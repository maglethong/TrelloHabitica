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
  public class CardsStickers {
    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// undefined
    /// </summary>
    /// <value>undefined</value>
    [DataMember(Name="left", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "left")]
    public string Left { get; set; }

    /// <summary>
    /// undefined
    /// </summary>
    /// <value>undefined</value>
    [DataMember(Name="rotate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rotate")]
    public string Rotate { get; set; }

    /// <summary>
    /// undefined
    /// </summary>
    /// <value>undefined</value>
    [DataMember(Name="top", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top")]
    public string Top { get; set; }

    /// <summary>
    /// Valid Z values for stickers, must be an integer
    /// </summary>
    /// <value>Valid Z values for stickers, must be an integer</value>
    [DataMember(Name="zIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zIndex")]
    public string ZIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardsStickers {\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Left: ").Append(Left).Append("\n");
      sb.Append("  Rotate: ").Append(Rotate).Append("\n");
      sb.Append("  Top: ").Append(Top).Append("\n");
      sb.Append("  ZIndex: ").Append(ZIndex).Append("\n");
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
