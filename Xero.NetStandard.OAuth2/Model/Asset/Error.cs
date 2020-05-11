/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
 *
 * The version of the OpenAPI document: 2.1.2
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// Error
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        
        /// <summary>
        /// Array of elements of resource validation errors
        /// </summary>
        /// <value>Array of elements of resource validation errors</value>
        [DataMember(Name="resourceValidationErrors", EmitDefaultValue=false)]
        public List<ResourceValidationErrorsElement> ResourceValidationErrors { get; set; }

        /// <summary>
        /// Array of elements of field validation errors
        /// </summary>
        /// <value>Array of elements of field validation errors</value>
        [DataMember(Name="fieldValidationErrors", EmitDefaultValue=false)]
        public List<FieldValidationErrorsElement> FieldValidationErrors { get; set; }

        /// <summary>
        /// The internal type of error, not accessible externally
        /// </summary>
        /// <value>The internal type of error, not accessible externally</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Title of the error
        /// </summary>
        /// <value>Title of the error</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Detail of the error
        /// </summary>
        /// <value>Detail of the error</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  ResourceValidationErrors: ").Append(ResourceValidationErrors).Append("\n");
            sb.Append("  FieldValidationErrors: ").Append(FieldValidationErrors).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceValidationErrors == input.ResourceValidationErrors ||
                    this.ResourceValidationErrors != null &&
                    input.ResourceValidationErrors != null &&
                    this.ResourceValidationErrors.SequenceEqual(input.ResourceValidationErrors)
                ) && 
                (
                    this.FieldValidationErrors == input.FieldValidationErrors ||
                    this.FieldValidationErrors != null &&
                    input.FieldValidationErrors != null &&
                    this.FieldValidationErrors.SequenceEqual(input.FieldValidationErrors)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResourceValidationErrors != null)
                    hashCode = hashCode * 59 + this.ResourceValidationErrors.GetHashCode();
                if (this.FieldValidationErrors != null)
                    hashCode = hashCode * 59 + this.FieldValidationErrors.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
