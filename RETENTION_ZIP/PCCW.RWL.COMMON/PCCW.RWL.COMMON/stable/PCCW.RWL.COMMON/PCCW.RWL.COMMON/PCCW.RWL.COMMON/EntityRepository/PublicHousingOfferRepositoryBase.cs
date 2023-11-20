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
///-- Description:	<Description,Table :[PublicHousingOffer],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [PublicHousingOffer] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = Configurator.MSSQLTablePrefix + "PublicHousingOffer")]
    public class PublicHousingOfferRepositoryBase : global::System.Data.Linq.DataContext, global::NEURON.ENTITY.FRAMEWORK.IEntityRepository, global::System.IDisposable
    {

        #region Instance
        private static PublicHousingOfferRepositoryBase instance;
        public static PublicHousingOfferRepositoryBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new PublicHousingOfferRepositoryBase(_oDB);
            }
            return instance;
        }
        public static PublicHousingOfferRepositoryBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new PublicHousingOfferRepositoryBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<PublicHousingOfferEntity> PublicHousingOffers;
        #endregion

        #region Constructor
        public PublicHousingOfferRepositoryBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~PublicHousingOfferRepositoryBase()
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
        public static PublicHousingOffer CreateEntityInstanceObject()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return new PublicHousingOffer(_oDB);
        }

        public static PublicHousingOffer CreateEntityInstanceObject(MSSQLConnect x_oDB)
        {
            return new PublicHousingOffer(x_oDB);
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [PublicHousingOffer]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
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


        public PublicHousingOfferEntity GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static PublicHousingOfferEntity GetObj(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            PublicHousingOffer _PublicHousingOffer = (PublicHousingOffer)PublicHousingOfferRepositoryBase.CreateEntityInstanceObject(x_oDB);
            if (!_PublicHousingOffer.Load(x_iId)) { return null; }
            return _PublicHousingOffer;
        }



        public static PublicHousingOfferEntity[] GetArrayObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            List<PublicHousingOfferEntity> _oPublicHousingOfferList = GetListObj(x_oDB, 0, "id", x_oArrayItemId);
            return _oPublicHousingOfferList.Count == 0 ? null : _oPublicHousingOfferList.ToArray();
        }

        public static List<PublicHousingOfferEntity> GetListObjByID(MSSQLConnect x_oDB, List<string> x_oArrayItemId)
        {
            return GetListObj(x_oDB, 0, "id", x_oArrayItemId);
        }


        public static PublicHousingOfferEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<PublicHousingOfferEntity> _oPublicHousingOfferList = GetListObj(x_oDB, 0, x_oColumnName, x_oArrayItemId);
            return _oPublicHousingOfferList.Count == 0 ? null : _oPublicHousingOfferList.ToArray();
        }


        public static PublicHousingOfferEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            List<PublicHousingOfferEntity> _oPublicHousingOfferList = GetListObj(x_oDB, x_iTop, x_oColumnName, x_oArrayItemId);
            return _oPublicHousingOfferList.Count == 0 ? null : _oPublicHousingOfferList.ToArray();
        }

        public static List<PublicHousingOfferEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_oColumnName, List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            List<PublicHousingOfferEntity> _oRow = new List<PublicHousingOfferEntity>();
            string _sQuery = "SELECT  " + _sTop + " [PublicHousingOffer].[id] AS PUBLICHOUSINGOFFER_ID,[PublicHousingOffer].[cdate] AS PUBLICHOUSINGOFFER_CDATE,[PublicHousingOffer].[cid] AS PUBLICHOUSINGOFFER_CID,[PublicHousingOffer].[did] AS PUBLICHOUSINGOFFER_DID,[PublicHousingOffer].[sdate] AS PUBLICHOUSINGOFFER_SDATE,[PublicHousingOffer].[active] AS PUBLICHOUSINGOFFER_ACTIVE,[PublicHousingOffer].[edate] AS PUBLICHOUSINGOFFER_EDATE,[PublicHousingOffer].[program] AS PUBLICHOUSINGOFFER_PROGRAM,[PublicHousingOffer].[ddate] AS PUBLICHOUSINGOFFER_DDATE,[PublicHousingOffer].[s_premium2] AS PUBLICHOUSINGOFFER_S_PREMIUM2  FROM  [PublicHousingOffer]";
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
                _sQuery += " WHERE [PublicHousingOffer].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }

            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                    while (_oData.Read())
                    {
                        PublicHousingOffer _oPublicHousingOffer = PublicHousingOfferRepositoryBase.CreateEntityInstanceObject(x_oDB);
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ID"])) { _oPublicHousingOffer.id = (global::System.Nullable<int>)_oData["PUBLICHOUSINGOFFER_ID"]; } else { _oPublicHousingOffer.id = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CDATE"])) { _oPublicHousingOffer.cdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_CDATE"]; } else { _oPublicHousingOffer.cdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CID"])) { _oPublicHousingOffer.cid = (string)_oData["PUBLICHOUSINGOFFER_CID"]; } else { _oPublicHousingOffer.cid = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ACTIVE"])) { _oPublicHousingOffer.active = (global::System.Nullable<bool>)_oData["PUBLICHOUSINGOFFER_ACTIVE"]; } else { _oPublicHousingOffer.active = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_SDATE"])) { _oPublicHousingOffer.sdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_SDATE"]; } else { _oPublicHousingOffer.sdate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"])) { _oPublicHousingOffer.s_premium2 = (string)_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"]; } else { _oPublicHousingOffer.s_premium2 = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_EDATE"])) { _oPublicHousingOffer.edate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_EDATE"]; } else { _oPublicHousingOffer.edate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_PROGRAM"])) { _oPublicHousingOffer.program = (string)_oData["PUBLICHOUSINGOFFER_PROGRAM"]; } else { _oPublicHousingOffer.program = global::System.String.Empty; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DDATE"])) { _oPublicHousingOffer.ddate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_DDATE"]; } else { _oPublicHousingOffer.ddate = null; }
                        if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DID"])) { _oPublicHousingOffer.did = (string)_oData["PUBLICHOUSINGOFFER_DID"]; } else { _oPublicHousingOffer.did = global::System.String.Empty; }
                        _oPublicHousingOffer.SetDB(x_oDB);
                        _oPublicHousingOffer.GetFound();
                        _oRow.Add(_oPublicHousingOffer);
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


        public static PublicHousingOfferEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<PublicHousingOfferEntity> _oPublicHousingOfferList = GetListObj(x_oDB, 0, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oPublicHousingOfferList.Count == 0 ? null : _oPublicHousingOfferList.ToArray();
        }


        public static PublicHousingOfferEntity[] GetArrayObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            List<PublicHousingOfferEntity> _oPublicHousingOfferList = GetListObj(x_oDB, x_iTop, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            return _oPublicHousingOfferList.Count == 0 ? null : _oPublicHousingOfferList.ToArray();
        }

        public static List<PublicHousingOfferEntity> GetListObj(MSSQLConnect x_oDB, int x_iTop, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            List<PublicHousingOfferEntity> _oRow = new List<PublicHousingOfferEntity>();
            string _sTop = string.Empty;
            if (x_iTop > 0) { _sTop = " TOP " + x_iTop.ToString() + " "; }
            string _sFields = "[PublicHousingOffer].[id] AS PUBLICHOUSINGOFFER_ID,[PublicHousingOffer].[cdate] AS PUBLICHOUSINGOFFER_CDATE,[PublicHousingOffer].[cid] AS PUBLICHOUSINGOFFER_CID,[PublicHousingOffer].[did] AS PUBLICHOUSINGOFFER_DID,[PublicHousingOffer].[sdate] AS PUBLICHOUSINGOFFER_SDATE,[PublicHousingOffer].[active] AS PUBLICHOUSINGOFFER_ACTIVE,[PublicHousingOffer].[edate] AS PUBLICHOUSINGOFFER_EDATE,[PublicHousingOffer].[program] AS PUBLICHOUSINGOFFER_PROGRAM,[PublicHousingOffer].[ddate] AS PUBLICHOUSINGOFFER_DDATE,[PublicHousingOffer].[s_premium2] AS PUBLICHOUSINGOFFER_S_PREMIUM2";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sFields = _sFields.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
            global::System.Data.SqlClient.SqlDataReader _oData = PublicHousingOfferRepositoryBase.GetSearch(x_oDB, _sTop.ToString() + _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                PublicHousingOfferEntity _oPublicHousingOffer = PublicHousingOfferRepositoryBase.CreateEntityInstanceObject(x_oDB);
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ID"])) { _oPublicHousingOffer.id = (global::System.Nullable<int>)_oData["PUBLICHOUSINGOFFER_ID"]; } else { _oPublicHousingOffer.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CDATE"])) { _oPublicHousingOffer.cdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_CDATE"]; } else { _oPublicHousingOffer.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_CID"])) { _oPublicHousingOffer.cid = (string)_oData["PUBLICHOUSINGOFFER_CID"]; } else { _oPublicHousingOffer.cid = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_ACTIVE"])) { _oPublicHousingOffer.active = (global::System.Nullable<bool>)_oData["PUBLICHOUSINGOFFER_ACTIVE"]; } else { _oPublicHousingOffer.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_SDATE"])) { _oPublicHousingOffer.sdate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_SDATE"]; } else { _oPublicHousingOffer.sdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"])) { _oPublicHousingOffer.s_premium2 = (string)_oData["PUBLICHOUSINGOFFER_S_PREMIUM2"]; } else { _oPublicHousingOffer.s_premium2 = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_EDATE"])) { _oPublicHousingOffer.edate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_EDATE"]; } else { _oPublicHousingOffer.edate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_PROGRAM"])) { _oPublicHousingOffer.program = (string)_oData["PUBLICHOUSINGOFFER_PROGRAM"]; } else { _oPublicHousingOffer.program = global::System.String.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DDATE"])) { _oPublicHousingOffer.ddate = (global::System.Nullable<DateTime>)_oData["PUBLICHOUSINGOFFER_DDATE"]; } else { _oPublicHousingOffer.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["PUBLICHOUSINGOFFER_DID"])) { _oPublicHousingOffer.did = (string)_oData["PUBLICHOUSINGOFFER_DID"]; } else { _oPublicHousingOffer.did = global::System.String.Empty; }
                _oPublicHousingOffer.SetDB(x_oDB);
                _oPublicHousingOffer.GetFound();
                _oRow.Add(_oPublicHousingOffer);
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
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(PublicHousingOffer.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, PublicHousingOffer.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(PublicHousingOffer.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(PublicHousingOffer.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT   [PublicHousingOffer].[id] AS PUBLICHOUSINGOFFER_ID,[PublicHousingOffer].[cdate] AS PUBLICHOUSINGOFFER_CDATE,[PublicHousingOffer].[cid] AS PUBLICHOUSINGOFFER_CID,[PublicHousingOffer].[did] AS PUBLICHOUSINGOFFER_DID,[PublicHousingOffer].[sdate] AS PUBLICHOUSINGOFFER_SDATE,[PublicHousingOffer].[active] AS PUBLICHOUSINGOFFER_ACTIVE,[PublicHousingOffer].[edate] AS PUBLICHOUSINGOFFER_EDATE,[PublicHousingOffer].[program] AS PUBLICHOUSINGOFFER_PROGRAM,[PublicHousingOffer].[ddate] AS PUBLICHOUSINGOFFER_DDATE,[PublicHousingOffer].[s_premium2] AS PUBLICHOUSINGOFFER_S_PREMIUM2  FROM  [PublicHousingOffer]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _oQuery = _oQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
                global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
                try
                {
                    _oConn.Open();
                    _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                    _oAdp.SelectCommand.ExecuteNonQuery();
                    _oAdp.Fill(_oDset, "PublicHousingOffer");
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

        public bool Insert(global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dSdate, string x_sS_premium2, global::System.Nullable<DateTime> x_dEdate, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            PublicHousingOffer _oPublicHousingOffer = PublicHousingOfferRepositoryBase.CreateEntityInstanceObject(n_oDB);
            _oPublicHousingOffer.cdate = x_dCdate;
            _oPublicHousingOffer.cid = x_sCid;
            _oPublicHousingOffer.active = x_bActive;
            _oPublicHousingOffer.sdate = x_dSdate;
            _oPublicHousingOffer.s_premium2 = x_sS_premium2;
            _oPublicHousingOffer.edate = x_dEdate;
            _oPublicHousingOffer.program = x_sProgram;
            _oPublicHousingOffer.ddate = x_dDdate;
            _oPublicHousingOffer.did = x_sDid;
            return InsertWithOutLastID(n_oDB, _oPublicHousingOffer);
        }


        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dSdate, string x_sS_premium2, global::System.Nullable<DateTime> x_dEdate, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            PublicHousingOffer _oPublicHousingOffer = PublicHousingOfferRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oPublicHousingOffer.cdate = x_dCdate;
            _oPublicHousingOffer.cid = x_sCid;
            _oPublicHousingOffer.active = x_bActive;
            _oPublicHousingOffer.sdate = x_dSdate;
            _oPublicHousingOffer.s_premium2 = x_sS_premium2;
            _oPublicHousingOffer.edate = x_dEdate;
            _oPublicHousingOffer.program = x_sProgram;
            _oPublicHousingOffer.ddate = x_dDdate;
            _oPublicHousingOffer.did = x_sDid;
            return InsertWithOutLastID(x_oDB, _oPublicHousingOffer);
        }


        public bool Insert(PublicHousingOffer x_oPublicHousingOffer)
        {
            return InsertWithOutLastID(n_oDB, x_oPublicHousingOffer);
        }


        public bool InsertEntity(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return false;
            if (!(x_oObj is PublicHousingOffer)) return false;
            return InsertWithOutLastID((MSSQLConnect)x_oDB, (PublicHousingOffer)x_oObj);
        }


        public static bool Insert(MSSQLConnect x_oDB, PublicHousingOffer x_oPublicHousingOffer)
        {
            return InsertWithOutLastID(x_oDB, x_oPublicHousingOffer);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, PublicHousingOffer x_oPublicHousingOffer)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [PublicHousingOffer]   ([cdate],[cid],[did],[sdate],[active],[edate],[program],[ddate],[s_premium2])  VALUES  (@cdate,@cid,@did,@sdate,@active,@edate,@program,@ddate,@s_premium2)";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
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
            return InsertTransactionWithOutLastID(x_oDB, _oConn, _oCmd, x_oPublicHousingOffer);
        }

        public static bool InsertTransactionWithOutLastID(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, PublicHousingOffer x_oPublicHousingOffer)
        {
            bool _bResult = false;
            if (!x_oPublicHousingOffer.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oPublicHousingOffer.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oPublicHousingOffer.cdate; }
                if (x_oPublicHousingOffer.cid == null) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oPublicHousingOffer.cid; }
                if (x_oPublicHousingOffer.did == null) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oPublicHousingOffer.did; }
                if (x_oPublicHousingOffer.sdate == null) { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = x_oPublicHousingOffer.sdate; }
                if (x_oPublicHousingOffer.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oPublicHousingOffer.active; }
                if (x_oPublicHousingOffer.edate == null) { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_oPublicHousingOffer.edate; }
                if (x_oPublicHousingOffer.program == null) { x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oPublicHousingOffer.program; }
                if (x_oPublicHousingOffer.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oPublicHousingOffer.ddate; }
                if (x_oPublicHousingOffer.s_premium2 == null) { x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar, 250).Value = DBNull.Value; } else { x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar, 250).Value = x_oPublicHousingOffer.s_premium2; }
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate, string x_sCid, global::System.Nullable<bool> x_bActive, global::System.Nullable<DateTime> x_dSdate, string x_sS_premium2, global::System.Nullable<DateTime> x_dEdate, string x_sProgram, global::System.Nullable<DateTime> x_dDdate, string x_sDid)
        {
            int _oLastID;
            PublicHousingOffer _oPublicHousingOffer = PublicHousingOfferRepositoryBase.CreateEntityInstanceObject(x_oDB);
            _oPublicHousingOffer.cdate = x_dCdate;
            _oPublicHousingOffer.cid = x_sCid;
            _oPublicHousingOffer.active = x_bActive;
            _oPublicHousingOffer.sdate = x_dSdate;
            _oPublicHousingOffer.s_premium2 = x_sS_premium2;
            _oPublicHousingOffer.edate = x_dEdate;
            _oPublicHousingOffer.program = x_sProgram;
            _oPublicHousingOffer.ddate = x_dDdate;
            _oPublicHousingOffer.did = x_sDid;
            if (InsertWithLastID_SP(x_oDB, _oPublicHousingOffer, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(PublicHousingOffer x_oPublicHousingOffer)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oPublicHousingOffer, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, PublicHousingOffer x_oPublicHousingOffer)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oPublicHousingOffer, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB)
        {
            if (!(x_oDB is MSSQLConnect)) return -1;
            if (!(x_oObj is PublicHousingOffer)) return -1;
            int _oLastID;
            if (InsertWithLastID_SP((MSSQLConnect)x_oDB, (PublicHousingOffer)x_oObj, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, PublicHousingOffer x_oPublicHousingOffer, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_" + Configurator.MSSQLTablePrefix.ToUpper() + "PUBLICHOUSINGOFFER";
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
            return InsertTransactionWithLastID_SP(x_oDB, _oConn, _oCmd, x_oPublicHousingOffer, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(MSSQLConnect x_oDB, global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, PublicHousingOffer x_oPublicHousingOffer, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oPublicHousingOffer.cdate; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.cid == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oPublicHousingOffer.cid; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.did == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oPublicHousingOffer.did; }
                _oPar = x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.sdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oPublicHousingOffer.sdate; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.active == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oPublicHousingOffer.active; }
                _oPar = x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.edate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oPublicHousingOffer.edate; }
                _oPar = x_oCmd.Parameters.Add("@program", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.program == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oPublicHousingOffer.program; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oPublicHousingOffer.ddate; }
                _oPar = x_oCmd.Parameters.Add("@s_premium2", global::System.Data.SqlDbType.NVarChar, 250);
                _oPar.Direction = ParameterDirection.Input;
                if (x_oPublicHousingOffer.s_premium2 == null) { _oPar.Value = DBNull.Value; } else { _oPar.Value = x_oPublicHousingOffer.s_premium2; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                if (!x_oDB.bTransaction && x_oConn.State == ConnectionState.Closed) x_oConn.Open();
                _bResult = Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
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

        #region INSERT_PUBLICHOUSINGOFFER Store Procedures
        ///-- =============================================
        ///-- Author:		<Author: Sum Wan,FU>
        ///-- Create date: <Create Date 2009-11-17>
        ///-- Description:	<Description,PUBLICHOUSINGOFFER, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_PUBLICHOUSINGOFFER Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_PUBLICHOUSINGOFFER', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_PUBLICHOUSINGOFFER;
        GO
        CREATE PROCEDURE INSERT_PUBLICHOUSINGOFFER
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @cdate datetime,
        @cid nvarchar(50),
        @active bit,
        @sdate datetime,
        @s_premium2 nvarchar(250),
        @edate datetime,
        @program nvarchar(250),
        @ddate datetime,
        @did nvarchar(50)
        AS
        
        INSERT INTO  [PublicHousingOffer]   ([cdate],[cid],[did],[sdate],[active],[edate],[program],[ddate],[s_premium2])  VALUES  (@cdate,@cid,@did,@sdate,@active,@edate,@program,@ddate,@s_premium2)
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

        public static bool Delete(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, global::System.Nullable<int> x_iId)
        {
            if (x_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [PublicHousingOffer]  WHERE [PublicHousingOffer].[id]=@id";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
            using (global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
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
            return PublicHousingOfferRepositoryBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [PublicHousingOffer]";
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
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
            string _sQuery = "DELETE FROM [PublicHousingOffer]" + x_sFilter;
            if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[PublicHousingOffer]", "[" + Configurator.MSSQLTablePrefix + "PublicHousingOffer]"); }
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

