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
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Table :[MobileOrderFallout],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderFalloutDalDAO{
        
        #region RS
        public class MobileOrderFalloutRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bDdate = false;
            public bool n_bFo_reason = false;
            public bool n_bMid = false;
            public bool n_bFollow_by = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderFallout.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.active);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderFallout.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderFallout.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderFallout.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.did);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderFallout.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.ddate);
                }
                if (this.n_bFo_reason  || x_bSetShowALL || (MobileOrderFallout.Para.fo_reason.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFo_reason=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.fo_reason);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderFallout.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.mid);
                }
                if (this.n_bFollow_by  || x_bSetShowALL || (MobileOrderFallout.Para.follow_by.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFollow_by=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderFallout.Para.follow_by);
                }
                return _oFR.ToString();
            }
            
            public string FieldsToReturn()
            {
                return this.FieldsToReturn(string.Empty,false);
            }
            
        }
        #endregion
        #region Constructor
        
        public MobileOrderFalloutDalDAO(){
        }
        ~MobileOrderFalloutDalDAO(){
            this.Release();
        }
        #endregion
        
        #region Search Engine
        public static global::System.Data.SqlClient.SqlDataReader DrSearch(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, string x_sFieldsToReturn,string x_sSortByField,bool x_bAscDirection)
        {
            SearchUtils _oSearchUtils = new SearchUtils();
            _oSearchUtils.SetSearchItems(x_oSearchItems);
            _oSearchUtils.SetRowFilter(x_sRowFilter);
            _oSearchUtils.SetStart(x_lStart);
            _oSearchUtils.SetLimit(x_lLimit);
            _oSearchUtils.SetFieldsToReturn(x_sFieldsToReturn);
            _oSearchUtils.SetOrderByField(x_sSortByField);
            _oSearchUtils.SetAscDirection(x_bAscDirection);
            _oSearchUtils.SetTable(MobileOrderFallout.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderFalloutEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderFalloutRS x_oFieldsToReturn,MobileOrderFalloutRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderFalloutEntity> _oMobileOrderFalloutList = new List<MobileOrderFalloutEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderFallout _oMobileOrderFallout = new MobileOrderFallout();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.active])) { _oMobileOrderFallout.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderFallout.Para.active]); } else { _oMobileOrderFallout.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.cdate])) { _oMobileOrderFallout.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderFallout.Para.cdate]); } else { _oMobileOrderFallout.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.cid])) { _oMobileOrderFallout.SetCid((string)_oDATA[MobileOrderFallout.Para.cid]); } else { _oMobileOrderFallout.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.did])) { _oMobileOrderFallout.SetDid((string)_oDATA[MobileOrderFallout.Para.did]); } else { _oMobileOrderFallout.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.ddate])) { _oMobileOrderFallout.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderFallout.Para.ddate]); } else { _oMobileOrderFallout.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFo_reason))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.fo_reason])) { _oMobileOrderFallout.SetFo_reason((string)_oDATA[MobileOrderFallout.Para.fo_reason]); } else { _oMobileOrderFallout.SetFo_reason(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.mid])) { _oMobileOrderFallout.SetMid((global::System.Nullable<int>)_oDATA[MobileOrderFallout.Para.mid]); } else { _oMobileOrderFallout.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFollow_by))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderFallout.Para.follow_by])) { _oMobileOrderFallout.SetFollow_by((string)_oDATA[MobileOrderFallout.Para.follow_by]); } else { _oMobileOrderFallout.SetFollow_by(global::System.String.Empty); }
                    }
                    _oMobileOrderFalloutList.Add(_oMobileOrderFallout);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderFalloutList;
            }
            return new List<MobileOrderFalloutEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderFalloutEntity> OrderBy(string x_sSort, IQueryable<MobileOrderFalloutEntity> x_oMobileOrderFalloutBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderFallout.Para.active:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderFallout.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderFallout.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderFallout.Para.did:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderFallout.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileOrderFallout.Para.fo_reason:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.fo_reason).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.fo_reason).Select(c => c);
                break;
                case MobileOrderFallout.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderFallout.Para.follow_by:
                if(x_bAsc)
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderBy(c => c.follow_by).Select(c => c);
                else
                    x_oMobileOrderFalloutBaseList = x_oMobileOrderFalloutBaseList.OrderByDescending(c => c.follow_by).Select(c => c);
                break;
            }
            return x_oMobileOrderFalloutBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderFalloutEntity> FindAll()
        {
            MobileOrderFalloutEntity[] _oMobileOrderFalloutsArr=  MobileOrderFalloutRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderFalloutsArr != null)
            {
                IList<MobileOrderFalloutEntity> _oMobileOrderFalloutsList = (IList<MobileOrderFalloutEntity>)_oMobileOrderFalloutsArr;
                return _oMobileOrderFalloutsList;
            }
            return new List<MobileOrderFalloutEntity>();
        }
        
        public static IList<MobileOrderFalloutEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderFalloutEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderFalloutEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderFalloutEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderFalloutRS x_oShowField = new MobileOrderFalloutRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderFalloutRS x_oSortField=new MobileOrderFalloutRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderFallout.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderFallout.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderFalloutRepositoryBase _oMobileOrderFalloutRepositoryBase = new MobileOrderFalloutRepositoryBase(GetDB());
            return _oMobileOrderFalloutRepositoryBase.GetCount();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr("MobileRetentionOrderDB");
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


