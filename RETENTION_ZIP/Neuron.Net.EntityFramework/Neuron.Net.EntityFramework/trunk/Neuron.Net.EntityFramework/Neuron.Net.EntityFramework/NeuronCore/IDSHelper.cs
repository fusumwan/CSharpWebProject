using System;
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2008-06-07>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by PHILIP FU in 2008. 
///--                            This library is for Dataset reader class.
///-- =============================================

namespace NEURON.ENTITY.FRAMEWORK
{
    public interface IDSHelper
    {
        DataSet DSet { get; }
        void AddTable(string x_sTableName);
        DataTable SearchDSTable(string x_sTableName);
    }
}
