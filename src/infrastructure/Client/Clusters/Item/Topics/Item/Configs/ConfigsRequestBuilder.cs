// <auto-generated/>
using KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.Item;
using KafkaRestProxy.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs
{
    /// <summary>
    /// Builds and executes requests for operations under \clusters\{cluster_id}\topics\{topic_name}\configs
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ConfigsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KafkaRestProxy.Client.clusters.item.topics.item.configs.item collection</summary>
        /// <param name="position">The configuration parameter name.</param>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.Item.WithNameItemRequestBuilder"/></returns>
        public global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.Item.WithNameItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("name", position);
                return new global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.Item.WithNameItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.ConfigsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/topics/{topic_name}/configs", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.ConfigsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ConfigsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/topics/{topic_name}/configs", rawUrl)
        {
        }
        /// <summary>
        /// [![Generally Available](https://img.shields.io/badge/Lifecycle%20Stage-Generally%20Available-%2345c6e8)](#section/Versioning/API-Lifecycle-Policy)Return the list of configuration parameters that belong to the specified topic.
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Models.TopicConfigDataList"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 404 status code</exception>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::KafkaRestProxy.Client.Models.TopicConfigDataList?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::KafkaRestProxy.Client.Models.TopicConfigDataList> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
                { "401", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
                { "404", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
                { "5XX", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::KafkaRestProxy.Client.Models.TopicConfigDataList>(requestInfo, global::KafkaRestProxy.Client.Models.TopicConfigDataList.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [![Generally Available](https://img.shields.io/badge/Lifecycle%20Stage-Generally%20Available-%2345c6e8)](#section/Versioning/API-Lifecycle-Policy)Return the list of configuration parameters that belong to the specified topic.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.ConfigsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.ConfigsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KafkaRestProxy.Client.Clusters.Item.Topics.Item.Configs.ConfigsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class ConfigsRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
