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
using System.Linq;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-10-21>
///-- Description:	<Description,Class :PublicHousingOfferSelectFilter, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{
    public class PublicHousingOfferSelectFilter : IDisposable
    {
        protected void Init()
        {
            this.PublicHousingOfferArr = PublicHousingOfferBal.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), null, null, null);
            if (this.PublicHousingOfferArr != null)
            {
                if (SelectFilter == null) SelectFilter = new Dictionary<string, List<string>>();
                for (int i = 0; i < this.PublicHousingOfferArr.Length; i++)
                {
                    if (!string.IsNullOrEmpty(PublicHousingOfferArr[i].GetProgram()) && !string.IsNullOrEmpty(PublicHousingOfferArr[i].GetS_premium2()))
                    {
                        if (SelectFilter.ContainsKey(PublicHousingOfferArr[i].GetProgram()))
                        {
                            List<string> _oS_premium2ValueList = SelectFilter[PublicHousingOfferArr[i].GetProgram()];
                            if (!_oS_premium2ValueList.Contains(PublicHousingOfferArr[i].GetS_premium2()))
                                _oS_premium2ValueList.Add(PublicHousingOfferArr[i].GetS_premium2());
                        }
                        else
                            SelectFilter.Add(PublicHousingOfferArr[i].GetProgram(), new List<string>() { PublicHousingOfferArr[i].GetS_premium2() });
                    }
                }
            }
        }

        public List<string> GetListValue()
        {
            List<string> _oListValue = new List<string>();
            PublicHousingOfferRepositoryBase _oPublicHousingOfferRepositoryBase = PublicHousingOfferRepositoryBase.Instance(SYSConn<MSSQLConnect>.Connect());
            IQueryable<PublicHousingOfferEntity> PublicHousingOfferList = from sPublicHousingOffer in _oPublicHousingOfferRepositoryBase.PublicHousingOffers
                                                                          where sPublicHousingOffer.s_premium2 != string.Empty && sPublicHousingOffer.s_premium2 != null && sPublicHousingOffer.program != string.Empty && sPublicHousingOffer.program != null 
                                                                          select sPublicHousingOffer;

            if (PublicHousingOfferList.Count<PublicHousingOfferEntity>() > 0) { _oListValue = PublicHousingOfferList.Select(c => c.s_premium2).Distinct().ToList(); }

            return _oListValue;
        }

        protected Dictionary<string, List<string>> n_oSelectFilter = null;
        #region SelectFilter
        public Dictionary<string, List<string>> SelectFilter
        {
            get
            {
                return this.n_oSelectFilter;
            }
            set
            {
                this.n_oSelectFilter = value;
            }
        }
        #endregion SelectFilter


        protected PublicHousingOfferEntity[] n_oPublicHousingOfferArr = null;
        #region PublicHousingOfferArr
        public PublicHousingOfferEntity[] PublicHousingOfferArr
        {
            get
            {
                return this.n_oPublicHousingOfferArr;
            }
            set
            {
                this.n_oPublicHousingOfferArr = value;
            }
        }
        #endregion PublicHousingOfferArr


        #region Instance
        private static PublicHousingOfferSelectFilter instance;
        #endregion


        #region Constructor & Destructor
        protected PublicHousingOfferSelectFilter() {
            this.Init();
        }

        protected PublicHousingOfferSelectFilter(Dictionary<string, List<string>> x_oSelectFilter, PublicHousingOfferEntity[] x_oPublicHousingOfferArr)
        {
            SelectFilter = x_oSelectFilter;
            PublicHousingOfferArr = x_oPublicHousingOfferArr;
        }

        public static PublicHousingOfferSelectFilter Instance()
        {
            if (instance == null)
                instance = new PublicHousingOfferSelectFilter();
            return instance;
        }

        public static PublicHousingOfferSelectFilter Instance(Dictionary<string, List<string>> x_oSelectFilter, PublicHousingOfferEntity[] x_oPublicHousingOfferArr)
        {
            if (instance == null)
                instance = new PublicHousingOfferSelectFilter(x_oSelectFilter, x_oPublicHousingOfferArr);
            return instance;
        }

        ~PublicHousingOfferSelectFilter() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public Dictionary<string, List<string>> GetSelectFilter() { return this.SelectFilter; }
        public PublicHousingOfferEntity[] GetPublicHousingOfferArr() { return this.PublicHousingOfferArr; }

        public bool SetSelectFilter(Dictionary<string, List<string>> value)
        {
            this.SelectFilter = value;
            return true;
        }
        public bool SetPublicHousingOfferArr(PublicHousingOfferEntity[] value)
        {
            this.PublicHousingOfferArr = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(PublicHousingOfferSelectFilter x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.SelectFilter.Equals(x_oObj.SelectFilter)) { return false; }
            if (!this.PublicHousingOfferArr.Equals(x_oObj.PublicHousingOfferArr)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.SelectFilter = null;
            this.PublicHousingOfferArr = null;
        }
        #endregion Release


        #region Clone
        public PublicHousingOfferSelectFilter DeepClone()
        {
            PublicHousingOfferSelectFilter PublicHousingOfferSelectFilter_Clone = new PublicHousingOfferSelectFilter();
            PublicHousingOfferSelectFilter_Clone.SetSelectFilter(this.SelectFilter);
            PublicHousingOfferSelectFilter_Clone.SetPublicHousingOfferArr(this.PublicHousingOfferArr);
            return PublicHousingOfferSelectFilter_Clone;
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
