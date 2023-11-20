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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[AutoSelectionProperty],Object Base layer>
///-- =============================================

namespace PCCW.RWL.CORE
{
    /// <summary>
    /// Summary description for table [AutoSelectionProperty] Object Base layer
    /// </summary>
    public class AutoSelectionPropertys : Collection<AutoSelectionProperty> { }
    public class AutoSelectionProperty : AutoSelectionPropertyEntity
    {

        #region Constructor

        public AutoSelectionProperty()
            : base()
        {
        }
        public AutoSelectionProperty(MSSQLConnect x_oDB)
            : base(x_oDB)
        {
        }

        public AutoSelectionProperty(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
            : base(x_oDB, x_iId)
        {
        }

        ~AutoSelectionProperty()
        {
            base.Release();
        }
        #endregion

        #region Get NormalRebate Selected Value

        [Obsolete]
        public static string Get_NormalRebateSelectedValue(Nullable<bool> x_bNormalRebate, string x_sRetenion_type)
        {
            return Get_NormalRebateSelectedValueProc(x_bNormalRebate, x_sRetenion_type);
        }


        protected static string Get_NormalRebateSelectedValueProc(Nullable<bool> x_bNormalRebate, string x_sRetenion_type)
        {
            if (x_bNormalRebate == null) return string.Empty;
            if (x_bNormalRebate == false && x_sRetenion_type == "0")
                return "N";
            else if (x_bNormalRebate == false && x_sRetenion_type == "2")
                return "L";
            else if (x_bNormalRebate == false && x_sRetenion_type == "3")
                return "S";
            else if (x_bNormalRebate == false && x_sRetenion_type == "4")
                return "T";
            else if (x_bNormalRebate == false && x_sRetenion_type == "5")
                return "O";
            else if (x_bNormalRebate == false && x_sRetenion_type == "6")
                return "M";
            else
                return "Y";
        }
        #endregion

        #region Set NormalRebate Retenion Type
        public static void Set_NormalRebate_Retenion_type(string x_sType, out bool x_bNormalRebate, out string x_sRetenion_type)
        {
            if ("N".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "0";
            }
            else if ("L".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "2";
            }
            else if ("S".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "3";
            }
            else if ("T".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "4";
            }
            else if ("O".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "5";
            }
            else if ("M".Equals(x_sType))
            {
                x_bNormalRebate = false;
                x_sRetenion_type = "6";
            }
            else
            {
                x_bNormalRebate = true;
                x_sRetenion_type = "1";
            }
        }
        #endregion
        
    }
}

