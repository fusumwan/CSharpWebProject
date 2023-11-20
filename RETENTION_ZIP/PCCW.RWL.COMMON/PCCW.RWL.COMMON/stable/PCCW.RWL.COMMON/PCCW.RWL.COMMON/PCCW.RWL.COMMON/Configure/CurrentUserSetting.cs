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
using System.Web;
using System.Web.UI;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-Wed>
///-- Description:	<Description,Class :CurrentUserSetting, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class CurrentUserSetting : IDisposable
    {

        protected string n_sUid = string.Empty;
        #region Uid
        public string Uid
        {
            get
            {
                return this.n_sUid;
            }
            set
            {
                this.n_sUid = value;
            }
        }
        #endregion Uid


        protected string n_sArprog = string.Empty;
        #region Arprog
        public string Arprog
        {
            get
            {
                return this.n_sArprog;
            }
            set
            {
                this.n_sArprog = value;
            }
        }
        #endregion Arprog


        protected string n_sChannel = string.Empty;
        #region Channel
        public string Channel
        {
            get
            {
                return this.n_sChannel;
            }
            set
            {
                this.n_sChannel = value;
            }
        }
        #endregion Channel


        protected string n_sLv = string.Empty;
        #region Lv
        public string Lv
        {
            get
            {
                return this.n_sLv;
            }
            set
            {
                this.n_sLv = value;
            }
        }
        #endregion Lv
        
        public CurrentUserSetting this[Page x_oPage]
        {
            get
            {
                string _sUid = string.Empty;
                if (x_oPage.Session["uid"] != null)
                {
                    _sUid = x_oPage.Session["uid"].ToString();
                    x_oPage.Session["uid"] = _sUid;
                }
                string _sLv = string.Empty;
                if (x_oPage.Session["lv"] != null)
                {
                    _sLv = x_oPage.Session["lv"].ToString();
                    x_oPage.Session["lv"] = _sLv;
                }
                string _sArprog = string.Empty;
                if (x_oPage.Session["arprog"] != null)
                {
                    _sArprog = x_oPage.Session["arprog"].ToString();
                    x_oPage.Session["arprog"] = _sArprog;
                }
                string _sChannel = string.Empty;
                if (x_oPage.Session["channel"] != null)
                {
                    _sChannel = x_oPage.Session["channel"].ToString();
                    x_oPage.Session["channel"] = _sChannel;
                }
                return new CurrentUserSetting(_sUid, _sArprog, _sChannel, _sLv);
            }
        }

        #region Instance
        private static CurrentUserSetting instance;
        #endregion

        #region Constructor & Destructor
        public CurrentUserSetting()
        {
            string _sUid = string.Empty;

            if (HttpContext.Current.Session["uid"] != null)
            {
                _sUid = HttpContext.Current.Session["uid"].ToString();
                HttpContext.Current.Session["uid"] = _sUid;
            }
            string _sLv = string.Empty;
            if (HttpContext.Current.Session["lv"] != null)
            {
                _sLv = HttpContext.Current.Session["lv"].ToString();
                HttpContext.Current.Session["lv"] = _sLv;
            }
            string _sArprog = string.Empty;
            if (HttpContext.Current.Session["arprog"] != null)
            {
                _sArprog = HttpContext.Current.Session["arprog"].ToString();
                HttpContext.Current.Session["arprog"] = _sArprog;
            }
            string _sChannel = string.Empty;
            if (HttpContext.Current.Session["channel"] != null)
            {
                _sChannel = HttpContext.Current.Session["channel"].ToString();
                HttpContext.Current.Session["channel"] = _sChannel;
            }

        }

        protected CurrentUserSetting(string x_sUid, string x_sArprog, string x_sChannel, string x_sLv)
        {
            Uid = x_sUid;
            Arprog = x_sArprog;
            Channel = x_sChannel;
            Lv = x_sLv;
        }

        public static CurrentUserSetting Instance()
        {
            if (instance == null)
                instance = new CurrentUserSetting();
            return instance;
        }

        public static CurrentUserSetting Instance(string x_sUid, string x_sArprog, string x_sChannel, string x_sLv)
        {
            if (instance == null)
                instance = new CurrentUserSetting(x_sUid, x_sArprog, x_sChannel, x_sLv);
            return instance;
        }

        ~CurrentUserSetting() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetUid() { return this.Uid; }
        public string GetArprog() { return this.Arprog; }
        public string GetChannel() { return this.Channel; }
        public string GetLv() { return this.Lv; }

        public bool SetUid(string value)
        {
            this.Uid = value;
            return true;
        }
        public bool SetArprog(string value)
        {
            this.Arprog = value;
            return true;
        }
        public bool SetChannel(string value)
        {
            this.Channel = value;
            return true;
        }
        public bool SetLv(string value)
        {
            this.Lv = value;
            return true;
        }
        #endregion

        #region Equals
        public bool Equals(CurrentUserSetting x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Uid.Equals(x_oObj.Uid)) { return false; }
            if (!this.Arprog.Equals(x_oObj.Arprog)) { return false; }
            if (!this.Channel.Equals(x_oObj.Channel)) { return false; }
            if (!this.Lv.Equals(x_oObj.Lv)) { return false; }
            return true;
        }
        #endregion Equals

        #region Release
        public void Release()
        {
            this.Uid = string.Empty;
            this.Arprog = string.Empty;
            this.Channel = string.Empty;
            this.Lv = string.Empty;
        }
        #endregion Release

        #region DeepClone
        public CurrentUserSetting DeepClone()
        {
            CurrentUserSetting CurrentUserSetting_Clone = new CurrentUserSetting();
            CurrentUserSetting_Clone.SetUid(this.Uid);
            CurrentUserSetting_Clone.SetArprog(this.Arprog);
            CurrentUserSetting_Clone.SetChannel(this.Channel);
            CurrentUserSetting_Clone.SetLv(this.Lv);
            return CurrentUserSetting_Clone;
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
