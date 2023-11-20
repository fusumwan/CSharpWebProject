using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<SessionFactory Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by PHILIP FU in 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY{
    
    public class SessionFactory<T> : ISessionFactory<T>, IDisposable
    {
        public ISession<T> OpenSession()
        {
            ISession<T> _oISession = new SessionImplementation<T>();
            _oISession .Open();
            return _oISession ;
        }
        public void Close()
        {
        }
        void global::System.IDisposable.Dispose() { }
        public void Dispose() { }
    }
    
}

