using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.DietException
{
    public class DietNotFoundException : Exception
    {
        public DietNotFoundException()
        {
        }

        public DietNotFoundException(string? message) : base(message)
        {
        }

        public DietNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DietNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
