// -----------------------------------------------------------------------
// <copyright file="DocumentsManagerApi.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Ims.Case.Client;
using Ims.Case.Model;
using RestSharp;

namespace Ims.Case.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public partial class DocumentsManager : IDocumentsManager
    {
        /// <summary>
        /// Defines the _exceptionFactory.
        /// </summary>
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsManager"/> class.
        /// </summary>
        public DocumentsManager()
        {
            Configuration = Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsManager"/> class.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        public DocumentsManager(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsManager"/> class.
        /// </summary>
        /// <param name="basePath">The basePath<see cref="string"/>.</param>
        public DocumentsManager(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets or sets the configuration object...
        /// </summary>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the ExceptionFactory
        /// Provides a factory method hook for the creation of exceptions....
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header.</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<string, string> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
        }

        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call. This is a request to the Service Provider to provide all of the Competency Framework Documents.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>CFDocumentSet.</returns>
        public CFDocumentSet GetAllCFDocuments(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null)
        {
            ApiResponse<CFDocumentSet> localVarResponse = GetAllCFDocumentsWithHttpInfo(limit, offset, sort, orderBy, filter, fields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call. This is a request to the Service Provider to provide all of the Competency Framework Documents.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>Task of CFDocumentSet.</returns>
        public async System.Threading.Tasks.Task<CFDocumentSet> GetAllCFDocumentsAsync(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null)
        {
            ApiResponse<CFDocumentSet> localVarResponse = await GetAllCFDocumentsAsyncWithHttpInfo(limit, offset, sort, orderBy, filter, fields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call. This is a request to the Service Provider to provide all of the Competency Framework Documents.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>Task of ApiResponse (CFDocumentSet).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CFDocumentSet>> GetAllCFDocumentsAsyncWithHttpInfo(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null)
        {

            var localVarPath = "/CFDocuments";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "orderBy", orderBy)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (fields != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("multi", "fields", fields)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCFDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFDocumentSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFDocumentSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFDocumentSet)));
        }

        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call. This is a request to the Service Provider to provide all of the Competency Framework Documents.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>ApiResponse of CFDocumentSet.</returns>
        public ApiResponse<CFDocumentSet> GetAllCFDocumentsWithHttpInfo(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null)
        {

            var localVarPath = "/CFDocuments";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (offset != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "offset", offset)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            if (orderBy != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "orderBy", orderBy)); // query parameter
            if (filter != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "filter", filter)); // query parameter
            if (fields != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("multi", "fields", fields)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAllCFDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFDocumentSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFDocumentSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFDocumentSet)));
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// The REST read request message for the getCFDocument() API call. This is a request to the service provider to provide the information for the specific Competency Framework Document. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>CFDocument.</returns>
        public CFDocument GetCFDocument(string sourcedId)
        {
            ApiResponse<CFDocument> localVarResponse = GetCFDocumentWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFDocument() API call. This is a request to the service provider to provide the information for the specific Competency Framework Document. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>Task of CFDocument.</returns>
        public async System.Threading.Tasks.Task<CFDocument> GetCFDocumentAsync(string sourcedId)
        {
            ApiResponse<CFDocument> localVarResponse = await GetCFDocumentAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFDocument() API call. This is a request to the service provider to provide the information for the specific Competency Framework Document. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFDocument).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CFDocument>> GetCFDocumentAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DocumentsManagerApi->GetCFDocument");

            var localVarPath = "/CFDocuments/{sourcedId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sourcedId != null) localVarPathParams.Add("sourcedId", Configuration.ApiClient.ParameterToString(sourcedId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCFDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFDocument)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFDocument)));
        }

        /// <summary>
        /// The REST read request message for the getCFDocument() API call. This is a request to the service provider to provide the information for the specific Competency Framework Document. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFDocument.</returns>
        public ApiResponse<CFDocument> GetCFDocumentWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DocumentsManagerApi->GetCFDocument");

            var localVarPath = "/CFDocuments/{sourcedId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sourcedId != null) localVarPathParams.Add("sourcedId", Configuration.ApiClient.ParameterToString(sourcedId)); // path parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetCFDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFDocument)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFDocument)));
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The basePath<see cref="string"/>.</param>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
        }
    }
}
