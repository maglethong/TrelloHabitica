using System;
using System.Collections.Generic;
using RestSharp;
using Swagger.Client;
using Swagger.Trello.Model;

namespace Swagger.Trello.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationApi
    {
        /// <summary>
        /// addOrganizations() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Organizations\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddOrganizations (Organizations body, string key, string token);
        /// <summary>
        /// addOrganizationsLogoByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Organizations Logo\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddOrganizationsLogoByIdOrg (string idOrg, OrganizationsLogo body, string key, string token);
        /// <summary>
        /// deleteOrganizationsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteOrganizationsByIdOrg (string idOrg, string key, string token);
        /// <summary>
        /// deleteOrganizationsLogoByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteOrganizationsLogoByIdOrg (string idOrg, string key, string token);
        /// <summary>
        /// deleteOrganizationsMembersAllByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="idMember">idMember</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteOrganizationsMembersAllByIdOrgByIdMember (string idOrg, string idMember, string key, string token);
        /// <summary>
        /// deleteOrganizationsMembersByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="idMember">idMember</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteOrganizationsMembersByIdOrgByIdMember (string idOrg, string idMember, string key, string token);
        /// <summary>
        /// deleteOrganizationsPrefsAssociatedDomainByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteOrganizationsPrefsAssociatedDomainByIdOrg (string idOrg, string key, string token);
        /// <summary>
        /// deleteOrganizationsPrefsOrgInviteRestrictByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="value">An email address with optional expansion tokens</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg (string idOrg, string value, string key, string token);
        /// <summary>
        /// getOrganizationsActionsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="entities"> true or false</param>
        /// <param name="display"> true or false</param>
        /// <param name="filter">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="limit">a number from 0 to 1000</param>
        /// <param name="format">One of: count, list or minimal</param>
        /// <param name="since">A date, null or lastView</param>
        /// <param name="before">A date, or null</param>
        /// <param name="page">Page * limit must be less than 1000</param>
        /// <param name="idModels">Only return actions related to these model ids</param>
        /// <param name="member"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="memberCreator"> true or false</param>
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetOrganizationsActionsByIdOrg (string idOrg, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields);
        /// <summary>
        /// getOrganizationsBoardsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">all or a comma-separated list of: closed, members, open, organization, pinned, public, starred or unpinned</param>
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="actionsEntities"> true or false</param>
        /// <param name="actionsLimit">a number from 0 to 1000</param>
        /// <param name="actionsFormat">One of: count, list or minimal</param>
        /// <param name="actionsSince">A date, null or lastView</param>
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="memberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param>
        /// <param name="organization"> true or false</param>
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="lists">One of: all, closed, none or open</param>
        /// <returns></returns>
        void GetOrganizationsBoardsByIdOrg (string idOrg, string key, string token, string filter, string fields, string actions, string actionsEntities, string actionsLimit, string actionsFormat, string actionsSince, string actionFields, string memberships, string organization, string organizationFields, string lists);
        /// <summary>
        /// getOrganizationsBoardsByIdOrgByFilter() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetOrganizationsBoardsByIdOrgByFilter (string idOrg, string filter, string key, string token);
        /// <summary>
        /// getOrganizationsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="actionsEntities"> true or false</param>
        /// <param name="actionsDisplay"> true or false</param>
        /// <param name="actionsLimit">a number from 0 to 1000</param>
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="memberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param>
        /// <param name="membershipsMember"> true or false</param>
        /// <param name="membershipsMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="members">One of: admins, all, none, normal or owners</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="memberActivity">true or false ; works for premium organizations only.</param>
        /// <param name="membersInvited">One of: admins, all, none, normal or owners</param>
        /// <param name="membersInvitedFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="boards">all or a comma-separated list of: closed, members, open, organization, pinned, public, starred or unpinned</param>
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="boardActions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="boardActionsEntities"> true or false</param>
        /// <param name="boardActionsDisplay"> true or false</param>
        /// <param name="boardActionsFormat">One of: count, list or minimal</param>
        /// <param name="boardActionsSince">A date, null or lastView</param>
        /// <param name="boardActionsLimit">a number from 0 to 1000</param>
        /// <param name="boardActionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="boardLists">One of: all, closed, none or open</param>
        /// <param name="paidAccount"> true or false</param>
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <returns></returns>
        void GetOrganizationsByIdOrg (string idOrg, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string memberships, string membershipsMember, string membershipsMemberFields, string members, string memberFields, string memberActivity, string membersInvited, string membersInvitedFields, string boards, string boardFields, string boardActions, string boardActionsEntities, string boardActionsDisplay, string boardActionsFormat, string boardActionsSince, string boardActionsLimit, string boardActionFields, string boardLists, string paidAccount, string fields);
        /// <summary>
        /// getOrganizationsByIdOrgByField() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetOrganizationsByIdOrgByField (string idOrg, string field, string key, string token);
        /// <summary>
        /// getOrganizationsDeltasByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="tags">A valid tag for subscribing</param>
        /// <param name="ixLastUpdate">a number from -1 to Infinity</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetOrganizationsDeltasByIdOrg (string idOrg, string tags, string ixLastUpdate, string key, string token);
        /// <summary>
        /// getOrganizationsMembersByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: admins, all, none, normal or owners</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="activity">true or false ; works for premium organizations only.</param>
        /// <returns></returns>
        void GetOrganizationsMembersByIdOrg (string idOrg, string key, string token, string filter, string fields, string activity);
        /// <summary>
        /// getOrganizationsMembersByIdOrgByFilter() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetOrganizationsMembersByIdOrgByFilter (string idOrg, string filter, string key, string token);
        /// <summary>
        /// getOrganizationsMembersCardsByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="idMember">idMember</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <param name="members"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="checkItemStates"> true or false</param>
        /// <param name="checklists">One of: all or none</param>
        /// <param name="board"> true or false</param>
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="list"> true or false</param>
        /// <param name="listFields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <param name="filter">One of: all, closed, none, open or visible</param>
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <returns></returns>
        void GetOrganizationsMembersCardsByIdOrgByIdMember (string idOrg, string idMember, string key, string token, string actions, string attachments, string attachmentFields, string members, string memberFields, string checkItemStates, string checklists, string board, string boardFields, string list, string listFields, string filter, string fields);
        /// <summary>
        /// getOrganizationsMembersInvitedByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param>
        /// <returns></returns>
        void GetOrganizationsMembersInvitedByIdOrg (string idOrg, string key, string token, string fields);
        /// <summary>
        /// getOrganizationsMembersInvitedByIdOrgByField() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetOrganizationsMembersInvitedByIdOrgByField (string idOrg, string field, string key, string token);
        /// <summary>
        /// getOrganizationsMembershipsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">all or a comma-separated list of: active, admin, deactivated, me or normal</param>
        /// <param name="member"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetOrganizationsMembershipsByIdOrg (string idOrg, string key, string token, string filter, string member, string memberFields);
        /// <summary>
        /// getOrganizationsMembershipsByIdOrgByIdMembership() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="idMembership">idMembership</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="member"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetOrganizationsMembershipsByIdOrgByIdMembership (string idOrg, string idMembership, string key, string token, string member, string memberFields);
        /// <summary>
        /// updateOrganizationsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Organizations\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsByIdOrg (string idOrg, Organizations body, string key, string token);
        /// <summary>
        /// updateOrganizationsDescByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Organizations Desc\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsDescByIdOrg (string idOrg, OrganizationsDesc body, string key, string token);
        /// <summary>
        /// updateOrganizationsDisplayNameByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Organizations Display Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsDisplayNameByIdOrg (string idOrg, OrganizationsDisplayName body, string key, string token);
        /// <summary>
        /// updateOrganizationsMembersByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Organizations Members\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsMembersByIdOrg (string idOrg, OrganizationsMembers body, string key, string token);
        /// <summary>
        /// updateOrganizationsMembersByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="idMember">idMember</param>
        /// <param name="body">Attributes of \&quot;Organizations Members\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsMembersByIdOrgByIdMember (string idOrg, string idMember, OrganizationsMembers body, string key, string token);
        /// <summary>
        /// updateOrganizationsMembersDeactivatedByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="idMember">idMember</param>
        /// <param name="body">Attributes of \&quot;Organizations Members Deactivated\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember (string idOrg, string idMember, OrganizationsMembersDeactivated body, string key, string token);
        /// <summary>
        /// updateOrganizationsMembershipsByIdOrgByIdMembership() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="idMembership">idMembership</param>
        /// <param name="body">Attributes of \&quot;Organizations Memberships\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsMembershipsByIdOrgByIdMembership (string idOrg, string idMembership, OrganizationsMemberships body, string key, string token);
        /// <summary>
        /// updateOrganizationsNameByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Organizations Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsNameByIdOrg (string idOrg, OrganizationsName body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsAssociatedDomainByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs Associated Domain\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsAssociatedDomainByIdOrg (string idOrg, PrefsAssociatedDomain body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs Board Visibility Restrict\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg (string idOrg, PrefsBoardVisibilityRestrict body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs Board Visibility Restrict\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg (string idOrg, PrefsBoardVisibilityRestrict body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs Board Visibility Restrict\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg (string idOrg, PrefsBoardVisibilityRestrict body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsExternalMembersDisabledByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs External Members Disabled\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg (string idOrg, PrefsExternalMembersDisabled body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsGoogleAppsVersionByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs Google Apps Version\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg (string idOrg, PrefsGoogleAppsVersion body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsOrgInviteRestrictByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs Org Invite Restrict\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg (string idOrg, PrefsOrgInviteRestrict body, string key, string token);
        /// <summary>
        /// updateOrganizationsPrefsPermissionLevelByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Prefs Permission Level\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsPrefsPermissionLevelByIdOrg (string idOrg, PrefsPermissionLevel body, string key, string token);
        /// <summary>
        /// updateOrganizationsWebsiteByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param>
        /// <param name="body">Attributes of \&quot;Organizations Website\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateOrganizationsWebsiteByIdOrg (string idOrg, OrganizationsWebsite body, string key, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrganizationApi : IOrganizationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OrganizationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrganizationApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// addOrganizations() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Organizations\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddOrganizations (Organizations body, string key, string token)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOrganizations");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddOrganizations");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddOrganizations");
            
    
            var path = "/organizations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrganizations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrganizations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addOrganizationsLogoByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Organizations Logo\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddOrganizationsLogoByIdOrg (string idOrg, OrganizationsLogo body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling AddOrganizationsLogoByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddOrganizationsLogoByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddOrganizationsLogoByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddOrganizationsLogoByIdOrg");
            
    
            var path = "/organizations/{idOrg}/logo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrganizationsLogoByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddOrganizationsLogoByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteOrganizationsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteOrganizationsByIdOrg (string idOrg, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling DeleteOrganizationsByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteOrganizationsByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteOrganizationsByIdOrg");
            
    
            var path = "/organizations/{idOrg}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteOrganizationsLogoByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteOrganizationsLogoByIdOrg (string idOrg, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling DeleteOrganizationsLogoByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteOrganizationsLogoByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteOrganizationsLogoByIdOrg");
            
    
            var path = "/organizations/{idOrg}/logo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsLogoByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsLogoByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteOrganizationsMembersAllByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteOrganizationsMembersAllByIdOrgByIdMember (string idOrg, string idMember, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling DeleteOrganizationsMembersAllByIdOrgByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteOrganizationsMembersAllByIdOrgByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteOrganizationsMembersAllByIdOrgByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteOrganizationsMembersAllByIdOrgByIdMember");
            
    
            var path = "/organizations/{idOrg}/members/{idMember}/all";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsMembersAllByIdOrgByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsMembersAllByIdOrgByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteOrganizationsMembersByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteOrganizationsMembersByIdOrgByIdMember (string idOrg, string idMember, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling DeleteOrganizationsMembersByIdOrgByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteOrganizationsMembersByIdOrgByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteOrganizationsMembersByIdOrgByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteOrganizationsMembersByIdOrgByIdMember");
            
    
            var path = "/organizations/{idOrg}/members/{idMember}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsMembersByIdOrgByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsMembersByIdOrgByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteOrganizationsPrefsAssociatedDomainByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteOrganizationsPrefsAssociatedDomainByIdOrg (string idOrg, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling DeleteOrganizationsPrefsAssociatedDomainByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteOrganizationsPrefsAssociatedDomainByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteOrganizationsPrefsAssociatedDomainByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/associatedDomain";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsPrefsAssociatedDomainByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsPrefsAssociatedDomainByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteOrganizationsPrefsOrgInviteRestrictByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="value">An email address with optional expansion tokens</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg (string idOrg, string value, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
            // verify the required parameter 'value' is set
            if (value == null) throw new ApiException(400, "Missing required parameter 'value' when calling DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/orgInviteRestrict";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteOrganizationsPrefsOrgInviteRestrictByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsActionsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="entities"> true or false</param> 
        /// <param name="display"> true or false</param> 
        /// <param name="filter">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="limit">a number from 0 to 1000</param> 
        /// <param name="format">One of: count, list or minimal</param> 
        /// <param name="since">A date, null or lastView</param> 
        /// <param name="before">A date, or null</param> 
        /// <param name="page">Page * limit must be less than 1000</param> 
        /// <param name="idModels">Only return actions related to these model ids</param> 
        /// <param name="member"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="memberCreator"> true or false</param> 
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetOrganizationsActionsByIdOrg (string idOrg, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsActionsByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsActionsByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsActionsByIdOrg");
            
    
            var path = "/organizations/{idOrg}/actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (entities != null) queryParams.Add("entities", ApiClient.ParameterToString(entities)); // query parameter
 if (display != null) queryParams.Add("display", ApiClient.ParameterToString(display)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (idModels != null) queryParams.Add("idModels", ApiClient.ParameterToString(idModels)); // query parameter
 if (member != null) queryParams.Add("member", ApiClient.ParameterToString(member)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (memberCreator != null) queryParams.Add("memberCreator", ApiClient.ParameterToString(memberCreator)); // query parameter
 if (memberCreatorFields != null) queryParams.Add("memberCreator_fields", ApiClient.ParameterToString(memberCreatorFields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsActionsByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsActionsByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsBoardsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">all or a comma-separated list of: closed, members, open, organization, pinned, public, starred or unpinned</param> 
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="actionsEntities"> true or false</param> 
        /// <param name="actionsLimit">a number from 0 to 1000</param> 
        /// <param name="actionsFormat">One of: count, list or minimal</param> 
        /// <param name="actionsSince">A date, null or lastView</param> 
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="memberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param> 
        /// <param name="organization"> true or false</param> 
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="lists">One of: all, closed, none or open</param> 
        /// <returns></returns>            
        public void GetOrganizationsBoardsByIdOrg (string idOrg, string key, string token, string filter, string fields, string actions, string actionsEntities, string actionsLimit, string actionsFormat, string actionsSince, string actionFields, string memberships, string organization, string organizationFields, string lists)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsBoardsByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsBoardsByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsBoardsByIdOrg");
            
    
            var path = "/organizations/{idOrg}/boards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (actions != null) queryParams.Add("actions", ApiClient.ParameterToString(actions)); // query parameter
 if (actionsEntities != null) queryParams.Add("actions_entities", ApiClient.ParameterToString(actionsEntities)); // query parameter
 if (actionsLimit != null) queryParams.Add("actions_limit", ApiClient.ParameterToString(actionsLimit)); // query parameter
 if (actionsFormat != null) queryParams.Add("actions_format", ApiClient.ParameterToString(actionsFormat)); // query parameter
 if (actionsSince != null) queryParams.Add("actions_since", ApiClient.ParameterToString(actionsSince)); // query parameter
 if (actionFields != null) queryParams.Add("action_fields", ApiClient.ParameterToString(actionFields)); // query parameter
 if (memberships != null) queryParams.Add("memberships", ApiClient.ParameterToString(memberships)); // query parameter
 if (organization != null) queryParams.Add("organization", ApiClient.ParameterToString(organization)); // query parameter
 if (organizationFields != null) queryParams.Add("organization_fields", ApiClient.ParameterToString(organizationFields)); // query parameter
 if (lists != null) queryParams.Add("lists", ApiClient.ParameterToString(lists)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsBoardsByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsBoardsByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsBoardsByIdOrgByFilter() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetOrganizationsBoardsByIdOrgByFilter (string idOrg, string filter, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsBoardsByIdOrgByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetOrganizationsBoardsByIdOrgByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsBoardsByIdOrgByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsBoardsByIdOrgByFilter");
            
    
            var path = "/organizations/{idOrg}/boards/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "filter" + "}", ApiClient.ParameterToString(filter));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsBoardsByIdOrgByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsBoardsByIdOrgByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="actionsEntities"> true or false</param> 
        /// <param name="actionsDisplay"> true or false</param> 
        /// <param name="actionsLimit">a number from 0 to 1000</param> 
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="memberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param> 
        /// <param name="membershipsMember"> true or false</param> 
        /// <param name="membershipsMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="members">One of: admins, all, none, normal or owners</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="memberActivity">true or false ; works for premium organizations only.</param> 
        /// <param name="membersInvited">One of: admins, all, none, normal or owners</param> 
        /// <param name="membersInvitedFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="boards">all or a comma-separated list of: closed, members, open, organization, pinned, public, starred or unpinned</param> 
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="boardActions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="boardActionsEntities"> true or false</param> 
        /// <param name="boardActionsDisplay"> true or false</param> 
        /// <param name="boardActionsFormat">One of: count, list or minimal</param> 
        /// <param name="boardActionsSince">A date, null or lastView</param> 
        /// <param name="boardActionsLimit">a number from 0 to 1000</param> 
        /// <param name="boardActionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="boardLists">One of: all, closed, none or open</param> 
        /// <param name="paidAccount"> true or false</param> 
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <returns></returns>            
        public void GetOrganizationsByIdOrg (string idOrg, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string memberships, string membershipsMember, string membershipsMemberFields, string members, string memberFields, string memberActivity, string membersInvited, string membersInvitedFields, string boards, string boardFields, string boardActions, string boardActionsEntities, string boardActionsDisplay, string boardActionsFormat, string boardActionsSince, string boardActionsLimit, string boardActionFields, string boardLists, string paidAccount, string fields)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsByIdOrg");
            
    
            var path = "/organizations/{idOrg}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (actions != null) queryParams.Add("actions", ApiClient.ParameterToString(actions)); // query parameter
 if (actionsEntities != null) queryParams.Add("actions_entities", ApiClient.ParameterToString(actionsEntities)); // query parameter
 if (actionsDisplay != null) queryParams.Add("actions_display", ApiClient.ParameterToString(actionsDisplay)); // query parameter
 if (actionsLimit != null) queryParams.Add("actions_limit", ApiClient.ParameterToString(actionsLimit)); // query parameter
 if (actionFields != null) queryParams.Add("action_fields", ApiClient.ParameterToString(actionFields)); // query parameter
 if (memberships != null) queryParams.Add("memberships", ApiClient.ParameterToString(memberships)); // query parameter
 if (membershipsMember != null) queryParams.Add("memberships_member", ApiClient.ParameterToString(membershipsMember)); // query parameter
 if (membershipsMemberFields != null) queryParams.Add("memberships_member_fields", ApiClient.ParameterToString(membershipsMemberFields)); // query parameter
 if (members != null) queryParams.Add("members", ApiClient.ParameterToString(members)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (memberActivity != null) queryParams.Add("member_activity", ApiClient.ParameterToString(memberActivity)); // query parameter
 if (membersInvited != null) queryParams.Add("membersInvited", ApiClient.ParameterToString(membersInvited)); // query parameter
 if (membersInvitedFields != null) queryParams.Add("membersInvited_fields", ApiClient.ParameterToString(membersInvitedFields)); // query parameter
 if (boards != null) queryParams.Add("boards", ApiClient.ParameterToString(boards)); // query parameter
 if (boardFields != null) queryParams.Add("board_fields", ApiClient.ParameterToString(boardFields)); // query parameter
 if (boardActions != null) queryParams.Add("board_actions", ApiClient.ParameterToString(boardActions)); // query parameter
 if (boardActionsEntities != null) queryParams.Add("board_actions_entities", ApiClient.ParameterToString(boardActionsEntities)); // query parameter
 if (boardActionsDisplay != null) queryParams.Add("board_actions_display", ApiClient.ParameterToString(boardActionsDisplay)); // query parameter
 if (boardActionsFormat != null) queryParams.Add("board_actions_format", ApiClient.ParameterToString(boardActionsFormat)); // query parameter
 if (boardActionsSince != null) queryParams.Add("board_actions_since", ApiClient.ParameterToString(boardActionsSince)); // query parameter
 if (boardActionsLimit != null) queryParams.Add("board_actions_limit", ApiClient.ParameterToString(boardActionsLimit)); // query parameter
 if (boardActionFields != null) queryParams.Add("board_action_fields", ApiClient.ParameterToString(boardActionFields)); // query parameter
 if (boardLists != null) queryParams.Add("board_lists", ApiClient.ParameterToString(boardLists)); // query parameter
 if (paidAccount != null) queryParams.Add("paid_account", ApiClient.ParameterToString(paidAccount)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsByIdOrgByField() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetOrganizationsByIdOrgByField (string idOrg, string field, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsByIdOrgByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetOrganizationsByIdOrgByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsByIdOrgByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsByIdOrgByField");
            
    
            var path = "/organizations/{idOrg}/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "field" + "}", ApiClient.ParameterToString(field));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsByIdOrgByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsByIdOrgByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsDeltasByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="tags">A valid tag for subscribing</param> 
        /// <param name="ixLastUpdate">a number from -1 to Infinity</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetOrganizationsDeltasByIdOrg (string idOrg, string tags, string ixLastUpdate, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsDeltasByIdOrg");
            
            // verify the required parameter 'tags' is set
            if (tags == null) throw new ApiException(400, "Missing required parameter 'tags' when calling GetOrganizationsDeltasByIdOrg");
            
            // verify the required parameter 'ixLastUpdate' is set
            if (ixLastUpdate == null) throw new ApiException(400, "Missing required parameter 'ixLastUpdate' when calling GetOrganizationsDeltasByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsDeltasByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsDeltasByIdOrg");
            
    
            var path = "/organizations/{idOrg}/deltas";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tags != null) queryParams.Add("tags", ApiClient.ParameterToString(tags)); // query parameter
 if (ixLastUpdate != null) queryParams.Add("ixLastUpdate", ApiClient.ParameterToString(ixLastUpdate)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsDeltasByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsDeltasByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsMembersByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: admins, all, none, normal or owners</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="activity">true or false ; works for premium organizations only.</param> 
        /// <returns></returns>            
        public void GetOrganizationsMembersByIdOrg (string idOrg, string key, string token, string filter, string fields, string activity)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsMembersByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsMembersByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsMembersByIdOrg");
            
    
            var path = "/organizations/{idOrg}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (activity != null) queryParams.Add("activity", ApiClient.ParameterToString(activity)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsMembersByIdOrgByFilter() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetOrganizationsMembersByIdOrgByFilter (string idOrg, string filter, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsMembersByIdOrgByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetOrganizationsMembersByIdOrgByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsMembersByIdOrgByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsMembersByIdOrgByFilter");
            
    
            var path = "/organizations/{idOrg}/members/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "filter" + "}", ApiClient.ParameterToString(filter));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersByIdOrgByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersByIdOrgByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsMembersCardsByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <param name="members"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="checkItemStates"> true or false</param> 
        /// <param name="checklists">One of: all or none</param> 
        /// <param name="board"> true or false</param> 
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="list"> true or false</param> 
        /// <param name="listFields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <param name="filter">One of: all, closed, none, open or visible</param> 
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <returns></returns>            
        public void GetOrganizationsMembersCardsByIdOrgByIdMember (string idOrg, string idMember, string key, string token, string actions, string attachments, string attachmentFields, string members, string memberFields, string checkItemStates, string checklists, string board, string boardFields, string list, string listFields, string filter, string fields)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsMembersCardsByIdOrgByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetOrganizationsMembersCardsByIdOrgByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsMembersCardsByIdOrgByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsMembersCardsByIdOrgByIdMember");
            
    
            var path = "/organizations/{idOrg}/members/{idMember}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (actions != null) queryParams.Add("actions", ApiClient.ParameterToString(actions)); // query parameter
 if (attachments != null) queryParams.Add("attachments", ApiClient.ParameterToString(attachments)); // query parameter
 if (attachmentFields != null) queryParams.Add("attachment_fields", ApiClient.ParameterToString(attachmentFields)); // query parameter
 if (members != null) queryParams.Add("members", ApiClient.ParameterToString(members)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (checkItemStates != null) queryParams.Add("checkItemStates", ApiClient.ParameterToString(checkItemStates)); // query parameter
 if (checklists != null) queryParams.Add("checklists", ApiClient.ParameterToString(checklists)); // query parameter
 if (board != null) queryParams.Add("board", ApiClient.ParameterToString(board)); // query parameter
 if (boardFields != null) queryParams.Add("board_fields", ApiClient.ParameterToString(boardFields)); // query parameter
 if (list != null) queryParams.Add("list", ApiClient.ParameterToString(list)); // query parameter
 if (listFields != null) queryParams.Add("list_fields", ApiClient.ParameterToString(listFields)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersCardsByIdOrgByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersCardsByIdOrgByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsMembersInvitedByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param> 
        /// <returns></returns>            
        public void GetOrganizationsMembersInvitedByIdOrg (string idOrg, string key, string token, string fields)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsMembersInvitedByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsMembersInvitedByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsMembersInvitedByIdOrg");
            
    
            var path = "/organizations/{idOrg}/membersInvited";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersInvitedByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersInvitedByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsMembersInvitedByIdOrgByField() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetOrganizationsMembersInvitedByIdOrgByField (string idOrg, string field, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsMembersInvitedByIdOrgByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetOrganizationsMembersInvitedByIdOrgByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsMembersInvitedByIdOrgByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsMembersInvitedByIdOrgByField");
            
    
            var path = "/organizations/{idOrg}/membersInvited/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "field" + "}", ApiClient.ParameterToString(field));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersInvitedByIdOrgByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembersInvitedByIdOrgByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsMembershipsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">all or a comma-separated list of: active, admin, deactivated, me or normal</param> 
        /// <param name="member"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetOrganizationsMembershipsByIdOrg (string idOrg, string key, string token, string filter, string member, string memberFields)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsMembershipsByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsMembershipsByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsMembershipsByIdOrg");
            
    
            var path = "/organizations/{idOrg}/memberships";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (member != null) queryParams.Add("member", ApiClient.ParameterToString(member)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembershipsByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembershipsByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getOrganizationsMembershipsByIdOrgByIdMembership() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="idMembership">idMembership</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="member"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetOrganizationsMembershipsByIdOrgByIdMembership (string idOrg, string idMembership, string key, string token, string member, string memberFields)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling GetOrganizationsMembershipsByIdOrgByIdMembership");
            
            // verify the required parameter 'idMembership' is set
            if (idMembership == null) throw new ApiException(400, "Missing required parameter 'idMembership' when calling GetOrganizationsMembershipsByIdOrgByIdMembership");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetOrganizationsMembershipsByIdOrgByIdMembership");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetOrganizationsMembershipsByIdOrgByIdMembership");
            
    
            var path = "/organizations/{idOrg}/memberships/{idMembership}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "idMembership" + "}", ApiClient.ParameterToString(idMembership));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (member != null) queryParams.Add("member", ApiClient.ParameterToString(member)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembershipsByIdOrgByIdMembership: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetOrganizationsMembershipsByIdOrgByIdMembership: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Organizations\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsByIdOrg (string idOrg, Organizations body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsByIdOrg");
            
    
            var path = "/organizations/{idOrg}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsDescByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Organizations Desc\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsDescByIdOrg (string idOrg, OrganizationsDesc body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsDescByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsDescByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsDescByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsDescByIdOrg");
            
    
            var path = "/organizations/{idOrg}/desc";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsDescByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsDescByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsDisplayNameByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Organizations Display Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsDisplayNameByIdOrg (string idOrg, OrganizationsDisplayName body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsDisplayNameByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsDisplayNameByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsDisplayNameByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsDisplayNameByIdOrg");
            
    
            var path = "/organizations/{idOrg}/displayName";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsDisplayNameByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsDisplayNameByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsMembersByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Organizations Members\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsMembersByIdOrg (string idOrg, OrganizationsMembers body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsMembersByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsMembersByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsMembersByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsMembersByIdOrg");
            
    
            var path = "/organizations/{idOrg}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembersByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembersByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsMembersByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="body">Attributes of \&quot;Organizations Members\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsMembersByIdOrgByIdMember (string idOrg, string idMember, OrganizationsMembers body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsMembersByIdOrgByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateOrganizationsMembersByIdOrgByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsMembersByIdOrgByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsMembersByIdOrgByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsMembersByIdOrgByIdMember");
            
    
            var path = "/organizations/{idOrg}/members/{idMember}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembersByIdOrgByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembersByIdOrgByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsMembersDeactivatedByIdOrgByIdMember() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="body">Attributes of \&quot;Organizations Members Deactivated\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember (string idOrg, string idMember, OrganizationsMembersDeactivated body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember");
            
    
            var path = "/organizations/{idOrg}/members/{idMember}/deactivated";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembersDeactivatedByIdOrgByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsMembershipsByIdOrgByIdMembership() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="idMembership">idMembership</param> 
        /// <param name="body">Attributes of \&quot;Organizations Memberships\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsMembershipsByIdOrgByIdMembership (string idOrg, string idMembership, OrganizationsMemberships body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsMembershipsByIdOrgByIdMembership");
            
            // verify the required parameter 'idMembership' is set
            if (idMembership == null) throw new ApiException(400, "Missing required parameter 'idMembership' when calling UpdateOrganizationsMembershipsByIdOrgByIdMembership");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsMembershipsByIdOrgByIdMembership");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsMembershipsByIdOrgByIdMembership");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsMembershipsByIdOrgByIdMembership");
            
    
            var path = "/organizations/{idOrg}/memberships/{idMembership}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
path = path.Replace("{" + "idMembership" + "}", ApiClient.ParameterToString(idMembership));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembershipsByIdOrgByIdMembership: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsMembershipsByIdOrgByIdMembership: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsNameByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Organizations Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsNameByIdOrg (string idOrg, OrganizationsName body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsNameByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsNameByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsNameByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsNameByIdOrg");
            
    
            var path = "/organizations/{idOrg}/name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsNameByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsNameByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsAssociatedDomainByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs Associated Domain\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsAssociatedDomainByIdOrg (string idOrg, PrefsAssociatedDomain body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsAssociatedDomainByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsAssociatedDomainByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsAssociatedDomainByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsAssociatedDomainByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/associatedDomain";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsAssociatedDomainByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsAssociatedDomainByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs Board Visibility Restrict\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg (string idOrg, PrefsBoardVisibilityRestrict body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/boardVisibilityRestrict/org";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsBoardVisibilityRestrictOrgByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs Board Visibility Restrict\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg (string idOrg, PrefsBoardVisibilityRestrict body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/boardVisibilityRestrict/private";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsBoardVisibilityRestrictPrivateByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs Board Visibility Restrict\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg (string idOrg, PrefsBoardVisibilityRestrict body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/boardVisibilityRestrict/public";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsBoardVisibilityRestrictPublicByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsExternalMembersDisabledByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs External Members Disabled\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg (string idOrg, PrefsExternalMembersDisabled body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/externalMembersDisabled";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsExternalMembersDisabledByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsGoogleAppsVersionByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs Google Apps Version\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg (string idOrg, PrefsGoogleAppsVersion body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/googleAppsVersion";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsGoogleAppsVersionByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsOrgInviteRestrictByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs Org Invite Restrict\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg (string idOrg, PrefsOrgInviteRestrict body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/orgInviteRestrict";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsOrgInviteRestrictByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsPrefsPermissionLevelByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Prefs Permission Level\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsPrefsPermissionLevelByIdOrg (string idOrg, PrefsPermissionLevel body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsPrefsPermissionLevelByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsPrefsPermissionLevelByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsPrefsPermissionLevelByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsPrefsPermissionLevelByIdOrg");
            
    
            var path = "/organizations/{idOrg}/prefs/permissionLevel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsPermissionLevelByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsPrefsPermissionLevelByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateOrganizationsWebsiteByIdOrg() 
        /// </summary>
        /// <param name="idOrg">idOrg or name</param> 
        /// <param name="body">Attributes of \&quot;Organizations Website\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateOrganizationsWebsiteByIdOrg (string idOrg, OrganizationsWebsite body, string key, string token)
        {
            
            // verify the required parameter 'idOrg' is set
            if (idOrg == null) throw new ApiException(400, "Missing required parameter 'idOrg' when calling UpdateOrganizationsWebsiteByIdOrg");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateOrganizationsWebsiteByIdOrg");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateOrganizationsWebsiteByIdOrg");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateOrganizationsWebsiteByIdOrg");
            
    
            var path = "/organizations/{idOrg}/website";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idOrg" + "}", ApiClient.ParameterToString(idOrg));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsWebsiteByIdOrg: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateOrganizationsWebsiteByIdOrg: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
