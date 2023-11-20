﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-07>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by PHILIP FU in 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================
namespace NEURON.WEB.UI
{
    //[assembly: TagPrefix("WC", "WC")]
    [DefaultProperty("RepeaterEx User Control")]
    [ToolboxData("<{0}:RepeaterEx runat=server></{0}:RepeaterEx>")]
    public class RepeaterEx : Repeater
    {
        private Color FRepeaterLineColor;
        bool FEmptyShowHeader = true;
        public bool EmptyShowHeader
        {
            get
            {
                return FEmptyShowHeader;
            }
            set
            {
                FEmptyShowHeader = value;
            }
        }


        public void ExportExcel(string ExportExcelFileName)
        {
            if(ExportExcelFileName.Trim()==string.Empty)
                Export(Encoding.UTF8, "ExportExcel.xls", "application/ms-excel");
            else
                Export(Encoding.UTF8, ExportExcelFileName.Trim(), "application/ms-excel");
        }


        public void ExportWord(string ExportWordFileName)
        {
            if(ExportWordFileName.Trim() == string.Empty)
                Export(Encoding.UTF8, "ExportWord.doc", "application/ms-word");
            else
                Export(Encoding.UTF8, ExportWordFileName.Trim(), "application/ms-word");
        }


        protected void Export(Encoding eEncoding, String FileName, string ContentType)
        {
            HttpResponse oResponse;
            System.IO.StringWriter oStringWriter;
            System.Web.UI.HtmlTextWriter oHtmlWriter;
            String sText;
            String sFilename;
            if (this.Page is ExportPage)
            {
                ((ExportPage)this.Page).IsVerifyRender = false;
            }
            sFilename = HttpUtility.UrlEncode(FileName, eEncoding);

            oResponse = HttpContext.Current.Response;
            oResponse.Clear();
            sText = "<meta http-equiv='Content-Type'; content='text/html';charset='{0}'>";
            sText = String.Format(sText, eEncoding.WebName);
            oResponse.Write(sText);
            oResponse.AddHeader("content-disposition", "attachment;filename=" + FileName);
            oResponse.ContentEncoding = eEncoding;
            oResponse.Charset = eEncoding.WebName;
            oResponse.ContentType = ContentType;

            //If you want the option to open the Excel file without saving than
            //comment out the line below
            //oResponse.Cache.SetCacheability(HttpCacheability.NoCache)

            oStringWriter = new System.IO.StringWriter();
            oHtmlWriter = new System.Web.UI.HtmlTextWriter(oStringWriter);
            


            this.RenderControl(oHtmlWriter);


            oResponse.Write(oStringWriter.ToString());
            oResponse.End();
        }


        protected override void CreateChildControls()
        {
            base.CreateChildControls();
        }


        [Description("Repeater Color Line"), TypeConverter(typeof(WebColorConverter)), Category("Appearance"), DefaultValue(typeof(Color), "")]
        public Color RepeaterLineColor
        {
            get { return FRepeaterLineColor; }
            set { FRepeaterLineColor = value; }
        }


        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {

            base.Render(writer);
        }



        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }


       




    }
}