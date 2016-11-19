#if NETSTANDARD1_3
namespace System
{
    // FIXME: will be removed.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
    public sealed class SerializableAttribute : Attribute
    { }

    // FIXME: will be removed.
    [Serializable]
    public class ApplicationException : Exception
    {
        public ApplicationException() { }
        public ApplicationException(string message) { }
        public ApplicationException(string message, Exception inner) {}
    }

    public interface ICloneable {
        object Clone();
    }
}

#endif