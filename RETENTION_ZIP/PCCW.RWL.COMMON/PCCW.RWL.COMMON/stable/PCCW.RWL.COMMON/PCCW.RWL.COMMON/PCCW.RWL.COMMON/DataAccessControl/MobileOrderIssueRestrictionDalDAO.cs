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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestriction],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderIssueRestrictionDalDAO{
        
        #region RS
        public class MobileOrderIssueRestrictionRS
        {
            public bool n_bName = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bType = false;
            public bool n_bActive = false;
            public bool n_bRestriction_id = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bName  || x_bSetShowALL || (MobileOrderIssueRestriction.Para.name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bName=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestriction.Para.name);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderIssueRestriction.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestriction.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderIssueRestriction.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestriction.Para.cid);
                }
                if (this.n_bType  || x_bSetShowALL || (MobileOrderIssueRestriction.Para.type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bType=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestriction.Para.type);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderIssueRestriction.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestriction.Para.active);
                }
                if (this.n_bRestriction_id  || x_bSetShowALL || (MobileOrderIssueRestriction.Para.restriction_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRestriction_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestriction.Para.restriction_id);
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
        
        public MobileOrderIssueRestrictionDalDAO(){
        }
        ~MobileOrderIssueRestrictionDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderIssueRestriction.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderIssueRestrictionEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderIssueRestrictionRS x_oFieldsToReturn,MobileOrderIssueRestrictionRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionList = new List<MobileOrderIssueRestrictionEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderIssueRestriction _oMobileOrderIssueRestriction = new MobileOrderIssueRestriction();
                    if ((true).Equals(x_oFieldsToReturn.n_bName))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestriction.Para.name])) { _oMobileOrderIssueRestriction.SetName((string)_oDATA[MobileOrderIssueRestriction.Para.name]); } else { _oMobileOrderIssueRestriction.SetName(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestriction.Para.cdate])) { _oMobileOrderIssueRestriction.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderIssueRestriction.Para.cdate]); } else { _oMobileOrderIssueRestriction.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestriction.Para.cid])) { _oMobileOrderIssueRestriction.SetCid((string)_oDATA[MobileOrderIssueRestriction.Para.cid]); } else { _oMobileOrderIssueRestriction.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bType))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestriction.Para.type])) { _oMobileOrderIssueRestriction.SetType((string)_oDATA[MobileOrderIssueRestriction.Para.type]); } else { _oMobileOrderIssueRestriction.SetType(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestriction.Para.active])) { _oMobileOrderIssueRestriction.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderIssueRestriction.Para.active]); } else { _oMobileOrderIssueRestriction.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRestriction_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestriction.Para.restriction_id])) { _oMobileOrderIssueRestriction.SetRestriction_id((global::System.Nullable<int>)_oDATA[MobileOrderIssueRestriction.Para.restriction_id]); } else { _oMobileOrderIssueRestriction.SetRestriction_id(null); }
                    }
                    _oMobileOrderIssueRestrictionList.Add(_oMobileOrderIssueRestriction);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderIssueRestrictionList;
            }
            return new List<MobileOrderIssueRestrictionEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderIssueRestrictionEntity> OrderBy(string x_sSort, IQueryable<MobileOrderIssueRestrictionEntity> x_oMobileOrderIssueRestrictionBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderIssueRestriction.Para.name:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderBy(c => c.name).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderByDescending(c => c.name).Select(c => c);
                break;
                case MobileOrderIssueRestriction.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderIssueRestriction.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderIssueRestriction.Para.type:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderBy(c => c.type).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderByDescending(c => c.type).Select(c => c);
                break;
                case MobileOrderIssueRestriction.Para.active:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderIssueRestriction.Para.restriction_id:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderBy(c => c.restriction_id).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionBaseList = x_oMobileOrderIssueRestrictionBaseList.OrderByDescending(c => c.restriction_id).Select(c => c);
                break;
            }
            return x_oMobileOrderIssueRestrictionBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderIssueRestrictionEntity> FindAll()
        {
            MobileOrderIssueRestrictionEntity[] _oMobileOrderIssueRestrictionsArr=  MobileOrderIssueRestrictionRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderIssueRestrictionsArr != null)
            {
                IList<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionsList = (IList<MobileOrderIssueRestrictionEntity>)_oMobileOrderIssueRestrictionsArr;
                return _oMobileOrderIssueRestrictionsList;
            }
            return new List<MobileOrderIssueRestrictionEntity>();
        }
        
        public static IList<MobileOrderIssueRestrictionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderIssueRestrictionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderIssueRestrictionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderIssueRestrictionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, x_sRowFilter, true);
        }

        public static IList<MobileOrderIssueRestrictionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter,bool x_bAscDirection)
        {
            MobileOrderIssueRestrictionRS x_oShowField = new MobileOrderIssueRestrictionRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderIssueRestrictionRS x_oSortField = new MobileOrderIssueRestrictionRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderIssueRestriction.Para.restriction_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(MobileOrderIssueRestriction.Para.restriction_id, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, x_bAscDirection);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderIssueRestrictionRepositoryBase _oMobileOrderIssueRestrictionRepositoryBase = new MobileOrderIssueRestrictionRepositoryBase(GetDB());
            return _oMobileOrderIssueRestrictionRepositoryBase.GetCount();
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


