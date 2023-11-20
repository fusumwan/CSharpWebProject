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
///-- Create date: <Create Date 2010-12-17>
///-- Description:	<Description,Table :[MobileOrderIssueRestrictionProfile],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderIssueRestrictionProfileDalDAO{
        
        #region RS
        public class MobileOrderIssueRestrictionProfileRS
        {
            public bool n_bMid = false;
            public bool n_bCdate = false;
            public bool n_bMrt_no = false;
            public bool n_bCid = false;
            public bool n_bActive = false;
            public bool n_bRestriction_id = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderIssueRestrictionProfile.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionProfile.Para.mid);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderIssueRestrictionProfile.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionProfile.Para.cdate);
                }
                if (this.n_bMrt_no  || x_bSetShowALL || (MobileOrderIssueRestrictionProfile.Para.mrt_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMrt_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionProfile.Para.mrt_no);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderIssueRestrictionProfile.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionProfile.Para.cid);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderIssueRestrictionProfile.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionProfile.Para.active);
                }
                if (this.n_bRestriction_id  || x_bSetShowALL || (MobileOrderIssueRestrictionProfile.Para.restriction_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRestriction_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderIssueRestrictionProfile.Para.restriction_id);
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
        
        public MobileOrderIssueRestrictionProfileDalDAO(){
        }
        ~MobileOrderIssueRestrictionProfileDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderIssueRestrictionProfile.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderIssueRestrictionProfileEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderIssueRestrictionProfileRS x_oFieldsToReturn,MobileOrderIssueRestrictionProfileRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfileList = new List<MobileOrderIssueRestrictionProfileEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderIssueRestrictionProfile _oMobileOrderIssueRestrictionProfile = new MobileOrderIssueRestrictionProfile();
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionProfile.Para.mid])) { _oMobileOrderIssueRestrictionProfile.SetMid((global::System.Nullable<int>)_oDATA[MobileOrderIssueRestrictionProfile.Para.mid]); } else { _oMobileOrderIssueRestrictionProfile.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionProfile.Para.cdate])) { _oMobileOrderIssueRestrictionProfile.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderIssueRestrictionProfile.Para.cdate]); } else { _oMobileOrderIssueRestrictionProfile.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMrt_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionProfile.Para.mrt_no])) { _oMobileOrderIssueRestrictionProfile.SetMrt_no((global::System.Nullable<int>)_oDATA[MobileOrderIssueRestrictionProfile.Para.mrt_no]); } else { _oMobileOrderIssueRestrictionProfile.SetMrt_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionProfile.Para.cid])) { _oMobileOrderIssueRestrictionProfile.SetCid((string)_oDATA[MobileOrderIssueRestrictionProfile.Para.cid]); } else { _oMobileOrderIssueRestrictionProfile.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionProfile.Para.active])) { _oMobileOrderIssueRestrictionProfile.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderIssueRestrictionProfile.Para.active]); } else { _oMobileOrderIssueRestrictionProfile.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRestriction_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderIssueRestrictionProfile.Para.restriction_id])) { _oMobileOrderIssueRestrictionProfile.SetRestriction_id((global::System.Nullable<int>)_oDATA[MobileOrderIssueRestrictionProfile.Para.restriction_id]); } else { _oMobileOrderIssueRestrictionProfile.SetRestriction_id(null); }
                    }
                    _oMobileOrderIssueRestrictionProfileList.Add(_oMobileOrderIssueRestrictionProfile);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderIssueRestrictionProfileList;
            }
            return new List<MobileOrderIssueRestrictionProfileEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderIssueRestrictionProfileEntity> OrderBy(string x_sSort, IQueryable<MobileOrderIssueRestrictionProfileEntity> x_oMobileOrderIssueRestrictionProfileBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderIssueRestrictionProfile.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderIssueRestrictionProfile.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderIssueRestrictionProfile.Para.mrt_no:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderBy(c => c.mrt_no).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderByDescending(c => c.mrt_no).Select(c => c);
                break;
                case MobileOrderIssueRestrictionProfile.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderIssueRestrictionProfile.Para.active:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderIssueRestrictionProfile.Para.restriction_id:
                if(x_bAsc)
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderBy(c => c.restriction_id).Select(c => c);
                else
                    x_oMobileOrderIssueRestrictionProfileBaseList = x_oMobileOrderIssueRestrictionProfileBaseList.OrderByDescending(c => c.restriction_id).Select(c => c);
                break;
            }
            return x_oMobileOrderIssueRestrictionProfileBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderIssueRestrictionProfileEntity> FindAll()
        {
            MobileOrderIssueRestrictionProfileEntity[] _oMobileOrderIssueRestrictionProfilesArr=  MobileOrderIssueRestrictionProfileRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderIssueRestrictionProfilesArr != null)
            {
                IList<MobileOrderIssueRestrictionProfileEntity> _oMobileOrderIssueRestrictionProfilesList = (IList<MobileOrderIssueRestrictionProfileEntity>)_oMobileOrderIssueRestrictionProfilesArr;
                return _oMobileOrderIssueRestrictionProfilesList;
            }
            return new List<MobileOrderIssueRestrictionProfileEntity>();
        }
        
        public static IList<MobileOrderIssueRestrictionProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderIssueRestrictionProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderIssueRestrictionProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderIssueRestrictionProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, x_sRowFilter,true);
        }

        public static IList<MobileOrderIssueRestrictionProfileEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem, string x_sRowFilter,bool x_bAscDirection)
        {
            MobileOrderIssueRestrictionProfileRS x_oShowField = new MobileOrderIssueRestrictionProfileRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderIssueRestrictionProfileRS x_oSortField = new MobileOrderIssueRestrictionProfileRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderIssueRestrictionProfile.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression))
            {
                x_oSortField.FieldsToReturn(x_sSortExpression, false);
            }
            x_oSortField.FieldsToReturn(MobileOrderIssueRestrictionProfile.Para.mid, false);
            return SearchList(x_oSearchItem, x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize), x_oShowField, x_oSortField, x_bAscDirection);
        }


        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderIssueRestrictionProfileRepositoryBase _oMobileOrderIssueRestrictionProfileRepositoryBase = new MobileOrderIssueRestrictionProfileRepositoryBase(GetDB());
            return _oMobileOrderIssueRestrictionProfileRepositoryBase.GetCount();
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


