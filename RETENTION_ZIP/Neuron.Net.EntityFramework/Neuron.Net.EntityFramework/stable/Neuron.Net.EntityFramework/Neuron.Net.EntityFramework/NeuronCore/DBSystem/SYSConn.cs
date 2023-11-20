using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<SYSConn Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.CONNECT{
    
    public class SYSConn<T>
    {
        public SYSConn(){}
        
        public static T Connect(){ return ConnectC(string.Empty);}
        public static T Connect(string x_sDBCh){return ConnectC(x_sDBCh);}
        private static T ConnectC(string x_sDBCh)
        {
            if (typeof(T) == typeof(MSSQLConnect) || typeof(T) == typeof(MSSQLConn)) return (T)ConnMSSQL(x_sDBCh);
            if (typeof(T) == typeof(ODBCConnect) || typeof(T) == typeof(ODBCConn)) return (T)ConnODBC(x_sDBCh);
            if (typeof(T) == typeof(OLEDBConnect) || typeof(T) == typeof(OLEDBConn)) return (T)ConnOLEDB(x_sDBCh);
            if (typeof(T) == typeof(ORACLEConnect) || typeof(T) == typeof(ORACLEConn)) return (T)ConnORACLE(x_sDBCh);
            return (T)ConnMSSQL(x_sDBCh);
        }
        private static object ConnMSSQL(string x_sDBCh)
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            if (x_sDBCh.Trim().Equals(string.Empty) && ConfigEntity.Instance().GetConfigurator() != null) x_sDBCh = ConfigEntity.Instance().GetConfigurator().MSSQLConnName;
            _oDB.SetConnStr(DBConnHelper.DBTypeStr(x_sDBCh));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        private static object ConnODBC(string x_sDBCh)
        {
            ODBCConnect _oDB = new ODBCConnect();
            if (x_sDBCh.Trim().Equals(string.Empty) && ConfigEntity.Instance().GetConfigurator() != null) x_sDBCh = ConfigEntity.Instance().GetConfigurator().ODBCConnName;
            _oDB.SetConnStr(DBConnHelper.DBTypeStr(x_sDBCh));
            return _oDB;
        }
        private static object ConnOLEDB(string x_sDBCh)
        {
            OLEDBConnect _oDB = new OLEDBConnect();
            if (x_sDBCh.Trim().Equals(string.Empty) && ConfigEntity.Instance().GetConfigurator() != null) x_sDBCh = ConfigEntity.Instance().GetConfigurator().OLEDBConnName;
            _oDB.SetConnStr(DBConnHelper.DBTypeStr(x_sDBCh));
            return _oDB;
        }
        private static object ConnORACLE(string x_sDBCh)
        {
            ORACLEConnect _oDB = new ORACLEConnect();
            if (x_sDBCh.Trim().Equals(string.Empty) && ConfigEntity.Instance().GetConfigurator() != null) x_sDBCh = ConfigEntity.Instance().GetConfigurator().ORACLEConnName;
            _oDB.SetConnStr(DBConnHelper.DBTypeStr(x_sDBCh));
            return _oDB;
        }
    }
    
}

