using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedYu.DataManager
{
    public class CYProjectManager
    {
        private static Dictionary<string,CYProject> Projects { get; set; } = new Dictionary<string, CYProject>();

        public static bool AddProject(CYProject project)
        {
            lock(Projects)
            {
                Projects.Add(project.ID,project);
            }
            
            return true;
        }

        public static bool RemoveProject(CYProject project)
        {
            lock(Projects)
            {
                Projects.Remove(project.ID);
            }
            return true;
        }

        public static CYProject GetProject(string id)
        {
            lock(Projects)
            {
                if(Projects.ContainsKey(id))
                    return Projects[id];
            }
            return null;
        }
    }

    /// <summary>
    /// 工程配置
    /// </summary>
    public class CYProject
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// 最后的运行时间
        /// </summary>
        public DateTime LastRunTime { get; set; } = DateTime.Now;
        /// <summary>
        /// 最后的更新时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; } = DateTime.Now;
        public CYProject() { }


    }
}
