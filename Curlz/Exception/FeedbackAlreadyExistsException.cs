namespace Curlz.Exception
{
    public class FeedbackAlreadyExistsException : ApplicationException
    {
        public FeedbackAlreadyExistsException() { }
        public FeedbackAlreadyExistsException(string msg) : base(msg) { }
    }
}
