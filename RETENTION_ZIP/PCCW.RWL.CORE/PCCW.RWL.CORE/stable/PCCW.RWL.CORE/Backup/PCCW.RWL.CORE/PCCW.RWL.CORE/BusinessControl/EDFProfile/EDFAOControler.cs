using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;
using System.Data.Odbc;
using System.Data.SqlTypes;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-Wed>
///-- Description:	<Description,Class :EDFAOControler, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class EDFAOControler
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Init Salemancodelist
        public void InitSalemancodeList(string x_sUid)
        {
            if (x_sUid == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sUid");
            n_oSalesmancodeList = new global::System.Collections.Generic.List<string>();
            n_oSalesmancodeList1 = new global::System.Collections.Generic.List<string>();
            global::System.Data.SqlClient.SqlDataReader _oReader = ProfileTeamDetailBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "salesmancode", "active=1 and staff_no='" + x_sUid.ToString() + "'", null, null);
            n_oSalesmancodeList.Clear();
            n_oSalesmancodeList1.Clear();
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    n_oSalesmancodeList.Add(_oReader[ProfileTeamDetail.Para.salesmancode].ToString());
                    n_oSalesmancodeList1.Add(_oReader[ProfileTeamDetail.Para.salesmancode].ToString());
                }
            }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
        }
        #endregion

        #region Ao Html Code
        public global::System.Collections.Generic.List<string> GetAoHtmlCode(string x_sUid, string x_sLv)
        {
            if (x_sUid == null) throw new ArgumentNullException("x_sUid");
            if (x_sLv == null) throw new ArgumentNullException("x_sLv");
            global::System.Collections.Generic.List<string> _oWr = new global::System.Collections.Generic.List<string>();
            InitSalemancodeList(x_sUid);

            ArrayList _oStockList = new ArrayList();

            string _sQuery = "SELECT IMEI_Stock.DUMMY4, IMEI_Stock.MODEL MODEL, SUNDAY_form.Cancelled Cancelled FROM IMEI_Stock left join sunday_form SUNDAY_form on IMEI_Stock.DUMMY4 =  SUNDAY_form.agree_no  WHERE IMEI_Stock.Dummy2='CC RET' AND (IMEI_Stock.Status='AO' OR IMEI_Stock.Status='AWAIT') AND IMEI_Stock.MODEL<>' ' AND IMEI_Stock.MODEL is not null   ";
            if (!("65535".Equals(x_sLv) || "10".Equals(x_sLv) || "4".Equals(x_sLv)))
                _sQuery += " AND (IMEI_Stock.StaffNo='" + x_sUid + "' OR IMEI_Stock.StaffNo='' OR IMEI_Stock.StaffNo is null) ";
            //_sQuery += " AND IMEI_Stock.ReferenceNo is not null AND (SUNDAY_form.Cancelled ='N' or SUNDAY_form.Cancelled is null) and IMEI_Stock.DUMMY4 is not null ORDER BY IMEI_Stock.DUMMY4  ";
            _sQuery += " AND IMEI_Stock.ReferenceNo is not null and IMEI_Stock.DUMMY4 is not null ORDER BY IMEI_Stock.DUMMY4  ";
            global::System.Data.Odbc.OdbcDataReader _oDrCount2 = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);

            //read all SundayImeiStock. DUMMY4 on 
            while (_oDrCount2.Read())
            {
                if (!Func.FR(_oDrCount2["MODEL"]).Trim().Equals(string.Empty))
                {
                    int _iRecordID;
                    if (int.TryParse(Func.FR(_oDrCount2["DUMMY4"]), out _iRecordID))
                    {
                        bool _bFlag = true;
                        string _sCancel = Func.FR(_oDrCount2["Cancelled"]).Trim();
                        if (_sCancel.ToUpper().Equals("Y"))
                        {
                            string _sOrder_id = Func.IDSubtract100000(_iRecordID);
                            string _sEdf_no = string.Empty;
                            string _sImei_no = string.Empty;
                            SqlDataReader _oRDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT edf_no,Imei_no FROM MobileRetentionOrder WHERE active=1 AND order_id='" + _sOrder_id + "'");
                            if (_oRDr.Read())
                            {
                                _sEdf_no = Func.FR(_oRDr["edf_no"]).Trim().ToUpper();
                                _sImei_no = Func.FR(_oRDr["Imei_no"]).Trim().ToUpper();
                                if (_sEdf_no.Equals(string.Empty) && _sImei_no.Equals("AO"))
                                {
                                    _bFlag = true;
                                }
                                else
                                {
                                    _bFlag = false;
                                }
                            }
                            else
                            {
                                _bFlag = false;
                            }
                            _oRDr.Close();
                            _oRDr.Dispose();
                        }
                        if (_bFlag)
                        {
                            if (!_oStockList.Contains(Func.FR(_oDrCount2["DUMMY4"])))
                            {
                                if (!CheckWebLogHaveIMEI(_iRecordID - 100000))
                                {
                                    _oStockList.Add(Func.FR(_oDrCount2["DUMMY4"]));
                                }
                            }
                        }
                    }
                }
            }
            _oDrCount2.Close();
            _oDrCount2.Dispose();

            //read all active data all 
            ArrayList _oAvailableRefList = new ArrayList();
            //ArrayList AvailableRefListCount = new ArrayList();

            for (int _icountList = 0; _icountList <= _oStockList.Count - 1; _icountList++)
            {
                //read all referenceno is active
                _sQuery = "SELECT datediff(d,getdate(),d_date) as date_diff,hs_model,d_date,staff_name,salesmancode,mrt_no FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and order_id='" + Func.IDSubtract100000(Convert.ToInt32(_oStockList[_icountList])) + "' AND hs_model<>'' AND hs_model is not null and imei_no is not null and imei_no<>'' and (imei_no='AO' or imei_no='AWAIT' or imei_no='Await')";
                global::System.Data.SqlClient.SqlDataReader _oDrCount3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                if (_oDrCount3.Read())
                {
                    if (!_oAvailableRefList.Contains(Func.IDSubtract100000(Convert.ToInt32(_oStockList[_icountList]))))
                    {
                        _oAvailableRefList.Add(Func.IDSubtract100000(Convert.ToInt32(_oStockList[_icountList])));
                    }
                }
                _oDrCount3.Close();
                _oDrCount3.Dispose();
            }




            ArrayList _omodelList = new ArrayList();
            ArrayList _oedateList = new ArrayList();
            ArrayList _ologdateList = new ArrayList();

            for (int _icountList = 0; _icountList <= _oAvailableRefList.Count - 1; _icountList++)
            {
                _sQuery = "select edate, cdate, sku from [MobileRetentionOrder] where [MobileRetentionOrder].order_id ='" + _oAvailableRefList[_icountList] + "'  AND [MobileRetentionOrder].active=1 AND hs_model<>'' AND hs_model is not null and imei_no is not null and imei_no<>'' and (imei_no='AO' or imei_no='AWAIT' or imei_no='Await')";
                global::System.Data.SqlClient.SqlDataReader _oDrCount4 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                if (_oDrCount4.Read())
                {
                    _omodelList.Add(_oDrCount4["sku"]);
                    _oedateList.Add(_oDrCount4["edate"]);
                    _ologdateList.Add(_oDrCount4["cdate"]);

                }
                _oDrCount4.Close();
                _oDrCount4.Dispose();
            }
            //using AvailableRefList, modelList, edateList and logdateList to get Q_value for each Imei
            String _scurrentOrderNumer = "";
            String _scurrentModel = "";
            DateTime? _dcurrentEdate;
            DateTime? _dcurrentLogDate;
            String _sCompare_OrderNumer = "";
            String _sCompare_Model = "";
            DateTime? _dCompare_Edate;
            DateTime? _dCompare_LogDate;
            int _iQ_value;
            ArrayList _oQValueList = new ArrayList();

            for (int _icountList = 0; _icountList <= _oAvailableRefList.Count - 1; _icountList++)
            {
                _iQ_value = 0;
                _scurrentOrderNumer = _oAvailableRefList[_icountList].ToString();
                _scurrentModel = _omodelList[_icountList].ToString();
                if (_oedateList[_icountList].ToString() != "" && _oedateList[_icountList].ToString() != null)
                {
                    _dcurrentEdate = (DateTime)_oedateList[_icountList];
                }
                else
                {
                    _dcurrentEdate = null;
                }
                if (_ologdateList[_icountList].ToString() != "" && _ologdateList[_icountList].ToString() != null)
                {
                    _dcurrentLogDate = (DateTime)_ologdateList[_icountList];
                }
                else
                {
                    _dcurrentLogDate = null;
                }
                for (int _icountList2 = 0; _icountList2 <= _oAvailableRefList.Count - 1; _icountList2++)
                {
                    _sCompare_OrderNumer = _oAvailableRefList[_icountList2].ToString();
                    _sCompare_Model = _omodelList[_icountList2].ToString();
                    if (_oedateList[_icountList2].ToString() != "" && _oedateList[_icountList2].ToString() != null)
                    {
                        _dCompare_Edate = (DateTime)_oedateList[_icountList2];
                    }
                    else
                    {
                        _dCompare_Edate = null;
                    }
                    if (_ologdateList[_icountList2].ToString() != "" && _ologdateList[_icountList2].ToString() != null)
                    {
                        _dCompare_LogDate = (DateTime)_ologdateList[_icountList2];
                    }
                    else
                    {
                        _dCompare_LogDate = null;
                    }
                    //if not a same order id and same model, do a compare to get a Q_value
                    if (_sCompare_OrderNumer != _scurrentOrderNumer && _sCompare_Model == _scurrentModel)
                    {
                        //when currentEdate has a value do a compare with the other edate and logdate
                        if (_dcurrentEdate != null)
                        {
                            if (_dCompare_Edate != null)
                            {
                                if (DateTime.Compare((DateTime)_dcurrentEdate, (DateTime)_dCompare_Edate) > 0)
                                {
                                    _iQ_value++;
                                }
                                if (DateTime.Compare((DateTime)_dcurrentEdate, (DateTime)_dCompare_Edate) == 0)
                                {
                                    if (int.Parse(_scurrentOrderNumer) > int.Parse(_sCompare_OrderNumer))
                                    {
                                        _iQ_value++;
                                    }
                                }

                            }
                            else
                            {
                                if (DateTime.Compare((DateTime)_dcurrentEdate, (DateTime)_dCompare_LogDate) > 0)
                                {
                                    _iQ_value++;
                                }
                                if (DateTime.Compare((DateTime)_dcurrentEdate, (DateTime)_dCompare_LogDate) == 0)
                                {
                                    if (int.Parse(_scurrentOrderNumer) > int.Parse(_sCompare_OrderNumer))
                                    {
                                        _iQ_value++;
                                    }
                                }
                            }

                        }
                        else
                        {
                            if (_dCompare_Edate != null)
                            {
                                if (DateTime.Compare((DateTime)_dcurrentLogDate, (DateTime)_dCompare_Edate) > 0)
                                {
                                    _iQ_value++;
                                }
                                if (DateTime.Compare((DateTime)_dcurrentLogDate, (DateTime)_dCompare_Edate) == 0)
                                {
                                    if (int.Parse(_scurrentOrderNumer) > int.Parse(_sCompare_OrderNumer))
                                    {
                                        _iQ_value++;
                                    }
                                }
                            }
                            else
                            {
                                if (DateTime.Compare((DateTime)_dcurrentLogDate, (DateTime)_dCompare_LogDate) > 0)
                                {
                                    _iQ_value++;
                                }
                                if (DateTime.Compare((DateTime)_dcurrentLogDate, (DateTime)_dCompare_LogDate) == 0)
                                {
                                    if (int.Parse(_scurrentOrderNumer) > int.Parse(_sCompare_OrderNumer))
                                    {
                                        _iQ_value++;
                                    }
                                }
                            }
                        }
                    }
                }

                if (_iQ_value == 0)
                {
                    _oQValueList.Add(1);
                }
                else
                {
                    _oQValueList.Add(_iQ_value + 1);
                }
            }

            _sQuery = "SELECT IMEI_Stock.DUMMY4, IMEI_Stock.MODEL MODEL,IMEI_Stock.Kit_Code,IMEI_Stock.StaffNo,IMEI_Stock.Status, SUNDAY_form.Cancelled Cancelled FROM IMEI_Stock left join sunday_form SUNDAY_form on IMEI_Stock.DUMMY4 =  SUNDAY_form.agree_no  WHERE IMEI_Stock.Dummy2='CC RET' AND (IMEI_Stock.Status='AO' OR IMEI_Stock.Status='STOCK' OR IMEI_Stock.Status='AWAIT') AND IMEI_Stock.MODEL<>' ' AND IMEI_Stock.MODEL is not null  ";
            if (!("65535".Equals(x_sLv) || "10".Equals(x_sLv) || "4".Equals(x_sLv)))
                _sQuery += " AND (IMEI_Stock.StaffNo='" + x_sUid + "' OR IMEI_Stock.StaffNo='' OR IMEI_Stock.StaffNo is null) ";
            //_sQuery += " AND IMEI_Stock.ReferenceNo is not null AND (SUNDAY_form.Cancelled ='N' or SUNDAY_form.Cancelled is null) and IMEI_Stock.DUMMY4 is not null ORDER BY IMEI_Stock.DUMMY4  ";
            _sQuery += " AND IMEI_Stock.ReferenceNo is not null and IMEI_Stock.DUMMY4 is not null ORDER BY IMEI_Stock.DUMMY4  ";
            global::System.Data.Odbc.OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_sQuery);

            ArrayList _oRecordIDList = new ArrayList();

            int i = 1;
            while (_oDr.Read())
            {
                int _iRecordID;
                if (int.TryParse(Func.FR(_oDr["DUMMY4"]), out _iRecordID))
                {
                    bool _bFlag = true;
                    string _sCancel = Func.FR(_oDr["Cancelled"]).Trim();
                    if (_sCancel.ToUpper().Equals("Y"))
                    {
                        string _sOrder_id = Func.IDSubtract100000(_iRecordID);
                        string _sEdf_no = string.Empty;
                        string _sImei_no = string.Empty;
                        SqlDataReader _oRDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT edf_no,Imei_no FROM MobileRetentionOrder WHERE active=1 AND order_id='" + _sOrder_id + "'");
                        if (_oRDr.Read())
                        {
                            _sEdf_no = Func.FR(_oRDr["edf_no"]).Trim().ToUpper();
                            _sImei_no = Func.FR(_oRDr["Imei_no"]).Trim().ToUpper();
                            if (_sEdf_no.Equals(string.Empty) && _sImei_no.Equals("AO"))
                            {
                                _bFlag = true;
                            }
                            else
                            {
                                _bFlag = false;
                            }
                        }
                        else
                        {
                            _bFlag = false;
                        }
                        _oRDr.Close();
                        _oRDr.Dispose();
                    }


                    if (!_oAvailableRefList.Contains(Func.FR(_oDr["DUMMY4"]).ToString().Trim()) && _bFlag)
                    {
                        if (Func.FR(_oDr["DUMMY4"]).ToString().Trim() == "478333")
                        {
                            string _sDUMMY4 = Func.FR(_oDr["DUMMY4"]).ToString().Trim();
                        }

                        _oAvailableRefList.Add(Func.FR(_oDr["DUMMY4"]).ToString().Trim());

                        int _iRecord_id = 0;
                        int _iOrder_id = 0;
                        if (int.TryParse(Func.FR(_oDr["DUMMY4"]).ToString(), out _iRecord_id))
                        {
                            _iOrder_id = _iRecord_id - 100000;
                        }

                        MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(SYSConn<MSSQLConnect>.Connect(), _iOrder_id);

                        n_iAo_count = 0;
                        n_iAo_red = 0;
                        n_iAo_yellow = 0;
                        n_iAwait_count = 0;

                        #region Old Code
                        //using an array to save sku value if sku is a new value

                        #endregion

                        _sQuery = "SELECT datediff(d,getdate(),d_date) as date_diff,hs_model,d_date,staff_name,salesmancode,mrt_no,log_date FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder with (nolock) where active=1 and order_id='" + Func.IDSubtract100000(Convert.ToInt32(_oDr["DUMMY4"].ToString())) + "' AND hs_model<>'' AND hs_model is not null and imei_no is not null and imei_no<>'' and (imei_no='AO' or imei_no='AWAIT' or imei_no='Await')";
                        global::System.Data.SqlClient.SqlDataReader _oDr3 = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                        if (_oDr3.Read())
                        {
                            n_bRWLHaveRecord = true;
                            n_sAo_staff_name = Func.FR(_oDr3[MobileRetentionOrder.Para.staff_name]).ToString();
                            n_sAo_sc = Func.FR(_oDr3[MobileRetentionOrder.Para.salesmancode]).ToString();
                            n_sAo_hs_model = Func.FR(_oDr3[MobileRetentionOrder.Para.hs_model]).ToString();
                            n_sAo_mrt_no = Func.FR(_oDr3[MobileRetentionOrder.Para.mrt_no]).ToString();
                            n_sAo_d_date = Func.FR(_oDr3[MobileRetentionOrder.Para.d_date]).ToString();
                            int _iDate_diff = 0;

                            string _sDate_diff = Func.FR(_oDr3["date_diff"]).Trim();
                            if (Int32.TryParse(_sDate_diff, out _iDate_diff)) { }
                            if (_iDate_diff <= 0)
                                n_iAo_red = 1;
                            else
                            {
                                n_iAo_red = 0;
                                if (_iDate_diff == 1)
                                    n_iAo_yellow = 1;
                                else
                                    n_iAo_yellow = 0;
                            }
                            for (int j = 0; j <= _oAvailableRefList.Count - 1; j++)
                            {
                                if (_oAvailableRefList[j].ToString().Equals(Func.IDSubtract100000(Convert.ToInt32(_oDr["DUMMY4"].ToString()))))
                                {
                                    if (_oQValueList != null)
                                    {
                                        if (_oQValueList.Count > j)
                                            n_iAo_count = (int)_oQValueList[j];
                                    }
                                }
                            }
                        }
                        else
                        {
                            n_bRWLHaveRecord = false;
                            n_sAo_staff_name = string.Empty;
                            n_sAo_sc = string.Empty;
                            n_sAo_hs_model = string.Empty;
                            n_sAo_mrt_no = string.Empty;
                            n_sAo_d_date = string.Empty;
                            n_iAo_red = 0;
                            n_iAo_yellow = 0;
                        }

                        if ((!"10".Equals(x_sLv) || !"4".Equals(x_sLv) || ("10".Equals(x_sLv) || "4".Equals(x_sLv)) && n_oSalesmancodeList.Contains(n_sAo_sc)) && n_bRWLHaveRecord)
                        {
                            _oWr.Add("<tr>");
                            string _sClass = string.Empty;
                            if ((1).Equals(n_iAo_red))
                                _sClass = "row_red";
                            else if ((1).Equals(n_iAo_yellow))
                                _sClass = "row_yellow";
                            else
                                _sClass = "row2";

                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + i.ToString() + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\"><a href=\"SearchRetentionOrderViewDetail.aspx?order_id=" + Func.FR(_oDr["DUMMY4"]).ToString() + "\">" + Func.FR(_oDr["DUMMY4"]).ToString() + "</a></span></td>");


                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["Kit_Code"]).ToString() + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + n_sAo_hs_model + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["StaffNo"]).ToString() + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + n_sAo_staff_name + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + n_sAo_sc + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + n_sAo_mrt_no + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + ((_oMobileRetentionOrder.GetLog_date() != null) ? ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("MM/dd/yyyy") : string.Empty) + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + ((_oMobileRetentionOrder.GetD_date() != null) ? ((DateTime)_oMobileRetentionOrder.GetD_date()).ToString("MM/dd/yyyy") : string.Empty) + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">" + Func.FR(_oDr["Status"]).ToString() + "</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">");
                            if ("STOCK".Equals(Func.FR(_oDr["Status"]).ToString()))
                            {
                                _oWr.Add("0");
                            }
                            else
                            {
                                _oWr.Add(n_iAo_count.ToString());
                            }
                            _oWr.Add("</span></td>");
                            _oWr.Add("<td height=\"0\" class=\"" + _sClass + "\"><span class=\"gensmall\" style=\"font-size:7pt\">");



                            if ("STOCK".Equals(Func.FR(_oDr["Status"]).ToString()) && (1).Equals(n_iAo_red))
                                _oWr.Add("<a href=\"PreviousOrderModify.aspx?&re_confirm=TRUE&order_id=" + Func.FR(_oDr["DUMMY4"]).ToString() + "\">Re-confirm delivery date</a>");
                            else if ("STOCK".Equals(Func.FR(_oDr["Status"]).ToString()))
                            {
                                _oWr.Add("System Processing");
                                _oWr.Add("[<a href=\"PreviousOrderModify.aspx?&re_confirm=TRUE&order_id=" + Func.FR(_oDr["DUMMY4"]).ToString() + "\">Re-confirm delivery date</a>]");
                            }
                            _oWr.Add("</span></td>");
                            _oWr.Add("</tr>");
                            i += 1;
                        }

                        _oDr3.Close();
                        _oDr3.Dispose();
                    }
                }//Convert Func.FR(_oDr["DUMMY4"]) to _iRecordID
            }//while
            _oDr.Close();
            _oDr.Dispose();
            return _oWr;
        }

        public string GetLog_date(int x_iOrder_id)
        {
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(GetDB(), x_iOrder_id);
            if (_oMobileRetentionOrder.GetFound())
            {
                if (_oMobileRetentionOrder.GetLog_date() != null)
                {
                    return ((DateTime)_oMobileRetentionOrder.GetLog_date()).ToString("MM/dd/yyyy");
                }
            }
            return string.Empty;
        }

        public MobileRetentionOrder GetOrder(int x_iOrder_id)
        {
            MobileRetentionOrder _oMobileRetentionOrder = new MobileRetentionOrder(GetDB(), x_iOrder_id);
            if (_oMobileRetentionOrder.GetFound())
            {
                return _oMobileRetentionOrder;
            }
            return new MobileRetentionOrder();
        }

        #endregion

        protected bool CheckWebLogHaveIMEI(int x_iOrder_id)
        {
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT imei_no FROM MobileRetentionOrder WHERE (imei_no<>'AO' and imei_no<>'AWAIT' and imei_no is not null and imei_no<>'') AND active=1 AND order_id='" + x_iOrder_id.ToString() + "'");
            if (_oDr.Read())
            {
                string _sIMEI = Func.FR(_oDr["imei_no"]).Trim().ToUpper();
                if (!_sIMEI.Equals("AO") && _sIMEI.Equals("AWAIT") && _sIMEI != string.Empty)
                {
                    _oDr.Close();
                    _oDr.Dispose();
                    return true;
                }
            }
            _oDr.Close();
            _oDr.Dispose();
            return false;
        }

        #region GetDB
        protected ODBCConnect GetORDB()
        {

            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }

        protected MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        protected string n_sAo_d_date = string.Empty;
        #region m_sAo_d_date
        protected string m_sAo_d_date
        {
            get
            {
                return this.n_sAo_d_date;
            }
            set
            {
                this.n_sAo_d_date = value;
            }
        }
        #endregion m_sAo_d_date


        protected int n_iAo_count = -1;
        #region m_iAo_count
        protected int m_iAo_count
        {
            get
            {
                return this.n_iAo_count;
            }
            set
            {
                this.n_iAo_count = value;
            }
        }
        #endregion m_iAo_count


        protected global::System.Collections.Generic.List<string> n_oSalesmancodeList1 = new global::System.Collections.Generic.List<string>();
        #region m_oSalesmancodeList1
        protected global::System.Collections.Generic.List<string> m_oSalesmancodeList1
        {
            get
            {
                return this.n_oSalesmancodeList1;
            }
            set
            {
                this.n_oSalesmancodeList1 = value;
            }
        }
        #endregion m_oSalesmancodeList1


        protected global::System.Collections.Generic.List<string> n_oSalesmancodeList = new global::System.Collections.Generic.List<string>();
        #region m_oSalesmancodeList
        protected global::System.Collections.Generic.List<string> m_oSalesmancodeList
        {
            get
            {
                return this.n_oSalesmancodeList;
            }
            set
            {
                this.n_oSalesmancodeList = value;
            }
        }
        #endregion m_oSalesmancodeList


        protected bool n_bRWLHaveRecord = false;
        #region RWLHaveRecord
        protected bool m_bRWLHaveRecord
        {
            get
            {
                return this.n_bRWLHaveRecord;
            }
            set
            {
                this.n_bRWLHaveRecord = value;
            }
        }
        #endregion

        protected int n_iAwait_count = -1;
        #region m_iAwait_count
        protected int m_iAwait_count
        {
            get
            {
                return this.n_iAwait_count;
            }
            set
            {
                this.n_iAwait_count = value;
            }
        }
        #endregion m_iAwait_count


        protected int n_iAo_red = -1;
        #region m_iAo_red
        protected int m_iAo_red
        {
            get
            {
                return this.n_iAo_red;
            }
            set
            {
                this.n_iAo_red = value;
            }
        }
        #endregion m_iAo_red


        protected string n_sAo_staff_name = string.Empty;
        #region m_sAo_staff_name
        protected string m_sAo_staff_name
        {
            get
            {
                return this.n_sAo_staff_name;
            }
            set
            {
                this.n_sAo_staff_name = value;
            }
        }
        #endregion m_sAo_staff_name


        protected string n_sAo_mrt_no = string.Empty;
        #region m_sAo_mrt_no
        protected string m_sAo_mrt_no
        {
            get
            {
                return this.n_sAo_mrt_no;
            }
            set
            {
                this.n_sAo_mrt_no = value;
            }
        }
        #endregion m_sAo_mrt_no


        protected string n_sAo_hs_model = string.Empty;
        #region m_sAo_hs_model
        protected string m_sAo_hs_model
        {
            get
            {
                return this.n_sAo_hs_model;
            }
            set
            {
                this.n_sAo_hs_model = value;
            }
        }
        #endregion m_sAo_hs_model


        protected int n_iAo_yellow = -1;
        #region m_iAo_yellow
        protected int m_iAo_yellow
        {
            get
            {
                return this.n_iAo_yellow;
            }
            set
            {
                this.n_iAo_yellow = value;
            }
        }
        #endregion m_iAo_yellow


        protected string n_sAo_sc = string.Empty;
        #region m_sAo_sc
        protected string m_sAo_sc
        {
            get
            {
                return this.n_sAo_sc;
            }
            set
            {
                this.n_sAo_sc = value;
            }
        }
        #endregion m_sAo_sc


        #region Constructor & Destructor
        public EDFAOControler() { }

        public EDFAOControler(string x_sAo_d_date, int x_iAo_count, global::System.Collections.Generic.List<string> x_oSalesmancodeList1, global::System.Collections.Generic.List<string> x_oSalesmancodeList, int x_iAwait_count, int x_iAo_red, string x_sAo_staff_name, string x_sAo_mrt_no, string x_sAo_hs_model, int x_iAo_yellow, string x_sAo_sc)
        {
            m_sAo_d_date = x_sAo_d_date;
            m_iAo_count = x_iAo_count;
            m_oSalesmancodeList1 = x_oSalesmancodeList1;
            m_oSalesmancodeList = x_oSalesmancodeList;
            m_iAwait_count = x_iAwait_count;
            m_iAo_red = x_iAo_red;
            m_sAo_staff_name = x_sAo_staff_name;
            m_sAo_mrt_no = x_sAo_mrt_no;
            m_sAo_hs_model = x_sAo_hs_model;
            m_iAo_yellow = x_iAo_yellow;
            m_sAo_sc = x_sAo_sc;
        }

        ~EDFAOControler() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetAo_d_date() { return this.m_sAo_d_date; }
        public int GetAo_count() { return this.m_iAo_count; }
        public global::System.Collections.Generic.List<string> GetSalesmancodeList1() { return this.m_oSalesmancodeList1; }
        public global::System.Collections.Generic.List<string> GetSalesmancodeList() { return this.m_oSalesmancodeList; }
        public int GetAwait_count() { return this.m_iAwait_count; }
        public int GetAo_red() { return this.m_iAo_red; }
        public string GetAo_staff_name() { return this.m_sAo_staff_name; }
        public string GetAo_mrt_no() { return this.m_sAo_mrt_no; }
        public string GetAo_hs_model() { return this.m_sAo_hs_model; }
        public int GetAo_yellow() { return this.m_iAo_yellow; }
        public string GetAo_sc() { return this.m_sAo_sc; }
        public bool GetRWLHaveRecord() { return this.m_bRWLHaveRecord; }

        public bool SetRWLHaveRecord(bool value)
        {
            this.n_bRWLHaveRecord = value;
            return true;
        }
        public bool SetAo_d_date(string value)
        {
            this.m_sAo_d_date = value;
            return true;
        }
        public bool SetAo_count(int value)
        {
            this.m_iAo_count = value;
            return true;
        }
        public bool SetSalesmancodeList1(List<string> value)
        {
            this.m_oSalesmancodeList1 = value;
            return true;
        }
        public bool SetSalesmancodeList(List<string> value)
        {
            this.m_oSalesmancodeList = value;
            return true;
        }
        public bool SetAwait_count(int value)
        {
            this.m_iAwait_count = value;
            return true;
        }
        public bool SetAo_red(int value)
        {
            this.m_iAo_red = value;
            return true;
        }
        public bool SetAo_staff_name(string value)
        {
            this.m_sAo_staff_name = value;
            return true;
        }
        public bool SetAo_mrt_no(string value)
        {
            this.m_sAo_mrt_no = value;
            return true;
        }
        public bool SetAo_hs_model(string value)
        {
            this.m_sAo_hs_model = value;
            return true;
        }
        public bool SetAo_yellow(int value)
        {
            this.m_iAo_yellow = value;
            return true;
        }
        public bool SetAo_sc(string value)
        {
            this.m_sAo_sc = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(EDFAOControler x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sAo_d_date.Equals(x_oObj.m_sAo_d_date)) { return false; }
            if (!this.m_iAo_count.Equals(x_oObj.m_iAo_count)) { return false; }
            if (!this.m_oSalesmancodeList1.Equals(x_oObj.m_oSalesmancodeList1)) { return false; }
            if (!this.m_oSalesmancodeList.Equals(x_oObj.m_oSalesmancodeList)) { return false; }
            if (!this.m_iAwait_count.Equals(x_oObj.m_iAwait_count)) { return false; }
            if (!this.m_iAo_red.Equals(x_oObj.m_iAo_red)) { return false; }
            if (!this.m_sAo_staff_name.Equals(x_oObj.m_sAo_staff_name)) { return false; }
            if (!this.m_sAo_mrt_no.Equals(x_oObj.m_sAo_mrt_no)) { return false; }
            if (!this.m_sAo_hs_model.Equals(x_oObj.m_sAo_hs_model)) { return false; }
            if (!this.m_iAo_yellow.Equals(x_oObj.m_iAo_yellow)) { return false; }
            if (!this.m_sAo_sc.Equals(x_oObj.m_sAo_sc)) { return false; }
            if (!this.m_bRWLHaveRecord.Equals(x_oObj.m_bRWLHaveRecord)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_sAo_d_date = string.Empty;
            this.m_iAo_count = -1;
            this.m_oSalesmancodeList1 = new global::System.Collections.Generic.List<string>();
            this.m_oSalesmancodeList = new global::System.Collections.Generic.List<string>();
            this.m_iAwait_count = -1;
            this.m_iAo_red = -1;
            this.m_sAo_staff_name = string.Empty;
            this.m_sAo_mrt_no = string.Empty;
            this.m_sAo_hs_model = string.Empty;
            this.m_iAo_yellow = -1;
            this.m_sAo_sc = string.Empty;
            this.m_bRWLHaveRecord = false;
        }
        #endregion Release


        #region DeepClone
        public EDFAOControler DeepClone()
        {
            EDFAOControler EDFAOControler_Clone = new EDFAOControler();
            EDFAOControler_Clone.SetAo_d_date(this.m_sAo_d_date);
            EDFAOControler_Clone.SetAo_count(this.m_iAo_count);
            EDFAOControler_Clone.SetSalesmancodeList1(this.m_oSalesmancodeList1);
            EDFAOControler_Clone.SetSalesmancodeList(this.m_oSalesmancodeList);
            EDFAOControler_Clone.SetAwait_count(this.m_iAwait_count);
            EDFAOControler_Clone.SetAo_red(this.m_iAo_red);
            EDFAOControler_Clone.SetAo_staff_name(this.m_sAo_staff_name);
            EDFAOControler_Clone.SetAo_mrt_no(this.m_sAo_mrt_no);
            EDFAOControler_Clone.SetAo_hs_model(this.m_sAo_hs_model);
            EDFAOControler_Clone.SetAo_yellow(this.m_iAo_yellow);
            EDFAOControler_Clone.SetAo_sc(this.m_sAo_sc);
            EDFAOControler_Clone.SetRWLHaveRecord(this.m_bRWLHaveRecord);
            return EDFAOControler_Clone;
        }
        #endregion Clone

    }
}
