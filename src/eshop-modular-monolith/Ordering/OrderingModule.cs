using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

namespace Ordering
{
    public static class OrderingModule
    {
          public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddApplicationServices()
            //        .AddInfrastructureServices(configuration)
            //        .AddApiServices(configuration);
            return services;
        }
        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            // Cấu hình middleware của OrderingModule tại đây nếu cần thiết
            return app;
        }
    }
}
