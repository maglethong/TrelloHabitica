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
  public class Boards {
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
    /// The id of the board to copy into the new board
    /// </summary>
    /// <value>The id of the board to copy into the new board</value>
    [DataMember(Name="idBoardSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idBoardSource")]
    public string IdBoardSource { get; set; }

    /// <summary>
    /// The id or name of the organization to add the board to.
    /// </summary>
    /// <value>The id or name of the organization to add the board to.</value>
    [DataMember(Name="idOrganization", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idOrganization")]
    public string IdOrganization { get; set; }

    /// <summary>
    /// Components of the source board to copy.
    /// </summary>
    /// <value>Components of the source board to copy.</value>
    [DataMember(Name="keepFromSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keepFromSource")]
    public string KeepFromSource { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="labelNames/blue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelNames/blue")]
    public string LabelNamesblue { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="labelNames/green", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelNames/green")]
    public string LabelNamesgreen { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="labelNames/orange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelNames/orange")]
    public string LabelNamesorange { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="labelNames/purple", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelNames/purple")]
    public string LabelNamespurple { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="labelNames/red", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelNames/red")]
    public string LabelNamesred { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="labelNames/yellow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "labelNames/yellow")]
    public string LabelNamesyellow { get; set; }

    /// <summary>
    /// a string with a length from 1 to 16384
    /// </summary>
    /// <value>a string with a length from 1 to 16384</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// all or a comma-separated list of: calendar, cardAging, recap or voting
    /// </summary>
    /// <value>all or a comma-separated list of: calendar, cardAging, recap or voting</value>
    [DataMember(Name="powerUps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "powerUps")]
    public string PowerUps { get; set; }

    /// <summary>
    /// A standard background name, or the id of a custom background
    /// </summary>
    /// <value>A standard background name, or the id of a custom background</value>
    [DataMember(Name="prefs/background", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/background")]
    public string Prefsbackground { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="prefs/calendarFeedEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/calendarFeedEnabled")]
    public string PrefscalendarFeedEnabled { get; set; }

    /// <summary>
    /// One of: pirate or regular
    /// </summary>
    /// <value>One of: pirate or regular</value>
    [DataMember(Name="prefs/cardAging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/cardAging")]
    public string PrefscardAging { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="prefs/cardCovers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/cardCovers")]
    public string PrefscardCovers { get; set; }

    /// <summary>
    /// One of: disabled, members, observers, org or public
    /// </summary>
    /// <value>One of: disabled, members, observers, org or public</value>
    [DataMember(Name="prefs/comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/comments")]
    public string Prefscomments { get; set; }

    /// <summary>
    /// One of: admins or members
    /// </summary>
    /// <value>One of: admins or members</value>
    [DataMember(Name="prefs/invitations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/invitations")]
    public string Prefsinvitations { get; set; }

    /// <summary>
    /// One of: org, private or public
    /// </summary>
    /// <value>One of: org, private or public</value>
    [DataMember(Name="prefs/permissionLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/permissionLevel")]
    public string PrefspermissionLevel { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="prefs/selfJoin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/selfJoin")]
    public string PrefsselfJoin { get; set; }

    /// <summary>
    /// One of: disabled, members, observers, org or public
    /// </summary>
    /// <value>One of: disabled, members, observers, org or public</value>
    [DataMember(Name="prefs/voting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs/voting")]
    public string Prefsvoting { get; set; }

    /// <summary>
    /// a string with a length from 0 to 16384
    /// </summary>
    /// <value>a string with a length from 0 to 16384</value>
    [DataMember(Name="prefs_background", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_background")]
    public string PrefsBackground { get; set; }

    /// <summary>
    /// One of: pirate or regular
    /// </summary>
    /// <value>One of: pirate or regular</value>
    [DataMember(Name="prefs_cardAging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_cardAging")]
    public string PrefsCardAging { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="prefs_cardCovers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_cardCovers")]
    public string PrefsCardCovers { get; set; }

    /// <summary>
    /// One of: disabled, members, observers, org or public
    /// </summary>
    /// <value>One of: disabled, members, observers, org or public</value>
    [DataMember(Name="prefs_comments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_comments")]
    public string PrefsComments { get; set; }

    /// <summary>
    /// One of: admins or members
    /// </summary>
    /// <value>One of: admins or members</value>
    [DataMember(Name="prefs_invitations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_invitations")]
    public string PrefsInvitations { get; set; }

    /// <summary>
    /// One of: org, private or public
    /// </summary>
    /// <value>One of: org, private or public</value>
    [DataMember(Name="prefs_permissionLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_permissionLevel")]
    public string PrefsPermissionLevel { get; set; }

    /// <summary>
    ///  true or false
    /// </summary>
    /// <value> true or false</value>
    [DataMember(Name="prefs_selfJoin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_selfJoin")]
    public string PrefsSelfJoin { get; set; }

    /// <summary>
    /// One of: disabled, members, observers, org or public
    /// </summary>
    /// <value>One of: disabled, members, observers, org or public</value>
    [DataMember(Name="prefs_voting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prefs_voting")]
    public string PrefsVoting { get; set; }

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
      sb.Append("class Boards {\n");
      sb.Append("  Closed: ").Append(Closed).Append("\n");
      sb.Append("  Desc: ").Append(Desc).Append("\n");
      sb.Append("  IdBoardSource: ").Append(IdBoardSource).Append("\n");
      sb.Append("  IdOrganization: ").Append(IdOrganization).Append("\n");
      sb.Append("  KeepFromSource: ").Append(KeepFromSource).Append("\n");
      sb.Append("  LabelNamesblue: ").Append(LabelNamesblue).Append("\n");
      sb.Append("  LabelNamesgreen: ").Append(LabelNamesgreen).Append("\n");
      sb.Append("  LabelNamesorange: ").Append(LabelNamesorange).Append("\n");
      sb.Append("  LabelNamespurple: ").Append(LabelNamespurple).Append("\n");
      sb.Append("  LabelNamesred: ").Append(LabelNamesred).Append("\n");
      sb.Append("  LabelNamesyellow: ").Append(LabelNamesyellow).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PowerUps: ").Append(PowerUps).Append("\n");
      sb.Append("  Prefsbackground: ").Append(Prefsbackground).Append("\n");
      sb.Append("  PrefscalendarFeedEnabled: ").Append(PrefscalendarFeedEnabled).Append("\n");
      sb.Append("  PrefscardAging: ").Append(PrefscardAging).Append("\n");
      sb.Append("  PrefscardCovers: ").Append(PrefscardCovers).Append("\n");
      sb.Append("  Prefscomments: ").Append(Prefscomments).Append("\n");
      sb.Append("  Prefsinvitations: ").Append(Prefsinvitations).Append("\n");
      sb.Append("  PrefspermissionLevel: ").Append(PrefspermissionLevel).Append("\n");
      sb.Append("  PrefsselfJoin: ").Append(PrefsselfJoin).Append("\n");
      sb.Append("  Prefsvoting: ").Append(Prefsvoting).Append("\n");
      sb.Append("  PrefsBackground: ").Append(PrefsBackground).Append("\n");
      sb.Append("  PrefsCardAging: ").Append(PrefsCardAging).Append("\n");
      sb.Append("  PrefsCardCovers: ").Append(PrefsCardCovers).Append("\n");
      sb.Append("  PrefsComments: ").Append(PrefsComments).Append("\n");
      sb.Append("  PrefsInvitations: ").Append(PrefsInvitations).Append("\n");
      sb.Append("  PrefsPermissionLevel: ").Append(PrefsPermissionLevel).Append("\n");
      sb.Append("  PrefsSelfJoin: ").Append(PrefsSelfJoin).Append("\n");
      sb.Append("  PrefsVoting: ").Append(PrefsVoting).Append("\n");
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
