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
///-- Description:	<Description,Table :[MobileOrderMNPDetailRevision],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderMNPDetailRevision] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderMNPDetailRevision")]
    public class MobileOrderMNPDetailRevisionRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderMNPDetailRevisionRepositoryBase instance;
        public static MobileOrderMNPDetailRevisionRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderMNPDetailRevisionRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderMNPDetailRevisionRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderMNPDetailRevisionRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderMNPDetailRevisionEntity> MobileOrderMNPDetailRevisions;
        #endregion
        
        #region Constructor
        public MobileOrderMNPDetailRevisionRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderMNPDetailRevisionRepositoryBase() { 
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
        public static MobileOrderMNPDetailRevision CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderMNPDetailRevision(_oDB);
        }
        
        public static MobileOrderMNPDetailRevision CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderMNPDetailRevision(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderMNPDetailRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
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
        
        
        public MobileOrderMNPDetailRevisionEntity GetObj(global::System.Nullable<long> x_lMid)
        {
            return GetObj(n_oDB, x_lMid);
        }
        
        
        public static MobileOrderMNPDetailRevisionEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            if (x_oDB==null) { return null; }
            MobileOrderMNPDetailRevision _MobileOrderMNPDetailRevision = (MobileOrderMNPDetailRevision)MobileOrderMNPDetailRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderMNPDetailRevision.Load(x_lMid)) { return null; }
            return _MobileOrderMNPDetailRevision;
        }
        
        
        
        public static MobileOrderMNPDetailRevisionEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderMNPDetailRevisionEntity> _oMobileOrderMNPDetailRevisionList = GetListObj(x_oDB,0, "mid", x_oArrayItemId);
            if(_oMobileOrderMNPDetailRevisionList==null){ return null;}
            return _oMobileOrderMNPDetailRevisionList.Count == 0 ? null : _oMobileOrderMNPDetailRevisionList.ToArray();
        }
        
        public static List<MobileOrderMNPDetailRevisionEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mid", x_oArrayItemId);
        }
        
        
        public static MobileOrderMNPDetailRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMNPDetailRevisionEntity> _oMobileOrderMNPDetailRevisionList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderMNPDetailRevisionList==null){ return null;}
            return _oMobileOrderMNPDetailRevisionList.Count == 0 ? null : _oMobileOrderMNPDetailRevisionList.ToArray();
        }
        
        
        public static MobileOrderMNPDetailRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMNPDetailRevisionEntity> _oMobileOrderMNPDetailRevisionList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderMNPDetailRevisionList==null){ return null;}
            return _oMobileOrderMNPDetailRevisionList.Count == 0 ? null : _oMobileOrderMNPDetailRevisionList.ToArray();
        }
        
        public static List<MobileOrderMNPDetailRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderMNPDetailRevisionEntity> _oRow = new List<MobileOrderMNPDetailRevisionEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderMNPDetailRevision].[service_activation_time] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetailRevision].[ticker_number] AS MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER,[MobileOrderMNPDetailRevision].[id_type] AS MOBILEORDERMNPDETAILREVISION_ID_TYPE,[MobileOrderMNPDetailRevision].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetailRevision].[transfer_idd_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetailRevision].[service_activation_date] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetailRevision].[mnp_id] AS MOBILEORDERMNPDETAILREVISION_MNP_ID,[MobileOrderMNPDetailRevision].[transfer_others_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetailRevision].[registered_name] AS MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME,[MobileOrderMNPDetailRevision].[hkid] AS MOBILEORDERMNPDETAILREVISION_HKID,[MobileOrderMNPDetailRevision].[transfer_to_3g] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G,[MobileOrderMNPDetailRevision].[order_id] AS MOBILEORDERMNPDETAILREVISION_ORDER_ID,[MobileOrderMNPDetailRevision].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetailRevision].[mid] AS MOBILEORDERMNPDETAILREVISION_MID,[MobileOrderMNPDetailRevision].[company_name] AS MOBILEORDERMNPDETAILREVISION_COMPANY_NAME,[MobileOrderMNPDetailRevision].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT  FROM  [MobileOrderMNPDetailRevision]";
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
                _sQuery += " WHERE [MobileOrderMNPDetailRevision].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderMNPDetailRevision _oMobileOrderMNPDetailRevision = MobileOrderMNPDetailRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME"])) {_oMobileOrderMNPDetailRevision.service_activation_time = (string)_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME"]; }else{_oMobileOrderMNPDetailRevision.service_activation_time=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER"])) {_oMobileOrderMNPDetailRevision.ticker_number = (string)_oData["MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER"]; }else{_oMobileOrderMNPDetailRevision.ticker_number=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_ID_TYPE"])) {_oMobileOrderMNPDetailRevision.id_type = (string)_oData["MOBILEORDERMNPDETAILREVISION_ID_TYPE"]; }else{_oMobileOrderMNPDetailRevision.id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT"]; }else{_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_COMPANY_NAME"])) {_oMobileOrderMNPDetailRevision.company_name = (string)_oData["MOBILEORDERMNPDETAILREVISION_COMPANY_NAME"]; }else{_oMobileOrderMNPDetailRevision.company_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE"])) {_oMobileOrderMNPDetailRevision.service_activation_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE"]; }else{_oMobileOrderMNPDetailRevision.service_activation_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_MNP_ID"])) {_oMobileOrderMNPDetailRevision.mnp_id = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_MNP_ID"]; }else{_oMobileOrderMNPDetailRevision.mnp_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_others_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT"]; }else{_oMobileOrderMNPDetailRevision.transfer_others_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_MID"])) {_oMobileOrderMNPDetailRevision.mid = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_MID"]; }else{_oMobileOrderMNPDetailRevision.mid=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_HKID"])) {_oMobileOrderMNPDetailRevision.hkid = (string)_oData["MOBILEORDERMNPDETAILREVISION_HKID"]; }else{_oMobileOrderMNPDetailRevision.hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G"])) {_oMobileOrderMNPDetailRevision.transfer_to_3g = (global::System.Nullable<bool>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G"]; }else{_oMobileOrderMNPDetailRevision.transfer_to_3g=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_idd_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT"]; }else{_oMobileOrderMNPDetailRevision.transfer_idd_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT"]; }else{_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_ORDER_ID"])) {_oMobileOrderMNPDetailRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERMNPDETAILREVISION_ORDER_ID"]; }else{_oMobileOrderMNPDetailRevision.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME"])) {_oMobileOrderMNPDetailRevision.registered_name = (string)_oData["MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME"]; }else{_oMobileOrderMNPDetailRevision.registered_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"]; }else{_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit=null;}
                        _oMobileOrderMNPDetailRevision.SetDB(x_oDB);
                        _oMobileOrderMNPDetailRevision.GetFound();
                        _oRow.Add(_oMobileOrderMNPDetailRevision);
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
        
        
        public static MobileOrderMNPDetailRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMNPDetailRevisionEntity> _oMobileOrderMNPDetailRevisionList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderMNPDetailRevisionList==null){ return null;}
            return _oMobileOrderMNPDetailRevisionList.Count == 0 ? null : _oMobileOrderMNPDetailRevisionList.ToArray();
        }
        
        
        public static MobileOrderMNPDetailRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMNPDetailRevisionEntity> _oMobileOrderMNPDetailRevisionList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderMNPDetailRevisionList==null){ return null;}
            return _oMobileOrderMNPDetailRevisionList.Count == 0 ? null : _oMobileOrderMNPDetailRevisionList.ToArray();
        }
        
        public static List<MobileOrderMNPDetailRevisionEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderMNPDetailRevisionEntity> _oRow = new List<MobileOrderMNPDetailRevisionEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderMNPDetailRevision].[service_activation_time] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetailRevision].[ticker_number] AS MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER,[MobileOrderMNPDetailRevision].[id_type] AS MOBILEORDERMNPDETAILREVISION_ID_TYPE,[MobileOrderMNPDetailRevision].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetailRevision].[transfer_idd_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetailRevision].[service_activation_date] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetailRevision].[mnp_id] AS MOBILEORDERMNPDETAILREVISION_MNP_ID,[MobileOrderMNPDetailRevision].[transfer_others_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetailRevision].[registered_name] AS MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME,[MobileOrderMNPDetailRevision].[hkid] AS MOBILEORDERMNPDETAILREVISION_HKID,[MobileOrderMNPDetailRevision].[transfer_to_3g] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G,[MobileOrderMNPDetailRevision].[order_id] AS MOBILEORDERMNPDETAILREVISION_ORDER_ID,[MobileOrderMNPDetailRevision].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetailRevision].[mid] AS MOBILEORDERMNPDETAILREVISION_MID,[MobileOrderMNPDetailRevision].[company_name] AS MOBILEORDERMNPDETAILREVISION_COMPANY_NAME,[MobileOrderMNPDetailRevision].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderMNPDetailRevisionRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderMNPDetailRevisionEntity _oMobileOrderMNPDetailRevision = MobileOrderMNPDetailRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME"])) {_oMobileOrderMNPDetailRevision.service_activation_time = (string)_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME"]; } else {_oMobileOrderMNPDetailRevision.service_activation_time=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER"])) {_oMobileOrderMNPDetailRevision.ticker_number = (string)_oData["MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER"]; } else {_oMobileOrderMNPDetailRevision.ticker_number=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_ID_TYPE"])) {_oMobileOrderMNPDetailRevision.id_type = (string)_oData["MOBILEORDERMNPDETAILREVISION_ID_TYPE"]; } else {_oMobileOrderMNPDetailRevision.id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT"]; } else {_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_COMPANY_NAME"])) {_oMobileOrderMNPDetailRevision.company_name = (string)_oData["MOBILEORDERMNPDETAILREVISION_COMPANY_NAME"]; } else {_oMobileOrderMNPDetailRevision.company_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE"])) {_oMobileOrderMNPDetailRevision.service_activation_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE"]; } else {_oMobileOrderMNPDetailRevision.service_activation_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_MNP_ID"])) {_oMobileOrderMNPDetailRevision.mnp_id = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_MNP_ID"]; } else {_oMobileOrderMNPDetailRevision.mnp_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_others_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT"]; } else {_oMobileOrderMNPDetailRevision.transfer_others_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_MID"])) {_oMobileOrderMNPDetailRevision.mid = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_MID"]; } else {_oMobileOrderMNPDetailRevision.mid=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_HKID"])) {_oMobileOrderMNPDetailRevision.hkid = (string)_oData["MOBILEORDERMNPDETAILREVISION_HKID"]; } else {_oMobileOrderMNPDetailRevision.hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G"])) {_oMobileOrderMNPDetailRevision.transfer_to_3g = (global::System.Nullable<bool>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G"]; } else {_oMobileOrderMNPDetailRevision.transfer_to_3g=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_idd_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT"]; } else {_oMobileOrderMNPDetailRevision.transfer_idd_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT"]; } else {_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_ORDER_ID"])) {_oMobileOrderMNPDetailRevision.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERMNPDETAILREVISION_ORDER_ID"]; } else {_oMobileOrderMNPDetailRevision.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME"])) {_oMobileOrderMNPDetailRevision.registered_name = (string)_oData["MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME"]; } else {_oMobileOrderMNPDetailRevision.registered_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"])) {_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"]; } else {_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit=null; }
                _oMobileOrderMNPDetailRevision.SetDB(x_oDB);
                _oMobileOrderMNPDetailRevision.GetFound();
                _oRow.Add(_oMobileOrderMNPDetailRevision);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderMNPDetailRevision.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderMNPDetailRevision.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderMNPDetailRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderMNPDetailRevision.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderMNPDetailRevision].[service_activation_time] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetailRevision].[ticker_number] AS MOBILEORDERMNPDETAILREVISION_TICKER_NUMBER,[MobileOrderMNPDetailRevision].[id_type] AS MOBILEORDERMNPDETAILREVISION_ID_TYPE,[MobileOrderMNPDetailRevision].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetailRevision].[transfer_idd_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetailRevision].[service_activation_date] AS MOBILEORDERMNPDETAILREVISION_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetailRevision].[mnp_id] AS MOBILEORDERMNPDETAILREVISION_MNP_ID,[MobileOrderMNPDetailRevision].[transfer_others_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetailRevision].[registered_name] AS MOBILEORDERMNPDETAILREVISION_REGISTERED_NAME,[MobileOrderMNPDetailRevision].[hkid] AS MOBILEORDERMNPDETAILREVISION_HKID,[MobileOrderMNPDetailRevision].[transfer_to_3g] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_TO_3G,[MobileOrderMNPDetailRevision].[order_id] AS MOBILEORDERMNPDETAILREVISION_ORDER_ID,[MobileOrderMNPDetailRevision].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetailRevision].[mid] AS MOBILEORDERMNPDETAILREVISION_MID,[MobileOrderMNPDetailRevision].[company_name] AS MOBILEORDERMNPDETAILREVISION_COMPANY_NAME,[MobileOrderMNPDetailRevision].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAILREVISION_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT  FROM  [MobileOrderMNPDetailRevision]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderMNPDetailRevision");
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
        
        public bool Insert(string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lMnp_id,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            MobileOrderMNPDetailRevision _oMobileOrderMNPDetailRevision=MobileOrderMNPDetailRevisionRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderMNPDetailRevision.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetailRevision.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetailRevision.id_type=x_sId_type;
            _oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetailRevision.company_name=x_sCompany_name;
            _oMobileOrderMNPDetailRevision.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetailRevision.mnp_id=x_lMnp_id;
            _oMobileOrderMNPDetailRevision.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetailRevision.hkid=x_sHkid;
            _oMobileOrderMNPDetailRevision.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetailRevision.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetailRevision.order_id=x_iOrder_id;
            _oMobileOrderMNPDetailRevision.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            return InsertWithOutLastID(n_oDB, _oMobileOrderMNPDetailRevision);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lMnp_id,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            MobileOrderMNPDetailRevision _oMobileOrderMNPDetailRevision=MobileOrderMNPDetailRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMNPDetailRevision.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetailRevision.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetailRevision.id_type=x_sId_type;
            _oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetailRevision.company_name=x_sCompany_name;
            _oMobileOrderMNPDetailRevision.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetailRevision.mnp_id=x_lMnp_id;
            _oMobileOrderMNPDetailRevision.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetailRevision.hkid=x_sHkid;
            _oMobileOrderMNPDetailRevision.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetailRevision.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetailRevision.order_id=x_iOrder_id;
            _oMobileOrderMNPDetailRevision.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            return InsertWithOutLastID(x_oDB, _oMobileOrderMNPDetailRevision);
        }
        
        
        public bool Insert(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderMNPDetailRevision);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderMNPDetailRevision)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderMNPDetailRevision)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderMNPDetailRevision);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderMNPDetailRevision]   ([service_activation_time],[ticker_number],[id_type],[transfer_idd_roaming_deposit],[transfer_idd_deposit],[service_activation_date],[mnp_id],[transfer_others_deposit],[registered_name],[hkid],[transfer_to_3g],[order_id],[transfer_no_add_proof_deposit],[company_name],[transfer_no_hk_id_holder_deposit])  VALUES  (@service_activation_time,@ticker_number,@id_type,@transfer_idd_roaming_deposit,@transfer_idd_deposit,@service_activation_date,@mnp_id,@transfer_others_deposit,@registered_name,@hkid,@transfer_to_3g,@order_id,@transfer_no_add_proof_deposit,@company_name,@transfer_no_hk_id_holder_deposit)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderMNPDetailRevision);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            bool _bResult = false;
            if (!x_oMobileOrderMNPDetailRevision.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderMNPDetailRevision.service_activation_time==null){  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.service_activation_time; }
                if(x_oMobileOrderMNPDetailRevision.ticker_number==null){  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.ticker_number; }
                if(x_oMobileOrderMNPDetailRevision.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.id_type; }
                if(x_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit; }
                if(x_oMobileOrderMNPDetailRevision.transfer_idd_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_idd_deposit; }
                if(x_oMobileOrderMNPDetailRevision.service_activation_date==null){  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMNPDetailRevision.service_activation_date; }
                if(x_oMobileOrderMNPDetailRevision.mnp_id==null){  x_oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.mnp_id; }
                if(x_oMobileOrderMNPDetailRevision.transfer_others_deposit==null){  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_others_deposit; }
                if(x_oMobileOrderMNPDetailRevision.registered_name==null){  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.registered_name; }
                if(x_oMobileOrderMNPDetailRevision.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.hkid; }
                if(x_oMobileOrderMNPDetailRevision.transfer_to_3g==null){  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMNPDetailRevision.transfer_to_3g; }
                if(x_oMobileOrderMNPDetailRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderMNPDetailRevision.order_id; }
                if(x_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit; }
                if(x_oMobileOrderMNPDetailRevision.company_name==null){  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.company_name; }
                if(x_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lMnp_id,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            int _oLastID;
            MobileOrderMNPDetailRevision _oMobileOrderMNPDetailRevision=MobileOrderMNPDetailRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMNPDetailRevision.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetailRevision.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetailRevision.id_type=x_sId_type;
            _oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetailRevision.company_name=x_sCompany_name;
            _oMobileOrderMNPDetailRevision.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetailRevision.mnp_id=x_lMnp_id;
            _oMobileOrderMNPDetailRevision.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetailRevision.hkid=x_sHkid;
            _oMobileOrderMNPDetailRevision.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetailRevision.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetailRevision.order_id=x_iOrder_id;
            _oMobileOrderMNPDetailRevision.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            if(InsertWithLastID(x_oDB, _oMobileOrderMNPDetailRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderMNPDetailRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderMNPDetailRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderMNPDetailRevision)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderMNPDetailRevision)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderMNPDetailRevision]   ([service_activation_time],[ticker_number],[id_type],[transfer_idd_roaming_deposit],[transfer_idd_deposit],[service_activation_date],[mnp_id],[transfer_others_deposit],[registered_name],[hkid],[transfer_to_3g],[order_id],[transfer_no_add_proof_deposit],[company_name],[transfer_no_hk_id_holder_deposit])  VALUES  (@service_activation_time,@ticker_number,@id_type,@transfer_idd_roaming_deposit,@transfer_idd_deposit,@service_activation_date,@mnp_id,@transfer_others_deposit,@registered_name,@hkid,@transfer_to_3g,@order_id,@transfer_no_add_proof_deposit,@company_name,@transfer_no_hk_id_holder_deposit)"+" SELECT  @@IDENTITY AS MobileOrderMNPDetailRevision_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderMNPDetailRevision,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderMNPDetailRevision.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderMNPDetailRevision.service_activation_time==null){  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.service_activation_time; }
                if(x_oMobileOrderMNPDetailRevision.ticker_number==null){  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.ticker_number; }
                if(x_oMobileOrderMNPDetailRevision.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.id_type; }
                if(x_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit; }
                if(x_oMobileOrderMNPDetailRevision.transfer_idd_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_idd_deposit; }
                if(x_oMobileOrderMNPDetailRevision.service_activation_date==null){  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMNPDetailRevision.service_activation_date; }
                if(x_oMobileOrderMNPDetailRevision.mnp_id==null){  x_oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.mnp_id; }
                if(x_oMobileOrderMNPDetailRevision.transfer_others_deposit==null){  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_others_deposit; }
                if(x_oMobileOrderMNPDetailRevision.registered_name==null){  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.registered_name; }
                if(x_oMobileOrderMNPDetailRevision.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.hkid; }
                if(x_oMobileOrderMNPDetailRevision.transfer_to_3g==null){  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMNPDetailRevision.transfer_to_3g; }
                if(x_oMobileOrderMNPDetailRevision.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderMNPDetailRevision.order_id; }
                if(x_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit; }
                if(x_oMobileOrderMNPDetailRevision.company_name==null){  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetailRevision.company_name; }
                if(x_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderMNPDetailRevision_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderMNPDetailRevision_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderMNPDetailRevision_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lMnp_id,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            int _oLastID;
            MobileOrderMNPDetailRevision _oMobileOrderMNPDetailRevision=MobileOrderMNPDetailRevisionRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMNPDetailRevision.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetailRevision.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetailRevision.id_type=x_sId_type;
            _oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetailRevision.company_name=x_sCompany_name;
            _oMobileOrderMNPDetailRevision.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetailRevision.mnp_id=x_lMnp_id;
            _oMobileOrderMNPDetailRevision.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetailRevision.hkid=x_sHkid;
            _oMobileOrderMNPDetailRevision.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetailRevision.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetailRevision.order_id=x_iOrder_id;
            _oMobileOrderMNPDetailRevision.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderMNPDetailRevision,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderMNPDetailRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderMNPDetailRevision, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderMNPDetailRevision)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderMNPDetailRevision)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERMNPDETAILREVISION";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderMNPDetailRevision,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMNPDetailRevision x_oMobileOrderMNPDetailRevision, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.service_activation_time==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.service_activation_time; }
                _oPar=x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.ticker_number==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.ticker_number; }
                _oPar=x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.id_type; }
                _oPar=x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.transfer_idd_roaming_deposit; }
                _oPar=x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.transfer_idd_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.transfer_idd_deposit; }
                _oPar=x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.service_activation_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.service_activation_date; }
                _oPar=x_oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.mnp_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.mnp_id; }
                _oPar=x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.transfer_others_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.transfer_others_deposit; }
                _oPar=x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.registered_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.registered_name; }
                _oPar=x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.hkid; }
                _oPar=x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.transfer_to_3g==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.transfer_to_3g; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.order_id; }
                _oPar=x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.transfer_no_add_proof_deposit; }
                _oPar=x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.company_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.company_name; }
                _oPar=x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetailRevision.transfer_no_hk_id_holder_deposit; }
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
        
        #region INSERT_MOBILEORDERMNPDETAILREVISION Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2011-03-08>
        ///-- Description:	<Description,MOBILEORDERMNPDETAILREVISION, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERMNPDETAILREVISION Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERMNPDETAILREVISION', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERMNPDETAILREVISION;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERMNPDETAILREVISION
        	-- Add the parameters for the stored procedure here
        @RETURN_MID bigint output,
        @service_activation_time nvarchar(50),
        @ticker_number nvarchar(50),
        @id_type nvarchar(50),
        @transfer_idd_roaming_deposit bigint,
        @company_name nvarchar(50),
        @service_activation_date datetime,
        @mnp_id bigint,
        @transfer_others_deposit bigint,
        @hkid nvarchar(50),
        @transfer_to_3g bit,
        @transfer_idd_deposit bigint,
        @transfer_no_add_proof_deposit bigint,
        @order_id int,
        @registered_name nvarchar(50),
        @transfer_no_hk_id_holder_deposit bigint
        AS
        
        INSERT INTO  [MobileOrderMNPDetailRevision]   ([service_activation_time],[ticker_number],[id_type],[transfer_idd_roaming_deposit],[transfer_idd_deposit],[service_activation_date],[mnp_id],[transfer_others_deposit],[registered_name],[hkid],[transfer_to_3g],[order_id],[transfer_no_add_proof_deposit],[company_name],[transfer_no_hk_id_holder_deposit])  VALUES  (@service_activation_time,@ticker_number,@id_type,@transfer_idd_roaming_deposit,@transfer_idd_deposit,@service_activation_date,@mnp_id,@transfer_others_deposit,@registered_name,@hkid,@transfer_to_3g,@order_id,@transfer_no_add_proof_deposit,@company_name,@transfer_no_hk_id_holder_deposit)
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
            string _sQuery = "DELETE FROM  [MobileOrderMNPDetailRevision]  WHERE [MobileOrderMNPDetailRevision].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
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
            return MobileOrderMNPDetailRevisionRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderMNPDetailRevision]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderMNPDetailRevision]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetailRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetailRevision]"); }
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


