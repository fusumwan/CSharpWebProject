using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
///-- Create date: <Create Date 2010-05-31>
///-- Description:	<Description,Table :[EDFErrorCase],DataAccess layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [EDFErrorCase] DataAccess layer
    /// </summary>
    
    public class EDFErrorCaseDals:Collection<EDFErrorCase>{}
    public class EDFErrorCaseDal: EDFErrorCaseDalDAO{
        
        #region Constructor
        
        public EDFErrorCaseDal() : base(){
        }
        ~EDFErrorCaseDal(){
            base.Release();
        }
        #endregion
        
        
    }
}


