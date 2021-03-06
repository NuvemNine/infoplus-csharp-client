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
    public interface IVendorComplianceSurveyApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>VendorComplianceSurvey</returns>
        VendorComplianceSurvey AddVendorComplianceSurvey (VendorComplianceSurvey body);
  
        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        ApiResponse<VendorComplianceSurvey> AddVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body);
        
        /// <summary>
        /// Add new audit for a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param>
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param>
        /// <returns></returns>
        void AddVendorComplianceSurveyAudit (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit);
  
        /// <summary>
        /// Add new audit for a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param>
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddVendorComplianceSurveyAuditWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit);
        
        /// <summary>
        /// Add new tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param>
        /// <param name="vendorComplianceSurveyTag">The tag to add</param>
        /// <returns></returns>
        void AddVendorComplianceSurveyTag (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);
  
        /// <summary>
        /// Add new tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param>
        /// <param name="vendorComplianceSurveyTag">The tag to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddVendorComplianceSurveyTagWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);
        
        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns></returns>
        void DeleteVendorComplianceSurvey (int? vendorComplianceSurveyId);
  
        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVendorComplianceSurveyWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param>
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param>
        /// <returns></returns>
        void DeleteVendorComplianceSurveyTag (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);
  
        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param>
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVendorComplianceSurveyTagWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);
        
        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param>
        /// <returns>VendorComplianceSurvey</returns>
        VendorComplianceSurvey GetDuplicateVendorComplianceSurveyById (int? vendorComplianceSurveyId);
  
        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param>
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        ApiResponse<VendorComplianceSurvey> GetDuplicateVendorComplianceSurveyByIdWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>List&lt;VendorComplianceSurvey&gt;</returns>
        List<VendorComplianceSurvey> GetVendorComplianceSurveyByFilter (string filter = null, int? page = null, int? limit = null, string sort = null);
  
        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>ApiResponse of List&lt;VendorComplianceSurvey&gt;</returns>
        ApiResponse<List<VendorComplianceSurvey>> GetVendorComplianceSurveyByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>VendorComplianceSurvey</returns>
        VendorComplianceSurvey GetVendorComplianceSurveyById (int? vendorComplianceSurveyId);
  
        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        ApiResponse<VendorComplianceSurvey> GetVendorComplianceSurveyByIdWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Get the tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Get all existing vendorComplianceSurvey tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param>
        /// <returns></returns>
        void GetVendorComplianceSurveyTags (int? vendorComplianceSurveyId);
  
        /// <summary>
        /// Get the tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Get all existing vendorComplianceSurvey tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetVendorComplianceSurveyTagsWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns></returns>
        void UpdateVendorComplianceSurvey (VendorComplianceSurvey body);
  
        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body);
        
        /// <summary>
        /// Update a vendorComplianceSurvey custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns></returns>
        void UpdateVendorComplianceSurveyCustomFields (VendorComplianceSurvey body);
  
        /// <summary>
        /// Update a vendorComplianceSurvey custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateVendorComplianceSurveyCustomFieldsWithHttpInfo (VendorComplianceSurvey body);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        System.Threading.Tasks.Task<VendorComplianceSurvey> AddVendorComplianceSurveyAsync (VendorComplianceSurvey body);

        /// <summary>
        /// Create a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Inserts a new vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> AddVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body);
        
        /// <summary>
        /// Add new audit for a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param>
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddVendorComplianceSurveyAuditAsync (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit);

        /// <summary>
        /// Add new audit for a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Adds an audit to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param>
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddVendorComplianceSurveyAuditAsyncWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit);
        
        /// <summary>
        /// Add new tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param>
        /// <param name="vendorComplianceSurveyTag">The tag to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddVendorComplianceSurveyTagAsync (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);

        /// <summary>
        /// Add new tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Adds a tag to an existing vendorComplianceSurvey.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param>
        /// <param name="vendorComplianceSurveyTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddVendorComplianceSurveyTagAsyncWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);
        
        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteVendorComplianceSurveyAsync (int? vendorComplianceSurveyId);

        /// <summary>
        /// Delete a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Deletes the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVendorComplianceSurveyAsyncWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param>
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteVendorComplianceSurveyTagAsync (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);

        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param>
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVendorComplianceSurveyTagAsyncWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag);
        
        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        System.Threading.Tasks.Task<VendorComplianceSurvey> GetDuplicateVendorComplianceSurveyByIdAsync (int? vendorComplianceSurveyId);

        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> GetDuplicateVendorComplianceSurveyByIdAsyncWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;VendorComplianceSurvey&gt;</returns>
        System.Threading.Tasks.Task<List<VendorComplianceSurvey>> GetVendorComplianceSurveyByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null);

        /// <summary>
        /// Search vendorComplianceSurveys by filter
        /// </summary>
        /// <remarks>
        /// Returns the list of vendorComplianceSurveys that match the given filter.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;VendorComplianceSurvey&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VendorComplianceSurvey>>> GetVendorComplianceSurveyByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null);
        
        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        System.Threading.Tasks.Task<VendorComplianceSurvey> GetVendorComplianceSurveyByIdAsync (int? vendorComplianceSurveyId);

        /// <summary>
        /// Get a vendorComplianceSurvey by id
        /// </summary>
        /// <remarks>
        /// Returns the vendorComplianceSurvey identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> GetVendorComplianceSurveyByIdAsyncWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Get the tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Get all existing vendorComplianceSurvey tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetVendorComplianceSurveyTagsAsync (int? vendorComplianceSurveyId);

        /// <summary>
        /// Get the tags for a vendorComplianceSurvey.
        /// </summary>
        /// <remarks>
        /// Get all existing vendorComplianceSurvey tags.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetVendorComplianceSurveyTagsAsyncWithHttpInfo (int? vendorComplianceSurveyId);
        
        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateVendorComplianceSurveyAsync (VendorComplianceSurvey body);

        /// <summary>
        /// Update a vendorComplianceSurvey
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body);
        
        /// <summary>
        /// Update a vendorComplianceSurvey custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateVendorComplianceSurveyCustomFieldsAsync (VendorComplianceSurvey body);

        /// <summary>
        /// Update a vendorComplianceSurvey custom fields
        /// </summary>
        /// <remarks>
        /// Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateVendorComplianceSurveyCustomFieldsAsyncWithHttpInfo (VendorComplianceSurvey body);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VendorComplianceSurveyApi : IVendorComplianceSurveyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorComplianceSurveyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VendorComplianceSurveyApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorComplianceSurveyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VendorComplianceSurveyApi(Configuration configuration = null)
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
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param> 
        /// <returns>VendorComplianceSurvey</returns>
        public VendorComplianceSurvey AddVendorComplianceSurvey (VendorComplianceSurvey body)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = AddVendorComplianceSurveyWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param> 
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        public ApiResponse< VendorComplianceSurvey > AddVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VendorComplianceSurveyApi->AddVendorComplianceSurvey");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }

        
        /// <summary>
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        public async System.Threading.Tasks.Task<VendorComplianceSurvey> AddVendorComplianceSurveyAsync (VendorComplianceSurvey body)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = await AddVendorComplianceSurveyAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a vendorComplianceSurvey Inserts a new vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be inserted.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> AddVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AddVendorComplianceSurvey");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }
        
        /// <summary>
        /// Add new audit for a vendorComplianceSurvey Adds an audit to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param> 
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param> 
        /// <returns></returns>
        public void AddVendorComplianceSurveyAudit (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit)
        {
             AddVendorComplianceSurveyAuditWithHttpInfo(vendorComplianceSurveyId, vendorComplianceSurveyAudit);
        }

        /// <summary>
        /// Add new audit for a vendorComplianceSurvey Adds an audit to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param> 
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddVendorComplianceSurveyAuditWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->AddVendorComplianceSurveyAudit");
            
            // verify the required parameter 'vendorComplianceSurveyAudit' is set
            if (vendorComplianceSurveyAudit == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyAudit' when calling VendorComplianceSurveyApi->AddVendorComplianceSurveyAudit");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/audit/{vendorComplianceSurveyAudit}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            if (vendorComplianceSurveyAudit != null) localVarPathParams.Add("vendorComplianceSurveyAudit", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyAudit)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new audit for a vendorComplianceSurvey Adds an audit to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param>
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddVendorComplianceSurveyAuditAsync (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit)
        {
             await AddVendorComplianceSurveyAuditAsyncWithHttpInfo(vendorComplianceSurveyId, vendorComplianceSurveyAudit);

        }

        /// <summary>
        /// Add new audit for a vendorComplianceSurvey Adds an audit to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add an audit to</param>
        /// <param name="vendorComplianceSurveyAudit">The audit to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddVendorComplianceSurveyAuditAsyncWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyAudit)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling AddVendorComplianceSurveyAudit");
            // verify the required parameter 'vendorComplianceSurveyAudit' is set
            if (vendorComplianceSurveyAudit == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyAudit' when calling AddVendorComplianceSurveyAudit");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/audit/{vendorComplianceSurveyAudit}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            if (vendorComplianceSurveyAudit != null) localVarPathParams.Add("vendorComplianceSurveyAudit", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyAudit)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyAudit: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyAudit: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Add new tags for a vendorComplianceSurvey. Adds a tag to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param> 
        /// <param name="vendorComplianceSurveyTag">The tag to add</param> 
        /// <returns></returns>
        public void AddVendorComplianceSurveyTag (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
             AddVendorComplianceSurveyTagWithHttpInfo(vendorComplianceSurveyId, vendorComplianceSurveyTag);
        }

        /// <summary>
        /// Add new tags for a vendorComplianceSurvey. Adds a tag to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param> 
        /// <param name="vendorComplianceSurveyTag">The tag to add</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddVendorComplianceSurveyTagWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->AddVendorComplianceSurveyTag");
            
            // verify the required parameter 'vendorComplianceSurveyTag' is set
            if (vendorComplianceSurveyTag == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyTag' when calling VendorComplianceSurveyApi->AddVendorComplianceSurveyTag");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag/{vendorComplianceSurveyTag}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            if (vendorComplianceSurveyTag != null) localVarPathParams.Add("vendorComplianceSurveyTag", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Add new tags for a vendorComplianceSurvey. Adds a tag to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param>
        /// <param name="vendorComplianceSurveyTag">The tag to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddVendorComplianceSurveyTagAsync (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
             await AddVendorComplianceSurveyTagAsyncWithHttpInfo(vendorComplianceSurveyId, vendorComplianceSurveyTag);

        }

        /// <summary>
        /// Add new tags for a vendorComplianceSurvey. Adds a tag to an existing vendorComplianceSurvey.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to add a tag to</param>
        /// <param name="vendorComplianceSurveyTag">The tag to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddVendorComplianceSurveyTagAsyncWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling AddVendorComplianceSurveyTag");
            // verify the required parameter 'vendorComplianceSurveyTag' is set
            if (vendorComplianceSurveyTag == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyTag' when calling AddVendorComplianceSurveyTag");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag/{vendorComplianceSurveyTag}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            if (vendorComplianceSurveyTag != null) localVarPathParams.Add("vendorComplianceSurveyTag", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AddVendorComplianceSurveyTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param> 
        /// <returns></returns>
        public void DeleteVendorComplianceSurvey (int? vendorComplianceSurveyId)
        {
             DeleteVendorComplianceSurveyWithHttpInfo(vendorComplianceSurveyId);
        }

        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteVendorComplianceSurveyWithHttpInfo (int? vendorComplianceSurveyId)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->DeleteVendorComplianceSurvey");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteVendorComplianceSurveyAsync (int? vendorComplianceSurveyId)
        {
             await DeleteVendorComplianceSurveyAsyncWithHttpInfo(vendorComplianceSurveyId);

        }

        /// <summary>
        /// Delete a vendorComplianceSurvey Deletes the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be deleted.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVendorComplianceSurveyAsyncWithHttpInfo (int? vendorComplianceSurveyId)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling DeleteVendorComplianceSurvey");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey. Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param> 
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param> 
        /// <returns></returns>
        public void DeleteVendorComplianceSurveyTag (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
             DeleteVendorComplianceSurveyTagWithHttpInfo(vendorComplianceSurveyId, vendorComplianceSurveyTag);
        }

        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey. Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param> 
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteVendorComplianceSurveyTagWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->DeleteVendorComplianceSurveyTag");
            
            // verify the required parameter 'vendorComplianceSurveyTag' is set
            if (vendorComplianceSurveyTag == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyTag' when calling VendorComplianceSurveyApi->DeleteVendorComplianceSurveyTag");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag/{vendorComplianceSurveyTag}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            if (vendorComplianceSurveyTag != null) localVarPathParams.Add("vendorComplianceSurveyTag", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyTag)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurveyTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurveyTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey. Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param>
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteVendorComplianceSurveyTagAsync (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
             await DeleteVendorComplianceSurveyTagAsyncWithHttpInfo(vendorComplianceSurveyId, vendorComplianceSurveyTag);

        }

        /// <summary>
        /// Delete a tag for a vendorComplianceSurvey. Deletes an existing vendorComplianceSurvey tag using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to remove tag from</param>
        /// <param name="vendorComplianceSurveyTag">The tag to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVendorComplianceSurveyTagAsyncWithHttpInfo (int? vendorComplianceSurveyId, string vendorComplianceSurveyTag)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling DeleteVendorComplianceSurveyTag");
            // verify the required parameter 'vendorComplianceSurveyTag' is set
            if (vendorComplianceSurveyTag == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyTag' when calling DeleteVendorComplianceSurveyTag");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag/{vendorComplianceSurveyTag}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            if (vendorComplianceSurveyTag != null) localVarPathParams.Add("vendorComplianceSurveyTag", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyTag)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurveyTag: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteVendorComplianceSurveyTag: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param> 
        /// <returns>VendorComplianceSurvey</returns>
        public VendorComplianceSurvey GetDuplicateVendorComplianceSurveyById (int? vendorComplianceSurveyId)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = GetDuplicateVendorComplianceSurveyByIdWithHttpInfo(vendorComplianceSurveyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param> 
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        public ApiResponse< VendorComplianceSurvey > GetDuplicateVendorComplianceSurveyByIdWithHttpInfo (int? vendorComplianceSurveyId)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->GetDuplicateVendorComplianceSurveyById");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/duplicate/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateVendorComplianceSurveyById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateVendorComplianceSurveyById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }

        
        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        public async System.Threading.Tasks.Task<VendorComplianceSurvey> GetDuplicateVendorComplianceSurveyByIdAsync (int? vendorComplianceSurveyId)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = await GetDuplicateVendorComplianceSurveyByIdAsyncWithHttpInfo(vendorComplianceSurveyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a duplicated a vendorComplianceSurvey by id Returns a duplicated vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be duplicated.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> GetDuplicateVendorComplianceSurveyByIdAsyncWithHttpInfo (int? vendorComplianceSurveyId)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling GetDuplicateVendorComplianceSurveyById");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/duplicate/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateVendorComplianceSurveyById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetDuplicateVendorComplianceSurveyById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }
        
        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>List&lt;VendorComplianceSurvey&gt;</returns>
        public List<VendorComplianceSurvey> GetVendorComplianceSurveyByFilter (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<VendorComplianceSurvey>> localVarResponse = GetVendorComplianceSurveyByFilterWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param> 
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param> 
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param> 
        /// <param name="sort">Sort results by specified field. (optional)</param> 
        /// <returns>ApiResponse of List&lt;VendorComplianceSurvey&gt;</returns>
        public ApiResponse< List<VendorComplianceSurvey> > GetVendorComplianceSurveyByFilterWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<List<VendorComplianceSurvey>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VendorComplianceSurvey>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VendorComplianceSurvey>)));
            
        }

        
        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of List&lt;VendorComplianceSurvey&gt;</returns>
        public async System.Threading.Tasks.Task<List<VendorComplianceSurvey>> GetVendorComplianceSurveyByFilterAsync (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
             ApiResponse<List<VendorComplianceSurvey>> localVarResponse = await GetVendorComplianceSurveyByFilterAsyncWithHttpInfo(filter, page, limit, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search vendorComplianceSurveys by filter Returns the list of vendorComplianceSurveys that match the given filter.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Query string, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <param name="sort">Sort results by specified field. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;VendorComplianceSurvey&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<VendorComplianceSurvey>>> GetVendorComplianceSurveyByFilterAsyncWithHttpInfo (string filter = null, int? page = null, int? limit = null, string sort = null)
        {
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/search";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyByFilter: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<VendorComplianceSurvey>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VendorComplianceSurvey>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VendorComplianceSurvey>)));
            
        }
        
        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param> 
        /// <returns>VendorComplianceSurvey</returns>
        public VendorComplianceSurvey GetVendorComplianceSurveyById (int? vendorComplianceSurveyId)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = GetVendorComplianceSurveyByIdWithHttpInfo(vendorComplianceSurveyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param> 
        /// <returns>ApiResponse of VendorComplianceSurvey</returns>
        public ApiResponse< VendorComplianceSurvey > GetVendorComplianceSurveyByIdWithHttpInfo (int? vendorComplianceSurveyId)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->GetVendorComplianceSurveyById");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }

        
        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of VendorComplianceSurvey</returns>
        public async System.Threading.Tasks.Task<VendorComplianceSurvey> GetVendorComplianceSurveyByIdAsync (int? vendorComplianceSurveyId)
        {
             ApiResponse<VendorComplianceSurvey> localVarResponse = await GetVendorComplianceSurveyByIdAsyncWithHttpInfo(vendorComplianceSurveyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a vendorComplianceSurvey by id Returns the vendorComplianceSurvey identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to be returned.</param>
        /// <returns>Task of ApiResponse (VendorComplianceSurvey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VendorComplianceSurvey>> GetVendorComplianceSurveyByIdAsyncWithHttpInfo (int? vendorComplianceSurveyId)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling GetVendorComplianceSurveyById");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyById: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<VendorComplianceSurvey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VendorComplianceSurvey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VendorComplianceSurvey)));
            
        }
        
        /// <summary>
        /// Get the tags for a vendorComplianceSurvey. Get all existing vendorComplianceSurvey tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param> 
        /// <returns></returns>
        public void GetVendorComplianceSurveyTags (int? vendorComplianceSurveyId)
        {
             GetVendorComplianceSurveyTagsWithHttpInfo(vendorComplianceSurveyId);
        }

        /// <summary>
        /// Get the tags for a vendorComplianceSurvey. Get all existing vendorComplianceSurvey tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetVendorComplianceSurveyTagsWithHttpInfo (int? vendorComplianceSurveyId)
        {
            
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null)
                throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling VendorComplianceSurveyApi->GetVendorComplianceSurveyTags");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Get the tags for a vendorComplianceSurvey. Get all existing vendorComplianceSurvey tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetVendorComplianceSurveyTagsAsync (int? vendorComplianceSurveyId)
        {
             await GetVendorComplianceSurveyTagsAsyncWithHttpInfo(vendorComplianceSurveyId);

        }

        /// <summary>
        /// Get the tags for a vendorComplianceSurvey. Get all existing vendorComplianceSurvey tags.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vendorComplianceSurveyId">Id of the vendorComplianceSurvey to get tags for</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetVendorComplianceSurveyTagsAsyncWithHttpInfo (int? vendorComplianceSurveyId)
        {
            // verify the required parameter 'vendorComplianceSurveyId' is set
            if (vendorComplianceSurveyId == null) throw new ApiException(400, "Missing required parameter 'vendorComplianceSurveyId' when calling GetVendorComplianceSurveyTags");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/{vendorComplianceSurveyId}/tag";
    
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
            if (vendorComplianceSurveyId != null) localVarPathParams.Add("vendorComplianceSurveyId", Configuration.ApiClient.ParameterToString(vendorComplianceSurveyId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyTags: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetVendorComplianceSurveyTags: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param> 
        /// <returns></returns>
        public void UpdateVendorComplianceSurvey (VendorComplianceSurvey body)
        {
             UpdateVendorComplianceSurveyWithHttpInfo(body);
        }

        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateVendorComplianceSurveyWithHttpInfo (VendorComplianceSurvey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VendorComplianceSurveyApi->UpdateVendorComplianceSurvey");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateVendorComplianceSurveyAsync (VendorComplianceSurvey body)
        {
             await UpdateVendorComplianceSurveyAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a vendorComplianceSurvey Updates an existing vendorComplianceSurvey using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateVendorComplianceSurveyAsyncWithHttpInfo (VendorComplianceSurvey body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateVendorComplianceSurvey");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurvey: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a vendorComplianceSurvey custom fields Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param> 
        /// <returns></returns>
        public void UpdateVendorComplianceSurveyCustomFields (VendorComplianceSurvey body)
        {
             UpdateVendorComplianceSurveyCustomFieldsWithHttpInfo(body);
        }

        /// <summary>
        /// Update a vendorComplianceSurvey custom fields Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateVendorComplianceSurveyCustomFieldsWithHttpInfo (VendorComplianceSurvey body)
        {
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling VendorComplianceSurveyApi->UpdateVendorComplianceSurveyCustomFields");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurveyCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurveyCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update a vendorComplianceSurvey custom fields Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateVendorComplianceSurveyCustomFieldsAsync (VendorComplianceSurvey body)
        {
             await UpdateVendorComplianceSurveyCustomFieldsAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Update a vendorComplianceSurvey custom fields Updates an existing vendorComplianceSurvey custom fields using the specified data.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">VendorComplianceSurvey to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateVendorComplianceSurveyCustomFieldsAsyncWithHttpInfo (VendorComplianceSurvey body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateVendorComplianceSurveyCustomFields");
            
    
            var localVarPath = "/beta/vendorComplianceSurvey/customFields";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurveyCustomFields: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateVendorComplianceSurveyCustomFields: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
