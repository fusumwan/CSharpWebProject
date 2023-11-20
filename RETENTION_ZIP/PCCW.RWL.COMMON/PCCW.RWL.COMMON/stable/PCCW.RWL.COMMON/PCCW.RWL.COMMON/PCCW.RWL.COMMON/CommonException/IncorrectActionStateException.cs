using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Web; 

/// <summary> 
 /// Summary description for IncorrectActionStateException 
/// </summary> 
[global::System.Serializable]
public class IncorrectActionStateException : Exception
{
    // 
    // For guidelines regarding the creation of new exception types, see 
    //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp 
    // and 
    //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp 
    // 

    public IncorrectActionStateException() { }
    public IncorrectActionStateException(string message) : base(message) { }
    public IncorrectActionStateException(string message, Exception inner) : base(message, inner) { }
    protected IncorrectActionStateException(
       System.Runtime.Serialization.SerializationInfo info,
       System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }
}
