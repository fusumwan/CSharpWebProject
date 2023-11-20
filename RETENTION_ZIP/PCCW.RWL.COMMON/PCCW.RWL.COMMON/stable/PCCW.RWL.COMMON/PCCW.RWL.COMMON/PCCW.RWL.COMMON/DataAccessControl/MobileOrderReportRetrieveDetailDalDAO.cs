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
///-- Description:	<Description,Table :[MobileOrderReportRetrieveDetail],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportRetrieveDetailDalDAO{
        
        #region RS
        public class MobileOrderReportRetrieveDetailRS
        {
            public bool n_bId = false;
            public bool n_bDid = false;
            public bool n_bActive = false;
            public bool n_bGuid_id = false;
            public bool n_bRetrieve_group = false;
            public bool n_bRetrieve_date = false;
            public bool n_bDdate = false;
            public bool n_bRetrieve_sn = false;
            public bool n_bReport_type = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bId  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.id);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.did);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.active);
                }
                if (this.n_bGuid_id  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.guid_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGuid_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.guid_id);
                }
                if (this.n_bRetrieve_group  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.retrieve_group.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_group=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.retrieve_group);
                }
                if (this.n_bRetrieve_date  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.retrieve_date);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.ddate);
                }
                if (this.n_bRetrieve_sn  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.retrieve_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.retrieve_sn);
                }
                if (this.n_bReport_type  || x_bSetShowALL || (MobileOrderReportRetrieveDetail.Para.report_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportRetrieveDetail.Para.report_type);
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
        
        public MobileOrderReportRetrieveDetailDalDAO(){
        }
        ~MobileOrderReportRetrieveDetailDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReportRetrieveDetail.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportRetrieveDetailEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportRetrieveDetailRS x_oFieldsToReturn,MobileOrderReportRetrieveDetailRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportRetrieveDetailEntity> _oMobileOrderReportRetrieveDetailList = new List<MobileOrderReportRetrieveDetailEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReportRetrieveDetail _oMobileOrderReportRetrieveDetail = new MobileOrderReportRetrieveDetail();
                    if ((true).Equals(x_oFieldsToReturn.n_bId))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.id])) { _oMobileOrderReportRetrieveDetail.SetId((global::System.Nullable<int>)_oDATA[MobileOrderReportRetrieveDetail.Para.id]); } else { _oMobileOrderReportRetrieveDetail.SetId(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.did])) { _oMobileOrderReportRetrieveDetail.SetDid((string)_oDATA[MobileOrderReportRetrieveDetail.Para.did]); } else { _oMobileOrderReportRetrieveDetail.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.active])) { _oMobileOrderReportRetrieveDetail.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReportRetrieveDetail.Para.active]); } else { _oMobileOrderReportRetrieveDetail.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGuid_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.guid_id])) { _oMobileOrderReportRetrieveDetail.SetGuid_id((global::System.Nullable<Guid>)_oDATA[MobileOrderReportRetrieveDetail.Para.guid_id]); } else { _oMobileOrderReportRetrieveDetail.SetGuid_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_group))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.retrieve_group])) { _oMobileOrderReportRetrieveDetail.SetRetrieve_group((string)_oDATA[MobileOrderReportRetrieveDetail.Para.retrieve_group]); } else { _oMobileOrderReportRetrieveDetail.SetRetrieve_group(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.retrieve_date])) { _oMobileOrderReportRetrieveDetail.SetRetrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportRetrieveDetail.Para.retrieve_date]); } else { _oMobileOrderReportRetrieveDetail.SetRetrieve_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.ddate])) { _oMobileOrderReportRetrieveDetail.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportRetrieveDetail.Para.ddate]); } else { _oMobileOrderReportRetrieveDetail.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.retrieve_sn])) { _oMobileOrderReportRetrieveDetail.SetRetrieve_sn((string)_oDATA[MobileOrderReportRetrieveDetail.Para.retrieve_sn]); } else { _oMobileOrderReportRetrieveDetail.SetRetrieve_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportRetrieveDetail.Para.report_type])) { _oMobileOrderReportRetrieveDetail.SetReport_type((string)_oDATA[MobileOrderReportRetrieveDetail.Para.report_type]); } else { _oMobileOrderReportRetrieveDetail.SetReport_type(global::System.String.Empty); }
                    }
                    _oMobileOrderReportRetrieveDetailList.Add(_oMobileOrderReportRetrieveDetail);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportRetrieveDetailList;
            }
            return new List<MobileOrderReportRetrieveDetailEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportRetrieveDetailEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportRetrieveDetailEntity> x_oMobileOrderReportRetrieveDetailBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReportRetrieveDetail.Para.id:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.id).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.id).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.did:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.guid_id:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.guid_id).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.guid_id).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.retrieve_group:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.retrieve_group).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.retrieve_group).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.retrieve_date).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.retrieve_sn:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.retrieve_sn).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.retrieve_sn).Select(c => c);
                break;
                case MobileOrderReportRetrieveDetail.Para.report_type:
                if(x_bAsc)
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderBy(c => c.report_type).Select(c => c);
                else
                    x_oMobileOrderReportRetrieveDetailBaseList = x_oMobileOrderReportRetrieveDetailBaseList.OrderByDescending(c => c.report_type).Select(c => c);
                break;
            }
            return x_oMobileOrderReportRetrieveDetailBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportRetrieveDetailEntity> FindAll()
        {
            MobileOrderReportRetrieveDetailEntity[] _oMobileOrderReportRetrieveDetailsArr=  MobileOrderReportRetrieveDetailRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportRetrieveDetailsArr != null)
            {
                IList<MobileOrderReportRetrieveDetailEntity> _oMobileOrderReportRetrieveDetailsList = (IList<MobileOrderReportRetrieveDetailEntity>)_oMobileOrderReportRetrieveDetailsArr;
                return _oMobileOrderReportRetrieveDetailsList;
            }
            return new List<MobileOrderReportRetrieveDetailEntity>();
        }
        
        public static IList<MobileOrderReportRetrieveDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportRetrieveDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportRetrieveDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportRetrieveDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportRetrieveDetailRS x_oShowField = new MobileOrderReportRetrieveDetailRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportRetrieveDetailRS x_oSortField=new MobileOrderReportRetrieveDetailRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReportRetrieveDetail.Para.id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReportRetrieveDetail.Para.id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportRetrieveDetailRepositoryBase _oMobileOrderReportRetrieveDetailRepositoryBase = new MobileOrderReportRetrieveDetailRepositoryBase(GetDB());
            return _oMobileOrderReportRetrieveDetailRepositoryBase.GetCount();
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


