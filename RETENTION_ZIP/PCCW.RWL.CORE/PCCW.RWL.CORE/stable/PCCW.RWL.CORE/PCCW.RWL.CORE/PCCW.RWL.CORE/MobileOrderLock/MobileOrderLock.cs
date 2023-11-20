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
///-- Create date: <Create Date 2010-03-27>
///-- Description:	<Description,Class :MobileOrderLock, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class MobileOrderLock : IDisposable
    {

        protected string n_sOwner = global::System.String.Empty;
        #region Owner
        public string Owner
        {
            get
            {
                return this.n_sOwner;
            }
            set
            {
                this.n_sOwner = value;
            }
        }
        #endregion Owner


        protected CurrentLockStatus n_oCurrentStatus = CurrentLockStatus.ISSUE_ORDER;
        #region CurrentStatus
        public CurrentLockStatus CurrentStatus
        {
            get
            {
                return this.n_oCurrentStatus;
            }
            set
            {
                this.n_oCurrentStatus = value;
            }
        }
        #endregion CurrentStatus


        protected int n_iSerial = -1;
        #region Serial
        public int Serial
        {
            get
            {
                return this.n_iSerial;
            }
            set
            {
                this.n_iSerial = value;
            }
        }
        #endregion Serial


        protected DateTime? n_dModifiedAt = null;
        #region ModifiedAt
        public DateTime? ModifiedAt
        {
            get
            {
                return this.n_dModifiedAt;
            }
            set
            {
                this.n_dModifiedAt = value;
            }
        }
        #endregion ModifiedAt


        protected bool n_bIsActive = false;
        #region IsActive
        public bool IsActive
        {
            get
            {
                return this.n_bIsActive;
            }
            set
            {
                this.n_bIsActive = value;
            }
        }
        #endregion IsActive


        protected string n_sModifiedBy = global::System.String.Empty;
        #region ModifiedBy
        public string ModifiedBy
        {
            get
            {
                return this.n_sModifiedBy;
            }
            set
            {
                this.n_sModifiedBy = value;
            }
        }
        #endregion ModifiedBy


        protected DateTime? n_dLockedAt = null;
        #region LockedAt
        public DateTime? LockedAt
        {
            get
            {
                return this.n_dLockedAt;
            }
            set
            {
                this.n_dLockedAt = value;
            }
        }
        #endregion LockedAt


        protected int n_iOrderId = -1;
        #region OrderId
        public int OrderId
        {
            get
            {
                return this.n_iOrderId;
            }
            set
            {
                this.n_iOrderId = value;
            }
        }
        #endregion OrderId


        protected DateTime? n_dLockedSince = null;
        #region LockedSince
        public DateTime? LockedSince
        {
            get
            {
                return this.n_dLockedSince;
            }
            set
            {
                this.n_dLockedSince = value;
            }
        }
        #endregion LockedSince


        protected string n_sHandSetIMEI = global::System.String.Empty;
        #region HandSetIMEI
        public string HandSetIMEI
        {
            get
            {
                return this.n_sHandSetIMEI;
            }
            set
            {
                this.n_sHandSetIMEI = value;
            }
        }
        #endregion HandSetIMEI


        protected string n_sMobileNumber = global::System.String.Empty;
        #region MobileNumber
        public string MobileNumber
        {
            get
            {
                return this.n_sMobileNumber;
            }
            set
            {
                this.n_sMobileNumber = value;
            }
        }
        #endregion MobileNumber


        protected string n_sHandSetModel = global::System.String.Empty;
        #region HandSetModel
        public string HandSetModel
        {
            get
            {
                return this.n_sHandSetModel;
            }
            set
            {
                this.n_sHandSetModel = value;
            }
        }
        #endregion HandSetModel


        protected string n_sLockedBy = global::System.String.Empty;
        #region LockedBy
        public string LockedBy
        {
            get
            {
                return this.n_sLockedBy;
            }
            set
            {
                this.n_sLockedBy = value;
            }
        }
        #endregion LockedBy


        protected string n_sOwnerChannel = global::System.String.Empty;
        #region OwnerChannel
        public string OwnerChannel
        {
            get
            {
                return this.n_sOwnerChannel;
            }
            set
            {
                this.n_sOwnerChannel = value;
            }
        }
        #endregion OwnerChannel


        protected string n_sPageName = global::System.String.Empty;
        #region PageName
        public string PageName
        {
            get
            {
                return this.n_sPageName;
            }
            set
            {
                this.n_sPageName = value;
            }
        }
        #endregion PageName


        protected bool n_bHandSetOrder = false;
        #region HandSetOrder
        public bool HandSetOrder
        {
            get
            {
                return this.n_bHandSetOrder;
            }
            set
            {
                this.n_bHandSetOrder = value;
            }
        }
        #endregion HandSetOrder


        protected DateTime? n_dCreatedAt = null;
        #region CreatedAt
        public DateTime? CreatedAt
        {
            get
            {
                return this.n_dCreatedAt;
            }
            set
            {
                this.n_dCreatedAt = value;
            }
        }
        #endregion CreatedAt


        protected Guid n_gId = global::System.Guid.NewGuid();
        #region Id
        public Guid Id
        {
            get
            {
                return this.n_gId;
            }
            set
            {
                this.n_gId = value;
            }
        }
        #endregion Id

        #region Para
        public class Para
        {
            public const string Owner = "Owner";
            public const string CurrentStatus = "CurrentStatus";
            public const string Serial = "Serial";
            public const string ModifiedAt = "ModifiedAt";
            public const string IsActive = "IsActive";
            public const string ModifiedBy = "ModifiedBy";
            public const string LockedAt = "LockedAt";
            public const string OrderId = "OrderId";
            public const string LockedSince = "LockedSince";
            public const string HandSetIMEI = "HandSetIMEI";
            public const string MobileNumber = "MobileNumber";
            public const string HandSetModel = "HandSetModel";
            public const string LockedBy = "LockedBy";
            public const string OwnerChannel = "OwnerChannel";
            public const string PageName = "PageName";
            public const string HandSetOrder = "HandSetOrder";
            public const string CreatedAt = "CreatedAt";
            public const string Id = "Id";
        }
        #endregion Para

        #region Constructor & Destructor
        public MobileOrderLock() { }

        public MobileOrderLock(string x_sOwner, CurrentLockStatus x_oCurrentStatus, int x_iSerial, DateTime? x_dModifiedAt, bool x_bIsActive, string x_sModifiedBy, DateTime? x_dLockedAt, int x_iOrderId, DateTime? x_dLockedSince, string x_sHandSetIMEI, string x_sMobileNumber, string x_sHandSetModel, string x_sLockedBy, string x_sOwnerChannel, string x_sPageName, bool x_bHandSetOrder, DateTime? x_dCreatedAt, Guid x_gId)
        {
            Owner = x_sOwner;
            CurrentStatus = x_oCurrentStatus;
            Serial = x_iSerial;
            ModifiedAt = x_dModifiedAt;
            IsActive = x_bIsActive;
            ModifiedBy = x_sModifiedBy;
            LockedAt = x_dLockedAt;
            OrderId = x_iOrderId;
            LockedSince = x_dLockedSince;
            HandSetIMEI = x_sHandSetIMEI;
            MobileNumber = x_sMobileNumber;
            HandSetModel = x_sHandSetModel;
            LockedBy = x_sLockedBy;
            OwnerChannel = x_sOwnerChannel;
            PageName = x_sPageName;
            HandSetOrder = x_bHandSetOrder;
            CreatedAt = x_dCreatedAt;
            Id = x_gId;
        }

        ~MobileOrderLock() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetOwner() { return this.Owner; }
        public CurrentLockStatus GetCurrentStatus() { return this.CurrentStatus; }
        public int GetSerial() { return this.Serial; }
        public DateTime? GetModifiedAt() { return this.ModifiedAt; }
        public bool GetIsActive() { return this.IsActive; }
        public string GetModifiedBy() { return this.ModifiedBy; }
        public DateTime? GetLockedAt() { return this.LockedAt; }
        public int GetOrderId() { return this.OrderId; }
        public DateTime? GetLockedSince() { return this.LockedSince; }
        public string GetHandSetIMEI() { return this.HandSetIMEI; }
        public string GetMobileNumber() { return this.MobileNumber; }
        public string GetHandSetModel() { return this.HandSetModel; }
        public string GetLockedBy() { return this.LockedBy; }
        public string GetOwnerChannel() { return this.OwnerChannel; }
        public string GetPageName() { return this.PageName; }
        public bool GetHandSetOrder() { return this.HandSetOrder; }
        public DateTime? GetCreatedAt() { return this.CreatedAt; }
        public Guid GetId() { return this.Id; }

        public bool SetOwner(string value)
        {
            this.Owner = value;
            return true;
        }
        public bool SetCurrentStatus(CurrentLockStatus value)
        {
            this.CurrentStatus = value;
            return true;
        }
        public bool SetSerial(int value)
        {
            this.Serial = value;
            return true;
        }
        public bool SetModifiedAt(DateTime? value)
        {
            this.ModifiedAt = value;
            return true;
        }
        public bool SetIsActive(bool value)
        {
            this.IsActive = value;
            return true;
        }
        public bool SetModifiedBy(string value)
        {
            this.ModifiedBy = value;
            return true;
        }
        public bool SetLockedAt(DateTime? value)
        {
            this.LockedAt = value;
            return true;
        }
        public bool SetOrderId(int value)
        {
            this.OrderId = value;
            return true;
        }
        public bool SetLockedSince(DateTime? value)
        {
            this.LockedSince = value;
            return true;
        }
        public bool SetHandSetIMEI(string value)
        {
            this.HandSetIMEI = value;
            return true;
        }
        public bool SetMobileNumber(string value)
        {
            this.MobileNumber = value;
            return true;
        }
        public bool SetHandSetModel(string value)
        {
            this.HandSetModel = value;
            return true;
        }
        public bool SetLockedBy(string value)
        {
            this.LockedBy = value;
            return true;
        }
        public bool SetOwnerChannel(string value)
        {
            this.OwnerChannel = value;
            return true;
        }
        public bool SetPageName(string value)
        {
            this.PageName = value;
            return true;
        }
        public bool SetHandSetOrder(bool value)
        {
            this.HandSetOrder = value;
            return true;
        }
        public bool SetCreatedAt(DateTime? value)
        {
            this.CreatedAt = value;
            return true;
        }
        public bool SetId(Guid value)
        {
            this.Id = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(MobileOrderLock x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Owner.Equals(x_oObj.Owner)) { return false; }
            if (!this.CurrentStatus.Equals(x_oObj.CurrentStatus)) { return false; }
            if (!this.Serial.Equals(x_oObj.Serial)) { return false; }
            if (!this.ModifiedAt.Equals(x_oObj.ModifiedAt)) { return false; }
            if (!this.IsActive.Equals(x_oObj.IsActive)) { return false; }
            if (!this.ModifiedBy.Equals(x_oObj.ModifiedBy)) { return false; }
            if (!this.LockedAt.Equals(x_oObj.LockedAt)) { return false; }
            if (!this.OrderId.Equals(x_oObj.OrderId)) { return false; }
            if (!this.LockedSince.Equals(x_oObj.LockedSince)) { return false; }
            if (!this.HandSetIMEI.Equals(x_oObj.HandSetIMEI)) { return false; }
            if (!this.MobileNumber.Equals(x_oObj.MobileNumber)) { return false; }
            if (!this.HandSetModel.Equals(x_oObj.HandSetModel)) { return false; }
            if (!this.LockedBy.Equals(x_oObj.LockedBy)) { return false; }
            if (!this.OwnerChannel.Equals(x_oObj.OwnerChannel)) { return false; }
            if (!this.PageName.Equals(x_oObj.PageName)) { return false; }
            if (!this.HandSetOrder.Equals(x_oObj.HandSetOrder)) { return false; }
            if (!this.CreatedAt.Equals(x_oObj.CreatedAt)) { return false; }
            if (!this.Id.Equals(x_oObj.Id)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Owner = global::System.String.Empty;
            this.CurrentStatus = CurrentLockStatus.ISSUE_ORDER;
            this.Serial = -1;
            this.ModifiedAt = null;
            this.IsActive = false;
            this.ModifiedBy = global::System.String.Empty;
            this.LockedAt = null;
            this.OrderId = -1;
            this.LockedSince = null;
            this.HandSetIMEI = global::System.String.Empty;
            this.MobileNumber = global::System.String.Empty;
            this.HandSetModel = global::System.String.Empty;
            this.LockedBy = global::System.String.Empty;
            this.OwnerChannel = global::System.String.Empty;
            this.PageName = global::System.String.Empty;
            this.HandSetOrder = false;
            this.CreatedAt = null;
            this.Id = global::System.Guid.NewGuid();
        }
        #endregion Release


        #region Clone
        public MobileOrderLock DeepClone()
        {
            MobileOrderLock MobileOrderLock_Clone = new MobileOrderLock();
            MobileOrderLock_Clone.SetOwner(this.Owner);
            MobileOrderLock_Clone.SetCurrentStatus(this.CurrentStatus);
            MobileOrderLock_Clone.SetSerial(this.Serial);
            MobileOrderLock_Clone.SetModifiedAt(this.ModifiedAt);
            MobileOrderLock_Clone.SetIsActive(this.IsActive);
            MobileOrderLock_Clone.SetModifiedBy(this.ModifiedBy);
            MobileOrderLock_Clone.SetLockedAt(this.LockedAt);
            MobileOrderLock_Clone.SetOrderId(this.OrderId);
            MobileOrderLock_Clone.SetLockedSince(this.LockedSince);
            MobileOrderLock_Clone.SetHandSetIMEI(this.HandSetIMEI);
            MobileOrderLock_Clone.SetMobileNumber(this.MobileNumber);
            MobileOrderLock_Clone.SetHandSetModel(this.HandSetModel);
            MobileOrderLock_Clone.SetLockedBy(this.LockedBy);
            MobileOrderLock_Clone.SetOwnerChannel(this.OwnerChannel);
            MobileOrderLock_Clone.SetPageName(this.PageName);
            MobileOrderLock_Clone.SetHandSetOrder(this.HandSetOrder);
            MobileOrderLock_Clone.SetCreatedAt(this.CreatedAt);
            MobileOrderLock_Clone.SetId(this.Id);
            return MobileOrderLock_Clone;
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
