using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-12>
///-- Description:	<Description,Class :DayCountFlagControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class DayCountFlagControl : DayCountFlagControlEntity, IDayCountFlagControlEntityRepository<DayCountFlagControl>, IDisposable
    {

        #region Constructor & Destructor
        public DayCountFlagControl() { }

        public DayCountFlagControl(
            string x_sLog_year, string x_sLog_day2, int x_iCheckday, string x_sLog_month, 
            System.Nullable<DateTime> x_dLog_date, string x_sLog_year2, 
            System.Nullable<DateTime> x_dLog_date2, string x_sLog_day, 
            int x_iDay_flag, int x_iCheckmonth, string x_sLog_month2, int x_iMonth_flag)
        {
            m_sLog_year = x_sLog_year;
            m_sLog_day2 = x_sLog_day2;
            m_iCheckday = x_iCheckday;
            m_sLog_month = x_sLog_month;
            m_dLog_date = x_dLog_date;
            m_sLog_year2 = x_sLog_year2;
            m_dLog_date2 = x_dLog_date2;
            m_sLog_day = x_sLog_day;
            m_iDay_flag = x_iDay_flag;
            m_iCheckmonth = x_iCheckmonth;
            m_sLog_month2 = x_sLog_month2;
            m_iMonth_flag = x_iMonth_flag;
        }

        ~DayCountFlagControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetLog_year() { return this.m_sLog_year; }
        public string GetLog_day2() { return this.m_sLog_day2; }
        public int GetCheckday() { return this.m_iCheckday; }
        public string GetLog_month() { return this.m_sLog_month; }
        public global::System.Nullable<DateTime> GetLog_date() { return this.m_dLog_date; }
        public string GetLog_year2() { return this.m_sLog_year2; }
        public global::System.Nullable<DateTime> GetLog_date2() { return this.m_dLog_date2; }
        public string GetLog_day() { return this.m_sLog_day; }
        public int GetDay_flag() { return this.m_iDay_flag; }
        public int GetCheckmonth() { return this.m_iCheckmonth; }
        public string GetLog_month2() { return this.m_sLog_month2; }
        public int GetMonth_flag() { return this.m_iMonth_flag; }

        public bool SetLog_year(string value)
        {
            this.m_sLog_year = value;
            return true;
        }
        public bool SetLog_day2(string value)
        {
            this.m_sLog_day2 = value;
            return true;
        }
        public bool SetCheckday(int value)
        {
            this.m_iCheckday = value;
            return true;
        }
        public bool SetLog_month(string value)
        {
            this.m_sLog_month = value;
            return true;
        }
        public bool SetLog_date(global::System.Nullable<DateTime> value)
        {
            this.m_dLog_date = value;
            return true;
        }
        public bool SetLog_year2(string value)
        {
            this.m_sLog_year2 = value;
            return true;
        }
        public bool SetLog_date2(global::System.Nullable<DateTime> value)
        {
            this.m_dLog_date2 = value;
            return true;
        }
        public bool SetLog_day(string value)
        {
            this.m_sLog_day = value;
            return true;
        }
        public bool SetDay_flag(int value)
        {
            this.m_iDay_flag = value;
            return true;
        }
        public bool SetCheckmonth(int value)
        {
            this.m_iCheckmonth = value;
            return true;
        }
        public bool SetLog_month2(string value)
        {
            this.m_sLog_month2 = value;
            return true;
        }
        public bool SetMonth_flag(int value)
        {
            this.m_iMonth_flag = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(DayCountFlagControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sLog_year.Equals(x_oObj.m_sLog_year)) { return false; }
            if (!this.m_sLog_day2.Equals(x_oObj.m_sLog_day2)) { return false; }
            if (!this.m_iCheckday.Equals(x_oObj.m_iCheckday)) { return false; }
            if (!this.m_sLog_month.Equals(x_oObj.m_sLog_month)) { return false; }
            if (!this.m_dLog_date.Equals(x_oObj.m_dLog_date)) { return false; }
            if (!this.m_sLog_year2.Equals(x_oObj.m_sLog_year2)) { return false; }
            if (!this.m_dLog_date2.Equals(x_oObj.m_dLog_date2)) { return false; }
            if (!this.m_sLog_day.Equals(x_oObj.m_sLog_day)) { return false; }
            if (!this.m_iDay_flag.Equals(x_oObj.m_iDay_flag)) { return false; }
            if (!this.m_iCheckmonth.Equals(x_oObj.m_iCheckmonth)) { return false; }
            if (!this.m_sLog_month2.Equals(x_oObj.m_sLog_month2)) { return false; }
            if (!this.m_iMonth_flag.Equals(x_oObj.m_iMonth_flag)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_sLog_year = string.Empty;
            this.m_sLog_day2 = string.Empty;
            this.m_iCheckday = -1;
            this.m_sLog_month = string.Empty;
            this.m_dLog_date = null;
            this.m_sLog_year2 = string.Empty;
            this.m_dLog_date2 = null;
            this.m_sLog_day = string.Empty;
            this.m_iDay_flag = -1;
            this.m_iCheckmonth = -1;
            this.m_sLog_month2 = string.Empty;
            this.m_iMonth_flag = -1;
        }
        #endregion Release


        #region DeepClone
        public DayCountFlagControl DeepClone()
        {
            DayCountFlagControl DayCountFlagControl_Clone = new DayCountFlagControl();
            DayCountFlagControl_Clone.SetLog_year(this.m_sLog_year);
            DayCountFlagControl_Clone.SetLog_day2(this.m_sLog_day2);
            DayCountFlagControl_Clone.SetCheckday(this.m_iCheckday);
            DayCountFlagControl_Clone.SetLog_month(this.m_sLog_month);
            DayCountFlagControl_Clone.SetLog_date(this.m_dLog_date);
            DayCountFlagControl_Clone.SetLog_year2(this.m_sLog_year2);
            DayCountFlagControl_Clone.SetLog_date2(this.m_dLog_date2);
            DayCountFlagControl_Clone.SetLog_day(this.m_sLog_day);
            DayCountFlagControl_Clone.SetDay_flag(this.m_iDay_flag);
            DayCountFlagControl_Clone.SetCheckmonth(this.m_iCheckmonth);
            DayCountFlagControl_Clone.SetLog_month2(this.m_sLog_month2);
            DayCountFlagControl_Clone.SetMonth_flag(this.m_iMonth_flag);
            return DayCountFlagControl_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
