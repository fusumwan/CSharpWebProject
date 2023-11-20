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
///-- Description:	<Description,Table :[OrderReleaseDetail],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [OrderReleaseDetail] Business layer
    /// </summary>
    
    public abstract class OrderReleaseDetailBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public OrderReleaseDetailBalBase(){
        }
        ~OrderReleaseDetailBalBase(){
            this.Release();
        }
        #endregion
        

        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return OrderReleaseDetailRepository.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static OrderReleaseDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId){
            return OrderReleaseDetailRepository.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static OrderReleaseDetailEntity[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return OrderReleaseDetailRepository.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return OrderReleaseDetailRepository.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return OrderReleaseDetailRepository.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return OrderReleaseDetailRepository.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, System.Nullable<int> x_iOrder_id,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,System.Nullable<DateTime> x_dDdate,System.Nullable<bool> x_bActive)
        {
            return OrderReleaseDetailRepository.Insert(x_oDB, x_iOrder_id,x_dCdate,x_sCid,x_sDid,x_dDdate,x_bActive);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,OrderReleaseDetail x_oOrderReleaseDetail)
        {
            return OrderReleaseDetailRepository.InsertWithOutLastID(x_oDB,x_oOrderReleaseDetail);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,System.Nullable<int> x_iOrder_id,System.Nullable<DateTime> x_dCdate,string x_sCid,string x_sDid,System.Nullable<DateTime> x_dDdate,System.Nullable<bool> x_bActive)
        {
            return OrderReleaseDetailRepository.InsertReturnLastID_SP(x_oDB,x_iOrder_id,x_dCdate,x_sCid,x_sDid,x_dDdate,x_bActive);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, OrderReleaseDetail x_oOrderReleaseDetail)
        {
            return OrderReleaseDetailRepository.InsertReturnLastID_SP(x_oDB,x_oOrderReleaseDetail);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return OrderReleaseDetailRepository.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return OrderReleaseDetailRepository.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iMid)
        {
            return OrderReleaseDetailRepository.Delete(x_oDB, x_iMid);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(OrderReleaseDetail x_oOrderReleaseDetailRow){
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


