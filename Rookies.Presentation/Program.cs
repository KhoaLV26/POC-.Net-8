
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Rookies.Domain;

namespace Rookies.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var connectionString = builder.Configuration.GetConnectionString("BookBorrowManagementConnection");
            builder.Services.AddDbContext<BookBorrowManagementContext>(options => options.UseSqlServer(connectionString,x => x.MigrationsAssembly("Rookies.Presentation")));
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
