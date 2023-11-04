using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PaginationClass.Data;
using PaginationClass.Model;
using PaginationClass.Pagination.Common.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<PaginationDbContext>(Options => Options.UseSqlServer(builder.Configuration
               .GetConnectionString("Connection")));


builder.Services.AddScoped<IPaginationService<Items>, PaginationService<Items>>();
builder.Services.AddScoped<DatabaseSeeder>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Ticket Ease",
        Description = "TicketEase is a web-based application that streamlines and optimizes the management of task projects",
        TermsOfService = new Uri("https://decagon.institute/#faqs"),
        Contact = new OpenApiContact
        {
            Name = "Ticket Management System",
            Email = "",
            Url = new Uri("https://decagon.institute/") 
        },
        License = new OpenApiLicense
        {
            Name = "Use under OpenApiLiscense",
            Url = new Uri ("https://decagon.institute/"),

        },
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ticket Management System v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
