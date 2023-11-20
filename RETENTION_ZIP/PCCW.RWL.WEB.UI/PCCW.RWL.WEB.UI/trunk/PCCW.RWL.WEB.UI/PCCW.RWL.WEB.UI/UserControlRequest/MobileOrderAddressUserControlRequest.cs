using System;
using System.Web;
using PCCW.RWL.CORE.WEBFUNC;

namespace PCCW.RWL.WEB.UI.UserControlRequest
{
    public class MobileOrderAddressUserControlRequest
    {
        public string UserControlRequestIDName = string.Empty;

        #region [d_street]   qsD_streetName & qsD_street
        public const string qsD_streetName = "d_street";
        public string qsD_street
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsD_streetName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsD_streetName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_streetName).Trim();

                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [d_region]   qsD_regionName & qsD_region
        public const string qsD_regionName = "d_region";
        public string qsD_region
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsD_regionName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName+qsD_regionName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_regionName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [d_floor]   qsD_floorName & qsD_floor
        public const string qsD_floorName = "d_floor";
        public string qsD_floor
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsD_floorName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName+qsD_floorName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_floorName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [d_build]   qsD_buildName & qsD_build
        public const string qsD_buildName = "d_build";
        public string qsD_build
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsD_buildName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName+qsD_buildName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_buildName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion

        #region [d_district]   qsD_districtName & qsD_district
        public const string qsD_districtName = "d_district";
        public string qsD_district
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsD_districtName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsD_districtName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_districtName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion

        #region [d_room]   qsD_roomName & qsD_room
        public const string qsD_roomName = "d_room";
        public string qsD_room
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsD_roomName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName+qsD_roomName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_roomName).Trim();
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
        #region [address_type]   qsAddress_typeName & qsAddress_type
        public const string qsAddress_typeName = "address_type";
        public string qsAddress_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsAddress_typeName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName+qsAddress_typeName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsAddress_typeName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [d_type]   qsD_typeName & qsD_type
        public const string qsD_typeName = "d_type";
        public string qsD_type
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName+qsD_typeName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName+qsD_typeName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_typeName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
        #region [address_id]   qsAddress_idName & qsAddress_id
        public const string qsAddress_idName = "address_id";
        public global::System.Nullable<long> qsAddress_id
        {
            get
            {
                if (Func.IsParseLong(HttpContext.Current.Request[this.UserControlRequestIDName + qsAddress_idName]))
                    return long.Parse(HttpContext.Current.Request[this.UserControlRequestIDName + qsAddress_idName].ToString());
                else
                {
                    long _lAddress_id;
                    string _sAddress_id = WebFunc.RequestQuery(this.UserControlRequestIDName + qsAddress_idName).Trim();
                    if (long.TryParse(_sAddress_id, out _lAddress_id))
                        return _lAddress_id;
                }
                return null;
            }
        }
        #endregion
        #region [d_blk]   qsD_blkName & qsD_blk
        public const string qsD_blkName = "d_blk";
        public string qsD_blk
        {
            get
            {
                if (Func.IsParseString(HttpContext.Current.Request[this.UserControlRequestIDName + qsD_blkName]))
                    return HttpContext.Current.Request[this.UserControlRequestIDName + qsD_blkName].ToString();
                else
                    return WebFunc.RequestQuery(this.UserControlRequestIDName + qsD_blkName).Trim();
                //return global::System.String.Empty;
            }
        }
        #endregion
    }
}
