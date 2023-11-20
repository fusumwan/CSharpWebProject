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
///-- Create date: <Create Date 2010-04-19>
///-- Description:	<Description,Table :[SpecialCustomer],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [SpecialCustomer] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"SpecialCustomer")]
    public class SpecialCustomerRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static SpecialCustomerRepositoryBase instance;
        public static SpecialCustomerRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr("MobileRetentionOrderDB");
                instance = new SpecialCustomerRepositoryBase(_oDB);
            }
            return instance;
        }
        public static SpecialCustomerRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new SpecialCustomerRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<SpecialCustomerEntity> SpecialCustomers;
        #endregion
        
        #region Constructor
        public SpecialCustomerRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~SpecialCustomerRepositoryBase() { 
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
        public static SpecialCustomer CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr("MobileRetentionOrderDB");
            return new SpecialCustomer(_oDB);
        }
        
        public static SpecialCustomer CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new SpecialCustomer(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [SpecialCustomer]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
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
        
        
        public SpecialCustomerEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static SpecialCustomerEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            SpecialCustomer _SpecialCustomer = (SpecialCustomer)SpecialCustomerRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_SpecialCustomer.Load(x_iId)) { return null; }
            return _SpecialCustomer;
        }
        
        
        
        public static SpecialCustomerEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<SpecialCustomerEntity> _oSpecialCustomerList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            return _oSpecialCustomerList.Count == 0 ? null : _oSpecialCustomerList.ToArray();
        }
        
        public static List<SpecialCustomerEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static SpecialCustomerEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SpecialCustomerEntity> _oSpecialCustomerList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oSpecialCustomerList.Count == 0 ? null : _oSpecialCustomerList.ToArray();
        }
        
        
        public static SpecialCustomerEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SpecialCustomerEntity> _oSpecialCustomerList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oSpecialCustomerList.Count == 0 ? null : _oSpecialCustomerList.ToArray();
        }
        
        public static List<SpecialCustomerEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<SpecialCustomerEntity> _oRow = new List<SpecialCustomerEntity>();
            string _sQuery = "SELECT  "+_sTop+" [SpecialCustomer].[cid] AS SPECIALCUSTOMER_CID,[SpecialCustomer].[id] AS SPECIALCUSTOMER_ID,[SpecialCustomer].[cdate] AS SPECIALCUSTOMER_CDATE,[SpecialCustomer].[condition1] AS SPECIALCUSTOMER_CONDITION1,[SpecialCustomer].[condition4] AS SPECIALCUSTOMER_CONDITION4,[SpecialCustomer].[status] AS SPECIALCUSTOMER_STATUS,[SpecialCustomer].[active] AS SPECIALCUSTOMER_ACTIVE,[SpecialCustomer].[condition3] AS SPECIALCUSTOMER_CONDITION3,[SpecialCustomer].[condition5] AS SPECIALCUSTOMER_CONDITION5,[SpecialCustomer].[hkid] AS SPECIALCUSTOMER_HKID,[SpecialCustomer].[ddate] AS SPECIALCUSTOMER_DDATE,[SpecialCustomer].[count] AS SPECIALCUSTOMER_COUNT,[SpecialCustomer].[did] AS SPECIALCUSTOMER_DID,[SpecialCustomer].[condition2] AS SPECIALCUSTOMER_CONDITION2  FROM  [SpecialCustomer]";
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
                _sQuery += " WHERE [SpecialCustomer].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        SpecialCustomer _oSpecialCustomer = SpecialCustomerRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ID"])) {_oSpecialCustomer.id = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_ID"]; }else{_oSpecialCustomer.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CDATE"])) {_oSpecialCustomer.cdate = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_CDATE"]; }else{_oSpecialCustomer.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CID"])) {_oSpecialCustomer.cid = (string)_oData["SPECIALCUSTOMER_CID"]; }else{_oSpecialCustomer.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION4"])) {_oSpecialCustomer.condition4 = (string)_oData["SPECIALCUSTOMER_CONDITION4"]; }else{_oSpecialCustomer.condition4=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_STATUS"])) {_oSpecialCustomer.status = (string)_oData["SPECIALCUSTOMER_STATUS"]; }else{_oSpecialCustomer.status=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ACTIVE"])) {_oSpecialCustomer.active = (global::System.Nullable<bool>)_oData["SPECIALCUSTOMER_ACTIVE"]; }else{_oSpecialCustomer.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION3"])) {_oSpecialCustomer.condition3 = (string)_oData["SPECIALCUSTOMER_CONDITION3"]; }else{_oSpecialCustomer.condition3=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION5"])) {_oSpecialCustomer.condition5 = (string)_oData["SPECIALCUSTOMER_CONDITION5"]; }else{_oSpecialCustomer.condition5=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_HKID"])) {_oSpecialCustomer.hkid = (string)_oData["SPECIALCUSTOMER_HKID"]; }else{_oSpecialCustomer.hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION1"])) {_oSpecialCustomer.condition1 = (string)_oData["SPECIALCUSTOMER_CONDITION1"]; }else{_oSpecialCustomer.condition1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DDATE"])) {_oSpecialCustomer.ddate = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_DDATE"]; }else{_oSpecialCustomer.ddate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_COUNT"])) {_oSpecialCustomer.count = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_COUNT"]; }else{_oSpecialCustomer.count=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DID"])) {_oSpecialCustomer.did = (string)_oData["SPECIALCUSTOMER_DID"]; }else{_oSpecialCustomer.did=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION2"])) {_oSpecialCustomer.condition2 = (string)_oData["SPECIALCUSTOMER_CONDITION2"]; }else{_oSpecialCustomer.condition2=global::System.String.Empty;}
                        _oSpecialCustomer.SetDB(x_oDB);
                        _oSpecialCustomer.GetFound();
                        _oRow.Add(_oSpecialCustomer);
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
        
        
        public static SpecialCustomerEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SpecialCustomerEntity> _oSpecialCustomerList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSpecialCustomerList.Count == 0 ? null : _oSpecialCustomerList.ToArray();
        }
        
        
        public static SpecialCustomerEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SpecialCustomerEntity> _oSpecialCustomerList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSpecialCustomerList.Count == 0 ? null : _oSpecialCustomerList.ToArray();
        }
        
        public static List<SpecialCustomerEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<SpecialCustomerEntity> _oRow = new List<SpecialCustomerEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[SpecialCustomer].[cid] AS SPECIALCUSTOMER_CID,[SpecialCustomer].[id] AS SPECIALCUSTOMER_ID,[SpecialCustomer].[cdate] AS SPECIALCUSTOMER_CDATE,[SpecialCustomer].[condition1] AS SPECIALCUSTOMER_CONDITION1,[SpecialCustomer].[condition4] AS SPECIALCUSTOMER_CONDITION4,[SpecialCustomer].[status] AS SPECIALCUSTOMER_STATUS,[SpecialCustomer].[active] AS SPECIALCUSTOMER_ACTIVE,[SpecialCustomer].[condition3] AS SPECIALCUSTOMER_CONDITION3,[SpecialCustomer].[condition5] AS SPECIALCUSTOMER_CONDITION5,[SpecialCustomer].[hkid] AS SPECIALCUSTOMER_HKID,[SpecialCustomer].[ddate] AS SPECIALCUSTOMER_DDATE,[SpecialCustomer].[count] AS SPECIALCUSTOMER_COUNT,[SpecialCustomer].[did] AS SPECIALCUSTOMER_DID,[SpecialCustomer].[condition2] AS SPECIALCUSTOMER_CONDITION2";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = SpecialCustomerRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                SpecialCustomerEntity _oSpecialCustomer = SpecialCustomerRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ID"])) {_oSpecialCustomer.id = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_ID"]; } else {_oSpecialCustomer.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CDATE"])) {_oSpecialCustomer.cdate = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_CDATE"]; } else {_oSpecialCustomer.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CID"])) {_oSpecialCustomer.cid = (string)_oData["SPECIALCUSTOMER_CID"]; } else {_oSpecialCustomer.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION4"])) {_oSpecialCustomer.condition4 = (string)_oData["SPECIALCUSTOMER_CONDITION4"]; } else {_oSpecialCustomer.condition4=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_STATUS"])) {_oSpecialCustomer.status = (string)_oData["SPECIALCUSTOMER_STATUS"]; } else {_oSpecialCustomer.status=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_ACTIVE"])) {_oSpecialCustomer.active = (global::System.Nullable<bool>)_oData["SPECIALCUSTOMER_ACTIVE"]; } else {_oSpecialCustomer.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION3"])) {_oSpecialCustomer.condition3 = (string)_oData["SPECIALCUSTOMER_CONDITION3"]; } else {_oSpecialCustomer.condition3=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION5"])) {_oSpecialCustomer.condition5 = (string)_oData["SPECIALCUSTOMER_CONDITION5"]; } else {_oSpecialCustomer.condition5=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_HKID"])) {_oSpecialCustomer.hkid = (string)_oData["SPECIALCUSTOMER_HKID"]; } else {_oSpecialCustomer.hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION1"])) {_oSpecialCustomer.condition1 = (string)_oData["SPECIALCUSTOMER_CONDITION1"]; } else {_oSpecialCustomer.condition1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DDATE"])) {_oSpecialCustomer.ddate = (global::System.Nullable<DateTime>)_oData["SPECIALCUSTOMER_DDATE"]; } else {_oSpecialCustomer.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_COUNT"])) {_oSpecialCustomer.count = (global::System.Nullable<int>)_oData["SPECIALCUSTOMER_COUNT"]; } else {_oSpecialCustomer.count=null; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_DID"])) {_oSpecialCustomer.did = (string)_oData["SPECIALCUSTOMER_DID"]; } else {_oSpecialCustomer.did=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SPECIALCUSTOMER_CONDITION2"])) {_oSpecialCustomer.condition2 = (string)_oData["SPECIALCUSTOMER_CONDITION2"]; } else {_oSpecialCustomer.condition2=global::System.String.Empty; }
                _oSpecialCustomer.SetDB(x_oDB);
                _oSpecialCustomer.GetFound();
                _oRow.Add(_oSpecialCustomer);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( SpecialCustomer.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,SpecialCustomer.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(SpecialCustomer.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(SpecialCustomer.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [SpecialCustomer].[cid] AS SPECIALCUSTOMER_CID,[SpecialCustomer].[id] AS SPECIALCUSTOMER_ID,[SpecialCustomer].[cdate] AS SPECIALCUSTOMER_CDATE,[SpecialCustomer].[condition1] AS SPECIALCUSTOMER_CONDITION1,[SpecialCustomer].[condition4] AS SPECIALCUSTOMER_CONDITION4,[SpecialCustomer].[status] AS SPECIALCUSTOMER_STATUS,[SpecialCustomer].[active] AS SPECIALCUSTOMER_ACTIVE,[SpecialCustomer].[condition3] AS SPECIALCUSTOMER_CONDITION3,[SpecialCustomer].[condition5] AS SPECIALCUSTOMER_CONDITION5,[SpecialCustomer].[hkid] AS SPECIALCUSTOMER_HKID,[SpecialCustomer].[ddate] AS SPECIALCUSTOMER_DDATE,[SpecialCustomer].[count] AS SPECIALCUSTOMER_COUNT,[SpecialCustomer].[did] AS SPECIALCUSTOMER_DID,[SpecialCustomer].[condition2] AS SPECIALCUSTOMER_CONDITION2  FROM  [SpecialCustomer]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"SpecialCustomer");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sCondition4,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sCondition3,string x_sCondition5,string x_sHkid,string x_sCondition1,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<int> x_iCount,string x_sDid,string x_sCondition2)
        {
            SpecialCustomer _oSpecialCustomer=SpecialCustomerRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oSpecialCustomer.cdate=x_dCdate;
            _oSpecialCustomer.cid=x_sCid;
            _oSpecialCustomer.condition4=x_sCondition4;
            _oSpecialCustomer.status=x_sStatus;
            _oSpecialCustomer.active=x_bActive;
            _oSpecialCustomer.condition3=x_sCondition3;
            _oSpecialCustomer.condition5=x_sCondition5;
            _oSpecialCustomer.hkid=x_sHkid;
            _oSpecialCustomer.condition1=x_sCondition1;
            _oSpecialCustomer.ddate=x_dDdate;
            _oSpecialCustomer.count=x_iCount;
            _oSpecialCustomer.did=x_sDid;
            _oSpecialCustomer.condition2=x_sCondition2;
            return InsertWithOutLastID(n_oDB, _oSpecialCustomer);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sCondition4,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sCondition3,string x_sCondition5,string x_sHkid,string x_sCondition1,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<int> x_iCount,string x_sDid,string x_sCondition2)
        {
            SpecialCustomer _oSpecialCustomer=SpecialCustomerRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSpecialCustomer.cdate=x_dCdate;
            _oSpecialCustomer.cid=x_sCid;
            _oSpecialCustomer.condition4=x_sCondition4;
            _oSpecialCustomer.status=x_sStatus;
            _oSpecialCustomer.active=x_bActive;
            _oSpecialCustomer.condition3=x_sCondition3;
            _oSpecialCustomer.condition5=x_sCondition5;
            _oSpecialCustomer.hkid=x_sHkid;
            _oSpecialCustomer.condition1=x_sCondition1;
            _oSpecialCustomer.ddate=x_dDdate;
            _oSpecialCustomer.count=x_iCount;
            _oSpecialCustomer.did=x_sDid;
            _oSpecialCustomer.condition2=x_sCondition2;
            return InsertWithOutLastID(x_oDB, _oSpecialCustomer);
        }
        
        
        public bool Insert(SpecialCustomer x_oSpecialCustomer)
        {
            return InsertWithOutLastID(n_oDB, x_oSpecialCustomer);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is SpecialCustomer)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (SpecialCustomer)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,SpecialCustomer x_oSpecialCustomer)
        {
            return InsertWithOutLastID(x_oDB, x_oSpecialCustomer);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,SpecialCustomer x_oSpecialCustomer)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [SpecialCustomer]   ([cid],[cdate],[condition1],[condition4],[status],[active],[condition3],[condition5],[hkid],[ddate],[count],[did],[condition2])  VALUES  (@cid,@cdate,@condition1,@condition4,@status,@active,@condition3,@condition5,@hkid,@ddate,@count,@did,@condition2)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oSpecialCustomer);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,SpecialCustomer x_oSpecialCustomer)
        {
            bool _bResult = false;
            if (!x_oSpecialCustomer.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oSpecialCustomer.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.cid; }
                if(x_oSpecialCustomer.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oSpecialCustomer.cdate; }
                if(x_oSpecialCustomer.condition1==null){  x_oCmd.Parameters.Add("@condition1", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition1", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition1; }
                if(x_oSpecialCustomer.condition4==null){  x_oCmd.Parameters.Add("@condition4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition4; }
                if(x_oSpecialCustomer.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.status; }
                if(x_oSpecialCustomer.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oSpecialCustomer.active; }
                if(x_oSpecialCustomer.condition3==null){  x_oCmd.Parameters.Add("@condition3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition3; }
                if(x_oSpecialCustomer.condition5==null){  x_oCmd.Parameters.Add("@condition5", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition5", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition5; }
                if(x_oSpecialCustomer.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.hkid; }
                if(x_oSpecialCustomer.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oSpecialCustomer.ddate; }
                if(x_oSpecialCustomer.count==null){  x_oCmd.Parameters.Add("@count", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@count", global::System.Data.SqlDbType.Int).Value=x_oSpecialCustomer.count; }
                if(x_oSpecialCustomer.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.did; }
                if(x_oSpecialCustomer.condition2==null){  x_oCmd.Parameters.Add("@condition2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition2; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sCondition4,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sCondition3,string x_sCondition5,string x_sHkid,string x_sCondition1,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<int> x_iCount,string x_sDid,string x_sCondition2)
        {
            int _oLastID;
            SpecialCustomer _oSpecialCustomer=SpecialCustomerRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSpecialCustomer.cdate=x_dCdate;
            _oSpecialCustomer.cid=x_sCid;
            _oSpecialCustomer.condition4=x_sCondition4;
            _oSpecialCustomer.status=x_sStatus;
            _oSpecialCustomer.active=x_bActive;
            _oSpecialCustomer.condition3=x_sCondition3;
            _oSpecialCustomer.condition5=x_sCondition5;
            _oSpecialCustomer.hkid=x_sHkid;
            _oSpecialCustomer.condition1=x_sCondition1;
            _oSpecialCustomer.ddate=x_dDdate;
            _oSpecialCustomer.count=x_iCount;
            _oSpecialCustomer.did=x_sDid;
            _oSpecialCustomer.condition2=x_sCondition2;
            if(InsertWithLastID(x_oDB, _oSpecialCustomer,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(SpecialCustomer x_oSpecialCustomer)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oSpecialCustomer, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, SpecialCustomer x_oSpecialCustomer)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oSpecialCustomer, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is SpecialCustomer)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (SpecialCustomer)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,SpecialCustomer x_oSpecialCustomer, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [SpecialCustomer]   ([cid],[cdate],[condition1],[condition4],[status],[active],[condition3],[condition5],[hkid],[ddate],[count],[did],[condition2])  VALUES  (@cid,@cdate,@condition1,@condition4,@status,@active,@condition3,@condition5,@hkid,@ddate,@count,@did,@condition2)"+" SELECT  @@IDENTITY AS SpecialCustomer_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oSpecialCustomer,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,SpecialCustomer x_oSpecialCustomer, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oSpecialCustomer.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oSpecialCustomer.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.cid; }
                if(x_oSpecialCustomer.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oSpecialCustomer.cdate; }
                if(x_oSpecialCustomer.condition1==null){  x_oCmd.Parameters.Add("@condition1", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition1", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition1; }
                if(x_oSpecialCustomer.condition4==null){  x_oCmd.Parameters.Add("@condition4", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition4", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition4; }
                if(x_oSpecialCustomer.status==null){  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.status; }
                if(x_oSpecialCustomer.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oSpecialCustomer.active; }
                if(x_oSpecialCustomer.condition3==null){  x_oCmd.Parameters.Add("@condition3", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition3", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition3; }
                if(x_oSpecialCustomer.condition5==null){  x_oCmd.Parameters.Add("@condition5", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition5", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition5; }
                if(x_oSpecialCustomer.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.hkid; }
                if(x_oSpecialCustomer.ddate==null){  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oSpecialCustomer.ddate; }
                if(x_oSpecialCustomer.count==null){  x_oCmd.Parameters.Add("@count", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@count", global::System.Data.SqlDbType.Int).Value=x_oSpecialCustomer.count; }
                if(x_oSpecialCustomer.did==null){  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.did; }
                if(x_oSpecialCustomer.condition2==null){  x_oCmd.Parameters.Add("@condition2", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@condition2", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSpecialCustomer.condition2; }
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["SpecialCustomer_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["SpecialCustomer_LASTID"].ToString()) && int.TryParse(_oData["SpecialCustomer_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sCondition4,string x_sStatus,global::System.Nullable<bool> x_bActive,string x_sCondition3,string x_sCondition5,string x_sHkid,string x_sCondition1,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<int> x_iCount,string x_sDid,string x_sCondition2)
        {
            int _oLastID;
            SpecialCustomer _oSpecialCustomer=SpecialCustomerRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSpecialCustomer.cdate=x_dCdate;
            _oSpecialCustomer.cid=x_sCid;
            _oSpecialCustomer.condition4=x_sCondition4;
            _oSpecialCustomer.status=x_sStatus;
            _oSpecialCustomer.active=x_bActive;
            _oSpecialCustomer.condition3=x_sCondition3;
            _oSpecialCustomer.condition5=x_sCondition5;
            _oSpecialCustomer.hkid=x_sHkid;
            _oSpecialCustomer.condition1=x_sCondition1;
            _oSpecialCustomer.ddate=x_dDdate;
            _oSpecialCustomer.count=x_iCount;
            _oSpecialCustomer.did=x_sDid;
            _oSpecialCustomer.condition2=x_sCondition2;
            if(InsertWithLastID_SP(x_oDB, _oSpecialCustomer,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(SpecialCustomer x_oSpecialCustomer)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oSpecialCustomer, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, SpecialCustomer x_oSpecialCustomer)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oSpecialCustomer, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is SpecialCustomer)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (SpecialCustomer)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,SpecialCustomer x_oSpecialCustomer, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "SPECIALCUSTOMER";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oSpecialCustomer,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,SpecialCustomer x_oSpecialCustomer, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.cid; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oSpecialCustomer.cdate; }
                _oPar=x_oCmd.Parameters.Add("@condition1", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.condition1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.condition1; }
                _oPar=x_oCmd.Parameters.Add("@condition4", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.condition4==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.condition4; }
                _oPar=x_oCmd.Parameters.Add("@status", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.status==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.status; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.active; }
                _oPar=x_oCmd.Parameters.Add("@condition3", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.condition3==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.condition3; }
                _oPar=x_oCmd.Parameters.Add("@condition5", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.condition5==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.condition5; }
                _oPar=x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.hkid; }
                _oPar=x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.ddate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oSpecialCustomer.ddate; }
                _oPar=x_oCmd.Parameters.Add("@count", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.count==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.count; }
                _oPar=x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.did==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.did; }
                _oPar=x_oCmd.Parameters.Add("@condition2", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oSpecialCustomer.condition2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oSpecialCustomer.condition2; }
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
        
        #region INSERT_SPECIALCUSTOMER Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2010-04-19>
        ///-- Description:	<Description,SPECIALCUSTOMER, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_SPECIALCUSTOMER Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB
        GO
        IF OBJECT_ID ( 'INSERT_SPECIALCUSTOMER', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_SPECIALCUSTOMER;
        GO
        CREATE PROCEDURE INSERT_SPECIALCUSTOMER
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @condition4 nvarchar(50),
        @status nvarchar(50),
        @active bit,
        @condition3 nvarchar(50),
        @condition5 nvarchar(50),
        @hkid nvarchar(50),
        @condition1 nvarchar(50),
        @ddate datetime,
        @count int,
        @did nvarchar(50),
        @condition2 nvarchar(50)
        AS
        
        INSERT INTO  [SpecialCustomer]   ([cid],[cdate],[condition1],[condition4],[status],[active],[condition3],[condition5],[hkid],[ddate],[count],[did],[condition2])  VALUES  (@cid,@cdate,@condition1,@condition4,@status,@active,@condition3,@condition5,@hkid,@ddate,@count,@did,@condition2)
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
            string _sQuery = "DELETE FROM  [SpecialCustomer]  WHERE [SpecialCustomer].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return SpecialCustomerRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [SpecialCustomer]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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
            string _sQuery = "DELETE FROM [SpecialCustomer]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[SpecialCustomer]","["+ Configurator.MSSQLTablePrefix + "SpecialCustomer]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
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


