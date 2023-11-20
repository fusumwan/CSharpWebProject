using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public class JS_LISTITEM
    {
        protected Dictionary<string, object> ItemSetting = null;

        protected string _Text = string.Empty;
        #region Text
        public string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                this._Text = value;
            }
        }
        #endregion

        protected string _Value = string.Empty;
        #region Value
        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                this._Value = value;
            }
        }
        #endregion

        public JSAttributes Attributes = new JSAttributes("LISTITEM", false);
        protected bool _Selected=false;
        public bool Selected
        {
            get
            {
                return _Selected;
            }
            set{
                if (this.Index >= 0)
                {
                    _Selected = value;
                    string Key = "Selected_" + Index.ToString();
                    if (!ItemSetting.ContainsKey(Key))
                        ItemSetting.Add("Selected_" + Index.ToString(), this);
                    else
                        ItemSetting["Selected_" + Index.ToString()] = this;
                }
            }
        }
        protected bool _Enabled = true;
        public bool Enabled
        {
            get
            {
                return _Enabled;
            }
            set
            {
                if (this.Index >= 0)
                {
                    _Enabled = value;
                    string Key = "ItemEnabled_" + Index.ToString();
                    if (!ItemSetting.ContainsKey(Key))
                        ItemSetting.Add("ItemEnabled_" + Index.ToString(), this);
                    else
                        ItemSetting["ItemEnabled_" + Index.ToString()] = this;
                }
            }
        }
        public int Index = -1;
        public JS_LISTITEM(string text, string value)
        {
            this.Text = text;
            this.Value = value;
        }

        public void SetItemSetting(ref Dictionary<string, object> x_oItemSetting)
        {
            ItemSetting = x_oItemSetting;
        }
    }
}