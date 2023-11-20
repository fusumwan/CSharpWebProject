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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-01-09>
///-- Description:	<Description,Class :[BundleMappingPropertyControler],Data Releation Access Object Control>
///-- =============================================
///
namespace PCCW.RWL.CORE
{

    public class BundleMappingPropertyControler
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Get Vas Field
        public Hashtable Get_VasfieldList(string x_sNormal_rebate_type, string x_sProgram, string x_sBundle_name, string x_sRate_plan, string x_sHs_model, string x_sIssue_type)
        {
            //if (x_sNormal_rebate_type == null) throw new InvalidOperationException("x_sNormal_rebate_type");
            //if (x_sProgram == null) throw new InvalidOperationException("x_sBundle_name");
            //if (x_sBundle_name == null) throw new InvalidOperationException("x_sBundle_name");
            //if (x_sRate_plan == null) throw new InvalidOperationException("x_sRate_plan");
            Hashtable _oVasfieldList = new Hashtable();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append(" SELECT vas_field  FROM  " + Configurator.MSSQLTablePrefix + "BundleMapping  WITH (NOLOCK) WHERE ");
            _sQuery.Append(" (normal_rebate_type='" + x_sNormal_rebate_type.ToString() + "' OR normal_rebate_type='' OR normal_rebate_type IS NULL) ");
            _sQuery.Append(" AND (program='" + x_sProgram.Trim() + "' OR program IS NULL OR program ='') ");
            _sQuery.Append(" AND active=1 ");
            _sQuery.Append(" AND sdate <=getdate() AND edate >=getdate() ");
            _sQuery.Append(" AND (bundle_name='" + x_sBundle_name.Trim() + "' OR bundle_name IS NULL OR bundle_name ='') ");
            _sQuery.Append(" AND (rate_plan='" + x_sRate_plan.Trim() + "' OR  rate_plan IS NULL OR rate_plan ='' ) ");
            _sQuery.Append(" AND (hs_model='" + x_sHs_model.Trim() + "' OR hs_model IS NULL OR hs_model = '' ) ");
            _sQuery.Append(" AND issue_type='" + x_sIssue_type + "'  ");
            _sQuery.Append(" AND vas_field in (SELECT vas_field FROM " + Configurator.MSSQLTablePrefix + "BusinessVas WITH (NOLOCK)  WHERE active=1)");
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            if (_oReader != null)
            {
                while (_oReader.Read())
                {
                    string _sMulitVasfield = Get_MulitVasfield(_oReader[BusinessVas.Para.vas_field].ToString());
                    if (!_oVasfieldList.ContainsKey(_oReader[BusinessVas.Para.vas_field].ToString()))
                        _oVasfieldList.Add(_oReader[BusinessVas.Para.vas_field].ToString(), _sMulitVasfield.ToString());
                }
            }
            if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); }
            return _oVasfieldList;
        }

        public string Get_MulitVasfield(string x_sVasfield_rs)
        {
            if (x_sVasfield_rs == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sVasfield_rs");
            IDSQuery _oReader = IDSQuery.CreateDsCriteria(VasCreateHolderControl.Instance().Ds, BusinessVas.Para.TableName())
                .Add(DsExpression.Eq(BusinessVas.Para.vas_field, x_sVasfield_rs));
            //string _sQuery = "SELECT top 1 vas_field, multi FROM " + Configurator.MSSQLTablePrefix + "BusinessVas where vas_field='" + x_sVasfield_rs.ToLower() + "'";
            //global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            if (_oReader.Read())
            {
                //if (!global::System.Convert.IsDBNull(_oReader[BusinessVas.Para.multi])){
                if (_oReader[BusinessVas.Para.multi] != null)
                {
                    if (_oReader[BusinessVas.Para.multi].ToString().ToUpper() == "TRUE")
                    {
                        if (!global::System.Convert.IsDBNull(_oReader[BusinessVas.Para.vas_field]))
                        {
                            string _sVasField = _oReader[BusinessVas.Para.vas_field].ToString() + "1";
                            _oReader.Close();
                            //_oReader.Dispose();
                            return _sVasField;
                        }
                    }
                }
            }
            //if (_oReader != null) { _oReader.Close(); _oReader.Dispose(); _oReader = null; }
            if (_oReader != null) { _oReader.Close(); }
            return string.Empty;
        }
        #endregion

        #region
        protected bool BusinessVasDescriptUpdateBy(string x_sFee, System.Nullable<int> x_iId)
        {
            if (Convert.IsDBNull(x_iId) || x_iId == null) return false;
            string _sQuery = "UPDATE  [BusinessVasDescription]  SET [fee]=@fee WHERE [BusinessVasDescription].[id]=@id";
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@fee", SqlDbType.NVarChar).Value = x_sFee;
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
        protected bool BusinessVasDescriptUpdateBy(
            System.Nullable<bool> x_bActive, string x_sFee, string x_sVas_desc,
            string x_sVas, System.Nullable<int> x_iId)
        {
            if (Convert.IsDBNull(x_iId) || x_iId == null) return false;
            string _sQuery = "UPDATE  [BusinessVasDescription]  SET [active]=@active,[fee]=@fee,[vas_desc]=@vas_desc,[vas]=@vas WHERE [BusinessVasDescription].[id]=@id";
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value = x_bActive;
                _oCmd.Parameters.Add("@fee", SqlDbType.NVarChar).Value = x_sFee;
                _oCmd.Parameters.Add("@vas_desc", SqlDbType.NVarChar).Value = x_sVas_desc;
                _oCmd.Parameters.Add("@vas", SqlDbType.NVarChar).Value = x_sVas;
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

        protected bool BusinessVasDescriptUpdateBy(string x_sFee, string x_sVas_desc, System.Nullable<int> x_iId)
        {
            if (Convert.IsDBNull(x_iId) || x_iId == null) return false;
            string _sQuery = "UPDATE  [BusinessVasDescription]  SET [fee]=@fee,[vas_desc]=@vas_desc WHERE [BusinessVasDescription].[id]=@id";
            using (SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection())
            {
                SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
                bool _bResult = false;
                _oCmd.Parameters.Add("@fee", SqlDbType.NVarChar).Value = x_sFee;
                _oCmd.Parameters.Add("@vas_desc", SqlDbType.NVarChar).Value = x_sVas_desc;
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

        #region Get DB
        protected static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion


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



        #region Constructor & Destructor
        public BundleMappingPropertyControler() { }

        public BundleMappingPropertyControler(
            string x_sNormal_rebate_type, string x_sBundle_name,
            string x_sRate_plan, string x_sProgram)
        {
            m_sNormal_rebate = x_sNormal_rebate_type;
            m_sBundle_name = x_sBundle_name;
            m_sRate_plan = x_sRate_plan;
            m_sProgram = x_sProgram;
        }


        ~BundleMappingPropertyControler() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetNormal_rebate() { return this.m_sNormal_rebate; }
        public string GetBundle_name() { return this.m_sBundle_name; }
        public string GetRate_plan() { return this.m_sRate_plan; }
        public string GetProgram() { return this.m_sProgram; }

        public bool SetNormal_rebate(string value)
        {
            this.m_sNormal_rebate = value;
            return true;
        }
        public bool SetBundle_name(string value)
        {
            this.m_sBundle_name = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.m_sRate_plan = value;
            return true;
        }
        public bool SetProgram(string value)
        {
            this.m_sProgram = value;
            return true;
        }
        #endregion




        #region Equals
        public bool Equals(BundleMappingPropertyControler x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sNormal_rebate.Equals(x_oObj.m_sNormal_rebate)) { return false; }
            if (!this.m_sBundle_name.Equals(x_oObj.m_sBundle_name)) { return false; }
            if (!this.m_sRate_plan.Equals(x_oObj.m_sRate_plan)) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sNormal_rebate = string.Empty;
            this.m_sBundle_name = string.Empty;
            this.m_sRate_plan = string.Empty;
            this.m_sProgram = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public BundleMappingPropertyControler DeepClone()
        {
            BundleMappingPropertyControler BundleMappingPropertyControler_Clone = new BundleMappingPropertyControler();
            BundleMappingPropertyControler_Clone.SetNormal_rebate(this.m_sNormal_rebate);
            BundleMappingPropertyControler_Clone.SetBundle_name(this.m_sBundle_name);
            BundleMappingPropertyControler_Clone.SetRate_plan(this.m_sRate_plan);
            BundleMappingPropertyControler_Clone.SetProgram(this.m_sProgram);
            return BundleMappingPropertyControler_Clone;
        }
        #endregion Clone

    }
}
