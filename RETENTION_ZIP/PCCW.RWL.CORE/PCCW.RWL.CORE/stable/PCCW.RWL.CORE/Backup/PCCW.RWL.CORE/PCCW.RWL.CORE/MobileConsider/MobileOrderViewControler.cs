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
using System.Xml.Linq;
using System.Linq;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[MobileOrderViewControler],Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class MobileOrderViewControler
    {
        #region Access right control
        [Obsolete]
        public bool AccessRightControl()
        {
            string _oQuery1 = string.Empty;
            string _oQuery2 = string.Empty;
            string _oQuery3 = string.Empty;
            string _oQuery4 = string.Empty;
            string _oQuery5 = string.Empty;
            global::System.Data.SqlClient.SqlDataReader _oReader = null;

            List<string> _oSalesmancodeList = new List<string>();
            SaleManCodeProfile _oSaleManCodeProfile = new SaleManCodeProfile();
            _oSaleManCodeProfile.SetUid(this.n_sUid.ToString().Trim());
            _oSalesmancodeList = _oSaleManCodeProfile.Get_SalemanCodeList();
            _oQuery2 = "SELECT order_status FROM " + n_sPrefix + "MobileOrderReport with (nolock) WHERE order_id='" + this.n_iRwlOrderID.ToString() + "' AND active=1 AND order_status='DONE' order by mid desc";
            _oQuery3 = "SELECT order_id,action_eff_date,dateadd(month,12,action_eff_date) FROM " + n_sPrefix + "MobileRetentionOrder WITH (NOLOCK) WHERE active=1 AND action_eff_date IS NOT NULL AND dateadd(month,12,action_eff_date)>=getdate() AND active=1 AND order_id='" + this.n_iRwlOrderID.ToString() + "' ";
            _oQuery4 = "SELECT order_id,con_eff_date,con_per,trade_field,action_required,dateadd(month, convert(float,con_per) -8,con_eff_date) month_diff from MobileRetentionOrder WITH (NOLOCK) WHERE active=1 AND ((con_eff_date is not null AND con_per is not null AND dateadd(month, convert(float,con_per) -8,con_eff_date)<=getdate()) or action_required='opt_out') AND active=1 AND order_id='" + this.n_iRwlOrderID.ToString() + "' ";
            _oQuery5 = "SELECT order_id,bill_cut_date,con_per,trade_field,action_required,dateadd(month, convert(float,con_per) -8,bill_cut_date) month_diff from MobileRetentionOrder WITH (NOLOCK) WHERE active=1 AND ((bill_cut_date is not null AND con_per is not null AND dateadd(month, convert(float,con_per) -8,bill_cut_date)<=getdate()) or action_required='opt_out') AND active=1 AND order_id='" + this.n_iRwlOrderID.ToString() + "' ";

            if (n_oDB != null && this.n_iRwlOrderID > -1)
            {
                if (_oSalesmancodeList.Count > 0) { this.n_sSalesmancodeList = Func.ExplodeList(_oSalesmancodeList, ",", true); }
                if (this.n_sStaff_no != string.Empty)
                {
                    this.n_iDup_flag = 0;
                    _oReader = n_oDB.GetSearch(_oQuery2);
                    if (_oReader.Read())
                    {
                        this.n_iDone_flag = 1;
                        if (this.n_sAction_required == "suspend")
                        {
                            _oReader = n_oDB.GetSearch(_oQuery3);
                            if (_oReader.Read())
                                n_oResponseMsg.Add("Order Suspended within 12 MONTHS Cannot create an new order");
                            else
                                this.n_iAdd_flag = 1;
                            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
                        }
                        else if (this.n_sTrade_field.Trim() == "NA" || this.n_sTrade_field.Trim() == "3GRET0298AUTOREN12M" || this.n_sTrade_field.Trim() == "3GRET0098AUTOREN12M" || this.n_sTrade_field.Trim() == "3GRET0198AUTOREN12M")
                            this.n_iAdd_flag = 1;
                        else
                        {
                            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
                            _oReader = n_oDB.GetSearch(_oQuery4);
                            if (_oReader.Read())
                            {
                                this.n_iAdd_flag = 1;
                            }
                            else
                            {
                                _oReader = n_oDB.GetSearch(_oQuery5);
                                if (_oReader.Read())
                                {
                                    this.n_iAdd_flag = 1;
                                }
                                else
                                {
                                    n_oResponseMsg.Add(" EXISTING CONTRACT > 8 MONTHS! Cannot create an new order");
                                }
                                //n_oResponseMsg.Add(" EXISTING CONTRACT > 8 MONTHS! Cannot create an new order");
                            }
                            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
                        }
                    }
                    else
                        if (_oReader != null) _oReader.Close(); _oReader.Dispose();
                }
                return true;
            }
            return false;
        }

        #endregion

        #region Special Trade Field
        [Obsolete]
        public bool SpecialTradeField()
        {
            string _sQuery = string.Empty;
            if (this.n_iRwlOrderID > -1 && n_oDB != null && this.n_sTrade_field != string.Empty)
            {
                _sQuery = "SELECT order_status FROM " + this.n_sPrefix + "MobileOrderReport WITH (NOLOCK) WHERE order_id='" + this.n_iRwlOrderID.ToString().Trim() + "' AND active=1 AND order_status='DONE' ORDER BY mid DESC";
                global::System.Data.SqlClient.SqlDataReader _oReader = n_oDB.GetSearch(_sQuery);
                if (_oReader.Read())
                {
                    this.n_iAdd_flag = 0;
                    if (this.n_sTrade_field.Trim() == "NA" || this.n_sTrade_field.Trim() == "3GRET0298AUTOREN12M" || this.n_sTrade_field == "3GRET0098AUTOREN12M" || this.n_sTrade_field == "3GRET0198AUTOREN12M")
                        this.n_iAdd_flag = 1;
                }
                if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            }
            return false;
        }
        #endregion

        #region After Released Restriction -> Add new order & Cancel old order
        [Obsolete]
        public bool AfterReleasedRestriction()
        {
            string _sQuery = string.Empty;
            if (this.n_iRwlOrderID > -1 && n_oDB != null)
            {
                _sQuery = "SELECT TOP 1 * FROM " + this.n_sPrefix + "OrderReleaseDetail WITH (NOLOCK) WHERE order_id='" + this.n_iRwlOrderID + "' AND active=1";
                global::System.Data.SqlClient.SqlDataReader _oReader = n_oDB.GetSearch(_sQuery);
                if (_oReader != null)
                {
                    if (_oReader.Read())
                        this.n_iDup_flag = 1;
                    if (_oReader != null) _oReader.Close(); _oReader.Dispose();
                }
                return true;
            }
            return false;
        }
        #endregion

       

        #region InitDataByMRT
        public bool InitDataByMRT()
        {
            string _sQuery = string.Empty;
            int _iMobileNumber;
            if (this.n_sMrt != string.Empty &&
                n_oDB != null &&
                int.TryParse(this.n_sMrt.Trim().Replace("'", "''"), out _iMobileNumber))
            {
                if (!IsExceptionAddRuleOrder(n_sMrt))
                {
                    _sQuery = "SELECT TOP 1 order_id,action_required,staff_no,salesmancode,trade_field,issue_type FROM " + Configurator.MSSQLTablePrefix + "MobileRetentionOrder WITH (NOLOCK) WHERE active=1 AND mrt_no='" + _iMobileNumber.ToString() + "' ORDER BY log_date DESC";
                    global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
                    if (_oReader != null)
                    {
                        if (_oReader.Read())
                        {
                            if (this.Issue_type != "UPGRADE")
                            {
                                this.n_iRwlOrderID = Convert.ToInt32(_oReader[MobileRetentionOrder.Para.order_id].ToString());
                                this.n_sAction_required = _oReader[MobileRetentionOrder.Para.action_required].ToString();
                                this.n_sStaff_no = _oReader[MobileRetentionOrder.Para.staff_no].ToString();
                                this.n_sSalesmancode = _oReader[MobileRetentionOrder.Para.salesmancode].ToString();
                                this.n_sTrade_field = _oReader[MobileRetentionOrder.Para.trade_field].ToString();
                                //this.AfterReleasedRestriction();
                                //this.SpecialTradeField();
                                //this.AccessRightControl();
                                SetAddFlag(this.n_iRwlOrderID, _iMobileNumber, this.n_sAction_required, this.n_sStaff_no, this.n_sSalesmancode, this.n_sTrade_field);
                            }
                            else
                                this.n_iAdd_flag = 1;
                        }
                        else
                            this.n_iAdd_flag = 1;
                        if (_oReader != null) _oReader.Close(); _oReader.Dispose();
                        return true;
                    }
                }
                else
                {
                    this.AfterReleasedRestriction();
                    this.n_iAdd_flag = 1;
                    return true;
                }
            }
            return false;
        }

        public bool IsExceptionAddRuleOrder(string x_sMrt_no)
        {
            if (string.IsNullOrEmpty(x_sMrt_no)) return false;
            MobileRetentionOrderAddRuleExceptionListEntity[] _oMobileRetentionOrderAddRuleExceptionListArr =
                MobileRetentionOrderAddRuleExceptionListRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(),1, " mrt_no='" + x_sMrt_no + "' AND used=0 AND (order_id='' OR order_id IS NULL) AND active=1", null, "id");
            if (_oMobileRetentionOrderAddRuleExceptionListArr != null)
                if (_oMobileRetentionOrderAddRuleExceptionListArr.Length > 0)
                    return true;
            return false;
        }

        public MobileRetentionOrderAddRuleExceptionListEntity FindExceptionAddRuleOrder(string x_sMrt_no)
        {
            if (string.IsNullOrEmpty(x_sMrt_no)) return null;
            MobileRetentionOrderAddRuleExceptionListEntity[] _oMobileRetentionOrderAddRuleExceptionListArr =
                MobileRetentionOrderAddRuleExceptionListRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), 1, " mrt_no='" + x_sMrt_no + "' AND used=0 AND (order_id='' OR order_id IS NULL) AND active=1", null, "id");
            if (_oMobileRetentionOrderAddRuleExceptionListArr != null)
                if (_oMobileRetentionOrderAddRuleExceptionListArr.Length > 0)
                    return _oMobileRetentionOrderAddRuleExceptionListArr[0];
            return null;
        }
        #endregion

        protected void SetAddFlag(int x_iOrderID, int x_iMobileNumber, string x_sAction_required, string x_sStaff_no, string x_sSalesmancode, string x_sTrade_field)
        {
            bool _bResult = false;
            int _iResultFlag = -1;
            string _sErrorMsg = string.Empty;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("MobileOrderIssueRestrictionSP");
            SqlCommand _oCmd = new SqlCommand();
            _oCmd.CommandText = _oQuery.ToString();
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                _oCmd.Connection = _oConn;
                _oCmd.CommandType = CommandType.StoredProcedure;
                _oCmd.Parameters.Clear();
                try
                {
                    SqlParameter _oPar = null;
                    _oPar = _oCmd.Parameters.Add("@MobileNumber", SqlDbType.Int);
                    _oPar.Value = x_iMobileNumber;
                    _oPar.Direction = ParameterDirection.Input;
                    _oPar = _oCmd.Parameters.Add("@OrderID", SqlDbType.Int);
                    _oPar.Value = x_iOrderID;
                    _oPar.Direction = ParameterDirection.Input;
                    _oPar = _oCmd.Parameters.Add("@ActionRequired", SqlDbType.NVarChar, 50);
                    _oPar.Value = x_sAction_required;
                    _oPar.Direction = ParameterDirection.Input;
                    _oPar = _oCmd.Parameters.Add("@ErrorMsg", SqlDbType.NVarChar, 1000);
                    _oPar.Direction = ParameterDirection.Output;
                    _oPar = _oCmd.Parameters.Add("@RESULT", SqlDbType.NVarChar, 1000);
                    _oPar.Direction = ParameterDirection.Output;
                    if (_oConn.State == ConnectionState.Closed) _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                    _iResultFlag = Int32.Parse(_oCmd.Parameters["@RESULT"].Value.ToString());
                    _sErrorMsg = _oCmd.Parameters["@ErrorMsg"].Value.ToString().Trim();
                }
                catch (Exception exp)
                {

                }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
            }

            if (_iResultFlag == 2)
            {
                this.n_iDone_flag = 1;
                this.n_iDup_flag = 1;
                this.n_iAdd_flag = 1;
            }
            else if (_iResultFlag == 1)
            {
                this.n_iDone_flag = 1;
                this.n_iDup_flag = 0;
                this.n_iAdd_flag = 1;
            }
            else if (_iResultFlag == -2)
            {
                this.n_iDone_flag = 0;
            }
            else
            {
                this.n_iAdd_flag = -1;
            }

            if (!_sErrorMsg.Equals(string.Empty))
            {
                this.n_oResponseMsg.Add(_sErrorMsg);
                this.n_iAdd_flag = 0;
            }
        }

        public string Issue_type = string.Empty;
        protected int n_iProg_Lv = -1;
        #region m_iProg_Lv
        protected int m_iProg_Lv
        {
            get
            {
                return this.n_iProg_Lv;
            }
            set
            {
                this.n_iProg_Lv = value;
            }
        }
        #endregion m_iProg_Lv


        protected string n_sPrefix = Configurator.MSSQLTablePrefix;
        #region m_sPrefix
        protected string m_sPrefix
        {
            get
            {
                return this.n_sPrefix;
            }
            set
            {
                this.n_sPrefix = value;
            }
        }
        #endregion m_sPrefix


        protected string n_sStaff_no = string.Empty;
        #region m_sStaff_no
        protected string m_sStaff_no
        {
            get
            {
                return this.n_sStaff_no;
            }
            set
            {
                this.n_sStaff_no = value;
            }
        }
        #endregion m_sStaff_no


        protected string n_sAction_required = string.Empty;
        #region m_sAction_required
        protected string m_sAction_required
        {
            get
            {
                return this.n_sAction_required;
            }
            set
            {
                this.n_sAction_required = value;
            }
        }
        #endregion m_sAction_required


        protected int n_iDup_flag = 0;
        #region m_iDup_flag
        protected int m_iDup_flag
        {
            get
            {
                return this.n_iDup_flag;
            }
            set
            {
                this.n_iDup_flag = value;
            }
        }
        #endregion m_iDup_flag


        protected string n_sSalesmancodeList = string.Empty;
        #region m_sSalesmancodeList
        protected string m_sSalesmancodeList
        {
            get
            {
                return this.n_sSalesmancodeList;
            }
            set
            {
                this.n_sSalesmancodeList = value;
            }
        }
        #endregion m_sSalesmancodeList


        protected global::System.Collections.Generic.List<string> n_oResponseMsg = new global::System.Collections.Generic.List<string>();
        #region m_oResponseMsg
        protected global::System.Collections.Generic.List<string> m_oResponseMsg
        {
            get
            {
                return this.n_oResponseMsg;
            }
            set
            {
                this.n_oResponseMsg = value;
            }
        }
        #endregion m_oResponseMsg

         
        protected MSSQLConnect n_oDB = null;
        #region m_oDB
        protected MSSQLConnect m_oDB
        {
            get
            {
                return this.n_oDB;
            }
            set
            {
                this.n_oDB = value;
            }
        }
        #endregion m_oDB


        protected string n_sSalesmancode = string.Empty;
        #region m_sSalesmancode
        protected string m_sSalesmancode
        {
            get
            {
                return this.n_sSalesmancode;
            }
            set
            {
                this.n_sSalesmancode = value;
            }
        }
        #endregion m_sSalesmancode


        protected int n_iDone_flag = 0;
        #region m_iDone_flag
        protected int m_iDone_flag
        {
            get
            {
                return this.n_iDone_flag;
            }
            set
            {
                this.n_iDone_flag = value;
            }
        }
        #endregion m_iDone_flag


        protected string n_sTrade_field = string.Empty;
        #region m_sTrade_field
        protected string m_sTrade_field
        {
            get
            {
                return this.n_sTrade_field;
            }
            set
            {
                this.n_sTrade_field = value;
            }
        }
        #endregion m_sTrade_field


        protected int n_iAdd_flag = 0;
        #region m_iAdd_flag
        protected int m_iAdd_flag
        {
            get
            {
                return this.n_iAdd_flag;
            }
            set
            {
                this.n_iAdd_flag = value;
            }
        }
        #endregion m_iAdd_flag


        protected string n_sUid = string.Empty;
        #region m_sUid
        protected string m_sUid
        {
            get
            {
                return this.n_sUid;
            }
            set
            {
                this.n_sUid = value;
            }
        }
        #endregion m_sUid

        protected int n_iRwlOrderID = -1;
        #region m_iRwlOrderID
        protected int m_iRwlOrderID
        {
            get
            {
                return this.n_iRwlOrderID;
            }
            set
            {
                this.n_iRwlOrderID = value;
            }
        }
        #endregion m_iRwlOrderID

        protected string n_sMrt = string.Empty;
        #region m_sMrt
        protected string m_sMrt
        {
            get
            {
                return this.n_sMrt;
            }
            set
            {
                this.n_sMrt = value;
            }
        }
        #endregion m_sMrt

        protected string n_sConnStr = string.Empty;
        #region m_sConnStr
        protected string m_sConnStr
        {
            get
            {
                return this.n_sConnStr;
            }
            set
            {
                this.n_sConnStr = value;
            }
        }
        #endregion m_sConnStr

        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Constructor & Destructor
        public MobileOrderViewControler() { }

        public MobileOrderViewControler(int x_iProg_Lv, string x_sPrefix, string x_sStaff_no, string x_sAction_required, int x_iDup_flag, string x_sSalesmancodeList, global::System.Collections.Generic.List<string> x_oResponseMsg, MSSQLConnect x_oDB, string x_sSalesmancode, int x_iDone_flag, string x_sTrade_field, int x_iAdd_flag, string x_sUid, int x_iRwlOrderID, string x_sMrt, string x_sConnStr)
        {
            m_iProg_Lv = x_iProg_Lv;
            m_sPrefix = x_sPrefix;
            m_sStaff_no = x_sStaff_no;
            m_sAction_required = x_sAction_required;
            m_iDup_flag = x_iDup_flag;
            m_sSalesmancodeList = x_sSalesmancodeList;
            m_oResponseMsg = x_oResponseMsg;
            m_oDB = x_oDB;
            m_sSalesmancode = x_sSalesmancode;
            m_iDone_flag = x_iDone_flag;
            m_sTrade_field = x_sTrade_field;
            m_iAdd_flag = x_iAdd_flag;
            m_sUid = x_sUid;
            m_iRwlOrderID = x_iRwlOrderID;
            m_sMrt = x_sMrt;
            m_sConnStr = x_sConnStr;
        }

        ~MobileOrderViewControler() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public int GetProg_Lv() { return this.m_iProg_Lv; }
        public string GetPrefix() { return this.m_sPrefix; }
        public string GetStaff_no() { return this.m_sStaff_no; }
        public string GetAction_required() { return this.m_sAction_required; }
        public int GetDup_flag() { return this.m_iDup_flag; }
        public string GetSalesmancodeList() { return this.m_sSalesmancodeList; }
        public global::System.Collections.Generic.List<string> GetResponseMsg() { return this.m_oResponseMsg; }
        public MSSQLConnect GetDB() { return this.m_oDB; }
        public string GetSalesmancode() { return this.m_sSalesmancode; }
        public int GetDone_flag() { return this.m_iDone_flag; }
        public string GetTrade_field() { return this.m_sTrade_field; }
        public int GetAdd_flag() { return this.m_iAdd_flag; }
        public string GetUid() { return this.m_sUid; }
        public int GetRwlOrderID() { return this.m_iRwlOrderID; }
        public string GetMrt() { return this.m_sMrt; }
        public string GetConnStr() { return this.m_sConnStr; }

        public bool SetProg_Lv(int value)
        {
            this.m_iProg_Lv = value;
            return true;
        }
        public bool SetPrefix(string value)
        {
            this.m_sPrefix = value;
            return true;
        }
        public bool SetStaff_no(string value)
        {
            this.m_sStaff_no = value;
            return true;
        }
        public bool SetAction_required(string value)
        {
            this.m_sAction_required = value;
            return true;
        }
        public bool SetDup_flag(int value)
        {
            this.m_iDup_flag = value;
            return true;
        }
        public bool SetSalesmancodeList(string value)
        {
            this.m_sSalesmancodeList = value;
            return true;
        }
        public bool SetResponseMsg(List<string> value)
        {
            this.m_oResponseMsg = value;
            return true;
        }
        public bool SetDB(MSSQLConnect value)
        {
            this.m_oDB = value;
            return true;
        }
        public bool SetSalesmancode(string value)
        {
            this.m_sSalesmancode = value;
            return true;
        }
        public bool SetDone_flag(int value)
        {
            this.m_iDone_flag = value;
            return true;
        }
        public bool SetTrade_field(string value)
        {
            this.m_sTrade_field = value;
            return true;
        }
        public bool SetAdd_flag(int value)
        {
            this.m_iAdd_flag = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetRwlOrderID(int value)
        {
            this.m_iRwlOrderID = value;
            return true;
        }
        public bool SetMrt(string value)
        {
            this.m_sMrt = value;
            return true;
        }
        public bool SetConnStr(string value)
        {
            this.m_sConnStr = value;
            return true;
        }
        #endregion



        #region Equals
        public bool Equals(MobileOrderViewControler x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_iProg_Lv.Equals(x_oObj.m_iProg_Lv)) { return false; }
            if (!this.m_sPrefix.Equals(x_oObj.m_sPrefix)) { return false; }
            if (!this.m_sStaff_no.Equals(x_oObj.m_sStaff_no)) { return false; }
            if (!this.m_sAction_required.Equals(x_oObj.m_sAction_required)) { return false; }
            if (!this.m_iDup_flag.Equals(x_oObj.m_iDup_flag)) { return false; }
            if (!this.m_sSalesmancodeList.Equals(x_oObj.m_sSalesmancodeList)) { return false; }
            if (!this.m_oResponseMsg.Equals(x_oObj.m_oResponseMsg)) { return false; }
            if (!this.m_oDB.Equals(x_oObj.m_oDB)) { return false; }
            if (!this.m_sSalesmancode.Equals(x_oObj.m_sSalesmancode)) { return false; }
            if (!this.m_iDone_flag.Equals(x_oObj.m_iDone_flag)) { return false; }
            if (!this.m_sTrade_field.Equals(x_oObj.m_sTrade_field)) { return false; }
            if (!this.m_iAdd_flag.Equals(x_oObj.m_iAdd_flag)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_iRwlOrderID.Equals(x_oObj.m_iRwlOrderID)) { return false; }
            if (!this.m_sMrt.Equals(x_oObj.m_sMrt)) { return false; }
            if (!this.m_sConnStr.Equals(x_oObj.m_sConnStr)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_iProg_Lv = -1;
            this.m_sPrefix = Configurator.MSSQLTablePrefix;
            this.m_sStaff_no = string.Empty;
            this.m_sAction_required = string.Empty;
            this.m_iDup_flag = -1;
            this.m_sSalesmancodeList = string.Empty;
            this.m_oResponseMsg = null;
            this.m_oDB = null;
            this.m_sSalesmancode = string.Empty;
            this.m_iDone_flag = -1;
            this.m_sTrade_field = string.Empty;
            this.m_iAdd_flag = -1;
            this.m_sUid = string.Empty;
            this.m_iRwlOrderID = -1;
            this.m_sMrt = string.Empty;
            this.m_sConnStr = string.Empty;
        }
        #endregion Release


        #region DeepClone
        public MobileOrderViewControler DeepClone()
        {
            MobileOrderViewControler MobileOrderViewControler_Clone = new MobileOrderViewControler();
            MobileOrderViewControler_Clone.SetProg_Lv(this.m_iProg_Lv);
            MobileOrderViewControler_Clone.SetPrefix(this.m_sPrefix);
            MobileOrderViewControler_Clone.SetStaff_no(this.m_sStaff_no);
            MobileOrderViewControler_Clone.SetAction_required(this.m_sAction_required);
            MobileOrderViewControler_Clone.SetDup_flag(this.m_iDup_flag);
            MobileOrderViewControler_Clone.SetSalesmancodeList(this.m_sSalesmancodeList);
            MobileOrderViewControler_Clone.SetResponseMsg(this.m_oResponseMsg);
            MobileOrderViewControler_Clone.SetDB(this.m_oDB);
            MobileOrderViewControler_Clone.SetSalesmancode(this.m_sSalesmancode);
            MobileOrderViewControler_Clone.SetDone_flag(this.m_iDone_flag);
            MobileOrderViewControler_Clone.SetTrade_field(this.m_sTrade_field);
            MobileOrderViewControler_Clone.SetAdd_flag(this.m_iAdd_flag);
            MobileOrderViewControler_Clone.SetUid(this.m_sUid);
            MobileOrderViewControler_Clone.SetRwlOrderID(this.m_iRwlOrderID);
            MobileOrderViewControler_Clone.SetMrt(this.m_sMrt);
            MobileOrderViewControler_Clone.SetConnStr(this.m_sConnStr);
            return MobileOrderViewControler_Clone;
        }
        #endregion Clone

    }
}
