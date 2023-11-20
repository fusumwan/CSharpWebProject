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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-02-22>
///-- Description:	<Description,Table :[ProductItemCode],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    /// <summary>
    /// Summary description for table [ProductItemCode] Business layer
    /// </summary>
    
    
    public class ProductItemCodeBals:Collection<ProductItemCode>{}
    public class ProductItemCodeBal: ProductItemCodeBalBase{

        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public ProductItemCodeBal() : base(){
        }
        ~ProductItemCodeBal(){
            base.Release();
        }
        #endregion

        #region Hsmodel ListBox
        public static Hashtable ListBoxHsmodel()
        {
            Hashtable _oHsmodelList = new Hashtable();
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT item_code,hs_model FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode WITH (nolock) WHERE active=1 AND item_code<>'' ORDER BY hs_model");
            while (_oReader.Read())
            {
                if (!_oHsmodelList.ContainsKey(_oReader[ProductItemCode.Para.item_code].ToString()))
                    _oHsmodelList.Add(_oReader[ProductItemCode.Para.item_code].ToString(), _oReader[ProductItemCode.Para.hs_model].ToString());
            }
            if(_oReader!=null) _oReader.Close();
            return _oHsmodelList;
        }

        public static ObjectArr ListBoxHsmodelNoSort()
        {
            ObjectArr _oHsmodelList = new ObjectArr();
            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch("SELECT item_code,hs_model FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode WITH (nolock) WHERE active=1 AND item_code<>'' ORDER BY hs_model");
            while (_oReader.Read())
            {
                if (!_oHsmodelList.ContainsKey(_oReader[ProductItemCode.Para.hs_model].ToString()))
                    _oHsmodelList.Add(_oReader[ProductItemCode.Para.hs_model].ToString(), _oReader[ProductItemCode.Para.item_code].ToString());
            }
            if (_oReader != null)
            {
                _oReader.Close();
                _oReader.Dispose();
            }
            return _oHsmodelList;
        }
        #endregion


        #region Hsmodel
        public static global::System.Collections.Generic.List<string> DrpHsmodelList(string x_sType,string x_sItem_code)
        {
            global::System.Collections.Generic.List<string> _oHsmodelList = new global::System.Collections.Generic.List<string>();
            global::System.Text.StringBuilder _sQuery = new global::System.Text.StringBuilder();
            _sQuery.Append("SELECT DISTINCT hs_model FROM " + Configurator.MSSQLTablePrefix + "ProductItemCode WITH (NOLOCK) WHERE ACTIVE=1 AND hs_model<>''");
            if (!string.IsNullOrEmpty(x_sType)) { _sQuery.Append(" AND type='" + x_sType + "'"); }
            if (!string.IsNullOrEmpty(x_sItem_code)) { _sQuery.Append(" AND  item_code='" + x_sItem_code.Trim() + "'"); }

            global::System.Data.SqlClient.SqlDataReader _oReader = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery.ToString());
            while (_oReader.Read())
            {
                _oHsmodelList.Add(_oReader[ProductItemCode.Para.hs_model].ToString());
            }
            if (_oReader != null)
            {
                _oReader.Close();
                _oReader.Dispose();
            }
            return _oHsmodelList;
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

    }
}


