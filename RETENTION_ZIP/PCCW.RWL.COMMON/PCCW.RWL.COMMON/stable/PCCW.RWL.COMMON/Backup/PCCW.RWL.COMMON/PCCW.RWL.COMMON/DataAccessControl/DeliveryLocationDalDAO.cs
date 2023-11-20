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
///-- Create date: <Create Date 2011-10-31>
///-- Description:	<Description,Table :[DeliveryLocation],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class DeliveryLocationDalDAO{
        
        #region RS
        public class DeliveryLocationRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bLocation = false;
            public bool n_bFee = false;
            public bool n_bArea = false;
            public bool n_bActive = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (DeliveryLocation.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryLocation.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (DeliveryLocation.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryLocation.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (DeliveryLocation.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryLocation.Para.cid);
                }
                if (this.n_bLocation  || x_bSetShowALL || (DeliveryLocation.Para.location.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bLocation=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryLocation.Para.location);
                }
                if (this.n_bFee  || x_bSetShowALL || (DeliveryLocation.Para.fee.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFee=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryLocation.Para.fee);
                }
                if (this.n_bArea  || x_bSetShowALL || (DeliveryLocation.Para.area.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bArea=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryLocation.Para.area);
                }
                if (this.n_bActive  || x_bSetShowALL || (DeliveryLocation.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(DeliveryLocation.Para.active);
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
        
        public DeliveryLocationDalDAO(){
        }
        ~DeliveryLocationDalDAO(){
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
            _oSearchUtils.SetTable(DeliveryLocation.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<DeliveryLocationEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, DeliveryLocationRS x_oFieldsToReturn,DeliveryLocationRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<DeliveryLocationEntity> _oDeliveryLocationList = new List<DeliveryLocationEntity>();
                
                while (_oDATA.Read())
                {
                    DeliveryLocation _oDeliveryLocation = new DeliveryLocation();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryLocation.Para.id])) { _oDeliveryLocation.SetId((global::System.Nullable<int>)_oDATA[DeliveryLocation.Para.id]); } else { _oDeliveryLocation.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryLocation.Para.cdate])) { _oDeliveryLocation.SetCdate((global::System.Nullable<DateTime>)_oDATA[DeliveryLocation.Para.cdate]); } else { _oDeliveryLocation.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryLocation.Para.cid])) { _oDeliveryLocation.SetCid((string)_oDATA[DeliveryLocation.Para.cid]); } else { _oDeliveryLocation.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bLocation))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryLocation.Para.location])) { _oDeliveryLocation.SetLocation((string)_oDATA[DeliveryLocation.Para.location]); } else { _oDeliveryLocation.SetLocation(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFee))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryLocation.Para.fee])) { _oDeliveryLocation.SetFee((string)_oDATA[DeliveryLocation.Para.fee]); } else { _oDeliveryLocation.SetFee(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bArea))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryLocation.Para.area])) { _oDeliveryLocation.SetArea((string)_oDATA[DeliveryLocation.Para.area]); } else { _oDeliveryLocation.SetArea(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[DeliveryLocation.Para.active])) { _oDeliveryLocation.SetActive((global::System.Nullable<bool>)_oDATA[DeliveryLocation.Para.active]); } else { _oDeliveryLocation.SetActive(null); }
                    }
                    _oDeliveryLocationList.Add(_oDeliveryLocation);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oDeliveryLocationList;
            }
            return new List<DeliveryLocationEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<DeliveryLocationEntity> OrderBy(string x_sSort, IQueryable<DeliveryLocationEntity> x_oDeliveryLocationBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case DeliveryLocation.Para.id:
                if(x_bAsc)
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case DeliveryLocation.Para.cdate:
                if(x_bAsc)
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case DeliveryLocation.Para.cid:
                if(x_bAsc)
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case DeliveryLocation.Para.location:
                if(x_bAsc)
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderBy(c => c.location).Select(c => c);
                else
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderByDescending(c => c.location).Select(c => c);
                break;
                case DeliveryLocation.Para.fee:
                if(x_bAsc)
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderBy(c => c.fee).Select(c => c);
                else
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderByDescending(c => c.fee).Select(c => c);
                break;
                case DeliveryLocation.Para.area:
                if(x_bAsc)
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderBy(c => c.area).Select(c => c);
                else
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderByDescending(c => c.area).Select(c => c);
                break;
                case DeliveryLocation.Para.active:
                if(x_bAsc)
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oDeliveryLocationBaseList = x_oDeliveryLocationBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
            }
            return x_oDeliveryLocationBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<DeliveryLocationEntity> FindAll()
        {
            DeliveryLocationEntity[] _oDeliveryLocationsArr=  DeliveryLocationRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oDeliveryLocationsArr != null)
            {
                IList<DeliveryLocationEntity> _oDeliveryLocationsList = (IList<DeliveryLocationEntity>)_oDeliveryLocationsArr;
                return _oDeliveryLocationsList;
            }
            return new List<DeliveryLocationEntity>();
        }
        
        public static IList<DeliveryLocationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<DeliveryLocationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<DeliveryLocationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<DeliveryLocationEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            DeliveryLocationRS x_oShowField = new DeliveryLocationRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            DeliveryLocationRS x_oSortField=new DeliveryLocationRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(DeliveryLocation.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(DeliveryLocation.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            DeliveryLocationRepositoryBase _oDeliveryLocationRepositoryBase = new DeliveryLocationRepositoryBase(GetDB());
            return _oDeliveryLocationRepositoryBase.GetCount();
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


