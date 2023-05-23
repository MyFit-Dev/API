using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.FormException
{
    public class FormNotFoundException : Exception
    {
        public FormNotFoundException()
        {
        }

        public FormNotFoundException(string? message) : base(message)
        {
        }

        public FormNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FormNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
