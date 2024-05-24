namespace Curlz.Exception
{
    public class FeedbackNotFoundException : ApplicationException
    {
        public FeedbackNotFoundException() { }
        public FeedbackNotFoundException(string msg) : base(msg) { }
    }
}
