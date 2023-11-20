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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportType],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportTypeDalDAO{
        
        #region RS
        public class MobileOrderReportTypeRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bReport_name = false;
            public bool n_bId = false;
            public bool n_bDdate = false;
            public bool n_bMid = false;
            public bool n_bReport_type = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReportType.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.active);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderReportType.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderReportType.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderReportType.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.did);
                }
                if (this.n_bReport_name  || x_bSetShowALL || (MobileOrderReportType.Para.report_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.report_name);
                }
                if (this.n_bId  || x_bSetShowALL || (MobileOrderReportType.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.id);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderReportType.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.ddate);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderReportType.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.mid);
                }
                if (this.n_bReport_type  || x_bSetShowALL || (MobileOrderReportType.Para.report_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportType.Para.report_type);
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
        
        public MobileOrderReportTypeDalDAO(){
        }
        ~MobileOrderReportTypeDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReportType.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportTypeEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportTypeRS x_oFieldsToReturn,MobileOrderReportTypeRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportTypeEntity> _oMobileOrderReportTypeList = new List<MobileOrderReportTypeEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReportType _oMobileOrderReportType = new MobileOrderReportType();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.active])) { _oMobileOrderReportType.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReportType.Para.active]); } else { _oMobileOrderReportType.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.cdate])) { _oMobileOrderReportType.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportType.Para.cdate]); } else { _oMobileOrderReportType.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.cid])) { _oMobileOrderReportType.SetCid((string)_oDATA[MobileOrderReportType.Para.cid]); } else { _oMobileOrderReportType.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.did])) { _oMobileOrderReportType.SetDid((string)_oDATA[MobileOrderReportType.Para.did]); } else { _oMobileOrderReportType.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.report_name])) { _oMobileOrderReportType.SetReport_name((string)_oDATA[MobileOrderReportType.Para.report_name]); } else { _oMobileOrderReportType.SetReport_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.id])) { _oMobileOrderReportType.SetId((global::System.Nullable<Guid>)_oDATA[MobileOrderReportType.Para.id]); } else { _oMobileOrderReportType.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.ddate])) { _oMobileOrderReportType.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportType.Para.ddate]); } else { _oMobileOrderReportType.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.mid])) { _oMobileOrderReportType.SetMid((global::System.Nullable<int>)_oDATA[MobileOrderReportType.Para.mid]); } else { _oMobileOrderReportType.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportType.Para.report_type])) { _oMobileOrderReportType.SetReport_type((string)_oDATA[MobileOrderReportType.Para.report_type]); } else { _oMobileOrderReportType.SetReport_type(global::System.String.Empty); }
                    }
                    _oMobileOrderReportTypeList.Add(_oMobileOrderReportType);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportTypeList;
            }
            return new List<MobileOrderReportTypeEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportTypeEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportTypeEntity> x_oMobileOrderReportTypeBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReportType.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReportType.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderReportType.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderReportType.Para.did:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderReportType.Para.report_name:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.report_name).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.report_name).Select(c => c);
                break;
                case MobileOrderReportType.Para.id:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileOrderReportType.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileOrderReportType.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderReportType.Para.report_type:
                if(x_bAsc)
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderBy(c => c.report_type).Select(c => c);
                else
                    x_oMobileOrderReportTypeBaseList = x_oMobileOrderReportTypeBaseList.OrderByDescending(c => c.report_type).Select(c => c);
                break;
            }
            return x_oMobileOrderReportTypeBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportTypeEntity> FindAll()
        {
            MobileOrderReportTypeEntity[] _oMobileOrderReportTypesArr=  MobileOrderReportTypeRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportTypesArr != null)
            {
                IList<MobileOrderReportTypeEntity> _oMobileOrderReportTypesList = (IList<MobileOrderReportTypeEntity>)_oMobileOrderReportTypesArr;
                return _oMobileOrderReportTypesList;
            }
            return new List<MobileOrderReportTypeEntity>();
        }
        
        public static IList<MobileOrderReportTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportTypeEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportTypeRS x_oShowField = new MobileOrderReportTypeRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportTypeRS x_oSortField=new MobileOrderReportTypeRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReportType.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReportType.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportTypeRepositoryBase _oMobileOrderReportTypeRepositoryBase = new MobileOrderReportTypeRepositoryBase(GetDB());
            return _oMobileOrderReportTypeRepositoryBase.GetCount();
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


