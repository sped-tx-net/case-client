// -----------------------------------------------------------------------
// <copyright file="CFDocumentSet.cs" company="sped-tx.net">
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
    /// This is the container for a collection of CFDocuments. There must be at least one CFDocument.
    /// </summary>
    [DataContract]
    public partial class CFDocumentSet : IEquatable<CFDocumentSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocumentSet"/> class.
        /// </summary>
        /// <param name="cFDocuments">cFDocuments (required).</param>
        public CFDocumentSet(List<CFDocument> cFDocuments = default(List<CFDocument>))
        {
            // to ensure "cFDocuments" is required (not null)
            if (cFDocuments == null)
            {
                throw new InvalidDataException("cFDocuments is a required property for CFDocumentSet and cannot be null");
            }
            else
            {
                CFDocuments = cFDocuments;
            }
        }

        /// <summary>
        /// Gets or sets the CFDocuments
        /// Gets or Sets CFDocuments..
        /// </summary>
        [DataMember(Name = "CFDocuments", EmitDefaultValue = false)]
        public List<CFDocument> CFDocuments { get; set; }

        /// <summary>
        /// Returns true if CFDocumentSet instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFDocumentSet to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFDocumentSet input)
        {
            if (input == null)
                return false;

            return
                (
                    CFDocuments == input.CFDocuments ||
                    CFDocuments != null &&
                    input.CFDocuments != null &&
                    CFDocuments.SequenceEqual(input.CFDocuments)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFDocumentSet);
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
                if (CFDocuments != null)
                    hashCode = hashCode * 59 + CFDocuments.GetHashCode();
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
            sb.Append("class CFDocumentSet {\n");
            sb.Append("  CFDocuments: ").Append(CFDocuments).Append("\n");
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
