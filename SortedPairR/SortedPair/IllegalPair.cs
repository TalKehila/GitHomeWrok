using System;
using System.Runtime.Serialization;
namespace SortedPair
{
    [Serializable]
    internal class IllegalPair : Exception
    {
        public IllegalPair()
        {
        }
        public IllegalPair(string message) : base(message)
        {
        }
        public IllegalPair(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected IllegalPair(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}