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
    public interface IBillingCodeActivityApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param>
        /// <returns>BillingCodeActivity</returns>
        BillingCodeActivity AddBillingCodeActivity (BillingCodeActivity body);
  
        /// <summary>
        /// Create a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param>
        /// <returns>ApiResponse of BillingCodeActivity</returns>
        ApiResponse<BillingCodeActivity> AddBillingCodeActivityWithHttpInfo (BillingCodeActivity body);
        
        /// <summary>
        /// Add new audit for a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param>
        /// <param name="billingCodeActivityAudit">The audit to add</param>
        /// <returns></returns>
        void AddBillingCodeActivityAudit (int? billingCodeActivityId, string billingCodeActivityAudit);
  
        /// <summary>
        /// Add new audit for a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param>
        /// <param name="billingCodeActivityAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBillingCodeActivityAuditWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityAudit);
        
        /// <summary>
        /// Add new tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param>
        /// <param name="billingCodeActivityTag">The tag to add</param>
        /// <returns></returns>
        void AddBillingCodeActivityTag (int? billingCodeActivityId, string billingCodeActivityTag);
  
        /// <summary>
        /// Add new tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param>
        /// <param name="billingCodeActivityTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddBillingCodeActivityTagWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag);
        
        /// <summary>
        /// Delete a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param>
        /// <returns></returns>
        void DeleteBillingCodeActivity (int? billingCodeActivityId);
  
        /// <summary>
        /// Delete a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBillingCodeActivityWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Delete a tag for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param>
        /// <param name="billingCodeActivityTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteBillingCodeActivityTag (int? billingCodeActivityId, string billingCodeActivityTag);
  
        /// <summary>
        /// Delete a tag for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param>
        /// <param name="billingCodeActivityTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBillingCodeActivityTagWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag);
        
        /// <summary>
        /// Search billingCodeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;BillingCodeActivity&gt;</returns>
        List<BillingCodeActivity> GetBillingCodeActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search billingCodeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;BillingCodeActivity&gt;</returns>
        ApiResponse<List<BillingCodeActivity>> GetBillingCodeActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param>
        /// <returns>BillingCodeActivity</returns>
        BillingCodeActivity GetBillingCodeActivityById (int? billingCodeActivityId);
  
        /// <summary>
        /// Get a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param>
        /// <returns>ApiResponse of BillingCodeActivity</returns>
        ApiResponse<BillingCodeActivity> GetBillingCodeActivityByIdWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Get the tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param>
        /// <returns></returns>
        void GetBillingCodeActivityTags (int? billingCodeActivityId);
  
        /// <summary>
        /// Get the tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetBillingCodeActivityTagsWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Get a duplicated a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param>
        /// <returns>BillingCodeActivity</returns>
        BillingCodeActivity GetDuplicateBillingCodeActivityById (int? billingCodeActivityId);
  
        /// <summary>
        /// Get a duplicated a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param>
        /// <returns>ApiResponse of BillingCodeActivity</returns>
        ApiResponse<BillingCodeActivity> GetDuplicateBillingCodeActivityByIdWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Update a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param>
        /// <returns></returns>
        void UpdateBillingCodeActivity (BillingCodeActivity body);
  
        /// <summary>
        /// Update a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateBillingCodeActivityWithHttpInfo (BillingCodeActivity body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param>
        /// <returns>Task of BillingCodeActivity</returns>
        System.Threading.Tasks.Task<BillingCodeActivity> AddBillingCodeActivityAsync (BillingCodeActivity body);

        /// <summary>
        /// Create a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Inserts a new billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (BillingCodeActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillingCodeActivity>> AddBillingCodeActivityAsyncWithHttpInfo (BillingCodeActivity body);
        
        /// <summary>
        /// Add new audit for a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param>
        /// <param name="billingCodeActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBillingCodeActivityAuditAsync (int? billingCodeActivityId, string billingCodeActivityAudit);

        /// <summary>
        /// Add new audit for a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param>
        /// <param name="billingCodeActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeActivityAuditAsyncWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityAudit);
        
        /// <summary>
        /// Add new tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param>
        /// <param name="billingCodeActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddBillingCodeActivityTagAsync (int? billingCodeActivityId, string billingCodeActivityTag);

        /// <summary>
        /// Add new tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing billingCodeActivity.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param>
        /// <param name="billingCodeActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeActivityTagAsyncWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag);
        
        /// <summary>
        /// Delete a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBillingCodeActivityAsync (int? billingCodeActivityId);

        /// <summary>
        /// Delete a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Deletes the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeActivityAsyncWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Delete a tag for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param>
        /// <param name="billingCodeActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBillingCodeActivityTagAsync (int? billingCodeActivityId, string billingCodeActivityTag);

        /// <summary>
        /// Delete a tag for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Deletes an existing billingCodeActivity tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param>
        /// <param name="billingCodeActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeActivityTagAsyncWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag);
        
        /// <summary>
        /// Search billingCodeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BillingCodeActivity&gt;</returns>
        System.Threading.Tasks.Task<List<BillingCodeActivity>> GetBillingCodeActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search billingCodeActivitys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of billingCodeActivitys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BillingCodeActivity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<BillingCodeActivity>>> GetBillingCodeActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param>
        /// <returns>Task of BillingCodeActivity</returns>
        System.Threading.Tasks.Task<BillingCodeActivity> GetBillingCodeActivityByIdAsync (int? billingCodeActivityId);

        /// <summary>
        /// Get a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns the billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param>
        /// <returns>Task of ApiResponse (BillingCodeActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillingCodeActivity>> GetBillingCodeActivityByIdAsyncWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Get the tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetBillingCodeActivityTagsAsync (int? billingCodeActivityId);

        /// <summary>
        /// Get the tags for a billingCodeActivity.
        /// </summary>
        /// <remarks>
        /// Get all existing billingCodeActivity tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetBillingCodeActivityTagsAsyncWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Get a duplicated a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param>
        /// <returns>Task of BillingCodeActivity</returns>
        System.Threading.Tasks.Task<BillingCodeActivity> GetDuplicateBillingCodeActivityByIdAsync (int? billingCodeActivityId);

        /// <summary>
        /// Get a duplicated a billingCodeActivity by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated billingCodeActivity identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (BillingCodeActivity)</returns>
        System.Threading.Tasks.Task<ApiResponse<BillingCodeActivity>> GetDuplicateBillingCodeActivityByIdAsyncWithHttpInfo (int? billingCodeActivityId);
        
        /// <summary>
        /// Update a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateBillingCodeActivityAsync (BillingCodeActivity body);

        /// <summary>
        /// Update a billingCodeActivity
        /// </summary>
        /// <remarks>
        /// Updates an existing billingCodeActivity using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillingCodeActivityAsyncWithHttpInfo (BillingCodeActivity body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BillingCodeActivityApi : IBillingCodeActivityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeActivityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BillingCodeActivityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingCodeActivityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BillingCodeActivityApi(Configuration configuration = null)
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
        /// Create a billingCodeActivity Inserts a new billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param> 
        /// <returns>BillingCodeActivity</returns>
        public BillingCodeActivity AddBillingCodeActivity (BillingCodeActivity body)
        {
             ApiResponse<BillingCodeActivity> localVarResponse = AddBillingCodeActivityWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a billingCodeActivity Inserts a new billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param> 
        /// <returns>ApiResponse of BillingCodeActivity</returns>
        public ApiResponse< BillingCodeActivity > AddBillingCodeActivityWithHttpInfo (BillingCodeActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillingCodeActivityApi->AddBillingCodeActivity");
            
    
            var localVarPath = "/beta/billingCodeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillingCodeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeActivity)));
            
        }

        
        /// <summary>
        /// Create a billingCodeActivity Inserts a new billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param>
        /// <returns>Task of BillingCodeActivity</returns>
        public async System.Threading.Tasks.Task<BillingCodeActivity> AddBillingCodeActivityAsync (BillingCodeActivity body)
        {
             ApiResponse<BillingCodeActivity> localVarResponse = await AddBillingCodeActivityAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a billingCodeActivity Inserts a new billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be inserted.</param>
        /// <returns>Task of ApiResponse (BillingCodeActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillingCodeActivity>> AddBillingCodeActivityAsyncWithHttpInfo (BillingCodeActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddBillingCodeActivity");
            
    
            var localVarPath = "/beta/billingCodeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingCodeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeActivity)));
            
        }
        
        /// <summary>
        /// Add new audit for a billingCodeActivity Adds an audit to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param> 
        /// <param name="billingCodeActivityAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddBillingCodeActivityAudit (int? billingCodeActivityId, string billingCodeActivityAudit)
        {
             AddBillingCodeActivityAuditWithHttpInfo(billingCodeActivityId, billingCodeActivityAudit);
        }

        /// <summary>
        /// Add new audit for a billingCodeActivity Adds an audit to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param> 
        /// <param name="billingCodeActivityAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBillingCodeActivityAuditWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityAudit)
        {
            
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling BillingCodeActivityApi->AddBillingCodeActivityAudit");
            
            // verify the required parameter 'billingCodeActivityAudit' is set
            if (billingCodeActivityAudit == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityAudit' when calling BillingCodeActivityApi->AddBillingCodeActivityAudit");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/audit/{billingCodeActivityAudit}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            if (billingCodeActivityAudit != null) localVarPathParams.Add("billingCodeActivityAudit", Configuration.ApiClient.ParameterToString(billingCodeActivityAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a billingCodeActivity Adds an audit to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param>
        /// <param name="billingCodeActivityAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBillingCodeActivityAuditAsync (int? billingCodeActivityId, string billingCodeActivityAudit)
        {
             await AddBillingCodeActivityAuditAsyncWithHttpInfo(billingCodeActivityId, billingCodeActivityAudit);

        }

        /// <summary>
        /// Add new audit for a billingCodeActivity Adds an audit to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add an audit to</param>
        /// <param name="billingCodeActivityAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeActivityAuditAsyncWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityAudit)
        {
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling AddBillingCodeActivityAudit");
            // verify the required parameter 'billingCodeActivityAudit' is set
            if (billingCodeActivityAudit == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityAudit' when calling AddBillingCodeActivityAudit");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/audit/{billingCodeActivityAudit}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            if (billingCodeActivityAudit != null) localVarPathParams.Add("billingCodeActivityAudit", Configuration.ApiClient.ParameterToString(billingCodeActivityAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a billingCodeActivity. Adds a tag to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param> 
        /// <param name="billingCodeActivityTag">The tag to add</param> 
        /// <returns></returns>
        public void AddBillingCodeActivityTag (int? billingCodeActivityId, string billingCodeActivityTag)
        {
             AddBillingCodeActivityTagWithHttpInfo(billingCodeActivityId, billingCodeActivityTag);
        }

        /// <summary>
        /// Add new tags for a billingCodeActivity. Adds a tag to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param> 
        /// <param name="billingCodeActivityTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddBillingCodeActivityTagWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag)
        {
            
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling BillingCodeActivityApi->AddBillingCodeActivityTag");
            
            // verify the required parameter 'billingCodeActivityTag' is set
            if (billingCodeActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityTag' when calling BillingCodeActivityApi->AddBillingCodeActivityTag");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/tag/{billingCodeActivityTag}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            if (billingCodeActivityTag != null) localVarPathParams.Add("billingCodeActivityTag", Configuration.ApiClient.ParameterToString(billingCodeActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a billingCodeActivity. Adds a tag to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param>
        /// <param name="billingCodeActivityTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddBillingCodeActivityTagAsync (int? billingCodeActivityId, string billingCodeActivityTag)
        {
             await AddBillingCodeActivityTagAsyncWithHttpInfo(billingCodeActivityId, billingCodeActivityTag);

        }

        /// <summary>
        /// Add new tags for a billingCodeActivity. Adds a tag to an existing billingCodeActivity.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to add a tag to</param>
        /// <param name="billingCodeActivityTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddBillingCodeActivityTagAsyncWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag)
        {
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling AddBillingCodeActivityTag");
            // verify the required parameter 'billingCodeActivityTag' is set
            if (billingCodeActivityTag == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityTag' when calling AddBillingCodeActivityTag");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/tag/{billingCodeActivityTag}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            if (billingCodeActivityTag != null) localVarPathParams.Add("billingCodeActivityTag", Configuration.ApiClient.ParameterToString(billingCodeActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddBillingCodeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a billingCodeActivity Deletes the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param> 
        /// <returns></returns>
        public void DeleteBillingCodeActivity (int? billingCodeActivityId)
        {
             DeleteBillingCodeActivityWithHttpInfo(billingCodeActivityId);
        }

        /// <summary>
        /// Delete a billingCodeActivity Deletes the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBillingCodeActivityWithHttpInfo (int? billingCodeActivityId)
        {
            
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling BillingCodeActivityApi->DeleteBillingCodeActivity");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a billingCodeActivity Deletes the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBillingCodeActivityAsync (int? billingCodeActivityId)
        {
             await DeleteBillingCodeActivityAsyncWithHttpInfo(billingCodeActivityId);

        }

        /// <summary>
        /// Delete a billingCodeActivity Deletes the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeActivityAsyncWithHttpInfo (int? billingCodeActivityId)
        {
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling DeleteBillingCodeActivity");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a billingCodeActivity. Deletes an existing billingCodeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param> 
        /// <param name="billingCodeActivityTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteBillingCodeActivityTag (int? billingCodeActivityId, string billingCodeActivityTag)
        {
             DeleteBillingCodeActivityTagWithHttpInfo(billingCodeActivityId, billingCodeActivityTag);
        }

        /// <summary>
        /// Delete a tag for a billingCodeActivity. Deletes an existing billingCodeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param> 
        /// <param name="billingCodeActivityTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBillingCodeActivityTagWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag)
        {
            
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling BillingCodeActivityApi->DeleteBillingCodeActivityTag");
            
            // verify the required parameter 'billingCodeActivityTag' is set
            if (billingCodeActivityTag == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityTag' when calling BillingCodeActivityApi->DeleteBillingCodeActivityTag");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/tag/{billingCodeActivityTag}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            if (billingCodeActivityTag != null) localVarPathParams.Add("billingCodeActivityTag", Configuration.ApiClient.ParameterToString(billingCodeActivityTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a billingCodeActivity. Deletes an existing billingCodeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param>
        /// <param name="billingCodeActivityTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBillingCodeActivityTagAsync (int? billingCodeActivityId, string billingCodeActivityTag)
        {
             await DeleteBillingCodeActivityTagAsyncWithHttpInfo(billingCodeActivityId, billingCodeActivityTag);

        }

        /// <summary>
        /// Delete a tag for a billingCodeActivity. Deletes an existing billingCodeActivity tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to remove tag from</param>
        /// <param name="billingCodeActivityTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBillingCodeActivityTagAsyncWithHttpInfo (int? billingCodeActivityId, string billingCodeActivityTag)
        {
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling DeleteBillingCodeActivityTag");
            // verify the required parameter 'billingCodeActivityTag' is set
            if (billingCodeActivityTag == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityTag' when calling DeleteBillingCodeActivityTag");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/tag/{billingCodeActivityTag}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            if (billingCodeActivityTag != null) localVarPathParams.Add("billingCodeActivityTag", Configuration.ApiClient.ParameterToString(billingCodeActivityTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivityTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteBillingCodeActivityTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Search billingCodeActivitys by filter Returns the list of billingCodeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;BillingCodeActivity&gt;</returns>
        public List<BillingCodeActivity> GetBillingCodeActivityByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BillingCodeActivity>> localVarResponse = GetBillingCodeActivityByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search billingCodeActivitys by filter Returns the list of billingCodeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;BillingCodeActivity&gt;</returns>
        public ApiResponse< List<BillingCodeActivity> > GetBillingCodeActivityByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/billingCodeActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<BillingCodeActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BillingCodeActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillingCodeActivity>)));
            
        }

        
        /// <summary>
        /// Search billingCodeActivitys by filter Returns the list of billingCodeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;BillingCodeActivity&gt;</returns>
        public async System.Threading.Tasks.Task<List<BillingCodeActivity>> GetBillingCodeActivityByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<BillingCodeActivity>> localVarResponse = await GetBillingCodeActivityByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search billingCodeActivitys by filter Returns the list of billingCodeActivitys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;BillingCodeActivity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<BillingCodeActivity>>> GetBillingCodeActivityByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/billingCodeActivity/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<BillingCodeActivity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<BillingCodeActivity>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<BillingCodeActivity>)));
            
        }
        
        /// <summary>
        /// Get a billingCodeActivity by id Returns the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param> 
        /// <returns>BillingCodeActivity</returns>
        public BillingCodeActivity GetBillingCodeActivityById (int? billingCodeActivityId)
        {
             ApiResponse<BillingCodeActivity> localVarResponse = GetBillingCodeActivityByIdWithHttpInfo(billingCodeActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a billingCodeActivity by id Returns the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param> 
        /// <returns>ApiResponse of BillingCodeActivity</returns>
        public ApiResponse< BillingCodeActivity > GetBillingCodeActivityByIdWithHttpInfo (int? billingCodeActivityId)
        {
            
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling BillingCodeActivityApi->GetBillingCodeActivityById");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillingCodeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeActivity)));
            
        }

        
        /// <summary>
        /// Get a billingCodeActivity by id Returns the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param>
        /// <returns>Task of BillingCodeActivity</returns>
        public async System.Threading.Tasks.Task<BillingCodeActivity> GetBillingCodeActivityByIdAsync (int? billingCodeActivityId)
        {
             ApiResponse<BillingCodeActivity> localVarResponse = await GetBillingCodeActivityByIdAsyncWithHttpInfo(billingCodeActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a billingCodeActivity by id Returns the billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be returned.</param>
        /// <returns>Task of ApiResponse (BillingCodeActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillingCodeActivity>> GetBillingCodeActivityByIdAsyncWithHttpInfo (int? billingCodeActivityId)
        {
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling GetBillingCodeActivityById");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingCodeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeActivity)));
            
        }
        
        /// <summary>
        /// Get the tags for a billingCodeActivity. Get all existing billingCodeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param> 
        /// <returns></returns>
        public void GetBillingCodeActivityTags (int? billingCodeActivityId)
        {
             GetBillingCodeActivityTagsWithHttpInfo(billingCodeActivityId);
        }

        /// <summary>
        /// Get the tags for a billingCodeActivity. Get all existing billingCodeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetBillingCodeActivityTagsWithHttpInfo (int? billingCodeActivityId)
        {
            
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling BillingCodeActivityApi->GetBillingCodeActivityTags");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/tag";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a billingCodeActivity. Get all existing billingCodeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetBillingCodeActivityTagsAsync (int? billingCodeActivityId)
        {
             await GetBillingCodeActivityTagsAsyncWithHttpInfo(billingCodeActivityId);

        }

        /// <summary>
        /// Get the tags for a billingCodeActivity. Get all existing billingCodeActivity tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetBillingCodeActivityTagsAsyncWithHttpInfo (int? billingCodeActivityId)
        {
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling GetBillingCodeActivityTags");
            
    
            var localVarPath = "/beta/billingCodeActivity/{billingCodeActivityId}/tag";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetBillingCodeActivityTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a billingCodeActivity by id Returns a duplicated billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param> 
        /// <returns>BillingCodeActivity</returns>
        public BillingCodeActivity GetDuplicateBillingCodeActivityById (int? billingCodeActivityId)
        {
             ApiResponse<BillingCodeActivity> localVarResponse = GetDuplicateBillingCodeActivityByIdWithHttpInfo(billingCodeActivityId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a billingCodeActivity by id Returns a duplicated billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param> 
        /// <returns>ApiResponse of BillingCodeActivity</returns>
        public ApiResponse< BillingCodeActivity > GetDuplicateBillingCodeActivityByIdWithHttpInfo (int? billingCodeActivityId)
        {
            
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null)
                throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling BillingCodeActivityApi->GetDuplicateBillingCodeActivityById");
            
    
            var localVarPath = "/beta/billingCodeActivity/duplicate/{billingCodeActivityId}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<BillingCodeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeActivity)));
            
        }

        
        /// <summary>
        /// Get a duplicated a billingCodeActivity by id Returns a duplicated billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param>
        /// <returns>Task of BillingCodeActivity</returns>
        public async System.Threading.Tasks.Task<BillingCodeActivity> GetDuplicateBillingCodeActivityByIdAsync (int? billingCodeActivityId)
        {
             ApiResponse<BillingCodeActivity> localVarResponse = await GetDuplicateBillingCodeActivityByIdAsyncWithHttpInfo(billingCodeActivityId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a billingCodeActivity by id Returns a duplicated billingCodeActivity identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="billingCodeActivityId">Id of the billingCodeActivity to be duplicated.</param>
        /// <returns>Task of ApiResponse (BillingCodeActivity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BillingCodeActivity>> GetDuplicateBillingCodeActivityByIdAsyncWithHttpInfo (int? billingCodeActivityId)
        {
            // verify the required parameter 'billingCodeActivityId' is set
            if (billingCodeActivityId == null) throw new ApiException(400, "Missing required parameter 'billingCodeActivityId' when calling GetDuplicateBillingCodeActivityById");
            
    
            var localVarPath = "/beta/billingCodeActivity/duplicate/{billingCodeActivityId}";
    
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
            if (billingCodeActivityId != null) localVarPathParams.Add("billingCodeActivityId", Configuration.ApiClient.ParameterToString(billingCodeActivityId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeActivityById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateBillingCodeActivityById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<BillingCodeActivity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BillingCodeActivity) Configuration.ApiClient.Deserialize(localVarResponse, typeof(BillingCodeActivity)));
            
        }
        
        /// <summary>
        /// Update a billingCodeActivity Updates an existing billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param> 
        /// <returns></returns>
        public void UpdateBillingCodeActivity (BillingCodeActivity body)
        {
             UpdateBillingCodeActivityWithHttpInfo(body);
        }

        /// <summary>
        /// Update a billingCodeActivity Updates an existing billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateBillingCodeActivityWithHttpInfo (BillingCodeActivity body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BillingCodeActivityApi->UpdateBillingCodeActivity");
            
    
            var localVarPath = "/beta/billingCodeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a billingCodeActivity Updates an existing billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateBillingCodeActivityAsync (BillingCodeActivity body)
        {
             await UpdateBillingCodeActivityAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a billingCodeActivity Updates an existing billingCodeActivity using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">BillingCodeActivity to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateBillingCodeActivityAsyncWithHttpInfo (BillingCodeActivity body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateBillingCodeActivity");
            
    
            var localVarPath = "/beta/billingCodeActivity";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateBillingCodeActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
