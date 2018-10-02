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
  public class ListsMoveAllCards {
    /// <summary>
    /// id of the board that the cards should be moved to
    /// </summary>
    /// <value>id of the board that the cards should be moved to</value>
    [DataMember(Name="idBoard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idBoard")]
    public string IdBoard { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListsMoveAllCards {\n");
      sb.Append("  IdBoard: ").Append(IdBoard).Append("\n");
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
