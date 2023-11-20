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
///-- Create date: <Create Date 2009-07-13>
///-- Description:	<Description,Table :[crm_rpt_2G_action_rpt_GL],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class Crm_rpt_2G_action_rpt_GLDalDAO{
        
        #region RS
        public class Crm_rpt_2G_action_rpt_GLRS
        {
            public bool n_bAls_flg = false;
            public bool n_bEnd_date = false;
            public bool n_bRemarks = false;
            public bool n_bAirtime_hs_model = false;
            public bool n_bStart_date = false;
            public bool n_bCalllist_name = false;
            public bool n_bJoin_date = false;
            public bool n_bField1 = false;
            public bool n_bBill_cycle = false;
            public bool n_bAddr_3 = false;
            public bool n_bAddr_2 = false;
            public bool n_bId_number = false;
            public bool n_bAttention_name_formartted = false;
            public bool n_bCustomer_name_formartted = false;
            public bool n_bAutopay = false;
            public bool n_bField3 = false;
            public bool n_bAddr_4 = false;
            public bool n_bProgram = false;
            public bool n_bProp_plan = false;
            public bool n_bCustomer_group = false;
            public bool n_bCustomer_code = false;
            public bool n_bTelemarketing_suppress_flag = false;
            public bool n_bIdd_flg = false;
            public bool n_bActive = false;
            public bool n_bDdate = false;
            public bool n_bId = false;
            public bool n_bPlan_fee = false;
            public bool n_bRate_plan = false;
            public bool n_bSegment = false;
            public bool n_bId1 = false;
            public bool n_bPassword = false;
            public bool n_bPayment_method = false;
            public bool n_bContract_id = false;
            public bool n_bField2 = false;
            public bool n_bMobile_no = false;
            public bool n_bPeriod = false;
            public bool n_bVas_desc = false;
            public bool n_bCdate = false;
            public bool n_bSubscriber_tier = false;
            public bool n_bCustomer_id = false;
            public bool n_bHandset_rebate_end_date = false;
            public bool n_bPlan_free_inter_min = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bExpired_month = false;
            public bool n_bPlan_free_intra_min = false;
            public bool n_bOriginal_telemarketing_suppress_flag = false;
            public bool n_bContact_number = false;
            public bool n_bTradefield = false;
            public bool n_bAddr_1 = false;
            public bool n_bMax_contract_end_date = false;
            public bool n_bMnp_rebate_end_date = false;
            public bool n_bProgram_id = false;
            public string FieldsToReturn()
            {
                StringBuilder _sFR = new StringBuilder();
                if (this.n_bAls_flg)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.als_flg);
                }
                if (this.n_bEnd_date)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.end_date);
                }
                if (this.n_bRemarks)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.remarks);
                }
                if (this.n_bAirtime_hs_model)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model);
                }
                if (this.n_bStart_date)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.start_date);
                }
                if (this.n_bCalllist_name)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.calllist_name);
                }
                if (this.n_bJoin_date)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.join_date);
                }
                if (this.n_bField1)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.field1);
                }
                if (this.n_bBill_cycle)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle);
                }
                if (this.n_bAddr_3)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.addr_3);
                }
                if (this.n_bAddr_2)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.addr_2);
                }
                if (this.n_bId_number)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.id_number);
                }
                if (this.n_bAttention_name_formartted)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted);
                }
                if (this.n_bCustomer_name_formartted)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted);
                }
                if (this.n_bAutopay)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.autopay);
                }
                if (this.n_bField3)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.field3);
                }
                if (this.n_bAddr_4)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.addr_4);
                }
                if (this.n_bProgram)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.program);
                }
                if (this.n_bProp_plan)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.prop_plan);
                }
                if (this.n_bCustomer_group)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.customer_group);
                }
                if (this.n_bCustomer_code)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.customer_code);
                }
                if (this.n_bTelemarketing_suppress_flag)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag);
                }
                if (this.n_bIdd_flg)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.idd_flg);
                }
                if (this.n_bActive)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.active);
                }
                if (this.n_bDdate)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.ddate);
                }
                if (this.n_bId)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.id);
                }
                if (this.n_bPlan_fee)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.plan_fee);
                }
                if (this.n_bRate_plan)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.rate_plan);
                }
                if (this.n_bSegment)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.segment);
                }
                if (this.n_bId1)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.id1);
                }
                if (this.n_bPassword)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.password);
                }
                if (this.n_bPayment_method)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.payment_method);
                }
                if (this.n_bContract_id)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.contract_id);
                }
                if (this.n_bField2)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.field2);
                }
                if (this.n_bMobile_no)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.mobile_no);
                }
                if (this.n_bPeriod)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.period);
                }
                if (this.n_bVas_desc)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.vas_desc);
                }
                if (this.n_bCdate)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.cdate);
                }
                if (this.n_bSubscriber_tier)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier);
                }
                if (this.n_bCustomer_id)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.customer_id);
                }
                if (this.n_bHandset_rebate_end_date)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date);
                }
                if (this.n_bPlan_free_inter_min)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min);
                }
                if (this.n_bCid)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.cid);
                }
                if (this.n_bDid)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.did);
                }
                if (this.n_bExpired_month)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.expired_month);
                }
                if (this.n_bPlan_free_intra_min)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min);
                }
                if (this.n_bOriginal_telemarketing_suppress_flag)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag);
                }
                if (this.n_bContact_number)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.contact_number);
                }
                if (this.n_bTradefield)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.tradefield);
                }
                if (this.n_bAddr_1)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.addr_1);
                }
                if (this.n_bMax_contract_end_date)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date);
                }
                if (this.n_bMnp_rebate_end_date)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date);
                }
                if (this.n_bProgram_id)
                {
                    if (!"".Equals(_sFR.ToString())) { _sFR.Append(","); }
                    _sFR.Append(Crm_rpt_2G_action_rpt_GL.Para.program_id);
                }
                return _sFR.ToString();
            }
        }
        #endregion
        #region Constructor
        
        public Crm_rpt_2G_action_rpt_GLDalDAO(){
        }
        ~Crm_rpt_2G_action_rpt_GLDalDAO(){
            this.Release();
        }
        #endregion
        
        #region Search Engine
        public static SqlDataReader DrSearchCrm_rpt_2G_action_rpt_GL(List<SearchItem> x_oSearchItems,long x_lStart,long x_lLimit, string x_sFieldsToReturn,string x_sSortByField,bool x_bAscDirection) 
        {
            SearchUtils _oSearchUtils = new SearchUtils();
            _oSearchUtils.SetSearchItems(x_oSearchItems);
            _oSearchUtils.SetStart(x_lStart);
            _oSearchUtils.SetLimit(x_lLimit);
            _oSearchUtils.SetFieldsToReturn(x_sFieldsToReturn);
            _oSearchUtils.SetOrderByField(x_sSortByField);
            _oSearchUtils.SetAscDirection(x_bAscDirection);
            _oSearchUtils.SetTable(Crm_rpt_2G_action_rpt_GL.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<Crm_rpt_2G_action_rpt_GL> SearchCrm_rpt_2G_action_rpt_GLList(List<SearchItem> x_oSearchItems,long x_lStart,long x_lLimit, Crm_rpt_2G_action_rpt_GLRS x_oFieldsToReturn,Crm_rpt_2G_action_rpt_GLRS x_oSortByField,bool x_bAscDirection)
        {
            SqlDataReader _oDATA = DrSearchCrm_rpt_2G_action_rpt_GL(x_oSearchItems, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<Crm_rpt_2G_action_rpt_GL> _oCrm_rpt_2G_action_rpt_GLList = new List<Crm_rpt_2G_action_rpt_GL>();
                
                while (_oDATA.Read())
                {
                    Crm_rpt_2G_action_rpt_GL _oCrm_rpt_2G_action_rpt_GL = new Crm_rpt_2G_action_rpt_GL();
                    if ((true).Equals(x_oFieldsToReturn.n_bAls_flg))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.als_flg])) { _oCrm_rpt_2G_action_rpt_GL.SetAls_flg((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.als_flg]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAls_flg(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEnd_date))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.end_date])) { _oCrm_rpt_2G_action_rpt_GL.SetEnd_date((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.end_date]); } else { _oCrm_rpt_2G_action_rpt_GL.SetEnd_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemarks))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.remarks])) { _oCrm_rpt_2G_action_rpt_GL.SetRemarks((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.remarks]); } else { _oCrm_rpt_2G_action_rpt_GL.SetRemarks(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAirtime_hs_model))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model])) { _oCrm_rpt_2G_action_rpt_GL.SetAirtime_hs_model((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAirtime_hs_model(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStart_date))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.start_date])) { _oCrm_rpt_2G_action_rpt_GL.SetStart_date((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.start_date]); } else { _oCrm_rpt_2G_action_rpt_GL.SetStart_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCalllist_name))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.calllist_name])) { _oCrm_rpt_2G_action_rpt_GL.SetCalllist_name((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.calllist_name]); } else { _oCrm_rpt_2G_action_rpt_GL.SetCalllist_name(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bJoin_date))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.join_date])) { _oCrm_rpt_2G_action_rpt_GL.SetJoin_date((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.join_date]); } else { _oCrm_rpt_2G_action_rpt_GL.SetJoin_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField1))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.field1])) { _oCrm_rpt_2G_action_rpt_GL.SetField1((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.field1]); } else { _oCrm_rpt_2G_action_rpt_GL.SetField1(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bBill_cycle))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.bill_cycle])) { _oCrm_rpt_2G_action_rpt_GL.SetBill_cycle((System.Nullable<int>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.bill_cycle]); } else { _oCrm_rpt_2G_action_rpt_GL.SetBill_cycle(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAddr_3))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_3])) { _oCrm_rpt_2G_action_rpt_GL.SetAddr_3((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_3]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAddr_3(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAddr_2))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_2])) { _oCrm_rpt_2G_action_rpt_GL.SetAddr_2((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_2]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAddr_2(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId_number))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.id_number])) { _oCrm_rpt_2G_action_rpt_GL.SetId_number((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.id_number]); } else { _oCrm_rpt_2G_action_rpt_GL.SetId_number(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAttention_name_formartted))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted])) { _oCrm_rpt_2G_action_rpt_GL.SetAttention_name_formartted((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAttention_name_formartted(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCustomer_name_formartted))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted])) { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_name_formartted((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted]); } else { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_name_formartted(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAutopay))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.autopay])) { _oCrm_rpt_2G_action_rpt_GL.SetAutopay((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.autopay]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAutopay(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField3))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.field3])) { _oCrm_rpt_2G_action_rpt_GL.SetField3((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.field3]); } else { _oCrm_rpt_2G_action_rpt_GL.SetField3(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAddr_4))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_4])) { _oCrm_rpt_2G_action_rpt_GL.SetAddr_4((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_4]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAddr_4(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.program])) { _oCrm_rpt_2G_action_rpt_GL.SetProgram((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.program]); } else { _oCrm_rpt_2G_action_rpt_GL.SetProgram(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProp_plan))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.prop_plan])) { _oCrm_rpt_2G_action_rpt_GL.SetProp_plan((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.prop_plan]); } else { _oCrm_rpt_2G_action_rpt_GL.SetProp_plan(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCustomer_group))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_group])) { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_group((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_group]); } else { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_group(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCustomer_code))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_code])) { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_code((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_code]); } else { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_code(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTelemarketing_suppress_flag))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag])) { _oCrm_rpt_2G_action_rpt_GL.SetTelemarketing_suppress_flag((System.Nullable<bool>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag]); } else { _oCrm_rpt_2G_action_rpt_GL.SetTelemarketing_suppress_flag(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIdd_flg))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.idd_flg])) { _oCrm_rpt_2G_action_rpt_GL.SetIdd_flg((System.Nullable<bool>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.idd_flg]); } else { _oCrm_rpt_2G_action_rpt_GL.SetIdd_flg(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.active])) { _oCrm_rpt_2G_action_rpt_GL.SetActive((System.Nullable<bool>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.active]); } else { _oCrm_rpt_2G_action_rpt_GL.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.ddate])) { _oCrm_rpt_2G_action_rpt_GL.SetDdate((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.ddate]); } else { _oCrm_rpt_2G_action_rpt_GL.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.id])) { _oCrm_rpt_2G_action_rpt_GL.SetId((System.Nullable<int>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.id]); } else { _oCrm_rpt_2G_action_rpt_GL.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_fee))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.plan_fee])) { _oCrm_rpt_2G_action_rpt_GL.SetPlan_fee((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.plan_fee]); } else { _oCrm_rpt_2G_action_rpt_GL.SetPlan_fee(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRate_plan))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.rate_plan])) { _oCrm_rpt_2G_action_rpt_GL.SetRate_plan((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.rate_plan]); } else { _oCrm_rpt_2G_action_rpt_GL.SetRate_plan(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSegment))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.segment])) { _oCrm_rpt_2G_action_rpt_GL.SetSegment((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.segment]); } else { _oCrm_rpt_2G_action_rpt_GL.SetSegment(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId1))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.id1])) { _oCrm_rpt_2G_action_rpt_GL.SetId1((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.id1]); } else { _oCrm_rpt_2G_action_rpt_GL.SetId1(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPassword))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.password])) { _oCrm_rpt_2G_action_rpt_GL.SetPassword((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.password]); } else { _oCrm_rpt_2G_action_rpt_GL.SetPassword(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPayment_method))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.payment_method])) { _oCrm_rpt_2G_action_rpt_GL.SetPayment_method((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.payment_method]); } else { _oCrm_rpt_2G_action_rpt_GL.SetPayment_method(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bContract_id))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.contract_id])) { _oCrm_rpt_2G_action_rpt_GL.SetContract_id((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.contract_id]); } else { _oCrm_rpt_2G_action_rpt_GL.SetContract_id(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField2))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.field2])) { _oCrm_rpt_2G_action_rpt_GL.SetField2((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.field2]); } else { _oCrm_rpt_2G_action_rpt_GL.SetField2(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMobile_no))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.mobile_no])) { _oCrm_rpt_2G_action_rpt_GL.SetMobile_no((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.mobile_no]); } else { _oCrm_rpt_2G_action_rpt_GL.SetMobile_no(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPeriod))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.period])) { _oCrm_rpt_2G_action_rpt_GL.SetPeriod((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.period]); } else { _oCrm_rpt_2G_action_rpt_GL.SetPeriod(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_desc))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.vas_desc])) { _oCrm_rpt_2G_action_rpt_GL.SetVas_desc((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.vas_desc]); } else { _oCrm_rpt_2G_action_rpt_GL.SetVas_desc(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.cdate])) { _oCrm_rpt_2G_action_rpt_GL.SetCdate((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.cdate]); } else { _oCrm_rpt_2G_action_rpt_GL.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSubscriber_tier))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier])) { _oCrm_rpt_2G_action_rpt_GL.SetSubscriber_tier((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier]); } else { _oCrm_rpt_2G_action_rpt_GL.SetSubscriber_tier(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCustomer_id))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_id])) { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_id((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.customer_id]); } else { _oCrm_rpt_2G_action_rpt_GL.SetCustomer_id(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHandset_rebate_end_date))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date])) { _oCrm_rpt_2G_action_rpt_GL.SetHandset_rebate_end_date((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date]); } else { _oCrm_rpt_2G_action_rpt_GL.SetHandset_rebate_end_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_free_inter_min))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min])) { _oCrm_rpt_2G_action_rpt_GL.SetPlan_free_inter_min((System.Nullable<int>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min]); } else { _oCrm_rpt_2G_action_rpt_GL.SetPlan_free_inter_min(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.cid])) { _oCrm_rpt_2G_action_rpt_GL.SetCid((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.cid]); } else { _oCrm_rpt_2G_action_rpt_GL.SetCid(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.did])) { _oCrm_rpt_2G_action_rpt_GL.SetDid((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.did]); } else { _oCrm_rpt_2G_action_rpt_GL.SetDid(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExpired_month))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.expired_month])) { _oCrm_rpt_2G_action_rpt_GL.SetExpired_month((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.expired_month]); } else { _oCrm_rpt_2G_action_rpt_GL.SetExpired_month(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPlan_free_intra_min))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min])) { _oCrm_rpt_2G_action_rpt_GL.SetPlan_free_intra_min((System.Nullable<int>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min]); } else { _oCrm_rpt_2G_action_rpt_GL.SetPlan_free_intra_min(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOriginal_telemarketing_suppress_flag))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag])) { _oCrm_rpt_2G_action_rpt_GL.SetOriginal_telemarketing_suppress_flag((System.Nullable<bool>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag]); } else { _oCrm_rpt_2G_action_rpt_GL.SetOriginal_telemarketing_suppress_flag(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bContact_number))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.contact_number])) { _oCrm_rpt_2G_action_rpt_GL.SetContact_number((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.contact_number]); } else { _oCrm_rpt_2G_action_rpt_GL.SetContact_number(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTradefield))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.tradefield])) { _oCrm_rpt_2G_action_rpt_GL.SetTradefield((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.tradefield]); } else { _oCrm_rpt_2G_action_rpt_GL.SetTradefield(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAddr_1))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_1])) { _oCrm_rpt_2G_action_rpt_GL.SetAddr_1((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.addr_1]); } else { _oCrm_rpt_2G_action_rpt_GL.SetAddr_1(string.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMax_contract_end_date))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date])) { _oCrm_rpt_2G_action_rpt_GL.SetMax_contract_end_date((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date]); } else { _oCrm_rpt_2G_action_rpt_GL.SetMax_contract_end_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMnp_rebate_end_date))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date])) { _oCrm_rpt_2G_action_rpt_GL.SetMnp_rebate_end_date((System.Nullable<DateTime>)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date]); } else { _oCrm_rpt_2G_action_rpt_GL.SetMnp_rebate_end_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bProgram_id))
                    {
                        if (!Convert.IsDBNull(_oDATA[Crm_rpt_2G_action_rpt_GL.Para.program_id])) { _oCrm_rpt_2G_action_rpt_GL.SetProgram_id((string)_oDATA[Crm_rpt_2G_action_rpt_GL.Para.program_id]); } else { _oCrm_rpt_2G_action_rpt_GL.SetProgram_id(string.Empty); }
                    }
                    _oCrm_rpt_2G_action_rpt_GLList.Add(_oCrm_rpt_2G_action_rpt_GL);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oCrm_rpt_2G_action_rpt_GLList;
            }
            return new List<Crm_rpt_2G_action_rpt_GL>();
        }
        #endregion
        
        #region Linq OrderBy
        public static global::System.Linq.IQueryable<Crm_rpt_2G_action_rpt_GLEntity> OrderBy(string x_sSort, IQueryable<Crm_rpt_2G_action_rpt_GLEntity> x_oCrm_rpt_2G_action_rpt_GLBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case "als_flg":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.als_flg).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.als_flg).Select(c => c);
                break;
                case "end_date":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.end_date).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.end_date).Select(c => c);
                break;
                case "remarks":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.remarks).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.remarks).Select(c => c);
                break;
                case "airtime_hs_model":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.airtime_hs_model).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.airtime_hs_model).Select(c => c);
                break;
                case "start_date":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.start_date).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.start_date).Select(c => c);
                break;
                case "calllist_name":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.calllist_name).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.calllist_name).Select(c => c);
                break;
                case "join_date":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.join_date).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.join_date).Select(c => c);
                break;
                case "field1":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.field1).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.field1).Select(c => c);
                break;
                case "bill_cycle":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.bill_cycle).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.bill_cycle).Select(c => c);
                break;
                case "addr_3":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.addr_3).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.addr_3).Select(c => c);
                break;
                case "addr_2":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.addr_2).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.addr_2).Select(c => c);
                break;
                case "id_number":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.id_number).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.id_number).Select(c => c);
                break;
                case "attention_name_formartted":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.attention_name_formartted).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.attention_name_formartted).Select(c => c);
                break;
                case "customer_name_formartted":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.customer_name_formartted).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.customer_name_formartted).Select(c => c);
                break;
                case "autopay":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.autopay).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.autopay).Select(c => c);
                break;
                case "field3":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.field3).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.field3).Select(c => c);
                break;
                case "addr_4":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.addr_4).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.addr_4).Select(c => c);
                break;
                case "program":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.program).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.program).Select(c => c);
                break;
                case "prop_plan":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.prop_plan).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.prop_plan).Select(c => c);
                break;
                case "customer_group":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.customer_group).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.customer_group).Select(c => c);
                break;
                case "customer_code":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.customer_code).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.customer_code).Select(c => c);
                break;
                case "telemarketing_suppress_flag":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.telemarketing_suppress_flag).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.telemarketing_suppress_flag).Select(c => c);
                break;
                case "idd_flg":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.idd_flg).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.idd_flg).Select(c => c);
                break;
                case "active":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case "ddate":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case "id":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case "plan_fee":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.plan_fee).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.plan_fee).Select(c => c);
                break;
                case "rate_plan":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.rate_plan).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.rate_plan).Select(c => c);
                break;
                case "segment":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.segment).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.segment).Select(c => c);
                break;
                case "id1":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.id1).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.id1).Select(c => c);
                break;
                case "password":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.password).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.password).Select(c => c);
                break;
                case "payment_method":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.payment_method).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.payment_method).Select(c => c);
                break;
                case "contract_id":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.contract_id).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.contract_id).Select(c => c);
                break;
                case "field2":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.field2).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.field2).Select(c => c);
                break;
                case "mobile_no":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.mobile_no).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.mobile_no).Select(c => c);
                break;
                case "period":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.period).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.period).Select(c => c);
                break;
                case "vas_desc":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.vas_desc).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.vas_desc).Select(c => c);
                break;
                case "cdate":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case "subscriber_tier":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.subscriber_tier).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.subscriber_tier).Select(c => c);
                break;
                case "customer_id":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.customer_id).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.customer_id).Select(c => c);
                break;
                case "handset_rebate_end_date":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.handset_rebate_end_date).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.handset_rebate_end_date).Select(c => c);
                break;
                case "plan_free_inter_min":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.plan_free_inter_min).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.plan_free_inter_min).Select(c => c);
                break;
                case "cid":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case "did":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case "expired_month":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.expired_month).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.expired_month).Select(c => c);
                break;
                case "plan_free_intra_min":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.plan_free_intra_min).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.plan_free_intra_min).Select(c => c);
                break;
                case "original_telemarketing_suppress_flag":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.original_telemarketing_suppress_flag).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.original_telemarketing_suppress_flag).Select(c => c);
                break;
                case "contact_number":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.contact_number).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.contact_number).Select(c => c);
                break;
                case "tradefield":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.tradefield).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.tradefield).Select(c => c);
                break;
                case "addr_1":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.addr_1).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.addr_1).Select(c => c);
                break;
                case "max_contract_end_date":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.max_contract_end_date).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.max_contract_end_date).Select(c => c);
                break;
                case "mnp_rebate_end_date":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.mnp_rebate_end_date).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.mnp_rebate_end_date).Select(c => c);
                break;
                case "program_id":
                if(x_bAsc)
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderBy(c => c.program_id).Select(c => c);
                else
                    x_oCrm_rpt_2G_action_rpt_GLBaseList = x_oCrm_rpt_2G_action_rpt_GLBaseList.OrderByDescending(c => c.program_id).Select(c => c);
                break;
            }
            return x_oCrm_rpt_2G_action_rpt_GLBaseList;
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.CRM + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


