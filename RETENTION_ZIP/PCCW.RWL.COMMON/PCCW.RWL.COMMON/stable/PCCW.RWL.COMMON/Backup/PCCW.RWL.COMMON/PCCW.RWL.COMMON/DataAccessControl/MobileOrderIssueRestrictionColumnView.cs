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
///-- Create date: <Create Date 2010-12-21>
///-- Description:	<Description,Class :MobileOrderIssueRestrictionColumnView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class MobileOrderIssueRestrictionColumnView : IDisposable, global::System.IEquatable<MobileOrderIssueRestrictionColumnView>
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


        protected MobileOrderIssueRestrictionColumn n_oMobileOrderIssueRestrictionColumn = null;
        #region MobileOrderIssueRestrictionColumn
        [DataObjectField(true)]
        public virtual MobileOrderIssueRestrictionColumn MobileOrderIssueRestrictionColumn
        {
            get
            {
                if (n_oMobileOrderIssueRestrictionColumn == null) { n_oMobileOrderIssueRestrictionColumn = new MobileOrderIssueRestrictionColumn(GetDB()); }
                return this.n_oMobileOrderIssueRestrictionColumn;
            }
            set
            {
                this.n_oMobileOrderIssueRestrictionColumn = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn


        #region MobileOrderIssueRestrictionColumn_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> MobileOrderIssueRestrictionColumn_active
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.active;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.active = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_active


        #region MobileOrderIssueRestrictionColumn_cdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> MobileOrderIssueRestrictionColumn_cdate
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.cdate;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.cdate = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_cdate


        #region MobileOrderIssueRestrictionColumn_cid
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestrictionColumn_cid
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.cid;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.cid = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_cid


        #region MobileOrderIssueRestrictionColumn_restriction_id
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> MobileOrderIssueRestrictionColumn_restriction_id
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.restriction_id;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.restriction_id = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_restriction_id


        #region MobileOrderIssueRestrictionColumn_restriction_column
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestrictionColumn_restriction_column
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.restriction_column;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.restriction_column = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_restriction_column


        #region MobileOrderIssueRestrictionColumn_restriction_value
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestrictionColumn_restriction_value
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.restriction_value;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.restriction_value = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_restriction_value


        #region MobileOrderIssueRestrictionColumn_restriction_table
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestrictionColumn_restriction_table
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.restriction_table;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.restriction_table = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_restriction_table


        #region MobileOrderIssueRestrictionColumn_action_type
        [DataObjectField(true)]
        public virtual string MobileOrderIssueRestrictionColumn_action_type
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.action_type;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.action_type = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_action_type


        #region MobileOrderIssueRestrictionColumn_mid
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> MobileOrderIssueRestrictionColumn_mid
        {
            get
            {
                return this.MobileOrderIssueRestrictionColumn.mid;
            }
            set
            {
                this.MobileOrderIssueRestrictionColumn.mid = value;
            }
        }
        #endregion MobileOrderIssueRestrictionColumn_mid

        #region Para
        public class Para
        {
            public const string MobileOrderIssueRestrictionColumn = "MobileOrderIssueRestrictionColumn";
            public const string MobileOrderIssueRestrictionColumn_active = "MobileOrderIssueRestrictionColumn_active";
            public const string MobileOrderIssueRestrictionColumn_cdate = "MobileOrderIssueRestrictionColumn_cdate";
            public const string MobileOrderIssueRestrictionColumn_cid = "MobileOrderIssueRestrictionColumn_cid";
            public const string MobileOrderIssueRestrictionColumn_restriction_id = "MobileOrderIssueRestrictionColumn_restriction_id";
            public const string MobileOrderIssueRestrictionColumn_restriction_column = "MobileOrderIssueRestrictionColumn_restriction_column";
            public const string MobileOrderIssueRestrictionColumn_restriction_value = "MobileOrderIssueRestrictionColumn_restriction_value";
            public const string MobileOrderIssueRestrictionColumn_restriction_table = "MobileOrderIssueRestrictionColumn_restriction_table";
            public const string MobileOrderIssueRestrictionColumn_action_type = "MobileOrderIssueRestrictionColumn_action_type";
            public const string MobileOrderIssueRestrictionColumn_mid = "MobileOrderIssueRestrictionColumn_mid";
        }
        #endregion Para

        #region Constructor & Destructor
        public MobileOrderIssueRestrictionColumnView() { }

        public MobileOrderIssueRestrictionColumnView(MobileOrderIssueRestrictionColumn x_oMobileOrderIssueRestrictionColumn)
        {
            MobileOrderIssueRestrictionColumn = x_oMobileOrderIssueRestrictionColumn;
        }

        ~MobileOrderIssueRestrictionColumnView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public MobileOrderIssueRestrictionColumn Get() { return this.MobileOrderIssueRestrictionColumn; }

        public bool Set(MobileOrderIssueRestrictionColumn value)
        {
            this.MobileOrderIssueRestrictionColumn = value;
            return true;
        }
        #endregion


        #region IEquatable<MobileOrderIssueRestrictionColumnView> Members
        public bool Equals(MobileOrderIssueRestrictionColumnView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.MobileOrderIssueRestrictionColumn.Equals(x_oObj.MobileOrderIssueRestrictionColumn)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.MobileOrderIssueRestrictionColumn = null;
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
        public MobileOrderIssueRestrictionColumnView DeepClone()
        {
            MobileOrderIssueRestrictionColumnView MobileOrderIssueRestrictionColumnView_Clone = new MobileOrderIssueRestrictionColumnView();
            MobileOrderIssueRestrictionColumnView_Clone.Set(this.MobileOrderIssueRestrictionColumn);
            return MobileOrderIssueRestrictionColumnView_Clone;
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
