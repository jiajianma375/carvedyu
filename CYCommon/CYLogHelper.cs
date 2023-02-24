using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYCommon
{
    public class CYLogHelper
    {
        public static readonly log4net.ILog loginfo = log4net.LogManager.GetLogger("loginfo");
        public static readonly log4net.ILog logerror = log4net.LogManager.GetLogger("logerror");
        public static readonly log4net.ILog logmodule = log4net.LogManager.GetLogger("logmodule");
        public static void WriteLog(string info)
        {
            if (loginfo.IsInfoEnabled)
            {
                loginfo.Info(info);
            }
        }

        public static void WriteLog(string info, Exception ex)
        {
            if (logerror.IsErrorEnabled)
            {
                logerror.Error(info, ex);
            }
        }

        public static void WriteModuleLog(string info, Exception ex = null)
        {
            if (logmodule.IsErrorEnabled)
            {
                if (ex == null)
                {
                    logmodule.Info(info);
                }
                else
                {
                    logmodule.Error(info, ex);
                }

            }
        }

    }
}
