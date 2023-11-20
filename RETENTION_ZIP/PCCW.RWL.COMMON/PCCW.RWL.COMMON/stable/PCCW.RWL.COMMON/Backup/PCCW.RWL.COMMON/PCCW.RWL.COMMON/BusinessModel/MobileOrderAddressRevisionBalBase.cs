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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderAddressRevision],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderAddressRevision] Business layer
    /// </summary>
    
    public abstract class MobileOrderAddressRevisionBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderAddressRevisionBalBase(){
        }
        ~MobileOrderAddressRevisionBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            return GetDataSet(x_oMobileOrderAddressRevision,null,MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddressRevision x_oMobileOrderAddressRevision,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderAddressRevision,x_oMergeDSet,MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddressRevision x_oMobileOrderAddressRevision,MobileOrderAddressRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderAddressRevision,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderAddressRevision x_oMobileOrderAddressRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderAddressRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderAddressRevision,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderAddressRevision x_oMobileOrderAddressRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderAddressRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderAddressRevision.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_street); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.address_id); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_region); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_floor); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_build); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_room); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.address_type); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_type); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_district); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Columns.Add(MobileOrderAddressRevision.Para.d_blk); }
            if (x_oMobileOrderAddressRevision != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_street] = x_oMobileOrderAddressRevision.GetD_street(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.address_id] = x_oMobileOrderAddressRevision.GetAddress_id(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_region] = x_oMobileOrderAddressRevision.GetD_region(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_floor] = x_oMobileOrderAddressRevision.GetD_floor(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_build] = x_oMobileOrderAddressRevision.GetD_build(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_room] = x_oMobileOrderAddressRevision.GetD_room(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.order_id] = x_oMobileOrderAddressRevision.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.address_type] = x_oMobileOrderAddressRevision.GetAddress_type(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_type] = x_oMobileOrderAddressRevision.GetD_type(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_district] = x_oMobileOrderAddressRevision.GetD_district(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.mid] = x_oMobileOrderAddressRevision.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderAddressRevision.Para.d_blk] = x_oMobileOrderAddressRevision.GetD_blk(); }
                _oDSet.Tables[MobileOrderAddressRevision.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderAddressRevisionInfo x_oTableSet)
        {
            return MobileOrderAddressRevisionBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderAddressRevisionBal.ToEmptyDataSetProcess(MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderAddressRevisionInfo x_oTableSet)
        {
            return MobileOrderAddressRevisionBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderAddressRevision x_oMobileOrderAddressRevision, MobileOrderAddressRevisionInfo x_oTableSet)
        {
            return MobileOrderAddressRevisionBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderAddressRevision.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            return MobileOrderAddressRevisionBal.GetDataSet(x_oMobileOrderAddressRevision, null, MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderAddressRevision.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return Row(x_oTable, x_oDB,x_lMid,MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid, MobileOrderAddressRevisionInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid,MobileOrderAddressRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderAddressRevision].[d_build] AS MOBILEORDERADDRESSREVISION_D_BUILD,[MobileOrderAddressRevision].[d_street] AS MOBILEORDERADDRESSREVISION_D_STREET,[MobileOrderAddressRevision].[d_district] AS MOBILEORDERADDRESSREVISION_D_DISTRICT,[MobileOrderAddressRevision].[d_region] AS MOBILEORDERADDRESSREVISION_D_REGION,[MobileOrderAddressRevision].[d_floor] AS MOBILEORDERADDRESSREVISION_D_FLOOR,[MobileOrderAddressRevision].[d_room] AS MOBILEORDERADDRESSREVISION_D_ROOM,[MobileOrderAddressRevision].[order_id] AS MOBILEORDERADDRESSREVISION_ORDER_ID,[MobileOrderAddressRevision].[address_type] AS MOBILEORDERADDRESSREVISION_ADDRESS_TYPE,[MobileOrderAddressRevision].[d_type] AS MOBILEORDERADDRESSREVISION_D_TYPE,[MobileOrderAddressRevision].[address_id] AS MOBILEORDERADDRESSREVISION_ADDRESS_ID,[MobileOrderAddressRevision].[mid] AS MOBILEORDERADDRESSREVISION_MID,[MobileOrderAddressRevision].[d_blk] AS MOBILEORDERADDRESSREVISION_D_BLK  FROM  [MobileOrderAddressRevision]  WHERE  [MobileOrderAddressRevision].[mid] = \'"+x_lMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderAddressRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderAddressRevision]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_BUILD"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_BUILD"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_STREET"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_STREET"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_DISTRICT"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_DISTRICT"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_REGION"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_REGION"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_FLOOR"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_FLOOR"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_ROOM"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_ROOM"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERADDRESSREVISION_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ADDRESS_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_ADDRESS_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_ADDRESS_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESSREVISION_ADDRESS_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERADDRESSREVISION_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERADDRESSREVISION_D_BLK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).AliasName].ToString()] = (string)_oData["MOBILEORDERADDRESSREVISION_D_BLK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderAddressRevision x_oMobileOrderAddressRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderAddressRevision.Para.TableName(), x_oDataSet,x_oMobileOrderAddressRevisionRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderAddressRevision x_oMobileOrderAddressRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderAddressRevisionRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderAddressRevision x_oMobileOrderAddressRevisionRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderAddressRevisionInfo _oTableSet=MobileOrderAddressRevisionInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_street = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_street).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).AliasName))
                    x_oMobileOrderAddressRevisionRow.address_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.address_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_region = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_region).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_floor = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_floor).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_build = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_build).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_room = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_room).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).AliasName))
                    x_oMobileOrderAddressRevisionRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).AliasName))
                    x_oMobileOrderAddressRevisionRow.address_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.address_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_district = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_district).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).AliasName))
                    x_oMobileOrderAddressRevisionRow.mid = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).AliasName))
                    x_oMobileOrderAddressRevisionRow.d_blk = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderAddressRevision.Para.d_blk).AliasName];
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
            return MobileOrderAddressRevisionRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderAddressRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderAddressRevisionRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderAddressRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderAddressRevisionRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderAddressRevisionRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderAddressRevisionRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderAddressRevisionRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sD_street,global::System.Nullable<long> x_lAddress_id,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            return MobileOrderAddressRevisionRepository.Insert(x_oDB, x_sD_street,x_lAddress_id,x_sD_region,x_sD_floor,x_sD_build,x_sD_room,x_iOrder_id,x_sAddress_type,x_sD_type,x_sD_district,x_sD_blk);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            return MobileOrderAddressRevisionRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderAddressRevision);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sD_street,global::System.Nullable<long> x_lAddress_id,string x_sD_region,string x_sD_floor,string x_sD_build,string x_sD_room,global::System.Nullable<int> x_iOrder_id,string x_sAddress_type,string x_sD_type,string x_sD_district,string x_sD_blk)
        {
            return MobileOrderAddressRevisionRepository.InsertReturnLastID_SP(x_oDB,x_sD_street,x_lAddress_id,x_sD_region,x_sD_floor,x_sD_build,x_sD_room,x_iOrder_id,x_sAddress_type,x_sD_type,x_sD_district,x_sD_blk);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderAddressRevision x_oMobileOrderAddressRevision)
        {
            return MobileOrderAddressRevisionRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderAddressRevision);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderAddressRevisionRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderAddressRevisionRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return MobileOrderAddressRevisionRepository.Delete(x_oDB, x_lMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderAddressRevision x_oMobileOrderAddressRevisionRow){
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


