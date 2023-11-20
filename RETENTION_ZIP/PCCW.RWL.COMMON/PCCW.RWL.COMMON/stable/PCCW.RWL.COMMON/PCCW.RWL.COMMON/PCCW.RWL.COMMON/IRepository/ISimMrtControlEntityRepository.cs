using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-Mon>
///-- Description:	<Description,Class :ISimMrtControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface ISimMrtControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetDelete();
        string GetMrt();
        string GetUid();
        int GetOrder_id();
        bool SetDelete(string value);
        bool SetMrt(string value);
        bool SetUid(string value);
        bool SetOrder_id(int value);
        string GetSimMrt();
        #endregion
        void Release();

    }
}
