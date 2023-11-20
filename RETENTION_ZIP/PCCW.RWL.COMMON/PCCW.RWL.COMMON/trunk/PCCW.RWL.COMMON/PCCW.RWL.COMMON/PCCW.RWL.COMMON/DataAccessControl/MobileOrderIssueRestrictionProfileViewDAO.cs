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

    public class MobileOrderIssueRestrictionProfileViewList : List<MobileOrderIssueRestrictionProfileView>
    {
        internal void Find(MobileOrderIssueRestrictionProfileView x_oMobileOrderIssueRestrictionProfileView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class MobileOrderIssueRestrictionProfileViewDAO
    {
        protected static int? _Count { get; set; }
        protected static MobileOrderIssueRestrictionProfileViewList _SourceData { get; set; }
        private MobileOrderIssueRestrictionProfileViewList _Data
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

        public MobileOrderIssueRestrictionProfileViewDAO()
        {
            
        }

        public MobileOrderIssueRestrictionProfileViewList GetDBAll()
        {
            return GetDBAll(-1, -1, "mid", string.Empty);
        }

        public MobileOrderIssueRestrictionProfileViewList GetDBAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sFilterExpression)
        {
            if (string.IsNullOrEmpty(x_sSortExpression))
                x_sSortExpression = "mid";
            if (string.IsNullOrEmpty(x_sFilterExpression))
                x_sFilterExpression = string.Empty;
            MobileOrderIssueRestrictionProfileViewList _oMobileOrderIssueRestrictionProfileViewList = new MobileOrderIssueRestrictionProfileViewList();
            IList<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfileEntityArr = MobileOrderIssueRestrictionProfileDalDAO.FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, (new List<SearchItem>()), x_sFilterExpression, false);
            
            if (_oMobileOrderIssueRestrictionProfileEntityArr != null)
            {
                if (_oMobileOrderIssueRestrictionProfileEntityArr.Count > 0)
                {
                    int _iIndex = 0;
                    for (int i = 0; i < _oMobileOrderIssueRestrictionProfileEntityArr.Count; i++)
                    {
                        MobileOrderIssueRestrictionProfileView _oMobileOrderIssueRestrictionProfileView = new MobileOrderIssueRestrictionProfileView();
                        _oMobileOrderIssueRestrictionProfileView.Index = _iIndex;
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile = (MobileOrderIssueRestrictionProfile)_oMobileOrderIssueRestrictionProfileEntityArr[i];
                        _oMobileOrderIssueRestrictionProfileViewList.Add(_oMobileOrderIssueRestrictionProfileView);
                    }
                }
            }
            return _oMobileOrderIssueRestrictionProfileViewList;
        }

        #region CountAll
        public int CountAll()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT COUNT(*) FROM MobileOrderIssueRestrictionProfile WITH (NOLOCK)");
            string _sCount = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar(_oQuery.ToString());
            int _iCount;
            if (int.TryParse(_sCount, out _iCount))
            {
                if (_Count == null)
                    _Count = _iCount;
            }
            return (int)_Count;
        }
        #endregion


        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public MobileOrderIssueRestrictionProfileViewList FindAll()
        {
            return this._Data;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public MobileOrderIssueRestrictionProfileViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRestriction_id)
        {
            return GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, " restriction_id=" + ((string.IsNullOrEmpty(x_sRestriction_id)) ? "''" : x_sRestriction_id) + " ");
            
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public MobileOrderIssueRestrictionProfileViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression,string.Empty);
        }



        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteMobileOrderIssueRestrictionProfileView(MobileOrderIssueRestrictionProfileView x_oMobileOrderIssueRestrictionProfileView)
        {
            if (x_oMobileOrderIssueRestrictionProfileView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionProfileView cannot be null value!");

            if (_SourceData == null) { _SourceData = this.GetDBAll(); }

            if (_SourceData.Count > x_oMobileOrderIssueRestrictionProfileView.Index &&
                x_oMobileOrderIssueRestrictionProfileView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].MobileOrderIssueRestrictionProfile.restriction_id == x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.restriction_id)
                    {
                        if (x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.Delete())
                        {
                            _SourceData = this.GetDBAll();
                            break;
                        }
                    }
                }
            }
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateMobileOrderIssueRestrictionProfileView(MobileOrderIssueRestrictionProfileView x_oMobileOrderIssueRestrictionProfileView)
        {
            if (x_oMobileOrderIssueRestrictionProfileView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionProfileView cannot be null value!");
            bool _bSyncFlag = false;
            if (_SourceData == null) { _SourceData = this.GetDBAll(); }
            if (_SourceData.Count > x_oMobileOrderIssueRestrictionProfileView.Index &&
                x_oMobileOrderIssueRestrictionProfileView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].MobileOrderIssueRestrictionProfile.restriction_id == x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.restriction_id
                        &&
                        x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.restriction_id != null)
                    {
                        MobileOrderIssueRestrictionProfileView _oMobileOrderIssueRestrictionProfileView = _SourceData[i];
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.SetDB(SYSConn<MSSQLConnect>.Connect());
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.active = x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.active;
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.cdate = x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.cdate;
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.cid = x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.cid;
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.mrt_no = x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.mrt_no;
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile_restriction_id = x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile_restriction_id;
                        _oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.Save();
                        _bSyncFlag = false;
                        break;
                    }
                    else
                        _bSyncFlag = true;
                }
            }
            else
                _bSyncFlag = true;

            if (_bSyncFlag)
                _SourceData = this.GetDBAll();
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertMobileOrderIssueRestrictionProfileView(MobileOrderIssueRestrictionProfileView x_oMobileOrderIssueRestrictionProfileView)
        {
            if (x_oMobileOrderIssueRestrictionProfileView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionView cannot be null value!");

            x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.cdate = DateTime.Now;
            x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.active = true;
            if (!x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.mrt_no.Equals(string.Empty) &&
                !x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile.cid.Equals(string.Empty))
            {
                MobileOrderIssueRestrictionProfileBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), x_oMobileOrderIssueRestrictionProfileView.MobileOrderIssueRestrictionProfile);
            }
            _SourceData = this.GetDBAll();
        }


        public MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }

    }
}
