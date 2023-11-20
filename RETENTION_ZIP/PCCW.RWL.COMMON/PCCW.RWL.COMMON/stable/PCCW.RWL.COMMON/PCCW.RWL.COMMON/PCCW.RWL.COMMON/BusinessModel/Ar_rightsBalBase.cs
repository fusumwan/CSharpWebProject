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
///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-03-24>
///-- Description:	<Description,Table :[CSSDB].[dbo].[ar_rights],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[ar_rights] Business layer
    /// </summary>
    
    public abstract class Ar_rightsBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public Ar_rightsBalBase(){
        }
        ~Ar_rightsBalBase(){
            this.Release();
        }
        #endregion
        
        

        
        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return Ar_rightsManager.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static Ar_rights[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId){
            return Ar_rightsManager.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static Ar_rights[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return Ar_rightsManager.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Ar_rightsManager.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Ar_rightsManager.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return Ar_rightsManager.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sCID,string x_sDID,string x_sPROG_LV,System.Nullable<bool> x_bAR_LST,string x_sSTAFF_NO,System.Nullable<bool> x_bAR_PRT,System.Nullable<bool> x_bAR_MOD,string x_sPROG_NAME,System.Nullable<int> x_iACTIVE,System.Nullable<bool> x_bAR_ADD,System.Nullable<bool> x_bAR_DEL,System.Nullable<DateTime> x_dDDATE,System.Nullable<DateTime> x_dCDATE)
        {
            return Ar_rightsManager.Insert(x_oDB, x_sCID,x_sDID,x_sPROG_LV,x_bAR_LST,x_sSTAFF_NO,x_bAR_PRT,x_bAR_MOD,x_sPROG_NAME,x_iACTIVE,x_bAR_ADD,x_bAR_DEL,x_dDDATE,x_dCDATE);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Ar_rights x_oAr_rights)
        {
            return Ar_rightsManager.InsertWithOutLastID(x_oDB,x_oAr_rights);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sCID,string x_sDID,string x_sPROG_LV,System.Nullable<bool> x_bAR_LST,string x_sSTAFF_NO,System.Nullable<bool> x_bAR_PRT,System.Nullable<bool> x_bAR_MOD,string x_sPROG_NAME,System.Nullable<int> x_iACTIVE,System.Nullable<bool> x_bAR_ADD,System.Nullable<bool> x_bAR_DEL,System.Nullable<DateTime> x_dDDATE,System.Nullable<DateTime> x_dCDATE)
        {
            return Ar_rightsManager.InsertReturnLastID_SP(x_oDB,x_sCID,x_sDID,x_sPROG_LV,x_bAR_LST,x_sSTAFF_NO,x_bAR_PRT,x_bAR_MOD,x_sPROG_NAME,x_iACTIVE,x_bAR_ADD,x_bAR_DEL,x_dDDATE,x_dCDATE);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Ar_rights x_oAr_rights)
        {
            return Ar_rightsManager.InsertReturnLastID_SP(x_oDB,x_oAr_rights);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return Ar_rightsManager.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return Ar_rightsManager.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iAPPL_ID)
        {
            return Ar_rightsManager.Delete(x_oDB, x_iAPPL_ID);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(Ar_rights x_oAr_rightsRow){
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


