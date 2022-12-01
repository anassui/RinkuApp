using RinkuApp.Persistence.Data;
using RinkuApp.Persistence.Repositories;
using RinkuApp.Persistence.RepositoriesInterface;
using RinkuApp.Service.Services;
using RinkuApp.Services.ServicesInterface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AppDbContext, AppDbContext>();
builder.Services.AddScoped<IA01EmpleadosRepository, A01EmpleadosRepository>();
builder.Services.AddScoped<IA02RolesRepository, A02RolesRepository>();
builder.Services.AddScoped<IB01SalariosRepository, B01SalariosRepository>();
builder.Services.AddScoped<IB02RolEmpleadoRepository, B02RolEmpleadoRepository>();
builder.Services.AddScoped<IB03EntregasEmpleadoRepository, B03EntregasEmpleadoRepository>();
builder.Services.AddScoped<IBitacoraHorasLaboradasRepository, BitacoraHorasLaboradasRepository>();
builder.Services.AddScoped<IX01ParametrosGeneralesRepository, X01ParametrosGeneralesRepository>();

builder.Services.AddScoped<IA01EmpleadosService, A01EmpleadosService>();
builder.Services.AddScoped<IA02RolesService, A02RolesService>();
builder.Services.AddScoped<IB01SalariosService, B01SalariosService>();
builder.Services.AddScoped<IB02RolEmpleadoService, B02RolEmpleadoService>();
builder.Services.AddScoped<IB03EntregasEmpleadoService, B03EntregasEmpleadoService>();
builder.Services.AddScoped<IBitacoraHorasLaboradasService, BitacoraHorasLaboradasService>();
builder.Services.AddScoped<IX01ParametrosGeneralesService, X01ParametrosGeneralesService>();
builder.Services.AddMvcCore().AddRazorViewEngine();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
   // app.UseSwagger();
   // app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
