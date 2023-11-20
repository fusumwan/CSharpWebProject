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
///-- Create date: <Create Date 2011-10-31>
///-- Description:	<Description,Table :[DeliveryTime],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class DeliveryTimeDalDAO{
        
        #region RS
        public class DeliveryTimeRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bLocation = false;
            public bool n_bActive = false;
            public bool n_bPeriod = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (DeliveryTime.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryTime.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (DeliveryTime.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryTime.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (DeliveryTime.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryTime.Para.cid);
                }
                if (this.n_bLocation  || x_bSetShowALL || (DeliveryTime.Para.location.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLocation=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryTime.Para.location);
                }
                if (this.n_bActive  || x_bSetShowALL || (DeliveryTime.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryTime.Para.active);
                }
                if (this.n_bPeriod  || x_bSetShowALL || (DeliveryTime.Para.period.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPeriod=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryTime.Para.period);
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
        
        public DeliveryTimeDalDAO(){
        }
        ~DeliveryTimeDalDAO(){
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
            _oSearchUtils.SetTable(DeliveryTime.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<DeliveryTimeEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, DeliveryTimeRS x_oFieldsToReturn,DeliveryTimeRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<DeliveryTimeEntity> _oDeliveryTimeList = new List<DeliveryTimeEntity>();
                
                while (_oDATA.Read())
                {
                    DeliveryTime _oDeliveryTime = new DeliveryTime();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryTime.Para.id])) { _oDeliveryTime.SetId((global::System.Nullable<int>)_oDATA[DeliveryTime.Para.id]); } else { _oDeliveryTime.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryTime.Para.cdate])) { _oDeliveryTime.SetCdate((global::System.Nullable<DateTime>)_oDATA[DeliveryTime.Para.cdate]); } else { _oDeliveryTime.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryTime.Para.cid])) { _oDeliveryTime.SetCid((string)_oDATA[DeliveryTime.Para.cid]); } else { _oDeliveryTime.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLocation))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryTime.Para.location])) { _oDeliveryTime.SetLocation((string)_oDATA[DeliveryTime.Para.location]); } else { _oDeliveryTime.SetLocation(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryTime.Para.active])) { _oDeliveryTime.SetActive((global::System.Nullable<bool>)_oDATA[DeliveryTime.Para.active]); } else { _oDeliveryTime.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPeriod))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryTime.Para.period])) { _oDeliveryTime.SetPeriod((string)_oDATA[DeliveryTime.Para.period]); } else { _oDeliveryTime.SetPeriod(global::System.String.Empty); }
                    }
                    _oDeliveryTimeList.Add(_oDeliveryTime);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oDeliveryTimeList;
            }
            return new List<DeliveryTimeEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<DeliveryTimeEntity> OrderBy(string x_sSort, IQueryable<DeliveryTimeEntity> x_oDeliveryTimeBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case DeliveryTime.Para.id:
                if(x_bAsc)
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case DeliveryTime.Para.cdate:
                if(x_bAsc)
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case DeliveryTime.Para.cid:
                if(x_bAsc)
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case DeliveryTime.Para.location:
                if(x_bAsc)
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderBy(c => c.location).Select(c => c);
                else
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderByDescending(c => c.location).Select(c => c);
                break;
                case DeliveryTime.Para.active:
                if(x_bAsc)
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case DeliveryTime.Para.period:
                if(x_bAsc)
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderBy(c => c.period).Select(c => c);
                else
                    x_oDeliveryTimeBaseList = x_oDeliveryTimeBaseList.OrderByDescending(c => c.period).Select(c => c);
                break;
            }
            return x_oDeliveryTimeBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<DeliveryTimeEntity> FindAll()
        {
            DeliveryTimeEntity[] _oDeliveryTimesArr=  DeliveryTimeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oDeliveryTimesArr != null)
            {
                IList<DeliveryTimeEntity> _oDeliveryTimesList = (IList<DeliveryTimeEntity>)_oDeliveryTimesArr;
                return _oDeliveryTimesList;
            }
            return new List<DeliveryTimeEntity>();
        }
        
        public static IList<DeliveryTimeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<DeliveryTimeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<DeliveryTimeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<DeliveryTimeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            DeliveryTimeRS x_oShowField = new DeliveryTimeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            DeliveryTimeRS x_oSortField=new DeliveryTimeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(DeliveryTime.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(DeliveryTime.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            DeliveryTimeRepositoryBase _oDeliveryTimeRepositoryBase = new DeliveryTimeRepositoryBase(GetDB());
            return _oDeliveryTimeRepositoryBase.GetCount();
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


