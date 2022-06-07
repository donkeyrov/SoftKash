using Blazored.Toast;
using LoanMgt.UI.Areas.Identity;
using LoanMgt.UI.Data;
using LoanMgt.UI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanMgt.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")),ServiceLifetime.Transient);
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
            services.AddAuthorizationCore();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddSyncfusionBlazor();
            services.AddBlazoredToast();
            services.AddBlazorContextMenu();
            services.AddTransient<MenuRepository>();            
            services.AddTransient<CountryRepository>();
            services.AddTransient<ProvinceRepository>();
            services.AddTransient<TownRepository>();
            services.AddTransient<GenderRepository>();
            services.AddTransient<TitleRepository>();
            services.AddTransient<TransactionCodeRepository>();
            services.AddTransient<TransactionDetailsRepository>();
            services.AddTransient<TransactionRepository>();
            services.AddTransient<AccountRepository>();
            services.AddTransient<AccountTypeRepository>();
            services.AddTransient<SequenceRepository>();
            services.AddTransient<FileUpload>();
            services.AddTransient<BranchRepository>();
            services.AddTransient<CurrencyRepository>();
            services.AddTransient<BranchHolidayRepository>();
            services.AddTransient<DisbursementMethodRepository>();
            services.AddTransient<RepaymentCycleRpository>();
            services.AddTransient<CollateralTypeRepository>();
            services.AddTransient<OtherIncomeTypeRepository>();
            services.AddTransient<CollectorRepository>();
            services.AddTransient<FeeRepository>();
            services.AddTransient<LoanFeeRepository>();
            services.AddTransient<TaxTypeRepository>();
            services.AddTransient<AssetManagementTypeRepository>();
            services.AddTransient<UserRoleRepository>();
            services.AddTransient<RoleRepository>();
            services.AddTransient<LoanProductRepository>();
            services.AddTransient<InterestMethodRepository>();
            services.AddTransient<LoanInterestPeriodRepository>();
            services.AddTransient<LoanDurationRepository>();
            services.AddTransient<BorrowerRepository>();
            services.AddTransient<BorrowerGroupRepository>();
            services.AddTransient<BorrowerFileRepository>();
            services.AddTransient<GroupRepository>();
            services.AddTransient<WorkingStatusRepository>();
            services.AddTransient<LoanRepository>();
            services.AddTransient<TransactionTempRepository>();
            services.AddTransient<CollateralRepository>();
            services.AddTransient<ExpenseRepository>();
            services.AddTransient<ExpenseTypeRepository>();
            services.AddTransient<InvestorRepository>();
            services.AddTransient<OtherIncomeRepository>();
            services.AddTransient<OtherIncomeTypeRepository>();
            services.AddTransient<AttachmentFilesRepository>();
            services.AddTransient<LoanFileRepository>();
            services.AddTransient<GuarantorRepository>();
            services.AddTransient<GuarantorFileRepository>();
            services.AddTransient<UserRepository>();
            services.AddTransient<AccountSettingsRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTIwNDg4QDMxMzkyZTMzMmUzMFN6YXdUdWZxZVU1UFJ1dHNwVmkyTFVBNVRBaGlLVkFBazZ6RzRFeDFRZUk9");
            //Register Bold license
            Bold.Licensing.BoldLicenseProvider.RegisterLicense("EYMyDobfUIHK24dtm0sUuepcwGUPG4Xv/qxBuQwN/7s=");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseMiddleware<BlazorCookieLoginMiddleware<IdentityUser>>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");               
            });
        }
    }
}
