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

    public class HandSetOfferTypeViewList : List<HandSetOfferTypeView>
    {
        internal void Find(HandSetOfferTypeView x_oHandSetOfferTypeView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class HandSetOfferTypeViewDAO
    {
        protected static HandSetOfferTypeViewList _SourceData { get; set; }
        private HandSetOfferTypeViewList _Data
        {
            get
            {
                if (_SourceData == null)
                {
                    return this.GetDBAll();
                }
                else return _SourceData;
            }
            set { _SourceData = value; }
        }

        public HandSetOfferTypeViewDAO()
        {
            GetDBAll();
        }

        public HandSetOfferTypeViewList GetDBAll()
        {
            HandSetOfferTypeViewList _oHandSetOfferTypeViewList = new HandSetOfferTypeViewList();
            return _oHandSetOfferTypeViewList;
        }


        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public HandSetOfferTypeViewList FindAll()
        {
            return this._Data;
        }


        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteHandSetOfferTypeView(HandSetOfferTypeView x_oHandSetOfferTypeView)
        {
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateHandSetOfferTypeView(HandSetOfferTypeView x_oHandSetOfferTypeView)
        {
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertHandSetOfferTypeView(HandSetOfferTypeView x_oHandSetOfferTypeView)
        {
        }


        public MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }

    }
}
