using System.Threading;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Hosting;

namespace mediadevoted.api.Services.MassTransit
{
    public class BusService : IHostedService
    {
        private readonly IBusControl _busControl;

        public BusService(IBusControl busControl) => _busControl = busControl;

        public Task StartAsync(CancellationToken cancellationToken) => _busControl.StartAsync(cancellationToken);

        public Task StopAsync(CancellationToken cancellationToken) => _busControl.StopAsync(cancellationToken);
    }
}
