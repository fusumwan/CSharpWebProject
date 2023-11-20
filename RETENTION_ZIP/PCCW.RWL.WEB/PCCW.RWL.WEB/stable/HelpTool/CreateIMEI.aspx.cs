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

public partial class SandBox_Default9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        /*
         
insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW LG KP275 BLACK','131000000000000','2650841','NORMAL','CC RET','PLG');
insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW-NOKIA E72 ZODIUM BLACK(4GB MICRO SD)','131000000000000','2404291','NORMAL','CC RET','PLG');
insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW-SONY ERI NAITE J105 VAPOUR SILVER','131000000000000','2614411','NORMAL','CC RET','PLG');
insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW-SAMSUNG M8910 MIDNIGHT BK','131000000000000','2643231','NORMAL','CC RET','PLG');
        update IMEI_stock set IMEI='', KIT_CODE='',STATUS='',DUMMY2 ='CC RET_' where create_by='A8350006'
        DELETE FROM 
         */

        int val = 100000;
        int val2 = 200300;
        for (int i = 0; i < 100; i++)
        {
            val += 1;
            val2 += 1;
            //string _sQuery = "insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW LG KP275 BLACK','131000000" + val + "','2650841','NORMAL','CC RET','PLG');";
            string _sQuery = "insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW LG KP275 BLACK','131100000" + val2 + "','2650841','NORMAL','CC RET','PLG');";
            //string _sQuery = "insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW-SONY ERI NAITE J105 VAPOUR SILVER','131000000"+val2+"','2614411','NORMAL','CC RET','PLG');";
            //string _sQuery = "insert into IMEI_stock (create_date,create_by,model,IMEI,KIT_CODE,STATUS,DUMMY2,DUMMY3) values (to_date('22/09/2009' , 'dd/mm/yyyy hh24:mi:ss'),'A8350006','PCCW-SAMSUNG M8910 MIDNIGHT BK','131000000"+val2+"','2643231','NORMAL','CC RET','PLG');";

            //string _sQuery = "Update IMEI_stock SET IMEI='131000000" + val2 + "'  WHERE  kit_code='2404291' and IMEI='131000000" + val + "';";
            //string _sQuery = "Update IMEI_stock SET IMEI='131000000" + val2 + "'  WHERE  kit_code='2614411' and IMEI='131000000" + val + "';";

            Response.Write(_sQuery + "<br>commit;<br>");
        }
    }
}
