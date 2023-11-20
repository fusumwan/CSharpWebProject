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
///-- Description:	<Description,Table :[AutoSelectionProperty],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class AutoSelectionPropertyDalDAO
    {

        #region RS
        public class AutoSelectionPropertyRS
        {
            public bool n_bId = false;
            public bool n_bPeriod = false;
            public bool n_bStart_date = false;
            public bool n_bObprogram = false;
            public bool n_bChannel = false;
            public bool n_bTier = false;
            public bool n_bTradefield_mid = false;
            public bool n_bUid = false;
            public bool n_bEnd_date = false;
            public bool n_bPlan_fee = false;
            public bool n_bRemarks = false;
            public bool n_bPo_date = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId || x_bSetShowALL || (AutoSelectionProperty.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.id);
                }
                if (this.n_bPeriod || x_bSetShowALL || (AutoSelectionProperty.Para.period.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPeriod = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.period);
                }
                if (this.n_bStart_date || x_bSetShowALL || (AutoSelectionProperty.Para.start_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStart_date = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.start_date);
                }
                if (this.n_bObprogram || x_bSetShowALL || (AutoSelectionProperty.Para.obprogram.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bObprogram = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.obprogram);
                }
                if (this.n_bChannel || x_bSetShowALL || (AutoSelectionProperty.Para.channel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bChannel = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.channel);
                }
                if (this.n_bTier || x_bSetShowALL || (AutoSelectionProperty.Para.tier.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTier = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.tier);
                }
                if (this.n_bTradefield_mid || x_bSetShowALL || (AutoSelectionProperty.Para.tradefield_mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTradefield_mid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.tradefield_mid);
                }
                if (this.n_bUid || x_bSetShowALL || (AutoSelectionProperty.Para.uid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.uid);
                }
                if (this.n_bEnd_date || x_bSetShowALL || (AutoSelectionProperty.Para.end_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEnd_date = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.end_date);
                }
                if (this.n_bPlan_fee || x_bSetShowALL || (AutoSelectionProperty.Para.plan_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_fee = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.plan_fee);
                }
                if (this.n_bRemarks || x_bSetShowALL || (AutoSelectionProperty.Para.remarks.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemarks = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.remarks);
                }
                if (this.n_bPo_date || x_bSetShowALL || (AutoSelectionProperty.Para.po_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPo_date = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(AutoSelectionProperty.Para.po_date);
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

        public AutoSelectionPropertyDalDAO()
        {
        }
        ~AutoSelectionPropertyDalDAO()
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
            _oSearchUtils.SetTable(AutoSelectionProperty.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<AutoSelectionPropertyEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, AutoSelectionPropertyRS x_oFieldsToReturn, AutoSelectionPropertyRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<AutoSelectionPropertyEntity> _oAutoSelectionPropertyList = new List<AutoSelectionPropertyEntity>();

                while (_oDATA.Read())
                {
                    AutoSelectionProperty _oAutoSelectionProperty = new AutoSelectionProperty();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.id])) { _oAutoSelectionProperty.SetId((global::System.Nullable<int>)_oDATA[AutoSelectionProperty.Para.id]); } else { _oAutoSelectionProperty.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPeriod))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.period])) { _oAutoSelectionProperty.SetPeriod((string)_oDATA[AutoSelectionProperty.Para.period]); } else { _oAutoSelectionProperty.SetPeriod(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStart_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.start_date])) { _oAutoSelectionProperty.SetStart_date((global::System.Nullable<DateTime>)_oDATA[AutoSelectionProperty.Para.start_date]); } else { _oAutoSelectionProperty.SetStart_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bObprogram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.obprogram])) { _oAutoSelectionProperty.SetObprogram((string)_oDATA[AutoSelectionProperty.Para.obprogram]); } else { _oAutoSelectionProperty.SetObprogram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bChannel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.channel])) { _oAutoSelectionProperty.SetChannel((string)_oDATA[AutoSelectionProperty.Para.channel]); } else { _oAutoSelectionProperty.SetChannel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTier))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.tier])) { _oAutoSelectionProperty.SetTier((string)_oDATA[AutoSelectionProperty.Para.tier]); } else { _oAutoSelectionProperty.SetTier(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTradefield_mid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.tradefield_mid])) { _oAutoSelectionProperty.SetTradefield_mid((global::System.Nullable<int>)_oDATA[AutoSelectionProperty.Para.tradefield_mid]); } else { _oAutoSelectionProperty.SetTradefield_mid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.uid])) { _oAutoSelectionProperty.SetUid((string)_oDATA[AutoSelectionProperty.Para.uid]); } else { _oAutoSelectionProperty.SetUid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEnd_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.end_date])) { _oAutoSelectionProperty.SetEnd_date((global::System.Nullable<DateTime>)_oDATA[AutoSelectionProperty.Para.end_date]); } else { _oAutoSelectionProperty.SetEnd_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.plan_fee])) { _oAutoSelectionProperty.SetPlan_fee((string)_oDATA[AutoSelectionProperty.Para.plan_fee]); } else { _oAutoSelectionProperty.SetPlan_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemarks))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.remarks])) { _oAutoSelectionProperty.SetRemarks((string)_oDATA[AutoSelectionProperty.Para.remarks]); } else { _oAutoSelectionProperty.SetRemarks(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPo_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[AutoSelectionProperty.Para.po_date])) { _oAutoSelectionProperty.SetPo_date((global::System.Nullable<DateTime>)_oDATA[AutoSelectionProperty.Para.po_date]); } else { _oAutoSelectionProperty.SetPo_date(null); }
                    }
                    _oAutoSelectionPropertyList.Add(_oAutoSelectionProperty);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oAutoSelectionPropertyList;
            }
            return new List<AutoSelectionPropertyEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<AutoSelectionPropertyEntity> OrderBy(string x_sSort, IQueryable<AutoSelectionPropertyEntity> x_oAutoSelectionPropertyBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case AutoSelectionProperty.Para.id:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.id).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.id).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.period:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.period).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.period).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.start_date:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.start_date).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.start_date).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.obprogram:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.obprogram).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.obprogram).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.channel:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.channel).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.channel).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.tier:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.tier).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.tier).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.tradefield_mid:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.tradefield_mid).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.tradefield_mid).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.uid:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.uid).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.uid).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.end_date:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.end_date).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.end_date).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.plan_fee:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.plan_fee).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.plan_fee).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.remarks:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.remarks).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.remarks).Select(c => c);
                    break;
                case AutoSelectionProperty.Para.po_date:
                    if (x_bAsc)
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderBy(c => c.po_date).Select(c => c);
                    else
                        x_oAutoSelectionPropertyBaseList = x_oAutoSelectionPropertyBaseList.OrderByDescending(c => c.po_date).Select(c => c);
                    break;
            }
            return x_oAutoSelectionPropertyBaseList;
        }
        #endregion


        #region FindAll
        public static IList<AutoSelectionPropertyEntity> FindAll()
        {
            AutoSelectionPropertyEntity[] _oAutoSelectionPropertysArr = AutoSelectionPropertyRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oAutoSelectionPropertysArr != null)
            {
                IList<AutoSelectionPropertyEntity> _oAutoSelectionPropertysList = (IList<AutoSelectionPropertyEntity>)_oAutoSelectionPropertysArr;
                return _oAutoSelectionPropertysList;
            }
            return new List<AutoSelectionPropertyEntity>();
        }

        public static IList<AutoSelectionPropertyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<AutoSelectionPropertyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<AutoSelectionPropertyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<AutoSelectionPropertyEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            AutoSelectionPropertyRS x_oShowField = new AutoSelectionPropertyRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            AutoSelectionPropertyRS x_oSortField = new AutoSelectionPropertyRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(AutoSelectionProperty.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(AutoSelectionProperty.Para.id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            AutoSelectionPropertyRepositoryBase _oAutoSelectionPropertyRepositoryBase = new AutoSelectionPropertyRepositoryBase(GetDB());
            return _oAutoSelectionPropertyRepositoryBase.GetCount();
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

