using Curlz.Exception;
using Curlz.Models;
using Curlz.Repositories.Repositories_Registration;

namespace Curlz.Services.Services_Registration
{
    public class RegistrationService: IRegistrationService
    {
        private readonly IRegistrationRepository repo;

        public RegistrationService(IRegistrationRepository repo)
        {

            this.repo = repo;
        }
        public List<Registration> GetRegistration()
        {
            return repo.GetRegistration();
        }
        public int AddRegistration(Registration Registration)
        {
            if (repo.GetRegistration(Registration.Reg_Id) != null)
            {
                throw new RegistrationAlreadyExistsException($"Registration with Registration id {Registration.Reg_Id} already exists");
            }
            return repo.AddRegistration(Registration);
        }
        public int DeleteRegistration(int id)
        {
            if (repo.GetRegistration(id) == null)
            {
                throw new RegistrationNotFoundException($"Registration with Registration id {id} does not exists");
            }
            return repo.DeleteRegistration(id);
        }

        public Registration GetRegistration(int id)
        {
            Registration c = repo.GetRegistration(id);
            if (c == null)
            {
                throw new RegistrationNotFoundException($"Registration with Registration id {id} does not exists");
            }
            return c;
        }
        public int UpdateRegistration(int id, Registration Registration)
        {
            if (repo.GetRegistration(id) == null)
            {
                throw new RegistrationNotFoundException($"Registration with Registration id {id} does not exists");
            }
            return repo.UpdateRegistration(id, Registration);
        }

        public string Login(string email, string password)
        {
            return repo.Login(email, password);
        }
    }
}
