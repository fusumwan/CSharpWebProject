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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<TransactionImplementation Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY{
    
    public class TransactionImplementation : ITransaction, IDisposable
    {
        public SqlTransaction SqlTransaction { get; set; }
        public OdbcTransaction OdbcTransaction { get; set; }
        public OleDbTransaction OleDbTransaction { get; set; }
        public OracleTransaction OracleTransaction { get; set; }
        private bool n_bIsActive = false;
        public bool IsActive
        {
            get
            {
                return n_bIsActive;
            }
        }
        private bool n_bWasCommitted = false;
        public bool WasCommitted
        {
            get
            {
                return n_bWasCommitted;
            }
        }
        private bool n_bWasRolledBack = false;
        public bool WasRolledBack
        {
            get
            {
                return n_bWasRolledBack;
            }
        }
        public TransactionImplementation()
        {
            this.TransactionRelease();
        }
        public void Begin(Object x_oConn)
        {
            this.TransactionRelease();
            n_bIsActive = true;
            if (x_oConn is global::System.Data.SqlClient.SqlConnection)
            {
                ((global::System.Data.SqlClient.SqlConnection)x_oConn).Open();
                SqlTransaction = ((global::System.Data.SqlClient.SqlConnection)x_oConn).BeginTransaction();
                return;
            }
            if (x_oConn is global::System.Data.Odbc.OdbcConnection)
            {
                ((global::System.Data.Odbc.OdbcConnection)x_oConn).Open();
                OdbcTransaction = ((global::System.Data.Odbc.OdbcConnection)x_oConn).BeginTransaction();
                return;
            }
            if (x_oConn is global::System.Data.OleDb.OleDbConnection)
            {
                ((global::System.Data.OleDb.OleDbConnection)x_oConn).Open();
                OleDbTransaction = ((global::System.Data.OleDb.OleDbConnection)x_oConn).BeginTransaction();
                return;
            }
            if (x_oConn is global::System.Data.OracleClient.OracleConnection)
            {
                ((global::System.Data.OracleClient.OracleConnection)x_oConn).Open();
                OracleTransaction = ((global::System.Data.OracleClient.OracleConnection)x_oConn).BeginTransaction();
                return;
            }
            n_bIsActive = false;
        }
        protected void TransactionRelease()
        {
            if (this.SqlTransaction != null)
            {
                this.SqlTransaction.Dispose();
                this.SqlTransaction = null;
            }
            if (this.OdbcTransaction != null)
            {
                this.OdbcTransaction.Dispose();
                this.OdbcTransaction = null;
            }
            if (this.OleDbTransaction != null)
            {
                this.OleDbTransaction.Dispose();
                this.OleDbTransaction = null;
            }
            if (this.OracleTransaction != null)
            {
                this.OracleTransaction.Dispose();
                this.OracleTransaction = null;
            }
        }
        public void Commit()
        {
            n_bWasCommitted = true;
            if (this.SqlTransaction != null) { SqlTransaction.Commit(); }
            if (this.OdbcTransaction != null) { OdbcTransaction.Commit(); }
            if (this.OleDbTransaction != null) { OleDbTransaction.Commit(); }
            if (this.OracleTransaction != null) { OracleTransaction.Commit(); }
        }
        public void Rollback()
        {
            n_bWasRolledBack = true;
            if (this.SqlTransaction != null) { SqlTransaction.Rollback(); }
            if (this.OdbcTransaction != null) { OdbcTransaction.Rollback(); }
            if (this.OleDbTransaction != null) { OleDbTransaction.Rollback(); }
            if (this.OracleTransaction != null) { OracleTransaction.Rollback(); }
        }
        void global::System.IDisposable.Dispose() {
            this.Dispose();
        }
        public void Dispose()
        {
            n_bIsActive = false;
            n_bWasCommitted = false;
            n_bWasRolledBack = false;
            if (this.SqlTransaction != null) { SqlTransaction.Dispose(); }
            if (this.OdbcTransaction != null) { OdbcTransaction.Dispose(); }
            if (this.OleDbTransaction != null) { OleDbTransaction.Dispose(); }
            if (this.OracleTransaction != null) { OracleTransaction.Dispose(); }
            TransactionRelease();
        }
    }
    
}

