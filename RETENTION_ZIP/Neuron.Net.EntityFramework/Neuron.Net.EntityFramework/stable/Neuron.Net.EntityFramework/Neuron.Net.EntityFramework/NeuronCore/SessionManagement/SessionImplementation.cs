using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-07-03>
///-- Description:	<SessionImplementation Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY
{

    public class SessionImplementation<T> : ISession<T>, IDisposable
    {
        private T n_oDBTypeConn = default(T);
        public T DBTypeConn
        {
            get
            {
                return n_oDBTypeConn;
            }
            set
            {
                n_oDBTypeConn = value;
            }
        }
        private ITransaction n_oTransaction = new TransactionImplementation();
        public ITransaction Transaction
        {
            get
            {
                return n_oTransaction;
            }
        }
        public SessionImplementation()
        {
            n_oDBTypeConn = SYSConn<T>.Connect();
        }
        ~SessionImplementation()
        {
            this.Dispose();
        }
        public void Open()
        {
            n_oDBTypeConn = ISessionOpen(n_oDBTypeConn);
        }
        protected T ISessionOpen(object x_oObj)
        {
            if (n_oDBTypeConn is MSSQLConnect && typeof(T) == typeof(MSSQLConnect))
            {
                ((MSSQLConnect)x_oObj).ISessionConn = ((MSSQLConnect)x_oObj).GetConnection();

                return (T)x_oObj;
            }
            if (n_oDBTypeConn is ODBCConnect && typeof(T) == typeof(ODBCConnect))
            {
                ((ODBCConnect)x_oObj).ISessionConn = ((ODBCConnect)x_oObj).GetConnection();

                return (T)x_oObj;
            }
            if (n_oDBTypeConn is OLEDBConnect && typeof(T) == typeof(ODBCConnect))
            {
                ((OLEDBConnect)x_oObj).ISessionConn = ((OLEDBConnect)x_oObj).GetConnection();
                return (T)x_oObj;
            }
            if (n_oDBTypeConn is ORACLEConnect && typeof(T) == typeof(ORACLEConnect))
            {
                ((ORACLEConnect)x_oObj).ISessionConn = ((ORACLEConnect)x_oObj).GetConnection();
                return (T)x_oObj;
            }
            return (T)x_oObj;
        }
        public void Close()
        {
            n_oDBTypeConn = ISessionClose(n_oDBTypeConn);
        }
        protected T ISessionClose(object x_oObj)
        {
            if (x_oObj is MSSQLConnect && typeof(T) == typeof(MSSQLConnect))
            {
                MSSQLConnect _oObj = (MSSQLConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.ISessionConn.Close();
                    _oObj.ISessionConn.Dispose();
                }
                return (T)x_oObj;
            }
            if (x_oObj is ODBCConnect && typeof(T) == typeof(ODBCConnect))
            {
                ODBCConnect _oObj = (ODBCConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.ISessionConn.Close();
                    _oObj.ISessionConn.Dispose();
                }
                return (T)x_oObj;
            }
            if (x_oObj is OLEDBConnect && typeof(T) == typeof(OLEDBConnect))
            {
                OLEDBConnect _oObj = (OLEDBConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.ISessionConn.Close();
                    _oObj.ISessionConn.Dispose();
                }
                return (T)x_oObj;
            }
            if (x_oObj is ORACLEConnect && typeof(T) == typeof(ORACLEConnect))
            {
                ORACLEConnect _oObj = (ORACLEConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.ISessionConn.Close();
                    _oObj.ISessionConn.Dispose();
                }
                return (T)x_oObj;
            }
            return (T)x_oObj;
        }
        public ITransaction BeginTransaction()
        {
            return ISessionBeginTransaction(n_oDBTypeConn);
        }
        protected ITransaction ISessionBeginTransaction(object x_oObj)
        {
            if (x_oObj is MSSQLConnect && typeof(T) == typeof(MSSQLConnect))
            {
                MSSQLConnect _oObj = (MSSQLConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.bTransaction = true;
                    _oObj.ISessionCmd = _oObj.ISessionConn.CreateCommand();
                    Transaction.Begin(_oObj.ISessionConn);
                    _oObj.ISessionCmd.Connection = _oObj.ISessionConn;
                    _oObj.ISessionCmd.Transaction = Transaction.SqlTransaction;
                    return Transaction;
                }
            }
            if (x_oObj is ODBCConnect && typeof(T) == typeof(ODBCConnect))
            {
                ODBCConnect _oObj = (ODBCConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.bTransaction = true;
                    _oObj.ISessionCmd = _oObj.ISessionConn.CreateCommand();
                    Transaction.Begin(_oObj.ISessionConn);
                    _oObj.ISessionCmd.Connection = _oObj.ISessionConn;
                    _oObj.ISessionCmd.Transaction = Transaction.OdbcTransaction;
                    return Transaction;
                }
            }
            if (x_oObj is OLEDBConnect && typeof(T) == typeof(OLEDBConnect))
            {
                OLEDBConnect _oObj = (OLEDBConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.bTransaction = true;
                    _oObj.ISessionCmd = _oObj.ISessionConn.CreateCommand();
                    Transaction.Begin(_oObj.ISessionConn);
                    _oObj.ISessionCmd.Connection = _oObj.ISessionConn;
                    _oObj.ISessionCmd.Transaction = Transaction.OleDbTransaction;
                    return Transaction;
                }
            }
            if (x_oObj is ORACLEConnect && typeof(T) == typeof(ORACLEConnect))
            {
                ORACLEConnect _oObj = (ORACLEConnect)x_oObj;
                if (_oObj.ISessionConn != null)
                {
                    _oObj.bTransaction = true;
                    _oObj.ISessionCmd = _oObj.ISessionConn.CreateCommand();
                    Transaction.Begin(_oObj.ISessionConn);
                    _oObj.ISessionCmd.Connection = _oObj.ISessionConn;
                    _oObj.ISessionCmd.Transaction = Transaction.OracleTransaction;
                    return Transaction;
                }
            }
            return Transaction;
        }
        public global::System.Data.DataSet Select(string x_sQuery)
        {
            if (typeof(T) == typeof(MSSQLConnect))
            {
                return SYSConn<MSSQLConnect>.Connect().GetDS(x_sQuery);
            }
            if (typeof(T) == typeof(ODBCConnect))
            {
                return SYSConn<ODBCConnect>.Connect().GetDS(x_sQuery);
            }
            if (typeof(T) == typeof(ORACLEConnect))
            {
                return SYSConn<ORACLEConnect>.Connect().GetDS(x_sQuery);
            }
            if (typeof(T) == typeof(OLEDBConnect))
            {
                return SYSConn<OLEDBConnect>.Connect().GetDS(x_sQuery);
            }
            return new global::System.Data.DataSet();
        }
        public bool Delete(object x_oObj)
        {
            return ISessionDelete(x_oObj, n_oDBTypeConn);
        }
        protected bool ISessionDelete(object x_oObj, object x_oDBTypeConn)
        {
            try
            {

                if (x_oDBTypeConn is MSSQLConnect && typeof(T) == typeof(MSSQLConnect))
                {
                    IEntity<MSSQLConnect> _oObj = (IEntity<MSSQLConnect>)x_oObj;
                    MSSQLConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((MSSQLConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Delete();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
                if (x_oDBTypeConn is ODBCConnect && typeof(T) == typeof(ODBCConnect))
                {
                    IEntity<ODBCConnect> _oObj = (IEntity<ODBCConnect>)x_oObj;
                    ODBCConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((ODBCConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Delete();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
                if (x_oDBTypeConn is OLEDBConnect && typeof(T) == typeof(OLEDBConnect))
                {
                    IEntity<OLEDBConnect> _oObj = (IEntity<OLEDBConnect>)x_oObj;
                    OLEDBConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((OLEDBConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Delete();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
                if (x_oDBTypeConn is ORACLEConnect && typeof(T) == typeof(ORACLEConnect))
                {
                    IEntity<ORACLEConnect> _oObj = (IEntity<ORACLEConnect>)x_oObj;
                    ORACLEConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((ORACLEConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Delete();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
            }

            return false;
        }
        public bool Delete(string x_sQuery)
        {
            if (typeof(T) == typeof(MSSQLConnect))
            {
                return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(ODBCConnect))
            {
                return SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(OLEDBConnect))
            {
                return SYSConn<OLEDBConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(ORACLEConnect))
            {
                return SYSConn<ORACLEConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            return false;
        }
        public bool Update(object x_oObj)
        {
            return ISessionUpdate(x_oObj, n_oDBTypeConn);
        }
        protected bool ISessionUpdate(object x_oObj, object x_oDBTypeConn)
        {
            try
            {
                if (x_oDBTypeConn is MSSQLConnect && typeof(T) == typeof(MSSQLConnect))
                {
                    IEntity<MSSQLConnect> _oObj = (IEntity<MSSQLConnect>)x_oObj;
                    MSSQLConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((MSSQLConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Save();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
                if (x_oDBTypeConn is ODBCConnect && typeof(T) == typeof(ODBCConnect))
                {
                    IEntity<ODBCConnect> _oObj = (IEntity<ODBCConnect>)x_oObj;
                    ODBCConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((ODBCConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Save();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
                if (x_oDBTypeConn is OLEDBConnect && typeof(T) == typeof(OLEDBConnect))
                {
                    IEntity<OLEDBConnect> _oObj = (IEntity<OLEDBConnect>)x_oObj;
                    OLEDBConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((OLEDBConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Save();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
                if (x_oDBTypeConn is ORACLEConnect && typeof(T) == typeof(ORACLEConnect))
                {
                    IEntity<ORACLEConnect> _oObj = (IEntity<ORACLEConnect>)x_oObj;
                    ORACLEConnect _oTempDB = _oObj.GetDB();
                    _oObj.SetDB((ORACLEConnect)x_oDBTypeConn);
                    bool _bFlag = _oObj.Save();
                    _oObj.SetDB(_oTempDB);
                    return _bFlag;
                }
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
            }
            return false;
        }
        public bool Update(string x_sQuery)
        {
            if (typeof(T) == typeof(MSSQLConnect))
            {
                return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(ODBCConnect))
            {
                return SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(OLEDBConnect))
            {
                return SYSConn<OLEDBConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(ORACLEConnect))
            {
                return SYSConn<ORACLEConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            return false;
        }
        public bool Insert(object x_oObj)
        {
            return ISessionInsert(x_oObj, n_oDBTypeConn);
        }
        public bool ISessionInsert(object x_oObj, object x_oDBTypeConn)
        {
            try
            {
                return ((IEntityRepository)(((IEntity<T>)x_oObj).GetRepositoryObject(x_oObj))).InsertEntity(x_oObj, x_oDBTypeConn);
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
                return false;
            }
        }
        public int InsertReturnID(object x_oObj, bool x_oUseSP)
        {
            return ISessionInsertReturnID(x_oObj, x_oUseSP, n_oDBTypeConn);
        }
        public int ISessionInsertReturnID(object x_oObj, bool x_oUseSP, object x_oDBTypeConn)
        {
            try
            {
                if (x_oUseSP)
                    return ((IEntityRepository)(((IEntity<T>)x_oObj).GetRepositoryObject(x_oObj))).InsertEntityReturnLastID_SP(x_oObj, x_oDBTypeConn);
                else
                    return ((IEntityRepository)(((IEntity<T>)x_oObj).GetRepositoryObject(x_oObj))).InsertEntityReturnLastID(x_oObj, x_oDBTypeConn);
            }
            catch (Exception exp)
            {
                string error = exp.ToString();
            }
            return -1;
        }
        public bool Insert(string x_sQuery)
        {
            if (typeof(T) == typeof(MSSQLConnect))
            {
                return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(ODBCConnect))
            {
                return SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(OLEDBConnect))
            {
                return SYSConn<OLEDBConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            if (typeof(T) == typeof(ORACLEConnect))
            {
                return SYSConn<ORACLEConnect>.Connect().ExplicitNonQuery(x_sQuery);
            }
            return false;
        }
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
            n_oDBTypeConn = ISessionDispose(n_oDBTypeConn);
        }
        protected T ISessionDispose(object x_oObj)
        {
            if (x_oObj is MSSQLConnect)
            {
                MSSQLConnect _oObj = (MSSQLConnect)x_oObj;
                if (_oObj.ISessionCmd != null) _oObj.ISessionCmd.Dispose();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Close();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Dispose();
                _oObj.ISessionCmd = null;
                _oObj.ISessionConn = null;
                return (T)x_oObj;
            }
            if (x_oObj is ODBCConnect)
            {
                ODBCConnect _oObj = (ODBCConnect)x_oObj;
                if (_oObj.ISessionCmd != null) _oObj.ISessionCmd.Dispose();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Close();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Dispose();
                _oObj.ISessionCmd = null;
                _oObj.ISessionConn = null;
                return (T)x_oObj;
            }
            if (x_oObj is OLEDBConnect)
            {
                OLEDBConnect _oObj = (OLEDBConnect)x_oObj;
                if (_oObj.ISessionCmd != null) _oObj.ISessionCmd.Dispose();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Close();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Dispose();
                _oObj.ISessionCmd = null;
                _oObj.ISessionConn = null;
                return (T)x_oObj;
            }
            if (x_oObj is ORACLEConnect)
            {
                ORACLEConnect _oObj = (ORACLEConnect)x_oObj;
                if (_oObj.ISessionCmd != null) _oObj.ISessionCmd.Dispose();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Close();
                if (_oObj.ISessionConn != null) _oObj.ISessionConn.Dispose();
                _oObj.ISessionCmd = null;
                _oObj.ISessionConn = null;
                return (T)x_oObj;
            }
            return (T)x_oObj;
        }
    }

}

