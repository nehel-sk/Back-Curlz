
using Curlz.Models;
using Curlz.Repositories.Repositories_Booking;
using Curlz.Repositories.Repositories_Feedback;
using Curlz.Repositories.Repositories_Registration;
using Curlz.Repositories.Repositories_Service;
using Curlz.Repositories.Repositories_Slot;
using Curlz.Services.Services_Booking;
using Curlz.Services.Services_Feedback;
using Curlz.Services.Services_Registration;
using Curlz.Services.Services_Service;
using Curlz.Services.Services_Slot;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Curlz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
        
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<IRegistrationRepository, RegistrationRepository>();
            builder.Services.AddTransient<IRegistrationService, RegistrationService>();
            builder.Services.AddTransient<ISlotRepository, SlotRepository>();
            builder.Services.AddTransient<ISlotService, SlotService>();
            builder.Services.AddTransient<IServiceRepository, ServiceRepository>();
            builder.Services.AddTransient<IServiceService, ServiceService>();
            builder.Services.AddTransient<IBookingRepository, BookingRepository>();
            builder.Services.AddTransient<IBookingService, BookingService>();
            builder.Services.AddTransient<IFeedbackRepository, FeedbackRepository>();
            builder.Services.AddTransient<IFeedbackService, FeedbackService>();
            
            builder.Services.AddDbContext<CurlzDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyCon")));

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("policy", builder => builder
                    .WithOrigins("http://localhost:3000")
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .AllowAnyHeader());
                // .WithHeaders("Accept", "Content-Type", "Origin", "X-My-Header"));
            });



            builder.Services.AddAuthentication(options =>

            {
                
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(o =>

            {
                // Used to validate incoming JWT
                o.TokenValidationParameters = new TokenValidationParameters

                {
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    ValidAudience = builder.Configuration["Jwt:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey
                    (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true
                };

            });
            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors("policy");

            app.MapControllers();

            app.Run();
        }
    }
}
