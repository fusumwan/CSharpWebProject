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
///-- Create date: <Create Date 2011-10-04>
///-- Description:	<Description,Table :[RetentionPlanUsage],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class RetentionPlanUsageDalDAO{
        
        #region RS
        public class RetentionPlanUsageRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bRate_plan = false;
            public bool n_bActive = false;
            public bool n_bRate_plan_vas_value = false;
            public bool n_bRate_plan_vas = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (RetentionPlanUsage.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlanUsage.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (RetentionPlanUsage.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlanUsage.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (RetentionPlanUsage.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlanUsage.Para.cid);
                }
                if (this.n_bRate_plan  || x_bSetShowALL || (RetentionPlanUsage.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlanUsage.Para.rate_plan);
                }
                if (this.n_bActive  || x_bSetShowALL || (RetentionPlanUsage.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlanUsage.Para.active);
                }
                if (this.n_bRate_plan_vas_value  || x_bSetShowALL || (RetentionPlanUsage.Para.rate_plan_vas_value.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan_vas_value=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlanUsage.Para.rate_plan_vas_value);
                }
                if (this.n_bRate_plan_vas  || x_bSetShowALL || (RetentionPlanUsage.Para.rate_plan_vas.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan_vas=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(RetentionPlanUsage.Para.rate_plan_vas);
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
        
        public RetentionPlanUsageDalDAO(){
        }
        ~RetentionPlanUsageDalDAO(){
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
            _oSearchUtils.SetTable(RetentionPlanUsage.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<RetentionPlanUsageEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, RetentionPlanUsageRS x_oFieldsToReturn,RetentionPlanUsageRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<RetentionPlanUsageEntity> _oRetentionPlanUsageList = new List<RetentionPlanUsageEntity>();
                
                while (_oDATA.Read())
                {
                    RetentionPlanUsage _oRetentionPlanUsage = new RetentionPlanUsage();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlanUsage.Para.id])) { _oRetentionPlanUsage.SetId((global::System.Nullable<int>)_oDATA[RetentionPlanUsage.Para.id]); } else { _oRetentionPlanUsage.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlanUsage.Para.cdate])) { _oRetentionPlanUsage.SetCdate((global::System.Nullable<DateTime>)_oDATA[RetentionPlanUsage.Para.cdate]); } else { _oRetentionPlanUsage.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlanUsage.Para.cid])) { _oRetentionPlanUsage.SetCid((string)_oDATA[RetentionPlanUsage.Para.cid]); } else { _oRetentionPlanUsage.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlanUsage.Para.rate_plan])) { _oRetentionPlanUsage.SetRate_plan((string)_oDATA[RetentionPlanUsage.Para.rate_plan]); } else { _oRetentionPlanUsage.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlanUsage.Para.active])) { _oRetentionPlanUsage.SetActive((global::System.Nullable<bool>)_oDATA[RetentionPlanUsage.Para.active]); } else { _oRetentionPlanUsage.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan_vas_value))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlanUsage.Para.rate_plan_vas_value])) { _oRetentionPlanUsage.SetRate_plan_vas_value((string)_oDATA[RetentionPlanUsage.Para.rate_plan_vas_value]); } else { _oRetentionPlanUsage.SetRate_plan_vas_value(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan_vas))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[RetentionPlanUsage.Para.rate_plan_vas])) { _oRetentionPlanUsage.SetRate_plan_vas((string)_oDATA[RetentionPlanUsage.Para.rate_plan_vas]); } else { _oRetentionPlanUsage.SetRate_plan_vas(global::System.String.Empty); }
                    }
                    _oRetentionPlanUsageList.Add(_oRetentionPlanUsage);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oRetentionPlanUsageList;
            }
            return new List<RetentionPlanUsageEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<RetentionPlanUsageEntity> OrderBy(string x_sSort, IQueryable<RetentionPlanUsageEntity> x_oRetentionPlanUsageBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case RetentionPlanUsage.Para.id:
                if(x_bAsc)
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case RetentionPlanUsage.Para.cdate:
                if(x_bAsc)
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case RetentionPlanUsage.Para.cid:
                if(x_bAsc)
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case RetentionPlanUsage.Para.rate_plan:
                if(x_bAsc)
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case RetentionPlanUsage.Para.active:
                if(x_bAsc)
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case RetentionPlanUsage.Para.rate_plan_vas_value:
                if(x_bAsc)
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderBy(c => c.rate_plan_vas_value).Select(c => c);
                else
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderByDescending(c => c.rate_plan_vas_value).Select(c => c);
                break;
                case RetentionPlanUsage.Para.rate_plan_vas:
                if(x_bAsc)
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderBy(c => c.rate_plan_vas).Select(c => c);
                else
                    x_oRetentionPlanUsageBaseList = x_oRetentionPlanUsageBaseList.OrderByDescending(c => c.rate_plan_vas).Select(c => c);
                break;
            }
            return x_oRetentionPlanUsageBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<RetentionPlanUsageEntity> FindAll()
        {
            RetentionPlanUsageEntity[] _oRetentionPlanUsagesArr=  RetentionPlanUsageRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oRetentionPlanUsagesArr != null)
            {
                IList<RetentionPlanUsageEntity> _oRetentionPlanUsagesList = (IList<RetentionPlanUsageEntity>)_oRetentionPlanUsagesArr;
                return _oRetentionPlanUsagesList;
            }
            return new List<RetentionPlanUsageEntity>();
        }
        
        public static IList<RetentionPlanUsageEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<RetentionPlanUsageEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<RetentionPlanUsageEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<RetentionPlanUsageEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            RetentionPlanUsageRS x_oShowField = new RetentionPlanUsageRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            RetentionPlanUsageRS x_oSortField=new RetentionPlanUsageRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(RetentionPlanUsage.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(RetentionPlanUsage.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            RetentionPlanUsageRepositoryBase _oRetentionPlanUsageRepositoryBase = new RetentionPlanUsageRepositoryBase(GetDB());
            return _oRetentionPlanUsageRepositoryBase.GetCount();
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


