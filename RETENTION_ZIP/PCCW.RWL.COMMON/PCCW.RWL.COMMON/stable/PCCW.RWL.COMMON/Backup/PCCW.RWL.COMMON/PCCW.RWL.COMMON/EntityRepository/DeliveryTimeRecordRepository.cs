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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-04-21>
///-- Description:	<Description,Table :[DeliveryTimeRecord],Insert / list / delete  manager layer>
///-- =============================================

namespace PCCW.RWL.CORE
{
    
    /// <summary>
    /// Summary description for table [DeliveryTimeRecord] Insert / list / delete manager layer
    /// </summary>
    public class DeliveryTimeRecordRepository : DeliveryTimeRecordRepositoryBase
    {
        public DeliveryTimeRecordRepository(MSSQLConnect x_oDB) : base(x_oDB)
        {
            //
            // TODO: Add constructor logic here
            //
        }
        ~DeliveryTimeRecordRepository()
        {
        }
    }
}


