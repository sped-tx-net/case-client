// -----------------------------------------------------------------------
// <copyright file="IReadableConfiguration.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace Ims.Case.Client
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadableConfiguration
    {
        /// <summary>
        /// Gets the access token...
        /// </summary>
        string AccessToken { get; }

        /// <summary>
        /// Gets the API key...
        /// </summary>
        IDictionary<string, string> ApiKey { get; }

        /// <summary>
        /// Gets the API key prefix...
        /// </summary>
        IDictionary<string, string> ApiKeyPrefix { get; }

        /// <summary>
        /// Gets the base path...
        /// </summary>
        string BasePath { get; }

        /// <summary>
        /// Gets the date time format...
        /// </summary>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default header...
        /// </summary>
        IDictionary<string, string> DefaultHeader { get; }

        /// <summary>
        /// Gets the Password.
        /// </summary>
        string Password { get; }

        /// <summary>
        /// Gets the temp folder path...
        /// </summary>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)..
        /// </summary>
        int Timeout { get; }

        /// <summary>
        /// Gets the user agent...
        /// </summary>
        string UserAgent { get; }

        /// <summary>
        /// Gets the Username.
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        string GetApiKeyWithPrefix(string apiKeyIdentifier);
    }
}
