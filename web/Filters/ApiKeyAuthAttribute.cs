/*using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace web.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

    public class ApiKeyAuthAttribute : Attribute, IAsyncActionFIlter
    {
        private const string ApiKeyHeaderName = "ApiKey";

        public async Task OnActionExecusionAsync(ActionExecutinContext contex, ActionExecutionDelegate next)
        {
            

            if(context.HttpContext.Request.Headers.TryGetValue(ApiKeyHeaderName, out var potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;

            }

            var conguration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = configuration.GetValue<string>("ApiKey");

            if(!apiKey.Equals(potentialApiKey))
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            
            await next();

           


        }


    }
}*/