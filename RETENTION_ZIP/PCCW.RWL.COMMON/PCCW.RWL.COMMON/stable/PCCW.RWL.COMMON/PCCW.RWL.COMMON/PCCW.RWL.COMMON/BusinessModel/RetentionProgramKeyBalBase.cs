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
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-02-03>
///-- Description:	<Description,Table :[RetentionProgramKey],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [RetentionProgramKey] Business layer
    /// </summary>
    
    public abstract class RetentionProgramKeyBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public RetentionProgramKeyBalBase(){
        }
        ~RetentionProgramKeyBalBase(){
            this.Release();
        }
        #endregion
        

        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return RetentionProgramKeyRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static RetentionProgramKeyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId){
            return RetentionProgramKeyRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static RetentionProgramKeyEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return RetentionProgramKeyRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return RetentionProgramKeyRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return RetentionProgramKeyRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return RetentionProgramKeyRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sType,string x_sCall_list_type,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,System.Nullable<DateTime> x_dReturn_date,System.Nullable<DateTime> x_dEdate,System.Nullable<bool> x_bActive,string x_sCenter,string x_sExpiry_month,System.Nullable<DateTime> x_dUpload_date,string x_sCall_list_size,System.Nullable<DateTime> x_dDdate,string x_sProgram_name,System.Nullable<int> x_iProgram_id,string x_sRemarks,System.Nullable<DateTime> x_dSdate)
        {
            return RetentionProgramKeyRepository.Insert(x_oDB, x_sType,x_sCall_list_type,x_dCdate,x_sCid,x_sDid,x_dReturn_date,x_dEdate,x_bActive,x_sCenter,x_sExpiry_month,x_dUpload_date,x_sCall_list_size,x_dDdate,x_sProgram_name,x_iProgram_id,x_sRemarks,x_dSdate);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,RetentionProgramKey x_oRetentionProgramKey)
        {
            return RetentionProgramKeyRepository.InsertWithOutLastID(x_oDB,x_oRetentionProgramKey);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sType,string x_sCall_list_type,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,System.Nullable<DateTime> x_dReturn_date,System.Nullable<DateTime> x_dEdate,System.Nullable<bool> x_bActive,string x_sCenter,string x_sExpiry_month,System.Nullable<DateTime> x_dUpload_date,string x_sCall_list_size,System.Nullable<DateTime> x_dDdate,string x_sProgram_name,System.Nullable<int> x_iProgram_id,string x_sRemarks,System.Nullable<DateTime> x_dSdate)
        {
            return RetentionProgramKeyRepository.InsertReturnLastID_SP(x_oDB,x_sType,x_sCall_list_type,x_dCdate,x_sCid,x_sDid,x_dReturn_date,x_dEdate,x_bActive,x_sCenter,x_sExpiry_month,x_dUpload_date,x_sCall_list_size,x_dDdate,x_sProgram_name,x_iProgram_id,x_sRemarks,x_dSdate);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, RetentionProgramKey x_oRetentionProgramKey)
        {
            return RetentionProgramKeyRepository.InsertReturnLastID_SP(x_oDB,x_oRetentionProgramKey);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return RetentionProgramKeyRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return RetentionProgramKeyRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            return RetentionProgramKeyRepository.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(RetentionProgramKey x_oRetentionProgramKeyRow){
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


