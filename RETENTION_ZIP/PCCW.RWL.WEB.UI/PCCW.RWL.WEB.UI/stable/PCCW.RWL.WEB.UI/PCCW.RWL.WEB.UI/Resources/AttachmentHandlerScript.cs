using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.WEB.UI.Resources
{
    public class AttachmentHandlerScript
    {
        private AttachmentHandlerScript() { }

        private static AttachmentHandlerScript _instance;

        public static AttachmentHandlerScript Instance
        {
            get
            {
                if (AttachmentHandlerScript._instance == null)
                    AttachmentHandlerScript._instance = new AttachmentHandlerScript();
                return AttachmentHandlerScript._instance;
            }
        }

        public static string ResourceName
        {
            get
            {
                return "PCCW.RWL.WEB.UI.Resources.AttachmentHandlerScript.js";
            }
        }
    }
}
