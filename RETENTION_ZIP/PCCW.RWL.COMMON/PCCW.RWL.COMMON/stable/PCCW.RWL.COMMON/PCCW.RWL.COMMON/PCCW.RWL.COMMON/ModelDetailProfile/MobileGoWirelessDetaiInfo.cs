using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
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
///-- Create date: <Create Date 2009-06-01>
///-- Description:	<Description,Table :[MobileGoWirelessDetail], Information layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileGoWirelessDetail] Information layer
    /// </summary>
    public class MobileGoWirelessDetailInfos:Collection<MobileGoWirelessDetail>{}
    public class MobileGoWirelessDetailInfo: MobileGoWirelessDetailInfoDLL{
        
        #region Constructor
        
        public MobileGoWirelessDetailInfo() : base(){
        }
        ~MobileGoWirelessDetailInfo(){
            base.Release();
        }
        #endregion
        
        
    }
}


