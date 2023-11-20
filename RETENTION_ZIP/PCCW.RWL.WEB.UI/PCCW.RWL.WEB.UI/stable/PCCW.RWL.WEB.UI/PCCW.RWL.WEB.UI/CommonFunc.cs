using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCCW.RWL.WEB.UI
{
    public class CommonFunc
    {
        #region Set HtmlControl Style By Javascript
        public static void SetHtmlControlStyle(Control x_oControl,string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr)
        {
            Random ran = new Random();
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("<script>document.getElementById('{0}').style.{1}='{2}';</script>", x_sID, x_oStyle.ToString().ToLower(), x_sValue);
            else
                _sScript = string.Format("<script>document.getElementById('{0}').style.{1}={2};</script>", x_sID, x_oStyle.ToString().ToLower(), x_sValue);

            ScriptManager.RegisterStartupScript(x_oControl, x_oControl.GetType(), x_sID + (new Random()).Next(1, 1000).ToString(), _sScript, false);
        }
        #endregion

        #region Set HtmlContorl Attributes By Javascript
        public static void SetHtmlControlAtt(Control x_oControl, string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr)
        {
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("<script>document.getElementById('{0}').{1}='{2}';</script>", x_sID, x_oAtt.ToString().ToLower(), x_sValue);
            else
                _sScript = string.Format("<script>document.getElementById('{0}').{1}={2};</script>", x_sID, x_oAtt.ToString().ToLower(), x_sValue);

            ScriptManager.RegisterStartupScript(x_oControl, x_oControl.GetType(), x_sID + (new Random()).Next(1, 1000).ToString(), _sScript, false);
        }
        #endregion

        #region Set HtmlContorl Value By Javascript
        public static void SetHtmlControlValue(Control x_oControl, string x_sID, string x_sValue, bool x_bStr)
        {
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("<script>document.getElementById('{0}').value='{1}';</script>", x_sID, x_sValue);
            else
                _sScript = string.Format("<script>document.getElementById('{0}').value={1};</script>", x_sID, x_sValue);

            ScriptManager.RegisterStartupScript(x_oControl, x_oControl.GetType(), x_sID + (new Random()).Next(1, 1000).ToString(), _sScript, false);
        }
        #endregion

        #region Run Javascript Function
        public static void RunJavascriptFunc(Control x_oControl, string x_sFunc)
        {
            string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
            ScriptManager.RegisterStartupScript(x_oControl, x_oControl.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString(), string.Format("<script>{0}</script>", _sFunc), false);
        }
        #endregion

        #region RegisterJavaScript
        public static void RegisterJavaScript(Control x_oControl,string x_sID, string x_sScript, bool x_bIncludeScript)
        {
            if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
            ScriptManager.RegisterStartupScript(x_oControl, x_oControl.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
        }
        #endregion
    }
}
