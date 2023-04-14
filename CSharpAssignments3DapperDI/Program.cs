using ApplicationCore.Services.Services;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddSingleton<DapperDbContext>();
builder.Services.AddTransient<DepartmentRepository, DepartmentRepository>();
builder.Services.AddTransient<IDepartmentService, DepartmentService>();
builder.Services.AddTransient<EmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "index", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "employee", pattern: "{controller=Home}/{action=Employee}/{id?}");
app.MapControllerRoute(
    name: "department", pattern: "{controller=Home}/{action=Department}/{id?}");

app.Run();
