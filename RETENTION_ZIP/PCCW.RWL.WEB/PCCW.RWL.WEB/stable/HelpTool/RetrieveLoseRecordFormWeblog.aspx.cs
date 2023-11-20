using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;


public partial class SandBox_RetrieveLoseRecordFormWeblog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        //306091
        //RetrieveWebLogRecordFromHistory(306091);
    }

    protected void RetrieveWebLogRecordFromHistory(int x_iHis_Order_id)
    {
        MobileRetentionPreviousOrder _oMobileRetentionPreviousOrder = 
            new MobileRetentionPreviousOrder(SYSConn<MSSQLConnect>.Connect(), x_iHis_Order_id);
        if (_oMobileRetentionPreviousOrder.GetFound())
        {

            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect());
            _oMobileRetentionOrder.ac_no = _oMobileRetentionPreviousOrder.ac_no;
            _oMobileRetentionOrder.accept = _oMobileRetentionPreviousOrder.accept;
            _oMobileRetentionOrder.accessory_code = _oMobileRetentionPreviousOrder.accessory_code;
            _oMobileRetentionOrder.accessory_desc = _oMobileRetentionPreviousOrder.accessory_desc;
            _oMobileRetentionOrder.accessory_imei = _oMobileRetentionPreviousOrder.accessory_imei;
            _oMobileRetentionOrder.accessory_price = _oMobileRetentionPreviousOrder.accessory_price;
            _oMobileRetentionOrder.action_date = _oMobileRetentionPreviousOrder.action_date;
            _oMobileRetentionOrder.action_eff_date = _oMobileRetentionPreviousOrder.action_eff_date;
            _oMobileRetentionOrder.action_required = _oMobileRetentionPreviousOrder.action_required;
            _oMobileRetentionOrder.active = _oMobileRetentionPreviousOrder.active;
            _oMobileRetentionOrder.aig_gift = _oMobileRetentionPreviousOrder.aig_gift;
            _oMobileRetentionOrder.amount = _oMobileRetentionPreviousOrder.amount;
            _oMobileRetentionOrder.bank_code = _oMobileRetentionPreviousOrder.bank_code;
            _oMobileRetentionOrder.bank_name = _oMobileRetentionPreviousOrder.bank_name;
            _oMobileRetentionOrder.bill_cut_date = _oMobileRetentionPreviousOrder.bill_cut_date;
            _oMobileRetentionOrder.bill_cut_num = _oMobileRetentionPreviousOrder.bill_cut_num;
            _oMobileRetentionOrder.bundle_name = _oMobileRetentionPreviousOrder.bundle_name;
            _oMobileRetentionOrder.cancel_renew = _oMobileRetentionPreviousOrder.cancel_renew;
            _oMobileRetentionOrder.card_exp_month = _oMobileRetentionPreviousOrder.card_exp_month;
            _oMobileRetentionOrder.card_exp_year = _oMobileRetentionPreviousOrder.card_exp_year;
            _oMobileRetentionOrder.card_holder = _oMobileRetentionPreviousOrder.card_holder;
            _oMobileRetentionOrder.card_no = _oMobileRetentionPreviousOrder.card_no;
            _oMobileRetentionOrder.card_type = _oMobileRetentionPreviousOrder.card_type;
            _oMobileRetentionOrder.cdate = _oMobileRetentionPreviousOrder.cdate;
            _oMobileRetentionOrder.channel = _oMobileRetentionPreviousOrder.channel;
            _oMobileRetentionOrder.cid = _oMobileRetentionPreviousOrder.cid;
            _oMobileRetentionOrder.con_eff_date = _oMobileRetentionPreviousOrder.con_eff_date;
            _oMobileRetentionOrder.con_per = _oMobileRetentionPreviousOrder.con_per;
            _oMobileRetentionOrder.contact_no = _oMobileRetentionPreviousOrder.contact_no;
            _oMobileRetentionOrder.contact_person = _oMobileRetentionPreviousOrder.contact_person;
            _oMobileRetentionOrder.cooling_date = _oMobileRetentionPreviousOrder.cooling_date;
            _oMobileRetentionOrder.cooling_offer = _oMobileRetentionPreviousOrder.cooling_offer;
            _oMobileRetentionOrder.cust_name = _oMobileRetentionPreviousOrder.cust_name;
            _oMobileRetentionOrder.cust_staff_no = _oMobileRetentionPreviousOrder.cust_staff_no;
            _oMobileRetentionOrder.cust_type = _oMobileRetentionPreviousOrder.cust_type;
            _oMobileRetentionOrder.d_address = _oMobileRetentionPreviousOrder.d_address;
            _oMobileRetentionOrder.d_date = _oMobileRetentionPreviousOrder.d_date;
            _oMobileRetentionOrder.d_time = _oMobileRetentionPreviousOrder.d_time;
            _oMobileRetentionOrder.ddate = _oMobileRetentionPreviousOrder.ddate;
            _oMobileRetentionOrder.del_remark = _oMobileRetentionPreviousOrder.del_remark;
            _oMobileRetentionOrder.did = _oMobileRetentionPreviousOrder.did;
            _oMobileRetentionOrder.easywatch_ord_id = _oMobileRetentionPreviousOrder.easywatch_ord_id;
            _oMobileRetentionOrder.easywatch_type = _oMobileRetentionPreviousOrder.easywatch_type;
            _oMobileRetentionOrder.edf_no = _oMobileRetentionPreviousOrder.edf_no;
            _oMobileRetentionOrder.exist_cust_plan = _oMobileRetentionPreviousOrder.exist_cust_plan;
            _oMobileRetentionOrder.exist_plan = _oMobileRetentionPreviousOrder.exist_plan;
            _oMobileRetentionOrder.existing_contract_end_date = _oMobileRetentionPreviousOrder.existing_contract_end_date;
            _oMobileRetentionOrder.ext_place_tel = _oMobileRetentionPreviousOrder.ext_place_tel;
            _oMobileRetentionOrder.extn = _oMobileRetentionPreviousOrder.extn;
            _oMobileRetentionOrder.extra_d_charge = _oMobileRetentionPreviousOrder.extra_d_charge;
            _oMobileRetentionOrder.extra_offer = _oMobileRetentionPreviousOrder.extra_offer;
            _oMobileRetentionOrder.extra_rebate = _oMobileRetentionPreviousOrder.extra_rebate;
            _oMobileRetentionOrder.extra_rebate_amount = _oMobileRetentionPreviousOrder.extra_rebate_amount;
            _oMobileRetentionOrder.fast_start = _oMobileRetentionPreviousOrder.fast_start;
            _oMobileRetentionOrder.free_mon = _oMobileRetentionPreviousOrder.free_mon;
            _oMobileRetentionOrder.gift_code = _oMobileRetentionPreviousOrder.gift_code;
            _oMobileRetentionOrder.gift_code2 = _oMobileRetentionPreviousOrder.gift_code2;
            _oMobileRetentionOrder.gift_code3 = _oMobileRetentionPreviousOrder.gift_code3;
            _oMobileRetentionOrder.gift_code4 = _oMobileRetentionPreviousOrder.gift_code4;
            _oMobileRetentionOrder.gift_desc = _oMobileRetentionPreviousOrder.gift_desc;
            _oMobileRetentionOrder.gift_desc2 = _oMobileRetentionPreviousOrder.gift_desc2;
            _oMobileRetentionOrder.gift_desc3 = _oMobileRetentionPreviousOrder.gift_desc3;
            _oMobileRetentionOrder.gift_desc4 = _oMobileRetentionPreviousOrder.gift_desc4;
            _oMobileRetentionOrder.gift_imei = _oMobileRetentionPreviousOrder.gift_imei;
            _oMobileRetentionOrder.gift_imei2 = _oMobileRetentionPreviousOrder.gift_imei2;
            _oMobileRetentionOrder.gift_imei3 = _oMobileRetentionPreviousOrder.gift_imei3;
            _oMobileRetentionOrder.gift_imei4 = _oMobileRetentionPreviousOrder.gift_imei4;
            _oMobileRetentionOrder.go_wireless = _oMobileRetentionPreviousOrder.go_wireless;
            _oMobileRetentionOrder.go_wireless_package_code = _oMobileRetentionPreviousOrder.go_wireless_package_code;
            _oMobileRetentionOrder.hkid = _oMobileRetentionPreviousOrder.hkid;
            _oMobileRetentionOrder.hs_model = _oMobileRetentionPreviousOrder.hs_model;
            _oMobileRetentionOrder.id_type = _oMobileRetentionPreviousOrder.id_type;
            _oMobileRetentionOrder.imei_no = _oMobileRetentionPreviousOrder.imei_no;
            _oMobileRetentionOrder.lob = _oMobileRetentionPreviousOrder.lob;
            _oMobileRetentionOrder.lob_ac = _oMobileRetentionPreviousOrder.lob_ac;
            _oMobileRetentionOrder.log_date = _oMobileRetentionPreviousOrder.log_date;
            _oMobileRetentionOrder.m_card_exp_month = _oMobileRetentionPreviousOrder.m_card_exp_month;
            _oMobileRetentionOrder.m_card_exp_year = _oMobileRetentionPreviousOrder.m_card_exp_year;
            _oMobileRetentionOrder.m_card_holder2 = _oMobileRetentionPreviousOrder.m_card_holder2;
            _oMobileRetentionOrder.m_card_no = _oMobileRetentionPreviousOrder.m_card_no;
            _oMobileRetentionOrder.m_card_type = _oMobileRetentionPreviousOrder.m_card_type;
            _oMobileRetentionOrder.m_rebate_amount = _oMobileRetentionPreviousOrder.m_rebate_amount;
            _oMobileRetentionOrder.monthly_payment_method = _oMobileRetentionPreviousOrder.monthly_payment_method;
            _oMobileRetentionOrder.mrt_no = _oMobileRetentionPreviousOrder.mrt_no;
            _oMobileRetentionOrder.next_bill = _oMobileRetentionPreviousOrder.next_bill;
            _oMobileRetentionOrder.normal_rebate = _oMobileRetentionPreviousOrder.normal_rebate;
            _oMobileRetentionOrder.ob_program_id = _oMobileRetentionPreviousOrder.ob_program_id;
            _oMobileRetentionOrder.old_ord_id = _oMobileRetentionPreviousOrder.old_ord_id;
            _oMobileRetentionOrder.ord_place_by = _oMobileRetentionPreviousOrder.ord_place_by;
            _oMobileRetentionOrder.ord_place_hkid = _oMobileRetentionPreviousOrder.ord_place_hkid;
            _oMobileRetentionOrder.ord_place_id_type = _oMobileRetentionPreviousOrder.ord_place_id_type;
            _oMobileRetentionOrder.ord_place_rel = _oMobileRetentionPreviousOrder.ord_place_rel;
            _oMobileRetentionOrder.ord_place_tel = _oMobileRetentionPreviousOrder.ord_place_tel;
            _oMobileRetentionOrder.org_fee = _oMobileRetentionPreviousOrder.org_fee;
            _oMobileRetentionOrder.org_ftg = _oMobileRetentionPreviousOrder.org_ftg;
            _oMobileRetentionOrder.org_mrt = _oMobileRetentionPreviousOrder.org_mrt;
            _oMobileRetentionOrder.pay_method = _oMobileRetentionPreviousOrder.pay_method;
            _oMobileRetentionOrder.pcd_paid_go_wireless = _oMobileRetentionPreviousOrder.pcd_paid_go_wireless;
            _oMobileRetentionOrder.plan_eff = _oMobileRetentionPreviousOrder.plan_eff;
            _oMobileRetentionOrder.plan_eff_date = _oMobileRetentionPreviousOrder.plan_eff_date;
            _oMobileRetentionOrder.pos_ref_no = _oMobileRetentionPreviousOrder.pos_ref_no;
            _oMobileRetentionOrder.preferred_languages = _oMobileRetentionPreviousOrder.preferred_languages;
            _oMobileRetentionOrder.premium = _oMobileRetentionPreviousOrder.premium;
            _oMobileRetentionOrder.program = _oMobileRetentionPreviousOrder.program;
            _oMobileRetentionOrder.r_offer = _oMobileRetentionPreviousOrder.r_offer;
            _oMobileRetentionOrder.rate_plan = _oMobileRetentionPreviousOrder.rate_plan;
            _oMobileRetentionOrder.reasons = _oMobileRetentionPreviousOrder.reasons;
            _oMobileRetentionOrder.rebate = _oMobileRetentionPreviousOrder.rebate;
            _oMobileRetentionOrder.rebate_amount = _oMobileRetentionPreviousOrder.rebate_amount;
            _oMobileRetentionOrder.ref_salesmancode = _oMobileRetentionPreviousOrder.ref_salesmancode;
            _oMobileRetentionOrder.ref_staff_no = _oMobileRetentionPreviousOrder.ref_staff_no;
            _oMobileRetentionOrder.register_address = _oMobileRetentionPreviousOrder.register_address;
            _oMobileRetentionOrder.remarks = _oMobileRetentionPreviousOrder.remarks;
            _oMobileRetentionOrder.remarks2EDF = _oMobileRetentionPreviousOrder.remarks2EDF;
            _oMobileRetentionOrder.remarks2PY = _oMobileRetentionPreviousOrder.remarks2PY;
            _oMobileRetentionOrder.retention_type = _oMobileRetentionPreviousOrder.retention_type;
            _oMobileRetentionOrder.retrieve_cnt = _oMobileRetentionPreviousOrder.retrieve_cnt;
            _oMobileRetentionOrder.s_premium = _oMobileRetentionPreviousOrder.s_premium;
            _oMobileRetentionOrder.s_premium2 = _oMobileRetentionPreviousOrder.s_premium2;
            _oMobileRetentionOrder.salesmancode = _oMobileRetentionPreviousOrder.salesmancode;
            _oMobileRetentionOrder.sim_mrt_no = _oMobileRetentionPreviousOrder.sim_mrt_no;
            _oMobileRetentionOrder.sku = _oMobileRetentionPreviousOrder.sku;
            _oMobileRetentionOrder.sp_d_date = _oMobileRetentionPreviousOrder.sp_d_date;
            _oMobileRetentionOrder.sp_ref_no = _oMobileRetentionPreviousOrder.sp_ref_no;
            _oMobileRetentionOrder.special_approval = _oMobileRetentionPreviousOrder.special_approval;
            _oMobileRetentionOrder.staff_name = _oMobileRetentionPreviousOrder.staff_name;
            _oMobileRetentionOrder.staff_no = _oMobileRetentionPreviousOrder.staff_no;
            _oMobileRetentionOrder.status_by_cs_admin = _oMobileRetentionPreviousOrder.status_by_cs_admin;
            _oMobileRetentionOrder.teamcode = _oMobileRetentionPreviousOrder.teamcode;
            _oMobileRetentionOrder.third_party_credit_card = _oMobileRetentionPreviousOrder.third_party_credit_card;
            _oMobileRetentionOrder.third_party_hkid = _oMobileRetentionPreviousOrder.third_party_hkid;
            _oMobileRetentionOrder.third_party_id_type = _oMobileRetentionPreviousOrder.third_party_id_type;
            _oMobileRetentionOrder.tl_name = _oMobileRetentionPreviousOrder.tl_name;
            _oMobileRetentionOrder.trade_field = _oMobileRetentionPreviousOrder.trade_field;
            _oMobileRetentionOrder.vas_eff_date = _oMobileRetentionPreviousOrder.vas_eff_date;
            _oMobileRetentionOrder.vip_case = _oMobileRetentionPreviousOrder.vip_case;
            _oMobileRetentionOrder.waive = _oMobileRetentionPreviousOrder.waive;

            if (MobileRetentionOrderBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oMobileRetentionOrder))
            {
                Response.Write("Insert a retrieve order data success!");
            }


        }
    }
}
