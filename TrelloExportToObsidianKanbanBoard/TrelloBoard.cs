using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TrelloExportToObsidianKanbanBoard
{
    public class TrelloBoard
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("descData")]
        public object DescData { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("dateClosed")]
        public object DateClosed { get; set; }

        [JsonProperty("idOrganization")]
        public string IdOrganization { get; set; }

        [JsonProperty("idEnterprise")]
        public object IdEnterprise { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("starred")]
        public bool Starred { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("prefs")]
        public Prefs Prefs { get; set; }

        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("labelNames")]
        public LabelNames LabelNames { get; set; }

        [JsonProperty("powerUps")]
        public List<object> PowerUps { get; set; }

        [JsonProperty("dateLastActivity")]
        public DateTime DateLastActivity { get; set; }

        [JsonProperty("dateLastView")]
        public DateTime DateLastView { get; set; }

        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        [JsonProperty("idTags")]
        public List<object> IdTags { get; set; }

        [JsonProperty("datePluginDisable")]
        public object DatePluginDisable { get; set; }

        [JsonProperty("creationMethod")]
        public string CreationMethod { get; set; }

        [JsonProperty("ixUpdate")]
        public string IxUpdate { get; set; }

        [JsonProperty("templateGallery")]
        public object TemplateGallery { get; set; }

        [JsonProperty("enterpriseOwned")]
        public bool EnterpriseOwned { get; set; }

        [JsonProperty("idBoardSource")]
        public object IdBoardSource { get; set; }

        [JsonProperty("premiumFeatures")]
        public List<string> PremiumFeatures { get; set; }

        [JsonProperty("idMemberCreator")]
        public string IdMemberCreator { get; set; }

        [JsonProperty("actions")]
        public List<Action> Actions { get; set; }

        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }

        [JsonProperty("labels")]
        public List<Label> Labels { get; set; }

        [JsonProperty("lists")]
        public List<List> Lists { get; set; }

        [JsonProperty("members")]
        public List<Member> Members { get; set; }

        [JsonProperty("checklists")]
        public List<Checklist> Checklists { get; set; }

        [JsonProperty("customFields")]
        public List<object> CustomFields { get; set; }

        [JsonProperty("memberships")]
        public List<Membership> Memberships { get; set; }

        [JsonProperty("pluginData")]
        public List<object> PluginData { get; set; }
    }

    public class Action
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idMemberCreator")]
        public string IdMemberCreator { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("appCreator")]
        public object AppCreator { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("limits")]
        public object Limits { get; set; }

        [JsonProperty("memberCreator")]
        public MemberCreator MemberCreator { get; set; }
    }

    public class Attachments
    {
        [JsonProperty("perBoard")]
        public PerBoard PerBoard { get; set; }

        [JsonProperty("perCard")]
        public PerCard PerCard { get; set; }
    }

    public class AttachmentsByType
    {
        [JsonProperty("trello")]
        public Trello Trello { get; set; }
    }

    public class BackgroundImageScaled
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Badges
    {
        [JsonProperty("attachmentsByType")]
        public AttachmentsByType AttachmentsByType { get; set; }

        [JsonProperty("location")]
        public bool Location { get; set; }

        [JsonProperty("votes")]
        public int Votes { get; set; }

        [JsonProperty("viewingMemberVoted")]
        public bool ViewingMemberVoted { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("fogbugz")]
        public string Fogbugz { get; set; }

        [JsonProperty("checkItems")]
        public int CheckItems { get; set; }

        [JsonProperty("checkItemsChecked")]
        public int CheckItemsChecked { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("attachments")]
        public int Attachments { get; set; }

        [JsonProperty("description")]
        public bool Description { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }

        [JsonProperty("dueComplete")]
        public bool DueComplete { get; set; }

        [JsonProperty("checkItemsEarliestDue")]
        public object CheckItemsEarliestDue { get; set; }

        [JsonProperty("start")]
        public object Start { get; set; }
    }

    public class Board
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }
    }

    public class Boards
    {
        [JsonProperty("totalMembersPerBoard")]
        public TotalMembersPerBoard TotalMembersPerBoard { get; set; }

        [JsonProperty("totalAccessRequestsPerBoard")]
        public TotalAccessRequestsPerBoard TotalAccessRequestsPerBoard { get; set; }
    }

    public class Card
    {
        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("idShort")]
        public int IdShort { get; set; }

        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("idList")]
        public string IdList { get; set; }
    }

    public class Card2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("badges")]
        public Badges Badges { get; set; }

        [JsonProperty("checkItemStates")]
        public object CheckItemStates { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("coordinates")]
        public object Coordinates { get; set; }

        [JsonProperty("creationMethod")]
        public string CreationMethod { get; set; }

        [JsonProperty("dueComplete")]
        public bool DueComplete { get; set; }

        [JsonProperty("dateLastActivity")]
        public DateTime DateLastActivity { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("descData")]
        public object DescData { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }

        [JsonProperty("dueReminder")]
        public object DueReminder { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("idChecklists")]
        public List<string> IdChecklists { get; set; }

        [JsonProperty("idLabels")]
        public List<object> IdLabels { get; set; }

        [JsonProperty("idList")]
        public string IdList { get; set; }

        [JsonProperty("idMembers")]
        public List<object> IdMembers { get; set; }

        [JsonProperty("idMembersVoted")]
        public List<object> IdMembersVoted { get; set; }

        [JsonProperty("idShort")]
        public int IdShort { get; set; }

        [JsonProperty("idAttachmentCover")]
        public object IdAttachmentCover { get; set; }

        [JsonProperty("labels")]
        public List<object> Labels { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("locationName")]
        public object LocationName { get; set; }

        [JsonProperty("manualCoverAttachment")]
        public bool ManualCoverAttachment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("shortLink")]
        public string ShortLink { get; set; }

        [JsonProperty("shortUrl")]
        public string ShortUrl { get; set; }

        [JsonProperty("staticMapUrl")]
        public object StaticMapUrl { get; set; }

        [JsonProperty("start")]
        public object Start { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("cover")]
        public Cover Cover { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("cardRole")]
        public object CardRole { get; set; }

        [JsonProperty("attachments")]
        public List<object> Attachments { get; set; }

        [JsonProperty("pluginData")]
        public List<object> PluginData { get; set; }

        [JsonProperty("customFieldItems")]
        public List<object> CustomFieldItems { get; set; }

        [JsonProperty("openPerBoard")]
        public OpenPerBoard OpenPerBoard { get; set; }

        [JsonProperty("openPerList")]
        public OpenPerList OpenPerList { get; set; }

        [JsonProperty("totalPerBoard")]
        public TotalPerBoard TotalPerBoard { get; set; }

        [JsonProperty("totalPerList")]
        public TotalPerList TotalPerList { get; set; }
    }

    public class CheckItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameData")]
        public object NameData { get; set; }

        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("due")]
        public object Due { get; set; }

        [JsonProperty("dueReminder")]
        public object DueReminder { get; set; }

        [JsonProperty("idMember")]
        public object IdMember { get; set; }

        [JsonProperty("idChecklist")]
        public string IdChecklist { get; set; }

        [JsonProperty("perChecklist")]
        public PerChecklist PerChecklist { get; set; }
    }

    public class Checklist
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("idCard")]
        public string IdCard { get; set; }

        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("checkItems")]
        public List<CheckItem> CheckItems { get; set; }

        [JsonProperty("creationMethod")]
        public string CreationMethod { get; set; }

        [JsonProperty("perBoard")]
        public PerBoard PerBoard { get; set; }

        [JsonProperty("perCard")]
        public PerCard PerCard { get; set; }
    }

    public class Cover
    {
        [JsonProperty("idAttachment")]
        public object IdAttachment { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("idUploadedBackground")]
        public object IdUploadedBackground { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("brightness")]
        public string Brightness { get; set; }

        [JsonProperty("idPlugin")]
        public object IdPlugin { get; set; }
    }

    public class CustomFieldOptions
    {
        [JsonProperty("perField")]
        public PerField PerField { get; set; }
    }

    public class CustomFields
    {
        [JsonProperty("perBoard")]
        public PerBoard PerBoard { get; set; }
    }

    public class Data
    {
        [JsonProperty("old")]
        public Old Old { get; set; }

        [JsonProperty("card")]
        public Card Card { get; set; }

        [JsonProperty("board")]
        public Board Board { get; set; }

        [JsonProperty("list")]
        public List List { get; set; }

        [JsonProperty("listBefore")]
        public ListBefore ListBefore { get; set; }

        [JsonProperty("listAfter")]
        public ListAfter ListAfter { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }
    }

    public class Label
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("perBoard")]
        public PerBoard PerBoard { get; set; }
    }

    public class LabelNames
    {
        [JsonProperty("green")]
        public string Green { get; set; }

        [JsonProperty("yellow")]
        public string Yellow { get; set; }

        [JsonProperty("orange")]
        public string Orange { get; set; }

        [JsonProperty("red")]
        public string Red { get; set; }

        [JsonProperty("purple")]
        public string Purple { get; set; }

        [JsonProperty("blue")]
        public string Blue { get; set; }

        [JsonProperty("sky")]
        public string Sky { get; set; }

        [JsonProperty("lime")]
        public string Lime { get; set; }

        [JsonProperty("pink")]
        public string Pink { get; set; }

        [JsonProperty("black")]
        public string Black { get; set; }

        [JsonProperty("green_dark")]
        public string GreenDark { get; set; }

        [JsonProperty("yellow_dark")]
        public string YellowDark { get; set; }

        [JsonProperty("orange_dark")]
        public string OrangeDark { get; set; }

        [JsonProperty("red_dark")]
        public string RedDark { get; set; }

        [JsonProperty("purple_dark")]
        public string PurpleDark { get; set; }

        [JsonProperty("blue_dark")]
        public string BlueDark { get; set; }

        [JsonProperty("sky_dark")]
        public string SkyDark { get; set; }

        [JsonProperty("lime_dark")]
        public string LimeDark { get; set; }

        [JsonProperty("pink_dark")]
        public string PinkDark { get; set; }

        [JsonProperty("black_dark")]
        public string BlackDark { get; set; }

        [JsonProperty("green_light")]
        public string GreenLight { get; set; }

        [JsonProperty("yellow_light")]
        public string YellowLight { get; set; }

        [JsonProperty("orange_light")]
        public string OrangeLight { get; set; }

        [JsonProperty("red_light")]
        public string RedLight { get; set; }

        [JsonProperty("purple_light")]
        public string PurpleLight { get; set; }

        [JsonProperty("blue_light")]
        public string BlueLight { get; set; }

        [JsonProperty("sky_light")]
        public string SkyLight { get; set; }

        [JsonProperty("lime_light")]
        public string LimeLight { get; set; }

        [JsonProperty("pink_light")]
        public string PinkLight { get; set; }

        [JsonProperty("black_light")]
        public string BlackLight { get; set; }
    }

    public class Limits
    {
        [JsonProperty("attachments")]
        public Attachments Attachments { get; set; }

        [JsonProperty("boards")]
        public Boards Boards { get; set; }

        [JsonProperty("cards")]
        public Card Cards { get; set; }

        [JsonProperty("checklists")]
        public Checklist Checklists { get; set; }

        [JsonProperty("checkItems")]
        public CheckItem CheckItems { get; set; }

        [JsonProperty("customFields")]
        public CustomFields CustomFields { get; set; }

        [JsonProperty("customFieldOptions")]
        public CustomFieldOptions CustomFieldOptions { get; set; }

        [JsonProperty("labels")]
        public Label Labels { get; set; }

        [JsonProperty("lists")]
        public List Lists { get; set; }

        [JsonProperty("stickers")]
        public Stickers Stickers { get; set; }

        [JsonProperty("reactions")]
        public Reactions Reactions { get; set; }
    }

    public class List
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class List2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("idBoard")]
        public string IdBoard { get; set; }

        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("softLimit")]
        public object SoftLimit { get; set; }

        [JsonProperty("status")]
        public object Status { get; set; }

        [JsonProperty("creationMethod")]
        public string CreationMethod { get; set; }

        [JsonProperty("idOrganization")]
        public string IdOrganization { get; set; }

        [JsonProperty("limits")]
        public Limits Limits { get; set; }

        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        [JsonProperty("openPerBoard")]
        public OpenPerBoard OpenPerBoard { get; set; }

        [JsonProperty("totalPerBoard")]
        public TotalPerBoard TotalPerBoard { get; set; }
    }

    public class ListAfter
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListBefore
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Member
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("aaId")]
        public string AaId { get; set; }

        [JsonProperty("activityBlocked")]
        public bool ActivityBlocked { get; set; }

        [JsonProperty("avatarHash")]
        public string AvatarHash { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("bioData")]
        public object BioData { get; set; }

        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("idEnterprise")]
        public object IdEnterprise { get; set; }

        [JsonProperty("idEnterprisesDeactivated")]
        public List<object> IdEnterprisesDeactivated { get; set; }

        [JsonProperty("idMemberReferrer")]
        public object IdMemberReferrer { get; set; }

        [JsonProperty("idPremOrgsAdmin")]
        public List<object> IdPremOrgsAdmin { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("memberType")]
        public string MemberType { get; set; }

        [JsonProperty("nonPublic")]
        public NonPublic NonPublic { get; set; }

        [JsonProperty("nonPublicAvailable")]
        public bool NonPublicAvailable { get; set; }

        [JsonProperty("products")]
        public List<object> Products { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MemberCreator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("activityBlocked")]
        public bool ActivityBlocked { get; set; }

        [JsonProperty("avatarHash")]
        public string AvatarHash { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("idMemberReferrer")]
        public object IdMemberReferrer { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("nonPublic")]
        public NonPublic NonPublic { get; set; }

        [JsonProperty("nonPublicAvailable")]
        public bool NonPublicAvailable { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class Membership
    {
        [JsonProperty("idMember")]
        public string IdMember { get; set; }

        [JsonProperty("memberType")]
        public string MemberType { get; set; }

        [JsonProperty("unconfirmed")]
        public bool Unconfirmed { get; set; }

        [JsonProperty("deactivated")]
        public bool Deactivated { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class NonPublic
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("avatarHash")]
        public object AvatarHash { get; set; }
    }

    public class Old
    {
        [JsonProperty("pos")]
        public double Pos { get; set; }

        [JsonProperty("idList")]
        public string IdList { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OpenPerBoard
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class OpenPerList
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class Organization
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PerAction
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class PerBoard
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class PerCard
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class PerChecklist
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class PerField
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class Prefs
    {
        [JsonProperty("permissionLevel")]
        public string PermissionLevel { get; set; }

        [JsonProperty("hideVotes")]
        public bool HideVotes { get; set; }

        [JsonProperty("voting")]
        public string Voting { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("invitations")]
        public string Invitations { get; set; }

        [JsonProperty("selfJoin")]
        public bool SelfJoin { get; set; }

        [JsonProperty("cardCovers")]
        public bool CardCovers { get; set; }

        [JsonProperty("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonProperty("cardAging")]
        public string CardAging { get; set; }

        [JsonProperty("calendarFeedEnabled")]
        public bool CalendarFeedEnabled { get; set; }

        [JsonProperty("hiddenPluginBoardButtons")]
        public List<object> HiddenPluginBoardButtons { get; set; }

        [JsonProperty("switcherViews")]
        public List<SwitcherView> SwitcherViews { get; set; }

        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("backgroundColor")]
        public object BackgroundColor { get; set; }

        [JsonProperty("backgroundImage")]
        public string BackgroundImage { get; set; }

        [JsonProperty("backgroundImageScaled")]
        public List<BackgroundImageScaled> BackgroundImageScaled { get; set; }

        [JsonProperty("backgroundTile")]
        public bool BackgroundTile { get; set; }

        [JsonProperty("backgroundBrightness")]
        public string BackgroundBrightness { get; set; }

        [JsonProperty("backgroundBottomColor")]
        public string BackgroundBottomColor { get; set; }

        [JsonProperty("backgroundTopColor")]
        public string BackgroundTopColor { get; set; }

        [JsonProperty("canBePublic")]
        public bool CanBePublic { get; set; }

        [JsonProperty("canBeEnterprise")]
        public bool CanBeEnterprise { get; set; }

        [JsonProperty("canBeOrg")]
        public bool CanBeOrg { get; set; }

        [JsonProperty("canBePrivate")]
        public bool CanBePrivate { get; set; }

        [JsonProperty("canInvite")]
        public bool CanInvite { get; set; }
    }

    public class Reactions
    {
        [JsonProperty("perAction")]
        public PerAction PerAction { get; set; }

        [JsonProperty("uniquePerAction")]
        public UniquePerAction UniquePerAction { get; set; }
    }

    public class Stickers
    {
        [JsonProperty("perCard")]
        public PerCard PerCard { get; set; }
    }

    public class SwitcherView
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("viewType")]
        public string ViewType { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class TotalAccessRequestsPerBoard
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class TotalMembersPerBoard
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class TotalPerBoard
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class TotalPerList
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }

    public class Trello
    {
        [JsonProperty("board")]
        public int Board { get; set; }

        [JsonProperty("card")]
        public int Card { get; set; }
    }

    public class UniquePerAction
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("disableAt")]
        public int DisableAt { get; set; }

        [JsonProperty("warnAt")]
        public int WarnAt { get; set; }
    }


}
