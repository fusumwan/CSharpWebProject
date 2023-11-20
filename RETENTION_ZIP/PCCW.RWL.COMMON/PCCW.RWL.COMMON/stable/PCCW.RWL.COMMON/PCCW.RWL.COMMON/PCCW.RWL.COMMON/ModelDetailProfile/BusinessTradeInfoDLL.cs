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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[BusinessTrade], Information layer>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BusinessTrade] Information layer
    /// </summary>
    public abstract class BusinessTradeInfoDLL{
        
        
        #region Parameter
        private TableObj n_oTableSet = new TableObj();
        public bool n_bViewAll=false;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion
        
        #region CreateInfoInstanceObject
        public static BusinessTradeInfo CreateInfoInstanceObject(){
            return new BusinessTradeInfo();
        }
        #endregion
        #region Constructor
        
        public BusinessTradeInfoDLL(){
            Init();
        }
        ~BusinessTradeInfoDLL(){
            this.Release();
        }
        #endregion
        
        
        #region Init
        public void Init()
        {
            
            string _sStrFldName;
            n_oTableSet.TableName = BusinessTrade.Para.TableName();
            n_oTableSet.DefaultFilter = String.Empty;
            n_oTableSet.GroupBy = String.Empty;
            n_oTableSet.Having = String.Empty;
            n_oTableSet.DefaultOrderBy = String.Empty;
            
            // [mid] Field
            _sStrFldName = BusinessTrade.Para.mid;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = true;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = true;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = true;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = true;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[mid]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "mid";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[mid]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "mid";
            n_oTableSet.Fields(_sStrFldName).AliasName = "mid";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "mid";
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
            
            
            // [channel] Field
            _sStrFldName = BusinessTrade.Para.channel;
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "char";
            
            
            // [cdate] Field
            _sStrFldName = BusinessTrade.Para.cdate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[cdate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "cdate";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[cdate]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "cdate";
            n_oTableSet.Fields(_sStrFldName).AliasName = "cdate";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "cdate";
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
            
            
            // [bundle_name] Field
            _sStrFldName = BusinessTrade.Para.bundle_name;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[bundle_name]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "bundle_name";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[bundle_name]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "bundle_name";
            n_oTableSet.Fields(_sStrFldName).AliasName = "bundle_name";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "bundle_name";
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
            
            
            // [hs_model_name] Field
            _sStrFldName = BusinessTrade.Para.hs_model_name;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[hs_model_name]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "hs_model_name";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[hs_model_name]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "hs_model_name";
            n_oTableSet.Fields(_sStrFldName).AliasName = "hs_model_name";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "hs_model_name";
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
            
            
            // [trade_field] Field
            _sStrFldName = BusinessTrade.Para.trade_field;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[trade_field]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "trade_field";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[trade_field]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "trade_field";
            n_oTableSet.Fields(_sStrFldName).AliasName = "trade_field";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "trade_field";
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
            
            
            // [did] Field
            _sStrFldName = BusinessTrade.Para.did;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[did]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "did";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[did]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "did";
            n_oTableSet.Fields(_sStrFldName).AliasName = "did";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "did";
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
            
            
            // [premium_1] Field
            _sStrFldName = BusinessTrade.Para.premium_1;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[premium_1]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "premium_1";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[premium_1]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "premium_1";
            n_oTableSet.Fields(_sStrFldName).AliasName = "premium_1";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "premium_1";
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
            
            
            // [sdate] Field
            _sStrFldName = BusinessTrade.Para.sdate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[sdate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "sdate";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[sdate]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "sdate";
            n_oTableSet.Fields(_sStrFldName).AliasName = "sdate";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "sdate";
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
            
            
            // [rebate] Field
            _sStrFldName = BusinessTrade.Para.rebate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[rebate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "rebate";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[rebate]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "rebate";
            n_oTableSet.Fields(_sStrFldName).AliasName = "rebate";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "rebate";
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
            
            
            // [premium_2] Field
            _sStrFldName = BusinessTrade.Para.premium_2;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[premium_2]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "premium_2";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[premium_2]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "premium_2";
            n_oTableSet.Fields(_sStrFldName).AliasName = "premium_2";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "premium_2";
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
            
            
            // [retention_type] Field
            _sStrFldName = BusinessTrade.Para.retention_type;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[retention_type]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "retention_type";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[retention_type]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "retention_type";
            n_oTableSet.Fields(_sStrFldName).AliasName = "retention_type";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "retention_type";
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
            
            
            // [extra_offer] Field
            _sStrFldName = BusinessTrade.Para.extra_offer;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[extra_offer]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "extra_offer";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[extra_offer]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "extra_offer";
            n_oTableSet.Fields(_sStrFldName).AliasName = "extra_offer";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "extra_offer";
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
            
            
            // [edate] Field
            _sStrFldName = BusinessTrade.Para.edate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[edate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "edate";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[edate]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "edate";
            n_oTableSet.Fields(_sStrFldName).AliasName = "edate";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "edate";
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
            
            
            // [program] Field
            _sStrFldName = BusinessTrade.Para.program;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[program]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "program";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[program]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "program";
            n_oTableSet.Fields(_sStrFldName).AliasName = "program";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "program";
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
            
            
            // [con_per] Field
            _sStrFldName = BusinessTrade.Para.con_per;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[con_per]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "con_per";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[con_per]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "con_per";
            n_oTableSet.Fields(_sStrFldName).AliasName = "con_per";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "con_per";
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
            
            
            // [rate_plan] Field
            _sStrFldName = BusinessTrade.Para.rate_plan;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[rate_plan]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "rate_plan";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[rate_plan]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "rate_plan";
            n_oTableSet.Fields(_sStrFldName).AliasName = "rate_plan";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "rate_plan";
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
            
            
            // [ddate] Field
            _sStrFldName = BusinessTrade.Para.ddate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[ddate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "ddate";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[ddate]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "ddate";
            n_oTableSet.Fields(_sStrFldName).AliasName = "ddate";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "ddate";
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
            
            
            // [normal_rebate_type] Field
            _sStrFldName = BusinessTrade.Para.normal_rebate_type;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[normal_rebate_type]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "normal_rebate_type";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[normal_rebate_type]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "normal_rebate_type";
            n_oTableSet.Fields(_sStrFldName).AliasName = "normal_rebate_type";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "normal_rebate_type";
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
            n_oTableSet.Fields(_sStrFldName).Size = 100;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";
            
            
            // [active] Field
            _sStrFldName = BusinessTrade.Para.active;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[active]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "active";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[active]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "active";
            n_oTableSet.Fields(_sStrFldName).AliasName = "active";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "active";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "bit";
            
            
            // [free_mon] Field
            _sStrFldName = BusinessTrade.Para.free_mon;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[free_mon]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "free_mon";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[free_mon]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "free_mon";
            n_oTableSet.Fields(_sStrFldName).AliasName = "free_mon";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "free_mon";
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
            
            
            // [cid] Field
            _sStrFldName = BusinessTrade.Para.cid;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[cid]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "cid";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[cid]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "cid";
            n_oTableSet.Fields(_sStrFldName).AliasName = "cid";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "cid";
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
            
            
            // [cancel_renew] Field
            _sStrFldName = BusinessTrade.Para.cancel_renew;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[cancel_renew]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "cancel_renew";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[cancel_renew]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "cancel_renew";
            n_oTableSet.Fields(_sStrFldName).AliasName = "cancel_renew";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "cancel_renew";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "bit";
            
            
            // [ob_early] Field
            _sStrFldName = BusinessTrade.Para.ob_early;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[ob_early]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "ob_early";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[ob_early]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "ob_early";
            n_oTableSet.Fields(_sStrFldName).AliasName = "ob_early";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "ob_early";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "char";
            
            
            // [normal_rebate] Field
            _sStrFldName = BusinessTrade.Para.normal_rebate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[normal_rebate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "normal_rebate";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[normal_rebate]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "normal_rebate";
            n_oTableSet.Fields(_sStrFldName).AliasName = "normal_rebate";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "normal_rebate";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "bit";
            
            
            // [hs_model] Field
            _sStrFldName = BusinessTrade.Para.hs_model;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[hs_model]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "hs_model";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[hs_model]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "hs_model";
            n_oTableSet.Fields(_sStrFldName).AliasName = "hs_model";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "hs_model";
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
            
            
            // [plan_fee] Field
            _sStrFldName = BusinessTrade.Para.plan_fee;
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
            n_oTableSet.Fields(_sStrFldName).Size = 10;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";
            
            
            // [po_date] Field
            _sStrFldName = BusinessTrade.Para.po_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[po_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<DateTime>";
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
            
            
            // [remarks] Field
            _sStrFldName = BusinessTrade.Para.remarks;
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
            
            
            // [issue_type] Field
            _sStrFldName = BusinessTrade.Para.issue_type;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[issue_type]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "issue_type";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[issue_type]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "issue_type";
            n_oTableSet.Fields(_sStrFldName).AliasName = "issue_type";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "issue_type";
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
            
        }
        #endregion
        
        
        #region Get & Set
        
        #region GetViewAll
        public bool GetViewAll(){ return n_bViewAll; }
        #endregion GetViewAll
        
        
        #region SetViewAll
        public void SetViewAll(bool value){  n_bViewAll=value; }
        #endregion SetViewAll
        
        
        #region GetTableSet
        public TableObj GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(TableObj value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        #region GetTableInfo
        public Field GetMidTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.mid);
        }
        public Field GetChannelTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.channel);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.cdate);
        }
        public Field GetBundle_nameTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.bundle_name);
        }
        public Field GetHs_model_nameTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.hs_model_name);
        }
        public Field GetTrade_fieldTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.trade_field);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.did);
        }
        public Field GetPremium_1Table(){
            return n_oTableSet.Fields(BusinessTrade.Para.premium_1);
        }
        public Field GetSdateTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.sdate);
        }
        public Field GetRebateTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.rebate);
        }
        public Field GetPremium_2Table(){
            return n_oTableSet.Fields(BusinessTrade.Para.premium_2);
        }
        public Field GetRetention_typeTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.retention_type);
        }
        public Field GetExtra_offerTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.extra_offer);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.edate);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.program);
        }
        public Field GetCon_perTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.con_per);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.rate_plan);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.ddate);
        }
        public Field GetNormal_rebate_typeTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.normal_rebate_type);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.active);
        }
        public Field GetFree_monTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.free_mon);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.cid);
        }
        public Field GetCancel_renewTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.cancel_renew);
        }
        public Field GetOb_earlyTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.ob_early);
        }
        public Field GetNormal_rebateTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.normal_rebate);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.hs_model);
        }
        public Field GetPlan_feeTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.plan_fee);
        }
        public Field GetPo_dateTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.po_date);
        }
        public Field GetRemarksTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.remarks);
        }
        public Field GetIssue_typeTable(){
            return n_oTableSet.Fields(BusinessTrade.Para.issue_type);
        }
        
        public Field Fields(string x_sColumn){
            return n_oTableSet.Fields(x_sColumn);
        }
        #endregion GetTableInfo
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


