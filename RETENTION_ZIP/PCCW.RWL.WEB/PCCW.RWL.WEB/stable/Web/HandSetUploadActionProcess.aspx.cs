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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;
using System.Globalization;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class Web_HandSetUploadActionProcess : NEURON.WEB.UI.BasePage
{
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    protected DataSet OfferSet = null;
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

    protected DataSet GetOfferSetList()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT * FROM HandSetOfferType");
        return SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
    }

    protected string DR(object x_oObj)
    {
        if (x_oObj == null) return string.Empty;
        return x_oObj.ToString();
    }

    public void InitFrame()
    {
        this.OfferSet = GetOfferSetList();

        string[] _oFormat = new string[] { 
        "MM/dd/yyyy", "MM/dd/yyyy HH:mm","MM/dd/yyyy H:mm","MM/dd/yyyy H:m","MM/dd/yyyy H:mm:ss","MM/dd/yyyy H:m:ss",  "MM/dd/yyyy HH:mm:ss",
        "MM/dd/yyyy tt ", "MM/dd/yyyy HH:mm tt ","MM/dd/yyyy H:mm tt","MM/dd/yyyy H:m tt","MM/dd/yyyy H:mm:ss tt","MM/dd/yyyy H:m:ss tt",  "MM/dd/yyyy HH:mm:ss tt",
        "MM/dd/yyyy tt ", "MM/dd/yyyy hh:mm tt ","MM/dd/yyyy h:mm tt","MM/dd/yyyy h:m tt","MM/dd/yyyy h:mm:ss tt","MM/dd/yyyy h:m:ss tt",  "MM/dd/yyyy hh:mm:ss tt",
        "MM/dd/yyyy tt ", "MM/dd/yyyy tt hh:mm ","MM/dd/yyyy tt h:mm","MM/dd/yyyy tt h:m","MM/dd/yyyy tt h:mm:ss","MM/dd/yyyy tt h:m:ss",  "MM/dd/yyyy tt hh:mm:ss",


        "M/dd/yyyy", "M/dd/yyyy HH:mm", "M/dd/yyyy H:mm", "M/dd/yyyy H:m","M/dd/yyyy H:mm:ss", "M/dd/yyyy H:m:ss", "M/dd/yyyy HH:mm:ss",
        "M/dd/yyyy tt", "M/dd/yyyy HH:mm tt", "M/dd/yyyy H:mm tt", "M/dd/yyyy H:m tt","M/dd/yyyy H:mm:ss tt", "M/dd/yyyy H:m:ss tt", "M/dd/yyyy HH:mm:ss tt",
        "M/dd/yyyy tt", "M/dd/yyyy hh:mm tt", "M/dd/yyyy h:mm tt", "M/dd/yyyy h:m tt","M/dd/yyyy h:mm:ss tt", "M/dd/yyyy h:m:ss tt", "M/dd/yyyy h:mm:ss tt",
        "M/dd/yyyy tt", "M/dd/yyyy hh:mm", "M/dd/yyyy tt h:mm", "M/dd/yyyy tt h:m","M/dd/yyyy tt h:mm:ss", "M/dd/yyyy tt h:m:ss", "M/dd/yyyy tt h:mm:ss",


        "MM/d/yyyy", "MM/d/yyyy HH:mm","MM/d/yyyy H:mm","MM/d/yyyy H:m","MM/d/yyyy H:mm:ss","MM/d/yyyy H:m:ss", "MM/d/yyyy HH:mm:ss",
        "MM/d/yyyy tt", "MM/d/yyyy HH:mm tt","MM/d/yyyy H:mm tt","MM/d/yyyy H:m tt","MM/d/yyyy H:mm:ss tt","MM/d/yyyy H:m:ss tt", "MM/d/yyyy HH:mm:ss tt",
        "MM/d/yyyy tt", "MM/d/yyyy hh:mm tt","MM/d/yyyy h:mm tt","MM/d/yyyy h:m tt","MM/d/yyyy h:mm:ss tt","MM/d/yyyy h:m:ss tt", "MM/d/yyyy hh:mm:ss tt",
        "MM/d/yyyy tt", "MM/d/yyyy tt hh:mm","MM/d/yyyy tt h:mm","MM/d/yyyy tt h:m","MM/d/yyyy tt h:mm:ss","MM/d/yyyy h:m:ss tt", "MM/d/yyyy tt hh:mm:ss",

        "M/d/yyyy", "M/d/yyyy HH:mm","M/d/yyyy H:mm","M/d/yyyy H:m","M/d/yyyy H:mm:ss","M/d/yyyy H:m:ss", "M/d/yyyy HH:mm:ss",
        "M/d/yyyy tt", "M/d/yyyy HH:mm tt","M/d/yyyy H:mm tt","M/d/yyyy H:m tt","M/d/yyyy H:mm:ss tt","M/d/yyyy H:m:ss tt", "M/d/yyyy HH:mm:ss tt",
        "M/d/yyyy tt", "M/d/yyyy hh:mm tt","M/d/yyyy h:mm tt","M/d/yyyy h:m tt","M/d/yyyy h:mm:ss tt","M/d/yyyy h:m:ss tt", "M/d/yyyy hh:mm:ss tt",
        "M/d/yyyy tt", "M/d/yyyy tt hh:mm","M/d/yyyy tt h:mm","M/d/yyyy tt h:m","M/d/yyyy tt h:mm:ss","M/d/yyyy tt h:m:ss", "M/d/yyyy tt hh:mm:ss"
        };

        bool _bIsUat = bool.Parse(Func.RQ(Request["uat"]).Trim());

        try
        {
            string _sUpload = "Web/upload";
            string _sFileName = Func.RQ(Request["fn"]).Trim();
            string _sExcelVersion = Func.RQ(Request["excelversion"]).Trim();
            string _sServerFilePath = "~/" + _sUpload + "/" + _sFileName;
            

            if (WebFunc.CheckFileExists(this.Page, _sServerFilePath))
            {
                String _sPath = Server.MapPath("~/Web/upload/");
                string _sFilePath = _sPath + _sFileName;
                string _sSheetName = WebFunc.ExcelSheetName(_sFilePath, _sExcelVersion.Trim().ToUpper());
                StringBuilder _oFilter = new StringBuilder();

                DataSet _oDs = WebFunc.ExcelToDS(_sFilePath, " * ", _sExcelVersion.Trim().ToUpper(), _sSheetName, true, _oFilter.ToString());
                foreach (DataRow _oDr in _oDs.Tables[0].Rows)
                {
                    bool _bUpdate = false;
                    //mid,plan_fee, rebate_gp ,normal_rebate_type, con_per, hs_model, premium ,r_offer ,rebate_amount, amount, extra_rebate ,extra_rebate_amount ,payment, sdate,active,cid,cdate
                    HandSetOfferedBasket _oHandSetOfferedBasket = HandSetOfferedBasketRepositoryBase.CreateEntityInstanceObject();
                    _oHandSetOfferedBasket.SetDB(GetDB(_bIsUat));
                    if (_oDr["mid"] != null)
                    {
                        string _sMid = DR(_oDr[HandSetOfferedBasket.Para.mid]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                        int _iMid;
                        if (int.TryParse(_sMid, out _iMid))
                        {
                            _oHandSetOfferedBasket.SetMid(_iMid);
                            _oHandSetOfferedBasket.Load(_iMid);
                            if (_oHandSetOfferedBasket.Retrieve())
                            {
                                _bUpdate = true;
                            }
                        }
                    }
                    string _sPlan_fee = DR(_oDr[HandSetOfferedBasket.Para.plan_fee]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetPlan_fee(_sPlan_fee);
                    string _sRebate_gp = DR(_oDr[HandSetOfferedBasket.Para.rebate_gp]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetRebate_gp(_sRebate_gp);
                    string _sNormal_rebate_type = DR(_oDr[HandSetOfferedBasket.Para.normal_rebate_type]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetNormal_rebate_type(_sNormal_rebate_type);
                    string _sCon_per = DR(_oDr[HandSetOfferedBasket.Para.con_per]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetCon_per(_sCon_per);
                    string _sHs_model = DR(_oDr[HandSetOfferedBasket.Para.hs_model]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetHs_model(_sHs_model);
                    string _sPremium = DR(_oDr[HandSetOfferedBasket.Para.premium]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetPremium(_sPremium);
                    string _sR_offer = DR(_oDr[HandSetOfferedBasket.Para.r_offer]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetR_offer(_sR_offer);
                    string _sRebate_amount = DR(_oDr[HandSetOfferedBasket.Para.rebate_amount]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetRebate_amount(_sRebate_amount);
                    string _sAmount = DR(_oDr[HandSetOfferedBasket.Para.amount]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetAmount(_sAmount);
                    string _sExtra_rebate = DR(_oDr[HandSetOfferedBasket.Para.extra_rebate]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetExtra_rebate(_sExtra_rebate);
                    string _sExtra_rebate_amount = DR(_oDr[HandSetOfferedBasket.Para.extra_rebate_amount]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetExtra_rebate_amount(_sExtra_rebate_amount);
                    string _sPayment = DR(_oDr[HandSetOfferedBasket.Para.payment]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetPayment(_sPayment);
                    string _sItemCode = DR(_oDr[HandSetOfferedBasket.Para.item_code]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetItem_code(_sItemCode);
                    string _sActive = DR(_oDr[HandSetOfferedBasket.Para.active]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);


                    _oHandSetOfferedBasket.SetIssue_type("ALL");
                    bool _bActive;
                    if (bool.TryParse(_sActive, out _bActive))
                    {
                        _oHandSetOfferedBasket.SetActive(_bActive);
                    }
                    string _sCid = DR(_oDr[HandSetOfferedBasket.Para.cid]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetCid(_sCid);

                    string _sDid = DR(_oDr[HandSetOfferedBasket.Para.did]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    _oHandSetOfferedBasket.SetDid(_sDid);

                    string _sOffer_type_id = DR(_oDr[HandSetOfferedBasket.Para.offer_type_id]).Trim().Replace("'", string.Empty).Replace(",", string.Empty);
                    int _iOffer_type_id = 1;
                    if (!string.IsNullOrEmpty(_sOffer_type_id))
                    {
                        IDSQuery _oIDr = IDSQuery.CreateDsCriteria(OfferSet, string.Empty)
                            .Add(DsExpression.Eq(HandSetOfferType.Para.name, _sOffer_type_id));
                        if (_oIDr.Read())
                        {
                            if (int.TryParse(_oIDr[HandSetOfferType.Para.id] as string, out _iOffer_type_id))
                            {

                            }
                        }
                        _oIDr.Close();
                    }

                    _oHandSetOfferedBasket.SetOffer_type_id(_iOffer_type_id);
                    {
                        DateTime _dSdate;
                        if (DateTime.TryParseExact(DR(_oDr[HandSetOfferedBasket.Para.sdate]), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                            _oHandSetOfferedBasket.SetSdate(_dSdate);
                        else
                            _oHandSetOfferedBasket.SetSdate(null);
                    }
                    {
                        DateTime _dCdate;
                        if (DateTime.TryParseExact(DR(_oDr[HandSetOfferedBasket.Para.cdate]), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dCdate))
                            _oHandSetOfferedBasket.SetCdate(_dCdate);
                        else
                            _oHandSetOfferedBasket.SetCdate(null);
                    }
                    {
                        DateTime _dDdate;
                        if (DateTime.TryParseExact(DR(_oDr[HandSetOfferedBasket.Para.ddate]), _oFormat, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dDdate))
                            _oHandSetOfferedBasket.SetDdate(_dDdate);
                        else
                            _oHandSetOfferedBasket.SetDdate(null);
                    }

                    if (
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetCon_per()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetHs_model()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetPlan_fee()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetRebate_gp()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetHs_model()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetPremium()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetR_offer()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetRebate_amount()) ||
                        !string.IsNullOrEmpty(_oHandSetOfferedBasket.GetAmount())
                        )
                    {
                        if (_bUpdate)
                            _oHandSetOfferedBasket.Save();
                        else
                            HandSetOfferedBasketBal.InsertWithOutLastID(GetDB(_bIsUat), _oHandSetOfferedBasket);
                    }
                }
            }
        }
        catch (Exception Exp)
        {
            string Error = Exp.ToString();

        }
    }

    #region GetDB
    public static MSSQLConnect GetDB(bool x_bIsUat)
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.bWithNoLock = true;
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + (x_bIsUat ? "2" : string.Empty));
        return _oDB;
    }
    #endregion


    public void RunJavascriptFunc(string x_sFunc)
    {
        string _sFunc = ((x_sFunc.IndexOf(';') > 0) ? x_sFunc : x_sFunc + ";");
        ScriptManager.RegisterStartupScript(this, this.GetType(), x_sFunc + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), string.Format("<script>{0}</script>", _sFunc), false);
    }

}
