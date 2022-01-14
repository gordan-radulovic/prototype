using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace web.Data{
    public class Startup{
        public void ConfigureServices(IServiceCollection services){
            services.AddMvc();

            services.AddDbContext<PostContext>();

            //services.AddIdentity<User, IdentityRole
        }

        public void Configure (IApplicationBuilder app){
            app.UseDeveloperExceptionPage();

            app.UseMvcWithDefaultRoute();

            app.UseStaticFiles();
        }
    }
}
