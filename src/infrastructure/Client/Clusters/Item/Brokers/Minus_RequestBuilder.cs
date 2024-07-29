// <auto-generated/>
using KafkaRestProxy.Client.Clusters.Item.Brokers.Configs;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace KafkaRestProxy.Client.Clusters.Item.Brokers
{
    /// <summary>
    /// Builds and executes requests for operations under \clusters\{cluster_id}\brokers\-
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class Minus_RequestBuilder : BaseRequestBuilder
    {
        /// <summary>The configs property</summary>
        public global::KafkaRestProxy.Client.Clusters.Item.Brokers.Configs.ConfigsRequestBuilder Configs
        {
            get => new global::KafkaRestProxy.Client.Clusters.Item.Brokers.Configs.ConfigsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.Brokers.Minus_RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Minus_RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/brokers/-", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.Brokers.Minus_RequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Minus_RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/brokers/-", rawUrl)
        {
        }
    }
}
