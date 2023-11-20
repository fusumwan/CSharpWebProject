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


public partial class GiftCodeViewAction : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;

    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
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
        if (!IsPostBack)
        {
            BindData();
        }
    }

    public void BindData()
    {
        if(n_oDB==null){(n_oDB=new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));}
        GiftBasket_RP.DataSource = n_oDB.GetDS("SELECT mid,gift_code,CONVERT(varchar,edate,101) edate,gift_desc,gift_gp, CONVERT(varchar,sdate,101)  sdate FROM "+Configurator.MSSQLTablePrefix+"GiftBasket WHERE active=1");
        GiftBasket_RP.DataBind();
    }

    protected void GiftBasket_ItemCommand(object source, RepeaterCommandEventArgs e)
    {



        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if("Modify".Equals(e.CommandName))
        {
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iGift_id = Convert.ToInt32(_txtmid.Text);
            string _sQuery = "SELECT * FROM GiftBasket WITH (nolock) WHERE active=1 and gift_code='" +WebFunc.qsGift_code+ "' and mid<>'" +_iGift_id.ToString()+ "' ";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (!_oDr.Read() || WebFunc.qsGift_code.Equals(string.Empty))
            {
                TextBox _txtGIFT_DESC = (TextBox)e.Item.FindControl("txtGIFT_DESC");
                TextBox _txtGIFT_CODE = (TextBox)e.Item.FindControl("txtGIFT_CODE");
                TextBox _txtGIFT_GP = (TextBox)e.Item.FindControl("txtGIFT_GP");
                TextBox _txtSDATE = (TextBox)e.Item.FindControl("txtSDATE");
                TextBox _txtEDATE = (TextBox)e.Item.FindControl("txtEDATE");
                GiftBasket _oGiftBasket = new GiftBasket(n_oDB, _iGift_id);
                if (_txtGIFT_DESC.Text != string.Empty) { _oGiftBasket.SetGift_desc(_txtGIFT_DESC.Text.Trim()); }
                if (_txtGIFT_CODE.Text != string.Empty) { _oGiftBasket.SetGift_code(_txtGIFT_CODE.Text.Trim()); }
                if (_txtGIFT_GP.Text != string.Empty) { _oGiftBasket.SetGift_gp(_txtGIFT_GP.Text); }
                if (_txtSDATE.Text != string.Empty)
                {
                    try
                    {
                        _oGiftBasket.SetSdate(DateTime.ParseExact(_txtSDATE.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
                    }
                    catch { }
                }
                else
                {
                    _oGiftBasket.SetSdate(null);
                }
                if (_txtEDATE.Text != string.Empty)
                {
                    try
                    {
                        _oGiftBasket.SetEdate(DateTime.ParseExact(_txtEDATE.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
                    }
                    catch { }
                }
                else
                {
                    _oGiftBasket.SetEdate(null);
                }
                if (RWLFramework.CurrentUser[this.Page].Uid != null) _oGiftBasket.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
                _oGiftBasket.SetCdate(DateTime.Now);

                if (_oGiftBasket.Save())
                {
                    GiftBasketBackUp(_iGift_id);
                    BindData();
                }
                else
                    WebFunc.RegisterScriptEX(this.Page, "Modify Error!");
            }
            else
            {
                WebFunc.RegisterScriptEX(this.Page, "DUPLICATE ITEM CODE!!");
            }
        }
        else if ("Delete".Equals(e.CommandName))
        {
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iGift_id = Convert.ToInt32(_txtmid.Text);
            if (GiftBasketRepository.Delete(n_oDB, _iGift_id))
            {
                GiftBasketBackUp(_iGift_id);
                BindData();
            }
        }
    }

    protected bool GiftBasketBackUp(int x_iId)
    {
        string _sQueryBK = "insert into GiftBasketRevision (rec_no, gift_desc, gift_code, quota, last_stock, sdate, edate, gift_gp, active, cid, cdate, did, ddate ) ";
        _sQueryBK += " select mid, gift_desc, gift_code, quota, last_stock, sdate, edate, gift_gp, active, cid, cdate, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate() from GiftBasket ";
        _sQueryBK += " where mid='" + x_iId.ToString() + "'";
        return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryBK);
    }

    protected void GiftBasket_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int orderID = e.Item.ItemIndex + 1;
            Label _GiftNum= (Label)e.Item.FindControl("GiftNum");
            _GiftNum.Text = orderID.ToString();
        }
    }
    protected void submitbut_Click(object sender, EventArgs e)
    {
        bool _bExit = false;
        if (txtGIFT_CODE_ADD.Text.Trim() != string.Empty)
        {
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT TOP 1 gift_code  FROM " + GiftBasket.Para.TableName() + " WHERE gift_code='" + txtGIFT_CODE_ADD.Text.ToString() + "' ");
            if (_oDr.Read()) { 
                WebFunc.RegisterScriptEX(this.Page, "DULPLICATE GIFT_CODE!");
                _bExit = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            if (_bExit) { return; }
        }

        GiftBasket _oGiftBasket = (GiftBasket)GiftBasketRepository.CreateEntityInstanceObject();
        _oGiftBasket.SetGift_desc(txtGIFT_DESC_ADD.Text.Trim());
        _oGiftBasket.SetGift_code(txtGIFT_CODE_ADD.Text.Trim());
        _oGiftBasket.SetGift_gp(txtGIFT_GP_ADD.Text.Trim());
        if (RWLFramework.CurrentUser[this.Page].Uid != null) _oGiftBasket.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
        _oGiftBasket.SetCdate(DateTime.Now);
        _oGiftBasket.SetActive(true);
        if (txtGIFT_SDATE_ADD.Text != string.Empty)
        {
            try
            {
                _oGiftBasket.SetSdate(DateTime.ParseExact(txtGIFT_SDATE_ADD.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
            }
            catch { }
        }
        if (txtGIFT_EDATE_ADD.Text != string.Empty)
        {
            try
            {
                _oGiftBasket.SetEdate(DateTime.ParseExact(txtGIFT_EDATE_ADD.Text, n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces));
            }
            catch { }
        }
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if (GiftBasketRepository.InsertWithOutLastID(n_oDB, _oGiftBasket))
        {
            BindData();
            txtGIFT_DESC_ADD.Text = string.Empty;
            txtGIFT_CODE_ADD.Text = string.Empty;
            txtGIFT_GP_ADD.Text = string.Empty;
            txtGIFT_SDATE_ADD.Text = string.Empty;
            txtGIFT_EDATE_ADD.Text = string.Empty;
        }
        else
        {
            WebFunc.RegisterScriptEX(this.Page,"Insert Error!");
        }
    }
}
