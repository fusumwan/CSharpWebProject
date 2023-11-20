using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-11-11>
///-- Description:	<Description,Table :[MobileOrderMonthlyFee],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class MobileOrderMonthlyFeeDalDAO
    {

        #region RS
        public class MobileOrderMonthlyFeeRS
        {
            public bool n_bMid = false;
            public bool n_bMon = false;
            public bool n_bFee = false;
            public bool n_bActive = false;
            public bool n_bFree_mon = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bMid || x_bSetShowALL || (MobileOrderMonthlyFee.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMonthlyFee.Para.mid);
                }
                if (this.n_bMon || x_bSetShowALL || (MobileOrderMonthlyFee.Para.mon.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMon = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMonthlyFee.Para.mon);
                }
                if (this.n_bFee || x_bSetShowALL || (MobileOrderMonthlyFee.Para.fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFee = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMonthlyFee.Para.fee);
                }
                if (this.n_bActive || x_bSetShowALL || (MobileOrderMonthlyFee.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMonthlyFee.Para.active);
                }
                if (this.n_bFree_mon || x_bSetShowALL || (MobileOrderMonthlyFee.Para.free_mon.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFree_mon = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMonthlyFee.Para.free_mon);
                }
                return _oFR.ToString();
            }

            public string FieldsToReturn()
            {
                return this.FieldsToReturn(string.Empty, false);
            }

        }
        #endregion
        #region Constructor

        public MobileOrderMonthlyFeeDalDAO()
        {
        }
        ~MobileOrderMonthlyFeeDalDAO()
        {
            this.Release();
        }
        #endregion

        #region Search Engine
        public static global::System.Data.SqlClient.SqlDataReader DrSearch(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, string x_sFieldsToReturn, string x_sSortByField, bool x_bAscDirection)
        {
            SearchUtils _oSearchUtils = new SearchUtils();
            _oSearchUtils.SetSearchItems(x_oSearchItems);
            _oSearchUtils.SetRowFilter(x_sRowFilter);
            _oSearchUtils.SetStart(x_lStart);
            _oSearchUtils.SetLimit(x_lLimit);
            _oSearchUtils.SetFieldsToReturn(x_sFieldsToReturn);
            _oSearchUtils.SetOrderByField(x_sSortByField);
            _oSearchUtils.SetAscDirection(x_bAscDirection);
            _oSearchUtils.SetTable(MobileOrderMonthlyFee.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderMonthlyFeeEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, MobileOrderMonthlyFeeRS x_oFieldsToReturn, MobileOrderMonthlyFeeRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeeList = new List<MobileOrderMonthlyFeeEntity>();

                while (_oDATA.Read())
                {
                    MobileOrderMonthlyFee _oMobileOrderMonthlyFee = new MobileOrderMonthlyFee();
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMonthlyFee.Para.mid])) { _oMobileOrderMonthlyFee.SetMid((global::System.Nullable<int>)_oDATA[MobileOrderMonthlyFee.Para.mid]); } else { _oMobileOrderMonthlyFee.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMon))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMonthlyFee.Para.mon])) { _oMobileOrderMonthlyFee.SetMon((global::System.Nullable<int>)_oDATA[MobileOrderMonthlyFee.Para.mon]); } else { _oMobileOrderMonthlyFee.SetMon(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMonthlyFee.Para.fee])) { _oMobileOrderMonthlyFee.SetFee((global::System.Nullable<int>)_oDATA[MobileOrderMonthlyFee.Para.fee]); } else { _oMobileOrderMonthlyFee.SetFee(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMonthlyFee.Para.active])) { _oMobileOrderMonthlyFee.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderMonthlyFee.Para.active]); } else { _oMobileOrderMonthlyFee.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFree_mon))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMonthlyFee.Para.free_mon])) { _oMobileOrderMonthlyFee.SetFree_mon((string)_oDATA[MobileOrderMonthlyFee.Para.free_mon]); } else { _oMobileOrderMonthlyFee.SetFree_mon(global::System.String.Empty); }
                    }
                    _oMobileOrderMonthlyFeeList.Add(_oMobileOrderMonthlyFee);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderMonthlyFeeList;
            }
            return new List<MobileOrderMonthlyFeeEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<MobileOrderMonthlyFeeEntity> OrderBy(string x_sSort, IQueryable<MobileOrderMonthlyFeeEntity> x_oMobileOrderMonthlyFeeBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case MobileOrderMonthlyFee.Para.mid:
                    if (x_bAsc)
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case MobileOrderMonthlyFee.Para.mon:
                    if (x_bAsc)
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderBy(c => c.mon).Select(c => c);
                    else
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderByDescending(c => c.mon).Select(c => c);
                    break;
                case MobileOrderMonthlyFee.Para.fee:
                    if (x_bAsc)
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderBy(c => c.fee).Select(c => c);
                    else
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderByDescending(c => c.fee).Select(c => c);
                    break;
                case MobileOrderMonthlyFee.Para.active:
                    if (x_bAsc)
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case MobileOrderMonthlyFee.Para.free_mon:
                    if (x_bAsc)
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderBy(c => c.free_mon).Select(c => c);
                    else
                        x_oMobileOrderMonthlyFeeBaseList = x_oMobileOrderMonthlyFeeBaseList.OrderByDescending(c => c.free_mon).Select(c => c);
                    break;
            }
            return x_oMobileOrderMonthlyFeeBaseList;
        }
        #endregion


        #region FindAll
        public static IList<MobileOrderMonthlyFeeEntity> FindAll()
        {
            MobileOrderMonthlyFeeEntity[] _oMobileOrderMonthlyFeesArr = MobileOrderMonthlyFeeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderMonthlyFeesArr != null)
            {
                IList<MobileOrderMonthlyFeeEntity> _oMobileOrderMonthlyFeesList = (IList<MobileOrderMonthlyFeeEntity>)_oMobileOrderMonthlyFeesArr;
                return _oMobileOrderMonthlyFeesList;
            }
            return new List<MobileOrderMonthlyFeeEntity>();
        }

        public static IList<MobileOrderMonthlyFeeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<MobileOrderMonthlyFeeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<MobileOrderMonthlyFeeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<MobileOrderMonthlyFeeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            MobileOrderMonthlyFeeRS x_oShowField = new MobileOrderMonthlyFeeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderMonthlyFeeRS x_oSortField = new MobileOrderMonthlyFeeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderMonthlyFee.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(MobileOrderMonthlyFee.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            MobileOrderMonthlyFeeRepositoryBase _oMobileOrderMonthlyFeeRepositoryBase = new MobileOrderMonthlyFeeRepositoryBase(GetDB());
            return _oMobileOrderMonthlyFeeRepositoryBase.GetCount();
        }
        #endregion

        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        #region
        public void Release() { }
        #endregion
    }
}

