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
///-- Description:	<Description,Table :[CSSDB].[dbo].[ar_rights],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[ar_rights] Object Base layer
    /// </summary>
    public class Ar_rightss:Collection<Ar_rights>{}
    public class Ar_rights: Ar_rightsBase{
        
        #region Constructor
        
        public Ar_rights() : base(){
        }
        public Ar_rights(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public Ar_rights(MSSQLConnect x_oDB,System.Nullable<int> x_iAPPL_ID) : base(x_oDB,x_iAPPL_ID) {
        }
        
        ~Ar_rights(){
            base.Release();
        }
        #endregion
        
        
    }
}


