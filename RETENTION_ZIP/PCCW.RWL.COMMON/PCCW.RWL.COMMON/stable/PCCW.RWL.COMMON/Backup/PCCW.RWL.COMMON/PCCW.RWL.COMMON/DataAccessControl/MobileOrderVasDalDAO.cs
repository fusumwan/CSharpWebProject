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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderVas],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderVasDalDAO{
        
        #region RS
        public class MobileOrderVasRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bActive = false;
            public bool n_bVas_field = false;
            public bool n_bVas_id = false;
            public bool n_bOrder_id = false;
            public bool n_bFee = false;
            public bool n_bVas_value = false;
            public bool n_bMulti_id = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (MobileOrderVas.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderVas.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.cdate);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderVas.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.active);
                }
                if (this.n_bVas_field  || x_bSetShowALL || (MobileOrderVas.Para.vas_field.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_field=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.vas_field);
                }
                if (this.n_bVas_id  || x_bSetShowALL || (MobileOrderVas.Para.vas_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.vas_id);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderVas.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.order_id);
                }
                if (this.n_bFee  || x_bSetShowALL || (MobileOrderVas.Para.fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.fee);
                }
                if (this.n_bVas_value  || x_bSetShowALL || (MobileOrderVas.Para.vas_value.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_value=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.vas_value);
                }
                if (this.n_bMulti_id  || x_bSetShowALL || (MobileOrderVas.Para.multi_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMulti_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderVas.Para.multi_id);
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
        
        public MobileOrderVasDalDAO(){
        }
        ~MobileOrderVasDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderVas.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderVasEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderVasRS x_oFieldsToReturn,MobileOrderVasRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderVasEntity> _oMobileOrderVasList = new List<MobileOrderVasEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderVas _oMobileOrderVas = new MobileOrderVas();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.id])) { _oMobileOrderVas.SetId((global::System.Nullable<int>)_oDATA[MobileOrderVas.Para.id]); } else { _oMobileOrderVas.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.cdate])) { _oMobileOrderVas.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderVas.Para.cdate]); } else { _oMobileOrderVas.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.active])) { _oMobileOrderVas.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderVas.Para.active]); } else { _oMobileOrderVas.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_field))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.vas_field])) { _oMobileOrderVas.SetVas_field((string)_oDATA[MobileOrderVas.Para.vas_field]); } else { _oMobileOrderVas.SetVas_field(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.vas_id])) { _oMobileOrderVas.SetVas_id((global::System.Nullable<int>)_oDATA[MobileOrderVas.Para.vas_id]); } else { _oMobileOrderVas.SetVas_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.order_id])) { _oMobileOrderVas.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderVas.Para.order_id]); } else { _oMobileOrderVas.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.fee])) { _oMobileOrderVas.SetFee((string)_oDATA[MobileOrderVas.Para.fee]); } else { _oMobileOrderVas.SetFee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_value))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.vas_value])) { _oMobileOrderVas.SetVas_value((string)_oDATA[MobileOrderVas.Para.vas_value]); } else { _oMobileOrderVas.SetVas_value(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMulti_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderVas.Para.multi_id])) { _oMobileOrderVas.SetMulti_id((global::System.Nullable<int>)_oDATA[MobileOrderVas.Para.multi_id]); } else { _oMobileOrderVas.SetMulti_id(null); }
                    }
                    _oMobileOrderVasList.Add(_oMobileOrderVas);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderVasList;
            }
            return new List<MobileOrderVasEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderVasEntity> OrderBy(string x_sSort, IQueryable<MobileOrderVasEntity> x_oMobileOrderVasBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderVas.Para.id:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileOrderVas.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderVas.Para.active:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderVas.Para.vas_field:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.vas_field).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.vas_field).Select(c => c);
                break;
                case MobileOrderVas.Para.vas_id:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.vas_id).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.vas_id).Select(c => c);
                break;
                case MobileOrderVas.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderVas.Para.fee:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.fee).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.fee).Select(c => c);
                break;
                case MobileOrderVas.Para.vas_value:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.vas_value).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.vas_value).Select(c => c);
                break;
                case MobileOrderVas.Para.multi_id:
                if(x_bAsc)
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderBy(c => c.multi_id).Select(c => c);
                else
                    x_oMobileOrderVasBaseList = x_oMobileOrderVasBaseList.OrderByDescending(c => c.multi_id).Select(c => c);
                break;
            }
            return x_oMobileOrderVasBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderVasEntity> FindAll()
        {
            MobileOrderVasEntity[] _oMobileOrderVassArr=  MobileOrderVasRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderVassArr != null)
            {
                IList<MobileOrderVasEntity> _oMobileOrderVassList = (IList<MobileOrderVasEntity>)_oMobileOrderVassArr;
                return _oMobileOrderVassList;
            }
            return new List<MobileOrderVasEntity>();
        }
        
        public static IList<MobileOrderVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderVasEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderVasRS x_oShowField = new MobileOrderVasRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderVasRS x_oSortField=new MobileOrderVasRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderVas.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderVas.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderVasRepositoryBase _oMobileOrderVasRepositoryBase = new MobileOrderVasRepositoryBase(GetDB());
            return _oMobileOrderVasRepositoryBase.GetCount();
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


