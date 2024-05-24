namespace Curlz.Exception
{
    public class SlotAlreadyExistsException : ApplicationException
    {
        public SlotAlreadyExistsException() { }
        public SlotAlreadyExistsException(string msg) : base(msg) { }
    }
}
