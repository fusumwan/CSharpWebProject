using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using System.Configuration;
using System.Xml;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-18>
///-- Description:	<Description,Class :VasFilterObj, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class VasFilterObj : VasFilterObjEntity, IVasFilterObjEntityRepository<VasFilterObj>, IDisposable
    {

        #region Constructor & Destructor
        public VasFilterObj() { }

        public VasFilterObj(string x_sNormal_rebate_type, string x_sBundle_name, string x_sRate_plan, string x_sProgram, string x_sVas_field,string x_sHs_model,string x_sIssue_type)
        {
            Normal_rebate_type = x_sNormal_rebate_type;
            Bundle_name = x_sBundle_name;
            Rate_plan = x_sRate_plan;
            Program = x_sProgram;
            Vas_field = x_sVas_field;
            Hs_model = x_sHs_model;
            Issue_type = x_sIssue_type;
        }

        ~VasFilterObj() { }

        #endregion Constructor & Destructor

        #region Get & Set
        public string GetNormal_rebate_type() { return this.Normal_rebate_type; }
        public string GetBundle_name() { return this.Bundle_name; }
        public string GetRate_plan() { return this.Rate_plan; }
        public string GetProgram() { return this.Program; }
        public string GetVas_field() { return this.Vas_field; }
        public string GetHs_model() { return this.Hs_model; }
        public string GetIssue_type() { return this.Issue_type; }
        public bool SetNormal_rebate_type(string value)
        {
            this.Normal_rebate_type = value;
            return true;
        }

        public bool SetIssue_type(string value)
        {
            this.Issue_type = value;
            return true;
        }
        public bool SetBundle_name(string value)
        {
            this.Bundle_name = value;
            return true;
        }
        public bool SetRate_plan(string value)
        {
            this.Rate_plan = value;
            return true;
        }

        public bool SetProgram(string value)
        {
            this.Program = value;
            return true;
        }

        public bool SetVas_field(string value)
        {
            this.Vas_field = value;
            return true;
        }

        public bool SetHs_model(string value)
        {
            this.Hs_model = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(VasFilterObj x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.Normal_rebate_type.Equals(x_oObj.Normal_rebate_type)) { return false; }
            if (!this.Bundle_name.Equals(x_oObj.Bundle_name)) { return false; }
            if (!this.Rate_plan.Equals(x_oObj.Rate_plan)) { return false; }
            if (!this.Program.Equals(x_oObj.Program)) { return false; }
            if (!this.Vas_field.Equals(x_oObj.Vas_field)) { return false; }
            if (!this.Hs_model.Equals(x_oObj.Hs_model)) { return false; }
            if (!this.Issue_type.Equals(x_oObj.Issue_type)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.Normal_rebate_type= string.Empty;
            this.Bundle_name = string.Empty;
            this.Rate_plan = string.Empty;
            this.Program = string.Empty;
            this.Normal_rebate_type = string.Empty;
            this.Vas_field = string.Empty;
            this.Issue_type = string.Empty;
        }
        #endregion Release


        #region DeepClone
        public VasFilterObj DeepClone()
        {
            VasFilterObj VasFilterObj_Clone = new VasFilterObj();
            VasFilterObj_Clone.SetNormal_rebate_type(this.Normal_rebate_type);
            VasFilterObj_Clone.SetBundle_name(this.Bundle_name);
            VasFilterObj_Clone.SetRate_plan(this.Rate_plan);
            VasFilterObj_Clone.SetProgram(this.Program);
            VasFilterObj_Clone.SetVas_field(this.Vas_field);
            VasFilterObj_Clone.SetIssue_type(this.Issue_type);
            return VasFilterObj_Clone;
        }
        #endregion Clone

        void global::System.IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }

    }
}
