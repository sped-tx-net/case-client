// -----------------------------------------------------------------------
// <copyright file="CFItem.cs" company="sped-tx.net">
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
    /// This is the container for the CFItem data outside of the context of a CFPackage. This is the content that either describes a specific competency (learning objective) or describes a grouping of competencies within the taxonomy of a Competency Framework Document.
    /// </summary>
    [DataContract]
    public partial class CFItem : CFPckgItem, IEquatable<CFItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFItem"/> class.
        /// </summary>
        /// <param name="cFDocumentURI">cFDocumentURI (required).</param>
        /// <param name="identifier">The identifier<see cref="string"/>.</param>
        /// <param name="fullStatement">The fullStatement<see cref="string"/>.</param>
        /// <param name="alternativeLabel">The alternativeLabel<see cref="string"/>.</param>
        /// <param name="cFItemType">The cFItemType<see cref="string"/>.</param>
        /// <param name="uri">The uri<see cref="string"/>.</param>
        /// <param name="humanCodingScheme">The humanCodingScheme<see cref="string"/>.</param>
        /// <param name="listEnumeration">The listEnumeration<see cref="string"/>.</param>
        /// <param name="abbreviatedStatement">The abbreviatedStatement<see cref="string"/>.</param>
        /// <param name="conceptKeywords">The conceptKeywords<see cref="List{string}"/>.</param>
        /// <param name="conceptKeywordsURI">The conceptKeywordsURI<see cref="LinkURI"/>.</param>
        /// <param name="notes">The notes<see cref="string"/>.</param>
        /// <param name="language">The language<see cref="string"/>.</param>
        /// <param name="educationLevel">The educationLevel<see cref="List{string}"/>.</param>
        /// <param name="cFItemTypeURI">The cFItemTypeURI<see cref="LinkURI"/>.</param>
        /// <param name="licenseURI">The licenseURI<see cref="LinkURI"/>.</param>
        /// <param name="statusStartDate">The statusStartDate<see cref="DateTime?"/>.</param>
        /// <param name="statusEndDate">The statusEndDate<see cref="DateTime?"/>.</param>
        /// <param name="lastChangeDateTime">The lastChangeDateTime<see cref="DateTime?"/>.</param>
        public CFItem(LinkURI cFDocumentURI = default(LinkURI), string identifier = default(string), string fullStatement = default(string), string alternativeLabel = default(string), string cFItemType = default(string), string uri = default(string), string humanCodingScheme = default(string), string listEnumeration = default(string), string abbreviatedStatement = default(string), List<string> conceptKeywords = default(List<string>), LinkURI conceptKeywordsURI = default(LinkURI), string notes = default(string), string language = default(string), string educationLevel = default, LinkURI cFItemTypeURI = default(LinkURI), LinkURI licenseURI = default(LinkURI), DateTime? statusStartDate = default(DateTime?), DateTime? statusEndDate = default(DateTime?), DateTime? lastChangeDateTime = default(DateTime?)) : base(identifier, fullStatement, alternativeLabel, cFItemType, uri, humanCodingScheme, listEnumeration, abbreviatedStatement, conceptKeywords, conceptKeywordsURI, notes, language, educationLevel, cFItemTypeURI, licenseURI, statusStartDate, statusEndDate, lastChangeDateTime)
        {
            // to ensure "cFDocumentURI" is required (not null)
            if (cFDocumentURI == null)
            {
                throw new InvalidDataException("cFDocumentURI is a required property for CFItem and cannot be null");
            }
            else
            {
                CFDocumentURI = cFDocumentURI;
            }
        }

        /// <summary>
        /// Gets or sets the CFDocumentURI
        /// Gets or Sets CFDocumentURI..
        /// </summary>
        [DataMember(Name = "CFDocumentURI", EmitDefaultValue = false)]
        public LinkURI CFDocumentURI { get; set; }

        /// <summary>
        /// Returns true if CFItem instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFItem to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFItem input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    CFDocumentURI == input.CFDocumentURI ||
                    (CFDocumentURI != null &&
                    CFDocumentURI.Equals(input.CFDocumentURI))
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFItem);
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
                if (CFDocumentURI != null)
                    hashCode = hashCode * 59 + CFDocumentURI.GetHashCode();
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
            sb.Append("class CFItem {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CFDocumentURI: ").Append(CFDocumentURI).Append("\n");
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
