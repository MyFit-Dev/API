using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.StaffException
{
    public class StaffNotFoundException : Exception
    {
        public StaffNotFoundException()
        {
        }

        public StaffNotFoundException(string? message) : base(message)
        {
        }

        public StaffNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StaffNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
