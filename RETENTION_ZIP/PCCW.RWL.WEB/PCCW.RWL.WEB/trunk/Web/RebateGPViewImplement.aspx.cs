using System;
using System.Collections;
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


public partial class RebateGPViewImplement : NEURON.WEB.UI.BasePage
{
    MSSQLConnect n_oDB = null;
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    string[] _sDateTimeList = { "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy", "M/dd/yyyy hh:mm:ss", "MM/d/yyyy hh:mm:ss", "M/d/yyyy hh:mm:ss"};
    DataSet n_oGPList = new DataSet();
    DataSet n_oProgramList = new DataSet();
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
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        n_oGPList = n_oDB.GetDS("SELECT distinct gp FROM "+Configurator.MSSQLTablePrefix+ "RebateGroup with (nolock) WHERE active=1 ");
        n_oProgramList = n_oDB.GetDS("SELECT distinct program FROM " +Configurator.MSSQLTablePrefix+ "BusinessTrade with (nolock) WHERE active=1 ");


        drpPROGRAM_ADD.Items.Clear();
        drpPROGRAM_ADD.Items.Add(new ListItem(string.Empty, string.Empty));

        RWL_REBATE_RP.DataSource = n_oDB.GetDS("SELECT mid,gp,program FROM "+Configurator.MSSQLTablePrefix+"RebateGroup WHERE program in (SELECT distinct program FROM " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) where active=1) and active=1 order by mid");
        //RWL_REBATE_RP.DataSource = RebateGroupRepository.GetSearch(n_oDB, "mid,gp,program", "program in (select distinct program from "+Configurator.MSSQLTablePrefix+"BusinessTrade with (nolock) where active=1) ", null, "mid");
        RWL_REBATE_RP.DataBind();

        for (int i = 0; i < n_oProgramList.Tables[0].Rows.Count; i++)
        {
            string _sValue = n_oProgramList.Tables[0].Rows[i][0].ToString();
            drpPROGRAM_ADD.Items.Add(new ListItem(_sValue, _sValue));
        }
        drpPROGRAM_ADD.SelectedIndex = 0;
        
    }

    public DataSet BindRebateGp()
    {
        return n_oGPList;
    }

    public DataSet BindRebateProgram()
    {
        return n_oProgramList;
    }


    protected void submitbut_Click(object sender, EventArgs e)
    {
        if (drpPROGRAM_ADD.SelectedValue == string.Empty) { WebFunc.RegisterScriptEX(this.Page, "Please select program!"); }
        RebateGroup _oRebateGroup = new RebateGroup();

        _oRebateGroup.SetProgram(drpPROGRAM_ADD.SelectedValue);
        _oRebateGroup.SetGp(txtREBATE_GROUP_ADD.Text.ToString());
        if (RWLFramework.CurrentUser[this.Page].Uid != null) _oRebateGroup.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
        _oRebateGroup.SetCdate(DateTime.Now);
        _oRebateGroup.SetActive(true);
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if (RebateGroupRepository.InsertWithOutLastID(n_oDB, _oRebateGroup))
        {
            BindData();
            drpPROGRAM_ADD.SelectedIndex=0;
            txtREBATE_GROUP_ADD.Text = string.Empty;
        }
        else
        {
            WebFunc.RegisterScriptEX(this.Page, "Insert Error!");
        }
    }
    protected void RWL_REBATE_RP_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (n_oDB == null) { (n_oDB = new MSSQLConnect()).SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty)); }
        if("Modify".Equals(e.CommandName))
        {
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iRebate_id = Convert.ToInt32(_txtmid.Text);
            DropDownList _drpREBATE_GP = (DropDownList)e.Item.FindControl("drpREBATE_GP");
            DropDownList _drpREBATE_PROGRAM = (DropDownList)e.Item.FindControl("drpREBATE_PROGRAM");
            RebateGroup _oRebateGroup = new RebateGroup(n_oDB, _iRebate_id);
            if (_drpREBATE_GP.SelectedValue != string.Empty) { _oRebateGroup.SetGp(_drpREBATE_GP.SelectedValue); }
            if (_drpREBATE_PROGRAM.SelectedValue != string.Empty) { _oRebateGroup.SetProgram(_drpREBATE_PROGRAM.SelectedValue); }
            if (RWLFramework.CurrentUser[this.Page].Uid!=null) _oRebateGroup.SetCid(RWLFramework.CurrentUser[this.Page].Uid.ToString());
            _oRebateGroup.SetCdate(DateTime.Now);
            if (_oRebateGroup.Save())
            {
                RebateGroupBackup(_iRebate_id);
                BindData();
            }
            else
                WebFunc.RegisterScriptEX(this.Page, "Modify Error!");
        }
        else if ("Delete".Equals(e.CommandName))
        {
            
            Label _txtmid = (Label)e.Item.FindControl("txtmid");
            int _iRebate_id = Convert.ToInt32(_txtmid.Text);
            if (RebateGroupRepository.Delete(n_oDB, _iRebate_id))
            {
                RebateGroupBackup(_iRebate_id);
                BindData();
            }
        }
    }

    protected bool RebateGroupBackup(int x_iId)
    {
        string _sQueryBK = "INSERT INTO RebateGroupRevision (rec_no, gp, program, active, cid, cdate) ";
        _sQueryBK += " SELECT mid, gp, program, active, '" + RWLFramework.CurrentUser[this.Page].Uid + "',getdate() FROM RebateGroup ";
        _sQueryBK += " WHERE mid='" + x_iId.ToString() + "'";
        return SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery(_sQueryBK);
    }

    protected void RWL_REBATE_RP_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {

            if (n_oGPList.Tables.Count > 0)
            {
                DropDownList _drpREBATE_GP = (DropDownList)e.Item.FindControl("drpREBATE_GP");
                Label _txtREBATE_GP = (Label)e.Item.FindControl("txtREBATE_GP");

                _drpREBATE_GP.Items.Clear();
                _drpREBATE_GP.Items.Add(new ListItem(string.Empty, string.Empty));
                _drpREBATE_GP.SelectedIndex = 0;
                for (int i = 0; i < n_oGPList.Tables[0].Rows.Count; i++)
                {
                    _drpREBATE_GP.Items.Add(new ListItem(n_oGPList.Tables[0].Rows[i][0].ToString(), n_oGPList.Tables[0].Rows[i][0].ToString()));
                    if (_txtREBATE_GP.Text.ToUpper().Trim() == n_oGPList.Tables[0].Rows[i][0].ToString().ToUpper().Trim())
                        _drpREBATE_GP.SelectedValue = n_oGPList.Tables[0].Rows[i][0].ToString();
                }
            }

            if (n_oProgramList.Tables.Count > 0)
            {
                DropDownList _drpREBATE_PROGRAM = (DropDownList)e.Item.FindControl("drpREBATE_PROGRAM");
                Label _txtREBATE_PROGRAM = (Label)e.Item.FindControl("txtREBATE_PROGRAM");

                _drpREBATE_PROGRAM.Items.Clear();
                _drpREBATE_PROGRAM.Items.Add(new ListItem(string.Empty, string.Empty));
                _drpREBATE_PROGRAM.SelectedIndex = 0;
                for (int i = 0; i < n_oProgramList.Tables[0].Rows.Count; i++)
                {
                    _drpREBATE_PROGRAM.Items.Add(new ListItem(n_oProgramList.Tables[0].Rows[i][0].ToString(), n_oProgramList.Tables[0].Rows[i][0].ToString()));
                    if (_txtREBATE_PROGRAM.Text.ToUpper().Trim() == n_oProgramList.Tables[0].Rows[i][0].ToString().ToUpper().Trim())
                        _drpREBATE_PROGRAM.SelectedValue = n_oProgramList.Tables[0].Rows[i][0].ToString();
                }
            }


            int orderID = e.Item.ItemIndex + 1;
            Label _oRebateNum = (Label)e.Item.FindControl("RebateNum");
            _oRebateNum.Text = orderID.ToString();
        }
    }
}
