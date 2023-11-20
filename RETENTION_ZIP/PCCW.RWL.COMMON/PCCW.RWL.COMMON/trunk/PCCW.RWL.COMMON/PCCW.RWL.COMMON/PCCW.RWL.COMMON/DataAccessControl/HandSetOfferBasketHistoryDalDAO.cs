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
///-- Description:	<Description,Table :[HandSetOfferBasketHistory],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class HandSetOfferBasketHistoryDalDAO{
        
        #region RS
        public class HandSetOfferBasketHistoryRS
        {
            public bool n_bRec_no = false;
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
                if (this.n_bRec_no  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.rec_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRec_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.rec_no);
                }
                if (this.n_bMid  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.mid);
                }
                if (this.n_bR_offer  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.r_offer.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bR_offer=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.r_offer);
                }
                if (this.n_bExtra_rebate_amount  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.extra_rebate_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_rebate_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.extra_rebate_amount);
                }
                if (this.n_bCdate  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.cdate);
                }
                if (this.n_bAmount  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAmount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.amount);
                }
                if (this.n_bCid  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.did);
                }
                if (this.n_bSdate  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.sdate);
                }
                if (this.n_bPayment  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.payment.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPayment=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.payment);
                }
                if (this.n_bRetention_type  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.retention_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetention_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.retention_type);
                }
                if (this.n_bEdate  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.edate);
                }
                if (this.n_bCon_per  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.con_per.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCon_per=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.con_per);
                }
                if (this.n_bDdate  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.ddate);
                }
                if (this.n_bNormal_rebate_type  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.normal_rebate_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.normal_rebate_type);
                }
                if (this.n_bPremium  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.premium.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPremium=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.premium);
                }
                if (this.n_bExtra_rebate  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.extra_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExtra_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.extra_rebate);
                }
                if (this.n_bRebate_gp  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.rebate_gp.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate_gp=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.rebate_gp);
                }
                if (this.n_bNormal_rebate  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.normal_rebate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bNormal_rebate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.normal_rebate);
                }
                if (this.n_bHs_model  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.hs_model.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHs_model=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.hs_model);
                }
                if (this.n_bOffer_type_id  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.offer_type_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOffer_type_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.offer_type_id);
                }
                if (this.n_bActive  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.active);
                }
                if (this.n_bRebate_amount  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.rebate_amount.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRebate_amount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.rebate_amount);
                }
                if (this.n_bPlan_fee  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.plan_fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPlan_fee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.plan_fee);
                }
                if (this.n_bItem_code  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.item_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bItem_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.item_code);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (HandSetOfferBasketHistory.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(HandSetOfferBasketHistory.Para.issue_type);
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
        
        public HandSetOfferBasketHistoryDalDAO(){
        }
        ~HandSetOfferBasketHistoryDalDAO(){
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
            _oSearchUtils.SetTable(HandSetOfferBasketHistory.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<HandSetOfferBasketHistoryEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, HandSetOfferBasketHistoryRS x_oFieldsToReturn,HandSetOfferBasketHistoryRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<HandSetOfferBasketHistoryEntity> _oHandSetOfferBasketHistoryList = new List<HandSetOfferBasketHistoryEntity>();
                
                while (_oDATA.Read())
                {
                    HandSetOfferBasketHistory _oHandSetOfferBasketHistory = new HandSetOfferBasketHistory();
                    if ((true).Equals(x_oFieldsToReturn.n_bRec_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.rec_no])) { _oHandSetOfferBasketHistory.SetRec_no((global::System.Nullable<int>)_oDATA[HandSetOfferBasketHistory.Para.rec_no]); } else { _oHandSetOfferBasketHistory.SetRec_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.mid])) { _oHandSetOfferBasketHistory.SetMid((global::System.Nullable<int>)_oDATA[HandSetOfferBasketHistory.Para.mid]); } else { _oHandSetOfferBasketHistory.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bR_offer))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.r_offer])) { _oHandSetOfferBasketHistory.SetR_offer((string)_oDATA[HandSetOfferBasketHistory.Para.r_offer]); } else { _oHandSetOfferBasketHistory.SetR_offer(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_rebate_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.extra_rebate_amount])) { _oHandSetOfferBasketHistory.SetExtra_rebate_amount((string)_oDATA[HandSetOfferBasketHistory.Para.extra_rebate_amount]); } else { _oHandSetOfferBasketHistory.SetExtra_rebate_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.cdate])) { _oHandSetOfferBasketHistory.SetCdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferBasketHistory.Para.cdate]); } else { _oHandSetOfferBasketHistory.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAmount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.amount])) { _oHandSetOfferBasketHistory.SetAmount((string)_oDATA[HandSetOfferBasketHistory.Para.amount]); } else { _oHandSetOfferBasketHistory.SetAmount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.cid])) { _oHandSetOfferBasketHistory.SetCid((string)_oDATA[HandSetOfferBasketHistory.Para.cid]); } else { _oHandSetOfferBasketHistory.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.did])) { _oHandSetOfferBasketHistory.SetDid((string)_oDATA[HandSetOfferBasketHistory.Para.did]); } else { _oHandSetOfferBasketHistory.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.sdate])) { _oHandSetOfferBasketHistory.SetSdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferBasketHistory.Para.sdate]); } else { _oHandSetOfferBasketHistory.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPayment))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.payment])) { _oHandSetOfferBasketHistory.SetPayment((string)_oDATA[HandSetOfferBasketHistory.Para.payment]); } else { _oHandSetOfferBasketHistory.SetPayment(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetention_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.retention_type])) { _oHandSetOfferBasketHistory.SetRetention_type((string)_oDATA[HandSetOfferBasketHistory.Para.retention_type]); } else { _oHandSetOfferBasketHistory.SetRetention_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.edate])) { _oHandSetOfferBasketHistory.SetEdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferBasketHistory.Para.edate]); } else { _oHandSetOfferBasketHistory.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCon_per))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.con_per])) { _oHandSetOfferBasketHistory.SetCon_per((string)_oDATA[HandSetOfferBasketHistory.Para.con_per]); } else { _oHandSetOfferBasketHistory.SetCon_per(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.ddate])) { _oHandSetOfferBasketHistory.SetDdate((global::System.Nullable<DateTime>)_oDATA[HandSetOfferBasketHistory.Para.ddate]); } else { _oHandSetOfferBasketHistory.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.normal_rebate_type])) { _oHandSetOfferBasketHistory.SetNormal_rebate_type((string)_oDATA[HandSetOfferBasketHistory.Para.normal_rebate_type]); } else { _oHandSetOfferBasketHistory.SetNormal_rebate_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPremium))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.premium])) { _oHandSetOfferBasketHistory.SetPremium((string)_oDATA[HandSetOfferBasketHistory.Para.premium]); } else { _oHandSetOfferBasketHistory.SetPremium(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExtra_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.extra_rebate])) { _oHandSetOfferBasketHistory.SetExtra_rebate((string)_oDATA[HandSetOfferBasketHistory.Para.extra_rebate]); } else { _oHandSetOfferBasketHistory.SetExtra_rebate(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate_gp))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.rebate_gp])) { _oHandSetOfferBasketHistory.SetRebate_gp((string)_oDATA[HandSetOfferBasketHistory.Para.rebate_gp]); } else { _oHandSetOfferBasketHistory.SetRebate_gp(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bNormal_rebate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.normal_rebate])) { _oHandSetOfferBasketHistory.SetNormal_rebate((global::System.Nullable<bool>)_oDATA[HandSetOfferBasketHistory.Para.normal_rebate]); } else { _oHandSetOfferBasketHistory.SetNormal_rebate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHs_model))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.hs_model])) { _oHandSetOfferBasketHistory.SetHs_model((string)_oDATA[HandSetOfferBasketHistory.Para.hs_model]); } else { _oHandSetOfferBasketHistory.SetHs_model(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOffer_type_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.offer_type_id])) { _oHandSetOfferBasketHistory.SetOffer_type_id((global::System.Nullable<int>)_oDATA[HandSetOfferBasketHistory.Para.offer_type_id]); } else { _oHandSetOfferBasketHistory.SetOffer_type_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.active])) { _oHandSetOfferBasketHistory.SetActive((global::System.Nullable<bool>)_oDATA[HandSetOfferBasketHistory.Para.active]); } else { _oHandSetOfferBasketHistory.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRebate_amount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.rebate_amount])) { _oHandSetOfferBasketHistory.SetRebate_amount((string)_oDATA[HandSetOfferBasketHistory.Para.rebate_amount]); } else { _oHandSetOfferBasketHistory.SetRebate_amount(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_fee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.plan_fee])) { _oHandSetOfferBasketHistory.SetPlan_fee((string)_oDATA[HandSetOfferBasketHistory.Para.plan_fee]); } else { _oHandSetOfferBasketHistory.SetPlan_fee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bItem_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.item_code])) { _oHandSetOfferBasketHistory.SetItem_code((string)_oDATA[HandSetOfferBasketHistory.Para.item_code]); } else { _oHandSetOfferBasketHistory.SetItem_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[HandSetOfferBasketHistory.Para.issue_type])) { _oHandSetOfferBasketHistory.SetIssue_type((string)_oDATA[HandSetOfferBasketHistory.Para.issue_type]); } else { _oHandSetOfferBasketHistory.SetIssue_type(global::System.String.Empty); }
                    }
                    _oHandSetOfferBasketHistoryList.Add(_oHandSetOfferBasketHistory);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oHandSetOfferBasketHistoryList;
            }
            return new List<HandSetOfferBasketHistoryEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<HandSetOfferBasketHistoryEntity> OrderBy(string x_sSort, IQueryable<HandSetOfferBasketHistoryEntity> x_oHandSetOfferBasketHistoryBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case HandSetOfferBasketHistory.Para.rec_no:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.rec_no).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.rec_no).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.mid:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.r_offer:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.r_offer).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.r_offer).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.extra_rebate_amount:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.extra_rebate_amount).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.extra_rebate_amount).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.cdate:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.amount:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.amount).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.amount).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.cid:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.did:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.sdate:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.payment:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.payment).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.payment).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.retention_type:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.retention_type).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.retention_type).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.edate:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.con_per:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.con_per).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.con_per).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.ddate:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.normal_rebate_type:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.normal_rebate_type).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.normal_rebate_type).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.premium:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.premium).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.premium).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.extra_rebate:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.extra_rebate).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.extra_rebate).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.rebate_gp:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.rebate_gp).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.rebate_gp).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.normal_rebate:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.normal_rebate).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.normal_rebate).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.hs_model:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.hs_model).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.hs_model).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.offer_type_id:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.offer_type_id).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.offer_type_id).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.active:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.rebate_amount:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.rebate_amount).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.rebate_amount).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.plan_fee:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.plan_fee).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.plan_fee).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.item_code:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.item_code).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.item_code).Select(c => c);
                break;
                case HandSetOfferBasketHistory.Para.issue_type:
                if(x_bAsc)
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oHandSetOfferBasketHistoryBaseList = x_oHandSetOfferBasketHistoryBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
            }
            return x_oHandSetOfferBasketHistoryBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<HandSetOfferBasketHistoryEntity> FindAll()
        {
            HandSetOfferBasketHistoryEntity[] _oHandSetOfferBasketHistorysArr=  HandSetOfferBasketHistoryRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oHandSetOfferBasketHistorysArr != null)
            {
                IList<HandSetOfferBasketHistoryEntity> _oHandSetOfferBasketHistorysList = (IList<HandSetOfferBasketHistoryEntity>)_oHandSetOfferBasketHistorysArr;
                return _oHandSetOfferBasketHistorysList;
            }
            return new List<HandSetOfferBasketHistoryEntity>();
        }
        
        public static IList<HandSetOfferBasketHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<HandSetOfferBasketHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<HandSetOfferBasketHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<HandSetOfferBasketHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            HandSetOfferBasketHistoryRS x_oShowField = new HandSetOfferBasketHistoryRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            HandSetOfferBasketHistoryRS x_oSortField=new HandSetOfferBasketHistoryRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(HandSetOfferBasketHistory.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(HandSetOfferBasketHistory.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            HandSetOfferBasketHistoryRepositoryBase _oHandSetOfferBasketHistoryRepositoryBase = new HandSetOfferBasketHistoryRepositoryBase(GetDB());
            return _oHandSetOfferBasketHistoryRepositoryBase.GetCount();
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


