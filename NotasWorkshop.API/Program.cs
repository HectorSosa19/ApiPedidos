using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NotasWorkshop.API.IoC;
using NotasWorkshop.Bl.IoC;
using NotasWorkshop.Core.IoC;
using NotasWorkshop.Model.Contexts.NotasWorkshop;
using NotasWorkshop.Model.Entities;
using NotasWorkshop.Model.IoC;
using NotasWorkshop.Services.IoC;
using NotasWorkshop.Services.Services;
using SendGrid.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.GetConfigurationSections(builder.Configuration);
builder.Services.AddApiRegistry();
builder.Services.AddServicesRegistry();
builder.Services.AddBlRegistry(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddModelRegistry();
builder.Services.AddCoreRegistry();

string myAppDbContextConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<NotasWorkshopDbContext>(op => op.UseSqlServer(myAppDbContextConnection),
    ServiceLifetime.Transient);

// Add services to the container.
builder.Services.AddControllers(options =>
{
	options.EnableEndpointRouting = false;
}).AddFluentValidation();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSendGrid(options =>
{
    options.ApiKey = builder.Configuration.GetSection("SendGridEmailSettings").GetValue<string>("APIKey");
});
builder.Services.AddControllers().AddOData(options => options.Select().Filter().OrderBy());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettingss:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });
var app = builder.Build();

/// Wrong
//string myAppDbContextConnection = app.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<NotasWorkshopDbContext>(op => op.UseSqlServer(myAppDbContextConnection),
//    ServiceLifetime.Transient);
/// 

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
