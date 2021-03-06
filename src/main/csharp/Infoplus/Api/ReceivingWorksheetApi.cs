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
    public interface IReceivingWorksheetApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param>
        /// <returns>ReceivingWorksheet</returns>
        ReceivingWorksheet AddReceivingWorksheet (ReceivingWorksheet body);
  
        /// <summary>
        /// Create a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param>
        /// <returns>ApiResponse of ReceivingWorksheet</returns>
        ApiResponse<ReceivingWorksheet> AddReceivingWorksheetWithHttpInfo (ReceivingWorksheet body);
        
        /// <summary>
        /// Add new audit for a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param>
        /// <param name="receivingWorksheetAudit">The audit to add</param>
        /// <returns></returns>
        void AddReceivingWorksheetAudit (int? receivingWorksheetId, string receivingWorksheetAudit);
  
        /// <summary>
        /// Add new audit for a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param>
        /// <param name="receivingWorksheetAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReceivingWorksheetAuditWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetAudit);
        
        /// <summary>
        /// Add new tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param>
        /// <param name="receivingWorksheetTag">The tag to add</param>
        /// <returns></returns>
        void AddReceivingWorksheetTag (int? receivingWorksheetId, string receivingWorksheetTag);
  
        /// <summary>
        /// Add new tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param>
        /// <param name="receivingWorksheetTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddReceivingWorksheetTagWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag);
        
        /// <summary>
        /// Delete a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param>
        /// <returns></returns>
        void DeleteReceivingWorksheet (int? receivingWorksheetId);
  
        /// <summary>
        /// Delete a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteReceivingWorksheetWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Delete a tag for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param>
        /// <param name="receivingWorksheetTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteReceivingWorksheetTag (int? receivingWorksheetId, string receivingWorksheetTag);
  
        /// <summary>
        /// Delete a tag for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param>
        /// <param name="receivingWorksheetTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteReceivingWorksheetTagWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag);
        
        /// <summary>
        /// Get a duplicated a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param>
        /// <returns>ReceivingWorksheet</returns>
        ReceivingWorksheet GetDuplicateReceivingWorksheetById (int? receivingWorksheetId);
  
        /// <summary>
        /// Get a duplicated a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param>
        /// <returns>ApiResponse of ReceivingWorksheet</returns>
        ApiResponse<ReceivingWorksheet> GetDuplicateReceivingWorksheetByIdWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Search receivingWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;ReceivingWorksheet&gt;</returns>
        List<ReceivingWorksheet> GetReceivingWorksheetByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search receivingWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;ReceivingWorksheet&gt;</returns>
        ApiResponse<List<ReceivingWorksheet>> GetReceivingWorksheetByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param>
        /// <returns>ReceivingWorksheet</returns>
        ReceivingWorksheet GetReceivingWorksheetById (int? receivingWorksheetId);
  
        /// <summary>
        /// Get a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param>
        /// <returns>ApiResponse of ReceivingWorksheet</returns>
        ApiResponse<ReceivingWorksheet> GetReceivingWorksheetByIdWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Get the tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param>
        /// <returns></returns>
        void GetReceivingWorksheetTags (int? receivingWorksheetId);
  
        /// <summary>
        /// Get the tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetReceivingWorksheetTagsWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Update a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns></returns>
        void UpdateReceivingWorksheet (ReceivingWorksheet body);
  
        /// <summary>
        /// Update a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateReceivingWorksheetWithHttpInfo (ReceivingWorksheet body);
        
        /// <summary>
        /// Update a receivingWorksheet custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns></returns>
        void UpdateReceivingWorksheetCustomFields (ReceivingWorksheet body);
  
        /// <summary>
        /// Update a receivingWorksheet custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateReceivingWorksheetCustomFieldsWithHttpInfo (ReceivingWorksheet body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param>
        /// <returns>Task of ReceivingWorksheet</returns>
        System.Threading.Tasks.Task<ReceivingWorksheet> AddReceivingWorksheetAsync (ReceivingWorksheet body);

        /// <summary>
        /// Create a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Inserts a new receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param>
        /// <returns>Task of ApiResponse (ReceivingWorksheet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReceivingWorksheet>> AddReceivingWorksheetAsyncWithHttpInfo (ReceivingWorksheet body);
        
        /// <summary>
        /// Add new audit for a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param>
        /// <param name="receivingWorksheetAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReceivingWorksheetAuditAsync (int? receivingWorksheetId, string receivingWorksheetAudit);

        /// <summary>
        /// Add new audit for a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param>
        /// <param name="receivingWorksheetAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingWorksheetAuditAsyncWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetAudit);
        
        /// <summary>
        /// Add new tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param>
        /// <param name="receivingWorksheetTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddReceivingWorksheetTagAsync (int? receivingWorksheetId, string receivingWorksheetTag);

        /// <summary>
        /// Add new tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing receivingWorksheet.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param>
        /// <param name="receivingWorksheetTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingWorksheetTagAsyncWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag);
        
        /// <summary>
        /// Delete a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteReceivingWorksheetAsync (int? receivingWorksheetId);

        /// <summary>
        /// Delete a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Deletes the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingWorksheetAsyncWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Delete a tag for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param>
        /// <param name="receivingWorksheetTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteReceivingWorksheetTagAsync (int? receivingWorksheetId, string receivingWorksheetTag);

        /// <summary>
        /// Delete a tag for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Deletes an existing receivingWorksheet tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param>
        /// <param name="receivingWorksheetTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingWorksheetTagAsyncWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag);
        
        /// <summary>
        /// Get a duplicated a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param>
        /// <returns>Task of ReceivingWorksheet</returns>
        System.Threading.Tasks.Task<ReceivingWorksheet> GetDuplicateReceivingWorksheetByIdAsync (int? receivingWorksheetId);

        /// <summary>
        /// Get a duplicated a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param>
        /// <returns>Task of ApiResponse (ReceivingWorksheet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReceivingWorksheet>> GetDuplicateReceivingWorksheetByIdAsyncWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Search receivingWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ReceivingWorksheet&gt;</returns>
        System.Threading.Tasks.Task<List<ReceivingWorksheet>> GetReceivingWorksheetByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search receivingWorksheets by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of receivingWorksheets that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ReceivingWorksheet&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ReceivingWorksheet>>> GetReceivingWorksheetByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param>
        /// <returns>Task of ReceivingWorksheet</returns>
        System.Threading.Tasks.Task<ReceivingWorksheet> GetReceivingWorksheetByIdAsync (int? receivingWorksheetId);

        /// <summary>
        /// Get a receivingWorksheet by id
        /// </summary>
        /// <remarks>
        /// Returns the receivingWorksheet identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param>
        /// <returns>Task of ApiResponse (ReceivingWorksheet)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReceivingWorksheet>> GetReceivingWorksheetByIdAsyncWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Get the tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetReceivingWorksheetTagsAsync (int? receivingWorksheetId);

        /// <summary>
        /// Get the tags for a receivingWorksheet.
        /// </summary>
        /// <remarks>
        /// Get all existing receivingWorksheet tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetReceivingWorksheetTagsAsyncWithHttpInfo (int? receivingWorksheetId);
        
        /// <summary>
        /// Update a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateReceivingWorksheetAsync (ReceivingWorksheet body);

        /// <summary>
        /// Update a receivingWorksheet
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReceivingWorksheetAsyncWithHttpInfo (ReceivingWorksheet body);
        
        /// <summary>
        /// Update a receivingWorksheet custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateReceivingWorksheetCustomFieldsAsync (ReceivingWorksheet body);

        /// <summary>
        /// Update a receivingWorksheet custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing receivingWorksheet custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReceivingWorksheetCustomFieldsAsyncWithHttpInfo (ReceivingWorksheet body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReceivingWorksheetApi : IReceivingWorksheetApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingWorksheetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReceivingWorksheetApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceivingWorksheetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReceivingWorksheetApi(Configuration configuration = null)
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
        /// Create a receivingWorksheet Inserts a new receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param> 
        /// <returns>ReceivingWorksheet</returns>
        public ReceivingWorksheet AddReceivingWorksheet (ReceivingWorksheet body)
        {
             ApiResponse<ReceivingWorksheet> localVarResponse = AddReceivingWorksheetWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a receivingWorksheet Inserts a new receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param> 
        /// <returns>ApiResponse of ReceivingWorksheet</returns>
        public ApiResponse< ReceivingWorksheet > AddReceivingWorksheetWithHttpInfo (ReceivingWorksheet body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReceivingWorksheetApi->AddReceivingWorksheet");
            
    
            var localVarPath = "/beta/receivingWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReceivingWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingWorksheet)));
            
        }

        
        /// <summary>
        /// Create a receivingWorksheet Inserts a new receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param>
        /// <returns>Task of ReceivingWorksheet</returns>
        public async System.Threading.Tasks.Task<ReceivingWorksheet> AddReceivingWorksheetAsync (ReceivingWorksheet body)
        {
             ApiResponse<ReceivingWorksheet> localVarResponse = await AddReceivingWorksheetAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a receivingWorksheet Inserts a new receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be inserted.</param>
        /// <returns>Task of ApiResponse (ReceivingWorksheet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReceivingWorksheet>> AddReceivingWorksheetAsyncWithHttpInfo (ReceivingWorksheet body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddReceivingWorksheet");
            
    
            var localVarPath = "/beta/receivingWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReceivingWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingWorksheet)));
            
        }
        
        /// <summary>
        /// Add new audit for a receivingWorksheet Adds an audit to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param> 
        /// <param name="receivingWorksheetAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddReceivingWorksheetAudit (int? receivingWorksheetId, string receivingWorksheetAudit)
        {
             AddReceivingWorksheetAuditWithHttpInfo(receivingWorksheetId, receivingWorksheetAudit);
        }

        /// <summary>
        /// Add new audit for a receivingWorksheet Adds an audit to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param> 
        /// <param name="receivingWorksheetAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReceivingWorksheetAuditWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetAudit)
        {
            
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling ReceivingWorksheetApi->AddReceivingWorksheetAudit");
            
            // verify the required parameter 'receivingWorksheetAudit' is set
            if (receivingWorksheetAudit == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetAudit' when calling ReceivingWorksheetApi->AddReceivingWorksheetAudit");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/audit/{receivingWorksheetAudit}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            if (receivingWorksheetAudit != null) localVarPathParams.Add("receivingWorksheetAudit", Configuration.ApiClient.ParameterToString(receivingWorksheetAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a receivingWorksheet Adds an audit to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param>
        /// <param name="receivingWorksheetAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReceivingWorksheetAuditAsync (int? receivingWorksheetId, string receivingWorksheetAudit)
        {
             await AddReceivingWorksheetAuditAsyncWithHttpInfo(receivingWorksheetId, receivingWorksheetAudit);

        }

        /// <summary>
        /// Add new audit for a receivingWorksheet Adds an audit to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add an audit to</param>
        /// <param name="receivingWorksheetAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingWorksheetAuditAsyncWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetAudit)
        {
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling AddReceivingWorksheetAudit");
            // verify the required parameter 'receivingWorksheetAudit' is set
            if (receivingWorksheetAudit == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetAudit' when calling AddReceivingWorksheetAudit");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/audit/{receivingWorksheetAudit}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            if (receivingWorksheetAudit != null) localVarPathParams.Add("receivingWorksheetAudit", Configuration.ApiClient.ParameterToString(receivingWorksheetAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a receivingWorksheet. Adds a tag to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param> 
        /// <param name="receivingWorksheetTag">The tag to add</param> 
        /// <returns></returns>
        public void AddReceivingWorksheetTag (int? receivingWorksheetId, string receivingWorksheetTag)
        {
             AddReceivingWorksheetTagWithHttpInfo(receivingWorksheetId, receivingWorksheetTag);
        }

        /// <summary>
        /// Add new tags for a receivingWorksheet. Adds a tag to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param> 
        /// <param name="receivingWorksheetTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddReceivingWorksheetTagWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag)
        {
            
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling ReceivingWorksheetApi->AddReceivingWorksheetTag");
            
            // verify the required parameter 'receivingWorksheetTag' is set
            if (receivingWorksheetTag == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetTag' when calling ReceivingWorksheetApi->AddReceivingWorksheetTag");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/tag/{receivingWorksheetTag}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            if (receivingWorksheetTag != null) localVarPathParams.Add("receivingWorksheetTag", Configuration.ApiClient.ParameterToString(receivingWorksheetTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a receivingWorksheet. Adds a tag to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param>
        /// <param name="receivingWorksheetTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddReceivingWorksheetTagAsync (int? receivingWorksheetId, string receivingWorksheetTag)
        {
             await AddReceivingWorksheetTagAsyncWithHttpInfo(receivingWorksheetId, receivingWorksheetTag);

        }

        /// <summary>
        /// Add new tags for a receivingWorksheet. Adds a tag to an existing receivingWorksheet.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to add a tag to</param>
        /// <param name="receivingWorksheetTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddReceivingWorksheetTagAsyncWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag)
        {
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling AddReceivingWorksheetTag");
            // verify the required parameter 'receivingWorksheetTag' is set
            if (receivingWorksheetTag == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetTag' when calling AddReceivingWorksheetTag");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/tag/{receivingWorksheetTag}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            if (receivingWorksheetTag != null) localVarPathParams.Add("receivingWorksheetTag", Configuration.ApiClient.ParameterToString(receivingWorksheetTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddReceivingWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a receivingWorksheet Deletes the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param> 
        /// <returns></returns>
        public void DeleteReceivingWorksheet (int? receivingWorksheetId)
        {
             DeleteReceivingWorksheetWithHttpInfo(receivingWorksheetId);
        }

        /// <summary>
        /// Delete a receivingWorksheet Deletes the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteReceivingWorksheetWithHttpInfo (int? receivingWorksheetId)
        {
            
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling ReceivingWorksheetApi->DeleteReceivingWorksheet");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a receivingWorksheet Deletes the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteReceivingWorksheetAsync (int? receivingWorksheetId)
        {
             await DeleteReceivingWorksheetAsyncWithHttpInfo(receivingWorksheetId);

        }

        /// <summary>
        /// Delete a receivingWorksheet Deletes the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingWorksheetAsyncWithHttpInfo (int? receivingWorksheetId)
        {
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling DeleteReceivingWorksheet");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a receivingWorksheet. Deletes an existing receivingWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param> 
        /// <param name="receivingWorksheetTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteReceivingWorksheetTag (int? receivingWorksheetId, string receivingWorksheetTag)
        {
             DeleteReceivingWorksheetTagWithHttpInfo(receivingWorksheetId, receivingWorksheetTag);
        }

        /// <summary>
        /// Delete a tag for a receivingWorksheet. Deletes an existing receivingWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param> 
        /// <param name="receivingWorksheetTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteReceivingWorksheetTagWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag)
        {
            
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling ReceivingWorksheetApi->DeleteReceivingWorksheetTag");
            
            // verify the required parameter 'receivingWorksheetTag' is set
            if (receivingWorksheetTag == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetTag' when calling ReceivingWorksheetApi->DeleteReceivingWorksheetTag");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/tag/{receivingWorksheetTag}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            if (receivingWorksheetTag != null) localVarPathParams.Add("receivingWorksheetTag", Configuration.ApiClient.ParameterToString(receivingWorksheetTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a receivingWorksheet. Deletes an existing receivingWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param>
        /// <param name="receivingWorksheetTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteReceivingWorksheetTagAsync (int? receivingWorksheetId, string receivingWorksheetTag)
        {
             await DeleteReceivingWorksheetTagAsyncWithHttpInfo(receivingWorksheetId, receivingWorksheetTag);

        }

        /// <summary>
        /// Delete a tag for a receivingWorksheet. Deletes an existing receivingWorksheet tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to remove tag from</param>
        /// <param name="receivingWorksheetTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteReceivingWorksheetTagAsyncWithHttpInfo (int? receivingWorksheetId, string receivingWorksheetTag)
        {
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling DeleteReceivingWorksheetTag");
            // verify the required parameter 'receivingWorksheetTag' is set
            if (receivingWorksheetTag == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetTag' when calling DeleteReceivingWorksheetTag");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/tag/{receivingWorksheetTag}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            if (receivingWorksheetTag != null) localVarPathParams.Add("receivingWorksheetTag", Configuration.ApiClient.ParameterToString(receivingWorksheetTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheetTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteReceivingWorksheetTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a receivingWorksheet by id Returns a duplicated receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param> 
        /// <returns>ReceivingWorksheet</returns>
        public ReceivingWorksheet GetDuplicateReceivingWorksheetById (int? receivingWorksheetId)
        {
             ApiResponse<ReceivingWorksheet> localVarResponse = GetDuplicateReceivingWorksheetByIdWithHttpInfo(receivingWorksheetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a receivingWorksheet by id Returns a duplicated receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param> 
        /// <returns>ApiResponse of ReceivingWorksheet</returns>
        public ApiResponse< ReceivingWorksheet > GetDuplicateReceivingWorksheetByIdWithHttpInfo (int? receivingWorksheetId)
        {
            
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling ReceivingWorksheetApi->GetDuplicateReceivingWorksheetById");
            
    
            var localVarPath = "/beta/receivingWorksheet/duplicate/{receivingWorksheetId}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReceivingWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingWorksheet)));
            
        }

        
        /// <summary>
        /// Get a duplicated a receivingWorksheet by id Returns a duplicated receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param>
        /// <returns>Task of ReceivingWorksheet</returns>
        public async System.Threading.Tasks.Task<ReceivingWorksheet> GetDuplicateReceivingWorksheetByIdAsync (int? receivingWorksheetId)
        {
             ApiResponse<ReceivingWorksheet> localVarResponse = await GetDuplicateReceivingWorksheetByIdAsyncWithHttpInfo(receivingWorksheetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a receivingWorksheet by id Returns a duplicated receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be duplicated.</param>
        /// <returns>Task of ApiResponse (ReceivingWorksheet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReceivingWorksheet>> GetDuplicateReceivingWorksheetByIdAsyncWithHttpInfo (int? receivingWorksheetId)
        {
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling GetDuplicateReceivingWorksheetById");
            
    
            var localVarPath = "/beta/receivingWorksheet/duplicate/{receivingWorksheetId}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateReceivingWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReceivingWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingWorksheet)));
            
        }
        
        /// <summary>
        /// Search receivingWorksheets by filter Returns the list of receivingWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;ReceivingWorksheet&gt;</returns>
        public List<ReceivingWorksheet> GetReceivingWorksheetByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ReceivingWorksheet>> localVarResponse = GetReceivingWorksheetByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search receivingWorksheets by filter Returns the list of receivingWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;ReceivingWorksheet&gt;</returns>
        public ApiResponse< List<ReceivingWorksheet> > GetReceivingWorksheetByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/receivingWorksheet/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<ReceivingWorksheet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ReceivingWorksheet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReceivingWorksheet>)));
            
        }

        
        /// <summary>
        /// Search receivingWorksheets by filter Returns the list of receivingWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;ReceivingWorksheet&gt;</returns>
        public async System.Threading.Tasks.Task<List<ReceivingWorksheet>> GetReceivingWorksheetByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<ReceivingWorksheet>> localVarResponse = await GetReceivingWorksheetByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search receivingWorksheets by filter Returns the list of receivingWorksheets that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ReceivingWorksheet&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ReceivingWorksheet>>> GetReceivingWorksheetByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/receivingWorksheet/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<ReceivingWorksheet>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ReceivingWorksheet>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ReceivingWorksheet>)));
            
        }
        
        /// <summary>
        /// Get a receivingWorksheet by id Returns the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param> 
        /// <returns>ReceivingWorksheet</returns>
        public ReceivingWorksheet GetReceivingWorksheetById (int? receivingWorksheetId)
        {
             ApiResponse<ReceivingWorksheet> localVarResponse = GetReceivingWorksheetByIdWithHttpInfo(receivingWorksheetId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a receivingWorksheet by id Returns the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param> 
        /// <returns>ApiResponse of ReceivingWorksheet</returns>
        public ApiResponse< ReceivingWorksheet > GetReceivingWorksheetByIdWithHttpInfo (int? receivingWorksheetId)
        {
            
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling ReceivingWorksheetApi->GetReceivingWorksheetById");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ReceivingWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingWorksheet)));
            
        }

        
        /// <summary>
        /// Get a receivingWorksheet by id Returns the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param>
        /// <returns>Task of ReceivingWorksheet</returns>
        public async System.Threading.Tasks.Task<ReceivingWorksheet> GetReceivingWorksheetByIdAsync (int? receivingWorksheetId)
        {
             ApiResponse<ReceivingWorksheet> localVarResponse = await GetReceivingWorksheetByIdAsyncWithHttpInfo(receivingWorksheetId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a receivingWorksheet by id Returns the receivingWorksheet identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to be returned.</param>
        /// <returns>Task of ApiResponse (ReceivingWorksheet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReceivingWorksheet>> GetReceivingWorksheetByIdAsyncWithHttpInfo (int? receivingWorksheetId)
        {
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling GetReceivingWorksheetById");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ReceivingWorksheet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReceivingWorksheet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReceivingWorksheet)));
            
        }
        
        /// <summary>
        /// Get the tags for a receivingWorksheet. Get all existing receivingWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param> 
        /// <returns></returns>
        public void GetReceivingWorksheetTags (int? receivingWorksheetId)
        {
             GetReceivingWorksheetTagsWithHttpInfo(receivingWorksheetId);
        }

        /// <summary>
        /// Get the tags for a receivingWorksheet. Get all existing receivingWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetReceivingWorksheetTagsWithHttpInfo (int? receivingWorksheetId)
        {
            
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null)
                throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling ReceivingWorksheetApi->GetReceivingWorksheetTags");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/tag";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a receivingWorksheet. Get all existing receivingWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetReceivingWorksheetTagsAsync (int? receivingWorksheetId)
        {
             await GetReceivingWorksheetTagsAsyncWithHttpInfo(receivingWorksheetId);

        }

        /// <summary>
        /// Get the tags for a receivingWorksheet. Get all existing receivingWorksheet tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="receivingWorksheetId">Id of the receivingWorksheet to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetReceivingWorksheetTagsAsyncWithHttpInfo (int? receivingWorksheetId)
        {
            // verify the required parameter 'receivingWorksheetId' is set
            if (receivingWorksheetId == null) throw new ApiException(400, "Missing required parameter 'receivingWorksheetId' when calling GetReceivingWorksheetTags");
            
    
            var localVarPath = "/beta/receivingWorksheet/{receivingWorksheetId}/tag";
    
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
            if (receivingWorksheetId != null) localVarPathParams.Add("receivingWorksheetId", Configuration.ApiClient.ParameterToString(receivingWorksheetId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetReceivingWorksheetTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a receivingWorksheet Updates an existing receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param> 
        /// <returns></returns>
        public void UpdateReceivingWorksheet (ReceivingWorksheet body)
        {
             UpdateReceivingWorksheetWithHttpInfo(body);
        }

        /// <summary>
        /// Update a receivingWorksheet Updates an existing receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateReceivingWorksheetWithHttpInfo (ReceivingWorksheet body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReceivingWorksheetApi->UpdateReceivingWorksheet");
            
    
            var localVarPath = "/beta/receivingWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a receivingWorksheet Updates an existing receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateReceivingWorksheetAsync (ReceivingWorksheet body)
        {
             await UpdateReceivingWorksheetAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a receivingWorksheet Updates an existing receivingWorksheet using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReceivingWorksheetAsyncWithHttpInfo (ReceivingWorksheet body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateReceivingWorksheet");
            
    
            var localVarPath = "/beta/receivingWorksheet";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a receivingWorksheet custom fields Updates an existing receivingWorksheet custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param> 
        /// <returns></returns>
        public void UpdateReceivingWorksheetCustomFields (ReceivingWorksheet body)
        {
             UpdateReceivingWorksheetCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a receivingWorksheet custom fields Updates an existing receivingWorksheet custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateReceivingWorksheetCustomFieldsWithHttpInfo (ReceivingWorksheet body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ReceivingWorksheetApi->UpdateReceivingWorksheetCustomFields");
            
    
            var localVarPath = "/beta/receivingWorksheet/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheetCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheetCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a receivingWorksheet custom fields Updates an existing receivingWorksheet custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateReceivingWorksheetCustomFieldsAsync (ReceivingWorksheet body)
        {
             await UpdateReceivingWorksheetCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a receivingWorksheet custom fields Updates an existing receivingWorksheet custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">ReceivingWorksheet to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateReceivingWorksheetCustomFieldsAsyncWithHttpInfo (ReceivingWorksheet body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateReceivingWorksheetCustomFields");
            
    
            var localVarPath = "/beta/receivingWorksheet/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheetCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateReceivingWorksheetCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
