using LanguageSkillsAPI.Data;
using LanguageSkillsAPI.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Jering.Javascript.NodeJS;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddNodeJS();


builder.Services.AddNodeServices(options =>
{
    options.ProjectPath = "C:\\Users\\Home\\source\\repos\\LanguageSkillsAPI\\LanguageSkillsAPI\\Infrastructure\\TranslationAPI";
});


builder.Services.AddDbContext<ApiContext>(opt =>
        opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<ICardTranslationRepository, CardTranslationRepository>();

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
