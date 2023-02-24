using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedYu.DataManager
{
    public class CYModuleManager
    {
        /// <summary>
        /// key = 模块ID
        /// </summary>
        private static ConcurrentDictionary<string, CYModule> m_Modules = new ConcurrentDictionary<string, CYModule>();
        private static object lockModule = new object();

        /// <summary>
        /// 注册一个模块，注册失败返回错误信息
        /// </summary>
        /// <param name="module"></param>
        /// <param name="error">错误信息</param>
        /// <returns>成功 true 失败 false</returns>
        public static bool RegisterModule(CYModule module, out string error)
        {
            error = "";
            if (module == null)
                return false;

            if (m_Modules.ContainsKey(module.GetModuleID()))
            {
                error = $"{module.GetModuleID()} ID已经被注册";
                return false;
            }

            if (IsModuleName(module.Name) == true)
            {
                error = $"{module.Name} 名称已经被占用";
                return false;
            }
            lock (lockModule)
            {
                m_Modules.TryAdd(module.GetModuleID(), module);
            }


            return true;
        }
        /// <summary>
        /// 获取一个模块
        /// </summary>
        /// <param name="id">模块ID</param>
        /// <returns></returns>
        public static CYModule GetModule(string id)
        {
            lock (lockModule)
            {
                if (m_Modules.ContainsKey(id))
                    return m_Modules[id];
            }
            return null;
        }

        /// <summary>
        /// 销毁指定的模块
        /// </summary>
        public static void Destroy(string moduleID)
        {
            lock (lockModule)
            {
                if (moduleID == null)
                    return;
                if (m_Modules.ContainsKey(moduleID))
                {
                    //m_Modules[moduleID].Destroy();
                    m_Modules.TryRemove(moduleID, out CYModule module);

                    //module.Destroy();
                    module = null;
                }
            }
        }

        /// <summary>
        /// 判断模块名称是否已经被占用（非ID）
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsModuleName(string name)
        {
            lock (lockModule)
            {
                foreach (CYModule item in m_Modules.Values)
                {
                    if (item.Name == name)
                        return true;

                }
            }

            return false;
        }

        /// <summary>
        /// 获取所有模块的名称（非ID）
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllModuleName()
        {
            List<string> names = new List<string>();
            lock (lockModule)
            {
                foreach (var itme in m_Modules.Values)
                {
                    names.Add(itme.Name);
                }
            }
            return names;
        }

        /// <summary>
        /// 获取一个新模块的默认名称
        /// </summary>
        /// <param name="name">前缀名（相机、图像处理等）</param>
        /// <returns>返回（相机1、图像处理1等）</returns>
        public static string GetNewModuleName(string name)
        {
            var names = GetAllModuleName();
            //默认名称计算
            string defaultValue = name;
            if (names.Count == 0)
            {
                defaultValue += "1";
            }
            else
            {
                for (int i = 1; i <= names.Count + 1; i++)
                {
                    if (i == names.Count + 1)
                    {
                        defaultValue += i;
                        break;
                    }
                    string temp = defaultValue + i;
                    bool isName = false;
                    for (int j = 0; j < names.Count; j++)
                    {
                        if (temp == names[j])
                        {
                            isName = true;
                            break;
                        }
                    }

                    if (isName == false)
                    {
                        defaultValue = temp;
                        break;
                    }

                }
            }
            return defaultValue;
        }
    }
}
