using System;
using System.ComponentModel;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NEURON.WEB.UI
{
    public class SelectParameter
    {
        public static ObjectParameter ChangeValue(string x_oName, TypeCode x_oType, string x_sValue)
        {
            ObjectParameter _oCode = new ObjectParameter();
            _oCode.Name = x_oName;
            _oCode.Type = x_oType;
            _oCode.Value = x_sValue;
            return _oCode;
        }

    }


    [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
    public class ObjectParameter : Parameter
    {

        public ObjectParameter()
        {
        }
        // The StaticParameter(string, object) constructor
        // initializes the DataValue property and calls the
        // Parameter(string) constructor to initialize the Name property.
        public ObjectParameter(string name, object value)
            : base(name)
        {
            DataValue = value;
        }
        // The StaticParameter(string, TypeCode, object) constructor
        // initializes the DataValue property and calls the
        // Parameter(string, TypeCode) constructor to initialize the Name and
        // Type properties.
        public ObjectParameter(string name, TypeCode type, object value)
            : base(name, type)
        {
            DataValue = value;
        }
        // The StaticParameter copy constructor is provided to ensure that
        // the state contained in the DataValue property is copied to new
        // instances of the class.
        protected ObjectParameter(ObjectParameter original)
            : base(original)
        {
            DataValue = original.DataValue;
        }

        // The Clone method is overridden to call the
        // StaticParameter copy constructor, so that the data in
        // the DataValue property is correctly transferred to the
        // new instance of the StaticParameter.
        protected override Parameter Clone()
        {
            return new ObjectParameter(this);
        }
        // The DataValue can be any arbitrary object and is stored in ViewState.
        public object DataValue
        {
            get
            {
                return ViewState["Value"];
            }
            set
            {
                ViewState["Value"] = value;
            }
        }
        // The Value property is a type safe convenience property
        // used when the StaticParameter represents string data.
        // It gets the string value of the DataValue property, and
        // sets the DataValue property directly.
        public string Value
        {
            get
            {
                object o = DataValue;
                if (o == null || !(o is string))
                    return String.Empty;
                return (string)o;
            }
            set
            {
                DataValue = value;
                OnParameterChanged();
            }
        }

    }
}
