namespace Curlz.Exception
{
    public class StatusNotFoundException : ApplicationException
    {
        public StatusNotFoundException() { }
        public StatusNotFoundException(string msg) : base(msg) { }
    }
}
