using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class MobileRetentionOrderAddModifyScripts
    {
        private MobileRetentionOrderAddModifyScripts() { }

        private static MobileRetentionOrderAddModifyScripts _instance;

        public static MobileRetentionOrderAddModifyScripts Instance
        {
            get
            {
                if (MobileRetentionOrderAddModifyScripts._instance == null)
                    MobileRetentionOrderAddModifyScripts._instance = new MobileRetentionOrderAddModifyScripts();
                return MobileRetentionOrderAddModifyScripts._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.MobileRetentionOrderAddModifyScripts.js";
            }
        }
    }
}
