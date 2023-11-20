using System;
using System.Data;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
///-- Create date: <Create Date 2010-05-17>
///-- Description:	<Description,Table :[BankCode], Information layer>
///-- =============================================
namespace PCCW.RWL.CORE
{

    /// <summary>
    /// Summary description for table [BankCode] Information layer
    /// </summary>
    public abstract class BankCodeInfoDLL
    {


        #region Parameter
        private TableObj n_oTableSet = new TableObj();
        public bool n_bViewAll = false;
        public string n_sPrefix = Configurator.MSSQLTablePrefix;
        #endregion

        #region CreateInfoInstanceObject
        public static BankCodeInfo CreateInfoInstanceObject()
        {
            return new BankCodeInfo();
        }
        #endregion
        #region Constructor

        public BankCodeInfoDLL()
        {
            Init();
        }
        ~BankCodeInfoDLL()
        {
            this.Release();
        }
        #endregion


        #region Init
        public void Init()
        {

            string _sStrFldName;
            n_oTableSet.TableName = BankCode.Para.TableName();
            n_oTableSet.DefaultFilter = String.Empty;
            n_oTableSet.GroupBy = String.Empty;
            n_oTableSet.Having = String.Empty;
            n_oTableSet.DefaultOrderBy = String.Empty;

            // [bank_code] Field
            _sStrFldName = BankCode.Para.bank_code;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[bank_code]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "bank_code";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[bank_code]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "bank_code";
            n_oTableSet.Fields(_sStrFldName).AliasName = "bank_code";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "bank_code";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 200;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";


            // [bank_name] Field
            _sStrFldName = BankCode.Para.bank_name;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[bank_name]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "bank_name";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[bank_name]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "bank_name";
            n_oTableSet.Fields(_sStrFldName).AliasName = "bank_name";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "bank_name";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 200;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "varchar";


            // [mid] Field
            _sStrFldName = BankCode.Para.mid;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = true;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = true;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = true;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = true;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[mid]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<int>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "mid";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[mid]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "mid";
            n_oTableSet.Fields(_sStrFldName).AliasName = "mid";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "mid";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = false;
            n_oTableSet.Fields(_sStrFldName).IsEdit = false;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = false;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = false;
            n_oTableSet.Fields(_sStrFldName).Size = 0;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "int";


            // [installment_period] Field
            _sStrFldName = BankCode.Para.installment_period;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[installment_period]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "installment_period";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[installment_period]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "installment_period";
            n_oTableSet.Fields(_sStrFldName).AliasName = "installment_period";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "installment_period";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 250;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";


            // [active] Field
            _sStrFldName = BankCode.Para.active;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[active]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "global::System.Nullable<bool>";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "active";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[active]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "active";
            n_oTableSet.Fields(_sStrFldName).AliasName = "active";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "active";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 0;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "bit";


            // [min_amount] Field
            _sStrFldName = BankCode.Para.min_amount;
            n_oTableSet.Add(_sStrFldName);
            n_oTableSet.Fields(_sStrFldName).IsAutoIncrement = false;
            n_oTableSet.Fields(_sStrFldName).IsIdentityKey = false;
            n_oTableSet.Fields(_sStrFldName).IsPrimaryKey = false;
            n_oTableSet.Fields(_sStrFldName).IsUniqueKey = false;
            n_oTableSet.Fields(_sStrFldName).FieldName = "[min_amount]";
            n_oTableSet.Fields(_sStrFldName).FieldType = "string";
            n_oTableSet.Fields(_sStrFldName).FieldVar = "min_amount";
            n_oTableSet.Fields(_sStrFldName).FieldUploadPath = "";
            n_oTableSet.Fields(_sStrFldName).SortName = "[min_amount]";
            n_oTableSet.Fields(_sStrFldName).SortParm = "min_amount";
            n_oTableSet.Fields(_sStrFldName).AliasName = "min_amount";
            n_oTableSet.Fields(_sStrFldName).ParameterName = "min_amount";
            n_oTableSet.Fields(_sStrFldName).QuoteStart = "";
            n_oTableSet.Fields(_sStrFldName).QuoteEnd = "";
            n_oTableSet.Fields(_sStrFldName).IsList = true;
            n_oTableSet.Fields(_sStrFldName).IsView = true;
            n_oTableSet.Fields(_sStrFldName).IsEdit = true;
            n_oTableSet.Fields(_sStrFldName).IsDelete = true;
            n_oTableSet.Fields(_sStrFldName).IsAdd = true;
            n_oTableSet.Fields(_sStrFldName).IsSearch = true;
            n_oTableSet.Fields(_sStrFldName).IsRegister = false;
            n_oTableSet.Fields(_sStrFldName).IsNullable = true;
            n_oTableSet.Fields(_sStrFldName).Size = 10;
            n_oTableSet.Fields(_sStrFldName).SqlDataType = "nvarchar";

        }
        #endregion


        #region Get & Set

        #region GetViewAll
        public bool GetViewAll() { return n_bViewAll; }
        #endregion GetViewAll


        #region SetViewAll
        public void SetViewAll(bool value) { n_bViewAll = value; }
        #endregion SetViewAll


        #region GetTableSet
        public TableObj GetTableSet() { return n_oTableSet; }
        #endregion GetTableSet


        #region SetTableSet
        public void SetTableSet(TableObj value) { n_oTableSet = value; }
        #endregion SetTableSet

        #region GetTableInfo
        public Field GetBank_codeTable()
        {
            return n_oTableSet.Fields(BankCode.Para.bank_code);
        }
        public Field GetBank_nameTable()
        {
            return n_oTableSet.Fields(BankCode.Para.bank_name);
        }
        public Field GetMidTable()
        {
            return n_oTableSet.Fields(BankCode.Para.mid);
        }
        public Field GetInstallment_periodTable()
        {
            return n_oTableSet.Fields(BankCode.Para.installment_period);
        }
        public Field GetActiveTable()
        {
            return n_oTableSet.Fields(BankCode.Para.active);
        }
        public Field GetMin_amountTable()
        {
            return n_oTableSet.Fields(BankCode.Para.min_amount);
        }

        public Field Fields(string x_sColumn)
        {
            return n_oTableSet.Fields(x_sColumn);
        }
        #endregion GetTableInfo
        #endregion
        #region
        public void Release() { }
        #endregion
    }
}

