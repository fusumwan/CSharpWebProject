using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
///-- Create date: <Create Date 2009-07-13>
///-- Description:	<Description,Table :[crm_rpt_2G_action_rpt_GL],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [crm_rpt_2G_action_rpt_GL] Business layer
    /// </summary>
    
    public abstract class Crm_rpt_2G_action_rpt_GLBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public Crm_rpt_2G_action_rpt_GLBalBase(){
        }
        ~Crm_rpt_2G_action_rpt_GLBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static DataSet ToDataSet(Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            return GetDataSet(x_oCrm_rpt_2G_action_rpt_GL,null);
        }
        
        
        public static DataSet ToDataSet(Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL,DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oCrm_rpt_2G_action_rpt_GL,x_oMergeDSet);
        }
        
        
        protected static DataSet GetDataSet(Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL,DataSet x_oMergeDSet)
        {
            Crm_rpt_2G_action_rpt_GLInfo _oTableSet=new Crm_rpt_2G_action_rpt_GLInfo();
            DataSet _oDSet = new DataSet();
            _oDSet.Tables.Add(Crm_rpt_2G_action_rpt_GL.Para.TableName());
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("als_flg"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("remarks"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("airtime_hs_model"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("start_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("calllist_name"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("join_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("field1"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("bill_cycle"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_3"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_2"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("id_number"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("attention_name_formartted"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_name_formartted"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("autopay"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("field3"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_4"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("program"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("prop_plan"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_group"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_code"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("telemarketing_suppress_flag"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("idd_flg"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("active"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("ddate"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("id"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("plan_fee"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("rate_plan"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("segment"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("id1"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("password"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("payment_method"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("contract_id"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("field2"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("mobile_no"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("period"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("vas_desc"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("cdate"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("subscriber_tier"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_id"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("handset_rebate_end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("plan_free_inter_min"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("cid"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("did"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("expired_month"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("plan_free_intra_min"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("original_telemarketing_suppress_flag"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("contact_number"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("tradefield"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_1"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("max_contract_end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("mnp_rebate_end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("program_id"); }
            DataRow _oDRow = _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].NewRow();
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.als_flg] = x_oCrm_rpt_2G_action_rpt_GL.GetAls_flg(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetEnd_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.remarks] = x_oCrm_rpt_2G_action_rpt_GL.GetRemarks(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model] = x_oCrm_rpt_2G_action_rpt_GL.GetAirtime_hs_model(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.start_date] = x_oCrm_rpt_2G_action_rpt_GL.GetStart_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.calllist_name] = x_oCrm_rpt_2G_action_rpt_GL.GetCalllist_name(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.join_date] = x_oCrm_rpt_2G_action_rpt_GL.GetJoin_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.field1] = x_oCrm_rpt_2G_action_rpt_GL.GetField1(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.bill_cycle] = x_oCrm_rpt_2G_action_rpt_GL.GetBill_cycle(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_3] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_3(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_2] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_2(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.id_number] = x_oCrm_rpt_2G_action_rpt_GL.GetId_number(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted] = x_oCrm_rpt_2G_action_rpt_GL.GetAttention_name_formartted(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_name_formartted(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.autopay] = x_oCrm_rpt_2G_action_rpt_GL.GetAutopay(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.field3] = x_oCrm_rpt_2G_action_rpt_GL.GetField3(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_4] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_4(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.program] = x_oCrm_rpt_2G_action_rpt_GL.GetProgram(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.prop_plan] = x_oCrm_rpt_2G_action_rpt_GL.GetProp_plan(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_group] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_group(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_code] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_code(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag] = x_oCrm_rpt_2G_action_rpt_GL.GetTelemarketing_suppress_flag(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.idd_flg] = x_oCrm_rpt_2G_action_rpt_GL.GetIdd_flg(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.active] = x_oCrm_rpt_2G_action_rpt_GL.GetActive(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.ddate] = x_oCrm_rpt_2G_action_rpt_GL.GetDdate(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.id] = x_oCrm_rpt_2G_action_rpt_GL.GetId(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.plan_fee] = x_oCrm_rpt_2G_action_rpt_GL.GetPlan_fee(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.rate_plan] = x_oCrm_rpt_2G_action_rpt_GL.GetRate_plan(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.segment] = x_oCrm_rpt_2G_action_rpt_GL.GetSegment(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.id1] = x_oCrm_rpt_2G_action_rpt_GL.GetId1(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.password] = x_oCrm_rpt_2G_action_rpt_GL.GetPassword(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.payment_method] = x_oCrm_rpt_2G_action_rpt_GL.GetPayment_method(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.contract_id] = x_oCrm_rpt_2G_action_rpt_GL.GetContract_id(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.field2] = x_oCrm_rpt_2G_action_rpt_GL.GetField2(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.mobile_no] = x_oCrm_rpt_2G_action_rpt_GL.GetMobile_no(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.period] = x_oCrm_rpt_2G_action_rpt_GL.GetPeriod(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.vas_desc] = x_oCrm_rpt_2G_action_rpt_GL.GetVas_desc(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.cdate] = x_oCrm_rpt_2G_action_rpt_GL.GetCdate(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier] = x_oCrm_rpt_2G_action_rpt_GL.GetSubscriber_tier(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_id] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_id(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetHandset_rebate_end_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min] = x_oCrm_rpt_2G_action_rpt_GL.GetPlan_free_inter_min(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.cid] = x_oCrm_rpt_2G_action_rpt_GL.GetCid(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.did] = x_oCrm_rpt_2G_action_rpt_GL.GetDid(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.expired_month] = x_oCrm_rpt_2G_action_rpt_GL.GetExpired_month(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min] = x_oCrm_rpt_2G_action_rpt_GL.GetPlan_free_intra_min(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag] = x_oCrm_rpt_2G_action_rpt_GL.GetOriginal_telemarketing_suppress_flag(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.contact_number] = x_oCrm_rpt_2G_action_rpt_GL.GetContact_number(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.tradefield] = x_oCrm_rpt_2G_action_rpt_GL.GetTradefield(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_1] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_1(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetMax_contract_end_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetMnp_rebate_end_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.program_id] = x_oCrm_rpt_2G_action_rpt_GL.GetProgram_id(); }
            _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Rows.Add(_oDRow);
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        public DataSet ToEmptyDataSet()
        {
            Crm_rpt_2G_action_rpt_GLInfo _oTableSet=new Crm_rpt_2G_action_rpt_GLInfo();
            DataSet _oDSet = new DataSet();
            _oDSet.Tables.Add(Crm_rpt_2G_action_rpt_GL.Para.TableName());
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("als_flg"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("remarks"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("airtime_hs_model"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("start_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("calllist_name"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("join_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("field1"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("bill_cycle"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_3"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_2"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("id_number"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("attention_name_formartted"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_name_formartted"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("autopay"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("field3"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_4"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("program"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("prop_plan"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_group"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_code"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("telemarketing_suppress_flag"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("idd_flg"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("active"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("ddate"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("id"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("plan_fee"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("rate_plan"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("segment"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("id1"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("password"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("payment_method"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("contract_id"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("field2"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("mobile_no"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("period"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("vas_desc"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("cdate"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("subscriber_tier"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("customer_id"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("handset_rebate_end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("plan_free_inter_min"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("cid"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("did"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("expired_month"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("plan_free_intra_min"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("original_telemarketing_suppress_flag"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("contact_number"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("tradefield"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("addr_1"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("max_contract_end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("mnp_rebate_end_date"); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[Crm_rpt_2G_action_rpt_GL.Para.TableName()].Columns.Add("program_id"); }
            return _oDSet;
        }
        
        
        #endregion ToDataSet
        
        #region Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        
        public static DataTable Table(Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            DataTable n_oTbl = new DataTable();
            Crm_rpt_2G_action_rpt_GLInfo _oTableSet=new Crm_rpt_2G_action_rpt_GLInfo();
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).AliasName);}
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).AliasName);}
            DataRow _oDRow = n_oTbl.NewRow();
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.als_flg] = x_oCrm_rpt_2G_action_rpt_GL.GetAls_flg(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetEnd_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.remarks] = x_oCrm_rpt_2G_action_rpt_GL.GetRemarks(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model] = x_oCrm_rpt_2G_action_rpt_GL.GetAirtime_hs_model(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.start_date] = x_oCrm_rpt_2G_action_rpt_GL.GetStart_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.calllist_name] = x_oCrm_rpt_2G_action_rpt_GL.GetCalllist_name(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.join_date] = x_oCrm_rpt_2G_action_rpt_GL.GetJoin_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.field1] = x_oCrm_rpt_2G_action_rpt_GL.GetField1(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.bill_cycle] = x_oCrm_rpt_2G_action_rpt_GL.GetBill_cycle(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_3] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_3(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_2] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_2(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.id_number] = x_oCrm_rpt_2G_action_rpt_GL.GetId_number(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted] = x_oCrm_rpt_2G_action_rpt_GL.GetAttention_name_formartted(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_name_formartted(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.autopay] = x_oCrm_rpt_2G_action_rpt_GL.GetAutopay(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.field3] = x_oCrm_rpt_2G_action_rpt_GL.GetField3(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_4] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_4(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.program] = x_oCrm_rpt_2G_action_rpt_GL.GetProgram(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.prop_plan] = x_oCrm_rpt_2G_action_rpt_GL.GetProp_plan(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_group] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_group(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_code] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_code(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag] = x_oCrm_rpt_2G_action_rpt_GL.GetTelemarketing_suppress_flag(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.idd_flg] = x_oCrm_rpt_2G_action_rpt_GL.GetIdd_flg(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.active] = x_oCrm_rpt_2G_action_rpt_GL.GetActive(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.ddate] = x_oCrm_rpt_2G_action_rpt_GL.GetDdate(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.id] = x_oCrm_rpt_2G_action_rpt_GL.GetId(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.plan_fee] = x_oCrm_rpt_2G_action_rpt_GL.GetPlan_fee(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.rate_plan] = x_oCrm_rpt_2G_action_rpt_GL.GetRate_plan(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.segment] = x_oCrm_rpt_2G_action_rpt_GL.GetSegment(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.id1] = x_oCrm_rpt_2G_action_rpt_GL.GetId1(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.password] = x_oCrm_rpt_2G_action_rpt_GL.GetPassword(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.payment_method] = x_oCrm_rpt_2G_action_rpt_GL.GetPayment_method(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.contract_id] = x_oCrm_rpt_2G_action_rpt_GL.GetContract_id(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.field2] = x_oCrm_rpt_2G_action_rpt_GL.GetField2(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.mobile_no] = x_oCrm_rpt_2G_action_rpt_GL.GetMobile_no(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.period] = x_oCrm_rpt_2G_action_rpt_GL.GetPeriod(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.vas_desc] = x_oCrm_rpt_2G_action_rpt_GL.GetVas_desc(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.cdate] = x_oCrm_rpt_2G_action_rpt_GL.GetCdate(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier] = x_oCrm_rpt_2G_action_rpt_GL.GetSubscriber_tier(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.customer_id] = x_oCrm_rpt_2G_action_rpt_GL.GetCustomer_id(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetHandset_rebate_end_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min] = x_oCrm_rpt_2G_action_rpt_GL.GetPlan_free_inter_min(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.cid] = x_oCrm_rpt_2G_action_rpt_GL.GetCid(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.did] = x_oCrm_rpt_2G_action_rpt_GL.GetDid(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.expired_month] = x_oCrm_rpt_2G_action_rpt_GL.GetExpired_month(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min] = x_oCrm_rpt_2G_action_rpt_GL.GetPlan_free_intra_min(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag] = x_oCrm_rpt_2G_action_rpt_GL.GetOriginal_telemarketing_suppress_flag(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.contact_number] = x_oCrm_rpt_2G_action_rpt_GL.GetContact_number(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.tradefield] = x_oCrm_rpt_2G_action_rpt_GL.GetTradefield(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.addr_1] = x_oCrm_rpt_2G_action_rpt_GL.GetAddr_1(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetMax_contract_end_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date] = x_oCrm_rpt_2G_action_rpt_GL.GetMnp_rebate_end_date(); }
            if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).IsView || _oTableSet.GetViewAll()) { _oDRow[Crm_rpt_2G_action_rpt_GL.Para.program_id] = x_oCrm_rpt_2G_action_rpt_GL.GetProgram_id(); }
            n_oTbl.Rows.Add(_oDRow);
            return n_oTbl;
        }
        #endregion
        
        
        #region Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            Crm_rpt_2G_action_rpt_GLInfo _oTableSet=new Crm_rpt_2G_action_rpt_GLInfo();
            using(SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT [crm_rpt_2G_action_rpt_GL].[telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[end_date] AS CRM_RPT_2G_ACTION_RPT_GL_END_DATE,[crm_rpt_2G_action_rpt_GL].[ddate] AS CRM_RPT_2G_ACTION_RPT_GL_DDATE,[crm_rpt_2G_action_rpt_GL].[airtime_hs_model] AS CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL,[crm_rpt_2G_action_rpt_GL].[tradefield] AS CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD,[crm_rpt_2G_action_rpt_GL].[calllist_name] AS CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME,[crm_rpt_2G_action_rpt_GL].[field1] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD1,[crm_rpt_2G_action_rpt_GL].[remarks] AS CRM_RPT_2G_ACTION_RPT_GL_REMARKS,[crm_rpt_2G_action_rpt_GL].[bill_cycle] AS CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE,[crm_rpt_2G_action_rpt_GL].[addr_2] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_2,[crm_rpt_2G_action_rpt_GL].[id_number] AS CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER,[crm_rpt_2G_action_rpt_GL].[attention_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[customer_name_formartted] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED,[crm_rpt_2G_action_rpt_GL].[mnp_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[field3] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD3,[crm_rpt_2G_action_rpt_GL].[addr_4] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_4,[crm_rpt_2G_action_rpt_GL].[program] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM,[crm_rpt_2G_action_rpt_GL].[prop_plan] AS CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN,[crm_rpt_2G_action_rpt_GL].[expired_month] AS CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH,[crm_rpt_2G_action_rpt_GL].[customer_group] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP,[crm_rpt_2G_action_rpt_GL].[join_date] AS CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE,[crm_rpt_2G_action_rpt_GL].[idd_flg] AS CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG,[crm_rpt_2G_action_rpt_GL].[active] AS CRM_RPT_2G_ACTION_RPT_GL_ACTIVE,[crm_rpt_2G_action_rpt_GL].[period] AS CRM_RPT_2G_ACTION_RPT_GL_PERIOD,[crm_rpt_2G_action_rpt_GL].[field2] AS CRM_RPT_2G_ACTION_RPT_GL_FIELD2,[crm_rpt_2G_action_rpt_GL].[start_date] AS CRM_RPT_2G_ACTION_RPT_GL_START_DATE,[crm_rpt_2G_action_rpt_GL].[plan_fee] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE,[crm_rpt_2G_action_rpt_GL].[rate_plan] AS CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN,[crm_rpt_2G_action_rpt_GL].[segment] AS CRM_RPT_2G_ACTION_RPT_GL_SEGMENT,[crm_rpt_2G_action_rpt_GL].[cdate] AS CRM_RPT_2G_ACTION_RPT_GL_CDATE,[crm_rpt_2G_action_rpt_GL].[program_id] AS CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID,[crm_rpt_2G_action_rpt_GL].[password] AS CRM_RPT_2G_ACTION_RPT_GL_PASSWORD,[crm_rpt_2G_action_rpt_GL].[payment_method] AS CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD,[crm_rpt_2G_action_rpt_GL].[contract_id] AS CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID,[crm_rpt_2G_action_rpt_GL].[customer_code] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE,[crm_rpt_2G_action_rpt_GL].[mobile_no] AS CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO,[crm_rpt_2G_action_rpt_GL].[als_flg] AS CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG,[crm_rpt_2G_action_rpt_GL].[vas_desc] AS CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC,[crm_rpt_2G_action_rpt_GL].[addr_3] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_3,[crm_rpt_2G_action_rpt_GL].[subscriber_tier] AS CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER,[crm_rpt_2G_action_rpt_GL].[customer_id] AS CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID,[crm_rpt_2G_action_rpt_GL].[handset_rebate_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE,[crm_rpt_2G_action_rpt_GL].[plan_free_inter_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN,[crm_rpt_2G_action_rpt_GL].[cid] AS CRM_RPT_2G_ACTION_RPT_GL_CID,[crm_rpt_2G_action_rpt_GL].[did] AS CRM_RPT_2G_ACTION_RPT_GL_DID,[crm_rpt_2G_action_rpt_GL].[id] AS CRM_RPT_2G_ACTION_RPT_GL_ID,[crm_rpt_2G_action_rpt_GL].[plan_free_intra_min] AS CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN,[crm_rpt_2G_action_rpt_GL].[original_telemarketing_suppress_flag] AS CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG,[crm_rpt_2G_action_rpt_GL].[contact_number] AS CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER,[crm_rpt_2G_action_rpt_GL].[addr_1] AS CRM_RPT_2G_ACTION_RPT_GL_ADDR_1,[crm_rpt_2G_action_rpt_GL].[max_contract_end_date] AS CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE,[crm_rpt_2G_action_rpt_GL].[id1] AS CRM_RPT_2G_ACTION_RPT_GL_ID1,[crm_rpt_2G_action_rpt_GL].[autopay] AS CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY  FROM  [crm_rpt_2G_action_rpt_GL]  WHERE  [crm_rpt_2G_action_rpt_GL].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[crm_rpt_2G_action_rpt_GL]","["+ Configurator.MSSQLTablePrefix + "crm_rpt_2G_action_rpt_GL]"); }
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                SqlDataReader _oData;
                DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).AliasName].ToString()] = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_TELEMARKETING_SUPPRESS_FLAG"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_END_DATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_DDATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AIRTIME_HS_MODEL"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_TRADEFIELD"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CALLLIST_NAME"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD1"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_REMARKS"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).AliasName].ToString()] = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_BILL_CYCLE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_2"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID_NUMBER"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ATTENTION_NAME_FORMARTTED"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_NAME_FORMARTTED"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MNP_REBATE_END_DATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD3"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_4"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROP_PLAN"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_EXPIRED_MONTH"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_GROUP"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_JOIN_DATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).AliasName].ToString()] = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_IDD_FLG"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).AliasName].ToString()] = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PERIOD"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_FIELD2"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_START_DATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FEE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_RATE_PLAN"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SEGMENT"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_CDATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PROGRAM_ID"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PASSWORD"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_PAYMENT_METHOD"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTRACT_ID"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_CODE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_MOBILE_NO"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ALS_FLG"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_VAS_DESC"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_3"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_SUBSCRIBER_TIER"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CUSTOMER_ID"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_HANDSET_REBATE_END_DATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).AliasName].ToString()] = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTER_MIN"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CID"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_DID"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).AliasName].ToString()] = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).AliasName].ToString()] = (System.Nullable<int>)_oData["CRM_RPT_2G_ACTION_RPT_GL_PLAN_FREE_INTRA_MIN"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).AliasName].ToString()] = (System.Nullable<bool>)_oData["CRM_RPT_2G_ACTION_RPT_GL_ORIGINAL_TELEMARKETING_SUPPRESS_FLAG"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_CONTACT_NUMBER"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ADDR_1"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).AliasName].ToString()] = (System.Nullable<DateTime>)_oData["CRM_RPT_2G_ACTION_RPT_GL_MAX_CONTRACT_END_DATE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_ID1"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).IsView || _oTableSet.GetViewAll()) {
                            if (!Convert.IsDBNull(_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"]) && x_oTable.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).AliasName].ToString()] = (string)_oData["CRM_RPT_2G_ACTION_RPT_GL_AUTOPAY"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).AliasName].ToString()] =string.Empty;
                        }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch {  }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRw;
            }
        }
        #endregion
        
        
        #region SetDataSetRow
        
        
        // ******************************
        // *  Handler for Convert To DataSet Row
        // ******************************
        
        public static bool SetDataSetRow(int x_iROW, DataSet x_oDataSet,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GLRow)
        {
            return SetDataSetRowProc(x_iROW, Crm_rpt_2G_action_rpt_GL.Para.TableName(), x_oDataSet,x_oCrm_rpt_2G_action_rpt_GLRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, DataSet x_oDataSet,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GLRow)
        {
            return SetDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oCrm_rpt_2G_action_rpt_GLRow);
        }
        protected static bool SetDataSetRowProc(int x_iROW, string x_sTableName, DataSet x_oDataSet,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GLRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                Crm_rpt_2G_action_rpt_GLInfo _oTableSet=new Crm_rpt_2G_action_rpt_GLInfo();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.als_flg = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.als_flg).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.end_date = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.end_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.remarks = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.remarks).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.airtime_hs_model = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.airtime_hs_model).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.start_date = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.start_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.calllist_name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.calllist_name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.join_date = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.join_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.field1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.bill_cycle = (System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.bill_cycle).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.addr_3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.addr_2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.id_number = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id_number).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.attention_name_formartted = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.attention_name_formartted).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.customer_name_formartted = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_name_formartted).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.autopay = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.autopay).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.field3 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field3).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.addr_4 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_4).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.program = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.prop_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.prop_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.customer_group = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_group).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.customer_code = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_code).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.telemarketing_suppress_flag = (System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.telemarketing_suppress_flag).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.idd_flg = (System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.idd_flg).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.active = (System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.ddate = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.id = (System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.plan_fee = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_fee).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.rate_plan = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.rate_plan).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.segment = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.segment).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.id1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.id1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.password = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.password).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.payment_method = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.payment_method).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.contract_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contract_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.field2 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.field2).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.mobile_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mobile_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.period = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.period).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.vas_desc = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.vas_desc).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.cdate = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.subscriber_tier = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.subscriber_tier).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.customer_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.customer_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.handset_rebate_end_date = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.handset_rebate_end_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.plan_free_inter_min = (System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_inter_min).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.expired_month = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.expired_month).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.plan_free_intra_min = (System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.plan_free_intra_min).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.original_telemarketing_suppress_flag = (System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.original_telemarketing_suppress_flag).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.contact_number = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.contact_number).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.tradefield = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.tradefield).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.addr_1 = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.addr_1).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.max_contract_end_date = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.max_contract_end_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.mnp_rebate_end_date = (System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.mnp_rebate_end_date).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).AliasName))
                    x_oCrm_rpt_2G_action_rpt_GLRow.program_id = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(Crm_rpt_2G_action_rpt_GL.Para.program_id).AliasName];
                return true;
            }
            return false;
        }
        
        #endregion SetByDataSet
        
        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return Crm_rpt_2G_action_rpt_GLRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static Crm_rpt_2G_action_rpt_GLEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return Crm_rpt_2G_action_rpt_GLRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static Crm_rpt_2G_action_rpt_GLEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return Crm_rpt_2G_action_rpt_GLRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Crm_rpt_2G_action_rpt_GLRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static SqlDataReader GetDataReader(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Crm_rpt_2G_action_rpt_GLRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return Crm_rpt_2G_action_rpt_GLRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sAls_flg,System.Nullable<DateTime> x_dEnd_date,string x_sRemarks,string x_sAirtime_hs_model,System.Nullable<DateTime> x_dStart_date,string x_sCalllist_name,System.Nullable<DateTime> x_dJoin_date,string x_sField1,System.Nullable<int> x_iBill_cycle,string x_sAddr_3,string x_sAddr_2,string x_sId_number,string x_sAttention_name_formartted,string x_sCustomer_name_formartted,string x_sAutopay,string x_sField3,string x_sAddr_4,string x_sProgram,string x_sProp_plan,string x_sCustomer_group,string x_sCustomer_code,System.Nullable<bool> x_bTelemarketing_suppress_flag,System.Nullable<bool> x_bIdd_flg,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dDdate,string x_sPlan_fee,string x_sRate_plan,string x_sSegment,string x_sId1,string x_sPassword,string x_sPayment_method,string x_sContract_id,string x_sField2,string x_sMobile_no,string x_sPeriod,string x_sVas_desc,System.Nullable<DateTime> x_dCdate,string x_sSubscriber_tier,string x_sCustomer_id,System.Nullable<DateTime> x_dHandset_rebate_end_date,System.Nullable<int> x_iPlan_free_inter_min,string x_sCid,string x_sDid,string x_sExpired_month,System.Nullable<int> x_iPlan_free_intra_min,System.Nullable<bool> x_bOriginal_telemarketing_suppress_flag,string x_sContact_number,string x_sTradefield,string x_sAddr_1,System.Nullable<DateTime> x_dMax_contract_end_date,System.Nullable<DateTime> x_dMnp_rebate_end_date,string x_sProgram_id)
        {
            return Crm_rpt_2G_action_rpt_GLRepository.Insert(x_oDB, x_sAls_flg,x_dEnd_date,x_sRemarks,x_sAirtime_hs_model,x_dStart_date,x_sCalllist_name,x_dJoin_date,x_sField1,x_iBill_cycle,x_sAddr_3,x_sAddr_2,x_sId_number,x_sAttention_name_formartted,x_sCustomer_name_formartted,x_sAutopay,x_sField3,x_sAddr_4,x_sProgram,x_sProp_plan,x_sCustomer_group,x_sCustomer_code,x_bTelemarketing_suppress_flag,x_bIdd_flg,x_bActive,x_dDdate,x_sPlan_fee,x_sRate_plan,x_sSegment,x_sId1,x_sPassword,x_sPayment_method,x_sContract_id,x_sField2,x_sMobile_no,x_sPeriod,x_sVas_desc,x_dCdate,x_sSubscriber_tier,x_sCustomer_id,x_dHandset_rebate_end_date,x_iPlan_free_inter_min,x_sCid,x_sDid,x_sExpired_month,x_iPlan_free_intra_min,x_bOriginal_telemarketing_suppress_flag,x_sContact_number,x_sTradefield,x_sAddr_1,x_dMax_contract_end_date,x_dMnp_rebate_end_date,x_sProgram_id);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            return Crm_rpt_2G_action_rpt_GLRepository.InsertWithOutLastID(x_oDB,x_oCrm_rpt_2G_action_rpt_GL);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sAls_flg,System.Nullable<DateTime> x_dEnd_date,string x_sRemarks,string x_sAirtime_hs_model,System.Nullable<DateTime> x_dStart_date,string x_sCalllist_name,System.Nullable<DateTime> x_dJoin_date,string x_sField1,System.Nullable<int> x_iBill_cycle,string x_sAddr_3,string x_sAddr_2,string x_sId_number,string x_sAttention_name_formartted,string x_sCustomer_name_formartted,string x_sAutopay,string x_sField3,string x_sAddr_4,string x_sProgram,string x_sProp_plan,string x_sCustomer_group,string x_sCustomer_code,System.Nullable<bool> x_bTelemarketing_suppress_flag,System.Nullable<bool> x_bIdd_flg,System.Nullable<bool> x_bActive,System.Nullable<DateTime> x_dDdate,string x_sPlan_fee,string x_sRate_plan,string x_sSegment,string x_sId1,string x_sPassword,string x_sPayment_method,string x_sContract_id,string x_sField2,string x_sMobile_no,string x_sPeriod,string x_sVas_desc,System.Nullable<DateTime> x_dCdate,string x_sSubscriber_tier,string x_sCustomer_id,System.Nullable<DateTime> x_dHandset_rebate_end_date,System.Nullable<int> x_iPlan_free_inter_min,string x_sCid,string x_sDid,string x_sExpired_month,System.Nullable<int> x_iPlan_free_intra_min,System.Nullable<bool> x_bOriginal_telemarketing_suppress_flag,string x_sContact_number,string x_sTradefield,string x_sAddr_1,System.Nullable<DateTime> x_dMax_contract_end_date,System.Nullable<DateTime> x_dMnp_rebate_end_date,string x_sProgram_id)
        {
            return Crm_rpt_2G_action_rpt_GLRepository.InsertReturnLastID_SP(x_oDB,x_sAls_flg,x_dEnd_date,x_sRemarks,x_sAirtime_hs_model,x_dStart_date,x_sCalllist_name,x_dJoin_date,x_sField1,x_iBill_cycle,x_sAddr_3,x_sAddr_2,x_sId_number,x_sAttention_name_formartted,x_sCustomer_name_formartted,x_sAutopay,x_sField3,x_sAddr_4,x_sProgram,x_sProp_plan,x_sCustomer_group,x_sCustomer_code,x_bTelemarketing_suppress_flag,x_bIdd_flg,x_bActive,x_dDdate,x_sPlan_fee,x_sRate_plan,x_sSegment,x_sId1,x_sPassword,x_sPayment_method,x_sContract_id,x_sField2,x_sMobile_no,x_sPeriod,x_sVas_desc,x_dCdate,x_sSubscriber_tier,x_sCustomer_id,x_dHandset_rebate_end_date,x_iPlan_free_inter_min,x_sCid,x_sDid,x_sExpired_month,x_iPlan_free_intra_min,x_bOriginal_telemarketing_suppress_flag,x_sContact_number,x_sTradefield,x_sAddr_1,x_dMax_contract_end_date,x_dMnp_rebate_end_date,x_sProgram_id);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GL)
        {
            return Crm_rpt_2G_action_rpt_GLRepository.InsertReturnLastID_SP(x_oDB,x_oCrm_rpt_2G_action_rpt_GL);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return Crm_rpt_2G_action_rpt_GLRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return Crm_rpt_2G_action_rpt_GLRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            return Crm_rpt_2G_action_rpt_GLRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(Crm_rpt_2G_action_rpt_GL x_oCrm_rpt_2G_action_rpt_GLRow){
            String sFile = String.Empty;
        }
        
        #endregion
        
        #region Release
        
        // ******************************
        // *  Handler for Release Memory
        // ******************************
        
        public void Release(){}
        #endregion
    }
}


