using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserSAP.Data;
using UserSAP.Models;
using UserSAP.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.===================================================
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//===========Personagel Services =======================//
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<TokenService>();

//-----------------Add DbContext------------//
var connectionString = builder.Configuration.GetConnectionString("UserConnection");
builder.Services.AddDbContext<UserDbContext>(opts => opts.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddControllers();

//----------------Add Identity---------------//
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<UserDbContext>()
    .AddDefaultTokenProviders();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
