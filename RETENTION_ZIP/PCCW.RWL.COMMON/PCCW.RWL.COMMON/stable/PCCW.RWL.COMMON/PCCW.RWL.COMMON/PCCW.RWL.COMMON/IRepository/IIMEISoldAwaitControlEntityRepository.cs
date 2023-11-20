using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IIMEISoldAwaitControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IIMEISoldAwaitControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetHs_model();
        string GetToday1();
        string GetToday();
        string GetOrder_id();
        string GetStaff_no();
        string GetAment_Date();
        string GetImei_no();
        string GetEdf_no();
        string GetSku();
        string GetUid();
        bool SetHs_model(string value);
        bool SetToday1(string value);
        bool SetToday(string value);
        bool SetOrder_id(string value);
        bool SetStaff_no(string value);
        bool SetAment_Date(string value);
        bool SetImei_no(string value);
        bool SetEdf_no(string value);
        bool SetSku(string value);
        bool SetUid(string value);
        #endregion
        void Release();

    }
}
