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
///-- Description:	<Description,Class :[ORGFeeProfile],Data Relation Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class ORGFeeProfile
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region Get OrgFee List
        public global::System.Collections.Generic.List<string> Get_OrgFeeList(string x_sProgram)
        {
            if (x_sProgram == null) throw new InvalidOperationException("x_sProgram");
            global::System.Collections.Generic.List<string> _oOrgFeeList = new global::System.Collections.Generic.List<string>();
            string _sQuery = "select DISTINCT fee from " + Configurator.MSSQLTablePrefix + "TariffFeeSchedule with (nolock) where active=1  and program='" + x_sProgram.Trim() + "'";
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            if (_oReader != null){
                while (_oReader.Read())
                    _oOrgFeeList.Add(_oReader[TariffFeeSchedule.Para.fee].ToString());
                if (_oReader != null) _oReader.Close(); _oReader.Dispose();
            } 
            return _oOrgFeeList;
        }
        #endregion
		
		#region  TariffFree
		protected bool TariffFreeProgramUpdate(
            System.Nullable<bool> x_bActive,string x_sProgram,System.Nullable<int> x_iId)
		{
		    if (Convert.IsDBNull(x_iId) || x_iId==null ) return false;
		    string _sQuery = "UPDATE  [TariffFeeSchedule]  SET [active]=@active,[program]=@program WHERE [MobileGoWirelessDetail].[id]=@id";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value =x_bActive;
		        _oCmd.Parameters.Add("@program", SqlDbType.NVarChar).Value =x_sProgram;
		        _oCmd.Parameters.Add("@id", SqlDbType.Int).Value =x_iId;
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
		private bool RemoveTariffFeeScheduleBy(System.Nullable<int> x_iId,string x_sProgram)
		{
		    if (Convert.IsDBNull(x_iId) || x_iId==null ) return false;
		    string _sQuery = "DELETE FROM [TariffFeeSchedule] WHERE [TariffFeeSchedule].[program]=@program";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@id", SqlDbType.Int).Value = x_iId;
		        _oCmd.Parameters.Add("@program", SqlDbType.NVarChar).Value = x_sProgram;
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
		
		private bool RemoveTariffFeeScheduleBy(
            System.Nullable<int> x_iId,System.Nullable<bool> x_bActive,
            string x_sProgram,string x_sFee)
		{
		    if (Convert.IsDBNull(x_iId) || x_iId==null ) return false;
		    string _sQuery = "DELETE FROM [TariffFeeSchedule] WHERE [TariffFeeSchedule].[active]=@active AND [TariffFeeSchedule].[program]=@program AND [TariffFeeSchedule].[fee]=@fee";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@id", SqlDbType.Int).Value = x_iId;
		        _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value = x_bActive;
		        _oCmd.Parameters.Add("@program", SqlDbType.NVarChar).Value = x_sProgram;
		        _oCmd.Parameters.Add("@fee", SqlDbType.NVarChar).Value = x_sFee;
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
        protected ORGFeeProfile() { }

        protected ORGFeeProfile(string x_sProgram)
        {
            m_sProgram = x_sProgram;
        }

        ~ORGFeeProfile() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetProgram() { return this.m_sProgram; }

        public bool SetProgram(string value)
        {
            this.m_sProgram = value;
            return true;
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

        #region Equals
        public bool Equals(ORGFeeProfile x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sProgram.Equals(x_oObj.m_sProgram)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sProgram = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public ORGFeeProfile DeepClone()
        {
            ORGFeeProfile ORGFeeProfile_Clone = new ORGFeeProfile();
            ORGFeeProfile_Clone.SetProgram(this.m_sProgram);
            return ORGFeeProfile_Clone;
        }
        #endregion Clone

    }
}
