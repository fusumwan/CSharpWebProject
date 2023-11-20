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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[HandSetOfferedBasket],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [HandSetOfferedBasket] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = Configurator.MSSQLTablePrefix+"HandSetOfferedBasket")]
    public class HandSetOfferedBasketEntity: global::System.IDisposable ,global::NEURON.ENTITY.FRAMEWORK.IEntity<MSSQLConnect>{
        
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
        
        
        protected string n_sR_offer=global::System.String.Empty;
        #region r_offer
        [System.Data.Linq.Mapping.Column(Name="[r_offer]", Storage="n_sR_offer")]
        public string r_offer{
            get{
                return this.n_sR_offer;
            }
            set{
                this.n_sR_offer=value;
            }
        }
        #endregion r_offer
        
        
        protected string n_sExtra_rebate_amount=global::System.String.Empty;
        #region extra_rebate_amount
        [System.Data.Linq.Mapping.Column(Name="[extra_rebate_amount]", Storage="n_sExtra_rebate_amount")]
        public string extra_rebate_amount{
            get{
                return this.n_sExtra_rebate_amount;
            }
            set{
                this.n_sExtra_rebate_amount=value;
            }
        }
        #endregion extra_rebate_amount
        
        
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
        
        
        protected string n_sAmount=global::System.String.Empty;
        #region amount
        [System.Data.Linq.Mapping.Column(Name="[amount]", Storage="n_sAmount")]
        public string amount{
            get{
                return this.n_sAmount;
            }
            set{
                this.n_sAmount=value;
            }
        }
        #endregion amount
        
        
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
        
        
        protected global::System.Nullable<DateTime> n_dSdate=null;
        #region sdate
        [System.Data.Linq.Mapping.Column(Name="[sdate]", Storage="n_dSdate")]
        public global::System.Nullable<DateTime> sdate{
            get{
                return this.n_dSdate;
            }
            set{
                this.n_dSdate=value;
            }
        }
        #endregion sdate
        
        
        protected string n_sPayment=global::System.String.Empty;
        #region payment
        [System.Data.Linq.Mapping.Column(Name="[payment]", Storage="n_sPayment")]
        public string payment{
            get{
                return this.n_sPayment;
            }
            set{
                this.n_sPayment=value;
            }
        }
        #endregion payment
        
        
        protected string n_sRetention_type=global::System.String.Empty;
        #region retention_type
        [System.Data.Linq.Mapping.Column(Name="[retention_type]", Storage="n_sRetention_type")]
        public string retention_type{
            get{
                return this.n_sRetention_type;
            }
            set{
                this.n_sRetention_type=value;
            }
        }
        #endregion retention_type
        
        
        protected global::System.Nullable<DateTime> n_dEdate=null;
        #region edate
        [System.Data.Linq.Mapping.Column(Name="[edate]", Storage="n_dEdate")]
        public global::System.Nullable<DateTime> edate{
            get{
                return this.n_dEdate;
            }
            set{
                this.n_dEdate=value;
            }
        }
        #endregion edate
        
        
        protected string n_sCon_per=global::System.String.Empty;
        #region con_per
        [System.Data.Linq.Mapping.Column(Name="[con_per]", Storage="n_sCon_per")]
        public string con_per{
            get{
                return this.n_sCon_per;
            }
            set{
                this.n_sCon_per=value;
            }
        }
        #endregion con_per
        
        
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
        
        
        protected string n_sNormal_rebate_type=global::System.String.Empty;
        #region normal_rebate_type
        [System.Data.Linq.Mapping.Column(Name="[normal_rebate_type]", Storage="n_sNormal_rebate_type")]
        public string normal_rebate_type{
            get{
                return this.n_sNormal_rebate_type;
            }
            set{
                this.n_sNormal_rebate_type=value;
            }
        }
        #endregion normal_rebate_type
        
        
        protected string n_sPremium=global::System.String.Empty;
        #region premium
        [System.Data.Linq.Mapping.Column(Name="[premium]", Storage="n_sPremium")]
        public string premium{
            get{
                return this.n_sPremium;
            }
            set{
                this.n_sPremium=value;
            }
        }
        #endregion premium
        
        
        protected string n_sExtra_rebate=global::System.String.Empty;
        #region extra_rebate
        [System.Data.Linq.Mapping.Column(Name="[extra_rebate]", Storage="n_sExtra_rebate")]
        public string extra_rebate{
            get{
                return this.n_sExtra_rebate;
            }
            set{
                this.n_sExtra_rebate=value;
            }
        }
        #endregion extra_rebate
        
        
        protected string n_sRebate_gp=global::System.String.Empty;
        #region rebate_gp
        [System.Data.Linq.Mapping.Column(Name="[rebate_gp]", Storage="n_sRebate_gp")]
        public string rebate_gp{
            get{
                return this.n_sRebate_gp;
            }
            set{
                this.n_sRebate_gp=value;
            }
        }
        #endregion rebate_gp
        
        
        protected global::System.Nullable<bool> n_bNormal_rebate=null;
        #region normal_rebate
        [System.Data.Linq.Mapping.Column(Name="[normal_rebate]", Storage="n_bNormal_rebate")]
        public global::System.Nullable<bool> normal_rebate{
            get{
                return this.n_bNormal_rebate;
            }
            set{
                this.n_bNormal_rebate=value;
            }
        }
        #endregion normal_rebate
        
        
        protected string n_sHs_model=global::System.String.Empty;
        #region hs_model
        [System.Data.Linq.Mapping.Column(Name="[hs_model]", Storage="n_sHs_model")]
        public string hs_model{
            get{
                return this.n_sHs_model;
            }
            set{
                this.n_sHs_model=value;
            }
        }
        #endregion hs_model
        
        
        protected global::System.Nullable<int> n_iOffer_type_id=null;
        #region offer_type_id
        [System.Data.Linq.Mapping.Column(Name="[offer_type_id]", Storage="n_iOffer_type_id")]
        public global::System.Nullable<int> offer_type_id{
            get{
                return this.n_iOffer_type_id;
            }
            set{
                this.n_iOffer_type_id=value;
            }
        }
        #endregion offer_type_id
        
        
        private HandSetOfferType n_oHandSetOfferTypeHandSetOfferedBasket=null;
        #region HandSetOfferTypeHandSetOfferedBasket    Primary Key Table
        public HandSetOfferType HandSetOfferTypeHandSetOfferedBasket{
            get{
                if(n_oHandSetOfferTypeHandSetOfferedBasket==null){
                    if (n_iOffer_type_id == null) { 
                        n_oHandSetOfferTypeHandSetOfferedBasket=new HandSetOfferType();
                        return n_oHandSetOfferTypeHandSetOfferedBasket;
                    }
                    n_oHandSetOfferTypeHandSetOfferedBasket = (HandSetOfferType)HandSetOfferTypeRepository.GetObj(this.n_oDB, this.n_iOffer_type_id);
                    if(n_oHandSetOfferTypeHandSetOfferedBasket==null){
                        n_oHandSetOfferTypeHandSetOfferedBasket=new HandSetOfferType(this.n_oDB);
                        n_oHandSetOfferTypeHandSetOfferedBasket.SetId(this.n_iOffer_type_id);
                    }
                }
                else if(n_oHandSetOfferTypeHandSetOfferedBasket.id!=this.n_iOffer_type_id)
                {
                    n_oHandSetOfferTypeHandSetOfferedBasket = (HandSetOfferType)HandSetOfferTypeRepository.GetObj(this.n_oDB, this.n_iOffer_type_id);
                    if (n_oHandSetOfferTypeHandSetOfferedBasket == null)
                    {
                        n_oHandSetOfferTypeHandSetOfferedBasket=new HandSetOfferType(this.n_oDB);
                        n_oHandSetOfferTypeHandSetOfferedBasket.SetId(this.n_iOffer_type_id);
                    }
                }
                return n_oHandSetOfferTypeHandSetOfferedBasket;
            }
            set{
                if (value == null)
                {
                    n_oHandSetOfferTypeHandSetOfferedBasket = new HandSetOfferType(this.n_oDB);
                }
                else
                {
                    this.n_oHandSetOfferTypeHandSetOfferedBasket = value;
                }
                n_oHandSetOfferTypeHandSetOfferedBasket.SetId(this.n_iOffer_type_id);
            }
        }
        
        private global::System.Data.DataSet n_oHandSetOfferTypeHandSetOfferedBasketDataSet = null;
        #region HandSetOfferTypeHandSetOfferedBasketDataSet    Primary Key Table DataSet
        public global::System.Data.DataSet HandSetOfferTypeHandSetOfferedBasketDataSet
        {
            get
            {
                HandSetOfferTypeBal _oHandSetOfferTypeBal = new HandSetOfferTypeBal();
                bool _bGetDataSet = false;
                if (n_oHandSetOfferTypeHandSetOfferedBasketDataSet == null)
                {
                    if (n_iOffer_type_id == null) { 
                        n_oHandSetOfferTypeHandSetOfferedBasketDataSet= HandSetOfferTypeBal.ToEmptyDataSet();
                        return n_oHandSetOfferTypeHandSetOfferedBasketDataSet;
                    }
                    _bGetDataSet = true;
                }
                if(n_oHandSetOfferTypeHandSetOfferedBasketDataSet!=null){
                    if (n_oHandSetOfferTypeHandSetOfferedBasketDataSet.Tables.Contains(HandSetOfferType.Para.TableName())){
                        if (n_oHandSetOfferTypeHandSetOfferedBasketDataSet.Tables[HandSetOfferType.Para.TableName()].Rows.Count == 0){ _bGetDataSet = true; }
                    }
                }
                if (_bGetDataSet){
                    n_oHandSetOfferTypeHandSetOfferedBasketDataSet = HandSetOfferTypeRepository.GetDataSet(n_oDB, "offer_type_id="+n_iOffer_type_id);
                    if (n_oHandSetOfferTypeHandSetOfferedBasketDataSet == null)
                    {
                        n_oHandSetOfferTypeHandSetOfferedBasketDataSet = HandSetOfferTypeBal.ToEmptyDataSet();
                    }
                }
                return n_oHandSetOfferTypeHandSetOfferedBasketDataSet;
            }
            set
            {
                n_oHandSetOfferTypeHandSetOfferedBasketDataSet = value;
            }
        }
        
        #endregion HandSetOfferTypeHandSetOfferedBasketDataSet
        #endregion HandSetOfferTypeHandSetOfferedBasket
        
        
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
        
        
        protected string n_sRebate_amount=global::System.String.Empty;
        #region rebate_amount
        [System.Data.Linq.Mapping.Column(Name="[rebate_amount]", Storage="n_sRebate_amount")]
        public string rebate_amount{
            get{
                return this.n_sRebate_amount;
            }
            set{
                this.n_sRebate_amount=value;
            }
        }
        #endregion rebate_amount
        
        
        protected string n_sPlan_fee=global::System.String.Empty;
        #region plan_fee
        [System.Data.Linq.Mapping.Column(Name="[plan_fee]", Storage="n_sPlan_fee")]
        public string plan_fee{
            get{
                return this.n_sPlan_fee;
            }
            set{
                this.n_sPlan_fee=value;
            }
        }
        #endregion plan_fee
        
        
        protected string n_sItem_code=global::System.String.Empty;
        #region item_code
        [System.Data.Linq.Mapping.Column(Name="[item_code]", Storage="n_sItem_code")]
        public string item_code{
            get{
                return this.n_sItem_code;
            }
            set{
                this.n_sItem_code=value;
            }
        }
        #endregion item_code
        
        
        protected string n_sIssue_type=global::System.String.Empty;
        #region issue_type
        [System.Data.Linq.Mapping.Column(Name="[issue_type]", Storage="n_sIssue_type")]
        public string issue_type{
            get{
                return this.n_sIssue_type;
            }
            set{
                this.n_sIssue_type=value;
            }
        }
        #endregion issue_type
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private DataTable n_oTbl = null;
        private DataRow n_oRow = null;
        private HandSetOfferedBasketInfo n_oTableSet = HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string mid="mid";
            public const string r_offer="r_offer";
            public const string extra_rebate_amount="extra_rebate_amount";
            public const string cdate="cdate";
            public const string amount="amount";
            public const string cid="cid";
            public const string did="did";
            public const string sdate="sdate";
            public const string payment="payment";
            public const string retention_type="retention_type";
            public const string edate="edate";
            public const string con_per="con_per";
            public const string ddate="ddate";
            public const string normal_rebate_type="normal_rebate_type";
            public const string premium="premium";
            public const string extra_rebate="extra_rebate";
            public const string rebate_gp="rebate_gp";
            public const string normal_rebate="normal_rebate";
            public const string hs_model="hs_model";
            public const string offer_type_id="offer_type_id";
            public const string active="active";
            public const string rebate_amount="rebate_amount";
            public const string plan_fee="plan_fee";
            public const string item_code="item_code";
            public const string issue_type="issue_type";
            public const string HandSetOfferedBasket_table_name="HandSetOfferedBasket";
            public static string TableName() { return HandSetOfferedBasket_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public HandSetOfferedBasketEntity(){
            Init();
        }
        public HandSetOfferedBasketEntity(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public HandSetOfferedBasketEntity(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid){
            n_oDB=x_oDB;
            this.Load(x_iMid);
            Init();
        }
        
        ~HandSetOfferedBasketEntity(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iMid){
            if (n_oDB==null) { return false; }
            if (x_iMid==null) { return false; }
            string _sQuery = "SELECT   [HandSetOfferedBasket].[mid] AS HANDSETOFFEREDBASKET_MID,[HandSetOfferedBasket].[r_offer] AS HANDSETOFFEREDBASKET_R_OFFER,[HandSetOfferedBasket].[extra_rebate_amount] AS HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT,[HandSetOfferedBasket].[cdate] AS HANDSETOFFEREDBASKET_CDATE,[HandSetOfferedBasket].[amount] AS HANDSETOFFEREDBASKET_AMOUNT,[HandSetOfferedBasket].[cid] AS HANDSETOFFEREDBASKET_CID,[HandSetOfferedBasket].[did] AS HANDSETOFFEREDBASKET_DID,[HandSetOfferedBasket].[sdate] AS HANDSETOFFEREDBASKET_SDATE,[HandSetOfferedBasket].[payment] AS HANDSETOFFEREDBASKET_PAYMENT,[HandSetOfferedBasket].[retention_type] AS HANDSETOFFEREDBASKET_RETENTION_TYPE,[HandSetOfferedBasket].[edate] AS HANDSETOFFEREDBASKET_EDATE,[HandSetOfferedBasket].[con_per] AS HANDSETOFFEREDBASKET_CON_PER,[HandSetOfferedBasket].[ddate] AS HANDSETOFFEREDBASKET_DDATE,[HandSetOfferedBasket].[normal_rebate_type] AS HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE,[HandSetOfferedBasket].[premium] AS HANDSETOFFEREDBASKET_PREMIUM,[HandSetOfferedBasket].[extra_rebate] AS HANDSETOFFEREDBASKET_EXTRA_REBATE,[HandSetOfferedBasket].[rebate_gp] AS HANDSETOFFEREDBASKET_REBATE_GP,[HandSetOfferedBasket].[normal_rebate] AS HANDSETOFFEREDBASKET_NORMAL_REBATE,[HandSetOfferedBasket].[hs_model] AS HANDSETOFFEREDBASKET_HS_MODEL,[HandSetOfferedBasket].[offer_type_id] AS HANDSETOFFEREDBASKET_OFFER_TYPE_ID,[HandSetOfferedBasket].[active] AS HANDSETOFFEREDBASKET_ACTIVE,[HandSetOfferedBasket].[rebate_amount] AS HANDSETOFFEREDBASKET_REBATE_AMOUNT,[HandSetOfferedBasket].[plan_fee] AS HANDSETOFFEREDBASKET_PLAN_FEE,[HandSetOfferedBasket].[item_code] AS HANDSETOFFEREDBASKET_ITEM_CODE,[HandSetOfferedBasket].[issue_type] AS HANDSETOFFEREDBASKET_ISSUE_TYPE  FROM  [HandSetOfferedBasket]  WHERE  [HandSetOfferedBasket].[mid] = \'"+x_iMid.ToString()+"\'";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_MID"])) {n_iMid = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_MID"];}else{n_iMid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_R_OFFER"])) {n_sR_offer = (string)_oData["HANDSETOFFEREDBASKET_R_OFFER"];}else{n_sR_offer=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"])) {n_sExtra_rebate_amount = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE_AMOUNT"];}else{n_sExtra_rebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_CDATE"];}else{n_dCdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_AMOUNT"])) {n_sAmount = (string)_oData["HANDSETOFFEREDBASKET_AMOUNT"];}else{n_sAmount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CID"])) {n_sCid = (string)_oData["HANDSETOFFEREDBASKET_CID"];}else{n_sCid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DID"])) {n_sDid = (string)_oData["HANDSETOFFEREDBASKET_DID"];}else{n_sDid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_SDATE"])) {n_dSdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_SDATE"];}else{n_dSdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PAYMENT"])) {n_sPayment = (string)_oData["HANDSETOFFEREDBASKET_PAYMENT"];}else{n_sPayment=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"])) {n_sRetention_type = (string)_oData["HANDSETOFFEREDBASKET_RETENTION_TYPE"];}else{n_sRetention_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_EDATE"];}else{n_dEdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_CON_PER"])) {n_sCon_per = (string)_oData["HANDSETOFFEREDBASKET_CON_PER"];}else{n_sCon_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["HANDSETOFFEREDBASKET_DDATE"];}else{n_dDdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"])) {n_sNormal_rebate_type = (string)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE_TYPE"];}else{n_sNormal_rebate_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PREMIUM"])) {n_sPremium = (string)_oData["HANDSETOFFEREDBASKET_PREMIUM"];}else{n_sPremium=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"])) {n_sExtra_rebate = (string)_oData["HANDSETOFFEREDBASKET_EXTRA_REBATE"];}else{n_sExtra_rebate=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_GP"])) {n_sRebate_gp = (string)_oData["HANDSETOFFEREDBASKET_REBATE_GP"];}else{n_sRebate_gp=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"])) {n_bNormal_rebate = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_NORMAL_REBATE"];}else{n_bNormal_rebate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_HS_MODEL"])) {n_sHs_model = (string)_oData["HANDSETOFFEREDBASKET_HS_MODEL"];}else{n_sHs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"])) {n_iOffer_type_id = (global::System.Nullable<int>)_oData["HANDSETOFFEREDBASKET_OFFER_TYPE_ID"];}else{n_iOffer_type_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["HANDSETOFFEREDBASKET_ACTIVE"];}else{n_bActive=null;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"])) {n_sRebate_amount = (string)_oData["HANDSETOFFEREDBASKET_REBATE_AMOUNT"];}else{n_sRebate_amount=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_PLAN_FEE"])) {n_sPlan_fee = (string)_oData["HANDSETOFFEREDBASKET_PLAN_FEE"];}else{n_sPlan_fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ITEM_CODE"])) {n_sItem_code = (string)_oData["HANDSETOFFEREDBASKET_ITEM_CODE"];}else{n_sItem_code=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"])) {n_sIssue_type = (string)_oData["HANDSETOFFEREDBASKET_ISSUE_TYPE"];}else{n_sIssue_type=global::System.String.Empty;}
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
            if(!x_bInsert){
                if (n_iMid==null && !(n_oTableSet.Fields(Para.mid).IsNullable)) return false;
            }
            if (n_sR_offer==null && !(n_oTableSet.Fields(Para.r_offer).IsNullable)) return false;
            if (n_sExtra_rebate_amount==null && !(n_oTableSet.Fields(Para.extra_rebate_amount).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_sAmount==null && !(n_oTableSet.Fields(Para.amount).IsNullable)) return false;
            if (n_sCid==null && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (n_sDid==null && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dSdate==null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            if (n_sPayment==null && !(n_oTableSet.Fields(Para.payment).IsNullable)) return false;
            if (n_sRetention_type==null && !(n_oTableSet.Fields(Para.retention_type).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_sCon_per==null && !(n_oTableSet.Fields(Para.con_per).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (n_sNormal_rebate_type==null && !(n_oTableSet.Fields(Para.normal_rebate_type).IsNullable)) return false;
            if (n_sPremium==null && !(n_oTableSet.Fields(Para.premium).IsNullable)) return false;
            if (n_sExtra_rebate==null && !(n_oTableSet.Fields(Para.extra_rebate).IsNullable)) return false;
            if (n_sRebate_gp==null && !(n_oTableSet.Fields(Para.rebate_gp).IsNullable)) return false;
            if (n_bNormal_rebate==null && !(n_oTableSet.Fields(Para.normal_rebate).IsNullable)) return false;
            if (n_sHs_model==null && !(n_oTableSet.Fields(Para.hs_model).IsNullable)) return false;
            if (n_iOffer_type_id==null && !(n_oTableSet.Fields(Para.offer_type_id).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (n_sRebate_amount==null && !(n_oTableSet.Fields(Para.rebate_amount).IsNullable)) return false;
            if (n_sPlan_fee==null && !(n_oTableSet.Fields(Para.plan_fee).IsNullable)) return false;
            if (n_sItem_code==null && !(n_oTableSet.Fields(Para.item_code).IsNullable)) return false;
            if (n_sIssue_type==null && !(n_oTableSet.Fields(Para.issue_type).IsNullable)) return false;
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
            if (x_oObj.GetType().IsSubclassOf(typeof(HandSetOfferedBasketEntity)) || (x_oObj is HandSetOfferedBasketEntity)) return HandSetOfferedBasketRepository.Instance();
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
        public HandSetOfferedBasketInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(HandSetOfferedBasketInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetMid(){return this.mid;}
        public string GetR_offer(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.r_offer)) { return string.Empty; }
            return this.r_offer;
        }
        public string GetExtra_rebate_amount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extra_rebate_amount)) { return string.Empty; }
            return this.extra_rebate_amount;
        }
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetAmount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.amount)) { return string.Empty; }
            return this.amount;
        }
        public string GetCid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.cid)) { return string.Empty; }
            return this.cid;
        }
        public string GetDid(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.did)) { return string.Empty; }
            return this.did;
        }
        public global::System.Nullable<DateTime> GetSdate(){return this.sdate;}
        public string GetPayment(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.payment)) { return string.Empty; }
            return this.payment;
        }
        public string GetRetention_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.retention_type)) { return string.Empty; }
            return this.retention_type;
        }
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public string GetCon_per(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.con_per)) { return string.Empty; }
            return this.con_per;
        }
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetNormal_rebate_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.normal_rebate_type)) { return string.Empty; }
            return this.normal_rebate_type;
        }
        public string GetPremium(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.premium)) { return string.Empty; }
            return this.premium;
        }
        public string GetExtra_rebate(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.extra_rebate)) { return string.Empty; }
            return this.extra_rebate;
        }
        public string GetRebate_gp(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rebate_gp)) { return string.Empty; }
            return this.rebate_gp;
        }
        public global::System.Nullable<bool> GetNormal_rebate(){return this.normal_rebate;}
        public string GetHs_model(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.hs_model)) { return string.Empty; }
            return this.hs_model;
        }
        public global::System.Nullable<int> GetOffer_type_id(){return this.offer_type_id;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetRebate_amount(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.rebate_amount)) { return string.Empty; }
            return this.rebate_amount;
        }
        public string GetPlan_fee(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.plan_fee)) { return string.Empty; }
            return this.plan_fee;
        }
        public string GetItem_code(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.item_code)) { return string.Empty; }
            return this.item_code;
        }
        public string GetIssue_type(){
            if (this.StrNullToEmpty && string.IsNullOrEmpty( this.issue_type)) { return string.Empty; }
            return this.issue_type;
        }
        
        public bool SetMid(global::System.Nullable<int> value){
            this.mid=value;
            return true;
        }
        public bool SetR_offer(string value){
            this.r_offer=value;
            return true;
        }
        public bool SetExtra_rebate_amount(string value){
            this.extra_rebate_amount=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetAmount(string value){
            this.amount=value;
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
        public bool SetSdate(global::System.Nullable<DateTime> value){
            this.sdate=value;
            return true;
        }
        public bool SetPayment(string value){
            this.payment=value;
            return true;
        }
        public bool SetRetention_type(string value){
            this.retention_type=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetCon_per(string value){
            this.con_per=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetNormal_rebate_type(string value){
            this.normal_rebate_type=value;
            return true;
        }
        public bool SetPremium(string value){
            this.premium=value;
            return true;
        }
        public bool SetExtra_rebate(string value){
            this.extra_rebate=value;
            return true;
        }
        public bool SetRebate_gp(string value){
            this.rebate_gp=value;
            return true;
        }
        public bool SetNormal_rebate(global::System.Nullable<bool> value){
            this.normal_rebate=value;
            return true;
        }
        public bool SetHs_model(string value){
            this.hs_model=value;
            return true;
        }
        public bool SetOffer_type_id(global::System.Nullable<int> value){
            this.offer_type_id=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetRebate_amount(string value){
            this.rebate_amount=value;
            return true;
        }
        public bool SetPlan_fee(string value){
            this.plan_fee=value;
            return true;
        }
        public bool SetItem_code(string value){
            this.item_code=value;
            return true;
        }
        public bool SetIssue_type(string value){
            this.issue_type=value;
            return true;
        }
        
        public Field GetMidTable(){
            return n_oTableSet.Fields(Para.mid);
        }
        public Field GetR_offerTable(){
            return n_oTableSet.Fields(Para.r_offer);
        }
        public Field GetExtra_rebate_amountTable(){
            return n_oTableSet.Fields(Para.extra_rebate_amount);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetAmountTable(){
            return n_oTableSet.Fields(Para.amount);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetSdateTable(){
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetPaymentTable(){
            return n_oTableSet.Fields(Para.payment);
        }
        public Field GetRetention_typeTable(){
            return n_oTableSet.Fields(Para.retention_type);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetCon_perTable(){
            return n_oTableSet.Fields(Para.con_per);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetNormal_rebate_typeTable(){
            return n_oTableSet.Fields(Para.normal_rebate_type);
        }
        public Field GetPremiumTable(){
            return n_oTableSet.Fields(Para.premium);
        }
        public Field GetExtra_rebateTable(){
            return n_oTableSet.Fields(Para.extra_rebate);
        }
        public Field GetRebate_gpTable(){
            return n_oTableSet.Fields(Para.rebate_gp);
        }
        public Field GetNormal_rebateTable(){
            return n_oTableSet.Fields(Para.normal_rebate);
        }
        public Field GetHs_modelTable(){
            return n_oTableSet.Fields(Para.hs_model);
        }
        public Field GetOffer_type_idTable(){
            return n_oTableSet.Fields(Para.offer_type_id);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetRebate_amountTable(){
            return n_oTableSet.Fields(Para.rebate_amount);
        }
        public Field GetPlan_feeTable(){
            return n_oTableSet.Fields(Para.plan_fee);
        }
        public Field GetItem_codeTable(){
            return n_oTableSet.Fields(Para.item_code);
        }
        public Field GetIssue_typeTable(){
            return n_oTableSet.Fields(Para.issue_type);
        }
        #endregion
        
        #region Addtional Get & Set
        public HandSetOfferType GetHandSetOfferTypeHandSetOfferedBasket() {
            return HandSetOfferTypeHandSetOfferedBasket;
        }
        
        public bool SetHandSetOfferTypeHandSetOfferedBasket(HandSetOfferType value) {
            HandSetOfferTypeHandSetOfferedBasket = value;
            return true;
        }
        
        public global::System.Data.DataSet GetHandSetOfferTypeHandSetOfferedBasketDataSet(){
            return HandSetOfferTypeHandSetOfferedBasketDataSet;
        }
        
        public bool SetHandSetOfferTypeHandSetOfferedBasketDataSet(global::System.Data.DataSet value) {
            HandSetOfferTypeHandSetOfferedBasketDataSet = value;
            return true;
        }
        
        
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
        
        public bool EqualID(HandSetOfferedBasket x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iMid.Equals(x_oObj.mid)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(HandSetOfferedBasket x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iMid.Equals(x_oObj.mid)){ return false; }
            if(!this.n_sR_offer.Equals(x_oObj.r_offer)){ return false; }
            if(!this.n_sExtra_rebate_amount.Equals(x_oObj.extra_rebate_amount)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_sAmount.Equals(x_oObj.amount)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_dSdate.Equals(x_oObj.sdate)){ return false; }
            if(!this.n_sPayment.Equals(x_oObj.payment)){ return false; }
            if(!this.n_sRetention_type.Equals(x_oObj.retention_type)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_sCon_per.Equals(x_oObj.con_per)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sNormal_rebate_type.Equals(x_oObj.normal_rebate_type)){ return false; }
            if(!this.n_sPremium.Equals(x_oObj.premium)){ return false; }
            if(!this.n_sExtra_rebate.Equals(x_oObj.extra_rebate)){ return false; }
            if(!this.n_sRebate_gp.Equals(x_oObj.rebate_gp)){ return false; }
            if(!this.n_bNormal_rebate.Equals(x_oObj.normal_rebate)){ return false; }
            if(!this.n_sHs_model.Equals(x_oObj.hs_model)){ return false; }
            if(!this.n_iOffer_type_id.Equals(x_oObj.offer_type_id)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sRebate_amount.Equals(x_oObj.rebate_amount)){ return false; }
            if(!this.n_sPlan_fee.Equals(x_oObj.plan_fee)){ return false; }
            if(!this.n_sItem_code.Equals(x_oObj.item_code)){ return false; }
            if(!this.n_sIssue_type.Equals(x_oObj.issue_type)){ return false; }
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
            string _sQuery = "UPDATE  [HandSetOfferedBasket]  SET  [r_offer]=@r_offer,[extra_rebate_amount]=@extra_rebate_amount,[cdate]=@cdate,[amount]=@amount,[cid]=@cid,[did]=@did,[sdate]=@sdate,[payment]=@payment,[retention_type]=@retention_type,[edate]=@edate,[con_per]=@con_per,[ddate]=@ddate,[normal_rebate_type]=@normal_rebate_type,[premium]=@premium,[extra_rebate]=@extra_rebate,[rebate_gp]=@rebate_gp,[normal_rebate]=@normal_rebate,[hs_model]=@hs_model,[offer_type_id]=@offer_type_id,[active]=@active,[rebate_amount]=@rebate_amount,[plan_fee]=@plan_fee,[item_code]=@item_code,[issue_type]=@issue_type  WHERE [HandSetOfferedBasket].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
            if(n_iMid==null){  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value=n_iMid; }
            if(n_sR_offer==null){  _oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@r_offer", global::System.Data.SqlDbType.NVarChar,50).Value=n_sR_offer; }
            if(n_sExtra_rebate_amount==null){  _oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extra_rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=n_sExtra_rebate_amount; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_sAmount==null){  _oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@amount", global::System.Data.SqlDbType.NVarChar,10).Value=n_sAmount; }
            if(n_sCid==null){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char,10).Value=n_sCid; }
            if(n_sDid==null){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.Char,10).Value=n_sDid; }
            if(n_dSdate==null){  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=n_dSdate; }
            if(n_sPayment==null){  _oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@payment", global::System.Data.SqlDbType.NVarChar,20).Value=n_sPayment; }
            if(n_sRetention_type==null){  _oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@retention_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRetention_type; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_sCon_per==null){  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCon_per; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(n_sNormal_rebate_type==null){  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate_type", global::System.Data.SqlDbType.NVarChar,100).Value=n_sNormal_rebate_type; }
            if(n_sPremium==null){  _oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@premium", global::System.Data.SqlDbType.NVarChar,100).Value=n_sPremium; }
            if(n_sExtra_rebate==null){  _oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@extra_rebate", global::System.Data.SqlDbType.NVarChar,10).Value=n_sExtra_rebate; }
            if(n_sRebate_gp==null){  _oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rebate_gp", global::System.Data.SqlDbType.NVarChar,20).Value=n_sRebate_gp; }
            if(n_bNormal_rebate==null){  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@normal_rebate", global::System.Data.SqlDbType.Bit).Value=n_bNormal_rebate; }
            if(n_sHs_model==null){  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,100).Value=n_sHs_model; }
            if(n_iOffer_type_id==null){  _oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@offer_type_id", global::System.Data.SqlDbType.Int).Value=n_iOffer_type_id; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(n_sRebate_amount==null){  _oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@rebate_amount", global::System.Data.SqlDbType.NVarChar,50).Value=n_sRebate_amount; }
            if(n_sPlan_fee==null){  _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@plan_fee", global::System.Data.SqlDbType.NVarChar,10).Value=n_sPlan_fee; }
            if(n_sItem_code==null){  _oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@item_code", global::System.Data.SqlDbType.NVarChar,10).Value=n_sItem_code; }
            if(n_sIssue_type==null){  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  _oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=n_sIssue_type; }
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
        /// Summary description for table [HandSetOfferedBasket] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iMid==null) { return false; }
            string _sQuery="DELETE FROM  [HandSetOfferedBasket]  WHERE [HandSetOfferedBasket].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
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
        /// Summary description for table [HandSetOfferedBasket] Object Base Clone
        /// </summary>
        
        public HandSetOfferedBasket DeepClone()
        {
            HandSetOfferedBasket _oHandSetOfferedBasket_Clone = new HandSetOfferedBasket();
            _oHandSetOfferedBasket_Clone.mid = this.n_iMid;
            _oHandSetOfferedBasket_Clone.r_offer = this.n_sR_offer;
            _oHandSetOfferedBasket_Clone.extra_rebate_amount = this.n_sExtra_rebate_amount;
            _oHandSetOfferedBasket_Clone.cdate = this.n_dCdate;
            _oHandSetOfferedBasket_Clone.amount = this.n_sAmount;
            _oHandSetOfferedBasket_Clone.cid = this.n_sCid;
            _oHandSetOfferedBasket_Clone.did = this.n_sDid;
            _oHandSetOfferedBasket_Clone.sdate = this.n_dSdate;
            _oHandSetOfferedBasket_Clone.payment = this.n_sPayment;
            _oHandSetOfferedBasket_Clone.retention_type = this.n_sRetention_type;
            _oHandSetOfferedBasket_Clone.edate = this.n_dEdate;
            _oHandSetOfferedBasket_Clone.con_per = this.n_sCon_per;
            _oHandSetOfferedBasket_Clone.ddate = this.n_dDdate;
            _oHandSetOfferedBasket_Clone.normal_rebate_type = this.n_sNormal_rebate_type;
            _oHandSetOfferedBasket_Clone.premium = this.n_sPremium;
            _oHandSetOfferedBasket_Clone.extra_rebate = this.n_sExtra_rebate;
            _oHandSetOfferedBasket_Clone.rebate_gp = this.n_sRebate_gp;
            _oHandSetOfferedBasket_Clone.normal_rebate = this.n_bNormal_rebate;
            _oHandSetOfferedBasket_Clone.hs_model = this.n_sHs_model;
            _oHandSetOfferedBasket_Clone.offer_type_id = this.n_iOffer_type_id;
            _oHandSetOfferedBasket_Clone.active = this.n_bActive;
            _oHandSetOfferedBasket_Clone.rebate_amount = this.n_sRebate_amount;
            _oHandSetOfferedBasket_Clone.plan_fee = this.n_sPlan_fee;
            _oHandSetOfferedBasket_Clone.item_code = this.n_sItem_code;
            _oHandSetOfferedBasket_Clone.issue_type = this.n_sIssue_type;
            _oHandSetOfferedBasket_Clone.SetFound(this.n_bFound);
            _oHandSetOfferedBasket_Clone.SetDB(this.n_oDB);
            _oHandSetOfferedBasket_Clone.SetRow(this.n_oRow);
            _oHandSetOfferedBasket_Clone.SetTbl(this.n_oTbl);
            _oHandSetOfferedBasket_Clone.SetTableSet(this.n_oTableSet);
            HandSetOfferTypeHandSetOfferedBasket=null;
            _oHandSetOfferedBasket_Clone.HandSetOfferTypeHandSetOfferedBasket = this.HandSetOfferTypeHandSetOfferedBasket.DeepClone();
            
            return _oHandSetOfferedBasket_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_iMid=null;
            n_sR_offer=global::System.String.Empty;
            n_sExtra_rebate_amount=global::System.String.Empty;
            n_dCdate=null;
            n_sAmount=global::System.String.Empty;
            n_sCid=global::System.String.Empty;
            n_sDid=global::System.String.Empty;
            n_dSdate=null;
            n_sPayment=global::System.String.Empty;
            n_sRetention_type=global::System.String.Empty;
            n_dEdate=null;
            n_sCon_per=global::System.String.Empty;
            n_dDdate=null;
            n_sNormal_rebate_type=global::System.String.Empty;
            n_sPremium=global::System.String.Empty;
            n_sExtra_rebate=global::System.String.Empty;
            n_sRebate_gp=global::System.String.Empty;
            n_bNormal_rebate=null;
            n_sHs_model=global::System.String.Empty;
            n_iOffer_type_id=null;
            n_bActive=null;
            n_sRebate_amount=global::System.String.Empty;
            n_sPlan_fee=global::System.String.Empty;
            n_sItem_code=global::System.String.Empty;
            n_sIssue_type=global::System.String.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = HandSetOfferedBasketInfoDLL.CreateInfoInstanceObject();
            n_oHandSetOfferTypeHandSetOfferedBasket=null;
        }
        #endregion
    }
}


