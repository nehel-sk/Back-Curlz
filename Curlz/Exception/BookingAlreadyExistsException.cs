namespace Curlz.Exception
{
    public class BookingAlreadyExistsException: ApplicationException
    {
        public BookingAlreadyExistsException() { }
        public BookingAlreadyExistsException(string msg) : base(msg) { }
    }
}
