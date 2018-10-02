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
  public class Checklists {
    /// <summary>
    /// id of the board that the checklist should be added to
    /// </summary>
    /// <value>id of the board that the checklist should be added to</value>
    [DataMember(Name="idBoard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idBoard")]
    public string IdBoard { get; set; }

    /// <summary>
    /// id of the card that the checklist should be added to
    /// </summary>
    /// <value>id of the card that the checklist should be added to</value>
    [DataMember(Name="idCard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idCard")]
    public string IdCard { get; set; }

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
      sb.Append("class Checklists {\n");
      sb.Append("  IdBoard: ").Append(IdBoard).Append("\n");
      sb.Append("  IdCard: ").Append(IdCard).Append("\n");
      sb.Append("  IdChecklistSource: ").Append(IdChecklistSource).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
