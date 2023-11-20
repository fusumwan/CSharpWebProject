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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-07-02>
///-- Description:	<Description,Class :TierExcelPara, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class TierExcelPara : IDisposable
    {

        protected TierSqlExcelCols n_oRemarks = new TierSqlExcelCols();
        #region remarks
        public TierSqlExcelCols remarks
        {
            get
            {
                return this.n_oRemarks;
            }
            set
            {
                this.n_oRemarks = value;
            }
        }
        #endregion remarks


        protected TierSqlExcelCols n_oPeriod = new TierSqlExcelCols();
        #region period
        public TierSqlExcelCols period
        {
            get
            {
                return this.n_oPeriod;
            }
            set
            {
                this.n_oPeriod = value;
            }
        }
        #endregion period


        protected TierSqlExcelCols n_oObprogram = new TierSqlExcelCols();
        #region obprogram
        public TierSqlExcelCols obprogram
        {
            get
            {
                return this.n_oObprogram;
            }
            set
            {
                this.n_oObprogram = value;
            }
        }
        #endregion obprogram


        protected TierSqlExcelCols n_oChannel = new TierSqlExcelCols();
        #region channel
        public TierSqlExcelCols channel
        {
            get
            {
                return this.n_oChannel;
            }
            set
            {
                this.n_oChannel = value;
            }
        }
        #endregion channel


        protected TierSqlExcelCols n_oTier = new TierSqlExcelCols();
        #region tier
        public TierSqlExcelCols tier
        {
            get
            {
                return this.n_oTier;
            }
            set
            {
                this.n_oTier = value;
            }
        }
        #endregion tier


        protected TierSqlExcelCols n_oTradefield_mid = new TierSqlExcelCols();
        #region tradefield_mid
        public TierSqlExcelCols tradefield_mid
        {
            get
            {
                return this.n_oTradefield_mid;
            }
            set
            {
                this.n_oTradefield_mid = value;
            }
        }
        #endregion tradefield_mid


        protected TierSqlExcelCols n_oStart_date = new TierSqlExcelCols();
        #region start_date
        public TierSqlExcelCols start_date
        {
            get
            {
                return this.n_oStart_date;
            }
            set
            {
                this.n_oStart_date = value;
            }
        }
        #endregion start_date


        protected TierSqlExcelCols n_oUid = new TierSqlExcelCols();
        #region uid
        public TierSqlExcelCols uid
        {
            get
            {
                return this.n_oUid;
            }
            set
            {
                this.n_oUid = value;
            }
        }
        #endregion uid


        protected TierSqlExcelCols n_oPlan_fee = new TierSqlExcelCols();
        #region plan_fee
        public TierSqlExcelCols plan_fee
        {
            get
            {
                return this.n_oPlan_fee;
            }
            set
            {
                this.n_oPlan_fee = value;
            }
        }
        #endregion plan_fee


        protected TierSqlExcelCols n_oEnd_date = new TierSqlExcelCols();
        #region end_date
        public TierSqlExcelCols end_date
        {
            get
            {
                return this.n_oEnd_date;
            }
            set
            {
                this.n_oEnd_date = value;
            }
        }
        #endregion end_date


        protected TierSqlExcelCols n_oPo_date = new TierSqlExcelCols();
        #region po_date
        public TierSqlExcelCols po_date
        {
            get
            {
                return this.n_oPo_date;
            }
            set
            {
                this.n_oPo_date = value;
            }
        }
        #endregion po_date


        #region Constructor & Destructor
        public TierExcelPara() {
            Init();
        }

        public TierExcelPara(TierSqlExcelCols x_oRemarks, TierSqlExcelCols x_oFree_month, TierSqlExcelCols x_oPeriod, TierSqlExcelCols x_oPremium_2, TierSqlExcelCols x_oObprogram, TierSqlExcelCols x_oChannel, TierSqlExcelCols x_oTier, TierSqlExcelCols x_oTradefield_mid, TierSqlExcelCols x_oStart_date, TierSqlExcelCols x_oUid, TierSqlExcelCols x_oPremium_1, TierSqlExcelCols x_oMonthly_rebate, TierSqlExcelCols x_oPlan_fee, TierSqlExcelCols x_oEnd_date, TierSqlExcelCols x_oPo_date)
        {
            remarks = x_oRemarks;
            period = x_oPeriod;
            obprogram = x_oObprogram;
            channel = x_oChannel;
            tier = x_oTier;
            tradefield_mid = x_oTradefield_mid;
            start_date = x_oStart_date;
            uid = x_oUid;
            plan_fee = x_oPlan_fee;
            end_date = x_oEnd_date;
            po_date = x_oPo_date;
            Init();
        }

        ~TierExcelPara() { }

        #endregion Constructor & Destructor

        public void Init()
        {
            obprogram.DataSetPoint = 0;
            obprogram.ExcelColName = "obprogram";
            obprogram.TierColName = "obprogram";
            
            period.DataSetPoint = 1;
            period.ExcelColName = "period";
            period.TierColName = "period";
            
            plan_fee.DataSetPoint = 2;
            plan_fee.ExcelColName = "plan_fee";
            plan_fee.TierColName = "plan_fee";
            
            tier.DataSetPoint = 3;
            tier.ExcelColName = "tier";
            tier.TierColName = "tier";

            tradefield_mid.DataSetPoint = 4;
            tradefield_mid.ExcelColName = "mid";
            tradefield_mid.TierColName = "mid";

            channel.DataSetPoint = 5;
            channel.ExcelColName = "channel";
            channel.TierColName = "channel";

            start_date.DataSetPoint = 6;
            start_date.ExcelColName = "start_date";
            start_date.TierColName = "start_date";

            end_date.DataSetPoint = 7;
            end_date.ExcelColName = "end_date";
            end_date.TierColName = "end_date";

            uid.DataSetPoint = 8;
            uid.ExcelColName = "uid";
            uid.TierColName = "uid";

            po_date.DataSetPoint =9;
            po_date.ExcelColName = "po_date";
            po_date.TierColName = "po_date";

            remarks.DataSetPoint = 10;
            remarks.ExcelColName = "remarks";
            remarks.TierColName = "remarks";
        }


        #region Get & Set
        public TierSqlExcelCols GetRemarks() { return this.remarks; }

        public TierSqlExcelCols GetPeriod() { return this.period; }

        public TierSqlExcelCols GetObprogram() { return this.obprogram; }
        public TierSqlExcelCols GetChannel() { return this.channel; }
        public TierSqlExcelCols GetTier() { return this.tier; }
        public TierSqlExcelCols GetTradefield_mid() { return this.tradefield_mid; }
        public TierSqlExcelCols GetStart_date() { return this.start_date; }
        public TierSqlExcelCols GetUid() { return this.uid; }


        public TierSqlExcelCols GetPlan_fee() { return this.plan_fee; }
        public TierSqlExcelCols GetEnd_date() { return this.end_date; }
        public TierSqlExcelCols GetPo_date() { return this.po_date; }

        public bool SetRemarks(TierSqlExcelCols value)
        {
            this.remarks = value;
            return true;
        }
        public bool SetPeriod(TierSqlExcelCols value)
        {
            this.period = value;
            return true;
        }
        public bool SetObprogram(TierSqlExcelCols value)
        {
            this.obprogram = value;
            return true;
        }
        public bool SetChannel(TierSqlExcelCols value)
        {
            this.channel = value;
            return true;
        }
        public bool SetTier(TierSqlExcelCols value)
        {
            this.tier = value;
            return true;
        }
        public bool SetTradefield_mid(TierSqlExcelCols value)
        {
            this.tradefield_mid = value;
            return true;
        }
        public bool SetStart_date(TierSqlExcelCols value)
        {
            this.start_date = value;
            return true;
        }
        public bool SetUid(TierSqlExcelCols value)
        {
            this.uid = value;
            return true;
        }
        public bool SetPlan_fee(TierSqlExcelCols value)
        {
            this.plan_fee = value;
            return true;
        }
        public bool SetEnd_date(TierSqlExcelCols value)
        {
            this.end_date = value;
            return true;
        }
        public bool SetPo_date(TierSqlExcelCols value)
        {
            this.po_date = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(TierExcelPara x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.remarks.Equals(x_oObj.remarks)) { return false; }
            if (!this.period.Equals(x_oObj.period)) { return false; }
            if (!this.obprogram.Equals(x_oObj.obprogram)) { return false; }
            if (!this.channel.Equals(x_oObj.channel)) { return false; }
            if (!this.tier.Equals(x_oObj.tier)) { return false; }
            if (!this.tradefield_mid.Equals(x_oObj.tradefield_mid)) { return false; }
            if (!this.start_date.Equals(x_oObj.start_date)) { return false; }
            if (!this.uid.Equals(x_oObj.uid)) { return false; }
            if (!this.plan_fee.Equals(x_oObj.plan_fee)) { return false; }
            if (!this.end_date.Equals(x_oObj.end_date)) { return false; }
            if (!this.po_date.Equals(x_oObj.po_date)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.remarks = null;
            this.period = null;
            this.obprogram = null;
            this.channel = null;
            this.tier = null;
            this.tradefield_mid = null;
            this.start_date = null;
            this.uid = null;
            this.plan_fee = null;
            this.end_date = null;
            this.po_date = null;
        }
        #endregion Release


        #region DeepClone
        public TierExcelPara DeepClone()
        {
            TierExcelPara TierExcelPara_Clone = new TierExcelPara();
            TierExcelPara_Clone.SetRemarks(this.remarks);
            TierExcelPara_Clone.SetPeriod(this.period);
            TierExcelPara_Clone.SetObprogram(this.obprogram);
            TierExcelPara_Clone.SetChannel(this.channel);
            TierExcelPara_Clone.SetTier(this.tier);
            TierExcelPara_Clone.SetTradefield_mid(this.tradefield_mid);
            TierExcelPara_Clone.SetStart_date(this.start_date);
            TierExcelPara_Clone.SetUid(this.uid);
            TierExcelPara_Clone.SetPlan_fee(this.plan_fee);
            TierExcelPara_Clone.SetEnd_date(this.end_date);
            TierExcelPara_Clone.SetPo_date(this.po_date);
            return TierExcelPara_Clone;
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
