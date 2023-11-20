using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-10-28>
///-- Description:	<Description,Class :VasControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class VasControl : IDisposable
    {
        #region Set Vas
        public static void SetVas(int? x_iOrder_id,DateTime? x_dCdate, string x_sVas, string x_sValue, string x_sValue2, bool x_bMult)
        {
            if (x_sValue.Trim() == string.Empty)
            {
                DeleteVas(x_iOrder_id, x_sVas);
                return;
            }
            if (x_iOrder_id == null) return;

            string _sVas_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + x_sVas + "' AND vas_value='" + x_sValue + "'");
            string _sMulti_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE vas='" + x_sVas + "' AND fee='" + x_sValue2 + "'");

            if (_sVas_id == string.Empty) return;
            MobileOrderVas _oMobileOrderVas = (MobileOrderVas)MobileOrderVasRepository.CreateEntityInstanceObject();
            _oMobileOrderVas.SetOrder_id(x_iOrder_id);
            _oMobileOrderVas.SetVas_field(x_sVas);
            _oMobileOrderVas.SetVas_value((x_sValue.Equals(string.Empty)) ? null : x_sValue);
            _oMobileOrderVas.SetFee((x_sValue2.Equals(string.Empty)) ? null : x_sValue2);

            int _iVas_id;
            if (int.TryParse(_sVas_id, out _iVas_id))
                _oMobileOrderVas.SetVas_id(_iVas_id);
            else
                _oMobileOrderVas.SetVas_id(null);

            int _iMulti_id;
            if (int.TryParse(_sMulti_id, out _iMulti_id))
                _oMobileOrderVas.SetMulti_id(_iMulti_id);
            else
                _oMobileOrderVas.SetMulti_id(null);

            _oMobileOrderVas.SetCdate(x_dCdate);
            _oMobileOrderVas.SetActive(true);
            MobileOrderVasBal.InsertReturnLastID_SP(GetDB(), _oMobileOrderVas);
        }
        #endregion

        #region Delete Vas
        public static void DeleteVas(int? x_iOrder_id, string x_sVas)
        {
            try
            {
                if (x_iOrder_id == null) return;
                if (string.IsNullOrEmpty(x_sVas)) return;
                GetDB().ExplicitNonQuery("DELETE FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas WHERE order_id='" + ((int)x_iOrder_id).ToString() + "' AND vas_field='" + x_sVas + "'");
            }
            catch
            {

            }
        }
        #endregion

        #region Save Vas
        public static void SaveVas(int? x_iOrder_id, DateTime? x_dCdate, string x_sVas, string x_sValue, string x_sValue2, bool x_bMult)
        {
            if (x_sValue.Trim() == string.Empty)
            {
                DeleteVas(x_iOrder_id, x_sVas);
                return;
            }

            if (x_iOrder_id == null) return;
            string _sVas_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WHERE vas_field='" + x_sVas + "' AND vas_value='" + x_sValue.Trim() + "'");
            string _sMulti_id = GetDB().GetExecuteScalar("SELECT id FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription WHERE vas='" + x_sVas + "' AND fee='" + x_sValue2.Trim() + "'");

            if (_sVas_id == string.Empty) return;
            bool _bFlag = true;
            string _sId = GetDB().GetExecuteScalar("SELECT a.id FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas a RIGHT JOIN " + Configurator.MSSQLTablePrefix + "BusinessVas b on a.vas_field=b.vas_field AND a.vas_field=b.vas_field AND a.vas_id=b.id WHERE a.order_id='" + ((int)x_iOrder_id).ToString() + "' AND a.vas_field='" + x_sVas.Trim() + "'");
            if (_sId != string.Empty)
            {
                int _iId;
                if (int.TryParse(_sId.Trim(), out _iId))
                {
                    _bFlag = false;
                    MobileOrderVas _oMobileOrderVas = new MobileOrderVas(GetDB(), _iId);
                    _oMobileOrderVas.SetOrder_id(x_iOrder_id);
                    _oMobileOrderVas.SetVas_value((x_sValue.Equals(string.Empty)) ? null : x_sValue);
                    _oMobileOrderVas.SetFee((x_sValue2.Equals(string.Empty)) ? null : x_sValue2);

                    int _iVas_id;
                    if (int.TryParse(_sVas_id, out _iVas_id))
                        _oMobileOrderVas.SetVas_id(_iVas_id);
                    else
                        _oMobileOrderVas.SetVas_id(null);

                    int _iMulti_id;
                    if (int.TryParse(_sMulti_id, out _iMulti_id))
                        _oMobileOrderVas.SetMulti_id(_iMulti_id);
                    else
                        _oMobileOrderVas.SetMulti_id(null);

                    _oMobileOrderVas.SetCdate(x_dCdate);
                    using (ISession<MSSQLConnect> _oSession = (new SessionFactory<MSSQLConnect>()).OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        _oSession.Update(_oMobileOrderVas);
                        _oTransaction.Commit();
                    }
                }
            }

            if (_bFlag)
            {
                MobileOrderVas _oMobileOrderVas = (MobileOrderVas)MobileOrderVasRepository.CreateEntityInstanceObject();
                _oMobileOrderVas.SetOrder_id(x_iOrder_id);
                _oMobileOrderVas.SetVas_field(x_sVas);
                _oMobileOrderVas.SetVas_value((x_sValue.Equals(string.Empty)) ? null : x_sValue);
                _oMobileOrderVas.SetFee((x_sValue2.Equals(string.Empty)) ? null : x_sValue2);

                int _iVas_id;
                if (int.TryParse(_sVas_id, out _iVas_id))
                    _oMobileOrderVas.SetVas_id(_iVas_id);
                else
                    _oMobileOrderVas.SetVas_id(null);

                int _iMulti_id;
                if (int.TryParse(_sMulti_id, out _iMulti_id))
                    _oMobileOrderVas.SetMulti_id(_iMulti_id);
                else
                    _oMobileOrderVas.SetMulti_id(null);

                _oMobileOrderVas.SetCdate(x_dCdate);
                _oMobileOrderVas.SetActive(true);
                MobileOrderVasBal.InsertReturnLastID_SP(GetDB(), _oMobileOrderVas);
            }
        }
        #endregion

        #region Get Vas
        public static string GetVasValue(int? x_iOrder_id, string x_sVas)
        {
            if (x_iOrder_id == null) return string.Empty;
            if (string.IsNullOrEmpty(x_sVas))
                return string.Empty;
            else
            {
                x_sVas = x_sVas.Trim();
                if (string.IsNullOrEmpty(x_sVas)) { return string.Empty; }
            }

            VasControl _oVasControl = VasControl.Instance();
            if (_oVasControl.MobileOrderVasDS == null)
                _oVasControl.ReLoadDataMobileOrderVas();
            if (_oVasControl.BusinessVasDS == null)
                _oVasControl.ReLoadDataBusinessVas();

            string _sVas_id = string.Empty;
            IDSQuery _oMobileOrderVasDR = IDSQuery.CreateDsCriteria(_oVasControl.MobileOrderVasDS, string.Empty)
                .Add(DsExpression.Eq(MobileOrderVas.Para.order_id, ((int)x_iOrder_id).ToString()));
            if (_oMobileOrderVasDR.Read())
                _sVas_id = _oMobileOrderVasDR[MobileOrderVas.Para.vas_id].ToString();
            
            int _iVas_id;
            if (_sVas_id.Equals(string.Empty)) return string.Empty;
            if (int.TryParse(_sVas_id, out _iVas_id))
            {
                IDSQuery _oBusinessVasDR = IDSQuery.CreateDsCriteria(_oVasControl.BusinessVasDS, string.Empty)
                    .Add(DsExpression.Eq(BusinessVas.Para.id, _iVas_id.ToString()));
                if (_oBusinessVasDR.Read())
                {
                    string _sVas_value = _oBusinessVasDR[BusinessVas.Para.vas_value].ToString();
                    return _sVas_value;
                }
            }

            return string.Empty;
        }
        #endregion


        #region ReLoad Data To Memory
        public void ReLoadDataToMemory()
        {
            this.ReLoadDataBusinessVas();
            this.ReLoadDataBusinessVasDescription();
            this.ReLoadDataMobileOrderVas();
            this.ReLoadDataMobileOrderVasRevision();
        }
        public void ReLoadDataMobileOrderVas()
        {
            this.MobileOrderVasDS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT id,order_id,vas_field,cdate,vas_id,vas_value,multi_id,fee,active FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVas");
        }

        public void ReLoadDataMobileOrderVasRevision()
        {
            this.MobileOrderVasRevisionDS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT id,order_id,vas_field,cdate,vas_id,vas_value,multi_id,fee,active FROM " + Configurator.MSSQLTablePrefix + "MobileOrderVasRevision");
        }

        public void ReLoadDataBusinessVas()
        {
            this.BusinessVasDS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT id,vas_field,vas_value,vas_name,vas_chi_name,multi,active FROM " + Configurator.MSSQLTablePrefix + "BusinessVas");
        }

        public void ReLoadDataBusinessVasDescription()
        {
            this.BusinessVasDescriptionDS = SYSConn<MSSQLConnect>.Connect().GetDS("SELECT id,vas,fee,vas_desc,active FROM " + Configurator.MSSQLTablePrefix + "BusinessVasDescription");
        }
        #endregion

        protected DataSet n_oMobileOrderVasRevisionDS = null;
        #region MobileOrderVasRevisionDS
        public DataSet MobileOrderVasRevisionDS
        {
            get
            {
                return this.n_oMobileOrderVasRevisionDS;
            }
            set
            {
                this.n_oMobileOrderVasRevisionDS = value;
            }
        }
        #endregion MobileOrderVasRevisionDS


        protected DataSet n_oMobileOrderVasDS = null;
        #region MobileOrderVasDS
        public DataSet MobileOrderVasDS
        {
            get
            {
                return this.n_oMobileOrderVasDS;
            }
            set
            {
                this.n_oMobileOrderVasDS = value;
            }
        }
        #endregion MobileOrderVasDS


        protected DataSet n_oBusinessVasDS = null;
        #region BusinessVasDS
        public DataSet BusinessVasDS
        {
            get
            {
                return this.n_oBusinessVasDS;
            }
            set
            {
                this.n_oBusinessVasDS = value;
            }
        }
        #endregion BusinessVasDS


        protected DataSet n_oBusinessVasDescriptionDS = null;
        #region BusinessVasDescriptionDS
        public DataSet BusinessVasDescriptionDS
        {
            get
            {
                return this.n_oBusinessVasDescriptionDS;
            }
            set
            {
                this.n_oBusinessVasDescriptionDS = value;
            }
        }
        #endregion BusinessVasDescriptionDS

        #region Para
        public class Para
        {
            public const string MobileOrderVasRevisionDS = "MobileOrderVasRevisionDS";
            public const string MobileOrderVasDS = "MobileOrderVasDS";
            public const string BusinessVasDS = "BusinessVasDS";
            public const string BusinessVasDescriptionDS = "BusinessVasDescriptionDS";
        }
        #endregion Para

        #region Instance
        private static VasControl instance;
        #endregion


        #region Constructor & Destructor
        protected VasControl() { }

        protected VasControl(DataSet x_oMobileOrderVasRevisionDS, DataSet x_oMobileOrderVasDS, DataSet x_oBusinessVasDS, DataSet x_oBusinessVasDescriptionDS)
        {
            MobileOrderVasRevisionDS = x_oMobileOrderVasRevisionDS;
            MobileOrderVasDS = x_oMobileOrderVasDS;
            BusinessVasDS = x_oBusinessVasDS;
            BusinessVasDescriptionDS = x_oBusinessVasDescriptionDS;
        }

        public static VasControl Instance()
        {
            if (instance == null)
                instance = new VasControl();
            return instance;
        }

        public static VasControl Instance(DataSet x_oMobileOrderVasRevisionDS, DataSet x_oMobileOrderVasDS, DataSet x_oBusinessVasDS, DataSet x_oBusinessVasDescriptionDS)
        {
            if (instance == null)
                instance = new VasControl(x_oMobileOrderVasRevisionDS, x_oMobileOrderVasDS, x_oBusinessVasDS, x_oBusinessVasDescriptionDS);
            return instance;
        }

        ~VasControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

        #region Get Oracle DB
        protected static ODBCConnect GetORDB()
        {
            ODBCConnect _oDB = new ODBCConnect();
            _oDB.SetConnStr(Configurator.DBName.ORADNS + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        public DataSet GetMobileOrderVasRevisionDS() { return this.MobileOrderVasRevisionDS; }
        public DataSet GetMobileOrderVasDS() { return this.MobileOrderVasDS; }
        public DataSet GetBusinessVasDS() { return this.BusinessVasDS; }
        public DataSet GetBusinessVasDescriptionDS() { return this.BusinessVasDescriptionDS; }

        public bool SetMobileOrderVasRevisionDS(DataSet value)
        {
            this.MobileOrderVasRevisionDS = value;
            return true;
        }
        public bool SetMobileOrderVasDS(DataSet value)
        {
            this.MobileOrderVasDS = value;
            return true;
        }
        public bool SetBusinessVasDS(DataSet value)
        {
            this.BusinessVasDS = value;
            return true;
        }
        public bool SetBusinessVasDescriptionDS(DataSet value)
        {
            this.BusinessVasDescriptionDS = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(VasControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.MobileOrderVasRevisionDS.Equals(x_oObj.MobileOrderVasRevisionDS)) { return false; }
            if (!this.MobileOrderVasDS.Equals(x_oObj.MobileOrderVasDS)) { return false; }
            if (!this.BusinessVasDS.Equals(x_oObj.BusinessVasDS)) { return false; }
            if (!this.BusinessVasDescriptionDS.Equals(x_oObj.BusinessVasDescriptionDS)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.MobileOrderVasRevisionDS = null;
            this.MobileOrderVasDS = null;
            this.BusinessVasDS = null;
            this.BusinessVasDescriptionDS = null;
        }
        #endregion Release


        #region Clone
        public VasControl DeepClone()
        {
            VasControl VasControl_Clone = new VasControl();
            VasControl_Clone.SetMobileOrderVasRevisionDS(this.MobileOrderVasRevisionDS);
            VasControl_Clone.SetMobileOrderVasDS(this.MobileOrderVasDS);
            VasControl_Clone.SetBusinessVasDS(this.BusinessVasDS);
            VasControl_Clone.SetBusinessVasDescriptionDS(this.BusinessVasDescriptionDS);
            return VasControl_Clone;
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
