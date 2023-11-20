using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public class JSStyle
    {
        public string ID { get; set; }
        public bool isName { get; set; }
        protected Dictionary<string, object> ItemSetting = null;
        public Hashtable StyleSetting = new Hashtable();
        
        public string this[System.Web.UI.HtmlTextWriterStyle Key]
        {
            set
            {
                if (StyleSetting.ContainsKey(Key))
                    StyleSetting[Key] = value;
                else
                    StyleSetting.Add(Key, value);

                if (this.ItemSetting != null)
                {
                    int i = ItemSetting.Count;
                    bool bFlag = true;
                    while (bFlag){
                        string StyleKey="Style_" + i.ToString();
                        if (!ItemSetting.ContainsKey(StyleKey))
                        {
                            ItemSetting.Add(StyleKey, Key);
                            bFlag = false;
                        }
                        else
                            i += 1;
                    }
                }
            }
            get
            {
                if (StyleSetting.ContainsKey(Key))
                    return StyleSetting[Key].ToString();
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
                if (StyleSetting.ContainsKey(History[i]))
                {
                    if(!this.isName)
                        _oScript.AppendLine(RegisterJS.SetJSControlStyle(this.ID, History[i], StyleSetting[History[i]].ToString(), true, x_bIncludeScript));
                    else
                        _oScript.AppendLine(RegisterJS.SetJSControlNameStyle(this.ID, History[i], StyleSetting[History[i]].ToString(), true, x_bIncludeScript));
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

        

        public JSStyle(string x_sID,bool x_bIsName, ref Dictionary<string, object> x_oItemSetting)
        {
            this.ID = x_sID;
            this.isName = x_bIsName;
            this.ItemSetting = x_oItemSetting;
        }

        public JSStyle(string x_sID, bool x_bIsName)
        {
            this.ID = x_sID;
            this.isName = x_bIsName;
        }

        public void ClearHistory()
        {
            if (this.ItemSetting != null)
                this.ItemSetting.Clear();
        }
    }
}
