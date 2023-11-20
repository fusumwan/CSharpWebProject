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
///-- Create date: <Create Date 2010-05-31>
///-- Description:	<Description,Table :[EDFErrorCase],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class EDFErrorCaseDalDAO{
        
        #region RS
        public class EDFErrorCaseRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bMrt_no = false;
            public bool n_bStatus = false;
            public bool n_bActive = false;
            public bool n_bRemark = false;
            public bool n_bImei_status = false;
            public bool n_bImei_no = false;
            public bool n_bImei_remark = false;
            public bool n_bEdf_no = false;
            public bool n_bOrder_id = false;
            public bool n_bDid = false;
            public bool n_bDdate = false;
            public bool n_bError_msg = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (EDFErrorCase.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (EDFErrorCase.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (EDFErrorCase.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.cid);
                }
                if (this.n_bMrt_no  || x_bSetShowALL || (EDFErrorCase.Para.mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.mrt_no);
                }
                if (this.n_bStatus  || x_bSetShowALL || (EDFErrorCase.Para.status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStatus=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.status);
                }
                if (this.n_bActive  || x_bSetShowALL || (EDFErrorCase.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.active);
                }
                if (this.n_bRemark  || x_bSetShowALL || (EDFErrorCase.Para.remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.remark);
                }
                if (this.n_bImei_status  || x_bSetShowALL || (EDFErrorCase.Para.imei_status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_status=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.imei_status);
                }
                if (this.n_bImei_no  || x_bSetShowALL || (EDFErrorCase.Para.imei_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.imei_no);
                }
                if (this.n_bImei_remark  || x_bSetShowALL || (EDFErrorCase.Para.imei_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.imei_remark);
                }
                if (this.n_bEdf_no  || x_bSetShowALL || (EDFErrorCase.Para.edf_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdf_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.edf_no);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (EDFErrorCase.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.order_id);
                }
                if (this.n_bDid  || x_bSetShowALL || (EDFErrorCase.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.did);
                }
                if (this.n_bDdate  || x_bSetShowALL || (EDFErrorCase.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.ddate);
                }
                if (this.n_bError_msg  || x_bSetShowALL || (EDFErrorCase.Para.error_msg.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bError_msg=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(EDFErrorCase.Para.error_msg);
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
        
        public EDFErrorCaseDalDAO(){
        }
        ~EDFErrorCaseDalDAO(){
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
            _oSearchUtils.SetTable(EDFErrorCase.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<EDFErrorCaseEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, EDFErrorCaseRS x_oFieldsToReturn,EDFErrorCaseRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<EDFErrorCaseEntity> _oEDFErrorCaseList = new List<EDFErrorCaseEntity>();
                
                while (_oDATA.Read())
                {
                    EDFErrorCase _oEDFErrorCase = new EDFErrorCase();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.id])) { _oEDFErrorCase.SetId((global::System.Nullable<int>)_oDATA[EDFErrorCase.Para.id]); } else { _oEDFErrorCase.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.cdate])) { _oEDFErrorCase.SetCdate((global::System.Nullable<DateTime>)_oDATA[EDFErrorCase.Para.cdate]); } else { _oEDFErrorCase.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.cid])) { _oEDFErrorCase.SetCid((string)_oDATA[EDFErrorCase.Para.cid]); } else { _oEDFErrorCase.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.mrt_no])) { _oEDFErrorCase.SetMrt_no((string)_oDATA[EDFErrorCase.Para.mrt_no]); } else { _oEDFErrorCase.SetMrt_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStatus))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.status])) { _oEDFErrorCase.SetStatus((string)_oDATA[EDFErrorCase.Para.status]); } else { _oEDFErrorCase.SetStatus(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.active])) { _oEDFErrorCase.SetActive((global::System.Nullable<bool>)_oDATA[EDFErrorCase.Para.active]); } else { _oEDFErrorCase.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.remark])) { _oEDFErrorCase.SetRemark((string)_oDATA[EDFErrorCase.Para.remark]); } else { _oEDFErrorCase.SetRemark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_status))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.imei_status])) { _oEDFErrorCase.SetImei_status((string)_oDATA[EDFErrorCase.Para.imei_status]); } else { _oEDFErrorCase.SetImei_status(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.imei_no])) { _oEDFErrorCase.SetImei_no((string)_oDATA[EDFErrorCase.Para.imei_no]); } else { _oEDFErrorCase.SetImei_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.imei_remark])) { _oEDFErrorCase.SetImei_remark((string)_oDATA[EDFErrorCase.Para.imei_remark]); } else { _oEDFErrorCase.SetImei_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdf_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.edf_no])) { _oEDFErrorCase.SetEdf_no((string)_oDATA[EDFErrorCase.Para.edf_no]); } else { _oEDFErrorCase.SetEdf_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.order_id])) { _oEDFErrorCase.SetOrder_id((global::System.Nullable<int>)_oDATA[EDFErrorCase.Para.order_id]); } else { _oEDFErrorCase.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.did])) { _oEDFErrorCase.SetDid((string)_oDATA[EDFErrorCase.Para.did]); } else { _oEDFErrorCase.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.ddate])) { _oEDFErrorCase.SetDdate((global::System.Nullable<DateTime>)_oDATA[EDFErrorCase.Para.ddate]); } else { _oEDFErrorCase.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bError_msg))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[EDFErrorCase.Para.error_msg])) { _oEDFErrorCase.SetError_msg((string)_oDATA[EDFErrorCase.Para.error_msg]); } else { _oEDFErrorCase.SetError_msg(global::System.String.Empty); }
                    }
                    _oEDFErrorCaseList.Add(_oEDFErrorCase);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oEDFErrorCaseList;
            }
            return new List<EDFErrorCaseEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<EDFErrorCaseEntity> OrderBy(string x_sSort, IQueryable<EDFErrorCaseEntity> x_oEDFErrorCaseBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case EDFErrorCase.Para.id:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case EDFErrorCase.Para.cdate:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case EDFErrorCase.Para.cid:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case EDFErrorCase.Para.mrt_no:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.mrt_no).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.mrt_no).Select(c => c);
                break;
                case EDFErrorCase.Para.status:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.status).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.status).Select(c => c);
                break;
                case EDFErrorCase.Para.active:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case EDFErrorCase.Para.remark:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.remark).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.remark).Select(c => c);
                break;
                case EDFErrorCase.Para.imei_status:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.imei_status).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.imei_status).Select(c => c);
                break;
                case EDFErrorCase.Para.imei_no:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.imei_no).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.imei_no).Select(c => c);
                break;
                case EDFErrorCase.Para.imei_remark:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.imei_remark).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.imei_remark).Select(c => c);
                break;
                case EDFErrorCase.Para.edf_no:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.edf_no).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.edf_no).Select(c => c);
                break;
                case EDFErrorCase.Para.order_id:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case EDFErrorCase.Para.did:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case EDFErrorCase.Para.ddate:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case EDFErrorCase.Para.error_msg:
                if(x_bAsc)
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderBy(c => c.error_msg).Select(c => c);
                else
                    x_oEDFErrorCaseBaseList = x_oEDFErrorCaseBaseList.OrderByDescending(c => c.error_msg).Select(c => c);
                break;
            }
            return x_oEDFErrorCaseBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<EDFErrorCaseEntity> FindAll()
        {
            EDFErrorCaseEntity[] _oEDFErrorCasesArr=  EDFErrorCaseRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oEDFErrorCasesArr != null)
            {
                IList<EDFErrorCaseEntity> _oEDFErrorCasesList = (IList<EDFErrorCaseEntity>)_oEDFErrorCasesArr;
                return _oEDFErrorCasesList;
            }
            return new List<EDFErrorCaseEntity>();
        }
        
        public static IList<EDFErrorCaseEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<EDFErrorCaseEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<EDFErrorCaseEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<EDFErrorCaseEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            EDFErrorCaseRS x_oShowField = new EDFErrorCaseRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            EDFErrorCaseRS x_oSortField=new EDFErrorCaseRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(EDFErrorCase.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(EDFErrorCase.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            EDFErrorCaseRepositoryBase _oEDFErrorCaseRepositoryBase = new EDFErrorCaseRepositoryBase(GetDB());
            return _oEDFErrorCaseRepositoryBase.GetCount();
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


