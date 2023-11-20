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
///-- Create date: <Create Date 2010-06-04>
///-- Description:	<Description,Class :BusinessVasDefaultSetView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class BusinessVasDefaultSetView : IDisposable, global::System.IEquatable<BusinessVasDefaultSetView>
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


        protected BusinessVasDefaultSet n_oBusinessVasDefaultSet = null;


        #region BusinessVasDefaultSet_BusinessVas_vas_name
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_BusinessVas_vas_name
        {
            get
            {
                return this.BusinessVasDefaultSet.BusinessVas.vas_name;
            }
            set
            {
                this.BusinessVasDefaultSet.BusinessVas.vas_name = value;
            }
        }
        #endregion BusinessVasDefaultSet_BusinessVas_vas_name

        #region BusinessVasDefaultSet
        [DataObjectField(true)]
        public virtual BusinessVasDefaultSet BusinessVasDefaultSet
        {
            get
            {
                if (n_oBusinessVasDefaultSet == null) { n_oBusinessVasDefaultSet = new BusinessVasDefaultSet(GetDB()); }
                return this.n_oBusinessVasDefaultSet;
            }
            set
            {
                this.n_oBusinessVasDefaultSet = value;
            }
        }
        #endregion BusinessVasDefaultSet


        #region BusinessVasDefaultSet_display2
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> BusinessVasDefaultSet_display2
        {
            get
            {
                return this.BusinessVasDefaultSet.display2;
            }
            set
            {
                this.BusinessVasDefaultSet.display2 = value;
            }
        }
        #endregion BusinessVasDefaultSet_display2


        #region BusinessVasDefaultSet_mid
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> BusinessVasDefaultSet_mid
        {
            get
            {
                return this.BusinessVasDefaultSet.mid;
            }
            set
            {
                this.BusinessVasDefaultSet.mid = value;
            }
        }
        #endregion BusinessVasDefaultSet_mid


        #region BusinessVasDefaultSet_cdate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> BusinessVasDefaultSet_cdate
        {
            get
            {
                return this.BusinessVasDefaultSet.cdate;
            }
            set
            {
                this.BusinessVasDefaultSet.cdate = value;
            }
        }
        #endregion BusinessVasDefaultSet_cdate


        #region BusinessVasDefaultSet_bundle_name
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_bundle_name
        {
            get
            {
                return this.BusinessVasDefaultSet.bundle_name;
            }
            set
            {
                this.BusinessVasDefaultSet.bundle_name = value;
            }
        }
        #endregion BusinessVasDefaultSet_bundle_name

        #region BusinessVasDefaultSet_hs_model
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_hs_model
        {
            get
            {
                return this.BusinessVasDefaultSet.hs_model;
            }
            set
            {
                this.BusinessVasDefaultSet.hs_model = value;
            }
        }
        #endregion BusinessVasDefaultSet_hs_model


        #region BusinessVasDefaultSet_value2
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_value2
        {
            get
            {
                return this.BusinessVasDefaultSet.value2;
            }
            set
            {
                this.BusinessVasDefaultSet.value2 = value;
            }
        }
        #endregion BusinessVasDefaultSet_value2


        #region BusinessVasDefaultSet_cid
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_cid
        {
            get
            {
                return this.BusinessVasDefaultSet.cid;
            }
            set
            {
                this.BusinessVasDefaultSet.cid = value;
            }
        }
        #endregion BusinessVasDefaultSet_cid


        #region BusinessVasDefaultSet_value1
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_value1
        {
            get
            {
                return this.BusinessVasDefaultSet.value1;
            }
            set
            {
                this.BusinessVasDefaultSet.value1 = value;
            }
        }
        #endregion BusinessVasDefaultSet_value1


        #region BusinessVasDefaultSet_program
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_program
        {
            get
            {
                return this.BusinessVasDefaultSet.program;
            }
            set
            {
                this.BusinessVasDefaultSet.program = value;
            }
        }
        #endregion BusinessVasDefaultSet_program


        #region BusinessVasDefaultSet_edate
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> BusinessVasDefaultSet_edate
        {
            get
            {
                return this.BusinessVasDefaultSet.edate;
            }
            set
            {
                this.BusinessVasDefaultSet.edate = value;
            }
        }
        #endregion BusinessVasDefaultSet_edate


        #region BusinessVasDefaultSet_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> BusinessVasDefaultSet_active
        {
            get
            {
                return this.BusinessVasDefaultSet.active;
            }
            set
            {
                this.BusinessVasDefaultSet.active = value;
            }
        }
        #endregion BusinessVasDefaultSet_active


        #region BusinessVasDefaultSet_trade_field
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_trade_field
        {
            get
            {
                return this.BusinessVasDefaultSet.trade_field;
            }
            set
            {
                this.BusinessVasDefaultSet.trade_field = value;
            }
        }
        #endregion BusinessVasDefaultSet_trade_field


        #region BusinessVasDefaultSet_con_per
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_con_per
        {
            get
            {
                return this.BusinessVasDefaultSet.con_per;
            }
            set
            {
                this.BusinessVasDefaultSet.con_per = value;
            }
        }
        #endregion BusinessVasDefaultSet_con_per


        #region BusinessVasDefaultSet_display1
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> BusinessVasDefaultSet_display1
        {
            get
            {
                return this.BusinessVasDefaultSet.display1;
            }
            set
            {
                this.BusinessVasDefaultSet.display1 = value;
            }
        }
        #endregion BusinessVasDefaultSet_display1


        #region BusinessVasDefaultSet_enabled2
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> BusinessVasDefaultSet_enabled2
        {
            get
            {
                return this.BusinessVasDefaultSet.enabled2;
            }
            set
            {
                this.BusinessVasDefaultSet.enabled2 = value;
            }
        }
        #endregion BusinessVasDefaultSet_enabled2


        #region BusinessVasDefaultSet_vas2
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_vas2
        {
            get
            {
                return this.BusinessVasDefaultSet.vas2;
            }
            set
            {
                this.BusinessVasDefaultSet.vas2 = value;
            }
        }
        #endregion BusinessVasDefaultSet_vas2


        #region BusinessVasDefaultSet_rate_plan
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_rate_plan
        {
            get
            {
                return this.BusinessVasDefaultSet.rate_plan;
            }
            set
            {
                this.BusinessVasDefaultSet.rate_plan = value;
            }
        }
        #endregion BusinessVasDefaultSet_rate_plan


        #region BusinessVasDefaultSet_issue_type
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_issue_type
        {
            get
            {
                return this.BusinessVasDefaultSet.issue_type;
            }
            set
            {
                this.BusinessVasDefaultSet.issue_type = value;
            }
        }
        #endregion BusinessVasDefaultSet_issue_type


        #region BusinessVasDefaultSet_enabled1
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> BusinessVasDefaultSet_enabled1
        {
            get
            {
                return this.BusinessVasDefaultSet.enabled1;
            }
            set
            {
                this.BusinessVasDefaultSet.enabled1 = value;
            }
        }
        #endregion BusinessVasDefaultSet_enabled1


        #region BusinessVasDefaultSet_vas1
        [DataObjectField(true)]
        public virtual string BusinessVasDefaultSet_vas1
        {
            get
            {
                return this.BusinessVasDefaultSet.vas1;
            }
            set
            {
                this.BusinessVasDefaultSet.vas1 = value;
            }
        }
        #endregion BusinessVasDefaultSet_vas1

        #region Para
        public class Para
        {
            public const string BusinessVasDefaultSet = "BusinessVasDefaultSet";
            public const string BusinessVasDefaultSet_display2 = "BusinessVasDefaultSet_display2";
            public const string BusinessVasDefaultSet_mid = "BusinessVasDefaultSet_mid";
            public const string BusinessVasDefaultSet_cdate = "BusinessVasDefaultSet_cdate";
            public const string BusinessVasDefaultSet_bundle_name = "BusinessVasDefaultSet_bundle_name";
            public const string BusinessVasDefaultSet_value2 = "BusinessVasDefaultSet_value2";
            public const string BusinessVasDefaultSet_cid = "BusinessVasDefaultSet_cid";
            public const string BusinessVasDefaultSet_value1 = "BusinessVasDefaultSet_value1";
            public const string BusinessVasDefaultSet_program = "BusinessVasDefaultSet_program";
            public const string BusinessVasDefaultSet_edate = "BusinessVasDefaultSet_edate";
            public const string BusinessVasDefaultSet_active = "BusinessVasDefaultSet_active";
            public const string BusinessVasDefaultSet_trade_field = "BusinessVasDefaultSet_trade_field";
            public const string BusinessVasDefaultSet_con_per = "BusinessVasDefaultSet_con_per";
            public const string BusinessVasDefaultSet_display1 = "BusinessVasDefaultSet_display1";
            public const string BusinessVasDefaultSet_enabled2 = "BusinessVasDefaultSet_enabled2";
            public const string BusinessVasDefaultSet_vas2 = "BusinessVasDefaultSet_vas2";
            public const string BusinessVasDefaultSet_rate_plan = "BusinessVasDefaultSet_rate_plan";
            public const string BusinessVasDefaultSet_enabled1 = "BusinessVasDefaultSet_enabled1";
            public const string BusinessVasDefaultSet_vas1 = "BusinessVasDefaultSet_vas1";
        }
        #endregion Para

        #region Constructor & Destructor
        public BusinessVasDefaultSetView() { }

        public BusinessVasDefaultSetView(BusinessVasDefaultSet x_oBusinessVasDefaultSet)
        {
            BusinessVasDefaultSet = x_oBusinessVasDefaultSet;
        }

        ~BusinessVasDefaultSetView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public BusinessVasDefaultSet Get() { return this.BusinessVasDefaultSet; }

        public bool Set(BusinessVasDefaultSet value)
        {
            this.BusinessVasDefaultSet = value;
            return true;
        }
        #endregion


        #region IEquatable<BusinessVasDefaultSetView> Members
        public bool Equals(BusinessVasDefaultSetView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.BusinessVasDefaultSet.Equals(x_oObj.BusinessVasDefaultSet)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.BusinessVasDefaultSet = null;
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
        public BusinessVasDefaultSetView DeepClone()
        {
            BusinessVasDefaultSetView BusinessVasDefaultSetView_Clone = new BusinessVasDefaultSetView();
            BusinessVasDefaultSetView_Clone.Set(this.BusinessVasDefaultSet);
            return BusinessVasDefaultSetView_Clone;
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
