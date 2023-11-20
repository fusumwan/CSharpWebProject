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
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
using System.Linq;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-10-20>
///-- Description:	<Description,Class :MobileOneLevel, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class MobileOneLevel : IDisposable
    {
        internal class MOLevel
        {
            public const string MobileOneT1 = "mobileOne";
            public const string MobileOneT2 = "mobileOneT2";
            public const string MobileOneT3 = "mobileOneT3";
        }
        public List<DataSet> MobileLevelDSList = new List<DataSet>();
        public string GetMobileLevelDesc(string x_sMrt_no)
        {
            if (string.IsNullOrEmpty(x_sMrt_no)) return string.Empty;
            string _sMobileLevelDesc = string.Empty;
            try
            {
                StringBuilder _oQuery = new StringBuilder();
                /*
                if(Configurator.IsUat())
                    _oQuery.Append("SELECT TOP 1 [description] FROM [mobileOne](nolock) WHERE active=1 AND key_value ='" + x_sMrt_no.ToString() + "' ");
                else
                    _oQuery.Append("SELECT TOP 1 [description] FROM [mobileOne](nolock) WHERE active=1 AND key_value ='" + x_sMrt_no.ToString() + "' ");
                */
                /*
                _oQuery.Append("SELECT TOP 1 [description] FROM [mobileOne](nolock) WHERE active=1 AND key_value ='" + x_sMrt_no.ToString() + "' ");
                _sMobileLevelDesc = SYSConn<MSSQLConnect>.Connect("MobileOneDB").GetExecuteScalar(_oQuery.ToString());
                */
                /*
                 SELECT TOP 1 description FROM campaign c with(nolock) LEFT JOIN campaign_type ct with(nolock) ON c.cmpgn_id = ct.cmpgn_id AND c.cntct_grp_cd = ct.cntct_grp_cd WHERE c.active=1 AND ct.type is not null AND ct.type = 'mobileOne' AND c.key_value =''
                 */

                _oQuery.Append("SELECT TOP 1 description FROM campaign c with(nolock) LEFT JOIN campaign_type ct WITH(NOLOCK) ON c.cmpgn_id = ct.cmpgn_id AND c.cntct_grp_cd = ct.cntct_grp_cd WHERE c.active=1 AND ct.type IS NOT NULL AND ct.type = 'mobileOne' AND c.key_value ='" + x_sMrt_no.ToString() + "'");
                _sMobileLevelDesc = GetCRMDB().GetExecuteScalar(_oQuery.ToString());

            }
            catch (Exception Exp)
            {

            }
            finally
            {

            }

            if (!string.IsNullOrEmpty(_sMobileLevelDesc)) _sMobileLevelDesc = _sMobileLevelDesc.Trim();
            if (!_sMobileLevelDesc.Equals(string.Empty)) this.SetMobileNumber(x_sMrt_no);
            this.SetMobileOneType(_sMobileLevelDesc.Trim());
            return _sMobileLevelDesc;
        }


        public bool PreloadMobileLevelDescToMemory()
        {
            return PreloadMobileLevelDescToMemory(false);
        }
        public bool PreloadMobileLevelDescToMemory(bool x_bMustReload)
        {

            return true;
        }


        protected string ASignRecord(string _sId, long _lTop)
        {
            string _sLastId = string.Empty;
            DataSet _oDS = null;
            try
            {
                _sLastId = GetCRMDB().GetExecuteScalar("SELECT TOP " + _lTop.ToString() + " c.id FROM campaign c LEFT JOIN campaign_type ct ON c.cmpgn_id = ct.cmpgn_id AND c.cntct_grp_cd = ct.cntct_grp_cd WHERE c.active=1 AND ct.type is not null AND ct.type = 'mobileOne'  AND c.id>" + _sId + " ORDER BY c.id desc");
                _oDS = GetCRMDB().GetDS("SELECT TOP "+_lTop.ToString()+" description,c.key_value key_value  FROM campaign c LEFT JOIN campaign_type ct ON c.cmpgn_id = ct.cmpgn_id AND c.cntct_grp_cd = ct.cntct_grp_cd WHERE c.active=1 AND ct.type is not null AND ct.type = 'mobileOne' AND c.id>" + _sId + " ORDER BY c.id desc");
            }
            catch (Exception exp)
            {
                string _sError = exp.ToString();
            }
            finally
            {
            }
            if (_oDS != null)
            {
                if (_oDS.Tables.Count > 0)
                {
                    MobileLevelDSList.Add(_oDS);
                }
            }
            return _sLastId;
        }

        protected MSSQLConnect GetCRMDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.CRM);
            _oDB.bWithNoLock = true;
            return _oDB;
        }

        public IQueryable<BusinessTradeEntity> GetPermitProgram(IQueryable<BusinessTradeEntity> x_oRwlTradeBaseList, string x_sMrt_no)
        {
            string _sMobileLevelDesc = string.Empty;
            return GetPermitProgram(x_oRwlTradeBaseList, x_sMrt_no, ref _sMobileLevelDesc);
        }

        public IQueryable<BusinessTradeEntity> GetPermitProgram(IQueryable<BusinessTradeEntity> x_oRwlTradeBaseList, string x_sMrt_no, ref string x_sMobileLevelDesc)
        {
            if (x_sMrt_no.Equals(string.Empty)) return x_oRwlTradeBaseList;
            string _sMobileLevelDesc = GetMobileLevelDesc(x_sMrt_no);
            x_sMobileLevelDesc = _sMobileLevelDesc;
            if (_sMobileLevelDesc.ToUpper().Equals(MOLevel.MobileOneT3.ToUpper()))
            {
                x_oRwlTradeBaseList = x_oRwlTradeBaseList.Where(c => c.program != "MOBILEONE PREMIER RETENTION").Select(c => c);
            }
            else if (_sMobileLevelDesc.ToUpper().Equals(MOLevel.MobileOneT2.ToUpper()))
            {
                x_oRwlTradeBaseList = x_oRwlTradeBaseList.Where(c => c.program != "MOBILEONE PREMIER RETENTION").Select(c => c);
            }
            else if (_sMobileLevelDesc.Equals(string.Empty))
            {
                x_oRwlTradeBaseList = x_oRwlTradeBaseList.Where(c => c.program != "MOBILEONE T2 RETENTION" && c.program != "MOBILEONE PREMIER RETENTION" && c.program != "MOBILEONE T3 RETENTION").Select(c => c);
            }
            return x_oRwlTradeBaseList;
        }

        protected string n_sMobileOneType = global::System.String.Empty;
        #region MobileOneType
        public string MobileOneType
        {
            get
            {
                return this.n_sMobileOneType;
            }
            set
            {
                this.n_sMobileOneType = value;
            }
        }
        #endregion MobileOneType

        protected string n_sMobileNumber = global::System.String.Empty;
        #region MobileNumber
        public string MobileNumber
        {
            get
            {
                return this.n_sMobileNumber;
            }
            set
            {
                this.n_sMobileNumber = value;
            }
        }
        #endregion MobileNumber

        #region Instance
        private static MobileOneLevel instance;
        #endregion

        #region Constructor & Destructor
        protected MobileOneLevel() { }

        protected MobileOneLevel(string x_sMobileOneType, string x_sMobileNumber)
        {
            MobileOneType = x_sMobileOneType;
            MobileNumber = x_sMobileNumber;
        }

        
        public static MobileOneLevel Instance()
        {

            if (instance == null)
                instance = new MobileOneLevel();
            return instance;
        }

        public static MobileOneLevel Instance(string x_sMobileOneType, string x_sMobileNumber)
        {
            if (instance == null)
                instance = new MobileOneLevel(x_sMobileOneType, x_sMobileNumber);
            return instance;
        }

        ~MobileOneLevel() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetMobileOneType() { return this.MobileOneType; }
        public string GetMobileNumber() { return this.MobileNumber; }

        public bool SetMobileOneType(string value)
        {
            this.MobileOneType = value;
            return true;
        }
        public bool SetMobileNumber(string value)
        {
            this.MobileNumber = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(MobileOneLevel x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.MobileOneType.Equals(x_oObj.MobileOneType)) { return false; }
            if (!this.MobileNumber.Equals(x_oObj.MobileNumber)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.MobileOneType = global::System.String.Empty;
            this.MobileNumber = global::System.String.Empty;
        }
        #endregion Release

        #region Clone
        public MobileOneLevel DeepClone()
        {
            MobileOneLevel MobileOneLevel_Clone = new MobileOneLevel();
            MobileOneLevel_Clone.SetMobileOneType(this.MobileOneType);
            MobileOneLevel_Clone.SetMobileNumber(this.MobileNumber);
            return MobileOneLevel_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
