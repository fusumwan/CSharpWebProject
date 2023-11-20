using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.OracleClient;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Interface ISessionFactory Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by PHILIP FU in 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY{
    
    public interface ITransaction : IDisposable
    {
        SqlTransaction SqlTransaction { get; set; }
        OdbcTransaction OdbcTransaction { get; set; }
        OleDbTransaction OleDbTransaction { get; set; }
        OracleTransaction OracleTransaction { get; set; }
        bool IsActive { get; }
        bool WasCommitted { get; }
        bool WasRolledBack { get; }
        void Begin(object x_oConn);
        void Commit();
        void Rollback();
    }

}

