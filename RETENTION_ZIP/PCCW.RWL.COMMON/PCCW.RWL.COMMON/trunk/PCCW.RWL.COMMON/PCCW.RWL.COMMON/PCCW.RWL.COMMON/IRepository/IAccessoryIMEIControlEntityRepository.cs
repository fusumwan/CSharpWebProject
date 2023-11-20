using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IAccessoryIMEIControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IAccessoryIMEIControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetOrd_id();
        string GetUid();
        string GetToday();
        string GetSku();
        string GetEdf_no();
        string GetRef_no();
        string GetIMEI();
        string GetAccessory_price();
        string GetGift_desc();
        bool SetOrd_id(string value);
        bool SetUid(string value);
        bool SetToday(string value);
        bool SetSku(string value);
        bool SetEdf_no(string value);
        bool SetRef_no(string value);
        bool SetIMEI(string value);
        bool SetAccessory_price(string value);
        bool SetGift_desc(string value);
        #endregion
        void Release();
    }
}
