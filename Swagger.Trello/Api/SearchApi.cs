using System;
using System.Collections.Generic;
using RestSharp;
using Swagger.Client;

namespace Swagger.Trello.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi
    {
        /// <summary>
        /// getSearch() 
        /// </summary>
        /// <param name="query">a string with a length from 1 to 16384</param>
        /// <param name="idOrganizations">A comma-separated list of objectIds, 24-character hex strings</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="idBoards">A comma-separated list of objectIds, 24-character hex strings</param>
        /// <param name="idCards">A comma-separated list of objectIds, 24-character hex strings</param>
        /// <param name="modelTypes">all or a comma-separated list of: actions, boards, cards, members or organizations</param>
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param>
        /// <param name="boardsLimit">a number from 1 to 1000</param>
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param>
        /// <param name="cardsLimit">a number from 1 to 1000</param>
        /// <param name="cardsPage">a number from 0 to 100</param>
        /// <param name="cardBoard"> true or false</param>
        /// <param name="cardList"> true or false</param>
        /// <param name="cardMembers"> true or false</param>
        /// <param name="cardStickers"> true or false</param>
        /// <param name="cardAttachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param>
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param>
        /// <param name="organizationsLimit">a number from 1 to 1000</param>
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param>
        /// <param name="membersLimit">a number from 1 to 1000</param>
        /// <param name="partial"> true or false</param>
        /// <returns></returns>
        void GetSearch (string query, string idOrganizations, string key, string token, string idBoards, string idCards, string modelTypes, string boardFields, string boardsLimit, string cardFields, string cardsLimit, string cardsPage, string cardBoard, string cardList, string cardMembers, string cardStickers, string cardAttachments, string organizationFields, string organizationsLimit, string memberFields, string membersLimit, string partial);
        /// <summary>
        /// getSearchMembers() 
        /// </summary>
        /// <param name="query">a string with a length from 1 to 16384</param>
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param>
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param>
        /// <param name="limit">a number from 1 to 20</param>
        /// <param name="idBoard">An id, or null</param>
        /// <param name="idOrganization">An id, or null</param>
        /// <param name="onlyOrgMembers">A boolean</param>
        /// <returns></returns>
        void GetSearchMembers (string query, string key, string token, string limit, string idBoard, string idOrganization, string onlyOrgMembers);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : ISearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SearchApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
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
        /// getSearch() 
        /// </summary>
        /// <param name="query">a string with a length from 1 to 16384</param> 
        /// <param name="idOrganizations">A comma-separated list of objectIds, 24-character hex strings</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="idBoards">A comma-separated list of objectIds, 24-character hex strings</param> 
        /// <param name="idCards">A comma-separated list of objectIds, 24-character hex strings</param> 
        /// <param name="modelTypes">all or a comma-separated list of: actions, boards, cards, members or organizations</param> 
        /// <param name="boardFields">all or a comma-separated list of: closed, dateLastActivity, dateLastView, desc, descData, idOrganization, invitations, invited, labelNames, memberships, name, pinned, powerUps, prefs, shortLink, shortUrl, starred, subscribed or url</param> 
        /// <param name="boardsLimit">a number from 1 to 1000</param> 
        /// <param name="cardFields">all or a comma-separated list of: badges, checkItemStates, closed, dateLastActivity, desc, descData, due, email, idAttachmentCover, idBoard, idChecklists, idLabels, idList, idMembers, idMembersVoted, idShort, labels, manualCoverAttachment, name, pos, shortLink, shortUrl, subscribed or url</param> 
        /// <param name="cardsLimit">a number from 1 to 1000</param> 
        /// <param name="cardsPage">a number from 0 to 100</param> 
        /// <param name="cardBoard"> true or false</param> 
        /// <param name="cardList"> true or false</param> 
        /// <param name="cardMembers"> true or false</param> 
        /// <param name="cardStickers"> true or false</param> 
        /// <param name="cardAttachments">A boolean value or &amp;quot;cover&amp;quot; for only card cover attachments</param> 
        /// <param name="organizationFields">all or a comma-separated list of: billableMemberCount, desc, descData, displayName, idBoards, invitations, invited, logoHash, memberships, name, powerUps, prefs, premiumFeatures, products, url or website</param> 
        /// <param name="organizationsLimit">a number from 1 to 1000</param> 
        /// <param name="memberFields">all or a comma-separated list of: avatarHash, bio, bioData, confirmed, fullName, idPremOrgsAdmin, initials, memberType, products, status, url or username</param> 
        /// <param name="membersLimit">a number from 1 to 1000</param> 
        /// <param name="partial"> true or false</param> 
        /// <returns></returns>            
        public void GetSearch (string query, string idOrganizations, string key, string token, string idBoards, string idCards, string modelTypes, string boardFields, string boardsLimit, string cardFields, string cardsLimit, string cardsPage, string cardBoard, string cardList, string cardMembers, string cardStickers, string cardAttachments, string organizationFields, string organizationsLimit, string memberFields, string membersLimit, string partial)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling GetSearch");
            
            // verify the required parameter 'idOrganizations' is set
            if (idOrganizations == null) throw new ApiException(400, "Missing required parameter 'idOrganizations' when calling GetSearch");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetSearch");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetSearch");
            
    
            var path = "/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (idBoards != null) queryParams.Add("idBoards", ApiClient.ParameterToString(idBoards)); // query parameter
 if (idOrganizations != null) queryParams.Add("idOrganizations", ApiClient.ParameterToString(idOrganizations)); // query parameter
 if (idCards != null) queryParams.Add("idCards", ApiClient.ParameterToString(idCards)); // query parameter
 if (modelTypes != null) queryParams.Add("modelTypes", ApiClient.ParameterToString(modelTypes)); // query parameter
 if (boardFields != null) queryParams.Add("board_fields", ApiClient.ParameterToString(boardFields)); // query parameter
 if (boardsLimit != null) queryParams.Add("boards_limit", ApiClient.ParameterToString(boardsLimit)); // query parameter
 if (cardFields != null) queryParams.Add("card_fields", ApiClient.ParameterToString(cardFields)); // query parameter
 if (cardsLimit != null) queryParams.Add("cards_limit", ApiClient.ParameterToString(cardsLimit)); // query parameter
 if (cardsPage != null) queryParams.Add("cards_page", ApiClient.ParameterToString(cardsPage)); // query parameter
 if (cardBoard != null) queryParams.Add("card_board", ApiClient.ParameterToString(cardBoard)); // query parameter
 if (cardList != null) queryParams.Add("card_list", ApiClient.ParameterToString(cardList)); // query parameter
 if (cardMembers != null) queryParams.Add("card_members", ApiClient.ParameterToString(cardMembers)); // query parameter
 if (cardStickers != null) queryParams.Add("card_stickers", ApiClient.ParameterToString(cardStickers)); // query parameter
 if (cardAttachments != null) queryParams.Add("card_attachments", ApiClient.ParameterToString(cardAttachments)); // query parameter
 if (organizationFields != null) queryParams.Add("organization_fields", ApiClient.ParameterToString(organizationFields)); // query parameter
 if (organizationsLimit != null) queryParams.Add("organizations_limit", ApiClient.ParameterToString(organizationsLimit)); // query parameter
 if (memberFields != null) queryParams.Add("member_fields", ApiClient.ParameterToString(memberFields)); // query parameter
 if (membersLimit != null) queryParams.Add("members_limit", ApiClient.ParameterToString(membersLimit)); // query parameter
 if (partial != null) queryParams.Add("partial", ApiClient.ParameterToString(partial)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// getSearchMembers() 
        /// </summary>
        /// <param name="query">a string with a length from 1 to 16384</param> 
        /// <param name="key">&lt;a href&#x3D;\&quot;https://trello.com/1/appKey/generate\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Generate your application key&lt;/a&gt;</param> 
        /// <param name="token">&lt;a href&#x3D;\&quot;https://trello.com/docs/gettingstarted/index.html#getting-a-token-from-a-user\&quot;  target&#x3D;\&quot;_blank\&quot;&gt;Getting a token from a user&lt;/a&gt;</param> 
        /// <param name="limit">a number from 1 to 20</param> 
        /// <param name="idBoard">An id, or null</param> 
        /// <param name="idOrganization">An id, or null</param> 
        /// <param name="onlyOrgMembers">A boolean</param> 
        /// <returns></returns>            
        public void GetSearchMembers (string query, string key, string token, string limit, string idBoard, string idOrganization, string onlyOrgMembers)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling GetSearchMembers");
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetSearchMembers");
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling GetSearchMembers");
            
    
            var path = "/search/members";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (idBoard != null) queryParams.Add("idBoard", ApiClient.ParameterToString(idBoard)); // query parameter
 if (idOrganization != null) queryParams.Add("idOrganization", ApiClient.ParameterToString(idOrganization)); // query parameter
 if (onlyOrgMembers != null) queryParams.Add("onlyOrgMembers", ApiClient.ParameterToString(onlyOrgMembers)); // query parameter
 if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
 if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSearchMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSearchMembers: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
