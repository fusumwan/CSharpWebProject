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
///-- Description:	<Description,Table :[RebateGroup],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class RebateGroupDalDAO
    {

        #region RS
        public class RebateGroupRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bGp = false;
            public bool n_bProgram = false;
            public bool n_bDdate = false;
            public bool n_bMid = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive || x_bSetShowALL || (RebateGroup.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.active);
                }
                if (this.n_bCdate || x_bSetShowALL || (RebateGroup.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (RebateGroup.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.cid);
                }
                if (this.n_bDid || x_bSetShowALL || (RebateGroup.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.did);
                }
                if (this.n_bGp || x_bSetShowALL || (RebateGroup.Para.gp.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGp = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.gp);
                }
                if (this.n_bProgram || x_bSetShowALL || (RebateGroup.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.program);
                }
                if (this.n_bDdate || x_bSetShowALL || (RebateGroup.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.ddate);
                }
                if (this.n_bMid || x_bSetShowALL || (RebateGroup.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RebateGroup.Para.mid);
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

        public RebateGroupDalDAO()
        {
        }
        ~RebateGroupDalDAO()
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
            _oSearchUtils.SetTable(RebateGroup.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<RebateGroupEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, RebateGroupRS x_oFieldsToReturn, RebateGroupRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<RebateGroupEntity> _oRebateGroupList = new List<RebateGroupEntity>();

                while (_oDATA.Read())
                {
                    RebateGroup _oRebateGroup = new RebateGroup();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.active])) { _oRebateGroup.SetActive((global::System.Nullable<bool>)_oDATA[RebateGroup.Para.active]); } else { _oRebateGroup.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.cdate])) { _oRebateGroup.SetCdate((global::System.Nullable<DateTime>)_oDATA[RebateGroup.Para.cdate]); } else { _oRebateGroup.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.cid])) { _oRebateGroup.SetCid((string)_oDATA[RebateGroup.Para.cid]); } else { _oRebateGroup.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.did])) { _oRebateGroup.SetDid((string)_oDATA[RebateGroup.Para.did]); } else { _oRebateGroup.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGp))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.gp])) { _oRebateGroup.SetGp((string)_oDATA[RebateGroup.Para.gp]); } else { _oRebateGroup.SetGp(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.program])) { _oRebateGroup.SetProgram((string)_oDATA[RebateGroup.Para.program]); } else { _oRebateGroup.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.ddate])) { _oRebateGroup.SetDdate((global::System.Nullable<DateTime>)_oDATA[RebateGroup.Para.ddate]); } else { _oRebateGroup.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RebateGroup.Para.mid])) { _oRebateGroup.SetMid((global::System.Nullable<int>)_oDATA[RebateGroup.Para.mid]); } else { _oRebateGroup.SetMid(null); }
                    }
                    _oRebateGroupList.Add(_oRebateGroup);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oRebateGroupList;
            }
            return new List<RebateGroupEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<RebateGroupEntity> OrderBy(string x_sSort, IQueryable<RebateGroupEntity> x_oRebateGroupBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case RebateGroup.Para.active:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case RebateGroup.Para.cdate:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case RebateGroup.Para.cid:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case RebateGroup.Para.did:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case RebateGroup.Para.gp:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.gp).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.gp).Select(c => c);
                    break;
                case RebateGroup.Para.program:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.program).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.program).Select(c => c);
                    break;
                case RebateGroup.Para.ddate:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case RebateGroup.Para.mid:
                    if (x_bAsc)
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oRebateGroupBaseList = x_oRebateGroupBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
            }
            return x_oRebateGroupBaseList;
        }
        #endregion


        #region FindAll
        public static IList<RebateGroupEntity> FindAll()
        {
            RebateGroupEntity[] _oRebateGroupsArr = RebateGroupRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oRebateGroupsArr != null)
            {
                IList<RebateGroupEntity> _oRebateGroupsList = (IList<RebateGroupEntity>)_oRebateGroupsArr;
                return _oRebateGroupsList;
            }
            return new List<RebateGroupEntity>();
        }

        public static IList<RebateGroupEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<RebateGroupEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<RebateGroupEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<RebateGroupEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            RebateGroupRS x_oShowField = new RebateGroupRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            RebateGroupRS x_oSortField = new RebateGroupRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(RebateGroup.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(RebateGroup.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            RebateGroupRepositoryBase _oRebateGroupRepositoryBase = new RebateGroupRepositoryBase(GetDB());
            return _oRebateGroupRepositoryBase.GetCount();
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

