using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.UserException
{
    [Serializable]
    public class UserAlredyFoundException : Exception
    {
        public UserAlredyFoundException()
        {
        }

        public UserAlredyFoundException(string? message) : base(message)
        {
        }

        public UserAlredyFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserAlredyFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
