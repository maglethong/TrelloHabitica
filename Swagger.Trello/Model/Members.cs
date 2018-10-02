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
  public class Members {
    /// <summary>
    /// One of: gravatar, none or upload
    /// </summary>
    /// <value>One of: gravatar, none or upload</value>
    [DataMember(Name="avatarSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "avatarSource")]
    public string AvatarSource { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="bio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bio")]
    public string Bio { get; set; }

    /// <summary>
    /// A string with a length of at least 1.  Cannot begin or end with a space.
    /// </summary>
    /// <value>A string with a length of at least 1.  Cannot begin or end with a space.</value>
    [DataMember(Name="fullName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullName")]
    public string FullName { get; set; }

    /// <summary>
    /// A string with a length from 1 to 4.  Cannot begin or end with a space
    /// </summary>
    /// <value>A string with a length from 1 to 4.  Cannot begin or end with a space</value>
    [DataMember(Name="initials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initials")]
    public string Initials { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="prefs/colorBlind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/colorBlind")]
    public string PrefscolorBlind { get; set; }

    /// <summary>
    /// a string with a length from 0 to 255
    /// </summary>
    /// <value>a string with a length from 0 to 255</value>
    [DataMember(Name="prefs/locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/locale")]
    public string Prefslocale { get; set; }

    /// <summary>
    /// -1 (disabled), 1 or 60
    /// </summary>
    /// <value>-1 (disabled), 1 or 60</value>
    [DataMember(Name="prefs/minutesBetweenSummaries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/minutesBetweenSummaries")]
    public string PrefsminutesBetweenSummaries { get; set; }

    /// <summary>
    /// A string with a length of at least 3.  Only lowercase letters, underscores, and numbers are allowed.  Must be unique.
    /// </summary>
    /// <value>A string with a length of at least 3.  Only lowercase letters, underscores, and numbers are allowed.  Must be unique.</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Members {\n");
      sb.Append("  AvatarSource: ").Append(AvatarSource).Append("\n");
      sb.Append("  Bio: ").Append(Bio).Append("\n");
      sb.Append("  FullName: ").Append(FullName).Append("\n");
      sb.Append("  Initials: ").Append(Initials).Append("\n");
      sb.Append("  PrefscolorBlind: ").Append(PrefscolorBlind).Append("\n");
      sb.Append("  Prefslocale: ").Append(Prefslocale).Append("\n");
      sb.Append("  PrefsminutesBetweenSummaries: ").Append(PrefsminutesBetweenSummaries).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
