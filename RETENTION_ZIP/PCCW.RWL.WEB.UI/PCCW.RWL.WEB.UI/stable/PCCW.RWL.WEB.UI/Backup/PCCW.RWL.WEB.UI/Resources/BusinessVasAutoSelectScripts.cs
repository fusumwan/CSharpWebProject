using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class BusinessVasAutoSelectScripts
    {
        private BusinessVasAutoSelectScripts() { }

        private static BusinessVasAutoSelectScripts _instance;

        public static BusinessVasAutoSelectScripts Instance
        {
            get
            {
                if (BusinessVasAutoSelectScripts._instance == null)
                    BusinessVasAutoSelectScripts._instance = new BusinessVasAutoSelectScripts();
                return BusinessVasAutoSelectScripts._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.BusinessVasAutoSelectScripts.js";
            }
        }
    }
}
