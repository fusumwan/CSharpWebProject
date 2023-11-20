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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2008-12-04>
///-- Description:	<Description,Class :NHtmlSelectOptions, NHtml Select Control>
///-- =============================================
namespace NEURON.WEB.UI.HTMLCONTROL.HTMLSELECT
{

    public class NHtmlSelectOptions : IDisposable
    {

        protected string n_sValue = global::System.String.Empty;
        #region Value
        public string Value
        {
            get
            {
                return this.n_sValue;
            }
            set
            {
                this.n_sValue = value;
            }
        }
        #endregion Value


        protected string n_sText = global::System.String.Empty;
        #region Text
        public string Text
        {
            get
            {
                return this.n_sText;
            }
            set
            {
                this.n_sText = value;
            }
        }
        #endregion Text


        protected bool n_bSelected = false;
        #region Selected
        public bool Selected
        {
            get
            {
                return this.n_bSelected;
            }
            set
            {
                this.n_bSelected = value;
            }
        }
        #endregion Selected

        #region Para
        public class Para
        {
            public const string Value = "Value";
            public const string Text = "Text";
            public const string Selected = "Selected";
        }
        #endregion Para

        #region Constructor & Destructor
        public NHtmlSelectOptions(string x_sText, string x_sValue, bool x_bSelected)
        {
            Value = x_sValue;
            Text = x_sText;
            Selected = x_bSelected;
        }

        ~NHtmlSelectOptions() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetValue() { return this.Value; }
        public string GetText() { return this.Text; }
        public bool GetSelected() { return this.Selected; }

        public bool SetValue(string value)
        {
            this.Value = value;
            return true;
        }
        public bool SetText(string value)
        {
            this.Text = value;
            return true;
        }
        public bool SetSelected(bool value)
        {
            this.Selected = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(NHtmlSelectOptions x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Value.Equals(x_oObj.Value)) { return false; }
            if (!this.Text.Equals(x_oObj.Text)) { return false; }
            if (!this.Selected.Equals(x_oObj.Selected)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Value = global::System.String.Empty;
            this.Text = global::System.String.Empty;
            this.Selected = false;
        }
        #endregion Release


        #region Clone
        public NHtmlSelectOptions DeepClone()
        {
            NHtmlSelectOptions NHtmlSelectOptions_Clone = new NHtmlSelectOptions(this.Value,this.Text,this.Selected);
            return NHtmlSelectOptions_Clone;
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
