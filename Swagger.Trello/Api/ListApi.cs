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
    public interface IListApi
    {
        /// <summary>
        /// addLists() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Lists\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddLists (Lists body, string key, string token);
        /// <summary>
        /// addListsArchiveAllCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddListsArchiveAllCardsByIdList (string idList, string key, string token);
        /// <summary>
        /// addListsCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists Cards\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddListsCardsByIdList (string idList, ListsCards body, string key, string token);
        /// <summary>
        /// addListsMoveAllCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists Move All Cards\&quot; to be added.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddListsMoveAllCardsByIdList (string idList, ListsMoveAllCards body, string key, string token);
        /// <summary>
        /// getListsActionsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
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
        void GetListsActionsByIdList (string idList, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields);
        /// <summary>
        /// getListsBoardByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <returns></returns>
        void GetListsBoardByIdList (string idList, string key, string token, string fields);
        /// <summary>
        /// getListsBoardByIdListByField() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetListsBoardByIdListByField (string idList, string field, string key, string token);
        /// <summary>
        /// getListsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="cards">One of: all, closed, none or open</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="board"> true or false</param>
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <returns></returns>
        void GetListsByIdList (string idList, string key, string token, string cards, string cardFields, string board, string boardFields, string fields);
        /// <summary>
        /// getListsByIdListByField() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetListsByIdListByField (string idList, string field, string key, string token);
        /// <summary>
        /// getListsCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
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
        /// <param name="filter">One of: all, closed, none or open</param>
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <returns></returns>
        void GetListsCardsByIdList (string idList, string key, string token, string actions, string attachments, string attachmentFields, string stickers, string members, string memberFields, string checkItemStates, string checklists, string limit, string since, string before, string filter, string fields);
        /// <summary>
        /// getListsCardsByIdListByFilter() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="filter">filter</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetListsCardsByIdListByFilter (string idList, string filter, string key, string token);
        /// <summary>
        /// updateListsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateListsByIdList (string idList, Lists body, string key, string token);
        /// <summary>
        /// updateListsClosedByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists Closed\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateListsClosedByIdList (string idList, ListsClosed body, string key, string token);
        /// <summary>
        /// updateListsIdBoardByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists Id Board\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateListsIdBoardByIdList (string idList, ListsIdBoard body, string key, string token);
        /// <summary>
        /// updateListsNameByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists Name\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateListsNameByIdList (string idList, ListsName body, string key, string token);
        /// <summary>
        /// updateListsPosByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists Pos\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateListsPosByIdList (string idList, ListsPos body, string key, string token);
        /// <summary>
        /// updateListsSubscribedByIdList() 
        /// </summary>
        /// <param name="idList">idList</param>
        /// <param name="body">Attributes of \&quot;Lists Subscribed\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateListsSubscribedByIdList (string idList, ListsSubscribed body, string key, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ListApi : IListApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ListApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ListApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ListApi(String basePath)
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
        /// addLists() 
        /// </summary>
        /// <param name="body">Attributes of \&quot;Lists\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddLists (Lists body, string key, string token)
        {
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddLists");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddLists");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddLists");
            
    
            var path = "/lists";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddLists: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddLists: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addListsArchiveAllCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddListsArchiveAllCardsByIdList (string idList, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling AddListsArchiveAllCardsByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddListsArchiveAllCardsByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddListsArchiveAllCardsByIdList");
            
    
            var path = "/lists/{idList}/archiveAllCards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddListsArchiveAllCardsByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddListsArchiveAllCardsByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addListsCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists Cards\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddListsCardsByIdList (string idList, ListsCards body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling AddListsCardsByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddListsCardsByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddListsCardsByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddListsCardsByIdList");
            
    
            var path = "/lists/{idList}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddListsCardsByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddListsCardsByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// addListsMoveAllCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists Move All Cards\&quot; to be added.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddListsMoveAllCardsByIdList (string idList, ListsMoveAllCards body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling AddListsMoveAllCardsByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddListsMoveAllCardsByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddListsMoveAllCardsByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddListsMoveAllCardsByIdList");
            
    
            var path = "/lists/{idList}/moveAllCards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddListsMoveAllCardsByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddListsMoveAllCardsByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getListsActionsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
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
        public void GetListsActionsByIdList (string idList, string key, string token, string entities, string display, string filter, string fields, string limit, string format, string since, string before, string page, string idModels, string member, string memberFields, string memberCreator, string memberCreatorFields)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling GetListsActionsByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetListsActionsByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetListsActionsByIdList");
            
    
            var path = "/lists/{idList}/actions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsActionsByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsActionsByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getListsBoardByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <returns></returns>            
        public void GetListsBoardByIdList (string idList, string key, string token, string fields)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling GetListsBoardByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetListsBoardByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetListsBoardByIdList");
            
    
            var path = "/lists/{idList}/board";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsBoardByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsBoardByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getListsBoardByIdListByField() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetListsBoardByIdListByField (string idList, string field, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling GetListsBoardByIdListByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetListsBoardByIdListByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetListsBoardByIdListByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetListsBoardByIdListByField");
            
    
            var path = "/lists/{idList}/board/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsBoardByIdListByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsBoardByIdListByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getListsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="cards">One of: all, closed, none or open</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="board"> true or false</param> 
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <returns></returns>            
        public void GetListsByIdList (string idList, string key, string token, string cards, string cardFields, string board, string boardFields, string fields)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling GetListsByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetListsByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetListsByIdList");
            
    
            var path = "/lists/{idList}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (cards != null) queryParams.Add("cards", ApiClient.ParameterToString(cards)); // query parameter
 if (cardFields != null) queryParams.Add("card_fields", ApiClient.ParameterToString(cardFields)); // query parameter
 if (board != null) queryParams.Add("board", ApiClient.ParameterToString(board)); // query parameter
 if (boardFields != null) queryParams.Add("board_fields", ApiClient.ParameterToString(boardFields)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getListsByIdListByField() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetListsByIdListByField (string idList, string field, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling GetListsByIdListByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetListsByIdListByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetListsByIdListByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetListsByIdListByField");
            
    
            var path = "/lists/{idList}/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsByIdListByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsByIdListByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getListsCardsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
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
        /// <param name="filter">One of: all, closed, none or open</param> 
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <returns></returns>            
        public void GetListsCardsByIdList (string idList, string key, string token, string actions, string attachments, string attachmentFields, string stickers, string members, string memberFields, string checkItemStates, string checklists, string limit, string since, string before, string filter, string fields)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling GetListsCardsByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetListsCardsByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetListsCardsByIdList");
            
    
            var path = "/lists/{idList}/cards";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsCardsByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsCardsByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getListsCardsByIdListByFilter() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="filter">filter</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetListsCardsByIdListByFilter (string idList, string filter, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling GetListsCardsByIdListByFilter");
            
            // verify the required parameter 'filter' is set
            if (filter == null) throw new ApiException(400, "Missing required parameter 'filter' when calling GetListsCardsByIdListByFilter");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetListsCardsByIdListByFilter");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetListsCardsByIdListByFilter");
            
    
            var path = "/lists/{idList}/cards/{filter}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsCardsByIdListByFilter: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetListsCardsByIdListByFilter: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateListsByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateListsByIdList (string idList, Lists body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling UpdateListsByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateListsByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateListsByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateListsByIdList");
            
    
            var path = "/lists/{idList}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateListsClosedByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists Closed\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateListsClosedByIdList (string idList, ListsClosed body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling UpdateListsClosedByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateListsClosedByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateListsClosedByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateListsClosedByIdList");
            
    
            var path = "/lists/{idList}/closed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsClosedByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsClosedByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateListsIdBoardByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists Id Board\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateListsIdBoardByIdList (string idList, ListsIdBoard body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling UpdateListsIdBoardByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateListsIdBoardByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateListsIdBoardByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateListsIdBoardByIdList");
            
    
            var path = "/lists/{idList}/idBoard";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsIdBoardByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsIdBoardByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateListsNameByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists Name\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateListsNameByIdList (string idList, ListsName body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling UpdateListsNameByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateListsNameByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateListsNameByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateListsNameByIdList");
            
    
            var path = "/lists/{idList}/name";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsNameByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsNameByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateListsPosByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists Pos\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateListsPosByIdList (string idList, ListsPos body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling UpdateListsPosByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateListsPosByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateListsPosByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateListsPosByIdList");
            
    
            var path = "/lists/{idList}/pos";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsPosByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsPosByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateListsSubscribedByIdList() 
        /// </summary>
        /// <param name="idList">idList</param> 
        /// <param name="body">Attributes of \&quot;Lists Subscribed\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateListsSubscribedByIdList (string idList, ListsSubscribed body, string key, string token)
        {
            
            // verify the required parameter 'idList' is set
            if (idList == null) throw new ApiException(400, "Missing required parameter 'idList' when calling UpdateListsSubscribedByIdList");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateListsSubscribedByIdList");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateListsSubscribedByIdList");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateListsSubscribedByIdList");
            
    
            var path = "/lists/{idList}/subscribed";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idList" + "}", ApiClient.ParameterToString(idList));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsSubscribedByIdList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateListsSubscribedByIdList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
