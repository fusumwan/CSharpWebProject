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
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;



namespace PCCW.RWL.WEB.UI.Order
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:MobileOrderThreePartyUserControl runat=server></{0}:MobileOrderThreePartyUserControl>")]
    public class MobileOrderThreePartyUserControl : CompositeControl
    {
        [Category("Data")]
        [DefaultValue("")]
        public string TitleNameLbl { get; set; }

        [Category("Behavior")]
        [DefaultValue("AddWebLogScriptManager")]
        public string ToolkitScriptManagerID { get; set; }

        [Category("Behavior")]
        [DefaultValue("")]
        public string HkIdClientScript { get; set; }

        protected bool n_bEnable = true;
        [Category("Behavior")]
        [DefaultValue("")]
        public bool Enable {
            get
            {
                return n_bEnable;
            }
            set
            {
                n_bEnable = value;
                SetEnable(value);
            }
        }

        AjaxControlToolkit.ToolkitScriptManager WebScriptManager = null;

        [Category("Appearance")]
        [DefaultValue("Ts1")]
        public string TdOneClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("Ts2")]
        public string TdTwoClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("disablerow")]
        public string TxtClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("Fs1")]
        public string SpanOneClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("Fs2")]
        public string SpanTwoClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("disablerow")]
        public string DrpClass { get; set; }

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool TableTagVisable { get; set; }

        [Category("Appearance")]
        [DefaultValue("../Web/images/loading.gif")]
        public string LoadingImgSrc { get; set; }

        [Category("Appearance")]
        [DefaultValue("~/Resources/Images/calendar.png")]
        public string CalendarImgSrc { get; set; }

        [Category("Appearance")]
        [DefaultValue(8)]
        public int TitleFontSize { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string IdTypeClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string IdType1Class { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string HkidClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string Hkid2Class { get; set; }

        public DropDownList Id_type = new DropDownList();
        public CheckBox Three_party = new CheckBox();
        public DropDownList Plural = new DropDownList();
        public TextBox Arthurization_person = new TextBox();
        public TextBox id_type1 = new TextBox();
        public TextBox hkid = new TextBox();
        public TextBox hkid2 = new TextBox();
        public TextBox contact_no = new TextBox();

        TextBox ClientIDHidden = new TextBox();
        TextBox ClientNameHidden = new TextBox();
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            this.Page.DataBind();
            RWLFramework.DataBaseConfigSetting();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Page.ClientScript.RegisterClientScriptResource(Resources.Behavior.Instance.GetType(), Resources.Behavior.ResourceName);
            this.Page.ClientScript.RegisterClientScriptResource(Resources.MobileOrderAddressUserControlJS.Instance.GetType(), Resources.MobileOrderAddressUserControlJS.ResourceName);

        }

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            this.CssClass = this.ID.ToString();
            if (TableTagVisable)
            {
                ControlAdd("<table border=\"0\">");
            }
            ControlAdd("<tr  class='" + this.ClientID + "'>");
            ControlAdd("<td class=\"" + this.TdOneClass + "\">");
            ControlAdd("<span class=\"" + this.SpanOneClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize.ToString() + "pt\">Receive SIM by 3rd party</span>");
            ControlAdd("</td>");
            ControlAdd("<td class=\"" + this.TdTwoClass + "\" colspan='10'>");
            ControlAdd("<span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize.ToString() + "pt\">");

            Three_party.ID = "three_party";
            Three_party.CssClass = this.ClientID + "three_party";
            Three_party.Attributes["value"] = "Y";
            Three_party.Attributes["onclick"] = "ReceiveSIMBy3rdPartyDetailShowChk(this.checked)";
            Three_party.Enabled = this.Enable;
            ControlAdd(Three_party);
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("<tr  class='" + this.ClientID + "'>");
            ControlAdd("<td class=\"" + this.TdOneClass + "\">");
            ControlAdd("</td>");
            ControlAdd("<td  class=\"" + this.TdTwoClass + "\" colspan=\"10\">");

            #region Table Of Receive SIM by 3rd party Detail
            ControlAdd("<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" id=\"ReceiveSIMBy3rdPartyDetailShow\" name=\"ReceiveSIMBy3rdPartyDetailShow\" class=\"ReceiveSIMBy3rdPartyDetailShow\" style=\"display:none\">");
            ControlAdd("<tr>");
            ControlAdd("<td  style=\"vertical-align:middle\">");
            ControlAdd("<span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize.ToString() + "pt;\">");
            ControlAdd("Authorization person 授權人姓名");


            Plural.ID = "plural";
            Plural.Items.Add(new ListItem(string.Empty, string.Empty));
            Plural.Items.Add(new ListItem("MR", "Mr"));
            Plural.Items.Add(new ListItem("MRS", "Mrs"));
            Plural.Items.Add(new ListItem("MISS", "Miss"));
            Plural.Items.Add(new ListItem("MS", "Ms"));
            Plural.Enabled = this.Enable;
            Plural.CssClass = this.ClientID + "plural";
            ControlAdd(Plural);


            Arthurization_person.ID = "arthurization_person";
            Arthurization_person.CssClass = this.ClientID + "arthurization_person";
            Arthurization_person.Enabled = this.Enable;
            ControlAdd(Arthurization_person);
            //ControlAdd("<input id=\""+this.ClientID+"arthurization_person\" name=\""+this.ClientID+"arthurization_person\" class=\""+this.ClientID+"arthurization_person\" maxlength=\"50\" />");
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("<tr>");
            ControlAdd("<td style=\"vertical-align:middle\">");
            ControlAdd("<span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize.ToString() + "pt;\">");
            ControlAdd("HKID NO. 授權人身份證號碼/護照號碼");

            Id_type.ID = "id_type";
            Id_type.AppendDataBoundItems = true;
            Id_type.Attributes["onchange"] = "ChkHKID('" + this.ID + "')";
            Id_type.Enabled = this.Enable;
            Id_type.CssClass = this.DrpClass+" "+this.ClientID+"id_type";

            Id_type.Items.Add(new ListItem(string.Empty, string.Empty));
            Id_type.Items.Add(new ListItem("HKID", "HKID"));
            Id_type.Items.Add(new ListItem("BR NO", "BRNO"));
            Id_type.Items.Add(new ListItem("Passport", "PP"));

            ControlAdd(Id_type);


            id_type1.ID = "id_type1";
            id_type1.CssClass = this.ClientID + "id_type1" + " " + this.TxtClass;
            id_type1.Width = 6;
            id_type1.Font.Size = this.TitleFontSize;
            id_type1.Enabled = this.Enabled;

            hkid.ID = "hkid";
            hkid.Width = 150;
            hkid.Font.Size = this.TitleFontSize;
            hkid.Attributes["onblur"] = "chg_upper(this);ChkHKID('" + this.ID + "');";
            hkid.CssClass = this.ClientID + "hkid";
            hkid.Enabled = this.Enable;
            ControlAdd(hkid);

            ControlAdd("(");

            hkid2.ID = "hkid2";
            hkid2.Width = 10;
            hkid2.Font.Size = this.TitleFontSize;
            hkid2.Attributes["onblur"] = "chg_upper(this);ChkHKID('" + this.ID + "');";
            hkid2.CssClass = this.ClientID + "hkid2";
            hkid2.Enabled = this.Enable;
            ControlAdd(hkid2);
            ControlAdd(")");

            //ControlAdd("<input name=\"" + this.ClientID + "id_type1\" type=\"text\" id=\"" + this.ClientID + "id_type1\" class=\"" + this.TxtClass + "\" readonly disabled style=\"display:none;font-size:10pt\" size=\"6\" maxlength=\"1\" class=\"" +this.IdType1Class+" "+ this.TxtClass + "\" />");
            //ControlAdd("<input name=\""+this.ClientID+"hkid\" type=\"text\" id=\""+this.ClientID+"hkid\" size=\"15\" maxlength=\"20\" onblur=\"chg_upper(this);chk_id(this);\"   style=\"font-size:"+this.TitleFontSize.ToString()+"pt\" class=\""+this.HkidClass+" "+this.TxtClass+"\" />");
            //ControlAdd("(<input name=\""+this.ClientID+"hkid2\" type=\"text\" id=\""+this.ClientID+"hkid2\" size=\"2\" maxlength=\"1\" onblur=\"chg_upper(this);chk_id(this);\"  style=\"font-size:"+this.TitleFontSize.ToString()+"pt\"  class=\""+this.Hkid2Class+" "+this.TxtClass+"\" />)");
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("<tr>");
            ControlAdd("<td style=\"vertical-align:middle\">");
            ControlAdd("<span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize.ToString() + "pt;\">");
            ControlAdd("Contact number");


            contact_no.ID = "contact_no";
            contact_no.CssClass = this.ClientID + "contact_no";
            contact_no.Font.Size = this.TitleFontSize;
            contact_no.Enabled = this.Enable;
            ControlAdd(contact_no);
            //ControlAdd("<input id=\"" + this.ClientID + "contact_no\" name=\"" + this.ClientID + "contact_no\"  />");

            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("</table>");
            #endregion


            ControlAdd("</td>");
            ControlAdd("</tr>");
            if (TableTagVisable)
            {
                ControlAdd("</table>");
            }
            ClientIDHidden.ID = "__" + this.ID + "Hidden__";
            ClientIDHidden.CssClass = this.ID + "Hidden";
            ClientIDHidden.Style[HtmlTextWriterStyle.Display] = "none";
            this.Controls.Add(ClientIDHidden);


            ClientNameHidden.ID = "__" + this.ID + "HiddenName__";
            ClientNameHidden.CssClass = this.ID + "HiddenName";
            ClientNameHidden.Style[HtmlTextWriterStyle.Display] = "none";
            this.Controls.Add(ClientNameHidden);

            CommonFunc.RegisterJavaScript(this.Page, string.Empty, "SaveClientID('" + this.ID + "')", true);

        }

        public static MobileOrderThreePartyUserControlRequest RequestID(string x_sID)
        {
            MobileOrderThreePartyUserControlRequest _oMobileOrderThreePartyUserControlRequest = new MobileOrderThreePartyUserControlRequest();
            if(HttpContext.Current.Request[x_sID + "HiddenName"] != null)
            {
                //_oMobileOrderThreePartyUserControlRequest.UserControlRequestIDName = HttpContext.Current.Request[x_sID + "HiddenName"].ToString();
                _oMobileOrderThreePartyUserControlRequest.UserControlRequestIDName = x_sID + "$";
            }
            _oMobileOrderThreePartyUserControlRequest.UserControlRequestIDName = x_sID + "$";
            return _oMobileOrderThreePartyUserControlRequest;
        }

        public static MobileOrderThreePartyUserControlRequest RequestName(string x_sName)
        {
            MobileOrderThreePartyUserControlRequest _oMobileOrderThreePartyUserControlRequest = new MobileOrderThreePartyUserControlRequest();

            _oMobileOrderThreePartyUserControlRequest.UserControlRequestIDName = x_sName;

            return _oMobileOrderThreePartyUserControlRequest;
        }

        public void Reset()
        {
            //((CheckBox)this.FindControl("three_party")).Checked = false;


            this.contact_no.Text = string.Empty;
            this.Id_type.SelectedIndex = 0;
            this.Three_party.Checked = false;
            this.Plural.SelectedIndex = 0;
            this.Arthurization_person.Text = string.Empty;
            this.id_type1.Text = string.Empty;
            this.hkid.Text = string.Empty;
            this.hkid2.Text = string.Empty;
        }

        protected void SetEnable(bool x_bEnable)
        {
            this.contact_no.Enabled = x_bEnable;
            this.Id_type.Enabled=x_bEnable;
            this.Three_party.Enabled=x_bEnable;
            this.Plural.Enabled=x_bEnable;
            this.Arthurization_person.Enabled=x_bEnable;
            this.id_type1.Enabled=x_bEnable;
            this.hkid.Enabled=x_bEnable;
            this.hkid2.Enabled=x_bEnable;
        }

        protected void ControlAdd(string x_sHtml)
        {
            this.Controls.Add(new LiteralControl(x_sHtml));
        }

        protected void ControlAdd(Control x_oChild)
        {
            this.Controls.Add(x_oChild);
        }

        protected override void Render(HtmlTextWriter w)
        {
            base.Render(w);
        }

        public override void DataBind()
        {
            base.DataBind();
        }
    }
}
