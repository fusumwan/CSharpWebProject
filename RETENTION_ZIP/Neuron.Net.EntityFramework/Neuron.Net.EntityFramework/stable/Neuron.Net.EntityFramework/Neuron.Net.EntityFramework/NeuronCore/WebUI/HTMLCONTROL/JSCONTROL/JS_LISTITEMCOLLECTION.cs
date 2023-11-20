using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public sealed class JS_LISTITEMCOLLECTION
    {
        public bool IsRadio = false;
        protected Dictionary<string, object> ItemSetting = null;
        List<JS_LISTITEM> ListCollection = null;
        public int Count {
            get
            {
                if (ListCollection != null)
                    return ListCollection.Count;
                return 0;
            }
        }
        public JS_LISTITEM this[int index] {
            get
            {
                if(index>=0 && index<ListCollection.Count){
                    this.ListCollection[index].Index = index;
                    return this.ListCollection[index];
                }
                return new JS_LISTITEM(string.Empty, string.Empty);
            }
        }

        public string Id = string.Empty;
        public JS_LISTITEMCOLLECTION(string ID, ref Dictionary<string, object> Setting)
        {
            this.Id = ID;
            this.ItemSetting = Setting;
            ListCollection = new List<JS_LISTITEM>();
        }

        public void Add(JS_LISTITEM item)
        {
            item.SetItemSetting(ref this.ItemSetting);
            ListCollection.Add(item);
            if (!IsRadio)
            {
                string Key = "Add_" + ListCollection.Count.ToString();
                if (!ItemSetting.ContainsKey(Key))
                    ItemSetting.Add("Add_" + ListCollection.Count.ToString(), item);
            }
        }

        public void Clear()
        {
            ListCollection.Clear();
            if (!IsRadio)
            {
                string Key = "Clear_" + ListCollection.Count.ToString();
                if (!ItemSetting.ContainsKey(Key))
                    ItemSetting.Add("Clear_" + ListCollection.Count.ToString(), "Clear");
            }
        }

        public void RemoveAt(int index)
        {
            ListCollection.RemoveAt(index);
            if (!IsRadio)
            {
                string Key = "RemoveAt_" + ListCollection.Count.ToString();
                if (!ItemSetting.ContainsKey(Key) && index < ListCollection.Count)
                {
                    ItemSetting.Add("RemoveAt", index);
                    ListCollection.RemoveAt(index);
                }
            }
        }

        public void Remove(JS_LISTITEM Item)
        {
            this.Remove(Item.Text, Item.Value);
        }

        public void Remove(string text, string value)
        {
            JS_LISTITEM Item = this.FindByTextValue(text, value);
            if (Item != null)
            {
                string Key = "Remove_" + ListCollection.Count.ToString();
                if (!ItemSetting.ContainsKey(Key))
                {
                    if (!IsRadio) { ItemSetting.Add("Remove", Item); }
                    for (int i = 0; i < ListCollection.Count; i++)
                    {
                        if (ListCollection[i].Text == Item.Text && ListCollection[i].Value == Item.Value)
                        {
                            ListCollection.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        public bool Contains(JS_LISTITEM item)
        {
            return ListCollection.Contains(item);
        }

        public JS_LISTITEM FindByText(string text)
        {
            for (int i = 0; i < ListCollection.Count; i++)
            {
                if (ListCollection[i].Text.Equals(text)){
                    return ListCollection[i];
                }
            }
            return null;
        }

        public void AutoSetItemIndex()
        {
            for (int i = 0; i < ListCollection.Count; i++)
            {
                ListCollection[i].Index = i;
            }
        }

        public JS_LISTITEM FindByValue(string value)
        {
            for (int i = 0; i < ListCollection.Count; i++)
            {
                if (ListCollection[i].Value.Equals(value))
                    return ListCollection[i];
            }
            return null;
        }

        public JS_LISTITEM FindByTextValue(string text, string value)
        {
            List<JS_LISTITEM> FindResult = new List<JS_LISTITEM>();
            
            for (int i = 0; i < ListCollection.Count; i++)
            {
                if (ListCollection[i].Text.Equals(text) && ListCollection[i].Value.Equals(value))
                {
                    ListCollection[i].Index = i;
                    FindResult.Add(ListCollection[i]);
                }
            }
            if (FindResult.Count > 0)
                return FindResult[0];
            return null;
        }
    }
}