using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;
using PCCW.RWL.CORE;

public partial class HelpTool_CheckIPhoneCreateStockRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        CheckIMEI_STOCK(284276);


        CheckIMEI_STOCK(308471);
        CheckIMEI_STOCK(316838);
        CheckIMEI_STOCK(329962);
        CheckIMEI_STOCK(337525);
        CheckIMEI_STOCK(340491);
        CheckIMEI_STOCK(341129);
        CheckIMEI_STOCK(341168);
        CheckIMEI_STOCK(345209);
        CheckIMEI_STOCK(345587);
        CheckIMEI_STOCK(345616);
        CheckIMEI_STOCK(345625);
        CheckIMEI_STOCK(345628);
        CheckIMEI_STOCK(345637);
        CheckIMEI_STOCK(345667);
        CheckIMEI_STOCK(345678);
        CheckIMEI_STOCK(345689);
        CheckIMEI_STOCK(345788);
        CheckIMEI_STOCK(345816);
        CheckIMEI_STOCK(345841);
        CheckIMEI_STOCK(345859);
        CheckIMEI_STOCK(345946);
        CheckIMEI_STOCK(346051);
        CheckIMEI_STOCK(346130);
        CheckIMEI_STOCK(346188);
        CheckIMEI_STOCK(346203);
        CheckIMEI_STOCK(346250);
        CheckIMEI_STOCK(346252);
        CheckIMEI_STOCK(346259);
        CheckIMEI_STOCK(346403);
        CheckIMEI_STOCK(346445);
        CheckIMEI_STOCK(346466);
        CheckIMEI_STOCK(346468);
        CheckIMEI_STOCK(346522);
        CheckIMEI_STOCK(346532);
        CheckIMEI_STOCK(346568);
        CheckIMEI_STOCK(346725);
        CheckIMEI_STOCK(346795);
        CheckIMEI_STOCK(346815);
        CheckIMEI_STOCK(346858);
        CheckIMEI_STOCK(346901);
        CheckIMEI_STOCK(346932);
        CheckIMEI_STOCK(346947);
        CheckIMEI_STOCK(346951);
        CheckIMEI_STOCK(346956);
        CheckIMEI_STOCK(346957);
        CheckIMEI_STOCK(347023);
        CheckIMEI_STOCK(347239);
        CheckIMEI_STOCK(347322);
        CheckIMEI_STOCK(347400);
        CheckIMEI_STOCK(347470);
        CheckIMEI_STOCK(347482);
        CheckIMEI_STOCK(347554);
        CheckIMEI_STOCK(347569);
        CheckIMEI_STOCK(347954);
        CheckIMEI_STOCK(347982);
        CheckIMEI_STOCK(347994);
        CheckIMEI_STOCK(348176);
        CheckIMEI_STOCK(348462);
        CheckIMEI_STOCK(349016);
        CheckIMEI_STOCK(349135);
        CheckIMEI_STOCK(349265);
        CheckIMEI_STOCK(349461);
        CheckIMEI_STOCK(349693);
        CheckIMEI_STOCK(349768);
        CheckIMEI_STOCK(350059);
        CheckIMEI_STOCK(350256);
        CheckIMEI_STOCK(350257);
        CheckIMEI_STOCK(350259);
        CheckIMEI_STOCK(350281);
        CheckIMEI_STOCK(350352);
        CheckIMEI_STOCK(350405);
        CheckIMEI_STOCK(350511);
        CheckIMEI_STOCK(350540);
        CheckIMEI_STOCK(350659);
        CheckIMEI_STOCK(350694);
        CheckIMEI_STOCK(350760);
        CheckIMEI_STOCK(350808);
        CheckIMEI_STOCK(350838);
        CheckIMEI_STOCK(350879);
        CheckIMEI_STOCK(350887);
        CheckIMEI_STOCK(350908);
        CheckIMEI_STOCK(351072);
        CheckIMEI_STOCK(351102);
        CheckIMEI_STOCK(351205);
        CheckIMEI_STOCK(351237);
        CheckIMEI_STOCK(351243);
        CheckIMEI_STOCK(351326);
        CheckIMEI_STOCK(351573);
        CheckIMEI_STOCK(351615);
        CheckIMEI_STOCK(351642);
        CheckIMEI_STOCK(351700);
        CheckIMEI_STOCK(351719);
        CheckIMEI_STOCK(351720);
        CheckIMEI_STOCK(351906);
        CheckIMEI_STOCK(352112);
        CheckIMEI_STOCK(352232);
        CheckIMEI_STOCK(352239);
        CheckIMEI_STOCK(352453);
        CheckIMEI_STOCK(352469);
        CheckIMEI_STOCK(352470);
        CheckIMEI_STOCK(352484);
        CheckIMEI_STOCK(352582);
        CheckIMEI_STOCK(352619);
        CheckIMEI_STOCK(352717);
        CheckIMEI_STOCK(352856);
        CheckIMEI_STOCK(352888);
        CheckIMEI_STOCK(352960);
        CheckIMEI_STOCK(352977);
        CheckIMEI_STOCK(353124);
        CheckIMEI_STOCK(353186);
        CheckIMEI_STOCK(353200);
        CheckIMEI_STOCK(353320);
        CheckIMEI_STOCK(353405);
        CheckIMEI_STOCK(353414);
        CheckIMEI_STOCK(353480);
        CheckIMEI_STOCK(353490);
        CheckIMEI_STOCK(353553);
        CheckIMEI_STOCK(353558);
        CheckIMEI_STOCK(353615);
        CheckIMEI_STOCK(353720);
        CheckIMEI_STOCK(353727);
        CheckIMEI_STOCK(353829);
        CheckIMEI_STOCK(353877);
        CheckIMEI_STOCK(354013);
        CheckIMEI_STOCK(354128);
        CheckIMEI_STOCK(354224);
        CheckIMEI_STOCK(354229);
        CheckIMEI_STOCK(354272);
        CheckIMEI_STOCK(354475);
        CheckIMEI_STOCK(354477);
        CheckIMEI_STOCK(354750);
        CheckIMEI_STOCK(354792);
        CheckIMEI_STOCK(354840);
        CheckIMEI_STOCK(355335);
        CheckIMEI_STOCK(355621);
        CheckIMEI_STOCK(355645);
        CheckIMEI_STOCK(355721);
        CheckIMEI_STOCK(355725);
        CheckIMEI_STOCK(355838);
        CheckIMEI_STOCK(355914);
        CheckIMEI_STOCK(355965);
        CheckIMEI_STOCK(355991);
        CheckIMEI_STOCK(355998);
        CheckIMEI_STOCK(356003);
        CheckIMEI_STOCK(356110);
        CheckIMEI_STOCK(356212);
        CheckIMEI_STOCK(356286);
        CheckIMEI_STOCK(356447);
        CheckIMEI_STOCK(356473);
        CheckIMEI_STOCK(356622);
        CheckIMEI_STOCK(356713);
        CheckIMEI_STOCK(356865);
        CheckIMEI_STOCK(357232);
        CheckIMEI_STOCK(357260);
        CheckIMEI_STOCK(357274);
        CheckIMEI_STOCK(357276);
        CheckIMEI_STOCK(357293);
        CheckIMEI_STOCK(357299);
        CheckIMEI_STOCK(357360);
        CheckIMEI_STOCK(357361);
        CheckIMEI_STOCK(357679);
        CheckIMEI_STOCK(357699);
        CheckIMEI_STOCK(357764);
        CheckIMEI_STOCK(357786);
        CheckIMEI_STOCK(357859);
        CheckIMEI_STOCK(357948);
        CheckIMEI_STOCK(357954);
        CheckIMEI_STOCK(358119);
        CheckIMEI_STOCK(358145);
        CheckIMEI_STOCK(358146);
        CheckIMEI_STOCK(358168);
        CheckIMEI_STOCK(358205);
        CheckIMEI_STOCK(358209);
        CheckIMEI_STOCK(358210);
        CheckIMEI_STOCK(358212);
        CheckIMEI_STOCK(358319);
        CheckIMEI_STOCK(358330);
        CheckIMEI_STOCK(358359);
        CheckIMEI_STOCK(358366);
        CheckIMEI_STOCK(358394);
        CheckIMEI_STOCK(358533);
        CheckIMEI_STOCK(358556);
        CheckIMEI_STOCK(358785);
        CheckIMEI_STOCK(358796);
        CheckIMEI_STOCK(358848);
        CheckIMEI_STOCK(358879);
        CheckIMEI_STOCK(358896);
        CheckIMEI_STOCK(358936);

    }


    protected void CheckIMEI_STOCK(int x_iOrderid)
    {
        AllowInsertAWAITIMEI(x_iOrderid);
    }

    protected void AllowInsertAWAITIMEI(int _iOrder_id)
    {

        string n_sToday1 = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
        if (_oMobileRetentionOrder.GetFound())
        {
            if (_oMobileRetentionOrder.GetImei_no().Equals("AWAIT") &&
                   _oMobileRetentionOrder.GetActive() == true)
            {
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("SELECT DUMMY4,ReferenceNo,MODEL,Kit_Code,Status FROM IMEI_STOCK WHERE ");
                _oQuery.Append(" Kit_Code='" + _oMobileRetentionOrder.GetSku() + "'  ");
                _oQuery.Append(" AND (Status='AWAIT' or Status='STOCK' ) ");
                _oQuery.Append(" AND (DUMMY4='" + Func.IDAdd100000(_iOrder_id) + "' ");
                _oQuery.Append(" or ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "') ");
                _oQuery.Append(" AND Dummy2='CC RET' ");

                Response.Write(_oQuery.ToString() + " union <br>");
                OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
                if (!_oDr.Read())
                {
                    string _sQuery = "INSERT into IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + _oMobileRetentionOrder.GetSku() + "','" + _oMobileRetentionOrder.GetHs_model() + "','AWAIT','" + Func.IDAdd100000(_iOrder_id) + "','" + _oMobileRetentionOrder.GetEdf_no() + "',to_date('" + n_sToday1 + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + _oMobileRetentionOrder.GetStaff_no() + "','" + _oMobileRetentionOrder.GetStaff_no() + "','CC RET','"+_oMobileRetentionOrder.GetDelivery_exchange_location()+"' ) ";

                   // Response.Write(_sQuery + ";<br>");
                    // if (SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sQuery))
                    {
                        //Response.Write("Insert " + _iOrder_id.ToString() + " AWAIT success!<br>");
                    }
                }
                _oDr.Close();
                _oDr.Dispose();
            }
        }
    }

    protected void CancelAOAWAIT(int _iOrder_id)
    {
        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("UPDATE IMEI_STOCK SET STATUS='CANCEL' WHERE ");
        _oQuery.Append(" Kit_Code='" + _oMobileRetentionOrder.GetSku() + "'  ");
        _oQuery.Append(" AND DUMMY4='" + Func.IDAdd100000(_iOrder_id) + "' ");
        //_oQuery.Append(" AND ReferenceNo='" + _oMobileRetentionOrder.GetEdf_no() + "' ");
        _oQuery.Append(" AND Dummy2='CC RET' AND (STATUS='AWAIT' OR STATUS='AO') ");
        _oQuery.Append("  AND ROWNUM<=1");
        bool _bCancel = SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_oQuery.ToString());
    }

}
