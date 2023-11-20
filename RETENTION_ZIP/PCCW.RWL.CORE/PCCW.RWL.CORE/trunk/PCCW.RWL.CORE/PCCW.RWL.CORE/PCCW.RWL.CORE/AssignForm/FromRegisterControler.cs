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
using System.Data.Odbc;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using NEURON.ENTITY.FRAMEWORK.STOCK;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[FromRegisterControler],Data Relation Access Object Control>
///-- =============================================

namespace PCCW.RWL.CORE
{
    public class FromRegisterControler
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Existing Customer Type
        public static global::System.Linq.IQueryable<TariffFeeScheduleEntity> Get_ExistCustomerType()
        {

            TariffFeeScheduleRepositoryBase _oTariffFeeScheduleRepositoryBase =
                new TariffFeeScheduleRepositoryBase(SYSConn<MSSQLConnect>.Connect());
            IQueryable<TariffFeeScheduleEntity> _oRwlTariffFeeList =
                from sRwlTariffFee in _oTariffFeeScheduleRepositoryBase.TariffFeeSchedules
                where
                sRwlTariffFee.active == true
                select sRwlTariffFee;

            //DISTINCT program later
            return _oRwlTariffFeeList;
        }
        #endregion

        #region Fee List
        public static global::System.Linq.IQueryable<TariffFeeScheduleEntity> Get_OrgFeeList(string x_sProgram)
        {
            TariffFeeScheduleRepositoryBase _oTariffFeeScheduleRepositoryBase =
                new TariffFeeScheduleRepositoryBase(SYSConn<MSSQLConnect>.Connect());
            IQueryable<TariffFeeScheduleEntity> _oRwlTariffFeeList =
                from sRwlTariffFee in _oTariffFeeScheduleRepositoryBase.TariffFeeSchedules
                where
                sRwlTariffFee.active == true && sRwlTariffFee.program == x_sProgram.Trim()
                select sRwlTariffFee;
            //DISTINCT fee later
            return _oRwlTariffFeeList;
        }
        #endregion

        #region Suspend  Reasons
        public static global::System.Linq.IQueryable<SuspendEventDetailEntity> Get_SuspendReasons()
        {
            SuspendEventDetailRepositoryBase _oSuspendEventDetailRepositoryBase =
                new SuspendEventDetailRepositoryBase(SYSConn<MSSQLConnect>.Connect());
            IQueryable<SuspendEventDetailEntity> _oRwlSuspendList =
                from sRwlSuspendList in _oSuspendEventDetailRepositoryBase.SuspendEventDetails
                where sRwlSuspendList.active == true
                select sRwlSuspendList;

            return _oRwlSuspendList;
        }
        #endregion

        #region Program List
        public static global::System.Linq.IQueryable<BusinessTradeEntity> Get_ProgramList()
        {
            string _sMobileLevelDesc = string.Empty;
            return FromRegisterControler.Get_ProgramList(string.Empty, ref _sMobileLevelDesc);
        }

        public static global::System.Linq.IQueryable<BusinessTradeEntity> Get_ProgramList(string x_sMrt_no, ref string x_sMobileLevelDesc,string x_sIssue_type)
        {
            BusinessTradeRepositoryBase _oBusinessTradeRepositoryBase =
                new BusinessTradeRepositoryBase(SYSConn<MSSQLConnect>.Connect());
            IQueryable<BusinessTradeEntity> _oRwlTradeBaseList =
                from sRwlTradeList in _oBusinessTradeRepositoryBase.BusinessTrades.AsQueryable<BusinessTradeEntity>()
                where sRwlTradeList.active == true &&
                (sRwlTradeList.edate == null || sRwlTradeList.edate > DateTime.Now.AddDays(-1)) &&
                (sRwlTradeList.sdate == null || sRwlTradeList.sdate <= DateTime.Now)
                select sRwlTradeList;
            if (!string.IsNullOrEmpty(x_sMrt_no))
            {
                //-------MobileOne---------//
                MobileOneLevel _oMobileOneLevel = MobileOneLevel.Instance();
                _oRwlTradeBaseList = _oMobileOneLevel.GetPermitProgram(_oRwlTradeBaseList, x_sMrt_no, ref x_sMobileLevelDesc);
                //-------------------------------//
            }
            if (!string.IsNullOrEmpty(x_sIssue_type))
            {
              _oRwlTradeBaseList = _oRwlTradeBaseList.Where(c => c.issue_type == x_sIssue_type).Select(c => c);
            }
            return _oRwlTradeBaseList;
        }
        public static global::System.Linq.IQueryable<BusinessTradeEntity> Get_ProgramList(string x_sMrt_no, ref string x_sMobileLevelDesc)
        {
            return FromRegisterControler.Get_ProgramList( x_sMrt_no,ref  x_sMobileLevelDesc,string.Empty);
        }
        #endregion

        #region Get PlanList
        protected global::System.Data.SqlClient.SqlDataReader GetPlanList(
            string x_sProgram, string x_sNormal_rebate_type, string x_sChannel)
        {
            StringBuilder _oFilter = new StringBuilder();
            string _sFilter = string.Empty;
            //if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");
            //if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            //if (x_sChannel == null) throw new ArgumentNullException("x_sChannel");
            _oFilter.Append("active=1 and rate_plan<>'' ");
            _oFilter.Append(" AND rate_plan is not null ");
            _oFilter.Append(" AND (edate is null or edate >getdate()-1)");
            _oFilter.Append(" AND sdate<=getdate() ");
            _oFilter.Append(" AND program='" + x_sProgram.Trim() + "'");
            _oFilter.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            _oFilter.Append(" AND channel in ('ALL'");
            if (!string.IsNullOrEmpty(x_sChannel.Trim()))
                _oFilter.Append(",'" + x_sChannel.Trim() + "'");
            else
                _oFilter.Append(",'IB','OB'");
            return BusinessTradeBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "DISTINCT rate_plan", _oFilter.ToString(), null, null);
        }
        #endregion

        #region Get Channel
        public string Get_Channel_By_Staff_no(string x_sStaff_no)
        {
            if (string.IsNullOrEmpty(x_sStaff_no)) return string.Empty;
            return SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT staff_type FROM [CSSDB].[csc].[staffinfo_new]  WITH (NOLOCK)  WHERE staff_no2='" + x_sStaff_no.Trim() + "'");
        }

        public string Get_Channel_By_TeamCode(string x_sTeamcode)
        {
            string _sChannel = string.Empty;
            if (string.IsNullOrEmpty(x_sTeamcode)) return string.Empty;
            x_sTeamcode = x_sTeamcode.Trim();
            StringBuilder _oQuery = new StringBuilder();
            if (x_sTeamcode == null) throw new ArgumentNullException("x_sTeamcode");

            _oQuery.Append("SELECT [CHANNEL] FROM [CSSDB].[CSC].[boc_info]  WITH (NOLOCK) ");
            _oQuery.Append("where teamcode = '" + x_sTeamcode + "' ");
            _oQuery.Append("AND sdate < getdate() and (edate > getdate() or edate is null)");
            _oQuery.Append("AND channel is not null");
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery.ToString());
            if (_oReader != null)
            {
                if (_oReader.Read())
                {
                    _sChannel = _oReader["channel"].ToString();
                }
            }
            if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            return _sChannel;
        }
        #endregion

        #region Get TeamLeader
        public string Get_TeamLeader_By_TeamCode(string x_sTeamcode)
        {
            string _sStaff_name = string.Empty;
            StringBuilder _oQuery = new StringBuilder();
            if (x_sTeamcode == null) throw new ArgumentNullException("x_sTeamcode");

            _oQuery.Append(" SELECT a.leader1_sn,a.leader2_sn,a.leader3_sn, ");
            _oQuery.Append(" 'leader1_name' = (SELECT TOP 1 staff_name FROM csc.Staffinfo_new WITH (NOLOCK) WHERE staff_no2=a.leader1_sn), ");
            _oQuery.Append(" 'leader2_name' = (SELECT TOP 1 staff_name FROM csc.Staffinfo_new WITH (NOLOCK) WHERE staff_no2=a.leader1_sn), ");
            _oQuery.Append(" 'leader3_name' = (SELECT TOP 1 staff_name FROM csc.Staffinfo_new WITH (NOLOCK) WHERE staff_no2=a.leader1_sn) ");
            _oQuery.Append(" FROM csc.boc_info a WHERE a.teamcode='" + x_sTeamcode + "' ");
            _oQuery.Append(" AND sdate<=getdate() AND (edate>=getdate() or edate is null) AND active=1 ");
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_oQuery.ToString());
            if (_oReader != null)
            {
                if (_oReader.Read())
                {
                    _sStaff_name = _oReader["leader1_name"].ToString().Trim();
                    if (string.IsNullOrEmpty(_sStaff_name))
                        _sStaff_name = _oReader["leader2_name"].ToString().Trim();
                    if (string.IsNullOrEmpty(_sStaff_name))
                        _sStaff_name = _oReader["leader3_name"].ToString().Trim();
                }
            }
            if (_oReader != null) _oReader.Close();
            return _sStaff_name;

        }
        #endregion

        #region Get District

        public static List<string> GetLocation(string x_sRegion)
        {
            List<string> _oList = new List<string>();
            _oList.Add(string.Empty);
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT location FROM DeliveryLocation WHERE area='" + x_sRegion + "' AND active=1");
            while (_oDr.Read())
            {
                _oList.Add(Func.FR(_oDr["location"]).ToString());
            }
            _oDr.Close();
            _oDr.Dispose();
            return _oList;
        }


        public DeliveryLocationEntity[] Get_District_Arr()
        {
            DeliveryLocationEntity[] _oDeliveryLocationRecords =
                DeliveryLocationBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "active=1", null, DeliveryTimeRecord.Para.location);
            return _oDeliveryLocationRecords;
        }

        public static global::System.Data.SqlClient.SqlDataReader Get_District_DataReader()
        {
            return DeliveryLocationBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "location", "active=1", null, "location");
        }

        private bool RemoveLocation(System.Nullable<int> x_iId)
        {
            if (Convert.IsDBNull(x_iId) || x_iId == null) return false;
            string _sQuery = "DELETE FROM [DeliveryTimeRecord] WHERE [DeliveryTimeRecord].[id]=@id";
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@id", SqlDbType.Int).Value = x_iId;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception error)
                {
                }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _bResult;
            }
        }
        #endregion

        #region Check IPHONE 3
        #region CheckEOrder IPHONE 3
        public static bool CheckEOrderIPhone3(string x_sHkid)
        {
            bool _bFlag = false;
            //string _sQuery = "SELECT top 1 hs_model FROM csc.pccwmsns_order where active = 1 and hs_model in ('2420731','2420911','2420961','2420971','2420981') and r_hkid = '" + x_sHkid + "'";
            string _sQuery = "SELECT TOP 1 hs_model FROM csc.pccwmsns_order WITH (NOLOCK) WHERE active = 1 and hs_model in ('2421051','2420731','2420911','2420961','2420971','2420981') and r_hkid = '" + x_sHkid + "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckNewRWL IPHONE 3
        public static bool CheckNewRWLIPhone3(string x_sHkid, string x_sOrder_id)
        {
            bool _bFlag = false;
            string _sQuery = "SELECT TOP 1 hs_model FROM dbo.MobileRetentionOrder WITH (NOLOCK) WHERE active = 1 AND hs_model is not null AND hs_model<>'' AND sku in ('2421051','2420731','2420911','2420961','2420971','2420981') and hkid = '" + x_sHkid + "' and order_id <> '" + x_sOrder_id + "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckIPhoneCoupon IPHONE 3
        public static bool CheckIPhoneCouponIPhone3(string x_sHkid)
        {
            bool _bFlag = false;
            //string _sQuery = "SELECT top 1 custom_id FROM csc.IPhoneCoupon WHERE isuse=1 AND custom_id = '" + x_sHkid + "'";
            string _sQuery = "SELECT top 1 custom_id FROM csc.IPhoneCoupon WITH (NOLOCK) WHERE isuse=1 AND custom_id = '" + x_sHkid + "' and type='IPHONE 3'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckAllSystemIPhoneOrder IPHONE 3
        public static bool CheckAllSystemIPhoneOrderIPhone3(string x_sHkid, string x_sOrder_id)
        {
            if (string.IsNullOrEmpty(x_sHkid)) x_sHkid = string.Empty;
            if (string.IsNullOrEmpty(x_sOrder_id)) x_sOrder_id = string.Empty;
            if (CheckEOrderIPhone3(x_sHkid) || CheckNewRWLIPhone3(x_sHkid, x_sOrder_id) || CheckIPhoneCouponIPhone3(x_sHkid))
                return true;
            else
                return false;
        }
        #endregion
        #endregion check IPHONE 3

        #region Is IPhone Concierge
        public static bool IsIPhoneConciergeHandSet(string x_sSku)
        {
            if (string.IsNullOrEmpty(x_sSku)) { return false; }
            if (x_sSku == "2421051" || 
             x_sSku == "2420731" || 
            x_sSku == "2420911" || 
             x_sSku == "2420961" || 
            x_sSku == "2420971" || 
             x_sSku == "2420981" 
           )
            {
                return true;
            }

            if (x_sSku == "2421161" ||  
            x_sSku == "2421171" || 
                x_sSku == "2421451" || 
                x_sSku == "2421461")
            {
                return true;
            }

            if (x_sSku == "2421101" || 
            x_sSku == "2421111" || 
            x_sSku == "2421121" 
            )
            {
                return true; 
            }

            return false;
        }
        #endregion

        #region Check IPHONE 4
        #region CheckEOrder IPHONE 4
        public static bool CheckEOrderIPhone4(string x_sHkid)
        {
            bool _bFlag = false;
            string _sQuery = "SELECT TOP 1 hs_model FROM csc.pccwmsns_order  WITH (NOLOCK) WHERE active = 1 AND hs_model in ('2421161','2421171','2421451','2421461') and r_hkid = '" + x_sHkid + "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckNewRWL IPHONE 4
        public static bool CheckNewRWLIPhone4(string x_sHkid, string x_sOrder_id)
        {
            bool _bFlag = false;
            string _sQuery = "SELECT TOP 1 hs_model FROM dbo.MobileRetentionOrder WITH (NOLOCK) WHERE active = 1 AND hs_model is not null AND hs_model<>'' AND sku in ('2421161','2421171','2421451','2421461') and hkid = '" + x_sHkid + "' and order_id <> '" + x_sOrder_id + "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckIPhoneCoupon IPHONE 4
        public static bool CheckIPhoneCouponIPhone4(string x_sHkid)
        {
            bool _bFlag = false;
            string _sQuery = "SELECT TOP 1 custom_id FROM csc.IPhoneCoupon WITH (NOLOCK) WHERE isuse=1 AND custom_id = '" + x_sHkid + "' and type='IPHONE 4'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckAllSystemIPhoneOrder IPHONE 4
        public static bool CheckAllSystemIPhoneOrderIPhone4(string x_sHkid, string x_sOrder_id)
        {
            if (string.IsNullOrEmpty(x_sHkid)) x_sHkid = string.Empty;
            if (string.IsNullOrEmpty(x_sOrder_id)) x_sOrder_id = string.Empty;
            if (CheckEOrderIPhone4(x_sHkid) || CheckNewRWLIPhone4(x_sHkid, x_sOrder_id) || CheckIPhoneCouponIPhone4(x_sHkid))
                return true;
            else
                return false;
        }
        #endregion
        #endregion check IPHONE 4

        #region Check IPAD
        #region CheckEOrder IPAD
        public static bool CheckEOrderIPad(string x_sHkid)
        {
            bool _bFlag = false;
            string _sQuery = "SELECT TOP 1 hs_model FROM csc.pccwmsns_order  WITH (NOLOCK)  WHERE active = 1 AND hs_model in ('2421101','2421111','2421121') AND r_hkid = '" + x_sHkid + "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckNewRWL IPAD
        public static bool CheckNewRWLIPad(string x_sHkid, string x_sOrder_id)
        {
            bool _bFlag = false;
            string _sQuery = "SELECT TOP 1 hs_model FROM dbo.MobileRetentionOrder WITH (NOLOCK) WHERE active = 1 AND hs_model is not null AND hs_model<>'' AND sku in ('2421101','2421111','2421121') AND hkid = '" + x_sHkid + "'  AND order_id = '" + x_sOrder_id + "'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckIPhoneCoupon IPAD
        public static bool CheckIPhoneCouponIPad(string x_sHkid)
        {
            bool _bFlag = false;
            string _sQuery = "SELECT TOP 1 custom_id FROM csc.IPhoneCoupon WITH (NOLOCK) WHERE isuse=1 AND custom_id = '" + x_sHkid + "' and type='IPAD'";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect("CSSDB").GetSearch(_sQuery);
            if (_oDr.Read())
            {
                _bFlag = true;
            }
            _oDr.Close();
            _oDr.Dispose();
            return _bFlag;
        }
        #endregion

        #region CheckAllSystemIPhoneOrder IPAD
        public static bool CheckAllSystemIPhoneOrderIPad(string x_sHkid, string x_sOrder_id)
        {
            if (string.IsNullOrEmpty(x_sHkid)) x_sHkid = string.Empty;
            if (string.IsNullOrEmpty(x_sOrder_id)) x_sOrder_id = string.Empty;
            if (CheckEOrderIPad(x_sHkid) || CheckNewRWLIPad(x_sHkid, x_sOrder_id) || CheckIPhoneCouponIPad(x_sHkid))
                return true;
            else
                return false;
        }
        #endregion
        #endregion check IPAD

        #region Get Staff Info
        public Staffinfo_new Get_StaffInfoEntity(string x_sStaffno)
        {
            if (x_sStaffno == null) throw new ArgumentNullException("x_sStaffno");

            string _sSalecode = string.Empty;
            string _sSalename = string.Empty;
            string _sExtn = string.Empty;

            OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch("SELECT salecode,salename,extn FROM saleinfo  WHERE saleid1 = '" + x_sStaffno + "'");
            if (_oDr.Read())
            {
                _sSalecode = Func.FR(_oDr["salecode"]);
                _sSalename = Func.FR(_oDr["salename"]);
                _sExtn = Func.FR(_oDr["extn"]);
            }
            _oDr.Close();
            _oDr.Dispose();

            Staffinfo_new _oStaffinfo_new = new Staffinfo_new(SYSConn<MSSQLConnect>.Connect(), x_sStaffno, x_sStaffno);
            if (!_sSalecode.Trim().Equals(string.Empty)) { _oStaffinfo_new.SetSalesman_code(_sSalecode); }
            if (!_sSalename.Trim().Equals(string.Empty)) { _oStaffinfo_new.SetStaff_name(_sSalename); }
            if (_sExtn.Trim().Equals(string.Empty)) { _oStaffinfo_new.EXTN = _sExtn; }
            return _oStaffinfo_new;
        }
        #endregion

        #region Get Gift Desc
        public static global::System.Data.SqlClient.SqlDataReader Get_GiftDescList_DataReader()
        {
            StringBuilder _oFilter = new StringBuilder();
            _oFilter.Append("active=1 and (edate is null or edate >getdate()-1) and sdate<=getdate()");
            return GiftBasketBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "DISTINCT gift_desc", _oFilter.ToString(), null, null);
        }
        #endregion

        #region Get Accessory Desc
        public static global::System.Data.SqlClient.SqlDataReader Get_AccessoryDescList_DataReader()
        {
            StringBuilder _oFilter = new StringBuilder();
            _oFilter.Append(" active=1 AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
            _oFilter.Append(" AND accessory_desc <> 'LENOVO S10-2 (6 CELL/BLACK COLOR/TC XP HOME)' AND accessory_desc <> 'SAMSUNG NP-N135 (6 CELL/WHITE COLOR/XP HOME)'");
            return AccessoryBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "DISTINCT accessory_desc", _oFilter.ToString(), null, null);
        }
        #endregion

        #region Get Bank
        public static global::System.Data.SqlClient.SqlDataReader Get_BankList_DataReader()
        {
            return BankCodeBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "DISTINCT bank_name,bank_code", "active=1", null, null);
        }

        public static global::System.Data.SqlClient.SqlDataReader Get_BankNameList_DataReader(bool _bActive)
        {
            return BankCodeBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "DISTINCT bank_name", ((_bActive) ? "active=1" : "active=0"), null, null);
        }
        protected bool BankProfileUpdate(
            System.Nullable<bool> x_bActive, string x_sBank_name,
            string x_sBank_code, string x_sMin_amount)
        {

            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("UPDATE  [BankCode]  SET ");
            _oQuery.Append("[active]=@active,[bank_name]=@bank_name,[bank_code]=@bank_code,[min_amount]=@min_amount ");
            _oQuery.Append(" WHERE [BankCode].[mid]=@mid");
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_oQuery.ToString(), _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value = x_bActive;
                _oCmd.Parameters.Add("@bank_name", SqlDbType.VarChar).Value = x_sBank_name;
                _oCmd.Parameters.Add("@bank_code", SqlDbType.VarChar).Value = x_sBank_code;
                _oCmd.Parameters.Add("@min_amount", SqlDbType.NVarChar).Value = x_sMin_amount;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception error)
                {
                    Logger.ErrorFormat("FromRegisterControler: {0}", error.ToString());
                }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _bResult;
            }
        }


        
        private bool BankProfileRemove(System.Nullable<int> x_iMid)
        {
            if (Convert.IsDBNull(x_iMid) || x_iMid == null) return false;
            string _sQuery = "DELETE FROM [BankCode] WHERE [BankCode].[mid]=@mid";
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@mid", SqlDbType.Int).Value = x_iMid;
                try
                {
                    _oConn.Open();
                    _bResult = Convert.ToBoolean(_oCmd.ExecuteNonQuery());
                }
                catch (Exception error)
                {
                    Logger.ErrorFormat("FormRegisterControler:{0}", error.ToString());
                }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _bResult;
            }
        }
        #endregion

        public static ObjectArr GetNormalRebateTypeList(bool x_bIncludeAll)
        {
            ObjectArr _oNormalRebateTypeList = new ObjectArr();
            if (x_bIncludeAll)
                _oNormalRebateTypeList.Add("ALL",string.Empty);
            _oNormalRebateTypeList.Add("RETENTION", "RETENTION");
            _oNormalRebateTypeList.Add("RETENTION+", "RETENTION+");
            _oNormalRebateTypeList.Add("LOYAL RETENTION+", "LOYAL RETENTION+");
            _oNormalRebateTypeList.Add("SPECIAL RETENTION", "SPECIAL RETENTION");
            _oNormalRebateTypeList.Add("T-5 UPSELLING", "T-5 UPSELLING");
            _oNormalRebateTypeList.Add("SIM ONLY T-5 UPSELLING", "SIM ONLY T-5 UPSELLING");
            _oNormalRebateTypeList.Add("SPECIAL MARKER RETENTION", "SPECIAL MARKER RETENTION");
            _oNormalRebateTypeList.Add("SPECIAL RETENTION (OB PROGRAM)", "SPECIAL RETENTION (OB PROGRAM)");
            _oNormalRebateTypeList.Add("SIM UPSELL", "SIM UPSELL");
            _oNormalRebateTypeList.Add("SMARTPHONE(I) PLAN(2)", "SMARTPHONE(I) PLAN(2)");
            _oNormalRebateTypeList.Add("SMARTPHONE(I) PLAN(2) SPECIAL", "SMARTPHONE(I) PLAN(2) SPECIAL");
            _oNormalRebateTypeList.Add("PUBLIC HOUSING", "PUBLIC HOUSING");
            _oNormalRebateTypeList.Add("T-12 UPSELLING", "T-12 UPSELLING");
            _oNormalRebateTypeList.Add("NE BASE", "NE BASE");
            _oNormalRebateTypeList.Add("GW BASE", "GW BASE");
            return _oNormalRebateTypeList;
        }


        #region Get Trade field
        public static global::System.Collections.Generic.List<string> Get_TradeFieldList(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs,
            string x_sRate_plan, string x_sRebate, string x_sNormal_rebate_type,
            string x_sChannel, string x_sHsmodel_name, string x_sPremium_name, string x_sFree_mon, ref bool x_bDisabledHandSet, ref bool x_bDisabledPremium)
        {

            return FromRegisterControler.Get_TradeFieldList(x_sProgram, x_sCon_per, x_sPlan_fee_rs, x_sRate_plan, x_sRebate, x_sNormal_rebate_type, x_sChannel, x_sHsmodel_name,
                x_sPremium_name, x_sFree_mon, ref x_bDisabledHandSet, ref x_bDisabledPremium, string.Empty);
        }


        public static global::System.Collections.Generic.List<string> Get_TradeFieldList(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs,
            string x_sRate_plan, string x_sRebate, string x_sNormal_rebate_type,
            string x_sChannel, string x_sHsmodel_name, string x_sPremium_name, string x_sFree_mon, ref bool x_bDisabledHandSet, ref bool x_bDisabledPremium,string x_sIssue_type)
        {
            if (x_sProgram == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sProgram");
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_sHsmodel == null) throw new ArgumentNullException("x_sHsmodel");
            //if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            //if (x_sPlan_fee_rs == null) throw new ArgumentNullException("x_sPlan_fee_rs");
            //if (x_sRate_plan == null) throw new ArgumentNullException("x_sRate_plan");
            global::System.Collections.Generic.List<string> _oTradeFieldList = new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _sQuery1 = new global::System.Text.StringBuilder();
            global::System.Text.StringBuilder _sQuery2 = new global::System.Text.StringBuilder();
            _sQuery1.Append("SELECT [mid],[program],[retention_type],[normal_rebate],[rate_plan],[con_per],[rebate],[free_mon],[hs_model],[hs_model_name],[premium_1],[premium_2],[trade_field],[bundle_name],[plan_fee],[cancel_renew],[channel],[ob_early],[sdate],[edate],[active],[cid],[cdate],[did],[ddate],[extra_offer],[po_date],[remarks],[normal_rebate_type] FROM " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _sQuery1.Append(" WHERE active=1 AND trade_field!='' AND trade_field is not null AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
            _sQuery1.Append(" AND program='" + x_sProgram.Trim() + "'");
            _sQuery1.Append(" AND con_per='" + x_sCon_per.Trim() + "'");
            _sQuery1.Append(" AND rate_plan='" + x_sRate_plan.Trim() + "'");
            _sQuery1.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery1.Append(" AND issue_type='" + x_sIssue_type.Trim() + "'"); }
            if (!x_sHsmodel_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model_name='" + x_sHsmodel_name.Trim() + "' OR  hs_model_name='' OR hs_model_name IS NULL) ");

            if (!x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (premium_1='" + x_sPremium_name.Trim() + "' OR  premium_1='' OR premium_1 IS NULL) ");

            if (!x_sHsmodel_name.Trim().Equals(string.Empty) &&
                x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='Y')");

            if (x_sHsmodel_name.Trim().Equals(string.Empty) &&
                !x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='P') ");

            if (!x_sHsmodel_name.Trim().Equals(string.Empty) &&
                !x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='A' )");

            if (x_sHsmodel_name.Trim().Equals(string.Empty) &&
                x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='' OR hs_model IS NULL )");

            if (!string.IsNullOrEmpty(x_sRebate))
                _sQuery1.Append(" AND rebate='" + x_sRebate + "' ");
            else
                _sQuery1.Append(" AND (rebate='' OR rebate is null) ");

            if (!x_sFree_mon.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND free_mon='" + x_sFree_mon.Trim() + "' ");
            else
                _sQuery1.Append(" AND (free_mon='' OR free_mon is null) ");

            _sQuery1.Append(" AND channel in ('ALL'");
            if (!x_sChannel.Trim().Equals(string.Empty))
                _sQuery1.Append(",'" + x_sChannel.Trim() + "'");
            else
                _sQuery1.Append(",'IB','OB'");
            _sQuery1.Append(")");


            x_bDisabledHandSet = false;
            x_bDisabledPremium = false;
            DataSet _oDS = SYSConn<MSSQLConnect>.Connect().GetDS(_sQuery1.ToString());
            IDSQuery _oDR = IDSQuery.CreateDsCriteria(_oDS, string.Empty);
            while (_oDR.Read())
            {
                string _sTradeField = _oDR[BusinessTrade.Para.trade_field].ToString().Trim();
                if (!_oTradeFieldList.Contains(_sTradeField) && 
                    !string.IsNullOrEmpty(_sTradeField))
                {
                    _oTradeFieldList.Add(_sTradeField);
                }
            }
            _oDR.Close();
            CheckDistableHandSetOrPremium(_oDS,ref x_bDisabledHandSet, ref x_bDisabledPremium);
            
            return _oTradeFieldList;
        }
        #endregion

        protected static void CheckDistableHandSetOrPremium(DataSet x_oDs, ref bool x_bDisabledHandSet, ref bool x_bDisabledPremium)
        {
            bool _bA = false;
            bool _bY = false;
            bool _bP = false;

            IDSQuery _oDR = IDSQuery.CreateDsCriteria(x_oDs, string.Empty);
            while (_oDR.Read())
            {
                string _sHs_model = _oDR[BusinessTrade.Para.hs_model].ToString().Trim().ToUpper();
                if (_sHs_model.Equals("A"))
                {
                    _bA = true;
                    break;
                }
                if (_sHs_model.Equals("Y")) { _bY = true; }
                if (_sHs_model.Equals("P")) { _bP = true; }
            }
            _oDR.Close();

            if (_bA)
            {
                x_bDisabledHandSet = false;
                x_bDisabledPremium = false;
            }
            else if (_bY == true && _bP == false && _bA == false)
            {
                x_bDisabledHandSet = false;
                x_bDisabledPremium = true;
            }
            else if (_bP == true && _bY == false && _bA == false)
            {
                x_bDisabledHandSet = true;
                x_bDisabledPremium = false;
            }
        }


        #region Get Bundle Name
        public static global::System.Collections.Generic.List<string> Get_BundleNameList(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs, string x_sRate_plan, string x_sRebate,
            string x_sNormal_rebate_type, string x_sChannel, string x_sHsmodel_name, string x_sPremium_name, string x_sFree_mon, ref bool x_bDisabledHandSet, ref bool x_bDisabledPremium)
        {
            return FromRegisterControler.Get_BundleNameList(x_sProgram, x_sCon_per, x_sPlan_fee_rs, x_sRate_plan, x_sRebate, x_sNormal_rebate_type,
                x_sChannel, x_sHsmodel_name, x_sPremium_name, x_sFree_mon, ref x_bDisabledHandSet, ref x_bDisabledPremium, string.Empty);

        }


        public static global::System.Collections.Generic.List<string> Get_BundleNameList(
            string x_sProgram, string x_sCon_per, string x_sPlan_fee_rs, string x_sRate_plan, string x_sRebate,
            string x_sNormal_rebate_type, string x_sChannel, string x_sHsmodel_name, string x_sPremium_name, string x_sFree_mon, ref bool x_bDisabledHandSet, ref bool x_bDisabledPremium, string x_sIssue_type)
        {
            //if (x_sProgram == null) throw new ArgumentNullException("x_sProgram");
            //if (x_sCon_per == null) throw new ArgumentNullException("x_sCon_per");
            //if (x_sHsmodel == null) throw new ArgumentNullException("x_sHsmodel");
            //if (x_sNormal_rebate_type == null) throw new ArgumentNullException("x_sNormal_rebate_type");
            //if (x_sPlan_fee_rs == null) throw new ArgumentNullException("x_sPlan_fee_rs");
            //if (x_sRate_plan == null) throw new ArgumentNullException("x_sRate_plan");
            global::System.Collections.Generic.List<string> _oBundleNameList = new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _sQuery1 = new global::System.Text.StringBuilder();
            global::System.Text.StringBuilder _sQuery2 = new global::System.Text.StringBuilder();
            _sQuery1.Append("SELECT [mid],[program],[retention_type],[normal_rebate],[rate_plan],[con_per],[rebate],[free_mon],[hs_model],[hs_model_name],[premium_1],[premium_2],[trade_field],[bundle_name],[plan_fee],[cancel_renew],[channel],[ob_early],[sdate],[edate],[active],[cid],[cdate],[did],[ddate],[extra_offer],[po_date],[remarks],[normal_rebate_type]  FROM " + Configurator.MSSQLTablePrefix + "BusinessTrade with (nolock) ");
            _sQuery1.Append(" WHERE active=1   AND bundle_name!='' AND bundle_name is not null  AND (edate is null or edate >getdate()-1) AND sdate<=getdate() ");
            _sQuery1.Append(" AND program='" + x_sProgram.Trim() + "'");
            _sQuery1.Append(" AND con_per='" + x_sCon_per.Trim() + "'");
            _sQuery1.Append(" AND rate_plan='" + x_sRate_plan.Trim() + "'");
            _sQuery1.Append(" AND normal_rebate_type='" + x_sNormal_rebate_type.Trim() + "'");
            if (!string.IsNullOrEmpty(x_sIssue_type)) { _sQuery1.Append(" AND issue_type='" + x_sIssue_type.Trim() + "'"); }
            if (!x_sHsmodel_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model_name='" + x_sHsmodel_name.Trim() + "' or  hs_model_name='' or hs_model_name is null) ");

            if (!x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (premium_1='" + x_sPremium_name.Trim() + "' or  premium_1='' or premium_1 is null) ");

            if (!x_sHsmodel_name.Trim().Equals(string.Empty) &&
                x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='Y')");

            if (x_sHsmodel_name.Trim().Equals(string.Empty) &&
                !x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='P' ) ");

            if (!x_sHsmodel_name.Trim().Equals(string.Empty) &&
                !x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='A' )");

            if (x_sHsmodel_name.Trim().Equals(string.Empty) &&
                x_sPremium_name.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND (hs_model='' OR hs_model IS NULL )");


            if (!string.IsNullOrEmpty(x_sRebate))
                _sQuery1.Append(" AND rebate='" + x_sRebate + "' ");
            else
                _sQuery1.Append(" AND (rebate='' OR rebate is null) ");

            if (!x_sFree_mon.Trim().Equals(string.Empty))
                _sQuery1.Append(" AND free_mon='" + x_sFree_mon.Trim() + "' ");
            else
                _sQuery1.Append(" AND (free_mon='' OR free_mon is null) ");

            _sQuery1.Append(" AND channel in ('ALL'");
            if (!x_sChannel.Trim().Equals(string.Empty))
                _sQuery1.Append(",'" + x_sChannel.Trim() + "'");
            else
                _sQuery1.Append(",'IB','OB'");
            _sQuery1.Append(")");

            x_bDisabledHandSet = false;
            x_bDisabledPremium = false;
            DataSet _oDS = SYSConn<MSSQLConnect>.Connect().GetDS(_sQuery1.ToString());
            IDSQuery _oDR = IDSQuery.CreateDsCriteria(_oDS, string.Empty);
            while (_oDR.Read())
            {
                string _sBundleName= _oDR[BusinessTrade.Para.bundle_name].ToString().Trim();
                if (!_oBundleNameList.Contains(_sBundleName) &&
                    !string.IsNullOrEmpty(_sBundleName))
                {
                    _oBundleNameList.Add(_sBundleName);
                }
            }
            _oDR.Close();

            CheckDistableHandSetOrPremium(_oDS,ref x_bDisabledHandSet, ref x_bDisabledPremium);

            return _oBundleNameList;
        }
        #endregion

        public static bool UseProgramRebateMapping(string x_sProgram,string x_sIssue_type)
        {
            bool _bUse = true;
            if (string.IsNullOrEmpty(x_sProgram)) return true;
            if (string.IsNullOrEmpty(x_sIssue_type)) return true;
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT TOP 1 program FROM ProgramRebateMapping WHERE ");
            _oQuery.Append("program='" + x_sProgram + "' AND issue_type='" + x_sIssue_type + "' AND active=1");
            string _sProgram = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
            if (!string.IsNullOrEmpty(_sProgram))
            {
                
                StringBuilder _oQuery1 = new StringBuilder();
                _oQuery1.Append("SELECT TOP 1 program FROM ProgramRebateMapping WHERE ");
                _oQuery1.Append("program='" + x_sProgram + "' AND issue_type='" + x_sIssue_type + "' AND active=1 AND ");
                _oQuery1.Append("(sdate IS NOT NULL AND sdate<=getdate()) AND (edate IS NULL OR edate>getdate()) AND use_rebate_mapping=1");
                SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_oQuery1.ToString());
                if (_oDr.Read())
                {
                    _bUse = true;
                }
                else
                {
                    _bUse = false;
                }
                _oDr.Close();
                _oDr.Dispose();
            }

            return _bUse;
        }


        #region Item Location
        public static string GetProductionItemLocation(string x_sIssue_type, string x_sProgram, string x_sSku)
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT TOP 1 location FROM ProductItemLocation WHERE ");
            _oQuery.Append("(issue_type='" + x_sIssue_type + "' OR issue_type='ALL') AND ");
            _oQuery.Append("(program='" + x_sProgram + "' OR program='ALL') AND ");
            _oQuery.Append("(sku='" + x_sSku + "' OR sku='ALL') ORDER BY ID DESC");
            return SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
        }
        #endregion

        #region Get DB
        protected static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        #region Get Retenion Rebate
        public static string Retention_rebate(bool x_bNum, string x_sCh)
        {
            if (x_sCh == null) throw new ArgumentNullException("x_sCh");
            if (x_bNum)
            {
                int _iNormal_rebate = 1;
                switch (x_sCh)
                {
                    case "Y":
                        _iNormal_rebate = 1;
                        break;
                    case "N":
                        _iNormal_rebate = 0;
                        break;
                    case "L":
                        _iNormal_rebate = 2;
                        break;
                    case "S":
                        _iNormal_rebate = 3;
                        break;
                    case "T":
                        _iNormal_rebate = 4;
                        break;
                    case "O":
                        _iNormal_rebate = 5;
                        break;
                    case "M":
                        _iNormal_rebate = 6;
                        break;
                }
                return _iNormal_rebate.ToString();
            }
            else
            {
                string _sNormal_rebate = "Y";
                switch (x_sCh)
                {
                    case "Y":
                        _sNormal_rebate = "Y";
                        break;
                    case "N":
                        _sNormal_rebate = "N";
                        break;
                    case "L":
                        _sNormal_rebate = "L";
                        break;
                    case "S":
                        _sNormal_rebate = "S";
                        break;
                    case "T":
                        _sNormal_rebate = "T";
                        break;
                    case "O":
                        _sNormal_rebate = "O";
                        break;
                    case "M":
                        _sNormal_rebate = "M";
                        break;
                }
                return _sNormal_rebate.ToString();
            }
        }
        #endregion


        #region MonthlyPaymentMethodMapping
        public static List<string> GetPaymentMethodList(string x_sProgram,string x_sPayment_Type,string x_sIssue_Type)
        {
            List<string> _oPaymentList = new List<string>();
            StringBuilder _oWhereSQL = new StringBuilder();
            _oWhereSQL.Append("(program='" + x_sProgram + "' OR program='ALL') AND ");
            _oWhereSQL.Append("(payment_type='" + x_sPayment_Type + "' OR payment_type='ALL')");
            _oWhereSQL.Append("AND issue_type='" + x_sIssue_Type + "'");
            List<MonthlyPaymentMethodMappingEntity> _oList =
                MonthlyPaymentMethodMappingRepository.GetListObj(SYSConn<MSSQLConnect>.Connect(), 1, _oWhereSQL.ToString(), null, "ID DESC");

            if (_oList.Count> 0)
            {
                MonthlyPaymentMethodMappingEntity _oMonthlyPaymentMethodMappingEntity =
                    _oList[0];

                if (_oMonthlyPaymentMethodMappingEntity.credit_card_group==true)
                {
                    if (x_sPayment_Type == "MONTHLY PAYMENT")
                    {
                        if (!_oPaymentList.Contains("KEEP EXISTING CREDIT CARD")) { _oPaymentList.Add("KEEP EXISTING CREDIT CARD"); }
                        if (!_oPaymentList.Contains("CHANGE TO CREDIT CARD")) { _oPaymentList.Add("CHANGE TO CREDIT CARD"); }
                    }
                    if (x_sPayment_Type == "PREPAYMENT")
                    {
                        if (!_oPaymentList.Contains("CASH")) { _oPaymentList.Add("CASH"); }
                        if (!_oPaymentList.Contains("CREDIT CARD")) { _oPaymentList.Add("CREDIT CARD"); }
                        if (!_oPaymentList.Contains("CREDIT CARD INSTALLMENT")) { _oPaymentList.Add("CREDIT CARD INSTALLMENT"); }
                    }
                }
                if (_oMonthlyPaymentMethodMappingEntity.third_party_credit_card == true)
                {
                    if (x_sPayment_Type == "MONTHLY PAYMENT")
                        if (!_oPaymentList.Contains("CHANGE TO 3RD PARTY CREDIT CARD")) { _oPaymentList.Add("CHANGE TO 3RD PARTY CREDIT CARD"); }
                }
                if (_oMonthlyPaymentMethodMappingEntity.cash_group == true)
                {
                    if (x_sPayment_Type == "MONTHLY PAYMENT")
                    {
                        if (!_oPaymentList.Contains("KEEP EXISTING COD")) { _oPaymentList.Add("KEEP EXISTING COD"); }
                        if (!_oPaymentList.Contains("CHANGE TO COD")) { _oPaymentList.Add("CHANGE TO COD"); }
                    }
                    if (x_sPayment_Type == "PREPAYMENT")
                    {
                        if (!_oPaymentList.Contains("CASH")) { _oPaymentList.Add("CASH"); }
                    }
                }
                if (_oMonthlyPaymentMethodMappingEntity.bank_account_group == true)
                {
                    if (x_sPayment_Type == "MONTHLY PAYMENT")
                    {
                        if (!_oPaymentList.Contains("KEEP EXISTING BANK ACCOUNT")) { _oPaymentList.Add("KEEP EXISTING BANK ACCOUNT"); }
                        if (!_oPaymentList.Contains("CHANGE TO BANK ACCOUNT")) { _oPaymentList.Add("CHANGE TO BANK ACCOUNT"); }
                    }
                }

            }


            return _oPaymentList;
        }

        #endregion

        protected string n_sD_build = string.Empty;
        #region m_sD_build
        public string m_sD_build
        {
            get
            {
                return this.n_sD_build;
            }
            set
            {
                this.n_sD_build = value;
            }
        }
        #endregion


        protected string n_sGift_desc = string.Empty;
        #region m_sGift_desc
        public string m_sGift_desc
        {
            get
            {
                return this.n_sGift_desc;
            }
            set
            {
                this.n_sGift_desc = value;
            }
        }
        #endregion m_sGift_desc


        protected string n_sD_region = string.Empty;
        #region m_sD_region
        public string m_sD_region
        {
            get
            {
                return this.n_sD_region;
            }
            set
            {
                this.n_sD_region = value;
            }
        }
        #endregion m_sD_region


        protected string n_sD_address = string.Empty;
        #region m_sD_address
        public string m_sD_address
        {
            get
            {
                return this.n_sD_address;
            }
            set
            {
                this.n_sD_address = value;
            }
        }
        #endregion

        protected string n_sRebate_amount = string.Empty;
        #region m_sRebate_amount
        public string m_sRebate_amount
        {
            get
            {
                return this.n_sRebate_amount;
            }
            set
            {
                this.n_sRebate_amount = value;
            }
        }
        #endregion m_sRebate_amount

        protected string n_sTl_name = string.Empty;
        #region m_sTl_name
        public string m_sTl_name
        {
            get
            {
                return this.n_sTl_name;
            }
            set
            {
                this.n_sTl_name = value;
            }
        }
        #endregion m_sTl_name

        protected string n_sSalesmancode = string.Empty;
        #region m_sSalesmancode
        public string m_sSalesmancode
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


        protected string n_sFree_mon = string.Empty;
        #region m_sFree_mon
        public string m_sFree_mon
        {
            get
            {
                return this.n_sFree_mon;
            }
            set
            {
                this.n_sFree_mon = value;
            }
        }
        #endregion m_sFree_mon


        protected string n_sGift_imei4 = string.Empty;
        #region m_sGift_imei4
        public string m_sGift_imei4
        {
            get
            {
                return this.n_sGift_imei4;
            }
            set
            {
                this.n_sGift_imei4 = value;
            }
        }
        #endregion m_sGift_imei4


        protected string n_sRemarks2PY = string.Empty;
        #region m_sRemarks2PY
        public string m_sRemarks2PY
        {
            get
            {
                return this.n_sRemarks2PY;
            }
            set
            {
                this.n_sRemarks2PY = value;
            }
        }
        #endregion m_sRemarks2PY


        protected string n_sAction_eff_date = string.Empty;
        #region m_sAction_eff_date
        public string m_sAction_eff_date
        {
            get
            {
                return this.n_sAction_eff_date;
            }
            set
            {
                this.n_sAction_eff_date = value;
            }
        }
        #endregion m_sAction_eff_date


        protected string n_sAccessory_desc = string.Empty;
        #region m_sAccessory_desc
        public string m_sAccessory_desc
        {
            get
            {
                return this.n_sAccessory_desc;
            }
            set
            {
                this.n_sAccessory_desc = value;
            }
        }
        #endregion m_sAccessory_desc


        protected string n_sGift_code = string.Empty;
        #region m_sGift_code
        public string m_sGift_code
        {
            get
            {
                return this.n_sGift_code;
            }
            set
            {
                this.n_sGift_code = value;
            }
        }
        #endregion m_sGift_code


        protected string n_sVas_eff_date = string.Empty;
        #region m_sVas_eff_date
        public string m_sVas_eff_date
        {
            get
            {
                return this.n_sVas_eff_date;
            }
            set
            {
                this.n_sVas_eff_date = value;
            }
        }
        #endregion m_sVas_eff_date


        protected string n_sRefer_staff_no = string.Empty;
        #region m_sRefer_staff_no
        public string m_sRefer_staff_no
        {
            get
            {
                return this.n_sRefer_staff_no;
            }
            set
            {
                this.n_sRefer_staff_no = value;
            }
        }
        #endregion m_sRefer_staff_no


        protected string n_sChannel = string.Empty;
        #region m_sChannel
        public string m_sChannel
        {
            get
            {
                return this.n_sChannel;
            }
            set
            {
                this.n_sChannel = value;
            }
        }
        #endregion m_sChannel


        protected string n_sM_card_no4 = string.Empty;
        #region m_sM_card_no4
        public string m_sM_card_no4
        {
            get
            {
                return this.n_sM_card_no4;
            }
            set
            {
                this.n_sM_card_no4 = value;
            }
        }
        #endregion m_sM_card_no4

        protected string n_sBank_name = string.Empty;
        #region m_sBank_name
        public string m_sBank_name
        {
            get
            {
                return this.n_sBank_name;
            }
            set
            {
                this.n_sBank_name = value;
            }
        }
        #endregion

        protected string n_sLob = string.Empty;
        #region m_sLob
        public string m_sLob
        {
            get
            {
                return this.n_sLob;
            }
            set
            {
                this.n_sLob = value;
            }
        }
        #endregion m_sLob


        protected string n_sPermium = string.Empty;
        #region m_sPermium
        public string m_sPermium
        {
            get
            {
                return this.n_sPermium;
            }
            set
            {
                this.n_sPermium = value;
            }
        }
        #endregion m_sPermium


        protected string n_sRemarks2EDF = string.Empty;
        #region m_sRemarks2EDF
        public string m_sRemarks2EDF
        {
            get
            {
                return this.n_sRemarks2EDF;
            }
            set
            {
                this.n_sRemarks2EDF = value;
            }
        }
        #endregion m_sRemarks2EDF


        protected string n_sD_time = string.Empty;
        #region m_sD_time
        public string m_sD_time
        {
            get
            {
                return this.n_sD_time;
            }
            set
            {
                this.n_sD_time = value;
            }
        }
        #endregion m_sD_time


        protected string n_sCard_no1 = string.Empty;
        #region m_sCard_no1
        public string m_sCard_no1
        {
            get
            {
                return this.n_sCard_no1;
            }
            set
            {
                this.n_sCard_no1 = value;
            }
        }
        #endregion m_sCard_no1


        protected string n_sCancel_renew = string.Empty;
        #region m_sCancel_renew
        public string m_sCancel_renew
        {
            get
            {
                return this.n_sCancel_renew;
            }
            set
            {
                this.n_sCancel_renew = value;
            }
        }
        #endregion m_sCancel_renew


        protected string n_sD_room = string.Empty;
        #region m_sD_room
        public string m_sD_room
        {
            get
            {
                return this.n_sD_room;
            }
            set
            {
                this.n_sD_room = value;
            }
        }
        #endregion m_sD_room


        protected string n_sD_type = string.Empty;
        #region m_sD_type
        public string m_sD_type
        {
            get
            {
                return this.n_sD_type;
            }
            set
            {
                this.n_sD_type = value;
            }
        }
        #endregion m_sD_type


        protected string n_sHkid = string.Empty;
        #region m_sHkid
        public string m_sHkid
        {
            get
            {
                return this.n_sHkid;
            }
            set
            {
                this.n_sHkid = value;
            }
        }
        #endregion m_sHkid


        protected string n_sOrd_place_rel = string.Empty;
        #region m_sord_place_rel
        public string m_sord_place_rel
        {
            get
            {
                return this.n_sOrd_place_rel;
            }
            set
            {
                this.n_sOrd_place_rel = value;
            }
        }
        #endregion m_sord_place_rel


        protected string n_sM_card_no2 = string.Empty;
        #region m_sM_card_no2
        public string m_sM_card_no2
        {
            get
            {
                return this.n_sM_card_no2;
            }
            set
            {
                this.n_sM_card_no2 = value;
            }
        }
        #endregion m_sM_card_no2


        protected string n_sM_card_no3 = string.Empty;
        #region m_sM_card_no3
        public string m_sM_card_no3
        {
            get
            {
                return this.n_sM_card_no3;
            }
            set
            {
                this.n_sM_card_no3 = value;
            }
        }
        #endregion m_sM_card_no3


        protected string n_sM_card_no1 = string.Empty;
        #region m_sM_card_no1
        public string m_sM_card_no1
        {
            get
            {
                return this.n_sM_card_no1;
            }
            set
            {
                this.n_sM_card_no1 = value;
            }
        }
        #endregion m_sM_card_no1


        protected string n_sM_card_exp_month = string.Empty;
        #region m_sM_card_exp_month
        public string m_sM_card_exp_month
        {
            get
            {
                return this.n_sM_card_exp_month;
            }
            set
            {
                this.n_sM_card_exp_month = value;
            }
        }
        #endregion m_sM_card_exp_month


        protected string n_sD_street = string.Empty;
        #region m_sD_street
        public string m_sD_street
        {
            get
            {
                return this.n_sD_street;
            }
            set
            {
                this.n_sD_street = value;
            }
        }
        #endregion m_sD_street


        protected string n_sD_date = string.Empty;
        #region m_sD_date
        public string m_sD_date
        {
            get
            {
                return this.n_sD_date;
            }
            set
            {
                this.n_sD_date = value;
            }
        }
        #endregion m_sD_date


        protected string n_sCard_exp_month = string.Empty;
        #region m_sCard_exp_month
        public string m_sCard_exp_month
        {
            get
            {
                return this.n_sCard_exp_month;
            }
            set
            {
                this.n_sCard_exp_month = value;
            }
        }
        #endregion m_sCard_exp_month


        protected string n_sHkid2 = string.Empty;
        #region m_sHkid2
        public string m_sHkid2
        {
            get
            {
                return this.n_sHkid2;
            }
            set
            {
                this.n_sHkid2 = value;
            }
        }
        #endregion m_sHkid2


        protected string n_sTrade_field = string.Empty;
        #region m_sTrade_field
        public string m_sTrade_field
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


        protected string n_sCard_holder = string.Empty;
        #region m_sCard_holder
        public string m_sCard_holder
        {
            get
            {
                return this.n_sCard_holder;
            }
            set
            {
                this.n_sCard_holder = value;
            }
        }
        #endregion m_sCard_holder


        protected string n_sBank_code = string.Empty;
        #region m_sBank_code
        public string m_sBank_code
        {
            get
            {
                return this.n_sBank_code;
            }
            set
            {
                this.n_sBank_code = value;
            }
        }
        #endregion m_sBank_code


        protected string n_sStaff_no = string.Empty;
        #region m_sStaff_no
        public string m_sStaff_no
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


        protected string n_sOrd_place_by = string.Empty;
        #region m_sOrd_place_by
        public string m_sOrd_place_by
        {
            get
            {
                return this.n_sOrd_place_by;
            }
            set
            {
                this.n_sOrd_place_by = value;
            }
        }
        #endregion m_sOrd_place_by


        protected string n_sPlan_eff = string.Empty;
        #region m_sPlan_eff
        public string m_sPlan_eff
        {
            get
            {
                return this.n_sPlan_eff;
            }
            set
            {
                this.n_sPlan_eff = value;
            }
        }
        #endregion m_sPlan_eff


        protected string n_sRemarks = string.Empty;
        #region m_sRemarks
        public string m_sRemarks
        {
            get
            {
                return this.n_sRemarks;
            }
            set
            {
                this.n_sRemarks = value;
            }
        }
        #endregion m_sRemarks


        protected string n_sWaive = string.Empty;
        #region m_sWaive
        public string m_sWaive
        {
            get
            {
                return this.n_sWaive;
            }
            set
            {
                this.n_sWaive = value;
            }
        }
        #endregion m_sWaive


        protected string n_sPay_method = string.Empty;
        #region m_sPay_method
        public string m_sPay_method
        {
            get
            {
                return this.n_sPay_method;
            }
            set
            {
                this.n_sPay_method = value;
            }
        }
        #endregion m_sPay_method


        protected string n_sM_card_exp_year = string.Empty;
        #region m_sM_card_exp_year
        public string m_sM_card_exp_year
        {
            get
            {
                return this.n_sM_card_exp_year;
            }
            set
            {
                this.n_sM_card_exp_year = value;
            }
        }
        #endregion m_sM_card_exp_year


        protected string n_sExisting_contract_end_year = string.Empty;
        #region m_sExisting_contract_end_year
        public string m_sExisting_contract_end_year
        {
            get
            {
                return this.n_sExisting_contract_end_year;
            }
            set
            {
                this.n_sExisting_contract_end_year = value;
            }
        }
        #endregion m_sExisting_contract_end_year


        protected string n_sRef_salesmancode = string.Empty;
        #region m_sRef_salesmancode
        public string m_sRef_salesmancode
        {
            get
            {
                return this.n_sRef_salesmancode;
            }
            set
            {
                this.n_sRef_salesmancode = value;
            }
        }
        #endregion m_sRef_salesmancode


        protected string n_sStaff_name = string.Empty;
        #region m_sStaff_name
        public string m_sStaff_name
        {
            get
            {
                return this.n_sStaff_name;
            }
            set
            {
                this.n_sStaff_name = value;
            }
        }
        #endregion m_sStaff_name


        protected string n_sSku = string.Empty;
        #region m_sSku
        public string m_sSku
        {
            get
            {
                return this.n_sSku;
            }
            set
            {
                this.n_sSku = value;
            }
        }
        #endregion m_sSku


        protected string n_sReasons = string.Empty;
        #region m_sReasons
        public string m_sReasons
        {
            get
            {
                return this.n_sReasons;
            }
            set
            {
                this.n_sReasons = value;
            }
        }
        #endregion m_sReasons


        protected string n_sLob_ac = string.Empty;
        #region m_sLob_ac
        public string m_sLob_ac
        {
            get
            {
                return this.n_sLob_ac;
            }
            set
            {
                this.n_sLob_ac = value;
            }
        }
        #endregion m_sLob_ac


        protected string n_sCon_eff_date = string.Empty;
        #region m_sCon_eff_date
        public string m_sCon_eff_date
        {
            get
            {
                return this.n_sCon_eff_date;
            }
            set
            {
                this.n_sCon_eff_date = value;
            }
        }
        #endregion m_sCon_eff_date


        protected string n_sCard_no3 = string.Empty;
        #region m_sCard_no3
        public string m_sCard_no3
        {
            get
            {
                return this.n_sCard_no3;
            }
            set
            {
                this.n_sCard_no3 = value;
            }
        }
        #endregion m_sCard_no3


        protected string n_sCust_name = string.Empty;
        #region m_sCust_name
        public string m_sCust_name
        {
            get
            {
                return this.n_sCust_name;
            }
            set
            {
                this.n_sCust_name = value;
            }
        }
        #endregion m_sCust_name


        protected string n_sOrd_place_tel = string.Empty;
        #region m_sOrd_place_tel
        public string m_sOrd_place_tel
        {
            get
            {
                return this.n_sOrd_place_tel;
            }
            set
            {
                this.n_sOrd_place_tel = value;
            }
        }
        #endregion m_sOrd_place_tel


        protected string n_sMonthly_payment_type = string.Empty;
        #region m_sMonthly_payment_type
        public string m_sMonthly_payment_type
        {
            get
            {
                return this.n_sMonthly_payment_type;
            }
            set
            {
                this.n_sMonthly_payment_type = value;
            }
        }
        #endregion m_sMonthly_payment_type


        protected string n_sAc_no = string.Empty;
        #region m_sAc_no
        public string m_sAc_no
        {
            get
            {
                return this.n_sAc_no;
            }
            set
            {
                this.n_sAc_no = value;
            }
        }
        #endregion m_sAc_no


        protected string n_sBundle_name = string.Empty;
        #region m_sBundle_name
        public string m_sBundle_name
        {
            get
            {
                return this.n_sBundle_name;
            }
            set
            {
                this.n_sBundle_name = value;
            }
        }
        #endregion m_sBundle_name


        protected string n_sContact_no = string.Empty;
        #region m_sContact_no
        public string m_sContact_no
        {
            get
            {
                return this.n_sContact_no;
            }
            set
            {
                this.n_sContact_no = value;
            }
        }
        #endregion m_sContact_no


        protected string n_sGift_desc4 = string.Empty;
        #region m_sGift_desc4
        public string m_sGift_desc4
        {
            get
            {
                return this.n_sGift_desc4;
            }
            set
            {
                this.n_sGift_desc4 = value;
            }
        }
        #endregion m_sGift_desc4


        protected string n_sOrg_ftg = string.Empty;
        #region m_sOrg_ftg
        public string m_sOrg_ftg
        {
            get
            {
                return this.n_sOrg_ftg;
            }
            set
            {
                this.n_sOrg_ftg = value;
            }
        }
        #endregion m_sOrg_ftg


        protected string n_sOb_program_id = string.Empty;
        #region m_sOb_program_id
        public string m_sOb_program_id
        {
            get
            {
                return this.n_sOb_program_id;
            }
            set
            {
                this.n_sOb_program_id = value;
            }
        }
        #endregion m_sOb_program_id


        protected string n_sAmount = string.Empty;
        #region m_sAmount
        public string m_sAmount
        {
            get
            {
                return this.n_sAmount;
            }
            set
            {
                this.n_sAmount = value;
            }
        }
        #endregion m_sAmount


        protected string n_sExisting_contract_end_month = string.Empty;
        #region m_sExisting_contract_end_month
        public string m_sExisting_contract_end_month
        {
            get
            {
                return this.n_sExisting_contract_end_month;
            }
            set
            {
                this.n_sExisting_contract_end_month = value;
            }
        }
        #endregion m_sExisting_contract_end_month


        protected string n_sMrt_no = string.Empty;
        #region m_sMrt_no
        public string m_sMrt_no
        {
            get
            {
                return this.n_sMrt_no;
            }
            set
            {
                this.n_sMrt_no = value;
            }
        }
        #endregion m_sMrt_no


        protected string n_sSpecial_approval = string.Empty;
        #region m_sSpecial_approval
        public string m_sSpecial_approval
        {
            get
            {
                return this.n_sSpecial_approval;
            }
            set
            {
                this.n_sSpecial_approval = value;
            }
        }
        #endregion m_sSpecial_approval


        protected string n_sM_rebate_amount = string.Empty;
        #region m_sM_rebate_amount
        public string m_sM_rebate_amount
        {
            get
            {
                return this.n_sM_rebate_amount;
            }
            set
            {
                this.n_sM_rebate_amount = value;
            }
        }
        #endregion m_sM_rebate_amount


        protected string n_sAig_gift = string.Empty;
        #region m_sAig_gift
        public string m_sAig_gift
        {
            get
            {
                return this.n_sAig_gift;
            }
            set
            {
                this.n_sAig_gift = value;
            }
        }
        #endregion m_sAig_gift


        protected string n_sExtn = string.Empty;
        #region m_sExtn
        public string m_sExtn
        {
            get
            {
                return this.n_sExtn;
            }
            set
            {
                this.n_sExtn = value;
            }
        }
        #endregion m_sExtn


        protected string n_sCard_no4 = string.Empty;
        #region m_sCard_no4
        public string m_sCard_no4
        {
            get
            {
                return this.n_sCard_no4;
            }
            set
            {
                this.n_sCard_no4 = value;
            }
        }
        #endregion m_sCard_no4


        protected int n_iLv = -1;
        #region m_iLv
        public int m_iLv
        {
            get
            {
                return this.n_iLv;
            }
            set
            {
                this.n_iLv = value;
            }
        }
        #endregion m_iLv


        protected string n_sAccessory_imei = string.Empty;
        #region m_sAccessory_imei
        public string m_sAccessory_imei
        {
            get
            {
                return this.n_sAccessory_imei;
            }
            set
            {
                this.n_sAccessory_imei = value;
            }
        }
        #endregion m_sAccessory_imei


        protected string n_sRebate = string.Empty;
        #region m_sRebate
        public string m_sRebate
        {
            get
            {
                return this.n_sRebate;
            }
            set
            {
                this.n_sRebate = value;
            }
        }
        #endregion m_sRebate


        protected string n_sAccessory_code = string.Empty;
        #region m_sAccessory_code
        public string m_sAccessory_code
        {
            get
            {
                return this.n_sAccessory_code;
            }
            set
            {
                this.n_sAccessory_code = value;
            }
        }
        #endregion m_sAccessory_code


        protected string n_sM_card_type2 = string.Empty;
        #region m_sM_card_type2
        public string m_sM_card_type2
        {
            get
            {
                return this.n_sM_card_type2;
            }
            set
            {
                this.n_sM_card_type2 = value;
            }
        }
        #endregion m_sM_card_type2


        protected string n_sCon_per = string.Empty;
        #region m_sCon_per
        public string m_sCon_per
        {
            get
            {
                return this.n_sCon_per;
            }
            set
            {
                this.n_sCon_per = value;
            }
        }
        #endregion m_sCon_per


        protected string n_sM_card_holder2 = string.Empty;
        #region m_sM_card_holder2
        public string m_sM_card_holder2
        {
            get
            {
                return this.n_sM_card_holder2;
            }
            set
            {
                this.n_sM_card_holder2 = value;
            }
        }
        #endregion m_sM_card_holder2


        protected string n_sGift_code4 = string.Empty;
        #region m_sGift_code4
        public string m_sGift_code4
        {
            get
            {
                return this.n_sGift_code4;
            }
            set
            {
                this.n_sGift_code4 = value;
            }
        }
        #endregion m_sGift_code4


        protected string n_sGift_code3 = string.Empty;
        #region m_sGift_code3
        public string m_sGift_code3
        {
            get
            {
                return this.n_sGift_code3;
            }
            set
            {
                this.n_sGift_code3 = value;
            }
        }
        #endregion m_sGift_code3


        protected string n_sNormal_rebate_type = string.Empty;
        #region m_sNormal_rebate
        public string m_sNormal_rebate
        {
            get
            {
                return this.n_sNormal_rebate_type;
            }
            set
            {
                this.n_sNormal_rebate_type = value;
            }
        }
        #endregion m_sNormal_rebate


        protected string n_sExt_place_tel = string.Empty;
        #region m_sExt_place_tel
        public string m_sExt_place_tel
        {
            get
            {
                return this.n_sExt_place_tel;
            }
            set
            {
                this.n_sExt_place_tel = value;
            }
        }
        #endregion m_sExt_place_tel


        protected string n_sD_floor = string.Empty;
        #region m_sD_floor
        public string m_sD_floor
        {
            get
            {
                return this.n_sD_floor;
            }
            set
            {
                this.n_sD_floor = value;
            }
        }
        #endregion m_sD_floor


        protected string n_sAction_required2 = string.Empty;
        #region m_sAction_required2
        public string m_sAction_required2
        {
            get
            {
                return this.n_sAction_required2;
            }
            set
            {
                this.n_sAction_required2 = value;
            }
        }
        #endregion m_sAction_required2


        protected string n_sCard_no2 = string.Empty;
        #region m_sCard_no2
        public string m_sCard_no2
        {
            get
            {
                return this.n_sCard_no2;
            }
            set
            {
                this.n_sCard_no2 = value;
            }
        }
        #endregion m_sCard_no2


        protected string n_sSp_d_date = string.Empty;
        #region m_sSp_d_date
        public string m_sSp_d_date
        {
            get
            {
                return this.n_sSp_d_date;
            }
            set
            {
                this.n_sSp_d_date = value;
            }
        }
        #endregion m_sSp_d_date


        protected string n_sExtra_d_charge = string.Empty;
        #region m_sExtra_d_charge
        public string m_sExtra_d_charge
        {
            get
            {
                return this.n_sExtra_d_charge;
            }
            set
            {
                this.n_sExtra_d_charge = value;
            }
        }
        #endregion m_sExtra_d_charge


        protected string n_sTeamcode = string.Empty;
        #region m_sTeamcode
        public string m_sTeamcode
        {
            get
            {
                return this.n_sTeamcode;
            }
            set
            {
                this.n_sTeamcode = value;
            }
        }
        #endregion m_sTeamcode


        protected string n_sAction_required = string.Empty;
        #region m_sAction_required
        public string m_sAction_required
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


        protected string n_sProgram = string.Empty;
        #region m_sProgram
        public string m_sProgram
        {
            get
            {
                return this.n_sProgram;
            }
            set
            {
                this.n_sProgram = value;
            }
        }
        #endregion m_sProgram


        protected string n_sExist_plan = string.Empty;
        #region m_sExist_plan
        public string m_sExist_plan
        {
            get
            {
                return this.n_sExist_plan;
            }
            set
            {
                this.n_sExist_plan = value;
            }
        }
        #endregion m_sExist_plan


        protected string n_sAccessory_price = string.Empty;
        #region m_sAccessory_price
        public string m_sAccessory_price
        {
            get
            {
                return this.n_sAccessory_price;
            }
            set
            {
                this.n_sAccessory_price = value;
            }
        }
        #endregion m_sAccessory_price


        protected string n_sM_Card_type = string.Empty;
        #region m_sM_Card_type
        public string m_sM_Card_type
        {
            get
            {
                return this.n_sM_Card_type;
            }
            set
            {
                this.n_sM_Card_type = value;
            }
        }
        #endregion m_sM_Card_type


        protected string n_sEasywatch_type = string.Empty;
        #region m_sEasywatch_type
        public string m_sEasywatch_type
        {
            get
            {
                return this.n_sEasywatch_type;
            }
            set
            {
                this.n_sEasywatch_type = value;
            }
        }
        #endregion m_sEasywatch_type


        protected string n_sGift_imei = string.Empty;
        #region m_sGift_imei
        public string m_sGift_imei
        {
            get
            {
                return this.n_sGift_imei;
            }
            set
            {
                this.n_sGift_imei = value;
            }
        }
        #endregion m_sGift_imei


        protected string n_sVip_case = string.Empty;
        #region m_sVip_case
        public string m_sVip_case
        {
            get
            {
                return this.n_sVip_case;
            }
            set
            {
                this.n_sVip_case = value;
            }
        }
        #endregion m_sVip_case


        protected string n_sS_premium = string.Empty;
        #region m_sS_premium
        public string m_sS_premium
        {
            get
            {
                return this.n_sS_premium;
            }
            set
            {
                this.n_sS_premium = value;
            }
        }
        #endregion m_sS_premium


        protected string n_sOrd_place_hkid2 = string.Empty;
        #region m_sOrd_place_hkid2
        public string m_sOrd_place_hkid2
        {
            get
            {
                return this.n_sOrd_place_hkid2;
            }
            set
            {
                this.n_sOrd_place_hkid2 = value;
            }
        }
        #endregion m_sOrd_place_hkid2


        protected string n_sCust_type = string.Empty;
        #region m_sCust_type
        public string m_sCust_type
        {
            get
            {
                return this.n_sCust_type;
            }
            set
            {
                this.n_sCust_type = value;
            }
        }
        #endregion m_sCust_type


        protected string n_sContract_person = string.Empty;
        #region m_sContract_person
        public string m_sContract_person
        {
            get
            {
                return this.n_sContract_person;
            }
            set
            {
                this.n_sContract_person = value;
            }
        }
        #endregion m_sContract_person


        protected string n_sPlan_eff_date = string.Empty;
        #region m_sPlan_eff_date
        public string m_sPlan_eff_date
        {
            get
            {
                return this.n_sPlan_eff_date;
            }
            set
            {
                this.n_sPlan_eff_date = value;
            }
        }
        #endregion m_sPlan_eff_date


        protected string n_sCust_staff_no = string.Empty;
        #region m_sCust_staff_no
        public string m_sCust_staff_no
        {
            get
            {
                return this.n_sCust_staff_no;
            }
            set
            {
                this.n_sCust_staff_no = value;
            }
        }
        #endregion m_sCust_staff_no


        protected string n_sOrd_place_id_type = string.Empty;
        #region m_sOrd_place_id_type
        public string m_sOrd_place_id_type
        {
            get
            {
                return this.n_sOrd_place_id_type;
            }
            set
            {
                this.n_sOrd_place_id_type = value;
            }
        }
        #endregion m_sOrd_place_id_type


        protected string n_sExtra_rebate_amount = string.Empty;
        #region m_sExtra_rebate_amount
        public string m_sExtra_rebate_amount
        {
            get
            {
                return this.n_sExtra_rebate_amount;
            }
            set
            {
                this.n_sExtra_rebate_amount = value;
            }
        }
        #endregion m_sExtra_rebate_amount


        protected string n_sOrd_place_hkid = string.Empty;
        #region m_sOrd_place_hkid
        public string m_sOrd_place_hkid
        {
            get
            {
                return this.n_sOrd_place_hkid;
            }
            set
            {
                this.n_sOrd_place_hkid = value;
            }
        }
        #endregion m_sOrd_place_hkid


        protected string n_sSp_ref_no = string.Empty;
        #region m_sSp_ref_no
        public string m_sSp_ref_no
        {
            get
            {
                return this.n_sSp_ref_no;
            }
            set
            {
                this.n_sSp_ref_no = value;
            }
        }
        #endregion m_sSp_ref_no


        protected string n_sLog_date = string.Empty;
        #region m_sLog_date
        public string m_sLog_date
        {
            get
            {
                return this.n_sLog_date;
            }
            set
            {
                this.n_sLog_date = value;
            }
        }
        #endregion m_sLog_date


        protected string n_sHs_model = string.Empty;
        #region m_sHs_model
        public string m_sHs_model
        {
            get
            {
                return this.n_sHs_model;
            }
            set
            {
                this.n_sHs_model = value;
            }
        }
        #endregion m_sHs_model


        protected string n_sCard_exp_year = string.Empty;
        #region m_sCard_exp_year
        public string m_sCard_exp_year
        {
            get
            {
                return this.n_sCard_exp_year;
            }
            set
            {
                this.n_sCard_exp_year = value;
            }
        }
        #endregion m_sCard_exp_year


        protected string n_sRate_plan = string.Empty;
        #region m_sRate_plan
        public string m_sRate_plan
        {
            get
            {
                return this.n_sRate_plan;
            }
            set
            {
                this.n_sRate_plan = value;
            }
        }
        #endregion m_sRate_plan


        protected string n_sS_permium2 = string.Empty;
        #region m_sS_permium2
        public string m_sS_permium2
        {
            get
            {
                return this.n_sS_permium2;
            }
            set
            {
                this.n_sS_permium2 = value;
            }
        }
        #endregion m_sS_permium2


        protected string n_sD_blk = string.Empty;
        #region m_sD_blk
        public string m_sD_blk
        {
            get
            {
                return this.n_sD_blk;
            }
            set
            {
                this.n_sD_blk = value;
            }
        }
        #endregion m_sD_blk


        protected string n_sAccept = string.Empty;
        #region m_sAccept
        public string m_sAccept
        {
            get
            {
                return this.n_sAccept;
            }
            set
            {
                this.n_sAccept = value;
            }
        }
        #endregion m_sAccept


        protected string n_sExist_cust_plan = string.Empty;
        #region m_sExist_cust_plan
        public string m_sExist_cust_plan
        {
            get
            {
                return this.n_sExist_cust_plan;
            }
            set
            {
                this.n_sExist_cust_plan = value;
            }
        }
        #endregion m_sExist_cust_plan


        protected string n_sOrg_fee = string.Empty;
        #region m_sOrg_fee
        public string m_sOrg_fee
        {
            get
            {
                return this.n_sOrg_fee;
            }
            set
            {
                this.n_sOrg_fee = value;
            }
        }
        #endregion m_sOrg_fee


        protected string n_sFast_start = string.Empty;
        #region m_sFast_start
        public string m_sFast_start
        {
            get
            {
                return this.n_sFast_start;
            }
            set
            {
                this.n_sFast_start = value;
            }
        }
        #endregion m_sFast_start


        protected string n_sPos_ref_no = string.Empty;
        #region m_sPos_ref_no
        public string m_sPos_ref_no
        {
            get
            {
                return this.n_sPos_ref_no;
            }
            set
            {
                this.n_sPos_ref_no = value;
            }
        }
        #endregion m_sPos_ref_no


        protected string n_sGift_code2 = string.Empty;
        #region m_sGift_code2
        public string m_sGift_code2
        {
            get
            {
                return this.n_sGift_code2;
            }
            set
            {
                this.n_sGift_code2 = value;
            }
        }
        #endregion m_sGift_code2


        protected string n_sEasywatch_ord_id = string.Empty;
        #region m_sEasywatch_ord_id
        public string m_sEasywatch_ord_id
        {
            get
            {
                return this.n_sEasywatch_ord_id;
            }
            set
            {
                this.n_sEasywatch_ord_id = value;
            }
        }
        #endregion m_sEasywatch_ord_id


        protected string n_sId_type = string.Empty;
        #region m_sId_type
        public string m_sId_type
        {
            get
            {
                return this.n_sId_type;
            }
            set
            {
                this.n_sId_type = value;
            }
        }
        #endregion m_sId_type


        protected string n_sR_offer = string.Empty;
        #region m_sR_offer
        public string m_sR_offer
        {
            get
            {
                return this.n_sR_offer;
            }
            set
            {
                this.n_sR_offer = value;
            }
        }
        #endregion m_sR_offer


        protected string n_sM_card_type = string.Empty;
        #region m_sM_card_type
        public string m_sM_card_type
        {
            get
            {
                return this.n_sM_card_type;
            }
            set
            {
                this.n_sM_card_type = value;
            }
        }
        #endregion m_sM_card_type


        #region Constructor & Destructor
        public FromRegisterControler() { }

        public FromRegisterControler(string x_sD_address, string x_sBank_name, string x_sGift_desc, string x_sD_region, string x_sRebate_amount, string x_sTl_name, string x_sSalesmancode, string x_sFree_mon, string x_sGift_imei4, string x_sRemarks2PY, string x_sAction_eff_date, string x_sAccessory_desc, string x_sGift_code, string x_sVas_eff_date, string x_sRefer_staff_no, string x_sChannel, string x_sM_card_no4, string x_sLob, string x_sPermium, string x_sRemarks2EDF, string x_sD_time, string x_sCard_no1, string x_sCancel_renew, string x_sD_room, string x_sD_type, string x_sHkid, string x_sord_place_rel, string x_sM_card_no2, string x_sM_card_no3, string x_sM_card_no1, string x_sM_card_exp_month, string x_sD_street, string x_sD_date, string x_sCard_exp_month, string x_sHkid2, string x_sTrade_field, string x_sCard_holder, string x_sBank_code, string x_sD_build, string x_sStaff_no, string x_sOrd_place_by, string x_sPlan_eff, string x_sRemarks, string x_sWaive, string x_sPay_method, string x_sM_card_exp_year, string x_sExisting_contract_end_year, string x_sRef_salesmancode, string x_sStaff_name, string x_sSku, string x_sReasons, string x_sLob_ac, string x_sCon_eff_date, string x_sCard_no3, string x_sCust_name, string x_sOrd_place_tel, string x_sMonthly_payment_type, string x_sAc_no, string x_sBundle_name, string x_sContact_no, string x_sGift_desc4, string x_sOrg_ftg, string x_sOb_program_id, string x_sAmount, string x_sExisting_contract_end_month, string x_sMrt_no, string x_sSpecial_approval, string x_sM_rebate_amount, string x_sAig_gift, string x_sExtn, string x_sCard_no4, int x_iLv, string x_sAccessory_imei, string x_sRebate, string x_sAccessory_code, string x_sM_card_type2, string x_sCon_per, string x_sM_card_holder2, string x_sGift_code4, string x_sGift_code3, string x_sNormal_rebate_type, string x_sExt_place_tel, string x_sD_floor, string x_sAction_required2, string x_sCard_no2, string x_sSp_d_date, string x_sExtra_d_charge, string x_sTeamcode, string x_sAction_required, string x_sProgram, string x_sExist_plan, string x_sAccessory_price, string x_sM_Card_type, string x_sEasywatch_type, string x_sGift_imei, string x_sVip_case, string x_sS_premium, string x_sOrd_place_hkid2, string x_sCust_type, string x_sContract_person, string x_sPlan_eff_date, string x_sCust_staff_no, string x_sOrd_place_id_type, string x_sExtra_rebate_amount, string x_sOrd_place_hkid, string x_sSp_ref_no, string x_sLog_date, string x_sHs_model, string x_sCard_exp_year, string x_sRate_plan, string x_sS_permium2, string x_sD_blk, string x_sAccept, string x_sExist_cust_plan, string x_sOrg_fee, string x_sFast_start, string x_sPos_ref_no, string x_sGift_code2, string x_sEasywatch_ord_id, string x_sId_type, string x_sR_offer, string x_sM_card_type)
        {

            m_sD_address = x_sD_address;
            m_sBank_name = x_sBank_name;
            m_sGift_desc = x_sGift_desc;
            m_sD_region = x_sD_region;
            m_sRebate_amount = x_sRebate_amount;
            m_sTl_name = x_sTl_name;
            m_sSalesmancode = x_sSalesmancode;
            m_sFree_mon = x_sFree_mon;
            m_sGift_imei4 = x_sGift_imei4;
            m_sRemarks2PY = x_sRemarks2PY;
            m_sAction_eff_date = x_sAction_eff_date;
            m_sAccessory_desc = x_sAccessory_desc;
            m_sGift_code = x_sGift_code;
            m_sVas_eff_date = x_sVas_eff_date;
            m_sRefer_staff_no = x_sRefer_staff_no;
            m_sChannel = x_sChannel;
            m_sM_card_no4 = x_sM_card_no4;
            m_sLob = x_sLob;
            m_sPermium = x_sPermium;
            m_sRemarks2EDF = x_sRemarks2EDF;
            m_sD_time = x_sD_time;
            m_sCard_no1 = x_sCard_no1;
            m_sCancel_renew = x_sCancel_renew;
            m_sD_room = x_sD_room;
            m_sD_type = x_sD_type;
            m_sHkid = x_sHkid;
            m_sord_place_rel = x_sord_place_rel;
            m_sM_card_no2 = x_sM_card_no2;
            m_sM_card_no3 = x_sM_card_no3;
            m_sM_card_no1 = x_sM_card_no1;
            m_sM_card_exp_month = x_sM_card_exp_month;
            m_sD_street = x_sD_street;
            m_sD_date = x_sD_date;
            m_sCard_exp_month = x_sCard_exp_month;
            m_sHkid2 = x_sHkid2;
            m_sTrade_field = x_sTrade_field;
            m_sCard_holder = x_sCard_holder;
            m_sBank_code = x_sBank_code;
            m_sD_build = x_sD_build;
            m_sStaff_no = x_sStaff_no;
            m_sOrd_place_by = x_sOrd_place_by;
            m_sPlan_eff = x_sPlan_eff;
            m_sRemarks = x_sRemarks;
            m_sWaive = x_sWaive;
            m_sPay_method = x_sPay_method;
            m_sM_card_exp_year = x_sM_card_exp_year;
            m_sExisting_contract_end_year = x_sExisting_contract_end_year;
            m_sRef_salesmancode = x_sRef_salesmancode;
            m_sStaff_name = x_sStaff_name;
            m_sSku = x_sSku;
            m_sReasons = x_sReasons;
            m_sLob_ac = x_sLob_ac;
            m_sCon_eff_date = x_sCon_eff_date;
            m_sCard_no3 = x_sCard_no3;
            m_sCust_name = x_sCust_name;
            m_sOrd_place_tel = x_sOrd_place_tel;
            m_sMonthly_payment_type = x_sMonthly_payment_type;
            m_sAc_no = x_sAc_no;
            m_sBundle_name = x_sBundle_name;
            m_sContact_no = x_sContact_no;
            m_sGift_desc4 = x_sGift_desc4;
            m_sOrg_ftg = x_sOrg_ftg;
            m_sOb_program_id = x_sOb_program_id;
            m_sAmount = x_sAmount;
            m_sExisting_contract_end_month = x_sExisting_contract_end_month;
            m_sMrt_no = x_sMrt_no;
            m_sSpecial_approval = x_sSpecial_approval;
            m_sM_rebate_amount = x_sM_rebate_amount;
            m_sAig_gift = x_sAig_gift;
            m_sExtn = x_sExtn;
            m_sCard_no4 = x_sCard_no4;
            m_iLv = x_iLv;
            m_sAccessory_imei = x_sAccessory_imei;
            m_sRebate = x_sRebate;
            m_sAccessory_code = x_sAccessory_code;
            m_sM_card_type2 = x_sM_card_type2;
            m_sCon_per = x_sCon_per;
            m_sM_card_holder2 = x_sM_card_holder2;
            m_sGift_code4 = x_sGift_code4;
            m_sGift_code3 = x_sGift_code3;
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sExt_place_tel = x_sExt_place_tel;
            m_sD_floor = x_sD_floor;
            m_sAction_required2 = x_sAction_required2;
            m_sCard_no2 = x_sCard_no2;
            m_sSp_d_date = x_sSp_d_date;
            m_sExtra_d_charge = x_sExtra_d_charge;
            m_sTeamcode = x_sTeamcode;
            m_sAction_required = x_sAction_required;
            m_sProgram = x_sProgram;
            m_sExist_plan = x_sExist_plan;
            m_sAccessory_price = x_sAccessory_price;
            m_sM_Card_type = x_sM_Card_type;
            m_sEasywatch_type = x_sEasywatch_type;
            m_sGift_imei = x_sGift_imei;
            m_sVip_case = x_sVip_case;
            m_sS_premium = x_sS_premium;
            m_sOrd_place_hkid2 = x_sOrd_place_hkid2;
            m_sCust_type = x_sCust_type;
            m_sContract_person = x_sContract_person;
            m_sPlan_eff_date = x_sPlan_eff_date;
            m_sCust_staff_no = x_sCust_staff_no;
            m_sOrd_place_id_type = x_sOrd_place_id_type;
            m_sExtra_rebate_amount = x_sExtra_rebate_amount;
            m_sOrd_place_hkid = x_sOrd_place_hkid;
            m_sSp_ref_no = x_sSp_ref_no;
            m_sLog_date = x_sLog_date;
            m_sHs_model = x_sHs_model;
            m_sCard_exp_year = x_sCard_exp_year;
            m_sRate_plan = x_sRate_plan;
            m_sS_permium2 = x_sS_permium2;
            m_sD_blk = x_sD_blk;
            m_sAccept = x_sAccept;
            m_sExist_cust_plan = x_sExist_cust_plan;
            m_sOrg_fee = x_sOrg_fee;
            m_sFast_start = x_sFast_start;
            m_sPos_ref_no = x_sPos_ref_no;
            m_sGift_code2 = x_sGift_code2;
            m_sEasywatch_ord_id = x_sEasywatch_ord_id;
            m_sId_type = x_sId_type;
            m_sR_offer = x_sR_offer;
            m_sM_card_type = x_sM_card_type;
        }

        ~FromRegisterControler() { }

        #endregion Constructor & Destructor

        #region Get & Set

        public string GetD_address() { return this.m_sD_address; }
        public string GetBank_name() { return this.m_sBank_name; }
        public string GetGift_desc() { return this.m_sGift_desc; }
        public string GetD_region() { return this.m_sD_region; }
        public string GetRebate_amount() { return this.m_sRebate_amount; }
        public string GetTl_name() { return this.m_sTl_name; }
        public string GetSalesmancode() { return this.m_sSalesmancode; }
        public string GetFree_mon() { return this.m_sFree_mon; }
        public string GetGift_imei4() { return this.m_sGift_imei4; }
        public string GetRemarks2PY() { return this.m_sRemarks2PY; }
        public string GetAction_eff_date() { return this.m_sAction_eff_date; }
        public string GetAccessory_desc() { return this.m_sAccessory_desc; }
        public string GetGift_code() { return this.m_sGift_code; }
        public string GetVas_eff_date() { return this.m_sVas_eff_date; }
        public string GetRefer_staff_no() { return this.m_sRefer_staff_no; }
        public string GetChannel() { return this.m_sChannel; }
        public string GetM_card_no4() { return this.m_sM_card_no4; }
        public string GetLob() { return this.m_sLob; }
        public string GetPermium() { return this.m_sPermium; }
        public string GetRemarks2EDF() { return this.m_sRemarks2EDF; }
        public string GetD_time() { return this.m_sD_time; }
        public string GetCard_no1() { return this.m_sCard_no1; }
        public string GetCancel_renew() { return this.m_sCancel_renew; }
        public string GetD_room() { return this.m_sD_room; }
        public string GetD_type() { return this.m_sD_type; }
        public string GetHkid() { return this.m_sHkid; }
        public string GetOrd_place_rel() { return this.m_sord_place_rel; }
        public string GetM_card_no2() { return this.m_sM_card_no2; }
        public string GetM_card_no3() { return this.m_sM_card_no3; }
        public string GetM_card_no1() { return this.m_sM_card_no1; }
        public string GetM_card_exp_month() { return this.m_sM_card_exp_month; }
        public string GetD_street() { return this.m_sD_street; }
        public string GetD_date() { return this.m_sD_date; }
        public string GetCard_exp_month() { return this.m_sCard_exp_month; }
        public string GetHkid2() { return this.m_sHkid2; }
        public string GetTrade_field() { return this.m_sTrade_field; }
        public string GetCard_holder() { return this.m_sCard_holder; }
        public string GetBank_code() { return this.m_sBank_code; }
        public string GetD_build() { return this.m_sD_build; }
        public string GetStaff_no() { return this.m_sStaff_no; }
        public string GetOrd_place_by() { return this.m_sOrd_place_by; }
        public string GetPlan_eff() { return this.m_sPlan_eff; }
        public string GetRemarks() { return this.m_sRemarks; }
        public string GetWaive() { return this.m_sWaive; }
        public string GetPay_method() { return this.m_sPay_method; }
        public string GetM_card_exp_year() { return this.m_sM_card_exp_year; }
        public string GetExisting_contract_end_year() { return this.m_sExisting_contract_end_year; }
        public string GetRef_salesmancode() { return this.m_sRef_salesmancode; }
        public string GetStaff_name() { return this.m_sStaff_name; }
        public string GetSku() { return this.m_sSku; }
        public string GetReasons() { return this.m_sReasons; }
        public string GetLob_ac() { return this.m_sLob_ac; }
        public string GetCon_eff_date() { return this.m_sCon_eff_date; }
        public string GetCard_no3() { return this.m_sCard_no3; }
        public string GetCust_name() { return this.m_sCust_name; }
        public string GetOrd_place_tel() { return this.m_sOrd_place_tel; }
        public string GetMonthly_payment_type() { return this.m_sMonthly_payment_type; }
        public string GetAc_no() { return this.m_sAc_no; }
        public string GetBundle_name() { return this.m_sBundle_name; }
        public string GetContact_no() { return this.m_sContact_no; }
        public string GetGift_desc4() { return this.m_sGift_desc4; }
        public string GetOrg_ftg() { return this.m_sOrg_ftg; }
        public string GetOb_program_id() { return this.m_sOb_program_id; }
        public string GetAmount() { return this.m_sAmount; }
        public string GetExisting_contract_end_month() { return this.m_sExisting_contract_end_month; }
        public string GetMrt_no() { return this.m_sMrt_no; }
        public string GetSpecial_approval() { return this.m_sSpecial_approval; }
        public string GetM_rebate_amount() { return this.m_sM_rebate_amount; }
        public string GetAig_gift() { return this.m_sAig_gift; }
        public string GetExtn() { return this.m_sExtn; }
        public string GetCard_no4() { return this.m_sCard_no4; }
        public int GetLv() { return this.m_iLv; }
        public string GetAccessory_imei() { return this.m_sAccessory_imei; }
        public string GetRebate() { return this.m_sRebate; }
        public string GetAccessory_code() { return this.m_sAccessory_code; }
        public string GetM_card_type2() { return this.m_sM_card_type2; }
        public string GetCon_per() { return this.m_sCon_per; }
        public string GetM_card_holder2() { return this.m_sM_card_holder2; }
        public string GetGift_code4() { return this.m_sGift_code4; }
        public string GetGift_code3() { return this.m_sGift_code3; }
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetExt_place_tel() { return this.m_sExt_place_tel; }
        public string GetD_floor() { return this.m_sD_floor; }
        public string GetAction_required2() { return this.m_sAction_required2; }
        public string GetCard_no2() { return this.m_sCard_no2; }
        public string GetSp_d_date() { return this.m_sSp_d_date; }
        public string GetExtra_d_charge() { return this.m_sExtra_d_charge; }
        public string GetTeamcode() { return this.m_sTeamcode; }
        public string GetAction_required() { return this.m_sAction_required; }
        public string GetProgram() { return this.m_sProgram; }
        public string GetExist_plan() { return this.m_sExist_plan; }
        public string GetAccessory_price() { return this.m_sAccessory_price; }
        public string GetM_Card_type() { return this.m_sM_Card_type; }
        public string GetEasywatch_type() { return this.m_sEasywatch_type; }
        public string GetGift_imei() { return this.m_sGift_imei; }
        public string GetVip_case() { return this.m_sVip_case; }
        public string GetS_premium() { return this.m_sS_premium; }
        public string GetOrd_place_hkid2() { return this.m_sOrd_place_hkid2; }
        public string GetCust_type() { return this.m_sCust_type; }
        public string GetContract_person() { return this.m_sContract_person; }
        public string GetPlan_eff_date() { return this.m_sPlan_eff_date; }
        public string GetCust_staff_no() { return this.m_sCust_staff_no; }
        public string GetOrd_place_id_type() { return this.m_sOrd_place_id_type; }
        public string GetExtra_rebate_amount() { return this.m_sExtra_rebate_amount; }
        public string GetOrd_place_hkid() { return this.m_sOrd_place_hkid; }
        public string GetSp_ref_no() { return this.m_sSp_ref_no; }
        public string GetLog_date() { return this.m_sLog_date; }
        public string GetHs_model() { return this.m_sHs_model; }
        public string GetCard_exp_year() { return this.m_sCard_exp_year; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public string GetS_permium2() { return this.m_sS_permium2; }
        public string GetD_blk() { return this.m_sD_blk; }
        public string GetAccept() { return this.m_sAccept; }
        public string GetExist_cust_plan() { return this.m_sExist_cust_plan; }
        public string GetOrg_fee() { return this.m_sOrg_fee; }
        public string GetFast_start() { return this.m_sFast_start; }
        public string GetPos_ref_no() { return this.m_sPos_ref_no; }
        public string GetGift_code2() { return this.m_sGift_code2; }
        public string GetEasywatch_ord_id() { return this.m_sEasywatch_ord_id; }
        public string GetId_type() { return this.m_sId_type; }
        public string GetR_offer() { return this.m_sR_offer; }
        public string GetM_card_type() { return this.m_sM_card_type; }

        public bool SetD_build(string value)
        {
            this.m_sD_build = value;
            return true;
        }
        public bool SetD_address(string value)
        {
            this.m_sD_address = value;
            return true;
        }
        public bool SetBank_name(string value)
        {
            this.m_sBank_name = value;
            return true;
        }
        public bool SetGift_desc(string value)
        {
            this.m_sGift_desc = value;
            return true;
        }
        public bool SetD_region(string value)
        {
            this.m_sD_region = value;
            return true;
        }
        public bool SetRebate_amount(string value)
        {
            this.m_sRebate_amount = value;
            return true;
        }
        public bool SetTl_name(string value)
        {
            this.m_sTl_name = value;
            return true;
        }
        public bool SetSalesmancode(string value)
        {
            this.m_sSalesmancode = value;
            return true;
        }
        public bool SetFree_mon(string value)
        {
            this.m_sFree_mon = value;
            return true;
        }
        public bool SetGift_imei4(string value)
        {
            this.m_sGift_imei4 = value;
            return true;
        }
        public bool SetRemarks2PY(string value)
        {
            this.m_sRemarks2PY = value;
            return true;
        }
        public bool SetAction_eff_date(string value)
        {
            this.m_sAction_eff_date = value;
            return true;
        }
        public bool SetAccessory_desc(string value)
        {
            this.m_sAccessory_desc = value;
            return true;
        }
        public bool SetGift_code(string value)
        {
            this.m_sGift_code = value;
            return true;
        }
        public bool SetVas_eff_date(string value)
        {
            this.m_sVas_eff_date = value;
            return true;
        }
        public bool SetRefer_staff_no(string value)
        {
            this.m_sRefer_staff_no = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.m_sChannel = value;
            return true;
        }
        public bool SetM_card_no4(string value)
        {
            this.m_sM_card_no4 = value;
            return true;
        }
        public bool SetLob(string value)
        {
            this.m_sLob = value;
            return true;
        }
        public bool SetPermium(string value)
        {
            this.m_sPermium = value;
            return true;
        }
        public bool SetRemarks2EDF(string value)
        {
            this.m_sRemarks2EDF = value;
            return true;
        }
        public bool SetD_time(string value)
        {
            this.m_sD_time = value;
            return true;
        }
        public bool SetCard_no1(string value)
        {
            this.m_sCard_no1 = value;
            return true;
        }
        public bool SetCancel_renew(string value)
        {
            this.m_sCancel_renew = value;
            return true;
        }
        public bool SetD_room(string value)
        {
            this.m_sD_room = value;
            return true;
        }
        public bool SetD_type(string value)
        {
            this.m_sD_type = value;
            return true;
        }
        public bool SetHkid(string value)
        {
            this.m_sHkid = value;
            return true;
        }
        public bool SetOrd_place_rel(string value)
        {
            this.m_sord_place_rel = value;
            return true;
        }
        public bool SetM_card_no2(string value)
        {
            this.m_sM_card_no2 = value;
            return true;
        }
        public bool SetM_card_no3(string value)
        {
            this.m_sM_card_no3 = value;
            return true;
        }
        public bool SetM_card_no1(string value)
        {
            this.m_sM_card_no1 = value;
            return true;
        }
        public bool SetM_card_exp_month(string value)
        {
            this.m_sM_card_exp_month = value;
            return true;
        }
        public bool SetD_street(string value)
        {
            this.m_sD_street = value;
            return true;
        }
        public bool SetD_date(string value)
        {
            this.m_sD_date = value;
            return true;
        }
        public bool SetCard_exp_month(string value)
        {
            this.m_sCard_exp_month = value;
            return true;
        }
        public bool SetHkid2(string value)
        {
            this.m_sHkid2 = value;
            return true;
        }
        public bool SetTrade_field(string value)
        {
            this.m_sTrade_field = value;
            return true;
        }
        public bool SetCard_holder(string value)
        {
            this.m_sCard_holder = value;
            return true;
        }
        public bool SetBank_code(string value)
        {
            this.m_sBank_code = value;
            return true;
        }

        public bool SetStaff_no(string value)
        {
            this.m_sStaff_no = value;
            return true;
        }
        public bool SetOrd_place_by(string value)
        {
            this.m_sOrd_place_by = value;
            return true;
        }
        public bool SetPlan_eff(string value)
        {
            this.m_sPlan_eff = value;
            return true;
        }
        public bool SetRemarks(string value)
        {
            this.m_sRemarks = value;
            return true;
        }
        public bool SetWaive(string value)
        {
            this.m_sWaive = value;
            return true;
        }
        public bool SetPay_method(string value)
        {
            this.m_sPay_method = value;
            return true;
        }
        public bool SetM_card_exp_year(string value)
        {
            this.m_sM_card_exp_year = value;
            return true;
        }
        public bool SetExisting_contract_end_year(string value)
        {
            this.m_sExisting_contract_end_year = value;
            return true;
        }
        public bool SetRef_salesmancode(string value)
        {
            this.m_sRef_salesmancode = value;
            return true;
        }
        public bool SetStaff_name(string value)
        {
            this.m_sStaff_name = value;
            return true;
        }
        public bool SetSku(string value)
        {
            this.m_sSku = value;
            return true;
        }
        public bool SetReasons(string value)
        {
            this.m_sReasons = value;
            return true;
        }
        public bool SetLob_ac(string value)
        {
            this.m_sLob_ac = value;
            return true;
        }
        public bool SetCon_eff_date(string value)
        {
            this.m_sCon_eff_date = value;
            return true;
        }
        public bool SetCard_no3(string value)
        {
            this.m_sCard_no3 = value;
            return true;
        }
        public bool SetCust_name(string value)
        {
            this.m_sCust_name = value;
            return true;
        }
        public bool SetOrd_place_tel(string value)
        {
            this.m_sOrd_place_tel = value;
            return true;
        }
        public bool SetMonthly_payment_type(string value)
        {
            this.m_sMonthly_payment_type = value;
            return true;
        }
        public bool SetAc_no(string value)
        {
            this.m_sAc_no = value;
            return true;
        }
        public bool SetBundle_name(string value)
        {
            this.m_sBundle_name = value;
            return true;
        }
        public bool SetContact_no(string value)
        {
            this.m_sContact_no = value;
            return true;
        }
        public bool SetGift_desc4(string value)
        {
            this.m_sGift_desc4 = value;
            return true;
        }
        public bool SetOrg_ftg(string value)
        {
            this.m_sOrg_ftg = value;
            return true;
        }
        public bool SetOb_program_id(string value)
        {
            this.m_sOb_program_id = value;
            return true;
        }
        public bool SetAmount(string value)
        {
            this.m_sAmount = value;
            return true;
        }
        public bool SetExisting_contract_end_month(string value)
        {
            this.m_sExisting_contract_end_month = value;
            return true;
        }
        public bool SetMrt_no(string value)
        {
            this.m_sMrt_no = value;
            return true;
        }
        public bool SetSpecial_approval(string value)
        {
            this.m_sSpecial_approval = value;
            return true;
        }
        public bool SetM_rebate_amount(string value)
        {
            this.m_sM_rebate_amount = value;
            return true;
        }
        public bool SetAig_gift(string value)
        {
            this.m_sAig_gift = value;
            return true;
        }
        public bool SetExtn(string value)
        {
            this.m_sExtn = value;
            return true;
        }
        public bool SetCard_no4(string value)
        {
            this.m_sCard_no4 = value;
            return true;
        }
        public bool SetLv(int value)
        {
            this.m_iLv = value;
            return true;
        }
        public bool SetAccessory_imei(string value)
        {
            this.m_sAccessory_imei = value;
            return true;
        }
        public bool SetRebate(string value)
        {
            this.m_sRebate = value;
            return true;
        }
        public bool SetAccessory_code(string value)
        {
            this.m_sAccessory_code = value;
            return true;
        }
        public bool SetM_card_type2(string value)
        {
            this.m_sM_card_type2 = value;
            return true;
        }
        public bool SetCon_per(string value)
        {
            this.m_sCon_per = value;
            return true;
        }
        public bool SetM_card_holder2(string value)
        {
            this.m_sM_card_holder2 = value;
            return true;
        }
        public bool SetGift_code4(string value)
        {
            this.m_sGift_code4 = value;
            return true;
        }
        public bool SetGift_code3(string value)
        {
            this.m_sGift_code3 = value;
            return true;
        }
        public bool SetNormal_rebate(string value)
        {
            this.m_sNormal_rebate = value;
            return true;
        }
        public bool SetExt_place_tel(string value)
        {
            this.m_sExt_place_tel = value;
            return true;
        }
        public bool SetD_floor(string value)
        {
            this.m_sD_floor = value;
            return true;
        }
        public bool SetAction_required2(string value)
        {
            this.m_sAction_required2 = value;
            return true;
        }
        public bool SetCard_no2(string value)
        {
            this.m_sCard_no2 = value;
            return true;
        }
        public bool SetSp_d_date(string value)
        {
            this.m_sSp_d_date = value;
            return true;
        }
        public bool SetExtra_d_charge(string value)
        {
            this.m_sExtra_d_charge = value;
            return true;
        }
        public bool SetTeamcode(string value)
        {
            this.m_sTeamcode = value;
            return true;
        }
        public bool SetAction_required(string value)
        {
            this.m_sAction_required = value;
            return true;
        }
        public bool SetProgram(string value)
        {
            this.m_sProgram = value;
            return true;
        }
        public bool SetExist_plan(string value)
        {
            this.m_sExist_plan = value;
            return true;
        }
        public bool SetAccessory_price(string value)
        {
            this.m_sAccessory_price = value;
            return true;
        }
        public bool SetM_Card_type(string value)
        {
            this.m_sM_Card_type = value;
            return true;
        }
        public bool SetEasywatch_type(string value)
        {
            this.m_sEasywatch_type = value;
            return true;
        }
        public bool SetGift_imei(string value)
        {
            this.m_sGift_imei = value;
            return true;
        }
        public bool SetVip_case(string value)
        {
            this.m_sVip_case = value;
            return true;
        }
        public bool SetS_premium(string value)
        {
            this.m_sS_premium = value;
            return true;
        }
        public bool SetOrd_place_hkid2(string value)
        {
            this.m_sOrd_place_hkid2 = value;
            return true;
        }
        public bool SetCust_type(string value)
        {
            this.m_sCust_type = value;
            return true;
        }
        public bool SetContract_person(string value)
        {
            this.m_sContract_person = value;
            return true;
        }
        public bool SetPlan_eff_date(string value)
        {
            this.m_sPlan_eff_date = value;
            return true;
        }
        public bool SetCust_staff_no(string value)
        {
            this.m_sCust_staff_no = value;
            return true;
        }
        public bool SetOrd_place_id_type(string value)
        {
            this.m_sOrd_place_id_type = value;
            return true;
        }
        public bool SetExtra_rebate_amount(string value)
        {
            this.m_sExtra_rebate_amount = value;
            return true;
        }
        public bool SetOrd_place_hkid(string value)
        {
            this.m_sOrd_place_hkid = value;
            return true;
        }
        public bool SetSp_ref_no(string value)
        {
            this.m_sSp_ref_no = value;
            return true;
        }
        public bool SetLog_date(string value)
        {
            this.m_sLog_date = value;
            return true;
        }
        public bool SetHs_model(string value)
        {
            this.m_sHs_model = value;
            return true;
        }
        public bool SetCard_exp_year(string value)
        {
            this.m_sCard_exp_year = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetS_permium2(string value)
        {
            this.m_sS_permium2 = value;
            return true;
        }
        public bool SetD_blk(string value)
        {
            this.m_sD_blk = value;
            return true;
        }
        public bool SetAccept(string value)
        {
            this.m_sAccept = value;
            return true;
        }
        public bool SetExist_cust_plan(string value)
        {
            this.m_sExist_cust_plan = value;
            return true;
        }
        public bool SetOrg_fee(string value)
        {
            this.m_sOrg_fee = value;
            return true;
        }
        public bool SetFast_start(string value)
        {
            this.m_sFast_start = value;
            return true;
        }
        public bool SetPos_ref_no(string value)
        {
            this.m_sPos_ref_no = value;
            return true;
        }
        public bool SetGift_code2(string value)
        {
            this.m_sGift_code2 = value;
            return true;
        }
        public bool SetEasywatch_ord_id(string value)
        {
            this.m_sEasywatch_ord_id = value;
            return true;
        }
        public bool SetId_type(string value)
        {
            this.m_sId_type = value;
            return true;
        }
        public bool SetR_offer(string value)
        {
            this.m_sR_offer = value;
            return true;
        }
        public bool SetM_card_type(string value)
        {
            this.m_sM_card_type = value;
            return true;
        }
        #endregion



        #region Get

        #endregion



        #region Equals
        public bool Equals(FromRegisterControler x_oObj)
        {
            if (x_oObj == null) { return false; }

            if (!this.m_sD_address.Equals(x_oObj.m_sD_address)) { return false; }
            if (!this.m_sBank_name.Equals(x_oObj.m_sBank_name)) { return false; }
            if (!this.m_sGift_desc.Equals(x_oObj.m_sGift_desc)) { return false; }
            if (!this.m_sD_region.Equals(x_oObj.m_sD_region)) { return false; }
            if (!this.m_sRebate_amount.Equals(x_oObj.m_sRebate_amount)) { return false; }
            if (!this.m_sTl_name.Equals(x_oObj.m_sTl_name)) { return false; }
            if (!this.m_sSalesmancode.Equals(x_oObj.m_sSalesmancode)) { return false; }
            if (!this.m_sFree_mon.Equals(x_oObj.m_sFree_mon)) { return false; }
            if (!this.m_sGift_imei4.Equals(x_oObj.m_sGift_imei4)) { return false; }
            if (!this.m_sRemarks2PY.Equals(x_oObj.m_sRemarks2PY)) { return false; }
            if (!this.m_sAction_eff_date.Equals(x_oObj.m_sAction_eff_date)) { return false; }
            if (!this.m_sAccessory_desc.Equals(x_oObj.m_sAccessory_desc)) { return false; }
            if (!this.m_sGift_code.Equals(x_oObj.m_sGift_code)) { return false; }
            if (!this.m_sVas_eff_date.Equals(x_oObj.m_sVas_eff_date)) { return false; }
            if (!this.m_sRefer_staff_no.Equals(x_oObj.m_sRefer_staff_no)) { return false; }
            if (!this.m_sChannel.Equals(x_oObj.m_sChannel)) { return false; }
            if (!this.m_sM_card_no4.Equals(x_oObj.m_sM_card_no4)) { return false; }
            if (!this.m_sLob.Equals(x_oObj.m_sLob)) { return false; }
            if (!this.m_sPermium.Equals(x_oObj.m_sPermium)) { return false; }
            if (!this.m_sRemarks2EDF.Equals(x_oObj.m_sRemarks2EDF)) { return false; }
            if (!this.m_sD_time.Equals(x_oObj.m_sD_time)) { return false; }
            if (!this.m_sCard_no1.Equals(x_oObj.m_sCard_no1)) { return false; }
            if (!this.m_sCancel_renew.Equals(x_oObj.m_sCancel_renew)) { return false; }
            if (!this.m_sD_room.Equals(x_oObj.m_sD_room)) { return false; }
            if (!this.m_sD_type.Equals(x_oObj.m_sD_type)) { return false; }
            if (!this.m_sHkid.Equals(x_oObj.m_sHkid)) { return false; }
            if (!this.m_sord_place_rel.Equals(x_oObj.m_sord_place_rel)) { return false; }
            if (!this.m_sM_card_no2.Equals(x_oObj.m_sM_card_no2)) { return false; }
            if (!this.m_sM_card_no3.Equals(x_oObj.m_sM_card_no3)) { return false; }
            if (!this.m_sM_card_no1.Equals(x_oObj.m_sM_card_no1)) { return false; }
            if (!this.m_sM_card_exp_month.Equals(x_oObj.m_sM_card_exp_month)) { return false; }
            if (!this.m_sD_street.Equals(x_oObj.m_sD_street)) { return false; }
            if (!this.m_sD_date.Equals(x_oObj.m_sD_date)) { return false; }
            if (!this.m_sCard_exp_month.Equals(x_oObj.m_sCard_exp_month)) { return false; }
            if (!this.m_sHkid2.Equals(x_oObj.m_sHkid2)) { return false; }
            if (!this.m_sTrade_field.Equals(x_oObj.m_sTrade_field)) { return false; }
            if (!this.m_sCard_holder.Equals(x_oObj.m_sCard_holder)) { return false; }
            if (!this.m_sBank_code.Equals(x_oObj.m_sBank_code)) { return false; }
            if (!this.m_sD_build.Equals(x_oObj.m_sD_build)) { return false; }
            if (!this.m_sStaff_no.Equals(x_oObj.m_sStaff_no)) { return false; }
            if (!this.m_sOrd_place_by.Equals(x_oObj.m_sOrd_place_by)) { return false; }
            if (!this.m_sPlan_eff.Equals(x_oObj.m_sPlan_eff)) { return false; }
            if (!this.m_sRemarks.Equals(x_oObj.m_sRemarks)) { return false; }
            if (!this.m_sWaive.Equals(x_oObj.m_sWaive)) { return false; }
            if (!this.m_sPay_method.Equals(x_oObj.m_sPay_method)) { return false; }
            if (!this.m_sM_card_exp_year.Equals(x_oObj.m_sM_card_exp_year)) { return false; }
            if (!this.m_sExisting_contract_end_year.Equals(x_oObj.m_sExisting_contract_end_year)) { return false; }
            if (!this.m_sRef_salesmancode.Equals(x_oObj.m_sRef_salesmancode)) { return false; }
            if (!this.m_sStaff_name.Equals(x_oObj.m_sStaff_name)) { return false; }
            if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
            if (!this.m_sReasons.Equals(x_oObj.m_sReasons)) { return false; }
            if (!this.m_sLob_ac.Equals(x_oObj.m_sLob_ac)) { return false; }
            if (!this.m_sCon_eff_date.Equals(x_oObj.m_sCon_eff_date)) { return false; }
            if (!this.m_sCard_no3.Equals(x_oObj.m_sCard_no3)) { return false; }
            if (!this.m_sCust_name.Equals(x_oObj.m_sCust_name)) { return false; }
            if (!this.m_sOrd_place_tel.Equals(x_oObj.m_sOrd_place_tel)) { return false; }
            if (!this.m_sMonthly_payment_type.Equals(x_oObj.m_sMonthly_payment_type)) { return false; }
            if (!this.m_sAc_no.Equals(x_oObj.m_sAc_no)) { return false; }
            if (!this.m_sBundle_name.Equals(x_oObj.m_sBundle_name)) { return false; }
            if (!this.m_sContact_no.Equals(x_oObj.m_sContact_no)) { return false; }
            if (!this.m_sGift_desc4.Equals(x_oObj.m_sGift_desc4)) { return false; }
            if (!this.m_sOrg_ftg.Equals(x_oObj.m_sOrg_ftg)) { return false; }
            if (!this.m_sOb_program_id.Equals(x_oObj.m_sOb_program_id)) { return false; }
            if (!this.m_sAmount.Equals(x_oObj.m_sAmount)) { return false; }
            if (!this.m_sExisting_contract_end_month.Equals(x_oObj.m_sExisting_contract_end_month)) { return false; }
            if (!this.m_sMrt_no.Equals(x_oObj.m_sMrt_no)) { return false; }
            if (!this.m_sSpecial_approval.Equals(x_oObj.m_sSpecial_approval)) { return false; }
            if (!this.m_sM_rebate_amount.Equals(x_oObj.m_sM_rebate_amount)) { return false; }
            if (!this.m_sAig_gift.Equals(x_oObj.m_sAig_gift)) { return false; }
            if (!this.m_sExtn.Equals(x_oObj.m_sExtn)) { return false; }
            if (!this.m_sCard_no4.Equals(x_oObj.m_sCard_no4)) { return false; }
            if (!this.m_iLv.Equals(x_oObj.m_iLv)) { return false; }
            if (!this.m_sAccessory_imei.Equals(x_oObj.m_sAccessory_imei)) { return false; }
            if (!this.m_sRebate.Equals(x_oObj.m_sRebate)) { return false; }
            if (!this.m_sAccessory_code.Equals(x_oObj.m_sAccessory_code)) { return false; }
            if (!this.m_sM_card_type2.Equals(x_oObj.m_sM_card_type2)) { return false; }
            if (!this.m_sCon_per.Equals(x_oObj.m_sCon_per)) { return false; }
            if (!this.m_sM_card_holder2.Equals(x_oObj.m_sM_card_holder2)) { return false; }
            if (!this.m_sGift_code4.Equals(x_oObj.m_sGift_code4)) { return false; }
            if (!this.m_sGift_code3.Equals(x_oObj.m_sGift_code3)) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sExt_place_tel.Equals(x_oObj.m_sExt_place_tel)) { return false; }
            if (!this.m_sD_floor.Equals(x_oObj.m_sD_floor)) { return false; }
            if (!this.m_sAction_required2.Equals(x_oObj.m_sAction_required2)) { return false; }
            if (!this.m_sCard_no2.Equals(x_oObj.m_sCard_no2)) { return false; }
            if (!this.m_sSp_d_date.Equals(x_oObj.m_sSp_d_date)) { return false; }
            if (!this.m_sExtra_d_charge.Equals(x_oObj.m_sExtra_d_charge)) { return false; }
            if (!this.m_sTeamcode.Equals(x_oObj.m_sTeamcode)) { return false; }
            if (!this.m_sAction_required.Equals(x_oObj.m_sAction_required)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            if (!this.m_sExist_plan.Equals(x_oObj.m_sExist_plan)) { return false; }
            if (!this.m_sAccessory_price.Equals(x_oObj.m_sAccessory_price)) { return false; }
            if (!this.m_sM_Card_type.Equals(x_oObj.m_sM_Card_type)) { return false; }
            if (!this.m_sEasywatch_type.Equals(x_oObj.m_sEasywatch_type)) { return false; }
            if (!this.m_sGift_imei.Equals(x_oObj.m_sGift_imei)) { return false; }
            if (!this.m_sVip_case.Equals(x_oObj.m_sVip_case)) { return false; }
            if (!this.m_sS_premium.Equals(x_oObj.m_sS_premium)) { return false; }
            if (!this.m_sOrd_place_hkid2.Equals(x_oObj.m_sOrd_place_hkid2)) { return false; }
            if (!this.m_sCust_type.Equals(x_oObj.m_sCust_type)) { return false; }
            if (!this.m_sContract_person.Equals(x_oObj.m_sContract_person)) { return false; }
            if (!this.m_sPlan_eff_date.Equals(x_oObj.m_sPlan_eff_date)) { return false; }
            if (!this.m_sCust_staff_no.Equals(x_oObj.m_sCust_staff_no)) { return false; }
            if (!this.m_sOrd_place_id_type.Equals(x_oObj.m_sOrd_place_id_type)) { return false; }
            if (!this.m_sExtra_rebate_amount.Equals(x_oObj.m_sExtra_rebate_amount)) { return false; }
            if (!this.m_sOrd_place_hkid.Equals(x_oObj.m_sOrd_place_hkid)) { return false; }
            if (!this.m_sSp_ref_no.Equals(x_oObj.m_sSp_ref_no)) { return false; }
            if (!this.m_sLog_date.Equals(x_oObj.m_sLog_date)) { return false; }
            if (!this.m_sHs_model.Equals(x_oObj.m_sHs_model)) { return false; }
            if (!this.m_sCard_exp_year.Equals(x_oObj.m_sCard_exp_year)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_sS_permium2.Equals(x_oObj.m_sS_permium2)) { return false; }
            if (!this.m_sD_blk.Equals(x_oObj.m_sD_blk)) { return false; }
            if (!this.m_sAccept.Equals(x_oObj.m_sAccept)) { return false; }
            if (!this.m_sExist_cust_plan.Equals(x_oObj.m_sExist_cust_plan)) { return false; }
            if (!this.m_sOrg_fee.Equals(x_oObj.m_sOrg_fee)) { return false; }
            if (!this.m_sFast_start.Equals(x_oObj.m_sFast_start)) { return false; }
            if (!this.m_sPos_ref_no.Equals(x_oObj.m_sPos_ref_no)) { return false; }
            if (!this.m_sGift_code2.Equals(x_oObj.m_sGift_code2)) { return false; }
            if (!this.m_sEasywatch_ord_id.Equals(x_oObj.m_sEasywatch_ord_id)) { return false; }
            if (!this.m_sId_type.Equals(x_oObj.m_sId_type)) { return false; }
            if (!this.m_sR_offer.Equals(x_oObj.m_sR_offer)) { return false; }
            if (!this.m_sM_card_type.Equals(x_oObj.m_sM_card_type)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {

            this.m_sD_address = string.Empty;
            this.m_sBank_name = string.Empty;
            this.m_sGift_desc = string.Empty;
            this.m_sD_region = string.Empty;
            this.m_sRebate_amount = string.Empty;
            this.m_sTl_name = string.Empty;
            this.m_sSalesmancode = string.Empty;
            this.m_sFree_mon = string.Empty;
            this.m_sGift_imei4 = string.Empty;
            this.m_sRemarks2PY = string.Empty;
            this.m_sAction_eff_date = string.Empty;
            this.m_sAccessory_desc = string.Empty;
            this.m_sGift_code = string.Empty;
            this.m_sVas_eff_date = string.Empty;
            this.m_sRefer_staff_no = string.Empty;
            this.m_sChannel = string.Empty;
            this.m_sM_card_no4 = string.Empty;
            this.m_sLob = string.Empty;
            this.m_sPermium = string.Empty;
            this.m_sRemarks2EDF = string.Empty;
            this.m_sD_time = string.Empty;
            this.m_sCard_no1 = string.Empty;
            this.m_sCancel_renew = string.Empty;
            this.m_sD_room = string.Empty;
            this.m_sD_type = string.Empty;
            this.m_sHkid = string.Empty;
            this.m_sord_place_rel = string.Empty;
            this.m_sM_card_no2 = string.Empty;
            this.m_sM_card_no3 = string.Empty;
            this.m_sM_card_no1 = string.Empty;
            this.m_sM_card_exp_month = string.Empty;
            this.m_sD_street = string.Empty;
            this.m_sD_date = string.Empty;
            this.m_sCard_exp_month = string.Empty;
            this.m_sHkid2 = string.Empty;
            this.m_sTrade_field = string.Empty;
            this.m_sCard_holder = string.Empty;
            this.m_sBank_code = string.Empty;
            this.m_sD_build = string.Empty;
            this.m_sStaff_no = string.Empty;
            this.m_sOrd_place_by = string.Empty;
            this.m_sPlan_eff = string.Empty;
            this.m_sRemarks = string.Empty;
            this.m_sWaive = string.Empty;
            this.m_sPay_method = string.Empty;
            this.m_sM_card_exp_year = string.Empty;
            this.m_sExisting_contract_end_year = string.Empty;
            this.m_sRef_salesmancode = string.Empty;
            this.m_sStaff_name = string.Empty;
            this.m_sSku = string.Empty;
            this.m_sReasons = string.Empty;
            this.m_sLob_ac = string.Empty;
            this.m_sCon_eff_date = string.Empty;
            this.m_sCard_no3 = string.Empty;
            this.m_sCust_name = string.Empty;
            this.m_sOrd_place_tel = string.Empty;
            this.m_sMonthly_payment_type = string.Empty;
            this.m_sAc_no = string.Empty;
            this.m_sBundle_name = string.Empty;
            this.m_sContact_no = string.Empty;
            this.m_sGift_desc4 = string.Empty;
            this.m_sOrg_ftg = string.Empty;
            this.m_sOb_program_id = string.Empty;
            this.m_sAmount = string.Empty;
            this.m_sExisting_contract_end_month = string.Empty;
            this.m_sMrt_no = string.Empty;
            this.m_sSpecial_approval = string.Empty;
            this.m_sM_rebate_amount = string.Empty;
            this.m_sAig_gift = string.Empty;
            this.m_sExtn = string.Empty;
            this.m_sCard_no4 = string.Empty;
            this.m_iLv = -1;
            this.m_sAccessory_imei = string.Empty;
            this.m_sRebate = string.Empty;
            this.m_sAccessory_code = string.Empty;
            this.m_sM_card_type2 = string.Empty;
            this.m_sCon_per = string.Empty;
            this.m_sM_card_holder2 = string.Empty;
            this.m_sGift_code4 = string.Empty;
            this.m_sGift_code3 = string.Empty;
            this.m_sNormal_rebate = string.Empty;
            this.m_sExt_place_tel = string.Empty;
            this.m_sD_floor = string.Empty;
            this.m_sAction_required2 = string.Empty;
            this.m_sCard_no2 = string.Empty;
            this.m_sSp_d_date = string.Empty;
            this.m_sExtra_d_charge = string.Empty;
            this.m_sTeamcode = string.Empty;
            this.m_sAction_required = string.Empty;
            this.m_sProgram = string.Empty;
            this.m_sExist_plan = string.Empty;
            this.m_sAccessory_price = string.Empty;
            this.m_sM_Card_type = string.Empty;
            this.m_sEasywatch_type = string.Empty;
            this.m_sGift_imei = string.Empty;
            this.m_sVip_case = string.Empty;
            this.m_sS_premium = string.Empty;
            this.m_sOrd_place_hkid2 = string.Empty;
            this.m_sCust_type = string.Empty;
            this.m_sContract_person = string.Empty;
            this.m_sPlan_eff_date = string.Empty;
            this.m_sCust_staff_no = string.Empty;
            this.m_sOrd_place_id_type = string.Empty;
            this.m_sExtra_rebate_amount = string.Empty;
            this.m_sOrd_place_hkid = string.Empty;
            this.m_sSp_ref_no = string.Empty;
            this.m_sLog_date = string.Empty;
            this.m_sHs_model = string.Empty;
            this.m_sCard_exp_year = string.Empty;
            this.m_sRate_plan = string.Empty;
            this.m_sS_permium2 = string.Empty;
            this.m_sD_blk = string.Empty;
            this.m_sAccept = string.Empty;
            this.m_sExist_cust_plan = string.Empty;
            this.m_sOrg_fee = string.Empty;
            this.m_sFast_start = string.Empty;
            this.m_sPos_ref_no = string.Empty;
            this.m_sGift_code2 = string.Empty;
            this.m_sEasywatch_ord_id = string.Empty;
            this.m_sId_type = string.Empty;
            this.m_sR_offer = string.Empty;
            this.m_sM_card_type = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public FromRegisterControler DeepClone()
        {
            FromRegisterControler FromRegisterControler_Clone = new FromRegisterControler();

            FromRegisterControler_Clone.SetD_address(this.m_sD_address);
            FromRegisterControler_Clone.SetBank_name(this.m_sBank_name);
            FromRegisterControler_Clone.SetGift_desc(this.m_sGift_desc);
            FromRegisterControler_Clone.SetD_region(this.m_sD_region);
            FromRegisterControler_Clone.SetRebate_amount(this.m_sRebate_amount);
            FromRegisterControler_Clone.SetTl_name(this.m_sTl_name);
            FromRegisterControler_Clone.SetSalesmancode(this.m_sSalesmancode);
            FromRegisterControler_Clone.SetFree_mon(this.m_sFree_mon);
            FromRegisterControler_Clone.SetGift_imei4(this.m_sGift_imei4);
            FromRegisterControler_Clone.SetRemarks2PY(this.m_sRemarks2PY);
            FromRegisterControler_Clone.SetAction_eff_date(this.m_sAction_eff_date);
            FromRegisterControler_Clone.SetAccessory_desc(this.m_sAccessory_desc);
            FromRegisterControler_Clone.SetGift_code(this.m_sGift_code);
            FromRegisterControler_Clone.SetVas_eff_date(this.m_sVas_eff_date);
            FromRegisterControler_Clone.SetRefer_staff_no(this.m_sRefer_staff_no);
            FromRegisterControler_Clone.SetChannel(this.m_sChannel);
            FromRegisterControler_Clone.SetM_card_no4(this.m_sM_card_no4);
            FromRegisterControler_Clone.SetLob(this.m_sLob);
            FromRegisterControler_Clone.SetPermium(this.m_sPermium);
            FromRegisterControler_Clone.SetRemarks2EDF(this.m_sRemarks2EDF);
            FromRegisterControler_Clone.SetD_time(this.m_sD_time);
            FromRegisterControler_Clone.SetCard_no1(this.m_sCard_no1);
            FromRegisterControler_Clone.SetCancel_renew(this.m_sCancel_renew);
            FromRegisterControler_Clone.SetD_room(this.m_sD_room);
            FromRegisterControler_Clone.SetD_type(this.m_sD_type);
            FromRegisterControler_Clone.SetHkid(this.m_sHkid);
            FromRegisterControler_Clone.SetOrd_place_rel(this.m_sord_place_rel);
            FromRegisterControler_Clone.SetM_card_no2(this.m_sM_card_no2);
            FromRegisterControler_Clone.SetM_card_no3(this.m_sM_card_no3);
            FromRegisterControler_Clone.SetM_card_no1(this.m_sM_card_no1);
            FromRegisterControler_Clone.SetM_card_exp_month(this.m_sM_card_exp_month);
            FromRegisterControler_Clone.SetD_street(this.m_sD_street);
            FromRegisterControler_Clone.SetD_date(this.m_sD_date);
            FromRegisterControler_Clone.SetCard_exp_month(this.m_sCard_exp_month);
            FromRegisterControler_Clone.SetHkid2(this.m_sHkid2);
            FromRegisterControler_Clone.SetTrade_field(this.m_sTrade_field);
            FromRegisterControler_Clone.SetCard_holder(this.m_sCard_holder);
            FromRegisterControler_Clone.SetBank_code(this.m_sBank_code);
            FromRegisterControler_Clone.SetD_build(this.m_sD_build);
            FromRegisterControler_Clone.SetStaff_no(this.m_sStaff_no);
            FromRegisterControler_Clone.SetOrd_place_by(this.m_sOrd_place_by);
            FromRegisterControler_Clone.SetPlan_eff(this.m_sPlan_eff);
            FromRegisterControler_Clone.SetRemarks(this.m_sRemarks);
            FromRegisterControler_Clone.SetWaive(this.m_sWaive);
            FromRegisterControler_Clone.SetPay_method(this.m_sPay_method);
            FromRegisterControler_Clone.SetM_card_exp_year(this.m_sM_card_exp_year);
            FromRegisterControler_Clone.SetExisting_contract_end_year(this.m_sExisting_contract_end_year);
            FromRegisterControler_Clone.SetRef_salesmancode(this.m_sRef_salesmancode);
            FromRegisterControler_Clone.SetStaff_name(this.m_sStaff_name);
            FromRegisterControler_Clone.SetSku(this.m_sSku);
            FromRegisterControler_Clone.SetReasons(this.m_sReasons);
            FromRegisterControler_Clone.SetLob_ac(this.m_sLob_ac);
            FromRegisterControler_Clone.SetCon_eff_date(this.m_sCon_eff_date);
            FromRegisterControler_Clone.SetCard_no3(this.m_sCard_no3);
            FromRegisterControler_Clone.SetCust_name(this.m_sCust_name);
            FromRegisterControler_Clone.SetOrd_place_tel(this.m_sOrd_place_tel);
            FromRegisterControler_Clone.SetMonthly_payment_type(this.m_sMonthly_payment_type);
            FromRegisterControler_Clone.SetAc_no(this.m_sAc_no);
            FromRegisterControler_Clone.SetBundle_name(this.m_sBundle_name);
            FromRegisterControler_Clone.SetContact_no(this.m_sContact_no);
            FromRegisterControler_Clone.SetGift_desc4(this.m_sGift_desc4);
            FromRegisterControler_Clone.SetOrg_ftg(this.m_sOrg_ftg);
            FromRegisterControler_Clone.SetOb_program_id(this.m_sOb_program_id);
            FromRegisterControler_Clone.SetAmount(this.m_sAmount);
            FromRegisterControler_Clone.SetExisting_contract_end_month(this.m_sExisting_contract_end_month);
            FromRegisterControler_Clone.SetMrt_no(this.m_sMrt_no);
            FromRegisterControler_Clone.SetSpecial_approval(this.m_sSpecial_approval);
            FromRegisterControler_Clone.SetM_rebate_amount(this.m_sM_rebate_amount);
            FromRegisterControler_Clone.SetAig_gift(this.m_sAig_gift);
            FromRegisterControler_Clone.SetExtn(this.m_sExtn);
            FromRegisterControler_Clone.SetCard_no4(this.m_sCard_no4);
            FromRegisterControler_Clone.SetLv(this.m_iLv);
            FromRegisterControler_Clone.SetAccessory_imei(this.m_sAccessory_imei);
            FromRegisterControler_Clone.SetRebate(this.m_sRebate);
            FromRegisterControler_Clone.SetAccessory_code(this.m_sAccessory_code);
            FromRegisterControler_Clone.SetM_card_type2(this.m_sM_card_type2);
            FromRegisterControler_Clone.SetCon_per(this.m_sCon_per);
            FromRegisterControler_Clone.SetM_card_holder2(this.m_sM_card_holder2);
            FromRegisterControler_Clone.SetGift_code4(this.m_sGift_code4);
            FromRegisterControler_Clone.SetGift_code3(this.m_sGift_code3);
            FromRegisterControler_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            FromRegisterControler_Clone.SetExt_place_tel(this.m_sExt_place_tel);
            FromRegisterControler_Clone.SetD_floor(this.m_sD_floor);
            FromRegisterControler_Clone.SetAction_required2(this.m_sAction_required2);
            FromRegisterControler_Clone.SetCard_no2(this.m_sCard_no2);
            FromRegisterControler_Clone.SetSp_d_date(this.m_sSp_d_date);
            FromRegisterControler_Clone.SetExtra_d_charge(this.m_sExtra_d_charge);
            FromRegisterControler_Clone.SetTeamcode(this.m_sTeamcode);
            FromRegisterControler_Clone.SetAction_required(this.m_sAction_required);
            FromRegisterControler_Clone.SetProgram(this.m_sProgram);
            FromRegisterControler_Clone.SetExist_plan(this.m_sExist_plan);
            FromRegisterControler_Clone.SetAccessory_price(this.m_sAccessory_price);
            FromRegisterControler_Clone.SetM_Card_type(this.m_sM_Card_type);
            FromRegisterControler_Clone.SetEasywatch_type(this.m_sEasywatch_type);
            FromRegisterControler_Clone.SetGift_imei(this.m_sGift_imei);
            FromRegisterControler_Clone.SetVip_case(this.m_sVip_case);
            FromRegisterControler_Clone.SetS_premium(this.m_sS_premium);
            FromRegisterControler_Clone.SetOrd_place_hkid2(this.m_sOrd_place_hkid2);
            FromRegisterControler_Clone.SetCust_type(this.m_sCust_type);
            FromRegisterControler_Clone.SetContract_person(this.m_sContract_person);
            FromRegisterControler_Clone.SetPlan_eff_date(this.m_sPlan_eff_date);
            FromRegisterControler_Clone.SetCust_staff_no(this.m_sCust_staff_no);
            FromRegisterControler_Clone.SetOrd_place_id_type(this.m_sOrd_place_id_type);
            FromRegisterControler_Clone.SetExtra_rebate_amount(this.m_sExtra_rebate_amount);
            FromRegisterControler_Clone.SetOrd_place_hkid(this.m_sOrd_place_hkid);
            FromRegisterControler_Clone.SetSp_ref_no(this.m_sSp_ref_no);
            FromRegisterControler_Clone.SetLog_date(this.m_sLog_date);
            FromRegisterControler_Clone.SetHs_model(this.m_sHs_model);
            FromRegisterControler_Clone.SetCard_exp_year(this.m_sCard_exp_year);
            FromRegisterControler_Clone.SetRate_plan(this.m_sRate_plan);
            FromRegisterControler_Clone.SetS_permium2(this.m_sS_permium2);
            FromRegisterControler_Clone.SetD_blk(this.m_sD_blk);
            FromRegisterControler_Clone.SetAccept(this.m_sAccept);
            FromRegisterControler_Clone.SetExist_cust_plan(this.m_sExist_cust_plan);
            FromRegisterControler_Clone.SetOrg_fee(this.m_sOrg_fee);
            FromRegisterControler_Clone.SetFast_start(this.m_sFast_start);
            FromRegisterControler_Clone.SetPos_ref_no(this.m_sPos_ref_no);
            FromRegisterControler_Clone.SetGift_code2(this.m_sGift_code2);
            FromRegisterControler_Clone.SetEasywatch_ord_id(this.m_sEasywatch_ord_id);
            FromRegisterControler_Clone.SetId_type(this.m_sId_type);
            FromRegisterControler_Clone.SetR_offer(this.m_sR_offer);
            FromRegisterControler_Clone.SetM_card_type(this.m_sM_card_type);
            return FromRegisterControler_Clone;
        }
        #endregion Clone

    }
}
