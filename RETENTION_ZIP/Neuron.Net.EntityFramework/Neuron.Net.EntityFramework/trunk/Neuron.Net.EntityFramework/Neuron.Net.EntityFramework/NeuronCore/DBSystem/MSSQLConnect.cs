using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Database Class!>
///-- =============================================

namespace NEURON.ENTITY.FRAMEWORK.CONNECT{
    public class MSSQLConnect : MSSQLConn{
        public MSSQLConnect() : base()
        {
        }
        public MSSQLConnect(string connStr) : base(connStr)
        {
        }
        public MSSQLConnect(string catalog, string source, string username, string password) : base(catalog, source, username, password){
        }
        protected override string Formatted(object o)
        {
            if (o is int)
            {
                return o.ToString();
            }
            else if (o is string)
            {
                return "'"+o.ToString()+"'";
            }
            return o.ToString();
        }
    }
}

