using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[SearchUtils],SearchUtils Control>
///-- =============================================
namespace NEURON.ENTITY.FRAMEWORK
{
    /**
    * This is also the recommended usage
    * @package searchUtils
    */
    public class SearchUtils
    {
        // Row Filter
        protected string n_sRowFilter = string.Empty;
        #region m_sRowFilter
        protected string m_sRowFilter
        {
            get
            {
                return this.n_sRowFilter;
            }
            set
            {
                this.n_sRowFilter = value;
            }
        }
        #endregion
        //  field from table
        protected string n_sSql = string.Empty;
        #region m_sSql
        protected string m_sSql
        {
            get
            {
                return this.n_sSql;
            }
            set
            {
                this.n_sSql = value;
            }
        }
        #endregion m_sSql
        // fieldToSearch  field from table
        protected global::System.Collections.Generic.List<SearchItem> n_oSearchItems = new global::System.Collections.Generic.List<SearchItem>();
        #region m_oSearchItems
        protected global::System.Collections.Generic.List<SearchItem> m_oSearchItems
        {
            get
            {
                return this.n_oSearchItems;
            }
            set
            {
                this.n_oSearchItems = value;
            }
        }
        #endregion m_oSearchItems
        // orderByField  field from table
        protected string n_sOrderByField = string.Empty;
        #region m_sOrderByField
        protected string m_sOrderByField
        {
            get
            {
                return this.n_sOrderByField;
            }
            set
            {
                this.n_sOrderByField = value;
            }
        }
        #endregion m_sOrderByField
        // fieldsToReturn  field from table
        protected string n_sFieldsToReturn = string.Empty;
        #region m_sFieldsToReturn
        protected string m_sFieldsToReturn
        {
            get
            {
                return this.n_sFieldsToReturn;
            }
            set
            {
                this.n_sFieldsToReturn = value;
            }
        }
        #endregion m_sFieldsToReturn
        // table  field from table
        protected string n_sTable = string.Empty;
        #region m_sTable
        protected string m_sTable
        {
            get
            {
                return this.n_sTable;
            }
            set
            {
                this.n_sTable = value;
            }
        }
        #endregion m_sTable
        // start  row  from table
        protected long n_lStart = -1;
        #region m_lStart
        protected long m_lStart
        {
            get
            {
                return this.n_lStart;
            }
            set
            {
                this.n_lStart = value;
            }
        }
        #endregion m_lStart
        // orderDirection  field from table
        protected bool n_bAscDirection = true;
        #region m_bAscDirection
        protected bool m_bAscDirection
        {
            get
            {
                return this.n_bAscDirection;
            }
            set
            {
                this.n_bAscDirection = value;
            }
        }
        #endregion m_bAscDirection
        // limit  row from table
        protected long n_lLimit = -1;
        #region m_lLimit
        protected long m_lLimit
        {
            get
            {
                return this.n_lLimit;
            }
            set
            {
                this.n_lLimit = value;
            }
        }
        #endregion m_lLimit
        // searchCondition  field from table
        protected string n_sSearchOperand = string.Empty;
        #region m_sSearchOperand
        protected string m_sSearchOperand
        {
            get
            {
                return this.n_sSearchOperand;
            }
            set
            {
                this.n_sSearchOperand = value;
            }
        }
        #endregion m_sSearchOperand
        #region Constructor & Destructor
        public SearchUtils() { }
        public SearchUtils(string x_sSql, global::System.Collections.Generic.List<SearchItem> x_oSearchItems, string x_sRowFilter, string x_sOrderByField, string x_sFieldsToReturn, string x_sTable, int x_lStart, bool x_bAscDirection, int x_lLimit, string x_sSearchOperand)
        {
            m_sSql = x_sSql;
            m_oSearchItems = x_oSearchItems;
            m_sOrderByField = x_sOrderByField;
            m_sFieldsToReturn = x_sFieldsToReturn;
            m_sTable = x_sTable;
            m_lStart = x_lStart;
            m_bAscDirection = x_bAscDirection;
            m_lLimit = x_lLimit;
            m_sSearchOperand = x_sSearchOperand;
        }
        ~SearchUtils() { }
        #endregion Constructor & Destructor
        #region Get & Set
        public string GetRowFilter()
        {
            return this.m_sRowFilter;
        }
        public string GetSql()
        {
            if (this.m_sSql == null) return string.Empty;
            return this.m_sSql;
        }
        public global::System.Collections.Generic.List<SearchItem> GetSearchItems() { return this.m_oSearchItems; }
        public string GetOrderByField()
        {
            if (this.m_sOrderByField == null) return string.Empty;
            return this.m_sOrderByField;
        }
        public string GetFieldsToReturn()
        {
            if (this.m_sFieldsToReturn == null) return string.Empty;
            return this.m_sFieldsToReturn;
        }
        public string GetTable()
        {
            if (this.m_sTable == null) return string.Empty;
            return this.m_sTable;
        }
        public long GetStart() { return this.m_lStart; }
        public bool GetAscDirection() { return this.m_bAscDirection; }
        public long GetLimit() { return this.m_lLimit; }
        public string GetSearchOperand()
        {
            if (this.m_sSearchOperand == null) return string.Empty;
            return this.m_sSearchOperand;
        }
        public bool SetRowFilter(string value)
        {
            this.m_sRowFilter = value;
            return true;
        }

        public bool SetSql(string value)
        {
            this.m_sSql = value;
            return true;
        }
        public bool SetSearchItems(List<SearchItem> value)
        {
            this.m_oSearchItems = value;
            return true;
        }
        public bool SetOrderByField(string value)
        {
            this.m_sOrderByField = value;
            return true;
        }
        public bool SetFieldsToReturn(string value)
        {
            this.m_sFieldsToReturn = value;
            return true;
        }
        public bool SetTable(string value)
        {
            this.m_sTable = value;
            return true;
        }
        public bool SetStart(long value)
        {
            this.m_lStart = value;
            return true;
        }
        public bool SetAscDirection(bool value)
        {
            this.m_bAscDirection = value;
            return true;
        }
        public bool SetLimit(long value)
        {
            this.m_lLimit = value;
            return true;
        }
        public bool SetSearchOperand(string value)
        {
            this.m_sSearchOperand = value;
            return true;
        }
        #endregion
        #region Build Search SQL
        public void BuildSearchSQL()
        {
            bool _bFlag = true;
            if (!string.IsNullOrEmpty(this.GetOrderByField())) { this.SetOrderByField(this.GetOrderByField().Trim()); }
            if (GetStart() == -1 && GetLimit() == -1)
                _bFlag = true;
            else if (this.GetStart() >= 0 && this.GetLimit() > 0)
            {
                if (!string.IsNullOrEmpty(this.GetOrderByField()))
                    _bFlag = true;
                else
                    _bFlag = false;
            }
            else if ((this.GetStart() < 0 && this.GetLimit() > 0) || (this.GetStart() >= 0 && this.GetLimit() < 0))
                _bFlag = false;

            if (_bFlag)
            {
                global::System.Collections.Generic.List<SearchItem> _oSearchItemsList = this.GetSearchItems();
                bool _bLimit = false;
                long _bTopLimit = 0;
                long _bPageLimit = 0;
                if (this.GetStart() >= 0 && this.GetLimit() > 0)
                {
                    if (!string.IsNullOrEmpty(this.GetOrderByField()))
                    {
                        _bLimit = true;
                        _bTopLimit = GetStart() + GetLimit();
                        _bPageLimit = GetLimit();
                    }
                }

                if (string.IsNullOrEmpty(this.GetFieldsToReturn()))
                    this.SetFieldsToReturn(" * ");

                if (string.IsNullOrEmpty(this.GetSearchOperand()))
                    this.SetSearchOperand(" AND ");

                global::System.Text.StringBuilder _oSQLBuffer = new global::System.Text.StringBuilder();
                _oSQLBuffer.Append("SELECT ");
                if (_bLimit)
                    _oSQLBuffer.Append(" TOP " + _bTopLimit.ToString() + " ");

                _oSQLBuffer.Append(" " + this.GetFieldsToReturn() + " ");
                _oSQLBuffer.Append(" FROM " + this.GetTable());
                int _iConditionNum = 0;
                if (_oSearchItemsList != null)
                {
                    if (_oSearchItemsList.Count > 0)
                    {
                        _oSQLBuffer.Append(" WHERE ");
                        _oSQLBuffer.Append(" ( ");
                        for (int a = 0; a < _oSearchItemsList.Count; a++)
                        {
                            SearchItem _oSearchItem = (SearchItem)_oSearchItemsList[a];
                            global::System.Collections.Generic.List<string> _oSearchValues = _oSearchItem.GetSearchValues();
                            if (_iConditionNum != 0)
                            {
                                _oSQLBuffer.Append(" ");
                                _oSQLBuffer.Append(_oSearchItem.GetOuterOperand());
                                _oSQLBuffer.Append(" ");
                            }
                            _oSQLBuffer.Append(" ( ");
                            for (int b = 0; b < _oSearchValues.Count; b++)
                            {
                                if (!(0).Equals(b))
                                {
                                    _oSQLBuffer.Append(" ");
                                    _oSQLBuffer.Append(_oSearchItem.GetInnerOperand());
                                    _oSQLBuffer.Append(" ");
                                }
                                _oSQLBuffer.Append(_oSearchItem.GetSearchField());
                                if (_oSearchItem.GetSearchCondition() == "=" && _oSearchItem.GetNullable() && "".Equals((string)_oSearchValues[b]))
                                    _oSQLBuffer.Append(" is null ");
                                else
                                {
                                    _oSQLBuffer.Append(" ");
                                    _oSQLBuffer.Append(_oSearchItem.GetSearchCondition());
                                    _oSQLBuffer.Append(" '");
                                    _oSQLBuffer.Append((string)_oSearchValues[b]);
                                    _oSQLBuffer.Append("' ");
                                }
                                _iConditionNum += 1;
                            } // end for b
                            _oSQLBuffer.Append(" ) ");
                        }// end for a
                        _oSQLBuffer.Append(" ) ");
                    }// end if count>0
                }// end of  SearchItemList!=null

                // Row Filter
                if (!string.IsNullOrEmpty(this.m_sRowFilter))
                {
                    if (_oSQLBuffer.ToString().IndexOf("WHERE") > -1)
                        _oSQLBuffer.Append(" AND ");
                    else
                        _oSQLBuffer.Append(" WHERE ");
                    _oSQLBuffer.Append(" ( " + this.m_sRowFilter + " ) ");
                }

                if (!string.IsNullOrEmpty(this.GetOrderByField()))
                {
                    _oSQLBuffer.Append(" ORDER BY ");
                    _oSQLBuffer.Append(" ");
                    _oSQLBuffer.Append(this.GetOrderByField());
                    _oSQLBuffer.Append("  ");
                   
                    _oSQLBuffer.Append((this.GetAscDirection() ? "ASC" : "DESC"));


                    _oSQLBuffer.Append(" ");
                }

                if (_bLimit && !string.Empty.Equals(this.GetOrderByField()))
                {
                    StringBuilder _sSqlLimit = new StringBuilder();
                    _sSqlLimit.Append("SELECT TOP " + _bPageLimit.ToString() + " " + this.GetFieldsToReturn() + " FROM ( ");
                    _sSqlLimit.Append("SELECT TOP " + _bPageLimit.ToString() + " " + this.GetFieldsToReturn() + " FROM ( ");
                    _sSqlLimit.Append(_oSQLBuffer.ToString());
                    _sSqlLimit.Append(") AS RowTableDesc ORDER BY " + this.GetOrderByField() + " " + ((this.GetAscDirection()==false) ? "ASC" : "DESC") + " ");//opposite
                    _sSqlLimit.Append(") AS RowTableAsc ORDER BY " + this.GetOrderByField() + " " + (this.GetAscDirection() ? "ASC" : "DESC"));
                    this.SetSql(_sSqlLimit.ToString());
                }
                else
                    this.SetSql(_oSQLBuffer.ToString());
            }
            else
                this.SetSql(string.Empty);
        }

        #endregion
        #region Build Search By Keyword
        protected void BuildSearchByKeywordSQL()
        {
            global::System.Collections.Generic.List<SearchItem> _oSearchItemsList = this.GetSearchItems();
            string _sSearchOperator = " LIKE ";
            string _sSearchOperand = " OR ";

            if ("".Equals(this.GetFieldsToReturn()))
                this.SetFieldsToReturn(" * ");
            if ("".Equals(this.GetFieldsToReturn()))
                this.SetAscDirection(true);

            global::System.Text.StringBuilder _oSqlBuffer = new global::System.Text.StringBuilder();
            _oSqlBuffer.Append("SELECT");
            _oSqlBuffer.Append(" ");
            _oSqlBuffer.Append(this.GetFieldsToReturn());
            _oSqlBuffer.Append(" ");
            _oSqlBuffer.Append(" FROM ");
            _oSqlBuffer.Append(this.GetTable());
            _oSqlBuffer.Append(" WHERE ");
            _oSqlBuffer.Append("(");
            for (int p = 0; p < _oSearchItemsList.Count; p++)
            {
                SearchItem _oSearchItem = (SearchItem)_oSearchItemsList[p];
                string _sFieldList = _oSearchItem.GetSearchField();
                global::System.Collections.Generic.List<string> _sKeywords = _oSearchItem.GetSearchValues();
                string _sKeyword = (string)_sKeywords[0];
                _oSqlBuffer.Append("(");
                _oSqlBuffer.Append(_sFieldList + " " + _sSearchOperator + " '%" + _sKeyword + "%' ");
                _oSqlBuffer.Append(")");
                if (p != (_oSearchItemsList.Count - 1))
                {
                    _oSqlBuffer.Append(" " + _sSearchOperand + " ");
                }
            }// end p
            _oSqlBuffer.Append(")");
            if (!"".Equals(this.GetOrderByField()))
            {
                _oSqlBuffer.Append(" ORDER BY ");
                _oSqlBuffer.Append(" " + this.GetOrderByField() + " ");
                _oSqlBuffer.Append(" " + this.GetAscDirection() + " ");
            }
            this.SetSql(_oSqlBuffer.ToString());
        }
        #endregion
        #region Get Search SQL
        public string GetSearchSQL()
        {
            this.BuildSearchSQL();
            return this.GetSql();
        }
        #endregion
        #region Get Search By Keyword SQL
        public string GetSearchByKeywordSQL()
        {
            this.BuildSearchByKeywordSQL();
            return this.GetSql();
        }
        #endregion
        #region Equals
        public bool Equals(SearchUtils x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sRowFilter.Equals(x_oObj.m_sRowFilter)) { return false; }
            if (!this.m_sSql.Equals(x_oObj.m_sSql)) { return false; }
            if (!this.m_oSearchItems.Equals(x_oObj.m_oSearchItems)) { return false; }
            if (!this.m_sOrderByField.Equals(x_oObj.m_sOrderByField)) { return false; }
            if (!this.m_sFieldsToReturn.Equals(x_oObj.m_sFieldsToReturn)) { return false; }
            if (!this.m_sTable.Equals(x_oObj.m_sTable)) { return false; }
            if (!this.m_lStart.Equals(x_oObj.m_lStart)) { return false; }
            if (!this.m_bAscDirection.Equals(x_oObj.m_bAscDirection)) { return false; }
            if (!this.m_lLimit.Equals(x_oObj.m_lLimit)) { return false; }
            if (!this.m_sSearchOperand.Equals(x_oObj.m_sSearchOperand)) { return false; }
            return true;
        }
        #endregion Equals
        #region Release
        public void Release()
        {
            this.m_sSql = string.Empty;
            this.m_sRowFilter = string.Empty;
            this.m_oSearchItems = new global::System.Collections.Generic.List<SearchItem>();
            this.m_sOrderByField = string.Empty;
            this.m_sFieldsToReturn = string.Empty;
            this.m_sTable = string.Empty;
            this.m_lStart = -1;
            this.m_bAscDirection = true;
            this.m_lLimit = -1;
            this.m_sSearchOperand = string.Empty;
        }
        #endregion Release
        #region Clone
        public SearchUtils Clone()
        {
            SearchUtils SearchUtils_Clone = new SearchUtils();
            SearchUtils_Clone.SetRowFilter(this.m_sRowFilter);
            SearchUtils_Clone.SetSql(this.m_sSql);
            SearchUtils_Clone.SetSearchItems(this.m_oSearchItems);
            SearchUtils_Clone.SetOrderByField(this.m_sOrderByField);
            SearchUtils_Clone.SetFieldsToReturn(this.m_sFieldsToReturn);
            SearchUtils_Clone.SetTable(this.m_sTable);
            SearchUtils_Clone.SetStart(this.m_lStart);
            SearchUtils_Clone.SetAscDirection(this.m_bAscDirection);
            SearchUtils_Clone.SetLimit(this.m_lLimit);
            SearchUtils_Clone.SetSearchOperand(this.m_sSearchOperand);
            return SearchUtils_Clone;
        }
        #endregion Clone
    }
}

