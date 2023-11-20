using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PCCW.RWL.WEB.UI.Resources
{
    public class MobileOrderAddressUserControlJS
    {
        private MobileOrderAddressUserControlJS() { }

        private static MobileOrderAddressUserControlJS _instance;

        public static MobileOrderAddressUserControlJS Instance
        {
            get
            {
                if (MobileOrderAddressUserControlJS._instance == null)
                    MobileOrderAddressUserControlJS._instance = new MobileOrderAddressUserControlJS();
                return MobileOrderAddressUserControlJS._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.MobileOrderAddressUserControlJS.js";
            }
        }
    }
}
