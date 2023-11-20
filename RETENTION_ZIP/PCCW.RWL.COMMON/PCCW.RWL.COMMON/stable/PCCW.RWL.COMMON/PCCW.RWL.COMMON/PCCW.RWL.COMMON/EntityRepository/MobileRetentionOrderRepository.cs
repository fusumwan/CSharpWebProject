using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
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
///-- Create date: <Create Date 2009-04-02>
///-- Description:	<Description,Table :[MobileRetentionOrder],Insert / list / delete  manager layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileRetentionOrder] Insert / list / delete manager layer
    /// </summary>
    public class MobileRetentionOrderRepository : MobileRetentionOrderRepositoryBase
    {
        public MobileRetentionOrderRepository(MSSQLConnect x_oDB) : base(x_oDB)
        {
            //
            // TODO: Add constructor logic here
            //
        }
        ~MobileRetentionOrderRepository()
        {
        }

        /*
        
        DECLARE @LAST_ID INT
        SET @LAST_ID=(SELECT MAX(order_id) FROM MobileRetentionOrder)
        DBCC checkident('MobileRetentionOrder', reseed, @LAST_ID)  
        
       */

    }
}


