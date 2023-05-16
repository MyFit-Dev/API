using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.PlanException
{
    [Serializable]
    public class PlanAlredyFoundException : Exception
    {
        public PlanAlredyFoundException()
        {
        }

        public PlanAlredyFoundException(string? message) : base(message)
        {
        }

        public PlanAlredyFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PlanAlredyFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
