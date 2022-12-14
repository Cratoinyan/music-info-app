using Microsoft.EntityFrameworkCore;
using music_info_app.DAL.Concreation;
using music_info_app.DAL.Interface;
using music_info_app.DB;
using music_info_app.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
});

builder.Services.AddDbContext<SongContext>(options => options.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=SongDb;trusted_connection=true;"));
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<IAlbumRepository,AlbumRepository>();
builder.Services.AddScoped<IArtistRepository,ArtistRepository>();

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
