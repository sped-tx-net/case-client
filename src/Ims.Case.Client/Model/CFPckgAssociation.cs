// -----------------------------------------------------------------------
// <copyright file="CFPckgAssociation.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Ims.Case.Model
{
    /// <summary>
    /// This is the container for the data about the relationship between two CFDocuments or between two CFItems within the context of a CFPackage.
    /// </summary>
    [DataContract]
    public partial class CFPckgAssociation : IEquatable<CFPckgAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPckgAssociation"/> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="associationType">associationType (required).</param>
        /// <param name="sequenceNumber">Model Primitive Datatype &#x3D; Integer.</param>
        /// <param name="uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="originNodeURI">originNodeURI (required).</param>
        /// <param name="destinationNodeURI">destinationNodeURI (required).</param>
        /// <param name="cFAssociationGroupingURI">cFAssociationGroupingURI.</param>
        /// <param name="lastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        public CFPckgAssociation(string identifier = default(string), AssociationTypeEnum associationType = default(AssociationTypeEnum), int? sequenceNumber = default(int?), string uri = default(string), LinkGenURI originNodeURI = default(LinkGenURI), LinkGenURI destinationNodeURI = default(LinkGenURI), LinkURI cFAssociationGroupingURI = default(LinkURI), DateTime? lastChangeDateTime = default(DateTime?))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for CFPckgAssociation and cannot be null");
            }
            else
            {
                Identifier = identifier;
            }
            // to ensure "associationType" is required (not null)
            if (associationType == null)
            {
                throw new InvalidDataException("associationType is a required property for CFPckgAssociation and cannot be null");
            }
            else
            {
                AssociationType = associationType;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CFPckgAssociation and cannot be null");
            }
            else
            {
                Uri = uri;
            }
            // to ensure "originNodeURI" is required (not null)
            if (originNodeURI == null)
            {
                throw new InvalidDataException("originNodeURI is a required property for CFPckgAssociation and cannot be null");
            }
            else
            {
                OriginNodeURI = originNodeURI;
            }
            // to ensure "destinationNodeURI" is required (not null)
            if (destinationNodeURI == null)
            {
                throw new InvalidDataException("destinationNodeURI is a required property for CFPckgAssociation and cannot be null");
            }
            else
            {
                DestinationNodeURI = destinationNodeURI;
            }
            // to ensure "lastChangeDateTime" is required (not null)
            if (lastChangeDateTime == null)
            {
                throw new InvalidDataException("lastChangeDateTime is a required property for CFPckgAssociation and cannot be null");
            }
            else
            {
                LastChangeDateTime = lastChangeDateTime;
            }
            SequenceNumber = sequenceNumber;
            CFAssociationGroupingURI = cFAssociationGroupingURI;
        }

        /// <summary>
        /// Gets or sets the AssociationType
        /// Gets or Sets AssociationType.
        /// </summary>
        [DataMember(Name = "associationType", EmitDefaultValue = false)]
        public AssociationTypeEnum AssociationType { get; set; }

        /// <summary>
        /// Gets or sets the CFAssociationGroupingURI
        /// Gets or Sets CFAssociationGroupingURI.
        /// </summary>
        [DataMember(Name = "CFAssociationGroupingURI", EmitDefaultValue = false)]
        public LinkURI CFAssociationGroupingURI { get; set; }

        /// <summary>
        /// Gets or sets the DestinationNodeURI
        /// Gets or Sets DestinationNodeURI.
        /// </summary>
        [DataMember(Name = "destinationNodeURI", EmitDefaultValue = false)]
        public LinkGenURI DestinationNodeURI { get; set; }

        /// <summary>
        /// Gets or sets the Identifier
        /// Gets or Sets Identifier.
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the LastChangeDateTime
        /// Model Primitive Datatype &#x3D; DateTime.
        /// </summary>
        [DataMember(Name = "lastChangeDateTime", EmitDefaultValue = false)]
        public DateTime? LastChangeDateTime { get; set; }

        /// <summary>
        /// Gets or sets the OriginNodeURI
        /// Gets or Sets OriginNodeURI.
        /// </summary>
        [DataMember(Name = "originNodeURI", EmitDefaultValue = false)]
        public LinkGenURI OriginNodeURI { get; set; }

        /// <summary>
        /// Gets or sets the SequenceNumber
        /// Model Primitive Datatype &#x3D; Integer.
        /// </summary>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = false)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the Uri
        /// Model Primitive Datatype &#x3D; AnyURI.
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns true if CFPckgAssociation instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFPckgAssociation to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFPckgAssociation input)
        {
            if (input == null)
                return false;

            return
                (
                    Identifier == input.Identifier ||
                    (Identifier != null &&
                    Identifier.Equals(input.Identifier))
                ) &&
                (
                    AssociationType == input.AssociationType ||
                    (AssociationType != null &&
                    AssociationType.Equals(input.AssociationType))
                ) &&
                (
                    SequenceNumber == input.SequenceNumber ||
                    (SequenceNumber != null &&
                    SequenceNumber.Equals(input.SequenceNumber))
                ) &&
                (
                    Uri == input.Uri ||
                    (Uri != null &&
                    Uri.Equals(input.Uri))
                ) &&
                (
                    OriginNodeURI == input.OriginNodeURI ||
                    (OriginNodeURI != null &&
                    OriginNodeURI.Equals(input.OriginNodeURI))
                ) &&
                (
                    DestinationNodeURI == input.DestinationNodeURI ||
                    (DestinationNodeURI != null &&
                    DestinationNodeURI.Equals(input.DestinationNodeURI))
                ) &&
                (
                    CFAssociationGroupingURI == input.CFAssociationGroupingURI ||
                    (CFAssociationGroupingURI != null &&
                    CFAssociationGroupingURI.Equals(input.CFAssociationGroupingURI))
                ) &&
                (
                    LastChangeDateTime == input.LastChangeDateTime ||
                    (LastChangeDateTime != null &&
                    LastChangeDateTime.Equals(input.LastChangeDateTime))
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFPckgAssociation);
        }

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Identifier != null)
                    hashCode = hashCode * 59 + Identifier.GetHashCode();
                if (AssociationType != null)
                    hashCode = hashCode * 59 + AssociationType.GetHashCode();
                if (SequenceNumber != null)
                    hashCode = hashCode * 59 + SequenceNumber.GetHashCode();
                if (Uri != null)
                    hashCode = hashCode * 59 + Uri.GetHashCode();
                if (OriginNodeURI != null)
                    hashCode = hashCode * 59 + OriginNodeURI.GetHashCode();
                if (DestinationNodeURI != null)
                    hashCode = hashCode * 59 + DestinationNodeURI.GetHashCode();
                if (CFAssociationGroupingURI != null)
                    hashCode = hashCode * 59 + CFAssociationGroupingURI.GetHashCode();
                if (LastChangeDateTime != null)
                    hashCode = hashCode * 59 + LastChangeDateTime.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CFPckgAssociation {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  AssociationType: ").Append(AssociationType).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  OriginNodeURI: ").Append(OriginNodeURI).Append("\n");
            sb.Append("  DestinationNodeURI: ").Append(DestinationNodeURI).Append("\n");
            sb.Append("  CFAssociationGroupingURI: ").Append(CFAssociationGroupingURI).Append("\n");
            sb.Append("  LastChangeDateTime: ").Append(LastChangeDateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance.
        /// </summary>
        /// <param name="validationContext">Validation context.</param>
        /// <returns>Validation Result.</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        /// Defines AssociationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssociationTypeEnum
        {
            /// <summary>
            /// Enum IsChildOf for value: isChildOf
            /// </summary>
            [EnumMember(Value = "isChildOf")]
            IsChildOf = 1,
            /// <summary>
            /// Enum IsPeerOf for value: isPeerOf
            /// </summary>
            [EnumMember(Value = "isPeerOf")]
            IsPeerOf = 2,
            /// <summary>
            /// Enum IsPartOf for value: isPartOf
            /// </summary>
            [EnumMember(Value = "isPartOf")]
            IsPartOf = 3,
            /// <summary>
            /// Enum ExactMatchOf for value: exactMatchOf
            /// </summary>
            [EnumMember(Value = "exactMatchOf")]
            ExactMatchOf = 4,
            /// <summary>
            /// Enum Precedes for value: precedes
            /// </summary>
            [EnumMember(Value = "precedes")]
            Precedes = 5,
            /// <summary>
            /// Enum IsRelatedTo for value: isRelatedTo
            /// </summary>
            [EnumMember(Value = "isRelatedTo")]
            IsRelatedTo = 6,
            /// <summary>
            /// Enum ReplacedBy for value: replacedBy
            /// </summary>
            [EnumMember(Value = "replacedBy")]
            ReplacedBy = 7,
            /// <summary>
            /// Enum Exemplar for value: exemplar
            /// </summary>
            [EnumMember(Value = "exemplar")]
            Exemplar = 8,
            /// <summary>
            /// Enum HasSkillLevel for value: hasSkillLevel
            /// </summary>
            [EnumMember(Value = "hasSkillLevel")]
            HasSkillLevel = 9
        }
    }
}
