using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using NEURON.WEB.UI.HTMLCONTROL;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-12-09>
///-- Description:	<Description,Class :NHtmlTable, Data Access Object Control>
///-- =============================================
namespace NEURON.WEB.UI.HTMLCONTROL.HTMLTABLE
{

    public class NHtmlTable : IDisposable, NHtmlContainerControl
    {
        protected string ToHtml()
        {
            StringBuilder _oHtmlCell = new StringBuilder();
            _oHtmlCell.Append("<Table  " +this.GetAttSetting()+" "+ GetEventSetting() + " >");
            if (ContainerControl != null)
            {
                IDictionaryEnumerator _oItem = ContainerControl.GetEnumerator();
                while (_oItem.MoveNext())
                {
                    NHtmlContainerControl _oControl = (NHtmlContainerControl)_oItem.Value;
                    _oHtmlCell.Append(_oControl.ToInnerHtml());
                }
            }
            _oHtmlCell.Append("</Table>");
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

            if (!string.IsNullOrEmpty(this.Align))
                _oHtmlControlAtt.Append(" align=\"" + this.Align.ToString() + "\" ");


            if (!string.IsNullOrEmpty(this.CssClass))
                _oHtmlControlAtt.Append(" class=\"" + this.CssClass + "\" ");

            if (this.Border > 0)
                _oHtmlControlAtt.Append(" border=\"" + this.Border + "\" ");

            if (!string.IsNullOrEmpty(this.Dir))
                _oHtmlControlAtt.Append(" dir=\"" + this.Dir + "\" ");

            if (this.CellPadding > 0)
                _oHtmlControlAtt.Append(" cellpadding=\"" + this.CellPadding + "\" ");

            if (this.CellSpacing > 0)
                _oHtmlControlAtt.Append(" cellspacing=\"" + this.CellSpacing + "\" ");

            if (!string.IsNullOrEmpty(this.Align))
                _oHtmlControlAtt.Append(" align=\"" + this.Align + "\" ");

            if (!string.IsNullOrEmpty(this.Frame))
                _oHtmlControlAtt.Append(" frame=\"" + this.Frame + "\" ");

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

        protected int n_iCellPadding = -1;
        #region CellPadding
        public int CellPadding
        {
            get
            {
                return this.n_iCellPadding;
            }
            set
            {
                this.n_iCellPadding = value;
            }
        }
        #endregion CellPadding

        protected Dictionary<string, NHtmlContainerControl> n_oContainerControl = new Dictionary<string, NHtmlContainerControl>();
        #region ContainerControl
        public Dictionary<string, NHtmlContainerControl> ContainerControl
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


        protected string n_sDir = global::System.String.Empty;
        #region Dir
        public string Dir
        {
            get
            {
                return this.n_sDir;
            }
            set
            {
                this.n_sDir = value;
            }
        }
        #endregion Dir


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


        protected int n_iBorder = -1;
        #region Border
        public int Border
        {
            get
            {
                return this.n_iBorder;
            }
            set
            {
                this.n_iBorder = value;
            }
        }
        #endregion Border


        protected string n_sFrame = global::System.String.Empty;
        #region Frame
        public string Frame
        {
            get
            {
                return this.n_sFrame;
            }
            set
            {
                this.n_sFrame = value;
            }
        }
        #endregion Frame


        protected int n_iCellSpacing = -1;
        #region CellSpacing
        public int CellSpacing
        {
            get
            {
                return this.n_iCellSpacing;
            }
            set
            {
                this.n_iCellSpacing = value;
            }
        }
        #endregion CellSpacing


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
            
            public const string Events = "Events";
            public const string Align = "Align";
            public const string CellPadding = "CellPadding";
            public const string ContainerControl = "ContainerControl";
            public const string Height = "Height";
            public const string InnerHtml = "InnerHtml";
            public const string Dir = "Dir";
            public const string Id = "Id";
            public const string Style = "Style";
            public const string Border = "Border";
            public const string Frame = "Frame";
            public const string CellSpacing = "CellSpacing";
            public const string Width = "Width";
            public const string CssClass = "CssClass";
            public const string Disabled = "Disabled";
            public const string Visible = "Visible";
            public const string Name = "Name";
        }
        #endregion Para

        #region Constructor & Destructor
        public NHtmlTable() { }

        public NHtmlTable(string x_sName, bool x_bVisible, bool x_bDisabled, string x_sCssClass, HtmlEvents x_oEvents, string x_sAlign, int x_iCellPadding, Dictionary<string, NHtmlContainerControl> x_oContainerControl, string x_sHeight, string x_sInnerHtml, string x_sDir, string x_sId, Hashtable x_oStyle, int x_iBorder, string x_sFrame, int x_iCellSpacing, string x_sWidth)
        {
            Visible = x_bVisible;
            Name = x_sName;
            Disabled = x_bDisabled;
            CssClass = x_sCssClass;
            Events = x_oEvents;
            Align = x_sAlign;
            CellPadding = x_iCellPadding;
            ContainerControl = x_oContainerControl;
            Height = x_sHeight;
            InnerHtml = x_sInnerHtml;
            Dir = x_sDir;
            Id = x_sId;
            Style = x_oStyle;
            Border = x_iBorder;
            Frame = x_sFrame;
            CellSpacing = x_iCellSpacing;
            Width = x_sWidth;
        }

        ~NHtmlTable() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public bool GetVisible() { return this.Visible; }
        public string GetName() { return this.Name; }
        public bool GetDisabled() { return this.Disabled; }
        public string GetCssClass() { return this.CssClass; }
        public HtmlEvents GetEvents() { return this.Events; }
        public string GetAlign() { return this.Align; }
        public int GetCellPadding() { return this.CellPadding; }
        public Dictionary<string, NHtmlContainerControl> GetContainerControl() { return this.ContainerControl; }
        public string GetHeight() { return this.Height; }
        public string GetInnerHtml() { return this.InnerHtml; }
        public string GetDir() { return this.Dir; }
        public string GetId() { return this.Id; }
        public Hashtable GetStyle() { return this.Style; }
        public int GetBorder() { return this.Border; }
        public string GetFrame() { return this.Frame; }
        public int GetCellSpacing() { return this.CellSpacing; }
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
        public bool SetEvents(HtmlEvents value)
        {
            this.Events = value;
            return true;
        }
        public bool SetAlign(string value)
        {
            this.Align = value;
            return true;
        }
        public bool SetCellPadding(int value)
        {
            this.CellPadding = value;
            return true;
        }
        public bool SetContainerControl(Dictionary<string, NHtmlContainerControl> value)
        {
            this.ContainerControl = value;
            return true;
        }
        public bool SetHeight(string value)
        {
            this.Height = value;
            return true;
        }
        public bool SetInnerHtml(string value)
        {
            this.InnerHtml = value;
            return true;
        }
        public bool SetDir(string value)
        {
            this.Dir = value;
            return true;
        }
        public bool SetId(string value)
        {
            this.Id = value;
            return true;
        }
        public bool SetStyle(Hashtable value)
        {
            this.Style = value;
            return true;
        }
        public bool SetBorder(int value)
        {
            this.Border = value;
            return true;
        }
        public bool SetFrame(string value)
        {
            this.Frame = value;
            return true;
        }
        public bool SetCellSpacing(int value)
        {
            this.CellSpacing = value;
            return true;
        }
        public bool SetWidth(string value)
        {
            this.Width = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(NHtmlTable x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Visible.Equals(x_oObj.Visible)) { return false; }
            if (!this.Name.Equals(x_oObj.Name)) { return false; }
            if (!this.Disabled.Equals(x_oObj.Disabled)) { return false; }
            if (!this.CssClass.Equals(x_oObj.CssClass)) { return false; }
            if (!this.Events.Equals(x_oObj.Events)) { return false; }
            if (!this.Align.Equals(x_oObj.Align)) { return false; }
            if (!this.CellPadding.Equals(x_oObj.CellPadding)) { return false; }
            if (!this.ContainerControl.Equals(x_oObj.ContainerControl)) { return false; }
            if (!this.Height.Equals(x_oObj.Height)) { return false; }
            if (!this.InnerHtml.Equals(x_oObj.InnerHtml)) { return false; }
            if (!this.Dir.Equals(x_oObj.Dir)) { return false; }
            if (!this.Id.Equals(x_oObj.Id)) { return false; }
            if (!this.Style.Equals(x_oObj.Style)) { return false; }
            if (!this.Border.Equals(x_oObj.Border)) { return false; }
            if (!this.Frame.Equals(x_oObj.Frame)) { return false; }
            if (!this.CellSpacing.Equals(x_oObj.CellSpacing)) { return false; }
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
            this.Events = new HtmlEvents();
            this.Align = global::System.String.Empty;
            this.CellPadding = -1;
            this.ContainerControl = new Dictionary<string, NHtmlContainerControl>();
            this.Height = global::System.String.Empty;
            this.InnerHtml = global::System.String.Empty;
            this.Dir = global::System.String.Empty;
            this.Id = global::System.String.Empty;
            this.Style = new Hashtable();
            this.Border = -1;
            this.Frame = global::System.String.Empty;
            this.CellSpacing = -1;
            this.Width = global::System.String.Empty;
        }
        #endregion Release


        #region Clone
        public NHtmlTable DeepClone()
        {
            NHtmlTable NHtmlTable_Clone = new NHtmlTable();
            NHtmlTable_Clone.SetVisible(this.Visible);
            NHtmlTable_Clone.SetName(this.Name);
            NHtmlTable_Clone.SetDisabled(this.Disabled);
            NHtmlTable_Clone.SetCssClass(this.CssClass);
            NHtmlTable_Clone.SetEvents(this.Events);
            NHtmlTable_Clone.SetAlign(this.Align);
            NHtmlTable_Clone.SetCellPadding(this.CellPadding);
            NHtmlTable_Clone.SetContainerControl(this.ContainerControl);
            NHtmlTable_Clone.SetHeight(this.Height);
            NHtmlTable_Clone.SetInnerHtml(this.InnerHtml);
            NHtmlTable_Clone.SetDir(this.Dir);
            NHtmlTable_Clone.SetId(this.Id);
            NHtmlTable_Clone.SetStyle(this.Style);
            NHtmlTable_Clone.SetBorder(this.Border);
            NHtmlTable_Clone.SetFrame(this.Frame);
            NHtmlTable_Clone.SetCellSpacing(this.CellSpacing);
            NHtmlTable_Clone.SetWidth(this.Width);
            return NHtmlTable_Clone;
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
