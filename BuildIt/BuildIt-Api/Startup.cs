using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace BuildIt_Api
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
            services.AddDbContext<EFContext>(options => 
                options.UseSqlServer(Configuration.GetSection("ConnectionString:DefaultConnection").Value));

            // Injeção de dependências
            services.AddScoped<EFContext, EFContext>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<ICaixaEletronicaRepository, CaixaEletronicaRepository>();
            services.AddTransient<INotasRepository, NotasRepository>();
            services.AddTransient<ISaqueRepository, SaqueRepository>();
            services.AddTransient<ITipoClienteRepository, TipoClienteRepository>();
            services.AddTransient<INotasSugeridaRepository, NotasSugeridaRepository>();

            services.AddCors(options => options
                .AddPolicy("buildItPolicy", p => p
                    .SetIsOriginAllowedToAllowWildcardSubdomains()
                    .WithOrigins("*")
                    .AllowAnyMethod()
                    .AllowAnyHeader())
            );

            services.AddOpenApiDocument(config => { config.DocumentName = "OpenApi3"; });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseCors("buildItPolicy");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseOpenApi((config) => { config.DocumentName = "Build IT API";  });

            app.UseSwaggerUi3((config) => config.DocumentTitle = "Build IT API");
            app.UseReDoc();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
