using System;
using System.IO;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Security.Cryptography;
using System.Reflection;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;

namespace NEURON.ENTITY.FRAMEWORK
{
    public class FuncHelper
    {
        #region Setting
        public static int DefaultInt = -1;
        public static double DefaultDouble = -1;
        public static string DefaultString = "";
        public static DateTime DefaultDateTime { get { return DateTime.Now; } }
        public static bool DefaultBoolean = false;
        public static string StrSeperator { get { return "|"; } }
        public static string QtnSeperator { get { return "/\n"; } }
        public static string SessionLang = "language";
        public static string[] n_sDBDatePatternList = { "dd/MM/yyyy", "d/MM/yyyy", "dd/M/yyyy", "d/M/yyyy" };
        public static string[] n_sDateTimeList = { "MM/dd/yyyy", "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy", "M/dd/yyyy HH:mm", "MM/d/yyyy HH:mm", "M/dd/yyyy HH:mm", "M/d/yyyy HH:mm", "M/dd/yyyy HH:mm:ss", "MM/d/yyyy HH:mm:ss", "M/dd/yyyy HH:mm:ss", "M/d/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy hh:mm:ss", "MM/d/yyyy hh:mm:ss", "M/dd/yyyy hh:mm:ss", "M/d/yyyy hh:mm:ss", "MM/dd/yyyy tt hh:mm:ss", "MM/d/yyyy tt hh:mm:ss", "M/dd/yyyy tt hh:mm:ss", "M/d/yyyy tt hh:mm:ss" };
        public static string[] n_sDateTimeListTmp1 = { "yyyy/MM/dd", "yyyy/M/dd", "yyyy/MM/d", "yyyy/M/d", "yyyy/MM/dd HH:mm", "yyyy/M/dd HH:mm", "yyyy/MM/d HH:mm", "yyyy/M/d HH:mm", "yyyy/MM/dd HH:mm:ss", "yyyy/M/dd HH:mm:ss", "yyyy/MM/d HH:mm:ss", "yyyy/M/d HH:mm:ss", "yyyy/MM/dd hh:mm:ss", "yyyy/MM/dd hh:mm:ss", "yyyy/M/dd hh:mm:ss", "yyyy/MM/d hh:mm:ss", "yyyy/M/d hh:mm:ss", "yyyy/MM/dd tt hh:mm:ss", "yyyy/M/dd tt hh:mm:ss", "yyyy/MM/d tt hh:mm:ss", "yyyy/M/d tt hh:mm:ss" };
        public static string[] n_sDateTimeListTmp2 = { "dd/MM/yyyy", "dd/M/yyyy", "d/MM/yyyy", "d/M/yyyy", "dd/MM/yyyy HH:mm", "dd/M/yyyy HH:mm", "d/MM/yyyy HH:mm", "d/M/yyyy HH:mm", "dd/MM/yyyy HH:mm:ss", "dd/M/yyyy HH:mm:ss", "d/MM/yyyy HH:mm:ss", "d/M/yyyy HH:mm:ss", "dd/MM/yyyy hh:mm:ss", "dd/MM/yyyy hh:mm:ss", "dd/M/yyyy hh:mm:ss", "d/MM/yyyy hh:mm:ss", "d/M/yyyy hh:mm:ss", "dd/MM/yyyy tt hh:mm:ss", "dd/M/yyyy tt hh:mm:ss", "d/MM/yyyy tt hh:mm:ss", "d/M/yyyy tt hh:mm:ss" };
        public static string n_sDBDatePattern = "dd/MM/yyyy";
        #endregion
        public FuncHelper() { }
        #region String Left and Right read
        public static string Left(string x_sStr, int x_iLen)
        {
            if (x_sStr.Length >= x_iLen)
                return x_sStr.Substring(0, x_iLen);
            else
                return string.Empty;
        }
        public static string Right(string x_sStr, int x_iLen)
        {
            if (x_sStr.Equals(string.Empty)) return string.Empty;
            if (x_sStr.Length >= x_iLen)
                return x_sStr.Substring(x_sStr.Length - x_iLen, x_iLen);
            else
                return string.Empty;
        }
        #endregion
        #region DataReader Field Check And Return
        public static string FR(object x_oObj)
        {
            if (FuncHelper.IsDBNullOrEmpty(x_oObj)) return string.Empty;
            return x_oObj.ToString();
        }
        public static string DR(object x_oObj)
        {
            if (x_oObj == null) return string.Empty;
            return x_oObj.ToString();
        }

        #endregion
        #region Request Field Check And Return
        public static string RQ(object x_oObj)
        {
            if (x_oObj == null) return string.Empty;
            return x_oObj.ToString();
        }
        public static bool RB(object x_oObj)
        {
            if (x_oObj == null) return false;
            if ("".Equals(x_oObj.ToString().Trim())) return false;
            return true;
        }
        #endregion
        #region DateDiff
        public static double DateDiff(string x_sHowtocompare, System.DateTime x_sStartDate, System.DateTime x_sEndDate)
        {
            double _dDiff = 0;
            System.TimeSpan _oTS = new System.TimeSpan(x_sEndDate.Ticks - x_sStartDate.Ticks);
            switch (x_sHowtocompare.ToLower())
            {
                case "year":
                    _dDiff = Convert.ToDouble(_oTS.TotalDays / 365);
                    break;
                case "month":
                    _dDiff = Convert.ToDouble((_oTS.TotalDays / 365) * 12);
                    break;
                case "day":
                    _dDiff = Convert.ToDouble(_oTS.TotalDays);
                    break;
                case "hour":
                    _dDiff = Convert.ToDouble(_oTS.TotalHours);
                    break;
                case "minute":
                    _dDiff = Convert.ToDouble(_oTS.TotalMinutes);
                    break;
                case "second":
                    _dDiff = Convert.ToDouble(_oTS.TotalSeconds);
                    break;
            }

            return _dDiff;
            throw new NotImplementedException();
        }
        #endregion
        #region String Trim
        public static string StringTrim(object xObj)
        {
            if (xObj != null)
            {
                if (xObj is string) return xObj.ToString().Trim();
                if (xObj is DateTime) return ((DateTime)xObj).ToString(n_sDBDatePattern).Trim();
            }
            else
                return string.Empty;
            return xObj.ToString().Trim();
        }
        #endregion
        #region IS Functions: IsEmpty, IsEqualStr, IsInt, IsDouble, IsDateTime
        public static bool IsEmpty(object xObj)
        {
            if (xObj == null)
                return true;
            return (xObj.ToString().Trim().Length == 0);
        }
        #region IsEqualStr
        public static bool IsEqualStr(string xString1, string xString2)
        {
            return IsEqualStr(xString1, xString2, false, true);
        }
        public static bool IsEqualStr(string xString1, string xString2, bool xCaseSensitive)
        {
            return IsEqualStr(xString1, xString2, xCaseSensitive, true);
        }
        public static bool IsEqualStr(string xString1, string xString2, bool xCaseSensitive, bool xTrim)
        {
            if (xTrim)
            {
                xString1 = xString1.Trim();
                xString2 = xString2.Trim();
            }
            if (xCaseSensitive)
                return xString1.Equals(xString2);
            return xString1.ToLower().Equals(xString2.ToLower());
        }
        #endregion
        public static bool IsDBNullOrEmpty(object xObj)
        {
            if (Convert.IsDBNull(xObj)) { return true; }
            if (string.IsNullOrEmpty(xObj.ToString())) { return true; }
            return false;
        }
        public static bool IsParseInt(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                int _iValue;
                if (int.TryParse(xObj, out _iValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseLong(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                long _lValue;
                if (long.TryParse(xObj, out _lValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseDouble(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                double _fValue;
                if (double.TryParse(xObj, out _fValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseDateTime(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                ConvertDatetime(xObj);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseBool(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                bool _bValue;
                if (bool.TryParse(xObj, out _bValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool IsParseCheckBoxBool(string xObj)
        {
            if (xObj == null) return false;
            xObj = xObj.Trim();
            if (xObj.Equals("on") || xObj.Equals("1"))
            {
                try{
                    bool _bValue;
                    if (xObj.Equals("on"))
                        return true;
                    else if (bool.TryParse(xObj, out _bValue))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch{
                    return false;
                }
            }
            return true;
        }

        public static bool IsParseChar(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                char _cValue;
                if (char.TryParse(xObj, out _cValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseByte(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                Byte _bValue;
                if (Byte.TryParse(xObj, out _bValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseByteArr(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                (new System.Text.ASCIIEncoding()).GetBytes(xObj);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseString(string xObj)
        {
            if (xObj == null) return false;
            return true;
        }
        public static bool IsParseDecimal(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                Decimal _dValue;
                if (Decimal.TryParse(xObj, out _dValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseInt16(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                short _iValue;
                if (short.TryParse(xObj, out _iValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseGuid(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                Guid _oValue = new Guid(xObj.ToString());
                return true;
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseFloat(string xObj)
        {
            if (xObj == null) return false;
            try
            {
                double _fValue;
                if (double.TryParse(xObj, out _fValue))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool IsParseObject(string xObj)
        {
            if (xObj == null) return false;
            return true;
        }
        public static bool IsInt(object xObj)
        {
            if (xObj is int)
                return IsInteger(xObj.ToString().Trim());
            return false;
        }
        public static bool IsLong(object xObj)
        {
            if (xObj is long)
                return IsInteger(xObj.ToString().Trim());
            return false;
        }
        public static bool IsDouble(object xObj)
        {
            try
            {
                if (xObj is double)
                {
                    double.Parse(xObj.ToString().Trim());
                    return true;
                }
                else
                    return false;

            }
            catch
            {
                return false;
            }
        }
        public static bool IsDateTime(object xObj)
        {
            try
            {
                if (xObj is DateTime)
                {
                    DateTime _dValue;
                    if (DateTime.TryParse(xObj.ToString().Trim(), out _dValue))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsBool(object xObj) { return ((xObj is bool && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsChar(object xObj) { return ((xObj is char && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsByte(object xObj) { return ((xObj is byte && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsByteArr(object xObj) { return ((xObj is byte[] && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsString(object xObj) { return ((xObj is string && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsDecimal(object xObj) { return ((xObj is decimal && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsInt16(object xObj) { return ((xObj is Int16 && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsGuid(object xObj) { return ((xObj is Guid && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsFloat(object xObj) { return ((xObj is float && xObj != null && !"".Equals(xObj.ToString())) ? true : false); }
        public static bool IsObject(object xObj) { return ((xObj != null && !"".Equals(xObj.ToString())) ? true : false); }

        // Function to test for Positive Integers.
        protected static bool IsNaturalNumber(String strNumber)
        {
            Regex objNotNaturalPattern = new Regex("[^0-9]");
            Regex objNaturalPattern = new Regex("0*[1-9][0-9]*");
            return !objNotNaturalPattern.IsMatch(strNumber) &&
            objNaturalPattern.IsMatch(strNumber);
        }
        // Function to test for Positive Integers with zero inclusive
        protected static bool IsWholeNumber(String strNumber)
        {
            Regex objNotWholePattern = new Regex("[^0-9]");
            return !objNotWholePattern.IsMatch(strNumber);
        }
        // Function to Test for Integers both Positive & Negative
        protected static bool IsInteger(String strNumber)
        {
            Regex objNotIntPattern = new Regex("[^0-9-]");
            Regex objIntPattern = new Regex("^-[0-9]+$|^[0-9]+$");
            return !objNotIntPattern.IsMatch(strNumber) && objIntPattern.IsMatch(strNumber);
        }
        // Function to Test for Positive Number both Integer & Real
        protected static bool IsPositiveNumber(String strNumber)
        {
            Regex objNotPositivePattern = new Regex("[^0-9.]");
            Regex objPositivePattern = new Regex("^[.][0-9]+$|[0-9]*[.]*[0-9]+$");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            return !objNotPositivePattern.IsMatch(strNumber) &&
            objPositivePattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber);
        }
        // Function to test whether the string is valid number or not
        protected static bool IsNumber(String strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([-]|[0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");
            return !objNotNumberPattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber) &&
            !objTwoMinusPattern.IsMatch(strNumber) &&
            objNumberPattern.IsMatch(strNumber);
        }
        // Function To test for Alphabets.
        protected static bool IsAlpha(String strToCheck)
        {
            Regex objAlphaPattern = new Regex("[^a-zA-Z]");
            return !objAlphaPattern.IsMatch(strToCheck);
        }
        // Function to Check for AlphaNumeric.
        protected static bool IsAlphaNumeric(String strToCheck)
        {
            Regex objAlphaNumericPattern = new Regex("[^a-zA-Z0-9]");
            return !objAlphaNumericPattern.IsMatch(strToCheck);
        }
        #endregion
        #region DATA Function: Xml2DataSet, DataSet2Xml, FillData, InsertData, UpdateData, HasData, DBDateTime, DBStr, DBBool, DBSize, SetData
        #region Xml2DataSet, DataSet2Xml

        public static global::System.Data.DataSet Xml2DataSet(string xXmlContent)
        {
            return Xml2DataSet(xXmlContent, "");
        }
        public static global::System.Data.DataSet Xml2DataSet(string xXmlContent, string sCaller)
        {
            try
            {
                global::System.Data.DataSet myDataSet = new global::System.Data.DataSet();
                StringReader myStringReader = new StringReader(xXmlContent);
                myDataSet.ReadXml(myStringReader);
                return myDataSet;
            }
            catch (Exception Err)
            {
                SystemError.CreateErrorLog(sCaller + ":Xml2DataSet:" + Err.Message);
            }
            return null;
        }
        public static string DataSet2Xml(DataSet xDataSet)
        {
            return DataSet2Xml(xDataSet, "");
        }
        public static string DataSet2Xml(DataSet xDataSet, string sCaller)
        {
            try
            {
                if (HasData(xDataSet))
                {
                    StringWriter myStringWriter = new StringWriter();
                    xDataSet.WriteXml(myStringWriter, System.Data.XmlWriteMode.WriteSchema);
                    return myStringWriter.ToString();
                }
            }
            catch (Exception Err)
            {
                SystemError.CreateErrorLog("DataSet2Xml:" + Err.Message);
            }
            return "";
        }
        #endregion
        #region DBSize
        public static int DBSize(DateTime xDataTime)
        {
            return 8;
        }
        public static int DBSize(int xInt)
        {
            return 4;
        }
        public static int DBSize(double xDouble)
        {
            return 8;
        }
        public static int DBSize(string xString)
        {
            if (xString == null) return 0;
            return xString.Length * 2;
        }
        public static int DBSize(bool xBoolean)
        {
            return 2;
        }
        #endregion
        #region DBStr
        public static string DBStr(object xObj)
        {
            return DBStr(xObj, false, false);
        }
        public static string DBStr(object xObj, bool xToNull, bool xTrim)
        {
            string myTmp = (xObj == null) ? "" : xObj.ToString();
            if (xTrim) myTmp = myTmp.Trim();
            if (xToNull)
                if (myTmp.Length == 0)
                    return "NULL";
            return "'" + myTmp.Replace("\\", "\\\\").Replace("'", "\\'") + "'";
        }
        #endregion
        #region DBDateTime
        public static string DBDateTime(object xObj)
        {
            return DBDateTime(xObj, false);
        }
        public static string DBDateTime(object xObj, bool xToNull)
        {
            if (IsDateTime(xObj)) return DBDateTime(DateTime.Parse(xObj.ToString()));
            if (xToNull) return "NULL";
            return DBDateTime(DefaultDateTime);
        }
        public static string DBDateTime(DateTime xDateTime)
        {
            return "'" + xDateTime.ToString("yyyy/MM/dd HH:mm:ss") + "'";
        }
        #endregion
        #region DBBool
        public static string DBBool(bool xBool)
        {
            return DBBool(xBool, "1", "0");
        }
        public static string DBBool(object xObj)
        {
            return DBBool(xObj, "1", "0");
        }
        public static string DBBool(object xObj, string xTrue, string xFalse)
        {
            if (xObj.GetType().Equals(System.Type.GetType("System.Boolean")))
                return DBBool((bool)xObj, xTrue, xFalse);
            if (IsInt(xObj))
                return DBBool(int.Parse(xObj.ToString()) == 1, xTrue, xFalse);
            return DBBool(DefaultBoolean, xTrue, xFalse);
        }
        public static string DBBool(bool xBool, string xTrue, string xFalse)
        {
            return ((xBool) ? xTrue : xFalse);
        }
        #endregion
        #region InsertData
        public static string InsertData(DateTime xDateTime)
        {
            return DBDateTime(xDateTime);
        }
        public static string InsertData(DateTime xDateTime, bool xToNull, bool xTrim)
        {
            return InsertData(xDateTime);
        }
        public static string InsertData(double xDouble)
        {
            return xDouble.ToString();
        }
        public static string InsertData(double xDouble, bool xToNull, bool xTrim)
        {
            return InsertData(xDouble);
        }
        public static string InsertData(int xInt)
        {
            return InsertData(xInt, false, false);
        }
        public static string InsertData(int xInt, bool xToNull, bool xTrim)
        {
            if (xToNull)
                if (xInt == DefaultInt)
                    return "NULL";
            return xInt.ToString();
        }
        public static string InsertData(char xString)
        {
            return InsertData(xString.ToString(), false, false);
        }
        public static string InsertData(char xString, bool xToNull, bool xTrim)
        {
            return DBStr(xString.ToString(), xToNull, xTrim);
        }
        public static string InsertData(string xString)
        {
            return InsertData(xString, false, false);
        }
        public static string InsertData(string xString, bool xToNull, bool xTrim)
        {
            return DBStr(xString, xToNull, xTrim);
        }
        public static string InsertData(bool xBool)
        {
            return DBBool(xBool);
        }
        public static string InsertData(bool xBool, bool xToNull, bool xTrim)
        {
            return InsertData(xBool);
        }
        #endregion
        #region UpdateData
        public static string UpdateData(string xName, DateTime xDateTime)
        {
            return UpdateData(xName, xDateTime, false, false);
        }
        public static string UpdateData(string xName, DateTime xDateTime, bool xToNull, bool xTrim)
        {
            return xName + " = " + DBDateTime(xDateTime);
        }
        public static string UpdateData(string xName, double xDouble)
        {
            return xName + " = " + xDouble.ToString();
        }
        public static string UpdateData(string xName, double xDouble, bool xToNull, bool xTrim)
        {
            return UpdateData(xName, xDouble);
        }
        public static string UpdateData(string xName, int xInt)
        {
            return UpdateData(xName, xInt, false, false);
        }
        public static string UpdateData(string xName, int xInt, bool xToNull, bool xTrim)
        {
            if (xToNull)
                if (xInt == DefaultInt)
                    return xName + " = NULL";
            return xName + " = " + xInt.ToString();
        }
        public static string UpdateData(string xName, string xString)
        {
            return UpdateData(xName, xString, false, false);
        }
        public static string UpdateData(string xName, string xString, bool xToNull, bool xTrim)
        {
            return xName + " = " + DBStr(xString, xToNull, xTrim);
        }
        public static string UpdateData(string xName, bool xBool)
        {
            return xName + " = " + DBBool(xBool);
        }
        public static string UpdateData(string xName, bool xBool, bool xToNull, bool xTrim)
        {
            return UpdateData(xName, xBool);
        }
        #endregion
        #region FillData
        public static void FillData(ref DateTime xDateTime, global::System.Data.DataRow xDR, string xName)
        {
            FillData(ref xDateTime, xDR, xName, DefaultDateTime);
        }
        public static void FillData(ref DateTime xDateTime, global::System.Data.DataRow xDR, string xName, DateTime xDefault)
        {
            xDateTime = (IsDateTime(xDR[xName])) ? DateTime.Parse(xDR[xName].ToString()) : xDefault;
        }
        public static void FillData(ref double xDouble, global::System.Data.DataRow xDR, string xName)
        {
            FillData(ref xDouble, xDR, xName, DefaultDouble);
        }
        public static void FillData(ref double xDouble, global::System.Data.DataRow xDR, string xName, double xDefault)
        {
            xDouble = (IsDouble(xDR[xName])) ? double.Parse(xDR[xName].ToString()) : xDefault;
        }
        public static void FillData(ref int xInt, global::System.Data.DataRow xDR, string xName)
        {
            FillData(ref xInt, xDR, xName, DefaultInt);
        }
        public static void FillData(ref int xInt, global::System.Data.DataRow xDR, string xName, int xDefault)
        {
            xInt = (IsInt(xDR[xName])) ? int.Parse(xDR[xName].ToString()) : xDefault;
        }
        public static void FillData(ref long xLong, global::System.Data.DataRow xDR, string xName)
        {
            FillData(ref xLong, xDR, xName, DefaultInt);
        }
        public static void FillData(ref long xLong, global::System.Data.DataRow xDR, string xName, long xDefault)
        {
            xLong = (IsLong(xDR[xName])) ? long.Parse(xDR[xName].ToString()) : xDefault;
        }
        public static void FillData(ref string xStr, global::System.Data.DataRow xDR, string xName)
        {
            xStr = xDR[xName].ToString();
        }
        public static void FillData(ref string xStr, global::System.Data.DataRow xDR, string xName, string xDefault)
        {
            xStr = xDR[xName].ToString();
        }
        public static void FillData(ref char xChar, global::System.Data.DataRow xDR, string xName)
        {
            string s = xDR[xName].ToString();
            if (s.Length == 1)
                xChar = char.Parse(xDR[xName].ToString());
            else
                xChar = ' ';
        }
        public static void FillData(ref bool xBool, global::System.Data.DataRow xDR, string xName)
        {
            FillData(ref xBool, xDR, xName, DefaultBoolean);
        }
        public static void FillData(ref bool xBool, global::System.Data.DataRow xDR, string xName, bool xDefault)
        {
            if (IsEmpty(xDR[xName]))
                xBool = xDefault;
            else
                xBool = xDR[xName].ToString().Equals("1") | xDR[xName].ToString().ToLower().Equals("true");
        }
        #endregion
        #region HasData
        public static bool HasData(global::System.Data.DataRow xDataRow)
        {
            return (xDataRow != null);
        }
        public static bool HasData(DataTable xDataTable)
        {
            if (xDataTable != null)
                return (xDataTable.Rows.Count > 0);
            return false;
        }
        public static bool HasData(DataSet xDataSet)
        {
            if (xDataSet != null)
                return HasData(xDataSet.Tables[0]);
            return false;
        }
        #endregion

        #endregion
        #region UI IO Function: WriteMsg
        public static string BIG5toUTF8(string x_sObj)
        {
            if (string.IsNullOrEmpty(x_sObj)) return string.Empty;
            return new UTF8Encoding().GetString(Encoding.GetEncoding("big5").GetBytes(x_sObj));
        }
        #region iso-8859-1 Latin-1 to Big5
        public static string LatinToBig5(string x_sObj)
        {
            if (string.IsNullOrEmpty(x_sObj)) return string.Empty;
            Byte[] _bChar = Encoding.GetEncoding(1252).GetBytes(x_sObj);
            return Encoding.GetEncoding(950).GetString(_bChar);
        }
        #endregion

        #region iso-8859-1 Latin-1 to UTF8
        public static string LatinToUTF8(string x_sObj)
        {
            if (string.IsNullOrEmpty(x_sObj)) return string.Empty;
            Byte[] _bChar = Encoding.GetEncoding(1252).GetBytes(x_sObj);
            return Encoding.GetEncoding(65001).GetString(_bChar);
        }
        #endregion

        #region Big5 to iso-8859-1
        public static string Big5ToLatin(string x_sObj)
        {
            if (string.IsNullOrEmpty(x_sObj)) return string.Empty;
            Byte[] _bChar = Encoding.GetEncoding(950).GetBytes(x_sObj);
            return Encoding.GetEncoding(1252).GetString(_bChar);
        }
        #endregion
        public static char NextASCII(char startChar, int count)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            Byte[] encodedBytes;
            encodedBytes = ascii.GetBytes(startChar.ToString());
            int startASCII = int.Parse(encodedBytes[0].ToString());
            int targetASCII = startASCII + count;
            Byte[] decodeBytes = new Byte[1];
            decodeBytes[0] = byte.Parse(targetASCII.ToString());
            string targetString = ascii.GetString(decodeBytes, 0, 1);
            return char.Parse(targetString);
        }
        #endregion
        #region String Function: ImplodeString, ExplodeInt
        public static string ImplodeString(string[] source, string limiter)
        {
            return ImplodeString(source, limiter, -1);
        }
        public static string ImplodeString(string[] source, string limiter, int charBound)
        {
            string result = "";
            for (int i = 0; i < source.Length; i++)
            {
                if (i != 0)
                    result += limiter;
                if ((charBound != -1) && (result.Length + source[i].Length > charBound))
                {
                    result += "...";
                    return result;
                }
                else
                {
                    result += source[i];
                }
            }
            return result;
        }
        public static string ImplodeInt(int[] source, string limiter)
        {
            string result = "";
            for (int i = 0; i < source.Length; i++)
            {
                if (result != "")
                    result += limiter;
                result += source[i].ToString();
            }
            return result;
        }

        #region Explode List String
        public static string ExplodeList(List<string> x_oObject, string _sSp)
        {
            return FuncHelper.ExplodeList(x_oObject, _sSp, false);
        }

        public static string ExplodeList(List<string> x_oObject, string _sSp, bool _bApostrophe)
        {
            global::System.Text.StringBuilder _oTmp = new global::System.Text.StringBuilder();
            if (!"".Equals(_sSp))
            {
                for (int i = 0; i < x_oObject.Count; i++)
                {
                    if (_oTmp.ToString() != string.Empty) _oTmp.Append(_sSp);
                    if (_bApostrophe)
                    {
                        _oTmp.Append("'"+x_oObject[i].ToString().Trim()+"'");
                    }
                    else
                    {
                        _oTmp.Append(x_oObject[i].ToString().Trim());
                    }
                }
            }
            return _oTmp.ToString();
        }
        #endregion

        public static string[] ExplodeString(string source, string limiter)
        {
            bool found = true;
            ArrayList o_aResult = new ArrayList();
            int count;
            while ((found))
            {
                count = source.IndexOf(limiter);
                if (count != -1)
                {
                    o_aResult.Add(source.Substring(0, count));
                    source = source.Substring(count + limiter.Length);
                }
                else
                {
                    found = false;
                }
            }
            o_aResult.Add(source);
            string[] result = new string[o_aResult.Count];
            for (int i = 0; i < result.Length; i++)
                result[i] = (string)o_aResult[i];
            return result;
        }
        public static int[] ExplodeInt(string source, char limiter)
        {
            char[] limiters = { limiter };
            string[] strResult = source.Split(limiters);
            ArrayList intArrayResult = new ArrayList();
            for (int i = 0; i < strResult.Length; i++)
            {
                if (FuncHelper.IsInt(strResult[i]))
                    intArrayResult.Add(int.Parse(strResult[i]));
            }
            int[] intResult = new int[intArrayResult.Count];
            for (int i = 0; i < intArrayResult.Count; i++)
                intResult[i] = (int)intArrayResult[i];
            return intResult;
        }
        #endregion
        #region File Funciton : OutputFileSize
        public static string OutputFileSize(int size)
        {
            int sizeLevel = 1;
            while (size >= 1024)
            {
                size = size / 1024;
                sizeLevel++;
            }
            switch (sizeLevel)
            {
                case 1:
                    return size.ToString() + 'B';
                case 2:
                    return size.ToString() + 'K';
                case 3:
                    return size.ToString() + 'M';
                case 4:
                    return size.ToString() + 'G';
                default:
                    return size.ToString() + 'B';
            }
        }
        #endregion

        #region Random Choose Function : RandomItem
        public static ArrayList RandomItem(ArrayList x_Input, int x_NumSelect)
        {
            Random ran = new Random();
            if (x_Input.Count < x_NumSelect)
                return x_Input;
            else
            {
                ArrayList x_Output = new ArrayList();
                int i = 0;
                while (i < x_NumSelect)
                {
                    int sel = ran.Next() % x_Input.Count;
                    x_Output.Add(x_Input[sel]);
                    x_Input.RemoveAt(sel);
                    x_Input.TrimToSize();
                    i++;
                }
                return x_Output;
            }
        }
        #endregion

        #region DateTimeCompare
        public static int DateTimeCompare(Nullable<DateTime> t1, Nullable<DateTime> t2)
        {
            if (t1 == null) return -2;
            if (t2 == null) return -3;
            return DateTime.Compare(Convert.ToDateTime(t1), Convert.ToDateTime(t2));
        }
        #endregion

        #region ConvertDatetime
        public static DateTime ConvertDatetime(string x_sDate)
        {
            string[] _sDateTimeList = { "MM/dd/yyyy", "M/dd/yyyy", "MM/d/yyyy", "M/d/yyyy", "M/dd/yyyy HH:mm", "MM/d/yyyy HH:mm", "M/dd/yyyy HH:mm", "M/d/yyyy HH:mm", "M/dd/yyyy HH:mm:ss", "MM/d/yyyy HH:mm:ss", "M/dd/yyyy HH:mm:ss", "M/d/yyyy HH:mm:ss", "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy hh:mm:ss", "MM/d/yyyy hh:mm:ss", "M/dd/yyyy hh:mm:ss", "M/d/yyyy hh:mm:ss", "MM/dd/yyyy tt hh:mm:ss", "MM/d/yyyy tt hh:mm:ss", "M/dd/yyyy tt hh:mm:ss", "M/d/yyyy tt hh:mm:ss" };
            string[] _sDateTimeList2 = { "yyyy/MM/dd", "yyyy/M/dd", "yyyy/MM/d", "yyyy/M/d", "yyyy/MM/dd HH:mm", "yyyy/M/dd HH:mm", "yyyy/MM/d HH:mm", "yyyy/M/d HH:mm", "yyyy/MM/dd HH:mm:ss", "yyyy/M/dd HH:mm:ss", "yyyy/MM/d HH:mm:ss", "yyyy/M/d HH:mm:ss", "yyyy/MM/dd hh:mm:ss", "yyyy/MM/dd hh:mm:ss", "yyyy/M/dd hh:mm:ss", "yyyy/MM/d hh:mm:ss", "yyyy/M/d hh:mm:ss", "yyyy/MM/dd tt hh:mm:ss", "yyyy/M/dd tt hh:mm:ss", "yyyy/MM/d tt hh:mm:ss", "yyyy/M/d tt hh:mm:ss" };
            string[] _sDateTimeList3 = { "dd/MM/yyyy", "dd/M/yyyy", "d/MM/yyyy", "d/M/yyyy", "dd/MM/yyyy HH:mm", "dd/M/yyyy HH:mm", "d/MM/yyyy HH:mm", "d/M/yyyy HH:mm", "dd/MM/yyyy HH:mm:ss", "dd/M/yyyy HH:mm:ss", "d/MM/yyyy HH:mm:ss", "d/M/yyyy HH:mm:ss", "dd/MM/yyyy hh:mm:ss", "dd/MM/yyyy hh:mm:ss", "dd/M/yyyy hh:mm:ss", "d/MM/yyyy hh:mm:ss", "d/M/yyyy hh:mm:ss", "dd/MM/yyyy tt hh:mm:ss", "dd/M/yyyy tt hh:mm:ss", "d/MM/yyyy tt hh:mm:ss", "d/M/yyyy tt hh:mm:ss" };
            x_sDate = x_sDate.Replace("上午", "AM");
            x_sDate = x_sDate.Replace("下午", "PM");
            if (!string.Empty.Equals(x_sDate.Trim()))
            {
                try
                {
                    DateTime _dValue;
                    if (DateTime.TryParseExact(x_sDate.Trim(), _sDateTimeList, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dValue))
                    {
                        return _dValue;
                    }
                    else if (DateTime.TryParseExact(x_sDate.Trim(), _sDateTimeList2, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dValue))
                    {
                        return _dValue;
                    }
                    else if (DateTime.TryParseExact(x_sDate.Trim(), _sDateTimeList3, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces, out _dValue))
                    {
                        return _dValue;
                    }
                }
                catch (System.FormatException ex)
                {
                }
            }
            return Convert.ToDateTime(x_sDate);
        }
        public static DateTime ConvertDatetime(string x_sDate, string x_sPattern)
        {
            return DateTime.ParseExact(x_sDate, x_sPattern, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces);
        }
        #endregion

        #region Convertion
        public static int ParseInt(object xObj)
        {
            if (xObj == null)
                return 0;
            try
            {
                return int.Parse(xObj.ToString());
            }
            finally { }
            return 0;
        }
        public static string ParseString(object xObj)
        {
            if (xObj == null)
                return "";
            try
            {
                return xObj.ToString();
            }
            finally { }
        }
        #endregion

        #region DateFormat
        public static string DateFormatShortDate
        {
            get
            {
                return "dd/MM/yyyy";
            }
        }
        public static string DateFormatWebCalendar
        {
            get
            {
                return "dd/MM/yyyy";
            }
        }
        public static string DateFormatQueryString
        {
            get
            {
                return "yyyymmdd";
            }
        }
        #endregion

        #region MD5
        static public string MD5(string input)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            global::System.Text.StringBuilder sBuilder = new global::System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        #endregion

        #region ConvertToCSV
        static public string convertToCSV(DataTable dt)
        {
            global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
            if (dt.Columns.Count > 0)
            {
                foreach (DataColumn c in dt.Columns)
                {
                    sb.Append(c.ColumnName + ",");
                }
                sb.Append(System.Environment.NewLine);
                foreach (global::System.Data.DataRow r in dt.Rows)
                {
                    foreach (DataColumn c in dt.Columns)
                    {
                        sb.Append(r[c].ToString() + ",");
                    }
                    sb.Append(System.Environment.NewLine);
                }
            }
            return sb.ToString();
        }
        #endregion
		
		#region Inherit To Derived
        public static DerivedType InheritToDerived<DerivedType, InheritType>(InheritType x_oInheritBase)
        {
            DerivedType _oDerived = Activator.CreateInstance<DerivedType>();
            Type _oDerivedType = typeof(DerivedType);
            if (_oDerivedType.IsSubclassOf(typeof(InheritType)))
            {
                foreach (PropertyInfo _oProp in x_oInheritBase.GetType().GetProperties())
                {
                    PropertyInfo _oPropVal = x_oInheritBase.GetType().GetProperty(_oProp.Name);
                    _oPropVal.SetValue(_oDerived, _oPropVal.GetValue(x_oInheritBase, null), null);
                }
                return _oDerived;
            }
            return Activator.CreateInstance<DerivedType>();
        }
        #endregion


        #region Check English Char
        public static bool isEnglishChar(char x_cChar)
        {
            if(x_cChar.Equals(string.Empty)) return false;
            UnicodeCategory _oCat = char.GetUnicodeCategory(x_cChar);
            if (_oCat == UnicodeCategory.OtherLetter)
                return false;
            else
                return true;
        }
        #endregion

    }

}

