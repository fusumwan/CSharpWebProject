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
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2010-09-17>
///-- Description:	<Description,Table :[sqll],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [sqll] Object Base layer
    /// </summary>
    public class Sqlls:Collection<Sqll>{}
    public class Sqll: SqllEntity{
        
        #region Constructor
        
        public Sqll() : base(){
        }
        public Sqll(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public Sqll(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sTxt,string x_sIp,global::System.Nullable<int> x_iIdx) : base(x_oDB,x_dCdate,x_sTxt,x_sIp,x_iIdx){
        }
        
        ~Sqll(){
            base.Release();
        }
        #endregion
        
        
        
    }
}


