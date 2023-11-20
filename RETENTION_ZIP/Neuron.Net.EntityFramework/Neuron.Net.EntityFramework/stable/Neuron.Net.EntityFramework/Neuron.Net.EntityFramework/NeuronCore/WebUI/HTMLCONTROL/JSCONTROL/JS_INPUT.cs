using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public class JS_INPUT : IJSControl
    {
        protected Dictionary<string, object> ItemSetting = new Dictionary<string, object>();
        public JSStyle Style = null;
        public JSAttributes Attributes = null;
        public string Type = string.Empty;

        protected bool n_bRunRegistorJS = true;
        #region RunRegistorJS
        public bool RunRegistorJS
        {
            get
            {
                return n_bRunRegistorJS;
            }
            set
            {
                this.n_bRunRegistorJS = value;
            }
        }
        #endregion

        protected string n_sValue = string.Empty;
        #region Value
        public string Value
        {
            set
            {
                n_sValue = value;
                if (RunRegistorJS)
                {
                    if (!ItemSetting.ContainsKey("Value_"))
                        ItemSetting.Add("Value_", value);
                    else
                        ItemSetting["Value_"] = value;
                }
            }
            get
            {
                return n_sValue;
            }
        }
        #endregion

        protected bool n_bChecked = false;
        #region Checked
        public bool Checked
        {
            set
            {
                n_bChecked = value;
                if (RunRegistorJS)
                {
                    if (!ItemSetting.ContainsKey("Checked_"))
                        ItemSetting.Add("Checked_", value);
                    else
                        ItemSetting["Checked_"] = value;
                }
            }
            get
            {
                return n_bChecked;
            }
        }
        #endregion

        protected bool n_bDisabled = false;
        #region Disabled
        public bool Disabled
        {
            set
            {
                n_bDisabled = value;
                n_bEnabled = !value;
                if (RunRegistorJS)
                {
                    if (!ItemSetting.ContainsKey("Disabled_"))
                        ItemSetting.Add("Disabled_", value);
                    else
                        ItemSetting["Disabled_"] = value;
                }
            }
            get
            {
                return n_bDisabled;
            }
        }
        #endregion

        protected bool n_bEnabled = false;
        #region Enabled
        public bool Enabled
        {
            set
            {
                n_bEnabled = value;
                n_bDisabled = !value;
                if (RunRegistorJS)
                {
                    if (!ItemSetting.ContainsKey("Enabled_"))
                        ItemSetting.Add("Enabled_", value);
                    else
                        ItemSetting["Enabled_"] = value;
                }
            }
            get
            {
                return n_bEnabled;
            }
        }
        #endregion

        public string ID = string.Empty;

        public JS_INPUT(string x_sID, string x_sType)
        {
            if (string.IsNullOrEmpty(x_sID) || string.IsNullOrEmpty(x_sType))
            {
                throw new ArgumentNullException("Cannot New Object By Null/Empty Value");
            }
            this.ID = x_sID;
            this.Type = x_sType;
            this.Style = new JSStyle(this.ID, false, ref ItemSetting);
            this.Attributes = new JSAttributes(this.ID, false, ref ItemSetting);
        }

        public string ToScript(bool x_bClearHist, bool x_bIncludeScript)
        {
            if (string.IsNullOrEmpty(this.ID)) return string.Empty;
            if (this.Style == null) return string.Empty;
            if (this.Attributes == null) return string.Empty;
            if (this.ItemSetting == null) return string.Empty;
            if (this.ItemSetting.Count == 0 && this.Attributes.GetHistoryCount() == 0 && this.Style.GetHistoryCount() == 0) return string.Empty;
            StringBuilder _oScript = new StringBuilder();
            if (x_bIncludeScript)
                _oScript.AppendLine("<script>");
            foreach (KeyValuePair<string, object> _oItem in ItemSetting)
            {
                string ActionKey = JSScriptLibrary.ReadKey(_oItem.Key);
                switch (ActionKey)
                {
                    case "Value":
                        {
                            _oScript.AppendLine(RegisterJS.SetJSControlValue(this.ID, this.Value, true, false));
                        }
                        break;
                    case "Checked":
                        {
                            bool Checked = (bool)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlAtt(this.ID, HtmlTextWriterAttribute.Checked, ((Checked) ? "true" : "false"), false, false));
                        }
                        break;
                    case "Disabled":
                        {
                            bool Disabled = (bool)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlAtt(this.ID, HtmlTextWriterAttribute.Disabled, ((Disabled)?"true":"false"), false, false));
                        }
                        break;
                    case "Enabled":
                        {
                            bool Flag = (bool)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlAtt(this.ID, HtmlTextWriterAttribute.Disabled, ((Flag) ? "false" : "true"), false, false));
                        }
                        break;
                    case "Style":
                        {
                            HtmlTextWriterStyle Key = (HtmlTextWriterStyle)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlStyle(this.ID, Key, this.Style.StyleSetting[Key].ToString(), true, x_bIncludeScript));
                        }
                        break;
                    case "Attribute":
                        {
                            string Key = (string)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlAtt(this.ID, Key, this.Attributes.AttributeSetting[Key].ToString(), false, x_bIncludeScript));
                        }
                        break;
                }
            }
            if (x_bIncludeScript)
                _oScript.AppendLine("</script>");

            //_oScript.AppendLine(this.Style.ToScript(x_bClearHist, x_bIncludeScript));
            //_oScript.AppendLine(this.Attributes.ToScript(x_bClearHist, x_bIncludeScript));
            //_oScript.AppendLine(RegisterJS.SetJSControlValue(this.ID, this.Value, true, x_bIncludeScript));

            if (x_bClearHist)
            {
                this.ItemSetting.Clear();
                this.Style.ClearHistory();
                this.Attributes.ClearHistory();
            }
            return _oScript.ToString();
        }
        public string ToScript(bool x_bClearHist)
        {
            return ToScript(x_bClearHist, true);
        }

        public string ToScript()
        {
            return this.ToScript(true);
        }
    }
}
