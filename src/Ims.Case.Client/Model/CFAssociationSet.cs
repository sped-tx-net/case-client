// -----------------------------------------------------------------------
// <copyright file="CFAssociationSet.cs" company="sped-tx.net">
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
    /// This is the container for a collection of CFAssociations. There must be at least one CFAssociation. Note that the association can be between CFDocuments or between CFItems.
    /// </summary>
    [DataContract]
    public partial class CFAssociationSet : IEquatable<CFAssociationSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFAssociationSet"/> class.
        /// </summary>
        /// <param name="cFItem">cFItem (required).</param>
        /// <param name="cFAssociations">cFAssociations (required).</param>
        public CFAssociationSet(CFItem cFItem = default(CFItem), List<CFPckgAssociation> cFAssociations = default(List<CFPckgAssociation>))
        {
            // to ensure "cFItem" is required (not null)
            if (cFItem == null)
            {
                throw new InvalidDataException("cFItem is a required property for CFAssociationSet and cannot be null");
            }
            else
            {
                CFItem = cFItem;
            }
            // to ensure "cFAssociations" is required (not null)
            if (cFAssociations == null)
            {
                throw new InvalidDataException("cFAssociations is a required property for CFAssociationSet and cannot be null");
            }
            else
            {
                CFAssociations = cFAssociations;
            }
        }

        /// <summary>
        /// Gets or sets the CFAssociations
        /// Gets or Sets CFAssociations..
        /// </summary>
        [DataMember(Name = "CFAssociations", EmitDefaultValue = false)]
        public List<CFPckgAssociation> CFAssociations { get; set; }

        /// <summary>
        /// Gets or sets the CFItem
        /// Gets or Sets CFItem..
        /// </summary>
        [DataMember(Name = "CFItem", EmitDefaultValue = false)]
        public CFItem CFItem { get; set; }

        /// <summary>
        /// Returns true if CFAssociationSet instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFAssociationSet to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFAssociationSet input)
        {
            if (input == null)
                return false;

            return
                (
                    CFItem == input.CFItem ||
                    (CFItem != null &&
                    CFItem.Equals(input.CFItem))
                ) &&
                (
                    CFAssociations == input.CFAssociations ||
                    CFAssociations != null &&
                    input.CFAssociations != null &&
                    CFAssociations.SequenceEqual(input.CFAssociations)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFAssociationSet);
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
                if (CFItem != null)
                    hashCode = hashCode * 59 + CFItem.GetHashCode();
                if (CFAssociations != null)
                    hashCode = hashCode * 59 + CFAssociations.GetHashCode();
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
            sb.Append("class CFAssociationSet {\n");
            sb.Append("  CFItem: ").Append(CFItem).Append("\n");
            sb.Append("  CFAssociations: ").Append(CFAssociations).Append("\n");
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
