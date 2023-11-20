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
///-- Description:	<Description,Table :[MobileOrderAddressRevision],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderAddressRevisionDalDAO{
        
        #region RS
        public class MobileOrderAddressRevisionRS
        {
            public bool n_bD_street = false;
            public bool n_bAddress_id = false;
            public bool n_bD_region = false;
            public bool n_bD_floor = false;
            public bool n_bD_build = false;
            public bool n_bD_room = false;
            public bool n_bOrder_id = false;
            public bool n_bAddress_type = false;
            public bool n_bD_type = false;
            public bool n_bD_district = false;
            public bool n_bMid = false;
            public bool n_bD_blk = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bD_street  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_street.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_street=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_street);
                }
                if (this.n_bAddress_id  || x_bSetShowALL || (MobileOrderAddressRevision.Para.address_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAddress_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.address_id);
                }
                if (this.n_bD_region  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_region.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_region=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_region);
                }
                if (this.n_bD_floor  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_floor.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_floor=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_floor);
                }
                if (this.n_bD_build  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_build.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_build=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_build);
                }
                if (this.n_bD_room  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_room.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_room=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_room);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderAddressRevision.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.order_id);
                }
                if (this.n_bAddress_type  || x_bSetShowALL || (MobileOrderAddressRevision.Para.address_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAddress_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.address_type);
                }
                if (this.n_bD_type  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_type);
                }
                if (this.n_bD_district  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_district.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_district=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_district);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderAddressRevision.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.mid);
                }
                if (this.n_bD_blk  || x_bSetShowALL || (MobileOrderAddressRevision.Para.d_blk.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bD_blk=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderAddressRevision.Para.d_blk);
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
        
        public MobileOrderAddressRevisionDalDAO(){
        }
        ~MobileOrderAddressRevisionDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderAddressRevision.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderAddressRevisionEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderAddressRevisionRS x_oFieldsToReturn,MobileOrderAddressRevisionRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderAddressRevisionEntity> _oMobileOrderAddressRevisionList = new List<MobileOrderAddressRevisionEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderAddressRevision _oMobileOrderAddressRevision = new MobileOrderAddressRevision();
                    if ((true).Equals(x_oFieldsToReturn.n_bD_street))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_street])) { _oMobileOrderAddressRevision.SetD_street((string)_oDATA[MobileOrderAddressRevision.Para.d_street]); } else { _oMobileOrderAddressRevision.SetD_street(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAddress_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.address_id])) { _oMobileOrderAddressRevision.SetAddress_id((global::System.Nullable<long>)_oDATA[MobileOrderAddressRevision.Para.address_id]); } else { _oMobileOrderAddressRevision.SetAddress_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_region))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_region])) { _oMobileOrderAddressRevision.SetD_region((string)_oDATA[MobileOrderAddressRevision.Para.d_region]); } else { _oMobileOrderAddressRevision.SetD_region(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_floor))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_floor])) { _oMobileOrderAddressRevision.SetD_floor((string)_oDATA[MobileOrderAddressRevision.Para.d_floor]); } else { _oMobileOrderAddressRevision.SetD_floor(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_build))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_build])) { _oMobileOrderAddressRevision.SetD_build((string)_oDATA[MobileOrderAddressRevision.Para.d_build]); } else { _oMobileOrderAddressRevision.SetD_build(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_room))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_room])) { _oMobileOrderAddressRevision.SetD_room((string)_oDATA[MobileOrderAddressRevision.Para.d_room]); } else { _oMobileOrderAddressRevision.SetD_room(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.order_id])) { _oMobileOrderAddressRevision.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderAddressRevision.Para.order_id]); } else { _oMobileOrderAddressRevision.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAddress_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.address_type])) { _oMobileOrderAddressRevision.SetAddress_type((string)_oDATA[MobileOrderAddressRevision.Para.address_type]); } else { _oMobileOrderAddressRevision.SetAddress_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_type])) { _oMobileOrderAddressRevision.SetD_type((string)_oDATA[MobileOrderAddressRevision.Para.d_type]); } else { _oMobileOrderAddressRevision.SetD_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_district))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_district])) { _oMobileOrderAddressRevision.SetD_district((string)_oDATA[MobileOrderAddressRevision.Para.d_district]); } else { _oMobileOrderAddressRevision.SetD_district(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.mid])) { _oMobileOrderAddressRevision.SetMid((global::System.Nullable<long>)_oDATA[MobileOrderAddressRevision.Para.mid]); } else { _oMobileOrderAddressRevision.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bD_blk))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderAddressRevision.Para.d_blk])) { _oMobileOrderAddressRevision.SetD_blk((string)_oDATA[MobileOrderAddressRevision.Para.d_blk]); } else { _oMobileOrderAddressRevision.SetD_blk(global::System.String.Empty); }
                    }
                    _oMobileOrderAddressRevisionList.Add(_oMobileOrderAddressRevision);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderAddressRevisionList;
            }
            return new List<MobileOrderAddressRevisionEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderAddressRevisionEntity> OrderBy(string x_sSort, IQueryable<MobileOrderAddressRevisionEntity> x_oMobileOrderAddressRevisionBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderAddressRevision.Para.d_street:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_street).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_street).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.address_id:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.address_id).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.address_id).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.d_region:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_region).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_region).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.d_floor:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_floor).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_floor).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.d_build:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_build).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_build).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.d_room:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_room).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_room).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.address_type:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.address_type).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.address_type).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.d_type:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_type).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_type).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.d_district:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_district).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_district).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderAddressRevision.Para.d_blk:
                if(x_bAsc)
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderBy(c => c.d_blk).Select(c => c);
                else
                    x_oMobileOrderAddressRevisionBaseList = x_oMobileOrderAddressRevisionBaseList.OrderByDescending(c => c.d_blk).Select(c => c);
                break;
            }
            return x_oMobileOrderAddressRevisionBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderAddressRevisionEntity> FindAll()
        {
            MobileOrderAddressRevisionEntity[] _oMobileOrderAddressRevisionsArr=  MobileOrderAddressRevisionRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderAddressRevisionsArr != null)
            {
                IList<MobileOrderAddressRevisionEntity> _oMobileOrderAddressRevisionsList = (IList<MobileOrderAddressRevisionEntity>)_oMobileOrderAddressRevisionsArr;
                return _oMobileOrderAddressRevisionsList;
            }
            return new List<MobileOrderAddressRevisionEntity>();
        }
        
        public static IList<MobileOrderAddressRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderAddressRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderAddressRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderAddressRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderAddressRevisionRS x_oShowField = new MobileOrderAddressRevisionRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderAddressRevisionRS x_oSortField=new MobileOrderAddressRevisionRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderAddressRevision.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderAddressRevision.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderAddressRevisionRepositoryBase _oMobileOrderAddressRevisionRepositoryBase = new MobileOrderAddressRevisionRepositoryBase(GetDB());
            return _oMobileOrderAddressRevisionRepositoryBase.GetCount();
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


