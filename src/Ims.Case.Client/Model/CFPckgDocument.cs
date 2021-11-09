// -----------------------------------------------------------------------
// <copyright file="CFPckgDocument.cs" company="sped-tx.net">
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
    /// The container for the data about a competency framework document (CFDocument) within a CFPackage. A CFDocument is the root for the creation of a learning standard/competency.
    /// </summary>
    [DataContract]
    public partial class CFPckgDocument : IEquatable<CFPckgDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPckgDocument"/> class.
        /// </summary>
        /// <param name="identifier">identifier (required).</param>
        /// <param name="uri">Model Primitive Datatype &#x3D; AnyURI (required).</param>
        /// <param name="creator">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="title">Model Primitive Datatype &#x3D; NormalizedString (required).</param>
        /// <param name="lastChangeDateTime">Model Primitive Datatype &#x3D; DateTime (required).</param>
        /// <param name="officialSourceURL">officialSourceURL.</param>
        /// <param name="publisher">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="description">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="subject">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="subjectURI">subjectURI.</param>
        /// <param name="language">Model Primitive Datatype &#x3D; Language.</param>
        /// <param name="version">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="adoptionStatus">Model Primitive Datatype &#x3D; NormalizedString.</param>
        /// <param name="statusStartDate">Model Primitive Datatype &#x3D; Date.</param>
        /// <param name="statusEndDate">Model Primitive Datatype &#x3D; Date.</param>
        /// <param name="licenseURI">licenseURI.</param>
        /// <param name="notes">Model Primitive Datatype &#x3D; String.</param>
        public CFPckgDocument(string identifier = default(string), string uri = default(string), string creator = default(string), string title = default(string), DateTime? lastChangeDateTime = default(DateTime?), string officialSourceURL = default(string), string publisher = default(string), string description = default(string), string subject = default, List<LinkURI> subjectURI = default(List<LinkURI>), string language = default(string), string version = default(string), string adoptionStatus = default(string), DateTime? statusStartDate = default(DateTime?), DateTime? statusEndDate = default(DateTime?), LinkURI licenseURI = default(LinkURI), string notes = default(string))
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for CFPckgDocument and cannot be null");
            }
            else
            {
                Identifier = identifier;
            }
            // to ensure "uri" is required (not null)
            if (uri == null)
            {
                throw new InvalidDataException("uri is a required property for CFPckgDocument and cannot be null");
            }
            else
            {
                Uri = uri;
            }
            // to ensure "creator" is required (not null)
            if (creator == null)
            {
                throw new InvalidDataException("creator is a required property for CFPckgDocument and cannot be null");
            }
            else
            {
                Creator = creator;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for CFPckgDocument and cannot be null");
            }
            else
            {
                Title = title;
            }
            // to ensure "lastChangeDateTime" is required (not null)
            if (lastChangeDateTime == null)
            {
                throw new InvalidDataException("lastChangeDateTime is a required property for CFPckgDocument and cannot be null");
            }
            else
            {
                LastChangeDateTime = lastChangeDateTime;
            }
            OfficialSourceURL = officialSourceURL;
            Publisher = publisher;
            Description = description;
            Subject = subject;
            SubjectURI = subjectURI;
            Language = language;
            Version = version;
            AdoptionStatus = adoptionStatus;
            StatusStartDate = statusStartDate;
            StatusEndDate = statusEndDate;
            LicenseURI = licenseURI;
            Notes = notes;
        }

        /// <summary>
        /// Gets or sets the AdoptionStatus
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "adoptionStatus", EmitDefaultValue = false)]
        public string AdoptionStatus { get; set; }

        /// <summary>
        /// Gets or sets the Creator
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

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
        /// Gets or sets the Notes
        /// Model Primitive Datatype &#x3D; String.
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the OfficialSourceURL
        /// Gets or Sets OfficialSourceURL.
        /// </summary>
        [DataMember(Name = "officialSourceURL", EmitDefaultValue = false)]
        public string OfficialSourceURL { get; set; }

        /// <summary>
        /// Gets or sets the Publisher
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "publisher", EmitDefaultValue = false)]
        public string Publisher { get; set; }

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
        /// Gets or sets the Subject
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the SubjectURI
        /// Gets or Sets SubjectURI.
        /// </summary>
        [DataMember(Name = "subjectURI", EmitDefaultValue = false)]
        public List<LinkURI> SubjectURI { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Uri
        /// Model Primitive Datatype &#x3D; AnyURI.
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the Version
        /// Model Primitive Datatype &#x3D; NormalizedString.
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns true if CFPckgDocument instances are equal.
        /// </summary>
        /// <param name="input">Instance of CFPckgDocument to be compared.</param>
        /// <returns>Boolean.</returns>
        public bool Equals(CFPckgDocument input)
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
                    Uri == input.Uri ||
                    (Uri != null &&
                    Uri.Equals(input.Uri))
                ) &&
                (
                    Creator == input.Creator ||
                    (Creator != null &&
                    Creator.Equals(input.Creator))
                ) &&
                (
                    Title == input.Title ||
                    (Title != null &&
                    Title.Equals(input.Title))
                ) &&
                (
                    LastChangeDateTime == input.LastChangeDateTime ||
                    (LastChangeDateTime != null &&
                    LastChangeDateTime.Equals(input.LastChangeDateTime))
                ) &&
                (
                    OfficialSourceURL == input.OfficialSourceURL ||
                    (OfficialSourceURL != null &&
                    OfficialSourceURL.Equals(input.OfficialSourceURL))
                ) &&
                (
                    Publisher == input.Publisher ||
                    (Publisher != null &&
                    Publisher.Equals(input.Publisher))
                ) &&
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) &&
                (
                    Subject == input.Subject ||
                    Subject != null &&
                    input.Subject != null &&
                    Subject.SequenceEqual(input.Subject)
                ) &&
                (
                    SubjectURI == input.SubjectURI ||
                    SubjectURI != null &&
                    input.SubjectURI != null &&
                    SubjectURI.SequenceEqual(input.SubjectURI)
                ) &&
                (
                    Language == input.Language ||
                    (Language != null &&
                    Language.Equals(input.Language))
                ) &&
                (
                    Version == input.Version ||
                    (Version != null &&
                    Version.Equals(input.Version))
                ) &&
                (
                    AdoptionStatus == input.AdoptionStatus ||
                    (AdoptionStatus != null &&
                    AdoptionStatus.Equals(input.AdoptionStatus))
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
                    LicenseURI == input.LicenseURI ||
                    (LicenseURI != null &&
                    LicenseURI.Equals(input.LicenseURI))
                ) &&
                (
                    Notes == input.Notes ||
                    (Notes != null &&
                    Notes.Equals(input.Notes))
                );
        }

        /// <summary>
        /// Returns true if objects are equal.
        /// </summary>
        /// <param name="input">Object to be compared.</param>
        /// <returns>Boolean.</returns>
        public override bool Equals(object input)
        {
            return Equals(input as CFPckgDocument);
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
                if (Uri != null)
                    hashCode = hashCode * 59 + Uri.GetHashCode();
                if (Creator != null)
                    hashCode = hashCode * 59 + Creator.GetHashCode();
                if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                if (LastChangeDateTime != null)
                    hashCode = hashCode * 59 + LastChangeDateTime.GetHashCode();
                if (OfficialSourceURL != null)
                    hashCode = hashCode * 59 + OfficialSourceURL.GetHashCode();
                if (Publisher != null)
                    hashCode = hashCode * 59 + Publisher.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                if (SubjectURI != null)
                    hashCode = hashCode * 59 + SubjectURI.GetHashCode();
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                if (AdoptionStatus != null)
                    hashCode = hashCode * 59 + AdoptionStatus.GetHashCode();
                if (StatusStartDate != null)
                    hashCode = hashCode * 59 + StatusStartDate.GetHashCode();
                if (StatusEndDate != null)
                    hashCode = hashCode * 59 + StatusEndDate.GetHashCode();
                if (LicenseURI != null)
                    hashCode = hashCode * 59 + LicenseURI.GetHashCode();
                if (Notes != null)
                    hashCode = hashCode * 59 + Notes.GetHashCode();
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
            sb.Append("class CFPckgDocument {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  LastChangeDateTime: ").Append(LastChangeDateTime).Append("\n");
            sb.Append("  OfficialSourceURL: ").Append(OfficialSourceURL).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  SubjectURI: ").Append(SubjectURI).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  AdoptionStatus: ").Append(AdoptionStatus).Append("\n");
            sb.Append("  StatusStartDate: ").Append(StatusStartDate).Append("\n");
            sb.Append("  StatusEndDate: ").Append(StatusEndDate).Append("\n");
            sb.Append("  LicenseURI: ").Append(LicenseURI).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
