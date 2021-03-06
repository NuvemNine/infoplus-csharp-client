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
    public interface IEmailTemplateApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an emailTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate AddEmailTemplate (EmailTemplate body);
  
        /// <summary>
        /// Create an emailTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param>
        /// <returns>ApiResponse of EmailTemplate</returns>
        ApiResponse<EmailTemplate> AddEmailTemplateWithHttpInfo (EmailTemplate body);
        
        /// <summary>
        /// Add new audit for an emailTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param>
        /// <param name="emailTemplateAudit">The audit to add</param>
        /// <returns></returns>
        void AddEmailTemplateAudit (int? emailTemplateId, string emailTemplateAudit);
  
        /// <summary>
        /// Add new audit for an emailTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param>
        /// <param name="emailTemplateAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddEmailTemplateAuditWithHttpInfo (int? emailTemplateId, string emailTemplateAudit);
        
        /// <summary>
        /// Add new tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param>
        /// <param name="emailTemplateTag">The tag to add</param>
        /// <returns></returns>
        void AddEmailTemplateTag (int? emailTemplateId, string emailTemplateTag);
  
        /// <summary>
        /// Add new tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param>
        /// <param name="emailTemplateTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddEmailTemplateTagWithHttpInfo (int? emailTemplateId, string emailTemplateTag);
        
        /// <summary>
        /// Delete an emailTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param>
        /// <returns></returns>
        void DeleteEmailTemplate (int? emailTemplateId);
  
        /// <summary>
        /// Delete an emailTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEmailTemplateWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Delete a tag for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing emailTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param>
        /// <param name="emailTemplateTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteEmailTemplateTag (int? emailTemplateId, string emailTemplateTag);
  
        /// <summary>
        /// Delete a tag for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing emailTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param>
        /// <param name="emailTemplateTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteEmailTemplateTagWithHttpInfo (int? emailTemplateId, string emailTemplateTag);
        
        /// <summary>
        /// Get a duplicated an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate GetDuplicateEmailTemplateById (int? emailTemplateId);
  
        /// <summary>
        /// Get a duplicated an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param>
        /// <returns>ApiResponse of EmailTemplate</returns>
        ApiResponse<EmailTemplate> GetDuplicateEmailTemplateByIdWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Search emailTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of emailTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;EmailTemplate&gt;</returns>
        List<EmailTemplate> GetEmailTemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search emailTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of emailTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;EmailTemplate&gt;</returns>
        ApiResponse<List<EmailTemplate>> GetEmailTemplateByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param>
        /// <returns>EmailTemplate</returns>
        EmailTemplate GetEmailTemplateById (int? emailTemplateId);
  
        /// <summary>
        /// Get an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param>
        /// <returns>ApiResponse of EmailTemplate</returns>
        ApiResponse<EmailTemplate> GetEmailTemplateByIdWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Get the tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing emailTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param>
        /// <returns></returns>
        void GetEmailTemplateTags (int? emailTemplateId);
  
        /// <summary>
        /// Get the tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing emailTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetEmailTemplateTagsWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Update an emailTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns></returns>
        void UpdateEmailTemplate (EmailTemplate body);
  
        /// <summary>
        /// Update an emailTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateEmailTemplateWithHttpInfo (EmailTemplate body);
        
        /// <summary>
        /// Update an emailTemplate custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns></returns>
        void UpdateEmailTemplateCustomFields (EmailTemplate body);
  
        /// <summary>
        /// Update an emailTemplate custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateEmailTemplateCustomFieldsWithHttpInfo (EmailTemplate body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an emailTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param>
        /// <returns>Task of EmailTemplate</returns>
        System.Threading.Tasks.Task<EmailTemplate> AddEmailTemplateAsync (EmailTemplate body);

        /// <summary>
        /// Create an emailTemplate
        /// </summary>
        /// <remarks>
        /// Inserts a new emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param>
        /// <returns>Task of ApiResponse (EmailTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailTemplate>> AddEmailTemplateAsyncWithHttpInfo (EmailTemplate body);
        
        /// <summary>
        /// Add new audit for an emailTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param>
        /// <param name="emailTemplateAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddEmailTemplateAuditAsync (int? emailTemplateId, string emailTemplateAudit);

        /// <summary>
        /// Add new audit for an emailTemplate
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param>
        /// <param name="emailTemplateAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddEmailTemplateAuditAsyncWithHttpInfo (int? emailTemplateId, string emailTemplateAudit);
        
        /// <summary>
        /// Add new tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param>
        /// <param name="emailTemplateTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddEmailTemplateTagAsync (int? emailTemplateId, string emailTemplateTag);

        /// <summary>
        /// Add new tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing emailTemplate.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param>
        /// <param name="emailTemplateTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddEmailTemplateTagAsyncWithHttpInfo (int? emailTemplateId, string emailTemplateTag);
        
        /// <summary>
        /// Delete an emailTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEmailTemplateAsync (int? emailTemplateId);

        /// <summary>
        /// Delete an emailTemplate
        /// </summary>
        /// <remarks>
        /// Deletes the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmailTemplateAsyncWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Delete a tag for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing emailTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param>
        /// <param name="emailTemplateTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteEmailTemplateTagAsync (int? emailTemplateId, string emailTemplateTag);

        /// <summary>
        /// Delete a tag for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Deletes an existing emailTemplate tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param>
        /// <param name="emailTemplateTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmailTemplateTagAsyncWithHttpInfo (int? emailTemplateId, string emailTemplateTag);
        
        /// <summary>
        /// Get a duplicated an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param>
        /// <returns>Task of EmailTemplate</returns>
        System.Threading.Tasks.Task<EmailTemplate> GetDuplicateEmailTemplateByIdAsync (int? emailTemplateId);

        /// <summary>
        /// Get a duplicated an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param>
        /// <returns>Task of ApiResponse (EmailTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailTemplate>> GetDuplicateEmailTemplateByIdAsyncWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Search emailTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of emailTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;EmailTemplate&gt;</returns>
        System.Threading.Tasks.Task<List<EmailTemplate>> GetEmailTemplateByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search emailTemplates by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of emailTemplates that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EmailTemplate&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<EmailTemplate>>> GetEmailTemplateByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param>
        /// <returns>Task of EmailTemplate</returns>
        System.Threading.Tasks.Task<EmailTemplate> GetEmailTemplateByIdAsync (int? emailTemplateId);

        /// <summary>
        /// Get an emailTemplate by id
        /// </summary>
        /// <remarks>
        /// Returns the emailTemplate identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param>
        /// <returns>Task of ApiResponse (EmailTemplate)</returns>
        System.Threading.Tasks.Task<ApiResponse<EmailTemplate>> GetEmailTemplateByIdAsyncWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Get the tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing emailTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetEmailTemplateTagsAsync (int? emailTemplateId);

        /// <summary>
        /// Get the tags for an emailTemplate.
        /// </summary>
        /// <remarks>
        /// Get all existing emailTemplate tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetEmailTemplateTagsAsyncWithHttpInfo (int? emailTemplateId);
        
        /// <summary>
        /// Update an emailTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateEmailTemplateAsync (EmailTemplate body);

        /// <summary>
        /// Update an emailTemplate
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateEmailTemplateAsyncWithHttpInfo (EmailTemplate body);
        
        /// <summary>
        /// Update an emailTemplate custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateEmailTemplateCustomFieldsAsync (EmailTemplate body);

        /// <summary>
        /// Update an emailTemplate custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing emailTemplate custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateEmailTemplateCustomFieldsAsyncWithHttpInfo (EmailTemplate body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmailTemplateApi : IEmailTemplateApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailTemplateApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailTemplateApi(Configuration configuration = null)
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
        /// Create an emailTemplate Inserts a new emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param> 
        /// <returns>EmailTemplate</returns>
        public EmailTemplate AddEmailTemplate (EmailTemplate body)
        {
             ApiResponse<EmailTemplate> localVarResponse = AddEmailTemplateWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an emailTemplate Inserts a new emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param> 
        /// <returns>ApiResponse of EmailTemplate</returns>
        public ApiResponse< EmailTemplate > AddEmailTemplateWithHttpInfo (EmailTemplate body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmailTemplateApi->AddEmailTemplate");
            
    
            var localVarPath = "/beta/emailTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailTemplate)));
            
        }

        
        /// <summary>
        /// Create an emailTemplate Inserts a new emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param>
        /// <returns>Task of EmailTemplate</returns>
        public async System.Threading.Tasks.Task<EmailTemplate> AddEmailTemplateAsync (EmailTemplate body)
        {
             ApiResponse<EmailTemplate> localVarResponse = await AddEmailTemplateAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an emailTemplate Inserts a new emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be inserted.</param>
        /// <returns>Task of ApiResponse (EmailTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailTemplate>> AddEmailTemplateAsyncWithHttpInfo (EmailTemplate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddEmailTemplate");
            
    
            var localVarPath = "/beta/emailTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailTemplate)));
            
        }
        
        /// <summary>
        /// Add new audit for an emailTemplate Adds an audit to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param> 
        /// <param name="emailTemplateAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddEmailTemplateAudit (int? emailTemplateId, string emailTemplateAudit)
        {
             AddEmailTemplateAuditWithHttpInfo(emailTemplateId, emailTemplateAudit);
        }

        /// <summary>
        /// Add new audit for an emailTemplate Adds an audit to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param> 
        /// <param name="emailTemplateAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddEmailTemplateAuditWithHttpInfo (int? emailTemplateId, string emailTemplateAudit)
        {
            
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling EmailTemplateApi->AddEmailTemplateAudit");
            
            // verify the required parameter 'emailTemplateAudit' is set
            if (emailTemplateAudit == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateAudit' when calling EmailTemplateApi->AddEmailTemplateAudit");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/audit/{emailTemplateAudit}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            if (emailTemplateAudit != null) localVarPathParams.Add("emailTemplateAudit", Configuration.ApiClient.ParameterToString(emailTemplateAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for an emailTemplate Adds an audit to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param>
        /// <param name="emailTemplateAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddEmailTemplateAuditAsync (int? emailTemplateId, string emailTemplateAudit)
        {
             await AddEmailTemplateAuditAsyncWithHttpInfo(emailTemplateId, emailTemplateAudit);

        }

        /// <summary>
        /// Add new audit for an emailTemplate Adds an audit to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add an audit to</param>
        /// <param name="emailTemplateAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddEmailTemplateAuditAsyncWithHttpInfo (int? emailTemplateId, string emailTemplateAudit)
        {
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null) throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling AddEmailTemplateAudit");
            // verify the required parameter 'emailTemplateAudit' is set
            if (emailTemplateAudit == null) throw new ApiException(400, "Missing required parameter 'emailTemplateAudit' when calling AddEmailTemplateAudit");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/audit/{emailTemplateAudit}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            if (emailTemplateAudit != null) localVarPathParams.Add("emailTemplateAudit", Configuration.ApiClient.ParameterToString(emailTemplateAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for an emailTemplate. Adds a tag to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param> 
        /// <param name="emailTemplateTag">The tag to add</param> 
        /// <returns></returns>
        public void AddEmailTemplateTag (int? emailTemplateId, string emailTemplateTag)
        {
             AddEmailTemplateTagWithHttpInfo(emailTemplateId, emailTemplateTag);
        }

        /// <summary>
        /// Add new tags for an emailTemplate. Adds a tag to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param> 
        /// <param name="emailTemplateTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddEmailTemplateTagWithHttpInfo (int? emailTemplateId, string emailTemplateTag)
        {
            
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling EmailTemplateApi->AddEmailTemplateTag");
            
            // verify the required parameter 'emailTemplateTag' is set
            if (emailTemplateTag == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateTag' when calling EmailTemplateApi->AddEmailTemplateTag");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/tag/{emailTemplateTag}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            if (emailTemplateTag != null) localVarPathParams.Add("emailTemplateTag", Configuration.ApiClient.ParameterToString(emailTemplateTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for an emailTemplate. Adds a tag to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param>
        /// <param name="emailTemplateTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddEmailTemplateTagAsync (int? emailTemplateId, string emailTemplateTag)
        {
             await AddEmailTemplateTagAsyncWithHttpInfo(emailTemplateId, emailTemplateTag);

        }

        /// <summary>
        /// Add new tags for an emailTemplate. Adds a tag to an existing emailTemplate.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to add a tag to</param>
        /// <param name="emailTemplateTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddEmailTemplateTagAsyncWithHttpInfo (int? emailTemplateId, string emailTemplateTag)
        {
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null) throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling AddEmailTemplateTag");
            // verify the required parameter 'emailTemplateTag' is set
            if (emailTemplateTag == null) throw new ApiException(400, "Missing required parameter 'emailTemplateTag' when calling AddEmailTemplateTag");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/tag/{emailTemplateTag}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            if (emailTemplateTag != null) localVarPathParams.Add("emailTemplateTag", Configuration.ApiClient.ParameterToString(emailTemplateTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddEmailTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete an emailTemplate Deletes the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param> 
        /// <returns></returns>
        public void DeleteEmailTemplate (int? emailTemplateId)
        {
             DeleteEmailTemplateWithHttpInfo(emailTemplateId);
        }

        /// <summary>
        /// Delete an emailTemplate Deletes the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEmailTemplateWithHttpInfo (int? emailTemplateId)
        {
            
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling EmailTemplateApi->DeleteEmailTemplate");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete an emailTemplate Deletes the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteEmailTemplateAsync (int? emailTemplateId)
        {
             await DeleteEmailTemplateAsyncWithHttpInfo(emailTemplateId);

        }

        /// <summary>
        /// Delete an emailTemplate Deletes the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmailTemplateAsyncWithHttpInfo (int? emailTemplateId)
        {
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null) throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling DeleteEmailTemplate");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for an emailTemplate. Deletes an existing emailTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param> 
        /// <param name="emailTemplateTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteEmailTemplateTag (int? emailTemplateId, string emailTemplateTag)
        {
             DeleteEmailTemplateTagWithHttpInfo(emailTemplateId, emailTemplateTag);
        }

        /// <summary>
        /// Delete a tag for an emailTemplate. Deletes an existing emailTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param> 
        /// <param name="emailTemplateTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteEmailTemplateTagWithHttpInfo (int? emailTemplateId, string emailTemplateTag)
        {
            
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling EmailTemplateApi->DeleteEmailTemplateTag");
            
            // verify the required parameter 'emailTemplateTag' is set
            if (emailTemplateTag == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateTag' when calling EmailTemplateApi->DeleteEmailTemplateTag");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/tag/{emailTemplateTag}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            if (emailTemplateTag != null) localVarPathParams.Add("emailTemplateTag", Configuration.ApiClient.ParameterToString(emailTemplateTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for an emailTemplate. Deletes an existing emailTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param>
        /// <param name="emailTemplateTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteEmailTemplateTagAsync (int? emailTemplateId, string emailTemplateTag)
        {
             await DeleteEmailTemplateTagAsyncWithHttpInfo(emailTemplateId, emailTemplateTag);

        }

        /// <summary>
        /// Delete a tag for an emailTemplate. Deletes an existing emailTemplate tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to remove tag from</param>
        /// <param name="emailTemplateTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteEmailTemplateTagAsyncWithHttpInfo (int? emailTemplateId, string emailTemplateTag)
        {
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null) throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling DeleteEmailTemplateTag");
            // verify the required parameter 'emailTemplateTag' is set
            if (emailTemplateTag == null) throw new ApiException(400, "Missing required parameter 'emailTemplateTag' when calling DeleteEmailTemplateTag");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/tag/{emailTemplateTag}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            if (emailTemplateTag != null) localVarPathParams.Add("emailTemplateTag", Configuration.ApiClient.ParameterToString(emailTemplateTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplateTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteEmailTemplateTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated an emailTemplate by id Returns a duplicated emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param> 
        /// <returns>EmailTemplate</returns>
        public EmailTemplate GetDuplicateEmailTemplateById (int? emailTemplateId)
        {
             ApiResponse<EmailTemplate> localVarResponse = GetDuplicateEmailTemplateByIdWithHttpInfo(emailTemplateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated an emailTemplate by id Returns a duplicated emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param> 
        /// <returns>ApiResponse of EmailTemplate</returns>
        public ApiResponse< EmailTemplate > GetDuplicateEmailTemplateByIdWithHttpInfo (int? emailTemplateId)
        {
            
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling EmailTemplateApi->GetDuplicateEmailTemplateById");
            
    
            var localVarPath = "/beta/emailTemplate/duplicate/{emailTemplateId}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateEmailTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateEmailTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailTemplate)));
            
        }

        
        /// <summary>
        /// Get a duplicated an emailTemplate by id Returns a duplicated emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param>
        /// <returns>Task of EmailTemplate</returns>
        public async System.Threading.Tasks.Task<EmailTemplate> GetDuplicateEmailTemplateByIdAsync (int? emailTemplateId)
        {
             ApiResponse<EmailTemplate> localVarResponse = await GetDuplicateEmailTemplateByIdAsyncWithHttpInfo(emailTemplateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated an emailTemplate by id Returns a duplicated emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be duplicated.</param>
        /// <returns>Task of ApiResponse (EmailTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailTemplate>> GetDuplicateEmailTemplateByIdAsyncWithHttpInfo (int? emailTemplateId)
        {
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null) throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling GetDuplicateEmailTemplateById");
            
    
            var localVarPath = "/beta/emailTemplate/duplicate/{emailTemplateId}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateEmailTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateEmailTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailTemplate)));
            
        }
        
        /// <summary>
        /// Search emailTemplates by filter Returns the list of emailTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;EmailTemplate&gt;</returns>
        public List<EmailTemplate> GetEmailTemplateByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<EmailTemplate>> localVarResponse = GetEmailTemplateByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search emailTemplates by filter Returns the list of emailTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;EmailTemplate&gt;</returns>
        public ApiResponse< List<EmailTemplate> > GetEmailTemplateByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/emailTemplate/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<EmailTemplate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EmailTemplate>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EmailTemplate>)));
            
        }

        
        /// <summary>
        /// Search emailTemplates by filter Returns the list of emailTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;EmailTemplate&gt;</returns>
        public async System.Threading.Tasks.Task<List<EmailTemplate>> GetEmailTemplateByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<EmailTemplate>> localVarResponse = await GetEmailTemplateByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search emailTemplates by filter Returns the list of emailTemplates that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;EmailTemplate&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<EmailTemplate>>> GetEmailTemplateByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/emailTemplate/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<EmailTemplate>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<EmailTemplate>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<EmailTemplate>)));
            
        }
        
        /// <summary>
        /// Get an emailTemplate by id Returns the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param> 
        /// <returns>EmailTemplate</returns>
        public EmailTemplate GetEmailTemplateById (int? emailTemplateId)
        {
             ApiResponse<EmailTemplate> localVarResponse = GetEmailTemplateByIdWithHttpInfo(emailTemplateId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an emailTemplate by id Returns the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param> 
        /// <returns>ApiResponse of EmailTemplate</returns>
        public ApiResponse< EmailTemplate > GetEmailTemplateByIdWithHttpInfo (int? emailTemplateId)
        {
            
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling EmailTemplateApi->GetEmailTemplateById");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EmailTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailTemplate)));
            
        }

        
        /// <summary>
        /// Get an emailTemplate by id Returns the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param>
        /// <returns>Task of EmailTemplate</returns>
        public async System.Threading.Tasks.Task<EmailTemplate> GetEmailTemplateByIdAsync (int? emailTemplateId)
        {
             ApiResponse<EmailTemplate> localVarResponse = await GetEmailTemplateByIdAsyncWithHttpInfo(emailTemplateId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an emailTemplate by id Returns the emailTemplate identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to be returned.</param>
        /// <returns>Task of ApiResponse (EmailTemplate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EmailTemplate>> GetEmailTemplateByIdAsyncWithHttpInfo (int? emailTemplateId)
        {
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null) throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling GetEmailTemplateById");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EmailTemplate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EmailTemplate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EmailTemplate)));
            
        }
        
        /// <summary>
        /// Get the tags for an emailTemplate. Get all existing emailTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param> 
        /// <returns></returns>
        public void GetEmailTemplateTags (int? emailTemplateId)
        {
             GetEmailTemplateTagsWithHttpInfo(emailTemplateId);
        }

        /// <summary>
        /// Get the tags for an emailTemplate. Get all existing emailTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetEmailTemplateTagsWithHttpInfo (int? emailTemplateId)
        {
            
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null)
                throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling EmailTemplateApi->GetEmailTemplateTags");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/tag";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for an emailTemplate. Get all existing emailTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetEmailTemplateTagsAsync (int? emailTemplateId)
        {
             await GetEmailTemplateTagsAsyncWithHttpInfo(emailTemplateId);

        }

        /// <summary>
        /// Get the tags for an emailTemplate. Get all existing emailTemplate tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="emailTemplateId">Id of the emailTemplate to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetEmailTemplateTagsAsyncWithHttpInfo (int? emailTemplateId)
        {
            // verify the required parameter 'emailTemplateId' is set
            if (emailTemplateId == null) throw new ApiException(400, "Missing required parameter 'emailTemplateId' when calling GetEmailTemplateTags");
            
    
            var localVarPath = "/beta/emailTemplate/{emailTemplateId}/tag";
    
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
            if (emailTemplateId != null) localVarPathParams.Add("emailTemplateId", Configuration.ApiClient.ParameterToString(emailTemplateId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEmailTemplateTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an emailTemplate Updates an existing emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param> 
        /// <returns></returns>
        public void UpdateEmailTemplate (EmailTemplate body)
        {
             UpdateEmailTemplateWithHttpInfo(body);
        }

        /// <summary>
        /// Update an emailTemplate Updates an existing emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateEmailTemplateWithHttpInfo (EmailTemplate body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmailTemplateApi->UpdateEmailTemplate");
            
    
            var localVarPath = "/beta/emailTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an emailTemplate Updates an existing emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateEmailTemplateAsync (EmailTemplate body)
        {
             await UpdateEmailTemplateAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an emailTemplate Updates an existing emailTemplate using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateEmailTemplateAsyncWithHttpInfo (EmailTemplate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateEmailTemplate");
            
    
            var localVarPath = "/beta/emailTemplate";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplate: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplate: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update an emailTemplate custom fields Updates an existing emailTemplate custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param> 
        /// <returns></returns>
        public void UpdateEmailTemplateCustomFields (EmailTemplate body)
        {
             UpdateEmailTemplateCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update an emailTemplate custom fields Updates an existing emailTemplate custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateEmailTemplateCustomFieldsWithHttpInfo (EmailTemplate body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling EmailTemplateApi->UpdateEmailTemplateCustomFields");
            
    
            var localVarPath = "/beta/emailTemplate/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplateCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplateCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update an emailTemplate custom fields Updates an existing emailTemplate custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateEmailTemplateCustomFieldsAsync (EmailTemplate body)
        {
             await UpdateEmailTemplateCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update an emailTemplate custom fields Updates an existing emailTemplate custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">EmailTemplate to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateEmailTemplateCustomFieldsAsyncWithHttpInfo (EmailTemplate body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateEmailTemplateCustomFields");
            
    
            var localVarPath = "/beta/emailTemplate/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplateCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateEmailTemplateCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
