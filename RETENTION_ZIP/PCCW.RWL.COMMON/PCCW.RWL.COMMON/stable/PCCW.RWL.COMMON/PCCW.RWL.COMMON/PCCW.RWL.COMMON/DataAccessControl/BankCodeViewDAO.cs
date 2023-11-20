using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
using System.ComponentModel;
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
using PCCW.RWL.CORE;
namespace PCCW.RWL.CORE
{

    public class BankCodeViewList : List<BankCodeView>
    {
        internal void Find(BankCodeView x_oBankCodeView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class BankCodeViewDAO
    {
        protected static BankCodeViewList _SourceData { get; set; }
        private BankCodeViewList _Data
        {
            get
            {
                if (_SourceData == null)
                {
                    _SourceData = this.GetDBAll();
                    return _SourceData;
                }
                else return _SourceData;
            }
            set { _SourceData = value; }
        }

        public BankCodeViewDAO()
        {
            if (_SourceData == null)
                _SourceData = this.GetDBAll(null, null, " mid desc");
        }

        public BankCodeViewList GetDBAll()
        {
            return this.GetDBAll(null, null, " mid desc");
        }

        public BankCodeViewList GetDBAll(string x_sStrWhere, string x_sStrGroup, string x_oStrOrderBy)
        {
            BankCodeViewList _oBankCodeViewList = new BankCodeViewList();
            BankCodeEntity[] _oBankCodeEntityArr = BankCodeBal.GetArrayObj(GetDB(), x_sStrWhere, x_sStrGroup, x_oStrOrderBy);
            if (_oBankCodeEntityArr != null)
            {
                for (int i = 0; i < _oBankCodeEntityArr.Length; i++)
                {
                    BankCodeView _oBankCodeView = new BankCodeView();
                    _oBankCodeView.Index = i;
                    _oBankCodeView.BankCode = (BankCode)_oBankCodeEntityArr[i];

                    _oBankCodeViewList.Add(_oBankCodeView);
                }
            }
            return _oBankCodeViewList;
        }


        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public BankCodeViewList FindAll()
        {
            if (this._Data == null)
                throw new NotImplementedException("ERROR:  _Data cannot be null value!");

            return this._Data;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public BankCodeViewList FindAll(string x_sStrWhere, string x_sStrGroup, string x_oStrOrderBy)
        {
            BankCodeViewList _oBankCodeViewList = this.GetDBAll(x_sStrWhere, x_sStrGroup, x_oStrOrderBy);
            if (_oBankCodeViewList == null)
                return new BankCodeViewList();

            return _oBankCodeViewList;
        }


        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteBankCodeView(BankCodeView x_oBankCodeView)
        {
            if (x_oBankCodeView == null)
                throw new NotImplementedException("ERROR:  x_oBankCodeView cannot be null value!");
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateBankCodeView(BankCodeView x_oBankCodeView)
        {
            if (x_oBankCodeView == null)
                throw new NotImplementedException("ERROR:  x_oBankCodeView cannot be null value!");


            bool _bSyncFlag = false;
            if (_SourceData == null) { _SourceData = this.GetDBAll(); }

            if (_SourceData.Count > x_oBankCodeView.Index && x_oBankCodeView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].BankCode_mid == x_oBankCodeView.BankCode_mid)
                    {
                        BankCodeView _oBankCodeView = _SourceData[i];
                        if (x_oBankCodeView.BankCode.active == true){
                            _oBankCodeView.BankCode.active = true;
                        }else{
                            _oBankCodeView.BankCode.active = false;
                        }
                        _oBankCodeView.BankCode.bank_code = x_oBankCodeView.BankCode.bank_code;
                        _oBankCodeView.BankCode.bank_name = x_oBankCodeView.BankCode.bank_name;
                        
                        _oBankCodeView.BankCode.installment_period = x_oBankCodeView.BankCode.installment_period;
                        _oBankCodeView.BankCode.min_amount = x_oBankCodeView.BankCode.min_amount;

                        _oBankCodeView.BankCode.Save();

                        _bSyncFlag = false;
                        break;
                    }
                    else
                    {
                        _bSyncFlag = true;
                    }
                }
            }
            else
                _bSyncFlag = true;

            if (_bSyncFlag)
            {
                _SourceData = this.GetDBAll();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertBankCodeView(BankCodeView x_oBankCodeView)
        {
            if (x_oBankCodeView == null)
                throw new NotImplementedException("ERROR:  x_oBankCodeView cannot be null value!");

            BankCodeBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), x_oBankCodeView.BankCode);
            _SourceData = this.GetDBAll();

        }


        public MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }

    }
}
