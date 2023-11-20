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
///-- Create date: <Create Date 2011-09-01>
///-- Description:	<Description,Table :[MobileNumberProfile],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileNumberProfileDalDAO{
        
        #region RS
        public class MobileNumberProfileRS
        {
            public bool n_bPool = false;
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bMrt_no = false;
            public bool n_bStatus = false;
            public bool n_bMrt_group = false;
            public bool n_bActive = false;
            public bool n_bEdf_no = false;
            public bool n_bOrder_id = false;
            public bool n_bDdate = false;
            public bool n_bDid = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bPool  || x_bSetShowALL || (MobileNumberProfile.Para.pool.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPool=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.pool);
                }
                if (this.n_bId  || x_bSetShowALL || (MobileNumberProfile.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileNumberProfile.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileNumberProfile.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.cid);
                }
                if (this.n_bMrt_no  || x_bSetShowALL || (MobileNumberProfile.Para.mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.mrt_no);
                }
                if (this.n_bStatus  || x_bSetShowALL || (MobileNumberProfile.Para.status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStatus=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.status);
                }
                if (this.n_bMrt_group  || x_bSetShowALL || (MobileNumberProfile.Para.mrt_group.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMrt_group=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.mrt_group);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileNumberProfile.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.active);
                }
                if (this.n_bEdf_no  || x_bSetShowALL || (MobileNumberProfile.Para.edf_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdf_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.edf_no);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileNumberProfile.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.order_id);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileNumberProfile.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.ddate);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileNumberProfile.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileNumberProfile.Para.did);
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
        
        public MobileNumberProfileDalDAO(){
        }
        ~MobileNumberProfileDalDAO(){
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
            _oSearchUtils.SetTable(MobileNumberProfile.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileNumberProfileEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileNumberProfileRS x_oFieldsToReturn,MobileNumberProfileRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileNumberProfileEntity> _oMobileNumberProfileList = new List<MobileNumberProfileEntity>();
                
                while (_oDATA.Read())
                {
                    MobileNumberProfile _oMobileNumberProfile = new MobileNumberProfile();
                    if ((true).Equals(x_oFieldsToReturn.n_bPool))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.pool])) { _oMobileNumberProfile.SetPool((string)_oDATA[MobileNumberProfile.Para.pool]); } else { _oMobileNumberProfile.SetPool(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.id])) { _oMobileNumberProfile.SetId((global::System.Nullable<int>)_oDATA[MobileNumberProfile.Para.id]); } else { _oMobileNumberProfile.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.cdate])) { _oMobileNumberProfile.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileNumberProfile.Para.cdate]); } else { _oMobileNumberProfile.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.cid])) { _oMobileNumberProfile.SetCid((string)_oDATA[MobileNumberProfile.Para.cid]); } else { _oMobileNumberProfile.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.mrt_no])) { _oMobileNumberProfile.SetMrt_no((global::System.Nullable<long>)_oDATA[MobileNumberProfile.Para.mrt_no]); } else { _oMobileNumberProfile.SetMrt_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStatus))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.status])) { _oMobileNumberProfile.SetStatus((string)_oDATA[MobileNumberProfile.Para.status]); } else { _oMobileNumberProfile.SetStatus(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMrt_group))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.mrt_group])) { _oMobileNumberProfile.SetMrt_group((string)_oDATA[MobileNumberProfile.Para.mrt_group]); } else { _oMobileNumberProfile.SetMrt_group(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.active])) { _oMobileNumberProfile.SetActive((global::System.Nullable<bool>)_oDATA[MobileNumberProfile.Para.active]); } else { _oMobileNumberProfile.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdf_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.edf_no])) { _oMobileNumberProfile.SetEdf_no((string)_oDATA[MobileNumberProfile.Para.edf_no]); } else { _oMobileNumberProfile.SetEdf_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.order_id])) { _oMobileNumberProfile.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileNumberProfile.Para.order_id]); } else { _oMobileNumberProfile.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.ddate])) { _oMobileNumberProfile.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileNumberProfile.Para.ddate]); } else { _oMobileNumberProfile.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileNumberProfile.Para.did])) { _oMobileNumberProfile.SetDid((string)_oDATA[MobileNumberProfile.Para.did]); } else { _oMobileNumberProfile.SetDid(global::System.String.Empty); }
                    }
                    _oMobileNumberProfileList.Add(_oMobileNumberProfile);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileNumberProfileList;
            }
            return new List<MobileNumberProfileEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileNumberProfileEntity> OrderBy(string x_sSort, IQueryable<MobileNumberProfileEntity> x_oMobileNumberProfileBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileNumberProfile.Para.pool:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.pool).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.pool).Select(c => c);
                break;
                case MobileNumberProfile.Para.id:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileNumberProfile.Para.cdate:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileNumberProfile.Para.cid:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileNumberProfile.Para.mrt_no:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.mrt_no).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.mrt_no).Select(c => c);
                break;
                case MobileNumberProfile.Para.status:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.status).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.status).Select(c => c);
                break;
                case MobileNumberProfile.Para.mrt_group:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.mrt_group).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.mrt_group).Select(c => c);
                break;
                case MobileNumberProfile.Para.active:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileNumberProfile.Para.edf_no:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.edf_no).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.edf_no).Select(c => c);
                break;
                case MobileNumberProfile.Para.order_id:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileNumberProfile.Para.ddate:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileNumberProfile.Para.did:
                if(x_bAsc)
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileNumberProfileBaseList = x_oMobileNumberProfileBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
            }
            return x_oMobileNumberProfileBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileNumberProfileEntity> FindAll()
        {
            MobileNumberProfileEntity[] _oMobileNumberProfilesArr=  MobileNumberProfileRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileNumberProfilesArr != null)
            {
                IList<MobileNumberProfileEntity> _oMobileNumberProfilesList = (IList<MobileNumberProfileEntity>)_oMobileNumberProfilesArr;
                return _oMobileNumberProfilesList;
            }
            return new List<MobileNumberProfileEntity>();
        }
        
        public static IList<MobileNumberProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileNumberProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileNumberProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileNumberProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileNumberProfileRS x_oShowField = new MobileNumberProfileRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileNumberProfileRS x_oSortField=new MobileNumberProfileRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileNumberProfile.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileNumberProfile.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileNumberProfileRepositoryBase _oMobileNumberProfileRepositoryBase = new MobileNumberProfileRepositoryBase(GetDB());
            return _oMobileNumberProfileRepositoryBase.GetCount();
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


