using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2009-06-18>
///-- Description:	<Description,Class :VasFilterObjEntity, Data Entity>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class VasFilterObjEntity
    {
        protected string n_sNormal_rebate_type = string.Empty;
        #region Normal_rebate_type
        public virtual string Normal_rebate_type
        {
            get
            {
                return this.n_sNormal_rebate_type;
            }
            set
            {
                this.n_sNormal_rebate_type = value;
            }
        }
        #endregion Normal_rebate_type

        protected string n_sBundle_name = string.Empty;
        #region Bundle_name
        public virtual string Bundle_name
        {
            get
            {
                return this.n_sBundle_name;
            }
            set
            {
                this.n_sBundle_name = value;
            }
        }
        #endregion Bundle_name

        protected string n_sHs_model = string.Empty;
        #region Hs_model
        public virtual string Hs_model
        {
            get
            {
                return this.n_sHs_model;
            }
            set
            {
                this.n_sHs_model = value;
            }
        }
        #endregion Hs_model

        protected string n_sRate_plan = string.Empty;
        #region Rate_plan
        public virtual string Rate_plan
        {
            get
            {
                return this.n_sRate_plan;
            }
            set
            {
                this.n_sRate_plan = value;
            }
        }
        #endregion Rate_plan

        protected string n_sProgram = string.Empty;
        #region Program
        public virtual string Program
        {
            get
            {
                return this.n_sProgram;
            }
            set
            {
                this.n_sProgram = value;
            }
        }
        #endregion Program

        protected string n_sIssue_type = string.Empty;
        #region Issue_type
        public virtual string Issue_type
        {
            get
            {
                return this.n_sIssue_type;
            }
            set
            {
                this.n_sIssue_type = value;
            }
        }
        #endregion Issue_type

        protected string n_sVas_field = string.Empty;
        #region Vas_field
        public virtual string Vas_field
        {
            get
            {
                return this.n_sVas_field;
            }
            set
            {
                this.n_sVas_field = value;
            }
        }
        #endregion Vas_field

    }
}
