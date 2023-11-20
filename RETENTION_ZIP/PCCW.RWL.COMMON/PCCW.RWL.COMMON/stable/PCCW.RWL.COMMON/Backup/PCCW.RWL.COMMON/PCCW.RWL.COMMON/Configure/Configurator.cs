using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;

using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
/// <summary>
/// Summary description for Configurator
/// </summary>
namespace PCCW.RWL.CORE
{
    public class Configurator : ConfiguratorAttributeEntity, IConfigurator, IDisposable
    {
        public const string MSSQLTablePrefix = "";
        public const string ODBCTablePrefix = "";
        public const string ORACLETablePrefix = "";
        public const string OLEDBTablePrefix = "";


        public string MSSQLConnName { get; set; }
        public string ODBCConnName { get; set; }
        public string ORACLEConnName { get; set; }
        public string OLEDBConnName { get; set; }
        public  class DBName
        {
            public const string CSSDB = "CSSDB";
            public const string CSSSQLDB = "CSSSQLDB";
            public const string CRM = "CRM";
            public const string ORADNS = "ORADNS";
            public const string MobileRetentionOrderDB = "MobileRetentionOrderDB";
            public const string MobileOneDB = "MobileOneDB";
            public const string Common = "Common";
        }

        #region Instance
        private static Configurator instance;
        #endregion


        #region Constructor & Destructor
        protected Configurator() {
            MSSQLConnName = string.Empty;
            ODBCConnName = string.Empty;
            ORACLEConnName = string.Empty;
            OLEDBConnName = string.Empty;
        }

        public static Configurator Instance()
        {
            if (instance == null)
                instance = new Configurator();
            return instance;
        }


        ~Configurator() { }

        #endregion Constructor & Destructor

        #region Get & Set

        #endregion

        public static string GetTitle()
        {
            if (IsUat())
                return "3G Retention - Web Log.Net <span style=\"color:Red\">UAT</span>";
            else
                return "3G Retention - Web Log.Net";
        }

        public static bool IsUat()
        {
            try
            {
                if (System.Configuration.ConfigurationManager.AppSettings["UAT"].ToString().Trim().ToUpper().Equals("TRUE"))
                    return true;
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            return false;
        }


        public string DBConnStr(string x_sDBName)
        {

            string _sDBName = x_sDBName.Trim();
            string _sResult = DBName.CSSDB;
            switch (_sDBName)
            {
                case DBName.MobileRetentionOrderDB:
                    _sResult = DBName.MobileRetentionOrderDB + ((IsUat()) ? "2" : string.Empty);
                    break;
                case DBName.CSSDB:
                    _sResult = DBName.CSSDB + ((IsUat()) ? "2" : string.Empty); 
                    break;
                case DBName.CSSSQLDB:
                    _sResult = DBName.CSSSQLDB + ((IsUat()) ? "2" : string.Empty);
                    break;
                case DBName.CRM:
                    _sResult = DBName.CRM + ((IsUat()) ? "2" : string.Empty); 
                    break;
                case DBName.ORADNS:
                    _sResult = DBName.ORADNS + ((IsUat()) ? "2" : string.Empty); 
                    break;
                case DBName.MobileOneDB:
                    _sResult = DBName.MobileOneDB + ((IsUat()) ? "2" : string.Empty);
                    break;
                case DBName.Common:
                    _sResult = DBName.Common + ((IsUat()) ? "2" : string.Empty);
                    break;
                default:
                    _sResult = _sDBName;
                    break;
            }
            return _sResult;
        }

        public string AddTablePrefix(Type x_sDBType,string x_sTableName)
        {

            return x_sTableName;
        }

        #region Equals
        public bool Equals(Configurator x_oObj)
        {
            if (x_oObj == null) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {

        }
        #endregion Release


        #region DeepClone
        public Configurator DeepClone()
        {
            Configurator Configurator_Clone = new Configurator();

            return Configurator_Clone;
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