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
///-- Create date: <Create Date 2010-03-27>
///-- Description:	<Description,Class :MobileOrderLockControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class MobileOrderLockControl : IDisposable
    {
        public void RemoveOwerOrderLock(string x_sOwer)
        {
            if (this.OrderLockHistory != null)
                this.OrderLockHistory.RemoveOwerOrderLock(x_sOwer.Trim());
        }

        public MobileOrderLock FindByMobileNumber(string x_sMobileNumber)
        {
            if (this.OrderLockHistory != null)
                return this.OrderLockHistory.FindByMobileNumber(x_sMobileNumber);
            return null;
        }

        public bool AddNewOrderLock(string x_sMobileNumber, CurrentLockStatus x_oCurrentStatus,
            bool x_bHandSetOrder, string x_sHandSetModel, string x_sHandSetIMEI, string x_sOwer,string x_sOwerChannel, string x_sPageName)
        {
            if (this.OrderLockHistory != null)
               return this.OrderLockHistory.AddOrderLock(x_sMobileNumber, x_oCurrentStatus, x_bHandSetOrder, x_sHandSetModel, x_sHandSetIMEI, x_sOwer, x_sOwerChannel, x_sPageName);
            return false;
        }

        protected bool FindLockHistoryByMrt(string x_sMobileNumber)
        {
            if (this.OrderLockHistory.FindByMobileNumber(x_sMobileNumber)!=null) return true;
            return false;
        }

        public bool IsOrderLock(string x_sMobileNumber, CurrentLockStatus x_oCurrentStatus, string x_sOwer)
        {
            if (this.OrderLockHistory != null)
                return this.OrderLockHistory.IsOrderLock(x_sMobileNumber, x_oCurrentStatus, x_sOwer);
            return false;
        }
        public void RemoveMobileOrderLock(string x_sMobileNumber)
        {
            if (this.OrderLockHistory != null)
                this.OrderLockHistory.RemoveMobileOrderLock(x_sMobileNumber);
        }

        public void RemoveExpiryLock()
        {
            if(this.OrderLockHistory!=null)
                this.OrderLockHistory.RemoveExpiryLock();
        }
        protected MobileOrderLockHistory n_oOrderLockHistory = null;
        #region OrderLockHistory
        public MobileOrderLockHistory OrderLockHistory
        {
            get
            {
                return this.n_oOrderLockHistory;
            }
            set
            {
                this.n_oOrderLockHistory = value;
            }
        }
        #endregion OrderLockHistory

        #region Para
        public class Para
        {
            public const string OrderLockHistory = "OrderLockHistory";
        }
        #endregion Para

        #region Instance
        private static MobileOrderLockControl instance;
        #endregion


        #region Constructor & Destructor
        protected MobileOrderLockControl() {
            OrderLockHistory = new MobileOrderLockHistory();
        }

        protected MobileOrderLockControl(MobileOrderLockHistory x_oOrderLockHistory)
        {
            OrderLockHistory = x_oOrderLockHistory;
        }

        public static MobileOrderLockControl Instance()
        {
            if (instance == null)
                instance = new MobileOrderLockControl();
            return instance;
        }

        public static MobileOrderLockControl Instance(MobileOrderLockHistory x_oOrderLockHistory)
        {
            if (instance == null)
                instance = new MobileOrderLockControl(x_oOrderLockHistory);
            return instance;
        }

        ~MobileOrderLockControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public MobileOrderLockHistory GetOrderLockHistory() { return this.OrderLockHistory; }

        public bool SetOrderLockHistory(MobileOrderLockHistory value)
        {
            this.OrderLockHistory = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(MobileOrderLockControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.OrderLockHistory.Equals(x_oObj.OrderLockHistory)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.OrderLockHistory = null;
        }
        #endregion Release


        #region Clone
        public MobileOrderLockControl DeepClone()
        {
            MobileOrderLockControl MobileOrderLockControl_Clone = new MobileOrderLockControl();
            MobileOrderLockControl_Clone.SetOrderLockHistory(this.OrderLockHistory);
            return MobileOrderLockControl_Clone;
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
