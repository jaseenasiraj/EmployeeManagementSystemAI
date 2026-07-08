using EmployeeManagementSystemAI.Data;
using EmployeeManagementSystemAI.Repositories.Implementation;
using EmployeeManagementSystemAI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using EmployeeManagementSystemAI.Models.DTO;
using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(Options =>
{
    Options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeConnectionStrings"));
});
builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        var response = new ValidationErrorResponseDto();

        foreach (var modelState in context.ModelState.Values)
        {
            foreach (var error in modelState.Errors)
            {
                response.Errors.Add(error.ErrorMessage);
            }
        }

        return new BadRequestObjectResult(response);
    };
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<EmployeeManagementSystemAI.Middlewares.ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
