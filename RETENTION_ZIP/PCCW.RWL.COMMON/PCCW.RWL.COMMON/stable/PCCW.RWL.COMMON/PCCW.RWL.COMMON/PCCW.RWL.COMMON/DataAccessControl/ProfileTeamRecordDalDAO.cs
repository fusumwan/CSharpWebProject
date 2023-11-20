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
///-- Create date: <Create Date 2011-01-11>
///-- Description:	<Description,Table :[ProfileTeamRecord],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class ProfileTeamRecordDalDAO{
        
        #region RS
        public class ProfileTeamRecordRS
        {
            public bool n_bId = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bActive = false;
            public bool n_bRemark = false;
            public bool n_bEdate = false;
            public bool n_bSalesman_code = false;
            public bool n_bStaff_no = false;
            public bool n_bDdate = false;
            public bool n_bSdate = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (ProfileTeamRecord.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.id);
                }
                if (this.n_bCdate  || x_bSetShowALL || (ProfileTeamRecord.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (ProfileTeamRecord.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (ProfileTeamRecord.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.did);
                }
                if (this.n_bActive  || x_bSetShowALL || (ProfileTeamRecord.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.active);
                }
                if (this.n_bRemark  || x_bSetShowALL || (ProfileTeamRecord.Para.remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.remark);
                }
                if (this.n_bEdate  || x_bSetShowALL || (ProfileTeamRecord.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.edate);
                }
                if (this.n_bSalesman_code  || x_bSetShowALL || (ProfileTeamRecord.Para.salesman_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSalesman_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.salesman_code);
                }
                if (this.n_bStaff_no  || x_bSetShowALL || (ProfileTeamRecord.Para.staff_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStaff_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.staff_no);
                }
                if (this.n_bDdate  || x_bSetShowALL || (ProfileTeamRecord.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.ddate);
                }
                if (this.n_bSdate  || x_bSetShowALL || (ProfileTeamRecord.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecord.Para.sdate);
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
        
        public ProfileTeamRecordDalDAO(){
        }
        ~ProfileTeamRecordDalDAO(){
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
            _oSearchUtils.SetTable(ProfileTeamRecord.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<ProfileTeamRecordEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, ProfileTeamRecordRS x_oFieldsToReturn,ProfileTeamRecordRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<ProfileTeamRecordEntity> _oProfileTeamRecordList = new List<ProfileTeamRecordEntity>();
                
                while (_oDATA.Read())
                {
                    ProfileTeamRecord _oProfileTeamRecord = new ProfileTeamRecord();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.id])) { _oProfileTeamRecord.SetId((global::System.Nullable<int>)_oDATA[ProfileTeamRecord.Para.id]); } else { _oProfileTeamRecord.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.cdate])) { _oProfileTeamRecord.SetCdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecord.Para.cdate]); } else { _oProfileTeamRecord.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.cid])) { _oProfileTeamRecord.SetCid((string)_oDATA[ProfileTeamRecord.Para.cid]); } else { _oProfileTeamRecord.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.did])) { _oProfileTeamRecord.SetDid((string)_oDATA[ProfileTeamRecord.Para.did]); } else { _oProfileTeamRecord.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.active])) { _oProfileTeamRecord.SetActive((global::System.Nullable<bool>)_oDATA[ProfileTeamRecord.Para.active]); } else { _oProfileTeamRecord.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.remark])) { _oProfileTeamRecord.SetRemark((string)_oDATA[ProfileTeamRecord.Para.remark]); } else { _oProfileTeamRecord.SetRemark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.edate])) { _oProfileTeamRecord.SetEdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecord.Para.edate]); } else { _oProfileTeamRecord.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSalesman_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.salesman_code])) { _oProfileTeamRecord.SetSalesman_code((string)_oDATA[ProfileTeamRecord.Para.salesman_code]); } else { _oProfileTeamRecord.SetSalesman_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStaff_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.staff_no])) { _oProfileTeamRecord.SetStaff_no((string)_oDATA[ProfileTeamRecord.Para.staff_no]); } else { _oProfileTeamRecord.SetStaff_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.ddate])) { _oProfileTeamRecord.SetDdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecord.Para.ddate]); } else { _oProfileTeamRecord.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecord.Para.sdate])) { _oProfileTeamRecord.SetSdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecord.Para.sdate]); } else { _oProfileTeamRecord.SetSdate(null); }
                    }
                    _oProfileTeamRecordList.Add(_oProfileTeamRecord);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oProfileTeamRecordList;
            }
            return new List<ProfileTeamRecordEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<ProfileTeamRecordEntity> OrderBy(string x_sSort, IQueryable<ProfileTeamRecordEntity> x_oProfileTeamRecordBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case ProfileTeamRecord.Para.id:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case ProfileTeamRecord.Para.cdate:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case ProfileTeamRecord.Para.cid:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case ProfileTeamRecord.Para.did:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case ProfileTeamRecord.Para.active:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case ProfileTeamRecord.Para.remark:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.remark).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.remark).Select(c => c);
                break;
                case ProfileTeamRecord.Para.edate:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case ProfileTeamRecord.Para.salesman_code:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.salesman_code).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.salesman_code).Select(c => c);
                break;
                case ProfileTeamRecord.Para.staff_no:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.staff_no).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.staff_no).Select(c => c);
                break;
                case ProfileTeamRecord.Para.ddate:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case ProfileTeamRecord.Para.sdate:
                if(x_bAsc)
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oProfileTeamRecordBaseList = x_oProfileTeamRecordBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
            }
            return x_oProfileTeamRecordBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<ProfileTeamRecordEntity> FindAll()
        {
            ProfileTeamRecordEntity[] _oProfileTeamRecordsArr=  ProfileTeamRecordRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oProfileTeamRecordsArr != null)
            {
                IList<ProfileTeamRecordEntity> _oProfileTeamRecordsList = (IList<ProfileTeamRecordEntity>)_oProfileTeamRecordsArr;
                return _oProfileTeamRecordsList;
            }
            return new List<ProfileTeamRecordEntity>();
        }
        
        public static IList<ProfileTeamRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<ProfileTeamRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<ProfileTeamRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<ProfileTeamRecordEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            ProfileTeamRecordRS x_oShowField = new ProfileTeamRecordRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            ProfileTeamRecordRS x_oSortField=new ProfileTeamRecordRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(ProfileTeamRecord.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(ProfileTeamRecord.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            ProfileTeamRecordRepositoryBase _oProfileTeamRecordRepositoryBase = new ProfileTeamRecordRepositoryBase(GetDB());
            return _oProfileTeamRecordRepositoryBase.GetCount();
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


