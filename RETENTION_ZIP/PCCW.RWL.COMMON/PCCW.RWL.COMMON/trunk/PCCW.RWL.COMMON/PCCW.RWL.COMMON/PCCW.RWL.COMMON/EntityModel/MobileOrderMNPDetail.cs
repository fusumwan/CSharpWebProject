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
///-- Create date: <Create Date 2010-10-12>
///-- Description:	<Description,Table :[MobileOrderMNPDetail],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [MobileOrderMNPDetail] Object Base layer
    /// </summary>
    public class MobileOrderMNPDetails:Collection<MobileOrderMNPDetail>{}
    public class MobileOrderMNPDetail: MobileOrderMNPDetailEntity{
        
        #region Constructor
        
        public MobileOrderMNPDetail() : base(){
        }
        public MobileOrderMNPDetail(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public MobileOrderMNPDetail(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMnp_id) : base(x_oDB,x_lMnp_id) {
        }
        
        ~MobileOrderMNPDetail(){
            base.Release();
        }
        #endregion
        
        
    }
}


