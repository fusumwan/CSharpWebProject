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
///-- Description:	<Description,Table :[CSSDB].[dbo].[channel_team_map],Business layer>
///-- =============================================


namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[channel_team_map] Business layer
    /// </summary>
    
    public abstract class Channel_team_mapBalBase{
        
        #region Constructor
        
        
        // ******************************
        // *  Handler for Class Constructor
        // ******************************
        
        public Channel_team_mapBalBase(){
        }
        ~Channel_team_mapBalBase(){
            this.Release();
        }
        #endregion
        
        
        #region Count
        
        // ******************************
        // *  Handler for Data Counting
        // ******************************
        
        public static int GetCount(MSSQLConnect x_oDB){
            return Channel_team_mapManager.GetCount(x_oDB);
        }
        #endregion
        
        
        #region Get
        
        // ******************************
        // *  Handler for Data Getting
        // ******************************
        
        public static Channel_team_map[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId){
            return Channel_team_mapManager.GetArrayObj(x_oDB,x_oColumnName,x_oArrayItemId);
        }
        
        public static Channel_team_map[] GetArrayObj(MSSQLConnect x_oDB, string x_oStrWhere, string x_oStrGroup, string x_oStrOrder){
            return Channel_team_mapManager.GetArrayObj(x_oDB,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        #endregion
        
        
        #region List
        
        // ******************************
        // *  Handler for Data Listing
        // ******************************
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Channel_team_mapManager.GetDataSet(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder){
            return Channel_team_mapManager.GetSearch(x_oDB,x_oStrFields,x_oStrWhere,x_oStrGroup,x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter){
            return Channel_team_mapManager.GetDataSet(x_oDB,x_sFilter);
        }
        #endregion
        
        #region Insert
        
        // ******************************
        // *  Handler for Data Inserting
        // ******************************
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sTeamcode,string x_sChannel,System.Nullable<bool> x_bActive)
        {
            return Channel_team_mapManager.Insert(x_oDB, x_sTeamcode,x_sChannel,x_bActive);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Channel_team_map x_oChannel_team_map)
        {
            return Channel_team_mapManager.InsertWithOutLastID(x_oDB,x_oChannel_team_map);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sTeamcode,string x_sChannel,System.Nullable<bool> x_bActive)
        {
            return Channel_team_mapManager.InsertReturnLastID_SP(x_oDB,x_sTeamcode,x_sChannel,x_bActive);
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Channel_team_map x_oChannel_team_map)
        {
            return Channel_team_mapManager.InsertReturnLastID_SP(x_oDB,x_oChannel_team_map);
        }
        
        #endregion
        
        #region Delete
        
        // ******************************
        // *  Handler for Data Deleting
        // ******************************
        
        public static bool DeleteAll(MSSQLConnect x_oDB){
            return Channel_team_mapManager.DeleteAll(x_oDB);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter){
            return Channel_team_mapManager.DeleteFilter(x_oDB, x_sFilter);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            return Channel_team_mapManager.Delete(x_oDB, x_iId);
        }
        
        
        #endregion
        
        #region Delete Uploaded Files
        
        // *************************
        // *  Delete Uploaded Files
        // *************************
        protected virtual void DeleteUploadedFiles(Channel_team_map x_oChannel_team_mapRow){
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


