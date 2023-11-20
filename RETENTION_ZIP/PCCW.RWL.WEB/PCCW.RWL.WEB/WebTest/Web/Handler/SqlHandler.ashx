<%@ WebHandler Language="C#" Class="SqlHandler" %>


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
public class SqlHandler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string _sMethod = string.Empty;
        string _sFilter = string.Empty;
        if (context.Request["method"] != null)
        {
            _sMethod = context.Request["method"].ToString();
        }
        if (context.Request["filter"] != null)
        {
            _sFilter = context.Request["filter"].ToString();
        }
        string _sResult = string.Empty;
        StringBuilder _oQuery=new StringBuilder();
        switch (_sMethod)
        {
            case "GETCNMRTNO":
                _oQuery.Append(" SELECT TOP 1 MRT_NO FROM " +MobileNumberProfile.Para.TableName());
                _oQuery.Append(" WHERE ACTIVE=1 AND STATUS='AVALIABLE' AND MRT_NO='" + _sFilter + "'");
                _sResult = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
                if (_sResult != string.Empty)
                {
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE MobileNumberProfile SET STATUS='HOLDED' WHERE MRT_no='" + _sFilter + "' AND STATUS='AVALIABLE' AND ACTIVE=1");
                }
                break;
            case "RELEASECNMRTNO":
                if (_sFilter != string.Empty)
                {
                    SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE MobileNumberProfile SET STATUS='AVALIABLE' WHERE MRT_no='" + _sFilter + "' AND STATUS='HOLDED'  AND ACTIVE=1 ");
                }
                break;
            case "CHKMRTNO":
                _sResult = CheckRetentionOrder(_sFilter);
                break;
            case "ITEMCODECHK":
                if (_sFilter != string.Empty)
                {
                    _sResult = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT TOP 1 item_code  FROM ProductItemCode WHERE  item_code='" + _sFilter + "'");
                }
                break;
        }
        context.Response.Write(_sResult);
    }

    protected string CheckRetentionOrder(string x_sMrt_no)
    {
        if (string.IsNullOrEmpty(x_sMrt_no)) { return string.Empty; }
        MobileRetentionOrderEntity[] _oMobileRetentionOrderEntity = MobileRetentionOrderRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 1, "mrt_no='" + x_sMrt_no + "' AND DATEADD(MONTH,3,log_date)>getdate() AND active=1 ", null, "order_id desc");
        if (_oMobileRetentionOrderEntity != null)
        {
            if (_oMobileRetentionOrderEntity.Length > 0)
            {

                return "此MRT於 " + ((DateTime)_oMobileRetentionOrderEntity[0].GetLog_date()).ToString("dd MMM yyyy") + " 已出ORDER，請確認是否繼續?";
            }
        }
        return string.Empty;
    }
    
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}