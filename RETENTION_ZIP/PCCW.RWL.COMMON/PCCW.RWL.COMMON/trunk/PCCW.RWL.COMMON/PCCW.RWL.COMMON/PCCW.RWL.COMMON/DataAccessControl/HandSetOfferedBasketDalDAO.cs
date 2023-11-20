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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[HandSetOfferedBasket],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class HandSetOfferedBasketDalDAO{
        
        #region RS
        public class HandSetOfferedBasketRS
        {
            public bool n_bMid = false;
            public bool n_bR_offer = false;
            public bool n_bExtra_rebate_amount = false;
            public bool n_bCdate = false;
            public bool n_bAmount = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bSdate = false;
            public bool n_bPayment = false;
            public bool n_bRetention_type = false;
            public bool n_bEdate = false;
            public bool n_bCon_per = false;
            public bool n_bDdate = false;
            public bool n_bNormal_rebate_type = false;
            public bool n_bPremium = false;
            public bool n_bExtra_rebate = false;
            public bool n_bRebate_gp = false;
            public bool n_bNormal_rebate = false;
            public bool n_bHs_model = false;
            public bool n_bOffer_type_id = false;
            public bool n_bActive = false;
            public bool n_bRebate_amount = false;
            public bool n_bPlan_fee = false;
            public bool n_bItem_code = false;
            public bool n_bIssue_type = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bMid  || x_bSetShowALL || (HandSetOfferedBasket.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.mid);
                }
                if (this.n_bR_offer  || x_bSetShowALL || (HandSetOfferedBasket.Para.r_offer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bR_offer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.r_offer);
                }
                if (this.n_bExtra_rebate_amount  || x_bSetShowALL || (HandSetOfferedBasket.Para.extra_rebate_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_rebate_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.extra_rebate_amount);
                }
                if (this.n_bCdate  || x_bSetShowALL || (HandSetOfferedBasket.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.cdate);
                }
                if (this.n_bAmount  || x_bSetShowALL || (HandSetOfferedBasket.Para.amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAmount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.amount);
                }
                if (this.n_bCid  || x_bSetShowALL || (HandSetOfferedBasket.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (HandSetOfferedBasket.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.did);
                }
                if (this.n_bSdate  || x_bSetShowALL || (HandSetOfferedBasket.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.sdate);
                }
                if (this.n_bPayment  || x_bSetShowALL || (HandSetOfferedBasket.Para.payment.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPayment=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.payment);
                }
                if (this.n_bRetention_type  || x_bSetShowALL || (HandSetOfferedBasket.Para.retention_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetention_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.retention_type);
                }
                if (this.n_bEdate  || x_bSetShowALL || (HandSetOfferedBasket.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.edate);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (HandSetOfferedBasket.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.con_per);
                }
                if (this.n_bDdate  || x_bSetShowALL || (HandSetOfferedBasket.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.ddate);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (HandSetOfferedBasket.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.normal_rebate_type);
                }
                if (this.n_bPremium  || x_bSetShowALL || (HandSetOfferedBasket.Para.premium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.premium);
                }
                if (this.n_bExtra_rebate  || x_bSetShowALL || (HandSetOfferedBasket.Para.extra_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.extra_rebate);
                }
                if (this.n_bRebate_gp  || x_bSetShowALL || (HandSetOfferedBasket.Para.rebate_gp.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate_gp=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.rebate_gp);
                }
                if (this.n_bNormal_rebate  || x_bSetShowALL || (HandSetOfferedBasket.Para.normal_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.normal_rebate);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (HandSetOfferedBasket.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.hs_model);
                }
                if (this.n_bOffer_type_id  || x_bSetShowALL || (HandSetOfferedBasket.Para.offer_type_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOffer_type_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.offer_type_id);
                }
                if (this.n_bActive  || x_bSetShowALL || (HandSetOfferedBasket.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.active);
                }
                if (this.n_bRebate_amount  || x_bSetShowALL || (HandSetOfferedBasket.Para.rebate_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.rebate_amount);
                }
                if (this.n_bPlan_fee  || x_bSetShowALL || (HandSetOfferedBasket.Para.plan_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_fee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.plan_fee);
                }
                if (this.n_bItem_code  || x_bSetShowALL || (HandSetOfferedBasket.Para.item_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bItem_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.item_code);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (HandSetOfferedBasket.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferedBasket.Para.issue_type);
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
        
        public HandSetOfferedBasketDalDAO(){
        }
        ~HandSetOfferedBasketDalDAO(){
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
            _oSearchUtils.SetTable(HandSetOfferedBasket.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<HandSetOfferedBasketEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, HandSetOfferedBasketRS x_oFieldsToReturn,HandSetOfferedBasketRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<HandSetOfferedBasketEntity> _oHandSetOfferedBasketList = new List<HandSetOfferedBasketEntity>();
                
                while (_oDATA.Read())
                {
                    HandSetOfferedBasket _oHandSetOfferedBasket = new HandSetOfferedBasket();
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.mid])) { _oHandSetOfferedBasket.SetMid((global::System.Nullable<int>)_oDATA[HandSetOfferedBasket.Para.mid]); } else { _oHandSetOfferedBasket.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bR_offer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.r_offer])) { _oHandSetOfferedBasket.SetR_offer((string)_oDATA[HandSetOfferedBasket.Para.r_offer]); } else { _oHandSetOfferedBasket.SetR_offer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_rebate_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.extra_rebate_amount])) { _oHandSetOfferedBasket.SetExtra_rebate_amount((string)_oDATA[HandSetOfferedBasket.Para.extra_rebate_amount]); } else { _oHandSetOfferedBasket.SetExtra_rebate_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.cdate])) { _oHandSetOfferedBasket.SetCdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferedBasket.Para.cdate]); } else { _oHandSetOfferedBasket.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAmount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.amount])) { _oHandSetOfferedBasket.SetAmount((string)_oDATA[HandSetOfferedBasket.Para.amount]); } else { _oHandSetOfferedBasket.SetAmount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.cid])) { _oHandSetOfferedBasket.SetCid((string)_oDATA[HandSetOfferedBasket.Para.cid]); } else { _oHandSetOfferedBasket.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.did])) { _oHandSetOfferedBasket.SetDid((string)_oDATA[HandSetOfferedBasket.Para.did]); } else { _oHandSetOfferedBasket.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.sdate])) { _oHandSetOfferedBasket.SetSdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferedBasket.Para.sdate]); } else { _oHandSetOfferedBasket.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPayment))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.payment])) { _oHandSetOfferedBasket.SetPayment((string)_oDATA[HandSetOfferedBasket.Para.payment]); } else { _oHandSetOfferedBasket.SetPayment(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetention_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.retention_type])) { _oHandSetOfferedBasket.SetRetention_type((string)_oDATA[HandSetOfferedBasket.Para.retention_type]); } else { _oHandSetOfferedBasket.SetRetention_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.edate])) { _oHandSetOfferedBasket.SetEdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferedBasket.Para.edate]); } else { _oHandSetOfferedBasket.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.con_per])) { _oHandSetOfferedBasket.SetCon_per((string)_oDATA[HandSetOfferedBasket.Para.con_per]); } else { _oHandSetOfferedBasket.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.ddate])) { _oHandSetOfferedBasket.SetDdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferedBasket.Para.ddate]); } else { _oHandSetOfferedBasket.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.normal_rebate_type])) { _oHandSetOfferedBasket.SetNormal_rebate_type((string)_oDATA[HandSetOfferedBasket.Para.normal_rebate_type]); } else { _oHandSetOfferedBasket.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.premium])) { _oHandSetOfferedBasket.SetPremium((string)_oDATA[HandSetOfferedBasket.Para.premium]); } else { _oHandSetOfferedBasket.SetPremium(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.extra_rebate])) { _oHandSetOfferedBasket.SetExtra_rebate((string)_oDATA[HandSetOfferedBasket.Para.extra_rebate]); } else { _oHandSetOfferedBasket.SetExtra_rebate(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate_gp))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.rebate_gp])) { _oHandSetOfferedBasket.SetRebate_gp((string)_oDATA[HandSetOfferedBasket.Para.rebate_gp]); } else { _oHandSetOfferedBasket.SetRebate_gp(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.normal_rebate])) { _oHandSetOfferedBasket.SetNormal_rebate((global::System.Nullable<bool>)_oDATA[HandSetOfferedBasket.Para.normal_rebate]); } else { _oHandSetOfferedBasket.SetNormal_rebate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.hs_model])) { _oHandSetOfferedBasket.SetHs_model((string)_oDATA[HandSetOfferedBasket.Para.hs_model]); } else { _oHandSetOfferedBasket.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOffer_type_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.offer_type_id])) { _oHandSetOfferedBasket.SetOffer_type_id((global::System.Nullable<int>)_oDATA[HandSetOfferedBasket.Para.offer_type_id]); } else { _oHandSetOfferedBasket.SetOffer_type_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.active])) { _oHandSetOfferedBasket.SetActive((global::System.Nullable<bool>)_oDATA[HandSetOfferedBasket.Para.active]); } else { _oHandSetOfferedBasket.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.rebate_amount])) { _oHandSetOfferedBasket.SetRebate_amount((string)_oDATA[HandSetOfferedBasket.Para.rebate_amount]); } else { _oHandSetOfferedBasket.SetRebate_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.plan_fee])) { _oHandSetOfferedBasket.SetPlan_fee((string)_oDATA[HandSetOfferedBasket.Para.plan_fee]); } else { _oHandSetOfferedBasket.SetPlan_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bItem_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.item_code])) { _oHandSetOfferedBasket.SetItem_code((string)_oDATA[HandSetOfferedBasket.Para.item_code]); } else { _oHandSetOfferedBasket.SetItem_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferedBasket.Para.issue_type])) { _oHandSetOfferedBasket.SetIssue_type((string)_oDATA[HandSetOfferedBasket.Para.issue_type]); } else { _oHandSetOfferedBasket.SetIssue_type(global::System.String.Empty); }
                    }
                    _oHandSetOfferedBasketList.Add(_oHandSetOfferedBasket);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oHandSetOfferedBasketList;
            }
            return new List<HandSetOfferedBasketEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<HandSetOfferedBasketEntity> OrderBy(string x_sSort, IQueryable<HandSetOfferedBasketEntity> x_oHandSetOfferedBasketBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case HandSetOfferedBasket.Para.mid:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.r_offer:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.r_offer).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.r_offer).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.extra_rebate_amount:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.extra_rebate_amount).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.extra_rebate_amount).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.cdate:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.amount:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.amount).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.amount).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.cid:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.did:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.sdate:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.payment:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.payment).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.payment).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.retention_type:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.retention_type).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.retention_type).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.edate:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.con_per:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.ddate:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.premium:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.premium).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.premium).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.extra_rebate:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.extra_rebate).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.extra_rebate).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.rebate_gp:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.rebate_gp).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.rebate_gp).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.normal_rebate:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.normal_rebate).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.normal_rebate).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.hs_model:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.offer_type_id:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.offer_type_id).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.offer_type_id).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.active:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.rebate_amount:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.rebate_amount).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.rebate_amount).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.plan_fee:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.plan_fee).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.plan_fee).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.item_code:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.item_code).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.item_code).Select(c => c);
                break;
                case HandSetOfferedBasket.Para.issue_type:
                if(x_bAsc)
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oHandSetOfferedBasketBaseList = x_oHandSetOfferedBasketBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
            }
            return x_oHandSetOfferedBasketBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<HandSetOfferedBasketEntity> FindAll()
        {
            HandSetOfferedBasketEntity[] _oHandSetOfferedBasketsArr=  HandSetOfferedBasketRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oHandSetOfferedBasketsArr != null)
            {
                IList<HandSetOfferedBasketEntity> _oHandSetOfferedBasketsList = (IList<HandSetOfferedBasketEntity>)_oHandSetOfferedBasketsArr;
                return _oHandSetOfferedBasketsList;
            }
            return new List<HandSetOfferedBasketEntity>();
        }
        
        public static IList<HandSetOfferedBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<HandSetOfferedBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<HandSetOfferedBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<HandSetOfferedBasketEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            HandSetOfferedBasketRS x_oShowField = new HandSetOfferedBasketRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            HandSetOfferedBasketRS x_oSortField=new HandSetOfferedBasketRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(HandSetOfferedBasket.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(HandSetOfferedBasket.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            HandSetOfferedBasketRepositoryBase _oHandSetOfferedBasketRepositoryBase = new HandSetOfferedBasketRepositoryBase(GetDB());
            return _oHandSetOfferedBasketRepositoryBase.GetCount();
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


