using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

namespace PCCW.RWL.CORE
{
    public class MobileGList
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public static bool UpdateMobileGType(string x_sEDF, string x_sMobileNo)
        {
            if (string.IsNullOrEmpty(x_sEDF)) return false;
            if (string.IsNullOrEmpty(x_sMobileNo)) return false;
            string _sQuery1 = "SELECT TOP 1 MRT FROM [CSSDB].[CSC].[Migrate2GList] WHERE MRT='" + x_sMobileNo + "' AND ACTIVE=1";
            string _sQuery2 = "UPDATE SUNDAY_FORM SET FG_QTY0='Y' WHERE REFERENCENO='" + x_sEDF + "' AND ROWNUM<=1";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>
                .Connect("CSSDB")
                .GetSearch(_sQuery1);
            if (!_oDr.Read())
            {
                _oDr.Close();
                _oDr.Dispose();
                return false;
            }
            _oDr.Close();
            _oDr.Dispose();
            return SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery2);
        }
    }
}
