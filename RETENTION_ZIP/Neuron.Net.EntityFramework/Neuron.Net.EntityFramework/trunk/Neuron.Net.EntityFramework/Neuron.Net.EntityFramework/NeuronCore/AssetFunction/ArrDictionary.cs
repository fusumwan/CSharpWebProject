using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Wed>
///-- Description:	<Description,Class :ArrDictionary, Data Access Object Control>
///-- =============================================
namespace NEURON.ENTITY.FRAMEWORK
{
    public class ArrDictionary : IDictionary
    {
        protected long n_lItemsInUse = -1;
        #region m_lItemsInUse
        protected long m_lItemsInUse
        {
            get
            {
                return this.n_lItemsInUse;
            }
            set
            {
                this.n_lItemsInUse = value;
            }
        }
        #endregion m_lItemsInUse


        protected DictionaryEntry[] n_oItems = null;
        #region m_oItems
        protected DictionaryEntry[] m_oItems
        {
            get
            {
                return this.n_oItems;
            }
            set
            {
                this.n_oItems = value;
            }
        }
        #endregion m_oItems


        #region Constructor & Destructor
        public ArrDictionary(long x_NumItems)
        {
            n_oItems = new DictionaryEntry[x_NumItems];
        }
        public ArrDictionary(long x_lItemsInUse, DictionaryEntry[] x_oItems)
        {
            m_lItemsInUse = x_lItemsInUse;
            m_oItems = x_oItems;
        }

        ~ArrDictionary() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public long GetItemsInUse() { return this.m_lItemsInUse; }
        public DictionaryEntry[] GetItems() { return this.m_oItems; }

        public bool SetItemsInUse(long value)
        {
            this.m_lItemsInUse = value;
            return true;
        }
        public bool SetItems(DictionaryEntry[] value)
        {
            this.m_oItems = value;
            return true;
        }
        #endregion

        #region IDictionary Members
        public bool IsReadOnly { get { return false; } }
        public bool Contains(object x_oKey)
        {
            long x_lIndex;
            return TryGetIndexOfKey(x_oKey, out x_lIndex);
        }
        public bool IsFixedSize { get { return false; } }
        public void Remove(object x_oKey)
        {
            if (x_oKey == null) throw new ArgumentNullException("key");
            long x_lIndex;
            if (TryGetIndexOfKey(x_oKey, out x_lIndex))
            {
                Array.Copy(n_oItems, x_lIndex + 1, n_oItems, x_lIndex, n_lItemsInUse - x_lIndex - 1);
                n_lItemsInUse--;
            }
            else
            {
                return;
            }
        }
        public void Clear() { n_lItemsInUse = 0; }
        public void Add(object x_oKey, object x_oValue)
        {
            if (n_lItemsInUse == n_oItems.Length)
                throw new InvalidOperationException("The dictionary cannot hold any more items.");
            n_oItems[n_lItemsInUse++] = new DictionaryEntry(x_oKey, x_oValue);
        }
        public ICollection Keys
        {
            get
            {
                Object[] _oKeys = new Object[n_lItemsInUse];
                for (long n = 0; n < n_lItemsInUse; n++)
                    _oKeys[n] = n_oItems[n].Key;
                return _oKeys;
            }
        }
        public ICollection Values
        {
            get
            {
                Object[] _oValues = new Object[n_lItemsInUse];
                for (long n = 0; n < n_lItemsInUse; n++)
                    _oValues[n] = n_oItems[n].Value;
                return _oValues;
            }
        }
        public object this[object x_oKey]
        {
            get
            {
                long x_lIndex;
                if (TryGetIndexOfKey(x_oKey, out x_lIndex))
                {
                    return n_oItems[x_lIndex].Value;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                long x_lIndex;
                if (TryGetIndexOfKey(x_oKey, out x_lIndex))
                {
                    n_oItems[x_lIndex].Value = value;
                }
                else
                {
                    Add(x_oKey, value);
                }
            }
        }
        private Boolean TryGetIndexOfKey(Object x_oKey, out long x_lIndex)
        {
            for (x_lIndex = 0; x_lIndex < n_lItemsInUse; x_lIndex++)
            {
                if (n_oItems[x_lIndex].Key.Equals(x_oKey)) return true;
            }
            return false;
        }
        private class ArrDictionaryEnumerator : IDictionaryEnumerator
        {
            DictionaryEntry[] n_oItems;
            long x_lIndex = -1;

            public ArrDictionaryEnumerator(ArrDictionary x_oSd)
            {
                n_oItems = new DictionaryEntry[x_oSd.Count];
                Array.Copy(x_oSd.GetItems(), 0, n_oItems, 0, x_oSd.Count);
            }

            public Object Current { get { ValidateIndex(); return n_oItems[x_lIndex]; } }
            public DictionaryEntry Entry{ get { return (DictionaryEntry)Current; }}
            public Object Key { get { ValidateIndex(); return n_oItems[x_lIndex].Key; } }
            public Object Value { get { ValidateIndex(); return n_oItems[x_lIndex].Value; } }
            public Boolean MoveNext(){
                if (x_lIndex < n_oItems.Length - 1) { x_lIndex++; return true; }
                return false;
            }

            private void ValidateIndex()
            {
                if (x_lIndex < 0 || x_lIndex >= n_oItems.Length)
                    throw new InvalidOperationException("Enumerator is before or after the collection.");
            }

            public void Reset()
            {
                x_lIndex = -1;
            }
        }
        public IDictionaryEnumerator GetEnumerator()
        {
            return new ArrDictionaryEnumerator(this);
        }
        #endregion

        #region ICollection Members
        public bool IsSynchronized { get { return false; } }
        public object SyncRoot { get { throw new NotImplementedException(); } }
        public int Count { get { return (Int32)n_lItemsInUse; } }
        public void CopyTo(Array x_oArray, int x_lIndex) { throw new NotImplementedException(); }
        #endregion

        #region IEnumerable Members
        IEnumerator IEnumerable.GetEnumerator(){
            return ((IDictionary)this).GetEnumerator();
        }
        #endregion

        #region Equals
        public bool Equals(ArrDictionary x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_lItemsInUse.Equals(x_oObj.m_lItemsInUse)) { return false; }
            if (!this.m_oItems.Equals(x_oObj.m_oItems)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_lItemsInUse = -1;
            this.m_oItems = null;
        }
        #endregion Release


        #region Clone
        public ArrDictionary Clone()
        {
            ArrDictionary ArrDictionary_Clone = new ArrDictionary(this.Count);
            ArrDictionary_Clone.SetItemsInUse(this.m_lItemsInUse);
            ArrDictionary_Clone.SetItems(this.m_oItems);
            return ArrDictionary_Clone;
        }
        #endregion Clone

    }
}
