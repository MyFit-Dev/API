using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.GymException
{
    [Serializable]
    public class GymNotFoundException : Exception
    {
        public GymNotFoundException()
        {
        }

        public GymNotFoundException(string? message) : base(message)
        {
        }

        public GymNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GymNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
