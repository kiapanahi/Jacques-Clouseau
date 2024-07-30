// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace KafkaRestProxy.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class ReplicaData : global::KafkaRestProxy.Client.Models.Resource, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The broker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::KafkaRestProxy.Client.Models.Relationship? Broker { get; set; }
#nullable restore
#else
        public global::KafkaRestProxy.Client.Models.Relationship Broker { get; set; }
#endif
        /// <summary>The broker_id property</summary>
        public int? BrokerId { get; set; }
        /// <summary>The cluster_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClusterId { get; set; }
#nullable restore
#else
        public string ClusterId { get; set; }
#endif
        /// <summary>The is_in_sync property</summary>
        public bool? IsInSync { get; set; }
        /// <summary>The is_leader property</summary>
        public bool? IsLeader { get; set; }
        /// <summary>The partition_id property</summary>
        public int? PartitionId { get; set; }
        /// <summary>The topic_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TopicName { get; set; }
#nullable restore
#else
        public string TopicName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Models.ReplicaData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::KafkaRestProxy.Client.Models.ReplicaData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KafkaRestProxy.Client.Models.ReplicaData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "broker", n => { Broker = n.GetObjectValue<global::KafkaRestProxy.Client.Models.Relationship>(global::KafkaRestProxy.Client.Models.Relationship.CreateFromDiscriminatorValue); } },
                { "broker_id", n => { BrokerId = n.GetIntValue(); } },
                { "cluster_id", n => { ClusterId = n.GetStringValue(); } },
                { "is_in_sync", n => { IsInSync = n.GetBoolValue(); } },
                { "is_leader", n => { IsLeader = n.GetBoolValue(); } },
                { "partition_id", n => { PartitionId = n.GetIntValue(); } },
                { "topic_name", n => { TopicName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::KafkaRestProxy.Client.Models.Relationship>("broker", Broker);
            writer.WriteIntValue("broker_id", BrokerId);
            writer.WriteStringValue("cluster_id", ClusterId);
            writer.WriteBoolValue("is_in_sync", IsInSync);
            writer.WriteBoolValue("is_leader", IsLeader);
            writer.WriteIntValue("partition_id", PartitionId);
            writer.WriteStringValue("topic_name", TopicName);
        }
    }
}