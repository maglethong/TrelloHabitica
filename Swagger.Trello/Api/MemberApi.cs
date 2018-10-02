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
    public interface IMemberApi
    {
        /// <summary>
        /// addMembersAvatarByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Avatar\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersAvatarByIdMember (string idMember, MembersAvatar body, string key, string token);
        /// <summary>
        /// addMembersBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Board Backgrounds\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersBoardBackgroundsByIdMember (string idMember, MembersBoardBackgrounds body, string key, string token);
        /// <summary>
        /// addMembersBoardStarsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Board Stars\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersBoardStarsByIdMember (string idMember, MembersBoardStars body, string key, string token);
        /// <summary>
        /// addMembersCustomBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Custom Board Backgrounds\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersCustomBoardBackgroundsByIdMember (string idMember, MembersCustomBoardBackgrounds body, string key, string token);
        /// <summary>
        /// addMembersCustomEmojiByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Custom Emoji\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersCustomEmojiByIdMember (string idMember, MembersCustomEmoji body, string key, string token);
        /// <summary>
        /// addMembersCustomStickersByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Custom Stickers\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersCustomStickersByIdMember (string idMember, MembersCustomStickers body, string key, string token);
        /// <summary>
        /// addMembersOneTimeMessagesDismissedByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members One Time Messages Dismissed\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersOneTimeMessagesDismissedByIdMember (string idMember, MembersOneTimeMessagesDismissed body, string key, string token);
        /// <summary>
        /// addMembersSavedSearchesByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Saved Searches\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddMembersSavedSearchesByIdMember (string idMember, MembersSavedSearches body, string key, string token);
        /// <summary>
        /// deleteMembersBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardBackground">idBoardBackground</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token);
        /// <summary>
        /// deleteMembersBoardStarsByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardStar">idBoardStar</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteMembersBoardStarsByIdMemberByIdBoardStar (string idMember, string idBoardStar, string key, string token);
        /// <summary>
        /// deleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardBackground">idBoardBackground</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token);
        /// <summary>
        /// deleteMembersCustomStickersByIdMemberByIdCustomSticker() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idCustomSticker">idCustomSticker</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteMembersCustomStickersByIdMemberByIdCustomSticker (string idMember, string idCustomSticker, string key, string token);
        /// <summary>
        /// deleteMembersSavedSearchesByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idSavedSearch">idSavedSearch</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteMembersSavedSearchesByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, string key, string token);
        /// <summary>
        /// getMembersActionsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
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
        void GetMembersActionsByIdMember (string idMember, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields);
        /// <summary>
        /// getMembersBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: all, custom, default, none or premium</param>
        /// <returns></returns>
        void GetMembersBoardBackgroundsByIdMember (string idMember, string key, string token, string filter);
        /// <summary>
        /// getMembersBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardBackground">idBoardBackground</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: brightness, fullSizeUrl, scaled or tile</param>
        /// <returns></returns>
        void GetMembersBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token, string fields);
        /// <summary>
        /// getMembersBoardStarsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersBoardStarsByIdMember (string idMember, string key, string token);
        /// <summary>
        /// getMembersBoardStarsByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardStar">idBoardStar</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersBoardStarsByIdMemberByIdBoardStar (string idMember, string idBoardStar, string key, string token);
        /// <summary>
        /// getMembersBoardsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
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
        void GetMembersBoardsByIdMember (string idMember, string key, string token, string filter, string fields, string actions, string actionsEntities, string actionsLimit, string actionsFormat, string actionsSince, string actionFields, string memberships, string organization, string organizationFields, string lists);
        /// <summary>
        /// getMembersBoardsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersBoardsByIdMemberByFilter (string idMember, string filter, string key, string token);
        /// <summary>
        /// getMembersBoardsInvitedByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <returns></returns>
        void GetMembersBoardsInvitedByIdMember (string idMember, string key, string token, string fields);
        /// <summary>
        /// getMembersBoardsInvitedByIdMemberByField() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersBoardsInvitedByIdMemberByField (string idMember, string field, string key, string token);
        /// <summary>
        /// getMembersByIdMember() If you specify &#39;me&#39; as the username, this call will respond as if you had supplied the username associated with the supplied token
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="actionsEntities"> true or false</param>
        /// <param name="actionsDisplay"> true or false</param>
        /// <param name="actionsLimit">a number from 0 to 1000</param>
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="actionSince">A date, null or lastView</param>
        /// <param name="actionBefore">A date, or null</param>
        /// <param name="cards">One of: all, closed, none, open or visible</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="cardMembers"> true or false</param>
        /// <param name="cardMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="cardAttachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <param name="cardAttachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <param name="cardStickers"> true or false</param>
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
        /// <param name="boardMemberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param>
        /// <param name="boardOrganization"> true or false</param>
        /// <param name="boardOrganizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="boardsInvited">all or a comma-separated list of: closed, members, open, organization, pinned, public, starred or unpinned</param>
        /// <param name="boardsInvitedFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="boardStars"> true or false</param>
        /// <param name="savedSearches"> true or false</param>
        /// <param name="organizations">One of: all, members, none or public</param>
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="organizationPaidAccount"> true or false</param>
        /// <param name="organizationsInvited">One of: all, members, none or public</param>
        /// <param name="organizationsInvitedFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="notifications">all or a comma-separated list of: addAdminToBoard, addAdminToOrganization, addedAttachmentToCard, addedMemberToCard, addedToBoard, addedToCard, addedToOrganization, cardDueSoon, changeCard, closeBoard, commentCard, createdCard, declinedInvitationToBoard, declinedInvitationToOrganization, invitedToBoard, invitedToOrganization, makeAdminOfBoard, makeAdminOfOrganization, memberJoinedTrello, mentionedOnCard, removedFromBoard, removedFromCard, removedFromOrganization, removedMemberFromCard, unconfirmedInvitedToBoard, unconfirmedInvitedToOrganization or updateCheckItemStateOnCard</param>
        /// <param name="notificationsEntities"> true or false</param>
        /// <param name="notificationsDisplay"> true or false</param>
        /// <param name="notificationsLimit">a number from 1 to 1000</param>
        /// <param name="notificationFields">all or a comma-separated list of: data, date, idMemberCreator, type or unread</param>
        /// <param name="notificationMemberCreator"> true or false</param>
        /// <param name="notificationMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="notificationBefore">An id, or null</param>
        /// <param name="notificationSince">An id, or null</param>
        /// <param name="tokens">One of: all or none</param>
        /// <param name="paidAccount"> true or false</param>
        /// <param name="boardBackgrounds">One of: all, custom, default, none or premium</param>
        /// <param name="customBoardBackgrounds">One of: all or none</param>
        /// <param name="customStickers">One of: all or none</param>
        /// <param name="customEmoji">One of: all or none</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param>
        /// <returns></returns>
        void GetMembersByIdMember (string idMember, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string actionSince, string actionBefore, string cards, string cardFields, string cardMembers, string cardMemberFields, string cardAttachments, string cardAttachmentFields, string cardStickers, string boards, string boardFields, string boardActions, string boardActionsEntities, string boardActionsDisplay, string boardActionsFormat, string boardActionsSince, string boardActionsLimit, string boardActionFields, string boardLists, string boardMemberships, string boardOrganization, string boardOrganizationFields, string boardsInvited, string boardsInvitedFields, string boardStars, string savedSearches, string organizations, string organizationFields, string organizationPaidAccount, string organizationsInvited, string organizationsInvitedFields, string notifications, string notificationsEntities, string notificationsDisplay, string notificationsLimit, string notificationFields, string notificationMemberCreator, string notificationMemberCreatorFields, string notificationBefore, string notificationSince, string tokens, string paidAccount, string boardBackgrounds, string customBoardBackgrounds, string customStickers, string customEmoji, string fields);
        /// <summary>
        /// getMembersByIdMemberByField() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersByIdMemberByField (string idMember, string field, string key, string token);
        /// <summary>
        /// getMembersCardsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
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
        void GetMembersCardsByIdMember (string idMember, string key, string token, string actions, string attachments, string attachmentFields, string stickers, string members, string memberFields, string checkItemStates, string checklists, string limit, string since, string before, string filter, string fields);
        /// <summary>
        /// getMembersCardsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersCardsByIdMemberByFilter (string idMember, string filter, string key, string token);
        /// <summary>
        /// getMembersCustomBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: all or none</param>
        /// <returns></returns>
        void GetMembersCustomBoardBackgroundsByIdMember (string idMember, string key, string token, string filter);
        /// <summary>
        /// getMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardBackground">idBoardBackground</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: brightness, fullSizeUrl, scaled or tile</param>
        /// <returns></returns>
        void GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token, string fields);
        /// <summary>
        /// getMembersCustomEmojiByIdMember() This gets the list of all of the user’s uploaded emoji
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: all or none</param>
        /// <returns></returns>
        void GetMembersCustomEmojiByIdMember (string idMember, string key, string token, string filter);
        /// <summary>
        /// getMembersCustomEmojiByIdMemberByIdCustomEmoji() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idCustomEmoji">idCustomEmoji</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: name or url</param>
        /// <returns></returns>
        void GetMembersCustomEmojiByIdMemberByIdCustomEmoji (string idMember, string idCustomEmoji, string key, string token, string fields);
        /// <summary>
        /// getMembersCustomStickersByIdMember() This gets a list of all of the user’s uploaded stickers
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: all or none</param>
        /// <returns></returns>
        void GetMembersCustomStickersByIdMember (string idMember, string key, string token, string filter);
        /// <summary>
        /// getMembersCustomStickersByIdMemberByIdCustomSticker() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idCustomSticker">idCustomSticker</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: scaled or url</param>
        /// <returns></returns>
        void GetMembersCustomStickersByIdMemberByIdCustomSticker (string idMember, string idCustomSticker, string key, string token, string fields);
        /// <summary>
        /// getMembersDeltasByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="tags">A valid tag for subscribing</param>
        /// <param name="ixLastUpdate">a number from -1 to Infinity</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersDeltasByIdMember (string idMember, string tags, string ixLastUpdate, string key, string token);
        /// <summary>
        /// getMembersNotificationsByIdMember() You can only read the notifications for the member associated with the supplied token
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="entities"> true or false</param>
        /// <param name="display"> true or false</param>
        /// <param name="filter">all or a comma-separated list of: addAdminToBoard, addAdminToOrganization, addedAttachmentToCard, addedMemberToCard, addedToBoard, addedToCard, addedToOrganization, cardDueSoon, changeCard, closeBoard, commentCard, createdCard, declinedInvitationToBoard, declinedInvitationToOrganization, invitedToBoard, invitedToOrganization, makeAdminOfBoard, makeAdminOfOrganization, memberJoinedTrello, mentionedOnCard, removedFromBoard, removedFromCard, removedFromOrganization, removedMemberFromCard, unconfirmedInvitedToBoard, unconfirmedInvitedToOrganization or updateCheckItemStateOnCard</param>
        /// <param name="readFilter">One of: all, read or unread</param>
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator, type or unread</param>
        /// <param name="limit">a number from 1 to 1000</param>
        /// <param name="page">a number from 0 to 100</param>
        /// <param name="before">An id, or null</param>
        /// <param name="since">An id, or null</param>
        /// <param name="memberCreator"> true or false</param>
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetMembersNotificationsByIdMember (string idMember, string key, string token, string entities, string display, string filter, string readFilter, string fields, string limit, string page, string before, string since, string memberCreator, string memberCreatorFields);
        /// <summary>
        /// getMembersNotificationsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersNotificationsByIdMemberByFilter (string idMember, string filter, string key, string token);
        /// <summary>
        /// getMembersOrganizationsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: all, members, none or public</param>
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="paidAccount"> true or false</param>
        /// <returns></returns>
        void GetMembersOrganizationsByIdMember (string idMember, string key, string token, string filter, string fields, string paidAccount);
        /// <summary>
        /// getMembersOrganizationsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersOrganizationsByIdMemberByFilter (string idMember, string filter, string key, string token);
        /// <summary>
        /// getMembersOrganizationsInvitedByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <returns></returns>
        void GetMembersOrganizationsInvitedByIdMember (string idMember, string key, string token, string fields);
        /// <summary>
        /// getMembersOrganizationsInvitedByIdMemberByField() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersOrganizationsInvitedByIdMemberByField (string idMember, string field, string key, string token);
        /// <summary>
        /// getMembersSavedSearchesByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersSavedSearchesByIdMember (string idMember, string key, string token);
        /// <summary>
        /// getMembersSavedSearchesByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idSavedSearch">idSavedSearch</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetMembersSavedSearchesByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, string key, string token);
        /// <summary>
        /// getMembersTokensByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="filter">One of: all or none</param>
        /// <returns></returns>
        void GetMembersTokensByIdMember (string idMember, string key, string token, string filter);
        /// <summary>
        /// updateMembersAvatarSourceByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Avatar Source\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersAvatarSourceByIdMember (string idMember, MembersAvatarSource body, string key, string token);
        /// <summary>
        /// updateMembersBioByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Bio\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersBioByIdMember (string idMember, MembersBio body, string key, string token);
        /// <summary>
        /// updateMembersBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardBackground">idBoardBackground</param>
        /// <param name="body">Attributes of \&quot;Members Board Backgrounds\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, MembersBoardBackgrounds body, string key, string token);
        /// <summary>
        /// updateMembersBoardStarsByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardStar">idBoardStar</param>
        /// <param name="body">Attributes of \&quot;Members Board Stars\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersBoardStarsByIdMemberByIdBoardStar (string idMember, string idBoardStar, MembersBoardStars body, string key, string token);
        /// <summary>
        /// updateMembersBoardStarsIdBoardByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardStar">idBoardStar</param>
        /// <param name="body">Attributes of \&quot;Members Board Stars Id Board\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar (string idMember, string idBoardStar, MembersBoardStarsIdBoard body, string key, string token);
        /// <summary>
        /// updateMembersBoardStarsPosByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardStar">idBoardStar</param>
        /// <param name="body">Attributes of \&quot;Members Board Stars Pos\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersBoardStarsPosByIdMemberByIdBoardStar (string idMember, string idBoardStar, MembersBoardStarsPos body, string key, string token);
        /// <summary>
        /// updateMembersByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersByIdMember (string idMember, Members body, string key, string token);
        /// <summary>
        /// updateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idBoardBackground">idBoardBackground</param>
        /// <param name="body">Attributes of \&quot;Members Custom Board Backgrounds\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, MembersCustomBoardBackgrounds body, string key, string token);
        /// <summary>
        /// updateMembersFullNameByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Full Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersFullNameByIdMember (string idMember, MembersFullName body, string key, string token);
        /// <summary>
        /// updateMembersInitialsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Initials\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersInitialsByIdMember (string idMember, MembersInitials body, string key, string token);
        /// <summary>
        /// updateMembersPrefsColorBlindByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Prefs Color Blind\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersPrefsColorBlindByIdMember (string idMember, PrefsColorBlind body, string key, string token);
        /// <summary>
        /// updateMembersPrefsLocaleByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Prefs Locale\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersPrefsLocaleByIdMember (string idMember, PrefsLocale body, string key, string token);
        /// <summary>
        /// updateMembersPrefsMinutesBetweenSummariesByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Prefs Minutes Between Summaries\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersPrefsMinutesBetweenSummariesByIdMember (string idMember, PrefsMinutesBetweenSummaries body, string key, string token);
        /// <summary>
        /// updateMembersSavedSearchesByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idSavedSearch">idSavedSearch</param>
        /// <param name="body">Attributes of \&quot;Members Saved Searches\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersSavedSearchesByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearches body, string key, string token);
        /// <summary>
        /// updateMembersSavedSearchesNameByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idSavedSearch">idSavedSearch</param>
        /// <param name="body">Attributes of \&quot;Members Saved Searches Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearchesName body, string key, string token);
        /// <summary>
        /// updateMembersSavedSearchesPosByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idSavedSearch">idSavedSearch</param>
        /// <param name="body">Attributes of \&quot;Members Saved Searches Pos\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearchesPos body, string key, string token);
        /// <summary>
        /// updateMembersSavedSearchesQueryByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="idSavedSearch">idSavedSearch</param>
        /// <param name="body">Attributes of \&quot;Members Saved Searches Query\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearchesQuery body, string key, string token);
        /// <summary>
        /// updateMembersUsernameByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param>
        /// <param name="body">Attributes of \&quot;Members Username\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateMembersUsernameByIdMember (string idMember, MembersUsername body, string key, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MemberApi : IMemberApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MemberApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MemberApi(String basePath)
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
        /// addMembersAvatarByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Avatar\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersAvatarByIdMember (string idMember, MembersAvatar body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersAvatarByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersAvatarByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersAvatarByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersAvatarByIdMember");
            
    
            var path = "/members/{idMember}/avatar";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersAvatarByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersAvatarByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addMembersBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Board Backgrounds\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersBoardBackgroundsByIdMember (string idMember, MembersBoardBackgrounds body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersBoardBackgroundsByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersBoardBackgroundsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersBoardBackgroundsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersBoardBackgroundsByIdMember");
            
    
            var path = "/members/{idMember}/boardBackgrounds";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersBoardBackgroundsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersBoardBackgroundsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addMembersBoardStarsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Board Stars\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersBoardStarsByIdMember (string idMember, MembersBoardStars body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersBoardStarsByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersBoardStarsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersBoardStarsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersBoardStarsByIdMember");
            
    
            var path = "/members/{idMember}/boardStars";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersBoardStarsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersBoardStarsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addMembersCustomBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Custom Board Backgrounds\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersCustomBoardBackgroundsByIdMember (string idMember, MembersCustomBoardBackgrounds body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersCustomBoardBackgroundsByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersCustomBoardBackgroundsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersCustomBoardBackgroundsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersCustomBoardBackgroundsByIdMember");
            
    
            var path = "/members/{idMember}/customBoardBackgrounds";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersCustomBoardBackgroundsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersCustomBoardBackgroundsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addMembersCustomEmojiByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Custom Emoji\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersCustomEmojiByIdMember (string idMember, MembersCustomEmoji body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersCustomEmojiByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersCustomEmojiByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersCustomEmojiByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersCustomEmojiByIdMember");
            
    
            var path = "/members/{idMember}/customEmoji";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersCustomEmojiByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersCustomEmojiByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addMembersCustomStickersByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Custom Stickers\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersCustomStickersByIdMember (string idMember, MembersCustomStickers body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersCustomStickersByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersCustomStickersByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersCustomStickersByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersCustomStickersByIdMember");
            
    
            var path = "/members/{idMember}/customStickers";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersCustomStickersByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersCustomStickersByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addMembersOneTimeMessagesDismissedByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members One Time Messages Dismissed\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersOneTimeMessagesDismissedByIdMember (string idMember, MembersOneTimeMessagesDismissed body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersOneTimeMessagesDismissedByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersOneTimeMessagesDismissedByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersOneTimeMessagesDismissedByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersOneTimeMessagesDismissedByIdMember");
            
    
            var path = "/members/{idMember}/oneTimeMessagesDismissed";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersOneTimeMessagesDismissedByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersOneTimeMessagesDismissedByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addMembersSavedSearchesByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Saved Searches\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddMembersSavedSearchesByIdMember (string idMember, MembersSavedSearches body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling AddMembersSavedSearchesByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddMembersSavedSearchesByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddMembersSavedSearchesByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddMembersSavedSearchesByIdMember");
            
    
            var path = "/members/{idMember}/savedSearches";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersSavedSearchesByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddMembersSavedSearchesByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteMembersBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardBackground">idBoardBackground</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'idBoardBackground' is set
            if (idBoardBackground == null) throw new ApiException(400, "Missing required parameter 'idBoardBackground' when calling DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
    
            var path = "/members/{idMember}/boardBackgrounds/{idBoardBackground}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardBackground" + "}", ApiClient.ParameterToString(idBoardBackground));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersBoardBackgroundsByIdMemberByIdBoardBackground: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteMembersBoardStarsByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardStar">idBoardStar</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteMembersBoardStarsByIdMemberByIdBoardStar (string idMember, string idBoardStar, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'idBoardStar' is set
            if (idBoardStar == null) throw new ApiException(400, "Missing required parameter 'idBoardStar' when calling DeleteMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteMembersBoardStarsByIdMemberByIdBoardStar");
            
    
            var path = "/members/{idMember}/boardStars/{idBoardStar}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardStar" + "}", ApiClient.ParameterToString(idBoardStar));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersBoardStarsByIdMemberByIdBoardStar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersBoardStarsByIdMemberByIdBoardStar: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardBackground">idBoardBackground</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'idBoardBackground' is set
            if (idBoardBackground == null) throw new ApiException(400, "Missing required parameter 'idBoardBackground' when calling DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
    
            var path = "/members/{idMember}/customBoardBackgrounds/{idBoardBackground}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardBackground" + "}", ApiClient.ParameterToString(idBoardBackground));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteMembersCustomStickersByIdMemberByIdCustomSticker() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idCustomSticker">idCustomSticker</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteMembersCustomStickersByIdMemberByIdCustomSticker (string idMember, string idCustomSticker, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteMembersCustomStickersByIdMemberByIdCustomSticker");
            
            // verify the required parameter 'idCustomSticker' is set
            if (idCustomSticker == null) throw new ApiException(400, "Missing required parameter 'idCustomSticker' when calling DeleteMembersCustomStickersByIdMemberByIdCustomSticker");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteMembersCustomStickersByIdMemberByIdCustomSticker");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteMembersCustomStickersByIdMemberByIdCustomSticker");
            
    
            var path = "/members/{idMember}/customStickers/{idCustomSticker}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idCustomSticker" + "}", ApiClient.ParameterToString(idCustomSticker));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersCustomStickersByIdMemberByIdCustomSticker: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersCustomStickersByIdMemberByIdCustomSticker: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteMembersSavedSearchesByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idSavedSearch">idSavedSearch</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteMembersSavedSearchesByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'idSavedSearch' is set
            if (idSavedSearch == null) throw new ApiException(400, "Missing required parameter 'idSavedSearch' when calling DeleteMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteMembersSavedSearchesByIdMemberByIdSavedSearch");
            
    
            var path = "/members/{idMember}/savedSearches/{idSavedSearch}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idSavedSearch" + "}", ApiClient.ParameterToString(idSavedSearch));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersSavedSearchesByIdMemberByIdSavedSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteMembersSavedSearchesByIdMemberByIdSavedSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersActionsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
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
        public void GetMembersActionsByIdMember (string idMember, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersActionsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersActionsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersActionsByIdMember");
            
    
            var path = "/members/{idMember}/actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersActionsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersActionsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: all, custom, default, none or premium</param> 
        /// <returns></returns>            
        public void GetMembersBoardBackgroundsByIdMember (string idMember, string key, string token, string filter)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardBackgroundsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardBackgroundsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardBackgroundsByIdMember");
            
    
            var path = "/members/{idMember}/boardBackgrounds";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardBackgroundsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardBackgroundsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardBackground">idBoardBackground</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: brightness, fullSizeUrl, scaled or tile</param> 
        /// <returns></returns>            
        public void GetMembersBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'idBoardBackground' is set
            if (idBoardBackground == null) throw new ApiException(400, "Missing required parameter 'idBoardBackground' when calling GetMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
    
            var path = "/members/{idMember}/boardBackgrounds/{idBoardBackground}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardBackground" + "}", ApiClient.ParameterToString(idBoardBackground));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardBackgroundsByIdMemberByIdBoardBackground: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardBackgroundsByIdMemberByIdBoardBackground: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardStarsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersBoardStarsByIdMember (string idMember, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardStarsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardStarsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardStarsByIdMember");
            
    
            var path = "/members/{idMember}/boardStars";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardStarsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardStarsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardStarsByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardStar">idBoardStar</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersBoardStarsByIdMemberByIdBoardStar (string idMember, string idBoardStar, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'idBoardStar' is set
            if (idBoardStar == null) throw new ApiException(400, "Missing required parameter 'idBoardStar' when calling GetMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardStarsByIdMemberByIdBoardStar");
            
    
            var path = "/members/{idMember}/boardStars/{idBoardStar}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardStar" + "}", ApiClient.ParameterToString(idBoardStar));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardStarsByIdMemberByIdBoardStar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardStarsByIdMemberByIdBoardStar: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
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
        public void GetMembersBoardsByIdMember (string idMember, string key, string token, string filter, string fields, string actions, string actionsEntities, string actionsLimit, string actionsFormat, string actionsSince, string actionFields, string memberships, string organization, string organizationFields, string lists)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardsByIdMember");
            
    
            var path = "/members/{idMember}/boards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersBoardsByIdMemberByFilter (string idMember, string filter, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardsByIdMemberByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetMembersBoardsByIdMemberByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardsByIdMemberByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardsByIdMemberByFilter");
            
    
            var path = "/members/{idMember}/boards/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsByIdMemberByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsByIdMemberByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardsInvitedByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <returns></returns>            
        public void GetMembersBoardsInvitedByIdMember (string idMember, string key, string token, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardsInvitedByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardsInvitedByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardsInvitedByIdMember");
            
    
            var path = "/members/{idMember}/boardsInvited";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsInvitedByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsInvitedByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersBoardsInvitedByIdMemberByField() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersBoardsInvitedByIdMemberByField (string idMember, string field, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersBoardsInvitedByIdMemberByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetMembersBoardsInvitedByIdMemberByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersBoardsInvitedByIdMemberByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersBoardsInvitedByIdMemberByField");
            
    
            var path = "/members/{idMember}/boardsInvited/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsInvitedByIdMemberByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersBoardsInvitedByIdMemberByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersByIdMember() If you specify &#39;me&#39; as the username, this call will respond as if you had supplied the username associated with the supplied token
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="actionsEntities"> true or false</param> 
        /// <param name="actionsDisplay"> true or false</param> 
        /// <param name="actionsLimit">a number from 0 to 1000</param> 
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="actionSince">A date, null or lastView</param> 
        /// <param name="actionBefore">A date, or null</param> 
        /// <param name="cards">One of: all, closed, none, open or visible</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="cardMembers"> true or false</param> 
        /// <param name="cardMemberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="cardAttachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <param name="cardAttachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <param name="cardStickers"> true or false</param> 
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
        /// <param name="boardMemberships">all or a comma-separated list of: active, admin, deactivated, me or normal</param> 
        /// <param name="boardOrganization"> true or false</param> 
        /// <param name="boardOrganizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="boardsInvited">all or a comma-separated list of: closed, members, open, organization, pinned, public, starred or unpinned</param> 
        /// <param name="boardsInvitedFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="boardStars"> true or false</param> 
        /// <param name="savedSearches"> true or false</param> 
        /// <param name="organizations">One of: all, members, none or public</param> 
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="organizationPaidAccount"> true or false</param> 
        /// <param name="organizationsInvited">One of: all, members, none or public</param> 
        /// <param name="organizationsInvitedFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="notifications">all or a comma-separated list of: addAdminToBoard, addAdminToOrganization, addedAttachmentToCard, addedMemberToCard, addedToBoard, addedToCard, addedToOrganization, cardDueSoon, changeCard, closeBoard, commentCard, createdCard, declinedInvitationToBoard, declinedInvitationToOrganization, invitedToBoard, invitedToOrganization, makeAdminOfBoard, makeAdminOfOrganization, memberJoinedTrello, mentionedOnCard, removedFromBoard, removedFromCard, removedFromOrganization, removedMemberFromCard, unconfirmedInvitedToBoard, unconfirmedInvitedToOrganization or updateCheckItemStateOnCard</param> 
        /// <param name="notificationsEntities"> true or false</param> 
        /// <param name="notificationsDisplay"> true or false</param> 
        /// <param name="notificationsLimit">a number from 1 to 1000</param> 
        /// <param name="notificationFields">all or a comma-separated list of: data, date, idMemberCreator, type or unread</param> 
        /// <param name="notificationMemberCreator"> true or false</param> 
        /// <param name="notificationMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="notificationBefore">An id, or null</param> 
        /// <param name="notificationSince">An id, or null</param> 
        /// <param name="tokens">One of: all or none</param> 
        /// <param name="paidAccount"> true or false</param> 
        /// <param name="boardBackgrounds">One of: all, custom, default, none or premium</param> 
        /// <param name="customBoardBackgrounds">One of: all or none</param> 
        /// <param name="customStickers">One of: all or none</param> 
        /// <param name="customEmoji">One of: all or none</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param> 
        /// <returns></returns>            
        public void GetMembersByIdMember (string idMember, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string actionSince, string actionBefore, string cards, string cardFields, string cardMembers, string cardMemberFields, string cardAttachments, string cardAttachmentFields, string cardStickers, string boards, string boardFields, string boardActions, string boardActionsEntities, string boardActionsDisplay, string boardActionsFormat, string boardActionsSince, string boardActionsLimit, string boardActionFields, string boardLists, string boardMemberships, string boardOrganization, string boardOrganizationFields, string boardsInvited, string boardsInvitedFields, string boardStars, string savedSearches, string organizations, string organizationFields, string organizationPaidAccount, string organizationsInvited, string organizationsInvitedFields, string notifications, string notificationsEntities, string notificationsDisplay, string notificationsLimit, string notificationFields, string notificationMemberCreator, string notificationMemberCreatorFields, string notificationBefore, string notificationSince, string tokens, string paidAccount, string boardBackgrounds, string customBoardBackgrounds, string customStickers, string customEmoji, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersByIdMember");
            
    
            var path = "/members/{idMember}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
 if (actionSince != null) queryParams.Add("action_since", ApiClient.ParameterToString(actionSince)); // query parameter
 if (actionBefore != null) queryParams.Add("action_before", ApiClient.ParameterToString(actionBefore)); // query parameter
 if (cards != null) queryParams.Add("cards", ApiClient.ParameterToString(cards)); // query parameter
 if (cardFields != null) queryParams.Add("card_fields", ApiClient.ParameterToString(cardFields)); // query parameter
 if (cardMembers != null) queryParams.Add("card_members", ApiClient.ParameterToString(cardMembers)); // query parameter
 if (cardMemberFields != null) queryParams.Add("card_member_fields", ApiClient.ParameterToString(cardMemberFields)); // query parameter
 if (cardAttachments != null) queryParams.Add("card_attachments", ApiClient.ParameterToString(cardAttachments)); // query parameter
 if (cardAttachmentFields != null) queryParams.Add("card_attachment_fields", ApiClient.ParameterToString(cardAttachmentFields)); // query parameter
 if (cardStickers != null) queryParams.Add("card_stickers", ApiClient.ParameterToString(cardStickers)); // query parameter
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
 if (boardMemberships != null) queryParams.Add("board_memberships", ApiClient.ParameterToString(boardMemberships)); // query parameter
 if (boardOrganization != null) queryParams.Add("board_organization", ApiClient.ParameterToString(boardOrganization)); // query parameter
 if (boardOrganizationFields != null) queryParams.Add("board_organization_fields", ApiClient.ParameterToString(boardOrganizationFields)); // query parameter
 if (boardsInvited != null) queryParams.Add("boardsInvited", ApiClient.ParameterToString(boardsInvited)); // query parameter
 if (boardsInvitedFields != null) queryParams.Add("boardsInvited_fields", ApiClient.ParameterToString(boardsInvitedFields)); // query parameter
 if (boardStars != null) queryParams.Add("boardStars", ApiClient.ParameterToString(boardStars)); // query parameter
 if (savedSearches != null) queryParams.Add("savedSearches", ApiClient.ParameterToString(savedSearches)); // query parameter
 if (organizations != null) queryParams.Add("organizations", ApiClient.ParameterToString(organizations)); // query parameter
 if (organizationFields != null) queryParams.Add("organization_fields", ApiClient.ParameterToString(organizationFields)); // query parameter
 if (organizationPaidAccount != null) queryParams.Add("organization_paid_account", ApiClient.ParameterToString(organizationPaidAccount)); // query parameter
 if (organizationsInvited != null) queryParams.Add("organizationsInvited", ApiClient.ParameterToString(organizationsInvited)); // query parameter
 if (organizationsInvitedFields != null) queryParams.Add("organizationsInvited_fields", ApiClient.ParameterToString(organizationsInvitedFields)); // query parameter
 if (notifications != null) queryParams.Add("notifications", ApiClient.ParameterToString(notifications)); // query parameter
 if (notificationsEntities != null) queryParams.Add("notifications_entities", ApiClient.ParameterToString(notificationsEntities)); // query parameter
 if (notificationsDisplay != null) queryParams.Add("notifications_display", ApiClient.ParameterToString(notificationsDisplay)); // query parameter
 if (notificationsLimit != null) queryParams.Add("notifications_limit", ApiClient.ParameterToString(notificationsLimit)); // query parameter
 if (notificationFields != null) queryParams.Add("notification_fields", ApiClient.ParameterToString(notificationFields)); // query parameter
 if (notificationMemberCreator != null) queryParams.Add("notification_memberCreator", ApiClient.ParameterToString(notificationMemberCreator)); // query parameter
 if (notificationMemberCreatorFields != null) queryParams.Add("notification_memberCreator_fields", ApiClient.ParameterToString(notificationMemberCreatorFields)); // query parameter
 if (notificationBefore != null) queryParams.Add("notification_before", ApiClient.ParameterToString(notificationBefore)); // query parameter
 if (notificationSince != null) queryParams.Add("notification_since", ApiClient.ParameterToString(notificationSince)); // query parameter
 if (tokens != null) queryParams.Add("tokens", ApiClient.ParameterToString(tokens)); // query parameter
 if (paidAccount != null) queryParams.Add("paid_account", ApiClient.ParameterToString(paidAccount)); // query parameter
 if (boardBackgrounds != null) queryParams.Add("boardBackgrounds", ApiClient.ParameterToString(boardBackgrounds)); // query parameter
 if (customBoardBackgrounds != null) queryParams.Add("customBoardBackgrounds", ApiClient.ParameterToString(customBoardBackgrounds)); // query parameter
 if (customStickers != null) queryParams.Add("customStickers", ApiClient.ParameterToString(customStickers)); // query parameter
 if (customEmoji != null) queryParams.Add("customEmoji", ApiClient.ParameterToString(customEmoji)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersByIdMemberByField() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersByIdMemberByField (string idMember, string field, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersByIdMemberByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetMembersByIdMemberByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersByIdMemberByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersByIdMemberByField");
            
    
            var path = "/members/{idMember}/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersByIdMemberByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersByIdMemberByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCardsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
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
        public void GetMembersCardsByIdMember (string idMember, string key, string token, string actions, string attachments, string attachmentFields, string stickers, string members, string memberFields, string checkItemStates, string checklists, string limit, string since, string before, string filter, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCardsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCardsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCardsByIdMember");
            
    
            var path = "/members/{idMember}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCardsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCardsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCardsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersCardsByIdMemberByFilter (string idMember, string filter, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCardsByIdMemberByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetMembersCardsByIdMemberByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCardsByIdMemberByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCardsByIdMemberByFilter");
            
    
            var path = "/members/{idMember}/cards/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCardsByIdMemberByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCardsByIdMemberByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCustomBoardBackgroundsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: all or none</param> 
        /// <returns></returns>            
        public void GetMembersCustomBoardBackgroundsByIdMember (string idMember, string key, string token, string filter)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCustomBoardBackgroundsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCustomBoardBackgroundsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCustomBoardBackgroundsByIdMember");
            
    
            var path = "/members/{idMember}/customBoardBackgrounds";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomBoardBackgroundsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomBoardBackgroundsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardBackground">idBoardBackground</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: brightness, fullSizeUrl, scaled or tile</param> 
        /// <returns></returns>            
        public void GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, string key, string token, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'idBoardBackground' is set
            if (idBoardBackground == null) throw new ApiException(400, "Missing required parameter 'idBoardBackground' when calling GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
    
            var path = "/members/{idMember}/customBoardBackgrounds/{idBoardBackground}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardBackground" + "}", ApiClient.ParameterToString(idBoardBackground));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCustomEmojiByIdMember() This gets the list of all of the user’s uploaded emoji
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: all or none</param> 
        /// <returns></returns>            
        public void GetMembersCustomEmojiByIdMember (string idMember, string key, string token, string filter)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCustomEmojiByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCustomEmojiByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCustomEmojiByIdMember");
            
    
            var path = "/members/{idMember}/customEmoji";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomEmojiByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomEmojiByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCustomEmojiByIdMemberByIdCustomEmoji() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idCustomEmoji">idCustomEmoji</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: name or url</param> 
        /// <returns></returns>            
        public void GetMembersCustomEmojiByIdMemberByIdCustomEmoji (string idMember, string idCustomEmoji, string key, string token, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCustomEmojiByIdMemberByIdCustomEmoji");
            
            // verify the required parameter 'idCustomEmoji' is set
            if (idCustomEmoji == null) throw new ApiException(400, "Missing required parameter 'idCustomEmoji' when calling GetMembersCustomEmojiByIdMemberByIdCustomEmoji");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCustomEmojiByIdMemberByIdCustomEmoji");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCustomEmojiByIdMemberByIdCustomEmoji");
            
    
            var path = "/members/{idMember}/customEmoji/{idCustomEmoji}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idCustomEmoji" + "}", ApiClient.ParameterToString(idCustomEmoji));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomEmojiByIdMemberByIdCustomEmoji: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomEmojiByIdMemberByIdCustomEmoji: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCustomStickersByIdMember() This gets a list of all of the user’s uploaded stickers
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: all or none</param> 
        /// <returns></returns>            
        public void GetMembersCustomStickersByIdMember (string idMember, string key, string token, string filter)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCustomStickersByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCustomStickersByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCustomStickersByIdMember");
            
    
            var path = "/members/{idMember}/customStickers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomStickersByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomStickersByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersCustomStickersByIdMemberByIdCustomSticker() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idCustomSticker">idCustomSticker</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: scaled or url</param> 
        /// <returns></returns>            
        public void GetMembersCustomStickersByIdMemberByIdCustomSticker (string idMember, string idCustomSticker, string key, string token, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersCustomStickersByIdMemberByIdCustomSticker");
            
            // verify the required parameter 'idCustomSticker' is set
            if (idCustomSticker == null) throw new ApiException(400, "Missing required parameter 'idCustomSticker' when calling GetMembersCustomStickersByIdMemberByIdCustomSticker");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersCustomStickersByIdMemberByIdCustomSticker");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersCustomStickersByIdMemberByIdCustomSticker");
            
    
            var path = "/members/{idMember}/customStickers/{idCustomSticker}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idCustomSticker" + "}", ApiClient.ParameterToString(idCustomSticker));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomStickersByIdMemberByIdCustomSticker: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersCustomStickersByIdMemberByIdCustomSticker: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersDeltasByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="tags">A valid tag for subscribing</param> 
        /// <param name="ixLastUpdate">a number from -1 to Infinity</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersDeltasByIdMember (string idMember, string tags, string ixLastUpdate, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersDeltasByIdMember");
            
            // verify the required parameter 'tags' is set
            if (tags == null) throw new ApiException(400, "Missing required parameter 'tags' when calling GetMembersDeltasByIdMember");
            
            // verify the required parameter 'ixLastUpdate' is set
            if (ixLastUpdate == null) throw new ApiException(400, "Missing required parameter 'ixLastUpdate' when calling GetMembersDeltasByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersDeltasByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersDeltasByIdMember");
            
    
            var path = "/members/{idMember}/deltas";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersDeltasByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersDeltasByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersNotificationsByIdMember() You can only read the notifications for the member associated with the supplied token
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="entities"> true or false</param> 
        /// <param name="display"> true or false</param> 
        /// <param name="filter">all or a comma-separated list of: addAdminToBoard, addAdminToOrganization, addedAttachmentToCard, addedMemberToCard, addedToBoard, addedToCard, addedToOrganization, cardDueSoon, changeCard, closeBoard, commentCard, createdCard, declinedInvitationToBoard, declinedInvitationToOrganization, invitedToBoard, invitedToOrganization, makeAdminOfBoard, makeAdminOfOrganization, memberJoinedTrello, mentionedOnCard, removedFromBoard, removedFromCard, removedFromOrganization, removedMemberFromCard, unconfirmedInvitedToBoard, unconfirmedInvitedToOrganization or updateCheckItemStateOnCard</param> 
        /// <param name="readFilter">One of: all, read or unread</param> 
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator, type or unread</param> 
        /// <param name="limit">a number from 1 to 1000</param> 
        /// <param name="page">a number from 0 to 100</param> 
        /// <param name="before">An id, or null</param> 
        /// <param name="since">An id, or null</param> 
        /// <param name="memberCreator"> true or false</param> 
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetMembersNotificationsByIdMember (string idMember, string key, string token, string entities, string display, string filter, string readFilter, string fields, string limit, string page, string before, string since, string memberCreator, string memberCreatorFields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersNotificationsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersNotificationsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersNotificationsByIdMember");
            
    
            var path = "/members/{idMember}/notifications";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (entities != null) queryParams.Add("entities", ApiClient.ParameterToString(entities)); // query parameter
 if (display != null) queryParams.Add("display", ApiClient.ParameterToString(display)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (readFilter != null) queryParams.Add("read_filter", ApiClient.ParameterToString(readFilter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
 if (before != null) queryParams.Add("before", ApiClient.ParameterToString(before)); // query parameter
 if (since != null) queryParams.Add("since", ApiClient.ParameterToString(since)); // query parameter
 if (memberCreator != null) queryParams.Add("memberCreator", ApiClient.ParameterToString(memberCreator)); // query parameter
 if (memberCreatorFields != null) queryParams.Add("memberCreator_fields", ApiClient.ParameterToString(memberCreatorFields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersNotificationsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersNotificationsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersNotificationsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersNotificationsByIdMemberByFilter (string idMember, string filter, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersNotificationsByIdMemberByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetMembersNotificationsByIdMemberByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersNotificationsByIdMemberByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersNotificationsByIdMemberByFilter");
            
    
            var path = "/members/{idMember}/notifications/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersNotificationsByIdMemberByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersNotificationsByIdMemberByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersOrganizationsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: all, members, none or public</param> 
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="paidAccount"> true or false</param> 
        /// <returns></returns>            
        public void GetMembersOrganizationsByIdMember (string idMember, string key, string token, string filter, string fields, string paidAccount)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersOrganizationsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersOrganizationsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersOrganizationsByIdMember");
            
    
            var path = "/members/{idMember}/organizations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (paidAccount != null) queryParams.Add("paid_account", ApiClient.ParameterToString(paidAccount)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersOrganizationsByIdMemberByFilter() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersOrganizationsByIdMemberByFilter (string idMember, string filter, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersOrganizationsByIdMemberByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetMembersOrganizationsByIdMemberByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersOrganizationsByIdMemberByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersOrganizationsByIdMemberByFilter");
            
    
            var path = "/members/{idMember}/organizations/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsByIdMemberByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsByIdMemberByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersOrganizationsInvitedByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <returns></returns>            
        public void GetMembersOrganizationsInvitedByIdMember (string idMember, string key, string token, string fields)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersOrganizationsInvitedByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersOrganizationsInvitedByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersOrganizationsInvitedByIdMember");
            
    
            var path = "/members/{idMember}/organizationsInvited";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsInvitedByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsInvitedByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersOrganizationsInvitedByIdMemberByField() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersOrganizationsInvitedByIdMemberByField (string idMember, string field, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersOrganizationsInvitedByIdMemberByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetMembersOrganizationsInvitedByIdMemberByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersOrganizationsInvitedByIdMemberByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersOrganizationsInvitedByIdMemberByField");
            
    
            var path = "/members/{idMember}/organizationsInvited/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsInvitedByIdMemberByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersOrganizationsInvitedByIdMemberByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersSavedSearchesByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersSavedSearchesByIdMember (string idMember, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersSavedSearchesByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersSavedSearchesByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersSavedSearchesByIdMember");
            
    
            var path = "/members/{idMember}/savedSearches";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersSavedSearchesByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersSavedSearchesByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersSavedSearchesByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idSavedSearch">idSavedSearch</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetMembersSavedSearchesByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'idSavedSearch' is set
            if (idSavedSearch == null) throw new ApiException(400, "Missing required parameter 'idSavedSearch' when calling GetMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersSavedSearchesByIdMemberByIdSavedSearch");
            
    
            var path = "/members/{idMember}/savedSearches/{idSavedSearch}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idSavedSearch" + "}", ApiClient.ParameterToString(idSavedSearch));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersSavedSearchesByIdMemberByIdSavedSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersSavedSearchesByIdMemberByIdSavedSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getMembersTokensByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="filter">One of: all or none</param> 
        /// <returns></returns>            
        public void GetMembersTokensByIdMember (string idMember, string key, string token, string filter)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling GetMembersTokensByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetMembersTokensByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetMembersTokensByIdMember");
            
    
            var path = "/members/{idMember}/tokens";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersTokensByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetMembersTokensByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersAvatarSourceByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Avatar Source\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersAvatarSourceByIdMember (string idMember, MembersAvatarSource body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersAvatarSourceByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersAvatarSourceByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersAvatarSourceByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersAvatarSourceByIdMember");
            
    
            var path = "/members/{idMember}/avatarSource";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersAvatarSourceByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersAvatarSourceByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersBioByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Bio\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersBioByIdMember (string idMember, MembersBio body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersBioByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersBioByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersBioByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersBioByIdMember");
            
    
            var path = "/members/{idMember}/bio";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBioByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBioByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardBackground">idBoardBackground</param> 
        /// <param name="body">Attributes of \&quot;Members Board Backgrounds\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, MembersBoardBackgrounds body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'idBoardBackground' is set
            if (idBoardBackground == null) throw new ApiException(400, "Missing required parameter 'idBoardBackground' when calling UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground");
            
    
            var path = "/members/{idMember}/boardBackgrounds/{idBoardBackground}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardBackground" + "}", ApiClient.ParameterToString(idBoardBackground));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardBackgroundsByIdMemberByIdBoardBackground: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersBoardStarsByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardStar">idBoardStar</param> 
        /// <param name="body">Attributes of \&quot;Members Board Stars\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersBoardStarsByIdMemberByIdBoardStar (string idMember, string idBoardStar, MembersBoardStars body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'idBoardStar' is set
            if (idBoardStar == null) throw new ApiException(400, "Missing required parameter 'idBoardStar' when calling UpdateMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersBoardStarsByIdMemberByIdBoardStar");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersBoardStarsByIdMemberByIdBoardStar");
            
    
            var path = "/members/{idMember}/boardStars/{idBoardStar}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardStar" + "}", ApiClient.ParameterToString(idBoardStar));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardStarsByIdMemberByIdBoardStar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardStarsByIdMemberByIdBoardStar: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersBoardStarsIdBoardByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardStar">idBoardStar</param> 
        /// <param name="body">Attributes of \&quot;Members Board Stars Id Board\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar (string idMember, string idBoardStar, MembersBoardStarsIdBoard body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar");
            
            // verify the required parameter 'idBoardStar' is set
            if (idBoardStar == null) throw new ApiException(400, "Missing required parameter 'idBoardStar' when calling UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar");
            
    
            var path = "/members/{idMember}/boardStars/{idBoardStar}/idBoard";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardStar" + "}", ApiClient.ParameterToString(idBoardStar));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardStarsIdBoardByIdMemberByIdBoardStar: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersBoardStarsPosByIdMemberByIdBoardStar() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardStar">idBoardStar</param> 
        /// <param name="body">Attributes of \&quot;Members Board Stars Pos\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersBoardStarsPosByIdMemberByIdBoardStar (string idMember, string idBoardStar, MembersBoardStarsPos body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersBoardStarsPosByIdMemberByIdBoardStar");
            
            // verify the required parameter 'idBoardStar' is set
            if (idBoardStar == null) throw new ApiException(400, "Missing required parameter 'idBoardStar' when calling UpdateMembersBoardStarsPosByIdMemberByIdBoardStar");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersBoardStarsPosByIdMemberByIdBoardStar");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersBoardStarsPosByIdMemberByIdBoardStar");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersBoardStarsPosByIdMemberByIdBoardStar");
            
    
            var path = "/members/{idMember}/boardStars/{idBoardStar}/pos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardStar" + "}", ApiClient.ParameterToString(idBoardStar));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardStarsPosByIdMemberByIdBoardStar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersBoardStarsPosByIdMemberByIdBoardStar: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersByIdMember (string idMember, Members body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersByIdMember");
            
    
            var path = "/members/{idMember}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idBoardBackground">idBoardBackground</param> 
        /// <param name="body">Attributes of \&quot;Members Custom Board Backgrounds\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground (string idMember, string idBoardBackground, MembersCustomBoardBackgrounds body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'idBoardBackground' is set
            if (idBoardBackground == null) throw new ApiException(400, "Missing required parameter 'idBoardBackground' when calling UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground");
            
    
            var path = "/members/{idMember}/customBoardBackgrounds/{idBoardBackground}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idBoardBackground" + "}", ApiClient.ParameterToString(idBoardBackground));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersCustomBoardBackgroundsByIdMemberByIdBoardBackground: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersFullNameByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Full Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersFullNameByIdMember (string idMember, MembersFullName body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersFullNameByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersFullNameByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersFullNameByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersFullNameByIdMember");
            
    
            var path = "/members/{idMember}/fullName";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersFullNameByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersFullNameByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersInitialsByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Initials\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersInitialsByIdMember (string idMember, MembersInitials body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersInitialsByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersInitialsByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersInitialsByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersInitialsByIdMember");
            
    
            var path = "/members/{idMember}/initials";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersInitialsByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersInitialsByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersPrefsColorBlindByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Prefs Color Blind\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersPrefsColorBlindByIdMember (string idMember, PrefsColorBlind body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersPrefsColorBlindByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersPrefsColorBlindByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersPrefsColorBlindByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersPrefsColorBlindByIdMember");
            
    
            var path = "/members/{idMember}/prefs/colorBlind";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersPrefsColorBlindByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersPrefsColorBlindByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersPrefsLocaleByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Prefs Locale\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersPrefsLocaleByIdMember (string idMember, PrefsLocale body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersPrefsLocaleByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersPrefsLocaleByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersPrefsLocaleByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersPrefsLocaleByIdMember");
            
    
            var path = "/members/{idMember}/prefs/locale";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersPrefsLocaleByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersPrefsLocaleByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersPrefsMinutesBetweenSummariesByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Prefs Minutes Between Summaries\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersPrefsMinutesBetweenSummariesByIdMember (string idMember, PrefsMinutesBetweenSummaries body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersPrefsMinutesBetweenSummariesByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersPrefsMinutesBetweenSummariesByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersPrefsMinutesBetweenSummariesByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersPrefsMinutesBetweenSummariesByIdMember");
            
    
            var path = "/members/{idMember}/prefs/minutesBetweenSummaries";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersPrefsMinutesBetweenSummariesByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersPrefsMinutesBetweenSummariesByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersSavedSearchesByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idSavedSearch">idSavedSearch</param> 
        /// <param name="body">Attributes of \&quot;Members Saved Searches\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersSavedSearchesByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearches body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'idSavedSearch' is set
            if (idSavedSearch == null) throw new ApiException(400, "Missing required parameter 'idSavedSearch' when calling UpdateMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersSavedSearchesByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersSavedSearchesByIdMemberByIdSavedSearch");
            
    
            var path = "/members/{idMember}/savedSearches/{idSavedSearch}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idSavedSearch" + "}", ApiClient.ParameterToString(idSavedSearch));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesByIdMemberByIdSavedSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesByIdMemberByIdSavedSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersSavedSearchesNameByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idSavedSearch">idSavedSearch</param> 
        /// <param name="body">Attributes of \&quot;Members Saved Searches Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearchesName body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'idSavedSearch' is set
            if (idSavedSearch == null) throw new ApiException(400, "Missing required parameter 'idSavedSearch' when calling UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch");
            
    
            var path = "/members/{idMember}/savedSearches/{idSavedSearch}/name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idSavedSearch" + "}", ApiClient.ParameterToString(idSavedSearch));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesNameByIdMemberByIdSavedSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersSavedSearchesPosByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idSavedSearch">idSavedSearch</param> 
        /// <param name="body">Attributes of \&quot;Members Saved Searches Pos\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearchesPos body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'idSavedSearch' is set
            if (idSavedSearch == null) throw new ApiException(400, "Missing required parameter 'idSavedSearch' when calling UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch");
            
    
            var path = "/members/{idMember}/savedSearches/{idSavedSearch}/pos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idSavedSearch" + "}", ApiClient.ParameterToString(idSavedSearch));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesPosByIdMemberByIdSavedSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersSavedSearchesQueryByIdMemberByIdSavedSearch() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="idSavedSearch">idSavedSearch</param> 
        /// <param name="body">Attributes of \&quot;Members Saved Searches Query\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch (string idMember, string idSavedSearch, MembersSavedSearchesQuery body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'idSavedSearch' is set
            if (idSavedSearch == null) throw new ApiException(400, "Missing required parameter 'idSavedSearch' when calling UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch");
            
    
            var path = "/members/{idMember}/savedSearches/{idSavedSearch}/query";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idMember" + "}", ApiClient.ParameterToString(idMember));
path = path.Replace("{" + "idSavedSearch" + "}", ApiClient.ParameterToString(idSavedSearch));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersSavedSearchesQueryByIdMemberByIdSavedSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateMembersUsernameByIdMember() 
        /// </summary>
        /// <param name="idMember">idMember or username</param> 
        /// <param name="body">Attributes of \&quot;Members Username\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateMembersUsernameByIdMember (string idMember, MembersUsername body, string key, string token)
        {
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling UpdateMembersUsernameByIdMember");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateMembersUsernameByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateMembersUsernameByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateMembersUsernameByIdMember");
            
    
            var path = "/members/{idMember}/username";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersUsernameByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateMembersUsernameByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
