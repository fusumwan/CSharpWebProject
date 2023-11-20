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
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[OfferAutomation],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class OfferAutomationDalDAO{
        
        #region RS
        public class OfferAutomationRS
        {
            public bool n_bId = false;
            public bool n_bOffer_name = false;
            public bool n_bCall_list_program_id = false;
            public bool n_bActive = false;
            public bool n_bTrade_field_id = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (OfferAutomation.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(OfferAutomation.Para.id);
                }
                if (this.n_bOffer_name  || x_bSetShowALL || (OfferAutomation.Para.offer_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOffer_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(OfferAutomation.Para.offer_name);
                }
                if (this.n_bCall_list_program_id  || x_bSetShowALL || (OfferAutomation.Para.call_list_program_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCall_list_program_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(OfferAutomation.Para.call_list_program_id);
                }
                if (this.n_bActive  || x_bSetShowALL || (OfferAutomation.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(OfferAutomation.Para.active);
                }
                if (this.n_bTrade_field_id  || x_bSetShowALL || (OfferAutomation.Para.trade_field_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTrade_field_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(OfferAutomation.Para.trade_field_id);
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
        
        public OfferAutomationDalDAO(){
        }
        ~OfferAutomationDalDAO(){
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
            _oSearchUtils.SetTable(OfferAutomation.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<OfferAutomationEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, OfferAutomationRS x_oFieldsToReturn,OfferAutomationRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<OfferAutomationEntity> _oOfferAutomationList = new List<OfferAutomationEntity>();
                
                while (_oDATA.Read())
                {
                    OfferAutomation _oOfferAutomation = new OfferAutomation();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[OfferAutomation.Para.id])) { _oOfferAutomation.SetId((global::System.Nullable<int>)_oDATA[OfferAutomation.Para.id]); } else { _oOfferAutomation.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOffer_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[OfferAutomation.Para.offer_name])) { _oOfferAutomation.SetOffer_name((string)_oDATA[OfferAutomation.Para.offer_name]); } else { _oOfferAutomation.SetOffer_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCall_list_program_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[OfferAutomation.Para.call_list_program_id])) { _oOfferAutomation.SetCall_list_program_id((global::System.Nullable<long>)_oDATA[OfferAutomation.Para.call_list_program_id]); } else { _oOfferAutomation.SetCall_list_program_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[OfferAutomation.Para.active])) { _oOfferAutomation.SetActive((global::System.Nullable<bool>)_oDATA[OfferAutomation.Para.active]); } else { _oOfferAutomation.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTrade_field_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[OfferAutomation.Para.trade_field_id])) { _oOfferAutomation.SetTrade_field_id((global::System.Nullable<int>)_oDATA[OfferAutomation.Para.trade_field_id]); } else { _oOfferAutomation.SetTrade_field_id(null); }
                    }
                    _oOfferAutomationList.Add(_oOfferAutomation);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oOfferAutomationList;
            }
            return new List<OfferAutomationEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<OfferAutomationEntity> OrderBy(string x_sSort, IQueryable<OfferAutomationEntity> x_oOfferAutomationBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case OfferAutomation.Para.id:
                if(x_bAsc)
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case OfferAutomation.Para.offer_name:
                if(x_bAsc)
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderBy(c => c.offer_name).Select(c => c);
                else
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderByDescending(c => c.offer_name).Select(c => c);
                break;
                case OfferAutomation.Para.call_list_program_id:
                if(x_bAsc)
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderBy(c => c.call_list_program_id).Select(c => c);
                else
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderByDescending(c => c.call_list_program_id).Select(c => c);
                break;
                case OfferAutomation.Para.active:
                if(x_bAsc)
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case OfferAutomation.Para.trade_field_id:
                if(x_bAsc)
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderBy(c => c.trade_field_id).Select(c => c);
                else
                    x_oOfferAutomationBaseList = x_oOfferAutomationBaseList.OrderByDescending(c => c.trade_field_id).Select(c => c);
                break;
            }
            return x_oOfferAutomationBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<OfferAutomationEntity> FindAll()
        {
            OfferAutomationEntity[] _oOfferAutomationsArr=  OfferAutomationRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oOfferAutomationsArr != null)
            {
                IList<OfferAutomationEntity> _oOfferAutomationsList = (IList<OfferAutomationEntity>)_oOfferAutomationsArr;
                return _oOfferAutomationsList;
            }
            return new List<OfferAutomationEntity>();
        }
        
        public static IList<OfferAutomationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<OfferAutomationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<OfferAutomationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<OfferAutomationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            OfferAutomationRS x_oShowField = new OfferAutomationRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            OfferAutomationRS x_oSortField=new OfferAutomationRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(OfferAutomation.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(OfferAutomation.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            OfferAutomationRepositoryBase _oOfferAutomationRepositoryBase = new OfferAutomationRepositoryBase(GetDB());
            return _oOfferAutomationRepositoryBase.GetCount();
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


