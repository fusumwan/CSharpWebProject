using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;

using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2008-06-08>
///-- Description:	<Description,Class :ExportPage, Data Access Object Control>
///-- =============================================
namespace NEURON.WEB.UI
{

    public class ExportPage : System.Web.UI.Page,  IDisposable
    {

        protected bool FIsVerifyRender = true;


        public bool IsVerifyRender{
            get
            {
                return FIsVerifyRender;
            }
            set
            {
                FIsVerifyRender = value;
            }
        }


        #region Constructor & Destructor
        public ExportPage() { }

        public ExportPage(bool x_bFIsVerifyRender)
        {
            FIsVerifyRender = x_bFIsVerifyRender;
        }

        ~ExportPage() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public bool GetFIsVerifyRender() { return this.FIsVerifyRender; }

        public bool SetFIsVerifyRender(bool value)
        {
            this.FIsVerifyRender = value;
            return true;
        }
        #endregion


        public override void VerifyRenderingInServerForm(System.Web.UI.Control control)
        {
            if (this.IsVerifyRender)
                base.VerifyRenderingInServerForm(control);
        }

        public override bool EnableEventValidation
        {
            get
            {
                if (this.IsVerifyRender)
                    return base.EnableEventValidation;
                else
                    return false;
            }
            set
            {
                base.EnableEventValidation = value;
            }
        }

        public static string ControlToHTML(System.Web.UI.Control _Control)
        {
            string sHTML;
            System.IO.StringWriter oTextWriter = new System.IO.StringWriter();
            System.Web.UI.HtmlTextWriter oHTMLWriter = new System.Web.UI.HtmlTextWriter(oTextWriter);

            if (_Control.Page != null)
            {
                if (_Control.Page is ExportPage)
                {
                    ((ExportPage)_Control.Page).IsVerifyRender = false;
                }
            }
            _Control.RenderControl(oHTMLWriter);
            sHTML = oTextWriter.ToString();
            return sHTML;
        }


        #region Equals
        public bool Equals(ExportPage x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.FIsVerifyRender.Equals(x_oObj.FIsVerifyRender)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.FIsVerifyRender = false;
        }
        #endregion Release


        #region Clone
        public ExportPage Clone()
        {
            ExportPage ExportPage_Clone = new ExportPage();
            ExportPage_Clone.SetFIsVerifyRender(this.FIsVerifyRender);
            return ExportPage_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {

        }
    }
}
