using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///-- =============================================
///-- Author:		<Author,Ben Wong>
///-- Create date: <Create Date 2010-08-09 Mon>
///-- Description:	<Description,Class :ISIMControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public interface ISIMControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetSim_no();
        string GetReserve();
        string GetReferenceno();
        string GetDummy1();
        string GetAssign_date();

        bool SetSim_no(string value);
        bool SetReserve(string value);
        bool SetReferenceno(string value);
        bool SetDummy1(string value);
        bool SetAssign_date(string value);
        #endregion
        void Release();
    }
}
