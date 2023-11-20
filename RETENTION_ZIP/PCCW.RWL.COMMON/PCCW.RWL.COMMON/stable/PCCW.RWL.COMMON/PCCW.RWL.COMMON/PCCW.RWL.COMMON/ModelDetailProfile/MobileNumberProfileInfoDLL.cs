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
///-- Create date: <Create Date 2011-09-01>
///-- Description:	<Description,Table :[MobileNumberProfile], Information layer>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileNumberProfile] Information layer
    /// </summary>
    public abstract class MobileNumberProfileInfoDLL{
        
        
        #region Parameter
        private TableObj n_oTableSet = new TableObj();
        public bool n_bViewAll=false;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion
        
        #region CreateInfoInstanceObject
        public static MobileNumberProfileInfo CreateInfoInstanceObject(){
            return new MobileNumberProfileInfo();
        }
        #endregion
        #region Constructor
        
        public MobileNumberProfileInfoDLL(){
            Init();
        }
        ~MobileNumberProfileInfoDLL(){
            this.Release();
        }
        #endregion
        
        
        #region Init
        public void Init()
        {
            
            string _sStrFldName;
            n_oTableSet.TableName = MobileNumberProfile.Para.TableName();
            n_oTableSet.DefaultFilter = String.Empty;
            n_oTableSet.GroupBy = String.Empty;
            n_oTableSet.Having = String.Empty;
            n_oTableSet.DefaultOrderBy = String.Empty;
            
            // [pool] Field
            _sStrFldName = MobileNumberProfile.Para.pool;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[pool]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "pool";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[pool]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "pool";
            n_oTableSet.Fields(_sStrFldName).AliasName = "pool";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "pool";
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
            
            
            // [id] Field
            _sStrFldName = MobileNumberProfile.Para.id;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = true;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = true;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = true;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = true;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[id]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<int>";
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
            
            
            // [cdate] Field
            _sStrFldName = MobileNumberProfile.Para.cdate;
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
            
            
            // [cid] Field
            _sStrFldName = MobileNumberProfile.Para.cid;
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
            
            
            // [mrt_no] Field
            _sStrFldName = MobileNumberProfile.Para.mrt_no;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[mrt_no]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<long>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "mrt_no";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[mrt_no]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "mrt_no";
            n_oTableSet.Fields(_sStrFldName).AliasName = "mrt_no";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "mrt_no";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "bigint";
            
            
            // [status] Field
            _sStrFldName = MobileNumberProfile.Para.status;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[status]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "status";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[status]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "status";
            n_oTableSet.Fields(_sStrFldName).AliasName = "status";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "status";
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
            
            
            // [mrt_group] Field
            _sStrFldName = MobileNumberProfile.Para.mrt_group;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[mrt_group]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "mrt_group";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[mrt_group]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "mrt_group";
            n_oTableSet.Fields(_sStrFldName).AliasName = "mrt_group";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "mrt_group";
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
            
            
            // [active] Field
            _sStrFldName = MobileNumberProfile.Para.active;
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
            
            
            // [edf_no] Field
            _sStrFldName = MobileNumberProfile.Para.edf_no;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[edf_no]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "edf_no";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[edf_no]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "edf_no";
            n_oTableSet.Fields(_sStrFldName).AliasName = "edf_no";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "edf_no";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";
            
            
            // [order_id] Field
            _sStrFldName = MobileNumberProfile.Para.order_id;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[order_id]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "order_id";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[order_id]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "order_id";
            n_oTableSet.Fields(_sStrFldName).AliasName = "order_id";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "order_id";
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
            
            
            // [ddate] Field
            _sStrFldName = MobileNumberProfile.Para.ddate;
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
            
            
            // [did] Field
            _sStrFldName = MobileNumberProfile.Para.did;
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
        public Field GetPoolTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.pool);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.id);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.cdate);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.cid);
        }
        public Field GetMrt_noTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.mrt_no);
        }
        public Field GetStatusTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.status);
        }
        public Field GetMrt_groupTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.mrt_group);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.active);
        }
        public Field GetEdf_noTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.edf_no);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.order_id);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.ddate);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(MobileNumberProfile.Para.did);
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


