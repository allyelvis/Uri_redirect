using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

public static class RedirectFunction
{
    [FunctionName("Redirect")]
    public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        string redirectUrl = "https://sokoni.bi"; // Replace with your desired redirect URL

        log.LogInformation($"Redirecting to: {redirectUrl}");

        return new RedirectResult(redirectUrl, true);
    }
}
