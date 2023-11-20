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
///-- Create date: <Create Date 2011-12-07>
///-- Description:	<Description,Table :[MobileOrderReportHistory],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportHistory] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReportHistory")]
    public class MobileOrderReportHistoryRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportHistoryRepositoryBase instance;
        public static MobileOrderReportHistoryRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportHistoryRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportHistoryRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportHistoryRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportHistoryEntity> MobileOrderReportHistorys;
        #endregion
        
        #region Constructor
        public MobileOrderReportHistoryRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportHistoryRepositoryBase() { 
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
        public static MobileOrderReportHistory CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReportHistory(_oDB);
        }
        
        public static MobileOrderReportHistory CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReportHistory(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReportHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
        
        
        public MobileOrderReportHistoryEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static MobileOrderReportHistoryEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportHistory _MobileOrderReportHistory = (MobileOrderReportHistory)MobileOrderReportHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportHistory.Load(x_iMid)) { return null; }
            return _MobileOrderReportHistory;
        }
        
        
        
        public static MobileOrderReportHistoryEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportHistoryEntity> _oMobileOrderReportHistoryList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderReportHistoryList==null){ return null;}
            return _oMobileOrderReportHistoryList.Count == 0 ? null : _oMobileOrderReportHistoryList.ToArray();
        }
        
        public static List<MobileOrderReportHistoryEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportHistoryEntity> _oMobileOrderReportHistoryList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportHistoryList==null){ return null;}
            return _oMobileOrderReportHistoryList.Count == 0 ? null : _oMobileOrderReportHistoryList.ToArray();
        }
        
        
        public static MobileOrderReportHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportHistoryEntity> _oMobileOrderReportHistoryList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportHistoryList==null){ return null;}
            return _oMobileOrderReportHistoryList.Count == 0 ? null : _oMobileOrderReportHistoryList.ToArray();
        }
        
        public static List<MobileOrderReportHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportHistoryEntity> _oRow = new List<MobileOrderReportHistoryEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReportHistory].[order_status] AS MOBILEORDERREPORTHISTORY_ORDER_STATUS,[MobileOrderReportHistory].[gw_retrieve_sn] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN,[MobileOrderReportHistory].[sent_again] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN,[MobileOrderReportHistory].[mid] AS MOBILEORDERREPORTHISTORY_MID,[MobileOrderReportHistory].[email_date] AS MOBILEORDERREPORTHISTORY_EMAIL_DATE,[MobileOrderReportHistory].[retrieve_cnt] AS MOBILEORDERREPORTHISTORY_RETRIEVE_CNT,[MobileOrderReportHistory].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[cdate] AS MOBILEORDERREPORTHISTORY_CDATE,[MobileOrderReportHistory].[retrieve_sn] AS MOBILEORDERREPORTHISTORY_RETRIEVE_SN,[MobileOrderReportHistory].[cid] AS MOBILEORDERREPORTHISTORY_CID,[MobileOrderReportHistory].[did] AS MOBILEORDERREPORTHISTORY_DID,[MobileOrderReportHistory].[sent_again_date] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE,[MobileOrderReportHistory].[idd_vas] AS MOBILEORDERREPORTHISTORY_IDD_VAS,[MobileOrderReportHistory].[active] AS MOBILEORDERREPORTHISTORY_ACTIVE,[MobileOrderReportHistory].[fallout_reason] AS MOBILEORDERREPORTHISTORY_FALLOUT_REASON,[MobileOrderReportHistory].[fallout_remark] AS MOBILEORDERREPORTHISTORY_FALLOUT_REMARK,[MobileOrderReportHistory].[fallout_main_category] AS MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportHistory].[gw_retrieve_date] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE,[MobileOrderReportHistory].[report_type] AS MOBILEORDERREPORTHISTORY_REPORT_TYPE,[MobileOrderReportHistory].[reactive_sn] AS MOBILEORDERREPORTHISTORY_REACTIVE_SN,[MobileOrderReportHistory].[ddate] AS MOBILEORDERREPORTHISTORY_DDATE,[MobileOrderReportHistory].[ext_place_tel] AS MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL,[MobileOrderReportHistory].[reactive_date] AS MOBILEORDERREPORTHISTORY_REACTIVE_DATE,[MobileOrderReportHistory].[order_id] AS MOBILEORDERREPORTHISTORY_ORDER_ID,[MobileOrderReportHistory].[rec_no] AS MOBILEORDERREPORTHISTORY_REC_NO,[MobileOrderReportHistory].[retrieve_date] AS MOBILEORDERREPORTHISTORY_RETRIEVE_DATE,[MobileOrderReportHistory].[py_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[fallout_reply] AS MOBILEORDERREPORTHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportHistory]";
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
                _sQuery += " WHERE [MobileOrderReportHistory].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReportHistory _oMobileOrderReportHistory = MobileOrderReportHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"])) {_oMobileOrderReportHistory.order_status = (string)_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"]; }else{_oMobileOrderReportHistory.order_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"])) {_oMobileOrderReportHistory.gw_retrieve_sn = (string)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"]; }else{_oMobileOrderReportHistory.gw_retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"])) {_oMobileOrderReportHistory.sent_again = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"]; }else{_oMobileOrderReportHistory.sent_again=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_MID"])) {_oMobileOrderReportHistory.mid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_MID"]; }else{_oMobileOrderReportHistory.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"])) {_oMobileOrderReportHistory.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"]; }else{_oMobileOrderReportHistory.email_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"])) {_oMobileOrderReportHistory.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"]; }else{_oMobileOrderReportHistory.retrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.fs_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"]; }else{_oMobileOrderReportHistory.fs_sent_again_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CDATE"])) {_oMobileOrderReportHistory.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_CDATE"]; }else{_oMobileOrderReportHistory.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"])) {_oMobileOrderReportHistory.retrieve_sn = (string)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"]; }else{_oMobileOrderReportHistory.retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CID"])) {_oMobileOrderReportHistory.cid = (string)_oData["MOBILEORDERREPORTHISTORY_CID"]; }else{_oMobileOrderReportHistory.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DID"])) {_oMobileOrderReportHistory.did = (string)_oData["MOBILEORDERREPORTHISTORY_DID"]; }else{_oMobileOrderReportHistory.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"])) {_oMobileOrderReportHistory.sent_again_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"]; }else{_oMobileOrderReportHistory.sent_again_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"])) {_oMobileOrderReportHistory.idd_vas = (string)_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"]; }else{_oMobileOrderReportHistory.idd_vas=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ACTIVE"])) {_oMobileOrderReportHistory.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTHISTORY_ACTIVE"]; }else{_oMobileOrderReportHistory.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"])) {_oMobileOrderReportHistory.fallout_reason = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"]; }else{_oMobileOrderReportHistory.fallout_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"])) {_oMobileOrderReportHistory.fallout_remark = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"]; }else{_oMobileOrderReportHistory.fallout_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReportHistory.fallout_main_category = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"]; }else{_oMobileOrderReportHistory.fallout_main_category=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"])) {_oMobileOrderReportHistory.report_type = (string)_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"]; }else{_oMobileOrderReportHistory.report_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"])) {_oMobileOrderReportHistory.fallout_reply = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"]; }else{_oMobileOrderReportHistory.fallout_reply=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"])) {_oMobileOrderReportHistory.reactive_sn = (string)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"]; }else{_oMobileOrderReportHistory.reactive_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DDATE"])) {_oMobileOrderReportHistory.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_DDATE"]; }else{_oMobileOrderReportHistory.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"])) {_oMobileOrderReportHistory.ext_place_tel = (string)_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"]; }else{_oMobileOrderReportHistory.ext_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"])) {_oMobileOrderReportHistory.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"]; }else{_oMobileOrderReportHistory.reactive_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.gw_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"]; }else{_oMobileOrderReportHistory.gw_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REC_NO"])) {_oMobileOrderReportHistory.rec_no = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_REC_NO"]; }else{_oMobileOrderReportHistory.rec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"])) {_oMobileOrderReportHistory.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"]; }else{_oMobileOrderReportHistory.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.py_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"]; }else{_oMobileOrderReportHistory.py_sent_again_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"]; }else{_oMobileOrderReportHistory.retrieve_date=null;}
                        _oMobileOrderReportHistory.SetDB(x_oDB);
                        _oMobileOrderReportHistory.GetFound();
                        _oRow.Add(_oMobileOrderReportHistory);
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
        
        
        public static MobileOrderReportHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportHistoryEntity> _oMobileOrderReportHistoryList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportHistoryList==null){ return null;}
            return _oMobileOrderReportHistoryList.Count == 0 ? null : _oMobileOrderReportHistoryList.ToArray();
        }
        
        
        public static MobileOrderReportHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportHistoryEntity> _oMobileOrderReportHistoryList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportHistoryList==null){ return null;}
            return _oMobileOrderReportHistoryList.Count == 0 ? null : _oMobileOrderReportHistoryList.ToArray();
        }
        
        public static List<MobileOrderReportHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportHistoryEntity> _oRow = new List<MobileOrderReportHistoryEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReportHistory].[order_status] AS MOBILEORDERREPORTHISTORY_ORDER_STATUS,[MobileOrderReportHistory].[gw_retrieve_sn] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN,[MobileOrderReportHistory].[sent_again] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN,[MobileOrderReportHistory].[mid] AS MOBILEORDERREPORTHISTORY_MID,[MobileOrderReportHistory].[email_date] AS MOBILEORDERREPORTHISTORY_EMAIL_DATE,[MobileOrderReportHistory].[retrieve_cnt] AS MOBILEORDERREPORTHISTORY_RETRIEVE_CNT,[MobileOrderReportHistory].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[cdate] AS MOBILEORDERREPORTHISTORY_CDATE,[MobileOrderReportHistory].[retrieve_sn] AS MOBILEORDERREPORTHISTORY_RETRIEVE_SN,[MobileOrderReportHistory].[cid] AS MOBILEORDERREPORTHISTORY_CID,[MobileOrderReportHistory].[did] AS MOBILEORDERREPORTHISTORY_DID,[MobileOrderReportHistory].[sent_again_date] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE,[MobileOrderReportHistory].[idd_vas] AS MOBILEORDERREPORTHISTORY_IDD_VAS,[MobileOrderReportHistory].[active] AS MOBILEORDERREPORTHISTORY_ACTIVE,[MobileOrderReportHistory].[fallout_reason] AS MOBILEORDERREPORTHISTORY_FALLOUT_REASON,[MobileOrderReportHistory].[fallout_remark] AS MOBILEORDERREPORTHISTORY_FALLOUT_REMARK,[MobileOrderReportHistory].[fallout_main_category] AS MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportHistory].[gw_retrieve_date] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE,[MobileOrderReportHistory].[report_type] AS MOBILEORDERREPORTHISTORY_REPORT_TYPE,[MobileOrderReportHistory].[reactive_sn] AS MOBILEORDERREPORTHISTORY_REACTIVE_SN,[MobileOrderReportHistory].[ddate] AS MOBILEORDERREPORTHISTORY_DDATE,[MobileOrderReportHistory].[ext_place_tel] AS MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL,[MobileOrderReportHistory].[reactive_date] AS MOBILEORDERREPORTHISTORY_REACTIVE_DATE,[MobileOrderReportHistory].[order_id] AS MOBILEORDERREPORTHISTORY_ORDER_ID,[MobileOrderReportHistory].[rec_no] AS MOBILEORDERREPORTHISTORY_REC_NO,[MobileOrderReportHistory].[retrieve_date] AS MOBILEORDERREPORTHISTORY_RETRIEVE_DATE,[MobileOrderReportHistory].[py_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[fallout_reply] AS MOBILEORDERREPORTHISTORY_FALLOUT_REPLY";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportHistoryRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportHistoryEntity _oMobileOrderReportHistory = MobileOrderReportHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"])) {_oMobileOrderReportHistory.order_status = (string)_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"]; } else {_oMobileOrderReportHistory.order_status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"])) {_oMobileOrderReportHistory.gw_retrieve_sn = (string)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"]; } else {_oMobileOrderReportHistory.gw_retrieve_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"])) {_oMobileOrderReportHistory.sent_again = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"]; } else {_oMobileOrderReportHistory.sent_again=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_MID"])) {_oMobileOrderReportHistory.mid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_MID"]; } else {_oMobileOrderReportHistory.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"])) {_oMobileOrderReportHistory.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"]; } else {_oMobileOrderReportHistory.email_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"])) {_oMobileOrderReportHistory.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"]; } else {_oMobileOrderReportHistory.retrieve_cnt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.fs_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"]; } else {_oMobileOrderReportHistory.fs_sent_again_retrieve_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CDATE"])) {_oMobileOrderReportHistory.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_CDATE"]; } else {_oMobileOrderReportHistory.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"])) {_oMobileOrderReportHistory.retrieve_sn = (string)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"]; } else {_oMobileOrderReportHistory.retrieve_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CID"])) {_oMobileOrderReportHistory.cid = (string)_oData["MOBILEORDERREPORTHISTORY_CID"]; } else {_oMobileOrderReportHistory.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DID"])) {_oMobileOrderReportHistory.did = (string)_oData["MOBILEORDERREPORTHISTORY_DID"]; } else {_oMobileOrderReportHistory.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"])) {_oMobileOrderReportHistory.sent_again_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"]; } else {_oMobileOrderReportHistory.sent_again_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"])) {_oMobileOrderReportHistory.idd_vas = (string)_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"]; } else {_oMobileOrderReportHistory.idd_vas=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ACTIVE"])) {_oMobileOrderReportHistory.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTHISTORY_ACTIVE"]; } else {_oMobileOrderReportHistory.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"])) {_oMobileOrderReportHistory.fallout_reason = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"]; } else {_oMobileOrderReportHistory.fallout_reason=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"])) {_oMobileOrderReportHistory.fallout_remark = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"]; } else {_oMobileOrderReportHistory.fallout_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReportHistory.fallout_main_category = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"]; } else {_oMobileOrderReportHistory.fallout_main_category=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"])) {_oMobileOrderReportHistory.report_type = (string)_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"]; } else {_oMobileOrderReportHistory.report_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"])) {_oMobileOrderReportHistory.fallout_reply = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"]; } else {_oMobileOrderReportHistory.fallout_reply=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"])) {_oMobileOrderReportHistory.reactive_sn = (string)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"]; } else {_oMobileOrderReportHistory.reactive_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DDATE"])) {_oMobileOrderReportHistory.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_DDATE"]; } else {_oMobileOrderReportHistory.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"])) {_oMobileOrderReportHistory.ext_place_tel = (string)_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"]; } else {_oMobileOrderReportHistory.ext_place_tel=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"])) {_oMobileOrderReportHistory.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"]; } else {_oMobileOrderReportHistory.reactive_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.gw_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"]; } else {_oMobileOrderReportHistory.gw_retrieve_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REC_NO"])) {_oMobileOrderReportHistory.rec_no = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_REC_NO"]; } else {_oMobileOrderReportHistory.rec_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"])) {_oMobileOrderReportHistory.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"]; } else {_oMobileOrderReportHistory.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.py_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"]; } else {_oMobileOrderReportHistory.py_sent_again_retrieve_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"])) {_oMobileOrderReportHistory.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"]; } else {_oMobileOrderReportHistory.retrieve_date=null; }
                _oMobileOrderReportHistory.SetDB(x_oDB);
                _oMobileOrderReportHistory.GetFound();
                _oRow.Add(_oMobileOrderReportHistory);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReportHistory.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReportHistory.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReportHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReportHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReportHistory].[order_status] AS MOBILEORDERREPORTHISTORY_ORDER_STATUS,[MobileOrderReportHistory].[gw_retrieve_sn] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN,[MobileOrderReportHistory].[sent_again] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN,[MobileOrderReportHistory].[mid] AS MOBILEORDERREPORTHISTORY_MID,[MobileOrderReportHistory].[email_date] AS MOBILEORDERREPORTHISTORY_EMAIL_DATE,[MobileOrderReportHistory].[retrieve_cnt] AS MOBILEORDERREPORTHISTORY_RETRIEVE_CNT,[MobileOrderReportHistory].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[cdate] AS MOBILEORDERREPORTHISTORY_CDATE,[MobileOrderReportHistory].[retrieve_sn] AS MOBILEORDERREPORTHISTORY_RETRIEVE_SN,[MobileOrderReportHistory].[cid] AS MOBILEORDERREPORTHISTORY_CID,[MobileOrderReportHistory].[did] AS MOBILEORDERREPORTHISTORY_DID,[MobileOrderReportHistory].[sent_again_date] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE,[MobileOrderReportHistory].[idd_vas] AS MOBILEORDERREPORTHISTORY_IDD_VAS,[MobileOrderReportHistory].[active] AS MOBILEORDERREPORTHISTORY_ACTIVE,[MobileOrderReportHistory].[fallout_reason] AS MOBILEORDERREPORTHISTORY_FALLOUT_REASON,[MobileOrderReportHistory].[fallout_remark] AS MOBILEORDERREPORTHISTORY_FALLOUT_REMARK,[MobileOrderReportHistory].[fallout_main_category] AS MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportHistory].[gw_retrieve_date] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE,[MobileOrderReportHistory].[report_type] AS MOBILEORDERREPORTHISTORY_REPORT_TYPE,[MobileOrderReportHistory].[reactive_sn] AS MOBILEORDERREPORTHISTORY_REACTIVE_SN,[MobileOrderReportHistory].[ddate] AS MOBILEORDERREPORTHISTORY_DDATE,[MobileOrderReportHistory].[ext_place_tel] AS MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL,[MobileOrderReportHistory].[reactive_date] AS MOBILEORDERREPORTHISTORY_REACTIVE_DATE,[MobileOrderReportHistory].[order_id] AS MOBILEORDERREPORTHISTORY_ORDER_ID,[MobileOrderReportHistory].[rec_no] AS MOBILEORDERREPORTHISTORY_REC_NO,[MobileOrderReportHistory].[retrieve_date] AS MOBILEORDERREPORTHISTORY_RETRIEVE_DATE,[MobileOrderReportHistory].[py_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[fallout_reply] AS MOBILEORDERREPORTHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportHistory]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReportHistory");
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
        
        public bool Insert(string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iRec_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReportHistory _oMobileOrderReportHistory=MobileOrderReportHistoryRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReportHistory.order_status=x_sOrder_status;
            _oMobileOrderReportHistory.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReportHistory.sent_again=x_iSent_again;
            _oMobileOrderReportHistory.email_date=x_dEmail_date;
            _oMobileOrderReportHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportHistory.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReportHistory.cdate=x_dCdate;
            _oMobileOrderReportHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportHistory.cid=x_sCid;
            _oMobileOrderReportHistory.did=x_sDid;
            _oMobileOrderReportHistory.sent_again_date=x_dSent_again_date;
            _oMobileOrderReportHistory.idd_vas=x_sIdd_vas;
            _oMobileOrderReportHistory.active=x_bActive;
            _oMobileOrderReportHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportHistory.report_type=x_sReport_type;
            _oMobileOrderReportHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportHistory.ddate=x_dDdate;
            _oMobileOrderReportHistory.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReportHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportHistory.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReportHistory.rec_no=x_iRec_no;
            _oMobileOrderReportHistory.order_id=x_iOrder_id;
            _oMobileOrderReportHistory.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReportHistory.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReportHistory);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iRec_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReportHistory _oMobileOrderReportHistory=MobileOrderReportHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportHistory.order_status=x_sOrder_status;
            _oMobileOrderReportHistory.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReportHistory.sent_again=x_iSent_again;
            _oMobileOrderReportHistory.email_date=x_dEmail_date;
            _oMobileOrderReportHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportHistory.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReportHistory.cdate=x_dCdate;
            _oMobileOrderReportHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportHistory.cid=x_sCid;
            _oMobileOrderReportHistory.did=x_sDid;
            _oMobileOrderReportHistory.sent_again_date=x_dSent_again_date;
            _oMobileOrderReportHistory.idd_vas=x_sIdd_vas;
            _oMobileOrderReportHistory.active=x_bActive;
            _oMobileOrderReportHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportHistory.report_type=x_sReport_type;
            _oMobileOrderReportHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportHistory.ddate=x_dDdate;
            _oMobileOrderReportHistory.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReportHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportHistory.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReportHistory.rec_no=x_iRec_no;
            _oMobileOrderReportHistory.order_id=x_iOrder_id;
            _oMobileOrderReportHistory.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReportHistory.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReportHistory);
        }
        
        
        public bool Insert(MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReportHistory);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReportHistory)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReportHistory)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReportHistory);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportHistory]   ([order_status],[gw_retrieve_sn],[sent_again],[email_date],[retrieve_cnt],[fs_sent_again_retrieve_date],[cdate],[retrieve_sn],[cid],[did],[sent_again_date],[idd_vas],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[gw_retrieve_date],[report_type],[reactive_sn],[ddate],[ext_place_tel],[reactive_date],[order_id],[rec_no],[retrieve_date],[py_sent_again_retrieve_date],[fallout_reply])  VALUES  (@order_status,@gw_retrieve_sn,@sent_again,@email_date,@retrieve_cnt,@fs_sent_again_retrieve_date,@cdate,@retrieve_sn,@cid,@did,@sent_again_date,@idd_vas,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@gw_retrieve_date,@report_type,@reactive_sn,@ddate,@ext_place_tel,@reactive_date,@order_id,@rec_no,@retrieve_date,@py_sent_again_retrieve_date,@fallout_reply)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportHistory);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReportHistory.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportHistory.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportHistory.order_status; }
                if(x_oMobileOrderReportHistory.gw_retrieve_sn==null){  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.gw_retrieve_sn; }
                if(x_oMobileOrderReportHistory.sent_again==null){  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.sent_again; }
                if(x_oMobileOrderReportHistory.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.email_date; }
                if(x_oMobileOrderReportHistory.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.retrieve_cnt; }
                if(x_oMobileOrderReportHistory.fs_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.fs_sent_again_retrieve_date; }
                if(x_oMobileOrderReportHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.cdate; }
                if(x_oMobileOrderReportHistory.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.retrieve_sn; }
                if(x_oMobileOrderReportHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.cid; }
                if(x_oMobileOrderReportHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.did; }
                if(x_oMobileOrderReportHistory.sent_again_date==null){  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.sent_again_date; }
                if(x_oMobileOrderReportHistory.idd_vas==null){  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReportHistory.idd_vas; }
                if(x_oMobileOrderReportHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportHistory.active; }
                if(x_oMobileOrderReportHistory.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportHistory.fallout_reason; }
                if(x_oMobileOrderReportHistory.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportHistory.fallout_remark; }
                if(x_oMobileOrderReportHistory.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportHistory.fallout_main_category; }
                if(x_oMobileOrderReportHistory.gw_retrieve_date==null){  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.gw_retrieve_date; }
                if(x_oMobileOrderReportHistory.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportHistory.report_type; }
                if(x_oMobileOrderReportHistory.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportHistory.reactive_sn; }
                if(x_oMobileOrderReportHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.ddate; }
                if(x_oMobileOrderReportHistory.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReportHistory.ext_place_tel; }
                if(x_oMobileOrderReportHistory.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.reactive_date; }
                if(x_oMobileOrderReportHistory.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.order_id; }
                if(x_oMobileOrderReportHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.rec_no; }
                if(x_oMobileOrderReportHistory.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.retrieve_date; }
                if(x_oMobileOrderReportHistory.py_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.py_sent_again_retrieve_date; }
                if(x_oMobileOrderReportHistory.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportHistory.fallout_reply; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iRec_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReportHistory _oMobileOrderReportHistory=MobileOrderReportHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportHistory.order_status=x_sOrder_status;
            _oMobileOrderReportHistory.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReportHistory.sent_again=x_iSent_again;
            _oMobileOrderReportHistory.email_date=x_dEmail_date;
            _oMobileOrderReportHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportHistory.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReportHistory.cdate=x_dCdate;
            _oMobileOrderReportHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportHistory.cid=x_sCid;
            _oMobileOrderReportHistory.did=x_sDid;
            _oMobileOrderReportHistory.sent_again_date=x_dSent_again_date;
            _oMobileOrderReportHistory.idd_vas=x_sIdd_vas;
            _oMobileOrderReportHistory.active=x_bActive;
            _oMobileOrderReportHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportHistory.report_type=x_sReport_type;
            _oMobileOrderReportHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportHistory.ddate=x_dDdate;
            _oMobileOrderReportHistory.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReportHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportHistory.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReportHistory.rec_no=x_iRec_no;
            _oMobileOrderReportHistory.order_id=x_iOrder_id;
            _oMobileOrderReportHistory.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReportHistory.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID(x_oDB, _oMobileOrderReportHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReportHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReportHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportHistory)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReportHistory)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReportHistory x_oMobileOrderReportHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportHistory]   ([order_status],[gw_retrieve_sn],[sent_again],[email_date],[retrieve_cnt],[fs_sent_again_retrieve_date],[cdate],[retrieve_sn],[cid],[did],[sent_again_date],[idd_vas],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[gw_retrieve_date],[report_type],[reactive_sn],[ddate],[ext_place_tel],[reactive_date],[order_id],[rec_no],[retrieve_date],[py_sent_again_retrieve_date],[fallout_reply])  VALUES  (@order_status,@gw_retrieve_sn,@sent_again,@email_date,@retrieve_cnt,@fs_sent_again_retrieve_date,@cdate,@retrieve_sn,@cid,@did,@sent_again_date,@idd_vas,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@gw_retrieve_date,@report_type,@reactive_sn,@ddate,@ext_place_tel,@reactive_date,@order_id,@rec_no,@retrieve_date,@py_sent_again_retrieve_date,@fallout_reply)"+" SELECT  @@IDENTITY AS MobileOrderReportHistory_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportHistory,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportHistory x_oMobileOrderReportHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReportHistory.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportHistory.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportHistory.order_status; }
                if(x_oMobileOrderReportHistory.gw_retrieve_sn==null){  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.gw_retrieve_sn; }
                if(x_oMobileOrderReportHistory.sent_again==null){  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.sent_again; }
                if(x_oMobileOrderReportHistory.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.email_date; }
                if(x_oMobileOrderReportHistory.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.retrieve_cnt; }
                if(x_oMobileOrderReportHistory.fs_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.fs_sent_again_retrieve_date; }
                if(x_oMobileOrderReportHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.cdate; }
                if(x_oMobileOrderReportHistory.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.retrieve_sn; }
                if(x_oMobileOrderReportHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.cid; }
                if(x_oMobileOrderReportHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportHistory.did; }
                if(x_oMobileOrderReportHistory.sent_again_date==null){  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.sent_again_date; }
                if(x_oMobileOrderReportHistory.idd_vas==null){  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReportHistory.idd_vas; }
                if(x_oMobileOrderReportHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportHistory.active; }
                if(x_oMobileOrderReportHistory.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportHistory.fallout_reason; }
                if(x_oMobileOrderReportHistory.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportHistory.fallout_remark; }
                if(x_oMobileOrderReportHistory.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportHistory.fallout_main_category; }
                if(x_oMobileOrderReportHistory.gw_retrieve_date==null){  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.gw_retrieve_date; }
                if(x_oMobileOrderReportHistory.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportHistory.report_type; }
                if(x_oMobileOrderReportHistory.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportHistory.reactive_sn; }
                if(x_oMobileOrderReportHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.ddate; }
                if(x_oMobileOrderReportHistory.ext_place_tel==null){  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderReportHistory.ext_place_tel; }
                if(x_oMobileOrderReportHistory.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.reactive_date; }
                if(x_oMobileOrderReportHistory.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.order_id; }
                if(x_oMobileOrderReportHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportHistory.rec_no; }
                if(x_oMobileOrderReportHistory.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.retrieve_date; }
                if(x_oMobileOrderReportHistory.py_sent_again_retrieve_date==null){  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportHistory.py_sent_again_retrieve_date; }
                if(x_oMobileOrderReportHistory.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportHistory.fallout_reply; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReportHistory_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReportHistory_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReportHistory_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sGw_retrieve_sn,global::System.Nullable<int> x_iSent_again,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dFs_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,global::System.Nullable<DateTime> x_dSent_again_date,string x_sIdd_vas,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sFallout_reply,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,string x_sExt_place_tel,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<DateTime> x_dGw_retrieve_date,global::System.Nullable<int> x_iRec_no,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dPy_sent_again_retrieve_date,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReportHistory _oMobileOrderReportHistory=MobileOrderReportHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportHistory.order_status=x_sOrder_status;
            _oMobileOrderReportHistory.gw_retrieve_sn=x_sGw_retrieve_sn;
            _oMobileOrderReportHistory.sent_again=x_iSent_again;
            _oMobileOrderReportHistory.email_date=x_dEmail_date;
            _oMobileOrderReportHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportHistory.fs_sent_again_retrieve_date=x_dFs_sent_again_retrieve_date;
            _oMobileOrderReportHistory.cdate=x_dCdate;
            _oMobileOrderReportHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportHistory.cid=x_sCid;
            _oMobileOrderReportHistory.did=x_sDid;
            _oMobileOrderReportHistory.sent_again_date=x_dSent_again_date;
            _oMobileOrderReportHistory.idd_vas=x_sIdd_vas;
            _oMobileOrderReportHistory.active=x_bActive;
            _oMobileOrderReportHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportHistory.report_type=x_sReport_type;
            _oMobileOrderReportHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportHistory.ddate=x_dDdate;
            _oMobileOrderReportHistory.ext_place_tel=x_sExt_place_tel;
            _oMobileOrderReportHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportHistory.gw_retrieve_date=x_dGw_retrieve_date;
            _oMobileOrderReportHistory.rec_no=x_iRec_no;
            _oMobileOrderReportHistory.order_id=x_iOrder_id;
            _oMobileOrderReportHistory.py_sent_again_retrieve_date=x_dPy_sent_again_retrieve_date;
            _oMobileOrderReportHistory.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReportHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReportHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportHistory x_oMobileOrderReportHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReportHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportHistory)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReportHistory)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReportHistory x_oMobileOrderReportHistory, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORTHISTORY";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReportHistory,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportHistory x_oMobileOrderReportHistory, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.order_status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.order_status; }
                _oPar=x_oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.gw_retrieve_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.gw_retrieve_sn; }
                _oPar=x_oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.sent_again==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.sent_again; }
                _oPar=x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.email_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.email_date; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.retrieve_cnt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.retrieve_cnt; }
                _oPar=x_oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.fs_sent_again_retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.fs_sent_again_retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.cdate; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.retrieve_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.retrieve_sn; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.did; }
                _oPar=x_oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.sent_again_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.sent_again_date; }
                _oPar=x_oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.idd_vas==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.idd_vas; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.active; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.fallout_reason==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.fallout_reason; }
                _oPar=x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.fallout_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.fallout_remark; }
                _oPar=x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.fallout_main_category==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.fallout_main_category; }
                _oPar=x_oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.gw_retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.gw_retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.report_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.report_type; }
                _oPar=x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.reactive_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.reactive_sn; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.ddate; }
                _oPar=x_oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.ext_place_tel==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.ext_place_tel; }
                _oPar=x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.reactive_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.reactive_date; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.order_id; }
                _oPar=x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.rec_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.rec_no; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.py_sent_again_retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportHistory.py_sent_again_retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportHistory.fallout_reply==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportHistory.fallout_reply; }
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
        
        #region INSERT_MOBILEORDERREPORTHISTORY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-12-07>
        ///-- Description:	<Description,MOBILEORDERREPORTHISTORY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORTHISTORY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORTHISTORY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORTHISTORY;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORTHISTORY
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
        @fallout_reason text,
        @fallout_remark text,
        @fallout_main_category nvarchar(250),
        @report_type char(20),
        @fallout_reply text,
        @reactive_sn nvarchar(20),
        @ddate datetime,
        @ext_place_tel nvarchar(30),
        @reactive_date datetime,
        @gw_retrieve_date datetime,
        @rec_no int,
        @order_id int,
        @py_sent_again_retrieve_date datetime,
        @retrieve_date datetime
        AS
        
        INSERT INTO  [MobileOrderReportHistory]   ([order_status],[gw_retrieve_sn],[sent_again],[email_date],[retrieve_cnt],[fs_sent_again_retrieve_date],[cdate],[retrieve_sn],[cid],[did],[sent_again_date],[idd_vas],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[gw_retrieve_date],[report_type],[reactive_sn],[ddate],[ext_place_tel],[reactive_date],[order_id],[rec_no],[retrieve_date],[py_sent_again_retrieve_date],[fallout_reply])  VALUES  (@order_status,@gw_retrieve_sn,@sent_again,@email_date,@retrieve_cnt,@fs_sent_again_retrieve_date,@cdate,@retrieve_sn,@cid,@did,@sent_again_date,@idd_vas,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@gw_retrieve_date,@report_type,@reactive_sn,@ddate,@ext_place_tel,@reactive_date,@order_id,@rec_no,@retrieve_date,@py_sent_again_retrieve_date,@fallout_reply)
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
            string _sQuery = "DELETE FROM  [MobileOrderReportHistory]  WHERE [MobileOrderReportHistory].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
            return MobileOrderReportHistoryRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReportHistory]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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


