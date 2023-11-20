using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///-- =============================================
///-- Author:		<Author,Ben Wong>
///-- Create date: <Create Date 2010-08-09 Mon>
///-- Description:	<Description,Class :SIMControlEntity, Data Entity>
///-- =============================================

namespace PCCW.RWL.CORE
{
    public class SIMControlEntity
    {
        protected string n_sSim_no = string.Empty;
        #region m_sSim_no - Sim_item_no
        protected virtual string m_sSim_no
        {
            get
            {
                return this.n_sSim_no;
            }
            set
            {
                this.n_sSim_no = value;
            }
        }
        #endregion m_sSim_no

        protected string n_sReserve = string.Empty;
        #region m_sReserve - Sim_item_code
        protected virtual string m_sReserve
        {
            get
            {
                return this.n_sReserve;
            }
            set
            {
                this.n_sReserve = value;
            }
        }
        #endregion m_sReserve

        protected string n_sReferenceno = string.Empty;
        #region m_sReferenceno - Sim_item_number
        protected virtual string m_sReferenceno
        {
            get
            {
                return this.n_sReferenceno;
            }
            set
            {
                this.n_sReferenceno = value;
            }
        }
        #endregion m_sReferenceno

        protected string n_sDummy1 = string.Empty;
        #region m_sDummy1 ~ dummy2
        protected virtual string m_sDummy1
        {
            get
            {
                return this.n_sDummy1;
            }
            set
            {
                this.n_sDummy1 = value;
            }
        }
        #endregion m_sDummy1


        protected string n_sAssign_date = string.Empty;
        #region m_sAssign_date - Completed_date
        protected virtual string m_sAssign_date
        {
            get
            {
                return this.n_sAssign_date;
            }
            set
            {
                this.n_sAssign_date = value;
            }
        }
        #endregion m_sAssign_date



    }
}
