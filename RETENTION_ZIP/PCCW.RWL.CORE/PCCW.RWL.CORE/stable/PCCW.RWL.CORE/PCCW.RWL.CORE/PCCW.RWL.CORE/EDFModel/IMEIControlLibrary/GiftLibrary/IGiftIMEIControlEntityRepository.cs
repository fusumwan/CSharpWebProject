using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IGiftIMEIControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IGiftIMEIControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetOrd_id();
        string GetUid();
        string GetToday();
        string GetSku();
        string GetIMEI();
        string GetRef_no();
        string GetGift_desc();
        string GetEdf_no();
        bool SetOrd_id(string value);
        bool SetUid(string value);
        bool SetToday(string value);
        bool SetSku(string value);
        bool SetIMEI(string value);
        bool SetRef_no(string value);
        bool SetGift_desc(string value);
        bool SetEdf_no(string value);
        #endregion
        void Release();

    }
}
