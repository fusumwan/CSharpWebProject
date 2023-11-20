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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-24>
///-- Description:	<Description,Table :[CSSDB].[csc].[staffinfo_new],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [CSSDB].[csc].[staffinfo_new] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = "staffinfo_new")]
    public class Staffinfo_newBase{
        
        
        protected global::System.Nullable<int> n_iBasic=null;
        #region basic
        [System.Data.Linq.Mapping.Column(Name="[basic]", Storage="n_iBasic")]
        public global::System.Nullable<int> basic{
            get{
                return this.n_iBasic;
            }
            set{
                this.n_iBasic=value;
            }
        }
        #endregion basic
        
        
        protected string n_sCid=string.Empty;
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
        
        
        protected string n_sSteptype=string.Empty;
        #region steptype
        [System.Data.Linq.Mapping.Column(Name="[steptype]", Storage="n_sSteptype")]
        public string steptype{
            get{
                return this.n_sSteptype;
            }
            set{
                this.n_sSteptype=value;
            }
        }
        #endregion steptype
        
        
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
        
        
        protected global::System.Nullable<bool> n_bFreeze=null;
        #region freeze
        [System.Data.Linq.Mapping.Column(Name="[freeze]", Storage="n_bFreeze")]
        public global::System.Nullable<bool> freeze{
            get{
                return this.n_bFreeze;
            }
            set{
                this.n_bFreeze=value;
            }
        }
        #endregion freeze
        
        
        protected global::System.Nullable<DateTime> n_dLwdate=null;
        #region lwdate
        [System.Data.Linq.Mapping.Column(Name="[lwdate]", Storage="n_dLwdate")]
        public global::System.Nullable<DateTime> lwdate{
            get{
                return this.n_dLwdate;
            }
            set{
                this.n_dLwdate=value;
            }
        }
        #endregion lwdate
        
        
        protected string n_sCmrid=string.Empty;
        #region cmrid
        [System.Data.Linq.Mapping.Column(Name="[cmrid]", Storage="n_sCmrid")]
        public string cmrid{
            get{
                return this.n_sCmrid;
            }
            set{
                this.n_sCmrid=value;
            }
        }
        #endregion cmrid
        
        
        protected string n_sDid=string.Empty;
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
        
        
        protected global::System.Nullable<DateTime> n_dContract_s=null;
        #region contract_s
        [System.Data.Linq.Mapping.Column(Name="[contract_s]", Storage="n_dContract_s")]
        public global::System.Nullable<DateTime> contract_s{
            get{
                return this.n_dContract_s;
            }
            set{
                this.n_dContract_s=value;
            }
        }
        #endregion contract_s
        
        
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
        
        
        protected string n_sSalesman_code=string.Empty;
        #region salesman_code
        [System.Data.Linq.Mapping.Column(Name="[salesman_code]", Storage="n_sSalesman_code")]
        public string salesman_code{
            get{
                return this.n_sSalesman_code;
            }
            set{
                this.n_sSalesman_code=value;
            }
        }
        #endregion salesman_code
        
        
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
        
        
        protected string n_sStream=string.Empty;
        #region stream
        [System.Data.Linq.Mapping.Column(Name="[stream]", Storage="n_sStream")]
        public string stream{
            get{
                return this.n_sStream;
            }
            set{
                this.n_sStream=value;
            }
        }
        #endregion stream
        
        
        protected global::System.Nullable<DateTime> n_dJoindate=null;
        #region joindate
        [System.Data.Linq.Mapping.Column(Name="[joindate]", Storage="n_dJoindate")]
        public global::System.Nullable<DateTime> joindate{
            get{
                return this.n_dJoindate;
            }
            set{
                this.n_dJoindate=value;
            }
        }
        #endregion joindate
        
        
        protected string n_sShift=string.Empty;
        #region shift
        [System.Data.Linq.Mapping.Column(Name="[shift]", Storage="n_sShift")]
        public string shift{
            get{
                return this.n_sShift;
            }
            set{
                this.n_sShift=value;
            }
        }
        #endregion shift
        
        
        protected string n_sStaff_no=string.Empty;
        #region staff_no
        [System.Data.Linq.Mapping.Column(Name="[staff_no]", Storage="n_sStaff_no")]
        public string staff_no{
            get{
                return this.n_sStaff_no;
            }
            set{
                this.n_sStaff_no=value;
            }
        }
        #endregion staff_no
        
        
        protected global::System.Nullable<bool> n_bInternship=null;
        #region internship
        [System.Data.Linq.Mapping.Column(Name="[internship]", Storage="n_bInternship")]
        public global::System.Nullable<bool> internship{
            get{
                return this.n_bInternship;
            }
            set{
                this.n_bInternship=value;
            }
        }
        #endregion internship
        
        
        protected string n_sCentre=string.Empty;
        #region centre
        [System.Data.Linq.Mapping.Column(Name="[centre]", Storage="n_sCentre")]
        public string centre{
            get{
                return this.n_sCentre;
            }
            set{
                this.n_sCentre=value;
            }
        }
        #endregion centre
        
        
        protected string n_sPay_code=string.Empty;
        #region pay_code
        [System.Data.Linq.Mapping.Column(Name="[pay_code]", Storage="n_sPay_code")]
        public string pay_code{
            get{
                return this.n_sPay_code;
            }
            set{
                this.n_sPay_code=value;
            }
        }
        #endregion pay_code
        
        
        protected string n_sStaff_no2=string.Empty;
        #region staff_no2
        [System.Data.Linq.Mapping.Column(Name="[staff_no2]", Storage="n_sStaff_no2")]
        public string staff_no2{
            get{
                return this.n_sStaff_no2;
            }
            set{
                this.n_sStaff_no2=value;
            }
        }
        #endregion staff_no2
        
        
        protected global::System.Nullable<int> n_iId=null;
        #region id
        [System.Data.Linq.Mapping.Column(Name="[id]", Storage="n_iId")]
        public global::System.Nullable<int> id{
            get{
                return this.n_iId;
            }
            set{
                this.n_iId=value;
            }
        }
        #endregion id
        
        
        protected string n_sTeamcode=string.Empty;
        #region teamcode
        [System.Data.Linq.Mapping.Column(Name="[teamcode]", Storage="n_sTeamcode")]
        public string teamcode{
            get{
                return this.n_sTeamcode;
            }
            set{
                this.n_sTeamcode=value;
            }
        }
        #endregion teamcode
        
        
        protected string n_sLanguage=string.Empty;
        #region Language
        [System.Data.Linq.Mapping.Column(Name="[Language]", Storage="n_sLanguage")]
        public string Language{
            get{
                return this.n_sLanguage;
            }
            set{
                this.n_sLanguage=value;
            }
        }
        #endregion Language
        
        
        protected string n_sStaff_type=string.Empty;
        #region staff_type
        [System.Data.Linq.Mapping.Column(Name="[staff_type]", Storage="n_sStaff_type")]
        public string staff_type{
            get{
                return this.n_sStaff_type;
            }
            set{
                this.n_sStaff_type=value;
            }
        }
        #endregion staff_type
        
        
        protected string n_sStaff_name=string.Empty;
        #region staff_name
        [System.Data.Linq.Mapping.Column(Name="[staff_name]", Storage="n_sStaff_name")]
        public string staff_name{
            get{
                return this.n_sStaff_name;
            }
            set{
                this.n_sStaff_name=value;
            }
        }
        #endregion staff_name
        
        
        protected global::System.Nullable<int> n_iOtc=null;
        #region otc
        [System.Data.Linq.Mapping.Column(Name="[otc]", Storage="n_iOtc")]
        public global::System.Nullable<int> otc{
            get{
                return this.n_iOtc;
            }
            set{
                this.n_iOtc=value;
            }
        }
        #endregion otc
        
        
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
        
        
        protected global::System.Nullable<DateTime> n_dContract_e=null;
        #region contract_e
        [System.Data.Linq.Mapping.Column(Name="[contract_e]", Storage="n_dContract_e")]
        public global::System.Nullable<DateTime> contract_e{
            get{
                return this.n_dContract_e;
            }
            set{
                this.n_dContract_e=value;
            }
        }
        #endregion contract_e
        
        
        protected string n_sSkill=string.Empty;
        #region skill
        [System.Data.Linq.Mapping.Column(Name="[skill]", Storage="n_sSkill")]
        public string skill{
            get{
                return this.n_sSkill;
            }
            set{
                this.n_sSkill=value;
            }
        }
        #endregion skill
        
        
        protected string n_sSteplevel=string.Empty;
        #region steplevel
        [System.Data.Linq.Mapping.Column(Name="[steplevel]", Storage="n_sSteplevel")]
        public string steplevel{
            get{
                return this.n_sSteplevel;
            }
            set{
                this.n_sSteplevel=value;
            }
        }
        #endregion steplevel
        
        
        protected string n_sCcc=string.Empty;
        #region ccc
        [System.Data.Linq.Mapping.Column(Name="[ccc]", Storage="n_sCcc")]
        public string ccc{
            get{
                return this.n_sCcc;
            }
            set{
                this.n_sCcc=value;
            }
        }
        #endregion ccc
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private Staffinfo_newInfo n_oTableSet = new Staffinfo_newInfo();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string basic="basic";
            public const string edate="edate";
            public const string steptype="steptype";
            public const string cdate="cdate";
            public const string cmrid="cmrid";
            public const string did="did";
            public const string contract_s="contract_s";
            public const string sdate="sdate";
            public const string active="active";
            public const string salesman_code="salesman_code";
            public const string stream="stream";
            public const string joindate="joindate";
            public const string shift="shift";
            public const string staff_no="staff_no";
            public const string internship="internship";
            public const string lwdate="lwdate";
            public const string ddate="ddate";
            public const string staff_no2="staff_no2";
            public const string id="id";
            public const string teamcode="teamcode";
            public const string centre="centre";
            public const string Language="Language";
            public const string cid="cid";
            public const string staff_name="staff_name";
            public const string otc="otc";
            public const string skill="skill";
            public const string freeze="freeze";
            public const string contract_e="contract_e";
            public const string staff_type="staff_type";
            public const string steplevel="steplevel";
            public const string ccc="ccc";
            public const string pay_code="pay_code";
            public const string Staffinfo_new_table_name = Configurator.MSSQLTablePrefix + "staffinfo_new";
            public static string TableName() { return Staffinfo_new_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public Staffinfo_newBase(){
            Init();
        }
        public Staffinfo_newBase(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public Staffinfo_newBase(MSSQLConnect x_oDB,System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        public Staffinfo_newBase(MSSQLConnect x_oDB,string x_sStaff_no2,string x_sStaff_no){
            n_oDB=x_oDB;
            this.Load(x_sStaff_no2,x_sStaff_no);
            Init();
        }
        
        ~Staffinfo_newBase(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT [CSSDB].[csc].[staffinfo_new].[basic] AS STAFFINFO_NEW_BASIC,[CSSDB].[csc].[staffinfo_new].[cid] AS STAFFINFO_NEW_CID,[CSSDB].[csc].[staffinfo_new].[steptype] AS STAFFINFO_NEW_STEPTYPE,[CSSDB].[csc].[staffinfo_new].[cdate] AS STAFFINFO_NEW_CDATE,[CSSDB].[csc].[staffinfo_new].[freeze] AS STAFFINFO_NEW_FREEZE,[CSSDB].[csc].[staffinfo_new].[lwdate] AS STAFFINFO_NEW_LWDATE,[CSSDB].[csc].[staffinfo_new].[cmrid] AS STAFFINFO_NEW_CMRID,[CSSDB].[csc].[staffinfo_new].[did] AS STAFFINFO_NEW_DID,[CSSDB].[csc].[staffinfo_new].[contract_s] AS STAFFINFO_NEW_CONTRACT_S,[CSSDB].[csc].[staffinfo_new].[sdate] AS STAFFINFO_NEW_SDATE,[CSSDB].[csc].[staffinfo_new].[active] AS STAFFINFO_NEW_ACTIVE,[CSSDB].[csc].[staffinfo_new].[salesman_code] AS STAFFINFO_NEW_SALESMAN_CODE,[CSSDB].[csc].[staffinfo_new].[ddate] AS STAFFINFO_NEW_DDATE,[CSSDB].[csc].[staffinfo_new].[stream] AS STAFFINFO_NEW_STREAM,[CSSDB].[csc].[staffinfo_new].[joindate] AS STAFFINFO_NEW_JOINDATE,[CSSDB].[csc].[staffinfo_new].[shift] AS STAFFINFO_NEW_SHIFT,[CSSDB].[csc].[staffinfo_new].[staff_no] AS STAFFINFO_NEW_STAFF_NO,[CSSDB].[csc].[staffinfo_new].[internship] AS STAFFINFO_NEW_INTERNSHIP,[CSSDB].[csc].[staffinfo_new].[centre] AS STAFFINFO_NEW_CENTRE,[CSSDB].[csc].[staffinfo_new].[pay_code] AS STAFFINFO_NEW_PAY_CODE,[CSSDB].[csc].[staffinfo_new].[staff_no2] AS STAFFINFO_NEW_STAFF_NO2,[CSSDB].[csc].[staffinfo_new].[id] AS STAFFINFO_NEW_ID,[CSSDB].[csc].[staffinfo_new].[teamcode] AS STAFFINFO_NEW_TEAMCODE,[CSSDB].[csc].[staffinfo_new].[Language] AS STAFFINFO_NEW_LANGUAGE,[CSSDB].[csc].[staffinfo_new].[staff_type] AS STAFFINFO_NEW_STAFF_TYPE,[CSSDB].[csc].[staffinfo_new].[staff_name] AS STAFFINFO_NEW_STAFF_NAME,[CSSDB].[csc].[staffinfo_new].[otc] AS STAFFINFO_NEW_OTC,[CSSDB].[csc].[staffinfo_new].[edate] AS STAFFINFO_NEW_EDATE,[CSSDB].[csc].[staffinfo_new].[contract_e] AS STAFFINFO_NEW_CONTRACT_E,[CSSDB].[csc].[staffinfo_new].[skill] AS STAFFINFO_NEW_SKILL,[CSSDB].[csc].[staffinfo_new].[steplevel] AS STAFFINFO_NEW_STEPLEVEL,[CSSDB].[csc].[staffinfo_new].[ccc] AS STAFFINFO_NEW_CCC  FROM  [CSSDB].[csc].[staffinfo_new]  WHERE  [CSSDB].[csc].[staffinfo_new].[id] = \'"+x_iId.ToString()+"\'";
            
            global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            global::System.Data.SqlClient.SqlDataReader _oData;
            try
            {
                _oConn.Open();
                _oData = _oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    n_bFound = true;
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_BASIC"])) {n_iBasic = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_BASIC"];}else{n_iBasic=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CID"])) {n_sCid = (string)_oData["STAFFINFO_NEW_CID"];}else{n_sCid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPTYPE"])) {n_sSteptype = (string)_oData["STAFFINFO_NEW_STEPTYPE"];}else{n_sSteptype=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CDATE"])) {n_dCdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CDATE"];}else{n_dCdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_FREEZE"])) {n_bFreeze = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_FREEZE"];}else{n_bFreeze=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LWDATE"])) {n_dLwdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_LWDATE"];}else{n_dLwdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CMRID"])) {n_sCmrid = (string)_oData["STAFFINFO_NEW_CMRID"];}else{n_sCmrid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DID"])) {n_sDid = (string)_oData["STAFFINFO_NEW_DID"];}else{n_sDid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_S"])) {n_dContract_s = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_S"];}else{n_dContract_s=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SDATE"])) {n_dSdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_SDATE"];}else{n_dSdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_ACTIVE"];}else{n_bActive=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SALESMAN_CODE"])) {n_sSalesman_code = (string)_oData["STAFFINFO_NEW_SALESMAN_CODE"];}else{n_sSalesman_code=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DDATE"])) {n_dDdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_DDATE"];}else{n_dDdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STREAM"])) {n_sStream = (string)_oData["STAFFINFO_NEW_STREAM"];}else{n_sStream=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_JOINDATE"])) {n_dJoindate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_JOINDATE"];}else{n_dJoindate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SHIFT"])) {n_sShift = (string)_oData["STAFFINFO_NEW_SHIFT"];}else{n_sShift=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NO"])) {n_sStaff_no = (string)_oData["STAFFINFO_NEW_STAFF_NO"];}else{n_sStaff_no=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_INTERNSHIP"])) {n_bInternship = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_INTERNSHIP"];}else{n_bInternship=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CENTRE"])) {n_sCentre = (string)_oData["STAFFINFO_NEW_CENTRE"];}else{n_sCentre=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_PAY_CODE"])) {n_sPay_code = (string)_oData["STAFFINFO_NEW_PAY_CODE"];}else{n_sPay_code=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NO2"])) {n_sStaff_no2 = (string)_oData["STAFFINFO_NEW_STAFF_NO2"];}else{n_sStaff_no2=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ID"])) {n_iId = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_ID"];}else{n_iId=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_TEAMCODE"])) {n_sTeamcode = (string)_oData["STAFFINFO_NEW_TEAMCODE"];}else{n_sTeamcode=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LANGUAGE"])) {n_sLanguage = (string)_oData["STAFFINFO_NEW_LANGUAGE"];}else{n_sLanguage=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_TYPE"])) {n_sStaff_type = (string)_oData["STAFFINFO_NEW_STAFF_TYPE"];}else{n_sStaff_type=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NAME"])) {n_sStaff_name = (string)_oData["STAFFINFO_NEW_STAFF_NAME"];}else{n_sStaff_name=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_OTC"])) {n_iOtc = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_OTC"];}else{n_iOtc=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_EDATE"])) {n_dEdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_EDATE"];}else{n_dEdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_E"])) {n_dContract_e = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_E"];}else{n_dContract_e=null;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SKILL"])) {n_sSkill = (string)_oData["STAFFINFO_NEW_SKILL"];}else{n_sSkill=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPLEVEL"])) {n_sSteplevel = (string)_oData["STAFFINFO_NEW_STEPLEVEL"];}else{n_sSteplevel=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CCC"])) {n_sCcc = (string)_oData["STAFFINFO_NEW_CCC"];}else{n_sCcc=string.Empty;}
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
        
        public bool Load(string x_sStaff_no2,string x_sStaff_no){
            if (n_oDB==null) { return false; }
            if (string.IsNullOrEmpty(x_sStaff_no2)) { return false; }
            if (string.IsNullOrEmpty(x_sStaff_no)) { return false; }
            string _sQuery = "SELECT [CSSDB].[csc].[staffinfo_new].[basic] AS STAFFINFO_NEW_BASIC,[CSSDB].[csc].[staffinfo_new].[cid] AS STAFFINFO_NEW_CID,[CSSDB].[csc].[staffinfo_new].[steptype] AS STAFFINFO_NEW_STEPTYPE,[CSSDB].[csc].[staffinfo_new].[cdate] AS STAFFINFO_NEW_CDATE,[CSSDB].[csc].[staffinfo_new].[freeze] AS STAFFINFO_NEW_FREEZE,[CSSDB].[csc].[staffinfo_new].[lwdate] AS STAFFINFO_NEW_LWDATE,[CSSDB].[csc].[staffinfo_new].[cmrid] AS STAFFINFO_NEW_CMRID,[CSSDB].[csc].[staffinfo_new].[did] AS STAFFINFO_NEW_DID,[CSSDB].[csc].[staffinfo_new].[contract_s] AS STAFFINFO_NEW_CONTRACT_S,[CSSDB].[csc].[staffinfo_new].[sdate] AS STAFFINFO_NEW_SDATE,[CSSDB].[csc].[staffinfo_new].[active] AS STAFFINFO_NEW_ACTIVE,[CSSDB].[csc].[staffinfo_new].[salesman_code] AS STAFFINFO_NEW_SALESMAN_CODE,[CSSDB].[csc].[staffinfo_new].[ddate] AS STAFFINFO_NEW_DDATE,[CSSDB].[csc].[staffinfo_new].[stream] AS STAFFINFO_NEW_STREAM,[CSSDB].[csc].[staffinfo_new].[joindate] AS STAFFINFO_NEW_JOINDATE,[CSSDB].[csc].[staffinfo_new].[shift] AS STAFFINFO_NEW_SHIFT,[CSSDB].[csc].[staffinfo_new].[staff_no] AS STAFFINFO_NEW_STAFF_NO,[CSSDB].[csc].[staffinfo_new].[internship] AS STAFFINFO_NEW_INTERNSHIP,[CSSDB].[csc].[staffinfo_new].[centre] AS STAFFINFO_NEW_CENTRE,[CSSDB].[csc].[staffinfo_new].[pay_code] AS STAFFINFO_NEW_PAY_CODE,[CSSDB].[csc].[staffinfo_new].[staff_no2] AS STAFFINFO_NEW_STAFF_NO2,[CSSDB].[csc].[staffinfo_new].[id] AS STAFFINFO_NEW_ID,[CSSDB].[csc].[staffinfo_new].[teamcode] AS STAFFINFO_NEW_TEAMCODE,[CSSDB].[csc].[staffinfo_new].[Language] AS STAFFINFO_NEW_LANGUAGE,[CSSDB].[csc].[staffinfo_new].[staff_type] AS STAFFINFO_NEW_STAFF_TYPE,[CSSDB].[csc].[staffinfo_new].[staff_name] AS STAFFINFO_NEW_STAFF_NAME,[CSSDB].[csc].[staffinfo_new].[otc] AS STAFFINFO_NEW_OTC,[CSSDB].[csc].[staffinfo_new].[edate] AS STAFFINFO_NEW_EDATE,[CSSDB].[csc].[staffinfo_new].[contract_e] AS STAFFINFO_NEW_CONTRACT_E,[CSSDB].[csc].[staffinfo_new].[skill] AS STAFFINFO_NEW_SKILL,[CSSDB].[csc].[staffinfo_new].[steplevel] AS STAFFINFO_NEW_STEPLEVEL,[CSSDB].[csc].[staffinfo_new].[ccc] AS STAFFINFO_NEW_CCC  FROM  [CSSDB].[csc].[staffinfo_new]  WHERE  [CSSDB].[csc].[staffinfo_new].[staff_no2] = \'" + x_sStaff_no2.ToString() + "\'  AND  (edate is null or edate>=getdate()-1)";
            using (global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read())
                    {
                        n_bFound = true;
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_BASIC"])) { n_iBasic = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_BASIC"]; } else { n_iBasic = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CID"])) { n_sCid = (string)_oData["STAFFINFO_NEW_CID"]; } else { n_sCid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPTYPE"])) { n_sSteptype = (string)_oData["STAFFINFO_NEW_STEPTYPE"]; } else { n_sSteptype = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CDATE"])) { n_dCdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CDATE"]; } else { n_dCdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_FREEZE"])) { n_bFreeze = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_FREEZE"]; } else { n_bFreeze = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LWDATE"])) { n_dLwdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_LWDATE"]; } else { n_dLwdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CMRID"])) { n_sCmrid = (string)_oData["STAFFINFO_NEW_CMRID"]; } else { n_sCmrid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DID"])) { n_sDid = (string)_oData["STAFFINFO_NEW_DID"]; } else { n_sDid = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_S"])) { n_dContract_s = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_S"]; } else { n_dContract_s = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SDATE"])) { n_dSdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_SDATE"]; } else { n_dSdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ACTIVE"])) { n_bActive = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_ACTIVE"]; } else { n_bActive = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SALESMAN_CODE"])) { n_sSalesman_code = (string)_oData["STAFFINFO_NEW_SALESMAN_CODE"]; } else { n_sSalesman_code = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DDATE"])) { n_dDdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_DDATE"]; } else { n_dDdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STREAM"])) { n_sStream = (string)_oData["STAFFINFO_NEW_STREAM"]; } else { n_sStream = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_JOINDATE"])) { n_dJoindate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_JOINDATE"]; } else { n_dJoindate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SHIFT"])) { n_sShift = (string)_oData["STAFFINFO_NEW_SHIFT"]; } else { n_sShift = string.Empty; }
                      
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_INTERNSHIP"])) { n_bInternship = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_INTERNSHIP"]; } else { n_bInternship = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CENTRE"])) { n_sCentre = (string)_oData["STAFFINFO_NEW_CENTRE"]; } else { n_sCentre = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_PAY_CODE"])) { n_sPay_code = (string)_oData["STAFFINFO_NEW_PAY_CODE"]; } else { n_sPay_code = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NO2"])) { n_sStaff_no2 = (string)_oData["STAFFINFO_NEW_STAFF_NO2"]; } else { n_sStaff_no2 = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ID"])) { n_iId = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_ID"]; } else { n_iId = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_TEAMCODE"])) { n_sTeamcode = (string)_oData["STAFFINFO_NEW_TEAMCODE"]; } else { n_sTeamcode = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LANGUAGE"])) { n_sLanguage = (string)_oData["STAFFINFO_NEW_LANGUAGE"]; } else { n_sLanguage = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_TYPE"])) { n_sStaff_type = (string)_oData["STAFFINFO_NEW_STAFF_TYPE"]; } else { n_sStaff_type = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NAME"])) { n_sStaff_name = (string)_oData["STAFFINFO_NEW_STAFF_NAME"]; } else { n_sStaff_name = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_OTC"])) { n_iOtc = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_OTC"]; } else { n_iOtc = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_EDATE"])) { n_dEdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_EDATE"]; } else { n_dEdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_E"])) { n_dContract_e = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_E"]; } else { n_dContract_e = null; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SKILL"])) { n_sSkill = (string)_oData["STAFFINFO_NEW_SKILL"]; } else { n_sSkill = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPLEVEL"])) { n_sSteplevel = (string)_oData["STAFFINFO_NEW_STEPLEVEL"]; } else { n_sSteplevel = string.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CCC"])) { n_sCcc = (string)_oData["STAFFINFO_NEW_CCC"]; } else { n_sCcc = string.Empty; }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }
            return true;
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
            if (n_iBasic==null && !(n_oTableSet.Fields(Para.basic).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCid) && !(n_oTableSet.Fields(Para.cid).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sSteptype) && !(n_oTableSet.Fields(Para.steptype).IsNullable)) return false;
            if (n_dCdate==null && !(n_oTableSet.Fields(Para.cdate).IsNullable)) return false;
            if (n_bFreeze==null && !(n_oTableSet.Fields(Para.freeze).IsNullable)) return false;
            if (n_dLwdate==null && !(n_oTableSet.Fields(Para.lwdate).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCmrid) && !(n_oTableSet.Fields(Para.cmrid).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sDid) && !(n_oTableSet.Fields(Para.did).IsNullable)) return false;
            if (n_dContract_s==null && !(n_oTableSet.Fields(Para.contract_s).IsNullable)) return false;
            if (n_dSdate==null && !(n_oTableSet.Fields(Para.sdate).IsNullable)) return false;
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sSalesman_code) && !(n_oTableSet.Fields(Para.salesman_code).IsNullable)) return false;
            if (n_dDdate==null && !(n_oTableSet.Fields(Para.ddate).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sStream) && !(n_oTableSet.Fields(Para.stream).IsNullable)) return false;
            if (n_dJoindate==null && !(n_oTableSet.Fields(Para.joindate).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sShift) && !(n_oTableSet.Fields(Para.shift).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sStaff_no) && !(n_oTableSet.Fields(Para.staff_no).IsNullable)) return false;
            if (n_bInternship==null && !(n_oTableSet.Fields(Para.internship).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCentre) && !(n_oTableSet.Fields(Para.centre).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sPay_code) && !(n_oTableSet.Fields(Para.pay_code).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sStaff_no2) && !(n_oTableSet.Fields(Para.staff_no2).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            if (string.IsNullOrEmpty(n_sTeamcode) && !(n_oTableSet.Fields(Para.teamcode).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sLanguage) && !(n_oTableSet.Fields(Para.Language).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sStaff_type) && !(n_oTableSet.Fields(Para.staff_type).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sStaff_name) && !(n_oTableSet.Fields(Para.staff_name).IsNullable)) return false;
            if (n_iOtc==null && !(n_oTableSet.Fields(Para.otc).IsNullable)) return false;
            if (n_dEdate==null && !(n_oTableSet.Fields(Para.edate).IsNullable)) return false;
            if (n_dContract_e==null && !(n_oTableSet.Fields(Para.contract_e).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sSkill) && !(n_oTableSet.Fields(Para.skill).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sSteplevel) && !(n_oTableSet.Fields(Para.steplevel).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sCcc) && !(n_oTableSet.Fields(Para.ccc).IsNullable)) return false;
            return true;
        }
        #endregion
        
        #region Get & Set
        
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        public object GetManagerObject(object x_oObj)
        {
            if (x_oObj is Staffinfo_new) return Staffinfo_newManager.Instance();
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
        public global::System.Data.DataTable GetTbl(){ return n_oTbl; }
        #endregion GetTbl
        
        
        #region SetTbl
        public void SetTbl(DataTable value){  n_oTbl=value; }
        #endregion SetTbl
        
        
        #region GetRow
        public global::System.Data.DataRow GetRow(){ return n_oRow; }
        #endregion GetRow
        
        
        #region SetRow
        public void SetRow(global::System.Data.DataRow value){  n_oRow=value; }
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
        public Staffinfo_newInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(Staffinfo_newInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetBasic(){return this.basic;}
        public global::System.Nullable<DateTime> GetEdate(){return this.edate;}
        public string GetSteptype(){return this.steptype;}
        public global::System.Nullable<DateTime> GetCdate(){return this.cdate;}
        public string GetCmrid(){return this.cmrid;}
        public string GetDid(){return this.did;}
        public global::System.Nullable<DateTime> GetContract_s(){return this.contract_s;}
        public global::System.Nullable<DateTime> GetSdate(){return this.sdate;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        public string GetSalesman_code(){return this.salesman_code;}
        public string GetStream(){return this.stream;}
        public global::System.Nullable<DateTime> GetJoindate(){return this.joindate;}
        public string GetShift(){return this.shift;}
        public string GetStaff_no(){return this.staff_no;}
        public global::System.Nullable<bool> GetInternship(){return this.internship;}
        public global::System.Nullable<DateTime> GetLwdate(){return this.lwdate;}
        public global::System.Nullable<DateTime> GetDdate(){return this.ddate;}
        public string GetStaff_no2(){return this.staff_no2;}
        public global::System.Nullable<int> GetId(){return this.id;}
        public string GetTeamcode(){return this.teamcode;}
        public string GetCentre(){return this.centre;}
        public string GetLanguage(){return this.Language;}
        public string GetCid(){return this.cid;}
        public string GetStaff_name(){return this.staff_name;}
        public global::System.Nullable<int> GetOtc(){return this.otc;}
        public string GetSkill(){return this.skill;}
        public global::System.Nullable<bool> GetFreeze(){return this.freeze;}
        public global::System.Nullable<DateTime> GetContract_e(){return this.contract_e;}
        public string GetStaff_type(){return this.staff_type;}
        public string GetSteplevel(){return this.steplevel;}
        public string GetCcc(){return this.ccc;}
        public string GetPay_code(){return this.pay_code;}
        
        public bool SetBasic(global::System.Nullable<int> value){
            this.basic=value;
            return true;
        }
        public bool SetEdate(global::System.Nullable<DateTime> value){
            this.edate=value;
            return true;
        }
        public bool SetSteptype(string value){
            this.steptype=value;
            return true;
        }
        public bool SetCdate(global::System.Nullable<DateTime> value){
            this.cdate=value;
            return true;
        }
        public bool SetCmrid(string value){
            this.cmrid=value;
            return true;
        }
        public bool SetDid(string value){
            this.did=value;
            return true;
        }
        public bool SetContract_s(global::System.Nullable<DateTime> value){
            this.contract_s=value;
            return true;
        }
        public bool SetSdate(global::System.Nullable<DateTime> value){
            this.sdate=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        public bool SetSalesman_code(string value){
            this.salesman_code=value;
            return true;
        }
        public bool SetStream(string value){
            this.stream=value;
            return true;
        }
        public bool SetJoindate(global::System.Nullable<DateTime> value){
            this.joindate=value;
            return true;
        }
        public bool SetShift(string value){
            this.shift=value;
            return true;
        }
        public bool SetStaff_no(string value){
            this.staff_no=value;
            return true;
        }
        public bool SetInternship(global::System.Nullable<bool> value){
            this.internship=value;
            return true;
        }
        public bool SetLwdate(global::System.Nullable<DateTime> value){
            this.lwdate=value;
            return true;
        }
        public bool SetDdate(global::System.Nullable<DateTime> value){
            this.ddate=value;
            return true;
        }
        public bool SetStaff_no2(string value){
            this.staff_no2=value;
            return true;
        }
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetTeamcode(string value){
            this.teamcode=value;
            return true;
        }
        public bool SetCentre(string value){
            this.centre=value;
            return true;
        }
        public bool SetLanguage(string value){
            this.Language=value;
            return true;
        }
        public bool SetCid(string value){
            this.cid=value;
            return true;
        }
        public bool SetStaff_name(string value){
            this.staff_name=value;
            return true;
        }
        public bool SetOtc(global::System.Nullable<int> value){
            this.otc=value;
            return true;
        }
        public bool SetSkill(string value){
            this.skill=value;
            return true;
        }
        public bool SetFreeze(global::System.Nullable<bool> value){
            this.freeze=value;
            return true;
        }
        public bool SetContract_e(global::System.Nullable<DateTime> value){
            this.contract_e=value;
            return true;
        }
        public bool SetStaff_type(string value){
            this.staff_type=value;
            return true;
        }
        public bool SetSteplevel(string value){
            this.steplevel=value;
            return true;
        }
        public bool SetCcc(string value){
            this.ccc=value;
            return true;
        }
        public bool SetPay_code(string value){
            this.pay_code=value;
            return true;
        }
        
        public Field GetBasicTable(){
            return n_oTableSet.Fields(Para.basic);
        }
        public Field GetEdateTable(){
            return n_oTableSet.Fields(Para.edate);
        }
        public Field GetSteptypeTable(){
            return n_oTableSet.Fields(Para.steptype);
        }
        public Field GetCdateTable(){
            return n_oTableSet.Fields(Para.cdate);
        }
        public Field GetCmridTable(){
            return n_oTableSet.Fields(Para.cmrid);
        }
        public Field GetDidTable(){
            return n_oTableSet.Fields(Para.did);
        }
        public Field GetContract_sTable(){
            return n_oTableSet.Fields(Para.contract_s);
        }
        public Field GetSdateTable(){
            return n_oTableSet.Fields(Para.sdate);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
        }
        public Field GetSalesman_codeTable(){
            return n_oTableSet.Fields(Para.salesman_code);
        }
        public Field GetStreamTable(){
            return n_oTableSet.Fields(Para.stream);
        }
        public Field GetJoindateTable(){
            return n_oTableSet.Fields(Para.joindate);
        }
        public Field GetShiftTable(){
            return n_oTableSet.Fields(Para.shift);
        }
        public Field GetStaff_noTable(){
            return n_oTableSet.Fields(Para.staff_no);
        }
        public Field GetInternshipTable(){
            return n_oTableSet.Fields(Para.internship);
        }
        public Field GetLwdateTable(){
            return n_oTableSet.Fields(Para.lwdate);
        }
        public Field GetDdateTable(){
            return n_oTableSet.Fields(Para.ddate);
        }
        public Field GetStaff_no2Table(){
            return n_oTableSet.Fields(Para.staff_no2);
        }
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetTeamcodeTable(){
            return n_oTableSet.Fields(Para.teamcode);
        }
        public Field GetCentreTable(){
            return n_oTableSet.Fields(Para.centre);
        }
        public Field GetLanguageTable(){
            return n_oTableSet.Fields(Para.Language);
        }
        public Field GetCidTable(){
            return n_oTableSet.Fields(Para.cid);
        }
        public Field GetStaff_nameTable(){
            return n_oTableSet.Fields(Para.staff_name);
        }
        public Field GetOtcTable(){
            return n_oTableSet.Fields(Para.otc);
        }
        public Field GetSkillTable(){
            return n_oTableSet.Fields(Para.skill);
        }
        public Field GetFreezeTable(){
            return n_oTableSet.Fields(Para.freeze);
        }
        public Field GetContract_eTable(){
            return n_oTableSet.Fields(Para.contract_e);
        }
        public Field GetStaff_typeTable(){
            return n_oTableSet.Fields(Para.staff_type);
        }
        public Field GetSteplevelTable(){
            return n_oTableSet.Fields(Para.steplevel);
        }
        public Field GetCccTable(){
            return n_oTableSet.Fields(Para.ccc);
        }
        public Field GetPay_codeTable(){
            return n_oTableSet.Fields(Para.pay_code);
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
        
        public bool EqualID(Staffinfo_new x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(Staffinfo_new x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_iBasic.Equals(x_oObj.basic)){ return false; }
            if(!this.n_sCid.Equals(x_oObj.cid)){ return false; }
            if(!this.n_sSteptype.Equals(x_oObj.steptype)){ return false; }
            if(!this.n_dCdate.Equals(x_oObj.cdate)){ return false; }
            if(!this.n_bFreeze.Equals(x_oObj.freeze)){ return false; }
            if(!this.n_dLwdate.Equals(x_oObj.lwdate)){ return false; }
            if(!this.n_sCmrid.Equals(x_oObj.cmrid)){ return false; }
            if(!this.n_sDid.Equals(x_oObj.did)){ return false; }
            if(!this.n_dContract_s.Equals(x_oObj.contract_s)){ return false; }
            if(!this.n_dSdate.Equals(x_oObj.sdate)){ return false; }
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sSalesman_code.Equals(x_oObj.salesman_code)){ return false; }
            if(!this.n_dDdate.Equals(x_oObj.ddate)){ return false; }
            if(!this.n_sStream.Equals(x_oObj.stream)){ return false; }
            if(!this.n_dJoindate.Equals(x_oObj.joindate)){ return false; }
            if(!this.n_sShift.Equals(x_oObj.shift)){ return false; }
            if(!this.n_sStaff_no.Equals(x_oObj.staff_no)){ return false; }
            if(!this.n_bInternship.Equals(x_oObj.internship)){ return false; }
            if(!this.n_sCentre.Equals(x_oObj.centre)){ return false; }
            if(!this.n_sPay_code.Equals(x_oObj.pay_code)){ return false; }
            if(!this.n_sStaff_no2.Equals(x_oObj.staff_no2)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
            if(!this.n_sTeamcode.Equals(x_oObj.teamcode)){ return false; }
            if(!this.n_sLanguage.Equals(x_oObj.Language)){ return false; }
            if(!this.n_sStaff_type.Equals(x_oObj.staff_type)){ return false; }
            if(!this.n_sStaff_name.Equals(x_oObj.staff_name)){ return false; }
            if(!this.n_iOtc.Equals(x_oObj.otc)){ return false; }
            if(!this.n_dEdate.Equals(x_oObj.edate)){ return false; }
            if(!this.n_dContract_e.Equals(x_oObj.contract_e)){ return false; }
            if(!this.n_sSkill.Equals(x_oObj.skill)){ return false; }
            if(!this.n_sSteplevel.Equals(x_oObj.steplevel)){ return false; }
            if(!this.n_sCcc.Equals(x_oObj.ccc)){ return false; }
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
            if(!n_iId.Equals(null)){
                _bResult=this.Load(n_iId);
                if(_bResult){ return _bResult;}
            }
            if(!n_sStaff_no2.Equals(string.Empty) && !n_sStaff_no.Equals(string.Empty)){
                _bResult=this.Load(n_sStaff_no2,n_sStaff_no);
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
            if (n_iId==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [CSSDB].[csc].[staffinfo_new]  SET  [basic]=@basic,[cid]=@cid,[steptype]=@steptype,[cdate]=@cdate,[freeze]=@freeze,[lwdate]=@lwdate,[cmrid]=@cmrid,[did]=@did,[contract_s]=@contract_s,[sdate]=@sdate,[active]=@active,[salesman_code]=@salesman_code,[ddate]=@ddate,[stream]=@stream,[joindate]=@joindate,[shift]=@shift,[staff_no]=@staff_no,[internship]=@internship,[centre]=@centre,[pay_code]=@pay_code,[staff_no2]=@staff_no2,[teamcode]=@teamcode,[Language]=@Language,[staff_type]=@staff_type,[staff_name]=@staff_name,[otc]=@otc,[edate]=@edate,[contract_e]=@contract_e,[skill]=@skill,[steplevel]=@steplevel,[ccc]=@ccc  WHERE [CSSDB].[csc].[staffinfo_new].[id]=@id";
            
            global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            if(n_iBasic==null){  _oCmd.Parameters.Add("@basic", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@basic", global::System.Data.SqlDbType.Int).Value=n_iBasic; }
            if(string.IsNullOrEmpty(n_sCid)){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCid; }
            if(string.IsNullOrEmpty(n_sSteptype)){  _oCmd.Parameters.Add("@steptype", global::System.Data.SqlDbType.NVarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@steptype", global::System.Data.SqlDbType.NVarChar,4).Value=n_sSteptype; }
            if(n_dCdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=n_dCdate; }
            if(n_bFreeze==null){  _oCmd.Parameters.Add("@freeze", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@freeze", global::System.Data.SqlDbType.Bit).Value=n_bFreeze; }
            if(n_dLwdate==null){  _oCmd.Parameters.Add("@lwdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@lwdate", global::System.Data.SqlDbType.DateTime).Value=n_dLwdate; }
            if(string.IsNullOrEmpty(n_sCmrid)){  _oCmd.Parameters.Add("@cmrid", global::System.Data.SqlDbType.NVarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cmrid", global::System.Data.SqlDbType.NVarChar,4).Value=n_sCmrid; }
            if(string.IsNullOrEmpty(n_sDid)){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,10).Value=n_sDid; }
            if(n_dContract_s==null){  _oCmd.Parameters.Add("@contract_s", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@contract_s", global::System.Data.SqlDbType.DateTime).Value=n_dContract_s; }
            if(n_dSdate==null){  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value=n_dSdate; }
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(string.IsNullOrEmpty(n_sSalesman_code)){  _oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar,4).Value=n_sSalesman_code; }
            if(n_dDdate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=n_dDdate; }
            if(string.IsNullOrEmpty(n_sStream)){  _oCmd.Parameters.Add("@stream", global::System.Data.SqlDbType.NVarChar,5).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@stream", global::System.Data.SqlDbType.NVarChar,5).Value=n_sStream; }
            if(n_dJoindate==null){  _oCmd.Parameters.Add("@joindate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@joindate", global::System.Data.SqlDbType.DateTime).Value=n_dJoindate; }
            if(string.IsNullOrEmpty(n_sShift)){  _oCmd.Parameters.Add("@shift", global::System.Data.SqlDbType.NVarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@shift", global::System.Data.SqlDbType.NVarChar,15).Value=n_sShift; }
            if(string.IsNullOrEmpty(n_sStaff_no)){  _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar,10).Value=n_sStaff_no; }
            if(n_bInternship==null){  _oCmd.Parameters.Add("@internship", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@internship", global::System.Data.SqlDbType.Bit).Value=n_bInternship; }
            if(string.IsNullOrEmpty(n_sCentre)){  _oCmd.Parameters.Add("@centre", global::System.Data.SqlDbType.NVarChar,5).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@centre", global::System.Data.SqlDbType.NVarChar,5).Value=n_sCentre; }
            if(string.IsNullOrEmpty(n_sPay_code)){  _oCmd.Parameters.Add("@pay_code", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@pay_code", global::System.Data.SqlDbType.NVarChar,10).Value=n_sPay_code; }
            if(string.IsNullOrEmpty(n_sStaff_no2)){  _oCmd.Parameters.Add("@staff_no2", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@staff_no2", global::System.Data.SqlDbType.NVarChar,10).Value=n_sStaff_no2; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
            if(string.IsNullOrEmpty(n_sTeamcode)){  _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,15).Value=n_sTeamcode; }
            if(string.IsNullOrEmpty(n_sLanguage)){  _oCmd.Parameters.Add("@Language", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@Language", global::System.Data.SqlDbType.NVarChar,10).Value=n_sLanguage; }
            if(string.IsNullOrEmpty(n_sStaff_type)){  _oCmd.Parameters.Add("@staff_type", global::System.Data.SqlDbType.NVarChar,5).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@staff_type", global::System.Data.SqlDbType.NVarChar,5).Value=n_sStaff_type; }
            if(string.IsNullOrEmpty(n_sStaff_name)){  _oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar,50).Value=n_sStaff_name; }
            if(n_iOtc==null){  _oCmd.Parameters.Add("@otc", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@otc", global::System.Data.SqlDbType.Int).Value=n_iOtc; }
            if(n_dEdate==null){  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=n_dEdate; }
            if(n_dContract_e==null){  _oCmd.Parameters.Add("@contract_e", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@contract_e", global::System.Data.SqlDbType.DateTime).Value=n_dContract_e; }
            if(string.IsNullOrEmpty(n_sSkill)){  _oCmd.Parameters.Add("@skill", global::System.Data.SqlDbType.NVarChar,5).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@skill", global::System.Data.SqlDbType.NVarChar,5).Value=n_sSkill; }
            if(string.IsNullOrEmpty(n_sSteplevel)){  _oCmd.Parameters.Add("@steplevel", global::System.Data.SqlDbType.NVarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@steplevel", global::System.Data.SqlDbType.NVarChar,4).Value=n_sSteplevel; }
            if(string.IsNullOrEmpty(n_sCcc)){  _oCmd.Parameters.Add("@ccc", global::System.Data.SqlDbType.NVarChar,3).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@ccc", global::System.Data.SqlDbType.NVarChar,3).Value=n_sCcc; }
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        #endregion
        
        #region Delete
        
        /// <summary>
        /// Summary description for table [CSSDB].[csc].[staffinfo_new] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [CSSDB].[csc].[staffinfo_new]  WHERE [CSSDB].[csc].[staffinfo_new].[id]=@id";
            
            global::System.Data.SqlClient.SqlConnection _oConn = this.n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = n_iId;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        #endregion
        
        #region DeepClone
        
        /// <summary>
        /// Summary description for table [CSSDB].[csc].[staffinfo_new] Object Base Clone
        /// </summary>
        
        public Staffinfo_new DeepClone()
        {
            Staffinfo_new _oStaffinfo_new_Clone = new Staffinfo_new();
            _oStaffinfo_new_Clone.basic = this.n_iBasic;
            _oStaffinfo_new_Clone.cid = this.n_sCid;
            _oStaffinfo_new_Clone.steptype = this.n_sSteptype;
            _oStaffinfo_new_Clone.cdate = this.n_dCdate;
            _oStaffinfo_new_Clone.freeze = this.n_bFreeze;
            _oStaffinfo_new_Clone.lwdate = this.n_dLwdate;
            _oStaffinfo_new_Clone.cmrid = this.n_sCmrid;
            _oStaffinfo_new_Clone.did = this.n_sDid;
            _oStaffinfo_new_Clone.contract_s = this.n_dContract_s;
            _oStaffinfo_new_Clone.sdate = this.n_dSdate;
            _oStaffinfo_new_Clone.active = this.n_bActive;
            _oStaffinfo_new_Clone.salesman_code = this.n_sSalesman_code;
            _oStaffinfo_new_Clone.ddate = this.n_dDdate;
            _oStaffinfo_new_Clone.stream = this.n_sStream;
            _oStaffinfo_new_Clone.joindate = this.n_dJoindate;
            _oStaffinfo_new_Clone.shift = this.n_sShift;
            _oStaffinfo_new_Clone.staff_no = this.n_sStaff_no;
            _oStaffinfo_new_Clone.internship = this.n_bInternship;
            _oStaffinfo_new_Clone.centre = this.n_sCentre;
            _oStaffinfo_new_Clone.pay_code = this.n_sPay_code;
            _oStaffinfo_new_Clone.staff_no2 = this.n_sStaff_no2;
            _oStaffinfo_new_Clone.id = this.n_iId;
            _oStaffinfo_new_Clone.teamcode = this.n_sTeamcode;
            _oStaffinfo_new_Clone.Language = this.n_sLanguage;
            _oStaffinfo_new_Clone.staff_type = this.n_sStaff_type;
            _oStaffinfo_new_Clone.staff_name = this.n_sStaff_name;
            _oStaffinfo_new_Clone.otc = this.n_iOtc;
            _oStaffinfo_new_Clone.edate = this.n_dEdate;
            _oStaffinfo_new_Clone.contract_e = this.n_dContract_e;
            _oStaffinfo_new_Clone.skill = this.n_sSkill;
            _oStaffinfo_new_Clone.steplevel = this.n_sSteplevel;
            _oStaffinfo_new_Clone.ccc = this.n_sCcc;
            _oStaffinfo_new_Clone.SetFound(this.n_bFound);
            _oStaffinfo_new_Clone.SetDB(this.n_oDB);
            _oStaffinfo_new_Clone.SetRow(this.n_oRow);
            _oStaffinfo_new_Clone.SetTbl(this.n_oTbl);
            _oStaffinfo_new_Clone.SetTableSet(this.n_oTableSet);
            
            return _oStaffinfo_new_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_iBasic=null;
            n_sCid=string.Empty;
            n_sSteptype=string.Empty;
            n_dCdate=null;
            n_bFreeze=null;
            n_dLwdate=null;
            n_sCmrid=string.Empty;
            n_sDid=string.Empty;
            n_dContract_s=null;
            n_dSdate=null;
            n_bActive=null;
            n_sSalesman_code=string.Empty;
            n_dDdate=null;
            n_sStream=string.Empty;
            n_dJoindate=null;
            n_sShift=string.Empty;
            n_sStaff_no=string.Empty;
            n_bInternship=null;
            n_sCentre=string.Empty;
            n_sPay_code=string.Empty;
            n_sStaff_no2=string.Empty;
            n_iId=null;
            n_sTeamcode=string.Empty;
            n_sLanguage=string.Empty;
            n_sStaff_type=string.Empty;
            n_sStaff_name=string.Empty;
            n_iOtc=null;
            n_dEdate=null;
            n_dContract_e=null;
            n_sSkill=string.Empty;
            n_sSteplevel=string.Empty;
            n_sCcc=string.Empty;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new Staffinfo_newInfo();
        }
        #endregion
    }
}


