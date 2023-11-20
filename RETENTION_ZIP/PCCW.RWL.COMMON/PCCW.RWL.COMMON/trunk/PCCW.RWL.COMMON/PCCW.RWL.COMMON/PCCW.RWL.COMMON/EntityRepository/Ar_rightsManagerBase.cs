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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-24>
///-- Description:	<Description,Table :[CSSDB].[dbo].[ar_rights],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[ar_rights] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= "ar_rights")]
    public class Ar_rightsManagerBase: System.Data.Linq.DataContext{
        
        #region Instance
        private static Ar_rightsManagerBase instance;
        public static Ar_rightsManagerBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new Ar_rightsManagerBase(_oDB);
            }
            return instance;
        }
        public static Ar_rightsManagerBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new Ar_rightsManagerBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<Ar_rightsBase> Ar_rightss;
        #endregion
        
        #region Constructor
        public Ar_rightsManagerBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~Ar_rightsManagerBase() { 
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
            }
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [CSSDB].[dbo].[ar_rights]";
            
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
        #endregion
        
        #region Get
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        public Ar_rights GetObj(global::System.Nullable<int> x_iAPPL_ID)
        {
            return GetObj(n_oDB, x_iAPPL_ID);
        }
        
        
        public static Ar_rights GetObj(MSSQLConnect x_oDB,System.Nullable<int> x_iAPPL_ID)
        {
            if (x_oDB==null) { return null; }
            Ar_rights _Ar_rights = new Ar_rights(x_oDB);
            if (!_Ar_rights.Load(x_iAPPL_ID)) { return null; }
            return _Ar_rights;
        }
        
        
        
        public static Ar_rights[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            return GetArrayObj(x_oDB,"APPL_ID",x_oArrayItemId);
        }
        
        
        public static Ar_rights[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Ar_rights> _oRow = new global::System.Collections.Generic.List<Ar_rights>();
            string _sQuery = "SELECT [CSSDB].[dbo].[ar_rights].[CID] AS AR_RIGHTS_CID,[CSSDB].[dbo].[ar_rights].[DID] AS AR_RIGHTS_DID,[CSSDB].[dbo].[ar_rights].[PROG_LV] AS AR_RIGHTS_PROG_LV,[CSSDB].[dbo].[ar_rights].[AR_LST] AS AR_RIGHTS_AR_LST,[CSSDB].[dbo].[ar_rights].[STAFF_NO] AS AR_RIGHTS_STAFF_NO,[CSSDB].[dbo].[ar_rights].[AR_PRT] AS AR_RIGHTS_AR_PRT,[CSSDB].[dbo].[ar_rights].[DDATE] AS AR_RIGHTS_DDATE,[CSSDB].[dbo].[ar_rights].[PROG_NAME] AS AR_RIGHTS_PROG_NAME,[CSSDB].[dbo].[ar_rights].[CDATE] AS AR_RIGHTS_CDATE,[CSSDB].[dbo].[ar_rights].[ACTIVE] AS AR_RIGHTS_ACTIVE,[CSSDB].[dbo].[ar_rights].[AR_ADD] AS AR_RIGHTS_AR_ADD,[CSSDB].[dbo].[ar_rights].[AR_DEL] AS AR_RIGHTS_AR_DEL,[CSSDB].[dbo].[ar_rights].[AR_MOD] AS AR_RIGHTS_AR_MOD,[CSSDB].[dbo].[ar_rights].[APPL_ID] AS AR_RIGHTS_APPL_ID  FROM  [CSSDB].[dbo].[ar_rights]";
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
                _sQuery += " WHERE [CSSDB].[dbo].[ar_rights].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            _oConn.Open();
            try
            {
                global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                while (_oData.Read())
                {
                    Ar_rights _oAr_rights = new Ar_rights();
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_CID"])) {_oAr_rights.CID = (string)_oData["AR_RIGHTS_CID"]; }else{_oAr_rights.CID=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_DID"])) {_oAr_rights.DID = (string)_oData["AR_RIGHTS_DID"]; }else{_oAr_rights.DID=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_PROG_LV"])) {_oAr_rights.PROG_LV = (string)_oData["AR_RIGHTS_PROG_LV"]; }else{_oAr_rights.PROG_LV=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_LST"])) {_oAr_rights.AR_LST = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_LST"]; }else{_oAr_rights.AR_LST=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_STAFF_NO"])) {_oAr_rights.STAFF_NO = (string)_oData["AR_RIGHTS_STAFF_NO"]; }else{_oAr_rights.STAFF_NO=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_PRT"])) {_oAr_rights.AR_PRT = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_PRT"]; }else{_oAr_rights.AR_PRT=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_MOD"])) {_oAr_rights.AR_MOD = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_MOD"]; }else{_oAr_rights.AR_MOD=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_PROG_NAME"])) {_oAr_rights.PROG_NAME = (string)_oData["AR_RIGHTS_PROG_NAME"]; }else{_oAr_rights.PROG_NAME=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_ACTIVE"])) {_oAr_rights.ACTIVE = (global::System.Nullable<int>)_oData["AR_RIGHTS_ACTIVE"]; }else{_oAr_rights.ACTIVE=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_ADD"])) {_oAr_rights.AR_ADD = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_ADD"]; }else{_oAr_rights.AR_ADD=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_DEL"])) {_oAr_rights.AR_DEL = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_DEL"]; }else{_oAr_rights.AR_DEL=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_DDATE"])) {_oAr_rights.DDATE = (global::System.Nullable<DateTime>)_oData["AR_RIGHTS_DDATE"]; }else{_oAr_rights.DDATE=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_CDATE"])) {_oAr_rights.CDATE = (global::System.Nullable<DateTime>)_oData["AR_RIGHTS_CDATE"]; }else{_oAr_rights.CDATE=null;}
                    if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_APPL_ID"])) {_oAr_rights.APPL_ID = (global::System.Nullable<int>)_oData["AR_RIGHTS_APPL_ID"]; }else{_oAr_rights.APPL_ID=null;}
                    _oAr_rights.SetDB(x_oDB);
                    _oAr_rights.GetFound();
                    _oRow.Add(_oAr_rights);
                }
                _oData.Close();
                _oData.Dispose();
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
        
        public static Ar_rights[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Ar_rights> _oRow = new global::System.Collections.Generic.List<Ar_rights>();
            string _sFields="[CSSDB].[dbo].[ar_rights].[CID] AS AR_RIGHTS_CID,[CSSDB].[dbo].[ar_rights].[DID] AS AR_RIGHTS_DID,[CSSDB].[dbo].[ar_rights].[PROG_LV] AS AR_RIGHTS_PROG_LV,[CSSDB].[dbo].[ar_rights].[AR_LST] AS AR_RIGHTS_AR_LST,[CSSDB].[dbo].[ar_rights].[STAFF_NO] AS AR_RIGHTS_STAFF_NO,[CSSDB].[dbo].[ar_rights].[AR_PRT] AS AR_RIGHTS_AR_PRT,[CSSDB].[dbo].[ar_rights].[DDATE] AS AR_RIGHTS_DDATE,[CSSDB].[dbo].[ar_rights].[PROG_NAME] AS AR_RIGHTS_PROG_NAME,[CSSDB].[dbo].[ar_rights].[CDATE] AS AR_RIGHTS_CDATE,[CSSDB].[dbo].[ar_rights].[ACTIVE] AS AR_RIGHTS_ACTIVE,[CSSDB].[dbo].[ar_rights].[AR_ADD] AS AR_RIGHTS_AR_ADD,[CSSDB].[dbo].[ar_rights].[AR_DEL] AS AR_RIGHTS_AR_DEL,[CSSDB].[dbo].[ar_rights].[AR_MOD] AS AR_RIGHTS_AR_MOD,[CSSDB].[dbo].[ar_rights].[APPL_ID] AS AR_RIGHTS_APPL_ID";
            
            global::System.Data.SqlClient.SqlDataReader _oData = Ar_rightsManagerBase.GetSearch(x_oDB, _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                Ar_rights _oAr_rights = new Ar_rights();
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_CID"])) {_oAr_rights.CID = (string)_oData["AR_RIGHTS_CID"]; } else {_oAr_rights.CID=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_DID"])) {_oAr_rights.DID = (string)_oData["AR_RIGHTS_DID"]; } else {_oAr_rights.DID=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_PROG_LV"])) {_oAr_rights.PROG_LV = (string)_oData["AR_RIGHTS_PROG_LV"]; } else {_oAr_rights.PROG_LV=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_LST"])) {_oAr_rights.AR_LST = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_LST"]; } else {_oAr_rights.AR_LST=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_STAFF_NO"])) {_oAr_rights.STAFF_NO = (string)_oData["AR_RIGHTS_STAFF_NO"]; } else {_oAr_rights.STAFF_NO=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_PRT"])) {_oAr_rights.AR_PRT = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_PRT"]; } else {_oAr_rights.AR_PRT=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_MOD"])) {_oAr_rights.AR_MOD = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_MOD"]; } else {_oAr_rights.AR_MOD=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_PROG_NAME"])) {_oAr_rights.PROG_NAME = (string)_oData["AR_RIGHTS_PROG_NAME"]; } else {_oAr_rights.PROG_NAME=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_ACTIVE"])) {_oAr_rights.ACTIVE = (global::System.Nullable<int>)_oData["AR_RIGHTS_ACTIVE"]; } else {_oAr_rights.ACTIVE=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_ADD"])) {_oAr_rights.AR_ADD = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_ADD"]; } else {_oAr_rights.AR_ADD=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_AR_DEL"])) {_oAr_rights.AR_DEL = (global::System.Nullable<bool>)_oData["AR_RIGHTS_AR_DEL"]; } else {_oAr_rights.AR_DEL=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_DDATE"])) {_oAr_rights.DDATE = (global::System.Nullable<DateTime>)_oData["AR_RIGHTS_DDATE"]; } else {_oAr_rights.DDATE=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_CDATE"])) {_oAr_rights.CDATE = (global::System.Nullable<DateTime>)_oData["AR_RIGHTS_CDATE"]; } else {_oAr_rights.CDATE=null; }
                if (!global::System.Convert.IsDBNull(_oData["AR_RIGHTS_APPL_ID"])) {_oAr_rights.APPL_ID = (global::System.Nullable<int>)_oData["AR_RIGHTS_APPL_ID"]; } else {_oAr_rights.APPL_ID=null; }
                _oAr_rights.SetDB(x_oDB);
                _oAr_rights.GetFound();
                _oRow.Add(_oAr_rights);
            }
            _oData.Close();
            _oData.Dispose();
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( Ar_rights.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,Ar_rights.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(Ar_rights.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Ar_rights.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT [CSSDB].[dbo].[ar_rights].[CID] AS AR_RIGHTS_CID,[CSSDB].[dbo].[ar_rights].[DID] AS AR_RIGHTS_DID,[CSSDB].[dbo].[ar_rights].[PROG_LV] AS AR_RIGHTS_PROG_LV,[CSSDB].[dbo].[ar_rights].[AR_LST] AS AR_RIGHTS_AR_LST,[CSSDB].[dbo].[ar_rights].[STAFF_NO] AS AR_RIGHTS_STAFF_NO,[CSSDB].[dbo].[ar_rights].[AR_PRT] AS AR_RIGHTS_AR_PRT,[CSSDB].[dbo].[ar_rights].[DDATE] AS AR_RIGHTS_DDATE,[CSSDB].[dbo].[ar_rights].[PROG_NAME] AS AR_RIGHTS_PROG_NAME,[CSSDB].[dbo].[ar_rights].[CDATE] AS AR_RIGHTS_CDATE,[CSSDB].[dbo].[ar_rights].[ACTIVE] AS AR_RIGHTS_ACTIVE,[CSSDB].[dbo].[ar_rights].[AR_ADD] AS AR_RIGHTS_AR_ADD,[CSSDB].[dbo].[ar_rights].[AR_DEL] AS AR_RIGHTS_AR_DEL,[CSSDB].[dbo].[ar_rights].[AR_MOD] AS AR_RIGHTS_AR_MOD,[CSSDB].[dbo].[ar_rights].[APPL_ID] AS AR_RIGHTS_APPL_ID  FROM  [CSSDB].[dbo].[ar_rights]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
           
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
            try
            {
                _oConn.Open();
                _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                _oAdp.SelectCommand.ExecuteNonQuery();
                _oAdp.Fill(_oDset,"ar_rights");
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
        
        public bool Insert(string x_sCID,string x_sDID,string x_sPROG_LV,System.Nullable<bool> x_bAR_LST,string x_sSTAFF_NO,System.Nullable<bool> x_bAR_PRT,System.Nullable<bool> x_bAR_MOD,string x_sPROG_NAME,System.Nullable<int> x_iACTIVE,System.Nullable<bool> x_bAR_ADD,System.Nullable<bool> x_bAR_DEL,System.Nullable<DateTime> x_dDDATE,System.Nullable<DateTime> x_dCDATE)
        {
            Ar_rights _oAr_rights=new Ar_rights();
            _oAr_rights.CID=x_sCID;
            _oAr_rights.DID=x_sDID;
            _oAr_rights.PROG_LV=x_sPROG_LV;
            _oAr_rights.AR_LST=x_bAR_LST;
            _oAr_rights.STAFF_NO=x_sSTAFF_NO;
            _oAr_rights.AR_PRT=x_bAR_PRT;
            _oAr_rights.AR_MOD=x_bAR_MOD;
            _oAr_rights.PROG_NAME=x_sPROG_NAME;
            _oAr_rights.ACTIVE=x_iACTIVE;
            _oAr_rights.AR_ADD=x_bAR_ADD;
            _oAr_rights.AR_DEL=x_bAR_DEL;
            _oAr_rights.DDATE=x_dDDATE;
            _oAr_rights.CDATE=x_dCDATE;
            return InsertWithOutLastID(n_oDB, _oAr_rights);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sCID,string x_sDID,string x_sPROG_LV,System.Nullable<bool> x_bAR_LST,string x_sSTAFF_NO,System.Nullable<bool> x_bAR_PRT,System.Nullable<bool> x_bAR_MOD,string x_sPROG_NAME,System.Nullable<int> x_iACTIVE,System.Nullable<bool> x_bAR_ADD,System.Nullable<bool> x_bAR_DEL,System.Nullable<DateTime> x_dDDATE,System.Nullable<DateTime> x_dCDATE)
        {
            Ar_rights _oAr_rights=new Ar_rights();
            _oAr_rights.CID=x_sCID;
            _oAr_rights.DID=x_sDID;
            _oAr_rights.PROG_LV=x_sPROG_LV;
            _oAr_rights.AR_LST=x_bAR_LST;
            _oAr_rights.STAFF_NO=x_sSTAFF_NO;
            _oAr_rights.AR_PRT=x_bAR_PRT;
            _oAr_rights.AR_MOD=x_bAR_MOD;
            _oAr_rights.PROG_NAME=x_sPROG_NAME;
            _oAr_rights.ACTIVE=x_iACTIVE;
            _oAr_rights.AR_ADD=x_bAR_ADD;
            _oAr_rights.AR_DEL=x_bAR_DEL;
            _oAr_rights.DDATE=x_dDDATE;
            _oAr_rights.CDATE=x_dCDATE;
            return InsertWithOutLastID(x_oDB, _oAr_rights);
        }
        
        
        public bool Insert(Ar_rights x_oAr_rights)
        {
            return InsertWithOutLastID(n_oDB, x_oAr_rights);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,Ar_rights x_oAr_rights)
        {
            return InsertWithOutLastID(x_oDB, x_oAr_rights);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Ar_rights x_oAr_rights)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [CSSDB].[dbo].[ar_rights]   ([CID],[DID],[PROG_LV],[AR_LST],[STAFF_NO],[AR_PRT],[DDATE],[PROG_NAME],[CDATE],[ACTIVE],[AR_ADD],[AR_DEL],[AR_MOD])  VALUES  (@CID,@DID,@PROG_LV,@AR_LST,@STAFF_NO,@AR_PRT,@DDATE,@PROG_NAME,@CDATE,@ACTIVE,@AR_ADD,@AR_DEL,@AR_MOD)";
            
            global::System.Data.SqlClient.SqlConnection _oConn =x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            return InsertTransactionWithOutLastID(_oConn, _oCmd, x_oAr_rights);
        }
        
        public static bool InsertTransactionWithOutLastID(global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,Ar_rights x_oAr_rights)
        {
            bool _bResult = false;
            if (!x_oAr_rights.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(string.IsNullOrEmpty(x_oAr_rights.CID)){  x_oCmd.Parameters.Add("@CID", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@CID", global::System.Data.SqlDbType.NVarChar,10).Value=x_oAr_rights.CID; }
                if(string.IsNullOrEmpty(x_oAr_rights.DID)){  x_oCmd.Parameters.Add("@DID", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@DID", global::System.Data.SqlDbType.NVarChar,10).Value=x_oAr_rights.DID; }
                if(string.IsNullOrEmpty(x_oAr_rights.PROG_LV)){  x_oCmd.Parameters.Add("@PROG_LV", global::System.Data.SqlDbType.NVarChar,15).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@PROG_LV", global::System.Data.SqlDbType.NVarChar,15).Value=x_oAr_rights.PROG_LV; }
                if(x_oAr_rights.AR_LST==null){  x_oCmd.Parameters.Add("@AR_LST", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@AR_LST", global::System.Data.SqlDbType.Bit).Value=x_oAr_rights.AR_LST; }
                if(string.IsNullOrEmpty(x_oAr_rights.STAFF_NO)){  x_oCmd.Parameters.Add("@STAFF_NO", global::System.Data.SqlDbType.NVarChar,20).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@STAFF_NO", global::System.Data.SqlDbType.NVarChar,20).Value=x_oAr_rights.STAFF_NO; }
                if(x_oAr_rights.AR_PRT==null){  x_oCmd.Parameters.Add("@AR_PRT", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@AR_PRT", global::System.Data.SqlDbType.Bit).Value=x_oAr_rights.AR_PRT; }
                if(x_oAr_rights.DDATE==null){  x_oCmd.Parameters.Add("@DDATE", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@DDATE", global::System.Data.SqlDbType.DateTime).Value=x_oAr_rights.DDATE; }
                if(string.IsNullOrEmpty(x_oAr_rights.PROG_NAME)){  x_oCmd.Parameters.Add("@PROG_NAME", global::System.Data.SqlDbType.NVarChar,15).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@PROG_NAME", global::System.Data.SqlDbType.NVarChar,15).Value=x_oAr_rights.PROG_NAME; }
                if(x_oAr_rights.CDATE==null){  x_oCmd.Parameters.Add("@CDATE", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@CDATE", global::System.Data.SqlDbType.DateTime).Value=x_oAr_rights.CDATE; }
                if(x_oAr_rights.ACTIVE==null){  x_oCmd.Parameters.Add("@ACTIVE", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@ACTIVE", global::System.Data.SqlDbType.Int).Value=x_oAr_rights.ACTIVE; }
                if(x_oAr_rights.AR_ADD==null){  x_oCmd.Parameters.Add("@AR_ADD", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@AR_ADD", global::System.Data.SqlDbType.Bit).Value=x_oAr_rights.AR_ADD; }
                if(x_oAr_rights.AR_DEL==null){  x_oCmd.Parameters.Add("@AR_DEL", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@AR_DEL", global::System.Data.SqlDbType.Bit).Value=x_oAr_rights.AR_DEL; }
                if(x_oAr_rights.AR_MOD==null){  x_oCmd.Parameters.Add("@AR_MOD", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@AR_MOD", global::System.Data.SqlDbType.Bit).Value=x_oAr_rights.AR_MOD; }
                x_oCmd.CommandType = CommandType.Text;
                x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                x_oConn.Close();
                x_oCmd.Dispose();
                x_oConn.Dispose();
            }
            return _bResult;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sCID,string x_sDID,string x_sPROG_LV,System.Nullable<bool> x_bAR_LST,string x_sSTAFF_NO,System.Nullable<bool> x_bAR_PRT,System.Nullable<bool> x_bAR_MOD,string x_sPROG_NAME,System.Nullable<int> x_iACTIVE,System.Nullable<bool> x_bAR_ADD,System.Nullable<bool> x_bAR_DEL,System.Nullable<DateTime> x_dDDATE,System.Nullable<DateTime> x_dCDATE)
        {
            int _oLastID;
            Ar_rights _oAr_rights=new Ar_rights();
            _oAr_rights.CID=x_sCID;
            _oAr_rights.DID=x_sDID;
            _oAr_rights.PROG_LV=x_sPROG_LV;
            _oAr_rights.AR_LST=x_bAR_LST;
            _oAr_rights.STAFF_NO=x_sSTAFF_NO;
            _oAr_rights.AR_PRT=x_bAR_PRT;
            _oAr_rights.AR_MOD=x_bAR_MOD;
            _oAr_rights.PROG_NAME=x_sPROG_NAME;
            _oAr_rights.ACTIVE=x_iACTIVE;
            _oAr_rights.AR_ADD=x_bAR_ADD;
            _oAr_rights.AR_DEL=x_bAR_DEL;
            _oAr_rights.DDATE=x_dDDATE;
            _oAr_rights.CDATE=x_dCDATE;
            if(InsertWithLastID_SP(x_oDB, _oAr_rights,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(Ar_rights x_oAr_rights)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oAr_rights, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Ar_rights x_oAr_rights)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oAr_rights, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,Ar_rights x_oAr_rights, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_AR_RIGHTS";
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            return InsertTransactionWithLastID_SP(_oConn, _oCmd, x_oAr_rights,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,Ar_rights x_oAr_rights, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            global::System.Data.SqlClient.SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@CID", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(string.IsNullOrEmpty(x_oAr_rights.CID)){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.CID; }
                _oPar=x_oCmd.Parameters.Add("@DID", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(string.IsNullOrEmpty(x_oAr_rights.DID)){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.DID; }
                _oPar=x_oCmd.Parameters.Add("@PROG_LV", global::System.Data.SqlDbType.NVarChar,15);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(string.IsNullOrEmpty(x_oAr_rights.PROG_LV)){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.PROG_LV; }
                _oPar=x_oCmd.Parameters.Add("@AR_LST", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.AR_LST==null){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.AR_LST; }
                _oPar=x_oCmd.Parameters.Add("@STAFF_NO", global::System.Data.SqlDbType.NVarChar,20);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(string.IsNullOrEmpty(x_oAr_rights.STAFF_NO)){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.STAFF_NO; }
                _oPar=x_oCmd.Parameters.Add("@AR_PRT", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.AR_PRT==null){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.AR_PRT; }
                _oPar=x_oCmd.Parameters.Add("@DDATE", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.DDATE==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oAr_rights.DDATE; }
                _oPar=x_oCmd.Parameters.Add("@PROG_NAME", global::System.Data.SqlDbType.NVarChar,15);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(string.IsNullOrEmpty(x_oAr_rights.PROG_NAME)){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.PROG_NAME; }
                _oPar=x_oCmd.Parameters.Add("@CDATE", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.CDATE==null){  _oPar.Value = SqlDateTime.Null; }else{  _oPar.Value=x_oAr_rights.CDATE; }
                _oPar=x_oCmd.Parameters.Add("@ACTIVE", global::System.Data.SqlDbType.Int);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.ACTIVE==null){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.ACTIVE; }
                _oPar=x_oCmd.Parameters.Add("@AR_ADD", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.AR_ADD==null){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.AR_ADD; }
                _oPar=x_oCmd.Parameters.Add("@AR_DEL", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.AR_DEL==null){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.AR_DEL; }
                _oPar=x_oCmd.Parameters.Add("@AR_MOD", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oAr_rights.AR_MOD==null){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oAr_rights.AR_MOD; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_APPL_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=global::System.Data.ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_APPL_ID"].Value.ToString());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                x_oConn.Close();
                x_oCmd.Dispose();
                x_oConn.Dispose();
            }
            return _bResult;
        }
        
        
        #region INSERT_AR_RIGHTS Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-03-24>
        ///-- Description:	<Description,AR_RIGHTS, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_AR_RIGHTS Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_AR_RIGHTS', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_AR_RIGHTS;
        GO
        CREATE PROCEDURE INSERT_AR_RIGHTS
        	-- Add the parameters for the stored procedure here
        @RETURN_APPL_ID int output,
        @CID nvarchar(10),
        @DID nvarchar(10),
        @PROG_LV nvarchar(15),
        @AR_LST bit,
        @STAFF_NO nvarchar(20),
        @AR_PRT bit,
        @AR_MOD bit,
        @PROG_NAME nvarchar(15),
        @ACTIVE int,
        @AR_ADD bit,
        @AR_DEL bit,
        @DDATE datetime,
        @CDATE datetime
        AS
        
        INSERT INTO  [CSSDB].[dbo].[ar_rights]   ([CID],[DID],[PROG_LV],[AR_LST],[STAFF_NO],[AR_PRT],[DDATE],[PROG_NAME],[CDATE],[ACTIVE],[AR_ADD],[AR_DEL],[AR_MOD])  VALUES  (@CID,@DID,@PROG_LV,@AR_LST,@STAFF_NO,@AR_PRT,@DDATE,@PROG_NAME,@CDATE,@ACTIVE,@AR_ADD,@AR_DEL,@AR_MOD)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_APPL_ID=@@IDENTITY
        RETURN @RETURN_APPL_ID
        END
        ELSE
        BEGIN
        SET @RETURN_APPL_ID=-1
        RETURN @RETURN_APPL_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iAPPL_ID)
        {
            return DeleteProc(n_oDB, x_iAPPL_ID);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iAPPL_ID)
        {
            return DeleteProc(x_oDB, x_iAPPL_ID);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, System.Nullable<int> x_iAPPL_ID)
        {
            if (x_iAPPL_ID==null) { return false; }
            string _sQuery = "DELETE FROM  [CSSDB].[dbo].[ar_rights]  WHERE [CSSDB].[dbo].[ar_rights].[APPL_ID]=@APPL_ID";
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            _oCmd.Parameters.Add("@APPL_ID", global::System.Data.SqlDbType.Int).Value = x_iAPPL_ID;
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
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return Ar_rightsManagerBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [CSSDB].[dbo].[ar_rights]";
            
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
            string _sQuery = "DELETE FROM [CSSDB].[dbo].[ar_rights]"+x_sFilter;
            
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


