using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

public static class MyTimerFunction
{
    [FunctionName("MyTimerFunction")]
    public static void Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer, ILogger log)
    {
        // This function will run every 5 minutes (when the minutes are divisible by 5).
        log.LogInformation($"C# Timer trigger executed at: {DateTime.Now}");
    }
}
