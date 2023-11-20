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
///-- Description:	<Description,Table :[CallListUploadMrtNo],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [CallListUploadMrtNo] Object Base layer
    /// </summary>
    public class CallListUploadMrtNos:Collection<CallListUploadMrtNo>{}
    public class CallListUploadMrtNo: CallListUploadMrtNoEntity{
        
        #region Constructor
        
        public CallListUploadMrtNo() : base(){
        }
        public CallListUploadMrtNo(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public CallListUploadMrtNo(MSSQLConnect x_oDB,global::System.Nullable<long> x_lId) : base(x_oDB,x_lId) {
        }
        
        ~CallListUploadMrtNo(){
            base.Release();
        }
        #endregion
        
        
    }
}


