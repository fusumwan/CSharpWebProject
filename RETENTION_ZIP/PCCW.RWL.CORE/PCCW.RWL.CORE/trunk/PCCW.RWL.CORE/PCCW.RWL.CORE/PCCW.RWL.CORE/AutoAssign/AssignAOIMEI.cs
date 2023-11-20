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
///-- Create date: <Create Date 2010-03-31>
///-- Description:	<Description,Class :AssignAOIMEI, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class AssignAOIMEI : IDisposable
    {

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


        protected EDFRWLCombineSynchronizationl n_oAutoAOAssignImei = null;
        #region AutoAOAssignImei
        protected EDFRWLCombineSynchronizationl AutoAOAssignImei
        {
            get
            {
                return this.n_oAutoAOAssignImei;
            }
            set
            {
                this.n_oAutoAOAssignImei = value;
            }
        }
        #endregion AutoAOAssignImei

        #region Para
        public class Para
        {
            public const string IsLock = "IsLock";
            public const string EndLockTime = "EndLockTime";
            public const string StartLockTime = "StartLockTime";
            public const string AutoAOAssignImei = "AutoAOAssignImei";
        }
        #endregion Para

        #region Instance
        private static AssignAOIMEI instance;
        #endregion


        #region Constructor & Destructor
        protected AssignAOIMEI() { }

        protected AssignAOIMEI(bool x_bIsLock, global::System.Nullable<DateTime> x_oEndLockTime, global::System.Nullable<DateTime> x_oStartLockTime, EDFRWLCombineSynchronizationl x_oAutoAOAssignImei)
        {
            IsLock = x_bIsLock;
            EndLockTime = x_oEndLockTime;
            StartLockTime = x_oStartLockTime;
            AutoAOAssignImei = x_oAutoAOAssignImei;
        }

        public static AssignAOIMEI Instance()
        {
            if (instance == null)
                instance = new AssignAOIMEI();
            return instance;
        }

        public static AssignAOIMEI Instance(bool x_bIsLock, global::System.Nullable<DateTime> x_oEndLockTime, global::System.Nullable<DateTime> x_oStartLockTime, EDFRWLCombineSynchronizationl x_oAutoAOAssignImei)
        {
            if (instance == null)
                instance = new AssignAOIMEI(x_bIsLock, x_oEndLockTime, x_oStartLockTime, x_oAutoAOAssignImei);
            return instance;
        }

        ~AssignAOIMEI() { }

        #endregion Constructor & Destructor

        public void AutoAssignAOCaseIMEI(string x_sUid)
        {
            if (this.IsLock == false)
            {
                this.IsLock = true;
                this.StartLockTime = DateTime.Now;
                this.EndLockTime = DateTime.Now.AddMinutes(5);
                if (this.AutoAOAssignImei == null) this.AutoAOAssignImei = new EDFRWLCombineSynchronizationl();
                this.AutoAOAssignImei.SetUid(x_sUid);
                this.AutoAOAssignImei.UpdateImei();
                this.IsLock = false;
            }
            else
            {
                if (this.StartLockTime == null || this.EndLockTime == null)
                {
                    this.StartLockTime = DateTime.Now;
                    this.EndLockTime = DateTime.Now.AddMinutes(5);
                }
                if (DateTime.Compare((DateTime)this.StartLockTime, (DateTime)this.EndLockTime) > 0)
                {
                    this.IsLock = false;
                    AutoAssignAOCaseIMEI(x_sUid);
                }
            }
        }


        #region Get & Set
        protected bool GetIsLock() { return this.IsLock; }
        protected global::System.Nullable<DateTime> GetEndLockTime() { return this.EndLockTime; }
        protected global::System.Nullable<DateTime> GetStartLockTime() { return this.StartLockTime; }
        protected EDFRWLCombineSynchronizationl GetAutoAOAssignImei() { return this.AutoAOAssignImei; }

        protected bool SetIsLock(bool value)
        {
            this.IsLock = value;
            return true;
        }
        protected bool SetEndLockTime(global::System.Nullable<DateTime> value)
        {
            this.EndLockTime = value;
            return true;
        }
        protected bool SetStartLockTime(global::System.Nullable<DateTime> value)
        {
            this.StartLockTime = value;
            return true;
        }
        protected bool SetAutoAOAssignImei(EDFRWLCombineSynchronizationl value)
        {
            this.AutoAOAssignImei = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(AssignAOIMEI x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.IsLock.Equals(x_oObj.IsLock)) { return false; }
            if (!this.EndLockTime.Equals(x_oObj.EndLockTime)) { return false; }
            if (!this.StartLockTime.Equals(x_oObj.StartLockTime)) { return false; }
            if (!this.AutoAOAssignImei.Equals(x_oObj.AutoAOAssignImei)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.IsLock = false;
            this.EndLockTime = null;
            this.StartLockTime = null;
            this.AutoAOAssignImei = null;
        }
        #endregion Release


        #region Clone
        public AssignAOIMEI DeepClone()
        {
            AssignAOIMEI AssignAOIMEI_Clone = new AssignAOIMEI();
            AssignAOIMEI_Clone.SetIsLock(this.IsLock);
            AssignAOIMEI_Clone.SetEndLockTime(this.EndLockTime);
            AssignAOIMEI_Clone.SetStartLockTime(this.StartLockTime);
            AssignAOIMEI_Clone.SetAutoAOAssignImei(this.AutoAOAssignImei);
            return AssignAOIMEI_Clone;
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
