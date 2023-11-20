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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportStyle],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportStyle] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReportStyle")]
    public class MobileOrderReportStyleRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportStyleRepositoryBase instance;
        public static MobileOrderReportStyleRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportStyleRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportStyleRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportStyleRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportStyleEntity> MobileOrderReportStyles;
        #endregion
        
        #region Constructor
        public MobileOrderReportStyleRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportStyleRepositoryBase() { 
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
        public static MobileOrderReportStyle CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReportStyle(_oDB);
        }
        
        public static MobileOrderReportStyle CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReportStyle(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReportStyle]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
        
        
        public MobileOrderReportStyleEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileOrderReportStyleEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportStyle _MobileOrderReportStyle = (MobileOrderReportStyle)MobileOrderReportStyleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportStyle.Load(x_iId)) { return null; }
            return _MobileOrderReportStyle;
        }
        
        
        
        public static MobileOrderReportStyleEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportStyleEntity> _oMobileOrderReportStyleList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMobileOrderReportStyleList==null){ return null;}
            return _oMobileOrderReportStyleList.Count == 0 ? null : _oMobileOrderReportStyleList.ToArray();
        }
        
        public static List<MobileOrderReportStyleEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportStyleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportStyleEntity> _oMobileOrderReportStyleList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportStyleList==null){ return null;}
            return _oMobileOrderReportStyleList.Count == 0 ? null : _oMobileOrderReportStyleList.ToArray();
        }
        
        
        public static MobileOrderReportStyleEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportStyleEntity> _oMobileOrderReportStyleList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportStyleList==null){ return null;}
            return _oMobileOrderReportStyleList.Count == 0 ? null : _oMobileOrderReportStyleList.ToArray();
        }
        
        public static List<MobileOrderReportStyleEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportStyleEntity> _oRow = new List<MobileOrderReportStyleEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReportStyle].[id] AS MOBILEORDERREPORTSTYLE_ID,[MobileOrderReportStyle].[cdate] AS MOBILEORDERREPORTSTYLE_CDATE,[MobileOrderReportStyle].[cid] AS MOBILEORDERREPORTSTYLE_CID,[MobileOrderReportStyle].[active] AS MOBILEORDERREPORTSTYLE_ACTIVE,[MobileOrderReportStyle].[status] AS MOBILEORDERREPORTSTYLE_STATUS,[MobileOrderReportStyle].[type] AS MOBILEORDERREPORTSTYLE_TYPE,[MobileOrderReportStyle].[report_id] AS MOBILEORDERREPORTSTYLE_REPORT_ID,[MobileOrderReportStyle].[vas_show] AS MOBILEORDERREPORTSTYLE_VAS_SHOW,[MobileOrderReportStyle].[format] AS MOBILEORDERREPORTSTYLE_FORMAT  FROM  [MobileOrderReportStyle]";
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
                _sQuery += " WHERE [MobileOrderReportStyle].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReportStyle _oMobileOrderReportStyle = MobileOrderReportStyleRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ID"])) {_oMobileOrderReportStyle.id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_ID"]; }else{_oMobileOrderReportStyle.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CDATE"])) {_oMobileOrderReportStyle.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTSTYLE_CDATE"]; }else{_oMobileOrderReportStyle.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CID"])) {_oMobileOrderReportStyle.cid = (string)_oData["MOBILEORDERREPORTSTYLE_CID"]; }else{_oMobileOrderReportStyle.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ACTIVE"])) {_oMobileOrderReportStyle.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_ACTIVE"]; }else{_oMobileOrderReportStyle.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_STATUS"])) {_oMobileOrderReportStyle.status = (string)_oData["MOBILEORDERREPORTSTYLE_STATUS"]; }else{_oMobileOrderReportStyle.status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_TYPE"])) {_oMobileOrderReportStyle.type = (string)_oData["MOBILEORDERREPORTSTYLE_TYPE"]; }else{_oMobileOrderReportStyle.type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"])) {_oMobileOrderReportStyle.report_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"]; }else{_oMobileOrderReportStyle.report_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_FORMAT"])) {_oMobileOrderReportStyle.format = (string)_oData["MOBILEORDERREPORTSTYLE_FORMAT"]; }else{_oMobileOrderReportStyle.format=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"])) {_oMobileOrderReportStyle.vas_show = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"]; }else{_oMobileOrderReportStyle.vas_show=null;}
                        _oMobileOrderReportStyle.SetDB(x_oDB);
                        _oMobileOrderReportStyle.GetFound();
                        _oRow.Add(_oMobileOrderReportStyle);
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
        
        
        public static MobileOrderReportStyleEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportStyleEntity> _oMobileOrderReportStyleList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportStyleList==null){ return null;}
            return _oMobileOrderReportStyleList.Count == 0 ? null : _oMobileOrderReportStyleList.ToArray();
        }
        
        
        public static MobileOrderReportStyleEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportStyleEntity> _oMobileOrderReportStyleList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportStyleList==null){ return null;}
            return _oMobileOrderReportStyleList.Count == 0 ? null : _oMobileOrderReportStyleList.ToArray();
        }
        
        public static List<MobileOrderReportStyleEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportStyleEntity> _oRow = new List<MobileOrderReportStyleEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReportStyle].[id] AS MOBILEORDERREPORTSTYLE_ID,[MobileOrderReportStyle].[cdate] AS MOBILEORDERREPORTSTYLE_CDATE,[MobileOrderReportStyle].[cid] AS MOBILEORDERREPORTSTYLE_CID,[MobileOrderReportStyle].[active] AS MOBILEORDERREPORTSTYLE_ACTIVE,[MobileOrderReportStyle].[status] AS MOBILEORDERREPORTSTYLE_STATUS,[MobileOrderReportStyle].[type] AS MOBILEORDERREPORTSTYLE_TYPE,[MobileOrderReportStyle].[report_id] AS MOBILEORDERREPORTSTYLE_REPORT_ID,[MobileOrderReportStyle].[vas_show] AS MOBILEORDERREPORTSTYLE_VAS_SHOW,[MobileOrderReportStyle].[format] AS MOBILEORDERREPORTSTYLE_FORMAT";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportStyleRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportStyleEntity _oMobileOrderReportStyle = MobileOrderReportStyleRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ID"])) {_oMobileOrderReportStyle.id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_ID"]; } else {_oMobileOrderReportStyle.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CDATE"])) {_oMobileOrderReportStyle.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTSTYLE_CDATE"]; } else {_oMobileOrderReportStyle.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_CID"])) {_oMobileOrderReportStyle.cid = (string)_oData["MOBILEORDERREPORTSTYLE_CID"]; } else {_oMobileOrderReportStyle.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_ACTIVE"])) {_oMobileOrderReportStyle.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_ACTIVE"]; } else {_oMobileOrderReportStyle.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_STATUS"])) {_oMobileOrderReportStyle.status = (string)_oData["MOBILEORDERREPORTSTYLE_STATUS"]; } else {_oMobileOrderReportStyle.status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_TYPE"])) {_oMobileOrderReportStyle.type = (string)_oData["MOBILEORDERREPORTSTYLE_TYPE"]; } else {_oMobileOrderReportStyle.type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"])) {_oMobileOrderReportStyle.report_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTSTYLE_REPORT_ID"]; } else {_oMobileOrderReportStyle.report_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_FORMAT"])) {_oMobileOrderReportStyle.format = (string)_oData["MOBILEORDERREPORTSTYLE_FORMAT"]; } else {_oMobileOrderReportStyle.format=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"])) {_oMobileOrderReportStyle.vas_show = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTSTYLE_VAS_SHOW"]; } else {_oMobileOrderReportStyle.vas_show=null; }
                _oMobileOrderReportStyle.SetDB(x_oDB);
                _oMobileOrderReportStyle.GetFound();
                _oRow.Add(_oMobileOrderReportStyle);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReportStyle.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReportStyle.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReportStyle.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReportStyle.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReportStyle].[id] AS MOBILEORDERREPORTSTYLE_ID,[MobileOrderReportStyle].[cdate] AS MOBILEORDERREPORTSTYLE_CDATE,[MobileOrderReportStyle].[cid] AS MOBILEORDERREPORTSTYLE_CID,[MobileOrderReportStyle].[active] AS MOBILEORDERREPORTSTYLE_ACTIVE,[MobileOrderReportStyle].[status] AS MOBILEORDERREPORTSTYLE_STATUS,[MobileOrderReportStyle].[type] AS MOBILEORDERREPORTSTYLE_TYPE,[MobileOrderReportStyle].[report_id] AS MOBILEORDERREPORTSTYLE_REPORT_ID,[MobileOrderReportStyle].[vas_show] AS MOBILEORDERREPORTSTYLE_VAS_SHOW,[MobileOrderReportStyle].[format] AS MOBILEORDERREPORTSTYLE_FORMAT  FROM  [MobileOrderReportStyle]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReportStyle");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<bool> x_bActive,string x_sStatus,string x_sType,global::System.Nullable<int> x_iReport_id,string x_sFormat,global::System.Nullable<bool> x_bVas_show)
        {
            MobileOrderReportStyle _oMobileOrderReportStyle=MobileOrderReportStyleRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReportStyle.cdate=x_dCdate;
            _oMobileOrderReportStyle.cid=x_sCid;
            _oMobileOrderReportStyle.active=x_bActive;
            _oMobileOrderReportStyle.status=x_sStatus;
            _oMobileOrderReportStyle.type=x_sType;
            _oMobileOrderReportStyle.report_id=x_iReport_id;
            _oMobileOrderReportStyle.format=x_sFormat;
            _oMobileOrderReportStyle.vas_show=x_bVas_show;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReportStyle);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<bool> x_bActive,string x_sStatus,string x_sType,global::System.Nullable<int> x_iReport_id,string x_sFormat,global::System.Nullable<bool> x_bVas_show)
        {
            MobileOrderReportStyle _oMobileOrderReportStyle=MobileOrderReportStyleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportStyle.cdate=x_dCdate;
            _oMobileOrderReportStyle.cid=x_sCid;
            _oMobileOrderReportStyle.active=x_bActive;
            _oMobileOrderReportStyle.status=x_sStatus;
            _oMobileOrderReportStyle.type=x_sType;
            _oMobileOrderReportStyle.report_id=x_iReport_id;
            _oMobileOrderReportStyle.format=x_sFormat;
            _oMobileOrderReportStyle.vas_show=x_bVas_show;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReportStyle);
        }
        
        
        public bool Insert(MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReportStyle);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReportStyle)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReportStyle)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReportStyle);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportStyle]   ([cdate],[cid],[active],[status],[type],[report_id],[vas_show],[format])  VALUES  (@cdate,@cid,@active,@status,@type,@report_id,@vas_show,@format)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportStyle);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReportStyle.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportStyle.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportStyle.cdate; }
                if(x_oMobileOrderReportStyle.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value=x_oMobileOrderReportStyle.cid; }
                if(x_oMobileOrderReportStyle.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportStyle.active; }
                if(x_oMobileOrderReportStyle.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NChar,50).Value=x_oMobileOrderReportStyle.status; }
                if(x_oMobileOrderReportStyle.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NChar,20).Value=x_oMobileOrderReportStyle.type; }
                if(x_oMobileOrderReportStyle.report_id==null){  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportStyle.report_id; }
                if(x_oMobileOrderReportStyle.vas_show==null){  x_oCmd.Parameters.Add("@vas_show", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_show", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportStyle.vas_show; }
                if(x_oMobileOrderReportStyle.format==null){  x_oCmd.Parameters.Add("@format", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@format", global::System.Data.SqlDbType.NChar,10).Value=x_oMobileOrderReportStyle.format; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<bool> x_bActive,string x_sStatus,string x_sType,global::System.Nullable<int> x_iReport_id,string x_sFormat,global::System.Nullable<bool> x_bVas_show)
        {
            int _oLastID;
            MobileOrderReportStyle _oMobileOrderReportStyle=MobileOrderReportStyleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportStyle.cdate=x_dCdate;
            _oMobileOrderReportStyle.cid=x_sCid;
            _oMobileOrderReportStyle.active=x_bActive;
            _oMobileOrderReportStyle.status=x_sStatus;
            _oMobileOrderReportStyle.type=x_sType;
            _oMobileOrderReportStyle.report_id=x_iReport_id;
            _oMobileOrderReportStyle.format=x_sFormat;
            _oMobileOrderReportStyle.vas_show=x_bVas_show;
            if(InsertWithLastID(x_oDB, _oMobileOrderReportStyle,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReportStyle, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReportStyle, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportStyle)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReportStyle)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReportStyle x_oMobileOrderReportStyle, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportStyle]   ([cdate],[cid],[active],[status],[type],[report_id],[vas_show],[format])  VALUES  (@cdate,@cid,@active,@status,@type,@report_id,@vas_show,@format)"+" SELECT  @@IDENTITY AS MobileOrderReportStyle_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportStyle,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportStyle x_oMobileOrderReportStyle, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReportStyle.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportStyle.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportStyle.cdate; }
                if(x_oMobileOrderReportStyle.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10).Value=x_oMobileOrderReportStyle.cid; }
                if(x_oMobileOrderReportStyle.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportStyle.active; }
                if(x_oMobileOrderReportStyle.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NChar,50).Value=x_oMobileOrderReportStyle.status; }
                if(x_oMobileOrderReportStyle.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NChar,20).Value=x_oMobileOrderReportStyle.type; }
                if(x_oMobileOrderReportStyle.report_id==null){  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportStyle.report_id; }
                if(x_oMobileOrderReportStyle.vas_show==null){  x_oCmd.Parameters.Add("@vas_show", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_show", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportStyle.vas_show; }
                if(x_oMobileOrderReportStyle.format==null){  x_oCmd.Parameters.Add("@format", global::System.Data.SqlDbType.NChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@format", global::System.Data.SqlDbType.NChar,10).Value=x_oMobileOrderReportStyle.format; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReportStyle_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReportStyle_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReportStyle_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,global::System.Nullable<bool> x_bActive,string x_sStatus,string x_sType,global::System.Nullable<int> x_iReport_id,string x_sFormat,global::System.Nullable<bool> x_bVas_show)
        {
            int _oLastID;
            MobileOrderReportStyle _oMobileOrderReportStyle=MobileOrderReportStyleRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportStyle.cdate=x_dCdate;
            _oMobileOrderReportStyle.cid=x_sCid;
            _oMobileOrderReportStyle.active=x_bActive;
            _oMobileOrderReportStyle.status=x_sStatus;
            _oMobileOrderReportStyle.type=x_sType;
            _oMobileOrderReportStyle.report_id=x_iReport_id;
            _oMobileOrderReportStyle.format=x_sFormat;
            _oMobileOrderReportStyle.vas_show=x_bVas_show;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReportStyle,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReportStyle, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportStyle x_oMobileOrderReportStyle)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReportStyle, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportStyle)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReportStyle)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReportStyle x_oMobileOrderReportStyle, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORTSTYLE";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReportStyle,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportStyle x_oMobileOrderReportStyle, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportStyle.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportStyle.cid; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportStyle.active; }
                _oPar=x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportStyle.status; }
                _oPar=x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportStyle.type; }
                _oPar=x_oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.report_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportStyle.report_id; }
                _oPar=x_oCmd.Parameters.Add("@vas_show", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.vas_show==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportStyle.vas_show; }
                _oPar=x_oCmd.Parameters.Add("@format", global::System.Data.SqlDbType.NChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportStyle.format==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportStyle.format; }
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
        
        #region INSERT_MOBILEORDERREPORTSTYLE Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-10-29>
        ///-- Description:	<Description,MOBILEORDERREPORTSTYLE, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORTSTYLE Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORTSTYLE', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORTSTYLE;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORTSTYLE
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nchar(10),
        @active bit,
        @status nchar(50),
        @type nchar(20),
        @report_id int,
        @format nchar(10),
        @vas_show bit
        AS
        
        INSERT INTO  [MobileOrderReportStyle]   ([cdate],[cid],[active],[status],[type],[report_id],[vas_show],[format])  VALUES  (@cdate,@cid,@active,@status,@type,@report_id,@vas_show,@format)
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
            string _sQuery = "DELETE FROM  [MobileOrderReportStyle]  WHERE [MobileOrderReportStyle].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
            return MobileOrderReportStyleRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportStyle]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReportStyle]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportStyle]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportStyle]"); }
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


