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
///-- Create date: <Create Date 2010-12-10>
///-- Description:	<Description,Table :[MobileOrderSyncSearch],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderSyncSearchDalDAO{
        
        #region RS
        public class MobileOrderSyncSearchRS
        {
            public bool n_bActive = false;
            public bool n_bSku = false;
            public bool n_bProgram = false;
            public bool n_bSim_item_name = false;
            public bool n_bD_date = false;
            public bool n_bEdf_no = false;
            public bool n_bOrder_id = false;
            public bool n_bSim_item_code = false;
            public bool n_bImei_no = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderSyncSearch.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.active);
                }
                if (this.n_bSku  || x_bSetShowALL || (MobileOrderSyncSearch.Para.sku.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSku=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.sku);
                }
                if (this.n_bProgram  || x_bSetShowALL || (MobileOrderSyncSearch.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.program);
                }
                if (this.n_bSim_item_name  || x_bSetShowALL || (MobileOrderSyncSearch.Para.sim_item_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSim_item_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.sim_item_name);
                }
                if (this.n_bD_date  || x_bSetShowALL || (MobileOrderSyncSearch.Para.d_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.d_date);
                }
                if (this.n_bEdf_no  || x_bSetShowALL || (MobileOrderSyncSearch.Para.edf_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdf_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.edf_no);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderSyncSearch.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.order_id);
                }
                if (this.n_bSim_item_code  || x_bSetShowALL || (MobileOrderSyncSearch.Para.sim_item_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSim_item_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.sim_item_code);
                }
                if (this.n_bImei_no  || x_bSetShowALL || (MobileOrderSyncSearch.Para.imei_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderSyncSearch.Para.imei_no);
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
        
        public MobileOrderSyncSearchDalDAO(){
        }
        ~MobileOrderSyncSearchDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderSyncSearch.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderSyncSearchEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderSyncSearchRS x_oFieldsToReturn,MobileOrderSyncSearchRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderSyncSearchEntity> _oMobileOrderSyncSearchList = new List<MobileOrderSyncSearchEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderSyncSearch _oMobileOrderSyncSearch = new MobileOrderSyncSearch();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.active])) { _oMobileOrderSyncSearch.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderSyncSearch.Para.active]); } else { _oMobileOrderSyncSearch.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSku))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.sku])) { _oMobileOrderSyncSearch.SetSku((string)_oDATA[MobileOrderSyncSearch.Para.sku]); } else { _oMobileOrderSyncSearch.SetSku(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.program])) { _oMobileOrderSyncSearch.SetProgram((string)_oDATA[MobileOrderSyncSearch.Para.program]); } else { _oMobileOrderSyncSearch.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSim_item_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.sim_item_name])) { _oMobileOrderSyncSearch.SetSim_item_name((string)_oDATA[MobileOrderSyncSearch.Para.sim_item_name]); } else { _oMobileOrderSyncSearch.SetSim_item_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.d_date])) { _oMobileOrderSyncSearch.SetD_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderSyncSearch.Para.d_date]); } else { _oMobileOrderSyncSearch.SetD_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdf_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.edf_no])) { _oMobileOrderSyncSearch.SetEdf_no((string)_oDATA[MobileOrderSyncSearch.Para.edf_no]); } else { _oMobileOrderSyncSearch.SetEdf_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.order_id])) { _oMobileOrderSyncSearch.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderSyncSearch.Para.order_id]); } else { _oMobileOrderSyncSearch.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSim_item_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.sim_item_code])) { _oMobileOrderSyncSearch.SetSim_item_code((string)_oDATA[MobileOrderSyncSearch.Para.sim_item_code]); } else { _oMobileOrderSyncSearch.SetSim_item_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderSyncSearch.Para.imei_no])) { _oMobileOrderSyncSearch.SetImei_no((string)_oDATA[MobileOrderSyncSearch.Para.imei_no]); } else { _oMobileOrderSyncSearch.SetImei_no(global::System.String.Empty); }
                    }
                    _oMobileOrderSyncSearchList.Add(_oMobileOrderSyncSearch);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderSyncSearchList;
            }
            return new List<MobileOrderSyncSearchEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderSyncSearchEntity> OrderBy(string x_sSort, IQueryable<MobileOrderSyncSearchEntity> x_oMobileOrderSyncSearchBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderSyncSearch.Para.active:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.sku:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.sku).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.sku).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.program:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.sim_item_name:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.sim_item_name).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.sim_item_name).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.d_date:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.d_date).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.d_date).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.edf_no:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.edf_no).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.edf_no).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.sim_item_code:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.sim_item_code).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.sim_item_code).Select(c => c);
                break;
                case MobileOrderSyncSearch.Para.imei_no:
                if(x_bAsc)
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderBy(c => c.imei_no).Select(c => c);
                else
                    x_oMobileOrderSyncSearchBaseList = x_oMobileOrderSyncSearchBaseList.OrderByDescending(c => c.imei_no).Select(c => c);
                break;
            }
            return x_oMobileOrderSyncSearchBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderSyncSearchEntity> FindAll()
        {
            MobileOrderSyncSearchEntity[] _oMobileOrderSyncSearchsArr=  MobileOrderSyncSearchRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderSyncSearchsArr != null)
            {
                IList<MobileOrderSyncSearchEntity> _oMobileOrderSyncSearchsList = (IList<MobileOrderSyncSearchEntity>)_oMobileOrderSyncSearchsArr;
                return _oMobileOrderSyncSearchsList;
            }
            return new List<MobileOrderSyncSearchEntity>();
        }
        
        public static IList<MobileOrderSyncSearchEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderSyncSearchEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderSyncSearchEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderSyncSearchEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderSyncSearchRS x_oShowField = new MobileOrderSyncSearchRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderSyncSearchRS x_oSortField=new MobileOrderSyncSearchRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderSyncSearch.Para.order_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderSyncSearch.Para.order_id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderSyncSearchRepositoryBase _oMobileOrderSyncSearchRepositoryBase = new MobileOrderSyncSearchRepositoryBase(GetDB());
            return _oMobileOrderSyncSearchRepositoryBase.GetCount();
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


