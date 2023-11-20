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
///-- Create date: <Create Date 2011-12-07>
///-- Description:	<Description,Table :[MobileOrderReport],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReport] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReport")]
    public class MobileOrderReportRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportRepositoryBase instance;
        public static MobileOrderReportRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportEntity> MobileOrderReports;
        #endregion
        
        #region Constructor
        public MobileOrderReportRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportRepositoryBase() { 
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
        public static MobileOrderReport CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReport(_oDB);
        }
        
        public static MobileOrderReport CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReport(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReport]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
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
        
        
        public MobileOrderReportEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static MobileOrderReportEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReport _MobileOrderReport = (MobileOrderReport)MobileOrderReportRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReport.Load(x_iMid)) { return null; }
            return _MobileOrderReport;
        }
        
        
        
        public static MobileOrderReportEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportEntity> _oMobileOrderReportList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderReportList==null){ return null;}
            return _oMobileOrderReportList.Count == 0 ? null : _oMobileOrderReportList.ToArray();
        }
        
        public static List<MobileOrderReportEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportEntity> _oMobileOrderReportList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportList==null){ return null;}
            return _oMobileOrderReportList.Count == 0 ? null : _oMobileOrderReportList.ToArray();
        }
        
        
        public static MobileOrderReportEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportEntity> _oMobileOrderReportList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportList==null){ return null;}
            return _oMobileOrderReportList.Count == 0 ? null : _oMobileOrderReportList.ToArray();
        }
        
        public static List<MobileOrderReportEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportEntity> _oRow = new List<MobileOrderReportEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReport].[order_status] AS MOBILEORDERREPORT_ORDER_STATUS,[MobileOrderReport].[gw_retrieve_sn] AS MOBILEORDERREPORT_GW_RETRIEVE_SN,[MobileOrderReport].[sent_again] AS MOBILEORDERREPORT_SENT_AGAIN,[MobileOrderReport].[mid] AS MOBILEORDERREPORT_MID,[MobileOrderReport].[email_date] AS MOBILEORDERREPORT_EMAIL_DATE,[MobileOrderReport].[retrieve_cnt] AS MOBILEORDERREPORT_RETRIEVE_CNT,[MobileOrderReport].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[cdate] AS MOBILEORDERREPORT_CDATE,[MobileOrderReport].[retrieve_sn] AS MOBILEORDERREPORT_RETRIEVE_SN,[MobileOrderReport].[cid] AS MOBILEORDERREPORT_CID,[MobileOrderReport].[did] AS MOBILEORDERREPORT_DID,[MobileOrderReport].[sent_again_date] AS MOBILEORDERREPORT_SENT_AGAIN_DATE,[MobileOrderReport].[idd_vas] AS MOBILEORDERREPORT_IDD_VAS,[MobileOrderReport].[active] AS MOBILEORDERREPORT_ACTIVE,[MobileOrderReport].[fallout_reason] AS MOBILEORDERREPORT_FALLOUT_REASON,[MobileOrderReport].[fallout_remark] AS MOBILEORDERREPORT_FALLOUT_REMARK,[MobileOrderReport].[fallout_main_category] AS MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY,[MobileOrderReport].[gw_retrieve_date] AS MOBILEORDERREPORT_GW_RETRIEVE_DATE,[MobileOrderReport].[report_type] AS MOBILEORDERREPORT_REPORT_TYPE,[MobileOrderReport].[reactive_sn] AS MOBILEORDERREPORT_REACTIVE_SN,[MobileOrderReport].[ddate] AS MOBILEORDERREPORT_DDATE,[MobileOrderReport].[ext_place_tel] AS MOBILEORDERREPORT_EXT_PLACE_TEL,[MobileOrderReport].[reactive_date] AS MOBILEORDERREPORT_REACTIVE_DATE,[MobileOrderReport].[order_id] AS MOBILEORDERREPORT_ORDER_ID,[MobileOrderReport].[retrieve_date] AS MOBILEORDERREPORT_RETRIEVE_DATE,[MobileOrderReport].[py_sent_again_retrieve_date] AS MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[fallout_reply] AS MOBILEORDERREPORT_FALLOUT_REPLY  FROM  [MobileOrderReport]";
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
                _sQuery += " WHERE [MobileOrderReport].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReport _oMobileOrderReport = MobileOrderReportRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ORDER_STATUS"])) {_oMobileOrderReport.order_status = (string)_oData["MOBILEORDERREPORT_ORDER_STATUS"]; }else{_oMobileOrderReport.order_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_GW_RETRIEVE_SN"])) {_oMobileOrderReport.gw_retrieve_sn = (string)_oData["MOBILEORDERREPORT_GW_RETRIEVE_SN"]; }else{_oMobileOrderReport.gw_retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_SENT_AGAIN"])) {_oMobileOrderReport.sent_again = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_SENT_AGAIN"]; }else{_oMobileOrderReport.sent_again=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_MID"])) {_oMobileOrderReport.mid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_MID"]; }else{_oMobileOrderReport.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_EMAIL_DATE"])) {_oMobileOrderReport.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_EMAIL_DATE"]; }else{_oMobileOrderReport.email_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_CNT"])) {_oMobileOrderReport.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_RETRIEVE_CNT"]; }else{_oMobileOrderReport.retrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReport.fs_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE"]; }else{_oMobileOrderReport.fs_sent_again_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_CDATE"])) {_oMobileOrderReport.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_CDATE"]; }else{_oMobileOrderReport.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_SN"])) {_oMobileOrderReport.retrieve_sn = (string)_oData["MOBILEORDERREPORT_RETRIEVE_SN"]; }else{_oMobileOrderReport.retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_CID"])) {_oMobileOrderReport.cid = (string)_oData["MOBILEORDERREPORT_CID"]; }else{_oMobileOrderReport.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_DID"])) {_oMobileOrderReport.did = (string)_oData["MOBILEORDERREPORT_DID"]; }else{_oMobileOrderReport.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_SENT_AGAIN_DATE"])) {_oMobileOrderReport.sent_again_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_SENT_AGAIN_DATE"]; }else{_oMobileOrderReport.sent_again_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_IDD_VAS"])) {_oMobileOrderReport.idd_vas = (string)_oData["MOBILEORDERREPORT_IDD_VAS"]; }else{_oMobileOrderReport.idd_vas=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ACTIVE"])) {_oMobileOrderReport.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORT_ACTIVE"]; }else{_oMobileOrderReport.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REASON"])) {_oMobileOrderReport.fallout_reason = (string)_oData["MOBILEORDERREPORT_FALLOUT_REASON"]; }else{_oMobileOrderReport.fallout_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REMARK"])) {_oMobileOrderReport.fallout_remark = (string)_oData["MOBILEORDERREPORT_FALLOUT_REMARK"]; }else{_oMobileOrderReport.fallout_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReport.fallout_main_category = (string)_oData["MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY"]; }else{_oMobileOrderReport.fallout_main_category=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REPORT_TYPE"])) {_oMobileOrderReport.report_type = (string)_oData["MOBILEORDERREPORT_REPORT_TYPE"]; }else{_oMobileOrderReport.report_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REPLY"])) {_oMobileOrderReport.fallout_reply = (string)_oData["MOBILEORDERREPORT_FALLOUT_REPLY"]; }else{_oMobileOrderReport.fallout_reply=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REACTIVE_SN"])) {_oMobileOrderReport.reactive_sn = (string)_oData["MOBILEORDERREPORT_REACTIVE_SN"]; }else{_oMobileOrderReport.reactive_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_DDATE"])) {_oMobileOrderReport.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_DDATE"]; }else{_oMobileOrderReport.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_EXT_PLACE_TEL"])) {_oMobileOrderReport.ext_place_tel = (string)_oData["MOBILEORDERREPORT_EXT_PLACE_TEL"]; }else{_oMobileOrderReport.ext_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REACTIVE_DATE"])) {_oMobileOrderReport.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_REACTIVE_DATE"]; }else{_oMobileOrderReport.reactive_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_GW_RETRIEVE_DATE"])) {_oMobileOrderReport.gw_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_GW_RETRIEVE_DATE"]; }else{_oMobileOrderReport.gw_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ORDER_ID"])) {_oMobileOrderReport.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_ORDER_ID"]; }else{_oMobileOrderReport.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReport.py_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE"]; }else{_oMobileOrderReport.py_sent_again_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_DATE"])) {_oMobileOrderReport.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_RETRIEVE_DATE"]; }else{_oMobileOrderReport.retrieve_date=null;}
                        _oMobileOrderReport.SetDB(x_oDB);
                        _oMobileOrderReport.GetFound();
                        _oRow.Add(_oMobileOrderReport);
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
        
        
        public static MobileOrderReportEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportEntity> _oMobileOrderReportList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportList==null){ return null;}
            return _oMobileOrderReportList.Count == 0 ? null : _oMobileOrderReportList.ToArray();
        }
        
        
        public static MobileOrderReportEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportEntity> _oMobileOrderReportList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportList==null){ return null;}
            return _oMobileOrderReportList.Count == 0 ? null : _oMobileOrderReportList.ToArray();
        }
        
        public static List<MobileOrderReportEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportEntity> _oRow = new List<MobileOrderReportEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReport].[order_status] AS MOBILEORDERREPORT_ORDER_STATUS,[MobileOrderReport].[gw_retrieve_sn] AS MOBILEORDERREPORT_GW_RETRIEVE_SN,[MobileOrderReport].[sent_again] AS MOBILEORDERREPORT_SENT_AGAIN,[MobileOrderReport].[mid] AS MOBILEORDERREPORT_MID,[MobileOrderReport].[email_date] AS MOBILEORDERREPORT_EMAIL_DATE,[MobileOrderReport].[retrieve_cnt] AS MOBILEORDERREPORT_RETRIEVE_CNT,[MobileOrderReport].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[cdate] AS MOBILEORDERREPORT_CDATE,[MobileOrderReport].[retrieve_sn] AS MOBILEORDERREPORT_RETRIEVE_SN,[MobileOrderReport].[cid] AS MOBILEORDERREPORT_CID,[MobileOrderReport].[did] AS MOBILEORDERREPORT_DID,[MobileOrderReport].[sent_again_date] AS MOBILEORDERREPORT_SENT_AGAIN_DATE,[MobileOrderReport].[idd_vas] AS MOBILEORDERREPORT_IDD_VAS,[MobileOrderReport].[active] AS MOBILEORDERREPORT_ACTIVE,[MobileOrderReport].[fallout_reason] AS MOBILEORDERREPORT_FALLOUT_REASON,[MobileOrderReport].[fallout_remark] AS MOBILEORDERREPORT_FALLOUT_REMARK,[MobileOrderReport].[fallout_main_category] AS MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY,[MobileOrderReport].[gw_retrieve_date] AS MOBILEORDERREPORT_GW_RETRIEVE_DATE,[MobileOrderReport].[report_type] AS MOBILEORDERREPORT_REPORT_TYPE,[MobileOrderReport].[reactive_sn] AS MOBILEORDERREPORT_REACTIVE_SN,[MobileOrderReport].[ddate] AS MOBILEORDERREPORT_DDATE,[MobileOrderReport].[ext_place_tel] AS MOBILEORDERREPORT_EXT_PLACE_TEL,[MobileOrderReport].[reactive_date] AS MOBILEORDERREPORT_REACTIVE_DATE,[MobileOrderReport].[order_id] AS MOBILEORDERREPORT_ORDER_ID,[MobileOrderReport].[retrieve_date] AS MOBILEORDERREPORT_RETRIEVE_DATE,[MobileOrderReport].[py_sent_again_retrieve_date] AS MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[fallout_reply] AS MOBILEORDERREPORT_FALLOUT_REPLY";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportEntity _oMobileOrderReport = MobileOrderReportRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ORDER_STATUS"])) {_oMobileOrderReport.order_status = (string)_oData["MOBILEORDERREPORT_ORDER_STATUS"]; } else {_oMobileOrderReport.order_status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_GW_RETRIEVE_SN"])) {_oMobileOrderReport.gw_retrieve_sn = (string)_oData["MOBILEORDERREPORT_GW_RETRIEVE_SN"]; } else {_oMobileOrderReport.gw_retrieve_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_SENT_AGAIN"])) {_oMobileOrderReport.sent_again = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_SENT_AGAIN"]; } else {_oMobileOrderReport.sent_again=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_MID"])) {_oMobileOrderReport.mid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_MID"]; } else {_oMobileOrderReport.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_EMAIL_DATE"])) {_oMobileOrderReport.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_EMAIL_DATE"]; } else {_oMobileOrderReport.email_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_CNT"])) {_oMobileOrderReport.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_RETRIEVE_CNT"]; } else {_oMobileOrderReport.retrieve_cnt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReport.fs_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE"]; } else {_oMobileOrderReport.fs_sent_again_retrieve_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_CDATE"])) {_oMobileOrderReport.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_CDATE"]; } else {_oMobileOrderReport.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_SN"])) {_oMobileOrderReport.retrieve_sn = (string)_oData["MOBILEORDERREPORT_RETRIEVE_SN"]; } else {_oMobileOrderReport.retrieve_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_CID"])) {_oMobileOrderReport.cid = (string)_oData["MOBILEORDERREPORT_CID"]; } else {_oMobileOrderReport.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_DID"])) {_oMobileOrderReport.did = (string)_oData["MOBILEORDERREPORT_DID"]; } else {_oMobileOrderReport.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_SENT_AGAIN_DATE"])) {_oMobileOrderReport.sent_again_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_SENT_AGAIN_DATE"]; } else {_oMobileOrderReport.sent_again_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_IDD_VAS"])) {_oMobileOrderReport.idd_vas = (string)_oData["MOBILEORDERREPORT_IDD_VAS"]; } else {_oMobileOrderReport.idd_vas=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ACTIVE"])) {_oMobileOrderReport.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORT_ACTIVE"]; } else {_oMobileOrderReport.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REASON"])) {_oMobileOrderReport.fallout_reason = (string)_oData["MOBILEORDERREPORT_FALLOUT_REASON"]; } else {_oMobileOrderReport.fallout_reason=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REMARK"])) {_oMobileOrderReport.fallout_remark = (string)_oData["MOBILEORDERREPORT_FALLOUT_REMARK"]; } else {_oMobileOrderReport.fallout_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReport.fallout_main_category = (string)_oData["MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY"]; } else {_oMobileOrderReport.fallout_main_category=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REPORT_TYPE"])) {_oMobileOrderReport.report_type = (string)_oData["MOBILEORDERREPORT_REPORT_TYPE"]; } else {_oMobileOrderReport.report_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_FALLOUT_REPLY"])) {_oMobileOrderReport.fallout_reply = (string)_oData["MOBILEORDERREPORT_FALLOUT_REPLY"]; } else {_oMobileOrderReport.fallout_reply=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REACTIVE_SN"])) {_oMobileOrderReport.reactive_sn = (string)_oData["MOBILEORDERREPORT_REACTIVE_SN"]; } else {_oMobileOrderReport.reactive_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_DDATE"])) {_oMobileOrderReport.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_DDATE"]; } else {_oMobileOrderReport.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_EXT_PLACE_TEL"])) {_oMobileOrderReport.ext_place_tel = (string)_oData["MOBILEORDERREPORT_EXT_PLACE_TEL"]; } else {_oMobileOrderReport.ext_place_tel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_REACTIVE_DATE"])) {_oMobileOrderReport.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_REACTIVE_DATE"]; } else {_oMobileOrderReport.reactive_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_GW_RETRIEVE_DATE"])) {_oMobileOrderReport.gw_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_GW_RETRIEVE_DATE"]; } else {_oMobileOrderReport.gw_retrieve_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_ORDER_ID"])) {_oMobileOrderReport.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORT_ORDER_ID"]; } else {_oMobileOrderReport.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReport.py_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE"]; } else {_oMobileOrderReport.py_sent_again_retrieve_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORT_RETRIEVE_DATE"])) {_oMobileOrderReport.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORT_RETRIEVE_DATE"]; } else {_oMobileOrderReport.retrieve_date=null; }
                _oMobileOrderReport.SetDB(x_oDB);
                _oMobileOrderReport.GetFound();
                _oRow.Add(_oMobileOrderReport);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReport.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReport.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReport.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReport.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReport].[order_status] AS MOBILEORDERREPORT_ORDER_STATUS,[MobileOrderReport].[gw_retrieve_sn] AS MOBILEORDERREPORT_GW_RETRIEVE_SN,[MobileOrderReport].[sent_again] AS MOBILEORDERREPORT_SENT_AGAIN,[MobileOrderReport].[mid] AS MOBILEORDERREPORT_MID,[MobileOrderReport].[email_date] AS MOBILEORDERREPORT_EMAIL_DATE,[MobileOrderReport].[retrieve_cnt] AS MOBILEORDERREPORT_RETRIEVE_CNT,[MobileOrderReport].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORT_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[cdate] AS MOBILEORDERREPORT_CDATE,[MobileOrderReport].[retrieve_sn] AS MOBILEORDERREPORT_RETRIEVE_SN,[MobileOrderReport].[cid] AS MOBILEORDERREPORT_CID,[MobileOrderReport].[did] AS MOBILEORDERREPORT_DID,[MobileOrderReport].[sent_again_date] AS MOBILEORDERREPORT_SENT_AGAIN_DATE,[MobileOrderReport].[idd_vas] AS MOBILEORDERREPORT_IDD_VAS,[MobileOrderReport].[active] AS MOBILEORDERREPORT_ACTIVE,[MobileOrderReport].[fallout_reason] AS MOBILEORDERREPORT_FALLOUT_REASON,[MobileOrderReport].[fallout_remark] AS MOBILEORDERREPORT_FALLOUT_REMARK,[MobileOrderReport].[fallout_main_category] AS MOBILEORDERREPORT_FALLOUT_MAIN_CATEGORY,[MobileOrderReport].[gw_retrieve_date] AS MOBILEORDERREPORT_GW_RETRIEVE_DATE,[MobileOrderReport].[report_type] AS MOBILEORDERREPORT_REPORT_TYPE,[MobileOrderReport].[reactive_sn] AS MOBILEORDERREPORT_REACTIVE_SN,[MobileOrderReport].[ddate] AS MOBILEORDERREPORT_DDATE,[MobileOrderReport].[ext_place_tel] AS MOBILEORDERREPORT_EXT_PLACE_TEL,[MobileOrderReport].[reactive_date] AS MOBILEORDERREPORT_REACTIVE_DATE,[MobileOrderReport].[order_id] AS MOBILEORDERREPORT_ORDER_ID,[MobileOrderReport].[retrieve_date] AS MOBILEORDERREPORT_RETRIEVE_DATE,[MobileOrderReport].[py_sent_again_retrieve_date] AS MOBILEORDERREPORT_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReport].[fallout_reply] AS MOBILEORDERREPORT_FALLOUT_REPLY  FROM  [MobileOrderReport]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReport");
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
        
        public bool Insert(string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReport _oMobileOrderReport=MobileOrderReportRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReport.order_status=x_sOrder_status;
            _oMobileOrderReport.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReport.sent_again=x_iSent_again;
            _oMobileOrderReport.email_date=x_dEmail_date;
            _oMobileOrderReport.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReport.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReport.cdate=x_dCdate;
            _oMobileOrderReport.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReport.cid=x_sCid;
            _oMobileOrderReport.did=x_sDid;
            _oMobileOrderReport.sent_again_date=x_dSent_again_date;
            _oMobileOrderReport.idd_vas=x_sIdd_vas;
            _oMobileOrderReport.active=x_bActive;
            _oMobileOrderReport.fallout_reason=x_sFallout_reason;
            _oMobileOrderReport.fallout_remark=x_sFallout_remark;
            _oMobileOrderReport.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReport.report_type=x_sReport_type;
            _oMobileOrderReport.fallout_reply=x_sFallout_reply;
            _oMobileOrderReport.reactive_sn=x_sReactive_sn;
            _oMobileOrderReport.ddate=x_dDdate;
            _oMobileOrderReport.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReport.reactive_date=x_dReactive_date;
            _oMobileOrderReport.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReport.order_id=x_iOrder_id;
            _oMobileOrderReport.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReport.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReport);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReport _oMobileOrderReport=MobileOrderReportRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReport.order_status=x_sOrder_status;
            _oMobileOrderReport.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReport.sent_again=x_iSent_again;
            _oMobileOrderReport.email_date=x_dEmail_date;
            _oMobileOrderReport.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReport.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReport.cdate=x_dCdate;
            _oMobileOrderReport.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReport.cid=x_sCid;
            _oMobileOrderReport.did=x_sDid;
            _oMobileOrderReport.sent_again_date=x_dSent_again_date;
            _oMobileOrderReport.idd_vas=x_sIdd_vas;
            _oMobileOrderReport.active=x_bActive;
            _oMobileOrderReport.fallout_reason=x_sFallout_reason;
            _oMobileOrderReport.fallout_remark=x_sFallout_remark;
            _oMobileOrderReport.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReport.report_type=x_sReport_type;
            _oMobileOrderReport.fallout_reply=x_sFallout_reply;
            _oMobileOrderReport.reactive_sn=x_sReactive_sn;
            _oMobileOrderReport.ddate=x_dDdate;
            _oMobileOrderReport.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReport.reactive_date=x_dReactive_date;
            _oMobileOrderReport.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReport.order_id=x_iOrder_id;
            _oMobileOrderReport.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReport.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReport);
        }
        
        
        public bool Insert(MobileOrderReport x_oMobileOrderReport)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReport);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReport)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReport)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReport x_oMobileOrderReport)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReport);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReport x_oMobileOrderReport)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReport]   ([order_status],[gw_retrieve_sn],[sent_again],[email_date],[retrieve_cnt],[fs_sent_again_retrieve_date],[cdate],[retrieve_sn],[cid],[did],[sent_again_date],[idd_vas],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[gw_retrieve_date],[report_type],[reactive_sn],[ddate],[ext_place_tel],[reactive_date],[order_id],[retrieve_date],[py_sent_again_retrieve_date],[fallout_reply])  VALUES  (@order_status,@gw_retrieve_sn,@sent_again,@email_date,@retrieve_cnt,@fs_sent_again_retrieve_date,@cdate,@retrieve_sn,@cid,@did,@sent_again_date,@idd_vas,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@gw_retrieve_date,@report_type,@reactive_sn,@ddate,@ext_place_tel,@reactive_date,@order_id,@retrieve_date,@py_sent_again_retrieve_date,@fallout_reply)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReport);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReport x_oMobileOrderReport)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReport.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReport.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReport.order_status; }
                if(x_oMobileOrderReport.gw_retrieve_sn==null){  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.gw_retrieve_sn; }
                if(x_oMobileOrderReport.sent_again==null){  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReport.sent_again; }
                if(x_oMobileOrderReport.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.email_date; }
                if(x_oMobileOrderReport.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReport.retrieve_cnt; }
                if(x_oMobileOrderReport.fs_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.fs_sent_again_retrieve_date; }
                if(x_oMobileOrderReport.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.cdate; }
                if(x_oMobileOrderReport.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.retrieve_sn; }
                if(x_oMobileOrderReport.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.cid; }
                if(x_oMobileOrderReport.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.did; }
                if(x_oMobileOrderReport.sent_again_date==null){  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.sent_again_date; }
                if(x_oMobileOrderReport.idd_vas==null){  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReport.idd_vas; }
                if(x_oMobileOrderReport.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReport.active; }
                if(x_oMobileOrderReport.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReport.fallout_reason; }
                if(x_oMobileOrderReport.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReport.fallout_remark; }
                if(x_oMobileOrderReport.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReport.fallout_main_category; }
                if(x_oMobileOrderReport.gw_retrieve_date==null){  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.gw_retrieve_date; }
                if(x_oMobileOrderReport.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReport.report_type; }
                if(x_oMobileOrderReport.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReport.reactive_sn; }
                if(x_oMobileOrderReport.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.ddate; }
                if(x_oMobileOrderReport.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReport.ext_place_tel; }
                if(x_oMobileOrderReport.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.reactive_date; }
                if(x_oMobileOrderReport.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReport.order_id; }
                if(x_oMobileOrderReport.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.retrieve_date; }
                if(x_oMobileOrderReport.py_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.py_sent_again_retrieve_date; }
                if(x_oMobileOrderReport.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReport.fallout_reply; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReport _oMobileOrderReport=MobileOrderReportRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReport.order_status=x_sOrder_status;
            _oMobileOrderReport.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReport.sent_again=x_iSent_again;
            _oMobileOrderReport.email_date=x_dEmail_date;
            _oMobileOrderReport.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReport.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReport.cdate=x_dCdate;
            _oMobileOrderReport.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReport.cid=x_sCid;
            _oMobileOrderReport.did=x_sDid;
            _oMobileOrderReport.sent_again_date=x_dSent_again_date;
            _oMobileOrderReport.idd_vas=x_sIdd_vas;
            _oMobileOrderReport.active=x_bActive;
            _oMobileOrderReport.fallout_reason=x_sFallout_reason;
            _oMobileOrderReport.fallout_remark=x_sFallout_remark;
            _oMobileOrderReport.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReport.report_type=x_sReport_type;
            _oMobileOrderReport.fallout_reply=x_sFallout_reply;
            _oMobileOrderReport.reactive_sn=x_sReactive_sn;
            _oMobileOrderReport.ddate=x_dDdate;
            _oMobileOrderReport.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReport.reactive_date=x_dReactive_date;
            _oMobileOrderReport.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReport.order_id=x_iOrder_id;
            _oMobileOrderReport.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReport.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID(x_oDB, _oMobileOrderReport,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReport x_oMobileOrderReport)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReport, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReport x_oMobileOrderReport)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReport, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReport)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReport)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReport x_oMobileOrderReport, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReport]   ([order_status],[gw_retrieve_sn],[sent_again],[email_date],[retrieve_cnt],[fs_sent_again_retrieve_date],[cdate],[retrieve_sn],[cid],[did],[sent_again_date],[idd_vas],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[gw_retrieve_date],[report_type],[reactive_sn],[ddate],[ext_place_tel],[reactive_date],[order_id],[retrieve_date],[py_sent_again_retrieve_date],[fallout_reply])  VALUES  (@order_status,@gw_retrieve_sn,@sent_again,@email_date,@retrieve_cnt,@fs_sent_again_retrieve_date,@cdate,@retrieve_sn,@cid,@did,@sent_again_date,@idd_vas,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@gw_retrieve_date,@report_type,@reactive_sn,@ddate,@ext_place_tel,@reactive_date,@order_id,@retrieve_date,@py_sent_again_retrieve_date,@fallout_reply)"+" SELECT  @@IDENTITY AS MobileOrderReport_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReport,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReport x_oMobileOrderReport, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReport.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReport.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReport.order_status; }
                if(x_oMobileOrderReport.gw_retrieve_sn==null){  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.gw_retrieve_sn; }
                if(x_oMobileOrderReport.sent_again==null){  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReport.sent_again; }
                if(x_oMobileOrderReport.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.email_date; }
                if(x_oMobileOrderReport.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReport.retrieve_cnt; }
                if(x_oMobileOrderReport.fs_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.fs_sent_again_retrieve_date; }
                if(x_oMobileOrderReport.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.cdate; }
                if(x_oMobileOrderReport.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.retrieve_sn; }
                if(x_oMobileOrderReport.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.cid; }
                if(x_oMobileOrderReport.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReport.did; }
                if(x_oMobileOrderReport.sent_again_date==null){  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.sent_again_date; }
                if(x_oMobileOrderReport.idd_vas==null){  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReport.idd_vas; }
                if(x_oMobileOrderReport.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReport.active; }
                if(x_oMobileOrderReport.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReport.fallout_reason; }
                if(x_oMobileOrderReport.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReport.fallout_remark; }
                if(x_oMobileOrderReport.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReport.fallout_main_category; }
                if(x_oMobileOrderReport.gw_retrieve_date==null){  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.gw_retrieve_date; }
                if(x_oMobileOrderReport.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReport.report_type; }
                if(x_oMobileOrderReport.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReport.reactive_sn; }
                if(x_oMobileOrderReport.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.ddate; }
                if(x_oMobileOrderReport.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReport.ext_place_tel; }
                if(x_oMobileOrderReport.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.reactive_date; }
                if(x_oMobileOrderReport.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReport.order_id; }
                if(x_oMobileOrderReport.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.retrieve_date; }
                if(x_oMobileOrderReport.py_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReport.py_sent_again_retrieve_date; }
                if(x_oMobileOrderReport.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReport.fallout_reply; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReport_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReport_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReport_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReport _oMobileOrderReport=MobileOrderReportRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReport.order_status=x_sOrder_status;
            _oMobileOrderReport.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReport.sent_again=x_iSent_again;
            _oMobileOrderReport.email_date=x_dEmail_date;
            _oMobileOrderReport.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReport.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReport.cdate=x_dCdate;
            _oMobileOrderReport.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReport.cid=x_sCid;
            _oMobileOrderReport.did=x_sDid;
            _oMobileOrderReport.sent_again_date=x_dSent_again_date;
            _oMobileOrderReport.idd_vas=x_sIdd_vas;
            _oMobileOrderReport.active=x_bActive;
            _oMobileOrderReport.fallout_reason=x_sFallout_reason;
            _oMobileOrderReport.fallout_remark=x_sFallout_remark;
            _oMobileOrderReport.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReport.report_type=x_sReport_type;
            _oMobileOrderReport.fallout_reply=x_sFallout_reply;
            _oMobileOrderReport.reactive_sn=x_sReactive_sn;
            _oMobileOrderReport.ddate=x_dDdate;
            _oMobileOrderReport.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReport.reactive_date=x_dReactive_date;
            _oMobileOrderReport.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReport.order_id=x_iOrder_id;
            _oMobileOrderReport.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReport.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReport,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReport x_oMobileOrderReport)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReport, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReport x_oMobileOrderReport)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReport, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReport)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReport)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReport x_oMobileOrderReport, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORT";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReport,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReport x_oMobileOrderReport, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.order_status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.order_status; }
                _oPar=x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.gw_retrieve_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.gw_retrieve_sn; }
                _oPar=x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.sent_again==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.sent_again; }
                _oPar=x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.email_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.email_date; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.retrieve_cnt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.retrieve_cnt; }
                _oPar=x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.fs_sent_again_retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.fs_sent_again_retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.cdate; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.retrieve_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.retrieve_sn; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.did; }
                _oPar=x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.sent_again_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.sent_again_date; }
                _oPar=x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.idd_vas==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.idd_vas; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.active; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.fallout_reason==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.fallout_reason; }
                _oPar=x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.fallout_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.fallout_remark; }
                _oPar=x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.fallout_main_category==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.fallout_main_category; }
                _oPar=x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.gw_retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.gw_retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.report_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.report_type; }
                _oPar=x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.reactive_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.reactive_sn; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.ddate; }
                _oPar=x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.ext_place_tel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.ext_place_tel; }
                _oPar=x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.reactive_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.reactive_date; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.order_id; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.py_sent_again_retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReport.py_sent_again_retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReport.fallout_reply==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReport.fallout_reply; }
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
        
        #region INSERT_MOBILEORDERREPORT Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-12-07>
        ///-- Description:	<Description,MOBILEORDERREPORT, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORT Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORT', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORT;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORT
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @order_status nvarchar(50),
        @gw_retrieve_sn char(10),
        @sent_again int,
        @email_date datetime,
        @retrieve_cnt int,
        @fs_sent_again_retrieve_date datetime,
        @cdate datetime,
        @retrieve_sn char(10),
        @cid char(10),
        @did char(10),
        @sent_again_date datetime,
        @idd_vas nvarchar(30),
        @active bit,
        @fallout_reason nvarchar(250),
        @fallout_remark text,
        @fallout_main_category nvarchar(250),
        @report_type char(20),
        @fallout_reply text,
        @reactive_sn nvarchar(20),
        @ddate datetime,
        @ext_place_tel nvarchar(30),
        @reactive_date datetime,
        @gw_retrieve_date datetime,
        @order_id int,
        @py_sent_again_retrieve_date datetime,
        @retrieve_date datetime
        AS
        
        INSERT INTO  [MobileOrderReport]   ([order_status],[gw_retrieve_sn],[sent_again],[email_date],[retrieve_cnt],[fs_sent_again_retrieve_date],[cdate],[retrieve_sn],[cid],[did],[sent_again_date],[idd_vas],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[gw_retrieve_date],[report_type],[reactive_sn],[ddate],[ext_place_tel],[reactive_date],[order_id],[retrieve_date],[py_sent_again_retrieve_date],[fallout_reply])  VALUES  (@order_status,@gw_retrieve_sn,@sent_again,@email_date,@retrieve_cnt,@fs_sent_again_retrieve_date,@cdate,@retrieve_sn,@cid,@did,@sent_again_date,@idd_vas,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@gw_retrieve_date,@report_type,@reactive_sn,@ddate,@ext_place_tel,@reactive_date,@order_id,@retrieve_date,@py_sent_again_retrieve_date,@fallout_reply)
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
            string _sQuery = "DELETE FROM  [MobileOrderReport]  WHERE [MobileOrderReport].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
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
            return MobileOrderReportRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReport]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReport]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReport]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReport]"); }
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


