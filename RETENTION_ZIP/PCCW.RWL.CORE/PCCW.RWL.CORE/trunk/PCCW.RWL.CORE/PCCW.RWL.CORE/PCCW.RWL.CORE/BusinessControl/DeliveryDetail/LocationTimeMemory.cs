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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-10-22>
///-- Description:	<Description,Class :LocationTimeMemory, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class LocationTimeMemory : IDisposable
    {
        protected bool IsLock = false;
        protected DateTime? StartLockTime = DateTime.Now;
        protected DateTime? EndLockTime = DateTime.Now.AddMinutes(5);

        public List<string> FindLocationByArea(string x_sArea)
        {
            if (this.AreaLocationList != null && this.AreaLocationList.ContainsKey(x_sArea))
            {
                return this.AreaLocationList[x_sArea];
            }
            return new List<string>();
        }
        protected Dictionary<string, List<string>> n_oAreaLocationList = null;
        #region AreaLocationList
        public Dictionary<string, List<string>> AreaLocationList
        {
            get
            {
                return this.n_oAreaLocationList;
            }
            set
            {
                this.n_oAreaLocationList = value;
            }
        }
        #endregion AreaLocationList


        protected DataSet n_oLocationTimeDataSet = null;
        #region LocationTimeDataSet
        public DataSet LocationTimeDataSet
        {
            get
            {
                return this.n_oLocationTimeDataSet;
            }
            set
            {
                this.n_oLocationTimeDataSet = value;
            }
        }
        #endregion LocationTimeDataSet


        protected List<string> n_oAreaList = null;
        #region AreaList
        public List<string> AreaList
        {
            get
            {
                return this.n_oAreaList;
            }
            set
            {
                this.n_oAreaList = value;
            }
        }
        #endregion AreaList

        #region Para
        public class Para
        {
            public const string AreaLocationList = "AreaLocationList";
            public const string LocationTimeDataSet = "LocationTimeDataSet";
            public const string AreaList = "AreaList";
        }
        #endregion Para

        #region Instance
        private static LocationTimeMemory instance;
        #endregion

        public void PreLoadDataToMemory()
        {
            PreLoadDataToMemory(false);
        }

        public void PreLoadDataToMemory(bool x_bMustReload)
        {
            if (this.IsLock == false)
            {
                this.IsLock = true;
                if (this.LocationTimeDataSet == null || x_bMustReload)
                    this.LocationTimeDataSet = SYSConn<MSSQLConnect>.Connect().GetDataSet(DeliveryTimeRecord.Para.TableName(), " location,am,pm,pm6_8,pm7_9,pm8_10,delivery_fee", "active=1", null, null, DeliveryTimeRecord.Para.TableName());

                if (this.AreaList == null || x_bMustReload)
                {
                    this.AreaList = new List<string>();
                    SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT distinct area FROM " + DeliveryTimeRecord.Para.TableName() + "   with (nolock)  WHERE active=1");
                    while (_oDr.Read())
                    {
                        string _sArea = Func.FR(_oDr[DeliveryTimeRecord.Para.area]);
                        if (!_sArea.Trim().Equals(string.Empty))
                            this.AreaList.Add(_sArea);
                    }
                    _oDr.Close();
                    _oDr.Dispose();
                }

                if (this.AreaLocationList == null || x_bMustReload)
                {
                    this.AreaLocationList = new Dictionary<string, List<string>>();
                    for (int i = 0; i < AreaList.Count; i++)
                    {
                        List<string> _oLocationList = new List<string>();
                        SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT location FROM " + DeliveryTimeRecord.Para.TableName() + "   with (nolock)  WHERE active=1 AND area='" + AreaList[i].Trim() + "' order by location");
                        while (_oDr.Read())
                        {
                            string _sLocation = Func.FR(_oDr[DeliveryTimeRecord.Para.location]);
                            if (!_sLocation.Trim().Equals(string.Empty))
                                _oLocationList.Add(_sLocation);
                        }
                        _oDr.Close();
                        _oDr.Dispose();
                        if (!AreaLocationList.ContainsKey(AreaList[i].ToString()))
                            AreaLocationList.Add(AreaList[i].ToString(), _oLocationList);
                    }
                }
                this.IsLock = false;
            }
            else
            {
                if (this.StartLockTime == null || this.EndLockTime == null)
                {
                    this.StartLockTime = DateTime.Now;
                    this.EndLockTime = DateTime.Now.AddMinutes(5);
                }
                if (DateTime.Compare(DateTime.Now, (DateTime)this.EndLockTime) > 0)
                {
                    this.IsLock = false;
                    PreLoadDataToMemory(x_bMustReload);
                }
            }
        }

        #region Constructor & Destructor
        protected LocationTimeMemory()
        {

        }

        protected LocationTimeMemory(Dictionary<string, List<string>> x_oAreaLocationList, DataSet x_oLocationTimeDataSet, List<string> x_oAreaList)
        {
            AreaLocationList = x_oAreaLocationList;
            LocationTimeDataSet = x_oLocationTimeDataSet;
            AreaList = x_oAreaList;
        }

        public static LocationTimeMemory Instance()
        {
            if (instance == null)
                instance = new LocationTimeMemory();
            return instance;
        }

        public static LocationTimeMemory Instance(Dictionary<string, List<string>> x_oAreaLocationList, DataSet x_oLocationTimeDataSet, List<string> x_oAreaList)
        {
            if (instance == null)
                instance = new LocationTimeMemory(x_oAreaLocationList, x_oLocationTimeDataSet, x_oAreaList);
            return instance;
        }

        ~LocationTimeMemory() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public Dictionary<string, List<string>> GetAreaLocationList() { return this.AreaLocationList; }
        public DataSet GetLocationTimeDataSet() { return this.LocationTimeDataSet; }
        public List<string> GetAreaList() { return this.AreaList; }

        public bool SetAreaLocationList(Dictionary<string, List<string>> value)
        {
            this.AreaLocationList = value;
            return true;
        }
        public bool SetLocationTimeDataSet(DataSet value)
        {
            this.LocationTimeDataSet = value;
            return true;
        }
        public bool SetAreaList(List<string> value)
        {
            this.AreaList = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(LocationTimeMemory x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.AreaLocationList.Equals(x_oObj.AreaLocationList)) { return false; }
            if (!this.LocationTimeDataSet.Equals(x_oObj.LocationTimeDataSet)) { return false; }
            if (!this.AreaList.Equals(x_oObj.AreaList)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.AreaLocationList = null;
            this.LocationTimeDataSet = null;
            this.AreaList = null;
        }
        #endregion Release


        #region Clone
        public LocationTimeMemory DeepClone()
        {
            LocationTimeMemory LocationTimeMemory_Clone = new LocationTimeMemory();
            LocationTimeMemory_Clone.SetAreaLocationList(this.AreaLocationList);
            LocationTimeMemory_Clone.SetLocationTimeDataSet(this.LocationTimeDataSet);
            LocationTimeMemory_Clone.SetAreaList(this.AreaList);
            return LocationTimeMemory_Clone;
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
