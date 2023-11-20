using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
namespace PCCW.RWL.CORE{
    public class TableObj : TableBase<Field>
    {
        public TableObj()
        {
        }
        public virtual void Add(string key)
        {
            if (fieldlist == null) { fieldlist = new Dictionary<string, Field>(); }
            if (!fieldlist.ContainsKey(key))
                fieldlist.Add(key, new Field());
        }
        public virtual void Add(int key)
        {
            if (fieldlist_index == null) { fieldlist_index = new Dictionary<int, Field>(); }
            if (!fieldlist_index.ContainsKey(key))
                fieldlist_index.Add(key, new Field());
        }
        public virtual Field Fields(int index)
        {
            if (!fieldlist_index.ContainsKey(index))
                return null;
            return fieldlist_index[index];
        }
        public virtual Field Fields(string key)
        {
            if (!fieldlist.ContainsKey(key))
                return null;
            return fieldlist[key];
        }
    }
    
}

