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
  public class Lists {
    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="closed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed")]
    public string Closed { get; set; }

    /// <summary>
    /// id of the board that the list should be added to
    /// </summary>
    /// <value>id of the board that the list should be added to</value>
    [DataMember(Name="idBoard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idBoard")]
    public string IdBoard { get; set; }

    /// <summary>
    /// The id of the list to copy into a new list.
    /// </summary>
    /// <value>The id of the list to copy into a new list.</value>
    [DataMember(Name="idListSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idListSource")]
    public string IdListSource { get; set; }

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
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="subscribed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscribed")]
    public string Subscribed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Lists {\n");
      sb.Append("  Closed: ").Append(Closed).Append("\n");
      sb.Append("  IdBoard: ").Append(IdBoard).Append("\n");
      sb.Append("  IdListSource: ").Append(IdListSource).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Pos: ").Append(Pos).Append("\n");
      sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
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
