using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Identity.PoC.B2C.API.ClaimsEnrichment
{
    public static class ClaimsEnrichment
    {
        [FunctionName("ClaimsEnrichment")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            log.LogInformation($"Request Body: {requestBody}");

            //if (ValidateToken(req))
            if (true)
            {
                //Get Extensions App Id. That app registration was created when your B2C tenant was created - you'll need this Client (App) ID 
                string customAttributeAppId = Environment.GetEnvironmentVariable("extensions-app-id");
                customAttributeAppId = customAttributeAppId.Replace("-", "");

                var responseProperties = new Dictionary<string, object>
              {
                { $"extension_{customAttributeAppId}_CustomClaimRole", "Administrator" },
                { $"extension_{customAttributeAppId}_CustomInputClaims",requestBody }
              };

                log.LogInformation($"Response Body: {JsonConvert.SerializeObject(responseProperties)}");

                return new JsonResult(responseProperties) { StatusCode = 200 };
            }
            else
            {
                return new UnauthorizedResult();
            }
        }

        private static bool ValidateToken(HttpRequest req)
        {
            string userName = Environment.GetEnvironmentVariable("ApiUserName");
            string secret = Environment.GetEnvironmentVariable("ApiPassword");

            Environment.GetEnvironmentVariable("Password");

            string authHeader = req.Headers["Authorization"].ToString();

            if (String.IsNullOrEmpty(authHeader))
            {
                return false;
            }
            else if (!authHeader.StartsWith("Basic "))
            {
                return false;
            }
            else
            {
                var inputs = authHeader.Split(" ");
                if (inputs == null || inputs.Count() != 2)
                {
                    return false;
                }
                else
                {
                    string decoded = Encoding.UTF8.GetString(Convert.FromBase64String(inputs[1]));
                    if (String.IsNullOrEmpty(decoded))
                    {
                        return false;
                    }
                    else
                    {
                        var values = decoded.Split(":");
                        if (values == null || values.Count() != 2)
                        {
                            return false;
                        }
                        else
                        {
                            if (string.Compare(values[0], userName, true) != 0)
                            {
                                return false;
                            }
                            else if (string.Compare(values[1], secret, false) != 0)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }

                        }
                    }
                }
            }
        }
    }
}
