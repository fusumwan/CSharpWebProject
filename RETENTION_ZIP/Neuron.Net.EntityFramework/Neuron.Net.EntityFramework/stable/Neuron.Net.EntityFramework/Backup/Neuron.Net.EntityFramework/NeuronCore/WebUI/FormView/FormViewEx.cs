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

    [Description("FormViewEx UserControl"), ToolboxData("<{0}:FormViewEx runat=server></{0}:FormViewEx>")]
    public class FormViewEx : FormView
    {
        private GridView FGridView = null;


        protected internal GridView GridView
        {
            get { return FGridView; }
            set { FGridView = value; }
        }

        private IButtonControl FindButtonControl(System.Web.UI.Control Parent, string CommandName)
        {
            //System.Web.UI.Control oControl = null; 
            IButtonControl oButtonControl = null;

            foreach (System.Web.UI.Control oControl in Parent.Controls)
            {
                if ((oControl is IButtonControl))
                {
                    oButtonControl = (IButtonControl)oControl;
                    if (CommandName.Equals(oButtonControl.CommandName))
                    {
                        return oButtonControl;
                    }
                }
                else
                {
                    if (oControl.Controls.Count > 0)
                    {
                        oButtonControl = FindButtonControl(oControl, CommandName);
                        if (oButtonControl != null)
                        {
                            return oButtonControl;
                        }
                    }
                }
            }
            return null;
        }


        private IButtonControl FindButtonControl(string CommandName)
        {
            return FindButtonControl(this, CommandName);
        }

 
        protected override void OnLoad(EventArgs e)
        {
            if (this.DefaultMode == FormViewMode.Edit)
            {
                this.InsertItemTemplate = this.EditItemTemplate;
            }
            base.OnLoad(e);
        }


        protected override void OnPreRender(EventArgs e)
        {
            IButtonControl oButtonControl;

            base.OnPreRender(e);

            if (this.Visible && this.GridView != null)
            {
                switch (this.CurrentMode)
                {
                    case FormViewMode.Edit:

                        oButtonControl = FindButtonControl("Insert");
                        if (oButtonControl != null)
                        {
                            ((Control)oButtonControl).Visible = false;
                        }


                        oButtonControl = FindButtonControl("Update");
                        if (oButtonControl != null)
                        {
                            ((Control)oButtonControl).Visible = true;
                        }

                        break;
                    case FormViewMode.Insert:

                        oButtonControl = FindButtonControl("Insert");
                        if (oButtonControl != null)
                        {
                            ((Control)oButtonControl).Visible = true;
                        }


                        oButtonControl = FindButtonControl("Update");
                        if (oButtonControl != null)
                        {
                            ((Control)oButtonControl).Visible = false;
                        }

                        break;
                }
            }
        }


        private void ChangeViewMode()
        {
            this.Visible = false;
            this.GridView.Visible = true;
            this.GridView.EditIndex = -1;
        }




        protected override void OnItemInserted(FormViewInsertedEventArgs e)
        {
            base.OnItemInserted(e);

            ChangeViewMode();
        }

        protected override void OnItemUpdated(FormViewUpdatedEventArgs e)
        {
            base.OnItemUpdated(e);

            ChangeViewMode();
        }

        protected override void OnItemCommand(FormViewCommandEventArgs e)
        {
            if (e.CommandName.ToUpper() == "CANCEL")
            {

                ChangeViewMode();
            }
            base.OnItemCommand(e);
        }
    }

}
