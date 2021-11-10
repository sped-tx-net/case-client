// -----------------------------------------------------------------------
// <copyright file="CFRubricCriterionLevel.cs" company="sped-tx.net">
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
    /// The container for the definition of a criterion level which is addressed by the competency framework.
    /// </summary>
    [DataContract]
    public partial class CFRubricCriterionLevel : IEquatable<CFRubricCriterionLevel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFRubricCriterionLevel"/> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="description">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="quality">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="score">Model Primitive Datatype &#x3D; Float.</param>
        /// <param name="feedback">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="position">Model Primitive Datatype &#x3D; Integer.</param>
        /// <param name="rubricCriterionId">rubricCriterionId.</param>
        /// <param name="lastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        public CFRubricCriterionLevel(string identifier = default(string), string uri = default(string), string description = default(string), string quality = default(string), float? score = default(float?), string feedback = default(string), int? position = default(int?), string rubricCriterionId = default(string), DateTime? lastChangeDateTime = default(DateTime?))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for CFRubricCriterionLevel and cannot be null");
            }
            else
            {
                Identifier = identifier;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CFRubricCriterionLevel and cannot be null");
            }
            else
            {
                Uri = uri;
            }
            // to ensure "lastChangeDateTime" is required (not null)
            if (lastChangeDateTime == null)
            {
                throw new InvalidDataException("lastChangeDateTime is a required property for CFRubricCriterionLevel and cannot be null");
            }
            else
            {
                LastChangeDateTime = lastChangeDateTime;
            }
            Description = description;
            Quality = quality;
            Score = score;
            Feedback = feedback;
            Position = position;
            RubricCriterionId = rubricCriterionId;
        }

        /// <summary>
        /// Gets or sets the Description
        /// Model Primitive Datatype &#x3D; String.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Feedback
        /// Model Primitive Datatype &#x3D; String.
        /// </summary>
        [DataMember(Name = "feedback", EmitDefaultValue = false)]
        public string Feedback { get; set; }

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
        /// Gets or sets the Quality
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public string Quality { get; set; }

        /// <summary>
        /// Gets or sets the RubricCriterionId
        /// Gets or Sets RubricCriterionId.
        /// </summary>
        [DataMember(Name = "rubricCriterionId", EmitDefaultValue = false)]
        public string RubricCriterionId { get; set; }

        /// <summary>
        /// Gets or sets the Score
        /// Model Primitive Datatype &#x3D; Float.
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public float? Score { get; set; }

        /// <summary>
        /// Gets or sets the Uri
        /// Model Primitive Datatype &#x3D; AnyURI.
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns true if CFRubricCriterionLevel instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFRubricCriterionLevel to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFRubricCriterionLevel input)
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
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) &&
                (
                    Quality == input.Quality ||
                    (Quality != null &&
                    Quality.Equals(input.Quality))
                ) &&
                (
                    Score == input.Score ||
                    (Score != null &&
                    Score.Equals(input.Score))
                ) &&
                (
                    Feedback == input.Feedback ||
                    (Feedback != null &&
                    Feedback.Equals(input.Feedback))
                ) &&
                (
                    Position == input.Position ||
                    (Position != null &&
                    Position.Equals(input.Position))
                ) &&
                (
                    RubricCriterionId == input.RubricCriterionId ||
                    (RubricCriterionId != null &&
                    RubricCriterionId.Equals(input.RubricCriterionId))
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
            return Equals(input as CFRubricCriterionLevel);
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
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Quality != null)
                    hashCode = hashCode * 59 + Quality.GetHashCode();
                if (Score != null)
                    hashCode = hashCode * 59 + Score.GetHashCode();
                if (Feedback != null)
                    hashCode = hashCode * 59 + Feedback.GetHashCode();
                if (Position != null)
                    hashCode = hashCode * 59 + Position.GetHashCode();
                if (RubricCriterionId != null)
                    hashCode = hashCode * 59 + RubricCriterionId.GetHashCode();
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
            sb.Append("class CFRubricCriterionLevel {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Feedback: ").Append(Feedback).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  RubricCriterionId: ").Append(RubricCriterionId).Append("\n");
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
