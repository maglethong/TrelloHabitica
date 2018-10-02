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
    public interface INotificationApi
    {
        /// <summary>
        /// addNotificationsAllRead() 
        /// </summary>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void AddNotificationsAllRead (string key, string token);
        /// <summary>
        /// getNotificationsBoardByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <returns></returns>
        void GetNotificationsBoardByIdNotification (string idNotification, string key, string token, string fields);
        /// <summary>
        /// getNotificationsBoardByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsBoardByIdNotificationByField (string idNotification, string field, string key, string token);
        /// <summary>
        /// getNotificationsByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="display"> true or false</param>
        /// <param name="entities"> true or false</param>
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator, type or unread</param>
        /// <param name="memberCreator"> true or false</param>
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="board"> true or false</param>
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="list"> true or false</param>
        /// <param name="card"> true or false</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="organization"> true or false</param>
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="member"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetNotificationsByIdNotification (string idNotification, string key, string token, string display, string entities, string fields, string memberCreator, string memberCreatorFields, string board, string boardFields, string list, string card, string cardFields, string organization, string organizationFields, string member, string memberFields);
        /// <summary>
        /// getNotificationsByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsByIdNotificationByField (string idNotification, string field, string key, string token);
        /// <summary>
        /// getNotificationsCardByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <returns></returns>
        void GetNotificationsCardByIdNotification (string idNotification, string key, string token, string fields);
        /// <summary>
        /// getNotificationsCardByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsCardByIdNotificationByField (string idNotification, string field, string key, string token);
        /// <summary>
        /// getNotificationsDisplayByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsDisplayByIdNotification (string idNotification, string key, string token);
        /// <summary>
        /// getNotificationsEntitiesByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsEntitiesByIdNotification (string idNotification, string key, string token);
        /// <summary>
        /// getNotificationsListByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <returns></returns>
        void GetNotificationsListByIdNotification (string idNotification, string key, string token, string fields);
        /// <summary>
        /// getNotificationsListByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsListByIdNotificationByField (string idNotification, string field, string key, string token);
        /// <summary>
        /// getNotificationsMemberByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param>
        /// <returns></returns>
        void GetNotificationsMemberByIdNotification (string idNotification, string key, string token, string fields);
        /// <summary>
        /// getNotificationsMemberByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsMemberByIdNotificationByField (string idNotification, string field, string key, string token);
        /// <summary>
        /// getNotificationsMemberCreatorByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param>
        /// <returns></returns>
        void GetNotificationsMemberCreatorByIdNotification (string idNotification, string key, string token, string fields);
        /// <summary>
        /// getNotificationsMemberCreatorByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsMemberCreatorByIdNotificationByField (string idNotification, string field, string key, string token);
        /// <summary>
        /// getNotificationsOrganizationByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <returns></returns>
        void GetNotificationsOrganizationByIdNotification (string idNotification, string key, string token, string fields);
        /// <summary>
        /// getNotificationsOrganizationByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetNotificationsOrganizationByIdNotificationByField (string idNotification, string field, string key, string token);
        /// <summary>
        /// updateNotificationsByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="body">Attributes of \&quot;Notifications\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateNotificationsByIdNotification (string idNotification, Notifications body, string key, string token);
        /// <summary>
        /// updateNotificationsUnreadByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param>
        /// <param name="body">Attributes of \&quot;Notifications Unread\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateNotificationsUnreadByIdNotification (string idNotification, NotificationsUnread body, string key, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificationApi : INotificationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public NotificationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationApi(String basePath)
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
        /// addNotificationsAllRead() 
        /// </summary>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void AddNotificationsAllRead (string key, string token)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling AddNotificationsAllRead");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddNotificationsAllRead");
            
    
            var path = "/notifications/all/read";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling AddNotificationsAllRead: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddNotificationsAllRead: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsBoardByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <returns></returns>            
        public void GetNotificationsBoardByIdNotification (string idNotification, string key, string token, string fields)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsBoardByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsBoardByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsBoardByIdNotification");
            
    
            var path = "/notifications/{idNotification}/board";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsBoardByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsBoardByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsBoardByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsBoardByIdNotificationByField (string idNotification, string field, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsBoardByIdNotificationByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetNotificationsBoardByIdNotificationByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsBoardByIdNotificationByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsBoardByIdNotificationByField");
            
    
            var path = "/notifications/{idNotification}/board/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsBoardByIdNotificationByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsBoardByIdNotificationByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="display"> true or false</param> 
        /// <param name="entities"> true or false</param> 
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator, type or unread</param> 
        /// <param name="memberCreator"> true or false</param> 
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="board"> true or false</param> 
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="list"> true or false</param> 
        /// <param name="card"> true or false</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="organization"> true or false</param> 
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="member"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetNotificationsByIdNotification (string idNotification, string key, string token, string display, string entities, string fields, string memberCreator, string memberCreatorFields, string board, string boardFields, string list, string card, string cardFields, string organization, string organizationFields, string member, string memberFields)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsByIdNotification");
            
    
            var path = "/notifications/{idNotification}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (display != null) queryParams.Add("display", ApiClient.ParameterToString(display)); // query parameter
 if (entities != null) queryParams.Add("entities", ApiClient.ParameterToString(entities)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (memberCreator != null) queryParams.Add("memberCreator", ApiClient.ParameterToString(memberCreator)); // query parameter
 if (memberCreatorFields != null) queryParams.Add("memberCreator_fields", ApiClient.ParameterToString(memberCreatorFields)); // query parameter
 if (board != null) queryParams.Add("board", ApiClient.ParameterToString(board)); // query parameter
 if (boardFields != null) queryParams.Add("board_fields", ApiClient.ParameterToString(boardFields)); // query parameter
 if (list != null) queryParams.Add("list", ApiClient.ParameterToString(list)); // query parameter
 if (card != null) queryParams.Add("card", ApiClient.ParameterToString(card)); // query parameter
 if (cardFields != null) queryParams.Add("card_fields", ApiClient.ParameterToString(cardFields)); // query parameter
 if (organization != null) queryParams.Add("organization", ApiClient.ParameterToString(organization)); // query parameter
 if (organizationFields != null) queryParams.Add("organization_fields", ApiClient.ParameterToString(organizationFields)); // query parameter
 if (member != null) queryParams.Add("member", ApiClient.ParameterToString(member)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key", "api_token" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsByIdNotificationByField (string idNotification, string field, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsByIdNotificationByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetNotificationsByIdNotificationByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsByIdNotificationByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsByIdNotificationByField");
            
    
            var path = "/notifications/{idNotification}/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsByIdNotificationByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsByIdNotificationByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsCardByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <returns></returns>            
        public void GetNotificationsCardByIdNotification (string idNotification, string key, string token, string fields)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsCardByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsCardByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsCardByIdNotification");
            
    
            var path = "/notifications/{idNotification}/card";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsCardByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsCardByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsCardByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsCardByIdNotificationByField (string idNotification, string field, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsCardByIdNotificationByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetNotificationsCardByIdNotificationByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsCardByIdNotificationByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsCardByIdNotificationByField");
            
    
            var path = "/notifications/{idNotification}/card/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsCardByIdNotificationByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsCardByIdNotificationByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsDisplayByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsDisplayByIdNotification (string idNotification, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsDisplayByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsDisplayByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsDisplayByIdNotification");
            
    
            var path = "/notifications/{idNotification}/display";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsDisplayByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsDisplayByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsEntitiesByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsEntitiesByIdNotification (string idNotification, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsEntitiesByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsEntitiesByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsEntitiesByIdNotification");
            
    
            var path = "/notifications/{idNotification}/entities";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsEntitiesByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsEntitiesByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsListByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <returns></returns>            
        public void GetNotificationsListByIdNotification (string idNotification, string key, string token, string fields)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsListByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsListByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsListByIdNotification");
            
    
            var path = "/notifications/{idNotification}/list";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsListByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsListByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsListByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsListByIdNotificationByField (string idNotification, string field, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsListByIdNotificationByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetNotificationsListByIdNotificationByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsListByIdNotificationByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsListByIdNotificationByField");
            
    
            var path = "/notifications/{idNotification}/list/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsListByIdNotificationByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsListByIdNotificationByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsMemberByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param> 
        /// <returns></returns>            
        public void GetNotificationsMemberByIdNotification (string idNotification, string key, string token, string fields)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsMemberByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsMemberByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsMemberByIdNotification");
            
    
            var path = "/notifications/{idNotification}/member";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsMemberByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsMemberByIdNotificationByField (string idNotification, string field, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsMemberByIdNotificationByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetNotificationsMemberByIdNotificationByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsMemberByIdNotificationByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsMemberByIdNotificationByField");
            
    
            var path = "/notifications/{idNotification}/member/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberByIdNotificationByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberByIdNotificationByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsMemberCreatorByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param> 
        /// <returns></returns>            
        public void GetNotificationsMemberCreatorByIdNotification (string idNotification, string key, string token, string fields)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsMemberCreatorByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsMemberCreatorByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsMemberCreatorByIdNotification");
            
    
            var path = "/notifications/{idNotification}/memberCreator";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberCreatorByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberCreatorByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsMemberCreatorByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsMemberCreatorByIdNotificationByField (string idNotification, string field, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsMemberCreatorByIdNotificationByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetNotificationsMemberCreatorByIdNotificationByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsMemberCreatorByIdNotificationByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsMemberCreatorByIdNotificationByField");
            
    
            var path = "/notifications/{idNotification}/memberCreator/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberCreatorByIdNotificationByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsMemberCreatorByIdNotificationByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsOrganizationByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <returns></returns>            
        public void GetNotificationsOrganizationByIdNotification (string idNotification, string key, string token, string fields)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsOrganizationByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsOrganizationByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsOrganizationByIdNotification");
            
    
            var path = "/notifications/{idNotification}/organization";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsOrganizationByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsOrganizationByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getNotificationsOrganizationByIdNotificationByField() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetNotificationsOrganizationByIdNotificationByField (string idNotification, string field, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling GetNotificationsOrganizationByIdNotificationByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetNotificationsOrganizationByIdNotificationByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetNotificationsOrganizationByIdNotificationByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetNotificationsOrganizationByIdNotificationByField");
            
    
            var path = "/notifications/{idNotification}/organization/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsOrganizationByIdNotificationByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotificationsOrganizationByIdNotificationByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateNotificationsByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="body">Attributes of \&quot;Notifications\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateNotificationsByIdNotification (string idNotification, Notifications body, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling UpdateNotificationsByIdNotification");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateNotificationsByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateNotificationsByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateNotificationsByIdNotification");
            
    
            var path = "/notifications/{idNotification}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateNotificationsByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateNotificationsByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateNotificationsUnreadByIdNotification() 
        /// </summary>
        /// <param name="idNotification">idNotification</param> 
        /// <param name="body">Attributes of \&quot;Notifications Unread\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateNotificationsUnreadByIdNotification (string idNotification, NotificationsUnread body, string key, string token)
        {
            
            // verify the required parameter 'idNotification' is set
            if (idNotification == null) throw new ApiException(400, "Missing required parameter 'idNotification' when calling UpdateNotificationsUnreadByIdNotification");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateNotificationsUnreadByIdNotification");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateNotificationsUnreadByIdNotification");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateNotificationsUnreadByIdNotification");
            
    
            var path = "/notifications/{idNotification}/unread";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idNotification" + "}", ApiClient.ParameterToString(idNotification));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateNotificationsUnreadByIdNotification: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateNotificationsUnreadByIdNotification: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
