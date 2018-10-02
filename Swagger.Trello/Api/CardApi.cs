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
    public interface ICardApi
    {
        /// <summary>
        /// addCards() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Cards\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCards (Cards body, string key, string token);
        /// <summary>
        /// addCardsActionsCommentsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Actions Comments\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsActionsCommentsByIdCard (string idCard, ActionsComments body, string key, string token);
        /// <summary>
        /// addCardsAttachmentsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Attachments\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsAttachmentsByIdCard (string idCard, CardsAttachments body, string key, string token);
        /// <summary>
        /// addCardsChecklistCheckItemByIdCardByIdChecklist() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklist">idChecklist</param>
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsChecklistCheckItemByIdCardByIdChecklist (string idCard, string idChecklist, CardsChecklistCheckItem body, string key, string token);
        /// <summary>
        /// addCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklist">idChecklist</param>
        /// <param name="idCheckItem">idCheckItem</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, string key, string token);
        /// <summary>
        /// addCardsChecklistsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Checklists\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsChecklistsByIdCard (string idCard, CardsChecklists body, string key, string token);
        /// <summary>
        /// addCardsIdLabelsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Id Labels\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsIdLabelsByIdCard (string idCard, CardsIdLabels body, string key, string token);
        /// <summary>
        /// addCardsIdMembersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Id Members\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsIdMembersByIdCard (string idCard, CardsIdMembers body, string key, string token);
        /// <summary>
        /// addCardsLabelsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Labels\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsLabelsByIdCard (string idCard, CardsLabels body, string key, string token);
        /// <summary>
        /// addCardsMarkAssociatedNotificationsReadByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsMarkAssociatedNotificationsReadByIdCard (string idCard, string key, string token);
        /// <summary>
        /// addCardsMembersVotedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Members Voted\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsMembersVotedByIdCard (string idCard, CardsMembersVoted body, string key, string token);
        /// <summary>
        /// addCardsStickersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Stickers\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddCardsStickersByIdCard (string idCard, CardsStickers body, string key, string token);
        /// <summary>
        /// deleteCardsActionsCommentsByIdCardByIdAction() This can only be done by the original author of the comment, or someone with higher permissions than the original author.
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsActionsCommentsByIdCardByIdAction (string idCard, string idAction, string key, string token);
        /// <summary>
        /// deleteCardsAttachmentsByIdCardByIdAttachment() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idAttachment">idAttachment</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsAttachmentsByIdCardByIdAttachment (string idCard, string idAttachment, string key, string token);
        /// <summary>
        /// deleteCardsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsByIdCard (string idCard, string key, string token);
        /// <summary>
        /// deleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklist">idChecklist</param>
        /// <param name="idCheckItem">idCheckItem</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, string key, string token);
        /// <summary>
        /// deleteCardsChecklistsByIdCardByIdChecklist() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklist">idChecklist</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsChecklistsByIdCardByIdChecklist (string idCard, string idChecklist, string key, string token);
        /// <summary>
        /// deleteCardsIdLabelsByIdCardByIdLabel() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idLabel">idLabel</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsIdLabelsByIdCardByIdLabel (string idCard, string idLabel, string key, string token);
        /// <summary>
        /// deleteCardsIdMembersByIdCardByIdMember() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idMember">idMember</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsIdMembersByIdCardByIdMember (string idCard, string idMember, string key, string token);
        /// <summary>
        /// deleteCardsLabelsByIdCardByColor() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="color">color</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsLabelsByIdCardByColor (string idCard, string color, string key, string token);
        /// <summary>
        /// deleteCardsMembersVotedByIdCardByIdMember() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idMember">idMember</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsMembersVotedByIdCardByIdMember (string idCard, string idMember, string key, string token);
        /// <summary>
        /// deleteCardsStickersByIdCardByIdSticker() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idSticker">idSticker</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteCardsStickersByIdCardByIdSticker (string idCard, string idSticker, string key, string token);
        /// <summary>
        /// getCardsActionsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
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
        void GetCardsActionsByIdCard (string idCard, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields);
        /// <summary>
        /// getCardsAttachmentsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <param name="filter">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <returns></returns>
        void GetCardsAttachmentsByIdCard (string idCard, string key, string token, string fields, string filter);
        /// <summary>
        /// getCardsAttachmentsByIdCardByIdAttachment() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idAttachment">idAttachment</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <returns></returns>
        void GetCardsAttachmentsByIdCardByIdAttachment (string idCard, string idAttachment, string key, string token, string fields);
        /// <summary>
        /// getCardsBoardByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <returns></returns>
        void GetCardsBoardByIdCard (string idCard, string key, string token, string fields);
        /// <summary>
        /// getCardsBoardByIdCardByField() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetCardsBoardByIdCardByField (string idCard, string field, string key, string token);
        /// <summary>
        /// getCardsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param>
        /// <param name="actionsEntities"> true or false</param>
        /// <param name="actionsDisplay"> true or false</param>
        /// <param name="actionsLimit">a number from 0 to 1000</param>
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="actionMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param>
        /// <param name="members"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="membersVoted"> true or false</param>
        /// <param name="memberVotedFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="checkItemStates"> true or false</param>
        /// <param name="checkItemStateFields">all or a comma-separated list of: idCheckItem or state</param>
        /// <param name="checklists">One of: all or none</param>
        /// <param name="checklistFields">all or a comma-separated list of: idBoard, idCard, name or pos</param>
        /// <param name="board"> true or false</param>
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="list"> true or false</param>
        /// <param name="listFields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <param name="stickers"> true or false</param>
        /// <param name="stickerFields">all or a comma-separated list of: image, imageScaled, imageUrl, left, rotate, top or zIndex</param>
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <returns></returns>
        void GetCardsByIdCard (string idCard, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string actionMemberCreatorFields, string attachments, string attachmentFields, string members, string memberFields, string membersVoted, string memberVotedFields, string checkItemStates, string checkItemStateFields, string checklists, string checklistFields, string board, string boardFields, string list, string listFields, string stickers, string stickerFields, string fields);
        /// <summary>
        /// getCardsByIdCardByField() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetCardsByIdCardByField (string idCard, string field, string key, string token);
        /// <summary>
        /// getCardsCheckItemStatesByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: idCheckItem or state</param>
        /// <returns></returns>
        void GetCardsCheckItemStatesByIdCard (string idCard, string key, string token, string fields);
        /// <summary>
        /// getCardsChecklistsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="cards">One of: all, closed, none, open or visible</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="checkItems">One of: all or none</param>
        /// <param name="checkItemFields">all or a comma-separated list of: name, nameData, pos, state or type</param>
        /// <param name="filter">One of: all or none</param>
        /// <param name="fields">all or a comma-separated list of: idBoard, idCard, name or pos</param>
        /// <returns></returns>
        void GetCardsChecklistsByIdCard (string idCard, string key, string token, string cards, string cardFields, string checkItems, string checkItemFields, string filter, string fields);
        /// <summary>
        /// getCardsListByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <returns></returns>
        void GetCardsListByIdCard (string idCard, string key, string token, string fields);
        /// <summary>
        /// getCardsListByIdCardByField() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetCardsListByIdCardByField (string idCard, string field, string key, string token);
        /// <summary>
        /// getCardsMembersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetCardsMembersByIdCard (string idCard, string key, string token, string fields);
        /// <summary>
        /// getCardsMembersVotedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetCardsMembersVotedByIdCard (string idCard, string key, string token, string fields);
        /// <summary>
        /// getCardsStickersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: image, imageScaled, imageUrl, left, rotate, top or zIndex</param>
        /// <returns></returns>
        void GetCardsStickersByIdCard (string idCard, string key, string token, string fields);
        /// <summary>
        /// getCardsStickersByIdCardByIdSticker() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idSticker">idSticker</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: image, imageScaled, imageUrl, left, rotate, top or zIndex</param>
        /// <returns></returns>
        void GetCardsStickersByIdCardByIdSticker (string idCard, string idSticker, string key, string token, string fields);
        /// <summary>
        /// updateCardsActionsCommentsByIdCardByIdAction() This can only be done by the original author of the comment.
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idAction">idAction</param>
        /// <param name="body">Attributes of \&quot;Cards Actions Comments\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsActionsCommentsByIdCardByIdAction (string idCard, string idAction, CardsActionsComments body, string key, string token);
        /// <summary>
        /// updateCardsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsByIdCard (string idCard, Cards body, string key, string token);
        /// <summary>
        /// updateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklistCurrent">idChecklistCurrent</param>
        /// <param name="idCheckItem">idCheckItem</param>
        /// <param name="body">Attributes of \&quot;Cards Checklist Id Checklist Current Check Item\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem (string idCard, string idChecklistCurrent, string idCheckItem, CardsChecklistIdChecklistCurrentCheckItem body, string key, string token);
        /// <summary>
        /// updateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklist">idChecklist</param>
        /// <param name="idCheckItem">idCheckItem</param>
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, CardsChecklistCheckItemName body, string key, string token);
        /// <summary>
        /// updateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklist">idChecklist</param>
        /// <param name="idCheckItem">idCheckItem</param>
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item Pos\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, CardsChecklistCheckItemPos body, string key, string token);
        /// <summary>
        /// updateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idChecklist">idChecklist</param>
        /// <param name="idCheckItem">idCheckItem</param>
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item State\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, CardsChecklistCheckItemState body, string key, string token);
        /// <summary>
        /// updateCardsClosedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Closed\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsClosedByIdCard (string idCard, CardsClosed body, string key, string token);
        /// <summary>
        /// updateCardsDescByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Desc\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsDescByIdCard (string idCard, CardsDesc body, string key, string token);
        /// <summary>
        /// updateCardsDueByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Due\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsDueByIdCard (string idCard, CardsDue body, string key, string token);
        /// <summary>
        /// updateCardsIdAttachmentCoverByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Id Attachment Cover\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsIdAttachmentCoverByIdCard (string idCard, CardsIdAttachmentCover body, string key, string token);
        /// <summary>
        /// updateCardsIdBoardByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Id Board\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsIdBoardByIdCard (string idCard, CardsIdBoard body, string key, string token);
        /// <summary>
        /// updateCardsIdListByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Id List\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsIdListByIdCard (string idCard, CardsIdList body, string key, string token);
        /// <summary>
        /// updateCardsIdMembersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Id Members\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsIdMembersByIdCard (string idCard, CardsIdMembers body, string key, string token);
        /// <summary>
        /// updateCardsLabelsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Labels\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsLabelsByIdCard (string idCard, CardsLabels body, string key, string token);
        /// <summary>
        /// updateCardsNameByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsNameByIdCard (string idCard, CardsName body, string key, string token);
        /// <summary>
        /// updateCardsPosByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Pos\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsPosByIdCard (string idCard, CardsPos body, string key, string token);
        /// <summary>
        /// updateCardsStickersByIdCardByIdSticker() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="idSticker">idSticker</param>
        /// <param name="body">Attributes of \&quot;Cards Stickers\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsStickersByIdCardByIdSticker (string idCard, string idSticker, CardsStickers body, string key, string token);
        /// <summary>
        /// updateCardsSubscribedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param>
        /// <param name="body">Attributes of \&quot;Cards Subscribed\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateCardsSubscribedByIdCard (string idCard, CardsSubscribed body, string key, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CardApi : ICardApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CardApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CardApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CardApi(String basePath)
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
        /// addCards() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Cards\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCards (Cards body, string key, string token)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCards");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCards");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCards");
            
    
            var path = "/cards";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCards: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCards: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsActionsCommentsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Actions Comments\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsActionsCommentsByIdCard (string idCard, ActionsComments body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsActionsCommentsByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsActionsCommentsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsActionsCommentsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsActionsCommentsByIdCard");
            
    
            var path = "/cards/{idCard}/actions/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsActionsCommentsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsActionsCommentsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsAttachmentsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Attachments\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsAttachmentsByIdCard (string idCard, CardsAttachments body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsAttachmentsByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsAttachmentsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsAttachmentsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsAttachmentsByIdCard");
            
    
            var path = "/cards/{idCard}/attachments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsAttachmentsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsAttachmentsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsChecklistCheckItemByIdCardByIdChecklist() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklist">idChecklist</param> 
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsChecklistCheckItemByIdCardByIdChecklist (string idCard, string idChecklist, CardsChecklistCheckItem body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsChecklistCheckItemByIdCardByIdChecklist");
            
            // verify the required parameter 'idChecklist' is set
            if (idChecklist == null) throw new ApiException(400, "Missing required parameter 'idChecklist' when calling AddCardsChecklistCheckItemByIdCardByIdChecklist");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsChecklistCheckItemByIdCardByIdChecklist");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsChecklistCheckItemByIdCardByIdChecklist");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsChecklistCheckItemByIdCardByIdChecklist");
            
    
            var path = "/cards/{idCard}/checklist/{idChecklist}/checkItem";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklist" + "}", ApiClient.ParameterToString(idChecklist));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsChecklistCheckItemByIdCardByIdChecklist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsChecklistCheckItemByIdCardByIdChecklist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklist">idChecklist</param> 
        /// <param name="idCheckItem">idCheckItem</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idChecklist' is set
            if (idChecklist == null) throw new ApiException(400, "Missing required parameter 'idChecklist' when calling AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idCheckItem' is set
            if (idCheckItem == null) throw new ApiException(400, "Missing required parameter 'idCheckItem' when calling AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem");
            
    
            var path = "/cards/{idCard}/checklist/{idChecklist}/checkItem/{idCheckItem}/convertToCard";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklist" + "}", ApiClient.ParameterToString(idChecklist));
path = path.Replace("{" + "idCheckItem" + "}", ApiClient.ParameterToString(idCheckItem));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsChecklistCheckItemConvertToCardByIdCardByIdChecklistByIdCheckItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsChecklistsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Checklists\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsChecklistsByIdCard (string idCard, CardsChecklists body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsChecklistsByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsChecklistsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsChecklistsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsChecklistsByIdCard");
            
    
            var path = "/cards/{idCard}/checklists";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsChecklistsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsChecklistsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsIdLabelsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Id Labels\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsIdLabelsByIdCard (string idCard, CardsIdLabels body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsIdLabelsByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsIdLabelsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsIdLabelsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsIdLabelsByIdCard");
            
    
            var path = "/cards/{idCard}/idLabels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsIdLabelsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsIdLabelsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsIdMembersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Id Members\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsIdMembersByIdCard (string idCard, CardsIdMembers body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsIdMembersByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsIdMembersByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsIdMembersByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsIdMembersByIdCard");
            
    
            var path = "/cards/{idCard}/idMembers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsIdMembersByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsIdMembersByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsLabelsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Labels\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsLabelsByIdCard (string idCard, CardsLabels body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsLabelsByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsLabelsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsLabelsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsLabelsByIdCard");
            
    
            var path = "/cards/{idCard}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsLabelsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsLabelsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsMarkAssociatedNotificationsReadByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsMarkAssociatedNotificationsReadByIdCard (string idCard, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsMarkAssociatedNotificationsReadByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsMarkAssociatedNotificationsReadByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsMarkAssociatedNotificationsReadByIdCard");
            
    
            var path = "/cards/{idCard}/markAssociatedNotificationsRead";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsMarkAssociatedNotificationsReadByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsMarkAssociatedNotificationsReadByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsMembersVotedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Members Voted\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsMembersVotedByIdCard (string idCard, CardsMembersVoted body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsMembersVotedByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsMembersVotedByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsMembersVotedByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsMembersVotedByIdCard");
            
    
            var path = "/cards/{idCard}/membersVoted";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsMembersVotedByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsMembersVotedByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addCardsStickersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Stickers\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddCardsStickersByIdCard (string idCard, CardsStickers body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling AddCardsStickersByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddCardsStickersByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddCardsStickersByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddCardsStickersByIdCard");
            
    
            var path = "/cards/{idCard}/stickers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsStickersByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCardsStickersByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsActionsCommentsByIdCardByIdAction() This can only be done by the original author of the comment, or someone with higher permissions than the original author.
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsActionsCommentsByIdCardByIdAction (string idCard, string idAction, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsActionsCommentsByIdCardByIdAction");
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling DeleteCardsActionsCommentsByIdCardByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsActionsCommentsByIdCardByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsActionsCommentsByIdCardByIdAction");
            
    
            var path = "/cards/{idCard}/actions/{idAction}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsActionsCommentsByIdCardByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsActionsCommentsByIdCardByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsAttachmentsByIdCardByIdAttachment() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idAttachment">idAttachment</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsAttachmentsByIdCardByIdAttachment (string idCard, string idAttachment, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsAttachmentsByIdCardByIdAttachment");
            
            // verify the required parameter 'idAttachment' is set
            if (idAttachment == null) throw new ApiException(400, "Missing required parameter 'idAttachment' when calling DeleteCardsAttachmentsByIdCardByIdAttachment");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsAttachmentsByIdCardByIdAttachment");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsAttachmentsByIdCardByIdAttachment");
            
    
            var path = "/cards/{idCard}/attachments/{idAttachment}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idAttachment" + "}", ApiClient.ParameterToString(idAttachment));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsAttachmentsByIdCardByIdAttachment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsAttachmentsByIdCardByIdAttachment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsByIdCard (string idCard, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsByIdCard");
            
    
            var path = "/cards/{idCard}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklist">idChecklist</param> 
        /// <param name="idCheckItem">idCheckItem</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idChecklist' is set
            if (idChecklist == null) throw new ApiException(400, "Missing required parameter 'idChecklist' when calling DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idCheckItem' is set
            if (idCheckItem == null) throw new ApiException(400, "Missing required parameter 'idCheckItem' when calling DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem");
            
    
            var path = "/cards/{idCard}/checklist/{idChecklist}/checkItem/{idCheckItem}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklist" + "}", ApiClient.ParameterToString(idChecklist));
path = path.Replace("{" + "idCheckItem" + "}", ApiClient.ParameterToString(idCheckItem));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsChecklistCheckItemByIdCardByIdChecklistByIdCheckItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsChecklistsByIdCardByIdChecklist() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklist">idChecklist</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsChecklistsByIdCardByIdChecklist (string idCard, string idChecklist, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsChecklistsByIdCardByIdChecklist");
            
            // verify the required parameter 'idChecklist' is set
            if (idChecklist == null) throw new ApiException(400, "Missing required parameter 'idChecklist' when calling DeleteCardsChecklistsByIdCardByIdChecklist");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsChecklistsByIdCardByIdChecklist");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsChecklistsByIdCardByIdChecklist");
            
    
            var path = "/cards/{idCard}/checklists/{idChecklist}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklist" + "}", ApiClient.ParameterToString(idChecklist));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsChecklistsByIdCardByIdChecklist: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsChecklistsByIdCardByIdChecklist: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsIdLabelsByIdCardByIdLabel() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idLabel">idLabel</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsIdLabelsByIdCardByIdLabel (string idCard, string idLabel, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsIdLabelsByIdCardByIdLabel");
            
            // verify the required parameter 'idLabel' is set
            if (idLabel == null) throw new ApiException(400, "Missing required parameter 'idLabel' when calling DeleteCardsIdLabelsByIdCardByIdLabel");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsIdLabelsByIdCardByIdLabel");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsIdLabelsByIdCardByIdLabel");
            
    
            var path = "/cards/{idCard}/idLabels/{idLabel}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idLabel" + "}", ApiClient.ParameterToString(idLabel));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsIdLabelsByIdCardByIdLabel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsIdLabelsByIdCardByIdLabel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsIdMembersByIdCardByIdMember() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsIdMembersByIdCardByIdMember (string idCard, string idMember, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsIdMembersByIdCardByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteCardsIdMembersByIdCardByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsIdMembersByIdCardByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsIdMembersByIdCardByIdMember");
            
    
            var path = "/cards/{idCard}/idMembers/{idMember}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsIdMembersByIdCardByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsIdMembersByIdCardByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsLabelsByIdCardByColor() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="color">color</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsLabelsByIdCardByColor (string idCard, string color, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsLabelsByIdCardByColor");
            
            // verify the required parameter 'color' is set
            if (color == null) throw new ApiException(400, "Missing required parameter 'color' when calling DeleteCardsLabelsByIdCardByColor");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsLabelsByIdCardByColor");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsLabelsByIdCardByColor");
            
    
            var path = "/cards/{idCard}/labels/{color}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "color" + "}", ApiClient.ParameterToString(color));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsLabelsByIdCardByColor: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsLabelsByIdCardByColor: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsMembersVotedByIdCardByIdMember() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idMember">idMember</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsMembersVotedByIdCardByIdMember (string idCard, string idMember, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsMembersVotedByIdCardByIdMember");
            
            // verify the required parameter 'idMember' is set
            if (idMember == null) throw new ApiException(400, "Missing required parameter 'idMember' when calling DeleteCardsMembersVotedByIdCardByIdMember");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsMembersVotedByIdCardByIdMember");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsMembersVotedByIdCardByIdMember");
            
    
            var path = "/cards/{idCard}/membersVoted/{idMember}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsMembersVotedByIdCardByIdMember: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsMembersVotedByIdCardByIdMember: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// deleteCardsStickersByIdCardByIdSticker() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idSticker">idSticker</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteCardsStickersByIdCardByIdSticker (string idCard, string idSticker, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling DeleteCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'idSticker' is set
            if (idSticker == null) throw new ApiException(400, "Missing required parameter 'idSticker' when calling DeleteCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteCardsStickersByIdCardByIdSticker");
            
    
            var path = "/cards/{idCard}/stickers/{idSticker}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idSticker" + "}", ApiClient.ParameterToString(idSticker));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsStickersByIdCardByIdSticker: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCardsStickersByIdCardByIdSticker: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsActionsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
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
        public void GetCardsActionsByIdCard (string idCard, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsActionsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsActionsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsActionsByIdCard");
            
    
            var path = "/cards/{idCard}/actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsActionsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsActionsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsAttachmentsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <param name="filter">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <returns></returns>            
        public void GetCardsAttachmentsByIdCard (string idCard, string key, string token, string fields, string filter)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsAttachmentsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsAttachmentsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsAttachmentsByIdCard");
            
    
            var path = "/cards/{idCard}/attachments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsAttachmentsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsAttachmentsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsAttachmentsByIdCardByIdAttachment() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idAttachment">idAttachment</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <returns></returns>            
        public void GetCardsAttachmentsByIdCardByIdAttachment (string idCard, string idAttachment, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsAttachmentsByIdCardByIdAttachment");
            
            // verify the required parameter 'idAttachment' is set
            if (idAttachment == null) throw new ApiException(400, "Missing required parameter 'idAttachment' when calling GetCardsAttachmentsByIdCardByIdAttachment");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsAttachmentsByIdCardByIdAttachment");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsAttachmentsByIdCardByIdAttachment");
            
    
            var path = "/cards/{idCard}/attachments/{idAttachment}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idAttachment" + "}", ApiClient.ParameterToString(idAttachment));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsAttachmentsByIdCardByIdAttachment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsAttachmentsByIdCardByIdAttachment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsBoardByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <returns></returns>            
        public void GetCardsBoardByIdCard (string idCard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsBoardByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsBoardByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsBoardByIdCard");
            
    
            var path = "/cards/{idCard}/board";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsBoardByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsBoardByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsBoardByIdCardByField() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetCardsBoardByIdCardByField (string idCard, string field, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsBoardByIdCardByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetCardsBoardByIdCardByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsBoardByIdCardByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsBoardByIdCardByField");
            
    
            var path = "/cards/{idCard}/board/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsBoardByIdCardByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsBoardByIdCardByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="actions">all or a comma-separated list of: addAttachmentToCard, addChecklistToCard, addMemberToBoard, addMemberToCard, addMemberToOrganization, addToOrganizationBoard, commentCard, convertToCardFromCheckItem, copyBoard, copyCard, copyCommentCard, createBoard, createCard, createList, createOrganization, deleteAttachmentFromCard, deleteBoardInvitation, deleteCard, deleteOrganizationInvitation, disablePowerUp, emailCard, enablePowerUp, makeAdminOfBoard, makeNormalMemberOfBoard, makeNormalMemberOfOrganization, makeObserverOfBoard, memberJoinedTrello, moveCardFromBoard, moveCardToBoard, moveListFromBoard, moveListToBoard, removeChecklistFromCard, removeFromOrganizationBoard, removeMemberFromCard, unconfirmedBoardInvitation, unconfirmedOrganizationInvitation, updateBoard, updateCard, updateCard:closed, updateCard:desc, updateCard:idList, updateCard:name, updateCheckItemStateOnCard, updateChecklist, updateList, updateList:closed, updateList:name, updateMember or updateOrganization</param> 
        /// <param name="actionsEntities"> true or false</param> 
        /// <param name="actionsDisplay"> true or false</param> 
        /// <param name="actionsLimit">a number from 0 to 1000</param> 
        /// <param name="actionFields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="actionMemberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="attachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <param name="attachmentFields">all or a comma-separated list of: bytes, date, edgeColor, idMember, isUpload, mimeType, name, previews or url</param> 
        /// <param name="members"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="membersVoted"> true or false</param> 
        /// <param name="memberVotedFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="checkItemStates"> true or false</param> 
        /// <param name="checkItemStateFields">all or a comma-separated list of: idCheckItem or state</param> 
        /// <param name="checklists">One of: all or none</param> 
        /// <param name="checklistFields">all or a comma-separated list of: idBoard, idCard, name or pos</param> 
        /// <param name="board"> true or false</param> 
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="list"> true or false</param> 
        /// <param name="listFields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <param name="stickers"> true or false</param> 
        /// <param name="stickerFields">all or a comma-separated list of: image, imageScaled, imageUrl, left, rotate, top or zIndex</param> 
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <returns></returns>            
        public void GetCardsByIdCard (string idCard, string key, string token, string actions, string actionsEntities, string actionsDisplay, string actionsLimit, string actionFields, string actionMemberCreatorFields, string attachments, string attachmentFields, string members, string memberFields, string membersVoted, string memberVotedFields, string checkItemStates, string checkItemStateFields, string checklists, string checklistFields, string board, string boardFields, string list, string listFields, string stickers, string stickerFields, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsByIdCard");
            
    
            var path = "/cards/{idCard}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
 if (actionMemberCreatorFields != null) queryParams.Add("action_memberCreator_fields", ApiClient.ParameterToString(actionMemberCreatorFields)); // query parameter
 if (attachments != null) queryParams.Add("attachments", ApiClient.ParameterToString(attachments)); // query parameter
 if (attachmentFields != null) queryParams.Add("attachment_fields", ApiClient.ParameterToString(attachmentFields)); // query parameter
 if (members != null) queryParams.Add("members", ApiClient.ParameterToString(members)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (membersVoted != null) queryParams.Add("membersVoted", ApiClient.ParameterToString(membersVoted)); // query parameter
 if (memberVotedFields != null) queryParams.Add("memberVoted_fields", ApiClient.ParameterToString(memberVotedFields)); // query parameter
 if (checkItemStates != null) queryParams.Add("checkItemStates", ApiClient.ParameterToString(checkItemStates)); // query parameter
 if (checkItemStateFields != null) queryParams.Add("checkItemState_fields", ApiClient.ParameterToString(checkItemStateFields)); // query parameter
 if (checklists != null) queryParams.Add("checklists", ApiClient.ParameterToString(checklists)); // query parameter
 if (checklistFields != null) queryParams.Add("checklist_fields", ApiClient.ParameterToString(checklistFields)); // query parameter
 if (board != null) queryParams.Add("board", ApiClient.ParameterToString(board)); // query parameter
 if (boardFields != null) queryParams.Add("board_fields", ApiClient.ParameterToString(boardFields)); // query parameter
 if (list != null) queryParams.Add("list", ApiClient.ParameterToString(list)); // query parameter
 if (listFields != null) queryParams.Add("list_fields", ApiClient.ParameterToString(listFields)); // query parameter
 if (stickers != null) queryParams.Add("stickers", ApiClient.ParameterToString(stickers)); // query parameter
 if (stickerFields != null) queryParams.Add("sticker_fields", ApiClient.ParameterToString(stickerFields)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsByIdCardByField() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetCardsByIdCardByField (string idCard, string field, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsByIdCardByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetCardsByIdCardByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsByIdCardByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsByIdCardByField");
            
    
            var path = "/cards/{idCard}/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsByIdCardByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsByIdCardByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsCheckItemStatesByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: idCheckItem or state</param> 
        /// <returns></returns>            
        public void GetCardsCheckItemStatesByIdCard (string idCard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsCheckItemStatesByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsCheckItemStatesByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsCheckItemStatesByIdCard");
            
    
            var path = "/cards/{idCard}/checkItemStates";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsCheckItemStatesByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsCheckItemStatesByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsChecklistsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="cards">One of: all, closed, none, open or visible</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="checkItems">One of: all or none</param> 
        /// <param name="checkItemFields">all or a comma-separated list of: name, nameData, pos, state or type</param> 
        /// <param name="filter">One of: all or none</param> 
        /// <param name="fields">all or a comma-separated list of: idBoard, idCard, name or pos</param> 
        /// <returns></returns>            
        public void GetCardsChecklistsByIdCard (string idCard, string key, string token, string cards, string cardFields, string checkItems, string checkItemFields, string filter, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsChecklistsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsChecklistsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsChecklistsByIdCard");
            
    
            var path = "/cards/{idCard}/checklists";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsChecklistsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsChecklistsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsListByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <returns></returns>            
        public void GetCardsListByIdCard (string idCard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsListByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsListByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsListByIdCard");
            
    
            var path = "/cards/{idCard}/list";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsListByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsListByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsListByIdCardByField() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetCardsListByIdCardByField (string idCard, string field, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsListByIdCardByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetCardsListByIdCardByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsListByIdCardByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsListByIdCardByField");
            
    
            var path = "/cards/{idCard}/list/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsListByIdCardByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsListByIdCardByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsMembersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetCardsMembersByIdCard (string idCard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsMembersByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsMembersByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsMembersByIdCard");
            
    
            var path = "/cards/{idCard}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsMembersByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsMembersByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsMembersVotedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetCardsMembersVotedByIdCard (string idCard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsMembersVotedByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsMembersVotedByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsMembersVotedByIdCard");
            
    
            var path = "/cards/{idCard}/membersVoted";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsMembersVotedByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsMembersVotedByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsStickersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: image, imageScaled, imageUrl, left, rotate, top or zIndex</param> 
        /// <returns></returns>            
        public void GetCardsStickersByIdCard (string idCard, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsStickersByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsStickersByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsStickersByIdCard");
            
    
            var path = "/cards/{idCard}/stickers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsStickersByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsStickersByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getCardsStickersByIdCardByIdSticker() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idSticker">idSticker</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: image, imageScaled, imageUrl, left, rotate, top or zIndex</param> 
        /// <returns></returns>            
        public void GetCardsStickersByIdCardByIdSticker (string idCard, string idSticker, string key, string token, string fields)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling GetCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'idSticker' is set
            if (idSticker == null) throw new ApiException(400, "Missing required parameter 'idSticker' when calling GetCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetCardsStickersByIdCardByIdSticker");
            
    
            var path = "/cards/{idCard}/stickers/{idSticker}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idSticker" + "}", ApiClient.ParameterToString(idSticker));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsStickersByIdCardByIdSticker: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCardsStickersByIdCardByIdSticker: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsActionsCommentsByIdCardByIdAction() This can only be done by the original author of the comment.
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idAction">idAction</param> 
        /// <param name="body">Attributes of \&quot;Cards Actions Comments\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsActionsCommentsByIdCardByIdAction (string idCard, string idAction, CardsActionsComments body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsActionsCommentsByIdCardByIdAction");
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling UpdateCardsActionsCommentsByIdCardByIdAction");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsActionsCommentsByIdCardByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsActionsCommentsByIdCardByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsActionsCommentsByIdCardByIdAction");
            
    
            var path = "/cards/{idCard}/actions/{idAction}/comments";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsActionsCommentsByIdCardByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsActionsCommentsByIdCardByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsByIdCard (string idCard, Cards body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsByIdCard");
            
    
            var path = "/cards/{idCard}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklistCurrent">idChecklistCurrent</param> 
        /// <param name="idCheckItem">idCheckItem</param> 
        /// <param name="body">Attributes of \&quot;Cards Checklist Id Checklist Current Check Item\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem (string idCard, string idChecklistCurrent, string idCheckItem, CardsChecklistIdChecklistCurrentCheckItem body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem");
            
            // verify the required parameter 'idChecklistCurrent' is set
            if (idChecklistCurrent == null) throw new ApiException(400, "Missing required parameter 'idChecklistCurrent' when calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem");
            
            // verify the required parameter 'idCheckItem' is set
            if (idCheckItem == null) throw new ApiException(400, "Missing required parameter 'idCheckItem' when calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem");
            
    
            var path = "/cards/{idCard}/checklist/{idChecklistCurrent}/checkItem/{idCheckItem}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklistCurrent" + "}", ApiClient.ParameterToString(idChecklistCurrent));
path = path.Replace("{" + "idCheckItem" + "}", ApiClient.ParameterToString(idCheckItem));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemByIdCardByIdChecklistCurrentByIdCheckItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklist">idChecklist</param> 
        /// <param name="idCheckItem">idCheckItem</param> 
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, CardsChecklistCheckItemName body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idChecklist' is set
            if (idChecklist == null) throw new ApiException(400, "Missing required parameter 'idChecklist' when calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idCheckItem' is set
            if (idCheckItem == null) throw new ApiException(400, "Missing required parameter 'idCheckItem' when calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem");
            
    
            var path = "/cards/{idCard}/checklist/{idChecklist}/checkItem/{idCheckItem}/name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklist" + "}", ApiClient.ParameterToString(idChecklist));
path = path.Replace("{" + "idCheckItem" + "}", ApiClient.ParameterToString(idCheckItem));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemNameByIdCardByIdChecklistByIdCheckItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklist">idChecklist</param> 
        /// <param name="idCheckItem">idCheckItem</param> 
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item Pos\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, CardsChecklistCheckItemPos body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idChecklist' is set
            if (idChecklist == null) throw new ApiException(400, "Missing required parameter 'idChecklist' when calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idCheckItem' is set
            if (idCheckItem == null) throw new ApiException(400, "Missing required parameter 'idCheckItem' when calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem");
            
    
            var path = "/cards/{idCard}/checklist/{idChecklist}/checkItem/{idCheckItem}/pos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklist" + "}", ApiClient.ParameterToString(idChecklist));
path = path.Replace("{" + "idCheckItem" + "}", ApiClient.ParameterToString(idCheckItem));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemPosByIdCardByIdChecklistByIdCheckItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idChecklist">idChecklist</param> 
        /// <param name="idCheckItem">idCheckItem</param> 
        /// <param name="body">Attributes of \&quot;Cards Checklist Check Item State\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem (string idCard, string idChecklist, string idCheckItem, CardsChecklistCheckItemState body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idChecklist' is set
            if (idChecklist == null) throw new ApiException(400, "Missing required parameter 'idChecklist' when calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'idCheckItem' is set
            if (idCheckItem == null) throw new ApiException(400, "Missing required parameter 'idCheckItem' when calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem");
            
    
            var path = "/cards/{idCard}/checklist/{idChecklist}/checkItem/{idCheckItem}/state";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idChecklist" + "}", ApiClient.ParameterToString(idChecklist));
path = path.Replace("{" + "idCheckItem" + "}", ApiClient.ParameterToString(idCheckItem));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsChecklistCheckItemStateByIdCardByIdChecklistByIdCheckItem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsClosedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Closed\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsClosedByIdCard (string idCard, CardsClosed body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsClosedByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsClosedByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsClosedByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsClosedByIdCard");
            
    
            var path = "/cards/{idCard}/closed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsClosedByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsClosedByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsDescByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Desc\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsDescByIdCard (string idCard, CardsDesc body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsDescByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsDescByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsDescByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsDescByIdCard");
            
    
            var path = "/cards/{idCard}/desc";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsDescByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsDescByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsDueByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Due\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsDueByIdCard (string idCard, CardsDue body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsDueByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsDueByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsDueByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsDueByIdCard");
            
    
            var path = "/cards/{idCard}/due";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsDueByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsDueByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsIdAttachmentCoverByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Id Attachment Cover\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsIdAttachmentCoverByIdCard (string idCard, CardsIdAttachmentCover body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsIdAttachmentCoverByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsIdAttachmentCoverByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsIdAttachmentCoverByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsIdAttachmentCoverByIdCard");
            
    
            var path = "/cards/{idCard}/idAttachmentCover";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdAttachmentCoverByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdAttachmentCoverByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsIdBoardByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Id Board\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsIdBoardByIdCard (string idCard, CardsIdBoard body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsIdBoardByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsIdBoardByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsIdBoardByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsIdBoardByIdCard");
            
    
            var path = "/cards/{idCard}/idBoard";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdBoardByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdBoardByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsIdListByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Id List\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsIdListByIdCard (string idCard, CardsIdList body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsIdListByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsIdListByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsIdListByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsIdListByIdCard");
            
    
            var path = "/cards/{idCard}/idList";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdListByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdListByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsIdMembersByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Id Members\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsIdMembersByIdCard (string idCard, CardsIdMembers body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsIdMembersByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsIdMembersByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsIdMembersByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsIdMembersByIdCard");
            
    
            var path = "/cards/{idCard}/idMembers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdMembersByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsIdMembersByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsLabelsByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Labels\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsLabelsByIdCard (string idCard, CardsLabels body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsLabelsByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsLabelsByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsLabelsByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsLabelsByIdCard");
            
    
            var path = "/cards/{idCard}/labels";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsLabelsByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsLabelsByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsNameByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsNameByIdCard (string idCard, CardsName body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsNameByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsNameByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsNameByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsNameByIdCard");
            
    
            var path = "/cards/{idCard}/name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsNameByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsNameByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsPosByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Pos\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsPosByIdCard (string idCard, CardsPos body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsPosByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsPosByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsPosByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsPosByIdCard");
            
    
            var path = "/cards/{idCard}/pos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsPosByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsPosByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsStickersByIdCardByIdSticker() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="idSticker">idSticker</param> 
        /// <param name="body">Attributes of \&quot;Cards Stickers\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsStickersByIdCardByIdSticker (string idCard, string idSticker, CardsStickers body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'idSticker' is set
            if (idSticker == null) throw new ApiException(400, "Missing required parameter 'idSticker' when calling UpdateCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsStickersByIdCardByIdSticker");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsStickersByIdCardByIdSticker");
            
    
            var path = "/cards/{idCard}/stickers/{idSticker}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
path = path.Replace("{" + "idSticker" + "}", ApiClient.ParameterToString(idSticker));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsStickersByIdCardByIdSticker: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsStickersByIdCardByIdSticker: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateCardsSubscribedByIdCard() 
        /// </summary>
        /// <param name="idCard">card id or shortlink</param> 
        /// <param name="body">Attributes of \&quot;Cards Subscribed\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateCardsSubscribedByIdCard (string idCard, CardsSubscribed body, string key, string token)
        {
            
            // verify the required parameter 'idCard' is set
            if (idCard == null) throw new ApiException(400, "Missing required parameter 'idCard' when calling UpdateCardsSubscribedByIdCard");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateCardsSubscribedByIdCard");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateCardsSubscribedByIdCard");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateCardsSubscribedByIdCard");
            
    
            var path = "/cards/{idCard}/subscribed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idCard" + "}", ApiClient.ParameterToString(idCard));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsSubscribedByIdCard: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCardsSubscribedByIdCard: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
