using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class Behavior
    {
        private Behavior() { }

        private static Behavior _instance;

        public static Behavior Instance
        {
            get
            {
                if (Behavior._instance == null)
                    Behavior._instance = new Behavior();
                return Behavior._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.Behavior.js";
            }
        }
    }
}
