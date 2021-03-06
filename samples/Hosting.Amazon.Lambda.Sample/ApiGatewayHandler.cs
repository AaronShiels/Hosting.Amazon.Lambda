using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Hosting.Amazon.Lambda.Functions;
using Microsoft.Extensions.Logging;

namespace Hosting.Amazon.Lambda.Sample
{
    public class ApiGatewayFunction : BaseFunction<APIGatewayProxyRequest, APIGatewayProxyResponse>
    {
        private readonly ILogger<ApiGatewayFunction> _log;

        public ApiGatewayFunction(ILogger<ApiGatewayFunction> log)
        {
            _log = log;
        }

        protected override Task<APIGatewayProxyResponse> InvokeAsync(APIGatewayProxyRequest request, ILambdaContext context)
        {
            _log.LogInformation("Invoked request!");

            var response = new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = "Hello world!"
            };
            return Task.FromResult(response);
        }
    }
}