using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public  class JSAttributes
    {
        public string ID { get; set; }
        public bool isName { get; set; }
        public Hashtable AttributeSetting = new Hashtable();
        protected Dictionary<string, object> ItemSetting = null;
        public string this[System.Web.UI.HtmlTextWriterAttribute Key]
        {
            set
            {
                if (AttributeSetting.ContainsKey(Key.ToString().ToLower()))
                    AttributeSetting[Key.ToString().ToLower()] = value;
                else
                    AttributeSetting.Add(Key.ToString().ToLower(), value);

                if (this.ItemSetting != null)
                {
                    int i = ItemSetting.Count;
                    bool bFlag = true;
                    while (bFlag)
                    {
                        string StyleKey = "Attribute_" + i.ToString();
                        if (!ItemSetting.ContainsKey(StyleKey))
                        {
                            ItemSetting.Add(StyleKey, Key.ToString().ToLower());
                            bFlag = false;
                        }
                        else
                            i += 1;
                    }
                }
            }
            get
            {
                if (AttributeSetting.ContainsKey(Key.ToString().ToLower()))
                    return AttributeSetting[Key.ToString().ToLower()].ToString();
                return string.Empty;
            }
        }

        public string this[string Key]
        {
            set
            {
                if (AttributeSetting.ContainsKey(Key.ToLower()))
                    AttributeSetting[Key.ToLower()] = value;
                else
                    AttributeSetting.Add(Key.ToLower(), value);

                if (this.ItemSetting != null)
                {
                    int i = ItemSetting.Count;
                    bool bFlag = true;
                    while (bFlag)
                    {
                        string StyleKey = "Attribute_" + i.ToString();
                        if (!ItemSetting.ContainsKey(StyleKey))
                        {
                            ItemSetting.Add(StyleKey, Key.ToString().ToLower());
                            bFlag = false;
                        }
                        else
                            i += 1;
                    }
                }
            }
            get
            {
                if (AttributeSetting.ContainsKey(Key))
                    return AttributeSetting[Key].ToString();
                return string.Empty;
            }
        }

        /*
       public string ToScript()
        {
            return ToScript(true);
        }
        public string ToScript(bool x_bClearHist)
        {
            return ToScript(x_bClearHist, true);
        }
        public string ToScript(bool x_bClearHist, bool x_bIncludeScript)
        {
            if (string.IsNullOrEmpty(this.ID)) return string.Empty;
            StringBuilder _oScript = new StringBuilder();
            for (int i = 0; i < History.Count; i++)
            {
                if (AttributeSetting.ContainsKey(History[i]))
                {
                    if(!this.isName)
                        _oScript.AppendLine(RegisterJS.SetJSControlAtt(this.ID, History[i], AttributeSetting[History[i]].ToString(), false, x_bIncludeScript));
                    else
                        _oScript.AppendLine(RegisterJS.SetJSControlNameAtt(this.ID, History[i], AttributeSetting[History[i]].ToString(), false, x_bIncludeScript));
                }
            }
            if (x_bClearHist) History.Clear();
            return _oScript.ToString();
        }
        */

        public int GetHistoryCount()
        {
            return ItemSetting.Count;
        }

        public void ClearHistory()
        {
            if (this.ItemSetting != null)
                this.ItemSetting.Clear();
        }

        public JSAttributes(string x_sID, bool x_bIsName, ref Dictionary<string, object> x_oItemSetting)
        {
            this.ID = x_sID;
            this.isName = x_bIsName;
            this.ItemSetting = x_oItemSetting;
        }

        public JSAttributes(string x_sID, bool x_bIsName)
        {
            this.ID = x_sID;
            this.isName = x_bIsName;
        }
    }
}
