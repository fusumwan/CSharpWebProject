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
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using log4net;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-11-30>
///-- Description:	<Description,Class :AccessRightControl, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class AccessRightControl : IDisposable
    {
        #region Logger Setup
        protected static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        protected bool IsLock = false;
        protected DateTime? StartLockTime = DateTime.Now;
        protected DateTime? EndLockTime = DateTime.Now.AddMinutes(5);

        protected DataSet n_oAccessRightDS = null;
        #region AccessRightDS
        public DataSet AccessRightDS
        {
            get
            {
                return this.n_oAccessRightDS;
            }
            set
            {
                this.n_oAccessRightDS = value;
            }
        }
        #endregion AccessRightDS

        #region Para
        public class Para
        {
            public const string AccessRightDS = "AccessRightDS";
        }
        #endregion Para

        #region Instance
        private static AccessRightControl instance;
        #endregion


        #region Constructor & Destructor
        protected AccessRightControl() { }

        protected AccessRightControl(DataSet x_oAccessRightDS)
        {
            AccessRightDS = x_oAccessRightDS;
        }

        public static AccessRightControl Instance()
        {
            if (instance == null)
                instance = new AccessRightControl();
            return instance;
        }

        public static AccessRightControl Instance(DataSet x_oAccessRightDS)
        {
            if (instance == null)
                instance = new AccessRightControl(x_oAccessRightDS);
            return instance;
        }

        ~AccessRightControl() { }

        #endregion Constructor & Destructor

        public bool PagePrivilegeCheck(CurrentUserSetting x_oCurrentUserSetting, string x_sAccess_Page)
        {
            if (x_oCurrentUserSetting == null) return false;
            if (this.AccessRightDS == null)
                PreLoadDataToMemory();
            if (this.AccessRightDS.Tables[0].Rows.Count == 0)
            {
                return true;
            }

            IDSQuery _oDR1 = IDSQuery.CreateDsCriteria(this.AccessRightDS, string.Empty)
                .Add(DsExpression.Eq("access_page", x_sAccess_Page))
                .Add(DsExpression.Eq("access_level", x_oCurrentUserSetting.Lv));
            if (_oDR1.Read())
            {
                _oDR1.Close();
                return true;
            }
            _oDR1.Close();

            IDSQuery _oDR2 = IDSQuery.CreateDsCriteria(this.AccessRightDS, string.Empty)
               .Add(DsExpression.Eq("access_page", x_sAccess_Page))
               .Add(DsExpression.Eq("access_level", "100"))
               .Add(DsExpression.Eq("sp_uid", x_oCurrentUserSetting.Uid));

            if (_oDR2.Read())
            {
                _oDR2.Close();
                return true;
            }
            _oDR2.Close();

            IDSQuery _oDR3 = IDSQuery.CreateDsCriteria(this.AccessRightDS, string.Empty)
               .Add(DsExpression.Eq("access_page", x_sAccess_Page))
               .Add(DsExpression.Eq("access_level", x_oCurrentUserSetting.Lv))
               .Add(DsExpression.Eq("sp_uid", x_oCurrentUserSetting.Uid));

            if (_oDR3.Read())
            {
                _oDR3.Close();
                return true;
            }
            _oDR3.Close();
            


            return false;
        }

        public void PreLoadDataToMemory()
        {
            PreLoadDataToMemory(false);
        }

        public void PreLoadDataToMemory(bool x_bMustReload)
        {
            if (this.IsLock == false)
            {
                this.IsLock = true;
                if (this.AccessRightDS == null || x_bMustReload)
                {
                    StringBuilder _oQuery = new StringBuilder();
                    _oQuery.Append("SELECT ");
                    _oQuery.Append("a.access_page access_page,");
                    _oQuery.Append("a.page_desc page_desc,");
                    _oQuery.Append("a.cid cid,");
                    _oQuery.Append("a.did did,");
                    _oQuery.Append("a.active page_active,");
                    _oQuery.Append("a.cdate cdate,");
                    _oQuery.Append("a.mdate mdate,");
                    _oQuery.Append("b.access_level access_level,");
                    _oQuery.Append("b.sp_uid sp_uid,");
                    _oQuery.Append("b.active level_active ");
                    _oQuery.Append("FROM AccessPage a right join AccessPageProfile b  with (nolock) ON a.id=b.access_page_id WHERE a.active=1 and b.active=1;");
                    this.AccessRightDS = SYSConn<MSSQLConnect>.Connect().GetDS(_oQuery.ToString());
                }
                this.IsLock = false;
            }
            else
            {
                if (this.StartLockTime == null || this.EndLockTime == null)
                {
                    this.StartLockTime = DateTime.Now;
                    this.EndLockTime = DateTime.Now.AddMinutes(5);
                }
                if (DateTime.Compare((DateTime)this.StartLockTime, (DateTime)this.EndLockTime) > 0)
                {
                    this.IsLock = false;
                    PreLoadDataToMemory(x_bMustReload);
                }
            }
        }

        #region Get & Set
        public DataSet GetAccessRightDS() { return this.AccessRightDS; }

        public bool SetAccessRightDS(DataSet value)
        {
            this.AccessRightDS = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(AccessRightControl x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.AccessRightDS.Equals(x_oObj.AccessRightDS)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.AccessRightDS = null;
        }
        #endregion Release


        #region Clone
        public AccessRightControl DeepClone()
        {
            AccessRightControl AccessRightControl_Clone = new AccessRightControl();
            AccessRightControl_Clone.SetAccessRightDS(this.AccessRightDS);
            return AccessRightControl_Clone;
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
}
