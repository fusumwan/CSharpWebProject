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
///-- Create date: <Create Date 2011-07-13>
///-- Description:	<Description,Table :[HandSetOfferType],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [HandSetOfferType] Business layer
    /// </summary>
    
    public abstract class HandSetOfferTypeBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public HandSetOfferTypeBalBase(){
        }
        ~HandSetOfferTypeBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferType x_oHandSetOfferType)
        {
            return GetDataSet(x_oHandSetOfferType,null,HandSetOfferTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferType x_oHandSetOfferType,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oHandSetOfferType,x_oMergeDSet,HandSetOfferTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferType x_oHandSetOfferType,HandSetOfferTypeInfo x_oTableSet)
        {
            return GetDataSet(x_oHandSetOfferType,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(HandSetOfferType x_oHandSetOfferType,global::System.Data.DataSet x_oMergeDSet,HandSetOfferTypeInfo x_oTableSet)
        {
            return GetDataSet(x_oHandSetOfferType,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(HandSetOfferType x_oHandSetOfferType,global::System.Data.DataSet x_oMergeDSet,HandSetOfferTypeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = HandSetOfferTypeInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(HandSetOfferType.Para.TableName());
            if (x_oTableSet.Fields(HandSetOfferType.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.id); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.cdate); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.cid); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.did); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.expiry_chk); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.active); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.name); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.edate); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.ddate); }
            if (x_oTableSet.Fields(HandSetOfferType.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[HandSetOfferType.Para.TableName()].Columns.Add(HandSetOfferType.Para.sdate); }
            if (x_oHandSetOfferType != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[HandSetOfferType.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(HandSetOfferType.Para.id).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.id] = x_oHandSetOfferType.GetId(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.cdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.cdate] = x_oHandSetOfferType.GetCdate(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.cid).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.cid] = x_oHandSetOfferType.GetCid(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.did).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.did] = x_oHandSetOfferType.GetDid(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.expiry_chk] = x_oHandSetOfferType.GetExpiry_chk(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.active).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.active] = x_oHandSetOfferType.GetActive(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.name).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.name] = x_oHandSetOfferType.GetName(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.edate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.edate] = x_oHandSetOfferType.GetEdate(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.ddate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.ddate] = x_oHandSetOfferType.GetDdate(); }
                if (x_oTableSet.Fields(HandSetOfferType.Para.sdate).IsView || x_oTableSet.GetViewAll()) { _oDRow[HandSetOfferType.Para.sdate] = x_oHandSetOfferType.GetSdate(); }
                _oDSet.Tables[HandSetOfferType.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(HandSetOfferTypeInfo x_oTableSet)
        {
            return HandSetOfferTypeBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return HandSetOfferTypeBal.ToEmptyDataSetProcess(HandSetOfferTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(HandSetOfferTypeInfo x_oTableSet)
        {
            return HandSetOfferTypeBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(HandSetOfferType x_oHandSetOfferType, HandSetOfferTypeInfo x_oTableSet)
        {
            return HandSetOfferTypeBal.GetDataSet(null, null, x_oTableSet).Tables[HandSetOfferType.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(HandSetOfferType x_oHandSetOfferType)
        {
            return HandSetOfferTypeBal.GetDataSet(x_oHandSetOfferType, null, HandSetOfferTypeInfoDLL.CreateInfoInstanceObject()).Tables[HandSetOfferType.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return Row(x_oTable, x_oDB,x_iId,HandSetOfferTypeInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId, HandSetOfferTypeInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_iId, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<int> x_iId,HandSetOfferTypeInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = HandSetOfferTypeInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [HandSetOfferType].[id] AS HANDSETOFFERTYPE_ID,[HandSetOfferType].[cdate] AS HANDSETOFFERTYPE_CDATE,[HandSetOfferType].[cid] AS HANDSETOFFERTYPE_CID,[HandSetOfferType].[did] AS HANDSETOFFERTYPE_DID,[HandSetOfferType].[expiry_chk] AS HANDSETOFFERTYPE_EXPIRY_CHK,[HandSetOfferType].[active] AS HANDSETOFFERTYPE_ACTIVE,[HandSetOfferType].[name] AS HANDSETOFFERTYPE_NAME,[HandSetOfferType].[edate] AS HANDSETOFFERTYPE_EDATE,[HandSetOfferType].[ddate] AS HANDSETOFFERTYPE_DDATE,[HandSetOfferType].[sdate] AS HANDSETOFFERTYPE_SDATE  FROM  [HandSetOfferType]  WHERE  [HandSetOfferType].[id] = \'"+x_iId.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[HandSetOfferType]","["+ Configurator.MSSQLTablePrefix + "HandSetOfferType]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(HandSetOfferType.Para.id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["HANDSETOFFERTYPE_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.cdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_CDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.cdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.cdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_CDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.cdate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.cid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_CID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.cid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.cid).AliasName].ToString()] = (string)_oData["HANDSETOFFERTYPE_CID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.cid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.did).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_DID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.did).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.did).AliasName].ToString()] = (string)_oData["HANDSETOFFERTYPE_DID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.did).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_EXPIRY_CHK"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["HANDSETOFFERTYPE_EXPIRY_CHK"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.active).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_ACTIVE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.active).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["HANDSETOFFERTYPE_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.name).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_NAME"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.name).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.name).AliasName].ToString()] = (string)_oData["HANDSETOFFERTYPE_NAME"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.name).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.edate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_EDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.edate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.edate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_EDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.edate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.ddate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_DDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.ddate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.ddate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_DDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.ddate).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(HandSetOfferType.Para.sdate).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["HANDSETOFFERTYPE_SDATE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(HandSetOfferType.Para.sdate).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.sdate).AliasName].ToString()] = (global::System.Nullable<DateTime>)_oData["HANDSETOFFERTYPE_SDATE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(HandSetOfferType.Para.sdate).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,HandSetOfferType x_oHandSetOfferTypeRow)
        {
            return SetByDataSetRowProc(x_iROW, HandSetOfferType.Para.TableName(), x_oDataSet,x_oHandSetOfferTypeRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,HandSetOfferType x_oHandSetOfferTypeRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oHandSetOfferTypeRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,HandSetOfferType x_oHandSetOfferTypeRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                HandSetOfferTypeInfo _oTableSet=HandSetOfferTypeInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.id).AliasName))
                    x_oHandSetOfferTypeRow.id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.cdate).AliasName))
                    x_oHandSetOfferTypeRow.cdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.cdate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.cid).AliasName))
                    x_oHandSetOfferTypeRow.cid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.cid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.did).AliasName))
                    x_oHandSetOfferTypeRow.did = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.did).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).AliasName))
                    x_oHandSetOfferTypeRow.expiry_chk = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.expiry_chk).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.active).AliasName))
                    x_oHandSetOfferTypeRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.name).AliasName))
                    x_oHandSetOfferTypeRow.name = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.name).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.edate).AliasName))
                    x_oHandSetOfferTypeRow.edate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.edate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.ddate).AliasName))
                    x_oHandSetOfferTypeRow.ddate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.ddate).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(HandSetOfferType.Para.sdate).AliasName))
                    x_oHandSetOfferTypeRow.sdate = (global::System.Nullable<DateTime>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(HandSetOfferType.Para.sdate).AliasName];
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
            return HandSetOfferTypeRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static HandSetOfferTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return HandSetOfferTypeRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static HandSetOfferTypeEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return HandSetOfferTypeRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return HandSetOfferTypeRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return HandSetOfferTypeRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return HandSetOfferTypeRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bExpiry_chk,global::System.Nullable<bool> x_bActive,string x_sName,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            return HandSetOfferTypeRepository.Insert(x_oDB, x_dCdate,x_sCid,x_sDid,x_bExpiry_chk,x_bActive,x_sName,x_dEdate,x_dDdate,x_dSdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,HandSetOfferType x_oHandSetOfferType)
        {
            return HandSetOfferTypeRepository.InsertWithOutLastID(x_oDB,x_oHandSetOfferType);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,global::System.Nullable<bool> x_bExpiry_chk,global::System.Nullable<bool> x_bActive,string x_sName,global::System.Nullable<DateTime> x_dEdate,global::System.Nullable<DateTime> x_dDdate,global::System.Nullable<DateTime> x_dSdate)
        {
            return HandSetOfferTypeRepository.InsertReturnLastID_SP(x_oDB,x_dCdate,x_sCid,x_sDid,x_bExpiry_chk,x_bActive,x_sName,x_dEdate,x_dDdate,x_dSdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, HandSetOfferType x_oHandSetOfferType)
        {
            return HandSetOfferTypeRepository.InsertReturnLastID_SP(x_oDB,x_oHandSetOfferType);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return HandSetOfferTypeRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return HandSetOfferTypeRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<int> x_iId)
        {
            return HandSetOfferTypeRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(HandSetOfferType x_oHandSetOfferTypeRow){
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


