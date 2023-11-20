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
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class SandBox_CreateGiftIMEI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        GetAccessoryImei();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    public void GetAccessoryImei()
    {

        AccessoryEntity[] _oGiftBasketArr = AccessoryRepositoryBase.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "mid>0", null, null);
        if (_oGiftBasketArr != null)
        {
            int val = 3100;
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < _oGiftBasketArr.Length; i++)
                {
                    if (_oGiftBasketArr[i].accessory_desc.IndexOf("&") < 0)
                    {
                        string _sQuery = "insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('11/12/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','" + _oGiftBasketArr[i].accessory_desc + "','FG0" + val.ToString() + "','" + _oGiftBasketArr[i].accessory_code + "','NORMAL','CC RET','PLG');";
                        Response.Write(_sQuery + "<br>");
                        Response.Write("commit;<br>");
                        val += 1;
                    }
                }
                Response.Write("commit;");
            }
        }

    }

    public void GetFeeGiftImei()
    {
        GiftBasketEntity[] _oGiftBasketArr = GiftBasketRepositoryBase.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "mid>0", null, null);
        if (_oGiftBasketArr != null)
        {
            int val = 3000;
            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < _oGiftBasketArr.Length; i++)
                {
                    if (_oGiftBasketArr[i].gift_desc.IndexOf("&") < 0)
                    {
                        string _sQuery = "insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('11/12/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','" + _oGiftBasketArr[i].gift_desc + "','FG0" + val.ToString() + "','" + _oGiftBasketArr[i].gift_code + "','NORMAL','CC RET','PLG');";
                        Response.Write(_sQuery + "<br>");
                        val += 1;
                    }
                }
                Response.Write("commit;");
            }
        }
    }
}
