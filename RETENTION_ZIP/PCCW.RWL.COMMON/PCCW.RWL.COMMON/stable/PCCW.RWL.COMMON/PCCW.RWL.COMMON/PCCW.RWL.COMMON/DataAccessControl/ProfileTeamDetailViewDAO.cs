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

    public class ProfileTeamDetailViewList : List<ProfileTeamDetailView>
    {
        internal void Find(ProfileTeamDetailView x_oProfileTeamDetailView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class ProfileTeamDetailViewDAO
    {
        protected static ProfileTeamDetailViewList _SourceData { get; set; }
        private ProfileTeamDetailViewList _Data
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

        public ProfileTeamDetailViewDAO()
        {
            GetDBAll();
        }

        public ProfileTeamDetailViewList GetDBAll()
        {
            ProfileTeamDetailViewList _oProfileTeamDetailViewList = new ProfileTeamDetailViewList();

            ProfileTeamDetailEntity[] _oProfileTeamDetailEntityArr = ProfileTeamDetailBal.GetArrayObj(GetDB(), null, null, null);
            if (_oProfileTeamDetailEntityArr != null)
            {


            }
            /*
              NexusPurchaseOrderingEntity[] _oNexusPurchaseOrderingEntityArr = NexusPurchaseOrderingBal.GetArrayObj(GetDB(), null, null, null);
            if (_oNexusPurchaseOrderingEntityArr != null)
            {
                for (int i = 0; i < _oNexusPurchaseOrderingEntityArr.Length; i++)
                {
                    NexusPurchaseView _oNexusPurchaseView = new NexusPurchaseView();
                    _oNexusPurchaseView.Index = i;
                    _oNexusPurchaseView.NexusPurchaseOrdering = (NexusPurchaseOrdering)_oNexusPurchaseOrderingEntityArr[i];
                    _oNexusPurchaseViewList.Add(_oNexusPurchaseView);
                }
            }
             */

            return _oProfileTeamDetailViewList;
        }


        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public ProfileTeamDetailViewList FindAll()
        {
            return this._Data;
        }


        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteProfileTeamDetailView(ProfileTeamDetailView x_oProfileTeamDetailView)
        {
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateProfileTeamDetailView(ProfileTeamDetailView x_oProfileTeamDetailView)
        {
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertProfileTeamDetailView(ProfileTeamDetailView x_oProfileTeamDetailView)
        {
        }


        public MSSQLConnect GetDB()
        {
            return SYSConn<MSSQLConnect>.Connect(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
        }

    }
}
