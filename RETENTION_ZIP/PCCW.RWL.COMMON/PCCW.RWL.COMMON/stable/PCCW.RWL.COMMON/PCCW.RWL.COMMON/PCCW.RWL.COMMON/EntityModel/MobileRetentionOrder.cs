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
///-- Create date: <Create Date 2010-10-15>
///-- Description:	<Description,Table :[MobileRetentionOrder],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [MobileRetentionOrder] Object Base layer
    /// </summary>
    public class MobileRetentionOrders:Collection<MobileRetentionOrder>{}
    public class MobileRetentionOrder: MobileRetentionOrderEntity{
        
        #region Constructor
        
        public MobileRetentionOrder() : base(){
        }
        public MobileRetentionOrder(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public MobileRetentionOrder(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id) : base(x_oDB,x_iOrder_id) {
        }
        
        ~MobileRetentionOrder(){
            base.Release();
        }

        public string GetCustomerName()
        {
            if (!this.GetFamily_name().Trim().Equals(string.Empty) || 
                !this.GetGiven_name().Trim().Equals(string.Empty))
            {
                return (this.GetFamily_name().Trim() + " " + this.GetGiven_name().Trim()).Trim();
            }
            return this.GetCust_name().Trim();
        }

        public static string GetCustomerName(MobileRetentionOrderEntity x_oMobileRetentionOrder)
        {

            if (!x_oMobileRetentionOrder.GetFamily_name().Trim().Equals(string.Empty) ||
                !x_oMobileRetentionOrder.GetGiven_name().Trim().Equals(string.Empty))
            {
                return (x_oMobileRetentionOrder.GetFamily_name().Trim() + " " + x_oMobileRetentionOrder.GetGiven_name().Trim()).Trim();
            }
            return x_oMobileRetentionOrder.GetCust_name().Trim();
        }


        #endregion
        
        
    }
}


