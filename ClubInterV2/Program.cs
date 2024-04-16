using ClubInterV2.Data;
using ClubInterV2.Models;
using ClubInterV2.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

var JWTSetting = builder.Configuration.GetSection("JWTSetting");
// Add services to the container.

// Value to connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
// Register service to connection
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);

// to able to inject JWTService class inside our Controllers
builder.Services.AddScoped<JWTService>();


builder.Services.AddIdentityCore<User>(options =>
{
    // Password configuration
    options.Password.RequiredLength = 6;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;

    // For email confirmation
    options.SignIn.RequireConfirmedEmail = true;
}).AddRoles<IdentityRole>() // be able to add roles
.AddRoleManager<RoleManager<IdentityRole>>() // be able to make use og RolManager
.AddEntityFrameworkStores<AppDbContext>() // Providing our context
.AddSignInManager<SignInManager<User>>() // make use of Signin Manager
.AddUserManager<UserManager<User>>() // make use of UserManager to create users
.AddDefaultTokenProviders(); // to able to create tokens for email confirmation


// be able to authentication users using JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // validate the token based on the key we have provided inside appsettings.development.json JWT:Key
            ValidateIssuerSigningKey = true,
            // the issuer signin key based on JWT:Key
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"])),
            // the issuer which in here is the api project url we are using
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            // validatethe issuer (whow ever is issuing the JWT)
            ValidateIssuer = true,
            // don't validate audience (andular side)
            ValidateAudience = false
        };
    });

/*

builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();


builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(opt => {
    opt.SaveToken = true;
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidAudience = JWTSetting["ValidAudience"],
        ValidIssuer = JWTSetting["ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JWTSetting.GetSection("securityKey").Value!))
    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization Exampl : 'Bearer eyeleie",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
        new OpenApiSecurityScheme{
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "Bearer"
            },
            Scheme = "out",
            Name= "Bearer",
            In = ParameterLocation.Header
        },
        new List<string>()
        }
    });
});*/

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// adding UseAuthentication into our pipeline and this shuld come before UseAuthorization
// Authentication verifies the identity of a user or service, and authorization determines their acess rights
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
