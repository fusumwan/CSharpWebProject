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
///-- Create date: <Create Date 2011-12-07>
///-- Description:	<Description,Table :[MobileOrderReportHistory],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderReportHistory] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"MobileOrderReportHistory")]
    public class MobileOrderReportHistoryEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sGw_retrieve_sn=global::System.String.Empty;
        #region gw_retrieve_sn
        [System.Data.Linq.Mapping.Column(Name="[gw_retrieve_sn]", Storage="n_sGw_retrieve_sn")]
        public string gw_retrieve_sn{
            get{
                return this.n_sGw_retrieve_sn;
            }
            set{
                this.n_sGw_retrieve_sn=value;
            }
        }
        #endregion gw_retrieve_sn
        
        
        protected global::System.Nullable<int> n_iSent_again=null;
        #region sent_again
        [System.Data.Linq.Mapping.Column(Name="[sent_again]", Storage="n_iSent_again")]
        public global::System.Nullable<int> sent_again{
            get{
                return this.n_iSent_again;
            }
            set{
                this.n_iSent_again=value;
            }
        }
        #endregion sent_again
        
        
        protected global::System.Nullable<int> n_iMid=null;
        #region mid
        [System.Data.Linq.Mapping.Column(Name="[mid]", Storage="n_iMid")]
        public global::System.Nullable<int> mid{
            get{
                return this.n_iMid;
            }
            set{
                this.n_iMid=value;
            }
        }
        #endregion mid
        
        
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
        
        
        protected global::System.Nullable<DateTime> n_dFs_sent_again_retrieve_date=null;
        #region fs_sent_again_retrieve_date
        [System.Data.Linq.Mapping.Column(Name="[fs_sent_again_retrieve_date]", Storage="n_dFs_sent_again_retrieve_date")]
        public global::System.Nullable<DateTime> fs_sent_again_retrieve_date{
            get{
                return this.n_dFs_sent_again_retrieve_date;
            }
            set{
                this.n_dFs_sent_again_retrieve_date=value;
            }
        }
        #endregion fs_sent_again_retrieve_date
        
        
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
        
        
        protected global::System.Nullable<DateTime> n_dSent_again_date=null;
        #region sent_again_date
        [System.Data.Linq.Mapping.Column(Name="[sent_again_date]", Storage="n_dSent_again_date")]
        public global::System.Nullable<DateTime> sent_again_date{
            get{
                return this.n_dSent_again_date;
            }
            set{
                this.n_dSent_again_date=value;
            }
        }
        #endregion sent_again_date
        
        
        protected string n_sIdd_vas=global::System.String.Empty;
        #region idd_vas
        [System.Data.Linq.Mapping.Column(Name="[idd_vas]", Storage="n_sIdd_vas")]
        public string idd_vas{
            get{
                return this.n_sIdd_vas;
            }
            set{
                this.n_sIdd_vas=value;
            }
        }
        #endregion idd_vas
        
        
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
        
        
        protected global::System.Nullable<DateTime> n_dGw_retrieve_date=null;
        #region gw_retrieve_date
        [System.Data.Linq.Mapping.Column(Name="[gw_retrieve_date]", Storage="n_dGw_retrieve_date")]
        public global::System.Nullable<DateTime> gw_retrieve_date{
            get{
                return this.n_dGw_retrieve_date;
            }
            set{
                this.n_dGw_retrieve_date=value;
            }
        }
        #endregion gw_retrieve_date
        
        
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
        
        
        protected string n_sExt_place_tel=global::System.String.Empty;
        #region ext_place_tel
        [System.Data.Linq.Mapping.Column(Name="[ext_place_tel]", Storage="n_sExt_place_tel")]
        public string ext_place_tel{
            get{
                return this.n_sExt_place_tel;
            }
            set{
                this.n_sExt_place_tel=value;
            }
        }
        #endregion ext_place_tel
        
        
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
        
        
        protected global::System.Nullable<DateTime> n_dPy_sent_again_retrieve_date=null;
        #region py_sent_again_retrieve_date
        [System.Data.Linq.Mapping.Column(Name="[py_sent_again_retrieve_date]", Storage="n_dPy_sent_again_retrieve_date")]
        public global::System.Nullable<DateTime> py_sent_again_retrieve_date{
            get{
                return this.n_dPy_sent_again_retrieve_date;
            }
            set{
                this.n_dPy_sent_again_retrieve_date=value;
            }
        }
        #endregion py_sent_again_retrieve_date
        
        
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
        private MobileOrderReportHistoryInfo n_oTableSet = MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string order_status="order_status";
            public const string gw_retrieve_sn="gw_retrieve_sn";
            public const string sent_again="sent_again";
            public const string mid="mid";
            public const string email_date="email_date";
            public const string retrieve_cnt="retrieve_cnt";
            public const string fs_sent_again_retrieve_date="fs_sent_again_retrieve_date";
            public const string cdate="cdate";
            public const string retrieve_sn="retrieve_sn";
            public const string cid="cid";
            public const string did="did";
            public const string sent_again_date="sent_again_date";
            public const string idd_vas="idd_vas";
            public const string active="active";
            public const string fallout_reason="fallout_reason";
            public const string fallout_remark="fallout_remark";
            public const string fallout_main_category="fallout_main_category";
            public const string report_type="report_type";
            public const string fallout_reply="fallout_reply";
            public const string reactive_sn="reactive_sn";
            public const string ddate="ddate";
            public const string ext_place_tel="ext_place_tel";
            public const string reactive_date="reactive_date";
            public const string gw_retrieve_date="gw_retrieve_date";
            public const string rec_no="rec_no";
            public const string order_id="order_id";
            public const string py_sent_again_retrieve_date="py_sent_again_retrieve_date";
            public const string retrieve_date="retrieve_date";
            public const string MobileOrderReportHistory_table_name="MobileOrderReportHistory";
            public static string TableName() { return MobileOrderReportHistory_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public MobileOrderReportHistoryEntity(){
            Init();
        }
        public MobileOrderReportHistoryEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public MobileOrderReportHistoryEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~MobileOrderReportHistoryEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [MobileOrderReportHistory].[order_status] AS MOBILEORDERREPORTHISTORY_ORDER_STATUS,[MobileOrderReportHistory].[gw_retrieve_sn] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN,[MobileOrderReportHistory].[sent_again] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN,[MobileOrderReportHistory].[mid] AS MOBILEORDERREPORTHISTORY_MID,[MobileOrderReportHistory].[email_date] AS MOBILEORDERREPORTHISTORY_EMAIL_DATE,[MobileOrderReportHistory].[retrieve_cnt] AS MOBILEORDERREPORTHISTORY_RETRIEVE_CNT,[MobileOrderReportHistory].[fs_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[cdate] AS MOBILEORDERREPORTHISTORY_CDATE,[MobileOrderReportHistory].[retrieve_sn] AS MOBILEORDERREPORTHISTORY_RETRIEVE_SN,[MobileOrderReportHistory].[cid] AS MOBILEORDERREPORTHISTORY_CID,[MobileOrderReportHistory].[did] AS MOBILEORDERREPORTHISTORY_DID,[MobileOrderReportHistory].[sent_again_date] AS MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE,[MobileOrderReportHistory].[idd_vas] AS MOBILEORDERREPORTHISTORY_IDD_VAS,[MobileOrderReportHistory].[active] AS MOBILEORDERREPORTHISTORY_ACTIVE,[MobileOrderReportHistory].[fallout_reason] AS MOBILEORDERREPORTHISTORY_FALLOUT_REASON,[MobileOrderReportHistory].[fallout_remark] AS MOBILEORDERREPORTHISTORY_FALLOUT_REMARK,[MobileOrderReportHistory].[fallout_main_category] AS MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY,[MobileOrderReportHistory].[gw_retrieve_date] AS MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE,[MobileOrderReportHistory].[report_type] AS MOBILEORDERREPORTHISTORY_REPORT_TYPE,[MobileOrderReportHistory].[reactive_sn] AS MOBILEORDERREPORTHISTORY_REACTIVE_SN,[MobileOrderReportHistory].[ddate] AS MOBILEORDERREPORTHISTORY_DDATE,[MobileOrderReportHistory].[ext_place_tel] AS MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL,[MobileOrderReportHistory].[reactive_date] AS MOBILEORDERREPORTHISTORY_REACTIVE_DATE,[MobileOrderReportHistory].[order_id] AS MOBILEORDERREPORTHISTORY_ORDER_ID,[MobileOrderReportHistory].[rec_no] AS MOBILEORDERREPORTHISTORY_REC_NO,[MobileOrderReportHistory].[retrieve_date] AS MOBILEORDERREPORTHISTORY_RETRIEVE_DATE,[MobileOrderReportHistory].[py_sent_again_retrieve_date] AS MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE,[MobileOrderReportHistory].[fallout_reply] AS MOBILEORDERREPORTHISTORY_FALLOUT_REPLY  FROM  [MobileOrderReportHistory]  WHERE  [MobileOrderReportHistory].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"])) {n_sOrder_status = (string)_oData["MOBILEORDERREPORTHISTORY_ORDER_STATUS"];}else{n_sOrder_status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"])) {n_sGw_retrieve_sn = (string)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_SN"];}else{n_sGw_retrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"])) {n_iSent_again = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN"];}else{n_iSent_again=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_MID"];}else{n_iMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"])) {n_dEmail_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_EMAIL_DATE"];}else{n_dEmail_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"])) {n_iRetrieve_cnt = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_CNT"];}else{n_iRetrieve_cnt=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"])) {n_dFs_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_FS_SENT_AGAIN_RETRIEVE_DATE"];}else{n_dFs_sent_again_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"])) {n_sRetrieve_sn = (string)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_SN"];}else{n_sRetrieve_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_CID"])) {n_sCid = (string)_oData["MOBILEORDERREPORTHISTORY_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DID"])) {n_sDid = (string)_oData["MOBILEORDERREPORTHISTORY_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"])) {n_dSent_again_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_SENT_AGAIN_DATE"];}else{n_dSent_again_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"])) {n_sIdd_vas = (string)_oData["MOBILEORDERREPORTHISTORY_IDD_VAS"];}else{n_sIdd_vas=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["MOBILEORDERREPORTHISTORY_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"])) {n_sFallout_reason = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REASON"];}else{n_sFallout_reason=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"])) {n_sFallout_remark = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REMARK"];}else{n_sFallout_remark=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"])) {n_sFallout_main_category = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_MAIN_CATEGORY"];}else{n_sFallout_main_category=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"])) {n_dGw_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_GW_RETRIEVE_DATE"];}else{n_dGw_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"])) {n_sReport_type = (string)_oData["MOBILEORDERREPORTHISTORY_REPORT_TYPE"];}else{n_sReport_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"])) {n_sReactive_sn = (string)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_SN"];}else{n_sReactive_sn=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"])) {n_sExt_place_tel = (string)_oData["MOBILEORDERREPORTHISTORY_EXT_PLACE_TEL"];}else{n_sExt_place_tel=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"])) {n_dReactive_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_REACTIVE_DATE"];}else{n_dReactive_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"])) {n_iOrder_id = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_ORDER_ID"];}else{n_iOrder_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_REC_NO"])) {n_iRec_no = (global::System.Nullable<int>)_oData["MOBILEORDERREPORTHISTORY_REC_NO"];}else{n_iRec_no=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"])) {n_dRetrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_RETRIEVE_DATE"];}else{n_dRetrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"])) {n_dPy_sent_again_retrieve_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERREPORTHISTORY_PY_SENT_AGAIN_RETRIEVE_DATE"];}else{n_dPy_sent_again_retrieve_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"])) {n_sFallout_reply = (string)_oData["MOBILEORDERREPORTHISTORY_FALLOUT_REPLY"];}else{n_sFallout_reply=global::System.String.Empty;}
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
            if (n_sGw_retrieve_sn==null && !(n_oTableSet.Fields(Para.gw_retrieve_sn).IsNullable)) return false;
            if (n_iSent_again==null && !(n_oTableSet.Fields(Para.sent_again).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_dEmail_date==null && !(n_oTableSet.Fields(Para.email_date).IsNullable)) return false;
            if (n_iRetrieve_cnt==null && !(n_oTableSet.Fields(Para.retrieve_cnt).IsNullable)) return false;
            if (n_dFs_sent_again_retrieve_date==null && !(n_oTableSet.Fields(Para.fs_sent_again_retrieve_date).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sRetrieve_sn==null && !(n_oTableSet.Fields(Para.retrieve_sn).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dSent_again_date==null && !(n_oTableSet.Fields(Para.sent_again_date).IsNullable)) return false;
            if (n_sIdd_vas==null && !(n_oTableSet.Fields(Para.idd_vas).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sFallout_reason==null && !(n_oTableSet.Fields(Para.fallout_reason).IsNullable)) return false;
            if (n_sFallout_remark==null && !(n_oTableSet.Fields(Para.fallout_remark).IsNullable)) return false;
            if (n_sFallout_main_category==null && !(n_oTableSet.Fields(Para.fallout_main_category).IsNullable)) return false;
            if (n_dGw_retrieve_date==null && !(n_oTableSet.Fields(Para.gw_retrieve_date).IsNullable)) return false;
            if (n_sReport_type==null && !(n_oTableSet.Fields(Para.report_type).IsNullable)) return false;
            if (n_sReactive_sn==null && !(n_oTableSet.Fields(Para.reactive_sn).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sExt_place_tel==null && !(n_oTableSet.Fields(Para.ext_place_tel).IsNullable)) return false;
            if (n_dReactive_date==null && !(n_oTableSet.Fields(Para.reactive_date).IsNullable)) return false;
            if (n_iOrder_id==null && !(n_oTableSet.Fields(Para.order_id).IsNullable)) return false;
            if (n_iRec_no==null && !(n_oTableSet.Fields(Para.rec_no).IsNullable)) return false;
            if (n_dRetrieve_date==null && !(n_oTableSet.Fields(Para.retrieve_date).IsNullable)) return false;
            if (n_dPy_sent_again_retrieve_date==null && !(n_oTableSet.Fields(Para.py_sent_again_retrieve_date).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(MobileOrderReportHistoryEntity)) || (x_oObj is MobileOrderReportHistoryEntity)) return MobileOrderReportHistoryRepository.Instance();
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
        public MobileOrderReportHistoryInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(MobileOrderReportHistoryInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetOrder_status(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.order_status)) { return string.Empty; }
            return this.order_status;
        }
        public string GetGw_retrieve_sn(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.gw_retrieve_sn)) { return string.Empty; }
            return this.gw_retrieve_sn;
        }
        public global::System.Nullable<int> GetSent_again(){return this.sent_again;}
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public global::System.Nullable<DateTime> GetEmail_date(){return this.email_date;}
        public global::System.Nullable<int> GetRetrieve_cnt(){return this.retrieve_cnt;}
        public global::System.Nullable<DateTime> GetFs_sent_again_retrieve_date(){return this.fs_sent_again_retrieve_date;}
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
        public global::System.Nullable<DateTime> GetSent_again_date(){return this.sent_again_date;}
        public string GetIdd_vas(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.idd_vas)) { return string.Empty; }
            return this.idd_vas;
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
        public string GetReport_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.report_type)) { return string.Empty; }
            return this.report_type;
        }
        public string GetFallout_reply(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.fallout_reply)) { return string.Empty; }
            return this.fallout_reply;
        }
        public string GetReactive_sn(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.reactive_sn)) { return string.Empty; }
            return this.reactive_sn;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetExt_place_tel(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.ext_place_tel)) { return string.Empty; }
            return this.ext_place_tel;
        }
        public global::System.Nullable<DateTime> GetReactive_date(){return this.reactive_date;}
        public global::System.Nullable<DateTime> GetGw_retrieve_date(){return this.gw_retrieve_date;}
        public global::System.Nullable<int> GetRec_no(){return this.rec_no;}
        public global::System.Nullable<int> GetOrder_id(){return this.order_id;}
        public global::System.Nullable<DateTime> GetPy_sent_again_retrieve_date(){return this.py_sent_again_retrieve_date;}
        public global::System.Nullable<DateTime> GetRetrieve_date(){return this.retrieve_date;}
        
        public bool SetOrder_status(string value){
            this.order_status=value;
            return true;
        }
        public bool SetGw_retrieve_sn(string value){
            this.gw_retrieve_sn=value;
            return true;
        }
        public bool SetSent_again(global::System.Nullable<int> value){
            this.sent_again=value;
            return true;
        }
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
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
        public bool SetFs_sent_again_retrieve_date(global::System.Nullable<DateTime> value){
            this.fs_sent_again_retrieve_date=value;
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
        public bool SetSent_again_date(global::System.Nullable<DateTime> value){
            this.sent_again_date=value;
            return true;
        }
        public bool SetIdd_vas(string value){
            this.idd_vas=value;
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
        public bool SetReport_type(string value){
            this.report_type=value;
            return true;
        }
        public bool SetFallout_reply(string value){
            this.fallout_reply=value;
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
        public bool SetExt_place_tel(string value){
            this.ext_place_tel=value;
            return true;
        }
        public bool SetReactive_date(global::System.Nullable<DateTime> value){
            this.reactive_date=value;
            return true;
        }
        public bool SetGw_retrieve_date(global::System.Nullable<DateTime> value){
            this.gw_retrieve_date=value;
            return true;
        }
        public bool SetRec_no(global::System.Nullable<int> value){
            this.rec_no=value;
            return true;
        }
        public bool SetOrder_id(global::System.Nullable<int> value){
            this.order_id=value;
            return true;
        }
        public bool SetPy_sent_again_retrieve_date(global::System.Nullable<DateTime> value){
            this.py_sent_again_retrieve_date=value;
            return true;
        }
        public bool SetRetrieve_date(global::System.Nullable<DateTime> value){
            this.retrieve_date=value;
            return true;
        }
        
        public Field GetOrder_statusTable(){
            return n_oTableSet.Fields(Para.order_status);
        }
        public Field GetGw_retrieve_snTable(){
            return n_oTableSet.Fields(Para.gw_retrieve_sn);
        }
        public Field GetSent_againTable(){
            return n_oTableSet.Fields(Para.sent_again);
        }
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetEmail_dateTable(){
            return n_oTableSet.Fields(Para.email_date);
        }
        public Field GetRetrieve_cntTable(){
            return n_oTableSet.Fields(Para.retrieve_cnt);
        }
        public Field GetFs_sent_again_retrieve_dateTable(){
            return n_oTableSet.Fields(Para.fs_sent_again_retrieve_date);
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
        public Field GetSent_again_dateTable(){
            return n_oTableSet.Fields(Para.sent_again_date);
        }
        public Field GetIdd_vasTable(){
            return n_oTableSet.Fields(Para.idd_vas);
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
        public Field GetReport_typeTable(){
            return n_oTableSet.Fields(Para.report_type);
        }
        public Field GetFallout_replyTable(){
            return n_oTableSet.Fields(Para.fallout_reply);
        }
        public Field GetReactive_snTable(){
            return n_oTableSet.Fields(Para.reactive_sn);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetExt_place_telTable(){
            return n_oTableSet.Fields(Para.ext_place_tel);
        }
        public Field GetReactive_dateTable(){
            return n_oTableSet.Fields(Para.reactive_date);
        }
        public Field GetGw_retrieve_dateTable(){
            return n_oTableSet.Fields(Para.gw_retrieve_date);
        }
        public Field GetRec_noTable(){
            return n_oTableSet.Fields(Para.rec_no);
        }
        public Field GetOrder_idTable(){
            return n_oTableSet.Fields(Para.order_id);
        }
        public Field GetPy_sent_again_retrieve_dateTable(){
            return n_oTableSet.Fields(Para.py_sent_again_retrieve_date);
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
        
        public bool EqualID(MobileOrderReportHistory x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(MobileOrderReportHistory x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sOrder_status.Equals(x_oObj.order_status)){ return false; }
            if(!this.n_sGw_retrieve_sn.Equals(x_oObj.gw_retrieve_sn)){ return false; }
            if(!this.n_iSent_again.Equals(x_oObj.sent_again)){ return false; }
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
            if(!this.n_dEmail_date.Equals(x_oObj.email_date)){ return false; }
            if(!this.n_iRetrieve_cnt.Equals(x_oObj.retrieve_cnt)){ return false; }
            if(!this.n_dFs_sent_again_retrieve_date.Equals(x_oObj.fs_sent_again_retrieve_date)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sRetrieve_sn.Equals(x_oObj.retrieve_sn)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_dSent_again_date.Equals(x_oObj.sent_again_date)){ return false; }
            if(!this.n_sIdd_vas.Equals(x_oObj.idd_vas)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sFallout_reason.Equals(x_oObj.fallout_reason)){ return false; }
            if(!this.n_sFallout_remark.Equals(x_oObj.fallout_remark)){ return false; }
            if(!this.n_sFallout_main_category.Equals(x_oObj.fallout_main_category)){ return false; }
            if(!this.n_dGw_retrieve_date.Equals(x_oObj.gw_retrieve_date)){ return false; }
            if(!this.n_sReport_type.Equals(x_oObj.report_type)){ return false; }
            if(!this.n_sReactive_sn.Equals(x_oObj.reactive_sn)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sExt_place_tel.Equals(x_oObj.ext_place_tel)){ return false; }
            if(!this.n_dReactive_date.Equals(x_oObj.reactive_date)){ return false; }
            if(!this.n_iOrder_id.Equals(x_oObj.order_id)){ return false; }
            if(!this.n_iRec_no.Equals(x_oObj.rec_no)){ return false; }
            if(!this.n_dRetrieve_date.Equals(x_oObj.retrieve_date)){ return false; }
            if(!this.n_dPy_sent_again_retrieve_date.Equals(x_oObj.py_sent_again_retrieve_date)){ return false; }
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
            if(!n_iMid.Equals(null)){
                _bResult=this.Load(n_iMid);
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
            if (n_iMid==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [MobileOrderReportHistory]  SET  [order_status]=@order_status,[gw_retrieve_sn]=@gw_retrieve_sn,[sent_again]=@sent_again,[email_date]=@email_date,[retrieve_cnt]=@retrieve_cnt,[fs_sent_again_retrieve_date]=@fs_sent_again_retrieve_date,[cdate]=@cdate,[retrieve_sn]=@retrieve_sn,[cid]=@cid,[did]=@did,[sent_again_date]=@sent_again_date,[idd_vas]=@idd_vas,[active]=@active,[fallout_reason]=@fallout_reason,[fallout_remark]=@fallout_remark,[fallout_main_category]=@fallout_main_category,[gw_retrieve_date]=@gw_retrieve_date,[report_type]=@report_type,[reactive_sn]=@reactive_sn,[ddate]=@ddate,[ext_place_tel]=@ext_place_tel,[reactive_date]=@reactive_date,[order_id]=@order_id,[rec_no]=@rec_no,[retrieve_date]=@retrieve_date,[py_sent_again_retrieve_date]=@py_sent_again_retrieve_date,[fallout_reply]=@fallout_reply  WHERE [MobileOrderReportHistory].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
            if(n_sGw_retrieve_sn==null){  _oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@gw_retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=n_sGw_retrieve_sn; }
            if(n_iSent_again==null){  _oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@sent_again", global::System.Data.SqlDbType.Int).Value=n_iSent_again; }
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
            if(n_dEmail_date==null){  _oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@email_date", global::System.Data.SqlDbType.DateTime).Value=n_dEmail_date; }
            if(n_iRetrieve_cnt==null){  _oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retrieve_cnt", global::System.Data.SqlDbType.Int).Value=n_iRetrieve_cnt; }
            if(n_dFs_sent_again_retrieve_date==null){  _oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@fs_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=n_dFs_sent_again_retrieve_date; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sRetrieve_sn==null){  _oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char,10).Value=n_sRetrieve_sn; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=n_sDid; }
            if(n_dSent_again_date==null){  _oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sent_again_date", global::System.Data.SqlDbType.DateTime).Value=n_dSent_again_date; }
            if(n_sIdd_vas==null){  _oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@idd_vas", global::System.Data.SqlDbType.NVarChar,30).Value=n_sIdd_vas; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sFallout_reason==null){  _oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fallout_reason", global::System.Data.SqlDbType.Text,2147483647).Value=n_sFallout_reason; }
            if(n_sFallout_remark==null){  _oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text,2147483647).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fallout_remark", global::System.Data.SqlDbType.Text,2147483647).Value=n_sFallout_remark; }
            if(n_sFallout_main_category==null){  _oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@fallout_main_category", global::System.Data.SqlDbType.NVarChar,250).Value=n_sFallout_main_category; }
            if(n_dGw_retrieve_date==null){  _oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@gw_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=n_dGw_retrieve_date; }
            if(n_sReport_type==null){  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@report_type", global::System.Data.SqlDbType.Char,20).Value=n_sReport_type; }
            if(n_sReactive_sn==null){  _oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@reactive_sn", global::System.Data.SqlDbType.NVarChar,20).Value=n_sReactive_sn; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sExt_place_tel==null){  _oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@ext_place_tel", global::System.Data.SqlDbType.NVarChar,30).Value=n_sExt_place_tel; }
            if(n_dReactive_date==null){  _oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@reactive_date", global::System.Data.SqlDbType.DateTime).Value=n_dReactive_date; }
            if(n_iOrder_id==null){  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=n_iOrder_id; }
            if(n_iRec_no==null){  _oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rec_no", global::System.Data.SqlDbType.Int).Value=n_iRec_no; }
            if(n_dRetrieve_date==null){  _oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value=n_dRetrieve_date; }
            if(n_dPy_sent_again_retrieve_date==null){  _oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@py_sent_again_retrieve_date", global::System.Data.SqlDbType.DateTime).Value=n_dPy_sent_again_retrieve_date; }
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
        /// Summary description for table [MobileOrderReportHistory] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [MobileOrderReportHistory]  WHERE [MobileOrderReportHistory].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderReportHistory]","["+ Configurator.MSSQLTablePrefix + "MobileOrderReportHistory]"); }
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
            _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = n_iMid;
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
        /// Summary description for table [MobileOrderReportHistory] Object Base Clone
        /// </summary>
        
        public MobileOrderReportHistory DeepClone()
        {
            MobileOrderReportHistory _oMobileOrderReportHistory_Clone = new MobileOrderReportHistory();
            _oMobileOrderReportHistory_Clone.order_status = this.n_sOrder_status;
            _oMobileOrderReportHistory_Clone.gw_retrieve_sn = this.n_sGw_retrieve_sn;
            _oMobileOrderReportHistory_Clone.sent_again = this.n_iSent_again;
            _oMobileOrderReportHistory_Clone.mid = this.n_iMid;
            _oMobileOrderReportHistory_Clone.email_date = this.n_dEmail_date;
            _oMobileOrderReportHistory_Clone.retrieve_cnt = this.n_iRetrieve_cnt;
            _oMobileOrderReportHistory_Clone.fs_sent_again_retrieve_date = this.n_dFs_sent_again_retrieve_date;
            _oMobileOrderReportHistory_Clone.cdate = this.n_dCdate;
            _oMobileOrderReportHistory_Clone.retrieve_sn = this.n_sRetrieve_sn;
            _oMobileOrderReportHistory_Clone.cid = this.n_sCid;
            _oMobileOrderReportHistory_Clone.did = this.n_sDid;
            _oMobileOrderReportHistory_Clone.sent_again_date = this.n_dSent_again_date;
            _oMobileOrderReportHistory_Clone.idd_vas = this.n_sIdd_vas;
            _oMobileOrderReportHistory_Clone.active = this.n_bActive;
            _oMobileOrderReportHistory_Clone.fallout_reason = this.n_sFallout_reason;
            _oMobileOrderReportHistory_Clone.fallout_remark = this.n_sFallout_remark;
            _oMobileOrderReportHistory_Clone.fallout_main_category = this.n_sFallout_main_category;
            _oMobileOrderReportHistory_Clone.gw_retrieve_date = this.n_dGw_retrieve_date;
            _oMobileOrderReportHistory_Clone.report_type = this.n_sReport_type;
            _oMobileOrderReportHistory_Clone.reactive_sn = this.n_sReactive_sn;
            _oMobileOrderReportHistory_Clone.ddate = this.n_dDdate;
            _oMobileOrderReportHistory_Clone.ext_place_tel = this.n_sExt_place_tel;
            _oMobileOrderReportHistory_Clone.reactive_date = this.n_dReactive_date;
            _oMobileOrderReportHistory_Clone.order_id = this.n_iOrder_id;
            _oMobileOrderReportHistory_Clone.rec_no = this.n_iRec_no;
            _oMobileOrderReportHistory_Clone.retrieve_date = this.n_dRetrieve_date;
            _oMobileOrderReportHistory_Clone.py_sent_again_retrieve_date = this.n_dPy_sent_again_retrieve_date;
            _oMobileOrderReportHistory_Clone.fallout_reply = this.n_sFallout_reply;
            _oMobileOrderReportHistory_Clone.SetFound(this.n_bFound);
            _oMobileOrderReportHistory_Clone.SetDB(this.n_oDB);
            _oMobileOrderReportHistory_Clone.SetRow(this.n_oRow);
            _oMobileOrderReportHistory_Clone.SetTbl(this.n_oTbl);
            _oMobileOrderReportHistory_Clone.SetTableSet(this.n_oTableSet);
            
            return _oMobileOrderReportHistory_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sOrder_status=global::System.String.Empty;
            n_sGw_retrieve_sn=global::System.String.Empty;
            n_iSent_again=null;
            n_iMid=null;
            n_dEmail_date=null;
            n_iRetrieve_cnt=null;
            n_dFs_sent_again_retrieve_date=null;
            n_dCdate=null;
            n_sRetrieve_sn=global::System.String.Empty;
            n_sCid=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_dSent_again_date=null;
            n_sIdd_vas=global::System.String.Empty;
            n_bActive=null;
            n_sFallout_reason=global::System.String.Empty;
            n_sFallout_remark=global::System.String.Empty;
            n_sFallout_main_category=global::System.String.Empty;
            n_dGw_retrieve_date=null;
            n_sReport_type=global::System.String.Empty;
            n_sReactive_sn=global::System.String.Empty;
            n_dDdate=null;
            n_sExt_place_tel=global::System.String.Empty;
            n_dReactive_date=null;
            n_iOrder_id=null;
            n_iRec_no=null;
            n_dRetrieve_date=null;
            n_dPy_sent_again_retrieve_date=null;
            n_sFallout_reply=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = MobileOrderReportHistoryInfoDLL.CreateInfoInstanceObject();
        }
        #endregion
    }
}


