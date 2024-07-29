// <auto-generated/>
using KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.Item;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions
{
    /// <summary>
    /// Builds and executes requests for operations under \clusters\{cluster_id}\consumer-groups\{consumer_group_id}\consumers\{consumer_id}\assignments\{topic_name}\partitions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class PartitionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the KafkaRestProxy.Client.clusters.item.consumerGroups.item.consumers.item.assignments.item.partitions.item collection</summary>
        /// <param name="position">The partition ID.</param>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.Item.WithPartition_ItemRequestBuilder"/></returns>
        public global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.Item.WithPartition_ItemRequestBuilder this[int position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("partition_id", position);
                return new global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.Item.WithPartition_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>Gets an item from the KafkaRestProxy.Client.clusters.item.consumerGroups.item.consumers.item.assignments.item.partitions.item collection</summary>
        /// <param name="position">The partition ID.</param>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.Item.WithPartition_ItemRequestBuilder"/></returns>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.Item.WithPartition_ItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("partition_id", position);
                return new global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.Item.WithPartition_ItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.PartitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PartitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/consumer-groups/{consumer_group_id}/consumers/{consumer_id}/assignments/{topic_name}/partitions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Clusters.Item.ConsumerGroups.Item.Consumers.Item.Assignments.Item.Partitions.PartitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PartitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/clusters/{cluster_id}/consumer-groups/{consumer_group_id}/consumers/{consumer_id}/assignments/{topic_name}/partitions", rawUrl)
        {
        }
    }
}
