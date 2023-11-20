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
///-- Create date: <Create Date 2011-01-14>
///-- Description:	<Description,Table :[ProfileTeamRecordHistory],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class ProfileTeamRecordHistoryDalDAO{
        
        #region RS
        public class ProfileTeamRecordHistoryRS
        {
            public bool n_bActive = false;
            public bool n_bCdate = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bAction_type = false;
            public bool n_bEdate = false;
            public bool n_bRec_no = false;
            public bool n_bSalesman_code = false;
            public bool n_bHis_id = false;
            public bool n_bStaff_no = false;
            public bool n_bDdate = false;
            public bool n_bSdate = false;
            public bool n_bRemark = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bActive  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.active);
                }
                if (this.n_bCdate  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.cdate);
                }
                if (this.n_bCid  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.did);
                }
                if (this.n_bAction_type  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.action_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bAction_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.action_type);
                }
                if (this.n_bEdate  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.edate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.edate);
                }
                if (this.n_bRec_no  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.rec_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRec_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.rec_no);
                }
                if (this.n_bSalesman_code  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.salesman_code.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSalesman_code=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.salesman_code);
                }
                if (this.n_bHis_id  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.his_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHis_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.his_id);
                }
                if (this.n_bStaff_no  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.staff_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bStaff_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.staff_no);
                }
                if (this.n_bDdate  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.ddate);
                }
                if (this.n_bSdate  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.sdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.sdate);
                }
                if (this.n_bRemark  || x_bSetShowALL || (ProfileTeamRecordHistory.Para.remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRemark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(ProfileTeamRecordHistory.Para.remark);
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
        
        public ProfileTeamRecordHistoryDalDAO(){
        }
        ~ProfileTeamRecordHistoryDalDAO(){
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
            _oSearchUtils.SetTable(ProfileTeamRecordHistory.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<ProfileTeamRecordHistoryEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, ProfileTeamRecordHistoryRS x_oFieldsToReturn,ProfileTeamRecordHistoryRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<ProfileTeamRecordHistoryEntity> _oProfileTeamRecordHistoryList = new List<ProfileTeamRecordHistoryEntity>();
                
                while (_oDATA.Read())
                {
                    ProfileTeamRecordHistory _oProfileTeamRecordHistory = new ProfileTeamRecordHistory();
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.active])) { _oProfileTeamRecordHistory.SetActive((global::System.Nullable<bool>)_oDATA[ProfileTeamRecordHistory.Para.active]); } else { _oProfileTeamRecordHistory.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.cdate])) { _oProfileTeamRecordHistory.SetCdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecordHistory.Para.cdate]); } else { _oProfileTeamRecordHistory.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.cid])) { _oProfileTeamRecordHistory.SetCid((string)_oDATA[ProfileTeamRecordHistory.Para.cid]); } else { _oProfileTeamRecordHistory.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.did])) { _oProfileTeamRecordHistory.SetDid((string)_oDATA[ProfileTeamRecordHistory.Para.did]); } else { _oProfileTeamRecordHistory.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bAction_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.action_type])) { _oProfileTeamRecordHistory.SetAction_type((string)_oDATA[ProfileTeamRecordHistory.Para.action_type]); } else { _oProfileTeamRecordHistory.SetAction_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.edate])) { _oProfileTeamRecordHistory.SetEdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecordHistory.Para.edate]); } else { _oProfileTeamRecordHistory.SetEdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRec_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.rec_no])) { _oProfileTeamRecordHistory.SetRec_no((global::System.Nullable<int>)_oDATA[ProfileTeamRecordHistory.Para.rec_no]); } else { _oProfileTeamRecordHistory.SetRec_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSalesman_code))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.salesman_code])) { _oProfileTeamRecordHistory.SetSalesman_code((string)_oDATA[ProfileTeamRecordHistory.Para.salesman_code]); } else { _oProfileTeamRecordHistory.SetSalesman_code(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHis_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.his_id])) { _oProfileTeamRecordHistory.SetHis_id((global::System.Nullable<long>)_oDATA[ProfileTeamRecordHistory.Para.his_id]); } else { _oProfileTeamRecordHistory.SetHis_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bStaff_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.staff_no])) { _oProfileTeamRecordHistory.SetStaff_no((string)_oDATA[ProfileTeamRecordHistory.Para.staff_no]); } else { _oProfileTeamRecordHistory.SetStaff_no(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.ddate])) { _oProfileTeamRecordHistory.SetDdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecordHistory.Para.ddate]); } else { _oProfileTeamRecordHistory.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.sdate])) { _oProfileTeamRecordHistory.SetSdate((global::System.Nullable<DateTime>)_oDATA[ProfileTeamRecordHistory.Para.sdate]); } else { _oProfileTeamRecordHistory.SetSdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRemark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[ProfileTeamRecordHistory.Para.remark])) { _oProfileTeamRecordHistory.SetRemark((string)_oDATA[ProfileTeamRecordHistory.Para.remark]); } else { _oProfileTeamRecordHistory.SetRemark(global::System.String.Empty); }
                    }
                    _oProfileTeamRecordHistoryList.Add(_oProfileTeamRecordHistory);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oProfileTeamRecordHistoryList;
            }
            return new List<ProfileTeamRecordHistoryEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<ProfileTeamRecordHistoryEntity> OrderBy(string x_sSort, IQueryable<ProfileTeamRecordHistoryEntity> x_oProfileTeamRecordHistoryBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case ProfileTeamRecordHistory.Para.active:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.cdate:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.cid:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.did:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.action_type:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.action_type).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.action_type).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.edate:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.edate).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.edate).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.rec_no:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.rec_no).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.rec_no).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.salesman_code:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.salesman_code).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.salesman_code).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.his_id:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.his_id).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.his_id).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.staff_no:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.staff_no).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.staff_no).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.ddate:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.sdate:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.sdate).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.sdate).Select(c => c);
                break;
                case ProfileTeamRecordHistory.Para.remark:
                if(x_bAsc)
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderBy(c => c.remark).Select(c => c);
                else
                    x_oProfileTeamRecordHistoryBaseList = x_oProfileTeamRecordHistoryBaseList.OrderByDescending(c => c.remark).Select(c => c);
                break;
            }
            return x_oProfileTeamRecordHistoryBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<ProfileTeamRecordHistoryEntity> FindAll()
        {
            ProfileTeamRecordHistoryEntity[] _oProfileTeamRecordHistorysArr=  ProfileTeamRecordHistoryRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oProfileTeamRecordHistorysArr != null)
            {
                IList<ProfileTeamRecordHistoryEntity> _oProfileTeamRecordHistorysList = (IList<ProfileTeamRecordHistoryEntity>)_oProfileTeamRecordHistorysArr;
                return _oProfileTeamRecordHistorysList;
            }
            return new List<ProfileTeamRecordHistoryEntity>();
        }
        
        public static IList<ProfileTeamRecordHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<ProfileTeamRecordHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<ProfileTeamRecordHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<ProfileTeamRecordHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            ProfileTeamRecordHistoryRS x_oShowField = new ProfileTeamRecordHistoryRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            ProfileTeamRecordHistoryRS x_oSortField=new ProfileTeamRecordHistoryRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(ProfileTeamRecordHistory.Para.his_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(ProfileTeamRecordHistory.Para.his_id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            ProfileTeamRecordHistoryRepositoryBase _oProfileTeamRecordHistoryRepositoryBase = new ProfileTeamRecordHistoryRepositoryBase(GetDB());
            return _oProfileTeamRecordHistoryRepositoryBase.GetCount();
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


