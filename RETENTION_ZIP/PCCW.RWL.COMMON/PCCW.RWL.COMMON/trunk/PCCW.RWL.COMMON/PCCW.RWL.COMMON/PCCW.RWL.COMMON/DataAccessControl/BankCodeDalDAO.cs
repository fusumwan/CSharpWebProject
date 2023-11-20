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
///-- Create date: <Create Date 2010-05-17>
///-- Description:	<Description,Table :[BankCode],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class BankCodeDalDAO
    {

        #region RS
        public class BankCodeRS
        {
            public bool n_bBank_code = false;
            public bool n_bBank_name = false;
            public bool n_bMid = false;
            public bool n_bInstallment_period = false;
            public bool n_bActive = false;
            public bool n_bMin_amount = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bBank_code || x_bSetShowALL || (BankCode.Para.bank_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBank_code = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BankCode.Para.bank_code);
                }
                if (this.n_bBank_name || x_bSetShowALL || (BankCode.Para.bank_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBank_name = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BankCode.Para.bank_name);
                }
                if (this.n_bMid || x_bSetShowALL || (BankCode.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BankCode.Para.mid);
                }
                if (this.n_bInstallment_period || x_bSetShowALL || (BankCode.Para.installment_period.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bInstallment_period = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BankCode.Para.installment_period);
                }
                if (this.n_bActive || x_bSetShowALL || (BankCode.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BankCode.Para.active);
                }
                if (this.n_bMin_amount || x_bSetShowALL || (BankCode.Para.min_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMin_amount = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BankCode.Para.min_amount);
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

        public BankCodeDalDAO()
        {
        }
        ~BankCodeDalDAO()
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
            _oSearchUtils.SetTable(BankCode.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BankCodeEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, BankCodeRS x_oFieldsToReturn, BankCodeRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<BankCodeEntity> _oBankCodeList = new List<BankCodeEntity>();

                while (_oDATA.Read())
                {
                    BankCode _oBankCode = new BankCode();
                    if ((true).Equals(x_oFieldsToReturn.n_bBank_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BankCode.Para.bank_code])) { _oBankCode.SetBank_code((string)_oDATA[BankCode.Para.bank_code]); } else { _oBankCode.SetBank_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBank_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BankCode.Para.bank_name])) { _oBankCode.SetBank_name((string)_oDATA[BankCode.Para.bank_name]); } else { _oBankCode.SetBank_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BankCode.Para.mid])) { _oBankCode.SetMid((global::System.Nullable<int>)_oDATA[BankCode.Para.mid]); } else { _oBankCode.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bInstallment_period))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BankCode.Para.installment_period])) { _oBankCode.SetInstallment_period((string)_oDATA[BankCode.Para.installment_period]); } else { _oBankCode.SetInstallment_period(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BankCode.Para.active])) { _oBankCode.SetActive((global::System.Nullable<bool>)_oDATA[BankCode.Para.active]); } else { _oBankCode.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMin_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BankCode.Para.min_amount])) { _oBankCode.SetMin_amount((string)_oDATA[BankCode.Para.min_amount]); } else { _oBankCode.SetMin_amount(global::System.String.Empty); }
                    }
                    _oBankCodeList.Add(_oBankCode);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBankCodeList;
            }
            return new List<BankCodeEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<BankCodeEntity> OrderBy(string x_sSort, IQueryable<BankCodeEntity> x_oBankCodeBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case BankCode.Para.bank_code:
                    if (x_bAsc)
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderBy(c => c.bank_code).Select(c => c);
                    else
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderByDescending(c => c.bank_code).Select(c => c);
                    break;
                case BankCode.Para.bank_name:
                    if (x_bAsc)
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderBy(c => c.bank_name).Select(c => c);
                    else
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderByDescending(c => c.bank_name).Select(c => c);
                    break;
                case BankCode.Para.mid:
                    if (x_bAsc)
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case BankCode.Para.installment_period:
                    if (x_bAsc)
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderBy(c => c.installment_period).Select(c => c);
                    else
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderByDescending(c => c.installment_period).Select(c => c);
                    break;
                case BankCode.Para.active:
                    if (x_bAsc)
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case BankCode.Para.min_amount:
                    if (x_bAsc)
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderBy(c => c.min_amount).Select(c => c);
                    else
                        x_oBankCodeBaseList = x_oBankCodeBaseList.OrderByDescending(c => c.min_amount).Select(c => c);
                    break;
            }
            return x_oBankCodeBaseList;
        }
        #endregion


        #region FindAll
        public static IList<BankCodeEntity> FindAll()
        {
            BankCodeEntity[] _oBankCodesArr = BankCodeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBankCodesArr != null)
            {
                IList<BankCodeEntity> _oBankCodesList = (IList<BankCodeEntity>)_oBankCodesArr;
                return _oBankCodesList;
            }
            return new List<BankCodeEntity>();
        }

        public static IList<BankCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<BankCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<BankCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<BankCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            BankCodeRS x_oShowField = new BankCodeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BankCodeRS x_oSortField = new BankCodeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BankCode.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(BankCode.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            BankCodeRepositoryBase _oBankCodeRepositoryBase = new BankCodeRepositoryBase(GetDB());
            return _oBankCodeRepositoryBase.GetCount();
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

