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
///-- Description:	<Description,Table :[GiftBasket],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class GiftBasketDalDAO
    {

        #region RS
        public class GiftBasketRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bGift_code = false;
            public bool n_bSdate = false;
            public bool n_bLast_stock = false;
            public bool n_bEdate = false;
            public bool n_bGift_desc = false;
            public bool n_bGift_gp = false;
            public bool n_bDdate = false;
            public bool n_bMid = false;
            public bool n_bDid = false;
            public bool n_bQuota = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive || x_bSetShowALL || (GiftBasket.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.active);
                }
                if (this.n_bCdate || x_bSetShowALL || (GiftBasket.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (GiftBasket.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.cid);
                }
                if (this.n_bGift_code || x_bSetShowALL || (GiftBasket.Para.gift_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_code = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.gift_code);
                }
                if (this.n_bSdate || x_bSetShowALL || (GiftBasket.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.sdate);
                }
                if (this.n_bLast_stock || x_bSetShowALL || (GiftBasket.Para.last_stock.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLast_stock = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.last_stock);
                }
                if (this.n_bEdate || x_bSetShowALL || (GiftBasket.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.edate);
                }
                if (this.n_bGift_desc || x_bSetShowALL || (GiftBasket.Para.gift_desc.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_desc = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.gift_desc);
                }
                if (this.n_bGift_gp || x_bSetShowALL || (GiftBasket.Para.gift_gp.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGift_gp = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.gift_gp);
                }
                if (this.n_bDdate || x_bSetShowALL || (GiftBasket.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.ddate);
                }
                if (this.n_bMid || x_bSetShowALL || (GiftBasket.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.mid);
                }
                if (this.n_bDid || x_bSetShowALL || (GiftBasket.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.did);
                }
                if (this.n_bQuota || x_bSetShowALL || (GiftBasket.Para.quota.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bQuota = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(GiftBasket.Para.quota);
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

        public GiftBasketDalDAO()
        {
        }
        ~GiftBasketDalDAO()
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
            _oSearchUtils.SetTable(GiftBasket.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<GiftBasketEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, GiftBasketRS x_oFieldsToReturn, GiftBasketRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<GiftBasketEntity> _oGiftBasketList = new List<GiftBasketEntity>();

                while (_oDATA.Read())
                {
                    GiftBasket _oGiftBasket = new GiftBasket();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.active])) { _oGiftBasket.SetActive((global::System.Nullable<bool>)_oDATA[GiftBasket.Para.active]); } else { _oGiftBasket.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.cdate])) { _oGiftBasket.SetCdate((global::System.Nullable<DateTime>)_oDATA[GiftBasket.Para.cdate]); } else { _oGiftBasket.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.cid])) { _oGiftBasket.SetCid((string)_oDATA[GiftBasket.Para.cid]); } else { _oGiftBasket.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.gift_code])) { _oGiftBasket.SetGift_code((string)_oDATA[GiftBasket.Para.gift_code]); } else { _oGiftBasket.SetGift_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.sdate])) { _oGiftBasket.SetSdate((global::System.Nullable<DateTime>)_oDATA[GiftBasket.Para.sdate]); } else { _oGiftBasket.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLast_stock))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.last_stock])) { _oGiftBasket.SetLast_stock((global::System.Nullable<bool>)_oDATA[GiftBasket.Para.last_stock]); } else { _oGiftBasket.SetLast_stock(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.edate])) { _oGiftBasket.SetEdate((global::System.Nullable<DateTime>)_oDATA[GiftBasket.Para.edate]); } else { _oGiftBasket.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_desc))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.gift_desc])) { _oGiftBasket.SetGift_desc((string)_oDATA[GiftBasket.Para.gift_desc]); } else { _oGiftBasket.SetGift_desc(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGift_gp))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.gift_gp])) { _oGiftBasket.SetGift_gp((string)_oDATA[GiftBasket.Para.gift_gp]); } else { _oGiftBasket.SetGift_gp(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.ddate])) { _oGiftBasket.SetDdate((global::System.Nullable<DateTime>)_oDATA[GiftBasket.Para.ddate]); } else { _oGiftBasket.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.mid])) { _oGiftBasket.SetMid((global::System.Nullable<int>)_oDATA[GiftBasket.Para.mid]); } else { _oGiftBasket.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.did])) { _oGiftBasket.SetDid((string)_oDATA[GiftBasket.Para.did]); } else { _oGiftBasket.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bQuota))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[GiftBasket.Para.quota])) { _oGiftBasket.SetQuota((string)_oDATA[GiftBasket.Para.quota]); } else { _oGiftBasket.SetQuota(global::System.String.Empty); }
                    }
                    _oGiftBasketList.Add(_oGiftBasket);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oGiftBasketList;
            }
            return new List<GiftBasketEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<GiftBasketEntity> OrderBy(string x_sSort, IQueryable<GiftBasketEntity> x_oGiftBasketBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case GiftBasket.Para.active:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case GiftBasket.Para.cdate:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case GiftBasket.Para.cid:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case GiftBasket.Para.gift_code:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.gift_code).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.gift_code).Select(c => c);
                    break;
                case GiftBasket.Para.sdate:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.sdate).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                    break;
                case GiftBasket.Para.last_stock:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.last_stock).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.last_stock).Select(c => c);
                    break;
                case GiftBasket.Para.edate:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.edate).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.edate).Select(c => c);
                    break;
                case GiftBasket.Para.gift_desc:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.gift_desc).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.gift_desc).Select(c => c);
                    break;
                case GiftBasket.Para.gift_gp:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.gift_gp).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.gift_gp).Select(c => c);
                    break;
                case GiftBasket.Para.ddate:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case GiftBasket.Para.mid:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case GiftBasket.Para.did:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case GiftBasket.Para.quota:
                    if (x_bAsc)
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderBy(c => c.quota).Select(c => c);
                    else
                        x_oGiftBasketBaseList = x_oGiftBasketBaseList.OrderByDescending(c => c.quota).Select(c => c);
                    break;
            }
            return x_oGiftBasketBaseList;
        }
        #endregion


        #region FindAll
        public static IList<GiftBasketEntity> FindAll()
        {
            GiftBasketEntity[] _oGiftBasketsArr = GiftBasketRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oGiftBasketsArr != null)
            {
                IList<GiftBasketEntity> _oGiftBasketsList = (IList<GiftBasketEntity>)_oGiftBasketsArr;
                return _oGiftBasketsList;
            }
            return new List<GiftBasketEntity>();
        }

        public static IList<GiftBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<GiftBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<GiftBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<GiftBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            GiftBasketRS x_oShowField = new GiftBasketRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            GiftBasketRS x_oSortField = new GiftBasketRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(GiftBasket.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(GiftBasket.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            GiftBasketRepositoryBase _oGiftBasketRepositoryBase = new GiftBasketRepositoryBase(GetDB());
            return _oGiftBasketRepositoryBase.GetCount();
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

