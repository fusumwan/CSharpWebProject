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
///-- Description:	<Description,Table :[Accessory],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class AccessoryDalDAO
    {

        #region RS
        public class AccessoryRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bAccessory_price = false;
            public bool n_bSdate = false;
            public bool n_bAccessory_desc = false;
            public bool n_bLast_stock = false;
            public bool n_bEdate = false;
            public bool n_bAccessory_code = false;
            public bool n_bDdate = false;
            public bool n_bMid = false;
            public bool n_bDid = false;
            public bool n_bQuota = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive || x_bSetShowALL || (Accessory.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.active);
                }
                if (this.n_bCdate || x_bSetShowALL || (Accessory.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (Accessory.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.cid);
                }
                if (this.n_bAccessory_price || x_bSetShowALL || (Accessory.Para.accessory_price.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_price = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.accessory_price);
                }
                if (this.n_bSdate || x_bSetShowALL || (Accessory.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.sdate);
                }
                if (this.n_bAccessory_desc || x_bSetShowALL || (Accessory.Para.accessory_desc.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_desc = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.accessory_desc);
                }
                if (this.n_bLast_stock || x_bSetShowALL || (Accessory.Para.last_stock.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLast_stock = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.last_stock);
                }
                if (this.n_bEdate || x_bSetShowALL || (Accessory.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.edate);
                }
                if (this.n_bAccessory_code || x_bSetShowALL || (Accessory.Para.accessory_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccessory_code = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.accessory_code);
                }
                if (this.n_bDdate || x_bSetShowALL || (Accessory.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.ddate);
                }
                if (this.n_bMid || x_bSetShowALL || (Accessory.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.mid);
                }
                if (this.n_bDid || x_bSetShowALL || (Accessory.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.did);
                }
                if (this.n_bQuota || x_bSetShowALL || (Accessory.Para.quota.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bQuota = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(Accessory.Para.quota);
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

        public AccessoryDalDAO()
        {
        }
        ~AccessoryDalDAO()
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
            _oSearchUtils.SetTable(Accessory.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<AccessoryEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, AccessoryRS x_oFieldsToReturn, AccessoryRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<AccessoryEntity> _oAccessoryList = new List<AccessoryEntity>();

                while (_oDATA.Read())
                {
                    Accessory _oAccessory = new Accessory();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.active])) { _oAccessory.SetActive((global::System.Nullable<bool>)_oDATA[Accessory.Para.active]); } else { _oAccessory.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.cdate])) { _oAccessory.SetCdate((global::System.Nullable<DateTime>)_oDATA[Accessory.Para.cdate]); } else { _oAccessory.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.cid])) { _oAccessory.SetCid((string)_oDATA[Accessory.Para.cid]); } else { _oAccessory.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_price))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.accessory_price])) { _oAccessory.SetAccessory_price((string)_oDATA[Accessory.Para.accessory_price]); } else { _oAccessory.SetAccessory_price(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.sdate])) { _oAccessory.SetSdate((global::System.Nullable<DateTime>)_oDATA[Accessory.Para.sdate]); } else { _oAccessory.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_desc))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.accessory_desc])) { _oAccessory.SetAccessory_desc((string)_oDATA[Accessory.Para.accessory_desc]); } else { _oAccessory.SetAccessory_desc(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLast_stock))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.last_stock])) { _oAccessory.SetLast_stock((global::System.Nullable<bool>)_oDATA[Accessory.Para.last_stock]); } else { _oAccessory.SetLast_stock(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.edate])) { _oAccessory.SetEdate((global::System.Nullable<DateTime>)_oDATA[Accessory.Para.edate]); } else { _oAccessory.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccessory_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.accessory_code])) { _oAccessory.SetAccessory_code((string)_oDATA[Accessory.Para.accessory_code]); } else { _oAccessory.SetAccessory_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.ddate])) { _oAccessory.SetDdate((global::System.Nullable<DateTime>)_oDATA[Accessory.Para.ddate]); } else { _oAccessory.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.mid])) { _oAccessory.SetMid((global::System.Nullable<int>)_oDATA[Accessory.Para.mid]); } else { _oAccessory.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.did])) { _oAccessory.SetDid((string)_oDATA[Accessory.Para.did]); } else { _oAccessory.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bQuota))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[Accessory.Para.quota])) { _oAccessory.SetQuota((string)_oDATA[Accessory.Para.quota]); } else { _oAccessory.SetQuota(global::System.String.Empty); }
                    }
                    _oAccessoryList.Add(_oAccessory);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oAccessoryList;
            }
            return new List<AccessoryEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<AccessoryEntity> OrderBy(string x_sSort, IQueryable<AccessoryEntity> x_oAccessoryBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case Accessory.Para.active:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case Accessory.Para.cdate:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case Accessory.Para.cid:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case Accessory.Para.accessory_price:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.accessory_price).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.accessory_price).Select(c => c);
                    break;
                case Accessory.Para.sdate:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.sdate).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                    break;
                case Accessory.Para.accessory_desc:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.accessory_desc).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.accessory_desc).Select(c => c);
                    break;
                case Accessory.Para.last_stock:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.last_stock).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.last_stock).Select(c => c);
                    break;
                case Accessory.Para.edate:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.edate).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.edate).Select(c => c);
                    break;
                case Accessory.Para.accessory_code:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.accessory_code).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.accessory_code).Select(c => c);
                    break;
                case Accessory.Para.ddate:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case Accessory.Para.mid:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case Accessory.Para.did:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case Accessory.Para.quota:
                    if (x_bAsc)
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderBy(c => c.quota).Select(c => c);
                    else
                        x_oAccessoryBaseList = x_oAccessoryBaseList.OrderByDescending(c => c.quota).Select(c => c);
                    break;
            }
            return x_oAccessoryBaseList;
        }
        #endregion


        #region FindAll
        public static IList<AccessoryEntity> FindAll()
        {
            AccessoryEntity[] _oAccessorysArr = AccessoryRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oAccessorysArr != null)
            {
                IList<AccessoryEntity> _oAccessorysList = (IList<AccessoryEntity>)_oAccessorysArr;
                return _oAccessorysList;
            }
            return new List<AccessoryEntity>();
        }

        public static IList<AccessoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<AccessoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<AccessoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<AccessoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            AccessoryRS x_oShowField = new AccessoryRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            AccessoryRS x_oSortField = new AccessoryRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(Accessory.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(Accessory.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            AccessoryRepositoryBase _oAccessoryRepositoryBase = new AccessoryRepositoryBase(GetDB());
            return _oAccessoryRepositoryBase.GetCount();
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

