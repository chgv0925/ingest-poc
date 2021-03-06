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
    public partial class SeriesModel : IEquatable<SeriesModel>
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
        /// Gets or Sets Repeat
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<RepeatEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum RepeatEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum EveryDayEnum for EveryDay
            /// </summary>
            [EnumMember(Value = "EveryDay")]
            EveryDayEnum = 2,
            
            /// <summary>
            /// Enum EveryWeekEnum for EveryWeek
            /// </summary>
            [EnumMember(Value = "EveryWeek")]
            EveryWeekEnum = 3,
            
            /// <summary>
            /// Enum EveryMonthEnum for EveryMonth
            /// </summary>
            [EnumMember(Value = "EveryMonth")]
            EveryMonthEnum = 4,
            
            /// <summary>
            /// Enum EveryYearEnum for EveryYear
            /// </summary>
            [EnumMember(Value = "EveryYear")]
            EveryYearEnum = 5
        }

        /// <summary>
        /// Gets or Sets Repeat
        /// </summary>
        [DataMember(Name="repeat", EmitDefaultValue=false)]
        public RepeatEnum Repeat { get; set; } = RepeatEnum.NoneEnum;

        /// <summary>
        /// Gets or Sets EndBy
        /// </summary>
        [DataMember(Name="endBy", EmitDefaultValue=false)]
        public DateTime EndBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeriesModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rev: ").Append(Rev).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
            sb.Append("  Repeat: ").Append(Repeat).Append("\n");
            sb.Append("  EndBy: ").Append(EndBy).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SeriesModel)obj);
        }

        /// <summary>
        /// Returns true if SeriesModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SeriesModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesModel other)
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
                    Repeat == other.Repeat ||
                    
                    Repeat.Equals(other.Repeat)
                ) && 
                (
                    EndBy == other.EndBy ||
                    EndBy != null &&
                    EndBy.Equals(other.EndBy)
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
                    if (Start != null)
                    hashCode = hashCode * 59 + Start.GetHashCode();
                    if (End != null)
                    hashCode = hashCode * 59 + End.GetHashCode();
                    
                    hashCode = hashCode * 59 + Repeat.GetHashCode();
                    if (EndBy != null)
                    hashCode = hashCode * 59 + EndBy.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SeriesModel left, SeriesModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SeriesModel left, SeriesModel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
