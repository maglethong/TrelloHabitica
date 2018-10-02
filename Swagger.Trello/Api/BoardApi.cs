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
    public interface IBoardApi
    {
        /// <summary>
        /// addBoards() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Boards\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoards (Boards body, string key, string token);
        /// <summary>
        /// addBoardsCalendarKeyGenerateByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoardsCalendarKeyGenerateByIdBoard (string idBoard, string key, string token);
        /// <summary>
        /// addBoardsChecklistsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Checklists\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoardsChecklistsByIdBoard (string idBoard, BoardsChecklists body, string key, string token);
        /// <summary>
        /// addBoardsEmailKeyGenerateByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoardsEmailKeyGenerateByIdBoard (string idBoard, string key, string token);
        /// <summary>
        /// addBoardsLabelsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Labels\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoardsLabelsByIdBoard (string idBoard, BoardsLabels body, string key, string token);
        /// <summary>
        /// addBoardsListsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Lists\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoardsListsByIdBoard (string idBoard, BoardsLists body, string key, string token);
        /// <summary>
        /// addBoardsMarkAsViewedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoardsMarkAsViewedByIdBoard (string idBoard, string key, string token);
        /// <summary>
        /// addBoardsPowerUpsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Power Ups\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddBoardsPowerUpsByIdBoard (string idBoard, BoardsPowerUps body, string key, string token);
        /// <summary>
        /// deleteBoardsMembersByIdBoardByIdMember() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="idMember">idMember</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteBoardsMembersByIdBoardByIdMember (string idBoard, string idMember, string key, string token);
        /// <summary>
        /// deleteBoardsPowerUpsByIdBoardByPowerUp() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="powerUp">powerUp</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteBoardsPowerUpsByIdBoardByPowerUp (string idBoard, string powerUp, string key, string token);
        /// <summary>
        /// getBoardsActionsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
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
        void GetBoardsActionsByIdBoard (string idBoard, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields);
        /// <summary>
        /// getBoardsBoardStarsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: mine or none</param>
        /// <returns></returns>
        void GetBoardsBoardStarsByIdBoard (string idBoard, string key, string token, string filter);
        /// <summary>
        /// getBoardsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="actionsEntities"> true or false</param>
        /// <param name="actionsDisplay"> true or false</param>
        /// <param name="actionsFormat">One of: count, list or minimal</param>
        /// <param name="actionsSince">A date, null or lastView</param>
        /// <param name="actionsLimit">a number from 0 to 1000</param>
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="actionMember"> true or false</param>
        /// <param name="actionMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="actionMemberCreator"> true or false</param>
        /// <param name="actionMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="cards">One of: all, closed, none, open or visible</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="cardAttachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <param name="cardAttachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <param name="cardChecklists">One of: all or none</param>
        /// <param name="cardStickers"> true or false</param>
        /// <param name="boardStars">One of: mine or none</param>
        /// <param name="labels">One of: all or none</param>
        /// <param name="labelFields">all or a comma-separated list of: color, idBoard, name or uses</param>
        /// <param name="labelsLimit">a number from 0 to 1000</param>
        /// <param name="lists">One of: all, closed, none or open</param>
        /// <param name="listFields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <param name="memberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param>
        /// <param name="membershipsMember"> true or false</param>
        /// <param name="membershipsMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="members">One of: admins, all, none, normal or owners</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="membersInvited">One of: admins, all, none, normal or owners</param>
        /// <param name="membersInvitedFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="checklists">One of: all or none</param>
        /// <param name="checklistFields">all or a comma-separated list of: idBoard, idCard, name or pos</param>
        /// <param name="organization"> true or false</param>
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="organizationMemberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param>
        /// <param name="myPrefs"> true or false</param>
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <returns></returns>
        void GetBoardsByIdBoard (string idBoard, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsFormat, string actionsSince, string actionsLimit, string actionFields, string actionMember, string actionMemberFields, string actionMemberCreator, string actionMemberCreatorFields, string cards, string cardFields, string cardAttachments, string cardAttachmentFields, string cardChecklists, string cardStickers, string boardStars, string labels, string labelFields, string labelsLimit, string lists, string listFields, string memberships, string membershipsMember, string membershipsMemberFields, string members, string memberFields, string membersInvited, string membersInvitedFields, string checklists, string checklistFields, string organization, string organizationFields, string organizationMemberships, string myPrefs, string fields);
        /// <summary>
        /// getBoardsByIdBoardByField() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsByIdBoardByField (string idBoard, string field, string key, string token);
        /// <summary>
        /// getBoardsCardsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <param name="stickers"> true or false</param>
        /// <param name="members"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="checkItemStates"> true or false</param>
        /// <param name="checklists">One of: all or none</param>
        /// <param name="limit">a number from 1 to 1000</param>
        /// <param name="since">A date, or null</param>
        /// <param name="before">A date, or null</param>
        /// <param name="filter">One of: all, closed, none, open or visible</param>
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <returns></returns>
        void GetBoardsCardsByIdBoard (string idBoard, string key, string token, string actions, string attachments, string attachmentFields, string stickers, string members, string memberFields, string checkItemStates, string checklists, string limit, string since, string before, string filter, string fields);
        /// <summary>
        /// getBoardsCardsByIdBoardByFilter() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsCardsByIdBoardByFilter (string idBoard, string filter, string key, string token);
        /// <summary>
        /// getBoardsCardsByIdBoardByIdCard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="idCard">idCard</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="actionsEntities"> true or false</param>
        /// <param name="actionsDisplay"> true or false</param>
        /// <param name="actionsLimit">a number from 0 to 1000</param>
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="actionMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="members"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="checkItemStates"> true or false</param>
        /// <param name="checkItemStateFields">all or a comma-separated list of: idCheckItem or state</param>
        /// <param name="labels"> true or false</param>
        /// <param name="checklists">One of: all or none</param>
        /// <param name="checklistFields">all or a comma-separated list of: idBoard, idCard, name or pos</param>
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <returns></returns>
        void GetBoardsCardsByIdBoardByIdCard (string idBoard, string idCard, string key, string token, string attachments, string attachmentFields, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string actionMemberCreatorFields, string members, string memberFields, string checkItemStates, string checkItemStateFields, string labels, string checklists, string checklistFields, string fields);
        /// <summary>
        /// getBoardsChecklistsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="cards">One of: all, closed, none, open or visible</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="checkItems">One of: all or none</param>
        /// <param name="checkItemFields">all or a comma-separated list of: name, nameData, pos, state or type</param>
        /// <param name="filter">One of: all or none</param>
        /// <param name="fields">all or a comma-separated list of: idBoard, idCard, name or pos</param>
        /// <returns></returns>
        void GetBoardsChecklistsByIdBoard (string idBoard, string key, string token, string cards, string cardFields, string checkItems, string checkItemFields, string filter, string fields);
        /// <summary>
        /// getBoardsDeltasByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="tags">A valid tag for subscribing</param>
        /// <param name="ixLastUpdate">a number from -1 to Infinity</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsDeltasByIdBoard (string idBoard, string tags, string ixLastUpdate, string key, string token);
        /// <summary>
        /// getBoardsLabelsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: color, idBoard, name or uses</param>
        /// <param name="limit">a number from 0 to 1000</param>
        /// <returns></returns>
        void GetBoardsLabelsByIdBoard (string idBoard, string key, string token, string fields, string limit);
        /// <summary>
        /// getBoardsLabelsByIdBoardByIdLabel() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="idLabel">idLabel</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: color, idBoard, name or uses</param>
        /// <returns></returns>
        void GetBoardsLabelsByIdBoardByIdLabel (string idBoard, string idLabel, string key, string token, string fields);
        /// <summary>
        /// getBoardsListsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="cards">One of: all, closed, none, open or visible</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="filter">One of: all, closed, none or open</param>
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <returns></returns>
        void GetBoardsListsByIdBoard (string idBoard, string key, string token, string cards, string cardFields, string filter, string fields);
        /// <summary>
        /// getBoardsListsByIdBoardByFilter() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsListsByIdBoardByFilter (string idBoard, string filter, string key, string token);
        /// <summary>
        /// getBoardsMembersByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: admins, all, none, normal or owners</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="activity">true or false ; works for premium organizations only.</param>
        /// <returns></returns>
        void GetBoardsMembersByIdBoard (string idBoard, string key, string token, string filter, string fields, string activity);
        /// <summary>
        /// getBoardsMembersByIdBoardByFilter() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsMembersByIdBoardByFilter (string idBoard, string filter, string key, string token);
        /// <summary>
        /// getBoardsMembersCardsByIdBoardByIdMember() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
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
        void GetBoardsMembersCardsByIdBoardByIdMember (string idBoard, string idMember, string key, string token, string actions, string attachments, string attachmentFields, string members, string memberFields, string checkItemStates, string checklists, string board, string boardFields, string list, string listFields, string filter, string fields);
        /// <summary>
        /// getBoardsMembersInvitedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param>
        /// <returns></returns>
        void GetBoardsMembersInvitedByIdBoard (string idBoard, string key, string token, string fields);
        /// <summary>
        /// getBoardsMembersInvitedByIdBoardByField() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsMembersInvitedByIdBoardByField (string idBoard, string field, string key, string token);
        /// <summary>
        /// getBoardsMembershipsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">all or a comma-separated list of: active, admin, deactivated, me or normal</param>
        /// <param name="member"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetBoardsMembershipsByIdBoard (string idBoard, string key, string token, string filter, string member, string memberFields);
        /// <summary>
        /// getBoardsMembershipsByIdBoardByIdMembership() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="idMembership">idMembership</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="member"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetBoardsMembershipsByIdBoardByIdMembership (string idBoard, string idMembership, string key, string token, string member, string memberFields);
        /// <summary>
        /// getBoardsMyPrefsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsMyPrefsByIdBoard (string idBoard, string key, string token);
        /// <summary>
        /// getBoardsOrganizationByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <returns></returns>
        void GetBoardsOrganizationByIdBoard (string idBoard, string key, string token, string fields);
        /// <summary>
        /// getBoardsOrganizationByIdBoardByField() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetBoardsOrganizationByIdBoardByField (string idBoard, string field, string key, string token);
        /// <summary>
        /// updateBoardsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsByIdBoard (string idBoard, Boards body, string key, string token);
        /// <summary>
        /// updateBoardsClosedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Closed\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsClosedByIdBoard (string idBoard, BoardsClosed body, string key, string token);
        /// <summary>
        /// updateBoardsDescByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Desc\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsDescByIdBoard (string idBoard, BoardsDesc body, string key, string token);
        /// <summary>
        /// updateBoardsIdOrganizationByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Id Organization\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsIdOrganizationByIdBoard (string idBoard, BoardsIdOrganization body, string key, string token);
        /// <summary>
        /// updateBoardsLabelNamesBlueByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Label Names Blue\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsLabelNamesBlueByIdBoard (string idBoard, LabelNamesBlue body, string key, string token);
        /// <summary>
        /// updateBoardsLabelNamesGreenByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Label Names Green\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsLabelNamesGreenByIdBoard (string idBoard, LabelNamesGreen body, string key, string token);
        /// <summary>
        /// updateBoardsLabelNamesOrangeByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Label Names Orange\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsLabelNamesOrangeByIdBoard (string idBoard, LabelNamesOrange body, string key, string token);
        /// <summary>
        /// updateBoardsLabelNamesPurpleByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Label Names Purple\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsLabelNamesPurpleByIdBoard (string idBoard, LabelNamesPurple body, string key, string token);
        /// <summary>
        /// updateBoardsLabelNamesRedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Label Names Red\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsLabelNamesRedByIdBoard (string idBoard, LabelNamesRed body, string key, string token);
        /// <summary>
        /// updateBoardsLabelNamesYellowByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Label Names Yellow\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsLabelNamesYellowByIdBoard (string idBoard, LabelNamesYellow body, string key, string token);
        /// <summary>
        /// updateBoardsMembersByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Members\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMembersByIdBoard (string idBoard, BoardsMembers body, string key, string token);
        /// <summary>
        /// updateBoardsMembersByIdBoardByIdMember() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="idMember">idMember</param>
        /// <param name="body">Attributes of \&quot;Boards Members\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMembersByIdBoardByIdMember (string idBoard, string idMember, BoardsMembers body, string key, string token);
        /// <summary>
        /// updateBoardsMembershipsByIdBoardByIdMembership() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="idMembership">idMembership</param>
        /// <param name="body">Attributes of \&quot;Boards Memberships\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMembershipsByIdBoardByIdMembership (string idBoard, string idMembership, BoardsMemberships body, string key, string token);
        /// <summary>
        /// updateBoardsMyPrefsEmailPositionByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;My Prefs Email Position\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMyPrefsEmailPositionByIdBoard (string idBoard, MyPrefsEmailPosition body, string key, string token);
        /// <summary>
        /// updateBoardsMyPrefsIdEmailListByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;My Prefs Id Email List\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMyPrefsIdEmailListByIdBoard (string idBoard, MyPrefsIdEmailList body, string key, string token);
        /// <summary>
        /// updateBoardsMyPrefsShowListGuideByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;My Prefs Show List Guide\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMyPrefsShowListGuideByIdBoard (string idBoard, MyPrefsShowListGuide body, string key, string token);
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarActivityByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar Activity\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMyPrefsShowSidebarActivityByIdBoard (string idBoard, MyPrefsShowSidebarActivity body, string key, string token);
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarBoardActionsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar Board Actions\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard (string idBoard, MyPrefsShowSidebarBoardActions body, string key, string token);
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMyPrefsShowSidebarByIdBoard (string idBoard, MyPrefsShowSidebar body, string key, string token);
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarMembersByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar Members\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsMyPrefsShowSidebarMembersByIdBoard (string idBoard, MyPrefsShowSidebarMembers body, string key, string token);
        /// <summary>
        /// updateBoardsNameByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsNameByIdBoard (string idBoard, BoardsName body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsBackgroundByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Background\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsBackgroundByIdBoard (string idBoard, PrefsBackground body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsCalendarFeedEnabledByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Calendar Feed Enabled\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsCalendarFeedEnabledByIdBoard (string idBoard, PrefsCalendarFeedEnabled body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsCardAgingByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Card Aging\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsCardAgingByIdBoard (string idBoard, PrefsCardAging body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsCardCoversByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Card Covers\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsCardCoversByIdBoard (string idBoard, PrefsCardCovers body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsCommentsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Comments\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsCommentsByIdBoard (string idBoard, PrefsComments body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsInvitationsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Invitations\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsInvitationsByIdBoard (string idBoard, PrefsInvitations body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsPermissionLevelByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Permission Level\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsPermissionLevelByIdBoard (string idBoard, PrefsPermissionLevel body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsSelfJoinByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Self Join\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsSelfJoinByIdBoard (string idBoard, PrefsSelfJoin body, string key, string token);
        /// <summary>
        /// updateBoardsPrefsVotingByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Prefs Voting\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsPrefsVotingByIdBoard (string idBoard, PrefsVoting body, string key, string token);
        /// <summary>
        /// updateBoardsSubscribedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param>
        /// <param name="body">Attributes of \&quot;Boards Subscribed\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateBoardsSubscribedByIdBoard (string idBoard, BoardsSubscribed body, string key, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BoardApi : IBoardApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BoardApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BoardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BoardApi(String basePath)
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
        /// addBoards() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Boards\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoards (Boards body, string key, string token)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBoards");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoards");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoards");
            
    
            var path = "/boards";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoards: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoards: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addBoardsCalendarKeyGenerateByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoardsCalendarKeyGenerateByIdBoard (string idBoard, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling AddBoardsCalendarKeyGenerateByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoardsCalendarKeyGenerateByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoardsCalendarKeyGenerateByIdBoard");
            
    
            var path = "/boards/{idBoard}/calendarKey/generate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsCalendarKeyGenerateByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsCalendarKeyGenerateByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addBoardsChecklistsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Checklists\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoardsChecklistsByIdBoard (string idBoard, BoardsChecklists body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling AddBoardsChecklistsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBoardsChecklistsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoardsChecklistsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoardsChecklistsByIdBoard");
            
    
            var path = "/boards/{idBoard}/checklists";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsChecklistsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsChecklistsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addBoardsEmailKeyGenerateByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoardsEmailKeyGenerateByIdBoard (string idBoard, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling AddBoardsEmailKeyGenerateByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoardsEmailKeyGenerateByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoardsEmailKeyGenerateByIdBoard");
            
    
            var path = "/boards/{idBoard}/emailKey/generate";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsEmailKeyGenerateByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsEmailKeyGenerateByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addBoardsLabelsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Labels\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoardsLabelsByIdBoard (string idBoard, BoardsLabels body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling AddBoardsLabelsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBoardsLabelsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoardsLabelsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoardsLabelsByIdBoard");
            
    
            var path = "/boards/{idBoard}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsLabelsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsLabelsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addBoardsListsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Lists\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoardsListsByIdBoard (string idBoard, BoardsLists body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling AddBoardsListsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBoardsListsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoardsListsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoardsListsByIdBoard");
            
    
            var path = "/boards/{idBoard}/lists";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsListsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsListsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addBoardsMarkAsViewedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoardsMarkAsViewedByIdBoard (string idBoard, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling AddBoardsMarkAsViewedByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoardsMarkAsViewedByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoardsMarkAsViewedByIdBoard");
            
    
            var path = "/boards/{idBoard}/markAsViewed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsMarkAsViewedByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsMarkAsViewedByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addBoardsPowerUpsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Power Ups\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddBoardsPowerUpsByIdBoard (string idBoard, BoardsPowerUps body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling AddBoardsPowerUpsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBoardsPowerUpsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddBoardsPowerUpsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddBoardsPowerUpsByIdBoard");
            
    
            var path = "/boards/{idBoard}/powerUps";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsPowerUpsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBoardsPowerUpsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteBoardsMembersByIdBoardByIdMember() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteBoardsMembersByIdBoardByIdMember (string idBoard, string idMember, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling DeleteBoardsMembersByIdBoardByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteBoardsMembersByIdBoardByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteBoardsMembersByIdBoardByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteBoardsMembersByIdBoardByIdMember");
            
    
            var path = "/boards/{idBoard}/members/{idMember}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBoardsMembersByIdBoardByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBoardsMembersByIdBoardByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteBoardsPowerUpsByIdBoardByPowerUp() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="powerUp">powerUp</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteBoardsPowerUpsByIdBoardByPowerUp (string idBoard, string powerUp, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling DeleteBoardsPowerUpsByIdBoardByPowerUp");
            
            // verify the required parameter 'powerUp' is set
            if (powerUp == null) throw new ApiException(400, "Missing required parameter 'powerUp' when calling DeleteBoardsPowerUpsByIdBoardByPowerUp");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteBoardsPowerUpsByIdBoardByPowerUp");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteBoardsPowerUpsByIdBoardByPowerUp");
            
    
            var path = "/boards/{idBoard}/powerUps/{powerUp}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
path = path.Replace("{" + "powerUp" + "}", ApiClient.ParameterToString(powerUp));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBoardsPowerUpsByIdBoardByPowerUp: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBoardsPowerUpsByIdBoardByPowerUp: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsActionsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
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
        public void GetBoardsActionsByIdBoard (string idBoard, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsActionsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsActionsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsActionsByIdBoard");
            
    
            var path = "/boards/{idBoard}/actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsActionsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsActionsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsBoardStarsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: mine or none</param> 
        /// <returns></returns>            
        public void GetBoardsBoardStarsByIdBoard (string idBoard, string key, string token, string filter)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsBoardStarsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsBoardStarsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsBoardStarsByIdBoard");
            
    
            var path = "/boards/{idBoard}/boardStars";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsBoardStarsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsBoardStarsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="actionsEntities"> true or false</param> 
        /// <param name="actionsDisplay"> true or false</param> 
        /// <param name="actionsFormat">One of: count, list or minimal</param> 
        /// <param name="actionsSince">A date, null or lastView</param> 
        /// <param name="actionsLimit">a number from 0 to 1000</param> 
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="actionMember"> true or false</param> 
        /// <param name="actionMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="actionMemberCreator"> true or false</param> 
        /// <param name="actionMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="cards">One of: all, closed, none, open or visible</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="cardAttachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <param name="cardAttachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <param name="cardChecklists">One of: all or none</param> 
        /// <param name="cardStickers"> true or false</param> 
        /// <param name="boardStars">One of: mine or none</param> 
        /// <param name="labels">One of: all or none</param> 
        /// <param name="labelFields">all or a comma-separated list of: color, idBoard, name or uses</param> 
        /// <param name="labelsLimit">a number from 0 to 1000</param> 
        /// <param name="lists">One of: all, closed, none or open</param> 
        /// <param name="listFields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <param name="memberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param> 
        /// <param name="membershipsMember"> true or false</param> 
        /// <param name="membershipsMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="members">One of: admins, all, none, normal or owners</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="membersInvited">One of: admins, all, none, normal or owners</param> 
        /// <param name="membersInvitedFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="checklists">One of: all or none</param> 
        /// <param name="checklistFields">all or a comma-separated list of: idBoard, idCard, name or pos</param> 
        /// <param name="organization"> true or false</param> 
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="organizationMemberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param> 
        /// <param name="myPrefs"> true or false</param> 
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <returns></returns>            
        public void GetBoardsByIdBoard (string idBoard, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsFormat, string actionsSince, string actionsLimit, string actionFields, string actionMember, string actionMemberFields, string actionMemberCreator, string actionMemberCreatorFields, string cards, string cardFields, string cardAttachments, string cardAttachmentFields, string cardChecklists, string cardStickers, string boardStars, string labels, string labelFields, string labelsLimit, string lists, string listFields, string memberships, string membershipsMember, string membershipsMemberFields, string members, string memberFields, string membersInvited, string membersInvitedFields, string checklists, string checklistFields, string organization, string organizationFields, string organizationMemberships, string myPrefs, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsByIdBoard");
            
    
            var path = "/boards/{idBoard}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (actions != null) queryParams.Add("actions", ApiClient.ParameterToString(actions)); // query parameter
 if (actionsEntities != null) queryParams.Add("actions_entities", ApiClient.ParameterToString(actionsEntities)); // query parameter
 if (actionsDisplay != null) queryParams.Add("actions_display", ApiClient.ParameterToString(actionsDisplay)); // query parameter
 if (actionsFormat != null) queryParams.Add("actions_format", ApiClient.ParameterToString(actionsFormat)); // query parameter
 if (actionsSince != null) queryParams.Add("actions_since", ApiClient.ParameterToString(actionsSince)); // query parameter
 if (actionsLimit != null) queryParams.Add("actions_limit", ApiClient.ParameterToString(actionsLimit)); // query parameter
 if (actionFields != null) queryParams.Add("action_fields", ApiClient.ParameterToString(actionFields)); // query parameter
 if (actionMember != null) queryParams.Add("action_member", ApiClient.ParameterToString(actionMember)); // query parameter
 if (actionMemberFields != null) queryParams.Add("action_member_fields", ApiClient.ParameterToString(actionMemberFields)); // query parameter
 if (actionMemberCreator != null) queryParams.Add("action_memberCreator", ApiClient.ParameterToString(actionMemberCreator)); // query parameter
 if (actionMemberCreatorFields != null) queryParams.Add("action_memberCreator_fields", ApiClient.ParameterToString(actionMemberCreatorFields)); // query parameter
 if (cards != null) queryParams.Add("cards", ApiClient.ParameterToString(cards)); // query parameter
 if (cardFields != null) queryParams.Add("card_fields", ApiClient.ParameterToString(cardFields)); // query parameter
 if (cardAttachments != null) queryParams.Add("card_attachments", ApiClient.ParameterToString(cardAttachments)); // query parameter
 if (cardAttachmentFields != null) queryParams.Add("card_attachment_fields", ApiClient.ParameterToString(cardAttachmentFields)); // query parameter
 if (cardChecklists != null) queryParams.Add("card_checklists", ApiClient.ParameterToString(cardChecklists)); // query parameter
 if (cardStickers != null) queryParams.Add("card_stickers", ApiClient.ParameterToString(cardStickers)); // query parameter
 if (boardStars != null) queryParams.Add("boardStars", ApiClient.ParameterToString(boardStars)); // query parameter
 if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
 if (labelFields != null) queryParams.Add("label_fields", ApiClient.ParameterToString(labelFields)); // query parameter
 if (labelsLimit != null) queryParams.Add("labels_limit", ApiClient.ParameterToString(labelsLimit)); // query parameter
 if (lists != null) queryParams.Add("lists", ApiClient.ParameterToString(lists)); // query parameter
 if (listFields != null) queryParams.Add("list_fields", ApiClient.ParameterToString(listFields)); // query parameter
 if (memberships != null) queryParams.Add("memberships", ApiClient.ParameterToString(memberships)); // query parameter
 if (membershipsMember != null) queryParams.Add("memberships_member", ApiClient.ParameterToString(membershipsMember)); // query parameter
 if (membershipsMemberFields != null) queryParams.Add("memberships_member_fields", ApiClient.ParameterToString(membershipsMemberFields)); // query parameter
 if (members != null) queryParams.Add("members", ApiClient.ParameterToString(members)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (membersInvited != null) queryParams.Add("membersInvited", ApiClient.ParameterToString(membersInvited)); // query parameter
 if (membersInvitedFields != null) queryParams.Add("membersInvited_fields", ApiClient.ParameterToString(membersInvitedFields)); // query parameter
 if (checklists != null) queryParams.Add("checklists", ApiClient.ParameterToString(checklists)); // query parameter
 if (checklistFields != null) queryParams.Add("checklist_fields", ApiClient.ParameterToString(checklistFields)); // query parameter
 if (organization != null) queryParams.Add("organization", ApiClient.ParameterToString(organization)); // query parameter
 if (organizationFields != null) queryParams.Add("organization_fields", ApiClient.ParameterToString(organizationFields)); // query parameter
 if (organizationMemberships != null) queryParams.Add("organization_memberships", ApiClient.ParameterToString(organizationMemberships)); // query parameter
 if (myPrefs != null) queryParams.Add("myPrefs", ApiClient.ParameterToString(myPrefs)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsByIdBoardByField() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsByIdBoardByField (string idBoard, string field, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsByIdBoardByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetBoardsByIdBoardByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsByIdBoardByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsByIdBoardByField");
            
    
            var path = "/boards/{idBoard}/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsByIdBoardByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsByIdBoardByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsCardsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <param name="stickers"> true or false</param> 
        /// <param name="members"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="checkItemStates"> true or false</param> 
        /// <param name="checklists">One of: all or none</param> 
        /// <param name="limit">a number from 1 to 1000</param> 
        /// <param name="since">A date, or null</param> 
        /// <param name="before">A date, or null</param> 
        /// <param name="filter">One of: all, closed, none, open or visible</param> 
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <returns></returns>            
        public void GetBoardsCardsByIdBoard (string idBoard, string key, string token, string actions, string attachments, string attachmentFields, string stickers, string members, string memberFields, string checkItemStates, string checklists, string limit, string since, string before, string filter, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsCardsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsCardsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsCardsByIdBoard");
            
    
            var path = "/boards/{idBoard}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (actions != null) queryParams.Add("actions", ApiClient.ParameterToString(actions)); // query parameter
 if (attachments != null) queryParams.Add("attachments", ApiClient.ParameterToString(attachments)); // query parameter
 if (attachmentFields != null) queryParams.Add("attachment_fields", ApiClient.ParameterToString(attachmentFields)); // query parameter
 if (stickers != null) queryParams.Add("stickers", ApiClient.ParameterToString(stickers)); // query parameter
 if (members != null) queryParams.Add("members", ApiClient.ParameterToString(members)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (checkItemStates != null) queryParams.Add("checkItemStates", ApiClient.ParameterToString(checkItemStates)); // query parameter
 if (checklists != null) queryParams.Add("checklists", ApiClient.ParameterToString(checklists)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsCardsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsCardsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsCardsByIdBoardByFilter() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsCardsByIdBoardByFilter (string idBoard, string filter, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsCardsByIdBoardByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetBoardsCardsByIdBoardByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsCardsByIdBoardByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsCardsByIdBoardByFilter");
            
    
            var path = "/boards/{idBoard}/cards/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsCardsByIdBoardByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsCardsByIdBoardByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsCardsByIdBoardByIdCard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="idCard">idCard</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="actionsEntities"> true or false</param> 
        /// <param name="actionsDisplay"> true or false</param> 
        /// <param name="actionsLimit">a number from 0 to 1000</param> 
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="actionMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="members"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="checkItemStates"> true or false</param> 
        /// <param name="checkItemStateFields">all or a comma-separated list of: idCheckItem or state</param> 
        /// <param name="labels"> true or false</param> 
        /// <param name="checklists">One of: all or none</param> 
        /// <param name="checklistFields">all or a comma-separated list of: idBoard, idCard, name or pos</param> 
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <returns></returns>            
        public void GetBoardsCardsByIdBoardByIdCard (string idBoard, string idCard, string key, string token, string attachments, string attachmentFields, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string actionMemberCreatorFields, string members, string memberFields, string checkItemStates, string checkItemStateFields, string labels, string checklists, string checklistFields, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsCardsByIdBoardByIdCard");
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetBoardsCardsByIdBoardByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsCardsByIdBoardByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsCardsByIdBoardByIdCard");
            
    
            var path = "/boards/{idBoard}/cards/{idCard}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (attachments != null) queryParams.Add("attachments", ApiClient.ParameterToString(attachments)); // query parameter
 if (attachmentFields != null) queryParams.Add("attachment_fields", ApiClient.ParameterToString(attachmentFields)); // query parameter
 if (actions != null) queryParams.Add("actions", ApiClient.ParameterToString(actions)); // query parameter
 if (actionsEntities != null) queryParams.Add("actions_entities", ApiClient.ParameterToString(actionsEntities)); // query parameter
 if (actionsDisplay != null) queryParams.Add("actions_display", ApiClient.ParameterToString(actionsDisplay)); // query parameter
 if (actionsLimit != null) queryParams.Add("actions_limit", ApiClient.ParameterToString(actionsLimit)); // query parameter
 if (actionFields != null) queryParams.Add("action_fields", ApiClient.ParameterToString(actionFields)); // query parameter
 if (actionMemberCreatorFields != null) queryParams.Add("action_memberCreator_fields", ApiClient.ParameterToString(actionMemberCreatorFields)); // query parameter
 if (members != null) queryParams.Add("members", ApiClient.ParameterToString(members)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (checkItemStates != null) queryParams.Add("checkItemStates", ApiClient.ParameterToString(checkItemStates)); // query parameter
 if (checkItemStateFields != null) queryParams.Add("checkItemState_fields", ApiClient.ParameterToString(checkItemStateFields)); // query parameter
 if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
 if (checklists != null) queryParams.Add("checklists", ApiClient.ParameterToString(checklists)); // query parameter
 if (checklistFields != null) queryParams.Add("checklist_fields", ApiClient.ParameterToString(checklistFields)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsCardsByIdBoardByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsCardsByIdBoardByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsChecklistsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="cards">One of: all, closed, none, open or visible</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="checkItems">One of: all or none</param> 
        /// <param name="checkItemFields">all or a comma-separated list of: name, nameData, pos, state or type</param> 
        /// <param name="filter">One of: all or none</param> 
        /// <param name="fields">all or a comma-separated list of: idBoard, idCard, name or pos</param> 
        /// <returns></returns>            
        public void GetBoardsChecklistsByIdBoard (string idBoard, string key, string token, string cards, string cardFields, string checkItems, string checkItemFields, string filter, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsChecklistsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsChecklistsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsChecklistsByIdBoard");
            
    
            var path = "/boards/{idBoard}/checklists";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cards != null) queryParams.Add("cards", ApiClient.ParameterToString(cards)); // query parameter
 if (cardFields != null) queryParams.Add("card_fields", ApiClient.ParameterToString(cardFields)); // query parameter
 if (checkItems != null) queryParams.Add("checkItems", ApiClient.ParameterToString(checkItems)); // query parameter
 if (checkItemFields != null) queryParams.Add("checkItem_fields", ApiClient.ParameterToString(checkItemFields)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsChecklistsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsChecklistsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsDeltasByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="tags">A valid tag for subscribing</param> 
        /// <param name="ixLastUpdate">a number from -1 to Infinity</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsDeltasByIdBoard (string idBoard, string tags, string ixLastUpdate, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsDeltasByIdBoard");
            
            // verify the required parameter 'tags' is set
            if (tags == null) throw new ApiException(400, "Missing required parameter 'tags' when calling GetBoardsDeltasByIdBoard");
            
            // verify the required parameter 'ixLastUpdate' is set
            if (ixLastUpdate == null) throw new ApiException(400, "Missing required parameter 'ixLastUpdate' when calling GetBoardsDeltasByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsDeltasByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsDeltasByIdBoard");
            
    
            var path = "/boards/{idBoard}/deltas";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsDeltasByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsDeltasByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsLabelsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: color, idBoard, name or uses</param> 
        /// <param name="limit">a number from 0 to 1000</param> 
        /// <returns></returns>            
        public void GetBoardsLabelsByIdBoard (string idBoard, string key, string token, string fields, string limit)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsLabelsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsLabelsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsLabelsByIdBoard");
            
    
            var path = "/boards/{idBoard}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsLabelsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsLabelsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsLabelsByIdBoardByIdLabel() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="idLabel">idLabel</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: color, idBoard, name or uses</param> 
        /// <returns></returns>            
        public void GetBoardsLabelsByIdBoardByIdLabel (string idBoard, string idLabel, string key, string token, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsLabelsByIdBoardByIdLabel");
            
            // verify the required parameter 'idLabel' is set
            if (idLabel == null) throw new ApiException(400, "Missing required parameter 'idLabel' when calling GetBoardsLabelsByIdBoardByIdLabel");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsLabelsByIdBoardByIdLabel");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsLabelsByIdBoardByIdLabel");
            
    
            var path = "/boards/{idBoard}/labels/{idLabel}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
path = path.Replace("{" + "idLabel" + "}", ApiClient.ParameterToString(idLabel));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsLabelsByIdBoardByIdLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsLabelsByIdBoardByIdLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsListsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="cards">One of: all, closed, none, open or visible</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="filter">One of: all, closed, none or open</param> 
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <returns></returns>            
        public void GetBoardsListsByIdBoard (string idBoard, string key, string token, string cards, string cardFields, string filter, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsListsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsListsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsListsByIdBoard");
            
    
            var path = "/boards/{idBoard}/lists";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cards != null) queryParams.Add("cards", ApiClient.ParameterToString(cards)); // query parameter
 if (cardFields != null) queryParams.Add("card_fields", ApiClient.ParameterToString(cardFields)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsListsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsListsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsListsByIdBoardByFilter() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsListsByIdBoardByFilter (string idBoard, string filter, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsListsByIdBoardByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetBoardsListsByIdBoardByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsListsByIdBoardByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsListsByIdBoardByFilter");
            
    
            var path = "/boards/{idBoard}/lists/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsListsByIdBoardByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsListsByIdBoardByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMembersByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: admins, all, none, normal or owners</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="activity">true or false ; works for premium organizations only.</param> 
        /// <returns></returns>            
        public void GetBoardsMembersByIdBoard (string idBoard, string key, string token, string filter, string fields, string activity)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMembersByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMembersByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMembersByIdBoard");
            
    
            var path = "/boards/{idBoard}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMembersByIdBoardByFilter() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsMembersByIdBoardByFilter (string idBoard, string filter, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMembersByIdBoardByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetBoardsMembersByIdBoardByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMembersByIdBoardByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMembersByIdBoardByFilter");
            
    
            var path = "/boards/{idBoard}/members/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersByIdBoardByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersByIdBoardByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMembersCardsByIdBoardByIdMember() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
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
        public void GetBoardsMembersCardsByIdBoardByIdMember (string idBoard, string idMember, string key, string token, string actions, string attachments, string attachmentFields, string members, string memberFields, string checkItemStates, string checklists, string board, string boardFields, string list, string listFields, string filter, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMembersCardsByIdBoardByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetBoardsMembersCardsByIdBoardByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMembersCardsByIdBoardByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMembersCardsByIdBoardByIdMember");
            
    
            var path = "/boards/{idBoard}/members/{idMember}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersCardsByIdBoardByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersCardsByIdBoardByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMembersInvitedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param> 
        /// <returns></returns>            
        public void GetBoardsMembersInvitedByIdBoard (string idBoard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMembersInvitedByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMembersInvitedByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMembersInvitedByIdBoard");
            
    
            var path = "/boards/{idBoard}/membersInvited";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersInvitedByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersInvitedByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMembersInvitedByIdBoardByField() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsMembersInvitedByIdBoardByField (string idBoard, string field, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMembersInvitedByIdBoardByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetBoardsMembersInvitedByIdBoardByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMembersInvitedByIdBoardByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMembersInvitedByIdBoardByField");
            
    
            var path = "/boards/{idBoard}/membersInvited/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersInvitedByIdBoardByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembersInvitedByIdBoardByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMembershipsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">all or a comma-separated list of: active, admin, deactivated, me or normal</param> 
        /// <param name="member"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetBoardsMembershipsByIdBoard (string idBoard, string key, string token, string filter, string member, string memberFields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMembershipsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMembershipsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMembershipsByIdBoard");
            
    
            var path = "/boards/{idBoard}/memberships";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembershipsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembershipsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMembershipsByIdBoardByIdMembership() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="idMembership">idMembership</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="member"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetBoardsMembershipsByIdBoardByIdMembership (string idBoard, string idMembership, string key, string token, string member, string memberFields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMembershipsByIdBoardByIdMembership");
            
            // verify the required parameter 'idMembership' is set
            if (idMembership == null) throw new ApiException(400, "Missing required parameter 'idMembership' when calling GetBoardsMembershipsByIdBoardByIdMembership");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMembershipsByIdBoardByIdMembership");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMembershipsByIdBoardByIdMembership");
            
    
            var path = "/boards/{idBoard}/memberships/{idMembership}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembershipsByIdBoardByIdMembership: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMembershipsByIdBoardByIdMembership: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsMyPrefsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsMyPrefsByIdBoard (string idBoard, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsMyPrefsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsMyPrefsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsMyPrefsByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMyPrefsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsMyPrefsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsOrganizationByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <returns></returns>            
        public void GetBoardsOrganizationByIdBoard (string idBoard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsOrganizationByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsOrganizationByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsOrganizationByIdBoard");
            
    
            var path = "/boards/{idBoard}/organization";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsOrganizationByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsOrganizationByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getBoardsOrganizationByIdBoardByField() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetBoardsOrganizationByIdBoardByField (string idBoard, string field, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling GetBoardsOrganizationByIdBoardByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetBoardsOrganizationByIdBoardByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetBoardsOrganizationByIdBoardByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetBoardsOrganizationByIdBoardByField");
            
    
            var path = "/boards/{idBoard}/organization/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsOrganizationByIdBoardByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBoardsOrganizationByIdBoardByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsByIdBoard (string idBoard, Boards body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsByIdBoard");
            
    
            var path = "/boards/{idBoard}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsClosedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Closed\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsClosedByIdBoard (string idBoard, BoardsClosed body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsClosedByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsClosedByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsClosedByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsClosedByIdBoard");
            
    
            var path = "/boards/{idBoard}/closed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsClosedByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsClosedByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsDescByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Desc\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsDescByIdBoard (string idBoard, BoardsDesc body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsDescByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsDescByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsDescByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsDescByIdBoard");
            
    
            var path = "/boards/{idBoard}/desc";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsDescByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsDescByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsIdOrganizationByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Id Organization\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsIdOrganizationByIdBoard (string idBoard, BoardsIdOrganization body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsIdOrganizationByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsIdOrganizationByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsIdOrganizationByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsIdOrganizationByIdBoard");
            
    
            var path = "/boards/{idBoard}/idOrganization";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsIdOrganizationByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsIdOrganizationByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsLabelNamesBlueByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Label Names Blue\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsLabelNamesBlueByIdBoard (string idBoard, LabelNamesBlue body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsLabelNamesBlueByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsLabelNamesBlueByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsLabelNamesBlueByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsLabelNamesBlueByIdBoard");
            
    
            var path = "/boards/{idBoard}/labelNames/blue";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesBlueByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesBlueByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsLabelNamesGreenByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Label Names Green\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsLabelNamesGreenByIdBoard (string idBoard, LabelNamesGreen body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsLabelNamesGreenByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsLabelNamesGreenByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsLabelNamesGreenByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsLabelNamesGreenByIdBoard");
            
    
            var path = "/boards/{idBoard}/labelNames/green";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesGreenByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesGreenByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsLabelNamesOrangeByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Label Names Orange\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsLabelNamesOrangeByIdBoard (string idBoard, LabelNamesOrange body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsLabelNamesOrangeByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsLabelNamesOrangeByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsLabelNamesOrangeByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsLabelNamesOrangeByIdBoard");
            
    
            var path = "/boards/{idBoard}/labelNames/orange";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesOrangeByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesOrangeByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsLabelNamesPurpleByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Label Names Purple\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsLabelNamesPurpleByIdBoard (string idBoard, LabelNamesPurple body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsLabelNamesPurpleByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsLabelNamesPurpleByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsLabelNamesPurpleByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsLabelNamesPurpleByIdBoard");
            
    
            var path = "/boards/{idBoard}/labelNames/purple";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesPurpleByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesPurpleByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsLabelNamesRedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Label Names Red\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsLabelNamesRedByIdBoard (string idBoard, LabelNamesRed body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsLabelNamesRedByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsLabelNamesRedByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsLabelNamesRedByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsLabelNamesRedByIdBoard");
            
    
            var path = "/boards/{idBoard}/labelNames/red";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesRedByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesRedByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsLabelNamesYellowByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Label Names Yellow\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsLabelNamesYellowByIdBoard (string idBoard, LabelNamesYellow body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsLabelNamesYellowByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsLabelNamesYellowByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsLabelNamesYellowByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsLabelNamesYellowByIdBoard");
            
    
            var path = "/boards/{idBoard}/labelNames/yellow";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesYellowByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsLabelNamesYellowByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMembersByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Members\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMembersByIdBoard (string idBoard, BoardsMembers body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMembersByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMembersByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMembersByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMembersByIdBoard");
            
    
            var path = "/boards/{idBoard}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMembersByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMembersByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMembersByIdBoardByIdMember() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="body">Attributes of \&quot;Boards Members\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMembersByIdBoardByIdMember (string idBoard, string idMember, BoardsMembers body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMembersByIdBoardByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateBoardsMembersByIdBoardByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMembersByIdBoardByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMembersByIdBoardByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMembersByIdBoardByIdMember");
            
    
            var path = "/boards/{idBoard}/members/{idMember}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMembersByIdBoardByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMembersByIdBoardByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMembershipsByIdBoardByIdMembership() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="idMembership">idMembership</param> 
        /// <param name="body">Attributes of \&quot;Boards Memberships\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMembershipsByIdBoardByIdMembership (string idBoard, string idMembership, BoardsMemberships body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMembershipsByIdBoardByIdMembership");
            
            // verify the required parameter 'idMembership' is set
            if (idMembership == null) throw new ApiException(400, "Missing required parameter 'idMembership' when calling UpdateBoardsMembershipsByIdBoardByIdMembership");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMembershipsByIdBoardByIdMembership");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMembershipsByIdBoardByIdMembership");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMembershipsByIdBoardByIdMembership");
            
    
            var path = "/boards/{idBoard}/memberships/{idMembership}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMembershipsByIdBoardByIdMembership: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMembershipsByIdBoardByIdMembership: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMyPrefsEmailPositionByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;My Prefs Email Position\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMyPrefsEmailPositionByIdBoard (string idBoard, MyPrefsEmailPosition body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMyPrefsEmailPositionByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMyPrefsEmailPositionByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMyPrefsEmailPositionByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMyPrefsEmailPositionByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs/emailPosition";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsEmailPositionByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsEmailPositionByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMyPrefsIdEmailListByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;My Prefs Id Email List\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMyPrefsIdEmailListByIdBoard (string idBoard, MyPrefsIdEmailList body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMyPrefsIdEmailListByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMyPrefsIdEmailListByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMyPrefsIdEmailListByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMyPrefsIdEmailListByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs/idEmailList";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsIdEmailListByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsIdEmailListByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMyPrefsShowListGuideByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;My Prefs Show List Guide\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMyPrefsShowListGuideByIdBoard (string idBoard, MyPrefsShowListGuide body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMyPrefsShowListGuideByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMyPrefsShowListGuideByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMyPrefsShowListGuideByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMyPrefsShowListGuideByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs/showListGuide";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowListGuideByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowListGuideByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarActivityByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar Activity\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMyPrefsShowSidebarActivityByIdBoard (string idBoard, MyPrefsShowSidebarActivity body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMyPrefsShowSidebarActivityByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMyPrefsShowSidebarActivityByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMyPrefsShowSidebarActivityByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMyPrefsShowSidebarActivityByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs/showSidebarActivity";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarActivityByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarActivityByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarBoardActionsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar Board Actions\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard (string idBoard, MyPrefsShowSidebarBoardActions body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs/showSidebarBoardActions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarBoardActionsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMyPrefsShowSidebarByIdBoard (string idBoard, MyPrefsShowSidebar body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMyPrefsShowSidebarByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMyPrefsShowSidebarByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMyPrefsShowSidebarByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMyPrefsShowSidebarByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs/showSidebar";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsMyPrefsShowSidebarMembersByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;My Prefs Show Sidebar Members\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsMyPrefsShowSidebarMembersByIdBoard (string idBoard, MyPrefsShowSidebarMembers body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsMyPrefsShowSidebarMembersByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsMyPrefsShowSidebarMembersByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsMyPrefsShowSidebarMembersByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsMyPrefsShowSidebarMembersByIdBoard");
            
    
            var path = "/boards/{idBoard}/myPrefs/showSidebarMembers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarMembersByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsMyPrefsShowSidebarMembersByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsNameByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsNameByIdBoard (string idBoard, BoardsName body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsNameByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsNameByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsNameByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsNameByIdBoard");
            
    
            var path = "/boards/{idBoard}/name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsNameByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsNameByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsBackgroundByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Background\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsBackgroundByIdBoard (string idBoard, PrefsBackground body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsBackgroundByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsBackgroundByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsBackgroundByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsBackgroundByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/background";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsBackgroundByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsBackgroundByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsCalendarFeedEnabledByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Calendar Feed Enabled\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsCalendarFeedEnabledByIdBoard (string idBoard, PrefsCalendarFeedEnabled body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsCalendarFeedEnabledByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsCalendarFeedEnabledByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsCalendarFeedEnabledByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsCalendarFeedEnabledByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/calendarFeedEnabled";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCalendarFeedEnabledByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCalendarFeedEnabledByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsCardAgingByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Card Aging\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsCardAgingByIdBoard (string idBoard, PrefsCardAging body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsCardAgingByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsCardAgingByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsCardAgingByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsCardAgingByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/cardAging";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCardAgingByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCardAgingByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsCardCoversByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Card Covers\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsCardCoversByIdBoard (string idBoard, PrefsCardCovers body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsCardCoversByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsCardCoversByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsCardCoversByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsCardCoversByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/cardCovers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCardCoversByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCardCoversByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsCommentsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Comments\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsCommentsByIdBoard (string idBoard, PrefsComments body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsCommentsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsCommentsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsCommentsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsCommentsByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCommentsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsCommentsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsInvitationsByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Invitations\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsInvitationsByIdBoard (string idBoard, PrefsInvitations body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsInvitationsByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsInvitationsByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsInvitationsByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsInvitationsByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/invitations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsInvitationsByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsInvitationsByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsPermissionLevelByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Permission Level\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsPermissionLevelByIdBoard (string idBoard, PrefsPermissionLevel body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsPermissionLevelByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsPermissionLevelByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsPermissionLevelByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsPermissionLevelByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/permissionLevel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsPermissionLevelByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsPermissionLevelByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsSelfJoinByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Self Join\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsSelfJoinByIdBoard (string idBoard, PrefsSelfJoin body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsSelfJoinByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsSelfJoinByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsSelfJoinByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsSelfJoinByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/selfJoin";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsSelfJoinByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsSelfJoinByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsPrefsVotingByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Prefs Voting\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsPrefsVotingByIdBoard (string idBoard, PrefsVoting body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsPrefsVotingByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsPrefsVotingByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsPrefsVotingByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsPrefsVotingByIdBoard");
            
    
            var path = "/boards/{idBoard}/prefs/voting";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsVotingByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsPrefsVotingByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateBoardsSubscribedByIdBoard() 
        /// </summary>
        /// <param name="idBoard">board_id</param> 
        /// <param name="body">Attributes of \&quot;Boards Subscribed\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateBoardsSubscribedByIdBoard (string idBoard, BoardsSubscribed body, string key, string token)
        {
            
            // verify the required parameter 'idBoard' is set
            if (idBoard == null) throw new ApiException(400, "Missing required parameter 'idBoard' when calling UpdateBoardsSubscribedByIdBoard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBoardsSubscribedByIdBoard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateBoardsSubscribedByIdBoard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateBoardsSubscribedByIdBoard");
            
    
            var path = "/boards/{idBoard}/subscribed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idBoard" + "}", ApiClient.ParameterToString(idBoard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsSubscribedByIdBoard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateBoardsSubscribedByIdBoard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
