using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.LogException
{
    public class LogNotFoundException : Exception
    {
        public LogNotFoundException()
        {
        }

        public LogNotFoundException(string? message) : base(message)
        {
        }

        public LogNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected LogNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
