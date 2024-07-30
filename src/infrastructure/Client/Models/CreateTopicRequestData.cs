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
    public partial class CreateTopicRequestData : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The configs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::KafkaRestProxy.Client.Models.CreateTopicRequestData_configs>? Configs { get; set; }
#nullable restore
#else
        public List<global::KafkaRestProxy.Client.Models.CreateTopicRequestData_configs> Configs { get; set; }
#endif
        /// <summary>The partitions_count property</summary>
        public int? PartitionsCount { get; set; }
        /// <summary>The replicas_assignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::KafkaRestProxy.Client.Models.CreateTopicRequestData_replicas_assignments? ReplicasAssignments { get; set; }
#nullable restore
#else
        public global::KafkaRestProxy.Client.Models.CreateTopicRequestData_replicas_assignments ReplicasAssignments { get; set; }
#endif
        /// <summary>The replication_factor property</summary>
        public int? ReplicationFactor { get; set; }
        /// <summary>The topic_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TopicName { get; set; }
#nullable restore
#else
        public string TopicName { get; set; }
#endif
        /// <summary>The validate_only property</summary>
        public bool? ValidateOnly { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Models.CreateTopicRequestData"/> and sets the default values.
        /// </summary>
        public CreateTopicRequestData()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Models.CreateTopicRequestData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KafkaRestProxy.Client.Models.CreateTopicRequestData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KafkaRestProxy.Client.Models.CreateTopicRequestData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "configs", n => { Configs = n.GetCollectionOfObjectValues<global::KafkaRestProxy.Client.Models.CreateTopicRequestData_configs>(global::KafkaRestProxy.Client.Models.CreateTopicRequestData_configs.CreateFromDiscriminatorValue)?.AsList(); } },
                { "partitions_count", n => { PartitionsCount = n.GetIntValue(); } },
                { "replicas_assignments", n => { ReplicasAssignments = n.GetObjectValue<global::KafkaRestProxy.Client.Models.CreateTopicRequestData_replicas_assignments>(global::KafkaRestProxy.Client.Models.CreateTopicRequestData_replicas_assignments.CreateFromDiscriminatorValue); } },
                { "replication_factor", n => { ReplicationFactor = n.GetIntValue(); } },
                { "topic_name", n => { TopicName = n.GetStringValue(); } },
                { "validate_only", n => { ValidateOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::KafkaRestProxy.Client.Models.CreateTopicRequestData_configs>("configs", Configs);
            writer.WriteIntValue("partitions_count", PartitionsCount);
            writer.WriteObjectValue<global::KafkaRestProxy.Client.Models.CreateTopicRequestData_replicas_assignments>("replicas_assignments", ReplicasAssignments);
            writer.WriteIntValue("replication_factor", ReplicationFactor);
            writer.WriteStringValue("topic_name", TopicName);
            writer.WriteBoolValue("validate_only", ValidateOnly);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}