using System;
using DNetUtils.Entities;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
/*
namespace DNetBotFunctions
{
    public static class ProcessActivity
    {
        [FunctionName("InboundActivityProcess")]
        [return: Table("ActivityTable")]
        public static ReceivedMessage InboundActivityProcess([QueueTrigger("discord-activity-inbound-queue")] CloudQueueMessage myQueueItem, ILogger log)
        {
            log.LogInformation($"Activity Queue trigger function processed: {myQueueItem}");

            ConvertedMessage message = DiscordConvert.DeSerializeObject(myQueueItem.AsString);
            return new ReceivedMessage(message);
        }
    }
}
*/