namespace Curlz.Exception
{
    public class BookingNotFoundException: ApplicationException
    {
        public BookingNotFoundException() { }
        public BookingNotFoundException(string msg) : base(msg) { }
    }
}
