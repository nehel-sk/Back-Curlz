using Curlz.Models;

namespace Curlz.Services.Services_Service
{
    public interface IServiceService
    {
        public List<Service> GetService();
        Service GetService(int id);
        int AddService(Service Service);
        int UpdateService(int id, Service Service);
        int DeleteService(int id);

        //Stored Procedure SearchByServiceName

        List<Service> GetServiceByService(string service);
    }
}
