using System;
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

///-- =============================================
///-- Author:		<Author: Sum Wan,FU>
///-- Create date: <Create Date 2008-06-07>
///-- Framework Description:	 NEURON .Net Entity Framework is developed by Sum Wan, FUin 2008. 
///--                            This library is for Dataset reader class.
///-- =============================================
namespace NEURON.ENTITY.FRAMEWORK
{
    public class IDSQuery
    {
        #region RowRecord
        protected DataRowView[] n_oRowRecord = null;
        public DataRowView[] RowRecord
        {
            get
            {
                if (n_oRowRecord == null) { n_oRowRecord = ToDataRowView(); }
                return n_oRowRecord;
            }
            set
            {
                n_oRowRecord = value;
            }
        }
        #endregion

        #region this[]
        public string this[int pos, string fieldname]
        {
            get
            {
                if (RowRecord.Length <= pos || pos < 0 || string.IsNullOrEmpty(fieldname)) return string.Empty;
                return ((DataRowView)RowRecord[pos])[fieldname].ToString();
            }
        }

        public string this[string fieldname]
        {
            get
            {
                if (this.ReadPointer.CurSer >= 0 && this.ReadPointer.CurSer < this.RowRecord.Length)
                {
                    if (string.IsNullOrEmpty(fieldname)) return string.Empty;
                    return ((DataRowView)RowRecord[this.ReadPointer.CurSer])[fieldname].ToString();
                }
                return string.Empty;
            }
        }


        public object this[string fieldname,bool EmptyIsNull]
        {
            get
            {
                if (this.ReadPointer.CurSer >= 0 && this.ReadPointer.CurSer < this.RowRecord.Length)
                {
                    if (string.IsNullOrEmpty(fieldname)) return new object();
                    if (((DataRowView)RowRecord[this.ReadPointer.CurSer])[fieldname].ToString().Equals(string.Empty)&& EmptyIsNull)
                        return null;
                    else
                        return ((DataRowView)RowRecord[this.ReadPointer.CurSer])[fieldname];
                }
                return new object();
            }
        }
        #endregion

        public List<DsExpression> SelectExpressions = new List<DsExpression>();
        public List<DsExpression> UpdateExpressions = new List<DsExpression>();

        #region ReadCurrent
        protected class ReadCurrent
        {
            public int CurSer = 0;
            public bool Reading = false;
            public ReadCurrent() { }
            public void Reset()
            {
                this.CurSer = 0;
                this.Reading = false;
            }
        }
        #endregion

        #region Parameters
        public DataSet Ds = null;
        public string TableName = string.Empty;
        public List<DsExpression> ExpressionList = new List<DsExpression>();
        protected ReadCurrent ReadPointer = new ReadCurrent();
        #endregion

        protected IDSQuery(DataSet x_oDs, string x_sTableName)
        {
            this.Ds = x_oDs;
            this.TableName = x_sTableName;
        }

        public static IDSQuery CreateDsCriteria(DataSet x_oDs, string x_sTableName)
        {
            return new IDSQuery(x_oDs, x_sTableName);
        }

        public IDSQuery DeepClone()
        {
            IDSQuery IDSQuery_Clone = new IDSQuery(this.Ds, this.TableName);
            IDSQuery_Clone.SelectExpressions = this.SelectExpressions;
            IDSQuery_Clone.ReadPointer = this.ReadPointer;
            return IDSQuery_Clone;
        }

        protected List<DataRowView> DataSetFindRows(string x_sRowFilter, string x_sSort)
        {
            DataView _oCustView = new DataView();
            List<DataRowView> _oFoundRows = new List<DataRowView>();
            if (this.Ds == null) return _oFoundRows;
            if (!string.IsNullOrEmpty(this.TableName) && this.Ds.Tables.Contains(this.TableName))
                _oCustView = new DataView(this.Ds.Tables[this.TableName], x_sRowFilter, x_sSort, DataViewRowState.CurrentRows);
            else if (this.Ds.Tables.Count > 0)
                _oCustView = new DataView(this.Ds.Tables[0], x_sRowFilter, x_sSort, DataViewRowState.CurrentRows);

            if (this.Ds.Tables.Count > 0)
            {
                foreach (DataRowView _oRows in _oCustView)
                {
                    _oFoundRows.Add(_oRows);
                }
            }
            return _oFoundRows;
        }

        protected DataRowView[] ToDataRowView()
        {
            string _sRowFilter = string.Empty;
            string _sSort = string.Empty;
            List<DataRowView> _oFoundRows = new List<DataRowView>();
            if (this.Ds == null) return _oFoundRows.ToArray();
            for (int i = 0; i < this.SelectExpressions.Count; i++)
            {
                if (!string.IsNullOrEmpty(_sRowFilter)) { _sRowFilter += " AND "; }
                if (!string.IsNullOrEmpty(_sSort)) { _sSort += ","; }
                _sRowFilter += this.SelectExpressions[i].Expression;
                _sSort += this.SelectExpressions[i].FieldName;
            }
            DataView _oCustView = new DataView();
            if (!string.IsNullOrEmpty(this.TableName) && this.Ds.Tables.Contains(this.TableName))
                _oCustView = new DataView(this.Ds.Tables[this.TableName], _sRowFilter, _sSort, DataViewRowState.CurrentRows);
            else if (this.Ds.Tables.Count > 0)
                _oCustView = new DataView(this.Ds.Tables[0], _sRowFilter, _sSort, DataViewRowState.CurrentRows);

            if (this.Ds.Tables.Count > 0)
            {
                foreach (DataRowView _oRows in _oCustView)
                {
                    _oFoundRows.Add(_oRows);
                }
            }

            return _oFoundRows.ToArray();
        }

        public DataSet ToDataSet()
        {
            return this.Ds;
        }

        public IDSQuery Add(DsExpression x_oDsExpression)
        {
            SelectExpressions.Add(x_oDsExpression);
            return this;
        }

        public IDSQuery Set(DsExpression x_oDsExpression)
        {
            UpdateExpressions.Add(x_oDsExpression);
            return this;
        }

        public int Count()
        {
            return this.RowRecord.Length;
        }

        public bool Read()
        {
            if (this.RowRecord == null) return false;
            if (this.ReadPointer.CurSer < this.RowRecord.Length)
            {
                if (this.ReadPointer.Reading) this.ReadPointer.CurSer += 1;
                if (!this.ReadPointer.Reading) this.ReadPointer.Reading = true;
                if (this.ReadPointer.CurSer == this.RowRecord.Length) return false;
                return true;
            }
            return false;
        }

        public bool Save()
        {
            bool _bResult = true;
            string _sSort = string.Empty;
            if (this.Ds == null) return false;
            List<object> _oValues = new List<object>();
            for (int i = 0; i < this.SelectExpressions.Count; i++)
            {
                if (!string.IsNullOrEmpty(_sSort)) { _sSort += ","; }
                _sSort += this.SelectExpressions[i].FieldName;
                _oValues.Add(this.SelectExpressions[i].Value);
            }
            DataView _oCustView = new DataView();
            if (!string.IsNullOrEmpty(this.TableName) && this.Ds.Tables.Contains(this.TableName))
                _oCustView = new DataView(this.Ds.Tables[this.TableName], "", _sSort, DataViewRowState.CurrentRows);
            else if (this.Ds.Tables.Count > 0)
                _oCustView = new DataView(this.Ds.Tables[0], "", _sSort, DataViewRowState.CurrentRows);
            if (this.Ds.Tables.Count > 0)
            {
                DataRowView[] _oDataRowView = _oCustView.FindRows(_oValues.ToArray());
                foreach (DataRowView _oRows in _oDataRowView)
                {
                    for (int i = 0; i < UpdateExpressions.Count; i++)
                    {
                        UpdateDataRowView(_oCustView, _oRows, UpdateExpressions[i].FieldName, UpdateExpressions[i].Value);
                    }
                }
            }
            else
                return false;

            return _bResult;
        }

        public bool Delete()
        {

            bool _bResult = true;
            string _sRowFilter = string.Empty;
            string _sSort = string.Empty;
            if (this.Ds == null) return false;
            for (int i = 0; i < this.SelectExpressions.Count; i++)
            {
                if (!string.IsNullOrEmpty(_sRowFilter)) { _sRowFilter += " AND "; }
                if (!string.IsNullOrEmpty(_sSort)) { _sSort += ","; }
                _sRowFilter += this.SelectExpressions[i].Expression;
                _sSort += this.SelectExpressions[i].FieldName;
            }
            DataView _oCustView = new DataView();
            if (!string.IsNullOrEmpty(this.TableName) && this.Ds.Tables.Contains(this.TableName))
                _oCustView = new DataView(this.Ds.Tables[this.TableName], _sRowFilter, _sSort, DataViewRowState.CurrentRows);
            else if (this.Ds.Tables.Count > 0)
                _oCustView = new DataView(this.Ds.Tables[0], _sRowFilter, _sSort, DataViewRowState.CurrentRows);

            if (this.Ds.Tables.Count > 0)
            {
                foreach (DataRowView _oRows in _oCustView)
                {
                    _oRows.Delete();
                }
            }
            else
                return false;

            return true;
        }
        public IDSQuery Reset()
        {
            this.ReadPointer.CurSer = 0;
            this.ReadPointer.Reading = false;
            this.SelectExpressions = new List<DsExpression>();
            return this;
        }

        public IDSQuery Close()
        {
            this.Ds = null;
            this.TableName = string.Empty;
            this.SelectExpressions = new List<DsExpression>();
            this.RowRecord = null;
            this.ReadPointer.Reset();
            return this;
        }

        protected bool IsNullorEmpty(object x_oFieldValue)
        {
            if (x_oFieldValue == null) return true;
            if (x_oFieldValue is string)
            {
                string _sTempValue = (string)x_oFieldValue;
                if (string.IsNullOrEmpty(_sTempValue)) return true;
            }
            return false;
        }

        public bool UpdateDataRowView(DataView x_oDataView, DataRowView x_oDataRowView, string x_sFieldName, object x_oFieldValue)
        {
            bool _bResult = true;

            try
            {

                string _sDataType = x_oDataView.Table.Columns[x_sFieldName].DataType.Name;
                switch (_sDataType)
                {
                    case "Int32":
                        #region Int Value
                        if (!IsNullorEmpty(x_oFieldValue))
                        {
                            x_oDataRowView[x_sFieldName] = Convert.DBNull;
                        }
                        else
                        {
                            if (x_oFieldValue is int)
                            {
                                x_oDataRowView[x_sFieldName] = (int)x_oFieldValue;
                            }
                            else
                            {
                                if (x_oFieldValue is string)
                                {
                                    int _dTempValue;
                                    if (int.TryParse(x_oFieldValue.ToString(), out _dTempValue))
                                    {
                                        x_oDataRowView[x_sFieldName] = _dTempValue;
                                    }
                                    else
                                    {
                                        x_oDataRowView[x_sFieldName] = Convert.ToInt32(x_oFieldValue);
                                    }
                                }
                                else
                                {
                                    x_oDataRowView[x_sFieldName] = Convert.ToInt32(x_oFieldValue);
                                }
                            }
                        }
                        #endregion
                        break;

                    case "Double":
                        #region Double Value
                        if (IsNullorEmpty(x_oFieldValue))
                        {
                            x_oDataRowView[x_sFieldName] = Convert.DBNull;
                        }
                        else
                        {
                            if (x_oFieldValue is double)
                            {
                                x_oDataRowView[x_sFieldName] = (double)x_oFieldValue;
                            }
                            else
                            {
                                if (x_oFieldValue is string)
                                {
                                    double _dTempValue;
                                    if (double.TryParse(x_oFieldValue.ToString(), out _dTempValue))
                                    {
                                        x_oDataRowView[x_sFieldName] = _dTempValue;
                                    }
                                    else
                                    {
                                        x_oDataRowView[x_sFieldName] = Convert.ToDateTime(x_oFieldValue);
                                    }
                                }
                                else
                                {
                                    x_oDataRowView[x_sFieldName] = Convert.ToDateTime(x_oFieldValue);
                                }
                            }
                        }
                        #endregion
                        break;

                    case "String":
                        #region String Value
                        if (IsNullorEmpty(x_oFieldValue))
                        {
                            x_oDataRowView[x_sFieldName] = Convert.DBNull;
                        }
                        else
                        {
                            x_oDataRowView[x_sFieldName] = ((string)x_oFieldValue).Trim();
                        }
                        #endregion
                        break;

                    case "DateTime":
                        #region Datetime Value
                        if (IsNullorEmpty(x_oFieldValue))
                        {
                            x_oDataRowView[x_sFieldName] = Convert.DBNull;
                        }
                        else
                        {
                            if (x_oFieldValue is DateTime)
                            {
                                x_oDataRowView[x_sFieldName] = Convert.ToDateTime(x_oFieldValue);
                            }
                            else
                            {

                                if (x_oFieldValue is string)
                                {
                                    DateTime _oTempDate;
                                    if (DateTime.TryParse(x_oFieldValue.ToString(), out _oTempDate))
                                    {
                                        x_oDataRowView[x_sFieldName] = _oTempDate;
                                    }
                                    else
                                    {
                                        x_oDataRowView[x_sFieldName] = Convert.ToDateTime(x_oFieldValue);
                                    }
                                }
                                else
                                {
                                    x_oDataRowView[x_sFieldName] = Convert.ToDateTime(x_oFieldValue);
                                }
                            }
                        }
                        #endregion
                        break;
                }
            }
            catch
            {
                _bResult = false;
            }

            return _bResult;
        }

    }
}
