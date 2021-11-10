// -----------------------------------------------------------------------
// <copyright file="IApiAccessor.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Ims.Case.Client
{
    /// <summary>
    /// Represents configuration aspects required to interact with the API endpoints.
    /// </summary>
    public interface IApiAccessor
    {
        /// <summary>
        /// Gets or sets the configuration object..
        /// </summary>
        Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the ExceptionFactory
        /// Provides a factory method hook for the creation of exceptions...
        /// </summary>
        ExceptionFactory ExceptionFactory { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        string GetBasePath();
    }
}
