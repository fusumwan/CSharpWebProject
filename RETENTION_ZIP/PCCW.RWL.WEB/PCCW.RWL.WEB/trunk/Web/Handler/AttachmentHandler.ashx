<%@ WebHandler Language="C#" Class="AttachmentHandler" %>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState; 
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using System.Text;

public class AttachmentHandler : IHttpHandler, IRequiresSessionState{
    
    public void ProcessRequest (HttpContext context) {
        var _oResponse = context.Response;
        string _sContentType = _oResponse.ContentType.ToString();
        _oResponse.ContentType = "text/plan";
                
        string _sAttachmentID = context.Request.QueryString["AttachmentID"];
        switch (_sAttachmentID)
        {
            case "HandSetMapping":
                if (context.Session["HandSetViewSql"] != null)
                {
                    string _sQuery = context.Session["HandSetViewSql"].ToString();

                    DataSet _oDataSet = SYSConn<MSSQLConnect>.Connect().GetDS(_sQuery);
                    WebFunc.ExportDataSetToExcelAndZip(_oDataSet, "HandSetMapping", false, Encoding.UTF8, WebFunc.ExportContentType.Excel, true, true, false);
                }

                break;
            case "FallOutDeltailCase":
                if (context.Session["FallOutDeltailCaseSql"] != null)
                {
                    string _sQuery = context.Session["FallOutDeltailCaseSql"].ToString();

                    DataSet _oDataSet = SYSConn<ODBCConnect>.Connect().GetDS(_sQuery);
                    WebFunc.ExportDataSetToExcelAndZip(_oDataSet, "FallOutDeltailCase", false, Encoding.UTF8, WebFunc.ExportContentType.Excel, true, true, false);
                }

                break;
            case "BusinessTradeView":

                if (context.Session["BusinessTradeViewSql"] != null)
                {
                    string _sQuery = context.Session["BusinessTradeViewSql"].ToString();
                    DataSet _oDataSet = SYSConn<MSSQLConnect>.Connect().GetDS(_sQuery);
                    WebFunc.ExportDataSetToExcelAndZip(_oDataSet, "BusinessTradeView", false, Encoding.UTF8, WebFunc.ExportContentType.Excel, true, true, false);
                }
                break;
            case "CPE":
                if (context.Session["CPESql"] != null)
                {
                    string _sQuery = context.Session["CPESql"].ToString();
                    DataSet _oDataSet = SYSConn<ODBCConnect>.Connect().GetDS(_sQuery);
                    WebFunc.ExportDataSetToExcelAndZip(_oDataSet, "CPE", false, Encoding.UTF8, WebFunc.ExportContentType.Excel, true, true, false);
                }
                break;
            case "MobileAssignListHistory":
                if (context.Session["MobileAssignListHistorySql"] != null)
                {
                    string _sQuery = context.Session["MobileAssignListHistorySql"].ToString();
                    DataSet _oDataSet = SYSConn<MSSQLConnect>.Connect().GetDS(_sQuery);
                    WebFunc.ExportDataSetToExcelAndZip(_oDataSet, "MobileAssignListHistory", false, Encoding.UTF8, WebFunc.ExportContentType.Excel, true, true, false);
                }
                break;
            case "BusinessVasDefaultSet":
                if (context.Session["BusinessVasDefaultSetSql"] != null)
                {
                    string _sQuery = context.Session["BusinessVasDefaultSetSql"].ToString();
                    DataSet _oDataSet = SYSConn<MSSQLConnect>.Connect().GetDS(_sQuery);
                    WebFunc.ExportDataSetToExcelAndZip(_oDataSet, "BusinessVasDefaultSet", false, Encoding.UTF8, WebFunc.ExportContentType.Excel, true, true, false);
                }
                break;
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}