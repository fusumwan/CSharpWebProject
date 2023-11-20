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
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.WEB.UI.HTMLCONTROL.JSCONTROL;

namespace PCCW.RWL.WEB.UI.Order
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:MobileOrderAddressUserControl runat=server></{0}:MobileOrderAddressUserControl>")]
    public class MobileOrderAddressUserControl : CompositeControl
    {
        //[Bindable(true)]
        //[Category("Data")]
        //[Category("Behavior")]
        [Category("Data")]
        [DefaultValue("")]
        public string TitleNameLbl { get; set; }
        [Category("Behavior")]
        [DefaultValue("AddWebLogScriptManager")]
        public string ToolkitScriptManagerID { get; set; }

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
        [DefaultValue("disablerow")]
        public string DrpClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("highlightrow")]
        public string RblClass { get; set; }

        protected bool n_bTableTagVisable { get; set; }

        [Category("Appearance")]
        [DefaultValue(false)]
        public bool TableTagVisable
        {
            get
            {
                return n_bTableTagVisable;
            }
            set
            {
                this.n_bTableTagVisable = value;
            }
        }

        [Category("Appearance")]
        [DefaultValue("../Web/images/loading.gif")]
        public string LoadingImgSrc { get; set; }

        [Category("Appearance")]
        [DefaultValue(8)]
        public int TitleFontSize { get; set; }

        [Category("Data")]
        [DefaultValue("")]
        public string Address_type { get; set; }
        UpdatePanel AddressUpdatePanel = new UpdatePanel();


        [Category("Appearance")]
        [DefaultValue("")]
        public string DTypeClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string DRegionClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string DDistrictClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string DRoomClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string DFloorClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string DBlkClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string DBuildClass { get; set; }

        [Category("Appearance")]
        [DefaultValue("")]
        public string DStreetClass { get; set; }

        public DropDownList D_type = new DropDownList();
        public DropDownList D_district = new DropDownList();
        public RadioButtonList D_region = new RadioButtonList();
        public TextBox D_floor = new TextBox();
        public TextBox D_blk = new TextBox();
        public TextBox D_build = new TextBox();
        public TextBox D_street = new TextBox();
        public TextBox D_room = new TextBox();
        public HtmlInputHidden DRegionHidden = new HtmlInputHidden();

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
            RWLFramework.Environment.AssetModel(typeof(DeliveryTimeTrackable));
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
            Control _oControl = new Control();
            AddressUpdatePanel.ID = "AddressUpdatePanel";
            AddressUpdatePanel.UpdateMode = UpdatePanelUpdateMode.Conditional;



            if (TableTagVisable)
            {
                _oControl.Controls.Add(new LiteralControl("<table style=\"font-size:" + this.TitleFontSize.ToString() + "pt\" border=\"0\">"));
            }
            _oControl.Controls.Add(new LiteralControl("<tr class='" + this.ID.ToString() + "'>"));
            _oControl.Controls.Add(new LiteralControl("<td height=\"0\" class=\"" + this.TdOneClass + "\">"));


            Label _oTableNameLbl = new Label();
            _oTableNameLbl.ID = "delivery_address_lab";
            _oTableNameLbl.Text = this.TitleNameLbl;
            _oTableNameLbl.CssClass = this.TxtClass;
            _oControl.Controls.Add(_oTableNameLbl);


            _oControl.Controls.Add(new LiteralControl("</td>"));
            _oControl.Controls.Add(new LiteralControl("<td height=\"0\" class=\"" + this.TdTwoClass + "\">"));

            ControlAdd("<table border=\"0\">");
            ControlAdd("<tr>");
            ControlAdd("<td><span class=\"" + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">Unit/Flat/Room</span></td>");
            ControlAdd("<td><span class=\"" + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">Floor</span></td>");
            ControlAdd("<td><span class=\"" + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">Block</span></td>");
            ControlAdd("<td><span class=\"" + this.TxtClass + "\" style=\"font-size:" + this.TitleFontSize + "pt\">Building/Estate Name</span></td>");
            ControlAdd("</tr>");


            ControlAdd("<tr>");
            ControlAdd("<td>");
            D_type.ID = "d_type";
            D_type.CssClass = this.DTypeClass + " " + this.DrpClass + " " + this.ClientID + "DTypeClass";
            D_type.Enabled = this.Enabled;
            D_type.AppendDataBoundItems = true;
            D_type.Items.Add(new ListItem(string.Empty, string.Empty));
            D_type.Items.Add(new ListItem("Unit", "Unit"));
            D_type.Items.Add(new ListItem("Flat", "Flat"));
            D_type.Items.Add(new ListItem("Room", "Room"));
            ControlAdd(D_type);


            D_room.ID = "d_room";
            D_room.CssClass = this.DRoomClass + " " + this.TxtClass + " " + this.ClientID + "DRoomClass";
            D_room.Attributes["onblur"] = "chg_upper(this)";
            D_room.Font.Size = this.TitleFontSize;
            D_room.Enabled = this.Enabled;
            D_room.MaxLength = 6;
            D_room.Width = 50;
            ControlAdd(D_room);


            ControlAdd("</td>");

            ControlAdd("<td>");



            D_floor.ID = "d_floor";
            D_floor.CssClass = this.DFloorClass + " " + this.TxtClass + " " + this.ClientID + "DFloorClass";
            D_floor.Attributes["onblur"] = "chg_upper(this)";
            D_floor.Font.Size = this.TitleFontSize;
            D_floor.Enabled = this.Enabled;
            D_floor.MaxLength = 3;
            D_floor.Width = 50;
            ControlAdd(D_floor);
            /*
            ControlAdd("<input runat=\"server\" name=\"" + this.ClientID + "&d_floor\" type=\"text\" id=\"" + this.ClientID + "_d_floor\"");
            ControlAdd("class=\"" + this.DFloorClass + " " + this.TxtClass + "\" " + ((this.Enabled) ? string.Empty : "disabled=\"disabled\"") + " size=\"4\" maxlength=\"3\"");
            ControlAdd("onblur=\"chg_upper(this);\" style=\"font-size:" + this.TitleFontSize.ToString() + "pt\" />");
            */


            ControlAdd("</td>");

            ControlAdd("<td>");

            D_blk.ID = "d_blk";
            D_blk.CssClass = this.DBlkClass + " " + this.TxtClass + " " + this.ClientID + "DBlkClass";
            D_blk.Attributes["onblur"] = "chg_upper(this)";
            D_blk.Font.Size = this.TitleFontSize;
            D_blk.MaxLength = 3;
            D_blk.Enabled = this.Enabled;
            D_blk.Width = 50;
            ControlAdd(D_blk);

            ControlAdd("</td>");

            ControlAdd("<td>");

            D_build.ID = "d_build";
            D_build.CssClass = this.DBuildClass + " " + this.TxtClass + " " + this.ClientID + "DBuildClass";
            D_build.Attributes["onblur"] = "chg_upper(this)";
            D_build.Font.Size = this.TitleFontSize;
            D_build.MaxLength = 300;
            D_build.Enabled = this.Enabled;
            D_build.Width = 350;
            ControlAdd(D_build);

            ControlAdd("</td>");

            ControlAdd("<td></td>");

            ControlAdd("</tr>");




            ControlAdd("<tr>");
            ControlAdd("<td colspan=\"4\">Street No. &amp; Street Name </td>");
            ControlAdd("<td>District</td>");
            ControlAdd("</tr>");


            ControlAdd("<tr>");
            ControlAdd("<td colspan=\"4\">");

            D_street.ID = "d_street";
            D_street.CssClass = this.DStreetClass + " " + this.TxtClass + " " + this.ClientID + "DStreetClass";
            D_street.Attributes["onblur"] = "chg_upper(this)";
            D_street.Font.Size = this.TitleFontSize;
            D_street.MaxLength = 100;
            D_street.Enabled = this.Enabled;
            D_street.Width = 300;
            ControlAdd(D_street);

            ControlAdd("</td>");
            ControlAdd("<td>");


            D_district.ID = "d_district";
            D_district.CssClass = this.DDistrictClass + " " + this.DrpClass + " " + this.ClientID + "DDistrictClass";
            D_district.AppendDataBoundItems = true;
            D_district.Enabled = this.Enabled;
            D_district.AutoPostBack = true;
            D_district.SelectedIndexChanged += new EventHandler(d_district_SelectedIndexChanged);
            D_district.Items.Add(new ListItem(string.Empty, string.Empty));
            D_district.Attributes["onchange"] = "AddressLoadDDistrictTime('" + this.ClientID + "_load_d_district_time')";
            ControlAdd(D_district);
            ControlAdd("<img src=\"" + this.LoadingImgSrc + "\" name=\"" + this.ClientID + "&load_d_district_time\" id=\"" + this.ClientID + "_load_d_district_time\" style=\"display:none\" />");
            ControlAdd("</td>");
            ControlAdd("</tr>");


            ControlAdd("<tr>");
            ControlAdd("<td colspan=\"5\">");
            //ControlAdd("<asp:HiddenField id=\"" + this.ClientID + "_d_region_hidden\" class=\"" + this.ClientID + "d_region_hidden\" runat=\"server\" />");


            DRegionHidden.ID = "DRegionHidden";
            DRegionHidden.Attributes["class"] = this.ClientID + "DRegionHidden";
            DRegionHidden.Visible = true;
            ControlAdd(DRegionHidden);


            D_region.ID = "d_region";
            D_region.AppendDataBoundItems = true;
            D_region.SelectedIndexChanged += new EventHandler(d_region_SelectedIndexChanged);
            D_region.RepeatDirection = System.Web.UI.WebControls.RepeatDirection.Horizontal;
            D_region.CssClass = this.DRegionClass + " " + this.RblClass + " " + this.ClientID + "DRegionClass";
            D_region.AutoPostBack = true;
            D_region.Items.Add(new ListItem("HK", "HK"));
            D_region.Items.Add(new ListItem("KLN", "KLN"));
            D_region.Items.Add(new ListItem("NT", "NT"));
            D_region.Items.Add(new ListItem("LT", "LT"));
            D_region.Enabled = this.Enabled;
            D_region.Attributes["onclick"] = "AddressDistrictLoad('" + this.ClientID + "_d_district_loading','" + this.ClientID + "_" + D_region.ClientID + "');AddressDRegionCheckAutoPostBack('" + this.ClientID + "','" + this.ClientID + "_d_district_loading');";
            //D_region.Attributes["onclick"] = "AddressDistrictLoad('" + this.ClientID + "_d_district_loading','" + this.ClientID + "_" + D_region.ClientID + "');";
            ControlAdd(D_region);
            ControlAdd("<img src=\"" + this.LoadingImgSrc + "\" name=\"" + this.ClientID + "&d_district_loading\" id=\"" + this.ClientID + "_d_district_loading\" style=\"display:none\" />");
            ControlAdd("</td>");
            ControlAdd("</tr>");
            ControlAdd("</table>");

            Button _oAddressUpdatePanelUpdate = new Button();
            _oAddressUpdatePanelUpdate.ID = "AddressUpdatePanelUpdate";
            _oAddressUpdatePanelUpdate.CssClass = this.ClientID + "AddressUpdatePanelUpdate";
            _oAddressUpdatePanelUpdate.Visible = true;
            _oAddressUpdatePanelUpdate.Style[HtmlTextWriterStyle.Display] = "none";
            _oAddressUpdatePanelUpdate.Click += new EventHandler(AddressUpdatePanelUpdate_Click);
            ControlAdd(_oAddressUpdatePanelUpdate);



            HtmlInputHidden _oDDistrictDefault = new HtmlInputHidden();
            _oDDistrictDefault.ID = "DDistrictDefault";
            _oDDistrictDefault.Attributes["class"] = this.ClientID + "DDistrictDefault";
            _oDDistrictDefault.Visible = true;

            ControlAdd(_oDDistrictDefault);

            if (WebScriptManager == null)
            {
                WebScriptManager = (ToolkitScriptManager)this.NamingContainer.FindControl(this.ToolkitScriptManagerID);
                if (WebScriptManager != null)
                {
                    if (this.Page.IsPostBack)
                    {
                        WebScriptManager.RegisterAsyncPostBackControl(D_region);
                        WebScriptManager.RegisterAsyncPostBackControl(_oAddressUpdatePanelUpdate);
                    }
                    _oControl.Controls.Add(AddressUpdatePanel);
                }
            }


            ClientIDHidden.ID = "__" + this.ID + "Hidden__";
            ClientIDHidden.CssClass = this.ID + "Hidden";
            ClientIDHidden.Style[HtmlTextWriterStyle.Display] = "none";
            _oControl.Controls.Add(ClientIDHidden);


            ClientNameHidden.ID = "__" + this.ID + "HiddenName__";
            ClientNameHidden.CssClass = this.ID + "HiddenName";
            ClientNameHidden.Style[HtmlTextWriterStyle.Display] = "none";
            _oControl.Controls.Add(ClientNameHidden);

            _oControl.Controls.Add(new LiteralControl("</td>"));
            _oControl.Controls.Add(new LiteralControl("</tr>"));
            if (TableTagVisable)
            {
                _oControl.Controls.Add(new LiteralControl("</table>"));
            }
            this.Controls.Add(_oControl);
            CommonFunc.RegisterJavaScript(this.Page, string.Empty, "SaveClientID('" + this.ID + "')", true);
            CommonFunc.RegisterJavaScript(this.Page, string.Empty, "AddressDRegionHiddenAutoSave('" + this.ID + "')", true);
        }



        public static MobileOrderAddressUserControlRequest RequestID(string x_sID)
        {
            MobileOrderAddressUserControlRequest _oMobileOrderAddressUserControlRequest = new MobileOrderAddressUserControlRequest();
            if (HttpContext.Current.Request[x_sID + "HiddenName"] != null)
            {
                //_oMobileOrderAddressUserControlRequest.UserControlRequestIDName = HttpContext.Current.Request[x_sID + "HiddenName"].ToString();
                _oMobileOrderAddressUserControlRequest.UserControlRequestIDName = x_sID + "$";
            }
            _oMobileOrderAddressUserControlRequest.UserControlRequestIDName = x_sID + "$";
            return _oMobileOrderAddressUserControlRequest;
        }

        public static MobileOrderAddressUserControlRequest RequestName(string x_sName)
        {
            MobileOrderAddressUserControlRequest _oMobileOrderAddressUserControlRequest = new MobileOrderAddressUserControlRequest();

            _oMobileOrderAddressUserControlRequest.UserControlRequestIDName = x_sName;
            return _oMobileOrderAddressUserControlRequest;
        }

        protected void AddressUpdatePanelUpdate_Click(object sender, EventArgs e)
        {
            if (this.Page.IsPostBack)
            {
                UpdatePanel _oUpdatePanel = (UpdatePanel)this.FindControl("AddressUpdatePanel");
                if (_oUpdatePanel == null) return;
                DropDownList _oD_district = (DropDownList)_oUpdatePanel.FindControl("d_district");
                if (_oD_district == null) return;
                HtmlInputHidden _oDDistrictDefault = (HtmlInputHidden)_oUpdatePanel.FindControl("DDistrictDefault");
                if (_oDDistrictDefault == null) return;
                if (_oDDistrictDefault.Value != string.Empty)
                {
                    DropListSelectedValue(ref _oD_district, _oDDistrictDefault.Value);
                    _oDDistrictDefault.Value = string.Empty;
                }
            }
        }

        protected void d_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePanel _oUpdatePanel = (UpdatePanel)this.FindControl("AddressUpdatePanel");
            if (_oUpdatePanel == null) return;
            DropDownList _oD_district = (DropDownList)_oUpdatePanel.FindControl("d_district");
            if (_oD_district == null) return;
            HtmlInputHidden _oDDistrictDefault = (HtmlInputHidden)_oUpdatePanel.FindControl("DDistrictDefault");
            if (_oDDistrictDefault == null) return;
            if (_oDDistrictDefault.Value != string.Empty)
            {
                DropListSelectedValue(ref _oD_district, _oDDistrictDefault.Value);
                _oDDistrictDefault.Value = string.Empty;
            }
            CommonFunc.RegisterJavaScript(this.Page, string.Empty, "AddressNoLoadDDistrictTime('" + this.ClientID + "_load_d_district_time')", true);
        }

        protected void d_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ReloadDDistrict())
                throw new BusinessObjectNotFoundException("Control : " + this.ID + " reload district list fail!");
        }


        public bool ReloadDDistrict()
        {
            UpdatePanel _oUpdatePanel = (UpdatePanel)this.FindControl("AddressUpdatePanel");
            if (_oUpdatePanel == null) return false;
            DropDownList _oD_district = (DropDownList)_oUpdatePanel.FindControl("d_district");
            if (_oD_district == null) return false;
            HtmlInputHidden _oDDistrictDefault = (HtmlInputHidden)_oUpdatePanel.FindControl("DDistrictDefault");
            if (_oDDistrictDefault == null) return false;
            RadioButtonList _oD_region = (RadioButtonList)_oUpdatePanel.FindControl("d_region");
            if (_oD_region == null) return false;
            HtmlInputHidden _oDRegionHidden = (HtmlInputHidden)_oUpdatePanel.FindControl("DRegionHidden");
            if (_oDRegionHidden == null) return false;
            if (D_region.SelectedIndex != -1)
            {
                RWLFramework.Control<DeliveryTimeTrackable>().InitDeliveryTime("YES", _oD_region.SelectedValue, string.Empty);
                _oD_district.Items.Clear();
                _oD_district.Items.Add(new ListItem(string.Empty, string.Empty));

                List<string> _oLocation = FromRegisterControler.GetLocation(_oD_region.SelectedValue);
                if (_oLocation != null)
                {
                    for (int i = 0; i < _oLocation.Count; i++)
                        _oD_district.Items.Add(new ListItem(_oLocation[i].ToString(), _oLocation[i].ToString()));

                    if (_oLocation.Count > 0 && _oDDistrictDefault.Value != string.Empty)
                    {
                        DropListSelectedValue(ref _oD_district, _oDDistrictDefault.Value);
                        _oDDistrictDefault.Value = string.Empty;
                    }
                }
                _oDRegionHidden.Value = _oD_region.SelectedValue.ToString();
            }
            CommonFunc.RegisterJavaScript(this.Page, string.Empty, "AddressDistrictNoLoad('" + this.ClientID + "_d_district_loading','" + _oD_region.ClientID + "')", true);
            return true;
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

        protected void ControlAdd(string x_sHtml)
        {
            this.AddressUpdatePanel.ContentTemplateContainer.Controls.Add(new LiteralControl(x_sHtml));
        }

        protected void ControlAdd(Control x_oChild)
        {
            this.AddressUpdatePanel.ContentTemplateContainer.Controls.Add(x_oChild);
        }

        public override void DataBind()
        {
            base.DataBind();
        }
    }
}
