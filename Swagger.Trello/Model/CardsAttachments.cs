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
  public class CardsAttachments {
    /// <summary>
    /// A file
    /// </summary>
    /// <value>A file</value>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public string File { get; set; }

    /// <summary>
    /// a string with a length from 0 to 256
    /// </summary>
    /// <value>a string with a length from 0 to 256</value>
    [DataMember(Name="mimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mimeType")]
    public string MimeType { get; set; }

    /// <summary>
    /// a string with a length from 0 to 256
    /// </summary>
    /// <value>a string with a length from 0 to 256</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A URL starting with http:// or https:// or null
    /// </summary>
    /// <value>A URL starting with http:// or https:// or null</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CardsAttachments {\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  MimeType: ").Append(MimeType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
