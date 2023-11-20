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
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :ODBMrtGwChk, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class ODBMrtGwChk : ODBMrtGwChkEntity, IODBMrtGwChkEntityRepository, IDisposable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public bool bCheck()
        {
            bool _bFlag = true;
            global::System.Data.SqlClient.SqlDataReader _oDr2 = 
                MobileRetentionOrderBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "top 1 *,family_name + given_name AS 'customer_name' ", "active=1 AND org_mrt='" + GetOrg_mrt() + "'", null, "org_mrt");
            if (!_oDr2.Read()){
                global::System.Data.SqlClient.SqlDataReader _oDr =
                    MobileRetentionOrderBal.GetSearch(SYSConn<MSSQLConnect>.Connect(), "top 1 * ", "active=1 AND mrt_no=" + GetOrg_mrt() + " AND program<>'GO WIRELESS'", null, "order_id desc");
                if (_oDr.Read()){
                    n_oChkList = new Hashtable();
                    n_oChkList.Add(MobileRetentionOrder.Para.cust_name, Func.FR(_oDr["customer_name"]));
                    n_oChkList.Add(MobileRetentionOrder.Para.ac_no, Func.FR(_oDr[MobileRetentionOrder.Para.ac_no]));
                    n_oChkList.Add(MobileRetentionOrder.Para.id_type, Func.FR(_oDr[MobileRetentionOrder.Para.id_type]));
                    string _sHkid1 = string.Empty;
                    string _sHkid2 = string.Empty;
                    if (Func.FR(_oDr[MobileRetentionOrder.Para.id_type]) == "HKID"){
                        _sHkid1 = Func.Left(Func.FR(_oDr[MobileRetentionOrder.Para.hkid]), Func.FR(_oDr[MobileRetentionOrder.Para.hkid]).Length - 1);
                        _sHkid2 = Func.Right(Func.FR(_oDr[MobileRetentionOrder.Para.hkid]), 1);
                    }
                    else{
                        _sHkid1 = Func.FR(_oDr[MobileRetentionOrder.Para.hkid]);
                        _sHkid2 = string.Empty;
                    }
                    n_oChkList.Add("HKID1", _sHkid1);
                    n_oChkList.Add("HKID2", _sHkid2);
                    n_oChkList.Add(MobileRetentionOrder.Para.exist_cust_plan, Func.FR(_oDr[MobileRetentionOrder.Para.exist_cust_plan]));
                    n_oChkList.Add(MobileRetentionOrder.Para.org_fee, Func.FR(_oDr[MobileRetentionOrder.Para.org_fee]));
                    n_oChkList.Add(MobileRetentionOrder.Para.ob_program_id, Func.FR(_oDr[MobileRetentionOrder.Para.ob_program_id]));
                }
                else
                    _bFlag = false;
                _oDr.Close();
                _oDr.Dispose();
            }
            else
                _bFlag = false;

            _oDr2.Close();
            _oDr2.Dispose();
            return _bFlag;
        }

        private bool DropModileGoWirlessRecord( System.Nullable<int> x_iOrder_id)
        {
            string _sQuery = "DELETE FROM [MobileGoWirelessDetail] WHERE [MobileGoWirelessDetail].[order_id]=@order_id";
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@order_id", SqlDbType.Int).Value = x_iOrder_id;
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



        protected bool UpdateAssign(System.Nullable<bool> x_bAssign, System.Nullable<int> x_iOrder_id)
        {
            string _sQuery = "UPDATE  [MobileGoWirelessDetail]  SET [assign]=@assign WHERE [MobileGoWirelessDetail].[order_id]=@order_id";
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@assign", SqlDbType.Bit).Value = x_bAssign;
                _oCmd.Parameters.Add("@order_id", SqlDbType.Int).Value = x_iOrder_id;
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

        #region GetDB
        protected MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }

        protected MSSQLConnect GetCRMDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.CRM + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        #region Get Oracle DB
        protected ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS);
            return _oDB;
        }
        #endregion

        #region Constructor & Destructor
        public ODBMrtGwChk(string x_sOrg_mrt) {
            m_sOrg_mrt = x_sOrg_mrt;
        }

        public ODBMrtGwChk(Hashtable x_oChkList, string x_sOrg_mrt)
        {
            if (x_oChkList == null) throw new ArgumentNullException("Check Org List");
            m_oChkList = x_oChkList;
            m_sOrg_mrt = x_sOrg_mrt;
        }

        ~ODBMrtGwChk() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public Hashtable GetChkList() { return this.m_oChkList; }
        public string GetOrg_mrt() { return this.m_sOrg_mrt; }

        public bool SetChkList(Hashtable value)
        {
            this.m_oChkList = value;
            return true;
        }
        public bool SetOrg_mrt(string value)
        {
            this.m_sOrg_mrt = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(ODBMrtGwChk x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_oChkList.Equals(x_oObj.m_oChkList)) { return false; }
            if (!this.m_sOrg_mrt.Equals(x_oObj.m_sOrg_mrt)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_oChkList = null;
            this.m_sOrg_mrt = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public ODBMrtGwChk DeepClone()
        {
            ODBMrtGwChk ODBMrtGwChk_Clone = new ODBMrtGwChk(this.GetOrg_mrt());
            ODBMrtGwChk_Clone.SetChkList(this.m_oChkList);
            ODBMrtGwChk_Clone.SetOrg_mrt(this.m_sOrg_mrt);
            return ODBMrtGwChk_Clone;
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
