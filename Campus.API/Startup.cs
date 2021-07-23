using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Campus.Business.Campus.Services;
using Campus.Business.Campus.Services.ReviewsS;
using Campus.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace Campus.API
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
			services.AddCors();
			services.AddControllers();
				//.AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

			services.AddDbContext<CampusContext>(config =>
			{
				config.UseSqlServer(Configuration.GetConnectionString("Campus"));
			});
			services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ICommentService, ICommentService>();
            services.AddScoped<IReviewService, IReviewService>();
			services.AddSwaggerGen();
            //.AddMvc();
            //.AddFluentValidation();
        }
		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Campus.API v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
			using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
			var dbContext = serviceScope.ServiceProvider.GetService<CampusContext>();
			dbContext.Database.EnsureCreated();
		}
	}
}
