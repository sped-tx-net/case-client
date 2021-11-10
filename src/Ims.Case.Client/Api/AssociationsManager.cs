// -----------------------------------------------------------------------
// <copyright file="AssociationsManager.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Ims.Case.Client;
using Ims.Case.Model;
using RestSharp;

namespace Ims.Case.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public partial class AssociationsManager : IAssociationsManager
    {
        /// <summary>
        /// Defines the _exceptionFactory.
        /// </summary>
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationsManager"/> class.
        /// </summary>
        public AssociationsManager()
        {
            Configuration = Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationsManager"/> class.
        /// </summary>
        /// <param name="configuration">An instance of Configuration.</param>
        public AssociationsManager(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationsManager"/> class.
        /// </summary>
        /// <param name="basePath">The basePath<see cref="string"/>.</param>
        public AssociationsManager(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets or sets the configuration object....
        /// </summary>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the ExceptionFactory
        /// Provides a factory method hook for the creation of exceptions.....
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
        /// The REST read request message for the getCFAssociation() API call. This is a request to the service provider to provide the information for the specific Competency Framework Association. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>CFAssociation.</returns>
        public CFAssociation GetCFAssociation(string sourcedId)
        {
            ApiResponse<CFAssociation> localVarResponse = GetCFAssociationWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFAssociation() API call. This is a request to the service provider to provide the information for the specific Competency Framework Association. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>Task of CFAssociation.</returns>
        public async Task<CFAssociation> GetCFAssociationAsync(string sourcedId)
        {
            ApiResponse<CFAssociation> localVarResponse = await GetCFAssociationAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFAssociation() API call. This is a request to the service provider to provide the information for the specific Competency Framework Association. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>Task of ApiResponse (CFAssociation).</returns>
        public async Task<ApiResponse<CFAssociation>> GetCFAssociationAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling AssociationsManagerApi->GetCFAssociation");

            var localVarPath = "/CFAssociations/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFAssociation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFAssociation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFAssociation)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFAssociation)));
        }

        /// <summary>
        /// The REST read request message for the getCFAssociation() API call. This is a request to the service provider to provide the information for the specific Competency Framework Association. If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>ApiResponse of CFAssociation.</returns>
        public ApiResponse<CFAssociation> GetCFAssociationWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling AssociationsManagerApi->GetCFAssociation");

            var localVarPath = "/CFAssociations/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFAssociation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFAssociation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFAssociation)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFAssociation)));
        }

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call. This is a request to the Service Provider to provide the all of the Competency Associations for the specified CFItem and the information about the CFItem itself.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>CFAssociationSet.</returns>
        public CFAssociationSet GetCFItemAssociations(string sourcedId)
        {
            ApiResponse<CFAssociationSet> localVarResponse = GetCFItemAssociationsWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call. This is a request to the Service Provider to provide the all of the Competency Associations for the specified CFItem and the information about the CFItem itself.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>Task of CFAssociationSet.</returns>
        public async Task<CFAssociationSet> GetCFItemAssociationsAsync(string sourcedId)
        {
            ApiResponse<CFAssociationSet> localVarResponse = await GetCFItemAssociationsAsyncWithHttpInfo(sourcedId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call. This is a request to the Service Provider to provide the all of the Competency Associations for the specified CFItem and the information about the CFItem itself.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>Task of ApiResponse (CFAssociationSet).</returns>
        public async Task<ApiResponse<CFAssociationSet>> GetCFItemAssociationsAsyncWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling AssociationsManagerApi->GetCFItemAssociations");

            var localVarPath = "/CFItemAssociations/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFItemAssociations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFAssociationSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFAssociationSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFAssociationSet)));
        }

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call. This is a request to the Service Provider to provide the all of the Competency Associations for the specified CFItem and the information about the CFItem itself.  If the identified record cannot be found then the &#x27;unknownobject&#x27; status code must be reported.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>ApiResponse of CFAssociationSet.</returns>
        public ApiResponse<CFAssociationSet> GetCFItemAssociationsWithHttpInfo(string sourcedId)
        {
            // verify the required parameter 'sourcedId' is set
            if (sourcedId == null)
                throw new ApiException(400, "Missing required parameter 'sourcedId' when calling AssociationsManagerApi->GetCFItemAssociations");

            var localVarPath = "/CFItemAssociations/{sourcedId}";
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
                Exception exception = ExceptionFactory("GetCFItemAssociations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CFAssociationSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CFAssociationSet)Configuration.ApiClient.Deserialize(localVarResponse, typeof(CFAssociationSet)));
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
