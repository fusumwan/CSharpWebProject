using System;
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace NEURON.ENTITY.FRAMEWORK
{
    public enum DsExpressionStatus
    {
        UnKnown = 0,
        Eq,
        EqProperty,
        Le,
        LeProperty,
        Lt,
        LtProperty,
        Ge,
        GeProperty,
        Gt,
        GtProperty,
        IsNull,
        IsNotNull,
        IsEmpty,
        IsNotEmpty,
        Like,
        NotLike,
    }

    public class DsExpression
    {
        #region Parameters
        public string Expression = string.Empty;
        public string FieldName = string.Empty;
        public string OtherFieldName = string.Empty;
        public object Value = null;
        public bool IsNullVal = false;
        public bool IsString = true;
        public DsExpressionStatus Status = DsExpressionStatus.UnKnown;
        #endregion

        #region Constructor
        public DsExpression() { }

        public DsExpression(string x_sExpression, string x_sPropertyName, object x_oValue, bool x_bIsString, bool x_bIsNullVal, DsExpressionStatus x_oStatus)
        {
            Expression = x_sExpression;
            FieldName = x_sPropertyName;
            OtherFieldName = string.Empty;
            Value = x_oValue;
            IsString = x_bIsString;
            IsNullVal = x_bIsNullVal;
            Status = x_oStatus;
        }

        public DsExpression(string x_sExpression, string x_sPropertyName, string x_sOtherPropertyName, DsExpressionStatus x_oStatus)
        {
            Expression = x_sExpression;
            FieldName = x_sPropertyName;
            OtherFieldName = x_sOtherPropertyName;
            Value = null;
            IsString = true;
            IsNullVal = false;
            Status = x_oStatus;
        }
        #endregion

        public static DsExpression Eq(string x_sPropertyName, string x_sValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) new DsExpression();
            if (x_sValue == null) return new DsExpression(x_sPropertyName + " IS NULL ", x_sPropertyName, x_sValue, true, true, DsExpressionStatus.IsNull);
            return new DsExpression(x_sPropertyName + "='" + x_sValue.Replace("'", "''") + "'", x_sPropertyName, x_sValue, true, false, DsExpressionStatus.Eq);
        }

        public static DsExpression Eq(string x_sPropertyName, int? x_iValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) new DsExpression();
            if (x_iValue == null) return new DsExpression(x_sPropertyName + " IS NULL ", x_sPropertyName, x_iValue, false, true, DsExpressionStatus.IsNull);
            return new DsExpression(x_sPropertyName + "=" + ((int)x_iValue).ToString(), x_sPropertyName, x_iValue, false, false, DsExpressionStatus.Eq);
        }

        public static DsExpression EqProperty(string x_sPropertyName, string x_sOtherPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName) || string.IsNullOrEmpty(x_sOtherPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + "=" + x_sOtherPropertyName, x_sPropertyName, x_sOtherPropertyName, DsExpressionStatus.EqProperty);
        }

        public static DsExpression Le(string x_sPropertyName, object x_oValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            if (x_oValue == null) return new DsExpression(x_sPropertyName + " IS NULL ", x_sPropertyName, x_oValue, false, true, DsExpressionStatus.IsNull);
            string _sValue = (x_oValue is string) ? ("'" + x_oValue.ToString().Replace("'", "''") + "'") : x_oValue.ToString();
            return new DsExpression(x_sPropertyName + "<=" + _sValue.ToString(), x_sPropertyName, x_oValue, (x_oValue is string) ? true : false, false, DsExpressionStatus.Le);
        }

        public static DsExpression LeProperty(string x_sPropertyName, string x_sOtherPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName) || string.IsNullOrEmpty(x_sOtherPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + "<=" + x_sOtherPropertyName, x_sPropertyName, x_sOtherPropertyName, DsExpressionStatus.LeProperty);
        }

        public static DsExpression Lt(string x_sPropertyName, object x_oValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            if (x_oValue == null) return new DsExpression(x_sPropertyName + " IS NULL ", x_sPropertyName, x_oValue, false, true, DsExpressionStatus.IsNull);
            string _sValue = (x_oValue is string) ? ("'" + x_oValue.ToString().Replace("'", "''") + "'") : x_oValue.ToString();
            return new DsExpression(x_sPropertyName + "<" + _sValue.ToString(), x_sPropertyName, x_oValue, (x_oValue is string) ? true : false, false, DsExpressionStatus.Lt);
        }

        public static DsExpression LtProperty(string x_sPropertyName, string x_sOtherPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName) || string.IsNullOrEmpty(x_sOtherPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + "<" + x_sOtherPropertyName, x_sPropertyName, x_sOtherPropertyName, DsExpressionStatus.LtProperty);
        }


        public static DsExpression Ge(string x_sPropertyName, object x_oValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            if (x_oValue == null) return new DsExpression(x_sPropertyName + " IS NULL ", x_sPropertyName, x_oValue, false, true, DsExpressionStatus.IsNull);
            string _sValue = (x_oValue is string) ? ("'" + x_oValue.ToString().Replace("'", "''") + "'") : x_oValue.ToString();
            return new DsExpression(x_sPropertyName + ">=" + _sValue.ToString(), x_sPropertyName, x_oValue, (x_oValue is string) ? true : false, false, DsExpressionStatus.Ge);
        }


        public static DsExpression GeProperty(string x_sPropertyName, string x_sOtherPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName) || string.IsNullOrEmpty(x_sOtherPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + ">=" + x_sOtherPropertyName, x_sPropertyName, x_sOtherPropertyName, DsExpressionStatus.GeProperty);
        }

        public static DsExpression Gt(string x_sPropertyName, object x_oValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            if (x_oValue == null) return new DsExpression(x_sPropertyName + " IS NULL ", x_sPropertyName, x_oValue, false, true, DsExpressionStatus.IsNull);
            string _sValue = (x_oValue is string) ? ("'" + x_oValue.ToString().Replace("'", "''") + "'") : x_oValue.ToString();
            return new DsExpression(x_sPropertyName + ">" + _sValue.ToString(), x_sPropertyName, x_oValue, (x_oValue is string) ? true : false, false, DsExpressionStatus.Gt);
        }

        public static DsExpression GtProperty(string x_sPropertyName, string x_sOtherPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName) || string.IsNullOrEmpty(x_sOtherPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + ">" + x_sOtherPropertyName, x_sPropertyName, x_sOtherPropertyName, DsExpressionStatus.GtProperty);
        }


        public static DsExpression IsNull(string x_sPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + " IS NULL ", x_sPropertyName, null, false, true, DsExpressionStatus.IsNull);
        }

        public static DsExpression IsNotNull(string x_sPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + " IS NOT NULL ", x_sPropertyName, null, false, false, DsExpressionStatus.IsNotNull);
        }

        public static DsExpression IsEmpty(string x_sPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + "=''", x_sPropertyName, string.Empty, false, false, DsExpressionStatus.IsEmpty);
        }

        public static DsExpression IsNotEmpty(string x_sPropertyName)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            return new DsExpression(x_sPropertyName + "<>''", x_sPropertyName, string.Empty, false, false, DsExpressionStatus.IsNotEmpty);
        }

        public static DsExpression Like(string x_sPropertyName, string x_sValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            if (string.IsNullOrEmpty(x_sValue)) return new DsExpression();
            return new DsExpression(x_sPropertyName + " Like " + "'" + x_sValue.Replace("'", "''") + "'", x_sPropertyName, x_sValue, true, false, DsExpressionStatus.Like);
        }

        public static DsExpression NotLike(string x_sPropertyName, string x_sValue)
        {
            if (string.IsNullOrEmpty(x_sPropertyName)) return new DsExpression();
            if (string.IsNullOrEmpty(x_sValue)) return new DsExpression();
            return new DsExpression(x_sPropertyName + " NOT LIKE " + "'" + x_sValue.Replace("'", "''") + "'", x_sPropertyName, x_sValue, true, false, DsExpressionStatus.NotLike);
        }
    }
}
