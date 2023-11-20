using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
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

    public class MobileOrderIssueRestrictionViewList : List<MobileOrderIssueRestrictionView>
    {
        internal void Find(MobileOrderIssueRestrictionView x_oMobileOrderIssueRestrictionView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class MobileOrderIssueRestrictionViewDAO
    {
        protected static MobileOrderIssueRestrictionViewList _SourceData { get; set; }
        protected static int? _Count { get; set; }
        private MobileOrderIssueRestrictionViewList _Data
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

        public MobileOrderIssueRestrictionViewDAO()
        {
            //GetDBAll();
        }

        public MobileOrderIssueRestrictionViewList GetDBAll()
        {
            return GetDBAll(-1, -1, "restriction_id", string.Empty);
        }

        public MobileOrderIssueRestrictionViewList GetDBAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sFilterExpression)
        {
            if (string.IsNullOrEmpty(x_sSortExpression))
                x_sSortExpression = "restriction_id";
            if (string.IsNullOrEmpty(x_sFilterExpression))
                x_sFilterExpression = string.Empty;
            MobileOrderIssueRestrictionViewList _oMobileOrderIssueRestrictionViewList = new MobileOrderIssueRestrictionViewList();
            IList<MobileOrderIssueRestrictionEntity> _oMobileOrderIssueRestrictionEntityArr = MobileOrderIssueRestrictionDalDAO.FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, (new List<SearchItem>()), x_sFilterExpression,false);
            if (_oMobileOrderIssueRestrictionEntityArr != null)
            {
                if (_oMobileOrderIssueRestrictionEntityArr.Count > 0)
                {
                    int _iIndex = 0;
                    for (int i = 0; i < _oMobileOrderIssueRestrictionEntityArr.Count; i++)
                    {
                        MobileOrderIssueRestrictionView _oMobileOrderIssueRestrictionView = new MobileOrderIssueRestrictionView();
                        _oMobileOrderIssueRestrictionView.Index = _iIndex;
                        _oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction = (MobileOrderIssueRestriction)_oMobileOrderIssueRestrictionEntityArr[i];
                        _oMobileOrderIssueRestrictionViewList.Add(_oMobileOrderIssueRestrictionView);
                    }
                }
            }
            return _oMobileOrderIssueRestrictionViewList;
        }

        #region CountAll
        public int CountAll()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT COUNT(*) FROM MobileOrderIssueRestriction WITH (NOLOCK)");
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
        public MobileOrderIssueRestrictionViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return this.GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, string.Empty);
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public MobileOrderIssueRestrictionViewList FindAll()
        {
            return this._Data;
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteMobileOrderIssueRestrictionView(MobileOrderIssueRestrictionView x_oMobileOrderIssueRestrictionView)
        {
            if (x_oMobileOrderIssueRestrictionView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionView cannot be null value!");

            if (_SourceData == null) { _SourceData = this.GetDBAll(); }

            if (_SourceData.Count > x_oMobileOrderIssueRestrictionView.Index &&
                x_oMobileOrderIssueRestrictionView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].MobileOrderIssueRestriction.restriction_id == x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.restriction_id &&
                        x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.restriction_id!=null)
                    {
                        if (x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.Delete())
                        {
                            _SourceData = this.GetDBAll();
                        }
                    }
                }
            }
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateMobileOrderIssueRestrictionView(MobileOrderIssueRestrictionView x_oMobileOrderIssueRestrictionView)
        {
            if (x_oMobileOrderIssueRestrictionView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionView cannot be null value!");
            bool _bSyncFlag = false;
            if (_SourceData == null) { _SourceData = this.GetDBAll(); }
            if (_SourceData.Count > x_oMobileOrderIssueRestrictionView.Index &&
                x_oMobileOrderIssueRestrictionView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].MobileOrderIssueRestriction.restriction_id == x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.restriction_id
                        && 
                        x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.restriction_id!=null)
                    {
                        MobileOrderIssueRestriction _oMobileOrderIssueRestriction = new MobileOrderIssueRestriction(SYSConn<MSSQLConnect>.Connect());
                        _oMobileOrderIssueRestriction.SetRestriction_id(x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.restriction_id);
                        if (_oMobileOrderIssueRestriction.Retrieve())
                        {
                            _oMobileOrderIssueRestriction.active = x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.active;
                            _oMobileOrderIssueRestriction.cdate = x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.cdate;
                            _oMobileOrderIssueRestriction.cid = x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.cid;
                            _oMobileOrderIssueRestriction.name = x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.name;
                            _oMobileOrderIssueRestriction.type = x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.type;

                            _oMobileOrderIssueRestriction.Save();
                            _SourceData = this.GetDBAll(); 
                        }
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
        public void InsertMobileOrderIssueRestrictionView(MobileOrderIssueRestrictionView x_oMobileOrderIssueRestrictionView)
        {
            if (x_oMobileOrderIssueRestrictionView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionView cannot be null value!");

            x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.cdate = DateTime.Now;
            x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.active = true;
            if (!x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.type.Equals(string.Empty) &&
                !x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.name.Equals(string.Empty) &&
                !x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction.cid.Equals(string.Empty))
            {
                MobileOrderIssueRestrictionBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), x_oMobileOrderIssueRestrictionView.MobileOrderIssueRestriction);
            }
            _SourceData = this.GetDBAll();
        }

        public void Reset()
        {
            _SourceData = null;
            _Count = null;
        }


        public MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }

    }
}
