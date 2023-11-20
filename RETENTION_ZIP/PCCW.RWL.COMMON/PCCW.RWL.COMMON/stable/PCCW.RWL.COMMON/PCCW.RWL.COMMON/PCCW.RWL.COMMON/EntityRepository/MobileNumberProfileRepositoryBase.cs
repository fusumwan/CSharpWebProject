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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-09-01>
///-- Description:	<Description,Table :[MobileNumberProfile],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileNumberProfile] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileNumberProfile")]
    public class MobileNumberProfileRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileNumberProfileRepositoryBase instance;
        public static MobileNumberProfileRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileNumberProfileRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileNumberProfileRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileNumberProfileRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileNumberProfileEntity> MobileNumberProfiles;
        #endregion
        
        #region Constructor
        public MobileNumberProfileRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileNumberProfileRepositoryBase() { 
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
        public static MobileNumberProfile CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileNumberProfile(_oDB);
        }
        
        public static MobileNumberProfile CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileNumberProfile(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileNumberProfile]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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
        
        
        public MobileNumberProfileEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileNumberProfileEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileNumberProfile _MobileNumberProfile = (MobileNumberProfile)MobileNumberProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileNumberProfile.Load(x_iId)) { return null; }
            return _MobileNumberProfile;
        }
        
        
        
        public static MobileNumberProfileEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileNumberProfileEntity> _oMobileNumberProfileList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMobileNumberProfileList==null){ return null;}
            return _oMobileNumberProfileList.Count == 0 ? null : _oMobileNumberProfileList.ToArray();
        }
        
        public static List<MobileNumberProfileEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileNumberProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileNumberProfileEntity> _oMobileNumberProfileList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileNumberProfileList==null){ return null;}
            return _oMobileNumberProfileList.Count == 0 ? null : _oMobileNumberProfileList.ToArray();
        }
        
        
        public static MobileNumberProfileEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileNumberProfileEntity> _oMobileNumberProfileList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileNumberProfileList==null){ return null;}
            return _oMobileNumberProfileList.Count == 0 ? null : _oMobileNumberProfileList.ToArray();
        }
        
        public static List<MobileNumberProfileEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileNumberProfileEntity> _oRow = new List<MobileNumberProfileEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileNumberProfile].[cid] AS MOBILENUMBERPROFILE_CID,[MobileNumberProfile].[id] AS MOBILENUMBERPROFILE_ID,[MobileNumberProfile].[cdate] AS MOBILENUMBERPROFILE_CDATE,[MobileNumberProfile].[pool] AS MOBILENUMBERPROFILE_POOL,[MobileNumberProfile].[mrt_no] AS MOBILENUMBERPROFILE_MRT_NO,[MobileNumberProfile].[status] AS MOBILENUMBERPROFILE_STATUS,[MobileNumberProfile].[mrt_group] AS MOBILENUMBERPROFILE_MRT_GROUP,[MobileNumberProfile].[active] AS MOBILENUMBERPROFILE_ACTIVE,[MobileNumberProfile].[edf_no] AS MOBILENUMBERPROFILE_EDF_NO,[MobileNumberProfile].[order_id] AS MOBILENUMBERPROFILE_ORDER_ID,[MobileNumberProfile].[ddate] AS MOBILENUMBERPROFILE_DDATE,[MobileNumberProfile].[did] AS MOBILENUMBERPROFILE_DID  FROM  [MobileNumberProfile]";
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
                _sQuery += " WHERE [MobileNumberProfile].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileNumberProfile _oMobileNumberProfile = MobileNumberProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_POOL"])) {_oMobileNumberProfile.pool = (string)_oData["MOBILENUMBERPROFILE_POOL"]; }else{_oMobileNumberProfile.pool=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ID"])) {_oMobileNumberProfile.id = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ID"]; }else{_oMobileNumberProfile.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CDATE"])) {_oMobileNumberProfile.cdate = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_CDATE"]; }else{_oMobileNumberProfile.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CID"])) {_oMobileNumberProfile.cid = (string)_oData["MOBILENUMBERPROFILE_CID"]; }else{_oMobileNumberProfile.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_NO"])) {_oMobileNumberProfile.mrt_no = (global::System.Nullable<long>)_oData["MOBILENUMBERPROFILE_MRT_NO"]; }else{_oMobileNumberProfile.mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_STATUS"])) {_oMobileNumberProfile.status = (string)_oData["MOBILENUMBERPROFILE_STATUS"]; }else{_oMobileNumberProfile.status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_GROUP"])) {_oMobileNumberProfile.mrt_group = (string)_oData["MOBILENUMBERPROFILE_MRT_GROUP"]; }else{_oMobileNumberProfile.mrt_group=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ACTIVE"])) {_oMobileNumberProfile.active = (global::System.Nullable<bool>)_oData["MOBILENUMBERPROFILE_ACTIVE"]; }else{_oMobileNumberProfile.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_EDF_NO"])) {_oMobileNumberProfile.edf_no = (string)_oData["MOBILENUMBERPROFILE_EDF_NO"]; }else{_oMobileNumberProfile.edf_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ORDER_ID"])) {_oMobileNumberProfile.order_id = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ORDER_ID"]; }else{_oMobileNumberProfile.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DDATE"])) {_oMobileNumberProfile.ddate = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_DDATE"]; }else{_oMobileNumberProfile.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DID"])) {_oMobileNumberProfile.did = (string)_oData["MOBILENUMBERPROFILE_DID"]; }else{_oMobileNumberProfile.did=global::System.String.Empty;}
                        _oMobileNumberProfile.SetDB(x_oDB);
                        _oMobileNumberProfile.GetFound();
                        _oRow.Add(_oMobileNumberProfile);
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
        
        
        public static MobileNumberProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileNumberProfileEntity> _oMobileNumberProfileList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileNumberProfileList==null){ return null;}
            return _oMobileNumberProfileList.Count == 0 ? null : _oMobileNumberProfileList.ToArray();
        }
        
        
        public static MobileNumberProfileEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileNumberProfileEntity> _oMobileNumberProfileList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileNumberProfileList==null){ return null;}
            return _oMobileNumberProfileList.Count == 0 ? null : _oMobileNumberProfileList.ToArray();
        }
        
        public static List<MobileNumberProfileEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileNumberProfileEntity> _oRow = new List<MobileNumberProfileEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileNumberProfile].[cid] AS MOBILENUMBERPROFILE_CID,[MobileNumberProfile].[id] AS MOBILENUMBERPROFILE_ID,[MobileNumberProfile].[cdate] AS MOBILENUMBERPROFILE_CDATE,[MobileNumberProfile].[pool] AS MOBILENUMBERPROFILE_POOL,[MobileNumberProfile].[mrt_no] AS MOBILENUMBERPROFILE_MRT_NO,[MobileNumberProfile].[status] AS MOBILENUMBERPROFILE_STATUS,[MobileNumberProfile].[mrt_group] AS MOBILENUMBERPROFILE_MRT_GROUP,[MobileNumberProfile].[active] AS MOBILENUMBERPROFILE_ACTIVE,[MobileNumberProfile].[edf_no] AS MOBILENUMBERPROFILE_EDF_NO,[MobileNumberProfile].[order_id] AS MOBILENUMBERPROFILE_ORDER_ID,[MobileNumberProfile].[ddate] AS MOBILENUMBERPROFILE_DDATE,[MobileNumberProfile].[did] AS MOBILENUMBERPROFILE_DID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileNumberProfileRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileNumberProfileEntity _oMobileNumberProfile = MobileNumberProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_POOL"])) {_oMobileNumberProfile.pool = (string)_oData["MOBILENUMBERPROFILE_POOL"]; } else {_oMobileNumberProfile.pool=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ID"])) {_oMobileNumberProfile.id = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ID"]; } else {_oMobileNumberProfile.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CDATE"])) {_oMobileNumberProfile.cdate = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_CDATE"]; } else {_oMobileNumberProfile.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_CID"])) {_oMobileNumberProfile.cid = (string)_oData["MOBILENUMBERPROFILE_CID"]; } else {_oMobileNumberProfile.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_NO"])) {_oMobileNumberProfile.mrt_no = (global::System.Nullable<long>)_oData["MOBILENUMBERPROFILE_MRT_NO"]; } else {_oMobileNumberProfile.mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_STATUS"])) {_oMobileNumberProfile.status = (string)_oData["MOBILENUMBERPROFILE_STATUS"]; } else {_oMobileNumberProfile.status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_MRT_GROUP"])) {_oMobileNumberProfile.mrt_group = (string)_oData["MOBILENUMBERPROFILE_MRT_GROUP"]; } else {_oMobileNumberProfile.mrt_group=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ACTIVE"])) {_oMobileNumberProfile.active = (global::System.Nullable<bool>)_oData["MOBILENUMBERPROFILE_ACTIVE"]; } else {_oMobileNumberProfile.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_EDF_NO"])) {_oMobileNumberProfile.edf_no = (string)_oData["MOBILENUMBERPROFILE_EDF_NO"]; } else {_oMobileNumberProfile.edf_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_ORDER_ID"])) {_oMobileNumberProfile.order_id = (global::System.Nullable<int>)_oData["MOBILENUMBERPROFILE_ORDER_ID"]; } else {_oMobileNumberProfile.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DDATE"])) {_oMobileNumberProfile.ddate = (global::System.Nullable<DateTime>)_oData["MOBILENUMBERPROFILE_DDATE"]; } else {_oMobileNumberProfile.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILENUMBERPROFILE_DID"])) {_oMobileNumberProfile.did = (string)_oData["MOBILENUMBERPROFILE_DID"]; } else {_oMobileNumberProfile.did=global::System.String.Empty; }
                _oMobileNumberProfile.SetDB(x_oDB);
                _oMobileNumberProfile.GetFound();
                _oRow.Add(_oMobileNumberProfile);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileNumberProfile.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileNumberProfile.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileNumberProfile.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileNumberProfile.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileNumberProfile].[cid] AS MOBILENUMBERPROFILE_CID,[MobileNumberProfile].[id] AS MOBILENUMBERPROFILE_ID,[MobileNumberProfile].[cdate] AS MOBILENUMBERPROFILE_CDATE,[MobileNumberProfile].[pool] AS MOBILENUMBERPROFILE_POOL,[MobileNumberProfile].[mrt_no] AS MOBILENUMBERPROFILE_MRT_NO,[MobileNumberProfile].[status] AS MOBILENUMBERPROFILE_STATUS,[MobileNumberProfile].[mrt_group] AS MOBILENUMBERPROFILE_MRT_GROUP,[MobileNumberProfile].[active] AS MOBILENUMBERPROFILE_ACTIVE,[MobileNumberProfile].[edf_no] AS MOBILENUMBERPROFILE_EDF_NO,[MobileNumberProfile].[order_id] AS MOBILENUMBERPROFILE_ORDER_ID,[MobileNumberProfile].[ddate] AS MOBILENUMBERPROFILE_DDATE,[MobileNumberProfile].[did] AS MOBILENUMBERPROFILE_DID  FROM  [MobileNumberProfile]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileNumberProfile");
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
        
        public bool Insert(string x_sPool,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<long> x_lMrt_no,string x_sStatus,string x_sMrt_group,global::System.Nullable<bool> x_bActive,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            MobileNumberProfile _oMobileNumberProfile=MobileNumberProfileRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileNumberProfile.pool=x_sPool;
            _oMobileNumberProfile.cdate=x_dCdate;
            _oMobileNumberProfile.cid=x_sCid;
            _oMobileNumberProfile.mrt_no=x_lMrt_no;
            _oMobileNumberProfile.status=x_sStatus;
            _oMobileNumberProfile.mrt_group=x_sMrt_group;
            _oMobileNumberProfile.active=x_bActive;
            _oMobileNumberProfile.edf_no=x_sEdf_no;
            _oMobileNumberProfile.order_id=x_iOrder_id;
            _oMobileNumberProfile.ddate=x_dDdate;
            _oMobileNumberProfile.did=x_sDid;
            return InsertWithOutLastID(n_oDB, _oMobileNumberProfile);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sPool,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<long> x_lMrt_no,string x_sStatus,string x_sMrt_group,global::System.Nullable<bool> x_bActive,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            MobileNumberProfile _oMobileNumberProfile=MobileNumberProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileNumberProfile.pool=x_sPool;
            _oMobileNumberProfile.cdate=x_dCdate;
            _oMobileNumberProfile.cid=x_sCid;
            _oMobileNumberProfile.mrt_no=x_lMrt_no;
            _oMobileNumberProfile.status=x_sStatus;
            _oMobileNumberProfile.mrt_group=x_sMrt_group;
            _oMobileNumberProfile.active=x_bActive;
            _oMobileNumberProfile.edf_no=x_sEdf_no;
            _oMobileNumberProfile.order_id=x_iOrder_id;
            _oMobileNumberProfile.ddate=x_dDdate;
            _oMobileNumberProfile.did=x_sDid;
            return InsertWithOutLastID(x_oDB, _oMobileNumberProfile);
        }
        
        
        public bool Insert(MobileNumberProfile x_oMobileNumberProfile)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileNumberProfile);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileNumberProfile)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileNumberProfile)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileNumberProfile x_oMobileNumberProfile)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileNumberProfile);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileNumberProfile x_oMobileNumberProfile)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileNumberProfile]   ([cid],[cdate],[pool],[mrt_no],[status],[mrt_group],[active],[edf_no],[order_id],[ddate],[did])  VALUES  (@cid,@cdate,@pool,@mrt_no,@status,@mrt_group,@active,@edf_no,@order_id,@ddate,@did)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileNumberProfile);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileNumberProfile x_oMobileNumberProfile)
        {
            bool _bResult = false;
            if (!x_oMobileNumberProfile.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileNumberProfile.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileNumberProfile.cid; }
                if(x_oMobileNumberProfile.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileNumberProfile.cdate; }
                if(x_oMobileNumberProfile.pool==null){  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileNumberProfile.pool; }
                if(x_oMobileNumberProfile.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.BigInt).Value=x_oMobileNumberProfile.mrt_no; }
                if(x_oMobileNumberProfile.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileNumberProfile.status; }
                if(x_oMobileNumberProfile.mrt_group==null){  x_oCmd.Parameters.Add("@mrt_group", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_group", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileNumberProfile.mrt_group; }
                if(x_oMobileNumberProfile.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileNumberProfile.active; }
                if(x_oMobileNumberProfile.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileNumberProfile.edf_no; }
                if(x_oMobileNumberProfile.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileNumberProfile.order_id; }
                if(x_oMobileNumberProfile.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileNumberProfile.ddate; }
                if(x_oMobileNumberProfile.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileNumberProfile.did; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sPool,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<long> x_lMrt_no,string x_sStatus,string x_sMrt_group,global::System.Nullable<bool> x_bActive,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            int _oLastID;
            MobileNumberProfile _oMobileNumberProfile=MobileNumberProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileNumberProfile.pool=x_sPool;
            _oMobileNumberProfile.cdate=x_dCdate;
            _oMobileNumberProfile.cid=x_sCid;
            _oMobileNumberProfile.mrt_no=x_lMrt_no;
            _oMobileNumberProfile.status=x_sStatus;
            _oMobileNumberProfile.mrt_group=x_sMrt_group;
            _oMobileNumberProfile.active=x_bActive;
            _oMobileNumberProfile.edf_no=x_sEdf_no;
            _oMobileNumberProfile.order_id=x_iOrder_id;
            _oMobileNumberProfile.ddate=x_dDdate;
            _oMobileNumberProfile.did=x_sDid;
            if(InsertWithLastID(x_oDB, _oMobileNumberProfile,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileNumberProfile x_oMobileNumberProfile)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileNumberProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileNumberProfile x_oMobileNumberProfile)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileNumberProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileNumberProfile)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileNumberProfile)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileNumberProfile x_oMobileNumberProfile, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileNumberProfile]   ([cid],[cdate],[pool],[mrt_no],[status],[mrt_group],[active],[edf_no],[order_id],[ddate],[did])  VALUES  (@cid,@cdate,@pool,@mrt_no,@status,@mrt_group,@active,@edf_no,@order_id,@ddate,@did)"+" SELECT  @@IDENTITY AS MobileNumberProfile_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileNumberProfile,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileNumberProfile x_oMobileNumberProfile, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileNumberProfile.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileNumberProfile.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileNumberProfile.cid; }
                if(x_oMobileNumberProfile.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileNumberProfile.cdate; }
                if(x_oMobileNumberProfile.pool==null){  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileNumberProfile.pool; }
                if(x_oMobileNumberProfile.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.BigInt).Value=x_oMobileNumberProfile.mrt_no; }
                if(x_oMobileNumberProfile.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileNumberProfile.status; }
                if(x_oMobileNumberProfile.mrt_group==null){  x_oCmd.Parameters.Add("@mrt_group", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_group", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileNumberProfile.mrt_group; }
                if(x_oMobileNumberProfile.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileNumberProfile.active; }
                if(x_oMobileNumberProfile.edf_no==null){  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15).Value=x_oMobileNumberProfile.edf_no; }
                if(x_oMobileNumberProfile.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileNumberProfile.order_id; }
                if(x_oMobileNumberProfile.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileNumberProfile.ddate; }
                if(x_oMobileNumberProfile.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileNumberProfile.did; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileNumberProfile_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileNumberProfile_LASTID"].ToString()) && int.TryParse(_oData["MobileNumberProfile_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sPool,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<long> x_lMrt_no,string x_sStatus,string x_sMrt_group,global::System.Nullable<bool> x_bActive,string x_sEdf_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dDdate,string x_sDid)
        {
            int _oLastID;
            MobileNumberProfile _oMobileNumberProfile=MobileNumberProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileNumberProfile.pool=x_sPool;
            _oMobileNumberProfile.cdate=x_dCdate;
            _oMobileNumberProfile.cid=x_sCid;
            _oMobileNumberProfile.mrt_no=x_lMrt_no;
            _oMobileNumberProfile.status=x_sStatus;
            _oMobileNumberProfile.mrt_group=x_sMrt_group;
            _oMobileNumberProfile.active=x_bActive;
            _oMobileNumberProfile.edf_no=x_sEdf_no;
            _oMobileNumberProfile.order_id=x_iOrder_id;
            _oMobileNumberProfile.ddate=x_dDdate;
            _oMobileNumberProfile.did=x_sDid;
            if(InsertWithLastID_SP(x_oDB, _oMobileNumberProfile,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileNumberProfile x_oMobileNumberProfile)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileNumberProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileNumberProfile x_oMobileNumberProfile)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileNumberProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileNumberProfile)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileNumberProfile)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileNumberProfile x_oMobileNumberProfile, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILENUMBERPROFILE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileNumberProfile,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileNumberProfile x_oMobileNumberProfile, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.cid; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileNumberProfile.cdate; }
                _oPar=x_oCmd.Parameters.Add("@pool", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.pool==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.pool; }
                _oPar=x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.status; }
                _oPar=x_oCmd.Parameters.Add("@mrt_group", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.mrt_group==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.mrt_group; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.active; }
                _oPar=x_oCmd.Parameters.Add("@edf_no", global::System.Data.SqlDbType.NVarChar,15);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.edf_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.edf_no; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.order_id; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileNumberProfile.ddate; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileNumberProfile.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileNumberProfile.did; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
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
        
        #region INSERT_MOBILENUMBERPROFILE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-09-01>
        ///-- Description:	<Description,MOBILENUMBERPROFILE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILENUMBERPROFILE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILENUMBERPROFILE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILENUMBERPROFILE;
        GO
        CREATE PROCEDURE INSERT_MOBILENUMBERPROFILE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @pool nvarchar(50),
        @cdate datetime,
        @cid nvarchar(10),
        @mrt_no bigint,
        @status nvarchar(50),
        @mrt_group nvarchar(50),
        @active bit,
        @edf_no nvarchar(15),
        @order_id int,
        @ddate datetime,
        @did nvarchar(10)
        AS
        
        INSERT INTO  [MobileNumberProfile]   ([cid],[cdate],[pool],[mrt_no],[status],[mrt_group],[active],[edf_no],[order_id],[ddate],[did])  VALUES  (@cid,@cdate,@pool,@mrt_no,@status,@mrt_group,@active,@edf_no,@order_id,@ddate,@did)
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
        
        public bool Delete(global::System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileNumberProfile]  WHERE [MobileNumberProfile].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return MobileNumberProfileRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileNumberProfile]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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
            string _sQuery = "DELETE FROM [MobileNumberProfile]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileNumberProfile]","["+ Configurator.MSSQLTablePrefix + "MobileNumberProfile]"); }
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


