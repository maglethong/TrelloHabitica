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
  public class Cards {
    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="closed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closed")]
    public string Closed { get; set; }

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
    /// A file
    /// </summary>
    /// <value>A file</value>
    [DataMember(Name="fileSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileSource")]
    public string FileSource { get; set; }

    /// <summary>
    /// Id of the image attachment of this card to use as its cover, or null for no cover
    /// </summary>
    /// <value>Id of the image attachment of this card to use as its cover, or null for no cover</value>
    [DataMember(Name="idAttachmentCover", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idAttachmentCover")]
    public string IdAttachmentCover { get; set; }

    /// <summary>
    /// id of the board the card should be moved to
    /// </summary>
    /// <value>id of the board the card should be moved to</value>
    [DataMember(Name="idBoard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idBoard")]
    public string IdBoard { get; set; }

    /// <summary>
    /// The id of the card to copy into a new card.
    /// </summary>
    /// <value>The id of the card to copy into a new card.</value>
    [DataMember(Name="idCardSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idCardSource")]
    public string IdCardSource { get; set; }

    /// <summary>
    /// A comma-separated list of objectIds, 24-character hex strings
    /// </summary>
    /// <value>A comma-separated list of objectIds, 24-character hex strings</value>
    [DataMember(Name="idLabels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idLabels")]
    public string IdLabels { get; set; }

    /// <summary>
    /// id of the list that the card should be added to
    /// </summary>
    /// <value>id of the list that the card should be added to</value>
    [DataMember(Name="idList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idList")]
    public string IdList { get; set; }

    /// <summary>
    /// A comma-separated list of objectIds, 24-character hex strings
    /// </summary>
    /// <value>A comma-separated list of objectIds, 24-character hex strings</value>
    [DataMember(Name="idMembers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idMembers")]
    public string IdMembers { get; set; }

    /// <summary>
    /// Properties of the card to copy over from the source.
    /// </summary>
    /// <value>Properties of the card to copy over from the source.</value>
    [DataMember(Name="keepFromSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keepFromSource")]
    public string KeepFromSource { get; set; }

    /// <summary>
    /// all or a comma-separated list of: blue, green, orange, purple, red or yellow
    /// </summary>
    /// <value>all or a comma-separated list of: blue, green, orange, purple, red or yellow</value>
    [DataMember(Name="labels", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labels")]
    public string Labels { get; set; }

    /// <summary>
    /// The name of the new card.  It isn&#39;t required if the name is being copied from provided by a URL, file or card that is being copied.
    /// </summary>
    /// <value>The name of the new card.  It isn&#39;t required if the name is being copied from provided by a URL, file or card that is being copied.</value>
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
    /// A URL starting with http:// or https:// or null
    /// </summary>
    /// <value>A URL starting with http:// or https:// or null</value>
    [DataMember(Name="urlSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "urlSource")]
    public string UrlSource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Cards {\n");
      sb.Append("  Closed: ").Append(Closed).Append("\n");
      sb.Append("  Desc: ").Append(Desc).Append("\n");
      sb.Append("  Due: ").Append(Due).Append("\n");
      sb.Append("  FileSource: ").Append(FileSource).Append("\n");
      sb.Append("  IdAttachmentCover: ").Append(IdAttachmentCover).Append("\n");
      sb.Append("  IdBoard: ").Append(IdBoard).Append("\n");
      sb.Append("  IdCardSource: ").Append(IdCardSource).Append("\n");
      sb.Append("  IdLabels: ").Append(IdLabels).Append("\n");
      sb.Append("  IdList: ").Append(IdList).Append("\n");
      sb.Append("  IdMembers: ").Append(IdMembers).Append("\n");
      sb.Append("  KeepFromSource: ").Append(KeepFromSource).Append("\n");
      sb.Append("  Labels: ").Append(Labels).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Pos: ").Append(Pos).Append("\n");
      sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
      sb.Append("  UrlSource: ").Append(UrlSource).Append("\n");
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
