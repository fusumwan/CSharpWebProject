using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK{
    public abstract class EntityFramework
    {
        public BasicConfiguratorManager Config
        {
            get
            {
                return BasicConfiguratorManager.Instance();
            }
        }

        public EntityFramework()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        
        private static EntityFrameworkEnvironment _Environment;
        public static EntityFrameworkEnvironment Environment
        {
            get
            {
                if (EntityFramework._Environment == null)
                {
                    EntityFramework._Environment = new EntityFrameworkEnvironment();
                }
                return EntityFramework._Environment;
            }
        }
    }
}

