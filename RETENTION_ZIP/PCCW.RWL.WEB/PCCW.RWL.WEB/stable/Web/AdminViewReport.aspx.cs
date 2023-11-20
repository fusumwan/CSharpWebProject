using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;
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


public partial class AdminViewReport : NEURON.WEB.UI.BasePage
{
    #region Logger Setup
    protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    #endregion
    BusinessVasDescriptionRepositoryBase _oBusinessVasDescriptionRepositoryBase = BusinessVasDescriptionRepositoryBase.Instance();
    ProfileTeamDetailRepositoryBase _oProfileTeamDetailRepositoryBase = ProfileTeamDetailRepositoryBase.Instance();
    MobileRetentionOrderRepositoryBase n_oMobileRetentionOrderRepositoryBase = MobileRetentionOrderRepositoryBase.Instance();
    Hashtable n_oVim_vas_desc = new Hashtable();
    Hashtable n_oMcam_vas_desc = new Hashtable();
    Hashtable n_oNet_vas_desc = new Hashtable();
    Hashtable n_oNow_hd_vas_desc = new Hashtable();
    Hashtable n_oGprs_vas_desc = new Hashtable();
    Hashtable n_oSms_vas_desc = new Hashtable();
    Hashtable n_oVm_vas_desc = new Hashtable();
    Dictionary<string, string> n_oVasNameData;
    Dictionary<string, List<string>> n_oFieldTitleData;
    VasCreateHolderControl n_oVasCreateHolderControl = VasCreateHolderControl.Instance();
    MobileOrderReportStyleEntity[] _oMobileOrderReportStyleArr;

    protected int _iId = 0;
    protected int _iReportId = 0;

    protected void Page_Load(object sender, EventArgs e)
    {

        //WebFunc.PrivilegeCheck(this.Page);
        //_oMobileOrderReportStyle = new MobileOrderReportStyle(WebFunc.qsFormat.ToString(), WebFunc.qsReport_type.ToString(), WebFunc.qsOrder_status);

        #region backup
        /*
        MobileOrderReportStyle _oMobileOrderReportStyle = new MobileOrderReportStyle(SYSConn<MSSQLConnect>.Connect(), 1);
        if (_oMobileOrderReportStyle.GetFound())
        {
            _oMobileOrderReportStyle.report_id= 1;
            _oMobileOrderReportStyle.Save();
        }*/
        #endregion

        //_iReportId = GetReportID(WebFunc.qsFormat.ToString(), WebFunc.qsReport_type.ToString(), WebFunc.qsOrder_status.ToString());

        _oMobileOrderReportStyleArr = GetMobileOrderReportStyleArr(WebFunc.qsFormat.ToString(), WebFunc.qsReport_type.ToString());
        MobileOrderReportStyle _oMobileOrderReportStyle = (MobileOrderReportStyle)_oMobileOrderReportStyleArr[0];

        _iReportId = GetReportID(WebFunc.qsFormat.ToString(), WebFunc.qsReport_type.ToString(), WebFunc.qsOrder_status.ToString());

        n_oVasNameData = GetVasNameList();
        n_oFieldTitleData = GetFieldTitleList(_iReportId);
        
    }

    protected MobileOrderReportStyleEntity[] GetMobileOrderReportStyleArr(string x_sFormat, string x_sReport_type)
    {
        if(string.IsNullOrEmpty(x_sFormat)){ return null;}
        if(string.IsNullOrEmpty(x_sReport_type)) { return null;}

        MobileOrderReportStyleEntity[] MobileOrderReportStyleArr=
            MobileOrderReportStyleRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(),
            1, "format='" + x_sFormat + "' and type='" + x_sReport_type + "'", null, "status DESC");
        
        if (MobileOrderReportStyleArr != null)
        {
            return MobileOrderReportStyleArr;
        }
        return null;
    }

    protected void ExportExcel()
    {
        WebFunc.ExportExcel(this.Page, "RetentionOrderExcelResult.xls");
    }

    // Generate the report content data
    protected void SearchReportShow()
    {
        
        // SQL of report columns in order
        StringBuilder _oFieldNames = new StringBuilder();
        //int _sReport_id = GetReportID(WebFunc.qsFormat.ToString(), WebFunc.qsReport_type.ToString(), WebFunc.qsOrder_status);
        int _iReport_id = _iReportId;
        SqlDataReader _oFieldDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT field_content,field_order,field_content_order,field_content_name FROM MobileOrderReportField WHERE report_id='" + _iReport_id + "' AND active=1 ORDER BY field_order ASC, field_content_order ASC");
        int _iPrevious_order = 0;
        int _iOrder = 0;
        while (_oFieldDr.Read())
        {
            _iOrder = (int)_oFieldDr["field_order"];

            if (_iPrevious_order != 0)
            {
                _oFieldNames.Append(",");
            }

            _oFieldNames.Append(Func.FR(_oFieldDr["field_content"]));
            _iPrevious_order = _iOrder;
        }
        _oFieldDr.Close();
        _oFieldDr.Dispose();

        // SQL of VAS columns
        StringBuilder _oVasHeader = new StringBuilder();
        StringBuilder _oVasQuery = new StringBuilder();
        foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
        {
            if (_oVasQuery.ToString() != string.Empty) { _oVasQuery.Append(","); }
            string _sVas_Field = _oItem.Key.ToString();
            string _sVas_Name = _oItem.Value.ToString();
            if (!_sVas_Name.Trim().Equals(string.Empty))
            {
                _oVasQuery.Append("'" + _sVas_Field + "'=");
                _oVasQuery.Append(" (SELECT TOP 1 '" + _sVas_Field + "'= CASE ");
                _oVasQuery.Append(" WHEN v.vas_value is not null AND v.fee is not null THEN v.vas_value +','+v2.vas_desc ");
                _oVasQuery.Append(" WHEN v.vas_value is not null THEN v.vas_value ");
                _oVasQuery.Append(" ELSE '' ");
                _oVasQuery.Append(" END FROM MobileOrderVas v with (nolock)  LEFT JOIN BusinessVasDescription v2 with (nolock) ON v.multi_id=v2.id WHERE v.vas_field='" + _sVas_Field + "' AND v.order_id=a.order_id ) ");
            }
        }

        // SQL of report content data
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT ");
        _oQuery.Append(_oFieldNames.ToString());
        _oQuery.Append("," +  _oVasQuery.ToString() + " FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder a with (nolock), " + Configurator.MSSQLTablePrefix + "MobileOrderReport b with (nolock) where a.order_id=b.order_id and b.active=1");

        if (Func.RB(WebFunc.qsOrder_id) && (Func.RB(WebFunc.qsOrder_id2) && !WebFunc.qsOrder_id2.Equals(string.Empty)))
            _oQuery.Append(" and a.order_id>='" + Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() + "'");
        else if (Func.RB(WebFunc.qsOrder_id))
            _oQuery.Append(" and a.order_id='" + Func.IDSubtract100000(WebFunc.qsOrder_id).ToString() + "'");

        if (Func.RB(WebFunc.qsOrder_id2))
            _oQuery.Append(" and a.order_id<='" + Func.IDSubtract100000(Convert.ToInt32(WebFunc.qsOrder_id2)).ToString() + "'");

        if (Func.RB(WebFunc.qsEmail_date))
            _oQuery.Append(" and b.email_date>='" + ((DateTime)WebFunc.qsEmail_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsEmail_date2))
            _oQuery.Append(" and b.email_date<='" + ((DateTime)WebFunc.qsEmail_date2).ToString("yyyyMMdd") + " 23:59'");

        if (Func.RB(WebFunc.qsLog_date))
            _oQuery.Append(" and a.log_date>='" + ((DateTime)WebFunc.qsLog_date).ToString("yyyyMMdd") + " 00:00'");

        if (Func.RB(WebFunc.qsLog_date2))
            _oQuery.Append(" and a.log_date<='" + ((DateTime)WebFunc.qsLog_date2).ToString("yyyyMMdd") + " 23:59'");

        if (Func.RB(WebFunc.qsMrt_no))
            _oQuery.Append(" and a.mrt_no='" + WebFunc.qsMrt_no.ToString() + "'");

        if (Func.RB(WebFunc.qsReport_type))
            _oQuery.Append(" and b.report_type='" + WebFunc.qsReport_type.ToString() + "'");
        else
            _oQuery.Append(" and b.report_type<>'rwl_cust'");


        if (Func.RB(WebFunc.qsOrder_status))
        {
            if ("no_follow".Equals(WebFunc.qsOrder_status))
                _oQuery.Append(" and (b.order_status='' or b.order_status is null)");
            else if ("no_follow_t4".Equals(WebFunc.qsOrder_status))
                _oQuery.Append(" and (b.order_status='' or b.order_status is null) and DATEDIFF(d,b.email_date,getdate())>4 ");
            else
                _oQuery.Append(" and b.order_status='" + WebFunc.qsOrder_status.ToString() + "'");
        }

        if (Func.RB(WebFunc.qsFallout_main_category))
            _oQuery.Append(" AND b.fallout_main_category='" + WebFunc.qsFallout_main_category.ToString() + "' ");

        if (Func.RB(WebFunc.qsFallout_reason))
            _oQuery.Append(" AND b.fallout_reason='" + WebFunc.qsFallout_reason.ToString() + "' ");


        if (!WebFunc.qsGo_wireless.Equals("ALL"))
        {
            if (WebFunc.qsGo_wireless.Equals("YES"))
                _oQuery.Append(" AND (a.go_wireless is not null AND a.go_wireless <>'NO' AND  a.go_wireless <>'') ");
            else if (WebFunc.qsGo_wireless.Equals("NO"))
                _oQuery.Append(" AND (a.go_wireless is null or a.go_wireless ='NO' or a.go_wireless='') ");
        }
        _oQuery.Append(" and a.program<>'MOBILE LITE (SIM ONLY)' and a.program<>'MOBILE LITE (HS OFFER)'");
        _oQuery.Append(" order by a.order_id");

        // Generate the report content in HTML format
        int _iViewid = 0;
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            _iViewid += 1;
            StringBuilder _oReportWrite = new StringBuilder();
            _oReportWrite.AppendLine("<tr>");
            _oReportWrite.AppendLine("<td nowrap >" + _iViewid.ToString() + "</td>");
            
            // non-VAS data
            foreach (KeyValuePair<string, List<string>> _oItem in n_oFieldTitleData)
            {
                string _sField_Title = _oItem.Key.ToString();
                List<string> _lField_Content = _oItem.Value;
                if (!_sField_Title.Trim().Equals(string.Empty))
                {
                    _oReportWrite.Append("<td nowrap style='mso-number-format:\\@'>");
                    int _iCount = 0;
                    foreach (string _sField_Content in _lField_Content)
                    {
                        if (_iCount != 0) _oReportWrite.Append(" ");
                        _oReportWrite.Append(Func.FR(_oDr[_sField_Content]));
                        _iCount++;
                    }
                    _oReportWrite.Append("</td>\n");
                }
            }

            // VAS data
            foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
            {
                string _sVas_Field = _oItem.Key.ToString();
                string _sVas_Name = _oItem.Value.ToString();
                if (!_sVas_Name.Trim().Equals(string.Empty))
                    _oReportWrite.AppendLine("<td nowrap=\"nowrap\" class=\"row2\">" + Func.FR(_oDr[_sVas_Field]) + "</td>\n");
            }

            _oReportWrite.AppendLine("</tr>");
            Response.Write(_oReportWrite.ToString());
        }
        _oDr.Close();
        _oDr.Dispose();
         
    }

    // Get the Report ID by format, type, status
    protected int GetReportID(string x_sFormat, string x_sType, string x_sStatus)
    {
        #region backup
        /*
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT report_id,status FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReportStyle ");
        _oQuery.Append(" WHERE format='" + x_sFormat + "' ");
        _oQuery.Append(" AND active=1 ");

        if (string.IsNullOrEmpty(x_sType)){
            _oQuery.Append(" AND type='all' ");
        }else{
            _oQuery.Append(" AND type='" + x_sType + "' ");
        }
        _oQuery.Append(" ORDER BY status DESC ");

        int returnValue = 0;

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read() && returnValue==0)
        {
            // If there is specified report for particular status
            if (Func.FR(_oDr["status"]) == x_sStatus)
            {
                returnValue = (int)_oDr["report_id"];
            }
            // Else. Order by DESC, so the last is NullOrEmpty which is the general report
            else if(string.IsNullOrEmpty(Func.FR(_oDr["status"]))){
                returnValue = (int)_oDr["report_id"];
            }
        }
        _oDr.Close();
        _oDr.Dispose();
         */
        #endregion

        String _sWhere = "format='" + x_sFormat + "' AND active=1 ";
        if (string.IsNullOrEmpty(x_sType))
        {
            _sWhere +=" AND type='all' ";
        }
        else
        {
            _sWhere +=" AND type='" + x_sType + "' ";
        }

        MobileOrderReportStyleEntity[] MobileOrderReportStyleArr =
            MobileOrderReportStyleRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(),
            1, _sWhere, null, "status DESC");

        int returnValue = 0;
        int i = 0;
        while (i < MobileOrderReportStyleArr.Length && returnValue == 0)
        {
            // If there is specified report for particular status
            if (Func.FR(MobileOrderReportStyleArr[0].status) == x_sStatus)
            {
                returnValue = (int)MobileOrderReportStyleArr[0].report_id;
            }
            // Else. Order by DESC, so the last is NullOrEmpty which is the general report
            else if (string.IsNullOrEmpty(MobileOrderReportStyleArr[0].status))
            {
                returnValue = (int)MobileOrderReportStyleArr[0].report_id;
            }
            i++;
        }

        // report #1 is set to general report, 
        // if no report is match, it will use report #1
        return returnValue == 0 ? 1 : returnValue;
    }

    // Check should VAS fields needed to show
    // it should be by id, not by report_id
    protected bool hasVASFields(int x_iReportID)
    {
        #region backup
        /*
        StringBuilder _oQuery = new StringBuilder();
        _oQuery.Append("SELECT vas FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReportStyle ");
        _oQuery.Append(" WHERE report ");
        _oQuery.Append(" AND active=1 ");

        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
        while (_oDr.Read())
        {
            if ((int)_oDr["vas"] == 1)
            {
                _bHasVASFields = true;
            }
        }
        _oDr.Close();
        _oDr.Dispose();
        return _bHasVASFields;
        */
        #endregion

        MobileOrderReportStyleEntity[] MobileOrderReportStyleArr =
            MobileOrderReportStyleRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(),
            1, "report_id=" + x_iReportID + "AND active=1", null, "vas DESC");

        if (MobileOrderReportStyleArr[0].vas_show == false)
        {
            return false;
        }
        else
        {
            return true;
        }
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
        _oDB.SetConnStr(Configurator.DBName.ORADNS + ((!"".Equals(Configurator.IsUat())) ? "2" : string.Empty));
        return _oDB;
    }
    #endregion

    #region HeaderShow
    protected void HeaderShow()
    {
        FieldHeaderShow();
        if (hasVASFields(_iReportId))
        {
            VasHeader();
        }
    }
    #endregion

    // Generate the header of non-VAS column
    #region FieldHeaderShow
    protected void FieldHeaderShow()
    {
        StringBuilder _oFieldHeader = new StringBuilder();

        foreach (KeyValuePair<string, List<string>> _oItem in n_oFieldTitleData)
        {
            string _sField_Title = _oItem.Key.ToString();
            if (!_sField_Title.Trim().Equals(string.Empty))
                _oFieldHeader.Append("<td class=\"row1\">" + _sField_Title + "</td>");
        }
        Response.Write(_oFieldHeader.ToString());
    }
    #endregion FieldHeaderShow

    // Dictionary of Field Header and fields in database (non-VAS)
    protected static Dictionary<string, List<string>> GetFieldTitleList(int x_iReport_id)
    {
        Dictionary<string, List<string>> _oFieldTitleData = new Dictionary<string, List<string>>();

        #region backup
        /*
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT field_title,field_content_name,field_order,field_content_order FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReportField WHERE report_id='1' AND active=1 ORDER BY field_order ASC, field_content_order ASC");
         */
        /*while (_oDr.Read())
        {
            string _sField_Title = Func.FR(_oDr["field_title"]).ToString().Trim();
            List<string> _lField_Content_Name = new List<string>();

            if (!_oFieldTitleData.ContainsKey(_sField_Title))
            {
                _lField_Content_Name.Add(Func.FR(_oDr["field_content_name"]).ToString().Trim());
                _oFieldTitleData.Add(_sField_Title, _lField_Content_Name);
            }
            else
            {
                _oFieldTitleData[_sField_Title].Add(Func.FR(_oDr["field_content_name"]).ToString().Trim());
            }
        }
        _oDr.Close();
        _oDr.Dispose();
        return _oFieldTitleData;
         */
#endregion
        
        MobileOrderReportFieldEntity[] _oMobileOrderReportFieldEntityArr = MobileOrderReportFieldBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "report_id='" + x_iReport_id.ToString() + "' AND active=1 ", null, "field_order ASC, field_content_order ASC");
        //_oMobileOrderReportFieldEntityArr[0].report_id = 1;
        //_oMobileOrderReportFieldEntityArr[0].Save();

        
        for (int i=0;i < _oMobileOrderReportFieldEntityArr.Length;i++)
        {
            string _sField_Title = Func.FR(_oMobileOrderReportFieldEntityArr[i].field_title).ToString().Trim();
            List<string> _lField_Content_Name = new List<string>();

            if (!_oFieldTitleData.ContainsKey(_sField_Title))
            {
                _lField_Content_Name.Add(Func.FR(_oMobileOrderReportFieldEntityArr[i].field_content_name).ToString().Trim());
                _oFieldTitleData.Add(_sField_Title, _lField_Content_Name);
            }
            else
            {
                _oFieldTitleData[_sField_Title].Add(Func.FR(_oMobileOrderReportFieldEntityArr[i].field_content_name).ToString().Trim());
            }
        }
        return _oFieldTitleData;
    }

    // VAS Column
    public void VasHeader()
    {
        List<string> _oList = new List<string>();
        IDSQuery _oDr = IDSQuery.CreateDsCriteria(n_oVasCreateHolderControl.GetDs(), BusinessVas.Para.TableName())
            .Add(DsExpression.Eq(BusinessVas.Para.active, 1));
        while (_oDr.Read())
        {
            string _sVas_name = _oDr[BusinessVas.Para.vas_name].ToString();
            if (!_oList.Contains(_sVas_name))
            {
                _oList.Add(_sVas_name);

                Response.Write("<td class=\"row1\">" + _sVas_name + "</td>");
            }
        }
        _oDr.Close();
    }

    // Generate the header of VAS column
    #region VasHeaderShow
    protected void VasHeaderShow()
    {
        StringBuilder _oVasHeader = new StringBuilder();
        StringBuilder _oVasQuery = new StringBuilder();

        foreach (KeyValuePair<string, string> _oItem in n_oVasNameData)
        {
            if (_oVasQuery.ToString() != string.Empty) { _oVasQuery.Append(","); }
            string _sVas_Field = _oItem.Key.ToString();
            string _sVas_Name = _oItem.Value.ToString();
            if (!_sVas_Name.Trim().Equals(string.Empty))
                _oVasHeader.Append("<td class=\"row1\">" + _sVas_Name + "</td>");
        }
        Response.Write(_oVasHeader.ToString());
    }
    #endregion

    protected static Dictionary<string, string> GetVasNameList()
    {
        Dictionary<string, string> _oVasNameData = new Dictionary<string, string>();
        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT DISTINCT vas_field,vas_name FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE active=1 ORDER BY vas_field");
        while (_oDr.Read())
        {
            string _sVas_Field = Func.FR(_oDr["vas_field"]).ToString().Trim();
            string _sVas_Name = Func.FR(_oDr["vas_name"]).ToString().Trim();
            if (!_oVasNameData.ContainsKey(_sVas_Field))
                _oVasNameData.Add(_sVas_Field, _sVas_Name);
        }
        _oDr.Close();
        _oDr.Dispose();
        return _oVasNameData;
    }

    protected void admin_view_rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (!e.Item.ItemIndex.Equals(-1))
        {
            int _iOrderID = e.Item.ItemIndex + 1;
            Literal _oViewid = (Literal)e.Item.FindControl("viewid");
            _oViewid.Text = _iOrderID.ToString();

            Literal _oMobileRetentionOrder_id = (Literal)e.Item.FindControl("MobileRetentionOrder_id");
            PlaceHolder _oVas_PlaceHolder = (PlaceHolder)e.Item.FindControl("vas_placeholder");
            StringBuilder _oPlace = new StringBuilder();
            if (_oMobileRetentionOrder_id != null && _oVas_PlaceHolder != null)
            {
                int _iOrder_id;
            }
            
            Literal _oAccept = (Literal)e.Item.FindControl("accept");
            if ("Y".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Accept Autoroll";
            else if ("reject".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "Reject Autoroll (change to FTG) ";
            else if ("no_comment".Equals(_oAccept.Text.ToLower()))
                _oAccept.Text = "No Comment";
        }
    }

    public bool bSpecialVas(string x_sVasField)
    {

        if (x_sVasField == "gprs_vas" ||
            x_sVasField == "vmin_vas" ||
            x_sVasField == "mcam_vas" ||
            x_sVasField == "net_vas" ||
            x_sVasField == "now_hd_vas" ||
            x_sVasField == "gprs_vas" ||
            x_sVasField == "sms_vas" ||
            x_sVasField == "vm_vas")
        {
            return true;
        }

        return false;
    }

    public string ShowSpecialVas(string x_sFee, string x_sVasField)
    {

        string _sResult = string.Empty;
        if (!"".Equals(x_sFee))
        {
            if (x_sFee.IndexOf(",") > -1)
            {
                string[] _oVal = x_sFee.Split((",")[0]);
                _sResult = _oVal[0];
                if (_oVal.Length > 1)
                {
                    if (!"".Equals(_oVal[1]))
                    {

                        switch (x_sFee)
                        {
                            case "net_vas":
                                if (n_oNet_vas_desc.Contains(_oVal[1]))
                                    _sResult += n_oNet_vas_desc[_oVal[1]].ToString();
                                break;
                            case "gprs_vas":
                                if (n_oGprs_vas_desc.Contains(_oVal[1]))
                                    _sResult += n_oGprs_vas_desc[_oVal[1]].ToString();
                                break;
                            case "vmin_vas":
                                if (n_oVim_vas_desc.Contains(_oVal[1]))
                                    _sResult += n_oVim_vas_desc[_oVal[1]].ToString();
                                break;
                            case "mcam_vas":
                                if (n_oMcam_vas_desc.Contains(_oVal[1]))
                                    _sResult += n_oMcam_vas_desc[_oVal[1]].ToString();
                                break;
                            case "now_hd_vas":
                                if (n_oNow_hd_vas_desc.Contains(_oVal[1]))
                                    _sResult += n_oNow_hd_vas_desc[_oVal[1]].ToString();
                                break;
                            case "sms_vas":
                                if (n_oSms_vas_desc.Contains(_oVal[1]))
                                    _sResult += n_oSms_vas_desc[_oVal[1]].ToString();
                                break;
                            case "vm_vas":
                                if (n_oVm_vas_desc.Contains(_oVal[1]))
                                    _sResult += n_oVm_vas_desc[_oVal[1]].ToString();
                                break;
                        }
                    }
                }
            }
        }
        return _sResult;
    }




    // MobileOrderReportStyle(string x_sFormat, string x_sType, string x_sStatus)
    /*
    public class MobileOrderReportStyle
    {
        #region Constructor
        private static MobileOrderReportStyle instance;
        protected string m_sFormat = string.Empty;
        protected string m_sType = string.Empty;
        protected string m_sStatus = string.Empty;

        protected int m_iReport_id = 0;
        protected bool m_bVas = true;
        protected int m_iId = 0;

        public MobileOrderReportStyle() { }

        public MobileOrderReportStyle(string x_sFormat, string x_sType, string x_sStatus)
        {
            m_sFormat = x_sFormat;
            m_sType = x_sType;
            m_sStatus = x_sStatus;
            findReport();
        }

        public static MobileOrderReportStyle Instance()
        {
            if (instance == null)
                instance = new MobileOrderReportStyle();
            return instance;
        }

        public static MobileOrderReportStyle Instance(string x_sFormat, string x_sType, string x_sStatus)
        {
            if (instance == null)
                instance = new MobileOrderReportStyle(x_sFormat, x_sType, x_sStatus);
            return instance;
        }

        ~MobileOrderReportStyle() { }
        #endregion

        #region Get_Set_Value
        public string GetFormat() { return this.m_sFormat; }
        public string GetType() { return this.m_sType; }
        public string GetStatus() { return this.m_sStatus; }
        public int GetReport_id() { return this.m_iReport_id; }
        public bool GetVas() { return this.m_bVas; }
        public int GetId() { return this.m_iId; }

        public bool SetFormat(string value)
        {
            this.m_sFormat = value;
            return true;
        }

        public bool SetType(string value)
        {
            this.m_sType = value;
            return true;
        }

        public bool SetStatus(string value)
        {
            this.m_sStatus = value;
            return true;
        }
        public bool SetReport_id(int value)
        {
            this.m_iReport_id = value;
            return true;
        }
        public bool SetVas(bool value)
        {
            this.m_bVas = value;
            return true;
        }
        public bool SetId(int value)
        {
            this.m_iId = value;
            return true;
        }
        #endregion

        // Check if Id is assigned or not
        public bool isAssignId()
        {
            return (GetId() == 0 ? false : true);
        }

        // Check should VAS fields needed to show
        public bool hasVASFields()
        {
            return GetVas();
        }

        // Find the matched report
        public void findReport()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT report_id,status FROM " + Configurator.MSSQLTablePrefix + "MobileOrderReportStyle ");
            _oQuery.Append(" WHERE format='" + GetFormat() + "' ");
            _oQuery.Append(" AND active=1 ");

            if (string.IsNullOrEmpty(GetType()))
            {
                _oQuery.Append(" AND type='all' ");
            }
            else
            {
                _oQuery.Append(" AND type='" + GetType() + "' ");
            }
            _oQuery.Append(" ORDER BY status DESC ");

            int returnValue = 0;
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            while (_oDr.Read() && returnValue == 0)
            {
                // If there is specified report for particular status
                if (Func.FR(_oDr["status"]) == GetStatus())
                {
                    returnValue = (int)_oDr["report_id"];
                }
                // Else. Order by DESC, so the last is NullOrEmpty which is the general report
                else if (string.IsNullOrEmpty(Func.FR(_oDr["status"])))
                {
                    returnValue = (int)_oDr["report_id"];
                }
            }
            _oDr.Close();
            _oDr.Dispose();

            // report #1 is set to general report, 
            // if no report is match, it will use report #1
            SetId(returnValue == 0 ? 1 : returnValue);
        }
    }
    */
}
