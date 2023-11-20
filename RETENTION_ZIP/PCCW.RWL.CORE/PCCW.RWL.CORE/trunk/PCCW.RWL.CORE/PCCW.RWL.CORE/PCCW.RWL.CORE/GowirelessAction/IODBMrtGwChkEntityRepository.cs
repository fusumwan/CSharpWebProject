using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IODBMrtGwChkEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IODBMrtGwChkEntityRepository : IDisposable
    {
        #region Get & Set
        Hashtable GetChkList();
        string GetOrg_mrt();
        bool SetChkList(Hashtable value);
        bool SetOrg_mrt(string value);
        #endregion
        void Release();

    }
}
