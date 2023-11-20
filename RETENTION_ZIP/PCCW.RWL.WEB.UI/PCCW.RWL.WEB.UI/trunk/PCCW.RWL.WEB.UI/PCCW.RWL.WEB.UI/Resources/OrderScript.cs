using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class OrderScript
    {
        private OrderScript() { }

        private static OrderScript _instance;

        public static OrderScript Instance
        {
            get
            {
                if (OrderScript._instance == null)
                    OrderScript._instance = new OrderScript();
                return OrderScript._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.OrderScript.js";
            }
        }
    }
}
