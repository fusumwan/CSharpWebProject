using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class LogicScript
    {
        private LogicScript() { }

        private static LogicScript _instance;

        public static LogicScript Instance
        {
            get
            {
                if (LogicScript._instance == null)
                    LogicScript._instance = new LogicScript();
                return LogicScript._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.LogicScript.js";
            }
        }
    }
}
