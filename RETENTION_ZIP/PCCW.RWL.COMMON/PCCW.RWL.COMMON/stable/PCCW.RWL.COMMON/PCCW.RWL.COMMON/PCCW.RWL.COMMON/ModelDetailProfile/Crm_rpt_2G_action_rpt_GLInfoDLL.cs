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
///-- Create date: <Create Date 2009-07-13>
///-- Description:	<Description,Table :[crm_rpt_2G_action_rpt_GL], Information layer>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [crm_rpt_2G_action_rpt_GL] Information layer
    /// </summary>
    public abstract class Crm_rpt_2G_action_rpt_GLInfoDLL{
        
        
        #region Parameter
        private TableObj n_oTableSet = new TableObj();
        public bool n_bViewAll=false;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Constructor
        
        public Crm_rpt_2G_action_rpt_GLInfoDLL(){
            Init();
        }
        ~Crm_rpt_2G_action_rpt_GLInfoDLL(){
            this.Release();
        }
        #endregion
        
        
        #region Init
        public void Init()
        {
            
            string _sStrFldName;
            n_oTableSet.TableName = Crm_rpt_2G_action_rpt_GL.Para.TableName();
            n_oTableSet.DefaultFilter = String.Empty;
            n_oTableSet.GroupBy = String.Empty;
            n_oTableSet.Having = String.Empty;
            n_oTableSet.DefaultOrderBy = String.Empty;
            
            // [als_flg] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.als_flg;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[als_flg]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "als_flg";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[als_flg]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "als_flg";
            n_oTableSet.Fields(_sStrFldName).AliasName = "als_flg";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "als_flg";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [end_date] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.end_date;
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
            
            
            // [remarks] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.remarks;
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
            n_oTableSet.Fields(_sStrFldName).Size = 100;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [airtime_hs_model] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[airtime_hs_model]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "airtime_hs_model";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[airtime_hs_model]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "airtime_hs_model";
            n_oTableSet.Fields(_sStrFldName).AliasName = "airtime_hs_model";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "airtime_hs_model";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [start_date] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.start_date;
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
            
            
            // [calllist_name] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.calllist_name;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[calllist_name]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "calllist_name";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[calllist_name]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "calllist_name";
            n_oTableSet.Fields(_sStrFldName).AliasName = "calllist_name";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "calllist_name";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [join_date] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.join_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[join_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "join_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[join_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "join_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "join_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "join_date";
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
            
            
            // [field1] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.field1;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[field1]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "field1";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[field1]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "field1";
            n_oTableSet.Fields(_sStrFldName).AliasName = "field1";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "field1";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [bill_cycle] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.bill_cycle;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[bill_cycle]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "bill_cycle";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[bill_cycle]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "bill_cycle";
            n_oTableSet.Fields(_sStrFldName).AliasName = "bill_cycle";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "bill_cycle";
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
            
            
            // [addr_3] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.addr_3;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[addr_3]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "addr_3";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[addr_3]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "addr_3";
            n_oTableSet.Fields(_sStrFldName).AliasName = "addr_3";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "addr_3";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [addr_2] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.addr_2;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[addr_2]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "addr_2";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[addr_2]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "addr_2";
            n_oTableSet.Fields(_sStrFldName).AliasName = "addr_2";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "addr_2";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [id_number] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.id_number;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[id_number]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "id_number";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[id_number]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "id_number";
            n_oTableSet.Fields(_sStrFldName).AliasName = "id_number";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "id_number";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [attention_name_formartted] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[attention_name_formartted]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "attention_name_formartted";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[attention_name_formartted]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "attention_name_formartted";
            n_oTableSet.Fields(_sStrFldName).AliasName = "attention_name_formartted";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "attention_name_formartted";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [customer_name_formartted] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[customer_name_formartted]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "customer_name_formartted";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[customer_name_formartted]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "customer_name_formartted";
            n_oTableSet.Fields(_sStrFldName).AliasName = "customer_name_formartted";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "customer_name_formartted";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [autopay] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.autopay;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[autopay]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "autopay";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[autopay]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "autopay";
            n_oTableSet.Fields(_sStrFldName).AliasName = "autopay";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "autopay";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [field3] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.field3;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[field3]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "field3";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[field3]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "field3";
            n_oTableSet.Fields(_sStrFldName).AliasName = "field3";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "field3";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [addr_4] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.addr_4;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[addr_4]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "addr_4";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[addr_4]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "addr_4";
            n_oTableSet.Fields(_sStrFldName).AliasName = "addr_4";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "addr_4";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [program] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.program;
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
            n_oTableSet.Fields(_sStrFldName).Size = 250;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [prop_plan] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.prop_plan;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[prop_plan]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "prop_plan";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[prop_plan]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "prop_plan";
            n_oTableSet.Fields(_sStrFldName).AliasName = "prop_plan";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "prop_plan";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [customer_group] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.customer_group;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[customer_group]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "customer_group";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[customer_group]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "customer_group";
            n_oTableSet.Fields(_sStrFldName).AliasName = "customer_group";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "customer_group";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [customer_code] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.customer_code;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[customer_code]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "customer_code";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[customer_code]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "customer_code";
            n_oTableSet.Fields(_sStrFldName).AliasName = "customer_code";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "customer_code";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [telemarketing_suppress_flag] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[telemarketing_suppress_flag]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "telemarketing_suppress_flag";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[telemarketing_suppress_flag]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "telemarketing_suppress_flag";
            n_oTableSet.Fields(_sStrFldName).AliasName = "telemarketing_suppress_flag";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "telemarketing_suppress_flag";
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
            
            
            // [idd_flg] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.idd_flg;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[idd_flg]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "idd_flg";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[idd_flg]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "idd_flg";
            n_oTableSet.Fields(_sStrFldName).AliasName = "idd_flg";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "idd_flg";
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
            
            
            // [active] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.active;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[active]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<bool>";
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
            
            
            // [ddate] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.ddate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[ddate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
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
            
            
            // [id] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.id;
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
            
            
            // [plan_fee] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.plan_fee;
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [rate_plan] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.rate_plan;
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [segment] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.segment;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[segment]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "segment";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[segment]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "segment";
            n_oTableSet.Fields(_sStrFldName).AliasName = "segment";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "segment";
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
            n_oTableSet.Fields(_sStrFldName).Size = 15;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [id1] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.id1;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[id1]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "id1";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[id1]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "id1";
            n_oTableSet.Fields(_sStrFldName).AliasName = "id1";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "id1";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [password] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.password;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[password]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "password";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[password]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "password";
            n_oTableSet.Fields(_sStrFldName).AliasName = "password";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "password";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [payment_method] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.payment_method;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[payment_method]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "payment_method";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[payment_method]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "payment_method";
            n_oTableSet.Fields(_sStrFldName).AliasName = "payment_method";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "payment_method";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [contract_id] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.contract_id;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[contract_id]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "contract_id";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[contract_id]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "contract_id";
            n_oTableSet.Fields(_sStrFldName).AliasName = "contract_id";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "contract_id";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [field2] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.field2;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[field2]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "field2";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[field2]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "field2";
            n_oTableSet.Fields(_sStrFldName).AliasName = "field2";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "field2";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [mobile_no] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.mobile_no;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[mobile_no]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "mobile_no";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[mobile_no]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "mobile_no";
            n_oTableSet.Fields(_sStrFldName).AliasName = "mobile_no";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "mobile_no";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = false;
            n_oTableSet.Fields(_sStrFldName).Size = 50;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [period] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.period;
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [vas_desc] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.vas_desc;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[vas_desc]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "vas_desc";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[vas_desc]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "vas_desc";
            n_oTableSet.Fields(_sStrFldName).AliasName = "vas_desc";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "vas_desc";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [cdate] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.cdate;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[cdate]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
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
            
            
            // [subscriber_tier] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[subscriber_tier]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "subscriber_tier";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[subscriber_tier]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "subscriber_tier";
            n_oTableSet.Fields(_sStrFldName).AliasName = "subscriber_tier";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "subscriber_tier";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [customer_id] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.customer_id;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[customer_id]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "customer_id";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[customer_id]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "customer_id";
            n_oTableSet.Fields(_sStrFldName).AliasName = "customer_id";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "customer_id";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [handset_rebate_end_date] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[handset_rebate_end_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "handset_rebate_end_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[handset_rebate_end_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "handset_rebate_end_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "handset_rebate_end_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "handset_rebate_end_date";
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
            
            
            // [plan_free_inter_min] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[plan_free_inter_min]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "plan_free_inter_min";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[plan_free_inter_min]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "plan_free_inter_min";
            n_oTableSet.Fields(_sStrFldName).AliasName = "plan_free_inter_min";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "plan_free_inter_min";
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
            
            
            // [cid] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.cid;
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
            n_oTableSet.Fields(_sStrFldName).Size = 50;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [did] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.did;
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
            n_oTableSet.Fields(_sStrFldName).Size = 50;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [expired_month] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.expired_month;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[expired_month]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "expired_month";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[expired_month]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "expired_month";
            n_oTableSet.Fields(_sStrFldName).AliasName = "expired_month";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "expired_month";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [plan_free_intra_min] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[plan_free_intra_min]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "plan_free_intra_min";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[plan_free_intra_min]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "plan_free_intra_min";
            n_oTableSet.Fields(_sStrFldName).AliasName = "plan_free_intra_min";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "plan_free_intra_min";
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
            
            
            // [original_telemarketing_suppress_flag] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[original_telemarketing_suppress_flag]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "original_telemarketing_suppress_flag";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[original_telemarketing_suppress_flag]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "original_telemarketing_suppress_flag";
            n_oTableSet.Fields(_sStrFldName).AliasName = "original_telemarketing_suppress_flag";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "original_telemarketing_suppress_flag";
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
            
            
            // [contact_number] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.contact_number;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[contact_number]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "contact_number";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[contact_number]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "contact_number";
            n_oTableSet.Fields(_sStrFldName).AliasName = "contact_number";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "contact_number";
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
            n_oTableSet.Fields(_sStrFldName).Size = 20;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [tradefield] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.tradefield;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[tradefield]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "tradefield";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[tradefield]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "tradefield";
            n_oTableSet.Fields(_sStrFldName).AliasName = "tradefield";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "tradefield";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [addr_1] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.addr_1;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[addr_1]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "addr_1";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[addr_1]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "addr_1";
            n_oTableSet.Fields(_sStrFldName).AliasName = "addr_1";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "addr_1";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
            
            // [max_contract_end_date] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[max_contract_end_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "max_contract_end_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[max_contract_end_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "max_contract_end_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "max_contract_end_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "max_contract_end_date";
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
            
            
            // [mnp_rebate_end_date] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[mnp_rebate_end_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "mnp_rebate_end_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[mnp_rebate_end_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "mnp_rebate_end_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "mnp_rebate_end_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "mnp_rebate_end_date";
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
            
            
            // [program_id] Field
            _sStrFldName = Crm_rpt_2G_action_rpt_GL.Para.program_id;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[program_id]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "program_id";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[program_id]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "program_id";
            n_oTableSet.Fields(_sStrFldName).AliasName = "program_id";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "program_id";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";
            
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
        public Field GetAls_flgTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg);
        }
        public Field GetEnd_dateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date);
        }
        public Field GetRemarksTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks);
        }
        public Field GetAirtime_hs_modelTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model);
        }
        public Field GetStart_dateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date);
        }
        public Field GetCalllist_nameTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name);
        }
        public Field GetJoin_dateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date);
        }
        public Field GetField1Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1);
        }
        public Field GetBill_cycleTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle);
        }
        public Field GetAddr_3Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3);
        }
        public Field GetAddr_2Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2);
        }
        public Field GetId_numberTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number);
        }
        public Field GetAttention_name_formarttedTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted);
        }
        public Field GetCustomer_name_formarttedTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted);
        }
        public Field GetAutopayTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay);
        }
        public Field GetField3Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3);
        }
        public Field GetAddr_4Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4);
        }
        public Field GetProgramTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program);
        }
        public Field GetProp_planTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan);
        }
        public Field GetCustomer_groupTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group);
        }
        public Field GetCustomer_codeTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code);
        }
        public Field GetTelemarketing_suppress_flagTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag);
        }
        public Field GetIdd_flgTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id);
        }
        public Field GetPlan_feeTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee);
        }
        public Field GetRate_planTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan);
        }
        public Field GetSegmentTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment);
        }
        public Field GetId1Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1);
        }
        public Field GetPasswordTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password);
        }
        public Field GetPayment_methodTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method);
        }
        public Field GetContract_idTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id);
        }
        public Field GetField2Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2);
        }
        public Field GetMobile_noTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no);
        }
        public Field GetPeriodTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period);
        }
        public Field GetVas_descTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate);
        }
        public Field GetSubscriber_tierTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier);
        }
        public Field GetCustomer_idTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id);
        }
        public Field GetHandset_rebate_end_dateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date);
        }
        public Field GetPlan_free_inter_minTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did);
        }
        public Field GetExpired_monthTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month);
        }
        public Field GetPlan_free_intra_minTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min);
        }
        public Field GetOriginal_telemarketing_suppress_flagTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag);
        }
        public Field GetContact_numberTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number);
        }
        public Field GetTradefieldTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield);
        }
        public Field GetAddr_1Table(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1);
        }
        public Field GetMax_contract_end_dateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date);
        }
        public Field GetMnp_rebate_end_dateTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date);
        }
        public Field GetProgram_idTable(){
            return n_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id);
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


