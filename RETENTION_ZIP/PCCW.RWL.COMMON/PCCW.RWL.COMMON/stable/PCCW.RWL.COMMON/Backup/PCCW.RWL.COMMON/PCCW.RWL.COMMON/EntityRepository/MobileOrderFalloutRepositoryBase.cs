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
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Table :[MobileOrderFallout],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderFallout] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderFallout")]
    public class MobileOrderFalloutRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderFalloutRepositoryBase instance;
        public static MobileOrderFalloutRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr("MobileRetentionOrderDB");
                instance = new MobileOrderFalloutRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderFalloutRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderFalloutRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderFalloutEntity> MobileOrderFallouts;
        #endregion
        
        #region Constructor
        public MobileOrderFalloutRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderFalloutRepositoryBase() { 
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
        public static MobileOrderFallout CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr("MobileRetentionOrderDB");
            return new MobileOrderFallout(_oDB);
        }
        
        public static MobileOrderFallout CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderFallout(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderFallout]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
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
        
        
        public MobileOrderFalloutEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static MobileOrderFalloutEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderFallout _MobileOrderFallout = (MobileOrderFallout)MobileOrderFalloutRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderFallout.Load(x_iMid)) { return null; }
            return _MobileOrderFallout;
        }
        
        
        
        public static MobileOrderFalloutEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderFalloutEntity> _oMobileOrderFalloutList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            return _oMobileOrderFalloutList.Count == 0 ? null : _oMobileOrderFalloutList.ToArray();
        }
        
        public static List<MobileOrderFalloutEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderFalloutEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderFalloutEntity> _oMobileOrderFalloutList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oMobileOrderFalloutList.Count == 0 ? null : _oMobileOrderFalloutList.ToArray();
        }
        
        
        public static MobileOrderFalloutEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderFalloutEntity> _oMobileOrderFalloutList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oMobileOrderFalloutList.Count == 0 ? null : _oMobileOrderFalloutList.ToArray();
        }
        
        public static List<MobileOrderFalloutEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderFalloutEntity> _oRow = new List<MobileOrderFalloutEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderFallout].[did] AS MOBILEORDERFALLOUT_DID,[MobileOrderFallout].[cdate] AS MOBILEORDERFALLOUT_CDATE,[MobileOrderFallout].[cid] AS MOBILEORDERFALLOUT_CID,[MobileOrderFallout].[follow_by] AS MOBILEORDERFALLOUT_FOLLOW_BY,[MobileOrderFallout].[active] AS MOBILEORDERFALLOUT_ACTIVE,[MobileOrderFallout].[ddate] AS MOBILEORDERFALLOUT_DDATE,[MobileOrderFallout].[fo_reason] AS MOBILEORDERFALLOUT_FO_REASON,[MobileOrderFallout].[mid] AS MOBILEORDERFALLOUT_MID  FROM  [MobileOrderFallout]";
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
                _sQuery += " WHERE [MobileOrderFallout].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderFallout _oMobileOrderFallout = MobileOrderFalloutRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_ACTIVE"])) {_oMobileOrderFallout.active = (global::System.Nullable<bool>)_oData["MOBILEORDERFALLOUT_ACTIVE"]; }else{_oMobileOrderFallout.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CDATE"])) {_oMobileOrderFallout.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_CDATE"]; }else{_oMobileOrderFallout.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CID"])) {_oMobileOrderFallout.cid = (string)_oData["MOBILEORDERFALLOUT_CID"]; }else{_oMobileOrderFallout.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DID"])) {_oMobileOrderFallout.did = (string)_oData["MOBILEORDERFALLOUT_DID"]; }else{_oMobileOrderFallout.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DDATE"])) {_oMobileOrderFallout.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_DDATE"]; }else{_oMobileOrderFallout.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FO_REASON"])) {_oMobileOrderFallout.fo_reason = (string)_oData["MOBILEORDERFALLOUT_FO_REASON"]; }else{_oMobileOrderFallout.fo_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_MID"])) {_oMobileOrderFallout.mid = (global::System.Nullable<int>)_oData["MOBILEORDERFALLOUT_MID"]; }else{_oMobileOrderFallout.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FOLLOW_BY"])) {_oMobileOrderFallout.follow_by = (string)_oData["MOBILEORDERFALLOUT_FOLLOW_BY"]; }else{_oMobileOrderFallout.follow_by=global::System.String.Empty;}
                        _oMobileOrderFallout.SetDB(x_oDB);
                        _oMobileOrderFallout.GetFound();
                        _oRow.Add(_oMobileOrderFallout);
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
        
        
        public static MobileOrderFalloutEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderFalloutEntity> _oMobileOrderFalloutList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileOrderFalloutList.Count == 0 ? null : _oMobileOrderFalloutList.ToArray();
        }
        
        
        public static MobileOrderFalloutEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderFalloutEntity> _oMobileOrderFalloutList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oMobileOrderFalloutList.Count == 0 ? null : _oMobileOrderFalloutList.ToArray();
        }
        
        public static List<MobileOrderFalloutEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderFalloutEntity> _oRow = new List<MobileOrderFalloutEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderFallout].[did] AS MOBILEORDERFALLOUT_DID,[MobileOrderFallout].[cdate] AS MOBILEORDERFALLOUT_CDATE,[MobileOrderFallout].[cid] AS MOBILEORDERFALLOUT_CID,[MobileOrderFallout].[follow_by] AS MOBILEORDERFALLOUT_FOLLOW_BY,[MobileOrderFallout].[active] AS MOBILEORDERFALLOUT_ACTIVE,[MobileOrderFallout].[ddate] AS MOBILEORDERFALLOUT_DDATE,[MobileOrderFallout].[fo_reason] AS MOBILEORDERFALLOUT_FO_REASON,[MobileOrderFallout].[mid] AS MOBILEORDERFALLOUT_MID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderFalloutRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderFalloutEntity _oMobileOrderFallout = MobileOrderFalloutRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_ACTIVE"])) {_oMobileOrderFallout.active = (global::System.Nullable<bool>)_oData["MOBILEORDERFALLOUT_ACTIVE"]; } else {_oMobileOrderFallout.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CDATE"])) {_oMobileOrderFallout.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_CDATE"]; } else {_oMobileOrderFallout.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_CID"])) {_oMobileOrderFallout.cid = (string)_oData["MOBILEORDERFALLOUT_CID"]; } else {_oMobileOrderFallout.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DID"])) {_oMobileOrderFallout.did = (string)_oData["MOBILEORDERFALLOUT_DID"]; } else {_oMobileOrderFallout.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_DDATE"])) {_oMobileOrderFallout.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERFALLOUT_DDATE"]; } else {_oMobileOrderFallout.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FO_REASON"])) {_oMobileOrderFallout.fo_reason = (string)_oData["MOBILEORDERFALLOUT_FO_REASON"]; } else {_oMobileOrderFallout.fo_reason=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_MID"])) {_oMobileOrderFallout.mid = (global::System.Nullable<int>)_oData["MOBILEORDERFALLOUT_MID"]; } else {_oMobileOrderFallout.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERFALLOUT_FOLLOW_BY"])) {_oMobileOrderFallout.follow_by = (string)_oData["MOBILEORDERFALLOUT_FOLLOW_BY"]; } else {_oMobileOrderFallout.follow_by=global::System.String.Empty; }
                _oMobileOrderFallout.SetDB(x_oDB);
                _oMobileOrderFallout.GetFound();
                _oRow.Add(_oMobileOrderFallout);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderFallout.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderFallout.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderFallout.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderFallout.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderFallout].[did] AS MOBILEORDERFALLOUT_DID,[MobileOrderFallout].[cdate] AS MOBILEORDERFALLOUT_CDATE,[MobileOrderFallout].[cid] AS MOBILEORDERFALLOUT_CID,[MobileOrderFallout].[follow_by] AS MOBILEORDERFALLOUT_FOLLOW_BY,[MobileOrderFallout].[active] AS MOBILEORDERFALLOUT_ACTIVE,[MobileOrderFallout].[ddate] AS MOBILEORDERFALLOUT_DDATE,[MobileOrderFallout].[fo_reason] AS MOBILEORDERFALLOUT_FO_REASON,[MobileOrderFallout].[mid] AS MOBILEORDERFALLOUT_MID  FROM  [MobileOrderFallout]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderFallout");
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
        
        public bool Insert(global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sFo_reason,string x_sFollow_by)
        {
            MobileOrderFallout _oMobileOrderFallout=MobileOrderFalloutRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderFallout.active=x_bActive;
            _oMobileOrderFallout.cdate=x_dCdate;
            _oMobileOrderFallout.cid=x_sCid;
            _oMobileOrderFallout.did=x_sDid;
            _oMobileOrderFallout.ddate=x_dDdate;
            _oMobileOrderFallout.fo_reason=x_sFo_reason;
            _oMobileOrderFallout.follow_by=x_sFollow_by;
            return InsertWithOutLastID(n_oDB, _oMobileOrderFallout);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sFo_reason,string x_sFollow_by)
        {
            MobileOrderFallout _oMobileOrderFallout=MobileOrderFalloutRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderFallout.active=x_bActive;
            _oMobileOrderFallout.cdate=x_dCdate;
            _oMobileOrderFallout.cid=x_sCid;
            _oMobileOrderFallout.did=x_sDid;
            _oMobileOrderFallout.ddate=x_dDdate;
            _oMobileOrderFallout.fo_reason=x_sFo_reason;
            _oMobileOrderFallout.follow_by=x_sFollow_by;
            return InsertWithOutLastID(x_oDB, _oMobileOrderFallout);
        }
        
        
        public bool Insert(MobileOrderFallout x_oMobileOrderFallout)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderFallout);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderFallout)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderFallout)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderFallout x_oMobileOrderFallout)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderFallout);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderFallout x_oMobileOrderFallout)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderFallout]   ([did],[cdate],[cid],[follow_by],[active],[ddate],[fo_reason])  VALUES  (@did,@cdate,@cid,@follow_by,@active,@ddate,@fo_reason)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderFallout);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderFallout x_oMobileOrderFallout)
        {
            bool _bResult = false;
            if (!x_oMobileOrderFallout.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderFallout.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderFallout.did; }
                if(x_oMobileOrderFallout.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderFallout.cdate; }
                if(x_oMobileOrderFallout.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderFallout.cid; }
                if(x_oMobileOrderFallout.follow_by==null){  x_oCmd.Parameters.Add("@follow_by", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@follow_by", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderFallout.follow_by; }
                if(x_oMobileOrderFallout.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderFallout.active; }
                if(x_oMobileOrderFallout.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderFallout.ddate; }
                if(x_oMobileOrderFallout.fo_reason==null){  x_oCmd.Parameters.Add("@fo_reason", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fo_reason", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderFallout.fo_reason; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sFo_reason,string x_sFollow_by)
        {
            int _oLastID;
            MobileOrderFallout _oMobileOrderFallout=MobileOrderFalloutRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderFallout.active=x_bActive;
            _oMobileOrderFallout.cdate=x_dCdate;
            _oMobileOrderFallout.cid=x_sCid;
            _oMobileOrderFallout.did=x_sDid;
            _oMobileOrderFallout.ddate=x_dDdate;
            _oMobileOrderFallout.fo_reason=x_sFo_reason;
            _oMobileOrderFallout.follow_by=x_sFollow_by;
            if(InsertWithLastID(x_oDB, _oMobileOrderFallout,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderFallout x_oMobileOrderFallout)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderFallout, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderFallout x_oMobileOrderFallout)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderFallout, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderFallout)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderFallout)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderFallout x_oMobileOrderFallout, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderFallout]   ([did],[cdate],[cid],[follow_by],[active],[ddate],[fo_reason])  VALUES  (@did,@cdate,@cid,@follow_by,@active,@ddate,@fo_reason)"+" SELECT  @@IDENTITY AS MobileOrderFallout_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderFallout,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderFallout x_oMobileOrderFallout, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderFallout.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderFallout.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderFallout.did; }
                if(x_oMobileOrderFallout.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderFallout.cdate; }
                if(x_oMobileOrderFallout.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderFallout.cid; }
                if(x_oMobileOrderFallout.follow_by==null){  x_oCmd.Parameters.Add("@follow_by", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@follow_by", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderFallout.follow_by; }
                if(x_oMobileOrderFallout.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderFallout.active; }
                if(x_oMobileOrderFallout.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderFallout.ddate; }
                if(x_oMobileOrderFallout.fo_reason==null){  x_oCmd.Parameters.Add("@fo_reason", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fo_reason", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderFallout.fo_reason; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderFallout_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderFallout_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderFallout_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bActive,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dDdate,string x_sFo_reason,string x_sFollow_by)
        {
            int _oLastID;
            MobileOrderFallout _oMobileOrderFallout=MobileOrderFalloutRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderFallout.active=x_bActive;
            _oMobileOrderFallout.cdate=x_dCdate;
            _oMobileOrderFallout.cid=x_sCid;
            _oMobileOrderFallout.did=x_sDid;
            _oMobileOrderFallout.ddate=x_dDdate;
            _oMobileOrderFallout.fo_reason=x_sFo_reason;
            _oMobileOrderFallout.follow_by=x_sFollow_by;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderFallout,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderFallout x_oMobileOrderFallout)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderFallout, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderFallout x_oMobileOrderFallout)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderFallout, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderFallout)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderFallout)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderFallout x_oMobileOrderFallout, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERFALLOUT";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderFallout,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderFallout x_oMobileOrderFallout, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderFallout.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderFallout.did; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderFallout.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderFallout.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderFallout.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderFallout.cid; }
                _oPar=x_oCmd.Parameters.Add("@follow_by", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderFallout.follow_by==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderFallout.follow_by; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderFallout.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderFallout.active; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderFallout.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderFallout.ddate; }
                _oPar=x_oCmd.Parameters.Add("@fo_reason", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderFallout.fo_reason==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderFallout.fo_reason; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MID"].Value.ToString());
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
        
        #region INSERT_MOBILEORDERFALLOUT Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-04-20>
        ///-- Description:	<Description,MOBILEORDERFALLOUT, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERFALLOUT Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERFALLOUT', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERFALLOUT;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERFALLOUT
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @active bit,
        @cdate datetime,
        @cid char(10),
        @did char(10),
        @ddate datetime,
        @fo_reason nvarchar(250),
        @follow_by nvarchar(50)
        AS
        
        INSERT INTO  [MobileOrderFallout]   ([did],[cdate],[cid],[follow_by],[active],[ddate],[fo_reason])  VALUES  (@did,@cdate,@cid,@follow_by,@active,@ddate,@fo_reason)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_MID=@@IDENTITY
        RETURN @RETURN_MID
        END
        ELSE
        BEGIN
        SET @RETURN_MID=-1
        RETURN @RETURN_MID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(n_oDB, x_iMid);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(x_oDB, x_iMid);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_iMid==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderFallout]  WHERE [MobileOrderFallout].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
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
            return MobileOrderFalloutRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderFallout]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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
            string _sQuery = "DELETE FROM [MobileOrderFallout]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderFallout]","["+ Configurator.MSSQLTablePrefix + "MobileOrderFallout]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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


