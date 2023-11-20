using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
///-- Description:	<Description,Table :[MobileOrderReportDetailHistory],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderReportDetailHistory] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderReportDetailHistory")]
    public class MobileOrderReportDetailHistoryEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
        public bool n_bStrNullToEmpty = true;
        #region StrNullToEmpty
        public bool StrNullToEmpty
        {
            get
            {
                return this.n_bStrNullToEmpty;
            }
            set
            {
                this.n_bStrNullToEmpty = value;
            }
        }
        #endregion
        
        
        protected string n_sOrder_status=global::System.String.Empty;
        #region order_status
        [System.Data.Linq.Mapping.Column(Name="[order_status]", Storage="n_sOrder_status")]
        public string order_status{
            get{
                return this.n_sOrder_status;
            }
            set{
                this.n_sOrder_status=value;
            }
        }
        #endregion order_status
        
        
        protected global::System.Nullable<bool> n_bMflag=null;
        #region mflag
        [System.Data.Linq.Mapping.Column(Name="[mflag]", Storage="n_bMflag")]
        public global::System.Nullable<bool> mflag{
            get{
                return this.n_bMflag;
            }
            set{
                this.n_bMflag=value;
            }
        }
        #endregion mflag
        
        
        protected global::System.Nullable<DateTime> n_dEmail_date=null;
        #region email_date
        [System.Data.Linq.Mapping.Column(Name="[email_date]", Storage="n_dEmail_date")]
        public global::System.Nullable<DateTime> email_date{
            get{
                return this.n_dEmail_date;
            }
            set{
                this.n_dEmail_date=value;
            }
        }
        #endregion email_date
        
        
        protected global::System.Nullable<int> n_iRetrieve_cnt=null;
        #region retrieve_cnt
        [System.Data.Linq.Mapping.Column(Name="[retrieve_cnt]", Storage="n_iRetrieve_cnt")]
        public global::System.Nullable<int> retrieve_cnt{
            get{
                return this.n_iRetrieve_cnt;
            }
            set{
                this.n_iRetrieve_cnt=value;
            }
        }
        #endregion retrieve_cnt
        
        
        protected global::System.Nullable<DateTime> n_dCdate=null;
        #region cdate
        [System.Data.Linq.Mapping.Column(Name="[cdate]", Storage="n_dCdate")]
        public global::System.Nullable<DateTime> cdate{
            get{
                return this.n_dCdate;
            }
            set{
                this.n_dCdate=value;
            }
        }
        #endregion cdate
        
        
        protected string n_sRetrieve_sn=global::System.String.Empty;
        #region retrieve_sn
        [System.Data.Linq.Mapping.Column(Name="[retrieve_sn]", Storage="n_sRetrieve_sn")]
        public string retrieve_sn{
            get{
                return this.n_sRetrieve_sn;
            }
            set{
                this.n_sRetrieve_sn=value;
            }
        }
        #endregion retrieve_sn
        
        
        protected string n_sCid=global::System.String.Empty;
        #region cid
        [System.Data.Linq.Mapping.Column(Name="[cid]", Storage="n_sCid")]
        public string cid{
            get{
                return this.n_sCid;
            }
            set{
                this.n_sCid=value;
            }
        }
        #endregion cid
        
        
        protected string n_sDid=global::System.String.Empty;
        #region did
        [System.Data.Linq.Mapping.Column(Name="[did]", Storage="n_sDid")]
        public string did{
            get{
                return this.n_sDid;
            }
            set{
                this.n_sDid=value;
            }
        }
        #endregion did
        
        
        protected string n_sEid=global::System.String.Empty;
        #region eid
        [System.Data.Linq.Mapping.Column(Name="[eid]", Storage="n_sEid")]
        public string eid{
            get{
                return this.n_sEid;
            }
            set{
                this.n_sEid=value;
            }
        }
        #endregion eid
        
        
        protected global::System.Nullable<bool> n_bActive=null;
        #region active
        [System.Data.Linq.Mapping.Column(Name="[active]", Storage="n_bActive")]
        public global::System.Nullable<bool> active{
            get{
                return this.n_bActive;
            }
            set{
                this.n_bActive=value;
            }
        }
        #endregion active
        
        
        protected string n_sFallout_reason=global::System.String.Empty;
        #region fallout_reason
        [System.Data.Linq.Mapping.Column(Name="[fallout_reason]", Storage="n_sFallout_reason")]
        public string fallout_reason{
            get{
                return this.n_sFallout_reason;
            }
            set{
                this.n_sFallout_reason=value;
            }
        }
        #endregion fallout_reason
        
        
        protected string n_sFallout_remark=global::System.String.Empty;
        #region fallout_remark
        [System.Data.Linq.Mapping.Column(Name="[fallout_remark]", Storage="n_sFallout_remark")]
        public string fallout_remark{
            get{
                return this.n_sFallout_remark;
            }
            set{
                this.n_sFallout_remark=value;
            }
        }
        #endregion fallout_remark
        
        
        protected string n_sFallout_main_category=global::System.String.Empty;
        #region fallout_main_category
        [System.Data.Linq.Mapping.Column(Name="[fallout_main_category]", Storage="n_sFallout_main_category")]
        public string fallout_main_category{
            get{
                return this.n_sFallout_main_category;
            }
            set{
                this.n_sFallout_main_category=value;
            }
        }
        #endregion fallout_main_category
        
        
        protected global::System.Nullable<int> n_iReport_his_id=null;
        #region report_his_id
        [System.Data.Linq.Mapping.Column(Name="[report_his_id]", Storage="n_iReport_his_id")]
        public global::System.Nullable<int> report_his_id{
            get{
                return this.n_iReport_his_id;
            }
            set{
                this.n_iReport_his_id=value;
            }
        }
        #endregion report_his_id
        
        
        protected string n_sReport_type=global::System.String.Empty;
        #region report_type
        [System.Data.Linq.Mapping.Column(Name="[report_type]", Storage="n_sReport_type")]
        public string report_type{
            get{
                return this.n_sReport_type;
            }
            set{
                this.n_sReport_type=value;
            }
        }
        #endregion report_type
        
        
        protected string n_sReactive_sn=global::System.String.Empty;
        #region reactive_sn
        [System.Data.Linq.Mapping.Column(Name="[reactive_sn]", Storage="n_sReactive_sn")]
        public string reactive_sn{
            get{
                return this.n_sReactive_sn;
            }
            set{
                this.n_sReactive_sn=value;
            }
        }
        #endregion reactive_sn
        
        
        protected global::System.Nullable<DateTime> n_dDdate=null;
        #region ddate
        [System.Data.Linq.Mapping.Column(Name="[ddate]", Storage="n_dDdate")]
        public global::System.Nullable<DateTime> ddate{
            get{
                return this.n_dDdate;
            }
            set{
                this.n_dDdate=value;
            }
        }
        #endregion ddate
        
        
        protected global::System.Nullable<DateTime> n_dMdate=null;
        #region mdate
        [System.Data.Linq.Mapping.Column(Name="[mdate]", Storage="n_dMdate")]
        public global::System.Nullable<DateTime> mdate{
            get{
                return this.n_dMdate;
            }
            set{
                this.n_dMdate=value;
            }
        }
        #endregion mdate
        
        
        protected global::System.Nullable<DateTime> n_dReactive_date=null;
        #region reactive_date
        [System.Data.Linq.Mapping.Column(Name="[reactive_date]", Storage="n_dReactive_date")]
        public global::System.Nullable<DateTime> reactive_date{
            get{
                return this.n_dReactive_date;
            }
            set{
                this.n_dReactive_date=value;
            }
        }
        #endregion reactive_date
        
        
        protected global::System.Nullable<int> n_iOrder_id=null;
        #region order_id
        [System.Data.Linq.Mapping.Column(Name="[order_id]", Storage="n_iOrder_id")]
        public global::System.Nullable<int> order_id{
            get{
                return this.n_iOrder_id;
            }
            set{
                this.n_iOrder_id=value;
            }
        }
        #endregion order_id
        
        
        protected global::System.Nullable<int> n_iRec_no=null;
        #region rec_no
        [System.Data.Linq.Mapping.Column(Name="[rec_no]", Storage="n_iRec_no")]
        public global::System.Nullable<int> rec_no{
            get{
                return this.n_iRec_no;
            }
            set{
                this.n_iRec_no=value;
            }
        }
        #endregion rec_no
        
        
        protected global::System.Nullable<DateTime> n_dRetrieve_date=null;
        #region retrieve_date
        [System.Data.Linq.Mapping.Column(Name="[retrieve_date]", Storage="n_dRetrieve_date")]
        public global::System.Nullable<DateTime> retrieve_date{
            get{
                return this.n_dRetrieve_date;
            }
            set{
                this.n_dRetrieve_date=value;
            }
        }
        #endregion retrieve_date
        
        
        protected string n_sFallout_reply=global::System.String.Empty;
        #region fallout_reply
        [System.Data.Linq.Mapping.Column(Name="[fallout_reply]", Storage="n_sFallout_reply")]
        public string fallout_reply{
            get{
                return this.n_sFallout_reply;
            }
            set{
                this.n_sFallout_reply=value;
            }
        }
        #endregion fallout_reply
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private MobileOrderReportDetailHistoryInfo n_oTableSet = MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string order_status="order_status";
            public const string fallout_reply="fallout_reply";
            public const string mflag="mflag";
            public const string email_date="email_date";
            public const string retrieve_cnt="retrieve_cnt";
            public const string cdate="cdate";
            public const string retrieve_sn="retrieve_sn";
            public const string cid="cid";
            public const string did="did";
            public const string eid="eid";
            public const string active="active";
            public const string fallout_reason="fallout_reason";
            public const string fallout_remark="fallout_remark";
            public const string fallout_main_category="fallout_main_category";
            public const string report_his_id="report_his_id";
            public const string report_type="report_type";
            public const string reactive_sn="reactive_sn";
            public const string ddate="ddate";
            public const string mdate="mdate";
            public const string reactive_date="reactive_date";
            public const string order_id="order_id";
            public const string rec_no="rec_no";
            public const string retrieve_date="retrieve_date";
            public const string MobileOrderReportDetailHistory_table_name="MobileOrderReportDetailHistory";
            public static string TableName() { return MobileOrderReportDetailHistory_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderReportDetailHistoryEntity(){
            Init();
        }
        public MobileOrderReportDetailHistoryEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderReportDetailHistoryEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iReport_his_id){
            n_oDB=x_oDB;
            this.Load(x_iReport_his_id);
            Init();
        }
        
        ~MobileOrderReportDetailHistoryEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iReport_his_id){
            if (n_oDB==null) { return false; }
            if (x_iReport_his_id==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderReportDetailHistory].[order_status] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS,[MobileOrderReportDetailHistory].[mflag] AS MOBILEORDERREPORTDETAILHISTORY_MFLAG,[MobileOrderReportDetailHistory].[email_date] AS MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE,[MobileOrderReportDetailHistory].[retrieve_cnt] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT,[MobileOrderReportDetailHistory].[cdate] AS MOBILEORDERREPORTDETAILHISTORY_CDATE,[MobileOrderReportDetailHistory].[retrieve_sn] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN,[MobileOrderReportDetailHistory].[cid] AS MOBILEORDERREPORTDETAILHISTORY_CID,[MobileOrderReportDetailHistory].[did] AS MOBILEORDERREPORTDETAILHISTORY_DID,[MobileOrderReportDetailHistory].[eid] AS MOBILEORDERREPORTDETAILHISTORY_EID,[MobileOrderReportDetailHistory].[active] AS MOBILEORDERREPORTDETAILHISTORY_ACTIVE,[MobileOrderReportDetailHistory].[fallout_reason] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON,[MobileOrderReportDetailHistory].[fallout_remark] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK,[MobileOrderReportDetailHistory].[fallout_main_category] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportDetailHistory].[report_his_id] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID,[MobileOrderReportDetailHistory].[report_type] AS MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE,[MobileOrderReportDetailHistory].[reactive_sn] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN,[MobileOrderReportDetailHistory].[ddate] AS MOBILEORDERREPORTDETAILHISTORY_DDATE,[MobileOrderReportDetailHistory].[mdate] AS MOBILEORDERREPORTDETAILHISTORY_MDATE,[MobileOrderReportDetailHistory].[reactive_date] AS MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE,[MobileOrderReportDetailHistory].[order_id] AS MOBILEORDERREPORTDETAILHISTORY_ORDER_ID,[MobileOrderReportDetailHistory].[rec_no] AS MOBILEORDERREPORTDETAILHISTORY_REC_NO,[MobileOrderReportDetailHistory].[retrieve_date] AS MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE,[MobileOrderReportDetailHistory].[fallout_reply] AS MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportDetailHistory]  WHERE  [MobileOrderReportDetailHistory].[report_his_id] = \'"+x_iReport_his_id.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        n_bFound = true;
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"])) {n_sOrder_status = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_STATUS"];}else{n_sOrder_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"])) {n_bMflag = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_MFLAG"];}else{n_bMflag=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"])) {n_dEmail_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_EMAIL_DATE"];}else{n_dEmail_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"])) {n_iRetrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_CNT"];}else{n_iRetrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"])) {n_sRetrieve_sn = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_SN"];}else{n_sRetrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_CID"])) {n_sCid = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DID"])) {n_sDid = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_EID"])) {n_sEid = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_EID"];}else{n_sEid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTDETAILHISTORY_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"])) {n_sFallout_reason = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REASON"];}else{n_sFallout_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"])) {n_sFallout_remark = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REMARK"];}else{n_sFallout_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"])) {n_sFallout_main_category = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_MAIN_CATEGORY"];}else{n_sFallout_main_category=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"])) {n_iReport_his_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_HIS_ID"];}else{n_iReport_his_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"])) {n_sReport_type = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REPORT_TYPE"];}else{n_sReport_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"])) {n_sReactive_sn = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_SN"];}else{n_sReactive_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"])) {n_dMdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_MDATE"];}else{n_dMdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"])) {n_dReactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_REACTIVE_DATE"];}else{n_dReactive_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"])) {n_iRec_no = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTDETAILHISTORY_REC_NO"];}else{n_iRec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"])) {n_dRetrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTDETAILHISTORY_RETRIEVE_DATE"];}else{n_dRetrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"])) {n_sFallout_reply = (string)_oData["MOBILEORDERREPORTDETAILHISTORY_FALLOUT_REPLY"];}else{n_sFallout_reply=global::System.String.Empty;}
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch {  }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return true;
            }
        }
        #endregion
        
        #region Init
        
        /// <summary>
        /// Summary description for Init Class
        /// </summary>
        
        public void Init()
        {
            
        }
        #endregion
        
        #region Vaild
        
        /// <summary>
        /// Summary description for Vaild Checking
        /// </summary>
        
        public bool Vaild(bool x_bInsert)
        {
            if (n_sOrder_status==null && !(n_oTableSet.Fields(Para.order_status).IsNullable)) return false;
            if (n_bMflag==null && !(n_oTableSet.Fields(Para.mflag).IsNullable)) return false;
            if (n_dEmail_date==null && !(n_oTableSet.Fields(Para.email_date).IsNullable)) return false;
            if (n_iRetrieve_cnt==null && !(n_oTableSet.Fields(Para.retrieve_cnt).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sRetrieve_sn==null && !(n_oTableSet.Fields(Para.retrieve_sn).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_sEid==null && !(n_oTableSet.Fields(Para.eid).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sFallout_reason==null && !(n_oTableSet.Fields(Para.fallout_reason).IsNullable)) return false;
            if (n_sFallout_remark==null && !(n_oTableSet.Fields(Para.fallout_remark).IsNullable)) return false;
            if (n_sFallout_main_category==null && !(n_oTableSet.Fields(Para.fallout_main_category).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iReport_his_id==null && !(n_oTableSet.Fields(Para.report_his_id).IsNullable)) return false;
            }
            if (n_sReport_type==null && !(n_oTableSet.Fields(Para.report_type).IsNullable)) return false;
            if (n_sReactive_sn==null && !(n_oTableSet.Fields(Para.reactive_sn).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_dMdate==null && !(n_oTableSet.Fields(Para.mdate).IsNullable)) return false;
            if (n_dReactive_date==null && !(n_oTableSet.Fields(Para.reactive_date).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_iRec_no==null && !(n_oTableSet.Fields(Para.rec_no).IsNullable)) return false;
            if (n_dRetrieve_date==null && !(n_oTableSet.Fields(Para.retrieve_date).IsNullable)) return false;
            if (n_sFallout_reply==null && !(n_oTableSet.Fields(Para.fallout_reply).IsNullable)) return false;
            return true;
        }
        #endregion
        
        #region Get & Set
        
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        
        
        public object GetRepositoryObject(object x_oObj)
        {
            if (x_oObj == null) return null;
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderReportDetailHistoryEntity)) || (x_oObj is MobileOrderReportDetailHistoryEntity)) return MobileOrderReportDetailHistoryRepository.Instance();
            return null;
        }
        
        
        #region GetFound
        public bool GetFound()
        {
            if(!this.n_bFound){ this.n_bFound = Vaild(false); }
            return this.n_bFound;
        }
        #endregion
        
        
        #region SetFound
        public void SetFound(bool value){  n_bFound=value; }
        #endregion SetFound
        
        
        #region GetTbl
        public DataTable GetTbl(){ return n_oTbl; }
        #endregion GetTbl
        
        
        #region SetTbl
        public void SetTbl(DataTable value){  n_oTbl=value; }
        #endregion SetTbl
        
        
        #region GetRow
        public DataRow GetRow(){ return n_oRow; }
        #endregion GetRow
        
        
        #region SetRow
        public void SetRow(DataRow value){  n_oRow=value; }
        #endregion SetRow
        
        
        #region GetDB
        public MSSQLConnect GetDB(){
            return n_oDB;
        }
        #endregion GetDB
        
        #region SetDB
        public void SetDB(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
        }
        #endregion SetDB
        
        
        #region GetTableSet
        public MobileOrderReportDetailHistoryInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderReportDetailHistoryInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetOrder_status(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.order_status)) { return string.Empty; }
            return this.order_status;
        }
        public string GetFallout_reply(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.fallout_reply)) { return string.Empty; }
            return this.fallout_reply;
        }
        public global::System.Nullable<bool> GetMflag(){return this.mflag;}
        public global::System.Nullable<DateTime> GetEmail_date(){return this.email_date;}
        public global::System.Nullable<int> GetRetrieve_cnt(){return this.retrieve_cnt;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetRetrieve_sn(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.retrieve_sn)) { return string.Empty; }
            return this.retrieve_sn;
        }
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public string GetEid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.eid)) { return string.Empty; }
            return this.eid;
        }
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetFallout_reason(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.fallout_reason)) { return string.Empty; }
            return this.fallout_reason;
        }
        public string GetFallout_remark(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.fallout_remark)) { return string.Empty; }
            return this.fallout_remark;
        }
        public string GetFallout_main_category(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.fallout_main_category)) { return string.Empty; }
            return this.fallout_main_category;
        }
        public global::System.Nullable<int> GetReport_his_id(){return this.report_his_id;}
        public string GetReport_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.report_type)) { return string.Empty; }
            return this.report_type;
        }
        public string GetReactive_sn(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.reactive_sn)) { return string.Empty; }
            return this.reactive_sn;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public global::System.Nullable<DateTime> GetMdate(){return this.mdate;}
        public global::System.Nullable<DateTime> GetReactive_date(){return this.reactive_date;}
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public global::System.Nullable<int> GetRec_no(){return this.rec_no;}
        public global::System.Nullable<DateTime> GetRetrieve_date(){return this.retrieve_date;}
        
        public bool SetOrder_status(string value){
            this.order_status=value;
            return true;
        }
        public bool SetFallout_reply(string value){
            this.fallout_reply=value;
            return true;
        }
        public bool SetMflag(global::System.Nullable<bool> value){
            this.mflag=value;
            return true;
        }
        public bool SetEmail_date(global::System.Nullable<DateTime> value){
            this.email_date=value;
            return true;
        }
        public bool SetRetrieve_cnt(global::System.Nullable<int> value){
            this.retrieve_cnt=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetRetrieve_sn(string value){
            this.retrieve_sn=value;
            return true;
        }
        public bool SetCid(string value){
            this.cid=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetEid(string value){
            this.eid=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetFallout_reason(string value){
            this.fallout_reason=value;
            return true;
        }
        public bool SetFallout_remark(string value){
            this.fallout_remark=value;
            return true;
        }
        public bool SetFallout_main_category(string value){
            this.fallout_main_category=value;
            return true;
        }
        public bool SetReport_his_id(global::System.Nullable<int> value){
            this.report_his_id=value;
            return true;
        }
        public bool SetReport_type(string value){
            this.report_type=value;
            return true;
        }
        public bool SetReactive_sn(string value){
            this.reactive_sn=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetMdate(global::System.Nullable<DateTime> value){
            this.mdate=value;
            return true;
        }
        public bool SetReactive_date(global::System.Nullable<DateTime> value){
            this.reactive_date=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetRec_no(global::System.Nullable<int> value){
            this.rec_no=value;
            return true;
        }
        public bool SetRetrieve_date(global::System.Nullable<DateTime> value){
            this.retrieve_date=value;
            return true;
        }
        
        public Field GetOrder_statusTable(){
            return n_oTableSet.Fields(Para.order_status);
        }
        public Field GetFallout_replyTable(){
            return n_oTableSet.Fields(Para.fallout_reply);
        }
        public Field GetMflagTable(){
            return n_oTableSet.Fields(Para.mflag);
        }
        public Field GetEmail_dateTable(){
            return n_oTableSet.Fields(Para.email_date);
        }
        public Field GetRetrieve_cntTable(){
            return n_oTableSet.Fields(Para.retrieve_cnt);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetRetrieve_snTable(){
            return n_oTableSet.Fields(Para.retrieve_sn);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetEidTable(){
            return n_oTableSet.Fields(Para.eid);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetFallout_reasonTable(){
            return n_oTableSet.Fields(Para.fallout_reason);
        }
        public Field GetFallout_remarkTable(){
            return n_oTableSet.Fields(Para.fallout_remark);
        }
        public Field GetFallout_main_categoryTable(){
            return n_oTableSet.Fields(Para.fallout_main_category);
        }
        public Field GetReport_his_idTable(){
            return n_oTableSet.Fields(Para.report_his_id);
        }
        public Field GetReport_typeTable(){
            return n_oTableSet.Fields(Para.report_type);
        }
        public Field GetReactive_snTable(){
            return n_oTableSet.Fields(Para.reactive_sn);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetMdateTable(){
            return n_oTableSet.Fields(Para.mdate);
        }
        public Field GetReactive_dateTable(){
            return n_oTableSet.Fields(Para.reactive_date);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetRec_noTable(){
            return n_oTableSet.Fields(Para.rec_no);
        }
        public Field GetRetrieve_dateTable(){
            return n_oTableSet.Fields(Para.retrieve_date);
        }
        #endregion
        
        #region Addtional Get & Set
        #endregion
        
        #region Add & Del
        #endregion
        
        #region CheckNullable
        
        /// <summary>
        /// Summary description for Nullable Columns
        /// </summary>
        
        public bool CheckNullable(string x_sColumnName)
        {
            if ("".Equals(x_sColumnName)) { return false; }
            return n_oTableSet.Fields(x_sColumnName).IsNullable;
        }
        #endregion
        
        #region Equal
        
        /// <summary>
        /// Summary description for Equal Check
        /// </summary>
        
        public bool EqualID(MobileOrderReportDetailHistory x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iReport_his_id.Equals(x_oObj.report_his_id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderReportDetailHistory x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sOrder_status.Equals(x_oObj.order_status)){ return false; }
            if(!this.n_bMflag.Equals(x_oObj.mflag)){ return false; }
            if(!this.n_dEmail_date.Equals(x_oObj.email_date)){ return false; }
            if(!this.n_iRetrieve_cnt.Equals(x_oObj.retrieve_cnt)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sRetrieve_sn.Equals(x_oObj.retrieve_sn)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_sEid.Equals(x_oObj.eid)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sFallout_reason.Equals(x_oObj.fallout_reason)){ return false; }
            if(!this.n_sFallout_remark.Equals(x_oObj.fallout_remark)){ return false; }
            if(!this.n_sFallout_main_category.Equals(x_oObj.fallout_main_category)){ return false; }
            if(!this.n_iReport_his_id.Equals(x_oObj.report_his_id)){ return false; }
            if(!this.n_sReport_type.Equals(x_oObj.report_type)){ return false; }
            if(!this.n_sReactive_sn.Equals(x_oObj.reactive_sn)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_dMdate.Equals(x_oObj.mdate)){ return false; }
            if(!this.n_dReactive_date.Equals(x_oObj.reactive_date)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_iRec_no.Equals(x_oObj.rec_no)){ return false; }
            if(!this.n_dRetrieve_date.Equals(x_oObj.retrieve_date)){ return false; }
            if(!this.n_sFallout_reply.Equals(x_oObj.fallout_reply)){ return false; }
            return true;
        }
        #endregion
        
        #region Retrieve
        
        /// <summary>
        /// Summary description for Retrieve
        /// </summary>
        
        public bool Retrieve(){
            if (n_oDB==null) { return false; }
            bool _bResult=false;
            if(!n_iReport_his_id.Equals(null)){
                _bResult=this.Load(n_iReport_his_id);
                if(_bResult){ return _bResult;}
            }
            return _bResult;
        }
        
        #endregion
        
        #region Save
        
        /// <summary>
        /// Summary description for Save
        /// </summary>
        
        public bool Save()
        {
            if(n_oDB==null){ return false;}
            if (n_iReport_his_id==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [MobileOrderReportDetailHistory]  SET  [order_status]=@order_status,[mflag]=@mflag,[email_date]=@email_date,[retrieve_cnt]=@retrieve_cnt,[cdate]=@cdate,[retrieve_sn]=@retrieve_sn,[cid]=@cid,[did]=@did,[eid]=@eid,[active]=@active,[fallout_reason]=@fallout_reason,[fallout_remark]=@fallout_remark,[fallout_main_category]=@fallout_main_category,[report_type]=@report_type,[reactive_sn]=@reactive_sn,[ddate]=@ddate,[mdate]=@mdate,[reactive_date]=@reactive_date,[order_id]=@order_id,[rec_no]=@rec_no,[retrieve_date]=@retrieve_date,[fallout_reply]=@fallout_reply  WHERE [MobileOrderReportDetailHistory].[report_his_id]=@report_his_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (n_oDB.bTransaction)
            {
                n_oDB.ISessionCmd.CommandText = _sQuery;
                n_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = n_oDB.ISessionCmd;
                _oConn = n_oDB.ISessionConn;
            }
            else
            {
                _oConn = n_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            bool _bResult=false;
            if(n_sOrder_status==null){  _oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar,50).Value=n_sOrder_status; }
            if(n_bMflag==null){  _oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mflag", global::System.Data.SqlDbType.Bit).Value=n_bMflag; }
            if(n_dEmail_date==null){  _oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=n_dEmail_date; }
            if(n_iRetrieve_cnt==null){  _oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=n_iRetrieve_cnt; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sRetrieve_sn==null){  _oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=n_sRetrieve_sn; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=n_sDid; }
            if(n_sEid==null){  _oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@eid", global::System.Data.SqlDbType.Char,10).Value=n_sEid; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sFallout_reason==null){  _oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text,2147483647).Value=n_sFallout_reason; }
            if(n_sFallout_remark==null){  _oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sFallout_remark; }
            if(n_sFallout_main_category==null){  _oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=n_sFallout_main_category; }
            if(n_iReport_his_id==null){  _oCmd.Parameters.Add("@report_his_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_his_id", global::System.Data.SqlDbType.Int).Value=n_iReport_his_id; }
            if(n_sReport_type==null){  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=n_sReport_type; }
            if(n_sReactive_sn==null){  _oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=n_sReactive_sn; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_dMdate==null){  _oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@mdate", global::System.Data.SqlDbType.DateTime).Value=n_dMdate; }
            if(n_dReactive_date==null){  _oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=n_dReactive_date; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_iRec_no==null){  _oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=n_iRec_no; }
            if(n_dRetrieve_date==null){  _oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=n_dRetrieve_date; }
            if(n_sFallout_reply==null){  _oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text,2147483647).Value=n_sFallout_reply; }
            try
            {
                if (!n_oDB.bTransaction && _oConn.State==ConnectionState.Closed) _oConn.Open();
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                if (!n_oDB.bTransaction)
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }
            return _bResult;
        }
        #endregion
        
        #region Delete
        
        /// <summary>
        /// Summary description for table [MobileOrderReportDetailHistory] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iReport_his_id==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderReportDetailHistory]  WHERE [MobileOrderReportDetailHistory].[report_his_id]=@report_his_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportDetailHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportDetailHistory]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = null;
            global::System.Data.SqlClient.SqlCommand _oCmd = null;
            if (n_oDB.bTransaction)
            {
                n_oDB.ISessionCmd.CommandText = _sQuery;
                n_oDB.ISessionCmd.Parameters.Clear();
                _oCmd = n_oDB.ISessionCmd;
                _oConn = n_oDB.ISessionConn;
            }
            else
            {
                _oConn = n_oDB.GetConnection();
                _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            }
            bool _bResult=false;
            _oCmd.Parameters.Add("@report_his_id", global::System.Data.SqlDbType.Int).Value = n_iReport_his_id;
            _oCmd.CommandType = CommandType.Text;
            try
            {
                if (!n_oDB.bTransaction && _oConn.State == ConnectionState.Closed)  _oConn.Open();
                _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                if (!n_oDB.bTransaction)
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }
            return _bResult;
        }
        #endregion
        
        #region Dispose
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
        #endregion
        
        #region DeepClone
        
        /// <summary>
        /// Summary description for table [MobileOrderReportDetailHistory] Object Base Clone
        /// </summary>
        
        public MobileOrderReportDetailHistory DeepClone()
        {
            MobileOrderReportDetailHistory _oMobileOrderReportDetailHistory_Clone = new MobileOrderReportDetailHistory();
            _oMobileOrderReportDetailHistory_Clone.order_status = this.n_sOrder_status;
            _oMobileOrderReportDetailHistory_Clone.mflag = this.n_bMflag;
            _oMobileOrderReportDetailHistory_Clone.email_date = this.n_dEmail_date;
            _oMobileOrderReportDetailHistory_Clone.retrieve_cnt = this.n_iRetrieve_cnt;
            _oMobileOrderReportDetailHistory_Clone.cdate = this.n_dCdate;
            _oMobileOrderReportDetailHistory_Clone.retrieve_sn = this.n_sRetrieve_sn;
            _oMobileOrderReportDetailHistory_Clone.cid = this.n_sCid;
            _oMobileOrderReportDetailHistory_Clone.did = this.n_sDid;
            _oMobileOrderReportDetailHistory_Clone.eid = this.n_sEid;
            _oMobileOrderReportDetailHistory_Clone.active = this.n_bActive;
            _oMobileOrderReportDetailHistory_Clone.fallout_reason = this.n_sFallout_reason;
            _oMobileOrderReportDetailHistory_Clone.fallout_remark = this.n_sFallout_remark;
            _oMobileOrderReportDetailHistory_Clone.fallout_main_category = this.n_sFallout_main_category;
            _oMobileOrderReportDetailHistory_Clone.report_his_id = this.n_iReport_his_id;
            _oMobileOrderReportDetailHistory_Clone.report_type = this.n_sReport_type;
            _oMobileOrderReportDetailHistory_Clone.reactive_sn = this.n_sReactive_sn;
            _oMobileOrderReportDetailHistory_Clone.ddate = this.n_dDdate;
            _oMobileOrderReportDetailHistory_Clone.mdate = this.n_dMdate;
            _oMobileOrderReportDetailHistory_Clone.reactive_date = this.n_dReactive_date;
            _oMobileOrderReportDetailHistory_Clone.order_id = this.n_iOrder_id;
            _oMobileOrderReportDetailHistory_Clone.rec_no = this.n_iRec_no;
            _oMobileOrderReportDetailHistory_Clone.retrieve_date = this.n_dRetrieve_date;
            _oMobileOrderReportDetailHistory_Clone.fallout_reply = this.n_sFallout_reply;
            _oMobileOrderReportDetailHistory_Clone.SetFound(this.n_bFound);
            _oMobileOrderReportDetailHistory_Clone.SetDB(this.n_oDB);
            _oMobileOrderReportDetailHistory_Clone.SetRow(this.n_oRow);
            _oMobileOrderReportDetailHistory_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderReportDetailHistory_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderReportDetailHistory_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sOrder_status=global::System.String.Empty;
            n_bMflag=null;
            n_dEmail_date=null;
            n_iRetrieve_cnt=null;
            n_dCdate=null;
            n_sRetrieve_sn=global::System.String.Empty;
            n_sCid=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_sEid=global::System.String.Empty;
            n_bActive=null;
            n_sFallout_reason=global::System.String.Empty;
            n_sFallout_remark=global::System.String.Empty;
            n_sFallout_main_category=global::System.String.Empty;
            n_iReport_his_id=null;
            n_sReport_type=global::System.String.Empty;
            n_sReactive_sn=global::System.String.Empty;
            n_dDdate=null;
            n_dMdate=null;
            n_dReactive_date=null;
            n_iOrder_id=null;
            n_iRec_no=null;
            n_dRetrieve_date=null;
            n_sFallout_reply=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderReportDetailHistoryInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


