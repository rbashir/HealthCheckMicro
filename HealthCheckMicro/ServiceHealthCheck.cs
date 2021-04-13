using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthCheckMicro
{
    public class ServiceHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var healthCheckResult = true;
            if (healthCheckResult)
            {
                return Task.FromResult(HealthCheckResult.Healthy("A healthy result."));
            }
            return Task.FromResult(new HealthCheckResult(context.Registration.FailureStatus, "An unhealthey result"));
        }
    }
}
