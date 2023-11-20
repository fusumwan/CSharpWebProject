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
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;
public partial class Web_ChangeStaffNoCurrentAccessRight : NEURON.WEB.UI.BasePage
{
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
    protected void Page_Load(object sender, EventArgs e)
    {
        WebFunc.PrivilegeCheck(this.Page);
        if (RWLFramework.CurrentUser[this.Page].Uid == "A8350006")
        {
            if (!IsPostBack)
            {
                StaffNo.Text = n_sSessionUid;
                ChangeLv.SelectedValue = n_sSessionLv;
            }
        }
        else
        {
            throw new BusinessObjectNotFoundException("Change session level Fail!");
        }
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Session["lv"] = ChangeLv.SelectedValue;
        WebFunc.RegisterScriptEX(this.Page, "Change session level is success!");
    }
 
}
