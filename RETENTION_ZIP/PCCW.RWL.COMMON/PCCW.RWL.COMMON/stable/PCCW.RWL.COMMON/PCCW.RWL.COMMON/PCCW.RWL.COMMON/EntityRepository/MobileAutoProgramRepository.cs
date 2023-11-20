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
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2010-06-11>
///-- Description:	<Description,Table :[MobileAutoProgram],Insert / list / delete  manager layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileAutoProgram] Insert / list / delete manager layer
    /// </summary>
    public class MobileAutoProgramRepository : MobileAutoProgramRepositoryBase
    {
        public MobileAutoProgramRepository(MSSQLConnect x_oDB) : base(x_oDB)
        {
            //
            // TODO: Add constructor logic here
            //
        }
        ~MobileAutoProgramRepository()
        {
        }
    }
}


