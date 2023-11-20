using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class PreviousOrderModifyScripts
    {
        private PreviousOrderModifyScripts() { }

        private static PreviousOrderModifyScripts _instance;

        public static PreviousOrderModifyScripts Instance
        {
            get
            {
                if (PreviousOrderModifyScripts._instance == null)
                    PreviousOrderModifyScripts._instance = new PreviousOrderModifyScripts();
                return PreviousOrderModifyScripts._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.PreviousOrderModifyScripts.js";
            }
        }
    }
}
