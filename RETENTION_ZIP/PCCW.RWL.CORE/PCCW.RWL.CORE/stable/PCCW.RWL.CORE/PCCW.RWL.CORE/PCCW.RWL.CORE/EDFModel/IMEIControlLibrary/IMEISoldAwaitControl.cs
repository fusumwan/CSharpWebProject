using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IMEISoldAwaitControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class IMEISoldAwaitControl : IMEISoldAwaitControlEntity, IIMEISoldAwaitControlEntityRepository
    {

        #region Instance
        private static IMEISoldAwaitControl instance;
        #endregion

        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        EDFStatusProfile _oEDFStatusProfile = new EDFStatusProfile();
        
        #region Constructor & Destructor
        public IMEISoldAwaitControl() { }

        public IMEISoldAwaitControl(
            string x_sHs_model, string x_sToday1, string x_sOrder_id, 
            string x_sStaff_no, string x_sAment_Date, string x_sImei_no, 
            string x_sEdf_no, string x_sSku, string x_sUid)
        {
            m_sHs_model = x_sHs_model;
            m_sToday1 = x_sToday1;
            m_sOrder_id = x_sOrder_id;
            m_sStaff_no = x_sStaff_no;
            m_sAment_Date = x_sAment_Date;
            m_sImei_no = x_sImei_no;
            m_sEdf_no = x_sEdf_no;
            m_sSku = x_sSku;
            m_sUid = x_sUid;
        }

        public static IMEISoldAwaitControl Instance()
        {
            if (instance == null)
                instance = new IMEISoldAwaitControl();
            return instance;
        }

        public static IMEISoldAwaitControl Instance(
            string x_sHs_model, string x_sToday1, string x_sOrder_id, 
            string x_sStaff_no, string x_sAment_Date, string x_sImei_no,
            string x_sEdf_no, string x_sSku, string x_sUid)
        {
            if (instance == null)
                instance = new IMEISoldAwaitControl(x_sHs_model, x_sToday1, x_sOrder_id, x_sStaff_no, x_sAment_Date, x_sImei_no, x_sEdf_no, x_sSku, x_sUid);
            return instance;
        }

        ~IMEISoldAwaitControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetHs_model() { return this.m_sHs_model; }
        public string GetToday1() { return this.m_sToday1; }
        public string GetToday() { return this.m_sToday; }
        public string GetOrder_id() { return this.m_sOrder_id; }
        public string GetStaff_no() { return this.m_sStaff_no; }
        public string GetAment_Date() { return this.m_sAment_Date; }
        public string GetImei_no() { return this.m_sImei_no; }
        public string GetEdf_no() { return this.m_sEdf_no; }
        public string GetSku() { return this.m_sSku; }
        public string GetUid() { return this.m_sUid; }
        public string GetMrt_no() { return this.m_sMrt_no; }

        public bool SetMrt_no(string value)
        {
            this.m_sMrt_no = value;
            return true;
        }

        public bool SetHs_model(string value)
        {
            this.m_sHs_model = value;
            return true;
        }
        public bool SetToday1(string value)
        {
            this.m_sToday1 = value;
            return true;
        }
        public bool SetToday(string value)
        {
            this.m_sToday = value;
            return true;
        }
        public bool SetOrder_id(string value)
        {
            this.m_sOrder_id = value;
            return true;
        }
        public bool SetStaff_no(string value)
        {
            this.m_sStaff_no = value;
            return true;
        }
        public bool SetAment_Date(string value)
        {
            this.m_sAment_Date = value;
            return true;
        }
        public bool SetImei_no(string value)
        {
            this.m_sImei_no = value;
            return true;
        }
        public bool SetEdf_no(string value)
        {
            this.m_sEdf_no = value;
            return true;
        }
        public bool SetSku(string value)
        {
            this.m_sSku = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        #endregion

        #region ManagementProductSoldAwait
        public void ManagementProductSoldAwait(string x_sItemLocation)
        {
            bool _bFoundIMEI=false;
            SetImei_no(string.Empty);
            string _sQuery = "SELECT * FROM IMEI_Stock Where Dummy2='CC RET' and Kit_Code='" + GetSku() + "' and Status='NORMAL' and DUMMY3='" + x_sItemLocation + "' and IMEI<>' ' and IMEI is not null order by IMEI";
            WebFunc.SaveQuery(_sQuery);
            global::System.Data.Odbc.OdbcDataReader _oDr2 = GetORDB().GetSearch(_sQuery);
            while (_oDr2.Read() && !_bFoundIMEI)
            {
                int _iOrder_id;
                if (int.TryParse(GetOrder_id(), out _iOrder_id))
                {
                    bool _bFlag = _oEDFStatusProfile.AllowAssignNormalIMEI(GetEdf_no(), Func.FR(_oDr2["IMEI"]), Func.IDAdd100000(_iOrder_id));
                    if (_bFlag)
                    {
                        SetImei_no(Func.FR(_oDr2["IMEI"]));
                        string _sAment_Date = string.Empty;
                        string[] _sFormat = { "yyyyMMdd", "yyyyMMdd HH:mm:ss", "yyyyMMdd H:mm:ss", "MM/dd/yyyy", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy H:mm:ss" };
                        if (string.IsNullOrEmpty(Func.FR(_oDr2["Dummy1"])))
                        {
                            if (!Convert.IsDBNull(_oDr2["Create_Date"]) && _oDr2["Create_Date"] != null)
                            {
                                DateTime _dCreateDate = (DateTime)_oDr2["Create_Date"];
                                SetAment_Date(_dCreateDate.ToString("yyyyMMdd"));
                            }
                            else
                            {
                                SetAment_Date(Func.FR(_oDr2["Dummy1"]).ToString());
                            }
                        }
                        else
                            SetAment_Date(Func.FR(_oDr2["Dummy1"]));

                        _bFoundIMEI=true;

                        string _sInsert1 = "INSERT into IMEI_Stock_hist (Kit_Code,Model,Status,ReferenceNo,Create_Date,Create_By,Dummy1,Dummy2,Dummy3,Stock_In_Date,DUMMY4,IMEI,Ament_Date) values ('" + Func.FR(_oDr2["Kit_Code"]).ToString() + "','" + Func.FR(_oDr2["Model"]).ToString() + "','" + Func.FR(_oDr2["Status"]).ToString() + "','" + Func.FR(_oDr2["ReferenceNo"]).ToString() + "',to_date('" + GetToday() + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + GetUid() + "','" + Func.FR(_oDr2["Dummy1"]).ToString() + "','" + Func.FR(_oDr2["Dummy2"]).ToString() + "','" + x_sItemLocation + "','" + Func.FR(_oDr2["Stock_In_Date"]).ToString() + "','" + Func.FR(_oDr2["DUMMY4"]).ToString() + "','" + Func.FR(_oDr2["IMEI"]).ToString() + "',to_date('" + GetAment_Date() + "' , 'yyyymmdd')) ";
                        string _sUpdate1 = "UPDATE IMEI_Stock set Status='SOLD', Dummy1='" + GetToday1() + "', DUMMY4='" + GetOrder_id() + "', ReferenceNo='" + GetEdf_no() + "', StaffNo='" + GetStaff_no() + "',Mobile_no='" + GetMrt_no() + "' ,Completed_Date='" + GetToday1() + "' where Dummy2='CC RET' and IMEI='" + GetImei_no() + "' and Status='NORMAL' and DUMMY3='" + x_sItemLocation + "' ";
                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sInsert1);
                        SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sUpdate1);
                        WebFunc.SaveQuery(_sInsert1);
                        WebFunc.SaveQuery(_sUpdate1);
                        if (Func.FR(_oDr2["IMEI"]).Trim()!=string.Empty)
                        {
                            //_oEDFStatusProfile.UsedDOAIMEI(Func.FR(_oDr2["IMEI"]).Trim(), _iOrder_id, IMEISTATUS.NORMAL, true, false);
                        }

                    }
                }
            }
            _oDr2.Close();
            _oDr2.Dispose();
            if (!_bFoundIMEI)
            {
                SetImei_no("AWAIT");
                StringBuilder _oQuery = new StringBuilder();
                _oQuery.Append("SELECT IMEI FROM IMEI_STOCK WHERE ");
                _oQuery.Append(" Kit_Code='" + GetSku() + "'  ");
                _oQuery.Append(" AND Status='AWAIT' ");
                _oQuery.Append(" AND DUMMY4='" + GetOrder_id() + "' ");
                _oQuery.Append(" AND ReferenceNo='" + GetEdf_no().Trim() + "' ");
                _oQuery.Append(" AND Dummy2='CC RET' ");
                _oQuery.Append(" AND DUMMY3='" + x_sItemLocation + "' ");
                WebFunc.SaveQuery(_oQuery.ToString());
                OdbcDataReader _oDr = SYSConn<ODBCConnect>.Connect().GetSearch(_oQuery.ToString());
                if (!_oDr.Read())
                {
                    string _sInsert1 = "INSERT into IMEI_Stock (Kit_Code,Model,Status,DUMMY4,ReferenceNo,Create_Date,Create_By,StaffNo,Dummy2,Dummy3) values ('" + GetSku() + "','" + GetHs_model().Trim() + "','AWAIT','" + GetOrder_id() + "','" + GetEdf_no() + "',to_date('" + GetToday() + "' , 'dd/mm/yyyy hh24:mi:ss'),'" + GetStaff_no() + "','" + GetStaff_no() + "','CC RET','" + x_sItemLocation + "' ) ";
                    SYSConn<ODBCConnect>.Connect().ExplicitNonQuery(_sInsert1);
                    WebFunc.SaveQuery(_sInsert1.ToString());
                }
                _oDr.Close();
                _oDr.Dispose();
            }
            
            MobileRetentionOrderBal.SetIMEI(GetImei_no(), Func.IDSubtract100000(Convert.ToInt32(GetOrder_id())));
        }
        #endregion

        #region Get Sql DB
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
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

        #region Equals
        public bool Equals(IMEISoldAwaitControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sHs_model.Equals(x_oObj.m_sHs_model)) { return false; }
            if (!this.m_sToday1.Equals(x_oObj.m_sToday1)) { return false; }
            if (!this.m_sOrder_id.Equals(x_oObj.m_sOrder_id)) { return false; }
            if (!this.m_sStaff_no.Equals(x_oObj.m_sStaff_no)) { return false; }
            if (!this.m_sAment_Date.Equals(x_oObj.m_sAment_Date)) { return false; }
            if (!this.m_sImei_no.Equals(x_oObj.m_sImei_no)) { return false; }
            if (!this.m_sEdf_no.Equals(x_oObj.m_sEdf_no)) { return false; }
            if (!this.m_sSku.Equals(x_oObj.m_sSku)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_sMrt_no.Equals(x_oObj.m_sMrt_no)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sHs_model = string.Empty;
            this.m_sToday1 = string.Empty;
            this.m_sOrder_id = string.Empty;
            this.m_sStaff_no = string.Empty;
            this.m_sAment_Date = string.Empty;
            this.m_sImei_no = string.Empty;
            this.m_sEdf_no = string.Empty;
            this.m_sSku = string.Empty;
            this.m_sUid = string.Empty;
            this.m_sMrt_no = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public IMEISoldAwaitControl DeepClone()
        {
            IMEISoldAwaitControl IMEISoldAwaitControl_Clone = new IMEISoldAwaitControl();
            IMEISoldAwaitControl_Clone.SetHs_model(this.m_sHs_model);
            IMEISoldAwaitControl_Clone.SetToday1(this.m_sToday1);
            IMEISoldAwaitControl_Clone.SetOrder_id(this.m_sOrder_id);
            IMEISoldAwaitControl_Clone.SetStaff_no(this.m_sStaff_no);
            IMEISoldAwaitControl_Clone.SetAment_Date(this.m_sAment_Date);
            IMEISoldAwaitControl_Clone.SetImei_no(this.m_sImei_no);
            IMEISoldAwaitControl_Clone.SetEdf_no(this.m_sEdf_no);
            IMEISoldAwaitControl_Clone.SetSku(this.m_sSku);
            IMEISoldAwaitControl_Clone.SetUid(this.m_sUid);
            IMEISoldAwaitControl_Clone.SetMrt_no(this.m_sMrt_no);
            return IMEISoldAwaitControl_Clone;
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
