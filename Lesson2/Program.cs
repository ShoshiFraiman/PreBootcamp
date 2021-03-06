using EpidemiologyReport.DAL;
using EpidemiologyReport.Services;
using Lesson2;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);


// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddSingleton<IEpidemiologyReportDB, EpidemiologyReportDB>();
builder.Services.AddScoped<ILocationBusinesssLogic, LocationBusinesssLogic>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IPatientBusinessLogic, PatientBusinessLogic>();


var app = builder.Build();
app.UseLoggerMiddleware();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();
public partial class Program {}
