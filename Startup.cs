using System.Net;
using System.Text;
using itsppisapi.Data;
using itsppisapi.Helpers;
using itsppisapi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;

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

            // send emails
            services.AddTransient<EmailHelper>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.AddCors();

            // Form Access repository
            services.AddScoped<FormAccessRepository>();

            // login and registration repository
            services.AddScoped<IAuthRepository, AuthRepository>();

            // reset and change password repository
            services.AddScoped<ResetRepository>();
            services.AddScoped<ResetPasswordRepository>();

            // jwt token security key validate
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
            services.AddScoped<PGS011Repository>();
            services.AddScoped<PGS012Repository>();
            services.AddScoped<PGS013Repository>();
            services.AddScoped<PGS006Repository>();
            services.AddScoped<PGS007Repository>();
            services.AddScoped<PGS017Repository>();

            // global 
            services.AddScoped<ListDepartmentRepository>();
            services.AddScoped<ListChemicalRepository>();
            services.AddScoped<ListUserRepository>();
            services.AddScoped<ListReportNameRepository>();
            services.AddScoped<ListWagonDescRepository>();
            services.AddScoped<ListWorkDescRepository>();
            services.AddScoped<ListBreakDownRepository>();
            services.AddScoped<ListTripTypeRepository>();
            services.AddScoped<ListContractorRepository>();

            // global function
            services.AddScoped<FuncNCVRepository>();
            services.AddScoped<FuncNcvOnuNgRepository>();

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

            // screen : Urea : Repository
            services.AddScoped<BreakdownMasterRepository>();
            services.AddScoped<MaintenanceDeptRepository>();
            services.AddScoped<TagMasterRepository>();
            services.AddScoped<TripMasterRepository>();
            services.AddScoped<PUS002Repository>();
            services.AddScoped<PUS003Repository>();
            services.AddScoped<PUS004Repository>();
            services.AddScoped<PUS201Repository>();
            services.AddScoped<PUS202Repository>();
            services.AddScoped<PUS203Repository>();
            services.AddScoped<PUS204Repository>();
            services.AddScoped<PUS301Repository>();
            services.AddScoped<PUS302Repository>();

            // screen : Bagging : Repository
            services.AddScoped<BagTypeRepository>();
            services.AddScoped<ContractorRepository>();
            services.AddScoped<DefectTypeRepository>();
            services.AddScoped<WagonTypeRepository>();
            services.AddScoped<WorkRepository>();
            services.AddScoped<PBS007Repository>();
            services.AddScoped<PBS008Repository>();
            services.AddScoped<PBS011Repository>();
            services.AddScoped<PBS202Repository>();
            services.AddScoped<PBS203Repository>();
            services.AddScoped<PBS204Repository>();
            services.AddScoped<ContractorDemurrageRepository>();
            services.AddScoped<ContrRKWgnDltsRepository>();
            services.AddScoped<RakeLoadingDeptRepository>();
            services.AddScoped<RakeWagonDltsRepository>();
            services.AddScoped<BagDailyDltsRepository>();
            services.AddScoped<BagDltsRepository>();
            services.AddScoped<PBS210Repository>();
            services.AddScoped<PBS212Repository>();

            // screen : Ammonia : Repository
            services.AddScoped<PAS001Repository>();
            services.AddScoped<PAS002Repository>();
            services.AddScoped<PAS003Repository>();
            services.AddScoped<PAS004Repository>();
            services.AddScoped<PAS005Repository>();
            services.AddScoped<PAS201Repository>();
            services.AddScoped<PAS202Repository>();
            services.AddScoped<PAS203Repository>();
            services.AddScoped<PAS204Repository>();
            services.AddScoped<PAS205Repository>();
            services.AddScoped<PAS207Repository>();
            services.AddScoped<PAS208Repository>();
            services.AddScoped<PAS209Repository>();
            services.AddScoped<PAS211Repository>(); // cooling Tower performance GP-II
            services.AddScoped<PAS212Repository>();
            services.AddScoped<PAS213Repository>();
            services.AddScoped<PAS214Repository>();
            services.AddScoped<PAS215Repository>();
            services.AddScoped<PAS216Repository>();
            services.AddScoped<PAS301Repository>();
            services.AddScoped<PAS302Repository>();

            // screen : Onu : Repository
            services.AddScoped<POS001Repository>();
            services.AddScoped<POS002Repository>();
            services.AddScoped<POS003Repository>();
            services.AddScoped<POS004Repository>();
            services.AddScoped<POS005Repository>();
            services.AddScoped<POS006Repository>();
            services.AddScoped<POS007Repository>();
            services.AddScoped<POS008Repository>();
            services.AddScoped<POS009Repository>();
            services.AddScoped<POS010Repository>();
            services.AddScoped<POS011Repository>(); // cooling Tower performance GP-I
            services.AddScoped<POS012Repository>();
            services.AddScoped<POS013Repository>();
            services.AddScoped<POS014Repository>();
            services.AddScoped<POS015Repository>();
            services.AddScoped<POS019Repository>();
            services.AddScoped<POS301Repository>();
            services.AddScoped<POS020Repository>();

            // screen : SSP : Repository
            services.AddScoped<PSS001Repository>();
            services.AddScoped<PSS004Repository>();

            // screen : TSE : Repository
            services.AddScoped<PTS006Repository>();
            services.AddScoped<PTS008Repository>();
            services.AddScoped<PTS227Repository>();
            services.AddScoped<PTS228Repository>();
            services.AddScoped<PTS229Repository>();
            services.AddScoped<PTS023Repository>();

            // screen : Management : Repository
            services.AddScoped<PMS201Repository>();
            services.AddScoped<PMS212Repository>();

            // screen : Balances : Repository
            services.AddScoped<PGS001Repository>();
            services.AddScoped<PGS002Repository>();
            services.AddScoped<PGS003Repository>();
            services.AddScoped<PGS004Repository>();
            services.AddScoped<PGS005Repository>();
            services.AddScoped<PGS018Repository>();
            services.AddScoped<PGS201Repository>();
            services.AddScoped<PGS202Repository>();
            services.AddScoped<PGS203Repository>();
            services.AddScoped<PGS204Repository>();
            services.AddScoped<PGS205Repository>();
            services.AddScoped<PGS207Repository>();

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
                app.UseHsts();
            }

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}