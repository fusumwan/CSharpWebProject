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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[crm_cust_num],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [crm_cust_num] Object Base layer
    /// </summary>
    public class Crm_cust_nums:Collection<Crm_cust_num>{}
    public class Crm_cust_num: Crm_cust_numBase{
        
        #region Constructor
        
        public Crm_cust_num() : base(){
        }
        public Crm_cust_num(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public Crm_cust_num(MSSQLConnect x_oDB,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,string x_sCust_num,System.Nullable<int> x_iCust_id,System.Nullable<int> x_iOrder_id,System.Nullable<DateTime> x_dDdate) : base(x_oDB,x_bActive,x_dCdate,x_sCid,x_sDid,x_sCust_num,x_iCust_id,x_iOrder_id,x_dDdate){
        }
        
        ~Crm_cust_num(){
            base.Release();
        }
        #endregion
        
        
        
    }
}


