// -----------------------------------------------------------------------
// <copyright file="RubricsManagerApi.cs" company="sped-tx.net">
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
    public interface IRubricsManager : IApiAccessor
    {
        /// <summary>
        /// The REST read request message for the getCFRubric() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Rubric that is to be read from the service provider.</param>
        /// <returns>CFRubric.</returns>
        CFRubric GetCFRubric(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFRubric() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Rubric that is to be read from the service provider.</param>
        /// <returns>Task of CFRubric.</returns>
        Task<CFRubric> GetCFRubricAsync(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFRubric() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Rubric that is to be read from the service provider.</param>
        /// <returns>Task of ApiResponse (CFRubric).</returns>
        Task<ApiResponse<CFRubric>> GetCFRubricAsyncWithHttpInfo(string sourcedId);

        /// <summary>
        /// The REST read request message for the getCFRubric() API call.
        /// </summary>
        /// <param name="sourcedId">The UUID that identifies the Competency Framework Rubric that is to be read from the service provider.</param>
        /// <returns>ApiResponse of CFRubric.</returns>
        ApiResponse<CFRubric> GetCFRubricWithHttpInfo(string sourcedId);
    }
}
