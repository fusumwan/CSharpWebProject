using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Interface ISession Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY{
    
    public interface ISession<T> : IDisposable
    {
        T DBTypeConn { get; set; }
        ITransaction Transaction { get; }
        ITransaction BeginTransaction();
        void Open();
        void Close();
        global::System.Data.DataSet Select(string x_sQuery);
        bool Delete(object x_oObj);
        bool Delete(string x_sQuery);
        bool Update(object x_oObj);
        bool Update(string x_sQuery);
        bool Insert(object x_oObj);
        bool Insert(string x_sQuery);
        int InsertReturnID(object x_oObj, bool x_oUseSP);
    }
    
}

