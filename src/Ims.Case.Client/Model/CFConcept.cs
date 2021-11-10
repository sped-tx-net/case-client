// -----------------------------------------------------------------------
// <copyright file="CFConcept.cs" company="sped-tx.net">
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

namespace Ims.Case.Model
{
    /// <summary>
    /// The container for the definition of a concept which is addressed by the competency framework.
    /// </summary>
    [DataContract]
    public partial class CFConcept : IEquatable<CFConcept>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFConcept"/> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="title">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="keywords">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="hierarchyCode">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="description">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="lastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        public CFConcept(string identifier = default(string), string uri = default(string), string title = default(string), string keywords = default(string), string hierarchyCode = default(string), string description = default(string), DateTime? lastChangeDateTime = default(DateTime?))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for CFConcept and cannot be null");
            }
            else
            {
                Identifier = identifier;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CFConcept and cannot be null");
            }
            else
            {
                Uri = uri;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for CFConcept and cannot be null");
            }
            else
            {
                Title = title;
            }
            // to ensure "hierarchyCode" is required (not null)
            if (hierarchyCode == null)
            {
                throw new InvalidDataException("hierarchyCode is a required property for CFConcept and cannot be null");
            }
            else
            {
                HierarchyCode = hierarchyCode;
            }
            // to ensure "lastChangeDateTime" is required (not null)
            if (lastChangeDateTime == null)
            {
                throw new InvalidDataException("lastChangeDateTime is a required property for CFConcept and cannot be null");
            }
            else
            {
                LastChangeDateTime = lastChangeDateTime;
            }
            Keywords = keywords;
            Description = description;
        }

        /// <summary>
        /// Gets or sets the Description
        /// Model Primitive Datatype &#x3D; String..
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the HierarchyCode
        /// Model Primitive Datatype &#x3D; NormalizedString..
        /// </summary>
        [DataMember(Name = "hierarchyCode", EmitDefaultValue = false)]
        public string HierarchyCode { get; set; }

        /// <summary>
        /// Gets or sets the Identifier
        /// Gets or Sets Identifier..
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the Keywords
        /// Model Primitive Datatype &#x3D; NormalizedString..
        /// </summary>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets the LastChangeDateTime
        /// Model Primitive Datatype &#x3D; DateTime..
        /// </summary>
        [DataMember(Name = "lastChangeDateTime", EmitDefaultValue = false)]
        public DateTime? LastChangeDateTime { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// Model Primitive Datatype &#x3D; NormalizedString..
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Uri
        /// Model Primitive Datatype &#x3D; AnyURI..
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns true if CFConcept instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFConcept to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFConcept input)
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
                    Uri == input.Uri ||
                    (Uri != null &&
                    Uri.Equals(input.Uri))
                ) &&
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
                ) &&
                (
                    Keywords == input.Keywords ||
                    (Keywords != null &&
                    Keywords.Equals(input.Keywords))
                ) &&
                (
                    HierarchyCode == input.HierarchyCode ||
                    (HierarchyCode != null &&
                    HierarchyCode.Equals(input.HierarchyCode))
                ) &&
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
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
            return Equals(input as CFConcept);
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
                if (Uri != null)
                    hashCode = hashCode * 59 + Uri.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (Keywords != null)
                    hashCode = hashCode * 59 + Keywords.GetHashCode();
                if (HierarchyCode != null)
                    hashCode = hashCode * 59 + HierarchyCode.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
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
            sb.Append("class CFConcept {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  HierarchyCode: ").Append(HierarchyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
    }
}
