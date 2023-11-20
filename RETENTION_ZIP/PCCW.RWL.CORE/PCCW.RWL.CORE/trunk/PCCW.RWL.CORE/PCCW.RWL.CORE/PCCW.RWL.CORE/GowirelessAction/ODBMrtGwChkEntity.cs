using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-05-Fri>
///-- Description:	<Description,Class :ODBMrtGwChkEntity, Data Entity>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class ODBMrtGwChkEntity
    {

        protected Hashtable n_oChkList = null;
        #region m_oChkList
        protected virtual Hashtable m_oChkList
        {
            get
            {
                return this.n_oChkList;
            }
            set
            {
                this.n_oChkList = value;
            }
        }
        #endregion m_oChkList


        protected string n_sOrg_mrt = string.Empty;
        #region m_sOrg_mrt
        protected virtual string m_sOrg_mrt
        {
            get
            {
                return this.n_sOrg_mrt;
            }
            set
            {
                this.n_sOrg_mrt = value;
            }
        }
        #endregion m_sOrg_mrt

    }
}
