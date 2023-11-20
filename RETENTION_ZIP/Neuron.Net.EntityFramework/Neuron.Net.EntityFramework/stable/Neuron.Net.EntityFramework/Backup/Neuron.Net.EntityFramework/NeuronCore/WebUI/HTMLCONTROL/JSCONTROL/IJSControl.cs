using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    public interface IJSControl
    {
        bool RunRegistorJS { get; set; }
        string ToScript();
        string ToScript(bool x_bClearHist);
        string ToScript(bool x_bClearHist,bool x_bIncludeScript);
    }
}
