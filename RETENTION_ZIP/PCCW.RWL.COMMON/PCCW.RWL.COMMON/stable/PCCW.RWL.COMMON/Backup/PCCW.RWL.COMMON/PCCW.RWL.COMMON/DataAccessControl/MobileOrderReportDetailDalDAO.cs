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
///-- Description:	<Description,Table :[MobileOrderReportDetail],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportDetailDalDAO{
        
        #region RS
        public class MobileOrderReportDetailRS
        {
            public bool n_bOrder_status = false;
            public bool n_bFallout_reply = false;
            public bool n_bMflag = false;
            public bool n_bEmail_date = false;
            public bool n_bRetrieve_cnt = false;
            public bool n_bCdate = false;
            public bool n_bRetrieve_sn = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bEid = false;
            public bool n_bReport_id = false;
            public bool n_bActive = false;
            public bool n_bFallout_reason = false;
            public bool n_bFallout_remark = false;
            public bool n_bFallout_main_category = false;
            public bool n_bReport_type = false;
            public bool n_bReactive_sn = false;
            public bool n_bDdate = false;
            public bool n_bMdate = false;
            public bool n_bReactive_date = false;
            public bool n_bOrder_id = false;
            public bool n_bRetrieve_date = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bOrder_status  || x_bSetShowALL || (MobileOrderReportDetail.Para.order_status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_status=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.order_status);
                }
                if (this.n_bFallout_reply  || x_bSetShowALL || (MobileOrderReportDetail.Para.fallout_reply.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reply=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.fallout_reply);
                }
                if (this.n_bMflag  || x_bSetShowALL || (MobileOrderReportDetail.Para.mflag.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMflag=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.mflag);
                }
                if (this.n_bEmail_date  || x_bSetShowALL || (MobileOrderReportDetail.Para.email_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEmail_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.email_date);
                }
                if (this.n_bRetrieve_cnt  || x_bSetShowALL || (MobileOrderReportDetail.Para.retrieve_cnt.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_cnt=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.retrieve_cnt);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderReportDetail.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.cdate);
                }
                if (this.n_bRetrieve_sn  || x_bSetShowALL || (MobileOrderReportDetail.Para.retrieve_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.retrieve_sn);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderReportDetail.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderReportDetail.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.did);
                }
                if (this.n_bEid  || x_bSetShowALL || (MobileOrderReportDetail.Para.eid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.eid);
                }
                if (this.n_bReport_id  || x_bSetShowALL || (MobileOrderReportDetail.Para.report_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.report_id);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReportDetail.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.active);
                }
                if (this.n_bFallout_reason  || x_bSetShowALL || (MobileOrderReportDetail.Para.fallout_reason.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reason=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.fallout_reason);
                }
                if (this.n_bFallout_remark  || x_bSetShowALL || (MobileOrderReportDetail.Para.fallout_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.fallout_remark);
                }
                if (this.n_bFallout_main_category  || x_bSetShowALL || (MobileOrderReportDetail.Para.fallout_main_category.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_main_category=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.fallout_main_category);
                }
                if (this.n_bReport_type  || x_bSetShowALL || (MobileOrderReportDetail.Para.report_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.report_type);
                }
                if (this.n_bReactive_sn  || x_bSetShowALL || (MobileOrderReportDetail.Para.reactive_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.reactive_sn);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderReportDetail.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.ddate);
                }
                if (this.n_bMdate  || x_bSetShowALL || (MobileOrderReportDetail.Para.mdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.mdate);
                }
                if (this.n_bReactive_date  || x_bSetShowALL || (MobileOrderReportDetail.Para.reactive_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.reactive_date);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderReportDetail.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.order_id);
                }
                if (this.n_bRetrieve_date  || x_bSetShowALL || (MobileOrderReportDetail.Para.retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetail.Para.retrieve_date);
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
        
        public MobileOrderReportDetailDalDAO(){
        }
        ~MobileOrderReportDetailDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReportDetail.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportDetailEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportDetailRS x_oFieldsToReturn,MobileOrderReportDetailRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportDetailEntity> _oMobileOrderReportDetailList = new List<MobileOrderReportDetailEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReportDetail _oMobileOrderReportDetail = new MobileOrderReportDetail();
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_status))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.order_status])) { _oMobileOrderReportDetail.SetOrder_status((string)_oDATA[MobileOrderReportDetail.Para.order_status]); } else { _oMobileOrderReportDetail.SetOrder_status(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reply))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.fallout_reply])) { _oMobileOrderReportDetail.SetFallout_reply((string)_oDATA[MobileOrderReportDetail.Para.fallout_reply]); } else { _oMobileOrderReportDetail.SetFallout_reply(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMflag))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.mflag])) { _oMobileOrderReportDetail.SetMflag((global::System.Nullable<bool>)_oDATA[MobileOrderReportDetail.Para.mflag]); } else { _oMobileOrderReportDetail.SetMflag(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEmail_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.email_date])) { _oMobileOrderReportDetail.SetEmail_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetail.Para.email_date]); } else { _oMobileOrderReportDetail.SetEmail_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_cnt))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.retrieve_cnt])) { _oMobileOrderReportDetail.SetRetrieve_cnt((global::System.Nullable<int>)_oDATA[MobileOrderReportDetail.Para.retrieve_cnt]); } else { _oMobileOrderReportDetail.SetRetrieve_cnt(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.cdate])) { _oMobileOrderReportDetail.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetail.Para.cdate]); } else { _oMobileOrderReportDetail.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.retrieve_sn])) { _oMobileOrderReportDetail.SetRetrieve_sn((string)_oDATA[MobileOrderReportDetail.Para.retrieve_sn]); } else { _oMobileOrderReportDetail.SetRetrieve_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.cid])) { _oMobileOrderReportDetail.SetCid((string)_oDATA[MobileOrderReportDetail.Para.cid]); } else { _oMobileOrderReportDetail.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.did])) { _oMobileOrderReportDetail.SetDid((string)_oDATA[MobileOrderReportDetail.Para.did]); } else { _oMobileOrderReportDetail.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.eid])) { _oMobileOrderReportDetail.SetEid((string)_oDATA[MobileOrderReportDetail.Para.eid]); } else { _oMobileOrderReportDetail.SetEid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.report_id])) { _oMobileOrderReportDetail.SetReport_id((global::System.Nullable<int>)_oDATA[MobileOrderReportDetail.Para.report_id]); } else { _oMobileOrderReportDetail.SetReport_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.active])) { _oMobileOrderReportDetail.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReportDetail.Para.active]); } else { _oMobileOrderReportDetail.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reason))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.fallout_reason])) { _oMobileOrderReportDetail.SetFallout_reason((string)_oDATA[MobileOrderReportDetail.Para.fallout_reason]); } else { _oMobileOrderReportDetail.SetFallout_reason(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.fallout_remark])) { _oMobileOrderReportDetail.SetFallout_remark((string)_oDATA[MobileOrderReportDetail.Para.fallout_remark]); } else { _oMobileOrderReportDetail.SetFallout_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_main_category))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.fallout_main_category])) { _oMobileOrderReportDetail.SetFallout_main_category((string)_oDATA[MobileOrderReportDetail.Para.fallout_main_category]); } else { _oMobileOrderReportDetail.SetFallout_main_category(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.report_type])) { _oMobileOrderReportDetail.SetReport_type((string)_oDATA[MobileOrderReportDetail.Para.report_type]); } else { _oMobileOrderReportDetail.SetReport_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.reactive_sn])) { _oMobileOrderReportDetail.SetReactive_sn((string)_oDATA[MobileOrderReportDetail.Para.reactive_sn]); } else { _oMobileOrderReportDetail.SetReactive_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.ddate])) { _oMobileOrderReportDetail.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetail.Para.ddate]); } else { _oMobileOrderReportDetail.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.mdate])) { _oMobileOrderReportDetail.SetMdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetail.Para.mdate]); } else { _oMobileOrderReportDetail.SetMdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.reactive_date])) { _oMobileOrderReportDetail.SetReactive_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetail.Para.reactive_date]); } else { _oMobileOrderReportDetail.SetReactive_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.order_id])) { _oMobileOrderReportDetail.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderReportDetail.Para.order_id]); } else { _oMobileOrderReportDetail.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetail.Para.retrieve_date])) { _oMobileOrderReportDetail.SetRetrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetail.Para.retrieve_date]); } else { _oMobileOrderReportDetail.SetRetrieve_date(null); }
                    }
                    _oMobileOrderReportDetailList.Add(_oMobileOrderReportDetail);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportDetailList;
            }
            return new List<MobileOrderReportDetailEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportDetailEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportDetailEntity> x_oMobileOrderReportDetailBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReportDetail.Para.order_status:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.order_status).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.order_status).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.fallout_reply:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.fallout_reply).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.fallout_reply).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.mflag:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.mflag).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.mflag).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.email_date:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.email_date).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.email_date).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.retrieve_cnt:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.retrieve_cnt).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.retrieve_cnt).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.retrieve_sn:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.retrieve_sn).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.retrieve_sn).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.did:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.eid:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.eid).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.eid).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.report_id:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.report_id).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.report_id).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.fallout_reason:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.fallout_reason).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.fallout_reason).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.fallout_remark:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.fallout_remark).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.fallout_remark).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.fallout_main_category:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.fallout_main_category).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.fallout_main_category).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.report_type:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.report_type).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.report_type).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.reactive_sn:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.reactive_sn).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.reactive_sn).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.mdate:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.mdate).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.mdate).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.reactive_date:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.reactive_date).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.reactive_date).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderReportDetail.Para.retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderBy(c => c.retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportDetailBaseList = x_oMobileOrderReportDetailBaseList.OrderByDescending(c => c.retrieve_date).Select(c => c);
                break;
            }
            return x_oMobileOrderReportDetailBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportDetailEntity> FindAll()
        {
            MobileOrderReportDetailEntity[] _oMobileOrderReportDetailsArr=  MobileOrderReportDetailRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportDetailsArr != null)
            {
                IList<MobileOrderReportDetailEntity> _oMobileOrderReportDetailsList = (IList<MobileOrderReportDetailEntity>)_oMobileOrderReportDetailsArr;
                return _oMobileOrderReportDetailsList;
            }
            return new List<MobileOrderReportDetailEntity>();
        }
        
        public static IList<MobileOrderReportDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportDetailRS x_oShowField = new MobileOrderReportDetailRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportDetailRS x_oSortField=new MobileOrderReportDetailRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReportDetail.Para.report_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReportDetail.Para.report_id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportDetailRepositoryBase _oMobileOrderReportDetailRepositoryBase = new MobileOrderReportDetailRepositoryBase(GetDB());
            return _oMobileOrderReportDetailRepositoryBase.GetCount();
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


