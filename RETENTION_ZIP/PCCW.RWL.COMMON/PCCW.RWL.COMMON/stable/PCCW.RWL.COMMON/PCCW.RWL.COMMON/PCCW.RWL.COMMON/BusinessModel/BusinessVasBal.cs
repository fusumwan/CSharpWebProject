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
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[BusinessVas],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BusinessVas] Business layer
    /// </summary>
    
    
    public class BusinessVasBals:Collection<BusinessVas>{}
    public class BusinessVasBal: BusinessVasBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public BusinessVasBal() : base(){
        }
        ~BusinessVasBal(){
            base.Release();
        }
        #endregion

        public static Hashtable DrpVasList(bool x_bFirstEmptyRecord)
        {
            Hashtable _oVasList = new Hashtable();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            if (x_bFirstEmptyRecord)
                _sQuery.Append(" SELECT 'vas_field'='', 'vas_name'=''  UNION ALL ");
            _sQuery.Append("SELECT DISTINCT vas_field,vas_name FROM " + Configurator.MSSQLTablePrefix + "BusinessVas where active=1 ORDER BY vas_name");
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            while (_oReader.Read())
            {
                _oVasList.Add(_oReader["vas_name"].ToString(), _oReader["vas_field"].ToString());
            }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _oVasList;

        }

        public static Hashtable DrpVasList()
        {
            return DrpVasList(false);

        }

        public static global::System.Data.DataSet DsVasList()
        {
            return DsVasList(false);
        }

        public static global::System.Data.DataSet DsVasList(bool x_bFirstEmptyRecord)
        {
            global::System.Data.DataSet _oDs = new global::System.Data.DataSet();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            if(x_bFirstEmptyRecord)
                _sQuery.Append(" SELECT 'vas_field'='', 'vas_name'=''  UNION ALL ");
            _sQuery.Append("SELECT DISTINCT vas_field,vas_name FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1 order by vas_name");

            _oDs = SYSConn<MSSQLConnect>.Connect().GetDS(_sQuery.ToString());
            if (_oDs != null) if (_oDs.Tables.Count > 0) return _oDs;
            return (new DataSet());
        }

        public static List<string> VasFieldFilter(){
            List<string> _oVasFieldFiter = new List<string>();
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT DISTINCT vas_field FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1 ORDER BY vas_field");
            while (_oDr.Read()){
                if (!Func.FR(_oDr["vas_field"]).Trim().Equals(string.Empty)){ _oVasFieldFiter.Add(Func.FR(_oDr["vas_field"]).Trim());}
            }
            _oDr.Close();
            _oDr.Dispose();
            return _oVasFieldFiter;
        }

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        
    }
}


