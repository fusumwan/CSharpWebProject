using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEURON.WEB.UI.HTMLCONTROL
{
    public interface NHtmlContainerControl
    {
        string Id { get; set; }
        string ToInnerHtml();
    }
}
