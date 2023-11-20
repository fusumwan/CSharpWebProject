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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Description,Class :[SearchItem],Search Object>
///-- =============================================
/**
* This is also the recommended usage
* @package searchItem
*/
namespace NEURON.ENTITY.FRAMEWORK{
    public class SearchItem
    {
        // outerOperand  field from table
        protected string n_sOuterOperand = string.Empty;
        #region m_sOuterOperand
        protected string m_sOuterOperand
        {
            get
            {
                return this.n_sOuterOperand;
            }
            set
            {
                this.n_sOuterOperand = value;
            }
        }
        #endregion m_sOuterOperand
        // searchField  field from table
        protected string n_sSearchField = string.Empty;
        #region m_sSearchField
        protected string m_sSearchField
        {
            get
            {
                return this.n_sSearchField;
            }
            set
            {
                this.n_sSearchField = value;
            }
        }
        #endregion m_sSearchField
        // searchCondition  field from table
        protected string n_sSearchCondition = string.Empty;
        #region m_sSearchCondition
        protected string m_sSearchCondition
        {
            get
            {
                return this.n_sSearchCondition;
            }
            set
            {
                this.n_sSearchCondition = value;
            }
        }
        #endregion m_sSearchCondition
        // searchTerms  field from table
        protected global::System.Collections.Generic.List<string> n_oSearchValues = new global::System.Collections.Generic.List<string>();
        #region m_oSearchValues
        protected global::System.Collections.Generic.List<string> m_oSearchValues
        {
            get
            {
                return this.n_oSearchValues;
            }
            set
            {
                this.n_oSearchValues = value;
            }
        }
        #endregion m_oSearchValues
        protected bool n_bNullable = false;
        #region m_bNullable
        protected bool m_bNullable
        {
            get
            {
                return this.n_bNullable;
            }
            set
            {
                this.n_bNullable = value;
            }
        }
        #endregion m_bNullable
        // this is field is to separate the different searchValues e.g
        // e.g ((searchField1 == value1) or (searchField1 == value2)) or is the inneroperand
        protected string n_sInnerOperand = string.Empty;
        #region m_sInnerOperand
        protected string m_sInnerOperand
        {
            get
            {
                return this.n_sInnerOperand;
            }
            set
            {
                this.n_sInnerOperand = value;
            }
        }
        #endregion m_sInnerOperand
        #region Constructor & Destructor
        public SearchItem() { }
        public SearchItem(string x_sSearchField,bool x_bNullable, global::System.Collections.Generic.List<string> x_oSearchValues, string x_sSearchCondition, string x_sOuterOperand, string x_sInnerOperand)
        {
            n_bNullable = x_bNullable;
            if ("".Equals(x_sSearchCondition)){
                x_sSearchCondition = "=";
            }
            if ("".Equals(x_sOuterOperand)){
                x_sOuterOperand = " and ";
            }
            if ("".Equals(x_sInnerOperand)){
                x_sInnerOperand = " or ";
            }
            if (x_oSearchValues != null){
                m_oSearchValues = x_oSearchValues;
            }
            else{
                m_oSearchValues = new global::System.Collections.Generic.List<string>();
            }
            this.SetSearchField(x_sSearchField);
            this.SetSearchCondition(x_sSearchCondition);
            this.SetInnerOperand(x_sInnerOperand);
            this.SetOuterOperand(x_sOuterOperand);
        }
        ~SearchItem() { }
        #endregion Constructor & Destructor
        #region Get & Set
        public string GetOuterOperand() { return this.m_sOuterOperand; }
        public string GetSearchField() { return this.m_sSearchField; }
        public string GetSearchCondition() { return this.m_sSearchCondition; }
        public global::System.Collections.Generic.List<string> GetSearchValues() { return this.m_oSearchValues; }
        public bool GetNullable() { return this.m_bNullable; }
        public string GetInnerOperand() { return this.m_sInnerOperand; }
        public bool SetOuterOperand(string value)
        {
            this.m_sOuterOperand = value;
            return true;
        }
        public bool SetSearchField(string value)
        {
            this.m_sSearchField = value;
            return true;
        }
        public bool SetSearchCondition(string value)
        {
            this.m_sSearchCondition = value;
            return true;
        }
        public bool SetSearchValues(List<string> value)
        {
            this.m_oSearchValues = value;
            return true;
        }
        public bool SetNullable(bool value)
        {
            this.m_bNullable = value;
            return true;
        }
        public bool SetInnerOperand(string value)
        {
            this.m_sInnerOperand = value;
            return true;
        }
        #endregion
        #region Equals
        public bool Equals(SearchItem x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sOuterOperand.Equals(x_oObj.m_sOuterOperand)) { return false; }
            if (!this.m_sSearchField.Equals(x_oObj.m_sSearchField)) { return false; }
            if (!this.m_sSearchCondition.Equals(x_oObj.m_sSearchCondition)) { return false; }
            if (!this.m_oSearchValues.Equals(x_oObj.m_oSearchValues)) { return false; }
            if (!this.m_bNullable.Equals(x_oObj.m_bNullable)) { return false; }
            if (!this.m_sInnerOperand.Equals(x_oObj.m_sInnerOperand)) { return false; }
            return true;
        }
        #endregion Equals
        #region Release
        public void Release()
        {
            this.m_sOuterOperand = string.Empty;
            this.m_sSearchField = string.Empty;
            this.m_sSearchCondition = string.Empty;
            this.m_oSearchValues = null;
            this.m_bNullable = false;
            this.m_sInnerOperand = string.Empty;
        }
        #endregion Release
        #region Clone
        public SearchItem Clone()
        {
            SearchItem SearchItem_Clone = new SearchItem();
            SearchItem_Clone.SetOuterOperand(this.m_sOuterOperand);
            SearchItem_Clone.SetSearchField(this.m_sSearchField);
            SearchItem_Clone.SetSearchCondition(this.m_sSearchCondition);
            SearchItem_Clone.SetSearchValues(this.m_oSearchValues);
            SearchItem_Clone.SetNullable(this.m_bNullable);
            SearchItem_Clone.SetInnerOperand(this.m_sInnerOperand);
            return SearchItem_Clone;
        }
        #endregion Clone
    }
}

