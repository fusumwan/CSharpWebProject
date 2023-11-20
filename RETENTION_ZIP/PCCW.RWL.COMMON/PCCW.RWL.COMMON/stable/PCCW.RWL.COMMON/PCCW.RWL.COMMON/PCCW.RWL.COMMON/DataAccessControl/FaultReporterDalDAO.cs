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
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Table :[FaultReporter],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class FaultReporterDalDAO{
        
        #region RS
        public class FaultReporterRS
        {
            public bool n_bId = false;
            public bool n_bName = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bEmail = false;
            public bool n_bActive = false;
            public bool n_bEdate = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (FaultReporter.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(FaultReporter.Para.id);
                }
                if (this.n_bName  || x_bSetShowALL || (FaultReporter.Para.name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bName=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(FaultReporter.Para.name);
                }
                if (this.n_bCdate  || x_bSetShowALL || (FaultReporter.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(FaultReporter.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (FaultReporter.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(FaultReporter.Para.cid);
                }
                if (this.n_bEmail  || x_bSetShowALL || (FaultReporter.Para.email.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEmail=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(FaultReporter.Para.email);
                }
                if (this.n_bActive  || x_bSetShowALL || (FaultReporter.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(FaultReporter.Para.active);
                }
                if (this.n_bEdate  || x_bSetShowALL || (FaultReporter.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(FaultReporter.Para.edate);
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
        
        public FaultReporterDalDAO(){
        }
        ~FaultReporterDalDAO(){
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
            _oSearchUtils.SetTable(FaultReporter.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<FaultReporterEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, FaultReporterRS x_oFieldsToReturn,FaultReporterRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<FaultReporterEntity> _oFaultReporterList = new List<FaultReporterEntity>();
                
                while (_oDATA.Read())
                {
                    FaultReporter _oFaultReporter = new FaultReporter();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[FaultReporter.Para.id])) { _oFaultReporter.SetId((global::System.Nullable<int>)_oDATA[FaultReporter.Para.id]); } else { _oFaultReporter.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bName))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[FaultReporter.Para.name])) { _oFaultReporter.SetName((string)_oDATA[FaultReporter.Para.name]); } else { _oFaultReporter.SetName(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[FaultReporter.Para.cdate])) { _oFaultReporter.SetCdate((global::System.Nullable<DateTime>)_oDATA[FaultReporter.Para.cdate]); } else { _oFaultReporter.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[FaultReporter.Para.cid])) { _oFaultReporter.SetCid((string)_oDATA[FaultReporter.Para.cid]); } else { _oFaultReporter.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEmail))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[FaultReporter.Para.email])) { _oFaultReporter.SetEmail((string)_oDATA[FaultReporter.Para.email]); } else { _oFaultReporter.SetEmail(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[FaultReporter.Para.active])) { _oFaultReporter.SetActive((global::System.Nullable<bool>)_oDATA[FaultReporter.Para.active]); } else { _oFaultReporter.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[FaultReporter.Para.edate])) { _oFaultReporter.SetEdate((global::System.Nullable<DateTime>)_oDATA[FaultReporter.Para.edate]); } else { _oFaultReporter.SetEdate(null); }
                    }
                    _oFaultReporterList.Add(_oFaultReporter);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oFaultReporterList;
            }
            return new List<FaultReporterEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<FaultReporterEntity> OrderBy(string x_sSort, IQueryable<FaultReporterEntity> x_oFaultReporterBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case FaultReporter.Para.id:
                if(x_bAsc)
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case FaultReporter.Para.name:
                if(x_bAsc)
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderBy(c => c.name).Select(c => c);
                else
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderByDescending(c => c.name).Select(c => c);
                break;
                case FaultReporter.Para.cdate:
                if(x_bAsc)
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case FaultReporter.Para.cid:
                if(x_bAsc)
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case FaultReporter.Para.email:
                if(x_bAsc)
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderBy(c => c.email).Select(c => c);
                else
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderByDescending(c => c.email).Select(c => c);
                break;
                case FaultReporter.Para.active:
                if(x_bAsc)
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case FaultReporter.Para.edate:
                if(x_bAsc)
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oFaultReporterBaseList = x_oFaultReporterBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
            }
            return x_oFaultReporterBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<FaultReporterEntity> FindAll()
        {
            FaultReporterEntity[] _oFaultReportersArr=  FaultReporterRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oFaultReportersArr != null)
            {
                IList<FaultReporterEntity> _oFaultReportersList = (IList<FaultReporterEntity>)_oFaultReportersArr;
                return _oFaultReportersList;
            }
            return new List<FaultReporterEntity>();
        }
        
        public static IList<FaultReporterEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<FaultReporterEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<FaultReporterEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<FaultReporterEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            FaultReporterRS x_oShowField = new FaultReporterRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            FaultReporterRS x_oSortField=new FaultReporterRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(FaultReporter.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(FaultReporter.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            FaultReporterRepositoryBase _oFaultReporterRepositoryBase = new FaultReporterRepositoryBase(GetDB());
            return _oFaultReporterRepositoryBase.GetCount();
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


