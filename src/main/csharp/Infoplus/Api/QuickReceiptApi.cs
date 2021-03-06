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
    public interface IQuickReceiptApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a quickReceipt
        /// </summary>
        /// <remarks>
        /// Inserts a new quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param>
        /// <returns>QuickReceipt</returns>
        QuickReceipt AddQuickReceipt (QuickReceipt body);
  
        /// <summary>
        /// Create a quickReceipt
        /// </summary>
        /// <remarks>
        /// Inserts a new quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param>
        /// <returns>ApiResponse of QuickReceipt</returns>
        ApiResponse<QuickReceipt> AddQuickReceiptWithHttpInfo (QuickReceipt body);
        
        /// <summary>
        /// Add new audit for a quickReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param>
        /// <param name="quickReceiptAudit">The audit to add</param>
        /// <returns></returns>
        void AddQuickReceiptAudit (int? quickReceiptId, string quickReceiptAudit);
  
        /// <summary>
        /// Add new audit for a quickReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param>
        /// <param name="quickReceiptAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddQuickReceiptAuditWithHttpInfo (int? quickReceiptId, string quickReceiptAudit);
        
        /// <summary>
        /// Add new tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param>
        /// <param name="quickReceiptTag">The tag to add</param>
        /// <returns></returns>
        void AddQuickReceiptTag (int? quickReceiptId, string quickReceiptTag);
  
        /// <summary>
        /// Add new tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param>
        /// <param name="quickReceiptTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddQuickReceiptTagWithHttpInfo (int? quickReceiptId, string quickReceiptTag);
        
        /// <summary>
        /// Delete a quickReceipt
        /// </summary>
        /// <remarks>
        /// Deletes the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param>
        /// <returns></returns>
        void DeleteQuickReceipt (int? quickReceiptId);
  
        /// <summary>
        /// Delete a quickReceipt
        /// </summary>
        /// <remarks>
        /// Deletes the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteQuickReceiptWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Delete a tag for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing quickReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param>
        /// <param name="quickReceiptTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteQuickReceiptTag (int? quickReceiptId, string quickReceiptTag);
  
        /// <summary>
        /// Delete a tag for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing quickReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param>
        /// <param name="quickReceiptTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteQuickReceiptTagWithHttpInfo (int? quickReceiptId, string quickReceiptTag);
        
        /// <summary>
        /// Get a duplicated a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param>
        /// <returns>QuickReceipt</returns>
        QuickReceipt GetDuplicateQuickReceiptById (int? quickReceiptId);
  
        /// <summary>
        /// Get a duplicated a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param>
        /// <returns>ApiResponse of QuickReceipt</returns>
        ApiResponse<QuickReceipt> GetDuplicateQuickReceiptByIdWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Search quickReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;QuickReceipt&gt;</returns>
        List<QuickReceipt> GetQuickReceiptByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search quickReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;QuickReceipt&gt;</returns>
        ApiResponse<List<QuickReceipt>> GetQuickReceiptByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param>
        /// <returns>QuickReceipt</returns>
        QuickReceipt GetQuickReceiptById (int? quickReceiptId);
  
        /// <summary>
        /// Get a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param>
        /// <returns>ApiResponse of QuickReceipt</returns>
        ApiResponse<QuickReceipt> GetQuickReceiptByIdWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Get the tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing quickReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param>
        /// <returns></returns>
        void GetQuickReceiptTags (int? quickReceiptId);
  
        /// <summary>
        /// Get the tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing quickReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetQuickReceiptTagsWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Update a quickReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns></returns>
        void UpdateQuickReceipt (QuickReceipt body);
  
        /// <summary>
        /// Update a quickReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateQuickReceiptWithHttpInfo (QuickReceipt body);
        
        /// <summary>
        /// Update a quickReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns></returns>
        void UpdateQuickReceiptCustomFields (QuickReceipt body);
  
        /// <summary>
        /// Update a quickReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateQuickReceiptCustomFieldsWithHttpInfo (QuickReceipt body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a quickReceipt
        /// </summary>
        /// <remarks>
        /// Inserts a new quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param>
        /// <returns>Task of QuickReceipt</returns>
        System.Threading.Tasks.Task<QuickReceipt> AddQuickReceiptAsync (QuickReceipt body);

        /// <summary>
        /// Create a quickReceipt
        /// </summary>
        /// <remarks>
        /// Inserts a new quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param>
        /// <returns>Task of ApiResponse (QuickReceipt)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuickReceipt>> AddQuickReceiptAsyncWithHttpInfo (QuickReceipt body);
        
        /// <summary>
        /// Add new audit for a quickReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param>
        /// <param name="quickReceiptAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddQuickReceiptAuditAsync (int? quickReceiptId, string quickReceiptAudit);

        /// <summary>
        /// Add new audit for a quickReceipt
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param>
        /// <param name="quickReceiptAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddQuickReceiptAuditAsyncWithHttpInfo (int? quickReceiptId, string quickReceiptAudit);
        
        /// <summary>
        /// Add new tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param>
        /// <param name="quickReceiptTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddQuickReceiptTagAsync (int? quickReceiptId, string quickReceiptTag);

        /// <summary>
        /// Add new tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing quickReceipt.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param>
        /// <param name="quickReceiptTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddQuickReceiptTagAsyncWithHttpInfo (int? quickReceiptId, string quickReceiptTag);
        
        /// <summary>
        /// Delete a quickReceipt
        /// </summary>
        /// <remarks>
        /// Deletes the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteQuickReceiptAsync (int? quickReceiptId);

        /// <summary>
        /// Delete a quickReceipt
        /// </summary>
        /// <remarks>
        /// Deletes the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQuickReceiptAsyncWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Delete a tag for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing quickReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param>
        /// <param name="quickReceiptTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteQuickReceiptTagAsync (int? quickReceiptId, string quickReceiptTag);

        /// <summary>
        /// Delete a tag for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Deletes an existing quickReceipt tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param>
        /// <param name="quickReceiptTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQuickReceiptTagAsyncWithHttpInfo (int? quickReceiptId, string quickReceiptTag);
        
        /// <summary>
        /// Get a duplicated a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param>
        /// <returns>Task of QuickReceipt</returns>
        System.Threading.Tasks.Task<QuickReceipt> GetDuplicateQuickReceiptByIdAsync (int? quickReceiptId);

        /// <summary>
        /// Get a duplicated a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param>
        /// <returns>Task of ApiResponse (QuickReceipt)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuickReceipt>> GetDuplicateQuickReceiptByIdAsyncWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Search quickReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;QuickReceipt&gt;</returns>
        System.Threading.Tasks.Task<List<QuickReceipt>> GetQuickReceiptByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search quickReceipts by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of quickReceipts that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;QuickReceipt&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<QuickReceipt>>> GetQuickReceiptByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param>
        /// <returns>Task of QuickReceipt</returns>
        System.Threading.Tasks.Task<QuickReceipt> GetQuickReceiptByIdAsync (int? quickReceiptId);

        /// <summary>
        /// Get a quickReceipt by id
        /// </summary>
        /// <remarks>
        /// Returns the quickReceipt identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param>
        /// <returns>Task of ApiResponse (QuickReceipt)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuickReceipt>> GetQuickReceiptByIdAsyncWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Get the tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing quickReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetQuickReceiptTagsAsync (int? quickReceiptId);

        /// <summary>
        /// Get the tags for a quickReceipt.
        /// </summary>
        /// <remarks>
        /// Get all existing quickReceipt tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetQuickReceiptTagsAsyncWithHttpInfo (int? quickReceiptId);
        
        /// <summary>
        /// Update a quickReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateQuickReceiptAsync (QuickReceipt body);

        /// <summary>
        /// Update a quickReceipt
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickReceiptAsyncWithHttpInfo (QuickReceipt body);
        
        /// <summary>
        /// Update a quickReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateQuickReceiptCustomFieldsAsync (QuickReceipt body);

        /// <summary>
        /// Update a quickReceipt custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing quickReceipt custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickReceiptCustomFieldsAsyncWithHttpInfo (QuickReceipt body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QuickReceiptApi : IQuickReceiptApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickReceiptApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QuickReceiptApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickReceiptApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QuickReceiptApi(Configuration configuration = null)
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
        /// Create a quickReceipt Inserts a new quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param> 
        /// <returns>QuickReceipt</returns>
        public QuickReceipt AddQuickReceipt (QuickReceipt body)
        {
             ApiResponse<QuickReceipt> localVarResponse = AddQuickReceiptWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a quickReceipt Inserts a new quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param> 
        /// <returns>ApiResponse of QuickReceipt</returns>
        public ApiResponse< QuickReceipt > AddQuickReceiptWithHttpInfo (QuickReceipt body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QuickReceiptApi->AddQuickReceipt");
            
    
            var localVarPath = "/beta/quickReceipt";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QuickReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickReceipt)));
            
        }

        
        /// <summary>
        /// Create a quickReceipt Inserts a new quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param>
        /// <returns>Task of QuickReceipt</returns>
        public async System.Threading.Tasks.Task<QuickReceipt> AddQuickReceiptAsync (QuickReceipt body)
        {
             ApiResponse<QuickReceipt> localVarResponse = await AddQuickReceiptAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a quickReceipt Inserts a new quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be inserted.</param>
        /// <returns>Task of ApiResponse (QuickReceipt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickReceipt>> AddQuickReceiptAsyncWithHttpInfo (QuickReceipt body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddQuickReceipt");
            
    
            var localVarPath = "/beta/quickReceipt";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QuickReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickReceipt)));
            
        }
        
        /// <summary>
        /// Add new audit for a quickReceipt Adds an audit to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param> 
        /// <param name="quickReceiptAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddQuickReceiptAudit (int? quickReceiptId, string quickReceiptAudit)
        {
             AddQuickReceiptAuditWithHttpInfo(quickReceiptId, quickReceiptAudit);
        }

        /// <summary>
        /// Add new audit for a quickReceipt Adds an audit to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param> 
        /// <param name="quickReceiptAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddQuickReceiptAuditWithHttpInfo (int? quickReceiptId, string quickReceiptAudit)
        {
            
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling QuickReceiptApi->AddQuickReceiptAudit");
            
            // verify the required parameter 'quickReceiptAudit' is set
            if (quickReceiptAudit == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptAudit' when calling QuickReceiptApi->AddQuickReceiptAudit");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/audit/{quickReceiptAudit}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            if (quickReceiptAudit != null) localVarPathParams.Add("quickReceiptAudit", Configuration.ApiClient.ParameterToString(quickReceiptAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a quickReceipt Adds an audit to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param>
        /// <param name="quickReceiptAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddQuickReceiptAuditAsync (int? quickReceiptId, string quickReceiptAudit)
        {
             await AddQuickReceiptAuditAsyncWithHttpInfo(quickReceiptId, quickReceiptAudit);

        }

        /// <summary>
        /// Add new audit for a quickReceipt Adds an audit to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add an audit to</param>
        /// <param name="quickReceiptAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddQuickReceiptAuditAsyncWithHttpInfo (int? quickReceiptId, string quickReceiptAudit)
        {
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null) throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling AddQuickReceiptAudit");
            // verify the required parameter 'quickReceiptAudit' is set
            if (quickReceiptAudit == null) throw new ApiException(400, "Missing required parameter 'quickReceiptAudit' when calling AddQuickReceiptAudit");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/audit/{quickReceiptAudit}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            if (quickReceiptAudit != null) localVarPathParams.Add("quickReceiptAudit", Configuration.ApiClient.ParameterToString(quickReceiptAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a quickReceipt. Adds a tag to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param> 
        /// <param name="quickReceiptTag">The tag to add</param> 
        /// <returns></returns>
        public void AddQuickReceiptTag (int? quickReceiptId, string quickReceiptTag)
        {
             AddQuickReceiptTagWithHttpInfo(quickReceiptId, quickReceiptTag);
        }

        /// <summary>
        /// Add new tags for a quickReceipt. Adds a tag to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param> 
        /// <param name="quickReceiptTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddQuickReceiptTagWithHttpInfo (int? quickReceiptId, string quickReceiptTag)
        {
            
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling QuickReceiptApi->AddQuickReceiptTag");
            
            // verify the required parameter 'quickReceiptTag' is set
            if (quickReceiptTag == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptTag' when calling QuickReceiptApi->AddQuickReceiptTag");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/tag/{quickReceiptTag}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            if (quickReceiptTag != null) localVarPathParams.Add("quickReceiptTag", Configuration.ApiClient.ParameterToString(quickReceiptTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a quickReceipt. Adds a tag to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param>
        /// <param name="quickReceiptTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddQuickReceiptTagAsync (int? quickReceiptId, string quickReceiptTag)
        {
             await AddQuickReceiptTagAsyncWithHttpInfo(quickReceiptId, quickReceiptTag);

        }

        /// <summary>
        /// Add new tags for a quickReceipt. Adds a tag to an existing quickReceipt.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to add a tag to</param>
        /// <param name="quickReceiptTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddQuickReceiptTagAsyncWithHttpInfo (int? quickReceiptId, string quickReceiptTag)
        {
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null) throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling AddQuickReceiptTag");
            // verify the required parameter 'quickReceiptTag' is set
            if (quickReceiptTag == null) throw new ApiException(400, "Missing required parameter 'quickReceiptTag' when calling AddQuickReceiptTag");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/tag/{quickReceiptTag}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            if (quickReceiptTag != null) localVarPathParams.Add("quickReceiptTag", Configuration.ApiClient.ParameterToString(quickReceiptTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddQuickReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a quickReceipt Deletes the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param> 
        /// <returns></returns>
        public void DeleteQuickReceipt (int? quickReceiptId)
        {
             DeleteQuickReceiptWithHttpInfo(quickReceiptId);
        }

        /// <summary>
        /// Delete a quickReceipt Deletes the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteQuickReceiptWithHttpInfo (int? quickReceiptId)
        {
            
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling QuickReceiptApi->DeleteQuickReceipt");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a quickReceipt Deletes the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteQuickReceiptAsync (int? quickReceiptId)
        {
             await DeleteQuickReceiptAsyncWithHttpInfo(quickReceiptId);

        }

        /// <summary>
        /// Delete a quickReceipt Deletes the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQuickReceiptAsyncWithHttpInfo (int? quickReceiptId)
        {
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null) throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling DeleteQuickReceipt");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a quickReceipt. Deletes an existing quickReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param> 
        /// <param name="quickReceiptTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteQuickReceiptTag (int? quickReceiptId, string quickReceiptTag)
        {
             DeleteQuickReceiptTagWithHttpInfo(quickReceiptId, quickReceiptTag);
        }

        /// <summary>
        /// Delete a tag for a quickReceipt. Deletes an existing quickReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param> 
        /// <param name="quickReceiptTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteQuickReceiptTagWithHttpInfo (int? quickReceiptId, string quickReceiptTag)
        {
            
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling QuickReceiptApi->DeleteQuickReceiptTag");
            
            // verify the required parameter 'quickReceiptTag' is set
            if (quickReceiptTag == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptTag' when calling QuickReceiptApi->DeleteQuickReceiptTag");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/tag/{quickReceiptTag}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            if (quickReceiptTag != null) localVarPathParams.Add("quickReceiptTag", Configuration.ApiClient.ParameterToString(quickReceiptTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a quickReceipt. Deletes an existing quickReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param>
        /// <param name="quickReceiptTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteQuickReceiptTagAsync (int? quickReceiptId, string quickReceiptTag)
        {
             await DeleteQuickReceiptTagAsyncWithHttpInfo(quickReceiptId, quickReceiptTag);

        }

        /// <summary>
        /// Delete a tag for a quickReceipt. Deletes an existing quickReceipt tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to remove tag from</param>
        /// <param name="quickReceiptTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteQuickReceiptTagAsyncWithHttpInfo (int? quickReceiptId, string quickReceiptTag)
        {
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null) throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling DeleteQuickReceiptTag");
            // verify the required parameter 'quickReceiptTag' is set
            if (quickReceiptTag == null) throw new ApiException(400, "Missing required parameter 'quickReceiptTag' when calling DeleteQuickReceiptTag");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/tag/{quickReceiptTag}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            if (quickReceiptTag != null) localVarPathParams.Add("quickReceiptTag", Configuration.ApiClient.ParameterToString(quickReceiptTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceiptTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteQuickReceiptTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a quickReceipt by id Returns a duplicated quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param> 
        /// <returns>QuickReceipt</returns>
        public QuickReceipt GetDuplicateQuickReceiptById (int? quickReceiptId)
        {
             ApiResponse<QuickReceipt> localVarResponse = GetDuplicateQuickReceiptByIdWithHttpInfo(quickReceiptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a quickReceipt by id Returns a duplicated quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param> 
        /// <returns>ApiResponse of QuickReceipt</returns>
        public ApiResponse< QuickReceipt > GetDuplicateQuickReceiptByIdWithHttpInfo (int? quickReceiptId)
        {
            
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling QuickReceiptApi->GetDuplicateQuickReceiptById");
            
    
            var localVarPath = "/beta/quickReceipt/duplicate/{quickReceiptId}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QuickReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickReceipt)));
            
        }

        
        /// <summary>
        /// Get a duplicated a quickReceipt by id Returns a duplicated quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param>
        /// <returns>Task of QuickReceipt</returns>
        public async System.Threading.Tasks.Task<QuickReceipt> GetDuplicateQuickReceiptByIdAsync (int? quickReceiptId)
        {
             ApiResponse<QuickReceipt> localVarResponse = await GetDuplicateQuickReceiptByIdAsyncWithHttpInfo(quickReceiptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a quickReceipt by id Returns a duplicated quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be duplicated.</param>
        /// <returns>Task of ApiResponse (QuickReceipt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickReceipt>> GetDuplicateQuickReceiptByIdAsyncWithHttpInfo (int? quickReceiptId)
        {
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null) throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling GetDuplicateQuickReceiptById");
            
    
            var localVarPath = "/beta/quickReceipt/duplicate/{quickReceiptId}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateQuickReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QuickReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickReceipt)));
            
        }
        
        /// <summary>
        /// Search quickReceipts by filter Returns the list of quickReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;QuickReceipt&gt;</returns>
        public List<QuickReceipt> GetQuickReceiptByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<QuickReceipt>> localVarResponse = GetQuickReceiptByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search quickReceipts by filter Returns the list of quickReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;QuickReceipt&gt;</returns>
        public ApiResponse< List<QuickReceipt> > GetQuickReceiptByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/quickReceipt/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<QuickReceipt>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<QuickReceipt>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<QuickReceipt>)));
            
        }

        
        /// <summary>
        /// Search quickReceipts by filter Returns the list of quickReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;QuickReceipt&gt;</returns>
        public async System.Threading.Tasks.Task<List<QuickReceipt>> GetQuickReceiptByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<QuickReceipt>> localVarResponse = await GetQuickReceiptByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search quickReceipts by filter Returns the list of quickReceipts that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;QuickReceipt&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<QuickReceipt>>> GetQuickReceiptByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/quickReceipt/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<QuickReceipt>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<QuickReceipt>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<QuickReceipt>)));
            
        }
        
        /// <summary>
        /// Get a quickReceipt by id Returns the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param> 
        /// <returns>QuickReceipt</returns>
        public QuickReceipt GetQuickReceiptById (int? quickReceiptId)
        {
             ApiResponse<QuickReceipt> localVarResponse = GetQuickReceiptByIdWithHttpInfo(quickReceiptId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a quickReceipt by id Returns the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param> 
        /// <returns>ApiResponse of QuickReceipt</returns>
        public ApiResponse< QuickReceipt > GetQuickReceiptByIdWithHttpInfo (int? quickReceiptId)
        {
            
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling QuickReceiptApi->GetQuickReceiptById");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QuickReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickReceipt)));
            
        }

        
        /// <summary>
        /// Get a quickReceipt by id Returns the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param>
        /// <returns>Task of QuickReceipt</returns>
        public async System.Threading.Tasks.Task<QuickReceipt> GetQuickReceiptByIdAsync (int? quickReceiptId)
        {
             ApiResponse<QuickReceipt> localVarResponse = await GetQuickReceiptByIdAsyncWithHttpInfo(quickReceiptId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a quickReceipt by id Returns the quickReceipt identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to be returned.</param>
        /// <returns>Task of ApiResponse (QuickReceipt)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuickReceipt>> GetQuickReceiptByIdAsyncWithHttpInfo (int? quickReceiptId)
        {
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null) throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling GetQuickReceiptById");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QuickReceipt>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuickReceipt) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuickReceipt)));
            
        }
        
        /// <summary>
        /// Get the tags for a quickReceipt. Get all existing quickReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param> 
        /// <returns></returns>
        public void GetQuickReceiptTags (int? quickReceiptId)
        {
             GetQuickReceiptTagsWithHttpInfo(quickReceiptId);
        }

        /// <summary>
        /// Get the tags for a quickReceipt. Get all existing quickReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetQuickReceiptTagsWithHttpInfo (int? quickReceiptId)
        {
            
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null)
                throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling QuickReceiptApi->GetQuickReceiptTags");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/tag";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a quickReceipt. Get all existing quickReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetQuickReceiptTagsAsync (int? quickReceiptId)
        {
             await GetQuickReceiptTagsAsyncWithHttpInfo(quickReceiptId);

        }

        /// <summary>
        /// Get the tags for a quickReceipt. Get all existing quickReceipt tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quickReceiptId">Id of the quickReceipt to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetQuickReceiptTagsAsyncWithHttpInfo (int? quickReceiptId)
        {
            // verify the required parameter 'quickReceiptId' is set
            if (quickReceiptId == null) throw new ApiException(400, "Missing required parameter 'quickReceiptId' when calling GetQuickReceiptTags");
            
    
            var localVarPath = "/beta/quickReceipt/{quickReceiptId}/tag";
    
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
            if (quickReceiptId != null) localVarPathParams.Add("quickReceiptId", Configuration.ApiClient.ParameterToString(quickReceiptId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuickReceiptTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a quickReceipt Updates an existing quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param> 
        /// <returns></returns>
        public void UpdateQuickReceipt (QuickReceipt body)
        {
             UpdateQuickReceiptWithHttpInfo(body);
        }

        /// <summary>
        /// Update a quickReceipt Updates an existing quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateQuickReceiptWithHttpInfo (QuickReceipt body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QuickReceiptApi->UpdateQuickReceipt");
            
    
            var localVarPath = "/beta/quickReceipt";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a quickReceipt Updates an existing quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateQuickReceiptAsync (QuickReceipt body)
        {
             await UpdateQuickReceiptAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a quickReceipt Updates an existing quickReceipt using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickReceiptAsyncWithHttpInfo (QuickReceipt body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateQuickReceipt");
            
    
            var localVarPath = "/beta/quickReceipt";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceipt: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceipt: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a quickReceipt custom fields Updates an existing quickReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param> 
        /// <returns></returns>
        public void UpdateQuickReceiptCustomFields (QuickReceipt body)
        {
             UpdateQuickReceiptCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a quickReceipt custom fields Updates an existing quickReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateQuickReceiptCustomFieldsWithHttpInfo (QuickReceipt body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QuickReceiptApi->UpdateQuickReceiptCustomFields");
            
    
            var localVarPath = "/beta/quickReceipt/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceiptCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceiptCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a quickReceipt custom fields Updates an existing quickReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateQuickReceiptCustomFieldsAsync (QuickReceipt body)
        {
             await UpdateQuickReceiptCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a quickReceipt custom fields Updates an existing quickReceipt custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">QuickReceipt to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateQuickReceiptCustomFieldsAsyncWithHttpInfo (QuickReceipt body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateQuickReceiptCustomFields");
            
    
            var localVarPath = "/beta/quickReceipt/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceiptCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuickReceiptCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
