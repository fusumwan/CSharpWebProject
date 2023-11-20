using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
namespace PCCW.RWL.CORE
{

    public class MobileOrderSyncSearchViewList : List<MobileOrderSyncSearchView>
    {
        internal void Find(MobileOrderSyncSearchView x_oMobileOrderSyncSearchView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class MobileOrderSyncSearchViewDAO
    {
        protected static MobileOrderSyncSearchViewList _SourceData { get; set; }
        private MobileOrderSyncSearchViewList _Data
        {
            get
            {
                if (_SourceData == null)
                {
                    return this.GetDBAll(string.Empty);
                }
                else return _SourceData;
            }
            set { _SourceData = value; }
        }

        public MobileOrderSyncSearchViewDAO()
        {
        }

        public MobileOrderSyncSearchViewList GetDBAll(string x_sFilterExpression)
        {
            MobileOrderSyncSearchViewList _oMobileOrderSyncSearchViewList = new MobileOrderSyncSearchViewList();
            if (!string.IsNullOrEmpty(x_sFilterExpression))
            {
                MobileOrderSyncSearchEntity[] _oMobileOrderSyncSearchArr = MobileOrderSyncSearchBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), x_sFilterExpression, null, "order_id desc");
                if (_oMobileOrderSyncSearchArr != null)
                {
                    if (_oMobileOrderSyncSearchArr.Length > 0)
                    {
                        int _iIndex = 0;
                        for (int i = 0; i < _oMobileOrderSyncSearchArr.Length; i++)
                        {
                            
                            if (!_oMobileOrderSyncSearchArr[i].GetEdf_no().Equals(string.Empty))
                            {
                                _iIndex += 1;
                                StringBuilder _oQuery = new StringBuilder();
                                MobileOrderSyncSearchView _oMobileOrderSyncSearchView = new MobileOrderSyncSearchView();
                                _oQuery.Append("SELECT SIM_ITEM_CODE FROM SUNDAY_FORM WHERE referenceno='" + _oMobileOrderSyncSearchArr[i].GetEdf_no() + "' AND CREATED_BY='CC RET' AND ROWNUM<=1");
                                _oMobileOrderSyncSearchView.Edf_sim_item_code = SYSConn<ODBCConnect>.Connect().GetExecuteScalar(_oQuery.ToString());


                                if(_oMobileOrderSyncSearchArr[i].order_id!=null)
                                    _oMobileOrderSyncSearchView.Record_id = ((int)_oMobileOrderSyncSearchArr[i].order_id) + 100000;
                                _oMobileOrderSyncSearchView.MobileOrderSyncSearch = (MobileOrderSyncSearch)_oMobileOrderSyncSearchArr[i];
                                
                                _oMobileOrderSyncSearchView.Index = _iIndex;
                                _oMobileOrderSyncSearchViewList.Add(_oMobileOrderSyncSearchView);
                            }
                        }
                    }
                    return _oMobileOrderSyncSearchViewList;
                }
            }
            return _oMobileOrderSyncSearchViewList;
        }


        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public MobileOrderSyncSearchViewList FindAll()
        {
            return this._Data;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public MobileOrderSyncSearchViewList FindAll(string x_sFilterExpression)
        {
            return GetDBAll(x_sFilterExpression);
        }


        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteMobileOrderSyncSearchView(MobileOrderSyncSearchView x_oMobileOrderSyncSearchView)
        {
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateMobileOrderSyncSearchView(MobileOrderSyncSearchView x_oMobileOrderSyncSearchView)
        {
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertMobileOrderSyncSearchView(MobileOrderSyncSearchView x_oMobileOrderSyncSearchView)
        {
        }


        public MSSQLConnect GetDB()
        {
            return SYSConn<MSSQLConnect>.Connect(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        }

    }
}
