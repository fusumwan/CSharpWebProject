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
///-- Description:	<Description,Table :[MobileOrderReportStyle],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportStyleDalDAO{
        
        #region RS
        public class MobileOrderReportStyleRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bActive = false;
            public bool n_bStatus = false;
            public bool n_bType = false;
            public bool n_bReport_id = false;
            public bool n_bFormat = false;
            public bool n_bVas_show = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (MobileOrderReportStyle.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderReportStyle.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderReportStyle.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.cid);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReportStyle.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.active);
                }
                if (this.n_bStatus  || x_bSetShowALL || (MobileOrderReportStyle.Para.status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStatus=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.status);
                }
                if (this.n_bType  || x_bSetShowALL || (MobileOrderReportStyle.Para.type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bType=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.type);
                }
                if (this.n_bReport_id  || x_bSetShowALL || (MobileOrderReportStyle.Para.report_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.report_id);
                }
                if (this.n_bFormat  || x_bSetShowALL || (MobileOrderReportStyle.Para.format.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFormat=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.format);
                }
                if (this.n_bVas_show  || x_bSetShowALL || (MobileOrderReportStyle.Para.vas_show.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bVas_show=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportStyle.Para.vas_show);
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
        
        public MobileOrderReportStyleDalDAO(){
        }
        ~MobileOrderReportStyleDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReportStyle.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportStyleEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportStyleRS x_oFieldsToReturn,MobileOrderReportStyleRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportStyleEntity> _oMobileOrderReportStyleList = new List<MobileOrderReportStyleEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReportStyle _oMobileOrderReportStyle = new MobileOrderReportStyle();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.id])) { _oMobileOrderReportStyle.SetId((global::System.Nullable<int>)_oDATA[MobileOrderReportStyle.Para.id]); } else { _oMobileOrderReportStyle.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.cdate])) { _oMobileOrderReportStyle.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportStyle.Para.cdate]); } else { _oMobileOrderReportStyle.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.cid])) { _oMobileOrderReportStyle.SetCid((string)_oDATA[MobileOrderReportStyle.Para.cid]); } else { _oMobileOrderReportStyle.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.active])) { _oMobileOrderReportStyle.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReportStyle.Para.active]); } else { _oMobileOrderReportStyle.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStatus))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.status])) { _oMobileOrderReportStyle.SetStatus((string)_oDATA[MobileOrderReportStyle.Para.status]); } else { _oMobileOrderReportStyle.SetStatus(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bType))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.type])) { _oMobileOrderReportStyle.SetType((string)_oDATA[MobileOrderReportStyle.Para.type]); } else { _oMobileOrderReportStyle.SetType(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.report_id])) { _oMobileOrderReportStyle.SetReport_id((global::System.Nullable<int>)_oDATA[MobileOrderReportStyle.Para.report_id]); } else { _oMobileOrderReportStyle.SetReport_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFormat))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.format])) { _oMobileOrderReportStyle.SetFormat((string)_oDATA[MobileOrderReportStyle.Para.format]); } else { _oMobileOrderReportStyle.SetFormat(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bVas_show))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportStyle.Para.vas_show])) { _oMobileOrderReportStyle.SetVas_show((global::System.Nullable<bool>)_oDATA[MobileOrderReportStyle.Para.vas_show]); } else { _oMobileOrderReportStyle.SetVas_show(null); }
                    }
                    _oMobileOrderReportStyleList.Add(_oMobileOrderReportStyle);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportStyleList;
            }
            return new List<MobileOrderReportStyleEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportStyleEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportStyleEntity> x_oMobileOrderReportStyleBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReportStyle.Para.id:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.status:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.status).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.status).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.type:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.type).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.type).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.report_id:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.report_id).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.report_id).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.format:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.format).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.format).Select(c => c);
                break;
                case MobileOrderReportStyle.Para.vas_show:
                if(x_bAsc)
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderBy(c => c.vas_show).Select(c => c);
                else
                    x_oMobileOrderReportStyleBaseList = x_oMobileOrderReportStyleBaseList.OrderByDescending(c => c.vas_show).Select(c => c);
                break;
            }
            return x_oMobileOrderReportStyleBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportStyleEntity> FindAll()
        {
            MobileOrderReportStyleEntity[] _oMobileOrderReportStylesArr=  MobileOrderReportStyleRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportStylesArr != null)
            {
                IList<MobileOrderReportStyleEntity> _oMobileOrderReportStylesList = (IList<MobileOrderReportStyleEntity>)_oMobileOrderReportStylesArr;
                return _oMobileOrderReportStylesList;
            }
            return new List<MobileOrderReportStyleEntity>();
        }
        
        public static IList<MobileOrderReportStyleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportStyleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportStyleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportStyleEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportStyleRS x_oShowField = new MobileOrderReportStyleRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportStyleRS x_oSortField=new MobileOrderReportStyleRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReportStyle.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReportStyle.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportStyleRepositoryBase _oMobileOrderReportStyleRepositoryBase = new MobileOrderReportStyleRepositoryBase(GetDB());
            return _oMobileOrderReportStyleRepositoryBase.GetCount();
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


