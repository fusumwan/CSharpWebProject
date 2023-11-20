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
///-- Create date: <Create Date 2010-11-05>
///-- Description:	<Description,Table :[MobileAssignList],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileAssignListDalDAO{
        
        #region RS
        public class MobileAssignListRS
        {
            public bool n_bSku = false;
            public bool n_bOrder_id = false;
            public bool n_bHs_model = false;
            public bool n_bEdf_no = false;
            public bool n_bImei_no = false;
            public bool n_bActive = false;
            public bool n_bD_date = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bSku  || x_bSetShowALL || (MobileAssignList.Para.sku.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSku=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAssignList.Para.sku);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileAssignList.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAssignList.Para.order_id);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (MobileAssignList.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAssignList.Para.hs_model);
                }
                if (this.n_bEdf_no  || x_bSetShowALL || (MobileAssignList.Para.edf_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdf_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAssignList.Para.edf_no);
                }
                if (this.n_bImei_no  || x_bSetShowALL || (MobileAssignList.Para.imei_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAssignList.Para.imei_no);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileAssignList.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAssignList.Para.active);
                }
                if (this.n_bD_date  || x_bSetShowALL || (MobileAssignList.Para.d_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileAssignList.Para.d_date);
                }
                return _oFR.ToString();
            }
            
            public string FieldsToReturn()
            {
                return this.FieldsToReturn(string.Empty,false);
            }
            
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
            _oSearchUtils.SetTable(MobileAssignList.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileAssignListEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileAssignListRS x_oFieldsToReturn,MobileAssignListRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileAssignListEntity> _oMobileAssignListList = new List<MobileAssignListEntity>();
                
                while (_oDATA.Read())
                {
                    MobileAssignList _oMobileAssignList = new MobileAssignList();
                    if ((true).Equals(x_oFieldsToReturn.n_bSku))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAssignList.Para.sku])) { _oMobileAssignList.SetSku((string)_oDATA[MobileAssignList.Para.sku]); } else { _oMobileAssignList.SetSku(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAssignList.Para.order_id])) { _oMobileAssignList.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileAssignList.Para.order_id]); } else { _oMobileAssignList.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAssignList.Para.hs_model])) { _oMobileAssignList.SetHs_model((string)_oDATA[MobileAssignList.Para.hs_model]); } else { _oMobileAssignList.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdf_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAssignList.Para.edf_no])) { _oMobileAssignList.SetEdf_no((string)_oDATA[MobileAssignList.Para.edf_no]); } else { _oMobileAssignList.SetEdf_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAssignList.Para.imei_no])) { _oMobileAssignList.SetImei_no((string)_oDATA[MobileAssignList.Para.imei_no]); } else { _oMobileAssignList.SetImei_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAssignList.Para.active])) { _oMobileAssignList.SetActive((global::System.Nullable<bool>)_oDATA[MobileAssignList.Para.active]); } else { _oMobileAssignList.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileAssignList.Para.d_date])) { _oMobileAssignList.SetD_date((global::System.Nullable<DateTime>)_oDATA[MobileAssignList.Para.d_date]); } else { _oMobileAssignList.SetD_date(null); }
                    }
                    _oMobileAssignListList.Add(_oMobileAssignList);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileAssignListList;
            }
            return new List<MobileAssignListEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileAssignListEntity> OrderBy(string x_sSort, IQueryable<MobileAssignListEntity> x_oMobileAssignListBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileAssignList.Para.sku:
                if(x_bAsc)
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderBy(c => c.sku).Select(c => c);
                else
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderByDescending(c => c.sku).Select(c => c);
                break;
                case MobileAssignList.Para.order_id:
                if(x_bAsc)
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileAssignList.Para.hs_model:
                if(x_bAsc)
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case MobileAssignList.Para.edf_no:
                if(x_bAsc)
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderBy(c => c.edf_no).Select(c => c);
                else
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderByDescending(c => c.edf_no).Select(c => c);
                break;
                case MobileAssignList.Para.imei_no:
                if(x_bAsc)
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderBy(c => c.imei_no).Select(c => c);
                else
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderByDescending(c => c.imei_no).Select(c => c);
                break;
                case MobileAssignList.Para.active:
                if(x_bAsc)
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileAssignList.Para.d_date:
                if(x_bAsc)
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderBy(c => c.d_date).Select(c => c);
                else
                    x_oMobileAssignListBaseList = x_oMobileAssignListBaseList.OrderByDescending(c => c.d_date).Select(c => c);
                break;
            }
            return x_oMobileAssignListBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileAssignListEntity> FindAll()
        {
            MobileAssignListEntity[] _oMobileAssignListsArr=  MobileAssignListRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileAssignListsArr != null)
            {
                IList<MobileAssignListEntity> _oMobileAssignListsList = (IList<MobileAssignListEntity>)_oMobileAssignListsArr;
                return _oMobileAssignListsList;
            }
            return new List<MobileAssignListEntity>();
        }
        
        public static IList<MobileAssignListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileAssignListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileAssignListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileAssignListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileAssignListRS x_oShowField = new MobileAssignListRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileAssignListRS x_oSortField=new MobileAssignListRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            x_oSortField.FieldsToReturn(x_sSortExpression,false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }

        public static IList<MobileAssignListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter, bool x_bAsc)
        {
            MobileAssignListRS x_oShowField = new MobileAssignListRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileAssignListRS x_oSortField = new MobileAssignListRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            x_oSortField.FieldsToReturn(x_sSortExpression, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, x_bAsc);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileAssignListRepositoryBase _oMobileAssignListRepositoryBase = new MobileAssignListRepositoryBase(GetDB());
            return _oMobileAssignListRepositoryBase.GetCount();
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


