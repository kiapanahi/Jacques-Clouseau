using KafkaFlow;

using Microsoft.Extensions.Logging;

namespace Clouseau.Infrastructure.Kafka.KafkaFlow.Producers;

public interface ICbtEventProducer
{
    Task PublishEvent();
}

internal sealed class CbtEventProducer : ICbtEventProducer
{
    private readonly IMessageProducer<CbtEventProducer> _messageProducer;
    private readonly ILogger<CbtEventProducer> _logger;

    public CbtEventProducer(IMessageProducer<CbtEventProducer> messageProducer, ILogger<CbtEventProducer> logger)
    {
        _messageProducer = messageProducer;
        _logger = logger;
    }

    private static SchemaRegistry.LogLevel GetRandomLogLevel()
    {
        var values = Enum.GetValues<SchemaRegistry.LogLevel>();
        var randomIndex = Random.Shared.Next(values.Length);
        return values[randomIndex];
    }

    public async Task PublishEvent()
    {
        var result = await _messageProducer.ProduceAsync(
            messageKey: Guid.NewGuid().ToString(),
            messageValue: new SchemaRegistry.AvroLogMessage
            {
                Severity = GetRandomLogLevel()
            })
            .ConfigureAwait(false);

        _logger.LogInformation(result.ToString());
    }
}
