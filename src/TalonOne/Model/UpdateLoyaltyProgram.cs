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
    /// Update Loyalty Program
    /// </summary>
    [DataContract]
    public partial class UpdateLoyaltyProgram :  IEquatable<UpdateLoyaltyProgram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateLoyaltyProgram" /> class.
        /// </summary>
        /// <param name="title">The display title for the Loyalty Program..</param>
        /// <param name="description">Description of our Loyalty Program..</param>
        /// <param name="subscribedApplications">A list containing the IDs of all applications that are subscribed to this Loyalty Program..</param>
        /// <param name="defaultValidity">Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39;..</param>
        /// <param name="defaultPending">Indicates the default duration for the pending time, after which points will be valid. The format is a number followed by a duration unit, like &#39;1h&#39; or &#39;40m&#39;..</param>
        /// <param name="allowSubledger">Indicates if this program supports subledgers inside the program.</param>
        public UpdateLoyaltyProgram(string title = default(string), string description = default(string), List<int> subscribedApplications = default(List<int>), string defaultValidity = default(string), string defaultPending = default(string), bool allowSubledger = default(bool))
        {
            this.Title = title;
            this.Description = description;
            this.SubscribedApplications = subscribedApplications;
            this.DefaultValidity = defaultValidity;
            this.DefaultPending = defaultPending;
            this.AllowSubledger = allowSubledger;
        }
        
        /// <summary>
        /// The display title for the Loyalty Program.
        /// </summary>
        /// <value>The display title for the Loyalty Program.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Description of our Loyalty Program.
        /// </summary>
        /// <value>Description of our Loyalty Program.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list containing the IDs of all applications that are subscribed to this Loyalty Program.
        /// </summary>
        /// <value>A list containing the IDs of all applications that are subscribed to this Loyalty Program.</value>
        [DataMember(Name="subscribedApplications", EmitDefaultValue=false)]
        public List<int> SubscribedApplications { get; set; }

        /// <summary>
        /// Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39;.
        /// </summary>
        /// <value>Indicates the default duration after which new loyalty points should expire. The format is a number, followed by one letter indicating the unit; like &#39;1h&#39; or &#39;40m&#39;.</value>
        [DataMember(Name="defaultValidity", EmitDefaultValue=false)]
        public string DefaultValidity { get; set; }

        /// <summary>
        /// Indicates the default duration for the pending time, after which points will be valid. The format is a number followed by a duration unit, like &#39;1h&#39; or &#39;40m&#39;.
        /// </summary>
        /// <value>Indicates the default duration for the pending time, after which points will be valid. The format is a number followed by a duration unit, like &#39;1h&#39; or &#39;40m&#39;.</value>
        [DataMember(Name="defaultPending", EmitDefaultValue=false)]
        public string DefaultPending { get; set; }

        /// <summary>
        /// Indicates if this program supports subledgers inside the program
        /// </summary>
        /// <value>Indicates if this program supports subledgers inside the program</value>
        [DataMember(Name="allowSubledger", EmitDefaultValue=false)]
        public bool AllowSubledger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLoyaltyProgram {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubscribedApplications: ").Append(SubscribedApplications).Append("\n");
            sb.Append("  DefaultValidity: ").Append(DefaultValidity).Append("\n");
            sb.Append("  DefaultPending: ").Append(DefaultPending).Append("\n");
            sb.Append("  AllowSubledger: ").Append(AllowSubledger).Append("\n");
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
            return this.Equals(input as UpdateLoyaltyProgram);
        }

        /// <summary>
        /// Returns true if UpdateLoyaltyProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateLoyaltyProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateLoyaltyProgram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SubscribedApplications == input.SubscribedApplications ||
                    this.SubscribedApplications != null &&
                    input.SubscribedApplications != null &&
                    this.SubscribedApplications.SequenceEqual(input.SubscribedApplications)
                ) && 
                (
                    this.DefaultValidity == input.DefaultValidity ||
                    (this.DefaultValidity != null &&
                    this.DefaultValidity.Equals(input.DefaultValidity))
                ) && 
                (
                    this.DefaultPending == input.DefaultPending ||
                    (this.DefaultPending != null &&
                    this.DefaultPending.Equals(input.DefaultPending))
                ) && 
                (
                    this.AllowSubledger == input.AllowSubledger ||
                    (this.AllowSubledger != null &&
                    this.AllowSubledger.Equals(input.AllowSubledger))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SubscribedApplications != null)
                    hashCode = hashCode * 59 + this.SubscribedApplications.GetHashCode();
                if (this.DefaultValidity != null)
                    hashCode = hashCode * 59 + this.DefaultValidity.GetHashCode();
                if (this.DefaultPending != null)
                    hashCode = hashCode * 59 + this.DefaultPending.GetHashCode();
                if (this.AllowSubledger != null)
                    hashCode = hashCode * 59 + this.AllowSubledger.GetHashCode();
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
