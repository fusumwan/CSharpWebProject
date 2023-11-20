using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using System.Web;


public partial class HandSetViewImplement : NEURON.WEB.UI.BasePage
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
        edate.Text = Func.RQ(Request["edate"]);
        Session["HandSetViewImplement_link"] = Request.Url.PathAndQuery;
        if(!IsPostBack) HsviewDataBind();

    }

    #region HsviewDataBind
    public void HsviewDataBind()
    {
        string _sQuery = string.Empty;
        if (Session["HandSetManagement_sql"] == null) Session["HandSetManagement_sql"] = string.Empty;
        if (Session["HandSetManagement_sql"].ToString() == ""){
            _sQuery = "SELECT mid,plan_fee,rebate_gp,normal_rebate_type, 'offer_type_id'=CASE WHEN offer_type_id is not null then (SELECT a.name FROM HandSetOfferType a where a.id=offer_type_id) ELSE '' END,con_per,hs_model,premium,r_offer,rebate_amount,amount,extra_rebate,extra_rebate_amount,payment,sdate,edate,	active,cid,cdate,	did,ddate,item_code FROM " + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket WITH (nolock) WHERE active=1 ";
            if (!"".Equals(WebFunc.qsPlan_fee)){_sQuery += " AND plan_fee='" + Func.StringTrim(WebFunc.qsPlan_fee) + "'";}
            if (!"".Equals(WebFunc.qsCon_per)){ _sQuery += " AND con_per='" + Func.StringTrim(WebFunc.qsCon_per) + "'";}
            if (!"".Equals(WebFunc.qsHs_model)){_sQuery += " AND hs_model='" + Func.StringTrim(WebFunc.qsHs_model) + "'";}
            if (!"".Equals(WebFunc.qsOffer_type_id) && WebFunc.qsOffer_type_id!=null) { _sQuery += " AND offer_type_id='" + Func.StringTrim(WebFunc.qsOffer_type_id) + "'"; }
            if (!"".Equals(WebFunc.qsPremium)){ _sQuery += " AND premium='" + Func.StringTrim(WebFunc.qsPremium) + "'";}
            if (!"".Equals(WebFunc.qsRebate_amount)){ _sQuery += " AND rebate_amount='" + Func.StringTrim(WebFunc.qsRebate_amount) + "'";}
            if (!"".Equals(WebFunc.qsR_offer)){ _sQuery += " AND r_offer='" + Func.StringTrim(WebFunc.qsR_offer) + "'";}
            if (!"".Equals(WebFunc.qsExtra_rebate_amount)){_sQuery += " AND extra_rebate_amount='" + Func.StringTrim(WebFunc.qsExtra_rebate_amount) + "'";}
            if (!"".Equals(WebFunc.qsExtra_rebate)){_sQuery += " AND extra_rebate='" + Func.StringTrim(WebFunc.qsExtra_rebate) + "'";}
            if (!"".Equals(WebFunc.qsAmount)){ _sQuery += " AND amount='" + Func.StringTrim(WebFunc.qsAmount) + "'";}

            if (!string.IsNullOrEmpty(WebFunc.qsNormal_rebate_type))
                _sQuery += " AND normal_rebate_type='" + WebFunc.qsNormal_rebate_type + "'";

            Session["HandSetManagement_sql"] = _sQuery;
        }
        else
            _sQuery = Session["HandSetManagement_sql"].ToString();

        if (!string.IsNullOrEmpty(Request.QueryString["sort"]))
            _sQuery += " ORDER BY " + Request.QueryString["sort"].ToString();
        else
            _sQuery += " ORDER BY MID ";
        
        if (!string.IsNullOrEmpty(Request.QueryString["order"]))
            _sQuery += " " + Request.QueryString["order"].ToString();
        HttpContext.Current.Session["HandSetViewSql"] = _sQuery;

        hsmodel_rp.DataSource = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        hsmodel_rp.DataBind();
    }
    #endregion


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
    protected void RepeaterID_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
    {
        if (!(-1).Equals(e.Item.ItemIndex))
        {
            HtmlInputCheckBox _oHs_del = (HtmlInputCheckBox)e.Item.FindControl("hs_del");
        }
    }
    protected void TradeDelActionButton_Click(object sender, EventArgs e)
    {
        TakeAction(true);
        HsviewDataBind();
    }
    protected void TakeUpdateAction_Click(object sender, EventArgs e)
    {
        TakeAction(false);
        HsviewDataBind();
    }
    protected void TakeAction(bool x_bDelete)
    {
        string _sDelList = string.Empty;
        foreach (RepeaterItem _oRepeaterItem in hsmodel_rp.Items)
        {
            HtmlInputCheckBox _oHs_del = (HtmlInputCheckBox)_oRepeaterItem.FindControl("hs_del");

            if (_oHs_del != null)
            {
                if (Func.IsParseInt(_oHs_del.Value) && _oHs_del.Checked)
                {
                    if (!"".Equals(_sDelList)) _sDelList += ",";
                    _sDelList += _oHs_del.Value.ToString().Trim();
                }
            }
        }
        
        if (!"".Equals(_sDelList))
        {
            if (x_bDelete)
            {
                              
                if (!string.IsNullOrEmpty(_sDelList))
                {
                    StringBuilder _sQuery = new StringBuilder();
                    _sQuery.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory(rec_no, plan_fee, normal_rebate_type, con_per, hs_model, offer_type_id, premium, r_offer, rebate_amount, amount, extra_rebate, extra_rebate_amount, payment, sdate, edate, item_code, active, cid, cdate) ");
                    _sQuery.Append(" SELECT mid, plan_fee, normal_rebate_type, con_per, hs_model, offer_type_id, premium, r_offer, rebate_amount, amount, extra_rebate, extra_rebate_amount, payment, sdate, edate, item_code, active, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate() FROM " + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket ");
                    _sQuery.Append(" WHERE mid in (" + _sDelList + ")");
                    if (SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery.ToString()))
                    {
                        if (HandSetOfferedBasketBal.SaveActive(SYSConn<MSSQLConnect>.Connect(), false, RWLFramework.CurrentUser[this.Page].Uid, "mid in (" + _sDelList + ")"))
                            RunJavascriptFunc("alert('Delete Record Success!');");
                        else
                            RunJavascriptFunc("alert('Delete Record Fail!');");
                    }
                    else
                        RunJavascriptFunc("alert('Delete Record Fail!');");
                }
                else
                    RunJavascriptFunc("alert('Delete Record Fail!');");
            }
            else
            {
                StringBuilder _sQuery = new StringBuilder();
                _sQuery.Append("INSERT INTO " + Configurator.MSSQLTablePrefix + "HandSetOfferBasketHistory(rec_no, plan_fee, normal_rebate_type, con_per, hs_model, offer_type_id, premium, r_offer, rebate_amount, amount, extra_rebate, extra_rebate_amount, payment, sdate, edate, item_code, active, cid, cdate) ");
                _sQuery.Append(" SELECT mid, plan_fee, normal_rebate_type, con_per, hs_model, offer_type_id, premium, r_offer, rebate_amount, amount, extra_rebate, extra_rebate_amount, payment, sdate, edate, item_code, active, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate() FROM " + Configurator.MSSQLTablePrefix + "HandSetOfferedBasket ");
                _sQuery.Append(" WHERE mid IN (" + _sDelList + ")");
                if (SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQuery.ToString()))
                {
                    if (Func.IsParseDateTime(edate.Text))
                    {
                        DateTime _dEdate = Func.ConvertDatetime(edate.Text);
                        if (HandSetOfferedBasketBal.SaveEndDate(SYSConn<MSSQLConnect>.Connect(), _dEdate, RWLFramework.CurrentUser[this.Page].Uid, "mid in (" + _sDelList + ")"))
                            RunJavascriptFunc("alert('Update Record Success!');");
                        else
                            RunJavascriptFunc("alert('Update Record Fail!');");
                    }
                }
                else
                    RunJavascriptFunc("alert('Update Record Fail!');");
            }
        }
    }
    protected string getOfferTypeString(int x_iOffer_type_id)
    {
        HandSetOfferTypeEntity[] _oOfferTypeIdList = HandSetOfferTypeBal.GetArrayObj(GetDB(), "active=1", null, "name");
        if (_oOfferTypeIdList != null)
        {
            for (int i = 0; i < _oOfferTypeIdList.Length; i++)
            {
                if (x_iOffer_type_id == _oOfferTypeIdList[i].id)
                {
                    return _oOfferTypeIdList[i].name.ToString();
                }
            }
        }
        return " ";
    }
    #region Run Javascript Function
    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString()+Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }
    #endregion

}
