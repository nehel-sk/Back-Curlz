using Curlz.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Curlz.Repositories.Repositories_Service
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly CurlzDbContext db;

        public ServiceRepository(CurlzDbContext db)
        {
            this.db = db;
        }
        public List<Service> GetService()
        {
            return db.Services.ToList();
        }
        public int AddService(Service Service)
        {
            db.Services.Add(Service);
            return db.SaveChanges();
        }
        public int DeleteService(int id)
        {
            Service c = db.Services.Where(x => x.Service_Id == id).FirstOrDefault();
            db.Services.Remove(c);
            return db.SaveChanges();
        }

        public Service GetService(int id)
        {
            return db.Services.Where(x => x.Service_Id == id).FirstOrDefault();
        }
        public int UpdateService(int id, Service Service)
        {
            Service c = db.Services.Where(x => x.Service_Id == id).FirstOrDefault();
            c.Service_Name = Service.Service_Name;
            c.Description = Service.Description;
            c.Price = Service.Price;


            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }


        //Stored Procedure SearchByServiceName

        /*public List<Service> GetServiceByName(string service)
        {

            string Srch = "exec SearchServices " +
                "@service = " + service;
            return db.Services.FromSqlRaw(Srch).ToList();
        }*/

        public List<Service> GetServiceByService(string service)
        {
            string SearchServices = "exec SearchServices @service";
            return db.Services.FromSqlRaw(SearchServices, new SqlParameter("@service", service)).ToList();
        }
    }
}
