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
///-- Description:	<Description,Table :[CSSDB].[dbo].[ar_rights],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[ar_rights] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = "ar_rights")]
    public class Ar_rightsBase{
        
        
        protected string n_sCID=string.Empty;
        #region CID
        [System.Data.Linq.Mapping.Column(Name="[CID]", Storage="n_sCID")]
        public string CID{
            get{
                return this.n_sCID;
            }
            set{
                this.n_sCID=value;
            }
        }
        #endregion CID
        
        
        protected string n_sDID=string.Empty;
        #region DID
        [System.Data.Linq.Mapping.Column(Name="[DID]", Storage="n_sDID")]
        public string DID{
            get{
                return this.n_sDID;
            }
            set{
                this.n_sDID=value;
            }
        }
        #endregion DID
        
        
        protected string n_sPROG_LV=string.Empty;
        #region PROG_LV
        [System.Data.Linq.Mapping.Column(Name="[PROG_LV]", Storage="n_sPROG_LV")]
        public string PROG_LV{
            get{
                return this.n_sPROG_LV;
            }
            set{
                this.n_sPROG_LV=value;
            }
        }
        #endregion PROG_LV
        
        
        protected global::System.Nullable<bool> n_bAR_LST=null;
        #region AR_LST
        [System.Data.Linq.Mapping.Column(Name="[AR_LST]", Storage="n_bAR_LST")]
        public global::System.Nullable<bool> AR_LST{
            get{
                return this.n_bAR_LST;
            }
            set{
                this.n_bAR_LST=value;
            }
        }
        #endregion AR_LST
        
        
        protected string n_sSTAFF_NO=string.Empty;
        #region STAFF_NO
        [System.Data.Linq.Mapping.Column(Name="[STAFF_NO]", Storage="n_sSTAFF_NO")]
        public string STAFF_NO{
            get{
                return this.n_sSTAFF_NO;
            }
            set{
                this.n_sSTAFF_NO=value;
            }
        }
        #endregion STAFF_NO
        
        
        protected global::System.Nullable<bool> n_bAR_PRT=null;
        #region AR_PRT
        [System.Data.Linq.Mapping.Column(Name="[AR_PRT]", Storage="n_bAR_PRT")]
        public global::System.Nullable<bool> AR_PRT{
            get{
                return this.n_bAR_PRT;
            }
            set{
                this.n_bAR_PRT=value;
            }
        }
        #endregion AR_PRT
        
        
        protected global::System.Nullable<DateTime> n_dDDATE=null;
        #region DDATE
        [System.Data.Linq.Mapping.Column(Name="[DDATE]", Storage="n_dDDATE")]
        public global::System.Nullable<DateTime> DDATE{
            get{
                return this.n_dDDATE;
            }
            set{
                this.n_dDDATE=value;
            }
        }
        #endregion DDATE
        
        
        protected string n_sPROG_NAME=string.Empty;
        #region PROG_NAME
        [System.Data.Linq.Mapping.Column(Name="[PROG_NAME]", Storage="n_sPROG_NAME")]
        public string PROG_NAME{
            get{
                return this.n_sPROG_NAME;
            }
            set{
                this.n_sPROG_NAME=value;
            }
        }
        #endregion PROG_NAME
        
        
        protected global::System.Nullable<DateTime> n_dCDATE=null;
        #region CDATE
        [System.Data.Linq.Mapping.Column(Name="[CDATE]", Storage="n_dCDATE")]
        public global::System.Nullable<DateTime> CDATE{
            get{
                return this.n_dCDATE;
            }
            set{
                this.n_dCDATE=value;
            }
        }
        #endregion CDATE
        
        
        protected global::System.Nullable<int> n_iACTIVE=null;
        #region ACTIVE
        [System.Data.Linq.Mapping.Column(Name="[ACTIVE]", Storage="n_iACTIVE")]
        public global::System.Nullable<int> ACTIVE{
            get{
                return this.n_iACTIVE;
            }
            set{
                this.n_iACTIVE=value;
            }
        }
        #endregion ACTIVE
        
        
        protected global::System.Nullable<bool> n_bAR_ADD=null;
        #region AR_ADD
        [System.Data.Linq.Mapping.Column(Name="[AR_ADD]", Storage="n_bAR_ADD")]
        public global::System.Nullable<bool> AR_ADD{
            get{
                return this.n_bAR_ADD;
            }
            set{
                this.n_bAR_ADD=value;
            }
        }
        #endregion AR_ADD
        
        
        protected global::System.Nullable<bool> n_bAR_DEL=null;
        #region AR_DEL
        [System.Data.Linq.Mapping.Column(Name="[AR_DEL]", Storage="n_bAR_DEL")]
        public global::System.Nullable<bool> AR_DEL{
            get{
                return this.n_bAR_DEL;
            }
            set{
                this.n_bAR_DEL=value;
            }
        }
        #endregion AR_DEL
        
        
        protected global::System.Nullable<bool> n_bAR_MOD=null;
        #region AR_MOD
        [System.Data.Linq.Mapping.Column(Name="[AR_MOD]", Storage="n_bAR_MOD")]
        public global::System.Nullable<bool> AR_MOD{
            get{
                return this.n_bAR_MOD;
            }
            set{
                this.n_bAR_MOD=value;
            }
        }
        #endregion AR_MOD
        
        
        protected global::System.Nullable<int> n_iAPPL_ID=null;
        #region APPL_ID
        [System.Data.Linq.Mapping.Column(Name="[APPL_ID]", Storage="n_iAPPL_ID")]
        public global::System.Nullable<int> APPL_ID{
            get{
                return this.n_iAPPL_ID;
            }
            set{
                this.n_iAPPL_ID=value;
            }
        }
        #endregion APPL_ID
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private Ar_rightsInfo n_oTableSet = new Ar_rightsInfo();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string CID="CID";
            public const string DID="DID";
            public const string PROG_LV="PROG_LV";
            public const string AR_LST="AR_LST";
            public const string STAFF_NO="STAFF_NO";
            public const string AR_PRT="AR_PRT";
            public const string AR_MOD="AR_MOD";
            public const string PROG_NAME="PROG_NAME";
            public const string ACTIVE="ACTIVE";
            public const string AR_ADD="AR_ADD";
            public const string AR_DEL="AR_DEL";
            public const string DDATE="DDATE";
            public const string CDATE="CDATE";
            public const string APPL_ID="APPL_ID";
            public const string Ar_rights_table_name=Configurator.MSSQLTablePrefix+"ar_rights";
            public static string TableName() { return Ar_rights_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public Ar_rightsBase(){
            Init();
        }
        public Ar_rightsBase(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public Ar_rightsBase(MSSQLConnect x_oDB,System.Nullable<int> x_iAPPL_ID){
            n_oDB=x_oDB;
            this.Load(x_iAPPL_ID);
            Init();
        }
        
        ~Ar_rightsBase(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iAPPL_ID){
            if (n_oDB==null) { return false; }
            if (x_iAPPL_ID==null) { return false; }
            string _sQuery = "SELECT [CSSDB].[dbo].[ar_rights].[CID] AS AR_RIGHTS_CID,[CSSDB].[dbo].[ar_rights].[DID] AS AR_RIGHTS_DID,[CSSDB].[dbo].[ar_rights].[PROG_LV] AS AR_RIGHTS_PROG_LV,[CSSDB].[dbo].[ar_rights].[AR_LST] AS AR_RIGHTS_AR_LST,[CSSDB].[dbo].[ar_rights].[STAFF_NO] AS AR_RIGHTS_STAFF_NO,[CSSDB].[dbo].[ar_rights].[AR_PRT] AS AR_RIGHTS_AR_PRT,[CSSDB].[dbo].[ar_rights].[DDATE] AS AR_RIGHTS_DDATE,[CSSDB].[dbo].[ar_rights].[PROG_NAME] AS AR_RIGHTS_PROG_NAME,[CSSDB].[dbo].[ar_rights].[CDATE] AS AR_RIGHTS_CDATE,[CSSDB].[dbo].[ar_rights].[ACTIVE] AS AR_RIGHTS_ACTIVE,[CSSDB].[dbo].[ar_rights].[AR_ADD] AS AR_RIGHTS_AR_ADD,[CSSDB].[dbo].[ar_rights].[AR_DEL] AS AR_RIGHTS_AR_DEL,[CSSDB].[dbo].[ar_rights].[AR_MOD] AS AR_RIGHTS_AR_MOD,[CSSDB].[dbo].[ar_rights].[APPL_ID] AS AR_RIGHTS_APPL_ID  FROM  [CSSDB].[dbo].[ar_rights]  WHERE  [CSSDB].[dbo].[ar_rights].[APPL_ID] = \'"+x_iAPPL_ID.ToString()+"\'";
            
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
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_CID"])) {n_sCID = (string)_oData["AR_RIGHTS_CID"];}else{n_sCID=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_DID"])) {n_sDID = (string)_oData["AR_RIGHTS_DID"];}else{n_sDID=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_PROG_LV"])) {n_sPROG_LV = (string)_oData["AR_RIGHTS_PROG_LV"];}else{n_sPROG_LV=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_LST"])) {n_bAR_LST = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_LST"];}else{n_bAR_LST=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_STAFF_NO"])) {n_sSTAFF_NO = (string)_oData["AR_RIGHTS_STAFF_NO"];}else{n_sSTAFF_NO=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_PRT"])) {n_bAR_PRT = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_PRT"];}else{n_bAR_PRT=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_DDATE"])) {n_dDDATE = (global::System.Nullable<DateTime>)_oData["AR_RIGHTS_DDATE"];}else{n_dDDATE=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_PROG_NAME"])) {n_sPROG_NAME = (string)_oData["AR_RIGHTS_PROG_NAME"];}else{n_sPROG_NAME=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_CDATE"])) {n_dCDATE = (global::System.Nullable<DateTime>)_oData["AR_RIGHTS_CDATE"];}else{n_dCDATE=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_ACTIVE"])) {n_iACTIVE = (global::System.Nullable<int>)_oData["AR_RIGHTS_ACTIVE"];}else{n_iACTIVE=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_ADD"])) {n_bAR_ADD = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_ADD"];}else{n_bAR_ADD=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_DEL"])) {n_bAR_DEL = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_DEL"];}else{n_bAR_DEL=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_MOD"])) {n_bAR_MOD = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_MOD"];}else{n_bAR_MOD=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_APPL_ID"])) {n_iAPPL_ID = (global::System.Nullable<int>)_oData["AR_RIGHTS_APPL_ID"];}else{n_iAPPL_ID=null;}
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
            if (string.IsNullOrEmpty(n_sCID) && !(n_oTableSet.Fields(Para.CID).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sDID) && !(n_oTableSet.Fields(Para.DID).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sPROG_LV) && !(n_oTableSet.Fields(Para.PROG_LV).IsNullable)) return false;
            if (n_bAR_LST==null && !(n_oTableSet.Fields(Para.AR_LST).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sSTAFF_NO) && !(n_oTableSet.Fields(Para.STAFF_NO).IsNullable)) return false;
            if (n_bAR_PRT==null && !(n_oTableSet.Fields(Para.AR_PRT).IsNullable)) return false;
            if (n_dDDATE==null && !(n_oTableSet.Fields(Para.DDATE).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sPROG_NAME) && !(n_oTableSet.Fields(Para.PROG_NAME).IsNullable)) return false;
            if (n_dCDATE==null && !(n_oTableSet.Fields(Para.CDATE).IsNullable)) return false;
            if (n_iACTIVE==null && !(n_oTableSet.Fields(Para.ACTIVE).IsNullable)) return false;
            if (n_bAR_ADD==null && !(n_oTableSet.Fields(Para.AR_ADD).IsNullable)) return false;
            if (n_bAR_DEL==null && !(n_oTableSet.Fields(Para.AR_DEL).IsNullable)) return false;
            if (n_bAR_MOD==null && !(n_oTableSet.Fields(Para.AR_MOD).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iAPPL_ID==null && !(n_oTableSet.Fields(Para.APPL_ID).IsNullable)) return false;
            }
            return true;
        }
        #endregion
        
        #region Get & Set
        public object GetManagerObject(object x_oObj)
        {
            if (x_oObj is Ar_rights) return Ar_rightsManager.Instance();
            return null;
        }
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        
        
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
        public Ar_rightsInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(Ar_rightsInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public string GetCID(){return this.CID;}
        public string GetDID(){return this.DID;}
        public string GetPROG_LV(){return this.PROG_LV;}
        public global::System.Nullable<bool> GetAR_LST(){return this.AR_LST;}
        public string GetSTAFF_NO(){return this.STAFF_NO;}
        public global::System.Nullable<bool> GetAR_PRT(){return this.AR_PRT;}
        public global::System.Nullable<bool> GetAR_MOD(){return this.AR_MOD;}
        public string GetPROG_NAME(){return this.PROG_NAME;}
        public global::System.Nullable<int> GetACTIVE(){return this.ACTIVE;}
        public global::System.Nullable<bool> GetAR_ADD(){return this.AR_ADD;}
        public global::System.Nullable<bool> GetAR_DEL(){return this.AR_DEL;}
        public global::System.Nullable<DateTime> GetDDATE(){return this.DDATE;}
        public global::System.Nullable<DateTime> GetCDATE(){return this.CDATE;}
        public global::System.Nullable<int> GetAPPL_ID(){return this.APPL_ID;}
        
        public bool SetCID(string value){
            this.CID=value;
            return true;
        }
        public bool SetDID(string value){
            this.DID=value;
            return true;
        }
        public bool SetPROG_LV(string value){
            this.PROG_LV=value;
            return true;
        }
        public bool SetAR_LST(global::System.Nullable<bool> value){
            this.AR_LST=value;
            return true;
        }
        public bool SetSTAFF_NO(string value){
            this.STAFF_NO=value;
            return true;
        }
        public bool SetAR_PRT(global::System.Nullable<bool> value){
            this.AR_PRT=value;
            return true;
        }
        public bool SetAR_MOD(global::System.Nullable<bool> value){
            this.AR_MOD=value;
            return true;
        }
        public bool SetPROG_NAME(string value){
            this.PROG_NAME=value;
            return true;
        }
        public bool SetACTIVE(global::System.Nullable<int> value){
            this.ACTIVE=value;
            return true;
        }
        public bool SetAR_ADD(global::System.Nullable<bool> value){
            this.AR_ADD=value;
            return true;
        }
        public bool SetAR_DEL(global::System.Nullable<bool> value){
            this.AR_DEL=value;
            return true;
        }
        public bool SetDDATE(global::System.Nullable<DateTime> value){
            this.DDATE=value;
            return true;
        }
        public bool SetCDATE(global::System.Nullable<DateTime> value){
            this.CDATE=value;
            return true;
        }
        public bool SetAPPL_ID(global::System.Nullable<int> value){
            this.APPL_ID=value;
            return true;
        }
        
        public Field GetCIDTable(){
            return n_oTableSet.Fields(Para.CID);
        }
        public Field GetDIDTable(){
            return n_oTableSet.Fields(Para.DID);
        }
        public Field GetPROG_LVTable(){
            return n_oTableSet.Fields(Para.PROG_LV);
        }
        public Field GetAR_LSTTable(){
            return n_oTableSet.Fields(Para.AR_LST);
        }
        public Field GetSTAFF_NOTable(){
            return n_oTableSet.Fields(Para.STAFF_NO);
        }
        public Field GetAR_PRTTable(){
            return n_oTableSet.Fields(Para.AR_PRT);
        }
        public Field GetAR_MODTable(){
            return n_oTableSet.Fields(Para.AR_MOD);
        }
        public Field GetPROG_NAMETable(){
            return n_oTableSet.Fields(Para.PROG_NAME);
        }
        public Field GetACTIVETable(){
            return n_oTableSet.Fields(Para.ACTIVE);
        }
        public Field GetAR_ADDTable(){
            return n_oTableSet.Fields(Para.AR_ADD);
        }
        public Field GetAR_DELTable(){
            return n_oTableSet.Fields(Para.AR_DEL);
        }
        public Field GetDDATETable(){
            return n_oTableSet.Fields(Para.DDATE);
        }
        public Field GetCDATETable(){
            return n_oTableSet.Fields(Para.CDATE);
        }
        public Field GetAPPL_IDTable(){
            return n_oTableSet.Fields(Para.APPL_ID);
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
        
        public bool EqualID(Ar_rights x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iAPPL_ID.Equals(x_oObj.APPL_ID)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(Ar_rights x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_sCID.Equals(x_oObj.CID)){ return false; }
            if(!this.n_sDID.Equals(x_oObj.DID)){ return false; }
            if(!this.n_sPROG_LV.Equals(x_oObj.PROG_LV)){ return false; }
            if(!this.n_bAR_LST.Equals(x_oObj.AR_LST)){ return false; }
            if(!this.n_sSTAFF_NO.Equals(x_oObj.STAFF_NO)){ return false; }
            if(!this.n_bAR_PRT.Equals(x_oObj.AR_PRT)){ return false; }
            if(!this.n_dDDATE.Equals(x_oObj.DDATE)){ return false; }
            if(!this.n_sPROG_NAME.Equals(x_oObj.PROG_NAME)){ return false; }
            if(!this.n_dCDATE.Equals(x_oObj.CDATE)){ return false; }
            if(!this.n_iACTIVE.Equals(x_oObj.ACTIVE)){ return false; }
            if(!this.n_bAR_ADD.Equals(x_oObj.AR_ADD)){ return false; }
            if(!this.n_bAR_DEL.Equals(x_oObj.AR_DEL)){ return false; }
            if(!this.n_bAR_MOD.Equals(x_oObj.AR_MOD)){ return false; }
            if(!this.n_iAPPL_ID.Equals(x_oObj.APPL_ID)){ return false; }
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
            if(!n_iAPPL_ID.Equals(null)){
                _bResult=this.Load(n_iAPPL_ID);
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
            if (n_iAPPL_ID==null) { return false; }
            if(!Vaild(false)){ return false; }
            string _sQuery = "UPDATE  [CSSDB].[dbo].[ar_rights]  SET  [CID]=@CID,[DID]=@DID,[PROG_LV]=@PROG_LV,[AR_LST]=@AR_LST,[STAFF_NO]=@STAFF_NO,[AR_PRT]=@AR_PRT,[DDATE]=@DDATE,[PROG_NAME]=@PROG_NAME,[CDATE]=@CDATE,[ACTIVE]=@ACTIVE,[AR_ADD]=@AR_ADD,[AR_DEL]=@AR_DEL,[AR_MOD]=@AR_MOD  WHERE [CSSDB].[dbo].[ar_rights].[APPL_ID]=@APPL_ID";
            
            global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            if(string.IsNullOrEmpty(n_sCID)){  _oCmd.Parameters.Add("@CID", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@CID", global::System.Data.SqlDbType.NVarChar,10).Value=n_sCID; }
            if(string.IsNullOrEmpty(n_sDID)){  _oCmd.Parameters.Add("@DID", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@DID", global::System.Data.SqlDbType.NVarChar,10).Value=n_sDID; }
            if(string.IsNullOrEmpty(n_sPROG_LV)){  _oCmd.Parameters.Add("@PROG_LV", global::System.Data.SqlDbType.NVarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@PROG_LV", global::System.Data.SqlDbType.NVarChar,15).Value=n_sPROG_LV; }
            if(n_bAR_LST==null){  _oCmd.Parameters.Add("@AR_LST", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@AR_LST", global::System.Data.SqlDbType.Bit).Value=n_bAR_LST; }
            if(string.IsNullOrEmpty(n_sSTAFF_NO)){  _oCmd.Parameters.Add("@STAFF_NO", global::System.Data.SqlDbType.NVarChar,20).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@STAFF_NO", global::System.Data.SqlDbType.NVarChar,20).Value=n_sSTAFF_NO; }
            if(n_bAR_PRT==null){  _oCmd.Parameters.Add("@AR_PRT", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@AR_PRT", global::System.Data.SqlDbType.Bit).Value=n_bAR_PRT; }
            if(n_dDDATE==null){  _oCmd.Parameters.Add("@DDATE", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@DDATE", global::System.Data.SqlDbType.DateTime).Value=n_dDDATE; }
            if(string.IsNullOrEmpty(n_sPROG_NAME)){  _oCmd.Parameters.Add("@PROG_NAME", global::System.Data.SqlDbType.NVarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@PROG_NAME", global::System.Data.SqlDbType.NVarChar,15).Value=n_sPROG_NAME; }
            if(n_dCDATE==null){  _oCmd.Parameters.Add("@CDATE", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@CDATE", global::System.Data.SqlDbType.DateTime).Value=n_dCDATE; }
            if(n_iACTIVE==null){  _oCmd.Parameters.Add("@ACTIVE", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@ACTIVE", global::System.Data.SqlDbType.Int).Value=n_iACTIVE; }
            if(n_bAR_ADD==null){  _oCmd.Parameters.Add("@AR_ADD", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@AR_ADD", global::System.Data.SqlDbType.Bit).Value=n_bAR_ADD; }
            if(n_bAR_DEL==null){  _oCmd.Parameters.Add("@AR_DEL", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@AR_DEL", global::System.Data.SqlDbType.Bit).Value=n_bAR_DEL; }
            if(n_bAR_MOD==null){  _oCmd.Parameters.Add("@AR_MOD", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@AR_MOD", global::System.Data.SqlDbType.Bit).Value=n_bAR_MOD; }
            if(n_iAPPL_ID==null){  _oCmd.Parameters.Add("@APPL_ID", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@APPL_ID", global::System.Data.SqlDbType.Int).Value=n_iAPPL_ID; }
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
        /// Summary description for table [CSSDB].[dbo].[ar_rights] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iAPPL_ID==null) { return false; }
            string _sQuery="DELETE FROM  [CSSDB].[dbo].[ar_rights]  WHERE [CSSDB].[dbo].[ar_rights].[APPL_ID]=@APPL_ID";
            
            global::System.Data.SqlClient.SqlConnection _oConn = this.n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            _oCmd.Parameters.Add("@APPL_ID", global::System.Data.SqlDbType.Int).Value = n_iAPPL_ID;
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
        /// Summary description for table [CSSDB].[dbo].[ar_rights] Object Base Clone
        /// </summary>
        
        public Ar_rights DeepClone()
        {
            Ar_rights _oAr_rights_Clone = new Ar_rights();
            _oAr_rights_Clone.CID = this.n_sCID;
            _oAr_rights_Clone.DID = this.n_sDID;
            _oAr_rights_Clone.PROG_LV = this.n_sPROG_LV;
            _oAr_rights_Clone.AR_LST = this.n_bAR_LST;
            _oAr_rights_Clone.STAFF_NO = this.n_sSTAFF_NO;
            _oAr_rights_Clone.AR_PRT = this.n_bAR_PRT;
            _oAr_rights_Clone.DDATE = this.n_dDDATE;
            _oAr_rights_Clone.PROG_NAME = this.n_sPROG_NAME;
            _oAr_rights_Clone.CDATE = this.n_dCDATE;
            _oAr_rights_Clone.ACTIVE = this.n_iACTIVE;
            _oAr_rights_Clone.AR_ADD = this.n_bAR_ADD;
            _oAr_rights_Clone.AR_DEL = this.n_bAR_DEL;
            _oAr_rights_Clone.AR_MOD = this.n_bAR_MOD;
            _oAr_rights_Clone.APPL_ID = this.n_iAPPL_ID;
            _oAr_rights_Clone.SetFound(this.n_bFound);
            _oAr_rights_Clone.SetDB(this.n_oDB);
            _oAr_rights_Clone.SetRow(this.n_oRow);
            _oAr_rights_Clone.SetTbl(this.n_oTbl);
            _oAr_rights_Clone.SetTableSet(this.n_oTableSet);
            
            return _oAr_rights_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_sCID=string.Empty;
            n_sDID=string.Empty;
            n_sPROG_LV=string.Empty;
            n_bAR_LST=null;
            n_sSTAFF_NO=string.Empty;
            n_bAR_PRT=null;
            n_dDDATE=null;
            n_sPROG_NAME=string.Empty;
            n_dCDATE=null;
            n_iACTIVE=null;
            n_bAR_ADD=null;
            n_bAR_DEL=null;
            n_bAR_MOD=null;
            n_iAPPL_ID=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new Ar_rightsInfo();
        }
        #endregion
    }
}


