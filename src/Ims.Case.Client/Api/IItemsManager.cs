// -----------------------------------------------------------------------
// <copyright file="ItemsManagerApi.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using Ims.Case.Client;
using Ims.Case.Model;

namespace Ims.Case.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public interface IItemsManager : IApiAccessor
    {
        /// <summary>
        /// The REST read request message for the getCFItem() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Item that is to be read from the service provider.</param>
        /// <returns>CFItem.</returns>
        CFItem GetCFItem(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItem() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Item that is to be read from the service provider.</param>
        /// <returns>Task of CFItem.</returns>
        System.Threading.Tasks.Task<CFItem> GetCFItemAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItem() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Item that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFItem).</returns>
        System.Threading.Tasks.Task<ApiResponse<CFItem>> GetCFItemAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItem() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Item that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFItem.</returns>
        ApiResponse<CFItem> GetCFItemWithHttpInfo(string sourcedId);
    }
}
