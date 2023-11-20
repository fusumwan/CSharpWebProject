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
///-- Description:	<Description,Table :[TariffFeeSchedule],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class TariffFeeScheduleDalDAO
    {

        #region RS
        public class TariffFeeScheduleRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bActive = false;
            public bool n_bProgram = false;
            public bool n_bDdate = false;
            public bool n_bOrg_fee = false;
            public bool n_bDid = false;
            public bool n_bFee = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId || x_bSetShowALL || (TariffFeeSchedule.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.id);
                }
                if (this.n_bCdate || x_bSetShowALL || (TariffFeeSchedule.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.cdate);
                }
                if (this.n_bCid || x_bSetShowALL || (TariffFeeSchedule.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.cid);
                }
                if (this.n_bActive || x_bSetShowALL || (TariffFeeSchedule.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.active);
                }
                if (this.n_bProgram || x_bSetShowALL || (TariffFeeSchedule.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.program);
                }
                if (this.n_bDdate || x_bSetShowALL || (TariffFeeSchedule.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.ddate);
                }
                if (this.n_bOrg_fee || x_bSetShowALL || (TariffFeeSchedule.Para.org_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrg_fee = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.org_fee);
                }
                if (this.n_bDid || x_bSetShowALL || (TariffFeeSchedule.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.did);
                }
                if (this.n_bFee || x_bSetShowALL || (TariffFeeSchedule.Para.fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFee = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(TariffFeeSchedule.Para.fee);
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

        public TariffFeeScheduleDalDAO()
        {
        }
        ~TariffFeeScheduleDalDAO()
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
            _oSearchUtils.SetTable(TariffFeeSchedule.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<TariffFeeScheduleEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, TariffFeeScheduleRS x_oFieldsToReturn, TariffFeeScheduleRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<TariffFeeScheduleEntity> _oTariffFeeScheduleList = new List<TariffFeeScheduleEntity>();

                while (_oDATA.Read())
                {
                    TariffFeeSchedule _oTariffFeeSchedule = new TariffFeeSchedule();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.id])) { _oTariffFeeSchedule.SetId((global::System.Nullable<int>)_oDATA[TariffFeeSchedule.Para.id]); } else { _oTariffFeeSchedule.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.cdate])) { _oTariffFeeSchedule.SetCdate((global::System.Nullable<DateTime>)_oDATA[TariffFeeSchedule.Para.cdate]); } else { _oTariffFeeSchedule.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.cid])) { _oTariffFeeSchedule.SetCid((string)_oDATA[TariffFeeSchedule.Para.cid]); } else { _oTariffFeeSchedule.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.active])) { _oTariffFeeSchedule.SetActive((global::System.Nullable<bool>)_oDATA[TariffFeeSchedule.Para.active]); } else { _oTariffFeeSchedule.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.program])) { _oTariffFeeSchedule.SetProgram((string)_oDATA[TariffFeeSchedule.Para.program]); } else { _oTariffFeeSchedule.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.ddate])) { _oTariffFeeSchedule.SetDdate((global::System.Nullable<DateTime>)_oDATA[TariffFeeSchedule.Para.ddate]); } else { _oTariffFeeSchedule.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrg_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.org_fee])) { _oTariffFeeSchedule.SetOrg_fee((global::System.Nullable<int>)_oDATA[TariffFeeSchedule.Para.org_fee]); } else { _oTariffFeeSchedule.SetOrg_fee(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.did])) { _oTariffFeeSchedule.SetDid((string)_oDATA[TariffFeeSchedule.Para.did]); } else { _oTariffFeeSchedule.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[TariffFeeSchedule.Para.fee])) { _oTariffFeeSchedule.SetFee((string)_oDATA[TariffFeeSchedule.Para.fee]); } else { _oTariffFeeSchedule.SetFee(global::System.String.Empty); }
                    }
                    _oTariffFeeScheduleList.Add(_oTariffFeeSchedule);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oTariffFeeScheduleList;
            }
            return new List<TariffFeeScheduleEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<TariffFeeScheduleEntity> OrderBy(string x_sSort, IQueryable<TariffFeeScheduleEntity> x_oTariffFeeScheduleBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case TariffFeeSchedule.Para.id:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.id).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.id).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.cdate:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.cid:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.active:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.program:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.program).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.program).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.ddate:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.org_fee:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.org_fee).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.org_fee).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.did:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case TariffFeeSchedule.Para.fee:
                    if (x_bAsc)
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderBy(c => c.fee).Select(c => c);
                    else
                        x_oTariffFeeScheduleBaseList = x_oTariffFeeScheduleBaseList.OrderByDescending(c => c.fee).Select(c => c);
                    break;
            }
            return x_oTariffFeeScheduleBaseList;
        }
        #endregion


        #region FindAll
        public static IList<TariffFeeScheduleEntity> FindAll()
        {
            TariffFeeScheduleEntity[] _oTariffFeeSchedulesArr = TariffFeeScheduleRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oTariffFeeSchedulesArr != null)
            {
                IList<TariffFeeScheduleEntity> _oTariffFeeSchedulesList = (IList<TariffFeeScheduleEntity>)_oTariffFeeSchedulesArr;
                return _oTariffFeeSchedulesList;
            }
            return new List<TariffFeeScheduleEntity>();
        }

        public static IList<TariffFeeScheduleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<TariffFeeScheduleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<TariffFeeScheduleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<TariffFeeScheduleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            TariffFeeScheduleRS x_oShowField = new TariffFeeScheduleRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            TariffFeeScheduleRS x_oSortField = new TariffFeeScheduleRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(TariffFeeSchedule.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(TariffFeeSchedule.Para.id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            TariffFeeScheduleRepositoryBase _oTariffFeeScheduleRepositoryBase = new TariffFeeScheduleRepositoryBase(GetDB());
            return _oTariffFeeScheduleRepositoryBase.GetCount();
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

