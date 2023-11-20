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
///-- Create date: <Create Date 2011-11-09>
///-- Description:	<Description,Table :[MonthlyPaymentMethodMapping],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MonthlyPaymentMethodMappingDalDAO{
        
        #region RS
        public class MonthlyPaymentMethodMappingRS
        {
            public bool n_bCash_group = false;
            public bool n_bId = false;
            public bool n_bActive = false;
            public bool n_bCredit_card_group = false;
            public bool n_bPayment_type = false;
            public bool n_bProgram = false;
            public bool n_bIssue_type = false;
            public bool n_bThird_party_credit_card = false;
            public bool n_bBank_account_group = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bCash_group  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.cash_group.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCash_group=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.cash_group);
                }
                if (this.n_bId  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.id);
                }
                if (this.n_bActive  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.active);
                }
                if (this.n_bCredit_card_group  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.credit_card_group.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCredit_card_group=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.credit_card_group);
                }
                if (this.n_bPayment_type  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.payment_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPayment_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.payment_type);
                }
                if (this.n_bProgram  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.program.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bProgram=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.program);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.issue_type);
                }
                if (this.n_bThird_party_credit_card  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.third_party_credit_card.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bThird_party_credit_card=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.third_party_credit_card);
                }
                if (this.n_bBank_account_group  || x_bSetShowALL || (MonthlyPaymentMethodMapping.Para.bank_account_group.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bBank_account_group=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MonthlyPaymentMethodMapping.Para.bank_account_group);
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
        
        public MonthlyPaymentMethodMappingDalDAO(){
        }
        ~MonthlyPaymentMethodMappingDalDAO(){
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
            _oSearchUtils.SetTable(MonthlyPaymentMethodMapping.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MonthlyPaymentMethodMappingEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MonthlyPaymentMethodMappingRS x_oFieldsToReturn,MonthlyPaymentMethodMappingRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MonthlyPaymentMethodMappingEntity> _oMonthlyPaymentMethodMappingList = new List<MonthlyPaymentMethodMappingEntity>();
                
                while (_oDATA.Read())
                {
                    MonthlyPaymentMethodMapping _oMonthlyPaymentMethodMapping = new MonthlyPaymentMethodMapping();
                    if ((true).Equals(x_oFieldsToReturn.n_bCash_group))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.cash_group])) { _oMonthlyPaymentMethodMapping.SetCash_group((global::System.Nullable<bool>)_oDATA[MonthlyPaymentMethodMapping.Para.cash_group]); } else { _oMonthlyPaymentMethodMapping.SetCash_group(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.id])) { _oMonthlyPaymentMethodMapping.SetId((global::System.Nullable<int>)_oDATA[MonthlyPaymentMethodMapping.Para.id]); } else { _oMonthlyPaymentMethodMapping.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.active])) { _oMonthlyPaymentMethodMapping.SetActive((global::System.Nullable<bool>)_oDATA[MonthlyPaymentMethodMapping.Para.active]); } else { _oMonthlyPaymentMethodMapping.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCredit_card_group))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.credit_card_group])) { _oMonthlyPaymentMethodMapping.SetCredit_card_group((global::System.Nullable<bool>)_oDATA[MonthlyPaymentMethodMapping.Para.credit_card_group]); } else { _oMonthlyPaymentMethodMapping.SetCredit_card_group(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPayment_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.payment_type])) { _oMonthlyPaymentMethodMapping.SetPayment_type((string)_oDATA[MonthlyPaymentMethodMapping.Para.payment_type]); } else { _oMonthlyPaymentMethodMapping.SetPayment_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.program])) { _oMonthlyPaymentMethodMapping.SetProgram((string)_oDATA[MonthlyPaymentMethodMapping.Para.program]); } else { _oMonthlyPaymentMethodMapping.SetProgram(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.issue_type])) { _oMonthlyPaymentMethodMapping.SetIssue_type((string)_oDATA[MonthlyPaymentMethodMapping.Para.issue_type]); } else { _oMonthlyPaymentMethodMapping.SetIssue_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bThird_party_credit_card))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.third_party_credit_card])) { _oMonthlyPaymentMethodMapping.SetThird_party_credit_card((global::System.Nullable<bool>)_oDATA[MonthlyPaymentMethodMapping.Para.third_party_credit_card]); } else { _oMonthlyPaymentMethodMapping.SetThird_party_credit_card(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBank_account_group))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MonthlyPaymentMethodMapping.Para.bank_account_group])) { _oMonthlyPaymentMethodMapping.SetBank_account_group((global::System.Nullable<bool>)_oDATA[MonthlyPaymentMethodMapping.Para.bank_account_group]); } else { _oMonthlyPaymentMethodMapping.SetBank_account_group(null); }
                    }
                    _oMonthlyPaymentMethodMappingList.Add(_oMonthlyPaymentMethodMapping);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMonthlyPaymentMethodMappingList;
            }
            return new List<MonthlyPaymentMethodMappingEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MonthlyPaymentMethodMappingEntity> OrderBy(string x_sSort, IQueryable<MonthlyPaymentMethodMappingEntity> x_oMonthlyPaymentMethodMappingBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MonthlyPaymentMethodMapping.Para.cash_group:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.cash_group).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.cash_group).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.id:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.active:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.credit_card_group:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.credit_card_group).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.credit_card_group).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.payment_type:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.payment_type).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.payment_type).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.program:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.issue_type:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.third_party_credit_card:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.third_party_credit_card).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.third_party_credit_card).Select(c => c);
                break;
                case MonthlyPaymentMethodMapping.Para.bank_account_group:
                if(x_bAsc)
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderBy(c => c.bank_account_group).Select(c => c);
                else
                    x_oMonthlyPaymentMethodMappingBaseList = x_oMonthlyPaymentMethodMappingBaseList.OrderByDescending(c => c.bank_account_group).Select(c => c);
                break;
            }
            return x_oMonthlyPaymentMethodMappingBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MonthlyPaymentMethodMappingEntity> FindAll()
        {
            MonthlyPaymentMethodMappingEntity[] _oMonthlyPaymentMethodMappingsArr=  MonthlyPaymentMethodMappingRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMonthlyPaymentMethodMappingsArr != null)
            {
                IList<MonthlyPaymentMethodMappingEntity> _oMonthlyPaymentMethodMappingsList = (IList<MonthlyPaymentMethodMappingEntity>)_oMonthlyPaymentMethodMappingsArr;
                return _oMonthlyPaymentMethodMappingsList;
            }
            return new List<MonthlyPaymentMethodMappingEntity>();
        }
        
        public static IList<MonthlyPaymentMethodMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MonthlyPaymentMethodMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MonthlyPaymentMethodMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MonthlyPaymentMethodMappingEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MonthlyPaymentMethodMappingRS x_oShowField = new MonthlyPaymentMethodMappingRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MonthlyPaymentMethodMappingRS x_oSortField=new MonthlyPaymentMethodMappingRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MonthlyPaymentMethodMapping.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MonthlyPaymentMethodMapping.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MonthlyPaymentMethodMappingRepositoryBase _oMonthlyPaymentMethodMappingRepositoryBase = new MonthlyPaymentMethodMappingRepositoryBase(GetDB());
            return _oMonthlyPaymentMethodMappingRepositoryBase.GetCount();
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


