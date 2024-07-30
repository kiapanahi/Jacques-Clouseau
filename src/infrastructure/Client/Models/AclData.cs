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
    public partial class AclData : global::KafkaRestProxy.Client.Models.Resource, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The cluster_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClusterId { get; set; }
#nullable restore
#else
        public string ClusterId { get; set; }
#endif
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Host { get; set; }
#nullable restore
#else
        public string Host { get; set; }
#endif
        /// <summary>The operation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operation { get; set; }
#nullable restore
#else
        public string Operation { get; set; }
#endif
        /// <summary>The pattern_type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PatternType { get; set; }
#nullable restore
#else
        public string PatternType { get; set; }
#endif
        /// <summary>The permission property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Permission { get; set; }
#nullable restore
#else
        public string Permission { get; set; }
#endif
        /// <summary>The principal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Principal { get; set; }
#nullable restore
#else
        public string Principal { get; set; }
#endif
        /// <summary>The resource_name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceName { get; set; }
#nullable restore
#else
        public string ResourceName { get; set; }
#endif
        /// <summary>The resource_type property</summary>
        public global::KafkaRestProxy.Client.Models.AclResourceType? ResourceType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Models.AclData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::KafkaRestProxy.Client.Models.AclData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KafkaRestProxy.Client.Models.AclData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cluster_id", n => { ClusterId = n.GetStringValue(); } },
                { "host", n => { Host = n.GetStringValue(); } },
                { "operation", n => { Operation = n.GetStringValue(); } },
                { "pattern_type", n => { PatternType = n.GetStringValue(); } },
                { "permission", n => { Permission = n.GetStringValue(); } },
                { "principal", n => { Principal = n.GetStringValue(); } },
                { "resource_name", n => { ResourceName = n.GetStringValue(); } },
                { "resource_type", n => { ResourceType = n.GetEnumValue<global::KafkaRestProxy.Client.Models.AclResourceType>(); } },
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
            writer.WriteStringValue("cluster_id", ClusterId);
            writer.WriteStringValue("host", Host);
            writer.WriteStringValue("operation", Operation);
            writer.WriteStringValue("pattern_type", PatternType);
            writer.WriteStringValue("permission", Permission);
            writer.WriteStringValue("principal", Principal);
            writer.WriteStringValue("resource_name", ResourceName);
            writer.WriteEnumValue<global::KafkaRestProxy.Client.Models.AclResourceType>("resource_type", ResourceType);
        }
    }
}