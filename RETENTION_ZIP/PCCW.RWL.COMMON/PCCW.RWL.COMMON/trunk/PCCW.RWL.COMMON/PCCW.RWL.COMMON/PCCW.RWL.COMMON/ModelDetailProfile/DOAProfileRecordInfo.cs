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
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Table :[DOAProfileRecord], Information layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [DOAProfileRecord] Information layer
    /// </summary>
    public class DOAProfileRecordInfos:Collection<DOAProfileRecord>{}
    public class DOAProfileRecordInfo: DOAProfileRecordInfoDLL{
        
        #region Constructor
        
        public DOAProfileRecordInfo() : base(){
        }
        ~DOAProfileRecordInfo(){
            base.Release();
        }
        #endregion
        
        
    }
}


