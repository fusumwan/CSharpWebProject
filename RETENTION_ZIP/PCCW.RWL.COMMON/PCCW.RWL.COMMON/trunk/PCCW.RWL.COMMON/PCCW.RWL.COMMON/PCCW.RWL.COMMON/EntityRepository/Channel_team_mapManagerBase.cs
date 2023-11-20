using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
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
///-- Description:	<Description,Table :[CSSDB].[dbo].[channel_team_map],Insert / list / delete  manager layer>
///-- Linq:	<Description,This class is inheritanced the DataContext of Linq Library!>
///-- =============================================
namespace PCCW.RWL.CORE{
    
    
    /// <summary>
    /// Summary description for table [CSSDB].[dbo].[channel_team_map] Insert / list / delete manager layer
    /// </summary>
    
    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name= "channel_team_map")]
    public class Channel_team_mapManagerBase: System.Data.Linq.DataContext{
        
        #region Instance
        private static Channel_team_mapManagerBase instance;
        public static Channel_team_mapManagerBase Instance()
        {
            if( instance == null ){
                MSSQLConnect _oDB=new MSSQLConnect();
                _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
                instance = new Channel_team_mapManagerBase(_oDB);
            }
            return instance;
        }
        public static Channel_team_mapManagerBase Instance(MSSQLConnect x_oDB)
        {
            if( instance == null )
            instance = new Channel_team_mapManagerBase(x_oDB);
            return instance;
        }
        #endregion
        
        #region Parameter
        MSSQLConnect n_oDB = null;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        public Table<Channel_team_mapBase> Channel_team_maps;
        #endregion
        
        #region Constructor
        public Channel_team_mapManagerBase(MSSQLConnect x_oDB) : base(x_oDB.ConnectionStr) {
            n_oDB = x_oDB;
        }
        ~Channel_team_mapManagerBase() { 
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
            }
        }
        #endregion

        #region Count
        
        /// <summary>
        /// Summary description for Counting
        /// </summary>
        
        public int GetCount()
        {
            return GetCount(n_oDB);
        }
        public static int GetCount(MSSQLConnect x_oDB)
        {
            string _sQuery = "SELECT Count(*) AS TotalCount FROM  [CSSDB].[dbo].[channel_team_map]";
           
            global::System.Data.SqlClient.SqlConnection _oConn=x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            _oConn.Open();
            int _iTotalCount = 0;
            try
            {
                global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                if (_oData.Read())
                {
                    _iTotalCount = (int)_oData["TotalCount"];
                }
                _oData.Close();
                _oData.Dispose();
            }
            catch{}
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _iTotalCount;
        }
        #endregion
        
        #region Get
        
        /// <summary>
        /// Summary description for management get record from table
        /// </summary>
        
        
        public Channel_team_map GetObj(global::System.Nullable<int> x_iId)
        {
            return GetObj(n_oDB, x_iId);
        }
        
        
        public static Channel_team_map GetObj(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            if (x_oDB==null) { return null; }
            Channel_team_map _Channel_team_map = new Channel_team_map(x_oDB);
            if (!_Channel_team_map.Load(x_iId)) { return null; }
            return _Channel_team_map;
        }
        
        
        
        public static Channel_team_map[] GetArrayObjByID(MSSQLConnect x_oDB,List<string> x_oArrayItemId)
        {
            return GetArrayObj(x_oDB,"id",x_oArrayItemId);
        }
        
        
        public static Channel_team_map[] GetArrayObj(MSSQLConnect x_oDB, string x_oColumnName, global::System.Collections.Generic.List<string> x_oArrayItemId)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Channel_team_map> _oRow = new global::System.Collections.Generic.List<Channel_team_map>();
            string _sQuery = "SELECT [CSSDB].[dbo].[channel_team_map].[active] AS CHANNEL_TEAM_MAP_ACTIVE,[CSSDB].[dbo].[channel_team_map].[teamcode] AS CHANNEL_TEAM_MAP_TEAMCODE,[CSSDB].[dbo].[channel_team_map].[channel] AS CHANNEL_TEAM_MAP_CHANNEL,[CSSDB].[dbo].[channel_team_map].[id] AS CHANNEL_TEAM_MAP_ID  FROM  [CSSDB].[dbo].[channel_team_map]";
            if (x_oArrayItemId!=null)
            {
                string _oList = "(";
                for (int i = 0; i < x_oArrayItemId.Count; i++)
                {
                    if (i < (x_oArrayItemId.Count - 1))
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "',";
                    }
                    else
                    {
                        _oList += "'" + x_oArrayItemId[i].ToString() + "'";
                    }
                }
                _oList += ")";
                _sQuery += " WHERE [CSSDB].[dbo].[channel_team_map].["+x_oColumnName.ToString()+"]  in " + _oList;
            }
            
           
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            _oConn.Open();
            try
            {
                global::System.Data.SqlClient.SqlDataReader _oData = _oCmd.ExecuteReader();
                while (_oData.Read())
                {
                    Channel_team_map _oChannel_team_map = new Channel_team_map();
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_ID"])) {_oChannel_team_map.id = (global::System.Nullable<int>)_oData["CHANNEL_TEAM_MAP_ID"]; }else{_oChannel_team_map.id=null;}
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_TEAMCODE"])) {_oChannel_team_map.teamcode = (string)_oData["CHANNEL_TEAM_MAP_TEAMCODE"]; }else{_oChannel_team_map.teamcode=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_CHANNEL"])) {_oChannel_team_map.channel = (string)_oData["CHANNEL_TEAM_MAP_CHANNEL"]; }else{_oChannel_team_map.channel=string.Empty;}
                    if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_ACTIVE"])) {_oChannel_team_map.active = (global::System.Nullable<bool>)_oData["CHANNEL_TEAM_MAP_ACTIVE"]; }else{_oChannel_team_map.active=null;}
                    _oChannel_team_map.SetDB(x_oDB);
                    _oChannel_team_map.GetFound();
                    _oRow.Add(_oChannel_team_map);
                }
                _oData.Close();
                _oData.Dispose();
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        
        public static Channel_team_map[] GetArrayObj(MSSQLConnect x_oDB, string x_sStrWhere, string x_sStrGroup, string x_sStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Collections.Generic.List<Channel_team_map> _oRow = new global::System.Collections.Generic.List<Channel_team_map>();
            string _sFields="[CSSDB].[dbo].[channel_team_map].[active] AS CHANNEL_TEAM_MAP_ACTIVE,[CSSDB].[dbo].[channel_team_map].[teamcode] AS CHANNEL_TEAM_MAP_TEAMCODE,[CSSDB].[dbo].[channel_team_map].[channel] AS CHANNEL_TEAM_MAP_CHANNEL,[CSSDB].[dbo].[channel_team_map].[id] AS CHANNEL_TEAM_MAP_ID";
            
            global::System.Data.SqlClient.SqlDataReader _oData = Channel_team_mapManagerBase.GetSearch(x_oDB, _sFields, x_sStrWhere, x_sStrGroup, x_sStrOrder);
            while (_oData.Read())
            {
                Channel_team_map _oChannel_team_map = new Channel_team_map();
                if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_ID"])) {_oChannel_team_map.id = (global::System.Nullable<int>)_oData["CHANNEL_TEAM_MAP_ID"]; } else {_oChannel_team_map.id=null; }
                if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_TEAMCODE"])) {_oChannel_team_map.teamcode = (string)_oData["CHANNEL_TEAM_MAP_TEAMCODE"]; } else {_oChannel_team_map.teamcode=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_CHANNEL"])) {_oChannel_team_map.channel = (string)_oData["CHANNEL_TEAM_MAP_CHANNEL"]; } else {_oChannel_team_map.channel=string.Empty; }
                if (!global::System.Convert.IsDBNull(_oData["CHANNEL_TEAM_MAP_ACTIVE"])) {_oChannel_team_map.active = (global::System.Nullable<bool>)_oData["CHANNEL_TEAM_MAP_ACTIVE"]; } else {_oChannel_team_map.active=null; }
                _oChannel_team_map.SetDB(x_oDB);
                _oChannel_team_map.GetFound();
                _oRow.Add(_oChannel_team_map);
            }
            _oData.Close();
            _oData.Dispose();
            return _oRow.Count == 0 ? null : _oRow.ToArray();
        }
        #endregion
        
        #region List
        /// <summary>
        /// Summary description for get table from records with DataSet
        /// </summary>
        
        public global::System.Data.DataSet GetDataSet()
        {
            return GetDataSet(n_oDB,"");
        }
        
        
        public global::System.Data.DataSet GetDataSet(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            return GetDataSet(n_oDB,x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,  String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            global::System.Data.DataSet _oDset = x_oDB.GetDataSet( Channel_team_map.Para.TableName(),x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder,Channel_team_map.Para.TableName());
            return _oDset;
        }
        
        
        public static global::System.Data.SqlClient.SqlDataReader GetSearch(MSSQLConnect x_oDB,String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (x_oDB==null) { return null; }
            return x_oDB.GetSearch(Channel_team_map.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        
        public global::System.Data.SqlClient.SqlDataReader GetSearch(String x_oStrFields, String x_oStrWhere, String x_oStrGroup, String x_oStrOrder)
        {
            if (n_oDB == null) { return null; }
            return n_oDB.GetSearch(Channel_team_map.Para.TableName(), x_oStrFields, x_oStrWhere, x_oStrGroup, x_oStrOrder);
        }
        
        public static global::System.Data.DataSet GetDataSet(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return null; }
            string _oQuery = "SELECT [CSSDB].[dbo].[channel_team_map].[active] AS CHANNEL_TEAM_MAP_ACTIVE,[CSSDB].[dbo].[channel_team_map].[teamcode] AS CHANNEL_TEAM_MAP_TEAMCODE,[CSSDB].[dbo].[channel_team_map].[channel] AS CHANNEL_TEAM_MAP_CHANNEL,[CSSDB].[dbo].[channel_team_map].[id] AS CHANNEL_TEAM_MAP_ID  FROM  [CSSDB].[dbo].[channel_team_map]" + ((x_sFilter == "") ? "" : (" WHERE " + x_sFilter));
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlDataAdapter _oAdp = new global::System.Data.SqlClient.SqlDataAdapter();
            global::System.Data.DataSet _oDset = new global::System.Data.DataSet();
            try
            {
                _oConn.Open();
                _oAdp.SelectCommand = new global::System.Data.SqlClient.SqlCommand(_oQuery,_oConn);
                _oAdp.SelectCommand.ExecuteNonQuery();
                _oAdp.Fill(_oDset,"channel_team_map");
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oAdp.Dispose();
                _oConn.Dispose();
            }
            return _oDset;
        }
        #endregion
        
        #region Insert
        /// <summary>
        /// Summary description for management Insert
        /// </summary>
        
        public bool Insert(string x_sTeamcode,string x_sChannel,System.Nullable<bool> x_bActive)
        {
            Channel_team_map _oChannel_team_map=new Channel_team_map();
            _oChannel_team_map.teamcode=x_sTeamcode;
            _oChannel_team_map.channel=x_sChannel;
            _oChannel_team_map.active=x_bActive;
            return InsertWithOutLastID(n_oDB, _oChannel_team_map);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB, string x_sTeamcode,string x_sChannel,System.Nullable<bool> x_bActive)
        {
            Channel_team_map _oChannel_team_map=new Channel_team_map();
            _oChannel_team_map.teamcode=x_sTeamcode;
            _oChannel_team_map.channel=x_sChannel;
            _oChannel_team_map.active=x_bActive;
            return InsertWithOutLastID(x_oDB, _oChannel_team_map);
        }
        
        
        public bool Insert(Channel_team_map x_oChannel_team_map)
        {
            return InsertWithOutLastID(n_oDB, x_oChannel_team_map);
        }
        
        
        public static bool Insert(MSSQLConnect x_oDB,Channel_team_map x_oChannel_team_map)
        {
            return InsertWithOutLastID(x_oDB, x_oChannel_team_map);
        }
        
        
        public static bool InsertWithOutLastID(MSSQLConnect x_oDB,Channel_team_map x_oChannel_team_map)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT INTO  [CSSDB].[dbo].[channel_team_map]   ([active],[teamcode],[channel])  VALUES  (@active,@teamcode,@channel)";
            
            global::System.Data.SqlClient.SqlConnection _oConn =x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            return InsertTransactionWithOutLastID(_oConn, _oCmd, x_oChannel_team_map);
        }
        
        public static bool InsertTransactionWithOutLastID(global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,Channel_team_map x_oChannel_team_map)
        {
            bool _bResult = false;
            if (!x_oChannel_team_map.Vaild(true)) { return false; }
            if (x_oConn == null) return false;
            if (x_oCmd == null) return false;
            x_oCmd.Parameters.Clear();
            try
            {
                if(x_oChannel_team_map.active==null){  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit).Value=x_oChannel_team_map.active; }
                if(string.IsNullOrEmpty(x_oChannel_team_map.teamcode)){  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10).Value=x_oChannel_team_map.teamcode; }
                if(string.IsNullOrEmpty(x_oChannel_team_map.channel)){  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar,10).Value = global::System.DBNull.Value; }else{  x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar,10).Value=x_oChannel_team_map.channel; }
                x_oCmd.CommandType = CommandType.Text;
                x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                x_oConn.Close();
                x_oCmd.Dispose();
                x_oConn.Dispose();
            }
            return _bResult;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB,string x_sTeamcode,string x_sChannel,System.Nullable<bool> x_bActive)
        {
            int _oLastID;
            Channel_team_map _oChannel_team_map=new Channel_team_map();
            _oChannel_team_map.teamcode=x_sTeamcode;
            _oChannel_team_map.channel=x_sChannel;
            _oChannel_team_map.active=x_bActive;
            if(InsertWithLastID_SP(x_oDB, _oChannel_team_map,out _oLastID)){
                return _oLastID;
                }else{
                return -1;
            }
        }
        
        
        public int InsertReturnLastID_SP(Channel_team_map x_oChannel_team_map)
        {
            int _oLastID;
            if (InsertWithLastID_SP(n_oDB, x_oChannel_team_map, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        
        public static int InsertReturnLastID_SP(MSSQLConnect x_oDB, Channel_team_map x_oChannel_team_map)
        {
            int _oLastID;
            if (InsertWithLastID_SP(x_oDB, x_oChannel_team_map, out _oLastID))
            {
                return _oLastID;
            }
            return -1;
        }
        
        public static bool InsertWithLastID_SP(MSSQLConnect x_oDB,Channel_team_map x_oChannel_team_map, out int x_oLAST_ID)
        {
            x_oLAST_ID = -1;
            if (x_oDB==null) { return false; }
            string _sQuery = "INSERT_CHANNEL_TEAM_MAP";
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            return InsertTransactionWithLastID_SP(_oConn, _oCmd, x_oChannel_team_map,out x_oLAST_ID);
        }
        
        protected static bool InsertTransactionWithLastID_SP(global::System.Data.SqlClient.SqlConnection x_oConn, global::System.Data.SqlClient.SqlCommand x_oCmd,Channel_team_map x_oChannel_team_map, out int x_oLAST_ID)
        {
            bool _bResult = false;
            x_oLAST_ID = -1;
            x_oCmd.Parameters.Clear();
            global::System.Data.SqlClient.SqlParameter _oPar;
            try
            {
                _oPar=x_oCmd.Parameters.Add("@active", global::System.Data.SqlDbType.Bit);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(x_oChannel_team_map.active==null){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oChannel_team_map.active; }
                _oPar=x_oCmd.Parameters.Add("@teamcode", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(string.IsNullOrEmpty(x_oChannel_team_map.teamcode)){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oChannel_team_map.teamcode; }
                _oPar=x_oCmd.Parameters.Add("@channel", global::System.Data.SqlDbType.NVarChar,10);
                _oPar.Direction=global::System.Data.ParameterDirection.Input;
                if(string.IsNullOrEmpty(x_oChannel_team_map.channel)){  _oPar.Value = global::System.DBNull.Value; }else{  _oPar.Value=x_oChannel_team_map.channel; }
                _oPar=x_oCmd.Parameters.Add("@RETURN_ID", global::System.Data.SqlDbType.Int);
                _oPar.Direction=global::System.Data.ParameterDirection.Output;
                x_oCmd.CommandType = CommandType.StoredProcedure;
                x_oConn.Open();
                _bResult = global::System.Convert.ToBoolean(x_oCmd.ExecuteNonQuery());
                x_oLAST_ID = Int32.Parse(x_oCmd.Parameters["@RETURN_ID"].Value.ToString());
            }
            catch (Exception exp) { string _sError = exp.ToString(); }
            finally
            {
                x_oConn.Close();
                x_oCmd.Dispose();
                x_oConn.Dispose();
            }
            return _bResult;
        }
        
        
        #region INSERT_CHANNEL_TEAM_MAP Store Procedures
        ///-- =============================================
        ///-- Author:		<Author,Philip SW>
        ///-- Create date: <Create Date 2009-03-24>
        ///-- Description:	<Description,CHANNEL_TEAM_MAP, Insert Store Procedures>
        ///-- =============================================
        /// <summary>
        /// INSERT_CHANNEL_TEAM_MAP Store Procedures
        /// </summary>
        /*
        USE MobileRetentionOrderDB_UAT
        GO
        IF OBJECT_ID ( 'INSERT_CHANNEL_TEAM_MAP', 'P' ) IS NOT NULL
        DROP PROCEDURE INSERT_CHANNEL_TEAM_MAP;
        GO
        CREATE PROCEDURE INSERT_CHANNEL_TEAM_MAP
        	-- Add the parameters for the stored procedure here
        @RETURN_ID int output,
        @teamcode nvarchar(10),
        @channel nvarchar(10),
        @active bit
        AS
        
        INSERT INTO  [CSSDB].[dbo].[channel_team_map]   ([active],[teamcode],[channel])  VALUES  (@active,@teamcode,@channel)
        IF @@IDENTITY IS NOT NULL
        BEGIN
        SELECT @RETURN_ID=@@IDENTITY
        RETURN @RETURN_ID
        END
        ELSE
        BEGIN
        SET @RETURN_ID=-1
        RETURN @RETURN_ID
        END
        
        GO
        */
        #endregion
        
        #endregion
        
        #region Delete
        /// <summary>
        /// Summary description for management table deleting
        /// </summary>
        
        public bool Delete(global::System.Nullable<int> x_iId)
        {
            return DeleteProc(n_oDB, x_iId);
        }
        
        public static bool Delete(MSSQLConnect x_oDB,System.Nullable<int> x_iId)
        {
            return DeleteProc(x_oDB, x_iId);
        }
        
        
        private static bool DeleteProc(MSSQLConnect x_oDB, System.Nullable<int> x_iId)
        {
            if (x_iId==null) { return false; }
            string _sQuery = "DELETE FROM  [CSSDB].[dbo].[channel_team_map]  WHERE [CSSDB].[dbo].[channel_team_map].[id]=@id";
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult=false;
            _oCmd.Parameters.Add("@id", global::System.Data.SqlDbType.Int).Value = x_iId;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        
        
        public bool DeleteAll()
        {
            if (n_oDB==null) { return false; }
            return Channel_team_mapManagerBase.DeleteAll(n_oDB);
        }
        
        public static bool DeleteAll(MSSQLConnect x_oDB)
        {
            if (x_oDB==null) { return false; }
            string _sQuery = "DELETE FROM  [CSSDB].[dbo].[channel_team_map]";
           
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        
        
        public bool DeleteFilter(string x_sFilter)
        {
            return DeleteFilter(n_oDB,x_sFilter);
        }
        
        public static bool DeleteFilter(MSSQLConnect x_oDB,string x_sFilter)
        {
            if (x_oDB==null) { return false; }
            if (!"".Equals(x_sFilter)){x_sFilter=" WHERE "+x_sFilter;}
            string _sQuery = "DELETE FROM [CSSDB].[dbo].[channel_team_map]"+x_sFilter;
            
            global::System.Data.SqlClient.SqlConnection _oConn = x_oDB.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_sQuery, _oConn);
            bool _bResult = false;
            try
            {
                _oConn.Open();
                _bResult = global::System.Convert.ToBoolean(_oCmd.ExecuteNonQuery());
            }
            catch {  }
            finally
            {
                _oConn.Close();
                _oCmd.Dispose();
                _oConn.Dispose();
            }
            return _bResult;
        }
        #endregion
    }
}


