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
using System.Data.Odbc;
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

public partial class HandSetCountViewExport : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    protected void Page_Load(object sender, EventArgs e){
        InitFrame();
        WebFunc.ExportExcel(this.Page, "RetentionOrderExcelResult.xls");
    }

    #region InitFrame
    public void InitFrame(){
        MobileSequentialCountProfile _oMobileSequentialCountProfile = new MobileSequentialCountProfile();
        if (WebFunc.qsLog_date != null && WebFunc.qsLog_date2 != null){
            _oMobileSequentialCountProfile.SetLog_date((DateTime)WebFunc.qsLog_date);
            _oMobileSequentialCountProfile.SetLog_date2((DateTime)WebFunc.qsLog_date2);
            _oMobileSequentialCountProfile.SetChannel(WebFunc.qsChannel);
            List<string> _oHscountCodeList = _oMobileSequentialCountProfile.GetHscountHtmlcode(WebFunc.qsChannel, WebFunc.qsSalesman_code, WebFunc.qsHs_model, WebFunc.qsPremium);
            for (int i = 0; i < _oHscountCodeList.Count; i++)
                hs_count_placeholder.Controls.Add(new LiteralControl(_oHscountCodeList[i].ToString()));
        }
    }
    #endregion
}
