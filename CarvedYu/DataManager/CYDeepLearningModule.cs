using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvedYu.DataManager
{
    public class CYDeepLearningModule : CYModule
    {
        public CYDeepLearningModule(ModuleType type) 
        {
            Type = type;
            Init();
        }

        public override int Init()
        {
            base.Init();

            
            return 0;
        }
    }
}
