using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedYu.DataManager
{
    public class CYModule
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        protected string m_Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// 该模块关联的数据集ID
        /// key = 前置模块ID
        /// value = 数据集ID
        /// </summary>
        protected Dictionary<string, List<string>> m_dataSet;

        /// <summary>
        /// 模块的创建时间
        /// </summary>
        protected DateTime m_CreateTime = DateTime.Now;

        /// <summary>
        /// 模块的名称
        /// </summary>
        public string Name { get;  set; }
        /// <summary>
        /// 模块的类型
        /// </summary>
        public ModuleType Type { get;protected set; }

        public CYModule()
        {
            Init();
        }
        /// <summary>
        /// 模块初始化 0 = 成功
        /// </summary>
        public virtual int Init()
        {
            if(m_dataSet == null)
                m_dataSet = new Dictionary<string, List<string>>();
            return 0;
        }

        /// <summary>
        /// 获取该模块的ID
        /// </summary>
        /// <returns></returns>
        public string GetModuleID()
        {
            return m_Id;
        }
    }

    public enum ModuleType
    {
        /// <summary>
        /// 输入
        /// </summary>
        InputModule = 1,
        /// <summary>
        /// 结果输出
        /// </summary>
        OutputModule = 2,
        /// <summary>
        /// 语义分割
        /// </summary>
        DeepLearningSemModule = 4,
        /// <summary>
        /// 分类
        /// </summary>
        DeepLearningClsModule = 8,
        /// <summary>
        /// 目标检测
        /// </summary>
        DeepLearningDetModule = 16,
        /// <summary>
        /// 用户脚本模块
        /// </summary>
        UserScript = 32,
        /// <summary>
        /// 实例分割
        /// </summary>
        DeepLearningInsModule = 64,
        /// <summary>
        /// 结果融合
        /// </summary>
        CrossCategoryNms = 128
    }
}
