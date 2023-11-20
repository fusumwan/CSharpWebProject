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
///-- Create date: <Create Date 2010-06-18>
///-- Description:	<Description,Table :[HandSetOfferType],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    /// <summary>
    /// Summary description for table [HandSetOfferType] Object Base layer
    /// </summary>
    public class HandSetOfferTypes:Collection<HandSetOfferType>{}
    public class HandSetOfferType: HandSetOfferTypeEntity{
        
        #region Constructor
        
        public HandSetOfferType() : base(){
        }
        public HandSetOfferType(MSSQLConnect x_oDB) : base(x_oDB){
        }
        
        public HandSetOfferType(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId) : base(x_oDB,x_iId) {
        }
        
        ~HandSetOfferType(){
            base.Release();
        }
        #endregion
        
        
    }
}


