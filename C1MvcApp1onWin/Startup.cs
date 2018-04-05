using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace C1MvcApp1onWin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            C1.Web.Mvc.LicenseManager.Key = "c1v01wqbCvsOSw5PCisO/xJBCw43EqsSwxYd8wr7Fq8K3ecS0xLvEhMS2w4vCv2l7w6bDpMK6wpLCq8WexYLCuMWKwqDCqMOqwq/ChnvEqcOEw7nEgMSswoPCpcWmw4F7w6Q7w5TCp8KxxJLFg8KywpfCiUbFgcWSxInDr8WFxKXEsGzDgXrCvMSHW8S6blvEtF3CkcO/xY/Dv1zEq8SHxJTCmH7EmmDDs8KSxYtzwq3EoMK0w6XFjcKMwoDDuW3Cn8Oaw7TFnsS0w5rCjl7DkMOQw75wwobFg8KOwrHCrcO0w7/DhsKhxIPCmMSqw4XEjcKmRXTEj8O2fsK8w47CisOI";
            C1.Web.Mvc.Finance.LicenseManager.Key = "c1v01w6zFv8OGxaJDw5xnw77Ci3HFqsWaacSdxLfDgcWQxJrDh0zEhsO4wpg4eH/CgcWNxYTEosKEbMKPwoTDpMOTw4nDkcSUxJPCssWVxJdePMKVwpbDqsKSxITCjsS8xIbDnsOFxKLEg8OqxIPEusOPwoc5w4h5w4XCg8Wja3vEm8KmxLjDrMSawpbCqn3Dg8OpZcOEwobEtFXDpcKgwrXDrcOBR8S9UMSUdsSBScOuwplZwq7CncWEwpxvxLHFnMOIR8StwpJvxILEiMOLf8Snw7jEjsSWwoXConjEmcKnxYDChm5sw7Zyw51+wpHCrWLCtcKJw5LCtsSEw7XCpsSewqrCpMKXwoF7xKnDn8OM";
            C1.Web.Mvc.Sheet.LicenseManager.Key = "c1v01wonDrMaHw6LCicO7xLLCoMKjw7HFq8KnwqvEg8SbxLbFh3p3wp1sxaPFgmxYxYvFncSrwp/FisKcxKrCoMKxwrPDgsOVw5PDg8OJwrlzxJXCvMK4wq3DkMKDw7zEm8SAxZHEnsOJw5rFgcOzeMKAxJPDsMOVxYHEiFRaxKjDk1LEicOQxZTEpULDssK0w7rCucSUw7vDpcKLwrnEs8S4ccOhw6nEtcWsYcK5w5nEqsOvwoHElcO5xIrFgsK9w6rEsMOvw4HCmMSPxIvCjcKCxJzDkcKexIllwpPCo8KdwqPEucKZxJLFhcWBP8SdxLvEvsOewrvDocWVw5lLxKDEksS/w6DDiMKZw5PDnk3DosSLasSBe13CssKnw5PClsK7";
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
