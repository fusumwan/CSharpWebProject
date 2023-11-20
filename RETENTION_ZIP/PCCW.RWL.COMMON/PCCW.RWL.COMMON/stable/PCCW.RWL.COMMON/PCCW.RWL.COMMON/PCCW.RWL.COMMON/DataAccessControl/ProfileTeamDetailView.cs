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
///-- Create date: <Create Date 2010-03-26>
///-- Description:	<Description,Class :ProfileTeamDetailView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class ProfileTeamDetailView : IDisposable, global::System.IEquatable<ProfileTeamDetailView>
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


        protected ProfileTeamDetail n_oProfileTeamDetail = null;
        #region ProfileTeamDetail
        [DataObjectField(true)]
        public virtual ProfileTeamDetail ProfileTeamDetail
        {
            get
            {
                if (n_oProfileTeamDetail == null) { n_oProfileTeamDetail = new ProfileTeamDetail(GetDB()); }
                return this.n_oProfileTeamDetail;
            }
            set
            {
                this.n_oProfileTeamDetail = value;
            }
        }
        #endregion ProfileTeamDetail


        #region ProfileTeamDetail_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> ProfileTeamDetail_active
        {
            get
            {
                return this.ProfileTeamDetail.active;
            }
            set
            {
                this.ProfileTeamDetail.active = value;
            }
        }
        #endregion ProfileTeamDetail_active


        #region ProfileTeamDetail_teamcode
        [DataObjectField(true)]
        public virtual string ProfileTeamDetail_teamcode
        {
            get
            {
                return this.ProfileTeamDetail.teamcode;
            }
            set
            {
                this.ProfileTeamDetail.teamcode = value;
            }
        }
        #endregion ProfileTeamDetail_teamcode


        #region ProfileTeamDetail_mid
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> ProfileTeamDetail_mid
        {
            get
            {
                return this.ProfileTeamDetail.mid;
            }
            set
            {
                this.ProfileTeamDetail.mid = value;
            }
        }
        #endregion ProfileTeamDetail_mid


        #region ProfileTeamDetail_salesmancode
        [DataObjectField(true)]
        public virtual string ProfileTeamDetail_salesmancode
        {
            get
            {
                return this.ProfileTeamDetail.salesmancode;
            }
            set
            {
                this.ProfileTeamDetail.salesmancode = value;
            }
        }
        #endregion ProfileTeamDetail_salesmancode

        #region ProfileTeamDetail_staff_no
        [DataObjectField(true)]
        public virtual string ProfileTeamDetail_staff_no
        {
            get
            {
                return this.ProfileTeamDetail.staff_no;
            }
            set
            {
                this.ProfileTeamDetail.staff_no = value;
            }
        }
        #endregion ProfileTeamDetail_staff_no

        #region Para
        public class Para
        {
            public const string ProfileTeamDetail = "ProfileTeamDetail";
            public const string ProfileTeamDetail_active = "ProfileTeamDetail_active";
            public const string ProfileTeamDetail_teamcode = "ProfileTeamDetail_teamcode";
            public const string ProfileTeamDetail_mid = "ProfileTeamDetail_mid";
            public const string ProfileTeamDetail_salesmancode = "ProfileTeamDetail_salesmancode";
            public const string ProfileTeamDetail_staff_no = "ProfileTeamDetail_staff_no";
        }
        #endregion Para

        #region Constructor & Destructor
        public ProfileTeamDetailView() { }

        public ProfileTeamDetailView(ProfileTeamDetail x_oProfileTeamDetail)
        {
            ProfileTeamDetail = x_oProfileTeamDetail;
        }

        ~ProfileTeamDetailView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public ProfileTeamDetail Get() { return this.ProfileTeamDetail; }

        public bool Set(ProfileTeamDetail value)
        {
            this.ProfileTeamDetail = value;
            return true;
        }
        #endregion


        #region IEquatable<ProfileTeamDetailView> Members
        public bool Equals(ProfileTeamDetailView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.ProfileTeamDetail.Equals(x_oObj.ProfileTeamDetail)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.ProfileTeamDetail = null;
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
            return SYSConn<MSSQLConnect>.Connect(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        }


        #region Clone
        public ProfileTeamDetailView DeepClone()
        {
            ProfileTeamDetailView ProfileTeamDetailView_Clone = new ProfileTeamDetailView();
            ProfileTeamDetailView_Clone.Set(this.ProfileTeamDetail);
            return ProfileTeamDetailView_Clone;
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
