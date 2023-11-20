using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-07-03>
///-- Description:	<ConfiguratorAttributeEntity Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                        	 This class is a web application configuration class. 
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK
{
    public class ConfiguratorAttributeEntity
    {
        protected string n_sTablePrefix = string.Empty;
        #region TablePrefix
        public virtual string TablePrefix
        {
            get
            {
                return this.n_sTablePrefix;
            }
            set
            {
                this.n_sTablePrefix = value;
            }
        }
        #endregion TablePrefix
    }
}

