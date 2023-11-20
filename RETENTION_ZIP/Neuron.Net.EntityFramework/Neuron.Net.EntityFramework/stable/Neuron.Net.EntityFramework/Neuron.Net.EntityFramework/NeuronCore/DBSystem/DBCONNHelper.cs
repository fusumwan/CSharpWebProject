using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Interface DBCONNHelper Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for relational object databases model class.
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK.CONNECT{
    public class DBConnHelper
    {

        public DBConnHelper()
        {
        }

        public static string DBTypeStr(string x_sDBName)
        {
            ConfigEntity _oConfigEntity = ConfigEntity.Instance();
            if (_oConfigEntity.GetConfigurator() != null)
            {
                return _oConfigEntity.GetConfigurator().DBConnStr(x_sDBName);
            }
            return x_sDBName;
        }

        public static string AddTablePrefix(Type x_sDBType,string x_sTableName)
        {

            ConfigEntity _oConfigEntity = ConfigEntity.Instance();
            if (_oConfigEntity.GetConfigurator() != null)
            {
                return _oConfigEntity.GetConfigurator().AddTablePrefix(x_sDBType, x_sTableName);
            }
            return x_sTableName;
        }
    }
}

