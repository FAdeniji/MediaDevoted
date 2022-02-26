using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using MassTransit.Azure.ServiceBus.Core;
using Microsoft.Extensions.Configuration;

namespace mediadevoted.api.Services
{
    public class MassTransitConfig
    {
        private static void ConfigureMassTransitAzureServiceBus(IBusRegistrationContext busRegContext, IServiceBusBusFactoryConfigurator busConfig)
        {
            var configuration = busRegContext.GetRequiredService<IConfiguration>();
            var azureServiceBusConfig = configuration.GetSection("AzureServiceBus");

            // specify the message FlightOrder to be sent to a specific topic
            busConfig.Host(azureServiceBusConfig["ConnectionString"], hostConfig =>
            {
                // This is optional, but you can specify the protocol to use.
                //hostConfig.TransportType = TransportType.AmqpWebSockets;
            });

            busConfig.MessageTopology.SetEntityNameFormatter(busConfig.MessageTopology.EntityNameFormatter);
            busConfig.ConfigureEndpoints(busRegContext);
        }

    }
}
