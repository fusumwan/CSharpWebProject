using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for TierViewItemDAO
    /// </summary>
    public class TierViewItemDAO
    {
        public TierViewItemDAO()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public IList<TierViewItem> FindSuccess()
        {
            return TierViewControl.Instance().GetSuccessIn();
        }

        public IList<TierViewItem> FindError()
        {

            return TierViewControl.Instance().GetErrRecord();
        }

        public IList<TierViewItem> FindDuplicate()
        {

            return TierViewControl.Instance().GetDupRecord();
        }
    }
}
