using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
///-- Description:	<Description,Table :[crm_customer],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [crm_customer] Object Base layer
    /// </summary>
    public class Crm_customers:Collection<Crm_customer>{}
    public class Crm_customer: Crm_customerBase{
        
        #region Constructor
        
        public Crm_customer() : base(){
        }
        public Crm_customer(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public Crm_customer(MSSQLConnect x_oDB,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_type,string x_sCust_title,string x_sId_type,string x_sCon_email,System.Nullable<int> x_iCust_id,string x_sCust_name,System.Nullable<DateTime> x_dDdate,string x_sTel_night,string x_sTel_day,string x_sFr_cl,string x_sHkid_br) : base(x_oDB,x_bActive,x_dCdate,x_sCid,x_sDid,x_sCust_type,x_sCust_title,x_sId_type,x_sCon_email,x_iCust_id,x_sCust_name,x_dDdate,x_sTel_night,x_sTel_day,x_sFr_cl,x_sHkid_br){
        }
        
        ~Crm_customer(){
            base.Release();
        }
        #endregion
        
        
        
    }
}


