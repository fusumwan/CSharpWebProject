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
///-- Create date: <Create Date 2011-09-22>
///-- Description:	<Description,Table :[ProgramRebateMapping],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class ProgramRebateMappingDalDAO{
        
        #region RS
        public class ProgramRebateMappingRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bActive = false;
            public bool n_bEdate = false;
            public bool n_bProgram = false;
            public bool n_bIssue_type = false;
            public bool n_bUse_rebate_mapping = false;
            public bool n_bSdate = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (ProgramRebateMapping.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (ProgramRebateMapping.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.cdate);
                }
                if (this.n_bActive  || x_bSetShowALL || (ProgramRebateMapping.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.active);
                }
                if (this.n_bEdate  || x_bSetShowALL || (ProgramRebateMapping.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.edate);
                }
                if (this.n_bProgram  || x_bSetShowALL || (ProgramRebateMapping.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.program);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (ProgramRebateMapping.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.issue_type);
                }
                if (this.n_bUse_rebate_mapping  || x_bSetShowALL || (ProgramRebateMapping.Para.use_rebate_mapping.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUse_rebate_mapping=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.use_rebate_mapping);
                }
                if (this.n_bSdate  || x_bSetShowALL || (ProgramRebateMapping.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProgramRebateMapping.Para.sdate);
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
        
        public ProgramRebateMappingDalDAO(){
        }
        ~ProgramRebateMappingDalDAO(){
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
            _oSearchUtils.SetTable(ProgramRebateMapping.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<ProgramRebateMappingEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, ProgramRebateMappingRS x_oFieldsToReturn,ProgramRebateMappingRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<ProgramRebateMappingEntity> _oProgramRebateMappingList = new List<ProgramRebateMappingEntity>();
                
                while (_oDATA.Read())
                {
                    ProgramRebateMapping _oProgramRebateMapping = new ProgramRebateMapping();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.id])) { _oProgramRebateMapping.SetId((global::System.Nullable<int>)_oDATA[ProgramRebateMapping.Para.id]); } else { _oProgramRebateMapping.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.cdate])) { _oProgramRebateMapping.SetCdate((global::System.Nullable<DateTime>)_oDATA[ProgramRebateMapping.Para.cdate]); } else { _oProgramRebateMapping.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.active])) { _oProgramRebateMapping.SetActive((global::System.Nullable<bool>)_oDATA[ProgramRebateMapping.Para.active]); } else { _oProgramRebateMapping.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.edate])) { _oProgramRebateMapping.SetEdate((global::System.Nullable<DateTime>)_oDATA[ProgramRebateMapping.Para.edate]); } else { _oProgramRebateMapping.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.program])) { _oProgramRebateMapping.SetProgram((string)_oDATA[ProgramRebateMapping.Para.program]); } else { _oProgramRebateMapping.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.issue_type])) { _oProgramRebateMapping.SetIssue_type((string)_oDATA[ProgramRebateMapping.Para.issue_type]); } else { _oProgramRebateMapping.SetIssue_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUse_rebate_mapping))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.use_rebate_mapping])) { _oProgramRebateMapping.SetUse_rebate_mapping((global::System.Nullable<bool>)_oDATA[ProgramRebateMapping.Para.use_rebate_mapping]); } else { _oProgramRebateMapping.SetUse_rebate_mapping(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProgramRebateMapping.Para.sdate])) { _oProgramRebateMapping.SetSdate((global::System.Nullable<DateTime>)_oDATA[ProgramRebateMapping.Para.sdate]); } else { _oProgramRebateMapping.SetSdate(null); }
                    }
                    _oProgramRebateMappingList.Add(_oProgramRebateMapping);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oProgramRebateMappingList;
            }
            return new List<ProgramRebateMappingEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<ProgramRebateMappingEntity> OrderBy(string x_sSort, IQueryable<ProgramRebateMappingEntity> x_oProgramRebateMappingBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case ProgramRebateMapping.Para.id:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case ProgramRebateMapping.Para.cdate:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case ProgramRebateMapping.Para.active:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case ProgramRebateMapping.Para.edate:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case ProgramRebateMapping.Para.program:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case ProgramRebateMapping.Para.issue_type:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
                case ProgramRebateMapping.Para.use_rebate_mapping:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.use_rebate_mapping).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.use_rebate_mapping).Select(c => c);
                break;
                case ProgramRebateMapping.Para.sdate:
                if(x_bAsc)
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oProgramRebateMappingBaseList = x_oProgramRebateMappingBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
            }
            return x_oProgramRebateMappingBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<ProgramRebateMappingEntity> FindAll()
        {
            ProgramRebateMappingEntity[] _oProgramRebateMappingsArr=  ProgramRebateMappingRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oProgramRebateMappingsArr != null)
            {
                IList<ProgramRebateMappingEntity> _oProgramRebateMappingsList = (IList<ProgramRebateMappingEntity>)_oProgramRebateMappingsArr;
                return _oProgramRebateMappingsList;
            }
            return new List<ProgramRebateMappingEntity>();
        }
        
        public static IList<ProgramRebateMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<ProgramRebateMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<ProgramRebateMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<ProgramRebateMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            ProgramRebateMappingRS x_oShowField = new ProgramRebateMappingRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            ProgramRebateMappingRS x_oSortField=new ProgramRebateMappingRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(ProgramRebateMapping.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(ProgramRebateMapping.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            ProgramRebateMappingRepositoryBase _oProgramRebateMappingRepositoryBase = new ProgramRebateMappingRepositoryBase(GetDB());
            return _oProgramRebateMappingRepositoryBase.GetCount();
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


