// <auto-generated/>
using KafkaRestProxy.Client.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace KafkaRestProxy.Client.Clusters.Item.AclsBatch
{
    /// <summary>
    /// Builds and executes requests for operations under \clusters\{cluster_id}\acls:batch
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class AclsBatchRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.AclsBatchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AclsBatchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/acls:batch", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.AclsBatchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AclsBatchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/acls:batch", rawUrl)
        {
        }
        /// <summary>
        /// [![Generally Available](https://img.shields.io/badge/Lifecycle%20Stage-Generally%20Available-%2345c6e8)](#section/Versioning/API-Lifecycle-Policy)Create ACLs.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 400 status code</exception>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 401 status code</exception>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 403 status code</exception>
        /// <exception cref="global::KafkaRestProxy.Client.Models.Error">When receiving a 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.CreateAclRequestDataListPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.CreateAclRequestDataListPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "400", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
                { "401", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
                { "403", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
                { "5XX", global::KafkaRestProxy.Client.Models.Error.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// [![Generally Available](https://img.shields.io/badge/Lifecycle%20Stage-Generally%20Available-%2345c6e8)](#section/Versioning/API-Lifecycle-Policy)Create ACLs.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.CreateAclRequestDataListPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.CreateAclRequestDataListPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.AclsBatchRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.AclsBatchRequestBuilder WithUrl(string rawUrl)
        {
            return new global::KafkaRestProxy.Client.Clusters.Item.AclsBatch.AclsBatchRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
        public partial class AclsBatchRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
