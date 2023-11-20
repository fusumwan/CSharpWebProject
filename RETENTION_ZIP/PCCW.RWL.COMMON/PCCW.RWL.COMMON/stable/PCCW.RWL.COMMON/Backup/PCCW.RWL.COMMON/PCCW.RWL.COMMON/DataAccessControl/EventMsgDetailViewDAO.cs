using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
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
using PCCW.RWL.CORE;
namespace PCCW.RWL.CORE
{
    public class EventMsgDetailViewList : List<EventMsgDetailView>
    {
        internal void Find(EventMsgDetailView x_oEventMsgDetailView)
        {
            throw new NotImplementedException();
        }
    };

    [DataObject(true)]
    public class EventMsgDetailViewDAO : EventMsgDetailDalDAO
    {
        protected static EventMsgDetailViewList _SourceData { get; set; }
        private EventMsgDetailViewList _Data
        {
            get
            {
                if (_SourceData == null)
                {
                    _SourceData = this.GetDBAll();
                    return _SourceData;
                }
                else return _SourceData;
            }
            set { _SourceData = value; }
        }

        public EventMsgDetailViewDAO()
        {
            if (_SourceData == null) 
                _SourceData=GetDBAll();
        }

        public EventMsgDetailViewList GetDBAll()
        {
            EventMsgDetailViewList _oEventMsgDetailViewList = new EventMsgDetailViewList();
            EventMsgDetailEntity[] _oEventMsgDetailEntityArr = EventMsgDetailBal.GetArrayObj(GetDB(), null, null, "mid desc");
            if (_oEventMsgDetailEntityArr != null)
            {
                for (int i = 0; i < _oEventMsgDetailEntityArr.Length; i++)
                {
                    EventMsgDetailView _oEventMsgDetailView = new EventMsgDetailView();
                    _oEventMsgDetailView.Index = i;
                    _oEventMsgDetailView.EventMsgDetail = (EventMsgDetail)_oEventMsgDetailEntityArr[i];
                    _oEventMsgDetailView.EventMsgDetail.message = Func.LatinToBig5(_oEventMsgDetailView.EventMsgDetail.message);
                    _oEventMsgDetailView.EventMsgDetail.subject = Func.LatinToBig5(_oEventMsgDetailView.EventMsgDetail.subject);

                    if (_oEventMsgDetailView.EventMsgDetail.active == true)
                        _oEventMsgDetailView.EventMsgDetail.active = true;
                    else
                        _oEventMsgDetailView.EventMsgDetail.active = false;
                    _oEventMsgDetailViewList.Add(_oEventMsgDetailView);
                }
            }
            return _oEventMsgDetailViewList;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public EventMsgDetailViewList FindAll()
        {
            if (this._Data == null)
                throw new NotImplementedException("ERROR:  _Data cannot be null value!");

            return this._Data;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public EventMsgDetailViewList FindAll(string x_sFilter)
        {
            if (this._Data == null)
                throw new NotImplementedException("ERROR:  _Data cannot be null value!");

            return this._Data;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteEventMsgDetailView(EventMsgDetailView x_oEventMsgDetailView)
        {
            if (x_oEventMsgDetailView == null) 
                throw new NotImplementedException("ERROR:  x_oEventMsgDetailView cannot be null value!");

            if (_SourceData == null) { _SourceData = this.GetDBAll(); }

            if (_SourceData.Count > x_oEventMsgDetailView.Index &&
                x_oEventMsgDetailView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].EventMsgDetail_mid == x_oEventMsgDetailView.EventMsgDetail_mid)
                    {
                        x_oEventMsgDetailView.EventMsgDetail.Delete();
                        _SourceData = this.GetDBAll();
                    }
                }
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateEventMsgDetailView(EventMsgDetailView x_oEventMsgDetailView)
        {
            if (x_oEventMsgDetailView == null)
                throw new NotImplementedException("ERROR:  x_oEventMsgDetailView cannot be null value!");

            bool _bSyncFlag = false;
            if (_SourceData == null) { _SourceData = this.GetDBAll(); }
            
            if (_SourceData.Count > x_oEventMsgDetailView.Index && 
                x_oEventMsgDetailView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].EventMsgDetail_mid == x_oEventMsgDetailView.EventMsgDetail_mid)
                    {
                        EventMsgDetailView _oEventMsgDetailView = _SourceData[i];
                        _oEventMsgDetailView.EventMsgDetail.access_right = x_oEventMsgDetailView.EventMsgDetail.access_right;
                        if (string.IsNullOrEmpty(_oEventMsgDetailView.EventMsgDetail.access_right))
                            _oEventMsgDetailView.EventMsgDetail.access_right = string.Empty;

                        if (x_oEventMsgDetailView.EventMsgDetail.active == true)
                            _oEventMsgDetailView.EventMsgDetail.active = true;
                        else
                            _oEventMsgDetailView.EventMsgDetail.active = false;

                        _oEventMsgDetailView.EventMsgDetail.sdate = x_oEventMsgDetailView.EventMsgDetail.sdate;
                        _oEventMsgDetailView.EventMsgDetail.edate = x_oEventMsgDetailView.EventMsgDetail.edate;
                        _oEventMsgDetailView.EventMsgDetail.message = Func.Big5ToLatin(x_oEventMsgDetailView.EventMsgDetail.message);
                        _oEventMsgDetailView.EventMsgDetail.subject = Func.Big5ToLatin(x_oEventMsgDetailView.EventMsgDetail.subject);
                        _oEventMsgDetailView.Save();

                        _oEventMsgDetailView.EventMsgDetail.message = x_oEventMsgDetailView.EventMsgDetail.message;
                        _oEventMsgDetailView.EventMsgDetail.subject = x_oEventMsgDetailView.EventMsgDetail.subject;


                        _bSyncFlag = false;
                        break;
                    }
                    else
                    {
                        _bSyncFlag = true;
                    }
                }
            }
            else
                _bSyncFlag = true;

            if (_bSyncFlag)
            {
                _SourceData = this.GetDBAll();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertEventMsgDetailView(EventMsgDetailView x_oEventMsgDetailView)
        {
            if (x_oEventMsgDetailView == null)
                throw new NotImplementedException("ERROR:  x_oEventMsgDetailView cannot be null value!");

            x_oEventMsgDetailView.EventMsgDetail.cdate = DateTime.Now;
            x_oEventMsgDetailView.EventMsgDetail.active = true;
            x_oEventMsgDetailView.EventMsgDetail.subject = Func.Big5ToLatin(x_oEventMsgDetailView.EventMsgDetail.subject);
            x_oEventMsgDetailView.EventMsgDetail.message = Func.Big5ToLatin(x_oEventMsgDetailView.EventMsgDetail.message);
            EventMsgDetailBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), x_oEventMsgDetailView.EventMsgDetail);
            _SourceData = this.GetDBAll();
        }


        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

    }
}
