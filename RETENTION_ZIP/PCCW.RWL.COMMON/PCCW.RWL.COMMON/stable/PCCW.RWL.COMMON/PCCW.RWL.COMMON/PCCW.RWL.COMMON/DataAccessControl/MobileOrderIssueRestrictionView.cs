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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Class :MobileOrderIssueRestrictionView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class MobileOrderIssueRestrictionView : IDisposable, global::System.IEquatable<MobileOrderIssueRestrictionView>
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


        protected MobileOrderIssueRestriction n_oMobileOrderIssueRestriction = null;
        #region MobileOrderIssueRestriction
        [DataObjectField(true)]
        public virtual MobileOrderIssueRestriction MobileOrderIssueRestriction
        {
            get
            {
                if (n_oMobileOrderIssueRestriction == null) { n_oMobileOrderIssueRestriction = new MobileOrderIssueRestriction(GetDB()); }
                return this.n_oMobileOrderIssueRestriction;
            }
            set
            {
                this.n_oMobileOrderIssueRestriction = value;
            }
        }
        #endregion MobileOrderIssueRestriction


        #region MobileOrderIssueRestriction_name
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestriction_name
        {
            get
            {
                return this.MobileOrderIssueRestriction.name;
            }
            set
            {
                this.MobileOrderIssueRestriction.name = value;
            }
        }
        #endregion MobileOrderIssueRestriction_name


        #region MobileOrderIssueRestriction_cdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> MobileOrderIssueRestriction_cdate
        {
            get
            {
                return this.MobileOrderIssueRestriction.cdate;
            }
            set
            {
                this.MobileOrderIssueRestriction.cdate = value;
            }
        }
        #endregion MobileOrderIssueRestriction_cdate


        #region MobileOrderIssueRestriction_cid
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestriction_cid
        {
            get
            {
                return this.MobileOrderIssueRestriction.cid;
            }
            set
            {
                this.MobileOrderIssueRestriction.cid = value;
            }
        }
        #endregion MobileOrderIssueRestriction_cid




        #region MobileOrderIssueRestriction_type
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestriction_type
        {
            get
            {
                return this.MobileOrderIssueRestriction.type;
            }
            set
            {
                this.MobileOrderIssueRestriction.type = value;
            }
        }
        #endregion MobileOrderIssueRestriction_type


        #region MobileOrderIssueRestriction_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> MobileOrderIssueRestriction_active
        {
            get
            {
                return this.MobileOrderIssueRestriction.active;
            }
            set
            {
                this.MobileOrderIssueRestriction.active = value;
            }
        }
        #endregion MobileOrderIssueRestriction_active


        #region MobileOrderIssueRestriction_restriction_id
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> MobileOrderIssueRestriction_restriction_id
        {
            get
            {
                return this.MobileOrderIssueRestriction.restriction_id;
            }
            set
            {
                this.MobileOrderIssueRestriction.restriction_id = value;
            }
        }
        #endregion MobileOrderIssueRestriction_restriction_id

        #region Para
        public class Para
        {
            public const string MobileOrderIssueRestriction = "MobileOrderIssueRestriction";
            public const string MobileOrderIssueRestriction_name = "MobileOrderIssueRestriction_name";
            public const string MobileOrderIssueRestriction_cdate = "MobileOrderIssueRestriction_cdate";
            public const string MobileOrderIssueRestriction_cid = "MobileOrderIssueRestriction_cid";
            public const string MobileOrderIssueRestriction_type = "MobileOrderIssueRestriction_type";
            public const string MobileOrderIssueRestriction_active = "MobileOrderIssueRestriction_active";
            public const string MobileOrderIssueRestriction_restriction_id = "MobileOrderIssueRestriction_restriction_id";
        }
        #endregion Para

        #region Constructor & Destructor
        public MobileOrderIssueRestrictionView() { }

        public MobileOrderIssueRestrictionView(MobileOrderIssueRestriction x_oMobileOrderIssueRestriction)
        {
            MobileOrderIssueRestriction = x_oMobileOrderIssueRestriction;
        }

        ~MobileOrderIssueRestrictionView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public MobileOrderIssueRestriction Get() { return this.MobileOrderIssueRestriction; }

        public bool Set(MobileOrderIssueRestriction value)
        {
            this.MobileOrderIssueRestriction = value;
            return true;
        }
        #endregion


        #region IEquatable<MobileOrderIssueRestrictionView> Members
        public bool Equals(MobileOrderIssueRestrictionView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.MobileOrderIssueRestriction.Equals(x_oObj.MobileOrderIssueRestriction)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.MobileOrderIssueRestriction = null;
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
        public MobileOrderIssueRestrictionView DeepClone()
        {
            MobileOrderIssueRestrictionView MobileOrderIssueRestrictionView_Clone = new MobileOrderIssueRestrictionView();
            MobileOrderIssueRestrictionView_Clone.Set(this.MobileOrderIssueRestriction);
            return MobileOrderIssueRestrictionView_Clone;
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
