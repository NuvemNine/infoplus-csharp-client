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
    public interface IInventorySnapshotApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for an inventorySnapshot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param>
        /// <param name="inventorySnapshotAudit">The audit to add</param>
        /// <returns></returns>
        void AddInventorySnapshotAudit (int? inventorySnapshotId, string inventorySnapshotAudit);
  
        /// <summary>
        /// Add new audit for an inventorySnapshot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param>
        /// <param name="inventorySnapshotAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventorySnapshotAuditWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotAudit);
        
        /// <summary>
        /// Add new tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param>
        /// <param name="inventorySnapshotTag">The tag to add</param>
        /// <returns></returns>
        void AddInventorySnapshotTag (int? inventorySnapshotId, string inventorySnapshotTag);
  
        /// <summary>
        /// Add new tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param>
        /// <param name="inventorySnapshotTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddInventorySnapshotTagWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag);
        
        /// <summary>
        /// Delete a tag for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventorySnapshot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param>
        /// <param name="inventorySnapshotTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteInventorySnapshotTag (int? inventorySnapshotId, string inventorySnapshotTag);
  
        /// <summary>
        /// Delete a tag for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventorySnapshot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param>
        /// <param name="inventorySnapshotTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteInventorySnapshotTagWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag);
        
        /// <summary>
        /// Get a duplicated an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param>
        /// <returns>InventorySnapshot</returns>
        InventorySnapshot GetDuplicateInventorySnapshotById (int? inventorySnapshotId);
  
        /// <summary>
        /// Get a duplicated an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param>
        /// <returns>ApiResponse of InventorySnapshot</returns>
        ApiResponse<InventorySnapshot> GetDuplicateInventorySnapshotByIdWithHttpInfo (int? inventorySnapshotId);
        
        /// <summary>
        /// Search inventorySnapshots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventorySnapshots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;InventorySnapshot&gt;</returns>
        List<InventorySnapshot> GetInventorySnapshotByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search inventorySnapshots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventorySnapshots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;InventorySnapshot&gt;</returns>
        ApiResponse<List<InventorySnapshot>> GetInventorySnapshotByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns the inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param>
        /// <returns>InventorySnapshot</returns>
        InventorySnapshot GetInventorySnapshotById (int? inventorySnapshotId);
  
        /// <summary>
        /// Get an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns the inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param>
        /// <returns>ApiResponse of InventorySnapshot</returns>
        ApiResponse<InventorySnapshot> GetInventorySnapshotByIdWithHttpInfo (int? inventorySnapshotId);
        
        /// <summary>
        /// Get the tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Get all existing inventorySnapshot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param>
        /// <returns></returns>
        void GetInventorySnapshotTags (int? inventorySnapshotId);
  
        /// <summary>
        /// Get the tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Get all existing inventorySnapshot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetInventorySnapshotTagsWithHttpInfo (int? inventorySnapshotId);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for an inventorySnapshot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param>
        /// <param name="inventorySnapshotAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventorySnapshotAuditAsync (int? inventorySnapshotId, string inventorySnapshotAudit);

        /// <summary>
        /// Add new audit for an inventorySnapshot
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param>
        /// <param name="inventorySnapshotAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventorySnapshotAuditAsyncWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotAudit);
        
        /// <summary>
        /// Add new tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param>
        /// <param name="inventorySnapshotTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddInventorySnapshotTagAsync (int? inventorySnapshotId, string inventorySnapshotTag);

        /// <summary>
        /// Add new tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing inventorySnapshot.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param>
        /// <param name="inventorySnapshotTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddInventorySnapshotTagAsyncWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag);
        
        /// <summary>
        /// Delete a tag for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventorySnapshot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param>
        /// <param name="inventorySnapshotTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteInventorySnapshotTagAsync (int? inventorySnapshotId, string inventorySnapshotTag);

        /// <summary>
        /// Delete a tag for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Deletes an existing inventorySnapshot tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param>
        /// <param name="inventorySnapshotTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventorySnapshotTagAsyncWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag);
        
        /// <summary>
        /// Get a duplicated an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param>
        /// <returns>Task of InventorySnapshot</returns>
        System.Threading.Tasks.Task<InventorySnapshot> GetDuplicateInventorySnapshotByIdAsync (int? inventorySnapshotId);

        /// <summary>
        /// Get a duplicated an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventorySnapshot)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventorySnapshot>> GetDuplicateInventorySnapshotByIdAsyncWithHttpInfo (int? inventorySnapshotId);
        
        /// <summary>
        /// Search inventorySnapshots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventorySnapshots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventorySnapshot&gt;</returns>
        System.Threading.Tasks.Task<List<InventorySnapshot>> GetInventorySnapshotByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search inventorySnapshots by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of inventorySnapshots that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventorySnapshot&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<InventorySnapshot>>> GetInventorySnapshotByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns the inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param>
        /// <returns>Task of InventorySnapshot</returns>
        System.Threading.Tasks.Task<InventorySnapshot> GetInventorySnapshotByIdAsync (int? inventorySnapshotId);

        /// <summary>
        /// Get an inventorySnapshot by id
        /// </summary>
        /// <remarks>
        /// Returns the inventorySnapshot identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param>
        /// <returns>Task of ApiResponse (InventorySnapshot)</returns>
        System.Threading.Tasks.Task<ApiResponse<InventorySnapshot>> GetInventorySnapshotByIdAsyncWithHttpInfo (int? inventorySnapshotId);
        
        /// <summary>
        /// Get the tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Get all existing inventorySnapshot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetInventorySnapshotTagsAsync (int? inventorySnapshotId);

        /// <summary>
        /// Get the tags for an inventorySnapshot.
        /// </summary>
        /// <remarks>
        /// Get all existing inventorySnapshot tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetInventorySnapshotTagsAsyncWithHttpInfo (int? inventorySnapshotId);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InventorySnapshotApi : IInventorySnapshotApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySnapshotApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InventorySnapshotApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InventorySnapshotApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InventorySnapshotApi(Configuration configuration = null)
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
        /// Add new audit for an inventorySnapshot Adds an audit to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param> 
        /// <param name="inventorySnapshotAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddInventorySnapshotAudit (int? inventorySnapshotId, string inventorySnapshotAudit)
        {
             AddInventorySnapshotAuditWithHttpInfo(inventorySnapshotId, inventorySnapshotAudit);
        }

        /// <summary>
        /// Add new audit for an inventorySnapshot Adds an audit to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param> 
        /// <param name="inventorySnapshotAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventorySnapshotAuditWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotAudit)
        {
            
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling InventorySnapshotApi->AddInventorySnapshotAudit");
            
            // verify the required parameter 'inventorySnapshotAudit' is set
            if (inventorySnapshotAudit == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotAudit' when calling InventorySnapshotApi->AddInventorySnapshotAudit");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/audit/{inventorySnapshotAudit}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            if (inventorySnapshotAudit != null) localVarPathParams.Add("inventorySnapshotAudit", Configuration.ApiClient.ParameterToString(inventorySnapshotAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an inventorySnapshot Adds an audit to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param>
        /// <param name="inventorySnapshotAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventorySnapshotAuditAsync (int? inventorySnapshotId, string inventorySnapshotAudit)
        {
             await AddInventorySnapshotAuditAsyncWithHttpInfo(inventorySnapshotId, inventorySnapshotAudit);

        }

        /// <summary>
        /// Add new audit for an inventorySnapshot Adds an audit to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add an audit to</param>
        /// <param name="inventorySnapshotAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventorySnapshotAuditAsyncWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotAudit)
        {
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling AddInventorySnapshotAudit");
            // verify the required parameter 'inventorySnapshotAudit' is set
            if (inventorySnapshotAudit == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotAudit' when calling AddInventorySnapshotAudit");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/audit/{inventorySnapshotAudit}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            if (inventorySnapshotAudit != null) localVarPathParams.Add("inventorySnapshotAudit", Configuration.ApiClient.ParameterToString(inventorySnapshotAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an inventorySnapshot. Adds a tag to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param> 
        /// <param name="inventorySnapshotTag">The tag to add</param> 
        /// <returns></returns>
        public void AddInventorySnapshotTag (int? inventorySnapshotId, string inventorySnapshotTag)
        {
             AddInventorySnapshotTagWithHttpInfo(inventorySnapshotId, inventorySnapshotTag);
        }

        /// <summary>
        /// Add new tags for an inventorySnapshot. Adds a tag to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param> 
        /// <param name="inventorySnapshotTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddInventorySnapshotTagWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag)
        {
            
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling InventorySnapshotApi->AddInventorySnapshotTag");
            
            // verify the required parameter 'inventorySnapshotTag' is set
            if (inventorySnapshotTag == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotTag' when calling InventorySnapshotApi->AddInventorySnapshotTag");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/tag/{inventorySnapshotTag}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            if (inventorySnapshotTag != null) localVarPathParams.Add("inventorySnapshotTag", Configuration.ApiClient.ParameterToString(inventorySnapshotTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an inventorySnapshot. Adds a tag to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param>
        /// <param name="inventorySnapshotTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddInventorySnapshotTagAsync (int? inventorySnapshotId, string inventorySnapshotTag)
        {
             await AddInventorySnapshotTagAsyncWithHttpInfo(inventorySnapshotId, inventorySnapshotTag);

        }

        /// <summary>
        /// Add new tags for an inventorySnapshot. Adds a tag to an existing inventorySnapshot.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to add a tag to</param>
        /// <param name="inventorySnapshotTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddInventorySnapshotTagAsyncWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag)
        {
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling AddInventorySnapshotTag");
            // verify the required parameter 'inventorySnapshotTag' is set
            if (inventorySnapshotTag == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotTag' when calling AddInventorySnapshotTag");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/tag/{inventorySnapshotTag}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            if (inventorySnapshotTag != null) localVarPathParams.Add("inventorySnapshotTag", Configuration.ApiClient.ParameterToString(inventorySnapshotTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddInventorySnapshotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an inventorySnapshot. Deletes an existing inventorySnapshot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param> 
        /// <param name="inventorySnapshotTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteInventorySnapshotTag (int? inventorySnapshotId, string inventorySnapshotTag)
        {
             DeleteInventorySnapshotTagWithHttpInfo(inventorySnapshotId, inventorySnapshotTag);
        }

        /// <summary>
        /// Delete a tag for an inventorySnapshot. Deletes an existing inventorySnapshot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param> 
        /// <param name="inventorySnapshotTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteInventorySnapshotTagWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag)
        {
            
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling InventorySnapshotApi->DeleteInventorySnapshotTag");
            
            // verify the required parameter 'inventorySnapshotTag' is set
            if (inventorySnapshotTag == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotTag' when calling InventorySnapshotApi->DeleteInventorySnapshotTag");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/tag/{inventorySnapshotTag}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            if (inventorySnapshotTag != null) localVarPathParams.Add("inventorySnapshotTag", Configuration.ApiClient.ParameterToString(inventorySnapshotTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventorySnapshotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventorySnapshotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an inventorySnapshot. Deletes an existing inventorySnapshot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param>
        /// <param name="inventorySnapshotTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteInventorySnapshotTagAsync (int? inventorySnapshotId, string inventorySnapshotTag)
        {
             await DeleteInventorySnapshotTagAsyncWithHttpInfo(inventorySnapshotId, inventorySnapshotTag);

        }

        /// <summary>
        /// Delete a tag for an inventorySnapshot. Deletes an existing inventorySnapshot tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to remove tag from</param>
        /// <param name="inventorySnapshotTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteInventorySnapshotTagAsyncWithHttpInfo (int? inventorySnapshotId, string inventorySnapshotTag)
        {
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling DeleteInventorySnapshotTag");
            // verify the required parameter 'inventorySnapshotTag' is set
            if (inventorySnapshotTag == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotTag' when calling DeleteInventorySnapshotTag");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/tag/{inventorySnapshotTag}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            if (inventorySnapshotTag != null) localVarPathParams.Add("inventorySnapshotTag", Configuration.ApiClient.ParameterToString(inventorySnapshotTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventorySnapshotTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteInventorySnapshotTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an inventorySnapshot by id Returns a duplicated inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param> 
        /// <returns>InventorySnapshot</returns>
        public InventorySnapshot GetDuplicateInventorySnapshotById (int? inventorySnapshotId)
        {
             ApiResponse<InventorySnapshot> localVarResponse = GetDuplicateInventorySnapshotByIdWithHttpInfo(inventorySnapshotId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an inventorySnapshot by id Returns a duplicated inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param> 
        /// <returns>ApiResponse of InventorySnapshot</returns>
        public ApiResponse< InventorySnapshot > GetDuplicateInventorySnapshotByIdWithHttpInfo (int? inventorySnapshotId)
        {
            
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling InventorySnapshotApi->GetDuplicateInventorySnapshotById");
            
    
            var localVarPath = "/beta/inventorySnapshot/duplicate/{inventorySnapshotId}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventorySnapshotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventorySnapshotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventorySnapshot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventorySnapshot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventorySnapshot)));
            
        }

        
        /// <summary>
        /// Get a duplicated an inventorySnapshot by id Returns a duplicated inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param>
        /// <returns>Task of InventorySnapshot</returns>
        public async System.Threading.Tasks.Task<InventorySnapshot> GetDuplicateInventorySnapshotByIdAsync (int? inventorySnapshotId)
        {
             ApiResponse<InventorySnapshot> localVarResponse = await GetDuplicateInventorySnapshotByIdAsyncWithHttpInfo(inventorySnapshotId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an inventorySnapshot by id Returns a duplicated inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be duplicated.</param>
        /// <returns>Task of ApiResponse (InventorySnapshot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventorySnapshot>> GetDuplicateInventorySnapshotByIdAsyncWithHttpInfo (int? inventorySnapshotId)
        {
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling GetDuplicateInventorySnapshotById");
            
    
            var localVarPath = "/beta/inventorySnapshot/duplicate/{inventorySnapshotId}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventorySnapshotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateInventorySnapshotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventorySnapshot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventorySnapshot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventorySnapshot)));
            
        }
        
        /// <summary>
        /// Search inventorySnapshots by filter Returns the list of inventorySnapshots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;InventorySnapshot&gt;</returns>
        public List<InventorySnapshot> GetInventorySnapshotByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventorySnapshot>> localVarResponse = GetInventorySnapshotByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search inventorySnapshots by filter Returns the list of inventorySnapshots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;InventorySnapshot&gt;</returns>
        public ApiResponse< List<InventorySnapshot> > GetInventorySnapshotByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventorySnapshot/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<InventorySnapshot>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventorySnapshot>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventorySnapshot>)));
            
        }

        
        /// <summary>
        /// Search inventorySnapshots by filter Returns the list of inventorySnapshots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;InventorySnapshot&gt;</returns>
        public async System.Threading.Tasks.Task<List<InventorySnapshot>> GetInventorySnapshotByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<InventorySnapshot>> localVarResponse = await GetInventorySnapshotByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search inventorySnapshots by filter Returns the list of inventorySnapshots that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;InventorySnapshot&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<InventorySnapshot>>> GetInventorySnapshotByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/inventorySnapshot/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<InventorySnapshot>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<InventorySnapshot>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<InventorySnapshot>)));
            
        }
        
        /// <summary>
        /// Get an inventorySnapshot by id Returns the inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param> 
        /// <returns>InventorySnapshot</returns>
        public InventorySnapshot GetInventorySnapshotById (int? inventorySnapshotId)
        {
             ApiResponse<InventorySnapshot> localVarResponse = GetInventorySnapshotByIdWithHttpInfo(inventorySnapshotId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an inventorySnapshot by id Returns the inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param> 
        /// <returns>ApiResponse of InventorySnapshot</returns>
        public ApiResponse< InventorySnapshot > GetInventorySnapshotByIdWithHttpInfo (int? inventorySnapshotId)
        {
            
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling InventorySnapshotApi->GetInventorySnapshotById");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<InventorySnapshot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventorySnapshot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventorySnapshot)));
            
        }

        
        /// <summary>
        /// Get an inventorySnapshot by id Returns the inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param>
        /// <returns>Task of InventorySnapshot</returns>
        public async System.Threading.Tasks.Task<InventorySnapshot> GetInventorySnapshotByIdAsync (int? inventorySnapshotId)
        {
             ApiResponse<InventorySnapshot> localVarResponse = await GetInventorySnapshotByIdAsyncWithHttpInfo(inventorySnapshotId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an inventorySnapshot by id Returns the inventorySnapshot identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to be returned.</param>
        /// <returns>Task of ApiResponse (InventorySnapshot)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InventorySnapshot>> GetInventorySnapshotByIdAsyncWithHttpInfo (int? inventorySnapshotId)
        {
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling GetInventorySnapshotById");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<InventorySnapshot>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InventorySnapshot) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InventorySnapshot)));
            
        }
        
        /// <summary>
        /// Get the tags for an inventorySnapshot. Get all existing inventorySnapshot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param> 
        /// <returns></returns>
        public void GetInventorySnapshotTags (int? inventorySnapshotId)
        {
             GetInventorySnapshotTagsWithHttpInfo(inventorySnapshotId);
        }

        /// <summary>
        /// Get the tags for an inventorySnapshot. Get all existing inventorySnapshot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetInventorySnapshotTagsWithHttpInfo (int? inventorySnapshotId)
        {
            
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null)
                throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling InventorySnapshotApi->GetInventorySnapshotTags");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/tag";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an inventorySnapshot. Get all existing inventorySnapshot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetInventorySnapshotTagsAsync (int? inventorySnapshotId)
        {
             await GetInventorySnapshotTagsAsyncWithHttpInfo(inventorySnapshotId);

        }

        /// <summary>
        /// Get the tags for an inventorySnapshot. Get all existing inventorySnapshot tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inventorySnapshotId">Id of the inventorySnapshot to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetInventorySnapshotTagsAsyncWithHttpInfo (int? inventorySnapshotId)
        {
            // verify the required parameter 'inventorySnapshotId' is set
            if (inventorySnapshotId == null) throw new ApiException(400, "Missing required parameter 'inventorySnapshotId' when calling GetInventorySnapshotTags");
            
    
            var localVarPath = "/beta/inventorySnapshot/{inventorySnapshotId}/tag";
    
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
            if (inventorySnapshotId != null) localVarPathParams.Add("inventorySnapshotId", Configuration.ApiClient.ParameterToString(inventorySnapshotId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetInventorySnapshotTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
