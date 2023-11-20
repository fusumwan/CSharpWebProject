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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2010-06-09>
///-- Description:	<Description,Table :[MobileManualAssignedHistory], Information layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileManualAssignedHistory] Information layer
    /// </summary>
    public class MobileManualAssignedHistoryInfos:Collection<MobileManualAssignedHistory>{}
    public class MobileManualAssignedHistoryInfo: MobileManualAssignedHistoryInfoDLL{
        
        #region Constructor
        
        public MobileManualAssignedHistoryInfo() : base(){
        }
        ~MobileManualAssignedHistoryInfo(){
            base.Release();
        }
        #endregion
        
        
    }
}


