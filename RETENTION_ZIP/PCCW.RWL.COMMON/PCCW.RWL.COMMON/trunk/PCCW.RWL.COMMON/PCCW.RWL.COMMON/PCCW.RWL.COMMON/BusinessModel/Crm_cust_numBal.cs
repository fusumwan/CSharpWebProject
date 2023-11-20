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
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[crm_cust_num],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [crm_cust_num] Business layer
    /// </summary>
    
    
    public class Crm_cust_numBals:Collection<Crm_cust_num>{}
    public class Crm_cust_numBal: Crm_cust_numBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public Crm_cust_numBal() : base(){
        }
        ~Crm_cust_numBal(){
            base.Release();
        }
        #endregion
        
        
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.CRM + (((Configurator.IsUat()) ? "2" : string.Empty)));
            return _oDB;
        }
        #endregion
        
    }
}


