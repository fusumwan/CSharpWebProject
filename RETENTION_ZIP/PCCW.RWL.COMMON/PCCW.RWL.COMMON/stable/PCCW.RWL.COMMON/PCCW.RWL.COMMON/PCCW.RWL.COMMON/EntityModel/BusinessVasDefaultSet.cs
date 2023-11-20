using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;


///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2010-06-04>
///-- Description:	<Description,Table :[BusinessVasDefaultSet],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE
{
    /// <summary>
    /// Summary description for table [BusinessVasDefaultSet] Object Base layer
    /// </summary>
    public class BusinessVasDefaultSets : Collection<BusinessVasDefaultSet> { }
    public class BusinessVasDefaultSet : BusinessVasDefaultSetEntity
    {

        #region BusinessVas
        protected BusinessVas n_oBusinessVas = null;
        [DataObjectField(true)]
        public virtual BusinessVas BusinessVas
        {
            get
            {

                if (n_oBusinessVas == null) { n_oBusinessVas = new BusinessVas(this.GetDB()); }
                return this.n_oBusinessVas;
            }
            set
            {
                this.n_oBusinessVas = value;
            }
        }
        #endregion BusinessVas

        #region BusinessVas_vas_name
        [DataObjectField(true)]
        public virtual string BusinessVas_vas_name
        {
            get
            {
                return this.BusinessVas.vas_name;
            }
            set
            {
                this.BusinessVas.vas_name = value;
            }
        }
        #endregion BusinessVas_vas_name

        #region BusinessVasDescription
        protected BusinessVasDescription n_oBusinessVasDescription = null;
        [DataObjectField(true)]
        public virtual BusinessVasDescription BusinessVasDescription
        {
            get
            {
                if (n_oBusinessVasDescription == null) { n_oBusinessVasDescription = new BusinessVasDescription(this.GetDB()); }
                return this.n_oBusinessVasDescription;
            }
            set
            {
                this.n_oBusinessVasDescription = value;
            }
        }
        #endregion BusinessVasDescription

        #region BusinessVasDescription_vas_desc
        [DataObjectField(true)]
        public virtual string BusinessVasDescription_vas_desc
        {
            get
            {
                return this.BusinessVasDescription.vas_desc;
            }
            set
            {
                this.BusinessVasDescription.vas_desc = value;
            }
        }
        #endregion BusinessVasDescription_vas_desc

        #region Constructor
        public BusinessVasDefaultSet()
            : base()
        {
        }
        public BusinessVasDefaultSet(MSSQLConnect x_oDB)
            : base(x_oDB)
        {
        }

        public BusinessVasDefaultSet(MSSQLConnect x_oDB, global::System.Nullable<int> x_iMid)
            : base(x_oDB, x_iMid)
        {
            
        }

        ~BusinessVasDefaultSet()
        {
            base.Release();

        }
        #endregion


    }
}


