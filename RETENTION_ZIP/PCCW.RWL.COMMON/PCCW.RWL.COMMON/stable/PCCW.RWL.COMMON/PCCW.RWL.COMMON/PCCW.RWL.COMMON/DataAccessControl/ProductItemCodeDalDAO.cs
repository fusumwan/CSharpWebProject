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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-11-11>
///-- Description:	<Description,Table :[ProductItemCode],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class ProductItemCodeDalDAO
    {

        #region RS
        public class ProductItemCodeRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bType = false;
            public bool n_bHs_model = false;
            public bool n_bLast_stock = false;
            public bool n_bItem_code = false;
            public bool n_bEdate = false;
            public bool n_bDdate = false;
            public bool n_bMid = false;
            public bool n_bSdate = false;
            public bool n_bQuota = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive || x_bSetShowALL || (ProductItemCode.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.active);
                }
                if (this.n_bCdate || x_bSetShowALL || (ProductItemCode.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (ProductItemCode.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.cid);
                }
                if (this.n_bDid || x_bSetShowALL || (ProductItemCode.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.did);
                }
                if (this.n_bType || x_bSetShowALL || (ProductItemCode.Para.type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bType = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.type);
                }
                if (this.n_bHs_model || x_bSetShowALL || (ProductItemCode.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.hs_model);
                }
                if (this.n_bLast_stock || x_bSetShowALL || (ProductItemCode.Para.last_stock.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLast_stock = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.last_stock);
                }
                if (this.n_bItem_code || x_bSetShowALL || (ProductItemCode.Para.item_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bItem_code = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.item_code);
                }
                if (this.n_bEdate || x_bSetShowALL || (ProductItemCode.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.edate);
                }
                if (this.n_bDdate || x_bSetShowALL || (ProductItemCode.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.ddate);
                }
                if (this.n_bMid || x_bSetShowALL || (ProductItemCode.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.mid);
                }
                if (this.n_bSdate || x_bSetShowALL || (ProductItemCode.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.sdate);
                }
                if (this.n_bQuota || x_bSetShowALL || (ProductItemCode.Para.quota.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bQuota = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProductItemCode.Para.quota);
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

        public ProductItemCodeDalDAO()
        {
        }
        ~ProductItemCodeDalDAO()
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
            _oSearchUtils.SetTable(ProductItemCode.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<ProductItemCodeEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, ProductItemCodeRS x_oFieldsToReturn, ProductItemCodeRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<ProductItemCodeEntity> _oProductItemCodeList = new List<ProductItemCodeEntity>();

                while (_oDATA.Read())
                {
                    ProductItemCode _oProductItemCode = new ProductItemCode();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.active])) { _oProductItemCode.SetActive((global::System.Nullable<bool>)_oDATA[ProductItemCode.Para.active]); } else { _oProductItemCode.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.cdate])) { _oProductItemCode.SetCdate((global::System.Nullable<DateTime>)_oDATA[ProductItemCode.Para.cdate]); } else { _oProductItemCode.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.cid])) { _oProductItemCode.SetCid((string)_oDATA[ProductItemCode.Para.cid]); } else { _oProductItemCode.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.did])) { _oProductItemCode.SetDid((string)_oDATA[ProductItemCode.Para.did]); } else { _oProductItemCode.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bType))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.type])) { _oProductItemCode.SetType((string)_oDATA[ProductItemCode.Para.type]); } else { _oProductItemCode.SetType(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.hs_model])) { _oProductItemCode.SetHs_model((string)_oDATA[ProductItemCode.Para.hs_model]); } else { _oProductItemCode.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLast_stock))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.last_stock])) { _oProductItemCode.SetLast_stock((global::System.Nullable<bool>)_oDATA[ProductItemCode.Para.last_stock]); } else { _oProductItemCode.SetLast_stock(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bItem_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.item_code])) { _oProductItemCode.SetItem_code((string)_oDATA[ProductItemCode.Para.item_code]); } else { _oProductItemCode.SetItem_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.edate])) { _oProductItemCode.SetEdate((global::System.Nullable<DateTime>)_oDATA[ProductItemCode.Para.edate]); } else { _oProductItemCode.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.ddate])) { _oProductItemCode.SetDdate((global::System.Nullable<DateTime>)_oDATA[ProductItemCode.Para.ddate]); } else { _oProductItemCode.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.mid])) { _oProductItemCode.SetMid((global::System.Nullable<int>)_oDATA[ProductItemCode.Para.mid]); } else { _oProductItemCode.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.sdate])) { _oProductItemCode.SetSdate((global::System.Nullable<DateTime>)_oDATA[ProductItemCode.Para.sdate]); } else { _oProductItemCode.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bQuota))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProductItemCode.Para.quota])) { _oProductItemCode.SetQuota((string)_oDATA[ProductItemCode.Para.quota]); } else { _oProductItemCode.SetQuota(global::System.String.Empty); }
                    }
                    _oProductItemCodeList.Add(_oProductItemCode);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oProductItemCodeList;
            }
            return new List<ProductItemCodeEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<ProductItemCodeEntity> OrderBy(string x_sSort, IQueryable<ProductItemCodeEntity> x_oProductItemCodeBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case ProductItemCode.Para.active:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case ProductItemCode.Para.cdate:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case ProductItemCode.Para.cid:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case ProductItemCode.Para.did:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case ProductItemCode.Para.type:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.type).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.type).Select(c => c);
                    break;
                case ProductItemCode.Para.hs_model:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.hs_model).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                    break;
                case ProductItemCode.Para.last_stock:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.last_stock).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.last_stock).Select(c => c);
                    break;
                case ProductItemCode.Para.item_code:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.item_code).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.item_code).Select(c => c);
                    break;
                case ProductItemCode.Para.edate:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.edate).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.edate).Select(c => c);
                    break;
                case ProductItemCode.Para.ddate:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case ProductItemCode.Para.mid:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case ProductItemCode.Para.sdate:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.sdate).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                    break;
                case ProductItemCode.Para.quota:
                    if (x_bAsc)
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderBy(c => c.quota).Select(c => c);
                    else
                        x_oProductItemCodeBaseList = x_oProductItemCodeBaseList.OrderByDescending(c => c.quota).Select(c => c);
                    break;
            }
            return x_oProductItemCodeBaseList;
        }
        #endregion


        #region FindAll
        public static IList<ProductItemCodeEntity> FindAll()
        {
            ProductItemCodeEntity[] _oProductItemCodesArr = ProductItemCodeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oProductItemCodesArr != null)
            {
                IList<ProductItemCodeEntity> _oProductItemCodesList = (IList<ProductItemCodeEntity>)_oProductItemCodesArr;
                return _oProductItemCodesList;
            }
            return new List<ProductItemCodeEntity>();
        }

        public static IList<ProductItemCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<ProductItemCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<ProductItemCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<ProductItemCodeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            ProductItemCodeRS x_oShowField = new ProductItemCodeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            ProductItemCodeRS x_oSortField = new ProductItemCodeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(ProductItemCode.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(ProductItemCode.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            ProductItemCodeRepositoryBase _oProductItemCodeRepositoryBase = new ProductItemCodeRepositoryBase(GetDB());
            return _oProductItemCodeRepositoryBase.GetCount();
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

