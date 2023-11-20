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
///-- Description:	<Description,Table :[RetentionPlan],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class RetentionPlanDalDAO
    {

        #region RS
        public class RetentionPlanRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bActive = false;
            public bool n_bPlan_code = false;
            public bool n_bPlan_fee = false;
            public bool n_bDdate = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId || x_bSetShowALL || (RetentionPlan.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.id);
                }
                if (this.n_bCdate || x_bSetShowALL || (RetentionPlan.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (RetentionPlan.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.cid);
                }
                if (this.n_bDid || x_bSetShowALL || (RetentionPlan.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.did);
                }
                if (this.n_bActive || x_bSetShowALL || (RetentionPlan.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.active);
                }
                if (this.n_bPlan_code || x_bSetShowALL || (RetentionPlan.Para.plan_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_code = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.plan_code);
                }
                if (this.n_bPlan_fee || x_bSetShowALL || (RetentionPlan.Para.plan_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_fee = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.plan_fee);
                }
                if (this.n_bDdate || x_bSetShowALL || (RetentionPlan.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlan.Para.ddate);
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

        public RetentionPlanDalDAO()
        {
        }
        ~RetentionPlanDalDAO()
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
            _oSearchUtils.SetTable(RetentionPlan.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<RetentionPlanEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, RetentionPlanRS x_oFieldsToReturn, RetentionPlanRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<RetentionPlanEntity> _oRetentionPlanList = new List<RetentionPlanEntity>();

                while (_oDATA.Read())
                {
                    RetentionPlan _oRetentionPlan = new RetentionPlan();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.id])) { _oRetentionPlan.SetId((global::System.Nullable<int>)_oDATA[RetentionPlan.Para.id]); } else { _oRetentionPlan.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.cdate])) { _oRetentionPlan.SetCdate((global::System.Nullable<DateTime>)_oDATA[RetentionPlan.Para.cdate]); } else { _oRetentionPlan.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.cid])) { _oRetentionPlan.SetCid((string)_oDATA[RetentionPlan.Para.cid]); } else { _oRetentionPlan.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.did])) { _oRetentionPlan.SetDid((string)_oDATA[RetentionPlan.Para.did]); } else { _oRetentionPlan.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.active])) { _oRetentionPlan.SetActive((global::System.Nullable<bool>)_oDATA[RetentionPlan.Para.active]); } else { _oRetentionPlan.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.plan_code])) { _oRetentionPlan.SetPlan_code((string)_oDATA[RetentionPlan.Para.plan_code]); } else { _oRetentionPlan.SetPlan_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.plan_fee])) { _oRetentionPlan.SetPlan_fee((global::System.Nullable<double>)_oDATA[RetentionPlan.Para.plan_fee]); } else { _oRetentionPlan.SetPlan_fee(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlan.Para.ddate])) { _oRetentionPlan.SetDdate((global::System.Nullable<DateTime>)_oDATA[RetentionPlan.Para.ddate]); } else { _oRetentionPlan.SetDdate(null); }
                    }
                    _oRetentionPlanList.Add(_oRetentionPlan);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oRetentionPlanList;
            }
            return new List<RetentionPlanEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<RetentionPlanEntity> OrderBy(string x_sSort, IQueryable<RetentionPlanEntity> x_oRetentionPlanBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case RetentionPlan.Para.id:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.id).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.id).Select(c => c);
                    break;
                case RetentionPlan.Para.cdate:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case RetentionPlan.Para.cid:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case RetentionPlan.Para.did:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case RetentionPlan.Para.active:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case RetentionPlan.Para.plan_code:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.plan_code).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.plan_code).Select(c => c);
                    break;
                case RetentionPlan.Para.plan_fee:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.plan_fee).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.plan_fee).Select(c => c);
                    break;
                case RetentionPlan.Para.ddate:
                    if (x_bAsc)
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oRetentionPlanBaseList = x_oRetentionPlanBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
            }
            return x_oRetentionPlanBaseList;
        }
        #endregion


        #region FindAll
        public static IList<RetentionPlanEntity> FindAll()
        {
            RetentionPlanEntity[] _oRetentionPlansArr = RetentionPlanRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oRetentionPlansArr != null)
            {
                IList<RetentionPlanEntity> _oRetentionPlansList = (IList<RetentionPlanEntity>)_oRetentionPlansArr;
                return _oRetentionPlansList;
            }
            return new List<RetentionPlanEntity>();
        }

        public static IList<RetentionPlanEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<RetentionPlanEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<RetentionPlanEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<RetentionPlanEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            RetentionPlanRS x_oShowField = new RetentionPlanRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            RetentionPlanRS x_oSortField = new RetentionPlanRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(RetentionPlan.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(RetentionPlan.Para.id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            RetentionPlanRepositoryBase _oRetentionPlanRepositoryBase = new RetentionPlanRepositoryBase(GetDB());
            return _oRetentionPlanRepositoryBase.GetCount();
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

