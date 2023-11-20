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
///-- Description:	<Description,Table :[MobileOrderThreeParty],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [MobileOrderThreeParty] Business layer
    /// </summary>
    
    public abstract class MobileOrderThreePartyBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public MobileOrderThreePartyBalBase(){
        }
        ~MobileOrderThreePartyBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            return GetDataSet(x_oMobileOrderThreeParty,null,MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreeParty x_oMobileOrderThreeParty,global::System.Data.DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oMobileOrderThreeParty,x_oMergeDSet,MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreeParty x_oMobileOrderThreeParty,MobileOrderThreePartyInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderThreeParty,null,x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(MobileOrderThreeParty x_oMobileOrderThreeParty,global::System.Data.DataSet x_oMergeDSet,MobileOrderThreePartyInfo x_oTableSet)
        {
            return GetDataSet(x_oMobileOrderThreeParty,x_oMergeDSet,x_oTableSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(MobileOrderThreeParty x_oMobileOrderThreeParty,global::System.Data.DataSet x_oMergeDSet,MobileOrderThreePartyInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(MobileOrderThreeParty.Para.TableName());
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.tpy_id); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.arthurization_person); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.contact_no); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.type); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.id_type); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.plural).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.plural); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.hkid); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.order_id); }
            if (x_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).IsView || x_oTableSet.GetViewAll()) { _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Columns.Add(MobileOrderThreeParty.Para.three_party); }
            if (x_oMobileOrderThreeParty != null){
                global::System.Data.DataRow _oDRow = _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].NewRow();
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.tpy_id] = x_oMobileOrderThreeParty.GetTpy_id(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.arthurization_person] = x_oMobileOrderThreeParty.GetArthurization_person(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.contact_no] = x_oMobileOrderThreeParty.GetContact_no(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.type] = x_oMobileOrderThreeParty.GetType(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.id_type] = x_oMobileOrderThreeParty.GetId_type(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.plural).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.plural] = x_oMobileOrderThreeParty.GetPlural(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.hkid] = x_oMobileOrderThreeParty.GetHkid(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.order_id] = x_oMobileOrderThreeParty.GetOrder_id(); }
                if (x_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).IsView || x_oTableSet.GetViewAll()) { _oDRow[MobileOrderThreeParty.Para.three_party] = x_oMobileOrderThreeParty.GetThree_party(); }
                _oDSet.Tables[MobileOrderThreeParty.Para.TableName()].Rows.Add(_oDRow);
            }
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        protected static global::System.Data.DataSet ToEmptyDataSetProcess(MobileOrderThreePartyInfo x_oTableSet)
        {
            return MobileOrderThreePartyBal.GetDataSet(null, null, x_oTableSet);
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet()
        {
            return MobileOrderThreePartyBal.ToEmptyDataSetProcess(MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static global::System.Data.DataSet ToEmptyDataSet(MobileOrderThreePartyInfo x_oTableSet)
        {
            return MobileOrderThreePartyBal.ToEmptyDataSetProcess(x_oTableSet);
        }
        
        
        #endregion ToDataSet
        
        #region To Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        public static global::System.Data.DataTable ToTable(MobileOrderThreeParty x_oMobileOrderThreeParty, MobileOrderThreePartyInfo x_oTableSet)
        {
            return MobileOrderThreePartyBal.GetDataSet(null, null, x_oTableSet).Tables[MobileOrderThreeParty.Para.TableName()];
        }
        public static global::System.Data.DataTable ToTable(MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            return MobileOrderThreePartyBal.GetDataSet(x_oMobileOrderThreeParty, null, MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject()).Tables[MobileOrderThreeParty.Para.TableName()];
        }
        #endregion
        
        #region To Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id)
        {
            return Row(x_oTable, x_oDB,x_lTpy_id,MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject());
        }
        
        
        public static DataRow ToRow(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id, MobileOrderThreePartyInfo x_oTableSet)
        {
            return Row(x_oTable, x_oDB,x_lTpy_id, x_oTableSet);
        }
        
        public static DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id,MobileOrderThreePartyInfo x_oTableSet)
        {
            if (x_oTableSet == null) x_oTableSet = MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT   [MobileOrderThreeParty].[tpy_id] AS MOBILEORDERTHREEPARTY_TPY_ID,[MobileOrderThreeParty].[hkid] AS MOBILEORDERTHREEPARTY_HKID,[MobileOrderThreeParty].[arthurization_person] AS MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON,[MobileOrderThreeParty].[id_type] AS MOBILEORDERTHREEPARTY_ID_TYPE,[MobileOrderThreeParty].[type] AS MOBILEORDERTHREEPARTY_TYPE,[MobileOrderThreeParty].[contact_no] AS MOBILEORDERTHREEPARTY_CONTACT_NO,[MobileOrderThreeParty].[plural] AS MOBILEORDERTHREEPARTY_PLURAL,[MobileOrderThreeParty].[order_id] AS MOBILEORDERTHREEPARTY_ORDER_ID,[MobileOrderThreeParty].[three_party] AS MOBILEORDERTHREEPARTY_THREE_PARTY  FROM  [MobileOrderThreeParty]  WHERE  [MobileOrderThreeParty].[tpy_id] = \'"+x_lTpy_id.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix)) { _sQuery = _sQuery.Replace("[MobileOrderThreeParty]","["+ Configurator.MSSQLTablePrefix + "MobileOrderThreeParty]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_TPY_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).AliasName].ToString()] = (global::System.Nullable<long>)_oData["MOBILEORDERTHREEPARTY_TPY_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_HKID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTY_HKID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTY_ARTHURIZATION_PERSON"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ID_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTY_ID_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.type).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_TYPE"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.type).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.type).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTY_TYPE"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.type).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_CONTACT_NO"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTY_CONTACT_NO"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.plural).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_PLURAL"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.plural).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.plural).AliasName].ToString()] = (string)_oData["MOBILEORDERTHREEPARTY_PLURAL"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.plural).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_ORDER_ID"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).AliasName].ToString()] = (global::System.Nullable<int>)_oData["MOBILEORDERTHREEPARTY_ORDER_ID"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).AliasName].ToString()] =string.Empty;
                        }
                        if (x_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).IsView || x_oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["MOBILEORDERTHREEPARTY_THREE_PARTY"]) && x_oTable.Columns.Contains(x_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).AliasName))
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["MOBILEORDERTHREEPARTY_THREE_PARTY"];
                            else
                                _oRw[x_oTable.Columns[x_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).AliasName].ToString()] =string.Empty;
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
        
        public static bool SetByDataSetRow(int x_iROW, DataSet x_oDataSet,MobileOrderThreeParty x_oMobileOrderThreePartyRow)
        {
            return SetByDataSetRowProc(x_iROW, MobileOrderThreeParty.Para.TableName(), x_oDataSet,x_oMobileOrderThreePartyRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderThreeParty x_oMobileOrderThreePartyRow)
        {
            return SetByDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oMobileOrderThreePartyRow);
        }
        protected static bool SetByDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,MobileOrderThreeParty x_oMobileOrderThreePartyRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                MobileOrderThreePartyInfo _oTableSet=MobileOrderThreePartyInfoDLL.CreateInfoInstanceObject();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).AliasName))
                    x_oMobileOrderThreePartyRow.tpy_id = (global::System.Nullable<long>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.tpy_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).AliasName))
                    x_oMobileOrderThreePartyRow.arthurization_person = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.arthurization_person).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).AliasName))
                    x_oMobileOrderThreePartyRow.contact_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.contact_no).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.type).AliasName))
                    x_oMobileOrderThreePartyRow.type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).AliasName))
                    x_oMobileOrderThreePartyRow.id_type = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.id_type).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.plural).AliasName))
                    x_oMobileOrderThreePartyRow.plural = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.plural).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).AliasName))
                    x_oMobileOrderThreePartyRow.hkid = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.hkid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).AliasName))
                    x_oMobileOrderThreePartyRow.order_id = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.order_id).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).AliasName))
                    x_oMobileOrderThreePartyRow.three_party = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(MobileOrderThreeParty.Para.three_party).AliasName];
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
            return MobileOrderThreePartyRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static MobileOrderThreePartyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, List<string> x_oArrayItemId){
            return MobileOrderThreePartyRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static MobileOrderThreePartyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return MobileOrderThreePartyRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderThreePartyRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return MobileOrderThreePartyRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderThreePartyRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            return MobileOrderThreePartyRepository.Insert(x_oDB, x_sArthurization_person,x_sContact_no,x_sType,x_sId_type,x_sPlural,x_sHkid,x_iOrder_id,x_bThree_party);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            return MobileOrderThreePartyRepository.InsertWithOutLastID(x_oDB,x_oMobileOrderThreeParty);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sArthurization_person,string x_sContact_no,string x_sType,string x_sId_type,string x_sPlural,string x_sHkid,global::System.Nullable<int> x_iOrder_id,global::System.Nullable<bool> x_bThree_party)
        {
            return MobileOrderThreePartyRepository.InsertReturnLastID_SP(x_oDB,x_sArthurization_person,x_sContact_no,x_sType,x_sId_type,x_sPlural,x_sHkid,x_iOrder_id,x_bThree_party);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, MobileOrderThreeParty x_oMobileOrderThreeParty)
        {
            return MobileOrderThreePartyRepository.InsertReturnLastID_SP(x_oDB,x_oMobileOrderThreeParty);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return MobileOrderThreePartyRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return MobileOrderThreePartyRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,global::System.Nullable<long> x_lTpy_id)
        {
            return MobileOrderThreePartyRepository.Delete(x_oDB, x_lTpy_id);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(MobileOrderThreeParty x_oMobileOrderThreePartyRow){
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


