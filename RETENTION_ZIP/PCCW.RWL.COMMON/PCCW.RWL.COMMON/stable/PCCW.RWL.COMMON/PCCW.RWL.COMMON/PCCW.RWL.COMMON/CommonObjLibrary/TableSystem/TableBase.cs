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
    public class TableBase<T>
    {
        protected string n_sDefaultOrderBy = string.Empty;
        #region DefaultOrderBy
        public string DefaultOrderBy
        {
            get
            {
                return this.n_sDefaultOrderBy;
            }
            set
            {
                this.n_sDefaultOrderBy = value;
            }
        }
        #endregion DefaultOrderBy
        protected string n_sHaving = string.Empty;
        #region Having
        public string Having
        {
            get
            {
                return this.n_sHaving;
            }
            set
            {
                this.n_sHaving = value;
            }
        }
        #endregion Having
        protected string n_sGroupBy = string.Empty;
        #region GroupBy
        public string GroupBy
        {
            get
            {
                return this.n_sGroupBy;
            }
            set
            {
                this.n_sGroupBy = value;
            }
        }
        #endregion GroupBy
        protected TableType n_oTableOfType = new TableType();
        #region TableOfType
        public TableType TableOfType
        {
            get
            {
                return this.n_oTableOfType;
            }
            set
            {
                this.n_oTableOfType = value;
            }
        }
        #endregion TableOfType
        protected string n_sDefaultFilter = string.Empty;
        #region DefaultFilter
        public string DefaultFilter
        {
            get
            {
                return this.n_sDefaultFilter;
            }
            set
            {
                this.n_sDefaultFilter = value;
            }
        }
        #endregion DefaultFilter
        protected int n_iCount = -1;
        #region Count
        public int Count
        {
            get
            {
                return this.n_iCount;
            }
            set
            {
                this.n_iCount = value;
            }
        }
        #endregion Count
        protected string n_sTableName = string.Empty;
        #region TableName
        public string TableName
        {
            get
            {
                return this.n_sTableName;
            }
            set
            {
                this.n_sTableName = value;
            }
        }
        #endregion TableName
        protected Dictionary<string, T> fieldlist;
        protected Dictionary<int, T> fieldlist_index;
        #region Constructor & Destructor
        public TableBase() { }
        #endregion Constructor & Destructor
        #region Get & Set
        public string GetDefaultOrderBy() { return this.DefaultOrderBy; }
        public string GetHaving() { return this.Having; }
        public string GetGroupBy() { return this.GroupBy; }
        public TableType GetTableOfType() { return this.TableOfType; }
        public string GetDefaultFilter() { return this.DefaultFilter; }
        public int GetCount() { return this.Count; }
        public string GetTableName() { return this.TableName; }
        public bool SetDefaultOrderBy(string value)
        {
            this.DefaultOrderBy = value;
            return true;
        }
        public bool SetHaving(string value)
        {
            this.Having = value;
            return true;
        }
        public bool SetGroupBy(string value)
        {
            this.GroupBy = value;
            return true;
        }
        public bool SetTableOfType(TableType value)
        {
            this.TableOfType = value;
            return true;
        }
        public bool SetDefaultFilter(string value)
        {
            this.DefaultFilter = value;
            return true;
        }
        public bool SetCount(int value)
        {
            this.Count = value;
            return true;
        }
        public bool SetTableName(string value)
        {
            this.TableName = value;
            return true;
        }
        #endregion

        public virtual void Add(string key, T field) { }
        #region Fields
        public virtual T Fields(int index)
        {
            return fieldlist_index[index];
        }
        public virtual T Fields(string key)
        {
            return fieldlist[key];
        }
        #endregion Fields

        #region Equals
        public bool Equals(TableBase<T> x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.DefaultOrderBy.Equals(x_oObj.DefaultOrderBy)) { return false; }
            if (!this.Having.Equals(x_oObj.Having)) { return false; }
            if (!this.GroupBy.Equals(x_oObj.GroupBy)) { return false; }
            if (!this.TableOfType.Equals(x_oObj.TableOfType)) { return false; }
            if (!this.DefaultFilter.Equals(x_oObj.DefaultFilter)) { return false; }
            if (!this.Count.Equals(x_oObj.Count)) { return false; }
            if (!this.TableName.Equals(x_oObj.TableName)) { return false; }
            return true;
        }
        #endregion Equals
        #region Release
        public void Release()
        {
            this.DefaultOrderBy = string.Empty;
            this.Having = string.Empty;
            this.GroupBy = string.Empty;
            this.TableOfType = new TableType();
            this.DefaultFilter = string.Empty;
            this.Count = -1;
            this.TableName = string.Empty;
            if (this.fieldlist != null) this.fieldlist.Clear();
            if (this.fieldlist_index != null) this.fieldlist_index.Clear();
        }
        #endregion Release
        #region Clone
        public TableBase<T> Clone()
        {
            TableBase<T> TableBase_Clone = new TableBase<T>();
            TableBase_Clone.SetDefaultOrderBy(this.DefaultOrderBy);
            TableBase_Clone.SetHaving(this.Having);
            TableBase_Clone.SetGroupBy(this.GroupBy);
            TableBase_Clone.SetTableOfType(this.TableOfType);
            TableBase_Clone.SetDefaultFilter(this.DefaultFilter);
            TableBase_Clone.SetCount(this.Count);
            TableBase_Clone.SetTableName(this.TableName);
            return TableBase_Clone;
        }
        #endregion Clone
    }
}

