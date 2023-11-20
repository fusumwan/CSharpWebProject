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
///-- Description:	<Description,Table :[SpecialPremium],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class SpecialPremiumDalDAO
    {

        #region RS
        public class SpecialPremiumRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bCon_per = false;
            public bool n_bRate_plan = false;
            public bool n_bDdate = false;
            public bool n_bMid = false;
            public bool n_bS_premium = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive || x_bSetShowALL || (SpecialPremium.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.active);
                }
                if (this.n_bCdate || x_bSetShowALL || (SpecialPremium.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (SpecialPremium.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.cid);
                }
                if (this.n_bDid || x_bSetShowALL || (SpecialPremium.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.did);
                }
                if (this.n_bCon_per || x_bSetShowALL || (SpecialPremium.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.con_per);
                }
                if (this.n_bRate_plan || x_bSetShowALL || (SpecialPremium.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.rate_plan);
                }
                if (this.n_bDdate || x_bSetShowALL || (SpecialPremium.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.ddate);
                }
                if (this.n_bMid || x_bSetShowALL || (SpecialPremium.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.mid);
                }
                if (this.n_bS_premium || x_bSetShowALL || (SpecialPremium.Para.s_premium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialPremium.Para.s_premium);
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

        public SpecialPremiumDalDAO()
        {
        }
        ~SpecialPremiumDalDAO()
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
            _oSearchUtils.SetTable(SpecialPremium.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<SpecialPremiumEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, SpecialPremiumRS x_oFieldsToReturn, SpecialPremiumRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<SpecialPremiumEntity> _oSpecialPremiumList = new List<SpecialPremiumEntity>();

                while (_oDATA.Read())
                {
                    SpecialPremium _oSpecialPremium = new SpecialPremium();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.active])) { _oSpecialPremium.SetActive((global::System.Nullable<bool>)_oDATA[SpecialPremium.Para.active]); } else { _oSpecialPremium.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.cdate])) { _oSpecialPremium.SetCdate((global::System.Nullable<DateTime>)_oDATA[SpecialPremium.Para.cdate]); } else { _oSpecialPremium.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.cid])) { _oSpecialPremium.SetCid((string)_oDATA[SpecialPremium.Para.cid]); } else { _oSpecialPremium.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.did])) { _oSpecialPremium.SetDid((string)_oDATA[SpecialPremium.Para.did]); } else { _oSpecialPremium.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.con_per])) { _oSpecialPremium.SetCon_per((string)_oDATA[SpecialPremium.Para.con_per]); } else { _oSpecialPremium.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.rate_plan])) { _oSpecialPremium.SetRate_plan((string)_oDATA[SpecialPremium.Para.rate_plan]); } else { _oSpecialPremium.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.ddate])) { _oSpecialPremium.SetDdate((global::System.Nullable<DateTime>)_oDATA[SpecialPremium.Para.ddate]); } else { _oSpecialPremium.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.mid])) { _oSpecialPremium.SetMid((global::System.Nullable<int>)_oDATA[SpecialPremium.Para.mid]); } else { _oSpecialPremium.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialPremium.Para.s_premium])) { _oSpecialPremium.SetS_premium((string)_oDATA[SpecialPremium.Para.s_premium]); } else { _oSpecialPremium.SetS_premium(global::System.String.Empty); }
                    }
                    _oSpecialPremiumList.Add(_oSpecialPremium);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oSpecialPremiumList;
            }
            return new List<SpecialPremiumEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<SpecialPremiumEntity> OrderBy(string x_sSort, IQueryable<SpecialPremiumEntity> x_oSpecialPremiumBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case SpecialPremium.Para.active:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case SpecialPremium.Para.cdate:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case SpecialPremium.Para.cid:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case SpecialPremium.Para.did:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case SpecialPremium.Para.con_per:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.con_per).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                    break;
                case SpecialPremium.Para.rate_plan:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                    break;
                case SpecialPremium.Para.ddate:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case SpecialPremium.Para.mid:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case SpecialPremium.Para.s_premium:
                    if (x_bAsc)
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderBy(c => c.s_premium).Select(c => c);
                    else
                        x_oSpecialPremiumBaseList = x_oSpecialPremiumBaseList.OrderByDescending(c => c.s_premium).Select(c => c);
                    break;
            }
            return x_oSpecialPremiumBaseList;
        }
        #endregion


        #region FindAll
        public static IList<SpecialPremiumEntity> FindAll()
        {
            SpecialPremiumEntity[] _oSpecialPremiumsArr = SpecialPremiumRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oSpecialPremiumsArr != null)
            {
                IList<SpecialPremiumEntity> _oSpecialPremiumsList = (IList<SpecialPremiumEntity>)_oSpecialPremiumsArr;
                return _oSpecialPremiumsList;
            }
            return new List<SpecialPremiumEntity>();
        }

        public static IList<SpecialPremiumEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<SpecialPremiumEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<SpecialPremiumEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<SpecialPremiumEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            SpecialPremiumRS x_oShowField = new SpecialPremiumRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            SpecialPremiumRS x_oSortField = new SpecialPremiumRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(SpecialPremium.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(SpecialPremium.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            SpecialPremiumRepositoryBase _oSpecialPremiumRepositoryBase = new SpecialPremiumRepositoryBase(GetDB());
            return _oSpecialPremiumRepositoryBase.GetCount();
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

