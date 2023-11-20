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
///-- Description:	<Description,Table :[crm_customer], Information layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [crm_customer] Information layer
    /// </summary>
    public class Crm_customerInfos:Collection<Crm_customer>{}
    public class Crm_customerInfo: Crm_customerInfoDLL{
        
        #region Constructor
        
        public Crm_customerInfo() : base(){
        }
        ~Crm_customerInfo(){
            base.Release();
        }
        #endregion
        
        
    }
}


