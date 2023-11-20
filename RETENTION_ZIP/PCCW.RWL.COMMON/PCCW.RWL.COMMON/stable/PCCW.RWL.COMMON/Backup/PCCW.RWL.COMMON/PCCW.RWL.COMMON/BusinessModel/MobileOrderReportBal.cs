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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-02-22>
///-- Description:	<Description,Table :[MobileOrderReport],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [MobileOrderReport] Business layer
    /// </summary>


    public class MobileOrderReportBals : Collection<MobileOrderReport> { }
    public class MobileOrderReportBal : MobileOrderReportBalBase
    {

        #region Constructor
        // ******************************
        // *  Handler for Class Constructor
        // ******************************

        public MobileOrderReportBal()
            : base()
        {
        }
        ~MobileOrderReportBal()
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


        public static bool UpdateOrderStatus(string x_sOrder_status, System.Nullable<DateTime> x_dCdate, string x_sRetrieve_sn, string x_sCid, System.Nullable<DateTime> x_dRetrieve_date, string x_sFallout_reply, System.Nullable<int> x_iOrder_id)
        {

            string _sQuery = "UPDATE  [MobileOrderReport]  SET [order_status]=@order_status,[cdate]=@cdate,[retrieve_sn]=@retrieve_sn,[cid]=@cid,[retrieve_date]=@retrieve_date,[fallout_reply]=@fallout_reply WHERE [MobileOrderReport].[order_id]=@order_id AND [MobileOrderReport].[active]=1 AND [MobileOrderReport].[order_status]='FALLOUT'";
            global::System.Data.SqlClient.SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            _oCmd.Parameters.Add("@order_status", global::System.Data.SqlDbType.NVarChar).Value = x_sOrder_status;
            _oCmd.Parameters.Add("@cdate", global::System.Data.SqlDbType.DateTime).Value = x_dCdate;
            _oCmd.Parameters.Add("@retrieve_sn", global::System.Data.SqlDbType.Char).Value = x_sRetrieve_sn;
            _oCmd.Parameters.Add("@cid", global::System.Data.SqlDbType.Char).Value = x_sCid;
            _oCmd.Parameters.Add("@retrieve_date", global::System.Data.SqlDbType.DateTime).Value = x_dRetrieve_date;
            _oCmd.Parameters.Add("@fallout_reply", global::System.Data.SqlDbType.Text).Value = x_sFallout_reply;
            _oCmd.Parameters.Add("@order_id", global::System.Data.SqlDbType.Int).Value = x_iOrder_id;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch (Exception error)
            {
                //Response.Write(error.ToString());
            }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }

    }
}


