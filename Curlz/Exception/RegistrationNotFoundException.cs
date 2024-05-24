namespace Curlz.Exception
{
    public class RegistrationNotFoundException:ApplicationException
    {
        public RegistrationNotFoundException() { }
        public RegistrationNotFoundException(string msg) : base(msg) { }
    }
}
