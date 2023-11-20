using System;
using System.Collections;
using NEURON.ENTITY.FRAMEWORK.STOCK;
namespace NEURON.WEB.UI.HTMLCONTROL
{
    public class HtmlControlList : Hashlist
    {
        public new NHtmlContainerControl this[string Key]
        {
            get { return (NHtmlContainerControl)base[Key]; }
            set { base[Key] = value; }
        }

        public new NHtmlContainerControl this[int Index]
        {
            get
            {
                object oTemp = base[Index];
                return (NHtmlContainerControl)oTemp;
            }
        }
        public HtmlControlList()
        {

        }
    }
}
