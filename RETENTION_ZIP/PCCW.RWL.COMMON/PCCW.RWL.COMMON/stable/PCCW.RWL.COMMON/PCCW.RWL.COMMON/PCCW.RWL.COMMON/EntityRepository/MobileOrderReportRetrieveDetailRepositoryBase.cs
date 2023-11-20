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
///-- Description:	<Description,Table :[MobileOrderReportRetrieveDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportRetrieveDetail] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReportRetrieveDetail")]
    public class MobileOrderReportRetrieveDetailRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportRetrieveDetailRepositoryBase instance;
        public static MobileOrderReportRetrieveDetailRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportRetrieveDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportRetrieveDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportRetrieveDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportRetrieveDetailEntity> MobileOrderReportRetrieveDetails;
        #endregion
        
        #region Constructor
        public MobileOrderReportRetrieveDetailRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportRetrieveDetailRepositoryBase() { 
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
        public static MobileOrderReportRetrieveDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReportRetrieveDetail(_oDB);
        }
        
        public static MobileOrderReportRetrieveDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReportRetrieveDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReportRetrieveDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
        
        
        public MobileOrderReportRetrieveDetailEntity GetObj(global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive)
        {
            return GetObj(n_oDB, x_gGuid_id,x_bActive);
        }
        
        
        public static MobileOrderReportRetrieveDetailEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportRetrieveDetail _MobileOrderReportRetrieveDetail = (MobileOrderReportRetrieveDetail)MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportRetrieveDetail.Load(x_gGuid_id,x_bActive)) { return null; }
            return _MobileOrderReportRetrieveDetail;
        }
        
        
        public MobileOrderReportRetrieveDetailEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileOrderReportRetrieveDetailEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportRetrieveDetail _MobileOrderReportRetrieveDetail = (MobileOrderReportRetrieveDetail)MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportRetrieveDetail.Load(x_iId)) { return null; }
            return _MobileOrderReportRetrieveDetail;
        }
        
        
        
        public static MobileOrderReportRetrieveDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportRetrieveDetailEntity> _oMobileOrderReportRetrieveDetailList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMobileOrderReportRetrieveDetailList==null){ return null;}
            return _oMobileOrderReportRetrieveDetailList.Count == 0 ? null : _oMobileOrderReportRetrieveDetailList.ToArray();
        }
        
        public static List<MobileOrderReportRetrieveDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportRetrieveDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportRetrieveDetailEntity> _oMobileOrderReportRetrieveDetailList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportRetrieveDetailList==null){ return null;}
            return _oMobileOrderReportRetrieveDetailList.Count == 0 ? null : _oMobileOrderReportRetrieveDetailList.ToArray();
        }
        
        
        public static MobileOrderReportRetrieveDetailEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportRetrieveDetailEntity> _oMobileOrderReportRetrieveDetailList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportRetrieveDetailList==null){ return null;}
            return _oMobileOrderReportRetrieveDetailList.Count == 0 ? null : _oMobileOrderReportRetrieveDetailList.ToArray();
        }
        
        public static List<MobileOrderReportRetrieveDetailEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportRetrieveDetailEntity> _oRow = new List<MobileOrderReportRetrieveDetailEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReportRetrieveDetail].[id] AS MOBILEORDERREPORTRETRIEVEDETAIL_ID,[MobileOrderReportRetrieveDetail].[active] AS MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE,[MobileOrderReportRetrieveDetail].[did] AS MOBILEORDERREPORTRETRIEVEDETAIL_DID,[MobileOrderReportRetrieveDetail].[guid_id] AS MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID,[MobileOrderReportRetrieveDetail].[retrieve_group] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP,[MobileOrderReportRetrieveDetail].[retrieve_date] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE,[MobileOrderReportRetrieveDetail].[ddate] AS MOBILEORDERREPORTRETRIEVEDETAIL_DDATE,[MobileOrderReportRetrieveDetail].[retrieve_sn] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN,[MobileOrderReportRetrieveDetail].[report_type] AS MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE  FROM  [MobileOrderReportRetrieveDetail]";
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
                _sQuery += " WHERE [MobileOrderReportRetrieveDetail].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReportRetrieveDetail _oMobileOrderReportRetrieveDetail = MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"])) {_oMobileOrderReportRetrieveDetail.id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"]; }else{_oMobileOrderReportRetrieveDetail.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"])) {_oMobileOrderReportRetrieveDetail.did = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"]; }else{_oMobileOrderReportRetrieveDetail.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"])) {_oMobileOrderReportRetrieveDetail.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"]; }else{_oMobileOrderReportRetrieveDetail.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"])) {_oMobileOrderReportRetrieveDetail.guid_id = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"]; }else{_oMobileOrderReportRetrieveDetail.guid_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"])) {_oMobileOrderReportRetrieveDetail.retrieve_group = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"]; }else{_oMobileOrderReportRetrieveDetail.retrieve_group=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"])) {_oMobileOrderReportRetrieveDetail.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"]; }else{_oMobileOrderReportRetrieveDetail.retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"])) {_oMobileOrderReportRetrieveDetail.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"]; }else{_oMobileOrderReportRetrieveDetail.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"])) {_oMobileOrderReportRetrieveDetail.retrieve_sn = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"]; }else{_oMobileOrderReportRetrieveDetail.retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"])) {_oMobileOrderReportRetrieveDetail.report_type = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"]; }else{_oMobileOrderReportRetrieveDetail.report_type=global::System.String.Empty;}
                        _oMobileOrderReportRetrieveDetail.SetDB(x_oDB);
                        _oMobileOrderReportRetrieveDetail.GetFound();
                        _oRow.Add(_oMobileOrderReportRetrieveDetail);
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
        
        
        public static MobileOrderReportRetrieveDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportRetrieveDetailEntity> _oMobileOrderReportRetrieveDetailList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportRetrieveDetailList==null){ return null;}
            return _oMobileOrderReportRetrieveDetailList.Count == 0 ? null : _oMobileOrderReportRetrieveDetailList.ToArray();
        }
        
        
        public static MobileOrderReportRetrieveDetailEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportRetrieveDetailEntity> _oMobileOrderReportRetrieveDetailList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportRetrieveDetailList==null){ return null;}
            return _oMobileOrderReportRetrieveDetailList.Count == 0 ? null : _oMobileOrderReportRetrieveDetailList.ToArray();
        }
        
        public static List<MobileOrderReportRetrieveDetailEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportRetrieveDetailEntity> _oRow = new List<MobileOrderReportRetrieveDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReportRetrieveDetail].[id] AS MOBILEORDERREPORTRETRIEVEDETAIL_ID,[MobileOrderReportRetrieveDetail].[active] AS MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE,[MobileOrderReportRetrieveDetail].[did] AS MOBILEORDERREPORTRETRIEVEDETAIL_DID,[MobileOrderReportRetrieveDetail].[guid_id] AS MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID,[MobileOrderReportRetrieveDetail].[retrieve_group] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP,[MobileOrderReportRetrieveDetail].[retrieve_date] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE,[MobileOrderReportRetrieveDetail].[ddate] AS MOBILEORDERREPORTRETRIEVEDETAIL_DDATE,[MobileOrderReportRetrieveDetail].[retrieve_sn] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN,[MobileOrderReportRetrieveDetail].[report_type] AS MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportRetrieveDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportRetrieveDetailEntity _oMobileOrderReportRetrieveDetail = MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"])) {_oMobileOrderReportRetrieveDetail.id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ID"]; } else {_oMobileOrderReportRetrieveDetail.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"])) {_oMobileOrderReportRetrieveDetail.did = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DID"]; } else {_oMobileOrderReportRetrieveDetail.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"])) {_oMobileOrderReportRetrieveDetail.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE"]; } else {_oMobileOrderReportRetrieveDetail.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"])) {_oMobileOrderReportRetrieveDetail.guid_id = (global::System.Nullable<Guid>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID"]; } else {_oMobileOrderReportRetrieveDetail.guid_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"])) {_oMobileOrderReportRetrieveDetail.retrieve_group = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP"]; } else {_oMobileOrderReportRetrieveDetail.retrieve_group=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"])) {_oMobileOrderReportRetrieveDetail.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE"]; } else {_oMobileOrderReportRetrieveDetail.retrieve_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"])) {_oMobileOrderReportRetrieveDetail.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_DDATE"]; } else {_oMobileOrderReportRetrieveDetail.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"])) {_oMobileOrderReportRetrieveDetail.retrieve_sn = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN"]; } else {_oMobileOrderReportRetrieveDetail.retrieve_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"])) {_oMobileOrderReportRetrieveDetail.report_type = (string)_oData["MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE"]; } else {_oMobileOrderReportRetrieveDetail.report_type=global::System.String.Empty; }
                _oMobileOrderReportRetrieveDetail.SetDB(x_oDB);
                _oMobileOrderReportRetrieveDetail.GetFound();
                _oRow.Add(_oMobileOrderReportRetrieveDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReportRetrieveDetail.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReportRetrieveDetail.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReportRetrieveDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReportRetrieveDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReportRetrieveDetail].[id] AS MOBILEORDERREPORTRETRIEVEDETAIL_ID,[MobileOrderReportRetrieveDetail].[active] AS MOBILEORDERREPORTRETRIEVEDETAIL_ACTIVE,[MobileOrderReportRetrieveDetail].[did] AS MOBILEORDERREPORTRETRIEVEDETAIL_DID,[MobileOrderReportRetrieveDetail].[guid_id] AS MOBILEORDERREPORTRETRIEVEDETAIL_GUID_ID,[MobileOrderReportRetrieveDetail].[retrieve_group] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_GROUP,[MobileOrderReportRetrieveDetail].[retrieve_date] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_DATE,[MobileOrderReportRetrieveDetail].[ddate] AS MOBILEORDERREPORTRETRIEVEDETAIL_DDATE,[MobileOrderReportRetrieveDetail].[retrieve_sn] AS MOBILEORDERREPORTRETRIEVEDETAIL_RETRIEVE_SN,[MobileOrderReportRetrieveDetail].[report_type] AS MOBILEORDERREPORTRETRIEVEDETAIL_REPORT_TYPE  FROM  [MobileOrderReportRetrieveDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReportRetrieveDetail");
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
        
        public bool Insert(string x_sDid,global::System.Nullable<bool> x_bActive,global::System.Nullable<Guid> x_gGuid_id,string x_sRetrieve_group,global::System.Nullable<DateTime> x_dRetrieve_date,global::System.Nullable<DateTime> x_dDdate,string x_sRetrieve_sn,string x_sReport_type)
        {
            MobileOrderReportRetrieveDetail _oMobileOrderReportRetrieveDetail=MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReportRetrieveDetail.did=x_sDid;
            _oMobileOrderReportRetrieveDetail.active=x_bActive;
            _oMobileOrderReportRetrieveDetail.guid_id=x_gGuid_id;
            _oMobileOrderReportRetrieveDetail.retrieve_group=x_sRetrieve_group;
            _oMobileOrderReportRetrieveDetail.retrieve_date=x_dRetrieve_date;
            _oMobileOrderReportRetrieveDetail.ddate=x_dDdate;
            _oMobileOrderReportRetrieveDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportRetrieveDetail.report_type=x_sReport_type;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReportRetrieveDetail);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sDid,global::System.Nullable<bool> x_bActive,global::System.Nullable<Guid> x_gGuid_id,string x_sRetrieve_group,global::System.Nullable<DateTime> x_dRetrieve_date,global::System.Nullable<DateTime> x_dDdate,string x_sRetrieve_sn,string x_sReport_type)
        {
            MobileOrderReportRetrieveDetail _oMobileOrderReportRetrieveDetail=MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportRetrieveDetail.did=x_sDid;
            _oMobileOrderReportRetrieveDetail.active=x_bActive;
            _oMobileOrderReportRetrieveDetail.guid_id=x_gGuid_id;
            _oMobileOrderReportRetrieveDetail.retrieve_group=x_sRetrieve_group;
            _oMobileOrderReportRetrieveDetail.retrieve_date=x_dRetrieve_date;
            _oMobileOrderReportRetrieveDetail.ddate=x_dDdate;
            _oMobileOrderReportRetrieveDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportRetrieveDetail.report_type=x_sReport_type;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReportRetrieveDetail);
        }
        
        
        public bool Insert(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReportRetrieveDetail);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReportRetrieveDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReportRetrieveDetail)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReportRetrieveDetail);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportRetrieveDetail]   ([active],[did],[guid_id],[retrieve_group],[retrieve_date],[ddate],[retrieve_sn],[report_type])  VALUES  (@active,@did,@guid_id,@retrieve_group,@retrieve_date,@ddate,@retrieve_sn,@report_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportRetrieveDetail);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReportRetrieveDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportRetrieveDetail.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportRetrieveDetail.active; }
                if(x_oMobileOrderReportRetrieveDetail.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,10).Value=x_oMobileOrderReportRetrieveDetail.did; }
                if(x_oMobileOrderReportRetrieveDetail.guid_id==null){  x_oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier).Value=x_oMobileOrderReportRetrieveDetail.guid_id; }
                if(x_oMobileOrderReportRetrieveDetail.retrieve_group==null){  x_oCmd.Parameters.Add("@retrieve_group", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_group", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportRetrieveDetail.retrieve_group; }
                if(x_oMobileOrderReportRetrieveDetail.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportRetrieveDetail.retrieve_date; }
                if(x_oMobileOrderReportRetrieveDetail.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportRetrieveDetail.ddate; }
                if(x_oMobileOrderReportRetrieveDetail.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportRetrieveDetail.retrieve_sn; }
                if(x_oMobileOrderReportRetrieveDetail.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportRetrieveDetail.report_type; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sDid,global::System.Nullable<bool> x_bActive,global::System.Nullable<Guid> x_gGuid_id,string x_sRetrieve_group,global::System.Nullable<DateTime> x_dRetrieve_date,global::System.Nullable<DateTime> x_dDdate,string x_sRetrieve_sn,string x_sReport_type)
        {
            int _oLastID;
            MobileOrderReportRetrieveDetail _oMobileOrderReportRetrieveDetail=MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportRetrieveDetail.did=x_sDid;
            _oMobileOrderReportRetrieveDetail.active=x_bActive;
            _oMobileOrderReportRetrieveDetail.guid_id=x_gGuid_id;
            _oMobileOrderReportRetrieveDetail.retrieve_group=x_sRetrieve_group;
            _oMobileOrderReportRetrieveDetail.retrieve_date=x_dRetrieve_date;
            _oMobileOrderReportRetrieveDetail.ddate=x_dDdate;
            _oMobileOrderReportRetrieveDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportRetrieveDetail.report_type=x_sReport_type;
            if(InsertWithLastID(x_oDB, _oMobileOrderReportRetrieveDetail,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReportRetrieveDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReportRetrieveDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportRetrieveDetail)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReportRetrieveDetail)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportRetrieveDetail]   ([active],[did],[guid_id],[retrieve_group],[retrieve_date],[ddate],[retrieve_sn],[report_type])  VALUES  (@active,@did,@guid_id,@retrieve_group,@retrieve_date,@ddate,@retrieve_sn,@report_type)"+" SELECT  @@IDENTITY AS MobileOrderReportRetrieveDetail_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportRetrieveDetail,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReportRetrieveDetail.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportRetrieveDetail.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportRetrieveDetail.active; }
                if(x_oMobileOrderReportRetrieveDetail.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,10).Value=x_oMobileOrderReportRetrieveDetail.did; }
                if(x_oMobileOrderReportRetrieveDetail.guid_id==null){  x_oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier).Value=x_oMobileOrderReportRetrieveDetail.guid_id; }
                if(x_oMobileOrderReportRetrieveDetail.retrieve_group==null){  x_oCmd.Parameters.Add("@retrieve_group", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_group", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportRetrieveDetail.retrieve_group; }
                if(x_oMobileOrderReportRetrieveDetail.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportRetrieveDetail.retrieve_date; }
                if(x_oMobileOrderReportRetrieveDetail.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportRetrieveDetail.ddate; }
                if(x_oMobileOrderReportRetrieveDetail.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportRetrieveDetail.retrieve_sn; }
                if(x_oMobileOrderReportRetrieveDetail.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportRetrieveDetail.report_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReportRetrieveDetail_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReportRetrieveDetail_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReportRetrieveDetail_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sDid,global::System.Nullable<bool> x_bActive,global::System.Nullable<Guid> x_gGuid_id,string x_sRetrieve_group,global::System.Nullable<DateTime> x_dRetrieve_date,global::System.Nullable<DateTime> x_dDdate,string x_sRetrieve_sn,string x_sReport_type)
        {
            int _oLastID;
            MobileOrderReportRetrieveDetail _oMobileOrderReportRetrieveDetail=MobileOrderReportRetrieveDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportRetrieveDetail.did=x_sDid;
            _oMobileOrderReportRetrieveDetail.active=x_bActive;
            _oMobileOrderReportRetrieveDetail.guid_id=x_gGuid_id;
            _oMobileOrderReportRetrieveDetail.retrieve_group=x_sRetrieve_group;
            _oMobileOrderReportRetrieveDetail.retrieve_date=x_dRetrieve_date;
            _oMobileOrderReportRetrieveDetail.ddate=x_dDdate;
            _oMobileOrderReportRetrieveDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportRetrieveDetail.report_type=x_sReport_type;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReportRetrieveDetail,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReportRetrieveDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReportRetrieveDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportRetrieveDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReportRetrieveDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORTRETRIEVEDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReportRetrieveDetail,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportRetrieveDetail x_oMobileOrderReportRetrieveDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.active; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.did; }
                _oPar=x_oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.guid_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.guid_id; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_group", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.retrieve_group==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.retrieve_group; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.ddate; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.retrieve_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.retrieve_sn; }
                _oPar=x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportRetrieveDetail.report_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportRetrieveDetail.report_type; }
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
        
        #region INSERT_MOBILEORDERREPORTRETRIEVEDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-10-29>
        ///-- Description:	<Description,MOBILEORDERREPORTRETRIEVEDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORTRETRIEVEDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORTRETRIEVEDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORTRETRIEVEDETAIL;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORTRETRIEVEDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @did varchar(10),
        @active bit,
        @guid_id uniqueidentifier,
        @retrieve_group nvarchar(50),
        @retrieve_date datetime,
        @ddate datetime,
        @retrieve_sn char(10),
        @report_type char(20)
        AS
        
        INSERT INTO  [MobileOrderReportRetrieveDetail]   ([active],[did],[guid_id],[retrieve_group],[retrieve_date],[ddate],[retrieve_sn],[report_type])  VALUES  (@active,@did,@guid_id,@retrieve_group,@retrieve_date,@ddate,@retrieve_sn,@report_type)
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
        
        public bool Delete(global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive)
        {
            return DeleteProc(n_oDB, x_gGuid_id,x_bActive);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive)
        {
            return DeleteProc(x_oDB, x_gGuid_id,x_bActive);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive)
        {
            if (x_gGuid_id==null) { return false; }
            if (x_bActive==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportRetrieveDetail]  WHERE [MobileOrderReportRetrieveDetail].[guid_id]=@guid_id AND [MobileOrderReportRetrieveDetail].[active]=@active";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@guid_id", global::System.Data.SqlDbType.UniqueIdentifier).Value = x_gGuid_id;
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
            string _sQuery = "DELETE FROM  [MobileOrderReportRetrieveDetail]  WHERE [MobileOrderReportRetrieveDetail].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
            return MobileOrderReportRetrieveDetailRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportRetrieveDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReportRetrieveDetail]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportRetrieveDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportRetrieveDetail]"); }
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


