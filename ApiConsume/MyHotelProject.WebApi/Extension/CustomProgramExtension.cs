using MyHotelProject.BusinessLayer.Abstract;
using MyHotelProject.BusinessLayer.Concrete;
using MyHotelProject.DataAccessLayer.Abstract;
using MyHotelProject.DataAccessLayer.Concrete;
using MyHotelProject.DataAccessLayer.EntityFramework;
using MyHotelProject.DataAccessLayer.Repositories;

namespace MyHotelProject.WebApi.Extension
{
    public static class CustomProgramExtension
    {
        public static void CustomService(this IServiceCollection services)
        {
            services.AddDbContext<MyContext>();

            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IStaffDal, EfStaffDal>();

            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IServicesDal, EfServicesDal>();

            services.AddScoped<ISubcribeService, SubcribeManager>();
            services.AddScoped<ISubcribeDal, EfSubcrieDal>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
        }
    }
}
