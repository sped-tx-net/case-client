// -----------------------------------------------------------------------
// <copyright file="CFSubjectSet.cs" company="sped-tx.net">
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
    /// The container for the set of CFSubjects supplied in the response payload. The relationship between the CFSubjects is determined by the &#x27;hierarchyCode&#x27;. The first CFSubject is that which has been specified in the call. The other CFSubjects are the set of children as determined by their place in the &#x27;hierarchyCode&#x27; of the CFSubject.
    /// </summary>
    [DataContract]
    public partial class CFSubjectSet : IEquatable<CFSubjectSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFSubjectSet"/> class.
        /// </summary>
        /// <param name="cFSubjects">cFSubjects (required).</param>
        public CFSubjectSet(List<CFSubject> cFSubjects = default(List<CFSubject>))
        {
            // to ensure "cFSubjects" is required (not null)
            if (cFSubjects == null)
            {
                throw new InvalidDataException("cFSubjects is a required property for CFSubjectSet and cannot be null");
            }
            else
            {
                CFSubjects = cFSubjects;
            }
        }

        /// <summary>
        /// Gets or sets the CFSubjects
        /// Gets or Sets CFSubjects.
        /// </summary>
        [DataMember(Name = "CFSubjects", EmitDefaultValue = false)]
        public List<CFSubject> CFSubjects { get; set; }

        /// <summary>
        /// Returns true if CFSubjectSet instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFSubjectSet to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFSubjectSet input)
        {
            if (input == null)
                return false;

            return
                (
                    CFSubjects == input.CFSubjects ||
                    CFSubjects != null &&
                    input.CFSubjects != null &&
                    CFSubjects.SequenceEqual(input.CFSubjects)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFSubjectSet);
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
                if (CFSubjects != null)
                    hashCode = hashCode * 59 + CFSubjects.GetHashCode();
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
            sb.Append("class CFSubjectSet {\n");
            sb.Append("  CFSubjects: ").Append(CFSubjects).Append("\n");
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
