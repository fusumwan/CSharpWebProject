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
///-- Create date: <Create Date 2010-08-20>
///-- Description:	<Description,Table :[MobileOrderMigrateRule],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderMigrateRuleDalDAO{
        
        #region RS
        public class MobileOrderMigrateRuleRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bStatus = false;
            public bool n_bType = false;
            public bool n_bChk = false;
            public bool n_bActive = false;
            public bool n_bName = false;
            public bool n_bSku = false;
            public bool n_bDdate = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (MobileOrderMigrateRule.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderMigrateRule.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderMigrateRule.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderMigrateRule.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.did);
                }
                if (this.n_bStatus  || x_bSetShowALL || (MobileOrderMigrateRule.Para.status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStatus=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.status);
                }
                if (this.n_bType  || x_bSetShowALL || (MobileOrderMigrateRule.Para.type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bType=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.type);
                }
                if (this.n_bChk  || x_bSetShowALL || (MobileOrderMigrateRule.Para.chk.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bChk=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.chk);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderMigrateRule.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.active);
                }
                if (this.n_bName  || x_bSetShowALL || (MobileOrderMigrateRule.Para.name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bName=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.name);
                }
                if (this.n_bSku  || x_bSetShowALL || (MobileOrderMigrateRule.Para.sku.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSku=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.sku);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderMigrateRule.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMigrateRule.Para.ddate);
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
        
        public MobileOrderMigrateRuleDalDAO(){
        }
        ~MobileOrderMigrateRuleDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderMigrateRule.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderMigrateRuleEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderMigrateRuleRS x_oFieldsToReturn,MobileOrderMigrateRuleRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRuleList = new List<MobileOrderMigrateRuleEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderMigrateRule _oMobileOrderMigrateRule = new MobileOrderMigrateRule();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.id])) { _oMobileOrderMigrateRule.SetId((global::System.Nullable<int>)_oDATA[MobileOrderMigrateRule.Para.id]); } else { _oMobileOrderMigrateRule.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.cdate])) { _oMobileOrderMigrateRule.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderMigrateRule.Para.cdate]); } else { _oMobileOrderMigrateRule.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.cid])) { _oMobileOrderMigrateRule.SetCid((string)_oDATA[MobileOrderMigrateRule.Para.cid]); } else { _oMobileOrderMigrateRule.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.did])) { _oMobileOrderMigrateRule.SetDid((string)_oDATA[MobileOrderMigrateRule.Para.did]); } else { _oMobileOrderMigrateRule.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStatus))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.status])) { _oMobileOrderMigrateRule.SetStatus((string)_oDATA[MobileOrderMigrateRule.Para.status]); } else { _oMobileOrderMigrateRule.SetStatus(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bType))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.type])) { _oMobileOrderMigrateRule.SetType((string)_oDATA[MobileOrderMigrateRule.Para.type]); } else { _oMobileOrderMigrateRule.SetType(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bChk))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.chk])) { _oMobileOrderMigrateRule.SetChk((global::System.Nullable<bool>)_oDATA[MobileOrderMigrateRule.Para.chk]); } else { _oMobileOrderMigrateRule.SetChk(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.active])) { _oMobileOrderMigrateRule.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderMigrateRule.Para.active]); } else { _oMobileOrderMigrateRule.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bName))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.name])) { _oMobileOrderMigrateRule.SetName((string)_oDATA[MobileOrderMigrateRule.Para.name]); } else { _oMobileOrderMigrateRule.SetName(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSku))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.sku])) { _oMobileOrderMigrateRule.SetSku((string)_oDATA[MobileOrderMigrateRule.Para.sku]); } else { _oMobileOrderMigrateRule.SetSku(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMigrateRule.Para.ddate])) { _oMobileOrderMigrateRule.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderMigrateRule.Para.ddate]); } else { _oMobileOrderMigrateRule.SetDdate(null); }
                    }
                    _oMobileOrderMigrateRuleList.Add(_oMobileOrderMigrateRule);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderMigrateRuleList;
            }
            return new List<MobileOrderMigrateRuleEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderMigrateRuleEntity> OrderBy(string x_sSort, IQueryable<MobileOrderMigrateRuleEntity> x_oMobileOrderMigrateRuleBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderMigrateRule.Para.id:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.did:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.status:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.status).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.status).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.type:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.type).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.type).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.chk:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.chk).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.chk).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.active:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.name:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.name).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.name).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.sku:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.sku).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.sku).Select(c => c);
                break;
                case MobileOrderMigrateRule.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderMigrateRuleBaseList = x_oMobileOrderMigrateRuleBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
            }
            return x_oMobileOrderMigrateRuleBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderMigrateRuleEntity> FindAll()
        {
            MobileOrderMigrateRuleEntity[] _oMobileOrderMigrateRulesArr=  MobileOrderMigrateRuleRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderMigrateRulesArr != null)
            {
                IList<MobileOrderMigrateRuleEntity> _oMobileOrderMigrateRulesList = (IList<MobileOrderMigrateRuleEntity>)_oMobileOrderMigrateRulesArr;
                return _oMobileOrderMigrateRulesList;
            }
            return new List<MobileOrderMigrateRuleEntity>();
        }
        
        public static IList<MobileOrderMigrateRuleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderMigrateRuleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderMigrateRuleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderMigrateRuleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderMigrateRuleRS x_oShowField = new MobileOrderMigrateRuleRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderMigrateRuleRS x_oSortField=new MobileOrderMigrateRuleRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderMigrateRule.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderMigrateRule.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderMigrateRuleRepositoryBase _oMobileOrderMigrateRuleRepositoryBase = new MobileOrderMigrateRuleRepositoryBase(GetDB());
            return _oMobileOrderMigrateRuleRepositoryBase.GetCount();
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


