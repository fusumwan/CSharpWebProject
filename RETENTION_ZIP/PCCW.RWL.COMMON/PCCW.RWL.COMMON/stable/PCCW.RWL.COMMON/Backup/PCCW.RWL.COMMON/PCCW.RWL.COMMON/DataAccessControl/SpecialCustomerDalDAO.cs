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
///-- Create date: <Create Date 2010-04-19>
///-- Description:	<Description,Table :[SpecialCustomer],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class SpecialCustomerDalDAO{
        
        #region RS
        public class SpecialCustomerRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bCondition4 = false;
            public bool n_bStatus = false;
            public bool n_bActive = false;
            public bool n_bCondition3 = false;
            public bool n_bCondition5 = false;
            public bool n_bHkid = false;
            public bool n_bCondition1 = false;
            public bool n_bDdate = false;
            public bool n_bCount = false;
            public bool n_bDid = false;
            public bool n_bCondition2 = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (SpecialCustomer.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (SpecialCustomer.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (SpecialCustomer.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.cid);
                }
                if (this.n_bCondition4  || x_bSetShowALL || (SpecialCustomer.Para.condition4.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCondition4=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.condition4);
                }
                if (this.n_bStatus  || x_bSetShowALL || (SpecialCustomer.Para.status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStatus=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.status);
                }
                if (this.n_bActive  || x_bSetShowALL || (SpecialCustomer.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.active);
                }
                if (this.n_bCondition3  || x_bSetShowALL || (SpecialCustomer.Para.condition3.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCondition3=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.condition3);
                }
                if (this.n_bCondition5  || x_bSetShowALL || (SpecialCustomer.Para.condition5.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCondition5=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.condition5);
                }
                if (this.n_bHkid  || x_bSetShowALL || (SpecialCustomer.Para.hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.hkid);
                }
                if (this.n_bCondition1  || x_bSetShowALL || (SpecialCustomer.Para.condition1.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCondition1=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.condition1);
                }
                if (this.n_bDdate  || x_bSetShowALL || (SpecialCustomer.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.ddate);
                }
                if (this.n_bCount  || x_bSetShowALL || (SpecialCustomer.Para.count.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCount=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.count);
                }
                if (this.n_bDid  || x_bSetShowALL || (SpecialCustomer.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.did);
                }
                if (this.n_bCondition2  || x_bSetShowALL || (SpecialCustomer.Para.condition2.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCondition2=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(SpecialCustomer.Para.condition2);
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
        
        public SpecialCustomerDalDAO(){
        }
        ~SpecialCustomerDalDAO(){
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
            _oSearchUtils.SetTable(SpecialCustomer.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<SpecialCustomerEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, SpecialCustomerRS x_oFieldsToReturn,SpecialCustomerRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<SpecialCustomerEntity> _oSpecialCustomerList = new List<SpecialCustomerEntity>();
                
                while (_oDATA.Read())
                {
                    SpecialCustomer _oSpecialCustomer = new SpecialCustomer();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.id])) { _oSpecialCustomer.SetId((global::System.Nullable<int>)_oDATA[SpecialCustomer.Para.id]); } else { _oSpecialCustomer.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.cdate])) { _oSpecialCustomer.SetCdate((global::System.Nullable<DateTime>)_oDATA[SpecialCustomer.Para.cdate]); } else { _oSpecialCustomer.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.cid])) { _oSpecialCustomer.SetCid((string)_oDATA[SpecialCustomer.Para.cid]); } else { _oSpecialCustomer.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCondition4))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.condition4])) { _oSpecialCustomer.SetCondition4((string)_oDATA[SpecialCustomer.Para.condition4]); } else { _oSpecialCustomer.SetCondition4(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStatus))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.status])) { _oSpecialCustomer.SetStatus((string)_oDATA[SpecialCustomer.Para.status]); } else { _oSpecialCustomer.SetStatus(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.active])) { _oSpecialCustomer.SetActive((global::System.Nullable<bool>)_oDATA[SpecialCustomer.Para.active]); } else { _oSpecialCustomer.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCondition3))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.condition3])) { _oSpecialCustomer.SetCondition3((string)_oDATA[SpecialCustomer.Para.condition3]); } else { _oSpecialCustomer.SetCondition3(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCondition5))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.condition5])) { _oSpecialCustomer.SetCondition5((string)_oDATA[SpecialCustomer.Para.condition5]); } else { _oSpecialCustomer.SetCondition5(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.hkid])) { _oSpecialCustomer.SetHkid((string)_oDATA[SpecialCustomer.Para.hkid]); } else { _oSpecialCustomer.SetHkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCondition1))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.condition1])) { _oSpecialCustomer.SetCondition1((string)_oDATA[SpecialCustomer.Para.condition1]); } else { _oSpecialCustomer.SetCondition1(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.ddate])) { _oSpecialCustomer.SetDdate((global::System.Nullable<DateTime>)_oDATA[SpecialCustomer.Para.ddate]); } else { _oSpecialCustomer.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCount))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.count])) { _oSpecialCustomer.SetCount((global::System.Nullable<int>)_oDATA[SpecialCustomer.Para.count]); } else { _oSpecialCustomer.SetCount(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.did])) { _oSpecialCustomer.SetDid((string)_oDATA[SpecialCustomer.Para.did]); } else { _oSpecialCustomer.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCondition2))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[SpecialCustomer.Para.condition2])) { _oSpecialCustomer.SetCondition2((string)_oDATA[SpecialCustomer.Para.condition2]); } else { _oSpecialCustomer.SetCondition2(global::System.String.Empty); }
                    }
                    _oSpecialCustomerList.Add(_oSpecialCustomer);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oSpecialCustomerList;
            }
            return new List<SpecialCustomerEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<SpecialCustomerEntity> OrderBy(string x_sSort, IQueryable<SpecialCustomerEntity> x_oSpecialCustomerBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case SpecialCustomer.Para.id:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case SpecialCustomer.Para.cdate:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case SpecialCustomer.Para.cid:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case SpecialCustomer.Para.condition4:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.condition4).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.condition4).Select(c => c);
                break;
                case SpecialCustomer.Para.status:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.status).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.status).Select(c => c);
                break;
                case SpecialCustomer.Para.active:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case SpecialCustomer.Para.condition3:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.condition3).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.condition3).Select(c => c);
                break;
                case SpecialCustomer.Para.condition5:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.condition5).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.condition5).Select(c => c);
                break;
                case SpecialCustomer.Para.hkid:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.hkid).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.hkid).Select(c => c);
                break;
                case SpecialCustomer.Para.condition1:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.condition1).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.condition1).Select(c => c);
                break;
                case SpecialCustomer.Para.ddate:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case SpecialCustomer.Para.count:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.count).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.count).Select(c => c);
                break;
                case SpecialCustomer.Para.did:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case SpecialCustomer.Para.condition2:
                if(x_bAsc)
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderBy(c => c.condition2).Select(c => c);
                else
                    x_oSpecialCustomerBaseList = x_oSpecialCustomerBaseList.OrderByDescending(c => c.condition2).Select(c => c);
                break;
            }
            return x_oSpecialCustomerBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<SpecialCustomerEntity> FindAll()
        {
            SpecialCustomerEntity[] _oSpecialCustomersArr=  SpecialCustomerRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oSpecialCustomersArr != null)
            {
                IList<SpecialCustomerEntity> _oSpecialCustomersList = (IList<SpecialCustomerEntity>)_oSpecialCustomersArr;
                return _oSpecialCustomersList;
            }
            return new List<SpecialCustomerEntity>();
        }
        
        public static IList<SpecialCustomerEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<SpecialCustomerEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<SpecialCustomerEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<SpecialCustomerEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            SpecialCustomerRS x_oShowField = new SpecialCustomerRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            SpecialCustomerRS x_oSortField=new SpecialCustomerRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(SpecialCustomer.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(SpecialCustomer.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            SpecialCustomerRepositoryBase _oSpecialCustomerRepositoryBase = new SpecialCustomerRepositoryBase(GetDB());
            return _oSpecialCustomerRepositoryBase.GetCount();
        }
        #endregion
        
        #region GetDB
        public static MSSQLConnect GetDB()
        {
            MSSQLConnect _oDB = new MSSQLConnect();
            _oDB.SetConnStr("MobileRetentionOrderDB");
            return _oDB;
        }
        #endregion
        #region
        public void Release(){}
        #endregion
    }
}


