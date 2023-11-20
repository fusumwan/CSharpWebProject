using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace NEURON.ENTITY.FRAMEWORK
{
    public class DSHelper : IDSHelper, IDisposable
    {
        DataSet n_oDSet = null;
        public DataSet DSet
        {
            get
            {
                return n_oDSet;
            }
        }

        public void AddTable(string x_sTableName)
        {
            if (!CheckBuildDs())
                throw new Exception("Error to init DataSet!");
            if (!this.DSet.Tables.Contains(x_sTableName))
            {
                DataTable _oDataTable = new DataTable(x_sTableName);
                this.DSet.Tables.Add(_oDataTable);
            }
        }

        public DataTable SearchDSTable(string x_sTableName)
        {
            if (!CheckBuildDs())
                throw new Exception("Error to init DataSet!");
            return SearchDSTable(x_sTableName, false);
        }

        public DataTable SearchDSTable(string x_sTableName, bool x_bMustFind)
        {
            if (!CheckBuildDs())
                throw new Exception("Error to init DataSet!");
            if (this.n_oDSet == null) { this.n_oDSet = new DataSet(); }
            if (this.DSet.Tables.Contains(x_sTableName))
                return this.DSet.Tables[x_sTableName];
            if (x_bMustFind)
                AddTable(x_sTableName);

            return null;
        }

        protected bool CheckBuildDs()
        {
            if (this.n_oDSet == null) { this.n_oDSet = new DataSet(); }
            return true;
        }

        void global::System.IDisposable.Dispose() { }
        public void Dispose() { }

    }
}
