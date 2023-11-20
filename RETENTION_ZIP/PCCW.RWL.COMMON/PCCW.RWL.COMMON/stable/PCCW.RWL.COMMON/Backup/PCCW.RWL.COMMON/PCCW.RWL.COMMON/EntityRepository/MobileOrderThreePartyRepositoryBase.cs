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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderThreeParty],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderThreeParty] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderThreeParty")]
    public class MobileOrderThreePartyRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderThreePartyRepositoryBase instance;
        public static MobileOrderThreePartyRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderThreePartyRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderThreePartyRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderThreePartyRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderThreePartyEntity> MobileOrderThreePartys;
        #endregion
        
        #region Constructor
        public MobileOrderThreePartyRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderThreePartyRepositoryBase() { 
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
        public static MobileOrderThreeParty CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderThreeParty(_oDB);
        }
        
        public static MobileOrderThreeParty CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderThreeParty(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderThreeParty]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
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
        
        
        public MobileOrderThreePartyEntity GetObj(global::System.Nullable<long> x_lTpy_id)
        {
            return GetObj(n_oDB, x_lTpy_id);
        }
        
        
        public static MobileOrderThreePartyEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id)
        {
            if (x_oDB==null) { return null; }
            MobileOrderThreeParty _MobileOrderThreeParty = (MobileOrderThreeParty)MobileOrderThreePartyRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderThreeParty.Load(x_lTpy_id)) { return null; }
            return _MobileOrderThreeParty;
        }
        
        
        
        public static MobileOrderThreePartyEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderThreePartyEntity> _oMobileOrderThreePartyList = GetListObj(x_oDB,0, "tpy_id", x_oArrayItemId);
            if(_oMobileOrderThreePartyList==null){ return null;}
            return _oMobileOrderThreePartyList.Count == 0 ? null : _oMobileOrderThreePartyList.ToArray();
        }
        
        public static List<MobileOrderThreePartyEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "tpy_id", x_oArrayItemId);
        }
        
        
        public static MobileOrderThreePartyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderThreePartyEntity> _oMobileOrderThreePartyList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderThreePartyList==null){ return null;}
            return _oMobileOrderThreePartyList.Count == 0 ? null : _oMobileOrderThreePartyList.ToArray();
        }
        
        
        public static MobileOrderThreePartyEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderThreePartyEntity> _oMobileOrderThreePartyList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderThreePartyList==null){ return null;}
            return _oMobileOrderThreePartyList.Count == 0 ? null : _oMobileOrderThreePartyList.ToArray();
        }
        
        public static List<MobileOrderThreePartyEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderThreePartyEntity> _oRow = new List<MobileOrderThreePartyEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderThreeParty].[tpy_id] AS MOBILEORDERTHREEPARTY_TPY_ID,[MobileOrderThreeParty].[hkid] AS MOBILEORDERTHREEPARTY_HKID,[MobileOrderThreeParty].[arthurization_person] AS MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON,[MobileOrderThreeParty].[id_type] AS MOBILEORDERTHREEPARTY_ID_TYPE,[MobileOrderThreeParty].[type] AS MOBILEORDERTHREEPARTY_TYPE,[MobileOrderThreeParty].[contact_no] AS MOBILEORDERTHREEPARTY_CONTACT_NO,[MobileOrderThreeParty].[plural] AS MOBILEORDERTHREEPARTY_PLURAL,[MobileOrderThreeParty].[order_id] AS MOBILEORDERTHREEPARTY_ORDER_ID,[MobileOrderThreeParty].[three_party] AS MOBILEORDERTHREEPARTY_THREE_PARTY  FROM  [MobileOrderThreeParty]";
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
                _sQuery += " WHERE [MobileOrderThreeParty].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderThreeParty _oMobileOrderThreeParty = MobileOrderThreePartyRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_TPY_ID"])) {_oMobileOrderThreeParty.tpy_id = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTY_TPY_ID"]; }else{_oMobileOrderThreeParty.tpy_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON"])) {_oMobileOrderThreeParty.arthurization_person = (string)_oData["MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON"]; }else{_oMobileOrderThreeParty.arthurization_person=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_CONTACT_NO"])) {_oMobileOrderThreeParty.contact_no = (string)_oData["MOBILEORDERTHREEPARTY_CONTACT_NO"]; }else{_oMobileOrderThreeParty.contact_no=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_TYPE"])) {_oMobileOrderThreeParty.type = (string)_oData["MOBILEORDERTHREEPARTY_TYPE"]; }else{_oMobileOrderThreeParty.type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ID_TYPE"])) {_oMobileOrderThreeParty.id_type = (string)_oData["MOBILEORDERTHREEPARTY_ID_TYPE"]; }else{_oMobileOrderThreeParty.id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_PLURAL"])) {_oMobileOrderThreeParty.plural = (string)_oData["MOBILEORDERTHREEPARTY_PLURAL"]; }else{_oMobileOrderThreeParty.plural=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_HKID"])) {_oMobileOrderThreeParty.hkid = (string)_oData["MOBILEORDERTHREEPARTY_HKID"]; }else{_oMobileOrderThreeParty.hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ORDER_ID"])) {_oMobileOrderThreeParty.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERTHREEPARTY_ORDER_ID"]; }else{_oMobileOrderThreeParty.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_THREE_PARTY"])) {_oMobileOrderThreeParty.three_party = (global::System.Nullable<bool>)_oData["MOBILEORDERTHREEPARTY_THREE_PARTY"]; }else{_oMobileOrderThreeParty.three_party=null;}
                        _oMobileOrderThreeParty.SetDB(x_oDB);
                        _oMobileOrderThreeParty.GetFound();
                        _oRow.Add(_oMobileOrderThreeParty);
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
        
        
        public static MobileOrderThreePartyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderThreePartyEntity> _oMobileOrderThreePartyList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderThreePartyList==null){ return null;}
            return _oMobileOrderThreePartyList.Count == 0 ? null : _oMobileOrderThreePartyList.ToArray();
        }
        
        
        public static MobileOrderThreePartyEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderThreePartyEntity> _oMobileOrderThreePartyList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderThreePartyList==null){ return null;}
            return _oMobileOrderThreePartyList.Count == 0 ? null : _oMobileOrderThreePartyList.ToArray();
        }
        
        public static List<MobileOrderThreePartyEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderThreePartyEntity> _oRow = new List<MobileOrderThreePartyEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderThreeParty].[tpy_id] AS MOBILEORDERTHREEPARTY_TPY_ID,[MobileOrderThreeParty].[hkid] AS MOBILEORDERTHREEPARTY_HKID,[MobileOrderThreeParty].[arthurization_person] AS MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON,[MobileOrderThreeParty].[id_type] AS MOBILEORDERTHREEPARTY_ID_TYPE,[MobileOrderThreeParty].[type] AS MOBILEORDERTHREEPARTY_TYPE,[MobileOrderThreeParty].[contact_no] AS MOBILEORDERTHREEPARTY_CONTACT_NO,[MobileOrderThreeParty].[plural] AS MOBILEORDERTHREEPARTY_PLURAL,[MobileOrderThreeParty].[order_id] AS MOBILEORDERTHREEPARTY_ORDER_ID,[MobileOrderThreeParty].[three_party] AS MOBILEORDERTHREEPARTY_THREE_PARTY";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderThreePartyRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderThreePartyEntity _oMobileOrderThreeParty = MobileOrderThreePartyRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_TPY_ID"])) {_oMobileOrderThreeParty.tpy_id = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTY_TPY_ID"]; } else {_oMobileOrderThreeParty.tpy_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON"])) {_oMobileOrderThreeParty.arthurization_person = (string)_oData["MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON"]; } else {_oMobileOrderThreeParty.arthurization_person=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_CONTACT_NO"])) {_oMobileOrderThreeParty.contact_no = (string)_oData["MOBILEORDERTHREEPARTY_CONTACT_NO"]; } else {_oMobileOrderThreeParty.contact_no=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_TYPE"])) {_oMobileOrderThreeParty.type = (string)_oData["MOBILEORDERTHREEPARTY_TYPE"]; } else {_oMobileOrderThreeParty.type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ID_TYPE"])) {_oMobileOrderThreeParty.id_type = (string)_oData["MOBILEORDERTHREEPARTY_ID_TYPE"]; } else {_oMobileOrderThreeParty.id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_PLURAL"])) {_oMobileOrderThreeParty.plural = (string)_oData["MOBILEORDERTHREEPARTY_PLURAL"]; } else {_oMobileOrderThreeParty.plural=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_HKID"])) {_oMobileOrderThreeParty.hkid = (string)_oData["MOBILEORDERTHREEPARTY_HKID"]; } else {_oMobileOrderThreeParty.hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ORDER_ID"])) {_oMobileOrderThreeParty.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERTHREEPARTY_ORDER_ID"]; } else {_oMobileOrderThreeParty.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_THREE_PARTY"])) {_oMobileOrderThreeParty.three_party = (global::System.Nullable<bool>)_oData["MOBILEORDERTHREEPARTY_THREE_PARTY"]; } else {_oMobileOrderThreeParty.three_party=null; }
                _oMobileOrderThreeParty.SetDB(x_oDB);
                _oMobileOrderThreeParty.GetFound();
                _oRow.Add(_oMobileOrderThreeParty);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderThreeParty.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderThreeParty.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderThreeParty.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderThreeParty.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderThreeParty].[tpy_id] AS MOBILEORDERTHREEPARTY_TPY_ID,[MobileOrderThreeParty].[hkid] AS MOBILEORDERTHREEPARTY_HKID,[MobileOrderThreeParty].[arthurization_person] AS MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON,[MobileOrderThreeParty].[id_type] AS MOBILEORDERTHREEPARTY_ID_TYPE,[MobileOrderThreeParty].[type] AS MOBILEORDERTHREEPARTY_TYPE,[MobileOrderThreeParty].[contact_no] AS MOBILEORDERTHREEPARTY_CONTACT_NO,[MobileOrderThreeParty].[plural] AS MOBILEORDERTHREEPARTY_PLURAL,[MobileOrderThreeParty].[order_id] AS MOBILEORDERTHREEPARTY_ORDER_ID,[MobileOrderThreeParty].[three_party] AS MOBILEORDERTHREEPARTY_THREE_PARTY  FROM  [MobileOrderThreeParty]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderThreeParty");
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
        
        public bool Insert(string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            MobileOrderThreeParty _oMobileOrderThreeParty=MobileOrderThreePartyRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderThreeParty.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreeParty.contact_no=x_sContact_no;
            _oMobileOrderThreeParty.type=x_sType;
            _oMobileOrderThreeParty.id_type=x_sId_type;
            _oMobileOrderThreeParty.plural=x_sPlural;
            _oMobileOrderThreeParty.hkid=x_sHkid;
            _oMobileOrderThreeParty.order_id=x_iOrder_id;
            _oMobileOrderThreeParty.three_party=x_bThree_party;
            return InsertWithOutLastID(n_oDB, _oMobileOrderThreeParty);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            MobileOrderThreeParty _oMobileOrderThreeParty=MobileOrderThreePartyRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderThreeParty.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreeParty.contact_no=x_sContact_no;
            _oMobileOrderThreeParty.type=x_sType;
            _oMobileOrderThreeParty.id_type=x_sId_type;
            _oMobileOrderThreeParty.plural=x_sPlural;
            _oMobileOrderThreeParty.hkid=x_sHkid;
            _oMobileOrderThreeParty.order_id=x_iOrder_id;
            _oMobileOrderThreeParty.three_party=x_bThree_party;
            return InsertWithOutLastID(x_oDB, _oMobileOrderThreeParty);
        }
        
        
        public bool Insert(MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderThreeParty);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderThreeParty)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderThreeParty)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderThreeParty);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderThreeParty]   ([hkid],[arthurization_person],[id_type],[type],[contact_no],[plural],[order_id],[three_party])  VALUES  (@hkid,@arthurization_person,@id_type,@type,@contact_no,@plural,@order_id,@three_party)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderThreeParty);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            bool _bResult = false;
            if (!x_oMobileOrderThreeParty.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderThreeParty.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderThreeParty.hkid; }
                if(x_oMobileOrderThreeParty.arthurization_person==null){  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderThreeParty.arthurization_person; }
                if(x_oMobileOrderThreeParty.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderThreeParty.id_type; }
                if(x_oMobileOrderThreeParty.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderThreeParty.type; }
                if(x_oMobileOrderThreeParty.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreeParty.contact_no; }
                if(x_oMobileOrderThreeParty.plural==null){  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreeParty.plural; }
                if(x_oMobileOrderThreeParty.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderThreeParty.order_id; }
                if(x_oMobileOrderThreeParty.three_party==null){  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderThreeParty.three_party; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            int _oLastID;
            MobileOrderThreeParty _oMobileOrderThreeParty=MobileOrderThreePartyRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderThreeParty.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreeParty.contact_no=x_sContact_no;
            _oMobileOrderThreeParty.type=x_sType;
            _oMobileOrderThreeParty.id_type=x_sId_type;
            _oMobileOrderThreeParty.plural=x_sPlural;
            _oMobileOrderThreeParty.hkid=x_sHkid;
            _oMobileOrderThreeParty.order_id=x_iOrder_id;
            _oMobileOrderThreeParty.three_party=x_bThree_party;
            if(InsertWithLastID(x_oDB, _oMobileOrderThreeParty,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderThreeParty, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderThreeParty, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderThreeParty)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderThreeParty)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderThreeParty x_oMobileOrderThreeParty, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderThreeParty]   ([hkid],[arthurization_person],[id_type],[type],[contact_no],[plural],[order_id],[three_party])  VALUES  (@hkid,@arthurization_person,@id_type,@type,@contact_no,@plural,@order_id,@three_party)"+" SELECT  @@IDENTITY AS MobileOrderThreeParty_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderThreeParty,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderThreeParty x_oMobileOrderThreeParty, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderThreeParty.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderThreeParty.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30).Value=x_oMobileOrderThreeParty.hkid; }
                if(x_oMobileOrderThreeParty.arthurization_person==null){  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250).Value=x_oMobileOrderThreeParty.arthurization_person; }
                if(x_oMobileOrderThreeParty.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderThreeParty.id_type; }
                if(x_oMobileOrderThreeParty.type==null){  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderThreeParty.type; }
                if(x_oMobileOrderThreeParty.contact_no==null){  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreeParty.contact_no; }
                if(x_oMobileOrderThreeParty.plural==null){  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20).Value=x_oMobileOrderThreeParty.plural; }
                if(x_oMobileOrderThreeParty.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderThreeParty.order_id; }
                if(x_oMobileOrderThreeParty.three_party==null){  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderThreeParty.three_party; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderThreeParty_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderThreeParty_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderThreeParty_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            int _oLastID;
            MobileOrderThreeParty _oMobileOrderThreeParty=MobileOrderThreePartyRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderThreeParty.arthurization_person=x_sArthurization_person;
            _oMobileOrderThreeParty.contact_no=x_sContact_no;
            _oMobileOrderThreeParty.type=x_sType;
            _oMobileOrderThreeParty.id_type=x_sId_type;
            _oMobileOrderThreeParty.plural=x_sPlural;
            _oMobileOrderThreeParty.hkid=x_sHkid;
            _oMobileOrderThreeParty.order_id=x_iOrder_id;
            _oMobileOrderThreeParty.three_party=x_bThree_party;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderThreeParty,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderThreeParty, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderThreeParty, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderThreeParty)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderThreeParty)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderThreeParty x_oMobileOrderThreeParty, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERTHREEPARTY";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderThreeParty,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderThreeParty x_oMobileOrderThreeParty, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,30);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.hkid; }
                _oPar=x_oCmd.Parameters.Add("@arthurization_person", global::System.Data.SqlDbType.NVarChar,250);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.arthurization_person==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.arthurization_person; }
                _oPar=x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.id_type; }
                _oPar=x_oCmd.Parameters.Add("@type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.type; }
                _oPar=x_oCmd.Parameters.Add("@contact_no", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.contact_no==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.contact_no; }
                _oPar=x_oCmd.Parameters.Add("@plural", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.plural==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.plural; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.order_id; }
                _oPar=x_oCmd.Parameters.Add("@three_party", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderThreeParty.three_party==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderThreeParty.three_party; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_TPY_ID", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_TPY_ID"].Value.ToString());
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
        
        #region INSERT_MOBILEORDERTHREEPARTY Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-03-08>
        ///-- Description:	<Description,MOBILEORDERTHREEPARTY, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERTHREEPARTY Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERTHREEPARTY', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERTHREEPARTY;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERTHREEPARTY
        	-- Add the parameters for the stored procedure here
        @RETURN_TPY_ID bigint output,
        @arthurization_person nvarchar(250),
        @contact_no nvarchar(20),
        @type nvarchar(50),
        @id_type nvarchar(10),
        @plural nvarchar(20),
        @hkid nvarchar(30),
        @order_id int,
        @three_party bit
        AS
        
        INSERT INTO  [MobileOrderThreeParty]   ([hkid],[arthurization_person],[id_type],[type],[contact_no],[plural],[order_id],[three_party])  VALUES  (@hkid,@arthurization_person,@id_type,@type,@contact_no,@plural,@order_id,@three_party)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_TPY_ID=@@IDENTITY
        RETURN @RETURN_TPY_ID
        END
        ELSE
        BEGIN
        SET @RETURN_TPY_ID=-1
        RETURN @RETURN_TPY_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<long> x_lTpy_id)
        {
            return DeleteProc(n_oDB, x_lTpy_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id)
        {
            return DeleteProc(x_oDB, x_lTpy_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lTpy_id)
        {
            if (x_lTpy_id==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderThreeParty]  WHERE [MobileOrderThreeParty].[tpy_id]=@tpy_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@tpy_id", global::System.Data.SqlDbType.BigInt).Value = x_lTpy_id;
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
            return MobileOrderThreePartyRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderThreeParty]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderThreeParty]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
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


