using MyFit_Libs.Models;
using System.Runtime.Serialization;
using System.Transactions;

namespace MyFit_API.Exceptions.UserException
{
    [Serializable]
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException()
        {
        }

        public UserNotFoundException(string? message) : base(message)
        {
        }

        public UserNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UserNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
