// -----------------------------------------------------------------------
// <copyright file="CFPackage.cs" company="sped-tx.net">
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
    /// This is the container for all of the data for a Competency Framework Package i.e. the root CFDocument and ALL of the corresponding components i.e. the CFItems, CFAssociations and CFDefinitions.
    /// </summary>
    [DataContract]
    public partial class CFPackage : IEquatable<CFPackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPackage"/> class.
        /// </summary>
        /// <param name="cFDocument">cFDocument (required).</param>
        /// <param name="cFItems">cFItems.</param>
        /// <param name="cFAssociations">cFAssociations.</param>
        /// <param name="cFDefinitions">cFDefinitions.</param>
        /// <param name="cFRubrics">cFRubrics.</param>
        public CFPackage(CFPckgDocument cFDocument = default(CFPckgDocument), List<CFPckgItem> cFItems = default(List<CFPckgItem>), List<CFPckgAssociation> cFAssociations = default(List<CFPckgAssociation>), CFDefinition cFDefinitions = default(CFDefinition), List<CFRubric> cFRubrics = default(List<CFRubric>))
        {
            // to ensure "cFDocument" is required (not null)
            if (cFDocument == null)
            {
                throw new InvalidDataException("cFDocument is a required property for CFPackage and cannot be null");
            }
            else
            {
                CFDocument = cFDocument;
            }
            CFItems = cFItems;
            CFAssociations = cFAssociations;
            CFDefinitions = cFDefinitions;
            CFRubrics = cFRubrics;
        }

        /// <summary>
        /// Gets or sets the CFAssociations
        /// Gets or Sets CFAssociations..
        /// </summary>
        [DataMember(Name = "CFAssociations", EmitDefaultValue = false)]
        public List<CFPckgAssociation> CFAssociations { get; set; }

        /// <summary>
        /// Gets or sets the CFDefinitions
        /// Gets or Sets CFDefinitions..
        /// </summary>
        [DataMember(Name = "CFDefinitions", EmitDefaultValue = false)]
        public CFDefinition CFDefinitions { get; set; }

        /// <summary>
        /// Gets or sets the CFDocument
        /// Gets or Sets CFDocument..
        /// </summary>
        [DataMember(Name = "CFDocument", EmitDefaultValue = false)]
        public CFPckgDocument CFDocument { get; set; }

        /// <summary>
        /// Gets or sets the CFItems
        /// Gets or Sets CFItems..
        /// </summary>
        [DataMember(Name = "CFItems", EmitDefaultValue = false)]
        public List<CFPckgItem> CFItems { get; set; }

        /// <summary>
        /// Gets or sets the CFRubrics
        /// Gets or Sets CFRubrics..
        /// </summary>
        [DataMember(Name = "CFRubrics", EmitDefaultValue = false)]
        public List<CFRubric> CFRubrics { get; set; }

        /// <summary>
        /// Returns true if CFPackage instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFPackage to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFPackage input)
        {
            if (input == null)
                return false;

            return
                (
                    CFDocument == input.CFDocument ||
                    (CFDocument != null &&
                    CFDocument.Equals(input.CFDocument))
                ) &&
                (
                    CFItems == input.CFItems ||
                    CFItems != null &&
                    input.CFItems != null &&
                    CFItems.SequenceEqual(input.CFItems)
                ) &&
                (
                    CFAssociations == input.CFAssociations ||
                    CFAssociations != null &&
                    input.CFAssociations != null &&
                    CFAssociations.SequenceEqual(input.CFAssociations)
                ) &&
                (
                    CFDefinitions == input.CFDefinitions ||
                    (CFDefinitions != null &&
                    CFDefinitions.Equals(input.CFDefinitions))
                ) &&
                (
                    CFRubrics == input.CFRubrics ||
                    CFRubrics != null &&
                    input.CFRubrics != null &&
                    CFRubrics.SequenceEqual(input.CFRubrics)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFPackage);
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
                if (CFDocument != null)
                    hashCode = hashCode * 59 + CFDocument.GetHashCode();
                if (CFItems != null)
                    hashCode = hashCode * 59 + CFItems.GetHashCode();
                if (CFAssociations != null)
                    hashCode = hashCode * 59 + CFAssociations.GetHashCode();
                if (CFDefinitions != null)
                    hashCode = hashCode * 59 + CFDefinitions.GetHashCode();
                if (CFRubrics != null)
                    hashCode = hashCode * 59 + CFRubrics.GetHashCode();
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
            sb.Append("class CFPackage {\n");
            sb.Append("  CFDocument: ").Append(CFDocument).Append("\n");
            sb.Append("  CFItems: ").Append(CFItems).Append("\n");
            sb.Append("  CFAssociations: ").Append(CFAssociations).Append("\n");
            sb.Append("  CFDefinitions: ").Append(CFDefinitions).Append("\n");
            sb.Append("  CFRubrics: ").Append(CFRubrics).Append("\n");
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
