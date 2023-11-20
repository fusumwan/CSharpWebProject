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
///-- Description:	<Description,Table :[SuspendEventDetail],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class SuspendEventDetailDalDAO
    {

        #region RS
        public class SuspendEventDetailRS
        {
            public bool n_bMid = false;
            public bool n_bActive = false;
            public bool n_bReasons = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bMid || x_bSetShowALL || (SuspendEventDetail.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SuspendEventDetail.Para.mid);
                }
                if (this.n_bActive || x_bSetShowALL || (SuspendEventDetail.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SuspendEventDetail.Para.active);
                }
                if (this.n_bReasons || x_bSetShowALL || (SuspendEventDetail.Para.reasons.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReasons = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SuspendEventDetail.Para.reasons);
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

        public SuspendEventDetailDalDAO()
        {
        }
        ~SuspendEventDetailDalDAO()
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
            _oSearchUtils.SetTable(SuspendEventDetail.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<SuspendEventDetailEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, SuspendEventDetailRS x_oFieldsToReturn, SuspendEventDetailRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<SuspendEventDetailEntity> _oSuspendEventDetailList = new List<SuspendEventDetailEntity>();

                while (_oDATA.Read())
                {
                    SuspendEventDetail _oSuspendEventDetail = new SuspendEventDetail();
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SuspendEventDetail.Para.mid])) { _oSuspendEventDetail.SetMid((global::System.Nullable<int>)_oDATA[SuspendEventDetail.Para.mid]); } else { _oSuspendEventDetail.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SuspendEventDetail.Para.active])) { _oSuspendEventDetail.SetActive((global::System.Nullable<bool>)_oDATA[SuspendEventDetail.Para.active]); } else { _oSuspendEventDetail.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReasons))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SuspendEventDetail.Para.reasons])) { _oSuspendEventDetail.SetReasons((string)_oDATA[SuspendEventDetail.Para.reasons]); } else { _oSuspendEventDetail.SetReasons(global::System.String.Empty); }
                    }
                    _oSuspendEventDetailList.Add(_oSuspendEventDetail);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oSuspendEventDetailList;
            }
            return new List<SuspendEventDetailEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<SuspendEventDetailEntity> OrderBy(string x_sSort, IQueryable<SuspendEventDetailEntity> x_oSuspendEventDetailBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case SuspendEventDetail.Para.mid:
                    if (x_bAsc)
                        x_oSuspendEventDetailBaseList = x_oSuspendEventDetailBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oSuspendEventDetailBaseList = x_oSuspendEventDetailBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case SuspendEventDetail.Para.active:
                    if (x_bAsc)
                        x_oSuspendEventDetailBaseList = x_oSuspendEventDetailBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oSuspendEventDetailBaseList = x_oSuspendEventDetailBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case SuspendEventDetail.Para.reasons:
                    if (x_bAsc)
                        x_oSuspendEventDetailBaseList = x_oSuspendEventDetailBaseList.OrderBy(c => c.reasons).Select(c => c);
                    else
                        x_oSuspendEventDetailBaseList = x_oSuspendEventDetailBaseList.OrderByDescending(c => c.reasons).Select(c => c);
                    break;
            }
            return x_oSuspendEventDetailBaseList;
        }
        #endregion


        #region FindAll
        public static IList<SuspendEventDetailEntity> FindAll()
        {
            SuspendEventDetailEntity[] _oSuspendEventDetailsArr = SuspendEventDetailRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oSuspendEventDetailsArr != null)
            {
                IList<SuspendEventDetailEntity> _oSuspendEventDetailsList = (IList<SuspendEventDetailEntity>)_oSuspendEventDetailsArr;
                return _oSuspendEventDetailsList;
            }
            return new List<SuspendEventDetailEntity>();
        }

        public static IList<SuspendEventDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<SuspendEventDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<SuspendEventDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<SuspendEventDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            SuspendEventDetailRS x_oShowField = new SuspendEventDetailRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            SuspendEventDetailRS x_oSortField = new SuspendEventDetailRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(SuspendEventDetail.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(SuspendEventDetail.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            SuspendEventDetailRepositoryBase _oSuspendEventDetailRepositoryBase = new SuspendEventDetailRepositoryBase(GetDB());
            return _oSuspendEventDetailRepositoryBase.GetCount();
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

