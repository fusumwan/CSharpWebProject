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
using System.Data.SqlClient;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-07>
///-- Description:	<Database Base Class!>
///-- =============================================

namespace NEURON.ENTITY.FRAMEWORK.CONNECT
{
    public abstract class MSSQLConn
    {
        public bool bTransaction = false;
        public global::System.Data.SqlClient.SqlConnection ISessionConn = null;
        public global::System.Data.SqlClient.SqlCommand ISessionCmd = null;
        private string ConnectionString = string.Empty;
        private string ConnStrName = string.Empty;
        private string PathFileName = string.Empty;
        public bool bWithNoLock = false;
        public const string m_sTablePrefix = "";
        public const string m_sTablePrefix2 = "";
        public MSSQLConn()
        {
            if (!"".Equals(ConnStrName))
            {
                this.ConnectionString = GetConfigurationSetting();
            }
        }
        public MSSQLConn(string connStr)
        {
            this.ConnectionString = connStr;
        }
        public MSSQLConn(string catalog, string source, string username, string password)
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
        public global::System.Data.SqlClient.SqlConnection GetConnection()
        {
            if ("".Equals(this.ConnectionString)) this.ConnectionString = GetConfigurationSetting();
            return (new global::System.Data.SqlClient.SqlConnection(this.ConnectionString));
        }
        public void SetConnStr(string x_sConnStr)
        {
            ConnStrName = x_sConnStr;
            if (!"".Equals(ConnStrName))
            {
                this.ConnectionString = GetConfigurationSetting();
            }
        }


        public global::System.Data.SqlClient.SqlDataReader GetSearch(string x_sQuery)
        {
            global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection();
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(x_sQuery, _oConn);
            _oCmd.CommandTimeout = 99999;
            if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
            _oConn.Open();
            return _oCmd.ExecuteReader(CommandBehavior.CloseConnection);
            /*
            try
            {
                _oConn.Open();
                return _oCmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                _oConn.Close();
                _oConn.Dispose();
            }
            return null;
            */

            //try{ _oConn.Open();} catch(Exception e){ SystemError.CreateErrorLog("SQL:" + x_sQuery + "  \r\n" + e.ToString());}

        }

        public global::System.Data.SqlClient.SqlDataReader GetSearch(String strTable, String strFields, String strWhere, String strGroup, String strOrder)
        {
            global::System.Text.StringBuilder _oQueryStr = new global::System.Text.StringBuilder();
            global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection();
            
            if (!string.IsNullOrEmpty(strFields))
            {
                _oQueryStr.Append("SELECT ");
                _oQueryStr.Append(strFields);
                _oQueryStr.Append(" FROM ");
                _oQueryStr.Append(strTable);
                if (bWithNoLock) { _oQueryStr.Append(" WITH (NOLOCK) "); }
            }
            else
            {
                _oQueryStr.Append("SELECT * FROM ");
                _oQueryStr.Append(strTable);
                if (bWithNoLock) { _oQueryStr.Append(" WITH (NOLOCK) "); }
            }
            if (!string.IsNullOrEmpty(strWhere))
            {
                _oQueryStr.Append(" WHERE ");
                _oQueryStr.Append(strWhere);
            }
            if (!string.IsNullOrEmpty(strGroup))
            {
                _oQueryStr.Append(" GROUP BY ");
                _oQueryStr.Append(strGroup);
            }
            if (!string.IsNullOrEmpty(strOrder))
            {
                _oQueryStr.Append(" ORDER BY ");
                _oQueryStr.Append(strOrder);
            }
            global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(_oQueryStr.ToString(), _oConn);
            _oCmd.CommandTimeout = 99999;
            if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
            _oConn.Open();
            return _oCmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public ArrayList GetSelArrData(String strTable, String strFields, String strWhere, String strGroup, String strOrder)
        {
            String myQueryString = string.Empty;
            ArrayList array = new ArrayList();
            global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection();
            if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
            _oConn.Open();
            strTable = "[" + strTable + "]";
            try
            {
                if (!string.IsNullOrEmpty(strFields))
                {
                    myQueryString = "SELECT " + strFields + " FROM " + strTable;
                    if (bWithNoLock) { myQueryString += " with (nolock) "; }
                }
                else
                {
                    myQueryString = "SELECT * FROM " + strTable;
                    if (bWithNoLock) { myQueryString += " with (nolock) "; }
                }
                if (!string.IsNullOrEmpty(strWhere))
                {
                    myQueryString = myQueryString + " WHERE " + strWhere;
                }

                if (!string.IsNullOrEmpty(strGroup))
                {
                    myQueryString = myQueryString + " GROUP BY " + strGroup;
                }
                if (!string.IsNullOrEmpty(strOrder))
                {
                    myQueryString = myQueryString + " ORDER BY " + strOrder;
                }
                global::System.Data.SqlClient.SqlCommand cmd = new global::System.Data.SqlClient.SqlCommand(myQueryString, _oConn);
                cmd.CommandTimeout = 99999;
                global::System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
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
        public global::System.Data.DataSet GetDataSet(String strTable, String strFields, String strWhere, String strGroup, String strOrder, String strDataSetName)
        {
            String myQueryString = "";
            global::System.Data.DataSet dSet = new global::System.Data.DataSet();

            using (global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection())
            {
                try
                {
                    if (!string.IsNullOrEmpty(strFields))
                    {
                        myQueryString = "SELECT " + strFields + " FROM " + strTable;
                        if (bWithNoLock) { myQueryString += " with (nolock) "; }
                    }
                    else
                    {
                        myQueryString = "SELECT * FROM " + strTable;
                        if (bWithNoLock) { myQueryString += " with (nolock) "; }
                    }
                    if (!string.IsNullOrEmpty(strWhere))
                    {
                        myQueryString = myQueryString + " WHERE " + strWhere;
                    }
                    if (!string.IsNullOrEmpty(strGroup))
                    {
                        myQueryString = myQueryString + " GROUP BY " + strGroup;
                    }
                    if (!string.IsNullOrEmpty(strOrder))
                    {
                        myQueryString = myQueryString + " ORDER BY " + strOrder;
                    }
                    if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                    _oConn.Open();
                    global::System.Data.SqlClient.SqlDataAdapter myAdapter = new global::System.Data.SqlClient.SqlDataAdapter(myQueryString, _oConn);
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
            }
            return (dSet);
        }
        public global::System.Data.DataSet GetDS(String query)
        {
            global::System.Data.DataSet dSet = new global::System.Data.DataSet();
            if (query == string.Empty)
                return (dSet);
            global::System.Data.SqlClient.SqlConnection _oConn = new global::System.Data.SqlClient.SqlConnection(this.ConnectionString);
            try
            {
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                global::System.Data.SqlClient.SqlDataAdapter myAdapter = new global::System.Data.SqlClient.SqlDataAdapter(query, _oConn);
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


        
        protected SqlCommand CommandFile(string x_sSelect,SqlParameter[] x_oParmes,Boolean x_bNotificationAutoEnlist){
            SqlCommand _oCmd=new SqlCommand(x_sSelect);
            for(int i=0;i<x_oParmes.Length;i++){
                _oCmd.Parameters.Add(x_oParmes[i]);
            }
            _oCmd.NotificationAutoEnlist = x_bNotificationAutoEnlist;
            return _oCmd;
        }

        public DataSet GetDs(string x_sSelect,SqlParameter[] x_oParmes,string x_sTableName, Boolean x_bNotificationAutoEnlist)
        {
            DataSet _oDs = new DataSet();
            try
            {
                global::System.Data.SqlClient.SqlConnection _oConn  = new global::System.Data.SqlClient.SqlConnection(this.ConnectionString);
                global::System.Data.SqlClient.SqlDataAdapter _oAdapter = new SqlDataAdapter();
                _oAdapter.SelectCommand = CommandFile(x_sSelect, x_oParmes, x_bNotificationAutoEnlist);
                SqlCommandBuilder _oScb = new SqlCommandBuilder(_oAdapter);
                _oAdapter.Fill(_oDs, x_sTableName);
            }
            catch (Exception Exp)
            {
                SystemError.CreateErrorLog(Exp.ToString());
            }
            return _oDs;
        }

        public bool UpdateDs(string x_sSelect, Boolean x_bNotificationAutoEnlist, DataTable x_oDt)
        {
            bool _bResult = false;
            int i = 0;
            try
            {
                SqlDataAdapter _oAdapter = new SqlDataAdapter();
                if (!string.IsNullOrEmpty(x_sSelect))
                {
                    SqlConnection _oConn = new SqlConnection(this.ConnectionStr);
                    _oAdapter.SelectCommand = CommandFile(x_sSelect, null, x_bNotificationAutoEnlist);
                    SqlCommandBuilder _oScb = new SqlCommandBuilder(_oAdapter);
                }
                if (x_oDt!=null)
                {
                    i = _oAdapter.Update(x_oDt);
                }
                if (i > 0)
                {
                    _bResult = true;
                }
            }
            catch (Exception Exp) {
                SystemError.CreateErrorLog(Exp.ToString());
            }
            return _bResult;
        }

        public void BatchUpdate(string x_sSelect, SqlParameter[] x_oParmes, DataTable x_oDt, Int32 x_iBatchSize, Boolean x_bNotificationAutoEnlist)
        {
            SqlDataAdapter _oAdapter = new SqlDataAdapter();
            if (!string.IsNullOrEmpty(x_sSelect))
            {
                SqlConnection _oConn = new SqlConnection(this.ConnectionStr);
                _oAdapter.SelectCommand = CommandFile(x_sSelect, null, x_bNotificationAutoEnlist);
                SqlCommandBuilder _oScb = new SqlCommandBuilder(_oAdapter);
                _oAdapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.None;
                _oAdapter.InsertCommand.UpdatedRowSource = UpdateRowSource.None;
                _oAdapter.DeleteCommand.UpdatedRowSource = UpdateRowSource.None;

                // Set the batch size.
                _oAdapter.UpdateBatchSize = x_iBatchSize;

                // Execute the update.
                _oAdapter.Update(x_oDt);
            }
        }



        public bool Delete(string strTable, string where_key)
        {
            string query = "DELETE FROM " + strTable + " WHERE ";
            query += where_key;
            return this.ExplicitNonQuery(query);
        }
        public bool Delete(string query)
        {
            return this.ExplicitNonQuery(query);
        }


        public string GetExecuteScalar(string x_sQuery)
        {
            string _sResult = string.Empty;
            using (global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection())
            {
                global::System.Data.SqlClient.SqlCommand _oCmd = new global::System.Data.SqlClient.SqlCommand(x_sQuery, _oConn);
                _oCmd.CommandTimeout = 99999;

                try
                {
                    if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                    _oConn.Open();
                    _sResult = _oCmd.ExecuteScalar().ToString();
                }
                catch(Exception exp) 
                {
                    string error = exp.ToString();
                }
                finally
                {
                    _oCmd.Dispose();
                    _oConn.Close();
                    _oConn.Dispose();
                }
            }
            return _sResult;
        }



        public bool ExplicitNonQuery(string query)
        {
            using (global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection())
            {
                if (_oConn.State == ConnectionState.Open) { _oConn.Close(); }
                _oConn.Open();
                try
                {
                    global::System.Data.SqlClient.SqlCommand cmd = new global::System.Data.SqlClient.SqlCommand(query, _oConn);
                    cmd.CommandTimeout = 99999;
                    int result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return result > 0;
                }
                catch (SqlException ex)
                {
                    string error = ex.ToString();
                }
                finally
                {
                    _oConn.Close();
                    _oConn.Dispose();
                }
            }
            return false;
        }

        public bool ExplicitNonQuery(global::System.Data.SqlClient.SqlCommand cmd)
        {
            int result = -1;
            global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection();
            cmd.CommandTimeout = 99999;
            if (_oConn.State == ConnectionState.Open) _oConn.Close();
            _oConn.Open();
            try
            {
                cmd.Connection = _oConn;
                result = cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SqlException ex)
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
        public int ExplicitNonQueryLastID(global::System.Data.SqlClient.SqlCommand cmd)
        {
            int result = -1;
            global::System.Data.SqlClient.SqlConnection _oConn = this.GetConnection();
            cmd.CommandTimeout = 99999;
            if (_oConn.State == ConnectionState.Open) _oConn.Close();
            _oConn.Open();
            try
            {
                cmd.Connection = _oConn;
                result = cmd.ExecuteNonQuery();
                cmd = new global::System.Data.SqlClient.SqlCommand("SELECT @@IDENTITY AS 'ID'", _oConn);
                global::System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string re = reader[0].ToString();
                    if (re != string.Empty)
                        result = Convert.ToInt32(re);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (SqlException ex)
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
    }
}

