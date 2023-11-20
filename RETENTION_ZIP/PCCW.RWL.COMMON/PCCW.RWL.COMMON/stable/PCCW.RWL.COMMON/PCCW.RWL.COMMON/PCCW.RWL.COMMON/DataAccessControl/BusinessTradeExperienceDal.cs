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
///-- Create date: <Create Date 2011-03-14>
///-- Description:	<Description,Table :[BusinessTradeExperience],DataAccess layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [BusinessTradeExperience] DataAccess layer
    /// </summary>
    
    public class BusinessTradeExperienceDals:Collection<BusinessTradeExperience>{}
    public class BusinessTradeExperienceDal: BusinessTradeExperienceDalDAO{
        
        #region Constructor
        
        public BusinessTradeExperienceDal() : base(){
        }
        ~BusinessTradeExperienceDal(){
            base.Release();
        }
        #endregion
        
        
    }
}


