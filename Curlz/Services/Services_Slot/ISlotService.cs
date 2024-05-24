using Curlz.Models;

namespace Curlz.Services.Services_Slot
{
    public interface ISlotService
    {
        public List<Slot> GetSlot();
        Slot GetSlot(int id);
        int AddSlot(Slot Slot);
        int UpdateSlot(int id, Slot Slot);
        int DeleteSlot(int id);
    }
}
