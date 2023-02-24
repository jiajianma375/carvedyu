using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CYCommon
{
    public class IviDeploy
    {
        /*!
         * @brief:      获取IVI_Deploy库版本号
         * @param:      null
         * @return:     版本号信息
         */
        public unsafe string GetVersion()
        {
            string veriosn_info = "";
            IntPtr process_output_addr = (IntPtr)0;     // 字符串指针
            var process_output_len = 0;                 // 字符串长度
            int ret = get_version((IntPtr)(&process_output_addr), (IntPtr)(&process_output_len));
            if (ret != 0) return veriosn_info;

            // 获取c接口返回的string字符串
            var retint = Marshal.ReadIntPtr((IntPtr)(&process_output_addr));
            int intBufLen = (int)Math.Ceiling((double)process_output_len * sizeof(Char) / sizeof(int));
            byte[] output_bytes = System.Text.Encoding.Unicode.GetBytes(Marshal.PtrToStringUni(retint, intBufLen));
            veriosn_info = System.Text.Encoding.UTF8.GetString(output_bytes);
            if (veriosn_info.Length > process_output_len) veriosn_info = veriosn_info.Remove(process_output_len);
            free_result(ref process_output_addr);
            return veriosn_info;
        }

        /*!
         * @brief:      IVI_Deploy实例初始化
         * @param:      [in]        param   算法配置参数, 配置文件路径(常用) 或 json格式的配置内容
         * @return:     状态码(0:成功; others:错误码)
         */
        public int Initialize(string initParam)
        {
            int[] init_state = { -1 };
            pHandler_ = initialize(initParam, initParam, init_state);
            return init_state[0];
        }

        /*!
         * @brief:      IVI_Deploy实例推理
         * @param:      [in]        input      输入数据, json格式字符串, 详见接口文档
         *              [out]       output     输出结果, json格式字符串, 详见接口文档
         * @return:     状态码(0:成功; others:错误码)
         */
        public unsafe int Process(string input, ref string output)
        {
            // 运行状态：process_state=0，成功；process_state=400，失败；
            int[] process_state = { -1 };
            IntPtr process_output_addr = (IntPtr)0;     // 字符串指针
            var process_output_len = 0;                 // 字符串长度
            int ret = process(pHandler_, input, input.Length, (IntPtr)(&process_output_addr), (IntPtr)(&process_output_len));
            if (ret != 0) return ret;                   // 推理错误，返回错误码

            // 获取c接口返回的string字符串
            var retint = Marshal.ReadIntPtr((IntPtr)(&process_output_addr));
            int intBufLen = (int)Math.Ceiling((double)process_output_len * sizeof(Char) / sizeof(int));
            byte[] output_bytes = System.Text.Encoding.Unicode.GetBytes(Marshal.PtrToStringUni(retint, intBufLen));
            output = System.Text.Encoding.UTF8.GetString(output_bytes);
            if (output.Length > process_output_len) output = output.Remove(process_output_len);
            free_result(ref process_output_addr);
            return 0;
        }

        /* 析构函数，析构时进行资源释放 */
        ~IviDeploy()
        {
            if (pHandler_ != IntPtr.Zero)
            {
                release(ref pHandler_);
                pHandler_ = IntPtr.Zero;
            }
        }

        // 模型实例指针
        private IntPtr pHandler_ = IntPtr.Zero;

        [DllImport(@"IVI_Deploy.dll", EntryPoint = "initialize")]
        static extern IntPtr initialize(string model_entry, string model_config, int[] state);

        [DllImport(@"IVI_Deploy.dll", EntryPoint = "process", CharSet = CharSet.Ansi)]
        static extern int process(IntPtr alog, string input_json, int input_size, IntPtr output, IntPtr output_size);

        [DllImport(@"IVI_Deploy.dll", EntryPoint = "get_version", CharSet = CharSet.Ansi)]
        static extern int get_version(IntPtr output, IntPtr output_size);

        [DllImport(@"IVI_Deploy.dll", EntryPoint = "release")]
        static extern int release(ref IntPtr alog);

        [DllImport(@"IVI_Deploy.dll", EntryPoint = "free_result")]
        static extern int free_result(ref IntPtr output);
    }
}
