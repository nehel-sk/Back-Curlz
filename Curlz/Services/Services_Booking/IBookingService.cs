using Curlz.Models;

namespace Curlz.Services.Services_Booking
{
    public interface IBookingService
    {
        public List<Booking> GetBooking();
        Booking GetBooking(int id);
        int AddBooking(Booking Booking);
        int UpdateBooking(int id, Booking Booking);
        int DeleteBooking(int id);
    }
}
