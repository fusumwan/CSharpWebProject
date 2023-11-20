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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2010-05-10>
///-- Description:	<Description,Class :EventMsgDetailView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class EventMsgDetailView : IDisposable, global::System.IEquatable<EventMsgDetailView>
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


        protected EventMsgDetail n_oEventMsgDetail = null;
        #region EventMsgDetail
        [DataObjectField(true)]
        public virtual EventMsgDetail EventMsgDetail
        {
            get
            {
                if (n_oEventMsgDetail == null) { n_oEventMsgDetail = new EventMsgDetail(GetDB()); }
                return this.n_oEventMsgDetail;
            }
            set
            {
                this.n_oEventMsgDetail = value;
            }
        }
        #endregion EventMsgDetail


        #region EventMsgDetail_cdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> EventMsgDetail_cdate
        {
            get
            {
                return this.EventMsgDetail.cdate;
            }
            set
            {
                this.EventMsgDetail.cdate = value;
            }
        }
        #endregion EventMsgDetail_cdate


        #region EventMsgDetail_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> EventMsgDetail_active
        {
            get
            {
                return this.EventMsgDetail.active;
            }
            set
            {
                this.EventMsgDetail.active = value;
            }
        }
        #endregion EventMsgDetail_active


        #region EventMsgDetail_access_right
        [DataObjectField(true)]
        public virtual string EventMsgDetail_access_right
        {
            get
            {
                return this.EventMsgDetail.access_right;
            }
            set
            {
                this.EventMsgDetail.access_right = value;
            }
        }
        #endregion EventMsgDetail_access_right


        #region EventMsgDetail_cid
        [DataObjectField(true)]
        public virtual string EventMsgDetail_cid
        {
            get
            {
                return this.EventMsgDetail.cid;
            }
            set
            {
                this.EventMsgDetail.cid = value;
            }
        }
        #endregion EventMsgDetail_cid


        #region EventMsgDetail_did
        [DataObjectField(true)]
        public virtual string EventMsgDetail_did
        {
            get
            {
                return this.EventMsgDetail.did;
            }
            set
            {
                this.EventMsgDetail.did = value;
            }
        }
        #endregion EventMsgDetail_did


        #region EventMsgDetail_message
        [DataObjectField(true)]
        public virtual string EventMsgDetail_message
        {
            get
            {
                return this.EventMsgDetail.message;
            }
            set
            {
                this.EventMsgDetail.message = value;
            }
        }
        #endregion EventMsgDetail_message


        #region EventMsgDetail_edate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> EventMsgDetail_edate
        {
            get
            {
                return this.EventMsgDetail.edate;
            }
            set
            {
                this.EventMsgDetail.edate = value;
            }
        }
        #endregion EventMsgDetail_edate


        #region EventMsgDetail_subject
        [DataObjectField(true)]
        public virtual string EventMsgDetail_subject
        {
            get
            {
                return this.EventMsgDetail.subject;
            }
            set
            {
                this.EventMsgDetail.subject = value;
            }
        }
        #endregion EventMsgDetail_subject


        #region EventMsgDetail_ddate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> EventMsgDetail_ddate
        {
            get
            {
                return this.EventMsgDetail.ddate;
            }
            set
            {
                this.EventMsgDetail.ddate = value;
            }
        }
        #endregion EventMsgDetail_ddate


        #region EventMsgDetail_mid
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> EventMsgDetail_mid
        {
            get
            {
                return this.EventMsgDetail.mid;
            }
            set
            {
                this.EventMsgDetail.mid = value;
            }
        }
        #endregion EventMsgDetail_mid


        #region EventMsgDetail_sdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> EventMsgDetail_sdate
        {
            get
            {
                return this.EventMsgDetail.sdate;
            }
            set
            {
                this.EventMsgDetail.sdate = value;
            }
        }
        #endregion EventMsgDetail_sdate

        #region Para
        public class Para
        {
            public const string EventMsgDetail = "EventMsgDetail";
            public const string EventMsgDetail_cdate = "EventMsgDetail_cdate";
            public const string EventMsgDetail_active = "EventMsgDetail_active";
            public const string EventMsgDetail_access_right = "EventMsgDetail_access_right";
            public const string EventMsgDetail_cid = "EventMsgDetail_cid";
            public const string EventMsgDetail_did = "EventMsgDetail_did";
            public const string EventMsgDetail_message = "EventMsgDetail_message";
            public const string EventMsgDetail_edate = "EventMsgDetail_edate";
            public const string EventMsgDetail_subject = "EventMsgDetail_subject";
            public const string EventMsgDetail_ddate = "EventMsgDetail_ddate";
            public const string EventMsgDetail_mid = "EventMsgDetail_mid";
            public const string EventMsgDetail_sdate = "EventMsgDetail_sdate";
        }
        #endregion Para

        #region Constructor & Destructor
        public EventMsgDetailView() { }

        public EventMsgDetailView(EventMsgDetail x_oEventMsgDetail)
        {
            EventMsgDetail = x_oEventMsgDetail;
        }

        ~EventMsgDetailView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public EventMsgDetail Get() { return this.EventMsgDetail; }

        public bool Set(EventMsgDetail value)
        {
            this.EventMsgDetail = value;
            return true;
        }
        #endregion


        #region IEquatable<EventMsgDetailView> Members
        public bool Equals(EventMsgDetailView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.EventMsgDetail.Equals(x_oObj.EventMsgDetail)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.EventMsgDetail = null;
        }
        #endregion Release


        public void Save()
        {
            if (this.EventMsgDetail == null) { throw new NotImplementedException(); }
            this.EventMsgDetail.Save();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion


        #region Clone
        public EventMsgDetailView DeepClone()
        {
            EventMsgDetailView EventMsgDetailView_Clone = new EventMsgDetailView();
            EventMsgDetailView_Clone.Set(this.EventMsgDetail);
            return EventMsgDetailView_Clone;
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
