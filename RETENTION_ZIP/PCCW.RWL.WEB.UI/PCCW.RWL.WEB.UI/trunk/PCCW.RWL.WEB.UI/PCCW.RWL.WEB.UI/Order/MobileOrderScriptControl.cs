using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using PCCW.RWL.CORE;
namespace PCCW.RWL.WEB.UI.Order
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:MobileOrderAddressUserControl runat=server></{0}:MobileOrderAddressUserControl>")]
    public class MobileOrderScriptControl : CompositeControl
    {
        private string n_sOrderPageType;
        [Category("Data")]
        [DefaultValue("")]
        public string OrderPageType
        {
            get
            {
                return n_sOrderPageType;
            }
            set
            {
                this.n_sOrderPageType = value;
                if (string.IsNullOrEmpty(this.n_sOrderPageType)) this.n_sOrderPageType = string.Empty;
                this.n_sOrderPageType = this.n_sOrderPageType.Trim();
            }
        }

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
            switch (this.OrderPageType)
            {
                case "MobileRetentionOrderCreateScripts":
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.OrderScript.Instance.GetType(), Resources.OrderScript.ResourceName);
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.MobileRetentionOrderCreateScripts.Instance.GetType(), Resources.MobileRetentionOrderCreateScripts.ResourceName);
                    break;
                case "MobileRetentionOrderAddModifyScripts":
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.OrderScript.Instance.GetType(), Resources.OrderScript.ResourceName);
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.MobileRetentionOrderAddModifyScripts.Instance.GetType(), Resources.MobileRetentionOrderAddModifyScripts.ResourceName);
                    break;
                case "PreviousOrderModifyNoCheckScripts":
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.OrderScript.Instance.GetType(), Resources.OrderScript.ResourceName);
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.PreviousOrderModifyNoCheckScripts.Instance.GetType(), Resources.PreviousOrderModifyNoCheckScripts.ResourceName);
                    break;
                case "PreviousOrderModifyScripts":
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.OrderScript.Instance.GetType(), Resources.OrderScript.ResourceName);
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.PreviousOrderModifyScripts.Instance.GetType(), Resources.PreviousOrderModifyScripts.ResourceName);
                    break;
                case "OrderScripts":
                    this.Page.ClientScript.RegisterClientScriptResource(Resources.OrderScript.Instance.GetType(), Resources.OrderScript.ResourceName);
                   
                    break;
                default:
                    throw new BusinessObjectNotFoundException("MobileOrderScriptControl: OrderPageType Setting Error");
            }
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
