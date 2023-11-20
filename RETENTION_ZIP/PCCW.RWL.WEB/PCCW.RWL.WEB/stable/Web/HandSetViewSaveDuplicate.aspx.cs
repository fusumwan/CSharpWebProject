using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK.STOCK;


public partial class HandSetViewSaveDuplicate : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , Request.ApplicationPath);

        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();
    }

    protected void InitFrame()
    {

    }

    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    public ObjectArr IssueTypeDataBind()
    {
        return BusinessTradeBal.GetIssueTypeList(true);
    }

    protected void hs_view_form_DataBound(object sender, EventArgs e)
    {
        if (hs_view_form.CurrentMode == FormViewMode.ReadOnly)
        {
            Button _oDUPLICATE = (Button)hs_view_form.FindControl("DUPLICATE");
            if (_oDUPLICATE != null){
                if ("65535".Equals(RWLFramework.CurrentUser[this.Page].Lv) || "20".Equals(RWLFramework.CurrentUser[this.Page].Lv))
                    _oDUPLICATE.Visible = true;
                else
                    _oDUPLICATE.Visible = false;
            }

            Literal _oNormal_rebate_type = (Literal)hs_view_form.FindControl("normal_rebate_type");
            


            Literal _oOffer_type_id = (Literal)hs_view_form.FindControl("offer_type_id");
            HandSetOfferTypeEntity[] _oOfferTypeIdList = HandSetOfferTypeBal.GetArrayObj(GetDB(), "active=1", null, "id asc");
            if (_oOfferTypeIdList != null)
            {
                for (int i = 0; i < _oOfferTypeIdList.Length; i++)
                {
                    int _iOffer_type_id;
                    if (!string.IsNullOrEmpty(_oOffer_type_id.Text) && int.TryParse(_oOffer_type_id.Text,out _iOffer_type_id))
                    {
                        if (_iOffer_type_id == _oOfferTypeIdList[i].id)
                        {
                            _oOffer_type_id.Text = _oOfferTypeIdList[i].name.ToString();
                        }
                    }
                }
            }
        }
        else if (hs_view_form.CurrentMode == FormViewMode.Edit || hs_view_form.CurrentMode == FormViewMode.Insert)
        {
            Literal _oPlan_fee = (Literal)hs_view_form.FindControl("plan_fee");
            DropDownList _oPlan_feeList = (DropDownList)hs_view_form.FindControl("plan_fee1");
            _oPlan_feeList.Items.Clear();
            _oPlan_feeList.Items.Add(new ListItem(string.Empty, string.Empty));
            List<string> _sPlanFeeList = BusinessTradeBal.DrpPlanFeeList();
            for (int i = 0; i < _sPlanFeeList.Count; i++)
                _oPlan_feeList.Items.Add(new ListItem(_sPlanFeeList[i].ToString(), _sPlanFeeList[i].ToString()));

            Literal _oNormal_rebate_type_value = (Literal)hs_view_form.FindControl("normal_rebate_type_value");
            DropDownList _oNormal_rebate_type = (DropDownList)hs_view_form.FindControl("normal_rebate_type");

            DropDownList _oIssue_typeList = (DropDownList)hs_view_form.FindControl("issue_type1");
            
            

            Literal _oRebate_gp = (Literal)hs_view_form.FindControl("rebate_gp");
            DropDownList _oRebate_gpList = (DropDownList)hs_view_form.FindControl("rebate_gp1");
            _oRebate_gpList.Items.Clear();
            _oRebate_gpList.Items.Add(new ListItem(string.Empty, string.Empty));
            List<string> _sRebate_gpList = RebateGroupBal.DrpRebateGpList();
            for (int i = 0; i < _sRebate_gpList.Count; i++)
                _oRebate_gpList.Items.Add(new ListItem(_sRebate_gpList[i].ToString(), _sRebate_gpList[i].ToString()));

            TextBox _oCon_per = (TextBox)hs_view_form.FindControl("con_per");
            DropDownList _oCon_per1List = (DropDownList)hs_view_form.FindControl("con_per1");
            _oCon_per1List.Items.Clear();
            _oCon_per1List.Items.Add(new ListItem(string.Empty, string.Empty));
            List<string> _sCon_perList = HandSetOfferedBasketBal.DrpCon_perList();
            for (int i = 0; i < _sCon_perList.Count; i++)
                _oCon_per1List.Items.Add(new ListItem(_sCon_perList[i].ToString(), _sCon_perList[i].ToString()));

            Literal _oHs_model = (Literal)hs_view_form.FindControl("hs_model");
            DropDownList _oHs_modelList = (DropDownList)hs_view_form.FindControl("hs_model1");
            _oHs_modelList.Items.Clear();
            _oHs_modelList.Items.Add(new ListItem(string.Empty, string.Empty));
            List<string> _sHsModelList = ProductItemCodeBal.DrpHsmodelList("HS",null);
            for (int i = 0; i < _sHsModelList.Count; i++)
                _oHs_modelList.Items.Add(new ListItem(_sHsModelList[i].ToString(), _sHsModelList[i].ToString()));


            HiddenField _oOffer_type_id = (HiddenField)hs_view_form.FindControl("offer_type_id");
            DropDownList _oOffer_type_id1 = (DropDownList)hs_view_form.FindControl("offer_type_id1");
            HandSetOfferTypeEntity[] _oOfferTypeIdList = HandSetOfferTypeBal.GetArrayObj(GetDB(), "active=1", null, "id asc");
            _oOffer_type_id1.Items.Clear();
            if (_oOfferTypeIdList != null)
            {
                for (int i = 0; i < _oOfferTypeIdList.Length; i++)
                    _oOffer_type_id1.Items.Add(new ListItem(_oOfferTypeIdList[i].name.ToString(), _oOfferTypeIdList[i].id.ToString()));
            }

            TextBox _oPremium = (TextBox)hs_view_form.FindControl("premium");
            DropDownList _oPremiumList = (DropDownList)hs_view_form.FindControl("premium1");
            List<string> _sPremiumList = ProductItemCodeBal.DrpHsmodelList("PMU",null);
            _oPremiumList.Items.Clear();
            _oPremiumList.Items.Add(new ListItem("",""));
            for (int i = 0; i<_sPremiumList.Count; i++)
                _oPremiumList.Items.Add(new ListItem(_sPremiumList[i].ToString(), _sPremiumList[i].ToString()));

            Literal _oPayment= (Literal)hs_view_form.FindControl("payment");
            RadioButtonList _oPaymentList = (RadioButtonList)hs_view_form.FindControl("payment1");


            if (hs_view_form.CurrentMode == FormViewMode.Insert){
                HandSetOfferedBasket _oHandSetOfferedBasket = new HandSetOfferedBasket(SYSConn<MSSQLConnect>.Connect(), WebFunc.qsMid);
                if (_oHandSetOfferedBasket.GetFound())
                {
                    _oNormal_rebate_type.Text= _oHandSetOfferedBasket.GetNormal_rebate_type();
                    _oPlan_fee.Text = _oHandSetOfferedBasket.GetPlan_fee();
                    _oRebate_gp.Text = _oHandSetOfferedBasket.GetRebate_gp();
                    _oCon_per.Text = _oHandSetOfferedBasket.GetCon_per();
                    _oHs_model.Text = _oHandSetOfferedBasket.GetHs_model();
                    _oPayment.Text = _oHandSetOfferedBasket.GetPayment();
                   
                    TextBox _oRebate_amount = (TextBox)hs_view_form.FindControl("rebate_amount");
                    TextBox _oR_offer = (TextBox)hs_view_form.FindControl("r_offer");
                    TextBox _oExtra_rebate_amount = (TextBox)hs_view_form.FindControl("extra_rebate_amount");
                    TextBox _oExtra_rebate = (TextBox)hs_view_form.FindControl("extra_rebate");
                    TextBox _oAmount = (TextBox)hs_view_form.FindControl("amount");
                    TextBox _oSdate = (TextBox)hs_view_form.FindControl("sdate");
                    TextBox _oEdate = (TextBox)hs_view_form.FindControl("edate");

                    _oRebate_amount.Text = _oHandSetOfferedBasket.GetRebate_amount().Trim();
                    _oR_offer.Text = _oHandSetOfferedBasket.GetR_offer().Trim();
                    _oExtra_rebate_amount.Text = _oHandSetOfferedBasket.GetExtra_rebate_amount().Trim();
                    _oExtra_rebate.Text = _oHandSetOfferedBasket.GetExtra_rebate().Trim();
                    _oAmount.Text = _oHandSetOfferedBasket.GetAmount().Trim();
                    _oSdate.Text = (_oHandSetOfferedBasket.GetSdate() != null) ? ((DateTime)_oHandSetOfferedBasket.GetSdate()).ToString("dd/MM/yyyy") : "";
                    //_oSdate.Text = ((DateTime)_oHandSetOfferedBasket.GetSdate()).ToString("dd/MM/yyyy");
                    _oEdate.Text = (_oHandSetOfferedBasket.GetEdate() != null) ? ((DateTime)_oHandSetOfferedBasket.GetEdate()).ToString("dd/MM/yyyy") : "";
                    //_oEdate.Text = ((DateTime)_oHandSetOfferedBasket.GetEdate()).ToString("dd/MM/yyyy");
                    _oOffer_type_id.Value = _oHandSetOfferedBasket.GetOffer_type_id().ToString();
                    _oPremium.Text = _oHandSetOfferedBasket.GetPremium().Trim();
                    _oIssue_typeList.SelectedValue = _oHandSetOfferedBasket.GetIssue_type();
                }
            }else if(hs_view_form.CurrentMode == FormViewMode.Edit){

                TextBox _amount = (TextBox)hs_view_form.FindControl("amount");
                _amount.Attributes.Add("readonly", "true");
            }
            _oNormal_rebate_type_value.Text = _oNormal_rebate_type.SelectedValue;

            if (_oOffer_type_id1.Items.FindByValue(_oOffer_type_id.Value) != null) _oOffer_type_id1.SelectedValue = _oOffer_type_id.Value;
            if (_oPremiumList.Items.FindByValue(_oPremium.Text) != null) _oPremiumList.SelectedValue = _oPremium.Text;
            if (_oPlan_feeList.Items.FindByValue(_oPlan_fee.Text) != null) _oPlan_feeList.SelectedValue = _oPlan_fee.Text;
            if (_oRebate_gpList.Items.FindByValue(_oRebate_gp.Text) != null) _oRebate_gpList.SelectedValue = _oRebate_gp.Text;
            if (_oCon_per1List.Items.FindByValue(_oCon_per.Text.ToString()) != null) _oCon_per1List.SelectedValue = _oCon_per.Text;
            if (_oHs_modelList.Items.FindByValue(_oHs_model.Text.ToString()) != null) _oHs_modelList.SelectedValue = _oHs_model.Text;
            if (_oPaymentList.Items.FindByValue(_oPayment.Text.ToString()) != null) _oPaymentList.SelectedValue = _oPayment.Text;

        }
    }
    protected void hs_view_form_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        if (e.CommandName == "Edit")
        {
            hs_view_form.ChangeMode(FormViewMode.Edit);
        }
        else if (e.CommandName == "View")
        {
            hs_view_form.ChangeMode(FormViewMode.ReadOnly);
        }
        else if (e.CommandName == "Save")
        {
            Literal _oPlan_fee = (Literal)hs_view_form.FindControl("plan_fee");
            DropDownList _oPlan_feeList = (DropDownList)hs_view_form.FindControl("plan_fee1");

            DropDownList _oNormal_rebate_type = (DropDownList)hs_view_form.FindControl("normal_rebate_type");
            DropDownList _oIssue_typeList = (DropDownList)hs_view_form.FindControl("issue_type1");
            
            Literal _oRebate_gp = (Literal)hs_view_form.FindControl("rebate_gp");
            DropDownList _oRebate_gpList = (DropDownList)hs_view_form.FindControl("rebate_gp1");

            DropDownList _oCon_per1List = (DropDownList)hs_view_form.FindControl("con_per1");
            TextBox _oCon_per = (TextBox)hs_view_form.FindControl("con_per");

            DropDownList _oHs_modelList = (DropDownList)hs_view_form.FindControl("hs_model1");
            Literal _oHs_model = (Literal)hs_view_form.FindControl("hs_model");

            HiddenField _oOffer_type_id = (HiddenField)hs_view_form.FindControl("offer_type_id");
            DropDownList _oOffer_type_id1 = (DropDownList)hs_view_form.FindControl("offer_type_id1");

            TextBox _oPremium = (TextBox)hs_view_form.FindControl("premium");
            DropDownList _oPremiumList = (DropDownList)hs_view_form.FindControl("premium1");

            RadioButtonList _oPaymentList = (RadioButtonList)hs_view_form.FindControl("payment1");

            TextBox _oRebate_amount = (TextBox)hs_view_form.FindControl("rebate_amount");


            TextBox _oR_offer = (TextBox)hs_view_form.FindControl("r_offer");

            
            TextBox _oExtra_rebate_amount = (TextBox)hs_view_form.FindControl("extra_rebate_amount");


            TextBox _oExtra_rebate = (TextBox)hs_view_form.FindControl("extra_rebate");


            TextBox _oAmount = (TextBox)hs_view_form.FindControl("amount");


            TextBox _oSdate = (TextBox)hs_view_form.FindControl("sdate");
            TextBox _oEdate = (TextBox)hs_view_form.FindControl("edate");
            Literal _oMid = (Literal)hs_view_form.FindControl("mid");
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory(rec_no, rebate_gp, plan_fee, normal_rebate_type, con_per, hs_model, offer_type_id, premium, r_offer, rebate_amount, amount, extra_rebate, extra_rebate_amount, payment, sdate, edate, item_code, active, cid, cdate) ");
            _oQuery.Append(" SELECT mid, rebate_gp, plan_fee, normal_rebate_type, con_per, hs_model, offer_type_id, premium, r_offer, rebate_amount, amount, extra_rebate, extra_rebate_amount, payment, sdate, edate, item_code, active, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate() FROM " + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket ");
            _oQuery.Append(" WHERE mid='" + _oMid.Text + "'");
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
            HandSetOfferedBasket _oHandSetOfferedBasket = (HandSetOfferedBasket)HandSetOfferedBasketRepository.CreateEntityInstanceObject();
            _oHandSetOfferedBasket.SetMid(Convert.ToInt32(_oMid.Text.Trim()));
            _oHandSetOfferedBasket.Retrieve();
            
            _oHandSetOfferedBasket.SetPlan_fee(_oPlan_feeList.SelectedValue.ToString());
            _oHandSetOfferedBasket.SetNormal_rebate_type(_oNormal_rebate_type.SelectedValue);

            _oHandSetOfferedBasket.SetRebate_gp(_oRebate_gpList.SelectedValue.ToString());
            _oHandSetOfferedBasket.SetCon_per(_oCon_per1List.SelectedValue.ToString());
            _oHandSetOfferedBasket.SetHs_model(_oHs_modelList.SelectedValue.ToString());
            _oHandSetOfferedBasket.SetOffer_type_id(int.Parse(_oOffer_type_id1.SelectedValue.ToString()));
            _oHandSetOfferedBasket.SetPremium(_oPremiumList.SelectedValue.ToString());
            _oHandSetOfferedBasket.SetPayment(_oPaymentList.SelectedValue);
            _oHandSetOfferedBasket.SetRebate_amount(_oRebate_amount.Text);
            _oHandSetOfferedBasket.SetR_offer(_oR_offer.Text);
            _oHandSetOfferedBasket.SetExtra_rebate_amount(_oExtra_rebate_amount.Text);
            _oHandSetOfferedBasket.SetExtra_rebate(_oExtra_rebate.Text);
            _oHandSetOfferedBasket.SetAmount(_oAmount.Text);
            _oHandSetOfferedBasket.SetIssue_type(_oIssue_typeList.SelectedValue);

            if (!"".Equals(_oSdate.Text.Trim())) _oHandSetOfferedBasket.SetSdate(WebFunc.DateTimeConvert(_oSdate.Text.Trim(),(new string[]{"d/M/yyyy","d/MM/yyyy","dd/MM/yyyy"})  ));
            if (!"".Equals(_oEdate.Text.Trim())) _oHandSetOfferedBasket.SetEdate(WebFunc.DateTimeConvert(_oEdate.Text.Trim(), (new string[] { "d/M/yyyy", "d/MM/yyyy", "dd/MM/yyyy" })));
            using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
            using (ITransaction _oTransaction = _oSession.BeginTransaction())
            {
                _oSession.Update(_oHandSetOfferedBasket);
                _oTransaction.Commit();
            }
            
            hs_view_source.DataBind();
            hs_view_form.DataBind();
            hs_view_form.ChangeMode(FormViewMode.ReadOnly);
        }
        else if (e.CommandName == "Duplicate"){
            hs_view_form.ChangeMode(FormViewMode.Insert);
            HandSetOfferedBasket _oHandSetOfferedBasket = (HandSetOfferedBasket)HandSetOfferedBasketRepository.CreateEntityInstanceObject();
            _oHandSetOfferedBasket.SetMid(WebFunc.qsMid);
            _oHandSetOfferedBasket.Retrieve();
            //HandSetOfferedBasket _oHandSetOfferedBasket = new HandSetOfferedBasket(GetDB(),WebFunc.qsMid);
            if (_oHandSetOfferedBasket.GetFound())
            {

            }
        }
        else if (e.CommandName == "Back" && Session["HandSetViewImplement_link"] != null){
            if (!"".Equals(Session["HandSetViewImplement_link"])) Response.Redirect(Session["HandSetViewImplement_link"].ToString());
        }
    }
    protected void hs_view_source_Init(object sender, EventArgs e)
    {
        hs_view_source.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
    protected void hs_view_form_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        HandSetOfferedBasket _oHandSetOfferedBasket = (HandSetOfferedBasket)HandSetOfferedBasketRepository.CreateEntityInstanceObject();
        _oHandSetOfferedBasket.SetPlan_fee(e.Values["plan_fee"].ToString());

        _oHandSetOfferedBasket.SetNormal_rebate_type(e.Values["normal_rebate_type"].ToString());


        _oHandSetOfferedBasket.SetRebate_gp(e.Values["rebate_gp"].ToString());
        _oHandSetOfferedBasket.SetCon_per(e.Values["con_per"].ToString());
        _oHandSetOfferedBasket.SetHs_model(e.Values["hs_model"].ToString());
        _oHandSetOfferedBasket.SetOffer_type_id(int.Parse(e.Values["offer_type_id"].ToString()));
        _oHandSetOfferedBasket.SetPremium(e.Values["premium"].ToString());
        _oHandSetOfferedBasket.SetIssue_type(e.Values["issue_type"].ToString());
        _oHandSetOfferedBasket.SetRebate_amount(e.Values["rebate_amount"].ToString());
        _oHandSetOfferedBasket.SetPayment(e.Values["payment"].ToString());
        _oHandSetOfferedBasket.SetR_offer(e.Values["r_offer"].ToString());
        _oHandSetOfferedBasket.SetExtra_rebate_amount(e.Values["extra_rebate_amount"].ToString());
        _oHandSetOfferedBasket.SetExtra_rebate(e.Values["extra_rebate"].ToString());
        _oHandSetOfferedBasket.SetAmount(e.Values["amount"].ToString());
        DateTime _dSdate;
        if(DateTime.TryParseExact((string)e.Values["sdate"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture,DateTimeStyles.AllowWhiteSpaces,out _dSdate))
            _oHandSetOfferedBasket.SetSdate(_dSdate);

        DateTime _dEdate;
        if (DateTime.TryParseExact((string)e.Values["edate"], "dd/MM/yyyy", System.Globalization.CultureInfo.CurrentCulture, DateTimeStyles.AllowWhiteSpaces, out _dEdate))
            _oHandSetOfferedBasket.SetEdate(_dEdate);

        _oHandSetOfferedBasket.SetActive(true);
        _oHandSetOfferedBasket.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
        _oHandSetOfferedBasket.SetCdate(DateTime.Now);


        e.Cancel = true;
        int? _iMid = HandSetOfferedBasketRepository.InsertReturnLastID_SP(SYSConn<MSSQLConnect>.Connect(), _oHandSetOfferedBasket);
        if (_iMid != null && _iMid != -1){ Response.Redirect("HandSetViewSaveDuplicate.aspx?mid=" + ((int)_iMid).ToString());}
    }
    protected void normal_rebate_type_Init(object sender, EventArgs e)
    {
        if (sender is DropDownList)
        {
            DropDownList normal_rebate_type = (DropDownList)sender;
            if (normal_rebate_type != null)
            {

                normal_rebate_type.Items.Clear();
                ObjectArr _oNormalRebateType = FromRegisterControler.GetNormalRebateTypeList(true);
                for (int i = 0; i < _oNormalRebateType.Count; i++)
                {
                    object _sKey = _oNormalRebateType.KeyFind(i);
                    object _sValue = _oNormalRebateType.ValueFind(i);
                    normal_rebate_type.Items.Add(new ListItem(_sKey.ToString(), _sValue.ToString()));
                    if (true)
                    {
                        if (_sKey.Equals("ALL"))
                            normal_rebate_type.SelectedValue = "";
                    }
                    else
                        normal_rebate_type.SelectedValue = "RETENTION";
                }
            }
        }
    }

  
}
