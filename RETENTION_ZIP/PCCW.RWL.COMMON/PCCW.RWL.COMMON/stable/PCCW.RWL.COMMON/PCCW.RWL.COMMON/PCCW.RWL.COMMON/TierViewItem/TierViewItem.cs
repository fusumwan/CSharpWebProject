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
using System.Runtime.CompilerServices;
using System.Xml;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-07-16>
///-- Description:	<Description,Class :TierViewItem, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class TierViewItem 
    {
        [CompilerGenerated]
        private BusinessTrade n_oBusinessTrade;
        #region BusinessTrade
        [DataObjectField(true)]
        public virtual BusinessTrade BusinessTrade
        {
            [CompilerGenerated]
            get
            {
                return this.n_oBusinessTrade;
            }
            [CompilerGenerated]
            set
            {
                this.n_oBusinessTrade = value;
            }
        }
        #endregion BusinessTrade

        [CompilerGenerated]
        private AutoSelectionProperty n_oAutoSelectionProperty;
        #region AutoSelectionProperty
        [DataObjectField(true)]
        public virtual AutoSelectionProperty AutoSelectionProperty
        {
            [CompilerGenerated]
            get
            {
                return this.n_oAutoSelectionProperty;
            }
            [CompilerGenerated]
            set
            {
                this.n_oAutoSelectionProperty = value;
            }
        }
        #endregion AutoSelectionProperty

        protected bool n_bDupRecord = false;
        #region DupRecord
        public bool DupRecord
        {
            get
            {
                return this.n_bDupRecord;
            }
            set
            {
                this.ResetStatus();
                this.n_bDupRecord = value;
            }
        }
        #endregion DupRecord

        protected int n_iRowLine = -1;
        #region RowLine
        public int RowLine
        {
            get
            {
                return this.n_iRowLine;
            }
            set
            {
                this.n_iRowLine = value;
            }
        }
        #endregion RowLine


        protected bool n_bSuccessRecord = false;
        #region SuccessRecord
        public bool SuccessRecord
        {
            get
            {
                return this.n_bSuccessRecord;
            }
            set
            {
                this.ResetStatus();
                this.n_bSuccessRecord = value;
            }
        }
        #endregion SuccessRecord


        protected bool n_bErrorRecord = false;
        #region ErrorRecord
        public bool ErrorRecord
        {
            get
            {
                return this.n_bErrorRecord;
            }
            set
            {
                this.ResetStatus();
                this.n_bErrorRecord = value;
            }
        }
        #endregion ErrorRecord

        #region Instance
        private static TierViewItem instance;
        #endregion

        #region Constructor & Destructor
        public TierViewItem() { }

        public TierViewItem(int x_iRowLine, bool x_bSuccessRecord, BusinessTrade x_oBusinessTrade, bool x_bDupRecord, AutoSelectionProperty x_oAutoSelectionProperty, bool x_bErrorRecord)
        {
            RowLine = x_iRowLine;
            SuccessRecord = x_bSuccessRecord;
            BusinessTrade = x_oBusinessTrade;
            DupRecord = x_bDupRecord;
            AutoSelectionProperty = x_oAutoSelectionProperty;
            ErrorRecord = x_bErrorRecord;
            
        }

        public static TierViewItem Instance()
        {
            if (instance == null)
                instance = new TierViewItem();
            return instance;
        }

        public static TierViewItem Instance(int x_iRowLine, bool x_bSuccessRecord, BusinessTrade x_oBusinessTrade, bool x_bDupRecord, AutoSelectionProperty x_oAutoSelectionProperty, bool x_bErrorRecord)
        {
            if (instance == null)
                instance = new TierViewItem(x_iRowLine, x_bSuccessRecord, x_oBusinessTrade, x_bDupRecord, x_oAutoSelectionProperty, x_bErrorRecord);
            return instance;
        }

        ~TierViewItem() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public int GetRowLine() { return this.RowLine; }
        public bool GetSuccessRecord() { return this.SuccessRecord; }
        public BusinessTrade GetBusinessTrade() { return this.BusinessTrade; }
        public bool GetDupRecord() { return this.DupRecord; }
        public AutoSelectionProperty GetAutoSelectionProperty() { return this.AutoSelectionProperty; }
        public bool GetErrorRecord() { return this.ErrorRecord; }

        public bool SetRowLine(int value)
        {
            this.RowLine = value;
            return true;
        }
        public bool SetSuccessRecord(bool value)
        {
            this.ResetStatus();
            this.SuccessRecord = value;
            return true;
        }
        public bool SetBusinessTrade(BusinessTrade value)
        {
            this.BusinessTrade = value;
            return true;
        }
        public bool SetDupRecord(bool value)
        {
            this.ResetStatus();
            this.DupRecord = value;
            return true;
        }
        public bool SetAutoSelectionProperty(AutoSelectionProperty value)
        {
            this.AutoSelectionProperty = value;
            return true;
        }
        public bool SetErrorRecord(bool value)
        {
            this.ResetStatus();
            this.ErrorRecord = value;
            return true;
        }
        #endregion

        #region ResetStatus
        protected bool ResetStatus()
        {
            this.n_bErrorRecord = false;
            this.n_bDupRecord = false;
            this.n_bSuccessRecord = false;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(TierViewItem x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.RowLine.Equals(x_oObj.RowLine)) { return false; }
            if (!this.SuccessRecord.Equals(x_oObj.SuccessRecord)) { return false; }
            if (!this.BusinessTrade.Equals(x_oObj.BusinessTrade)) { return false; }
            if (!this.DupRecord.Equals(x_oObj.DupRecord)) { return false; }
            if (!this.AutoSelectionProperty.Equals(x_oObj.AutoSelectionProperty)) { return false; }
            if (!this.ErrorRecord.Equals(x_oObj.ErrorRecord)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.RowLine = -1;
            this.SuccessRecord = false;
            this.BusinessTrade = null;
            this.DupRecord = false;
            this.AutoSelectionProperty = null;
            this.ErrorRecord = false;
        }
        #endregion Release

        #region Clone
        public TierViewItem Clone()
        {
            TierViewItem TierViewItem_Clone = new TierViewItem();
            TierViewItem_Clone.SetRowLine(this.RowLine);
            TierViewItem_Clone.SetSuccessRecord(this.SuccessRecord);
            TierViewItem_Clone.SetBusinessTrade(this.BusinessTrade);
            TierViewItem_Clone.SetDupRecord(this.DupRecord);
            TierViewItem_Clone.SetAutoSelectionProperty(this.AutoSelectionProperty);
            TierViewItem_Clone.SetErrorRecord(this.ErrorRecord);
            return TierViewItem_Clone;
        }
        #endregion Clone
    }
}
