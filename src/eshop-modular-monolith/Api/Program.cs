
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Add services to the container.
builder.Services.AddControllers();  //add MVC controllers to the services container

app.MapGet("/", () => "Hello World!");

//Configure the HTTP request pipeline.
builder.Services.AddCatalogModule(builder.Configuration) // Đăng ký CatalogModule vào DI container
                .AddBasketModule(builder.Configuration)  // Đăng ký BasketModule vào DI container
                .AddOrderingModule(builder.Configuration);  // Đăng ký OrderModule vào DI container

//congigure the HTTP request pipeline

//Use static file
app.UseStaticFiles();

//Use routing
app.UseRouting();

//Use authentication and authorization
app.UseAuthentication();
app.UseAuthorization();

//Define endpoints
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Map các controller vào routing
});

app.UseCatalogModule(); // Sử dụng CatalogModule trong pipeline
app.UseBasketModule(); // Sử dụng BasketModule trong pipeline
app.UseOrderingModule(); // Sử dụng OrderModule trong pipeline

app.Run();
