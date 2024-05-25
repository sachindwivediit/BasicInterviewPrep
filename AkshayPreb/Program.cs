
namespace AkshayPreb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSingleton<CustomMiddleware>();
            builder.Services.AddScoped<ILogger, DatabaseLog>();
            //builder.Services.AddScoped<ILogger, FileLogger>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //responsible to Configure the HTTP request pipeline.
            //its executed on every request in asp.net application

            //request delegate are used to build request pipeline

            //request delegate are configured using three Extension method 
            //use - its excuted itself first then pass you request to next componenet becausse internally its invoking next();
            //run -  its excuted itself and then terminate the execution that why its always placed in the last position of the pipeline 
            //map - its map a specific request url path to a middleware componet ------htts://Controllername/actionname 

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("Error");
            }

            app.MapControllers();

            app.Run(); //4
        }
    }
}
