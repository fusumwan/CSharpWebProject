<%@ WebHandler Language="C#" Class="IMEIManagementTool" %>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using log4net;
using System.Reflection;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

public class IMEIManagementTool : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string _sMethod = string.Empty;
        if (context.Request["method"] != null)
        {
            _sMethod = context.Request["method"].ToString();
        }
        string _sEdf_no = string.Empty;
        string _sImei_no = string.Empty;
        string _sResult = string.Empty;
        if (string.IsNullOrEmpty(_sMethod)) return;
        switch (_sMethod)
        {
            case "ChkExistingOrder":
                _sEdf_no = ((context.Request["edf_no"] != null) ? context.Request["edf_no"].ToString() : string.Empty);
                if (PCCW.RWL.CORE.IMEIManagementTool.ChkExistingOrder(_sEdf_no))
                    context.Response.Write("TRUE");
                else
                    context.Response.Write("FALSE");
                break;
            case "ChkExistingIMEI":
                _sImei_no = ((context.Request["imei_no"] != null) ? context.Request["imei_no"].ToString() : string.Empty);
                if (PCCW.RWL.CORE.IMEIManagementTool.ChkExistingIMEI(_sImei_no))
                    context.Response.Write("TRUE");
                else
                    context.Response.Write("FALSE");
                break;
            case "ChkExistingIMEIStatus":
                _sImei_no = ((context.Request["imei_no"] != null) ? context.Request["imei_no"].ToString() : string.Empty);
                context.Response.Write(PCCW.RWL.CORE.IMEIManagementTool.ChkExistingIMEIStatus(_sImei_no));
                break;
            case "GetSkuHsmodel":
                _sEdf_no = ((context.Request["edf_no"] != null) ? context.Request["edf_no"].ToString() : string.Empty);
                string _sSku_hs_model= SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(
                "SELECT TOP 1 [sku]+' - '+[hs_model] as [sku_hs_model] FROM MobileRetentionOrder WHERE edf_no='" + _sEdf_no + "' ");
                context.Response.Write(_sSku_hs_model);
                break;
        }
    }

    
    
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}