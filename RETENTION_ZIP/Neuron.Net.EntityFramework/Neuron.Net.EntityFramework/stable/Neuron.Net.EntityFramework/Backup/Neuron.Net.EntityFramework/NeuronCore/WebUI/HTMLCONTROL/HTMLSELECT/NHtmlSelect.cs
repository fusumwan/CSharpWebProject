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
///-- Create date: <Create Date 2008-12-04>
///-- Description:	<Description,Class :NHtmlSelect, NHtmlSelect Control>
///-- =============================================
namespace NEURON.WEB.UI.HTMLCONTROL.HTMLSELECT
{
    public class NHtmlSelect : IDisposable, NHtmlContainerControl
    {
        public void AddItem(string x_sText, string x_sValue)
        {
            NHtmlSelectOptions _oNHtmlSelectOptions = new NHtmlSelectOptions(x_sText,x_sValue,false);
            this.Items.Add(_oNHtmlSelectOptions);
        }

        public void AssignStyle(string x_sStyle, string x_sValue)
        {
            if (x_sStyle.Equals(string.Empty)) return;
            if (this.Style.ContainsKey(x_sStyle))
                this.Style[x_sStyle] = x_sValue;
            else
                this.Style.Add(x_sStyle, x_sValue);
        }

        protected void SetALLSelected(bool x_bSelected)
        {
            for (int i = 0; i < this.Items.Count; i++)
                ((NHtmlSelectOptions)this.Items[i]).Selected = x_bSelected;
        }

        protected bool SetSelectedValue(string x_sValue)
        {
            bool _bFlag = false;
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (((NHtmlSelectOptions)this.Items[i]).Value.Equals(x_sValue))
                {
                    SetALLSelected(false);
                    ((NHtmlSelectOptions)this.Items[i]).Selected = true;
                    _bFlag = true;
                }
            }
            return _bFlag;
        }

        protected string GetSelectedValue()
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (((NHtmlSelectOptions)this.Items[i]).Selected)
                    return ((NHtmlSelectOptions)this.Items[i]).Value;
            }
            if (this.Items.Count > 0)
                return ((NHtmlSelectOptions)this.Items[0]).Value;

            return string.Empty;
        }

        protected string ToHtml()
        {
            StringBuilder _oHtmlCode = new StringBuilder();
            _oHtmlCode.Append("<SELECT " + this.GetAttSetting() + " "  + this.GetEventSetting() + " >");
            if (this.Items != null)
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    NHtmlSelectOptions _oNHtmlSelectOptions = this.Items[i];
                    string _sSelected = (_oNHtmlSelectOptions.Selected) ? "selected=\"selected\"" : string.Empty;
                    _oHtmlCode.Append("<OPTION value=\"" + _oNHtmlSelectOptions.Value.ToString() + "\"  " + _sSelected + ">" + _oNHtmlSelectOptions.Text.ToString() + "</OPTION>");
                }
            }
            _oHtmlCode.Append("</SELECT>");
            return _oHtmlCode.ToString();
        }

        #region GetAttSettring
        protected string GetAttSetting()
        {
            StringBuilder _oHtmlControlAtt = new StringBuilder();
            if (!string.IsNullOrEmpty(this.Id))
                _oHtmlControlAtt.Append(" id=\"" + this.Id.ToString() + "\" ");

            if (!string.IsNullOrEmpty(this.Lang))
                _oHtmlControlAtt.Append(" lang=\"" + this.Lang.ToString() + "\" ");
            
            if (this.Multiple)
                _oHtmlControlAtt.Append(" multiple=\"multiple\" ");

            if (!string.IsNullOrEmpty(this.Class))
                _oHtmlControlAtt.Append(" class=\"" + this.Class + "\" ");

            if (!string.IsNullOrEmpty(this.Dir))
                _oHtmlControlAtt.Append(" dir=\"" + this.Dir + "\" ");

            if (this.Disabled)
                _oHtmlControlAtt.Append(" disabled=\"disabled\" ");

            if (!string.IsNullOrEmpty(this.Name))
                _oHtmlControlAtt.Append(" name=\"" + this.Name + "\" ");

            if (!string.IsNullOrEmpty(this.Size))
                _oHtmlControlAtt.Append(" size=\"" + this.Size + "\" ");

            if(this.Style!=null)
                _oHtmlControlAtt.Append(" style=\"" + this.GetStyleSetting() + "\" ");

            if (!string.IsNullOrEmpty(this.Title))
                _oHtmlControlAtt.Append(" title=\"" + this.Title + "\" ");

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
        protected string GetStyleSetting(){
            if (this.Style == null) return string.Empty;
            StringBuilder _oStyle = new StringBuilder();
            IDictionaryEnumerator _oItem = this.Style.GetEnumerator();
            while (_oItem.MoveNext())
            {
                if (!string.IsNullOrEmpty(_oStyle.ToString())) _oStyle.Append(";");
                _oStyle.Append(_oItem.Key.ToString() + ":" + _oItem.Value.ToString());
            }
            return _oStyle.ToString();
        }
        #endregion

        #region SelectedValue
        public string SelectedValue
        {
            get
            {
                return GetSelectedValue();
            }
            set
            {
                SetSelectedValue(value);
            }
        }
        #endregion

        protected HtmlEvents n_oHtmlEvents = new HtmlEvents();
        #region HtmlEvents
        public HtmlEvents Events
        {
            get
            {
                return this.n_oHtmlEvents;
            }
            set
            {
                n_oHtmlEvents = value;
            }
        }
        #endregion

        protected string n_sValue = global::System.String.Empty;
        #region Value
        public string Value
        {
            get
            {
                this.n_sValue = GetSelectedValue();
                return this.n_sValue;
            }
            set
            {
                if (value == string.Empty)
                    this.n_sValue = string.Empty;
                else if (SetSelectedValue(value))
                    this.n_sValue = value;
            }
        }
        #endregion Value

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
        #endregion Name

        protected string n_sID = global::System.String.Empty;
        #region Id
        public string Id
        {
            get
            {
                return this.n_sID;
            }
            set
            {
                this.n_sID = value;
            }
        }
        #endregion Id

        protected List<NHtmlSelectOptions> n_oItems = new List<NHtmlSelectOptions>();
        #region Items
        public List<NHtmlSelectOptions> Items
        {
            get
            {
                return this.n_oItems;
            }
            set
            {
                this.n_oItems = value;
            }
        }
        #endregion Items

        protected int n_iSelectedIndex = -1;
        #region SelectedIndex
        public int SelectedIndex
        {
            get
            {
                return this.n_iSelectedIndex;
            }
            set
            {
                if (value < this.Items.Count && value > -1)
                {
                    SetALLSelected(false);
                    ((NHtmlSelectOptions)this.Items[value]).Selected = true;
                    this.n_iSelectedIndex = value;
                }
            }
        }
        #endregion SelectedIndex


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

        protected bool n_bVisible = false;
        #region Visible
        public bool Visible
        {
            get
            {
                return this.n_bVisible;
            }
            set
            {
                this.n_bVisible = value;
            }
        }
        #endregion Visible


        protected string n_sTitle = global::System.String.Empty;
        #region Title
        public string Title
        {
            get
            {
                return this.n_sTitle;
            }
            set
            {
                this.n_sTitle = value;
            }
        }
        #endregion Title


        protected string n_sSize = global::System.String.Empty;
        #region Size
        public string Size
        {
            get
            {
                return this.n_sSize;
            }
            set
            {
                this.n_sSize = value;
            }
        }
        #endregion Size


        protected string n_sClass = global::System.String.Empty;
        #region Class
        public string Class
        {
            get
            {
                return this.n_sClass;
            }
            set
            {
                this.n_sClass = value;
            }
        }
        #endregion Class


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


        protected string n_sLang = global::System.String.Empty;
        #region Lang
        public string Lang
        {
            get
            {
                return this.n_sLang;
            }
            set
            {
                this.n_sLang = value;
            }
        }
        #endregion Lang


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


        protected bool n_bDisabled = false;
        #region Disabled
        public bool Disabled
        {
            get
            {
                return this.n_bDisabled;
            }
            set
            {
                this.n_bDisabled = value;
            }
        }
        #endregion Disabled


        protected bool n_bMultiple = false;
        #region Multiple
        public bool Multiple
        {
            get
            {
                return this.n_bMultiple;
            }
            set
            {
                this.n_bMultiple = value;
            }
        }
        #endregion Multiple

        #region Para
        public class Para
        {
            public const string Value = "Value";
            public const string Name = "Name";
            public const string ID = "ID";
            public const string Items = "Items";
            public const string SelectedIndex = "SelectedIndex";
            public const string InnerHtml = "InnerHtml";
            public const string Visible = "Visible";
            public const string Title = "Title";
            public const string Size = "Size";
            public const string Class = "Class";
            public const string Style = "Style";
            public const string Lang = "Lang";
            public const string Dir = "Dir";
            public const string Disabled = "Disabled";
            public const string Multiple = "Multiple";
            public const string Events = "Events";
        }
        #endregion Para

        #region Constructor & Destructor
        public NHtmlSelect(string x_sId) {
            this.Id = x_sId;
        }
        ~NHtmlSelect() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public HtmlEvents GetEvents() { return this.Events; }
        public string GetValue() { return this.Value; }
        public string GetName() { return this.Name; }
        public string GetId() { return this.Id; }
        public List<NHtmlSelectOptions> GetItems() { return this.Items; }
        public int GetSelectedIndex() { return this.SelectedIndex; }
        public string GetInnerHtml() { return this.InnerHtml; }
        public bool GetVisible() { return this.Visible; }
        public string GetTitle() { return this.Title; }
        public string GetSize() { return this.Size; }
        public string GetClass() { return this.Class; }
        public Hashtable GetStyle() { return this.Style; }
        public string GetLang() { return this.Lang; }
        public string GetDir() { return this.Dir; }
        public bool GetDisabled() { return this.Disabled; }
        public bool GetMultiple() { return this.Multiple; }

        public bool SetEvents(HtmlEvents value) { this.Events = value; return true; }
        public bool SetValue(string value)
        {
            this.Value = value;
            return true;
        }
        public bool SetName(string value)
        {
            this.Name = value;
            return true;
        }
        public bool SetId(string value)
        {
            this.Id = value;
            return true;
        }
        public bool SetItems(List<NHtmlSelectOptions> value)
        {
            this.Items = value;
            return true;
        }
        public bool SetSelectedIndex(int value)
        {
            this.SelectedIndex = value;
            return true;
        }
        public bool SetInnerHtml(string value)
        {
            this.InnerHtml = value;
            return true;
        }
        public bool SetVisible(bool value)
        {
            this.Visible = value;
            return true;
        }
        public bool SetTitle(string value)
        {
            this.Title = value;
            return true;
        }
        public bool SetSize(string value)
        {
            this.Size = value;
            return true;
        }
        public bool SetClass(string value)
        {
            this.Class = value;
            return true;
        }
        public bool SetStyle(Hashtable value)
        {
            this.Style = value;
            return true;
        }
        public bool SetLang(string value)
        {
            this.Lang = value;
            return true;
        }
        public bool SetDir(string value)
        {
            this.Dir = value;
            return true;
        }
        public bool SetDisabled(bool value)
        {
            this.Disabled = value;
            return true;
        }
        public bool SetMultiple(bool value)
        {
            this.Multiple = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(NHtmlSelect x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Value.Equals(x_oObj.Value)) { return false; }
            if (!this.Name.Equals(x_oObj.Name)) { return false; }
            if (!this.Id.Equals(x_oObj.Id)) { return false; }
            if (!this.Items.Equals(x_oObj.Items)) { return false; }
            if (!this.SelectedIndex.Equals(x_oObj.SelectedIndex)) { return false; }
            if (!this.InnerHtml.Equals(x_oObj.InnerHtml)) { return false; }
            if (!this.Visible.Equals(x_oObj.Visible)) { return false; }
            if (!this.Title.Equals(x_oObj.Title)) { return false; }
            if (!this.Size.Equals(x_oObj.Size)) { return false; }
            if (!this.Class.Equals(x_oObj.Class)) { return false; }
            if (!this.Style.Equals(x_oObj.Style)) { return false; }
            if (!this.Lang.Equals(x_oObj.Lang)) { return false; }
            if (!this.Dir.Equals(x_oObj.Dir)) { return false; }
            if (!this.Disabled.Equals(x_oObj.Disabled)) { return false; }
            if (!this.Multiple.Equals(x_oObj.Multiple)) { return false; }
            if (!this.Events.Equals(x_oObj.Events)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Value = global::System.String.Empty;
            this.Name = global::System.String.Empty;
            this.Id = global::System.String.Empty;
            this.Items = new List<NHtmlSelectOptions>();
            this.SelectedIndex = -1;
            this.InnerHtml = global::System.String.Empty;
            this.Visible = false;
            this.Title = global::System.String.Empty;
            this.Size = global::System.String.Empty;
            this.Class = global::System.String.Empty;
            this.Style = new Hashtable();
            this.Lang = global::System.String.Empty;
            this.Dir = global::System.String.Empty;
            this.Disabled = false;
            this.Multiple = false;
            this.Events = new HtmlEvents();
        }
        #endregion Release


        #region Clone
        public NHtmlSelect DeepClone()
        {
            NHtmlSelect NHtmlSelect_Clone = new NHtmlSelect(this.Id);
            NHtmlSelect_Clone.SetValue(this.Value);
            NHtmlSelect_Clone.SetName(this.Name);
            NHtmlSelect_Clone.SetId(this.Id);
            NHtmlSelect_Clone.SetItems(this.Items);
            NHtmlSelect_Clone.SetSelectedIndex(this.SelectedIndex);
            NHtmlSelect_Clone.SetInnerHtml(this.InnerHtml);
            NHtmlSelect_Clone.SetVisible(this.Visible);
            NHtmlSelect_Clone.SetTitle(this.Title);
            NHtmlSelect_Clone.SetSize(this.Size);
            NHtmlSelect_Clone.SetClass(this.Class);
            NHtmlSelect_Clone.SetStyle(this.Style);
            NHtmlSelect_Clone.SetLang(this.Lang);
            NHtmlSelect_Clone.SetDir(this.Dir);
            NHtmlSelect_Clone.SetDisabled(this.Disabled);
            NHtmlSelect_Clone.SetMultiple(this.Multiple);
            NHtmlSelect_Clone.SetEvents(this.Events);
            return NHtmlSelect_Clone;
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
