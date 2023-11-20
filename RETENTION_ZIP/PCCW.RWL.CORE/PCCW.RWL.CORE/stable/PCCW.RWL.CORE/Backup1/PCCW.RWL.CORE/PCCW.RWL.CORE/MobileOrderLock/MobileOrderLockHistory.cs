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
///-- Description:	<Description,Class :MobileOrderLockHistory, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class MobileOrderLockHistory : IDisposable
    {
        public MobileOrderLock FindByMobileNumber(string x_sMobileNumber)
        {
            if(string.IsNullOrEmpty(x_sMobileNumber)) return null;
            if (this.MobileOrderHistoryEntry == null) return null;

            foreach (KeyValuePair<string, MobileOrderLock> _oValue in MobileOrderHistoryEntry)
            {
                MobileOrderLock _oMobileOrderLock = _oValue.Value;
                if (_oMobileOrderLock.MobileNumber.Equals(x_sMobileNumber.Trim()))
                    return _oMobileOrderLock;
            }
            return null;
        }

        public bool AddOrderLock(string x_sMobileNumber, CurrentLockStatus x_oCurrentStatus,
            bool x_bHandSetOrder, string x_sHandSetModel, string x_sHandSetIMEI, string x_sOwer,string x_sOwerChannel, string x_sPageName)
        {
            if (this.MobileOrderHistoryEntry == null) return false;
            if (this.FindByMobileNumber(x_sMobileNumber) == null)
            {
                MobileOrderLock _oMobileOrderLock = new MobileOrderLock();
                _oMobileOrderLock.CreatedAt = DateTime.Now;
                _oMobileOrderLock.IsActive = true;
                _oMobileOrderLock.LockedAt = DateTime.Now;
                _oMobileOrderLock.LockedBy = x_sOwer;
                _oMobileOrderLock.LockedSince = DateTime.Now.AddMinutes(5.0);
                _oMobileOrderLock.CurrentStatus = x_oCurrentStatus;
                _oMobileOrderLock.HandSetModel = x_sHandSetModel;
                _oMobileOrderLock.HandSetIMEI = x_sHandSetIMEI;
                _oMobileOrderLock.Owner = x_sOwer;
                _oMobileOrderLock.OwnerChannel = x_sOwerChannel;
                _oMobileOrderLock.PageName = x_sPageName;
                _oMobileOrderLock.MobileNumber = x_sMobileNumber;
                if (!this.MobileOrderHistoryEntry.ContainsKey(x_sMobileNumber))
                    this.MobileOrderHistoryEntry.Add(x_sMobileNumber,_oMobileOrderLock);
                return true;
            }
            return false;
        }

        public bool IsOrderLock(string x_sMobileNumber, CurrentLockStatus x_oCurrentStatus,string x_sOwer)
        {
            MobileOrderLock _oMobileOrderLock = FindByMobileNumber(x_sMobileNumber);
            if (_oMobileOrderLock != null)
            {
                if (_oMobileOrderLock.LockedSince != null)
                {
                    if (DateTime.Compare(DateTime.Now, (DateTime)_oMobileOrderLock.LockedSince) < 0)
                        return true;
                }
            }
            return false;
        }

        public void RemoveMobileOrderLock(string x_sMobileNumber)
        {
            if (this.MobileOrderHistoryEntry == null) return;
            if (string.IsNullOrEmpty(x_sMobileNumber)) return;
            this.MobileOrderHistoryEntry.Remove(x_sMobileNumber);
        }

        public void RemoveOwerOrderLock(string x_sOwer)
        {
            if (this.MobileOrderHistoryEntry == null) return;
            if (string.IsNullOrEmpty(x_sOwer)) return;
            List<string> _oMrtRemoveList = new List<string>();
            foreach (KeyValuePair<string, MobileOrderLock> _oValue in MobileOrderHistoryEntry)
            {
                MobileOrderLock _oMobileOrderLock = _oValue.Value;
                if (_oMobileOrderLock.Owner.Equals(x_sOwer.Trim()))
                {
                    _oMrtRemoveList.Add(_oMobileOrderLock.GetMobileNumber());
                }
            }
            for (int i = 0; i < _oMrtRemoveList.Count; i++)
            {
                if(MobileOrderHistoryEntry.ContainsKey(_oMrtRemoveList[i].ToString()))
                    MobileOrderHistoryEntry.Remove(_oMrtRemoveList[i].ToString());
            }
        }

        public void RemoveExpiryLock()
        {
            if(this.MobileOrderHistoryEntry==null) return;
            List<string> _oRemoveMobile = new List<string>();
            foreach(KeyValuePair<string,MobileOrderLock> _oValue in  MobileOrderHistoryEntry){
                MobileOrderLock _oMobileOrderLock = _oValue.Value;
                if (_oMobileOrderLock.LockedSince != null)
                {
                    if (DateTime.Compare(DateTime.Now, (DateTime)_oMobileOrderLock.LockedSince) > 0)
                    {
                        _oMobileOrderLock.IsActive = false;
                        _oRemoveMobile.Add(_oMobileOrderLock.MobileNumber);
                    }
                }
            }
            for (int i = 0; i < _oRemoveMobile.Count; i++)
                this.MobileOrderHistoryEntry.Remove(_oRemoveMobile[i]);
        }


        protected IDictionary<string, MobileOrderLock> n_oMobileOrderHistoryEntry = null;
        #region MobileOrderHistoryEntry
        public IDictionary<string,MobileOrderLock> MobileOrderHistoryEntry
        {
            get
            {
                return this.n_oMobileOrderHistoryEntry;
            }
            set
            {
                this.n_oMobileOrderHistoryEntry = value;
            }
        }
        #endregion MobileOrderHistoryEntry

        #region Para
        public class Para
        {
            public const string MobileOrderHistoryEntry = "MobileOrderHistoryEntry";
        }
        #endregion Para

        #region Constructor & Destructor
        public MobileOrderLockHistory() {
            this.MobileOrderHistoryEntry = new Dictionary<string, MobileOrderLock>();
        }

        public MobileOrderLockHistory(IDictionary<string,MobileOrderLock> x_oMobileOrderHistoryEntry)
        {
            MobileOrderHistoryEntry = x_oMobileOrderHistoryEntry;
        }

        ~MobileOrderLockHistory() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public IDictionary<string,MobileOrderLock> GetMobileOrderHistoryEntry() { return this.MobileOrderHistoryEntry; }

        public bool SetMobileOrderHistoryEntry(IDictionary<string,MobileOrderLock> value)
        {
            this.MobileOrderHistoryEntry = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(MobileOrderLockHistory x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.MobileOrderHistoryEntry.Equals(x_oObj.MobileOrderHistoryEntry)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.MobileOrderHistoryEntry = null;
        }
        #endregion Release


        #region Clone
        public MobileOrderLockHistory DeepClone()
        {
            MobileOrderLockHistory MobileOrderLockHistory_Clone = new MobileOrderLockHistory();
            MobileOrderLockHistory_Clone.SetMobileOrderHistoryEntry(this.MobileOrderHistoryEntry);
            return MobileOrderLockHistory_Clone;
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
