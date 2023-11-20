using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public class JS_RADIO : IJSControl
    {
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

        protected int n_iSelectedIndex = 0;
        #region SelectedIndex
        public int SelectedIndex
        {
            set
            {
                n_iSelectedIndex = value;
                if (RunRegistorJS)
                {
                    if (ItemSetting.ContainsKey("SelectedIndex_"))
                        ItemSetting["SelectedIndex_"] = value;
                    else
                        ItemSetting.Add("SelectedIndex_", value);
                }
                if (n_iSelectedIndex >= 0 && n_iSelectedIndex < Items.Count)
                    Value = Items[n_iSelectedIndex].Value;
                else if(n_iSelectedIndex<0)
                    Value = string.Empty;
            }
            get
            {
                return n_iSelectedIndex;
            }
        }
        #endregion

        protected string n_sValue = string.Empty;
        public string Value
        {
            set
            {
                if (Items.FindByValue(value) != null)
                {
                    n_sValue = value;
                    if (n_sValue != null)
                    {
                        Items.AutoSetItemIndex();
                        if (RunRegistorJS)
                        {
                            if (ItemSetting.ContainsKey("Value_"))
                                ItemSetting["Value_"] = value;
                            else
                                ItemSetting.Add("Value_", value);
                        }
                        if (Items.Count > 0 && !n_sValue.Equals(string.Empty))
                            n_iSelectedIndex = Items.FindByValue(n_sValue).Index;
                        else
                            n_iSelectedIndex = 0;
                    }
                }
            }
            get
            {
                return n_sValue;
            }
        }

        #region SelectedValue
        public string SelectedValue
        {
            set
            {
                if (Items.FindByValue(value) != null)
                {
                    n_sValue = value;
                    if (n_sValue != null)
                    {
                        Items.AutoSetItemIndex();
                        if (RunRegistorJS)
                        {
                            if (ItemSetting.ContainsKey("Value_"))
                                ItemSetting["Value_"] = value;
                            else
                                ItemSetting.Add("Value_", value);
                        }
                        if (Items.Count > 0 && !n_sValue.Equals(string.Empty))
                            n_iSelectedIndex = Items.FindByValue(n_sValue).Index;
                        else
                            n_iSelectedIndex = 0;
                    }
                }
            }
            get
            {
                return n_sValue;
            }
        }
        #endregion

        protected bool n_bEnabled = true;
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

        public string Name = string.Empty;
        protected Dictionary<string, object> ItemSetting = new Dictionary<string, object>();
        public JS_LISTITEMCOLLECTION Items = null;
        public JS_RADIO(string x_sName, string x_sType)
        {
            if (string.IsNullOrEmpty(x_sName) || 
                string.IsNullOrEmpty(x_sType))
                throw new ArgumentNullException("Cannot New Object By Null/Empty Value");

            this.Name = x_sName;
            this.Type = x_sType;
            this.Style = new JSStyle(this.Name,true, ref ItemSetting);
            this.Attributes = new JSAttributes(this.Name, true, ref ItemSetting);
            this.Items = new JS_LISTITEMCOLLECTION(this.Name, ref ItemSetting);
        }

        public string ToScript(bool x_bClearHist, bool x_bIncludeScript)
        {
            if (string.IsNullOrEmpty(this.Name)) return string.Empty;
            if (this.Style == null) return string.Empty;
            if (this.Attributes == null) return string.Empty;
            if (this.ItemSetting == null) return string.Empty;
            if (this.ItemSetting.Count==0 && this.Attributes.GetHistoryCount() == 0 && this.Style.GetHistoryCount() == 0) return string.Empty;
            StringBuilder _oScript = new StringBuilder();
            string _sControlName = this.Name + "Js";

            if (x_bIncludeScript)
                _oScript.AppendLine("<script>");
            _oScript.AppendLine("var " + _sControlName + "=new JSHtmlRadio('" + this.Name + "');");
            if (x_bIncludeScript)
                _oScript.AppendLine("</script>");

            //_oScript.AppendLine(this.Style.ToScript(x_bClearHist, x_bIncludeScript));
            //_oScript.AppendLine(this.Attributes.ToScript(x_bClearHist, x_bIncludeScript));

            if (x_bIncludeScript)
                _oScript.AppendLine("<script>");
            foreach (KeyValuePair<string, object> _oItem in ItemSetting)
            {
                string ActionKey = JSScriptLibrary.ReadKey(_oItem.Key);
                switch (ActionKey)
                {
                    case "Value":
                        {
                            _oScript.AppendLine(_sControlName + ".SetItem(null,'" + this.Value.Replace("'", "\\'") + "',null,null);");
                        }
                        break;
                    case "Disabled":
                        {
                            bool Flag = (bool)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlNameAtt(this.Name, HtmlTextWriterAttribute.Disabled, ((Flag) ? "true" : "false"), false, false));
                        }
                        break;
                    case "Enabled":
                        {
                            bool Flag = (bool)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlNameAtt(this.Name, HtmlTextWriterAttribute.Disabled, ((Flag) ? "false" : "true"), false, false));
                        }
                        break;
                    case "SelectedIndex":
                        {
                            int Index = (int)_oItem.Value;
                            _oScript.AppendLine(_sControlName + ".SetItem(" + Index.ToString() + ",null,null,true);");
                        }
                        break;
                    case "Style":
                        {
                            HtmlTextWriterStyle Key = (HtmlTextWriterStyle)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlNameStyle(this.Name, Key, this.Style.StyleSetting[Key].ToString(), true, x_bIncludeScript));
                        }
                        break;
                    case "Attribute":
                        {
                            string Key = (string)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlNameAtt(this.Name, Key, this.Attributes.AttributeSetting[Key].ToString(), false, x_bIncludeScript));
                        }
                        break;
                }
            }
            if (x_bIncludeScript)
                _oScript.AppendLine("</script>");

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
