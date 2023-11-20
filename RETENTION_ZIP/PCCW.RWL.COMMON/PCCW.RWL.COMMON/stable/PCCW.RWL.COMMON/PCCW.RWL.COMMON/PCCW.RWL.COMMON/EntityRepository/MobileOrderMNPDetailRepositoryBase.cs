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
///-- Description:	<Description,Table :[MobileOrderMNPDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderMNPDetail] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"MobileOrderMNPDetail")]
    public class MobileOrderMNPDetailRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static MobileOrderMNPDetailRepositoryBase instance;
        public static MobileOrderMNPDetailRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new MobileOrderMNPDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static MobileOrderMNPDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new MobileOrderMNPDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<MobileOrderMNPDetailEntity> MobileOrderMNPDetails;
        #endregion
        
        #region Constructor
        public MobileOrderMNPDetailRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~MobileOrderMNPDetailRepositoryBase() { 
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
        public static MobileOrderMNPDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new MobileOrderMNPDetail(_oDB);
        }
        
        public static MobileOrderMNPDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new MobileOrderMNPDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [MobileOrderMNPDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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
        
        
        public MobileOrderMNPDetailEntity GetObj(global::System.Nullable<long> x_lMnp_id)
        {
            return GetObj(n_oDB, x_lMnp_id);
        }
        
        
        public static MobileOrderMNPDetailEntity GetObj(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id)
        {
            if (x_oDB==null) { return null; }
            MobileOrderMNPDetail _MobileOrderMNPDetail = (MobileOrderMNPDetail)MobileOrderMNPDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_MobileOrderMNPDetail.Load(x_lMnp_id)) { return null; }
            return _MobileOrderMNPDetail;
        }
        
        
        
        public static MobileOrderMNPDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            List<MobileOrderMNPDetailEntity> _oMobileOrderMNPDetailList = GetListObj(x_oDB,0, "mnp_id", x_oArrayItemId);
            if(_oMobileOrderMNPDetailList==null){ return null;}
            return _oMobileOrderMNPDetailList.Count == 0 ? null : _oMobileOrderMNPDetailList.ToArray();
        }
        
        public static List<MobileOrderMNPDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB,0, "mnp_id", x_oArrayItemId);
        }
        
        
        public static MobileOrderMNPDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMNPDetailEntity> _oMobileOrderMNPDetailList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderMNPDetailList==null){ return null;}
            return _oMobileOrderMNPDetailList.Count == 0 ? null : _oMobileOrderMNPDetailList.ToArray();
        }
        
        
        public static MobileOrderMNPDetailEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<MobileOrderMNPDetailEntity> _oMobileOrderMNPDetailList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            if(_oMobileOrderMNPDetailList==null){ return null;}
            return _oMobileOrderMNPDetailList.Count == 0 ? null : _oMobileOrderMNPDetailList.ToArray();
        }
        
        public static List<MobileOrderMNPDetailEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<MobileOrderMNPDetailEntity> _oRow = new List<MobileOrderMNPDetailEntity>();
            string _sQuery = "SELECT  "+_sTop+" [MobileOrderMNPDetail].[service_activation_time] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetail].[ticker_number] AS MOBILEORDERMNPDETAIL_TICKER_NUMBER,[MobileOrderMNPDetail].[id_type] AS MOBILEORDERMNPDETAIL_ID_TYPE,[MobileOrderMNPDetail].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetail].[transfer_idd_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetail].[service_activation_date] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetail].[mnp_id] AS MOBILEORDERMNPDETAIL_MNP_ID,[MobileOrderMNPDetail].[transfer_others_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetail].[registered_name] AS MOBILEORDERMNPDETAIL_REGISTERED_NAME,[MobileOrderMNPDetail].[hkid] AS MOBILEORDERMNPDETAIL_HKID,[MobileOrderMNPDetail].[transfer_to_3g] AS MOBILEORDERMNPDETAIL_TRANSFER_TO_3G,[MobileOrderMNPDetail].[order_id] AS MOBILEORDERMNPDETAIL_ORDER_ID,[MobileOrderMNPDetail].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetail].[company_name] AS MOBILEORDERMNPDETAIL_COMPANY_NAME,[MobileOrderMNPDetail].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT  FROM  [MobileOrderMNPDetail]";
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
                _sQuery += " WHERE [MobileOrderMNPDetail].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        MobileOrderMNPDetail _oMobileOrderMNPDetail = MobileOrderMNPDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"])) {_oMobileOrderMNPDetail.service_activation_time = (string)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"]; }else{_oMobileOrderMNPDetail.service_activation_time=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"])) {_oMobileOrderMNPDetail.ticker_number = (string)_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"]; }else{_oMobileOrderMNPDetail.ticker_number=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ID_TYPE"])) {_oMobileOrderMNPDetail.id_type = (string)_oData["MOBILEORDERMNPDETAIL_ID_TYPE"]; }else{_oMobileOrderMNPDetail.id_type=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_idd_roaming_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"]; }else{_oMobileOrderMNPDetail.transfer_idd_roaming_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"])) {_oMobileOrderMNPDetail.company_name = (string)_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"]; }else{_oMobileOrderMNPDetail.company_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"])) {_oMobileOrderMNPDetail.service_activation_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"]; }else{_oMobileOrderMNPDetail.service_activation_date=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_MNP_ID"])) {_oMobileOrderMNPDetail.mnp_id = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_MNP_ID"]; }else{_oMobileOrderMNPDetail.mnp_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_others_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"]; }else{_oMobileOrderMNPDetail.transfer_others_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_HKID"])) {_oMobileOrderMNPDetail.hkid = (string)_oData["MOBILEORDERMNPDETAIL_HKID"]; }else{_oMobileOrderMNPDetail.hkid=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"])) {_oMobileOrderMNPDetail.transfer_to_3g = (global::System.Nullable<bool>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"]; }else{_oMobileOrderMNPDetail.transfer_to_3g=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_idd_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"]; }else{_oMobileOrderMNPDetail.transfer_idd_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_no_add_proof_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"]; }else{_oMobileOrderMNPDetail.transfer_no_add_proof_deposit=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ORDER_ID"])) {_oMobileOrderMNPDetail.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERMNPDETAIL_ORDER_ID"]; }else{_oMobileOrderMNPDetail.order_id=null;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"])) {_oMobileOrderMNPDetail.registered_name = (string)_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"]; }else{_oMobileOrderMNPDetail.registered_name=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"]; }else{_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit=null;}
                        _oMobileOrderMNPDetail.SetDB(x_oDB);
                        _oMobileOrderMNPDetail.GetFound();
                        _oRow.Add(_oMobileOrderMNPDetail);
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
        
        
        public static MobileOrderMNPDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMNPDetailEntity> _oMobileOrderMNPDetailList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderMNPDetailList==null){ return null;}
            return _oMobileOrderMNPDetailList.Count == 0 ? null : _oMobileOrderMNPDetailList.ToArray();
        }
        
        
        public static MobileOrderMNPDetailEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<MobileOrderMNPDetailEntity> _oMobileOrderMNPDetailList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            if(_oMobileOrderMNPDetailList==null){ return null;}
            return _oMobileOrderMNPDetailList.Count == 0 ? null : _oMobileOrderMNPDetailList.ToArray();
        }
        
        public static List<MobileOrderMNPDetailEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<MobileOrderMNPDetailEntity> _oRow = new List<MobileOrderMNPDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[MobileOrderMNPDetail].[service_activation_time] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetail].[ticker_number] AS MOBILEORDERMNPDETAIL_TICKER_NUMBER,[MobileOrderMNPDetail].[id_type] AS MOBILEORDERMNPDETAIL_ID_TYPE,[MobileOrderMNPDetail].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetail].[transfer_idd_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetail].[service_activation_date] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetail].[mnp_id] AS MOBILEORDERMNPDETAIL_MNP_ID,[MobileOrderMNPDetail].[transfer_others_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetail].[registered_name] AS MOBILEORDERMNPDETAIL_REGISTERED_NAME,[MobileOrderMNPDetail].[hkid] AS MOBILEORDERMNPDETAIL_HKID,[MobileOrderMNPDetail].[transfer_to_3g] AS MOBILEORDERMNPDETAIL_TRANSFER_TO_3G,[MobileOrderMNPDetail].[order_id] AS MOBILEORDERMNPDETAIL_ORDER_ID,[MobileOrderMNPDetail].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetail].[company_name] AS MOBILEORDERMNPDETAIL_COMPANY_NAME,[MobileOrderMNPDetail].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = MobileOrderMNPDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                MobileOrderMNPDetailEntity _oMobileOrderMNPDetail = MobileOrderMNPDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"])) {_oMobileOrderMNPDetail.service_activation_time = (string)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME"]; } else {_oMobileOrderMNPDetail.service_activation_time=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"])) {_oMobileOrderMNPDetail.ticker_number = (string)_oData["MOBILEORDERMNPDETAIL_TICKER_NUMBER"]; } else {_oMobileOrderMNPDetail.ticker_number=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ID_TYPE"])) {_oMobileOrderMNPDetail.id_type = (string)_oData["MOBILEORDERMNPDETAIL_ID_TYPE"]; } else {_oMobileOrderMNPDetail.id_type=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_idd_roaming_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT"]; } else {_oMobileOrderMNPDetail.transfer_idd_roaming_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"])) {_oMobileOrderMNPDetail.company_name = (string)_oData["MOBILEORDERMNPDETAIL_COMPANY_NAME"]; } else {_oMobileOrderMNPDetail.company_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"])) {_oMobileOrderMNPDetail.service_activation_date = (global::System.Nullable<DateTime>)_oData["MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE"]; } else {_oMobileOrderMNPDetail.service_activation_date=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_MNP_ID"])) {_oMobileOrderMNPDetail.mnp_id = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_MNP_ID"]; } else {_oMobileOrderMNPDetail.mnp_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_others_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT"]; } else {_oMobileOrderMNPDetail.transfer_others_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_HKID"])) {_oMobileOrderMNPDetail.hkid = (string)_oData["MOBILEORDERMNPDETAIL_HKID"]; } else {_oMobileOrderMNPDetail.hkid=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"])) {_oMobileOrderMNPDetail.transfer_to_3g = (global::System.Nullable<bool>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_TO_3G"]; } else {_oMobileOrderMNPDetail.transfer_to_3g=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_idd_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT"]; } else {_oMobileOrderMNPDetail.transfer_idd_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_no_add_proof_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT"]; } else {_oMobileOrderMNPDetail.transfer_no_add_proof_deposit=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_ORDER_ID"])) {_oMobileOrderMNPDetail.order_id = (global::System.Nullable<int>)_oData["MOBILEORDERMNPDETAIL_ORDER_ID"]; } else {_oMobileOrderMNPDetail.order_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"])) {_oMobileOrderMNPDetail.registered_name = (string)_oData["MOBILEORDERMNPDETAIL_REGISTERED_NAME"]; } else {_oMobileOrderMNPDetail.registered_name=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"])) {_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit = (global::System.Nullable<long>)_oData["MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT"]; } else {_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit=null; }
                _oMobileOrderMNPDetail.SetDB(x_oDB);
                _oMobileOrderMNPDetail.GetFound();
                _oRow.Add(_oMobileOrderMNPDetail);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( MobileOrderMNPDetail.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,MobileOrderMNPDetail.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(MobileOrderMNPDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(MobileOrderMNPDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [MobileOrderMNPDetail].[service_activation_time] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_TIME,[MobileOrderMNPDetail].[ticker_number] AS MOBILEORDERMNPDETAIL_TICKER_NUMBER,[MobileOrderMNPDetail].[id_type] AS MOBILEORDERMNPDETAIL_ID_TYPE,[MobileOrderMNPDetail].[transfer_idd_roaming_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_ROAMING_DEPOSIT,[MobileOrderMNPDetail].[transfer_idd_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_IDD_DEPOSIT,[MobileOrderMNPDetail].[service_activation_date] AS MOBILEORDERMNPDETAIL_SERVICE_ACTIVATION_DATE,[MobileOrderMNPDetail].[mnp_id] AS MOBILEORDERMNPDETAIL_MNP_ID,[MobileOrderMNPDetail].[transfer_others_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_OTHERS_DEPOSIT,[MobileOrderMNPDetail].[registered_name] AS MOBILEORDERMNPDETAIL_REGISTERED_NAME,[MobileOrderMNPDetail].[hkid] AS MOBILEORDERMNPDETAIL_HKID,[MobileOrderMNPDetail].[transfer_to_3g] AS MOBILEORDERMNPDETAIL_TRANSFER_TO_3G,[MobileOrderMNPDetail].[order_id] AS MOBILEORDERMNPDETAIL_ORDER_ID,[MobileOrderMNPDetail].[transfer_no_add_proof_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_ADD_PROOF_DEPOSIT,[MobileOrderMNPDetail].[company_name] AS MOBILEORDERMNPDETAIL_COMPANY_NAME,[MobileOrderMNPDetail].[transfer_no_hk_id_holder_deposit] AS MOBILEORDERMNPDETAIL_TRANSFER_NO_HK_ID_HOLDER_DEPOSIT  FROM  [MobileOrderMNPDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"MobileOrderMNPDetail");
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
        
        public bool Insert(string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            MobileOrderMNPDetail _oMobileOrderMNPDetail=MobileOrderMNPDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oMobileOrderMNPDetail.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetail.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetail.id_type=x_sId_type;
            _oMobileOrderMNPDetail.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetail.company_name=x_sCompany_name;
            _oMobileOrderMNPDetail.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetail.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetail.hkid=x_sHkid;
            _oMobileOrderMNPDetail.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetail.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetail.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetail.order_id=x_iOrder_id;
            _oMobileOrderMNPDetail.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            return InsertWithOutLastID(n_oDB, _oMobileOrderMNPDetail);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            MobileOrderMNPDetail _oMobileOrderMNPDetail=MobileOrderMNPDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMNPDetail.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetail.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetail.id_type=x_sId_type;
            _oMobileOrderMNPDetail.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetail.company_name=x_sCompany_name;
            _oMobileOrderMNPDetail.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetail.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetail.hkid=x_sHkid;
            _oMobileOrderMNPDetail.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetail.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetail.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetail.order_id=x_iOrder_id;
            _oMobileOrderMNPDetail.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            return InsertWithOutLastID(x_oDB, _oMobileOrderMNPDetail);
        }
        
        
        public bool Insert(MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oMobileOrderMNPDetail);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is MobileOrderMNPDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (MobileOrderMNPDetail)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oMobileOrderMNPDetail);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderMNPDetail]   ([service_activation_time],[ticker_number],[id_type],[transfer_idd_roaming_deposit],[transfer_idd_deposit],[service_activation_date],[transfer_others_deposit],[registered_name],[hkid],[transfer_to_3g],[order_id],[transfer_no_add_proof_deposit],[company_name],[transfer_no_hk_id_holder_deposit])  VALUES  (@service_activation_time,@ticker_number,@id_type,@transfer_idd_roaming_deposit,@transfer_idd_deposit,@service_activation_date,@transfer_others_deposit,@registered_name,@hkid,@transfer_to_3g,@order_id,@transfer_no_add_proof_deposit,@company_name,@transfer_no_hk_id_holder_deposit)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderMNPDetail);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            bool _bResult = false;
            if (!x_oMobileOrderMNPDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderMNPDetail.service_activation_time==null){  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.service_activation_time; }
                if(x_oMobileOrderMNPDetail.ticker_number==null){  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.ticker_number; }
                if(x_oMobileOrderMNPDetail.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderMNPDetail.id_type; }
                if(x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit; }
                if(x_oMobileOrderMNPDetail.transfer_idd_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_idd_deposit; }
                if(x_oMobileOrderMNPDetail.service_activation_date==null){  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMNPDetail.service_activation_date; }
                if(x_oMobileOrderMNPDetail.transfer_others_deposit==null){  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_others_deposit; }
                if(x_oMobileOrderMNPDetail.registered_name==null){  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.registered_name; }
                if(x_oMobileOrderMNPDetail.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.hkid; }
                if(x_oMobileOrderMNPDetail.transfer_to_3g==null){  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMNPDetail.transfer_to_3g; }
                if(x_oMobileOrderMNPDetail.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderMNPDetail.order_id; }
                if(x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit; }
                if(x_oMobileOrderMNPDetail.company_name==null){  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.company_name; }
                if(x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit; }
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
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB,string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            int _oLastID;
            MobileOrderMNPDetail _oMobileOrderMNPDetail=MobileOrderMNPDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMNPDetail.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetail.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetail.id_type=x_sId_type;
            _oMobileOrderMNPDetail.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetail.company_name=x_sCompany_name;
            _oMobileOrderMNPDetail.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetail.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetail.hkid=x_sHkid;
            _oMobileOrderMNPDetail.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetail.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetail.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetail.order_id=x_iOrder_id;
            _oMobileOrderMNPDetail.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            if(InsertWithLastID(x_oDB, _oMobileOrderMNPDetail,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID(MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            int _oLastID;
            if (InsertWithLastID(n_oDB, x_oMobileOrderMNPDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID(MSSQLConnect x_oDB, MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            int _oLastID;
            if (InsertWithLastID(x_oDB, x_oMobileOrderMNPDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderMNPDetail)) return -1;
            int _iLastID;
            if (InsertWithLastID((MSSQLConnect)x_oDB, (MobileOrderMNPDetail)x_oObj, out _iLastID))
            {
                return _iLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID(MSSQLConnect x_oDB,MobileOrderMNPDetail x_oMobileOrderMNPDetail, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [MobileOrderMNPDetail]   ([service_activation_time],[ticker_number],[id_type],[transfer_idd_roaming_deposit],[transfer_idd_deposit],[service_activation_date],[transfer_others_deposit],[registered_name],[hkid],[transfer_to_3g],[order_id],[transfer_no_add_proof_deposit],[company_name],[transfer_no_hk_id_holder_deposit])  VALUES  (@service_activation_time,@ticker_number,@id_type,@transfer_idd_roaming_deposit,@transfer_idd_deposit,@service_activation_date,@transfer_others_deposit,@registered_name,@hkid,@transfer_to_3g,@order_id,@transfer_no_add_proof_deposit,@company_name,@transfer_no_hk_id_holder_deposit)"+" SELECT  @@IDENTITY AS MobileOrderMNPDetail_LASTID;";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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
            return InsertTransactionLastID(x_oDB,_oConn, _oCmd, x_oMobileOrderMNPDetail,out x_iLAST_ID);
        }
        
        public static bool InsertTransactionLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMNPDetail x_oMobileOrderMNPDetail, out int x_iLAST_ID)
        {
            x_iLAST_ID = -1;
            if (!x_oMobileOrderMNPDetail.Vaild(true)) { return false; }
            bool _bResult = false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oMobileOrderMNPDetail.service_activation_time==null){  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.service_activation_time; }
                if(x_oMobileOrderMNPDetail.ticker_number==null){  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.ticker_number; }
                if(x_oMobileOrderMNPDetail.id_type==null){  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10).Value=x_oMobileOrderMNPDetail.id_type; }
                if(x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit; }
                if(x_oMobileOrderMNPDetail.transfer_idd_deposit==null){  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_idd_deposit; }
                if(x_oMobileOrderMNPDetail.service_activation_date==null){  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime).Value=x_oMobileOrderMNPDetail.service_activation_date; }
                if(x_oMobileOrderMNPDetail.transfer_others_deposit==null){  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_others_deposit; }
                if(x_oMobileOrderMNPDetail.registered_name==null){  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.registered_name; }
                if(x_oMobileOrderMNPDetail.hkid==null){  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.hkid; }
                if(x_oMobileOrderMNPDetail.transfer_to_3g==null){  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit).Value=x_oMobileOrderMNPDetail.transfer_to_3g; }
                if(x_oMobileOrderMNPDetail.order_id==null){  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value=x_oMobileOrderMNPDetail.order_id; }
                if(x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit; }
                if(x_oMobileOrderMNPDetail.company_name==null){  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50).Value=x_oMobileOrderMNPDetail.company_name; }
                if(x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit==null){  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt).Value=x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                global::System.Data.SqlClient.SqlDataReader _oData = x_oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    if (Convert.IsDBNull(_oData["MobileOrderMNPDetail_LASTID"])){
                        if(string.IsNullOrEmpty(_oData["MobileOrderMNPDetail_LASTID"].ToString()) && int.TryParse(_oData["MobileOrderMNPDetail_LASTID"].ToString(),out x_iLAST_ID)){
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
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sService_activation_time,string x_sTicker_number,string x_sId_type,global::System.Nullable<long> x_lTransfer_idd_roaming_deposit,string x_sCompany_name,global::System.Nullable<DateTime> x_dService_activation_date,global::System.Nullable<long> x_lTransfer_others_deposit,string x_sHkid,global::System.Nullable<bool> x_bTransfer_to_3g,global::System.Nullable<long> x_lTransfer_idd_deposit,global::System.Nullable<long> x_lTransfer_no_add_proof_deposit,global::System.Nullable<int> x_iOrder_id,string x_sRegistered_name,global::System.Nullable<long> x_lTransfer_no_hk_id_holder_deposit)
        {
            int _oLastID;
            MobileOrderMNPDetail _oMobileOrderMNPDetail=MobileOrderMNPDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oMobileOrderMNPDetail.service_activation_time=x_sService_activation_time;
            _oMobileOrderMNPDetail.ticker_number=x_sTicker_number;
            _oMobileOrderMNPDetail.id_type=x_sId_type;
            _oMobileOrderMNPDetail.transfer_idd_roaming_deposit=x_lTransfer_idd_roaming_deposit;
            _oMobileOrderMNPDetail.company_name=x_sCompany_name;
            _oMobileOrderMNPDetail.service_activation_date=x_dService_activation_date;
            _oMobileOrderMNPDetail.transfer_others_deposit=x_lTransfer_others_deposit;
            _oMobileOrderMNPDetail.hkid=x_sHkid;
            _oMobileOrderMNPDetail.transfer_to_3g=x_bTransfer_to_3g;
            _oMobileOrderMNPDetail.transfer_idd_deposit=x_lTransfer_idd_deposit;
            _oMobileOrderMNPDetail.transfer_no_add_proof_deposit=x_lTransfer_no_add_proof_deposit;
            _oMobileOrderMNPDetail.order_id=x_iOrder_id;
            _oMobileOrderMNPDetail.registered_name=x_sRegistered_name;
            _oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit=x_lTransfer_no_hk_id_holder_deposit;
            if(InsertWithLastID_SP(x_oDB, _oMobileOrderMNPDetail,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oMobileOrderMNPDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderMNPDetail x_oMobileOrderMNPDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oMobileOrderMNPDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is MobileOrderMNPDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (MobileOrderMNPDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,MobileOrderMNPDetail x_oMobileOrderMNPDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "MOBILEORDERMNPDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB,_oConn, _oCmd, x_oMobileOrderMNPDetail,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,MobileOrderMNPDetail x_oMobileOrderMNPDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@service_activation_time", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.service_activation_time==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.service_activation_time; }
                _oPar=x_oCmd.Parameters.Add("@ticker_number", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.ticker_number==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.ticker_number; }
                _oPar=x_oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.id_type==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.id_type; }
                _oPar=x_oCmd.Parameters.Add("@transfer_idd_roaming_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.transfer_idd_roaming_deposit; }
                _oPar=x_oCmd.Parameters.Add("@transfer_idd_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.transfer_idd_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.transfer_idd_deposit; }
                _oPar=x_oCmd.Parameters.Add("@service_activation_date", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.service_activation_date==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oMobileOrderMNPDetail.service_activation_date; }
                _oPar=x_oCmd.Parameters.Add("@transfer_others_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.transfer_others_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.transfer_others_deposit; }
                _oPar=x_oCmd.Parameters.Add("@registered_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.registered_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.registered_name; }
                _oPar=x_oCmd.Parameters.Add("@hkid", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.hkid==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.hkid; }
                _oPar=x_oCmd.Parameters.Add("@transfer_to_3g", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.transfer_to_3g==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.transfer_to_3g; }
                _oPar=x_oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.order_id==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.order_id; }
                _oPar=x_oCmd.Parameters.Add("@transfer_no_add_proof_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.transfer_no_add_proof_deposit; }
                _oPar=x_oCmd.Parameters.Add("@company_name", global::System.Data.SqlDbType.NVarChar,50);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.company_name==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.company_name; }
                _oPar=x_oCmd.Parameters.Add("@transfer_no_hk_id_holder_deposit", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Input;
                if(x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit==null){  _oPar.Value = DBNull.Value; }else{  _oPar.Value=x_oMobileOrderMNPDetail.transfer_no_hk_id_holder_deposit; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_MNP_ID", global::System.Data.SqlDbType.BigInt);
                _oPar.Direction=ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State==ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MNP_ID"].Value.ToString());
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
        
        #region INSERT_MOBILEORDERMNPDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2011-03-08>
        ///-- Description:	<Description,MOBILEORDERMNPDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_MOBILEORDERMNPDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_MOBILEORDERMNPDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_MOBILEORDERMNPDETAIL;
        GO
        CREATE PROCEDURE INSERT_MOBILEORDERMNPDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_MNP_ID bigint output,
        @service_activation_time nvarchar(50),
        @ticker_number nvarchar(50),
        @id_type nvarchar(10),
        @transfer_idd_roaming_deposit bigint,
        @company_name nvarchar(50),
        @service_activation_date datetime,
        @transfer_others_deposit bigint,
        @hkid nvarchar(50),
        @transfer_to_3g bit,
        @transfer_idd_deposit bigint,
        @transfer_no_add_proof_deposit bigint,
        @order_id int,
        @registered_name nvarchar(50),
        @transfer_no_hk_id_holder_deposit bigint
        AS
        
        INSERT INTO  [MobileOrderMNPDetail]   ([service_activation_time],[ticker_number],[id_type],[transfer_idd_roaming_deposit],[transfer_idd_deposit],[service_activation_date],[transfer_others_deposit],[registered_name],[hkid],[transfer_to_3g],[order_id],[transfer_no_add_proof_deposit],[company_name],[transfer_no_hk_id_holder_deposit])  VALUES  (@service_activation_time,@ticker_number,@id_type,@transfer_idd_roaming_deposit,@transfer_idd_deposit,@service_activation_date,@transfer_others_deposit,@registered_name,@hkid,@transfer_to_3g,@order_id,@transfer_no_add_proof_deposit,@company_name,@transfer_no_hk_id_holder_deposit)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_MNP_ID=@@IDENTITY
        RETURN @RETURN_MNP_ID
        END
        ELSE
        BEGIN
        SET @RETURN_MNP_ID=-1
        RETURN @RETURN_MNP_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<long> x_lMnp_id)
        {
            return DeleteProc(n_oDB, x_lMnp_id);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id)
        {
            return DeleteProc(x_oDB, x_lMnp_id);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<long> x_lMnp_id)
        {
            if (x_lMnp_id==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderMNPDetail]  WHERE [MobileOrderMNPDetail].[mnp_id]=@mnp_id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult=false;
                _oCmd.Parameters.Add("@mnp_id", global::System.Data.SqlDbType.BigInt).Value = x_lMnp_id;
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
            return MobileOrderMNPDetailRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [MobileOrderMNPDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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
            string _sQuery = "DELETE FROM [MobileOrderMNPDetail]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderMNPDetail]","["+ Configurator.MSSQLTablePrefix + "MobileOrderMNPDetail]"); }
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


