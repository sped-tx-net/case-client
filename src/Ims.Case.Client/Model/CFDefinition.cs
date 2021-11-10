// -----------------------------------------------------------------------
// <copyright file="CFDefinition.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ims.Case.Model
{
    /// <summary>
    /// The container for the set of definitions used for the competency framework i.e. the set of CFSubjects, CFConcepts, CFItemTypes, CFAssociationGroupings and CFLicenses.
    /// </summary>
    [DataContract]
    public partial class CFDefinition : IEquatable<CFDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFDefinition"/> class.
        /// </summary>
        /// <param name="cFConcepts">cFConcepts.</param>
        /// <param name="cFSubjects">cFSubjects.</param>
        /// <param name="cFLicenses">cFLicenses.</param>
        /// <param name="cFItemTypes">cFItemTypes.</param>
        /// <param name="cFAssociationGroupings">cFAssociationGroupings.</param>
        public CFDefinition(List<CFConcept> cFConcepts = default(List<CFConcept>), List<CFSubject> cFSubjects = default(List<CFSubject>), List<CFLicense> cFLicenses = default(List<CFLicense>), List<CFItemType> cFItemTypes = default(List<CFItemType>), List<CFAssociationGrouping> cFAssociationGroupings = default(List<CFAssociationGrouping>))
        {
            CFConcepts = cFConcepts;
            CFSubjects = cFSubjects;
            CFLicenses = cFLicenses;
            CFItemTypes = cFItemTypes;
            CFAssociationGroupings = cFAssociationGroupings;
        }

        /// <summary>
        /// Gets or sets the CFAssociationGroupings
        /// Gets or Sets CFAssociationGroupings..
        /// </summary>
        [DataMember(Name = "CFAssociationGroupings", EmitDefaultValue = false)]
        public List<CFAssociationGrouping> CFAssociationGroupings { get; set; }

        /// <summary>
        /// Gets or sets the CFConcepts
        /// Gets or Sets CFConcepts..
        /// </summary>
        [DataMember(Name = "CFConcepts", EmitDefaultValue = false)]
        public List<CFConcept> CFConcepts { get; set; }

        /// <summary>
        /// Gets or sets the CFItemTypes
        /// Gets or Sets CFItemTypes..
        /// </summary>
        [DataMember(Name = "CFItemTypes", EmitDefaultValue = false)]
        public List<CFItemType> CFItemTypes { get; set; }

        /// <summary>
        /// Gets or sets the CFLicenses
        /// Gets or Sets CFLicenses..
        /// </summary>
        [DataMember(Name = "CFLicenses", EmitDefaultValue = false)]
        public List<CFLicense> CFLicenses { get; set; }

        /// <summary>
        /// Gets or sets the CFSubjects
        /// Gets or Sets CFSubjects..
        /// </summary>
        [DataMember(Name = "CFSubjects", EmitDefaultValue = false)]
        public List<CFSubject> CFSubjects { get; set; }

        /// <summary>
        /// Returns true if CFDefinition instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFDefinition to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFDefinition input)
        {
            if (input == null)
                return false;

            return
                (
                    CFConcepts == input.CFConcepts ||
                    CFConcepts != null &&
                    input.CFConcepts != null &&
                    CFConcepts.SequenceEqual(input.CFConcepts)
                ) &&
                (
                    CFSubjects == input.CFSubjects ||
                    CFSubjects != null &&
                    input.CFSubjects != null &&
                    CFSubjects.SequenceEqual(input.CFSubjects)
                ) &&
                (
                    CFLicenses == input.CFLicenses ||
                    CFLicenses != null &&
                    input.CFLicenses != null &&
                    CFLicenses.SequenceEqual(input.CFLicenses)
                ) &&
                (
                    CFItemTypes == input.CFItemTypes ||
                    CFItemTypes != null &&
                    input.CFItemTypes != null &&
                    CFItemTypes.SequenceEqual(input.CFItemTypes)
                ) &&
                (
                    CFAssociationGroupings == input.CFAssociationGroupings ||
                    CFAssociationGroupings != null &&
                    input.CFAssociationGroupings != null &&
                    CFAssociationGroupings.SequenceEqual(input.CFAssociationGroupings)
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFDefinition);
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
                if (CFSubjects != null)
                    hashCode = hashCode * 59 + CFSubjects.GetHashCode();
                if (CFLicenses != null)
                    hashCode = hashCode * 59 + CFLicenses.GetHashCode();
                if (CFItemTypes != null)
                    hashCode = hashCode * 59 + CFItemTypes.GetHashCode();
                if (CFAssociationGroupings != null)
                    hashCode = hashCode * 59 + CFAssociationGroupings.GetHashCode();
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
            sb.Append("class CFDefinition {\n");
            sb.Append("  CFConcepts: ").Append(CFConcepts).Append("\n");
            sb.Append("  CFSubjects: ").Append(CFSubjects).Append("\n");
            sb.Append("  CFLicenses: ").Append(CFLicenses).Append("\n");
            sb.Append("  CFItemTypes: ").Append(CFItemTypes).Append("\n");
            sb.Append("  CFAssociationGroupings: ").Append(CFAssociationGroupings).Append("\n");
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
