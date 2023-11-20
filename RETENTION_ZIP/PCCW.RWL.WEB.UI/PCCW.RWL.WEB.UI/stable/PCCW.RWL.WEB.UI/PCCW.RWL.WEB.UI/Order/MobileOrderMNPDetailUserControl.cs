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
    [ToolboxData("<{0}:MobileOrderMNPDetailUserControl runat=server></{0}:MobileOrderMNPDetailUserControl>")]
    public class MobileOrderMNPDetailUserControl : CompositeControl
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
        //[DefaultValue(false)]
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
        public string RegisterNameClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string TransferTo3GClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string TransferIddDepositClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string TransferIddRoamingDepositClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string TransferNoHkIdHolderDepositClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string TransferNoAddProofDepositClass { get; set; }
        
        [Category("Appearance")]
        [DefaultValue("")]
        public string TransferOthersDepositClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string IdTypeClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string Id1TypeClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string HkidClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string Hkid2Class { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string ServiceActivationTimeClass { get; set; }

        ImageButton CalenderImageServiceActivationDate = new ImageButton();
        public MobileOrderMNPDetail MobileOrderMNPDetailData = new MobileOrderMNPDetail();
        public TextBox id_type1 = new TextBox();

        public DropDownList Company_name = new DropDownList();
        public DropDownList Id_type = new DropDownList();
        public TextBox Service_activation_date = new TextBox();
        public TextBox hkid = new TextBox();
        public TextBox hkid2 = new TextBox();
        public TextBox registered_name = new TextBox();
        public CheckBox Transfer_to_3g = new CheckBox();
        public TextBox Transfer_idd_deposit = new TextBox();
        public TextBox Transfer_idd_roaming_deposit = new TextBox();
        public TextBox Transfer_no_hk_id_holder_deposit = new TextBox();
        public TextBox Transfer_no_add_proof_deposit = new TextBox();
        public TextBox Transfer_others_deposit = new TextBox();
        public DropDownList Service_activation_time = new DropDownList();
        public TextBox Ticker_number = new TextBox();

        public CalendarExtender CalendarServiceActivationDateFormat = new CalendarExtender();
        Button ServiceActivationDateClear = new Button();
        
        TextBox ClientIDHidden = new TextBox();
        TextBox ClientNameHidden = new TextBox();
        protected override void Render(HtmlTextWriter w)
        {
            base.Render(w);
        }

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
                ControlAdd("<table border=\"0\" id=\"mnp_information_show\" width='100%'>");
            }
            ControlAdd("<tr class='" + this.ClientID + "'>");
            ControlAdd("<td class=\"" + this.TdOneClass + "\"><span class=\"" + this.SpanOneClass+" "+this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">2N Company Name</span></td>");
            ControlAdd("<td class=\"" + this.TdTwoClass + "\" colspan='10'><span class=\"" + this.SpanTwoClass +" "+this.TxtClass+ "\" style=\"font-size:" + this.TitleFontSize + "pt\">");


            Company_name.ID = "company_name";
            Company_name.CssClass = this.ClientID + "company_name";
            Company_name.AppendDataBoundItems = true;
            Company_name.Items.Add(new ListItem(string.Empty, string.Empty));
            Company_name.Items.Add(new ListItem("PCCW 2G", "PCCW 2G"));
            Company_name.Attributes["onchange"] = "add_amount()";
            Company_name.Enabled = this.Enabled;
            ControlAdd(Company_name);

            ControlAdd("</span></td>");
            ControlAdd("</tr>");

            ControlAdd("<tr class='" + this.ClientID + "'>");
            ControlAdd("<td class=\"" + this.TdOneClass + "\"><span class=\"" + this.SpanOneClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">2N Registered Name</span></td>");
            ControlAdd("<td class=\"" + this.TdTwoClass + "\" colspan='10'><span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">");
            
            registered_name.ID = "registered_name";
            registered_name.CssClass = this.ClientID + "registered_name";
            registered_name.Width = 300;
            registered_name.Enabled = this.Enabled;
            ControlAdd(registered_name);
            
            //ControlAdd("<input id=\"" + this.ClientID + "registered_name\" name=\"" + this.ClientID + "registered_name\" size=\"50\"  />");
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");


            ControlAdd("<tr class='" + this.ID + "'>");
            ControlAdd("<td class=\"" + this.TdOneClass + "\"><span class=\"" + this.SpanOneClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">2N Registered HKID No.</span></td>");
            ControlAdd("<td class=\"" + this.TdTwoClass + "\" colspan='10'>");
            ControlAdd("<span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">");


            Id_type.ID = "id_type";
            Id_type.AppendDataBoundItems = true;
            Id_type.Attributes["onchange"] = "ChkHKID('" + this.ID + "')";
            Id_type.CssClass =this.ClientID+"id_type"+" "+ this.DrpClass;
            Id_type.Enabled = this.Enabled;
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
            hkid.Enabled = this.Enabled;
            ControlAdd(hkid);

            ControlAdd("(");

            hkid2.ID = "hkid2";
            hkid2.Width = 10;
            hkid2.Font.Size = this.TitleFontSize;
            hkid2.Attributes["onblur"] = "chg_upper(this);ChkHKID('" + this.ID + "');";
            hkid2.CssClass = this.ClientID + "hkid2";
            hkid2.Enabled = this.Enabled;
            ControlAdd(hkid2);
            ControlAdd(")");

            //ControlAdd("<input class=\"" + this.IdTypeClass + " " + this.TxtClass + "\" name=\"" + this.ClientID + "id_type1\" type=\"text\" id=\"" + this.ClientID + "id_type1\" class=\"" + this.TxtClass + "\" readonly=\"readonly\" disabled=\"disabled\" style=\"display:none;font-size:10pt\" size=\"6\" maxlength=\"1\" />");
            //ControlAdd("<input class=\"" + this.HkidClass + " " + this.TxtClass + "\" name=\"" + this.ClientID + "hkid\" type=\"text\" id=\"" + this.ClientID + "hkid\" size=\"15\" maxlength=\"20\" onblur=\"" + this.HkIdClientScript + "\"   style=\"font-size:" + this.TitleFontSize + "pt\" class=\"" + this.TxtClass + "\" />");
            //ControlAdd("( <input class=\"" + this.Hkid2Class + " " + this.TxtClass + "\" name=\"" + this.ClientID + "hkid2\" type=\"text\" id=\"" + this.ClientID + "hkid2\" size=\"2\" maxlength=\"1\" onblur=\"" + this.HkIdClientScript + "\"  style=\"font-size:" + this.TitleFontSize + "pt\"  class=\"" + this.TxtClass + "\" />)");


            Button CopyButton = new Button();
            CopyButton.ID = "CopyButton";
            CopyButton.CssClass= this.ClientID + "CopyButton";
            CopyButton.Text = "Copy Form Customer Data";
            CopyButton.OnClientClick = "CopyCustomData('" + this.ID + "');return false;";
            CopyButton.UseSubmitBehavior = false;
            CopyButton.Enabled = this.Enabled;
            ControlAdd(CopyButton);
            //ControlAdd("<input type='button' id='"+this.ClientID+"CopyButton' onclick='CopyCustomData('" + this.ID + "');' value='Copy Form Customer Data' />");
            
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("<tr class='" + this.ID + "'>");
            ControlAdd("<td class=\"" + this.TdOneClass + "\"><span class=\"" + this.SpanOneClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">2G IDD / Roaming Deposit Transfer to 3G</span></td>");
            ControlAdd("<td class=\"" + this.TdTwoClass + "\" colspan='10'>");

            
            Transfer_to_3g.ID = "transfer_to_3g";
            Transfer_to_3g.CssClass = this.ClientID + "transfer_to_3g" + " " + this.TransferTo3GClass;
            Transfer_to_3g.Attributes["onclick"] = "TransferTo3GShow(this.checked)";
            Transfer_to_3g.Attributes["value"] = "true";
            Transfer_to_3g.Enabled = this.Enabled;
            ControlAdd(Transfer_to_3g);
            //ControlAdd("<input class=\"" + this.TransferTo3GClass + "\"  type=\"checkbox\" id=\"" + this.ClientID + "transfer_to_3g\" name=\"" + this.ClientID + "transfer_to_3g\" value=\"Y\" />");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("<tr id=\"transfer_to_3g_show\" name=\"transfer_to_3g_show\" class=\"transfer_to_3g_show\" style=\"display:none\">");
            ControlAdd("<td class=\"" + this.TdOneClass + "\"></td>");
            ControlAdd("<td class=\"" + this.TdTwoClass + "\" colspan='10'>");
            ControlAdd("<span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">");
            ControlAdd("<p>");
            ControlAdd("Transfer IDD deposit");

            Transfer_idd_deposit.ID = "transfer_idd_deposit";
            Transfer_idd_deposit.Width = 50;
            Transfer_idd_deposit.CssClass = this.ClientID + "transfer_idd_deposit" + " " + this.TransferIddDepositClass + " " + this.TxtClass;
            Transfer_idd_deposit.Enabled = this.Enabled;
            ControlAdd(Transfer_idd_deposit);
            //ControlAdd("<input  class=\"" + this.TransferIddDepositClass + " " + this.TxtClass + "\" name=\"" + this.ClientID + "transfer_idd_deposit\" id=\"" + this.ClientID + "transfer_idd_deposit\" size=\"5\"   type=\"text\" />");
            ControlAdd("</p>");
            ControlAdd("<p>");
            ControlAdd("Transfer IDD & roaming deposit");

            
            Transfer_idd_roaming_deposit.ID = "transfer_idd_roaming_deposit";
            Transfer_idd_roaming_deposit.Width = 50;
            Transfer_idd_roaming_deposit.CssClass = this.ClientID + "transfer_idd_roaming_deposit" + " " + this.TransferIddRoamingDepositClass + " " + this.TxtClass;
            Transfer_idd_roaming_deposit.Enabled = this.Enabled;
            ControlAdd(Transfer_idd_roaming_deposit);

            //ControlAdd("<input class=\"" + this.TransferIddRoamingDepositClass + " " + this.TxtClass + "\" name=\"" + this.ClientID + "transfer_idd_roaming_deposit\" id=\"" + this.ClientID + "transfer_idd_roaming_deposit\" size=\"5\"   type=\"text\" />");
            ControlAdd("</p>");
            ControlAdd("<p>");
            ControlAdd("Transfer Non-HK ID holder deposit");


            Transfer_no_hk_id_holder_deposit.ID = "transfer_no_hk_id_holder_deposit";
            Transfer_no_hk_id_holder_deposit.Width = 50;
            Transfer_no_hk_id_holder_deposit.CssClass = this.ClientID + "transfer_no_hk_id_holder_deposit" + " " + this.TransferNoHkIdHolderDepositClass + " " + this.TxtClass;
            Transfer_no_hk_id_holder_deposit.Enabled = this.Enabled;
            ControlAdd(Transfer_no_hk_id_holder_deposit);

            //ControlAdd("<input class=\"" + this.TransferNoHkIdHolderDepositClass + " " + this.TxtClass + "\" name=\"" + this.ClientID + "transfer_no_hk_id_holder_deposit\" id=\"" + this.ClientID + "transfer_no_hk_id_holder_deposit\" size=\"5\"   type=\"text\" />");
            ControlAdd("</p>");
            ControlAdd("<p>");
            ControlAdd("Transfer no address proof deposit");

            
            Transfer_no_add_proof_deposit.ID = "transfer_no_add_proof_deposit";
            Transfer_no_add_proof_deposit.Width = 50;
            Transfer_no_add_proof_deposit.CssClass = this.ClientID + "transfer_no_add_proof_deposit" + " " + this.TransferNoAddProofDepositClass + " " + this.TxtClass;
            Transfer_no_add_proof_deposit.Enabled = this.Enabled;
            ControlAdd(Transfer_no_add_proof_deposit);

            //ControlAdd("<input class=\"" + this.TransferNoAddProofDepositClass + " " + this.TxtClass + "\" name=\"" + this.ClientID + "transfer_no_add_proof_deposit\" id=\"" + this.ClientID + "transfer_no_add_proof_deposit\" size=\"5\"   type=\"text\" />");
            ControlAdd("</p>");
            ControlAdd("<p>");
            ControlAdd("Transfer others deposit");

            
            Transfer_others_deposit.ID = "transfer_others_deposit";
            Transfer_others_deposit.Width = 50;
            Transfer_others_deposit.CssClass = this.ClientID + "transfer_others_deposit" + " " + this.TransferOthersDepositClass + " " + this.TxtClass;
            Transfer_others_deposit.Enabled = this.Enabled;
            ControlAdd(Transfer_others_deposit);

            //ControlAdd("<input class=\"" + this.TransferOthersDepositClass + " " + this.TxtClass + "\" name=\"" + this.ClientID + "transfer_others_deposit\" id=\"" + this.ClientID + "transfer_others_deposit\" size=\"5\"  type=\"text\"  />");
            ControlAdd("</p>");
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("<tr class='" + this.ID + "'>");
            ControlAdd("<td  class=\"" + this.TdOneClass + "\">");
            ControlAdd("<span class=\"" + this.SpanOneClass +" "+this.TxtClass+ "\" style=\"font-size:" + this.TitleFontSize + "pt\">");
            ControlAdd("Service Activation Date (AM/PM)");
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("<td  class=\"" + this.TdTwoClass + "\"  colspan='10'>");
            ControlAdd("<span class=\"" + this.SpanTwoClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">");


            Service_activation_date.ID = "service_activation_date";
            Service_activation_date.CssClass = this.ClientID + "service_activation_date";
            Service_activation_date.ReadOnly = true;
            Service_activation_date.MaxLength = 10;
            Service_activation_date.Font.Size = this.TitleFontSize;
            Service_activation_date.Enabled = this.Enabled;
            ControlAdd(Service_activation_date);


            CalenderImageServiceActivationDate.ID = "CalenderImageServiceActivationDate";
            CalenderImageServiceActivationDate.ImageUrl = this.CalendarImgSrc;
            CalenderImageServiceActivationDate.OnClientClick = "return false";
            ControlAdd(CalenderImageServiceActivationDate);
            
            CalendarServiceActivationDateFormat.TargetControlID = Service_activation_date.ID;
            CalendarServiceActivationDateFormat.Format = "dd/MM/yyyy";
            CalendarServiceActivationDateFormat.PopupButtonID = CalenderImageServiceActivationDate.ID;
            CalendarServiceActivationDateFormat.Enabled = this.Enabled;
            ControlAdd(CalendarServiceActivationDateFormat);

            
            Service_activation_time.ID = "service_activation_time";
            Service_activation_time.Items.Add(new ListItem(string.Empty, string.Empty));
            Service_activation_time.Items.Add(new ListItem("AM", "AM"));
            Service_activation_time.Items.Add(new ListItem("PM", "PM"));
            Service_activation_time.Enabled = this.Enabled;
            Service_activation_time.CssClass = this.ClientID + "service_activation_time" + " " + this.ServiceActivationTimeClass+" "+this.DrpClass;
            ControlAdd(Service_activation_time);
            /*
            ControlAdd("<select class=\"" + this.ClientID + "service_activation_time" + " " + this.ServiceActivationTimeClass + "\" id=\"" + this.ClientID + "service_activation_time\" name=\"" + this.ClientID + "service_activation_time\"  >");
            ControlAdd("<option value=\"\"></option>");
            ControlAdd("<option value=\"AM\">AM</option>");
            ControlAdd("<option value=\"PM\">PM</option>");
            ControlAdd("</select>");
            */
            
            ServiceActivationDateClear.UseSubmitBehavior = false;
            ServiceActivationDateClear.ID = "ServiceActivationDateClear";
            ServiceActivationDateClear.CssClass = this.ClientID + "ServiceActivationDateClear";
            ServiceActivationDateClear.Text = "Clear";
            ServiceActivationDateClear.OnClientClick = "ServiceActivationDateClearChk('" + this.ClientID + "');return false";
            ServiceActivationDateClear.Enabled = this.Enabled;
            ControlAdd(ServiceActivationDateClear);

            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("</tr>");

            ControlAdd("<tr class='" + this.ID + "'>");
            ControlAdd("<td class=\"" + this.TdOneClass + "\">");
            ControlAdd("<span class=\"" + this.SpanOneClass + " " + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">");
            ControlAdd("Ticker number");
            ControlAdd("</span>");
            ControlAdd("</td>");
            ControlAdd("<td  class=\"" + this.TdTwoClass + "\"  colspan='10'>");
            
            Ticker_number.ID = "ticker_number";
            Ticker_number.CssClass = this.ClientID + "ticker_number"+" "+this.TxtClass;
            Ticker_number.MaxLength = 10;
            Ticker_number.Enabled = this.Enabled;
            ControlAdd(Ticker_number);
            //ControlAdd("<input id=\"" + this.ClientID + "ticker_number\" name=\"" + this.ClientID + "ticker_number\"  />");
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



        #region DropListSelectedValue
        public void DropListSelectedValue(ref DropDownList x_oDrp, string x_sValue)
        {
            DropListSelectedValue(ref x_oDrp, x_sValue, true);
        }
        public void DropListSelectedValue(ref DropDownList x_oDrp, string x_sValue, bool x_bMustSelect)
        {
            bool _bFlag = false;
            for (int i = 0; i < x_oDrp.Items.Count; i++)
            {
                if (x_oDrp.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
                {
                    x_oDrp.SelectedIndex = i;
                    x_oDrp.SelectedValue = x_sValue;
                    _bFlag = true;
                }
            }

            if (x_bMustSelect && !_bFlag && !x_sValue.Trim().Equals(string.Empty))
            {
                x_oDrp.Items.Add(new ListItem(x_sValue, x_sValue));
                x_oDrp.SelectedValue = x_sValue;
            }
        }
        #endregion

        #region RadioListSelectedValue
        public void RadioListSelectedValue(ref RadioButtonList x_oDrp, string x_sValue)
        {
            RadioListSelectedValue(ref x_oDrp, x_sValue, true);
        }
        public void RadioListSelectedValue(ref RadioButtonList x_oDrp, string x_sValue, bool x_bMustSelect)
        {
            bool _bFlag = false;
            for (int i = 0; i < x_oDrp.Items.Count; i++)
            {
                if (x_oDrp.Items[i].Value.ToUpper().Trim() == x_sValue.ToUpper().Trim())
                {
                    x_oDrp.SelectedIndex = i;
                    x_oDrp.SelectedValue = x_sValue;
                    _bFlag = true;
                }
            }

            if (x_bMustSelect && !_bFlag && !x_sValue.Trim().Equals(string.Empty))
            {
                x_oDrp.Items.Add(new ListItem(x_sValue, x_sValue));
                x_oDrp.SelectedValue = x_sValue;
            }
        }
        #endregion

        public static MobileOrderMNPDetailUserControlRequest RequestID(string x_sID)
        {
            MobileOrderMNPDetailUserControlRequest _oMobileOrderMNPDetailUserControlRequest = new MobileOrderMNPDetailUserControlRequest();
            if (HttpContext.Current.Request[x_sID + "HiddenName"] != null)
            {
                //_oMobileOrderMNPDetailUserControlRequest.UserControlRequestIDName = HttpContext.Current.Request[x_sID + "HiddenName"].ToString();
                _oMobileOrderMNPDetailUserControlRequest.UserControlRequestIDName = x_sID + "$";
            }
            _oMobileOrderMNPDetailUserControlRequest.UserControlRequestIDName = x_sID + "$";
            return _oMobileOrderMNPDetailUserControlRequest;
        }

        public static MobileOrderMNPDetailUserControlRequest RequestName(string x_sName)
        {
            MobileOrderMNPDetailUserControlRequest _oMobileOrderMNPDetailUserControlRequest = new MobileOrderMNPDetailUserControlRequest();

            _oMobileOrderMNPDetailUserControlRequest.UserControlRequestIDName = x_sName;

            return _oMobileOrderMNPDetailUserControlRequest;
        }


        protected void ControlAdd(string x_sHtml)
        {
            this.Controls.Add(new LiteralControl(x_sHtml));
        }

        protected void ControlAdd(Control x_oChild)
        {
            this.Controls.Add(x_oChild);
        }



        public override void DataBind()
        {
            base.DataBind();
        }

    }
}
