namespace BackendAcademico.Api
{
    using BackendAcademico.Core.CustomEntities;
    using BackendAcademico.Core.Interfaces.Data;
    using BackendAcademico.Core.Interfaces.PreInscripcion;
    using BackendAcademico.Core.Interfaces.Test;
    using BackendAcademico.Core.Interfaces.Validators.PreInscripcion;
    using BackendAcademico.Core.Interfaces.Validators.Test;
    using BackendAcademico.Core.Services.PreInscripcion;
    using BackendAcademico.Core.Services.Test;
    using BackendAcademico.Infrastructure.Data;
    using BackendAcademico.Infrastructure.Filters;
    using BackendAcademico.Infrastructure.Repositories.PreInscripcion;
    using BackendAcademico.Infrastructure.Repositories.Test;
    using BackendAcademico.Infrastructure.Validators.Repositories;
    using FluentValidation.AspNetCore;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Serilog;

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

            services.AddControllers(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
            }).AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });
            services.AddTransient<IConeccion, Coneccion>();
            services.AddTransient<ITestRepository, TestRepository>();
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<ITestRepositoryVal, TestRepositoryVal>();
            services.AddTransient<IPreInscripcionRepository, PreInscripcionRepository>();
            services.AddTransient<IPreInscripcionService, PreInscripcionService>();
            services.AddTransient<IPreInscripcionRepositoryVal, PreInscripcionRepositoryVal>();

            services.AddMvc().AddFluentValidation(s =>
            {
                s.RegisterValidatorsFromAssemblyContaining<Startup>();
                s.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
            });

            services.Configure<PaginationOptions>(options => Configuration.GetSection("Pagination").Bind(options));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
