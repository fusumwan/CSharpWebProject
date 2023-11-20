using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class AccessoryViewAction : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    string[] n_sDateTimeList = { "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy", "M/dd/yyyy hh:mm:ss", "MM/d/yyyy hh:mm:ss", "M/d/yyyy hh:mm:ss" }; 
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
       if (!IsPostBack){ BindData();}

    }


    public void BindData()
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        Accessory_RP.DataSource = n_oDB.GetDS("select mid,Accessory_code,Accessory_desc,Accessory_price, CONVERT(varchar,edate,101) edate,CONVERT(varchar,sdate,101)  sdate from "+Configurator.MSSQLTablePrefix+"Accessory");
        Accessory_RP.DataBind();
    }


    protected void Accessory_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if("Modify".Equals(e.CommandName))
        {
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iGift_id = Convert.ToInt32(_txtmid.Text);
            string _sQuery = "SELECT * FROM AccessoryRevision with (nolock) WHERE active=1 AND accessory_code='" + WebFunc.qsAccessory_code + "' and mid<>'" + _iGift_id + "'";
            SqlDataReader _oDr= SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (!_oDr.Read() || WebFunc.qsAccessory_code.Equals(string.Empty))
            {
                if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
                
                TextBox _txtAccessory_DESC = (TextBox)e.Item.FindControl("txtAccessory_DESC");
                TextBox _txtAccessory_CODE = (TextBox)e.Item.FindControl("txtAccessory_CODE");
                TextBox _txtAccessory_PRICE = (TextBox)e.Item.FindControl("txtAccessory_PRICE");
                TextBox _txtSDATE = (TextBox)e.Item.FindControl("txtSDATE");
                TextBox _txtEDATE = (TextBox)e.Item.FindControl("txtEDATE");

                Accessory _oAccessory = new Accessory(n_oDB, _iGift_id);
                if (_txtAccessory_DESC.Text != string.Empty) { _oAccessory.SetAccessory_desc(_txtAccessory_DESC.Text); }
                if (_txtAccessory_CODE.Text != string.Empty) { _oAccessory.SetAccessory_code(_txtAccessory_CODE.Text); }
                if (_txtAccessory_PRICE.Text != string.Empty) { _oAccessory.SetAccessory_price(_txtAccessory_PRICE.Text); }
                if (_txtSDATE.Text != string.Empty)
                {
                    try
                    {
                        _oAccessory.SetSdate(DateTime.ParseExact(_txtSDATE.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
                    }
                    catch { }
                }
                if (_txtEDATE.Text != string.Empty)
                {
                    try
                    {
                        _oAccessory.SetEdate(DateTime.ParseExact(_txtEDATE.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
                    }
                    catch { }
                }

                if (RWLFramework.CurrentUser[this.Page].Uid != null) _oAccessory.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
                _oAccessory.SetCdate(DateTime.Now);
                if (_oAccessory.Save())
                {
                    AccessoryBackup(_iGift_id);
                    BindData();
                }
                else
                {
                    WebFunc.RegisterScriptEX(this.Page, "Modify Error!");
                }
            }
            else
            {
                WebFunc.RegisterScriptEX(this.Page, "DUPLICATE ITEM CODE!!");
            }
            _oDr.Close();
            _oDr.Dispose();
        }
        else if ("Delete".Equals(e.CommandName))
        {
            if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iGift_id = Convert.ToInt32(_txtmid.Text);
            if (AccessoryRepository.Delete(n_oDB, _iGift_id))
            {
                AccessoryBackup(_iGift_id);
                BindData();
            }
        }
    }


    protected bool AccessoryBackup(int x_iId)
    {
        string _sQueryBk = "insert into AccessoryRevision(rec_no, accessory_desc, accessory_code, accessory_price, quota, last_stock, sdate, edate, active, cid, cdate, did, ddate ) ";
        _sQueryBk += " select mid, accessory_desc, accessory_code, accessory_price, quota, last_stock, sdate, edate, active, cid, cdate, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate() from Accessory ";
        _sQueryBk += " where mid='" + x_iId.ToString() + "'";
        return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryBk);
    }

    protected void Accessory_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int orderID = e.Item.ItemIndex + 1;
            Label _AccNum = (Label)e.Item.FindControl("AccNum");
            _AccNum.Text = orderID.ToString();
        }
    }
    protected void submitbut_Click(object sender, EventArgs e)
    {
        if (txtAccessory_CODE_ADD.Text.Trim() != string.Empty)
        {
            bool _bExit = false;
            SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT TOP 1 accessory_code  FROM " + Accessory.Para.TableName() + " WHERE accessory_code='" + txtAccessory_CODE_ADD.Text.ToString() + "' ");
            if (_oDr2.Read()) { 
                WebFunc.RegisterScriptEX(this.Page, "DULPLICATE ACCESSORY CODE!");
                _bExit = true;
            }
            _oDr2.Close();
            _oDr2.Dispose();
            if (_bExit) { return; }
        }

        Accessory _oAccessory = (Accessory)AccessoryRepository.CreateEntityInstanceObject();
        _oAccessory.SetAccessory_desc(txtAccessory_DESC_ADD.Text);
        _oAccessory.SetAccessory_code(txtAccessory_CODE_ADD.Text);
        _oAccessory.SetAccessory_price(txtAccessory_PRICE_ADD.Text);
        string _sQuery = "SELECT * FROM AccessoryRevision with (nolock) WHERE active=1 AND accessory_code='" + WebFunc.qsAccessory_code + "'";
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
        if (!_oDr.Read() || WebFunc.qsAccessory_code.Equals(string.Empty))
        {
            if (!"".Equals(txtAccessory_SDATE_ADD.Text))
            {
                try
                {
                    _oAccessory.SetSdate(DateTime.ParseExact(txtAccessory_SDATE_ADD.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
                }
                catch { }
            }
            if (!"".Equals(txtAccessory_EDATE_ADD.Text))
            {
                try
                {
                    _oAccessory.SetEdate(DateTime.ParseExact(txtAccessory_EDATE_ADD.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
                }
                catch { }
            }
            if (RWLFramework.CurrentUser[this.Page].Uid != null) _oAccessory.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
            _oAccessory.SetCdate(DateTime.Now);
            _oAccessory.SetActive(true);
            if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
            if (AccessoryRepository.InsertWithOutLastID(n_oDB, _oAccessory))
            {
                BindData();
                txtAccessory_DESC_ADD.Text = string.Empty;
                txtAccessory_CODE_ADD.Text = string.Empty;
                txtAccessory_PRICE_ADD.Text = string.Empty;
                txtAccessory_SDATE_ADD.Text = string.Empty;
                txtAccessory_EDATE_ADD.Text = string.Empty;
            }
            else
            {
                WebFunc.RegisterScriptEX(this.Page, "Insert Error!");
            }
        }
        else
        {
            WebFunc.RegisterScriptEX(this.Page, "DUPLICATE ITEM CODE!!");
        }
        _oDr.Close();
        _oDr.Dispose();
    }
}
