using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK
{
    public class BasicConfiguratorManager
    {
        public ConfigEntity BasicConfigurator = ConfigEntity.Instance();
        #region Instance
        private static BasicConfiguratorManager instance;
        #endregion

        #region ConfigEntity & Destructor
        protected BasicConfiguratorManager() { }
        public static BasicConfiguratorManager Instance()
        {
            if (instance == null)
                instance = new BasicConfiguratorManager();
            return instance;
        }
        #endregion Constructor & Destructor
    }
}
