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
///-- Create date: <Create Date 2010-05-31>
///-- Description:	<Description,Class :BankCodeView, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    [global::System.Serializable]
    public class BankCodeView : IDisposable, global::System.IEquatable<BankCodeView>
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


        protected BankCode n_oBankCode = null;
        #region BankCode
        [DataObjectField(true)]
        public virtual BankCode BankCode
        {
            get
            {
                if (n_oBankCode == null) { n_oBankCode = new BankCode(GetDB()); }
                return this.n_oBankCode;
            }
            set
            {
                this.n_oBankCode = value;
            }
        }
        #endregion BankCode


        #region BankCode_active
        [DataObjectField(true)]
        public virtual global::System.Nullable<bool> BankCode_active
        {
            get
            {
                return this.BankCode.active;
            }
            set
            {
                this.BankCode.active = value;
            }
        }
        #endregion BankCode_active


        #region BankCode_mid
        [DataObjectField(true)]
        public virtual global::System.Nullable<int> BankCode_mid
        {
            get
            {
                return this.BankCode.mid;
            }
            set
            {
                this.BankCode.mid = value;
            }
        }
        #endregion BankCode_mid


        #region BankCode_bank_name
        [DataObjectField(true)]
        public virtual string BankCode_bank_name
        {
            get
            {
                return this.BankCode.bank_name;
            }
            set
            {
                this.BankCode.bank_name = value;
            }
        }
        #endregion BankCode_bank_name


        #region BankCode_installment_period
        [DataObjectField(true)]
        public virtual string BankCode_installment_period
        {
            get
            {
                return this.BankCode.installment_period;
            }
            set
            {
                this.BankCode.installment_period = value;
            }
        }
        #endregion BankCode_installment_period


        #region BankCode_bank_code
        [DataObjectField(true)]
        public virtual string BankCode_bank_code
        {
            get
            {
                return this.BankCode.bank_code;
            }
            set
            {
                this.BankCode.bank_code = value;
            }
        }
        #endregion BankCode_bank_code


        #region BankCode_min_amount
        [DataObjectField(true)]
        public virtual string BankCode_min_amount
        {
            get
            {
                return this.BankCode.min_amount;
            }
            set
            {
                this.BankCode.min_amount = value;
            }
        }
        #endregion BankCode_min_amount

        #region Para
        public class Para
        {
            public const string BankCode = "BankCode";
            public const string BankCode_active = "BankCode_active";
            public const string BankCode_mid = "BankCode_mid";
            public const string BankCode_bank_name = "BankCode_bank_name";
            public const string BankCode_installment_period = "BankCode_installment_period";
            public const string BankCode_bank_code = "BankCode_bank_code";
            public const string BankCode_min_amount = "BankCode_min_amount";
        }
        #endregion Para

        #region Constructor & Destructor
        public BankCodeView() { }

        public BankCodeView(BankCode x_oBankCode)
        {
            BankCode = x_oBankCode;
        }

        ~BankCodeView() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public BankCode Get() { return this.BankCode; }

        public bool Set(BankCode value)
        {
            this.BankCode = value;
            return true;
        }
        #endregion


        #region IEquatable<BankCodeView> Members
        public bool Equals(BankCodeView x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.BankCode.Equals(x_oObj.BankCode)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.BankCode = null;
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
        public BankCodeView DeepClone()
        {
            BankCodeView BankCodeView_Clone = new BankCodeView();
            BankCodeView_Clone.Set(this.BankCode);
            return BankCodeView_Clone;
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
