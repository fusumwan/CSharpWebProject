using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.CORE
{
    [global::System.Serializable]
    public class BusinessObjectNotFoundException : Exception
    {
        // 
        // For guidelines regarding the creation of new exception types, see 
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp 
        // and 
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp 
        // 

        public BusinessObjectNotFoundException() { }
        public BusinessObjectNotFoundException(string message) : base(message) { }
        public BusinessObjectNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected BusinessObjectNotFoundException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
