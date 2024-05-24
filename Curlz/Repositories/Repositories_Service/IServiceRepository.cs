using Curlz.Models;

namespace Curlz.Repositories.Repositories_Service
{
    public interface IServiceRepository
    {
        
        List<Service> GetService();
        Service GetService(int id);
        int AddService(Service Service);
        int UpdateService(int id, Service Service);
        int DeleteService(int id);

        //Stored procedure SearchByServiceName
        List<Service> GetServiceByService(string service);
    }
}
