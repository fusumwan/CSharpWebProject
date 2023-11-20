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
///-- Create date: <Create Date 2009-05-Tue>
///-- Description:	<Description,Class :DeliveryTimeTrackable, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class DeliveryTimeTrackable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion


        public static List<string> GetDeliveryTimeList(string x_sLocation)
        {
            List<string> _oTimeList = new List<string>();
            if (string.IsNullOrEmpty(x_sLocation)) return _oTimeList;
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT period FROM DeliveryTime WHERE location='" + x_sLocation+ "' AND active=1 ");
            while (_oDr.Read())
            {
                string _sResult = Func.FR(_oDr["period"]);
                if (!string.IsNullOrEmpty(_sResult))
                {
                    if (!_oTimeList.Contains(_sResult))
                        _oTimeList.Add(_sResult);
                }
            }
            _oDr.Close();
            _oDr.Dispose();
            return _oTimeList;
        }

        #region ResetTime
        private void ResetTime(){
            n_bAm = false;
            n_bPm = false;
            n_bPm6_8 = false;
            n_bPm7_9 = false;
            n_bPm8_10 = false;
        }
        #endregion

		#region Create New Area
        public static bool CreateNewArea(System.Nullable<DateTime> x_dCdate, string x_sCid, System.Nullable<bool> x_bActive, string x_sLocation, System.Nullable<bool> x_bPm7_9, string x_sArea, System.Nullable<bool> x_bPm6_8, System.Nullable<bool> x_bPm8_10, System.Nullable<bool> x_bAm, string x_sDid, System.Nullable<DateTime> x_dDdate, System.Nullable<bool> x_bPm, System.Nullable<int> x_iDelivery_fee)
		{
            string _sQuery = "INSERT INTO [DeliveryTimeRecord] ([cdate],[cid],[active],[location],[pm7_9],[area],[pm6_8],[am],[did],[ddate],[pm],[delivery_fee]) VALUES (@cdate,@cid,@active,@location,@pm7_9,@pm8_10,@area,@pm6_8,@am,@did,@ddate,@pm,@delivery_fee)";
		    using(SqlConnection _oConn =SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult = false;
		        _oCmd.Parameters.Add("@cdate", SqlDbType.DateTime).Value =x_dCdate;
		        _oCmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value =x_sCid;
		        _oCmd.Parameters.Add("@active", SqlDbType.Bit).Value =x_bActive;
		        _oCmd.Parameters.Add("@location", SqlDbType.NVarChar).Value =x_sLocation;
		        _oCmd.Parameters.Add("@pm7_9", SqlDbType.Bit).Value =x_bPm7_9;
                _oCmd.Parameters.Add("@pm8_10", SqlDbType.Bit).Value = x_bPm8_10;
		        _oCmd.Parameters.Add("@area", SqlDbType.NVarChar).Value =x_sArea;
		        _oCmd.Parameters.Add("@pm6_8", SqlDbType.Bit).Value =x_bPm6_8;
		        _oCmd.Parameters.Add("@am", SqlDbType.Bit).Value =x_bAm;
		        _oCmd.Parameters.Add("@did", SqlDbType.NVarChar).Value =x_sDid;
		        _oCmd.Parameters.Add("@ddate", SqlDbType.DateTime).Value =x_dDdate;
		        _oCmd.Parameters.Add("@pm", SqlDbType.Bit).Value =x_bPm;
		        _oCmd.Parameters.Add("@delivery_fee", SqlDbType.Int).Value =x_iDelivery_fee;
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
		
        #region InitDeliveryTime
        public void InitDeliveryTime(string x_sUpdate, string x_sArea, string x_sLocation)
        {
            if (x_sUpdate == null) Logger.WarnFormat("User cannot be found the result with null({0}) value in this function.", "x_sUpdate");
            if (x_sArea == null) throw new ArgumentNullException("x_sArea");
            if (x_sLocation == null) throw new ArgumentNullException("x_sLocation");
			
            n_oDelivery_list = new Hashtable();
            n_oLocation = new global::System.Collections.Generic.List<string>();
            SetUpdate(x_sUpdate);
            LocationTimeMemory _oLocationTimeMemory = LocationTimeMemory.Instance();
            _oLocationTimeMemory.PreLoadDataToMemory();
            if (!this.m_sUpdate.Equals("YES")){
                DataSet _oLocationTimeDataSet = _oLocationTimeMemory.GetLocationTimeDataSet();
                IDSQuery _oDr = IDSQuery.CreateDsCriteria(_oLocationTimeDataSet, DeliveryTimeRecord.Para.TableName())
                       .Add(DsExpression.Eq(DeliveryTimeRecord.Para.location, x_sLocation.Trim()));

                if (_oDr.Read())
                {
                    global::System.Collections.Generic.Dictionary<string, string> _oTimeList = new Dictionary<string, string>();
                    //global::System.Collections.Generic.List<string> _oTimeList = new global::System.Collections.Generic.List<string>();
                    ResetTime();
                    string _sDelivery_fee = string.Empty;
                    if ((Func.FR(_oDr[DeliveryTimeRecord.Para.delivery_fee]).Trim()).Equals(string.Empty))
                        _sDelivery_fee = "0";
                    else
                        _sDelivery_fee = Func.FR(_oDr[DeliveryTimeRecord.Para.delivery_fee]).Trim();

                    if (!n_oDelivery_list.Contains(_sDelivery_fee)){
                        if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.am]).Trim(), out n_bAm)) { if (n_bAm) { if(!_oTimeList.ContainsKey("AM")){ _oTimeList.Add("AM","AM");} } }
                        if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.pm]).Trim(), out n_bPm)) { if (n_bPm) {if(!_oTimeList.ContainsKey("PM")){ _oTimeList.Add("PM","PM");} } }
                        if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.pm6_8]).Trim(), out n_bPm6_8)) { if (n_bPm6_8) { if(!_oTimeList.ContainsKey("18-20")){ _oTimeList.Add("18-20","18-20");} } }
                        if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.pm7_9]).Trim(), out n_bPm7_9)) { if (n_bPm7_9) { if(!_oTimeList.ContainsKey("20-22")){ _oTimeList.Add("20-22","20-22");} } }
                        if (bool.TryParse(Func.FR(_oDr[DeliveryTimeRecord.Para.pm8_10]).Trim(), out n_bPm8_10)) { if (n_bPm8_10) { if (!_oTimeList.ContainsKey("8-10PM")) { _oTimeList.Add("8-10PM", "8-10PM"); } } }
                        if (_oTimeList.Count > 0) n_oDelivery_list.Add(_sDelivery_fee, _oTimeList);
                    }
                }
            }
            else if (n_sUpdate.Equals("YES")){
                SetLocation(_oLocationTimeMemory.FindLocationByArea(x_sArea.Trim()));
            }
        }
        #endregion
		
		#region
		protected bool RevisionAreaData(string x_sArea,System.Nullable<int> x_iMid)
		{
		    if (Convert.IsDBNull(x_iMid) || x_iMid==null ) return false;
		    string _sQuery = "UPDATE  [DeliveryTimeRecord]  SET [area]=@area WHERE [SuspendEventDetail].[mid]=@mid";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
		        _oCmd.Parameters.Add("@area", SqlDbType.NVarChar).Value =x_sArea;
		        _oCmd.Parameters.Add("@mid", SqlDbType.Int).Value =x_iMid;
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

		
		private bool RemoveDeliveryTime(System.Nullable<int> x_iId)
		{
		    if (Convert.IsDBNull(x_iId) || x_iId==null ) return false;
		    string _sQuery = "DELETE FROM [DeliveryTimeRecord] WHERE [DeliveryTimeRecord].[id]=@id";
		    using(SqlConnection _oConn = SYSConn<MSSQLConnect>.Connect().GetConnection()){
		        SqlCommand _oCmd = new SqlCommand(_sQuery, _oConn);
		        bool _bResult=false;
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

        #region GetDB
        protected MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            _oDB.bWithNoLock = true;
            return _oDB;
        }
        #endregion

        protected bool n_bAm = false;
        #region m_bAm
        protected bool m_bAm
        {
            get
            {
                return this.n_bAm;
            }
            set
            {
                this.n_bAm = value;
            }
        }
        #endregion m_bAm


        protected global::System.Collections.Generic.List<string> n_oLocation = new global::System.Collections.Generic.List<string>();
        #region m_oLocation
        protected global::System.Collections.Generic.List<string> m_oLocation
        {
            get
            {
                return this.n_oLocation;
            }
            set
            {
                this.n_oLocation = value;
            }
        }
        #endregion m_oLocation


        protected bool n_bPm6_8 = false;
        #region m_bPm6_8
        protected bool m_bPm6_8
        {
            get
            {
                return this.n_bPm6_8;
            }
            set
            {
                this.n_bPm6_8 = value;
            }
        }
        #endregion m_bPm6_8


        protected bool n_bPm = false;
        #region m_bPm
        protected bool m_bPm
        {
            get
            {
                return this.n_bPm;
            }
            set
            {
                this.n_bPm = value;
            }
        }
        #endregion m_bPm


        protected bool n_bPm7_9 = false;
        #region m_bPm7_9
        protected bool m_bPm7_9
        {
            get
            {
                return this.n_bPm7_9;
            }
            set
            {
                this.n_bPm7_9 = value;
            }
        }
        #endregion m_bPm7_9

        protected bool n_bPm8_10 = false;
        #region m_bPm8_10
        protected bool m_bPm8_10
        {
            get
            {
                return this.n_bPm8_10;
            }
            set
            {
                this.n_bPm8_10 = value;
            }
        }
        #endregion m_bPm8_10


        protected string n_sUpdate = string.Empty;
        #region m_sUpdate
        protected string m_sUpdate
        {
            get
            {
                return this.n_sUpdate;
            }
            set
            {
                this.n_sUpdate = value;
            }
        }
        #endregion m_sUpdate


        protected Hashtable n_oDelivery_list = null;
        #region m_oDelivery_list
        protected Hashtable m_oDelivery_list
        {
            get
            {
                return this.n_oDelivery_list;
            }
            set
            {
                this.n_oDelivery_list = value;
            }
        }
        #endregion m_oDelivery_list


        #region Constructor & Destructor
        public DeliveryTimeTrackable() { }

        public DeliveryTimeTrackable(bool x_bAm, global::System.Collections.Generic.List<string> x_oLocation, bool x_bPm6_8, bool x_bPm, bool x_bPm7_9,bool x_bPm8_10, string x_sUpdate, Hashtable x_oDelivery_fee_list)
        {
            m_bAm = x_bAm;
            m_oLocation = x_oLocation;
            m_bPm6_8 = x_bPm6_8;
            m_bPm = x_bPm;
            m_bPm7_9 = x_bPm7_9;
            m_bPm8_10 = x_bPm8_10;
            m_sUpdate = x_sUpdate;
            m_oDelivery_list = x_oDelivery_fee_list;
        }

        ~DeliveryTimeTrackable() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public bool GetAm() { return this.m_bAm; }
        public global::System.Collections.Generic.List<string> GetLocation() { return this.m_oLocation; }
        public bool GetPm6_8() { return this.m_bPm6_8; }
        public bool GetPm() { return this.m_bPm; }
        public bool GetPm7_9() { return this.m_bPm7_9; }
        public bool GetPm8_10() { return this.m_bPm8_10; }
        public string GetUpdate() { return this.m_sUpdate; }
        public Hashtable GetDelivery_list() { return this.m_oDelivery_list; }

        public bool SetAm(bool value)
        {
            this.m_bAm = value;
            return true;
        }
        public bool SetLocation(List<string> value)
        {
            this.m_oLocation = value;
            return true;
        }
        public bool SetPm6_8(bool value)
        {
            this.m_bPm6_8 = value;
            return true;
        }
        public bool SetPm(bool value)
        {
            this.m_bPm = value;
            return true;
        }
        public bool SetPm7_9(bool value)
        {
            this.m_bPm7_9 = value;
            return true;
        }
        public bool SetPm8_10(bool value)
        {
            this.m_bPm8_10 = value;
            return true;
        }
        public bool SetUpdate(string value)
        {
            this.m_sUpdate = value;
            return true;
        }
        public bool SetDelivery_list(Hashtable value)
        {
            this.m_oDelivery_list = value;
            return true;
        }
        #endregion



        #region Equals
        public bool Equals(DeliveryTimeTrackable x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_bAm.Equals(x_oObj.m_bAm)) { return false; }
            if (!this.m_oLocation.Equals(x_oObj.m_oLocation)) { return false; }
            if (!this.m_bPm6_8.Equals(x_oObj.m_bPm6_8)) { return false; }
            if (!this.m_bPm.Equals(x_oObj.m_bPm)) { return false; }
            if (!this.m_bPm7_9.Equals(x_oObj.m_bPm7_9)) { return false; }
            if (!this.m_bPm8_10.Equals(x_oObj.m_bPm8_10)) { return false; }
            if (!this.m_sUpdate.Equals(x_oObj.m_sUpdate)) { return false; }
            if (!this.m_oDelivery_list.Equals(x_oObj.m_oDelivery_list)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.m_bAm = false;
            this.m_oLocation = null;
            this.m_bPm6_8 = false;
            this.m_bPm = false;
            this.m_bPm7_9 = false;
            this.m_bPm8_10 = false;
            this.m_sUpdate = string.Empty;
            this.m_oDelivery_list = null;
        }
        #endregion Release


        #region DeepClone
        public DeliveryTimeTrackable DeepClone()
        {
            DeliveryTimeTrackable DeliveryTimeTrackable_Clone = new DeliveryTimeTrackable();
            DeliveryTimeTrackable_Clone.SetAm(this.m_bAm);
            DeliveryTimeTrackable_Clone.SetLocation(this.m_oLocation);
            DeliveryTimeTrackable_Clone.SetPm6_8(this.m_bPm6_8);
            DeliveryTimeTrackable_Clone.SetPm(this.m_bPm);
            DeliveryTimeTrackable_Clone.SetPm7_9(this.m_bPm7_9);
            DeliveryTimeTrackable_Clone.SetPm8_10(this.m_bPm8_10);
            DeliveryTimeTrackable_Clone.SetUpdate(this.m_sUpdate);
            DeliveryTimeTrackable_Clone.SetDelivery_list(this.m_oDelivery_list);
            return DeliveryTimeTrackable_Clone;
        }
        #endregion Clone

    }
}
