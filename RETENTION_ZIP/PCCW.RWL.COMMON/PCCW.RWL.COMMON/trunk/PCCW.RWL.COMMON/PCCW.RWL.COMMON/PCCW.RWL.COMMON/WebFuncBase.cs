using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
namespace PCCW.RWL.CORE.WEBFUNC
{
    public class ExcelFieldCharacter
    {
        public string ExcelField = string.Empty;
        public string DBField = string.Empty;
        public int DataSetPoint = -1;
    }

    public class WebFuncBase : System.Web.UI.Page
    {
        static public bool n_bUseDatetimePattern = true;
        public WebFuncBase() { }
        ~WebFuncBase() { }

        #region Export Excel
        public static void ExportExcel(Page x_oPage,string x_sFilename)
        {
            x_oPage.Response.Buffer = true;
            x_oPage.Response.AddHeader("content-disposition", "attachment; filename=" + x_sFilename);
            x_oPage.Response.ContentType = "application/vnd.ms-excel";
            x_oPage.Response.Flush();
        }
        #endregion

        #region Excel to DataSet
        public class EXCELVersion
        {
            public const string EXCEL2003 = "EXCEL2003";
            public const string EXCEL2007 = "EXCEL2007";
        }
        public static OleDbConnection GetExcelConn(string x_sPath, string x_sExcelVersion, bool x_bHDR)
        {
            string _sStrConn = string.Empty;
            switch (x_sExcelVersion.ToUpper())
            {
                case EXCELVersion.EXCEL2003:
                    _sStrConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + x_sPath + ";" + "Extended Properties=\"Excel 8.0;HDR=" + ((x_bHDR) ? "Yes" : "No") + ";IMEX=1\"";
                    break;
                case EXCELVersion.EXCEL2007:
                    _sStrConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + x_sPath + ";" + "Extended Properties=\"Excel 12.0 Xml;HDR=" + ((x_bHDR) ? "Yes" : "No") + ";IMEX=1\"";
                    break;
                default:
                    _sStrConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + x_sPath + ";" + "Extended Properties=\"Excel 8.0;HDR=" + ((x_bHDR) ? "Yes" : "No") + ";IMEX=1\"";
                    break;
            }
            OleDbConnection _oConn = new OleDbConnection(_sStrConn);
            return _oConn;
        }

        public static string ExcelSheetName(string x_sPath, string x_sExcelVersion)
        {

            OleDbConnection _oConn = GetExcelConn(x_sPath, x_sExcelVersion, true);
            try
            {
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                DataTable _oDataTable = _oConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (_oDataTable != null)
                {
                    return _oDataTable.Rows[0]["TABLE_NAME"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                _oConn.Close();
                _oConn.Dispose();
            }
            return string.Empty;
        }
        public static string ExcelSheetName(string x_sPath, string x_sExcelVersion, ref string x_sError)
        {
             OleDbConnection _oConn = null;
           
            try
            {
                _oConn = GetExcelConn(x_sPath, x_sExcelVersion, true);
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                DataTable _oDataTable = _oConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (_oDataTable != null)
                {
                    return _oDataTable.Rows[0]["TABLE_NAME"].ToString();
                }
            }
            catch(Exception exp)
            {
                x_sError=exp.ToString();
            }
            finally
            {
                if(_oConn!=null){
                    _oConn.Close();
                    _oConn.Dispose();
                }
            }
            return string.Empty;
        }

        public static DataSet ExcelToDS(string x_sPath, string x_sExcelVersion, string x_sSheet, bool x_bHDR)
        {
            return WebFuncBase.ExcelToDS(x_sPath, " * ", x_sExcelVersion, x_sSheet, x_bHDR,string.Empty);
        }

        public static DataSet ExcelToDS(string x_sPath, string x_sExcelVersion, string x_sSheet, bool x_bHDR, string x_sFilter)
        {
            return WebFuncBase.ExcelToDS(x_sPath, " * ", x_sExcelVersion, x_sSheet, x_bHDR, x_sFilter);
        }

        public static DataSet ExcelToDS(string x_sPath, string x_sField, string x_sExcelVersion, string x_sSheet, bool x_bHDR)
        {
            return WebFuncBase.ExcelToDS(x_sPath, x_sField, x_sExcelVersion, x_sSheet, x_bHDR, string.Empty);
        }

        public static DataSet ExcelToDS(string x_sPath, string x_sField, string x_sExcelVersion, string x_sSheet, bool x_bHDR, string x_sFilter)
        {
            if (x_sField == string.Empty) x_sField = " * ";
            OleDbConnection _oConn = GetExcelConn(x_sPath, x_sExcelVersion, x_bHDR);
            _oConn.Open();
            string strExcel = "";
            OleDbDataAdapter _oCmd = null;
            DataSet ds = null;
            strExcel = "SELECT " + x_sField + " FROM [" + x_sSheet + "] " + ((!string.IsNullOrEmpty(x_sFilter))? ("WHERE " + x_sFilter) : string.Empty);
            _oCmd = new OleDbDataAdapter(strExcel, _oConn);
            ds = new DataSet();
            _oCmd.Fill(ds, x_sSheet);
            _oCmd.Dispose();
            _oConn.Close();
            _oConn.Dispose();
            return ds;
        }


        public static OleDbDataReader ExcelToDataReader(string x_sPath, string x_sExcelVersion, string x_sSheet, bool x_bHDR)
        {
            OleDbConnection _oConn = GetExcelConn(x_sPath, x_sExcelVersion, x_bHDR);
            _oConn.Open();
            string _sQueryExcel = "SELECT * FROM [" + x_sSheet + "]";
            OleDbCommand _oCmd = new OleDbCommand(_sQueryExcel);
            return _oCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static IList<string> ExcelFieldList(string x_sPath, string x_sExcelVersion, string x_sSheet)
        {
            IList<string> _oExcelField = new List<string>();
            OleDbDataReader _oDr = WebFuncBase.ExcelToDataReader(x_sPath,x_sExcelVersion,x_sSheet, true);
            while (_oDr.Read()){
                for (int i = 0; i <= _oDr.FieldCount; i++)
                    if (!Func.FR(_oDr[i]).Trim().Equals(string.Empty)) _oExcelField.Add(Func.FR(_oDr[i]).Trim());
            }
            _oDr.Close();
            _oDr.Dispose();
            return _oExcelField;
        }

        public static Hashtable GetExcelFieldListByDataSet(global::System.Data.DataSet x_oDataSet)
        {
            Hashtable _oFields = new Hashtable();
            if (x_oDataSet.Tables.Count < 1) return _oFields;
            global::System.Data.DataRow _oDataRow = x_oDataSet.Tables[0].Rows[0];
            for (int i = 0; i < _oDataRow.Table.Columns.Count; i++)
            {
                ExcelFieldCharacter _oExcelFieldCharacter = new ExcelFieldCharacter();
                _oExcelFieldCharacter.ExcelField = _oDataRow[i].ToString();
                _oExcelFieldCharacter.DataSetPoint = i;
                _oFields.Add(_oExcelFieldCharacter.ExcelField, _oExcelFieldCharacter);
            }
            return _oFields;
        }

        public static Hashtable GetExcelFieldListByDataSetMappingDB(global::System.Data.DataSet x_oDataSet, IDictionary<string, string> x_oMapping)
        {
            Hashtable _oFields = new Hashtable();
            if (x_oDataSet.Tables.Count < 1) return _oFields;
            global::System.Data.DataRow _oDataRow = x_oDataSet.Tables[0].Rows[0];
            for (int i = 0; i < _oDataRow.Table.Columns.Count; i++)
            {
                ExcelFieldCharacter _oExcelFieldCharacter = new ExcelFieldCharacter();
                _oExcelFieldCharacter.ExcelField = _oDataRow[i].ToString();
                if (x_oMapping != null)
                {
                    if (x_oMapping.Count > 0 && !_oExcelFieldCharacter.ExcelField.Trim().Trim().Equals(string.Empty))
                    {
                        if (x_oMapping.ContainsKey(_oExcelFieldCharacter.ExcelField.Trim()))
                            _oExcelFieldCharacter.DBField = x_oMapping[_oExcelFieldCharacter.ExcelField.Trim()].ToString();
                    }
                }
                _oExcelFieldCharacter.DataSetPoint = i;
                _oFields.Add(_oExcelFieldCharacter.DBField, _oExcelFieldCharacter);
            }
            return _oFields;
        }
        #endregion

        #region File function

        public void CreateTextFile(Page x_oMyPage, string x_sFile)
        {
            string _sPath = x_oMyPage.Server.MapPath(x_sFile);
            FileInfo _oFileInfo = new FileInfo(_sPath);
            if (_oFileInfo.Exists == false)
            {
                StreamWriter _oSw = _oFileInfo.CreateText();
                _oSw.Close();
            }
        }
        public string ReadTextFile(Page x_oMyPage, string x_sFile)
        {
            string _sPath = x_oMyPage.Server.MapPath(x_sFile);
            StreamReader _oSr = new StreamReader(_sPath);
            string _sFileContent = _oSr.ReadToEnd();
            _oSr.Close();
            return _sFileContent;
        }

        public void SaveTextFile(Page x_oMyPage, string x_sFile, string x_sTextLine)
        {
            string _sPath = x_oMyPage.Server.MapPath(x_sFile);
            StreamWriter _oSw = new StreamWriter(_sPath);
            _oSw.WriteLine(x_sTextLine);
            _oSw.Flush();
            _oSw.Close();
        }
        public void AppendTextFile(Page x_oMyPage,string x_sFile, string x_sAppendLine)
        {
            string _sPath = x_oMyPage.Server.MapPath(x_sFile);
            FileInfo _oFileInfo = new FileInfo(_sPath);
            StreamWriter _oSw = _oFileInfo.AppendText(); 
            _oSw.WriteLine(x_sAppendLine);
            _oSw.Flush();
            _oSw.Close();
        }

        static public void CreateFolder(Page x_oMyPage, string x_sFolder)
        {
            string _sPath = x_oMyPage.Server.MapPath(x_sFolder);
            DirectoryInfo _oDirInfo = new DirectoryInfo(_sPath);
            if (!_oDirInfo.Exists)
                _oDirInfo.Create();
        }

        static public bool CheckFolderExists(Page x_oMyPage, string x_sFolder)
        {
            string _sPath = x_oMyPage.Server.MapPath(x_sFolder);
            DirectoryInfo _oDirInfo = new DirectoryInfo(_sPath);
            return _oDirInfo.Exists;
        }

        static public void CreateFile(Page mypage, string file)
        {
            string path = mypage.Server.MapPath(file);
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists == false)
            {
                FileStream fs = fileInfo.Create();
                fs.Close();
            }
        }

        static public bool CheckFileExists(Page mypage, string file)
        {
            string path = mypage.Server.MapPath(file);
            FileInfo fileInfo = new FileInfo(path);
            return fileInfo.Exists;
        }

        static public void DeleteFile(Page mypage, string file)
        {
            string path = mypage.Server.MapPath(file);
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists == true)
            {
                fileInfo.Delete();
            }
        }

        static public void MoveFile(Page mypage, string file, string target)
        {
            string path = mypage.Server.MapPath(file);
            string targetPath = mypage.Server.MapPath(target);
            FileInfo fileInfo = new FileInfo(path);
            FileInfo tfileInfo = new FileInfo(targetPath);
            if (fileInfo.Exists == true)
            {
                if (tfileInfo.Exists == false)
                {
                    fileInfo.MoveTo(targetPath);
                }
            }
        }

        static public void CopyFile(Page mypage, string file, string target)
        {
            string path = mypage.Server.MapPath(file);
            string targetPath = mypage.Server.MapPath(target);
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo(targetPath, true);
        }
        #endregion

        #region WebControl Function
        static public void DrpDownListSetSelectedValue(string x_sID,Page x_oPage, string x_sField_value, string x_sField_text, string x_sSelected, string x_sSql, string x_sConnectString)
        {
            if (string.IsNullOrEmpty(x_sConnectString)){ return;}
            DropDownList x_oDrpDownList = (DropDownList)x_oPage.FindControl(x_sID);
            WebFuncBase.DrpDownListSetSelectedValue(ref x_oDrpDownList, x_oPage, x_sField_value, x_sField_text, x_sSelected, x_sSql, x_sConnectString);
        }

        static public void DrpDownListSetSelectedValue(ref DropDownList x_oDrpDownList,Page x_oPage, string x_sField_value, string x_sField_text, string x_sSelected, string x_sSql, string x_sConnectString)
        {
            if (string.IsNullOrEmpty(x_sConnectString)) { return; }
            SqlConnection _oConn = new SqlConnection(x_sConnectString);
            SqlDataAdapter _oAdaptor = new SqlDataAdapter(x_sSql, _oConn);
            DataSet _oDs = new DataSet();
            _oAdaptor.Fill(_oDs);
            x_oDrpDownList.DataSource = _oDs;
            if (_oDs.Tables[0].Rows.Count > 0)
            {
                x_oDrpDownList.DataTextField = x_sField_text;
                x_oDrpDownList.DataValueField = x_sField_value;

                x_oDrpDownList.DataBind();
                x_oDrpDownList.SelectedValue = x_sSelected;
                x_oDrpDownList.Items.Insert(0, new ListItem("", ""));
            }
            else
            {
                x_oDrpDownList.Items.Insert(0, new ListItem("", ""));
                x_oDrpDownList.SelectedIndex = 0;
            }
        }


        static public void DrpDownListSetSelectedValue(ref DropDownList x_oDrpDownList, string x_sValue)
        {
            if (x_oDrpDownList != null &&
                !string.IsNullOrEmpty(x_sValue))
            {
                for (int i = 0; i < x_oDrpDownList.Items.Count; i++)
                {
                    if (x_oDrpDownList.Items[i].Value
                        .ToString()
                        .ToUpper()
                        .Trim()
                        .Equals(x_sValue.Trim().ToUpper()))
                    {
                        x_oDrpDownList.SelectedIndex = i;
                    }
                }
            }
        }

        #endregion

        #region SetFocus
        public static void SetFocus(System.Web.UI.Page oPage, System.Web.UI.Control c)
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            string scriptClientId = c.ClientID;
            sbScript.Append("<script language='javascript'>");
            sbScript.Append("document.getElementById('" + scriptClientId + "').focus();");
            sbScript.Append("</script>");
            oPage.RegisterStartupScript("SetFocus", sbScript.ToString());
        }
        #endregion

        #region RegisterScriptEX
        static public void RegisterScriptEX(Page mypage, string method)
        {
            method = "alert('" + method + "');";
            string script = @"
            <script language=""javascript"">
            <!--
            {0}
            //-->
            </script>
            ";
            mypage.ClientScript.RegisterStartupScript(typeof(Page), method, string.Format(script, method));
        }
        #endregion

        #region RegisterScript
        static public void RegisterScript(Page mypage, string method)
        {
            string script = @"
            <script language=""javascript"">
            <!--
            {0};
            //-->
            </script>
            ";
            mypage.ClientScript.RegisterStartupScript(typeof(Page), method, string.Format(script, method));
        }
        #endregion

        #region SetNavigateLocation
        public static void SetNavigateLocation(System.Web.UI.Page oPage, string sLocation)
        {
            System.Text.StringBuilder sbScript = new System.Text.StringBuilder();
            sbScript.Append("<script language=\"JavaScript\">");
            sbScript.Append("try {");
            sbScript.Append("top.setLocation(\"" + sLocation + "\");");
            sbScript.Append("} catch (e) {}\n");
            sbScript.Append("</script>\n");
            if (oPage != null && !oPage.IsClientScriptBlockRegistered("RegisterLocation"))
            {
                oPage.RegisterClientScriptBlock("RegisterLocation", sbScript.ToString());
            }
        }
        #endregion


        #region Web Request
        /// <summary>
        /// QueryString Function
        /// </summary>
        /// <param name="x_sName"></param>
        /// <returns></returns>
        public static string RequestQuery(string x_sName)
        {
            if (HttpContext.Current.Request[x_sName] != null)
                return HttpContext.Current.Request[x_sName].ToString();
            else
            {
                foreach (string _sKey in HttpContext.Current.Request.Form.Keys)
                    if (_sKey.Contains(x_sName)) { return HttpContext.Current.Request.Form[_sKey]; }
            }
            return string.Empty;
        }
        #endregion

        #region QueryString Parameter
        #region [accessory_waive]   qsAccessory_waiveName & qsAccessory_waive
        public const string qsAccessory_waiveName = "accessory_waive";
        public static bool qsAccessory_waive
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAccessory_waiveName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAccessory_waiveName].ToString());
                }
                return false;
            }
        }
        #endregion



        #region [special_handling_dummy_code]   qsSpecial_handling_dummy_codeName & qsSpecial_handling_dummy_code
        public const string qsSpecial_handling_dummy_codeName = "special_handling_dummy_code";
        public static string qsSpecial_handling_dummy_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSpecial_handling_dummy_codeName]))
                {
                    return HttpContext.Current.Request[qsSpecial_handling_dummy_codeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [first_month_fee]   qsFirst_month_feeName & qsFirst_month_fee
        public const string qsFirst_month_feeName = "first_month_fee";
        public static string qsFirst_month_fee
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFirst_month_feeName]))
                {
                    return HttpContext.Current.Request[qsFirst_month_feeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [first_month_license_fee]   qsFirst_month_license_feeName & qsFirst_month_license_fee
        public const string qsFirst_month_license_feeName = "first_month_license_fee";
        public static string qsFirst_month_license_fee
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFirst_month_license_feeName]))
                {
                    return HttpContext.Current.Request[qsFirst_month_license_feeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [ftg_tenure]   qsFtg_tenureName & qsFtg_tenure
        public const string qsFtg_tenureName = "ftg_tenure";
        public static string qsFtg_tenure
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFtg_tenureName]))
                {
                    return HttpContext.Current.Request[qsFtg_tenureName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [card_ref_no]   qsCard_ref_noName & qsCard_ref_no
        public const string qsCard_ref_noName = "card_ref_no";
        public static string qsCard_ref_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_ref_noName]))
                {
                    return HttpContext.Current.Request[qsCard_ref_noName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [cn_mrt_no]   qsCn_mrt_noName & qsCn_mrt_no
        public const string qsCn_mrt_noName = "cn_mrt_no";
        public static global::System.Nullable<long> qsCn_mrt_no
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[qsCn_mrt_noName]))
                {
                    return long.Parse(HttpContext.Current.Request[qsCn_mrt_noName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [pool]   qsPoolName & qsPool
        public const string qsPoolName = "pool";
        public static string qsPool
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPoolName]))
                {
                    return HttpContext.Current.Request[qsPoolName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion




        #region [m_3rd_id_type]   qsM_3rd_id_typeName & qsM_3rd_id_type
        public const string qsM_3rd_id_typeName = "m_3rd_id_type";
        public static string qsM_3rd_id_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_3rd_id_typeName]))
                {
                    return HttpContext.Current.Request[qsM_3rd_id_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [m_3rd_hkid]   qsM_3rd_hkidName & qsM_3rd_hkid
        public const string qsM_3rd_hkidName = "m_3rd_hkid";
        public static string qsM_3rd_hkid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_3rd_hkidName]))
                {
                    return HttpContext.Current.Request[qsM_3rd_hkidName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [m_3rd_hkid2]   qsM_3rd_hkid2Name & qsM_3rd_hkid2
        public const string qsM_3rd_hkid2Name = "m_3rd_hkid2";
        public static string qsM_3rd_hkid2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_3rd_hkid2Name]))
                {
                    return HttpContext.Current.Request[qsM_3rd_hkid2Name].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [m_3rd_contact_no]   qsM_3rd_contact_noName & qsM_3rd_contact_no
        public const string qsM_3rd_contact_noName = "m_3rd_contact_no";
        public static string qsM_3rd_contact_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_3rd_contact_noName]))
                {
                    return HttpContext.Current.Request[qsM_3rd_contact_noName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [upgrade_rebate_calculation]   qsUpgrade_rebate_calculationName & qsUpgrade_rebate_calculation
        public const string qsUpgrade_rebate_calculationName = "upgrade_rebate_calculation";
        public static string qsUpgrade_rebate_calculation
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_rebate_calculationName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_rebate_calculationName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [upgrade_existing_pccw_customer]   qsUpgrade_existing_pccw_customerName & qsUpgrade_existing_pccw_customer
        public const string qsUpgrade_existing_pccw_customerName = "upgrade_existing_pccw_customer";
        public static string qsUpgrade_existing_pccw_customer
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_existing_pccw_customerName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_existing_pccw_customerName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [upgrade_service_account_no]   qsUpgrade_service_account_noName & qsUpgrade_service_account_no
        public const string qsUpgrade_service_account_noName = "upgrade_service_account_no";
        public static string qsUpgrade_service_account_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_service_account_noName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_service_account_noName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [upgrade_registered_mobile_no]   qsUpgrade_registered_mobile_noName & qsUpgrade_registered_mobile_no
        public const string qsUpgrade_registered_mobile_noName = "upgrade_registered_mobile_no";
        public static string qsUpgrade_registered_mobile_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_registered_mobile_noName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_registered_mobile_noName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [upgrade_service_tenure]   qsUpgrade_service_tenureName & qsUpgrade_service_tenure
        public const string qsUpgrade_service_tenureName = "upgrade_service_tenure";
        public static string qsUpgrade_service_tenure
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_service_tenureName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_service_tenureName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [action_of_rate_plan_effective]   qsAction_of_rate_plan_effectiveName & qsAction_of_rate_plan_effective
        public const string qsAction_of_rate_plan_effectiveName = "action_of_rate_plan_effective";
        public static string qsAction_of_rate_plan_effective
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAction_of_rate_plan_effectiveName]))
                {
                    return HttpContext.Current.Request[qsAction_of_rate_plan_effectiveName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [existing_smart_phone_model]   qsExisting_smart_phone_modelName & qsExisting_smart_phone_model
        public const string qsExisting_smart_phone_modelName = "existing_smart_phone_model";
        public static string qsExisting_smart_phone_model
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExisting_smart_phone_modelName]))
                {
                    return HttpContext.Current.Request[qsExisting_smart_phone_modelName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [existing_smart_phone_imei]   qsExisting_smart_phone_imeiName & qsExisting_smart_phone_imei
        public const string qsExisting_smart_phone_imeiName = "existing_smart_phone_imei";
        public static string qsExisting_smart_phone_imei
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExisting_smart_phone_imeiName]))
                {
                    return HttpContext.Current.Request[qsExisting_smart_phone_imeiName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [upgrade_handset_offer_rebate_schedule]   qsUpgrade_handset_offer_rebate_scheduleeName & qsUpgrade_handset_offer_rebate_schedule
        public const string qsUpgrade_handset_offer_rebate_scheduleeName = "upgrade_handset_offer_rebate_schedule";
        public static string qsUpgrade_handset_offer_rebate_schedule
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_handset_offer_rebate_scheduleeName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_handset_offer_rebate_scheduleeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [upgrade_existing_customer_type]   qsUpgrade_existing_customer_typeName & qsUpgrade_existing_customer_type
        public const string qsUpgrade_existing_customer_typeName = "upgrade_existing_customer_type";
        public static string qsUpgrade_existing_customer_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_existing_customer_typeName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_existing_customer_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [upgrade_existing_contract_edate]   qsUpgrade_existing_contract_edateName & qsUpgrade_existing_contract_edate
        public const string qsUpgrade_existing_contract_edateName = "SDATE";
        public static System.Nullable<DateTime> qsUpgrade_existing_contract_edate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsUpgrade_existing_contract_edateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsUpgrade_existing_contract_edateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsUpgrade_existing_contract_edateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [upgrade_existing_contract_sdate]   qsUpgrade_existing_contract_sdateName & qsUpgrade_existing_contract_sdate
        public const string qsUpgrade_existing_contract_sdateName = "SDATE";
        public static System.Nullable<DateTime> qsUpgrade_existing_contract_sdate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsUpgrade_existing_contract_sdateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsUpgrade_existing_contract_sdateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsUpgrade_existing_contract_sdateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion


        #region [upgrade_sponsorships_amount] qsUpgrade_sponsorships_amountName & qsUpgrade_sponsorships_amount
        public const string qsUpgrade_sponsorships_amountName = "upgrade_sponsorships_amount";
        public static string qsUpgrade_sponsorships_amount
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_sponsorships_amountName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_sponsorships_amountName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [upgrade_type] qsUpgrade_typeName & qsUpgrade_type
        public const string qsUpgrade_typeName = "upgrade_type";
        public static string qsUpgrade_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsUpgrade_typeName]))
                {
                    return HttpContext.Current.Request[qsUpgrade_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [monthly_payment_type] qsMonthly_payment_typeName & qsMonthly_payment_type
        public const string qsMonthly_payment_typeName = "monthly_payment_type";
        public static string qsMonthly_payment_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_payment_typeName]))
                {
                    return HttpContext.Current.Request[qsMonthly_payment_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [given_name] qsGiven_nameName & qsGiven_name
        public const string qsGiven_nameName = "given_name";
        public static string qsGiven_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGiven_nameName]))
                {
                    return HttpContext.Current.Request[qsGiven_nameName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [family_name] qsFamily_nameName & qsFamily_name
        public const string qsFamily_nameName = "family_name";
        public static string qsFamily_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFamily_nameName]))
                {
                    return HttpContext.Current.Request[qsFamily_nameName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [redemption_notice_option]   qsRedemption_notice_optionName & qsRedemption_notice_option
        public const string qsRedemption_notice_optionName = "redemption_notice_option";
        public static string qsRedemption_notice_option
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRedemption_notice_optionName]))
                {
                    return HttpContext.Current.Request[qsRedemption_notice_optionName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [delivery_exchange]   qsDelivery_exchangeName & qsDelivery_exchange
        public const string qsDelivery_exchangeName = "delivery_exchange";
        public static string qsDelivery_exchange
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDelivery_exchangeName]))
                {
                    return HttpContext.Current.Request[qsDelivery_exchangeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [delivery_exchange_location]   qsDelivery_exchange_locationName & qsDelivery_exchange_location
        public const string qsDelivery_exchange_locationName = "delivery_exchange_location";
        public static string qsDelivery_exchange_location
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDelivery_exchange_locationName]))
                {
                    return HttpContext.Current.Request[qsDelivery_exchange_locationName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [delivery_exchange_option]   qsDelivery_exchange_optionName & qsDelivery_exchange_option
        public const string qsDelivery_exchange_optionName = "delivery_exchange_option";
        public static string qsDelivery_exchange_option
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDelivery_exchange_optionName]))
                {
                    return HttpContext.Current.Request[qsDelivery_exchange_optionName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [delivery_collection_type]   qsDelivery_collection_typeName & qsDelivery_collection_type
        public const string qsDelivery_collection_typeName = "delivery_collection_type";
        public static string qsDelivery_collection_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDelivery_collection_typeName]))
                {
                    return HttpContext.Current.Request[qsDelivery_collection_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [filename]   qsFilenameName & qsFilename
        public const string qsFilenameName = "filename";
        public static string qsFilename
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFilenameName]))
                {
                    return HttpContext.Current.Request[qsFilenameName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [monthly_bank_account_hkid2]   qsMonthly_bank_account_hkid2Name & qsMonthly_bank_account_hkid2
        public const string qsMonthly_bank_account_hkid2Name = "monthly_bank_account_hkid2";
        public static string qsMonthly_bank_account_hkid2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_bank_account_hkid2Name]))
                {
                    return HttpContext.Current.Request[qsMonthly_bank_account_hkid2Name].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [monthly_bank_account_hkid]   qsMonthly_bank_account_hkidName & qsMonthly_bank_account_hkid
        public const string qsMonthly_bank_account_hkidName = "monthly_bank_account_hkid";
        public static string qsMonthly_bank_account_hkid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_bank_account_hkidName]))
                {
                    return HttpContext.Current.Request[qsMonthly_bank_account_hkidName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [monthly_bank_account_id_type]   qsMonthly_bank_account_id_typeName & qsMonthly_bank_account_id_type
        public const string qsMonthly_bank_account_id_typeName = "monthly_bank_account_id_type";
        public static string qsMonthly_bank_account_id_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_bank_account_id_typeName]))
                {
                    return HttpContext.Current.Request[qsMonthly_bank_account_id_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [monthly_bank_account_holder]   qsMonthly_bank_account_holderName & qsMonthly_bank_account_holder
        public const string qsMonthly_bank_account_holderName = "monthly_bank_account_holder";
        public static string qsMonthly_bank_account_holder
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_bank_account_holderName]))
                {
                    return HttpContext.Current.Request[qsMonthly_bank_account_holderName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [monthly_bank_account_no]   qsMonthly_bank_account_noName & qsMonthly_bank_account_no
        public const string qsMonthly_bank_account_noName = "monthly_bank_account_no";
        public static string qsMonthly_bank_account_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_bank_account_noName]))
                {
                    return HttpContext.Current.Request[qsMonthly_bank_account_noName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [monthly_bank_account_branch_code]   qsMonthly_bank_account_branch_codeName & qsMonthly_bank_account_branch_code
        public const string qsMonthly_bank_account_branch_codeName = "monthly_bank_account_branch_code";
        public static string qsMonthly_bank_account_branch_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_bank_account_branch_codeName]))
                {
                    return HttpContext.Current.Request[qsMonthly_bank_account_branch_codeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [monthly_bank_account_bank_code]   qsMonthly_bank_account_bank_codeName & qsMonthly_bank_account_bank_code
        public const string qsMonthly_bank_account_bank_codeName = "monthly_bank_account_bank_code";
        public static string qsMonthly_bank_account_bank_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_bank_account_bank_codeName]))
                {
                    return HttpContext.Current.Request[qsMonthly_bank_account_bank_codeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [date_of_birth]   qsDate_of_birthName & qsDate_of_birth
        public const string qsDate_of_birthName = "date_of_birth";
        public static System.Nullable<DateTime> qsDate_of_birth
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsDate_of_birthName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsDate_of_birthName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsDate_of_birthName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [gender]   qsGenderName & qsGender
        public const string qsGenderName = "gender";
        public static string qsGender
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGenderName]))
                {
                    return HttpContext.Current.Request[qsGenderName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [change_payment_type]   qsChange_payment_typeName & qsChange_payment_type
        public const string qsChange_payment_typeName = "change_payment_type";
        public static string qsChange_payment_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsChange_payment_typeName]))
                {
                    return HttpContext.Current.Request[qsChange_payment_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [sms_mrt]   qsSms_mrtName & qsSms_mrt
        public const string qsSms_mrtName = "sms_mrt";
        public static string qsSms_mrt
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSms_mrtName]))
                {
                    return HttpContext.Current.Request[qsSms_mrtName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [normal_rebate_type]   qsNormal_rebate_typeName & qsNormal_rebate_type
        public const string qsNormal_rebate_typeName = "normal_rebate_type";
        public static string qsNormal_rebate_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsNormal_rebate_typeName]))
                {
                    return HttpContext.Current.Request[qsNormal_rebate_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [issue_type]   qsIssue_typeName & qsIssue_type
        public const string qsIssue_typeName = "issue_type";
        public static string qsIssue_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsIssue_typeName]))
                {
                    return HttpContext.Current.Request[qsIssue_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [registered_address_id]   qsRegistered_address_idName & qsRegistered_address_id
        public const string qsRegistered_address_idName = "registered_address_id";
        public static global::System.Nullable<long> qsRegistered_address_id
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[qsRegistered_address_idName]))
                {
                    return long.Parse(HttpContext.Current.Request[qsRegistered_address_idName].ToString());
                }
                return null;
            }
        }
        #endregion

        #region [bill_medium]   qsBill_mediumName & qsBill_medium
        public const string qsBill_mediumName = "bill_medium";
        public static string qsBill_medium
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsBill_mediumName]))
                {
                    return HttpContext.Current.Request[qsBill_mediumName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [bill_medium_email]   qsBill_medium_emailName & qsBill_medium_email
        public const string qsBill_medium_emailName = "bill_medium_email";
        public static string qsBill_medium_email
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsBill_medium_emailName]))
                {
                    return HttpContext.Current.Request[qsBill_medium_emailName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [bill_medium_waive]   qsBill_medium_waiveName & qsBill_medium_waive
        public const string qsBill_medium_waiveName = "bill_medium_waive";
        public static bool qsBill_medium_waive
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsBill_medium_waiveName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsBill_medium_waiveName].ToString());
                }
                return false;
            }
        }
        #endregion

        #region [bill_address_id]   qsBill_address_idName & qsBill_address_id
        public const string qsBill_address_idName = "bill_address_id";
        public static global::System.Nullable<long> qsBill_address_id
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[qsBill_address_idName]))
                {
                    return long.Parse(HttpContext.Current.Request[qsBill_address_idName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [mnp_id]   qsMnp_idName & qsMnp_id
        public const string qsMnp_idName = "mnp_id";
        public static global::System.Nullable<long> qsMnp_id
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[qsMnp_idName]))
                {
                    return long.Parse(HttpContext.Current.Request[qsMnp_idName].ToString());
                }
                return null;
            }
        }
        #endregion

        #region [prepayment_waive]   qsPrepayment_waiveName & qsPrepayment_waive
        public const string qsPrepayment_waiveName = "prepayment_waive";
        public static global::System.Nullable<bool> qsPrepayment_waive
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsPrepayment_waiveName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsPrepayment_waiveName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [three_party_id]   qsThree_party_idName & qsThree_party_id
        public const string qsThree_party_idName = "three_party_id";
        public static global::System.Nullable<long> qsThree_party_id
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[qsThree_party_idName]))
                {
                    return long.Parse(HttpContext.Current.Request[qsThree_party_idName].ToString());
                }
                return null;
            }
        }
        #endregion



        #region [receive_sim_by_3rd_party]   qsReceive_sim_by_3rd_partyName & qsReceive_sim_by_3rd_party
        public const string qsReceive_sim_by_3rd_partyName = "receive_sim_by_3rd_party";
        public static global::System.Nullable<bool> qsReceive_sim_by_3rd_party
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsReceive_sim_by_3rd_partyName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsReceive_sim_by_3rd_partyName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [receive_sim_arthurization_person]   qsReceive_sim_arthurization_personName & qsReceive_sim_arthurization_person
        public const string qsReceive_sim_arthurization_personName = "receive_sim_arthurization_person";
        public static string qsReceive_sim_arthurization_person
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsReceive_sim_arthurization_personName]))
                {
                    return HttpContext.Current.Request[qsReceive_sim_arthurization_personName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [receive_sim_hkid]   qsReceive_sim_hkidName & qsReceive_sim_hkid
        public const string qsReceive_sim_hkidName = "receive_sim_hkid";
        public static string qsReceive_sim_hkid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsReceive_sim_hkidName]))
                {
                    return HttpContext.Current.Request[qsReceive_sim_hkidName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [receive_contact_number]   qsReceive_contact_numberName & qsReceive_contact_number
        public const string qsReceive_contact_numberName = "receive_contact_number";
        public static string qsReceive_contact_number
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsReceive_contact_numberName]))
                {
                    return HttpContext.Current.Request[qsReceive_contact_numberName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [company_name]   qsCompany_nameName & qsCompany_name
        public const string qsCompany_nameName = "company_name";
        public static string qsCompany_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCompany_nameName]))
                {
                    return HttpContext.Current.Request[qsCompany_nameName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [registered_name]   qsRegistered_nameName & qsRegistered_name
        public const string qsRegistered_nameName = "registered_name";
        public static string qsRegistered_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRegistered_nameName]))
                {
                    return HttpContext.Current.Request[qsRegistered_nameName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [hkid_no]   qsHkid_noName & qsHkid_no
        public const string qsHkid_noName = "hkid_no";
        public static string qsHkid_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsHkid_noName]))
                {
                    return HttpContext.Current.Request[qsHkid_noName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [transfer_to_3g]   qsTransfer_to_3gName & qsTransfer_to_3g
        public const string qsTransfer_to_3gName = "transfer_to_3g";
        public static global::System.Nullable<bool> qsTransfer_to_3g
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsTransfer_to_3gName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsTransfer_to_3gName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [transfer_idd_deposit]   qsTransfer_idd_depositName & qsTransfer_idd_deposit
        public const string qsTransfer_idd_depositName = "transfer_idd_deposit";
        public static global::System.Nullable<int> qsTransfer_idd_deposit
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsTransfer_idd_depositName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsTransfer_idd_depositName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [transfer_idd_roaming_deposit]   qsTransfer_idd_roaming_depositName & qsTransfer_idd_roaming_deposit
        public const string qsTransfer_idd_roaming_depositName = "transfer_idd_roaming_deposit";
        public static global::System.Nullable<int> qsTransfer_idd_roaming_deposit
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsTransfer_idd_roaming_depositName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsTransfer_idd_roaming_depositName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [transfer_no_hk_id_holder_deposit]   qsTransfer_no_hk_id_holder_depositName & qsTransfer_no_hk_id_holder_deposit
        public const string qsTransfer_no_hk_id_holder_depositName = "transfer_no_hk_id_holder_deposit";
        public static global::System.Nullable<int> qsTransfer_no_hk_id_holder_deposit
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsTransfer_no_hk_id_holder_depositName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsTransfer_no_hk_id_holder_depositName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [transfer_others_deposit]   qsTransfer_others_depositName & qsTransfer_others_deposit
        public const string qsTransfer_others_depositName = "transfer_others_deposit";
        public static global::System.Nullable<int> qsTransfer_others_deposit
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsTransfer_others_depositName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsTransfer_others_depositName].ToString());
                }
                return null;
            }
        }
        #endregion


        #region [service_activation_date]   qsService_activation_dateName & qsService_activation_date
        public const string qsService_activation_dateName = "service_activation_date";
        public static global::System.Nullable<DateTime> qsService_activation_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsService_activation_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsService_activation_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsService_activation_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [service_activation_time]   qsService_activation_timeName & qsService_activation_time
        public const string qsService_activation_timeName = "service_activation_time";
        public static string qsService_activation_time
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsService_activation_timeName]))
                {
                    return HttpContext.Current.Request[qsService_activation_timeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [ticker_number]   qsTicker_numberName & qsTicker_number
        public const string qsTicker_numberName = "ticker_number";
        public static string qsTicker_number
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTicker_numberName]))
                {
                    return HttpContext.Current.Request[qsTicker_numberName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion




        #region [offer_type_id]   qsOffer_type_idName & qsOffer_type_id
        public const string qsOffer_type_idName = "offer_type_id";
        public static global::System.Nullable<int> qsOffer_type_id
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsOffer_type_idName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsOffer_type_idName].ToString());
                }
                return null;
            }
        }
        #endregion

        #region [expiry_chk]   qsExpiry_chkName & qsExpiry_chk
        public const string qsExpiry_chkName = "expiry_chk";
        public static global::System.Nullable<bool> qsExpiry_chk
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsExpiry_chkName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsExpiry_chkName].ToString());
                }
                return null;
            }
        }
        #endregion

        #region [installment_period]   qsInstallment_periodName & qsInstallment_period
        public const string qsInstallment_periodName = "installment_period";
        public static string qsInstallment_period
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsInstallment_periodName]))
                {
                    return HttpContext.Current.Request[qsInstallment_periodName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [sim_item_name]   qsSim_item_nameName & qsSim_item_name
        public const string qsSim_item_nameName = "sim_item_name";
        public static string qsSim_item_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSim_item_nameName]))
                {
                    return HttpContext.Current.Request[qsSim_item_nameName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [sim_item_number]   qsSim_item_numberName & qsSim_item_number
        public const string qsSim_item_numberName = "sim_item_number";
        public static string qsSim_item_number
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSim_item_numberName]))
                {
                    return HttpContext.Current.Request[qsSim_item_numberName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [sim_item_code]   qsSim_item_codeName & qsSim_item_code
        public const string qsSim_item_codeName = "sim_item_code";
        public static string qsSim_item_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSim_item_codeName]))
                {
                    return HttpContext.Current.Request[qsSim_item_codeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [fallout_main_category]   qsFallout_main_categoryName & qsFallout_main_category
        public const string qsFallout_main_categoryName = "fallout_main_category";
        public static string qsFallout_main_category
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFallout_main_categoryName]))
                {
                    return HttpContext.Current.Request[qsFallout_main_categoryName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [bill_cut_date]   qsBill_cut_dateName & qsBill_cut_date
        public const string qsBill_cut_dateName = "bill_cut_date";
        public static global::System.Nullable<DateTime> qsBill_cut_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsBill_cut_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsBill_cut_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsBill_cut_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion

        #region [bill_cut_num]   qsBill_cut_numName & qsBill_cut_num
        public const string qsBill_cut_numName = "bill_cut_num";
        public static global::System.Nullable<int> qsBill_cut_num
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsBill_cut_numName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsBill_cut_numName].ToString());
                }
                return null;
            }
        }
        #endregion

        #region [pcd_paid_go_wireless]   qsPcd_paid_go_wirelessName & qsPcd_paid_go_wireless
        public const string qsPcd_paid_go_wirelessName = "pcd_paid_go_wireless";
        public static bool qsPcd_paid_go_wireless
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsPcd_paid_go_wirelessName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsPcd_paid_go_wirelessName].ToString());
                }
                return false;
            }
        }
        #endregion

        #region [go_wireless_package_code]   qsGo_wireless_package_codeName & qsGo_wireless_package_code
        public const string qsGo_wireless_package_codeName = "go_wireless_package_code";
        public static string qsGo_wireless_package_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGo_wireless_package_codeName]))
                {
                    return HttpContext.Current.Request[qsGo_wireless_package_codeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [po_date]   qsPo_dateName & qsPo_date
        public const string qsPo_dateName = "po_date";
        public static System.Nullable<DateTime> qsPo_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsPo_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsPo_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsPo_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [remarks]   qsRemarksName & qsRemarks
        public const string qsRemarksName = "remarks";
        public static string qsRemarks
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRemarksName]))
                {
                    return HttpContext.Current.Request[qsRemarksName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [s_premium1]   qsS_premium1Name & qsS_premium1
        public const string qsS_premium1Name = "S_premium1";
        public static string qsS_premium1
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsS_premium1Name]))
                {
                    return HttpContext.Current.Request[qsS_premium1Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [s_premium3]   qsS_premium3Name & qsS_premium3
        public const string qsS_premium3Name = "S_premium3";
        public static string qsS_premium3
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsS_premium3Name]))
                {
                    return HttpContext.Current.Request[qsS_premium3Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [s_premium4]   qsS_premium4Name & qsS_premium4
        public const string qsS_premium4Name = "S_premium4";
        public static string qsS_premium4
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsS_premium4Name]))
                {
                    return HttpContext.Current.Request[qsS_premium4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [premium_1]   qsPremium_1Name & qsPremium_1
        public const string qsPremium_1Name = "premium_1";
        public static string qsPremium_1 {
            get {
                if(Func.IsParseString(HttpContext.Current.Request[qsPremium_1Name])){
                return HttpContext.Current.Request[qsPremium_1Name].ToString();}
                return string.Empty;
            }
        }
        #endregion
        #region [premium_2]   qsPremium_2Name & qsPremium_2
        public const string qsPremium_2Name = "premium_2";
        public static string qsPremium_2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPremium_2Name]))
                {
                    return HttpContext.Current.Request[qsPremium_2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [cooling_date]   qsCooling_dateName & qsCooling_date
        public const string qsCooling_dateName = "cooling_date";
        public static System.Nullable<DateTime> qsCooling_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsCooling_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsCooling_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsCooling_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [hs_offer_type_id]   qsHs_offer_type_idName & qsHs_offer_type_id
        public const string qsHs_offer_type_idName = "hs_offer_type_id";
        public static System.Nullable<int> qsHs_offer_type_id
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsHs_offer_type_idName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsHs_offer_type_idName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [org_mrt]   qsOrg_mrtName & qsOrg_mrt
        public const string qsOrg_mrtName = "org_mrt";
        public static System.Nullable<int> qsOrg_mrt
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsOrg_mrtName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsOrg_mrtName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [third_party_hkid]   qsThird_party_hkidName & qsThird_party_hkid
        public const string qsThird_party_hkidName = "third_party_hkid";
        public static string qsThird_party_hkid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsThird_party_hkidName]))
                {
                    return HttpContext.Current.Request[qsThird_party_hkidName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [third_party_id_type]   qsThird_party_id_typeName & qsThird_party_id_type
        public const string qsThird_party_id_typeName = "third_party_id_type";
        public static string qsThird_party_id_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsThird_party_id_typeName]))
                {
                    return HttpContext.Current.Request[qsThird_party_id_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [third_party_credit_card]   qsThird_party_credit_cardName & qsThird_party_credit_card
        public const string qsThird_party_credit_cardName = "third_party_credit_card";
        public static string qsThird_party_credit_card
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsThird_party_credit_cardName]))
                {
                    return HttpContext.Current.Request[qsThird_party_credit_cardName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [register_address]   qsRegister_addressName & qsRegister_address
        public const string qsRegister_addressName = "register_address";
        public static string qsRegister_address
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRegister_addressName]))
                {
                    return HttpContext.Current.Request[qsRegister_addressName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [preferred_languages]   qsPreferred_languagesName & qsPreferred_languages
        public const string qsPreferred_languagesName = "preferred_languages";
        public static string qsPreferred_languages
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPreferred_languagesName]))
                {
                    return HttpContext.Current.Request[qsPreferred_languagesName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [go_wireless]   qsGo_wirelessName & qsGo_wireless
        public const string qsGo_wirelessName = "go_wireless";
        public static string qsGo_wireless
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGo_wirelessName]))
                {
                    return HttpContext.Current.Request[qsGo_wirelessName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [sim_mrt_no]   qsSim_mrt_noName & qsSim_mrt_no
        public const string qsSim_mrt_noName = "sim_mrt_no";
        public static System.Nullable<int> qsSim_mrt_no
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsSim_mrt_noName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsSim_mrt_noName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [min_vas_add]   qsMin_vas_addName & qsMin_vas_add
        public const string qsMin_vas_addName = "min_vas_add";
        public static string qsMin_vas_add
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_vas_addName]))
                {
                    return HttpContext.Current.Request[qsMin_vas_addName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [id]   qsIdName & qsId
        public const string qsIdName = "id";
        public static System.Nullable<int> qsId
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsIdName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsIdName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [cdate]   qsCdateName & qsCdate
        public const string qsCdateName = "cdate";
        public static System.Nullable<DateTime> qsCdate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsCdateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsCdateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsCdateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [cid]   qsCidName & qsCid
        public const string qsCidName = "cid";
        public static string qsCid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCidName]))
                {
                    return HttpContext.Current.Request[qsCidName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [mrt_no]   qsMrt_noName & qsMrt_no
        public const string qsMrt_noName = "mrt_no";
        public static string qsMrt_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMrt_noName]))
                {
                    return HttpContext.Current.Request[qsMrt_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [active]   qsActiveName & qsActive
        public const string qsActiveName = "active";
        public static string qsActive
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsActiveName]))
                {
                    return HttpContext.Current.Request[qsActiveName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ac_no]   qsAc_noName & qsAc_no
        public const string qsAc_noName = "ac_no";
        public static string qsAc_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAc_noName]))
                {
                    return HttpContext.Current.Request[qsAc_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [cooling_offer]   qsCooling_offerName & qsCooling_offer
        public const string qsCooling_offerName = "cooling_offer";
        public static string qsCooling_offer
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCooling_offerName]))
                {
                    return HttpContext.Current.Request[qsCooling_offerName].ToString();
                }
                return null;
            }
        }
        #endregion
        #region [order_id]   qsOrder_idName & qsOrder_id
        public const string qsOrder_idName = "order_id";
        public static System.Nullable<int> qsOrder_id
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsOrder_idName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsOrder_idName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [ddate]   qsDdateName & qsDdate
        public const string qsDdateName = "ddate";
        public static System.Nullable<DateTime> qsDdate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsDdateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsDdateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsDdateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [did]   qsDidName & qsDid
        public const string qsDidName = "did";
        public static string qsDid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDidName]))
                {
                    return HttpContext.Current.Request[qsDidName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [bank_code]   qsBank_codeName & qsBank_code
        public const string qsBank_codeName = "bank_code";
        public static string qsBank_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsBank_codeName]))
                {
                    return HttpContext.Current.Request[qsBank_codeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [bank_name]   qsBank_nameName & qsBank_name
        public const string qsBank_nameName = "bank_name";
        public static string qsBank_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsBank_nameName]))
                {
                    return HttpContext.Current.Request[qsBank_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [mid]   qsMidName & qsMid
        public const string qsMidName = "mid";
        public static System.Nullable<int> qsMid
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsMidName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsMidName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [min_amount]   qsMin_amountName & qsMin_amount
        public const string qsMin_amountName = "min_amount";
        public static string qsMin_amount
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_amountName]))
                {
                    return HttpContext.Current.Request[qsMin_amountName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [CID]   qsCIDName & qsCID
        public const string qsCIDName = "CID";
        public static string qsCID
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCIDName]))
                {
                    return HttpContext.Current.Request[qsCIDName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [DID]   qsDIDName & qsDID
        public const string qsDIDName = "DID";
        public static string qsDID
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDIDName]))
                {
                    return HttpContext.Current.Request[qsDIDName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [PROG_LV]   qsPROG_LVName & qsPROG_LV
        public const string qsPROG_LVName = "PROG_LV";
        public static string qsPROG_LV
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPROG_LVName]))
                {
                    return HttpContext.Current.Request[qsPROG_LVName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [AR_LST]   qsAR_LSTName & qsAR_LST
        public const string qsAR_LSTName = "AR_LST";
        public static System.Nullable<bool> qsAR_LST
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAR_LSTName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAR_LSTName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [STAFF_NO]   qsSTAFF_NOName & qsSTAFF_NO
        public const string qsSTAFF_NOName = "STAFF_NO";
        public static string qsSTAFF_NO
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSTAFF_NOName]))
                {
                    return HttpContext.Current.Request[qsSTAFF_NOName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [AR_PRT]   qsAR_PRTName & qsAR_PRT
        public const string qsAR_PRTName = "AR_PRT";
        public static System.Nullable<bool> qsAR_PRT
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAR_PRTName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAR_PRTName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [AR_MOD]   qsAR_MODName & qsAR_MOD
        public const string qsAR_MODName = "AR_MOD";
        public static System.Nullable<bool> qsAR_MOD
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAR_MODName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAR_MODName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [PROG_NAME]   qsPROG_NAMEName & qsPROG_NAME
        public const string qsPROG_NAMEName = "PROG_NAME";
        public static string qsPROG_NAME
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPROG_NAMEName]))
                {
                    return HttpContext.Current.Request[qsPROG_NAMEName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ACTIVE]   qsACTIVEName & qsACTIVE
        public const string qsACTIVEName = "ACTIVE";
        public static System.Nullable<int> qsACTIVE
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsACTIVEName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsACTIVEName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [AR_ADD]   qsAR_ADDName & qsAR_ADD
        public const string qsAR_ADDName = "AR_ADD";
        public static System.Nullable<bool> qsAR_ADD
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAR_ADDName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAR_ADDName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [AR_DEL]   qsAR_DELName & qsAR_DEL
        public const string qsAR_DELName = "AR_DEL";
        public static System.Nullable<bool> qsAR_DEL
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAR_DELName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAR_DELName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [DDATE]   qsDDATEName & qsDDATE
        public const string qsDDATEName = "DDATE";
        public static System.Nullable<DateTime> qsDDATE
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsDDATEName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsDDATEName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsDDATEName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [CDATE]   qsCDATEName & qsCDATE
        public const string qsCDATEName = "CDATE";
        public static System.Nullable<DateTime> qsCDATE
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsCDATEName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsCDATEName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsCDATEName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [APPL_ID]   qsAPPL_IDName & qsAPPL_ID
        public const string qsAPPL_IDName = "APPL_ID";
        public static System.Nullable<int> qsAPPL_ID
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsAPPL_IDName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsAPPL_IDName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [reasons]   qsReasonsName & qsReasons
        public const string qsReasonsName = "reasons";
        public static string qsReasons
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsReasonsName]))
                {
                    return HttpContext.Current.Request[qsReasonsName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [fee]   qsFeeName & qsFee
        public const string qsFeeName = "fee";
        public static string qsFee
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFeeName]))
                {
                    return HttpContext.Current.Request[qsFeeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vas_desc]   qsVas_descName & qsVas_desc
        public const string qsVas_descName = "vas_desc";
        public static string qsVas_desc
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVas_descName]))
                {
                    return HttpContext.Current.Request[qsVas_descName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vas]   qsVasName & qsVas
        public const string qsVasName = "vas";
        public static string qsVas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVasName]))
                {
                    return HttpContext.Current.Request[qsVasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vas_field]   qsVas_fieldName & qsVas_field
        public const string qsVas_fieldName = "vas_field";
        public static string qsVas_field
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVas_fieldName]))
                {
                    return HttpContext.Current.Request[qsVas_fieldName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [edate]   qsEdateName & qsEdate
        public const string qsEdateName = "edate";
        public static System.Nullable<DateTime> qsEdate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsEdateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsEdateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsEdateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [program]   qsProgramName & qsProgram
        public const string qsProgramName = "program";
        public static string qsProgram
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsProgramName]))
                {
                    return HttpContext.Current.Request[qsProgramName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [bundle_name]   qsBundle_nameName & qsBundle_name
        public const string qsBundle_nameName = "bundle_name";
        public static string qsBundle_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsBundle_nameName]))
                {
                    return HttpContext.Current.Request[qsBundle_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [retention_rebate]   qsRetention_rebateName & qsRetention_rebate
        public const string qsRetention_rebateName = "retention_rebate";
        public static System.Nullable<int> qsRetention_rebate
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsRetention_rebateName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsRetention_rebateName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [normal_rebate]   qsNormal_rebateName & qsNormal_rebate
        public const string qsNormal_rebateName = "normal_rebate";
        public static System.Nullable<int> qsNormal_rebate
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsNormal_rebateName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsNormal_rebateName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [rate_plan]   qsRate_planName & qsRate_plan
        public const string qsRate_planName = "rate_plan";
        public static string qsRate_plan
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRate_planName]))
                {
                    return HttpContext.Current.Request[qsRate_planName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [sdate]   qsSdateName & qsSdate
        public const string qsSdateName = "sdate";
        public static System.Nullable<DateTime> qsSdate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsSdateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsSdateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsSdateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [type]   qsTypeName & qsType
        public const string qsTypeName = "type";
        public static string qsType
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTypeName]))
                {
                    return HttpContext.Current.Request[qsTypeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [call_list_type]   qsCall_list_typeName & qsCall_list_type
        public const string qsCall_list_typeName = "call_list_type";
        public static string qsCall_list_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCall_list_typeName]))
                {
                    return HttpContext.Current.Request[qsCall_list_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [return_date]   qsReturn_dateName & qsReturn_date
        public const string qsReturn_dateName = "return_date";
        public static System.Nullable<DateTime> qsReturn_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsReturn_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsReturn_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsReturn_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [center]   qsCenterName & qsCenter
        public const string qsCenterName = "center";
        public static string qsCenter
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCenterName]))
                {
                    return HttpContext.Current.Request[qsCenterName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [expiry_month]   qsExpiry_monthName & qsExpiry_month
        public const string qsExpiry_monthName = "expiry_month";
        public static string qsExpiry_month
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExpiry_monthName]))
                {
                    return HttpContext.Current.Request[qsExpiry_monthName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [upload_date]   qsUpload_dateName & qsUpload_date
        public const string qsUpload_dateName = "upload_date";
        public static System.Nullable<DateTime> qsUpload_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsUpload_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsUpload_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsUpload_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [call_list_size]   qsCall_list_sizeName & qsCall_list_size
        public const string qsCall_list_sizeName = "call_list_size";
        public static string qsCall_list_size
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCall_list_sizeName]))
                {
                    return HttpContext.Current.Request[qsCall_list_sizeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [program_name]   qsProgram_nameName & qsProgram_name
        public const string qsProgram_nameName = "program_name";
        public static string qsProgram_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsProgram_nameName]))
                {
                    return HttpContext.Current.Request[qsProgram_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [program_id]   qsProgram_idName & qsProgram_id
        public const string qsProgram_idName = "program_id";
        public static System.Nullable<int> qsProgram_id
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsProgram_idName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsProgram_idName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [gp]   qsGpName & qsGp
        public const string qsGpName = "gp";
        public static string qsGp
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGpName]))
                {
                    return HttpContext.Current.Request[qsGpName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [teamcode]   qsTeamcodeName & qsTeamcode
        public const string qsTeamcodeName = "teamcode";
        public static string qsTeamcode
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTeamcodeName]))
                {
                    return HttpContext.Current.Request[qsTeamcodeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [salesmancode]   qsSalesmancodeName & qsSalesmancode
        public const string qsSalesmancodeName = "salesmancode";
        public static string qsSalesmancode
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSalesmancodeName]))
                {
                    return HttpContext.Current.Request[qsSalesmancodeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [staff_no]   qsStaff_noName & qsStaff_no
        public const string qsStaff_noName = "staff_no";
        public static string qsStaff_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStaff_noName]))
                {
                    return HttpContext.Current.Request[qsStaff_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [hs_model]   qsHs_modelName & qsHs_model
        public const string qsHs_modelName = "hs_model";
        public static string qsHs_model
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsHs_modelName]))
                {
                    return HttpContext.Current.Request[qsHs_modelName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [last_stock]   qsLast_stockName & qsLast_stock
        public const string qsLast_stockName = "last_stock";
        public static System.Nullable<bool> qsLast_stock
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsLast_stockName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsLast_stockName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [item_code]   qsItem_codeName & qsItem_code
        public const string qsItem_codeName = "item_code";
        public static string qsItem_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsItem_codeName]))
                {
                    return HttpContext.Current.Request[qsItem_codeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [quota]   qsQuotaName & qsQuota
        public const string qsQuotaName = "quota";
        public static string qsQuota
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsQuotaName]))
                {
                    return HttpContext.Current.Request[qsQuotaName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [EDATE]   qsEDATEName & qsEDATE
        public const string qsEDATEName = "EDATE";
        public static System.Nullable<DateTime> qsEDATE
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsEDATEName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsEDATEName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsEDATEName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [FREEZE]   qsFREEZEName & qsFREEZE
        public const string qsFREEZEName = "FREEZE";
        public static System.Nullable<bool> qsFREEZE
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsFREEZEName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsFREEZEName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [SDATE]   qsSDATEName & qsSDATE
        public const string qsSDATEName = "SDATE";
        public static System.Nullable<DateTime> qsSDATE
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsSDATEName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsSDATEName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsSDATEName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [TEAMCODE]   qsTEAMCODEName & qsTEAMCODE
        public const string qsTEAMCODEName = "TEAMCODE";
        public static string qsTEAMCODE
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTEAMCODEName]))
                {
                    return HttpContext.Current.Request[qsTEAMCODEName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [next_bill]   qsNext_billName & qsNext_bill
        public const string qsNext_billName = "next_bill";
        public static System.Nullable<bool> qsNext_bill
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsNext_billName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsNext_billName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [ao_add]   qsAo_addName & qsAo_add
        public const string qsAo_addName = "ao_add";
        public static System.Nullable<bool> qsAo_add
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAo_addName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAo_addName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [mon]   qsMonName & qsMon
        public const string qsMonName = "mon";
        public static System.Nullable<int> qsMon
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsMonName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsMonName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [free_mon]   qsFree_monName & qsFree_mon
        public const string qsFree_monName = "free_mon";
        public static string qsFree_mon
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFree_monName]))
                {
                    return HttpContext.Current.Request[qsFree_monName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [order_status]   qsOrder_statusName & qsOrder_status
        public const string qsOrder_statusName = "order_status";
        public static string qsOrder_status
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrder_statusName]))
                {
                    return HttpContext.Current.Request[qsOrder_statusName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        
        #region [sent_again]   qsSent_againName & qsSent_again
        public const string qsSent_againName = "sent_again";
        public static string qsSent_again
        {
            get
            {
                if (Func.IsString(HttpContext.Current.Request[qsSent_againName]))
                {
                    return HttpContext.Current.Request[qsSent_againName].ToString();
                }
                return null;
            }
        }
        #endregion

        #region [email_date]   qsEmail_dateName & qsEmail_date
        public const string qsEmail_dateName = "email_date";
        public static System.Nullable<DateTime> qsEmail_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsEmail_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsEmail_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsEmail_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [retrieve_cnt]   qsRetrieve_cntName & qsRetrieve_cnt
        public const string qsRetrieve_cntName = "retrieve_cnt";
        public static System.Nullable<int> qsRetrieve_cnt
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsRetrieve_cntName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsRetrieve_cntName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [retrieve_sn]   qsRetrieve_snName & qsRetrieve_sn
        public const string qsRetrieve_snName = "retrieve_sn";
        public static string qsRetrieve_sn
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRetrieve_snName]))
                {
                    return HttpContext.Current.Request[qsRetrieve_snName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [idd_vas]   qsIdd_vasName & qsIdd_vas
        public const string qsIdd_vasName = "idd_vas";
        public static string qsIdd_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsIdd_vasName]))
                {
                    return HttpContext.Current.Request[qsIdd_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [fallout_reason]   qsFallout_reasonName & qsFallout_reason
        public const string qsFallout_reasonName = "fallout_reason";
        public static string qsFallout_reason
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFallout_reasonName]))
                {
                    return HttpContext.Current.Request[qsFallout_reasonName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [fallout_remark]   qsFallout_remarkName & qsFallout_remark
        public const string qsFallout_remarkName = "fallout_remark";
        public static string qsFallout_remark
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFallout_remarkName]))
                {
                    return HttpContext.Current.Request[qsFallout_remarkName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [fallout_reply]   qsFallout_replyName & qsFallout_reply
        public const string qsFallout_replyName = "fallout_reply";
        public static string qsFallout_reply
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFallout_replyName]))
                {
                    return HttpContext.Current.Request[qsFallout_replyName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [report_type]   qsReport_typeName & qsReport_type
        public const string qsReport_typeName = "report_type";
        public static string qsReport_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsReport_typeName]))
                {
                    return HttpContext.Current.Request[qsReport_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [reactive_sn]   qsReactive_snName & qsReactive_sn
        public const string qsReactive_snName = "reactive_sn";
        public static string qsReactive_sn
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsReactive_snName]))
                {
                    return HttpContext.Current.Request[qsReactive_snName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ext_place_tel]   qsExt_place_telName & qsExt_place_tel
        public const string qsExt_place_telName = "ext_place_tel";
        public static string qsExt_place_tel
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExt_place_telName]))
                {
                    return HttpContext.Current.Request[qsExt_place_telName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [reactive_date]   qsReactive_dateName & qsReactive_date
        public const string qsReactive_dateName = "reactive_date";
        public static System.Nullable<DateTime> qsReactive_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsReactive_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsReactive_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsReactive_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [retrieve_date]   qsRetrieve_dateName & qsRetrieve_date
        public const string qsRetrieve_dateName = "retrieve_date";
        public static System.Nullable<DateTime> qsRetrieve_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsRetrieve_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsRetrieve_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsRetrieve_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [vas_name]   qsVas_nameName & qsVas_name
        public const string qsVas_nameName = "vas_name";
        public static string qsVas_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVas_nameName]))
                {
                    return HttpContext.Current.Request[qsVas_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vas_chi_name]   qsVas_chi_nameName & qsVas_chi_name
        public const string qsVas_chi_nameName = "vas_chi_name";
        public static string qsVas_chi_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVas_chi_nameName]))
                {
                    return HttpContext.Current.Request[qsVas_chi_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [accessory_price]   qsAccessory_priceName & qsAccessory_price
        public const string qsAccessory_priceName = "accessory_price";
        public static string qsAccessory_price
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAccessory_priceName]))
                {
                    return HttpContext.Current.Request[qsAccessory_priceName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [accessory_desc]   qsAccessory_descName & qsAccessory_desc
        public const string qsAccessory_descName = "accessory_desc";
        public static string qsAccessory_desc
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAccessory_descName]))
                {
                    return HttpContext.Current.Request[qsAccessory_descName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [accessory_code]   qsAccessory_codeName & qsAccessory_code
        public const string qsAccessory_codeName = "accessory_code";
        public static string qsAccessory_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAccessory_codeName]))
                {
                    return HttpContext.Current.Request[qsAccessory_codeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [channel]   qsChannelName & qsChannel
        public const string qsChannelName = "channel";
        public static string qsChannel
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsChannelName]))
                {
                    return HttpContext.Current.Request[qsChannelName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [hs_model_name]   qsHs_model_nameName & qsHs_model_name
        public const string qsHs_model_nameName = "hs_model_name";
        public static string qsHs_model_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsHs_model_nameName]))
                {
                    return HttpContext.Current.Request[qsHs_model_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [trade_field]   qsTrade_fieldName & qsTrade_field
        public const string qsTrade_fieldName = "trade_field";
        public static string qsTrade_field
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTrade_fieldName]))
                {
                    return HttpContext.Current.Request[qsTrade_fieldName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [rebate]   qsRebateName & qsRebate
        public const string qsRebateName = "rebate";
        public static string qsRebate
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRebateName]))
                {
                    return HttpContext.Current.Request[qsRebateName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [retention_type]   qsRetention_typeName & qsRetention_type
        public const string qsRetention_typeName = "retention_type";
        public static string qsRetention_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRetention_typeName]))
                {
                    return HttpContext.Current.Request[qsRetention_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [extra_offer]   qsExtra_offerName & qsExtra_offer
        public const string qsExtra_offerName = "extra_offer";
        public static string qsExtra_offer
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExtra_offerName]))
                {
                    return HttpContext.Current.Request[qsExtra_offerName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [con_per]   qsCon_perName & qsCon_per
        public const string qsCon_perName = "con_per";
        public static string qsCon_per
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCon_perName]))
                {
                    return HttpContext.Current.Request[qsCon_perName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [premium]   qsPremiumName & qsPremium
        public const string qsPremiumName = "premium";
        public static string qsPremium
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPremiumName]))
                {
                    return HttpContext.Current.Request[qsPremiumName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [cancel_renew]   qsCancel_renewName & qsCancel_renew
        public const string qsCancel_renewName = "cancel_renew";
        public static string qsCancel_renew
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCancel_renewName]))
                {
                    return HttpContext.Current.Request[qsCancel_renewName].ToString();
                }
                return null;
            }
        }
        #endregion
        #region [ob_early]   qsOb_earlyName & qsOb_early
        public const string qsOb_earlyName = "ob_early";
        public static string qsOb_early
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOb_earlyName]))
                {
                    return HttpContext.Current.Request[qsOb_earlyName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [plan_fee]   qsPlan_feeName & qsPlan_fee
        public const string qsPlan_feeName = "plan_fee";
        public static string qsPlan_fee
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPlan_feeName]))
                {
                    return HttpContext.Current.Request[qsPlan_feeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [OWNER_SN]   qsOWNER_SNName & qsOWNER_SN
        public const string qsOWNER_SNName = "OWNER_SN";
        public static string qsOWNER_SN
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOWNER_SNName]))
                {
                    return HttpContext.Current.Request[qsOWNER_SNName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [TYPE]   qsTYPEName & qsTYPE
        public const string qsTYPEName = "TYPE";
        public static string qsTYPE
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTYPEName]))
                {
                    return HttpContext.Current.Request[qsTYPEName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [GROUPING]   qsGROUPINGName & qsGROUPING
        public const string qsGROUPINGName = "GROUPING";
        public static string qsGROUPING
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGROUPINGName]))
                {
                    return HttpContext.Current.Request[qsGROUPINGName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ORDER_ID]   qsORDER_IDName & qsORDER_ID
        public const string qsORDER_IDName = "ORDER_ID";
        public static System.Nullable<int> qsORDER_ID
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsORDER_IDName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsORDER_IDName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [REC_NO]   qsREC_NOName & qsREC_NO
        public const string qsREC_NOName = "REC_NO";
        public static string qsREC_NO
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsREC_NOName]))
                {
                    return HttpContext.Current.Request[qsREC_NOName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [BOC_ID]   qsBOC_IDName & qsBOC_ID
        public const string qsBOC_IDName = "BOC_ID";
        public static System.Nullable<int> qsBOC_ID
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsBOC_IDName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsBOC_IDName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [r_offer]   qsR_offerName & qsR_offer
        public const string qsR_offerName = "r_offer";
        public static string qsR_offer
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsR_offerName]))
                {
                    return HttpContext.Current.Request[qsR_offerName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [extra_rebate_amount]   qsExtra_rebate_amountName & qsExtra_rebate_amount
        public const string qsExtra_rebate_amountName = "extra_rebate_amount";
        public static string qsExtra_rebate_amount
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExtra_rebate_amountName]))
                {
                    return HttpContext.Current.Request[qsExtra_rebate_amountName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [amount]   qsAmountName & qsAmount
        public const string qsAmountName = "amount";
        public static string qsAmount
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAmountName]))
                {
                    return HttpContext.Current.Request[qsAmountName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [s_premium]   qsS_premiumName & qsS_premium
        public const string qsS_premiumName = "s_premium";
        public static string qsS_premium
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsS_premiumName]))
                {
                    return HttpContext.Current.Request[qsS_premiumName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [tier]   qsTierName & qsTier
        public const string qsTierName = "tier";
        public static string qsTier
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTierName]))
                {
                    return HttpContext.Current.Request[qsTierName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [extra_rebate]   qsExtra_rebateName & qsExtra_rebate
        public const string qsExtra_rebateName = "extra_rebate";
        public static string qsExtra_rebate
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExtra_rebateName]))
                {
                    return HttpContext.Current.Request[qsExtra_rebateName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [rebate_amount]   qsRebate_amountName & qsRebate_amount
        public const string qsRebate_amountName = "rebate_amount";
        public static string qsRebate_amount
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRebate_amountName]))
                {
                    return HttpContext.Current.Request[qsRebate_amountName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [access_right]   qsAccess_rightName & qsAccess_right
        public const string qsAccess_rightName = "access_right";
        public static string qsAccess_right
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAccess_rightName]))
                {
                    return HttpContext.Current.Request[qsAccess_rightName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [message]   qsMessageName & qsMessage
        public const string qsMessageName = "message";
        public static string qsMessage
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMessageName]))
                {
                    return HttpContext.Current.Request[qsMessageName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [subject]   qsSubjectName & qsSubject
        public const string qsSubjectName = "subject";
        public static string qsSubject
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSubjectName]))
                {
                    return HttpContext.Current.Request[qsSubjectName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [cancelled]   qsCancelledName & qsCancelled
        public const string qsCancelledName = "cancelled";
        public static string qsCancelled
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCancelledName]))
                {
                    return HttpContext.Current.Request[qsCancelledName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [Mobile_no]   qsMobile_noName & qsMobile_no
        public const string qsMobile_noName = "Mobile_no";
        public static string qsMobile_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMobile_noName]))
                {
                    return HttpContext.Current.Request[qsMobile_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [referenceNo]   qsReferenceNoName & qsReferenceNo
        public const string qsReferenceNoName = "referenceNo";
        public static string qsReferenceNo
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsReferenceNoName]))
                {
                    return HttpContext.Current.Request[qsReferenceNoName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [Agree_no]   qsAgree_noName & qsAgree_no
        public const string qsAgree_noName = "Agree_no";
        public static System.Nullable<int> qsAgree_no
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsAgree_noName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsAgree_noName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [SalesManCode]   qsSalesManCodeName & qsSalesManCode
        public const string qsSalesManCodeName = "SalesManCode";
        public static string qsSalesManCode
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSalesManCodeName]))
                {
                    return HttpContext.Current.Request[qsSalesManCodeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [staffNo]   qsStaffNoName & qsStaffNo
        public const string qsStaffNoName = "staffNo";
        public static string qsStaffNo
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStaffNoName]))
                {
                    return HttpContext.Current.Request[qsStaffNoName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [pending]   qsPendingName & qsPending
        public const string qsPendingName = "pending";
        public static string qsPending
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPendingName]))
                {
                    return HttpContext.Current.Request[qsPendingName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [staffName]   qsStaffNameName & qsStaffName
        public const string qsStaffNameName = "staffName";
        public static string qsStaffName
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStaffNameName]))
                {
                    return HttpContext.Current.Request[qsStaffNameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [pend_date]   qsPend_dateName & qsPend_date
        public const string qsPend_dateName = "pend_date";
        public static System.Nullable<DateTime> qsPend_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsPend_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsPend_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsPend_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [CREATED_BY]   qsCREATED_BYName & qsCREATED_BY
        public const string qsCREATED_BYName = "CREATED_BY";
        public static string qsCREATED_BY
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCREATED_BYName]))
                {
                    return HttpContext.Current.Request[qsCREATED_BYName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [actual_del_date]   qsActual_del_dateName & qsActual_del_date
        public const string qsActual_del_dateName = "actual_del_date";
        public static System.Nullable<DateTime> qsActual_del_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsActual_del_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsActual_del_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsActual_del_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [fail_reason]   qsFail_reasonName & qsFail_reason
        public const string qsFail_reasonName = "fail_reason";
        public static string qsFail_reason
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFail_reasonName]))
                {
                    return HttpContext.Current.Request[qsFail_reasonName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion

        #region [basic]   qsBasicName & qsBasic
        public const string qsBasicName = "basic";
        public static System.Nullable<int> qsBasic
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsBasicName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsBasicName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [steptype]   qsSteptypeName & qsSteptype
        public const string qsSteptypeName = "steptype";
        public static string qsSteptype
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSteptypeName]))
                {
                    return HttpContext.Current.Request[qsSteptypeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [cmrid]   qsCmridName & qsCmrid
        public const string qsCmridName = "cmrid";
        public static string qsCmrid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCmridName]))
                {
                    return HttpContext.Current.Request[qsCmridName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [contract_s]   qsContract_sName & qsContract_s
        public const string qsContract_sName = "contract_s";
        public static System.Nullable<DateTime> qsContract_s
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsContract_sName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsContract_sName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsContract_sName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [salesman_code]   qsSalesman_codeName & qsSalesman_code
        public const string qsSalesman_codeName = "salesman_code";
        public static string qsSalesman_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSalesman_codeName]))
                {
                    return HttpContext.Current.Request[qsSalesman_codeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [stream]   qsStreamName & qsStream
        public const string qsStreamName = "stream";
        public static string qsStream
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStreamName]))
                {
                    return HttpContext.Current.Request[qsStreamName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [joindate]   qsJoindateName & qsJoindate
        public const string qsJoindateName = "joindate";
        public static System.Nullable<DateTime> qsJoindate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsJoindateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsJoindateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsJoindateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [shift]   qsShiftName & qsShift
        public const string qsShiftName = "shift";
        public static string qsShift
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsShiftName]))
                {
                    return HttpContext.Current.Request[qsShiftName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [internship]   qsInternshipName & qsInternship
        public const string qsInternshipName = "internship";
        public static System.Nullable<bool> qsInternship
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsInternshipName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsInternshipName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [lwdate]   qsLwdateName & qsLwdate
        public const string qsLwdateName = "lwdate";
        public static System.Nullable<DateTime> qsLwdate
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsLwdateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsLwdateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsLwdateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [staff_no2]   qsStaff_no2Name & qsStaff_no2
        public const string qsStaff_no2Name = "staff_no2";
        public static string qsStaff_no2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStaff_no2Name]))
                {
                    return HttpContext.Current.Request[qsStaff_no2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [centre]   qsCentreName & qsCentre
        public const string qsCentreName = "centre";
        public static string qsCentre
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCentreName]))
                {
                    return HttpContext.Current.Request[qsCentreName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [Language]   qsLanguageName & qsLanguage
        public const string qsLanguageName = "Language";
        public static string qsLanguage
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsLanguageName]))
                {
                    return HttpContext.Current.Request[qsLanguageName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [staff_name]   qsStaff_nameName & qsStaff_name
        public const string qsStaff_nameName = "staff_name";
        public static string qsStaff_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStaff_nameName]))
                {
                    return HttpContext.Current.Request[qsStaff_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [otc]   qsOtcName & qsOtc
        public const string qsOtcName = "otc";
        public static System.Nullable<int> qsOtc
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsOtcName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsOtcName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [skill]   qsSkillName & qsSkill
        public const string qsSkillName = "skill";
        public static string qsSkill
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSkillName]))
                {
                    return HttpContext.Current.Request[qsSkillName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [freeze]   qsFreezeName & qsFreeze
        public const string qsFreezeName = "freeze";
        public static System.Nullable<bool> qsFreeze
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsFreezeName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsFreezeName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [contract_e]   qsContract_eName & qsContract_e
        public const string qsContract_eName = "contract_e";
        public static System.Nullable<DateTime> qsContract_e
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsContract_eName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsContract_eName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsContract_eName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [staff_type]   qsStaff_typeName & qsStaff_type
        public const string qsStaff_typeName = "staff_type";
        public static string qsStaff_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStaff_typeName]))
                {
                    return HttpContext.Current.Request[qsStaff_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [steplevel]   qsSteplevelName & qsSteplevel
        public const string qsSteplevelName = "steplevel";
        public static string qsSteplevel
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSteplevelName]))
                {
                    return HttpContext.Current.Request[qsSteplevelName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ccc]   qsCccName & qsCcc
        public const string qsCccName = "ccc";
        public static string qsCcc
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCccName]))
                {
                    return HttpContext.Current.Request[qsCccName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [pay_code]   qsPay_codeName & qsPay_code
        public const string qsPay_codeName = "pay_code";
        public static string qsPay_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPay_codeName]))
                {
                    return HttpContext.Current.Request[qsPay_codeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_code]   qsGift_codeName & qsGift_code
        public const string qsGift_codeName = "gift_code";
        public static string qsGift_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_codeName]))
                {
                    return HttpContext.Current.Request[qsGift_codeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_desc]   qsGift_descName & qsGift_desc
        public const string qsGift_descName = "gift_desc";
        public static string qsGift_desc
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_descName]))
                {
                    return HttpContext.Current.Request[qsGift_descName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_gp]   qsGift_gpName & qsGift_gp
        public const string qsGift_gpName = "gift_gp";
        public static string qsGift_gp
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_gpName]))
                {
                    return HttpContext.Current.Request[qsGift_gpName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [RECORD_ID]   qsRECORD_IDName & qsRECORD_ID
        public const string qsRECORD_IDName = "RECORD_ID";
        public static byte[] qsRECORD_ID
        {
            get
            {
                if (Func.IsParseByteArr(HttpContext.Current.Request[qsRECORD_IDName]))
                {
                    return (new System.Text.ASCIIEncoding()).GetBytes(HttpContext.Current.Request[qsRECORD_IDName]);
                }
                return null;
            }
        }
        #endregion
        #region [SALESMAN_ID]   qsSALESMAN_IDName & qsSALESMAN_ID
        public const string qsSALESMAN_IDName = "SALESMAN_ID";
        public static byte[] qsSALESMAN_ID
        {
            get
            {
                if (Func.IsParseByteArr(HttpContext.Current.Request[qsSALESMAN_IDName]))
                {
                    return (new System.Text.ASCIIEncoding()).GetBytes(HttpContext.Current.Request[qsSALESMAN_IDName]);
                }
                return null;
            }
        }
        #endregion
        #region [FALLOUT_DATE]   qsFALLOUT_DATEName & qsFALLOUT_DATE
        public const string qsFALLOUT_DATEName = "FALLOUT_DATE";
        public static System.Nullable<DateTime> qsFALLOUT_DATE
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsFALLOUT_DATEName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsFALLOUT_DATEName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsFALLOUT_DATEName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [SALESMAN_CODE]   qsSALESMAN_CODEName & qsSALESMAN_CODE
        public const string qsSALESMAN_CODEName = "SALESMAN_CODE";
        public static byte[] qsSALESMAN_CODE
        {
            get
            {
                if (Func.IsParseByteArr(HttpContext.Current.Request[qsSALESMAN_CODEName]))
                {
                    return (new System.Text.ASCIIEncoding()).GetBytes(HttpContext.Current.Request[qsSALESMAN_CODEName]);
                }
                return null;
            }
        }
        #endregion
        #region [STATUS]   qsSTATUSName & qsSTATUS
        public const string qsSTATUSName = "STATUS";
        public static byte[] qsSTATUS
        {
            get
            {
                if (Func.IsParseByteArr(HttpContext.Current.Request[qsSTATUSName]))
                {
                    return (new System.Text.ASCIIEncoding()).GetBytes(HttpContext.Current.Request[qsSTATUSName]);
                }
                return null;
            }
        }
        #endregion
        #region [MOBILE_NO]   qsMOBILE_NOName & qsMOBILE_NO
        public const string qsMOBILE_NOName = "MOBILE_NO";
        public static byte[] qsMOBILE_NO
        {
            get
            {
                if (Func.IsParseByteArr(HttpContext.Current.Request[qsMOBILE_NOName]))
                {
                    return (new System.Text.ASCIIEncoding()).GetBytes(HttpContext.Current.Request[qsMOBILE_NOName]);
                }
                return null;
            }
        }
        #endregion
        #region [sm_no]   qsSm_noName & qsSm_no
        public const string qsSm_noName = "sm_no";
        public static byte[] qsSm_no
        {
            get
            {
                if (Func.IsParseByteArr(HttpContext.Current.Request[qsSm_noName]))
                {
                    return (new System.Text.ASCIIEncoding()).GetBytes(HttpContext.Current.Request[qsSm_noName]);
                }
                return null;
            }
        }
        #endregion
        #region [payment]   qsPaymentName & qsPayment
        public const string qsPaymentName = "payment";
        public static string qsPayment
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPaymentName]))
                {
                    return HttpContext.Current.Request[qsPaymentName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [rebate_gp]   qsRebate_gpName & qsRebate_gp
        public const string qsRebate_gpName = "rebate_gp";
        public static string qsRebate_gp
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRebate_gpName]))
                {
                    return HttpContext.Current.Request[qsRebate_gpName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vas_value]   qsVas_valueName & qsVas_value
        public const string qsVas_valueName = "vas_value";
        public static string qsVas_value
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVas_valueName]))
                {
                    return HttpContext.Current.Request[qsVas_valueName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [multi]   qsMultiName & qsMulti
        public const string qsMultiName = "multi";
        public static System.Nullable<bool> qsMulti
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsMultiName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsMultiName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [org_fee]   qsOrg_feeName & qsOrg_fee
        public const string qsOrg_feeName = "org_fee";
        public static string qsOrg_fee
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrg_feeName]))
                {
                    return HttpContext.Current.Request[qsOrg_feeName].ToString();
                }
                return null;
            }
        }
        #endregion
        #region [location]   qsLocationName & qsLocation
        public const string qsLocationName = "location";
        public static string qsLocation
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsLocationName]))
                {
                    return HttpContext.Current.Request[qsLocationName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [pm7_9]   qsPm7_9Name & qsPm7_9
        public const string qsPm7_9Name = "pm7_9";
        public static System.Nullable<bool> qsPm7_9
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsPm7_9Name]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsPm7_9Name].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [pm]   qsPmName & qsPm
        public const string qsPmName = "pm";
        public static System.Nullable<bool> qsPm
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsPmName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsPmName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [pm6_8]   qsPm6_8Name & qsPm6_8
        public const string qsPm6_8Name = "pm6_8";
        public static System.Nullable<bool> qsPm6_8
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsPm6_8Name]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsPm6_8Name].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [am]   qsAmName & qsAm
        public const string qsAmName = "am";
        public static System.Nullable<bool> qsAm
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsAmName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsAmName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [delivery_fee]   qsDelivery_feeName & qsDelivery_fee
        public const string qsDelivery_feeName = "delivery_fee";
        public static System.Nullable<int> qsDelivery_fee
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsDelivery_feeName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsDelivery_feeName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [fo_reason]   qsFo_reasonName & qsFo_reason
        public const string qsFo_reasonName = "fo_reason";
        public static string qsFo_reason
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFo_reasonName]))
                {
                    return HttpContext.Current.Request[qsFo_reasonName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [follow_by]   qsFollow_byName & qsFollow_by
        public const string qsFollow_byName = "follow_by";
        public static string qsFollow_by
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFollow_byName]))
                {
                    return HttpContext.Current.Request[qsFollow_byName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ord_place_hkid]   qsOrd_place_hkidName & qsOrd_place_hkid
        public const string qsOrd_place_hkidName = "ord_place_hkid";
        public static string qsOrd_place_hkid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrd_place_hkidName]))
                {
                    return HttpContext.Current.Request[qsOrd_place_hkidName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [con_eff_date]   qsCon_eff_dateName & qsCon_eff_date
        public const string qsCon_eff_dateName = "con_eff_date";
        public static System.Nullable<DateTime> qsCon_eff_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsCon_eff_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsCon_eff_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsCon_eff_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [ord_place_by]   qsOrd_place_byName & qsOrd_place_by
        public const string qsOrd_place_byName = "ord_place_by";
        public static string qsOrd_place_by
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrd_place_byName]))
                {
                    return HttpContext.Current.Request[qsOrd_place_byName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_imei4]   qsGift_imei4Name & qsGift_imei4
        public const string qsGift_imei4Name = "gift_imei4";
        public static string qsGift_imei4
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_imei4Name]))
                {
                    return HttpContext.Current.Request[qsGift_imei4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [now_mobile_vas]   qsNow_mobile_vasName & qsNow_mobile_vas
        public const string qsNow_mobile_vasName = "now_mobile_vas";
        public static string qsNow_mobile_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsNow_mobile_vasName]))
                {
                    return HttpContext.Current.Request[qsNow_mobile_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [imei_no]   qsImei_noName & qsImei_no
        public const string qsImei_noName = "imei_no";
        public static string qsImei_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsImei_noName]))
                {
                    return HttpContext.Current.Request[qsImei_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [fin_vas]   qsFin_vasName & qsFin_vas
        public const string qsFin_vasName = "fin_vas";
        public static string qsFin_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFin_vasName]))
                {
                    return HttpContext.Current.Request[qsFin_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [m_card_exp_month]   qsM_card_exp_monthName & qsM_card_exp_month
        public const string qsM_card_exp_monthName = "m_card_exp_month";
        public static string qsM_card_exp_month
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_card_exp_monthName]))
                {
                    return HttpContext.Current.Request[qsM_card_exp_monthName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [min_vas200]   qsMin_vas200Name & qsMin_vas200
        public const string qsMin_vas200Name = "min_vas200";
        public static string qsMin_vas200
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_vas200Name]))
                {
                    return HttpContext.Current.Request[qsMin_vas200Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_code3]   qsGift_code3Name & qsGift_code3
        public const string qsGift_code3Name = "gift_code3";
        public static string qsGift_code3
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_code3Name]))
                {
                    return HttpContext.Current.Request[qsGift_code3Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [m_card_exp_year]   qsM_card_exp_yearName & qsM_card_exp_year
        public const string qsM_card_exp_yearName = "m_card_exp_year";
        public static string qsM_card_exp_year
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_card_exp_yearName]))
                {
                    return HttpContext.Current.Request[qsM_card_exp_yearName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [extn]   qsExtnName & qsExtn
        public const string qsExtnName = "extn";
        public static string qsExtn
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExtnName]))
                {
                    return HttpContext.Current.Request[qsExtnName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [net_vas]   qsNet_vasName & qsNet_vas
        public const string qsNet_vasName = "net_vas";
        public static string qsNet_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsNet_vasName]))
                {
                    return HttpContext.Current.Request[qsNet_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_desc4]   qsGift_desc4Name & qsGift_desc4
        public const string qsGift_desc4Name = "gift_desc4";
        public static string qsGift_desc4
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_desc4Name]))
                {
                    return HttpContext.Current.Request[qsGift_desc4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vmin_vas]   qsVmin_vasName & qsVmin_vas
        public const string qsVmin_vasName = "vmin_vas";
        public static string qsVmin_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVmin_vasName]))
                {
                    return HttpContext.Current.Request[qsVmin_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ord_place_rel]   qsOrd_place_relName & qsOrd_place_rel
        public const string qsOrd_place_relName = "ord_place_rel";
        public static string qsOrd_place_rel
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrd_place_relName]))
                {
                    return HttpContext.Current.Request[qsOrd_place_relName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [accessory_imei]   qsAccessory_imeiName & qsAccessory_imei
        public const string qsAccessory_imeiName = "accessory_imei";
        public static string qsAccessory_imei
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAccessory_imeiName]))
                {
                    return HttpContext.Current.Request[qsAccessory_imeiName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [d_address]   qsD_addressName & qsD_address
        public const string qsD_addressName = "d_address";
        public static string qsD_address
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_addressName]))
                {
                    return HttpContext.Current.Request[qsD_addressName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [action_date]   qsAction_dateName & qsAction_date
        public const string qsAction_dateName = "action_date";
        public static System.Nullable<DateTime> qsAction_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsAction_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsAction_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsAction_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [cust_type]   qsCust_typeName & qsCust_type
        public const string qsCust_typeName = "cust_type";
        public static string qsCust_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCust_typeName]))
                {
                    return HttpContext.Current.Request[qsCust_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [org_ftg]   qsOrg_ftgName & qsOrg_ftg
        public const string qsOrg_ftgName = "org_ftg";
        public static string qsOrg_ftg
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrg_ftgName]))
                {
                    return HttpContext.Current.Request[qsOrg_ftgName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [plan_eff_date]   qsPlan_eff_dateName & qsPlan_eff_date
        public const string qsPlan_eff_dateName = "plan_eff_date";
        public static System.Nullable<DateTime> qsPlan_eff_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsPlan_eff_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsPlan_eff_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsPlan_eff_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [status_by_cs_admin]   qsStatus_by_cs_adminName & qsStatus_by_cs_admin
        public const string qsStatus_by_cs_adminName = "status_by_cs_admin";
        public static string qsStatus_by_cs_admin
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsStatus_by_cs_adminName]))
                {
                    return HttpContext.Current.Request[qsStatus_by_cs_adminName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [min_vas400]   qsMin_vas400Name & qsMin_vas400
        public const string qsMin_vas400Name = "min_vas400";
        public static string qsMin_vas400
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_vas400Name]))
                {
                    return HttpContext.Current.Request[qsMin_vas400Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [lob_ac]   qsLob_acName & qsLob_ac
        public const string qsLob_acName = "lob_ac";
        public static string qsLob_ac
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsLob_acName]))
                {
                    return HttpContext.Current.Request[qsLob_acName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [foot_vas]   qsFoot_vasName & qsFoot_vas
        public const string qsFoot_vasName = "foot_vas";
        public static string qsFoot_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsFoot_vasName]))
                {
                    return HttpContext.Current.Request[qsFoot_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [card_no]   qsCard_noName & qsCard_no
        public const string qsCard_noName = "card_no";
        public static string qsCard_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_noName]))
                {
                    return HttpContext.Current.Request[qsCard_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vm_vas]   qsVm_vasName & qsVm_vas
        public const string qsVm_vasName = "vm_vas";
        public static string qsVm_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVm_vasName]))
                {
                    return HttpContext.Current.Request[qsVm_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [existing_contract_end_date]   qsExisting_contract_end_dateName & qsExisting_contract_end_date
        public const string qsExisting_contract_end_dateName = "existing_contract_end_date";
        public static string qsExisting_contract_end_date
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExisting_contract_end_dateName]))
                {
                    return HttpContext.Current.Request[qsExisting_contract_end_dateName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [card_exp_month]   qsCard_exp_monthName & qsCard_exp_month
        public const string qsCard_exp_monthName = "card_exp_month";
        public static string qsCard_exp_month
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_exp_monthName]))
                {
                    return HttpContext.Current.Request[qsCard_exp_monthName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [m_card_holder2]   qsM_card_holder2Name & qsM_card_holder2
        public const string qsM_card_holder2Name = "m_card_holder2";
        public static string qsM_card_holder2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_card_holder2Name]))
                {
                    return HttpContext.Current.Request[qsM_card_holder2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_code2]   qsGift_code2Name & qsGift_code2
        public const string qsGift_code2Name = "gift_code2";
        public static string qsGift_code2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_code2Name]))
                {
                    return HttpContext.Current.Request[qsGift_code2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [cust_staff_no]   qsCust_staff_noName & qsCust_staff_no
        public const string qsCust_staff_noName = "cust_staff_no";
        public static string qsCust_staff_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCust_staff_noName]))
                {
                    return HttpContext.Current.Request[qsCust_staff_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [now_hd_vas]   qsNow_hd_vasName & qsNow_hd_vas
        public const string qsNow_hd_vasName = "now_hd_vas";
        public static string qsNow_hd_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsNow_hd_vasName]))
                {
                    return HttpContext.Current.Request[qsNow_hd_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [min_vas300]   qsMin_vas300Name & qsMin_vas300
        public const string qsMin_vas300Name = "min_vas300";
        public static string qsMin_vas300
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_vas300Name]))
                {
                    return HttpContext.Current.Request[qsMin_vas300Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [s_premium2]   qsS_premium2Name & qsS_premium2
        public const string qsS_premium2Name = "s_premium2";
        public static string qsS_premium2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsS_premium2Name]))
                {
                    return HttpContext.Current.Request[qsS_premium2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [contact_person]   qsContact_personName & qsContact_person
        public const string qsContact_personName = "contact_person";
        public static string qsContact_person
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsContact_personName]))
                {
                    return HttpContext.Current.Request[qsContact_personName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [monthly_payment_method]   qsMonthly_payment_methodName & qsMonthly_payment_method
        public const string qsMonthly_payment_methodName = "monthly_payment_method";
        public static string qsMonthly_payment_method
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMonthly_payment_methodName]))
                {
                    return HttpContext.Current.Request[qsMonthly_payment_methodName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [m_card_type]   qsM_card_typeName & qsM_card_type
        public const string qsM_card_typeName = "m_card_type";
        public static string qsM_card_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_card_typeName]))
                {
                    return HttpContext.Current.Request[qsM_card_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [lob]   qsLobName & qsLob
        public const string qsLobName = "lob";
        public static string qsLob
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsLobName]))
                {
                    return HttpContext.Current.Request[qsLobName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [log_date]   qsLog_dateName & qsLog_date
        public const string qsLog_dateName = "log_date";
        public static System.Nullable<DateTime> qsLog_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsLog_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsLog_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsLog_dateName].ToString());
                        
                    }
                }
                return null;
            }
        }
        #endregion
        #region [m_rebate_amount]   qsM_rebate_amountName & qsM_rebate_amount
        public const string qsM_rebate_amountName = "m_rebate_amount";
        public static string qsM_rebate_amount
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_rebate_amountName]))
                {
                    return HttpContext.Current.Request[qsM_rebate_amountName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [mcam_vas]   qsMcam_vasName & qsMcam_vas
        public const string qsMcam_vasName = "mcam_vas";
        public static string qsMcam_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMcam_vasName]))
                {
                    return HttpContext.Current.Request[qsMcam_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [pay_method]   qsPay_methodName & qsPay_method
        public const string qsPay_methodName = "pay_method";
        public static string qsPay_method
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPay_methodName]))
                {
                    return HttpContext.Current.Request[qsPay_methodName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [remarks2EDF]   qsRemarks2EDFName & qsRemarks2EDF
        public const string qsRemarks2EDFName = "remarks2EDF";
        public static string qsRemarks2EDF
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRemarks2EDFName]))
                {
                    return HttpContext.Current.Request[qsRemarks2EDFName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [msn_vas]   qsMsn_vasName & qsMsn_vas
        public const string qsMsn_vasName = "msn_vas";
        public static string qsMsn_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMsn_vasName]))
                {
                    return HttpContext.Current.Request[qsMsn_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [accept]   qsAcceptName & qsAccept
        public const string qsAcceptName = "accept";
        public static string qsAccept
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAcceptName]))
                {
                    return HttpContext.Current.Request[qsAcceptName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [id_type]   qsId_typeName & qsId_type
        public const string qsId_typeName = "id_type";
        public static string qsId_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsId_typeName]))
                {
                    return HttpContext.Current.Request[qsId_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [d_date]   qsD_dateName & qsD_date
        public const string qsD_dateName = "d_date";
        public static System.Nullable<DateTime> qsD_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsD_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsD_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsD_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [ord_place_id_type]   qsOrd_place_id_typeName & qsOrd_place_id_type
        public const string qsOrd_place_id_typeName = "ord_place_id_type";
        public static string qsOrd_place_id_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrd_place_id_typeName]))
                {
                    return HttpContext.Current.Request[qsOrd_place_id_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [wifi_vas]   qsWifi_vasName & qsWifi_vas
        public const string qsWifi_vasName = "wifi_vas";
        public static string qsWifi_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsWifi_vasName]))
                {
                    return HttpContext.Current.Request[qsWifi_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vas_eff_date]   qsVas_eff_dateName & qsVas_eff_date
        public const string qsVas_eff_dateName = "vas_eff_date";
        public static System.Nullable<DateTime> qsVas_eff_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsVas_eff_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsVas_eff_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsVas_eff_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [ref_salesmancode]   qsRef_salesmancodeName & qsRef_salesmancode
        public const string qsRef_salesmancodeName = "ref_salesmancode";
        public static string qsRef_salesmancode
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRef_salesmancodeName]))
                {
                    return HttpContext.Current.Request[qsRef_salesmancodeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [waive]   qsWaiveName & qsWaive
        public const string qsWaiveName = "waive";
        public static System.Nullable<bool> qsWaive
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsWaiveName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsWaiveName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [license_waiver]   qsLicense_waiverName & qsLicense_waiver
        public const string qsLicense_waiverName = "license_waiver";
        public static string qsLicense_waiver
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsLicense_waiverName]))
                {
                    return HttpContext.Current.Request[qsLicense_waiverName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [hkid]   qsHkidName & qsHkid
        public const string qsHkidName = "hkid";
        public static string qsHkid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsHkidName]))
                {
                    return HttpContext.Current.Request[qsHkidName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_code4]   qsGift_code4Name & qsGift_code4
        public const string qsGift_code4Name = "gift_code4";
        public static string qsGift_code4
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_code4Name]))
                {
                    return HttpContext.Current.Request[qsGift_code4Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [sp_d_date]   qsSp_d_dateName & qsSp_d_date
        public const string qsSp_d_dateName = "sp_d_date";
        public static System.Nullable<DateTime> qsSp_d_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsSp_d_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsSp_d_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsSp_d_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [del_remark]   qsDel_remarkName & qsDel_remark
        public const string qsDel_remarkName = "del_remark";
        public static string qsDel_remark
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDel_remarkName]))
                {
                    return HttpContext.Current.Request[qsDel_remarkName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [tl_name]   qsTl_nameName & qsTl_name
        public const string qsTl_nameName = "tl_name";
        public static string qsTl_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsTl_nameName]))
                {
                    return HttpContext.Current.Request[qsTl_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [old_ord_id]   qsOld_ord_idName & qsOld_ord_id
        public const string qsOld_ord_idName = "old_ord_id";
        public static System.Nullable<int> qsOld_ord_id
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsOld_ord_idName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsOld_ord_idName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [min_vas500]   qsMin_vas500Name & qsMin_vas500
        public const string qsMin_vas500Name = "min_vas500";
        public static string qsMin_vas500
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_vas500Name]))
                {
                    return HttpContext.Current.Request[qsMin_vas500Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [m_card_no]   qsM_card_noName & qsM_card_no
        public const string qsM_card_noName = "m_card_no";
        public static string qsM_card_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsM_card_noName]))
                {
                    return HttpContext.Current.Request[qsM_card_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [aig_gift]   qsAig_giftName & qsAig_gift
        public const string qsAig_giftName = "aig_gift";
        public static string qsAig_gift
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAig_giftName]))
                {
                    return HttpContext.Current.Request[qsAig_giftName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ord_place_tel]   qsOrd_place_telName & qsOrd_place_tel
        public const string qsOrd_place_telName = "ord_place_tel";
        public static string qsOrd_place_tel
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOrd_place_telName]))
                {
                    return HttpContext.Current.Request[qsOrd_place_telName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [sp_ref_no]   qsSp_ref_noName & qsSp_ref_no
        public const string qsSp_ref_noName = "sp_ref_no";
        public static string qsSp_ref_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSp_ref_noName]))
                {
                    return HttpContext.Current.Request[qsSp_ref_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [card_type]   qsCard_typeName & qsCard_type
        public const string qsCard_typeName = "card_type";
        public static string qsCard_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_typeName]))
                {
                    return HttpContext.Current.Request[qsCard_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [contact_no]   qsContact_noName & qsContact_no
        public const string qsContact_noName = "contact_no";
        public static string qsContact_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsContact_noName]))
                {
                    return HttpContext.Current.Request[qsContact_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [sku]   qsSkuName & qsSku
        public const string qsSkuName = "sku";
        public static string qsSku
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSkuName]))
                {
                    return HttpContext.Current.Request[qsSkuName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [imin_vas400]   qsImin_vas400Name & qsImin_vas400
        public const string qsImin_vas400Name = "imin_vas400";
        public static string qsImin_vas400
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsImin_vas400Name]))
                {
                    return HttpContext.Current.Request[qsImin_vas400Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [vip_case]   qsVip_caseName & qsVip_case
        public const string qsVip_caseName = "vip_case";
        public static string qsVip_case
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsVip_caseName]))
                {
                    return HttpContext.Current.Request[qsVip_caseName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [action_eff_date]   qsAction_eff_dateName & qsAction_eff_date
        public const string qsAction_eff_dateName = "action_eff_date";
        public static System.Nullable<DateTime> qsAction_eff_date
        {
            get
            {
                if (Func.IsParseDateTime(HttpContext.Current.Request[qsAction_eff_dateName]))
                {
                    if (!WebFuncBase.n_bUseDatetimePattern)
                    {
                        return DateTime.Parse(HttpContext.Current.Request[qsAction_eff_dateName].ToString());
                    }
                    else
                    {
                        return Func.ConvertDatetime(HttpContext.Current.Request[qsAction_eff_dateName].ToString());
                    }
                }
                return null;
            }
        }
        #endregion
        #region [easywatch_type]   qsEasywatch_typeName & qsEasywatch_type
        public const string qsEasywatch_typeName = "easywatch_type";
        public static string qsEasywatch_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsEasywatch_typeName]))
                {
                    return HttpContext.Current.Request[qsEasywatch_typeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [action_required]   qsAction_requiredName & qsAction_required
        public const string qsAction_requiredName = "action_required";
        public static string qsAction_required
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAction_requiredName]))
                {
                    return HttpContext.Current.Request[qsAction_requiredName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [sms_vas]   qsSms_vasName & qsSms_vas
        public const string qsSms_vasName = "sms_vas";
        public static string qsSms_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSms_vasName]))
                {
                    return HttpContext.Current.Request[qsSms_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [card_holder]   qsCard_holderName & qsCard_holder
        public const string qsCard_holderName = "card_holder";
        public static string qsCard_holder
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_holderName]))
                {
                    return HttpContext.Current.Request[qsCard_holderName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_imei3]   qsGift_imei3Name & qsGift_imei3
        public const string qsGift_imei3Name = "gift_imei3";
        public static string qsGift_imei3
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_imei3Name]))
                {
                    return HttpContext.Current.Request[qsGift_imei3Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [horse_vas]   qsHorse_vasName & qsHorse_vas
        public const string qsHorse_vasName = "horse_vas";
        public static string qsHorse_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsHorse_vasName]))
                {
                    return HttpContext.Current.Request[qsHorse_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_desc2]   qsGift_desc2Name & qsGift_desc2
        public const string qsGift_desc2Name = "gift_desc2";
        public static string qsGift_desc2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_desc2Name]))
                {
                    return HttpContext.Current.Request[qsGift_desc2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [min_vas]   qsMin_vasName & qsMin_vas
        public const string qsMin_vasName = "min_vas";
        public static string qsMin_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_vasName]))
                {
                    return HttpContext.Current.Request[qsMin_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ref_staff_no]   qsRef_staff_noName & qsRef_staff_no
        public const string qsRef_staff_noName = "ref_staff_no";
        public static string qsRef_staff_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRef_staff_noName]))
                {
                    return HttpContext.Current.Request[qsRef_staff_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [edf_no]   qsEdf_noName & qsEdf_no
        public const string qsEdf_noName = "edf_no";
        public static string qsEdf_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsEdf_noName]))
                {
                    return HttpContext.Current.Request[qsEdf_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [special_approval]   qsSpecial_approvalName & qsSpecial_approval
        public const string qsSpecial_approvalName = "special_approval";
        public static string qsSpecial_approval
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsSpecial_approvalName]))
                {
                    return HttpContext.Current.Request[qsSpecial_approvalName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [exist_plan]   qsExist_planName & qsExist_plan
        public const string qsExist_planName = "exist_plan";
        public static string qsExist_plan
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExist_planName]))
                {
                    return HttpContext.Current.Request[qsExist_planName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [cust_name]   qsCust_nameName & qsCust_name
        public const string qsCust_nameName = "cust_name";
        public static string qsCust_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCust_nameName]))
                {
                    return HttpContext.Current.Request[qsCust_nameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [d_time]   qsD_timeName & qsD_time
        public const string qsD_timeName = "d_time";
        public static string qsD_time
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_timeName]))
                {
                    return HttpContext.Current.Request[qsD_timeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [pos_ref_no]   qsPos_ref_noName & qsPos_ref_no
        public const string qsPos_ref_noName = "pos_ref_no";
        public static string qsPos_ref_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPos_ref_noName]))
                {
                    return HttpContext.Current.Request[qsPos_ref_noName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [plan_eff]   qsPlan_effName & qsPlan_eff
        public const string qsPlan_effName = "plan_eff";
        public static string qsPlan_eff
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPlan_effName]))
                {
                    return HttpContext.Current.Request[qsPlan_effName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [moov_vas]   qsMoov_vasName & qsMoov_vas
        public const string qsMoov_vasName = "moov_vas";
        public static string qsMoov_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMoov_vasName]))
                {
                    return HttpContext.Current.Request[qsMoov_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [card_exp_year]   qsCard_exp_yearName & qsCard_exp_year
        public const string qsCard_exp_yearName = "card_exp_year";
        public static string qsCard_exp_year
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCard_exp_yearName]))
                {
                    return HttpContext.Current.Request[qsCard_exp_yearName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_imei]   qsGift_imeiName & qsGift_imei
        public const string qsGift_imeiName = "gift_imei";
        public static string qsGift_imei
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_imeiName]))
                {
                    return HttpContext.Current.Request[qsGift_imeiName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [min_vas600]   qsMin_vas600Name & qsMin_vas600
        public const string qsMin_vas600Name = "min_vas600";
        public static string qsMin_vas600
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMin_vas600Name]))
                {
                    return HttpContext.Current.Request[qsMin_vas600Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [now_vas]   qsNow_vasName & qsNow_vas
        public const string qsNow_vasName = "now_vas";
        public static string qsNow_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsNow_vasName]))
                {
                    return HttpContext.Current.Request[qsNow_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [exist_cust_plan]   qsExist_cust_planName & qsExist_cust_plan
        public const string qsExist_cust_planName = "exist_cust_plan";
        public static string qsExist_cust_plan
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExist_cust_planName]))
                {
                    return HttpContext.Current.Request[qsExist_cust_planName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [fast_start]   qsFast_startName & qsFast_start
        public const string qsFast_startName = "fast_start";
        public static System.Nullable<bool> qsFast_start
        {
            get
            {
                if (Func.IsParseBool(HttpContext.Current.Request[qsFast_startName]))
                {
                    return bool.Parse(HttpContext.Current.Request[qsFast_startName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [gift_imei2]   qsGift_imei2Name & qsGift_imei2
        public const string qsGift_imei2Name = "gift_imei2";
        public static string qsGift_imei2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_imei2Name]))
                {
                    return HttpContext.Current.Request[qsGift_imei2Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gift_desc3]   qsGift_desc3Name & qsGift_desc3
        public const string qsGift_desc3Name = "gift_desc3";
        public static string qsGift_desc3
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGift_desc3Name]))
                {
                    return HttpContext.Current.Request[qsGift_desc3Name].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [extra_d_charge]   qsExtra_d_chargeName & qsExtra_d_charge
        public const string qsExtra_d_chargeName = "extra_d_charge";
        public static string qsExtra_d_charge
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsExtra_d_chargeName]))
                {
                    return HttpContext.Current.Request[qsExtra_d_chargeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ob_program_id]   qsOb_program_idName & qsOb_program_id
        public const string qsOb_program_idName = "ob_program_id";
        public static string qsOb_program_id
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsOb_program_idName]))
                {
                    return HttpContext.Current.Request[qsOb_program_idName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [easywatch_ord_id]   qsEasywatch_ord_idName & qsEasywatch_ord_id
        public const string qsEasywatch_ord_idName = "easywatch_ord_id";
        public static string qsEasywatch_ord_id
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsEasywatch_ord_idName]))
                {
                    return HttpContext.Current.Request[qsEasywatch_ord_idName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [remarks2PY]   qsRemarks2PYName & qsRemarks2PY
        public const string qsRemarks2PYName = "remarks2PY";
        public static string qsRemarks2PY
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsRemarks2PYName]))
                {
                    return HttpContext.Current.Request[qsRemarks2PYName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [gprs_vas]   qsGprs_vasName & qsGprs_vas
        public const string qsGprs_vasName = "gprs_vas";
        public static string qsGprs_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsGprs_vasName]))
                {
                    return HttpContext.Current.Request[qsGprs_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [ct_vas]   qsCt_vasName & qsCt_vas
        public const string qsCt_vasName = "ct_vas";
        public static string qsCt_vas
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsCt_vasName]))
                {
                    return HttpContext.Current.Request[qsCt_vasName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [PROG_ID]   qsPROG_IDName & qsPROG_ID
        public const string qsPROG_IDName = "PROG_ID";
        public static System.Nullable<int> qsPROG_ID
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[qsPROG_IDName]))
                {
                    return int.Parse(HttpContext.Current.Request[qsPROG_IDName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [PROG_LV_DESC]   qsPROG_LV_DESCName & qsPROG_LV_DESC
        public const string qsPROG_LV_DESCName = "PROG_LV_DESC";
        public static string qsPROG_LV_DESC
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPROG_LV_DESCName]))
                {
                    return HttpContext.Current.Request[qsPROG_LV_DESCName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [PROG_DESC]   qsPROG_DESCName & qsPROG_DESC
        public const string qsPROG_DESCName = "PROG_DESC";
        public static string qsPROG_DESC
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPROG_DESCName]))
                {
                    return HttpContext.Current.Request[qsPROG_DESCName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [plan_code]   qsPlan_codeName & qsPlan_code
        public const string qsPlan_codeName = "plan_code";
        public static string qsPlan_code
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPlan_codeName]))
                {
                    return HttpContext.Current.Request[qsPlan_codeName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [mob_num]   qsMob_numName & qsMob_num
        public const string qsMob_numName = "mob_num";
        public static string qsMob_num
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsMob_numName]))
                {
                    return HttpContext.Current.Request[qsMob_numName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [doc_id]   qsDoc_idName & qsDoc_id
        public const string qsDoc_idName = "doc_id";
        public static string qsDoc_id
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsDoc_idName]))
                {
                    return HttpContext.Current.Request[qsDoc_idName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [name]   qsNameName & qsName
        public const string qsNameName = "name";
        public static string qsName
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsNameName]))
                {
                    return HttpContext.Current.Request[qsNameName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [prem_desc]   qsPrem_descName & qsPrem_desc
        public const string qsPrem_descName = "prem_desc";
        public static string qsPrem_desc
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPrem_descName]))
                {
                    return HttpContext.Current.Request[qsPrem_descName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [accnt_cd]   qsAccnt_cdName & qsAccnt_cd
        public const string qsAccnt_cdName = "accnt_cd";
        public static string qsAccnt_cd
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsAccnt_cdName]))
                {
                    return HttpContext.Current.Request[qsAccnt_cdName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region [lett_sent_date]   qsLett_sent_dateName & qsLett_sent_date
        public const string qsLett_sent_dateName = "lett_sent_date";
        public static string qsLett_sent_date
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsLett_sent_dateName]))
                {
                    return HttpContext.Current.Request[qsLett_sent_dateName].ToString();
                }
                return string.Empty;
            }
        }
        #endregion




        #region [transfer_no_add_proof_deposit]   qsTransfer_no_add_proof_depositName & qsTransfer_no_add_proof_deposit
        public const string qsTransfer_no_add_proof_depositName = "transfer_no_add_proof_deposit";
        public static global::System.Nullable<long> qsTransfer_no_add_proof_deposit
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[qsTransfer_no_add_proof_depositName]))
                {
                    return long.Parse(HttpContext.Current.Request[qsTransfer_no_add_proof_depositName].ToString());
                }
                return null;
            }
        }
        #endregion




        #region [arthurization_person]   qsArthurization_personName & qsArthurization_person
        public const string qsArthurization_personName = "arthurization_person";
        public static string qsArthurization_person
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsArthurization_personName]))
                {
                    return HttpContext.Current.Request[qsArthurization_personName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [plural]   qsPluralName & qsPlural
        public const string qsPluralName = "plural";
        public static string qsPlural
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsPluralName]))
                {
                    return HttpContext.Current.Request[qsPluralName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


 

        #region [d_street]   qsD_streetName & qsD_street
        public const string qsD_streetName = "d_street";
        public static string qsD_street
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_streetName]))
                {
                    return HttpContext.Current.Request[qsD_streetName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [d_region]   qsD_regionName & qsD_region
        public const string qsD_regionName = "d_region";
        public static string qsD_region
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_regionName]))
                {
                    return HttpContext.Current.Request[qsD_regionName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [d_floor]   qsD_floorName & qsD_floor
        public const string qsD_floorName = "d_floor";
        public static string qsD_floor
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_floorName]))
                {
                    return HttpContext.Current.Request[qsD_floorName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [d_build]   qsD_buildName & qsD_build
        public const string qsD_buildName = "d_build";
        public static string qsD_build
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_buildName]))
                {
                    return HttpContext.Current.Request[qsD_buildName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [d_district]   qsD_districtName & qsD_district
        public const string qsD_districtName = "d_district";
        public static string qsD_district
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_districtName]))
                {
                    return HttpContext.Current.Request[qsD_districtName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #region [d_room]   qsD_roomName & qsD_room
        public const string qsD_roomName = "d_room";
        public static string qsD_room
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_roomName]))
                {
                    return HttpContext.Current.Request[qsD_roomName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion


        #region [d_type]   qsD_typeName & qsD_type
        public const string qsD_typeName = "d_type";
        public static string qsD_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_typeName]))
                {
                    return HttpContext.Current.Request[qsD_typeName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion
        #region [address_id]   qsAddress_idName & qsAddress_id
        public const string qsAddress_idName = "address_id";
        public static global::System.Nullable<long> qsAddress_id
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[qsAddress_idName]))
                {
                    return long.Parse(HttpContext.Current.Request[qsAddress_idName].ToString());
                }
                return null;
            }
        }
        #endregion
        #region [d_blk]   qsD_blkName & qsD_blk
        public const string qsD_blkName = "d_blk";
        public static string qsD_blk
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[qsD_blkName]))
                {
                    return HttpContext.Current.Request[qsD_blkName].ToString();
                }
                return global::System.String.Empty;
            }
        }
        #endregion

        #endregion QueryString Parameter
        

        #region public static string GetLink(string sURL, string sDisplayName)
        public static string GetLink(string sURL, string sDisplayName)
        {
            string sRnt = "";
            if (sDisplayName.Trim() != "")
            {
                if (sURL.Trim() != "")
                {
                    sRnt = "<a href='" + sURL + "'>";
                }
                sRnt += sDisplayName;
                if (sURL.Trim() != "")
                {
                    sRnt += "</a>";
                }
            }
            return sRnt;
        }
        #endregion


        #region public static string PageName
        public static string PageName
        {
            get
            {
                string[] my_aStr = HttpContext.Current.Request.Path.Split("/"[0]);
                return my_aStr[my_aStr.Length - 1];
            }
        }
        #endregion

    }
}
