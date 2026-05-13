using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder; // Cực kỳ quan trọng để nhận diện IApplicationBuilder
namespace Catalog
{
    // 2. Class BẮT BUỘC phải là static để chứa Extension Method
    public static class CatalogModule
    {
        // 3. Hàm này bây giờ sẽ hoạt động chuẩn xác
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
           //services.addApplicationServices() // Đăng ký các dịch vụ của CatalogModule vào DI container
           //     .addInfrastructureServices() // Đăng ký các dịch vụ của CatalogModule vào DI container
           //     .addApiServices(); // Đăng ký các dịch vụ của CatalogModule vào DI container


            return services;
        }

        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            // Cấu hình middleware của CatalogModule tại đây nếu cần thiết
            return app;
        }
    }
}
