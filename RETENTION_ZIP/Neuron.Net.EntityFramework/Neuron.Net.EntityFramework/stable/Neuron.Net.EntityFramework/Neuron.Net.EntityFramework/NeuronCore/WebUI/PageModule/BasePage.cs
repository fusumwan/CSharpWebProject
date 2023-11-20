using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using NEURON.WEB.UI.COMPRESSION;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2008-06-08>
///-- Description:	<Description,Class :BasePage, View State Compression>
///-- =============================================
namespace NEURON.WEB.UI
{
    public class BasePage : Page
    {
        public BasePage()
        {

        }
        protected override object LoadPageStateFromPersistenceMedium()
        {
            try
            {
                string compression = ConfigurationManager.AppSettings["viewStateCompression"];
                if (string.IsNullOrEmpty(compression)) compression = "true";
                if (bool.Parse(compression))
                {
                    string viewState = Request.Form["__VSTATE"];
                    byte[] bytes = Convert.FromBase64String(viewState);
                    bytes = Compressor.Decompress(bytes);
                    LosFormatter formatter = new LosFormatter();
                    return formatter.Deserialize(Convert.ToBase64String(bytes));
                }
                else
                    return base.LoadPageStateFromPersistenceMedium();
            }
            catch (Exception) { throw; }
        }

        protected override void SavePageStateToPersistenceMedium(object viewState)
        {
            try
            {
                string compression = ConfigurationManager.AppSettings["viewStateCompression"];
                if (string.IsNullOrEmpty(compression)) compression = "true";
                if (bool.Parse(compression))
                {
                    LosFormatter formatter = new LosFormatter();
                    StringWriter writer = new StringWriter();
                    formatter.Serialize(writer, viewState);
                    string viewStateString = writer.ToString();
                    byte[] bytes = Convert.FromBase64String(viewStateString);
                    bytes = Compressor.Compress(bytes);

                    System.Web.UI.ScriptManager sm = System.Web.UI.ScriptManager.GetCurrent(this);
                    if (sm != null && sm.IsInAsyncPostBack)
                        System.Web.UI.ScriptManager.RegisterHiddenField(this, "__VSTATE", Convert.ToBase64String(bytes));
                    else
                        Page.ClientScript.RegisterHiddenField("__VSTATE", Convert.ToBase64String(bytes));
                }
                else
                    base.SavePageStateToPersistenceMedium(viewState);
            }
            catch (Exception) { throw; }

        }

    }
}
