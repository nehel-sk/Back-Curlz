using Curlz.Models;
using Curlz.Exception;
using Curlz.Repositories.Repositories_Booking;

namespace Curlz.Services.Services_Booking
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository repo;

        public BookingService(IBookingRepository repo)
        {

            this.repo = repo;
        }
        public List<Booking> GetBooking()
        {
            return repo.GetBooking();
        }
        public int AddBooking(Booking Booking)
        {
            if (repo.GetBooking(Booking.Booking_Id) != null)
            {
                throw new BookingAlreadyExistsException($"Booking with Booking id {Booking.Booking_Id} already exists");
            }
            return repo.AddBooking(Booking);
        }
        public int DeleteBooking(int id)
        {
            if (repo.GetBooking(id) == null)
            {
                throw new BookingNotFoundException($"Booking with Booking id {id} does not exists");
            }
            return repo.DeleteBooking(id);
        }

        public Booking GetBooking(int id)
        {
            Booking c = repo.GetBooking(id);
            if (c == null)
            {
                throw new BookingNotFoundException($"Booking with Booking id {id} does not exists");
            }
            return c;
        }
        public int UpdateBooking(int id, Booking Booking)
        {
            if (repo.GetBooking(id) == null)
            {
                throw new BookingNotFoundException($"Booking with Booking id {id} does not exists");
            }
            return repo.UpdateBooking(id, Booking);
        }
    }
}
