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
using System.Data.Odbc;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Reflection;

public partial class ReturnSoldGiftDetail : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    string[] n_sDateTimeList = { "dd/mm/yyyy hh24:mi:ss" };
    string[] n_sDateTimeList2 = { "yyyymmdd" };
    string n_sToday = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    string n_sToday1 = DateTime.Now.ToString("yyyyMMdd");
    protected void Page_Load(object sender, EventArgs e)
    {
        this.HeaderScripts.Text = string.Format(
        @"<script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-1.3.2.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/global.js""></script>
        <!--[if lte IE 6]><script defer type=""text/javascript"" src=""{0}/Resources/Scripts/pngfix.js""></script><![endif]-->
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/norefresh.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/script.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery-ui-1.8.2.custom.min.js""></script>
        <script type=""text/javascript"" src=""{0}/Resources/Scripts/jquery.alerts.js""></script>
        <link rel=""stylesheet"" href=""{0}/Resources/Styles/jquery.alerts.css"" type=""text/css"" />"
       , Request.ApplicationPath);

        WebFunc.PrivilegeCheck(this.Page);
        if (!IsPostBack) InitFrame();
    }

    public void InitFrame()
    {
        string _sQuery1 = "SELECT * FROM IMEI_Stock WHERE Dummy2='CC RET' and Status='SOLD' and Kit_Code='" + Func.RQ(Request["sku"]).ToString() + "' AND IMEI='"+Func.RQ(Request["imei"]).ToString()+"'";
        OdbcDataReader _oDr = GetORDB().GetSearch(_sQuery1);
        if (_oDr == null) return;
        if (_oDr.Read())
        {
            string _sAment_Date = string.Empty;
            if (Convert.IsDBNull(_oDr["Dummy1"]) || "".Equals(_oDr["Dummy1"].ToString().Trim()))
            {
                if (!Convert.IsDBNull(_oDr["Create_Date"]) && _oDr["Create_Date"] != null)
                {
                    DateTime _dAment_Date = (DateTime)_oDr["Create_Date"];
                    _sAment_Date = _dAment_Date.ToString("yyyyMMdd");
                }
                else
                {
                    _sAment_Date = Func.FR(_oDr["Dummy1"]).ToString();
                }
                //_sAment_Date = DateTime.ParseExact(_oDr["Create_Date"].ToString(), n_sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces).ToString("yyyyMMdd");
            }
            else
                _sAment_Date = Func.FR(_oDr["Dummy1"]).ToString();

            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("INSERT INTO IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,DUMMY4,Create_Date,Create_By,Dummy1,Dummy2,Stock_In_Date,IMEI,Ament_Date) values ('" + Func.FR(_oDr["Kit_Code"]).ToString() + "','" + Func.FR(_oDr["Model"]).ToString() + "','" + Func.FR(_oDr["Status"]).ToString() + "','" + Func.FR(_oDr["ReferenceNo"]).ToString() + "','" + Func.FR(_oDr["DUMMY4"]).ToString() + "',to_date('" + n_sToday + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "','" + Func.FR(_oDr["Dummy1"]).ToString() + "','" + Func.FR(_oDr["Dummy2"]).ToString() + "','" + Func.FR(_oDr["Stock_In_Date"]).ToString() + "','" + Func.FR(_oDr["IMEI"]).ToString() + "',to_date('" + _sAment_Date + "' , 'yyyymmdd')) ");
            SYSConn<MSSQLConnect>.Connect().ExplicitNonQuery("UPDATE IMEI_Stock SET Status='NORMAL', Dummy1='" + n_sToday1 + "', ReferenceNo=null, StaffNo=null ,Mobile_no=null ,Completed_Date=null, DUMMY4=null WHERE IMEI='" + Func.RQ(Request["imei"]) + "' and Dummy2='CC RET' and Kit_Code='" + Func.RQ(Request["sku"]) + "' ");

            if ("gift_imei".Equals(Request["check_imei"].ToString()))
            {
                string _sRefNo = GetRdf();
                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID ,Form_Name ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Free Gift Code 1','" + Func.RQ(WebFunc.qsSku) + "','')");
                string _sGift_desc = string.Empty;
                SqlDataReader _oDr2 = MobileRetentionOrderBal.GetSearch(GetDB(), "gift_desc,gift_imei", "active=1 and order_id='" + long.Parse(Func.FR(_oDr["DUMMY4"]).ToString()) + "'", null, null);
                if (_oDr2 != null){
                    if (_oDr2.Read())
                        _sGift_desc = Func.FR(_oDr2["gift_desc"]).ToString();
                }
                _oDr2.Close();
                _oDr2.Dispose();
                _sRefNo = GetRdf();

                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Free Gift Description 1','" + _sGift_desc + "','')");
                GetORDB().ExplicitNonQuery("UPDATE sunday_form SET FreeGift1='', FG_Desc1='' WHERE referenceno='" + Func.FR(_oDr["referenceNo"]) + "'");

                MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(GetDB());
                IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderList =
                    from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                    where
                        sMobileRetentionOrderList.active == true && sMobileRetentionOrderList.gift_imei == Request["imei"].ToString() &&
                        sMobileRetentionOrderList.gift_code == Request["sku"].ToString() && sMobileRetentionOrderList.order_id == Convert.ToInt32(Func.IDSubtract100000(Convert.ToInt32(_oDr["DUMMY4"].ToString())))
                    select sMobileRetentionOrderList;


                using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    bool _bRollBack = false;
                    foreach (MobileRetentionOrder _oItem in _oMobileRetentionOrderList)
                    {
                        _oItem.SetDB(GetDB());
                        _oItem.SetGift_imei(string.Empty);
                        _oItem.SetGift_code(string.Empty);
                        _oItem.SetGift_desc(string.Empty);

                        if (!_oSession.Update(_oItem))
                        {
                            _bRollBack = true;
                            break;
                        }
                    }
                    if (!_bRollBack)
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();
                }
            }
            else if ("gift_imei2".Equals(Request["check_imei"].ToString()))
            {
                string _sRefNo = GetRdf();

                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID ,Form_Name ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Free Gift Code 2','" + Func.RQ(WebFunc.qsSku) + "','')");

                string _sGift_desc = string.Empty;
                SqlDataReader _oDr2 = SYSConn<MSSQLConnect>.Connect().GetSearch("select gift_desc2,gift_imei2 from dbo." + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE active=1 and order_id='" + Func.IDSubtract100000(Convert.ToInt32(Func.FR(_oDr["DUMMY4"]).ToString())) + "' ");
                if (_oDr2.Read())
                    _sGift_desc = Func.FR(_oDr2[MobileRetentionOrder.Para.gift_desc2]);

                _oDr2.Close();
                _oDr2.Dispose();

                _sRefNo = GetRdf();
                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID  ,Form_Name  ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) VALUES ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Free Gift Description 2','" + _sGift_desc + "','')");
                GetORDB().ExplicitNonQuery("UPDATE sunday_form SET FreeGift2='', FG_Desc2='' WHERE referenceno='" + Func.FR(_oDr["referenceNo"]) + "'");

                MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(GetDB());
                IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderList =
                    from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                    where
                        sMobileRetentionOrderList.active == true && sMobileRetentionOrderList.gift_imei2 == Request["imei"].ToString() &&
                        sMobileRetentionOrderList.gift_code2 == Request["sku"].ToString() && sMobileRetentionOrderList.order_id == Convert.ToInt32(Func.IDSubtract100000(Convert.ToInt32(_oDr["DUMMY4"].ToString())))
                    select sMobileRetentionOrderList;

                using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    bool _bRollBack = false;
                    foreach (MobileRetentionOrder _oItem in _oMobileRetentionOrderList)
                    {
                        _oItem.SetDB(GetDB());
                        _oItem.SetGift_imei(string.Empty);
                        _oItem.SetGift_code(string.Empty);
                        _oItem.SetGift_desc(string.Empty);
                        if (_oSession.Update(_oItem))
                        {
                            _bRollBack = true;
                            break;
                        }
                    }

                    if (!_bRollBack)
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();
                }
            }
            else if ("accessory_imei".Equals(Request["check_imei"].ToString()))
            {
                string _sRefNo = GetRdf();
                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID ,Form_Name ,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Free Gift Code 1','" + Func.RQ(WebFunc.qsSku) + "','')");
                string _sGift_desc = string.Empty;
                int _iaccessory_price = 0;
                int _iAmount = 0;
                int _iNew_amount = 0;
                int _iOld_amount = 0;
                OdbcDataReader _oDr2 = GetORDB().GetSearch("select amount,accessory_desc,accessory_imei,accessory_price from dbo." + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) WHERE active=1 and order_id='" + Func.IDSubtract100000(Convert.ToInt32(_oDr["DUMMY4"].ToString())) + "' ");
                if (_oDr2.Read())
                {
                    _sGift_desc = Func.FR(_oDr2["accessory_desc"]);
                    if (string.IsNullOrEmpty(Func.FR(_oDr2["amount"]).Trim()))
                        _iAmount = 0;
                    else
                        _iAmount = Convert.ToInt32(Func.FR(_oDr2["amount"]).Trim());
                    if (string.IsNullOrEmpty(Func.FR(_oDr2["accessory_price"]).Trim()))
                        _iaccessory_price = 0;
                    else
                        _iaccessory_price = Convert.ToInt32(Func.FR(_oDr2["accessory_price"]).Trim());
                    if (string.IsNullOrEmpty(Func.FR(_oDr2["new_amount"])))
                        _iNew_amount = 0;
                    else
                        _iOld_amount = _iaccessory_price + _iAmount;
                }
                _oDr2.Close();
                _oDr2.Dispose();

                _sRefNo = GetRdf();
                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID,Form_Name,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Free Gift Description','" + _sGift_desc + "','')");
                _sRefNo = GetRdf();
                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID,Form_Name,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Accessory Cost','" + _iaccessory_price.ToString() + "','0')");
                _sRefNo = GetRdf();
                GetORDB().ExplicitNonQuery("INSERT INTO SUNDAY_Ament (Record_ID,Form_Name,REFERENCENO,Ament_Date, AMENT_BY ,Field_Name ,Change_From,Change_To ) Values ('" + _sRefNo + "','CC RET','" + Func.FR(_oDr["referenceNo"]) + "',to_date('" + n_sToday + "', 'dd/mm/yyyy hh24:mi:ss'),'" + RWLFramework.CurrentUser[this.Page].Uid + "' ,'Order Amount','" + _iOld_amount + "','" + _iAmount.ToString() + "')");

                GetORDB().ExplicitNonQuery("UPDATE sunday_form SET Order_Amt='" + _iAmount.ToString() + "', CASH_AMT='0', Plan_code='', FG_Code='' WHERE referenceno='" + Func.FR(_oDr["referenceNo"]) + "'");
                MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(GetDB());
                IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderList =
                    from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                    where
                        sMobileRetentionOrderList.active == true && sMobileRetentionOrderList.gift_imei2 == Request["imei"].ToString() &&
                        sMobileRetentionOrderList.gift_code2 == Request["sku"].ToString() && sMobileRetentionOrderList.order_id == Convert.ToInt32(Func.IDSubtract100000(Convert.ToInt32(_oDr["DUMMY4"].ToString())))
                    select sMobileRetentionOrderList;

                using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                using (ITransaction _oTransaction = _oSession.BeginTransaction())
                {
                    bool _bRollBack = false;
                    foreach (MobileRetentionOrder _oItem in _oMobileRetentionOrderList)
                    {
                        _oItem.SetDB(GetDB());
                        _oItem.SetGift_imei(string.Empty);
                        _oItem.SetGift_code(string.Empty);
                        _oItem.SetGift_desc(string.Empty);
                        if (_oSession.Update(_oItem))
                        {
                            _bRollBack = true;
                            break;
                        }
                    }
                    if (!_bRollBack)
                        _oTransaction.Commit();
                    else
                        _oTransaction.Rollback();

                }

            }

            Response.Write("<script>window.opener.document.form1."+Request["check_imei"].ToString()+".value=\"\";</script>");
            Response.Write("<script>window.opener.document.form1.get_" + Request["check_imei"].ToString() + ".disabled=false;</script>");
            Response.Write("<script>window.opener.document.form1.r_" + Request["check_imei"].ToString() + ".disabled=true;</script>");
            Response.Write("<script>window.opener.document.form1." + Request["gift"].ToString() + ".disabled=false;</script>");
            Response.Write("<script>window.opener.document.form1.r_" + Request["check_imei"].ToString() + ".style.display=\"none\";</script>");
            Response.Write("<script>window.opener.document.form1.get_" + Request["check_imei"].ToString() + ".style.display=\"inline\";</script>");
        }
        else
        {
            Response.Write("<script>alert(\"Cannot release\")</script>");


        }
    }

    public string GetRdf()
    {

        OdbcDataReader _oDr2 = GetORDB().GetSearch("SELECT FTS_CPE5_Serial.NextVal AS seq, to_char(sysdate, 'yymon') AS cdate FROM dual");
        string _sRefNo = string.Empty;
        if (_oDr2 != null)
        {
            if (_oDr2.Read())
            {
                _sRefNo = _oDr2["seq"].ToString() + "/A/" + _oDr2["cdate"].ToString();
            }
        }
        _oDr2.Close();
        _oDr2.Dispose();
        

        return _sRefNo;
    }


    #region GetDB
    protected MSSQLConnect GetDB()
    {
        MSSQLConnect _oDB = new MSSQLConnect();
        _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        _oDB.bWithNoLock = true;
        return _oDB;
    }
    #endregion

    #region Get Oracle DB
    protected ODBCConnect GetORDB()
    {
        ODBCConnect _oDB = new ODBCConnect();
        _oDB.SetConnStr(Configurator.DBName.ORADNS+((Configurator.IsUat()) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion
}
