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
  public class Organizations {
    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="desc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "desc")]
    public string Desc { get; set; }

    /// <summary>
    /// A string with a length of at least 1.  Cannot begin or end with a space.
    /// </summary>
    /// <value>A string with a length of at least 1.  Cannot begin or end with a space.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The google apps domain to link this org to.
    /// </summary>
    /// <value>The google apps domain to link this org to.</value>
    [DataMember(Name="prefs/associatedDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/associatedDomain")]
    public string PrefsassociatedDomain { get; set; }

    /// <summary>
    /// One of: admin, none or org
    /// </summary>
    /// <value>One of: admin, none or org</value>
    [DataMember(Name="prefs/boardVisibilityRestrict/org", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/boardVisibilityRestrict/org")]
    public string PrefsboardVisibilityRestrictorg { get; set; }

    /// <summary>
    /// One of: admin, none or org
    /// </summary>
    /// <value>One of: admin, none or org</value>
    [DataMember(Name="prefs/boardVisibilityRestrict/private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/boardVisibilityRestrict/private")]
    public string PrefsboardVisibilityRestrictprivate { get; set; }

    /// <summary>
    /// One of: admin, none or org
    /// </summary>
    /// <value>One of: admin, none or org</value>
    [DataMember(Name="prefs/boardVisibilityRestrict/public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/boardVisibilityRestrict/public")]
    public string PrefsboardVisibilityRestrictpublic { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="prefs/externalMembersDisabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/externalMembersDisabled")]
    public string PrefsexternalMembersDisabled { get; set; }

    /// <summary>
    /// a number from 1 to 2
    /// </summary>
    /// <value>a number from 1 to 2</value>
    [DataMember(Name="prefs/googleAppsVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/googleAppsVersion")]
    public string PrefsgoogleAppsVersion { get; set; }

    /// <summary>
    /// An email address with optional expansion tokens
    /// </summary>
    /// <value>An email address with optional expansion tokens</value>
    [DataMember(Name="prefs/orgInviteRestrict", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/orgInviteRestrict")]
    public string PrefsorgInviteRestrict { get; set; }

    /// <summary>
    /// One of: private or public
    /// </summary>
    /// <value>One of: private or public</value>
    [DataMember(Name="prefs/permissionLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/permissionLevel")]
    public string PrefspermissionLevel { get; set; }

    /// <summary>
    /// A URL starting with http:// or https:// or null
    /// </summary>
    /// <value>A URL starting with http:// or https:// or null</value>
    [DataMember(Name="website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "website")]
    public string Website { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Organizations {\n");
      sb.Append("  Desc: ").Append(Desc).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PrefsassociatedDomain: ").Append(PrefsassociatedDomain).Append("\n");
      sb.Append("  PrefsboardVisibilityRestrictorg: ").Append(PrefsboardVisibilityRestrictorg).Append("\n");
      sb.Append("  PrefsboardVisibilityRestrictprivate: ").Append(PrefsboardVisibilityRestrictprivate).Append("\n");
      sb.Append("  PrefsboardVisibilityRestrictpublic: ").Append(PrefsboardVisibilityRestrictpublic).Append("\n");
      sb.Append("  PrefsexternalMembersDisabled: ").Append(PrefsexternalMembersDisabled).Append("\n");
      sb.Append("  PrefsgoogleAppsVersion: ").Append(PrefsgoogleAppsVersion).Append("\n");
      sb.Append("  PrefsorgInviteRestrict: ").Append(PrefsorgInviteRestrict).Append("\n");
      sb.Append("  PrefspermissionLevel: ").Append(PrefspermissionLevel).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
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
