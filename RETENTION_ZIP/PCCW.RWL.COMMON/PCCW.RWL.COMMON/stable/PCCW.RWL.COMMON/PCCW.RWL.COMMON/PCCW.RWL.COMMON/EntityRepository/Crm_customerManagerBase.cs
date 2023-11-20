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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[crm_customer],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [crm_customer] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= "crm_customer")]
    public class Crm_customerManagerBase: System.Data.Linq.DataContext{
        
        #region Instance
        private static Crm_customerManagerBase instance;
        public static Crm_customerManagerBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.CRM + (((Configurator.IsUat()) ? "2" : string.Empty)));
                instance = new Crm_customerManagerBase(_oDB);
            }
            return instance;
        }
        public static Crm_customerManagerBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new Crm_customerManagerBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<Crm_customerBase> Crm_customers;
        #endregion
        
        #region Constructor
        public Crm_customerManagerBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~Crm_customerManagerBase() {
            this.Connection.Close();
            this.Connection.Dispose();
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [crm_customer]";
            
            global::System.Data.SqlClient.SqlConnection _oConn=x_oDB.GetConnection();
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
        #endregion
        
        #region Get
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        
        public static Crm_customer[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Crm_customer> _oRow = new global::System.Collections.Generic.List<Crm_customer>();
            string _sQuery = "SELECT [crm_customer].[active] AS CRM_CUSTOMER_ACTIVE,[crm_customer].[cdate] AS CRM_CUSTOMER_CDATE,[crm_customer].[cid] AS CRM_CUSTOMER_CID,[crm_customer].[did] AS CRM_CUSTOMER_DID,[crm_customer].[cust_type] AS CRM_CUSTOMER_CUST_TYPE,[crm_customer].[cust_title] AS CRM_CUSTOMER_CUST_TITLE,[crm_customer].[con_email] AS CRM_CUSTOMER_CON_EMAIL,[crm_customer].[id_type] AS CRM_CUSTOMER_ID_TYPE,[crm_customer].[cust_name] AS CRM_CUSTOMER_CUST_NAME,[crm_customer].[cust_id] AS CRM_CUSTOMER_CUST_ID,[crm_customer].[tel_night] AS CRM_CUSTOMER_TEL_NIGHT,[crm_customer].[ddate] AS CRM_CUSTOMER_DDATE,[crm_customer].[tel_day] AS CRM_CUSTOMER_TEL_DAY,[crm_customer].[fr_cl] AS CRM_CUSTOMER_FR_CL,[crm_customer].[hkid_br] AS CRM_CUSTOMER_HKID_BR  FROM  [crm_customer]";
            if (x_oArrayItemId!=null)
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
                _sQuery += " WHERE [crm_customer].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            _oConn.Open();
            try
            {
                global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                while (_oData.Read())
                {
                    Crm_customer _oCrm_customer = new Crm_customer();
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_ACTIVE"])) {_oCrm_customer.active = (global::System.Nullable<bool>)_oData["CRM_CUSTOMER_ACTIVE"]; }else{_oCrm_customer.active=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CDATE"])) {_oCrm_customer.cdate = (global::System.Nullable<DateTime>)_oData["CRM_CUSTOMER_CDATE"]; }else{_oCrm_customer.cdate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CID"])) {_oCrm_customer.cid = (string)_oData["CRM_CUSTOMER_CID"]; }else{_oCrm_customer.cid=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_DID"])) {_oCrm_customer.did = (string)_oData["CRM_CUSTOMER_DID"]; }else{_oCrm_customer.did=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_TYPE"])) {_oCrm_customer.cust_type = (string)_oData["CRM_CUSTOMER_CUST_TYPE"]; }else{_oCrm_customer.cust_type=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_TITLE"])) {_oCrm_customer.cust_title = (string)_oData["CRM_CUSTOMER_CUST_TITLE"]; }else{_oCrm_customer.cust_title=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_ID_TYPE"])) {_oCrm_customer.id_type = (string)_oData["CRM_CUSTOMER_ID_TYPE"]; }else{_oCrm_customer.id_type=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CON_EMAIL"])) {_oCrm_customer.con_email = (string)_oData["CRM_CUSTOMER_CON_EMAIL"]; }else{_oCrm_customer.con_email=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_ID"])) {_oCrm_customer.cust_id = (global::System.Nullable<int>)_oData["CRM_CUSTOMER_CUST_ID"]; }else{_oCrm_customer.cust_id=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_NAME"])) {_oCrm_customer.cust_name = (string)_oData["CRM_CUSTOMER_CUST_NAME"]; }else{_oCrm_customer.cust_name=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_DDATE"])) {_oCrm_customer.ddate = (global::System.Nullable<DateTime>)_oData["CRM_CUSTOMER_DDATE"]; }else{_oCrm_customer.ddate=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_TEL_NIGHT"])) {_oCrm_customer.tel_night = (string)_oData["CRM_CUSTOMER_TEL_NIGHT"]; }else{_oCrm_customer.tel_night=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_TEL_DAY"])) {_oCrm_customer.tel_day = (string)_oData["CRM_CUSTOMER_TEL_DAY"]; }else{_oCrm_customer.tel_day=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_FR_CL"])) {_oCrm_customer.fr_cl = (string)_oData["CRM_CUSTOMER_FR_CL"]; }else{_oCrm_customer.fr_cl=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_HKID_BR"])) {_oCrm_customer.hkid_br = (string)_oData["CRM_CUSTOMER_HKID_BR"]; }else{_oCrm_customer.hkid_br=string.Empty;}
                    _oCrm_customer.SetDB(x_oDB);
                    _oCrm_customer.GetFound();
                    _oRow.Add(_oCrm_customer);
                }
                _oData.Close();
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        
        public static Crm_customer[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Crm_customer> _oRow = new global::System.Collections.Generic.List<Crm_customer>();
            string _sFields="[crm_customer].[active] AS CRM_CUSTOMER_ACTIVE,[crm_customer].[cdate] AS CRM_CUSTOMER_CDATE,[crm_customer].[cid] AS CRM_CUSTOMER_CID,[crm_customer].[did] AS CRM_CUSTOMER_DID,[crm_customer].[cust_type] AS CRM_CUSTOMER_CUST_TYPE,[crm_customer].[cust_title] AS CRM_CUSTOMER_CUST_TITLE,[crm_customer].[con_email] AS CRM_CUSTOMER_CON_EMAIL,[crm_customer].[id_type] AS CRM_CUSTOMER_ID_TYPE,[crm_customer].[cust_name] AS CRM_CUSTOMER_CUST_NAME,[crm_customer].[cust_id] AS CRM_CUSTOMER_CUST_ID,[crm_customer].[tel_night] AS CRM_CUSTOMER_TEL_NIGHT,[crm_customer].[ddate] AS CRM_CUSTOMER_DDATE,[crm_customer].[tel_day] AS CRM_CUSTOMER_TEL_DAY,[crm_customer].[fr_cl] AS CRM_CUSTOMER_FR_CL,[crm_customer].[hkid_br] AS CRM_CUSTOMER_HKID_BR";
          
            global::System.Data.SqlClient.SqlDataReader _oData = Crm_customerManagerBase.GetSearch(x_oDB, _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                Crm_customer _oCrm_customer = new Crm_customer();
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_ACTIVE"])) {_oCrm_customer.active = (global::System.Nullable<bool>)_oData["CRM_CUSTOMER_ACTIVE"]; } else {_oCrm_customer.active=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CDATE"])) {_oCrm_customer.cdate = (global::System.Nullable<DateTime>)_oData["CRM_CUSTOMER_CDATE"]; } else {_oCrm_customer.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CID"])) {_oCrm_customer.cid = (string)_oData["CRM_CUSTOMER_CID"]; } else {_oCrm_customer.cid=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_DID"])) {_oCrm_customer.did = (string)_oData["CRM_CUSTOMER_DID"]; } else {_oCrm_customer.did=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_TYPE"])) {_oCrm_customer.cust_type = (string)_oData["CRM_CUSTOMER_CUST_TYPE"]; } else {_oCrm_customer.cust_type=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_TITLE"])) {_oCrm_customer.cust_title = (string)_oData["CRM_CUSTOMER_CUST_TITLE"]; } else {_oCrm_customer.cust_title=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_ID_TYPE"])) {_oCrm_customer.id_type = (string)_oData["CRM_CUSTOMER_ID_TYPE"]; } else {_oCrm_customer.id_type=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CON_EMAIL"])) {_oCrm_customer.con_email = (string)_oData["CRM_CUSTOMER_CON_EMAIL"]; } else {_oCrm_customer.con_email=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_ID"])) {_oCrm_customer.cust_id = (global::System.Nullable<int>)_oData["CRM_CUSTOMER_CUST_ID"]; } else {_oCrm_customer.cust_id=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_CUST_NAME"])) {_oCrm_customer.cust_name = (string)_oData["CRM_CUSTOMER_CUST_NAME"]; } else {_oCrm_customer.cust_name=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_DDATE"])) {_oCrm_customer.ddate = (global::System.Nullable<DateTime>)_oData["CRM_CUSTOMER_DDATE"]; } else {_oCrm_customer.ddate=null; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_TEL_NIGHT"])) {_oCrm_customer.tel_night = (string)_oData["CRM_CUSTOMER_TEL_NIGHT"]; } else {_oCrm_customer.tel_night=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_TEL_DAY"])) {_oCrm_customer.tel_day = (string)_oData["CRM_CUSTOMER_TEL_DAY"]; } else {_oCrm_customer.tel_day=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_FR_CL"])) {_oCrm_customer.fr_cl = (string)_oData["CRM_CUSTOMER_FR_CL"]; } else {_oCrm_customer.fr_cl=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CRM_CUSTOMER_HKID_BR"])) {_oCrm_customer.hkid_br = (string)_oData["CRM_CUSTOMER_HKID_BR"]; } else {_oCrm_customer.hkid_br=string.Empty; }
                _oCrm_customer.SetDB(x_oDB);
                _oCrm_customer.GetFound();
                _oRow.Add(_oCrm_customer);
            }
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        #endregion
        
        #region List
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( Crm_customer.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,Crm_customer.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(Crm_customer.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Crm_customer.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT [crm_customer].[active] AS CRM_CUSTOMER_ACTIVE,[crm_customer].[cdate] AS CRM_CUSTOMER_CDATE,[crm_customer].[cid] AS CRM_CUSTOMER_CID,[crm_customer].[did] AS CRM_CUSTOMER_DID,[crm_customer].[cust_type] AS CRM_CUSTOMER_CUST_TYPE,[crm_customer].[cust_title] AS CRM_CUSTOMER_CUST_TITLE,[crm_customer].[con_email] AS CRM_CUSTOMER_CON_EMAIL,[crm_customer].[id_type] AS CRM_CUSTOMER_ID_TYPE,[crm_customer].[cust_name] AS CRM_CUSTOMER_CUST_NAME,[crm_customer].[cust_id] AS CRM_CUSTOMER_CUST_ID,[crm_customer].[tel_night] AS CRM_CUSTOMER_TEL_NIGHT,[crm_customer].[ddate] AS CRM_CUSTOMER_DDATE,[crm_customer].[tel_day] AS CRM_CUSTOMER_TEL_DAY,[crm_customer].[fr_cl] AS CRM_CUSTOMER_FR_CL,[crm_customer].[hkid_br] AS CRM_CUSTOMER_HKID_BR  FROM  [crm_customer]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
           
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
            try
            {
                _oConn.Open();
                _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                _oAdp.SelectCommand.ExecuteNonQuery();
                _oAdp.Fill(_oDset,"crm_customer");
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
        #endregion
        
        #region Insert
        /// <summary>
        /// Summary description for management Insert
        /// </summary>
        
        public bool Insert(global::System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_type,string x_sCust_title,string x_sId_type,string x_sCon_email,string x_sCust_name,System.Nullable<DateTime> x_dDdate,string x_sTel_night,string x_sTel_day,string x_sFr_cl,string x_sHkid_br)
        {
            Crm_customer _oCrm_customer=new Crm_customer();
            _oCrm_customer.active=x_bActive;
            _oCrm_customer.cdate=x_dCdate;
            _oCrm_customer.cid=x_sCid;
            _oCrm_customer.did=x_sDid;
            _oCrm_customer.cust_type=x_sCust_type;
            _oCrm_customer.cust_title=x_sCust_title;
            _oCrm_customer.id_type=x_sId_type;
            _oCrm_customer.con_email=x_sCon_email;
            _oCrm_customer.cust_name=x_sCust_name;
            _oCrm_customer.ddate=x_dDdate;
            _oCrm_customer.tel_night=x_sTel_night;
            _oCrm_customer.tel_day=x_sTel_day;
            _oCrm_customer.fr_cl=x_sFr_cl;
            _oCrm_customer.hkid_br=x_sHkid_br;
            return InsertWithOutLastID(n_oDB, _oCrm_customer);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_type,string x_sCust_title,string x_sId_type,string x_sCon_email,string x_sCust_name,System.Nullable<DateTime> x_dDdate,string x_sTel_night,string x_sTel_day,string x_sFr_cl,string x_sHkid_br)
        {
            Crm_customer _oCrm_customer=new Crm_customer();
            _oCrm_customer.active=x_bActive;
            _oCrm_customer.cdate=x_dCdate;
            _oCrm_customer.cid=x_sCid;
            _oCrm_customer.did=x_sDid;
            _oCrm_customer.cust_type=x_sCust_type;
            _oCrm_customer.cust_title=x_sCust_title;
            _oCrm_customer.id_type=x_sId_type;
            _oCrm_customer.con_email=x_sCon_email;
            _oCrm_customer.cust_name=x_sCust_name;
            _oCrm_customer.ddate=x_dDdate;
            _oCrm_customer.tel_night=x_sTel_night;
            _oCrm_customer.tel_day=x_sTel_day;
            _oCrm_customer.fr_cl=x_sFr_cl;
            _oCrm_customer.hkid_br=x_sHkid_br;
            return InsertWithOutLastID(x_oDB, _oCrm_customer);
        }
        
        
        public bool Insert(Crm_customer x_oCrm_customer)
        {
            return InsertWithOutLastID(n_oDB, x_oCrm_customer);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,Crm_customer x_oCrm_customer)
        {
            return InsertWithOutLastID(x_oDB, x_oCrm_customer);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Crm_customer x_oCrm_customer)
        {
            if (!x_oCrm_customer.Vaild(true)) { return false; }
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [crm_customer]   ([active],[cdate],[cid],[did],[cust_type],[cust_title],[con_email],[id_type],[cust_name],[tel_night],[ddate],[tel_day],[fr_cl],[hkid_br])  VALUES  (@active,@cdate,@cid,@did,@cust_type,@cust_title,@con_email,@id_type,@cust_name,@tel_night,@ddate,@tel_day,@fr_cl,@hkid_br)";
            
            global::System.Data.SqlClient.SqlConnection _oConn =x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            if(x_oCrm_customer.active==null){  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oCrm_customer.active; }
            if(x_oCrm_customer.cdate==null){  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oCrm_customer.cdate; }
            if(string.IsNullOrEmpty(x_oCrm_customer.cid)){  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.VarChar,15).Value=x_oCrm_customer.cid; }
            if(string.IsNullOrEmpty(x_oCrm_customer.did)){  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.VarChar,15).Value=x_oCrm_customer.did; }
            if(string.IsNullOrEmpty(x_oCrm_customer.cust_type)){  _oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.Char,1).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_type", global::System.Data.SqlDbType.Char,1).Value=x_oCrm_customer.cust_type; }
            if(string.IsNullOrEmpty(x_oCrm_customer.cust_title)){  _oCmd.Parameters.Add("@cust_title", global::System.Data.SqlDbType.VarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_title", global::System.Data.SqlDbType.VarChar,4).Value=x_oCrm_customer.cust_title; }
            if(string.IsNullOrEmpty(x_oCrm_customer.con_email)){  _oCmd.Parameters.Add("@con_email", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@con_email", global::System.Data.SqlDbType.VarChar,50).Value=x_oCrm_customer.con_email; }
            if(string.IsNullOrEmpty(x_oCrm_customer.id_type)){  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.VarChar,4).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@id_type", global::System.Data.SqlDbType.VarChar,4).Value=x_oCrm_customer.id_type; }
            if(string.IsNullOrEmpty(x_oCrm_customer.cust_name)){  _oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.VarChar,100).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@cust_name", global::System.Data.SqlDbType.VarChar,100).Value=x_oCrm_customer.cust_name; }
            if(string.IsNullOrEmpty(x_oCrm_customer.tel_night)){  _oCmd.Parameters.Add("@tel_night", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@tel_night", global::System.Data.SqlDbType.VarChar,15).Value=x_oCrm_customer.tel_night; }
            if(x_oCrm_customer.ddate==null){  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  _oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value=x_oCrm_customer.ddate; }
            if(string.IsNullOrEmpty(x_oCrm_customer.tel_day)){  _oCmd.Parameters.Add("@tel_day", global::System.Data.SqlDbType.VarChar,15).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@tel_day", global::System.Data.SqlDbType.VarChar,15).Value=x_oCrm_customer.tel_day; }
            if(string.IsNullOrEmpty(x_oCrm_customer.fr_cl)){  _oCmd.Parameters.Add("@fr_cl", global::System.Data.SqlDbType.VarChar,50).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@fr_cl", global::System.Data.SqlDbType.VarChar,50).Value=x_oCrm_customer.fr_cl; }
            if(string.IsNullOrEmpty(x_oCrm_customer.hkid_br)){  _oCmd.Parameters.Add("@hkid_br", global::System.Data.SqlDbType.VarChar,30).Value = global::System.DBNull.Value; }else{  _oCmd.Parameters.Add("@hkid_br", global::System.Data.SqlDbType.VarChar,30).Value=x_oCrm_customer.hkid_br; }
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
        /// Summary description for management table deleting
        /// </summary>
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return Crm_customerManagerBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [crm_customer]";
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
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
        
        
        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB,x_sFilter);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return false; }
            if (!"".Equals(x_sFilter)){x_sFilter=" WHERE "+x_sFilter;}
            string _sQuery = "DELETE FROM [crm_customer]"+x_sFilter;
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
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
    }
}


