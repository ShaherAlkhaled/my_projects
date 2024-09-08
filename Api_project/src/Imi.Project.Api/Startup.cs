using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Services;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api
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

            services.AddDbContext<ApplicationDbContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
            }).
            AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Imi.Project.Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme."

                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });

            });
                services.AddAuthentication(option =>
                {
                    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                })
               .AddJwtBearer(jwtOptions =>
               {
                   jwtOptions.TokenValidationParameters = new TokenValidationParameters()
                   {
                       ValidateActor = true,
                       ValidateAudience = true,
                       ValidateLifetime = true,
                       ValidIssuer = Configuration["JWTConfiguration:Issuer"],
                       ValidAudience = Configuration["JWTConfiguration:Audience"],
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTConfiguration:SigningKey"]))
                   };

               });

            services.AddCors();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFishRepository, FishRepository>();
            services.AddScoped<IOriginCountryRepository, OriginCountryRepository>();
            services.AddScoped<IFishProcessingRepository, FishProcessingRepository>();
            services.AddScoped<IFishService, FishService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IFishProcessingService, FishProcessingService>();
            services.AddScoped<IOriginCountryService, OriginCountryService>();


            services.AddHttpContextAccessor();

            services.AddAuthorization(options =>
            {

                options.AddPolicy("CanRead", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        if (context.User.IsInRole("Admin"))
                        {
                            return true;
                        }
                        else
                        {
                            return (context.User.HasClaim("HasApprovedTermsAndConditions", true.ToString()));
                        }
                    });
                });

                options.AddPolicy("CanEdit", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        if (context.User.IsInRole("Admin"))
                        {
                            return true;
                        }
                        else
                        {
                            return (context.User.IsInRole("User") && context.User.HasClaim("HasApprovedTermsAndConditions", true.ToString()));
                        }
                    });
                });

                options.AddPolicy("CanCreate", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        if (context.User.IsInRole("Admin"))
                        {
                            return true;
                        }
                        else
                        {
                            return (context.User.IsInRole("User") && context.User.HasClaim("HasApprovedTermsAndConditions", true.ToString()));
                        }
                    });
                });

                options.AddPolicy("CanDelete", policy =>
                {
                    policy.RequireRole("Admin");
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Imi.Project.Api v1"));
                app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());


            }
            app.UseStaticFiles();


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
