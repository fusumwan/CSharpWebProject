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
///-- Description:	<Description,Table :[RebateGroup],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [RebateGroup] Business layer
    /// </summary>
    
    
    public class RebateGroupBals:Collection<RebateGroup>{}
    public class RebateGroupBal: RebateGroupBalBase{

        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public RebateGroupBal() : base(){
        }
        ~RebateGroupBal(){
            base.Release();
        }
        #endregion

        public static global::System.Collections.Generic.List<string> DrpRebateGpList()
        {
            global::System.Collections.Generic.List<string> _oRebateGpList = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("select DISTINCT gp from " +Configurator.MSSQLTablePrefix+ "RebateGroup with (nolock) where active=1 ");
            while (_oReader.Read()){
                _oRebateGpList.Add(_oReader["gp"].ToString());
            }
            if(_oReader!=null) _oReader.Close();
            return _oRebateGpList;
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


