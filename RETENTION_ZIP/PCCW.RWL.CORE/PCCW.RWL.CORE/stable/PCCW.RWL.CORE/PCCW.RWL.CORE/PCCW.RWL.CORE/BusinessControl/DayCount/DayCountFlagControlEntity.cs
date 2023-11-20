using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-12>
///-- Description:	<Description,Class :DayCountFlagControlEntity, Data Entity>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class DayCountFlagControlEntity
    {
        protected string n_sLog_year = string.Empty;
        #region m_sLog_year
        public virtual string m_sLog_year
        {
            get
            {
                return this.n_sLog_year;
            }
            set
            {
                this.n_sLog_year = value;
            }
        }
        #endregion m_sLog_year


        protected string n_sLog_day2 = string.Empty;
        #region m_sLog_day2
        public virtual string m_sLog_day2
        {
            get
            {
                return this.n_sLog_day2;
            }
            set
            {
                this.n_sLog_day2 = value;
            }
        }
        #endregion m_sLog_day2


        protected int n_iCheckday = -1;
        #region m_iCheckday
        public virtual int m_iCheckday
        {
            get
            {
                return this.n_iCheckday;
            }
            set
            {
                this.n_iCheckday = value;
            }
        }
        #endregion m_iCheckday


        protected string n_sLog_month = string.Empty;
        #region m_sLog_month
        public virtual string m_sLog_month
        {
            get
            {
                return this.n_sLog_month;
            }
            set
            {
                this.n_sLog_month = value;
            }
        }
        #endregion m_sLog_month


        protected global::System.Nullable<DateTime> n_dLog_date = null;
        #region m_dLog_date
        public virtual System.Nullable<DateTime> m_dLog_date
        {
            get
            {
                return this.n_dLog_date;
            }
            set
            {
                this.n_dLog_date = value;
            }
        }
        #endregion m_dLog_date


        protected string n_sLog_year2 = string.Empty;
        #region m_sLog_year2
        public virtual string m_sLog_year2
        {
            get
            {
                return this.n_sLog_year2;
            }
            set
            {
                this.n_sLog_year2 = value;
            }
        }
        #endregion m_sLog_year2


        protected global::System.Nullable<DateTime> n_dLog_date2 = null;
        #region m_dLog_date2
        public virtual System.Nullable<DateTime> m_dLog_date2
        {
            get
            {
                return this.n_dLog_date2;
            }
            set
            {
                this.n_dLog_date2 = value;
            }
        }
        #endregion m_dLog_date2


        protected string n_sLog_day = string.Empty;
        #region m_sLog_day
        public virtual string m_sLog_day
        {
            get
            {
                return this.n_sLog_day;
            }
            set
            {
                this.n_sLog_day = value;
            }
        }
        #endregion m_sLog_day


        protected int n_iDay_flag = -1;
        #region m_iDay_flag
        public virtual int m_iDay_flag
        {
            get
            {
                return this.n_iDay_flag;
            }
            set
            {
                this.n_iDay_flag = value;
            }
        }
        #endregion m_iDay_flag


        protected int n_iCheckmonth = -1;
        #region m_iCheckmonth
        public virtual int m_iCheckmonth
        {
            get
            {
                return this.n_iCheckmonth;
            }
            set
            {
                this.n_iCheckmonth = value;
            }
        }
        #endregion m_iCheckmonth


        protected string n_sLog_month2 = string.Empty;
        #region m_sLog_month2
        public virtual string m_sLog_month2
        {
            get
            {
                return this.n_sLog_month2;
            }
            set
            {
                this.n_sLog_month2 = value;
            }
        }
        #endregion m_sLog_month2


        protected int n_iMonth_flag = -1;
        #region m_iMonth_flag
        public virtual int m_iMonth_flag
        {
            get
            {
                return this.n_iMonth_flag;
            }
            set
            {
                this.n_iMonth_flag = value;
            }
        }
        #endregion m_iMonth_flag

    }
}
