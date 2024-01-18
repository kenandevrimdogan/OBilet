using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Middleware;
using OBilet.Presentation.UI.Web.Services;
using OBilet.Presentation.UI.Web.Services.Concrete;
using OBilet.Presentation.UI.Web.Services.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.Configure<OBiletApiSettings>(builder.Configuration.GetSection("OBiletApiSettings"));

builder.Services.AddHttpClient();
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<ILocationBusService, LocationBusService>();
builder.Services.AddScoped<IJourneyService, JourneyService>();
builder.Services.AddScoped<IIdentityService, IdentityService>();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddMemoryCache();
builder.Services.AddTransient<HeaderCheckMiddleware>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
