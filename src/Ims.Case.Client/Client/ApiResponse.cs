// -----------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="sped-tx.net">
//     Copyright © 2021 sped-tx.net. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace Ims.Case.Client
{
    /// <summary>
    /// API Response.
    /// </summary>
    /// <typeparam name="T">.</typeparam>
    public class ApiResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <param name="data">Data (parsed HTTP body).</param>
        public ApiResponse(int statusCode, IDictionary<string, string> headers, T data)
        {
            StatusCode = statusCode;
            Headers = headers;
            Data = data;
        }

        /// <summary>
        /// Gets the Data
        /// Gets or sets the data (parsed HTTP body)...
        /// </summary>
        public T Data { get; private set; }

        /// <summary>
        /// Gets the Headers
        /// Gets or sets the HTTP headers...
        /// </summary>
        public IDictionary<string, string> Headers { get; private set; }

        /// <summary>
        /// Gets the StatusCode
        /// Gets or sets the status code (HTTP status code)...
        /// </summary>
        public int StatusCode { get; private set; }
    }
}
