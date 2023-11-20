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
using DnaExpress.Web.UI.WebControls;
using System.Globalization;
using System.ComponentModel;

public partial class Web_ProductItemCodeControlPage : System.Web.UI.UserControl
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion

    #region SessionUid
    string n_sSessionUid
    {
        get
        {
            if (Session["uid"] != null)
            {
                return Session["uid"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionLv
    string n_sSessionLv
    {
        get
        {
            if (Session["lv"] != null)
            {
                return Session["lv"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionArprog
    string n_sSessionArprog
    {
        get
        {
            if (Session["arprog"] != null)
            {
                return Session["arprog"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion

    #region SessionChannel
    string n_sSessionChannel
    {
        get
        {
            if (Session["channel"] != null)
            {
                return Session["channel"].ToString();
            }
            else
                return string.Empty;
        }
    }
    #endregion
    [Bindable(true)]
    [Category("Data")]
    [Description("GetAspxProductItemCodeGV")]
    [DefaultValue(null)]
    public AspxGridView _AspxProductItemCodeGV
    {
        get
        {
            return AspxProductItemCodeGV;
        }
    }

   

    public string sortOrder { get { if (ViewState["sortOrder"].ToString() == "desc") { ViewState["sortOrder"] = "asc"; } else { ViewState["sortOrder"] = "desc"; } return ViewState["sortOrder"].ToString(); } set { ViewState["sortOrder"] = value; } }
    public static DataSet ItemType = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        ProductItemCodeObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }

    public void TypeBind()
    {
        ItemType = null;
        ItemType = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT 'TYPE'='' UNION SELECT DISTINCT TYPE FROM " + ProductItemCode.Para.TableName() + " WHERE TYPE IS NOT NULL AND TYPE!='' ");
    }

    public DataSet TypeDataBind()
    {
        if (ItemType == null)
            TypeBind();
        return ItemType;
    }

    


    protected void AspxProductItemCodeGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        if (e.RowIndex != -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];
            TextBox _oSdate = (TextBox)_oGridViewRow.FindControl("sdate");

            if (_oSdate.Text != string.Empty)
            {
                DateTime _dSdate;
                if (DateTime.TryParseExact(_oSdate.Text, Func.n_sDateTimeListTmp2, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dSdate))
                    e.NewValues["sdate"] = _dSdate;
                else
                    e.NewValues["sdate"] = null;
            }

            TextBox _oQuota = (TextBox)_oGridViewRow.FindControl("quota");
            if (_oQuota.Text != string.Empty)
            {
                _oQuota.Text = _oQuota.Text.Trim();
                e.NewValues["quota"] = _oQuota.Text.Trim();
            }
        }
    }
    protected void ProductItemCodeObj_Init(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        ProductItemCodeObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
    protected void AspxProductItemCodeGV_Init(object sender, EventArgs e)
    {
        
        RWLFramework.DataBaseConfigSetting();
        ProductItemCodeObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }


    protected void PageSizeRefresh_Click(object sender, EventArgs e)
    {

        if (GvPageSize != null)
        {
            int _iPageSize;
            if (int.TryParse(GvPageSize.Text, out _iPageSize))
            {
                if (_iPageSize > 0)
                {
                    AspxProductItemCodeGV.PageSize = _iPageSize;
                }
            }
            else
            {
                GvPageSize.Text = "15";
                AspxProductItemCodeGV.PageSize = 15;
            }
        }

        AspxProductItemCodeGV.DataBind();
    }

    protected void AspxProductItemCodeGV_Unload(object sender, EventArgs e)
    {

    }

    public override void DataBind()
    {
        base.DataBind();
        AspxProductItemCodeGV.DataBind();
    }


    protected void AspxProductItemCodeGV_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Disable")
        {
            int _iIndex;
            if (int.TryParse(e.CommandArgument.ToString(), out _iIndex))
            {
                GridView _oGridView = (GridView)sender;
                GridViewRow _oGridViewRow = (GridViewRow)AspxProductItemCodeGV.Rows[_iIndex];
                string _sMid = _oGridViewRow.Cells[1].Text;
                if (!string.IsNullOrEmpty(_sMid))
                {
                    int _iMid;
                    bool _bFlag = false;
                    if (int.TryParse(_sMid, out _iMid))
                    {
                        ProductItemCode _oProductItemCode = new ProductItemCode(SYSConn<MSSQLConnect>.Connect(), _iMid);
                        if (_oProductItemCode.GetFound())
                        {
                            _oProductItemCode.SetDid(RWLFramework.CurrentUser[this.Page].Uid);
                            _oProductItemCode.SetDdate(DateTime.Now);
                            _oProductItemCode.SetActive(false);
                            _bFlag = _oProductItemCode.Save();
                        }
                        else
                            _bFlag = false;

                        if (_bFlag)
                        {
                            AspxProductItemCodeGV.DataBind();
                            RegisterJavaScript(string.Empty, "jAlert('Update Success!', 'System Message');", true);
                        }
                        else
                            RegisterJavaScript(string.Empty, "jAlert('Update Fail!', 'System Message');", true);
                    }
                }
            }
        }
    }

    #region RegisterJavaScript
    protected void RegisterJavaScript(string x_sID, string x_sScript, bool x_bIncludeScript)
    {
        if (x_bIncludeScript) x_sScript = "<script>" + x_sScript + "</script>";
        ScriptManager.RegisterStartupScript(this.Page, this.GetType(), x_sID + (new Random()).Next(1, 1000).ToString() + Guid.NewGuid().ToString(), x_sScript, false);
    }
    #endregion
}
