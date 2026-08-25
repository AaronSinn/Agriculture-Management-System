using AMS.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//var connString = builder.Configuration.GetConnectionString("DefaultConnection");
var connString = "Host=localhost;Port=5432;Database=AMS;Username=AaronSinn;Password=pL9W.R?(5QRa^EHT^E46;";
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connString));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets<Program>();
}


//app.UseHttpsRedireWtion();
app.Run();