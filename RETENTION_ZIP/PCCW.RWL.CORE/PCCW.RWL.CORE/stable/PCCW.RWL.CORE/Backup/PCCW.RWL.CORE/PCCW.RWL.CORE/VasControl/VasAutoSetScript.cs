using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
using NEURON.ENTITY.FRAMEWORK.STOCK;
using PCCW.RWL.CORE;
using System.Collections.Generic;

///-- =============================================
///-- Author:		<Author,Philip SW>
///-- Create date: <Create Date 2010-06-04>
///-- Description:	<Description,Class :VasAutoSetScript, Data Access Object Control>
///-- =============================================
namespace PCCW.RWL.CORE
{

    public class VasAutoSetScript : IDisposable
    {
        
        protected Dictionary<string,string> n_oVasSetScript = new Dictionary<string,string>();
        #region VasSetScript
        public Dictionary<string,string> VasSetScript
        {
            get
            {
                if (this.n_oVasSetScript.Count==0)
                {
                    InitVasSetScript();
                }

                return this.n_oVasSetScript;
            }
            set
            {
                this.n_oVasSetScript = value;
            }
        }
        #endregion VasSetScript

        #region Para
        public class Para
        {
            public const string VasSetScript = "VasSetScript";
        }
        #endregion Para

        #region Instance
        private static VasAutoSetScript instance;
        #endregion


        #region Constructor & Destructor
        protected VasAutoSetScript()
        {
            RWLFramework.DataBaseConfigSetting();
            InitVasSetScript();
        }

        public void InitVasSetScript()
        {
            this.n_oVasSetScript.Clear();
            string _sQuery = "SELECT  DISTINCT issue_type FROM BusinessVasDefaultSet WHERE issue_type!='' AND issue_type IS NOT NULL";
            SqlDataReader _oDr = SYSConn<MSSQLConnect>.Connect().GetSearch(_sQuery);
            while (_oDr.Read())
            {
                string _sIssue_type = Func.FR(_oDr[BusinessVasDefaultSet.Para.issue_type]);
                if (!n_oVasSetScript.ContainsKey(_sIssue_type))
                {
                    string _sScript = GenVasAutoSelectionByIssueType(_sIssue_type);
                    this.n_oVasSetScript.Add(_sIssue_type, _sScript);
                }
            }
            _oDr.Close();
            _oDr.Dispose();
        }

        public string GenVasAutoSelectionByIssueType(string x_sIssueType)
        {
            StringBuilder _oVasAutoSet = new StringBuilder();
            _oVasAutoSet.AppendLine("<script>");
            _oVasAutoSet.AppendLine("function CVID(id, val) {");
            _oVasAutoSet.AppendLine("if (document.getElementById(id) == undefined) { return false; }");
            _oVasAutoSet.AppendLine("if (document.getElementById(id).value == val) {");
            _oVasAutoSet.AppendLine("return true;");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("else {");
            _oVasAutoSet.AppendLine("return false;");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("function VasSet(vas1, display1, enabled1, value1, vas2, display2, enabled2, value2) {");
            _oVasAutoSet.AppendLine("if (document.getElementById(vas1) != undefined && document.getElementById(vas1+'2')!=undefined) {");
            _oVasAutoSet.AppendLine("if (document.getElementById(vas1+'2').style.display!='none'){");

            _oVasAutoSet.AppendLine("if (display1 != null && display1!='') {");
            _oVasAutoSet.AppendLine("document.getElementById(vas1).style.display = display1;");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine(" if ((enabled1 != null && enabled1 != '') || (enabled1==true || enabled1==false)) {");
            _oVasAutoSet.AppendLine("document.getElementById(vas1).disabled = !enabled1;");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("if (value1!=null){");
            _oVasAutoSet.AppendLine("document.getElementById(vas1).value = value1;");
            _oVasAutoSet.AppendLine("}");


            _oVasAutoSet.AppendLine("if(document.getElementById(vas2)!=undefined){");
            _oVasAutoSet.AppendLine("if (display2 != null && display2!='') {");
            _oVasAutoSet.AppendLine("document.getElementById(vas2).style.display = display2;");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("if ((enabled2 != null && enabled2 != '') || (enabled2==true || enabled2==false)) {");
            _oVasAutoSet.AppendLine("document.getElementById(vas2).disabled = !enabled2;");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("if (value2!=null){");
            _oVasAutoSet.AppendLine("document.getElementById(vas2).value = value2;");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("}");

            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("}");
            _oVasAutoSet.AppendLine("}");


            StringBuilder _oRunSetVasScript = new StringBuilder();
            _oRunSetVasScript.AppendLine("function VasAutoDefaultSet(){");
            BusinessVasDefaultSetEntity[] _oBusinessVasDefaultSetEntityArr = BusinessVasDefaultSetRepository.GetArrayObj(SYSConn<MSSQLConnect>.Connect(), "issue_type='"+x_sIssueType+"'  or (issue_type is null or issue_type='')  ", null, " mid desc");

            if (_oBusinessVasDefaultSetEntityArr != null)
            {
                for (int i = 0; i < _oBusinessVasDefaultSetEntityArr.Length; i++)
                {
                    if (_oBusinessVasDefaultSetEntityArr[i].GetActive() == true)
                    {
                        StringBuilder _oAnd = new StringBuilder();
                        if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].program))
                        {
                            if (!_oAnd.ToString().Equals(string.Empty)) { _oAnd.Append(" && "); }
                            _oAnd.Append(" CVID('program','" + _oBusinessVasDefaultSetEntityArr[i].program + "') ");
                        }

                        if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].rate_plan))
                        {
                            if (!_oAnd.ToString().Equals(string.Empty)) { _oAnd.Append(" && "); }
                            _oAnd.Append(" CVID('rate_plan','" + _oBusinessVasDefaultSetEntityArr[i].rate_plan + "') ");
                        }

                        if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].con_per))
                        {
                            if (!_oAnd.ToString().Equals(string.Empty)) { _oAnd.Append(" && "); }
                            _oAnd.Append(" CVID('con_per','" + _oBusinessVasDefaultSetEntityArr[i].con_per + "') ");
                        }

                        if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].hs_model))
                        {
                            if (!_oAnd.ToString().Equals(string.Empty)) { _oAnd.Append(" && "); }
                            _oAnd.Append(" CVID('hs_model','" + _oBusinessVasDefaultSetEntityArr[i].hs_model + "') ");
                        }

                        if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].bundle_name))
                        {
                            if (!_oAnd.ToString().Equals(string.Empty)) { _oAnd.Append(" && "); }
                            _oAnd.Append(" CVID('bundle_name','" + _oBusinessVasDefaultSetEntityArr[i].bundle_name + "') ");
                        }

                        if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].trade_field))
                        {
                            if (!_oAnd.ToString().Equals(string.Empty)) { _oAnd.Append(" && "); }
                            _oAnd.Append(" CVID('trade_field','" + _oBusinessVasDefaultSetEntityArr[i].trade_field + "') ");
                        }

                        if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].issue_type))
                        {
                            if (!_oAnd.ToString().Equals(string.Empty)) { _oAnd.Append(" && "); }
                            _oAnd.Append(" CVID('issue_type','" + _oBusinessVasDefaultSetEntityArr[i].issue_type + "') ");
                        }

                        if (!_oAnd.ToString().Equals(string.Empty))
                        {
                            StringBuilder _oChkOffer = new StringBuilder();
                            _oChkOffer.AppendLine("if(" + _oAnd.ToString() + "){");

                            StringBuilder _oVasSet = new StringBuilder();
                            _oVasSet.Append("VasSet(");

                            if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].vas1))
                            {
                                _oVasSet.Append("'" + _oBusinessVasDefaultSetEntityArr[i].vas1 + "',");
                            }
                            else
                            {
                                _oVasSet.Append("'',");
                            }
                            if (_oBusinessVasDefaultSetEntityArr[i].display1 == null)
                            {
                                _oVasSet.Append("'',");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].display1 == true)
                            {
                                _oVasSet.Append("'inline',");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].display1 == false)
                            {
                                _oVasSet.Append("'none',");
                            }
                            else
                            {
                                _oVasSet.Append("'',");
                            }

                            if (_oBusinessVasDefaultSetEntityArr[i].enabled1 == null)
                            {
                                _oVasSet.Append("'',");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].enabled1 == true)
                            {
                                _oVasSet.Append("true,");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].enabled1 == false)
                            {
                                _oVasSet.Append("false,");
                            }
                            else
                            {
                                _oVasSet.Append("'',");
                            }

                            if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].value1))
                            {
                                _oVasSet.Append("'" + _oBusinessVasDefaultSetEntityArr[i].value1 + "',");
                            }
                            else
                            {
                                _oVasSet.Append("'',");
                            }

                            if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].vas2))
                            {
                                _oVasSet.Append("'" + _oBusinessVasDefaultSetEntityArr[i].vas2 + "',");
                            }
                            else
                            {
                                _oVasSet.Append("'',");
                            }

                            if (_oBusinessVasDefaultSetEntityArr[i].display2 == null)
                            {
                                _oVasSet.Append("'',");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].display2 == true)
                            {
                                _oVasSet.Append("'inline',");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].display2 == false)
                            {
                                _oVasSet.Append("'none',");
                            }
                            else
                            {
                                _oVasSet.Append("'',");
                            }

                            if (_oBusinessVasDefaultSetEntityArr[i].enabled2 == null)
                            {
                                _oVasSet.Append("'',");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].enabled2 == true)
                            {
                                _oVasSet.Append("true,");
                            }
                            else if (_oBusinessVasDefaultSetEntityArr[i].enabled2 == false)
                            {
                                _oVasSet.Append("false,");
                            }
                            else
                            {
                                _oVasSet.Append("'',");
                            }

                            if (!string.IsNullOrEmpty(_oBusinessVasDefaultSetEntityArr[i].value2))
                            {
                                _oVasSet.Append("'" + _oBusinessVasDefaultSetEntityArr[i].value2 + "'");
                            }
                            else
                            {
                                _oVasSet.Append("''");
                            }
                            _oVasSet.Append(")");
                            _oChkOffer.AppendLine(_oVasSet.ToString());
                            _oChkOffer.AppendLine("}");
                            _oRunSetVasScript.AppendLine(_oChkOffer.ToString());
                        }
                    }
                }
            }
            _oRunSetVasScript.AppendLine("}");
            _oVasAutoSet.AppendLine(_oRunSetVasScript.ToString());
            _oVasAutoSet.AppendLine("</script>");
            return _oVasAutoSet.ToString();
        }

        protected VasAutoSetScript(Dictionary<string,string> x_sVasSetScript)
        {
            VasSetScript = x_sVasSetScript;
        }

        public static VasAutoSetScript Instance()
        {
            if (instance == null)
                instance = new VasAutoSetScript();
            return instance;
        }

        public static VasAutoSetScript Instance(Dictionary<string,string> x_oVasSetScript)
        {
            if (instance == null)
                instance = new VasAutoSetScript(x_oVasSetScript);
            return instance;
        }

        ~VasAutoSetScript() { }

        #endregion Constructor & Destructor

        public void Reload()
        {
            instance = new VasAutoSetScript();
        }

        #region Get & Set
        public Dictionary<string,string> GetVasSetScript() { return this.VasSetScript; }

        public bool SetVasSetScript(Dictionary<string,string> value)
        {
            this.VasSetScript = value;
            return true;
        }
        #endregion


        #region Equals
        public bool Equals(VasAutoSetScript x_oObj)
        {
            if (x_oObj == null) { return false; }
            if (!this.VasSetScript.Equals(x_oObj.VasSetScript)) { return false; }
            return true;
        }
        #endregion Equals


        #region Release
        public void Release()
        {
            this.VasSetScript = new Dictionary<string,string>();
        }
        #endregion Release


        #region Clone
        public VasAutoSetScript DeepClone()
        {
            VasAutoSetScript VasAutoSetScript_Clone = new VasAutoSetScript();
            VasAutoSetScript_Clone.SetVasSetScript(this.VasSetScript);
            return VasAutoSetScript_Clone;
        }
        #endregion Clone

        void IDisposable.Dispose()
        {
            this.Dispose();
        }
        public void Dispose()
        {
        }
    }
}
