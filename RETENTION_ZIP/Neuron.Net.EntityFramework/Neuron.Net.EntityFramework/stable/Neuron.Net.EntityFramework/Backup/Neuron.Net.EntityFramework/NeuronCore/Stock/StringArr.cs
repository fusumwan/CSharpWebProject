using System;
using System.Collections;
using NEURON.ENTITY.FRAMEWORK.STOCK;
namespace NEURON.ENTITY.FRAMEWORK.STOCK
{
    public class ObjectArr : Hashlist
    {
        public new string this[string Key]
        {
            get { return (string)base[Key]; }
            set { base[Key] = value; }
        }

        public new string this[int Index]
        {
            get
            {
                object oTemp = base[Index];
                return (string)oTemp;
            }
        }
        public ObjectArr()
        {

        }
    }
}
