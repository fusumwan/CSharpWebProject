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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-08>
///-- Description:	<Description,Table :[Accessory],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [Accessory] Object Base layer
    /// </summary>
    public class Accessorys:Collection<Accessory>{}
    public class Accessory: AccessoryEntity{
        
        #region Constructor
        
        public Accessory() : base(){
        }
        public Accessory(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public Accessory(MSSQLConnect x_oDB,System.Nullable<int> x_iMid) : base(x_oDB,x_iMid) {
        }
        
        ~Accessory(){
            base.Release();
        }
        #endregion
        
        
    }
}


