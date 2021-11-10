// -----------------------------------------------------------------------
// <copyright file="CFPckgItem.cs" company="sped-tx.net">
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
using SwaggerDateConverter = Ims.Case.Client.SwaggerDateConverter;

namespace Ims.Case.Model
{
    /// <summary>
    /// This is the container for the CFItem data within the context of a CFPackage. This is the content that either describes a specific competency (learning objective) or describes a grouping of competencies within the taxonomy of a Competency Framework Document.
    /// </summary>
    [DataContract]
    public partial class CFPckgItem : IEquatable<CFPckgItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPckgItem"/> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="fullStatement">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="alternativeLabel">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="cFItemType">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="humanCodingScheme">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="listEnumeration">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="abbreviatedStatement">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="conceptKeywords">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="conceptKeywordsURI">conceptKeywordsURI.</param>
        /// <param name="notes">Model Primitive Datatype &#x3D; String.</param>
        /// <param name="language">Model Primitive Datatype &#x3D; Language.</param>
        /// <param name="educationLevel">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="cFItemTypeURI">cFItemTypeURI.</param>
        /// <param name="licenseURI">licenseURI.</param>
        /// <param name="statusStartDate">Model Primitive Datatype &#x3D; Date.</param>
        /// <param name="statusEndDate">Model Primitive Datatype &#x3D; Date.</param>
        /// <param name="lastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        public CFPckgItem(string identifier = default(string), string fullStatement = default(string), string alternativeLabel = default(string), string cFItemType = default(string), string uri = default(string), string humanCodingScheme = default(string), string listEnumeration = default(string), string abbreviatedStatement = default(string), List<string> conceptKeywords = default(List<string>), LinkURI conceptKeywordsURI = default(LinkURI), string notes = default(string), string language = default(string), string educationLevel = default, LinkURI cFItemTypeURI = default(LinkURI), LinkURI licenseURI = default(LinkURI), DateTime? statusStartDate = default(DateTime?), DateTime? statusEndDate = default(DateTime?), DateTime? lastChangeDateTime = default(DateTime?))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for CFPckgItem and cannot be null");
            }
            else
            {
                Identifier = identifier;
            }
            // to ensure "fullStatement" is required (not null)
            if (fullStatement == null)
            {
                throw new InvalidDataException("fullStatement is a required property for CFPckgItem and cannot be null");
            }
            else
            {
                FullStatement = fullStatement;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CFPckgItem and cannot be null");
            }
            else
            {
                Uri = uri;
            }
            // to ensure "lastChangeDateTime" is required (not null)
            if (lastChangeDateTime == null)
            {
                throw new InvalidDataException("lastChangeDateTime is a required property for CFPckgItem and cannot be null");
            }
            else
            {
                LastChangeDateTime = lastChangeDateTime;
            }
            AlternativeLabel = alternativeLabel;
            CFItemType = cFItemType;
            HumanCodingScheme = humanCodingScheme;
            ListEnumeration = listEnumeration;
            AbbreviatedStatement = abbreviatedStatement;
            ConceptKeywords = conceptKeywords;
            ConceptKeywordsURI = conceptKeywordsURI;
            Notes = notes;
            Language = language;
            EducationLevel = educationLevel;
            CFItemTypeURI = cFItemTypeURI;
            LicenseURI = licenseURI;
            StatusStartDate = statusStartDate;
            StatusEndDate = statusEndDate;
        }

        /// <summary>
        /// Gets or sets the AbbreviatedStatement
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "abbreviatedStatement", EmitDefaultValue = false)]
        public string AbbreviatedStatement { get; set; }

        /// <summary>
        /// Gets or sets the AlternativeLabel
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "alternativeLabel", EmitDefaultValue = false)]
        public string AlternativeLabel { get; set; }

        /// <summary>
        /// Gets or sets the CFItemType
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "CFItemType", EmitDefaultValue = false)]
        public string CFItemType { get; set; }

        /// <summary>
        /// Gets or sets the CFItemTypeURI
        /// Gets or Sets CFItemTypeURI.
        /// </summary>
        [DataMember(Name = "CFItemTypeURI", EmitDefaultValue = false)]
        public LinkURI CFItemTypeURI { get; set; }

        /// <summary>
        /// Gets or sets the ConceptKeywords
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "conceptKeywords", EmitDefaultValue = false)]
        public List<string> ConceptKeywords { get; set; }

        /// <summary>
        /// Gets or sets the ConceptKeywordsURI
        /// Gets or Sets ConceptKeywordsURI.
        /// </summary>
        [DataMember(Name = "conceptKeywordsURI", EmitDefaultValue = false)]
        public LinkURI ConceptKeywordsURI { get; set; }

        /// <summary>
        /// Gets or sets the EducationLevel
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "educationLevel", EmitDefaultValue = false)]
        public string EducationLevel { get; set; }

        /// <summary>
        /// Gets or sets the FullStatement
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "fullStatement", EmitDefaultValue = false)]
        public string FullStatement { get; set; }

        /// <summary>
        /// Gets or sets the HumanCodingScheme
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "humanCodingScheme", EmitDefaultValue = false)]
        public string HumanCodingScheme { get; set; }

        /// <summary>
        /// Gets or sets the Identifier
        /// Gets or Sets Identifier.
        /// </summary>
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets the Language
        /// Model Primitive Datatype &#x3D; Language.
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the LastChangeDateTime
        /// Model Primitive Datatype &#x3D; DateTime.
        /// </summary>
        [DataMember(Name = "lastChangeDateTime", EmitDefaultValue = false)]
        public DateTime? LastChangeDateTime { get; set; }

        /// <summary>
        /// Gets or sets the LicenseURI
        /// Gets or Sets LicenseURI.
        /// </summary>
        [DataMember(Name = "licenseURI", EmitDefaultValue = false)]
        public LinkURI LicenseURI { get; set; }

        /// <summary>
        /// Gets or sets the ListEnumeration
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "listEnumeration", EmitDefaultValue = false)]
        public string ListEnumeration { get; set; }

        /// <summary>
        /// Gets or sets the Notes
        /// Model Primitive Datatype &#x3D; String.
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the StatusEndDate
        /// Model Primitive Datatype &#x3D; Date.
        /// </summary>
        [DataMember(Name = "statusEndDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Gets or sets the StatusStartDate
        /// Model Primitive Datatype &#x3D; Date.
        /// </summary>
        [DataMember(Name = "statusStartDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? StatusStartDate { get; set; }

        /// <summary>
        /// Gets or sets the Uri
        /// Model Primitive Datatype &#x3D; AnyURI.
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Returns true if CFPckgItem instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFPckgItem to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFPckgItem input)
        {
            if (input == null)
                return false;

            return
                (
                    Identifier == input.Identifier ||
                    (Identifier != null &&
                    Identifier.Equals(input.Identifier))
                ) &&
                (
                    FullStatement == input.FullStatement ||
                    (FullStatement != null &&
                    FullStatement.Equals(input.FullStatement))
                ) &&
                (
                    AlternativeLabel == input.AlternativeLabel ||
                    (AlternativeLabel != null &&
                    AlternativeLabel.Equals(input.AlternativeLabel))
                ) &&
                (
                    CFItemType == input.CFItemType ||
                    (CFItemType != null &&
                    CFItemType.Equals(input.CFItemType))
                ) &&
                (
                    Uri == input.Uri ||
                    (Uri != null &&
                    Uri.Equals(input.Uri))
                ) &&
                (
                    HumanCodingScheme == input.HumanCodingScheme ||
                    (HumanCodingScheme != null &&
                    HumanCodingScheme.Equals(input.HumanCodingScheme))
                ) &&
                (
                    ListEnumeration == input.ListEnumeration ||
                    (ListEnumeration != null &&
                    ListEnumeration.Equals(input.ListEnumeration))
                ) &&
                (
                    AbbreviatedStatement == input.AbbreviatedStatement ||
                    (AbbreviatedStatement != null &&
                    AbbreviatedStatement.Equals(input.AbbreviatedStatement))
                ) &&
                (
                    ConceptKeywords == input.ConceptKeywords ||
                    ConceptKeywords != null &&
                    input.ConceptKeywords != null &&
                    ConceptKeywords.SequenceEqual(input.ConceptKeywords)
                ) &&
                (
                    ConceptKeywordsURI == input.ConceptKeywordsURI ||
                    (ConceptKeywordsURI != null &&
                    ConceptKeywordsURI.Equals(input.ConceptKeywordsURI))
                ) &&
                (
                    Notes == input.Notes ||
                    (Notes != null &&
                    Notes.Equals(input.Notes))
                ) &&
                (
                    Language == input.Language ||
                    (Language != null &&
                    Language.Equals(input.Language))
                ) &&
                (
                    EducationLevel == input.EducationLevel ||
                    EducationLevel != null &&
                    input.EducationLevel != null &&
                    EducationLevel.SequenceEqual(input.EducationLevel)
                ) &&
                (
                    CFItemTypeURI == input.CFItemTypeURI ||
                    (CFItemTypeURI != null &&
                    CFItemTypeURI.Equals(input.CFItemTypeURI))
                ) &&
                (
                    LicenseURI == input.LicenseURI ||
                    (LicenseURI != null &&
                    LicenseURI.Equals(input.LicenseURI))
                ) &&
                (
                    StatusStartDate == input.StatusStartDate ||
                    (StatusStartDate != null &&
                    StatusStartDate.Equals(input.StatusStartDate))
                ) &&
                (
                    StatusEndDate == input.StatusEndDate ||
                    (StatusEndDate != null &&
                    StatusEndDate.Equals(input.StatusEndDate))
                ) &&
                (
                    LastChangeDateTime == input.LastChangeDateTime ||
                    (LastChangeDateTime != null &&
                    LastChangeDateTime.Equals(input.LastChangeDateTime))
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFPckgItem);
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
                if (Identifier != null)
                    hashCode = hashCode * 59 + Identifier.GetHashCode();
                if (FullStatement != null)
                    hashCode = hashCode * 59 + FullStatement.GetHashCode();
                if (AlternativeLabel != null)
                    hashCode = hashCode * 59 + AlternativeLabel.GetHashCode();
                if (CFItemType != null)
                    hashCode = hashCode * 59 + CFItemType.GetHashCode();
                if (Uri != null)
                    hashCode = hashCode * 59 + Uri.GetHashCode();
                if (HumanCodingScheme != null)
                    hashCode = hashCode * 59 + HumanCodingScheme.GetHashCode();
                if (ListEnumeration != null)
                    hashCode = hashCode * 59 + ListEnumeration.GetHashCode();
                if (AbbreviatedStatement != null)
                    hashCode = hashCode * 59 + AbbreviatedStatement.GetHashCode();
                if (ConceptKeywords != null)
                    hashCode = hashCode * 59 + ConceptKeywords.GetHashCode();
                if (ConceptKeywordsURI != null)
                    hashCode = hashCode * 59 + ConceptKeywordsURI.GetHashCode();
                if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                if (EducationLevel != null)
                    hashCode = hashCode * 59 + EducationLevel.GetHashCode();
                if (CFItemTypeURI != null)
                    hashCode = hashCode * 59 + CFItemTypeURI.GetHashCode();
                if (LicenseURI != null)
                    hashCode = hashCode * 59 + LicenseURI.GetHashCode();
                if (StatusStartDate != null)
                    hashCode = hashCode * 59 + StatusStartDate.GetHashCode();
                if (StatusEndDate != null)
                    hashCode = hashCode * 59 + StatusEndDate.GetHashCode();
                if (LastChangeDateTime != null)
                    hashCode = hashCode * 59 + LastChangeDateTime.GetHashCode();
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
            sb.Append("class CFPckgItem {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  FullStatement: ").Append(FullStatement).Append("\n");
            sb.Append("  AlternativeLabel: ").Append(AlternativeLabel).Append("\n");
            sb.Append("  CFItemType: ").Append(CFItemType).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  HumanCodingScheme: ").Append(HumanCodingScheme).Append("\n");
            sb.Append("  ListEnumeration: ").Append(ListEnumeration).Append("\n");
            sb.Append("  AbbreviatedStatement: ").Append(AbbreviatedStatement).Append("\n");
            sb.Append("  ConceptKeywords: ").Append(ConceptKeywords).Append("\n");
            sb.Append("  ConceptKeywordsURI: ").Append(ConceptKeywordsURI).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  EducationLevel: ").Append(EducationLevel).Append("\n");
            sb.Append("  CFItemTypeURI: ").Append(CFItemTypeURI).Append("\n");
            sb.Append("  LicenseURI: ").Append(LicenseURI).Append("\n");
            sb.Append("  StatusStartDate: ").Append(StatusStartDate).Append("\n");
            sb.Append("  StatusEndDate: ").Append(StatusEndDate).Append("\n");
            sb.Append("  LastChangeDateTime: ").Append(LastChangeDateTime).Append("\n");
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
