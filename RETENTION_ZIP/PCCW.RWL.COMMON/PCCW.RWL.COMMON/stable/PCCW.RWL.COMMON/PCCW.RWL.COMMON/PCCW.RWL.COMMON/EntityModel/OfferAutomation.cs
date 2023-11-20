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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[OfferAutomation],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [OfferAutomation] Object Base layer
    /// </summary>
    public class OfferAutomations:Collection<OfferAutomation>{}
    public class OfferAutomation: OfferAutomationEntity{
        
        #region Constructor
        
        public OfferAutomation() : base(){
        }
        public OfferAutomation(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public OfferAutomation(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId) : base(x_oDB,x_iId) {
        }
        
        ~OfferAutomation(){
            base.Release();
        }
        #endregion
        
        
    }
}


