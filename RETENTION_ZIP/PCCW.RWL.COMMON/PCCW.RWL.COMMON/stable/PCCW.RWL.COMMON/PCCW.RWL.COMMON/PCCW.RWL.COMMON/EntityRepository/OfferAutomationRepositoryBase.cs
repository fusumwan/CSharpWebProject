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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[OfferAutomation],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [OfferAutomation] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"OfferAutomation")]
    public class OfferAutomationRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static OfferAutomationRepositoryBase instance;
        public static OfferAutomationRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new OfferAutomationRepositoryBase(_oDB);
            }
            return instance;
        }
        public static OfferAutomationRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new OfferAutomationRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<OfferAutomationEntity> OfferAutomations;
        #endregion
        
        #region Constructor
        public OfferAutomationRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~OfferAutomationRepositoryBase() { 
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
        public static OfferAutomation CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new OfferAutomation(_oDB);
        }
        
        public static OfferAutomation CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new OfferAutomation(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [OfferAutomation]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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
        
        
        public OfferAutomationEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static OfferAutomationEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            OfferAutomation _OfferAutomation = (OfferAutomation)OfferAutomationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_OfferAutomation.Load(x_iId)) { return null; }
            return _OfferAutomation;
        }
        
        
        
        public static OfferAutomationEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<OfferAutomationEntity> _oOfferAutomationList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oOfferAutomationList==null){ return null;}
            return _oOfferAutomationList.Count == 0 ? null : _oOfferAutomationList.ToArray();
        }
        
        public static List<OfferAutomationEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static OfferAutomationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<OfferAutomationEntity> _oOfferAutomationList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oOfferAutomationList==null){ return null;}
            return _oOfferAutomationList.Count == 0 ? null : _oOfferAutomationList.ToArray();
        }
        
        
        public static OfferAutomationEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<OfferAutomationEntity> _oOfferAutomationList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oOfferAutomationList==null){ return null;}
            return _oOfferAutomationList.Count == 0 ? null : _oOfferAutomationList.ToArray();
        }
        
        public static List<OfferAutomationEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<OfferAutomationEntity> _oRow = new List<OfferAutomationEntity>();
            string _sQuery = "SELECT  "+_sTop+" [OfferAutomation].[active] AS OFFERAUTOMATION_ACTIVE,[OfferAutomation].[offer_name] AS OFFERAUTOMATION_OFFER_NAME,[OfferAutomation].[call_list_program_id] AS OFFERAUTOMATION_CALL_LIST_PROGRAM_ID,[OfferAutomation].[id] AS OFFERAUTOMATION_ID,[OfferAutomation].[trade_field_id] AS OFFERAUTOMATION_TRADE_FIELD_ID  FROM  [OfferAutomation]";
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
                _sQuery += " WHERE [OfferAutomation].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        OfferAutomation _oOfferAutomation = OfferAutomationRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ID"])) {_oOfferAutomation.id = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_ID"]; }else{_oOfferAutomation.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_OFFER_NAME"])) {_oOfferAutomation.offer_name = (string)_oData["OFFERAUTOMATION_OFFER_NAME"]; }else{_oOfferAutomation.offer_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"])) {_oOfferAutomation.call_list_program_id = (global::System.Nullable<long>)_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"]; }else{_oOfferAutomation.call_list_program_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ACTIVE"])) {_oOfferAutomation.active = (global::System.Nullable<bool>)_oData["OFFERAUTOMATION_ACTIVE"]; }else{_oOfferAutomation.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_TRADE_FIELD_ID"])) {_oOfferAutomation.trade_field_id = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_TRADE_FIELD_ID"]; }else{_oOfferAutomation.trade_field_id=null;}
                        _oOfferAutomation.SetDB(x_oDB);
                        _oOfferAutomation.GetFound();
                        _oRow.Add(_oOfferAutomation);
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
        
        
        public static OfferAutomationEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<OfferAutomationEntity> _oOfferAutomationList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oOfferAutomationList==null){ return null;}
            return _oOfferAutomationList.Count == 0 ? null : _oOfferAutomationList.ToArray();
        }
        
        
        public static OfferAutomationEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<OfferAutomationEntity> _oOfferAutomationList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oOfferAutomationList==null){ return null;}
            return _oOfferAutomationList.Count == 0 ? null : _oOfferAutomationList.ToArray();
        }
        
        public static List<OfferAutomationEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<OfferAutomationEntity> _oRow = new List<OfferAutomationEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[OfferAutomation].[active] AS OFFERAUTOMATION_ACTIVE,[OfferAutomation].[offer_name] AS OFFERAUTOMATION_OFFER_NAME,[OfferAutomation].[call_list_program_id] AS OFFERAUTOMATION_CALL_LIST_PROGRAM_ID,[OfferAutomation].[id] AS OFFERAUTOMATION_ID,[OfferAutomation].[trade_field_id] AS OFFERAUTOMATION_TRADE_FIELD_ID";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = OfferAutomationRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                OfferAutomationEntity _oOfferAutomation = OfferAutomationRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ID"])) {_oOfferAutomation.id = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_ID"]; } else {_oOfferAutomation.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_OFFER_NAME"])) {_oOfferAutomation.offer_name = (string)_oData["OFFERAUTOMATION_OFFER_NAME"]; } else {_oOfferAutomation.offer_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"])) {_oOfferAutomation.call_list_program_id = (global::System.Nullable<long>)_oData["OFFERAUTOMATION_CALL_LIST_PROGRAM_ID"]; } else {_oOfferAutomation.call_list_program_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_ACTIVE"])) {_oOfferAutomation.active = (global::System.Nullable<bool>)_oData["OFFERAUTOMATION_ACTIVE"]; } else {_oOfferAutomation.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["OFFERAUTOMATION_TRADE_FIELD_ID"])) {_oOfferAutomation.trade_field_id = (global::System.Nullable<int>)_oData["OFFERAUTOMATION_TRADE_FIELD_ID"]; } else {_oOfferAutomation.trade_field_id=null; }
                _oOfferAutomation.SetDB(x_oDB);
                _oOfferAutomation.GetFound();
                _oRow.Add(_oOfferAutomation);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( OfferAutomation.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,OfferAutomation.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(OfferAutomation.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(OfferAutomation.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [OfferAutomation].[active] AS OFFERAUTOMATION_ACTIVE,[OfferAutomation].[offer_name] AS OFFERAUTOMATION_OFFER_NAME,[OfferAutomation].[call_list_program_id] AS OFFERAUTOMATION_CALL_LIST_PROGRAM_ID,[OfferAutomation].[id] AS OFFERAUTOMATION_ID,[OfferAutomation].[trade_field_id] AS OFFERAUTOMATION_TRADE_FIELD_ID  FROM  [OfferAutomation]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"OfferAutomation");
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
        
        public bool Insert(string x_sOffer_name,global::System.Nullable<long> x_lCall_list_program_id,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iTrade_field_id)
        {
            OfferAutomation _oOfferAutomation=OfferAutomationRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oOfferAutomation.offer_name=x_sOffer_name;
            _oOfferAutomation.call_list_program_id=x_lCall_list_program_id;
            _oOfferAutomation.active=x_bActive;
            _oOfferAutomation.trade_field_id=x_iTrade_field_id;
            return InsertWithOutLastID(n_oDB, _oOfferAutomation);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sOffer_name,global::System.Nullable<long> x_lCall_list_program_id,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iTrade_field_id)
        {
            OfferAutomation _oOfferAutomation=OfferAutomationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oOfferAutomation.offer_name=x_sOffer_name;
            _oOfferAutomation.call_list_program_id=x_lCall_list_program_id;
            _oOfferAutomation.active=x_bActive;
            _oOfferAutomation.trade_field_id=x_iTrade_field_id;
            return InsertWithOutLastID(x_oDB, _oOfferAutomation);
        }
        
        
        public bool Insert(OfferAutomation x_oOfferAutomation)
        {
            return InsertWithOutLastID(n_oDB, x_oOfferAutomation);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is OfferAutomation)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (OfferAutomation)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,OfferAutomation x_oOfferAutomation)
        {
            return InsertWithOutLastID(x_oDB, x_oOfferAutomation);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,OfferAutomation x_oOfferAutomation)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [OfferAutomation]   ([active],[offer_name],[call_list_program_id],[trade_field_id])  VALUES  (@active,@offer_name,@call_list_program_id,@trade_field_id)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oOfferAutomation);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,OfferAutomation x_oOfferAutomation)
        {
            bool _bResult = false;
            if (!x_oOfferAutomation.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oOfferAutomation.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oOfferAutomation.active; }
                if(x_oOfferAutomation.offer_name==null){  x_oCmd.Parameters.Add("@offer_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@offer_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oOfferAutomation.offer_name; }
                if(x_oOfferAutomation.call_list_program_id==null){  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=x_oOfferAutomation.call_list_program_id; }
                if(x_oOfferAutomation.trade_field_id==null){  x_oCmd.Parameters.Add("@trade_field_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field_id", global::System.Data.SqlDbType.Int).Value=x_oOfferAutomation.trade_field_id; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sOffer_name,global::System.Nullable<long> x_lCall_list_program_id,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iTrade_field_id)
        {
            int _oLastID;
            OfferAutomation _oOfferAutomation=OfferAutomationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oOfferAutomation.offer_name=x_sOffer_name;
            _oOfferAutomation.call_list_program_id=x_lCall_list_program_id;
            _oOfferAutomation.active=x_bActive;
            _oOfferAutomation.trade_field_id=x_iTrade_field_id;
            if(InsertWithLastID(x_oDB, _oOfferAutomation,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(OfferAutomation x_oOfferAutomation)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oOfferAutomation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, OfferAutomation x_oOfferAutomation)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oOfferAutomation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is OfferAutomation)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (OfferAutomation)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,OfferAutomation x_oOfferAutomation, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [OfferAutomation]   ([active],[offer_name],[call_list_program_id],[trade_field_id])  VALUES  (@active,@offer_name,@call_list_program_id,@trade_field_id)"+" SELECT  @@IDENTITY AS OfferAutomation_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oOfferAutomation,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,OfferAutomation x_oOfferAutomation, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oOfferAutomation.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oOfferAutomation.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oOfferAutomation.active; }
                if(x_oOfferAutomation.offer_name==null){  x_oCmd.Parameters.Add("@offer_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@offer_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oOfferAutomation.offer_name; }
                if(x_oOfferAutomation.call_list_program_id==null){  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt).Value=x_oOfferAutomation.call_list_program_id; }
                if(x_oOfferAutomation.trade_field_id==null){  x_oCmd.Parameters.Add("@trade_field_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field_id", global::System.Data.SqlDbType.Int).Value=x_oOfferAutomation.trade_field_id; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["OfferAutomation_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["OfferAutomation_LASTID"].ToString()) && int.TryParse(_oData["OfferAutomation_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sOffer_name,global::System.Nullable<long> x_lCall_list_program_id,global::System.Nullable<bool> x_bActive,global::System.Nullable<int> x_iTrade_field_id)
        {
            int _oLastID;
            OfferAutomation _oOfferAutomation=OfferAutomationRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oOfferAutomation.offer_name=x_sOffer_name;
            _oOfferAutomation.call_list_program_id=x_lCall_list_program_id;
            _oOfferAutomation.active=x_bActive;
            _oOfferAutomation.trade_field_id=x_iTrade_field_id;
            if(InsertWithLastID_SP(x_oDB, _oOfferAutomation,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(OfferAutomation x_oOfferAutomation)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oOfferAutomation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, OfferAutomation x_oOfferAutomation)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oOfferAutomation, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is OfferAutomation)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (OfferAutomation)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,OfferAutomation x_oOfferAutomation, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "OFFERAUTOMATION";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oOfferAutomation,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,OfferAutomation x_oOfferAutomation, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oOfferAutomation.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oOfferAutomation.active; }
                _oPar=x_oCmd.Parameters.Add("@offer_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oOfferAutomation.offer_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oOfferAutomation.offer_name; }
                _oPar=x_oCmd.Parameters.Add("@call_list_program_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oOfferAutomation.call_list_program_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oOfferAutomation.call_list_program_id; }
                _oPar=x_oCmd.Parameters.Add("@trade_field_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oOfferAutomation.trade_field_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oOfferAutomation.trade_field_id; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
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
        
        #region INSERT_OFFERAUTOMATION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-09-15>
        ///-- Description:	<Description,OFFERAUTOMATION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_OFFERAUTOMATION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_OFFERAUTOMATION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_OFFERAUTOMATION;
        GO
        CREATE PROCEDURE INSERT_OFFERAUTOMATION
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @offer_name nvarchar(250),
        @call_list_program_id bigint,
        @active bit,
        @trade_field_id int
        AS
        
        INSERT INTO  [OfferAutomation]   ([active],[offer_name],[call_list_program_id],[trade_field_id])  VALUES  (@active,@offer_name,@call_list_program_id,@trade_field_id)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ID=@@IDENTITY
        RETURN @RETURN_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ID=-1
        RETURN @RETURN_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId==null) { return false; }
            string _sQuery = "DELETE FROM  [OfferAutomation]  WHERE [OfferAutomation].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return OfferAutomationRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [OfferAutomation]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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
            string _sQuery = "DELETE FROM [OfferAutomation]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[OfferAutomation]","["+ Configurator.MSSQLTablePrefix + "OfferAutomation]"); }
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


