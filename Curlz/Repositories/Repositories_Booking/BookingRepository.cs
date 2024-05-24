using Curlz.Models;
using Microsoft.EntityFrameworkCore;

namespace Curlz.Repositories.Repositories_Booking
{
    public class BookingRepository : IBookingRepository
    {
        private readonly CurlzDbContext db;

        public BookingRepository(CurlzDbContext db)
        {
            this.db = db;
        }
        public List<Booking> GetBooking()
        {
            return db.Bookings.Include(b => b.Service).Include(b => b.Registration).Include(b=>b.Slot).ToList();
        }
        public int AddBooking(Booking Booking)
        {
            db.Bookings.Add(Booking);
            return db.SaveChanges();
        }
        public int DeleteBooking(int id)
        {
            Booking c = db.Bookings.Where(x => x.Booking_Id == id).FirstOrDefault();
            db.Bookings.Remove(c);
            return db.SaveChanges();
        }

        public Booking GetBooking(int id)
        {
            return db.Bookings.Where(x => x.Booking_Id == id).FirstOrDefault();
        }
        public int UpdateBooking(int id, Booking Booking)
        {
            Booking c = db.Bookings.Where(x => x.Booking_Id == id).FirstOrDefault();

            c.Booking_Date = Booking.Booking_Date;
            c.Booked_Date = Booking.Booked_Date;
            c.Status = Booking.Status;

            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
