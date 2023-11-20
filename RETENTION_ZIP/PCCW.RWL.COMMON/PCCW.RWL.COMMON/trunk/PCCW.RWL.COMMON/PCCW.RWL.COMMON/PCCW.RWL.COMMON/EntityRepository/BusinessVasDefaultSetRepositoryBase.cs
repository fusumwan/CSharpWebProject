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
///-- Create date: <Create Date 2011-07-15>
///-- Description:	<Description,Table :[BusinessVasDefaultSet],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [BusinessVasDefaultSet] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"BusinessVasDefaultSet")]
    public class BusinessVasDefaultSetRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static BusinessVasDefaultSetRepositoryBase instance;
        public static BusinessVasDefaultSetRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new BusinessVasDefaultSetRepositoryBase(_oDB);
            }
            return instance;
        }
        public static BusinessVasDefaultSetRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new BusinessVasDefaultSetRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<BusinessVasDefaultSetEntity> BusinessVasDefaultSets;
        #endregion
        
        #region Constructor
        public BusinessVasDefaultSetRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~BusinessVasDefaultSetRepositoryBase() { 
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
        public static BusinessVasDefaultSet CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new BusinessVasDefaultSet(_oDB);
        }
        
        public static BusinessVasDefaultSet CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new BusinessVasDefaultSet(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [BusinessVasDefaultSet]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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
        
        
        public BusinessVasDefaultSetEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }
        
        
        public static BusinessVasDefaultSetEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            if (x_oDB==null) { return null; }
            BusinessVasDefaultSet _BusinessVasDefaultSet = (BusinessVasDefaultSet)BusinessVasDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_BusinessVasDefaultSet.Load(x_iMid)) { return null; }
            return _BusinessVasDefaultSet;
        }
        
        
        
        public static BusinessVasDefaultSetEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oBusinessVasDefaultSetList==null){ return null;}
            return _oBusinessVasDefaultSetList.Count == 0 ? null : _oBusinessVasDefaultSetList.ToArray();
        }
        
        public static List<BusinessVasDefaultSetEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static BusinessVasDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oBusinessVasDefaultSetList==null){ return null;}
            return _oBusinessVasDefaultSetList.Count == 0 ? null : _oBusinessVasDefaultSetList.ToArray();
        }
        
        
        public static BusinessVasDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oBusinessVasDefaultSetList==null){ return null;}
            return _oBusinessVasDefaultSetList.Count == 0 ? null : _oBusinessVasDefaultSetList.ToArray();
        }
        
        public static List<BusinessVasDefaultSetEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<BusinessVasDefaultSetEntity> _oRow = new List<BusinessVasDefaultSetEntity>();
            string _sQuery = "SELECT  "+_sTop+" [BusinessVasDefaultSet].[display2] AS BUSINESSVASDEFAULTSET_DISPLAY2,[BusinessVasDefaultSet].[mid] AS BUSINESSVASDEFAULTSET_MID,[BusinessVasDefaultSet].[cdate] AS BUSINESSVASDEFAULTSET_CDATE,[BusinessVasDefaultSet].[cid] AS BUSINESSVASDEFAULTSET_CID,[BusinessVasDefaultSet].[bundle_name] AS BUSINESSVASDEFAULTSET_BUNDLE_NAME,[BusinessVasDefaultSet].[value2] AS BUSINESSVASDEFAULTSET_VALUE2,[BusinessVasDefaultSet].[trade_field] AS BUSINESSVASDEFAULTSET_TRADE_FIELD,[BusinessVasDefaultSet].[value1] AS BUSINESSVASDEFAULTSET_VALUE1,[BusinessVasDefaultSet].[program] AS BUSINESSVASDEFAULTSET_PROGRAM,[BusinessVasDefaultSet].[edate] AS BUSINESSVASDEFAULTSET_EDATE,[BusinessVasDefaultSet].[active] AS BUSINESSVASDEFAULTSET_ACTIVE,[BusinessVasDefaultSet].[con_per] AS BUSINESSVASDEFAULTSET_CON_PER,[BusinessVasDefaultSet].[display1] AS BUSINESSVASDEFAULTSET_DISPLAY1,[BusinessVasDefaultSet].[enabled2] AS BUSINESSVASDEFAULTSET_ENABLED2,[BusinessVasDefaultSet].[vas2] AS BUSINESSVASDEFAULTSET_VAS2,[BusinessVasDefaultSet].[rate_plan] AS BUSINESSVASDEFAULTSET_RATE_PLAN,[BusinessVasDefaultSet].[enabled1] AS BUSINESSVASDEFAULTSET_ENABLED1,[BusinessVasDefaultSet].[hs_model] AS BUSINESSVASDEFAULTSET_HS_MODEL,[BusinessVasDefaultSet].[vas1] AS BUSINESSVASDEFAULTSET_VAS1,[BusinessVasDefaultSet].[issue_type] AS BUSINESSVASDEFAULTSET_ISSUE_TYPE  FROM  [BusinessVasDefaultSet]";
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
                _sQuery += " WHERE [BusinessVasDefaultSet].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        BusinessVasDefaultSet _oBusinessVasDefaultSet = BusinessVasDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY2"])) {_oBusinessVasDefaultSet.display2 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY2"]; }else{_oBusinessVasDefaultSet.display2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_MID"])) {_oBusinessVasDefaultSet.mid = (global::System.Nullable<int>)_oData["BUSINESSVASDEFAULTSET_MID"]; }else{_oBusinessVasDefaultSet.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CDATE"])) {_oBusinessVasDefaultSet.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_CDATE"]; }else{_oBusinessVasDefaultSet.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"])) {_oBusinessVasDefaultSet.bundle_name = (string)_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"]; }else{_oBusinessVasDefaultSet.bundle_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE2"])) {_oBusinessVasDefaultSet.value2 = (string)_oData["BUSINESSVASDEFAULTSET_VALUE2"]; }else{_oBusinessVasDefaultSet.value2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CID"])) {_oBusinessVasDefaultSet.cid = (string)_oData["BUSINESSVASDEFAULTSET_CID"]; }else{_oBusinessVasDefaultSet.cid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE1"])) {_oBusinessVasDefaultSet.value1 = (string)_oData["BUSINESSVASDEFAULTSET_VALUE1"]; }else{_oBusinessVasDefaultSet.value1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_PROGRAM"])) {_oBusinessVasDefaultSet.program = (string)_oData["BUSINESSVASDEFAULTSET_PROGRAM"]; }else{_oBusinessVasDefaultSet.program=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_EDATE"])) {_oBusinessVasDefaultSet.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_EDATE"]; }else{_oBusinessVasDefaultSet.edate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ACTIVE"])) {_oBusinessVasDefaultSet.active = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ACTIVE"]; }else{_oBusinessVasDefaultSet.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"])) {_oBusinessVasDefaultSet.trade_field = (string)_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"]; }else{_oBusinessVasDefaultSet.trade_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CON_PER"])) {_oBusinessVasDefaultSet.con_per = (string)_oData["BUSINESSVASDEFAULTSET_CON_PER"]; }else{_oBusinessVasDefaultSet.con_per=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY1"])) {_oBusinessVasDefaultSet.display1 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY1"]; }else{_oBusinessVasDefaultSet.display1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED2"])) {_oBusinessVasDefaultSet.enabled2 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED2"]; }else{_oBusinessVasDefaultSet.enabled2=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS2"])) {_oBusinessVasDefaultSet.vas2 = (string)_oData["BUSINESSVASDEFAULTSET_VAS2"]; }else{_oBusinessVasDefaultSet.vas2=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"])) {_oBusinessVasDefaultSet.rate_plan = (string)_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"]; }else{_oBusinessVasDefaultSet.rate_plan=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED1"])) {_oBusinessVasDefaultSet.enabled1 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED1"]; }else{_oBusinessVasDefaultSet.enabled1=null;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_HS_MODEL"])) {_oBusinessVasDefaultSet.hs_model = (string)_oData["BUSINESSVASDEFAULTSET_HS_MODEL"]; }else{_oBusinessVasDefaultSet.hs_model=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS1"])) {_oBusinessVasDefaultSet.vas1 = (string)_oData["BUSINESSVASDEFAULTSET_VAS1"]; }else{_oBusinessVasDefaultSet.vas1=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"])) {_oBusinessVasDefaultSet.issue_type = (string)_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"]; }else{_oBusinessVasDefaultSet.issue_type=global::System.String.Empty;}
                        _oBusinessVasDefaultSet.SetDB(x_oDB);
                        _oBusinessVasDefaultSet.GetFound();
                        _oRow.Add(_oBusinessVasDefaultSet);
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
        
        
        public static BusinessVasDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessVasDefaultSetList==null){ return null;}
            return _oBusinessVasDefaultSetList.Count == 0 ? null : _oBusinessVasDefaultSetList.ToArray();
        }
        
        
        public static BusinessVasDefaultSetEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oBusinessVasDefaultSetList==null){ return null;}
            return _oBusinessVasDefaultSetList.Count == 0 ? null : _oBusinessVasDefaultSetList.ToArray();
        }
        
        public static List<BusinessVasDefaultSetEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<BusinessVasDefaultSetEntity> _oRow = new List<BusinessVasDefaultSetEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[BusinessVasDefaultSet].[display2] AS BUSINESSVASDEFAULTSET_DISPLAY2,[BusinessVasDefaultSet].[mid] AS BUSINESSVASDEFAULTSET_MID,[BusinessVasDefaultSet].[cdate] AS BUSINESSVASDEFAULTSET_CDATE,[BusinessVasDefaultSet].[cid] AS BUSINESSVASDEFAULTSET_CID,[BusinessVasDefaultSet].[bundle_name] AS BUSINESSVASDEFAULTSET_BUNDLE_NAME,[BusinessVasDefaultSet].[value2] AS BUSINESSVASDEFAULTSET_VALUE2,[BusinessVasDefaultSet].[trade_field] AS BUSINESSVASDEFAULTSET_TRADE_FIELD,[BusinessVasDefaultSet].[value1] AS BUSINESSVASDEFAULTSET_VALUE1,[BusinessVasDefaultSet].[program] AS BUSINESSVASDEFAULTSET_PROGRAM,[BusinessVasDefaultSet].[edate] AS BUSINESSVASDEFAULTSET_EDATE,[BusinessVasDefaultSet].[active] AS BUSINESSVASDEFAULTSET_ACTIVE,[BusinessVasDefaultSet].[con_per] AS BUSINESSVASDEFAULTSET_CON_PER,[BusinessVasDefaultSet].[display1] AS BUSINESSVASDEFAULTSET_DISPLAY1,[BusinessVasDefaultSet].[enabled2] AS BUSINESSVASDEFAULTSET_ENABLED2,[BusinessVasDefaultSet].[vas2] AS BUSINESSVASDEFAULTSET_VAS2,[BusinessVasDefaultSet].[rate_plan] AS BUSINESSVASDEFAULTSET_RATE_PLAN,[BusinessVasDefaultSet].[enabled1] AS BUSINESSVASDEFAULTSET_ENABLED1,[BusinessVasDefaultSet].[hs_model] AS BUSINESSVASDEFAULTSET_HS_MODEL,[BusinessVasDefaultSet].[vas1] AS BUSINESSVASDEFAULTSET_VAS1,[BusinessVasDefaultSet].[issue_type] AS BUSINESSVASDEFAULTSET_ISSUE_TYPE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = BusinessVasDefaultSetRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                BusinessVasDefaultSetEntity _oBusinessVasDefaultSet = BusinessVasDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY2"])) {_oBusinessVasDefaultSet.display2 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY2"]; } else {_oBusinessVasDefaultSet.display2=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_MID"])) {_oBusinessVasDefaultSet.mid = (global::System.Nullable<int>)_oData["BUSINESSVASDEFAULTSET_MID"]; } else {_oBusinessVasDefaultSet.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CDATE"])) {_oBusinessVasDefaultSet.cdate = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_CDATE"]; } else {_oBusinessVasDefaultSet.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"])) {_oBusinessVasDefaultSet.bundle_name = (string)_oData["BUSINESSVASDEFAULTSET_BUNDLE_NAME"]; } else {_oBusinessVasDefaultSet.bundle_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE2"])) {_oBusinessVasDefaultSet.value2 = (string)_oData["BUSINESSVASDEFAULTSET_VALUE2"]; } else {_oBusinessVasDefaultSet.value2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CID"])) {_oBusinessVasDefaultSet.cid = (string)_oData["BUSINESSVASDEFAULTSET_CID"]; } else {_oBusinessVasDefaultSet.cid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VALUE1"])) {_oBusinessVasDefaultSet.value1 = (string)_oData["BUSINESSVASDEFAULTSET_VALUE1"]; } else {_oBusinessVasDefaultSet.value1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_PROGRAM"])) {_oBusinessVasDefaultSet.program = (string)_oData["BUSINESSVASDEFAULTSET_PROGRAM"]; } else {_oBusinessVasDefaultSet.program=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_EDATE"])) {_oBusinessVasDefaultSet.edate = (global::System.Nullable<DateTime>)_oData["BUSINESSVASDEFAULTSET_EDATE"]; } else {_oBusinessVasDefaultSet.edate=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ACTIVE"])) {_oBusinessVasDefaultSet.active = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ACTIVE"]; } else {_oBusinessVasDefaultSet.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"])) {_oBusinessVasDefaultSet.trade_field = (string)_oData["BUSINESSVASDEFAULTSET_TRADE_FIELD"]; } else {_oBusinessVasDefaultSet.trade_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_CON_PER"])) {_oBusinessVasDefaultSet.con_per = (string)_oData["BUSINESSVASDEFAULTSET_CON_PER"]; } else {_oBusinessVasDefaultSet.con_per=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_DISPLAY1"])) {_oBusinessVasDefaultSet.display1 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_DISPLAY1"]; } else {_oBusinessVasDefaultSet.display1=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED2"])) {_oBusinessVasDefaultSet.enabled2 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED2"]; } else {_oBusinessVasDefaultSet.enabled2=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS2"])) {_oBusinessVasDefaultSet.vas2 = (string)_oData["BUSINESSVASDEFAULTSET_VAS2"]; } else {_oBusinessVasDefaultSet.vas2=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"])) {_oBusinessVasDefaultSet.rate_plan = (string)_oData["BUSINESSVASDEFAULTSET_RATE_PLAN"]; } else {_oBusinessVasDefaultSet.rate_plan=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ENABLED1"])) {_oBusinessVasDefaultSet.enabled1 = (global::System.Nullable<bool>)_oData["BUSINESSVASDEFAULTSET_ENABLED1"]; } else {_oBusinessVasDefaultSet.enabled1=null; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_HS_MODEL"])) {_oBusinessVasDefaultSet.hs_model = (string)_oData["BUSINESSVASDEFAULTSET_HS_MODEL"]; } else {_oBusinessVasDefaultSet.hs_model=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_VAS1"])) {_oBusinessVasDefaultSet.vas1 = (string)_oData["BUSINESSVASDEFAULTSET_VAS1"]; } else {_oBusinessVasDefaultSet.vas1=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"])) {_oBusinessVasDefaultSet.issue_type = (string)_oData["BUSINESSVASDEFAULTSET_ISSUE_TYPE"]; } else {_oBusinessVasDefaultSet.issue_type=global::System.String.Empty; }
                _oBusinessVasDefaultSet.SetDB(x_oDB);
                _oBusinessVasDefaultSet.GetFound();
                _oRow.Add(_oBusinessVasDefaultSet);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( BusinessVasDefaultSet.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,BusinessVasDefaultSet.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(BusinessVasDefaultSet.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(BusinessVasDefaultSet.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [BusinessVasDefaultSet].[display2] AS BUSINESSVASDEFAULTSET_DISPLAY2,[BusinessVasDefaultSet].[mid] AS BUSINESSVASDEFAULTSET_MID,[BusinessVasDefaultSet].[cdate] AS BUSINESSVASDEFAULTSET_CDATE,[BusinessVasDefaultSet].[cid] AS BUSINESSVASDEFAULTSET_CID,[BusinessVasDefaultSet].[bundle_name] AS BUSINESSVASDEFAULTSET_BUNDLE_NAME,[BusinessVasDefaultSet].[value2] AS BUSINESSVASDEFAULTSET_VALUE2,[BusinessVasDefaultSet].[trade_field] AS BUSINESSVASDEFAULTSET_TRADE_FIELD,[BusinessVasDefaultSet].[value1] AS BUSINESSVASDEFAULTSET_VALUE1,[BusinessVasDefaultSet].[program] AS BUSINESSVASDEFAULTSET_PROGRAM,[BusinessVasDefaultSet].[edate] AS BUSINESSVASDEFAULTSET_EDATE,[BusinessVasDefaultSet].[active] AS BUSINESSVASDEFAULTSET_ACTIVE,[BusinessVasDefaultSet].[con_per] AS BUSINESSVASDEFAULTSET_CON_PER,[BusinessVasDefaultSet].[display1] AS BUSINESSVASDEFAULTSET_DISPLAY1,[BusinessVasDefaultSet].[enabled2] AS BUSINESSVASDEFAULTSET_ENABLED2,[BusinessVasDefaultSet].[vas2] AS BUSINESSVASDEFAULTSET_VAS2,[BusinessVasDefaultSet].[rate_plan] AS BUSINESSVASDEFAULTSET_RATE_PLAN,[BusinessVasDefaultSet].[enabled1] AS BUSINESSVASDEFAULTSET_ENABLED1,[BusinessVasDefaultSet].[hs_model] AS BUSINESSVASDEFAULTSET_HS_MODEL,[BusinessVasDefaultSet].[vas1] AS BUSINESSVASDEFAULTSET_VAS1,[BusinessVasDefaultSet].[issue_type] AS BUSINESSVASDEFAULTSET_ISSUE_TYPE  FROM  [BusinessVasDefaultSet]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"BusinessVasDefaultSet");
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
        
        public bool Insert(global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sValue2,string x_sCid,string x_sValue1,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,string x_sTrade_field,string x_sCon_per,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<bool> x_bEnabled2,string x_sVas2,string x_sRate_plan,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,string x_sVas1,string x_sIssue_type)
        {
            BusinessVasDefaultSet _oBusinessVasDefaultSet=BusinessVasDefaultSetRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oBusinessVasDefaultSet.display2=x_bDisplay2;
            _oBusinessVasDefaultSet.cdate=x_dCdate;
            _oBusinessVasDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessVasDefaultSet.value2=x_sValue2;
            _oBusinessVasDefaultSet.cid=x_sCid;
            _oBusinessVasDefaultSet.value1=x_sValue1;
            _oBusinessVasDefaultSet.program=x_sProgram;
            _oBusinessVasDefaultSet.edate=x_dEdate;
            _oBusinessVasDefaultSet.active=x_bActive;
            _oBusinessVasDefaultSet.trade_field=x_sTrade_field;
            _oBusinessVasDefaultSet.con_per=x_sCon_per;
            _oBusinessVasDefaultSet.display1=x_bDisplay1;
            _oBusinessVasDefaultSet.enabled2=x_bEnabled2;
            _oBusinessVasDefaultSet.vas2=x_sVas2;
            _oBusinessVasDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessVasDefaultSet.enabled1=x_bEnabled1;
            _oBusinessVasDefaultSet.hs_model=x_sHs_model;
            _oBusinessVasDefaultSet.vas1=x_sVas1;
            _oBusinessVasDefaultSet.issue_type=x_sIssue_type;
            return InsertWithOutLastID(n_oDB, _oBusinessVasDefaultSet);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sValue2,string x_sCid,string x_sValue1,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,string x_sTrade_field,string x_sCon_per,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<bool> x_bEnabled2,string x_sVas2,string x_sRate_plan,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,string x_sVas1,string x_sIssue_type)
        {
            BusinessVasDefaultSet _oBusinessVasDefaultSet=BusinessVasDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasDefaultSet.display2=x_bDisplay2;
            _oBusinessVasDefaultSet.cdate=x_dCdate;
            _oBusinessVasDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessVasDefaultSet.value2=x_sValue2;
            _oBusinessVasDefaultSet.cid=x_sCid;
            _oBusinessVasDefaultSet.value1=x_sValue1;
            _oBusinessVasDefaultSet.program=x_sProgram;
            _oBusinessVasDefaultSet.edate=x_dEdate;
            _oBusinessVasDefaultSet.active=x_bActive;
            _oBusinessVasDefaultSet.trade_field=x_sTrade_field;
            _oBusinessVasDefaultSet.con_per=x_sCon_per;
            _oBusinessVasDefaultSet.display1=x_bDisplay1;
            _oBusinessVasDefaultSet.enabled2=x_bEnabled2;
            _oBusinessVasDefaultSet.vas2=x_sVas2;
            _oBusinessVasDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessVasDefaultSet.enabled1=x_bEnabled1;
            _oBusinessVasDefaultSet.hs_model=x_sHs_model;
            _oBusinessVasDefaultSet.vas1=x_sVas1;
            _oBusinessVasDefaultSet.issue_type=x_sIssue_type;
            return InsertWithOutLastID(x_oDB, _oBusinessVasDefaultSet);
        }
        
        
        public bool Insert(BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            return InsertWithOutLastID(n_oDB, x_oBusinessVasDefaultSet);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is BusinessVasDefaultSet)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (BusinessVasDefaultSet)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            return InsertWithOutLastID(x_oDB, x_oBusinessVasDefaultSet);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessVasDefaultSet]   ([display2],[cdate],[cid],[bundle_name],[value2],[trade_field],[value1],[program],[edate],[active],[con_per],[display1],[enabled2],[vas2],[rate_plan],[enabled1],[hs_model],[vas1],[issue_type])  VALUES  (@display2,@cdate,@cid,@bundle_name,@value2,@trade_field,@value1,@program,@edate,@active,@con_per,@display1,@enabled2,@vas2,@rate_plan,@enabled1,@hs_model,@vas1,@issue_type)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oBusinessVasDefaultSet);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            bool _bResult = false;
            if (!x_oBusinessVasDefaultSet.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessVasDefaultSet.display2==null){  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.display2; }
                if(x_oBusinessVasDefaultSet.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessVasDefaultSet.cdate; }
                if(x_oBusinessVasDefaultSet.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessVasDefaultSet.cid; }
                if(x_oBusinessVasDefaultSet.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.bundle_name; }
                if(x_oBusinessVasDefaultSet.value2==null){  x_oCmd.Parameters.Add("@value2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@value2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.value2; }
                if(x_oBusinessVasDefaultSet.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.trade_field; }
                if(x_oBusinessVasDefaultSet.value1==null){  x_oCmd.Parameters.Add("@value1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@value1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.value1; }
                if(x_oBusinessVasDefaultSet.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.program; }
                if(x_oBusinessVasDefaultSet.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessVasDefaultSet.edate; }
                if(x_oBusinessVasDefaultSet.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.active; }
                if(x_oBusinessVasDefaultSet.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.con_per; }
                if(x_oBusinessVasDefaultSet.display1==null){  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.display1; }
                if(x_oBusinessVasDefaultSet.enabled2==null){  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.enabled2; }
                if(x_oBusinessVasDefaultSet.vas2==null){  x_oCmd.Parameters.Add("@vas2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.vas2; }
                if(x_oBusinessVasDefaultSet.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.rate_plan; }
                if(x_oBusinessVasDefaultSet.enabled1==null){  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.enabled1; }
                if(x_oBusinessVasDefaultSet.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.hs_model; }
                if(x_oBusinessVasDefaultSet.vas1==null){  x_oCmd.Parameters.Add("@vas1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.vas1; }
                if(x_oBusinessVasDefaultSet.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessVasDefaultSet.issue_type; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sValue2,string x_sCid,string x_sValue1,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,string x_sTrade_field,string x_sCon_per,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<bool> x_bEnabled2,string x_sVas2,string x_sRate_plan,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,string x_sVas1,string x_sIssue_type)
        {
            int _oLastID;
            BusinessVasDefaultSet _oBusinessVasDefaultSet=BusinessVasDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasDefaultSet.display2=x_bDisplay2;
            _oBusinessVasDefaultSet.cdate=x_dCdate;
            _oBusinessVasDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessVasDefaultSet.value2=x_sValue2;
            _oBusinessVasDefaultSet.cid=x_sCid;
            _oBusinessVasDefaultSet.value1=x_sValue1;
            _oBusinessVasDefaultSet.program=x_sProgram;
            _oBusinessVasDefaultSet.edate=x_dEdate;
            _oBusinessVasDefaultSet.active=x_bActive;
            _oBusinessVasDefaultSet.trade_field=x_sTrade_field;
            _oBusinessVasDefaultSet.con_per=x_sCon_per;
            _oBusinessVasDefaultSet.display1=x_bDisplay1;
            _oBusinessVasDefaultSet.enabled2=x_bEnabled2;
            _oBusinessVasDefaultSet.vas2=x_sVas2;
            _oBusinessVasDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessVasDefaultSet.enabled1=x_bEnabled1;
            _oBusinessVasDefaultSet.hs_model=x_sHs_model;
            _oBusinessVasDefaultSet.vas1=x_sVas1;
            _oBusinessVasDefaultSet.issue_type=x_sIssue_type;
            if(InsertWithLastID(x_oDB, _oBusinessVasDefaultSet,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oBusinessVasDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oBusinessVasDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessVasDefaultSet)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (BusinessVasDefaultSet)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,BusinessVasDefaultSet x_oBusinessVasDefaultSet, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [BusinessVasDefaultSet]   ([display2],[cdate],[cid],[bundle_name],[value2],[trade_field],[value1],[program],[edate],[active],[con_per],[display1],[enabled2],[vas2],[rate_plan],[enabled1],[hs_model],[vas1],[issue_type])  VALUES  (@display2,@cdate,@cid,@bundle_name,@value2,@trade_field,@value1,@program,@edate,@active,@con_per,@display1,@enabled2,@vas2,@rate_plan,@enabled1,@hs_model,@vas1,@issue_type)"+" SELECT  @@IDENTITY AS BusinessVasDefaultSet_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oBusinessVasDefaultSet,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessVasDefaultSet x_oBusinessVasDefaultSet, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oBusinessVasDefaultSet.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oBusinessVasDefaultSet.display2==null){  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.display2; }
                if(x_oBusinessVasDefaultSet.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessVasDefaultSet.cdate; }
                if(x_oBusinessVasDefaultSet.cid==null){  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessVasDefaultSet.cid; }
                if(x_oBusinessVasDefaultSet.bundle_name==null){  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.bundle_name; }
                if(x_oBusinessVasDefaultSet.value2==null){  x_oCmd.Parameters.Add("@value2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@value2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.value2; }
                if(x_oBusinessVasDefaultSet.trade_field==null){  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.trade_field; }
                if(x_oBusinessVasDefaultSet.value1==null){  x_oCmd.Parameters.Add("@value1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@value1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.value1; }
                if(x_oBusinessVasDefaultSet.program==null){  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.program; }
                if(x_oBusinessVasDefaultSet.edate==null){  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value=x_oBusinessVasDefaultSet.edate; }
                if(x_oBusinessVasDefaultSet.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.active; }
                if(x_oBusinessVasDefaultSet.con_per==null){  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.con_per; }
                if(x_oBusinessVasDefaultSet.display1==null){  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.display1; }
                if(x_oBusinessVasDefaultSet.enabled2==null){  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.enabled2; }
                if(x_oBusinessVasDefaultSet.vas2==null){  x_oCmd.Parameters.Add("@vas2", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas2", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.vas2; }
                if(x_oBusinessVasDefaultSet.rate_plan==null){  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.rate_plan; }
                if(x_oBusinessVasDefaultSet.enabled1==null){  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit).Value=x_oBusinessVasDefaultSet.enabled1; }
                if(x_oBusinessVasDefaultSet.hs_model==null){  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.hs_model; }
                if(x_oBusinessVasDefaultSet.vas1==null){  x_oCmd.Parameters.Add("@vas1", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas1", global::System.Data.SqlDbType.NVarChar,250).Value=x_oBusinessVasDefaultSet.vas1; }
                if(x_oBusinessVasDefaultSet.issue_type==null){  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oBusinessVasDefaultSet.issue_type; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["BusinessVasDefaultSet_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["BusinessVasDefaultSet_LASTID"].ToString()) && int.TryParse(_oData["BusinessVasDefaultSet_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<bool> x_bDisplay2,global::System.Nullable<DateTime> x_dCdate,string x_sBundle_name,string x_sValue2,string x_sCid,string x_sValue1,string x_sProgram,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<bool> x_bActive,string x_sTrade_field,string x_sCon_per,global::System.Nullable<bool> x_bDisplay1,global::System.Nullable<bool> x_bEnabled2,string x_sVas2,string x_sRate_plan,global::System.Nullable<bool> x_bEnabled1,string x_sHs_model,string x_sVas1,string x_sIssue_type)
        {
            int _oLastID;
            BusinessVasDefaultSet _oBusinessVasDefaultSet=BusinessVasDefaultSetRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oBusinessVasDefaultSet.display2=x_bDisplay2;
            _oBusinessVasDefaultSet.cdate=x_dCdate;
            _oBusinessVasDefaultSet.bundle_name=x_sBundle_name;
            _oBusinessVasDefaultSet.value2=x_sValue2;
            _oBusinessVasDefaultSet.cid=x_sCid;
            _oBusinessVasDefaultSet.value1=x_sValue1;
            _oBusinessVasDefaultSet.program=x_sProgram;
            _oBusinessVasDefaultSet.edate=x_dEdate;
            _oBusinessVasDefaultSet.active=x_bActive;
            _oBusinessVasDefaultSet.trade_field=x_sTrade_field;
            _oBusinessVasDefaultSet.con_per=x_sCon_per;
            _oBusinessVasDefaultSet.display1=x_bDisplay1;
            _oBusinessVasDefaultSet.enabled2=x_bEnabled2;
            _oBusinessVasDefaultSet.vas2=x_sVas2;
            _oBusinessVasDefaultSet.rate_plan=x_sRate_plan;
            _oBusinessVasDefaultSet.enabled1=x_bEnabled1;
            _oBusinessVasDefaultSet.hs_model=x_sHs_model;
            _oBusinessVasDefaultSet.vas1=x_sVas1;
            _oBusinessVasDefaultSet.issue_type=x_sIssue_type;
            if(InsertWithLastID_SP(x_oDB, _oBusinessVasDefaultSet,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oBusinessVasDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oBusinessVasDefaultSet, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is BusinessVasDefaultSet)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (BusinessVasDefaultSet)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,BusinessVasDefaultSet x_oBusinessVasDefaultSet, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "BUSINESSVASDEFAULTSET";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oBusinessVasDefaultSet,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,BusinessVasDefaultSet x_oBusinessVasDefaultSet, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@display2", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.display2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.display2; }
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessVasDefaultSet.cdate; }
                _oPar=x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.cid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.cid; }
                _oPar=x_oCmd.Parameters.Add("@bundle_name", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.bundle_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.bundle_name; }
                _oPar=x_oCmd.Parameters.Add("@value2", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.value2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.value2; }
                _oPar=x_oCmd.Parameters.Add("@trade_field", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.trade_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.trade_field; }
                _oPar=x_oCmd.Parameters.Add("@value1", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.value1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.value1; }
                _oPar=x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.program==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.program; }
                _oPar=x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.edate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oBusinessVasDefaultSet.edate; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.active; }
                _oPar=x_oCmd.Parameters.Add("@con_per", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.con_per==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.con_per; }
                _oPar=x_oCmd.Parameters.Add("@display1", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.display1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.display1; }
                _oPar=x_oCmd.Parameters.Add("@enabled2", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.enabled2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.enabled2; }
                _oPar=x_oCmd.Parameters.Add("@vas2", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.vas2==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.vas2; }
                _oPar=x_oCmd.Parameters.Add("@rate_plan", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.rate_plan==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.rate_plan; }
                _oPar=x_oCmd.Parameters.Add("@enabled1", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.enabled1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.enabled1; }
                _oPar=x_oCmd.Parameters.Add("@hs_model", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.hs_model==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.hs_model; }
                _oPar=x_oCmd.Parameters.Add("@vas1", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.vas1==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.vas1; }
                _oPar=x_oCmd.Parameters.Add("@issue_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oBusinessVasDefaultSet.issue_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oBusinessVasDefaultSet.issue_type; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MID"].Value.ToString());
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
        
        #region INSERT_BUSINESSVASDEFAULTSET Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-07-15>
        ///-- Description:	<Description,BUSINESSVASDEFAULTSET, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_BUSINESSVASDEFAULTSET Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_BUSINESSVASDEFAULTSET', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_BUSINESSVASDEFAULTSET;
        GO
        CREATE PROCEDURE INSERT_BUSINESSVASDEFAULTSET
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @display2 bit,
        @cdate datetime,
        @bundle_name nvarchar(250),
        @value2 nvarchar(250),
        @cid nvarchar(50),
        @value1 nvarchar(250),
        @program nvarchar(250),
        @edate datetime,
        @active bit,
        @trade_field nvarchar(250),
        @con_per nvarchar(250),
        @display1 bit,
        @enabled2 bit,
        @vas2 nvarchar(250),
        @rate_plan nvarchar(250),
        @enabled1 bit,
        @hs_model nvarchar(250),
        @vas1 nvarchar(250),
        @issue_type nvarchar(50)
        AS
        
        INSERT INTO  [BusinessVasDefaultSet]   ([display2],[cdate],[cid],[bundle_name],[value2],[trade_field],[value1],[program],[edate],[active],[con_per],[display1],[enabled2],[vas2],[rate_plan],[enabled1],[hs_model],[vas1],[issue_type])  VALUES  (@display2,@cdate,@cid,@bundle_name,@value2,@trade_field,@value1,@program,@edate,@active,@con_per,@display1,@enabled2,@vas2,@rate_plan,@enabled1,@hs_model,@vas1,@issue_type)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_MID=@@IDENTITY
        RETURN @RETURN_MID
        END
        ELSE
        BEGIN
        SET @RETURN_MID=-1
        RETURN @RETURN_MID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(n_oDB, x_iMid);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(x_oDB, x_iMid);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_iMid==null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessVasDefaultSet]  WHERE [BusinessVasDefaultSet].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
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
            return BusinessVasDefaultSetRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [BusinessVasDefaultSet]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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
            string _sQuery = "DELETE FROM [BusinessVasDefaultSet]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[BusinessVasDefaultSet]","["+ Configurator.MSSQLTablePrefix + "BusinessVasDefaultSet]"); }
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


