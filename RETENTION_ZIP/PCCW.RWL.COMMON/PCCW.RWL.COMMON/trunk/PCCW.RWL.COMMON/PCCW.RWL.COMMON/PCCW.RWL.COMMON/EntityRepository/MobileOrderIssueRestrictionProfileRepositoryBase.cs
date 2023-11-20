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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionProfile],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderIssueRestrictionProfile] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderIssueRestrictionProfile")]
    public class MobileOrderIssueRestrictionProfileRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderIssueRestrictionProfileRepositoryBase instance;
        public static MobileOrderIssueRestrictionProfileRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderIssueRestrictionProfileRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderIssueRestrictionProfileRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderIssueRestrictionProfileRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderIssueRestrictionProfileEntity> MobileOrderIssueRestrictionProfiles;
        #endregion
        
        #region Constructor
        public MobileOrderIssueRestrictionProfileRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderIssueRestrictionProfileRepositoryBase() { 
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
        public static MobileOrderIssueRestrictionProfile CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderIssueRestrictionProfile(_oDB);
        }
        
        public static MobileOrderIssueRestrictionProfile CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderIssueRestrictionProfile(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderIssueRestrictionProfile]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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
        
        
        public MobileOrderIssueRestrictionProfileEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static MobileOrderIssueRestrictionProfileEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderIssueRestrictionProfile _MobileOrderIssueRestrictionProfile = (MobileOrderIssueRestrictionProfile)MobileOrderIssueRestrictionProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderIssueRestrictionProfile.Load(x_iMid)) { return null; }
            return _MobileOrderIssueRestrictionProfile;
        }
        
        
        
        public static MobileOrderIssueRestrictionProfileEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfileList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionProfileList==null){ return null;}
            return _oMobileOrderIssueRestrictionProfileList.Count == 0 ? null : _oMobileOrderIssueRestrictionProfileList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionProfileEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderIssueRestrictionProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfileList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionProfileList==null){ return null;}
            return _oMobileOrderIssueRestrictionProfileList.Count == 0 ? null : _oMobileOrderIssueRestrictionProfileList.ToArray();
        }
        
        
        public static MobileOrderIssueRestrictionProfileEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfileList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderIssueRestrictionProfileList==null){ return null;}
            return _oMobileOrderIssueRestrictionProfileList.Count == 0 ? null : _oMobileOrderIssueRestrictionProfileList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionProfileEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderIssueRestrictionProfileEntity> _oRow = new List<MobileOrderIssueRestrictionProfileEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderIssueRestrictionProfile].[active] AS MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE,[MobileOrderIssueRestrictionProfile].[cdate] AS MOBILEORDERISSUERESTRICTIONPROFILE_CDATE,[MobileOrderIssueRestrictionProfile].[mrt_no] AS MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO,[MobileOrderIssueRestrictionProfile].[cid] AS MOBILEORDERISSUERESTRICTIONPROFILE_CID,[MobileOrderIssueRestrictionProfile].[mid] AS MOBILEORDERISSUERESTRICTIONPROFILE_MID,[MobileOrderIssueRestrictionProfile].[restriction_id] AS MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID  FROM  [MobileOrderIssueRestrictionProfile]";
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
                _sQuery += " WHERE [MobileOrderIssueRestrictionProfile].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderIssueRestrictionProfile _oMobileOrderIssueRestrictionProfile = MobileOrderIssueRestrictionProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"])) {_oMobileOrderIssueRestrictionProfile.mid = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"]; }else{_oMobileOrderIssueRestrictionProfile.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"])) {_oMobileOrderIssueRestrictionProfile.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"]; }else{_oMobileOrderIssueRestrictionProfile.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"])) {_oMobileOrderIssueRestrictionProfile.mrt_no = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"]; }else{_oMobileOrderIssueRestrictionProfile.mrt_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"])) {_oMobileOrderIssueRestrictionProfile.cid = (string)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"]; }else{_oMobileOrderIssueRestrictionProfile.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"])) {_oMobileOrderIssueRestrictionProfile.active = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"]; }else{_oMobileOrderIssueRestrictionProfile.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"])) {_oMobileOrderIssueRestrictionProfile.restriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"]; }else{_oMobileOrderIssueRestrictionProfile.restriction_id=null;}
                        _oMobileOrderIssueRestrictionProfile.SetDB(x_oDB);
                        _oMobileOrderIssueRestrictionProfile.GetFound();
                        _oRow.Add(_oMobileOrderIssueRestrictionProfile);
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
        
        
        public static MobileOrderIssueRestrictionProfileEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfileList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderIssueRestrictionProfileList==null){ return null;}
            return _oMobileOrderIssueRestrictionProfileList.Count == 0 ? null : _oMobileOrderIssueRestrictionProfileList.ToArray();
        }
        
        
        public static MobileOrderIssueRestrictionProfileEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfileList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderIssueRestrictionProfileList==null){ return null;}
            return _oMobileOrderIssueRestrictionProfileList.Count == 0 ? null : _oMobileOrderIssueRestrictionProfileList.ToArray();
        }
        
        public static List<MobileOrderIssueRestrictionProfileEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderIssueRestrictionProfileEntity> _oRow = new List<MobileOrderIssueRestrictionProfileEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderIssueRestrictionProfile].[active] AS MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE,[MobileOrderIssueRestrictionProfile].[cdate] AS MOBILEORDERISSUERESTRICTIONPROFILE_CDATE,[MobileOrderIssueRestrictionProfile].[mrt_no] AS MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO,[MobileOrderIssueRestrictionProfile].[cid] AS MOBILEORDERISSUERESTRICTIONPROFILE_CID,[MobileOrderIssueRestrictionProfile].[mid] AS MOBILEORDERISSUERESTRICTIONPROFILE_MID,[MobileOrderIssueRestrictionProfile].[restriction_id] AS MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderIssueRestrictionProfileRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderIssueRestrictionProfileEntity _oMobileOrderIssueRestrictionProfile = MobileOrderIssueRestrictionProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"])) {_oMobileOrderIssueRestrictionProfile.mid = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MID"]; } else {_oMobileOrderIssueRestrictionProfile.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"])) {_oMobileOrderIssueRestrictionProfile.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CDATE"]; } else {_oMobileOrderIssueRestrictionProfile.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"])) {_oMobileOrderIssueRestrictionProfile.mrt_no = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO"]; } else {_oMobileOrderIssueRestrictionProfile.mrt_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"])) {_oMobileOrderIssueRestrictionProfile.cid = (string)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_CID"]; } else {_oMobileOrderIssueRestrictionProfile.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"])) {_oMobileOrderIssueRestrictionProfile.active = (global::System.Nullable<bool>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE"]; } else {_oMobileOrderIssueRestrictionProfile.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"])) {_oMobileOrderIssueRestrictionProfile.restriction_id = (global::System.Nullable<int>)_oData["MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID"]; } else {_oMobileOrderIssueRestrictionProfile.restriction_id=null; }
                _oMobileOrderIssueRestrictionProfile.SetDB(x_oDB);
                _oMobileOrderIssueRestrictionProfile.GetFound();
                _oRow.Add(_oMobileOrderIssueRestrictionProfile);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderIssueRestrictionProfile.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderIssueRestrictionProfile.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderIssueRestrictionProfile.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderIssueRestrictionProfile.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderIssueRestrictionProfile].[active] AS MOBILEORDERISSUERESTRICTIONPROFILE_ACTIVE,[MobileOrderIssueRestrictionProfile].[cdate] AS MOBILEORDERISSUERESTRICTIONPROFILE_CDATE,[MobileOrderIssueRestrictionProfile].[mrt_no] AS MOBILEORDERISSUERESTRICTIONPROFILE_MRT_NO,[MobileOrderIssueRestrictionProfile].[cid] AS MOBILEORDERISSUERESTRICTIONPROFILE_CID,[MobileOrderIssueRestrictionProfile].[mid] AS MOBILEORDERISSUERESTRICTIONPROFILE_MID,[MobileOrderIssueRestrictionProfile].[restriction_id] AS MOBILEORDERISSUERESTRICTIONPROFILE_RESTRICTION_ID  FROM  [MobileOrderIssueRestrictionProfile]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderIssueRestrictionProfile");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<int> x_iMrt_no,string x_sCid,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iRestriction_id)
        {
            MobileOrderIssueRestrictionProfile _oMobileOrderIssueRestrictionProfile=MobileOrderIssueRestrictionProfileRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderIssueRestrictionProfile.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionProfile.mrt_no=x_iMrt_no;
            _oMobileOrderIssueRestrictionProfile.cid=x_sCid;
            _oMobileOrderIssueRestrictionProfile.active=x_bActive;
            _oMobileOrderIssueRestrictionProfile.restriction_id=x_iRestriction_id;
            return InsertWithOutLastID(n_oDB, _oMobileOrderIssueRestrictionProfile);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<int> x_iMrt_no,string x_sCid,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iRestriction_id)
        {
            MobileOrderIssueRestrictionProfile _oMobileOrderIssueRestrictionProfile=MobileOrderIssueRestrictionProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestrictionProfile.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionProfile.mrt_no=x_iMrt_no;
            _oMobileOrderIssueRestrictionProfile.cid=x_sCid;
            _oMobileOrderIssueRestrictionProfile.active=x_bActive;
            _oMobileOrderIssueRestrictionProfile.restriction_id=x_iRestriction_id;
            return InsertWithOutLastID(x_oDB, _oMobileOrderIssueRestrictionProfile);
        }
        
        
        public bool Insert(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderIssueRestrictionProfile);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderIssueRestrictionProfile)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderIssueRestrictionProfile)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderIssueRestrictionProfile);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderIssueRestrictionProfile]   ([active],[cdate],[mrt_no],[cid],[restriction_id])  VALUES  (@active,@cdate,@mrt_no,@cid,@restriction_id)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestrictionProfile);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            bool _bResult = false;
            if (!x_oMobileOrderIssueRestrictionProfile.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderIssueRestrictionProfile.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderIssueRestrictionProfile.active; }
                if(x_oMobileOrderIssueRestrictionProfile.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderIssueRestrictionProfile.cdate; }
                if(x_oMobileOrderIssueRestrictionProfile.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderIssueRestrictionProfile.mrt_no; }
                if(x_oMobileOrderIssueRestrictionProfile.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestrictionProfile.cid; }
                if(x_oMobileOrderIssueRestrictionProfile.restriction_id==null){  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderIssueRestrictionProfile.restriction_id; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<int> x_iMrt_no,string x_sCid,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iRestriction_id)
        {
            int _oLastID;
            MobileOrderIssueRestrictionProfile _oMobileOrderIssueRestrictionProfile=MobileOrderIssueRestrictionProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestrictionProfile.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionProfile.mrt_no=x_iMrt_no;
            _oMobileOrderIssueRestrictionProfile.cid=x_sCid;
            _oMobileOrderIssueRestrictionProfile.active=x_bActive;
            _oMobileOrderIssueRestrictionProfile.restriction_id=x_iRestriction_id;
            if(InsertWithLastID(x_oDB, _oMobileOrderIssueRestrictionProfile,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderIssueRestrictionProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderIssueRestrictionProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderIssueRestrictionProfile)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderIssueRestrictionProfile)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderIssueRestrictionProfile]   ([active],[cdate],[mrt_no],[cid],[restriction_id])  VALUES  (@active,@cdate,@mrt_no,@cid,@restriction_id)"+" SELECT  @@IDENTITY AS MobileOrderIssueRestrictionProfile_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestrictionProfile,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderIssueRestrictionProfile.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderIssueRestrictionProfile.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderIssueRestrictionProfile.active; }
                if(x_oMobileOrderIssueRestrictionProfile.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderIssueRestrictionProfile.cdate; }
                if(x_oMobileOrderIssueRestrictionProfile.mrt_no==null){  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderIssueRestrictionProfile.mrt_no; }
                if(x_oMobileOrderIssueRestrictionProfile.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderIssueRestrictionProfile.cid; }
                if(x_oMobileOrderIssueRestrictionProfile.restriction_id==null){  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderIssueRestrictionProfile.restriction_id; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderIssueRestrictionProfile_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderIssueRestrictionProfile_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderIssueRestrictionProfile_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<int> x_iMrt_no,string x_sCid,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iRestriction_id)
        {
            int _oLastID;
            MobileOrderIssueRestrictionProfile _oMobileOrderIssueRestrictionProfile=MobileOrderIssueRestrictionProfileRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderIssueRestrictionProfile.cdate=x_dCdate;
            _oMobileOrderIssueRestrictionProfile.mrt_no=x_iMrt_no;
            _oMobileOrderIssueRestrictionProfile.cid=x_sCid;
            _oMobileOrderIssueRestrictionProfile.active=x_bActive;
            _oMobileOrderIssueRestrictionProfile.restriction_id=x_iRestriction_id;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderIssueRestrictionProfile,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderIssueRestrictionProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderIssueRestrictionProfile, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderIssueRestrictionProfile)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderIssueRestrictionProfile)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERISSUERESTRICTIONPROFILE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderIssueRestrictionProfile,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionProfile.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionProfile.active; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionProfile.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionProfile.cdate; }
                _oPar=x_oCmd.Parameters.Add("@mrt_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionProfile.mrt_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionProfile.mrt_no; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionProfile.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionProfile.cid; }
                _oPar=x_oCmd.Parameters.Add("@restriction_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderIssueRestrictionProfile.restriction_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderIssueRestrictionProfile.restriction_id; }
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
        
        #region INSERT_MOBILEORDERISSUERESTRICTIONPROFILE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-12-17>
        ///-- Description:	<Description,MOBILEORDERISSUERESTRICTIONPROFILE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERISSUERESTRICTIONPROFILE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERISSUERESTRICTIONPROFILE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERISSUERESTRICTIONPROFILE;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERISSUERESTRICTIONPROFILE
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @cdate datetime,
        @mrt_no int,
        @cid nvarchar(50),
        @active bit,
        @restriction_id int
        AS
        
        INSERT INTO  [MobileOrderIssueRestrictionProfile]   ([active],[cdate],[mrt_no],[cid],[restriction_id])  VALUES  (@active,@cdate,@mrt_no,@cid,@restriction_id)
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
            string _sQuery = "DELETE FROM  [MobileOrderIssueRestrictionProfile]  WHERE [MobileOrderIssueRestrictionProfile].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
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
            return MobileOrderIssueRestrictionProfileRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderIssueRestrictionProfile]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderIssueRestrictionProfile]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderIssueRestrictionProfile]","["+ Configurator.MSSQLTablePrefix + "MobileOrderIssueRestrictionProfile]"); }
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


