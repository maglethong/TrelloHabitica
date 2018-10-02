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
  public class MembersBoardStars {
    /// <summary>
    /// The id of the board to star
    /// </summary>
    /// <value>The id of the board to star</value>
    [DataMember(Name="idBoard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idBoard")]
    public string IdBoard { get; set; }

    /// <summary>
    /// A position. top , bottom , or a positive number.
    /// </summary>
    /// <value>A position. top , bottom , or a positive number.</value>
    [DataMember(Name="pos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pos")]
    public string Pos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MembersBoardStars {\n");
      sb.Append("  IdBoard: ").Append(IdBoard).Append("\n");
      sb.Append("  Pos: ").Append(Pos).Append("\n");
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
