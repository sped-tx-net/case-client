// -----------------------------------------------------------------------
// <copyright file="DefinitionsManagerApi.cs" company="sped-tx.net">
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
    public interface IDefinitionsManager : IApiAccessor
    {
        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>CFAssociationGrouping.</returns>
        CFAssociationGrouping GetCFAssociationGrouping(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>Task of CFAssociationGrouping.</returns>
        System.Threading.Tasks.Task<CFAssociationGrouping> GetCFAssociationGroupingAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFAssociationGrouping).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFAssociationGrouping>> GetCFAssociationGroupingAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFAssociationGrouping.</returns>
        ApiResponse<CFAssociationGrouping> GetCFAssociationGroupingWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFConcept() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>CFConceptSet.</returns>
        CFConceptSet GetCFConcept(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFConcept() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>Task of CFConceptSet.</returns>
        System.Threading.Tasks.Task<CFConceptSet> GetCFConceptAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFConcept() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFConceptSet).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFConceptSet>> GetCFConceptAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFConcept() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFConceptSet.</returns>
        ApiResponse<CFConceptSet> GetCFConceptWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemType() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>CFItemTypeSet.</returns>
        CFItemTypeSet GetCFItemType(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemType() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>Task of CFItemTypeSet.</returns>
        System.Threading.Tasks.Task<CFItemTypeSet> GetCFItemTypeAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemType() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFItemTypeSet).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFItemTypeSet>> GetCFItemTypeAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemType() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFItemTypeSet.</returns>
        ApiResponse<CFItemTypeSet> GetCFItemTypeWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFLicense() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>CFLicense.</returns>
        CFLicense GetCFLicense(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFLicense() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>Task of CFLicense.</returns>
        System.Threading.Tasks.Task<CFLicense> GetCFLicenseAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFLicense() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFLicense).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFLicense>> GetCFLicenseAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFLicense() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFLicense.</returns>
        ApiResponse<CFLicense> GetCFLicenseWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFSubject() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>CFSubjectSet.</returns>
        CFSubjectSet GetCFSubject(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFSubject() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>Task of CFSubjectSet.</returns>
        System.Threading.Tasks.Task<CFSubjectSet> GetCFSubjectAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFSubject() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFSubjectSet).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFSubjectSet>> GetCFSubjectAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFSubject() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFSubjectSet.</returns>
        ApiResponse<CFSubjectSet> GetCFSubjectWithHttpInfo(string sourcedId);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public partial class DefinitionsManager : IDefinitionsManager
    {
        /// <summary>
        /// Defines the _exceptionFactory.
        /// </summary>
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionsManager"/> class.
        /// </summary>
        public DefinitionsManager()
        {
            Configuration = Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionsManager"/> class.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        public DefinitionsManager(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionsManager"/> class.
        /// </summary>
        /// <param name="basePath">The basePath<see cref="string"/>.</param>
        public DefinitionsManager(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets or sets the configuration object..
        /// </summary>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the ExceptionFactory
        /// Provides a factory method hook for the creation of exceptions...
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
        /// Gets the base path of the API client.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call. This is a request to the Service Provider to provide the specified Competency Framework Association Grouping.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>CFAssociationGrouping.</returns>
        public CFAssociationGrouping GetCFAssociationGrouping(string sourcedId)
        {
            ApiResponse<CFAssociationGrouping> localVarResponse = GetCFAssociationGroupingWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call. This is a request to the Service Provider to provide the specified Competency Framework Association Grouping.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>Task of CFAssociationGrouping.</returns>
        public async System.Threading.Tasks.Task<CFAssociationGrouping> GetCFAssociationGroupingAsync(string sourcedId)
        {
            ApiResponse<CFAssociationGrouping> localVarResponse = await GetCFAssociationGroupingAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call. This is a request to the Service Provider to provide the specified Competency Framework Association Grouping.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFAssociationGrouping).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CFAssociationGrouping>> GetCFAssociationGroupingAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFAssociationGrouping");

            var localVarPath = "/CFAssociationGroupings/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFAssociationGrouping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFAssociationGrouping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFAssociationGrouping)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFAssociationGrouping)));
        }

        /// <summary>
        /// The REST read request message for the getCFAssociationGrouping() API call. This is a request to the Service Provider to provide the specified Competency Framework Association Grouping.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework AssociationGrouping that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFAssociationGrouping.</returns>
        public ApiResponse<CFAssociationGrouping> GetCFAssociationGroupingWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFAssociationGrouping");

            var localVarPath = "/CFAssociationGroupings/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFAssociationGrouping", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFAssociationGrouping>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFAssociationGrouping)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFAssociationGrouping)));
        }

        /// <summary>
        /// The REST read request message for the getCFConcept() API call. This is a request to the Service Provider to provide the specified Competency Framework Concept and the set of children CFConcepts as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>CFConceptSet.</returns>
        public CFConceptSet GetCFConcept(string sourcedId)
        {
            ApiResponse<CFConceptSet> localVarResponse = GetCFConceptWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFConcept() API call. This is a request to the Service Provider to provide the specified Competency Framework Concept and the set of children CFConcepts as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>Task of CFConceptSet.</returns>
        public async System.Threading.Tasks.Task<CFConceptSet> GetCFConceptAsync(string sourcedId)
        {
            ApiResponse<CFConceptSet> localVarResponse = await GetCFConceptAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFConcept() API call. This is a request to the Service Provider to provide the specified Competency Framework Concept and the set of children CFConcepts as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFConceptSet).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CFConceptSet>> GetCFConceptAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFConcept");

            var localVarPath = "/CFConcepts/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFConcept", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFConceptSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFConceptSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFConceptSet)));
        }

        /// <summary>
        /// The REST read request message for the getCFConcept() API call. This is a request to the Service Provider to provide the specified Competency Framework Concept and the set of children CFConcepts as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Concept that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFConceptSet.</returns>
        public ApiResponse<CFConceptSet> GetCFConceptWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFConcept");

            var localVarPath = "/CFConcepts/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFConcept", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFConceptSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFConceptSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFConceptSet)));
        }

        /// <summary>
        /// The REST read request message for the getCFItemType() API call. This is a request to the Service Provider to provide the specified Competency Framework Item Type and the set of children CFItemTypes as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>CFItemTypeSet.</returns>
        public CFItemTypeSet GetCFItemType(string sourcedId)
        {
            ApiResponse<CFItemTypeSet> localVarResponse = GetCFItemTypeWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFItemType() API call. This is a request to the Service Provider to provide the specified Competency Framework Item Type and the set of children CFItemTypes as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>Task of CFItemTypeSet.</returns>
        public async System.Threading.Tasks.Task<CFItemTypeSet> GetCFItemTypeAsync(string sourcedId)
        {
            ApiResponse<CFItemTypeSet> localVarResponse = await GetCFItemTypeAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFItemType() API call. This is a request to the Service Provider to provide the specified Competency Framework Item Type and the set of children CFItemTypes as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFItemTypeSet).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CFItemTypeSet>> GetCFItemTypeAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFItemType");

            var localVarPath = "/CFItemTypes/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFItemType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFItemTypeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFItemTypeSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFItemTypeSet)));
        }

        /// <summary>
        /// The REST read request message for the getCFItemType() API call. This is a request to the Service Provider to provide the specified Competency Framework Item Type and the set of children CFItemTypes as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework ItemType that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFItemTypeSet.</returns>
        public ApiResponse<CFItemTypeSet> GetCFItemTypeWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFItemType");

            var localVarPath = "/CFItemTypes/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFItemType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFItemTypeSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFItemTypeSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFItemTypeSet)));
        }

        /// <summary>
        /// The REST read request message for the getCFLicense() API call. This is a request to the Service Provider to provide the specified Competency Framework License.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>CFLicense.</returns>
        public CFLicense GetCFLicense(string sourcedId)
        {
            ApiResponse<CFLicense> localVarResponse = GetCFLicenseWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFLicense() API call. This is a request to the Service Provider to provide the specified Competency Framework License.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>Task of CFLicense.</returns>
        public async System.Threading.Tasks.Task<CFLicense> GetCFLicenseAsync(string sourcedId)
        {
            ApiResponse<CFLicense> localVarResponse = await GetCFLicenseAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFLicense() API call. This is a request to the Service Provider to provide the specified Competency Framework License.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFLicense).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CFLicense>> GetCFLicenseAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFLicense");

            var localVarPath = "/CFLicenses/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFLicense", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFLicense>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFLicense)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFLicense)));
        }

        /// <summary>
        /// The REST read request message for the getCFLicense() API call. This is a request to the Service Provider to provide the specified Competency Framework License.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework License that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFLicense.</returns>
        public ApiResponse<CFLicense> GetCFLicenseWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFLicense");

            var localVarPath = "/CFLicenses/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFLicense", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFLicense>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFLicense)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFLicense)));
        }

        /// <summary>
        /// The REST read request message for the getCFSubject() API call. This is a request to the Service Provider to provide the specified Competency Framework Subject and the set of children CFSubjects as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>CFSubjectSet.</returns>
        public CFSubjectSet GetCFSubject(string sourcedId)
        {
            ApiResponse<CFSubjectSet> localVarResponse = GetCFSubjectWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFSubject() API call. This is a request to the Service Provider to provide the specified Competency Framework Subject and the set of children CFSubjects as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>Task of CFSubjectSet.</returns>
        public async System.Threading.Tasks.Task<CFSubjectSet> GetCFSubjectAsync(string sourcedId)
        {
            ApiResponse<CFSubjectSet> localVarResponse = await GetCFSubjectAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFSubject() API call. This is a request to the Service Provider to provide the specified Competency Framework Subject and the set of children CFSubjects as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFSubjectSet).</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CFSubjectSet>> GetCFSubjectAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFSubject");

            var localVarPath = "/CFSubjects/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFSubject", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFSubjectSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFSubjectSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFSubjectSet)));
        }

        /// <summary>
        /// The REST read request message for the getCFSubject() API call. This is a request to the Service Provider to provide the specified Competency Framework Subject and the set of children CFSubjects as identified by the hierarchy codes.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Subject that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFSubjectSet.</returns>
        public ApiResponse<CFSubjectSet> GetCFSubjectWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling DefinitionsManagerApi->GetCFSubject");

            var localVarPath = "/CFSubjects/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFSubject", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFSubjectSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFSubjectSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFSubjectSet)));
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
