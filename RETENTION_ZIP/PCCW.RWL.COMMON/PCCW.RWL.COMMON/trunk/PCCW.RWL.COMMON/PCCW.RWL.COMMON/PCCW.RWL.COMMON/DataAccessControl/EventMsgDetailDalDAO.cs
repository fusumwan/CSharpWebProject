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
///-- Create date: <Create Date 2010-05-11>
///-- Description:	<Description,Table :[EventMsgDetail],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{

    public abstract class EventMsgDetailDalDAO
    {

        #region RS
        public class EventMsgDetailRS
        {
            public bool n_bCdate = false;
            public bool n_bActive = false;
            public bool n_bAccess_right = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bMessage = false;
            public bool n_bEdate = false;
            public bool n_bSubject = false;
            public bool n_bDdate = false;
            public bool n_bMid = false;
            public bool n_bSdate = false;
            public string FieldsToReturn(string x_sFieldName, bool x_bSetShowALL)
            {
                if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bCdate || x_bSetShowALL || (EventMsgDetail.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.cdate);
                }
                if (this.n_bActive || x_bSetShowALL || (EventMsgDetail.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.active);
                }
                if (this.n_bAccess_right || x_bSetShowALL || (EventMsgDetail.Para.access_right.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAccess_right = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.access_right);
                }
                if (this.n_bCid || x_bSetShowALL || (EventMsgDetail.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.cid);
                }
                if (this.n_bDid || x_bSetShowALL || (EventMsgDetail.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.did);
                }
                if (this.n_bMessage || x_bSetShowALL || (EventMsgDetail.Para.message.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMessage = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.message);
                }
                if (this.n_bEdate || x_bSetShowALL || (EventMsgDetail.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.edate);
                }
                if (this.n_bSubject || x_bSetShowALL || (EventMsgDetail.Para.subject.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSubject = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.subject);
                }
                if (this.n_bDdate || x_bSetShowALL || (EventMsgDetail.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.ddate);
                }
                if (this.n_bMid || x_bSetShowALL || (EventMsgDetail.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.mid);
                }
                if (this.n_bSdate || x_bSetShowALL || (EventMsgDetail.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate = true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EventMsgDetail.Para.sdate);
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

        public EventMsgDetailDalDAO()
        {
        }
        ~EventMsgDetailDalDAO()
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
            _oSearchUtils.SetTable(EventMsgDetail.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<EventMsgDetailEntity> SearchList(List<SearchItem> x_oSearchItems, string x_sRowFilter, long x_lStart, long x_lLimit, EventMsgDetailRS x_oFieldsToReturn, EventMsgDetailRS x_oSortByField, bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems, x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);

            if (_oDATA != null)
            {
                List<EventMsgDetailEntity> _oEventMsgDetailList = new List<EventMsgDetailEntity>();

                while (_oDATA.Read())
                {
                    EventMsgDetail _oEventMsgDetail = new EventMsgDetail();
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.cdate])) { _oEventMsgDetail.SetCdate((global::System.Nullable<DateTime>)_oDATA[EventMsgDetail.Para.cdate]); } else { _oEventMsgDetail.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.active])) { _oEventMsgDetail.SetActive((global::System.Nullable<bool>)_oDATA[EventMsgDetail.Para.active]); } else { _oEventMsgDetail.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAccess_right))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.access_right])) { _oEventMsgDetail.SetAccess_right((string)_oDATA[EventMsgDetail.Para.access_right]); } else { _oEventMsgDetail.SetAccess_right(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.cid])) { _oEventMsgDetail.SetCid((string)_oDATA[EventMsgDetail.Para.cid]); } else { _oEventMsgDetail.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.did])) { _oEventMsgDetail.SetDid((string)_oDATA[EventMsgDetail.Para.did]); } else { _oEventMsgDetail.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMessage))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.message])) { _oEventMsgDetail.SetMessage((string)_oDATA[EventMsgDetail.Para.message]); } else { _oEventMsgDetail.SetMessage(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.edate])) { _oEventMsgDetail.SetEdate((global::System.Nullable<DateTime>)_oDATA[EventMsgDetail.Para.edate]); } else { _oEventMsgDetail.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSubject))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.subject])) { _oEventMsgDetail.SetSubject((string)_oDATA[EventMsgDetail.Para.subject]); } else { _oEventMsgDetail.SetSubject(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.ddate])) { _oEventMsgDetail.SetDdate((global::System.Nullable<DateTime>)_oDATA[EventMsgDetail.Para.ddate]); } else { _oEventMsgDetail.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.mid])) { _oEventMsgDetail.SetMid((global::System.Nullable<int>)_oDATA[EventMsgDetail.Para.mid]); } else { _oEventMsgDetail.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EventMsgDetail.Para.sdate])) { _oEventMsgDetail.SetSdate((global::System.Nullable<DateTime>)_oDATA[EventMsgDetail.Para.sdate]); } else { _oEventMsgDetail.SetSdate(null); }
                    }
                    _oEventMsgDetailList.Add(_oEventMsgDetail);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oEventMsgDetailList;
            }
            return new List<EventMsgDetailEntity>();
        }
        #endregion

        #region Linq OrderBy
        public static IQueryable<EventMsgDetailEntity> OrderBy(string x_sSort, IQueryable<EventMsgDetailEntity> x_oEventMsgDetailBaseList, bool x_bAsc)
        {
            switch (x_sSort)
            {
                case EventMsgDetail.Para.cdate:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.cdate).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                    break;
                case EventMsgDetail.Para.active:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.active).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.active).Select(c => c);
                    break;
                case EventMsgDetail.Para.access_right:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.access_right).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.access_right).Select(c => c);
                    break;
                case EventMsgDetail.Para.cid:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.cid).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.cid).Select(c => c);
                    break;
                case EventMsgDetail.Para.did:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.did).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.did).Select(c => c);
                    break;
                case EventMsgDetail.Para.message:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.message).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.message).Select(c => c);
                    break;
                case EventMsgDetail.Para.edate:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.edate).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.edate).Select(c => c);
                    break;
                case EventMsgDetail.Para.subject:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.subject).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.subject).Select(c => c);
                    break;
                case EventMsgDetail.Para.ddate:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.ddate).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                    break;
                case EventMsgDetail.Para.mid:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.mid).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.mid).Select(c => c);
                    break;
                case EventMsgDetail.Para.sdate:
                    if (x_bAsc)
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderBy(c => c.sdate).Select(c => c);
                    else
                        x_oEventMsgDetailBaseList = x_oEventMsgDetailBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                    break;
            }
            return x_oEventMsgDetailBaseList;
        }
        #endregion


        #region FindAll
        public static IList<EventMsgDetailEntity> FindAll()
        {
            EventMsgDetailEntity[] _oEventMsgDetailsArr = EventMsgDetailRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oEventMsgDetailsArr != null)
            {
                IList<EventMsgDetailEntity> _oEventMsgDetailsList = (IList<EventMsgDetailEntity>)_oEventMsgDetailsArr;
                return _oEventMsgDetailsList;
            }
            return new List<EventMsgDetailEntity>();
        }

        public static IList<EventMsgDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), string.Empty);
        }

        public static IList<EventMsgDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }

        public static IList<EventMsgDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }

        public static IList<EventMsgDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter)
        {
            EventMsgDetailRS x_oShowField = new EventMsgDetailRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            EventMsgDetailRS x_oSortField = new EventMsgDetailRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(EventMsgDetail.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(EventMsgDetail.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, true);
        }
        #endregion


        #region CountAll
        public static int CountAll()
        {
            EventMsgDetailRepositoryBase _oEventMsgDetailRepositoryBase = new EventMsgDetailRepositoryBase(GetDB());
            return _oEventMsgDetailRepositoryBase.GetCount();
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

