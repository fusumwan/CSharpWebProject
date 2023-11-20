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
///-- Create date: <Create Date 2011-12-07>
///-- Description:	<Description,Table :[MobileOrderReport],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderReportDalDAO{
        
        #region RS
        public class MobileOrderReportRS
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
            public bool n_bOrder_id = false;
            public bool n_bPy_sent_again_retrieve_date = false;
            public bool n_bRetrieve_date = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bOrder_status  || x_bSetShowALL || (MobileOrderReport.Para.order_status.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_status=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.order_status);
                }
                if (this.n_bGw_retrieve_sn  || x_bSetShowALL || (MobileOrderReport.Para.gw_retrieve_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGw_retrieve_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.gw_retrieve_sn);
                }
                if (this.n_bSent_again  || x_bSetShowALL || (MobileOrderReport.Para.sent_again.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSent_again=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.sent_again);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderReport.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.mid);
                }
                if (this.n_bEmail_date  || x_bSetShowALL || (MobileOrderReport.Para.email_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bEmail_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.email_date);
                }
                if (this.n_bRetrieve_cnt  || x_bSetShowALL || (MobileOrderReport.Para.retrieve_cnt.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_cnt=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.retrieve_cnt);
                }
                if (this.n_bFs_sent_again_retrieve_date  || x_bSetShowALL || (MobileOrderReport.Para.fs_sent_again_retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFs_sent_again_retrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.fs_sent_again_retrieve_date);
                }
                if (this.n_bCdate  || x_bSetShowALL || (MobileOrderReport.Para.cdate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.cdate);
                }
                if (this.n_bRetrieve_sn  || x_bSetShowALL || (MobileOrderReport.Para.retrieve_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.retrieve_sn);
                }
                if (this.n_bCid  || x_bSetShowALL || (MobileOrderReport.Para.cid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.cid);
                }
                if (this.n_bDid  || x_bSetShowALL || (MobileOrderReport.Para.did.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.did);
                }
                if (this.n_bSent_again_date  || x_bSetShowALL || (MobileOrderReport.Para.sent_again_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bSent_again_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.sent_again_date);
                }
                if (this.n_bIdd_vas  || x_bSetShowALL || (MobileOrderReport.Para.idd_vas.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bIdd_vas=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.idd_vas);
                }
                if (this.n_bActive  || x_bSetShowALL || (MobileOrderReport.Para.active.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bActive=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.active);
                }
                if (this.n_bFallout_reason  || x_bSetShowALL || (MobileOrderReport.Para.fallout_reason.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reason=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.fallout_reason);
                }
                if (this.n_bFallout_remark  || x_bSetShowALL || (MobileOrderReport.Para.fallout_remark.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_remark=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.fallout_remark);
                }
                if (this.n_bFallout_main_category  || x_bSetShowALL || (MobileOrderReport.Para.fallout_main_category.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_main_category=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.fallout_main_category);
                }
                if (this.n_bReport_type  || x_bSetShowALL || (MobileOrderReport.Para.report_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReport_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.report_type);
                }
                if (this.n_bFallout_reply  || x_bSetShowALL || (MobileOrderReport.Para.fallout_reply.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bFallout_reply=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.fallout_reply);
                }
                if (this.n_bReactive_sn  || x_bSetShowALL || (MobileOrderReport.Para.reactive_sn.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_sn=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.reactive_sn);
                }
                if (this.n_bDdate  || x_bSetShowALL || (MobileOrderReport.Para.ddate.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bDdate=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.ddate);
                }
                if (this.n_bExt_place_tel  || x_bSetShowALL || (MobileOrderReport.Para.ext_place_tel.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bExt_place_tel=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.ext_place_tel);
                }
                if (this.n_bReactive_date  || x_bSetShowALL || (MobileOrderReport.Para.reactive_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bReactive_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.reactive_date);
                }
                if (this.n_bGw_retrieve_date  || x_bSetShowALL || (MobileOrderReport.Para.gw_retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bGw_retrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.gw_retrieve_date);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderReport.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.order_id);
                }
                if (this.n_bPy_sent_again_retrieve_date  || x_bSetShowALL || (MobileOrderReport.Para.py_sent_again_retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bPy_sent_again_retrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.py_sent_again_retrieve_date);
                }
                if (this.n_bRetrieve_date  || x_bSetShowALL || (MobileOrderReport.Para.retrieve_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRetrieve_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderReport.Para.retrieve_date);
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
        
        public MobileOrderReportDalDAO(){
        }
        ~MobileOrderReportDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderReport.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderReportEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderReportRS x_oFieldsToReturn,MobileOrderReportRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderReportEntity> _oMobileOrderReportList = new List<MobileOrderReportEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderReport _oMobileOrderReport = new MobileOrderReport();
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_status))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.order_status])) { _oMobileOrderReport.SetOrder_status((string)_oDATA[MobileOrderReport.Para.order_status]); } else { _oMobileOrderReport.SetOrder_status(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGw_retrieve_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.gw_retrieve_sn])) { _oMobileOrderReport.SetGw_retrieve_sn((string)_oDATA[MobileOrderReport.Para.gw_retrieve_sn]); } else { _oMobileOrderReport.SetGw_retrieve_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSent_again))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.sent_again])) { _oMobileOrderReport.SetSent_again((global::System.Nullable<int>)_oDATA[MobileOrderReport.Para.sent_again]); } else { _oMobileOrderReport.SetSent_again(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.mid])) { _oMobileOrderReport.SetMid((global::System.Nullable<int>)_oDATA[MobileOrderReport.Para.mid]); } else { _oMobileOrderReport.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bEmail_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.email_date])) { _oMobileOrderReport.SetEmail_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.email_date]); } else { _oMobileOrderReport.SetEmail_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_cnt))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.retrieve_cnt])) { _oMobileOrderReport.SetRetrieve_cnt((global::System.Nullable<int>)_oDATA[MobileOrderReport.Para.retrieve_cnt]); } else { _oMobileOrderReport.SetRetrieve_cnt(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFs_sent_again_retrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.fs_sent_again_retrieve_date])) { _oMobileOrderReport.SetFs_sent_again_retrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.fs_sent_again_retrieve_date]); } else { _oMobileOrderReport.SetFs_sent_again_retrieve_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.cdate])) { _oMobileOrderReport.SetCdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.cdate]); } else { _oMobileOrderReport.SetCdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.retrieve_sn])) { _oMobileOrderReport.SetRetrieve_sn((string)_oDATA[MobileOrderReport.Para.retrieve_sn]); } else { _oMobileOrderReport.SetRetrieve_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.cid])) { _oMobileOrderReport.SetCid((string)_oDATA[MobileOrderReport.Para.cid]); } else { _oMobileOrderReport.SetCid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.did])) { _oMobileOrderReport.SetDid((string)_oDATA[MobileOrderReport.Para.did]); } else { _oMobileOrderReport.SetDid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bSent_again_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.sent_again_date])) { _oMobileOrderReport.SetSent_again_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.sent_again_date]); } else { _oMobileOrderReport.SetSent_again_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bIdd_vas))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.idd_vas])) { _oMobileOrderReport.SetIdd_vas((string)_oDATA[MobileOrderReport.Para.idd_vas]); } else { _oMobileOrderReport.SetIdd_vas(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bActive))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.active])) { _oMobileOrderReport.SetActive((global::System.Nullable<bool>)_oDATA[MobileOrderReport.Para.active]); } else { _oMobileOrderReport.SetActive(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reason))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.fallout_reason])) { _oMobileOrderReport.SetFallout_reason((string)_oDATA[MobileOrderReport.Para.fallout_reason]); } else { _oMobileOrderReport.SetFallout_reason(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_remark))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.fallout_remark])) { _oMobileOrderReport.SetFallout_remark((string)_oDATA[MobileOrderReport.Para.fallout_remark]); } else { _oMobileOrderReport.SetFallout_remark(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_main_category))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.fallout_main_category])) { _oMobileOrderReport.SetFallout_main_category((string)_oDATA[MobileOrderReport.Para.fallout_main_category]); } else { _oMobileOrderReport.SetFallout_main_category(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReport_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.report_type])) { _oMobileOrderReport.SetReport_type((string)_oDATA[MobileOrderReport.Para.report_type]); } else { _oMobileOrderReport.SetReport_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bFallout_reply))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.fallout_reply])) { _oMobileOrderReport.SetFallout_reply((string)_oDATA[MobileOrderReport.Para.fallout_reply]); } else { _oMobileOrderReport.SetFallout_reply(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_sn))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.reactive_sn])) { _oMobileOrderReport.SetReactive_sn((string)_oDATA[MobileOrderReport.Para.reactive_sn]); } else { _oMobileOrderReport.SetReactive_sn(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bDdate))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.ddate])) { _oMobileOrderReport.SetDdate((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.ddate]); } else { _oMobileOrderReport.SetDdate(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bExt_place_tel))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.ext_place_tel])) { _oMobileOrderReport.SetExt_place_tel((string)_oDATA[MobileOrderReport.Para.ext_place_tel]); } else { _oMobileOrderReport.SetExt_place_tel(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bReactive_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.reactive_date])) { _oMobileOrderReport.SetReactive_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.reactive_date]); } else { _oMobileOrderReport.SetReactive_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bGw_retrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.gw_retrieve_date])) { _oMobileOrderReport.SetGw_retrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.gw_retrieve_date]); } else { _oMobileOrderReport.SetGw_retrieve_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.order_id])) { _oMobileOrderReport.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderReport.Para.order_id]); } else { _oMobileOrderReport.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bPy_sent_again_retrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.py_sent_again_retrieve_date])) { _oMobileOrderReport.SetPy_sent_again_retrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.py_sent_again_retrieve_date]); } else { _oMobileOrderReport.SetPy_sent_again_retrieve_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRetrieve_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderReport.Para.retrieve_date])) { _oMobileOrderReport.SetRetrieve_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderReport.Para.retrieve_date]); } else { _oMobileOrderReport.SetRetrieve_date(null); }
                    }
                    _oMobileOrderReportList.Add(_oMobileOrderReport);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderReportList;
            }
            return new List<MobileOrderReportEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderReportEntity> OrderBy(string x_sSort, IQueryable<MobileOrderReportEntity> x_oMobileOrderReportBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderReport.Para.order_status:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.order_status).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.order_status).Select(c => c);
                break;
                case MobileOrderReport.Para.gw_retrieve_sn:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.gw_retrieve_sn).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.gw_retrieve_sn).Select(c => c);
                break;
                case MobileOrderReport.Para.sent_again:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.sent_again).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.sent_again).Select(c => c);
                break;
                case MobileOrderReport.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderReport.Para.email_date:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.email_date).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.email_date).Select(c => c);
                break;
                case MobileOrderReport.Para.retrieve_cnt:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.retrieve_cnt).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.retrieve_cnt).Select(c => c);
                break;
                case MobileOrderReport.Para.fs_sent_again_retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.fs_sent_again_retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.fs_sent_again_retrieve_date).Select(c => c);
                break;
                case MobileOrderReport.Para.cdate:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.cdate).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.cdate).Select(c => c);
                break;
                case MobileOrderReport.Para.retrieve_sn:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.retrieve_sn).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.retrieve_sn).Select(c => c);
                break;
                case MobileOrderReport.Para.cid:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.cid).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.cid).Select(c => c);
                break;
                case MobileOrderReport.Para.did:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.did).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.did).Select(c => c);
                break;
                case MobileOrderReport.Para.sent_again_date:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.sent_again_date).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.sent_again_date).Select(c => c);
                break;
                case MobileOrderReport.Para.idd_vas:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.idd_vas).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.idd_vas).Select(c => c);
                break;
                case MobileOrderReport.Para.active:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.active).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.active).Select(c => c);
                break;
                case MobileOrderReport.Para.fallout_reason:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.fallout_reason).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.fallout_reason).Select(c => c);
                break;
                case MobileOrderReport.Para.fallout_remark:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.fallout_remark).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.fallout_remark).Select(c => c);
                break;
                case MobileOrderReport.Para.fallout_main_category:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.fallout_main_category).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.fallout_main_category).Select(c => c);
                break;
                case MobileOrderReport.Para.report_type:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.report_type).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.report_type).Select(c => c);
                break;
                case MobileOrderReport.Para.fallout_reply:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.fallout_reply).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.fallout_reply).Select(c => c);
                break;
                case MobileOrderReport.Para.reactive_sn:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.reactive_sn).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.reactive_sn).Select(c => c);
                break;
                case MobileOrderReport.Para.ddate:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.ddate).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.ddate).Select(c => c);
                break;
                case MobileOrderReport.Para.ext_place_tel:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.ext_place_tel).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.ext_place_tel).Select(c => c);
                break;
                case MobileOrderReport.Para.reactive_date:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.reactive_date).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.reactive_date).Select(c => c);
                break;
                case MobileOrderReport.Para.gw_retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.gw_retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.gw_retrieve_date).Select(c => c);
                break;
                case MobileOrderReport.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderReport.Para.py_sent_again_retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.py_sent_again_retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.py_sent_again_retrieve_date).Select(c => c);
                break;
                case MobileOrderReport.Para.retrieve_date:
                if(x_bAsc)
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderBy(c => c.retrieve_date).Select(c => c);
                else
                    x_oMobileOrderReportBaseList = x_oMobileOrderReportBaseList.OrderByDescending(c => c.retrieve_date).Select(c => c);
                break;
            }
            return x_oMobileOrderReportBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderReportEntity> FindAll()
        {
            MobileOrderReportEntity[] _oMobileOrderReportsArr=  MobileOrderReportRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderReportsArr != null)
            {
                IList<MobileOrderReportEntity> _oMobileOrderReportsList = (IList<MobileOrderReportEntity>)_oMobileOrderReportsArr;
                return _oMobileOrderReportsList;
            }
            return new List<MobileOrderReportEntity>();
        }
        
        public static IList<MobileOrderReportEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderReportEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderReportEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderReportEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderReportRS x_oShowField = new MobileOrderReportRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderReportRS x_oSortField=new MobileOrderReportRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderReport.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderReport.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderReportRepositoryBase _oMobileOrderReportRepositoryBase = new MobileOrderReportRepositoryBase(GetDB());
            return _oMobileOrderReportRepositoryBase.GetCount();
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


