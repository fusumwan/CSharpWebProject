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
///-- Create date: <Create Date 2010-06-09>
///-- Description:	<Description,Table :[MobileManualAssignedHistory],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileManualAssignedHistoryDalDAO{
        
        #region RS
        public class MobileManualAssignedHistoryRS
        {
            public bool n_bSku = false;
            public bool n_bOrder_id = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bImei_no = false;
            public bool n_bId = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bSku  || x_bSetShowALL || (MobileManualAssignedHistory.Para.sku.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSku=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileManualAssignedHistory.Para.sku);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileManualAssignedHistory.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileManualAssignedHistory.Para.order_id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileManualAssignedHistory.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileManualAssignedHistory.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileManualAssignedHistory.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileManualAssignedHistory.Para.cid);
                }
                if (this.n_bImei_no  || x_bSetShowALL || (MobileManualAssignedHistory.Para.imei_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bImei_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileManualAssignedHistory.Para.imei_no);
                }
                if (this.n_bId  || x_bSetShowALL || (MobileManualAssignedHistory.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileManualAssignedHistory.Para.id);
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
        
        public MobileManualAssignedHistoryDalDAO(){
        }
        ~MobileManualAssignedHistoryDalDAO(){
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
            _oSearchUtils.SetTable(MobileManualAssignedHistory.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileManualAssignedHistoryEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileManualAssignedHistoryRS x_oFieldsToReturn,MobileManualAssignedHistoryRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileManualAssignedHistoryEntity> _oMobileManualAssignedHistoryList = new List<MobileManualAssignedHistoryEntity>();
                
                while (_oDATA.Read())
                {
                    MobileManualAssignedHistory _oMobileManualAssignedHistory = new MobileManualAssignedHistory();
                    if ((true).Equals(x_oFieldsToReturn.n_bSku))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileManualAssignedHistory.Para.sku])) { _oMobileManualAssignedHistory.SetSku((string)_oDATA[MobileManualAssignedHistory.Para.sku]); } else { _oMobileManualAssignedHistory.SetSku(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileManualAssignedHistory.Para.order_id])) { _oMobileManualAssignedHistory.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileManualAssignedHistory.Para.order_id]); } else { _oMobileManualAssignedHistory.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileManualAssignedHistory.Para.cdate])) { _oMobileManualAssignedHistory.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileManualAssignedHistory.Para.cdate]); } else { _oMobileManualAssignedHistory.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileManualAssignedHistory.Para.cid])) { _oMobileManualAssignedHistory.SetCid((string)_oDATA[MobileManualAssignedHistory.Para.cid]); } else { _oMobileManualAssignedHistory.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bImei_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileManualAssignedHistory.Para.imei_no])) { _oMobileManualAssignedHistory.SetImei_no((string)_oDATA[MobileManualAssignedHistory.Para.imei_no]); } else { _oMobileManualAssignedHistory.SetImei_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileManualAssignedHistory.Para.id])) { _oMobileManualAssignedHistory.SetId((global::System.Nullable<int>)_oDATA[MobileManualAssignedHistory.Para.id]); } else { _oMobileManualAssignedHistory.SetId(null); }
                    }
                    _oMobileManualAssignedHistoryList.Add(_oMobileManualAssignedHistory);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileManualAssignedHistoryList;
            }
            return new List<MobileManualAssignedHistoryEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileManualAssignedHistoryEntity> OrderBy(string x_sSort, IQueryable<MobileManualAssignedHistoryEntity> x_oMobileManualAssignedHistoryBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileManualAssignedHistory.Para.sku:
                if(x_bAsc)
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderBy(c => c.sku).Select(c => c);
                else
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderByDescending(c => c.sku).Select(c => c);
                break;
                case MobileManualAssignedHistory.Para.order_id:
                if(x_bAsc)
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileManualAssignedHistory.Para.cdate:
                if(x_bAsc)
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileManualAssignedHistory.Para.cid:
                if(x_bAsc)
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileManualAssignedHistory.Para.imei_no:
                if(x_bAsc)
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderBy(c => c.imei_no).Select(c => c);
                else
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderByDescending(c => c.imei_no).Select(c => c);
                break;
                case MobileManualAssignedHistory.Para.id:
                if(x_bAsc)
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileManualAssignedHistoryBaseList = x_oMobileManualAssignedHistoryBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
            }
            return x_oMobileManualAssignedHistoryBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileManualAssignedHistoryEntity> FindAll()
        {
            MobileManualAssignedHistoryEntity[] _oMobileManualAssignedHistorysArr=  MobileManualAssignedHistoryRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileManualAssignedHistorysArr != null)
            {
                IList<MobileManualAssignedHistoryEntity> _oMobileManualAssignedHistorysList = (IList<MobileManualAssignedHistoryEntity>)_oMobileManualAssignedHistorysArr;
                return _oMobileManualAssignedHistorysList;
            }
            return new List<MobileManualAssignedHistoryEntity>();
        }
        
        public static IList<MobileManualAssignedHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileManualAssignedHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileManualAssignedHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileManualAssignedHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileManualAssignedHistoryRS x_oShowField = new MobileManualAssignedHistoryRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileManualAssignedHistoryRS x_oSortField=new MobileManualAssignedHistoryRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) { x_sSortExpression = x_sSortExpression.Trim(); }
            if (!x_sSortExpression.ToLower().Equals(MobileManualAssignedHistory.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileManualAssignedHistory.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileManualAssignedHistoryRepositoryBase _oMobileManualAssignedHistoryRepositoryBase = new MobileManualAssignedHistoryRepositoryBase(GetDB());
            return _oMobileManualAssignedHistoryRepositoryBase.GetCount();
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


