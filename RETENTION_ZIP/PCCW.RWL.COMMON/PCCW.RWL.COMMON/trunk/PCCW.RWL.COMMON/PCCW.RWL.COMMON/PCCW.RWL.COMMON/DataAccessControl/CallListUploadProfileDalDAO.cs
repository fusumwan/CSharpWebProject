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
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2011-09-15>
///-- Description:	<Description,Table :[CallListUploadProfile],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class CallListUploadProfileDalDAO{
        
        #region RS
        public class CallListUploadProfileRS
        {
            public bool n_bSdate = false;
            public bool n_bId = false;
            public bool n_bCall_list_program_id = false;
            public bool n_bIssue_type = false;
            public bool n_bActive = false;
            public bool n_bEdate = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bSdate  || x_bSetShowALL || (CallListUploadProfile.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadProfile.Para.sdate);
                }
                if (this.n_bId  || x_bSetShowALL || (CallListUploadProfile.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadProfile.Para.id);
                }
                if (this.n_bCall_list_program_id  || x_bSetShowALL || (CallListUploadProfile.Para.call_list_program_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCall_list_program_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadProfile.Para.call_list_program_id);
                }
                if (this.n_bIssue_type  || x_bSetShowALL || (CallListUploadProfile.Para.issue_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIssue_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadProfile.Para.issue_type);
                }
                if (this.n_bActive  || x_bSetShowALL || (CallListUploadProfile.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadProfile.Para.active);
                }
                if (this.n_bEdate  || x_bSetShowALL || (CallListUploadProfile.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadProfile.Para.edate);
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
        
        public CallListUploadProfileDalDAO(){
        }
        ~CallListUploadProfileDalDAO(){
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
            _oSearchUtils.SetTable(CallListUploadProfile.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<CallListUploadProfileEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, CallListUploadProfileRS x_oFieldsToReturn,CallListUploadProfileRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<CallListUploadProfileEntity> _oCallListUploadProfileList = new List<CallListUploadProfileEntity>();
                
                while (_oDATA.Read())
                {
                    CallListUploadProfile _oCallListUploadProfile = new CallListUploadProfile();
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadProfile.Para.sdate])) { _oCallListUploadProfile.SetSdate((global::System.Nullable<DateTime>)_oDATA[CallListUploadProfile.Para.sdate]); } else { _oCallListUploadProfile.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadProfile.Para.id])) { _oCallListUploadProfile.SetId((global::System.Nullable<long>)_oDATA[CallListUploadProfile.Para.id]); } else { _oCallListUploadProfile.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCall_list_program_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadProfile.Para.call_list_program_id])) { _oCallListUploadProfile.SetCall_list_program_id((global::System.Nullable<long>)_oDATA[CallListUploadProfile.Para.call_list_program_id]); } else { _oCallListUploadProfile.SetCall_list_program_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIssue_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadProfile.Para.issue_type])) { _oCallListUploadProfile.SetIssue_type((string)_oDATA[CallListUploadProfile.Para.issue_type]); } else { _oCallListUploadProfile.SetIssue_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadProfile.Para.active])) { _oCallListUploadProfile.SetActive((global::System.Nullable<bool>)_oDATA[CallListUploadProfile.Para.active]); } else { _oCallListUploadProfile.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadProfile.Para.edate])) { _oCallListUploadProfile.SetEdate((global::System.Nullable<DateTime>)_oDATA[CallListUploadProfile.Para.edate]); } else { _oCallListUploadProfile.SetEdate(null); }
                    }
                    _oCallListUploadProfileList.Add(_oCallListUploadProfile);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oCallListUploadProfileList;
            }
            return new List<CallListUploadProfileEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<CallListUploadProfileEntity> OrderBy(string x_sSort, IQueryable<CallListUploadProfileEntity> x_oCallListUploadProfileBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case CallListUploadProfile.Para.sdate:
                if(x_bAsc)
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
                case CallListUploadProfile.Para.id:
                if(x_bAsc)
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case CallListUploadProfile.Para.call_list_program_id:
                if(x_bAsc)
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderBy(c => c.call_list_program_id).Select(c => c);
                else
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderByDescending(c => c.call_list_program_id).Select(c => c);
                break;
                case CallListUploadProfile.Para.issue_type:
                if(x_bAsc)
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderBy(c => c.issue_type).Select(c => c);
                else
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderByDescending(c => c.issue_type).Select(c => c);
                break;
                case CallListUploadProfile.Para.active:
                if(x_bAsc)
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case CallListUploadProfile.Para.edate:
                if(x_bAsc)
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oCallListUploadProfileBaseList = x_oCallListUploadProfileBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
            }
            return x_oCallListUploadProfileBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<CallListUploadProfileEntity> FindAll()
        {
            CallListUploadProfileEntity[] _oCallListUploadProfilesArr=  CallListUploadProfileRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oCallListUploadProfilesArr != null)
            {
                IList<CallListUploadProfileEntity> _oCallListUploadProfilesList = (IList<CallListUploadProfileEntity>)_oCallListUploadProfilesArr;
                return _oCallListUploadProfilesList;
            }
            return new List<CallListUploadProfileEntity>();
        }
        
        public static IList<CallListUploadProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<CallListUploadProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<CallListUploadProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<CallListUploadProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            CallListUploadProfileRS x_oShowField = new CallListUploadProfileRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            CallListUploadProfileRS x_oSortField=new CallListUploadProfileRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(CallListUploadProfile.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(CallListUploadProfile.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            CallListUploadProfileRepositoryBase _oCallListUploadProfileRepositoryBase = new CallListUploadProfileRepositoryBase(GetDB());
            return _oCallListUploadProfileRepositoryBase.GetCount();
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


