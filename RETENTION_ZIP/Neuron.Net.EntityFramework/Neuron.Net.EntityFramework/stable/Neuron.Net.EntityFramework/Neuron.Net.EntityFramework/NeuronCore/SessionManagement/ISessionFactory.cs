using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Interface ISessionFactory Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY{
    
    public interface ISessionFactory<T> : IDisposable
    {
        ISession<T> OpenSession();
        void Close();
    }
    
}

