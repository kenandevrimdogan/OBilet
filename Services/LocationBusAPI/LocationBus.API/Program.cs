using LocationBus.API.Infrastructure;
using LocationBus.API.Services.Concrete;
using LocationBus.API.Services.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<OBiletApiSettings>(builder.Configuration.GetSection("OBiletApiSettings"));

builder.Services.AddHttpClient();

// Services
builder.Services.AddScoped<ILocationBusService, LocationBusService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
