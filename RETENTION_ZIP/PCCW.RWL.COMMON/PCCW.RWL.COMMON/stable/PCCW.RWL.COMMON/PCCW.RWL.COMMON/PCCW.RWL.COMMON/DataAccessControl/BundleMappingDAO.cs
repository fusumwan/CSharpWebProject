using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-18>
///-- Description:	<Description,Table :[BundleMapping],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE
{
    /// <summary>
    /// Summary description for table [BundleMappingDAO] DataAccess layer
    /// </summary>
    public class BundleMappingDAOs : Collection<BundleMapping> { }
    public class BundleMappingDAO : BundleMappingDalDAO
    {

        #region Constructor
        public BundleMappingDAO()
            : base()
        {


        }
        ~BundleMappingDAO()
        {
            base.Release();
        }
        #endregion

        public IList<VasViewField> FindAll()
        {
            IList<VasViewField> _oResultList = new global::System.Collections.Generic.List<VasViewField>();
            BundleMappingEntity[] _oBundleList = BundleMappingRepositoryBase.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), null, null, " program,normal_rebate_type,bundle_name,rate_plan,vas_field");
            for (int i = 0; i < _oBundleList.Length; i++)
            {
                VasViewField _oItem = new VasViewField();
                _oItem.BundleMapping.SetActive(_oBundleList[i].GetActive());
                _oItem.BundleMapping.SetBundle_name(_oBundleList[i].GetBundle_name());
                _oItem.BundleMapping.SetHs_model(_oBundleList[i].GetHs_model());
                _oItem.BundleMapping.SetCdate(_oBundleList[i].GetCdate());
                _oItem.BundleMapping.SetCid(_oBundleList[i].GetCid());
                _oItem.BundleMapping.SetDB(_oBundleList[i].GetDB());
                _oItem.BundleMapping.SetDdate(_oBundleList[i].GetDdate());
                _oItem.BundleMapping.SetDid(_oBundleList[i].GetDid());
                _oItem.BundleMapping.SetEdate(_oBundleList[i].GetEdate());
                _oItem.BundleMapping.SetFound(_oBundleList[i].GetFound());
                _oItem.BundleMapping.SetId(_oBundleList[i].GetId());

                _oItem.BundleMapping.SetProgram(_oBundleList[i].GetProgram());
                _oItem.BundleMapping.SetRate_plan(_oBundleList[i].GetRate_plan());
                _oItem.BundleMapping.SetIssue_type(_oBundleList[i].GetIssue_type());
                _oItem.BundleMapping.SetNormal_rebate_type(_oBundleList[i].GetNormal_rebate_type());
                _oItem.BundleMapping.SetSdate(_oBundleList[i].GetSdate());
                _oItem.BundleMapping.SetVas_field(_oBundleList[i].GetVas_field());
                _oResultList.Add(_oItem);
            }
            return _oResultList;
        }
        public IList<VasViewField> Find(string x_sNormal_rebate_type, string x_sProgram, string x_sRate_plan, string x_sVas_field, string x_sBundle_name,string x_sHs_model,string x_sIssue_type)
        {
            VasFilterObj _oVasFilterObj = new VasFilterObj();
            if (!string.IsNullOrEmpty(x_sNormal_rebate_type)) _oVasFilterObj.SetNormal_rebate_type(x_sNormal_rebate_type);
            if (!string.IsNullOrEmpty(x_sBundle_name)) _oVasFilterObj.SetBundle_name(x_sBundle_name);
            if (!string.IsNullOrEmpty(x_sProgram)) _oVasFilterObj.SetProgram(x_sProgram);
            if (!string.IsNullOrEmpty(x_sRate_plan)) _oVasFilterObj.SetRate_plan(x_sRate_plan);
            if (!string.IsNullOrEmpty(x_sVas_field)) _oVasFilterObj.SetVas_field(x_sVas_field);
            if (!string.IsNullOrEmpty(x_sHs_model)) _oVasFilterObj.SetHs_model(x_sHs_model);
            if (!string.IsNullOrEmpty(x_sIssue_type)) _oVasFilterObj.SetIssue_type(x_sIssue_type);
            return FindFilter(_oVasFilterObj);
        }


        public IList<VasViewField> FindFilter(VasFilterObj x_oVasFilterObj)
        {
            global::System.Text.StringBuilder _oQuery = new global::System.Text.StringBuilder();

            if (x_oVasFilterObj.GetProgram().Trim() != string.Empty && x_oVasFilterObj.GetProgram().Trim() != "ALL")
                _oQuery.Append(" program='" + x_oVasFilterObj.GetProgram().Trim() + "' AND ");

            if (x_oVasFilterObj.GetRate_plan().Trim() != string.Empty && x_oVasFilterObj.GetRate_plan().Trim() != "ALL")
                _oQuery.Append(" rate_plan='" + x_oVasFilterObj.GetRate_plan().Trim() + "' AND ");

            if (x_oVasFilterObj.GetVas_field().Trim() != string.Empty && x_oVasFilterObj.GetVas_field().Trim() != "ALL")
                _oQuery.Append(" vas_field='" + x_oVasFilterObj.GetVas_field().Trim() + "' AND ");

            if (x_oVasFilterObj.GetBundle_name().Trim() != string.Empty && x_oVasFilterObj.GetBundle_name().Trim() != "ALL")
                _oQuery.Append(" bundle_name ='" + x_oVasFilterObj.GetBundle_name().Trim() + "' AND ");

            if (x_oVasFilterObj.GetHs_model().Trim() != string.Empty && x_oVasFilterObj.GetHs_model().Trim() != "ALL")
                _oQuery.Append(" hs_model ='" + x_oVasFilterObj.GetHs_model().Trim() + "' AND ");

            if (x_oVasFilterObj.GetIssue_type().Trim() != string.Empty && x_oVasFilterObj.GetIssue_type().Trim() != "ALL")
                _oQuery.Append(" Issue_type ='" + x_oVasFilterObj.GetIssue_type().Trim() + "' AND ");

            if (!string.IsNullOrEmpty(x_oVasFilterObj.GetNormal_rebate_type()))
            {
                _oQuery.Append(" normal_rebate_type='" + x_oVasFilterObj.GetNormal_rebate_type() + "' AND ");
            }

            _oQuery.Append(" active=1 ");
            IList<VasViewField> _oResultList = new global::System.Collections.Generic.List<VasViewField>();
            BundleMappingEntity[] _oBundleList = BundleMappingRepositoryBase.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), _oQuery.ToString(), null, " program,normal_rebate_type,bundle_name,hs_model,rate_plan,vas_field");
            if (_oBundleList != null)
            {
                for (int i = 0; i < _oBundleList.Length; i++)
                {
                    VasViewField _oItem = new VasViewField();
                    _oItem.BundleMapping.SetActive(_oBundleList[i].GetActive());
                    _oItem.BundleMapping.SetBundle_name(_oBundleList[i].GetBundle_name());
                    _oItem.BundleMapping.SetHs_model(_oBundleList[i].GetHs_model());
                    _oItem.hs_model = _oBundleList[i].GetHs_model();
                    _oItem.BundleMapping.SetCdate(_oBundleList[i].GetCdate());
                    _oItem.BundleMapping.SetCid(_oBundleList[i].GetCid());
                    _oItem.BundleMapping.SetDB(_oBundleList[i].GetDB());
                    _oItem.BundleMapping.SetDdate(_oBundleList[i].GetDdate());
                    _oItem.BundleMapping.SetDid(_oBundleList[i].GetDid());
                    _oItem.BundleMapping.SetEdate(_oBundleList[i].GetEdate());
                    _oItem.BundleMapping.SetFound(_oBundleList[i].GetFound());
                    _oItem.BundleMapping.SetId(_oBundleList[i].GetId());
                    _oItem.BundleMapping.SetNormal_rebate_type(_oBundleList[i].GetNormal_rebate_type());
                    _oItem.BundleMapping.SetProgram(_oBundleList[i].GetProgram());
                    _oItem.BundleMapping.SetRate_plan(_oBundleList[i].GetRate_plan());
                    _oItem.BundleMapping.SetSdate(_oBundleList[i].GetSdate());
                    _oItem.BundleMapping.SetVas_field(_oBundleList[i].GetVas_field());
                    _oItem.normal_rebate_type = _oItem.BundleMapping.GetNormal_rebate_type();
                    _oItem.BundleMapping.SetIssue_type(_oBundleList[i].GetIssue_type());

                    global::System.Data.SqlClient.SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT DISTINCT o.vas_field,p.vas_name,o.bundle_name FROM " + Configurator.MSSQLTablePrefix + "BundleMapping o, " + Configurator.MSSQLTablePrefix + "BusinessVas p WHERE o.vas_field=p.vas_field AND p.active=1 AND  o.active=1 AND o.id=" + Func.FR(_oItem.BundleMapping.GetId()).ToString());
                    if (_oDr.Read())
                    {
                        _oItem.bundle_name = Func.FR(_oDr["bundle_name"]);
                        _oItem.vas_name = Func.FR(_oDr["vas_name"]);
                    }
                    _oDr.Close();
                    _oDr.Dispose();
                    _oResultList.Add(_oItem);

                }
            }
            return _oResultList;
        }
    }

    public class VasViewField
    {

        [CompilerGenerated]
        private BundleMapping _BundleMapping;

        [DataObjectField(true)]
        public virtual BundleMapping BundleMapping
        {
            [CompilerGenerated]
            get
            {
                return this._BundleMapping;
            }
            [CompilerGenerated]
            set
            {
                this._BundleMapping = value;
            }
        }


        [CompilerGenerated]
        private string _normal_rebate_type = string.Empty;

        [DataObjectField(true)]
        public virtual string normal_rebate_type
        {
            [CompilerGenerated]
            get
            {
                if (string.IsNullOrEmpty(this._normal_rebate_type))
                    return "ALL";
                return this._normal_rebate_type;
            }
            [CompilerGenerated]
            set
            {
                this._normal_rebate_type = value;
            }
        }

        [CompilerGenerated]
        private string _bundle_name = string.Empty;

        [DataObjectField(true)]
        public virtual string bundle_name
        {
            [CompilerGenerated]
            get
            {
                return this._bundle_name;
            }
            [CompilerGenerated]
            set
            {
                this._bundle_name = value;
            }
        }

        [CompilerGenerated]
        private string _hs_model = string.Empty;

        [DataObjectField(true)]
        public virtual string hs_model
        {
            [CompilerGenerated]
            get
            {
                return this._hs_model;
            }
            [CompilerGenerated]
            set
            {
                this._hs_model = value;
            }
        }



        [CompilerGenerated]
        private string _vas_name = string.Empty;

        [DataObjectField(true)]
        public virtual string vas_name
        {
            [CompilerGenerated]
            get
            {
                return this._vas_name;
            }
            [CompilerGenerated]
            set
            {
                this._vas_name = value;
            }
        }

        public VasViewField()
        {
            BundleMapping = (BundleMapping)BundleMappingRepository.CreateEntityInstanceObject();
        }
    }
}

