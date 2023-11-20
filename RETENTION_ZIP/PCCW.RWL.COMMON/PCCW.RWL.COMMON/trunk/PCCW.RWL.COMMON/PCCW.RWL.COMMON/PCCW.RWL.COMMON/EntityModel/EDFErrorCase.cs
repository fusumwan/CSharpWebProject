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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2010-05-31>
///-- Description:	<Description,Table :[EDFErrorCase],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [EDFErrorCase] Object Base layer
    /// </summary>
    public class EDFErrorCases:Collection<EDFErrorCase>{}
    public class EDFErrorCase: EDFErrorCaseEntity{
        
        #region Constructor
        
        public EDFErrorCase() : base(){
        }
        public EDFErrorCase(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public EDFErrorCase(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId) : base(x_oDB,x_iId) {
        }
        
        ~EDFErrorCase(){
            base.Release();
        }
        #endregion
        
        
    }
}


