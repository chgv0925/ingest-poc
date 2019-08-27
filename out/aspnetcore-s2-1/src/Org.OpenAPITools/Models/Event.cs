/*
 * GV.SCS.Store.Ingest
 *
 * Store for ingest
 *
 * The version of the OpenAPI document: 0.0.1
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;

namespace Org.OpenAPITools.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Event : IEquatable<Event>
    { 
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Rev
        /// </summary>
        [Required]
        [DataMember(Name="_rev", EmitDefaultValue=false)]
        public string Rev { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public EventSource Source { get; set; }

        /// <summary>
        /// Gets or Sets Start
        /// </summary>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// Gets or Sets End
        /// </summary>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public string End { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name="classification", EmitDefaultValue=false)]
        public List<Object> Classification { get; set; }

        /// <summary>
        /// Gets or Sets IsCrash
        /// </summary>
        [DataMember(Name="isCrash", EmitDefaultValue=false)]
        public bool IsCrash { get; set; } = false;

        /// <summary>
        /// Gets or Sets IsAutoAssigned
        /// </summary>
        [DataMember(Name="isAutoAssigned", EmitDefaultValue=false)]
        public bool IsAutoAssigned { get; set; } = false;

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  IsCrash: ").Append(IsCrash).Append("\n");
            sb.Append("  IsAutoAssigned: ").Append(IsAutoAssigned).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Event)obj);
        }

        /// <summary>
        /// Returns true if Event instances are equal
        /// </summary>
        /// <param name="other">Instance of Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Event other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Rev == other.Rev ||
                    Rev != null &&
                    Rev.Equals(other.Rev)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
                ) && 
                (
                    Start == other.Start ||
                    Start != null &&
                    Start.Equals(other.Start)
                ) && 
                (
                    End == other.End ||
                    End != null &&
                    End.Equals(other.End)
                ) && 
                (
                    Classification == other.Classification ||
                    Classification != null &&
                    other.Classification != null &&
                    Classification.SequenceEqual(other.Classification)
                ) && 
                (
                    IsCrash == other.IsCrash ||
                    
                    IsCrash.Equals(other.IsCrash)
                ) && 
                (
                    IsAutoAssigned == other.IsAutoAssigned ||
                    
                    IsAutoAssigned.Equals(other.IsAutoAssigned)
                ) && 
                (
                    Properties == other.Properties ||
                    Properties != null &&
                    other.Properties != null &&
                    Properties.SequenceEqual(other.Properties)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Rev != null)
                    hashCode = hashCode * 59 + Rev.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                    if (Start != null)
                    hashCode = hashCode * 59 + Start.GetHashCode();
                    if (End != null)
                    hashCode = hashCode * 59 + End.GetHashCode();
                    if (Classification != null)
                    hashCode = hashCode * 59 + Classification.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsCrash.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsAutoAssigned.GetHashCode();
                    if (Properties != null)
                    hashCode = hashCode * 59 + Properties.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Event left, Event right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Event left, Event right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}