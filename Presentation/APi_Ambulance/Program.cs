using APi_Ambulance.Persistens.CodeEfCore;
using Microsoft.EntityFrameworkCore;
using API_Ambulance.Application.Automapper.Patients;
using API_Ambulance.Application.Automapper.CallAmbulance;
using APi_Ambulance.DIServices;
using API_Ambulance.Application.Automapper.AmbDeparture;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(CreateMapPatient));
builder.Services.AddAutoMapper(typeof(CallAmbulCreatMap));
builder.Services.AddAutoMapper(typeof(CreateMapDeparture));
builder.Services.AddAutoMapper(typeof(ReadMapPatient));
builder.Services.AddAutoMapper(typeof(CallAmbulanceReadMap));
builder.Services.AddAutoMapper(typeof(UpdateMapPatient));
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<EfCoreDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyDbConnect")));
// DI services

builder.Services.AddPatientServices();
builder.Services.AddCallAmbulanceServices();
builder.Services.AddDepartureService();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
