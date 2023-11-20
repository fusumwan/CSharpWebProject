using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-12>
///-- Description:	<Description,Class :IDayCountFlagControlEntityRepository, Data Repository Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public interface IDayCountFlagControlEntityRepository<T> : IDisposable
    {
        #region Get & Set
        string GetLog_year();
        string GetLog_day2();
        int GetCheckday();
        string GetLog_month();
        System.Nullable<DateTime> GetLog_date();
        string GetLog_year2();
        System.Nullable<DateTime> GetLog_date2();
        string GetLog_day();
        int GetDay_flag();
        int GetCheckmonth();
        string GetLog_month2();
        int GetMonth_flag();
        bool SetLog_year(string value);
        bool SetLog_day2(string value);
        bool SetCheckday(int value);
        bool SetLog_month(string value);
        bool SetLog_date(global::System.Nullable<DateTime> value);
        bool SetLog_year2(string value);
        bool SetLog_date2(global::System.Nullable<DateTime> value);
        bool SetLog_day(string value);
        bool SetDay_flag(int value);
        bool SetCheckmonth(int value);
        bool SetLog_month2(string value);
        bool SetMonth_flag(int value);
        #endregion
        void Release();
        T DeepClone();

    }
}
