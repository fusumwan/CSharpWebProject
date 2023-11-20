using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class HandSetMappingAddAction : NEURON.WEB.UI.BasePage
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

    #region InitFrame
    public void InitFrame()
    {
        HandSetOfferedBasket _oHandSetOfferedBasket = (HandSetOfferedBasket)HandSetOfferedBasketRepository.CreateEntityInstanceObject();
        _oHandSetOfferedBasket.SetPlan_fee(WebFunc.qsPlan_fee);
        _oHandSetOfferedBasket.SetRebate_gp(WebFunc.qsRebate_gp);
        _oHandSetOfferedBasket.SetCon_per(WebFunc.qsCon_per);
        _oHandSetOfferedBasket.SetHs_model(WebFunc.qsHs_model);
        _oHandSetOfferedBasket.SetRebate_amount(WebFunc.qsRebate_amount);
        _oHandSetOfferedBasket.SetR_offer(WebFunc.qsR_offer);
        _oHandSetOfferedBasket.SetOffer_type_id(WebFunc.qsOffer_type_id);
        _oHandSetOfferedBasket.SetPremium(WebFunc.qsPremium);
        _oHandSetOfferedBasket.SetR_offer(WebFunc.qsR_offer);
        _oHandSetOfferedBasket.SetExtra_rebate_amount(WebFunc.qsExtra_rebate_amount);
        _oHandSetOfferedBasket.SetExtra_rebate(WebFunc.qsExtra_rebate);
        _oHandSetOfferedBasket.SetAmount(WebFunc.qsAmount);
        _oHandSetOfferedBasket.SetPayment(WebFunc.qsPayment);
        _oHandSetOfferedBasket.SetNormal_rebate_type(WebFunc.qsNormal_rebate_type);
        _oHandSetOfferedBasket.SetSdate(WebFunc.qsSdate);
        _oHandSetOfferedBasket.SetEdate(WebFunc.qsEdate);
        _oHandSetOfferedBasket.SetIssue_type(WebFunc.qsIssue_type);
        _oHandSetOfferedBasket.SetActive(true);
        _oHandSetOfferedBasket.SetCdate(DateTime.Now);
        int _iMid = -1;
        using(ISession<MSSQLConnect> _oSession=(new SessionFactory<MSSQLConnect>()).OpenSession())
        using (ITransaction _oTransaction = _oSession.BeginTransaction()){
            _iMid = _oSession.InsertReturnID(_oHandSetOfferedBasket, true);
            if (_iMid > 0)
                _oTransaction.Commit();
            else
                _oTransaction.Rollback();
        }
        _oHandSetOfferedBasket = (HandSetOfferedBasket)HandSetOfferedBasketRepository.CreateEntityInstanceObject();
        _oHandSetOfferedBasket.SetMid(_iMid);
        _oHandSetOfferedBasket.Retrieve();
        plan_fee.Text = _oHandSetOfferedBasket.GetPlan_fee();
        normal_rebate_type.Text = _oHandSetOfferedBasket.GetNormal_rebate_type();
        rebate_gp.Text = _oHandSetOfferedBasket.GetRebate_gp();
        con_per.Text = _oHandSetOfferedBasket.GetCon_per();
        hs_model.Text = _oHandSetOfferedBasket.GetHs_model();
        if(_oHandSetOfferedBasket.GetOffer_type_id()!=null){
            //offer_type_id.Text = ((int)_oHandSetOfferedBasket.GetOffer_type_id()).ToString();
            offer_type_id.Text = getOfferTypeString((int)_oHandSetOfferedBasket.GetOffer_type_id());
        }
        premium.Text = _oHandSetOfferedBasket.GetPremium();
        rebate_amount.Text = _oHandSetOfferedBasket.GetRebate_amount();
        r_offer.Text = _oHandSetOfferedBasket.GetR_offer();
        extra_rebate_amount.Text = _oHandSetOfferedBasket.GetExtra_rebate_amount();
        extra_rebate.Text = _oHandSetOfferedBasket.GetExtra_rebate();
        amount.Text = _oHandSetOfferedBasket.GetAmount();
        payment.Text = _oHandSetOfferedBasket.GetPayment();
        issue_type.Text = _oHandSetOfferedBasket.GetIssue_type();
        if(_oHandSetOfferedBasket.GetSdate()!=null) sdate.Text = ((DateTime)_oHandSetOfferedBasket.GetSdate()).ToString("MM/dd/yyyy");
        if(_oHandSetOfferedBasket.GetEdate()!=null) edate.Text = ((DateTime)_oHandSetOfferedBasket.GetEdate()).ToString("MM/dd/yyyy");
    }
    #endregion

    protected string getOfferTypeString(int x_iOffer_type_id)
    {
        HandSetOfferTypeEntity[] _oOfferTypeIdList = HandSetOfferTypeBal.GetArrayObj(GetDB(), null, null, "id asc");
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
        return "";
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
}
