namespace Curlz.Exception
{
    public class RegistrationAlreadyExistsException : ApplicationException
    {
        public RegistrationAlreadyExistsException() { }
        public RegistrationAlreadyExistsException(string msg) : base(msg) { }
    }
}
