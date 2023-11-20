using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IRwlReportSYSControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IRwlReportSYSControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetUid();
        DateTime GetNow();
        string GetOrder_id();
        bool SetUid(string value);
        bool SetNow(DateTime value);
        bool SetOrder_id(string value);
        #endregion
        void Release();

    }
}
