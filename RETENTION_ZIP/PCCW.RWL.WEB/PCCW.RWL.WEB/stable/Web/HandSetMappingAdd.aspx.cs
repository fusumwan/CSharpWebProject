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
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK.STOCK;

public partial class HandSetMappingAdd : NEURON.WEB.UI.BasePage
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
    protected void InitFrame()
    {
        ObjectArr _oItemList = BusinessTradeBal.GetIssueTypeList(true);
        for (int i = 0; i < _oItemList.Count; i++)
        {
            issue_type.Items.Add(new ListItem(_oItemList[i].ToString(), _oItemList[i].ToString()));
        }

        List<string> _oPlanFeeList = BusinessTradeBal.DrpPlanFeeList();
        plan_fee.Items.Clear();
        plan_fee.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oPlanFeeList.Count; i++)
            plan_fee.Items.Add(new ListItem(_oPlanFeeList[i].ToString(), _oPlanFeeList[i].ToString()));

        List<string> _oRebateGpList = RebateGroupBal.DrpRebateGpList();
        rebate_gp.Items.Clear();
        rebate_gp.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oRebateGpList.Count; i++)
            rebate_gp.Items.Add(new ListItem(_oRebateGpList[i].ToString(), _oRebateGpList[i].ToString()));
        
        List<string> _oConPerList = BusinessTradeBal.DrpCon_perList();
        con_per.Items.Clear();
        con_per.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oConPerList.Count; i++)
            con_per.Items.Add(new ListItem(_oConPerList[i].ToString(), _oConPerList[i].ToString()));

        List<string> _oHsmodelList = ProductItemCodeBal.DrpHsmodelList("HS",null);
        hs_model.Items.Clear();
        hs_model.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oHsmodelList.Count; i++)
            hs_model.Items.Add(new ListItem(_oHsmodelList[i].ToString(), _oHsmodelList[i].ToString()));

        List<string> _oPremiumList = ProductItemCodeBal.DrpHsmodelList("PMU",null);
        premium.Items.Clear();
        premium.Items.Add(new ListItem(string.Empty, string.Empty));
        for (int i = 0; i < _oPremiumList.Count; i++)
            premium.Items.Add(new ListItem(_oPremiumList[i].ToString(), _oPremiumList[i].ToString()));

        HandSetOfferTypeEntity[] _oOfferTypeIdList = HandSetOfferTypeBal.GetArrayObj(GetDB(), null, null, "id asc");
        offer_type_id.Items.Clear();
        //offer_type_id1.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oOfferTypeIdList != null)
        {
            for (int i = 0; i < _oOfferTypeIdList.Length; i++)
                offer_type_id.Items.Add(new ListItem(_oOfferTypeIdList[i].name.ToString(), _oOfferTypeIdList[i].id.ToString()));

        }

        sdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        NormalRebateTypeBindData(true);
    }
    #endregion



    #region NormalRebateTypeBindData
    protected void NormalRebateTypeBindData(bool x_bIncludeAll)
    {
        if (normal_rebate_type != null)
        {
            normal_rebate_type.Items.Clear();
            ObjectArr _oNormalRebateType = FromRegisterControler.GetNormalRebateTypeList(x_bIncludeAll);
            for (int i = 0; i < _oNormalRebateType.Count; i++)
            {
                object _sKey = _oNormalRebateType.KeyFind(i);
                object _sValue = _oNormalRebateType.ValueFind(i);
                normal_rebate_type.Items.Add(new ListItem(_sKey.ToString(), _sValue.ToString()));
                if (x_bIncludeAll)
                {
                    if (_sKey.Equals("ALL"))
                        normal_rebate_type.SelectedValue = "";
                }
                else
                    normal_rebate_type.SelectedValue = "RETENTION";
            }
        }
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
}
