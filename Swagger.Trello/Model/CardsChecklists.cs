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
  public class CardsChecklists {
    /// <summary>
    /// The id of the source checklist to copy into a new checklist.
    /// </summary>
    /// <value>The id of the source checklist to copy into a new checklist.</value>
    [DataMember(Name="idChecklistSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idChecklistSource")]
    public string IdChecklistSource { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The id of the checklist to add to the card, or null to create a new one.
    /// </summary>
    /// <value>The id of the checklist to add to the card, or null to create a new one.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardsChecklists {\n");
      sb.Append("  IdChecklistSource: ").Append(IdChecklistSource).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
