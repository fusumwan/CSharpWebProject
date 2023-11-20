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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-03-24>
///-- Description:	<Description,Table :[CSSDB].[csc].[staffinfo_new],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CSSDB].[csc].[staffinfo_new] Business layer
    /// </summary>
    
    public abstract class Staffinfo_newBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public Staffinfo_newBalBase(){
        }
        ~Staffinfo_newBalBase(){
            this.Release();
        }
        #endregion
        
        

        
        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return Staffinfo_newManager.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static Staffinfo_new[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId){
            return Staffinfo_newManager.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static Staffinfo_new[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return Staffinfo_newManager.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Staffinfo_newManager.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Staffinfo_newManager.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return Staffinfo_newManager.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, System.Nullable<int> x_iBasic,System.Nullable<DateTime> x_dEdate,string x_sSteptype,System.Nullable<DateTime> x_dCdate,string x_sCmrid,string x_sDid,System.Nullable<DateTime> x_dContract_s,System.Nullable<DateTime> x_dSdate,System.Nullable<bool> x_bActive,string x_sSalesman_code,string x_sStream,System.Nullable<DateTime> x_dJoindate,string x_sShift,string x_sStaff_no,System.Nullable<bool> x_bInternship,System.Nullable<DateTime> x_dLwdate,System.Nullable<DateTime> x_dDdate,string x_sStaff_no2,string x_sTeamcode,string x_sCentre,string x_sLanguage,string x_sCid,string x_sStaff_name,System.Nullable<int> x_iOtc,string x_sSkill,System.Nullable<bool> x_bFreeze,System.Nullable<DateTime> x_dContract_e,string x_sStaff_type,string x_sSteplevel,string x_sCcc,string x_sPay_code)
        {
            return Staffinfo_newManager.Insert(x_oDB, x_iBasic,x_dEdate,x_sSteptype,x_dCdate,x_sCmrid,x_sDid,x_dContract_s,x_dSdate,x_bActive,x_sSalesman_code,x_sStream,x_dJoindate,x_sShift,x_sStaff_no,x_bInternship,x_dLwdate,x_dDdate,x_sStaff_no2,x_sTeamcode,x_sCentre,x_sLanguage,x_sCid,x_sStaff_name,x_iOtc,x_sSkill,x_bFreeze,x_dContract_e,x_sStaff_type,x_sSteplevel,x_sCcc,x_sPay_code);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Staffinfo_new x_oStaffinfo_new)
        {
            return Staffinfo_newManager.InsertWithOutLastID(x_oDB,x_oStaffinfo_new);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,System.Nullable<int> x_iBasic,System.Nullable<DateTime> x_dEdate,string x_sSteptype,System.Nullable<DateTime> x_dCdate,string x_sCmrid,string x_sDid,System.Nullable<DateTime> x_dContract_s,System.Nullable<DateTime> x_dSdate,System.Nullable<bool> x_bActive,string x_sSalesman_code,string x_sStream,System.Nullable<DateTime> x_dJoindate,string x_sShift,string x_sStaff_no,System.Nullable<bool> x_bInternship,System.Nullable<DateTime> x_dLwdate,System.Nullable<DateTime> x_dDdate,string x_sStaff_no2,string x_sTeamcode,string x_sCentre,string x_sLanguage,string x_sCid,string x_sStaff_name,System.Nullable<int> x_iOtc,string x_sSkill,System.Nullable<bool> x_bFreeze,System.Nullable<DateTime> x_dContract_e,string x_sStaff_type,string x_sSteplevel,string x_sCcc,string x_sPay_code)
        {
            return Staffinfo_newManager.InsertReturnLastID_SP(x_oDB,x_iBasic,x_dEdate,x_sSteptype,x_dCdate,x_sCmrid,x_sDid,x_dContract_s,x_dSdate,x_bActive,x_sSalesman_code,x_sStream,x_dJoindate,x_sShift,x_sStaff_no,x_bInternship,x_dLwdate,x_dDdate,x_sStaff_no2,x_sTeamcode,x_sCentre,x_sLanguage,x_sCid,x_sStaff_name,x_iOtc,x_sSkill,x_bFreeze,x_dContract_e,x_sStaff_type,x_sSteplevel,x_sCcc,x_sPay_code);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Staffinfo_new x_oStaffinfo_new)
        {
            return Staffinfo_newManager.InsertReturnLastID_SP(x_oDB,x_oStaffinfo_new);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return Staffinfo_newManager.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return Staffinfo_newManager.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            return Staffinfo_newManager.Delete(x_oDB, x_iId);
        }
        
        
        public static bool Delete(MSSQLConnect x_oDB,string x_sStaff_no2,string x_sStaff_no)
        {
            return Staffinfo_newManager.Delete(x_oDB, x_sStaff_no2,x_sStaff_no);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(Staffinfo_new x_oStaffinfo_newRow){
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


