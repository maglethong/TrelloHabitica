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
  public class CardsChecklistIdChecklistCurrentCheckItem {
    /// <summary>
    /// An id, or null
    /// </summary>
    /// <value>An id, or null</value>
    [DataMember(Name="idChecklist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idChecklist")]
    public string IdChecklist { get; set; }

    /// <summary>
    /// a string with a length from 1 to 16384
    /// </summary>
    /// <value>a string with a length from 1 to 16384</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A position. top , bottom , or a positive number.
    /// </summary>
    /// <value>A position. top , bottom , or a positive number.</value>
    [DataMember(Name="pos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pos")]
    public string Pos { get; set; }

    /// <summary>
    /// One of: complete, false, incomplete or true
    /// </summary>
    /// <value>One of: complete, false, incomplete or true</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardsChecklistIdChecklistCurrentCheckItem {\n");
      sb.Append("  IdChecklist: ").Append(IdChecklist).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Pos: ").Append(Pos).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
