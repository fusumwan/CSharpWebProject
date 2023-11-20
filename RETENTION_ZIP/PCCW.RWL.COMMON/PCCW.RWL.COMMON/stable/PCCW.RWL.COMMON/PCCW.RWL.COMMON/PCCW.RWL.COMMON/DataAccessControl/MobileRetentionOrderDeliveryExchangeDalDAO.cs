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
///-- Create date: <Create Date 2011-02-16>
///-- Description:	<Description,Table :[MobileRetentionOrderDeliveryExchange],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileRetentionOrderDeliveryExchangeDalDAO{
        
        #region RS
        public class MobileRetentionOrderDeliveryExchangeRS
        {
            public bool n_bRate_plan = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bCon_per = false;
            public bool n_bId = false;
            public bool n_bActive = false;
            public bool n_bHs_model = false;
            public bool n_bProgram = false;
            public bool n_bNormal_rebate_type = false;
            public bool n_bDdate = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bRate_plan  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.rate_plan.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRate_plan=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.rate_plan);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.did);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.con_per);
                }
                if (this.n_bId  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.id);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.active);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.hs_model);
                }
                if (this.n_bProgram  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.program);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileRetentionOrderDeliveryExchange.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderDeliveryExchange.Para.ddate);
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
        
        public MobileRetentionOrderDeliveryExchangeDalDAO(){
        }
        ~MobileRetentionOrderDeliveryExchangeDalDAO(){
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
            _oSearchUtils.SetTable(MobileRetentionOrderDeliveryExchange.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileRetentionOrderDeliveryExchangeEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileRetentionOrderDeliveryExchangeRS x_oFieldsToReturn,MobileRetentionOrderDeliveryExchangeRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileRetentionOrderDeliveryExchangeEntity> _oMobileRetentionOrderDeliveryExchangeList = new List<MobileRetentionOrderDeliveryExchangeEntity>();
                
                while (_oDATA.Read())
                {
                    MobileRetentionOrderDeliveryExchange _oMobileRetentionOrderDeliveryExchange = new MobileRetentionOrderDeliveryExchange();
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.rate_plan])) { _oMobileRetentionOrderDeliveryExchange.SetRate_plan((string)_oDATA[MobileRetentionOrderDeliveryExchange.Para.rate_plan]); } else { _oMobileRetentionOrderDeliveryExchange.SetRate_plan(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.cdate])) { _oMobileRetentionOrderDeliveryExchange.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionOrderDeliveryExchange.Para.cdate]); } else { _oMobileRetentionOrderDeliveryExchange.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.cid])) { _oMobileRetentionOrderDeliveryExchange.SetCid((string)_oDATA[MobileRetentionOrderDeliveryExchange.Para.cid]); } else { _oMobileRetentionOrderDeliveryExchange.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.did])) { _oMobileRetentionOrderDeliveryExchange.SetDid((string)_oDATA[MobileRetentionOrderDeliveryExchange.Para.did]); } else { _oMobileRetentionOrderDeliveryExchange.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.con_per])) { _oMobileRetentionOrderDeliveryExchange.SetCon_per((string)_oDATA[MobileRetentionOrderDeliveryExchange.Para.con_per]); } else { _oMobileRetentionOrderDeliveryExchange.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.id])) { _oMobileRetentionOrderDeliveryExchange.SetId((global::System.Nullable<int>)_oDATA[MobileRetentionOrderDeliveryExchange.Para.id]); } else { _oMobileRetentionOrderDeliveryExchange.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.active])) { _oMobileRetentionOrderDeliveryExchange.SetActive((global::System.Nullable<bool>)_oDATA[MobileRetentionOrderDeliveryExchange.Para.active]); } else { _oMobileRetentionOrderDeliveryExchange.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.hs_model])) { _oMobileRetentionOrderDeliveryExchange.SetHs_model((string)_oDATA[MobileRetentionOrderDeliveryExchange.Para.hs_model]); } else { _oMobileRetentionOrderDeliveryExchange.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.program])) { _oMobileRetentionOrderDeliveryExchange.SetProgram((string)_oDATA[MobileRetentionOrderDeliveryExchange.Para.program]); } else { _oMobileRetentionOrderDeliveryExchange.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type])) { _oMobileRetentionOrderDeliveryExchange.SetNormal_rebate_type((string)_oDATA[MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type]); } else { _oMobileRetentionOrderDeliveryExchange.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderDeliveryExchange.Para.ddate])) { _oMobileRetentionOrderDeliveryExchange.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionOrderDeliveryExchange.Para.ddate]); } else { _oMobileRetentionOrderDeliveryExchange.SetDdate(null); }
                    }
                    _oMobileRetentionOrderDeliveryExchangeList.Add(_oMobileRetentionOrderDeliveryExchange);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileRetentionOrderDeliveryExchangeList;
            }
            return new List<MobileRetentionOrderDeliveryExchangeEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileRetentionOrderDeliveryExchangeEntity> OrderBy(string x_sSort, IQueryable<MobileRetentionOrderDeliveryExchangeEntity> x_oMobileRetentionOrderDeliveryExchangeBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileRetentionOrderDeliveryExchange.Para.rate_plan:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.cdate:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.cid:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.did:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.con_per:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.id:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.active:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.hs_model:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.program:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case MobileRetentionOrderDeliveryExchange.Para.ddate:
                if(x_bAsc)
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileRetentionOrderDeliveryExchangeBaseList = x_oMobileRetentionOrderDeliveryExchangeBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
            }
            return x_oMobileRetentionOrderDeliveryExchangeBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileRetentionOrderDeliveryExchangeEntity> FindAll()
        {
            MobileRetentionOrderDeliveryExchangeEntity[] _oMobileRetentionOrderDeliveryExchangesArr=  MobileRetentionOrderDeliveryExchangeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileRetentionOrderDeliveryExchangesArr != null)
            {
                IList<MobileRetentionOrderDeliveryExchangeEntity> _oMobileRetentionOrderDeliveryExchangesList = (IList<MobileRetentionOrderDeliveryExchangeEntity>)_oMobileRetentionOrderDeliveryExchangesArr;
                return _oMobileRetentionOrderDeliveryExchangesList;
            }
            return new List<MobileRetentionOrderDeliveryExchangeEntity>();
        }
        
        public static IList<MobileRetentionOrderDeliveryExchangeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileRetentionOrderDeliveryExchangeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileRetentionOrderDeliveryExchangeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileRetentionOrderDeliveryExchangeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileRetentionOrderDeliveryExchangeRS x_oShowField = new MobileRetentionOrderDeliveryExchangeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileRetentionOrderDeliveryExchangeRS x_oSortField=new MobileRetentionOrderDeliveryExchangeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileRetentionOrderDeliveryExchange.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileRetentionOrderDeliveryExchange.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileRetentionOrderDeliveryExchangeRepositoryBase _oMobileRetentionOrderDeliveryExchangeRepositoryBase = new MobileRetentionOrderDeliveryExchangeRepositoryBase(GetDB());
            return _oMobileRetentionOrderDeliveryExchangeRepositoryBase.GetCount();
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


