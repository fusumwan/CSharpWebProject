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
///-- Description:	<Description,Class :LoadingBar>
///-- =============================================

namespace NEURON.WEB.UI
{
    [DefaultProperty("Text"),
    ToolboxData("<{0}:LoadingBar runat=server></{0}:IELoadingBar>")]
    public class LoadingBar : System.Web.UI.WebControls.WebControl
    {
        private string _sLoadingText = "HTML Loading Page";


        private string _sLoadHTML1 = "<SCRIPT LANGUAGE='JavaScript'> if(document.getElementById) { var upLevel = true; }	else if(document.layers) {	var ns4 = true;	}else if(document.all) { var ie4 = true;}function showObject(obj) {	if (ns4) {	obj.visibility = 'show';}else if (ie4 || upLevel) {	obj.style.visibility = 'visible';}} function hideObject(obj) {	if (ns4) {	obj.visibility = 'hide';}	if (ie4 || upLevel) {obj.style.visibility = 'hidden';}	}</SCRIPT>";
        private string _sLoadHTML2 = string.Empty;
        private string _sLoadHTML3 = "<SCRIPT LANGUAGE='JavaScript'> if(upLevel) {	var load = document.getElementById('loadingScreen');	}	else if(ns4)	{		var load = document.loadingScreen;	}	else if(ie4)	{	var load = document.all.loadingScreen;	}	hideObject(load);</SCRIPT>";

        /*
         private string _sLoadHTML1 = "<SCRIPT LANGUAGE='JavaScript'> if(document.getElementById) { var upLevel = true; }	else if(document.layers) {	var ns4 = true;	}else if(document.all) { var ie4 = true;}function showObject(obj) {	if (ns4) {	obj.visibility = 'show';}else if (ie4 || upLevel) {	obj.style.display = 'inline';}} function hideObject(obj) {	if (ns4) {	obj.display = 'none';}	if (ie4 || upLevel) {obj.style.display = 'none';}	}</SCRIPT>";
        private string _sLoadHTML2 = string.Empty;
        private string _sLoadHTML3 = "<SCRIPT LANGUAGE='JavaScript'> if(upLevel) {	var load = document.getElementById('loadingScreen');	}	else if(ns4)	{		var load = document.loadingScreen;	}	else if(ie4)	{	var load = document.all.loadingScreen;	}	hideObject(load);</SCRIPT>";
         */

        private string _sSrcImage = "loading.gif";

        [Bindable(true),
        Category("Appearance"),
        DefaultValue("HTML Loading Page")]
        public string LoadingText
        {
            get
            {
                return _sLoadingText;
            }
            set
            {
                _sLoadingText = value;
            }
        }

        public string SrcImage
        {
            get
            {
                return _sSrcImage;
            }
            set
            {
                _sSrcImage = value;
            }
        }

        public LoadingBar()
        {
            this.Init += new EventHandler(Initing);
            this.Load += new EventHandler(Loading);
        }

        public void PageLoading(int x_iMilliSeconds)
        {
            TimeSpan _oWaitTime = new TimeSpan(0, 0, 0, 0,x_iMilliSeconds);
            System.Threading.Thread.Sleep(_oWaitTime);
        }

        protected void Initing(Object sender, System.EventArgs e)
        {

            _sLoadHTML2 = "<DIV ID='loadingScreen' STYLE='POSITION: absolute;Z-INDEX:5; LEFT: 1%; TOP: 1%;'>";
            _sLoadHTML2 += "<TABLE  width=\"100\" border=\"1\" cellpadding=\"5\" cellspacing=\"0\" bordercolor=\"#CCCCCC\">";
            _sLoadHTML2 += "<TR><TD width=\"94\" height=\"24\" valign=\"middle\" bgcolor=\"#FFFFCC\">";
            _sLoadHTML2 += "<IMG SRC='{0}' BORDER='0'>";
            _sLoadHTML2 += "<SPAN style=\"color: #666666;font-size: 12px;\">Loading ..... </SPAN>";
            _sLoadHTML2 +="</TD></TR></TABLE></DIV>";


            WebControl _oTmp = sender as WebControl;
            _sLoadHTML2 = string.Format(_sLoadHTML2, SrcImage);
            _oTmp.Page.Response.Write(_sLoadHTML1 + _sLoadHTML2);
            _oTmp.Page.Response.Flush();
        }

        protected void Loading(Object sender, System.EventArgs e)
        {
            WebControl _oTmp = sender as WebControl;
            _oTmp.Page.Response.Write(_sLoadHTML3);
        }
    }
}
