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
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public partial class Default : System.Web.UI.Page
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
        Session["uid"] = "A8350006";
        Session["lv"] = "65535";
        Session["arprog"] = "RWLN";
        Session["channel"] = string.Empty;
		if (n_sSessionLv.ToString()==string.Empty || n_sSessionLv.ToString()=="0"){Session["lv"] = Session["team_lv"];}
        RWLFramework.DataBaseConfigSetting();
		try{
			RWLFramework.InitModel();
		    LocationTimeMemory.Instance().PreLoadDataToMemory(true);
		    AccessRightControl.Instance().PreLoadDataToMemory(true);
	        RWLFramework.PreLoadDataToMemory();
        }
		catch (Exception exp)
        {

        }
        MessageShow();
        Response.Write("<script>location.href='Web/MobileRetentionMain.aspx'</script>");
        
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        
    }

    public void MessageShow()
    {
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT mid,message,subject FROM " + EventMsgDetail.Para.TableName() + " where active =1  and (edate is null or edate >getdate()-1) and sdate<=getdate() and (access_right='all' ");
        if (RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150498"))
        {
            _oQuery.Append(" or access_right is not null ");
        }
        else if (RWLFramework.CurrentUser[this.Page].Lv.Equals("1") ||
            RWLFramework.CurrentUser[this.Page].Lv.Equals("10") ||
            RWLFramework.CurrentUser[this.Page].Lv.Equals("4") ||
            RWLFramework.CurrentUser[this.Page].Lv.Equals("30")
            )
        {
            _oQuery.Append(" or access_right='fl' ");
        }
        else if (RWLFramework.CurrentUser[this.Page].Lv.Equals("6"))
        {
            _oQuery.Append(" or access_right='csa' ");
        }
        else if (RWLFramework.CurrentUser[this.Page].Lv.Equals("65535"))
        {
            _oQuery.Append(" or access_right='su' ");
        }
        _oQuery.Append(" ) ");

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        if (RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150498"))
        {
            while (_oDr.Read())
            {
                if (!Func.FR(_oDr[EventMsgDetail.Para.message]).Trim().Equals(string.Empty) &&
                    !Func.FR(_oDr[EventMsgDetail.Para.subject]).Trim().Equals(string.Empty))
                {
                    Response.Write("<Script>window.open('Web/MessageShowView.aspx?mid=" + Func.FR(_oDr["mid"]).Trim() + "','','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=550, height=300')</script>");
                }
            }
        }
        else
        {
            if (Request.Cookies["RWLMSG"] == null)
            {
                Request.Cookies.Add(new HttpCookie("RWLMSG", string.Empty));
            }

            if (_oDr.HasRows && Request.Cookies["RWLMSG"].Value.Equals(string.Empty))
            {
                Response.Cookies["RWLMSG"].Expires = DateTime.Now.AddDays(1);
                if (RWLFramework.CurrentUser[this.Page].Uid.Equals("A8350006") ||
                    RWLFramework.CurrentUser[this.Page].Uid.Equals("A3150498"))
                    Response.Cookies.Add(new HttpCookie("RWLMSG", string.Empty));
                else
                    Response.Cookies.Add(new HttpCookie("RWLMSG", "yes"));

                while (_oDr.Read())
                {
                    if (!Func.FR(_oDr[EventMsgDetail.Para.message]).Trim().Equals(string.Empty) &&
                        !Func.FR(_oDr[EventMsgDetail.Para.subject]).Trim().Equals(string.Empty))
                    {
                        Response.Write("<Script>window.open('Web/MessageShowView.aspx?mid=" + Func.FR(_oDr["mid"]).Trim() + "','','toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=no, width=550, height=300')</script>");
                    }
                }
            }
        }
        _oDr.Close();
        _oDr.Dispose();
    }
	
}
