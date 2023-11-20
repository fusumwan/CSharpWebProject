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
///-- Description:	<Description,Table :[MobileOrderThreePartyRevision],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderThreePartyRevision] Business layer
    /// </summary>
    
    public abstract class MobileOrderThreePartyRevisionBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderThreePartyRevisionBalBase(){
        }
        ~MobileOrderThreePartyRevisionBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            return GetDataSet(x_oMobileOrderThreePartyRevision,null,MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderThreePartyRevision,x_oMergeDSet,MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision,MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderThreePartyRevision,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderThreePartyRevision,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision,global::System.Data.DataSet x_oMergeDSet,MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderThreePartyRevision.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.tpy_id); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.arthurization_person); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.contact_no); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.type); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.id_type); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.plural); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.hkid); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.mid); }
            if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Columns.Add(MobileOrderThreePartyRevision.Para.three_party); }
            if (x_oMobileOrderThreePartyRevision != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.tpy_id] = x_oMobileOrderThreePartyRevision.GetTpy_id(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.arthurization_person] = x_oMobileOrderThreePartyRevision.GetArthurization_person(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.contact_no] = x_oMobileOrderThreePartyRevision.GetContact_no(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.type] = x_oMobileOrderThreePartyRevision.GetType(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.id_type] = x_oMobileOrderThreePartyRevision.GetId_type(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.plural] = x_oMobileOrderThreePartyRevision.GetPlural(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.hkid] = x_oMobileOrderThreePartyRevision.GetHkid(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.order_id] = x_oMobileOrderThreePartyRevision.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.mid] = x_oMobileOrderThreePartyRevision.GetMid(); }
                if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreePartyRevision.Para.three_party] = x_oMobileOrderThreePartyRevision.GetThree_party(); }
                _oDSet.Tables[MobileOrderThreePartyRevision.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            return MobileOrderThreePartyRevisionBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderThreePartyRevisionBal.ToEmptyDataSetProcess(MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            return MobileOrderThreePartyRevisionBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision, MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            return MobileOrderThreePartyRevisionBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderThreePartyRevision.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            return MobileOrderThreePartyRevisionBal.GetDataSet(x_oMobileOrderThreePartyRevision, null, MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderThreePartyRevision.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return Row(x_oTable, x_oDB,x_lMid,MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid, MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lMid, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid,MobileOrderThreePartyRevisionInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderThreePartyRevision].[tpy_id] AS MOBILEORDERTHREEPARTYREVISION_TPY_ID,[MobileOrderThreePartyRevision].[hkid] AS MOBILEORDERTHREEPARTYREVISION_HKID,[MobileOrderThreePartyRevision].[arthurization_person] AS MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON,[MobileOrderThreePartyRevision].[id_type] AS MOBILEORDERTHREEPARTYREVISION_ID_TYPE,[MobileOrderThreePartyRevision].[type] AS MOBILEORDERTHREEPARTYREVISION_TYPE,[MobileOrderThreePartyRevision].[contact_no] AS MOBILEORDERTHREEPARTYREVISION_CONTACT_NO,[MobileOrderThreePartyRevision].[plural] AS MOBILEORDERTHREEPARTYREVISION_PLURAL,[MobileOrderThreePartyRevision].[order_id] AS MOBILEORDERTHREEPARTYREVISION_ORDER_ID,[MobileOrderThreePartyRevision].[mid] AS MOBILEORDERTHREEPARTYREVISION_MID,[MobileOrderThreePartyRevision].[three_party] AS MOBILEORDERTHREEPARTYREVISION_THREE_PARTY  FROM  [MobileOrderThreePartyRevision]  WHERE  [MobileOrderThreePartyRevision].[mid] = \'"+x_lMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreePartyRevision]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreePartyRevision]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_TPY_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTYREVISION_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ARTHURIZATION_PERSON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTYREVISION_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTYREVISION_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTYREVISION_CONTACT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTYREVISION_PLURAL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERTHREEPARTYREVISION_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_MID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTYREVISION_MID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERTHREEPARTYREVISION_THREE_PARTY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderThreePartyRevision.Para.TableName(), x_oDataSet,x_oMobileOrderThreePartyRevisionRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevisionRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderThreePartyRevisionRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevisionRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderThreePartyRevisionInfo _oTableSet=MobileOrderThreePartyRevisionInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.tpy_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.tpy_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.arthurization_person = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.arthurization_person).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.contact_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.contact_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.plural = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.plural).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.mid = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).AliasName))
                    x_oMobileOrderThreePartyRevisionRow.three_party = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreePartyRevision.Para.three_party).AliasName];
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
            return MobileOrderThreePartyRevisionRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderThreePartyRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderThreePartyRevisionRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderThreePartyRevisionEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderThreePartyRevisionRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderThreePartyRevisionRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderThreePartyRevisionRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderThreePartyRevisionRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, global::System.Nullable<long> x_lTpy_id,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            return MobileOrderThreePartyRevisionRepository.Insert(x_oDB, x_lTpy_id,x_sArthurization_person,x_sContact_no,x_sType,x_sId_type,x_sPlural,x_sHkid,x_iOrder_id,x_bThree_party);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            return MobileOrderThreePartyRevisionRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderThreePartyRevision);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            return MobileOrderThreePartyRevisionRepository.InsertReturnLastID_SP(x_oDB,x_lTpy_id,x_sArthurization_person,x_sContact_no,x_sType,x_sId_type,x_sPlural,x_sHkid,x_iOrder_id,x_bThree_party);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevision)
        {
            return MobileOrderThreePartyRevisionRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderThreePartyRevision);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderThreePartyRevisionRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderThreePartyRevisionRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lMid)
        {
            return MobileOrderThreePartyRevisionRepository.Delete(x_oDB, x_lMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderThreePartyRevision x_oMobileOrderThreePartyRevisionRow){
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


