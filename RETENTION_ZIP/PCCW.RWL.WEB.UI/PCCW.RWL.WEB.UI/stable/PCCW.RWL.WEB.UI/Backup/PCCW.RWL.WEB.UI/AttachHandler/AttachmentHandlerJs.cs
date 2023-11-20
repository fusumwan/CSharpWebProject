using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace PCCW.RWL.WEB.UI.AttachHandler
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:AttachmentHandlerJs runat=server></{0}:AttachmentHandlerJs>")]
    public class AttachmentHandlerJs : CompositeControl
    {
        private string n_sAttachmentID;
        [Category("Data")]
        [DefaultValue("")]
        public string AttachmentID
        {
            get
            {
                return n_sAttachmentID;
            }
            set
            {
                this.n_sAttachmentID = value;
                if (string.IsNullOrEmpty(this.n_sAttachmentID)) this.n_sAttachmentID = string.Empty;
                this.n_sAttachmentID = this.n_sAttachmentID.Trim();
            }
        }

        private string n_sText;
        [Category("Data")]
        [DefaultValue("")]
        public string Text
        {
            get
            {
                return n_sText;
            }
            set
            {
                this.n_sText = value;
                if (string.IsNullOrEmpty(this.n_sText)) this.n_sText = string.Empty;
                this.n_sText = this.n_sText.Trim();
            }
        }

        [Category("Data")]
        [DefaultValue("")]
        public string Query
        {
            get
            {
                if (!string.IsNullOrEmpty(this.AttachmentID))
                {
                    if (HttpContext.Current.Session[this.AttachmentID] != null)
                        return HttpContext.Current.Session[this.AttachmentID].ToString();
                    else
                        return string.Empty;
                }
                else
                    return string.Empty;
            }
            set
            {
                HttpContext.Current.Session[this.AttachmentID] = value;
            }
        }



        protected bool n_bEnable = true;
        [Category("Behavior")]
        [DefaultValue("")]
        public bool Enable
        {
            get
            {
                return n_bEnable;
            }
            set
            {
                n_bEnable = value;
            }
        }



        protected override void Render(HtmlTextWriter w)
        {
            base.Render(w);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Page.ClientScript.RegisterClientScriptResource(Resources.AttachmentHandlerScript.Instance.GetType(), Resources.AttachmentHandlerScript.ResourceName);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            LiteralControl _oIframeControl = new LiteralControl();
            _oIframeControl.Text="<iframe id=\"AttachmentFrame\" scrolling=\"no\" width=\"0\" height=\"0\" style=\" border:0px 0px 0px 0px; margin:0px 0px 0px 0px; padding:0px 0px 0px 0px;\" ></iframe>";
            this.Controls.Add(_oIframeControl);
        }

        public override void DataBind()
        {
            base.DataBind();
        }
    }
}
