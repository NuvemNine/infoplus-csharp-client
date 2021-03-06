using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Infoplus.Client;
using Infoplus.Model;

namespace Infoplus.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IItemAccountCodeApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param>
        /// <returns>ItemAccountCode</returns>
        ItemAccountCode AddItemAccountCode (ItemAccountCode body);
  
        /// <summary>
        /// Create an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param>
        /// <returns>ApiResponse of ItemAccountCode</returns>
        ApiResponse<ItemAccountCode> AddItemAccountCodeWithHttpInfo (ItemAccountCode body);
        
        /// <summary>
        /// Add new audit for an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param>
        /// <param name="itemAccountCodeAudit">The audit to add</param>
        /// <returns></returns>
        void AddItemAccountCodeAudit (int? itemAccountCodeId, string itemAccountCodeAudit);
  
        /// <summary>
        /// Add new audit for an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param>
        /// <param name="itemAccountCodeAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemAccountCodeAuditWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeAudit);
        
        /// <summary>
        /// Add new tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param>
        /// <param name="itemAccountCodeTag">The tag to add</param>
        /// <returns></returns>
        void AddItemAccountCodeTag (int? itemAccountCodeId, string itemAccountCodeTag);
  
        /// <summary>
        /// Add new tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param>
        /// <param name="itemAccountCodeTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddItemAccountCodeTagWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag);
        
        /// <summary>
        /// Delete an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param>
        /// <returns></returns>
        void DeleteItemAccountCode (int? itemAccountCodeId);
  
        /// <summary>
        /// Delete an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemAccountCodeWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Delete a tag for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemAccountCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param>
        /// <param name="itemAccountCodeTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteItemAccountCodeTag (int? itemAccountCodeId, string itemAccountCodeTag);
  
        /// <summary>
        /// Delete a tag for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemAccountCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param>
        /// <param name="itemAccountCodeTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteItemAccountCodeTagWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag);
        
        /// <summary>
        /// Get a duplicated an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param>
        /// <returns>ItemAccountCode</returns>
        ItemAccountCode GetDuplicateItemAccountCodeById (int? itemAccountCodeId);
  
        /// <summary>
        /// Get a duplicated an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param>
        /// <returns>ApiResponse of ItemAccountCode</returns>
        ApiResponse<ItemAccountCode> GetDuplicateItemAccountCodeByIdWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Search itemAccountCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ItemAccountCode&gt;</returns>
        List<ItemAccountCode> GetItemAccountCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search itemAccountCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ItemAccountCode&gt;</returns>
        ApiResponse<List<ItemAccountCode>> GetItemAccountCodeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param>
        /// <returns>ItemAccountCode</returns>
        ItemAccountCode GetItemAccountCodeById (int? itemAccountCodeId);
  
        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param>
        /// <returns>ApiResponse of ItemAccountCode</returns>
        ApiResponse<ItemAccountCode> GetItemAccountCodeByIdWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Get the tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemAccountCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param>
        /// <returns></returns>
        void GetItemAccountCodeTags (int? itemAccountCodeId);
  
        /// <summary>
        /// Get the tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemAccountCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetItemAccountCodeTagsWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Update an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param>
        /// <returns></returns>
        void UpdateItemAccountCode (ItemAccountCode body);
  
        /// <summary>
        /// Update an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateItemAccountCodeWithHttpInfo (ItemAccountCode body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param>
        /// <returns>Task of ItemAccountCode</returns>
        System.Threading.Tasks.Task<ItemAccountCode> AddItemAccountCodeAsync (ItemAccountCode body);

        /// <summary>
        /// Create an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Inserts a new itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> AddItemAccountCodeAsyncWithHttpInfo (ItemAccountCode body);
        
        /// <summary>
        /// Add new audit for an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param>
        /// <param name="itemAccountCodeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemAccountCodeAuditAsync (int? itemAccountCodeId, string itemAccountCodeAudit);

        /// <summary>
        /// Add new audit for an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param>
        /// <param name="itemAccountCodeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemAccountCodeAuditAsyncWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeAudit);
        
        /// <summary>
        /// Add new tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param>
        /// <param name="itemAccountCodeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddItemAccountCodeTagAsync (int? itemAccountCodeId, string itemAccountCodeTag);

        /// <summary>
        /// Add new tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing itemAccountCode.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param>
        /// <param name="itemAccountCodeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddItemAccountCodeTagAsyncWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag);
        
        /// <summary>
        /// Delete an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemAccountCodeAsync (int? itemAccountCodeId);

        /// <summary>
        /// Delete an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Deletes the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemAccountCodeAsyncWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Delete a tag for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemAccountCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param>
        /// <param name="itemAccountCodeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteItemAccountCodeTagAsync (int? itemAccountCodeId, string itemAccountCodeTag);

        /// <summary>
        /// Delete a tag for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Deletes an existing itemAccountCode tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param>
        /// <param name="itemAccountCodeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemAccountCodeTagAsyncWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag);
        
        /// <summary>
        /// Get a duplicated an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param>
        /// <returns>Task of ItemAccountCode</returns>
        System.Threading.Tasks.Task<ItemAccountCode> GetDuplicateItemAccountCodeByIdAsync (int? itemAccountCodeId);

        /// <summary>
        /// Get a duplicated an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> GetDuplicateItemAccountCodeByIdAsyncWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Search itemAccountCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemAccountCode&gt;</returns>
        System.Threading.Tasks.Task<List<ItemAccountCode>> GetItemAccountCodeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search itemAccountCodes by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of itemAccountCodes that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemAccountCode&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ItemAccountCode>>> GetItemAccountCodeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param>
        /// <returns>Task of ItemAccountCode</returns>
        System.Threading.Tasks.Task<ItemAccountCode> GetItemAccountCodeByIdAsync (int? itemAccountCodeId);

        /// <summary>
        /// Get an itemAccountCode by id
        /// </summary>
        /// <remarks>
        /// Returns the itemAccountCode identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> GetItemAccountCodeByIdAsyncWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Get the tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemAccountCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetItemAccountCodeTagsAsync (int? itemAccountCodeId);

        /// <summary>
        /// Get the tags for an itemAccountCode.
        /// </summary>
        /// <remarks>
        /// Get all existing itemAccountCode tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetItemAccountCodeTagsAsyncWithHttpInfo (int? itemAccountCodeId);
        
        /// <summary>
        /// Update an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateItemAccountCodeAsync (ItemAccountCode body);

        /// <summary>
        /// Update an itemAccountCode
        /// </summary>
        /// <remarks>
        /// Updates an existing itemAccountCode using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemAccountCodeAsyncWithHttpInfo (ItemAccountCode body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ItemAccountCodeApi : IItemAccountCodeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAccountCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemAccountCodeApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemAccountCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemAccountCodeApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Create an itemAccountCode Inserts a new itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param> 
        /// <returns>ItemAccountCode</returns>
        public ItemAccountCode AddItemAccountCode (ItemAccountCode body)
        {
             ApiResponse<ItemAccountCode> localVarResponse = AddItemAccountCodeWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an itemAccountCode Inserts a new itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param> 
        /// <returns>ApiResponse of ItemAccountCode</returns>
        public ApiResponse< ItemAccountCode > AddItemAccountCodeWithHttpInfo (ItemAccountCode body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemAccountCodeApi->AddItemAccountCode");
            
    
            var localVarPath = "/beta/itemAccountCode";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }

        
        /// <summary>
        /// Create an itemAccountCode Inserts a new itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param>
        /// <returns>Task of ItemAccountCode</returns>
        public async System.Threading.Tasks.Task<ItemAccountCode> AddItemAccountCodeAsync (ItemAccountCode body)
        {
             ApiResponse<ItemAccountCode> localVarResponse = await AddItemAccountCodeAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an itemAccountCode Inserts a new itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be inserted.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> AddItemAccountCodeAsyncWithHttpInfo (ItemAccountCode body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddItemAccountCode");
            
    
            var localVarPath = "/beta/itemAccountCode";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }
        
        /// <summary>
        /// Add new audit for an itemAccountCode Adds an audit to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param> 
        /// <param name="itemAccountCodeAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddItemAccountCodeAudit (int? itemAccountCodeId, string itemAccountCodeAudit)
        {
             AddItemAccountCodeAuditWithHttpInfo(itemAccountCodeId, itemAccountCodeAudit);
        }

        /// <summary>
        /// Add new audit for an itemAccountCode Adds an audit to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param> 
        /// <param name="itemAccountCodeAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemAccountCodeAuditWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeAudit)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->AddItemAccountCodeAudit");
            
            // verify the required parameter 'itemAccountCodeAudit' is set
            if (itemAccountCodeAudit == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeAudit' when calling ItemAccountCodeApi->AddItemAccountCodeAudit");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/audit/{itemAccountCodeAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            if (itemAccountCodeAudit != null) localVarPathParams.Add("itemAccountCodeAudit", Configuration.ApiClient.ParameterToString(itemAccountCodeAudit)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an itemAccountCode Adds an audit to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param>
        /// <param name="itemAccountCodeAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemAccountCodeAuditAsync (int? itemAccountCodeId, string itemAccountCodeAudit)
        {
             await AddItemAccountCodeAuditAsyncWithHttpInfo(itemAccountCodeId, itemAccountCodeAudit);

        }

        /// <summary>
        /// Add new audit for an itemAccountCode Adds an audit to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add an audit to</param>
        /// <param name="itemAccountCodeAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemAccountCodeAuditAsyncWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeAudit)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling AddItemAccountCodeAudit");
            // verify the required parameter 'itemAccountCodeAudit' is set
            if (itemAccountCodeAudit == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeAudit' when calling AddItemAccountCodeAudit");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/audit/{itemAccountCodeAudit}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            if (itemAccountCodeAudit != null) localVarPathParams.Add("itemAccountCodeAudit", Configuration.ApiClient.ParameterToString(itemAccountCodeAudit)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an itemAccountCode. Adds a tag to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param> 
        /// <param name="itemAccountCodeTag">The tag to add</param> 
        /// <returns></returns>
        public void AddItemAccountCodeTag (int? itemAccountCodeId, string itemAccountCodeTag)
        {
             AddItemAccountCodeTagWithHttpInfo(itemAccountCodeId, itemAccountCodeTag);
        }

        /// <summary>
        /// Add new tags for an itemAccountCode. Adds a tag to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param> 
        /// <param name="itemAccountCodeTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddItemAccountCodeTagWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->AddItemAccountCodeTag");
            
            // verify the required parameter 'itemAccountCodeTag' is set
            if (itemAccountCodeTag == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeTag' when calling ItemAccountCodeApi->AddItemAccountCodeTag");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/tag/{itemAccountCodeTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            if (itemAccountCodeTag != null) localVarPathParams.Add("itemAccountCodeTag", Configuration.ApiClient.ParameterToString(itemAccountCodeTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an itemAccountCode. Adds a tag to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param>
        /// <param name="itemAccountCodeTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddItemAccountCodeTagAsync (int? itemAccountCodeId, string itemAccountCodeTag)
        {
             await AddItemAccountCodeTagAsyncWithHttpInfo(itemAccountCodeId, itemAccountCodeTag);

        }

        /// <summary>
        /// Add new tags for an itemAccountCode. Adds a tag to an existing itemAccountCode.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to add a tag to</param>
        /// <param name="itemAccountCodeTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddItemAccountCodeTagAsyncWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling AddItemAccountCodeTag");
            // verify the required parameter 'itemAccountCodeTag' is set
            if (itemAccountCodeTag == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeTag' when calling AddItemAccountCodeTag");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/tag/{itemAccountCodeTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            if (itemAccountCodeTag != null) localVarPathParams.Add("itemAccountCodeTag", Configuration.ApiClient.ParameterToString(itemAccountCodeTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddItemAccountCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an itemAccountCode Deletes the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param> 
        /// <returns></returns>
        public void DeleteItemAccountCode (int? itemAccountCodeId)
        {
             DeleteItemAccountCodeWithHttpInfo(itemAccountCodeId);
        }

        /// <summary>
        /// Delete an itemAccountCode Deletes the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemAccountCodeWithHttpInfo (int? itemAccountCodeId)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->DeleteItemAccountCode");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an itemAccountCode Deletes the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemAccountCodeAsync (int? itemAccountCodeId)
        {
             await DeleteItemAccountCodeAsyncWithHttpInfo(itemAccountCodeId);

        }

        /// <summary>
        /// Delete an itemAccountCode Deletes the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemAccountCodeAsyncWithHttpInfo (int? itemAccountCodeId)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling DeleteItemAccountCode");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an itemAccountCode. Deletes an existing itemAccountCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param> 
        /// <param name="itemAccountCodeTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteItemAccountCodeTag (int? itemAccountCodeId, string itemAccountCodeTag)
        {
             DeleteItemAccountCodeTagWithHttpInfo(itemAccountCodeId, itemAccountCodeTag);
        }

        /// <summary>
        /// Delete a tag for an itemAccountCode. Deletes an existing itemAccountCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param> 
        /// <param name="itemAccountCodeTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteItemAccountCodeTagWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->DeleteItemAccountCodeTag");
            
            // verify the required parameter 'itemAccountCodeTag' is set
            if (itemAccountCodeTag == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeTag' when calling ItemAccountCodeApi->DeleteItemAccountCodeTag");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/tag/{itemAccountCodeTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            if (itemAccountCodeTag != null) localVarPathParams.Add("itemAccountCodeTag", Configuration.ApiClient.ParameterToString(itemAccountCodeTag)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an itemAccountCode. Deletes an existing itemAccountCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param>
        /// <param name="itemAccountCodeTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteItemAccountCodeTagAsync (int? itemAccountCodeId, string itemAccountCodeTag)
        {
             await DeleteItemAccountCodeTagAsyncWithHttpInfo(itemAccountCodeId, itemAccountCodeTag);

        }

        /// <summary>
        /// Delete a tag for an itemAccountCode. Deletes an existing itemAccountCode tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to remove tag from</param>
        /// <param name="itemAccountCodeTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteItemAccountCodeTagAsyncWithHttpInfo (int? itemAccountCodeId, string itemAccountCodeTag)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling DeleteItemAccountCodeTag");
            // verify the required parameter 'itemAccountCodeTag' is set
            if (itemAccountCodeTag == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeTag' when calling DeleteItemAccountCodeTag");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/tag/{itemAccountCodeTag}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            if (itemAccountCodeTag != null) localVarPathParams.Add("itemAccountCodeTag", Configuration.ApiClient.ParameterToString(itemAccountCodeTag)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCodeTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteItemAccountCodeTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an itemAccountCode by id Returns a duplicated itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param> 
        /// <returns>ItemAccountCode</returns>
        public ItemAccountCode GetDuplicateItemAccountCodeById (int? itemAccountCodeId)
        {
             ApiResponse<ItemAccountCode> localVarResponse = GetDuplicateItemAccountCodeByIdWithHttpInfo(itemAccountCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an itemAccountCode by id Returns a duplicated itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param> 
        /// <returns>ApiResponse of ItemAccountCode</returns>
        public ApiResponse< ItemAccountCode > GetDuplicateItemAccountCodeByIdWithHttpInfo (int? itemAccountCodeId)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->GetDuplicateItemAccountCodeById");
            
    
            var localVarPath = "/beta/itemAccountCode/duplicate/{itemAccountCodeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemAccountCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemAccountCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }

        
        /// <summary>
        /// Get a duplicated an itemAccountCode by id Returns a duplicated itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param>
        /// <returns>Task of ItemAccountCode</returns>
        public async System.Threading.Tasks.Task<ItemAccountCode> GetDuplicateItemAccountCodeByIdAsync (int? itemAccountCodeId)
        {
             ApiResponse<ItemAccountCode> localVarResponse = await GetDuplicateItemAccountCodeByIdAsyncWithHttpInfo(itemAccountCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an itemAccountCode by id Returns a duplicated itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be duplicated.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> GetDuplicateItemAccountCodeByIdAsyncWithHttpInfo (int? itemAccountCodeId)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling GetDuplicateItemAccountCodeById");
            
    
            var localVarPath = "/beta/itemAccountCode/duplicate/{itemAccountCodeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemAccountCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateItemAccountCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }
        
        /// <summary>
        /// Search itemAccountCodes by filter Returns the list of itemAccountCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ItemAccountCode&gt;</returns>
        public List<ItemAccountCode> GetItemAccountCodeByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemAccountCode>> localVarResponse = GetItemAccountCodeByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search itemAccountCodes by filter Returns the list of itemAccountCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ItemAccountCode&gt;</returns>
        public ApiResponse< List<ItemAccountCode> > GetItemAccountCodeByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemAccountCode/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ItemAccountCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemAccountCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemAccountCode>)));
            
        }

        
        /// <summary>
        /// Search itemAccountCodes by filter Returns the list of itemAccountCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ItemAccountCode&gt;</returns>
        public async System.Threading.Tasks.Task<List<ItemAccountCode>> GetItemAccountCodeByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ItemAccountCode>> localVarResponse = await GetItemAccountCodeByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search itemAccountCodes by filter Returns the list of itemAccountCodes that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ItemAccountCode&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ItemAccountCode>>> GetItemAccountCodeByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/itemAccountCode/search";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (filter != null) localVarQueryParams.Add("filter", Configuration.ApiClient.ParameterToString(filter)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ItemAccountCode>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ItemAccountCode>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ItemAccountCode>)));
            
        }
        
        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param> 
        /// <returns>ItemAccountCode</returns>
        public ItemAccountCode GetItemAccountCodeById (int? itemAccountCodeId)
        {
             ApiResponse<ItemAccountCode> localVarResponse = GetItemAccountCodeByIdWithHttpInfo(itemAccountCodeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param> 
        /// <returns>ApiResponse of ItemAccountCode</returns>
        public ApiResponse< ItemAccountCode > GetItemAccountCodeByIdWithHttpInfo (int? itemAccountCodeId)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->GetItemAccountCodeById");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }

        
        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param>
        /// <returns>Task of ItemAccountCode</returns>
        public async System.Threading.Tasks.Task<ItemAccountCode> GetItemAccountCodeByIdAsync (int? itemAccountCodeId)
        {
             ApiResponse<ItemAccountCode> localVarResponse = await GetItemAccountCodeByIdAsyncWithHttpInfo(itemAccountCodeId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an itemAccountCode by id Returns the itemAccountCode identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to be returned.</param>
        /// <returns>Task of ApiResponse (ItemAccountCode)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ItemAccountCode>> GetItemAccountCodeByIdAsyncWithHttpInfo (int? itemAccountCodeId)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling GetItemAccountCodeById");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ItemAccountCode>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ItemAccountCode) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ItemAccountCode)));
            
        }
        
        /// <summary>
        /// Get the tags for an itemAccountCode. Get all existing itemAccountCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param> 
        /// <returns></returns>
        public void GetItemAccountCodeTags (int? itemAccountCodeId)
        {
             GetItemAccountCodeTagsWithHttpInfo(itemAccountCodeId);
        }

        /// <summary>
        /// Get the tags for an itemAccountCode. Get all existing itemAccountCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetItemAccountCodeTagsWithHttpInfo (int? itemAccountCodeId)
        {
            
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null)
                throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling ItemAccountCodeApi->GetItemAccountCodeTags");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/tag";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an itemAccountCode. Get all existing itemAccountCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetItemAccountCodeTagsAsync (int? itemAccountCodeId)
        {
             await GetItemAccountCodeTagsAsyncWithHttpInfo(itemAccountCodeId);

        }

        /// <summary>
        /// Get the tags for an itemAccountCode. Get all existing itemAccountCode tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemAccountCodeId">Id of the itemAccountCode to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetItemAccountCodeTagsAsyncWithHttpInfo (int? itemAccountCodeId)
        {
            // verify the required parameter 'itemAccountCodeId' is set
            if (itemAccountCodeId == null) throw new ApiException(400, "Missing required parameter 'itemAccountCodeId' when calling GetItemAccountCodeTags");
            
    
            var localVarPath = "/beta/itemAccountCode/{itemAccountCodeId}/tag";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (itemAccountCodeId != null) localVarPathParams.Add("itemAccountCodeId", Configuration.ApiClient.ParameterToString(itemAccountCodeId)); // path parameter
            
            
            
            
            

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetItemAccountCodeTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an itemAccountCode Updates an existing itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param> 
        /// <returns></returns>
        public void UpdateItemAccountCode (ItemAccountCode body)
        {
             UpdateItemAccountCodeWithHttpInfo(body);
        }

        /// <summary>
        /// Update an itemAccountCode Updates an existing itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateItemAccountCodeWithHttpInfo (ItemAccountCode body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ItemAccountCodeApi->UpdateItemAccountCode");
            
    
            var localVarPath = "/beta/itemAccountCode";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemAccountCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemAccountCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an itemAccountCode Updates an existing itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateItemAccountCodeAsync (ItemAccountCode body)
        {
             await UpdateItemAccountCodeAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an itemAccountCode Updates an existing itemAccountCode using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ItemAccountCode to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateItemAccountCodeAsyncWithHttpInfo (ItemAccountCode body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateItemAccountCode");
            
    
            var localVarPath = "/beta/itemAccountCode";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
            // authentication (api_key) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemAccountCode: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateItemAccountCode: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
