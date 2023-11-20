using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :IMEISoldAwaitControlEntity, Data Entity>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class IMEISoldAwaitControlEntity
    {

        protected string n_sHs_model = string.Empty;
        #region m_sHs_model
        protected virtual string m_sHs_model
        {
            get
            {
                return this.n_sHs_model;
            }
            set
            {
                this.n_sHs_model = value;
            }
        }
        #endregion m_sHs_model


        protected string n_sToday1 = string.Empty;
        #region m_sToday1
        protected virtual string m_sToday1
        {
            get
            {
                return this.n_sToday1;
            }
            set
            {
                this.n_sToday1 = value;
            }
        }
        #endregion m_sToday1

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


        protected string n_sOrder_id = string.Empty;
        #region m_sOrder_id
        protected virtual string m_sOrder_id
        {
            get
            {
                return this.n_sOrder_id;
            }
            set
            {
                this.n_sOrder_id = value;
            }
        }
        #endregion m_sOrder_id


        protected string n_sStaff_no = string.Empty;
        #region m_sStaff_no
        protected virtual string m_sStaff_no
        {
            get
            {
                return this.n_sStaff_no;
            }
            set
            {
                this.n_sStaff_no = value;
            }
        }
        #endregion m_sStaff_no


        protected string n_sAment_Date = string.Empty;
        #region m_sAment_Date
        protected virtual string m_sAment_Date
        {
            get
            {
                return this.n_sAment_Date;
            }
            set
            {
                this.n_sAment_Date = value;
            }
        }
        #endregion m_sAment_Date


        protected string n_sImei_no = string.Empty;
        #region m_sImei_no
        protected virtual string m_sImei_no
        {
            get
            {
                return this.n_sImei_no;
            }
            set
            {
                this.n_sImei_no = value;
            }
        }
        #endregion m_sImei_no


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


        protected string n_sMrt_no = string.Empty;
        #region m_sMrt_no
        protected virtual string m_sMrt_no
        {
            get
            {
                return this.n_sMrt_no;
            }
            set
            {
                this.n_sMrt_no = value;
            }
        }
        #endregion

    }
}
