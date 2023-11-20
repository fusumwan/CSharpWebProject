using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public class JS_SELECT : IJSControl
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
                if (Items.Count >= 0)
                {
                    if (value >= 0)
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
                        {
                            n_sValue = Items[n_iSelectedIndex].Value;
                        }
                    }
                }
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

        protected bool n_bEnabled= true;
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
                n_bEnabled=!value;
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

        public string ID = string.Empty;
        protected Dictionary<string, object> ItemSetting = new Dictionary<string, object>();
        public JS_LISTITEMCOLLECTION Items = null;

        public JS_SELECT(string x_sID, string x_sType)
        {
            if (string.IsNullOrEmpty(x_sID) || 
                string.IsNullOrEmpty(x_sType))
                throw new ArgumentNullException("Cannot New Object By Null/Empty Value");

            this.ID = x_sID;
            this.Type = x_sType;
            this.Style = new JSStyle(this.ID, false, ref ItemSetting);
            this.Attributes = new JSAttributes(this.ID, false, ref ItemSetting);
            this.Items = new JS_LISTITEMCOLLECTION(this.ID, ref ItemSetting);
        }


        

        public string ToScript(bool x_bClearHist, bool x_bIncludeScript)
        {
            if (string.IsNullOrEmpty(this.ID)) return string.Empty;
            if (this.Style == null) return string.Empty;
            if (this.Attributes == null) return string.Empty;
            if (this.ItemSetting == null) return string.Empty;
            if (this.ItemSetting.Count == 0 && this.Attributes.GetHistoryCount() == 0 && this.Style.GetHistoryCount() == 0) return string.Empty;
            StringBuilder _oScript = new StringBuilder();
            string _sControlName = this.ID + "Js";
            
            if(x_bIncludeScript)
                _oScript.AppendLine("<script>");
            _oScript.AppendLine("var " + _sControlName + "=new JSHtmlSelect('" + this.ID + "');");
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
                    case "Add":
                        {
                            JS_LISTITEM _oListItem = (JS_LISTITEM)_oItem.Value;
                            _oScript.AppendLine(_sControlName + ".AddItem('" + _oListItem.Text.Replace("'", "\\'") + "','" + _oListItem.Value.Replace("'", "\\'") + "');");
                        }
                        break;
                    case "Clear":
                        {
                            _oScript.AppendLine(_sControlName + ".ItemClear();");
                        }
                        break;
                    case "RemoveAt":
                        {
                            int index = (int)_oItem.Value;
                            _oScript.AppendLine(_sControlName + ".RemoveAt(" + index.ToString() + ");");
                        }
                        break;
                    case "Remove":
                        {
                            JS_LISTITEM _oListItem = (JS_LISTITEM)_oItem.Value;
                            _oScript.AppendLine(_sControlName + ".Remove('" + _oListItem.Text.Replace("'", "\\'") + "','" + _oListItem.Value.Replace("'", "\\'") + "' );");
                        }
                        break;
                    case "Value":
                        {
                            _oScript.AppendLine(RegisterJS.SetJSControlValue(this.ID, this.Value, true, false));
                        }
                        break;
                    case "Selected":
                        {
                            JS_LISTITEM _oListItem = (JS_LISTITEM)_oItem.Value;
                            _oScript.AppendLine(_sControlName + ".SetItem(" + _oListItem.Index.ToString() + ",null,null,null,"  + ((_oListItem.Selected)?"true":"false")  +   ");");
                        }
                        break;
                    case "ItemEnabled":
                        {
                            JS_LISTITEM _oListItem = (JS_LISTITEM)_oItem.Value;
                            _oScript.AppendLine(_sControlName + ".SetItem(" + _oListItem.Index.ToString() + ",null,null," + ((_oListItem.Enabled) ? "false" : "true") + ",null);");
                        }
                        break;
                    case "Disabled":
                        {
                            bool Flag = (bool)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlAtt(this.ID, HtmlTextWriterAttribute.Disabled, ((Flag) ? "true" : "false"), false, false));
                        }
                        break;
                    case "Enabled":
                        {
                            bool Flag = (bool)_oItem.Value;
                            _oScript.AppendLine(RegisterJS.SetJSControlAtt(this.ID, HtmlTextWriterAttribute.Disabled, ((Flag) ? "false" : "true"), false, false));
                        }
                        break;
                    case "SelectedIndex":
                        {
                            int Index = (int)_oItem.Value;
                            _oScript.AppendLine(_sControlName + ".SetItem(" + Index.ToString() + ",null,null,null,true);");
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
