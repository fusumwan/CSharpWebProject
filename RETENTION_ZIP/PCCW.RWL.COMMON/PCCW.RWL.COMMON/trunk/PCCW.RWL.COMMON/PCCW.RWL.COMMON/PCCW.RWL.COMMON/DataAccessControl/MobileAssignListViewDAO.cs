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
using System.Data.Odbc;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using PCCW.RWL.CORE;

public class MobileAssignListViewList : List<MobileAssignListView>
{
    internal void Find(MobileAssignListView x_oMobileAssignListView)
    {
        throw new NotImplementedException();
    }
};


[DataObject(true)]
public class MobileAssignListViewDAO
{
    protected static MobileAssignListViewList _SourceData { get; set; }
    protected static int? _Count { get; set; }
    private MobileAssignListViewList _Data
    {
        get
        {
            if (_SourceData == null)
            {
                return this.GetDBAll();
            }
            else return _SourceData;
        }
        set { _SourceData = value; }
    }


    public MobileAssignListViewDAO()
    {
        //GetDBAll();
    }

    public void Reset()
    {
        _SourceData = null;
        _Count = null;
    }

    public MobileAssignListViewList GetDBAll()
    {
        return GetDBAll(-1, -1, "order_id", string.Empty);
    }

    public MobileAssignListViewList GetDBAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sFilterExpression)
    {
        if (string.IsNullOrEmpty(x_sSortExpression))
            x_sSortExpression = "order_id";
        if (string.IsNullOrEmpty(x_sFilterExpression))
            x_sFilterExpression = string.Empty;
        MobileAssignListViewList _oMobileAssignListViewList = new MobileAssignListViewList();
        IList<MobileAssignListEntity> _oMobileAssignListEntityArr = MobileAssignListDalDAO.FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, (new List<SearchItem>()), x_sFilterExpression, false);
        if (_oMobileAssignListEntityArr != null)
        {
            if (_oMobileAssignListEntityArr.Count > 0)
            {
                Hashtable _oStockList = new Hashtable();
                List<int?> _oListOrder = new List<int?>();
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append(" SELECT DUMMY4,IMEI FROM IMEI_STOCK ");
                _oQuery.Append(" WHERE DUMMY2='CC RET' AND STATUS='STOCK' AND DUMMY4 IS NOT NULL AND DUMMY4<>' ' AND ");
                _oQuery.Append(" DUMMY4 IN (");
                StringBuilder _oIn = new StringBuilder();

                for (int i = 0; i < _oMobileAssignListEntityArr.Count; i++)
                {
                    if (_oMobileAssignListEntityArr[i].order_id != null)
                    {
                        _oMobileAssignListEntityArr[i].record_id = ((int)_oMobileAssignListEntityArr[i].order_id) + 100000;
                        if (_oIn.ToString() != string.Empty) _oIn.Append(",");
                        _oIn.Append("'" + _oMobileAssignListEntityArr[i].record_id.ToString() + "'");
                    }
                }
                _oQuery.Append(_oIn.ToString());
                _oQuery.Append(")");
                StringBuilder _oIn2 = new StringBuilder();
                OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
                while (_oDr.Read())
                {
                    string _sRecord_id = Func.FR(_oDr["DUMMY4"]).Trim();
                    string _sIMEI = Func.FR(_oDr["IMEI"]).Trim();
                    if (!_oStockList.Contains(_sRecord_id) && !_sIMEI.Equals(string.Empty))
                        _oStockList.Add(_sRecord_id, _sIMEI);

                    if (_oIn2.ToString() != string.Empty) _oIn2.Append(",");
                    _oIn2.Append("'" + _sRecord_id + "'");
                }
                _oDr.Close();
                _oDr.Dispose();

               
                int _iIndex = 0;
                for (int i = 0; i < _oMobileAssignListEntityArr.Count; i++)
                {
                    MobileAssignListView _oMobileAssignListView = new MobileAssignListView();
                    _oMobileAssignListView.MobileAssignList = (MobileAssignList)_oMobileAssignListEntityArr[i];
                    if (_oMobileAssignListView.MobileAssignList.order_id != null)
                    {
                        if (!_oListOrder.Contains(_oMobileAssignListView.MobileAssignList.order_id))
                        {
                            
                            _oMobileAssignListView.MobileAssignList.record_id = ((int)_oMobileAssignListEntityArr[i].order_id) + 100000;
                            _oMobileAssignListView.Index = _iIndex;
                            if (_oStockList.Contains(_oMobileAssignListEntityArr[i].record_id.ToString()))
                            {
                                _oMobileAssignListView.MobileAssignList.status = "STOCK";
                                _oMobileAssignListView.MobileAssignList.imei_no = _oStockList[_oMobileAssignListEntityArr[i].record_id.ToString()].ToString().Trim();
                                _oMobileAssignListView.Chk_enabled = true;
                                if (!_oMobileAssignListView.MobileAssignList.imei_no.Trim().Equals(string.Empty))
                                    _oMobileAssignListViewList.Add(_oMobileAssignListView);
                            }
                            else
                            {
                                if (_oMobileAssignListView.MobileAssignList.GetImei_no().Trim().ToUpper().Equals("AWAIT"))
                                    _oMobileAssignListView.MobileAssignList.status = "AWAIT";
                                else if (_oMobileAssignListView.MobileAssignList.GetImei_no().Trim().ToUpper().Equals("AO"))
                                    _oMobileAssignListView.MobileAssignList.status = "AO";
                                _oMobileAssignListView.Chk_enabled = false;
                                _oMobileAssignListView.MobileAssignList.imei_no = string.Empty;
                            }

                            _iIndex += 1;
                            _oListOrder.Add(_oMobileAssignListView.MobileAssignList.order_id);
                        }
                    }
                }
            }
        }
        return _oMobileAssignListViewList;
    }

    #region CountAll
    public int CountAll()
    {
        if (_SourceData == null)
            _SourceData = this.GetDBAll();
        if (_Count == null)
            _Count = _SourceData.Count;

        return (int)_Count;
    }
    #endregion


    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public MobileAssignListViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
    {
        if (_SourceData == null)
            _SourceData = this.GetDBAll();

        StringBuilder _sFilterExpression = new StringBuilder();
        if (_SourceData.Count > 0)
        {
            for (int i = 0; i < _SourceData.Count; i++)
            {
                if (_SourceData[i].MobileAssignList.order_id != null)
                {
                    if (!string.IsNullOrEmpty(_sFilterExpression.ToString())) _sFilterExpression.Append(",");
                    _sFilterExpression.Append(((int)_SourceData[i].MobileAssignList.order_id).ToString());
                }
            }

            if (!string.IsNullOrEmpty(_sFilterExpression.ToString()))
            {
                _sFilterExpression = new StringBuilder(" order_id in (" + _sFilterExpression.ToString() + ")");
            }
        }
        return this.GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, _sFilterExpression.ToString());
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public MobileAssignListViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sFilterExpression)
    {
        if (string.IsNullOrEmpty(x_sFilterExpression))
        {
            _SourceData = this.GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, string.Empty);
            return this._Data;
        }
        else
        {
            return this.GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_sFilterExpression);
        }
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    public MobileAssignListViewList FindAll()
    {
        return this._Data;
    }



    [DataObjectMethod(DataObjectMethodType.Delete, true)]
    public void DeleteMobileAssignListView(MobileAssignListView x_oMobileAssignListView)
    {
    }


    [DataObjectMethod(DataObjectMethodType.Update, true)]
    public void UpdateMobileAssignListView(MobileAssignListView x_oMobileAssignListView)
    {
    }

    [DataObjectMethod(DataObjectMethodType.Insert, true)]
    public void InsertMobileAssignListView(MobileAssignListView x_oMobileAssignListView)
    {
    }


    public MSSQLConnect GetDB()
    {
        return SYSConn<MSSQLConnect>.Connect(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
    }

}
