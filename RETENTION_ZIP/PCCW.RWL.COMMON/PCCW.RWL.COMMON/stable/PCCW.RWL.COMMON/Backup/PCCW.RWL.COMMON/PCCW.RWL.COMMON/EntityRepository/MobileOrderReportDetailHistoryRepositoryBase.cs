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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportDetailHistory],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportDetailHistory] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReportDetailHistory")]
    public class MobileOrderReportDetailHistoryRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportDetailHistoryRepositoryBase instance;
        public static MobileOrderReportDetailHistoryRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportDetailHistoryRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportDetailHistoryRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportDetailHistoryRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportDetailHistoryEntity> MobileOrderReportDetailHistorys;
        #endregion
        
        #region Constructor
        public MobileOrderReportDetailHistoryRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportDetailHistoryRepositoryBase() { 
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
        public static MobileOrderReportDetailHistory CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReportDetailHistory(_oDB);
        }
        
        public static MobileOrderReportDetailHistory CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReportDetailHistory(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReportDetailHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
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
        
        
        public MobileOrderReportDetailHistoryEntity GetObj(global::System.Nullable<int> x_iReport_his_id)
        {
            return GetObj(n_oDB, x_iReport_his_id);
        }
        
        
        public static MobileOrderReportDetailHistoryEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_his_id)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportDetailHistory _MobileOrderReportDetailHistory = (MobileOrderReportDetailHistory)MobileOrderReportDetailHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportDetailHistory.Load(x_iReport_his_id)) { return null; }
            return _MobileOrderReportDetailHistory;
        }
        
        
        
        public static MobileOrderReportDetailHistoryEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportDetailHistoryEntity> _oMobileOrderReportDetailHistoryList = GetListObj(x_oDB,0, "report_his_id", x_oArrayItemId);
            if(_oMobileOrderReportDetailHistoryList==null){ return null;}
            return _oMobileOrderReportDetailHistoryList.Count == 0 ? null : _oMobileOrderReportDetailHistoryList.ToArray();
        }
        
        public static List<MobileOrderReportDetailHistoryEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "report_his_id", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportDetailHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportDetailHistoryEntity> _oMobileOrderReportDetailHistoryList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportDetailHistoryList==null){ return null;}
            return _oMobileOrderReportDetailHistoryList.Count == 0 ? null : _oMobileOrderReportDetailHistoryList.ToArray();
        }
        
        
        public static MobileOrderReportDetailHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportDetailHistoryEntity> _oMobileOrderReportDetailHistoryList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportDetailHistoryList==null){ return null;}
            return _oMobileOrderReportDetailHistoryList.Count == 0 ? null : _oMobileOrderReportDetailHistoryList.ToArray();
        }
        
        public static List<MobileOrderReportDetailHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportDetailHistoryEntity> _oRow = new List<MobileOrderReportDetailHistoryEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReportDetailHistory].[order_status] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS,[MobileOrderReportDetailHistory].[mflag] AS MOBILEORDERREPORTDETAILHISTORY_MFLAG,[MobileOrderReportDetailHistory].[email_date] AS MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE,[MobileOrderReportDetailHistory].[retrieve_cnt] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT,[MobileOrderReportDetailHistory].[cdate] AS MOBILEORDERREPORTDETAILHISTORY_CDATE,[MobileOrderReportDetailHistory].[retrieve_sn] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN,[MobileOrderReportDetailHistory].[cid] AS MOBILEORDERREPORTDETAILHISTORY_CID,[MobileOrderReportDetailHistory].[did] AS MOBILEORDERREPORTDETAILHISTORY_DID,[MobileOrderReportDetailHistory].[eid] AS MOBILEORDERREPORTDETAILHISTORY_EID,[MobileOrderReportDetailHistory].[active] AS MOBILEORDERREPORTDETAILHISTORY_ACTIVE,[MobileOrderReportDetailHistory].[fallout_reason] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON,[MobileOrderReportDetailHistory].[fallout_remark] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK,[MobileOrderReportDetailHistory].[fallout_main_category] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetailHistory].[report_his_id] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID,[MobileOrderReportDetailHistory].[report_type] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE,[MobileOrderReportDetailHistory].[reactive_sn] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN,[MobileOrderReportDetailHistory].[ddate] AS MOBILEORDERREPORTDETAILHISTORY_DDATE,[MobileOrderReportDetailHistory].[mdate] AS MOBILEORDERREPORTDETAILHISTORY_MDATE,[MobileOrderReportDetailHistory].[reactive_date] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE,[MobileOrderReportDetailHistory].[order_id] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_ID,[MobileOrderReportDetailHistory].[rec_no] AS MOBILEORDERREPORTDETAILHISTORY_REC_NO,[MobileOrderReportDetailHistory].[retrieve_date] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE,[MobileOrderReportDetailHistory].[fallout_reply] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportDetailHistory]";
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
                _sQuery += " WHERE [MobileOrderReportDetailHistory].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReportDetailHistory _oMobileOrderReportDetailHistory = MobileOrderReportDetailHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"])) {_oMobileOrderReportDetailHistory.order_status = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"]; }else{_oMobileOrderReportDetailHistory.order_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"])) {_oMobileOrderReportDetailHistory.fallout_reply = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"]; }else{_oMobileOrderReportDetailHistory.fallout_reply=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"])) {_oMobileOrderReportDetailHistory.mflag = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"]; }else{_oMobileOrderReportDetailHistory.mflag=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"])) {_oMobileOrderReportDetailHistory.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"]; }else{_oMobileOrderReportDetailHistory.email_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"])) {_oMobileOrderReportDetailHistory.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"]; }else{_oMobileOrderReportDetailHistory.retrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"])) {_oMobileOrderReportDetailHistory.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"]; }else{_oMobileOrderReportDetailHistory.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"])) {_oMobileOrderReportDetailHistory.retrieve_sn = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"]; }else{_oMobileOrderReportDetailHistory.retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CID"])) {_oMobileOrderReportDetailHistory.cid = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_CID"]; }else{_oMobileOrderReportDetailHistory.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DID"])) {_oMobileOrderReportDetailHistory.did = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_DID"]; }else{_oMobileOrderReportDetailHistory.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EID"])) {_oMobileOrderReportDetailHistory.eid = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_EID"]; }else{_oMobileOrderReportDetailHistory.eid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"])) {_oMobileOrderReportDetailHistory.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"]; }else{_oMobileOrderReportDetailHistory.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"])) {_oMobileOrderReportDetailHistory.fallout_reason = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"]; }else{_oMobileOrderReportDetailHistory.fallout_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"])) {_oMobileOrderReportDetailHistory.fallout_remark = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"]; }else{_oMobileOrderReportDetailHistory.fallout_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReportDetailHistory.fallout_main_category = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"]; }else{_oMobileOrderReportDetailHistory.fallout_main_category=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"])) {_oMobileOrderReportDetailHistory.report_his_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"]; }else{_oMobileOrderReportDetailHistory.report_his_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"])) {_oMobileOrderReportDetailHistory.report_type = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"]; }else{_oMobileOrderReportDetailHistory.report_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"])) {_oMobileOrderReportDetailHistory.reactive_sn = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"]; }else{_oMobileOrderReportDetailHistory.reactive_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"])) {_oMobileOrderReportDetailHistory.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"]; }else{_oMobileOrderReportDetailHistory.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"])) {_oMobileOrderReportDetailHistory.mdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"]; }else{_oMobileOrderReportDetailHistory.mdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"])) {_oMobileOrderReportDetailHistory.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"]; }else{_oMobileOrderReportDetailHistory.reactive_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"])) {_oMobileOrderReportDetailHistory.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"]; }else{_oMobileOrderReportDetailHistory.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"])) {_oMobileOrderReportDetailHistory.rec_no = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"]; }else{_oMobileOrderReportDetailHistory.rec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"])) {_oMobileOrderReportDetailHistory.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"]; }else{_oMobileOrderReportDetailHistory.retrieve_date=null;}
                        _oMobileOrderReportDetailHistory.SetDB(x_oDB);
                        _oMobileOrderReportDetailHistory.GetFound();
                        _oRow.Add(_oMobileOrderReportDetailHistory);
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
        
        
        public static MobileOrderReportDetailHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportDetailHistoryEntity> _oMobileOrderReportDetailHistoryList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportDetailHistoryList==null){ return null;}
            return _oMobileOrderReportDetailHistoryList.Count == 0 ? null : _oMobileOrderReportDetailHistoryList.ToArray();
        }
        
        
        public static MobileOrderReportDetailHistoryEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportDetailHistoryEntity> _oMobileOrderReportDetailHistoryList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportDetailHistoryList==null){ return null;}
            return _oMobileOrderReportDetailHistoryList.Count == 0 ? null : _oMobileOrderReportDetailHistoryList.ToArray();
        }
        
        public static List<MobileOrderReportDetailHistoryEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportDetailHistoryEntity> _oRow = new List<MobileOrderReportDetailHistoryEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReportDetailHistory].[order_status] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS,[MobileOrderReportDetailHistory].[mflag] AS MOBILEORDERREPORTDETAILHISTORY_MFLAG,[MobileOrderReportDetailHistory].[email_date] AS MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE,[MobileOrderReportDetailHistory].[retrieve_cnt] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT,[MobileOrderReportDetailHistory].[cdate] AS MOBILEORDERREPORTDETAILHISTORY_CDATE,[MobileOrderReportDetailHistory].[retrieve_sn] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN,[MobileOrderReportDetailHistory].[cid] AS MOBILEORDERREPORTDETAILHISTORY_CID,[MobileOrderReportDetailHistory].[did] AS MOBILEORDERREPORTDETAILHISTORY_DID,[MobileOrderReportDetailHistory].[eid] AS MOBILEORDERREPORTDETAILHISTORY_EID,[MobileOrderReportDetailHistory].[active] AS MOBILEORDERREPORTDETAILHISTORY_ACTIVE,[MobileOrderReportDetailHistory].[fallout_reason] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON,[MobileOrderReportDetailHistory].[fallout_remark] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK,[MobileOrderReportDetailHistory].[fallout_main_category] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetailHistory].[report_his_id] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID,[MobileOrderReportDetailHistory].[report_type] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE,[MobileOrderReportDetailHistory].[reactive_sn] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN,[MobileOrderReportDetailHistory].[ddate] AS MOBILEORDERREPORTDETAILHISTORY_DDATE,[MobileOrderReportDetailHistory].[mdate] AS MOBILEORDERREPORTDETAILHISTORY_MDATE,[MobileOrderReportDetailHistory].[reactive_date] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE,[MobileOrderReportDetailHistory].[order_id] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_ID,[MobileOrderReportDetailHistory].[rec_no] AS MOBILEORDERREPORTDETAILHISTORY_REC_NO,[MobileOrderReportDetailHistory].[retrieve_date] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE,[MobileOrderReportDetailHistory].[fallout_reply] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportDetailHistoryRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportDetailHistoryEntity _oMobileOrderReportDetailHistory = MobileOrderReportDetailHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"])) {_oMobileOrderReportDetailHistory.order_status = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"]; } else {_oMobileOrderReportDetailHistory.order_status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"])) {_oMobileOrderReportDetailHistory.fallout_reply = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"]; } else {_oMobileOrderReportDetailHistory.fallout_reply=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"])) {_oMobileOrderReportDetailHistory.mflag = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"]; } else {_oMobileOrderReportDetailHistory.mflag=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"])) {_oMobileOrderReportDetailHistory.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"]; } else {_oMobileOrderReportDetailHistory.email_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"])) {_oMobileOrderReportDetailHistory.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"]; } else {_oMobileOrderReportDetailHistory.retrieve_cnt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"])) {_oMobileOrderReportDetailHistory.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"]; } else {_oMobileOrderReportDetailHistory.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"])) {_oMobileOrderReportDetailHistory.retrieve_sn = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"]; } else {_oMobileOrderReportDetailHistory.retrieve_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CID"])) {_oMobileOrderReportDetailHistory.cid = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_CID"]; } else {_oMobileOrderReportDetailHistory.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DID"])) {_oMobileOrderReportDetailHistory.did = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_DID"]; } else {_oMobileOrderReportDetailHistory.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EID"])) {_oMobileOrderReportDetailHistory.eid = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_EID"]; } else {_oMobileOrderReportDetailHistory.eid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"])) {_oMobileOrderReportDetailHistory.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"]; } else {_oMobileOrderReportDetailHistory.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"])) {_oMobileOrderReportDetailHistory.fallout_reason = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"]; } else {_oMobileOrderReportDetailHistory.fallout_reason=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"])) {_oMobileOrderReportDetailHistory.fallout_remark = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"]; } else {_oMobileOrderReportDetailHistory.fallout_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReportDetailHistory.fallout_main_category = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"]; } else {_oMobileOrderReportDetailHistory.fallout_main_category=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"])) {_oMobileOrderReportDetailHistory.report_his_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"]; } else {_oMobileOrderReportDetailHistory.report_his_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"])) {_oMobileOrderReportDetailHistory.report_type = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"]; } else {_oMobileOrderReportDetailHistory.report_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"])) {_oMobileOrderReportDetailHistory.reactive_sn = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"]; } else {_oMobileOrderReportDetailHistory.reactive_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"])) {_oMobileOrderReportDetailHistory.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"]; } else {_oMobileOrderReportDetailHistory.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"])) {_oMobileOrderReportDetailHistory.mdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"]; } else {_oMobileOrderReportDetailHistory.mdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"])) {_oMobileOrderReportDetailHistory.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"]; } else {_oMobileOrderReportDetailHistory.reactive_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"])) {_oMobileOrderReportDetailHistory.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"]; } else {_oMobileOrderReportDetailHistory.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"])) {_oMobileOrderReportDetailHistory.rec_no = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"]; } else {_oMobileOrderReportDetailHistory.rec_no=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"])) {_oMobileOrderReportDetailHistory.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"]; } else {_oMobileOrderReportDetailHistory.retrieve_date=null; }
                _oMobileOrderReportDetailHistory.SetDB(x_oDB);
                _oMobileOrderReportDetailHistory.GetFound();
                _oRow.Add(_oMobileOrderReportDetailHistory);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReportDetailHistory.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReportDetailHistory.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReportDetailHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReportDetailHistory.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReportDetailHistory].[order_status] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS,[MobileOrderReportDetailHistory].[mflag] AS MOBILEORDERREPORTDETAILHISTORY_MFLAG,[MobileOrderReportDetailHistory].[email_date] AS MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE,[MobileOrderReportDetailHistory].[retrieve_cnt] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT,[MobileOrderReportDetailHistory].[cdate] AS MOBILEORDERREPORTDETAILHISTORY_CDATE,[MobileOrderReportDetailHistory].[retrieve_sn] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN,[MobileOrderReportDetailHistory].[cid] AS MOBILEORDERREPORTDETAILHISTORY_CID,[MobileOrderReportDetailHistory].[did] AS MOBILEORDERREPORTDETAILHISTORY_DID,[MobileOrderReportDetailHistory].[eid] AS MOBILEORDERREPORTDETAILHISTORY_EID,[MobileOrderReportDetailHistory].[active] AS MOBILEORDERREPORTDETAILHISTORY_ACTIVE,[MobileOrderReportDetailHistory].[fallout_reason] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON,[MobileOrderReportDetailHistory].[fallout_remark] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK,[MobileOrderReportDetailHistory].[fallout_main_category] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetailHistory].[report_his_id] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID,[MobileOrderReportDetailHistory].[report_type] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE,[MobileOrderReportDetailHistory].[reactive_sn] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN,[MobileOrderReportDetailHistory].[ddate] AS MOBILEORDERREPORTDETAILHISTORY_DDATE,[MobileOrderReportDetailHistory].[mdate] AS MOBILEORDERREPORTDETAILHISTORY_MDATE,[MobileOrderReportDetailHistory].[reactive_date] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE,[MobileOrderReportDetailHistory].[order_id] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_ID,[MobileOrderReportDetailHistory].[rec_no] AS MOBILEORDERREPORTDETAILHISTORY_REC_NO,[MobileOrderReportDetailHistory].[retrieve_date] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE,[MobileOrderReportDetailHistory].[fallout_reply] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportDetailHistory]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReportDetailHistory");
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
        
        public bool Insert(string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<int> x_iRec_no,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReportDetailHistory _oMobileOrderReportDetailHistory=MobileOrderReportDetailHistoryRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReportDetailHistory.order_status=x_sOrder_status;
            _oMobileOrderReportDetailHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetailHistory.mflag=x_bMflag;
            _oMobileOrderReportDetailHistory.email_date=x_dEmail_date;
            _oMobileOrderReportDetailHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetailHistory.cdate=x_dCdate;
            _oMobileOrderReportDetailHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetailHistory.cid=x_sCid;
            _oMobileOrderReportDetailHistory.did=x_sDid;
            _oMobileOrderReportDetailHistory.eid=x_sEid;
            _oMobileOrderReportDetailHistory.active=x_bActive;
            _oMobileOrderReportDetailHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetailHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetailHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetailHistory.report_type=x_sReport_type;
            _oMobileOrderReportDetailHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetailHistory.ddate=x_dDdate;
            _oMobileOrderReportDetailHistory.mdate=x_dMdate;
            _oMobileOrderReportDetailHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetailHistory.order_id=x_iOrder_id;
            _oMobileOrderReportDetailHistory.rec_no=x_iRec_no;
            _oMobileOrderReportDetailHistory.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReportDetailHistory);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<int> x_iRec_no,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReportDetailHistory _oMobileOrderReportDetailHistory=MobileOrderReportDetailHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportDetailHistory.order_status=x_sOrder_status;
            _oMobileOrderReportDetailHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetailHistory.mflag=x_bMflag;
            _oMobileOrderReportDetailHistory.email_date=x_dEmail_date;
            _oMobileOrderReportDetailHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetailHistory.cdate=x_dCdate;
            _oMobileOrderReportDetailHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetailHistory.cid=x_sCid;
            _oMobileOrderReportDetailHistory.did=x_sDid;
            _oMobileOrderReportDetailHistory.eid=x_sEid;
            _oMobileOrderReportDetailHistory.active=x_bActive;
            _oMobileOrderReportDetailHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetailHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetailHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetailHistory.report_type=x_sReport_type;
            _oMobileOrderReportDetailHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetailHistory.ddate=x_dDdate;
            _oMobileOrderReportDetailHistory.mdate=x_dMdate;
            _oMobileOrderReportDetailHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetailHistory.order_id=x_iOrder_id;
            _oMobileOrderReportDetailHistory.rec_no=x_iRec_no;
            _oMobileOrderReportDetailHistory.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReportDetailHistory);
        }
        
        
        public bool Insert(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReportDetailHistory);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReportDetailHistory)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReportDetailHistory)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReportDetailHistory);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportDetailHistory]   ([order_status],[mflag],[email_date],[retrieve_cnt],[cdate],[retrieve_sn],[cid],[did],[eid],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[report_type],[reactive_sn],[ddate],[mdate],[reactive_date],[order_id],[rec_no],[retrieve_date],[fallout_reply])  VALUES  (@order_status,@mflag,@email_date,@retrieve_cnt,@cdate,@retrieve_sn,@cid,@did,@eid,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@report_type,@reactive_sn,@ddate,@mdate,@reactive_date,@order_id,@rec_no,@retrieve_date,@fallout_reply)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportDetailHistory);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReportDetailHistory.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportDetailHistory.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportDetailHistory.order_status; }
                if(x_oMobileOrderReportDetailHistory.mflag==null){  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetailHistory.mflag; }
                if(x_oMobileOrderReportDetailHistory.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.email_date; }
                if(x_oMobileOrderReportDetailHistory.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetailHistory.retrieve_cnt; }
                if(x_oMobileOrderReportDetailHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.cdate; }
                if(x_oMobileOrderReportDetailHistory.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.retrieve_sn; }
                if(x_oMobileOrderReportDetailHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.cid; }
                if(x_oMobileOrderReportDetailHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.did; }
                if(x_oMobileOrderReportDetailHistory.eid==null){  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.eid; }
                if(x_oMobileOrderReportDetailHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetailHistory.active; }
                if(x_oMobileOrderReportDetailHistory.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetailHistory.fallout_reason; }
                if(x_oMobileOrderReportDetailHistory.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetailHistory.fallout_remark; }
                if(x_oMobileOrderReportDetailHistory.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportDetailHistory.fallout_main_category; }
                if(x_oMobileOrderReportDetailHistory.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportDetailHistory.report_type; }
                if(x_oMobileOrderReportDetailHistory.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportDetailHistory.reactive_sn; }
                if(x_oMobileOrderReportDetailHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.ddate; }
                if(x_oMobileOrderReportDetailHistory.mdate==null){  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.mdate; }
                if(x_oMobileOrderReportDetailHistory.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.reactive_date; }
                if(x_oMobileOrderReportDetailHistory.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetailHistory.order_id; }
                if(x_oMobileOrderReportDetailHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetailHistory.rec_no; }
                if(x_oMobileOrderReportDetailHistory.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.retrieve_date; }
                if(x_oMobileOrderReportDetailHistory.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetailHistory.fallout_reply; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<int> x_iRec_no,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReportDetailHistory _oMobileOrderReportDetailHistory=MobileOrderReportDetailHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportDetailHistory.order_status=x_sOrder_status;
            _oMobileOrderReportDetailHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetailHistory.mflag=x_bMflag;
            _oMobileOrderReportDetailHistory.email_date=x_dEmail_date;
            _oMobileOrderReportDetailHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetailHistory.cdate=x_dCdate;
            _oMobileOrderReportDetailHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetailHistory.cid=x_sCid;
            _oMobileOrderReportDetailHistory.did=x_sDid;
            _oMobileOrderReportDetailHistory.eid=x_sEid;
            _oMobileOrderReportDetailHistory.active=x_bActive;
            _oMobileOrderReportDetailHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetailHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetailHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetailHistory.report_type=x_sReport_type;
            _oMobileOrderReportDetailHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetailHistory.ddate=x_dDdate;
            _oMobileOrderReportDetailHistory.mdate=x_dMdate;
            _oMobileOrderReportDetailHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetailHistory.order_id=x_iOrder_id;
            _oMobileOrderReportDetailHistory.rec_no=x_iRec_no;
            _oMobileOrderReportDetailHistory.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID(x_oDB, _oMobileOrderReportDetailHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReportDetailHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReportDetailHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportDetailHistory)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReportDetailHistory)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportDetailHistory]   ([order_status],[mflag],[email_date],[retrieve_cnt],[cdate],[retrieve_sn],[cid],[did],[eid],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[report_type],[reactive_sn],[ddate],[mdate],[reactive_date],[order_id],[rec_no],[retrieve_date],[fallout_reply])  VALUES  (@order_status,@mflag,@email_date,@retrieve_cnt,@cdate,@retrieve_sn,@cid,@did,@eid,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@report_type,@reactive_sn,@ddate,@mdate,@reactive_date,@order_id,@rec_no,@retrieve_date,@fallout_reply)"+" SELECT  @@IDENTITY AS MobileOrderReportDetailHistory_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportDetailHistory,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReportDetailHistory.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportDetailHistory.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportDetailHistory.order_status; }
                if(x_oMobileOrderReportDetailHistory.mflag==null){  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetailHistory.mflag; }
                if(x_oMobileOrderReportDetailHistory.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.email_date; }
                if(x_oMobileOrderReportDetailHistory.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetailHistory.retrieve_cnt; }
                if(x_oMobileOrderReportDetailHistory.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.cdate; }
                if(x_oMobileOrderReportDetailHistory.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.retrieve_sn; }
                if(x_oMobileOrderReportDetailHistory.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.cid; }
                if(x_oMobileOrderReportDetailHistory.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.did; }
                if(x_oMobileOrderReportDetailHistory.eid==null){  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetailHistory.eid; }
                if(x_oMobileOrderReportDetailHistory.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetailHistory.active; }
                if(x_oMobileOrderReportDetailHistory.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetailHistory.fallout_reason; }
                if(x_oMobileOrderReportDetailHistory.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetailHistory.fallout_remark; }
                if(x_oMobileOrderReportDetailHistory.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportDetailHistory.fallout_main_category; }
                if(x_oMobileOrderReportDetailHistory.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportDetailHistory.report_type; }
                if(x_oMobileOrderReportDetailHistory.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportDetailHistory.reactive_sn; }
                if(x_oMobileOrderReportDetailHistory.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.ddate; }
                if(x_oMobileOrderReportDetailHistory.mdate==null){  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.mdate; }
                if(x_oMobileOrderReportDetailHistory.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.reactive_date; }
                if(x_oMobileOrderReportDetailHistory.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetailHistory.order_id; }
                if(x_oMobileOrderReportDetailHistory.rec_no==null){  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetailHistory.rec_no; }
                if(x_oMobileOrderReportDetailHistory.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetailHistory.retrieve_date; }
                if(x_oMobileOrderReportDetailHistory.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetailHistory.fallout_reply; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReportDetailHistory_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReportDetailHistory_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReportDetailHistory_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<int> x_iRec_no,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReportDetailHistory _oMobileOrderReportDetailHistory=MobileOrderReportDetailHistoryRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportDetailHistory.order_status=x_sOrder_status;
            _oMobileOrderReportDetailHistory.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetailHistory.mflag=x_bMflag;
            _oMobileOrderReportDetailHistory.email_date=x_dEmail_date;
            _oMobileOrderReportDetailHistory.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetailHistory.cdate=x_dCdate;
            _oMobileOrderReportDetailHistory.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetailHistory.cid=x_sCid;
            _oMobileOrderReportDetailHistory.did=x_sDid;
            _oMobileOrderReportDetailHistory.eid=x_sEid;
            _oMobileOrderReportDetailHistory.active=x_bActive;
            _oMobileOrderReportDetailHistory.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetailHistory.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetailHistory.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetailHistory.report_type=x_sReport_type;
            _oMobileOrderReportDetailHistory.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetailHistory.ddate=x_dDdate;
            _oMobileOrderReportDetailHistory.mdate=x_dMdate;
            _oMobileOrderReportDetailHistory.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetailHistory.order_id=x_iOrder_id;
            _oMobileOrderReportDetailHistory.rec_no=x_iRec_no;
            _oMobileOrderReportDetailHistory.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReportDetailHistory,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReportDetailHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReportDetailHistory, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportDetailHistory)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReportDetailHistory)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORTDETAILHISTORY";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReportDetailHistory,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportDetailHistory x_oMobileOrderReportDetailHistory, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.order_status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.order_status; }
                _oPar=x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.mflag==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.mflag; }
                _oPar=x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.email_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.email_date; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.retrieve_cnt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.retrieve_cnt; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.cdate; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.retrieve_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.retrieve_sn; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.did; }
                _oPar=x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.eid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.eid; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.active; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.fallout_reason==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.fallout_reason; }
                _oPar=x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.fallout_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.fallout_remark; }
                _oPar=x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.fallout_main_category==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.fallout_main_category; }
                _oPar=x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.report_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.report_type; }
                _oPar=x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.reactive_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.reactive_sn; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.ddate; }
                _oPar=x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.mdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.mdate; }
                _oPar=x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.reactive_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.reactive_date; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.order_id; }
                _oPar=x_oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.rec_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.rec_no; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetailHistory.fallout_reply==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetailHistory.fallout_reply; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_REPORT_HIS_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_REPORT_HIS_ID"].Value.ToString());
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
        
        #region INSERT_MOBILEORDERREPORTDETAILHISTORY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-10-29>
        ///-- Description:	<Description,MOBILEORDERREPORTDETAILHISTORY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORTDETAILHISTORY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORTDETAILHISTORY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORTDETAILHISTORY;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORTDETAILHISTORY
        	-- Add the parameters for the stored procedure here
        @RETURN_REPORT_HIS_ID int output,
        @order_status nvarchar(50),
        @fallout_reply text,
        @mflag bit,
        @email_date datetime,
        @retrieve_cnt int,
        @cdate datetime,
        @retrieve_sn char(10),
        @cid char(10),
        @did char(10),
        @eid char(10),
        @active bit,
        @fallout_reason text,
        @fallout_remark text,
        @fallout_main_category nvarchar(250),
        @report_type char(20),
        @reactive_sn nvarchar(20),
        @ddate datetime,
        @mdate datetime,
        @reactive_date datetime,
        @order_id int,
        @rec_no int,
        @retrieve_date datetime
        AS
        
        INSERT INTO  [MobileOrderReportDetailHistory]   ([order_status],[mflag],[email_date],[retrieve_cnt],[cdate],[retrieve_sn],[cid],[did],[eid],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[report_type],[reactive_sn],[ddate],[mdate],[reactive_date],[order_id],[rec_no],[retrieve_date],[fallout_reply])  VALUES  (@order_status,@mflag,@email_date,@retrieve_cnt,@cdate,@retrieve_sn,@cid,@did,@eid,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@report_type,@reactive_sn,@ddate,@mdate,@reactive_date,@order_id,@rec_no,@retrieve_date,@fallout_reply)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_REPORT_HIS_ID=@@IDENTITY
        RETURN @RETURN_REPORT_HIS_ID
        END
        ELSE
        BEGIN
        SET @RETURN_REPORT_HIS_ID=-1
        RETURN @RETURN_REPORT_HIS_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iReport_his_id)
        {
            return DeleteProc(n_oDB, x_iReport_his_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_his_id)
        {
            return DeleteProc(x_oDB, x_iReport_his_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iReport_his_id)
        {
            if (x_iReport_his_id==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportDetailHistory]  WHERE [MobileOrderReportDetailHistory].[report_his_id]=@report_his_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@report_his_id", global::System.Data.SqlDbType.Int).Value = x_iReport_his_id;
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
            return MobileOrderReportDetailHistoryRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportDetailHistory]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReportDetailHistory]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
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


