using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using NEURON.WEB.UI.HTMLCONTROL;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-12-09>
///-- Description:	<Description,Class :NHtmlTableCell, Data Access Object Control>
///-- =============================================
namespace NEURON.WEB.UI.HTMLCONTROL.HTMLTABLECELL
{

    public class NHtmlTableCell : IDisposable, NHtmlContainerControl
    {
        protected string ToHtml()
        {
            if(string.IsNullOrEmpty(this.TagName)) return string.Empty;
            StringBuilder _oHtmlCell = new StringBuilder();
            _oHtmlCell.Append("<" + this.TagName+ " " + GetAttSetting() + " " + GetEventSetting() + " >");
            _oHtmlCell.Append(this.InnerText);
            if (ContainerControl != null)
            {
                for (int i = 0; i < ContainerControl.Count; i++)
                    _oHtmlCell.Append(ContainerControl[i].ToInnerHtml());
            }
            _oHtmlCell.Append("</" + this.TagName + ">");
            return _oHtmlCell.ToString();
        }

        #region ControlsAdd
        public void ControlsAdd(NHtmlContainerControl x_oControl)
        {
            if (x_oControl.Id.Equals(string.Empty)) return;
            if (this.ContainerControl.ContainsKey(x_oControl.Id))
                this.ContainerControl[x_oControl.Id] = x_oControl;
            else
                this.ContainerControl.Add(x_oControl.Id, x_oControl);
        }
        #endregion

        #region ControlsRemoveId
        public bool ControlsRemoveId(string x_sId)
        {
            if (this.ContainerControl.ContainsKey(x_sId))
            {
                this.ContainerControl.Remove(x_sId);
                return true;
            }
            return false;
        }
        #endregion

        #region AssignStyle
        public void AssignStyle(string x_sStyle, string x_sValue)
        {
            if (x_sStyle.Equals(string.Empty)) return;
            if (this.Style.ContainsKey(x_sStyle))
                this.Style[x_sStyle] = x_sValue;
            else
                this.Style.Add(x_sStyle, x_sValue);
        }
        #endregion

        #region GetAttSettring
        protected string GetAttSetting()
        {
            StringBuilder _oHtmlControlAtt = new StringBuilder();
            if (!string.IsNullOrEmpty(this.Id))
                _oHtmlControlAtt.Append(" id=\"" + this.Id.ToString() + "\" ");



            if (!string.IsNullOrEmpty(this.CssClass))
                _oHtmlControlAtt.Append(" class=\"" + this.CssClass + "\" ");

            if (this.Disabled)
                _oHtmlControlAtt.Append(" disabled=\"disabled\" ");

            if (!string.IsNullOrEmpty(this.Name))
                _oHtmlControlAtt.Append(" name=\"" + this.Name + "\" ");

            if (this.Style != null)
                _oHtmlControlAtt.Append(" style=\"" + this.GetStyleSetting() + "\" ");



            if (this.Visible)
                _oHtmlControlAtt.Append(" visible=\"true\" ");
            else
                _oHtmlControlAtt.Append(" visible=\"false\" ");

            return _oHtmlControlAtt.ToString();
        }
        #endregion

        #region GetEventSetting
        protected string GetEventSetting()
        {
            StringBuilder _oHtmlEventAtt = new StringBuilder();
            if (!string.IsNullOrEmpty(this.Events.OnBlur))
                _oHtmlEventAtt.Append(" onblur=\"" + this.Events.OnBlur + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnChange))
                _oHtmlEventAtt.Append(" onchange=\"" + this.Events.OnChange + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnClick))
                _oHtmlEventAtt.Append(" onclick=\"" + this.Events.OnClick + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnDataBinding))
                _oHtmlEventAtt.Append(" ondatabinding=\"" + this.Events.OnDataBinding + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnDblClick))
                _oHtmlEventAtt.Append(" ondblclick=\"" + this.Events.OnDblClick + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnDisposed))
                _oHtmlEventAtt.Append(" ondisposed=\"" + this.Events.OnDisposed + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnFocus))
                _oHtmlEventAtt.Append(" onfocus=\"" + this.Events.OnFocus + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnFocus))
                _oHtmlEventAtt.Append(" onfocus=\"" + this.Events.OnFocus + "\" ");

            if (!string.IsNullOrEmpty(this.Events.Oninit))
                _oHtmlEventAtt.Append(" oninit=\"" + this.Events.Oninit + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnKeydown))
                _oHtmlEventAtt.Append(" onkeydown=\"" + this.Events.OnKeydown + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnKeypress))
                _oHtmlEventAtt.Append(" onkeypress=\"" + this.Events.OnKeypress + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnKeyup))
                _oHtmlEventAtt.Append(" onkeyup=\"" + this.Events.OnKeyup + "\" ");

            if (!string.IsNullOrEmpty(this.Events.Onload))
                _oHtmlEventAtt.Append(" onload=\"" + this.Events.Onload + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnMouseDown))
                _oHtmlEventAtt.Append(" onmousedown=\"" + this.Events.OnMouseDown + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnMouseMove))
                _oHtmlEventAtt.Append(" onmousemove=\"" + this.Events.OnMouseMove + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnMouseOut))
                _oHtmlEventAtt.Append(" onmouseout=\"" + this.Events.OnMouseOut + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnMouseOver))
                _oHtmlEventAtt.Append(" onmouseover=\"" + this.Events.OnMouseOver + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnMouseUp))
                _oHtmlEventAtt.Append(" onmouseup=\"" + this.Events.OnMouseUp + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnPrerender))
                _oHtmlEventAtt.Append(" onprerender=\"" + this.Events.OnPrerender + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnServerChange))
                _oHtmlEventAtt.Append(" onserverchange=\"" + this.Events.OnServerChange + "\" ");

            if (!string.IsNullOrEmpty(this.Events.OnUnload))
                _oHtmlEventAtt.Append(" onunload=\"" + this.Events.OnUnload + "\" ");

            return _oHtmlEventAtt.ToString();
        }
        #endregion

        #region GetStyleSetting
        protected string GetStyleSetting()
        {
            if (this.Style == null) return string.Empty;
            StringBuilder _oStyle = new StringBuilder();
            IDictionaryEnumerator _oItem = this.Style.GetEnumerator();
            while (_oItem.MoveNext())
            {
                if (!_oItem.Key.ToString().Equals(string.Empty) &&
                    !_oItem.Value.ToString().Equals(string.Empty))
                {
                    if (!string.IsNullOrEmpty(_oStyle.ToString())) _oStyle.Append(";");
                    _oStyle.Append(_oItem.Key.ToString() + ":" + _oItem.Value.ToString());
                }
            }
            return _oStyle.ToString();
        }
        #endregion

        protected string n_sVAlign = global::System.String.Empty;
        #region VAlign
        public string VAlign
        {
            get
            {
                return this.n_sVAlign;
            }
            set
            {
                this.n_sVAlign = value;
            }
        }
        #endregion VAlign


        protected HtmlEvents n_oEvents = new HtmlEvents();
        #region Events
        public HtmlEvents Events
        {
            get
            {
                return this.n_oEvents;
            }
            set
            {
                this.n_oEvents = value;
            }
        }
        #endregion Events


        protected string n_sTagName = global::System.String.Empty;
        #region TagName
        public string TagName
        {
            get
            {
                return this.n_sTagName;
            }
            set
            {
                this.n_sTagName = value;
            }
        }
        #endregion TagName


        protected string n_sAlign = global::System.String.Empty;
        #region Align
        public string Align
        {
            get
            {
                return this.n_sAlign;
            }
            set
            {
                this.n_sAlign = value;
            }
        }
        #endregion Align


        protected string n_sBorderColor = global::System.String.Empty;
        #region BorderColor
        public string BorderColor
        {
            get
            {
                return this.n_sBorderColor;
            }
            set
            {
                this.n_sBorderColor = value;
            }
        }
        #endregion BorderColor

        
        protected HtmlControlList n_oContainerControl = new HtmlControlList();
        #region ContainerControl
        public HtmlControlList ContainerControl
        {
            get
            {
                return this.n_oContainerControl;
            }
            set
            {
                this.n_oContainerControl = value;
            }
        }
        #endregion ContainerControl


        protected string n_sRowSpan = global::System.String.Empty;
        #region RowSpan
        public string RowSpan
        {
            get
            {
                return this.n_sRowSpan;
            }
            set
            {
                this.n_sRowSpan = value;
            }
        }
        #endregion RowSpan


        protected string n_sHeight = global::System.String.Empty;
        #region Height
        public string Height
        {
            get
            {
                return this.n_sHeight;
            }
            set
            {
                this.n_sHeight = value;
            }
        }
        #endregion Height


        protected string n_sInnerText = global::System.String.Empty;
        #region InnerText
        public string InnerText
        {
            get
            {
                return this.n_sInnerText;
            }
            set
            {
                this.n_sInnerText = value;
            }
        }
        #endregion InnerText


        protected string n_sInnerHtml = global::System.String.Empty;
        #region InnerHtml
        public string InnerHtml
        {
            get
            {
                this.n_sInnerHtml = this.ToHtml();
                return this.n_sInnerHtml;
            }
            set
            {
                //this.n_sInnerHtml = value;
            }
        }
        #endregion InnerHtml

        protected string n_sNoWrap = global::System.String.Empty;
        #region NoWrap
        public string NoWrap
        {
            get
            {
                return this.n_sNoWrap;
            }
            set
            {
                this.n_sNoWrap = value;
            }
        }
        #endregion NoWrap


        protected string n_sId = global::System.String.Empty;
        #region Id
        public string Id
        {
            get
            {
                return this.n_sId;
            }
            set
            {
                this.n_sId = value;
            }
        }
        #endregion Id


        protected string n_sColSpan = global::System.String.Empty;
        #region ColSpan
        public string ColSpan
        {
            get
            {
                return this.n_sColSpan;
            }
            set
            {
                this.n_sColSpan = value;
            }
        }
        #endregion ColSpan


        protected string n_sBgColor = global::System.String.Empty;
        #region BgColor
        public string BgColor
        {
            get
            {
                return this.n_sBgColor;
            }
            set
            {
                this.n_sBgColor = value;
            }
        }
        #endregion BgColor


        protected Hashtable n_oStyle = new Hashtable();
        #region Style
        public Hashtable Style
        {
            get
            {
                return this.n_oStyle;
            }
            set
            {
                this.n_oStyle = value;
            }
        }
        #endregion Style


        protected string n_sWidth = global::System.String.Empty;
        #region Width
        public string Width
        {
            get
            {
                return this.n_sWidth;
            }
            set
            {
                this.n_sWidth = value;
            }
        }
        #endregion Width

        protected string n_sCssClass = global::System.String.Empty;
        #region CssClass
        public string CssClass
        {
            get
            {
                return this.n_sCssClass;
            }
            set
            {
                this.n_sCssClass = value;
            }
        }
        #endregion

        protected bool n_bDisabled = false;
        #region Disabled
        public bool Disabled
        {
            get
            {
                return n_bDisabled;
            }
            set
            {
                this.n_bDisabled = value;
            }
        }
        #endregion

        protected string n_sName = global::System.String.Empty;
        #region Name
        public string Name
        {
            get
            {
                return this.n_sName;
            }
            set
            {
                this.n_sName = value;
            }
        }
        #endregion

        protected bool n_bVisible = true;
        #region Visible
        public bool Visible
        {
            get
            {
                return this.n_bVisible;
            }
            set
            {
                this.Visible = value;
            }
        }
        #endregion


        #region Para
        public class Para
        {
            public const string VAlign = "VAlign";
            public const string Events = "Events";
            public const string TagName = "TagName";
            public const string Align = "Align";
            public const string BorderColor = "BorderColor";
            public const string ContainerControl = "ContainerControl";
            public const string RowSpan = "RowSpan";
            public const string Height = "Height";
            public const string InnerText = "InnerText";
            public const string NoWrap = "NoWrap";
            public const string Id = "Id";
            public const string ColSpan = "ColSpan";
            public const string BgColor = "BgColor";
            public const string Style = "Style";
            public const string Width = "Width";
            public const string CssClass = "CssClass";
            public const string Disabled = "Disabled";
            public const string Visible = "Visible";
            public const string Name = "Name";
        }
        #endregion Para

        #region Constructor & Destructor
        public NHtmlTableCell(string x_sTagName) {
            this.TagName = x_sTagName;
        }
        ~NHtmlTableCell() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public bool GetVisible() { return this.Visible; }
        public string GetName() { return this.Name; }
        public bool GetDisabled() { return this.Disabled; }
        public string GetCssClass() { return this.CssClass; }
        public string GetVAlign() { return this.VAlign; }
        public HtmlEvents GetEvents() { return this.Events; }
        public string GetTagName() { return this.TagName; }
        public string GetAlign() { return this.Align; }
        public string GetBorderColor() { return this.BorderColor; }
        public HtmlControlList GetContainerControl() { return this.ContainerControl; }
        public string GetRowSpan() { return this.RowSpan; }
        public string GetHeight() { return this.Height; }
        public string GetInnerText() { return this.InnerText; }
        public string GetNoWrap() { return this.NoWrap; }
        public string GetId() { return this.Id; }
        public string GetColSpan() { return this.ColSpan; }
        public string GetBgColor() { return this.BgColor; }
        public Hashtable GetStyle() { return this.Style; }
        public string GetWidth() { return this.Width; }

        public bool SetVisible(bool value)
        {
            this.Visible = value;
            return true;
        }
        public bool SetName(string value)
        {
            this.Name = value;
            return true;
        }
        public bool SetDisabled(bool value)
        {
            this.Disabled = value;
            return true;
        }
        public bool SetCssClass(string value)
        {
            this.CssClass = value;
            return true;
        }
        public bool SetVAlign(string value)
        {
            this.VAlign = value;
            return true;
        }
        public bool SetEvents(HtmlEvents value)
        {
            this.Events = value;
            return true;
        }
        public bool SetTagName(string value)
        {
            this.TagName = value;
            return true;
        }
        public bool SetAlign(string value)
        {
            this.Align = value;
            return true;
        }
        public bool SetBorderColor(string value)
        {
            this.BorderColor = value;
            return true;
        }
        public bool SetContainerControl(HtmlControlList value)
        {
            this.ContainerControl = value;
            return true;
        }
        public bool SetRowSpan(string value)
        {
            this.RowSpan = value;
            return true;
        }
        public bool SetHeight(string value)
        {
            this.Height = value;
            return true;
        }
        public bool SetInnerText(string value)
        {
            this.InnerText = value;
            return true;
        }
        public bool SetNoWrap(string value)
        {
            this.NoWrap = value;
            return true;
        }
        public bool SetId(string value)
        {
            this.Id = value;
            return true;
        }
        public bool SetColSpan(string value)
        {
            this.ColSpan = value;
            return true;
        }
        public bool SetBgColor(string value)
        {
            this.BgColor = value;
            return true;
        }
        public bool SetStyle(Hashtable value)
        {
            this.Style = value;
            return true;
        }
        public bool SetWidth(string value)
        {
            this.Width = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(NHtmlTableCell x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Visible.Equals(x_oObj.Visible)) { return false; }
            if (!this.Name.Equals(x_oObj.Name)) { return false; }
            if (!this.Disabled.Equals(x_oObj.Disabled)) { return false; }
            if (!this.CssClass.Equals(x_oObj.CssClass)) { return false; }
            if (!this.VAlign.Equals(x_oObj.VAlign)) { return false; }
            if (!this.Events.Equals(x_oObj.Events)) { return false; }
            if (!this.TagName.Equals(x_oObj.TagName)) { return false; }
            if (!this.Align.Equals(x_oObj.Align)) { return false; }
            if (!this.BorderColor.Equals(x_oObj.BorderColor)) { return false; }
            if (!this.ContainerControl.Equals(x_oObj.ContainerControl)) { return false; }
            if (!this.RowSpan.Equals(x_oObj.RowSpan)) { return false; }
            if (!this.Height.Equals(x_oObj.Height)) { return false; }
            if (!this.InnerText.Equals(x_oObj.InnerText)) { return false; }
            if (!this.NoWrap.Equals(x_oObj.NoWrap)) { return false; }
            if (!this.Id.Equals(x_oObj.Id)) { return false; }
            if (!this.ColSpan.Equals(x_oObj.ColSpan)) { return false; }
            if (!this.BgColor.Equals(x_oObj.BgColor)) { return false; }
            if (!this.Style.Equals(x_oObj.Style)) { return false; }
            if (!this.Width.Equals(x_oObj.Width)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Visible = true;
            this.Name = global::System.String.Empty;
            this.Disabled = false;
            this.CssClass = global::System.String.Empty;
            this.VAlign = global::System.String.Empty;
            this.Events = new HtmlEvents();
            this.TagName = global::System.String.Empty;
            this.Align = global::System.String.Empty;
            this.BorderColor = global::System.String.Empty;
            this.ContainerControl = new HtmlControlList();
            this.RowSpan = global::System.String.Empty;
            this.Height = global::System.String.Empty;
            this.InnerText = global::System.String.Empty;
            this.NoWrap = global::System.String.Empty;
            this.Id = global::System.String.Empty;
            this.ColSpan = global::System.String.Empty;
            this.BgColor = global::System.String.Empty;
            this.Style = new Hashtable();
            this.Width = global::System.String.Empty;
        }
        #endregion Release


        #region Clone
        public NHtmlTableCell DeepClone()
        {
            NHtmlTableCell NHtmlTableCell_Clone = new NHtmlTableCell(this.TagName);
            NHtmlTableCell_Clone.SetVisible(this.Visible);
            NHtmlTableCell_Clone.SetName(this.Name);
            NHtmlTableCell_Clone.SetDisabled(this.Disabled);
            NHtmlTableCell_Clone.SetCssClass(this.CssClass);
            NHtmlTableCell_Clone.SetVAlign(this.VAlign);
            NHtmlTableCell_Clone.SetEvents(this.Events);
            NHtmlTableCell_Clone.SetTagName(this.TagName);
            NHtmlTableCell_Clone.SetAlign(this.Align);
            NHtmlTableCell_Clone.SetBorderColor(this.BorderColor);
            NHtmlTableCell_Clone.SetContainerControl(this.ContainerControl);
            NHtmlTableCell_Clone.SetRowSpan(this.RowSpan);
            NHtmlTableCell_Clone.SetHeight(this.Height);
            NHtmlTableCell_Clone.SetInnerText(this.InnerText);
            NHtmlTableCell_Clone.SetNoWrap(this.NoWrap);
            NHtmlTableCell_Clone.SetId(this.Id);
            NHtmlTableCell_Clone.SetColSpan(this.ColSpan);
            NHtmlTableCell_Clone.SetBgColor(this.BgColor);
            NHtmlTableCell_Clone.SetStyle(this.Style);
            NHtmlTableCell_Clone.SetWidth(this.Width);
            return NHtmlTableCell_Clone;
        }
        #endregion Clone

        void IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }

        string NHtmlContainerControl.ToInnerHtml()
        {
            return this.ToInnerHtml();
        }
        public string ToInnerHtml()
        {
            return this.InnerHtml;
        }
    }
}
