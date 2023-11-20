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
///-- Description:	<Description,Table :[BusinessVasNameRecord],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class BusinessVasNameRecordDalDAO
    {

        #region RS
        public class BusinessVasNameRecordRS
        {
            public bool n_bVas_field = false;
            public bool n_bVas_name = false;
            public bool n_bId = false;
            public bool n_bActive = false;
            public bool n_bVas_chi_name = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bVas_field || x_bSetShowALL || (BusinessVasNameRecord.Para.vas_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_field = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasNameRecord.Para.vas_field);
                }
                if (this.n_bVas_name || x_bSetShowALL || (BusinessVasNameRecord.Para.vas_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_name = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasNameRecord.Para.vas_name);
                }
                if (this.n_bId || x_bSetShowALL || (BusinessVasNameRecord.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasNameRecord.Para.id);
                }
                if (this.n_bActive || x_bSetShowALL || (BusinessVasNameRecord.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasNameRecord.Para.active);
                }
                if (this.n_bVas_chi_name || x_bSetShowALL || (BusinessVasNameRecord.Para.vas_chi_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_chi_name = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasNameRecord.Para.vas_chi_name);
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

        public BusinessVasNameRecordDalDAO()
        {
        }
        ~BusinessVasNameRecordDalDAO()
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
            _oSearchUtils.SetTable(BusinessVasNameRecord.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BusinessVasNameRecordEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, BusinessVasNameRecordRS x_oFieldsToReturn, BusinessVasNameRecordRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<BusinessVasNameRecordEntity> _oBusinessVasNameRecordList = new List<BusinessVasNameRecordEntity>();

                while (_oDATA.Read())
                {
                    BusinessVasNameRecord _oBusinessVasNameRecord = new BusinessVasNameRecord();
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasNameRecord.Para.vas_field])) { _oBusinessVasNameRecord.SetVas_field((string)_oDATA[BusinessVasNameRecord.Para.vas_field]); } else { _oBusinessVasNameRecord.SetVas_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasNameRecord.Para.vas_name])) { _oBusinessVasNameRecord.SetVas_name((string)_oDATA[BusinessVasNameRecord.Para.vas_name]); } else { _oBusinessVasNameRecord.SetVas_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasNameRecord.Para.id])) { _oBusinessVasNameRecord.SetId((global::System.Nullable<int>)_oDATA[BusinessVasNameRecord.Para.id]); } else { _oBusinessVasNameRecord.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasNameRecord.Para.active])) { _oBusinessVasNameRecord.SetActive((global::System.Nullable<bool>)_oDATA[BusinessVasNameRecord.Para.active]); } else { _oBusinessVasNameRecord.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_chi_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasNameRecord.Para.vas_chi_name])) { _oBusinessVasNameRecord.SetVas_chi_name((string)_oDATA[BusinessVasNameRecord.Para.vas_chi_name]); } else { _oBusinessVasNameRecord.SetVas_chi_name(global::System.String.Empty); }
                    }
                    _oBusinessVasNameRecordList.Add(_oBusinessVasNameRecord);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBusinessVasNameRecordList;
            }
            return new List<BusinessVasNameRecordEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<BusinessVasNameRecordEntity> OrderBy(string x_sSort, IQueryable<BusinessVasNameRecordEntity> x_oBusinessVasNameRecordBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case BusinessVasNameRecord.Para.vas_field:
                    if (x_bAsc)
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderBy(c => c.vas_field).Select(c => c);
                    else
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderByDescending(c => c.vas_field).Select(c => c);
                    break;
                case BusinessVasNameRecord.Para.vas_name:
                    if (x_bAsc)
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderBy(c => c.vas_name).Select(c => c);
                    else
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderByDescending(c => c.vas_name).Select(c => c);
                    break;
                case BusinessVasNameRecord.Para.id:
                    if (x_bAsc)
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderBy(c => c.id).Select(c => c);
                    else
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderByDescending(c => c.id).Select(c => c);
                    break;
                case BusinessVasNameRecord.Para.active:
                    if (x_bAsc)
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case BusinessVasNameRecord.Para.vas_chi_name:
                    if (x_bAsc)
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderBy(c => c.vas_chi_name).Select(c => c);
                    else
                        x_oBusinessVasNameRecordBaseList = x_oBusinessVasNameRecordBaseList.OrderByDescending(c => c.vas_chi_name).Select(c => c);
                    break;
            }
            return x_oBusinessVasNameRecordBaseList;
        }
        #endregion


        #region FindAll
        public static IList<BusinessVasNameRecordEntity> FindAll()
        {
            BusinessVasNameRecordEntity[] _oBusinessVasNameRecordsArr = BusinessVasNameRecordRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBusinessVasNameRecordsArr != null)
            {
                IList<BusinessVasNameRecordEntity> _oBusinessVasNameRecordsList = (IList<BusinessVasNameRecordEntity>)_oBusinessVasNameRecordsArr;
                return _oBusinessVasNameRecordsList;
            }
            return new List<BusinessVasNameRecordEntity>();
        }

        public static IList<BusinessVasNameRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<BusinessVasNameRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<BusinessVasNameRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<BusinessVasNameRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            BusinessVasNameRecordRS x_oShowField = new BusinessVasNameRecordRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BusinessVasNameRecordRS x_oSortField = new BusinessVasNameRecordRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BusinessVasNameRecord.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(BusinessVasNameRecord.Para.id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            BusinessVasNameRecordRepositoryBase _oBusinessVasNameRecordRepositoryBase = new BusinessVasNameRecordRepositoryBase(GetDB());
            return _oBusinessVasNameRecordRepositoryBase.GetCount();
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

