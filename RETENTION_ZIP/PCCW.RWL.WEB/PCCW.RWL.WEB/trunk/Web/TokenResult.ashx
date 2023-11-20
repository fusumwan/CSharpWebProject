<%@ WebHandler Language="C#" Class="TokenResult" %>
using System;
using System.Web;
using System.Text;
public class TokenResult : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        StringBuilder _oHtmlContent = new StringBuilder();
        _oHtmlContent.AppendLine("<html><title></title><body><script>");
        _oHtmlContent.AppendLine("if(window.opener.document.getElementById('ActiveCreditId')!=undefined){");
        _oHtmlContent.AppendLine("var token=window.opener.document.getElementById('ActiveCreditId').value;");
        _oHtmlContent.AppendLine("window.opener.document.getElementById(token).value='" + context.Request["V5"] + "';");
        _oHtmlContent.AppendLine("window.close();");
        _oHtmlContent.AppendLine("}");
        _oHtmlContent.AppendLine("</script></body></html>");
        
        
        context.Response.ContentType = "text/html";
        //context.Response.Write("<html><title></title><body><script>var token=window.opener.document.getElementById('ActiveCreditId').value;window.opener.document.getElementById(token).value='" + context.Request["V5"] + "';window.close();</script></body></html>");
        context.Response.Write(_oHtmlContent.ToString());
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}