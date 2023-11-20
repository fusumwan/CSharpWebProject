using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using AjaxControlToolkit;
using PCCW.RWL.WEB.UI;
using PCCW.RWL.WEB.UI.UserControlRequest;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.WEBFUNC;

namespace PCCW.RWL.WEB.UI.Vas
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:BusinessVasAutoSelectScriptsLibrary runat=server></{0}:BusinessVasAutoSelectScriptsLibrary>")]
    public class BusinessVasAutoSelectScriptsLibrary : CompositeControl
    {
        protected override void Render(HtmlTextWriter w)
        {
            base.Render(w);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Page.DataBind();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Page.ClientScript.RegisterClientScriptResource(Resources.BusinessVasAutoSelectScripts.Instance.GetType(), Resources.BusinessVasAutoSelectScripts.ResourceName);          
        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
        }
        public override void DataBind()
        {
            base.DataBind();
        }
    }
}
