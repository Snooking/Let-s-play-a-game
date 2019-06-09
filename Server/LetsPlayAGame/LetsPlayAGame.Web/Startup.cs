using LetsPlayAGame.BussinessLogic.Characters.QueryHandlers;
using LetsPlayAGame.Data;
using LetsPlayAGame.Data.Seeders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LetsPlayAGame
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<LetsPlayGameDbContext>(options => options.UseSqlServer(@"Server=DESKTOP-UU8VURO\SQLEXPRESS;Database=LetsPlayAGame;Integrated Security=True"));
            services.AddScoped<GetCharacterByIdQueryHandler, GetCharacterByIdQueryHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, LetsPlayGameDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            DatabaseSeeder.Seed(dbContext);

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
