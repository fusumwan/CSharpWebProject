using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[AutoSelectionProperty], Information layer>
///-- =============================================
namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [AutoSelectionProperty] Information layer
    /// </summary>
    public abstract class AutoSelectionPropertyInfoDLL
    {


        #region Parameter
        private TableObj n_oTableSet = new TableObj();
        public bool n_bViewAll = false;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region Constructor

        public AutoSelectionPropertyInfoDLL()
        {
            Init();
        }
        ~AutoSelectionPropertyInfoDLL()
        {
            this.Release();
        }
        #endregion

        #region Create Instance Object
        public static AutoSelectionPropertyInfo CreateInfoInstanceObject()
        {
            return new AutoSelectionPropertyInfo();
        }
        #endregion

        #region Init
        public void Init()
        {

            string _sStrFldName;
            n_oTableSet.TableName = AutoSelectionProperty.Para.TableName();
            n_oTableSet.DefaultFilter = String.Empty;
            n_oTableSet.GroupBy = String.Empty;
            n_oTableSet.Having = String.Empty;
            n_oTableSet.DefaultOrderBy = String.Empty;

            // [id] Field
            _sStrFldName = AutoSelectionProperty.Para.id;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = true;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = true;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = true;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = true;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[id]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "id";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[id]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "id";
            n_oTableSet.Fields(_sStrFldName).AliasName = "id";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "id";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = false;
            n_oTableSet.Fields(_sStrFldName).IsEdit = false;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = false;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = false;
            n_oTableSet.Fields(_sStrFldName).Size = 0;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "int";


            // [period] Field
            _sStrFldName = AutoSelectionProperty.Para.period;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[period]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "period";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[period]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "period";
            n_oTableSet.Fields(_sStrFldName).AliasName = "period";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "period";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 50;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";


            // [start_date] Field
            _sStrFldName = AutoSelectionProperty.Para.start_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[start_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "start_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[start_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "start_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "start_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "start_date";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 0;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "datetime";


            // [obprogram] Field
            _sStrFldName = AutoSelectionProperty.Para.obprogram;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[obprogram]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "obprogram";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[obprogram]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "obprogram";
            n_oTableSet.Fields(_sStrFldName).AliasName = "obprogram";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "obprogram";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 250;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";


            // [channel] Field
            _sStrFldName = AutoSelectionProperty.Para.channel;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[channel]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "channel";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[channel]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "channel";
            n_oTableSet.Fields(_sStrFldName).AliasName = "channel";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "channel";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 10;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";


            // [tier] Field
            _sStrFldName = AutoSelectionProperty.Para.tier;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[tier]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "tier";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[tier]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "tier";
            n_oTableSet.Fields(_sStrFldName).AliasName = "tier";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "tier";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 50;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";


            // [tradefield_mid] Field
            _sStrFldName = AutoSelectionProperty.Para.tradefield_mid;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[tradefield_mid]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "tradefield_mid";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[tradefield_mid]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "tradefield_mid";
            n_oTableSet.Fields(_sStrFldName).AliasName = "tradefield_mid";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "tradefield_mid";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 0;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "int";


            // [uid] Field
            _sStrFldName = AutoSelectionProperty.Para.uid;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[uid]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "uid";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[uid]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "uid";
            n_oTableSet.Fields(_sStrFldName).AliasName = "uid";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "uid";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 50;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";


            // [end_date] Field
            _sStrFldName = AutoSelectionProperty.Para.end_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[end_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "end_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[end_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "end_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "end_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "end_date";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 0;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "datetime";


            // [plan_fee] Field
            _sStrFldName = AutoSelectionProperty.Para.plan_fee;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[plan_fee]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "plan_fee";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[plan_fee]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "plan_fee";
            n_oTableSet.Fields(_sStrFldName).AliasName = "plan_fee";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "plan_fee";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 50;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";


            // [remarks] Field
            _sStrFldName = AutoSelectionProperty.Para.remarks;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[remarks]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "remarks";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[remarks]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "remarks";
            n_oTableSet.Fields(_sStrFldName).AliasName = "remarks";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "remarks";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 2147483647;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "text";


            // [po_date] Field
            _sStrFldName = AutoSelectionProperty.Para.po_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[po_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "po_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[po_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "po_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "po_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "po_date";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 0;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "datetime";

        }
        #endregion


        #region Get & Set

        #region GetViewAll
        public bool GetViewAll() { return n_bViewAll; }
        #endregion GetViewAll


        #region SetViewAll
        public void SetViewAll(bool value) { n_bViewAll = value; }
        #endregion SetViewAll


        #region GetTableSet
        public TableObj GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(TableObj value) { n_oTableSet = value; }
        #endregion SetTableSet

        #region GetTableInfo
        public Field GetIdTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.id);
        }
        public Field GetPeriodTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.period);
        }
        public Field GetStart_dateTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.start_date);
        }
        public Field GetObprogramTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.obprogram);
        }
        public Field GetChannelTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.channel);
        }
        public Field GetTierTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.tier);
        }
        public Field GetTradefield_midTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.tradefield_mid);
        }
        public Field GetUidTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.uid);
        }
        public Field GetEnd_dateTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.end_date);
        }
        public Field GetPlan_feeTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.plan_fee);
        }
        public Field GetRemarksTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.remarks);
        }
        public Field GetPo_dateTable()
        {
            return n_oTableSet.Fields(AutoSelectionProperty.Para.po_date);
        }

        public Field Fields(string x_sColumn)
        {
            return n_oTableSet.Fields(x_sColumn);
        }
        #endregion GetTableInfo
        #endregion
        #region
        public void Release() { }
        #endregion
    }
}

