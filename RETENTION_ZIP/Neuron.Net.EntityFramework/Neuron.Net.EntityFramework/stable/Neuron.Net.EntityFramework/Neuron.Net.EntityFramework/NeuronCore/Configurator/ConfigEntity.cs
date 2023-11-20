using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-10>
///-- Description:	<Description,Class :ConfiguratorAttribute, Data Access Object Control>
///-- =============================================

namespace NEURON.ENTITY.FRAMEWORK
{
    public class ConfigEntity
    {
        IConfigurator n_oConfigurator = null;
        
        #region Instance
        private static ConfigEntity instance;
        #endregion


        #region ConfigEntity & Destructor
        protected ConfigEntity() { }

        public static ConfigEntity Instance()
        {
            if (instance == null)
                instance = new ConfigEntity();
            return instance;
        }

        public void Configure(IConfigurator x_oIConfigurator)
        {
            n_oConfigurator = x_oIConfigurator;
        }

        public IConfigurator GetConfigurator()
        {
            return n_oConfigurator;
        }

        

        #endregion Constructor & Destructor
    }
}
