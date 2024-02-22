//namespace FintechTracking
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {

//              Configuration = configuration;

//        }
//        public IConfiguration Configuration { get; }

//        public void ConfigureServices(IServiceCollection services)
//        {


//            //services.AddTransient<FintechTrackingSercice>();

//        }
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {


//            app.UseEndpoints(endpoints =>
//            {
//                //endpoints.MapHangfireDashboard();
//            });
//        }
//    }
//}

// Startup.cs

using FintechTracking.Services;
using FintechTrackingDb;
using Microsoft.EntityFrameworkCore;

namespace FintechTracking
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddTransient<FintechTrackingService>();
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer());




        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

        }
    }
}

      

