using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace Clouseau.ServiceDefaults;

public static class Diagnostics
{
    public const string ServiceName = "clouseau-tracker";
    public static readonly string SystemVersion = typeof(Diagnostics).Assembly.GetName().Version!.ToString(3);

    public static readonly ActivitySource ActivitySource = new(ServiceName, SystemVersion);
    public static readonly Meter Meter = new(ServiceName, SystemVersion);
}
