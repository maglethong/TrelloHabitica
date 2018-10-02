using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Swagger.Trello.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TokensWebhooks {
    /// <summary>
    /// A valid URL that is reachable with a HEAD request
    /// </summary>
    /// <value>A valid URL that is reachable with a HEAD request</value>
    [DataMember(Name="callbackURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "callbackURL")]
    public string CallbackURL { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// id of the model to be monitored
    /// </summary>
    /// <value>id of the model to be monitored</value>
    [DataMember(Name="idModel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idModel")]
    public string IdModel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokensWebhooks {\n");
      sb.Append("  CallbackURL: ").Append(CallbackURL).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IdModel: ").Append(IdModel).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
