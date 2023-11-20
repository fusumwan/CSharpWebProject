using System;
using System.Web;
using PCCW.RWL.CORE.WEBFUNC;

namespace PCCW.RWL.WEB.UI.UserControlRequest
{
    public class MobileOrderThreePartyUserControlRequest
    {
        public string UserControlRequestIDName = string.Empty;

        #region [id]   qsIdName & qsId
        public const string qsIdName = "id";
        public global::System.Nullable<long> qsId
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsIdName]))
                {
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsIdName].ToString());
                }
                else
                {
                    long _lId;
                    string _sId = WebFunc.RequestQuery(this.UserControlRequestIDName + qsIdName).Trim();
                    if (long.TryParse(_sId, out _lId))
                        return _lId;
                }
                return null;
            }
        }
        #endregion
        #region [arthurization_person]   qsArthurization_personName & qsArthurization_person
        public const string qsArthurization_personName = "arthurization_person";
        public string qsArthurization_person
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsArthurization_personName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsArthurization_personName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsArthurization_personName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [contact_no]   qsContact_noName & qsContact_no
        public const string qsContact_noName = "contact_no";
        public string qsContact_no
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsContact_noName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsContact_noName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsContact_noName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [type]   qsTypeName & qsType
        public const string qsTypeName = "type";
        public string qsType
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsTypeName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsTypeName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsTypeName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [plural]   qsPluralName & qsPlural
        public const string qsPluralName = "plural";
        public string qsPlural
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsPluralName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsPluralName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsPluralName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion

        #region [id_type]   qsId_typeName & qsId_type
        public const string qsId_typeName = "id_type";
        public string qsId_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsId_typeName]))
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
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsHkidName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName+qsHkidName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName+qsHkidName).ToString();
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
        #region [order_id]   qsOrder_idName & qsOrder_id
        public const string qsOrder_idName = "order_id";
        public global::System.Nullable<int> qsOrder_id
        {
            get
            {
                if (Func.IsParseInt(HttpContext.Current.Request[this.UserControlRequestIDName + qsOrder_idName]))
                    return int.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsOrder_idName].ToString());
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
        #region [three_party]   qsThree_partyName & qsThree_party
        public const string qsThree_partyName = "three_party";
        public global::System.Nullable<bool> qsThree_party
        {
            get
            {
                string _sThree_party = string.Empty;
                if (HttpContext.Current.Request[this.UserControlRequestIDName + qsThree_partyName] != null)
                    _sThree_party = HttpContext.Current.Request[this.UserControlRequestIDName + qsThree_partyName].ToString();
                else
                    _sThree_party = WebFunc.RequestQuery(this.UserControlRequestIDName + qsThree_partyName).Trim();

                if (_sThree_party == "on")
                    return true;

                if (Func.IsParseBool(_sThree_party))
                {
                    return bool.Parse(_sThree_party);
                }
                return null;
            }
        }
        #endregion
    }
}
