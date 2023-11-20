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
///-- Create date: <Create Date 2010-10-29>
///-- Description:	<Description,Table :[MobileOrderReportField],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportFieldDalDAO{
        
        #region RS
        public class MobileOrderReportFieldRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bField_title = false;
            public bool n_bActive = false;
            public bool n_bReport_id = false;
            public bool n_bField_content_order = false;
            public bool n_bField_content = false;
            public bool n_bField_content_name = false;
            public bool n_bField_order = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (MobileOrderReportField.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderReportField.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderReportField.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.cid);
                }
                if (this.n_bField_title  || x_bSetShowALL || (MobileOrderReportField.Para.field_title.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bField_title=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.field_title);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReportField.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.active);
                }
                if (this.n_bReport_id  || x_bSetShowALL || (MobileOrderReportField.Para.report_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.report_id);
                }
                if (this.n_bField_content_order  || x_bSetShowALL || (MobileOrderReportField.Para.field_content_order.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bField_content_order=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.field_content_order);
                }
                if (this.n_bField_content  || x_bSetShowALL || (MobileOrderReportField.Para.field_content.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bField_content=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.field_content);
                }
                if (this.n_bField_content_name  || x_bSetShowALL || (MobileOrderReportField.Para.field_content_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bField_content_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.field_content_name);
                }
                if (this.n_bField_order  || x_bSetShowALL || (MobileOrderReportField.Para.field_order.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bField_order=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportField.Para.field_order);
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
        
        public MobileOrderReportFieldDalDAO(){
        }
        ~MobileOrderReportFieldDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReportField.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportFieldEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportFieldRS x_oFieldsToReturn,MobileOrderReportFieldRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportFieldEntity> _oMobileOrderReportFieldList = new List<MobileOrderReportFieldEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReportField _oMobileOrderReportField = new MobileOrderReportField();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.id])) { _oMobileOrderReportField.SetId((global::System.Nullable<int>)_oDATA[MobileOrderReportField.Para.id]); } else { _oMobileOrderReportField.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.cdate])) { _oMobileOrderReportField.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportField.Para.cdate]); } else { _oMobileOrderReportField.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.cid])) { _oMobileOrderReportField.SetCid((string)_oDATA[MobileOrderReportField.Para.cid]); } else { _oMobileOrderReportField.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField_title))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.field_title])) { _oMobileOrderReportField.SetField_title((string)_oDATA[MobileOrderReportField.Para.field_title]); } else { _oMobileOrderReportField.SetField_title(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.active])) { _oMobileOrderReportField.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReportField.Para.active]); } else { _oMobileOrderReportField.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.report_id])) { _oMobileOrderReportField.SetReport_id((global::System.Nullable<int>)_oDATA[MobileOrderReportField.Para.report_id]); } else { _oMobileOrderReportField.SetReport_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField_content_order))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.field_content_order])) { _oMobileOrderReportField.SetField_content_order((global::System.Nullable<int>)_oDATA[MobileOrderReportField.Para.field_content_order]); } else { _oMobileOrderReportField.SetField_content_order(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField_content))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.field_content])) { _oMobileOrderReportField.SetField_content((string)_oDATA[MobileOrderReportField.Para.field_content]); } else { _oMobileOrderReportField.SetField_content(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField_content_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.field_content_name])) { _oMobileOrderReportField.SetField_content_name((string)_oDATA[MobileOrderReportField.Para.field_content_name]); } else { _oMobileOrderReportField.SetField_content_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bField_order))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportField.Para.field_order])) { _oMobileOrderReportField.SetField_order((global::System.Nullable<int>)_oDATA[MobileOrderReportField.Para.field_order]); } else { _oMobileOrderReportField.SetField_order(null); }
                    }
                    _oMobileOrderReportFieldList.Add(_oMobileOrderReportField);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportFieldList;
            }
            return new List<MobileOrderReportFieldEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportFieldEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportFieldEntity> x_oMobileOrderReportFieldBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReportField.Para.id:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileOrderReportField.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderReportField.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderReportField.Para.field_title:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.field_title).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.field_title).Select(c => c);
                break;
                case MobileOrderReportField.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReportField.Para.report_id:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.report_id).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.report_id).Select(c => c);
                break;
                case MobileOrderReportField.Para.field_content_order:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.field_content_order).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.field_content_order).Select(c => c);
                break;
                case MobileOrderReportField.Para.field_content:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.field_content).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.field_content).Select(c => c);
                break;
                case MobileOrderReportField.Para.field_content_name:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.field_content_name).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.field_content_name).Select(c => c);
                break;
                case MobileOrderReportField.Para.field_order:
                if(x_bAsc)
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderBy(c => c.field_order).Select(c => c);
                else
                    x_oMobileOrderReportFieldBaseList = x_oMobileOrderReportFieldBaseList.OrderByDescending(c => c.field_order).Select(c => c);
                break;
            }
            return x_oMobileOrderReportFieldBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportFieldEntity> FindAll()
        {
            MobileOrderReportFieldEntity[] _oMobileOrderReportFieldsArr=  MobileOrderReportFieldRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportFieldsArr != null)
            {
                IList<MobileOrderReportFieldEntity> _oMobileOrderReportFieldsList = (IList<MobileOrderReportFieldEntity>)_oMobileOrderReportFieldsArr;
                return _oMobileOrderReportFieldsList;
            }
            return new List<MobileOrderReportFieldEntity>();
        }
        
        public static IList<MobileOrderReportFieldEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportFieldEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportFieldEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportFieldEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportFieldRS x_oShowField = new MobileOrderReportFieldRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportFieldRS x_oSortField=new MobileOrderReportFieldRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReportField.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReportField.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportFieldRepositoryBase _oMobileOrderReportFieldRepositoryBase = new MobileOrderReportFieldRepositoryBase(GetDB());
            return _oMobileOrderReportFieldRepositoryBase.GetCount();
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


