using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HealthCheckMicro
{
    public class HealthCheckWithArgs : IHealthCheck
    {
        public int I { get; set; }
        public string S { get; set; }
        public HealthCheckWithArgs(int i , string s)
        {
            I = i;
            S = s;
        }
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var result = true;
            if (result)
            {
                return Task.FromResult(HealthCheckResult.Healthy($"Healthy with S = {S} and I = {I}"));
            }
            return Task.FromResult(new HealthCheckResult(HealthStatus.Unhealthy, $"it failed with S = {S} and I = {I}"));
        }
    }
}
