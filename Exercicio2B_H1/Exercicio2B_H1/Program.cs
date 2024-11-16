
using Exercicio2B_H1.Repositories;
using Exercicio2B_H1.Services;

namespace Exercicio2B_H1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
            builder.Services.AddScoped<IAlunoService, AlunoService>();

            builder.Services.AddScoped<IAlunoNotaRepository, AlunoNotaRepository>();
            builder.Services.AddScoped<IAlunoNotaService, AlunoNotaService>();

            builder.Services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();
            builder.Services.AddScoped<IDisciplinaService, DisciplinaService>();
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
        }
    }
}

