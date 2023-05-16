using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.GymException
{
    [Serializable]
    public class GymAlredyFoundException : Exception
    {
        public GymAlredyFoundException()
        {
        }

        public GymAlredyFoundException(string? message) : base(message)
        {
        }

        public GymAlredyFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected GymAlredyFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
