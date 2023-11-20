using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-Mon>
///-- Description:	<Description,Class :SimMrtControlEntity, Data Entity>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class SimMrtControlEntity
    {

        protected string n_sDelete = string.Empty;
        #region m_sDelete
        protected virtual string m_sDelete
        {
            get
            {
                return this.n_sDelete;
            }
            set
            {
                this.n_sDelete = value;
            }
        }
        #endregion m_sDelete


        protected string n_sMrt = string.Empty;
        #region m_sMrt
        protected virtual string m_sMrt
        {
            get
            {
                return this.n_sMrt;
            }
            set
            {
                this.n_sMrt = value;
            }
        }
        #endregion m_sMrt


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


        protected int n_iOrder_id = -1;
        #region m_iOrder_id
        protected virtual int m_iOrder_id
        {
            get
            {
                return this.n_iOrder_id;
            }
            set
            {
                this.n_iOrder_id = value;
            }
        }
        #endregion m_iOrder_id

    }
}
