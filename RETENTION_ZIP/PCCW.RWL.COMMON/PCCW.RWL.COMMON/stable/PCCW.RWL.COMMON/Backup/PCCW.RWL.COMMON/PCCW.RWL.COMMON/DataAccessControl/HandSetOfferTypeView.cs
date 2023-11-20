using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2010-06-18>
///-- Description:	<Description,Class :HandSetOfferTypeView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class HandSetOfferTypeView : IDisposable, global::System.IEquatable<HandSetOfferTypeView>
    {

        private int _Index = 0;
        [DataObjectField(true)]
        public int Index
        {
            get
            {
                return _Index;
            }
            set
            {
                _Index = value;
            }
        }


        protected HandSetOfferType n_oHandSetOfferType = null;
        #region HandSetOfferType
        [DataObjectField(true)]
        public virtual HandSetOfferType HandSetOfferType
        {
            get
            {
                if (n_oHandSetOfferType == null) { n_oHandSetOfferType = new HandSetOfferType(GetDB()); }
                return this.n_oHandSetOfferType;
            }
            set
            {
                this.n_oHandSetOfferType = value;
            }
        }
        #endregion HandSetOfferType


        #region HandSetOfferType_id
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> HandSetOfferType_id
        {
            get
            {
                return this.HandSetOfferType.id;
            }
            set
            {
                this.HandSetOfferType.id = value;
            }
        }
        #endregion HandSetOfferType_id


        #region HandSetOfferType_cdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> HandSetOfferType_cdate
        {
            get
            {
                return this.HandSetOfferType.cdate;
            }
            set
            {
                this.HandSetOfferType.cdate = value;
            }
        }
        #endregion HandSetOfferType_cdate


        #region HandSetOfferType_cid
        [DataObjectField(true)]
        public virtual string HandSetOfferType_cid
        {
            get
            {
                return this.HandSetOfferType.cid;
            }
            set
            {
                this.HandSetOfferType.cid = value;
            }
        }
        #endregion HandSetOfferType_cid


        #region HandSetOfferType_did
        [DataObjectField(true)]
        public virtual string HandSetOfferType_did
        {
            get
            {
                return this.HandSetOfferType.did;
            }
            set
            {
                this.HandSetOfferType.did = value;
            }
        }
        #endregion HandSetOfferType_did


        #region HandSetOfferType_expiry_chk
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> HandSetOfferType_expiry_chk
        {
            get
            {
                return this.HandSetOfferType.expiry_chk;
            }
            set
            {
                this.HandSetOfferType.expiry_chk = value;
            }
        }
        #endregion HandSetOfferType_expiry_chk


        #region HandSetOfferType_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> HandSetOfferType_active
        {
            get
            {
                return this.HandSetOfferType.active;
            }
            set
            {
                this.HandSetOfferType.active = value;
            }
        }
        #endregion HandSetOfferType_active


        #region HandSetOfferType_name
        [DataObjectField(true)]
        public virtual string HandSetOfferType_name
        {
            get
            {
                return this.HandSetOfferType.name;
            }
            set
            {
                this.HandSetOfferType.name = value;
            }
        }
        #endregion HandSetOfferType_name


        #region HandSetOfferType_edate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> HandSetOfferType_edate
        {
            get
            {
                return this.HandSetOfferType.edate;
            }
            set
            {
                this.HandSetOfferType.edate = value;
            }
        }
        #endregion HandSetOfferType_edate


        #region HandSetOfferType_ddate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> HandSetOfferType_ddate
        {
            get
            {
                return this.HandSetOfferType.ddate;
            }
            set
            {
                this.HandSetOfferType.ddate = value;
            }
        }
        #endregion HandSetOfferType_ddate


        #region HandSetOfferType_sdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> HandSetOfferType_sdate
        {
            get
            {
                return this.HandSetOfferType.sdate;
            }
            set
            {
                this.HandSetOfferType.sdate = value;
            }
        }
        #endregion HandSetOfferType_sdate

        #region Para
        public class Para
        {
            public const string HandSetOfferType = "HandSetOfferType";
            public const string HandSetOfferType_id = "HandSetOfferType_id";
            public const string HandSetOfferType_cdate = "HandSetOfferType_cdate";
            public const string HandSetOfferType_cid = "HandSetOfferType_cid";
            public const string HandSetOfferType_did = "HandSetOfferType_did";
            public const string HandSetOfferType_expiry_chk = "HandSetOfferType_expiry_chk";
            public const string HandSetOfferType_active = "HandSetOfferType_active";
            public const string HandSetOfferType_name = "HandSetOfferType_name";
            public const string HandSetOfferType_edate = "HandSetOfferType_edate";
            public const string HandSetOfferType_ddate = "HandSetOfferType_ddate";
            public const string HandSetOfferType_sdate = "HandSetOfferType_sdate";
        }
        #endregion Para

        #region Constructor & Destructor
        public HandSetOfferTypeView() { }

        public HandSetOfferTypeView(HandSetOfferType x_oHandSetOfferType)
        {
            HandSetOfferType = x_oHandSetOfferType;
        }

        ~HandSetOfferTypeView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public HandSetOfferType Get() { return this.HandSetOfferType; }

        public bool Set(HandSetOfferType value)
        {
            this.HandSetOfferType = value;
            return true;
        }
        #endregion


        #region IEquatable<HandSetOfferTypeView> Members
        public bool Equals(HandSetOfferTypeView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.HandSetOfferType.Equals(x_oObj.HandSetOfferType)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.HandSetOfferType = null;
        }
        #endregion Release


        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }


        #region Clone
        public HandSetOfferTypeView DeepClone()
        {
            HandSetOfferTypeView HandSetOfferTypeView_Clone = new HandSetOfferTypeView();
            HandSetOfferTypeView_Clone.Set(this.HandSetOfferType);
            return HandSetOfferTypeView_Clone;
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
