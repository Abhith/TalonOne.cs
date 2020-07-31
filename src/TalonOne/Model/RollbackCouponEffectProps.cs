/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// The properties specific to the \&quot;rollbackCoupon\&quot; effect. This gets triggered whenever previously closed session is now cancelled and a coupon redemption was cancelled on our internal usage limit counters.
    /// </summary>
    [DataContract]
    public partial class RollbackCouponEffectProps :  IEquatable<RollbackCouponEffectProps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackCouponEffectProps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RollbackCouponEffectProps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RollbackCouponEffectProps" /> class.
        /// </summary>
        /// <param name="value">The coupon code whose usage has been rolled back (required).</param>
        public RollbackCouponEffectProps(string value = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for RollbackCouponEffectProps and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            
        }
        
        /// <summary>
        /// The coupon code whose usage has been rolled back
        /// </summary>
        /// <value>The coupon code whose usage has been rolled back</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollbackCouponEffectProps {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as RollbackCouponEffectProps);
        }

        /// <summary>
        /// Returns true if RollbackCouponEffectProps instances are equal
        /// </summary>
        /// <param name="input">Instance of RollbackCouponEffectProps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RollbackCouponEffectProps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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