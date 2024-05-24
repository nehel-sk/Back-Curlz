namespace Curlz.Exception
{
    public class SlotNotFoundException : ApplicationException
    {
        public SlotNotFoundException() { }
        public SlotNotFoundException(string msg) : base(msg) { }
    }
}
