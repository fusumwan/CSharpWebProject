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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[HandSetOfferType],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class HandSetOfferTypeDalDAO{
        
        #region RS
        public class HandSetOfferTypeRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bExpiry_chk = false;
            public bool n_bActive = false;
            public bool n_bName = false;
            public bool n_bEdate = false;
            public bool n_bDdate = false;
            public bool n_bSdate = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (HandSetOfferType.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (HandSetOfferType.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (HandSetOfferType.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (HandSetOfferType.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.did);
                }
                if (this.n_bExpiry_chk  || x_bSetShowALL || (HandSetOfferType.Para.expiry_chk.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExpiry_chk=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.expiry_chk);
                }
                if (this.n_bActive  || x_bSetShowALL || (HandSetOfferType.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.active);
                }
                if (this.n_bName  || x_bSetShowALL || (HandSetOfferType.Para.name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bName=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.name);
                }
                if (this.n_bEdate  || x_bSetShowALL || (HandSetOfferType.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.edate);
                }
                if (this.n_bDdate  || x_bSetShowALL || (HandSetOfferType.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.ddate);
                }
                if (this.n_bSdate  || x_bSetShowALL || (HandSetOfferType.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferType.Para.sdate);
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
        
        public HandSetOfferTypeDalDAO(){
        }
        ~HandSetOfferTypeDalDAO(){
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
            _oSearchUtils.SetTable(HandSetOfferType.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<HandSetOfferTypeEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, HandSetOfferTypeRS x_oFieldsToReturn,HandSetOfferTypeRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<HandSetOfferTypeEntity> _oHandSetOfferTypeList = new List<HandSetOfferTypeEntity>();
                
                while (_oDATA.Read())
                {
                    HandSetOfferType _oHandSetOfferType = new HandSetOfferType();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.id])) { _oHandSetOfferType.SetId((global::System.Nullable<int>)_oDATA[HandSetOfferType.Para.id]); } else { _oHandSetOfferType.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.cdate])) { _oHandSetOfferType.SetCdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferType.Para.cdate]); } else { _oHandSetOfferType.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.cid])) { _oHandSetOfferType.SetCid((string)_oDATA[HandSetOfferType.Para.cid]); } else { _oHandSetOfferType.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.did])) { _oHandSetOfferType.SetDid((string)_oDATA[HandSetOfferType.Para.did]); } else { _oHandSetOfferType.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExpiry_chk))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.expiry_chk])) { _oHandSetOfferType.SetExpiry_chk((global::System.Nullable<bool>)_oDATA[HandSetOfferType.Para.expiry_chk]); } else { _oHandSetOfferType.SetExpiry_chk(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.active])) { _oHandSetOfferType.SetActive((global::System.Nullable<bool>)_oDATA[HandSetOfferType.Para.active]); } else { _oHandSetOfferType.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bName))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.name])) { _oHandSetOfferType.SetName((string)_oDATA[HandSetOfferType.Para.name]); } else { _oHandSetOfferType.SetName(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.edate])) { _oHandSetOfferType.SetEdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferType.Para.edate]); } else { _oHandSetOfferType.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.ddate])) { _oHandSetOfferType.SetDdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferType.Para.ddate]); } else { _oHandSetOfferType.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferType.Para.sdate])) { _oHandSetOfferType.SetSdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferType.Para.sdate]); } else { _oHandSetOfferType.SetSdate(null); }
                    }
                    _oHandSetOfferTypeList.Add(_oHandSetOfferType);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oHandSetOfferTypeList;
            }
            return new List<HandSetOfferTypeEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<HandSetOfferTypeEntity> OrderBy(string x_sSort, IQueryable<HandSetOfferTypeEntity> x_oHandSetOfferTypeBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case HandSetOfferType.Para.id:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case HandSetOfferType.Para.cdate:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case HandSetOfferType.Para.cid:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case HandSetOfferType.Para.did:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case HandSetOfferType.Para.expiry_chk:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.expiry_chk).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.expiry_chk).Select(c => c);
                break;
                case HandSetOfferType.Para.active:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case HandSetOfferType.Para.name:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.name).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.name).Select(c => c);
                break;
                case HandSetOfferType.Para.edate:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case HandSetOfferType.Para.ddate:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case HandSetOfferType.Para.sdate:
                if(x_bAsc)
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oHandSetOfferTypeBaseList = x_oHandSetOfferTypeBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
            }
            return x_oHandSetOfferTypeBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<HandSetOfferTypeEntity> FindAll()
        {
            HandSetOfferTypeEntity[] _oHandSetOfferTypesArr=  HandSetOfferTypeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oHandSetOfferTypesArr != null)
            {
                IList<HandSetOfferTypeEntity> _oHandSetOfferTypesList = (IList<HandSetOfferTypeEntity>)_oHandSetOfferTypesArr;
                return _oHandSetOfferTypesList;
            }
            return new List<HandSetOfferTypeEntity>();
        }
        
        public static IList<HandSetOfferTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<HandSetOfferTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<HandSetOfferTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<HandSetOfferTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            HandSetOfferTypeRS x_oShowField = new HandSetOfferTypeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            HandSetOfferTypeRS x_oSortField=new HandSetOfferTypeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(HandSetOfferType.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(HandSetOfferType.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            HandSetOfferTypeRepositoryBase _oHandSetOfferTypeRepositoryBase = new HandSetOfferTypeRepositoryBase(GetDB());
            return _oHandSetOfferTypeRepositoryBase.GetCount();
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
        public void Release(){}
        #endregion
    }
}


