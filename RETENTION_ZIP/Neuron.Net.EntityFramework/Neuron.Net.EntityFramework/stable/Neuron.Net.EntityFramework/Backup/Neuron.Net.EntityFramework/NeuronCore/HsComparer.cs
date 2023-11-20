using System;
using System.Collections;
using System.Globalization;

/// <summary>
/// Summary description for HsComparer
/// </summary>

namespace NEURON.ENTITY.FRAMEWORK
{

    public class HsComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLower().GetHashCode();
        }
    }
}