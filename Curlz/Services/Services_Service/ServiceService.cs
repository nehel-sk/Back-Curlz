using Curlz.Models;
using Curlz.Exception;
using Curlz.Repositories.Repositories_Service;

namespace Curlz.Services.Services_Service
{
    public class ServiceService: IServiceService
    {
        private readonly IServiceRepository repo;

        public ServiceService(IServiceRepository repo)
        {

            this.repo = repo;
        }
        public List<Service> GetService()
        {
            return repo.GetService();
        }
        public int AddService(Service Service)
        {
            if (repo.GetService(Service.Service_Id) != null)
            {
                throw new ServiceAlreadyExistsException($"Service with Service id {Service.Service_Id} already exists");
            }
            return repo.AddService(Service);
        }
        public int DeleteService(int id)
        {
            if (repo.GetService(id) == null)
            {
                throw new ServiceNotFoundException($"Service with Service id {id} does not exists");
            }
            return repo.DeleteService(id);
        }

        public Service GetService(int id)
        {
            Service c = repo.GetService(id);
            if (c == null)
            {
                throw new ServiceNotFoundException($"Service with Service id {id} does not exists");
            }
            return c;
        }
        public int UpdateService(int id, Service Service)
        {
            if (repo.GetService(id) == null)
            {
                throw new ServiceNotFoundException($"Service with Service id {id} does not exists");
            }
            return repo.UpdateService(id, Service);
        }


        //Stored Procedure SearchByServiceName

        public List<Service> GetServiceByService(string service)
        {
            return repo.GetServiceByService(service);
        }
    }
}
