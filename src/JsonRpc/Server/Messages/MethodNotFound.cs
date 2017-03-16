namespace JsonRPC.Server
{
    public class MethodNotFound : Error
    {
        internal MethodNotFound() : this(null) { }
        internal MethodNotFound(object id) : base(id, new ErrorMessage(-32601, "Method not found")) { }
    }
}