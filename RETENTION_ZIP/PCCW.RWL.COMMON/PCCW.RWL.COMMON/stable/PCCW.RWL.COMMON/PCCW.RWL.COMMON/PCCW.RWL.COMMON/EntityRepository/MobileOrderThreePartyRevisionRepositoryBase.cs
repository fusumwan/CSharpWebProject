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
///-- Description:	<Description,Table :[MobileOrderThreePartyRevision],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderThreePartyRevision] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderThreePartyRevision")]
    public class MobileOrderThreePartyRevisionRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderThreePartyRevisionRepositoryBase instance;
        public static MobileOrderThreePartyRevisionRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderThreePartyRevisionRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderThreePartyRevisionRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderThreePartyRevisionRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderThreePartyRevisionEntity> MobileOrderThreePartyRevisions;
        #endregion
        
        #region Constructor
        public MobileOrderThreePartyRevisionRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderThreePartyRevisionRepositoryBase() { 
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
        public static MobileOrderThreePartyRevision CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderThreePartyRevision(_oDB);
        }
        
        public static MobileOrderThreePartyRevision CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderThreePartyRevision(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderThreePartyRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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
        
        
        public MobileOrderThreePartyRevisionEntity GetObj(global::System.Nullable<long> x_lMid)
        {
            return GetObj(n_oDB, x_lMid);
        }
        
        
        public static MobileOrderThreePartyRevisionEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderThreePartyRevision _MobileOrderThreePartyRevision = (MobileOrderThreePartyRevision)MobileOrderThreePartyRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderThreePartyRevision.Load(x_lMid)) { return null; }
            return _MobileOrderThreePartyRevision;
        }
        
        
        
        public static MobileOrderThreePartyRevisionEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderThreePartyRevisionEntity> _oMobileOrderThreePartyRevisionList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderThreePartyRevisionList==null){ return null;}
            return _oMobileOrderThreePartyRevisionList.Count == 0 ? null : _oMobileOrderThreePartyRevisionList.ToArray();
        }
        
        public static List<MobileOrderThreePartyRevisionEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderThreePartyRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderThreePartyRevisionEntity> _oMobileOrderThreePartyRevisionList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderThreePartyRevisionList==null){ return null;}
            return _oMobileOrderThreePartyRevisionList.Count == 0 ? null : _oMobileOrderThreePartyRevisionList.ToArray();
        }
        
        
        public static MobileOrderThreePartyRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderThreePartyRevisionEntity> _oMobileOrderThreePartyRevisionList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderThreePartyRevisionList==null){ return null;}
            return _oMobileOrderThreePartyRevisionList.Count == 0 ? null : _oMobileOrderThreePartyRevisionList.ToArray();
        }
        
        public static List<MobileOrderThreePartyRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderThreePartyRevisionEntity> _oRow = new List<MobileOrderThreePartyRevisionEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderThreePartyRevision].[tpy_id] AS MOBILEORDERTHREEPARTYREVISION_TPY_ID,[MobileOrderThreePartyRevision].[hkid] AS MOBILEORDERTHREEPARTYREVISION_HKID,[MobileOrderThreePartyRevision].[arthurization_person] AS MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON,[MobileOrderThreePartyRevision].[id_type] AS MOBILEORDERTHREEPARTYREVISION_ID_TYPE,[MobileOrderThreePartyRevision].[type] AS MOBILEORDERTHREEPARTYREVISION_TYPE,[MobileOrderThreePartyRevision].[contact_no] AS MOBILEORDERTHREEPARTYREVISION_CONTACT_NO,[MobileOrderThreePartyRevision].[plural] AS MOBILEORDERTHREEPARTYREVISION_PLURAL,[MobileOrderThreePartyRevision].[order_id] AS MOBILEORDERTHREEPARTYREVISION_ORDER_ID,[MobileOrderThreePartyRevision].[mid] AS MOBILEORDERTHREEPARTYREVISION_MID,[MobileOrderThreePartyRevision].[three_party] AS MOBILEORDERTHREEPARTYREVISION_THREE_PARTY  FROM  [MobileOrderThreePartyRevision]";
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
                _sQuery += " WHERE [MobileOrderThreePartyRevision].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision = MobileOrderThreePartyRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"])) {_oMobileOrderThreePartyRevision.tpy_id = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"]; }else{_oMobileOrderThreePartyRevision.tpy_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"])) {_oMobileOrderThreePartyRevision.arthurization_person = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"]; }else{_oMobileOrderThreePartyRevision.arthurization_person=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"])) {_oMobileOrderThreePartyRevision.contact_no = (string)_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"]; }else{_oMobileOrderThreePartyRevision.contact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"])) {_oMobileOrderThreePartyRevision.type = (string)_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"]; }else{_oMobileOrderThreePartyRevision.type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"])) {_oMobileOrderThreePartyRevision.id_type = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"]; }else{_oMobileOrderThreePartyRevision.id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"])) {_oMobileOrderThreePartyRevision.plural = (string)_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"]; }else{_oMobileOrderThreePartyRevision.plural=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_HKID"])) {_oMobileOrderThreePartyRevision.hkid = (string)_oData["MOBILEORDERTHREEPARTYREVISION_HKID"]; }else{_oMobileOrderThreePartyRevision.hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"])) {_oMobileOrderThreePartyRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"]; }else{_oMobileOrderThreePartyRevision.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_MID"])) {_oMobileOrderThreePartyRevision.mid = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_MID"]; }else{_oMobileOrderThreePartyRevision.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"])) {_oMobileOrderThreePartyRevision.three_party = (global::System.Nullable<bool>)_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"]; }else{_oMobileOrderThreePartyRevision.three_party=null;}
                        _oMobileOrderThreePartyRevision.SetDB(x_oDB);
                        _oMobileOrderThreePartyRevision.GetFound();
                        _oRow.Add(_oMobileOrderThreePartyRevision);
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
        
        
        public static MobileOrderThreePartyRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderThreePartyRevisionEntity> _oMobileOrderThreePartyRevisionList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderThreePartyRevisionList==null){ return null;}
            return _oMobileOrderThreePartyRevisionList.Count == 0 ? null : _oMobileOrderThreePartyRevisionList.ToArray();
        }
        
        
        public static MobileOrderThreePartyRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderThreePartyRevisionEntity> _oMobileOrderThreePartyRevisionList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderThreePartyRevisionList==null){ return null;}
            return _oMobileOrderThreePartyRevisionList.Count == 0 ? null : _oMobileOrderThreePartyRevisionList.ToArray();
        }
        
        public static List<MobileOrderThreePartyRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderThreePartyRevisionEntity> _oRow = new List<MobileOrderThreePartyRevisionEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderThreePartyRevision].[tpy_id] AS MOBILEORDERTHREEPARTYREVISION_TPY_ID,[MobileOrderThreePartyRevision].[hkid] AS MOBILEORDERTHREEPARTYREVISION_HKID,[MobileOrderThreePartyRevision].[arthurization_person] AS MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON,[MobileOrderThreePartyRevision].[id_type] AS MOBILEORDERTHREEPARTYREVISION_ID_TYPE,[MobileOrderThreePartyRevision].[type] AS MOBILEORDERTHREEPARTYREVISION_TYPE,[MobileOrderThreePartyRevision].[contact_no] AS MOBILEORDERTHREEPARTYREVISION_CONTACT_NO,[MobileOrderThreePartyRevision].[plural] AS MOBILEORDERTHREEPARTYREVISION_PLURAL,[MobileOrderThreePartyRevision].[order_id] AS MOBILEORDERTHREEPARTYREVISION_ORDER_ID,[MobileOrderThreePartyRevision].[mid] AS MOBILEORDERTHREEPARTYREVISION_MID,[MobileOrderThreePartyRevision].[three_party] AS MOBILEORDERTHREEPARTYREVISION_THREE_PARTY";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderThreePartyRevisionRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderThreePartyRevisionEntity _oMobileOrderThreePartyRevision = MobileOrderThreePartyRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"])) {_oMobileOrderThreePartyRevision.tpy_id = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"]; } else {_oMobileOrderThreePartyRevision.tpy_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"])) {_oMobileOrderThreePartyRevision.arthurization_person = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"]; } else {_oMobileOrderThreePartyRevision.arthurization_person=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"])) {_oMobileOrderThreePartyRevision.contact_no = (string)_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"]; } else {_oMobileOrderThreePartyRevision.contact_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"])) {_oMobileOrderThreePartyRevision.type = (string)_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"]; } else {_oMobileOrderThreePartyRevision.type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"])) {_oMobileOrderThreePartyRevision.id_type = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"]; } else {_oMobileOrderThreePartyRevision.id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"])) {_oMobileOrderThreePartyRevision.plural = (string)_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"]; } else {_oMobileOrderThreePartyRevision.plural=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_HKID"])) {_oMobileOrderThreePartyRevision.hkid = (string)_oData["MOBILEORDERTHREEPARTYREVISION_HKID"]; } else {_oMobileOrderThreePartyRevision.hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"])) {_oMobileOrderThreePartyRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"]; } else {_oMobileOrderThreePartyRevision.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_MID"])) {_oMobileOrderThreePartyRevision.mid = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_MID"]; } else {_oMobileOrderThreePartyRevision.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"])) {_oMobileOrderThreePartyRevision.three_party = (global::System.Nullable<bool>)_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"]; } else {_oMobileOrderThreePartyRevision.three_party=null; }
                _oMobileOrderThreePartyRevision.SetDB(x_oDB);
                _oMobileOrderThreePartyRevision.GetFound();
                _oRow.Add(_oMobileOrderThreePartyRevision);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderThreePartyRevision.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderThreePartyRevision.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderThreePartyRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderThreePartyRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderThreePartyRevision].[tpy_id] AS MOBILEORDERTHREEPARTYREVISION_TPY_ID,[MobileOrderThreePartyRevision].[hkid] AS MOBILEORDERTHREEPARTYREVISION_HKID,[MobileOrderThreePartyRevision].[arthurization_person] AS MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON,[MobileOrderThreePartyRevision].[id_type] AS MOBILEORDERTHREEPARTYREVISION_ID_TYPE,[MobileOrderThreePartyRevision].[type] AS MOBILEORDERTHREEPARTYREVISION_TYPE,[MobileOrderThreePartyRevision].[contact_no] AS MOBILEORDERTHREEPARTYREVISION_CONTACT_NO,[MobileOrderThreePartyRevision].[plural] AS MOBILEORDERTHREEPARTYREVISION_PLURAL,[MobileOrderThreePartyRevision].[order_id] AS MOBILEORDERTHREEPARTYREVISION_ORDER_ID,[MobileOrderThreePartyRevision].[mid] AS MOBILEORDERTHREEPARTYREVISION_MID,[MobileOrderThreePartyRevision].[three_party] AS MOBILEORDERTHREEPARTYREVISION_THREE_PARTY  FROM  [MobileOrderThreePartyRevision]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderThreePartyRevision");
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
        
        public bool Insert(global::System.Nullable<long> x_lTpy_id,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision=MobileOrderThreePartyRevisionRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderThreePartyRevision.tpy_id=x_lTpy_id;
            _oMobileOrderThreePartyRevision.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreePartyRevision.contact_no=x_sContact_no;
            _oMobileOrderThreePartyRevision.type=x_sType;
            _oMobileOrderThreePartyRevision.id_type=x_sId_type;
            _oMobileOrderThreePartyRevision.plural=x_sPlural;
            _oMobileOrderThreePartyRevision.hkid=x_sHkid;
            _oMobileOrderThreePartyRevision.order_id=x_iOrder_id;
            _oMobileOrderThreePartyRevision.three_party=x_bThree_party;
            return InsertWithOutLastID(n_oDB, _oMobileOrderThreePartyRevision);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<long> x_lTpy_id,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision=MobileOrderThreePartyRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderThreePartyRevision.tpy_id=x_lTpy_id;
            _oMobileOrderThreePartyRevision.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreePartyRevision.contact_no=x_sContact_no;
            _oMobileOrderThreePartyRevision.type=x_sType;
            _oMobileOrderThreePartyRevision.id_type=x_sId_type;
            _oMobileOrderThreePartyRevision.plural=x_sPlural;
            _oMobileOrderThreePartyRevision.hkid=x_sHkid;
            _oMobileOrderThreePartyRevision.order_id=x_iOrder_id;
            _oMobileOrderThreePartyRevision.three_party=x_bThree_party;
            return InsertWithOutLastID(x_oDB, _oMobileOrderThreePartyRevision);
        }
        
        
        public bool Insert(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderThreePartyRevision);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderThreePartyRevision)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderThreePartyRevision)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderThreePartyRevision);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderThreePartyRevision]   ([tpy_id],[hkid],[arthurization_person],[id_type],[type],[contact_no],[plural],[order_id],[three_party])  VALUES  (@tpy_id,@hkid,@arthurization_person,@id_type,@type,@contact_no,@plural,@order_id,@three_party)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderThreePartyRevision);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            bool _bResult = false;
            if (!x_oMobileOrderThreePartyRevision.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderThreePartyRevision.tpy_id==null){  x_oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderThreePartyRevision.tpy_id; }
                if(x_oMobileOrderThreePartyRevision.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderThreePartyRevision.hkid; }
                if(x_oMobileOrderThreePartyRevision.arthurization_person==null){  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderThreePartyRevision.arthurization_person; }
                if(x_oMobileOrderThreePartyRevision.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderThreePartyRevision.id_type; }
                if(x_oMobileOrderThreePartyRevision.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderThreePartyRevision.type; }
                if(x_oMobileOrderThreePartyRevision.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreePartyRevision.contact_no; }
                if(x_oMobileOrderThreePartyRevision.plural==null){  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreePartyRevision.plural; }
                if(x_oMobileOrderThreePartyRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderThreePartyRevision.order_id; }
                if(x_oMobileOrderThreePartyRevision.three_party==null){  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderThreePartyRevision.three_party; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            int _oLastID;
            MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision=MobileOrderThreePartyRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderThreePartyRevision.tpy_id=x_lTpy_id;
            _oMobileOrderThreePartyRevision.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreePartyRevision.contact_no=x_sContact_no;
            _oMobileOrderThreePartyRevision.type=x_sType;
            _oMobileOrderThreePartyRevision.id_type=x_sId_type;
            _oMobileOrderThreePartyRevision.plural=x_sPlural;
            _oMobileOrderThreePartyRevision.hkid=x_sHkid;
            _oMobileOrderThreePartyRevision.order_id=x_iOrder_id;
            _oMobileOrderThreePartyRevision.three_party=x_bThree_party;
            if(InsertWithLastID(x_oDB, _oMobileOrderThreePartyRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderThreePartyRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderThreePartyRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderThreePartyRevision)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderThreePartyRevision)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderThreePartyRevision]   ([tpy_id],[hkid],[arthurization_person],[id_type],[type],[contact_no],[plural],[order_id],[three_party])  VALUES  (@tpy_id,@hkid,@arthurization_person,@id_type,@type,@contact_no,@plural,@order_id,@three_party)"+" SELECT  @@IDENTITY AS MobileOrderThreePartyRevision_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderThreePartyRevision,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderThreePartyRevision.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderThreePartyRevision.tpy_id==null){  x_oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderThreePartyRevision.tpy_id; }
                if(x_oMobileOrderThreePartyRevision.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderThreePartyRevision.hkid; }
                if(x_oMobileOrderThreePartyRevision.arthurization_person==null){  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderThreePartyRevision.arthurization_person; }
                if(x_oMobileOrderThreePartyRevision.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderThreePartyRevision.id_type; }
                if(x_oMobileOrderThreePartyRevision.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderThreePartyRevision.type; }
                if(x_oMobileOrderThreePartyRevision.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreePartyRevision.contact_no; }
                if(x_oMobileOrderThreePartyRevision.plural==null){  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreePartyRevision.plural; }
                if(x_oMobileOrderThreePartyRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderThreePartyRevision.order_id; }
                if(x_oMobileOrderThreePartyRevision.three_party==null){  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderThreePartyRevision.three_party; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderThreePartyRevision_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderThreePartyRevision_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderThreePartyRevision_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            int _oLastID;
            MobileOrderThreePartyRevision _oMobileOrderThreePartyRevision=MobileOrderThreePartyRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderThreePartyRevision.tpy_id=x_lTpy_id;
            _oMobileOrderThreePartyRevision.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreePartyRevision.contact_no=x_sContact_no;
            _oMobileOrderThreePartyRevision.type=x_sType;
            _oMobileOrderThreePartyRevision.id_type=x_sId_type;
            _oMobileOrderThreePartyRevision.plural=x_sPlural;
            _oMobileOrderThreePartyRevision.hkid=x_sHkid;
            _oMobileOrderThreePartyRevision.order_id=x_iOrder_id;
            _oMobileOrderThreePartyRevision.three_party=x_bThree_party;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderThreePartyRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderThreePartyRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderThreePartyRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderThreePartyRevision)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderThreePartyRevision)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERTHREEPARTYREVISION";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderThreePartyRevision,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.tpy_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.tpy_id; }
                _oPar=x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.hkid; }
                _oPar=x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.arthurization_person==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.arthurization_person; }
                _oPar=x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.id_type; }
                _oPar=x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.type; }
                _oPar=x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.contact_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.contact_no; }
                _oPar=x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.plural==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.plural; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.order_id; }
                _oPar=x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreePartyRevision.three_party==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreePartyRevision.three_party; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.BigInt);
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
        
        #region INSERT_MOBILEORDERTHREEPARTYREVISION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-03-08>
        ///-- Description:	<Description,MOBILEORDERTHREEPARTYREVISION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERTHREEPARTYREVISION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERTHREEPARTYREVISION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERTHREEPARTYREVISION;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERTHREEPARTYREVISION
        	-- Add the parameters for the stored procedure here
        @RETURN_MID bigint output,
        @tpy_id bigint,
        @arthurization_person nvarchar(250),
        @contact_no nvarchar(20),
        @type nvarchar(50),
        @id_type nvarchar(10),
        @plural nvarchar(20),
        @hkid nvarchar(30),
        @order_id int,
        @three_party bit
        AS
        
        INSERT INTO  [MobileOrderThreePartyRevision]   ([tpy_id],[hkid],[arthurization_person],[id_type],[type],[contact_no],[plural],[order_id],[three_party])  VALUES  (@tpy_id,@hkid,@arthurization_person,@id_type,@type,@contact_no,@plural,@order_id,@three_party)
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
        
        public bool Delete(global::System.Nullable<long> x_lMid)
        {
            return DeleteProc(n_oDB, x_lMid);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return DeleteProc(x_oDB, x_lMid);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lMid)
        {
            if (x_lMid==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderThreePartyRevision]  WHERE [MobileOrderThreePartyRevision].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.BigInt).Value = x_lMid;
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
            return MobileOrderThreePartyRevisionRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderThreePartyRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderThreePartyRevision]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
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


