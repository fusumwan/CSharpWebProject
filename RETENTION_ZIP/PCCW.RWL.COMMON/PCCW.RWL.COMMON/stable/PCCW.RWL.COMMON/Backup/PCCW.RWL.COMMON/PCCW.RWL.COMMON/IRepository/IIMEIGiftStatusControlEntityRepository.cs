using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IIMEIGiftStatusControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IIMEIGiftStatusControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetCreate_Date();
        string GetToday1();
        string GetOrder_id();
        string GetReferenceNo();
        string GetToday();
        string GetKit_Code();
        string GetAment_Date();
        string GetImei_no();
        string GetDummy4();
        string GetIMEI();
        string GetModel();
        string GetSku();
        string GetGetDummy1();
        string GetDummy3();
        string GetUid();
        string GetStock_In_Date();
        string GetDummy1();
        string GetDummy2();
        string GetStatus();
        bool SetCreate_Date(string value);
        bool SetToday1(string value);
        bool SetOrder_id(string value);
        bool SetReferenceNo(string value);
        bool SetToday(string value);
        bool SetKit_Code(string value);
        bool SetAment_Date(string value);
        bool SetImei_no(string value);
        bool SetDummy4(string value);
        bool SetIMEI(string value);
        bool SetModel(string value);
        bool SetSku(string value);
        bool SetGetDummy1(string value);
        bool SetDummy3(string value);
        bool SetUid(string value);
        bool SetStock_In_Date(string value);
        bool SetDummy1(string value);
        bool SetDummy2(string value);
        bool SetStatus(string value);
        #endregion
        void Release();

    }
}
