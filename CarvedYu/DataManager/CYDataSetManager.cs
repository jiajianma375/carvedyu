using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarvedYu.DataManager
{
    public static class CYDataSetManager
    {
        /// <summary>
        /// 数据集集合，key = 数据集ID，value = 对应的数据集
        /// </summary>
        private static Dictionary<string, CYDataSet> m_DataSet = new Dictionary<string, CYDataSet>();

        public static void Init()
        {
            if(m_DataSet == null)
            {
                m_DataSet = new Dictionary<string, CYDataSet>();
            }
        }


        /// <summary>
        /// 添加一个数据集
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static bool AddDataSet(CYDataSet dataSet,out string error)
        {
            error = "";
            lock (m_DataSet)
            {
                foreach (var item in m_DataSet.Values)
                {
                    if (item.Name == dataSet.Name && item.SourceID == dataSet.SourceID)
                    {
                        error = "数据集名称重复";
                        return false;
                    }
                }
                m_DataSet.Add(dataSet.ID, dataSet);
            }
            return true;
        }
        /// <summary>
        /// 往数据集里添加图片
        /// </summary>
        /// <param name="dataSetId">数据集ID</param>
        /// <param name="imagePath">图片路径</param>
        /// <param name="error">错误信息</param>
        /// <returns></returns>
        public static bool AddDataSetImage(string dataSetId, string imagePath, out string error)
        {
            error = "";
            lock (m_DataSet)
            {
                if (m_DataSet.ContainsKey(dataSetId) == false)
                {
                    error = "数据集ID不存在";
                    return false;
                }
                var fileName = Path.GetFileName(imagePath);
                if (fileName == null || fileName == string.Empty)
                {
                    error = "图片路径异常";
                    return false;
                }
                if (m_DataSet[dataSetId].Images.ContainsKey(fileName))
                {
                    error = $"图片 {fileName} 已存在";
                    return false;
                }
                m_DataSet[dataSetId].Images.Add(fileName, new CYDataSetImageInfo() { SourcePath = imagePath,Name = fileName }) ;
                return true;
            }
        }
    }
    /// <summary>
    /// 数据集类
    /// </summary>
    public class CYDataSet
    {
        /// <summary>
        /// 数据集名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 数据集描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 数据集ID
        /// </summary>
        public string ID { get; private set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// 数据集关联到的输入源ID
        /// </summary>
        public string SourceID { get; set; }

        /// <summary>
        /// 该数据集创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 该数据集最后更新的时间
        /// </summary>
        public DateTime UpdateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 该数据集内的图片
        /// key = 带后缀不带路径的图片名称
        /// value = 该图片的信息
        /// </summary>
        public Dictionary<string, CYDataSetImageInfo> Images { get; set; }
        public CYDataSet() { }

    }

    /// <summary>
    /// 数据集内的图片信息
    /// </summary>
    public class CYDataSetImageInfo
    {
        /// <summary>
        /// 图片名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 该图片原始的完整路径
        /// </summary>
        public string SourcePath { get; set; }
        /// <summary>
        /// 该图片导入的时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
