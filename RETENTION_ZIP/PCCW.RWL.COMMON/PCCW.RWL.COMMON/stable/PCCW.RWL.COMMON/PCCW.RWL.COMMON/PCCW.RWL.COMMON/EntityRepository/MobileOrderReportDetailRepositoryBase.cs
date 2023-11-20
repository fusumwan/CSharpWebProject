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
///-- Description:	<Description,Table :[MobileOrderReportDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderReportDetail] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderReportDetail")]
    public class MobileOrderReportDetailRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderReportDetailRepositoryBase instance;
        public static MobileOrderReportDetailRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderReportDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderReportDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderReportDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderReportDetailEntity> MobileOrderReportDetails;
        #endregion
        
        #region Constructor
        public MobileOrderReportDetailRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderReportDetailRepositoryBase() { 
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
        public static MobileOrderReportDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderReportDetail(_oDB);
        }
        
        public static MobileOrderReportDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderReportDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderReportDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
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
        
        
        public MobileOrderReportDetailEntity GetObj(global::System.Nullable<int> x_iReport_id)
        {
            return GetObj(n_oDB, x_iReport_id);
        }
        
        
        public static MobileOrderReportDetailEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_id)
        {
            if (x_oDB==null) { return null; }
            MobileOrderReportDetail _MobileOrderReportDetail = (MobileOrderReportDetail)MobileOrderReportDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderReportDetail.Load(x_iReport_id)) { return null; }
            return _MobileOrderReportDetail;
        }
        
        
        
        public static MobileOrderReportDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderReportDetailEntity> _oMobileOrderReportDetailList = GetListObj(x_oDB,0, "report_id", x_oArrayItemId);
            if(_oMobileOrderReportDetailList==null){ return null;}
            return _oMobileOrderReportDetailList.Count == 0 ? null : _oMobileOrderReportDetailList.ToArray();
        }
        
        public static List<MobileOrderReportDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "report_id", x_oArrayItemId);
        }
        
        
        public static MobileOrderReportDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportDetailEntity> _oMobileOrderReportDetailList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportDetailList==null){ return null;}
            return _oMobileOrderReportDetailList.Count == 0 ? null : _oMobileOrderReportDetailList.ToArray();
        }
        
        
        public static MobileOrderReportDetailEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderReportDetailEntity> _oMobileOrderReportDetailList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderReportDetailList==null){ return null;}
            return _oMobileOrderReportDetailList.Count == 0 ? null : _oMobileOrderReportDetailList.ToArray();
        }
        
        public static List<MobileOrderReportDetailEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderReportDetailEntity> _oRow = new List<MobileOrderReportDetailEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderReportDetail].[order_status] AS MOBILEORDERREPORTDETAIL_ORDER_STATUS,[MobileOrderReportDetail].[mflag] AS MOBILEORDERREPORTDETAIL_MFLAG,[MobileOrderReportDetail].[email_date] AS MOBILEORDERREPORTDETAIL_EMAIL_DATE,[MobileOrderReportDetail].[retrieve_cnt] AS MOBILEORDERREPORTDETAIL_RETRIEVE_CNT,[MobileOrderReportDetail].[cdate] AS MOBILEORDERREPORTDETAIL_CDATE,[MobileOrderReportDetail].[retrieve_sn] AS MOBILEORDERREPORTDETAIL_RETRIEVE_SN,[MobileOrderReportDetail].[cid] AS MOBILEORDERREPORTDETAIL_CID,[MobileOrderReportDetail].[did] AS MOBILEORDERREPORTDETAIL_DID,[MobileOrderReportDetail].[eid] AS MOBILEORDERREPORTDETAIL_EID,[MobileOrderReportDetail].[report_id] AS MOBILEORDERREPORTDETAIL_REPORT_ID,[MobileOrderReportDetail].[active] AS MOBILEORDERREPORTDETAIL_ACTIVE,[MobileOrderReportDetail].[fallout_reason] AS MOBILEORDERREPORTDETAIL_FALLOUT_REASON,[MobileOrderReportDetail].[fallout_remark] AS MOBILEORDERREPORTDETAIL_FALLOUT_REMARK,[MobileOrderReportDetail].[fallout_main_category] AS MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetail].[report_type] AS MOBILEORDERREPORTDETAIL_REPORT_TYPE,[MobileOrderReportDetail].[reactive_sn] AS MOBILEORDERREPORTDETAIL_REACTIVE_SN,[MobileOrderReportDetail].[ddate] AS MOBILEORDERREPORTDETAIL_DDATE,[MobileOrderReportDetail].[mdate] AS MOBILEORDERREPORTDETAIL_MDATE,[MobileOrderReportDetail].[reactive_date] AS MOBILEORDERREPORTDETAIL_REACTIVE_DATE,[MobileOrderReportDetail].[order_id] AS MOBILEORDERREPORTDETAIL_ORDER_ID,[MobileOrderReportDetail].[retrieve_date] AS MOBILEORDERREPORTDETAIL_RETRIEVE_DATE,[MobileOrderReportDetail].[fallout_reply] AS MOBILEORDERREPORTDETAIL_FALLOUT_REPLY  FROM  [MobileOrderReportDetail]";
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
                _sQuery += " WHERE [MobileOrderReportDetail].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderReportDetail _oMobileOrderReportDetail = MobileOrderReportDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ORDER_STATUS"])) {_oMobileOrderReportDetail.order_status = (string)_oData["MOBILEORDERREPORTDETAIL_ORDER_STATUS"]; }else{_oMobileOrderReportDetail.order_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REPLY"])) {_oMobileOrderReportDetail.fallout_reply = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REPLY"]; }else{_oMobileOrderReportDetail.fallout_reply=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_MFLAG"])) {_oMobileOrderReportDetail.mflag = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAIL_MFLAG"]; }else{_oMobileOrderReportDetail.mflag=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_EMAIL_DATE"])) {_oMobileOrderReportDetail.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_EMAIL_DATE"]; }else{_oMobileOrderReportDetail.email_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_CNT"])) {_oMobileOrderReportDetail.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_CNT"]; }else{_oMobileOrderReportDetail.retrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_CDATE"])) {_oMobileOrderReportDetail.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_CDATE"]; }else{_oMobileOrderReportDetail.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_SN"])) {_oMobileOrderReportDetail.retrieve_sn = (string)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_SN"]; }else{_oMobileOrderReportDetail.retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_CID"])) {_oMobileOrderReportDetail.cid = (string)_oData["MOBILEORDERREPORTDETAIL_CID"]; }else{_oMobileOrderReportDetail.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_DID"])) {_oMobileOrderReportDetail.did = (string)_oData["MOBILEORDERREPORTDETAIL_DID"]; }else{_oMobileOrderReportDetail.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_EID"])) {_oMobileOrderReportDetail.eid = (string)_oData["MOBILEORDERREPORTDETAIL_EID"]; }else{_oMobileOrderReportDetail.eid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REPORT_ID"])) {_oMobileOrderReportDetail.report_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_REPORT_ID"]; }else{_oMobileOrderReportDetail.report_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ACTIVE"])) {_oMobileOrderReportDetail.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAIL_ACTIVE"]; }else{_oMobileOrderReportDetail.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REASON"])) {_oMobileOrderReportDetail.fallout_reason = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REASON"]; }else{_oMobileOrderReportDetail.fallout_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REMARK"])) {_oMobileOrderReportDetail.fallout_remark = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REMARK"]; }else{_oMobileOrderReportDetail.fallout_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReportDetail.fallout_main_category = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY"]; }else{_oMobileOrderReportDetail.fallout_main_category=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REPORT_TYPE"])) {_oMobileOrderReportDetail.report_type = (string)_oData["MOBILEORDERREPORTDETAIL_REPORT_TYPE"]; }else{_oMobileOrderReportDetail.report_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REACTIVE_SN"])) {_oMobileOrderReportDetail.reactive_sn = (string)_oData["MOBILEORDERREPORTDETAIL_REACTIVE_SN"]; }else{_oMobileOrderReportDetail.reactive_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_DDATE"])) {_oMobileOrderReportDetail.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_DDATE"]; }else{_oMobileOrderReportDetail.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_MDATE"])) {_oMobileOrderReportDetail.mdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_MDATE"]; }else{_oMobileOrderReportDetail.mdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REACTIVE_DATE"])) {_oMobileOrderReportDetail.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_REACTIVE_DATE"]; }else{_oMobileOrderReportDetail.reactive_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ORDER_ID"])) {_oMobileOrderReportDetail.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_ORDER_ID"]; }else{_oMobileOrderReportDetail.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_DATE"])) {_oMobileOrderReportDetail.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_DATE"]; }else{_oMobileOrderReportDetail.retrieve_date=null;}
                        _oMobileOrderReportDetail.SetDB(x_oDB);
                        _oMobileOrderReportDetail.GetFound();
                        _oRow.Add(_oMobileOrderReportDetail);
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
        
        
        public static MobileOrderReportDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportDetailEntity> _oMobileOrderReportDetailList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportDetailList==null){ return null;}
            return _oMobileOrderReportDetailList.Count == 0 ? null : _oMobileOrderReportDetailList.ToArray();
        }
        
        
        public static MobileOrderReportDetailEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderReportDetailEntity> _oMobileOrderReportDetailList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderReportDetailList==null){ return null;}
            return _oMobileOrderReportDetailList.Count == 0 ? null : _oMobileOrderReportDetailList.ToArray();
        }
        
        public static List<MobileOrderReportDetailEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderReportDetailEntity> _oRow = new List<MobileOrderReportDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderReportDetail].[order_status] AS MOBILEORDERREPORTDETAIL_ORDER_STATUS,[MobileOrderReportDetail].[mflag] AS MOBILEORDERREPORTDETAIL_MFLAG,[MobileOrderReportDetail].[email_date] AS MOBILEORDERREPORTDETAIL_EMAIL_DATE,[MobileOrderReportDetail].[retrieve_cnt] AS MOBILEORDERREPORTDETAIL_RETRIEVE_CNT,[MobileOrderReportDetail].[cdate] AS MOBILEORDERREPORTDETAIL_CDATE,[MobileOrderReportDetail].[retrieve_sn] AS MOBILEORDERREPORTDETAIL_RETRIEVE_SN,[MobileOrderReportDetail].[cid] AS MOBILEORDERREPORTDETAIL_CID,[MobileOrderReportDetail].[did] AS MOBILEORDERREPORTDETAIL_DID,[MobileOrderReportDetail].[eid] AS MOBILEORDERREPORTDETAIL_EID,[MobileOrderReportDetail].[report_id] AS MOBILEORDERREPORTDETAIL_REPORT_ID,[MobileOrderReportDetail].[active] AS MOBILEORDERREPORTDETAIL_ACTIVE,[MobileOrderReportDetail].[fallout_reason] AS MOBILEORDERREPORTDETAIL_FALLOUT_REASON,[MobileOrderReportDetail].[fallout_remark] AS MOBILEORDERREPORTDETAIL_FALLOUT_REMARK,[MobileOrderReportDetail].[fallout_main_category] AS MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetail].[report_type] AS MOBILEORDERREPORTDETAIL_REPORT_TYPE,[MobileOrderReportDetail].[reactive_sn] AS MOBILEORDERREPORTDETAIL_REACTIVE_SN,[MobileOrderReportDetail].[ddate] AS MOBILEORDERREPORTDETAIL_DDATE,[MobileOrderReportDetail].[mdate] AS MOBILEORDERREPORTDETAIL_MDATE,[MobileOrderReportDetail].[reactive_date] AS MOBILEORDERREPORTDETAIL_REACTIVE_DATE,[MobileOrderReportDetail].[order_id] AS MOBILEORDERREPORTDETAIL_ORDER_ID,[MobileOrderReportDetail].[retrieve_date] AS MOBILEORDERREPORTDETAIL_RETRIEVE_DATE,[MobileOrderReportDetail].[fallout_reply] AS MOBILEORDERREPORTDETAIL_FALLOUT_REPLY";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderReportDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderReportDetailEntity _oMobileOrderReportDetail = MobileOrderReportDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ORDER_STATUS"])) {_oMobileOrderReportDetail.order_status = (string)_oData["MOBILEORDERREPORTDETAIL_ORDER_STATUS"]; } else {_oMobileOrderReportDetail.order_status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REPLY"])) {_oMobileOrderReportDetail.fallout_reply = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REPLY"]; } else {_oMobileOrderReportDetail.fallout_reply=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_MFLAG"])) {_oMobileOrderReportDetail.mflag = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAIL_MFLAG"]; } else {_oMobileOrderReportDetail.mflag=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_EMAIL_DATE"])) {_oMobileOrderReportDetail.email_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_EMAIL_DATE"]; } else {_oMobileOrderReportDetail.email_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_CNT"])) {_oMobileOrderReportDetail.retrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_CNT"]; } else {_oMobileOrderReportDetail.retrieve_cnt=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_CDATE"])) {_oMobileOrderReportDetail.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_CDATE"]; } else {_oMobileOrderReportDetail.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_SN"])) {_oMobileOrderReportDetail.retrieve_sn = (string)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_SN"]; } else {_oMobileOrderReportDetail.retrieve_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_CID"])) {_oMobileOrderReportDetail.cid = (string)_oData["MOBILEORDERREPORTDETAIL_CID"]; } else {_oMobileOrderReportDetail.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_DID"])) {_oMobileOrderReportDetail.did = (string)_oData["MOBILEORDERREPORTDETAIL_DID"]; } else {_oMobileOrderReportDetail.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_EID"])) {_oMobileOrderReportDetail.eid = (string)_oData["MOBILEORDERREPORTDETAIL_EID"]; } else {_oMobileOrderReportDetail.eid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REPORT_ID"])) {_oMobileOrderReportDetail.report_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_REPORT_ID"]; } else {_oMobileOrderReportDetail.report_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ACTIVE"])) {_oMobileOrderReportDetail.active = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAIL_ACTIVE"]; } else {_oMobileOrderReportDetail.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REASON"])) {_oMobileOrderReportDetail.fallout_reason = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REASON"]; } else {_oMobileOrderReportDetail.fallout_reason=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REMARK"])) {_oMobileOrderReportDetail.fallout_remark = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_REMARK"]; } else {_oMobileOrderReportDetail.fallout_remark=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY"])) {_oMobileOrderReportDetail.fallout_main_category = (string)_oData["MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY"]; } else {_oMobileOrderReportDetail.fallout_main_category=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REPORT_TYPE"])) {_oMobileOrderReportDetail.report_type = (string)_oData["MOBILEORDERREPORTDETAIL_REPORT_TYPE"]; } else {_oMobileOrderReportDetail.report_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REACTIVE_SN"])) {_oMobileOrderReportDetail.reactive_sn = (string)_oData["MOBILEORDERREPORTDETAIL_REACTIVE_SN"]; } else {_oMobileOrderReportDetail.reactive_sn=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_DDATE"])) {_oMobileOrderReportDetail.ddate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_DDATE"]; } else {_oMobileOrderReportDetail.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_MDATE"])) {_oMobileOrderReportDetail.mdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_MDATE"]; } else {_oMobileOrderReportDetail.mdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_REACTIVE_DATE"])) {_oMobileOrderReportDetail.reactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_REACTIVE_DATE"]; } else {_oMobileOrderReportDetail.reactive_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_ORDER_ID"])) {_oMobileOrderReportDetail.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAIL_ORDER_ID"]; } else {_oMobileOrderReportDetail.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_DATE"])) {_oMobileOrderReportDetail.retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAIL_RETRIEVE_DATE"]; } else {_oMobileOrderReportDetail.retrieve_date=null; }
                _oMobileOrderReportDetail.SetDB(x_oDB);
                _oMobileOrderReportDetail.GetFound();
                _oRow.Add(_oMobileOrderReportDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderReportDetail.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderReportDetail.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderReportDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderReportDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderReportDetail].[order_status] AS MOBILEORDERREPORTDETAIL_ORDER_STATUS,[MobileOrderReportDetail].[mflag] AS MOBILEORDERREPORTDETAIL_MFLAG,[MobileOrderReportDetail].[email_date] AS MOBILEORDERREPORTDETAIL_EMAIL_DATE,[MobileOrderReportDetail].[retrieve_cnt] AS MOBILEORDERREPORTDETAIL_RETRIEVE_CNT,[MobileOrderReportDetail].[cdate] AS MOBILEORDERREPORTDETAIL_CDATE,[MobileOrderReportDetail].[retrieve_sn] AS MOBILEORDERREPORTDETAIL_RETRIEVE_SN,[MobileOrderReportDetail].[cid] AS MOBILEORDERREPORTDETAIL_CID,[MobileOrderReportDetail].[did] AS MOBILEORDERREPORTDETAIL_DID,[MobileOrderReportDetail].[eid] AS MOBILEORDERREPORTDETAIL_EID,[MobileOrderReportDetail].[report_id] AS MOBILEORDERREPORTDETAIL_REPORT_ID,[MobileOrderReportDetail].[active] AS MOBILEORDERREPORTDETAIL_ACTIVE,[MobileOrderReportDetail].[fallout_reason] AS MOBILEORDERREPORTDETAIL_FALLOUT_REASON,[MobileOrderReportDetail].[fallout_remark] AS MOBILEORDERREPORTDETAIL_FALLOUT_REMARK,[MobileOrderReportDetail].[fallout_main_category] AS MOBILEORDERREPORTDETAIL_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetail].[report_type] AS MOBILEORDERREPORTDETAIL_REPORT_TYPE,[MobileOrderReportDetail].[reactive_sn] AS MOBILEORDERREPORTDETAIL_REACTIVE_SN,[MobileOrderReportDetail].[ddate] AS MOBILEORDERREPORTDETAIL_DDATE,[MobileOrderReportDetail].[mdate] AS MOBILEORDERREPORTDETAIL_MDATE,[MobileOrderReportDetail].[reactive_date] AS MOBILEORDERREPORTDETAIL_REACTIVE_DATE,[MobileOrderReportDetail].[order_id] AS MOBILEORDERREPORTDETAIL_ORDER_ID,[MobileOrderReportDetail].[retrieve_date] AS MOBILEORDERREPORTDETAIL_RETRIEVE_DATE,[MobileOrderReportDetail].[fallout_reply] AS MOBILEORDERREPORTDETAIL_FALLOUT_REPLY  FROM  [MobileOrderReportDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderReportDetail");
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
        
        public bool Insert(string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReportDetail _oMobileOrderReportDetail=MobileOrderReportDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderReportDetail.order_status=x_sOrder_status;
            _oMobileOrderReportDetail.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetail.mflag=x_bMflag;
            _oMobileOrderReportDetail.email_date=x_dEmail_date;
            _oMobileOrderReportDetail.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetail.cdate=x_dCdate;
            _oMobileOrderReportDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetail.cid=x_sCid;
            _oMobileOrderReportDetail.did=x_sDid;
            _oMobileOrderReportDetail.eid=x_sEid;
            _oMobileOrderReportDetail.active=x_bActive;
            _oMobileOrderReportDetail.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetail.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetail.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetail.report_type=x_sReport_type;
            _oMobileOrderReportDetail.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetail.ddate=x_dDdate;
            _oMobileOrderReportDetail.mdate=x_dMdate;
            _oMobileOrderReportDetail.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetail.order_id=x_iOrder_id;
            _oMobileOrderReportDetail.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(n_oDB, _oMobileOrderReportDetail);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            MobileOrderReportDetail _oMobileOrderReportDetail=MobileOrderReportDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportDetail.order_status=x_sOrder_status;
            _oMobileOrderReportDetail.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetail.mflag=x_bMflag;
            _oMobileOrderReportDetail.email_date=x_dEmail_date;
            _oMobileOrderReportDetail.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetail.cdate=x_dCdate;
            _oMobileOrderReportDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetail.cid=x_sCid;
            _oMobileOrderReportDetail.did=x_sDid;
            _oMobileOrderReportDetail.eid=x_sEid;
            _oMobileOrderReportDetail.active=x_bActive;
            _oMobileOrderReportDetail.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetail.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetail.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetail.report_type=x_sReport_type;
            _oMobileOrderReportDetail.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetail.ddate=x_dDdate;
            _oMobileOrderReportDetail.mdate=x_dMdate;
            _oMobileOrderReportDetail.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetail.order_id=x_iOrder_id;
            _oMobileOrderReportDetail.retrieve_date=x_dRetrieve_date;
            return InsertWithOutLastID(x_oDB, _oMobileOrderReportDetail);
        }
        
        
        public bool Insert(MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderReportDetail);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderReportDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderReportDetail)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderReportDetail);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportDetail]   ([order_status],[mflag],[email_date],[retrieve_cnt],[cdate],[retrieve_sn],[cid],[did],[eid],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[report_type],[reactive_sn],[ddate],[mdate],[reactive_date],[order_id],[retrieve_date],[fallout_reply])  VALUES  (@order_status,@mflag,@email_date,@retrieve_cnt,@cdate,@retrieve_sn,@cid,@did,@eid,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@report_type,@reactive_sn,@ddate,@mdate,@reactive_date,@order_id,@retrieve_date,@fallout_reply)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportDetail);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            bool _bResult = false;
            if (!x_oMobileOrderReportDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportDetail.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportDetail.order_status; }
                if(x_oMobileOrderReportDetail.mflag==null){  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetail.mflag; }
                if(x_oMobileOrderReportDetail.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.email_date; }
                if(x_oMobileOrderReportDetail.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetail.retrieve_cnt; }
                if(x_oMobileOrderReportDetail.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.cdate; }
                if(x_oMobileOrderReportDetail.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.retrieve_sn; }
                if(x_oMobileOrderReportDetail.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.cid; }
                if(x_oMobileOrderReportDetail.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.did; }
                if(x_oMobileOrderReportDetail.eid==null){  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.eid; }
                if(x_oMobileOrderReportDetail.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetail.active; }
                if(x_oMobileOrderReportDetail.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportDetail.fallout_reason; }
                if(x_oMobileOrderReportDetail.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetail.fallout_remark; }
                if(x_oMobileOrderReportDetail.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportDetail.fallout_main_category; }
                if(x_oMobileOrderReportDetail.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportDetail.report_type; }
                if(x_oMobileOrderReportDetail.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportDetail.reactive_sn; }
                if(x_oMobileOrderReportDetail.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.ddate; }
                if(x_oMobileOrderReportDetail.mdate==null){  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.mdate; }
                if(x_oMobileOrderReportDetail.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.reactive_date; }
                if(x_oMobileOrderReportDetail.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetail.order_id; }
                if(x_oMobileOrderReportDetail.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.retrieve_date; }
                if(x_oMobileOrderReportDetail.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetail.fallout_reply; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReportDetail _oMobileOrderReportDetail=MobileOrderReportDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportDetail.order_status=x_sOrder_status;
            _oMobileOrderReportDetail.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetail.mflag=x_bMflag;
            _oMobileOrderReportDetail.email_date=x_dEmail_date;
            _oMobileOrderReportDetail.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetail.cdate=x_dCdate;
            _oMobileOrderReportDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetail.cid=x_sCid;
            _oMobileOrderReportDetail.did=x_sDid;
            _oMobileOrderReportDetail.eid=x_sEid;
            _oMobileOrderReportDetail.active=x_bActive;
            _oMobileOrderReportDetail.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetail.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetail.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetail.report_type=x_sReport_type;
            _oMobileOrderReportDetail.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetail.ddate=x_dDdate;
            _oMobileOrderReportDetail.mdate=x_dMdate;
            _oMobileOrderReportDetail.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetail.order_id=x_iOrder_id;
            _oMobileOrderReportDetail.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID(x_oDB, _oMobileOrderReportDetail,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderReportDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderReportDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportDetail)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderReportDetail)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderReportDetail x_oMobileOrderReportDetail, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderReportDetail]   ([order_status],[mflag],[email_date],[retrieve_cnt],[cdate],[retrieve_sn],[cid],[did],[eid],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[report_type],[reactive_sn],[ddate],[mdate],[reactive_date],[order_id],[retrieve_date],[fallout_reply])  VALUES  (@order_status,@mflag,@email_date,@retrieve_cnt,@cdate,@retrieve_sn,@cid,@did,@eid,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@report_type,@reactive_sn,@ddate,@mdate,@reactive_date,@order_id,@retrieve_date,@fallout_reply)"+" SELECT  @@IDENTITY AS MobileOrderReportDetail_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderReportDetail,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportDetail x_oMobileOrderReportDetail, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderReportDetail.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderReportDetail.order_status==null){  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderReportDetail.order_status; }
                if(x_oMobileOrderReportDetail.mflag==null){  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetail.mflag; }
                if(x_oMobileOrderReportDetail.email_date==null){  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.email_date; }
                if(x_oMobileOrderReportDetail.retrieve_cnt==null){  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetail.retrieve_cnt; }
                if(x_oMobileOrderReportDetail.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.cdate; }
                if(x_oMobileOrderReportDetail.retrieve_sn==null){  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.retrieve_sn; }
                if(x_oMobileOrderReportDetail.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.cid; }
                if(x_oMobileOrderReportDetail.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.did; }
                if(x_oMobileOrderReportDetail.eid==null){  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value=x_oMobileOrderReportDetail.eid; }
                if(x_oMobileOrderReportDetail.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderReportDetail.active; }
                if(x_oMobileOrderReportDetail.fallout_reason==null){  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportDetail.fallout_reason; }
                if(x_oMobileOrderReportDetail.fallout_remark==null){  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetail.fallout_remark; }
                if(x_oMobileOrderReportDetail.fallout_main_category==null){  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderReportDetail.fallout_main_category; }
                if(x_oMobileOrderReportDetail.report_type==null){  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=x_oMobileOrderReportDetail.report_type; }
                if(x_oMobileOrderReportDetail.reactive_sn==null){  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderReportDetail.reactive_sn; }
                if(x_oMobileOrderReportDetail.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.ddate; }
                if(x_oMobileOrderReportDetail.mdate==null){  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.mdate; }
                if(x_oMobileOrderReportDetail.reactive_date==null){  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.reactive_date; }
                if(x_oMobileOrderReportDetail.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderReportDetail.order_id; }
                if(x_oMobileOrderReportDetail.retrieve_date==null){  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderReportDetail.retrieve_date; }
                if(x_oMobileOrderReportDetail.fallout_reply==null){  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value=x_oMobileOrderReportDetail.fallout_reply; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderReportDetail_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderReportDetail_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderReportDetail_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOrder_status,string x_sFallout_reply,global::System.Nullable<bool> x_bMflag,global::System.Nullable<DateTime> x_dEmail_date,global::System.Nullable<int> x_iRetrieve_cnt,global::System.Nullable<DateTime> x_dCdate,string x_sRetrieve_sn,string x_sCid,string x_sDid,string x_sEid,global::System.Nullable<bool> x_bActive,string x_sFallout_reason,string x_sFallout_remark,string x_sFallout_main_category,string x_sReport_type,string x_sReactive_sn,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dMdate,global::System.Nullable<DateTime> x_dReactive_date,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<DateTime> x_dRetrieve_date)
        {
            int _oLastID;
            MobileOrderReportDetail _oMobileOrderReportDetail=MobileOrderReportDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderReportDetail.order_status=x_sOrder_status;
            _oMobileOrderReportDetail.fallout_reply=x_sFallout_reply;
            _oMobileOrderReportDetail.mflag=x_bMflag;
            _oMobileOrderReportDetail.email_date=x_dEmail_date;
            _oMobileOrderReportDetail.retrieve_cnt=x_iRetrieve_cnt;
            _oMobileOrderReportDetail.cdate=x_dCdate;
            _oMobileOrderReportDetail.retrieve_sn=x_sRetrieve_sn;
            _oMobileOrderReportDetail.cid=x_sCid;
            _oMobileOrderReportDetail.did=x_sDid;
            _oMobileOrderReportDetail.eid=x_sEid;
            _oMobileOrderReportDetail.active=x_bActive;
            _oMobileOrderReportDetail.fallout_reason=x_sFallout_reason;
            _oMobileOrderReportDetail.fallout_remark=x_sFallout_remark;
            _oMobileOrderReportDetail.fallout_main_category=x_sFallout_main_category;
            _oMobileOrderReportDetail.report_type=x_sReport_type;
            _oMobileOrderReportDetail.reactive_sn=x_sReactive_sn;
            _oMobileOrderReportDetail.ddate=x_dDdate;
            _oMobileOrderReportDetail.mdate=x_dMdate;
            _oMobileOrderReportDetail.reactive_date=x_dReactive_date;
            _oMobileOrderReportDetail.order_id=x_iOrder_id;
            _oMobileOrderReportDetail.retrieve_date=x_dRetrieve_date;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderReportDetail,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderReportDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderReportDetail x_oMobileOrderReportDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderReportDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderReportDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderReportDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderReportDetail x_oMobileOrderReportDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERREPORTDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderReportDetail,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderReportDetail x_oMobileOrderReportDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.order_status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.order_status; }
                _oPar=x_oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.mflag==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.mflag; }
                _oPar=x_oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.email_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetail.email_date; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.retrieve_cnt==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.retrieve_cnt; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetail.cdate; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.retrieve_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.retrieve_sn; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.cid; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.did; }
                _oPar=x_oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.eid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.eid; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.active; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.fallout_reason==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.fallout_reason; }
                _oPar=x_oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.fallout_remark==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.fallout_remark; }
                _oPar=x_oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.fallout_main_category==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.fallout_main_category; }
                _oPar=x_oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.report_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.report_type; }
                _oPar=x_oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.reactive_sn==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.reactive_sn; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetail.ddate; }
                _oPar=x_oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.mdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetail.mdate; }
                _oPar=x_oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.reactive_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetail.reactive_date; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.order_id; }
                _oPar=x_oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.retrieve_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderReportDetail.retrieve_date; }
                _oPar=x_oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderReportDetail.fallout_reply==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderReportDetail.fallout_reply; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_REPORT_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_REPORT_ID"].Value.ToString());
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
        
        #region INSERT_MOBILEORDERREPORTDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2010-10-29>
        ///-- Description:	<Description,MOBILEORDERREPORTDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERREPORTDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERREPORTDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERREPORTDETAIL;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERREPORTDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_REPORT_ID int output,
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
        @fallout_reason nvarchar(250),
        @fallout_remark text,
        @fallout_main_category nvarchar(250),
        @report_type char(20),
        @reactive_sn nvarchar(20),
        @ddate datetime,
        @mdate datetime,
        @reactive_date datetime,
        @order_id int,
        @retrieve_date datetime
        AS
        
        INSERT INTO  [MobileOrderReportDetail]   ([order_status],[mflag],[email_date],[retrieve_cnt],[cdate],[retrieve_sn],[cid],[did],[eid],[active],[fallout_reason],[fallout_remark],[fallout_main_category],[report_type],[reactive_sn],[ddate],[mdate],[reactive_date],[order_id],[retrieve_date],[fallout_reply])  VALUES  (@order_status,@mflag,@email_date,@retrieve_cnt,@cdate,@retrieve_sn,@cid,@did,@eid,@active,@fallout_reason,@fallout_remark,@fallout_main_category,@report_type,@reactive_sn,@ddate,@mdate,@reactive_date,@order_id,@retrieve_date,@fallout_reply)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_REPORT_ID=@@IDENTITY
        RETURN @RETURN_REPORT_ID
        END
        ELSE
        BEGIN
        SET @RETURN_REPORT_ID=-1
        RETURN @RETURN_REPORT_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iReport_id)
        {
            return DeleteProc(n_oDB, x_iReport_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_id)
        {
            return DeleteProc(x_oDB, x_iReport_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iReport_id)
        {
            if (x_iReport_id==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportDetail]  WHERE [MobileOrderReportDetail].[report_id]=@report_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@report_id", global::System.Data.SqlDbType.Int).Value = x_iReport_id;
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
            return MobileOrderReportDetailRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderReportDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderReportDetail]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetail]"); }
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


