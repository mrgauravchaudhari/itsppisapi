
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using itsppisapi.Data;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using itsppisapi.Helpers;

namespace itsppisapi
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
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
          .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.AddCors();

            // login and registration repository
            services.AddScoped<IAuthRepository, AuthRepository>();

            // reset and change password repository
            services.AddScoped<ResetRepository>();
            services.AddScoped<ResetPasswordRepository>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII
             .GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };
            });

            // layouts: tree menu repository
            services.AddScoped<TreeMenuRepository>();

            // admin : master repository
            services.AddScoped<PGS010Repository>();
            services.AddScoped<PGS010_2Repository>();
            // services.AddScoped<PGS011Repository>();
            services.AddScoped<PGS012Repository>();
            // services.AddScoped<PGS013Repository>();

            // global
            services.AddScoped<ListDepartmentRepository>();
            services.AddScoped<ListUserRepository>();
            services.AddScoped<ListReportNameRepository>();

            // screen : lab : Repository
            services.AddScoped<PLS001Repository>();
            services.AddScoped<PLS002Repository>();
            services.AddScoped<PLS003Repository>();
            services.AddScoped<PLS004Repository>();
            services.AddScoped<PLS005Repository>();
            services.AddScoped<PLS006Repository>();
            services.AddScoped<PLS007Repository>();
            services.AddScoped<PLS008Repository>();
            services.AddScoped<PLS009Repository>();
            services.AddScoped<PLS201Repository>();
            services.AddScoped<PLS202Repository>();
            services.AddScoped<PLS203Repository>();
            services.AddScoped<PLS204Repository>();

            // report : lab : Repository
            services.AddScoped<PLR001ReportRepository>();
            services.AddScoped<PLR002ReportRepository>();
            services.AddScoped<PLR003ReportRepository>();
            services.AddScoped<PLR005ReportRepository>();
            services.AddScoped<PLR006ReportRepository>();
            services.AddScoped<PLR201ReportRepository>();
            services.AddScoped<PLR202ReportRepository>();
            services.AddScoped<PLR203ReportRepository>();
            services.AddScoped<PLR204ReportRepository>();
            services.AddScoped<PLR205ReportRepository>();

            // screen : Electrical3 : Repository
            services.AddScoped<_3MVASubConditionRepository>();
            services.AddScoped<CommunicationRepository>();
            services.AddScoped<MainConditionRepository>();
            services.AddScoped<OffsiteSubConditionRepository>();
            services.AddScoped<SPGSubConditionRepository>();
            
            services.AddScoped<PES002Repository>();
            services.AddScoped<PES301Repository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(bulder =>
                {
                    bulder.Run(async context =>
                    {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        var error = context.Features.Get<IExceptionHandlerFeature>();
                        if (error != null)
                        {
                            context.Response.AddApplicationError(error.Error.Message);
                            await context.Response.WriteAsync(error.Error.Message);
                        }
                    });
                });
                // app.UseHsts();
            }

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
