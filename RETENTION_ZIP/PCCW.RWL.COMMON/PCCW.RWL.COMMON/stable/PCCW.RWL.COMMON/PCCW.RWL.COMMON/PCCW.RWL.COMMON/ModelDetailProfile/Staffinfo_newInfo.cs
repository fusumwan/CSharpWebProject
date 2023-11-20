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
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[CSSDB].[csc].[staffinfo_new], Information layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [CSSDB].[csc].[staffinfo_new] Information layer
    /// </summary>
    public class Staffinfo_newInfos:Collection<Staffinfo_new>{}
    public class Staffinfo_newInfo: Staffinfo_newInfoDLL{
        
        #region Constructor
        
        public Staffinfo_newInfo() : base(){
        }
        ~Staffinfo_newInfo(){
            base.Release();
        }
        #endregion
        
        
    }
}


