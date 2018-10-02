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
  public class ListsCards {
    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="desc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desc")]
    public string Desc { get; set; }

    /// <summary>
    /// A date, or null
    /// </summary>
    /// <value>A date, or null</value>
    [DataMember(Name="due", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "due")]
    public string Due { get; set; }

    /// <summary>
    /// A comma-separated list of objectIds, 24-character hex strings
    /// </summary>
    /// <value>A comma-separated list of objectIds, 24-character hex strings</value>
    [DataMember(Name="idMembers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idMembers")]
    public string IdMembers { get; set; }

    /// <summary>
    /// all or a comma-separated list of: blue, green, orange, purple, red or yellow
    /// </summary>
    /// <value>all or a comma-separated list of: blue, green, orange, purple, red or yellow</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public string Labels { get; set; }

    /// <summary>
    /// a string with a length from 1 to 16384
    /// </summary>
    /// <value>a string with a length from 1 to 16384</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListsCards {\n");
      sb.Append("  Desc: ").Append(Desc).Append("\n");
      sb.Append("  Due: ").Append(Due).Append("\n");
      sb.Append("  IdMembers: ").Append(IdMembers).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
