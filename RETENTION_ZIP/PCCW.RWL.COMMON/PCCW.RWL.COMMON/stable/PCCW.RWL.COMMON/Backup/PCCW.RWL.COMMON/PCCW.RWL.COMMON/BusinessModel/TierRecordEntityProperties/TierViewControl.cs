using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-07-16>
///-- Description:	<Description,Class :TierViewControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    [Serializable]
    public class TierViewControl : IDisposable
    {

        protected List<TierViewItem> n_oSuccessIn = new List<TierViewItem>();
        #region SuccessIn
        public List<TierViewItem> SuccessIn
        {
            get
            {
                return this.n_oSuccessIn;
            }
            set
            {
                this.n_oSuccessIn = value;
            }
        }
        #endregion SuccessIn


        protected List<TierViewItem> n_oDupRecord = new List<TierViewItem>();
        #region DupRecord
        public List<TierViewItem> DupRecord
        {
            get
            {
                return this.n_oDupRecord;
            }
            set
            {
                this.n_oDupRecord = value;
            }
        }
        #endregion DupRecord


        protected List<TierViewItem> n_oErrRecord = new List<TierViewItem>();
        #region ErrRecord
        public List<TierViewItem> ErrRecord
        {
            get
            {
                return this.n_oErrRecord;
            }
            set
            {
                this.n_oErrRecord = value;
            }
        }
        #endregion ErrRecord


        protected string n_oFilename = string.Empty;
        #region Filename
        public string Filename
        {
            get
            {
                return this.n_oFilename;
            }
            set
            {
                this.n_oFilename = value;
            }
        }
        #endregion


        public string NoFindMid = string.Empty;
        public string NotEqualPlanFee = string.Empty;

        #region Instance
        private static TierViewControl instance;
        #endregion

        #region Constructor & Destructor
        protected TierViewControl() { }

        protected TierViewControl(string x_sFilename,List<TierViewItem> x_oSuccessIn, List<TierViewItem> x_oDupRecord, List<TierViewItem> x_oErrRecord)
        {
            Filename = x_sFilename;
            SuccessIn = x_oSuccessIn;
            DupRecord = x_oDupRecord;
            ErrRecord = x_oErrRecord;
        }

        public static TierViewControl Instance()
        {
            if (instance == null)
                instance = new TierViewControl();
            return instance;
        }

        public static TierViewControl Instance(string x_sFilename,List<TierViewItem> x_oSuccessIn, List<TierViewItem> x_oDupRecord, List<TierViewItem> x_oErrRecord)
        {
            if (instance == null)
                instance = new TierViewControl(x_sFilename,x_oSuccessIn, x_oDupRecord, x_oErrRecord);
            return instance;
        }

        ~TierViewControl() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetFilename() { return this.Filename; }
        public IList<TierViewItem> GetSuccessIn() { return this.SuccessIn; }
        public IList<TierViewItem> GetDupRecord() { return this.DupRecord; }
        public IList<TierViewItem> GetErrRecord() { return this.ErrRecord; }

        public bool SetSuccessIn(List<TierViewItem> value)
        {
            this.SuccessIn = value;
            return true;
        }
        public bool SetDupRecord(List<TierViewItem> value)
        {
            this.DupRecord = value;
            return true;
        }
        public bool SetErrRecord(List<TierViewItem> value)
        {
            this.ErrRecord = value;
            return true;
        }

        public bool SetFilename(string value)
        {
            this.Filename = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(TierViewControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Filename.Equals(x_oObj.Filename)) { return false; }
            if (!this.SuccessIn.Equals(x_oObj.SuccessIn)) { return false; }
            if (!this.DupRecord.Equals(x_oObj.DupRecord)) { return false; }
            if (!this.ErrRecord.Equals(x_oObj.ErrRecord)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.Filename = string.Empty;
            this.SuccessIn.Clear();
            this.DupRecord.Clear();
            this.ErrRecord.Clear();
            this.SuccessIn = new List<TierViewItem>();
            this.DupRecord = new List<TierViewItem>();
            this.ErrRecord = new List<TierViewItem>();
            this.NotEqualPlanFee = string.Empty;
            this.NoFindMid = string.Empty;
        }
        #endregion Release

        #region Clone
        public TierViewControl Clone()
        {
            TierViewControl TierViewControl_Clone = new TierViewControl();
            TierViewControl_Clone.SetSuccessIn(this.SuccessIn);
            TierViewControl_Clone.SetDupRecord(this.DupRecord);
            TierViewControl_Clone.SetErrRecord(this.ErrRecord);
            TierViewControl_Clone.SetFilename(this.Filename);
            return TierViewControl_Clone;
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
