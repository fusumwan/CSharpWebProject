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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderVasRevision],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderVasRevisionDalDAO{
        
        #region RS
        public class MobileOrderVasRevisionRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bActive = false;
            public bool n_bVas_field = false;
            public bool n_bVas_id = false;
            public bool n_bHis_order_id = false;
            public bool n_bOrder_id = false;
            public bool n_bFee = false;
            public bool n_bVas_value = false;
            public bool n_bMulti_id = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (MobileOrderVasRevision.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderVasRevision.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.cdate);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderVasRevision.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.active);
                }
                if (this.n_bVas_field  || x_bSetShowALL || (MobileOrderVasRevision.Para.vas_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.vas_field);
                }
                if (this.n_bVas_id  || x_bSetShowALL || (MobileOrderVasRevision.Para.vas_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.vas_id);
                }
                if (this.n_bHis_order_id  || x_bSetShowALL || (MobileOrderVasRevision.Para.his_order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHis_order_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.his_order_id);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderVasRevision.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.order_id);
                }
                if (this.n_bFee  || x_bSetShowALL || (MobileOrderVasRevision.Para.fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.fee);
                }
                if (this.n_bVas_value  || x_bSetShowALL || (MobileOrderVasRevision.Para.vas_value.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_value=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.vas_value);
                }
                if (this.n_bMulti_id  || x_bSetShowALL || (MobileOrderVasRevision.Para.multi_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMulti_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVasRevision.Para.multi_id);
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
        
        public MobileOrderVasRevisionDalDAO(){
        }
        ~MobileOrderVasRevisionDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderVasRevision.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderVasRevisionEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderVasRevisionRS x_oFieldsToReturn,MobileOrderVasRevisionRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderVasRevisionEntity> _oMobileOrderVasRevisionList = new List<MobileOrderVasRevisionEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderVasRevision _oMobileOrderVasRevision = new MobileOrderVasRevision();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.id])) { _oMobileOrderVasRevision.SetId((global::System.Nullable<int>)_oDATA[MobileOrderVasRevision.Para.id]); } else { _oMobileOrderVasRevision.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.cdate])) { _oMobileOrderVasRevision.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderVasRevision.Para.cdate]); } else { _oMobileOrderVasRevision.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.active])) { _oMobileOrderVasRevision.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderVasRevision.Para.active]); } else { _oMobileOrderVasRevision.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.vas_field])) { _oMobileOrderVasRevision.SetVas_field((string)_oDATA[MobileOrderVasRevision.Para.vas_field]); } else { _oMobileOrderVasRevision.SetVas_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.vas_id])) { _oMobileOrderVasRevision.SetVas_id((global::System.Nullable<int>)_oDATA[MobileOrderVasRevision.Para.vas_id]); } else { _oMobileOrderVasRevision.SetVas_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHis_order_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.his_order_id])) { _oMobileOrderVasRevision.SetHis_order_id((global::System.Nullable<int>)_oDATA[MobileOrderVasRevision.Para.his_order_id]); } else { _oMobileOrderVasRevision.SetHis_order_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.order_id])) { _oMobileOrderVasRevision.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderVasRevision.Para.order_id]); } else { _oMobileOrderVasRevision.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.fee])) { _oMobileOrderVasRevision.SetFee((string)_oDATA[MobileOrderVasRevision.Para.fee]); } else { _oMobileOrderVasRevision.SetFee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_value))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.vas_value])) { _oMobileOrderVasRevision.SetVas_value((string)_oDATA[MobileOrderVasRevision.Para.vas_value]); } else { _oMobileOrderVasRevision.SetVas_value(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMulti_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVasRevision.Para.multi_id])) { _oMobileOrderVasRevision.SetMulti_id((global::System.Nullable<int>)_oDATA[MobileOrderVasRevision.Para.multi_id]); } else { _oMobileOrderVasRevision.SetMulti_id(null); }
                    }
                    _oMobileOrderVasRevisionList.Add(_oMobileOrderVasRevision);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderVasRevisionList;
            }
            return new List<MobileOrderVasRevisionEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderVasRevisionEntity> OrderBy(string x_sSort, IQueryable<MobileOrderVasRevisionEntity> x_oMobileOrderVasRevisionBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderVasRevision.Para.id:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.active:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.vas_field:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.vas_field).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.vas_field).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.vas_id:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.vas_id).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.vas_id).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.his_order_id:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.his_order_id).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.his_order_id).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.fee:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.fee).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.fee).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.vas_value:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.vas_value).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.vas_value).Select(c => c);
                break;
                case MobileOrderVasRevision.Para.multi_id:
                if(x_bAsc)
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderBy(c => c.multi_id).Select(c => c);
                else
                    x_oMobileOrderVasRevisionBaseList = x_oMobileOrderVasRevisionBaseList.OrderByDescending(c => c.multi_id).Select(c => c);
                break;
            }
            return x_oMobileOrderVasRevisionBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderVasRevisionEntity> FindAll()
        {
            MobileOrderVasRevisionEntity[] _oMobileOrderVasRevisionsArr=  MobileOrderVasRevisionRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderVasRevisionsArr != null)
            {
                IList<MobileOrderVasRevisionEntity> _oMobileOrderVasRevisionsList = (IList<MobileOrderVasRevisionEntity>)_oMobileOrderVasRevisionsArr;
                return _oMobileOrderVasRevisionsList;
            }
            return new List<MobileOrderVasRevisionEntity>();
        }
        
        public static IList<MobileOrderVasRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderVasRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderVasRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderVasRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderVasRevisionRS x_oShowField = new MobileOrderVasRevisionRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderVasRevisionRS x_oSortField=new MobileOrderVasRevisionRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderVasRevision.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderVasRevision.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderVasRevisionRepositoryBase _oMobileOrderVasRevisionRepositoryBase = new MobileOrderVasRevisionRepositoryBase(GetDB());
            return _oMobileOrderVasRevisionRepositoryBase.GetCount();
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


