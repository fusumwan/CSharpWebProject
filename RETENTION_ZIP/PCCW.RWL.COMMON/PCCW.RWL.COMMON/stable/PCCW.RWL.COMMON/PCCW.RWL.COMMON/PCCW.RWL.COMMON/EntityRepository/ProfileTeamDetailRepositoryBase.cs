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
///-- Create date: <Create Date 2009-11-17>
///-- Description:	<Description,Table :[ProfileTeamDetail],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [ProfileTeamDetail] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "ProfileTeamDetail")]
    public class ProfileTeamDetailRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static ProfileTeamDetailRepositoryBase instance;
        public static ProfileTeamDetailRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new ProfileTeamDetailRepositoryBase(_oDB);
            }
            return instance;
        }
        public static ProfileTeamDetailRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new ProfileTeamDetailRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<ProfileTeamDetailEntity> ProfileTeamDetails;
        #endregion

        #region Constructor
        public ProfileTeamDetailRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~ProfileTeamDetailRepositoryBase()
        {
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
        public static ProfileTeamDetail CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new ProfileTeamDetail(_oDB);
        }

        public static ProfileTeamDetail CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new ProfileTeamDetail(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [ProfileTeamDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
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
                catch (Exception exp) { string _sError = exp.ToString(); }
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


        public ProfileTeamDetailEntity GetObj(global::System.Nullable<int> x_iMid)
        {
            return GetObj(n_oDB, x_iMid);
        }


        public static ProfileTeamDetailEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_oDB == null) { return null; }
            ProfileTeamDetail _ProfileTeamDetail = (ProfileTeamDetail)ProfileTeamDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_ProfileTeamDetail.Load(x_iMid)) { return null; }
            return _ProfileTeamDetail;
        }



        public static ProfileTeamDetailEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<ProfileTeamDetailEntity> _oProfileTeamDetailList = GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
            return _oProfileTeamDetailList.Count == 0 ? null : _oProfileTeamDetailList.ToArray();
        }

        public static List<ProfileTeamDetailEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "mid", x_oArrayItemId);
        }


        public static ProfileTeamDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProfileTeamDetailEntity> _oProfileTeamDetailList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oProfileTeamDetailList.Count == 0 ? null : _oProfileTeamDetailList.ToArray();
        }


        public static ProfileTeamDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<ProfileTeamDetailEntity> _oProfileTeamDetailList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oProfileTeamDetailList.Count == 0 ? null : _oProfileTeamDetailList.ToArray();
        }

        public static List<ProfileTeamDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<ProfileTeamDetailEntity> _oRow = new List<ProfileTeamDetailEntity>();
            string _sQuery = "SELECT  " + _sTop + " [ProfileTeamDetail].[active] AS PROFILETEAMDETAIL_ACTIVE,[ProfileTeamDetail].[teamcode] AS PROFILETEAMDETAIL_TEAMCODE,[ProfileTeamDetail].[mid] AS PROFILETEAMDETAIL_MID,[ProfileTeamDetail].[salesmancode] AS PROFILETEAMDETAIL_SALESMANCODE,[ProfileTeamDetail].[staff_no] AS PROFILETEAMDETAIL_STAFF_NO  FROM  [ProfileTeamDetail]";
            if (x_oArrayItemId == null)
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
                _sQuery += " WHERE [ProfileTeamDetail].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        ProfileTeamDetail _oProfileTeamDetail = ProfileTeamDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_MID"])) { _oProfileTeamDetail.mid = (global::System.Nullable<int>)_oData["PROFILETEAMDETAIL_MID"]; } else { _oProfileTeamDetail.mid = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_TEAMCODE"])) { _oProfileTeamDetail.teamcode = (string)_oData["PROFILETEAMDETAIL_TEAMCODE"]; } else { _oProfileTeamDetail.teamcode = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_ACTIVE"])) { _oProfileTeamDetail.active = (global::System.Nullable<bool>)_oData["PROFILETEAMDETAIL_ACTIVE"]; } else { _oProfileTeamDetail.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_SALESMANCODE"])) { _oProfileTeamDetail.salesmancode = (string)_oData["PROFILETEAMDETAIL_SALESMANCODE"]; } else { _oProfileTeamDetail.salesmancode = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_STAFF_NO"])) { _oProfileTeamDetail.staff_no = (string)_oData["PROFILETEAMDETAIL_STAFF_NO"]; } else { _oProfileTeamDetail.staff_no = global::System.String.Empty; }
                        _oProfileTeamDetail.SetDB(x_oDB);
                        _oProfileTeamDetail.GetFound();
                        _oRow.Add(_oProfileTeamDetail);
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
                return _oRow;
            }
        }


        public static ProfileTeamDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProfileTeamDetailEntity> _oProfileTeamDetailList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oProfileTeamDetailList.Count == 0 ? null : _oProfileTeamDetailList.ToArray();
        }


        public static ProfileTeamDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<ProfileTeamDetailEntity> _oProfileTeamDetailList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oProfileTeamDetailList.Count == 0 ? null : _oProfileTeamDetailList.ToArray();
        }

        public static List<ProfileTeamDetailEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<ProfileTeamDetailEntity> _oRow = new List<ProfileTeamDetailEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[ProfileTeamDetail].[active] AS PROFILETEAMDETAIL_ACTIVE,[ProfileTeamDetail].[teamcode] AS PROFILETEAMDETAIL_TEAMCODE,[ProfileTeamDetail].[mid] AS PROFILETEAMDETAIL_MID,[ProfileTeamDetail].[salesmancode] AS PROFILETEAMDETAIL_SALESMANCODE,[ProfileTeamDetail].[staff_no] AS PROFILETEAMDETAIL_STAFF_NO";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = ProfileTeamDetailRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                ProfileTeamDetailEntity _oProfileTeamDetail = ProfileTeamDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_MID"])) { _oProfileTeamDetail.mid = (global::System.Nullable<int>)_oData["PROFILETEAMDETAIL_MID"]; } else { _oProfileTeamDetail.mid = null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_TEAMCODE"])) { _oProfileTeamDetail.teamcode = (string)_oData["PROFILETEAMDETAIL_TEAMCODE"]; } else { _oProfileTeamDetail.teamcode = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_ACTIVE"])) { _oProfileTeamDetail.active = (global::System.Nullable<bool>)_oData["PROFILETEAMDETAIL_ACTIVE"]; } else { _oProfileTeamDetail.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_SALESMANCODE"])) { _oProfileTeamDetail.salesmancode = (string)_oData["PROFILETEAMDETAIL_SALESMANCODE"]; } else { _oProfileTeamDetail.salesmancode = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PROFILETEAMDETAIL_STAFF_NO"])) { _oProfileTeamDetail.staff_no = (string)_oData["PROFILETEAMDETAIL_STAFF_NO"]; } else { _oProfileTeamDetail.staff_no = global::System.String.Empty; }
                _oProfileTeamDetail.SetDB(x_oDB);
                _oProfileTeamDetail.GetFound();
                _oRow.Add(_oProfileTeamDetail);
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
            return GetDataSet(n_oDB, "");
        }


        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(ProfileTeamDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, ProfileTeamDetail.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(ProfileTeamDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(ProfileTeamDetail.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [ProfileTeamDetail].[active] AS PROFILETEAMDETAIL_ACTIVE,[ProfileTeamDetail].[teamcode] AS PROFILETEAMDETAIL_TEAMCODE,[ProfileTeamDetail].[mid] AS PROFILETEAMDETAIL_MID,[ProfileTeamDetail].[salesmancode] AS PROFILETEAMDETAIL_SALESMANCODE,[ProfileTeamDetail].[staff_no] AS PROFILETEAMDETAIL_STAFF_NO  FROM  [ProfileTeamDetail]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "ProfileTeamDetail");
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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

        public bool Insert(string x_sTeamcode, global::System.Nullable<bool> x_bActive, string x_sSalesmancode, string x_sStaff_no)
        {
            ProfileTeamDetail _oProfileTeamDetail = ProfileTeamDetailRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oProfileTeamDetail.teamcode = x_sTeamcode;
            _oProfileTeamDetail.active = x_bActive;
            _oProfileTeamDetail.salesmancode = x_sSalesmancode;
            _oProfileTeamDetail.staff_no = x_sStaff_no;
            return InsertWithOutLastID(n_oDB, _oProfileTeamDetail);
        }


        public static bool Insert(MSSQLConnect x_oDB, string x_sTeamcode, global::System.Nullable<bool> x_bActive, string x_sSalesmancode, string x_sStaff_no)
        {
            ProfileTeamDetail _oProfileTeamDetail = ProfileTeamDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamDetail.teamcode = x_sTeamcode;
            _oProfileTeamDetail.active = x_bActive;
            _oProfileTeamDetail.salesmancode = x_sSalesmancode;
            _oProfileTeamDetail.staff_no = x_sStaff_no;
            return InsertWithOutLastID(x_oDB, _oProfileTeamDetail);
        }


        public bool Insert(ProfileTeamDetail x_oProfileTeamDetail)
        {
            return InsertWithOutLastID(n_oDB, x_oProfileTeamDetail);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is ProfileTeamDetail)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (ProfileTeamDetail)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, ProfileTeamDetail x_oProfileTeamDetail)
        {
            return InsertWithOutLastID(x_oDB, x_oProfileTeamDetail);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, ProfileTeamDetail x_oProfileTeamDetail)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [ProfileTeamDetail]   ([active],[teamcode],[salesmancode],[staff_no])  VALUES  (@active,@teamcode,@salesmancode,@staff_no)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oProfileTeamDetail);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, ProfileTeamDetail x_oProfileTeamDetail)
        {
            bool _bResult = false;
            if (!x_oProfileTeamDetail.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oProfileTeamDetail.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oProfileTeamDetail.active; }
                if (x_oProfileTeamDetail.teamcode == null) { x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.Char, 10).Value = x_oProfileTeamDetail.teamcode; }
                if (x_oProfileTeamDetail.salesmancode == null) { x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.Char, 5).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.Char, 5).Value = x_oProfileTeamDetail.salesmancode; }
                if (x_oProfileTeamDetail.staff_no == null) { x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.Char, 10).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.Char, 10).Value = x_oProfileTeamDetail.staff_no; }
                x_oCmd.CommandType = CommandType.Text;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, string x_sTeamcode, global::System.Nullable<bool> x_bActive, string x_sSalesmancode, string x_sStaff_no)
        {
            int _oLastID;
            ProfileTeamDetail _oProfileTeamDetail = ProfileTeamDetailRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oProfileTeamDetail.teamcode = x_sTeamcode;
            _oProfileTeamDetail.active = x_bActive;
            _oProfileTeamDetail.salesmancode = x_sSalesmancode;
            _oProfileTeamDetail.staff_no = x_sStaff_no;
            if (InsertWithLastID_SP(x_oDB, _oProfileTeamDetail, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(ProfileTeamDetail x_oProfileTeamDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oProfileTeamDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProfileTeamDetail x_oProfileTeamDetail)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oProfileTeamDetail, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is ProfileTeamDetail)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (ProfileTeamDetail)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, ProfileTeamDetail x_oProfileTeamDetail, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "PROFILETEAMDETAIL";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oProfileTeamDetail, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, ProfileTeamDetail x_oProfileTeamDetail, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProfileTeamDetail.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProfileTeamDetail.active; }
                _oPar = x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProfileTeamDetail.teamcode == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProfileTeamDetail.teamcode; }
                _oPar = x_oCmd.Parameters.Add("@salesmancode", global::System.Data.SqlDbType.Char, 5);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProfileTeamDetail.salesmancode == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProfileTeamDetail.salesmancode; }
                _oPar = x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.Char, 10);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oProfileTeamDetail.staff_no == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oProfileTeamDetail.staff_no; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_MID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_MID"].Value.ToString());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
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

        #region INSERT_PROFILETEAMDETAIL Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,PROFILETEAMDETAIL, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_PROFILETEAMDETAIL Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_PROFILETEAMDETAIL', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_PROFILETEAMDETAIL;
        GO
        CREATE PROCEDURE INSERT_PROFILETEAMDETAIL
        	-- Add the parameters for the stored procedure here
        @RETURN_MID int output,
        @teamcode char(10),
        @active bit,
        @salesmancode char(5),
        @staff_no char(10)
        AS
        
        INSERT INTO  [ProfileTeamDetail]   ([active],[teamcode],[salesmancode],[staff_no])  VALUES  (@active,@teamcode,@salesmancode,@staff_no)
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

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            return DeleteProc(x_oDB, x_iMid);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
        {
            if (x_iMid == null) { return false; }
            string _sQuery = "DELETE FROM  [ProfileTeamDetail]  WHERE [ProfileTeamDetail].[mid]=@mid";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@mid", global::System.Data.SqlDbType.Int).Value = x_iMid;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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
            if (n_oDB == null) { return false; }
            return ProfileTeamDetailRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [ProfileTeamDetail]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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
            return DeleteFilter(n_oDB, x_sFilter);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            if (!"".Equals(x_sFilter)) { x_sFilter = " WHERE " + x_sFilter; }
            string _sQuery = "DELETE FROM [ProfileTeamDetail]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]", "[" + Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception exp) { string _sError = exp.ToString(); }
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

