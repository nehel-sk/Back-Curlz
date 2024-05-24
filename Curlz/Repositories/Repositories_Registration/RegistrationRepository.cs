using Curlz.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Curlz.Repositories.Repositories_Registration
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly CurlzDbContext db;

        private readonly IConfiguration configuration;

        public RegistrationRepository(CurlzDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }
        public List<Registration> GetRegistration()
        {
            return db.Registrations.ToList();
        }
        public int AddRegistration(Registration Registration)
        {
            db.Registrations.Add(Registration);
            return db.SaveChanges();
        }
        public int DeleteRegistration(int id)
        {
            Registration c = db.Registrations.Where(x => x.Reg_Id == id).FirstOrDefault();
            db.Registrations.Remove(c);
            return db.SaveChanges();
        }

        public Registration GetRegistration(int id)
        {
            return db.Registrations.Where(x => x.Reg_Id == id).FirstOrDefault();
        }
        public int UpdateRegistration(int id, Registration Registration)
        {
            Registration c = db.Registrations.Where(x => x.Reg_Id == id).FirstOrDefault();
            c.First_Name = Registration.First_Name;
            c.Last_Name = Registration.Last_Name;
            c.Email_Id = Registration.Email_Id;
            c.Password = Registration.Password;
            c.Confirm_Password = Registration.Confirm_Password;
            c.Phone_No = Registration.Phone_No;

            db.Entry(c).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }

        public string Login(string email, string password)

        {
            var userExist = db.Registrations.FirstOrDefault(t => t.Email_Id == email && t.Password == password);
            if (userExist != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var claims = new[]
                {
                    new Claim(ClaimTypes.Email,userExist.Email_Id),
                    new Claim("Reg_Id",userExist.Reg_Id.ToString()),
                    new Claim("firstName", userExist.First_Name.ToString()),
                    new Claim(ClaimTypes.Role,userExist.Role)
                };
                var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"], claims, expires: DateTime.Now.AddMinutes(30), signingCredentials: credentials);
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            return null;
        }



        /*
        private bool UserExit(Registration userMaster)

        {

            return db.Registrations.Any(t => t.Email_Id == userMaster.Email_Id);

        }*/

    }
}
   
