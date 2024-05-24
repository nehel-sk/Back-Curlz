using Curlz.Models;

namespace Curlz.Repositories.Repositories_Slot
{
    public interface ISlotRepository
    {
        List<Slot> GetSlot();
        Slot GetSlot(int id);
        int AddSlot(Slot Slot);
        int UpdateSlot(int id, Slot Slot);
        int DeleteSlot(int id);
    }
}
