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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderVasRevision],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderVasRevision] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderVasRevision")]
    public class MobileOrderVasRevisionRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderVasRevisionRepositoryBase instance;
        public static MobileOrderVasRevisionRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderVasRevisionRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderVasRevisionRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderVasRevisionRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderVasRevisionEntity> MobileOrderVasRevisions;
        #endregion
        
        #region Constructor
        public MobileOrderVasRevisionRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderVasRevisionRepositoryBase() { 
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
        public static MobileOrderVasRevision CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderVasRevision(_oDB);
        }
        
        public static MobileOrderVasRevision CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderVasRevision(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderVasRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
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
        
        
        public MobileOrderVasRevisionEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static MobileOrderVasRevisionEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            MobileOrderVasRevision _MobileOrderVasRevision = (MobileOrderVasRevision)MobileOrderVasRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderVasRevision.Load(x_iId)) { return null; }
            return _MobileOrderVasRevision;
        }
        
        
        
        public static MobileOrderVasRevisionEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderVasRevisionEntity> _oMobileOrderVasRevisionList = GetListObj(x_oDB,0, "id", x_oArrayItemId);
            if(_oMobileOrderVasRevisionList==null){ return null;}
            return _oMobileOrderVasRevisionList.Count == 0 ? null : _oMobileOrderVasRevisionList.ToArray();
        }
        
        public static List<MobileOrderVasRevisionEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "id", x_oArrayItemId);
        }
        
        
        public static MobileOrderVasRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderVasRevisionEntity> _oMobileOrderVasRevisionList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderVasRevisionList==null){ return null;}
            return _oMobileOrderVasRevisionList.Count == 0 ? null : _oMobileOrderVasRevisionList.ToArray();
        }
        
        
        public static MobileOrderVasRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderVasRevisionEntity> _oMobileOrderVasRevisionList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderVasRevisionList==null){ return null;}
            return _oMobileOrderVasRevisionList.Count == 0 ? null : _oMobileOrderVasRevisionList.ToArray();
        }
        
        public static List<MobileOrderVasRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderVasRevisionEntity> _oRow = new List<MobileOrderVasRevisionEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderVasRevision].[id] AS MOBILEORDERVASREVISION_ID,[MobileOrderVasRevision].[cdate] AS MOBILEORDERVASREVISION_CDATE,[MobileOrderVasRevision].[active] AS MOBILEORDERVASREVISION_ACTIVE,[MobileOrderVasRevision].[multi_id] AS MOBILEORDERVASREVISION_MULTI_ID,[MobileOrderVasRevision].[vas_field] AS MOBILEORDERVASREVISION_VAS_FIELD,[MobileOrderVasRevision].[vas_id] AS MOBILEORDERVASREVISION_VAS_ID,[MobileOrderVasRevision].[his_order_id] AS MOBILEORDERVASREVISION_HIS_ORDER_ID,[MobileOrderVasRevision].[order_id] AS MOBILEORDERVASREVISION_ORDER_ID,[MobileOrderVasRevision].[fee] AS MOBILEORDERVASREVISION_FEE,[MobileOrderVasRevision].[vas_value] AS MOBILEORDERVASREVISION_VAS_VALUE  FROM  [MobileOrderVasRevision]";
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
                _sQuery += " WHERE [MobileOrderVasRevision].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderVasRevision _oMobileOrderVasRevision = MobileOrderVasRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ID"])) {_oMobileOrderVasRevision.id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_ID"]; }else{_oMobileOrderVasRevision.id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_CDATE"])) {_oMobileOrderVasRevision.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERVASREVISION_CDATE"]; }else{_oMobileOrderVasRevision.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ACTIVE"])) {_oMobileOrderVasRevision.active = (global::System.Nullable<bool>)_oData["MOBILEORDERVASREVISION_ACTIVE"]; }else{_oMobileOrderVasRevision.active=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_FIELD"])) {_oMobileOrderVasRevision.vas_field = (string)_oData["MOBILEORDERVASREVISION_VAS_FIELD"]; }else{_oMobileOrderVasRevision.vas_field=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_ID"])) {_oMobileOrderVasRevision.vas_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_VAS_ID"]; }else{_oMobileOrderVasRevision.vas_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_HIS_ORDER_ID"])) {_oMobileOrderVasRevision.his_order_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_HIS_ORDER_ID"]; }else{_oMobileOrderVasRevision.his_order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ORDER_ID"])) {_oMobileOrderVasRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_ORDER_ID"]; }else{_oMobileOrderVasRevision.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_FEE"])) {_oMobileOrderVasRevision.fee = (string)_oData["MOBILEORDERVASREVISION_FEE"]; }else{_oMobileOrderVasRevision.fee=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_VALUE"])) {_oMobileOrderVasRevision.vas_value = (string)_oData["MOBILEORDERVASREVISION_VAS_VALUE"]; }else{_oMobileOrderVasRevision.vas_value=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_MULTI_ID"])) {_oMobileOrderVasRevision.multi_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_MULTI_ID"]; }else{_oMobileOrderVasRevision.multi_id=null;}
                        _oMobileOrderVasRevision.SetDB(x_oDB);
                        _oMobileOrderVasRevision.GetFound();
                        _oRow.Add(_oMobileOrderVasRevision);
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
        
        
        public static MobileOrderVasRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderVasRevisionEntity> _oMobileOrderVasRevisionList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderVasRevisionList==null){ return null;}
            return _oMobileOrderVasRevisionList.Count == 0 ? null : _oMobileOrderVasRevisionList.ToArray();
        }
        
        
        public static MobileOrderVasRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderVasRevisionEntity> _oMobileOrderVasRevisionList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderVasRevisionList==null){ return null;}
            return _oMobileOrderVasRevisionList.Count == 0 ? null : _oMobileOrderVasRevisionList.ToArray();
        }
        
        public static List<MobileOrderVasRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderVasRevisionEntity> _oRow = new List<MobileOrderVasRevisionEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderVasRevision].[id] AS MOBILEORDERVASREVISION_ID,[MobileOrderVasRevision].[cdate] AS MOBILEORDERVASREVISION_CDATE,[MobileOrderVasRevision].[active] AS MOBILEORDERVASREVISION_ACTIVE,[MobileOrderVasRevision].[multi_id] AS MOBILEORDERVASREVISION_MULTI_ID,[MobileOrderVasRevision].[vas_field] AS MOBILEORDERVASREVISION_VAS_FIELD,[MobileOrderVasRevision].[vas_id] AS MOBILEORDERVASREVISION_VAS_ID,[MobileOrderVasRevision].[his_order_id] AS MOBILEORDERVASREVISION_HIS_ORDER_ID,[MobileOrderVasRevision].[order_id] AS MOBILEORDERVASREVISION_ORDER_ID,[MobileOrderVasRevision].[fee] AS MOBILEORDERVASREVISION_FEE,[MobileOrderVasRevision].[vas_value] AS MOBILEORDERVASREVISION_VAS_VALUE";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderVasRevisionRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderVasRevisionEntity _oMobileOrderVasRevision = MobileOrderVasRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ID"])) {_oMobileOrderVasRevision.id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_ID"]; } else {_oMobileOrderVasRevision.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_CDATE"])) {_oMobileOrderVasRevision.cdate = (global::System.Nullable<DateTime>)_oData["MOBILEORDERVASREVISION_CDATE"]; } else {_oMobileOrderVasRevision.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ACTIVE"])) {_oMobileOrderVasRevision.active = (global::System.Nullable<bool>)_oData["MOBILEORDERVASREVISION_ACTIVE"]; } else {_oMobileOrderVasRevision.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_FIELD"])) {_oMobileOrderVasRevision.vas_field = (string)_oData["MOBILEORDERVASREVISION_VAS_FIELD"]; } else {_oMobileOrderVasRevision.vas_field=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_ID"])) {_oMobileOrderVasRevision.vas_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_VAS_ID"]; } else {_oMobileOrderVasRevision.vas_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_HIS_ORDER_ID"])) {_oMobileOrderVasRevision.his_order_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_HIS_ORDER_ID"]; } else {_oMobileOrderVasRevision.his_order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_ORDER_ID"])) {_oMobileOrderVasRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_ORDER_ID"]; } else {_oMobileOrderVasRevision.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_FEE"])) {_oMobileOrderVasRevision.fee = (string)_oData["MOBILEORDERVASREVISION_FEE"]; } else {_oMobileOrderVasRevision.fee=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_VAS_VALUE"])) {_oMobileOrderVasRevision.vas_value = (string)_oData["MOBILEORDERVASREVISION_VAS_VALUE"]; } else {_oMobileOrderVasRevision.vas_value=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERVASREVISION_MULTI_ID"])) {_oMobileOrderVasRevision.multi_id = (global::System.Nullable<int>)_oData["MOBILEORDERVASREVISION_MULTI_ID"]; } else {_oMobileOrderVasRevision.multi_id=null; }
                _oMobileOrderVasRevision.SetDB(x_oDB);
                _oMobileOrderVasRevision.GetFound();
                _oRow.Add(_oMobileOrderVasRevision);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderVasRevision.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderVasRevision.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderVasRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderVasRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderVasRevision].[id] AS MOBILEORDERVASREVISION_ID,[MobileOrderVasRevision].[cdate] AS MOBILEORDERVASREVISION_CDATE,[MobileOrderVasRevision].[active] AS MOBILEORDERVASREVISION_ACTIVE,[MobileOrderVasRevision].[multi_id] AS MOBILEORDERVASREVISION_MULTI_ID,[MobileOrderVasRevision].[vas_field] AS MOBILEORDERVASREVISION_VAS_FIELD,[MobileOrderVasRevision].[vas_id] AS MOBILEORDERVASREVISION_VAS_ID,[MobileOrderVasRevision].[his_order_id] AS MOBILEORDERVASREVISION_HIS_ORDER_ID,[MobileOrderVasRevision].[order_id] AS MOBILEORDERVASREVISION_ORDER_ID,[MobileOrderVasRevision].[fee] AS MOBILEORDERVASREVISION_FEE,[MobileOrderVasRevision].[vas_value] AS MOBILEORDERVASREVISION_VAS_VALUE  FROM  [MobileOrderVasRevision]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderVasRevision");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iHis_order_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            MobileOrderVasRevision _oMobileOrderVasRevision=MobileOrderVasRevisionRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderVasRevision.cdate=x_dCdate;
            _oMobileOrderVasRevision.active=x_bActive;
            _oMobileOrderVasRevision.vas_field=x_sVas_field;
            _oMobileOrderVasRevision.vas_id=x_iVas_id;
            _oMobileOrderVasRevision.his_order_id=x_iHis_order_id;
            _oMobileOrderVasRevision.order_id=x_iOrder_id;
            _oMobileOrderVasRevision.fee=x_sFee;
            _oMobileOrderVasRevision.vas_value=x_sVas_value;
            _oMobileOrderVasRevision.multi_id=x_iMulti_id;
            return InsertWithOutLastID(n_oDB, _oMobileOrderVasRevision);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iHis_order_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            MobileOrderVasRevision _oMobileOrderVasRevision=MobileOrderVasRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderVasRevision.cdate=x_dCdate;
            _oMobileOrderVasRevision.active=x_bActive;
            _oMobileOrderVasRevision.vas_field=x_sVas_field;
            _oMobileOrderVasRevision.vas_id=x_iVas_id;
            _oMobileOrderVasRevision.his_order_id=x_iHis_order_id;
            _oMobileOrderVasRevision.order_id=x_iOrder_id;
            _oMobileOrderVasRevision.fee=x_sFee;
            _oMobileOrderVasRevision.vas_value=x_sVas_value;
            _oMobileOrderVasRevision.multi_id=x_iMulti_id;
            return InsertWithOutLastID(x_oDB, _oMobileOrderVasRevision);
        }
        
        
        public bool Insert(MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderVasRevision);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderVasRevision)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderVasRevision)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderVasRevision);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderVasRevision]   ([cdate],[active],[multi_id],[vas_field],[vas_id],[his_order_id],[order_id],[fee],[vas_value])  VALUES  (@cdate,@active,@multi_id,@vas_field,@vas_id,@his_order_id,@order_id,@fee,@vas_value)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderVasRevision);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            bool _bResult = false;
            if (!x_oMobileOrderVasRevision.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderVasRevision.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderVasRevision.cdate; }
                if(x_oMobileOrderVasRevision.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderVasRevision.active; }
                if(x_oMobileOrderVasRevision.multi_id==null){  x_oCmd.Parameters.Add("@multi_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@multi_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.multi_id; }
                if(x_oMobileOrderVasRevision.vas_field==null){  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileOrderVasRevision.vas_field; }
                if(x_oMobileOrderVasRevision.vas_id==null){  x_oCmd.Parameters.Add("@vas_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.vas_id; }
                if(x_oMobileOrderVasRevision.his_order_id==null){  x_oCmd.Parameters.Add("@his_order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@his_order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.his_order_id; }
                if(x_oMobileOrderVasRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.order_id; }
                if(x_oMobileOrderVasRevision.fee==null){  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileOrderVasRevision.fee; }
                if(x_oMobileOrderVasRevision.vas_value==null){  x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileOrderVasRevision.vas_value; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iHis_order_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            int _oLastID;
            MobileOrderVasRevision _oMobileOrderVasRevision=MobileOrderVasRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderVasRevision.cdate=x_dCdate;
            _oMobileOrderVasRevision.active=x_bActive;
            _oMobileOrderVasRevision.vas_field=x_sVas_field;
            _oMobileOrderVasRevision.vas_id=x_iVas_id;
            _oMobileOrderVasRevision.his_order_id=x_iHis_order_id;
            _oMobileOrderVasRevision.order_id=x_iOrder_id;
            _oMobileOrderVasRevision.fee=x_sFee;
            _oMobileOrderVasRevision.vas_value=x_sVas_value;
            _oMobileOrderVasRevision.multi_id=x_iMulti_id;
            if(InsertWithLastID(x_oDB, _oMobileOrderVasRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderVasRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderVasRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderVasRevision)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderVasRevision)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderVasRevision x_oMobileOrderVasRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderVasRevision]   ([cdate],[active],[multi_id],[vas_field],[vas_id],[his_order_id],[order_id],[fee],[vas_value])  VALUES  (@cdate,@active,@multi_id,@vas_field,@vas_id,@his_order_id,@order_id,@fee,@vas_value)"+" SELECT  @@IDENTITY AS MobileOrderVasRevision_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderVasRevision,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderVasRevision x_oMobileOrderVasRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderVasRevision.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderVasRevision.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderVasRevision.cdate; }
                if(x_oMobileOrderVasRevision.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderVasRevision.active; }
                if(x_oMobileOrderVasRevision.multi_id==null){  x_oCmd.Parameters.Add("@multi_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@multi_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.multi_id; }
                if(x_oMobileOrderVasRevision.vas_field==null){  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,100).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,100).Value=x_oMobileOrderVasRevision.vas_field; }
                if(x_oMobileOrderVasRevision.vas_id==null){  x_oCmd.Parameters.Add("@vas_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.vas_id; }
                if(x_oMobileOrderVasRevision.his_order_id==null){  x_oCmd.Parameters.Add("@his_order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@his_order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.his_order_id; }
                if(x_oMobileOrderVasRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderVasRevision.order_id; }
                if(x_oMobileOrderVasRevision.fee==null){  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileOrderVasRevision.fee; }
                if(x_oMobileOrderVasRevision.vas_value==null){  x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar,200).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar,200).Value=x_oMobileOrderVasRevision.vas_value; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderVasRevision_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderVasRevision_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderVasRevision_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,global::System.Nullable<bool> x_bActive,string x_sVas_field,global::System.Nullable<int> x_iVas_id,global::System.Nullable<int> x_iHis_order_id,global::System.Nullable<int> x_iOrder_id,string x_sFee,string x_sVas_value,global::System.Nullable<int> x_iMulti_id)
        {
            int _oLastID;
            MobileOrderVasRevision _oMobileOrderVasRevision=MobileOrderVasRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderVasRevision.cdate=x_dCdate;
            _oMobileOrderVasRevision.active=x_bActive;
            _oMobileOrderVasRevision.vas_field=x_sVas_field;
            _oMobileOrderVasRevision.vas_id=x_iVas_id;
            _oMobileOrderVasRevision.his_order_id=x_iHis_order_id;
            _oMobileOrderVasRevision.order_id=x_iOrder_id;
            _oMobileOrderVasRevision.fee=x_sFee;
            _oMobileOrderVasRevision.vas_value=x_sVas_value;
            _oMobileOrderVasRevision.multi_id=x_iMulti_id;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderVasRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderVasRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderVasRevision x_oMobileOrderVasRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderVasRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderVasRevision)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderVasRevision)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderVasRevision x_oMobileOrderVasRevision, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERVASREVISION";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderVasRevision,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderVasRevision x_oMobileOrderVasRevision, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.cdate==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderVasRevision.cdate; }
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.active==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.active; }
                _oPar=x_oCmd.Parameters.Add("@multi_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.multi_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.multi_id; }
                _oPar=x_oCmd.Parameters.Add("@vas_field", global::System.Data.SqlDbType.NVarChar,100);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.vas_field==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.vas_field; }
                _oPar=x_oCmd.Parameters.Add("@vas_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.vas_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.vas_id; }
                _oPar=x_oCmd.Parameters.Add("@his_order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.his_order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.his_order_id; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.order_id; }
                _oPar=x_oCmd.Parameters.Add("@fee", global::System.Data.SqlDbType.NVarChar,200);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.fee==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.fee; }
                _oPar=x_oCmd.Parameters.Add("@vas_value", global::System.Data.SqlDbType.NVarChar,200);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderVasRevision.vas_value==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderVasRevision.vas_value; }
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
        
        #region INSERT_MOBILEORDERVASREVISION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-03-08>
        ///-- Description:	<Description,MOBILEORDERVASREVISION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERVASREVISION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERVASREVISION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERVASREVISION;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERVASREVISION
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @active bit,
        @vas_field nvarchar(100),
        @vas_id int,
        @his_order_id int,
        @order_id int,
        @fee nvarchar(200),
        @vas_value nvarchar(200),
        @multi_id int
        AS
        
        INSERT INTO  [MobileOrderVasRevision]   ([cdate],[active],[multi_id],[vas_field],[vas_id],[his_order_id],[order_id],[fee],[vas_value])  VALUES  (@cdate,@active,@multi_id,@vas_field,@vas_id,@his_order_id,@order_id,@fee,@vas_value)
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
            string _sQuery = "DELETE FROM  [MobileOrderVasRevision]  WHERE [MobileOrderVasRevision].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
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
            return MobileOrderVasRevisionRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderVasRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderVasRevision]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderVasRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderVasRevision]"); }
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


