using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-01>
///-- Description:	<Description,Table :[MobileGoWirelessDetail], Information layer>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileGoWirelessDetail] Information layer
    /// </summary>
    public abstract class MobileGoWirelessDetailInfoDLL{
        
        
        #region Parameter
        private TableObj n_oTableSet = new TableObj();
        public bool n_bViewAll=false;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Constructor
        
        public MobileGoWirelessDetailInfoDLL(){
            Init();
        }
        ~MobileGoWirelessDetailInfoDLL(){
            this.Release();
        }
        #endregion

        #region Create Instance Object
        public static MobileGoWirelessDetailInfo CreateInfoInstanceObject()
        {
            return new MobileGoWirelessDetailInfo();
        }
        #endregion
        
        #region Init
        public void Init()
        {
            
            string _sStrFldName;
            n_oTableSet.TableName = MobileGoWirelessDetail.Para.TableName();
            n_oTableSet.DefaultFilter = String.Empty;
            n_oTableSet.GroupBy = String.Empty;
            n_oTableSet.Having = String.Empty;
            n_oTableSet.DefaultOrderBy = String.Empty;
            
            // [cid] Field
            _sStrFldName = MobileGoWirelessDetail.Para.cid;
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";
            
            
            // [active] Field
            _sStrFldName = MobileGoWirelessDetail.Para.active;
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
            
            
            // [cdate] Field
            _sStrFldName = MobileGoWirelessDetail.Para.cdate;
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
            
            
            // [assign] Field
            _sStrFldName = MobileGoWirelessDetail.Para.assign;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[assign]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "assign";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[assign]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "assign";
            n_oTableSet.Fields(_sStrFldName).AliasName = "assign";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "assign";
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
            
            
            // [mrt_no] Field
            _sStrFldName = MobileGoWirelessDetail.Para.mrt_no;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[mrt_no]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<int>";
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
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "int";
            
            
            // [id] Field
            _sStrFldName = MobileGoWirelessDetail.Para.id;
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
            
            
            // [assign_staff] Field
            _sStrFldName = MobileGoWirelessDetail.Para.assign_staff;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[assign_staff]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "assign_staff";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[assign_staff]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "assign_staff";
            n_oTableSet.Fields(_sStrFldName).AliasName = "assign_staff";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "assign_staff";
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
            
            
            // [assign_date] Field
            _sStrFldName = MobileGoWirelessDetail.Para.assign_date;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[assign_date]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<DateTime>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "assign_date";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[assign_date]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "assign_date";
            n_oTableSet.Fields(_sStrFldName).AliasName = "assign_date";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "assign_date";
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
            
            
            // [order_id] Field
            _sStrFldName = MobileGoWirelessDetail.Para.order_id;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[order_id]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "System.Nullable<int>";
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
            _sStrFldName = MobileGoWirelessDetail.Para.ddate;
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
            
            
            // [did] Field
            _sStrFldName = MobileGoWirelessDetail.Para.did;
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
        public Field GetCidTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.cid);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.active);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.cdate);
        }
        public Field GetAssignTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.assign);
        }
        public Field GetMrt_noTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.mrt_no);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.id);
        }
        public Field GetAssign_staffTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_staff);
        }
        public Field GetAssign_dateTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.assign_date);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.order_id);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.ddate);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(MobileGoWirelessDetail.Para.did);
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


