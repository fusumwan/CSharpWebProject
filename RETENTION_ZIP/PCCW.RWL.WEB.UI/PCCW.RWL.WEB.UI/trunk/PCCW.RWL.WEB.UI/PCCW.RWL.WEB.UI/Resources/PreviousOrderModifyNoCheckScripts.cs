using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class PreviousOrderModifyNoCheckScripts
    {
        private PreviousOrderModifyNoCheckScripts() { }

        private static PreviousOrderModifyNoCheckScripts _instance;

        public static PreviousOrderModifyNoCheckScripts Instance
        {
            get
            {
                if (PreviousOrderModifyNoCheckScripts._instance == null)
                    PreviousOrderModifyNoCheckScripts._instance = new PreviousOrderModifyNoCheckScripts();
                return PreviousOrderModifyNoCheckScripts._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.PreviousOrderModifyNoCheckScripts.js";
            }
        }
    }
}
