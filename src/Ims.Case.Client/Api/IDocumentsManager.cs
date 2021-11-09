// -----------------------------------------------------------------------
// <copyright file="DocumentsManagerApi.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;
using Ims.Case.Client;
using Ims.Case.Model;

namespace Ims.Case.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public interface IDocumentsManager : IApiAccessor
    {
        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>CFDocumentSet.</returns>
        CFDocumentSet GetAllCFDocuments(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null);

        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>Task of CFDocumentSet.</returns>
        System.Threading.Tasks.Task<CFDocumentSet> GetAllCFDocumentsAsync(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null);

        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>Task of ApiResponse (CFDocumentSet).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFDocumentSet>> GetAllCFDocumentsAsyncWithHttpInfo(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null);

        /// <summary>
        /// The REST read request message for the getAllCFDocuments() API call.
        /// </summary>
        /// <param name="limit">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;limit&#x27; defines the download segmentation value i.e. the maximum number of records to be contained in the response. The form of implementation is described in the corresponding binding document(s). (optional, default to 100).</param>
        /// <param name="offset">This is used as part of the data pagination mechanism to control the download rate of data. The &#x27;offset&#x27; is the number of the first record to be supplied in the segmented response message. The form of implementation is described in the corresponding binding document(s). (optional, default to 0).</param>
        /// <param name="sort">This is used as part of the sorting mechanism to be use by the service provider. The &#x27;sort&#x27; identifies the sort criteria to be used for the records in the response message. Use with the orderBy parameter. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="orderBy">This is used as part of the sorting mechanism to be use by the service provider. This defines the form of ordering for response to the sorted request i.e. ascending (asc) or descending (desc). The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="filter">This is used for the data filtering mechanism to be applied by the service provider. It defines the filtering rules to be applied when identifying the records to be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <param name="fields">This is used as part of the field selection mechanism to be applied by the service provider. This identifies the range of fields that should be supplied in the response message. The form of implementation is described in the corresponding binding document(s). (optional).</param>
        /// <returns>ApiResponse of CFDocumentSet.</returns>
        ApiResponse<CFDocumentSet> GetAllCFDocumentsWithHttpInfo(int? limit = null, int? offset = null, string sort = null, string orderBy = null, string filter = null, List<string> fields = null);

        /// <summary>
        /// The REST read request message for the getCFDocument() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>CFDocument.</returns>
        CFDocument GetCFDocument(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFDocument() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>Task of CFDocument.</returns>
        System.Threading.Tasks.Task<CFDocument> GetCFDocumentAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFDocument() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFDocument).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFDocument>> GetCFDocumentAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFDocument() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Document that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFDocument.</returns>
        ApiResponse<CFDocument> GetCFDocumentWithHttpInfo(string sourcedId);
    }
}
