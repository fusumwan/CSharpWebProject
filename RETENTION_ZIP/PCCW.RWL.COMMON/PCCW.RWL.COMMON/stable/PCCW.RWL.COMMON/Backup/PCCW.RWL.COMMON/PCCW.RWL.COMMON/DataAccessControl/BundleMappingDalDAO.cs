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
///-- Create date: <Create Date 2011-07-14>
///-- Description:	<Description,Table :[BundleMapping],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class BundleMappingDalDAO{
        
        #region RS
        public class BundleMappingRS
        {
            public bool n_bProgram = false;
            public bool n_bCdate = false;
            public bool n_bBundle_name = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bRetention_rebate = false;
            public bool n_bEdate = false;
            public bool n_bActive = false;
            public bool n_bNormal_rebate = false;
            public bool n_bDdate = false;
            public bool n_bNormal_rebate_type = false;
            public bool n_bId = false;
            public bool n_bSdate = false;
            public bool n_bRate_plan = false;
            public bool n_bVas_field = false;
            public bool n_bHs_model = false;
            public bool n_bIssue_type = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bProgram  || x_bSetShowALL || (BundleMapping.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.program);
                }
                if (this.n_bCdate  || x_bSetShowALL || (BundleMapping.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.cdate);
                }
                if (this.n_bBundle_name  || x_bSetShowALL || (BundleMapping.Para.bundle_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBundle_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.bundle_name);
                }
                if (this.n_bCid  || x_bSetShowALL || (BundleMapping.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (BundleMapping.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.did);
                }
                if (this.n_bRetention_rebate  || x_bSetShowALL || (BundleMapping.Para.retention_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetention_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.retention_rebate);
                }
                if (this.n_bEdate  || x_bSetShowALL || (BundleMapping.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.edate);
                }
                if (this.n_bActive  || x_bSetShowALL || (BundleMapping.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.active);
                }
                if (this.n_bNormal_rebate  || x_bSetShowALL || (BundleMapping.Para.normal_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.normal_rebate);
                }
                if (this.n_bDdate  || x_bSetShowALL || (BundleMapping.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.ddate);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (BundleMapping.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.normal_rebate_type);
                }
                if (this.n_bId  || x_bSetShowALL || (BundleMapping.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.id);
                }
                if (this.n_bSdate  || x_bSetShowALL || (BundleMapping.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.sdate);
                }
                if (this.n_bRate_plan  || x_bSetShowALL || (BundleMapping.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.rate_plan);
                }
                if (this.n_bVas_field  || x_bSetShowALL || (BundleMapping.Para.vas_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.vas_field);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (BundleMapping.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.hs_model);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (BundleMapping.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(BundleMapping.Para.issue_type);
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
        
        public BundleMappingDalDAO(){
        }
        ~BundleMappingDalDAO(){
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
            _oSearchUtils.SetTable(BundleMapping.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<BundleMappingEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, BundleMappingRS x_oFieldsToReturn,BundleMappingRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<BundleMappingEntity> _oBundleMappingList = new List<BundleMappingEntity>();
                
                while (_oDATA.Read())
                {
                    BundleMapping _oBundleMapping = new BundleMapping();
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.program])) { _oBundleMapping.SetProgram((string)_oDATA[BundleMapping.Para.program]); } else { _oBundleMapping.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.cdate])) { _oBundleMapping.SetCdate((global::System.Nullable<DateTime>)_oDATA[BundleMapping.Para.cdate]); } else { _oBundleMapping.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBundle_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.bundle_name])) { _oBundleMapping.SetBundle_name((string)_oDATA[BundleMapping.Para.bundle_name]); } else { _oBundleMapping.SetBundle_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.cid])) { _oBundleMapping.SetCid((string)_oDATA[BundleMapping.Para.cid]); } else { _oBundleMapping.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.did])) { _oBundleMapping.SetDid((string)_oDATA[BundleMapping.Para.did]); } else { _oBundleMapping.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetention_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.retention_rebate])) { _oBundleMapping.SetRetention_rebate((global::System.Nullable<int>)_oDATA[BundleMapping.Para.retention_rebate]); } else { _oBundleMapping.SetRetention_rebate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.edate])) { _oBundleMapping.SetEdate((global::System.Nullable<DateTime>)_oDATA[BundleMapping.Para.edate]); } else { _oBundleMapping.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.active])) { _oBundleMapping.SetActive((global::System.Nullable<bool>)_oDATA[BundleMapping.Para.active]); } else { _oBundleMapping.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.normal_rebate])) { _oBundleMapping.SetNormal_rebate((global::System.Nullable<int>)_oDATA[BundleMapping.Para.normal_rebate]); } else { _oBundleMapping.SetNormal_rebate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.ddate])) { _oBundleMapping.SetDdate((global::System.Nullable<DateTime>)_oDATA[BundleMapping.Para.ddate]); } else { _oBundleMapping.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.normal_rebate_type])) { _oBundleMapping.SetNormal_rebate_type((string)_oDATA[BundleMapping.Para.normal_rebate_type]); } else { _oBundleMapping.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.id])) { _oBundleMapping.SetId((global::System.Nullable<int>)_oDATA[BundleMapping.Para.id]); } else { _oBundleMapping.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.sdate])) { _oBundleMapping.SetSdate((global::System.Nullable<DateTime>)_oDATA[BundleMapping.Para.sdate]); } else { _oBundleMapping.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.rate_plan])) { _oBundleMapping.SetRate_plan((string)_oDATA[BundleMapping.Para.rate_plan]); } else { _oBundleMapping.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.vas_field])) { _oBundleMapping.SetVas_field((string)_oDATA[BundleMapping.Para.vas_field]); } else { _oBundleMapping.SetVas_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.hs_model])) { _oBundleMapping.SetHs_model((string)_oDATA[BundleMapping.Para.hs_model]); } else { _oBundleMapping.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[BundleMapping.Para.issue_type])) { _oBundleMapping.SetIssue_type((string)_oDATA[BundleMapping.Para.issue_type]); } else { _oBundleMapping.SetIssue_type(global::System.String.Empty); }
                    }
                    _oBundleMappingList.Add(_oBundleMapping);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oBundleMappingList;
            }
            return new List<BundleMappingEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<BundleMappingEntity> OrderBy(string x_sSort, IQueryable<BundleMappingEntity> x_oBundleMappingBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case BundleMapping.Para.program:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case BundleMapping.Para.cdate:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case BundleMapping.Para.bundle_name:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.bundle_name).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.bundle_name).Select(c => c);
                break;
                case BundleMapping.Para.cid:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case BundleMapping.Para.did:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case BundleMapping.Para.retention_rebate:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.retention_rebate).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.retention_rebate).Select(c => c);
                break;
                case BundleMapping.Para.edate:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case BundleMapping.Para.active:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case BundleMapping.Para.normal_rebate:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.normal_rebate).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.normal_rebate).Select(c => c);
                break;
                case BundleMapping.Para.ddate:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case BundleMapping.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case BundleMapping.Para.id:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case BundleMapping.Para.sdate:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
                case BundleMapping.Para.rate_plan:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case BundleMapping.Para.vas_field:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.vas_field).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.vas_field).Select(c => c);
                break;
                case BundleMapping.Para.hs_model:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case BundleMapping.Para.issue_type:
                if(x_bAsc)
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oBundleMappingBaseList = x_oBundleMappingBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
            }
            return x_oBundleMappingBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<BundleMappingEntity> FindAll()
        {
            BundleMappingEntity[] _oBundleMappingsArr=  BundleMappingRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oBundleMappingsArr != null)
            {
                IList<BundleMappingEntity> _oBundleMappingsList = (IList<BundleMappingEntity>)_oBundleMappingsArr;
                return _oBundleMappingsList;
            }
            return new List<BundleMappingEntity>();
        }
        
        public static IList<BundleMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<BundleMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<BundleMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<BundleMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            BundleMappingRS x_oShowField = new BundleMappingRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            BundleMappingRS x_oSortField=new BundleMappingRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(BundleMapping.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(BundleMapping.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            BundleMappingRepositoryBase _oBundleMappingRepositoryBase = new BundleMappingRepositoryBase(GetDB());
            return _oBundleMappingRepositoryBase.GetCount();
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


