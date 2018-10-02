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
    public interface IActionApi
    {
        /// <summary>
        /// deleteActionsByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void DeleteActionsByIdAction (string idAction, string key, string token);
        /// <summary>
        /// getActionsBoardByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <returns></returns>
        void GetActionsBoardByIdAction (string idAction, string key, string token, string fields);
        /// <summary>
        /// getActionsBoardByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsBoardByIdActionByField (string idAction, string field, string key, string token);
        /// <summary>
        /// getActionsByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="display"> true or false</param>
        /// <param name="entities"> true or false</param>
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator or type</param>
        /// <param name="member"> true or false</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="memberCreator"> true or false</param>
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <returns></returns>
        void GetActionsByIdAction (string idAction, string key, string token, string display, string entities, string fields, string member, string memberFields, string memberCreator, string memberCreatorFields);
        /// <summary>
        /// getActionsByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsByIdActionByField (string idAction, string field, string key, string token);
        /// <summary>
        /// getActionsCardByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <returns></returns>
        void GetActionsCardByIdAction (string idAction, string key, string token, string fields);
        /// <summary>
        /// getActionsCardByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsCardByIdActionByField (string idAction, string field, string key, string token);
        /// <summary>
        /// getActionsDisplayByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsDisplayByIdAction (string idAction, string key, string token);
        /// <summary>
        /// getActionsEntitiesByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsEntitiesByIdAction (string idAction, string key, string token);
        /// <summary>
        /// getActionsListByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param>
        /// <returns></returns>
        void GetActionsListByIdAction (string idAction, string key, string token, string fields);
        /// <summary>
        /// getActionsListByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsListByIdActionByField (string idAction, string field, string key, string token);
        /// <summary>
        /// getActionsMemberByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param>
        /// <returns></returns>
        void GetActionsMemberByIdAction (string idAction, string key, string token, string fields);
        /// <summary>
        /// getActionsMemberByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsMemberByIdActionByField (string idAction, string field, string key, string token);
        /// <summary>
        /// getActionsMemberCreatorByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param>
        /// <returns></returns>
        void GetActionsMemberCreatorByIdAction (string idAction, string key, string token, string fields);
        /// <summary>
        /// getActionsMemberCreatorByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsMemberCreatorByIdActionByField (string idAction, string field, string key, string token);
        /// <summary>
        /// getActionsOrganizationByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <returns></returns>
        void GetActionsOrganizationByIdAction (string idAction, string key, string token, string fields);
        /// <summary>
        /// getActionsOrganizationByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="field">field</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void GetActionsOrganizationByIdActionByField (string idAction, string field, string key, string token);
        /// <summary>
        /// updateActionsByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="body">Attributes of \&quot;Actions\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateActionsByIdAction (string idAction, Actions body, string key, string token);
        /// <summary>
        /// updateActionsTextByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param>
        /// <param name="body">Attributes of \&quot;Actions Text\&quot; to be updated.</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <returns></returns>
        void UpdateActionsTextByIdAction (string idAction, ActionsText body, string key, string token);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionApi : IActionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionApi(String basePath)
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
        /// deleteActionsByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void DeleteActionsByIdAction (string idAction, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling DeleteActionsByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling DeleteActionsByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling DeleteActionsByIdAction");
            
    
            var path = "/actions/{idAction}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteActionsByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteActionsByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsBoardByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <returns></returns>            
        public void GetActionsBoardByIdAction (string idAction, string key, string token, string fields)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsBoardByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsBoardByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsBoardByIdAction");
            
    
            var path = "/actions/{idAction}/board";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsBoardByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsBoardByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsBoardByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsBoardByIdActionByField (string idAction, string field, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsBoardByIdActionByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetActionsBoardByIdActionByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsBoardByIdActionByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsBoardByIdActionByField");
            
    
            var path = "/actions/{idAction}/board/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsBoardByIdActionByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsBoardByIdActionByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="display"> true or false</param> 
        /// <param name="entities"> true or false</param> 
        /// <param name="fields">all or a comma-separated list of: data, date, idMemberCreator or type</param> 
        /// <param name="member"> true or false</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="memberCreator"> true or false</param> 
        /// <param name="memberCreatorFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <returns></returns>            
        public void GetActionsByIdAction (string idAction, string key, string token, string display, string entities, string fields, string member, string memberFields, string memberCreator, string memberCreatorFields)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsByIdAction");
            
    
            var path = "/actions/{idAction}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (display != null) queryParams.Add("display", ApiClient.ParameterToString(display)); // query parameter
 if (entities != null) queryParams.Add("entities", ApiClient.ParameterToString(entities)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsByIdActionByField (string idAction, string field, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsByIdActionByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetActionsByIdActionByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsByIdActionByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsByIdActionByField");
            
    
            var path = "/actions/{idAction}/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsByIdActionByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsByIdActionByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsCardByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <returns></returns>            
        public void GetActionsCardByIdAction (string idAction, string key, string token, string fields)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsCardByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsCardByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsCardByIdAction");
            
    
            var path = "/actions/{idAction}/card";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsCardByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsCardByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsCardByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsCardByIdActionByField (string idAction, string field, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsCardByIdActionByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetActionsCardByIdActionByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsCardByIdActionByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsCardByIdActionByField");
            
    
            var path = "/actions/{idAction}/card/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsCardByIdActionByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsCardByIdActionByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsDisplayByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsDisplayByIdAction (string idAction, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsDisplayByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsDisplayByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsDisplayByIdAction");
            
    
            var path = "/actions/{idAction}/display";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsDisplayByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsDisplayByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsEntitiesByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsEntitiesByIdAction (string idAction, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsEntitiesByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsEntitiesByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsEntitiesByIdAction");
            
    
            var path = "/actions/{idAction}/entities";
            path = path.Replace("{format}", "json");
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsEntitiesByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsEntitiesByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsListByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: closed, idBoard, name, pos or subscribed</param> 
        /// <returns></returns>            
        public void GetActionsListByIdAction (string idAction, string key, string token, string fields)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsListByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsListByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsListByIdAction");
            
    
            var path = "/actions/{idAction}/list";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsListByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsListByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsListByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsListByIdActionByField (string idAction, string field, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsListByIdActionByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetActionsListByIdActionByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsListByIdActionByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsListByIdActionByField");
            
    
            var path = "/actions/{idAction}/list/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsListByIdActionByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsListByIdActionByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsMemberByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param> 
        /// <returns></returns>            
        public void GetActionsMemberByIdAction (string idAction, string key, string token, string fields)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsMemberByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsMemberByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsMemberByIdAction");
            
    
            var path = "/actions/{idAction}/member";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsMemberByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsMemberByIdActionByField (string idAction, string field, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsMemberByIdActionByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetActionsMemberByIdActionByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsMemberByIdActionByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsMemberByIdActionByField");
            
    
            var path = "/actions/{idAction}/member/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberByIdActionByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberByIdActionByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsMemberCreatorByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: avatarHash, avatarSource, bio, bioData, confirmed, email, fullName, gravatarHash, idBoards, idBoardsPinned, idOrganizations, idPremOrgsAdmin, initials, loginTypes, memberType, oneTimeMessagesDismissed, prefs, premiumFeatures, products, status, status, trophies, uploadedAvatarHash, url or username</param> 
        /// <returns></returns>            
        public void GetActionsMemberCreatorByIdAction (string idAction, string key, string token, string fields)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsMemberCreatorByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsMemberCreatorByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsMemberCreatorByIdAction");
            
    
            var path = "/actions/{idAction}/memberCreator";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberCreatorByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberCreatorByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsMemberCreatorByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsMemberCreatorByIdActionByField (string idAction, string field, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsMemberCreatorByIdActionByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetActionsMemberCreatorByIdActionByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsMemberCreatorByIdActionByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsMemberCreatorByIdActionByField");
            
    
            var path = "/actions/{idAction}/memberCreator/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberCreatorByIdActionByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsMemberCreatorByIdActionByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsOrganizationByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="fields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <returns></returns>            
        public void GetActionsOrganizationByIdAction (string idAction, string key, string token, string fields)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsOrganizationByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsOrganizationByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsOrganizationByIdAction");
            
    
            var path = "/actions/{idAction}/organization";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsOrganizationByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsOrganizationByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getActionsOrganizationByIdActionByField() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="field">field</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void GetActionsOrganizationByIdActionByField (string idAction, string field, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling GetActionsOrganizationByIdActionByField");
            
            // verify the required parameter 'field' is set
            if (field == null) throw new ApiException(400, "Missing required parameter 'field' when calling GetActionsOrganizationByIdActionByField");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetActionsOrganizationByIdActionByField");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetActionsOrganizationByIdActionByField");
            
    
            var path = "/actions/{idAction}/organization/{field}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "idAction" + "}", ApiClient.ParameterToString(idAction));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsOrganizationByIdActionByField: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetActionsOrganizationByIdActionByField: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateActionsByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="body">Attributes of \&quot;Actions\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateActionsByIdAction (string idAction, Actions body, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling UpdateActionsByIdAction");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateActionsByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateActionsByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateActionsByIdAction");
            
    
            var path = "/actions/{idAction}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActionsByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActionsByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// updateActionsTextByIdAction() 
        /// </summary>
        /// <param name="idAction">idAction</param> 
        /// <param name="body">Attributes of \&quot;Actions Text\&quot; to be updated.</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <returns></returns>            
        public void UpdateActionsTextByIdAction (string idAction, ActionsText body, string key, string token)
        {
            
            // verify the required parameter 'idAction' is set
            if (idAction == null) throw new ApiException(400, "Missing required parameter 'idAction' when calling UpdateActionsTextByIdAction");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateActionsTextByIdAction");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling UpdateActionsTextByIdAction");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpdateActionsTextByIdAction");
            
    
            var path = "/actions/{idAction}/text";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActionsTextByIdAction: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateActionsTextByIdAction: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
