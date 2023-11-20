using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-07-03>
///-- Description:	<Interface IEntity Repository Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================

namespace NEURON.ENTITY.FRAMEWORK
{

    public interface IEntityRepository : IDisposable
    {
        bool InsertEntity(object x_oObj, object x_oDB);
        int InsertEntityReturnLastID(object x_oObj, object x_oDB);
        int InsertEntityReturnLastID_SP(object x_oObj, object x_oDB);
    }

}

