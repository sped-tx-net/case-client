// -----------------------------------------------------------------------
// <copyright file="CFRubric.cs" company="sped-tx.net">
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
    /// The container for the definition of a rubric which is addressed by the competency framework. This includes the set of associated CFRubricCriteria and CFRubricCriterionLevels.
    /// </summary>
    [DataContract]
    public partial class CFRubric : IEquatable<CFRubric>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFRubric"/> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="title">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="description">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="lastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        /// <param name="cFRubricCriteria">cFRubricCriteria.</param>
        public CFRubric(string identifier = default(string), string uri = default(string), string title = default(string), string description = default(string), DateTime? lastChangeDateTime = default(DateTime?), List<CFRubricCriterion> cFRubricCriteria = default(List<CFRubricCriterion>))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for CFRubric and cannot be null");
            }
            else
            {
                Identifier = identifier;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CFRubric and cannot be null");
            }
            else
            {
                Uri = uri;
            }
            // to ensure "lastChangeDateTime" is required (not null)
            if (lastChangeDateTime == null)
            {
                throw new InvalidDataException("lastChangeDateTime is a required property for CFRubric and cannot be null");
            }
            else
            {
                LastChangeDateTime = lastChangeDateTime;
            }
            Title = title;
            Description = description;
            CFRubricCriteria = cFRubricCriteria;
        }

        /// <summary>
        /// Gets or sets the CFRubricCriteria
        /// Gets or Sets CFRubricCriteria.
        /// </summary>
        [DataMember(Name = "CFRubricCriteria", EmitDefaultValue = false)]
        public List<CFRubricCriterion> CFRubricCriteria { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// Model Primitive Datatype &#x3D; NormalizedString.
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
        /// Gets or sets the Title
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Uri
        /// Model Primitive Datatype &#x3D; AnyURI.
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns true if CFRubric instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFRubric to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFRubric input)
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
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) &&
                (
                    LastChangeDateTime == input.LastChangeDateTime ||
                    (LastChangeDateTime != null &&
                    LastChangeDateTime.Equals(input.LastChangeDateTime))
                ) &&
                (
                    CFRubricCriteria == input.CFRubricCriteria ||
                    CFRubricCriteria != null &&
                    input.CFRubricCriteria != null &&
                    CFRubricCriteria.SequenceEqual(input.CFRubricCriteria)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFRubric);
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
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (LastChangeDateTime != null)
                    hashCode = hashCode * 59 + LastChangeDateTime.GetHashCode();
                if (CFRubricCriteria != null)
                    hashCode = hashCode * 59 + CFRubricCriteria.GetHashCode();
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
            sb.Append("class CFRubric {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastChangeDateTime: ").Append(LastChangeDateTime).Append("\n");
            sb.Append("  CFRubricCriteria: ").Append(CFRubricCriteria).Append("\n");
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
