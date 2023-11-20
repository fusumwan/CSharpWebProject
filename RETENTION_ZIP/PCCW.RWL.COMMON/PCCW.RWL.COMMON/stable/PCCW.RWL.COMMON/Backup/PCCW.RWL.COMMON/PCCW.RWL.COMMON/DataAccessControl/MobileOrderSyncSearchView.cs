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
///-- Create date: <Create Date 2010-12-10>
///-- Description:	<Description,Class :MobileOrderSyncSearchView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class MobileOrderSyncSearchView : IDisposable, global::System.IEquatable<MobileOrderSyncSearchView>
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


        protected string n_sEdf_sim_item_code = global::System.String.Empty;
        #region Edf_sim_item_code
        [DataObjectField(true)]
        public virtual string Edf_sim_item_code
        {
            get
            {
                return this.n_sEdf_sim_item_code;
            }
            set
            {
                this.n_sEdf_sim_item_code = value;
            }
        }
        #endregion Edf_sim_item_code


        protected MobileOrderSyncSearch n_oMobileOrderSyncSearch = null;
        #region MobileOrderSyncSearch
        [DataObjectField(true)]
        public virtual MobileOrderSyncSearch MobileOrderSyncSearch
        {
            get
            {
                if (n_oMobileOrderSyncSearch == null) { n_oMobileOrderSyncSearch = new MobileOrderSyncSearch(GetDB()); }
                return this.n_oMobileOrderSyncSearch;
            }
            set
            {
                this.n_oMobileOrderSyncSearch = value;
            }
        }
        #endregion MobileOrderSyncSearch


        protected int? n_iRecord_id = null;
        #region Record_id
        [DataObjectField(true)]
        public virtual int? Record_id
        {
            get
            {
                return this.n_iRecord_id;
            }
            set
            {
                this.n_iRecord_id = value;
            }
        }
        #endregion Record_id


        #region MobileOrderSyncSearch_edf_no
        [DataObjectField(true)]
        public virtual string MobileOrderSyncSearch_edf_no
        {
            get
            {
                return this.MobileOrderSyncSearch.edf_no;
            }
            set
            {
                this.MobileOrderSyncSearch.edf_no = value;
            }
        }
        #endregion MobileOrderSyncSearch_edf_no


        #region MobileOrderSyncSearch_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> MobileOrderSyncSearch_active
        {
            get
            {
                return this.MobileOrderSyncSearch.active;
            }
            set
            {
                this.MobileOrderSyncSearch.active = value;
            }
        }
        #endregion MobileOrderSyncSearch_active


        #region MobileOrderSyncSearch_sku
        [DataObjectField(true)]
        public virtual string MobileOrderSyncSearch_sku
        {
            get
            {
                return this.MobileOrderSyncSearch.sku;
            }
            set
            {
                this.MobileOrderSyncSearch.sku = value;
            }
        }
        #endregion MobileOrderSyncSearch_sku


        #region MobileOrderSyncSearch_sim_item_name
        [DataObjectField(true)]
        public virtual string MobileOrderSyncSearch_sim_item_name
        {
            get
            {
                return this.MobileOrderSyncSearch.sim_item_name;
            }
            set
            {
                this.MobileOrderSyncSearch.sim_item_name = value;
            }
        }
        #endregion MobileOrderSyncSearch_sim_item_name


        #region MobileOrderSyncSearch_d_date
        [DataObjectField(true)]
        public virtual global::System.Nullable<DateTime> MobileOrderSyncSearch_d_date
        {
            get
            {
                return this.MobileOrderSyncSearch.d_date;
            }
            set
            {
                this.MobileOrderSyncSearch.d_date = value;
            }
        }
        #endregion MobileOrderSyncSearch_d_date


        #region MobileOrderSyncSearch_program
        [DataObjectField(true)]
        public virtual string MobileOrderSyncSearch_program
        {
            get
            {
                return this.MobileOrderSyncSearch.program;
            }
            set
            {
                this.MobileOrderSyncSearch.program = value;
            }
        }
        #endregion MobileOrderSyncSearch_program


        #region MobileOrderSyncSearch_order_id
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> MobileOrderSyncSearch_order_id
        {
            get
            {
                return this.MobileOrderSyncSearch.order_id;
            }
            set
            {
                this.MobileOrderSyncSearch.order_id = value;
            }
        }
        #endregion MobileOrderSyncSearch_order_id


        #region MobileOrderSyncSearch_sim_item_code
        [DataObjectField(true)]
        public virtual string MobileOrderSyncSearch_sim_item_code
        {
            get
            {
                return this.MobileOrderSyncSearch.sim_item_code;
            }
            set
            {
                this.MobileOrderSyncSearch.sim_item_code = value;
            }
        }
        #endregion MobileOrderSyncSearch_sim_item_code


        #region MobileOrderSyncSearch_imei_no
        [DataObjectField(true)]
        public virtual string MobileOrderSyncSearch_imei_no
        {
            get
            {
                return this.MobileOrderSyncSearch.imei_no;
            }
            set
            {
                this.MobileOrderSyncSearch.imei_no = value;
            }
        }
        #endregion MobileOrderSyncSearch_imei_no

        #region Para
        public class Para
        {
            public const string Edf_sim_item_code = "Edf_sim_item_code";
            public const string MobileOrderSyncSearch = "MobileOrderSyncSearch";
            public const string Record_id = "Record_id";
            public const string MobileOrderSyncSearch_edf_no = "MobileOrderSyncSearch_edf_no";
            public const string MobileOrderSyncSearch_active = "MobileOrderSyncSearch_active";
            public const string MobileOrderSyncSearch_sku = "MobileOrderSyncSearch_sku";
            public const string MobileOrderSyncSearch_sim_item_name = "MobileOrderSyncSearch_sim_item_name";
            public const string MobileOrderSyncSearch_d_date = "MobileOrderSyncSearch_d_date";
            public const string MobileOrderSyncSearch_program = "MobileOrderSyncSearch_program";
            public const string MobileOrderSyncSearch_order_id = "MobileOrderSyncSearch_order_id";
            public const string MobileOrderSyncSearch_sim_item_code = "MobileOrderSyncSearch_sim_item_code";
            public const string MobileOrderSyncSearch_imei_no = "MobileOrderSyncSearch_imei_no";
        }
        #endregion Para

        #region Constructor & Destructor
        public MobileOrderSyncSearchView() { }

        public MobileOrderSyncSearchView(string x_sEdf_sim_item_code, MobileOrderSyncSearch x_oMobileOrderSyncSearch, int x_iRecord_id)
        {
            Edf_sim_item_code = x_sEdf_sim_item_code;
            MobileOrderSyncSearch = x_oMobileOrderSyncSearch;
            Record_id = x_iRecord_id;
        }

        ~MobileOrderSyncSearchView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetEdf_sim_item_code() { return this.Edf_sim_item_code; }
        public MobileOrderSyncSearch Get() { return this.MobileOrderSyncSearch; }
        public int? GetRecord_id() { return this.Record_id; }

        public bool SetEdf_sim_item_code(string value)
        {
            this.Edf_sim_item_code = value;
            return true;
        }
        public bool Set(MobileOrderSyncSearch value)
        {
            this.MobileOrderSyncSearch = value;
            return true;
        }
        public bool SetRecord_id(int? value)
        {
            this.Record_id = value;
            return true;
        }
        #endregion


        #region IEquatable<MobileOrderSyncSearchView> Members
        public bool Equals(MobileOrderSyncSearchView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Edf_sim_item_code.Equals(x_oObj.Edf_sim_item_code)) { return false; }
            if (!this.MobileOrderSyncSearch.Equals(x_oObj.MobileOrderSyncSearch)) { return false; }
            if (!this.Record_id.Equals(x_oObj.Record_id)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Edf_sim_item_code = global::System.String.Empty;
            this.MobileOrderSyncSearch = null;
            this.Record_id = -1;
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
        public MobileOrderSyncSearchView DeepClone()
        {
            MobileOrderSyncSearchView MobileOrderSyncSearchView_Clone = new MobileOrderSyncSearchView();
            MobileOrderSyncSearchView_Clone.SetEdf_sim_item_code(this.Edf_sim_item_code);
            MobileOrderSyncSearchView_Clone.Set(this.MobileOrderSyncSearch);
            MobileOrderSyncSearchView_Clone.SetRecord_id(this.Record_id);
            return MobileOrderSyncSearchView_Clone;
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
