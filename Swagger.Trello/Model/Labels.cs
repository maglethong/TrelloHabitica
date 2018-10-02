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
  public class Labels {
    /// <summary>
    /// A valid label color or null
    /// </summary>
    /// <value>A valid label color or null</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// An id
    /// </summary>
    /// <value>An id</value>
    [DataMember(Name="idBoard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idBoard")]
    public string IdBoard { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Labels {\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  IdBoard: ").Append(IdBoard).Append("\n");
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
