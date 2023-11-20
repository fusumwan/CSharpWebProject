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
///-- Description:	<Description,Table :[ProfileTeamDetail],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class ProfileTeamDetailDalDAO
    {

        #region RS
        public class ProfileTeamDetailRS
        {
            public bool n_bMid = false;
            public bool n_bTeamcode = false;
            public bool n_bActive = false;
            public bool n_bSalesmancode = false;
            public bool n_bStaff_no = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bMid || x_bSetShowALL || (ProfileTeamDetail.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamDetail.Para.mid);
                }
                if (this.n_bTeamcode || x_bSetShowALL || (ProfileTeamDetail.Para.teamcode.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTeamcode = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamDetail.Para.teamcode);
                }
                if (this.n_bActive || x_bSetShowALL || (ProfileTeamDetail.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamDetail.Para.active);
                }
                if (this.n_bSalesmancode || x_bSetShowALL || (ProfileTeamDetail.Para.salesmancode.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSalesmancode = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamDetail.Para.salesmancode);
                }
                if (this.n_bStaff_no || x_bSetShowALL || (ProfileTeamDetail.Para.staff_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStaff_no = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamDetail.Para.staff_no);
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

        public ProfileTeamDetailDalDAO()
        {
        }
        ~ProfileTeamDetailDalDAO()
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
            _oSearchUtils.SetTable(ProfileTeamDetail.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<ProfileTeamDetailEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, ProfileTeamDetailRS x_oFieldsToReturn, ProfileTeamDetailRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<ProfileTeamDetailEntity> _oProfileTeamDetailList = new List<ProfileTeamDetailEntity>();

                while (_oDATA.Read())
                {
                    ProfileTeamDetail _oProfileTeamDetail = new ProfileTeamDetail();
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamDetail.Para.mid])) { _oProfileTeamDetail.SetMid((global::System.Nullable<int>)_oDATA[ProfileTeamDetail.Para.mid]); } else { _oProfileTeamDetail.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTeamcode))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamDetail.Para.teamcode])) { _oProfileTeamDetail.SetTeamcode((string)_oDATA[ProfileTeamDetail.Para.teamcode]); } else { _oProfileTeamDetail.SetTeamcode(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamDetail.Para.active])) { _oProfileTeamDetail.SetActive((global::System.Nullable<bool>)_oDATA[ProfileTeamDetail.Para.active]); } else { _oProfileTeamDetail.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSalesmancode))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamDetail.Para.salesmancode])) { _oProfileTeamDetail.SetSalesmancode((string)_oDATA[ProfileTeamDetail.Para.salesmancode]); } else { _oProfileTeamDetail.SetSalesmancode(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStaff_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamDetail.Para.staff_no])) { _oProfileTeamDetail.SetStaff_no((string)_oDATA[ProfileTeamDetail.Para.staff_no]); } else { _oProfileTeamDetail.SetStaff_no(global::System.String.Empty); }
                    }
                    _oProfileTeamDetailList.Add(_oProfileTeamDetail);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oProfileTeamDetailList;
            }
            return new List<ProfileTeamDetailEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<ProfileTeamDetailEntity> OrderBy(string x_sSort, IQueryable<ProfileTeamDetailEntity> x_oProfileTeamDetailBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case ProfileTeamDetail.Para.mid:
                    if (x_bAsc)
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case ProfileTeamDetail.Para.teamcode:
                    if (x_bAsc)
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderBy(c => c.teamcode).Select(c => c);
                    else
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderByDescending(c => c.teamcode).Select(c => c);
                    break;
                case ProfileTeamDetail.Para.active:
                    if (x_bAsc)
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case ProfileTeamDetail.Para.salesmancode:
                    if (x_bAsc)
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderBy(c => c.salesmancode).Select(c => c);
                    else
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderByDescending(c => c.salesmancode).Select(c => c);
                    break;
                case ProfileTeamDetail.Para.staff_no:
                    if (x_bAsc)
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderBy(c => c.staff_no).Select(c => c);
                    else
                        x_oProfileTeamDetailBaseList = x_oProfileTeamDetailBaseList.OrderByDescending(c => c.staff_no).Select(c => c);
                    break;
            }
            return x_oProfileTeamDetailBaseList;
        }
        #endregion


        #region FindAll
        public static IList<ProfileTeamDetailEntity> FindAll()
        {
            ProfileTeamDetailEntity[] _oProfileTeamDetailsArr = ProfileTeamDetailRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oProfileTeamDetailsArr != null)
            {
                IList<ProfileTeamDetailEntity> _oProfileTeamDetailsList = (IList<ProfileTeamDetailEntity>)_oProfileTeamDetailsArr;
                return _oProfileTeamDetailsList;
            }
            return new List<ProfileTeamDetailEntity>();
        }

        public static IList<ProfileTeamDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<ProfileTeamDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<ProfileTeamDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<ProfileTeamDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            ProfileTeamDetailRS x_oShowField = new ProfileTeamDetailRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            ProfileTeamDetailRS x_oSortField = new ProfileTeamDetailRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(ProfileTeamDetail.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(ProfileTeamDetail.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            ProfileTeamDetailRepositoryBase _oProfileTeamDetailRepositoryBase = new ProfileTeamDetailRepositoryBase(GetDB());
            return _oProfileTeamDetailRepositoryBase.GetCount();
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

