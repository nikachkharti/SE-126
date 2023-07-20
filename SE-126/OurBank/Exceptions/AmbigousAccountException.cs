using System.Runtime.Serialization;

namespace OurBank.Exceptions
{
    public class AmbigousAccountException : Exception
    {
        public AmbigousAccountException()
        {
        }

        public AmbigousAccountException(string message) : base(message)
        {
        }

        public AmbigousAccountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AmbigousAccountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
