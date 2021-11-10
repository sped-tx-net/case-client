// -----------------------------------------------------------------------
// <copyright file="CFDocument.cs" company="sped-tx.net">
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

namespace Ims.Case.Model
{
    /// <summary>
    /// The container for the data about a competency framework document (CFDocument) when exchanged outside of the context of a CFPackage. A CFDocument is the root for the creation of a learning standard/competency.
    /// </summary>
    [DataContract]
    public partial class CFDocument : CFPckgDocument, IEquatable<CFDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFDocument"/> class.
        /// </summary>
        /// <param name="cFPackageURI">cFPackageURI (required).</param>
        /// <param name="identifier">The identifier<see cref="string"/>.</param>
        /// <param name="uri">The uri<see cref="string"/>.</param>
        /// <param name="creator">The creator<see cref="string"/>.</param>
        /// <param name="title">The title<see cref="string"/>.</param>
        /// <param name="lastChangeDateTime">The lastChangeDateTime<see cref="DateTime?"/>.</param>
        /// <param name="officialSourceURL">The officialSourceURL<see cref="string"/>.</param>
        /// <param name="publisher">The publisher<see cref="string"/>.</param>
        /// <param name="description">The description<see cref="string"/>.</param>
        /// <param name="subject">The subject<see cref="List{string}"/>.</param>
        /// <param name="subjectURI">The subjectURI<see cref="List{LinkURI}"/>.</param>
        /// <param name="language">The language<see cref="string"/>.</param>
        /// <param name="version">The version<see cref="string"/>.</param>
        /// <param name="adoptionStatus">The adoptionStatus<see cref="string"/>.</param>
        /// <param name="statusStartDate">The statusStartDate<see cref="DateTime?"/>.</param>
        /// <param name="statusEndDate">The statusEndDate<see cref="DateTime?"/>.</param>
        /// <param name="licenseURI">The licenseURI<see cref="LinkURI"/>.</param>
        /// <param name="notes">The notes<see cref="string"/>.</param>
        public CFDocument(LinkURI cFPackageURI = default(LinkURI), string identifier = default(string), string uri = default(string), string creator = default(string), string title = default(string), DateTime? lastChangeDateTime = default(DateTime?), string officialSourceURL = default(string), string publisher = default(string), string description = default(string), string subject = default, List<LinkURI> subjectURI = default(List<LinkURI>), string language = default(string), string version = default(string), string adoptionStatus = default(string), DateTime? statusStartDate = default(DateTime?), DateTime? statusEndDate = default(DateTime?), LinkURI licenseURI = default(LinkURI), string notes = default(string)) : base(identifier, uri, creator, title, lastChangeDateTime, officialSourceURL, publisher, description, subject, subjectURI, language, version, adoptionStatus, statusStartDate, statusEndDate, licenseURI, notes)
        {
            // to ensure "cFPackageURI" is required (not null)
            if (cFPackageURI == null)
            {
                throw new InvalidDataException("cFPackageURI is a required property for CFDocument and cannot be null");
            }
            else
            {
                CFPackageURI = cFPackageURI;
            }
        }

        /// <summary>
        /// Gets or sets the CFPackageURI
        /// Gets or Sets CFPackageURI..
        /// </summary>
        [DataMember(Name = "CFPackageURI", EmitDefaultValue = false)]
        public LinkURI CFPackageURI { get; set; }

        /// <summary>
        /// Returns true if CFDocument instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFDocument to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFDocument input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    CFPackageURI == input.CFPackageURI ||
                    (CFPackageURI != null &&
                    CFPackageURI.Equals(input.CFPackageURI))
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFDocument);
        }

        /// <summary>
        /// Gets the hash code.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (CFPackageURI != null)
                    hashCode = hashCode * 59 + CFPackageURI.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns the JSON string presentation of the object.
        /// </summary>
        /// <returns>JSON string presentation of the object.</returns>
        public override string ToJson()
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
            sb.Append("class CFDocument {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CFPackageURI: ").Append(CFPackageURI).Append("\n");
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
