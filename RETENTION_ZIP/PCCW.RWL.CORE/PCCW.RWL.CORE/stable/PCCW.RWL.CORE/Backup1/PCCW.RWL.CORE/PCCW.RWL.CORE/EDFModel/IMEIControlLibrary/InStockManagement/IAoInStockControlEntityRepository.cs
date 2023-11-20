using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Thu>
///-- Description:	<Description,Class :IAoInStockControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    interface IAoInStockControlEntityRepository : IDisposable
    {
        #region Get & Set
        string GetCreateDate();
        string GetSku();
        string GetToday();
        string GetDummy1();
        string GetDummy4();
        string GetUid();
        string GetReferenceNo();
        string GetModel();
        string GetOrder_id();
        string GetIMEI();
        string GetDummy2();
        string GetStatus();
        string GetStock_In_Date();
        string GetKit_Code();
        string GetImei_no();
        string GetAment_Date();
        string GetRefNo();
        bool SetCreateDate(string value);
        bool SetSku(string value);
        bool SetToday(string value);
        bool SetDummy1(string value);
        bool SetDummy4(string value);
        bool SetUid(string value);
        bool SetReferenceNo(string value);
        bool SetModel(string value);
        bool SetOrder_id(string value);
        bool SetIMEI(string value);
        bool SetDummy2(string value);
        bool SetStatus(string value);
        bool SetStock_In_Date(string value);
        bool SetKit_Code(string value);
        bool SetImei_no(string value);
        bool SetAment_Date(string value);
        bool SetRefNo(string value);
        #endregion
        void Release();
    }
}
