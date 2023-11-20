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
///-- Create date: <Create Date 2010-12-21>
///-- Description:	<Description,Class :MobileOrderIssueRestrictionProfileView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class MobileOrderIssueRestrictionProfileView : IDisposable, global::System.IEquatable<MobileOrderIssueRestrictionProfileView>
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


        protected MobileOrderIssueRestrictionProfile n_oMobileOrderIssueRestrictionProfile = null;
        #region MobileOrderIssueRestrictionProfile
        [DataObjectField(true)]
        public virtual MobileOrderIssueRestrictionProfile MobileOrderIssueRestrictionProfile
        {
            get
            {
                if (n_oMobileOrderIssueRestrictionProfile == null) { n_oMobileOrderIssueRestrictionProfile = new MobileOrderIssueRestrictionProfile(GetDB()); }
                return this.n_oMobileOrderIssueRestrictionProfile;
            }
            set
            {
                this.n_oMobileOrderIssueRestrictionProfile = value;
            }
        }
        #endregion MobileOrderIssueRestrictionProfile


        #region MobileOrderIssueRestrictionProfile_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> MobileOrderIssueRestrictionProfile_active
        {
            get
            {
                return this.MobileOrderIssueRestrictionProfile.active;
            }
            set
            {
                this.MobileOrderIssueRestrictionProfile.active = value;
            }
        }
        #endregion MobileOrderIssueRestrictionProfile_active


        #region MobileOrderIssueRestrictionProfile_cdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> MobileOrderIssueRestrictionProfile_cdate
        {
            get
            {
                return this.MobileOrderIssueRestrictionProfile.cdate;
            }
            set
            {
                this.MobileOrderIssueRestrictionProfile.cdate = value;
            }
        }
        #endregion MobileOrderIssueRestrictionProfile_cdate


        #region MobileOrderIssueRestrictionProfile_mrt_no
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> MobileOrderIssueRestrictionProfile_mrt_no
        {
            get
            {
                return this.MobileOrderIssueRestrictionProfile.mrt_no;
            }
            set
            {
                this.MobileOrderIssueRestrictionProfile.mrt_no = value;
            }
        }
        #endregion MobileOrderIssueRestrictionProfile_mrt_no


        #region MobileOrderIssueRestrictionProfile_cid
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestrictionProfile_cid
        {
            get
            {
                return this.MobileOrderIssueRestrictionProfile.cid;
            }
            set
            {
                this.MobileOrderIssueRestrictionProfile.cid = value;
            }
        }
        #endregion MobileOrderIssueRestrictionProfile_cid


        #region MobileOrderIssueRestrictionProfile_mid
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> MobileOrderIssueRestrictionProfile_mid
        {
            get
            {
                return this.MobileOrderIssueRestrictionProfile.mid;
            }
            set
            {
                this.MobileOrderIssueRestrictionProfile.mid = value;
            }
        }
        #endregion MobileOrderIssueRestrictionProfile_mid


        #region MobileOrderIssueRestrictionProfile_restriction_id
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> MobileOrderIssueRestrictionProfile_restriction_id
        {
            get
            {
                return this.MobileOrderIssueRestrictionProfile.restriction_id;
            }
            set
            {
                this.MobileOrderIssueRestrictionProfile.restriction_id = value;
            }
        }
        #endregion MobileOrderIssueRestrictionProfile_restriction_id

        #region Para
        public class Para
        {
            public const string MobileOrderIssueRestrictionProfile = "MobileOrderIssueRestrictionProfile";
            public const string MobileOrderIssueRestrictionProfile_active = "MobileOrderIssueRestrictionProfile_active";
            public const string MobileOrderIssueRestrictionProfile_cdate = "MobileOrderIssueRestrictionProfile_cdate";
            public const string MobileOrderIssueRestrictionProfile_mrt_no = "MobileOrderIssueRestrictionProfile_mrt_no";
            public const string MobileOrderIssueRestrictionProfile_cid = "MobileOrderIssueRestrictionProfile_cid";
            public const string MobileOrderIssueRestrictionProfile_mid = "MobileOrderIssueRestrictionProfile_mid";
            public const string MobileOrderIssueRestrictionProfile_restriction_id = "MobileOrderIssueRestrictionProfile_restriction_id";
        }
        #endregion Para

        #region Constructor & Destructor
        public MobileOrderIssueRestrictionProfileView() { }

        public MobileOrderIssueRestrictionProfileView(MobileOrderIssueRestrictionProfile x_oMobileOrderIssueRestrictionProfile)
        {
            MobileOrderIssueRestrictionProfile = x_oMobileOrderIssueRestrictionProfile;
        }

        ~MobileOrderIssueRestrictionProfileView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public MobileOrderIssueRestrictionProfile Get() { return this.MobileOrderIssueRestrictionProfile; }

        public bool Set(MobileOrderIssueRestrictionProfile value)
        {
            this.MobileOrderIssueRestrictionProfile = value;
            return true;
        }
        #endregion


        #region IEquatable<MobileOrderIssueRestrictionProfileView> Members
        public bool Equals(MobileOrderIssueRestrictionProfileView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.MobileOrderIssueRestrictionProfile.Equals(x_oObj.MobileOrderIssueRestrictionProfile)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.MobileOrderIssueRestrictionProfile = null;
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
        public MobileOrderIssueRestrictionProfileView DeepClone()
        {
            MobileOrderIssueRestrictionProfileView MobileOrderIssueRestrictionProfileView_Clone = new MobileOrderIssueRestrictionProfileView();
            MobileOrderIssueRestrictionProfileView_Clone.Set(this.MobileOrderIssueRestrictionProfile);
            return MobileOrderIssueRestrictionProfileView_Clone;
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
