using Curlz.Models;

namespace Curlz.Repositories.Repositories_Booking
{
    public interface IBookingRepository
    {
        List<Booking> GetBooking();
        Booking GetBooking(int id);
        int AddBooking(Booking Booking);
        int UpdateBooking(int id, Booking Booking);
        int DeleteBooking(int id);
    }
}
