using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2008-06-08>
///-- Description:	<Description,Class :CommandFieldEX, Data Access Object Control>
///-- =============================================

namespace NEURON.WEB.UI
{
    public class CommandFieldEX : CommandField
    {
        private string FDeleteConfirmMessage = string.Empty;
        private string FDataField = string.Empty;


        public string DeleteConfirmMessage
        {
            get { return FDeleteConfirmMessage; }
            set { FDeleteConfirmMessage = value; }
        }

        public string DataField
        {
            get { return FDataField; }
            set { FDataField = value; }
        }

        public override void InitializeCell(DataControlFieldCell cell, DataControlCellType cellType, DataControlRowState rowState, int rowIndex)
        {
            base.InitializeCell(cell, cellType, rowState, rowIndex);
            if (this.ShowDeleteButton && this.Visible && this.DeleteConfirmMessage != string.Empty)
            {
                SetDeleteButton(cell);
            }
        }


        protected override DataControlField CreateField()
        {
            return new CommandFieldEX();
        }


        protected override void CopyProperties(DataControlField NewField)
        {
            CommandFieldEX oNewField;

            oNewField = (CommandFieldEX)NewField;
            oNewField.DeleteConfirmMessage = this.DeleteConfirmMessage;
            oNewField.DataField = this.DataField;
            base.CopyProperties(NewField);
        }


        private void SetDeleteButton(DataControlFieldCell Cell)
        {


            foreach (Control oControl in Cell.Controls)
            {
                if ((oControl) is IButtonControl)
                {
                    if (((IButtonControl)oControl).CommandName == "Delete")
                    {

                        oControl.DataBinding += new EventHandler(this.OnDataBindField);
                        return; 
                    }
                }
            }
        }


        protected virtual void OnDataBindField(object sender, EventArgs e)
        {
            Control oControl;
            object oDataItem;
            System.Data.DataRowView oDataRowView;
            string sScript;
            string sMessage;

            oControl = (Control)sender;

            if (this.DataField != string.Empty)
            {

                oDataItem = DataBinder.GetDataItem(oControl.NamingContainer);
                oDataRowView = (System.Data.DataRowView)oDataItem;
                sMessage = string.Format(this.DeleteConfirmMessage, oDataRowView[this.DataField].ToString());
            }
            else
            {
                sMessage = this.DeleteConfirmMessage;
            }

            sMessage = sMessage.Replace("'", "\\'");

            sScript = "if (confirm('" + sMessage + "')==false) {return false;}";
            ((WebControl)oControl).Attributes["onclick"] = sScript;
        }
    }
}
