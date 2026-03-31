using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Teste.UserDomain;

var builder = WebApplication.CreateBuilder(args);

// 🔌 CONNECTION STRING + DB
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔐 IDENTITY
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// 🔐 CONFIGURAÇÃO DE SENHA (opcional, mas recomendado)
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
});

// 🌐 CONTROLLERS
builder.Services.AddControllers();

// 📄 SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🌐 MIDDLEWARES

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 🔐 IMPORTANTE (ordem correta)
app.UseAuthentication(); // 👈 precisa vir antes
app.UseAuthorization();

app.MapControllers();

app.Run();