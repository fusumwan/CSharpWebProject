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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2011-07-21>
///-- Description:	<Description,Table :[MobileRetentionPreviousOrder],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [MobileRetentionPreviousOrder] Object Base layer
    /// </summary>
    public class MobileRetentionPreviousOrders:Collection<MobileRetentionPreviousOrder>{}
    public class MobileRetentionPreviousOrder: MobileRetentionPreviousOrderEntity{
        
        #region Constructor
        
        public MobileRetentionPreviousOrder() : base(){
        }
        public MobileRetentionPreviousOrder(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public MobileRetentionPreviousOrder(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id) : base(x_oDB,x_iOrder_id) {
        }
        
        ~MobileRetentionPreviousOrder(){
            base.Release();
        }
        #endregion
        
        
    }
}


