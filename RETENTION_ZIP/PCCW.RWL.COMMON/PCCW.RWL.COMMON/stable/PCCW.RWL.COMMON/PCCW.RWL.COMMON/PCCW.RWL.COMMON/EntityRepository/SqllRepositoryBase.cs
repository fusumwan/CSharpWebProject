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
///-- Create date: <Create Date 2010-09-17>
///-- Description:	<Description,Table :[sqll],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [sqll] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= Configurator.MSSQLTablePrefix+"sqll")]
    public class SqllRepositoryBase: global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable{
        
        #region Instance
        private static SqllRepositoryBase instance;
        public static SqllRepositoryBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.CSSSQLDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new SqllRepositoryBase(_oDB);
            }
            return instance;
        }
        public static SqllRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new SqllRepositoryBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<SqllEntity> Sqlls;
        #endregion
        
        #region Constructor
        public SqllRepositoryBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~SqllRepositoryBase() { 
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
        public static Sqll CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.CSSSQLDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new Sqll(_oDB);
        }
        
        public static Sqll CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new Sqll(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [sqll]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
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
        
        
        
        
        public static SqllEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SqllEntity> _oSqllList = GetListObj(x_oDB,0, x_oColumnName, x_oArrayItemId);
            return _oSqllList.Count == 0 ? null : _oSqllList.ToArray();
        }
        
        
        public static SqllEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<SqllEntity> _oSqllList = GetListObj(x_oDB,x_iTop, x_oColumnName, x_oArrayItemId);
            return _oSqllList.Count == 0 ? null : _oSqllList.ToArray();
        }
        
        public static List<SqllEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            List<SqllEntity> _oRow = new List<SqllEntity>();
            string _sQuery = "SELECT  "+_sTop+" [sqll].[cdate] AS SQLL_CDATE,[sqll].[txt] AS SQLL_TXT,[sqll].[ip] AS SQLL_IP,[sqll].[idx] AS SQLL_IDX  FROM  [sqll]";
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
                _sQuery += " WHERE [sqll].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        Sqll _oSqll = SqllRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_CDATE"])) {_oSqll.cdate = (global::System.Nullable<DateTime>)_oData["SQLL_CDATE"]; }else{_oSqll.cdate=null;}
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_TXT"])) {_oSqll.txt = (string)_oData["SQLL_TXT"]; }else{_oSqll.txt=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_IP"])) {_oSqll.ip = (string)_oData["SQLL_IP"]; }else{_oSqll.ip=global::System.String.Empty;}
                        if (!global::System.Convert.IsDBNull(_oData["SQLL_IDX"])) {_oSqll.idx = (global::System.Nullable<int>)_oData["SQLL_IDX"]; }else{_oSqll.idx=null;}
                        _oSqll.SetDB(x_oDB);
                        _oSqll.GetFound();
                        _oRow.Add(_oSqll);
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
        
        
        public static SqllEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SqllEntity> _oSqllList = GetListObj(x_oDB,0,  x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSqllList.Count == 0 ? null : _oSqllList.ToArray();
        }
        
        
        public static SqllEntity[] GetArrayObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<SqllEntity> _oSqllList = GetListObj(x_oDB,  x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oSqllList.Count == 0 ? null : _oSqllList.ToArray();
        }
        
        public static List<SqllEntity> GetListObj(MSSQLConnect x_oDB,int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            List<SqllEntity> _oRow = new List<SqllEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString()+" "; }
            string _sFields="[sqll].[cdate] AS SQLL_CDATE,[sqll].[txt] AS SQLL_TXT,[sqll].[ip] AS SQLL_IP,[sqll].[idx] AS SQLL_IDX";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = SqllRepositoryBase.GetSearch(x_oDB, _sTop.ToString()+_sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                SqllEntity _oSqll = SqllRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["SQLL_CDATE"])) {_oSqll.cdate = (global::System.Nullable<DateTime>)_oData["SQLL_CDATE"]; } else {_oSqll.cdate=null; }
                if (!global::System.Convert.IsDBNull(_oData["SQLL_TXT"])) {_oSqll.txt = (string)_oData["SQLL_TXT"]; } else {_oSqll.txt=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SQLL_IP"])) {_oSqll.ip = (string)_oData["SQLL_IP"]; } else {_oSqll.ip=global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["SQLL_IDX"])) {_oSqll.idx = (global::System.Nullable<int>)_oData["SQLL_IDX"]; } else {_oSqll.idx=null; }
                _oSqll.SetDB(x_oDB);
                _oSqll.GetFound();
                _oRow.Add(_oSqll);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( Sqll.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,Sqll.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(Sqll.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Sqll.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT   [sqll].[cdate] AS SQLL_CDATE,[sqll].[txt] AS SQLL_TXT,[sqll].[ip] AS SQLL_IP,[sqll].[idx] AS SQLL_IDX  FROM  [sqll]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset,"sqll");
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
        
        public bool Insert(global::System.Nullable<DateTime> x_dCdate,string x_sTxt,string x_sIp)
        {
            Sqll _oSqll=SqllRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oSqll.cdate=x_dCdate;
            _oSqll.txt=x_sTxt;
            _oSqll.ip=x_sIp;
            return InsertWithOutLastID(n_oDB, _oSqll);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sTxt,string x_sIp)
        {
            Sqll _oSqll=SqllRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oSqll.cdate=x_dCdate;
            _oSqll.txt=x_sTxt;
            _oSqll.ip=x_sIp;
            return InsertWithOutLastID(x_oDB, _oSqll);
        }
        
        
        public bool Insert(Sqll x_oSqll)
        {
            return InsertWithOutLastID(n_oDB, x_oSqll);
        }
        
        
        public bool InsertEntity( object x_oObj,object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is Sqll)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (Sqll)x_oObj);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,Sqll x_oSqll)
        {
            return InsertWithOutLastID(x_oDB, x_oSqll);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Sqll x_oSqll)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [sqll]   ([cdate],[txt],[ip])  VALUES  (@cdate,@txt,@ip)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
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
            return InsertTransactionWithOutLastID(x_oDB,_oConn, _oCmd, x_oSqll);
        }
        
        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB,global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,Sqll x_oSqll)
        {
            bool _bResult = false;
            if (!x_oSqll.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oSqll.cdate==null){  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; }else{  x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value=x_oSqll.cdate; }
                if(x_oSqll.txt==null){  x_oCmd.Parameters.Add("@txt", global::System.Data.SqlDbType.Text).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@txt", global::System.Data.SqlDbType.Text).Value=x_oSqll.txt; }
                if(x_oSqll.ip==null){  x_oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.NVarChar,50).Value = DBNull.Value; }else{  x_oCmd.Parameters.Add("@ip", global::System.Data.SqlDbType.NVarChar,50).Value=x_oSqll.ip; }
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
        
        
        public int InsertEntityReturnLastID(object x_oObj, object x_oDB)
        {
            return -1;
        }
        
        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            return -1;
        }
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return SqllRepositoryBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [sqll]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
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
            string _sQuery = "DELETE FROM [sqll]"+x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[sqll]","["+ Configurator.MSSQLTablePrefix + "sqll]"); }
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


