using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
///-- Create date: <Create Date 2010-07-29>
///-- Description:	<Description,Table :[ErrorLog],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class ErrorLogDalDAO{
        
        #region RS
        public class ErrorLogRS
        {
            public bool n_bUid = false;
            public bool n_bId = false;
            public bool n_bIp = false;
            public bool n_bPage = false;
            public bool n_bStack_trace = false;
            public bool n_bLog_date = false;
            public bool n_bErr_msg = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bUid  || x_bSetShowALL || (ErrorLog.Para.uid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ErrorLog.Para.uid);
                }
                if (this.n_bId  || x_bSetShowALL || (ErrorLog.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ErrorLog.Para.id);
                }
                if (this.n_bIp  || x_bSetShowALL || (ErrorLog.Para.ip.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIp=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ErrorLog.Para.ip);
                }
                if (this.n_bPage  || x_bSetShowALL || (ErrorLog.Para.page.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPage=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ErrorLog.Para.page);
                }
                if (this.n_bStack_trace  || x_bSetShowALL || (ErrorLog.Para.stack_trace.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStack_trace=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ErrorLog.Para.stack_trace);
                }
                if (this.n_bLog_date  || x_bSetShowALL || (ErrorLog.Para.log_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLog_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ErrorLog.Para.log_date);
                }
                if (this.n_bErr_msg  || x_bSetShowALL || (ErrorLog.Para.err_msg.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bErr_msg=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ErrorLog.Para.err_msg);
                }
                return _oFR.ToString();
            }
            
            public string FieldsToReturn()
            {
                return this.FieldsToReturn(string.Empty,false);
            }
            
        }
        #endregion
        #region Constructor
        
        public ErrorLogDalDAO(){
        }
        ~ErrorLogDalDAO(){
            this.Release();
        }
        #endregion
        
        #region Search Engine
        public static global::System.Data.SqlClient.SqlDataReader DrSearch(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, string x_sFieldsToReturn,string x_sSortByField,bool x_bAscDirection)
        {
            SearchUtils _oSearchUtils = new SearchUtils();
            _oSearchUtils.SetSearchItems(x_oSearchItems);
            _oSearchUtils.SetRowFilter(x_sRowFilter);
            _oSearchUtils.SetStart(x_lStart);
            _oSearchUtils.SetLimit(x_lLimit);
            _oSearchUtils.SetFieldsToReturn(x_sFieldsToReturn);
            _oSearchUtils.SetOrderByField(x_sSortByField);
            _oSearchUtils.SetAscDirection(x_bAscDirection);
            _oSearchUtils.SetTable(ErrorLog.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<ErrorLogEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, ErrorLogRS x_oFieldsToReturn,ErrorLogRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<ErrorLogEntity> _oErrorLogList = new List<ErrorLogEntity>();
                
                while (_oDATA.Read())
                {
                    ErrorLog _oErrorLog = new ErrorLog();
                    if ((true).Equals(x_oFieldsToReturn.n_bUid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ErrorLog.Para.uid])) { _oErrorLog.SetUid((string)_oDATA[ErrorLog.Para.uid]); } else { _oErrorLog.SetUid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ErrorLog.Para.id])) { _oErrorLog.SetId((global::System.Nullable<int>)_oDATA[ErrorLog.Para.id]); } else { _oErrorLog.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIp))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ErrorLog.Para.ip])) { _oErrorLog.SetIp((string)_oDATA[ErrorLog.Para.ip]); } else { _oErrorLog.SetIp(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPage))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ErrorLog.Para.page])) { _oErrorLog.SetPage((string)_oDATA[ErrorLog.Para.page]); } else { _oErrorLog.SetPage(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStack_trace))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ErrorLog.Para.stack_trace])) { _oErrorLog.SetStack_trace((string)_oDATA[ErrorLog.Para.stack_trace]); } else { _oErrorLog.SetStack_trace(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLog_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ErrorLog.Para.log_date])) { _oErrorLog.SetLog_date((global::System.Nullable<DateTime>)_oDATA[ErrorLog.Para.log_date]); } else { _oErrorLog.SetLog_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bErr_msg))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ErrorLog.Para.err_msg])) { _oErrorLog.SetErr_msg((string)_oDATA[ErrorLog.Para.err_msg]); } else { _oErrorLog.SetErr_msg(global::System.String.Empty); }
                    }
                    _oErrorLogList.Add(_oErrorLog);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oErrorLogList;
            }
            return new List<ErrorLogEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<ErrorLogEntity> OrderBy(string x_sSort, IQueryable<ErrorLogEntity> x_oErrorLogBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case ErrorLog.Para.uid:
                if(x_bAsc)
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderBy(c => c.uid).Select(c => c);
                else
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderByDescending(c => c.uid).Select(c => c);
                break;
                case ErrorLog.Para.id:
                if(x_bAsc)
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case ErrorLog.Para.ip:
                if(x_bAsc)
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderBy(c => c.ip).Select(c => c);
                else
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderByDescending(c => c.ip).Select(c => c);
                break;
                case ErrorLog.Para.page:
                if(x_bAsc)
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderBy(c => c.page).Select(c => c);
                else
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderByDescending(c => c.page).Select(c => c);
                break;
                case ErrorLog.Para.stack_trace:
                if(x_bAsc)
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderBy(c => c.stack_trace).Select(c => c);
                else
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderByDescending(c => c.stack_trace).Select(c => c);
                break;
                case ErrorLog.Para.log_date:
                if(x_bAsc)
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderBy(c => c.log_date).Select(c => c);
                else
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderByDescending(c => c.log_date).Select(c => c);
                break;
                case ErrorLog.Para.err_msg:
                if(x_bAsc)
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderBy(c => c.err_msg).Select(c => c);
                else
                    x_oErrorLogBaseList = x_oErrorLogBaseList.OrderByDescending(c => c.err_msg).Select(c => c);
                break;
            }
            return x_oErrorLogBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<ErrorLogEntity> FindAll()
        {
            ErrorLogEntity[] _oErrorLogsArr=  ErrorLogRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oErrorLogsArr != null)
            {
                IList<ErrorLogEntity> _oErrorLogsList = (IList<ErrorLogEntity>)_oErrorLogsArr;
                return _oErrorLogsList;
            }
            return new List<ErrorLogEntity>();
        }
        
        public static IList<ErrorLogEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<ErrorLogEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<ErrorLogEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<ErrorLogEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            ErrorLogRS x_oShowField = new ErrorLogRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            ErrorLogRS x_oSortField=new ErrorLogRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(ErrorLog.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(ErrorLog.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            ErrorLogRepositoryBase _oErrorLogRepositoryBase = new ErrorLogRepositoryBase(GetDB());
            return _oErrorLogRepositoryBase.GetCount();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr(Configurator.DBName.MobileRetentionOrderDB + ((Configurator.IsUat()) ? "2" : string.Empty));
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


