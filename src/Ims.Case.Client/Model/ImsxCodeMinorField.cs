// -----------------------------------------------------------------------
// <copyright file="ImsxCodeMinorField.cs" company="sped-tx.net">
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
using Newtonsoft.Json.Converters;

namespace Ims.Case.Model
{
    /// <summary>
    /// This is the container for a single code minor status code.
    /// </summary>
    [DataContract]
    public partial class ImsxCodeMinorField : IEquatable<ImsxCodeMinorField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImsxCodeMinorField"/> class.
        /// </summary>
        /// <param name="imsxCodeMinorFieldName">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="imsxCodeMinorFieldValue">imsxCodeMinorFieldValue (required).</param>
        public ImsxCodeMinorField(string imsxCodeMinorFieldName = default(string), ImsxCodeMinorFieldValueEnum imsxCodeMinorFieldValue = default(ImsxCodeMinorFieldValueEnum))
        {
            // to ensure "imsxCodeMinorFieldName" is required (not null)
            if (imsxCodeMinorFieldName == null)
            {
                throw new InvalidDataException("imsxCodeMinorFieldName is a required property for ImsxCodeMinorField and cannot be null");
            }
            else
            {
                ImsxCodeMinorFieldName = imsxCodeMinorFieldName;
            }
            // to ensure "imsxCodeMinorFieldValue" is required (not null)
            if (imsxCodeMinorFieldValue == null)
            {
                throw new InvalidDataException("imsxCodeMinorFieldValue is a required property for ImsxCodeMinorField and cannot be null");
            }
            else
            {
                ImsxCodeMinorFieldValue = imsxCodeMinorFieldValue;
            }
        }

        /// <summary>
        /// Gets or sets the ImsxCodeMinorFieldName
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "imsx_codeMinorFieldName", EmitDefaultValue = false)]
        public string ImsxCodeMinorFieldName { get; set; }

        /// <summary>
        /// Gets or sets the ImsxCodeMinorFieldValue
        /// Gets or Sets ImsxCodeMinorFieldValue.
        /// </summary>
        [DataMember(Name = "imsx_codeMinorFieldValue", EmitDefaultValue = false)]
        public ImsxCodeMinorFieldValueEnum ImsxCodeMinorFieldValue { get; set; }

        /// <summary>
        /// Returns true if ImsxCodeMinorField instances are equal.
        /// </summary>
        /// <param name="input">Instance of ImsxCodeMinorField to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(ImsxCodeMinorField input)
        {
            if (input == null)
                return false;

            return
                (
                    ImsxCodeMinorFieldName == input.ImsxCodeMinorFieldName ||
                    (ImsxCodeMinorFieldName != null &&
                    ImsxCodeMinorFieldName.Equals(input.ImsxCodeMinorFieldName))
                ) &&
                (
                    ImsxCodeMinorFieldValue == input.ImsxCodeMinorFieldValue ||
                    (ImsxCodeMinorFieldValue != null &&
                    ImsxCodeMinorFieldValue.Equals(input.ImsxCodeMinorFieldValue))
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ImsxCodeMinorField);
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
                if (ImsxCodeMinorFieldName != null)
                    hashCode = hashCode * 59 + ImsxCodeMinorFieldName.GetHashCode();
                if (ImsxCodeMinorFieldValue != null)
                    hashCode = hashCode * 59 + ImsxCodeMinorFieldValue.GetHashCode();
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
            sb.Append("class ImsxCodeMinorField {\n");
            sb.Append("  ImsxCodeMinorFieldName: ").Append(ImsxCodeMinorFieldName).Append("\n");
            sb.Append("  ImsxCodeMinorFieldValue: ").Append(ImsxCodeMinorFieldValue).Append("\n");
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

        /// <summary>
        /// Defines ImsxCodeMinorFieldValue
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImsxCodeMinorFieldValueEnum
        {
            /// <summary>
            /// Enum Fullsuccess for value: fullsuccess
            /// </summary>
            [EnumMember(Value = "fullsuccess")]
            Fullsuccess = 1,
            /// <summary>
            /// Enum Invalidsortfield for value: invalid_sort_field
            /// </summary>
            [EnumMember(Value = "invalid_sort_field")]
            Invalidsortfield = 2,
            /// <summary>
            /// Enum Invalidselectionfield for value: invalid_selection_field
            /// </summary>
            [EnumMember(Value = "invalid_selection_field")]
            Invalidselectionfield = 3,
            /// <summary>
            /// Enum Forbidden for value: forbidden
            /// </summary>
            [EnumMember(Value = "forbidden")]
            Forbidden = 4,
            /// <summary>
            /// Enum Unauthorisedrequest for value: unauthorisedrequest
            /// </summary>
            [EnumMember(Value = "unauthorisedrequest")]
            Unauthorisedrequest = 5,
            /// <summary>
            /// Enum Internalservererror for value: internal_server_error
            /// </summary>
            [EnumMember(Value = "internal_server_error")]
            Internalservererror = 6,
            /// <summary>
            /// Enum Unknownobject for value: unknownobject
            /// </summary>
            [EnumMember(Value = "unknownobject")]
            Unknownobject = 7,
            /// <summary>
            /// Enum Serverbusy for value: server_busy
            /// </summary>
            [EnumMember(Value = "server_busy")]
            Serverbusy = 8,
            /// <summary>
            /// Enum Invaliduuid for value: invaliduuid
            /// </summary>
            [EnumMember(Value = "invaliduuid")]
            Invaliduuid = 9
        }
    }
}
