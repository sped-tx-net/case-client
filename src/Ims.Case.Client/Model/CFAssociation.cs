// -----------------------------------------------------------------------
// <copyright file="CFAssociation.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ims.Case.Model
{
    /// <summary>
    /// This is the container for the data about the relationship between two CFDocuments or between two CFItems outside of the context of a CFPackage or CFItem.
    /// </summary>
    [DataContract]
    public partial class CFAssociation : CFPckgAssociation, IEquatable<CFAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFAssociation"/> class.
        /// </summary>
        /// <param name="cFDocumentURI">cFDocumentURI.</param>
        /// <param name="identifier">The identifier<see cref="string"/>.</param>
        /// <param name="associationType">The associationType<see cref="AssociationTypeEnum"/>.</param>
        /// <param name="sequenceNumber">The sequenceNumber<see cref="int?"/>.</param>
        /// <param name="uri">The uri<see cref="string"/>.</param>
        /// <param name="originNodeURI">The originNodeURI<see cref="LinkGenURI"/>.</param>
        /// <param name="destinationNodeURI">The destinationNodeURI<see cref="LinkGenURI"/>.</param>
        /// <param name="cFAssociationGroupingURI">The cFAssociationGroupingURI<see cref="LinkURI"/>.</param>
        /// <param name="lastChangeDateTime">The lastChangeDateTime<see cref="DateTime?"/>.</param>
        public CFAssociation(LinkURI cFDocumentURI = default(LinkURI), string identifier = default(string), AssociationTypeEnum associationType = default(AssociationTypeEnum), int? sequenceNumber = default(int?), string uri = default(string), LinkGenURI originNodeURI = default(LinkGenURI), LinkGenURI destinationNodeURI = default(LinkGenURI), LinkURI cFAssociationGroupingURI = default(LinkURI), DateTime? lastChangeDateTime = default(DateTime?)) : base(identifier, associationType, sequenceNumber, uri, originNodeURI, destinationNodeURI, cFAssociationGroupingURI, lastChangeDateTime)
        {
            CFDocumentURI = cFDocumentURI;
        }

        /// <summary>
        /// Gets or sets the CFDocumentURI
        /// Gets or Sets CFDocumentURI..
        /// </summary>
        [DataMember(Name = "CFDocumentURI", EmitDefaultValue = false)]
        public LinkURI CFDocumentURI { get; set; }

        /// <summary>
        /// Returns true if CFAssociation instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFAssociation to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFAssociation input)
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
            return Equals(input as CFAssociation);
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
            sb.Append("class CFAssociation {\n");
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
