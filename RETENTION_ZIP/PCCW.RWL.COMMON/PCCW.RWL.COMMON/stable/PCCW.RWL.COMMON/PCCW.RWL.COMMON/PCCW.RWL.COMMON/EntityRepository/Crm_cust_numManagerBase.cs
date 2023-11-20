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
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[crm_cust_num],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [crm_cust_num] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= "crm_cust_num")]
    public class Crm_cust_numManagerBase: System.Data.Linq.DataContext{
        
        #region Instance
        private static Crm_cust_numManagerBase instance;
        public static Crm_cust_numManagerBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.CRM + (((Configurator.IsUat()) ? "2" : string.Empty)));
                instance = new Crm_cust_numManagerBase(_oDB);
            }
            return instance;
        }
        public static Crm_cust_numManagerBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new Crm_cust_numManagerBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<Crm_cust_numBase> Crm_cust_nums;
        #endregion
        
        #region Constructor
        public Crm_cust_numManagerBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~Crm_cust_numManagerBase() {
            this.Connection.Close();
            this.Connection.Dispose();
        }
        #endregion
        
        #region Count
        
        /// <summary>
        /// Summary description for Counting
        /// </summary>
        
        public int GetCount()
        {
            return GetCount(n_oDB);
        }
        public static int GetCount(MSSQLConnect x_oDB)
        {
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [crm_cust_num]";

            global::System.Data.SqlClient.SqlConnection _oConn=x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            _oConn.Open();
            int _iTotalCount = 0;
            try
            {
                global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    _iTotalCount = (int)_oData["TotalCount"];
                }
            }
            catch{}
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _iTotalCount;
        }
        #endregion
        
        #region Get
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        
        public static Crm_cust_num[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Crm_cust_num> _oRow = new global::System.Collections.Generic.List<Crm_cust_num>();
            string _sQuery = "SELECT [crm_cust_num].[active] AS CRM_CUST_NUM_ACTIVE,[crm_cust_num].[cdate] AS CRM_CUST_NUM_CDATE,[crm_cust_num].[cid] AS CRM_CUST_NUM_CID,[crm_cust_num].[did] AS CRM_CUST_NUM_DID,[crm_cust_num].[cust_num] AS CRM_CUST_NUM_CUST_NUM,[crm_cust_num].[cust_id] AS CRM_CUST_NUM_CUST_ID,[crm_cust_num].[order_id] AS CRM_CUST_NUM_ORDER_ID,[crm_cust_num].[ddate] AS CRM_CUST_NUM_DDATE  FROM  [crm_cust_num]";
            if (x_oArrayItemId!=null)
            {
                string _oList = "(";
                for (int i = 0; i < x_oArrayItemId.Count; i++)
                {
                    if (i < (x_oArrayItemId.Count - 1))
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "',";
                    }
                    else
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "'";
                    }
                }
                _oList += ")";
                _sQuery += " WHERE [crm_cust_num].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            _oConn.Open();
            try
            {
                global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                while (_oData.Read())
                {
                    Crm_cust_num _oCrm_cust_num = new Crm_cust_num();
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_ACTIVE"])) {_oCrm_cust_num.active = (global::System.Nullable<bool>)_oData["CRM_CUST_NUM_ACTIVE"]; }else{_oCrm_cust_num.active=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CDATE"])) {_oCrm_cust_num.cdate = (global::System.Nullable<DateTime>)_oData["CRM_CUST_NUM_CDATE"]; }else{_oCrm_cust_num.cdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CID"])) {_oCrm_cust_num.cid = (string)_oData["CRM_CUST_NUM_CID"]; }else{_oCrm_cust_num.cid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_DID"])) {_oCrm_cust_num.did = (string)_oData["CRM_CUST_NUM_DID"]; }else{_oCrm_cust_num.did=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CUST_NUM"])) {_oCrm_cust_num.cust_num = (string)_oData["CRM_CUST_NUM_CUST_NUM"]; }else{_oCrm_cust_num.cust_num=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CUST_ID"])) {_oCrm_cust_num.cust_id = (global::System.Nullable<int>)_oData["CRM_CUST_NUM_CUST_ID"]; }else{_oCrm_cust_num.cust_id=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_ORDER_ID"])) {_oCrm_cust_num.order_id = (global::System.Nullable<int>)_oData["CRM_CUST_NUM_ORDER_ID"]; }else{_oCrm_cust_num.order_id=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_DDATE"])) {_oCrm_cust_num.ddate = (global::System.Nullable<DateTime>)_oData["CRM_CUST_NUM_DDATE"]; }else{_oCrm_cust_num.ddate=null;}
                    _oCrm_cust_num.SetDB(x_oDB);
                    _oCrm_cust_num.GetFound();
                    _oRow.Add(_oCrm_cust_num);
                }
                _oData.Close();
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        
        public static Crm_cust_num[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Crm_cust_num> _oRow = new global::System.Collections.Generic.List<Crm_cust_num>();
            string _sFields="[crm_cust_num].[active] AS CRM_CUST_NUM_ACTIVE,[crm_cust_num].[cdate] AS CRM_CUST_NUM_CDATE,[crm_cust_num].[cid] AS CRM_CUST_NUM_CID,[crm_cust_num].[did] AS CRM_CUST_NUM_DID,[crm_cust_num].[cust_num] AS CRM_CUST_NUM_CUST_NUM,[crm_cust_num].[cust_id] AS CRM_CUST_NUM_CUST_ID,[crm_cust_num].[order_id] AS CRM_CUST_NUM_ORDER_ID,[crm_cust_num].[ddate] AS CRM_CUST_NUM_DDATE";
            
            global::System.Data.SqlClient.SqlDataReader _oData = Crm_cust_numManagerBase.GetSearch(x_oDB, _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                Crm_cust_num _oCrm_cust_num = new Crm_cust_num();
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_ACTIVE"])) {_oCrm_cust_num.active = (global::System.Nullable<bool>)_oData["CRM_CUST_NUM_ACTIVE"]; } else {_oCrm_cust_num.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CDATE"])) {_oCrm_cust_num.cdate = (global::System.Nullable<DateTime>)_oData["CRM_CUST_NUM_CDATE"]; } else {_oCrm_cust_num.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CID"])) {_oCrm_cust_num.cid = (string)_oData["CRM_CUST_NUM_CID"]; } else {_oCrm_cust_num.cid=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_DID"])) {_oCrm_cust_num.did = (string)_oData["CRM_CUST_NUM_DID"]; } else {_oCrm_cust_num.did=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CUST_NUM"])) {_oCrm_cust_num.cust_num = (string)_oData["CRM_CUST_NUM_CUST_NUM"]; } else {_oCrm_cust_num.cust_num=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_CUST_ID"])) {_oCrm_cust_num.cust_id = (global::System.Nullable<int>)_oData["CRM_CUST_NUM_CUST_ID"]; } else {_oCrm_cust_num.cust_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_ORDER_ID"])) {_oCrm_cust_num.order_id = (global::System.Nullable<int>)_oData["CRM_CUST_NUM_ORDER_ID"]; } else {_oCrm_cust_num.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUST_NUM_DDATE"])) {_oCrm_cust_num.ddate = (global::System.Nullable<DateTime>)_oData["CRM_CUST_NUM_DDATE"]; } else {_oCrm_cust_num.ddate=null; }
                _oCrm_cust_num.SetDB(x_oDB);
                _oCrm_cust_num.GetFound();
                _oRow.Add(_oCrm_cust_num);
            }
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        #endregion
        
        #region List
        /// <summary>
        /// Summary description for get table from records with DataSet
        /// </summary>
        
        public global::System.Data.DataSet GetDataSet()
        {
            return GetDataSet(n_oDB,"");
        }
        
        
        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB,x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( Crm_cust_num.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,Crm_cust_num.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(Crm_cust_num.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Crm_cust_num.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT [crm_cust_num].[active] AS CRM_CUST_NUM_ACTIVE,[crm_cust_num].[cdate] AS CRM_CUST_NUM_CDATE,[crm_cust_num].[cid] AS CRM_CUST_NUM_CID,[crm_cust_num].[did] AS CRM_CUST_NUM_DID,[crm_cust_num].[cust_num] AS CRM_CUST_NUM_CUST_NUM,[crm_cust_num].[cust_id] AS CRM_CUST_NUM_CUST_ID,[crm_cust_num].[order_id] AS CRM_CUST_NUM_ORDER_ID,[crm_cust_num].[ddate] AS CRM_CUST_NUM_DDATE  FROM  [crm_cust_num]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
            try
            {
                _oConn.Open();
                _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                _oAdp.SelectCommand.ExecuteNonQuery();
                _oAdp.Fill(_oDset,"crm_cust_num");
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oAdp.Dispose();
                _oConn.Dispose();
            }
            return _oDset;
        }
        #endregion
        
        #region Insert
        /// <summary>
        /// Summary description for management Insert
        /// </summary>
        
        public bool Insert(global::System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_num,System.Nullable<int> x_iCust_id,System.Nullable<DateTime> x_dDdate)
        {
            Crm_cust_num _oCrm_cust_num=new Crm_cust_num();
            _oCrm_cust_num.active=x_bActive;
            _oCrm_cust_num.cdate=x_dCdate;
            _oCrm_cust_num.cid=x_sCid;
            _oCrm_cust_num.did=x_sDid;
            _oCrm_cust_num.cust_num=x_sCust_num;
            _oCrm_cust_num.cust_id=x_iCust_id;
            _oCrm_cust_num.ddate=x_dDdate;
            return InsertWithOutLastID(n_oDB, _oCrm_cust_num);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_num,System.Nullable<int> x_iCust_id,System.Nullable<DateTime> x_dDdate)
        {
            Crm_cust_num _oCrm_cust_num=new Crm_cust_num();
            _oCrm_cust_num.active=x_bActive;
            _oCrm_cust_num.cdate=x_dCdate;
            _oCrm_cust_num.cid=x_sCid;
            _oCrm_cust_num.did=x_sDid;
            _oCrm_cust_num.cust_num=x_sCust_num;
            _oCrm_cust_num.cust_id=x_iCust_id;
            _oCrm_cust_num.ddate=x_dDdate;
            return InsertWithOutLastID(x_oDB, _oCrm_cust_num);
        }
        
        
        public bool Insert(Crm_cust_num x_oCrm_cust_num)
        {
            return InsertWithOutLastID(n_oDB, x_oCrm_cust_num);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,Crm_cust_num x_oCrm_cust_num)
        {
            return InsertWithOutLastID(x_oDB, x_oCrm_cust_num);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Crm_cust_num x_oCrm_cust_num)
        {
            if (!x_oCrm_cust_num.Vaild(true)) { return false; }
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [crm_cust_num]   ([active],[cdate],[cid],[did],[cust_num],[cust_id],[ddate])  VALUES  (@active,@cdate,@cid,@did,@cust_num,@cust_id,@ddate)";
            
            global::System.Data.SqlClient.SqlConnection _oConn =x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            if(x_oCrm_cust_num.active==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oCrm_cust_num.active; }
            if(x_oCrm_cust_num.cdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oCrm_cust_num.cdate; }
            if(string.IsNullOrEmpty(x_oCrm_cust_num.cid)){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,50).Value=x_oCrm_cust_num.cid; }
            if(string.IsNullOrEmpty(x_oCrm_cust_num.did)){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,50).Value=x_oCrm_cust_num.did; }
            if(string.IsNullOrEmpty(x_oCrm_cust_num.cust_num)){  _oCmd.Parameters.Add("@cust_num", global::System.Data.SqlDbType.VarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_num", global::System.Data.SqlDbType.VarChar,10).Value=x_oCrm_cust_num.cust_num; }
            if(x_oCrm_cust_num.cust_id==null){  _oCmd.Parameters.Add("@cust_id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_id", global::System.Data.SqlDbType.Int).Value=x_oCrm_cust_num.cust_id; }
            if(x_oCrm_cust_num.ddate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oCrm_cust_num.ddate; }
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return Crm_cust_numManagerBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [crm_cust_num]";
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        
        
        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB,x_sFilter);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return false; }
            if (!"".Equals(x_sFilter)){x_sFilter=" WHERE "+x_sFilter;}
            string _sQuery = "DELETE FROM [crm_cust_num]"+x_sFilter;
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        #endregion
    }
}


