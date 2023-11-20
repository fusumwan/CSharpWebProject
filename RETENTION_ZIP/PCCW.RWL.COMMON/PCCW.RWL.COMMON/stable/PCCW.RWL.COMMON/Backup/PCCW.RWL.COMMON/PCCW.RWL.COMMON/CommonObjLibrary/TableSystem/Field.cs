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
    public class Field : FieldBase{

        protected string n_sFieldUploadPath = string.Empty;
        #region FieldUploadPath
        public string FieldUploadPath
        {
            get
            {
                return this.n_sFieldUploadPath;
            }
            set
            {
                this.n_sFieldUploadPath = value;
            }
        }
        #endregion FieldUploadPath

        protected string n_sSortParm = string.Empty;
        #region SortParm
        public string SortParm
        {
            get
            {
                return this.n_sSortParm;
            }
            set
            {
                this.n_sSortParm = value;
            }
        }
        #endregion SortParm

        protected string n_sSortName = string.Empty;
        #region SortName
        public string SortName
        {
            get
            {
                return this.n_sSortName;
            }
            set
            {
                this.n_sSortName = value;
            }
        }
        #endregion SortName

        protected string n_sReportColumnName = string.Empty;
        #region ReportColumnName
        public string ReportColumnName
        {
            get
            {
                return this.n_sReportColumnName;
            }
            set
            {
                this.n_sReportColumnName = value;
            }
        }
        #endregion

        protected int n_iReportColumnIndex = -1;
        #region ReportColumnIndex
        public int ReportColumnIndex
        {
            get
            {
                return n_iReportColumnIndex;
            }
            set
            {
                this.n_iReportColumnIndex = value;
            }
        }
        #endregion

        #region Constructor & Destructor
        public Field() { }

        public Field(string x_sFieldUploadPath, string x_sSortParm, string x_sSortName, string x_sReportColumnName)
        {
            FieldUploadPath = x_sFieldUploadPath;
            SortParm = x_sSortParm;
            SortName = x_sSortName;
            ReportColumnName = x_sReportColumnName;
        }

        ~Field() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetFieldUploadPath() { return this.FieldUploadPath; }
        public string GetSortParm() { return this.SortParm; }
        public string GetSortName() { return this.SortName; }
        public string GetReportColumnName() { return this.ReportColumnName; }
        public int GetReportColumnIndex() { return this.ReportColumnIndex; }
        public bool SetFieldUploadPath(string value)
        {
            this.FieldUploadPath = value;
            return true;
        }
        public bool SetSortParm(string value)
        {
            this.SortParm = value;
            return true;
        }
        public bool SetSortName(string value)
        {
            this.SortName = value;
            return true;
        }
        public bool SetReportColumnName(string value)
        {
            this.ReportColumnName = value;
            return true;
        }
        public bool SetReportColumnIndex(int value)
        {
            this.ReportColumnIndex = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(Field x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.FieldUploadPath.Equals(x_oObj.FieldUploadPath)) { return false; }
            if (!this.SortParm.Equals(x_oObj.SortParm)) { return false; }
            if (!this.SortName.Equals(x_oObj.SortName)) { return false; }
            if (!this.ReportColumnName.Equals(x_oObj.ReportColumnName)) { return false; }
            if (!this.ReportColumnIndex.Equals(x_oObj.ReportColumnIndex)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.FieldUploadPath = string.Empty;
            this.SortParm = string.Empty;
            this.SortName = string.Empty;
            this.ReportColumnName = string.Empty;
            this.ReportColumnIndex = -1;
        }
        #endregion Release


        #region Clone
        public Field Clone()
        {
            Field Field_Clone = new Field();
            Field_Clone.SetIsList(this.IsList);
            Field_Clone.SetIsNullable(this.IsNullable);
            Field_Clone.SetIsView(this.IsView);
            Field_Clone.SetIsSearch(this.IsSearch);
            Field_Clone.SetIsEdit(this.IsEdit);
            Field_Clone.SetParameterName(this.ParameterName);
            Field_Clone.SetAliasName(this.AliasName);
            Field_Clone.SetGenSql(this.GenSql);
            Field_Clone.SetSqlDataType(this.SqlDataType);
            Field_Clone.SetFieldVar(this.FieldVar);
            Field_Clone.SetQuoteStart(this.QuoteStart);
            Field_Clone.SetIsDelete(this.IsDelete);
            Field_Clone.SetIsAdd(this.IsAdd);
            Field_Clone.SetIsGenerateToSql(this.IsGenerateToSql);
            Field_Clone.SetIsRegister(this.IsRegister);
            Field_Clone.SetIsIdentityKey(this.IsIdentityKey);
            Field_Clone.SetIsPrimaryKey(this.IsPrimaryKey);
            Field_Clone.SetIsUniqueKey(this.IsUniqueKey);
            Field_Clone.SetIsAutoIncrement(this.IsAutoIncrement);
            Field_Clone.SetSize(this.Size);
            Field_Clone.SetFieldName(this.FieldName);
            Field_Clone.SetFieldType(this.FieldType);
            Field_Clone.SetQuoteEnd(this.QuoteEnd);
            Field_Clone.SetFieldUploadPath(this.FieldUploadPath);
            Field_Clone.SetSortParm(this.SortParm);
            Field_Clone.SetSortName(this.SortName);
            Field_Clone.SetReportColumnName(this.ReportColumnName);
            Field_Clone.SetReportColumnIndex(this.ReportColumnIndex);
            return Field_Clone;
        }
        #endregion Clone
        
    }
}

