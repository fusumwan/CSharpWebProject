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

    public class BusinessVasDefaultSetViewList : List<BusinessVasDefaultSetView>
    {
        internal void Find(BusinessVasDefaultSetView x_oBusinessVasDefaultSetView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class BusinessVasDefaultSetViewDAO
    {
        protected static BusinessVasDefaultSetViewList _SourceData { get; set; }
        protected static int? _Count { get; set; }
        private BusinessVasDefaultSetViewList _Data
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

        public BusinessVasDefaultSetViewDAO()
        {
            //GetDBAll();
            /*
            if (_SourceData == null)
                _SourceData = this.GetDBAll(null, null, " program asc");
            */
        }

        public BusinessVasDefaultSetViewList GetDBAll()
        {
            //return this.GetDBAll(null, null, " program asc");
            /*BusinessVasDefaultSetViewList _oBusinessVasDefaultSetViewList = new BusinessVasDefaultSetViewList();
            return _oBusinessVasDefaultSetViewList;*/
            //return this.GetDBAll(null, null, " mid desc");
            return new BusinessVasDefaultSetViewList();
        }

        public BusinessVasDefaultSetViewList GetDBAll(string x_sStrWhere, string x_sStrGroup, string x_oStrOrderBy)
        {
            BusinessVasDefaultSetViewList _oBusinessVasDefaultSetViewList = new BusinessVasDefaultSetViewList();
            BusinessVasDefaultSetEntity[] _oBusinessVasDefaultSetEntityArr = BusinessVasDefaultSetBal.GetArrayObj(GetDB(), x_sStrWhere, x_sStrGroup, x_oStrOrderBy);

            if (_oBusinessVasDefaultSetEntityArr != null)
            {
                for (int i = 0; i < _oBusinessVasDefaultSetEntityArr.Length; i++)
                {
                    BusinessVasDefaultSetView _oBusinessVasDefaultSetView = new BusinessVasDefaultSetView();
                    _oBusinessVasDefaultSetView.Index = i;
                    _oBusinessVasDefaultSetView.BusinessVasDefaultSet = (BusinessVasDefaultSet)_oBusinessVasDefaultSetEntityArr[i];
                    if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet != null)
                    {
                        // For VAS 1
                        string _sVas_field = (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1 != null) ? _oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1.ToString() : string.Empty;
                        string _sFilter = string.Empty;
                        if (!string.IsNullOrEmpty(_sVas_field))
                            _sFilter = " vas_field='" + _sVas_field + "'";
                        else
                            _sFilter = " (vas_field='' or vas_field IS NULL) ";
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVas = new BusinessVas(GetDB());
                        BusinessVasEntity[] _oBusinessVasEntityArr = BusinessVasBal.GetArrayObj(GetDB(), _sFilter, null, null);
                        if (_oBusinessVasEntityArr != null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVas = (BusinessVas)_oBusinessVasEntityArr[0];
                        }

                        // For VALUE 1

                        // For VALUE 2
                        string _sVas = (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1 != null) ? _oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1.ToString() : string.Empty;
                        string _sFee = (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2 != null) ? _oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2.ToString() : string.Empty;
                        string _sFilter2 = string.Empty;
                        if (!string.IsNullOrEmpty(_sVas))
                            _sFilter2 = " vas='" + _sVas + "'";
                        else
                            _sFilter2 = " (vas='' or vas IS NULL) ";

                        if (!string.IsNullOrEmpty(_sFee))
                            _sFilter2 = _sFilter2 + " AND fee='" + _sFee + "' ";
                        else
                            _sFilter2 = _sFilter2 + " AND (fee='' or fee IS NULL) ";
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVasDescription = new BusinessVasDescription(GetDB());
                        BusinessVasDescriptionEntity[] _oBusinessVasDescriptionEntityArr = BusinessVasDescriptionBal.GetArrayObj(GetDB(), _sFilter2, null, null);
                        if (_oBusinessVasDescriptionEntityArr != null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVasDescription = (BusinessVasDescription)_oBusinessVasDescriptionEntityArr[0];
                        }

                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.active == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.active = false;
                        }
                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.display1 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display1 = false;
                        }
                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.display2 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display2 = false;
                        }

                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled1 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled1 = false;
                        }
                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled2 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled2 = false;
                        }

                        _oBusinessVasDefaultSetViewList.Add(_oBusinessVasDefaultSetView);
                    }
                }
            }
            return _oBusinessVasDefaultSetViewList;
        }

        public BusinessVasDefaultSetViewList GetDBAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sFilterExpression)
        {
            BusinessVasDefaultSetViewList _oBusinessVasDefaultSetViewList = new BusinessVasDefaultSetViewList();
            IList<BusinessVasDefaultSetEntity> _oBusinessVasDefaultSetEntityArr = BusinessVasDefaultSetDalDAO.FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, (new List<SearchItem>()), x_sFilterExpression, false);
            if (_oBusinessVasDefaultSetEntityArr != null)
            {
                for (int i = 0; i < _oBusinessVasDefaultSetEntityArr.Count; i++)
                {
                    BusinessVasDefaultSetView _oBusinessVasDefaultSetView = new BusinessVasDefaultSetView();
                    _oBusinessVasDefaultSetView.Index = i;
                    _oBusinessVasDefaultSetView.BusinessVasDefaultSet = (BusinessVasDefaultSet)_oBusinessVasDefaultSetEntityArr[i];
                    if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet != null)
                    {
                        // For VAS 1
                        string _sVas_field = (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1 != null) ? _oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1.ToString() : string.Empty;
                        string _sFilter = string.Empty;
                        if (!string.IsNullOrEmpty(_sVas_field))
                            _sFilter = " vas_field='" + _sVas_field + "'";
                        else
                            _sFilter = " (vas_field='' or vas_field IS NULL) ";


                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVas = new BusinessVas(GetDB());
                        BusinessVasEntity[] _oBusinessVasEntityArr = BusinessVasBal.GetArrayObj(GetDB(), _sFilter, null, null);
                        if (_oBusinessVasEntityArr != null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVas = (BusinessVas)_oBusinessVasEntityArr[0];
                        }

                        // For VALUE 1

                        // For VALUE 2

                        string _sVas = (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1 != null) ? _oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1.ToString() : string.Empty;
                        string _sFee = (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2 != null) ? _oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2.ToString() : string.Empty;
                        string _sFilter2 = string.Empty;
                        if (!string.IsNullOrEmpty(_sVas))
                            _sFilter2 = " vas='" + _sVas + "'";
                        else
                            _sFilter2 = " (vas='' or vas IS NULL) ";

                        if (!string.IsNullOrEmpty(_sFee))
                            _sFilter2 = _sFilter2 + " AND fee='" + _sFee + "' ";
                        else
                            _sFilter2 = _sFilter2 + " AND (fee='' or fee IS NULL) ";

                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVasDescription = new BusinessVasDescription(GetDB());
                        BusinessVasDescriptionEntity[] _oBusinessVasDescriptionEntityArr = BusinessVasDescriptionBal.GetArrayObj(GetDB(), _sFilter2, null, null);
                        if (_oBusinessVasDescriptionEntityArr != null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVasDescription = (BusinessVasDescription)_oBusinessVasDescriptionEntityArr[0];
                        }

                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.active == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.active = false;
                        }
                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.display1 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display1 = false;
                        }
                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.display2 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display2 = false;
                        }

                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled1 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled1 = false;
                        }
                        if (_oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled2 == null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled2 = false;
                        }

                        _oBusinessVasDefaultSetViewList.Add(_oBusinessVasDefaultSetView);
                    }
                }
            }
            return _oBusinessVasDefaultSetViewList;
        }


        #region CountAll
        public int CountAll()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT COUNT(*) FROM BusinessVasDefaultSet WITH (NOLOCK)");
            string _sCount = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
            int _iCount;
            if (int.TryParse(_sCount, out _iCount))
            {
                _Count = _iCount;
            }
            return (int)_Count;
        }
        #endregion

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public BusinessVasDefaultSetViewList FindAll()
        {
            /*
            if (this._Data == null)
                throw new NotImplementedException("ERROR:  _Data cannot be null value!");

            return this._Data;
            */
            return this.GetDBAll(null, null, " mid desc");
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public BusinessVasDefaultSetViewList FindAll(string x_sStrWhere, string x_sStrGroup, string x_oStrOrderBy)
        {
            BusinessVasDefaultSetViewList _oBusinessVasDefaultSetViewList = this.GetDBAll(x_sStrWhere, x_sStrGroup, x_oStrOrderBy);
            if (_oBusinessVasDefaultSetViewList == null)
                return new BusinessVasDefaultSetViewList();

            return _oBusinessVasDefaultSetViewList;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public BusinessVasDefaultSetViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sFilterExpression)
        {
            BusinessVasDefaultSetViewList _oBusinessVasDefaultSetViewList = this.GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_sFilterExpression);
            if (_oBusinessVasDefaultSetViewList == null)
                return new BusinessVasDefaultSetViewList();

            return _oBusinessVasDefaultSetViewList;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public BusinessVasDefaultSetViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            BusinessVasDefaultSetViewList _oBusinessVasDefaultSetViewList = this.GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, string.Empty);
            if (_oBusinessVasDefaultSetViewList == null)
                return new BusinessVasDefaultSetViewList();

            return _oBusinessVasDefaultSetViewList;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteBusinessVasDefaultSetView(BusinessVasDefaultSetView x_oBusinessVasDefaultSetView)
        {
            if (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.mid != null)
            {
                x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.Delete();
            }
            /*
            _SourceData = this.GetDBAll(null, null, " mid desc");
             */
            //int _iMid;
            //_iMid = Convert.ToInt32(x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.mid);
            //x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.Delete();

        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateBusinessVasDefaultSetView(BusinessVasDefaultSetView x_oBusinessVasDefaultSetView)
        {

            if (x_oBusinessVasDefaultSetView == null)
                throw new NotImplementedException("ERROR:  x_oBusinessVasDefaultSetView cannot be null value!");
            if (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet_mid == null)
                throw new InvalidOperationException("ERROR : x_oBusinessVasDefaultSetView.BusinessVasDefaultSet_mid  cannot be null value!");

            if (_SourceData == null)
            {
                _SourceData = this.GetDBAll("mid=" + ((int)x_oBusinessVasDefaultSetView.BusinessVasDefaultSet_mid).ToString(), null, null);
            }

            if (_SourceData.Count > x_oBusinessVasDefaultSetView.Index && x_oBusinessVasDefaultSetView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].BusinessVasDefaultSet_mid == x_oBusinessVasDefaultSetView.BusinessVasDefaultSet_mid)
                    {
                        BusinessVasDefaultSetView _oBusinessVasDefaultSetView = _SourceData[i];
                        if (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.active == true)
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.active = true;
                        else
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.active = false;

                        if (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled1 == true)
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled1 = true;
                        else
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled1 = false;

                        if (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled2 == true)
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled2 = true;
                        else
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.enabled2 = false;


                        if (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.display1 == true)
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display1 = true;
                        else
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display1 = false;

                        if (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.display2 == true)
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display2 = true;
                        else
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.display2 = false;


                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.program = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.program;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.rate_plan = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.rate_plan;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.con_per = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.con_per;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.trade_field = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.trade_field;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.bundle_name = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.bundle_name;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.hs_model = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.hs_model;

                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1 = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.value1 = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.value1;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas2 = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas2;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2 = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2;

                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.cid = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.cid;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.edate = DateTime.Now;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.issue_type = x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.issue_type;
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.Save();

                        string _sVas_field = (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1 != null) ? x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1.ToString() : string.Empty;
                        string _sFilter = string.Empty;
                        if (!string.IsNullOrEmpty(_sVas_field))
                            _sFilter = " vas_field='" + _sVas_field + "'";
                        else
                            _sFilter = " (vas_field='' or vas_field IS NULL) ";

                        BusinessVasEntity[] _oBusinessVasEntityArr = BusinessVasBal.GetArrayObj(GetDB(), _sFilter, null, null);
                        if (_oBusinessVasEntityArr != null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVas = (BusinessVas)_oBusinessVasEntityArr[0];
                        }

                        // For VALUE 1

                        // For VALUE 2
                        _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVasDescription = new BusinessVasDescription(GetDB());

                        string _sVas = (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1 != null) ? x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.vas1.ToString() : string.Empty;
                        string _sFee = (x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2 != null) ? x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.value2.ToString() : string.Empty;
                        string _sFilter2 = string.Empty;
                        if (!string.IsNullOrEmpty(_sVas))
                            _sFilter2 = " vas='" + _sVas + "'";
                        else
                            _sFilter2 = " (vas='' or vas IS NULL) ";

                        if (!string.IsNullOrEmpty(_sFee))
                            _sFilter2 = _sFilter2 + " AND fee='" + _sFee + "' ";
                        else
                            _sFilter2 = _sFilter2 + " AND (fee='' or fee IS NULL) ";

                        BusinessVasDescriptionEntity[] _oBusinessVasDescriptionEntityArr = BusinessVasDescriptionBal.GetArrayObj(GetDB(), _sFilter2, null, null);
                        if (_oBusinessVasDescriptionEntityArr != null)
                        {
                            _oBusinessVasDefaultSetView.BusinessVasDefaultSet.BusinessVasDescription = (BusinessVasDescription)_oBusinessVasDescriptionEntityArr[0];
                        }
                        break;
                    }
                    else
                    {
                    }
                }
            }
            _SourceData = null;

        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertBusinessVasDefaultSetView(BusinessVasDefaultSetView x_oBusinessVasDefaultSetView)
        {
            if (x_oBusinessVasDefaultSetView == null)
                throw new NotImplementedException("ERROR:  x_oBusinessVasDefaultSetView cannot be null value!");
            x_oBusinessVasDefaultSetView.BusinessVasDefaultSet.cdate = DateTime.Now;
            BusinessVasDefaultSetBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), x_oBusinessVasDefaultSetView.BusinessVasDefaultSet);
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
