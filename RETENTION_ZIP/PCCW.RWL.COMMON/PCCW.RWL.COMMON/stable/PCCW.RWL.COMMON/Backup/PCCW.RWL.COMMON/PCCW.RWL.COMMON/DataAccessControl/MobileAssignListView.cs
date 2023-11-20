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

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2010-11-05>
///-- Description:	<Description,Class :MobileAssignListView, Data Access Object Control>
///-- =============================================

[global::System.Serializable]
public class MobileAssignListView : IDisposable, global::System.IEquatable<MobileAssignListView>
{
    private global::System.Nullable<bool> n_bChk_enabled = false;
    [DataObjectField(true)]
    public global::System.Nullable<bool> Chk_enabled
    {
        get
        {
            return this.n_bChk_enabled;
        }
        set
        {
            this.n_bChk_enabled = value;
        }
    }

    private int _Index = 0;
    [DataObjectField(true)]
    public int Index
    {
        get
        {
            return _Index;
        }
        set
        {
            _Index = value;
        }
    }


    protected MobileAssignList n_oMobileAssignList = null;
    #region MobileAssignList
    [DataObjectField(true)]
    public virtual MobileAssignList MobileAssignList
    {
        get
        {
            if (n_oMobileAssignList == null) { n_oMobileAssignList = new MobileAssignList(GetDB()); }
            return this.n_oMobileAssignList;
        }
        set
        {
            this.n_oMobileAssignList = value;
        }
    }
    #endregion MobileAssignList


    #region MobileAssignList_sku
    [DataObjectField(true)]
    public virtual string MobileAssignList_sku
    {
        get
        {
            return this.MobileAssignList.sku;
        }
        set
        {
            this.MobileAssignList.sku = value;
        }
    }
    #endregion MobileAssignList_sku


    #region MobileAssignList_order_id
    [DataObjectField(true)]
    public virtual global::System.Nullable<int> MobileAssignList_order_id
    {
        get
        {
            return this.MobileAssignList.order_id;
        }
        set
        {
            this.MobileAssignList.order_id = value;
        }
    }
    #endregion MobileAssignList_order_id

    #region MobileAssignList_record_id
    [DataObjectField(true)]
    public virtual global::System.Nullable<int> MobileAssignList_record_id
    {
        get
        {
            return this.MobileAssignList.record_id;
        }
        set
        {
            this.MobileAssignList.record_id = value;
        }
    }
    #endregion MobileAssignList_record_id

    #region MobileAssignList_status
    [DataObjectField(true)]
    public virtual string MobileAssignList_status
    {
        get
        {
            return this.MobileAssignList.status;
        }
        set
        {
            this.MobileAssignList.status = value;
        }
    }
    #endregion MobileAssignList_status


    #region MobileAssignList_hs_model
    [DataObjectField(true)]
    public virtual string MobileAssignList_hs_model
    {
        get
        {
            return this.MobileAssignList.hs_model;
        }
        set
        {
            this.MobileAssignList.hs_model = value;
        }
    }
    #endregion MobileAssignList_hs_model


    #region MobileAssignList_edf_no
    [DataObjectField(true)]
    public virtual string MobileAssignList_edf_no
    {
        get
        {
            return this.MobileAssignList.edf_no;
        }
        set
        {
            this.MobileAssignList.edf_no = value;
        }
    }
    #endregion MobileAssignList_edf_no


    #region MobileAssignList_imei_no
    [DataObjectField(true)]
    public virtual string MobileAssignList_imei_no
    {
        get
        {
            return this.MobileAssignList.imei_no;
        }
        set
        {
            this.MobileAssignList.imei_no = value;
        }
    }
    #endregion MobileAssignList_imei_no


    #region MobileAssignList_active
    [DataObjectField(true)]
    public virtual global::System.Nullable<bool> MobileAssignList_active
    {
        get
        {
            return this.MobileAssignList.active;
        }
        set
        {
            this.MobileAssignList.active = value;
        }
    }
    #endregion MobileAssignList_active


    #region MobileAssignList_d_date
    [DataObjectField(true)]
    public virtual global::System.Nullable<DateTime> MobileAssignList_d_date
    {
        get
        {
            return this.MobileAssignList.d_date;
        }
        set
        {
            this.MobileAssignList.d_date = value;
        }
    }
    #endregion MobileAssignList_d_date

    #region Para
    public class Para
    {
        public const string MobileAssignList = "MobileAssignList";
        public const string MobileAssignList_record_id = "MobileAssignList_record_id";
        public const string MobileAssignList_sku = "MobileAssignList_sku";
        public const string MobileAssignList_order_id = "MobileAssignList_order_id";
        public const string MobileAssignList_hs_model = "MobileAssignList_hs_model";
        public const string MobileAssignList_edf_no = "MobileAssignList_edf_no";
        public const string MobileAssignList_imei_no = "MobileAssignList_imei_no";
        public const string MobileAssignList_active = "MobileAssignList_active";
        public const string MobileAssignList_d_date = "MobileAssignList_d_date";
    }
    #endregion Para

    #region Constructor & Destructor
    public MobileAssignListView() { }

    public MobileAssignListView(MobileAssignList x_oMobileAssignList)
    {
        MobileAssignList = x_oMobileAssignList;
    }

    ~MobileAssignListView() { }

    #endregion Constructor & Destructor

    #region Get & Set
    public MobileAssignList Get() { return this.MobileAssignList; }

    public bool Set(MobileAssignList value)
    {
        this.MobileAssignList = value;
        return true;
    }
    #endregion


    #region IEquatable<MobileAssignListView> Members
    public bool Equals(MobileAssignListView x_oObj)
    {
        if (x_oObj == null) { return false; }
        if (!this.MobileAssignList.Equals(x_oObj.MobileAssignList)) { return false; }
        return true;
    }
    #endregion Equals


    #region Release
    public void Release()
    {
        this.MobileAssignList = null;
    }
    #endregion Release


    public void Save()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public MSSQLConnect GetDB()
    {
        return SYSConn<MSSQLConnect>.Connect(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
    }


    #region Clone
    public MobileAssignListView DeepClone()
    {
        MobileAssignListView MobileAssignListView_Clone = new MobileAssignListView();
        MobileAssignListView_Clone.Set(this.MobileAssignList);
        return MobileAssignListView_Clone;
    }
    #endregion Clone

    void IDisposable.Dispose()
    {
        this.Dispose();
    }
    public void Dispose()
    {
    }
}
