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
///-- Description:	<Description,Table :[CallListUploadMrtNo],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class CallListUploadMrtNoDalDAO{
        
        #region RS
        public class CallListUploadMrtNoRS
        {
            public bool n_bCdate = false;
            public bool n_bMrt_no = false;
            public bool n_bCall_list_program_id = false;
            public bool n_bId = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bCdate  || x_bSetShowALL || (CallListUploadMrtNo.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadMrtNo.Para.cdate);
                }
                if (this.n_bMrt_no  || x_bSetShowALL || (CallListUploadMrtNo.Para.mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadMrtNo.Para.mrt_no);
                }
                if (this.n_bCall_list_program_id  || x_bSetShowALL || (CallListUploadMrtNo.Para.call_list_program_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCall_list_program_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadMrtNo.Para.call_list_program_id);
                }
                if (this.n_bId  || x_bSetShowALL || (CallListUploadMrtNo.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(CallListUploadMrtNo.Para.id);
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
        
        public CallListUploadMrtNoDalDAO(){
        }
        ~CallListUploadMrtNoDalDAO(){
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
            _oSearchUtils.SetTable(CallListUploadMrtNo.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<CallListUploadMrtNoEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, CallListUploadMrtNoRS x_oFieldsToReturn,CallListUploadMrtNoRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<CallListUploadMrtNoEntity> _oCallListUploadMrtNoList = new List<CallListUploadMrtNoEntity>();
                
                while (_oDATA.Read())
                {
                    CallListUploadMrtNo _oCallListUploadMrtNo = new CallListUploadMrtNo();
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadMrtNo.Para.cdate])) { _oCallListUploadMrtNo.SetCdate((global::System.Nullable<DateTime>)_oDATA[CallListUploadMrtNo.Para.cdate]); } else { _oCallListUploadMrtNo.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadMrtNo.Para.mrt_no])) { _oCallListUploadMrtNo.SetMrt_no((string)_oDATA[CallListUploadMrtNo.Para.mrt_no]); } else { _oCallListUploadMrtNo.SetMrt_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCall_list_program_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadMrtNo.Para.call_list_program_id])) { _oCallListUploadMrtNo.SetCall_list_program_id((global::System.Nullable<long>)_oDATA[CallListUploadMrtNo.Para.call_list_program_id]); } else { _oCallListUploadMrtNo.SetCall_list_program_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[CallListUploadMrtNo.Para.id])) { _oCallListUploadMrtNo.SetId((global::System.Nullable<long>)_oDATA[CallListUploadMrtNo.Para.id]); } else { _oCallListUploadMrtNo.SetId(null); }
                    }
                    _oCallListUploadMrtNoList.Add(_oCallListUploadMrtNo);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oCallListUploadMrtNoList;
            }
            return new List<CallListUploadMrtNoEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<CallListUploadMrtNoEntity> OrderBy(string x_sSort, IQueryable<CallListUploadMrtNoEntity> x_oCallListUploadMrtNoBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case CallListUploadMrtNo.Para.cdate:
                if(x_bAsc)
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case CallListUploadMrtNo.Para.mrt_no:
                if(x_bAsc)
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderBy(c => c.mrt_no).Select(c => c);
                else
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderByDescending(c => c.mrt_no).Select(c => c);
                break;
                case CallListUploadMrtNo.Para.call_list_program_id:
                if(x_bAsc)
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderBy(c => c.call_list_program_id).Select(c => c);
                else
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderByDescending(c => c.call_list_program_id).Select(c => c);
                break;
                case CallListUploadMrtNo.Para.id:
                if(x_bAsc)
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oCallListUploadMrtNoBaseList = x_oCallListUploadMrtNoBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
            }
            return x_oCallListUploadMrtNoBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<CallListUploadMrtNoEntity> FindAll()
        {
            CallListUploadMrtNoEntity[] _oCallListUploadMrtNosArr=  CallListUploadMrtNoRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oCallListUploadMrtNosArr != null)
            {
                IList<CallListUploadMrtNoEntity> _oCallListUploadMrtNosList = (IList<CallListUploadMrtNoEntity>)_oCallListUploadMrtNosArr;
                return _oCallListUploadMrtNosList;
            }
            return new List<CallListUploadMrtNoEntity>();
        }
        
        public static IList<CallListUploadMrtNoEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<CallListUploadMrtNoEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<CallListUploadMrtNoEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<CallListUploadMrtNoEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            CallListUploadMrtNoRS x_oShowField = new CallListUploadMrtNoRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            CallListUploadMrtNoRS x_oSortField=new CallListUploadMrtNoRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(CallListUploadMrtNo.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(CallListUploadMrtNo.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            CallListUploadMrtNoRepositoryBase _oCallListUploadMrtNoRepositoryBase = new CallListUploadMrtNoRepositoryBase(GetDB());
            return _oCallListUploadMrtNoRepositoryBase.GetCount();
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


