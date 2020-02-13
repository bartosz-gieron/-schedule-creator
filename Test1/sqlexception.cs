using System;
using System.Runtime.Serialization;

namespace Test1
{
    [Serializable]
    internal class sqlexception : Exception
    {
        public sqlexception()
        {
        }

        public sqlexception(string message) : base(message)
        {
        }

        public sqlexception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected sqlexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}