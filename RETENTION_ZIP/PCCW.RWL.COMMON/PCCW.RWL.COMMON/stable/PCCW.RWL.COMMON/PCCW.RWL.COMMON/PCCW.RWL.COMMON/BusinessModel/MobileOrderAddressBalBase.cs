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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderAddress],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderAddress] Business layer
    /// </summary>
    
    public abstract class MobileOrderAddressBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderAddressBalBase(){
        }
        ~MobileOrderAddressBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddress x_oMobileOrderAddress)
        {
            return GetDataSet(x_oMobileOrderAddress,null,MobileOrderAddressInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddress x_oMobileOrderAddress,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderAddress,x_oMergeDSet,MobileOrderAddressInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddress x_oMobileOrderAddress,MobileOrderAddressInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderAddress,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddress x_oMobileOrderAddress,global::System.Data.DataSet x_oMergeDSet,MobileOrderAddressInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderAddress,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderAddress x_oMobileOrderAddress,global::System.Data.DataSet x_oMergeDSet,MobileOrderAddressInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderAddressInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderAddress.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_street).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_street); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.address_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.address_id); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_region).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_region); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_floor).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_floor); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_build).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_build); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_room).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_room); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.address_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.address_type); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_type); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_district).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_district); }
            if (x_oTableSet.Fields(MobileOrderAddress.Para.d_blk).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddress.Para.TableName()].Columns.Add(MobileOrderAddress.Para.d_blk); }
            if (x_oMobileOrderAddress != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderAddress.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_street).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_street] = x_oMobileOrderAddress.GetD_street(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.address_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.address_id] = x_oMobileOrderAddress.GetAddress_id(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_region).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_region] = x_oMobileOrderAddress.GetD_region(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_floor).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_floor] = x_oMobileOrderAddress.GetD_floor(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_build).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_build] = x_oMobileOrderAddress.GetD_build(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_room).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_room] = x_oMobileOrderAddress.GetD_room(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.order_id] = x_oMobileOrderAddress.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.address_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.address_type] = x_oMobileOrderAddress.GetAddress_type(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_type] = x_oMobileOrderAddress.GetD_type(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_district).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_district] = x_oMobileOrderAddress.GetD_district(); }
                if (x_oTableSet.Fields(MobileOrderAddress.Para.d_blk).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddress.Para.d_blk] = x_oMobileOrderAddress.GetD_blk(); }
                _oDSet.Tables[MobileOrderAddress.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderAddressInfo x_oTableSet)
        {
            return MobileOrderAddressBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderAddressBal.ToEmptyDataSetProcess(MobileOrderAddressInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderAddressInfo x_oTableSet)
        {
            return MobileOrderAddressBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderAddress x_oMobileOrderAddress, MobileOrderAddressInfo x_oTableSet)
        {
            return MobileOrderAddressBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderAddress.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderAddress x_oMobileOrderAddress)
        {
            return MobileOrderAddressBal.GetDataSet(x_oMobileOrderAddress, null, MobileOrderAddressInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderAddress.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id,x_sAddress_type,MobileOrderAddressInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type, MobileOrderAddressInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iOrder_id,x_sAddress_type, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,MobileOrderAddressInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderAddressInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderAddress].[d_build] AS MOBILEORDERADDRESS_D_BUILD,[MobileOrderAddress].[d_street] AS MOBILEORDERADDRESS_D_STREET,[MobileOrderAddress].[d_district] AS MOBILEORDERADDRESS_D_DISTRICT,[MobileOrderAddress].[d_region] AS MOBILEORDERADDRESS_D_REGION,[MobileOrderAddress].[d_floor] AS MOBILEORDERADDRESS_D_FLOOR,[MobileOrderAddress].[d_room] AS MOBILEORDERADDRESS_D_ROOM,[MobileOrderAddress].[order_id] AS MOBILEORDERADDRESS_ORDER_ID,[MobileOrderAddress].[address_type] AS MOBILEORDERADDRESS_ADDRESS_TYPE,[MobileOrderAddress].[d_type] AS MOBILEORDERADDRESS_D_TYPE,[MobileOrderAddress].[address_id] AS MOBILEORDERADDRESS_ADDRESS_ID,[MobileOrderAddress].[d_blk] AS MOBILEORDERADDRESS_D_BLK  FROM  [MobileOrderAddress]  WHERE  [MobileOrderAddress].[order_id] = \'"+x_iOrder_id.ToString()+"\'  AND  [MobileOrderAddress].[address_type] = \'"+x_sAddress_type.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddress]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddress]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_build).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BUILD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_build).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_build).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_BUILD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_build).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_street).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_STREET"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_street).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_street).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_STREET"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_street).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_district).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_DISTRICT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_district).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_district).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_DISTRICT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_district).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_region).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_REGION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_region).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_region).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_REGION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_region).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_floor).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_FLOOR"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_floor).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_floor).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_FLOOR"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_floor).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_room).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_ROOM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_room).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_room).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_ROOM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_room).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESS_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.address_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.address_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.address_type).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_ADDRESS_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.address_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_type).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.address_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_ADDRESS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.address_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.address_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESS_ADDRESS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.address_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddress.Para.d_blk).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESS_D_BLK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddress.Para.d_blk).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_blk).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESS_D_BLK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddress.Para.d_blk).AliasName].ToString()] =string.Empty;
                        }
                    }
                    _oData.Close();
                    _oData.Dispose();
                }
                catch {  }
                finally
                {
                    _oConn.Close();
                    _oCmd.Dispose();
                    _oConn.Dispose();
                }
                return _oRw;
            }
        }
        #endregion
        
        
        #region SetDataSetRow
        
        
        // ******************************
        // *  Handler for Convert To DataSet Row
        // ******************************
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderAddress x_oMobileOrderAddressRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderAddress.Para.TableName(), x_oDataSet,x_oMobileOrderAddressRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderAddress x_oMobileOrderAddressRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderAddressRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderAddress x_oMobileOrderAddressRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderAddressInfo _oTableSet=MobileOrderAddressInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_street).AliasName))
                    x_oMobileOrderAddressRow.d_street = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_street).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.address_id).AliasName))
                    x_oMobileOrderAddressRow.address_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.address_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_region).AliasName))
                    x_oMobileOrderAddressRow.d_region = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_region).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_floor).AliasName))
                    x_oMobileOrderAddressRow.d_floor = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_floor).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_build).AliasName))
                    x_oMobileOrderAddressRow.d_build = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_build).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_room).AliasName))
                    x_oMobileOrderAddressRow.d_room = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_room).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.order_id).AliasName))
                    x_oMobileOrderAddressRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.address_type).AliasName))
                    x_oMobileOrderAddressRow.address_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.address_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_type).AliasName))
                    x_oMobileOrderAddressRow.d_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_district).AliasName))
                    x_oMobileOrderAddressRow.d_district = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_district).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddress.Para.d_blk).AliasName))
                    x_oMobileOrderAddressRow.d_blk = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddress.Para.d_blk).AliasName];
                return true;
            }
            return false;
        }
        
        #endregion SetByDataSet
        
        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return MobileOrderAddressRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderAddressEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderAddressRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderAddressEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderAddressRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderAddressRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderAddressRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderAddressRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sD_street,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            return MobileOrderAddressRepository.Insert(x_oDB, x_sD_street,x_sD_region,x_sD_floor,x_sD_build,x_sD_room,x_iOrder_id,x_sAddress_type,x_sD_type,x_sD_district,x_sD_blk);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderAddress x_oMobileOrderAddress)
        {
            return MobileOrderAddressRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderAddress);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sD_street,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            return MobileOrderAddressRepository.InsertReturnLastID_SP(x_oDB,x_sD_street,x_sD_region,x_sD_floor,x_sD_build,x_sD_room,x_iOrder_id,x_sAddress_type,x_sD_type,x_sD_district,x_sD_blk);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderAddress x_oMobileOrderAddress)
        {
            return MobileOrderAddressRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderAddress);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderAddressRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderAddressRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type)
        {
            return MobileOrderAddressRepository.Delete(x_oDB, x_iOrder_id,x_sAddress_type);
        }
        
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lAddress_id)
        {
            return MobileOrderAddressRepository.Delete(x_oDB, x_lAddress_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderAddress x_oMobileOrderAddressRow){
            String sFile = String.Empty;
        }
        
        #endregion
        
        #region Release
        
        // ******************************
        // *  Handler for Release Memory
        // ******************************
        
        public void Release(){}
        #endregion
    }
}


