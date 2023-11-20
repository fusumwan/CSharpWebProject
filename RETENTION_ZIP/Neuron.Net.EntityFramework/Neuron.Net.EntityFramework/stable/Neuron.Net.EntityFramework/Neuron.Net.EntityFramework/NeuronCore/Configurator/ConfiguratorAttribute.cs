using System;
using System.Collections.Generic;
using System.Data;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-07-03>
///-- Description:	<ConfiguratorAttribute Class!>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                        	 This class is a web application configuration class. 
///-- =============================================


namespace NEURON.ENTITY.FRAMEWORK
{
    public class ConfiguratorAttribute : ConfiguratorAttributeEntity, IConfigurator, IDisposable
    {
        public string MSSQLConnName { get; set; }
        public string ODBCConnName { get; set; }
        public string ORACLEConnName { get; set; }
        public string OLEDBConnName { get; set; }
        #region Instance
        private static ConfiguratorAttribute instance;
        #endregion
        #region Constructor & Destructor
        protected ConfiguratorAttribute() { }
        protected ConfiguratorAttribute(string x_sTablePrefix)
        {
            TablePrefix = x_sTablePrefix;
        }
        public static ConfiguratorAttribute Instance()
        {
            if (instance == null)
                instance = new ConfiguratorAttribute();
            return instance;
        }
        public static ConfiguratorAttribute Instance(string x_sTablePrefix)
        {
            if (instance == null)
                instance = new ConfiguratorAttribute(x_sTablePrefix);
            return instance;
        }
        ~ConfiguratorAttribute() { }
        #endregion Constructor & Destructor
        #region Get & Set
        public string GetTablePrefix() { return this.TablePrefix; }
        public bool SetTablePrefix(string value)
        {
            this.TablePrefix = value;
            return true;
        }
        #endregion
        public string DBConnStr(string x_sDBName)
        {
            return string.Empty;
        }
        public string AddTablePrefix(Type x_sDBType, string x_sTableName)
        {
            return x_sTableName;
        }
        #region Equals
        public bool Equals(ConfiguratorAttribute x_sObj)
        {
            if (x_sObj == null) { return false; }
            if (!this.TablePrefix.Equals(x_sObj.TablePrefix)) { return false; }
            return true;
        }
        #endregion Equals
        #region Release
        public void Release()
        {
            this.TablePrefix = string.Empty;
        }
        #endregion Release
        #region Clone
        public ConfiguratorAttribute Clone()
        {
            ConfiguratorAttribute ConfiguratorAttribute_Clone = new ConfiguratorAttribute();
            ConfiguratorAttribute_Clone.SetTablePrefix(this.TablePrefix);
            return ConfiguratorAttribute_Clone;
        }
        #endregion Clone
        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}

