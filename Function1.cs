using Microsoft.Azure.EventHubs;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.Text;
using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;
namespace IoTHubTrigger_Azure_Function_and_Azure_IoT_Hub
{
    public static class IoTHubFunc
    {
        [FunctionName("IoTHubData")]
        public static void Run(
            [IoTHubTrigger("messages/events", Connection = "IoTHubTriggerConnection", ConsumerGroup = "FuncGroup")]EventData message,
            ILogger log)
        {
            log.LogInformation($"C# IoT Hub trigger function processed a message: {Encoding.UTF8.GetString(message.Body.Array)}");
        }
    }
}