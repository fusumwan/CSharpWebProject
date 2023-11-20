using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :RwlReportSYSControlEntity, Data Entity>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class RwlReportSYSControlEntity
    {

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


        protected DateTime n_dNow = ((DateTime)SqlDateTime.Null);
        #region m_dNow
        protected virtual DateTime m_dNow
        {
            get
            {
                return this.n_dNow;
            }
            set
            {
                this.n_dNow = value;
            }
        }
        #endregion m_dNow


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

    }
}
