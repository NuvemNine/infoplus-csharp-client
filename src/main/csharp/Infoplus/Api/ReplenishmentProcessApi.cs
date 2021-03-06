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
    public interface IReplenishmentProcessApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Add new audit for a replenishmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param>
        /// <param name="replenishmentProcessAudit">The audit to add</param>
        /// <returns></returns>
        void AddReplenishmentProcessAudit (int? replenishmentProcessId, string replenishmentProcessAudit);
  
        /// <summary>
        /// Add new audit for a replenishmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param>
        /// <param name="replenishmentProcessAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReplenishmentProcessAuditWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessAudit);
        
        /// <summary>
        /// Add new tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param>
        /// <param name="replenishmentProcessTag">The tag to add</param>
        /// <returns></returns>
        void AddReplenishmentProcessTag (int? replenishmentProcessId, string replenishmentProcessTag);
  
        /// <summary>
        /// Add new tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param>
        /// <param name="replenishmentProcessTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReplenishmentProcessTagWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag);
        
        /// <summary>
        /// Delete a tag for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param>
        /// <param name="replenishmentProcessTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteReplenishmentProcessTag (int? replenishmentProcessId, string replenishmentProcessTag);
  
        /// <summary>
        /// Delete a tag for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param>
        /// <param name="replenishmentProcessTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteReplenishmentProcessTagWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag);
        
        /// <summary>
        /// Get a duplicated a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param>
        /// <returns>ReplenishmentProcess</returns>
        ReplenishmentProcess GetDuplicateReplenishmentProcessById (int? replenishmentProcessId);
  
        /// <summary>
        /// Get a duplicated a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param>
        /// <returns>ApiResponse of ReplenishmentProcess</returns>
        ApiResponse<ReplenishmentProcess> GetDuplicateReplenishmentProcessByIdWithHttpInfo (int? replenishmentProcessId);
        
        /// <summary>
        /// Search replenishmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ReplenishmentProcess&gt;</returns>
        List<ReplenishmentProcess> GetReplenishmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search replenishmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ReplenishmentProcess&gt;</returns>
        ApiResponse<List<ReplenishmentProcess>> GetReplenishmentProcessByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param>
        /// <returns>ReplenishmentProcess</returns>
        ReplenishmentProcess GetReplenishmentProcessById (int? replenishmentProcessId);
  
        /// <summary>
        /// Get a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param>
        /// <returns>ApiResponse of ReplenishmentProcess</returns>
        ApiResponse<ReplenishmentProcess> GetReplenishmentProcessByIdWithHttpInfo (int? replenishmentProcessId);
        
        /// <summary>
        /// Get the tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param>
        /// <returns></returns>
        void GetReplenishmentProcessTags (int? replenishmentProcessId);
  
        /// <summary>
        /// Get the tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetReplenishmentProcessTagsWithHttpInfo (int? replenishmentProcessId);
        
        /// <summary>
        /// Update a replenishmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param>
        /// <returns></returns>
        void UpdateReplenishmentProcessCustomFields (ReplenishmentProcess body);
  
        /// <summary>
        /// Update a replenishmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateReplenishmentProcessCustomFieldsWithHttpInfo (ReplenishmentProcess body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Add new audit for a replenishmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param>
        /// <param name="replenishmentProcessAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReplenishmentProcessAuditAsync (int? replenishmentProcessId, string replenishmentProcessAudit);

        /// <summary>
        /// Add new audit for a replenishmentProcess
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param>
        /// <param name="replenishmentProcessAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentProcessAuditAsyncWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessAudit);
        
        /// <summary>
        /// Add new tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param>
        /// <param name="replenishmentProcessTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReplenishmentProcessTagAsync (int? replenishmentProcessId, string replenishmentProcessTag);

        /// <summary>
        /// Add new tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing replenishmentProcess.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param>
        /// <param name="replenishmentProcessTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentProcessTagAsyncWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag);
        
        /// <summary>
        /// Delete a tag for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param>
        /// <param name="replenishmentProcessTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteReplenishmentProcessTagAsync (int? replenishmentProcessId, string replenishmentProcessTag);

        /// <summary>
        /// Delete a tag for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Deletes an existing replenishmentProcess tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param>
        /// <param name="replenishmentProcessTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReplenishmentProcessTagAsyncWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag);
        
        /// <summary>
        /// Get a duplicated a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param>
        /// <returns>Task of ReplenishmentProcess</returns>
        System.Threading.Tasks.Task<ReplenishmentProcess> GetDuplicateReplenishmentProcessByIdAsync (int? replenishmentProcessId);

        /// <summary>
        /// Get a duplicated a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param>
        /// <returns>Task of ApiResponse (ReplenishmentProcess)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReplenishmentProcess>> GetDuplicateReplenishmentProcessByIdAsyncWithHttpInfo (int? replenishmentProcessId);
        
        /// <summary>
        /// Search replenishmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ReplenishmentProcess&gt;</returns>
        System.Threading.Tasks.Task<List<ReplenishmentProcess>> GetReplenishmentProcessByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search replenishmentProcesses by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of replenishmentProcesses that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ReplenishmentProcess&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ReplenishmentProcess>>> GetReplenishmentProcessByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param>
        /// <returns>Task of ReplenishmentProcess</returns>
        System.Threading.Tasks.Task<ReplenishmentProcess> GetReplenishmentProcessByIdAsync (int? replenishmentProcessId);

        /// <summary>
        /// Get a replenishmentProcess by id
        /// </summary>
        /// <remarks>
        /// Returns the replenishmentProcess identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param>
        /// <returns>Task of ApiResponse (ReplenishmentProcess)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReplenishmentProcess>> GetReplenishmentProcessByIdAsyncWithHttpInfo (int? replenishmentProcessId);
        
        /// <summary>
        /// Get the tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetReplenishmentProcessTagsAsync (int? replenishmentProcessId);

        /// <summary>
        /// Get the tags for a replenishmentProcess.
        /// </summary>
        /// <remarks>
        /// Get all existing replenishmentProcess tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetReplenishmentProcessTagsAsyncWithHttpInfo (int? replenishmentProcessId);
        
        /// <summary>
        /// Update a replenishmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateReplenishmentProcessCustomFieldsAsync (ReplenishmentProcess body);

        /// <summary>
        /// Update a replenishmentProcess custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing replenishmentProcess custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReplenishmentProcessCustomFieldsAsyncWithHttpInfo (ReplenishmentProcess body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReplenishmentProcessApi : IReplenishmentProcessApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplenishmentProcessApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReplenishmentProcessApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplenishmentProcessApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReplenishmentProcessApi(Configuration configuration = null)
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
        /// Add new audit for a replenishmentProcess Adds an audit to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param> 
        /// <param name="replenishmentProcessAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddReplenishmentProcessAudit (int? replenishmentProcessId, string replenishmentProcessAudit)
        {
             AddReplenishmentProcessAuditWithHttpInfo(replenishmentProcessId, replenishmentProcessAudit);
        }

        /// <summary>
        /// Add new audit for a replenishmentProcess Adds an audit to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param> 
        /// <param name="replenishmentProcessAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReplenishmentProcessAuditWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessAudit)
        {
            
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling ReplenishmentProcessApi->AddReplenishmentProcessAudit");
            
            // verify the required parameter 'replenishmentProcessAudit' is set
            if (replenishmentProcessAudit == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessAudit' when calling ReplenishmentProcessApi->AddReplenishmentProcessAudit");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/audit/{replenishmentProcessAudit}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            if (replenishmentProcessAudit != null) localVarPathParams.Add("replenishmentProcessAudit", Configuration.ApiClient.ParameterToString(replenishmentProcessAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a replenishmentProcess Adds an audit to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param>
        /// <param name="replenishmentProcessAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReplenishmentProcessAuditAsync (int? replenishmentProcessId, string replenishmentProcessAudit)
        {
             await AddReplenishmentProcessAuditAsyncWithHttpInfo(replenishmentProcessId, replenishmentProcessAudit);

        }

        /// <summary>
        /// Add new audit for a replenishmentProcess Adds an audit to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add an audit to</param>
        /// <param name="replenishmentProcessAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentProcessAuditAsyncWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessAudit)
        {
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling AddReplenishmentProcessAudit");
            // verify the required parameter 'replenishmentProcessAudit' is set
            if (replenishmentProcessAudit == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessAudit' when calling AddReplenishmentProcessAudit");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/audit/{replenishmentProcessAudit}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            if (replenishmentProcessAudit != null) localVarPathParams.Add("replenishmentProcessAudit", Configuration.ApiClient.ParameterToString(replenishmentProcessAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a replenishmentProcess. Adds a tag to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param> 
        /// <param name="replenishmentProcessTag">The tag to add</param> 
        /// <returns></returns>
        public void AddReplenishmentProcessTag (int? replenishmentProcessId, string replenishmentProcessTag)
        {
             AddReplenishmentProcessTagWithHttpInfo(replenishmentProcessId, replenishmentProcessTag);
        }

        /// <summary>
        /// Add new tags for a replenishmentProcess. Adds a tag to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param> 
        /// <param name="replenishmentProcessTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReplenishmentProcessTagWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag)
        {
            
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling ReplenishmentProcessApi->AddReplenishmentProcessTag");
            
            // verify the required parameter 'replenishmentProcessTag' is set
            if (replenishmentProcessTag == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessTag' when calling ReplenishmentProcessApi->AddReplenishmentProcessTag");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/tag/{replenishmentProcessTag}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            if (replenishmentProcessTag != null) localVarPathParams.Add("replenishmentProcessTag", Configuration.ApiClient.ParameterToString(replenishmentProcessTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a replenishmentProcess. Adds a tag to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param>
        /// <param name="replenishmentProcessTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReplenishmentProcessTagAsync (int? replenishmentProcessId, string replenishmentProcessTag)
        {
             await AddReplenishmentProcessTagAsyncWithHttpInfo(replenishmentProcessId, replenishmentProcessTag);

        }

        /// <summary>
        /// Add new tags for a replenishmentProcess. Adds a tag to an existing replenishmentProcess.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to add a tag to</param>
        /// <param name="replenishmentProcessTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReplenishmentProcessTagAsyncWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag)
        {
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling AddReplenishmentProcessTag");
            // verify the required parameter 'replenishmentProcessTag' is set
            if (replenishmentProcessTag == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessTag' when calling AddReplenishmentProcessTag");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/tag/{replenishmentProcessTag}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            if (replenishmentProcessTag != null) localVarPathParams.Add("replenishmentProcessTag", Configuration.ApiClient.ParameterToString(replenishmentProcessTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReplenishmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a replenishmentProcess. Deletes an existing replenishmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param> 
        /// <param name="replenishmentProcessTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteReplenishmentProcessTag (int? replenishmentProcessId, string replenishmentProcessTag)
        {
             DeleteReplenishmentProcessTagWithHttpInfo(replenishmentProcessId, replenishmentProcessTag);
        }

        /// <summary>
        /// Delete a tag for a replenishmentProcess. Deletes an existing replenishmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param> 
        /// <param name="replenishmentProcessTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteReplenishmentProcessTagWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag)
        {
            
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling ReplenishmentProcessApi->DeleteReplenishmentProcessTag");
            
            // verify the required parameter 'replenishmentProcessTag' is set
            if (replenishmentProcessTag == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessTag' when calling ReplenishmentProcessApi->DeleteReplenishmentProcessTag");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/tag/{replenishmentProcessTag}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            if (replenishmentProcessTag != null) localVarPathParams.Add("replenishmentProcessTag", Configuration.ApiClient.ParameterToString(replenishmentProcessTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a replenishmentProcess. Deletes an existing replenishmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param>
        /// <param name="replenishmentProcessTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteReplenishmentProcessTagAsync (int? replenishmentProcessId, string replenishmentProcessTag)
        {
             await DeleteReplenishmentProcessTagAsyncWithHttpInfo(replenishmentProcessId, replenishmentProcessTag);

        }

        /// <summary>
        /// Delete a tag for a replenishmentProcess. Deletes an existing replenishmentProcess tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to remove tag from</param>
        /// <param name="replenishmentProcessTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReplenishmentProcessTagAsyncWithHttpInfo (int? replenishmentProcessId, string replenishmentProcessTag)
        {
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling DeleteReplenishmentProcessTag");
            // verify the required parameter 'replenishmentProcessTag' is set
            if (replenishmentProcessTag == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessTag' when calling DeleteReplenishmentProcessTag");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/tag/{replenishmentProcessTag}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            if (replenishmentProcessTag != null) localVarPathParams.Add("replenishmentProcessTag", Configuration.ApiClient.ParameterToString(replenishmentProcessTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentProcessTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReplenishmentProcessTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a replenishmentProcess by id Returns a duplicated replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param> 
        /// <returns>ReplenishmentProcess</returns>
        public ReplenishmentProcess GetDuplicateReplenishmentProcessById (int? replenishmentProcessId)
        {
             ApiResponse<ReplenishmentProcess> localVarResponse = GetDuplicateReplenishmentProcessByIdWithHttpInfo(replenishmentProcessId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a replenishmentProcess by id Returns a duplicated replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param> 
        /// <returns>ApiResponse of ReplenishmentProcess</returns>
        public ApiResponse< ReplenishmentProcess > GetDuplicateReplenishmentProcessByIdWithHttpInfo (int? replenishmentProcessId)
        {
            
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling ReplenishmentProcessApi->GetDuplicateReplenishmentProcessById");
            
    
            var localVarPath = "/beta/replenishmentProcess/duplicate/{replenishmentProcessId}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReplenishmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplenishmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplenishmentProcess)));
            
        }

        
        /// <summary>
        /// Get a duplicated a replenishmentProcess by id Returns a duplicated replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param>
        /// <returns>Task of ReplenishmentProcess</returns>
        public async System.Threading.Tasks.Task<ReplenishmentProcess> GetDuplicateReplenishmentProcessByIdAsync (int? replenishmentProcessId)
        {
             ApiResponse<ReplenishmentProcess> localVarResponse = await GetDuplicateReplenishmentProcessByIdAsyncWithHttpInfo(replenishmentProcessId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a replenishmentProcess by id Returns a duplicated replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be duplicated.</param>
        /// <returns>Task of ApiResponse (ReplenishmentProcess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReplenishmentProcess>> GetDuplicateReplenishmentProcessByIdAsyncWithHttpInfo (int? replenishmentProcessId)
        {
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling GetDuplicateReplenishmentProcessById");
            
    
            var localVarPath = "/beta/replenishmentProcess/duplicate/{replenishmentProcessId}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReplenishmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplenishmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplenishmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplenishmentProcess)));
            
        }
        
        /// <summary>
        /// Search replenishmentProcesses by filter Returns the list of replenishmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ReplenishmentProcess&gt;</returns>
        public List<ReplenishmentProcess> GetReplenishmentProcessByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ReplenishmentProcess>> localVarResponse = GetReplenishmentProcessByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search replenishmentProcesses by filter Returns the list of replenishmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ReplenishmentProcess&gt;</returns>
        public ApiResponse< List<ReplenishmentProcess> > GetReplenishmentProcessByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/replenishmentProcess/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ReplenishmentProcess>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ReplenishmentProcess>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReplenishmentProcess>)));
            
        }

        
        /// <summary>
        /// Search replenishmentProcesses by filter Returns the list of replenishmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ReplenishmentProcess&gt;</returns>
        public async System.Threading.Tasks.Task<List<ReplenishmentProcess>> GetReplenishmentProcessByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ReplenishmentProcess>> localVarResponse = await GetReplenishmentProcessByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search replenishmentProcesses by filter Returns the list of replenishmentProcesses that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ReplenishmentProcess&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ReplenishmentProcess>>> GetReplenishmentProcessByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/replenishmentProcess/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ReplenishmentProcess>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ReplenishmentProcess>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReplenishmentProcess>)));
            
        }
        
        /// <summary>
        /// Get a replenishmentProcess by id Returns the replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param> 
        /// <returns>ReplenishmentProcess</returns>
        public ReplenishmentProcess GetReplenishmentProcessById (int? replenishmentProcessId)
        {
             ApiResponse<ReplenishmentProcess> localVarResponse = GetReplenishmentProcessByIdWithHttpInfo(replenishmentProcessId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a replenishmentProcess by id Returns the replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param> 
        /// <returns>ApiResponse of ReplenishmentProcess</returns>
        public ApiResponse< ReplenishmentProcess > GetReplenishmentProcessByIdWithHttpInfo (int? replenishmentProcessId)
        {
            
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling ReplenishmentProcessApi->GetReplenishmentProcessById");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReplenishmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplenishmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplenishmentProcess)));
            
        }

        
        /// <summary>
        /// Get a replenishmentProcess by id Returns the replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param>
        /// <returns>Task of ReplenishmentProcess</returns>
        public async System.Threading.Tasks.Task<ReplenishmentProcess> GetReplenishmentProcessByIdAsync (int? replenishmentProcessId)
        {
             ApiResponse<ReplenishmentProcess> localVarResponse = await GetReplenishmentProcessByIdAsyncWithHttpInfo(replenishmentProcessId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a replenishmentProcess by id Returns the replenishmentProcess identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to be returned.</param>
        /// <returns>Task of ApiResponse (ReplenishmentProcess)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReplenishmentProcess>> GetReplenishmentProcessByIdAsyncWithHttpInfo (int? replenishmentProcessId)
        {
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling GetReplenishmentProcessById");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReplenishmentProcess>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReplenishmentProcess) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReplenishmentProcess)));
            
        }
        
        /// <summary>
        /// Get the tags for a replenishmentProcess. Get all existing replenishmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param> 
        /// <returns></returns>
        public void GetReplenishmentProcessTags (int? replenishmentProcessId)
        {
             GetReplenishmentProcessTagsWithHttpInfo(replenishmentProcessId);
        }

        /// <summary>
        /// Get the tags for a replenishmentProcess. Get all existing replenishmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetReplenishmentProcessTagsWithHttpInfo (int? replenishmentProcessId)
        {
            
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null)
                throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling ReplenishmentProcessApi->GetReplenishmentProcessTags");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/tag";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a replenishmentProcess. Get all existing replenishmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetReplenishmentProcessTagsAsync (int? replenishmentProcessId)
        {
             await GetReplenishmentProcessTagsAsyncWithHttpInfo(replenishmentProcessId);

        }

        /// <summary>
        /// Get the tags for a replenishmentProcess. Get all existing replenishmentProcess tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="replenishmentProcessId">Id of the replenishmentProcess to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetReplenishmentProcessTagsAsyncWithHttpInfo (int? replenishmentProcessId)
        {
            // verify the required parameter 'replenishmentProcessId' is set
            if (replenishmentProcessId == null) throw new ApiException(400, "Missing required parameter 'replenishmentProcessId' when calling GetReplenishmentProcessTags");
            
    
            var localVarPath = "/beta/replenishmentProcess/{replenishmentProcessId}/tag";
    
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
            if (replenishmentProcessId != null) localVarPathParams.Add("replenishmentProcessId", Configuration.ApiClient.ParameterToString(replenishmentProcessId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReplenishmentProcessTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a replenishmentProcess custom fields Updates an existing replenishmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param> 
        /// <returns></returns>
        public void UpdateReplenishmentProcessCustomFields (ReplenishmentProcess body)
        {
             UpdateReplenishmentProcessCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a replenishmentProcess custom fields Updates an existing replenishmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateReplenishmentProcessCustomFieldsWithHttpInfo (ReplenishmentProcess body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReplenishmentProcessApi->UpdateReplenishmentProcessCustomFields");
            
    
            var localVarPath = "/beta/replenishmentProcess/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentProcessCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentProcessCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a replenishmentProcess custom fields Updates an existing replenishmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateReplenishmentProcessCustomFieldsAsync (ReplenishmentProcess body)
        {
             await UpdateReplenishmentProcessCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a replenishmentProcess custom fields Updates an existing replenishmentProcess custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReplenishmentProcess to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReplenishmentProcessCustomFieldsAsyncWithHttpInfo (ReplenishmentProcess body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateReplenishmentProcessCustomFields");
            
    
            var localVarPath = "/beta/replenishmentProcess/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentProcessCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReplenishmentProcessCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
