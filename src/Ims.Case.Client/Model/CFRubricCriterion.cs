// -----------------------------------------------------------------------
// <copyright file="CFRubricCriterion.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ims.Case.Model
{
    /// <summary>
    /// The container for the definition of a rubric criterion which is addressed by the competency framework.
    /// </summary>
    [DataContract]
    public partial class CFRubricCriterion : IEquatable<CFRubricCriterion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFRubricCriterion"/> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="category">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="description">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="cFItemURI">cFItemURI.</param>
        /// <param name="weight">Model Primitive Datatype &#x3D; Float.</param>
        /// <param name="position">Model Primitive Datatype &#x3D; Integer.</param>
        /// <param name="rubricId">rubricId.</param>
        /// <param name="lastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        /// <param name="cFRubricCriterionLevels">cFRubricCriterionLevels.</param>
        public CFRubricCriterion(string identifier = default(string), string uri = default(string), string category = default(string), string description = default(string), LinkURI cFItemURI = default(LinkURI), float? weight = default(float?), int? position = default(int?), string rubricId = default(string), DateTime? lastChangeDateTime = default(DateTime?), List<CFRubricCriterionLevel> cFRubricCriterionLevels = default(List<CFRubricCriterionLevel>))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for CFRubricCriterion and cannot be null");
            }
            else
            {
                Identifier = identifier;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CFRubricCriterion and cannot be null");
            }
            else
            {
                Uri = uri;
            }
            // to ensure "lastChangeDateTime" is required (not null)
            if (lastChangeDateTime == null)
            {
                throw new InvalidDataException("lastChangeDateTime is a required property for CFRubricCriterion and cannot be null");
            }
            else
            {
                LastChangeDateTime = lastChangeDateTime;
            }
            Category = category;
            Description = description;
            CFItemURI = cFItemURI;
            Weight = weight;
            Position = position;
            RubricId = rubricId;
            CFRubricCriterionLevels = cFRubricCriterionLevels;
        }

        /// <summary>
        /// Gets or sets the Category
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the CFItemURI
        /// Gets or Sets CFItemURI.
        /// </summary>
        [DataMember(Name = "CFItemURI", EmitDefaultValue = false)]
        public LinkURI CFItemURI { get; set; }

        /// <summary>
        /// Gets or sets the CFRubricCriterionLevels
        /// Gets or Sets CFRubricCriterionLevels.
        /// </summary>
        [DataMember(Name = "CFRubricCriterionLevels", EmitDefaultValue = false)]
        public List<CFRubricCriterionLevel> CFRubricCriterionLevels { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// Model Primitive Datatype &#x3D; String.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

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
        /// Gets or sets the Position
        /// Model Primitive Datatype &#x3D; Integer.
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets the RubricId
        /// Gets or Sets RubricId.
        /// </summary>
        [DataMember(Name = "rubricId", EmitDefaultValue = false)]
        public string RubricId { get; set; }

        /// <summary>
        /// Gets or sets the Uri
        /// Model Primitive Datatype &#x3D; AnyURI.
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the Weight
        /// Model Primitive Datatype &#x3D; Float.
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public float? Weight { get; set; }

        /// <summary>
        /// Returns true if CFRubricCriterion instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFRubricCriterion to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFRubricCriterion input)
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
                    Category == input.Category ||
                    (Category != null &&
                    Category.Equals(input.Category))
                ) &&
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) &&
                (
                    CFItemURI == input.CFItemURI ||
                    (CFItemURI != null &&
                    CFItemURI.Equals(input.CFItemURI))
                ) &&
                (
                    Weight == input.Weight ||
                    (Weight != null &&
                    Weight.Equals(input.Weight))
                ) &&
                (
                    Position == input.Position ||
                    (Position != null &&
                    Position.Equals(input.Position))
                ) &&
                (
                    RubricId == input.RubricId ||
                    (RubricId != null &&
                    RubricId.Equals(input.RubricId))
                ) &&
                (
                    LastChangeDateTime == input.LastChangeDateTime ||
                    (LastChangeDateTime != null &&
                    LastChangeDateTime.Equals(input.LastChangeDateTime))
                ) &&
                (
                    CFRubricCriterionLevels == input.CFRubricCriterionLevels ||
                    CFRubricCriterionLevels != null &&
                    input.CFRubricCriterionLevels != null &&
                    CFRubricCriterionLevels.SequenceEqual(input.CFRubricCriterionLevels)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFRubricCriterion);
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
                if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (CFItemURI != null)
                    hashCode = hashCode * 59 + CFItemURI.GetHashCode();
                if (Weight != null)
                    hashCode = hashCode * 59 + Weight.GetHashCode();
                if (Position != null)
                    hashCode = hashCode * 59 + Position.GetHashCode();
                if (RubricId != null)
                    hashCode = hashCode * 59 + RubricId.GetHashCode();
                if (LastChangeDateTime != null)
                    hashCode = hashCode * 59 + LastChangeDateTime.GetHashCode();
                if (CFRubricCriterionLevels != null)
                    hashCode = hashCode * 59 + CFRubricCriterionLevels.GetHashCode();
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
            sb.Append("class CFRubricCriterion {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CFItemURI: ").Append(CFItemURI).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  RubricId: ").Append(RubricId).Append("\n");
            sb.Append("  LastChangeDateTime: ").Append(LastChangeDateTime).Append("\n");
            sb.Append("  CFRubricCriterionLevels: ").Append(CFRubricCriterionLevels).Append("\n");
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
