using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    [Serializable]
    public class RegisterJS
    {
        #region Get Control Style
        public static string GetControlStyleStr(HtmlTextWriterStyle x_oStyle)
        {
            string _sStyleName = string.Empty;
            switch (x_oStyle)
            {
                case HtmlTextWriterStyle.BackgroundColor:
                    _sStyleName = "backgroundColor";
                    break;
                case HtmlTextWriterStyle.BackgroundImage:
                    _sStyleName = "backgroundImage";
                    break;
                case HtmlTextWriterStyle.BorderCollapse:
                    _sStyleName = "borderCollapse";
                    break;
                case HtmlTextWriterStyle.BorderColor:
                    _sStyleName = "borderColor";
                    break;
                case HtmlTextWriterStyle.BorderStyle:
                    _sStyleName = "borderStyle";
                    break;
                case HtmlTextWriterStyle.BorderWidth:
                    _sStyleName = "borderWidth";
                    break;
                case HtmlTextWriterStyle.Color:
                    _sStyleName = "color";
                    break;
                case HtmlTextWriterStyle.Cursor:
                    _sStyleName = "cursor";
                    break;
                case HtmlTextWriterStyle.Direction:
                    _sStyleName = "direction";
                    break;
                case HtmlTextWriterStyle.Display:
                    _sStyleName = "display";
                    break;
                case HtmlTextWriterStyle.Filter:
                    _sStyleName = "filter";
                    break;
                case HtmlTextWriterStyle.FontFamily:
                    _sStyleName = "fontFamily";
                    break;
                case HtmlTextWriterStyle.FontSize:
                    _sStyleName = "fontSize";
                    break;
                case HtmlTextWriterStyle.FontStyle:
                    _sStyleName = "fontStyle";
                    break;
                case HtmlTextWriterStyle.FontVariant:
                    _sStyleName = "fontVariant";
                    break;
                case HtmlTextWriterStyle.FontWeight:
                    _sStyleName = "fontWeight";
                    break;
                case HtmlTextWriterStyle.Height:
                    _sStyleName = "height";
                    break;
                case HtmlTextWriterStyle.Left:
                    _sStyleName = "left";
                    break;
                case HtmlTextWriterStyle.ListStyleImage:
                    _sStyleName = "listStyleImage";
                    break;
                case HtmlTextWriterStyle.ListStyleType:
                    _sStyleName = "listStyleType";
                    break;
                case HtmlTextWriterStyle.Margin:
                    _sStyleName = "margin";
                    break;
                case HtmlTextWriterStyle.MarginBottom:
                    _sStyleName = "marginBottom";
                    break;
                case HtmlTextWriterStyle.MarginLeft:
                    _sStyleName = "marginLeft";
                    break;
                case HtmlTextWriterStyle.MarginRight:
                    _sStyleName = "marginRight";
                    break;
                case HtmlTextWriterStyle.MarginTop:
                    _sStyleName = "marginTop";
                    break;
                case HtmlTextWriterStyle.Overflow:
                    _sStyleName = "overflow";
                    break;
                case HtmlTextWriterStyle.OverflowX:
                    _sStyleName = "overflowX";
                    break;
                case HtmlTextWriterStyle.OverflowY:
                    _sStyleName = "overflowY";
                    break;
                case HtmlTextWriterStyle.Padding:
                    _sStyleName = "padding";
                    break;
                case HtmlTextWriterStyle.PaddingBottom:
                    _sStyleName = "paddingBottom";
                    break;
                case HtmlTextWriterStyle.PaddingLeft:
                    _sStyleName = "paddingLeft";
                    break;
                case HtmlTextWriterStyle.PaddingRight:
                    _sStyleName = "paddingRight";
                    break;
                case HtmlTextWriterStyle.PaddingTop:
                    _sStyleName = "paddingTop";
                    break;
                case HtmlTextWriterStyle.Position:
                    _sStyleName = "position";
                    break;
                case HtmlTextWriterStyle.TextAlign:
                    _sStyleName = "textAlign";
                    break;
                case HtmlTextWriterStyle.TextDecoration:
                    _sStyleName = "textDecoration";
                    break;
                case HtmlTextWriterStyle.TextOverflow:
                    _sStyleName = "textOverflow";
                    break;
                case HtmlTextWriterStyle.Top:
                    _sStyleName = "top";
                    break;
                case HtmlTextWriterStyle.VerticalAlign:
                    _sStyleName = "verticalAlign";
                    break;
                case HtmlTextWriterStyle.Visibility:
                    _sStyleName = "visibility";
                    break;
                case HtmlTextWriterStyle.WhiteSpace:
                    _sStyleName = "whiteSpace";
                    break;
                case HtmlTextWriterStyle.Width:
                    _sStyleName = "width";
                    break;
                case HtmlTextWriterStyle.ZIndex:
                    _sStyleName = "zIndex";
                    break;
            }
            return _sStyleName;
        }
        #endregion

        #region Get Control Attribute
        public static string GetControlAttributeStr(HtmlTextWriterAttribute x_oAtt)
        {
            return RegisterJS.GetControlAttributeMapping(x_oAtt);
        }

        public static string GetControlAttributeStr(string x_sAtt)
        {
            string _sScript = string.Empty;
            switch (x_sAtt.Trim().ToLower())
            {
                case "readonly":
                    _sScript = "readOnly";
                    break;
                case "accesskey":
                    _sScript = "accessKey";
                    break;
                case "appendchild":
                    _sScript = "appendChild";
                    break;
                case "childnodes":
                    _sScript = "childNodes";
                    break;
                case "class":
                    _sScript = "className";
                    break;
                case "defaultchecked":
                    _sScript = "defaultChecked";
                    break;
                case "defaultvalue":
                    _sScript = "defaultValue";
                    break;
                case "dir":
                    _sScript = "dir";
                    break;
                case "disabled":
                    _sScript = "disabled";
                    break;
                case "firstchild":
                    _sScript = "firstChild";
                    break;
                case "id":
                    _sScript = "id";
                    break;
                case "innerhtml":
                    _sScript = "innerHTML";
                    break;
                case "lang":
                    _sScript = "lang";
                    break;
                case "lastchild":
                    _sScript = "lastChild";
                    break;
                case "maxlength":
                    _sScript = "maxLength";
                    break;
                case "name":
                    _sScript = "name";
                    break;
                case "nextsibling":
                    _sScript = "nextSibling";
                    break;
                case "nodename":
                    _sScript = "nodeName";
                    break;
                case "nodetype":
                    _sScript = "nodeType";
                    break;
                case "nodevalue":
                    _sScript = "nodeValue";
                    break;
                case "offsetheight":
                    _sScript = "offsetHeight";
                    break;
                case "offsetleft":
                    _sScript = "offsetLeft";
                    break;
                case "offsetparent":
                    _sScript = "offsetParent";
                    break;
                case "offsettop":
                    _sScript = "offsetTop";
                    break;
                case "offsetwidth":
                    _sScript = "offsetWidth";
                    break;
                case "ownerdocument":
                    _sScript = "ownerDocument";
                    break;
                case "parentnode":
                    _sScript = "parentNode";
                    break;
                case "previoussibling":
                    _sScript = "previousSibling";
                    break;
                case "size":
                    _sScript = "size";
                    break;
                case "src":
                    _sScript = "src";
                    break;
                case "tabIndex":
                    _sScript = "tabIndex";
                    break;
                case "tagname":
                    _sScript = "tagName";
                    break;
                case "title":
                    _sScript = "title";
                    break;
                case "type":
                    _sScript = "type";
                    break;
                case "usemap":
                    _sScript = "useMap";
                    break;
                case "value":
                    _sScript = "value";
                    break;
                case "length":
                    _sScript = "length";
                    break;
                case "multiple":
                    _sScript = "multiple";
                    break;
                case "selectedindex":
                    _sScript = "selectedIndex";
                    break;
                case "options":
                    _sScript = "options";
                    break;
                default:
                    _sScript = x_sAtt.ToString().ToLower().Trim();
                    break;
            }
            return _sScript;
        }

        protected static string GetControlAttributeMapping(HtmlTextWriterAttribute x_oAtt)
        {
            string _sScript = string.Empty;
            switch (x_oAtt)
            {
                case HtmlTextWriterAttribute.Abbr:
                    _sScript = "abbr";
                    break;
                case HtmlTextWriterAttribute.Accesskey:
                    _sScript = "accesskey";
                    break;
                case HtmlTextWriterAttribute.Align:
                    _sScript = "align";
                    break;
                case HtmlTextWriterAttribute.Alt:
                    _sScript = "alt";
                    break;
                case HtmlTextWriterAttribute.AutoComplete:
                    _sScript = "autocomplete";
                    break;
                case HtmlTextWriterAttribute.Axis:
                    _sScript = "axis";
                    break;
                case HtmlTextWriterAttribute.Background:
                    _sScript = "background";
                    break;
                case HtmlTextWriterAttribute.Bgcolor:
                    _sScript = "bgcolor";
                    break;
                case HtmlTextWriterAttribute.Border:
                    _sScript = "border";
                    break;
                case HtmlTextWriterAttribute.Bordercolor:
                    _sScript = "bordercolor";
                    break;
                case HtmlTextWriterAttribute.Cellpadding:
                    _sScript = "cellpadding";
                    break;
                case HtmlTextWriterAttribute.Cellspacing:
                    _sScript = "cellspacing";
                    break;
                case HtmlTextWriterAttribute.Checked:
                    _sScript = "checked";
                    break;
                case HtmlTextWriterAttribute.Class:
                    _sScript = "className";
                    break;
                case HtmlTextWriterAttribute.Cols:
                    _sScript = "cols";
                    break;
                case HtmlTextWriterAttribute.Colspan:
                    _sScript = "colspan";
                    break;
                case HtmlTextWriterAttribute.Content:
                    _sScript = "content";
                    break;
                case HtmlTextWriterAttribute.Coords:
                    _sScript = "coords";
                    break;
                case HtmlTextWriterAttribute.DesignerRegion:
                    _sScript = "designerregion";
                    break;
                case HtmlTextWriterAttribute.Dir:
                    _sScript = "dir";
                    break;
                case HtmlTextWriterAttribute.Disabled:
                    _sScript = "disabled";
                    break;
                case HtmlTextWriterAttribute.For:
                    _sScript = "for";
                    break;
                case HtmlTextWriterAttribute.Headers:
                    _sScript = "headers";
                    break;
                case HtmlTextWriterAttribute.Height:
                    _sScript = "height";
                    break;
                case HtmlTextWriterAttribute.Href:
                    _sScript = "href";
                    break;
                case HtmlTextWriterAttribute.Id:
                    _sScript = "id";
                    break;
                case HtmlTextWriterAttribute.Longdesc:
                    _sScript = "longdesc";
                    break;
                case HtmlTextWriterAttribute.Maxlength:
                    _sScript = "maxlength";
                    break;
                case HtmlTextWriterAttribute.Multiple:
                    _sScript = "multiple";
                    break;
                case HtmlTextWriterAttribute.Name:
                    _sScript = "name";
                    break;
                case HtmlTextWriterAttribute.Nowrap:
                    _sScript = "nowrap";
                    break;
                case HtmlTextWriterAttribute.Onchange:
                    _sScript = "onchange";
                    break;
                case HtmlTextWriterAttribute.Onclick:
                    _sScript = "onclick";
                    break;
                case HtmlTextWriterAttribute.ReadOnly:
                    _sScript = "readonly";
                    break;
                case HtmlTextWriterAttribute.Rel:
                    _sScript = "rel";
                    break;
                case HtmlTextWriterAttribute.Rows:
                    _sScript = "rows";
                    break;
                case HtmlTextWriterAttribute.Rowspan:
                    _sScript = "rowspan";
                    break;
                case HtmlTextWriterAttribute.Rules:
                    _sScript = "rules";
                    break;
                case HtmlTextWriterAttribute.Scope:
                    _sScript = "scope";
                    break;
                case HtmlTextWriterAttribute.Selected:
                    _sScript = "selected";
                    break;
                case HtmlTextWriterAttribute.Shape:
                    _sScript = "shape";
                    break;
                case HtmlTextWriterAttribute.Size:
                    _sScript = "size";
                    break;
                case HtmlTextWriterAttribute.Src:
                    _sScript = "src";
                    break;
                case HtmlTextWriterAttribute.Style:
                    _sScript = "style";
                    break;
                case HtmlTextWriterAttribute.Tabindex:
                    _sScript = "tabindex";
                    break;
                case HtmlTextWriterAttribute.Target:
                    _sScript = "target";
                    break;
                case HtmlTextWriterAttribute.Title:
                    _sScript = "title";
                    break;
                case HtmlTextWriterAttribute.Type:
                    _sScript = "type";
                    break;
                case HtmlTextWriterAttribute.Usemap:
                    _sScript = "usemap";
                    break;
                case HtmlTextWriterAttribute.Valign:
                    _sScript = "valign";
                    break;
                case HtmlTextWriterAttribute.Value:
                    _sScript = "value";
                    break;
                case HtmlTextWriterAttribute.VCardName:
                    _sScript = "vcardname";
                    break;
                case HtmlTextWriterAttribute.Width:
                    _sScript = "width";
                    break;
                case HtmlTextWriterAttribute.Wrap:
                    _sScript = "wrap";
                    break;
            }
            return _sScript;
        }
        #endregion

        #region Set JSControl Style By JavaScript
        public static string SetJSControlStyle(string x_sID, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr, bool x_bIncludeScript)
        {
            Random ran = new Random();
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}='{4}';{5}", x_sID, "{", x_sID, RegisterJS.GetControlStyleStr(x_oStyle), x_sValue, "}");
            else
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').style.{3}={4};{5}", x_sID, "{", x_sID, RegisterJS.GetControlStyleStr(x_oStyle), x_sValue, "}");

            if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
            return _sScript;
        }

        public static string SetJSControlNameStyle(string x_sName, HtmlTextWriterStyle x_oStyle, string x_sValue, bool x_bStr, bool x_bIncludeScript)
        {
            Random ran = new Random();
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("if (ChkName('{0}')) {1} for (i = 0; i < GetName('{2}').length; i++) {3} GetName('{4}')[i].style.{5} = '{6}'; {7} {8}", x_sName, "{", x_sName, "{",x_sName,RegisterJS.GetControlStyleStr(x_oStyle), x_sValue, "}","}");
            else
                _sScript = string.Format("if (ChkName('{0}')) {1} for (i = 0; i < GetName('{2}').length; i++) {3} GetName('{4}')[i].style.{5} = {6}; {7} {8}", x_sName, "{", x_sName, "{", x_sName, RegisterJS.GetControlStyleStr(x_oStyle), x_sValue, "}", "}");

            if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
            return _sScript;
        }
        #endregion

        #region Set JSContorl Attributes By JavaScript
        
        public static string SetJSControlAtt(string x_sID, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr, bool x_bIncludeScript)
        {
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').{3}='{4}';{5}", x_sID, "{", x_sID, GetControlAttributeStr(x_oAtt), x_sValue, "}");
            else
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').{3}={4};{5}", x_sID,"{", x_sID, GetControlAttributeStr(x_oAtt), x_sValue,"}");

            if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
            return _sScript;
        }
        public static string SetJSControlAtt(string x_sID, string x_sAtt, string x_sValue, bool x_bStr, bool x_bIncludeScript)
        {
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').{3}='{4}';{5}", x_sID, "{",x_sID, GetControlAttributeStr(x_sAtt), x_sValue,"}");
            else
                _sScript = string.Format("if(ChkID('{0}')){1}GetID('{2}').{3}={4};{5}", x_sID, "{",x_sID, GetControlAttributeStr(x_sAtt), x_sValue,"}");

            if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
            return _sScript;
        }

        public static string SetJSControlNameAtt(string x_sName, HtmlTextWriterAttribute x_oAtt, string x_sValue, bool x_bStr, bool x_bIncludeScript)
        {
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("if (ChkName('{0}')) {1} for (i = 0; i < GetName('{2}').length; i++) {3} GetName('{4}')[i].{5} = '{6}'; {7} {8}", x_sName, "{", x_sName, "{", x_sName, GetControlAttributeStr(x_oAtt), x_sValue, "}", "}");
            else
                _sScript = string.Format("if (ChkName('{0}')) {1} for (i = 0; i < GetName('{2}').length; i++) {3} GetName('{4}')[i].{5} = {6}; {7} {8}", x_sName, "{", x_sName, "{", x_sName, GetControlAttributeStr(x_oAtt), x_sValue, "}", "}");

            if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
            return _sScript;
        }
        public static string SetJSControlNameAtt(string x_sName, string x_sAtt, string x_sValue, bool x_bStr, bool x_bIncludeScript)
        {
            string _sScript = string.Empty;
            if (x_bStr)
                _sScript = string.Format("if (ChkName('{0}')) {1} for (i = 0; i < GetName('{2}').length; i++) {3} GetName('{4}')[i].{5} = '{6}'; {7} {8}", x_sName, "{", x_sName, "{", x_sName, GetControlAttributeStr(x_sAtt), x_sValue, "}", "}");
            else
                _sScript = string.Format("if (ChkName('{0}')) {1} for (i = 0; i < GetName('{2}').length; i++) {3} GetName('{4}')[i].{5} = {6}; {7} {8}", x_sName, "{", x_sName, "{", x_sName, GetControlAttributeStr(x_sAtt), x_sValue, "}", "}");

            if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
            return _sScript;
        }
        #endregion

        #region Set JSContorl Value By JavaScript
        public static string SetJSControlValue(string x_sID, string x_sValue, bool x_bStr, bool x_bIncludeScript)
        {
            string _sScript = string.Empty;

            if (x_bStr)
                _sScript = string.Format("if(ChkID('{0}')){1} GetID('{2}').value='{3}'; {4}", x_sID, "{", x_sID, x_sValue.Replace("'", "\\'"), "}");
            else
                _sScript = string.Format("if(ChkID('{0}')){1} GetID('{2}').value='{3}'; {4}", x_sID, "{", x_sID, x_sValue.Replace("'", "\\'"), "}");

            if (x_bIncludeScript) _sScript = "<script>" + _sScript + "</script>";
            return _sScript;
        }
        #endregion
    }
}
