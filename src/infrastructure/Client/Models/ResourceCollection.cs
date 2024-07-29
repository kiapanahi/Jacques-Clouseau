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
    public partial class ResourceCollection : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The kind property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kind { get; set; }
#nullable restore
#else
        public string Kind { get; set; }
#endif
        /// <summary>The metadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::KafkaRestProxy.Client.Models.ResourceCollectionMetadata? Metadata { get; set; }
#nullable restore
#else
        public global::KafkaRestProxy.Client.Models.ResourceCollectionMetadata Metadata { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::KafkaRestProxy.Client.Models.ResourceCollection"/> and sets the default values.
        /// </summary>
        public ResourceCollection()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::KafkaRestProxy.Client.Models.ResourceCollection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::KafkaRestProxy.Client.Models.ResourceCollection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::KafkaRestProxy.Client.Models.ResourceCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "kind", n => { Kind = n.GetStringValue(); } },
                { "metadata", n => { Metadata = n.GetObjectValue<global::KafkaRestProxy.Client.Models.ResourceCollectionMetadata>(global::KafkaRestProxy.Client.Models.ResourceCollectionMetadata.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("kind", Kind);
            writer.WriteObjectValue<global::KafkaRestProxy.Client.Models.ResourceCollectionMetadata>("metadata", Metadata);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
