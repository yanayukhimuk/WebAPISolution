using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using WebAPIProject.Models;

namespace WebAPIProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var startup = new Startup(builder.Configuration);
            startup.ConfigureServices(builder.Services); 
            var app = builder.Build();
            startup.Configure(app, builder.Environment);
        }
    }
}