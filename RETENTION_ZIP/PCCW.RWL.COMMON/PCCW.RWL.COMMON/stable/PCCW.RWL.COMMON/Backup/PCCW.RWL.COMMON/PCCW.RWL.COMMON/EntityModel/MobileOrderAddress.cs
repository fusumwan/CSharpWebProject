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
///-- Create date: <Create Date 2010-10-15>
///-- Description:	<Description,Table :[MobileOrderAddress],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [MobileOrderAddress] Object Base layer
    /// </summary>
    public class MobileOrderAddresss:Collection<MobileOrderAddress>{}
    public class MobileOrderAddress: MobileOrderAddressEntity{
        
        #region Constructor
        
        public MobileOrderAddress() : base(){
        }
        public MobileOrderAddress(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public MobileOrderAddress(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type) : base(x_oDB,x_iOrder_id,x_sAddress_type) {
        }
        
        public MobileOrderAddress(MSSQLConnect x_oDB,global::System.Nullable<long> x_lAddress_id) : base(x_oDB,x_lAddress_id) {
        }
        
        ~MobileOrderAddress(){
            base.Release();
        }
        #endregion
        
        
    }
}


