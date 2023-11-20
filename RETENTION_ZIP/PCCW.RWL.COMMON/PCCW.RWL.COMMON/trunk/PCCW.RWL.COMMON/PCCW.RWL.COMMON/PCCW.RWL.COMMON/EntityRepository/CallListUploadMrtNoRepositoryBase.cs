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
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadMrtNo],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CallListUploadMrtNo] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"CallListUploadMrtNo")]
    public class CallListUploadMrtNoRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static CallListUploadMrtNoRepositoryBase instance;
        public static CallListUploadMrtNoRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new CallListUploadMrtNoRepositoryBase(_oDB);
            }
            return instance;
        }
        public static CallListUploadMrtNoRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new CallListUploadMrtNoRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<CallListUploadMrtNoEntity> CallListUploadMrtNos;
        #endregion
        
        #region Constructor
        public CallListUploadMrtNoRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~CallListUploadMrtNoRepositoryBase() { 
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
            }
        }
        #endregion
        #region Create Instance Object
        /// <summary>
        /// Summary description for Create Instance Object
        /// </summary>
        public static CallListUploadMrtNo CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new CallListUploadMrtNo(_oDB);
        }
        
        public static CallListUploadMrtNo CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new CallListUploadMrtNo(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [CallListUploadMrtNo]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn=x_oDB.GetConnection()){
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
                    _oData.Close();
                    _oData.Dispose();
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
        }
        #endregion
        
        #region Get Array & List
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        public CallListUploadMrtNoEntity GetObj(global::System.Nullable<long> x_lId)
        {
            return GetObj(n_oDB, x_lId);
        }
        
        
        public static CallListUploadMrtNoEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            if (x_oDB==null) { return null; }
            CallListUploadMrtNo _CallListUploadMrtNo = (CallListUploadMrtNo)CallListUploadMrtNoRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_CallListUploadMrtNo.Load(x_lId)) { return null; }
            return _CallListUploadMrtNo;
        }
        
        
        
        public static CallListUploadMrtNoEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<CallListUploadMrtNoEntity> _oCallListUploadMrtNoList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oCallListUploadMrtNoList==null){ return null;}
            return _oCallListUploadMrtNoList.Count == 0 ? null : _oCallListUploadMrtNoList.ToArray();
        }
        
        public static List<CallListUploadMrtNoEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static CallListUploadMrtNoEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<CallListUploadMrtNoEntity> _oCallListUploadMrtNoList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oCallListUploadMrtNoList==null){ return null;}
            return _oCallListUploadMrtNoList.Count == 0 ? null : _oCallListUploadMrtNoList.ToArray();
        }
        
        
        public static CallListUploadMrtNoEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<CallListUploadMrtNoEntity> _oCallListUploadMrtNoList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oCallListUploadMrtNoList==null){ return null;}
            return _oCallListUploadMrtNoList.Count == 0 ? null : _oCallListUploadMrtNoList.ToArray();
        }
        
        public static List<CallListUploadMrtNoEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<CallListUploadMrtNoEntity> _oRow = new List<CallListUploadMrtNoEntity>();
            string _sQuery = "SELECT  "+_sTop+" [CallListUploadMrtNo].[cdate] AS CALLLISTUPLOADMRTNO_CDATE,[CallListUploadMrtNo].[mrt_no] AS CALLLISTUPLOADMRTNO_MRT_NO,[CallListUploadMrtNo].[call_list_program_id] AS CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID,[CallListUploadMrtNo].[id] AS CALLLISTUPLOADMRTNO_ID  FROM  [CallListUploadMrtNo]";
            if (x_oArrayItemId==null)
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
                _sQuery += " WHERE [CallListUploadMrtNo].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        CallListUploadMrtNo _oCallListUploadMrtNo = CallListUploadMrtNoRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CDATE"])) {_oCallListUploadMrtNo.cdate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADMRTNO_CDATE"]; }else{_oCallListUploadMrtNo.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_MRT_NO"])) {_oCallListUploadMrtNo.mrt_no = (string)_oData["CALLLISTUPLOADMRTNO_MRT_NO"]; }else{_oCallListUploadMrtNo.mrt_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"])) {_oCallListUploadMrtNo.call_list_program_id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"]; }else{_oCallListUploadMrtNo.call_list_program_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_ID"])) {_oCallListUploadMrtNo.id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_ID"]; }else{_oCallListUploadMrtNo.id=null;}
                        _oCallListUploadMrtNo.SetDB(x_oDB);
                        _oCallListUploadMrtNo.GetFound();
                        _oRow.Add(_oCallListUploadMrtNo);
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch { }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRow;
            }
        }
        
        
        public static CallListUploadMrtNoEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<CallListUploadMrtNoEntity> _oCallListUploadMrtNoList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oCallListUploadMrtNoList==null){ return null;}
            return _oCallListUploadMrtNoList.Count == 0 ? null : _oCallListUploadMrtNoList.ToArray();
        }
        
        
        public static CallListUploadMrtNoEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<CallListUploadMrtNoEntity> _oCallListUploadMrtNoList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oCallListUploadMrtNoList==null){ return null;}
            return _oCallListUploadMrtNoList.Count == 0 ? null : _oCallListUploadMrtNoList.ToArray();
        }
        
        public static List<CallListUploadMrtNoEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<CallListUploadMrtNoEntity> _oRow = new List<CallListUploadMrtNoEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[CallListUploadMrtNo].[cdate] AS CALLLISTUPLOADMRTNO_CDATE,[CallListUploadMrtNo].[mrt_no] AS CALLLISTUPLOADMRTNO_MRT_NO,[CallListUploadMrtNo].[call_list_program_id] AS CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID,[CallListUploadMrtNo].[id] AS CALLLISTUPLOADMRTNO_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = CallListUploadMrtNoRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                CallListUploadMrtNoEntity _oCallListUploadMrtNo = CallListUploadMrtNoRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CDATE"])) {_oCallListUploadMrtNo.cdate = (global::System.Nullable<DateTime>)_oData["CALLLISTUPLOADMRTNO_CDATE"]; } else {_oCallListUploadMrtNo.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_MRT_NO"])) {_oCallListUploadMrtNo.mrt_no = (string)_oData["CALLLISTUPLOADMRTNO_MRT_NO"]; } else {_oCallListUploadMrtNo.mrt_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"])) {_oCallListUploadMrtNo.call_list_program_id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID"]; } else {_oCallListUploadMrtNo.call_list_program_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["CALLLISTUPLOADMRTNO_ID"])) {_oCallListUploadMrtNo.id = (global::System.Nullable<long>)_oData["CALLLISTUPLOADMRTNO_ID"]; } else {_oCallListUploadMrtNo.id=null; }
                _oCallListUploadMrtNo.SetDB(x_oDB);
                _oCallListUploadMrtNo.GetFound();
                _oRow.Add(_oCallListUploadMrtNo);
            }
            _oData.Close();
            _oData.Dispose();
            return _oRow;
        }
        #endregion
        
        #region DataSet
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( CallListUploadMrtNo.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,CallListUploadMrtNo.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(CallListUploadMrtNo.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(CallListUploadMrtNo.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [CallListUploadMrtNo].[cdate] AS CALLLISTUPLOADMRTNO_CDATE,[CallListUploadMrtNo].[mrt_no] AS CALLLISTUPLOADMRTNO_MRT_NO,[CallListUploadMrtNo].[call_list_program_id] AS CALLLISTUPLOADMRTNO_CALL_LIST_PROGRAM_ID,[CallListUploadMrtNo].[id] AS CALLLISTUPLOADMRTNO_ID  FROM  [CallListUploadMrtNo]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"CallListUploadMrtNo");
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
        }
        #endregion
        #region Insert
        
        
        /// <summary>
        /// Summary description for management Insert
        /// </summary>
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sMrt_no,global::System.Nullable<long> x_lCall_list_program_id)
        {
            CallListUploadMrtNo _oCallListUploadMrtNo=CallListUploadMrtNoRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oCallListUploadMrtNo.cdate=x_dCdate;
            _oCallListUploadMrtNo.mrt_no=x_sMrt_no;
            _oCallListUploadMrtNo.call_list_program_id=x_lCall_list_program_id;
            return InsertWithOutLastID(n_oDB, _oCallListUploadMrtNo);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sMrt_no,global::System.Nullable<long> x_lCall_list_program_id)
        {
            CallListUploadMrtNo _oCallListUploadMrtNo=CallListUploadMrtNoRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCallListUploadMrtNo.cdate=x_dCdate;
            _oCallListUploadMrtNo.mrt_no=x_sMrt_no;
            _oCallListUploadMrtNo.call_list_program_id=x_lCall_list_program_id;
            return InsertWithOutLastID(x_oDB, _oCallListUploadMrtNo);
        }
        
        
        public bool Insert(CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            return InsertWithOutLastID(n_oDB, x_oCallListUploadMrtNo);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is CallListUploadMrtNo)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (CallListUploadMrtNo)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            return InsertWithOutLastID(x_oDB, x_oCallListUploadMrtNo);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [CallListUploadMrtNo]   ([cdate],[mrt_no],[call_list_program_id])  VALUES  (@cdate,@mrt_no,@call_list_program_id)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn =x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oCallListUploadMrtNo);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            bool _bResult = false;
            if (!x_oCallListUploadMrtNo.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oCallListUploadMrtNo.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oCallListUploadMrtNo.cdate; }
                if(x_oCallListUploadMrtNo.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oCallListUploadMrtNo.mrt_no; }
                if(x_oCallListUploadMrtNo.call_list_program_id==null){  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=x_oCallListUploadMrtNo.call_list_program_id; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sMrt_no,global::System.Nullable<long> x_lCall_list_program_id)
        {
            int _oLastID;
            CallListUploadMrtNo _oCallListUploadMrtNo=CallListUploadMrtNoRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCallListUploadMrtNo.cdate=x_dCdate;
            _oCallListUploadMrtNo.mrt_no=x_sMrt_no;
            _oCallListUploadMrtNo.call_list_program_id=x_lCall_list_program_id;
            if(InsertWithLastID(x_oDB, _oCallListUploadMrtNo,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oCallListUploadMrtNo, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oCallListUploadMrtNo, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is CallListUploadMrtNo)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (CallListUploadMrtNo)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,CallListUploadMrtNo x_oCallListUploadMrtNo, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [CallListUploadMrtNo]   ([cdate],[mrt_no],[call_list_program_id])  VALUES  (@cdate,@mrt_no,@call_list_program_id)"+" SELECT  @@IDENTITY AS CallListUploadMrtNo_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oCallListUploadMrtNo,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,CallListUploadMrtNo x_oCallListUploadMrtNo, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oCallListUploadMrtNo.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oCallListUploadMrtNo.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oCallListUploadMrtNo.cdate; }
                if(x_oCallListUploadMrtNo.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50).Value=x_oCallListUploadMrtNo.mrt_no; }
                if(x_oCallListUploadMrtNo.call_list_program_id==null){  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=x_oCallListUploadMrtNo.call_list_program_id; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["CallListUploadMrtNo_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["CallListUploadMrtNo_LASTID"].ToString()) && int.TryParse(_oData["CallListUploadMrtNo_LASTID"].ToString(),out x_iLAST_ID)){
                            _bResult=true;
                        }
                        else
                        {
                            x_iLAST_ID = -1;
                        }
                    }
                }
                _oData.Close();
                _oData.Dispose();
            }
            catch {  }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sMrt_no,global::System.Nullable<long> x_lCall_list_program_id)
        {
            int _oLastID;
            CallListUploadMrtNo _oCallListUploadMrtNo=CallListUploadMrtNoRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oCallListUploadMrtNo.cdate=x_dCdate;
            _oCallListUploadMrtNo.mrt_no=x_sMrt_no;
            _oCallListUploadMrtNo.call_list_program_id=x_lCall_list_program_id;
            if(InsertWithLastID_SP(x_oDB, _oCallListUploadMrtNo,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oCallListUploadMrtNo, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, CallListUploadMrtNo x_oCallListUploadMrtNo)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oCallListUploadMrtNo, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is CallListUploadMrtNo)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (CallListUploadMrtNo)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,CallListUploadMrtNo x_oCallListUploadMrtNo, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "CALLLISTUPLOADMRTNO";
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (x_oDB.bTransaction)
            {
                x_oDB.ISessionCmd.CommandText = _sQuery;
                x_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = x_oDB.ISessionCmd;
                _oConn = x_oDB.ISessionConn;
            }
            else
            {
                _oConn = x_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oCallListUploadMrtNo,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,CallListUploadMrtNo x_oCallListUploadMrtNo, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadMrtNo.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oCallListUploadMrtNo.cdate; }
                _oPar=x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadMrtNo.mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCallListUploadMrtNo.mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oCallListUploadMrtNo.call_list_program_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oCallListUploadMrtNo.call_list_program_id; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
            }
            catch { }
            finally
            {
                if (!x_oDB.bTransaction)
                {
                    x_oConn.Close();
                    x_oCmd.Dispose();
                    x_oConn.Dispose();
                }
            }
            return _bResult;
        }
        
        #region INSERT_CALLLISTUPLOADMRTNO Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-09-15>
        ///-- Description:	<Description,CALLLISTUPLOADMRTNO, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_CALLLISTUPLOADMRTNO Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_CALLLISTUPLOADMRTNO', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_CALLLISTUPLOADMRTNO;
        GO
        CREATE PROCEDURE INSERT_CALLLISTUPLOADMRTNO
        	-- Add the parameters for the stored procedure here
        @RETURN_ID bigint output,
        @cdate datetime,
        @mrt_no nvarchar(50),
        @call_list_program_id bigint
        AS
        
        INSERT INTO  [CallListUploadMrtNo]   ([cdate],[mrt_no],[call_list_program_id])  VALUES  (@cdate,@mrt_no,@call_list_program_id)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ID=@@IDENTITY
        RETURN @RETURN_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ID=-1
        RETURN @RETURN_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<long> x_lId)
        {
            return DeleteProc(n_oDB, x_lId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId)
        {
            return DeleteProc(x_oDB, x_lId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lId)
        {
            if (x_lId==null) { return false; }
            string _sQuery = "DELETE FROM  [CallListUploadMrtNo]  WHERE [CallListUploadMrtNo].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.BigInt).Value = x_lId;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return CallListUploadMrtNoRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [CallListUploadMrtNo]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oCmd.CommandType = CommandType.Text;
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        
        
        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB,x_sFilter);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return false; }
            if (!"".Equals(x_sFilter)){x_sFilter=" WHERE "+x_sFilter;}
            string _sQuery = "DELETE FROM [CallListUploadMrtNo]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[CallListUploadMrtNo]","["+ Configurator.MSSQLTablePrefix + "CallListUploadMrtNo]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.CommandType = CommandType.Text;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        }
        #endregion
        
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
        
    }
}


