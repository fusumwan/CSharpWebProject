using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;

using NEURON.ENTITY.FRAMEWORK;
/// <summary>
/// Summary description for Func
/// </summary>
public class Func : FuncHelper
{
	public Func()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public static string IDAdd100000(Nullable<int> x_iOrderID)
    {
        return ((x_iOrderID != null) ? (100000 + ((long)x_iOrderID)).ToString() : string.Empty);
    }

    public static string IDSubtract100000(Nullable<int> x_iOrderID)
    {
        return ((x_iOrderID != null) ? (((long)x_iOrderID) - 100000).ToString() : string.Empty);
    }
}
