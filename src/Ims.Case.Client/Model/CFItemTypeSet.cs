// -----------------------------------------------------------------------
// <copyright file="CFItemTypeSet.cs" company="sped-tx.net">
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
    /// The container for the set of CFItemTypes supplied in the response payload. The relationship between the CFItemTypes is determined by the &#x27;hierarchyCode&#x27;. The first CFItemType is that which has been specified in the call. The other CFItemTypes are the set of children as determined by their place in the &#x27;hierarchyCode&#x27; of the CFItemType.
    /// </summary>
    [DataContract]
    public partial class CFItemTypeSet : IEquatable<CFItemTypeSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFItemTypeSet"/> class.
        /// </summary>
        /// <param name="cFItemTypes">cFItemTypes (required).</param>
        public CFItemTypeSet(List<CFItemType> cFItemTypes = default(List<CFItemType>))
        {
            // to ensure "cFItemTypes" is required (not null)
            if (cFItemTypes == null)
            {
                throw new InvalidDataException("cFItemTypes is a required property for CFItemTypeSet and cannot be null");
            }
            else
            {
                CFItemTypes = cFItemTypes;
            }
        }

        /// <summary>
        /// Gets or sets the CFItemTypes
        /// Gets or Sets CFItemTypes..
        /// </summary>
        [DataMember(Name = "CFItemTypes", EmitDefaultValue = false)]
        public List<CFItemType> CFItemTypes { get; set; }

        /// <summary>
        /// Returns true if CFItemTypeSet instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFItemTypeSet to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFItemTypeSet input)
        {
            if (input == null)
                return false;

            return
                (
                    CFItemTypes == input.CFItemTypes ||
                    CFItemTypes != null &&
                    input.CFItemTypes != null &&
                    CFItemTypes.SequenceEqual(input.CFItemTypes)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFItemTypeSet);
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
                if (CFItemTypes != null)
                    hashCode = hashCode * 59 + CFItemTypes.GetHashCode();
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
            sb.Append("class CFItemTypeSet {\n");
            sb.Append("  CFItemTypes: ").Append(CFItemTypes).Append("\n");
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
