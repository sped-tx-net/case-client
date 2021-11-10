// -----------------------------------------------------------------------
// <copyright file="ImsxStatusInfo.cs" company="sped-tx.net">
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
    /// This is the container for the status code and associated information returned within the HTTP messages received from the Service Provider. For the CASE service this object will only be returned to provide information about a failed request i.e. it will NOT be in the payload for a successful request. See Appendix B for further information on the interpretation of the information contained within this class.
    /// </summary>
    [DataContract]
    public partial class ImsxStatusInfo : IEquatable<ImsxStatusInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImsxStatusInfo"/> class.
        /// </summary>
        /// <param name="imsxCodeMajor">imsxCodeMajor (required).</param>
        /// <param name="imsxSeverity">imsxSeverity (required).</param>
        /// <param name="imsxDescription">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="imsxCodeMinor">imsxCodeMinor.</param>
        public ImsxStatusInfo(ImsxCodeMajorEnum imsxCodeMajor = default(ImsxCodeMajorEnum), ImsxSeverityEnum imsxSeverity = default(ImsxSeverityEnum), string imsxDescription = default(string), ImsxCodeMinor imsxCodeMinor = default(ImsxCodeMinor))
        {
            // to ensure "imsxCodeMajor" is required (not null)
            if (imsxCodeMajor == null)
            {
                throw new InvalidDataException("imsxCodeMajor is a required property for ImsxStatusInfo and cannot be null");
            }
            else
            {
                ImsxCodeMajor = imsxCodeMajor;
            }
            // to ensure "imsxSeverity" is required (not null)
            if (imsxSeverity == null)
            {
                throw new InvalidDataException("imsxSeverity is a required property for ImsxStatusInfo and cannot be null");
            }
            else
            {
                ImsxSeverity = imsxSeverity;
            }
            ImsxDescription = imsxDescription;
            ImsxCodeMinor = imsxCodeMinor;
        }

        /// <summary>
        /// Gets or sets the ImsxCodeMajor
        /// Gets or Sets ImsxCodeMajor.
        /// </summary>
        [DataMember(Name = "imsx_codeMajor", EmitDefaultValue = false)]
        public ImsxCodeMajorEnum ImsxCodeMajor { get; set; }

        /// <summary>
        /// Gets or sets the ImsxCodeMinor
        /// Gets or Sets ImsxCodeMinor.
        /// </summary>
        [DataMember(Name = "imsx_codeMinor", EmitDefaultValue = false)]
        public ImsxCodeMinor ImsxCodeMinor { get; set; }

        /// <summary>
        /// Gets or sets the ImsxDescription
        /// Model Primitive Datatype &#x3D; String.
        /// </summary>
        [DataMember(Name = "imsx_description", EmitDefaultValue = false)]
        public string ImsxDescription { get; set; }

        /// <summary>
        /// Gets or sets the ImsxSeverity
        /// Gets or Sets ImsxSeverity.
        /// </summary>
        [DataMember(Name = "imsx_severity", EmitDefaultValue = false)]
        public ImsxSeverityEnum ImsxSeverity { get; set; }

        /// <summary>
        /// Returns true if ImsxStatusInfo instances are equal.
        /// </summary>
        /// <param name="input">Instance of ImsxStatusInfo to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(ImsxStatusInfo input)
        {
            if (input == null)
                return false;

            return
                (
                    ImsxCodeMajor == input.ImsxCodeMajor ||
                    (ImsxCodeMajor != null &&
                    ImsxCodeMajor.Equals(input.ImsxCodeMajor))
                ) &&
                (
                    ImsxSeverity == input.ImsxSeverity ||
                    (ImsxSeverity != null &&
                    ImsxSeverity.Equals(input.ImsxSeverity))
                ) &&
                (
                    ImsxDescription == input.ImsxDescription ||
                    (ImsxDescription != null &&
                    ImsxDescription.Equals(input.ImsxDescription))
                ) &&
                (
                    ImsxCodeMinor == input.ImsxCodeMinor ||
                    (ImsxCodeMinor != null &&
                    ImsxCodeMinor.Equals(input.ImsxCodeMinor))
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as ImsxStatusInfo);
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
                if (ImsxCodeMajor != null)
                    hashCode = hashCode * 59 + ImsxCodeMajor.GetHashCode();
                if (ImsxSeverity != null)
                    hashCode = hashCode * 59 + ImsxSeverity.GetHashCode();
                if (ImsxDescription != null)
                    hashCode = hashCode * 59 + ImsxDescription.GetHashCode();
                if (ImsxCodeMinor != null)
                    hashCode = hashCode * 59 + ImsxCodeMinor.GetHashCode();
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
            sb.Append("class ImsxStatusInfo {\n");
            sb.Append("  ImsxCodeMajor: ").Append(ImsxCodeMajor).Append("\n");
            sb.Append("  ImsxSeverity: ").Append(ImsxSeverity).Append("\n");
            sb.Append("  ImsxDescription: ").Append(ImsxDescription).Append("\n");
            sb.Append("  ImsxCodeMinor: ").Append(ImsxCodeMinor).Append("\n");
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
        /// Defines ImsxCodeMajor
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImsxCodeMajorEnum
        {
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 1,
            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 2,
            /// <summary>
            /// Enum Failure for value: failure
            /// </summary>
            [EnumMember(Value = "failure")]
            Failure = 3,
            /// <summary>
            /// Enum Unsupported for value: unsupported
            /// </summary>
            [EnumMember(Value = "unsupported")]
            Unsupported = 4
        }

        /// <summary>
        /// Defines ImsxSeverity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImsxSeverityEnum
        {
            /// <summary>
            /// Enum Status for value: status
            /// </summary>
            [EnumMember(Value = "status")]
            Status = 1,
            /// <summary>
            /// Enum Warning for value: warning
            /// </summary>
            [EnumMember(Value = "warning")]
            Warning = 2,
            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 3
        }
    }
}
