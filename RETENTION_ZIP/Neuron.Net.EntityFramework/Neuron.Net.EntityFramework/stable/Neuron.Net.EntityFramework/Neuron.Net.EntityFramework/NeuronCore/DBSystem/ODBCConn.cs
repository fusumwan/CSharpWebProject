using System;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Data.Odbc;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using System.Data.SqlClient;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Database Base Class!>
///-- =============================================

namespace NEURON.ENTITY.FRAMEWORK.CONNECT{
    public abstract class ODBCConn
    {
        public bool bTransaction = false;
        public global::System.Data.Odbc.OdbcConnection ISessionConn = null;
        public global::System.Data.Odbc.OdbcCommand ISessionCmd = null;
        private string ConnectionString = string.Empty;
        private string ConnStrName=string.Empty;
        private string PathFileName = string.Empty;
        public bool bWithNoLock = false;
        public const string m_sTablePrefix="";
        public const string m_sTablePrefix2="";
        public ODBCConn()
        {
            if(!"".Equals(ConnStrName)){
                this.ConnectionString = GetConfigurationSetting();
            }
        }
        public ODBCConn(string connStr)
        {
            this.ConnectionString = connStr;
        }
        public ODBCConn(string catalog, string source, string username, string password)
        {
            this.ConnectionString = @"Initial Catalog=" + catalog +
            @";Data Source=" + source +
            @";User ID=" + username +
            @";Password=" + password;
        }
        public string GetConfigurationSetting()
        {
            /*  Add References ->[.NET]-> System.Configuration.all   */
            return ConfigurationManager.ConnectionStrings[ConnStrName].ToString();
        }
        public string ConnectionStr
        {
            get { return this.ConnectionString; }
        }
        public global::System.Data.Odbc.OdbcConnection GetConnection()
        {
            if ("".Equals(this.ConnectionString)) this.ConnectionString = GetConfigurationSetting();
            return (new global::System.Data.Odbc.OdbcConnection(this.ConnectionString));
        }
        public void SetConnStr(string x_sConnStr){
            ConnStrName=x_sConnStr;
            if(!"".Equals(ConnStrName)){
                this.ConnectionString = GetConfigurationSetting();
            }
        }
        
        public global::System.Data.Odbc.OdbcDataReader GetSearch(string x_sQuery)
        {
            global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection();
            global::System.Data.Odbc.OdbcCommand _oCmd = new global::System.Data.Odbc.OdbcCommand(x_sQuery, _oConn);
            if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
            _oConn.Open();
            return _oCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        
        public global::System.Data.Odbc.OdbcDataReader GetSearch(String strTable, String strFields, String strWhere, String strGroup, String strOrder)
        {
            global::System.Text.StringBuilder _oQueryStr = new global::System.Text.StringBuilder();
            global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection();
            if(!string.IsNullOrEmpty(strFields))
            {
                _oQueryStr.Append("SELECT ");
                _oQueryStr.Append(strFields);
                _oQueryStr.Append(" FROM ");
                _oQueryStr.Append(strTable);
                if (bWithNoLock){ _oQueryStr.Append(" with (nolock) ");}
            }
            else
            {
                _oQueryStr.Append("SELECT * FROM ");
                _oQueryStr.Append(strTable);
                if (bWithNoLock) { _oQueryStr.Append(" with (nolock) "); }
            }
            if(!string.IsNullOrEmpty(strWhere))
            {
                _oQueryStr.Append(" WHERE ");
                _oQueryStr.Append(strWhere);
            }
            if(!string.IsNullOrEmpty(strGroup))
            {
                _oQueryStr.Append(" GROUP BY ");
                _oQueryStr.Append(strGroup);
            }
            
            if(!string.IsNullOrEmpty(strOrder))
            {
                _oQueryStr.Append(" ORDER BY ");
                _oQueryStr.Append(strOrder);
            }
            global::System.Data.Odbc.OdbcCommand _oCmd = new global::System.Data.Odbc.OdbcCommand(_oQueryStr.ToString(), _oConn);
            if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
            _oConn.Open();
            return _oCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public ArrayList GetSelArrData(String strTable, String strFields, String strWhere, String strGroup, String strOrder)
        {
            String myQueryString = string.Empty;
            ArrayList array = new ArrayList();

            using(global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection()){
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                strTable = "[" + strTable + "]";
                try
                {
                    if(!string.IsNullOrEmpty(strFields))
                    {
                        myQueryString = "SELECT " + strFields + " FROM " + strTable;
                        if (bWithNoLock){ myQueryString += " with (nolock) ";}
                    }
                    else
                    {
                        myQueryString = "SELECT * FROM " + strTable;
                        if (bWithNoLock){ myQueryString += " with (nolock) ";}
                    }
                    if(!string.IsNullOrEmpty(strWhere))
                    {
                        myQueryString = myQueryString + " WHERE " + strWhere;
                    }
                    if(!string.IsNullOrEmpty(strGroup))
                    {
                        myQueryString = myQueryString + " GROUP BY " + strGroup;
                    }
                    if(!string.IsNullOrEmpty(strOrder))
                    {
                        myQueryString = myQueryString + " ORDER BY " + strOrder;
                    }
                    global::System.Data.Odbc.OdbcCommand cmd = new global::System.Data.Odbc.OdbcCommand(myQueryString, _oConn);
                    global::System.Data.Odbc.OdbcDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ArrayList a = new ArrayList();
                        for (int i = 0; i < reader.FieldCount; i++)
                        a.Add(reader[i]);
                        array.Add(a);
                    }
                    reader.Close();
                    cmd.Dispose();
                }
                catch (Exception exp)
                {
                    SystemError.CreateErrorLog(exp.ToString());
                    // Logger.Log("Error fetching records for the query:- " + strQuery + ". Possible cause:- " + exp.ToString());
                }
                finally
                {
                    _oConn.Close();
                }
                return array;
            }
        }
        public global::System.Data.DataSet GetDataSet(String strTable, String strFields, String strWhere, String strGroup, String strOrder, String strDataSetName)
        {
            String myQueryString = "";

            global::System.Data.DataSet dSet = new global::System.Data.DataSet();
            global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection();
            try
            {
                if(!string.IsNullOrEmpty(strFields))
                {
                    myQueryString = "SELECT " + strFields + " FROM " + strTable;
                    if (bWithNoLock){ myQueryString += " with (nolock) ";}
                }
                else
                {
                    myQueryString = "SELECT * FROM " + strTable;
                    if (bWithNoLock){ myQueryString += " with (nolock) ";}
                }
                if(!string.IsNullOrEmpty(strWhere))
                {
                    myQueryString = myQueryString + " WHERE " + strWhere;
                }
                if(!string.IsNullOrEmpty(strGroup))
                {
                    myQueryString = myQueryString + " GROUP BY " + strGroup;
                }
                if(!string.IsNullOrEmpty(strOrder))
                {
                    myQueryString = myQueryString + " ORDER BY " + strOrder;
                }
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                global::System.Data.Odbc.OdbcDataAdapter myAdapter = new global::System.Data.Odbc.OdbcDataAdapter(myQueryString, _oConn);
                myAdapter.Fill(dSet, strDataSetName);
            }
            catch (Exception exp)
            {
                // Logger.Log("Error fetching records for the query:- " + strQuery + ". Possible cause:- " + exp.ToString());
                
            }
            finally
            {
                _oConn.Close();
                _oConn.Dispose();
            }
            return (dSet);
        }
        public global::System.Data.DataSet GetDS(String query)
        {
            global::System.Data.DataSet dSet = new global::System.Data.DataSet();
            if (query == string.Empty)
            return (dSet);
            global::System.Data.Odbc.OdbcConnection _oConn = new global::System.Data.Odbc.OdbcConnection(this.ConnectionString);
            try
            {
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                global::System.Data.Odbc.OdbcDataAdapter myAdapter = new global::System.Data.Odbc.OdbcDataAdapter(query, _oConn);
                myAdapter.Fill(dSet);
                _oConn.Close();
            }
            catch (Exception exp)
            {
                // Logger.Log("Error fetching records for the query:- " + strQuery + ". Possible cause:- " + exp.ToString());
                SystemError.CreateErrorLog(exp.ToString());
                _oConn.Close();
                _oConn.Dispose();
            }
            return (dSet);
        }
        protected OdbcCommand CommandFile(string x_sSelect, OdbcParameter[] x_oParmes)
        {
            OdbcCommand _oCmd = new OdbcCommand(x_sSelect);
            for (int i = 0; i < x_oParmes.Length; i++)
            {
                _oCmd.Parameters.Add(x_oParmes[i]);
            }
 
            return _oCmd;
        }

        public DataSet GetDs(string x_sSelect, OdbcParameter[] x_oParmes, string x_sTableName, Boolean x_bNotificationAutoEnlist)
        {
            DataSet _oDs = new DataSet();
            try
            {
                global::System.Data.Odbc.OdbcConnection _oConn = new global::System.Data.Odbc.OdbcConnection(this.ConnectionString);
                global::System.Data.Odbc.OdbcDataAdapter _oAdapter = new OdbcDataAdapter();
                _oAdapter.SelectCommand = CommandFile(x_sSelect, x_oParmes);
                OdbcCommandBuilder _oScb = new OdbcCommandBuilder(_oAdapter);
                
                _oAdapter.Fill(_oDs, x_sTableName);
            }
            catch (Exception Exp)
            {
                SystemError.CreateErrorLog(Exp.ToString());
            }
            return _oDs;
        }

        public bool UpdateDs(string x_sSelect,  DataTable x_oDt)
        {
            bool _bResult = false;
            int i = 0;
            try
            {
                OdbcDataAdapter _oAdapter = new OdbcDataAdapter();
                if (!string.IsNullOrEmpty(x_sSelect))
                {
                    OdbcConnection _oConn = new OdbcConnection(this.ConnectionStr);
                    _oAdapter.SelectCommand = CommandFile(x_sSelect, null);
                    OdbcCommandBuilder _oScb = new OdbcCommandBuilder(_oAdapter);
                }
                if (x_oDt != null)
                {
                    i = _oAdapter.Update(x_oDt);
                }
                if (i > 0)
                {
                    _bResult = true;
                }
            }
            catch (Exception Exp)
            {
                SystemError.CreateErrorLog(Exp.ToString());
            }
            return _bResult;
        }

        public void BatchUpdate(string x_sSelect, SqlParameter[] x_oParmes, DataTable x_oDt, Int32 x_iBatchSize)
        {
            OdbcDataAdapter _oAdapter = new OdbcDataAdapter();
            if (!string.IsNullOrEmpty(x_sSelect))
            {
                OdbcConnection _oConn = new OdbcConnection(this.ConnectionStr);
                _oAdapter.SelectCommand = CommandFile(x_sSelect, null);
                OdbcCommandBuilder _oScb = new OdbcCommandBuilder(_oAdapter);
                _oAdapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;
                _oAdapter.InsertCommand.UpdatedRowSource = UpdateRowSource.None;
                _oAdapter.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the batch size.
                _oAdapter.UpdateBatchSize = x_iBatchSize;

                // Execute the update.
                _oAdapter.Update(x_oDt);
            }
        }


        public ArrayList Select(string table, string ordering)
        {
            return this.ExplicitQuery("SELECT * FROM " + table + ((bWithNoLock)? " with (nolock)  ":"")+" ORDER BY " + ordering,true);
        }
        public ArrayList Select(string query)
        {
            return this.ExplicitQuery(query,true);
        }
        public ArrayList Select(string query,bool bArr)
        {
            return this.ExplicitQuery(query,bArr);
        }
        public int Insert(string table, string[] schema, params object[] fields)
        {

            if (schema.Length != fields.Length)
            throw new ArgumentException("The number of fields does not match the size of the schema.");
            string query = "INSERT INTO " + table + " (";
            for (int i = 0; i < schema.Length; i++)
            {
                query += schema[i];
                if (i != schema.Length - 1)
                query += ",";
            }
            query += ") VALUES (";
            for (int i = 0; i < schema.Length; i++)
            {
                query += "@"+schema[i];
                if (i != schema.Length - 1)
                query += ",";
            }
            query += ")";
            global::System.Data.Odbc.OdbcCommand cmd = new global::System.Data.Odbc.OdbcCommand(query);
            for(int i=0;i<fields.Length;i++)
            cmd.Parameters.Add(new global::System.Data.Odbc.OdbcParameter("@" + schema[i], fields[i]));
            return this.ExplicitNonQueryLastID(cmd);
        }
        public bool Delete(string table, string[] keys, params object[] fields)
        {
            if (keys.Length != fields.Length)
            throw new ArgumentException("The number of fields does not match the number of keys.");
            string query = "DELETE FROM " + table + " WHERE ";
            for (int i = 0; i < fields.Length; i++)
            {
                query += keys[i] + " = " + Formatted(fields[i]);
                if (i != fields.Length - 1)
                query += " AND ";
            }
            return this.ExplicitNonQuery(query);
        }
        public bool Delete(string table, string where_key)
        {
            table = m_sTablePrefix + table;
            string query = "DELETE FROM " + table + " WHERE ";
            query += where_key;
            return this.ExplicitNonQuery(query);
        }
        public bool Delete(string query)
        {
            return this.ExplicitNonQuery(query);
        }
        public bool Update(string table, string[] schema, string[] keys, params object[] fields)
        {
            if (schema.Length != fields.Length)
            throw new ArgumentException("The number of fields does not match the size of the schema.");
            string query = "UPDATE " + table + " SET ";
            for (int i = 0; i < fields.Length; i++)
            {
                string fdata = (string)Formatted(fields[i]);
                if (fdata != string.Empty)
                {
                    query += schema[i] + " = " + fdata;
                    if (i != fields.Length - 1)
                    query += ",";
                }
            }
            if (keys.Length>0)
            {
                query += " WHERE ";
                for (int i = 0; i < keys.Length; i++)
                {
                    string fdata = keys[i];
                    if (fdata != string.Empty)
                    {
                        query += " "+fdata+" ";
                        if (i != keys.Length - 1)
                        query += " AND ";
                    }
                }
                
            }
            return this.ExplicitNonQuery(query);
        }
        
        public string GetExecuteScalar(string x_sQuery)
        {
            global::System.Data.Odbc.OdbcConnection _oConn=this.GetConnection();
            global::System.Data.Odbc.OdbcCommand _oCmd=new global::System.Data.Odbc.OdbcCommand(x_sQuery,_oConn);
            
            string _sResult=string.Empty;
            try{
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                _sResult = _oCmd.ExecuteScalar().ToString();
                }catch { }
                finally{
                    _oCmd.Dispose();
                    _oConn.Close();
                }
                return _sResult;
            }
            
            public bool Update(string query)
            {
                return this.ExplicitNonQuery(query);
            }
            
            public bool ExplicitNonQuery(string query)
            {
                global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection();
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                try
                {
                    global::System.Data.Odbc.OdbcCommand cmd = new global::System.Data.Odbc.OdbcCommand(query, _oConn);
                    int result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    string error = ex.ToString();
                }
                finally
                {
                    _oConn.Close();
                    _oConn.Dispose();
                }
                return false;
            }
            public string ExecuteNonQueryWithErrorMsg(string x_sQuery)
            {
                int rowCount;
                ConnectionState previousConnectionState = ConnectionState.Closed;
                string sErrorMsg = string.Empty;
                DbConnection _oConn = null;
                try
                {
                    _oConn = GetConnection();
                    if(_oConn.State==ConnectionState.Open) _oConn.Close();
                    if (_oConn.State == ConnectionState.Closed)
                    {
                        _oConn.Open();
                        previousConnectionState = _oConn.State;
                    }
                    DbCommand cmd = _oConn.CreateCommand();
                    cmd.CommandText = x_sQuery;
                    rowCount = cmd.ExecuteNonQuery();
                }
                catch (Exception oErr)
                {
                    sErrorMsg = oErr.Message;
                }
                finally
                {
                    if (previousConnectionState != ConnectionState.Closed)
                    {
                        _oConn.Close();
                        _oConn.Dispose();
                    }
                }
                return sErrorMsg;
            }
            public bool ExplicitNonQuery(global::System.Data.Odbc.OdbcCommand cmd)
            {
                int result = -1;
                global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection();
                if (_oConn.State == ConnectionState.Open) _oConn.Close();
                _oConn.Open();
                try
                {
                    cmd.Connection = _oConn;
                    result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    string error = ex.ToString();
                }
                finally
                {
                    _oConn.Close();
                    _oConn.Dispose();
                }
                return result > 0;
            }
            public int ExplicitNonQueryLastID(global::System.Data.Odbc.OdbcCommand cmd)
            {
                int result = -1;
                global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection();
                if (_oConn.State == ConnectionState.Open) _oConn.Close();
                _oConn.Open();
                try
                {
                    cmd.Connection = _oConn;
                    result = cmd.ExecuteNonQuery();
                    cmd = new global::System.Data.Odbc.OdbcCommand("SELECT @@IDENTITY AS 'ID'", _oConn);
                    global::System.Data.Odbc.OdbcDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string re = reader[0].ToString();
                        if (re != string.Empty)
                        result = Convert.ToInt32(re);
                    }
                    reader.Close();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    string error = ex.ToString();
                }
                finally
                {
                    _oConn.Close();
                    _oConn.Dispose();
                }
                return result;
            }
            protected abstract string Formatted(object o);
            public ArrayList ExplicitQuery(string query,bool bArr)
            {
                global::System.Data.Odbc.OdbcConnection _oConn = this.GetConnection();
                if (_oConn.State == ConnectionState.Open) _oConn.Close();
                _oConn.Open();
                try{
                    ArrayList array = new ArrayList();
                    global::System.Data.Odbc.OdbcDataReader reader;
                    global::System.Data.Odbc.OdbcCommand cmd = new global::System.Data.Odbc.OdbcCommand(query, _oConn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ArrayList a = new ArrayList();
                        Hashtable h = new Hashtable();
                        if (bArr)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                if (!reader.IsDBNull(i))
                                {
                                    string fdata = reader[i].ToString().Trim(' ');
                                    if (fdata != string.Empty){
                                        if (fdata == "NULL"){
                                            fdata = "NULL_WORD";
                                        }
                                        
                                        a.Add(fdata);
                                    }
                                    else
                                    a.Add("NULL");
                                }
                                else
                                a.Add("NULL");
                            }
                            array.Add(a);
                        }
                        else
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string fName = reader.GetName(i).ToString();
                                if (!reader.IsDBNull(i))
                                {
                                    string fdata = reader[i].ToString().Trim(' ');
                                    if (fdata != string.Empty)
                                    {
                                        if (fdata == "NULL"){
                                            fdata = "NULL_WORD";
                                        }
                                        if (!h.ContainsKey(fName)){
                                            h.Add(fName, fdata);
                                        }
                                    }
                                    else{
                                        if (!h.ContainsKey(fName)){
                                            h.Add(fName, "NULL");
                                        }
                                    }
                                }
                                else
                                {
                                    if (!h.ContainsKey(fName)){
                                        h.Add(fName, "NULL");
                                    }
                                }
                            }
                            array.Add(h);
                        }
                    }
                    reader.Close();
                    cmd.Dispose();
                    _oConn.Close();
                    return array;
                }
                catch (Exception ex)
                {
                    SystemError.CreateErrorLog(ex.ToString());
                    _oConn.Close();
                    return new ArrayList();
                }
            }
            public static global::System.Data.DataTable ConvertDataReaderToDataTable(global::System.Data.Odbc.OdbcDataReader dataReader)
            {
                global::System.Data.DataTable datatable = new DataTable();
                try
                {	
                    for (int i = 0; i < dataReader.FieldCount; i++)
                    {
                        DataColumn myDataColumn = new DataColumn();
                        myDataColumn.DataType = dataReader.GetFieldType(i);
                        myDataColumn.ColumnName = dataReader.GetName(i);
                        datatable.Columns.Add(myDataColumn);
                    }
                    while (dataReader.Read())
                    {
                        global::System.Data.DataRow myDataRow = datatable.NewRow();
                        for (int i = 0; i < dataReader.FieldCount; i++)
                        {
                            myDataRow[i] = dataReader[i].ToString();
                        }
                        datatable.Rows.Add(myDataRow);
                        myDataRow = null;
                    }
                    dataReader.Close();
                    return datatable;
                }
                catch (Exception ex)
                {
                    SystemError.CreateErrorLog(ex.Message);
                    throw new Exception(ex.Message, ex);
                }
            }
        }
    }

