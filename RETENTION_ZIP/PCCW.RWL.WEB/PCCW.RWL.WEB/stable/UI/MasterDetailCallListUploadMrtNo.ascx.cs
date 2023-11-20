using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using DnaExpress.Web.UI.WebControls.AspxGridViewCommon;
using PCCW.RWL.CORE;
public partial class UI_MasterDetailCallListUploadMrtNo : DnaExpress.Web.UI.UserControl
{

    [Bindable(true)]
    [Category("Data")]
    [Description("CallListProgramID")]
    [DefaultValue(-1)]
    public long CallListProgramID
    {
        get
        {
            object o = ViewState["CallListProgramID"];
            return o == null ? -1 : (int)o;
        }
        set
        {
            ViewState["CallListProgramID"] = value;
            CallListUploadMrtNoObj.SelectParameters[0].DefaultValue = value.ToString();
        }
    }

    protected bool IsLoad
    {
        get
        {
            if (ViewState["IsLoad"] == null)
                ViewState["IsLoad"] = false;
            return (bool)ViewState["IsLoad"];
        }
        set
        {
            ViewState["IsLoad"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack || IsLoad == false)
        {
            IsLoad = true;
            CallListUploadMrtNoObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
            if (MasterDetailCommandArgument != null)
            {
                long _lCallListProgramID;
                if (long.TryParse(MasterDetailCommandArgument.ToString(), out _lCallListProgramID))
                {
                    CallListProgramID = _lCallListProgramID;
                    CallListUploadMrtNoGv.DataBind();
                }
            }
        }
    }
    protected void CallListUploadMrtNoObj_Init(object sender, EventArgs e)
    {
        CallListUploadMrtNoObj.ConnectionString = SYSConn<MSSQLConnect>.Connect().ConnectionStr;
    }
    protected void CallListUploadMrtNoGv_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (e.RowIndex > -1)
        {
            GridView _oGridView = (GridView)sender;
            GridViewRow _oGridViewRow = (GridViewRow)_oGridView.Rows[e.RowIndex];


            string _sId = CallListUploadMrtNoGv.DataKeys[e.RowIndex]["id"].ToString();
            int _iId;
            if (int.TryParse(_sId, out _iId))
            {
                CallListUploadMrtNo _oCallListUploadMrtNo = new CallListUploadMrtNo(SYSConn<MSSQLConnect>.Connect(), _iId);
                if (_oCallListUploadMrtNo.GetCall_list_program_id() != null)
                {

                    _oCallListUploadMrtNo.Delete();
                    CallListUploadMrtNoGv.DataBind();
                }


            }
        }
    }
}
