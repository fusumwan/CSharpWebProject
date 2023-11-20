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
///-- Create date: <Create Date 2010-03-31>
///-- Description:	<Description,Class :FindNoEdfRecordInsert, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class FindNoEdfRecordInsert : IDisposable
    {

        protected global::System.Nullable<DateTime> n_oStartLockTime = null;
        #region StartLockTime
        protected global::System.Nullable<DateTime> StartLockTime
        {
            get
            {
                return this.n_oStartLockTime;
            }
            set
            {
                this.n_oStartLockTime = value;
            }
        }
        #endregion StartLockTime


        protected bool n_bIsLock = false;
        #region IsLock
        protected bool IsLock
        {
            get
            {
                return this.n_bIsLock;
            }
            set
            {
                this.n_bIsLock = value;
            }
        }
        #endregion IsLock


        protected EDFStatusProfile n_oEDFStatusProfileControl = null;
        #region EDFStatusProfileControl
        protected EDFStatusProfile EDFStatusProfileControl
        {
            get
            {
                return this.n_oEDFStatusProfileControl;
            }
            set
            {
                this.n_oEDFStatusProfileControl = value;
            }
        }
        #endregion EDFStatusProfileControl


        protected global::System.Nullable<DateTime> n_oEndLockTime = null;
        #region EndLockTime
        protected global::System.Nullable<DateTime> EndLockTime
        {
            get
            {
                return this.n_oEndLockTime;
            }
            set
            {
                this.n_oEndLockTime = value;
            }
        }
        #endregion EndLockTime

        #region Para
        public class Para
        {
            public const string StartLockTime = "StartLockTime";
            public const string IsLock = "IsLock";
            public const string EDFStatusProfileControl = "EDFStatusProfileControl";
            public const string EndLockTime = "EndLockTime";
        }
        #endregion Para

        #region Instance
        private static FindNoEdfRecordInsert instance;
        #endregion


        #region Constructor & Destructor
        protected FindNoEdfRecordInsert() { }

        protected FindNoEdfRecordInsert(global::System.Nullable<DateTime> x_oStartLockTime, bool x_bIsLock, EDFStatusProfile x_oEDFStatusProfileControl, global::System.Nullable<DateTime> x_oEndLockTime)
        {
            StartLockTime = x_oStartLockTime;
            IsLock = x_bIsLock;
            EDFStatusProfileControl = x_oEDFStatusProfileControl;
            EndLockTime = x_oEndLockTime;
        }

        public static FindNoEdfRecordInsert Instance()
        {
            if (instance == null)
                instance = new FindNoEdfRecordInsert();
            return instance;
        }

        public static FindNoEdfRecordInsert Instance(global::System.Nullable<DateTime> x_oStartLockTime, bool x_bIsLock, EDFStatusProfile x_oEDFStatusProfileControl, global::System.Nullable<DateTime> x_oEndLockTime)
        {
            if (instance == null)
                instance = new FindNoEdfRecordInsert(x_oStartLockTime, x_bIsLock, x_oEDFStatusProfileControl, x_oEndLockTime);
            return instance;
        }

        ~FindNoEdfRecordInsert() { }

        #endregion Constructor & Destructor


        public void AutoInsertNoEDFRecord()
        {
            if (this.IsLock == false)
            {
                this.IsLock = true;
                this.StartLockTime = DateTime.Now;
                this.EndLockTime = DateTime.Now.AddMinutes(3);
                if (this.EDFStatusProfileControl == null) this.EDFStatusProfileControl = new EDFStatusProfile();
                this.EDFStatusProfileControl.FindNoEdfNoAndInsert();
                this.IsLock = false;
            }
            else
            {
                if (this.StartLockTime == null || this.EndLockTime == null)
                {
                    this.StartLockTime = DateTime.Now;
                    this.EndLockTime = DateTime.Now.AddMinutes(3);
                }
                if (DateTime.Compare(DateTime.Now, (DateTime)this.EndLockTime) > 0)
                {
                    this.IsLock = false;
                    AutoInsertNoEDFRecord();
                }
            }
        }

        #region Get & Set
        public global::System.Nullable<DateTime> GetStartLockTime() { return this.StartLockTime; }
        public bool GetIsLock() { return this.IsLock; }
        public EDFStatusProfile GetEDFStatusProfileControl() { return this.EDFStatusProfileControl; }
        public global::System.Nullable<DateTime> GetEndLockTime() { return this.EndLockTime; }

        public bool SetStartLockTime(global::System.Nullable<DateTime> value)
        {
            this.StartLockTime = value;
            return true;
        }
        public bool SetIsLock(bool value)
        {
            this.IsLock = value;
            return true;
        }
        public bool SetEDFStatusProfileControl(EDFStatusProfile value)
        {
            this.EDFStatusProfileControl = value;
            return true;
        }
        public bool SetEndLockTime(global::System.Nullable<DateTime> value)
        {
            this.EndLockTime = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(FindNoEdfRecordInsert x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.StartLockTime.Equals(x_oObj.StartLockTime)) { return false; }
            if (!this.IsLock.Equals(x_oObj.IsLock)) { return false; }
            if (!this.EDFStatusProfileControl.Equals(x_oObj.EDFStatusProfileControl)) { return false; }
            if (!this.EndLockTime.Equals(x_oObj.EndLockTime)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.StartLockTime = null;
            this.IsLock = false;
            this.EDFStatusProfileControl = null;
            this.EndLockTime = null;
        }
        #endregion Release


        #region Clone
        public FindNoEdfRecordInsert DeepClone()
        {
            FindNoEdfRecordInsert FindNoEdfRecordInsert_Clone = new FindNoEdfRecordInsert();
            FindNoEdfRecordInsert_Clone.SetStartLockTime(this.StartLockTime);
            FindNoEdfRecordInsert_Clone.SetIsLock(this.IsLock);
            FindNoEdfRecordInsert_Clone.SetEDFStatusProfileControl(this.EDFStatusProfileControl);
            FindNoEdfRecordInsert_Clone.SetEndLockTime(this.EndLockTime);
            return FindNoEdfRecordInsert_Clone;
        }
        #endregion Clone

        void IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
