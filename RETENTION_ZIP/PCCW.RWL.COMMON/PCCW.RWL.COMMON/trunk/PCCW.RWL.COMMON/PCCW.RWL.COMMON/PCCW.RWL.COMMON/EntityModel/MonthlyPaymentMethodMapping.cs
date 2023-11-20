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
///-- Create date: <Create Date 2011-11-09>
///-- Description:	<Description,Table :[MonthlyPaymentMethodMapping],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [MonthlyPaymentMethodMapping] Object Base layer
    /// </summary>
    public class MonthlyPaymentMethodMappings:Collection<MonthlyPaymentMethodMapping>{}
    public class MonthlyPaymentMethodMapping: MonthlyPaymentMethodMappingEntity{
        
        #region Constructor
        
        public MonthlyPaymentMethodMapping() : base(){
        }
        public MonthlyPaymentMethodMapping(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public MonthlyPaymentMethodMapping(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId) : base(x_oDB,x_iId) {
        }
        
        ~MonthlyPaymentMethodMapping(){
            base.Release();
        }
        #endregion
        
        
    }
}


