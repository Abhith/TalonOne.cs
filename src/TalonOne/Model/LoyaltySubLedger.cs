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
    /// Ledger of Balance in Loyalty Program for a Customer
    /// </summary>
    [DataContract]
    public partial class LoyaltySubLedger :  IEquatable<LoyaltySubLedger>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltySubLedger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LoyaltySubLedger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LoyaltySubLedger" /> class.
        /// </summary>
        /// <param name="total">total (required).</param>
        /// <param name="transactions">Transactions contains a list of all events that have happened such as additions, subtractions and expiries.</param>
        /// <param name="expiringPoints">ExpiringPoints contains a list of all points that will expiry and when.</param>
        public LoyaltySubLedger(decimal? total = default(decimal?), List<LoyaltyLedgerEntry> transactions = default(List<LoyaltyLedgerEntry>), List<LoyaltyLedgerEntry> expiringPoints = default(List<LoyaltyLedgerEntry>))
        {
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for LoyaltySubLedger and cannot be null");
            }
            else
            {
                this.Total = total;
            }
            this.Transactions = transactions;
            this.ExpiringPoints = expiringPoints;
        }
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Transactions contains a list of all events that have happened such as additions, subtractions and expiries
        /// </summary>
        /// <value>Transactions contains a list of all events that have happened such as additions, subtractions and expiries</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<LoyaltyLedgerEntry> Transactions { get; set; }

        /// <summary>
        /// ExpiringPoints contains a list of all points that will expiry and when
        /// </summary>
        /// <value>ExpiringPoints contains a list of all points that will expiry and when</value>
        [DataMember(Name="expiringPoints", EmitDefaultValue=false)]
        public List<LoyaltyLedgerEntry> ExpiringPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoyaltySubLedger {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  ExpiringPoints: ").Append(ExpiringPoints).Append("\n");
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
            return this.Equals(input as LoyaltySubLedger);
        }

        /// <summary>
        /// Returns true if LoyaltySubLedger instances are equal
        /// </summary>
        /// <param name="input">Instance of LoyaltySubLedger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoyaltySubLedger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.ExpiringPoints == input.ExpiringPoints ||
                    this.ExpiringPoints != null &&
                    this.ExpiringPoints.SequenceEqual(input.ExpiringPoints)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.ExpiringPoints != null)
                    hashCode = hashCode * 59 + this.ExpiringPoints.GetHashCode();
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