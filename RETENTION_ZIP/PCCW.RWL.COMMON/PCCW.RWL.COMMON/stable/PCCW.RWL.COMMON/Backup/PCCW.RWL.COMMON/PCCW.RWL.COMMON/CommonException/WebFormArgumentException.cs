﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCCW.RWL.CORE
{
    [global::System.Serializable]
    public class WebFormArgumentException : Exception
    {
        // 
        // For guidelines regarding the creation of new exception types, see 
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp 
        // and 
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp 
        // 

        public WebFormArgumentException() { }
        public WebFormArgumentException(string message) : base(message) { }
        public WebFormArgumentException(string message, Exception inner) : base(message, inner) { }
        protected WebFormArgumentException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
