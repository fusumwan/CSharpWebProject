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
///-- Create date: <Create Date 2011-12-07>
///-- Description:	<Description,Table :[MobileOrderReportHistory],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportHistoryDalDAO{
        
        #region RS
        public class MobileOrderReportHistoryRS
        {
            public bool n_bOrder_status = false;
            public bool n_bGw_retrieve_sn = false;
            public bool n_bSent_again = false;
            public bool n_bMid = false;
            public bool n_bEmail_date = false;
            public bool n_bRetrieve_cnt = false;
            public bool n_bFs_sent_again_retrieve_date = false;
            public bool n_bCdate = false;
            public bool n_bRetrieve_sn = false;
            public bool n_bCid = false;
            public bool n_bDid = false;
            public bool n_bSent_again_date = false;
            public bool n_bIdd_vas = false;
            public bool n_bActive = false;
            public bool n_bFallout_reason = false;
            public bool n_bFallout_remark = false;
            public bool n_bFallout_main_category = false;
            public bool n_bReport_type = false;
            public bool n_bFallout_reply = false;
            public bool n_bReactive_sn = false;
            public bool n_bDdate = false;
            public bool n_bExt_place_tel = false;
            public bool n_bReactive_date = false;
            public bool n_bGw_retrieve_date = false;
            public bool n_bRec_no = false;
            public bool n_bOrder_id = false;
            public bool n_bPy_sent_again_retrieve_date = false;
            public bool n_bRetrieve_date = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bOrder_status  || x_bSetShowALL || (MobileOrderReportHistory.Para.order_status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_status=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.order_status);
                }
                if (this.n_bGw_retrieve_sn  || x_bSetShowALL || (MobileOrderReportHistory.Para.gw_retrieve_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGw_retrieve_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.gw_retrieve_sn);
                }
                if (this.n_bSent_again  || x_bSetShowALL || (MobileOrderReportHistory.Para.sent_again.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSent_again=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.sent_again);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderReportHistory.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.mid);
                }
                if (this.n_bEmail_date  || x_bSetShowALL || (MobileOrderReportHistory.Para.email_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEmail_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.email_date);
                }
                if (this.n_bRetrieve_cnt  || x_bSetShowALL || (MobileOrderReportHistory.Para.retrieve_cnt.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_cnt=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.retrieve_cnt);
                }
                if (this.n_bFs_sent_again_retrieve_date  || x_bSetShowALL || (MobileOrderReportHistory.Para.fs_sent_again_retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFs_sent_again_retrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.fs_sent_again_retrieve_date);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderReportHistory.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.cdate);
                }
                if (this.n_bRetrieve_sn  || x_bSetShowALL || (MobileOrderReportHistory.Para.retrieve_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.retrieve_sn);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderReportHistory.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderReportHistory.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.did);
                }
                if (this.n_bSent_again_date  || x_bSetShowALL || (MobileOrderReportHistory.Para.sent_again_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSent_again_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.sent_again_date);
                }
                if (this.n_bIdd_vas  || x_bSetShowALL || (MobileOrderReportHistory.Para.idd_vas.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIdd_vas=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.idd_vas);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReportHistory.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.active);
                }
                if (this.n_bFallout_reason  || x_bSetShowALL || (MobileOrderReportHistory.Para.fallout_reason.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reason=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.fallout_reason);
                }
                if (this.n_bFallout_remark  || x_bSetShowALL || (MobileOrderReportHistory.Para.fallout_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.fallout_remark);
                }
                if (this.n_bFallout_main_category  || x_bSetShowALL || (MobileOrderReportHistory.Para.fallout_main_category.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_main_category=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.fallout_main_category);
                }
                if (this.n_bReport_type  || x_bSetShowALL || (MobileOrderReportHistory.Para.report_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.report_type);
                }
                if (this.n_bFallout_reply  || x_bSetShowALL || (MobileOrderReportHistory.Para.fallout_reply.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reply=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.fallout_reply);
                }
                if (this.n_bReactive_sn  || x_bSetShowALL || (MobileOrderReportHistory.Para.reactive_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.reactive_sn);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderReportHistory.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.ddate);
                }
                if (this.n_bExt_place_tel  || x_bSetShowALL || (MobileOrderReportHistory.Para.ext_place_tel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExt_place_tel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.ext_place_tel);
                }
                if (this.n_bReactive_date  || x_bSetShowALL || (MobileOrderReportHistory.Para.reactive_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.reactive_date);
                }
                if (this.n_bGw_retrieve_date  || x_bSetShowALL || (MobileOrderReportHistory.Para.gw_retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGw_retrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.gw_retrieve_date);
                }
                if (this.n_bRec_no  || x_bSetShowALL || (MobileOrderReportHistory.Para.rec_no.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRec_no=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.rec_no);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderReportHistory.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.order_id);
                }
                if (this.n_bPy_sent_again_retrieve_date  || x_bSetShowALL || (MobileOrderReportHistory.Para.py_sent_again_retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPy_sent_again_retrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.py_sent_again_retrieve_date);
                }
                if (this.n_bRetrieve_date  || x_bSetShowALL || (MobileOrderReportHistory.Para.retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReportHistory.Para.retrieve_date);
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
        
        public MobileOrderReportHistoryDalDAO(){
        }
        ~MobileOrderReportHistoryDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReportHistory.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportHistoryEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportHistoryRS x_oFieldsToReturn,MobileOrderReportHistoryRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportHistoryEntity> _oMobileOrderReportHistoryList = new List<MobileOrderReportHistoryEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReportHistory _oMobileOrderReportHistory = new MobileOrderReportHistory();
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_status))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.order_status])) { _oMobileOrderReportHistory.SetOrder_status((string)_oDATA[MobileOrderReportHistory.Para.order_status]); } else { _oMobileOrderReportHistory.SetOrder_status(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGw_retrieve_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.gw_retrieve_sn])) { _oMobileOrderReportHistory.SetGw_retrieve_sn((string)_oDATA[MobileOrderReportHistory.Para.gw_retrieve_sn]); } else { _oMobileOrderReportHistory.SetGw_retrieve_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSent_again))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.sent_again])) { _oMobileOrderReportHistory.SetSent_again((global::System.Nullable<int>)_oDATA[MobileOrderReportHistory.Para.sent_again]); } else { _oMobileOrderReportHistory.SetSent_again(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.mid])) { _oMobileOrderReportHistory.SetMid((global::System.Nullable<int>)_oDATA[MobileOrderReportHistory.Para.mid]); } else { _oMobileOrderReportHistory.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEmail_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.email_date])) { _oMobileOrderReportHistory.SetEmail_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.email_date]); } else { _oMobileOrderReportHistory.SetEmail_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_cnt))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.retrieve_cnt])) { _oMobileOrderReportHistory.SetRetrieve_cnt((global::System.Nullable<int>)_oDATA[MobileOrderReportHistory.Para.retrieve_cnt]); } else { _oMobileOrderReportHistory.SetRetrieve_cnt(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFs_sent_again_retrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.fs_sent_again_retrieve_date])) { _oMobileOrderReportHistory.SetFs_sent_again_retrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.fs_sent_again_retrieve_date]); } else { _oMobileOrderReportHistory.SetFs_sent_again_retrieve_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.cdate])) { _oMobileOrderReportHistory.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.cdate]); } else { _oMobileOrderReportHistory.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.retrieve_sn])) { _oMobileOrderReportHistory.SetRetrieve_sn((string)_oDATA[MobileOrderReportHistory.Para.retrieve_sn]); } else { _oMobileOrderReportHistory.SetRetrieve_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.cid])) { _oMobileOrderReportHistory.SetCid((string)_oDATA[MobileOrderReportHistory.Para.cid]); } else { _oMobileOrderReportHistory.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.did])) { _oMobileOrderReportHistory.SetDid((string)_oDATA[MobileOrderReportHistory.Para.did]); } else { _oMobileOrderReportHistory.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSent_again_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.sent_again_date])) { _oMobileOrderReportHistory.SetSent_again_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.sent_again_date]); } else { _oMobileOrderReportHistory.SetSent_again_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIdd_vas))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.idd_vas])) { _oMobileOrderReportHistory.SetIdd_vas((string)_oDATA[MobileOrderReportHistory.Para.idd_vas]); } else { _oMobileOrderReportHistory.SetIdd_vas(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.active])) { _oMobileOrderReportHistory.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReportHistory.Para.active]); } else { _oMobileOrderReportHistory.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reason))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.fallout_reason])) { _oMobileOrderReportHistory.SetFallout_reason((string)_oDATA[MobileOrderReportHistory.Para.fallout_reason]); } else { _oMobileOrderReportHistory.SetFallout_reason(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.fallout_remark])) { _oMobileOrderReportHistory.SetFallout_remark((string)_oDATA[MobileOrderReportHistory.Para.fallout_remark]); } else { _oMobileOrderReportHistory.SetFallout_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_main_category))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.fallout_main_category])) { _oMobileOrderReportHistory.SetFallout_main_category((string)_oDATA[MobileOrderReportHistory.Para.fallout_main_category]); } else { _oMobileOrderReportHistory.SetFallout_main_category(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.report_type])) { _oMobileOrderReportHistory.SetReport_type((string)_oDATA[MobileOrderReportHistory.Para.report_type]); } else { _oMobileOrderReportHistory.SetReport_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reply))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.fallout_reply])) { _oMobileOrderReportHistory.SetFallout_reply((string)_oDATA[MobileOrderReportHistory.Para.fallout_reply]); } else { _oMobileOrderReportHistory.SetFallout_reply(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.reactive_sn])) { _oMobileOrderReportHistory.SetReactive_sn((string)_oDATA[MobileOrderReportHistory.Para.reactive_sn]); } else { _oMobileOrderReportHistory.SetReactive_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.ddate])) { _oMobileOrderReportHistory.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.ddate]); } else { _oMobileOrderReportHistory.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExt_place_tel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.ext_place_tel])) { _oMobileOrderReportHistory.SetExt_place_tel((string)_oDATA[MobileOrderReportHistory.Para.ext_place_tel]); } else { _oMobileOrderReportHistory.SetExt_place_tel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.reactive_date])) { _oMobileOrderReportHistory.SetReactive_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.reactive_date]); } else { _oMobileOrderReportHistory.SetReactive_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGw_retrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.gw_retrieve_date])) { _oMobileOrderReportHistory.SetGw_retrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.gw_retrieve_date]); } else { _oMobileOrderReportHistory.SetGw_retrieve_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRec_no))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.rec_no])) { _oMobileOrderReportHistory.SetRec_no((global::System.Nullable<int>)_oDATA[MobileOrderReportHistory.Para.rec_no]); } else { _oMobileOrderReportHistory.SetRec_no(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.order_id])) { _oMobileOrderReportHistory.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderReportHistory.Para.order_id]); } else { _oMobileOrderReportHistory.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPy_sent_again_retrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.py_sent_again_retrieve_date])) { _oMobileOrderReportHistory.SetPy_sent_again_retrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.py_sent_again_retrieve_date]); } else { _oMobileOrderReportHistory.SetPy_sent_again_retrieve_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReportHistory.Para.retrieve_date])) { _oMobileOrderReportHistory.SetRetrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReportHistory.Para.retrieve_date]); } else { _oMobileOrderReportHistory.SetRetrieve_date(null); }
                    }
                    _oMobileOrderReportHistoryList.Add(_oMobileOrderReportHistory);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportHistoryList;
            }
            return new List<MobileOrderReportHistoryEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportHistoryEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportHistoryEntity> x_oMobileOrderReportHistoryBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReportHistory.Para.order_status:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.order_status).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.order_status).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.gw_retrieve_sn:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.gw_retrieve_sn).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.gw_retrieve_sn).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.sent_again:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.sent_again).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.sent_again).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.email_date:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.email_date).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.email_date).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.retrieve_cnt:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.retrieve_cnt).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.retrieve_cnt).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.fs_sent_again_retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.fs_sent_again_retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.fs_sent_again_retrieve_date).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.retrieve_sn:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.retrieve_sn).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.retrieve_sn).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.did:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.sent_again_date:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.sent_again_date).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.sent_again_date).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.idd_vas:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.idd_vas).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.idd_vas).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.fallout_reason:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.fallout_reason).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.fallout_reason).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.fallout_remark:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.fallout_remark).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.fallout_remark).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.fallout_main_category:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.fallout_main_category).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.fallout_main_category).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.report_type:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.report_type).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.report_type).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.fallout_reply:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.fallout_reply).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.fallout_reply).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.reactive_sn:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.reactive_sn).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.reactive_sn).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.ext_place_tel:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.ext_place_tel).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.ext_place_tel).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.reactive_date:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.reactive_date).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.reactive_date).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.gw_retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.gw_retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.gw_retrieve_date).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.rec_no:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.rec_no).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.rec_no).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.py_sent_again_retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.py_sent_again_retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.py_sent_again_retrieve_date).Select(c => c);
                break;
                case MobileOrderReportHistory.Para.retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderBy(c => c.retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportHistoryBaseList = x_oMobileOrderReportHistoryBaseList.OrderByDescending(c => c.retrieve_date).Select(c => c);
                break;
            }
            return x_oMobileOrderReportHistoryBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportHistoryEntity> FindAll()
        {
            MobileOrderReportHistoryEntity[] _oMobileOrderReportHistorysArr=  MobileOrderReportHistoryRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportHistorysArr != null)
            {
                IList<MobileOrderReportHistoryEntity> _oMobileOrderReportHistorysList = (IList<MobileOrderReportHistoryEntity>)_oMobileOrderReportHistorysArr;
                return _oMobileOrderReportHistorysList;
            }
            return new List<MobileOrderReportHistoryEntity>();
        }
        
        public static IList<MobileOrderReportHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportHistoryEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportHistoryRS x_oShowField = new MobileOrderReportHistoryRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportHistoryRS x_oSortField=new MobileOrderReportHistoryRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReportHistory.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReportHistory.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportHistoryRepositoryBase _oMobileOrderReportHistoryRepositoryBase = new MobileOrderReportHistoryRepositoryBase(GetDB());
            return _oMobileOrderReportHistoryRepositoryBase.GetCount();
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


