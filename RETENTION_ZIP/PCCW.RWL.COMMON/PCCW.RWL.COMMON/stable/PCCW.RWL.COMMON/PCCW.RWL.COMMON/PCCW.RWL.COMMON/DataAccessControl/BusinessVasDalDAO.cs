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
///-- Description:	<Description,Table :[BusinessVas],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class BusinessVasDalDAO
    {

        #region RS
        public class BusinessVasRS
        {
            public bool n_bVas_field = false;
            public bool n_bVas_name = false;
            public bool n_bActive = false;
            public bool n_bVas_value = false;
            public bool n_bMulti = false;
            public bool n_bId = false;
            public bool n_bVas_chi_name = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bVas_field || x_bSetShowALL || (BusinessVas.Para.vas_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_field = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVas.Para.vas_field);
                }
                if (this.n_bVas_name || x_bSetShowALL || (BusinessVas.Para.vas_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_name = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVas.Para.vas_name);
                }
                if (this.n_bActive || x_bSetShowALL || (BusinessVas.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVas.Para.active);
                }
                if (this.n_bVas_value || x_bSetShowALL || (BusinessVas.Para.vas_value.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_value = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVas.Para.vas_value);
                }
                if (this.n_bMulti || x_bSetShowALL || (BusinessVas.Para.multi.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMulti = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVas.Para.multi);
                }
                if (this.n_bId || x_bSetShowALL || (BusinessVas.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVas.Para.id);
                }
                if (this.n_bVas_chi_name || x_bSetShowALL || (BusinessVas.Para.vas_chi_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_chi_name = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVas.Para.vas_chi_name);
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

        public BusinessVasDalDAO()
        {
        }
        ~BusinessVasDalDAO()
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
            _oSearchUtils.SetTable(BusinessVas.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BusinessVasEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, BusinessVasRS x_oFieldsToReturn, BusinessVasRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<BusinessVasEntity> _oBusinessVasList = new List<BusinessVasEntity>();

                while (_oDATA.Read())
                {
                    BusinessVas _oBusinessVas = new BusinessVas();
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVas.Para.vas_field])) { _oBusinessVas.SetVas_field((string)_oDATA[BusinessVas.Para.vas_field]); } else { _oBusinessVas.SetVas_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVas.Para.vas_name])) { _oBusinessVas.SetVas_name((string)_oDATA[BusinessVas.Para.vas_name]); } else { _oBusinessVas.SetVas_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVas.Para.active])) { _oBusinessVas.SetActive((global::System.Nullable<bool>)_oDATA[BusinessVas.Para.active]); } else { _oBusinessVas.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_value))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVas.Para.vas_value])) { _oBusinessVas.SetVas_value((string)_oDATA[BusinessVas.Para.vas_value]); } else { _oBusinessVas.SetVas_value(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMulti))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVas.Para.multi])) { _oBusinessVas.SetMulti((global::System.Nullable<bool>)_oDATA[BusinessVas.Para.multi]); } else { _oBusinessVas.SetMulti(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVas.Para.id])) { _oBusinessVas.SetId((global::System.Nullable<int>)_oDATA[BusinessVas.Para.id]); } else { _oBusinessVas.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_chi_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVas.Para.vas_chi_name])) { _oBusinessVas.SetVas_chi_name((string)_oDATA[BusinessVas.Para.vas_chi_name]); } else { _oBusinessVas.SetVas_chi_name(global::System.String.Empty); }
                    }
                    _oBusinessVasList.Add(_oBusinessVas);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBusinessVasList;
            }
            return new List<BusinessVasEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<BusinessVasEntity> OrderBy(string x_sSort, IQueryable<BusinessVasEntity> x_oBusinessVasBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case BusinessVas.Para.vas_field:
                    if (x_bAsc)
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderBy(c => c.vas_field).Select(c => c);
                    else
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderByDescending(c => c.vas_field).Select(c => c);
                    break;
                case BusinessVas.Para.vas_name:
                    if (x_bAsc)
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderBy(c => c.vas_name).Select(c => c);
                    else
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderByDescending(c => c.vas_name).Select(c => c);
                    break;
                case BusinessVas.Para.active:
                    if (x_bAsc)
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case BusinessVas.Para.vas_value:
                    if (x_bAsc)
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderBy(c => c.vas_value).Select(c => c);
                    else
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderByDescending(c => c.vas_value).Select(c => c);
                    break;
                case BusinessVas.Para.multi:
                    if (x_bAsc)
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderBy(c => c.multi).Select(c => c);
                    else
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderByDescending(c => c.multi).Select(c => c);
                    break;
                case BusinessVas.Para.id:
                    if (x_bAsc)
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderBy(c => c.id).Select(c => c);
                    else
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderByDescending(c => c.id).Select(c => c);
                    break;
                case BusinessVas.Para.vas_chi_name:
                    if (x_bAsc)
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderBy(c => c.vas_chi_name).Select(c => c);
                    else
                        x_oBusinessVasBaseList = x_oBusinessVasBaseList.OrderByDescending(c => c.vas_chi_name).Select(c => c);
                    break;
            }
            return x_oBusinessVasBaseList;
        }
        #endregion


        #region FindAll
        public static IList<BusinessVasEntity> FindAll()
        {
            BusinessVasEntity[] _oBusinessVassArr = BusinessVasRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBusinessVassArr != null)
            {
                IList<BusinessVasEntity> _oBusinessVassList = (IList<BusinessVasEntity>)_oBusinessVassArr;
                return _oBusinessVassList;
            }
            return new List<BusinessVasEntity>();
        }

        public static IList<BusinessVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<BusinessVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<BusinessVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<BusinessVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            BusinessVasRS x_oShowField = new BusinessVasRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BusinessVasRS x_oSortField = new BusinessVasRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BusinessVas.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(BusinessVas.Para.id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            BusinessVasRepositoryBase _oBusinessVasRepositoryBase = new BusinessVasRepositoryBase(GetDB());
            return _oBusinessVasRepositoryBase.GetCount();
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

