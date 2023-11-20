<%@ WebHandler Language="C#" Class="CheckIphoneHKID" %>

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public class CheckIphoneHKID : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string qsHkid = context.Request.QueryString["hkid"];
        SpecialCustomerEntity n_oSpecialCustomer = GetSpecialCustomer(qsHkid);
        string qsSku = context.Request.QueryString["sku"];
        string qsOrder_id = (!string.IsNullOrEmpty(context.Request.QueryString["id"])) ? (Func.IDSubtract100000(Convert.ToInt32(context.Request.QueryString["id"])).ToString()) : "";

        bool HaveIPhone = false;
        bool HaveIPad = false;
        
        #region Check IPhone 3 Concierge Service
        if (WebFunc.qsSku == "2421051" || 
            WebFunc.qsSku == "2420731" || 
            WebFunc.qsSku == "2420911" || 
            WebFunc.qsSku == "2420961" || 
            WebFunc.qsSku == "2420971" || 
            WebFunc.qsSku == "2420981"
            )
        {
            bool _bSpecialCustomer = false;
            CheckSpecialCustomer(ref _bSpecialCustomer, ref n_oSpecialCustomer);
            context.Response.Clear();
            if (FromRegisterControler.CheckAllSystemIPhoneOrderIPhone3(qsHkid, qsOrder_id) && _bSpecialCustomer == false)
            {
                //Customer has already used IPhone Concierge Service!
                HaveIPhone = true;
            }

        }
        #endregion



        #region Check IPhone 4 Concierge Service
        if (WebFunc.qsSku == "2421561" ||
            WebFunc.qsSku == "2421571" 
            )
        {
            

            bool _bSpecialCustomer = false;
            CheckSpecialCustomer(ref _bSpecialCustomer, ref n_oSpecialCustomer);
            context.Response.Clear();
            if (FromRegisterControler.CheckAllSystemIPhoneOrderIPhone4(qsHkid, qsOrder_id) && _bSpecialCustomer == false)
            {
                //Customer has already used IPhone Concierge Service!
                HaveIPhone = true;
            }

        }
        #endregion

        #region Check IPad Concierge Service
        if (WebFunc.qsSku == "2421101" ||
            WebFunc.qsSku == "2421111" ||
            WebFunc.qsSku == "2421121"
            )
        {
            bool _bSpecialCustomer = false;
            CheckSpecialCustomer(ref _bSpecialCustomer, ref n_oSpecialCustomer);
            context.Response.Clear();
            if (FromRegisterControler.CheckAllSystemIPhoneOrderIPad(qsHkid, qsOrder_id) && _bSpecialCustomer == false)
            {
                //Customer has already used IPhone Concierge Service!
                HaveIPad = true;
            }

        }
        /*if (!FromRegisterControler.CheckSameIphoneSameOrder(qsOrder_id, qsSku))
        {
            Response.Clear();
            Response.Write("true");
        }*/

        if (HaveIPhone && HaveIPad)
        {
            context.Response.Write("false");
        }
        else
        {
            context.Response.Write("true");
        }
        
        #endregion
        
        
        
    }

    protected void CheckSpecialCustomer(ref bool x_bSpecialCustomer, ref SpecialCustomerEntity x_oSpecialCustomer)
    {
        if (x_oSpecialCustomer != null)
        {
            if (x_oSpecialCustomer.GetCount() != null)
            {
                int _iCount = (int)x_oSpecialCustomer.GetCount();
                if (_iCount > 0)
                {
                    x_bSpecialCustomer = true;
                }
            }
        }
    }

    protected static SpecialCustomerEntity GetSpecialCustomer(string _sHkid)
    {
        _sHkid = _sHkid.Replace("'", "''").Trim();
        if (string.IsNullOrEmpty(_sHkid)) return null;
        SpecialCustomerEntity[] _oSpecialCustomerArr = SpecialCustomerBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), " hkid='" + _sHkid + "' ", null, null);
        if (_oSpecialCustomerArr != null)
        {
            if (_oSpecialCustomerArr.Length > 0)
                return _oSpecialCustomerArr[0];
        }
        return null;
    }
    
    public bool IsReusable {
        get {
            return false;
        }
    }

}