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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[BusinessVasDescription],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [BusinessVasDescription] Object Base layer
    /// </summary>
    public class BusinessVasDescriptions:Collection<BusinessVasDescription>{}
    public class BusinessVasDescription: BusinessVasDescriptionEntity{
        
        #region Constructor
        
        public BusinessVasDescription() : base(){
        }
        public BusinessVasDescription(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public BusinessVasDescription(MSSQLConnect x_oDB,System.Nullable<int> x_iId) : base(x_oDB,x_iId) {
        }
        
        ~BusinessVasDescription(){
            base.Release();
        }
        #endregion
        
        
    }
}

