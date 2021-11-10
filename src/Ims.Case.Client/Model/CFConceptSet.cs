// -----------------------------------------------------------------------
// <copyright file="CFConceptSet.cs" company="sped-tx.net">
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
    /// The container for the set of CFConcepts supplied in the response payload. The relationship between the CFConcepts is determined by the &#x27;hierarchyCode&#x27;. The first CFConcept is that which has been specified in the call. The other CFConcepts are the set of children as determined by their place in the &#x27;hierarchyCode&#x27; of the CFConcept.
    /// </summary>
    [DataContract]
    public partial class CFConceptSet : IEquatable<CFConceptSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFConceptSet"/> class.
        /// </summary>
        /// <param name="cFConcepts">cFConcepts (required).</param>
        public CFConceptSet(List<CFConcept> cFConcepts = default(List<CFConcept>))
        {
            // to ensure "cFConcepts" is required (not null)
            if (cFConcepts == null)
            {
                throw new InvalidDataException("cFConcepts is a required property for CFConceptSet and cannot be null");
            }
            else
            {
                CFConcepts = cFConcepts;
            }
        }

        /// <summary>
        /// Gets or sets the CFConcepts
        /// Gets or Sets CFConcepts..
        /// </summary>
        [DataMember(Name = "CFConcepts", EmitDefaultValue = false)]
        public List<CFConcept> CFConcepts { get; set; }

        /// <summary>
        /// Returns true if CFConceptSet instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFConceptSet to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFConceptSet input)
        {
            if (input == null)
                return false;

            return
                (
                    CFConcepts == input.CFConcepts ||
                    CFConcepts != null &&
                    input.CFConcepts != null &&
                    CFConcepts.SequenceEqual(input.CFConcepts)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFConceptSet);
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
                if (CFConcepts != null)
                    hashCode = hashCode * 59 + CFConcepts.GetHashCode();
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
            sb.Append("class CFConceptSet {\n");
            sb.Append("  CFConcepts: ").Append(CFConcepts).Append("\n");
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
