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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2010-04-21>
///-- Description:	<Description,Class :FindNoAORecordInsert, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class FindNoAORecordInsert : IDisposable
    {

        protected bool n_oIsLock = false;
        #region IsLock
        protected bool IsLock
        {
            get
            {
                return this.n_oIsLock;
            }
            set
            {
                this.n_oIsLock = value;
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

        #region Para
        public class Para
        {
            public const string IsLock = "IsLock";
            public const string EDFStatusProfileControl = "EDFStatusProfileControl";
            public const string EndLockTime = "EndLockTime";
            public const string StartLockTime = "StartLockTime";
        }
        #endregion Para

        #region Instance
        private static FindNoAORecordInsert instance;
        #endregion

        #region Constructor & Destructor
        protected FindNoAORecordInsert() { }

        protected FindNoAORecordInsert(bool x_oIsLock, EDFStatusProfile x_oEDFStatusProfileControl, global::System.Nullable<DateTime> x_oEndLockTime, global::System.Nullable<DateTime> x_oStartLockTime)
        {
            IsLock = x_oIsLock;
            EDFStatusProfileControl = x_oEDFStatusProfileControl;
            EndLockTime = x_oEndLockTime;
            StartLockTime = x_oStartLockTime;
        }

        public static FindNoAORecordInsert Instance()
        {
            if (instance == null)
                instance = new FindNoAORecordInsert();
            return instance;
        }

        ~FindNoAORecordInsert() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public bool GetIsLock() { return this.IsLock; }
        public EDFStatusProfile GetEDFStatusProfileControl() { return this.EDFStatusProfileControl; }
        public global::System.Nullable<DateTime> GetEndLockTime() { return this.EndLockTime; }
        public global::System.Nullable<DateTime> GetStartLockTime() { return this.StartLockTime; }

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
        public bool SetStartLockTime(global::System.Nullable<DateTime> value)
        {
            this.StartLockTime = value;
            return true;
        }
        #endregion


        public void AutoInsertNoAONoEDFRecord()
        {

            if (this.IsLock == false)
            {
                this.IsLock = true;
                this.StartLockTime = DateTime.Now;
                this.EndLockTime = DateTime.Now.AddMinutes(3);
                if (this.EDFStatusProfileControl == null) this.EDFStatusProfileControl = new EDFStatusProfile();
                this.EDFStatusProfileControl.FindNoAONoEdfInsert();
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
                    AutoInsertNoAONoEDFRecord();
                }
            }
        }


        #region Equals
        public bool Equals(FindNoAORecordInsert x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.IsLock.Equals(x_oObj.IsLock)) { return false; }
            if (!this.EDFStatusProfileControl.Equals(x_oObj.EDFStatusProfileControl)) { return false; }
            if (!this.EndLockTime.Equals(x_oObj.EndLockTime)) { return false; }
            if (!this.StartLockTime.Equals(x_oObj.StartLockTime)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.IsLock = false;
            this.EDFStatusProfileControl = null;
            this.EndLockTime = null;
            this.StartLockTime = null;
        }
        #endregion Release


        #region Clone
        public FindNoAORecordInsert DeepClone()
        {
            FindNoAORecordInsert FindNoAORecordInsert_Clone = new FindNoAORecordInsert();
            FindNoAORecordInsert_Clone.SetIsLock(this.IsLock);
            FindNoAORecordInsert_Clone.SetEDFStatusProfileControl(this.EDFStatusProfileControl);
            FindNoAORecordInsert_Clone.SetEndLockTime(this.EndLockTime);
            FindNoAORecordInsert_Clone.SetStartLockTime(this.StartLockTime);
            return FindNoAORecordInsert_Clone;
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
