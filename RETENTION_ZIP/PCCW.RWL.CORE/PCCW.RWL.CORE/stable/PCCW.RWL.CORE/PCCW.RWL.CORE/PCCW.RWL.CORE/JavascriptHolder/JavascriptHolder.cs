using System;
using System.IO;
using System.Web.UI;
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
///-- Create date: <Create Date 2009-12-11>
///-- Description:	<Description,Class :JavascriptHolder, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class JavascriptHolder : IDisposable
    {
        #region AppendLine
        public void AppendLine(string x_sScript)
        {
            if (this.Holder != null)
            {
                this.Append(x_sScript);
                this.Append("\n");
                this.NumLine += 1;
            }
        }
        #endregion

        #region Append
        public void Append(string x_sScript)
        {
            if (this.Holder != null)
                this.Holder.Append(x_sScript);
        }
        #endregion

        #region ToScript
        public string ToScript()
        {
            if (this.Holder != null)
                return this.Holder.ToString();
            return string.Empty;
        }
        #endregion

        protected int n_iNumLine = -1;
        #region NumLine
        public int NumLine
        {
            get
            {
                return this.n_iNumLine;
            }
            set
            {
                this.n_iNumLine = value;
            }
        }
        #endregion NumLine


        protected StringBuilder n_oHolder = new StringBuilder();
        #region Holder
        public StringBuilder Holder
        {
            get
            {
                return this.n_oHolder;
            }
            set
            {
                this.n_oHolder = value;
            }
        }
        #endregion Holder


        protected Page n_oThisPage = null;
        #region ThisPage
        public Page ThisPage
        {
            get
            {
                return this.n_oThisPage;
            }
            set
            {
                this.n_oThisPage = value;
            }
        }
        #endregion ThisPage

        #region Para
        public class Para
        {
            public const string NumLine = "NumLine";
            public const string Holder = "Holder";
            public const string ThisPage = "ThisPage";
        }
        #endregion Para

        #region Constructor & Destructor
        public JavascriptHolder(Page x_oThisPage)
        {
            ThisPage = x_oThisPage;
        }

        ~JavascriptHolder() { }

        #endregion Constructor & Destructor

        

        #region Get & Set
        public int GetNumLine() { return this.NumLine; }
        public StringBuilder GetHolder() { return this.Holder; }
        public Page GetThisPage() { return this.ThisPage; }

        public bool SetNumLine(int value)
        {
            this.NumLine = value;
            return true;
        }
        public bool SetHolder(StringBuilder value)
        {
            this.Holder = value;
            return true;
        }
        public bool SetThisPage(Page value)
        {
            this.ThisPage = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(JavascriptHolder x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.NumLine.Equals(x_oObj.NumLine)) { return false; }
            if (!this.Holder.Equals(x_oObj.Holder)) { return false; }
            if (!this.ThisPage.Equals(x_oObj.ThisPage)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.NumLine = -1;
            this.Holder = null;
            this.ThisPage = null;
        }
        #endregion Release


        #region Clone
        public JavascriptHolder DeepClone()
        {
            JavascriptHolder JavascriptHolder_Clone = new JavascriptHolder(this.ThisPage);
            JavascriptHolder_Clone.SetNumLine(this.NumLine);
            JavascriptHolder_Clone.SetHolder(this.Holder);
            JavascriptHolder_Clone.SetThisPage(this.ThisPage);
            return JavascriptHolder_Clone;
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
