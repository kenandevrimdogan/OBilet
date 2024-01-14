using OBilet.Presentation.UI.Web.Infrastructure;
using OBilet.Presentation.UI.Web.Services.Concrete;
using OBilet.Presentation.UI.Web.Services.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.Configure<OBiletApiSettings>(builder.Configuration.GetSection("OBiletClientApiSettings"));
builder.Services.AddHttpClient();

// Services
builder.Services.AddScoped<IJourneyService, JourneyService>();
builder.Services.AddScoped<ILocationBusService, LocationBusService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
