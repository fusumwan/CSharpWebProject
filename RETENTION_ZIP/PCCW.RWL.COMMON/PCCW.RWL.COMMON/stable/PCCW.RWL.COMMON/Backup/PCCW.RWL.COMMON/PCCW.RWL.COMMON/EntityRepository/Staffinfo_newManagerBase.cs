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
///-- Description:	<Description,Table :[CSSDB].[csc].[staffinfo_new],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE
{


    /// <summary>
    /// Summary description for table [CSSDB].[csc].[staffinfo_new] Insert / list / delete manager layer
    /// </summary>

    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "staffinfo_new")]
    public class Staffinfo_newManagerBase : System.Data.Linq.DataContext
    {

        #region Instance
        private static Staffinfo_newManagerBase instance;
        public static Staffinfo_newManagerBase Instance()
        {
            if (instance == null)
            {
                MSSQLConnect _oDB = new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new Staffinfo_newManagerBase(_oDB);
            }
            return instance;
        }
        public static Staffinfo_newManagerBase Instance(MSSQLConnect x_oDB)
        {
            if (instance == null)
                instance = new Staffinfo_newManagerBase(x_oDB);
            return instance;
        }
        #endregion

        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<Staffinfo_newBase> Staffinfo_news;
        #endregion

        #region Constructor
        public Staffinfo_newManagerBase(MSSQLConnect x_oDB)
            : base(x_oDB.ConnectionStr)
        {
            n_oDB = x_oDB;
        }
        ~Staffinfo_newManagerBase()
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
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [CSSDB].[csc].[staffinfo_new]";

            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
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
        #endregion

        #region Get

        /// <summary>
        /// Summary description for management get record from table
        /// </summary>


        public Staffinfo_new GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }


        public static Staffinfo_new GetObj(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            if (x_oDB == null) { return null; }
            Staffinfo_new _Staffinfo_new = new Staffinfo_new(x_oDB);
            if (!_Staffinfo_new.Load(x_iId)) { return null; }
            return _Staffinfo_new;
        }


        public Staffinfo_new GetObj(string x_sStaff_no2, string x_sStaff_no)
        {
            return GetObj(n_oDB, x_sStaff_no2, x_sStaff_no);
        }


        public static Staffinfo_new GetObj(MSSQLConnect x_oDB, string x_sStaff_no2, string x_sStaff_no)
        {
            if (x_oDB == null) { return null; }
            Staffinfo_new _Staffinfo_new = new Staffinfo_new(x_oDB);
            if (!_Staffinfo_new.Load(x_sStaff_no2, x_sStaff_no)) { return null; }
            return _Staffinfo_new;
        }



        public static Staffinfo_new[] GetArrayObjByID(MSSQLConnect x_oDB, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            return GetArrayObj(x_oDB, "id", x_oArrayItemId);
        }


        public static Staffinfo_new[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            if (x_oDB == null) { return null; }
            global::System.Collections.Generic.List<Staffinfo_new> _oRow = new global::System.Collections.Generic.List<Staffinfo_new>();
            string _sQuery = "SELECT [CSSDB].[csc].[staffinfo_new].[basic] AS STAFFINFO_NEW_BASIC,[CSSDB].[csc].[staffinfo_new].[cid] AS STAFFINFO_NEW_CID,[CSSDB].[csc].[staffinfo_new].[steptype] AS STAFFINFO_NEW_STEPTYPE,[CSSDB].[csc].[staffinfo_new].[cdate] AS STAFFINFO_NEW_CDATE,[CSSDB].[csc].[staffinfo_new].[freeze] AS STAFFINFO_NEW_FREEZE,[CSSDB].[csc].[staffinfo_new].[lwdate] AS STAFFINFO_NEW_LWDATE,[CSSDB].[csc].[staffinfo_new].[cmrid] AS STAFFINFO_NEW_CMRID,[CSSDB].[csc].[staffinfo_new].[did] AS STAFFINFO_NEW_DID,[CSSDB].[csc].[staffinfo_new].[contract_s] AS STAFFINFO_NEW_CONTRACT_S,[CSSDB].[csc].[staffinfo_new].[sdate] AS STAFFINFO_NEW_SDATE,[CSSDB].[csc].[staffinfo_new].[active] AS STAFFINFO_NEW_ACTIVE,[CSSDB].[csc].[staffinfo_new].[salesman_code] AS STAFFINFO_NEW_SALESMAN_CODE,[CSSDB].[csc].[staffinfo_new].[ddate] AS STAFFINFO_NEW_DDATE,[CSSDB].[csc].[staffinfo_new].[stream] AS STAFFINFO_NEW_STREAM,[CSSDB].[csc].[staffinfo_new].[joindate] AS STAFFINFO_NEW_JOINDATE,[CSSDB].[csc].[staffinfo_new].[shift] AS STAFFINFO_NEW_SHIFT,[CSSDB].[csc].[staffinfo_new].[staff_no] AS STAFFINFO_NEW_STAFF_NO,[CSSDB].[csc].[staffinfo_new].[internship] AS STAFFINFO_NEW_INTERNSHIP,[CSSDB].[csc].[staffinfo_new].[centre] AS STAFFINFO_NEW_CENTRE,[CSSDB].[csc].[staffinfo_new].[pay_code] AS STAFFINFO_NEW_PAY_CODE,[CSSDB].[csc].[staffinfo_new].[staff_no2] AS STAFFINFO_NEW_STAFF_NO2,[CSSDB].[csc].[staffinfo_new].[id] AS STAFFINFO_NEW_ID,[CSSDB].[csc].[staffinfo_new].[teamcode] AS STAFFINFO_NEW_TEAMCODE,[CSSDB].[csc].[staffinfo_new].[Language] AS STAFFINFO_NEW_LANGUAGE,[CSSDB].[csc].[staffinfo_new].[staff_type] AS STAFFINFO_NEW_STAFF_TYPE,[CSSDB].[csc].[staffinfo_new].[staff_name] AS STAFFINFO_NEW_STAFF_NAME,[CSSDB].[csc].[staffinfo_new].[otc] AS STAFFINFO_NEW_OTC,[CSSDB].[csc].[staffinfo_new].[edate] AS STAFFINFO_NEW_EDATE,[CSSDB].[csc].[staffinfo_new].[contract_e] AS STAFFINFO_NEW_CONTRACT_E,[CSSDB].[csc].[staffinfo_new].[skill] AS STAFFINFO_NEW_SKILL,[CSSDB].[csc].[staffinfo_new].[steplevel] AS STAFFINFO_NEW_STEPLEVEL,[CSSDB].[csc].[staffinfo_new].[ccc] AS STAFFINFO_NEW_CCC  FROM  [CSSDB].[csc].[staffinfo_new]";
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
                _sQuery += " WHERE [CSSDB].[csc].[staffinfo_new].[" + x_oColumnName.ToString() + "]  in " + _oList;
            }


            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            _oConn.Open();
            try
            {
                global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                while (_oData.Read())
                {
                    Staffinfo_new _oStaffinfo_new = new Staffinfo_new();
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_BASIC"])) { _oStaffinfo_new.basic = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_BASIC"]; } else { _oStaffinfo_new.basic = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_EDATE"])) { _oStaffinfo_new.edate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_EDATE"]; } else { _oStaffinfo_new.edate = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPTYPE"])) { _oStaffinfo_new.steptype = (string)_oData["STAFFINFO_NEW_STEPTYPE"]; } else { _oStaffinfo_new.steptype = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CDATE"])) { _oStaffinfo_new.cdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CDATE"]; } else { _oStaffinfo_new.cdate = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CMRID"])) { _oStaffinfo_new.cmrid = (string)_oData["STAFFINFO_NEW_CMRID"]; } else { _oStaffinfo_new.cmrid = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DID"])) { _oStaffinfo_new.did = (string)_oData["STAFFINFO_NEW_DID"]; } else { _oStaffinfo_new.did = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_S"])) { _oStaffinfo_new.contract_s = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_S"]; } else { _oStaffinfo_new.contract_s = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SDATE"])) { _oStaffinfo_new.sdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_SDATE"]; } else { _oStaffinfo_new.sdate = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ACTIVE"])) { _oStaffinfo_new.active = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_ACTIVE"]; } else { _oStaffinfo_new.active = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SALESMAN_CODE"])) { _oStaffinfo_new.salesman_code = (string)_oData["STAFFINFO_NEW_SALESMAN_CODE"]; } else { _oStaffinfo_new.salesman_code = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STREAM"])) { _oStaffinfo_new.stream = (string)_oData["STAFFINFO_NEW_STREAM"]; } else { _oStaffinfo_new.stream = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_JOINDATE"])) { _oStaffinfo_new.joindate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_JOINDATE"]; } else { _oStaffinfo_new.joindate = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SHIFT"])) { _oStaffinfo_new.shift = (string)_oData["STAFFINFO_NEW_SHIFT"]; } else { _oStaffinfo_new.shift = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NO"])) { _oStaffinfo_new.staff_no = (string)_oData["STAFFINFO_NEW_STAFF_NO"]; } else { _oStaffinfo_new.staff_no = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_INTERNSHIP"])) { _oStaffinfo_new.internship = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_INTERNSHIP"]; } else { _oStaffinfo_new.internship = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LWDATE"])) { _oStaffinfo_new.lwdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_LWDATE"]; } else { _oStaffinfo_new.lwdate = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DDATE"])) { _oStaffinfo_new.ddate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_DDATE"]; } else { _oStaffinfo_new.ddate = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NO2"])) { _oStaffinfo_new.staff_no2 = (string)_oData["STAFFINFO_NEW_STAFF_NO2"]; } else { _oStaffinfo_new.staff_no2 = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ID"])) { _oStaffinfo_new.id = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_ID"]; } else { _oStaffinfo_new.id = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_TEAMCODE"])) { _oStaffinfo_new.teamcode = (string)_oData["STAFFINFO_NEW_TEAMCODE"]; } else { _oStaffinfo_new.teamcode = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CENTRE"])) { _oStaffinfo_new.centre = (string)_oData["STAFFINFO_NEW_CENTRE"]; } else { _oStaffinfo_new.centre = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LANGUAGE"])) { _oStaffinfo_new.Language = (string)_oData["STAFFINFO_NEW_LANGUAGE"]; } else { _oStaffinfo_new.Language = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CID"])) { _oStaffinfo_new.cid = (string)_oData["STAFFINFO_NEW_CID"]; } else { _oStaffinfo_new.cid = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NAME"])) { _oStaffinfo_new.staff_name = (string)_oData["STAFFINFO_NEW_STAFF_NAME"]; } else { _oStaffinfo_new.staff_name = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_OTC"])) { _oStaffinfo_new.otc = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_OTC"]; } else { _oStaffinfo_new.otc = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SKILL"])) { _oStaffinfo_new.skill = (string)_oData["STAFFINFO_NEW_SKILL"]; } else { _oStaffinfo_new.skill = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_FREEZE"])) { _oStaffinfo_new.freeze = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_FREEZE"]; } else { _oStaffinfo_new.freeze = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_E"])) { _oStaffinfo_new.contract_e = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_E"]; } else { _oStaffinfo_new.contract_e = null; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_TYPE"])) { _oStaffinfo_new.staff_type = (string)_oData["STAFFINFO_NEW_STAFF_TYPE"]; } else { _oStaffinfo_new.staff_type = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPLEVEL"])) { _oStaffinfo_new.steplevel = (string)_oData["STAFFINFO_NEW_STEPLEVEL"]; } else { _oStaffinfo_new.steplevel = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CCC"])) { _oStaffinfo_new.ccc = (string)_oData["STAFFINFO_NEW_CCC"]; } else { _oStaffinfo_new.ccc = string.Empty; }
                    if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_PAY_CODE"])) { _oStaffinfo_new.pay_code = (string)_oData["STAFFINFO_NEW_PAY_CODE"]; } else { _oStaffinfo_new.pay_code = string.Empty; }
                    _oStaffinfo_new.SetDB(x_oDB);
                    _oStaffinfo_new.GetFound();
                    _oRow.Add(_oStaffinfo_new);
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

        public static Staffinfo_new[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB == null) { return null; }
            global::System.Collections.Generic.List<Staffinfo_new> _oRow = new global::System.Collections.Generic.List<Staffinfo_new>();
            string _sFields = "[CSSDB].[csc].[staffinfo_new].[basic] AS STAFFINFO_NEW_BASIC,[CSSDB].[csc].[staffinfo_new].[cid] AS STAFFINFO_NEW_CID,[CSSDB].[csc].[staffinfo_new].[steptype] AS STAFFINFO_NEW_STEPTYPE,[CSSDB].[csc].[staffinfo_new].[cdate] AS STAFFINFO_NEW_CDATE,[CSSDB].[csc].[staffinfo_new].[freeze] AS STAFFINFO_NEW_FREEZE,[CSSDB].[csc].[staffinfo_new].[lwdate] AS STAFFINFO_NEW_LWDATE,[CSSDB].[csc].[staffinfo_new].[cmrid] AS STAFFINFO_NEW_CMRID,[CSSDB].[csc].[staffinfo_new].[did] AS STAFFINFO_NEW_DID,[CSSDB].[csc].[staffinfo_new].[contract_s] AS STAFFINFO_NEW_CONTRACT_S,[CSSDB].[csc].[staffinfo_new].[sdate] AS STAFFINFO_NEW_SDATE,[CSSDB].[csc].[staffinfo_new].[active] AS STAFFINFO_NEW_ACTIVE,[CSSDB].[csc].[staffinfo_new].[salesman_code] AS STAFFINFO_NEW_SALESMAN_CODE,[CSSDB].[csc].[staffinfo_new].[ddate] AS STAFFINFO_NEW_DDATE,[CSSDB].[csc].[staffinfo_new].[stream] AS STAFFINFO_NEW_STREAM,[CSSDB].[csc].[staffinfo_new].[joindate] AS STAFFINFO_NEW_JOINDATE,[CSSDB].[csc].[staffinfo_new].[shift] AS STAFFINFO_NEW_SHIFT,[CSSDB].[csc].[staffinfo_new].[staff_no] AS STAFFINFO_NEW_STAFF_NO,[CSSDB].[csc].[staffinfo_new].[internship] AS STAFFINFO_NEW_INTERNSHIP,[CSSDB].[csc].[staffinfo_new].[centre] AS STAFFINFO_NEW_CENTRE,[CSSDB].[csc].[staffinfo_new].[pay_code] AS STAFFINFO_NEW_PAY_CODE,[CSSDB].[csc].[staffinfo_new].[staff_no2] AS STAFFINFO_NEW_STAFF_NO2,[CSSDB].[csc].[staffinfo_new].[id] AS STAFFINFO_NEW_ID,[CSSDB].[csc].[staffinfo_new].[teamcode] AS STAFFINFO_NEW_TEAMCODE,[CSSDB].[csc].[staffinfo_new].[Language] AS STAFFINFO_NEW_LANGUAGE,[CSSDB].[csc].[staffinfo_new].[staff_type] AS STAFFINFO_NEW_STAFF_TYPE,[CSSDB].[csc].[staffinfo_new].[staff_name] AS STAFFINFO_NEW_STAFF_NAME,[CSSDB].[csc].[staffinfo_new].[otc] AS STAFFINFO_NEW_OTC,[CSSDB].[csc].[staffinfo_new].[edate] AS STAFFINFO_NEW_EDATE,[CSSDB].[csc].[staffinfo_new].[contract_e] AS STAFFINFO_NEW_CONTRACT_E,[CSSDB].[csc].[staffinfo_new].[skill] AS STAFFINFO_NEW_SKILL,[CSSDB].[csc].[staffinfo_new].[steplevel] AS STAFFINFO_NEW_STEPLEVEL,[CSSDB].[csc].[staffinfo_new].[ccc] AS STAFFINFO_NEW_CCC";

            global::System.Data.SqlClient.SqlDataReader _oData = Staffinfo_newManagerBase.GetSearch(x_oDB, _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                Staffinfo_new _oStaffinfo_new = new Staffinfo_new();
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_BASIC"])) { _oStaffinfo_new.basic = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_BASIC"]; } else { _oStaffinfo_new.basic = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_EDATE"])) { _oStaffinfo_new.edate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_EDATE"]; } else { _oStaffinfo_new.edate = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPTYPE"])) { _oStaffinfo_new.steptype = (string)_oData["STAFFINFO_NEW_STEPTYPE"]; } else { _oStaffinfo_new.steptype = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CDATE"])) { _oStaffinfo_new.cdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CDATE"]; } else { _oStaffinfo_new.cdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CMRID"])) { _oStaffinfo_new.cmrid = (string)_oData["STAFFINFO_NEW_CMRID"]; } else { _oStaffinfo_new.cmrid = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DID"])) { _oStaffinfo_new.did = (string)_oData["STAFFINFO_NEW_DID"]; } else { _oStaffinfo_new.did = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_S"])) { _oStaffinfo_new.contract_s = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_S"]; } else { _oStaffinfo_new.contract_s = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SDATE"])) { _oStaffinfo_new.sdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_SDATE"]; } else { _oStaffinfo_new.sdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ACTIVE"])) { _oStaffinfo_new.active = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_ACTIVE"]; } else { _oStaffinfo_new.active = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SALESMAN_CODE"])) { _oStaffinfo_new.salesman_code = (string)_oData["STAFFINFO_NEW_SALESMAN_CODE"]; } else { _oStaffinfo_new.salesman_code = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STREAM"])) { _oStaffinfo_new.stream = (string)_oData["STAFFINFO_NEW_STREAM"]; } else { _oStaffinfo_new.stream = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_JOINDATE"])) { _oStaffinfo_new.joindate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_JOINDATE"]; } else { _oStaffinfo_new.joindate = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SHIFT"])) { _oStaffinfo_new.shift = (string)_oData["STAFFINFO_NEW_SHIFT"]; } else { _oStaffinfo_new.shift = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NO"])) { _oStaffinfo_new.staff_no = (string)_oData["STAFFINFO_NEW_STAFF_NO"]; } else { _oStaffinfo_new.staff_no = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_INTERNSHIP"])) { _oStaffinfo_new.internship = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_INTERNSHIP"]; } else { _oStaffinfo_new.internship = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LWDATE"])) { _oStaffinfo_new.lwdate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_LWDATE"]; } else { _oStaffinfo_new.lwdate = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_DDATE"])) { _oStaffinfo_new.ddate = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_DDATE"]; } else { _oStaffinfo_new.ddate = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NO2"])) { _oStaffinfo_new.staff_no2 = (string)_oData["STAFFINFO_NEW_STAFF_NO2"]; } else { _oStaffinfo_new.staff_no2 = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_ID"])) { _oStaffinfo_new.id = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_ID"]; } else { _oStaffinfo_new.id = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_TEAMCODE"])) { _oStaffinfo_new.teamcode = (string)_oData["STAFFINFO_NEW_TEAMCODE"]; } else { _oStaffinfo_new.teamcode = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CENTRE"])) { _oStaffinfo_new.centre = (string)_oData["STAFFINFO_NEW_CENTRE"]; } else { _oStaffinfo_new.centre = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_LANGUAGE"])) { _oStaffinfo_new.Language = (string)_oData["STAFFINFO_NEW_LANGUAGE"]; } else { _oStaffinfo_new.Language = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CID"])) { _oStaffinfo_new.cid = (string)_oData["STAFFINFO_NEW_CID"]; } else { _oStaffinfo_new.cid = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_NAME"])) { _oStaffinfo_new.staff_name = (string)_oData["STAFFINFO_NEW_STAFF_NAME"]; } else { _oStaffinfo_new.staff_name = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_OTC"])) { _oStaffinfo_new.otc = (global::System.Nullable<int>)_oData["STAFFINFO_NEW_OTC"]; } else { _oStaffinfo_new.otc = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_SKILL"])) { _oStaffinfo_new.skill = (string)_oData["STAFFINFO_NEW_SKILL"]; } else { _oStaffinfo_new.skill = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_FREEZE"])) { _oStaffinfo_new.freeze = (global::System.Nullable<bool>)_oData["STAFFINFO_NEW_FREEZE"]; } else { _oStaffinfo_new.freeze = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CONTRACT_E"])) { _oStaffinfo_new.contract_e = (global::System.Nullable<DateTime>)_oData["STAFFINFO_NEW_CONTRACT_E"]; } else { _oStaffinfo_new.contract_e = null; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STAFF_TYPE"])) { _oStaffinfo_new.staff_type = (string)_oData["STAFFINFO_NEW_STAFF_TYPE"]; } else { _oStaffinfo_new.staff_type = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_STEPLEVEL"])) { _oStaffinfo_new.steplevel = (string)_oData["STAFFINFO_NEW_STEPLEVEL"]; } else { _oStaffinfo_new.steplevel = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_CCC"])) { _oStaffinfo_new.ccc = (string)_oData["STAFFINFO_NEW_CCC"]; } else { _oStaffinfo_new.ccc = string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["STAFFINFO_NEW_PAY_CODE"])) { _oStaffinfo_new.pay_code = (string)_oData["STAFFINFO_NEW_PAY_CODE"]; } else { _oStaffinfo_new.pay_code = string.Empty; }
                _oStaffinfo_new.SetDB(x_oDB);
                _oStaffinfo_new.GetFound();
                _oRow.Add(_oStaffinfo_new);
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
            return GetDataSet(n_oDB, "");
        }


        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB, x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet(Staffinfo_new.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder, Staffinfo_new.Para.TableName());
            return _oDset;
        }


        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB, String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB == null) { return null; }
            return x_oDB.GetSearch(Staffinfo_new.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Staffinfo_new.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }

        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return null; }
            string _oQuery = "SELECT [CSSDB].[csc].[staffinfo_new].[basic] AS STAFFINFO_NEW_BASIC,[CSSDB].[csc].[staffinfo_new].[cid] AS STAFFINFO_NEW_CID,[CSSDB].[csc].[staffinfo_new].[steptype] AS STAFFINFO_NEW_STEPTYPE,[CSSDB].[csc].[staffinfo_new].[cdate] AS STAFFINFO_NEW_CDATE,[CSSDB].[csc].[staffinfo_new].[freeze] AS STAFFINFO_NEW_FREEZE,[CSSDB].[csc].[staffinfo_new].[lwdate] AS STAFFINFO_NEW_LWDATE,[CSSDB].[csc].[staffinfo_new].[cmrid] AS STAFFINFO_NEW_CMRID,[CSSDB].[csc].[staffinfo_new].[did] AS STAFFINFO_NEW_DID,[CSSDB].[csc].[staffinfo_new].[contract_s] AS STAFFINFO_NEW_CONTRACT_S,[CSSDB].[csc].[staffinfo_new].[sdate] AS STAFFINFO_NEW_SDATE,[CSSDB].[csc].[staffinfo_new].[active] AS STAFFINFO_NEW_ACTIVE,[CSSDB].[csc].[staffinfo_new].[salesman_code] AS STAFFINFO_NEW_SALESMAN_CODE,[CSSDB].[csc].[staffinfo_new].[ddate] AS STAFFINFO_NEW_DDATE,[CSSDB].[csc].[staffinfo_new].[stream] AS STAFFINFO_NEW_STREAM,[CSSDB].[csc].[staffinfo_new].[joindate] AS STAFFINFO_NEW_JOINDATE,[CSSDB].[csc].[staffinfo_new].[shift] AS STAFFINFO_NEW_SHIFT,[CSSDB].[csc].[staffinfo_new].[staff_no] AS STAFFINFO_NEW_STAFF_NO,[CSSDB].[csc].[staffinfo_new].[internship] AS STAFFINFO_NEW_INTERNSHIP,[CSSDB].[csc].[staffinfo_new].[centre] AS STAFFINFO_NEW_CENTRE,[CSSDB].[csc].[staffinfo_new].[pay_code] AS STAFFINFO_NEW_PAY_CODE,[CSSDB].[csc].[staffinfo_new].[staff_no2] AS STAFFINFO_NEW_STAFF_NO2,[CSSDB].[csc].[staffinfo_new].[id] AS STAFFINFO_NEW_ID,[CSSDB].[csc].[staffinfo_new].[teamcode] AS STAFFINFO_NEW_TEAMCODE,[CSSDB].[csc].[staffinfo_new].[Language] AS STAFFINFO_NEW_LANGUAGE,[CSSDB].[csc].[staffinfo_new].[staff_type] AS STAFFINFO_NEW_STAFF_TYPE,[CSSDB].[csc].[staffinfo_new].[staff_name] AS STAFFINFO_NEW_STAFF_NAME,[CSSDB].[csc].[staffinfo_new].[otc] AS STAFFINFO_NEW_OTC,[CSSDB].[csc].[staffinfo_new].[edate] AS STAFFINFO_NEW_EDATE,[CSSDB].[csc].[staffinfo_new].[contract_e] AS STAFFINFO_NEW_CONTRACT_E,[CSSDB].[csc].[staffinfo_new].[skill] AS STAFFINFO_NEW_SKILL,[CSSDB].[csc].[staffinfo_new].[steplevel] AS STAFFINFO_NEW_STEPLEVEL,[CSSDB].[csc].[staffinfo_new].[ccc] AS STAFFINFO_NEW_CCC  FROM  [CSSDB].[csc].[staffinfo_new]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));

            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
            try
            {
                _oConn.Open();
                _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery, _oConn);
                _oAdp.SelectCommand.ExecuteNonQuery();
                _oAdp.Fill(_oDset, "staffinfo_new");
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
        #endregion

        #region Insert
        /// <summary>
        /// Summary description for management Insert
        /// </summary>

        public bool Insert(global::System.Nullable<int> x_iBasic, System.Nullable<DateTime> x_dEdate, string x_sSteptype, System.Nullable<DateTime> x_dCdate, string x_sCmrid, string x_sDid, System.Nullable<DateTime> x_dContract_s, System.Nullable<DateTime> x_dSdate, System.Nullable<bool> x_bActive, string x_sSalesman_code, string x_sStream, System.Nullable<DateTime> x_dJoindate, string x_sShift, string x_sStaff_no, System.Nullable<bool> x_bInternship, System.Nullable<DateTime> x_dLwdate, System.Nullable<DateTime> x_dDdate, string x_sStaff_no2, string x_sTeamcode, string x_sCentre, string x_sLanguage, string x_sCid, string x_sStaff_name, System.Nullable<int> x_iOtc, string x_sSkill, System.Nullable<bool> x_bFreeze, System.Nullable<DateTime> x_dContract_e, string x_sStaff_type, string x_sSteplevel, string x_sCcc, string x_sPay_code)
        {
            Staffinfo_new _oStaffinfo_new = new Staffinfo_new();
            _oStaffinfo_new.basic = x_iBasic;
            _oStaffinfo_new.edate = x_dEdate;
            _oStaffinfo_new.steptype = x_sSteptype;
            _oStaffinfo_new.cdate = x_dCdate;
            _oStaffinfo_new.cmrid = x_sCmrid;
            _oStaffinfo_new.did = x_sDid;
            _oStaffinfo_new.contract_s = x_dContract_s;
            _oStaffinfo_new.sdate = x_dSdate;
            _oStaffinfo_new.active = x_bActive;
            _oStaffinfo_new.salesman_code = x_sSalesman_code;
            _oStaffinfo_new.stream = x_sStream;
            _oStaffinfo_new.joindate = x_dJoindate;
            _oStaffinfo_new.shift = x_sShift;
            _oStaffinfo_new.staff_no = x_sStaff_no;
            _oStaffinfo_new.internship = x_bInternship;
            _oStaffinfo_new.lwdate = x_dLwdate;
            _oStaffinfo_new.ddate = x_dDdate;
            _oStaffinfo_new.staff_no2 = x_sStaff_no2;
            _oStaffinfo_new.teamcode = x_sTeamcode;
            _oStaffinfo_new.centre = x_sCentre;
            _oStaffinfo_new.Language = x_sLanguage;
            _oStaffinfo_new.cid = x_sCid;
            _oStaffinfo_new.staff_name = x_sStaff_name;
            _oStaffinfo_new.otc = x_iOtc;
            _oStaffinfo_new.skill = x_sSkill;
            _oStaffinfo_new.freeze = x_bFreeze;
            _oStaffinfo_new.contract_e = x_dContract_e;
            _oStaffinfo_new.staff_type = x_sStaff_type;
            _oStaffinfo_new.steplevel = x_sSteplevel;
            _oStaffinfo_new.ccc = x_sCcc;
            _oStaffinfo_new.pay_code = x_sPay_code;
            return InsertWithOutLastID(n_oDB, _oStaffinfo_new);
        }


        public static bool Insert(MSSQLConnect x_oDB, System.Nullable<int> x_iBasic, System.Nullable<DateTime> x_dEdate, string x_sSteptype, System.Nullable<DateTime> x_dCdate, string x_sCmrid, string x_sDid, System.Nullable<DateTime> x_dContract_s, System.Nullable<DateTime> x_dSdate, System.Nullable<bool> x_bActive, string x_sSalesman_code, string x_sStream, System.Nullable<DateTime> x_dJoindate, string x_sShift, string x_sStaff_no, System.Nullable<bool> x_bInternship, System.Nullable<DateTime> x_dLwdate, System.Nullable<DateTime> x_dDdate, string x_sStaff_no2, string x_sTeamcode, string x_sCentre, string x_sLanguage, string x_sCid, string x_sStaff_name, System.Nullable<int> x_iOtc, string x_sSkill, System.Nullable<bool> x_bFreeze, System.Nullable<DateTime> x_dContract_e, string x_sStaff_type, string x_sSteplevel, string x_sCcc, string x_sPay_code)
        {
            Staffinfo_new _oStaffinfo_new = new Staffinfo_new();
            _oStaffinfo_new.basic = x_iBasic;
            _oStaffinfo_new.edate = x_dEdate;
            _oStaffinfo_new.steptype = x_sSteptype;
            _oStaffinfo_new.cdate = x_dCdate;
            _oStaffinfo_new.cmrid = x_sCmrid;
            _oStaffinfo_new.did = x_sDid;
            _oStaffinfo_new.contract_s = x_dContract_s;
            _oStaffinfo_new.sdate = x_dSdate;
            _oStaffinfo_new.active = x_bActive;
            _oStaffinfo_new.salesman_code = x_sSalesman_code;
            _oStaffinfo_new.stream = x_sStream;
            _oStaffinfo_new.joindate = x_dJoindate;
            _oStaffinfo_new.shift = x_sShift;
            _oStaffinfo_new.staff_no = x_sStaff_no;
            _oStaffinfo_new.internship = x_bInternship;
            _oStaffinfo_new.lwdate = x_dLwdate;
            _oStaffinfo_new.ddate = x_dDdate;
            _oStaffinfo_new.staff_no2 = x_sStaff_no2;
            _oStaffinfo_new.teamcode = x_sTeamcode;
            _oStaffinfo_new.centre = x_sCentre;
            _oStaffinfo_new.Language = x_sLanguage;
            _oStaffinfo_new.cid = x_sCid;
            _oStaffinfo_new.staff_name = x_sStaff_name;
            _oStaffinfo_new.otc = x_iOtc;
            _oStaffinfo_new.skill = x_sSkill;
            _oStaffinfo_new.freeze = x_bFreeze;
            _oStaffinfo_new.contract_e = x_dContract_e;
            _oStaffinfo_new.staff_type = x_sStaff_type;
            _oStaffinfo_new.steplevel = x_sSteplevel;
            _oStaffinfo_new.ccc = x_sCcc;
            _oStaffinfo_new.pay_code = x_sPay_code;
            return InsertWithOutLastID(x_oDB, _oStaffinfo_new);
        }


        public bool Insert(Staffinfo_new x_oStaffinfo_new)
        {
            return InsertWithOutLastID(n_oDB, x_oStaffinfo_new);
        }


        public static bool Insert(MSSQLConnect x_oDB, Staffinfo_new x_oStaffinfo_new)
        {
            return InsertWithOutLastID(x_oDB, x_oStaffinfo_new);
        }


        public static bool InsertWithOutLastID(MSSQLConnect x_oDB, Staffinfo_new x_oStaffinfo_new)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT INTO  [CSSDB].[csc].[staffinfo_new]   ([basic],[cid],[steptype],[cdate],[freeze],[lwdate],[cmrid],[did],[contract_s],[sdate],[active],[salesman_code],[ddate],[stream],[joindate],[shift],[staff_no],[internship],[centre],[pay_code],[staff_no2],[teamcode],[Language],[staff_type],[staff_name],[otc],[edate],[contract_e],[skill],[steplevel],[ccc])  VALUES  (@basic,@cid,@steptype,@cdate,@freeze,@lwdate,@cmrid,@did,@contract_s,@sdate,@active,@salesman_code,@ddate,@stream,@joindate,@shift,@staff_no,@internship,@centre,@pay_code,@staff_no2,@teamcode,@Language,@staff_type,@staff_name,@otc,@edate,@contract_e,@skill,@steplevel,@ccc)";

            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            return InsertTransactionWithOutLastID(_oConn, _oCmd, x_oStaffinfo_new);
        }

        public static bool InsertTransactionWithOutLastID(global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, Staffinfo_new x_oStaffinfo_new)
        {
            bool _bResult = false;
            if (!x_oStaffinfo_new.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if (x_oStaffinfo_new.basic == null) { x_oCmd.Parameters.Add("@basic", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@basic", global::System.Data.SqlDbType.Int).Value = x_oStaffinfo_new.basic; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.cid)) { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oStaffinfo_new.cid; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.steptype)) { x_oCmd.Parameters.Add("@steptype", global::System.Data.SqlDbType.NVarChar, 4).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@steptype", global::System.Data.SqlDbType.NVarChar, 4).Value = x_oStaffinfo_new.steptype; }
                if (x_oStaffinfo_new.cdate == null) { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.cdate; }
                if (x_oStaffinfo_new.freeze == null) { x_oCmd.Parameters.Add("@freeze", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@freeze", global::System.Data.SqlDbType.Bit).Value = x_oStaffinfo_new.freeze; }
                if (x_oStaffinfo_new.lwdate == null) { x_oCmd.Parameters.Add("@lwdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@lwdate", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.lwdate; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.cmrid)) { x_oCmd.Parameters.Add("@cmrid", global::System.Data.SqlDbType.NVarChar, 4).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@cmrid", global::System.Data.SqlDbType.NVarChar, 4).Value = x_oStaffinfo_new.cmrid; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.did)) { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oStaffinfo_new.did; }
                if (x_oStaffinfo_new.contract_s == null) { x_oCmd.Parameters.Add("@contract_s", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@contract_s", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.contract_s; }
                if (x_oStaffinfo_new.sdate == null) { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.sdate; }
                if (x_oStaffinfo_new.active == null) { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_oStaffinfo_new.active; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.salesman_code)) { x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar, 4).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar, 4).Value = x_oStaffinfo_new.salesman_code; }
                if (x_oStaffinfo_new.ddate == null) { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.ddate; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.stream)) { x_oCmd.Parameters.Add("@stream", global::System.Data.SqlDbType.NVarChar, 5).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@stream", global::System.Data.SqlDbType.NVarChar, 5).Value = x_oStaffinfo_new.stream; }
                if (x_oStaffinfo_new.joindate == null) { x_oCmd.Parameters.Add("@joindate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@joindate", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.joindate; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.shift)) { x_oCmd.Parameters.Add("@shift", global::System.Data.SqlDbType.NVarChar, 15).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@shift", global::System.Data.SqlDbType.NVarChar, 15).Value = x_oStaffinfo_new.shift; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_no)) { x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oStaffinfo_new.staff_no; }
                if (x_oStaffinfo_new.internship == null) { x_oCmd.Parameters.Add("@internship", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@internship", global::System.Data.SqlDbType.Bit).Value = x_oStaffinfo_new.internship; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.centre)) { x_oCmd.Parameters.Add("@centre", global::System.Data.SqlDbType.NVarChar, 5).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@centre", global::System.Data.SqlDbType.NVarChar, 5).Value = x_oStaffinfo_new.centre; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.pay_code)) { x_oCmd.Parameters.Add("@pay_code", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@pay_code", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oStaffinfo_new.pay_code; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_no2)) { x_oCmd.Parameters.Add("@staff_no2", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@staff_no2", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oStaffinfo_new.staff_no2; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.teamcode)) { x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar, 15).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar, 15).Value = x_oStaffinfo_new.teamcode; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.Language)) { x_oCmd.Parameters.Add("@Language", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@Language", global::System.Data.SqlDbType.NVarChar, 10).Value = x_oStaffinfo_new.Language; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_type)) { x_oCmd.Parameters.Add("@staff_type", global::System.Data.SqlDbType.NVarChar, 5).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@staff_type", global::System.Data.SqlDbType.NVarChar, 5).Value = x_oStaffinfo_new.staff_type; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_name)) { x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar, 50).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar, 50).Value = x_oStaffinfo_new.staff_name; }
                if (x_oStaffinfo_new.otc == null) { x_oCmd.Parameters.Add("@otc", global::System.Data.SqlDbType.Int).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@otc", global::System.Data.SqlDbType.Int).Value = x_oStaffinfo_new.otc; }
                if (x_oStaffinfo_new.edate == null) { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.edate; }
                if (x_oStaffinfo_new.contract_e == null) { x_oCmd.Parameters.Add("@contract_e", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { x_oCmd.Parameters.Add("@contract_e", global::System.Data.SqlDbType.DateTime).Value = x_oStaffinfo_new.contract_e; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.skill)) { x_oCmd.Parameters.Add("@skill", global::System.Data.SqlDbType.NVarChar, 5).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@skill", global::System.Data.SqlDbType.NVarChar, 5).Value = x_oStaffinfo_new.skill; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.steplevel)) { x_oCmd.Parameters.Add("@steplevel", global::System.Data.SqlDbType.NVarChar, 4).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@steplevel", global::System.Data.SqlDbType.NVarChar, 4).Value = x_oStaffinfo_new.steplevel; }
                if (string.IsNullOrEmpty(x_oStaffinfo_new.ccc)) { x_oCmd.Parameters.Add("@ccc", global::System.Data.SqlDbType.NVarChar, 3).Value = global::System.DBNull.Value; } else { x_oCmd.Parameters.Add("@ccc", global::System.Data.SqlDbType.NVarChar, 3).Value = x_oStaffinfo_new.ccc; }
                x_oCmd.CommandType = CommandType.Text;
                x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
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


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, System.Nullable<int> x_iBasic, System.Nullable<DateTime> x_dEdate, string x_sSteptype, System.Nullable<DateTime> x_dCdate, string x_sCmrid, string x_sDid, System.Nullable<DateTime> x_dContract_s, System.Nullable<DateTime> x_dSdate, System.Nullable<bool> x_bActive, string x_sSalesman_code, string x_sStream, System.Nullable<DateTime> x_dJoindate, string x_sShift, string x_sStaff_no, System.Nullable<bool> x_bInternship, System.Nullable<DateTime> x_dLwdate, System.Nullable<DateTime> x_dDdate, string x_sStaff_no2, string x_sTeamcode, string x_sCentre, string x_sLanguage, string x_sCid, string x_sStaff_name, System.Nullable<int> x_iOtc, string x_sSkill, System.Nullable<bool> x_bFreeze, System.Nullable<DateTime> x_dContract_e, string x_sStaff_type, string x_sSteplevel, string x_sCcc, string x_sPay_code)
        {
            int _oLastID;
            Staffinfo_new _oStaffinfo_new = new Staffinfo_new();
            _oStaffinfo_new.basic = x_iBasic;
            _oStaffinfo_new.edate = x_dEdate;
            _oStaffinfo_new.steptype = x_sSteptype;
            _oStaffinfo_new.cdate = x_dCdate;
            _oStaffinfo_new.cmrid = x_sCmrid;
            _oStaffinfo_new.did = x_sDid;
            _oStaffinfo_new.contract_s = x_dContract_s;
            _oStaffinfo_new.sdate = x_dSdate;
            _oStaffinfo_new.active = x_bActive;
            _oStaffinfo_new.salesman_code = x_sSalesman_code;
            _oStaffinfo_new.stream = x_sStream;
            _oStaffinfo_new.joindate = x_dJoindate;
            _oStaffinfo_new.shift = x_sShift;
            _oStaffinfo_new.staff_no = x_sStaff_no;
            _oStaffinfo_new.internship = x_bInternship;
            _oStaffinfo_new.lwdate = x_dLwdate;
            _oStaffinfo_new.ddate = x_dDdate;
            _oStaffinfo_new.staff_no2 = x_sStaff_no2;
            _oStaffinfo_new.teamcode = x_sTeamcode;
            _oStaffinfo_new.centre = x_sCentre;
            _oStaffinfo_new.Language = x_sLanguage;
            _oStaffinfo_new.cid = x_sCid;
            _oStaffinfo_new.staff_name = x_sStaff_name;
            _oStaffinfo_new.otc = x_iOtc;
            _oStaffinfo_new.skill = x_sSkill;
            _oStaffinfo_new.freeze = x_bFreeze;
            _oStaffinfo_new.contract_e = x_dContract_e;
            _oStaffinfo_new.staff_type = x_sStaff_type;
            _oStaffinfo_new.steplevel = x_sSteplevel;
            _oStaffinfo_new.ccc = x_sCcc;
            _oStaffinfo_new.pay_code = x_sPay_code;
            if (InsertWithLastID_SP(x_oDB, _oStaffinfo_new, out _oLastID))
            {
                return _oLastID;
            }
            else
            {
                return -1;
            }
        }


        public int InsertReturnLastID_SP(Staffinfo_new x_oStaffinfo_new)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oStaffinfo_new, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }


        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Staffinfo_new x_oStaffinfo_new)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oStaffinfo_new, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }

        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB, Staffinfo_new x_oStaffinfo_new, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB == null) { return false; }
            string _sQuery = "INSERT_STAFFINFO_NEW";
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            return InsertTransactionWithLastID_SP(_oConn, _oCmd, x_oStaffinfo_new, out x_oLAST_ID);
        }

        protected static bool InsertTransactionWithLastID_SP(global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd, Staffinfo_new x_oStaffinfo_new, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            global::System.Data.SqlClient.SqlParameter _oPar;
            try
            {
                _oPar = x_oCmd.Parameters.Add("@basic", global::System.Data.SqlDbType.Int);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.basic == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.basic; }
                _oPar = x_oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.cid)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.cid; }
                _oPar = x_oCmd.Parameters.Add("@steptype", global::System.Data.SqlDbType.NVarChar, 4);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.steptype)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.steptype; }
                _oPar = x_oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.cdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.cdate; }
                _oPar = x_oCmd.Parameters.Add("@freeze", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.freeze == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.freeze; }
                _oPar = x_oCmd.Parameters.Add("@lwdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.lwdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.lwdate; }
                _oPar = x_oCmd.Parameters.Add("@cmrid", global::System.Data.SqlDbType.NVarChar, 4);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.cmrid)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.cmrid; }
                _oPar = x_oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.did)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.did; }
                _oPar = x_oCmd.Parameters.Add("@contract_s", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.contract_s == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.contract_s; }
                _oPar = x_oCmd.Parameters.Add("@sdate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.sdate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.sdate; }
                _oPar = x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.active == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.active; }
                _oPar = x_oCmd.Parameters.Add("@salesman_code", global::System.Data.SqlDbType.NVarChar, 4);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.salesman_code)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.salesman_code; }
                _oPar = x_oCmd.Parameters.Add("@ddate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.ddate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.ddate; }
                _oPar = x_oCmd.Parameters.Add("@stream", global::System.Data.SqlDbType.NVarChar, 5);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.stream)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.stream; }
                _oPar = x_oCmd.Parameters.Add("@joindate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.joindate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.joindate; }
                _oPar = x_oCmd.Parameters.Add("@shift", global::System.Data.SqlDbType.NVarChar, 15);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.shift)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.shift; }
                _oPar = x_oCmd.Parameters.Add("@staff_no", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_no)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.staff_no; }
                _oPar = x_oCmd.Parameters.Add("@internship", global::System.Data.SqlDbType.Bit);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.internship == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.internship; }
                _oPar = x_oCmd.Parameters.Add("@centre", global::System.Data.SqlDbType.NVarChar, 5);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.centre)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.centre; }
                _oPar = x_oCmd.Parameters.Add("@pay_code", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.pay_code)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.pay_code; }
                _oPar = x_oCmd.Parameters.Add("@staff_no2", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_no2)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.staff_no2; }
                _oPar = x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar, 15);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.teamcode)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.teamcode; }
                _oPar = x_oCmd.Parameters.Add("@Language", global::System.Data.SqlDbType.NVarChar, 10);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.Language)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.Language; }
                _oPar = x_oCmd.Parameters.Add("@staff_type", global::System.Data.SqlDbType.NVarChar, 5);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_type)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.staff_type; }
                _oPar = x_oCmd.Parameters.Add("@staff_name", global::System.Data.SqlDbType.NVarChar, 50);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.staff_name)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.staff_name; }
                _oPar = x_oCmd.Parameters.Add("@otc", global::System.Data.SqlDbType.Int);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.otc == null) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.otc; }
                _oPar = x_oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.edate == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.edate; }
                _oPar = x_oCmd.Parameters.Add("@contract_e", global::System.Data.SqlDbType.DateTime);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (x_oStaffinfo_new.contract_e == null) { _oPar.Value = SqlDateTime.Null; } else { _oPar.Value = x_oStaffinfo_new.contract_e; }
                _oPar = x_oCmd.Parameters.Add("@skill", global::System.Data.SqlDbType.NVarChar, 5);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.skill)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.skill; }
                _oPar = x_oCmd.Parameters.Add("@steplevel", global::System.Data.SqlDbType.NVarChar, 4);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.steplevel)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.steplevel; }
                _oPar = x_oCmd.Parameters.Add("@ccc", global::System.Data.SqlDbType.NVarChar, 3);
                _oPar.Direction = global::System.Data.ParameterDirection.Input;
                if (string.IsNullOrEmpty(x_oStaffinfo_new.ccc)) { _oPar.Value = global::System.DBNull.Value; } else { _oPar.Value = x_oStaffinfo_new.ccc; }
                _oPar = x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction = global::System.Data.ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
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




        #endregion

        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>

        public bool Delete(global::System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }

        public static bool Delete(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            if (x_iId == null) { return false; }
            string _sQuery = "DELETE FROM  [CSSDB].[csc].[staffinfo_new]  WHERE [CSSDB].[csc].[staffinfo_new].[id]=@id";

            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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

        public bool Delete(string x_sStaff_no2, string x_sStaff_no)
        {
            return DeleteProc(n_oDB, x_sStaff_no2, x_sStaff_no);
        }

        public static bool Delete(MSSQLConnect x_oDB, string x_sStaff_no2, string x_sStaff_no)
        {
            return DeleteProc(x_oDB, x_sStaff_no2, x_sStaff_no);
        }


        private static bool DeleteProc(MSSQLConnect x_oDB, string x_sStaff_no2, string x_sStaff_no)
        {
            if (string.IsNullOrEmpty(x_sStaff_no2)) { return false; }
            if (string.IsNullOrEmpty(x_sStaff_no)) { return false; }
            string _sQuery = "DELETE FROM  [CSSDB].[csc].[staffinfo_new]  WHERE [CSSDB].[csc].[staffinfo_new].[staff_no2]=@staff_no2 AND [CSSDB].[csc].[staffinfo_new].[staff_no]=@staff_no";

            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            _oCmd.Parameters.Add("@staff_no2", global::System.Data.SqlDbType.NVarChar, 10).Value = x_sStaff_no2;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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


        public bool DeleteAll()
        {
            if (n_oDB == null) { return false; }
            return Staffinfo_newManagerBase.DeleteAll(n_oDB);
        }

        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "DELETE FROM  [CSSDB].[csc].[staffinfo_new]";

            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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


        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB, x_sFilter);
        }

        public static bool DeleteFilter(MSSQLConnect x_oDB, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            if (!"".Equals(x_sFilter)) { x_sFilter = " WHERE " + x_sFilter; }
            string _sQuery = "DELETE FROM [CSSDB].[csc].[staffinfo_new]" + x_sFilter;

            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
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
        #endregion
    }
}


