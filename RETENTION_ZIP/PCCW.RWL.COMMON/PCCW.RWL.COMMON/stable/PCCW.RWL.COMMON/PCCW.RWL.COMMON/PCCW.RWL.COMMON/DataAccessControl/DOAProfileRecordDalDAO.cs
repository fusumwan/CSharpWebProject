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
///-- Create date: <Create Date 2010-04-20>
///-- Description:	<Description,Table :[DOAProfileRecord],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class DOAProfileRecordDalDAO{
        
        #region RS
        public class DOAProfileRecordRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bStatus = false;
            public bool n_bActive = false;
            public bool n_bImei_stock_remark = false;
            public bool n_bEdate = false;
            public bool n_bEdf_no = false;
            public bool n_bUsed = false;
            public bool n_bOrder_id = false;
            public bool n_bOrder_dn_remark = false;
            public bool n_bDdate = false;
            public bool n_bImei_no = false;
            public bool n_bOrder_remark = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (DOAProfileRecord.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (DOAProfileRecord.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (DOAProfileRecord.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (DOAProfileRecord.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.did);
                }
                if (this.n_bStatus  || x_bSetShowALL || (DOAProfileRecord.Para.status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStatus=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.status);
                }
                if (this.n_bActive  || x_bSetShowALL || (DOAProfileRecord.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.active);
                }
                if (this.n_bImei_stock_remark  || x_bSetShowALL || (DOAProfileRecord.Para.imei_stock_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_stock_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.imei_stock_remark);
                }
                if (this.n_bEdate  || x_bSetShowALL || (DOAProfileRecord.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.edate);
                }
                if (this.n_bEdf_no  || x_bSetShowALL || (DOAProfileRecord.Para.edf_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdf_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.edf_no);
                }
                if (this.n_bUsed  || x_bSetShowALL || (DOAProfileRecord.Para.used.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUsed=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.used);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (DOAProfileRecord.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.order_id);
                }
                if (this.n_bOrder_dn_remark  || x_bSetShowALL || (DOAProfileRecord.Para.order_dn_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_dn_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.order_dn_remark);
                }
                if (this.n_bDdate  || x_bSetShowALL || (DOAProfileRecord.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.ddate);
                }
                if (this.n_bImei_no  || x_bSetShowALL || (DOAProfileRecord.Para.imei_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.imei_no);
                }
                if (this.n_bOrder_remark  || x_bSetShowALL || (DOAProfileRecord.Para.order_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DOAProfileRecord.Para.order_remark);
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
        
        public DOAProfileRecordDalDAO(){
        }
        ~DOAProfileRecordDalDAO(){
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
            _oSearchUtils.SetTable(DOAProfileRecord.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<DOAProfileRecordEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, DOAProfileRecordRS x_oFieldsToReturn,DOAProfileRecordRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<DOAProfileRecordEntity> _oDOAProfileRecordList = new List<DOAProfileRecordEntity>();
                
                while (_oDATA.Read())
                {
                    DOAProfileRecord _oDOAProfileRecord = new DOAProfileRecord();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.id])) { _oDOAProfileRecord.SetId((global::System.Nullable<int>)_oDATA[DOAProfileRecord.Para.id]); } else { _oDOAProfileRecord.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.cdate])) { _oDOAProfileRecord.SetCdate((global::System.Nullable<DateTime>)_oDATA[DOAProfileRecord.Para.cdate]); } else { _oDOAProfileRecord.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.cid])) { _oDOAProfileRecord.SetCid((string)_oDATA[DOAProfileRecord.Para.cid]); } else { _oDOAProfileRecord.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.did])) { _oDOAProfileRecord.SetDid((string)_oDATA[DOAProfileRecord.Para.did]); } else { _oDOAProfileRecord.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStatus))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.status])) { _oDOAProfileRecord.SetStatus((string)_oDATA[DOAProfileRecord.Para.status]); } else { _oDOAProfileRecord.SetStatus(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.active])) { _oDOAProfileRecord.SetActive((global::System.Nullable<bool>)_oDATA[DOAProfileRecord.Para.active]); } else { _oDOAProfileRecord.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_stock_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.imei_stock_remark])) { _oDOAProfileRecord.SetImei_stock_remark((string)_oDATA[DOAProfileRecord.Para.imei_stock_remark]); } else { _oDOAProfileRecord.SetImei_stock_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.edate])) { _oDOAProfileRecord.SetEdate((global::System.Nullable<DateTime>)_oDATA[DOAProfileRecord.Para.edate]); } else { _oDOAProfileRecord.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdf_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.edf_no])) { _oDOAProfileRecord.SetEdf_no((string)_oDATA[DOAProfileRecord.Para.edf_no]); } else { _oDOAProfileRecord.SetEdf_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUsed))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.used])) { _oDOAProfileRecord.SetUsed((global::System.Nullable<bool>)_oDATA[DOAProfileRecord.Para.used]); } else { _oDOAProfileRecord.SetUsed(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.order_id])) { _oDOAProfileRecord.SetOrder_id((global::System.Nullable<int>)_oDATA[DOAProfileRecord.Para.order_id]); } else { _oDOAProfileRecord.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_dn_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.order_dn_remark])) { _oDOAProfileRecord.SetOrder_dn_remark((string)_oDATA[DOAProfileRecord.Para.order_dn_remark]); } else { _oDOAProfileRecord.SetOrder_dn_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.ddate])) { _oDOAProfileRecord.SetDdate((global::System.Nullable<DateTime>)_oDATA[DOAProfileRecord.Para.ddate]); } else { _oDOAProfileRecord.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.imei_no])) { _oDOAProfileRecord.SetImei_no((string)_oDATA[DOAProfileRecord.Para.imei_no]); } else { _oDOAProfileRecord.SetImei_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DOAProfileRecord.Para.order_remark])) { _oDOAProfileRecord.SetOrder_remark((string)_oDATA[DOAProfileRecord.Para.order_remark]); } else { _oDOAProfileRecord.SetOrder_remark(global::System.String.Empty); }
                    }
                    _oDOAProfileRecordList.Add(_oDOAProfileRecord);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oDOAProfileRecordList;
            }
            return new List<DOAProfileRecordEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<DOAProfileRecordEntity> OrderBy(string x_sSort, IQueryable<DOAProfileRecordEntity> x_oDOAProfileRecordBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case DOAProfileRecord.Para.id:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case DOAProfileRecord.Para.cdate:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case DOAProfileRecord.Para.cid:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case DOAProfileRecord.Para.did:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case DOAProfileRecord.Para.status:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.status).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.status).Select(c => c);
                break;
                case DOAProfileRecord.Para.active:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case DOAProfileRecord.Para.imei_stock_remark:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.imei_stock_remark).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.imei_stock_remark).Select(c => c);
                break;
                case DOAProfileRecord.Para.edate:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case DOAProfileRecord.Para.edf_no:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.edf_no).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.edf_no).Select(c => c);
                break;
                case DOAProfileRecord.Para.used:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.used).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.used).Select(c => c);
                break;
                case DOAProfileRecord.Para.order_id:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case DOAProfileRecord.Para.order_dn_remark:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.order_dn_remark).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.order_dn_remark).Select(c => c);
                break;
                case DOAProfileRecord.Para.ddate:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case DOAProfileRecord.Para.imei_no:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.imei_no).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.imei_no).Select(c => c);
                break;
                case DOAProfileRecord.Para.order_remark:
                if(x_bAsc)
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderBy(c => c.order_remark).Select(c => c);
                else
                    x_oDOAProfileRecordBaseList = x_oDOAProfileRecordBaseList.OrderByDescending(c => c.order_remark).Select(c => c);
                break;
            }
            return x_oDOAProfileRecordBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<DOAProfileRecordEntity> FindAll()
        {
            DOAProfileRecordEntity[] _oDOAProfileRecordsArr=  DOAProfileRecordRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oDOAProfileRecordsArr != null)
            {
                IList<DOAProfileRecordEntity> _oDOAProfileRecordsList = (IList<DOAProfileRecordEntity>)_oDOAProfileRecordsArr;
                return _oDOAProfileRecordsList;
            }
            return new List<DOAProfileRecordEntity>();
        }
        
        public static IList<DOAProfileRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<DOAProfileRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<DOAProfileRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<DOAProfileRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            DOAProfileRecordRS x_oShowField = new DOAProfileRecordRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            DOAProfileRecordRS x_oSortField=new DOAProfileRecordRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(DOAProfileRecord.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(DOAProfileRecord.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            DOAProfileRecordRepositoryBase _oDOAProfileRecordRepositoryBase = new DOAProfileRecordRepositoryBase(GetDB());
            return _oDOAProfileRecordRepositoryBase.GetCount();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr("MobileRetentionOrderDB");
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


