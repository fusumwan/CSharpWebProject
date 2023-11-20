using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class MobileRetentionOrderCreateScripts
    {
        private MobileRetentionOrderCreateScripts() { }

        private static MobileRetentionOrderCreateScripts _instance;

        public static MobileRetentionOrderCreateScripts Instance
        {
            get
            {
                if (MobileRetentionOrderCreateScripts._instance == null)
                    MobileRetentionOrderCreateScripts._instance = new MobileRetentionOrderCreateScripts();
                return MobileRetentionOrderCreateScripts._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.MobileRetentionOrderCreateScripts.js";
            }
        }
    }
}
