using System.Runtime.Serialization;

namespace Errors;

public class InvalidAgeException : Exception
{
    public InvalidAgeException() 
        : base("Geçersiz yaş değeri girildi.")
    {
        
    }

    public InvalidAgeException(string message) 
        : base(message) 
    {
        
    }

    public InvalidAgeException(string message, Exception inner)
        : base(message, inner) 
    {
        
    }

    public InvalidAgeException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    {
        
    }

}
