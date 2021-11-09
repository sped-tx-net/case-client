// -----------------------------------------------------------------------
// <copyright file="IAssociationsManager.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Threading.Tasks;
using Ims.Case.Client;
using Ims.Case.Model;

namespace Ims.Case.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints.
    /// </summary>
    public interface IAssociationsManager : IApiAccessor
    {
        /// <summary>
        /// The REST read request message for the getCFAssociation() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>CFAssociation.</returns>
        CFAssociation GetCFAssociation(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFAssociation() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>Task of CFAssociation.</returns>
        Task<CFAssociation> GetCFAssociationAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFAssociation() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>Task of ApiResponse (CFAssociation).</returns>
        Task<ApiResponse<CFAssociation>> GetCFAssociationAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFAssociation() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFAssociation to be supplied.</param>
        /// <returns>ApiResponse of CFAssociation.</returns>
        ApiResponse<CFAssociation> GetCFAssociationWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>CFAssociationSet.</returns>
        CFAssociationSet GetCFItemAssociations(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>Task of CFAssociationSet.</returns>
        Task<CFAssociationSet> GetCFItemAssociationsAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>Task of ApiResponse (CFAssociationSet).</returns>
        Task<ApiResponse<CFAssociationSet>> GetCFItemAssociationsAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFItemAssociations() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the CFItem for which ALL associations are to be supplied.</param>
        /// <returns>ApiResponse of CFAssociationSet.</returns>
        ApiResponse<CFAssociationSet> GetCFItemAssociationsWithHttpInfo(string sourcedId);
    }
}
