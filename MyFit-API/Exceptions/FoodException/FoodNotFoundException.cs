using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.FoodException
{
    public class FoodNotFoundException : Exception
    {
        public FoodNotFoundException()
        {
        }

        public FoodNotFoundException(string? message) : base(message)
        {
        }

        public FoodNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected FoodNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
