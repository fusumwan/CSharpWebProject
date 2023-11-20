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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportRetrieveDetail],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [MobileOrderReportRetrieveDetail] Object Base layer
    /// </summary>
    public class MobileOrderReportRetrieveDetails:Collection<MobileOrderReportRetrieveDetail>{}
    public class MobileOrderReportRetrieveDetail: MobileOrderReportRetrieveDetailEntity{
        
        #region Constructor
        
        public MobileOrderReportRetrieveDetail() : base(){
        }
        public MobileOrderReportRetrieveDetail(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public MobileOrderReportRetrieveDetail(MSSQLConnect x_oDB,global::System.Nullable<Guid> x_gGuid_id,global::System.Nullable<bool> x_bActive) : base(x_oDB,x_gGuid_id,x_bActive) {
        }
        
        public MobileOrderReportRetrieveDetail(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId) : base(x_oDB,x_iId) {
        }
        
        ~MobileOrderReportRetrieveDetail(){
            base.Release();
        }
        #endregion
        
        
    }
}


