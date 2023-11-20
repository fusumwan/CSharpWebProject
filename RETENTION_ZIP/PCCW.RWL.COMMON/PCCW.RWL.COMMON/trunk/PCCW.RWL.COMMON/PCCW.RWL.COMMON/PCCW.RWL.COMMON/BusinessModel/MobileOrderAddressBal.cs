using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
///-- Create date: <Create Date 2010-10-08>
///-- Description:	<Description,Table :[MobileOrderAddress],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [MobileOrderAddress] Business layer
    /// </summary>
    
    
    public class MobileOrderAddressBals:Collection<MobileOrderAddress>{}
    public class MobileOrderAddressBal: MobileOrderAddressBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderAddressBal() : base(){
        }
        ~MobileOrderAddressBal(){
            base.Release();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.bWithNoLock = true;
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion

        public static string GetAddress(MobileOrderAddressEntity x_oMobileOrderAddress)
        {
            if (x_oMobileOrderAddress == null) return string.Empty;
            if (!x_oMobileOrderAddress.GetFound()) return string.Empty;
            string _sAddress =
                ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_type())) ? x_oMobileOrderAddress.GetD_type() + " " : string.Empty)
                + ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_room())) ? x_oMobileOrderAddress.GetD_room() + " " : string.Empty)
                + ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_floor())) ? x_oMobileOrderAddress.GetD_floor() + " FLOOR " : string.Empty)
                + ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_blk())) ? "BLOCK " + x_oMobileOrderAddress.GetD_blk() + " " : string.Empty)
                + ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_build())) ? x_oMobileOrderAddress.GetD_build() + " " : string.Empty)
                + ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_street())) ? x_oMobileOrderAddress.GetD_street() + " " : string.Empty)
                + ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_district())) ? x_oMobileOrderAddress.GetD_district() + " " : string.Empty)
                + ((!string.IsNullOrEmpty(x_oMobileOrderAddress.GetD_region())) ? MobileOrderAddressBal.GetRegionDesc(x_oMobileOrderAddress.GetD_region()) : string.Empty);

            return _sAddress;
        }

        public static string GetRegionDesc(string x_sRegion)
        {
            if (string.IsNullOrEmpty(x_sRegion)) return string.Empty;
            string _sResult = string.Empty;
            switch (x_sRegion)
            {
                case "0":
                    _sResult = "HK";
                    break;
                case "1":
                    _sResult = "KLN";
                    break;
                case "2":
                    _sResult = "NT";
                    break;
                case "3":
                    _sResult = "LT";
                    break;
            }
            return _sResult;
        }
    }
}


