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
  public class MembersCustomBoardBackgrounds {
    /// <summary>
    /// One of: dark, light or unknown
    /// </summary>
    /// <value>One of: dark, light or unknown</value>
    [DataMember(Name="brightness", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brightness")]
    public string Brightness { get; set; }

    /// <summary>
    /// A file
    /// </summary>
    /// <value>A file</value>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public string File { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="tile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tile")]
    public string Tile { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MembersCustomBoardBackgrounds {\n");
      sb.Append("  Brightness: ").Append(Brightness).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  Tile: ").Append(Tile).Append("\n");
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
