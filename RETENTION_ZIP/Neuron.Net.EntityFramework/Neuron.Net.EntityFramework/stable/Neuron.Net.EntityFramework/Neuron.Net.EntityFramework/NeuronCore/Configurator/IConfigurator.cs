using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-07-03>
///-- Description:	<IConfigurator Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                        	 This class is a web application configuration class. 
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK
{
    public interface IConfigurator : IDisposable
    {
        string MSSQLConnName { get; set; }
        string ODBCConnName { get; set; }
        string ORACLEConnName { get; set; }
        string OLEDBConnName { get; set; }
        #region Get & Set

        string DBConnStr(string x_sDBName);
        string AddTablePrefix(Type x_sDBType, string x_sTableName);
        #endregion
        void Release();
    }
}

