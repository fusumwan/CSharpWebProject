using System;
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
    //[assembly: TagPrefix("WC.PROJECT", "WC")]
    [DefaultProperty("GridViewEx UserControl")]
    [ToolboxData("<{0}:GridViewEx EmptyShowHeader=true runat=server></{0}:GridViewEx>")]
    public class GridViewEx : GridView
    {
        private string FFormViewID = string.Empty;
        private FormView FFormView = null;
        private Color FGridLineColor;

        protected bool FEmptyShowHeader = true;
        protected bool EmptyShowHeader
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

        public void SetEmptyShowHeader(bool bShow)
        {
            EmptyShowHeader = bShow;
        }

        public bool GetEmtpyShowHeader() { return EmptyShowHeader; }

        public void ExportExcel(string ExportExcelFileName)
        {
            if (ExportExcelFileName.Trim() == string.Empty)
                Export(Encoding.UTF8, "ExportExcel.xls", "application/ms-excel");
            else
                Export(Encoding.UTF8, ExportExcelFileName.Trim(), "application/ms-excel");
        }

        public void ExportWord(string ExportWordFileName)
        {
            if (ExportWordFileName.Trim() == string.Empty)
                Export(Encoding.UTF8, "ExportWord.doc", "application/ms-word");
            else
                Export(Encoding.UTF8, ExportWordFileName.Trim(), "application/ms-word");
        }
        ///<summary>   
        ///GridView UserControl Export。   
        ///</summary>   
        ///<param name="Encoding">Encoding。</param>   
        ///<param name="FileName">FileName。</param>   
        ///<param name="ContentType">ContentType。</param>    
        ///
        protected void Export(Encoding eEncoding, String FileName, string ContentType)
        {
            HttpResponse oResponse;
            System.IO.StringWriter oStringWriter;
            System.Web.UI.HtmlTextWriter oHtmlWriter;
            bool bAllowPaging;
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
            bAllowPaging = this.AllowPaging;
            if (bAllowPaging)
            {
                this.AllowPaging = false;
                if (this.RequiresDataBinding)
                {
                    this.DataBind();
                }
            }

            this.RenderControl(oHtmlWriter);
            if (bAllowPaging)
                AllowPaging = bAllowPaging;

            oResponse.Write(oStringWriter.ToString());
            oResponse.End();
        }

        private Table CreateEmptyTable()
        {
            Table oTable = new Table();

            GridViewRow oGridViewRow;
            TableCell oCell = new TableCell();

            int iCount = 0;
            GridViewRowEventArgs e;

            oTable = base.CreateChildTable();
            iCount = this.Columns.Count;

            
            oGridViewRow = base.CreateRow(-1, -1, DataControlRowType.Header, DataControlRowState.Normal);
            DataControlField[] oFields = new DataControlField[iCount];

            this.Columns.CopyTo(oFields, 0);
            this.InitializeRow(oGridViewRow, oFields);
            e = new GridViewRowEventArgs(oGridViewRow);
            this.OnRowCreated(e);
            oTable.Rows.Add(oGridViewRow);

            oGridViewRow = new GridViewRow(-1, -1, DataControlRowType.DataRow, DataControlRowState.Normal);
            oCell = new TableCell();
            oCell.ColumnSpan = oFields.Length;
            oCell.Width = Unit.Percentage(100);
            oCell.Text = this.EmptyDataText;
            oCell.HorizontalAlign = System.Web.UI.WebControls.HorizontalAlign.Center;
            oGridViewRow.Cells.Add(oCell);
            oTable.Rows.Add(oGridViewRow);

            return oTable;
        }

        protected override int CreateChildControls(System.Collections.IEnumerable dataSource, bool dataBinding)
        {
            int iRowCount;
            Table oTable;
            iRowCount = base.CreateChildControls(dataSource, dataBinding);
            if (this.EmptyShowHeader && (iRowCount == 0))
            {
                oTable = CreateEmptyTable();
                this.Controls.Clear();
                this.Controls.Add(oTable);
            }
            return iRowCount;
        }


        /// <summary> 
        /// Connect FormView UserControl ID。 
        /// </summary> 
        [Description("Connect FormView UserControl ID。"), Themeable(false), IDReferenceProperty(typeof(FormView)), Category("Data"), DefaultValue("")]
        public string FormViewID
        {
            get { return FFormViewID; }
            set { FFormViewID = value; }
        }
        /// <summary> 
        /// GridView Color Line。 
        /// </summary> 
        [Description("GridView GridViewLine"), TypeConverter(typeof(WebColorConverter)), Category("Appearance"), DefaultValue(typeof(Color), "")]
        public Color GridLineColor
        {
            get { return FGridLineColor; }
            set { FGridLineColor = value; }
        }

        /// <summary> 
        /// Output Html。 
        /// </summary> 
        /// <param name="writer">Output Html Content。</param> 
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            if (this.GridLineColor != System.Drawing.Color.Empty)
            {
                this.Attributes["bordercolor"] = System.Drawing.ColorTranslator.ToHtml(this.GridLineColor);
            }
            base.Render(writer);
        }

        /// <summary> 
        /// Connect FormView ID。 
        /// </summary> 
        protected internal FormView FormView
        {
            get
            {
                if (string.IsNullOrEmpty(FFormViewID))
                    return null;
                if (FFormView == null)
                {
                    FFormView = (FormView)this.Parent.FindControl(FFormViewID);
                }
                return FFormView;
            }
        }

        /// <summary> 
        /// 
        /// </summary> 
        /// <param name="RowIndex">GridView </param> 
        public int GetDataRowIndex(int RowIndex)
        {
            int iRowIndex;
            if (this.AllowPaging)
            {
                iRowIndex = this.PageIndex * this.PageSize + RowIndex;
            }
            else
            {
                iRowIndex = RowIndex;
            }
            return iRowIndex;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.FormView != null)
            {
                if (this.FormView is FormViewEx)
                {
                    ((FormViewEx)this.FormView).GridView = this;
                }
            }
        }
        protected override void OnRowCommand(GridViewCommandEventArgs e)
        {
            int iDataRowIndex;

            switch (e.CommandName.ToUpper())
            {
                case "EDIT":
                    if (this.FormView != null && e.CommandArgument.ToString() != string.Empty)
                    {

                        iDataRowIndex = GetDataRowIndex(Convert.ToInt32(e.CommandArgument.ToString()));
                        this.FormView.PageIndex = iDataRowIndex;
                        this.FormView.ChangeMode(FormViewMode.Edit);
                        this.FormView.Visible = true;
                        this.Visible = false;
                    }

                    break;

                case "INSERT":
                    if (this.FormView != null)
                    {
                        this.FormView.ChangeMode(FormViewMode.Insert);
                        this.FormView.Visible = true;
                        this.Visible = false;
                    }

                    break;
            }
            base.OnRowCommand(e);
        }


    }
}
