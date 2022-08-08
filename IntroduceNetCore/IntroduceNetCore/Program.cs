var builder = WebApplication.CreateBuilder(args);

// this is where we can manage our configuration

//Before app.Build() runs, every instance of objects needed in every request can be registered to Services(IServiceCollection)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// We can also set up somethings to the specific environment
if (app.Environment.IsDevelopment())
{ 
    
}

//before app.Run, middleware that is going to run with every request has to be added to the app in pipeline order
//app.UseAuthentication();
//app.UseAuthorization();

app.UseRouting();

// Creating custom endpoints
// we can use default MapDefaultControllerRoute
app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}"));

//app.MapGet("/", () => "Hello World!");

app.Run();
