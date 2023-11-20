using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Xml;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-Mon>
///-- Description:	<Description,Class :SimMrtControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class SimMrtControl : SimMrtControlEntity, ISimMrtControlEntityRepository, IDisposable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public string GetSimMrt()
        {
            SessionFactory<MSSQLConnect> _oSessionFactory = new SessionFactory<MSSQLConnect>();
            if (!GetUid().Equals(string.Empty))
            {
                if (GetDelete().Equals("YES"))
                {
                    ISession<MSSQLConnect> _oSession = null;
                    using (_oSession = _oSessionFactory.OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        int? _iMrt = (Func.IsParseInt(this.GetMrt())) ? (int?)(Convert.ToInt32(this.GetMrt().ToString())) : null;
                        MobileGoWirelessDetailRepositoryBase _oMobileGoWirelessDetailRepositoryBase = new MobileGoWirelessDetailRepositoryBase(SYSConn<MSSQLConnect>.Connect());
                        IQueryable<MobileGoWirelessDetailEntity> _oMobileGoWirelessDetailEntityList = from sMobileGoWirelessDetailList in _oMobileGoWirelessDetailRepositoryBase.MobileGoWirelessDetails
                                                                                                      where
                                                                                                      sMobileGoWirelessDetailList.mrt_no == _iMrt
                                                                                                      select sMobileGoWirelessDetailList;
                        if (_oMobileGoWirelessDetailEntityList.Count<MobileGoWirelessDetailEntity>() > 0)
                        {
                            bool _bRollBack = false;
                            foreach (MobileGoWirelessDetailEntity _oMobileGoWirelessDetail in _oMobileGoWirelessDetailEntityList)
                            {
                                _oMobileGoWirelessDetail.SetAssign(false);
                                _oMobileGoWirelessDetail.SetAssign_staff(null);
                                _oMobileGoWirelessDetail.SetAssign_date(null);
                                _oMobileGoWirelessDetail.SetOrder_id(null);
                                _oSession.Update(_oMobileGoWirelessDetail);
                                if (!_oSession.Update(_oMobileGoWirelessDetail))
                                {
                                    _bRollBack = true;
                                    break;
                                }
                            }
                            if (!_bRollBack)
                                _oTransaction.Commit();
                            else
                                _oTransaction.Rollback();
                        }
                    }

                    

                    

                    using (_oSession = _oSessionFactory.OpenSession())
                    using (ITransaction _oTransaction = _oSession.BeginTransaction())
                    {
                        MobileRetentionOrderRepositoryBase _oMobileRetentionOrderRepositoryBase = new MobileRetentionOrderRepositoryBase(SYSConn<MSSQLConnect>.Connect());
                        IQueryable<MobileRetentionOrderEntity> _oMobileRetentionOrderEntityList = from sMobileRetentionOrderList in _oMobileRetentionOrderRepositoryBase.MobileRetentionOrders
                                                                                                  where
                                                                                                  sMobileRetentionOrderList.order_id == (int?)this.m_iOrder_id
                                                                                                  select sMobileRetentionOrderList;

                        if (_oMobileRetentionOrderEntityList.Count<MobileRetentionOrderEntity>() > 0)
                        {
                            bool _bRollBack = false;
                            foreach (MobileRetentionOrderEntity _oMobileRetentionOrder in _oMobileRetentionOrderEntityList)
                            {
                                _oMobileRetentionOrder.SetPreferred_languages(null);
                                _oMobileRetentionOrder.SetRegister_address(null);
                                _oMobileRetentionOrder.SetSim_mrt_no(null);
                                _oMobileRetentionOrder.SetGo_wireless(null);
                                if (!_oSession.Update(_oMobileRetentionOrder))
                                {
                                    _bRollBack = true;
                                    break;
                                }
                            }
                            if (!_bRollBack)
                                _oTransaction.Commit();
                            else
                                _oTransaction.Rollback();
                        }
                    }
                }
                else
                {
                    int _iId;
                    string _sId = SYSConn<MSSQLConnect>.Connect().GetExecuteScalar("SELECT TOP 1  id  FROM " + Configurator.MSSQLTablePrefix + "MobileGoWirelessDetail  with (nolock)  WHERE (order_id is null or order_id='') AND active=1 AND (assign_date is null OR datediff(s,assign_date,getdate())>1800) ORDER BY id");
                    if (!string.IsNullOrEmpty(_sId) && int.TryParse(_sId, out _iId))
                    {
                        MobileGoWirelessDetail _oMobileGoWirelessDetail = MobileGoWirelessDetailRepository.CreateEntityInstanceObject();
                        _oMobileGoWirelessDetail.SetId(_iId);
                        if (!_oMobileGoWirelessDetail.Retrieve()) { return "NO MRT"; }
                        _oMobileGoWirelessDetail.SetAssign(true);
                        _oMobileGoWirelessDetail.SetAssign_staff(GetUid());
                        _oMobileGoWirelessDetail.SetAssign_date(DateTime.Now);
                        _oMobileGoWirelessDetail.Save();
                        if (_oMobileGoWirelessDetail.mrt_no != null)
                        {
                            if (!string.IsNullOrEmpty(_oMobileGoWirelessDetail.mrt_no.ToString()))
                                return _oMobileGoWirelessDetail.GetMrt_no().ToString();
                            else
                                return "NO MRT";
                        }
                        else
                            return "NO MRT";
                    }
                    else
                        return "NO MRT";
                }
            }
            return "NO MRT";
        }

        #region Constructor & Destructor
        public SimMrtControl() { }

        public SimMrtControl(string x_sDelete, string x_sMrt, string x_sUid, int x_iOrder_id)
        {
            m_sDelete = x_sDelete;
            m_sMrt = x_sMrt;
            m_sUid = x_sUid;
            m_iOrder_id = x_iOrder_id;
        }
        ~SimMrtControl() { }
        #endregion Constructor & Destructor

        #region Get & Set
        public string GetDelete() { return this.m_sDelete; }
        public string GetMrt() { return this.m_sMrt; }
        public string GetUid() { return this.m_sUid; }
        public int GetOrder_id() { return this.m_iOrder_id; }

        public bool SetDelete(string value)
        {
            this.m_sDelete = value;
            return true;
        }
        public bool SetMrt(string value)
        {
            this.m_sMrt = value;
            return true;
        }
        public bool SetUid(string value)
        {
            this.m_sUid = value;
            return true;
        }
        public bool SetOrder_id(int value)
        {
            this.m_iOrder_id = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(SimMrtControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.m_sDelete.Equals(x_oObj.m_sDelete)) { return false; }
            if (!this.m_sMrt.Equals(x_oObj.m_sMrt)) { return false; }
            if (!this.m_sUid.Equals(x_oObj.m_sUid)) { return false; }
            if (!this.m_iOrder_id.Equals(x_oObj.m_iOrder_id)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.m_sDelete = string.Empty;
            this.m_sMrt = string.Empty;
            this.m_sUid = string.Empty;
            this.m_iOrder_id = -1;
        }
        #endregion Release

        #region DeepClone
        public SimMrtControl DeepClone()
        {
            SimMrtControl SimMrtControl_Clone = new SimMrtControl();
            SimMrtControl_Clone.SetDelete(this.m_sDelete);
            SimMrtControl_Clone.SetMrt(this.m_sMrt);
            SimMrtControl_Clone.SetUid(this.m_sUid);
            SimMrtControl_Clone.SetOrder_id(this.m_iOrder_id);
            return SimMrtControl_Clone;
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
