using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder; // Cực kỳ quan trọng để nhận diện IApplicationBuilder


namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration)
        {
            //add services to the container 
            //services.AddApplicationServices();
            //        .AddInfrastructureServices(configuration);
            //        .AddApiServices(configuration);

            return services;
        }
        public static IApplicationBuilder UseBasketModule(this IApplicationBuilder app)
        {
            // Cấu hình middleware của BasketModule tại đây nếu cần thiết
            return app;
        }

    }
}
