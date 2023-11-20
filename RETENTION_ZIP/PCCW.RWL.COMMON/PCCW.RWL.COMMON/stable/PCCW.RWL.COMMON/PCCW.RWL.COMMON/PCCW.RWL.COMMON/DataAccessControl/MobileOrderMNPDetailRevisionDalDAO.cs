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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderMNPDetailRevision],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderMNPDetailRevisionDalDAO{
        
        #region RS
        public class MobileOrderMNPDetailRevisionRS
        {
            public bool n_bService_activation_time = false;
            public bool n_bTicker_number = false;
            public bool n_bId_type = false;
            public bool n_bTransfer_idd_roaming_deposit = false;
            public bool n_bCompany_name = false;
            public bool n_bService_activation_date = false;
            public bool n_bMnp_id = false;
            public bool n_bTransfer_others_deposit = false;
            public bool n_bMid = false;
            public bool n_bHkid = false;
            public bool n_bTransfer_to_3g = false;
            public bool n_bTransfer_idd_deposit = false;
            public bool n_bTransfer_no_add_proof_deposit = false;
            public bool n_bOrder_id = false;
            public bool n_bRegistered_name = false;
            public bool n_bTransfer_no_hk_id_holder_deposit = false;
            public string FieldsToReturn(string x_sFieldName,bool x_bSetShowALL)
            {
                 if (x_sFieldName != null) x_sFieldName = x_sFieldName.Trim().ToLower();
                StringBuilder _oFR = new StringBuilder();
                if (this.n_bService_activation_time  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.service_activation_time.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bService_activation_time=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.service_activation_time);
                }
                if (this.n_bTicker_number  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.ticker_number.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTicker_number=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.ticker_number);
                }
                if (this.n_bId_type  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.id_type);
                }
                if (this.n_bTransfer_idd_roaming_deposit  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_idd_roaming_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit);
                }
                if (this.n_bCompany_name  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.company_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCompany_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.company_name);
                }
                if (this.n_bService_activation_date  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.service_activation_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bService_activation_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.service_activation_date);
                }
                if (this.n_bMnp_id  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.mnp_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMnp_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.mnp_id);
                }
                if (this.n_bTransfer_others_deposit  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.transfer_others_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_others_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.transfer_others_deposit);
                }
                if (this.n_bMid  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.mid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.mid);
                }
                if (this.n_bHkid  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.hkid);
                }
                if (this.n_bTransfer_to_3g  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.transfer_to_3g.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_to_3g=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.transfer_to_3g);
                }
                if (this.n_bTransfer_idd_deposit  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.transfer_idd_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_idd_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.transfer_idd_deposit);
                }
                if (this.n_bTransfer_no_add_proof_deposit  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_no_add_proof_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.order_id);
                }
                if (this.n_bRegistered_name  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.registered_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRegistered_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.registered_name);
                }
                if (this.n_bTransfer_no_hk_id_holder_deposit  || x_bSetShowALL || (MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_no_hk_id_holder_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit);
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
        
        public MobileOrderMNPDetailRevisionDalDAO(){
        }
        ~MobileOrderMNPDetailRevisionDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderMNPDetailRevision.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderMNPDetailRevisionEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderMNPDetailRevisionRS x_oFieldsToReturn,MobileOrderMNPDetailRevisionRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderMNPDetailRevisionEntity> _oMobileOrderMNPDetailRevisionList = new List<MobileOrderMNPDetailRevisionEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderMNPDetailRevision _oMobileOrderMNPDetailRevision = new MobileOrderMNPDetailRevision();
                    if ((true).Equals(x_oFieldsToReturn.n_bService_activation_time))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.service_activation_time])) { _oMobileOrderMNPDetailRevision.SetService_activation_time((string)_oDATA[MobileOrderMNPDetailRevision.Para.service_activation_time]); } else { _oMobileOrderMNPDetailRevision.SetService_activation_time(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTicker_number))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.ticker_number])) { _oMobileOrderMNPDetailRevision.SetTicker_number((string)_oDATA[MobileOrderMNPDetailRevision.Para.ticker_number]); } else { _oMobileOrderMNPDetailRevision.SetTicker_number(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.id_type])) { _oMobileOrderMNPDetailRevision.SetId_type((string)_oDATA[MobileOrderMNPDetailRevision.Para.id_type]); } else { _oMobileOrderMNPDetailRevision.SetId_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_idd_roaming_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit])) { _oMobileOrderMNPDetailRevision.SetTransfer_idd_roaming_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit]); } else { _oMobileOrderMNPDetailRevision.SetTransfer_idd_roaming_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCompany_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.company_name])) { _oMobileOrderMNPDetailRevision.SetCompany_name((string)_oDATA[MobileOrderMNPDetailRevision.Para.company_name]); } else { _oMobileOrderMNPDetailRevision.SetCompany_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bService_activation_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.service_activation_date])) { _oMobileOrderMNPDetailRevision.SetService_activation_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderMNPDetailRevision.Para.service_activation_date]); } else { _oMobileOrderMNPDetailRevision.SetService_activation_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMnp_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.mnp_id])) { _oMobileOrderMNPDetailRevision.SetMnp_id((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetailRevision.Para.mnp_id]); } else { _oMobileOrderMNPDetailRevision.SetMnp_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_others_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.transfer_others_deposit])) { _oMobileOrderMNPDetailRevision.SetTransfer_others_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetailRevision.Para.transfer_others_deposit]); } else { _oMobileOrderMNPDetailRevision.SetTransfer_others_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.mid])) { _oMobileOrderMNPDetailRevision.SetMid((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetailRevision.Para.mid]); } else { _oMobileOrderMNPDetailRevision.SetMid(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.hkid])) { _oMobileOrderMNPDetailRevision.SetHkid((string)_oDATA[MobileOrderMNPDetailRevision.Para.hkid]); } else { _oMobileOrderMNPDetailRevision.SetHkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_to_3g))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.transfer_to_3g])) { _oMobileOrderMNPDetailRevision.SetTransfer_to_3g((global::System.Nullable<bool>)_oDATA[MobileOrderMNPDetailRevision.Para.transfer_to_3g]); } else { _oMobileOrderMNPDetailRevision.SetTransfer_to_3g(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_idd_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.transfer_idd_deposit])) { _oMobileOrderMNPDetailRevision.SetTransfer_idd_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetailRevision.Para.transfer_idd_deposit]); } else { _oMobileOrderMNPDetailRevision.SetTransfer_idd_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_no_add_proof_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit])) { _oMobileOrderMNPDetailRevision.SetTransfer_no_add_proof_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit]); } else { _oMobileOrderMNPDetailRevision.SetTransfer_no_add_proof_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.order_id])) { _oMobileOrderMNPDetailRevision.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderMNPDetailRevision.Para.order_id]); } else { _oMobileOrderMNPDetailRevision.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRegistered_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.registered_name])) { _oMobileOrderMNPDetailRevision.SetRegistered_name((string)_oDATA[MobileOrderMNPDetailRevision.Para.registered_name]); } else { _oMobileOrderMNPDetailRevision.SetRegistered_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_no_hk_id_holder_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit])) { _oMobileOrderMNPDetailRevision.SetTransfer_no_hk_id_holder_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit]); } else { _oMobileOrderMNPDetailRevision.SetTransfer_no_hk_id_holder_deposit(null); }
                    }
                    _oMobileOrderMNPDetailRevisionList.Add(_oMobileOrderMNPDetailRevision);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderMNPDetailRevisionList;
            }
            return new List<MobileOrderMNPDetailRevisionEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderMNPDetailRevisionEntity> OrderBy(string x_sSort, IQueryable<MobileOrderMNPDetailRevisionEntity> x_oMobileOrderMNPDetailRevisionBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderMNPDetailRevision.Para.service_activation_time:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.service_activation_time).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.service_activation_time).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.ticker_number:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.ticker_number).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.ticker_number).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.id_type:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.id_type).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.id_type).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.transfer_idd_roaming_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.transfer_idd_roaming_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.transfer_idd_roaming_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.company_name:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.company_name).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.company_name).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.service_activation_date:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.service_activation_date).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.service_activation_date).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.mnp_id:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.mnp_id).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.mnp_id).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.transfer_others_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.transfer_others_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.transfer_others_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.mid:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.mid).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.mid).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.hkid:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.hkid).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.hkid).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.transfer_to_3g:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.transfer_to_3g).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.transfer_to_3g).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.transfer_idd_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.transfer_idd_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.transfer_idd_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.transfer_no_add_proof_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.transfer_no_add_proof_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.transfer_no_add_proof_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.registered_name:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.registered_name).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.registered_name).Select(c => c);
                break;
                case MobileOrderMNPDetailRevision.Para.transfer_no_hk_id_holder_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderBy(c => c.transfer_no_hk_id_holder_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailRevisionBaseList = x_oMobileOrderMNPDetailRevisionBaseList.OrderByDescending(c => c.transfer_no_hk_id_holder_deposit).Select(c => c);
                break;
            }
            return x_oMobileOrderMNPDetailRevisionBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderMNPDetailRevisionEntity> FindAll()
        {
            MobileOrderMNPDetailRevisionEntity[] _oMobileOrderMNPDetailRevisionsArr=  MobileOrderMNPDetailRevisionRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderMNPDetailRevisionsArr != null)
            {
                IList<MobileOrderMNPDetailRevisionEntity> _oMobileOrderMNPDetailRevisionsList = (IList<MobileOrderMNPDetailRevisionEntity>)_oMobileOrderMNPDetailRevisionsArr;
                return _oMobileOrderMNPDetailRevisionsList;
            }
            return new List<MobileOrderMNPDetailRevisionEntity>();
        }
        
        public static IList<MobileOrderMNPDetailRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderMNPDetailRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderMNPDetailRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderMNPDetailRevisionEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderMNPDetailRevisionRS x_oShowField = new MobileOrderMNPDetailRevisionRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderMNPDetailRevisionRS x_oSortField=new MobileOrderMNPDetailRevisionRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderMNPDetailRevision.Para.mid.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderMNPDetailRevision.Para.mid, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderMNPDetailRevisionRepositoryBase _oMobileOrderMNPDetailRevisionRepositoryBase = new MobileOrderMNPDetailRevisionRepositoryBase(GetDB());
            return _oMobileOrderMNPDetailRevisionRepositoryBase.GetCount();
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


