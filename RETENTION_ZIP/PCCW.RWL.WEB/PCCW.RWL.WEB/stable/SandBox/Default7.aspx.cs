using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Odbc;
using System.Globalization;
using System.Text;
using PCCW.RWL.CORE;
using PCCW.RWL.CORE.SERIAL;
using PCCW.RWL.CORE.WEBFUNC;
using NEURON.ENTITY.FRAMEWORK;
using NEURON.ENTITY.FRAMEWORK.SESSIONFACTORY;
using NEURON.ENTITY.FRAMEWORK.CONNECT;
public partial class SandBox_Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RWLFramework.DataBaseConfigSetting();
        mrt_no.Value = "66211738";
        ProgramListBindData();
    }

    #region ProgramListBindData
    protected void ProgramListBindData()
    {
        string _sMobileLevelDesc = string.Empty;
        IQueryable<BusinessTradeEntity> _oRwlTradeBaseList = FromRegisterControler.Get_ProgramList(mrt_no.Value.ToString(), ref _sMobileLevelDesc);
        program.Items.Clear();
        program.Items.Add(new ListItem(string.Empty, string.Empty));
        if (_oRwlTradeBaseList.Count<BusinessTradeEntity>() > 0)
        {
            List<string> _oPrograms = _oRwlTradeBaseList.Select(c => c.program).Distinct().ToList();
            for (int i = 0; i < _oPrograms.Count; i++)
            {

                    program.Items.Add(new ListItem(_oPrograms[i].ToString(), _oPrograms[i].ToString()));

            }
        }

        if (!string.IsNullOrEmpty(_sMobileLevelDesc))
        {
            cust_type.Items.Add(new ListItem(_sMobileLevelDesc.Trim(), _sMobileLevelDesc.Trim()));
            cust_type.SelectedValue = _sMobileLevelDesc.Trim();
            cust_type.Enabled = true;
        }
    }
    #endregion

}
