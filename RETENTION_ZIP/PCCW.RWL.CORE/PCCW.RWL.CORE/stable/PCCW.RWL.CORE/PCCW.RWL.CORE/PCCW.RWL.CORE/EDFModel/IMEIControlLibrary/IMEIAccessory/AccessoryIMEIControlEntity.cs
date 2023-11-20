using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :AccessoryIMEIControlEntity, Data Entity>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class AccessoryIMEIControlEntity
    {

        protected string n_sOrd_id = string.Empty;
        #region m_sOrd_id
        protected virtual string m_sOrd_id
        {
            get
            {
                return this.n_sOrd_id;
            }
            set
            {
                this.n_sOrd_id = value;
            }
        }
        #endregion m_sOrd_id


        protected string n_sUid = string.Empty;
        #region m_sUid
        protected virtual string m_sUid
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
        #endregion m_sUid


        protected string n_sToday = string.Empty;
        #region m_sToday
        protected virtual string m_sToday
        {
            get
            {
                return this.n_sToday;
            }
            set
            {
                this.n_sToday = value;
            }
        }
        #endregion m_sToday


        protected string n_sSku = string.Empty;
        #region m_sSku
        protected virtual string m_sSku
        {
            get
            {
                return this.n_sSku;
            }
            set
            {
                this.n_sSku = value;
            }
        }
        #endregion m_sSku


        protected string n_sEdf_no = string.Empty;
        #region m_sEdf_no
        protected virtual string m_sEdf_no
        {
            get
            {
                return this.n_sEdf_no;
            }
            set
            {
                this.n_sEdf_no = value;
            }
        }
        #endregion m_sEdf_no


        protected string n_sRef_no = string.Empty;
        #region m_sRef_no
        protected virtual string m_sRef_no
        {
            get
            {
                return this.n_sRef_no;
            }
            set
            {
                this.n_sRef_no = value;
            }
        }
        #endregion m_sRef_no


        protected string n_sIMEI = string.Empty;
        #region m_sIMEI
        protected virtual string m_sIMEI
        {
            get
            {
                return this.n_sIMEI;
            }
            set
            {
                this.n_sIMEI = value;
            }
        }
        #endregion m_sIMEI


        protected string n_sAccessory_price = string.Empty;
        #region m_sAccessory_price
        protected virtual string m_sAccessory_price
        {
            get
            {
                return this.n_sAccessory_price;
            }
            set
            {
                this.n_sAccessory_price = value;
            }
        }
        #endregion m_sAccessory_price


        protected string n_sGift_desc = string.Empty;
        #region m_sGift_desc
        protected virtual string m_sGift_desc
        {
            get
            {
                return this.n_sGift_desc;
            }
            set
            {
                this.n_sGift_desc = value;
            }
        }
        #endregion m_sGift_desc

    }
}
