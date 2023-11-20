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
using System.Xml;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[RetentionProgramKey], Information layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [RetentionProgramKey] Information layer
    /// </summary>
    public class RetentionProgramKeyInfos:Collection<RetentionProgramKey>{}
    public class RetentionProgramKeyInfo: RetentionProgramKeyInfoDLL{
        
        #region Constructor
        
        public RetentionProgramKeyInfo() : base(){
        }
        ~RetentionProgramKeyInfo(){
            base.Release();
        }
        #endregion
        
        
    }
}


