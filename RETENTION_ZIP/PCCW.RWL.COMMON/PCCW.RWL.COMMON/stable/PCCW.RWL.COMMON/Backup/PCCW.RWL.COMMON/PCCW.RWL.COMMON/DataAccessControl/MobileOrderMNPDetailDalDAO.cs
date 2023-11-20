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
///-- Create date: <Create Date 2011-03-08>
///-- Description:	<Description,Table :[MobileOrderMNPDetail],DataAccess layer>
///-- =============================================

namespace PCCW.RWL.CORE{
    
    public abstract class MobileOrderMNPDetailDalDAO{
        
        #region RS
        public class MobileOrderMNPDetailRS
        {
            public bool n_bService_activation_time = false;
            public bool n_bTicker_number = false;
            public bool n_bId_type = false;
            public bool n_bTransfer_idd_roaming_deposit = false;
            public bool n_bCompany_name = false;
            public bool n_bService_activation_date = false;
            public bool n_bMnp_id = false;
            public bool n_bTransfer_others_deposit = false;
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
                if (this.n_bService_activation_time  || x_bSetShowALL || (MobileOrderMNPDetail.Para.service_activation_time.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bService_activation_time=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.service_activation_time);
                }
                if (this.n_bTicker_number  || x_bSetShowALL || (MobileOrderMNPDetail.Para.ticker_number.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTicker_number=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.ticker_number);
                }
                if (this.n_bId_type  || x_bSetShowALL || (MobileOrderMNPDetail.Para.id_type.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bId_type=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.id_type);
                }
                if (this.n_bTransfer_idd_roaming_deposit  || x_bSetShowALL || (MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_idd_roaming_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit);
                }
                if (this.n_bCompany_name  || x_bSetShowALL || (MobileOrderMNPDetail.Para.company_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bCompany_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.company_name);
                }
                if (this.n_bService_activation_date  || x_bSetShowALL || (MobileOrderMNPDetail.Para.service_activation_date.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bService_activation_date=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.service_activation_date);
                }
                if (this.n_bMnp_id  || x_bSetShowALL || (MobileOrderMNPDetail.Para.mnp_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bMnp_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.mnp_id);
                }
                if (this.n_bTransfer_others_deposit  || x_bSetShowALL || (MobileOrderMNPDetail.Para.transfer_others_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_others_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.transfer_others_deposit);
                }
                if (this.n_bHkid  || x_bSetShowALL || (MobileOrderMNPDetail.Para.hkid.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bHkid=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.hkid);
                }
                if (this.n_bTransfer_to_3g  || x_bSetShowALL || (MobileOrderMNPDetail.Para.transfer_to_3g.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_to_3g=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.transfer_to_3g);
                }
                if (this.n_bTransfer_idd_deposit  || x_bSetShowALL || (MobileOrderMNPDetail.Para.transfer_idd_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_idd_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.transfer_idd_deposit);
                }
                if (this.n_bTransfer_no_add_proof_deposit  || x_bSetShowALL || (MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_no_add_proof_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit);
                }
                if (this.n_bOrder_id  || x_bSetShowALL || (MobileOrderMNPDetail.Para.order_id.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bOrder_id=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.order_id);
                }
                if (this.n_bRegistered_name  || x_bSetShowALL || (MobileOrderMNPDetail.Para.registered_name.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bRegistered_name=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.registered_name);
                }
                if (this.n_bTransfer_no_hk_id_holder_deposit  || x_bSetShowALL || (MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit.ToLower().Equals(x_sFieldName)))
                {
                    this.n_bTransfer_no_hk_id_holder_deposit=true;
                    if (!"".Equals(_oFR.ToString())) { _oFR.Append(","); }
                    _oFR.Append(MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit);
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
        
        public MobileOrderMNPDetailDalDAO(){
        }
        ~MobileOrderMNPDetailDalDAO(){
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
            _oSearchUtils.SetTable(MobileOrderMNPDetail.Para.TableName());
            string _sQuery = _oSearchUtils.GetSearchSQL();
            if (!"".Equals(_sQuery))
            {
                return GetDB().GetSearch(_sQuery);
            }
            return null;
        }
        public static List<MobileOrderMNPDetailEntity> SearchList(List<SearchItem> x_oSearchItems,string x_sRowFilter,long x_lStart,long x_lLimit, MobileOrderMNPDetailRS x_oFieldsToReturn,MobileOrderMNPDetailRS x_oSortByField,bool x_bAscDirection)
        {
            global::System.Data.SqlClient.SqlDataReader _oDATA = DrSearch(x_oSearchItems,x_sRowFilter, x_lStart, x_lLimit, x_oFieldsToReturn.FieldsToReturn(), x_oSortByField.FieldsToReturn(), x_bAscDirection);
            
            if (_oDATA != null)
            {
                List<MobileOrderMNPDetailEntity> _oMobileOrderMNPDetailList = new List<MobileOrderMNPDetailEntity>();
                
                while (_oDATA.Read())
                {
                    MobileOrderMNPDetail _oMobileOrderMNPDetail = new MobileOrderMNPDetail();
                    if ((true).Equals(x_oFieldsToReturn.n_bService_activation_time))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.service_activation_time])) { _oMobileOrderMNPDetail.SetService_activation_time((string)_oDATA[MobileOrderMNPDetail.Para.service_activation_time]); } else { _oMobileOrderMNPDetail.SetService_activation_time(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTicker_number))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.ticker_number])) { _oMobileOrderMNPDetail.SetTicker_number((string)_oDATA[MobileOrderMNPDetail.Para.ticker_number]); } else { _oMobileOrderMNPDetail.SetTicker_number(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bId_type))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.id_type])) { _oMobileOrderMNPDetail.SetId_type((string)_oDATA[MobileOrderMNPDetail.Para.id_type]); } else { _oMobileOrderMNPDetail.SetId_type(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_idd_roaming_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit])) { _oMobileOrderMNPDetail.SetTransfer_idd_roaming_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit]); } else { _oMobileOrderMNPDetail.SetTransfer_idd_roaming_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bCompany_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.company_name])) { _oMobileOrderMNPDetail.SetCompany_name((string)_oDATA[MobileOrderMNPDetail.Para.company_name]); } else { _oMobileOrderMNPDetail.SetCompany_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bService_activation_date))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.service_activation_date])) { _oMobileOrderMNPDetail.SetService_activation_date((global::System.Nullable<DateTime>)_oDATA[MobileOrderMNPDetail.Para.service_activation_date]); } else { _oMobileOrderMNPDetail.SetService_activation_date(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bMnp_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.mnp_id])) { _oMobileOrderMNPDetail.SetMnp_id((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetail.Para.mnp_id]); } else { _oMobileOrderMNPDetail.SetMnp_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_others_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.transfer_others_deposit])) { _oMobileOrderMNPDetail.SetTransfer_others_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetail.Para.transfer_others_deposit]); } else { _oMobileOrderMNPDetail.SetTransfer_others_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bHkid))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.hkid])) { _oMobileOrderMNPDetail.SetHkid((string)_oDATA[MobileOrderMNPDetail.Para.hkid]); } else { _oMobileOrderMNPDetail.SetHkid(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_to_3g))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.transfer_to_3g])) { _oMobileOrderMNPDetail.SetTransfer_to_3g((global::System.Nullable<bool>)_oDATA[MobileOrderMNPDetail.Para.transfer_to_3g]); } else { _oMobileOrderMNPDetail.SetTransfer_to_3g(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_idd_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.transfer_idd_deposit])) { _oMobileOrderMNPDetail.SetTransfer_idd_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetail.Para.transfer_idd_deposit]); } else { _oMobileOrderMNPDetail.SetTransfer_idd_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_no_add_proof_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit])) { _oMobileOrderMNPDetail.SetTransfer_no_add_proof_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit]); } else { _oMobileOrderMNPDetail.SetTransfer_no_add_proof_deposit(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bOrder_id))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.order_id])) { _oMobileOrderMNPDetail.SetOrder_id((global::System.Nullable<int>)_oDATA[MobileOrderMNPDetail.Para.order_id]); } else { _oMobileOrderMNPDetail.SetOrder_id(null); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bRegistered_name))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.registered_name])) { _oMobileOrderMNPDetail.SetRegistered_name((string)_oDATA[MobileOrderMNPDetail.Para.registered_name]); } else { _oMobileOrderMNPDetail.SetRegistered_name(global::System.String.Empty); }
                    }
                    if ((true).Equals(x_oFieldsToReturn.n_bTransfer_no_hk_id_holder_deposit))
                    {
                        if (!global::System.Convert.IsDBNull(_oDATA[MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit])) { _oMobileOrderMNPDetail.SetTransfer_no_hk_id_holder_deposit((global::System.Nullable<long>)_oDATA[MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit]); } else { _oMobileOrderMNPDetail.SetTransfer_no_hk_id_holder_deposit(null); }
                    }
                    _oMobileOrderMNPDetailList.Add(_oMobileOrderMNPDetail);
                }
                _oDATA.Close();
                _oDATA.Dispose();
                return _oMobileOrderMNPDetailList;
            }
            return new List<MobileOrderMNPDetailEntity>();
        }
        #endregion
        
        #region Linq OrderBy
        public static IQueryable<MobileOrderMNPDetailEntity> OrderBy(string x_sSort, IQueryable<MobileOrderMNPDetailEntity> x_oMobileOrderMNPDetailBaseList, bool x_bAsc)
        {
            switch(x_sSort){
                case MobileOrderMNPDetail.Para.service_activation_time:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.service_activation_time).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.service_activation_time).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.ticker_number:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.ticker_number).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.ticker_number).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.id_type:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.id_type).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.id_type).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.transfer_idd_roaming_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.transfer_idd_roaming_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.transfer_idd_roaming_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.company_name:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.company_name).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.company_name).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.service_activation_date:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.service_activation_date).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.service_activation_date).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.mnp_id:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.mnp_id).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.mnp_id).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.transfer_others_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.transfer_others_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.transfer_others_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.hkid:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.hkid).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.hkid).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.transfer_to_3g:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.transfer_to_3g).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.transfer_to_3g).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.transfer_idd_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.transfer_idd_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.transfer_idd_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.transfer_no_add_proof_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.transfer_no_add_proof_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.transfer_no_add_proof_deposit).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.order_id:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.order_id).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.order_id).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.registered_name:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.registered_name).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.registered_name).Select(c => c);
                break;
                case MobileOrderMNPDetail.Para.transfer_no_hk_id_holder_deposit:
                if(x_bAsc)
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderBy(c => c.transfer_no_hk_id_holder_deposit).Select(c => c);
                else
                    x_oMobileOrderMNPDetailBaseList = x_oMobileOrderMNPDetailBaseList.OrderByDescending(c => c.transfer_no_hk_id_holder_deposit).Select(c => c);
                break;
            }
            return x_oMobileOrderMNPDetailBaseList;
        }
        #endregion
        
        
        #region FindAll
        public static IList<MobileOrderMNPDetailEntity> FindAll()
        {
            MobileOrderMNPDetailEntity[] _oMobileOrderMNPDetailsArr=  MobileOrderMNPDetailRepositoryBase.GetArrayObj(GetDB(), null, null, null);
            if (_oMobileOrderMNPDetailsArr != null)
            {
                IList<MobileOrderMNPDetailEntity> _oMobileOrderMNPDetailsList = (IList<MobileOrderMNPDetailEntity>)_oMobileOrderMNPDetailsArr;
                return _oMobileOrderMNPDetailsList;
            }
            return new List<MobileOrderMNPDetailEntity>();
        }
        
        public static IList<MobileOrderMNPDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(),string.Empty);
        }
        
        public static IList<MobileOrderMNPDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,string x_sRowFilter)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, new List<SearchItem>(), x_sRowFilter);
        }
        
        public static IList<MobileOrderMNPDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression, List<SearchItem> x_oSearchItem)
        {
            return FindAll(x_iStartRow, x_iPageSize, x_sSortExpression, x_oSearchItem, string.Empty);
        }
        
        public static IList<MobileOrderMNPDetailEntity> FindAll(int x_iStartRow, int x_iPageSize, string x_sSortExpression,List<SearchItem> x_oSearchItem,string x_sRowFilter)
        {
            MobileOrderMNPDetailRS x_oShowField = new MobileOrderMNPDetailRS();
            x_oShowField.FieldsToReturn(string.Empty, true);
            MobileOrderMNPDetailRS x_oSortField=new MobileOrderMNPDetailRS();
            if (!string.IsNullOrEmpty(x_sSortExpression)) x_sSortExpression = x_sSortExpression.Trim();
            if (!x_sSortExpression.ToLower().Equals(MobileOrderMNPDetail.Para.mnp_id.ToLower()) && !string.IsNullOrEmpty(x_sSortExpression)){
                x_oSortField.FieldsToReturn(x_sSortExpression,false);
            }
            x_oSortField.FieldsToReturn(MobileOrderMNPDetail.Para.mnp_id, false);
            return SearchList(x_oSearchItem,x_sRowFilter, Convert.ToInt64(x_iStartRow), Convert.ToInt64(x_iPageSize),x_oShowField, x_oSortField, true);
        }
        #endregion
        
        
        #region CountAll
        public static int CountAll()
        {
            MobileOrderMNPDetailRepositoryBase _oMobileOrderMNPDetailRepositoryBase = new MobileOrderMNPDetailRepositoryBase(GetDB());
            return _oMobileOrderMNPDetailRepositoryBase.GetCount();
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


