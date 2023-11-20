using System;
using System.Web;
using PCCW.RWL.CORE.WEBFUNC;

namespace PCCW.RWL.WEB.UI.UserControlRequest
{
    public class MobileOrderMNPDetailUserControlRequest
    {
        public string UserControlRequestIDName = string.Empty;

        #region [service_activation_time]   qsService_activation_timeName & qsService_activation_time
        public const string qsService_activation_timeName = "service_activation_time";
        public string qsService_activation_time
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsService_activation_timeName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsService_activation_timeName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsService_activation_timeName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [ticker_number]   qsTicker_numberName & qsTicker_number
        public const string qsTicker_numberName = "ticker_number";
        public string qsTicker_number
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsTicker_numberName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsTicker_numberName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsTicker_numberName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [transfer_idd_deposit]   qsTransfer_idd_depositName & qsTransfer_idd_deposit
        public const string qsTransfer_idd_depositName = "transfer_idd_deposit";
        public global::System.Nullable<long> qsTransfer_idd_deposit
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_idd_depositName]))
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_idd_depositName].ToString());
                else
                {
                    long _lTradnsfer_idd_deposit;
                    string _sTradnsfer_idd_deposit = WebFunc.RequestQuery(this.UserControlRequestIDName + qsTransfer_idd_depositName).Trim();
                    if (long.TryParse(_sTradnsfer_idd_deposit, out _lTradnsfer_idd_deposit))
                        return _lTradnsfer_idd_deposit;
                }
                return null;
            }
        }
        #endregion
        #region [transfer_idd_roaming_deposit]   qsTransfer_idd_roaming_depositName & qsTransfer_idd_roaming_deposit
        public const string qsTransfer_idd_roaming_depositName = "transfer_idd_roaming_deposit";
        public global::System.Nullable<long> qsTransfer_idd_roaming_deposit
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_idd_roaming_depositName]))
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_idd_roaming_depositName].ToString());
                else
                {
                    long _lTransfer_idd_roaming_deposit;
                    string _sTransfer_idd_roaming_deposit = WebFunc.RequestQuery(this.UserControlRequestIDName + qsTransfer_idd_roaming_depositName).Trim();
                    if (long.TryParse(_sTransfer_idd_roaming_deposit, out _lTransfer_idd_roaming_deposit))
                        return _lTransfer_idd_roaming_deposit;
                }
                return null;
            }
        }
        #endregion
        #region [company_name]   qsCompany_nameName & qsCompany_name
        public const string qsCompany_nameName = "company_name";
        public string qsCompany_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsCompany_nameName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsCompany_nameName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsCompany_nameName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [service_activation_date]   qsService_activation_dateName & qsService_activation_date
        public const string qsService_activation_dateName = "service_activation_date";
        public global::System.Nullable<DateTime> qsService_activation_date
        {
            get
            {
                string _sService_activation_date = string.Empty;
                if(HttpContext.Current.Request[this.UserControlRequestIDName + qsService_activation_dateName]!=null)
                    _sService_activation_date = HttpContext.Current.Request[this.UserControlRequestIDName + qsService_activation_dateName].ToString().Trim();
                else
                    _sService_activation_date = WebFunc.RequestQuery(this.UserControlRequestIDName + qsService_activation_dateName).Trim();

                if (Func.IsParseDateTime(_sService_activation_date))
                {
                    if (!WebFunc.n_bUseDatetimePattern)
                        return DateTime.Parse(_sService_activation_date);
                    else
                        return Func.ConvertDatetime(_sService_activation_date);
                }
                return null;
            }
        }
        #endregion


        #region [mnp_id]   qsMnp_idName & qsMnp_id
        public const string qsMnp_idName = "mnp_id";
        public global::System.Nullable<long> qsMnp_id
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsMnp_idName]))
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsMnp_idName].ToString());
                else
                {
                    long _lMnp_id;
                    string _sMnp_id = WebFunc.RequestQuery(this.UserControlRequestIDName + qsMnp_idName).Trim();
                    if (long.TryParse(_sMnp_id, out _lMnp_id))
                        return _lMnp_id;
                }
                return null;
            }
        }
        #endregion
        #region [transfer_others_deposit]   qsTransfer_others_depositName & qsTransfer_others_deposit
        public const string qsTransfer_others_depositName = "transfer_others_deposit";
        public global::System.Nullable<long> qsTransfer_others_deposit
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_others_depositName]))
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_others_depositName].ToString());
                else
                {
                    long _lTransfer_others_deposit;
                    string _sTransfer_others_deposit = WebFunc.RequestQuery(this.UserControlRequestIDName + qsTransfer_others_depositName).Trim();
                    if (long.TryParse(_sTransfer_others_deposit, out _lTransfer_others_deposit))
                        return _lTransfer_others_deposit;
                }
                return null;
            }
        }
        #endregion
        #region [id_type]   qsId_typeName & qsId_type
        public const string qsId_typeName = "id_type";
        public string qsId_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsId_typeName]))
                    return HttpContext.Current.Request[qsId_typeName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsId_typeName).Trim();
                //return string.Empty;
            }
        }
        #endregion
        #region [hkid]   qsHkidName & qsHkid
        public const string qsHkidName = "hkid";
        public string qsHkid
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsHkidName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsHkidName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsHkidName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [hkid2]   qsHkid2Name & qsHkid2
        public const string qsHkid2Name = "hkid2";
        public string qsHkid2
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsHkid2Name]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsHkid2Name].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsHkid2Name).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [transfer_to_3g]   qsTransfer_to_3gName & qsTransfer_to_3g
        public const string qsTransfer_to_3gName = "transfer_to_3g";
        public global::System.Nullable<bool> qsTransfer_to_3g
        {
            get
            {
                string _sTransfer_to_3g = string.Empty;
                if (HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_to_3gName] != null)
                    _sTransfer_to_3g = HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_to_3gName].ToString().Trim();
                else
                    _sTransfer_to_3g = WebFunc.RequestQuery(this.UserControlRequestIDName + qsTransfer_to_3gName).Trim();

                if (_sTransfer_to_3g == "on")
                    return true;

                if (Func.IsParseBool(_sTransfer_to_3g))
                {
                    return bool.Parse(_sTransfer_to_3g);
                }
                return null;
            }
        }
        #endregion
        #region [order_id]   qsOrder_idName & qsOrder_id
        public const string qsOrder_idName = "order_id";
        public global::System.Nullable<int> qsOrder_id
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[this.UserControlRequestIDName + qsOrder_idName]))
                {
                    return int.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsOrder_idName].ToString());
                }
                else
                {
                    int _iOrder_id;
                    string _sOrder_id = WebFunc.RequestQuery(this.UserControlRequestIDName + qsOrder_idName).Trim();
                    if (int.TryParse(_sOrder_id, out _iOrder_id))
                        return _iOrder_id;
                }
                return null;
            }
        }
        #endregion
        #region [transfer_no_add_proof_deposit]   qsTransfer_no_add_proof_depositName & qsTransfer_no_add_proof_deposit
        public const string qsTransfer_no_add_proof_depositName = "transfer_no_add_proof_deposit";
        public global::System.Nullable<long> qsTransfer_no_add_proof_deposit
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_no_add_proof_depositName]))
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_no_add_proof_depositName].ToString());
                else
                {
                    long _lTransfer_no_add_proof_deposit;
                    string _sTransfer_no_add_proof_deposit = WebFunc.RequestQuery(this.UserControlRequestIDName + qsTransfer_no_add_proof_depositName).Trim();
                    if (long.TryParse(_sTransfer_no_add_proof_deposit, out _lTransfer_no_add_proof_deposit))
                        return _lTransfer_no_add_proof_deposit;
                }
                return null;
            }
        }
        #endregion
        #region [registered_name]   qsRegistered_nameName & qsRegistered_name
        public const string qsRegistered_nameName = "registered_name";
        public string qsRegistered_name
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsRegistered_nameName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsRegistered_nameName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsRegistered_nameName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [transfer_no_hk_id_holder_deposit]   qsTransfer_no_hk_id_holder_depositName & qsTransfer_no_hk_id_holder_deposit
        public const string qsTransfer_no_hk_id_holder_depositName = "transfer_no_hk_id_holder_deposit";
        public global::System.Nullable<long> qsTransfer_no_hk_id_holder_deposit
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_no_hk_id_holder_depositName]))
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsTransfer_no_hk_id_holder_depositName].ToString());
                else
                {
                    long _lTransfer_no_hk_id_holder_deposit;
                    string _slTransfer_no_hk_id_holder_deposit = WebFunc.RequestQuery(this.UserControlRequestIDName + qsTransfer_no_hk_id_holder_depositName).Trim();
                    if (long.TryParse(_slTransfer_no_hk_id_holder_deposit, out _lTransfer_no_hk_id_holder_deposit))
                        return _lTransfer_no_hk_id_holder_deposit;
                }
                return null;
            }
        }
        #endregion
    }
}
