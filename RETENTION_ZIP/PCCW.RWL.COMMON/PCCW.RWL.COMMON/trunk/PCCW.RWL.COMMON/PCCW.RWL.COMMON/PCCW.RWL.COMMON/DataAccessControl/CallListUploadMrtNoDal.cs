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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadMrtNo],DataAccess layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [CallListUploadMrtNo] DataAccess layer
    /// </summary>
    
    public class CallListUploadMrtNoDals:Collection<CallListUploadMrtNo>{}
    public class CallListUploadMrtNoDal: CallListUploadMrtNoDalDAO{
        
        #region Constructor
        
        public CallListUploadMrtNoDal() : base(){
        }
        ~CallListUploadMrtNoDal(){
            base.Release();
        }
        #endregion
        
        
    }
}


