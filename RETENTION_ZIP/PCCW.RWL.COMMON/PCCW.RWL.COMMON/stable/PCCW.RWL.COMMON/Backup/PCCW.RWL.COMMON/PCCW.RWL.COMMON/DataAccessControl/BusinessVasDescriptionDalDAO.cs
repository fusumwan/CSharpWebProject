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
///-- Description:	<Description,Table :[BusinessVasDescription],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class BusinessVasDescriptionDalDAO
    {

        #region RS
        public class BusinessVasDescriptionRS
        {
            public bool n_bId = false;
            public bool n_bFee = false;
            public bool n_bVas_desc = false;
            public bool n_bActive = false;
            public bool n_bVas = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId || x_bSetShowALL || (BusinessVasDescription.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDescription.Para.id);
                }
                if (this.n_bFee || x_bSetShowALL || (BusinessVasDescription.Para.fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFee = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDescription.Para.fee);
                }
                if (this.n_bVas_desc || x_bSetShowALL || (BusinessVasDescription.Para.vas_desc.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_desc = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDescription.Para.vas_desc);
                }
                if (this.n_bActive || x_bSetShowALL || (BusinessVasDescription.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDescription.Para.active);
                }
                if (this.n_bVas || x_bSetShowALL || (BusinessVasDescription.Para.vas.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BusinessVasDescription.Para.vas);
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

        public BusinessVasDescriptionDalDAO()
        {
        }
        ~BusinessVasDescriptionDalDAO()
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
            _oSearchUtils.SetTable(BusinessVasDescription.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BusinessVasDescriptionEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, BusinessVasDescriptionRS x_oFieldsToReturn, BusinessVasDescriptionRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<BusinessVasDescriptionEntity> _oBusinessVasDescriptionList = new List<BusinessVasDescriptionEntity>();

                while (_oDATA.Read())
                {
                    BusinessVasDescription _oBusinessVasDescription = new BusinessVasDescription();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDescription.Para.id])) { _oBusinessVasDescription.SetId((global::System.Nullable<int>)_oDATA[BusinessVasDescription.Para.id]); } else { _oBusinessVasDescription.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDescription.Para.fee])) { _oBusinessVasDescription.SetFee((string)_oDATA[BusinessVasDescription.Para.fee]); } else { _oBusinessVasDescription.SetFee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_desc))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDescription.Para.vas_desc])) { _oBusinessVasDescription.SetVas_desc((string)_oDATA[BusinessVasDescription.Para.vas_desc]); } else { _oBusinessVasDescription.SetVas_desc(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDescription.Para.active])) { _oBusinessVasDescription.SetActive((global::System.Nullable<bool>)_oDATA[BusinessVasDescription.Para.active]); } else { _oBusinessVasDescription.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BusinessVasDescription.Para.vas])) { _oBusinessVasDescription.SetVas((string)_oDATA[BusinessVasDescription.Para.vas]); } else { _oBusinessVasDescription.SetVas(global::System.String.Empty); }
                    }
                    _oBusinessVasDescriptionList.Add(_oBusinessVasDescription);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBusinessVasDescriptionList;
            }
            return new List<BusinessVasDescriptionEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<BusinessVasDescriptionEntity> OrderBy(string x_sSort, IQueryable<BusinessVasDescriptionEntity> x_oBusinessVasDescriptionBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case BusinessVasDescription.Para.id:
                    if (x_bAsc)
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderBy(c => c.id).Select(c => c);
                    else
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderByDescending(c => c.id).Select(c => c);
                    break;
                case BusinessVasDescription.Para.fee:
                    if (x_bAsc)
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderBy(c => c.fee).Select(c => c);
                    else
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderByDescending(c => c.fee).Select(c => c);
                    break;
                case BusinessVasDescription.Para.vas_desc:
                    if (x_bAsc)
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderBy(c => c.vas_desc).Select(c => c);
                    else
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderByDescending(c => c.vas_desc).Select(c => c);
                    break;
                case BusinessVasDescription.Para.active:
                    if (x_bAsc)
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case BusinessVasDescription.Para.vas:
                    if (x_bAsc)
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderBy(c => c.vas).Select(c => c);
                    else
                        x_oBusinessVasDescriptionBaseList = x_oBusinessVasDescriptionBaseList.OrderByDescending(c => c.vas).Select(c => c);
                    break;
            }
            return x_oBusinessVasDescriptionBaseList;
        }
        #endregion


        #region FindAll
        public static IList<BusinessVasDescriptionEntity> FindAll()
        {
            BusinessVasDescriptionEntity[] _oBusinessVasDescriptionsArr = BusinessVasDescriptionRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBusinessVasDescriptionsArr != null)
            {
                IList<BusinessVasDescriptionEntity> _oBusinessVasDescriptionsList = (IList<BusinessVasDescriptionEntity>)_oBusinessVasDescriptionsArr;
                return _oBusinessVasDescriptionsList;
            }
            return new List<BusinessVasDescriptionEntity>();
        }

        public static IList<BusinessVasDescriptionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<BusinessVasDescriptionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<BusinessVasDescriptionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<BusinessVasDescriptionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            BusinessVasDescriptionRS x_oShowField = new BusinessVasDescriptionRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BusinessVasDescriptionRS x_oSortField = new BusinessVasDescriptionRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BusinessVasDescription.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(BusinessVasDescription.Para.id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            BusinessVasDescriptionRepositoryBase _oBusinessVasDescriptionRepositoryBase = new BusinessVasDescriptionRepositoryBase(GetDB());
            return _oBusinessVasDescriptionRepositoryBase.GetCount();
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

