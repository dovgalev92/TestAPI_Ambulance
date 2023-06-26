using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Implementations;
using API_Ambulance.Application.GenericInterfaces;
using API_Ambulance.Application.Implementation;
using Microsoft.EntityFrameworkCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;
using API_Ambulance.Application.Automapper.Patients;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using APi_Ambulance.Domain.DTO.DToCallAmbul;
using API_Ambulance.Application.Automapper.CallAmbulance;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(CreateMapPatient));
builder.Services.AddAutoMapper(typeof(CallAmbulCreatMap));
builder.Services.AddDbContext<EfCoreDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyDbConnect")));
builder.Services.AddScoped<IRepositoryPatient<Patient>, EmplementationRepositoryPatient>();
builder.Services.AddScoped<IBizServicesPatient<PatientWriteDto, Patient>, BizServicesPatient>();
builder.Services.AddScoped<IRepository<CallingAmbulance>, EmplementationRepository>();
builder.Services.AddScoped<IBizServices<CreateCallAmbulDto>, BizServices>();

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
