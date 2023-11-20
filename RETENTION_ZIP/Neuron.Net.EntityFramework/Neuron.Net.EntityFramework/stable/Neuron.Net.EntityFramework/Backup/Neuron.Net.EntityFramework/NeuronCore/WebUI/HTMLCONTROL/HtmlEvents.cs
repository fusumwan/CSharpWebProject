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

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2008-12-04>
///-- Description:	<Description,Class :HtmlEvents, Data Access Object Control>
///-- =============================================
namespace NEURON.WEB.UI.HTMLCONTROL
{

    public class HtmlEvents : IDisposable
    {

        protected string n_sOnDataBinding = global::System.String.Empty;
        #region OnDataBinding
        public string OnDataBinding
        {
            get
            {
                return this.n_sOnDataBinding;
            }
            set
            {
                this.n_sOnDataBinding = value;
            }
        }
        #endregion OnDataBinding


        protected string n_sOnDblClick = global::System.String.Empty;
        #region OnDblClick
        public string OnDblClick
        {
            get
            {
                return this.n_sOnDblClick;
            }
            set
            {
                this.n_sOnDblClick = value;
            }
        }
        #endregion OnDblClick


        protected string n_sOnKeyup = global::System.String.Empty;
        #region OnKeyup
        public string OnKeyup
        {
            get
            {
                return this.n_sOnKeyup;
            }
            set
            {
                this.n_sOnKeyup = value;
            }
        }
        #endregion OnKeyup


        protected string n_sOnClick = global::System.String.Empty;
        #region OnClick
        public string OnClick
        {
            get
            {
                return this.n_sOnClick;
            }
            set
            {
                this.n_sOnClick = value;
            }
        }
        #endregion OnClick


        protected string n_sOnload = global::System.String.Empty;
        #region Onload
        public string Onload
        {
            get
            {
                return this.n_sOnload;
            }
            set
            {
                this.n_sOnload = value;
            }
        }
        #endregion Onload


        protected string n_sOnServerChange = global::System.String.Empty;
        #region OnServerChange
        public string OnServerChange
        {
            get
            {
                return this.n_sOnServerChange;
            }
            set
            {
                this.n_sOnServerChange = value;
            }
        }
        #endregion OnServerChange


        protected string n_sOnMouseOver = global::System.String.Empty;
        #region OnMouseOver
        public string OnMouseOver
        {
            get
            {
                return this.n_sOnMouseOver;
            }
            set
            {
                this.n_sOnMouseOver = value;
            }
        }
        #endregion OnMouseOver


        protected string n_sOnDisposed = global::System.String.Empty;
        #region OnDisposed
        public string OnDisposed
        {
            get
            {
                return this.n_sOnDisposed;
            }
            set
            {
                this.n_sOnDisposed = value;
            }
        }
        #endregion OnDisposed


        protected string n_sOnMouseOut = global::System.String.Empty;
        #region OnMouseOut
        public string OnMouseOut
        {
            get
            {
                return this.n_sOnMouseOut;
            }
            set
            {
                this.n_sOnMouseOut = value;
            }
        }
        #endregion OnMouseOut


        protected string n_sOnBlur = global::System.String.Empty;
        #region OnBlur
        public string OnBlur
        {
            get
            {
                return this.n_sOnBlur;
            }
            set
            {
                this.n_sOnBlur = value;
            }
        }
        #endregion OnBlur


        protected string n_sOnKeypress = global::System.String.Empty;
        #region OnKeypress
        public string OnKeypress
        {
            get
            {
                return this.n_sOnKeypress;
            }
            set
            {
                this.n_sOnKeypress = value;
            }
        }
        #endregion OnKeypress


        protected string n_sOnFocus = global::System.String.Empty;
        #region OnFocus
        public string OnFocus
        {
            get
            {
                return this.n_sOnFocus;
            }
            set
            {
                this.n_sOnFocus = value;
            }
        }
        #endregion OnFocus


        protected string n_sOninit = global::System.String.Empty;
        #region Oninit
        public string Oninit
        {
            get
            {
                return this.n_sOninit;
            }
            set
            {
                this.n_sOninit = value;
            }
        }
        #endregion Oninit


        protected string n_sOnUnload = global::System.String.Empty;
        #region OnUnload
        public string OnUnload
        {
            get
            {
                return this.n_sOnUnload;
            }
            set
            {
                this.n_sOnUnload = value;
            }
        }
        #endregion OnUnload


        protected string n_sOnMouseDown = global::System.String.Empty;
        #region OnMouseDown
        public string OnMouseDown
        {
            get
            {
                return this.n_sOnMouseDown;
            }
            set
            {
                this.n_sOnMouseDown = value;
            }
        }
        #endregion OnMouseDown


        protected string n_sOnMouseMove = global::System.String.Empty;
        #region OnMouseMove
        public string OnMouseMove
        {
            get
            {
                return this.n_sOnMouseMove;
            }
            set
            {
                this.n_sOnMouseMove = value;
            }
        }
        #endregion OnMouseMove


        protected string n_sOnPrerender = global::System.String.Empty;
        #region OnPrerender
        public string OnPrerender
        {
            get
            {
                return this.n_sOnPrerender;
            }
            set
            {
                this.n_sOnPrerender = value;
            }
        }
        #endregion OnPrerender


        protected string n_sOnChange = global::System.String.Empty;
        #region OnChange
        public string OnChange
        {
            get
            {
                return this.n_sOnChange;
            }
            set
            {
                this.n_sOnChange = value;
            }
        }
        #endregion OnChange


        protected string n_sOnKeydown = global::System.String.Empty;
        #region OnKeydown
        public string OnKeydown
        {
            get
            {
                return this.n_sOnKeydown;
            }
            set
            {
                this.n_sOnKeydown = value;
            }
        }
        #endregion OnKeydown


        protected string n_sOnMouseUp = global::System.String.Empty;
        #region OnMouseUp
        public string OnMouseUp
        {
            get
            {
                return this.n_sOnMouseUp;
            }
            set
            {
                this.n_sOnMouseUp = value;
            }
        }
        #endregion OnMouseUp

        #region Para
        public class Para
        {
            public const string OnDataBinding = "OnDataBinding";
            public const string OnDblClick = "OnDblClick";
            public const string OnKeyup = "OnKeyup";
            public const string OnClick = "OnClick";
            public const string Onload = "Onload";
            public const string OnServerChange = "OnServerChange";
            public const string OnMouseOver = "OnMouseOver";
            public const string OnDisposed = "OnDisposed";
            public const string OnMouseOut = "OnMouseOut";
            public const string OnBlur = "OnBlur";
            public const string OnKeypress = "OnKeypress";
            public const string OnFocus = "OnFocus";
            public const string Oninit = "Oninit";
            public const string OnUnload = "OnUnload";
            public const string OnMouseDown = "OnMouseDown";
            public const string OnMouseMove = "OnMouseMove";
            public const string OnPrerender = "OnPrerender";
            public const string OnChange = "OnChange";
            public const string OnKeydown = "OnKeydown";
            public const string OnMouseUp = "OnMouseUp";
        }
        #endregion Para

        #region Constructor & Destructor
        public HtmlEvents() { }

        public HtmlEvents(string x_sOnDataBinding, string x_sOnDblClick, string x_sOnKeyup, string x_sOnClick, string x_sOnload, string x_sOnServerChange, string x_sOnMouseOver, string x_sOnDisposed, string x_sOnMouseOut, string x_sOnBlur, string x_sOnKeypress, string x_sOnFocus, string x_sOninit, string x_sOnUnload, string x_sOnMouseDown, string x_sOnMouseMove, string x_sOnPrerender, string x_sOnChange, string x_sOnKeydown, string x_sOnMouseUp)
        {
            OnDataBinding = x_sOnDataBinding;
            OnDblClick = x_sOnDblClick;
            OnKeyup = x_sOnKeyup;
            OnClick = x_sOnClick;
            Onload = x_sOnload;
            OnServerChange = x_sOnServerChange;
            OnMouseOver = x_sOnMouseOver;
            OnDisposed = x_sOnDisposed;
            OnMouseOut = x_sOnMouseOut;
            OnBlur = x_sOnBlur;
            OnKeypress = x_sOnKeypress;
            OnFocus = x_sOnFocus;
            Oninit = x_sOninit;
            OnUnload = x_sOnUnload;
            OnMouseDown = x_sOnMouseDown;
            OnMouseMove = x_sOnMouseMove;
            OnPrerender = x_sOnPrerender;
            OnChange = x_sOnChange;
            OnKeydown = x_sOnKeydown;
            OnMouseUp = x_sOnMouseUp;
        }

        ~HtmlEvents() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetOnDataBinding() { return this.OnDataBinding; }
        public string GetOnDblClick() { return this.OnDblClick; }
        public string GetOnKeyup() { return this.OnKeyup; }
        public string GetOnClick() { return this.OnClick; }
        public string GetOnload() { return this.Onload; }
        public string GetOnServerChange() { return this.OnServerChange; }
        public string GetOnMouseOver() { return this.OnMouseOver; }
        public string GetOnDisposed() { return this.OnDisposed; }
        public string GetOnMouseOut() { return this.OnMouseOut; }
        public string GetOnBlur() { return this.OnBlur; }
        public string GetOnKeypress() { return this.OnKeypress; }
        public string GetOnFocus() { return this.OnFocus; }
        public string GetOninit() { return this.Oninit; }
        public string GetOnUnload() { return this.OnUnload; }
        public string GetOnMouseDown() { return this.OnMouseDown; }
        public string GetOnMouseMove() { return this.OnMouseMove; }
        public string GetOnPrerender() { return this.OnPrerender; }
        public string GetOnChange() { return this.OnChange; }
        public string GetOnKeydown() { return this.OnKeydown; }
        public string GetOnMouseUp() { return this.OnMouseUp; }

        public bool SetOnDataBinding(string value)
        {
            this.OnDataBinding = value;
            return true;
        }
        public bool SetOnDblClick(string value)
        {
            this.OnDblClick = value;
            return true;
        }
        public bool SetOnKeyup(string value)
        {
            this.OnKeyup = value;
            return true;
        }
        public bool SetOnClick(string value)
        {
            this.OnClick = value;
            return true;
        }
        public bool SetOnload(string value)
        {
            this.Onload = value;
            return true;
        }
        public bool SetOnServerChange(string value)
        {
            this.OnServerChange = value;
            return true;
        }
        public bool SetOnMouseOver(string value)
        {
            this.OnMouseOver = value;
            return true;
        }
        public bool SetOnDisposed(string value)
        {
            this.OnDisposed = value;
            return true;
        }
        public bool SetOnMouseOut(string value)
        {
            this.OnMouseOut = value;
            return true;
        }
        public bool SetOnBlur(string value)
        {
            this.OnBlur = value;
            return true;
        }
        public bool SetOnKeypress(string value)
        {
            this.OnKeypress = value;
            return true;
        }
        public bool SetOnFocus(string value)
        {
            this.OnFocus = value;
            return true;
        }
        public bool SetOninit(string value)
        {
            this.Oninit = value;
            return true;
        }
        public bool SetOnUnload(string value)
        {
            this.OnUnload = value;
            return true;
        }
        public bool SetOnMouseDown(string value)
        {
            this.OnMouseDown = value;
            return true;
        }
        public bool SetOnMouseMove(string value)
        {
            this.OnMouseMove = value;
            return true;
        }
        public bool SetOnPrerender(string value)
        {
            this.OnPrerender = value;
            return true;
        }
        public bool SetOnChange(string value)
        {
            this.OnChange = value;
            return true;
        }
        public bool SetOnKeydown(string value)
        {
            this.OnKeydown = value;
            return true;
        }
        public bool SetOnMouseUp(string value)
        {
            this.OnMouseUp = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(HtmlEvents x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.OnDataBinding.Equals(x_oObj.OnDataBinding)) { return false; }
            if (!this.OnDblClick.Equals(x_oObj.OnDblClick)) { return false; }
            if (!this.OnKeyup.Equals(x_oObj.OnKeyup)) { return false; }
            if (!this.OnClick.Equals(x_oObj.OnClick)) { return false; }
            if (!this.Onload.Equals(x_oObj.Onload)) { return false; }
            if (!this.OnServerChange.Equals(x_oObj.OnServerChange)) { return false; }
            if (!this.OnMouseOver.Equals(x_oObj.OnMouseOver)) { return false; }
            if (!this.OnDisposed.Equals(x_oObj.OnDisposed)) { return false; }
            if (!this.OnMouseOut.Equals(x_oObj.OnMouseOut)) { return false; }
            if (!this.OnBlur.Equals(x_oObj.OnBlur)) { return false; }
            if (!this.OnKeypress.Equals(x_oObj.OnKeypress)) { return false; }
            if (!this.OnFocus.Equals(x_oObj.OnFocus)) { return false; }
            if (!this.Oninit.Equals(x_oObj.Oninit)) { return false; }
            if (!this.OnUnload.Equals(x_oObj.OnUnload)) { return false; }
            if (!this.OnMouseDown.Equals(x_oObj.OnMouseDown)) { return false; }
            if (!this.OnMouseMove.Equals(x_oObj.OnMouseMove)) { return false; }
            if (!this.OnPrerender.Equals(x_oObj.OnPrerender)) { return false; }
            if (!this.OnChange.Equals(x_oObj.OnChange)) { return false; }
            if (!this.OnKeydown.Equals(x_oObj.OnKeydown)) { return false; }
            if (!this.OnMouseUp.Equals(x_oObj.OnMouseUp)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.OnDataBinding = global::System.String.Empty;
            this.OnDblClick = global::System.String.Empty;
            this.OnKeyup = global::System.String.Empty;
            this.OnClick = global::System.String.Empty;
            this.Onload = global::System.String.Empty;
            this.OnServerChange = global::System.String.Empty;
            this.OnMouseOver = global::System.String.Empty;
            this.OnDisposed = global::System.String.Empty;
            this.OnMouseOut = global::System.String.Empty;
            this.OnBlur = global::System.String.Empty;
            this.OnKeypress = global::System.String.Empty;
            this.OnFocus = global::System.String.Empty;
            this.Oninit = global::System.String.Empty;
            this.OnUnload = global::System.String.Empty;
            this.OnMouseDown = global::System.String.Empty;
            this.OnMouseMove = global::System.String.Empty;
            this.OnPrerender = global::System.String.Empty;
            this.OnChange = global::System.String.Empty;
            this.OnKeydown = global::System.String.Empty;
            this.OnMouseUp = global::System.String.Empty;
        }
        #endregion Release


        #region Clone
        public HtmlEvents DeepClone()
        {
            HtmlEvents HtmlEvents_Clone = new HtmlEvents();
            HtmlEvents_Clone.SetOnDataBinding(this.OnDataBinding);
            HtmlEvents_Clone.SetOnDblClick(this.OnDblClick);
            HtmlEvents_Clone.SetOnKeyup(this.OnKeyup);
            HtmlEvents_Clone.SetOnClick(this.OnClick);
            HtmlEvents_Clone.SetOnload(this.Onload);
            HtmlEvents_Clone.SetOnServerChange(this.OnServerChange);
            HtmlEvents_Clone.SetOnMouseOver(this.OnMouseOver);
            HtmlEvents_Clone.SetOnDisposed(this.OnDisposed);
            HtmlEvents_Clone.SetOnMouseOut(this.OnMouseOut);
            HtmlEvents_Clone.SetOnBlur(this.OnBlur);
            HtmlEvents_Clone.SetOnKeypress(this.OnKeypress);
            HtmlEvents_Clone.SetOnFocus(this.OnFocus);
            HtmlEvents_Clone.SetOninit(this.Oninit);
            HtmlEvents_Clone.SetOnUnload(this.OnUnload);
            HtmlEvents_Clone.SetOnMouseDown(this.OnMouseDown);
            HtmlEvents_Clone.SetOnMouseMove(this.OnMouseMove);
            HtmlEvents_Clone.SetOnPrerender(this.OnPrerender);
            HtmlEvents_Clone.SetOnChange(this.OnChange);
            HtmlEvents_Clone.SetOnKeydown(this.OnKeydown);
            HtmlEvents_Clone.SetOnMouseUp(this.OnMouseUp);
            return HtmlEvents_Clone;
        }
        #endregion Clone

        void IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
