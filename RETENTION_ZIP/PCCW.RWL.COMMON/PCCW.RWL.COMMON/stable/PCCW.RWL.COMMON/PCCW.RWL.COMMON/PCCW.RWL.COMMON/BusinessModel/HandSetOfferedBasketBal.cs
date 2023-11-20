using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
///-- Create date: <Create Date 2009-02-22>
///-- Description:	<Description,Table :[HandSetOfferedBasket],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [HandSetOfferedBasket] Business layer
    /// </summary>


    public class HandSetOfferedBasketBals : Collection<HandSetOfferedBasket> { }
    public class HandSetOfferedBasketBal : HandSetOfferedBasketBalBase
    {

        #region Constructor


        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public HandSetOfferedBasketBal()
            : base()
        {
        }
        ~HandSetOfferedBasketBal()
        {
            base.Release();
        }
        #endregion

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

        public static global::System.Collections.Generic.List<string> DrpCon_perList()
        {
            global::System.Collections.Generic.List<string> _oCon_perList = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("select DISTINCT con_per from " + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket with (nolock) where active=1 ");
            while (_oReader.Read())
            {
                _oCon_perList.Add(_oReader["con_per"].ToString());
            }
            if (_oReader != null) _oReader.Close();
            return _oCon_perList;
        }

        #region Update Active
        public static bool SaveActive(MSSQLConnect x_oDB, bool x_bActive, string x_sUid, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "UPDATE  [HandSetOfferedBasket]  SET  [ddate]=getdate(), [active]=@active,[did]=@did WHERE " + x_sFilter;
            if (!string.IsNullOrEmpty(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]", "[" + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            _oCmd.Parameters.Add("@did", global::System.Data.SqlDbType.NVarChar).Value = x_sUid;
            _oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = x_bActive;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
            }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        #endregion

        #region Update EndDate
        public static bool SaveEndDate(MSSQLConnect x_oDB, Nullable<DateTime> x_dEdate, string x_sUid, string x_sFilter)
        {
            if (x_oDB == null) { return false; }
            string _sQuery = "UPDATE  [HandSetOfferedBasket]  SET  [cdate]=@cdate,[edate]=@edate,[cid]=@cid WHERE " + x_sFilter;
            if (!string.IsNullOrEmpty(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferedBasket]", "[" + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket]"); }
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = DateTime.Now;
            if (x_dEdate == null) { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = SqlDateTime.Null; } else { _oCmd.Parameters.Add("@edate", global::System.Data.SqlDbType.DateTime).Value = x_dEdate; }
            if (string.IsNullOrEmpty(x_sUid)) { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = global::System.DBNull.Value; } else { _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.NVarChar, 10).Value = x_sUid; }
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


