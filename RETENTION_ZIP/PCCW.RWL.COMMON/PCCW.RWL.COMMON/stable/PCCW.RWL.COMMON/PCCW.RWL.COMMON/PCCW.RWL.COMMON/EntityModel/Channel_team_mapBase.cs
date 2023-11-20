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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-24>
///-- Description:	<Description,Table :[CSSDB].[dbo].[channel_team_map],Object Base layer>
///-- Linq:	<Description,This class can be selected by Linq To Sql(Lambda Expression)!>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[channel_team_map] Object Base layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.Table(Name = "channel_team_map")]
    public class Channel_team_mapBase{
        
        
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
        
        
        protected string n_sChannel=string.Empty;
        #region channel
        [System.Data.Linq.Mapping.Column(Name="[channel]", Storage="n_sChannel")]
        public string channel{
            get{
                return this.n_sChannel;
            }
            set{
                this.n_sChannel=value;
            }
        }
        #endregion channel
        
        
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
        
        #region Parameter
        private MSSQLConnect n_oDB = null;
        private bool n_bFound=false;
        private global::System.Data.DataTable n_oTbl = null;
        private global::System.Data.DataRow n_oRow = null;
        private Channel_team_mapInfo n_oTableSet = new Channel_team_mapInfo();
        public string n_sPrefix= Configurator.MSSQLTablePrefix;
        #endregion
        
        #region Parameter String
        public class Para{
            public const string id="id";
            public const string teamcode="teamcode";
            public const string channel="channel";
            public const string active="active";
            public const string Channel_team_map_table_name=Configurator.MSSQLTablePrefix+"channel_team_map";
            public static string TableName() { return Channel_team_map_table_name; }
        }
        #endregion Parameter String
        
        #region Constructor
        public Channel_team_mapBase(){
            Init();
        }
        public Channel_team_mapBase(MSSQLConnect x_oDB){
            n_oDB=x_oDB;
            Init();
        }
        
        public Channel_team_mapBase(MSSQLConnect x_oDB,System.Nullable<int> x_iId){
            n_oDB=x_oDB;
            this.Load(x_iId);
            Init();
        }
        
        ~Channel_team_mapBase(){
            this.Release();
        }
        #endregion
        
        #region Load
        
        public bool Load(global::System.Nullable<int> x_iId){
            if (n_oDB==null) { return false; }
            if (x_iId==null) { return false; }
            string _sQuery = "SELECT [CSSDB].[dbo].[channel_team_map].[active] AS CHANNEL_TEAM_MAP_ACTIVE,[CSSDB].[dbo].[channel_team_map].[teamcode] AS CHANNEL_TEAM_MAP_TEAMCODE,[CSSDB].[dbo].[channel_team_map].[channel] AS CHANNEL_TEAM_MAP_CHANNEL,[CSSDB].[dbo].[channel_team_map].[id] AS CHANNEL_TEAM_MAP_ID  FROM  [CSSDB].[dbo].[channel_team_map]  WHERE  [CSSDB].[dbo].[channel_team_map].[id] = \'"+x_iId.ToString()+"\'";
            
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
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_ACTIVE"])) {n_bActive = (global::System.Nullable<bool>)_oData["CHANNEL_TEAM_MAP_ACTIVE"];}else{n_bActive=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_TEAMCODE"])) {n_sTeamcode = (string)_oData["CHANNEL_TEAM_MAP_TEAMCODE"];}else{n_sTeamcode=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_CHANNEL"])) {n_sChannel = (string)_oData["CHANNEL_TEAM_MAP_CHANNEL"];}else{n_sChannel=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_ID"])) {n_iId = (global::System.Nullable<int>)_oData["CHANNEL_TEAM_MAP_ID"];}else{n_iId=null;}
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
            if (n_bActive==null && !(n_oTableSet.Fields(Para.active).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sTeamcode) && !(n_oTableSet.Fields(Para.teamcode).IsNullable)) return false;
            if (string.IsNullOrEmpty(n_sChannel) && !(n_oTableSet.Fields(Para.channel).IsNullable)) return false;
            if(!x_bInsert){
                if (n_iId==null && !(n_oTableSet.Fields(Para.id).IsNullable)) return false;
            }
            return true;
        }
        #endregion
        
        #region Get & Set
        
        /// <summary>
        /// Summary description for Get & Set this all class parameters
        /// </summary>
        public object GetManagerObject(object x_oObj)
        {
            if (x_oObj is Channel_team_map) return Channel_team_mapManager.Instance();
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
        public Channel_team_mapInfo GetTableSet(){ return n_oTableSet; }
        #endregion GetTableSet
        
        
        #region SetTableSet
        public void SetTableSet(Channel_team_mapInfo value){ n_oTableSet=value; }
        #endregion SetTableSet
        
        public global::System.Nullable<int> GetId(){return this.id;}
        public string GetTeamcode(){return this.teamcode;}
        public string GetChannel(){return this.channel;}
        public global::System.Nullable<bool> GetActive(){return this.active;}
        
        public bool SetId(global::System.Nullable<int> value){
            this.id=value;
            return true;
        }
        public bool SetTeamcode(string value){
            this.teamcode=value;
            return true;
        }
        public bool SetChannel(string value){
            this.channel=value;
            return true;
        }
        public bool SetActive(global::System.Nullable<bool> value){
            this.active=value;
            return true;
        }
        
        public Field GetIdTable(){
            return n_oTableSet.Fields(Para.id);
        }
        public Field GetTeamcodeTable(){
            return n_oTableSet.Fields(Para.teamcode);
        }
        public Field GetChannelTable(){
            return n_oTableSet.Fields(Para.channel);
        }
        public Field GetActiveTable(){
            return n_oTableSet.Fields(Para.active);
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
        
        public bool EqualID(Channel_team_map x_oObj)
        {
            if (x_oObj == null) return false;
            bool isEquals = true;
            isEquals = (this.n_iId.Equals(x_oObj.id)) && isEquals;
            return isEquals;
        }
        
        public bool Equals(Channel_team_map x_oObj)
        {
            if (x_oObj == null) return false;
            if(!this.n_bActive.Equals(x_oObj.active)){ return false; }
            if(!this.n_sTeamcode.Equals(x_oObj.teamcode)){ return false; }
            if(!this.n_sChannel.Equals(x_oObj.channel)){ return false; }
            if(!this.n_iId.Equals(x_oObj.id)){ return false; }
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
            string _sQuery = "UPDATE  [CSSDB].[dbo].[channel_team_map]  SET  [active]=@active,[teamcode]=@teamcode,[channel]=@channel  WHERE [CSSDB].[dbo].[channel_team_map].[id]=@id";
           
            global::System.Data.SqlClient.SqlConnection _oConn = n_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            if(n_bActive==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=n_bActive; }
            if(string.IsNullOrEmpty(n_sTeamcode)){  _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value=n_sTeamcode; }
            if(string.IsNullOrEmpty(n_sChannel)){  _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar,10).Value=n_sChannel; }
            if(n_iId==null){  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value=n_iId; }
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
        /// Summary description for table [CSSDB].[dbo].[channel_team_map] Delete Record
        /// </summary>
        
        public bool Delete()
        {
            if (n_iId==null) { return false; }
            string _sQuery="DELETE FROM  [CSSDB].[dbo].[channel_team_map]  WHERE [CSSDB].[dbo].[channel_team_map].[id]=@id";
           
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
        /// Summary description for table [CSSDB].[dbo].[channel_team_map] Object Base Clone
        /// </summary>
        
        public Channel_team_map DeepClone()
        {
            Channel_team_map _oChannel_team_map_Clone = new Channel_team_map();
            _oChannel_team_map_Clone.active = this.n_bActive;
            _oChannel_team_map_Clone.teamcode = this.n_sTeamcode;
            _oChannel_team_map_Clone.channel = this.n_sChannel;
            _oChannel_team_map_Clone.id = this.n_iId;
            _oChannel_team_map_Clone.SetFound(this.n_bFound);
            _oChannel_team_map_Clone.SetDB(this.n_oDB);
            _oChannel_team_map_Clone.SetRow(this.n_oRow);
            _oChannel_team_map_Clone.SetTbl(this.n_oTbl);
            _oChannel_team_map_Clone.SetTableSet(this.n_oTableSet);
            
            return _oChannel_team_map_Clone;
        }
        #endregion
        
        #region Release
        
        /// <summary>
        /// Summary description for Release
        /// </summary>
        
        public void Release(){
            n_bActive=null;
            n_sTeamcode=string.Empty;
            n_sChannel=string.Empty;
            n_iId=null;
            n_oDB = null;
            n_bFound= false;
            n_oTbl = null;
            n_oRow = null;
            n_oTableSet = new Channel_team_mapInfo();
        }
        #endregion
    }
}


