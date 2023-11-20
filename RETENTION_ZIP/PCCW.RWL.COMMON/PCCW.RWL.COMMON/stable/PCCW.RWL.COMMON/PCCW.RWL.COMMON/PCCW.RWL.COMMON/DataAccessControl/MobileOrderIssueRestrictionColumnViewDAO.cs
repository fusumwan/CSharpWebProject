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
    public class MobileOrderIssueRestrictionColumnViewList : List<MobileOrderIssueRestrictionColumnView>
    {
        internal void Find(MobileOrderIssueRestrictionColumnView x_oMobileOrderIssueRestrictionColumnView)
        {
            throw new NotImplementedException();
        }
    };


    [DataObject(true)]
    public class MobileOrderIssueRestrictionColumnViewDAO
    {
        protected static MobileOrderIssueRestrictionColumnViewList _SourceData { get; set; }
        protected static int? _Count { get; set; }
        private MobileOrderIssueRestrictionColumnViewList _Data
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

        public MobileOrderIssueRestrictionColumnViewDAO()
        {

        }
        public MobileOrderIssueRestrictionColumnViewList GetDBAll()
        {
            return GetDBAll(-1, -1, "mid", string.Empty);
        }

        public MobileOrderIssueRestrictionColumnViewList GetDBAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sFilterExpression)
        {
            if (string.IsNullOrEmpty(x_sSortExpression))
                x_sSortExpression = "mid";
            if (string.IsNullOrEmpty(x_sFilterExpression))
                x_sFilterExpression = string.Empty;
            MobileOrderIssueRestrictionColumnViewList _oMobileOrderIssueRestrictionColumnViewList = new MobileOrderIssueRestrictionColumnViewList();
            IList<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnEntityArr = MobileOrderIssueRestrictionColumnDalDAO.FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, (new List<SearchItem>()), x_sFilterExpression, false);

            if (_oMobileOrderIssueRestrictionColumnEntityArr != null)
            {
                if (_oMobileOrderIssueRestrictionColumnEntityArr.Count > 0)
                {
                    int _iIndex = 0;
                    for (int i = 0; i < _oMobileOrderIssueRestrictionColumnEntityArr.Count; i++)
                    {
                        MobileOrderIssueRestrictionColumnView _oMobileOrderIssueRestrictionColumnView = new MobileOrderIssueRestrictionColumnView();
                        _oMobileOrderIssueRestrictionColumnView.Index = _iIndex;
                        _oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn = (MobileOrderIssueRestrictionColumn)_oMobileOrderIssueRestrictionColumnEntityArr[i];
                        _oMobileOrderIssueRestrictionColumnViewList.Add(_oMobileOrderIssueRestrictionColumnView);
                    }
                }
            }
            return _oMobileOrderIssueRestrictionColumnViewList;
        }

        #region CountAll
        public int CountAll()
        {
            StringBuilder _oQuery = new StringBuilder();
            _oQuery.Append("SELECT COUNT(*) FROM MobileOrderIssueRestrictionColumn WITH (NOLOCK)");
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
        public MobileOrderIssueRestrictionColumnViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, string x_sRestriction_id)
        {
            return GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, " restriction_id=" + ((string.IsNullOrEmpty(x_sRestriction_id)) ? "''" : x_sRestriction_id) + " ");
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public MobileOrderIssueRestrictionColumnViewList FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return GetDBAll(x_iStartRow, x_iPageSize, x_sSortExpression, string.Empty);
        }

        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public void DeleteMobileOrderIssueRestrictionColumnView(MobileOrderIssueRestrictionColumnView x_oMobileOrderIssueRestrictionColumnView)
        {
            if (x_oMobileOrderIssueRestrictionColumnView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionColumnView cannot be null value!");

            if (_SourceData == null) { _SourceData = this.GetDBAll(); }

            if (_SourceData.Count > x_oMobileOrderIssueRestrictionColumnView.Index &&
                x_oMobileOrderIssueRestrictionColumnView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].MobileOrderIssueRestrictionColumn.mid == x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.mid)
                    {
                        if (x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.Delete())
                        {
                            _SourceData = this.GetDBAll();
                            break;
                        }
                    }
                }
            }
        }


        [DataObjectMethod(DataObjectMethodType.Update, true)]
        public void UpdateMobileOrderIssueRestrictionColumnView(MobileOrderIssueRestrictionColumnView x_oMobileOrderIssueRestrictionColumnView)
        {
            if (x_oMobileOrderIssueRestrictionColumnView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionColumnView cannot be null value!");
            bool _bSyncFlag = false;
            if (_SourceData == null) { _SourceData = this.GetDBAll(); }
            if (_SourceData.Count > x_oMobileOrderIssueRestrictionColumnView.Index &&
                x_oMobileOrderIssueRestrictionColumnView.Index >= 0)
            {
                for (int i = 0; i < _SourceData.Count; i++)
                {
                    if (_SourceData[i].MobileOrderIssueRestrictionColumn.mid == x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.mid
                        &&
                        x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_id != null)
                    {
                        MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn = new MobileOrderIssueRestrictionColumn(SYSConn<MSSQLConnect>.Connect(), x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.mid);
                        if(_oMobileOrderIssueRestrictionColumn.Retrieve()){
                            _oMobileOrderIssueRestrictionColumn.active = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.active;
                            _oMobileOrderIssueRestrictionColumn.cdate = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.cdate;
                            _oMobileOrderIssueRestrictionColumn.cid = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.cid;
                            _oMobileOrderIssueRestrictionColumn.restriction_column = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_column;
                            _oMobileOrderIssueRestrictionColumn.restriction_value = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_value;
                            _oMobileOrderIssueRestrictionColumn.action_type = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.action_type;
                            _oMobileOrderIssueRestrictionColumn.mid = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.mid;
                            _oMobileOrderIssueRestrictionColumn.restriction_id = x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_id;
                            _oMobileOrderIssueRestrictionColumn.Save();
                            _SourceData = this.GetDBAll();
                        }

                       
                        _bSyncFlag = false;
                        break;
                    }
                    else
                        _bSyncFlag = false;
                }
            }
            else
                _bSyncFlag = false;

            if (_bSyncFlag)
                _SourceData = this.GetDBAll();
        }

        [DataObjectMethod(DataObjectMethodType.Insert, true)]
        public void InsertMobileOrderIssueRestrictionColumnView(MobileOrderIssueRestrictionColumnView x_oMobileOrderIssueRestrictionColumnView)
        {
            if (x_oMobileOrderIssueRestrictionColumnView == null)
                throw new NotImplementedException("ERROR:  x_oMobileOrderIssueRestrictionColumnView cannot be null value!");

            x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.cdate = DateTime.Now;
            x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.active = true;
            x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_table = MobileRetentionOrder.Para.TableName();
            if (!x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_column.Equals(string.Empty) &&
                !x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.cid.Equals(string.Empty) &&
                !x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_table.Equals(string.Empty) &&
                !x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_value.Equals(string.Empty) &&
                x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn.restriction_id!=null)
            {
                MobileOrderIssueRestrictionColumnBal.InsertWithOutLastID(SYSConn<MSSQLConnect>.Connect(), x_oMobileOrderIssueRestrictionColumnView.MobileOrderIssueRestrictionColumn);
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
