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
    public partial class ConsumerData : global::KafkaRestProxy.Client.Models.Resource, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The assignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::KafkaRestProxy.Client.Models.Relationship? Assignments { get; set; }
#nullable restore
#else
        public global::KafkaRestProxy.Client.Models.Relationship Assignments { get; set; }
#endif
        /// <summary>The client_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientId { get; set; }
#nullable restore
#else
        public string ClientId { get; set; }
#endif
        /// <summary>The cluster_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClusterId { get; set; }
#nullable restore
#else
        public string ClusterId { get; set; }
#endif
        /// <summary>The consumer_group_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConsumerGroupId { get; set; }
#nullable restore
#else
        public string ConsumerGroupId { get; set; }
#endif
        /// <summary>The consumer_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConsumerId { get; set; }
#nullable restore
#else
        public string ConsumerId { get; set; }
#endif
        /// <summary>The instance_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceId { get; set; }
#nullable restore
#else
        public string InstanceId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Models.ConsumerData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::KafkaRestProxy.Client.Models.ConsumerData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KafkaRestProxy.Client.Models.ConsumerData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetObjectValue<global::KafkaRestProxy.Client.Models.Relationship>(global::KafkaRestProxy.Client.Models.Relationship.CreateFromDiscriminatorValue); } },
                { "client_id", n => { ClientId = n.GetStringValue(); } },
                { "cluster_id", n => { ClusterId = n.GetStringValue(); } },
                { "consumer_group_id", n => { ConsumerGroupId = n.GetStringValue(); } },
                { "consumer_id", n => { ConsumerId = n.GetStringValue(); } },
                { "instance_id", n => { InstanceId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::KafkaRestProxy.Client.Models.Relationship>("assignments", Assignments);
            writer.WriteStringValue("client_id", ClientId);
            writer.WriteStringValue("cluster_id", ClusterId);
            writer.WriteStringValue("consumer_group_id", ConsumerGroupId);
            writer.WriteStringValue("consumer_id", ConsumerId);
            writer.WriteStringValue("instance_id", InstanceId);
        }
    }
}