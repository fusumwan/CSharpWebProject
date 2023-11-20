using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-07>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by PHILIP FU in 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================
/// <summary>
/// Summary description for RWLScriptManager
/// </summary>
/// 
namespace NEURON.WEB.UI
{
    public class RWLScriptManager
    {
        Page n_oPage;
        public RWLScriptManager(Page x_oPage)
        {
            this.n_oPage = x_oPage;
        }

        private string ParserMessage(string x_sMessage)
        {
            string _sMessage = null;

            _sMessage = x_sMessage.Replace("'", "\\'");

            _sMessage = _sMessage.Replace("\n", "\\n");

            return _sMessage;
        }


        public string GetConfirmScript(string x_sMessage)
        {
            string _sMessage = null;
            string _sScript = null;

            _sMessage = ParserMessage(x_sMessage);
            _sScript = string.Format("if (confirm('{0}')==false) {{return false;}}", _sMessage);
            return _sScript;
        }


        public string GetConfirmScript(string x_sMessage, string x_sTrueScript, string x_sFalseScript)
        {
            string _sMessage = null;
            string _sScript = null;

            _sMessage = ParserMessage(x_sMessage);
            _sScript = string.Format("if (confirm('{0}')){{ {1} }} else {{ {2} }}", x_sMessage, x_sTrueScript, x_sFalseScript);
            return _sScript;
        }


        public void Confirm(string x_sMessage, string x_sTrueScript, string x_sFalseScript)
        {
            string _sScript = null;

            _sScript = GetConfirmScript(x_sMessage, x_sTrueScript, x_sFalseScript);
            n_oPage.RegisterStartupScript("Confirm", _sScript);
        }

    }
}