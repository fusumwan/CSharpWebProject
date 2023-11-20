using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEURON.WEB.UI.HTMLCONTROL.JSCONTROL
{
    public class JSScriptLibrary
    {
        public static string JSScriptCommon
        {
            get
            {
                StringBuilder _oJSCode = new StringBuilder();
                _oJSCode.AppendLine("<script>");
                _oJSCode.AppendLine("function JSHtmlSelect(ObjID){this.Id=ObjID;   ");
                _oJSCode.AppendLine("this.init=function(ObjID){ this.SelectObj=document.getElementById(ObjID);} ");
                _oJSCode.AppendLine("this.AddItem=function(text,value){if(this.SelectObj!=undefined){this.SelectObj.add(new Option(text,value));}}  ");
                _oJSCode.AppendLine("this.RemoveAt=function(index){if(this.SelectObj!=undefined){if(this.SelectObj.selectedIndex > -1){for(var i=0;i<this.SelectObj.options.length;i++){if(i==index){this.SelectObj.remove(i);i = i - 1;break;}}}}} ");
                _oJSCode.AppendLine("this.ItemClear=function(){if(this.SelectObj!=undefined){ this.SelectObj.options.length=0; }} ");
                _oJSCode.AppendLine("this.Remove=function(text,value){if(this.SelectObj!=undefined){if(this.SelectObj.selectedIndex > -1){for(var i=0;i<this.SelectObj.options.length;i++){var SelectText = this.SelectObj.options.item(i).text;var SelectValue = this.SelectObj.options.item(i).value;if(SelectText == text && SelectValue == value){this.SelectObj.remove(i);i = i - 1;break;}}}}}  ");
                _oJSCode.AppendLine("this.SetItem=function(index,text,value,disabled,selected){if(this.SelectObj!=undefined){if(index<this.SelectObj.options.length){if(text!=null){this.SelectObj.options.item(index).text=text;}if(value!=null){this.SelectObj.options.item(index).value=value;}if(selected!=null && selected==true){this.ClearSelected();this.SelectObj.options.item(index).selected=selected;}if(disabled!=null){this.SelectObj.options.item(index).disabled=disabled;}}}} ");
                _oJSCode.AppendLine("this.ClearSelected=function(){if(this.SelectObj!=undefined){for(i=0;i<this.SelectObj.options.length;i++){this.SelectObj.options.item(i).selected=false;}}} ");
                _oJSCode.AppendLine("this.init(ObjID);}  ");

                _oJSCode.AppendLine("function JSHtmlRadio(ObjName) {");
                _oJSCode.AppendLine("this.Name = ObjName;");
                _oJSCode.AppendLine("this.init = function(ObjName) { this.radioObj = GetName(ObjName); }");
                _oJSCode.AppendLine("this.GetRadioValue = function() { if (this.radioObj == undefined) { return \"\"; } if (!this.radioObj) { return \"\"; } var radioLength = this.radioObj.length; if (radioLength == undefined) { if (this.radioObj.checked) { return this.radioObj.value; } else { return \"\"; } } for (var i = 0; i < radioLength; i++) { if (this.radioObj[i].checked) { return this.radioObj[i].value; } } return \"\"; }");
                _oJSCode.AppendLine("this.SetRadioValue= function(newValue) {  if (this.radioObj == undefined) { return \"\"; } if (!this.radioObj) { return; } var radioLength = this.radioObj.length; if (radioLength == undefined) { this.radioObj.checked = (this.radioObj.value == newValue.toString()); return; } for (var i = 0; i < radioLength; i++) { this.radioObj[i].checked = false; if (this.radioObj[i].value == newValue.toString()) { this.radioObj[i].checked = true; } } }");
                _oJSCode.AppendLine("this.SetRadioSelectIndex = function(index,selected) { if (this.radioObj == undefined) { return; } var radioLength = this.radioObj.length; if (radioLength == undefined) { return; } if (index < radioLength) { for (var i = 0; i < radioLength; i++) { this.radioObj[i].checked = false; if (i == index) { this.radioObj[i].checked = selected; } } } }");
                _oJSCode.AppendLine("this.GetRadioSelectIndex = function() {if (this.radioObj == undefined) { return; }var radioLength = this.radioObj.length; for (var i = 0; i < radioLength; i++) {if (this.radioObj[i].checked) { return i; }}return -1;}");
                _oJSCode.AppendLine("this.SetItem = function(index, value, disabled, selected) {if (this.radioObj != undefined) { if (value != null) {if (index == null) {this.SetRadioValue(value);}else {var radioLength = this.radioObj.length; if (radioLength == undefined) { return; }if (index < radioLength) {for (var i = 0; i < radioLength; i++) { if (i == index) { this.radioObj[i].value = value;}}}}if (disabled != null) {var radioLength = this.radioObj.length;if (radioLength == undefined) { return; }if (index < radioLength) {for (var i = 0; i < radioLength; i++) {this.radioObj[i].disabled = disabled;}}}if (selected != null) {this.SetRadioSelectIndex(index, selected);}}}}");
                _oJSCode.AppendLine("this.init(ObjName);}");


                _oJSCode.AppendLine("function ChkID(ID){if(document.getElementById(ID)!=undefined){return true;}else{return false;}}function GetID(ID){return document.getElementById(ID);}");
                _oJSCode.AppendLine("function ChkName(Name) { if (document.getElementsByName(Name) != undefined){return true;}else{return false;} } function GetName(Name) { return document.getElementsByName(Name); }");
                _oJSCode.Append("</script>");
                return _oJSCode.ToString();
            }
        }

        public static string ReadKey(string Key)
        {
            if (!string.IsNullOrEmpty(Key) && Key.IndexOf('_') > 0)
            {
                string[] KeyList = Key.Split(("_")[0]);
                return KeyList[0];
            }
            return string.Empty;
        }
    }
}
