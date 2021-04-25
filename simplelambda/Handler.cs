using System;
using Amazon.Lambda.CloudWatchEvents.ScheduledEvents;
using Amazon.Lambda.Core;

namespace simplelambda{
 
    public class Handler
    {

        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public void Handle(ScheduledEvent cloudWatchEvent)
        {                        
            Console.WriteLine("Message: " + cloudWatchEvent.Source);            
        }

    }
}