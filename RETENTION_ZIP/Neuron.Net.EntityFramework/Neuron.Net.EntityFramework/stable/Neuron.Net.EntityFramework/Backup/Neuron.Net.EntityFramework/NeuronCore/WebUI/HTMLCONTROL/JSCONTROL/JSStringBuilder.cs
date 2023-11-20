using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    public class JSStringBuilder
    {
        StringBuilder n_oJSScript = new StringBuilder();
        public void Append(string x_sScript)
        {
            if (string.IsNullOrEmpty(x_sScript)) return;
            x_sScript = x_sScript.Trim();
            if (x_sScript.Replace("\n", string.Empty).ToString().Trim().Equals(string.Empty)) return;
            if (!string.IsNullOrEmpty(x_sScript))
                n_oJSScript.Append(x_sScript);
        }

        public void AppendLine(string x_sScript)
        {
            if (string.IsNullOrEmpty(x_sScript)) return;
            x_sScript = x_sScript.Trim();
            if (x_sScript.Replace("\n", string.Empty).ToString().Trim().Equals(string.Empty)) return;
            if (!string.IsNullOrEmpty(x_sScript))
                n_oJSScript.AppendLine(x_sScript);
        }

        public string ToString()
        {
            return n_oJSScript.ToString();
        }
    }
}
