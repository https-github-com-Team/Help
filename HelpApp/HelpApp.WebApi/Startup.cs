using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using HelpApp.Core.Contracts;
using HelpApp.Core.Services;
using HelpApp.Infrastructure.Db;
using HelpApp.Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;




namespace HelpApp.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            string assemblyName = typeof(HelpDbContext).Namespace;

            services.AddDbContext<HelpDbContext>(options =>

                options.UseSqlServer(Configuration["Db:ConnectionString"], b => b.MigrationsAssembly("HelpApp.WebApi"))
           );

           services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Web API - V1",
                        Version = "v1",
                        Contact = new OpenApiContact
                        {
                            Name = "Help team",
                            Email = "elshadzr@code.edu.az"
                        }
                    });
                c.SwaggerDoc("v2",
                    new OpenApiInfo
                    {
                        Title = "Web API - V2",
                        Version = "v2",
                        Contact = new OpenApiContact
                        {
                            Name = "Help team",
                            Email = "elshadzr@code.edu.az"
                        }
                    });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                //... and tell Swagger to use those XML comments.
                c.IncludeXmlComments(xmlPath);

                // c.OperationFilter<SwaggerFileOperationFilter>();

            });


            #region Servises Registration

            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISubCategoryService, SubCategoryService>();




            #endregion

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
            app.UseSwagger();
            app.UseStaticFiles();
            app.UseSwaggerUI(c =>

            {
                c.RoutePrefix = "";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "My API V2");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger XML Api Demo v1");
                c.SwaggerEndpoint("/swagger/v2/swagger.json", "Swagger XML Api Demo v1");

                c.DocumentTitle = "Help WebApi";

            });
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
