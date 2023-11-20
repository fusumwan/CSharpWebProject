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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
using System.Globalization;
public partial class Web_ProductItemCodeControlFormPage : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ProductAdd_Click(object sender, EventArgs e)
    {
        ProductItemCode _oProductItemCode = new ProductItemCode(SYSConn<MSSQLConnect>.Connect());
        _oProductItemCode.SetActive(true);
        _oProductItemCode.SetCdate(DateTime.Now);
        _oProductItemCode.SetCid(RWLFramework.CurrentUser[this.Page].Uid);
        _oProductItemCode.SetHs_model(hs_model.Text);
        _oProductItemCode.SetItem_code(item_code.Text);
        _oProductItemCode.SetLast_stock(last_stock.Checked);
        _oProductItemCode.SetQuota(quota.Text);
        DateTime _oSdate;
        if (DateTime.TryParseExact(sdate.Text, Func.n_sDateTimeListTmp2, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _oSdate))
        {
            _oProductItemCode.SetSdate(_oSdate);
        }
        _oProductItemCode.SetType(drpType.SelectedValue);
        bool _bFlag = true;

        if (string.IsNullOrEmpty(_oProductItemCode.GetHs_model()) && _bFlag == true)
        {
            _bFlag = false;

            RegisterJavaScript(string.Empty, "jAlert('Please kindly enter handset model!','System Message');", true);


        }
        /*
        if (string.IsNullOrEmpty(_oProductItemCode.GetItem_code()) && _bFlag == true)
        {
            _bFlag = false;
            RegisterJavaScript(string.Empty, "jAlert('Please kindly enter item code!','System Message');", true);
        }
         *
        */

        if (_bFlag)
        {
            if (ProductItemCodeBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), _oProductItemCode))
            {
                RegisterJavaScript(string.Empty, "jAlert('Insert Success!','System Message');", true);
            }
            else
            {
                RegisterJavaScript(string.Empty, "jAlert('Insert Fail!','System Message');", true);
            }
        }
    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(UpdatePanel1, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
}
