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
    
    public class FieldBase{

        protected bool n_bIsList = false;
        #region IsList
        public bool IsList
        {
            get
            {
                return this.n_bIsList;
            }
            set
            {
                this.n_bIsList = value;
            }
        }
        #endregion IsList


        protected bool n_bIsNullable = false;
        #region IsNullable
        public bool IsNullable
        {
            get
            {
                return this.n_bIsNullable;
            }
            set
            {
                this.n_bIsNullable = value;
            }
        }
        #endregion IsNullable


        protected bool n_bIsView = false;
        #region IsView
        public bool IsView
        {
            get
            {
                return this.n_bIsView;
            }
            set
            {
                this.n_bIsView = value;
            }
        }
        #endregion IsView


        protected bool n_bIsSearch = false;
        #region IsSearch
        public bool IsSearch
        {
            get
            {
                return this.n_bIsSearch;
            }
            set
            {
                this.n_bIsSearch = value;
            }
        }
        #endregion IsSearch


        protected bool n_bIsEdit = false;
        #region IsEdit
        public bool IsEdit
        {
            get
            {
                return this.n_bIsEdit;
            }
            set
            {
                this.n_bIsEdit = value;
            }
        }
        #endregion IsEdit


        protected string n_sParameterName = string.Empty;
        #region ParameterName
        public string ParameterName
        {
            get
            {
                return this.n_sParameterName;
            }
            set
            {
                this.n_sParameterName = value;
            }
        }
        #endregion ParameterName


        protected string n_sAliasName = string.Empty;
        #region AliasName
        public string AliasName
        {
            get
            {
                return this.n_sAliasName;
            }
            set
            {
                this.n_sAliasName = value;
            }
        }
        #endregion AliasName


        protected bool n_bGenSql = false;
        #region GenSql
        public bool GenSql
        {
            get
            {
                return this.n_bGenSql;
            }
            set
            {
                this.n_bGenSql = value;
            }
        }
        #endregion GenSql


        protected string n_sSqlDataType = string.Empty;
        #region SqlDataType
        public string SqlDataType
        {
            get
            {
                return this.n_sSqlDataType;
            }
            set
            {
                this.n_sSqlDataType = value;
            }
        }
        #endregion SqlDataType


        protected string n_sFieldVar = string.Empty;
        #region FieldVar
        public string FieldVar
        {
            get
            {
                return this.n_sFieldVar;
            }
            set
            {
                this.n_sFieldVar = value;
            }
        }
        #endregion FieldVar


        protected string n_sQuoteStart = string.Empty;
        #region QuoteStart
        public string QuoteStart
        {
            get
            {
                return this.n_sQuoteStart;
            }
            set
            {
                this.n_sQuoteStart = value;
            }
        }
        #endregion QuoteStart


        protected bool n_bIsDelete = false;
        #region IsDelete
        public bool IsDelete
        {
            get
            {
                return this.n_bIsDelete;
            }
            set
            {
                this.n_bIsDelete = value;
            }
        }
        #endregion IsDelete


        protected bool n_bIsAdd = false;
        #region IsAdd
        public bool IsAdd
        {
            get
            {
                return this.n_bIsAdd;
            }
            set
            {
                this.n_bIsAdd = value;
            }
        }
        #endregion IsAdd


        protected bool n_bIsGenerateToSql = false;
        #region IsGenerateToSql
        public bool IsGenerateToSql
        {
            get
            {
                return this.n_bIsGenerateToSql;
            }
            set
            {
                this.n_bIsGenerateToSql = value;
            }
        }
        #endregion IsGenerateToSql


        protected bool n_bIsRegister = false;
        #region IsRegister
        public bool IsRegister
        {
            get
            {
                return this.n_bIsRegister;
            }
            set
            {
                this.n_bIsRegister = value;
            }
        }
        #endregion IsRegister


        protected bool n_bIsIdentityKey = false;
        #region IsIdentityKey
        public bool IsIdentityKey
        {
            get
            {
                return this.n_bIsIdentityKey;
            }
            set
            {
                this.n_bIsIdentityKey = value;
            }
        }
        #endregion IsIdentityKey

        protected bool n_bIsPrimaryKey = false;
        #region IsPrimaryKey
        public bool IsPrimaryKey
        {
            get
            {
                return this.n_bIsPrimaryKey;
            }
            set
            {
                this.n_bIsPrimaryKey = value;
            }
        }
        #endregion IsPrimaryKey

        protected bool n_bIsUniqueKey = false;
        #region IsUniqueKey
        public bool IsUniqueKey
        {
            get
            {
                return this.n_bIsUniqueKey;
            }
            set
            {
                this.n_bIsUniqueKey = value;
            }
        }
        #endregion IsUniqueKey


        protected bool n_bIsAutoIncrement = false;
        #region IsAutoIncrement
        public bool IsAutoIncrement
        {
            get
            {
                return this.n_bIsAutoIncrement;
            }
            set
            {
                this.n_bIsAutoIncrement = value;
            }
        }
        #endregion IsAutoIncrement


        protected int n_iSize = -1;
        #region Size
        public int Size
        {
            get
            {
                return this.n_iSize;
            }
            set
            {
                this.n_iSize = value;
            }
        }
        #endregion Size


        protected string n_sFieldName = string.Empty;
        #region FieldName
        public string FieldName
        {
            get
            {
                return this.n_sFieldName;
            }
            set
            {
                this.n_sFieldName = value;
            }
        }
        #endregion FieldName


        protected string n_sFieldType = string.Empty;
        #region FieldType
        public string FieldType
        {
            get
            {
                return this.n_sFieldType;
            }
            set
            {
                this.n_sFieldType = value;
            }
        }
        #endregion FieldType


        protected string n_sQuoteEnd = string.Empty;
        #region QuoteEnd
        public string QuoteEnd
        {
            get
            {
                return this.n_sQuoteEnd;
            }
            set
            {
                this.n_sQuoteEnd = value;
            }
        }
        #endregion QuoteEnd


        #region Constructor & Destructor
        public FieldBase() { }

        public FieldBase(bool x_bIsList, bool x_bIsNullable, bool x_bIsView, bool x_bIsSearch, bool x_bIsEdit, string x_sParameterName, string x_sAliasName, bool x_bGenSql, string x_sSqlDataType, string x_sFieldVar, string x_sQuoteStart, bool x_bIsDelete, bool x_bIsAdd, bool x_bIsGenerateToSql, bool x_bIsRegister, bool x_bIsIdentityKey, bool x_bIsPrimaryKey, bool x_bIsUniqueKey, bool x_bIsAutoIncrement, int x_iSize, string x_sFieldName, string x_sFieldType, string x_sQuoteEnd)
        {
            IsList = x_bIsList;
            IsNullable = x_bIsNullable;
            IsView = x_bIsView;
            IsSearch = x_bIsSearch;
            IsEdit = x_bIsEdit;
            ParameterName = x_sParameterName;
            AliasName = x_sAliasName;
            GenSql = x_bGenSql;
            SqlDataType = x_sSqlDataType;
            FieldVar = x_sFieldVar;
            QuoteStart = x_sQuoteStart;
            IsDelete = x_bIsDelete;
            IsAdd = x_bIsAdd;
            IsGenerateToSql = x_bIsGenerateToSql;
            IsRegister = x_bIsRegister;
            IsIdentityKey = x_bIsIdentityKey;
            IsPrimaryKey = x_bIsPrimaryKey;
            IsUniqueKey = x_bIsUniqueKey;
            IsAutoIncrement = x_bIsAutoIncrement;
            Size = x_iSize;
            FieldName = x_sFieldName;
            FieldType = x_sFieldType;
            QuoteEnd = x_sQuoteEnd;
        }

        ~FieldBase() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public bool GetIsList() { return this.IsList; }
        public bool GetIsNullable() { return this.IsNullable; }
        public bool GetIsView() { return this.IsView; }
        public bool GetIsSearch() { return this.IsSearch; }
        public bool GetIsEdit() { return this.IsEdit; }
        public string GetParameterName() { return this.ParameterName; }
        public string GetAliasName() { return this.AliasName; }
        public bool GetGenSql() { return this.GenSql; }
        public string GetSqlDataType() { return this.SqlDataType; }
        public string GetFieldVar() { return this.FieldVar; }
        public string GetQuoteStart() { return this.QuoteStart; }
        public bool GetIsDelete() { return this.IsDelete; }
        public bool GetIsAdd() { return this.IsAdd; }
        public bool GetIsGenerateToSql() { return this.IsGenerateToSql; }
        public bool GetIsRegister() { return this.IsRegister; }
        public bool GetIsIdentityKey() { return this.IsIdentityKey; }
        public bool GetIsPrimaryKey() { return this.IsPrimaryKey; }
        public bool GetIsUniqueKey() { return this.IsUniqueKey; }
        public bool GetIsAutoIncrement() { return this.IsAutoIncrement; }
        public int GetSize() { return this.Size; }
        public string GetFieldName() { return this.FieldName; }
        public string GetFieldType() { return this.FieldType; }
        public string GetQuoteEnd() { return this.QuoteEnd; }

        public bool SetIsList(bool value)
        {
            this.IsList = value;
            return true;
        }
        public bool SetIsNullable(bool value)
        {
            this.IsNullable = value;
            return true;
        }
        public bool SetIsView(bool value)
        {
            this.IsView = value;
            return true;
        }
        public bool SetIsSearch(bool value)
        {
            this.IsSearch = value;
            return true;
        }
        public bool SetIsEdit(bool value)
        {
            this.IsEdit = value;
            return true;
        }
        public bool SetParameterName(string value)
        {
            this.ParameterName = value;
            return true;
        }
        public bool SetAliasName(string value)
        {
            this.AliasName = value;
            return true;
        }
        public bool SetGenSql(bool value)
        {
            this.GenSql = value;
            return true;
        }
        public bool SetSqlDataType(string value)
        {
            this.SqlDataType = value;
            return true;
        }
        public bool SetFieldVar(string value)
        {
            this.FieldVar = value;
            return true;
        }
        public bool SetQuoteStart(string value)
        {
            this.QuoteStart = value;
            return true;
        }
        public bool SetIsDelete(bool value)
        {
            this.IsDelete = value;
            return true;
        }
        public bool SetIsAdd(bool value)
        {
            this.IsAdd = value;
            return true;
        }
        public bool SetIsGenerateToSql(bool value)
        {
            this.IsGenerateToSql = value;
            return true;
        }
        public bool SetIsRegister(bool value)
        {
            this.IsRegister = value;
            return true;
        }
        public bool SetIsIdentityKey(bool value)
        {
            this.IsIdentityKey = value;
            return true;
        }
        public bool SetIsPrimaryKey(bool value)
        {
            this.IsPrimaryKey = value;
            return true;
        }
        public bool SetIsUniqueKey(bool value)
        {
            this.IsUniqueKey = value;
            return true;
        }
        public bool SetIsAutoIncrement(bool value)
        {
            this.IsAutoIncrement = value;
            return true;
        }
        public bool SetSize(int value)
        {
            this.Size = value;
            return true;
        }
        public bool SetFieldName(string value)
        {
            this.FieldName = value;
            return true;
        }
        public bool SetFieldType(string value)
        {
            this.FieldType = value;
            return true;
        }
        public bool SetQuoteEnd(string value)
        {
            this.QuoteEnd = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(FieldBase x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.IsList.Equals(x_oObj.IsList)) { return false; }
            if (!this.IsNullable.Equals(x_oObj.IsNullable)) { return false; }
            if (!this.IsView.Equals(x_oObj.IsView)) { return false; }
            if (!this.IsSearch.Equals(x_oObj.IsSearch)) { return false; }
            if (!this.IsEdit.Equals(x_oObj.IsEdit)) { return false; }
            if (!this.ParameterName.Equals(x_oObj.ParameterName)) { return false; }
            if (!this.AliasName.Equals(x_oObj.AliasName)) { return false; }
            if (!this.GenSql.Equals(x_oObj.GenSql)) { return false; }
            if (!this.SqlDataType.Equals(x_oObj.SqlDataType)) { return false; }
            if (!this.FieldVar.Equals(x_oObj.FieldVar)) { return false; }
            if (!this.QuoteStart.Equals(x_oObj.QuoteStart)) { return false; }
            if (!this.IsDelete.Equals(x_oObj.IsDelete)) { return false; }
            if (!this.IsAdd.Equals(x_oObj.IsAdd)) { return false; }
            if (!this.IsGenerateToSql.Equals(x_oObj.IsGenerateToSql)) { return false; }
            if (!this.IsRegister.Equals(x_oObj.IsRegister)) { return false; }
            if (!this.IsIdentityKey.Equals(x_oObj.IsIdentityKey)) { return false; }
            if (!this.IsPrimaryKey.Equals(x_oObj.IsPrimaryKey)) { return false; }
            if (!this.IsUniqueKey.Equals(x_oObj.IsUniqueKey)) { return false; }
            if (!this.IsAutoIncrement.Equals(x_oObj.IsAutoIncrement)) { return false; }
            if (!this.Size.Equals(x_oObj.Size)) { return false; }
            if (!this.FieldName.Equals(x_oObj.FieldName)) { return false; }
            if (!this.FieldType.Equals(x_oObj.FieldType)) { return false; }
            if (!this.QuoteEnd.Equals(x_oObj.QuoteEnd)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.IsList = false;
            this.IsNullable = false;
            this.IsView = false;
            this.IsSearch = false;
            this.IsEdit = false;
            this.ParameterName = string.Empty;
            this.AliasName = string.Empty;
            this.GenSql = false;
            this.SqlDataType = string.Empty;
            this.FieldVar = string.Empty;
            this.QuoteStart = string.Empty;
            this.IsDelete = false;
            this.IsAdd = false;
            this.IsGenerateToSql = false;
            this.IsRegister = false;
            this.IsIdentityKey = false;
            this.IsPrimaryKey = false;
            this.IsUniqueKey = false;
            this.IsAutoIncrement = false;
            this.Size = -1;
            this.FieldName = string.Empty;
            this.FieldType = string.Empty;
            this.QuoteEnd = string.Empty;
        }
        #endregion Release
        
        
        
    }
}

