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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionColumn],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderIssueRestrictionColumnDalDAO{
        
        #region RS
        public class MobileOrderIssueRestrictionColumnRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bRestriction_id = false;
            public bool n_bRestriction_column = false;
            public bool n_bRestriction_value = false;
            public bool n_bRestriction_table = false;
            public bool n_bAction_type = false;
            public bool n_bMid = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.active);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.cid);
                }
                if (this.n_bRestriction_id  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.restriction_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRestriction_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.restriction_id);
                }
                if (this.n_bRestriction_column  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.restriction_column.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRestriction_column=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.restriction_column);
                }
                if (this.n_bRestriction_value  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.restriction_value.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRestriction_value=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.restriction_value);
                }
                if (this.n_bRestriction_table  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.restriction_table.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRestriction_table=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.restriction_table);
                }
                if (this.n_bAction_type  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.action_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAction_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.action_type);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderIssueRestrictionColumn.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionColumn.Para.mid);
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
        
        public MobileOrderIssueRestrictionColumnDalDAO(){
        }
        ~MobileOrderIssueRestrictionColumnDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderIssueRestrictionColumn.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderIssueRestrictionColumnEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderIssueRestrictionColumnRS x_oFieldsToReturn,MobileOrderIssueRestrictionColumnRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnList = new List<MobileOrderIssueRestrictionColumnEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderIssueRestrictionColumn _oMobileOrderIssueRestrictionColumn = new MobileOrderIssueRestrictionColumn();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.active])) { _oMobileOrderIssueRestrictionColumn.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderIssueRestrictionColumn.Para.active]); } else { _oMobileOrderIssueRestrictionColumn.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.cdate])) { _oMobileOrderIssueRestrictionColumn.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderIssueRestrictionColumn.Para.cdate]); } else { _oMobileOrderIssueRestrictionColumn.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.cid])) { _oMobileOrderIssueRestrictionColumn.SetCid((string)_oDATA[MobileOrderIssueRestrictionColumn.Para.cid]); } else { _oMobileOrderIssueRestrictionColumn.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRestriction_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_id])) { _oMobileOrderIssueRestrictionColumn.SetRestriction_id((global::System.Nullable<int>)_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_id]); } else { _oMobileOrderIssueRestrictionColumn.SetRestriction_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRestriction_column))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_column])) { _oMobileOrderIssueRestrictionColumn.SetRestriction_column((string)_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_column]); } else { _oMobileOrderIssueRestrictionColumn.SetRestriction_column(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRestriction_value))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_value])) { _oMobileOrderIssueRestrictionColumn.SetRestriction_value((string)_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_value]); } else { _oMobileOrderIssueRestrictionColumn.SetRestriction_value(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRestriction_table))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_table])) { _oMobileOrderIssueRestrictionColumn.SetRestriction_table((string)_oDATA[MobileOrderIssueRestrictionColumn.Para.restriction_table]); } else { _oMobileOrderIssueRestrictionColumn.SetRestriction_table(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAction_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.action_type])) { _oMobileOrderIssueRestrictionColumn.SetAction_type((string)_oDATA[MobileOrderIssueRestrictionColumn.Para.action_type]); } else { _oMobileOrderIssueRestrictionColumn.SetAction_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionColumn.Para.mid])) { _oMobileOrderIssueRestrictionColumn.SetMid((global::System.Nullable<int>)_oDATA[MobileOrderIssueRestrictionColumn.Para.mid]); } else { _oMobileOrderIssueRestrictionColumn.SetMid(null); }
                    }
                    _oMobileOrderIssueRestrictionColumnList.Add(_oMobileOrderIssueRestrictionColumn);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderIssueRestrictionColumnList;
            }
            return new List<MobileOrderIssueRestrictionColumnEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderIssueRestrictionColumnEntity> OrderBy(string x_sSort, IQueryable<MobileOrderIssueRestrictionColumnEntity> x_oMobileOrderIssueRestrictionColumnBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderIssueRestrictionColumn.Para.active:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.restriction_id:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.restriction_id).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.restriction_id).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.restriction_column:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.restriction_column).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.restriction_column).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.restriction_value:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.restriction_value).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.restriction_value).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.restriction_table:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.restriction_table).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.restriction_table).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.action_type:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.action_type).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.action_type).Select(c => c);
                break;
                case MobileOrderIssueRestrictionColumn.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionColumnBaseList = x_oMobileOrderIssueRestrictionColumnBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
            }
            return x_oMobileOrderIssueRestrictionColumnBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderIssueRestrictionColumnEntity> FindAll()
        {
            MobileOrderIssueRestrictionColumnEntity[] _oMobileOrderIssueRestrictionColumnsArr=  MobileOrderIssueRestrictionColumnRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderIssueRestrictionColumnsArr != null)
            {
                IList<MobileOrderIssueRestrictionColumnEntity> _oMobileOrderIssueRestrictionColumnsList = (IList<MobileOrderIssueRestrictionColumnEntity>)_oMobileOrderIssueRestrictionColumnsArr;
                return _oMobileOrderIssueRestrictionColumnsList;
            }
            return new List<MobileOrderIssueRestrictionColumnEntity>();
        }
        
        public static IList<MobileOrderIssueRestrictionColumnEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderIssueRestrictionColumnEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderIssueRestrictionColumnEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderIssueRestrictionColumnEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, x_sRowFilter, true);
        }

        public static IList<MobileOrderIssueRestrictionColumnEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter,bool x_bAscDirection)
        {
            MobileOrderIssueRestrictionColumnRS x_oShowField = new MobileOrderIssueRestrictionColumnRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderIssueRestrictionColumnRS x_oSortField = new MobileOrderIssueRestrictionColumnRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderIssueRestrictionColumn.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(MobileOrderIssueRestrictionColumn.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, x_bAscDirection);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderIssueRestrictionColumnRepositoryBase _oMobileOrderIssueRestrictionColumnRepositoryBase = new MobileOrderIssueRestrictionColumnRepositoryBase(GetDB());
            return _oMobileOrderIssueRestrictionColumnRepositoryBase.GetCount();
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


