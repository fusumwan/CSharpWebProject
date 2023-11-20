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
///-- Description:	<Description,Table :[MobileOrderReportDetailHistory],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportDetailHistoryDalDAO{
        
        #region RS
        public class MobileOrderReportDetailHistoryRS
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
            public bool n_bActive = false;
            public bool n_bFallout_reason = false;
            public bool n_bFallout_remark = false;
            public bool n_bFallout_main_category = false;
            public bool n_bReport_his_id = false;
            public bool n_bReport_type = false;
            public bool n_bReactive_sn = false;
            public bool n_bDdate = false;
            public bool n_bMdate = false;
            public bool n_bReactive_date = false;
            public bool n_bOrder_id = false;
            public bool n_bRec_no = false;
            public bool n_bRetrieve_date = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bOrder_status  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.order_status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_status=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.order_status);
                }
                if (this.n_bFallout_reply  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.fallout_reply.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reply=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.fallout_reply);
                }
                if (this.n_bMflag  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.mflag.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMflag=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.mflag);
                }
                if (this.n_bEmail_date  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.email_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEmail_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.email_date);
                }
                if (this.n_bRetrieve_cnt  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.retrieve_cnt.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_cnt=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.retrieve_cnt);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.cdate);
                }
                if (this.n_bRetrieve_sn  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.retrieve_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.retrieve_sn);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.did);
                }
                if (this.n_bEid  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.eid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.eid);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.active);
                }
                if (this.n_bFallout_reason  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.fallout_reason.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reason=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.fallout_reason);
                }
                if (this.n_bFallout_remark  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.fallout_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.fallout_remark);
                }
                if (this.n_bFallout_main_category  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.fallout_main_category.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_main_category=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.fallout_main_category);
                }
                if (this.n_bReport_his_id  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.report_his_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_his_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.report_his_id);
                }
                if (this.n_bReport_type  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.report_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.report_type);
                }
                if (this.n_bReactive_sn  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.reactive_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.reactive_sn);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.ddate);
                }
                if (this.n_bMdate  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.mdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.mdate);
                }
                if (this.n_bReactive_date  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.reactive_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.reactive_date);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.order_id);
                }
                if (this.n_bRec_no  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.rec_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRec_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.rec_no);
                }
                if (this.n_bRetrieve_date  || x_bSetShowALL || (MobileOrderReportDetailHistory.Para.retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportDetailHistory.Para.retrieve_date);
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
        
        public MobileOrderReportDetailHistoryDalDAO(){
        }
        ~MobileOrderReportDetailHistoryDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReportDetailHistory.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportDetailHistoryEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportDetailHistoryRS x_oFieldsToReturn,MobileOrderReportDetailHistoryRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportDetailHistoryEntity> _oMobileOrderReportDetailHistoryList = new List<MobileOrderReportDetailHistoryEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReportDetailHistory _oMobileOrderReportDetailHistory = new MobileOrderReportDetailHistory();
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_status))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.order_status])) { _oMobileOrderReportDetailHistory.SetOrder_status((string)_oDATA[MobileOrderReportDetailHistory.Para.order_status]); } else { _oMobileOrderReportDetailHistory.SetOrder_status(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reply))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.fallout_reply])) { _oMobileOrderReportDetailHistory.SetFallout_reply((string)_oDATA[MobileOrderReportDetailHistory.Para.fallout_reply]); } else { _oMobileOrderReportDetailHistory.SetFallout_reply(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMflag))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.mflag])) { _oMobileOrderReportDetailHistory.SetMflag((global::System.Nullable<bool>)_oDATA[MobileOrderReportDetailHistory.Para.mflag]); } else { _oMobileOrderReportDetailHistory.SetMflag(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEmail_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.email_date])) { _oMobileOrderReportDetailHistory.SetEmail_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetailHistory.Para.email_date]); } else { _oMobileOrderReportDetailHistory.SetEmail_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_cnt))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.retrieve_cnt])) { _oMobileOrderReportDetailHistory.SetRetrieve_cnt((global::System.Nullable<int>)_oDATA[MobileOrderReportDetailHistory.Para.retrieve_cnt]); } else { _oMobileOrderReportDetailHistory.SetRetrieve_cnt(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.cdate])) { _oMobileOrderReportDetailHistory.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetailHistory.Para.cdate]); } else { _oMobileOrderReportDetailHistory.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.retrieve_sn])) { _oMobileOrderReportDetailHistory.SetRetrieve_sn((string)_oDATA[MobileOrderReportDetailHistory.Para.retrieve_sn]); } else { _oMobileOrderReportDetailHistory.SetRetrieve_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.cid])) { _oMobileOrderReportDetailHistory.SetCid((string)_oDATA[MobileOrderReportDetailHistory.Para.cid]); } else { _oMobileOrderReportDetailHistory.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.did])) { _oMobileOrderReportDetailHistory.SetDid((string)_oDATA[MobileOrderReportDetailHistory.Para.did]); } else { _oMobileOrderReportDetailHistory.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.eid])) { _oMobileOrderReportDetailHistory.SetEid((string)_oDATA[MobileOrderReportDetailHistory.Para.eid]); } else { _oMobileOrderReportDetailHistory.SetEid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.active])) { _oMobileOrderReportDetailHistory.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReportDetailHistory.Para.active]); } else { _oMobileOrderReportDetailHistory.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reason))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.fallout_reason])) { _oMobileOrderReportDetailHistory.SetFallout_reason((string)_oDATA[MobileOrderReportDetailHistory.Para.fallout_reason]); } else { _oMobileOrderReportDetailHistory.SetFallout_reason(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.fallout_remark])) { _oMobileOrderReportDetailHistory.SetFallout_remark((string)_oDATA[MobileOrderReportDetailHistory.Para.fallout_remark]); } else { _oMobileOrderReportDetailHistory.SetFallout_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_main_category))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.fallout_main_category])) { _oMobileOrderReportDetailHistory.SetFallout_main_category((string)_oDATA[MobileOrderReportDetailHistory.Para.fallout_main_category]); } else { _oMobileOrderReportDetailHistory.SetFallout_main_category(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_his_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.report_his_id])) { _oMobileOrderReportDetailHistory.SetReport_his_id((global::System.Nullable<int>)_oDATA[MobileOrderReportDetailHistory.Para.report_his_id]); } else { _oMobileOrderReportDetailHistory.SetReport_his_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.report_type])) { _oMobileOrderReportDetailHistory.SetReport_type((string)_oDATA[MobileOrderReportDetailHistory.Para.report_type]); } else { _oMobileOrderReportDetailHistory.SetReport_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.reactive_sn])) { _oMobileOrderReportDetailHistory.SetReactive_sn((string)_oDATA[MobileOrderReportDetailHistory.Para.reactive_sn]); } else { _oMobileOrderReportDetailHistory.SetReactive_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.ddate])) { _oMobileOrderReportDetailHistory.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetailHistory.Para.ddate]); } else { _oMobileOrderReportDetailHistory.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.mdate])) { _oMobileOrderReportDetailHistory.SetMdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetailHistory.Para.mdate]); } else { _oMobileOrderReportDetailHistory.SetMdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.reactive_date])) { _oMobileOrderReportDetailHistory.SetReactive_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetailHistory.Para.reactive_date]); } else { _oMobileOrderReportDetailHistory.SetReactive_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.order_id])) { _oMobileOrderReportDetailHistory.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderReportDetailHistory.Para.order_id]); } else { _oMobileOrderReportDetailHistory.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRec_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.rec_no])) { _oMobileOrderReportDetailHistory.SetRec_no((global::System.Nullable<int>)_oDATA[MobileOrderReportDetailHistory.Para.rec_no]); } else { _oMobileOrderReportDetailHistory.SetRec_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportDetailHistory.Para.retrieve_date])) { _oMobileOrderReportDetailHistory.SetRetrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportDetailHistory.Para.retrieve_date]); } else { _oMobileOrderReportDetailHistory.SetRetrieve_date(null); }
                    }
                    _oMobileOrderReportDetailHistoryList.Add(_oMobileOrderReportDetailHistory);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportDetailHistoryList;
            }
            return new List<MobileOrderReportDetailHistoryEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportDetailHistoryEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportDetailHistoryEntity> x_oMobileOrderReportDetailHistoryBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReportDetailHistory.Para.order_status:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.order_status).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.order_status).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.fallout_reply:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.fallout_reply).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.fallout_reply).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.mflag:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.mflag).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.mflag).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.email_date:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.email_date).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.email_date).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.retrieve_cnt:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.retrieve_cnt).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.retrieve_cnt).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.retrieve_sn:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.retrieve_sn).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.retrieve_sn).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.did:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.eid:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.eid).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.eid).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.fallout_reason:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.fallout_reason).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.fallout_reason).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.fallout_remark:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.fallout_remark).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.fallout_remark).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.fallout_main_category:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.fallout_main_category).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.fallout_main_category).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.report_his_id:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.report_his_id).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.report_his_id).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.report_type:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.report_type).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.report_type).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.reactive_sn:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.reactive_sn).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.reactive_sn).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.mdate:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.mdate).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.mdate).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.reactive_date:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.reactive_date).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.reactive_date).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.rec_no:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.rec_no).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.rec_no).Select(c => c);
                break;
                case MobileOrderReportDetailHistory.Para.retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderBy(c => c.retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportDetailHistoryBaseList = x_oMobileOrderReportDetailHistoryBaseList.OrderByDescending(c => c.retrieve_date).Select(c => c);
                break;
            }
            return x_oMobileOrderReportDetailHistoryBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportDetailHistoryEntity> FindAll()
        {
            MobileOrderReportDetailHistoryEntity[] _oMobileOrderReportDetailHistorysArr=  MobileOrderReportDetailHistoryRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportDetailHistorysArr != null)
            {
                IList<MobileOrderReportDetailHistoryEntity> _oMobileOrderReportDetailHistorysList = (IList<MobileOrderReportDetailHistoryEntity>)_oMobileOrderReportDetailHistorysArr;
                return _oMobileOrderReportDetailHistorysList;
            }
            return new List<MobileOrderReportDetailHistoryEntity>();
        }
        
        public static IList<MobileOrderReportDetailHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportDetailHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportDetailHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportDetailHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportDetailHistoryRS x_oShowField = new MobileOrderReportDetailHistoryRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportDetailHistoryRS x_oSortField=new MobileOrderReportDetailHistoryRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReportDetailHistory.Para.report_his_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReportDetailHistory.Para.report_his_id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportDetailHistoryRepositoryBase _oMobileOrderReportDetailHistoryRepositoryBase = new MobileOrderReportDetailHistoryRepositoryBase(GetDB());
            return _oMobileOrderReportDetailHistoryRepositoryBase.GetCount();
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


