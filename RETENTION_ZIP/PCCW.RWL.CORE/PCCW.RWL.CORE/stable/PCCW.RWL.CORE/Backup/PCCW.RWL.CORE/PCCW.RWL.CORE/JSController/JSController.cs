using System;
using System.IO;
using System.Web.UI;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;
using System.Xml;

namespace PCCW.RWL.CORE
{
    [Serializable]
    public class JSController
    {
        protected Dictionary<string, object> ControlArr = new Dictionary<string, object>();
        public JSController()
        {
            this.InitControl();
            this.InitControlValue();
        }

        #region InitControl
        protected void InitControl()
        {
            this.exist_cust_plan = new JS_SELECT("exist_cust_plan", "SELECT");
            this.org_fee = new JS_SELECT("org_fee", "SELECT");
            this.family_name = new JS_INPUT("family_name", "text");
            this.given_name = new JS_INPUT("given_name", "text");
            this.cust_name = new JS_INPUT("cust_name", "text");
            this.hkid = new JS_INPUT("hkid", "text");
            this.hkid2 = new JS_INPUT("hkid2", "text");
            this.id_type = new JS_SELECT("id_type", "SELECT");
            this.id_type1 = new JS_INPUT("id_type1", "text");
            this.action_required = new JS_INPUT("action_required", "checkbox");
            this.action_required2 = new JS_INPUT("action_required2", "checkbox");
            this.program = new JS_SELECT("program", "SELECT");
            this.plan_fee = new JS_SELECT("plan_fee", "SELECT");
            this.tier = new JS_SELECT("tier", "SELECT");
            this.rate_plan = new JS_SELECT("rate_plan", "SELECT");
            this.con_per = new JS_SELECT("con_per", "SELECT");
            this.rebate = new JS_SELECT("rebate", "SELECT");
            this.free_mon = new JS_SELECT("free_mon", "SELECT");
            this.hs_model = new JS_SELECT("hs_model", "SELECT");
            this.premium = new JS_SELECT("premium", "SELECT");
            this.s_premium = new JS_SELECT("s_premium", "SELECT");
            this.s_premium2 = new JS_SELECT("s_premium2", "SELECT");
            this.trade_field = new JS_SELECT("trade_field", "SELECT");
            this.bundle_name = new JS_SELECT("bundle_name", "SELECT");
            this.rebate_amount4 = new JS_SELECT("rebate_amount4", "SELECT");
            this.r_offer4 = new JS_SELECT("r_offer4", "SELECT");
            this.extra_rebate = new JS_INPUT("extra_rebate", "text");
            this.extra_rebate_amount4 = new JS_SELECT("extra_rebate_amount4", "SELECT");
            this.extra_rebate4 = new JS_SELECT("extra_rebate4", "SELECT");
            this.gift_desc1 = new JS_SELECT("gift_desc1", "SELECT");
            this.gift_desc21 = new JS_SELECT("gift_desc21", "SELECT");
            this.gift_desc31 = new JS_SELECT("gift_desc31", "SELECT");
            this.gift_desc41 = new JS_SELECT("gift_desc41", "SELECT");
            this.accessory_desc1 = new JS_SELECT("accessory_desc1", "SELECT");
            this.aig_gift = new JS_SELECT("aig_gift", "SELECT");
            this.d_district = new JS_SELECT("d_district", "SELECT");
            this.d_time = new JS_SELECT("d_time", "SELECT");
            this.pay_method = new JS_SELECT("pay_method", "SELECT");
            this.bank_code = new JS_SELECT("bank_code", "SELECT");
            this.go_wireless = new JS_SELECT("go_wireless", "SELECT");
            this.lob = new JS_SELECT("lob", "SELECT");
            this.lob_ac = new JS_INPUT("lob_ac", "SELECT");
            this.go_wireless_package_code = new JS_INPUT("go_wireless_package_code", "SELECT");
            
            this.card_type = new JS_SELECT("card_type", "SELECT");
            this.card_exp_month = new JS_SELECT("card_exp_month", "SELECT");
            this.card_exp_year = new JS_SELECT("card_exp_year", "SELECT");
            this.sku = new JS_INPUT("sku", "SELECT");
            
            this.rebate_amount = new JS_INPUT("rebate_amount", "text");
            this.rebate_amount1 = new JS_INPUT("rebate_amount1", "text");
            this.rebate_amount2 = new JS_INPUT("rebate_amount2", "text");
            this.rebate_amount3 = new JS_INPUT("rebate_amount3", "text");
            
            this.r_offer = new JS_INPUT("r_offer", "text");
            this.r_offer1 = new JS_INPUT("r_offer1", "text");
            this.r_offer2 = new JS_INPUT("r_offer2", "text");
            
            this.extra_rebate_amount = new JS_INPUT("extra_rebate_amount", "text");
            this.extra_rebate_amount1 = new JS_INPUT("extra_rebate_amount1", "text");
            this.extra_rebate_amount2 = new JS_INPUT("extra_rebate_amount2", "text");
            this.extra_rebate_amount3 = new JS_INPUT("extra_rebate_amount3", "text");

            this.gift_desc = new JS_INPUT("gift_desc", "text");
            this.gift_code = new JS_INPUT("gift_code", "text");
            this.gift_imei = new JS_INPUT("gift_imei", "text");
            this.gift_desc1 = new JS_SELECT("gift_desc1", "SELECT");

            this.gift_desc2 = new JS_INPUT("gift_desc2", "text");
            this.gift_code2 = new JS_INPUT("gift_code2", "text");
            this.gift_imei2 = new JS_INPUT("gift_imei2", "text");
            this.gift_desc21 = new JS_SELECT("gift_desc21", "SELECT");

            this.gift_desc3 = new JS_INPUT("gift_desc3", "text");
            this.gift_code3 = new JS_INPUT("gift_code3", "text");
            this.gift_imei3 = new JS_INPUT("gift_imei3", "text");
            this.gift_desc31 = new JS_SELECT("gift_desc31", "SELECT");

            this.gift_desc4 = new JS_INPUT("gift_desc4", "text");
            this.gift_code4 = new JS_INPUT("gift_code4", "text");
            this.gift_imei4 = new JS_INPUT("gift_imei4", "text");
            this.gift_desc41 = new JS_SELECT("gift_desc41", "SELECT");

            this.accessory_price = new JS_INPUT("accessory_price", "text");
            this.accessory_imei = new JS_INPUT("accessory_imei", "text");
            this.accessory_code = new JS_INPUT("accessory_code", "text");
            this.accessory_desc = new JS_INPUT("accessory_desc", "text");
            this.accessory_desc1 = new JS_SELECT("accessory_desc1", "SELECT");
            this.amount = new JS_INPUT("amount", "SELECT");
            this.extra_d_charge = new JS_INPUT("extra_d_charge", "text");
            this.normal_rebate_list = new JS_RADIO("normal_rebate_list", "radio");
            this.normal_rebate_list.Items.Add(new JS_LISTITEM("Retention", "Y"));
            this.normal_rebate_list.Items.Add(new JS_LISTITEM("Retention+", "N"));
            this.normal_rebate_list.Items.Add(new JS_LISTITEM("Loyal Retention+", "L"));
            this.normal_rebate_list.Items.Add(new JS_LISTITEM("Special Retention", "S"));
            this.normal_rebate_list.Items.Add(new JS_LISTITEM("T-5 Upselling", "T"));
            this.normal_rebate_list.Items.Add(new JS_LISTITEM("Sim Only T-5 Upselling", "O"));
            this.special_approval = new JS_RADIO("special_approval", "radio");
            this.special_approval.Items.Add(new JS_LISTITEM("Y", "Y"));
            this.special_approval.Items.Add(new JS_LISTITEM("N", "N"));
            this.preferred_languages = new JS_RADIO("preferred_languages", "radio");
            this.preferred_languages.Items.Add(new JS_LISTITEM("CHINESE", "CHINESE"));
            this.preferred_languages.Items.Add(new JS_LISTITEM("ENGLISH", "ENGLISH"));
            this.cust_staff_no = new JS_INPUT("cust_staff_no", "text");
            this.check_sn_no = new JS_INPUT("check_sn_no", "text");
            this.org_mrt = new JS_INPUT("org_mrt", "text");
            this.easywatch_ord_id = new JS_INPUT("easywatch_ord_id", "text");
            this.check_easy_id = new JS_INPUT("check_easy_id", "text");
            this.con_eff_date = new JS_INPUT("con_eff_date", "text");
            this.plan_eff = new JS_RADIO("plan_eff", "text");
            this.plan_eff.Items.Add(new JS_LISTITEM("Next Bill Date", "NBD"));
            this.plan_eff.Items.Add(new JS_LISTITEM("Other", "OTHER"));
            this.plan_eff_date = new JS_INPUT("plan_eff_date", "text");
            this.easywatch_type = new JS_RADIO("easywatch_type", "radio");
            this.easywatch_type.Items.Add(new JS_LISTITEM("Standalone", "standalone"));
            this.easywatch_type.Items.Add(new JS_LISTITEM("Combo offer Easywatch Standlone Order ID", "combo"));
            this.d_type = new JS_SELECT("d_type", "SELECT");
            this.d_build = new JS_INPUT("d_build", "text");
            this.d_blk = new JS_INPUT("d_blk", "text");
            this.d_room = new JS_INPUT("d_room", "text");
            this.d_floor = new JS_INPUT("d_floor", "text");
            this.d_street = new JS_INPUT("d_street", "text");
            this.d_region = new JS_RADIO("d_region", "radio");
            this.d_region.Items.Add(new JS_LISTITEM("HK", "0"));
            this.d_region.Items.Add(new JS_LISTITEM("KLN", "1"));
            this.d_region.Items.Add(new JS_LISTITEM("NT", "2"));
            this.d_region.Items.Add(new JS_LISTITEM("LT", "3"));
            this.contact_person = new JS_INPUT("contact_person", "text");
            this.contact_no = new JS_INPUT("contact_no", "text");
            this.ext_place_tel = new JS_INPUT("ext_place_tel", "text");
            this.card_no1 = new JS_INPUT("card_no1", "text");
            this.card_no2 = new JS_INPUT("card_no2", "text");
            this.card_no3 = new JS_INPUT("card_no3", "text");
            this.card_no4 = new JS_INPUT("card_no3", "text");
            this.card_holder = new JS_INPUT("card_holder", "text");
            this.card_exp_month = new JS_SELECT("card_exp_month", "SELECT");
            this.card_exp_year = new JS_SELECT("card_exp_year", "SELECT");
            this.bank_code = new JS_SELECT("bank_code", "SELECT");
            this.remarks2EDF = new JS_INPUT("remarks2EDF", "text");
            this.remarks2PY = new JS_INPUT("remarks2PY", "text");
            this.channel = new JS_INPUT("channel", "text");
            this.gw_value = new JS_INPUT("gw_value", "text");
            this.submit_gw = new JS_INPUT("submit_gw", "button");
            this.d_date = new JS_SELECT("d_date", "SELECT");
            this.d_time = new JS_SELECT("d_time", "SELECT");
            this.ac_no = new JS_INPUT("ac_no", "SELECT");
            
        }
        #endregion InitControl

        #region InitControlValue
        protected void InitControlValue()
        {
            this.SetRunRegistorJS(false);
            this.id_type1.Disabled = true;
            this.id_type1.Attributes["readonly"] = "true";
            this.special_approval.Disabled = true;
            this.lob.Disabled = true;
            this.lob_ac.Disabled = true;
            this.go_wireless_package_code.Disabled = true;
            this.rebate_amount1.Disabled = true;
            this.rebate_amount2.Disabled = true;
            this.rebate_amount3.Disabled = true;
            this.r_offer1.Disabled = true;
            this.r_offer2.Disabled = true;
            this.extra_rebate_amount1.Disabled = true;
            this.extra_rebate_amount2.Disabled = true;
            this.extra_rebate_amount3.Disabled = true;
            this.preferred_languages.Disabled = true;
            this.d_room.Disabled = true;
            this.d_floor.Disabled = true;
            this.d_blk.Disabled = true;
            this.d_build.Disabled = true;
            this.d_street.Disabled = true;
            this.d_district.Disabled = true;
            this.d_time.Disabled = true;
            this.extra_d_charge.Disabled = true;
            this.contact_person.Disabled = true;
            this.contact_no.Disabled = true;
            this.ext_place_tel.Disabled = true;
            this.pay_method.Disabled = true;
            this.card_type.Disabled = true;
            this.card_no1.Disabled = true;
            this.card_no2.Disabled = true;
            this.card_no3.Disabled = true;
            this.card_no4.Disabled = true;
            this.card_type.Disabled = true;
            this.card_holder.Disabled = true;
            this.card_exp_month.Disabled = true;
            this.card_exp_year.Disabled = true;
            this.bank_code.Disabled = true;
            this.remarks2EDF.Disabled = true;

            this.id_type1.Attributes["readonly"] = "true";
            this.sku.Attributes["readonly"] = "true";
            this.rebate_amount.Attributes["readonly"] = "true";
            this.r_offer.Attributes["readonly"] = "true";
            this.extra_rebate_amount.Attributes["readonly"] = "true";
            this.gift_desc.Attributes["readonly"] = "true";
            this.gift_code.Attributes["readonly"] = "true";
            this.gift_imei.Attributes["readonly"] = "true";
            this.gift_desc2.Attributes["readonly"] = "true";
            this.gift_code2.Attributes["readonly"] = "true";
            this.gift_imei2.Attributes["readonly"] = "true";
            this.gift_desc3.Attributes["readonly"] = "true";
            this.gift_code3.Attributes["readonly"] = "true";
            this.gift_imei3.Attributes["readonly"] = "true";
            this.gift_desc4.Attributes["readonly"] = "true";
            this.gift_code4.Attributes["readonly"] = "true";
            this.gift_imei4.Attributes["readonly"] = "true";
            this.accessory_desc.Attributes["readonly"] = "true";
            this.accessory_code.Attributes["readonly"] = "true";
            this.accessory_imei.Attributes["readonly"] = "true";
            this.accessory_price.Attributes["readonly"] = "true";
            this.amount.Attributes["readonly"] = "true";
            this.SetRunRegistorJS(true);
        }
        #endregion InitControlValue

        //ac_no
        protected JS_INPUT _ac_no = null;
        #region ac_no
        public JS_INPUT ac_no
        {
            set
            {
                _ac_no = value;
                if (ControlArr.ContainsKey("ac_no"))
                    ControlArr["ac_no"] = value;
                else
                    ControlArr.Add("ac_no", _ac_no);
            }
            get { return _ac_no; }
        }
        #endregion

        protected JS_INPUT _submit_gw = null;
        #region submit_gw
        public JS_INPUT submit_gw
        {
            set
            {
                _submit_gw = value;
                if (ControlArr.ContainsKey("submit_gw"))
                    ControlArr["submit_gw"] = value;
                else
                    ControlArr.Add("submit_gw", _submit_gw);
            }
            get { return _submit_gw; }
        }
        #endregion

        protected JS_INPUT _gw_value = null;
        #region gw_value
        public JS_INPUT gw_value
        {
            set
            {
                _gw_value = value;
                if (ControlArr.ContainsKey("gw_value"))
                    ControlArr["gw_value"] = value;
                else
                    ControlArr.Add("gw_value", _gw_value);
            }
            get { return _gw_value; }
        }
        #endregion

        protected JS_INPUT _channel = null;
        #region channel
        public JS_INPUT channel
        {
            set
            {
                _channel = value;
                if (ControlArr.ContainsKey("channel"))
                    ControlArr["channel"] = value;
                else
                    ControlArr.Add("channel", _channel);
            }
            get { return _channel; }
        }
        #endregion

        protected JS_INPUT _remarks2PY = null;
        #region remarks2PY
        public JS_INPUT remarks2PY
        {
            set
            {
                _remarks2PY = value;
                if (ControlArr.ContainsKey("remarks2PY"))
                    ControlArr["remarks2PY"] = value;
                else
                    ControlArr.Add("remarks2PY", _remarks2PY);
            }
            get { return _remarks2PY; }
        }
        #endregion

        protected JS_INPUT _remarks2EDF = null;
        #region remarks2EDF
        public JS_INPUT remarks2EDF
        {
            set
            {
                _remarks2EDF = value;
                if (ControlArr.ContainsKey("remarks2EDF"))
                    ControlArr["remarks2EDF"] = value;
                else
                    ControlArr.Add("remarks2EDF", _remarks2EDF);
            }
            get { return _remarks2EDF; }
        }
        #endregion

        protected JS_INPUT _card_holder = null;
        #region card_holder
        public JS_INPUT card_holder
        {
            set
            {
                _card_holder = value;
                if (ControlArr.ContainsKey("card_holder"))
                    ControlArr["card_holder"] = value;
                else
                    ControlArr.Add("card_holder", _card_holder);
            }
            get { return _card_holder; }
        }
        #endregion

        protected JS_INPUT _card_no4 = null;
        #region card_no4
        public JS_INPUT card_no4
        {
            set
            {
                _card_no4 = value;
                if (ControlArr.ContainsKey("card_no4"))
                    ControlArr["card_no4"] = value;
                else
                    ControlArr.Add("card_no4", _card_no4);
            }
            get { return _card_no4; }
        }
        #endregion

        protected JS_INPUT _card_no3 = null;
        #region card_no3
        public JS_INPUT card_no3
        {
            set
            {
                _card_no3 = value;
                if (ControlArr.ContainsKey("card_no3"))
                    ControlArr["card_no3"] = value;
                else
                    ControlArr.Add("card_no3", _card_no3);
            }
            get { return _card_no3; }
        }
        #endregion

        protected JS_INPUT _card_no2 = null;
        #region card_no2
        public JS_INPUT card_no2
        {
            set
            {
                _card_no2 = value;
                if (ControlArr.ContainsKey("card_no2"))
                    ControlArr["card_no2"] = value;
                else
                    ControlArr.Add("card_no2", _card_no2);
            }
            get { return _card_no2; }
        }
        #endregion

        protected JS_INPUT _card_no1 = null;
        #region card_no1
        public JS_INPUT card_no1
        {
            set
            {
                _card_no1 = value;
                if (ControlArr.ContainsKey("card_no1"))
                    ControlArr["card_no1"] = value;
                else
                    ControlArr.Add("card_no1", _card_no1);
            }
            get { return _card_no1; }
        }
        #endregion

        protected JS_INPUT _ext_place_tel = null;
        #region ext_place_tel
        public JS_INPUT ext_place_tel
        {
            set
            {
                _ext_place_tel = value;
                if (ControlArr.ContainsKey("ext_place_tel"))
                    ControlArr["ext_place_tel"] = value;
                else
                    ControlArr.Add("ext_place_tel", _ext_place_tel);
            }
            get { return _ext_place_tel; }
        }
        #endregion

        protected JS_INPUT _contact_no = null;
        #region contact_no
        public JS_INPUT contact_no
        {
            set
            {
                _contact_no = value;
                if (ControlArr.ContainsKey("contact_no"))
                    ControlArr["contact_no"] = value;
                else
                    ControlArr.Add("contact_no", _contact_no);
            }
            get { return _contact_no; }
        }
        #endregion

        protected JS_INPUT _contact_person = null;
        #region contact_person
        public JS_INPUT contact_person
        {
            set
            {
                _contact_person = value;
                if (ControlArr.ContainsKey("contact_person"))
                    ControlArr["contact_person"] = value;
                else
                    ControlArr.Add("contact_person", _contact_person);
            }
            get { return _contact_person; }
        }
        #endregion

        protected JS_SELECT _d_date = null;
        #region d_date
        public JS_SELECT d_date
        {
            set
            {
                _d_date = value;
                if (ControlArr.ContainsKey("d_date"))
                    ControlArr["d_date"] = value;
                else
                    ControlArr.Add("d_date", _d_date);
            }
            get { return _d_date; }
        }
        #endregion

        protected JS_RADIO _d_region = null;
        #region d_region
        public JS_RADIO d_region
        {
            set
            {
                _d_region = value;
                if (ControlArr.ContainsKey("d_region"))
                    ControlArr["d_region"] = value;
                else
                    ControlArr.Add("d_region", _d_region);
            }
            get { return _d_region; }
        }
        #endregion

        protected JS_INPUT _d_street = null;
        #region d_street
        public JS_INPUT d_street
        {
            set
            {
                _d_street = value;
                if (ControlArr.ContainsKey("d_street"))
                    ControlArr["d_street"] = value;
                else
                    ControlArr.Add("d_street", _d_street);
            }
            get { return _d_street; }
        }
        #endregion

        protected JS_INPUT _d_floor = null;
        #region d_floor
        public JS_INPUT d_floor
        {
            set
            {
                _d_floor = value;
                if (ControlArr.ContainsKey("d_floor"))
                    ControlArr["d_floor"] = value;
                else
                    ControlArr.Add("d_floor", _d_floor);
            }
            get { return _d_floor; }
        }
        #endregion

        protected JS_INPUT _d_build = null;
        #region d_build
        public JS_INPUT d_build
        {
            set
            {
                _d_build = value;
                if (ControlArr.ContainsKey("d_build"))
                    ControlArr["d_build"] = value;
                else
                    ControlArr.Add("d_build", _d_build);
            }
            get { return _d_build; }
        }
        #endregion

        protected JS_INPUT _d_blk = null;
        #region d_blk
        public JS_INPUT d_blk
        {
            set
            {
                _d_blk = value;
                if (ControlArr.ContainsKey("d_blk"))
                    ControlArr["d_blk"] = value;
                else
                    ControlArr.Add("d_blk", _d_blk);
            }
            get { return _d_blk; }
        }
        #endregion

        protected JS_INPUT _d_room = null;
        #region d_room
        public JS_INPUT d_room
        {
            set
            {
                _d_room = value;
                if (ControlArr.ContainsKey("d_room"))
                    ControlArr["d_room"] = value;
                else
                    ControlArr.Add("d_room", _d_room);
            }
            get { return _d_room; }
        }
        #endregion

        protected JS_SELECT _d_type = null;
        #region d_type
        public JS_SELECT d_type
        {
            set
            {
                _d_type = value;
                if (ControlArr.ContainsKey("d_type"))
                    ControlArr["d_type"] = value;
                else
                    ControlArr.Add("d_type", _d_type);
            }
            get { return _d_type; }
        }
        #endregion

        protected JS_RADIO _easywatch_type = null;
        #region easywatch_type
        public JS_RADIO easywatch_type
        {
            set
            {
                _easywatch_type = value;
                if (ControlArr.ContainsKey("easywatch_type"))
                    ControlArr["easywatch_type"] = value;
                else
                    ControlArr.Add("easywatch_type", _easywatch_type);
            }
            get { return _easywatch_type; }
        }
        #endregion

        protected JS_INPUT _plan_eff_date = null;
        #region plan_eff_date
        public JS_INPUT plan_eff_date
        {
            set
            {
                _plan_eff_date = value;
                if (ControlArr.ContainsKey("plan_eff_date"))
                    ControlArr["plan_eff_date"] = value;
                else
                    ControlArr.Add("plan_eff_date", _plan_eff_date);
            }
            get { return _plan_eff_date; }
        }
        #endregion

        protected JS_RADIO _plan_eff = null;
        #region plan_eff
        public JS_RADIO plan_eff
        {
            set
            {
                _plan_eff = value;
                if (ControlArr.ContainsKey("plan_eff"))
                    ControlArr["plan_eff"] = value;
                else
                    ControlArr.Add("plan_eff", _plan_eff);
            }
            get { return _plan_eff; }
        }
        #endregion

        protected JS_INPUT _con_eff_date = null;
        #region con_eff_date
        public JS_INPUT con_eff_date
        {
            set
            {
                _con_eff_date = value;
                if (ControlArr.ContainsKey("con_eff_date"))
                    ControlArr["con_eff_date"] = value;
                else
                    ControlArr.Add("con_eff_date", _con_eff_date);
            }
            get { return _con_eff_date; }
        }
        #endregion

        protected JS_INPUT _check_easy_id = null;
        #region check_easy_id
        public JS_INPUT check_easy_id
        {
            set
            {
                _check_easy_id = value;
                if (ControlArr.ContainsKey("check_easy_id"))
                    ControlArr["check_easy_id"] = value;
                else
                    ControlArr.Add("check_easy_id", _check_easy_id);
            }
            get { return _check_easy_id; }
        }
        #endregion
 
        protected JS_INPUT _easywatch_ord_id = null;
        #region easywatch_ord_id
        public JS_INPUT easywatch_ord_id
        {
            set
            {
                _easywatch_ord_id = value;
                if (ControlArr.ContainsKey("easywatch_ord_id"))
                    ControlArr["easywatch_ord_id"] = value;
                else
                    ControlArr.Add("easywatch_ord_id", _easywatch_ord_id);
            }
            get { return _easywatch_ord_id; }
        }
        #endregion

        protected JS_INPUT _org_mrt = null;
        #region org_mrt
        public JS_INPUT org_mrt
        {
            set
            {
                _org_mrt = value;
                if (ControlArr.ContainsKey("org_mrt"))
                    ControlArr["org_mrt"] = value;
                else
                    ControlArr.Add("org_mrt", _org_mrt);
            }
            get { return _org_mrt; }
        }
        #endregion
        

        protected JS_INPUT _check_sn_no = null;
        #region check_sn_no
        public JS_INPUT check_sn_no
        {
            set
            {
                _check_sn_no = value;
                if (ControlArr.ContainsKey("check_sn_no"))
                    ControlArr["check_sn_no"] = value;
                else
                    ControlArr.Add("check_sn_no", _check_sn_no);
            }
            get { return _check_sn_no; }
        }
        #endregion

        protected JS_INPUT _cust_staff_no = null;
        #region cust_staff_no
        public JS_INPUT cust_staff_no
        {
            set
            {
                _cust_staff_no = value;
                if (ControlArr.ContainsKey("cust_staff_no"))
                    ControlArr["cust_staff_no"] = value;
                else
                    ControlArr.Add("cust_staff_no", _cust_staff_no);
            }
            get { return _cust_staff_no; }
        }
        #endregion


        protected JS_RADIO _preferred_languages = null;
        #region preferred_languages
        public JS_RADIO preferred_languages
        {
            set
            {
                _preferred_languages = value;
                if (ControlArr.ContainsKey("preferred_languages"))
                    ControlArr["preferred_languages"] = value;
                else
                    ControlArr.Add("preferred_languages", _preferred_languages);
            }
            get { return _preferred_languages; }
        }
        #endregion


        protected JS_RADIO _special_approval = null;
        #region special_approval
        public JS_RADIO special_approval
        {
            set
            {
                _special_approval = value;
                if (ControlArr.ContainsKey("special_approval"))
                    ControlArr["special_approval"] = value;
                else
                    ControlArr.Add("special_approval", _special_approval);
            }
            get { return _special_approval; }
        }
        #endregion

        protected JS_RADIO _normal_rebate_list = null;
        #region normal_rebate_list
        public JS_RADIO normal_rebate_list
        {
            set
            {
                _normal_rebate_list = value;
                if (ControlArr.ContainsKey("normal_rebate_list"))
                    ControlArr["normal_rebate_list"] = value;
                else
                    ControlArr.Add("normal_rebate_list", _normal_rebate_list);
            }
            get { return _normal_rebate_list; }
        }
        #endregion

        protected JS_INPUT _extra_d_charge = null;
        #region extra_d_charge
        public JS_INPUT extra_d_charge
        {
            set
            {
                _extra_d_charge = value;
                if (ControlArr.ContainsKey("extra_d_charge"))
                    ControlArr["extra_d_charge"] = value;
                else
                    ControlArr.Add("extra_d_charge", _extra_d_charge);
            }
            get { return _extra_d_charge; }
        }
        #endregion

        protected JS_INPUT _amount = null;
        #region amount
        public JS_INPUT amount
        {
            set
            {
                _amount = value;
                if (ControlArr.ContainsKey("amount"))
                    ControlArr["amount"] = value;
                else
                    ControlArr.Add("amount", _amount);
            }
            get { return _amount; }
        }
        #endregion

        protected JS_INPUT _accessory_price = null;
        #region accessory_price
        public JS_INPUT accessory_price
        {
            set
            {
                _accessory_price = value;
                if (ControlArr.ContainsKey("accessory_price"))
                    ControlArr["accessory_price"] = value;
                else
                    ControlArr.Add("accessory_price", _accessory_price);
            }
            get { return _accessory_price; }
        }
        #endregion

        protected JS_INPUT _accessory_imei = null;
        #region accessory_imei
        public JS_INPUT accessory_imei
        {
            set
            {
                _accessory_imei = value;
                if (ControlArr.ContainsKey("accessory_imei"))
                    ControlArr["accessory_imei"] = value;
                else
                    ControlArr.Add("accessory_imei", _accessory_imei);
            }
            get { return _accessory_imei; }
        }
        #endregion

        protected JS_INPUT _accessory_code = null;
        #region accessory_code
        public JS_INPUT accessory_code
        {
            set
            {
                _accessory_code = value;
                if (ControlArr.ContainsKey("accessory_code"))
                    ControlArr["accessory_code"] = value;
                else
                    ControlArr.Add("accessory_code", _accessory_code);
            }
            get { return _accessory_code; }
        }
        #endregion

        protected JS_INPUT _accessory_desc = null;
        #region accessory_desc
        public JS_INPUT accessory_desc
        {
            set
            {
                _accessory_desc = value;
                if (ControlArr.ContainsKey("accessory_desc"))
                    ControlArr["accessory_desc"] = value;
                else
                    ControlArr.Add("accessory_desc", accessory_desc);
            }
            get { return _accessory_desc; }
        }
        #endregion

        protected JS_SELECT _accessory_desc1 = null;
        #region accessory_desc1
        public JS_SELECT accessory_desc1
        {
            set
            {
                _accessory_desc1 = value;
                if (ControlArr.ContainsKey("accessory_desc1"))
                    ControlArr["accessory_desc1"] = value;
                else
                    ControlArr.Add("accessory_desc1", _accessory_desc1);
            }
            get { return _accessory_desc1; }
        }
        #endregion

        protected JS_INPUT _gift_imei4 = null;
        #region gift_imei4
        public JS_INPUT gift_imei4
        {
            set
            {
                _gift_imei4 = value;
                if (ControlArr.ContainsKey("gift_imei4"))
                    ControlArr["gift_imei4"] = value;
                else
                    ControlArr.Add("gift_imei4", _gift_imei4);
            }
            get { return _gift_imei4; }
        }
        #endregion

        protected JS_INPUT _gift_code4 = null;
        #region gift_code4
        public JS_INPUT gift_code4
        {
            set
            {
                _gift_code4 = value;
                if (ControlArr.ContainsKey("gift_code4"))
                    ControlArr["gift_code4"] = value;
                else
                    ControlArr.Add("gift_code4", _gift_code4);
            }
            get { return _gift_code4; }
        }
        #endregion

        protected JS_INPUT _gift_desc4 = null;
        #region gift_desc4
        public JS_INPUT gift_desc4
        {
            set
            {
                _gift_desc4 = value;
                if (ControlArr.ContainsKey("gift_desc4"))
                    ControlArr["gift_desc4"] = value;
                else
                    ControlArr.Add("gift_desc4", _gift_desc4);
            }
            get { return _gift_desc4; }
        }
        #endregion

        protected JS_SELECT _gift_desc41 = null;
        #region gift_desc41
        public JS_SELECT gift_desc41
        {
            set
            {
                _gift_desc41 = value;
                if (ControlArr.ContainsKey("gift_desc41"))
                    ControlArr["gift_desc41"] = value;
                else
                    ControlArr.Add("gift_desc41", _gift_desc41);
            }
            get { return _gift_desc41; }
        }
        #endregion

        protected JS_INPUT _gift_imei3 = null;
        #region gift_imei3
        public JS_INPUT gift_imei3
        {
            set
            {
                _gift_imei3 = value;
                if (ControlArr.ContainsKey("gift_imei3"))
                    ControlArr["gift_imei3"] = value;
                else
                    ControlArr.Add("gift_imei3", _gift_imei3);
            }
            get { return _gift_imei3; }
        }
        #endregion


        protected JS_INPUT _gift_code3 = null;
        #region gift_code3
        public JS_INPUT gift_code3
        {
            set
            {
                _gift_code3 = value;
                if (ControlArr.ContainsKey("gift_code3"))
                    ControlArr["gift_code3"] = value;
                else
                    ControlArr.Add("gift_code3", _gift_code3);
            }
            get { return _gift_code3; }
        }
        #endregion

        protected JS_INPUT _gift_desc3 = null;
        #region gift_desc3
        public JS_INPUT gift_desc3
        {
            set
            {
                _gift_desc3 = value;
                if (ControlArr.ContainsKey("gift_desc3"))
                    ControlArr["gift_desc3"] = value;
                else
                    ControlArr.Add("gift_desc3", _gift_desc3);
            }
            get { return _gift_desc3; }
        }
        #endregion


        protected JS_SELECT _gift_desc31 = null;
        #region gift_desc31
        public JS_SELECT gift_desc31
        {
            set
            {
                _gift_desc31 = value;
                if (ControlArr.ContainsKey("gift_desc31"))
                    ControlArr["gift_desc31"] = value;
                else
                    ControlArr.Add("gift_desc31", _gift_desc31);
            }
            get { return _gift_desc31; }
        }
        #endregion

        protected JS_INPUT _gift_imei2 = null;
        #region gift_imei2
        public JS_INPUT gift_imei2
        {
            set
            {
                _gift_imei2 = value;
                if (ControlArr.ContainsKey("gift_imei2"))
                    ControlArr["gift_imei2"] = value;
                else
                    ControlArr.Add("gift_imei2", _gift_imei2);
            }
            get { return _gift_imei2; }
        }
        #endregion


        protected JS_INPUT _gift_code2 = null;
        #region gift_code2
        public JS_INPUT gift_code2
        {
            set
            {
                _gift_code2 = value;
                if (ControlArr.ContainsKey("gift_code2"))
                    ControlArr["gift_code2"] = value;
                else
                    ControlArr.Add("gift_code2", _gift_code2);
            }
            get { return _gift_code2; }
        }
        #endregion


        protected JS_INPUT _gift_desc2 = null;
        #region gift_desc2
        public JS_INPUT gift_desc2
        {
            set
            {
                _gift_desc2 = value;
                if (ControlArr.ContainsKey("gift_desc2"))
                    ControlArr["gift_desc2"] = value;
                else
                    ControlArr.Add("gift_desc2", _gift_desc2);
            }
            get { return _gift_desc2; }
        }
        #endregion

        protected JS_SELECT _gift_desc21 = null;
        #region gift_desc21
        public JS_SELECT gift_desc21
        {
            set
            {
                _gift_desc21 = value;
                if (ControlArr.ContainsKey("gift_desc21"))
                    ControlArr["gift_desc21"] = value;
                else
                    ControlArr.Add("gift_desc21", _gift_desc21);
            }
            get { return _gift_desc21; }
        }
        #endregion

        protected JS_SELECT _gift_desc1 = null;
        #region gift_desc1
        public JS_SELECT gift_desc1
        {
            set
            {
                _gift_desc1 = value;
                if (ControlArr.ContainsKey("gift_desc1"))
                    ControlArr["gift_desc1"] = value;
                else
                    ControlArr.Add("gift_desc1", _gift_desc1);
            }
            get { return _gift_desc1; }
        }
        #endregion

        protected JS_INPUT _gift_imei = null;
        #region gift_imei
        public JS_INPUT gift_imei
        {
            set
            {
                _gift_imei = value;
                if (ControlArr.ContainsKey("gift_imei"))
                    ControlArr["gift_imei"] = value;
                else
                    ControlArr.Add("gift_imei", _gift_imei);
            }
            get { return _gift_imei; }
        }
        #endregion


        protected JS_INPUT _gift_code = null;
        #region gift_code
        public JS_INPUT gift_code
        {
            set
            {
                _gift_code = value;
                if (ControlArr.ContainsKey("gift_code"))
                    ControlArr["gift_code"] = value;
                else
                    ControlArr.Add("gift_code", _gift_code);
            }
            get { return _gift_code; }
        }
        #endregion

        protected JS_INPUT _gift_desc = null;
        #region gift_desc
        public JS_INPUT gift_desc
        {
            set
            {
                _gift_desc = value;
                if (ControlArr.ContainsKey("gift_desc"))
                    ControlArr["gift_desc"] = value;
                else
                    ControlArr.Add("gift_desc", _gift_desc);
            }
            get { return _gift_desc; }
        }
        #endregion

        protected JS_INPUT _extra_rebate = null;
        #region extra_rebate
        public JS_INPUT extra_rebate
        {
            set
            {
                _extra_rebate = value;
                if (ControlArr.ContainsKey("extra_rebate"))
                    ControlArr["extra_rebate"] = value;
                else
                    ControlArr.Add("extra_rebate", _extra_rebate);
            }
            get { return _extra_rebate; }
        }
        #endregion


        protected JS_INPUT _extra_rebate_amount3 = null;
        #region extra_rebate_amount3
        public JS_INPUT extra_rebate_amount3
        {
            set
            {
                _extra_rebate_amount3 = value;
                if (ControlArr.ContainsKey("extra_rebate_amount3"))
                    ControlArr["extra_rebate_amount3"] = value;
                else
                    ControlArr.Add("extra_rebate_amount3", _extra_rebate_amount3);
            }
            get { return _extra_rebate_amount3; }
        }
        #endregion

        protected JS_INPUT _extra_rebate_amount2 = null;
        #region extra_rebate_amount2
        public JS_INPUT extra_rebate_amount2
        {
            set
            {
                _extra_rebate_amount2 = value;
                if (ControlArr.ContainsKey("extra_rebate_amount2"))
                    ControlArr["extra_rebate_amount2"] = value;
                else
                    ControlArr.Add("extra_rebate_amount2", _extra_rebate_amount2);
            }
            get { return _extra_rebate_amount2; }
        }
        #endregion


        protected JS_INPUT _extra_rebate_amount1 = null;
        #region extra_rebate_amount1
        public JS_INPUT extra_rebate_amount1
        {
            set
            {
                _extra_rebate_amount1 = value;
                if (ControlArr.ContainsKey("extra_rebate_amount1"))
                    ControlArr["extra_rebate_amount1"] = value;
                else
                    ControlArr.Add("extra_rebate_amount1", _extra_rebate_amount1);
            }
            get { return _extra_rebate_amount1; }
        }
        #endregion


        protected JS_INPUT _extra_rebate_amount = null;
        #region extra_rebate_amount
        public JS_INPUT extra_rebate_amount
        {
            set
            {
                _extra_rebate_amount = value;
                if (ControlArr.ContainsKey("extra_rebate_amount"))
                    ControlArr["extra_rebate_amount"] = value;
                else
                    ControlArr.Add("extra_rebate_amount", _extra_rebate_amount);
            }
            get { return _extra_rebate_amount; }
        }
        #endregion

        protected JS_INPUT _r_offer2 = null;
        #region r_offer2
        public JS_INPUT r_offer2
        {
            set
            {
                _r_offer2 = value;
                if (ControlArr.ContainsKey("r_offer2"))
                    ControlArr["r_offer2"] = value;
                else
                    ControlArr.Add("r_offer2", _r_offer2);
            }
            get { return _r_offer2; }
        }
        #endregion

        protected JS_INPUT _r_offer1 = null;
        #region r_offer1
        public JS_INPUT r_offer1
        {
            set
            {
                _r_offer1 = value;
                if (ControlArr.ContainsKey("r_offer1"))
                    ControlArr["r_offer1"] = value;
                else
                    ControlArr.Add("r_offer1", _r_offer1);
            }
            get { return _r_offer1; }
        }
        #endregion

        protected JS_INPUT _r_offer = null;
        #region r_offer
        public JS_INPUT r_offer
        {
            set
            {
                _r_offer = value;
                if (ControlArr.ContainsKey("r_offer"))
                    ControlArr["r_offer"] = value;
                else
                    ControlArr.Add("r_offer", _r_offer);
            }
            get { return _r_offer; }
        }
        #endregion

        protected JS_INPUT _rebate_amount3 = null;
        #region rebate_amount3
        public JS_INPUT rebate_amount3
        {
            set
            {
                _rebate_amount3 = value;
                if (ControlArr.ContainsKey("rebate_amount3"))
                    ControlArr["rebate_amount3"] = value;
                else
                    ControlArr.Add("rebate_amount3", _rebate_amount3);
            }
            get { return _rebate_amount3; }
        }
        #endregion

        protected JS_INPUT _rebate_amount2 = null;
        #region rebate_amount2
        public JS_INPUT rebate_amount2
        {
            set
            {
                _rebate_amount2 = value;
                if (ControlArr.ContainsKey("rebate_amount2"))
                    ControlArr["rebate_amount2"] = value;
                else
                    ControlArr.Add("rebate_amount2", _rebate_amount2);
            }
            get { return _rebate_amount2; }
        }
        #endregion


        protected JS_INPUT _rebate_amount1 = null;
        #region rebate_amount1
        public JS_INPUT rebate_amount1
        {
            set
            {
                _rebate_amount1 = value;
                if (ControlArr.ContainsKey("rebate_amount1"))
                    ControlArr["rebate_amount1"] = value;
                else
                    ControlArr.Add("rebate_amount1", _rebate_amount1);
            }
            get { return _rebate_amount1; }
        }
        #endregion

        protected JS_INPUT _rebate_amount = null;
        #region rebate_amount
        public JS_INPUT rebate_amount
        {
            set
            {
                _rebate_amount = value;
                if (ControlArr.ContainsKey("rebate_amount"))
                    ControlArr["rebate_amount"] = value;
                else
                    ControlArr.Add("rebate_amount", _rebate_amount);
            }
            get { return _rebate_amount; }
        }
        #endregion

        protected JS_INPUT _sku = null;
        #region sku
        public JS_INPUT sku
        {
            set
            {
                _sku = value;
                if (ControlArr.ContainsKey("sku"))
                    ControlArr["sku"] = value;
                else
                    ControlArr.Add("sku", _sku);
            }
            get { return _sku; }
        }
        #endregion

        protected JS_SELECT _card_exp_year = null;
        #region card_exp_year
        public JS_SELECT card_exp_year
        {
            set
            {
                _card_exp_year = value;
                if (ControlArr.ContainsKey("card_exp_year"))
                    ControlArr["card_exp_year"] = value;
                else
                    ControlArr.Add("card_exp_year", _card_exp_year);
            }
            get { return _card_exp_year; }
        }
        #endregion

        protected JS_SELECT _card_exp_month = null;
        #region card_exp_month
        public JS_SELECT card_exp_month
        {
            set
            {
                _card_exp_month = value;
                if (ControlArr.ContainsKey("card_exp_month"))
                    ControlArr["card_exp_month"] = value;
                else
                    ControlArr.Add("card_exp_month", _card_exp_month);
            }
            get { return _card_exp_month; }
        }
        #endregion

        protected JS_SELECT _card_type = null;
        #region card_type
        public JS_SELECT card_type
        {
            set
            {
                _card_type = value;
                if (ControlArr.ContainsKey("card_type"))
                    ControlArr["card_type"] = value;
                else
                    ControlArr.Add("card_type", _card_type);
            }
            get { return _card_type; }
        }
        #endregion

        protected JS_INPUT _go_wireless_package_code = null;
        #region go_wireless_package_code
        public JS_INPUT go_wireless_package_code
        {
            set
            {
                _go_wireless_package_code = value;
                if (ControlArr.ContainsKey("go_wireless_package_code"))
                    ControlArr["go_wireless_package_code"] = value;
                else
                    ControlArr.Add("go_wireless_package_code", _go_wireless_package_code);
            }
            get { return _go_wireless_package_code; }
        }
        #endregion

        protected JS_INPUT _lob_ac = null;
        #region lob_ac
        public JS_INPUT lob_ac
        {
            set
            {
                _lob_ac = value;
                if (ControlArr.ContainsKey("lob_ac"))
                    ControlArr["lob_ac"] = value;
                else
                    ControlArr.Add("lob_ac", _lob_ac);
            }
            get { return _lob_ac; }
        }
        #endregion

        protected JS_SELECT _lob = null;
        #region lob
        public JS_SELECT lob
        {
            set
            {
                _lob = value;
                if (ControlArr.ContainsKey("lob"))
                    ControlArr["lob"] = value;
                else
                    ControlArr.Add("lob", _lob);
            }
            get { return _lob; }
        }
        #endregion

        protected JS_SELECT _go_wireless = null;
        #region go_wireless
        public JS_SELECT go_wireless 
        {
            set
            {
                _go_wireless = value;
                if (ControlArr.ContainsKey("go_wireless"))
                    ControlArr["go_wireless"] = value;
                else
                    ControlArr.Add("go_wireless", _go_wireless);
            }
            get { return _go_wireless; }
        }
        #endregion

        protected JS_SELECT _bank_code = null;
        #region bank_code
        public JS_SELECT bank_code
        {
            set
            {
                _bank_code = value;
                if (ControlArr.ContainsKey("bank_code"))
                    ControlArr["bank_code"] = value;
                else
                    ControlArr.Add("bank_code", _bank_code);
            }
            get { return _bank_code; }
        }
        #endregion

        protected JS_SELECT _pay_method = null;
        #region pay_method
        public JS_SELECT pay_method
        {
            set
            {
                _pay_method = value;
                if (ControlArr.ContainsKey("pay_method"))
                    ControlArr["pay_method"] = value;
                else
                    ControlArr.Add("pay_method", _pay_method);
            }
            get { return _pay_method; }
        }
        #endregion

        protected JS_SELECT _d_time = null;
        #region d_time
        public JS_SELECT d_time
        {
            set
            {
                _d_time = value;
                if (ControlArr.ContainsKey("d_time"))
                    ControlArr["d_time"] = value;
                else
                    ControlArr.Add("d_time", _d_time);
            }
            get { return _d_time; }
        }
        #endregion

        protected JS_SELECT _d_district = null;
        #region d_district
        public JS_SELECT d_district
        {
            set
            {
                _d_district = value;
                if (ControlArr.ContainsKey("d_district"))
                    ControlArr["d_district"] = value;
                else
                    ControlArr.Add("d_district", _d_district);
            }
            get { return _d_district; }
        }
        #endregion

        protected JS_SELECT _aig_gift = null;
        #region aig_gift
        public JS_SELECT aig_gift
        {
            set
            {
                _aig_gift = value;
                if (ControlArr.ContainsKey("aig_gift"))
                    ControlArr["aig_gift"] = value;
                else
                    ControlArr.Add("aig_gift", _aig_gift);
            }
            get { return _aig_gift; }
        }
        #endregion

        protected JS_SELECT _extra_rebate4 = null;
        #region extra_rebate4
        public JS_SELECT extra_rebate4
        {
            set
            {
                _extra_rebate4 = value;
                if (ControlArr.ContainsKey("extra_rebate4"))
                    ControlArr["extra_rebate4"] = value;
                else
                    ControlArr.Add("extra_rebate4", _extra_rebate4);
            }
            get { return _extra_rebate4; }
        }
        #endregion

        protected JS_SELECT _extra_rebate_amount4 = null;
        #region extra_rebate_amount4
        public JS_SELECT extra_rebate_amount4
        {
            set
            {
                _extra_rebate_amount4 = value;
                if (ControlArr.ContainsKey("extra_rebate_amount4"))
                    ControlArr["extra_rebate_amount4"] = value;
                else
                    ControlArr.Add("extra_rebate_amount4", _extra_rebate_amount4);
            }
            get { return _extra_rebate_amount4; }
        }
        #endregion

        protected JS_SELECT _r_offer4 = null;
        #region r_offer4
        public JS_SELECT r_offer4
        {
            set
            {
                _r_offer4 = value;
                if (ControlArr.ContainsKey("r_offer4"))
                    ControlArr["r_offer4"] = value;
                else
                    ControlArr.Add("r_offer4", _r_offer4);
            }
            get { return _r_offer4; }
        }
        #endregion

        protected JS_SELECT _rebate_amount4 = null;
        #region rebate_amount4
        public JS_SELECT rebate_amount4
        {
            set
            {
                _rebate_amount4 = value;
                if (ControlArr.ContainsKey("rebate_amount4"))
                    ControlArr["rebate_amount4"] = value;
                else
                    ControlArr.Add("rebate_amount4", _rebate_amount4);
            }
            get { return _rebate_amount4; }
        }
        #endregion

        protected JS_SELECT _bundle_name = null;
        #region bundle_name
        public JS_SELECT bundle_name
        {
            set
            {
                _bundle_name = value;
                if (ControlArr.ContainsKey("bundle_name"))
                    ControlArr["bundle_name"] = value;
                else
                    ControlArr.Add("bundle_name", _bundle_name);
            }
            get { return _bundle_name; }
        }
        #endregion

        protected JS_SELECT _trade_field = null;
        #region trade_field
        public JS_SELECT trade_field
        {
            set
            {
                _trade_field = value;
                if (ControlArr.ContainsKey("trade_field"))
                    ControlArr["trade_field"] = value;
                else
                    ControlArr.Add("trade_field", _trade_field);
            }
            get { return _trade_field; }
        }
        #endregion

        protected JS_SELECT _s_premium2 = null;
        #region s_premium2
        public JS_SELECT s_premium2
        {
            set
            {
                _s_premium2 = value;
                if (ControlArr.ContainsKey("s_premium2"))
                    ControlArr["s_premium2"] = value;
                else
                    ControlArr.Add("s_premium2", _s_premium2);
            }
            get { return _s_premium2; }
        }
        #endregion

        protected JS_SELECT _s_premium = null;
        #region s_premium
        public JS_SELECT s_premium
        {
            set
            {
                _s_premium = value;
                if (ControlArr.ContainsKey("s_premium"))
                    ControlArr["s_premium"] = value;
                else
                    ControlArr.Add("s_premium", _s_premium);
            }
            get { return _s_premium; }
        }
        #endregion

        protected JS_SELECT _premium = null;
        #region premium
        public JS_SELECT premium
        {
            set
            {
                _premium = value;
                if (ControlArr.ContainsKey("premium"))
                    ControlArr["premium"] = value;
                else
                    ControlArr.Add("premium", _premium);
            }
            get { return _premium; }
        }
        #endregion

        protected JS_SELECT _hs_model = null;
        #region hs_model
        public JS_SELECT hs_model
        {
            set
            {
                _hs_model = value;
                if (ControlArr.ContainsKey("hs_model"))
                    ControlArr["hs_model"] = value;
                else
                    ControlArr.Add("hs_model", _hs_model);
            }
            get { return _hs_model; }
        }
        #endregion

        protected JS_SELECT _free_mon = null;
        #region free_mon
        public JS_SELECT free_mon
        {
            set
            {
                _free_mon = value;
                if (ControlArr.ContainsKey("free_mon"))
                    ControlArr["free_mon"] = value;
                else
                    ControlArr.Add("free_mon", _free_mon);
            }
            get { return _free_mon; }
        }
        #endregion

        protected JS_SELECT _rebate = null;
        #region rebate
        public JS_SELECT rebate
        {
            set
            {
                _rebate = value;
                if (ControlArr.ContainsKey("rebate"))
                    ControlArr["rebate"] = value;
                else
                    ControlArr.Add("rebate", _rebate);
            }
            get { return _rebate; }
        }
        #endregion

        protected JS_SELECT _con_per = null;
        #region con_per
        public JS_SELECT con_per
        {
            set
            {
                _con_per = value;
                if (ControlArr.ContainsKey("con_per"))
                    ControlArr["con_per"] = value;
                else
                    ControlArr.Add("con_per", _con_per);
            }
            get { return _con_per; }
        }
        #endregion

        protected JS_SELECT _rate_plan = null;
        #region rate_plan
        public JS_SELECT rate_plan
        {
            set
            {
                _rate_plan = value;
                if (ControlArr.ContainsKey("rate_plan"))
                    ControlArr["rate_plan"] = value;
                else
                    ControlArr.Add("rate_plan", _rate_plan);
            }
            get { return _rate_plan; }
        }
        #endregion

        protected JS_SELECT _tier = null;
        #region tier
        public JS_SELECT tier
        {
            set
            {
                _tier = value;
                if (ControlArr.ContainsKey("tier"))
                    ControlArr["tier"] = value;
                else
                    ControlArr.Add("tier", _tier);
            }
            get { return _tier; }
        }
        #endregion

        protected JS_SELECT _plan_fee= null;
        #region plan_fee
        public JS_SELECT plan_fee
        {
            set
            {
                _plan_fee = value;
                if (ControlArr.ContainsKey("plan_fee"))
                    ControlArr["plan_fee"] = value;
                else
                    ControlArr.Add("plan_fee", _plan_fee);
            }
            get { return _plan_fee; }
        }
        #endregion

        protected JS_SELECT _program = null;
        #region program
        public JS_SELECT program
        {
            set
            {
                _program = value;
                if (ControlArr.ContainsKey("program"))
                    ControlArr["program"] = value;
                else
                    ControlArr.Add("program", _program);
            }
            get { return _program; }
        }
        #endregion

        protected JS_INPUT _action_required2 = null;
        #region action_required2
        public JS_INPUT action_required2
        {
            set
            {
                _action_required2 = value;
                if (ControlArr.ContainsKey("action_required2"))
                    ControlArr["action_required2"] = value;
                else
                    ControlArr.Add("action_required2", _action_required2);
            }
            get
            {
                return _action_required2;
            }
        }
        #endregion

        protected JS_INPUT _action_required = null;
        #region action_required
        public JS_INPUT action_required
        {
            set
            {
                _action_required = value;
                if (ControlArr.ContainsKey("action_required"))
                    ControlArr["action_required"] = value;
                else
                    ControlArr.Add("action_required", _action_required);
            }
            get
            {
                return _action_required;
            }
        }
        #endregion

        protected JS_SELECT _id_type = null;
        #region id_type
        public JS_SELECT id_type
        {
            set
            {
                _id_type = value;
                if (ControlArr.ContainsKey("id_type"))
                    ControlArr["id_type"] = value;
                else
                    ControlArr.Add("id_type", _id_type);
            }
            get { return _id_type; }
        }
        #endregion

        protected JS_INPUT _id_type1 = null;
        #region id_type1
        public JS_INPUT id_type1
        {
            set
            {
                _id_type1 = value;
                if (ControlArr.ContainsKey("id_type1"))
                    ControlArr["id_type1"] = value;
                else
                    ControlArr.Add("id_type1", _id_type1);
            }
            get { return _id_type1; }
        }
        #endregion

        protected JS_INPUT _hkid2 = null;
        #region hkid2
        public JS_INPUT hkid2
        {
            set
            {
                _hkid2 = value;
                if (ControlArr.ContainsKey("hkid2"))
                    ControlArr["hkid2"] = value;
                else
                    ControlArr.Add("hkid2", _hkid2);
            }
            get { return _hkid2; }
        }
        #endregion

        protected JS_INPUT _hkid = null;
        #region hkid
        public JS_INPUT hkid
        {
            set
            {
                _hkid = value;
                if (ControlArr.ContainsKey("hkid"))
                    ControlArr["hkid"] = value;
                else
                    ControlArr.Add("hkid", _hkid);
            }
            get { return _hkid; }
        }
        #endregion

        protected JS_INPUT _cust_name = null;
        #region cust_name
        public JS_INPUT cust_name
        {
            set
            {
                _cust_name = value;
                if (ControlArr.ContainsKey("cust_name"))
                    ControlArr["cust_name"] = value;
                else
                    ControlArr.Add("cust_name", _cust_name);
            }
            get { return _cust_name; }
        }
        #endregion


        protected JS_INPUT _family_name = null;
        #region family_name
        public JS_INPUT family_name
        {
            set
            {
                _family_name = value;
                if (ControlArr.ContainsKey("family_name"))
                    ControlArr["family_name"] = value;
                else
                    ControlArr.Add("family_name", _family_name);
            }
            get { return _family_name; }
        }
        #endregion

        protected JS_INPUT _given_name = null;
        #region given_name
        public JS_INPUT given_name
        {
            set
            {
                _given_name = value;
                if (ControlArr.ContainsKey("given_name"))
                    ControlArr["given_name"] = value;
                else
                    ControlArr.Add("given_name", _given_name);
            }
            get { return _given_name; }
        }
        #endregion


        protected JS_SELECT _exist_cust_plan = null;
        #region exist_cust_plan
        public JS_SELECT exist_cust_plan
        {
            set
            {
                _exist_cust_plan = value;
                if (ControlArr.ContainsKey("exist_cust_plan"))
                    ControlArr["exist_cust_plan"] = value;
                else
                    ControlArr.Add("exist_cust_plan", _exist_cust_plan);
            }
            get { return _exist_cust_plan; }
        }
        #endregion

        protected JS_SELECT _org_fee = null;
        #region org_fee
        public JS_SELECT org_fee
        {
            set
            {
                _org_fee = value;
                if (ControlArr.ContainsKey("org_fee"))
                    ControlArr["org_fee"] = value;
                else
                    ControlArr.Add("org_fee", _org_fee);
            }
            get { return _org_fee; }
        }
        #endregion

        #region ToScript
        public string ToScript()
        {
            return this.ToScript(true,true);
        }

        public string ToScript(bool x_bClearHist,bool x_bIncludeScript)
        {
            JSStringBuilder _oScript = new JSStringBuilder();
            foreach (KeyValuePair<string, object> _oControl in ControlArr)
            {
                IJSControl _oJSControl = (IJSControl)_oControl.Value;
                _oScript.AppendLine(_oJSControl.ToScript(x_bClearHist, x_bIncludeScript));
            }
            return _oScript.ToString();
        }
        #endregion

        public void SetRunRegistorJS(bool x_bRun)
        {
            foreach (KeyValuePair<string, object> _oControl in ControlArr)
            {
                ((IJSControl)_oControl.Value).RunRegistorJS = x_bRun;
            }
        }
    }
}
