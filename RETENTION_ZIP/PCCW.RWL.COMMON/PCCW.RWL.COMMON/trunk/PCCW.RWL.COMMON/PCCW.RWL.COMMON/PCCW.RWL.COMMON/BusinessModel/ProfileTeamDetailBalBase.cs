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
using System.Xml;


using NEURON.ENTITY.FRAMEWORK;

using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[ProfileTeamDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [ProfileTeamDetail] Business layer
    /// </summary>
    
    public abstract class ProfileTeamDetailBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public ProfileTeamDetailBalBase(){
        }
        ~ProfileTeamDetailBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region ToDataSet
        
        
        // ******************************
        // *  Handler for Convert To DataSet
        // ******************************
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamDetail x_oProfileTeamDetail)
        {
            return GetDataSet(x_oProfileTeamDetail,null);
        }
        
        
        public static global::System.Data.DataSet ToDataSet(ProfileTeamDetail x_oProfileTeamDetail,DataSet x_oMergeDSet)
        {
            return GetDataSet(x_oProfileTeamDetail,x_oMergeDSet);
        }
        
        
        protected static global::System.Data.DataSet GetDataSet(ProfileTeamDetail x_oProfileTeamDetail,DataSet x_oMergeDSet)
        {
            ProfileTeamDetailInfo _oTableSet = ProfileTeamDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(ProfileTeamDetail.Para.TableName());
            if (_oTableSet.Fields(ProfileTeamDetail.Para.mid).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("mid"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("teamcode"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.active).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("active"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("salesmancode"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("staff_no"); }
            global::System.Data.DataRow _oDRow = _oDSet.Tables[ProfileTeamDetail.Para.TableName()].NewRow();
            if (_oTableSet.Fields(ProfileTeamDetail.Para.mid).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.mid] = x_oProfileTeamDetail.GetMid(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.teamcode] = x_oProfileTeamDetail.GetTeamcode(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.active).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.active] = x_oProfileTeamDetail.GetActive(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.salesmancode] = x_oProfileTeamDetail.GetSalesmancode(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.staff_no] = x_oProfileTeamDetail.GetStaff_no(); }
            _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Rows.Add(_oDRow);
            if(x_oMergeDSet!=null){ _oDSet.Merge(x_oMergeDSet); }
            return _oDSet;
        }
        
        
        public global::System.Data.DataSet ToEmptyDataSet()
        {
            ProfileTeamDetailInfo _oTableSet = ProfileTeamDetailInfoDLL.CreateInfoInstanceObject();
            global::System.Data.DataSet _oDSet = new global::System.Data.DataSet();
            _oDSet.Tables.Add(ProfileTeamDetail.Para.TableName());
            if (_oTableSet.Fields(ProfileTeamDetail.Para.mid).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("mid"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("teamcode"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.active).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("active"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("salesmancode"); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).IsView || _oTableSet.GetViewAll()) { _oDSet.Tables[ProfileTeamDetail.Para.TableName()].Columns.Add("staff_no"); }
            return _oDSet;
        }
        
        
        #endregion ToDataSet
        
        #region Table
        
        // ******************************
        // *  Handler for Convert To Table
        // ******************************
        
        public static global::System.Data.DataTable Table(ProfileTeamDetail x_oProfileTeamDetail)
        {
            global::System.Data.DataTable n_oTbl = new DataTable();
            ProfileTeamDetailInfo _oTableSet = ProfileTeamDetailInfoDLL.CreateInfoInstanceObject();
            if (_oTableSet.Fields(ProfileTeamDetail.Para.mid).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(ProfileTeamDetail.Para.mid).AliasName);}
            if (_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).AliasName);}
            if (_oTableSet.Fields(ProfileTeamDetail.Para.active).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(ProfileTeamDetail.Para.active).AliasName);}
            if (_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).AliasName);}
            if (_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).IsView || _oTableSet.GetViewAll()) {n_oTbl.Columns.Add(_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).AliasName);}
            global::System.Data.DataRow _oDRow = n_oTbl.NewRow();
            if (_oTableSet.Fields(ProfileTeamDetail.Para.mid).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.mid] = x_oProfileTeamDetail.GetMid(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.teamcode] = x_oProfileTeamDetail.GetTeamcode(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.active).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.active] = x_oProfileTeamDetail.GetActive(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.salesmancode] = x_oProfileTeamDetail.GetSalesmancode(); }
            if (_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).IsView || _oTableSet.GetViewAll()) { _oDRow[ProfileTeamDetail.Para.staff_no] = x_oProfileTeamDetail.GetStaff_no(); }
            n_oTbl.Rows.Add(_oDRow);
            return n_oTbl;
        }
        #endregion
        
        
        #region Row
        
        // ******************************
        // *  Handler for Data DataRow
        // ******************************
        
        public static global::System.Data.DataRow Row(DataTable x_oTable,MSSQLConnect x_oDB,System.Nullable<int> x_iMid)
        {
            ProfileTeamDetailInfo _oTableSet=new ProfileTeamDetailInfo();
            using(global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection()){
                string _sQuery = "SELECT [ProfileTeamDetail].[active] AS ProfileTeamDetail_ACTIVE,[ProfileTeamDetail].[teamcode] AS ProfileTeamDetail_TEAMCODE,[ProfileTeamDetail].[mid] AS ProfileTeamDetail_MID,[ProfileTeamDetail].[salesmancode] AS ProfileTeamDetail_SALESMANCODE,[ProfileTeamDetail].[staff_no] AS ProfileTeamDetail_STAFF_NO  FROM  [ProfileTeamDetail]  WHERE  [ProfileTeamDetail].[mid] = \'"+x_iMid.ToString()+"\'";
                if (!"".Equals(Configurator.MSSQLTablePrefix.Trim())) { _sQuery = _sQuery.Replace("[ProfileTeamDetail]","["+ Configurator.MSSQLTablePrefix + "ProfileTeamDetail]"); }
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
                global::System.Data.SqlClient.SqlDataReader _oData;
                global::System.Data.DataRow _oRw = x_oTable.NewRow();
                try
                {
                    _oConn.Open();
                    _oData = _oCmd.ExecuteReader();
                    if (_oData.Read()){
                        if (_oTableSet.Fields(ProfileTeamDetail.Para.active).IsView || _oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ProfileTeamDetail_ACTIVE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.active).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.active).AliasName].ToString()] = (global::System.Nullable<bool>)_oData["ProfileTeamDetail_ACTIVE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.active).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).IsView || _oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ProfileTeamDetail_TEAMCODE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).AliasName].ToString()] = (string)_oData["ProfileTeamDetail_TEAMCODE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(ProfileTeamDetail.Para.mid).IsView || _oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ProfileTeamDetail_MID"]) && x_oTable.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.mid).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.mid).AliasName].ToString()] = (global::System.Nullable<int>)_oData["ProfileTeamDetail_MID"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.mid).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).IsView || _oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ProfileTeamDetail_SALESMANCODE"]) && x_oTable.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).AliasName].ToString()] = (string)_oData["ProfileTeamDetail_SALESMANCODE"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).AliasName].ToString()] =string.Empty;
                        }
                        if (_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).IsView || _oTableSet.GetViewAll()) {
                            if (!global::System.Convert.IsDBNull(_oData["ProfileTeamDetail_STAFF_NO"]) && x_oTable.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).AliasName))
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).AliasName].ToString()] = (string)_oData["ProfileTeamDetail_STAFF_NO"];
                            else
                                _oRw[x_oTable.Columns[_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).AliasName].ToString()] =string.Empty;
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
        // *  Handler for Convert To global::System.Data.DataSet Row
        // ******************************
        
        public static bool SetDataSetRow(int x_iROW, global::System.Data.DataSet x_oDataSet,ProfileTeamDetail x_oProfileTeamDetailRow)
        {
            return SetDataSetRowProc(x_iROW, ProfileTeamDetail.Para.TableName(), x_oDataSet,x_oProfileTeamDetailRow);
        }
        public static bool SetDataSetRow(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProfileTeamDetail x_oProfileTeamDetailRow)
        {
            return SetDataSetRowProc(x_iROW, x_sTableName, x_oDataSet,x_oProfileTeamDetailRow);
        }
        protected static bool SetDataSetRowProc(int x_iROW, string x_sTableName, global::System.Data.DataSet x_oDataSet,ProfileTeamDetail x_oProfileTeamDetailRow)
        {
            if (x_iROW < 0) { return false; }
            if (x_sTableName == string.Empty) { return false; }
            if (x_oDataSet.Tables.Contains(x_sTableName))
            {
                ProfileTeamDetailInfo _oTableSet=new ProfileTeamDetailInfo();
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.mid).AliasName))
                    x_oProfileTeamDetailRow.mid = (global::System.Nullable<int>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamDetail.Para.mid).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).AliasName))
                    x_oProfileTeamDetailRow.teamcode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamDetail.Para.teamcode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.active).AliasName))
                    x_oProfileTeamDetailRow.active = (global::System.Nullable<bool>)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamDetail.Para.active).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).AliasName))
                    x_oProfileTeamDetailRow.salesmancode = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamDetail.Para.salesmancode).AliasName];
                if (x_oDataSet.Tables[x_sTableName].Rows[x_iROW].Table.Columns.Contains(_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).AliasName))
                    x_oProfileTeamDetailRow.staff_no = (string)x_oDataSet.Tables[x_sTableName].Rows[x_iROW][_oTableSet.Fields(ProfileTeamDetail.Para.staff_no).AliasName];
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
            return ProfileTeamDetailRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static ProfileTeamDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId){
            return ProfileTeamDetailRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static ProfileTeamDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return ProfileTeamDetailRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProfileTeamDetailRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return ProfileTeamDetailRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return ProfileTeamDetailRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sTeamcode,System.Nullable<bool> x_bActive,string x_sSalesmancode,string x_sStaff_no)
        {
            return ProfileTeamDetailRepository.Insert(x_oDB, x_sTeamcode,x_bActive,x_sSalesmancode,x_sStaff_no);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,ProfileTeamDetail x_oProfileTeamDetail)
        {
            return ProfileTeamDetailRepository.InsertWithOutLastID(x_oDB,x_oProfileTeamDetail);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sTeamcode,System.Nullable<bool> x_bActive,string x_sSalesmancode,string x_sStaff_no)
        {
            return ProfileTeamDetailRepository.InsertReturnLastID_SP(x_oDB,x_sTeamcode,x_bActive,x_sSalesmancode,x_sStaff_no);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, ProfileTeamDetail x_oProfileTeamDetail)
        {
            return ProfileTeamDetailRepository.InsertReturnLastID_SP(x_oDB,x_oProfileTeamDetail);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return ProfileTeamDetailRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return ProfileTeamDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iMid)
        {
            return ProfileTeamDetailRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(ProfileTeamDetail x_oProfileTeamDetailRow){
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


