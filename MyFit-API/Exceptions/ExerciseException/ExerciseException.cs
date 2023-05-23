using System.Runtime.Serialization;

namespace MyFit_API.Exceptions.ExerciseException
{
    public class ExerciseException : Exception
    {
        public ExerciseException()
        {
        }

        public ExerciseException(string? message) : base(message)
        {
        }

        public ExerciseException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExerciseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
