// -----------------------------------------------------------------------
// <copyright file="ImsxCodeMinor.cs" company="sped-tx.net">
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
    /// This is the container for the set of code minor status codes reported in the responses from the Service Provider.
    /// </summary>
    [DataContract]
    public partial class ImsxCodeMinor : IEquatable<ImsxCodeMinor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImsxCodeMinor"/> class.
        /// </summary>
        /// <param name="imsxCodeMinorField">imsxCodeMinorField (required).</param>
        public ImsxCodeMinor(List<ImsxCodeMinorField> imsxCodeMinorField = default(List<ImsxCodeMinorField>))
        {
            // to ensure "imsxCodeMinorField" is required (not null)
            if (imsxCodeMinorField == null)
            {
                throw new InvalidDataException("imsxCodeMinorField is a required property for ImsxCodeMinor and cannot be null");
            }
            else
            {
                ImsxCodeMinorField = imsxCodeMinorField;
            }
        }

        /// <summary>
        /// Gets or sets the ImsxCodeMinorField
        /// Gets or Sets ImsxCodeMinorField.
        /// </summary>
        [DataMember(Name = "imsx_codeMinorField", EmitDefaultValue = false)]
        public List<ImsxCodeMinorField> ImsxCodeMinorField { get; set; }

        /// <summary>
        /// Returns true if ImsxCodeMinor instances are equal.
        /// </summary>
        /// <param name="input">Instance of ImsxCodeMinor to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(ImsxCodeMinor input)
        {
            if (input == null)
                return false;

            return
                (
                    ImsxCodeMinorField == input.ImsxCodeMinorField ||
                    ImsxCodeMinorField != null &&
                    input.ImsxCodeMinorField != null &&
                    ImsxCodeMinorField.SequenceEqual(input.ImsxCodeMinorField)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ImsxCodeMinor);
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
                if (ImsxCodeMinorField != null)
                    hashCode = hashCode * 59 + ImsxCodeMinorField.GetHashCode();
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
            sb.Append("class ImsxCodeMinor {\n");
            sb.Append("  ImsxCodeMinorField: ").Append(ImsxCodeMinorField).Append("\n");
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
