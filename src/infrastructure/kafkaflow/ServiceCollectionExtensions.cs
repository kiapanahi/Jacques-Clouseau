using Clouseau.Infrastructure.Kafka.KafkaFlow.Producers;

using Confluent.SchemaRegistry.Serdes;

using KafkaFlow;

using Microsoft.Extensions.DependencyInjection;

namespace Clouseau.Infrastructure.Kafka.KafkaFlow;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddClouseauKafka(this IServiceCollection services)
    {
        services.AddScoped<ICbtEventProducer, CbtEventProducer>();

        services.AddKafka(kafka => kafka
            .UseConsoleLog()
            .AddCluster(cluster => cluster
                .WithName("local-cluster")
                .WithBrokers(["localhost:29092,localhost:29094,localhost:29096"])
                .WithSchemaRegistry(config => config.Url = "http://localhost:8081")
                .CreateTopicIfNotExists("cbt", 1, 1)
                .AddProducer<CbtEventProducer>(producer => producer
                        .DefaultTopic("cbt")
                        .AddMiddlewares(middlewares => middlewares
                            .AddSchemaRegistryAvroSerializer(new AvroSerializerConfig()
                            {
                                SubjectNameStrategy = Confluent.SchemaRegistry.SubjectNameStrategy.TopicRecord
                            })
                            )
                        )
                )
            );

        return services;
    }
}
