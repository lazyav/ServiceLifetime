
using Microsoft.Extensions.DependencyInjection;

namespace DIExample.Interfaces
{
    public interface IReportServiceLifetime
    {
        Guid Id { get; }
        ServiceLifetime Lifetime { get; }
    }
}
