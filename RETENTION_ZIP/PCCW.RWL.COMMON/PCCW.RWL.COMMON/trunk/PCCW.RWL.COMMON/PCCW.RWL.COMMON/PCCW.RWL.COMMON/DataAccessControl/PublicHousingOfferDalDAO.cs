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
///-- Description:	<Description,Table :[PublicHousingOffer],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class PublicHousingOfferDalDAO
    {

        #region RS
        public class PublicHousingOfferRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bActive = false;
            public bool n_bSdate = false;
            public bool n_bS_premium2 = false;
            public bool n_bEdate = false;
            public bool n_bProgram = false;
            public bool n_bDdate = false;
            public bool n_bDid = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId || x_bSetShowALL || (PublicHousingOffer.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.id);
                }
                if (this.n_bCdate || x_bSetShowALL || (PublicHousingOffer.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (PublicHousingOffer.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.cid);
                }
                if (this.n_bActive || x_bSetShowALL || (PublicHousingOffer.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.active);
                }
                if (this.n_bSdate || x_bSetShowALL || (PublicHousingOffer.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.sdate);
                }
                if (this.n_bS_premium2 || x_bSetShowALL || (PublicHousingOffer.Para.s_premium2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bS_premium2 = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.s_premium2);
                }
                if (this.n_bEdate || x_bSetShowALL || (PublicHousingOffer.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.edate);
                }
                if (this.n_bProgram || x_bSetShowALL || (PublicHousingOffer.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.program);
                }
                if (this.n_bDdate || x_bSetShowALL || (PublicHousingOffer.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.ddate);
                }
                if (this.n_bDid || x_bSetShowALL || (PublicHousingOffer.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(PublicHousingOffer.Para.did);
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

        public PublicHousingOfferDalDAO()
        {
        }
        ~PublicHousingOfferDalDAO()
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
            _oSearchUtils.SetTable(PublicHousingOffer.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<PublicHousingOfferEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, PublicHousingOfferRS x_oFieldsToReturn, PublicHousingOfferRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<PublicHousingOfferEntity> _oPublicHousingOfferList = new List<PublicHousingOfferEntity>();

                while (_oDATA.Read())
                {
                    PublicHousingOffer _oPublicHousingOffer = new PublicHousingOffer();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.id])) { _oPublicHousingOffer.SetId((global::System.Nullable<int>)_oDATA[PublicHousingOffer.Para.id]); } else { _oPublicHousingOffer.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.cdate])) { _oPublicHousingOffer.SetCdate((global::System.Nullable<DateTime>)_oDATA[PublicHousingOffer.Para.cdate]); } else { _oPublicHousingOffer.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.cid])) { _oPublicHousingOffer.SetCid((string)_oDATA[PublicHousingOffer.Para.cid]); } else { _oPublicHousingOffer.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.active])) { _oPublicHousingOffer.SetActive((global::System.Nullable<bool>)_oDATA[PublicHousingOffer.Para.active]); } else { _oPublicHousingOffer.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.sdate])) { _oPublicHousingOffer.SetSdate((global::System.Nullable<DateTime>)_oDATA[PublicHousingOffer.Para.sdate]); } else { _oPublicHousingOffer.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bS_premium2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.s_premium2])) { _oPublicHousingOffer.SetS_premium2((string)_oDATA[PublicHousingOffer.Para.s_premium2]); } else { _oPublicHousingOffer.SetS_premium2(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.edate])) { _oPublicHousingOffer.SetEdate((global::System.Nullable<DateTime>)_oDATA[PublicHousingOffer.Para.edate]); } else { _oPublicHousingOffer.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.program])) { _oPublicHousingOffer.SetProgram((string)_oDATA[PublicHousingOffer.Para.program]); } else { _oPublicHousingOffer.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.ddate])) { _oPublicHousingOffer.SetDdate((global::System.Nullable<DateTime>)_oDATA[PublicHousingOffer.Para.ddate]); } else { _oPublicHousingOffer.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[PublicHousingOffer.Para.did])) { _oPublicHousingOffer.SetDid((string)_oDATA[PublicHousingOffer.Para.did]); } else { _oPublicHousingOffer.SetDid(global::System.String.Empty); }
                    }
                    _oPublicHousingOfferList.Add(_oPublicHousingOffer);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oPublicHousingOfferList;
            }
            return new List<PublicHousingOfferEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<PublicHousingOfferEntity> OrderBy(string x_sSort, IQueryable<PublicHousingOfferEntity> x_oPublicHousingOfferBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case PublicHousingOffer.Para.id:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.id).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.id).Select(c => c);
                    break;
                case PublicHousingOffer.Para.cdate:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case PublicHousingOffer.Para.cid:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case PublicHousingOffer.Para.active:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case PublicHousingOffer.Para.sdate:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.sdate).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                    break;
                case PublicHousingOffer.Para.s_premium2:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.s_premium2).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.s_premium2).Select(c => c);
                    break;
                case PublicHousingOffer.Para.edate:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.edate).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.edate).Select(c => c);
                    break;
                case PublicHousingOffer.Para.program:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.program).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.program).Select(c => c);
                    break;
                case PublicHousingOffer.Para.ddate:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case PublicHousingOffer.Para.did:
                    if (x_bAsc)
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oPublicHousingOfferBaseList = x_oPublicHousingOfferBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
            }
            return x_oPublicHousingOfferBaseList;
        }
        #endregion


        #region FindAll
        public static IList<PublicHousingOfferEntity> FindAll()
        {
            PublicHousingOfferEntity[] _oPublicHousingOffersArr = PublicHousingOfferRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oPublicHousingOffersArr != null)
            {
                IList<PublicHousingOfferEntity> _oPublicHousingOffersList = (IList<PublicHousingOfferEntity>)_oPublicHousingOffersArr;
                return _oPublicHousingOffersList;
            }
            return new List<PublicHousingOfferEntity>();
        }

        public static IList<PublicHousingOfferEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<PublicHousingOfferEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<PublicHousingOfferEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<PublicHousingOfferEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            PublicHousingOfferRS x_oShowField = new PublicHousingOfferRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            PublicHousingOfferRS x_oSortField = new PublicHousingOfferRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(PublicHousingOffer.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(PublicHousingOffer.Para.id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            PublicHousingOfferRepositoryBase _oPublicHousingOfferRepositoryBase = new PublicHousingOfferRepositoryBase(GetDB());
            return _oPublicHousingOfferRepositoryBase.GetCount();
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

