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
///-- Create date: <Create Date 2011-02-02>
///-- Description:	<Description,Table :[MobileRetentionOrderAddRuleExceptionList],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileRetentionOrderAddRuleExceptionListDalDAO{
        
        #region RS
        public class MobileRetentionOrderAddRuleExceptionListRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bMrt_no = false;
            public bool n_bActive = false;
            public bool n_bFilename = false;
            public bool n_bUsed = false;
            public bool n_bOrder_id = false;
            public bool n_bDdate = false;
            public bool n_bDid = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.cid);
                }
                if (this.n_bMrt_no  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.mrt_no);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.active);
                }
                if (this.n_bFilename  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.filename.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFilename=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.filename);
                }
                if (this.n_bUsed  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.used.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bUsed=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.used);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.order_id);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.ddate);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileRetentionOrderAddRuleExceptionList.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileRetentionOrderAddRuleExceptionList.Para.did);
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
        
        public MobileRetentionOrderAddRuleExceptionListDalDAO(){
        }
        ~MobileRetentionOrderAddRuleExceptionListDalDAO(){
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
            _oSearchUtils.SetTable(MobileRetentionOrderAddRuleExceptionList.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileRetentionOrderAddRuleExceptionListEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileRetentionOrderAddRuleExceptionListRS x_oFieldsToReturn,MobileRetentionOrderAddRuleExceptionListRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileRetentionOrderAddRuleExceptionListEntity> _oMobileRetentionOrderAddRuleExceptionListList = new List<MobileRetentionOrderAddRuleExceptionListEntity>();
                
                while (_oDATA.Read())
                {
                    MobileRetentionOrderAddRuleExceptionList _oMobileRetentionOrderAddRuleExceptionList = new MobileRetentionOrderAddRuleExceptionList();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.id])) { _oMobileRetentionOrderAddRuleExceptionList.SetId((global::System.Nullable<int>)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.id]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.cdate])) { _oMobileRetentionOrderAddRuleExceptionList.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.cdate]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.cid])) { _oMobileRetentionOrderAddRuleExceptionList.SetCid((string)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.cid]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.mrt_no])) { _oMobileRetentionOrderAddRuleExceptionList.SetMrt_no((string)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.mrt_no]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetMrt_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.active])) { _oMobileRetentionOrderAddRuleExceptionList.SetActive((global::System.Nullable<bool>)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.active]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFilename))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.filename])) { _oMobileRetentionOrderAddRuleExceptionList.SetFilename((string)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.filename]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetFilename(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bUsed))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.used])) { _oMobileRetentionOrderAddRuleExceptionList.SetUsed((global::System.Nullable<bool>)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.used]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetUsed(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.order_id])) { _oMobileRetentionOrderAddRuleExceptionList.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.order_id]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.ddate])) { _oMobileRetentionOrderAddRuleExceptionList.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.ddate]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.did])) { _oMobileRetentionOrderAddRuleExceptionList.SetDid((string)_oDATA[MobileRetentionOrderAddRuleExceptionList.Para.did]); } else { _oMobileRetentionOrderAddRuleExceptionList.SetDid(global::System.String.Empty); }
                    }
                    _oMobileRetentionOrderAddRuleExceptionListList.Add(_oMobileRetentionOrderAddRuleExceptionList);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileRetentionOrderAddRuleExceptionListList;
            }
            return new List<MobileRetentionOrderAddRuleExceptionListEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileRetentionOrderAddRuleExceptionListEntity> OrderBy(string x_sSort, IQueryable<MobileRetentionOrderAddRuleExceptionListEntity> x_oMobileRetentionOrderAddRuleExceptionListBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileRetentionOrderAddRuleExceptionList.Para.id:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.cdate:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.cid:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.mrt_no:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.mrt_no).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.mrt_no).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.active:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.filename:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.filename).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.filename).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.used:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.used).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.used).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.order_id:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.ddate:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileRetentionOrderAddRuleExceptionList.Para.did:
                if(x_bAsc)
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileRetentionOrderAddRuleExceptionListBaseList = x_oMobileRetentionOrderAddRuleExceptionListBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
            }
            return x_oMobileRetentionOrderAddRuleExceptionListBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileRetentionOrderAddRuleExceptionListEntity> FindAll()
        {
            MobileRetentionOrderAddRuleExceptionListEntity[] _oMobileRetentionOrderAddRuleExceptionListsArr=  MobileRetentionOrderAddRuleExceptionListRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileRetentionOrderAddRuleExceptionListsArr != null)
            {
                IList<MobileRetentionOrderAddRuleExceptionListEntity> _oMobileRetentionOrderAddRuleExceptionListsList = (IList<MobileRetentionOrderAddRuleExceptionListEntity>)_oMobileRetentionOrderAddRuleExceptionListsArr;
                return _oMobileRetentionOrderAddRuleExceptionListsList;
            }
            return new List<MobileRetentionOrderAddRuleExceptionListEntity>();
        }
        
        public static IList<MobileRetentionOrderAddRuleExceptionListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileRetentionOrderAddRuleExceptionListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileRetentionOrderAddRuleExceptionListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileRetentionOrderAddRuleExceptionListEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileRetentionOrderAddRuleExceptionListRS x_oShowField = new MobileRetentionOrderAddRuleExceptionListRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileRetentionOrderAddRuleExceptionListRS x_oSortField=new MobileRetentionOrderAddRuleExceptionListRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileRetentionOrderAddRuleExceptionList.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileRetentionOrderAddRuleExceptionList.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileRetentionOrderAddRuleExceptionListRepositoryBase _oMobileRetentionOrderAddRuleExceptionListRepositoryBase = new MobileRetentionOrderAddRuleExceptionListRepositoryBase(GetDB());
            return _oMobileRetentionOrderAddRuleExceptionListRepositoryBase.GetCount();
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


