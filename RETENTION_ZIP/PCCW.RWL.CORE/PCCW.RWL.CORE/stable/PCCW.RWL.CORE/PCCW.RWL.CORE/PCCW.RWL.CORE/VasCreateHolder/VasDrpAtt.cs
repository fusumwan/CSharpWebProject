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
///-- Create date: <Create Date 2009-12-03>
///-- Description:	<Description,Class :VasDrpAtt, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    [Serializable]
    public class VasDrpAtt : IDisposable
    {

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
                this.n_iSelectedIndex = value;
            }
        }
        #endregion SelectedIndex


        protected bool n_bEnabled = true;
        #region Enabled
        public bool Enabled
        {
            get
            {
                return this.n_bEnabled;
            }
            set
            {
                this.n_bEnabled = value;
            }
        }
        #endregion Enabled


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


        protected string n_sSelectedValue = global::System.String.Empty;
        #region SelectedValue
        public string SelectedValue
        {
            get
            {
                return this.n_sSelectedValue;
            }
            set
            {
                this.n_sSelectedValue = value;
            }
        }
        #endregion SelectedValue

        #region Para
        public class Para
        {
            public const string SelectedIndex = "SelectedIndex";
            public const string Enabled = "Enabled";
            public const string Style = "Style";
            public const string SelectedValue = "SelectedValue";
        }
        #endregion Para

        #region Constructor & Destructor
        public VasDrpAtt() { }

        public VasDrpAtt(int x_iSelectedIndex, bool x_bEnabled, Hashtable x_oStyle, string x_sSelectedValue)
        {
            SelectedIndex = x_iSelectedIndex;
            Enabled = x_bEnabled;
            Style = x_oStyle;
            SelectedValue = x_sSelectedValue;
        }

        ~VasDrpAtt() { }

        #endregion Constructor & Destructor

        #region SaveVasDrp
        public VasDrpAtt SaveVasDrp(int? x_iSelectedIndex, bool? x_bEnabled, string x_sSelectedValue)
        {
            if(x_iSelectedIndex!=null)
                this.SelectedIndex = (int)x_iSelectedIndex;
            if(x_bEnabled!=null)
                this.Enabled = (bool)x_bEnabled;
            if(!string.IsNullOrEmpty(x_sSelectedValue))
                this.SelectedValue = x_sSelectedValue;
            return this;
        }
        #endregion

        public VasDrpAtt ModifyStyle(string x_sStyleName, string x_sValue)
        {
            if (this.Style.ContainsKey(x_sStyleName.Trim().ToUpper()))
                this.Style[x_sStyleName] = x_sValue;
            else
                this.Style.Add(x_sStyleName.Trim().ToUpper(), x_sValue.Trim());

            return this;
        }

        public VasDrpAtt RemoveStyle(string x_sStyleName)
        {
            this.Style.Remove(x_sStyleName.Trim().ToUpper());
            return this;
        }

        #region Get & Set
        public int GetSelectedIndex() { return this.SelectedIndex; }
        public bool GetEnabled() { return this.Enabled; }
        public Hashtable GetStyle() { return this.Style; }
        public string GetSelectedValue() { return this.SelectedValue; }

        public bool SetSelectedIndex(int value)
        {
            this.SelectedIndex = value;
            return true;
        }
        public bool SetEnabled(bool value)
        {
            this.Enabled = value;
            return true;
        }
        public bool SetStyle(Hashtable value)
        {
            this.Style = value;
            return true;
        }
        public bool SetSelectedValue(string value)
        {
            this.SelectedValue = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(VasDrpAtt x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.SelectedIndex.Equals(x_oObj.SelectedIndex)) { return false; }
            if (!this.Enabled.Equals(x_oObj.Enabled)) { return false; }
            if (!this.Style.Equals(x_oObj.Style)) { return false; }
            if (!this.SelectedValue.Equals(x_oObj.SelectedValue)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.SelectedIndex = -1;
            this.Enabled = true;
            this.Style = new Hashtable();
            this.SelectedValue = global::System.String.Empty;
        }
        #endregion Release


        #region Clone
        public VasDrpAtt DeepClone()
        {
            VasDrpAtt VasDrpAtt_Clone = new VasDrpAtt();
            VasDrpAtt_Clone.SetSelectedIndex(this.SelectedIndex);
            VasDrpAtt_Clone.SetEnabled(this.Enabled);
            VasDrpAtt_Clone.SetStyle(this.Style);
            VasDrpAtt_Clone.SetSelectedValue(this.SelectedValue);
            return VasDrpAtt_Clone;
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
