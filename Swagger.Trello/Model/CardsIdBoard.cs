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
  public class CardsIdBoard {
    /// <summary>
    /// id of the list that the card should be moved to on the new board
    /// </summary>
    /// <value>id of the list that the card should be moved to on the new board</value>
    [DataMember(Name="idList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idList")]
    public string IdList { get; set; }

    /// <summary>
    /// id of the board the card should be moved to
    /// </summary>
    /// <value>id of the board the card should be moved to</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardsIdBoard {\n");
      sb.Append("  IdList: ").Append(IdList).Append("\n");
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
