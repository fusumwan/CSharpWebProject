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
///-- Create date: <Create Date 2011-11-09>
///-- Description:	<Description,Table :[MonthlyPaymentMethodMapping],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MonthlyPaymentMethodMapping] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MonthlyPaymentMethodMapping")]
    public class MonthlyPaymentMethodMappingRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MonthlyPaymentMethodMappingRepositoryBase instance;
        public static MonthlyPaymentMethodMappingRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MonthlyPaymentMethodMappingRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MonthlyPaymentMethodMappingRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MonthlyPaymentMethodMappingRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MonthlyPaymentMethodMappingEntity> MonthlyPaymentMethodMappings;
        #endregion
        
        #region Constructor
        public MonthlyPaymentMethodMappingRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MonthlyPaymentMethodMappingRepositoryBase() { 
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
        public static MonthlyPaymentMethodMapping CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MonthlyPaymentMethodMapping(_oDB);
        }
        
        public static MonthlyPaymentMethodMapping CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MonthlyPaymentMethodMapping(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MonthlyPaymentMethodMapping]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
        
        
        public MonthlyPaymentMethodMappingEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MonthlyPaymentMethodMappingEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MonthlyPaymentMethodMapping _MonthlyPaymentMethodMapping = (MonthlyPaymentMethodMapping)MonthlyPaymentMethodMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MonthlyPaymentMethodMapping.Load(x_iId)) { return null; }
            return _MonthlyPaymentMethodMapping;
        }
        
        
        
        public static MonthlyPaymentMethodMappingEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MonthlyPaymentMethodMappingEntity> _oMonthlyPaymentMethodMappingList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMonthlyPaymentMethodMappingList==null){ return null;}
            return _oMonthlyPaymentMethodMappingList.Count == 0 ? null : _oMonthlyPaymentMethodMappingList.ToArray();
        }
        
        public static List<MonthlyPaymentMethodMappingEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MonthlyPaymentMethodMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MonthlyPaymentMethodMappingEntity> _oMonthlyPaymentMethodMappingList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMonthlyPaymentMethodMappingList==null){ return null;}
            return _oMonthlyPaymentMethodMappingList.Count == 0 ? null : _oMonthlyPaymentMethodMappingList.ToArray();
        }
        
        
        public static MonthlyPaymentMethodMappingEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MonthlyPaymentMethodMappingEntity> _oMonthlyPaymentMethodMappingList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMonthlyPaymentMethodMappingList==null){ return null;}
            return _oMonthlyPaymentMethodMappingList.Count == 0 ? null : _oMonthlyPaymentMethodMappingList.ToArray();
        }
        
        public static List<MonthlyPaymentMethodMappingEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MonthlyPaymentMethodMappingEntity> _oRow = new List<MonthlyPaymentMethodMappingEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MonthlyPaymentMethodMapping].[cash_group] AS MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP,[MonthlyPaymentMethodMapping].[id] AS MONTHLYPAYMENTMETHODMAPPING_ID,[MonthlyPaymentMethodMapping].[active] AS MONTHLYPAYMENTMETHODMAPPING_ACTIVE,[MonthlyPaymentMethodMapping].[credit_card_group] AS MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP,[MonthlyPaymentMethodMapping].[payment_type] AS MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE,[MonthlyPaymentMethodMapping].[program] AS MONTHLYPAYMENTMETHODMAPPING_PROGRAM,[MonthlyPaymentMethodMapping].[issue_type] AS MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE,[MonthlyPaymentMethodMapping].[bank_account_group] AS MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP,[MonthlyPaymentMethodMapping].[third_party_credit_card] AS MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD  FROM  [MonthlyPaymentMethodMapping]";
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
                _sQuery += " WHERE [MonthlyPaymentMethodMapping].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MonthlyPaymentMethodMapping _oMonthlyPaymentMethodMapping = MonthlyPaymentMethodMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"])) {_oMonthlyPaymentMethodMapping.cash_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"]; }else{_oMonthlyPaymentMethodMapping.cash_group=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ID"])) {_oMonthlyPaymentMethodMapping.id = (global::System.Nullable<int>)_oData["MONTHLYPAYMENTMETHODMAPPING_ID"]; }else{_oMonthlyPaymentMethodMapping.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"])) {_oMonthlyPaymentMethodMapping.active = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"]; }else{_oMonthlyPaymentMethodMapping.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"])) {_oMonthlyPaymentMethodMapping.credit_card_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"]; }else{_oMonthlyPaymentMethodMapping.credit_card_group=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"])) {_oMonthlyPaymentMethodMapping.payment_type = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"]; }else{_oMonthlyPaymentMethodMapping.payment_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"])) {_oMonthlyPaymentMethodMapping.program = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"]; }else{_oMonthlyPaymentMethodMapping.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"])) {_oMonthlyPaymentMethodMapping.issue_type = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"]; }else{_oMonthlyPaymentMethodMapping.issue_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"])) {_oMonthlyPaymentMethodMapping.third_party_credit_card = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"]; }else{_oMonthlyPaymentMethodMapping.third_party_credit_card=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"])) {_oMonthlyPaymentMethodMapping.bank_account_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"]; }else{_oMonthlyPaymentMethodMapping.bank_account_group=null;}
                        _oMonthlyPaymentMethodMapping.SetDB(x_oDB);
                        _oMonthlyPaymentMethodMapping.GetFound();
                        _oRow.Add(_oMonthlyPaymentMethodMapping);
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
        
        
        public static MonthlyPaymentMethodMappingEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MonthlyPaymentMethodMappingEntity> _oMonthlyPaymentMethodMappingList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMonthlyPaymentMethodMappingList==null){ return null;}
            return _oMonthlyPaymentMethodMappingList.Count == 0 ? null : _oMonthlyPaymentMethodMappingList.ToArray();
        }
        
        
        public static MonthlyPaymentMethodMappingEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MonthlyPaymentMethodMappingEntity> _oMonthlyPaymentMethodMappingList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMonthlyPaymentMethodMappingList==null){ return null;}
            return _oMonthlyPaymentMethodMappingList.Count == 0 ? null : _oMonthlyPaymentMethodMappingList.ToArray();
        }
        
        public static List<MonthlyPaymentMethodMappingEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MonthlyPaymentMethodMappingEntity> _oRow = new List<MonthlyPaymentMethodMappingEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MonthlyPaymentMethodMapping].[cash_group] AS MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP,[MonthlyPaymentMethodMapping].[id] AS MONTHLYPAYMENTMETHODMAPPING_ID,[MonthlyPaymentMethodMapping].[active] AS MONTHLYPAYMENTMETHODMAPPING_ACTIVE,[MonthlyPaymentMethodMapping].[credit_card_group] AS MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP,[MonthlyPaymentMethodMapping].[payment_type] AS MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE,[MonthlyPaymentMethodMapping].[program] AS MONTHLYPAYMENTMETHODMAPPING_PROGRAM,[MonthlyPaymentMethodMapping].[issue_type] AS MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE,[MonthlyPaymentMethodMapping].[bank_account_group] AS MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP,[MonthlyPaymentMethodMapping].[third_party_credit_card] AS MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MonthlyPaymentMethodMappingRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MonthlyPaymentMethodMappingEntity _oMonthlyPaymentMethodMapping = MonthlyPaymentMethodMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"])) {_oMonthlyPaymentMethodMapping.cash_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP"]; } else {_oMonthlyPaymentMethodMapping.cash_group=null; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ID"])) {_oMonthlyPaymentMethodMapping.id = (global::System.Nullable<int>)_oData["MONTHLYPAYMENTMETHODMAPPING_ID"]; } else {_oMonthlyPaymentMethodMapping.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"])) {_oMonthlyPaymentMethodMapping.active = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_ACTIVE"]; } else {_oMonthlyPaymentMethodMapping.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"])) {_oMonthlyPaymentMethodMapping.credit_card_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP"]; } else {_oMonthlyPaymentMethodMapping.credit_card_group=null; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"])) {_oMonthlyPaymentMethodMapping.payment_type = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE"]; } else {_oMonthlyPaymentMethodMapping.payment_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"])) {_oMonthlyPaymentMethodMapping.program = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_PROGRAM"]; } else {_oMonthlyPaymentMethodMapping.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"])) {_oMonthlyPaymentMethodMapping.issue_type = (string)_oData["MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE"]; } else {_oMonthlyPaymentMethodMapping.issue_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"])) {_oMonthlyPaymentMethodMapping.third_party_credit_card = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD"]; } else {_oMonthlyPaymentMethodMapping.third_party_credit_card=null; }
                if (!global::System.Convert.IsDBNull(_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"])) {_oMonthlyPaymentMethodMapping.bank_account_group = (global::System.Nullable<bool>)_oData["MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP"]; } else {_oMonthlyPaymentMethodMapping.bank_account_group=null; }
                _oMonthlyPaymentMethodMapping.SetDB(x_oDB);
                _oMonthlyPaymentMethodMapping.GetFound();
                _oRow.Add(_oMonthlyPaymentMethodMapping);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MonthlyPaymentMethodMapping.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MonthlyPaymentMethodMapping.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MonthlyPaymentMethodMapping.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MonthlyPaymentMethodMapping.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MonthlyPaymentMethodMapping].[cash_group] AS MONTHLYPAYMENTMETHODMAPPING_CASH_GROUP,[MonthlyPaymentMethodMapping].[id] AS MONTHLYPAYMENTMETHODMAPPING_ID,[MonthlyPaymentMethodMapping].[active] AS MONTHLYPAYMENTMETHODMAPPING_ACTIVE,[MonthlyPaymentMethodMapping].[credit_card_group] AS MONTHLYPAYMENTMETHODMAPPING_CREDIT_CARD_GROUP,[MonthlyPaymentMethodMapping].[payment_type] AS MONTHLYPAYMENTMETHODMAPPING_PAYMENT_TYPE,[MonthlyPaymentMethodMapping].[program] AS MONTHLYPAYMENTMETHODMAPPING_PROGRAM,[MonthlyPaymentMethodMapping].[issue_type] AS MONTHLYPAYMENTMETHODMAPPING_ISSUE_TYPE,[MonthlyPaymentMethodMapping].[bank_account_group] AS MONTHLYPAYMENTMETHODMAPPING_BANK_ACCOUNT_GROUP,[MonthlyPaymentMethodMapping].[third_party_credit_card] AS MONTHLYPAYMENTMETHODMAPPING_THIRD_PARTY_CREDIT_CARD  FROM  [MonthlyPaymentMethodMapping]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MonthlyPaymentMethodMapping");
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
        
        public bool Insert(global::System.Nullable<bool> x_bCash_group,global::System.Nullable<bool> x_bActive,global::System.Nullable<bool> x_bCredit_card_group,string x_sPayment_type,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bThird_party_credit_card,global::System.Nullable<bool> x_bBank_account_group)
        {
            MonthlyPaymentMethodMapping _oMonthlyPaymentMethodMapping=MonthlyPaymentMethodMappingRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMonthlyPaymentMethodMapping.cash_group=x_bCash_group;
            _oMonthlyPaymentMethodMapping.active=x_bActive;
            _oMonthlyPaymentMethodMapping.credit_card_group=x_bCredit_card_group;
            _oMonthlyPaymentMethodMapping.payment_type=x_sPayment_type;
            _oMonthlyPaymentMethodMapping.program=x_sProgram;
            _oMonthlyPaymentMethodMapping.issue_type=x_sIssue_type;
            _oMonthlyPaymentMethodMapping.third_party_credit_card=x_bThird_party_credit_card;
            _oMonthlyPaymentMethodMapping.bank_account_group=x_bBank_account_group;
            return InsertWithOutLastID(n_oDB, _oMonthlyPaymentMethodMapping);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bCash_group,global::System.Nullable<bool> x_bActive,global::System.Nullable<bool> x_bCredit_card_group,string x_sPayment_type,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bThird_party_credit_card,global::System.Nullable<bool> x_bBank_account_group)
        {
            MonthlyPaymentMethodMapping _oMonthlyPaymentMethodMapping=MonthlyPaymentMethodMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMonthlyPaymentMethodMapping.cash_group=x_bCash_group;
            _oMonthlyPaymentMethodMapping.active=x_bActive;
            _oMonthlyPaymentMethodMapping.credit_card_group=x_bCredit_card_group;
            _oMonthlyPaymentMethodMapping.payment_type=x_sPayment_type;
            _oMonthlyPaymentMethodMapping.program=x_sProgram;
            _oMonthlyPaymentMethodMapping.issue_type=x_sIssue_type;
            _oMonthlyPaymentMethodMapping.third_party_credit_card=x_bThird_party_credit_card;
            _oMonthlyPaymentMethodMapping.bank_account_group=x_bBank_account_group;
            return InsertWithOutLastID(x_oDB, _oMonthlyPaymentMethodMapping);
        }
        
        
        public bool Insert(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            return InsertWithOutLastID(n_oDB, x_oMonthlyPaymentMethodMapping);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MonthlyPaymentMethodMapping)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MonthlyPaymentMethodMapping)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            return InsertWithOutLastID(x_oDB, x_oMonthlyPaymentMethodMapping);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MonthlyPaymentMethodMapping]   ([cash_group],[active],[credit_card_group],[payment_type],[program],[issue_type],[bank_account_group],[third_party_credit_card])  VALUES  (@cash_group,@active,@credit_card_group,@payment_type,@program,@issue_type,@bank_account_group,@third_party_credit_card)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMonthlyPaymentMethodMapping);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            bool _bResult = false;
            if (!x_oMonthlyPaymentMethodMapping.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMonthlyPaymentMethodMapping.cash_group==null){  x_oCmd.Parameters.Add("@cash_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cash_group", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.cash_group; }
                if(x_oMonthlyPaymentMethodMapping.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.active; }
                if(x_oMonthlyPaymentMethodMapping.credit_card_group==null){  x_oCmd.Parameters.Add("@credit_card_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@credit_card_group", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.credit_card_group; }
                if(x_oMonthlyPaymentMethodMapping.payment_type==null){  x_oCmd.Parameters.Add("@payment_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@payment_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMonthlyPaymentMethodMapping.payment_type; }
                if(x_oMonthlyPaymentMethodMapping.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMonthlyPaymentMethodMapping.program; }
                if(x_oMonthlyPaymentMethodMapping.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMonthlyPaymentMethodMapping.issue_type; }
                if(x_oMonthlyPaymentMethodMapping.bank_account_group==null){  x_oCmd.Parameters.Add("@bank_account_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_account_group", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.bank_account_group; }
                if(x_oMonthlyPaymentMethodMapping.third_party_credit_card==null){  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.third_party_credit_card; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bCash_group,global::System.Nullable<bool> x_bActive,global::System.Nullable<bool> x_bCredit_card_group,string x_sPayment_type,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bThird_party_credit_card,global::System.Nullable<bool> x_bBank_account_group)
        {
            int _oLastID;
            MonthlyPaymentMethodMapping _oMonthlyPaymentMethodMapping=MonthlyPaymentMethodMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMonthlyPaymentMethodMapping.cash_group=x_bCash_group;
            _oMonthlyPaymentMethodMapping.active=x_bActive;
            _oMonthlyPaymentMethodMapping.credit_card_group=x_bCredit_card_group;
            _oMonthlyPaymentMethodMapping.payment_type=x_sPayment_type;
            _oMonthlyPaymentMethodMapping.program=x_sProgram;
            _oMonthlyPaymentMethodMapping.issue_type=x_sIssue_type;
            _oMonthlyPaymentMethodMapping.third_party_credit_card=x_bThird_party_credit_card;
            _oMonthlyPaymentMethodMapping.bank_account_group=x_bBank_account_group;
            if(InsertWithLastID(x_oDB, _oMonthlyPaymentMethodMapping,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMonthlyPaymentMethodMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMonthlyPaymentMethodMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MonthlyPaymentMethodMapping)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MonthlyPaymentMethodMapping)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MonthlyPaymentMethodMapping]   ([cash_group],[active],[credit_card_group],[payment_type],[program],[issue_type],[bank_account_group],[third_party_credit_card])  VALUES  (@cash_group,@active,@credit_card_group,@payment_type,@program,@issue_type,@bank_account_group,@third_party_credit_card)"+" SELECT  @@IDENTITY AS MonthlyPaymentMethodMapping_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMonthlyPaymentMethodMapping,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMonthlyPaymentMethodMapping.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMonthlyPaymentMethodMapping.cash_group==null){  x_oCmd.Parameters.Add("@cash_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cash_group", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.cash_group; }
                if(x_oMonthlyPaymentMethodMapping.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.active; }
                if(x_oMonthlyPaymentMethodMapping.credit_card_group==null){  x_oCmd.Parameters.Add("@credit_card_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@credit_card_group", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.credit_card_group; }
                if(x_oMonthlyPaymentMethodMapping.payment_type==null){  x_oCmd.Parameters.Add("@payment_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@payment_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMonthlyPaymentMethodMapping.payment_type; }
                if(x_oMonthlyPaymentMethodMapping.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMonthlyPaymentMethodMapping.program; }
                if(x_oMonthlyPaymentMethodMapping.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMonthlyPaymentMethodMapping.issue_type; }
                if(x_oMonthlyPaymentMethodMapping.bank_account_group==null){  x_oCmd.Parameters.Add("@bank_account_group", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bank_account_group", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.bank_account_group; }
                if(x_oMonthlyPaymentMethodMapping.third_party_credit_card==null){  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.Bit).Value=x_oMonthlyPaymentMethodMapping.third_party_credit_card; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MonthlyPaymentMethodMapping_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MonthlyPaymentMethodMapping_LASTID"].ToString()) && int.TryParse(_oData["MonthlyPaymentMethodMapping_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bCash_group,global::System.Nullable<bool> x_bActive,global::System.Nullable<bool> x_bCredit_card_group,string x_sPayment_type,string x_sProgram,string x_sIssue_type,global::System.Nullable<bool> x_bThird_party_credit_card,global::System.Nullable<bool> x_bBank_account_group)
        {
            int _oLastID;
            MonthlyPaymentMethodMapping _oMonthlyPaymentMethodMapping=MonthlyPaymentMethodMappingRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMonthlyPaymentMethodMapping.cash_group=x_bCash_group;
            _oMonthlyPaymentMethodMapping.active=x_bActive;
            _oMonthlyPaymentMethodMapping.credit_card_group=x_bCredit_card_group;
            _oMonthlyPaymentMethodMapping.payment_type=x_sPayment_type;
            _oMonthlyPaymentMethodMapping.program=x_sProgram;
            _oMonthlyPaymentMethodMapping.issue_type=x_sIssue_type;
            _oMonthlyPaymentMethodMapping.third_party_credit_card=x_bThird_party_credit_card;
            _oMonthlyPaymentMethodMapping.bank_account_group=x_bBank_account_group;
            if(InsertWithLastID_SP(x_oDB, _oMonthlyPaymentMethodMapping,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMonthlyPaymentMethodMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMonthlyPaymentMethodMapping, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MonthlyPaymentMethodMapping)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MonthlyPaymentMethodMapping)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MONTHLYPAYMENTMETHODMAPPING";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMonthlyPaymentMethodMapping,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MonthlyPaymentMethodMapping x_oMonthlyPaymentMethodMapping, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cash_group", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.cash_group==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.cash_group; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.active; }
                _oPar=x_oCmd.Parameters.Add("@credit_card_group", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.credit_card_group==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.credit_card_group; }
                _oPar=x_oCmd.Parameters.Add("@payment_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.payment_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.payment_type; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.program; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@bank_account_group", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.bank_account_group==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.bank_account_group; }
                _oPar=x_oCmd.Parameters.Add("@third_party_credit_card", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMonthlyPaymentMethodMapping.third_party_credit_card==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMonthlyPaymentMethodMapping.third_party_credit_card; }
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
        
        #region INSERT_MONTHLYPAYMENTMETHODMAPPING Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-11-09>
        ///-- Description:	<Description,MONTHLYPAYMENTMETHODMAPPING, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MONTHLYPAYMENTMETHODMAPPING Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MONTHLYPAYMENTMETHODMAPPING', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MONTHLYPAYMENTMETHODMAPPING;
        GO
        CREATE PROCEDURE INSERT_MONTHLYPAYMENTMETHODMAPPING
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cash_group bit,
        @active bit,
        @credit_card_group bit,
        @payment_type nvarchar(50),
        @program nvarchar(50),
        @issue_type nvarchar(50),
        @third_party_credit_card bit,
        @bank_account_group bit
        AS
        
        INSERT INTO  [MonthlyPaymentMethodMapping]   ([cash_group],[active],[credit_card_group],[payment_type],[program],[issue_type],[bank_account_group],[third_party_credit_card])  VALUES  (@cash_group,@active,@credit_card_group,@payment_type,@program,@issue_type,@bank_account_group,@third_party_credit_card)
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
            string _sQuery = "DELETE FROM  [MonthlyPaymentMethodMapping]  WHERE [MonthlyPaymentMethodMapping].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
            return MonthlyPaymentMethodMappingRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MonthlyPaymentMethodMapping]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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
            string _sQuery = "DELETE FROM [MonthlyPaymentMethodMapping]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MonthlyPaymentMethodMapping]","["+ Configurator.MSSQLTablePrefix + "MonthlyPaymentMethodMapping]"); }
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


