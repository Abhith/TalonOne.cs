/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// LoyaltyMembership
    /// </summary>
    [DataContract]
    public partial class LoyaltyMembership :  IEquatable<LoyaltyMembership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyMembership" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltyMembership() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltyMembership" /> class.
        /// </summary>
        /// <param name="joined">The moment in which the loyalty program was joined..</param>
        /// <param name="loyaltyProgramId">The ID of the loyalty program belonging to this entity. (required).</param>
        public LoyaltyMembership(DateTime? joined = default(DateTime?), int? loyaltyProgramId = default(int?))
        {
            // to ensure "loyaltyProgramId" is required (not null)
            if (loyaltyProgramId == null)
            {
                throw new InvalidDataException("loyaltyProgramId is a required property for LoyaltyMembership and cannot be null");
            }
            else
            {
                this.LoyaltyProgramId = loyaltyProgramId;
            }
            this.Joined = joined;
        }
        
        /// <summary>
        /// The moment in which the loyalty program was joined.
        /// </summary>
        /// <value>The moment in which the loyalty program was joined.</value>
        [DataMember(Name="joined", EmitDefaultValue=false)]
        public DateTime? Joined { get; set; }

        /// <summary>
        /// The ID of the loyalty program belonging to this entity.
        /// </summary>
        /// <value>The ID of the loyalty program belonging to this entity.</value>
        [DataMember(Name="loyaltyProgramId", EmitDefaultValue=false)]
        public int? LoyaltyProgramId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltyMembership {\n");
            sb.Append("  Joined: ").Append(Joined).Append("\n");
            sb.Append("  LoyaltyProgramId: ").Append(LoyaltyProgramId).Append("\n");
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
            return this.Equals(input as LoyaltyMembership);
        }

        /// <summary>
        /// Returns true if LoyaltyMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltyMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltyMembership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Joined == input.Joined ||
                    (this.Joined != null &&
                    this.Joined.Equals(input.Joined))
                ) && 
                (
                    this.LoyaltyProgramId == input.LoyaltyProgramId ||
                    (this.LoyaltyProgramId != null &&
                    this.LoyaltyProgramId.Equals(input.LoyaltyProgramId))
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
                if (this.Joined != null)
                    hashCode = hashCode * 59 + this.Joined.GetHashCode();
                if (this.LoyaltyProgramId != null)
                    hashCode = hashCode * 59 + this.LoyaltyProgramId.GetHashCode();
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